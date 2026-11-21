using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Fishing
{
	// Token: 0x02005501 RID: 21761
	[NullableContext(1)]
	[Nullable(0)]
	public class FishingRewardLimitTimeButton : UiPanelBase
	{
		// Token: 0x06035EDC RID: 220892 RVA: 0x00F0FC13 File Offset: 0x00F0DE13
		public FishingRewardLimitTimeButton(ActivityFishingData data)
		{
			this.Data = data;
		}

		// Token: 0x06035EDD RID: 220893 RVA: 0x00F0FC30 File Offset: 0x00F0DE30
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

		// Token: 0x06035EDE RID: 220894 RVA: 0x00F0FCF7 File Offset: 0x00F0DEF7
		protected override void OnBeforeHide()
		{
			this.ClearTimer();
		}

		// Token: 0x06035EDF RID: 220895 RVA: 0x00F0FD00 File Offset: 0x00F0DF00
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

		// Token: 0x06035EE0 RID: 220896 RVA: 0x00F0FD50 File Offset: 0x00F0DF50
		private void RefreshRedDot()
		{
			base.GetItem(2).SetUIActive(this.Data.GetTimeLimitRedDotState());
		}

		// Token: 0x06035EE1 RID: 220897 RVA: 0x00F0FD6C File Offset: 0x00F0DF6C
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

		// Token: 0x06035EE2 RID: 220898 RVA: 0x00F0FDC6 File Offset: 0x00F0DFC6
		private void InitTimer()
		{
			this.ClearTimer();
			this.RefreshTimeHandle = TimerSystem.GameplayTimeInstance.Forever(new TTimerAction(this.OnRefreshTime), 1000f, 1f, null, null, false);
		}

		// Token: 0x06035EE3 RID: 220899 RVA: 0x00F0FDF7 File Offset: 0x00F0DFF7
		private void ClearTimer()
		{
			if (this.RefreshTimeHandle != null)
			{
				TimerSystem.GameplayTimeInstance.Remove(this.RefreshTimeHandle);
				this.RefreshTimeHandle = null;
			}
		}

		// Token: 0x06035EE4 RID: 220900 RVA: 0x00F0FE19 File Offset: 0x00F0E019
		private void OnClickedButton()
		{
			if (this.LimitTimeRewardOn)
			{
				UiManager.Instance.OpenView(EUiViewName.FishingTimeLimitView, null, null);
			}
		}

		// Token: 0x0401C812 RID: 116754
		private const int CHECKGAP = 1000;

		// Token: 0x0401C813 RID: 116755
		private bool LimitTimeRewardOn;

		// Token: 0x0401C814 RID: 116756
		private readonly string RemainTimeText = "{0}";

		// Token: 0x0401C815 RID: 116757
		[Nullable(2)]
		private TimerHandle RefreshTimeHandle;

		// Token: 0x0401C816 RID: 116758
		protected ActivityFishingData Data;

		// Token: 0x0200B15E RID: 45406
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x04036D98 RID: 224664
			public const int Button = 0;

			// Token: 0x04036D99 RID: 224665
			public const int TxtTime = 1;

			// Token: 0x04036D9A RID: 224666
			public const int RedDot = 2;
		}
	}
}
