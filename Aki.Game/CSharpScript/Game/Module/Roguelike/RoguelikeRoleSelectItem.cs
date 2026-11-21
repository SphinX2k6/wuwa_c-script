using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Roguelike
{
	// Token: 0x02003DA8 RID: 15784
	public class RoguelikeRoleSelectItem : UiPanelBase
	{
		// Token: 0x060285B4 RID: 165300 RVA: 0x00B4F0B4 File Offset: 0x00B4D2B4
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

		// Token: 0x060285B5 RID: 165301 RVA: 0x00B4F1BD File Offset: 0x00B4D3BD
		private void OnClickRole()
		{
			Action<int> onClickRoleCallback = this.OnClickRoleCallback;
			if (onClickRoleCallback == null)
			{
				return;
			}
			onClickRoleCallback(this.Index);
		}

		// Token: 0x060285B6 RID: 165302 RVA: 0x00B4F1D8 File Offset: 0x00B4D3D8
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

		// Token: 0x060285B7 RID: 165303 RVA: 0x00B4F265 File Offset: 0x00B4D465
		public void ShowNewUnlockRole(bool isShow)
		{
			base.GetItem(4).SetUIActive(isShow);
		}

		// Token: 0x04015EDE RID: 89822
		[Nullable(2)]
		public Action<int> OnClickRoleCallback;

		// Token: 0x04015EDF RID: 89823
		public int Index;

		// Token: 0x02009999 RID: 39321
		private class EComponents
		{
			// Token: 0x0402FE53 RID: 196179
			public const int BtnRole = 0;

			// Token: 0x0402FE54 RID: 196180
			public const int PanelRole = 1;

			// Token: 0x0402FE55 RID: 196181
			public const int TexRole = 2;

			// Token: 0x0402FE56 RID: 196182
			public const int PanelEmpty = 3;

			// Token: 0x0402FE57 RID: 196183
			public const int PanelNewUnlock = 4;
		}
	}
}
