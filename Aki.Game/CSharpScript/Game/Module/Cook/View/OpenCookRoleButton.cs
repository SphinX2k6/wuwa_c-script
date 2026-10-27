using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Cook.View
{
	// Token: 0x02005B2B RID: 23339
	[NullableContext(1)]
	[Nullable(0)]
	public class OpenCookRoleButton : UiPanelBase
	{
		// Token: 0x0603B18C RID: 242060 RVA: 0x00E17DD8 File Offset: 0x00E15FD8
		public OpenCookRoleButton(UUIItem uiItem)
		{
			base.CreateThenShowByActor(uiItem.GetOwner(), null);
		}

		// Token: 0x0603B18D RID: 242061 RVA: 0x00E17DF0 File Offset: 0x00E15FF0
		protected unsafe override void OnRegisterComponent()
		{
			int num = 3;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action(delegate()
			{
				this.OpenCookRole();
			}));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0603B18E RID: 242062 RVA: 0x00E17EB8 File Offset: 0x00E160B8
		public void RefreshIcon(int roleId)
		{
			RoleDataBase roleDataById = RoleModel.Instance.GetRoleDataById(roleId, true);
			base.SetRoleIcon(roleDataById.GetRoleConfig().RoleHeadIcon, base.GetTexture(1), roleId, null, null);
		}

		// Token: 0x0603B18F RID: 242063 RVA: 0x00E17EF8 File Offset: 0x00E160F8
		public void RefreshRedDot(int roleId, int itemId)
		{
			base.GetItem(2).SetUIActive(CookController.Instance.CheckIsBuffEx(roleId, itemId));
		}

		// Token: 0x0603B190 RID: 242064 RVA: 0x00E17F12 File Offset: 0x00E16112
		public void BindOnCallback(Action onCallback)
		{
			this.OnCallback = onCallback;
		}

		// Token: 0x0603B191 RID: 242065 RVA: 0x00E17F1B File Offset: 0x00E1611B
		private void OpenCookRole()
		{
			if (this.OnCallback != null)
			{
				this.OnCallback();
			}
		}

		// Token: 0x0401ECFD RID: 126205
		[Nullable(2)]
		private Action OnCallback;
	}
}
