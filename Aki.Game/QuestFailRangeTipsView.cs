using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001264 RID: 4708
public class QuestFailRangeTipsView : UiTickViewBase
{
	// Token: 0x0600BA60 RID: 47712 RVA: 0x00370279 File Offset: 0x0036E479
	[NullableContext(1)]
	public QuestFailRangeTipsView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600BA61 RID: 47713 RVA: 0x00370284 File Offset: 0x0036E484
	protected unsafe override void OnRegisterComponent()
	{
		int num = 1;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int index = 0;
		*span[index] = new ValueTuple<int, Type>(0, typeof(UUIText));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x0600BA62 RID: 47714 RVA: 0x003702CC File Offset: 0x0036E4CC
	protected override void OnStart()
	{
		this.CountDownText = base.GetText(0);
		this.LevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
		double num = (double)this.OpenParam;
		this.RemainTime = num - TimeUtil.Instance.GetServerStopTimeStamp();
		this.UpdateCountDown();
	}

	// Token: 0x0600BA63 RID: 47715 RVA: 0x0037031C File Offset: 0x0036E51C
	protected override void OnTick(float delta)
	{
		if (Time.Instance.FlowTimeDilation == 0f)
		{
			return;
		}
		this.RemainTime = Math.Max(this.RemainTime - (double)(delta * Time.Instance.TimeDilation), 0.0);
		this.UpdateCountDown();
		if (this.LevelSequencePlayer.GetCurrentSequence() != "Loop")
		{
			this.LevelSequencePlayer.PlayLevelSequenceByName("Loop", false, null, false);
		}
	}

	// Token: 0x0600BA64 RID: 47716 RVA: 0x0037039C File Offset: 0x0036E59C
	private void UpdateCountDown()
	{
		int num = (int)Math.Floor(this.RemainTime / 1000.0);
		this.CountDownText.SetText(num.ToString(), true);
	}

	// Token: 0x04006B6E RID: 27502
	[Nullable(2)]
	private UUIText CountDownText;

	// Token: 0x04006B6F RID: 27503
	[Nullable(2)]
	private LevelSequencePlayer LevelSequencePlayer;

	// Token: 0x04006B70 RID: 27504
	private double RemainTime;

	// Token: 0x02007508 RID: 29960
	private static class EChildComponent
	{
		// Token: 0x040260C7 RID: 155847
		public const int CountDownText = 0;
	}
}
