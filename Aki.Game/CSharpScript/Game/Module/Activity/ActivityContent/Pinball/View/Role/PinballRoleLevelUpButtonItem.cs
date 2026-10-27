using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Pinball.View.Role
{
	// Token: 0x02006314 RID: 25364
	[NullableContext(2)]
	[Nullable(0)]
	public class PinballRoleLevelUpButtonItem : UiPanelBase
	{
		// Token: 0x0603FD03 RID: 261379 RVA: 0x00F6FF1C File Offset: 0x00F6E11C
		protected unsafe override void OnRegisterComponent()
		{
			int num = 2;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0603FD04 RID: 261380 RVA: 0x00F6FF88 File Offset: 0x00F6E188
		protected override UniTask OnBeforeStartAsync()
		{
			PinballRoleLevelUpButtonItem.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<PinballRoleLevelUpButtonItem.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603FD05 RID: 261381 RVA: 0x00F6FFCC File Offset: 0x00F6E1CC
		[NullableContext(1)]
		public void Refresh(IPinballRoleLevelUpButtonItemData data)
		{
			this.Data = data;
			ICostData costItemData = data.CostItemData;
			CostItem costItemPanel = this.CostItemPanel;
			if (costItemPanel != null)
			{
				costItemPanel.Refresh(costItemData);
			}
			ButtonItem confirmButtonItem = this.ConfirmButtonItem;
			if (confirmButtonItem != null)
			{
				confirmButtonItem.SetFunction(delegate(int _)
				{
					this.OnConfirm();
				});
			}
			bool flag = costItemData.Cost <= costItemData.Count;
			ButtonItem confirmButtonItem2 = this.ConfirmButtonItem;
			if (confirmButtonItem2 != null)
			{
				confirmButtonItem2.SetEnableClick(flag);
			}
			ButtonItem confirmButtonItem3 = this.ConfirmButtonItem;
			if (confirmButtonItem3 != null)
			{
				confirmButtonItem3.SetRedDotVisible(flag);
			}
			if (data.IsToMaxLevel)
			{
				ButtonItem confirmButtonItem4 = this.ConfirmButtonItem;
				if (confirmButtonItem4 == null)
				{
					return;
				}
				confirmButtonItem4.SetLocalTextNew("Pinball_Character_levelupMax", Array.Empty<object>());
				return;
			}
			else
			{
				ButtonItem confirmButtonItem5 = this.ConfirmButtonItem;
				if (confirmButtonItem5 == null)
				{
					return;
				}
				confirmButtonItem5.SetLocalTextNew("Pinball_Character_levelup", new object[]
				{
					data.Times
				});
				return;
			}
		}

		// Token: 0x0603FD06 RID: 261382 RVA: 0x00F70098 File Offset: 0x00F6E298
		private void OnConfirm()
		{
			if (this.Data == null)
			{
				return;
			}
			this.Data.ConfirmDelegate(this.Data.Times);
		}

		// Token: 0x040214C9 RID: 136393
		private IPinballRoleLevelUpButtonItemData Data;

		// Token: 0x040214CA RID: 136394
		private ButtonItem ConfirmButtonItem;

		// Token: 0x040214CB RID: 136395
		private CostItem CostItemPanel;

		// Token: 0x0200C506 RID: 50438
		[NullableContext(0)]
		private enum EComponent
		{
			// Token: 0x0403B764 RID: 243556
			ConfirmButtonItem,
			// Token: 0x0403B765 RID: 243557
			CostItem
		}
	}
}
