using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Birthday.View
{
	// Token: 0x02004C0E RID: 19470
	public class BirthdayRoleHeadItem : GridProxyAbstract<int>
	{
		// Token: 0x0603090C RID: 198924 RVA: 0x00D8940C File Offset: 0x00D8760C
		protected unsafe override void OnRegisterComponent()
		{
			int num = 2;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIExtendToggle));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUITexture));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnToggleClick));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0603090D RID: 198925 RVA: 0x00D894B2 File Offset: 0x00D876B2
		protected override void OnStart()
		{
			base.GetExtendToggle(0).CanExecuteChange.Bind(() => true);
		}

		// Token: 0x0603090E RID: 198926 RVA: 0x00D894E4 File Offset: 0x00D876E4
		public override void Refresh(int data, bool isSelected, int gridIndex)
		{
			this.RoleId = data;
			RoleDataBase roleDataById = RoleModel.Instance.GetRoleDataById(this.RoleId, true);
			int? num = (roleDataById != null) ? new int?(roleDataById.GetRoleSkinId()) : null;
			if (num == null)
			{
				num = new int?(ConfigRoleInfoById.GetConfig(this.RoleId, true).Value.SkinId);
			}
			RoleSkin? config = ConfigRoleSkinById.GetConfig(num.Value, true);
			if (config != null)
			{
				string roleHeadIconCircle = config.Value.RoleHeadIconCircle;
				base.SetTextureByPath(roleHeadIconCircle, base.GetTexture(1), null, null);
			}
			this.SetToggleState(isSelected);
		}

		// Token: 0x0603090F RID: 198927 RVA: 0x00D8959A File Offset: 0x00D8779A
		private void OnToggleClick(EToggleState state)
		{
			if (this.OnToggleClickCallBack != null)
			{
				this.OnToggleClickCallBack(base.GridIndex, this.RoleId);
			}
		}

		// Token: 0x06030910 RID: 198928 RVA: 0x00D895BC File Offset: 0x00D877BC
		public void SetToggleState(bool state)
		{
			EToggleState state2 = state ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked;
			base.GetExtendToggle(0).SetToggleState(state2, false, false, false);
		}

		// Token: 0x06030911 RID: 198929 RVA: 0x00D895E2 File Offset: 0x00D877E2
		public override void OnSelected(bool fireEvent)
		{
			this.SetToggleState(true);
		}

		// Token: 0x06030912 RID: 198930 RVA: 0x00D895EB File Offset: 0x00D877EB
		public override void OnDeselected(bool fireEvent)
		{
			this.SetToggleState(false);
		}

		// Token: 0x04019B3D RID: 105277
		private int RoleId;

		// Token: 0x04019B3E RID: 105278
		[Nullable(2)]
		public Action<int, int> OnToggleClickCallBack;

		// Token: 0x0200A824 RID: 43044
		private class EComponents
		{
			// Token: 0x04033F07 RID: 212743
			public const int ToggleRoot = 0;

			// Token: 0x04033F08 RID: 212744
			public const int TextureRoleIcon = 1;
		}
	}
}
