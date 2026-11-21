using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001CCC RID: 7372
[NullableContext(1)]
[Nullable(0)]
public class RoleTowerCountdownView : UiTickViewBase
{
	// Token: 0x06012415 RID: 74773 RVA: 0x00561BE9 File Offset: 0x0055FDE9
	public RoleTowerCountdownView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06012416 RID: 74774 RVA: 0x00561C00 File Offset: 0x0055FE00
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUIText)),
			new ValueTuple<int, Type>(3, typeof(UUIItem)),
			new ValueTuple<int, Type>(4, typeof(UUIItem))
		};
	}

	// Token: 0x06012417 RID: 74775 RVA: 0x00561C86 File Offset: 0x0055FE86
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.RoleTowerBattleTimeUpdate, new Action(this.OnTimeUpdate));
		EventSystem.Instance.Add(EEventName.RoleTowerBattleTimeDeltaUpdate, new Action(this.OnTimeDeltaUpdate));
	}

	// Token: 0x06012418 RID: 74776 RVA: 0x00561CC0 File Offset: 0x0055FEC0
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.RoleTowerBattleTimeUpdate, new Action(this.OnTimeUpdate));
		EventSystem.Instance.Remove(EEventName.RoleTowerBattleTimeDeltaUpdate, new Action(this.OnTimeDeltaUpdate));
	}

	// Token: 0x06012419 RID: 74777 RVA: 0x00561CFC File Offset: 0x0055FEFC
	protected override void OnStart()
	{
		UUIItem item = base.GetItem(1);
		if (item != null)
		{
			this.AddTimeSeqPlayer = new UiSequencePlayer(item);
			this.AddTimeSeqPlayer.BindOnEndSequenceEvent(new Action<string>(this.OnAddTimeSeqEnd));
		}
	}

	// Token: 0x0601241A RID: 74778 RVA: 0x00561D38 File Offset: 0x0055FF38
	protected override void OnBeforeShow()
	{
		this.RefreshTime();
		this.RefreshPauseState();
		this.DeltaQueue.Clear();
		this.IsShowingDelta = false;
		UUIItem item = base.GetItem(1);
		if (item != null)
		{
			item.SetUIActive(false);
		}
		UUIItem item2 = base.GetItem(4);
		if (item2 == null)
		{
			return;
		}
		item2.SetUIActive(false);
	}

	// Token: 0x0601241B RID: 74779 RVA: 0x00561D88 File Offset: 0x0055FF88
	protected override void OnTick(float delta)
	{
		RoleTowerModel.Instance.TickDungeonTimer();
		this.RefreshTime();
		this.RefreshPauseState();
	}

	// Token: 0x0601241C RID: 74780 RVA: 0x00561DA0 File Offset: 0x0055FFA0
	private void RefreshTime()
	{
		long dungeonRemainTime = RoleTowerModel.Instance.GetDungeonRemainTime();
		UUIText text = base.GetText(0);
		if (text == null)
		{
			return;
		}
		text.SetText(RoleTowerTimeUtil.FormatHudZero(dungeonRemainTime), true);
	}

	// Token: 0x0601241D RID: 74781 RVA: 0x00561DD0 File Offset: 0x0055FFD0
	private void RefreshPauseState()
	{
		UUIItem item = base.GetItem(3);
		if (item == null)
		{
			return;
		}
		item.SetUIActive(RoleTowerModel.Instance.IsDungeonTimePaused());
	}

	// Token: 0x0601241E RID: 74782 RVA: 0x00561DED File Offset: 0x0055FFED
	private void OnTimeUpdate()
	{
		this.RefreshTime();
	}

	// Token: 0x0601241F RID: 74783 RVA: 0x00561DF8 File Offset: 0x0055FFF8
	private void OnTimeDeltaUpdate()
	{
		long lastTimeDelta = RoleTowerModel.Instance.GetLastTimeDelta();
		if (lastTimeDelta == 0L)
		{
			return;
		}
		this.RefreshTime();
		this.DeltaQueue.Enqueue(lastTimeDelta);
		if (!this.IsShowingDelta)
		{
			this.PlayNextDelta();
		}
	}

	// Token: 0x06012420 RID: 74784 RVA: 0x00561E34 File Offset: 0x00560034
	private void PlayNextDelta()
	{
		if (this.DeltaQueue.Count == 0)
		{
			this.IsShowingDelta = false;
			UUIItem item = base.GetItem(1);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(false);
			return;
		}
		else
		{
			this.IsShowingDelta = true;
			long num = this.DeltaQueue.Dequeue();
			UUIItem item2 = base.GetItem(1);
			if (item2 != null)
			{
				item2.SetUIActive(true);
			}
			UUIItem item3 = base.GetItem(4);
			if (item3 != null)
			{
				item3.SetUIActive(num > 0L);
			}
			UUIText text = base.GetText(2);
			if (text != null)
			{
				UUIItem uuiitem = text;
				bool bUseChangeColor = num > 0L;
				FColor? fcolor = new FColor?(text.changeColor);
				uuiitem.SetChangeColor(bUseChangeColor, fcolor);
				text.SetText(RoleTowerTimeUtil.FormatDeltaHud(num), true);
			}
			UiSequencePlayer addTimeSeqPlayer = this.AddTimeSeqPlayer;
			if (addTimeSeqPlayer == null)
			{
				return;
			}
			addTimeSeqPlayer.PlaySequence((num > 0L) ? "Start" : "Start2", false, null);
			return;
		}
	}

	// Token: 0x06012421 RID: 74785 RVA: 0x00561F01 File Offset: 0x00560101
	private void OnAddTimeSeqEnd(string sequenceName)
	{
		if (sequenceName != "Start" && sequenceName != "Start2")
		{
			return;
		}
		this.PlayNextDelta();
	}

	// Token: 0x06012422 RID: 74786 RVA: 0x00561F24 File Offset: 0x00560124
	protected override void OnBeforeDestroy()
	{
		this.AddTimeSeqPlayer = null;
		this.DeltaQueue.Clear();
		this.IsShowingDelta = false;
	}

	// Token: 0x04009F75 RID: 40821
	private readonly Queue<long> DeltaQueue = new Queue<long>();

	// Token: 0x04009F76 RID: 40822
	private bool IsShowingDelta;

	// Token: 0x04009F77 RID: 40823
	[Nullable(2)]
	private UiSequencePlayer AddTimeSeqPlayer;

	// Token: 0x04009F78 RID: 40824
	private const string SubTimeSeqName = "Start2";

	// Token: 0x02007FBC RID: 32700
	[NullableContext(0)]
	private static class EChildType
	{
		// Token: 0x04029536 RID: 169270
		public const int TxtTime = 0;

		// Token: 0x04029537 RID: 169271
		public const int PnlAddTimeItem = 1;

		// Token: 0x04029538 RID: 169272
		public const int TxtTimeDelta = 2;

		// Token: 0x04029539 RID: 169273
		public const int PauseItem = 3;

		// Token: 0x0402953A RID: 169274
		public const int AddTimeEffectItem = 4;
	}
}
