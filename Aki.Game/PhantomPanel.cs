using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x0200108B RID: 4235
[NullableContext(2)]
[Nullable(0)]
public class PhantomPanel : UiPanelBase
{
	// Token: 0x0600A847 RID: 43079 RVA: 0x0031860F File Offset: 0x0031680F
	[NullableContext(1)]
	public PhantomPanel(UUIItem attachedItem)
	{
		this.AttachedUiItem = attachedItem;
	}

	// Token: 0x0600A848 RID: 43080 RVA: 0x00318620 File Offset: 0x00316820
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

	// Token: 0x0600A849 RID: 43081 RVA: 0x00318754 File Offset: 0x00316954
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

	// Token: 0x0600A84A RID: 43082 RVA: 0x003187B1 File Offset: 0x003169B1
	protected override void OnStart()
	{
		this.LoopSeqPlayer = new LevelSequencePlayer(base.GetItem(19));
		this.IconSeqPlayer = new LevelSequencePlayer(this.AttachedUiItem);
	}

	// Token: 0x0600A84B RID: 43083 RVA: 0x003187D8 File Offset: 0x003169D8
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

	// Token: 0x0600A84C RID: 43084 RVA: 0x0031880D File Offset: 0x00316A0D
	private void OnClick()
	{
		TowerDefenseController.Instance.TryOpenPhantomViewByPlayerIdAndRoleId(this.PlayerId, this.RoleCfgId);
	}

	// Token: 0x0600A84D RID: 43085 RVA: 0x00318825 File Offset: 0x00316A25
	public void SetRedDotActive(bool value)
	{
		base.GetItem(21).SetUIActive(value);
	}

	// Token: 0x0600A84E RID: 43086 RVA: 0x00318838 File Offset: 0x00316A38
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

	// Token: 0x0600A84F RID: 43087 RVA: 0x00318959 File Offset: 0x00316B59
	public void SetRelativeUiActive(bool active)
	{
		base.GetItem(19).SetUIActive(active);
	}

	// Token: 0x040061CD RID: 25037
	public int PlayerId;

	// Token: 0x040061CE RID: 25038
	public int RoleCfgId;

	// Token: 0x040061CF RID: 25039
	private readonly UUIItem AttachedUiItem;

	// Token: 0x040061D0 RID: 25040
	private LevelSequencePlayer LoopSeqPlayer;

	// Token: 0x040061D1 RID: 25041
	private LevelSequencePlayer IconSeqPlayer;

	// Token: 0x040061D2 RID: 25042
	private string LastIconPath;

	// Token: 0x040061D3 RID: 25043
	private bool IsLoopPlaying;

	// Token: 0x02007315 RID: 29461
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x0402576D RID: 153453
		VisionPanel = 19,
		// Token: 0x0402576E RID: 153454
		VisionButton,
		// Token: 0x0402576F RID: 153455
		RedDotItem,
		// Token: 0x04025770 RID: 153456
		AddSprite,
		// Token: 0x04025771 RID: 153457
		WaitingSprite,
		// Token: 0x04025772 RID: 153458
		IconTexture
	}
}
