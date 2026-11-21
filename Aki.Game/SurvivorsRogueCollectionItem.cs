using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020011DB RID: 4571
public class SurvivorsRogueCollectionItem : UiPanelBase
{
	// Token: 0x0600B565 RID: 46437 RVA: 0x0035962B File Offset: 0x0035782B
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText)),
			new ValueTuple<int, Type>(1, typeof(UUISprite))
		};
	}

	// Token: 0x0600B566 RID: 46438 RVA: 0x00359664 File Offset: 0x00357864
	protected override void OnStart()
	{
		this.CollectionNumText = base.GetText(0);
		this.CollectionEfficiencyTipsSprite = base.GetSprite(1);
		this.SequencePlayer = new LevelSequencePlayer(base.GetRootItem());
	}

	// Token: 0x0600B567 RID: 46439 RVA: 0x00359694 File Offset: 0x00357894
	protected override void OnBeforeShow()
	{
		this.SequencePlayer.StopPlayingSequence(false, true);
		this.SequencePlayer.PlayLevelSequenceByName("Start", false, null, false);
	}

	// Token: 0x0600B568 RID: 46440 RVA: 0x003596CC File Offset: 0x003578CC
	public void Refresh(int collectionNum, bool efficiencyEnhance, bool playSequence)
	{
		if (playSequence)
		{
			this.SequencePlayer.PlayOrReplaySequenceByName(efficiencyEnhance ? "BuffAdd" : "Add", false, null);
		}
		this.CollectionNumText.SetText(collectionNum.ToString(), true);
	}

	// Token: 0x040068E3 RID: 26851
	[Nullable(2)]
	protected UUIText CollectionNumText;

	// Token: 0x040068E4 RID: 26852
	[Nullable(2)]
	protected UUISprite CollectionEfficiencyTipsSprite;

	// Token: 0x040068E5 RID: 26853
	[Nullable(1)]
	protected LevelSequencePlayer SequencePlayer;

	// Token: 0x02007498 RID: 29848
	private static class EComponentDefine
	{
		// Token: 0x04025F15 RID: 155413
		public const int CollectionNum = 0;

		// Token: 0x04025F16 RID: 155414
		public const int CollectionEfficiencyTips = 1;
	}
}
