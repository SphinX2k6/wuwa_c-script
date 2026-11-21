using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.AutoAttach;
using UnrealEngine;

// Token: 0x020010DF RID: 4319
[NullableContext(2)]
[Nullable(0)]
public class MemoryDetailAttachItem : AutoAttachItem<int?>
{
	// Token: 0x0600AC4B RID: 44107 RVA: 0x0032B9C5 File Offset: 0x00329BC5
	public MemoryDetailAttachItem(AActor actor) : base(actor)
	{
	}

	// Token: 0x0600AC4C RID: 44108 RVA: 0x0032B9D0 File Offset: 0x00329BD0
	protected unsafe override void OnRegisterComponent()
	{
		int num = 7;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIExtendToggle));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x0600AC4D RID: 44109 RVA: 0x0032BADE File Offset: 0x00329CDE
	protected override UUIExtendToggle GetSelectToggle()
	{
		return base.GetExtendToggle(5);
	}

	// Token: 0x0600AC4E RID: 44110 RVA: 0x0032BAE7 File Offset: 0x00329CE7
	protected override void OnSelectToggleClick()
	{
		EventSystem.Instance.Emit<int>(EEventName.OnFragmentTopicClick, this.CurrentId);
	}

	// Token: 0x0600AC4F RID: 44111 RVA: 0x0032BAFF File Offset: 0x00329CFF
	private void TryInitLevelSequencePlayer()
	{
		if (this.LevelSequencePlayer == null)
		{
			this.LevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
		}
	}

	// Token: 0x0600AC50 RID: 44112 RVA: 0x0032BB1C File Offset: 0x00329D1C
	protected override void OnRefreshItem(int? id)
	{
		this.TryInitLevelSequencePlayer();
		this.UnBindRedDot();
		this.CurrentId = id.GetValueOrDefault(-1);
		if (id == null)
		{
			this.CurrentData = null;
		}
		else
		{
			PhotoMemoryTopic? photoMemoryTopicById = FragmentMemoryConfig.Instance.GetPhotoMemoryTopicById(id.Value);
			this.CurrentData = photoMemoryTopicById;
		}
		this.RefreshFinishItem();
		this.RefreshDescText();
		this.RefreshNameText();
		this.RefreshSprite();
		this.BindRedDot(id);
	}

	// Token: 0x0600AC51 RID: 44113 RVA: 0x0032BB94 File Offset: 0x00329D94
	private void BindRedDot(int? id)
	{
		if (id != null)
		{
			this.RedDotName = new ERedDotName?(ERedDotName.FragmentMemoryTopic);
			if (this.RedDotName != null)
			{
				RedDotController.Instance.BindRedDot(this.RedDotName.Value, base.GetItem(6), null, id.Value);
			}
			return;
		}
		UUIItem item = base.GetItem(6);
		if (item == null)
		{
			return;
		}
		item.SetUIActive(false);
	}

	// Token: 0x0600AC52 RID: 44114 RVA: 0x0032BC00 File Offset: 0x00329E00
	private void UnBindRedDot()
	{
		if (this.RedDotName != null)
		{
			RedDotController.Instance.UnBindGivenUi(this.RedDotName.Value, base.GetItem(6), (this.CurrentData != null) ? this.CurrentData.GetValueOrDefault().Id : -1);
			this.RedDotName = null;
		}
	}

	// Token: 0x0600AC53 RID: 44115 RVA: 0x0032BC64 File Offset: 0x00329E64
	private void RefreshSprite()
	{
		if (this.CurrentId == -1)
		{
			this.SetSpriteByPath(FragmentMemoryConfig.Instance.GetTopicNotOpenTexturePath(), base.GetSprite(0), false, null, null);
			this.SetSpriteByPath(FragmentMemoryConfig.Instance.GetTopicNotOpenTextureLightPath(), base.GetSprite(1), false, null, null);
			return;
		}
		if (this.CurrentData != null)
		{
			this.SetSpriteByPath(this.CurrentData.Value.BgResource, base.GetSprite(0), false, null, null);
			this.SetSpriteByPath(this.CurrentData.Value.BgResourceLight, base.GetSprite(1), false, null, null);
		}
	}

	// Token: 0x0600AC54 RID: 44116 RVA: 0x0032BD24 File Offset: 0x00329F24
	private void RefreshNameText()
	{
		if (this.CurrentId == -1 || this.CurrentData == null)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(2), "FragmentMemoryNotOpen", Array.Empty<object>());
			return;
		}
		UUIText text = base.GetText(2);
		if (text == null)
		{
			return;
		}
		text.ShowTextNew(this.CurrentData.Value.Title);
	}

	// Token: 0x0600AC55 RID: 44117 RVA: 0x0032BD88 File Offset: 0x00329F88
	private void RefreshDescText()
	{
		if (this.CurrentId == -1 || this.CurrentData == null)
		{
			UUIText text = base.GetText(3);
			if (text == null)
			{
				return;
			}
			text.SetText("", true);
			return;
		}
		else
		{
			IReadOnlyList<PhotoMemoryCollect> photoMemoryCollectConfigListByTopicId = FragmentMemoryConfig.Instance.GetPhotoMemoryCollectConfigListByTopicId(this.CurrentData.Value.Id);
			if (photoMemoryCollectConfigListByTopicId == null)
			{
				return;
			}
			int num = 0;
			foreach (PhotoMemoryCollect photoMemoryCollect in photoMemoryCollectConfigListByTopicId)
			{
				FragmentMemoryCollectData collectDataById = FragmentMemoryModel.Instance.GetCollectDataById(photoMemoryCollect.Id);
				if (collectDataById != null && collectDataById.GetIfUnlock())
				{
					num++;
				}
			}
			LguiUtil.Instance.SetLocalTextNew(base.GetText(3), "FragmentMemoryCollectProgress", new <>z__ReadOnlyArray<object>(new object[]
			{
				num.ToString(),
				photoMemoryCollectConfigListByTopicId.Count.ToString()
			}));
			return;
		}
	}

	// Token: 0x0600AC56 RID: 44118 RVA: 0x0032BE80 File Offset: 0x0032A080
	private void RefreshFinishItem()
	{
		if (this.CurrentData == null)
		{
			UUIItem item = base.GetItem(4);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(false);
			return;
		}
		else
		{
			FragmentMemoryTopicData topicDataById = FragmentMemoryModel.Instance.GetTopicDataById(this.CurrentData.Value.Id);
			bool uiactive = false;
			if (topicDataById != null && topicDataById.GetAllCollectState())
			{
				uiactive = true;
			}
			UUIItem item2 = base.GetItem(4);
			if (item2 == null)
			{
				return;
			}
			item2.SetUIActive(uiactive);
			return;
		}
	}

	// Token: 0x0600AC57 RID: 44119 RVA: 0x0032BEEC File Offset: 0x0032A0EC
	public override void OnSelect()
	{
		LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
		if (levelSequencePlayer != null)
		{
			levelSequencePlayer.StopCurrentSequence(false, false);
		}
		LevelSequencePlayer levelSequencePlayer2 = this.LevelSequencePlayer;
		if (levelSequencePlayer2 != null)
		{
			levelSequencePlayer2.PlaySequencePurely("Select", false, false, null, null, false);
		}
		EventSystem.Instance.Emit<int>(EEventName.OnFragmentTopicSelect, this.CurrentId);
		this.CurrentSelectState = true;
	}

	// Token: 0x0600AC58 RID: 44120 RVA: 0x0032BF4C File Offset: 0x0032A14C
	protected override void OnUnSelect()
	{
		if (this.CurrentSelectState)
		{
			LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
			if (levelSequencePlayer != null)
			{
				levelSequencePlayer.StopCurrentSequence(false, false);
			}
			LevelSequencePlayer levelSequencePlayer2 = this.LevelSequencePlayer;
			if (levelSequencePlayer2 != null)
			{
				levelSequencePlayer2.PlaySequencePurely("Unselect", false, false, null, null, false);
			}
		}
		this.CurrentSelectState = false;
	}

	// Token: 0x0600AC59 RID: 44121 RVA: 0x0032BF9E File Offset: 0x0032A19E
	protected override void OnBeforeDestroy()
	{
		this.UnBindRedDot();
	}

	// Token: 0x0600AC5A RID: 44122 RVA: 0x0032BFA6 File Offset: 0x0032A1A6
	protected override void OnMoveItem()
	{
	}

	// Token: 0x04006367 RID: 25447
	private PhotoMemoryTopic? CurrentData;

	// Token: 0x04006368 RID: 25448
	private int CurrentId;

	// Token: 0x04006369 RID: 25449
	private LevelSequencePlayer LevelSequencePlayer;

	// Token: 0x0400636A RID: 25450
	private bool CurrentSelectState;

	// Token: 0x0400636B RID: 25451
	private ERedDotName? RedDotName;

	// Token: 0x02007362 RID: 29538
	[NullableContext(0)]
	private class EComponents
	{
		// Token: 0x04025933 RID: 153907
		public const int MemorySprite = 0;

		// Token: 0x04025934 RID: 153908
		public const int MemorySpriteLight = 1;

		// Token: 0x04025935 RID: 153909
		public const int NameText = 2;

		// Token: 0x04025936 RID: 153910
		public const int DescText = 3;

		// Token: 0x04025937 RID: 153911
		public const int FinishItem = 4;

		// Token: 0x04025938 RID: 153912
		public const int Toggle = 5;

		// Token: 0x04025939 RID: 153913
		public const int RedDot = 6;
	}
}
