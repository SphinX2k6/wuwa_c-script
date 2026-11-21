using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Fishing
{
	// Token: 0x0200558C RID: 21900
	public class FishingPermanentRewardButton : UiPanelBase
	{
		// Token: 0x06036456 RID: 222294 RVA: 0x00F224C0 File Offset: 0x00F206C0
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

		// Token: 0x06036457 RID: 222295 RVA: 0x00F22587 File Offset: 0x00F20787
		protected override void OnBeforeShow()
		{
			this.Refresh();
		}

		// Token: 0x06036458 RID: 222296 RVA: 0x00F2258F File Offset: 0x00F2078F
		public void Refresh()
		{
			this.RefreshRedDot();
			this.RefreshProgress();
		}

		// Token: 0x06036459 RID: 222297 RVA: 0x00F225A0 File Offset: 0x00F207A0
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

		// Token: 0x0603645A RID: 222298 RVA: 0x00F225CC File Offset: 0x00F207CC
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

		// Token: 0x0603645B RID: 222299 RVA: 0x00F2261E File Offset: 0x00F2081E
		private void OnClickedButton()
		{
			UiManager.Instance.OpenView(EUiViewName.FishingHandBookRewardView, null, null);
		}

		// Token: 0x0200B1FE RID: 45566
		private class EComponents
		{
			// Token: 0x0403702E RID: 225326
			public const int Button = 0;

			// Token: 0x0403702F RID: 225327
			public const int TxtProgress = 1;

			// Token: 0x04037030 RID: 225328
			public const int RedDot = 2;
		}
	}
}
