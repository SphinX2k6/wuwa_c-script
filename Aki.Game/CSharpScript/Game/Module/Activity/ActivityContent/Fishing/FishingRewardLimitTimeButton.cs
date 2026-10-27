using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Fishing
{
	// Token: 0x02006583 RID: 25987
	[NullableContext(1)]
	[Nullable(0)]
	public class FishingRewardLimitTimeButton : UiPanelBase
	{
		// Token: 0x06041217 RID: 266775 RVA: 0x00FC8C5F File Offset: 0x00FC6E5F
		public FishingRewardLimitTimeButton(ActivityFishingData data)
		{
			this.Data = data;
		}

		// Token: 0x06041218 RID: 266776 RVA: 0x00FC8C7C File Offset: 0x00FC6E7C
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

		// Token: 0x06041219 RID: 266777 RVA: 0x00FC8D43 File Offset: 0x00FC6F43
		protected override void OnBeforeHide()
		{
			this.ClearTimer();
		}

		// Token: 0x0604121A RID: 266778 RVA: 0x00FC8D4C File Offset: 0x00FC6F4C
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

		// Token: 0x0604121B RID: 266779 RVA: 0x00FC8D9C File Offset: 0x00FC6F9C
		private void RefreshRedDot()
		{
			base.GetItem(2).SetUIActive(this.Data.GetTimeLimitRedDotState());
		}

		// Token: 0x0604121C RID: 266780 RVA: 0x00FC8DB8 File Offset: 0x00FC6FB8
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

		// Token: 0x0604121D RID: 266781 RVA: 0x00FC8E12 File Offset: 0x00FC7012
		private void InitTimer()
		{
			this.ClearTimer();
			this.RefreshTimeHandle = TimerSystem.GameplayTimeInstance.Forever(new TTimerAction(this.OnRefreshTime), 1000f, 1f, null, null, false);
		}

		// Token: 0x0604121E RID: 266782 RVA: 0x00FC8E43 File Offset: 0x00FC7043
		private void ClearTimer()
		{
			if (this.RefreshTimeHandle != null)
			{
				TimerSystem.GameplayTimeInstance.Remove(this.RefreshTimeHandle);
				this.RefreshTimeHandle = null;
			}
		}

		// Token: 0x0604121F RID: 266783 RVA: 0x00FC8E65 File Offset: 0x00FC7065
		private void OnClickedButton()
		{
			if (this.LimitTimeRewardOn)
			{
				UiManager.Instance.OpenView(EUiViewName.FishingTimeLimitView, null, null);
			}
		}

		// Token: 0x04021EE1 RID: 138977
		private const int CHECKGAP = 1000;

		// Token: 0x04021EE2 RID: 138978
		private bool LimitTimeRewardOn;

		// Token: 0x04021EE3 RID: 138979
		private readonly string RemainTimeText = "{0}";

		// Token: 0x04021EE4 RID: 138980
		[Nullable(2)]
		private TimerHandle RefreshTimeHandle;

		// Token: 0x04021EE5 RID: 138981
		protected ActivityFishingData Data;

		// Token: 0x0200C779 RID: 51065
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x0403C447 RID: 246855
			public const int Button = 0;

			// Token: 0x0403C448 RID: 246856
			public const int TxtTime = 1;

			// Token: 0x0403C449 RID: 246857
			public const int RedDot = 2;
		}
	}
}
