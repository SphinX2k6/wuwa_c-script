using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Birthday.View
{
	// Token: 0x02005C2E RID: 23598
	public class BirthdayRoleHeadItem : GridProxyAbstract<int>
	{
		// Token: 0x0603B9C1 RID: 244161 RVA: 0x00E3909C File Offset: 0x00E3729C
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

		// Token: 0x0603B9C2 RID: 244162 RVA: 0x00E39142 File Offset: 0x00E37342
		protected override void OnStart()
		{
			base.GetExtendToggle(0).CanExecuteChange.Bind(() => true);
		}

		// Token: 0x0603B9C3 RID: 244163 RVA: 0x00E39174 File Offset: 0x00E37374
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

		// Token: 0x0603B9C4 RID: 244164 RVA: 0x00E3922A File Offset: 0x00E3742A
		private void OnToggleClick(EToggleState state)
		{
			if (this.OnToggleClickCallBack != null)
			{
				this.OnToggleClickCallBack(base.GridIndex, this.RoleId);
			}
		}

		// Token: 0x0603B9C5 RID: 244165 RVA: 0x00E3924C File Offset: 0x00E3744C
		public void SetToggleState(bool state)
		{
			EToggleState state2 = state ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked;
			base.GetExtendToggle(0).SetToggleState(state2, false, false, false);
		}

		// Token: 0x0603B9C6 RID: 244166 RVA: 0x00E39272 File Offset: 0x00E37472
		public override void OnSelected(bool fireEvent)
		{
			this.SetToggleState(true);
		}

		// Token: 0x0603B9C7 RID: 244167 RVA: 0x00E3927B File Offset: 0x00E3747B
		public override void OnDeselected(bool fireEvent)
		{
			this.SetToggleState(false);
		}

		// Token: 0x0401F08C RID: 127116
		private int RoleId;

		// Token: 0x0401F08D RID: 127117
		[Nullable(2)]
		public Action<int, int> OnToggleClickCallBack;

		// Token: 0x0200BE1C RID: 48668
		private class EComponents
		{
			// Token: 0x04039544 RID: 234820
			public const int ToggleRoot = 0;

			// Token: 0x04039545 RID: 234821
			public const int TextureRoleIcon = 1;
		}
	}
}
