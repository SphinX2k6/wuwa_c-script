using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001086 RID: 4230
[NullableContext(2)]
[Nullable(0)]
public class RhythmGameHitResultPanel : UiPanelBase
{
	// Token: 0x06006DFF RID: 28159 RVA: 0x00165B84 File Offset: 0x00163D84
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

	// Token: 0x06006E00 RID: 28160 RVA: 0x00165BE8 File Offset: 0x00163DE8
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

	// Token: 0x040032CE RID: 13006
	private LevelSequencePlayer SequencePlayer;

	// Token: 0x040032CF RID: 13007
	private UUITexture IconHitResult;
}
