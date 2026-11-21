using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Aki.TDConfigMgr.Quest;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02002052 RID: 8274
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class SurvivorsRogueCardShopItem : GridProxyAbstract<GoodsDetail>
{
	// Token: 0x0601474D RID: 83789 RVA: 0x005F805C File Offset: 0x005F625C
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

	// Token: 0x0601474E RID: 83790 RVA: 0x005F8174 File Offset: 0x005F6374
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

	// Token: 0x0601474F RID: 83791 RVA: 0x005F81B4 File Offset: 0x005F63B4
	private void OnClickLock(ISurvivorsRogueCardBase data, bool bLock)
	{
		Action<GoodsDetail, bool> onClickLockCallback = this.OnClickLockCallback;
		if (onClickLockCallback == null)
		{
			return;
		}
		onClickLockCallback(this.Data, bLock);
	}

	// Token: 0x06014750 RID: 83792 RVA: 0x005F81CD File Offset: 0x005F63CD
	private void OnStateChange(ISurvivorsRogueCardBase data, EToggleState state)
	{
		Action<GoodsDetail, bool> onStateChangeCallback = this.OnStateChangeCallback;
		if (onStateChangeCallback == null)
		{
			return;
		}
		onStateChangeCallback(this.Data, state == EToggleState.ETT_Checked);
	}

	// Token: 0x06014751 RID: 83793 RVA: 0x005F81E9 File Offset: 0x005F63E9
	private void OnHover(ISurvivorsRogueCardBase data, EToggleState state)
	{
		if (state == EToggleState.ETT_Checked)
		{
			return;
		}
		this.RefreshSelected(true, true);
	}

	// Token: 0x06014752 RID: 83794 RVA: 0x005F81F8 File Offset: 0x005F63F8
	private void OnUnHover(ISurvivorsRogueCardBase data, EToggleState state)
	{
		if (state == EToggleState.ETT_Checked)
		{
			return;
		}
		this.RefreshSelected(false, true);
	}

	// Token: 0x06014753 RID: 83795 RVA: 0x005F8208 File Offset: 0x005F6408
	protected override UniTask OnBeforeStartAsync()
	{
		SurvivorsRogueCardShopItem.<OnBeforeStartAsync>d__19 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<SurvivorsRogueCardShopItem.<OnBeforeStartAsync>d__19>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06014754 RID: 83796 RVA: 0x005F824B File Offset: 0x005F644B
	protected override void OnBeforeShow()
	{
		SurvivorsRogueModel.Instance.BattleData.BehaviorDelegate.AddTreeVarUpdateDelegate(ESurvivorsRougeSystemVarType.Gold.ToEnumString(), new TTreeVarUpdateDelegate(this.RefreshPrice));
	}

	// Token: 0x06014755 RID: 83797 RVA: 0x005F8273 File Offset: 0x005F6473
	protected override void OnBeforeDestroy()
	{
		SurvivorsRogueModel.Instance.BattleData.BehaviorDelegate.RemoveTreeVarUpdateDelegate(ESurvivorsRougeSystemVarType.Gold.ToEnumString(), new TTreeVarUpdateDelegate(this.RefreshPrice));
		this.RootActor.OnSequencePlayEvent.Unbind();
	}

	// Token: 0x06014756 RID: 83798 RVA: 0x005F82AB File Offset: 0x005F64AB
	private SurvivorsRogueLvNode CreateLvNode()
	{
		return new SurvivorsRogueLvNode();
	}

	// Token: 0x06014757 RID: 83799 RVA: 0x005F82B4 File Offset: 0x005F64B4
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

	// Token: 0x06014758 RID: 83800 RVA: 0x005F8310 File Offset: 0x005F6510
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

	// Token: 0x06014759 RID: 83801 RVA: 0x005F8370 File Offset: 0x005F6570
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

	// Token: 0x0601475A RID: 83802 RVA: 0x005F83F0 File Offset: 0x005F65F0
	private void RefreshPrice(VarDefinePb lastVarDefine, VarDefinePb newVarDefine)
	{
		this.RefreshPrice();
	}

	// Token: 0x0601475B RID: 83803 RVA: 0x005F83F8 File Offset: 0x005F65F8
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

	// Token: 0x0601475C RID: 83804 RVA: 0x005F846C File Offset: 0x005F666C
	public void RefreshPurchased(bool isPurchased)
	{
		base.GetItem(6).SetUIActive(isPurchased);
		base.GetItem(7).SetUIActive(isPurchased);
		base.GetButton(1).RootUIComp.Get().SetUIActive(!isPurchased);
		base.GetItem(2).SetUIActive(!isPurchased && this.NeedLvInfo);
		base.GetItem(8).SetUIActive(!isPurchased && this.NeedLvInfo);
	}

	// Token: 0x0601475D RID: 83805 RVA: 0x005F84E0 File Offset: 0x005F66E0
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

	// Token: 0x0601475E RID: 83806 RVA: 0x005F8628 File Offset: 0x005F6828
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

	// Token: 0x0601475F RID: 83807 RVA: 0x005F8688 File Offset: 0x005F6888
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

	// Token: 0x06014760 RID: 83808 RVA: 0x005F8700 File Offset: 0x005F6900
	private UniTask PlayImportantNodeAnim()
	{
		SurvivorsRogueCardShopItem.<PlayImportantNodeAnim>d__32 <PlayImportantNodeAnim>d__;
		<PlayImportantNodeAnim>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<PlayImportantNodeAnim>d__.<>4__this = this;
		<PlayImportantNodeAnim>d__.<>1__state = -1;
		<PlayImportantNodeAnim>d__.<>t__builder.Start<SurvivorsRogueCardShopItem.<PlayImportantNodeAnim>d__32>(ref <PlayImportantNodeAnim>d__);
		return <PlayImportantNodeAnim>d__.<>t__builder.Task;
	}

	// Token: 0x06014761 RID: 83809 RVA: 0x005F8743 File Offset: 0x005F6943
	public override void OnSelected(bool fireEvent)
	{
		this.RefreshSelected(true, false);
	}

	// Token: 0x06014762 RID: 83810 RVA: 0x005F874D File Offset: 0x005F694D
	public override void OnDeselected(bool fireEvent)
	{
		this.RefreshSelected(false, false);
	}

	// Token: 0x06014763 RID: 83811 RVA: 0x005F8757 File Offset: 0x005F6957
	public override object GetKey(GoodsDetail data, int displayIndex)
	{
		return data.SurvivorsGainData.IncId;
	}

	// Token: 0x06014764 RID: 83812 RVA: 0x005F876C File Offset: 0x005F696C
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

	// Token: 0x0400AD91 RID: 44433
	private const string SEQ_LIGHT = "Start";

	// Token: 0x0400AD92 RID: 44434
	private const string SEQ_CLOSE = "Close";

	// Token: 0x0400AD93 RID: 44435
	[Nullable(2)]
	private LevelSequencePlayer LevelSequencePlayer;

	// Token: 0x0400AD94 RID: 44436
	[Nullable(2)]
	private LevelSequencePlayer ArrowSequencePlayer;

	// Token: 0x0400AD95 RID: 44437
	[Nullable(2)]
	public SurvivorsRogueCardBase CardItem;

	// Token: 0x0400AD96 RID: 44438
	private GoodsDetail Data;

	// Token: 0x0400AD97 RID: 44439
	private bool NeedLvInfo;

	// Token: 0x0400AD98 RID: 44440
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<SurvivorsRogueLvNode, ISurvivorsLvNodeData> LvNodeLayout;

	// Token: 0x0400AD99 RID: 44441
	private readonly List<int> HighlightNodeLvList = new List<int>();

	// Token: 0x0400AD9A RID: 44442
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Action<GoodsDetail> OnPurchaseBtnClickCallback;

	// Token: 0x0400AD9B RID: 44443
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Action<GoodsDetail, bool> OnClickLockCallback;

	// Token: 0x0400AD9C RID: 44444
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Action<GoodsDetail, bool> OnStateChangeCallback;

	// Token: 0x0400AD9D RID: 44445
	private bool AnimState;
}
