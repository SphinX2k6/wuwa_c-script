using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.DreamLink
{
	// Token: 0x02005ABB RID: 23227
	[NullableContext(1)]
	[Nullable(0)]
	public class DreamLinkLimitTimeRewardItem : UiPanelBase
	{
		// Token: 0x0603AD4B RID: 240971 RVA: 0x00E04CC7 File Offset: 0x00E02EC7
		public DreamLinkLimitTimeRewardItem(DreamLinkData Data)
		{
			this.Data = Data;
		}

		// Token: 0x0603AD4C RID: 240972 RVA: 0x00E04CE4 File Offset: 0x00E02EE4
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

		// Token: 0x0603AD4D RID: 240973 RVA: 0x00E04DAB File Offset: 0x00E02FAB
		protected override void OnBeforeHide()
		{
			this.ClearTimer();
		}

		// Token: 0x0603AD4E RID: 240974 RVA: 0x00E04DB4 File Offset: 0x00E02FB4
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

		// Token: 0x0603AD4F RID: 240975 RVA: 0x00E04E04 File Offset: 0x00E03004
		private void RefreshRedDot()
		{
			base.GetItem(2).SetUIActive(this.Data.CheckHasLimitTimeReward());
		}

		// Token: 0x0603AD50 RID: 240976 RVA: 0x00E04E20 File Offset: 0x00E03020
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

		// Token: 0x0603AD51 RID: 240977 RVA: 0x00E04E7A File Offset: 0x00E0307A
		private void InitTimer()
		{
			this.ClearTimer();
			this.RefreshTimeHandle = TimerSystem.GameplayTimeInstance.Forever(new TTimerAction(this.OnRefreshTime), 1000f, 1f, null, null, false);
		}

		// Token: 0x0603AD52 RID: 240978 RVA: 0x00E04EAB File Offset: 0x00E030AB
		private void ClearTimer()
		{
			if (this.RefreshTimeHandle != null)
			{
				TimerSystem.GameplayTimeInstance.Remove(this.RefreshTimeHandle);
				this.RefreshTimeHandle = null;
			}
		}

		// Token: 0x0603AD53 RID: 240979 RVA: 0x00E04ECD File Offset: 0x00E030CD
		private void OnClickedButton()
		{
			if (this.LimitTimeRewardOn)
			{
				this.Data.SaveFirstCheckRedDotState(4, 0);
				UiManager.Instance.OpenView(EUiViewName.DreamLinkRewardViewLimit, null, null);
			}
		}

		// Token: 0x0401EB31 RID: 125745
		private const int CHECKGAP = 1000;

		// Token: 0x0401EB32 RID: 125746
		private bool LimitTimeRewardOn;

		// Token: 0x0401EB33 RID: 125747
		private string RemainTimeText = "{0}";

		// Token: 0x0401EB34 RID: 125748
		[Nullable(2)]
		private TimerHandle RefreshTimeHandle;

		// Token: 0x0401EB35 RID: 125749
		private DreamLinkData Data;

		// Token: 0x0200BD0E RID: 48398
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x04039046 RID: 233542
			public const int Button = 0;

			// Token: 0x04039047 RID: 233543
			public const int TxtTime = 1;

			// Token: 0x04039048 RID: 233544
			public const int RedDot = 2;
		}
	}
}
