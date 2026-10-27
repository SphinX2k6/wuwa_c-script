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

// Token: 0x02001D33 RID: 7475
[NullableContext(1)]
[Nullable(0)]
public class TrapDefenseBuildTipsPanel : BattleChildViewPanel
{
	// Token: 0x1700121E RID: 4638
	// (get) Token: 0x0600E257 RID: 57943 RVA: 0x00352C1F File Offset: 0x00350E1F
	private bool IsInBuild
	{
		get
		{
			return (this.Type & ETrapDefenseBuildTipsType.Build) > ETrapDefenseBuildTipsType.None && this.IsInSelectBuild;
		}
	}

	// Token: 0x1700121F RID: 4639
	// (get) Token: 0x0600E258 RID: 57944 RVA: 0x00352C34 File Offset: 0x00350E34
	private bool IsInRecycle
	{
		get
		{
			return (this.Type & ETrapDefenseBuildTipsType.Recycle) > ETrapDefenseBuildTipsType.None;
		}
	}

	// Token: 0x17001220 RID: 4640
	// (get) Token: 0x0600E259 RID: 57945 RVA: 0x00352C41 File Offset: 0x00350E41
	private bool IsInPollute
	{
		get
		{
			return (this.Type & ETrapDefenseBuildTipsType.Pollute) > ETrapDefenseBuildTipsType.None && this.IsInSelectBuild;
		}
	}

	// Token: 0x17001221 RID: 4641
	// (get) Token: 0x0600E25A RID: 57946 RVA: 0x00352C56 File Offset: 0x00350E56
	private bool IsInRotate
	{
		get
		{
			return (this.Type & ETrapDefenseBuildTipsType.Rotate) > ETrapDefenseBuildTipsType.None && this.IsInBuild;
		}
	}

	// Token: 0x17001222 RID: 4642
	// (get) Token: 0x0600E25B RID: 57947 RVA: 0x00352C6B File Offset: 0x00350E6B
	private bool IsInDisable
	{
		get
		{
			return (this.Type & ETrapDefenseBuildTipsType.Disable) > ETrapDefenseBuildTipsType.None && this.IsInSelectBuild;
		}
	}

	// Token: 0x0600E25C RID: 57948 RVA: 0x00352C84 File Offset: 0x00350E84
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

