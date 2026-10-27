using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005E3E RID: 24126
	public class BattleFloatTipsView : UiViewBase
	{
		// Token: 0x0603D590 RID: 251280 RVA: 0x00ECA01C File Offset: 0x00EC821C
		[NullableContext(1)]
		public BattleFloatTipsView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0603D591 RID: 251281 RVA: 0x00ECA028 File Offset: 0x00EC8228
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

		// Token: 0x0603D592 RID: 251282 RVA: 0x00ECA0B4 File Offset: 0x00EC82B4
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

		// Token: 0x0603D593 RID: 251283 RVA: 0x00ECA125 File Offset: 0x00EC8325
		protected override void OnBeforeDestroy()
		{
			if (this.Timer != null)
			{
				TimerSystem.GameplayTimeInstance.Remove(this.Timer);
				this.Timer = null;
			}
		}

		// Token: 0x0603D594 RID: 251284 RVA: 0x00ECA147 File Offset: 0x00EC8347
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.BattleUiFloatTipUpdate, new Action(this.OnBattleUiFloatTipUpdate));
		}

		// Token: 0x0603D595 RID: 251285 RVA: 0x00ECA165 File Offset: 0x00EC8365
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.BattleUiFloatTipUpdate, new Action(this.OnBattleUiFloatTipUpdate));
		}

		// Token: 0x0603D596 RID: 251286 RVA: 0x00ECA184 File Offset: 0x00EC8384
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

		// Token: 0x0603D597 RID: 251287 RVA: 0x00ECA228 File Offset: 0x00EC8428
		private void OnBattleUiFloatTipUpdate()
		{
			BattleUiFloatTipsData floatTipsData = BattleUiModel.Instance.FloatTipsData;
			this.CurTip = floatTipsData.CurTip;
			this.InitText();
		}

		// Token: 0x0603D598 RID: 251288 RVA: 0x00ECA254 File Offset: 0x00EC8454
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

		// Token: 0x0603D599 RID: 251289 RVA: 0x00ECA28C File Offset: 0x00EC848C
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

		// Token: 0x0401FFFF RID: 131071
		private const int TIMER_INTERVAL = 100;

		// Token: 0x04020000 RID: 131072
		[Nullable(1)]
		private const string COUNTDOWN_TEXT_KEY = "BattleTipCountdown";

		// Token: 0x04020001 RID: 131073
		[Nullable(2)]
		private BattleUiFloatTip CurTip;

		// Token: 0x04020002 RID: 131074
		private int CurSeconds;

		// Token: 0x04020003 RID: 131075
		[Nullable(2)]
		private TimerHandle Timer;

		// Token: 0x0200C1BE RID: 49598
		private enum EChildType
		{
			// Token: 0x0403A8C4 RID: 239812
			TxtTip,
			// Token: 0x0403A8C5 RID: 239813
			TxtTime,
			// Token: 0x0403A8C6 RID: 239814
			IconItem
		}
	}
}
