using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001D19 RID: 7449
public class SurvivorsRogueCollectionItem : UiPanelBase
{
	// Token: 0x0600E148 RID: 57672 RVA: 0x0034DBFB File Offset: 0x0034BDFB
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText)),
			new ValueTuple<int, Type>(1, typeof(UUISprite))
		};
	}

	// Token: 0x0600E149 RID: 57673 RVA: 0x0034DC34 File Offset: 0x0034BE34
	protected override void OnStart()
	{
		this.CollectionNumText = base.GetText(0);
		this.CollectionEfficiencyTipsSprite = base.GetSprite(1);
		this.SequencePlayer = new LevelSequencePlayer(base.GetRootItem());
	}

	// Token: 0x0600E14A RID: 57674 RVA: 0x0034DC64 File Offset: 0x0034BE64
	protected override void OnBeforeShow()
	{
		this.SequencePlayer.StopPlayingSequence(false, true);
		this.SequencePlayer.PlayLevelSequenceByName("Start", false, null, false);
	}

	// Token: 0x0600E14B RID: 57675 RVA: 0x0034DC9C File Offset: 0x0034BE9C
	public void Refresh(int collectionNum, bool efficiencyEnhance, bool playSequence)
	{
		if (playSequence)
		{
			this.SequencePlayer.PlayOrReplaySequenceByName(efficiencyEnhance ? "BuffAdd" : "Add", false, null);
		}
		this.CollectionNumText.SetText(collectionNum.ToString(), true);
	}

	// Token: 0x04006804 RID: 26628
	[Nullable(2)]
	protected UUIText CollectionNumText;

	// Token: 0x04006805 RID: 26629
	[Nullable(2)]
	protected UUISprite CollectionEfficiencyTipsSprite;

	// Token: 0x04006806 RID: 26630
	[Nullable(1)]
	protected LevelSequencePlayer SequencePlayer;

	// Token: 0x0200830F RID: 33551
	private static class EComponentDefine
	{
		// Token: 0x0402ABED RID: 175085
		public const int CollectionNum = 0;

		// Token: 0x0402ABEE RID: 175086
		public const int CollectionEfficiencyTips = 1;
	}
}
