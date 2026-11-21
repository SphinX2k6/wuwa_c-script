using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Cook.View
{
	// Token: 0x02004B0C RID: 19212
	[NullableContext(1)]
	[Nullable(0)]
	public class OpenCookRoleButton : UiPanelBase
	{
		// Token: 0x060300FE RID: 196862 RVA: 0x00D68AF0 File Offset: 0x00D66CF0
		public OpenCookRoleButton(UUIItem uiItem)
		{
			base.CreateThenShowByActor(uiItem.GetOwner(), null);
		}

		// Token: 0x060300FF RID: 196863 RVA: 0x00D68B08 File Offset: 0x00D66D08
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

		// Token: 0x06030100 RID: 196864 RVA: 0x00D68BD0 File Offset: 0x00D66DD0
		public void RefreshIcon(int roleId)
		{
			RoleDataBase roleDataById = RoleModel.Instance.GetRoleDataById(roleId, true);
			base.SetRoleIcon(roleDataById.GetRoleConfig().RoleHeadIcon, base.GetTexture(1), roleId, null, null);
		}

		// Token: 0x06030101 RID: 196865 RVA: 0x00D68C10 File Offset: 0x00D66E10
		public void RefreshRedDot(int roleId, int itemId)
		{
			base.GetItem(2).SetUIActive(CookController.Instance.CheckIsBuffEx(roleId, itemId));
		}

		// Token: 0x06030102 RID: 196866 RVA: 0x00D68C2A File Offset: 0x00D66E2A
		public void BindOnCallback(Action onCallback)
		{
			this.OnCallback = onCallback;
		}

		// Token: 0x06030103 RID: 196867 RVA: 0x00D68C33 File Offset: 0x00D66E33
		private void OpenCookRole()
		{
			if (this.OnCallback != null)
			{
				this.OnCallback();
			}
		}

		// Token: 0x040197B9 RID: 104377
		[Nullable(2)]
		private Action OnCallback;
	}
}
