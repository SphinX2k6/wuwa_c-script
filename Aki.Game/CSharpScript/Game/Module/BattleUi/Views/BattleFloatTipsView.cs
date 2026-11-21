using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02004E23 RID: 20003
	public class BattleFloatTipsView : UiViewBase
	{
		// Token: 0x06032520 RID: 206112 RVA: 0x00E1B588 File Offset: 0x00E19788
		[NullableContext(1)]
		public BattleFloatTipsView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06032521 RID: 206113 RVA: 0x00E1B594 File Offset: 0x00E19794
		protected unsafe override void OnRegisterComponent()
		{
			int num = 3;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06032522 RID: 206114 RVA: 0x00E1B620 File Offset: 0x00E19820
		protected override void OnStart()
		{
			if (this.Timer == null)
			{
				this.Timer = TimerSystem.GameplayTimeInstance.Forever(new TTimerAction(this.OnTimerUpdate), 100f, 1f, null, null, true);
			}
			BattleUiFloatTipsData floatTipsData = BattleUiModel.Instance.FloatTipsData;
			BattleUiFloatTip battleUiFloatTip = floatTipsData.CurTip;
			if (floatTipsData.CheckIsExpired(battleUiFloatTip))
			{
				battleUiFloatTip = floatTipsData.GetNextFloatTip();
			}
			if (battleUiFloatTip == null)
			{
				return;
			}
			this.CurTip = battleUiFloatTip;
			this.InitText();
		}

		// Token: 0x06032523 RID: 206115 RVA: 0x00E1B691 File Offset: 0x00E19891
		protected override void OnBeforeDestroy()
		{
			if (this.Timer != null)
			{
				TimerSystem.GameplayTimeInstance.Remove(this.Timer);
				this.Timer = null;
			}
		}

		// Token: 0x06032524 RID: 206116 RVA: 0x00E1B6B3 File Offset: 0x00E198B3
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.BattleUiFloatTipUpdate, new Action(this.OnBattleUiFloatTipUpdate));
		}

		// Token: 0x06032525 RID: 206117 RVA: 0x00E1B6D1 File Offset: 0x00E198D1
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.BattleUiFloatTipUpdate, new Action(this.OnBattleUiFloatTipUpdate));
		}

		// Token: 0x06032526 RID: 206118 RVA: 0x00E1B6F0 File Offset: 0x00E198F0
		public void OnTimerUpdate(float _)
		{
			if (this.CurTip == null || (double)this.CurTip.EndTime <= Time.Instance.WorldTimeSeconds)
			{
				this.TryPlayNextTip();
				return;
			}
			if (this.CurTip.Type == EBattleUiFloatTip.Countdown)
			{
				int num = (int)Math.Max(Math.Ceiling((double)this.CurTip.CountdownEndTime - Time.Instance.WorldTimeSeconds), 0.0);
				if (num != this.CurSeconds)
				{
					this.CurSeconds = num;
					LguiUtil.Instance.SetLocalText(base.GetText(1), "BattleTipCountdown", new <>z__ReadOnlySingleElementList<object>(this.CurSeconds));
				}
			}
		}

		// Token: 0x06032527 RID: 206119 RVA: 0x00E1B794 File Offset: 0x00E19994
		private void OnBattleUiFloatTipUpdate()
		{
			BattleUiFloatTipsData floatTipsData = BattleUiModel.Instance.FloatTipsData;
			this.CurTip = floatTipsData.CurTip;
			this.InitText();
		}

		// Token: 0x06032528 RID: 206120 RVA: 0x00E1B7C0 File Offset: 0x00E199C0
		private void TryPlayNextTip()
		{
			BattleUiFloatTip nextFloatTip = BattleUiModel.Instance.FloatTipsData.GetNextFloatTip();
			if (nextFloatTip == null)
			{
				base.CloseMe(null);
				return;
			}
			this.CurTip = nextFloatTip;
			this.InitText();
		}

		// Token: 0x06032529 RID: 206121 RVA: 0x00E1B7F8 File Offset: 0x00E199F8
		private void InitText()
		{
			EBattleUiFloatTip type = this.CurTip.Type;
			if (type == EBattleUiFloatTip.Normal)
			{
				LguiUtil.Instance.SetLocalText(base.GetText(0), this.CurTip.TextKey, Array.Empty<object>());
				base.GetText(1).SetText("", true);
				base.GetItem(2).SetUIActive(false);
				return;
			}
			if (type != EBattleUiFloatTip.Countdown)
			{
				return;
			}
			this.CurSeconds = (int)Math.Max(Math.Ceiling((double)this.CurTip.CountdownEndTime - Time.Instance.WorldTimeSeconds), 0.0);
			LguiUtil.Instance.SetLocalText(base.GetText(0), this.CurTip.TextKey, Array.Empty<object>());
			LguiUtil.Instance.SetLocalText(base.GetText(1), "BattleTipCountdown", new <>z__ReadOnlySingleElementList<object>(this.CurSeconds));
			base.GetItem(2).SetUIActive(true);
		}

		// Token: 0x0401AAC6 RID: 109254
		private const int TIMER_INTERVAL = 100;

		// Token: 0x0401AAC7 RID: 109255
		[Nullable(1)]
		private const string COUNTDOWN_TEXT_KEY = "BattleTipCountdown";

		// Token: 0x0401AAC8 RID: 109256
		[Nullable(2)]
		private BattleUiFloatTip CurTip;

		// Token: 0x0401AAC9 RID: 109257
		private int CurSeconds;

		// Token: 0x0401AACA RID: 109258
		[Nullable(2)]
		private TimerHandle Timer;

		// Token: 0x0200ABCD RID: 43981
		private enum EChildType
		{
			// Token: 0x040352B6 RID: 217782
			TxtTip,
			// Token: 0x040352B7 RID: 217783
			TxtTime,
			// Token: 0x040352B8 RID: 217784
			IconItem
		}
	}
}
