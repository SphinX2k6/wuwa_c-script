using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Core.Common;
using CSharpScript.Game.Module.BattleUi.Views;
using CSharpScript.Game.Module.GameMainView.TrapDefense;
using CSharpScript.Game.Module.TowerDefenseEvent;
using CSharpScript.Game.Module.TowerDefenseEvent.Model;
using CSharpScript.Game.Module.TrapDefense;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020011F5 RID: 4597
[NullableContext(1)]
[Nullable(0)]
public class TrapDefenseBuildTipsPanel : BattleChildViewPanel
{
	// Token: 0x17001248 RID: 4680
	// (get) Token: 0x0600B674 RID: 46708 RVA: 0x0035E64F File Offset: 0x0035C84F
	private bool IsInBuild
	{
		get
		{
			return (this.Type & ETrapDefenseBuildTipsType.Build) > ETrapDefenseBuildTipsType.None && this.IsInSelectBuild;
		}
	}

	// Token: 0x17001249 RID: 4681
	// (get) Token: 0x0600B675 RID: 46709 RVA: 0x0035E664 File Offset: 0x0035C864
	private bool IsInRecycle
	{
		get
		{
			return (this.Type & ETrapDefenseBuildTipsType.Recycle) > ETrapDefenseBuildTipsType.None;
		}
	}

	// Token: 0x1700124A RID: 4682
	// (get) Token: 0x0600B676 RID: 46710 RVA: 0x0035E671 File Offset: 0x0035C871
	private bool IsInPollute
	{
		get
		{
			return (this.Type & ETrapDefenseBuildTipsType.Pollute) > ETrapDefenseBuildTipsType.None && this.IsInSelectBuild;
		}
	}

	// Token: 0x1700124B RID: 4683
	// (get) Token: 0x0600B677 RID: 46711 RVA: 0x0035E686 File Offset: 0x0035C886
	private bool IsInRotate
	{
		get
		{
			return (this.Type & ETrapDefenseBuildTipsType.Rotate) > ETrapDefenseBuildTipsType.None && this.IsInBuild;
		}
	}

	// Token: 0x1700124C RID: 4684
	// (get) Token: 0x0600B678 RID: 46712 RVA: 0x0035E69B File Offset: 0x0035C89B
	private bool IsInDisable
	{
		get
		{
			return (this.Type & ETrapDefenseBuildTipsType.Disable) > ETrapDefenseBuildTipsType.None && this.IsInSelectBuild;
		}
	}

