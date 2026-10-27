using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001373 RID: 4979
[NullableContext(1)]
[Nullable(0)]
public class MowingTowerBuffView : UiViewBase
{
	// Token: 0x06008B62 RID: 35682 RVA: 0x001DCB53 File Offset: 0x001DAD53
	public MowingTowerBuffView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06008B63 RID: 35683 RVA: 0x001DCB6C File Offset: 0x001DAD6C
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

	// Token: 0x06008B64 RID: 35684 RVA: 0x001DCC18 File Offset: 0x001DAE18
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

	// Token: 0x06008B65 RID: 35685 RVA: 0x001DCCA4 File Offset: 0x001DAEA4
	private BuffGridItem CreateLoopItem()
	{
		return new BuffGridItem();
	}

	// Token: 0x06008B66 RID: 35686 RVA: 0x001DCCAC File Offset: 0x001DAEAC
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

	// Token: 0x06008B67 RID: 35687 RVA: 0x001DCDC0 File Offset: 0x001DAFC0
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

	// Token: 0x06008B68 RID: 35688 RVA: 0x001DCEDC File Offset: 0x001DB0DC
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

	// Token: 0x06008B69 RID: 35689 RVA: 0x001DCF2C File Offset: 0x001DB12C
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

	// Token: 0x06008B6A RID: 35690 RVA: 0x001DCF8C File Offset: 0x001DB18C
	private bool CheckClickAble(BuffScrollItemData data)
	{
		return this.FirstRefresh || data.Selected || this.CheckIfStillCanSelectBuff();
	}

	// Token: 0x06008B6B RID: 35691 RVA: 0x001DCFB0 File Offset: 0x001DB1B0
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

	// Token: 0x06008B6C RID: 35692 RVA: 0x001DD000 File Offset: 0x001DB200
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

	// Token: 0x06008B6D RID: 35693 RVA: 0x001DD040 File Offset: 0x001DB240
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

	// Token: 0x06008B6E RID: 35694 RVA: 0x001DD103 File Offset: 0x001DB303
	protected override void OnBeforeHide()
	{
		LoopScrollView<BuffGridItem, BuffGridItemData> loopScrollView = this.LoopScrollView;
		if (loopScrollView == null)
		{
			return;
		}
		loopScrollView.ClearGridProxies();
	}

	// Token: 0x06008B6F RID: 35695 RVA: 0x001DD115 File Offset: 0x001DB315
	private void RefreshCountText()
	{
		UUIText text = base.GetText(2);
		if (text == null)
		{
			return;
		}
		text.SetUIActive(false);
	}

	// Token: 0x04003DCD RID: 15821
	[Nullable(2)]
	private PopupCaptionItem CaptionItem;

	// Token: 0x04003DCE RID: 15822
	[Nullable(2)]
	private MowingTowerTeamInfo CurrentTeamInfo;

	// Token: 0x04003DCF RID: 15823
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private List<BuffScrollItemData> CurrentSelectableBuffData;

	// Token: 0x04003DD0 RID: 15824
	private bool FirstRefresh = true;

	// Token: 0x04003DD1 RID: 15825
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private LoopScrollView<BuffGridItem, BuffGridItemData> LoopScrollView;

	// Token: 0x04003DD2 RID: 15826
	[Nullable(2)]
	private LevelSequencePlayer LevelSequencePlayer;

	// Token: 0x04003DD3 RID: 15827
	private bool IsBuffMaxCountOne = true;

	// Token: 0x020079EC RID: 31212
	[NullableContext(0)]
	private static class EComponent
	{
		// Token: 0x0402820C RID: 164364
		public const int CaptionItem = 0;

		// Token: 0x0402820D RID: 164365
		public const int LoopScrollView = 1;

		// Token: 0x0402820E RID: 164366
		public const int SelectCountText = 2;

		// Token: 0x0402820F RID: 164367
		public const int ConfirmButton = 3;

		// Token: 0x04028210 RID: 164368
		public const int LoopItem = 4;
	}
}
