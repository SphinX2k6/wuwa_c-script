using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Fishing
{
	// Token: 0x0200660E RID: 26126
	public class FishingPermanentRewardButton : UiPanelBase
	{
		// Token: 0x06041791 RID: 268177 RVA: 0x00FDB440 File Offset: 0x00FD9640
		protected unsafe override void OnRegisterComponent()
		{
			int num = 3;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnClickedButton));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06041792 RID: 268178 RVA: 0x00FDB507 File Offset: 0x00FD9707
		protected override void OnBeforeShow()
		{
			this.Refresh();
		}

		// Token: 0x06041793 RID: 268179 RVA: 0x00FDB50F File Offset: 0x00FD970F
		public void Refresh()
		{
			this.RefreshRedDot();
			this.RefreshProgress();
		}

		// Token: 0x06041794 RID: 268180 RVA: 0x00FDB520 File Offset: 0x00FD9720
		private void RefreshRedDot()
		{
			bool handBookRewardRedDotState = FishingModel.Instance.GetHandBookRewardRedDotState();
			UUIItem item = base.GetItem(2);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(handBookRewardRedDotState);
		}

		// Token: 0x06041795 RID: 268181 RVA: 0x00FDB54C File Offset: 0x00FD974C
		private void RefreshProgress()
		{
			int handBookRewardHaveTakenCount = FishingModel.Instance.GetHandBookRewardHaveTakenCount();
			int count = FishingModel.Instance.FishingItemHandBookRewardMap.Count;
			UUIText text = base.GetText(1);
			if (text == null)
			{
				return;
			}
			text.SetText(handBookRewardHaveTakenCount.ToString() + "/" + count.ToString(), true);
		}

		// Token: 0x06041796 RID: 268182 RVA: 0x00FDB59E File Offset: 0x00FD979E
		private void OnClickedButton()
		{
			UiManager.Instance.OpenView(EUiViewName.FishingHandBookRewardView, null, null);
		}

		// Token: 0x0200C81B RID: 51227
		private class EComponents
		{
			// Token: 0x0403C6E6 RID: 247526
			public const int Button = 0;

			// Token: 0x0403C6E7 RID: 247527
			public const int TxtProgress = 1;

			// Token: 0x0403C6E8 RID: 247528
			public const int RedDot = 2;
		}
	}
}
