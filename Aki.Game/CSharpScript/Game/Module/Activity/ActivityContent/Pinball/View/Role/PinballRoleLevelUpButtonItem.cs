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
	// Token: 0x02005292 RID: 21138
	[NullableContext(2)]
	[Nullable(0)]
	public class PinballRoleLevelUpButtonItem : UiPanelBase
	{
		// Token: 0x060349C4 RID: 215492 RVA: 0x00EB6E78 File Offset: 0x00EB5078
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

		// Token: 0x060349C5 RID: 215493 RVA: 0x00EB6EE4 File Offset: 0x00EB50E4
		protected override UniTask OnBeforeStartAsync()
		{
			PinballRoleLevelUpButtonItem.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<PinballRoleLevelUpButtonItem.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060349C6 RID: 215494 RVA: 0x00EB6F28 File Offset: 0x00EB5128
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

		// Token: 0x060349C7 RID: 215495 RVA: 0x00EB6FF4 File Offset: 0x00EB51F4
		private void OnConfirm()
		{
			if (this.Data == null)
			{
				return;
			}
			this.Data.ConfirmDelegate(this.Data.Times);
		}

		// Token: 0x0401BDF8 RID: 114168
		private IPinballRoleLevelUpButtonItemData Data;

		// Token: 0x0401BDF9 RID: 114169
		private ButtonItem ConfirmButtonItem;

		// Token: 0x0401BDFA RID: 114170
		private CostItem CostItemPanel;

		// Token: 0x0200AEED RID: 44781
		[NullableContext(0)]
		private enum EComponent
		{
			// Token: 0x040360C6 RID: 221382
			ConfirmButtonItem,
			// Token: 0x040360C7 RID: 221383
			CostItem
		}
	}
}
