using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Manufacture.Common
{
	// Token: 0x0200466F RID: 18031
	public class OpenHelpRoleButton : UiPanelBase
	{
		// Token: 0x0602D59D RID: 185757 RVA: 0x00CB2AB4 File Offset: 0x00CB0CB4
		[NullableContext(1)]
		public OpenHelpRoleButton(UUIItem uiItem)
		{
			base.CreateThenShowByActor(uiItem.GetOwner(), null);
		}

		// Token: 0x0602D59E RID: 185758 RVA: 0x00CB2ACC File Offset: 0x00CB0CCC
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
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OpenHelpRole));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0602D59F RID: 185759 RVA: 0x00CB2B94 File Offset: 0x00CB0D94
		public void RefreshIcon()
		{
			int? currentRoleId = CommonManager.Instance.GetCurrentRoleId();
			RoleDataBase roleDataById = RoleModel.Instance.GetRoleDataById(currentRoleId.Value, true);
			base.SetRoleIcon(roleDataById.GetRoleConfig().RoleHeadIcon, base.GetTexture(1), currentRoleId.Value, null, null);
		}

		// Token: 0x0602D5A0 RID: 185760 RVA: 0x00CB2BEC File Offset: 0x00CB0DEC
		public void RefreshRedDot(int itemId)
		{
			int? currentRoleId = CommonManager.Instance.GetCurrentRoleId();
			base.GetItem(2).SetUIActive(CommonManager.Instance.CheckIsBuffEx(currentRoleId.Value, itemId));
		}

		// Token: 0x0602D5A1 RID: 185761 RVA: 0x00CB2C22 File Offset: 0x00CB0E22
		[NullableContext(1)]
		public void BindOnCallback(Action onCallback)
		{
			this.OnCallback = onCallback;
		}

		// Token: 0x0602D5A2 RID: 185762 RVA: 0x00CB2C2B File Offset: 0x00CB0E2B
		private void OpenHelpRole()
		{
			if (this.OnCallback != null)
			{
				this.OnCallback();
			}
		}

		// Token: 0x040184B0 RID: 99504
		[Nullable(2)]
		private Action OnCallback;

		// Token: 0x0200A283 RID: 41603
		private class EOpenHelpRoleDefine
		{
			// Token: 0x040326EE RID: 206574
			public const int OpenButton = 0;

			// Token: 0x040326EF RID: 206575
			public const int RoleIconTexture = 1;

			// Token: 0x040326F0 RID: 206576
			public const int RedDotItem = 2;
		}
	}
}
