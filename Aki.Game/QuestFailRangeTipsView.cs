using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001DA2 RID: 7586
public class QuestFailRangeTipsView : UiTickViewBase
{
	// Token: 0x0600E642 RID: 58946 RVA: 0x00364619 File Offset: 0x00362819
	[NullableContext(1)]
	public QuestFailRangeTipsView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600E643 RID: 58947 RVA: 0x00364624 File Offset: 0x00362824
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

	// Token: 0x0600E644 RID: 58948 RVA: 0x0036466C File Offset: 0x0036286C
	protected override void OnStart()
	{
		this.CountDownText = base.GetText(0);
		this.LevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
		double num = (double)this.OpenParam;
		this.RemainTime = num - TimeUtil.Instance.GetServerStopTimeStamp();
		this.UpdateCountDown();
	}

	// Token: 0x0600E645 RID: 58949 RVA: 0x003646BC File Offset: 0x003628BC
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

	// Token: 0x0600E646 RID: 58950 RVA: 0x0036473C File Offset: 0x0036293C
	private void UpdateCountDown()
	{
		int num = (int)Math.Floor(this.RemainTime / 1000.0);
		this.CountDownText.SetText(num.ToString(), true);
	}

	// Token: 0x04006A8D RID: 27277
	[Nullable(2)]
	private UUIText CountDownText;

	// Token: 0x04006A8E RID: 27278
	[Nullable(2)]
	private LevelSequencePlayer LevelSequencePlayer;

	// Token: 0x04006A8F RID: 27279
	private double RemainTime;

	// Token: 0x02008380 RID: 33664
	private static class EChildComponent
	{
		// Token: 0x0402ADA1 RID: 175521
		public const int CountDownText = 0;
	}
}
