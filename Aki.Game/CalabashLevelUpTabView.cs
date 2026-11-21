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

// Token: 0x02000C0B RID: 3083
[NullableContext(1)]
[Nullable(0)]
public class CalabashLevelUpTabView : UiTabViewBase
{
	// Token: 0x06008073 RID: 32883 RVA: 0x00275C94 File Offset: 0x00273E94
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

	// Token: 0x06008074 RID: 32884 RVA: 0x00275E0C File Offset: 0x0027400C
	private void OnHelpBtnClick()
	{
		ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.CalabashExpTipId);
		ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
	}

	// Token: 0x06008075 RID: 32885 RVA: 0x00275E30 File Offset: 0x00274030
	protected override void AddEventListener()
	{
		EventSystem.Instance.Add(EEventName.GetCalabashReward, new Action(this.RefreshCalabash));
		EventSystem.Instance.Add<EUiViewName, int>(EEventName.CloseView, new Action<EUiViewName, int>(this.OnRewardViewClose));
	}

	// Token: 0x06008076 RID: 32886 RVA: 0x00275E67 File Offset: 0x00274067
	protected override void RemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.GetCalabashReward, new Action(this.RefreshCalabash));
		EventSystem.Instance.Remove<EUiViewName, int>(EEventName.CloseView, new Action<EUiViewName, int>(this.OnRewardViewClose));
	}

	// Token: 0x06008077 RID: 32887 RVA: 0x00275EA0 File Offset: 0x002740A0
	protected override UniTask OnCreateAsync()
	{
		CalabashLevelUpTabView.<OnCreateAsync>d__16 <OnCreateAsync>d__;
		<OnCreateAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnCreateAsync>d__.<>4__this = this;
		<OnCreateAsync>d__.<>1__state = -1;
		<OnCreateAsync>d__.<>t__builder.Start<CalabashLevelUpTabView.<OnCreateAsync>d__16>(ref <OnCreateAsync>d__);
		return <OnCreateAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06008078 RID: 32888 RVA: 0x00275EE4 File Offset: 0x002740E4
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

	// Token: 0x06008079 RID: 32889 RVA: 0x00275F84 File Offset: 0x00274184
	private CalabashGrid InitGrid(AActor actor, int index, int showNum)
	{
		CalabashGrid calabashGrid = new CalabashGrid();
		calabashGrid.CreateThenShowByActor(actor, null);
		calabashGrid.ButtonFunction = new Action<int>(this.MoveCalabashGrid);
		calabashGrid.CheckToggleCanClick = new Func<bool>(this.CheckToggleCanClick);
		calabashGrid.ItemCurve = this.ItemCurve;
		return calabashGrid;
	}

	// Token: 0x0600807A RID: 32890 RVA: 0x00275FC3 File Offset: 0x002741C3
	private bool CheckToggleCanClick()
	{
		return !this.NoCircleExhibitionView.MovingState();
	}

	// Token: 0x0600807B RID: 32891 RVA: 0x00275FD3 File Offset: 0x002741D3
	private CalabashLevelUpRewardItemGrid CreateRewardItem()
	{
		return new CalabashLevelUpRewardItemGrid();
	}

	// Token: 0x0600807C RID: 32892 RVA: 0x00275FDA File Offset: 0x002741DA
	private CalabashAttributeItem CreateAttributeItem()
	{
		return new CalabashAttributeItem();
	}

	// Token: 0x0600807D RID: 32893 RVA: 0x00275FE1 File Offset: 0x002741E1
	protected override void OnBeforeShow()
	{
		this.RefreshNoCircleExhibitionView(this.NeedInitExhibition);
		this.NeedInitExhibition = false;
		this.RefreshCalabashPlayerInfo();
	}

	// Token: 0x0600807E RID: 32894 RVA: 0x00275FFC File Offset: 0x002741FC
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

	// Token: 0x0600807F RID: 32895 RVA: 0x0027604C File Offset: 0x0027424C
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

	// Token: 0x06008080 RID: 32896 RVA: 0x002762A0 File Offset: 0x002744A0
	private void MoveCalabashGrid(int showIndex)
	{
		this.CurrentSelectedLevel = showIndex;
		if (this.NoCircleExhibitionView.GetCurrentSelectIndex() != showIndex)
		{
			this.NoCircleExhibitionView.AttachToIndex(showIndex, false);
		}
		this.OnSelectedLevelChange();
	}

	// Token: 0x06008081 RID: 32897 RVA: 0x002762CA File Offset: 0x002744CA
	private void OnSelectedLevelChange()
	{
		this.RefreshSelectedLevelInfo();
		this.RefreshStrengthItemNum();
	}

	// Token: 0x06008082 RID: 32898 RVA: 0x002762D8 File Offset: 0x002744D8
	private void RefreshSelectedLevelInfo()
	{
		this.RefreshReward();
		this.RefreshButtonState();
		this.RefreshAttribute();
	}

	// Token: 0x06008083 RID: 32899 RVA: 0x002762EC File Offset: 0x002744EC
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

	// Token: 0x06008084 RID: 32900 RVA: 0x00276378 File Offset: 0x00274578
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

	// Token: 0x06008085 RID: 32901 RVA: 0x002764C4 File Offset: 0x002746C4
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

	// Token: 0x06008086 RID: 32902 RVA: 0x002765A4 File Offset: 0x002747A4
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

	// Token: 0x06008087 RID: 32903 RVA: 0x00276680 File Offset: 0x00274880
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

	// Token: 0x06008088 RID: 32904 RVA: 0x0027673C File Offset: 0x0027493C
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

	// Token: 0x06008089 RID: 32905 RVA: 0x002767E8 File Offset: 0x002749E8
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

	// Token: 0x0600808A RID: 32906 RVA: 0x00276994 File Offset: 0x00274B94
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

	// Token: 0x0600808B RID: 32907 RVA: 0x00276A7C File Offset: 0x00274C7C
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

	// Token: 0x0600808C RID: 32908 RVA: 0x00276BD4 File Offset: 0x00274DD4
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

	// Token: 0x0600808D RID: 32909 RVA: 0x00276D20 File Offset: 0x00274F20
	private void ClearAttributeData()
	{
		foreach (CalabashAttributeData item in this.AttributeDataList)
		{
			this.AttributeDataListPool.Add(item);
		}
		this.AttributeDataList.Clear();
	}

	// Token: 0x0600808E RID: 32910 RVA: 0x00276D84 File Offset: 0x00274F84
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

	// Token: 0x0600808F RID: 32911 RVA: 0x00276DD0 File Offset: 0x00274FD0
	private void OnClickDetailItem(CalabashAttributeData data)
	{
		this.CurrentSelectDetailType = ((data.Type == this.CurrentSelectDetailType) ? ECalabashAttributeDataType.Default : data.Type);
		this.RefreshAttribute();
	}

	// Token: 0x06008090 RID: 32912 RVA: 0x00276DF5 File Offset: 0x00274FF5
	private void RefreshCalabash()
	{
		this.RefreshNoCircleExhibitionView(false);
		this.RefreshSelectedLevelInfo();
		this.RefreshCalabashPlayerInfo();
	}

	// Token: 0x06008091 RID: 32913 RVA: 0x00276E0C File Offset: 0x0027500C
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

	// Token: 0x06008092 RID: 32914 RVA: 0x00276E84 File Offset: 0x00275084
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

	// Token: 0x06008093 RID: 32915 RVA: 0x0027702C File Offset: 0x0027522C
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

	// Token: 0x04004F31 RID: 20273
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private NoCircleAttachView<CalabashGridData, CalabashGrid> NoCircleExhibitionView;

	// Token: 0x04004F32 RID: 20274
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private CalabashGridData[] CalabashGridDataList;

	// Token: 0x04004F33 RID: 20275
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<CalabashAttributeItem, CalabashAttributeData> AttributeLayout;

	// Token: 0x04004F34 RID: 20276
	private readonly List<CalabashAttributeData> AttributeDataList = new List<CalabashAttributeData>();

	// Token: 0x04004F35 RID: 20277
	private readonly List<CalabashAttributeData> AttributeDataListPool = new List<CalabashAttributeData>();

	// Token: 0x04004F36 RID: 20278
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<CalabashLevelUpRewardItemGrid, CalabashRewardItemData> RewardLayout;

	// Token: 0x04004F37 RID: 20279
	private int AchieveStrengthItemNum;

	// Token: 0x04004F38 RID: 20280
	private readonly List<CalabashRewardItemData> RewardDataList = new List<CalabashRewardItemData>();

	// Token: 0x04004F39 RID: 20281
	[Nullable(2)]
	private UCurveFloat ItemCurve;

	// Token: 0x04004F3A RID: 20282
	private int CurrentSelectedLevel;

	// Token: 0x04004F3B RID: 20283
	private ECalabashAttributeDataType CurrentSelectDetailType = ECalabashAttributeDataType.Default;

	// Token: 0x04004F3C RID: 20284
	private bool NeedInitExhibition = true;
}
