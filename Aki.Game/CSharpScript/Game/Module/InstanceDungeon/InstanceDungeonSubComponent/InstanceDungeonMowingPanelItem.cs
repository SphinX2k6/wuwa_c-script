using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.InstanceDungeon.InstanceDungeonSubComponent
{
	// Token: 0x020058A1 RID: 22689
	public class InstanceDungeonMowingPanelItem : UiPanelBase
	{
		// Token: 0x06039B9F RID: 236447 RVA: 0x00DB8124 File Offset: 0x00DB6324
		protected unsafe override void OnRegisterComponent()
		{
			int num = 7;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 2;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnLeftClick));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(2, new Action(this.OnRightClick));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06039BA0 RID: 236448 RVA: 0x00DB8292 File Offset: 0x00DB6492
		protected override void OnStart()
		{
			RedDotController.Instance.BindRedDot(ERedDotName.RedDotMowingRiskBuffAll, base.GetItem(1), null, 0);
			RedDotController.Instance.BindRedDot(ERedDotName.RedDotMowingRiskReward, base.GetItem(3), null, 0);
			if (this.Data != null)
			{
				this.RefreshItem();
			}
		}

		// Token: 0x06039BA1 RID: 236449 RVA: 0x00DB82D2 File Offset: 0x00DB64D2
		protected override void OnBeforeDestroy()
		{
			RedDotController.Instance.UnBindRedDot(ERedDotName.RedDotMowingRiskBuffAll);
			RedDotController.Instance.UnBindRedDot(ERedDotName.RedDotMowingRiskReward);
		}

		// Token: 0x06039BA2 RID: 236450 RVA: 0x00DB82F2 File Offset: 0x00DB64F2
		[NullableContext(1)]
		public void RefreshItemByData(InstanceDungeonMowingPanelItemData data)
		{
			this.Data = data;
			if (base.InAsyncLoading())
			{
				return;
			}
			this.RefreshItem();
		}

		// Token: 0x06039BA3 RID: 236451 RVA: 0x00DB830C File Offset: 0x00DB650C
		public void RefreshItem()
		{
			if (this.Data == null)
			{
				return;
			}
			UUIItem item = base.GetItem(6);
			if (item != null)
			{
				item.SetUIActive(this.Data.ScoreItemActive);
			}
			if (this.Data.ScoreItemActive && !string.IsNullOrEmpty(this.Data.ScoreText))
			{
				base.GetText(4).SetText(this.Data.ScoreText, true);
			}
		}

		// Token: 0x06039BA4 RID: 236452 RVA: 0x00DB8376 File Offset: 0x00DB6576
		private void OnLeftClick()
		{
			InstanceDungeonMowingPanelItemData data = this.Data;
			if (data == null)
			{
				return;
			}
			Action leftBtnClickCallBack = data.LeftBtnClickCallBack;
			if (leftBtnClickCallBack == null)
			{
				return;
			}
			leftBtnClickCallBack();
		}

		// Token: 0x06039BA5 RID: 236453 RVA: 0x00DB8392 File Offset: 0x00DB6592
		private void OnRightClick()
		{
			InstanceDungeonMowingPanelItemData data = this.Data;
			if (data == null)
			{
				return;
			}
			Action rightBtnClickCallBack = data.RightBtnClickCallBack;
			if (rightBtnClickCallBack == null)
			{
				return;
			}
			rightBtnClickCallBack();
		}

		// Token: 0x0401E26F RID: 123503
		[Nullable(2)]
		private InstanceDungeonMowingPanelItemData Data;

		// Token: 0x0200BB0A RID: 47882
		private enum EChildType
		{
			// Token: 0x04038813 RID: 231443
			LeftButton,
			// Token: 0x04038814 RID: 231444
			LeftRedDotItem,
			// Token: 0x04038815 RID: 231445
			RightButton,
			// Token: 0x04038816 RID: 231446
			RightRedDotItem,
			// Token: 0x04038817 RID: 231447
			ProgressText,
			// Token: 0x04038818 RID: 231448
			LeftItem,
			// Token: 0x04038819 RID: 231449
			ScoreItem
		}
	}
}
