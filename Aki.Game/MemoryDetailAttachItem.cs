using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.AutoAttach;
using UnrealEngine;

// Token: 0x02001C20 RID: 7200
[NullableContext(2)]
[Nullable(0)]
public class MemoryDetailAttachItem : AutoAttachItem<int?>
{
	// Token: 0x0600D835 RID: 55349 RVA: 0x003205ED File Offset: 0x0031E7ED
	public MemoryDetailAttachItem(AActor actor) : base(actor)
	{
	}

	// Token: 0x0600D836 RID: 55350 RVA: 0x003205F8 File Offset: 0x0031E7F8
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

	// Token: 0x0600D837 RID: 55351 RVA: 0x00320706 File Offset: 0x0031E906
	protected override UUIExtendToggle GetSelectToggle()
	{
		return base.GetExtendToggle(5);
	}

	// Token: 0x0600D838 RID: 55352 RVA: 0x0032070F File Offset: 0x0031E90F
	protected override void OnSelectToggleClick()
	{
		EventSystem.Instance.Emit<int>(EEventName.OnFragmentTopicClick, this.CurrentId);
	}

	// Token: 0x0600D839 RID: 55353 RVA: 0x00320727 File Offset: 0x0031E927
	private void TryInitLevelSequencePlayer()
	{
		if (this.LevelSequencePlayer == null)
		{
			this.LevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
		}
	}

	// Token: 0x0600D83A RID: 55354 RVA: 0x00320744 File Offset: 0x0031E944
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

	// Token: 0x0600D83B RID: 55355 RVA: 0x003207BC File Offset: 0x0031E9BC
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

	// Token: 0x0600D83C RID: 55356 RVA: 0x00320828 File Offset: 0x0031EA28
	private void UnBindRedDot()
	{
		if (this.RedDotName != null)
		{
			RedDotController.Instance.UnBindGivenUi(this.RedDotName.Value, base.GetItem(6), (this.CurrentData != null) ? this.CurrentData.GetValueOrDefault().Id : -1);
			this.RedDotName = null;
		}
	}

	// Token: 0x0600D83D RID: 55357 RVA: 0x0032088C File Offset: 0x0031EA8C
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

	// Token: 0x0600D83E RID: 55358 RVA: 0x0032094C File Offset: 0x0031EB4C
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

	// Token: 0x0600D83F RID: 55359 RVA: 0x003209B0 File Offset: 0x0031EBB0
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

	// Token: 0x0600D840 RID: 55360 RVA: 0x00320AA8 File Offset: 0x0031ECA8
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

	// Token: 0x0600D841 RID: 55361 RVA: 0x00320B14 File Offset: 0x0031ED14
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

	// Token: 0x0600D842 RID: 55362 RVA: 0x00320B74 File Offset: 0x0031ED74
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

	// Token: 0x0600D843 RID: 55363 RVA: 0x00320BC6 File Offset: 0x0031EDC6
	protected override void OnBeforeDestroy()
	{
		this.UnBindRedDot();
	}

	// Token: 0x0600D844 RID: 55364 RVA: 0x00320BCE File Offset: 0x0031EDCE
	protected override void OnMoveItem()
	{
	}

	// Token: 0x04006295 RID: 25237
	private PhotoMemoryTopic? CurrentData;

	// Token: 0x04006296 RID: 25238
	private int CurrentId;

	// Token: 0x04006297 RID: 25239
	private LevelSequencePlayer LevelSequencePlayer;

	// Token: 0x04006298 RID: 25240
	private bool CurrentSelectState;

	// Token: 0x04006299 RID: 25241
	private ERedDotName? RedDotName;

	// Token: 0x020081D9 RID: 33241
	[NullableContext(0)]
	private class EComponents
	{
		// Token: 0x0402A60C RID: 173580
		public const int MemorySprite = 0;

		// Token: 0x0402A60D RID: 173581
		public const int MemorySpriteLight = 1;

		// Token: 0x0402A60E RID: 173582
		public const int NameText = 2;

		// Token: 0x0402A60F RID: 173583
		public const int DescText = 3;

		// Token: 0x0402A610 RID: 173584
		public const int FinishItem = 4;

		// Token: 0x0402A611 RID: 173585
		public const int Toggle = 5;

		// Token: 0x0402A612 RID: 173586
		public const int RedDot = 6;
	}
}
