using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001BCC RID: 7116
[NullableContext(2)]
[Nullable(0)]
public class PhantomPanel : UiPanelBase
{
	// Token: 0x0600D435 RID: 54325 RVA: 0x0030D49B File Offset: 0x0030B69B
	[NullableContext(1)]
	public PhantomPanel(UUIItem attachedItem)
	{
		this.AttachedUiItem = attachedItem;
	}

	// Token: 0x0600D436 RID: 54326 RVA: 0x0030D4AC File Offset: 0x0030B6AC
	protected unsafe override void OnRegisterComponent()
	{
		int num = 6;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(19, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(20, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(21, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(22, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(23, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(24, typeof(UUITexture));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(20, new Action(this.OnClick));
		this.BtnBindInfo = list2;
	}

	// Token: 0x0600D437 RID: 54327 RVA: 0x0030D5E0 File Offset: 0x0030B7E0
	protected override void OnBeforeDestroy()
	{
		this.PlayerId = 0;
		this.RoleCfgId = 0;
		LevelSequencePlayer loopSeqPlayer = this.LoopSeqPlayer;
		if (loopSeqPlayer != null)
		{
			loopSeqPlayer.StopCurrentSequence(false, false);
		}
		this.LoopSeqPlayer = null;
		this.IsLoopPlaying = false;
		LevelSequencePlayer iconSeqPlayer = this.IconSeqPlayer;
		if (iconSeqPlayer != null)
		{
			iconSeqPlayer.StopCurrentSequence(false, false);
		}
		this.IconSeqPlayer = null;
		this.LastIconPath = null;
	}

	// Token: 0x0600D438 RID: 54328 RVA: 0x0030D63D File Offset: 0x0030B83D
	protected override void OnStart()
	{
		this.LoopSeqPlayer = new LevelSequencePlayer(base.GetItem(19));
		this.IconSeqPlayer = new LevelSequencePlayer(this.AttachedUiItem);
	}

	// Token: 0x0600D439 RID: 54329 RVA: 0x0030D664 File Offset: 0x0030B864
	[NullableContext(1)]
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	public override UUIItem[] GetGuideUiItemAndUiItemForShowEx(string[] configParams)
	{
		UUIButtonComponent button = base.GetButton(20);
		UUIItem uuiitem = (button != null) ? button.GetRootComponent() : null;
		if (uuiitem == null)
		{
			return null;
		}
		return new UUIItem[]
		{
			uuiitem,
			uuiitem
		};
	}

	// Token: 0x0600D43A RID: 54330 RVA: 0x0030D699 File Offset: 0x0030B899
	private void OnClick()
	{
		TowerDefenseController.Instance.TryOpenPhantomViewByPlayerIdAndRoleId(this.PlayerId, this.RoleCfgId);
	}

	// Token: 0x0600D43B RID: 54331 RVA: 0x0030D6B1 File Offset: 0x0030B8B1
	public void SetRedDotActive(bool value)
	{
		base.GetItem(21).SetUIActive(value);
	}

	// Token: 0x0600D43C RID: 54332 RVA: 0x0030D6C4 File Offset: 0x0030B8C4
	public void SetIcon(string path = null, bool isSelf = true)
	{
		UUISprite sprite = base.GetSprite(22);
		UUISprite sprite2 = base.GetSprite(23);
		UUITexture texture = base.GetTexture(24);
		base.GetButton(20).IsSelfInteractive = isSelf;
		bool flag = path != this.LastIconPath;
		this.LastIconPath = path;
		if (!string.IsNullOrEmpty(path))
		{
			sprite.SetUIActive(false);
			sprite2.SetUIActive(false);
			texture.SetUIActive(true);
			base.SetTextureByPath(path, base.GetTexture(24), null, null);
			if (flag)
			{
				if (!isSelf)
				{
					this.LoopSeqPlayer.StopCurrentSequence(false, false);
					this.IsLoopPlaying = false;
				}
				this.IconSeqPlayer.PlayLevelSequenceByName("VisionIn", false, null, false);
				return;
			}
		}
		else
		{
			sprite.SetUIActive(isSelf);
			sprite2.SetUIActive(!isSelf);
			texture.SetUIActive(false);
			if (isSelf)
			{
				if (flag)
				{
					this.IconSeqPlayer.PlayLevelSequenceByName("VisionOut", false, null, false);
					return;
				}
			}
			else if (!this.IsLoopPlaying)
			{
				this.IsLoopPlaying = true;
				this.LoopSeqPlayer.PlayLevelSequenceByName("Loop", false, null, false);
			}
		}
	}

	// Token: 0x0600D43D RID: 54333 RVA: 0x0030D7E5 File Offset: 0x0030B9E5
	public void SetRelativeUiActive(bool active)
	{
		base.GetItem(19).SetUIActive(active);
	}

	// Token: 0x040060FE RID: 24830
	public int PlayerId;

	// Token: 0x040060FF RID: 24831
	public int RoleCfgId;

	// Token: 0x04006100 RID: 24832
	private readonly UUIItem AttachedUiItem;

	// Token: 0x04006101 RID: 24833
	private LevelSequencePlayer LoopSeqPlayer;

	// Token: 0x04006102 RID: 24834
	private LevelSequencePlayer IconSeqPlayer;

	// Token: 0x04006103 RID: 24835
	private string LastIconPath;

	// Token: 0x04006104 RID: 24836
	private bool IsLoopPlaying;

	// Token: 0x02008187 RID: 33159
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x0402A439 RID: 173113
		VisionPanel = 19,
		// Token: 0x0402A43A RID: 173114
		VisionButton,
		// Token: 0x0402A43B RID: 173115
		RedDotItem,
		// Token: 0x0402A43C RID: 173116
		AddSprite,
		// Token: 0x0402A43D RID: 173117
		WaitingSprite,
		// Token: 0x0402A43E RID: 173118
		IconTexture
	}
}