	// Token: 0x0600B679 RID: 46713 RVA: 0x0035E6B4 File Offset: 0x0035C8B4
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUIItem)),
			new ValueTuple<int, Type>(4, typeof(UUIItem)),
			new ValueTuple<int, Type>(5, typeof(UUIText)),
			new ValueTuple<int, Type>(6, typeof(UUITexture)),
			new ValueTuple<int, Type>(7, typeof(UUIItem)),
			new ValueTuple<int, Type>(8, typeof(UUIItem)),
			new ValueTuple<int, Type>(9, typeof(UUIItem)),
			new ValueTuple<int, Type>(10, typeof(UUIText))
		};
	}

	// Token: 0x0600B67A RID: 46714 RVA: 0x0035E7C0 File Offset: 0x0035C9C0
	public override UniTask InitializeAsync()
	{
		TrapDefenseBuildTipsPanel.<InitializeAsync>d__26 <InitializeAsync>d__;
		<InitializeAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitializeAsync>d__.<>4__this = this;
		<InitializeAsync>d__.<>1__state = -1;
		<InitializeAsync>d__.<>t__builder.Start<TrapDefenseBuildTipsPanel.<InitializeAsync>d__26>(ref <InitializeAsync>d__);
		return <InitializeAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600B67B RID: 46715 RVA: 0x0035E804 File Offset: 0x0035CA04
	public override void InitializeTemp()
	{
		this.Sequence = new UiSequencePlayer(base.GetRootItem());
		this.Sequence.BindOnEndSequenceEvent(new Action<string>(this.OnEndSequenceEvent));
		this.Type = TowerDefenseEventController.Instance.BuildTipsType;
		this.CannotPlaceItem = base.GetItem(9);
		this.CannotPlaceText = base.GetText(10);
		this.RefreshState();
		this.RefreshCannotPlaceText();
		UUIItem item = base.GetItem(4);
		if (item == null)
		{
			return;
		}
		item.SetUIActive(false);
	}

	// Token: 0x0600B67C RID: 46716 RVA: 0x0035E884 File Offset: 0x0035CA84
	private void OnEndSequenceEvent(string sequenceName)
	{
		if (sequenceName == "CloseTip")
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
			if (!(sequenceName == "CloseDisable"))
			{
				if (sequenceName == "CloseWarn")
				{
					UUIItem cannotPlaceItem = this.CannotPlaceItem;
					if (cannotPlaceItem == null)
					{
						return;
					}
					cannotPlaceItem.SetUIActive(false);
				}
				return;
			}
			UUIItem item2 = base.GetItem(3);
			if (item2 == null)
			{
				return;
			}
			item2.SetUIActive(false);
			return;
		}
	}

	// Token: 0x0600B67D RID: 46717 RVA: 0x0035E8EF File Offset: 0x0035CAEF
	protected override void OnShowBattleChildViewPanel(bool isFirst)
	{
		this.BindAction();
	}

	// Token: 0x0600B67E RID: 46718 RVA: 0x0035E8F7 File Offset: 0x0035CAF7
	protected override void OnHideBattleChildViewPanel()
	{
		this.UnbindAction();
	}

	// Token: 0x0600B67F RID: 46719 RVA: 0x0035E8FF File Offset: 0x0035CAFF
	public override void OnTickBattleChildViewPanel(float delta)
	{
		if (this.UpdateCannotMode())
		{
			this.RefreshCannotPlaceText();
		}
		this.UpdatePolluteCostNum();
	}

	// Token: 0x0600B680 RID: 46720 RVA: 0x0035E915 File Offset: 0x0035CB15
	protected override void OnBeforeDestroy()
	{
		this.Sequence.Clear();
	}

	// Token: 0x0600B681 RID: 46721 RVA: 0x0035E924 File Offset: 0x0035CB24
	private void BindAction()
	{
		if (!this.IsBindAction)
		{
			InputDistributeController.Instance.BindAction("塔防旋转", new TInputHandle<InputDistributeDefine.EActionType>(this.OnRotateMachineCallback));
			InputDistributeController.Instance.BindAction("塔防回收机关", new TInputHandle<InputDistributeDefine.EActionType>(this.OnRecycleMachineCallback));
			this.IsBindAction = true;
		}
	}

	// Token: 0x0600B682 RID: 46722 RVA: 0x0035E978 File Offset: 0x0035CB78
	private void UnbindAction()
	{
		if (this.IsBindAction)
		{
			InputDistributeController.Instance.UnBindAction("塔防旋转", new TInputHandle<InputDistributeDefine.EActionType>(this.OnRotateMachineCallback));
			InputDistributeController.Instance.UnBindAction("塔防回收机关", new TInputHandle<InputDistributeDefine.EActionType>(this.OnRecycleMachineCallback));
			this.IsBindAction = false;
		}
	}

	// Token: 0x0600B683 RID: 46723 RVA: 0x0035E9CC File Offset: 0x0035CBCC
	private void RefreshState()
	{
		this.RefreshDisableItemActive();
		this.RefreshPolluteItemActive();
		if (Info.Instance.IsInTouch())
		{
			UUIItem item = base.GetItem(1);
			if (item != null)
			{
				item.SetUIActive(false);
			}
			UUIItem item2 = base.GetItem(2);
			if (item2 != null)
			{
				item2.SetUIActive(false);
			}
			UUIItem item3 = base.GetItem(0);
			if (item3 != null)
			{
				item3.SetUIActive(false);
			}
			this.NeedShowBtnSequence = false;
			return;
		}
		bool flag = this.CheckSettingItemActive();
		UUIItem item4 = base.GetItem(1);
		if (item4 != null)
		{
			item4.SetUIActive(this.IsInRotate);
		}
		UUIItem item5 = base.GetItem(2);
		if (item5 != null)
		{
			item5.SetUIActive(this.IsInRecycle);
		}
		UUIItem item6 = base.GetItem(0);
		if (item6 != null)
		{
			item6.SetUIActive(flag);
		}
		bool flag2 = this.IsInRotate || this.IsInRecycle || flag;
		if (flag2 != this.NeedShowBtnSequence)
		{
			this.NeedShowBtnSequence = flag2;
			this.PlayBtnSequence(flag2);
		}
	}

	// Token: 0x0600B684 RID: 46724 RVA: 0x0035EAA7 File Offset: 0x0035CCA7
	private void RefreshTipsItem(ETrapDefenseBuildTipsType type)
	{
		if (this.Type == type)
		{
			return;
		}
		this.Type = type;
		this.RefreshState();
	}

	// Token: 0x0600B685 RID: 46725 RVA: 0x0035EAC0 File Offset: 0x0035CCC0
	private bool CheckSettingItemActive()
	{
		return !Info.Instance.IsInTouch() && this.IsInBuild && (!this.IsInPollute || TrapDefenseModel.Instance.BattleData.IsPurificationItemEnough);
	}

	// Token: 0x0600B686 RID: 46726 RVA: 0x0035EAF4 File Offset: 0x0035CCF4
	private void PlayBtnSequence(bool isActive)
	{
		if (isActive)
		{
			this.Sequence.StopSequenceByKey("CloseBtn", false, true);
			this.Sequence.PlaySequencePurely("StartBtn", false, false);
			return;
		}
		this.Sequence.StopSequenceByKey("StartBtn", false, true);
		this.Sequence.PlaySequencePurely("CloseBtn", false, false);
	}

	// Token: 0x0600B687 RID: 46727 RVA: 0x0035EB50 File Offset: 0x0035CD50
	private void RefreshPolluteItemActive()
	{
		UUIItem item = base.GetItem(4);
		UUITexture texture = base.GetTexture(6);
		if (this.IsInPollute)
		{
			this.UpdatePolluteCostNum();
			TrapDefenseBattleItemData itemData = TrapDefenseModel.Instance.BattleInventoryData.GetItemData(1);
			if (itemData != null && !string.IsNullOrEmpty(itemData.Icon))
			{
				base.SetTextureByPath(itemData.Icon, texture, null, null);
			}
			this.Sequence.StopSequenceByKey("CloseTip", false, true);
			this.Sequence.PlayOrReplaySequenceByName("StartTip", false, null);
			if (item != null)
			{
				item.SetUIActive(true);
				return;
			}
		}
		else
		{
			this.Sequence.StopSequenceByKey("StartTip", false, true);
			this.Sequence.PlayOrReplaySequenceByName("CloseTip", false, null);
		}
	}

	// Token: 0x0600B688 RID: 46728 RVA: 0x0035EC18 File Offset: 0x0035CE18
	private void UpdatePolluteCostNum()
	{
		if (this.IsInPollute)
		{
			TrapDefenseBattleData battleData = TrapDefenseModel.Instance.BattleData;
			bool isPurificationItemEnough = battleData.IsPurificationItemEnough;
			int currentPurificationItemCount = battleData.GetCurrentPurificationItemCount();
			int purificationItemConsume = battleData.GetPurificationItemConsume();
			this.EnoughItem.SetUIActive(isPurificationItemEnough);
			this.NotEnoughItem.SetUIActive(!isPurificationItemEnough);
			if (isPurificationItemEnough)
			{
				LguiUtil.Instance.SetLocalTextNew(this.CostNumText, "TowerDefense_Main_BdCostGreen_Text", new <>z__ReadOnlyArray<object>(new object[]
				{
					currentPurificationItemCount,
					purificationItemConsume
				}));
				return;
			}
			LguiUtil.Instance.SetLocalTextNew(this.CostNumText, "TowerDefense_Main_BdCostRed_Text", new <>z__ReadOnlyArray<object>(new object[]
			{
				currentPurificationItemCount,
				purificationItemConsume
			}));
		}
	}

	// Token: 0x0600B689 RID: 46729 RVA: 0x0035ECD4 File Offset: 0x0035CED4
	private void RefreshDisableItemActive()
	{
		UUIItem item = base.GetItem(3);
		if (this.IsInDisable)
		{
			if (item != null)
			{
				item.SetUIActive(true);
			}
			this.Sequence.StopSequenceByKey("CloseDisable", false, true);
			this.Sequence.PlaySequencePurely("StartDisable", false, false);
			return;
		}
		this.Sequence.StopSequenceByKey("StartDisable", false, true);
		this.Sequence.PlaySequencePurely("CloseDisable", false, false);
	}

	// Token: 0x0600B68A RID: 46730 RVA: 0x0035ED44 File Offset: 0x0035CF44
	private void RefreshCannotPlaceText()
	{
		if (this.CannotMode == 1 || this.CannotMode == 0 || this.CannotMode == 7)
		{
			this.Sequence.StopSequenceByKey("StartWarn", false, true);
			this.Sequence.PlaySequencePurely("CloseWarn", false, false);
			return;
		}
		if (this.CannotMode == 2 || this.CannotMode == 3 || this.CannotMode == 4)
		{
			TowerDefenseEventRaycastResult raycastResult = TowerDefenseEventController.Instance.RaycastResult;
			LguiUtil.Instance.SetLocalTextNew(this.CannotPlaceText, TrapDefenseBuildTipsPanel.cannotPlaceTextMap[raycastResult.PlacementType], Array.Empty<object>());
		}
		else if (this.CannotMode == 5)
		{
			LguiUtil.Instance.SetLocalTextNew(this.CannotPlaceText, "TowerDefense_Battle_Numlimit", Array.Empty<object>());
		}
		else if (this.CannotMode == 6)
		{
			LguiUtil.Instance.SetLocalTextNew(this.CannotPlaceText, "TowerDefense_Battle_Coinlimit", Array.Empty<object>());
		}
		UUIItem cannotPlaceItem = this.CannotPlaceItem;
		if (cannotPlaceItem != null)
		{
			cannotPlaceItem.SetUIActive(true);
		}
		this.Sequence.StopSequenceByKey("CloseWarn", false, true);
		this.Sequence.PlaySequencePurely("StartWarn", false, false);
	}

	// Token: 0x0600B68B RID: 46731 RVA: 0x0035EE5C File Offset: 0x0035D05C
	private bool UpdateCannotMode()
	{
		int num = 0;
		if (this.IsInDisable)
		{
			TowerDefenseEventRaycastResult raycastResult = TowerDefenseEventController.Instance.RaycastResult;
			if (raycastResult.IsInvalidPlacement)
			{
				if (raycastResult.PlacementType == ETowerDefenseEventTrapPlacementType.Ground)
				{
					num = 2;
				}
				else if (raycastResult.PlacementType == ETowerDefenseEventTrapPlacementType.Wall)
				{
					num = 3;
				}
				else if (raycastResult.PlacementType == ETowerDefenseEventTrapPlacementType.Roof)
				{
					num = 4;
				}
			}
			else if (!TowerDefenseEventModel.Instance.HasPlaceToBuildTrap())
			{
				num = 5;
			}
			else if (!TowerDefenseEventController.Instance.IsEnoughGoldToBuildTrap())
			{
				num = 6;
			}
			else
			{
				num = 1;
			}
		}
		else if (!this.IsInSelectBuild)
		{
			num = 7;
		}
		if (num == this.CannotMode)
		{
			return false;
		}
		this.CannotMode = num;
		return true;
	}

	// Token: 0x0600B68C RID: 46732 RVA: 0x0035EEEE File Offset: 0x0035D0EE
	private void OnRotateMachineCallback(string name, InputDistributeDefine.EActionType actionType, InputIdentification identification)
	{
		if (!this.IsInRotate)
		{
			return;
		}
		if (actionType != InputDistributeDefine.EActionType.Press)
		{
			return;
		}
		TowerDefenseEventController.Instance.ExecuteRotateTrap();
	}

	// Token: 0x0600B68D RID: 46733 RVA: 0x0035EF07 File Offset: 0x0035D107
	private void OnRecycleMachineCallback(string name, InputDistributeDefine.EActionType actionType, InputIdentification identification)
	{
		if (!this.IsInRecycle)
		{
			return;
		}
		if (actionType != InputDistributeDefine.EActionType.Press)
		{
			return;
		}
		TowerDefenseEventController.Instance.ExecuteUnOccupyTrap();
	}

	// Token: 0x0600B68E RID: 46734 RVA: 0x0035EF21 File Offset: 0x0035D121
	public void SetRecyclePrice(int recyclePrice)
	{
		if (this.RecyclePriceItem != null)
		{
			this.RecyclePriceItem.UpdatePrice(recyclePrice);
		}
	}

	// Token: 0x0600B68F RID: 46735 RVA: 0x0035EF37 File Offset: 0x0035D137
	public void SetTipsType(ETrapDefenseBuildTipsType type)
	{
		this.RefreshTipsItem(type);
	}

	// Token: 0x0600B690 RID: 46736 RVA: 0x0035EF40 File Offset: 0x0035D140
	public void ResetCannotMode()
	{
		this.CannotMode = 0;
	}

	// Token: 0x0600B691 RID: 46737 RVA: 0x0035EF49 File Offset: 0x0035D149
	public void SetIsInSelectBuild(bool isInSelectBuild)
	{
		this.IsInSelectBuild = isInSelectBuild;
		this.RefreshState();
	}

	// Token: 0x0600B693 RID: 46739 RVA: 0x0035EF60 File Offset: 0x0035D160
	// Note: this type is marked as 'beforefieldinit'.
	static TrapDefenseBuildTipsPanel()
	{
		Dictionary<ETowerDefenseEventTrapPlacementType, string> dictionary = new Dictionary<ETowerDefenseEventTrapPlacementType, string>();
		dictionary[ETowerDefenseEventTrapPlacementType.Ground] = "TowerDefense_Battle_Groundonly";
		dictionary[ETowerDefenseEventTrapPlacementType.Wall] = "TowerDefense_Battle_Wallonly";
		dictionary[ETowerDefenseEventTrapPlacementType.Roof] = "TowerDefense_Battle_Toponly";
		TrapDefenseBuildTipsPanel.cannotPlaceTextMap = dictionary;
	}

	// Token: 0x04006990 RID: 27024
	[StaticVariableRuleIgnore]
	private static readonly Dictionary<ETowerDefenseEventTrapPlacementType, string> cannotPlaceTextMap;

	// Token: 0x04006991 RID: 27025
	protected bool IsInSelectBuild;

	// Token: 0x04006992 RID: 27026
	protected bool NeedShowBtnSequence;

	// Token: 0x04006993 RID: 27027
	private ETrapDefenseBuildTipsType Type;

	// Token: 0x04006994 RID: 27028
	private bool IsBindAction;

	// Token: 0x04006995 RID: 27029
	[Nullable(2)]
	private UUIItem CannotPlaceItem;

	// Token: 0x04006996 RID: 27030
	[Nullable(2)]
	private UUIText CannotPlaceText;

	// Token: 0x04006997 RID: 27031
	private int CannotMode;

	// Token: 0x04006998 RID: 27032
	[Nullable(2)]
	private TrapDefenseRecyclePriceItem RecyclePriceItem;

	// Token: 0x04006999 RID: 27033
	protected UiSequencePlayer Sequence;

	// Token: 0x0400699A RID: 27034
	protected UUIText CostNumText;

	// Token: 0x0400699B RID: 27035
	protected UUIItem EnoughItem;

	// Token: 0x0400699C RID: 27036
	protected UUIItem NotEnoughItem;

	// Token: 0x020074C2 RID: 29890
	[NullableContext(0)]
	private static class EComponentDefine
	{
		// Token: 0x04025FC0 RID: 155584
		public const int SettingItem = 0;

		// Token: 0x04025FC1 RID: 155585
		public const int RotateItem = 1;

		// Token: 0x04025FC2 RID: 155586
		public const int RecycleItem = 2;

		// Token: 0x04025FC3 RID: 155587
		public const int DisableItem = 3;

		// Token: 0x04025FC4 RID: 155588
		public const int PolluteItem = 4;

		// Token: 0x04025FC5 RID: 155589
		public const int CostNum = 5;

		// Token: 0x04025FC6 RID: 155590
		public const int CostIcon = 6;

		// Token: 0x04025FC7 RID: 155591
		public const int EnoughItem = 7;

		// Token: 0x04025FC8 RID: 155592
		public const int NotEnoughItem = 8;

		// Token: 0x04025FC9 RID: 155593
		public const int CannotPlaceItem = 9;

		// Token: 0x04025FCA RID: 155594
		public const int CannotPlaceText = 10;
	}

	// Token: 0x020074C3 RID: 29891
	[NullableContext(0)]
	private static class ECannotMode
	{
		// Token: 0x04025FCB RID: 155595
		public const int None = 0;

		// Token: 0x04025FCC RID: 155596
		public const int IsInDisable = 1;

		// Token: 0x04025FCD RID: 155597
		public const int GroundLimit = 2;

		// Token: 0x04025FCE RID: 155598
		public const int WallLimit = 3;

		// Token: 0x04025FCF RID: 155599
		public const int RoofLimit = 4;

		// Token: 0x04025FD0 RID: 155600
		public const int NumLimit = 5;

		// Token: 0x04025FD1 RID: 155601
		public const int GoldLimit = 6;

		// Token: 0x04025FD2 RID: 155602
		public const int IsNotInSelectBuild = 7;
	}
}
