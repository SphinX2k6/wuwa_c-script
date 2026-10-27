using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.AutoAttach;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.Reward;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001752 RID: 5970
[NullableContext(1)]
[Nullable(0)]
public class CalabashLevelUpTabView : UiTabViewBase
{
	// Token: 0x0600AC8C RID: 44172 RVA: 0x0026B84C File Offset: 0x00269A4C
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(3, typeof(UUIText)),
			new ValueTuple<int, Type>(4, typeof(UUIVerticalLayout)),
			new ValueTuple<int, Type>(5, typeof(UUIHorizontalLayout)),
			new ValueTuple<int, Type>(6, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(7, typeof(UUIItem)),
			new ValueTuple<int, Type>(8, typeof(UUIItem)),
			new ValueTuple<int, Type>(9, typeof(UUIText)),
			new ValueTuple<int, Type>(10, typeof(UUIText)),
			new ValueTuple<int, Type>(11, typeof(UUIText)),
			new ValueTuple<int, Type>(12, typeof(UUIItem))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(6, new Action(this.OnRewardBtnClick)),
			new ValueTuple<int, Delegate>(2, new Action(this.OnHelpBtnClick))
		};
	}

	// Token: 0x0600AC8D RID: 44173 RVA: 0x0026B9C4 File Offset: 0x00269BC4
	private void OnHelpBtnClick()
	{
		ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.CalabashExpTipId);
		ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
	}

	// Token: 0x0600AC8E RID: 44174 RVA: 0x0026B9E8 File Offset: 0x00269BE8
	protected override void AddEventListener()
	{
		EventSystem.Instance.Add(EEventName.GetCalabashReward, new Action(this.RefreshCalabash));
		EventSystem.Instance.Add<EUiViewName, int>(EEventName.CloseView, new Action<EUiViewName, int>(this.OnRewardViewClose));
	}

	// Token: 0x0600AC8F RID: 44175 RVA: 0x0026BA1F File Offset: 0x00269C1F
	protected override void RemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.GetCalabashReward, new Action(this.RefreshCalabash));
		EventSystem.Instance.Remove<EUiViewName, int>(EEventName.CloseView, new Action<EUiViewName, int>(this.OnRewardViewClose));
	}

	// Token: 0x0600AC90 RID: 44176 RVA: 0x0026BA58 File Offset: 0x00269C58
	protected override UniTask OnCreateAsync()
	{
		CalabashLevelUpTabView.<OnCreateAsync>d__16 <OnCreateAsync>d__;
		<OnCreateAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnCreateAsync>d__.<>4__this = this;
		<OnCreateAsync>d__.<>1__state = -1;
		<OnCreateAsync>d__.<>t__builder.Start<CalabashLevelUpTabView.<OnCreateAsync>d__16>(ref <OnCreateAsync>d__);
		return <OnCreateAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600AC91 RID: 44177 RVA: 0x0026BA9C File Offset: 0x00269C9C
	protected override void OnStart()
	{
		this.CurrentSelectDetailType = ECalabashAttributeDataType.Default;
		this.NoCircleExhibitionView = new NoCircleAttachView<CalabashGridData, CalabashGrid>(base.GetItem(0).GetOwner(), false);
		UUIItem item = base.GetItem(1);
		item.SetUIActive(false);
		this.NoCircleExhibitionView.CreateItems(item.GetOwner(), 0f, new Func<AActor, int, int, CalabashGrid>(this.InitGrid), EAttachDirection.Horizontal);
		this.RewardLayout = new GenericLayout<CalabashLevelUpRewardItemGrid, CalabashRewardItemData>(base.GetHorizontalLayout(5), new Func<CalabashLevelUpRewardItemGrid>(this.CreateRewardItem), null, false, true);
		this.AttributeLayout = new GenericLayout<CalabashAttributeItem, CalabashAttributeData>(base.GetVerticalLayout(4), new Func<CalabashAttributeItem>(this.CreateAttributeItem), null, false, true);
	}

	// Token: 0x0600AC92 RID: 44178 RVA: 0x0026BB3C File Offset: 0x00269D3C
	private CalabashGrid InitGrid(AActor actor, int index, int showNum)
	{
		CalabashGrid calabashGrid = new CalabashGrid();
		calabashGrid.CreateThenShowByActor(actor, null);
		calabashGrid.ButtonFunction = new Action<int>(this.MoveCalabashGrid);
		calabashGrid.CheckToggleCanClick = new Func<bool>(this.CheckToggleCanClick);
		calabashGrid.ItemCurve = this.ItemCurve;
		return calabashGrid;
	}

	// Token: 0x0600AC93 RID: 44179 RVA: 0x0026BB7B File Offset: 0x00269D7B
	private bool CheckToggleCanClick()
	{
		return !this.NoCircleExhibitionView.MovingState();
	}

	// Token: 0x0600AC94 RID: 44180 RVA: 0x0026BB8B File Offset: 0x00269D8B
	private CalabashLevelUpRewardItemGrid CreateRewardItem()
	{
		return new CalabashLevelUpRewardItemGrid();
	}

	// Token: 0x0600AC95 RID: 44181 RVA: 0x0026BB92 File Offset: 0x00269D92
	private CalabashAttributeItem CreateAttributeItem()
	{
		return new CalabashAttributeItem();
	}

	// Token: 0x0600AC96 RID: 44182 RVA: 0x0026BB99 File Offset: 0x00269D99
	protected override void OnBeforeShow()
	{
		this.RefreshNoCircleExhibitionView(this.NeedInitExhibition);
		this.NeedInitExhibition = false;
		this.RefreshCalabashPlayerInfo();
	}

	// Token: 0x0600AC97 RID: 44183 RVA: 0x0026BBB4 File Offset: 0x00269DB4
	private void OnRewardBtnClick()
	{
		int calabashLevel = CalabashModel.Instance.GetCalabashLevel();
		List<int> list = new List<int>();
		for (int i = 0; i <= calabashLevel; i++)
		{
			if (CalabashModel.Instance.GetReceiveRewardStateByLevel(i) == ECalabashRewardState.CanReceive)
			{
				list.Add(i);
			}
		}
		CalabashController.Instance.RequestMultiCalabashLevelReward(list.ToArray());
	}

	// Token: 0x0600AC98 RID: 44184 RVA: 0x0026BC04 File Offset: 0x00269E04
	private void OnRewardViewClose(EUiViewName viewName, int _)
	{
		if (viewName != EUiViewName.CommonRewardView)
		{
			return;
		}
		int value = ConfigCommonParamById.GetIntConfig("StrengthItemId").Value;
		if (this.AchieveStrengthItemNum == 0)
		{
			return;
		}
		ItemInfo? itemConfig = InventoryConfig.Instance.GetItemConfig(value);
		if (itemConfig == null || itemConfig.Value.Parameters() == null)
		{
			return;
		}
		int num = 0;
		using (Dictionary<int, int>.Enumerator enumerator = itemConfig.Value.Parameters().GetEnumerator())
		{
			if (enumerator.MoveNext())
			{
				KeyValuePair<int, int> keyValuePair = enumerator.Current;
				num = keyValuePair.Value;
			}
		}
		if (num == 0)
		{
			return;
		}
		PropRewardConf? config = ConfigPropRewardConfById.GetConfig(num, true);
		if (config == null)
		{
			return;
		}
		float num2 = 0f;
		foreach (ConfigPropValue configPropValue in config.Value.Props())
		{
			if (configPropValue.Id == 69)
			{
				num2 = configPropValue.Value * (float)this.AchieveStrengthItemNum;
				break;
			}
		}
		if (num2 == 0f)
		{
			return;
		}
		int num3 = (int)FormationAttributeController.Instance.GetBaseMax(EFormationAttributeId.Strength);
		PropertyIndex? propertyIndexInfo = PropertyIndexConfig.Instance.GetPropertyIndexInfo(69);
		AttributeInfo item = new AttributeInfo
		{
			Name = propertyIndexInfo.Value.Name,
			IconPath = propertyIndexInfo.Value.Icon,
			ShowArrow = new bool?(true),
			PreText = Math.Floor((double)((float)num3 - num2) / 100.0).ToString(),
			CurText = Math.Floor((double)num3 / 100.0).ToString()
		};
		LevelUpSuccessAttributeData data = new LevelUpSuccessAttributeData
		{
			Title = "PrefabTextItem_HuluStaminaUp_Text",
			StrengthUpgradeData = new StrengthUpgradeData
			{
				AttributeId = EFormationAttributeId.Strength,
				SingleStrengthValue = ConfigCommonParamById.GetIntConfig("SingleStrengthValue").Value,
				MaxSingleStrengthItemCount = ConfigCommonParamById.GetIntConfig("MaxSingleStrengthItemCount").Value,
				MaxStrength = num3
			},
			AttributeInfo = new List<IAttributeInfo>
			{
				item
			}
		};
		RoleLevelUpSuccessController.Instance.OpenSuccessAttributeView(data, null);
		this.RefreshStrengthItemNum();
	}

	// Token: 0x0600AC99 RID: 44185 RVA: 0x0026BE58 File Offset: 0x0026A058
	private void MoveCalabashGrid(int showIndex)
	{
		this.CurrentSelectedLevel = showIndex;
		if (this.NoCircleExhibitionView.GetCurrentSelectIndex() != showIndex)
		{
			this.NoCircleExhibitionView.AttachToIndex(showIndex, false);
		}
		this.OnSelectedLevelChange();
	}

	// Token: 0x0600AC9A RID: 44186 RVA: 0x0026BE82 File Offset: 0x0026A082
	private void OnSelectedLevelChange()
	{
		this.RefreshSelectedLevelInfo();
		this.RefreshStrengthItemNum();
	}

	// Token: 0x0600AC9B RID: 44187 RVA: 0x0026BE90 File Offset: 0x0026A090
	private void RefreshSelectedLevelInfo()
	{
		this.RefreshReward();
		this.RefreshButtonState();
		this.RefreshAttribute();
	}

	// Token: 0x0600AC9C RID: 44188 RVA: 0x0026BEA4 File Offset: 0x0026A0A4
	private void RefreshCalabashPlayerInfo()
	{
		int calabashLevel = CalabashModel.Instance.GetCalabashLevel();
		LguiUtil.Instance.SetLocalTextNew(base.GetText(10), "PrefabTextItem_HuluCurrentLv_Text", new <>z__ReadOnlySingleElementList<object>(calabashLevel));
		int calabashAllSchedule = CalabashModel.Instance.GetCalabashAllSchedule();
		int calabashOwnSchedule = CalabashModel.Instance.GetCalabashOwnSchedule();
		LguiUtil.Instance.SetLocalTextNew(base.GetText(11), "Phanton_CollectNum", new <>z__ReadOnlyArray<object>(new object[]
		{
			calabashOwnSchedule,
			calabashAllSchedule
		}));
		this.RefreshExpText(calabashLevel);
	}

	// Token: 0x0600AC9D RID: 44189 RVA: 0x0026BF30 File Offset: 0x0026A130
	private void RefreshReward()
	{
		int rewardId = CalabashConfig.Instance.GetCalabashConfigByLevel(this.CurrentSelectedLevel).Value.RewardId;
		if (rewardId <= 0)
		{
			GenericLayout<CalabashLevelUpRewardItemGrid, CalabashRewardItemData> rewardLayout = this.RewardLayout;
			if (rewardLayout != null)
			{
				rewardLayout.SetActive(false);
			}
			base.GetItem(12).SetUIActive(true);
			return;
		}
		Dictionary<int, int> dropPackagePreview = CSharpScript.Game.Module.Reward.RewardConfig.Instance.GetDropPackagePreview(rewardId);
		GenericLayout<CalabashLevelUpRewardItemGrid, CalabashRewardItemData> rewardLayout2 = this.RewardLayout;
		if (rewardLayout2 != null)
		{
			rewardLayout2.SetActive(true);
		}
		base.GetItem(12).SetUIActive(false);
		ECalabashRewardState receiveRewardStateByLevel = CalabashModel.Instance.GetReceiveRewardStateByLevel(this.CurrentSelectedLevel);
		int num = 0;
		foreach (KeyValuePair<int, int> keyValuePair in dropPackagePreview)
		{
			CalabashRewardItemData calabashRewardItemData;
			if (num < this.RewardDataList.Count)
			{
				calabashRewardItemData = this.RewardDataList[num];
			}
			else
			{
				calabashRewardItemData = new CalabashRewardItemData();
				this.RewardDataList.Add(calabashRewardItemData);
			}
			calabashRewardItemData.ReceiveState = receiveRewardStateByLevel;
			calabashRewardItemData.ItemData = new TItem?(new TItem(new InventoryDefine.GetItemData(keyValuePair.Key, 0), keyValuePair.Value));
			num++;
		}
		GenericLayout<CalabashLevelUpRewardItemGrid, CalabashRewardItemData> rewardLayout3 = this.RewardLayout;
		if (rewardLayout3 == null)
		{
			return;
		}
		rewardLayout3.RefreshByData(this.RewardDataList, null, false);
	}

	// Token: 0x0600AC9E RID: 44190 RVA: 0x0026C07C File Offset: 0x0026A27C
	private void RefreshStrengthItemNum()
	{
		this.AchieveStrengthItemNum = 0;
		int value = ConfigCommonParamById.GetIntConfig("StrengthItemId").Value;
		int calabashLevel = CalabashModel.Instance.GetCalabashLevel();
		for (int i = 0; i <= calabashLevel; i++)
		{
			if (CalabashModel.Instance.GetReceiveRewardStateByLevel(i) == ECalabashRewardState.CanReceive)
			{
				int rewardId = CalabashConfig.Instance.GetCalabashConfigByLevel(i).Value.RewardId;
				if (rewardId > 0)
				{
					foreach (KeyValuePair<int, int> keyValuePair in CSharpScript.Game.Module.Reward.RewardConfig.Instance.GetDropPackagePreview(rewardId))
					{
						if (value == keyValuePair.Key)
						{
							this.AchieveStrengthItemNum += keyValuePair.Value;
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600AC9F RID: 44191 RVA: 0x0026C15C File Offset: 0x0026A35C
	private void RefreshButtonState()
	{
		ECalabashRewardState receiveRewardStateByLevel = CalabashModel.Instance.GetReceiveRewardStateByLevel(this.CurrentSelectedLevel);
		base.GetButton(6).RootUIComp.Get().SetUIActive(receiveRewardStateByLevel == ECalabashRewardState.CanReceive);
		base.GetItem(8).SetUIActive(receiveRewardStateByLevel == ECalabashRewardState.CantReceive);
		base.GetItem(7).SetUIActive(receiveRewardStateByLevel == ECalabashRewardState.HasReceived);
		if (receiveRewardStateByLevel == ECalabashRewardState.CantReceive)
		{
			UUIText text = base.GetText(9);
			if (this.CalabashGridDataList[this.CurrentSelectedLevel].HasOverFlowExpReach)
			{
				ConditionGroup? config = ConfigConditionGroupById.GetConfig(CalabashConfig.Instance.GetCalabashConfigByLevel(this.CurrentSelectedLevel).Value.LevelUpCondition, true);
				LguiUtil.Instance.SetLocalTextNew(text, config.Value.HintText, Array.Empty<object>());
				return;
			}
			LguiUtil.Instance.SetLocalTextNew(text, "PrefabTextItem_HuluLvNotEnough_Text", Array.Empty<object>());
		}
	}

	// Token: 0x0600ACA0 RID: 44192 RVA: 0x0026C238 File Offset: 0x0026A438
	private void RefreshAttribute()
	{
		this.ClearAttributeData();
		this.CreateBasicAbsorptionData();
		this.CreateUpAbsorptionData();
		this.CreateLowCostAbsorptionData();
		this.CreateMaxQualityData();
		this.CreateMaxCostData();
		foreach (CalabashAttributeData calabashAttributeData in this.AttributeDataList)
		{
			calabashAttributeData.ClickCallBack = new Action<CalabashAttributeData>(this.OnClickDetailItem);
			calabashAttributeData.CurrentSelect = (this.CurrentSelectDetailType == calabashAttributeData.Type);
			calabashAttributeData.CurrentSelectLevel = this.CurrentSelectedLevel;
		}
		GenericLayout<CalabashAttributeItem, CalabashAttributeData> attributeLayout = this.AttributeLayout;
		if (attributeLayout == null)
		{
			return;
		}
		attributeLayout.RefreshByData(this.AttributeDataList, null, false);
	}

	// Token: 0x0600ACA1 RID: 44193 RVA: 0x0026C2F4 File Offset: 0x0026A4F4
	private void CreateBasicAbsorptionData()
	{
		int calabashLevel = CalabashModel.Instance.GetCalabashLevel();
		bool flag = calabashLevel >= this.CurrentSelectedLevel;
		CalabashAttributeData attributeData = this.GetAttributeData();
		attributeData.Type = ECalabashAttributeDataType.BasicAbsorption;
		attributeData.Name = "PrefabTextItem_1948060625_Text";
		attributeData.IsCost = false;
		attributeData.IsUp = false;
		int catchGainByLevel = CalabashModel.Instance.GetCatchGainByLevel(this.CurrentSelectedLevel);
		attributeData.Value = new TableTextArgNew("Text_ExplorationDegree_Text", new <>z__ReadOnlySingleElementList<object>(Math.Ceiling((double)catchGainByLevel / 10.0).ToString()));
		attributeData.IsToggleRaycast = false;
		if (!flag)
		{
			int catchGainByLevel2 = CalabashModel.Instance.GetCatchGainByLevel(calabashLevel);
			attributeData.IsUp = (catchGainByLevel > catchGainByLevel2);
		}
	}

	// Token: 0x0600ACA2 RID: 44194 RVA: 0x0026C3A0 File Offset: 0x0026A5A0
	private void CreateUpAbsorptionData()
	{
		int calabashLevel = CalabashModel.Instance.GetCalabashLevel();
		CalabashConfig instance = CalabashConfig.Instance;
		CalabashLevel? calabashLevel2 = (instance != null) ? instance.GetCalabashConfigByLevel(calabashLevel) : null;
		if (calabashLevel2 == null)
		{
			Log instance2 = Log.Instance;
			ELogModule module = ELogModule.Calabash;
			ELogAuthor author = ELogAuthor.CB;
			string message = "找不到对应等级的配置信息";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("curLevel", calabashLevel);
			instance2.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return;
		}
		CalabashConfig instance3 = CalabashConfig.Instance;
		CalabashLevel? calabashLevel3 = (instance3 != null) ? instance3.GetCalabashConfigByLevel(this.CurrentSelectedLevel) : null;
		bool flag = calabashLevel >= this.CurrentSelectedLevel;
		if (calabashLevel3 == null)
		{
			Log instance4 = Log.Instance;
			ELogModule module2 = ELogModule.Calabash;
			ELogAuthor author2 = ELogAuthor.CB;
			string message2 = "找不到对应等级的配置信息";
			ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("CurrentSelectedLevel", this.CurrentSelectedLevel);
			instance4.Error(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
			return;
		}
		CalabashAttributeData attributeData = this.GetAttributeData();
		attributeData.Type = ECalabashAttributeDataType.UpAbsorption;
		attributeData.Name = ECalabashTxt.UpAbsorptionTargetAdvanced.ToString();
		attributeData.IsCost = false;
		attributeData.IsUp = false;
		attributeData.IsToggleRaycast = true;
		int catchGainByLevel = CalabashModel.Instance.GetCatchGainByLevel(this.CurrentSelectedLevel);
		int tempCatchGain = calabashLevel3.Value.TempCatchGain;
		if (tempCatchGain <= catchGainByLevel)
		{
			attributeData.Value = new TableTextArgNew("PrefabTextItem_HuluTempCatchGainDisable_Text", Array.Empty<object>());
			return;
		}
		attributeData.Value = new TableTextArgNew("Text_ExplorationDegree_Text", new <>z__ReadOnlySingleElementList<object>(Math.Ceiling((double)tempCatchGain / 10.0).ToString()));
		if (!flag)
		{
			int tempCatchGain2 = calabashLevel2.Value.TempCatchGain;
			attributeData.IsUp = (tempCatchGain > tempCatchGain2);
		}
	}

	// Token: 0x0600ACA3 RID: 44195 RVA: 0x0026C54C File Offset: 0x0026A74C
	private void CreateLowCostAbsorptionData()
	{
		CalabashConfig instance = CalabashConfig.Instance;
		CalabashLevel? calabashLevel = (instance != null) ? instance.GetCalabashConfigByLevel(this.CurrentSelectedLevel) : null;
		if (calabashLevel == null)
		{
			Log instance2 = Log.Instance;
			ELogModule module = ELogModule.Calabash;
			ELogAuthor author = ELogAuthor.CB;
			string message = "找不到对应等级的配置信息";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("CurrentSelectedLevel", this.CurrentSelectedLevel);
			instance2.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return;
		}
		int lowCostTempCatchGain = calabashLevel.Value.LowCostTempCatchGain;
		if (lowCostTempCatchGain > 0)
		{
			CalabashAttributeData attributeData = this.GetAttributeData();
			attributeData.Type = ECalabashAttributeDataType.LowCostUpAbsorption;
			attributeData.Name = ECalabashTxt.UpAbsorptionTargetJunior.ToString();
			attributeData.IsCost = false;
			attributeData.IsUp = false;
			attributeData.IsToggleRaycast = true;
			attributeData.Value = new TableTextArgNew("Text_ExplorationDegree_Text", new <>z__ReadOnlySingleElementList<object>(Math.Ceiling((double)lowCostTempCatchGain / 10.0).ToString()));
		}
	}

	// Token: 0x0600ACA4 RID: 44196 RVA: 0x0026C634 File Offset: 0x0026A834
	private void CreateMaxQualityData()
	{
		int calabashLevel = CalabashModel.Instance.GetCalabashLevel();
		CalabashConfig instance = CalabashConfig.Instance;
		CalabashLevel? calabashLevel2 = (instance != null) ? instance.GetCalabashConfigByLevel(calabashLevel) : null;
		if (calabashLevel2 == null)
		{
			Log instance2 = Log.Instance;
			ELogModule module = ELogModule.Calabash;
			ELogAuthor author = ELogAuthor.CB;
			string message = "找不到对应等级的配置信息";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("curLevel", calabashLevel);
			instance2.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return;
		}
		CalabashConfig instance3 = CalabashConfig.Instance;
		CalabashLevel? calabashLevel3 = (instance3 != null) ? instance3.GetCalabashConfigByLevel(this.CurrentSelectedLevel) : null;
		bool flag = calabashLevel >= this.CurrentSelectedLevel;
		if (calabashLevel3 == null)
		{
			Log instance4 = Log.Instance;
			ELogModule module2 = ELogModule.Calabash;
			ELogAuthor author2 = ELogAuthor.CB;
			string message2 = "找不到对应等级的配置信息";
			ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("CurrentSelectedLevel", this.CurrentSelectedLevel);
			instance4.Error(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
			return;
		}
		CalabashAttributeData attributeData = this.GetAttributeData();
		attributeData.Type = ECalabashAttributeDataType.MaxQuality;
		attributeData.Name = "PrefabTextItem_3681645418_Text";
		attributeData.IsCost = false;
		attributeData.IsUp = false;
		string qualityDescription = calabashLevel3.Value.QualityDescription;
		attributeData.Value = new TableTextArgNew(qualityDescription, Array.Empty<object>());
		if (!flag)
		{
			string qualityDescription2 = calabashLevel2.Value.QualityDescription;
			attributeData.IsUp = (qualityDescription != qualityDescription2);
		}
		attributeData.IsToggleRaycast = true;
	}

	// Token: 0x0600ACA5 RID: 44197 RVA: 0x0026C78C File Offset: 0x0026A98C
	private void CreateMaxCostData()
	{
		int calabashLevel = CalabashModel.Instance.GetCalabashLevel();
		CalabashConfig instance = CalabashConfig.Instance;
		CalabashLevel? calabashLevel2 = (instance != null) ? instance.GetCalabashConfigByLevel(calabashLevel) : null;
		if (calabashLevel2 == null)
		{
			Log instance2 = Log.Instance;
			ELogModule module = ELogModule.Calabash;
			ELogAuthor author = ELogAuthor.CB;
			string message = "找不到对应等级的配置信息";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("curLevel", calabashLevel);
			instance2.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return;
		}
		CalabashConfig instance3 = CalabashConfig.Instance;
		CalabashLevel? calabashLevel3 = (instance3 != null) ? instance3.GetCalabashConfigByLevel(this.CurrentSelectedLevel) : null;
		bool flag = calabashLevel >= this.CurrentSelectedLevel;
		if (calabashLevel3 == null)
		{
			Log instance4 = Log.Instance;
			ELogModule module2 = ELogModule.Calabash;
			ELogAuthor author2 = ELogAuthor.CB;
			string message2 = "找不到对应等级的配置信息";
			ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("CurrentSelectedLevel", this.CurrentSelectedLevel);
			instance4.Error(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
			return;
		}
		CalabashAttributeData attributeData = this.GetAttributeData();
		attributeData.Type = ECalabashAttributeDataType.MaxCost;
		attributeData.Name = "PrefabTextItem_HuluCostLimit_Text";
		attributeData.IsCost = true;
		attributeData.IsUp = false;
		int cost = calabashLevel3.Value.Cost;
		attributeData.CostCount = cost;
		if (!flag)
		{
			int cost2 = calabashLevel2.Value.Cost;
			attributeData.IsUp = (cost > cost2);
		}
		attributeData.IsToggleRaycast = false;
	}

	// Token: 0x0600ACA6 RID: 44198 RVA: 0x0026C8D8 File Offset: 0x0026AAD8
	private void ClearAttributeData()
	{
		foreach (CalabashAttributeData item in this.AttributeDataList)
		{
			this.AttributeDataListPool.Add(item);
		}
		this.AttributeDataList.Clear();
	}

	// Token: 0x0600ACA7 RID: 44199 RVA: 0x0026C93C File Offset: 0x0026AB3C
	private CalabashAttributeData GetAttributeData()
	{
		CalabashAttributeData calabashAttributeData = null;
		if (this.AttributeDataListPool.Count > 0)
		{
			calabashAttributeData = this.AttributeDataListPool[0];
			this.AttributeDataListPool.RemoveAt(0);
		}
		if (calabashAttributeData == null)
		{
			calabashAttributeData = new CalabashAttributeData();
		}
		this.AttributeDataList.Add(calabashAttributeData);
		return calabashAttributeData;
	}

	// Token: 0x0600ACA8 RID: 44200 RVA: 0x0026C988 File Offset: 0x0026AB88
	private void OnClickDetailItem(CalabashAttributeData data)
	{
		this.CurrentSelectDetailType = ((data.Type == this.CurrentSelectDetailType) ? ECalabashAttributeDataType.Default : data.Type);
		this.RefreshAttribute();
	}

	// Token: 0x0600ACA9 RID: 44201 RVA: 0x0026C9AD File Offset: 0x0026ABAD
	private void RefreshCalabash()
	{
		this.RefreshNoCircleExhibitionView(false);
		this.RefreshSelectedLevelInfo();
		this.RefreshCalabashPlayerInfo();
	}

	// Token: 0x0600ACAA RID: 44202 RVA: 0x0026C9C4 File Offset: 0x0026ABC4
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	public override UUIItem[] GetGuideUiItemAndUiItemForShowEx(string[] configParams)
	{
		int num;
		if (configParams.Length != 1 && int.TryParse(configParams[0], out num))
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Guide;
			ELogAuthor author = ELogAuthor.JT;
			string message = "聚焦引导extraParam项配置有误";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("configParams", configParams);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return null;
		}
		GenericLayout<CalabashAttributeItem, CalabashAttributeData> attributeLayout = this.AttributeLayout;
		UUIItem uuiitem = (attributeLayout != null) ? attributeLayout.GetItemByIndex(int.Parse(configParams[0])) : null;
		if (uuiitem != null)
		{
			return new UUIItem[]
			{
				uuiitem,
				uuiitem
			};
		}
		return null;
	}

	// Token: 0x0600ACAB RID: 44203 RVA: 0x0026CA3C File Offset: 0x0026AC3C
	private void RefreshNoCircleExhibitionView(bool isInit = false)
	{
		int calabashLevel = CalabashModel.Instance.GetCalabashLevel();
		int currentExp = CalabashModel.Instance.GetCurrentExp();
		int calabashMaxLevel = CalabashModel.Instance.GetCalabashMaxLevel();
		if (this.CalabashGridDataList == null)
		{
			this.CalabashGridDataList = new CalabashGridData[calabashMaxLevel + 1];
		}
		int num = 0;
		for (int i = 0; i <= calabashMaxLevel; i++)
		{
			int levelUpExp = CalabashConfig.Instance.GetCalabashConfigByLevel(i).Value.LevelUpExp;
			int overFlowExp;
			int limitExp;
			if (i < calabashLevel)
			{
				overFlowExp = levelUpExp;
				limitExp = levelUpExp;
			}
			else
			{
				overFlowExp = Math.Min(levelUpExp, currentExp - num);
				limitExp = 0;
				num += levelUpExp;
			}
			CalabashGridData calabashGridData = this.CalabashGridDataList[i];
			if (calabashGridData == null)
			{
				calabashGridData = new CalabashGridData();
				this.CalabashGridDataList[i] = calabashGridData;
			}
			calabashGridData.Level = i;
			calabashGridData.OverFlowExp = overFlowExp;
			calabashGridData.LimitExp = limitExp;
			calabashGridData.MaxExp = levelUpExp;
			calabashGridData.IsMaxLevel = (i == calabashMaxLevel);
			if (i == 0)
			{
				calabashGridData.HasOverFlowExpReach = true;
			}
			else
			{
				CalabashGridData calabashGridData2 = this.CalabashGridDataList[i - 1];
				calabashGridData.HasOverFlowExpReach = (calabashGridData2.OverFlowExp == calabashGridData2.MaxExp);
			}
		}
		if (isInit)
		{
			this.NoCircleExhibitionView.ReloadView(this.CalabashGridDataList.Length, this.CalabashGridDataList, 0);
			this.NoCircleExhibitionView.AttachToIndex(calabashLevel, true);
			return;
		}
		foreach (CalabashGrid calabashGrid in this.NoCircleExhibitionView.GetItems())
		{
			calabashGrid.SetData(this.CalabashGridDataList);
			calabashGrid.RefreshItem();
		}
	}

	// Token: 0x0600ACAC RID: 44204 RVA: 0x0026CBE4 File Offset: 0x0026ADE4
	private void RefreshExpText(int curLevel)
	{
		int calabashMaxLevel = CalabashModel.Instance.GetCalabashMaxLevel();
		if (curLevel >= calabashMaxLevel)
		{
			LguiUtil.Instance.TrySetLocalTextNew(base.GetText(3), "DataBankLevelTips_Max", Array.Empty<object>());
			return;
		}
		int currentExp = CalabashModel.Instance.GetCurrentExp();
		CalabashLevel? calabashLevel;
		int? num = (CalabashConfig.Instance.GetCalabashConfigByLevel(curLevel) != null) ? new int?(calabashLevel.GetValueOrDefault().LevelUpExp) : null;
		LguiUtil.Instance.SetLocalTextNew(base.GetText(3), "CalabashLevelUpTabView_ExpText", new <>z__ReadOnlyArray<object>(new object[]
		{
			currentExp.ToString(),
			num.ToString()
		}));
	}

	// Token: 0x04004E88 RID: 20104
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private NoCircleAttachView<CalabashGridData, CalabashGrid> NoCircleExhibitionView;

	// Token: 0x04004E89 RID: 20105
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private CalabashGridData[] CalabashGridDataList;

	// Token: 0x04004E8A RID: 20106
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<CalabashAttributeItem, CalabashAttributeData> AttributeLayout;

	// Token: 0x04004E8B RID: 20107
	private readonly List<CalabashAttributeData> AttributeDataList = new List<CalabashAttributeData>();

	// Token: 0x04004E8C RID: 20108
	private readonly List<CalabashAttributeData> AttributeDataListPool = new List<CalabashAttributeData>();

	// Token: 0x04004E8D RID: 20109
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<CalabashLevelUpRewardItemGrid, CalabashRewardItemData> RewardLayout;

	// Token: 0x04004E8E RID: 20110
	private int AchieveStrengthItemNum;

	// Token: 0x04004E8F RID: 20111
	private readonly List<CalabashRewardItemData> RewardDataList = new List<CalabashRewardItemData>();

	// Token: 0x04004E90 RID: 20112
	[Nullable(2)]
	private UCurveFloat ItemCurve;

	// Token: 0x04004E91 RID: 20113
	private int CurrentSelectedLevel;

	// Token: 0x04004E92 RID: 20114
	private ECalabashAttributeDataType CurrentSelectDetailType = ECalabashAttributeDataType.Default;

	// Token: 0x04004E93 RID: 20115
	private bool NeedInitExhibition = true;
}
