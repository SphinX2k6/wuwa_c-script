using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.HonamiStory;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001EA6 RID: 7846
[NullableContext(1)]
[Nullable(0)]
public class HonamiStoryItemSweepItem : UiPanelBase
{
	// Token: 0x0600F0D8 RID: 61656 RVA: 0x0039D608 File Offset: 0x0039B808
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUITexture)),
			new ValueTuple<int, Type>(1, typeof(UUITexture)),
			new ValueTuple<int, Type>(2, typeof(UUITexture))
		};
	}

	// Token: 0x0600F0D9 RID: 61657 RVA: 0x0039D662 File Offset: 0x0039B862
	protected override void OnStart()
	{
		this.LevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
		this.LevelSequencePlayer.BindSequenceCloseEvent(new TSequenceEndEvent(this.OnSeqEnd), false);
	}

	// Token: 0x0600F0DA RID: 61658 RVA: 0x0039D68D File Offset: 0x0039B88D
	private void OnSeqEnd(string seqName)
	{
		Action<string> seqEndCb = this.SeqEndCb;
		if (seqEndCb != null)
		{
			seqEndCb(seqName);
		}
		this.SetSweepTextureActive(false);
	}

	// Token: 0x0600F0DB RID: 61659 RVA: 0x0039D6A8 File Offset: 0x0039B8A8
	public void BindSeqEndCb(Action<string> cb)
	{
		this.SeqEndCb = cb;
	}

	// Token: 0x0600F0DC RID: 61660 RVA: 0x0039D6B4 File Offset: 0x0039B8B4
	[NullableContext(2)]
	public void SetData(HonamiStoryItemDataBase data, EHonamiStoryBackpackType backpackType)
	{
		if (data != null)
		{
			HonamiStoryModel instance = HonamiStoryModel.Instance;
			bool isCross = data.GetIsCross();
			int baseGridWidth = data.GetBaseGridWidth(isCross);
			int baseGridHeight = data.GetBaseGridHeight(isCross);
			int num;
			int num2;
			if (backpackType != EHonamiStoryBackpackType.Player)
			{
				EHonamiStoryBackpack backpackId = HonamiStoryDefine.Instance.HonamiBackpackTypeMap[backpackType];
				HonamiStoryBackpackData backPackData = instance.GetBackPackData((int)backpackId, false);
				num = backPackData.GetCellWidth() * baseGridWidth + (baseGridWidth - 1) * backPackData.GetCellHorizontalInterval();
				num2 = backPackData.GetCellHeight() * baseGridHeight + (baseGridHeight - 1) * backPackData.GetCellVerticalInterval();
			}
			else
			{
				HonamiStoryPlayerBackpackData playerBackpackData = instance.GetPlayerBackpackData();
				num = playerBackpackData.GetCellWidth() * baseGridWidth + (baseGridWidth - 1) * playerBackpackData.GetCellHorizontalInterval();
				num2 = playerBackpackData.GetCellHeight() * baseGridHeight + (baseGridHeight - 1) * playerBackpackData.GetCellVerticalInterval();
			}
			UUIItem rootItem = this.RootItem;
			if (rootItem != null)
			{
				rootItem.SetWidth((float)num);
			}
			UUIItem rootItem2 = this.RootItem;
			if (rootItem2 == null)
			{
				return;
			}
			rootItem2.SetHeight((float)num2);
		}
	}

	// Token: 0x0600F0DD RID: 61661 RVA: 0x0039D798 File Offset: 0x0039B998
	public void PlaySequenceByNamePurely(string sequenceName)
	{
		this.SetSweepTextureActive(true);
		LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
		if (levelSequencePlayer == null)
		{
			return;
		}
		levelSequencePlayer.PlaySequencePurely(sequenceName, false, false, null, null, false);
	}

	// Token: 0x0600F0DE RID: 61662 RVA: 0x0039D7CA File Offset: 0x0039B9CA
	public void ClearSequence()
	{
		LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
		if (levelSequencePlayer != null)
		{
			levelSequencePlayer.StopCurrentSequence(false, true);
		}
		this.SetSweepTextureActive(false);
		this.SetActivateTextureActive(false);
	}

	// Token: 0x0600F0DF RID: 61663 RVA: 0x0039D7ED File Offset: 0x0039B9ED
	private void SetSweepTextureActive(bool isActive)
	{
		UUITexture texture = base.GetTexture(0);
		if (texture != null)
		{
			texture.SetUIActive(isActive);
		}
		UUITexture texture2 = base.GetTexture(1);
		if (texture2 == null)
		{
			return;
		}
		texture2.SetUIActive(isActive);
	}

	// Token: 0x0600F0E0 RID: 61664 RVA: 0x0039D814 File Offset: 0x0039BA14
	private void SetActivateTextureActive(bool isActive)
	{
		UUITexture texture = base.GetTexture(2);
		if (texture == null)
		{
			return;
		}
		texture.SetUIActive(isActive);
	}

	// Token: 0x0600F0E1 RID: 61665 RVA: 0x0039D828 File Offset: 0x0039BA28
	protected override void OnBeforeShow()
	{
		this.SetSweepTextureActive(false);
	}

	// Token: 0x0600F0E2 RID: 61666 RVA: 0x0039D831 File Offset: 0x0039BA31
	protected override void OnBeforeHide()
	{
		this.SetSweepTextureActive(false);
	}

	// Token: 0x04006F5F RID: 28511
	[Nullable(2)]
	private LevelSequencePlayer LevelSequencePlayer;

	// Token: 0x04006F60 RID: 28512
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private Action<string> SeqEndCb;

	// Token: 0x0200846E RID: 33902
	[NullableContext(0)]
	private enum ESweepComponent
	{
		// Token: 0x0402B1A0 RID: 176544
		SweepInTexture,
		// Token: 0x0402B1A1 RID: 176545
		SweepTipsTexture,
		// Token: 0x0402B1A2 RID: 176546
		ActivateTexture
	}
}
