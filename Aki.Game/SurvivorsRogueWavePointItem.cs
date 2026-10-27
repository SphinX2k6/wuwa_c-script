using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001D1A RID: 7450
[NullableContext(2)]
[Nullable(0)]
public class SurvivorsRogueWavePointItem : UiPanelBase
{
	// Token: 0x0600E14D RID: 57677 RVA: 0x0034DCEC File Offset: 0x0034BEEC
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUISprite)),
			new ValueTuple<int, Type>(2, typeof(UUISprite)),
			new ValueTuple<int, Type>(3, typeof(UUIItem)),
			new ValueTuple<int, Type>(4, typeof(UUISprite)),
			new ValueTuple<int, Type>(5, typeof(UUISprite)),
			new ValueTuple<int, Type>(6, typeof(UUISprite))
		};
	}

	// Token: 0x0600E14E RID: 57678 RVA: 0x0034DDA0 File Offset: 0x0034BFA0
	protected override void OnStart()
	{
		this.NormalWaveRoot = base.GetItem(0);
		this.NormalWaveFightingIcon = base.GetSprite(1);
		this.NormalWaveCompletedIcon = base.GetSprite(2);
		this.SpecialWaveRoot = base.GetItem(3);
		this.SpecialWaveFightingIcon = base.GetSprite(4);
		this.SpecialWaveCompletedIcon = base.GetSprite(5);
		this.EndlessCompletedIcon = base.GetSprite(6);
		this.SequencePlayer = new LevelSequencePlayer(base.GetRootItem());
	}

	// Token: 0x0600E14F RID: 57679 RVA: 0x0034DE19 File Offset: 0x0034C019
	public void SetState(EWaveType waveType)
	{
		this.NormalWaveRoot.SetUIActive(waveType == EWaveType.Normal);
		this.SpecialWaveRoot.SetUIActive(waveType == EWaveType.Special);
		this.EndlessCompletedIcon.SetUIActive(waveType == EWaveType.Endless);
		base.Show(null);
	}

	// Token: 0x0600E150 RID: 57680 RVA: 0x0034DE50 File Offset: 0x0034C050
	public void PlayBubbleSequence()
	{
		this.SequencePlayer.PlayOrReplaySequenceByName("Move", false, null);
	}

	// Token: 0x0600E151 RID: 57681 RVA: 0x0034DE78 File Offset: 0x0034C078
	public void PlayResetSequence()
	{
		this.SequencePlayer.PlayOrReplaySequenceByName("MoveBack", false, null);
	}

	// Token: 0x04006807 RID: 26631
	[Nullable(1)]
	private const string RESET_SEQUENCE_NAME = "MoveBack";

	// Token: 0x04006808 RID: 26632
	protected UUIItem NormalWaveRoot;

	// Token: 0x04006809 RID: 26633
	protected UUISprite NormalWaveFightingIcon;

	// Token: 0x0400680A RID: 26634
	protected UUISprite NormalWaveCompletedIcon;

	// Token: 0x0400680B RID: 26635
	protected UUIItem SpecialWaveRoot;

	// Token: 0x0400680C RID: 26636
	protected UUISprite SpecialWaveFightingIcon;

	// Token: 0x0400680D RID: 26637
	protected UUISprite SpecialWaveCompletedIcon;

	// Token: 0x0400680E RID: 26638
	protected UUISprite EndlessCompletedIcon;

	// Token: 0x0400680F RID: 26639
	[Nullable(1)]
	protected LevelSequencePlayer SequencePlayer;

	// Token: 0x02008310 RID: 33552
	[NullableContext(0)]
	private static class EComponentDefine
	{
		// Token: 0x0402ABEF RID: 175087
		public const int NormalWaveRoot = 0;

		// Token: 0x0402ABF0 RID: 175088
		public const int NormalWaveFightingIcon = 1;

		// Token: 0x0402ABF1 RID: 175089
		public const int NormalWaveCompletedIcon = 2;

		// Token: 0x0402ABF2 RID: 175090
		public const int SpecialWaveRoot = 3;

		// Token: 0x0402ABF3 RID: 175091
		public const int SpecialWaveFightingIcon = 4;

		// Token: 0x0402ABF4 RID: 175092
		public const int SpecialWaveCompletedIcon = 5;

		// Token: 0x0402ABF5 RID: 175093
		public const int EndlessCompletedIcon = 6;
	}
}
