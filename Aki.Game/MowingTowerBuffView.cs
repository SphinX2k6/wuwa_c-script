using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02000827 RID: 2087
[NullableContext(1)]
[Nullable(0)]
public class MowingTowerBuffView : UiViewBase
{
	// Token: 0x06005EFD RID: 24317 RVA: 0x001E598F File Offset: 0x001E3B8F
	public MowingTowerBuffView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06005EFE RID: 24318 RVA: 0x001E59A8 File Offset: 0x001E3BA8
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUILoopScrollViewComponent)),
			new ValueTuple<int, Type>(2, typeof(UUIText)),
			new ValueTuple<int, Type>(3, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(4, typeof(UUIItem))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(3, new Action(this.OnClickConfirmButton))
		};
	}

	// Token: 0x06005EFF RID: 24319 RVA: 0x001E5A54 File Offset: 0x001E3C54
	protected override void OnStart()
	{
		this.CaptionItem = new PopupCaptionItem(base.GetItem(0));
		this.CaptionItem.SetCloseCallBack(delegate
		{
			base.CloseMe(null);
		});
		this.CaptionItem.SetTitleByTextIdAndArgNew("MowingTowerBuffViewTitle", Array.Empty<object>());
		this.LoopScrollView = new LoopScrollView<BuffGridItem, BuffGridItemData>(base.GetLoopScrollViewComponent(1), base.GetItem(4).GetOwner() as AUIBaseActor, new Func<BuffGridItem>(this.CreateLoopItem), false);
		this.LevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
	}

	// Token: 0x06005F00 RID: 24320 RVA: 0x001E5AE0 File Offset: 0x001E3CE0
	private BuffGridItem CreateLoopItem()
	{
		return new BuffGridItem();
	}

	// Token: 0x06005F01 RID: 24321 RVA: 0x001E5AE8 File Offset: 0x001E3CE8
	private void OnClickConfirmButton()
	{
		List<MowingTowerBuffInfo> list = new List<MowingTowerBuffInfo>();
		int num = 1;
		for (int i = 0; i < this.CurrentSelectableBuffData.Count; i++)
		{
			BuffScrollItemData buffScrollItemData = this.CurrentSelectableBuffData[i];
			if (buffScrollItemData.Selected)
			{
				MowingTowerBuffInfo mowingTowerBuffInfo = new MowingTowerBuffInfo();
				mowingTowerBuffInfo.BuffId = buffScrollItemData.BuffId;
				mowingTowerBuffInfo.ChangeAble = true;
				mowingTowerBuffInfo.Slot = num;
				num++;
				list.Add(mowingTowerBuffInfo);
			}
		}
		int currentSelectCount = this.GetCurrentSelectCount();
		if (currentSelectCount < this.CurrentTeamInfo.GetBuffMaxCount())
		{
			for (int j = currentSelectCount; j < this.CurrentTeamInfo.GetBuffMaxCount(); j++)
			{
				MowingTowerBuffInfo indexPrepareSelectBuff = this.CurrentTeamInfo.GetIndexPrepareSelectBuff(j);
				MowingTowerBuffInfo mowingTowerBuffInfo2 = new MowingTowerBuffInfo();
				mowingTowerBuffInfo2.BuffId = 0;
				mowingTowerBuffInfo2.ChangeAble = (indexPrepareSelectBuff == null || indexPrepareSelectBuff.ChangeAble);
				mowingTowerBuffInfo2.Slot = num;
				num++;
				list.Add(mowingTowerBuffInfo2);
			}
		}
		this.CurrentTeamInfo.SetPrepareSelectBuff(list.ToArray());
		EventSystem.Instance.Emit(EEventName.ChangeMowingTowerBuff);
		base.CloseMe(null);
	}

	// Token: 0x06005F02 RID: 24322 RVA: 0x001E5BFC File Offset: 0x001E3DFC
	protected override void OnBeforeShow()
	{
		this.TryShowAnimation();
		this.CurrentTeamInfo = MowingTowerModel.Instance.CurrentTeamInfo;
		this.CurrentSelectableBuffData = new List<BuffScrollItemData>();
		List<MowingTowerBuffInfo> optionBuff = this.CurrentTeamInfo.GetOptionBuff();
		List<MowingTowerBuffInfo> prepareSelectBuff = this.CurrentTeamInfo.GetPrepareSelectBuff();
		for (int i = 0; i < optionBuff.Count; i++)
		{
			MowingTowerBuffInfo mowingTowerBuffInfo = optionBuff[i];
			BuffScrollItemData buffScrollItemData = new BuffScrollItemData();
			buffScrollItemData.BuffId = mowingTowerBuffInfo.BuffId;
			bool selected = false;
			for (int j = 0; j < prepareSelectBuff.Count; j++)
			{
				if (prepareSelectBuff[j].BuffId == mowingTowerBuffInfo.BuffId)
				{
					selected = true;
					break;
				}
			}
			buffScrollItemData.Selected = selected;
			buffScrollItemData.SelectedAtStart = buffScrollItemData.Selected;
			buffScrollItemData.OnClickToggle = new Action<BuffScrollItemData>(this.OnClickToggle);
			buffScrollItemData.CheckClickAble = new Func<BuffScrollItemData, bool>(this.CheckClickAble);
			this.CurrentSelectableBuffData.Add(buffScrollItemData);
		}
		this.RefreshScrollView();
		this.RefreshCountText();
		this.IsBuffMaxCountOne = (this.CurrentTeamInfo.LevelInfo.GetMaxBuffCount() == 1);
	}

	// Token: 0x06005F03 RID: 24323 RVA: 0x001E5D18 File Offset: 0x001E3F18
	private void TryShowAnimation()
	{
		string sequenceName = "Start";
		if (MowingTowerModel.Instance.PlayBackAnimation)
		{
			sequenceName = "ShowView";
		}
		LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
		if (levelSequencePlayer != null)
		{
			levelSequencePlayer.PlaySequencePurely(sequenceName, false, false, null, null, false);
		}
		MowingTowerModel.Instance.PlayBackAnimation = false;
	}

	// Token: 0x06005F04 RID: 24324 RVA: 0x001E5D68 File Offset: 0x001E3F68
	private void OnClickToggle(BuffScrollItemData data)
	{
		if (this.IsBuffMaxCountOne && !data.Selected)
		{
			for (int i = 0; i < this.CurrentSelectableBuffData.Count; i++)
			{
				this.CurrentSelectableBuffData[i].Selected = false;
			}
		}
		data.Selected = !data.Selected;
		this.RefreshScrollView();
		this.RefreshCountText();
	}

	// Token: 0x06005F05 RID: 24325 RVA: 0x001E5DC8 File Offset: 0x001E3FC8
	private bool CheckClickAble(BuffScrollItemData data)
	{
		return this.FirstRefresh || data.Selected || this.CheckIfStillCanSelectBuff();
	}

	// Token: 0x06005F06 RID: 24326 RVA: 0x001E5DEC File Offset: 0x001E3FEC
	private bool CheckIfStillCanSelectBuff()
	{
		if (this.FirstRefresh)
		{
			return true;
		}
		if (this.IsBuffMaxCountOne || this.CurrentTeamInfo.LevelInfo.GetMaxBuffCount() > this.GetCurrentSelectCount())
		{
			return true;
		}
		ScrollingTipsController.Instance.ShowTipsById("BossRushMaxBuffText", Array.Empty<object>());
		return false;
	}

	// Token: 0x06005F07 RID: 24327 RVA: 0x001E5E3C File Offset: 0x001E403C
	private int GetCurrentSelectCount()
	{
		int num = 0;
		for (int i = 0; i < this.CurrentSelectableBuffData.Count; i++)
		{
			if (this.CurrentSelectableBuffData[i].Selected)
			{
				num++;
			}
		}
		return num;
	}

	// Token: 0x06005F08 RID: 24328 RVA: 0x001E5E7C File Offset: 0x001E407C
	private void RefreshScrollView()
	{
		if (this.LoopScrollView != null)
		{
			List<BuffGridItemData> list = new List<BuffGridItemData>();
			this.FirstRefresh = true;
			for (int i = 0; i < this.CurrentSelectableBuffData.Count; i += 2)
			{
				BuffGridItemData buffGridItemData = new BuffGridItemData();
				buffGridItemData.BuffScrollItemData1 = this.CurrentSelectableBuffData[i];
				if (i + 1 >= this.CurrentSelectableBuffData.Count)
				{
					list.Add(buffGridItemData);
					break;
				}
				buffGridItemData.BuffScrollItemData2 = this.CurrentSelectableBuffData[i + 1];
				list.Add(buffGridItemData);
			}
			this.LoopScrollView.RefreshByData(list, false, delegate
			{
				this.FirstRefresh = false;
			}, false);
			base.GetLoopScrollViewComponent(1).RootUIComp.Get().SetUIActive(list.Count > 0);
		}
	}

	// Token: 0x06005F09 RID: 24329 RVA: 0x001E5F3F File Offset: 0x001E413F
	protected override void OnBeforeHide()
	{
		LoopScrollView<BuffGridItem, BuffGridItemData> loopScrollView = this.LoopScrollView;
		if (loopScrollView == null)
		{
			return;
		}
		loopScrollView.ClearGridProxies();
	}

	// Token: 0x06005F0A RID: 24330 RVA: 0x001E5F51 File Offset: 0x001E4151
	private void RefreshCountText()
	{
		UUIText text = base.GetText(2);
		if (text == null)
		{
			return;
		}
		text.SetUIActive(false);
	}

	// Token: 0x04003E65 RID: 15973
	[Nullable(2)]
	private PopupCaptionItem CaptionItem;

	// Token: 0x04003E66 RID: 15974
	[Nullable(2)]
	private MowingTowerTeamInfo CurrentTeamInfo;

	// Token: 0x04003E67 RID: 15975
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private List<BuffScrollItemData> CurrentSelectableBuffData;

	// Token: 0x04003E68 RID: 15976
	private bool FirstRefresh = true;

	// Token: 0x04003E69 RID: 15977
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private LoopScrollView<BuffGridItem, BuffGridItemData> LoopScrollView;

	// Token: 0x04003E6A RID: 15978
	[Nullable(2)]
	private LevelSequencePlayer LevelSequencePlayer;

	// Token: 0x04003E6B RID: 15979
	private bool IsBuffMaxCountOne = true;

	// Token: 0x02006B76 RID: 27510
	[NullableContext(0)]
	private static class EComponent
	{
		// Token: 0x04023539 RID: 144697
		public const int CaptionItem = 0;

		// Token: 0x0402353A RID: 144698
		public const int LoopScrollView = 1;

		// Token: 0x0402353B RID: 144699
		public const int SelectCountText = 2;

		// Token: 0x0402353C RID: 144700
		public const int ConfirmButton = 3;

		// Token: 0x0402353D RID: 144701
		public const int LoopItem = 4;
	}
}
