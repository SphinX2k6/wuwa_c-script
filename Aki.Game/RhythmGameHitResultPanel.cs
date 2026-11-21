using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x0200053A RID: 1338
[NullableContext(2)]
[Nullable(0)]
public class RhythmGameHitResultPanel : UiPanelBase
{
	// Token: 0x06004194 RID: 16788 RVA: 0x0016E4B8 File Offset: 0x0016C6B8
	protected override void OnBeforeCreate()
	{
		this.SequencePlayer = new LevelSequencePlayer(this.RootItem);
		UUIItem rootItem = this.RootItem;
		if (rootItem != null)
		{
			rootItem.SetUIActive(false);
		}
		UUIItem rootItem2 = this.RootItem;
		object obj;
		if (rootItem2 == null)
		{
			obj = null;
		}
		else
		{
			AActor owner = rootItem2.GetOwner();
			obj = ((owner != null) ? owner.GetComponentByClass(UUITexture.StaticClass()) : null);
		}
		this.IconHitResult = (obj as UUITexture);
	}

	// Token: 0x06004195 RID: 16789 RVA: 0x0016E51C File Offset: 0x0016C71C
	public void SetHitResult(EKuroRhythmGameRating result)
	{
		UUIItem rootItem = this.RootItem;
		if (rootItem != null)
		{
			rootItem.SetUIActive(true);
		}
		UiResource? uiResource;
		base.SetTextureByPath(((ConfigUiResourceById.GetConfig(RhythmGameModelDefine.RhythmGameHitResultTexture[result], true) != null) ? uiResource.GetValueOrDefault().Path : null) ?? "", this.IconHitResult, null, null);
		LevelSequencePlayer sequencePlayer = this.SequencePlayer;
		if (sequencePlayer != null)
		{
			sequencePlayer.StopPlayingSequence(false, true);
		}
		LevelSequencePlayer sequencePlayer2 = this.SequencePlayer;
		if (sequencePlayer2 == null)
		{
			return;
		}
		sequencePlayer2.PlayLevelSequenceByName("Start", false, null, false);
	}

	// Token: 0x04003367 RID: 13159
	private LevelSequencePlayer SequencePlayer;

	// Token: 0x04003368 RID: 13160
	private UUITexture IconHitResult;
}
