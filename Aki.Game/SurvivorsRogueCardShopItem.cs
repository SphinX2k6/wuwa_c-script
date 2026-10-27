using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Aki.TDConfigMgr.Quest;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02002AD6 RID: 10966
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class SurvivorsRogueCardShopItem : GridProxyAbstract<GoodsDetail>
{
	// Token: 0x06016D1C RID: 93468 RVA: 0x005CB508 File Offset: 0x005C9708
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUIVerticalLayout)),
			new ValueTuple<int, Type>(4, typeof(UUIItem)),
			new ValueTuple<int, Type>(5, typeof(UUIItem)),
			new ValueTuple<int, Type>(6, typeof(UUIItem)),
			new ValueTuple<int, Type>(7, typeof(UUIItem)),
			new ValueTuple<int, Type>(8, typeof(UUIItem)),
			new ValueTuple<int, Type>(9, typeof(UUIItem))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(1, new Action(this.OnClickBtnPurchase))
		};
	}

	// Token: 0x06016D1D RID: 93469 RVA: 0x005CB620 File Offset: 0x005C9820
	private void OnClickBtnPurchase()
	{
		if (this.HasImportantNode())
		{
			this.SetAnimOn(true);
			this.PlayImportantNodeAnim().ContinueWith(delegate()
			{
				Action<GoodsDetail> onPurchaseBtnClickCallback2 = this.OnPurchaseBtnClickCallback;
				if (onPurchaseBtnClickCallback2 == null)
				{
					return;
				}
				onPurchaseBtnClickCallback2(this.Data);
			});
			return;
		}
		Action<GoodsDetail> onPurchaseBtnClickCallback = this.OnPurchaseBtnClickCallback;
		if (onPurchaseBtnClickCallback == null)
		{
			return;
		}
		onPurchaseBtnClickCallback(this.Data);
	}

	// Token: 0x06016D1E RID: 93470 RVA: 0x005CB660 File Offset: 0x005C9860
	private void OnClickLock(ISurvivorsRogueCardBase data, bool bLock)
	{
		Action<GoodsDetail, bool> onClickLockCallback = this.OnClickLockCallback;
		if (onClickLockCallback == null)
		{
			return;
		}
		onClickLockCallback(this.Data, bLock);
	}

	// Token: 0x06016D1F RID: 93471 RVA: 0x005CB679 File Offset: 0x005C9879
	private void OnStateChange(ISurvivorsRogueCardBase data, EToggleState state)
	{
		Action<GoodsDetail, bool> onStateChangeCallback = this.OnStateChangeCallback;
		if (onStateChangeCallback == null)
		{
			return;
		}
		onStateChangeCallback(this.Data, state == EToggleState.ETT_Checked);
	}

	// Token: 0x06016D20 RID: 93472 RVA: 0x005CB695 File Offset: 0x005C9895
	private void OnHover(ISurvivorsRogueCardBase data, EToggleState state)
	{
		if (state == EToggleState.ETT_Checked)
		{
			return;
		}
		this.RefreshSelected(true, true);
	}

	// Token: 0x06016D21 RID: 93473 RVA: 0x005CB6A4 File Offset: 0x005C98A4
	private void OnUnHover(ISurvivorsRogueCardBase data, EToggleState state)
	{
		if (state == EToggleState.ETT_Checked)
		{
			return;
		}
		this.RefreshSelected(false, true);
	}

	// Token: 0x06016D22 RID: 93474 RVA: 0x005CB6B4 File Offset: 0x005C98B4
	protected override UniTask OnBeforeStartAsync()
	{
		SurvivorsRogueCardShopItem.<OnBeforeStartAsync>d__19 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<SurvivorsRogueCardShopItem.<OnBeforeStartAsync>d__19>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06016D23 RID: 93475 RVA: 0x005CB6F7 File Offset: 0x005C98F7
	protected override void OnBeforeShow()
	{
		SurvivorsRogueModel.Instance.BattleData.BehaviorDelegate.AddTreeVarUpdateDelegate(ESurvivorsRougeSystemVarType.Gold.ToEnumString(), new TTreeVarUpdateDelegate(this.RefreshPrice));
	}

	// Token: 0x06016D24 RID: 93476 RVA: 0x005CB71F File Offset: 0x005C991F
	protected override void OnBeforeDestroy()
	{
		SurvivorsRogueModel.Instance.BattleData.BehaviorDelegate.RemoveTreeVarUpdateDelegate(ESurvivorsRougeSystemVarType.Gold.ToEnumString(), new TTreeVarUpdateDelegate(this.RefreshPrice));
		this.RootActor.OnSequencePlayEvent.Unbind();
	}

	// Token: 0x06016D25 RID: 93477 RVA: 0x005CB757 File Offset: 0x005C9957
	private SurvivorsRogueLvNode CreateLvNode()
	{
		return new SurvivorsRogueLvNode();
	}

	// Token: 0x06016D26 RID: 93478 RVA: 0x005CB760 File Offset: 0x005C9960
	public override UniTask RefreshAsync(GoodsDetail data, bool isSelected, int gridIndex)
	{
		SurvivorsRogueCardShopItem.<RefreshAsync>d__23 <RefreshAsync>d__;
		<RefreshAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshAsync>d__.<>4__this = this;
		<RefreshAsync>d__.data = data;
		<RefreshAsync>d__.isSelected = isSelected;
		<RefreshAsync>d__.gridIndex = gridIndex;
		<RefreshAsync>d__.<>1__state = -1;
		<RefreshAsync>d__.<>t__builder.Start<SurvivorsRogueCardShopItem.<RefreshAsync>d__23>(ref <RefreshAsync>d__);
		return <RefreshAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06016D27 RID: 93479 RVA: 0x005CB7BC File Offset: 0x005C99BC
	private void OnEventSequence(string sequenceName, string eventName)
	{
		if (sequenceName == "None" && eventName == "PlayStart")
		{
			if (this.Data == null)
			{
				return;
			}
			if (this.Data.IsLock)
			{
				return;
			}
			LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
			if (levelSequencePlayer == null)
			{
				return;
			}
			levelSequencePlayer.PlayOrReplaySequenceByName("Start", false, null);
		}
	}

	// Token: 0x06016D28 RID: 93480 RVA: 0x005CB81C File Offset: 0x005C9A1C
	private List<ISurvivorsLvNodeData> GetLvNodeDataList(int maxLevel, List<int> importantNodeLevel, int curLevel, int upLevel)
	{
		this.HighlightNodeLvList.Clear();
		if (curLevel >= maxLevel)
		{
			return new List<ISurvivorsLvNodeData>();
		}
		List<ISurvivorsLvNodeData> list = new List<ISurvivorsLvNodeData>();
		for (int i = 1; i <= maxLevel; i++)
		{
			ESurvivorsLvState state = ESurvivorsLvState.Inactive;
			if (i <= curLevel)
			{
				state = ESurvivorsLvState.Activated;
			}
			else if (i <= curLevel + upLevel)
			{
				this.HighlightNodeLvList.Add(i);
			}
			SurvivorsLvNodeData item = new SurvivorsLvNodeData
			{
				Lv = i,
				IsImportant = importantNodeLevel.Contains(i),
				State = state
			};
			list.Add(item);
		}
		list.Reverse();
		return list;
	}

	// Token: 0x06016D29 RID: 93481 RVA: 0x005CB89C File Offset: 0x005C9A9C
	private void RefreshPrice(VarDefinePb lastVarDefine, VarDefinePb newVarDefine)
	{
		this.RefreshPrice();
	}

	// Token: 0x06016D2A RID: 93482 RVA: 0x005CB8A4 File Offset: 0x005C9AA4
	private void RefreshPrice()
	{
		if (this.Data == null)
		{
			return;
		}
		bool selfInteractive = SurvivorsRogueModel.Instance.BattleData.GetCurrencyCount() >= this.Data.CurPrice;
		SurvivorsRogueCardBase cardItem = this.CardItem;
		if (cardItem != null)
		{
			cardItem.RefreshCost(new int?(this.Data.CurPrice), false, !this.Data.IsSell);
		}
		base.GetButton(1).SetSelfInteractive(selfInteractive);
	}

	// Token: 0x06016D2B RID: 93483 RVA: 0x005CB918 File Offset: 0x005C9B18
	public void RefreshPurchased(bool isPurchased)
	{
		base.GetItem(6).SetUIActive(isPurchased);
		base.GetItem(7).SetUIActive(isPurchased);
		base.GetButton(1).RootUIComp.Get().SetUIActive(!isPurchased);
		base.GetItem(2).SetUIActive(!isPurchased && this.NeedLvInfo);
		base.GetItem(8).SetUIActive(!isPurchased && this.NeedLvInfo);
	}

	// Token: 0x06016D2C RID: 93484 RVA: 0x005CB98C File Offset: 0x005C9B8C
	private void RefreshSelected(bool bSelected, bool preSelect = false)
	{
		if (!preSelect)
		{
			this.CardItem.SetSelected(bSelected, false, false);
		}
		if (this.Data.IsSell)
		{
			base.GetItem(9).SetUIActive(false);
			return;
		}
		bool flag = false;
		foreach (int num in this.HighlightNodeLvList)
		{
			ESurvivorsLvState state = bSelected ? ESurvivorsLvState.Highlight : ESurvivorsLvState.Inactive;
			SurvivorsRogueLvNode layoutItemByKey = this.LvNodeLayout.GetLayoutItemByKey(num);
			if (layoutItemByKey != null)
			{
				layoutItemByKey.RefreshState(state);
			}
			if (layoutItemByKey != null && layoutItemByKey.Data.IsImportant)
			{
				flag = true;
			}
		}
		int? num2 = (this.HighlightNodeLvList.Count > 0) ? new int?(this.HighlightNodeLvList[this.HighlightNodeLvList.Count - 1]) : null;
		if (num2 != null)
		{
			UUIItem itemByKey = this.LvNodeLayout.GetItemByKey(num2.Value);
			if (itemByKey != null)
			{
				base.GetItem(5).SetAnchorOffsetY(itemByKey.GetAnchorOffsetY());
			}
		}
		base.GetItem(9).SetUIActive(!preSelect && bSelected && flag);
		this.SetAnimOn(bSelected);
	}

	// Token: 0x06016D2D RID: 93485 RVA: 0x005CBAD4 File Offset: 0x005C9CD4
	private void SetAnimOn(bool bOn)
	{
		if (bOn == this.AnimState)
		{
			return;
		}
		this.AnimState = bOn;
		this.ArrowSequencePlayer.StopPlayingSequence(false, true);
		base.GetItem(5).SetUIActive(true);
		this.ArrowSequencePlayer.PlayLevelSequenceByName(bOn ? "Start" : "Close", false, null, false);
	}

	// Token: 0x06016D2E RID: 93486 RVA: 0x005CBB34 File Offset: 0x005C9D34
	public bool HasImportantNode()
	{
		foreach (int num in this.HighlightNodeLvList)
		{
			SurvivorsRogueLvNode layoutItemByKey = this.LvNodeLayout.GetLayoutItemByKey(num);
			if (layoutItemByKey != null && layoutItemByKey.Data.IsImportant)
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x06016D2F RID: 93487 RVA: 0x005CBBAC File Offset: 0x005C9DAC
	private UniTask PlayImportantNodeAnim()
	{
		SurvivorsRogueCardShopItem.<PlayImportantNodeAnim>d__32 <PlayImportantNodeAnim>d__;
		<PlayImportantNodeAnim>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<PlayImportantNodeAnim>d__.<>4__this = this;
		<PlayImportantNodeAnim>d__.<>1__state = -1;
		<PlayImportantNodeAnim>d__.<>t__builder.Start<SurvivorsRogueCardShopItem.<PlayImportantNodeAnim>d__32>(ref <PlayImportantNodeAnim>d__);
		return <PlayImportantNodeAnim>d__.<>t__builder.Task;
	}

	// Token: 0x06016D30 RID: 93488 RVA: 0x005CBBEF File Offset: 0x005C9DEF
	public override void OnSelected(bool fireEvent)
	{
		this.RefreshSelected(true, false);
	}

	// Token: 0x06016D31 RID: 93489 RVA: 0x005CBBF9 File Offset: 0x005C9DF9
	public override void OnDeselected(bool fireEvent)
	{
		this.RefreshSelected(false, false);
	}

	// Token: 0x06016D32 RID: 93490 RVA: 0x005CBC03 File Offset: 0x005C9E03
	public override object GetKey(GoodsDetail data, int displayIndex)
	{
		return data.SurvivorsGainData.IncId;
	}

	// Token: 0x06016D33 RID: 93491 RVA: 0x005CBC18 File Offset: 0x005C9E18
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	public override UUIItem[] GetGuideUiItemAndUiItemForShowEx(string[] configParams)
	{
		if (configParams.Length == 0)
		{
			return null;
		}
		if (!(configParams[0] == "EvolveBar"))
		{
			return null;
		}
		UUIVerticalLayout verticalLayout = base.GetVerticalLayout(3);
		UUIItem uuiitem = (verticalLayout != null) ? verticalLayout.GetRootComponent() : null;
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

	// Token: 0x0400A98B RID: 43403
	private const string SEQ_LIGHT = "Start";

	// Token: 0x0400A98C RID: 43404
	private const string SEQ_CLOSE = "Close";

	// Token: 0x0400A98D RID: 43405
	[Nullable(2)]
	private LevelSequencePlayer LevelSequencePlayer;

	// Token: 0x0400A98E RID: 43406
	[Nullable(2)]
	private LevelSequencePlayer ArrowSequencePlayer;

	// Token: 0x0400A98F RID: 43407
	[Nullable(2)]
	public SurvivorsRogueCardBase CardItem;

	// Token: 0x0400A990 RID: 43408
	private GoodsDetail Data;

	// Token: 0x0400A991 RID: 43409
	private bool NeedLvInfo;

	// Token: 0x0400A992 RID: 43410
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<SurvivorsRogueLvNode, ISurvivorsLvNodeData> LvNodeLayout;

	// Token: 0x0400A993 RID: 43411
	private readonly List<int> HighlightNodeLvList = new List<int>();

	// Token: 0x0400A994 RID: 43412
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Action<GoodsDetail> OnPurchaseBtnClickCallback;

	// Token: 0x0400A995 RID: 43413
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Action<GoodsDetail, bool> OnClickLockCallback;

	// Token: 0x0400A996 RID: 43414
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Action<GoodsDetail, bool> OnStateChangeCallback;

	// Token: 0x0400A997 RID: 43415
	private bool AnimState;
}
