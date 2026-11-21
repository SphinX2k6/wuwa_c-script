using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.InstanceDungeon.InstanceDungeonSubComponent
{
	// Token: 0x02004879 RID: 18553
	public class InstanceDungeonMowingPanelItem : UiPanelBase
	{
		// Token: 0x0602EAC2 RID: 191170 RVA: 0x00D0703C File Offset: 0x00D0523C
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

		// Token: 0x0602EAC3 RID: 191171 RVA: 0x00D071AA File Offset: 0x00D053AA
		protected override void OnStart()
		{
			RedDotController.Instance.BindRedDot(ERedDotName.RedDotMowingRiskBuffAll, base.GetItem(1), null, 0);
			RedDotController.Instance.BindRedDot(ERedDotName.RedDotMowingRiskReward, base.GetItem(3), null, 0);
			if (this.Data != null)
			{
				this.RefreshItem();
			}
		}

		// Token: 0x0602EAC4 RID: 191172 RVA: 0x00D071EA File Offset: 0x00D053EA
		protected override void OnBeforeDestroy()
		{
			RedDotController.Instance.UnBindRedDot(ERedDotName.RedDotMowingRiskBuffAll);
			RedDotController.Instance.UnBindRedDot(ERedDotName.RedDotMowingRiskReward);
		}

		// Token: 0x0602EAC5 RID: 191173 RVA: 0x00D0720A File Offset: 0x00D0540A
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

		// Token: 0x0602EAC6 RID: 191174 RVA: 0x00D07224 File Offset: 0x00D05424
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

		// Token: 0x0602EAC7 RID: 191175 RVA: 0x00D0728E File Offset: 0x00D0548E
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

		// Token: 0x0602EAC8 RID: 191176 RVA: 0x00D072AA File Offset: 0x00D054AA
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

		// Token: 0x04018D0C RID: 101644
		[Nullable(2)]
		private InstanceDungeonMowingPanelItemData Data;

		// Token: 0x0200A523 RID: 42275
		private enum EChildType
		{
			// Token: 0x04033214 RID: 209428
			LeftButton,
			// Token: 0x04033215 RID: 209429
			LeftRedDotItem,
			// Token: 0x04033216 RID: 209430
			RightButton,
			// Token: 0x04033217 RID: 209431
			RightRedDotItem,
			// Token: 0x04033218 RID: 209432
			ProgressText,
			// Token: 0x04033219 RID: 209433
			LeftItem,
			// Token: 0x0403321A RID: 209434
			ScoreItem
		}
	}
}
