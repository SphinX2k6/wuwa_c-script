using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020011DC RID: 4572
[NullableContext(2)]
[Nullable(0)]
public class SurvivorsRogueWavePointItem : UiPanelBase
{
	// Token: 0x0600B56A RID: 46442 RVA: 0x0035971C File Offset: 0x0035791C
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

	// Token: 0x0600B56B RID: 46443 RVA: 0x003597D0 File Offset: 0x003579D0
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

	// Token: 0x0600B56C RID: 46444 RVA: 0x00359849 File Offset: 0x00357A49
	public void SetState(EWaveType waveType)
	{
		this.NormalWaveRoot.SetUIActive(waveType == EWaveType.Normal);
		this.SpecialWaveRoot.SetUIActive(waveType == EWaveType.Special);
		this.EndlessCompletedIcon.SetUIActive(waveType == EWaveType.Endless);
		base.Show(null);
	}

	// Token: 0x0600B56D RID: 46445 RVA: 0x00359880 File Offset: 0x00357A80
	public void PlayBubbleSequence()
	{
		this.SequencePlayer.PlayOrReplaySequenceByName("Move", false, null);
	}

	// Token: 0x0600B56E RID: 46446 RVA: 0x003598A8 File Offset: 0x00357AA8
	public void PlayResetSequence()
	{
		this.SequencePlayer.PlayOrReplaySequenceByName("MoveBack", false, null);
	}

	// Token: 0x040068E6 RID: 26854
	[Nullable(1)]
	private const string RESET_SEQUENCE_NAME = "MoveBack";

	// Token: 0x040068E7 RID: 26855
	protected UUIItem NormalWaveRoot;

	// Token: 0x040068E8 RID: 26856
	protected UUISprite NormalWaveFightingIcon;

	// Token: 0x040068E9 RID: 26857
	protected UUISprite NormalWaveCompletedIcon;

	// Token: 0x040068EA RID: 26858
	protected UUIItem SpecialWaveRoot;

	// Token: 0x040068EB RID: 26859
	protected UUISprite SpecialWaveFightingIcon;

	// Token: 0x040068EC RID: 26860
	protected UUISprite SpecialWaveCompletedIcon;

	// Token: 0x040068ED RID: 26861
	protected UUISprite EndlessCompletedIcon;

	// Token: 0x040068EE RID: 26862
	[Nullable(1)]
	protected LevelSequencePlayer SequencePlayer;

	// Token: 0x02007499 RID: 29849
	[NullableContext(0)]
	private static class EComponentDefine
	{
		// Token: 0x04025F17 RID: 155415
		public const int NormalWaveRoot = 0;

		// Token: 0x04025F18 RID: 155416
		public const int NormalWaveFightingIcon = 1;

		// Token: 0x04025F19 RID: 155417
		public const int NormalWaveCompletedIcon = 2;

		// Token: 0x04025F1A RID: 155418
		public const int SpecialWaveRoot = 3;

		// Token: 0x04025F1B RID: 155419
		public const int SpecialWaveFightingIcon = 4;

		// Token: 0x04025F1C RID: 155420
		public const int SpecialWaveCompletedIcon = 5;

		// Token: 0x04025F1D RID: 155421
		public const int EndlessCompletedIcon = 6;
	}
}