	// Token: 0x0600E25D RID: 57949 RVA: 0x00352D90 File Offset: 0x00350F90
	public override UniTask InitializeAsync()
	{
		TrapDefenseBuildTipsPanel.<InitializeAsync>d__26 <InitializeAsync>d__;
		<InitializeAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitializeAsync>d__.<>4__this = this;
		<InitializeAsync>d__.<>1__state = -1;
		<InitializeAsync>d__.<>t__builder.Start<TrapDefenseBuildTipsPanel.<InitializeAsync>d__26>(ref <InitializeAsync>d__);
		return <InitializeAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600E25E RID: 57950 RVA: 0x00352DD4 File Offset: 0x00350FD4
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

	// Token: 0x0600E25F RID: 57951 RVA: 0x00352E54 File Offset: 0x00351054
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

	// Token: 0x0600E260 RID: 57952 RVA: 0x00352EBF File Offset: 0x003510BF
	protected override void OnShowBattleChildViewPanel(bool isFirst)
	{
		this.BindAction();
	}

	// Token: 0x0600E261 RID: 57953 RVA: 0x00352EC7 File Offset: 0x003510C7
	protected override void OnHideBattleChildViewPanel()
	{
		this.UnbindAction();
	}

	// Token: 0x0600E262 RID: 57954 RVA: 0x00352ECF File Offset: 0x003510CF
	public override void OnTickBattleChildViewPanel(float delta)
	{
		if (this.UpdateCannotMode())
		{
			this.RefreshCannotPlaceText();
		}
		this.UpdatePolluteCostNum();
	}

	// Token: 0x0600E263 RID: 57955 RVA: 0x00352EE5 File Offset: 0x003510E5
	protected override void OnBeforeDestroy()
	{
		this.Sequence.Clear();
	}

	// Token: 0x0600E264 RID: 57956 RVA: 0x00352EF4 File Offset: 0x003510F4
	private void BindAction()
	{
		if (!this.IsBindAction)
		{
			InputDistributeController.Instance.BindAction("塔防旋转", new TInputHandle<InputDistributeDefine.EActionType>(this.OnRotateMachineCallback));
			InputDistributeController.Instance.BindAction("塔防回收机关", new TInputHandle<InputDistributeDefine.EActionType>(this.OnRecycleMachineCallback));
			this.IsBindAction = true;
		}
	}

	// Token: 0x0600E265 RID: 57957 RVA: 0x00352F48 File Offset: 0x00351148
	private void UnbindAction()
	{
		if (this.IsBindAction)
		{
			InputDistributeController.Instance.UnBindAction("塔防旋转", new TInputHandle<InputDistributeDefine.EActionType>(this.OnRotateMachineCallback));
			InputDistributeController.Instance.UnBindAction("塔防回收机关", new TInputHandle<InputDistributeDefine.EActionType>(this.OnRecycleMachineCallback));
			this.IsBindAction = false;
		}
	}

	// Token: 0x0600E266 RID: 57958 RVA: 0x00352F9C File Offset: 0x0035119C
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

	// Token: 0x0600E267 RID: 57959 RVA: 0x00353077 File Offset: 0x00351277
	private void RefreshTipsItem(ETrapDefenseBuildTipsType type)
	{
		if (this.Type == type)
		{
			return;
		}
		this.Type = type;
		this.RefreshState();
	}

	// Token: 0x0600E268 RID: 57960 RVA: 0x00353090 File Offset: 0x00351290
	private bool CheckSettingItemActive()
	{
		return !Info.Instance.IsInTouch() && this.IsInBuild && (!this.IsInPollute || TrapDefenseModel.Instance.BattleData.IsPurificationItemEnough);
	}

	// Token: 0x0600E269 RID: 57961 RVA: 0x003530C4 File Offset: 0x003512C4
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

	// Token: 0x0600E26A RID: 57962 RVA: 0x00353120 File Offset: 0x00351320
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

	// Token: 0x0600E26B RID: 57963 RVA: 0x003531E8 File Offset: 0x003513E8
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

	// Token: 0x0600E26C RID: 57964 RVA: 0x003532A4 File Offset: 0x003514A4
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

	// Token: 0x0600E26D RID: 57965 RVA: 0x00353314 File Offset: 0x00351514
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

	// Token: 0x0600E26E RID: 57966 RVA: 0x0035342C File Offset: 0x0035162C
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

	// Token: 0x0600E26F RID: 57967 RVA: 0x003534BE File Offset: 0x003516BE
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

	// Token: 0x0600E270 RID: 57968 RVA: 0x003534D7 File Offset: 0x003516D7
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

	// Token: 0x0600E271 RID: 57969 RVA: 0x003534F1 File Offset: 0x003516F1
	public void SetRecyclePrice(int recyclePrice)
	{
		if (this.RecyclePriceItem != null)
		{
			this.RecyclePriceItem.UpdatePrice(recyclePrice);
		}
	}

	// Token: 0x0600E272 RID: 57970 RVA: 0x00353507 File Offset: 0x00351707
	public void SetTipsType(ETrapDefenseBuildTipsType type)
	{
		this.RefreshTipsItem(type);
	}

	// Token: 0x0600E273 RID: 57971 RVA: 0x00353510 File Offset: 0x00351710
	public void ResetCannotMode()
	{
		this.CannotMode = 0;
	}

	// Token: 0x0600E274 RID: 57972 RVA: 0x00353519 File Offset: 0x00351719
	public void SetIsInSelectBuild(bool isInSelectBuild)
	{
		this.IsInSelectBuild = isInSelectBuild;
		this.RefreshState();
	}

	// Token: 0x0600E276 RID: 57974 RVA: 0x00353530 File Offset: 0x00351730
	// Note: this type is marked as 'beforefieldinit'.
	static TrapDefenseBuildTipsPanel()
	{
		Dictionary<ETowerDefenseEventTrapPlacementType, string> dictionary = new Dictionary<ETowerDefenseEventTrapPlacementType, string>();
		dictionary[ETowerDefenseEventTrapPlacementType.Ground] = "TowerDefense_Battle_Groundonly";
		dictionary[ETowerDefenseEventTrapPlacementType.Wall] = "TowerDefense_Battle_Wallonly";
		dictionary[ETowerDefenseEventTrapPlacementType.Roof] = "TowerDefense_Battle_Toponly";
		TrapDefenseBuildTipsPanel.cannotPlaceTextMap = dictionary;
	}

	// Token: 0x040068B1 RID: 26801
	[StaticVariableRuleIgnore]
	private static readonly Dictionary<ETowerDefenseEventTrapPlacementType, string> cannotPlaceTextMap;

	// Token: 0x040068B2 RID: 26802
	protected bool IsInSelectBuild;

	// Token: 0x040068B3 RID: 26803
	protected bool NeedShowBtnSequence;

	// Token: 0x040068B4 RID: 26804
	private ETrapDefenseBuildTipsType Type;

	// Token: 0x040068B5 RID: 26805
	private bool IsBindAction;

	// Token: 0x040068B6 RID: 26806
	[Nullable(2)]
	private UUIItem CannotPlaceItem;

	// Token: 0x040068B7 RID: 26807
	[Nullable(2)]
	private UUIText CannotPlaceText;

	// Token: 0x040068B8 RID: 26808
	private int CannotMode;

	// Token: 0x040068B9 RID: 26809
	[Nullable(2)]
	private TrapDefenseRecyclePriceItem RecyclePriceItem;

	// Token: 0x040068BA RID: 26810
	protected UiSequencePlayer Sequence;

	// Token: 0x040068BB RID: 26811
	protected UUIText CostNumText;

	// Token: 0x040068BC RID: 26812
	protected UUIItem EnoughItem;

	// Token: 0x040068BD RID: 26813
	protected UUIItem NotEnoughItem;

	// Token: 0x02008339 RID: 33593
	[NullableContext(0)]
	private static class EComponentDefine
	{
		// Token: 0x0402AC98 RID: 175256
		public const int SettingItem = 0;

		// Token: 0x0402AC99 RID: 175257
		public const int RotateItem = 1;

		// Token: 0x0402AC9A RID: 175258
		public const int RecycleItem = 2;

		// Token: 0x0402AC9B RID: 175259
		public const int DisableItem = 3;

		// Token: 0x0402AC9C RID: 175260
		public const int PolluteItem = 4;

		// Token: 0x0402AC9D RID: 175261
		public const int CostNum = 5;

		// Token: 0x0402AC9E RID: 175262
		public const int CostIcon = 6;

		// Token: 0x0402AC9F RID: 175263
		public const int EnoughItem = 7;

		// Token: 0x0402ACA0 RID: 175264
		public const int NotEnoughItem = 8;

		// Token: 0x0402ACA1 RID: 175265
		public const int CannotPlaceItem = 9;

		// Token: 0x0402ACA2 RID: 175266
		public const int CannotPlaceText = 10;
	}

	// Token: 0x0200833A RID: 33594
	[NullableContext(0)]
	private static class ECannotMode
	{
		// Token: 0x0402ACA3 RID: 175267
		public const int None = 0;

		// Token: 0x0402ACA4 RID: 175268
		public const int IsInDisable = 1;

		// Token: 0x0402ACA5 RID: 175269
		public const int GroundLimit = 2;

		// Token: 0x0402ACA6 RID: 175270
		public const int WallLimit = 3;

		// Token: 0x0402ACA7 RID: 175271
		public const int RoofLimit = 4;

		// Token: 0x0402ACA8 RID: 175272
		public const int NumLimit = 5;

		// Token: 0x0402ACA9 RID: 175273
		public const int GoldLimit = 6;

		// Token: 0x0402ACAA RID: 175274
		public const int IsNotInSelectBuild = 7;
	}
}
