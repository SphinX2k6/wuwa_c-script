using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Roguelike
{
	// Token: 0x02004DDF RID: 19935
	public class RoguelikeRoleSelectItem : UiPanelBase
	{
		// Token: 0x06033749 RID: 210761 RVA: 0x00C05BA4 File Offset: 0x00C03DA4
		protected unsafe override void OnRegisterComponent()
		{
			int num = 5;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnClickRole));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0603374A RID: 210762 RVA: 0x00C05CAD File Offset: 0x00C03EAD
		private void OnClickRole()
		{
			Action<int> onClickRoleCallback = this.OnClickRoleCallback;
			if (onClickRoleCallback == null)
			{
				return;
			}
			onClickRoleCallback(this.Index);
		}

		// Token: 0x0603374B RID: 210763 RVA: 0x00C05CC8 File Offset: 0x00C03EC8
		public void Refresh(int roleId)
		{
			bool flag = roleId == 0;
			base.GetTexture(2).SetUIActive(!flag);
			base.GetItem(1).SetUIActive(!flag);
			base.GetItem(3).SetUIActive(flag);
			if (flag)
			{
				return;
			}
			RoleModel instance = RoleModel.Instance;
			RoleDataBase roleDataBase = (instance != null) ? instance.GetRoleDataById(roleId, true) : null;
			if (roleDataBase == null)
			{
				return;
			}
			string roleHeadIconCircle = roleDataBase.GetRoleConfig().RoleHeadIconCircle;
			int roleSkinId = roleDataBase.GetRoleSkinId();
			base.SetRoleSkinIcon(roleHeadIconCircle, base.GetTexture(2), roleSkinId, null, null);
		}

		// Token: 0x0603374C RID: 210764 RVA: 0x00C05D55 File Offset: 0x00C03F55
		public void ShowNewUnlockRole(bool isShow)
		{
			base.GetItem(4).SetUIActive(isShow);
		}

		// Token: 0x0401B50B RID: 111883
		[Nullable(2)]
		public Action<int> OnClickRoleCallback;

		// Token: 0x0401B50C RID: 111884
		public int Index;

		// Token: 0x0200AF64 RID: 44900
		private class EComponents
		{
			// Token: 0x04035420 RID: 218144
			public const int BtnRole = 0;

			// Token: 0x04035421 RID: 218145
			public const int PanelRole = 1;

			// Token: 0x04035422 RID: 218146
			public const int TexRole = 2;

			// Token: 0x04035423 RID: 218147
			public const int PanelEmpty = 3;

			// Token: 0x04035424 RID: 218148
			public const int PanelNewUnlock = 4;
		}
	}
}
