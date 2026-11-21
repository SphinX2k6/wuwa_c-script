using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.DreamLink
{
	// Token: 0x02004A97 RID: 19095
	[NullableContext(1)]
	[Nullable(0)]
	public class DreamLinkLimitTimeRewardItem : UiPanelBase
	{
		// Token: 0x0602FC97 RID: 195735 RVA: 0x00D5528F File Offset: 0x00D5348F
		public DreamLinkLimitTimeRewardItem(DreamLinkData Data)
		{
			this.Data = Data;
		}

		// Token: 0x0602FC98 RID: 195736 RVA: 0x00D552AC File Offset: 0x00D534AC
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

		// Token: 0x0602FC99 RID: 195737 RVA: 0x00D55373 File Offset: 0x00D53573
		protected override void OnBeforeHide()
		{
			this.ClearTimer();
		}

		// Token: 0x0602FC9A RID: 195738 RVA: 0x00D5537C File Offset: 0x00D5357C
		public void RefreshActive()
		{
			this.LimitTimeRewardOn = this.Data.IsLimitTimeRewardOn();
			this.SetActive(this.LimitTimeRewardOn);
			if (this.LimitTimeRewardOn)
			{
				this.OnRefreshTime(0f);
				this.RefreshRedDot();
				this.InitTimer();
				return;
			}
			this.ClearTimer();
		}

		// Token: 0x0602FC9B RID: 195739 RVA: 0x00D553CC File Offset: 0x00D535CC
		private void RefreshRedDot()
		{
			base.GetItem(2).SetUIActive(this.Data.CheckHasLimitTimeReward());
		}

		// Token: 0x0602FC9C RID: 195740 RVA: 0x00D553E8 File Offset: 0x00D535E8
		private void OnRefreshTime(float _)
		{
			long limitTimeEndTime = this.Data.GetLimitTimeEndTime();
			double serverTime = TimeUtil.Instance.GetServerTime();
			if ((double)limitTimeEndTime - serverTime <= 0.0)
			{
				this.RefreshActive();
				return;
			}
			string remainTimeText = ActivityModel.Instance.GetRemainTimeText(limitTimeEndTime, this.RemainTimeText);
			base.GetText(1).SetText(remainTimeText, true);
		}

		// Token: 0x0602FC9D RID: 195741 RVA: 0x00D55442 File Offset: 0x00D53642
		private void InitTimer()
		{
			this.ClearTimer();
			this.RefreshTimeHandle = TimerSystem.GameplayTimeInstance.Forever(new TTimerAction(this.OnRefreshTime), 1000f, 1f, null, null, false);
		}

		// Token: 0x0602FC9E RID: 195742 RVA: 0x00D55473 File Offset: 0x00D53673
		private void ClearTimer()
		{
			if (this.RefreshTimeHandle != null)
			{
				TimerSystem.GameplayTimeInstance.Remove(this.RefreshTimeHandle);
				this.RefreshTimeHandle = null;
			}
		}

		// Token: 0x0602FC9F RID: 195743 RVA: 0x00D55495 File Offset: 0x00D53695
		private void OnClickedButton()
		{
			if (this.LimitTimeRewardOn)
			{
				this.Data.SaveFirstCheckRedDotState(4, 0);
				UiManager.Instance.OpenView(EUiViewName.DreamLinkRewardViewLimit, null, null);
			}
		}

		// Token: 0x040195D8 RID: 103896
		private const int CHECKGAP = 1000;

		// Token: 0x040195D9 RID: 103897
		private bool LimitTimeRewardOn;

		// Token: 0x040195DA RID: 103898
		private string RemainTimeText = "{0}";

		// Token: 0x040195DB RID: 103899
		[Nullable(2)]
		private TimerHandle RefreshTimeHandle;

		// Token: 0x040195DC RID: 103900
		private DreamLinkData Data;

		// Token: 0x0200A716 RID: 42774
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x04033A10 RID: 211472
			public const int Button = 0;

			// Token: 0x04033A11 RID: 211473
			public const int TxtTime = 1;

			// Token: 0x04033A12 RID: 211474
			public const int RedDot = 2;
		}
	}
}
