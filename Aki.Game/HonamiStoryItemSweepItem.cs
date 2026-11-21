using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.HonamiStory;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001368 RID: 4968
[NullableContext(1)]
[Nullable(0)]
public class HonamiStoryItemSweepItem : UiPanelBase
{
	// Token: 0x0600C4F7 RID: 50423 RVA: 0x003A91C4 File Offset: 0x003A73C4
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUITexture)),
			new ValueTuple<int, Type>(1, typeof(UUITexture)),
			new ValueTuple<int, Type>(2, typeof(UUITexture))
		};
	}

	// Token: 0x0600C4F8 RID: 50424 RVA: 0x003A921E File Offset: 0x003A741E
	protected override void OnStart()
	{
		this.LevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
		this.LevelSequencePlayer.BindSequenceCloseEvent(new TSequenceEndEvent(this.OnSeqEnd), false);
	}

	// Token: 0x0600C4F9 RID: 50425 RVA: 0x003A9249 File Offset: 0x003A7449
	private void OnSeqEnd(string seqName)
	{
		Action<string> seqEndCb = this.SeqEndCb;
		if (seqEndCb != null)
		{
			seqEndCb(seqName);
		}
		this.SetSweepTextureActive(false);
	}

	// Token: 0x0600C4FA RID: 50426 RVA: 0x003A9264 File Offset: 0x003A7464
	public void BindSeqEndCb(Action<string> cb)
	{
		this.SeqEndCb = cb;
	}

	// Token: 0x0600C4FB RID: 50427 RVA: 0x003A9270 File Offset: 0x003A7470
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

	// Token: 0x0600C4FC RID: 50428 RVA: 0x003A9354 File Offset: 0x003A7554
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

	// Token: 0x0600C4FD RID: 50429 RVA: 0x003A9386 File Offset: 0x003A7586
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

	// Token: 0x0600C4FE RID: 50430 RVA: 0x003A93A9 File Offset: 0x003A75A9
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

	// Token: 0x0600C4FF RID: 50431 RVA: 0x003A93D0 File Offset: 0x003A75D0
	private void SetActivateTextureActive(bool isActive)
	{
		UUITexture texture = base.GetTexture(2);
		if (texture == null)
		{
			return;
		}
		texture.SetUIActive(isActive);
	}

	// Token: 0x0600C500 RID: 50432 RVA: 0x003A93E4 File Offset: 0x003A75E4
	protected override void OnBeforeShow()
	{
		this.SetSweepTextureActive(false);
	}

	// Token: 0x0600C501 RID: 50433 RVA: 0x003A93ED File Offset: 0x003A75ED
	protected override void OnBeforeHide()
	{
		this.SetSweepTextureActive(false);
	}

	// Token: 0x04007040 RID: 28736
	[Nullable(2)]
	private LevelSequencePlayer LevelSequencePlayer;

	// Token: 0x04007041 RID: 28737
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private Action<string> SeqEndCb;

	// Token: 0x020075F3 RID: 30195
	[NullableContext(0)]
	private enum ESweepComponent
	{
		// Token: 0x040264C4 RID: 156868
		SweepInTexture,
		// Token: 0x040264C5 RID: 156869
		SweepTipsTexture,
		// Token: 0x040264C6 RID: 156870
		ActivateTexture
	}
}
