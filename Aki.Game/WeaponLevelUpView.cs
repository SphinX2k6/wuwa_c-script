using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Common;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.Item;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02002254 RID: 8788
[NullableContext(1)]
[Nullable(0)]
public class WeaponLevelUpView : UiTabViewBase
{
	// Token: 0x06015BA1 RID: 88993 RVA: 0x0064CF08 File Offset: 0x0064B108
	protected unsafe override void OnRegisterComponent()
	{
		int num = 5;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIVerticalLayout));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x06015BA2 RID: 88994 RVA: 0x0064CFD4 File Offset: 0x0064B1D4
	protected override UniTask OnBeforeStartAsync()
	{
		WeaponLevelUpView.<OnBeforeStartAsync>d__14 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<WeaponLevelUpView.<OnBeforeStartAsync>d__14>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06015BA3 RID: 88995 RVA: 0x0064D018 File Offset: 0x0064B218
	protected override void OnStart()
	{
		int incId = (int)this.ExtraParams;
		this.WeaponInstance = WeaponModel.Instance.GetWeaponDataByIncId(incId);
		this.InitExpComponent();
		this.InitAttributeItemList();
		this.InitConsumeComponent();
	}

	// Token: 0x06015BA4 RID: 88996 RVA: 0x0064D054 File Offset: 0x0064B254
	protected override void OnBeforeDestroy()
	{
		this.ExpComponent.Destroy(null);
		this.ItemGridConsumeComponent.Destroy(null);
		this.CheckAndCloseItemHintViewNew();
	}

	// Token: 0x06015BA5 RID: 88997 RVA: 0x0064D074 File Offset: 0x0064B274
	protected override void OnBeforeShow()
	{
		this.RefreshSelectedList();
		this.InitExp();
		this.RefreshName();
		this.UpdateAttribute();
		this.UpdateConsumeComponent();
	}

	// Token: 0x06015BA6 RID: 88998 RVA: 0x0064D094 File Offset: 0x0064B294
	private void RefreshSelectedList()
	{
		if (this.SelectedList == null || this.SelectedList.Count == 0)
		{
			return;
		}
		WeaponModel instance = WeaponModel.Instance;
		InventoryModel instance2 = InventoryModel.Instance;
		for (int i = this.SelectedList.Count - 1; i >= 0; i--)
		{
			ISelectedData selectedData = this.SelectedList[i];
			bool flag;
			if (selectedData.IncId > 0)
			{
				flag = (instance.GetWeaponDataByIncId(selectedData.IncId) != null);
			}
			else
			{
				List<ItemDataBase> itemDataBaseByConfigId = instance2.GetItemDataBaseByConfigId(selectedData.ItemId);
				if (itemDataBaseByConfigId.Count > 0)
				{
					int num = 0;
					foreach (ItemDataBase itemDataBase in itemDataBaseByConfigId)
					{
						num += itemDataBase.GetCount();
					}
					if (selectedData.SelectedCount > num)
					{
						selectedData.SelectedCount = num;
					}
					flag = (selectedData.SelectedCount > 0);
				}
				else
				{
					flag = false;
				}
			}
			if (!flag)
			{
				this.SelectedList.RemoveAt(i);
			}
		}
	}

	// Token: 0x06015BA7 RID: 88999 RVA: 0x0064D1A4 File Offset: 0x0064B3A4
	protected override void AddEventListener()
	{
		EventSystem.Instance.Add(EEventName.WeaponLevelUp, new Action(this.WeaponLevelUpEvent));
		EventSystem.Instance.Add<IReadOnlyList<TItem>>(EEventName.WeaponLevelUpReceiveItem, new Action<IReadOnlyList<TItem>>(this.WeaponLevelUpReceiveItem));
		EventSystem.Instance.Add<int>(EEventName.OnPlayerCurrencyChange, new Action<int>(this.OnPlayerCurrencyChange));
	}

	// Token: 0x06015BA8 RID: 89000 RVA: 0x0064D208 File Offset: 0x0064B408
	protected override void RemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.WeaponLevelUp, new Action(this.WeaponLevelUpEvent));
		EventSystem.Instance.Remove<IReadOnlyList<TItem>>(EEventName.WeaponLevelUpReceiveItem, new Action<IReadOnlyList<TItem>>(this.WeaponLevelUpReceiveItem));
		EventSystem.Instance.Remove<int>(EEventName.OnPlayerCurrencyChange, new Action<int>(this.OnPlayerCurrencyChange));
	}

	// Token: 0x06015BA9 RID: 89001 RVA: 0x0064D269 File Offset: 0x0064B469
	private void OnPlayerCurrencyChange(int i)
	{
		this.UpdateConsumeComponent();
	}

	// Token: 0x06015BAA RID: 89002 RVA: 0x0064D271 File Offset: 0x0064B471
	protected override void OnHideUiTabViewBase(bool fromToggle)
	{
		if (fromToggle)
		{
			UiManager.Instance.CloseView(EUiViewName.CommonItemSelectViewRight, null);
		}
	}

	// Token: 0x06015BAB RID: 89003 RVA: 0x0064D288 File Offset: 0x0064B488
	private void WeaponLevelUpEvent()
	{
		this.OnLevelUpSuccess();
		this.ExpComponent.PlayExpTween(this.CurrentExpData);
		this.SelectedList.Clear();
		this.ClearConsume();
		this.ItemGridConsumeComponent.UpdateComponent(2, 0, this.ConsumeList);
		this.ItemGridConsumeComponent.SetMaxState(this.WeaponInstance.IsLevelMax());
	}

	// Token: 0x06015BAC RID: 89004 RVA: 0x0064D2E6 File Offset: 0x0064B4E6
	private void WeaponLevelUpReceiveItem(IReadOnlyList<TItem> itemList)
	{
		this.ReceiveItemList = new List<TItem>(itemList);
		this.ReceiveItemList.Sort(delegate(TItem a, TItem b)
		{
			CSharpScript.Game.Module.Inventory.ItemConfig itemConfigData = InventoryConfig.Instance.GetItemConfigData(a.ItemData.ItemId);
			return InventoryConfig.Instance.GetItemConfigData(b.ItemData.ItemId).QualityId - itemConfigData.QualityId;
		});
	}

	// Token: 0x06015BAD RID: 89005 RVA: 0x0064D320 File Offset: 0x0064B520
	private void InitExpComponent()
	{
		this.ExpComponent = new ExpComponent(base.GetItem(0), false);
		this.ExpComponent.Init();
		this.ExpComponent.SetLevelFormatText("LevelNumber");
		this.ExpComponent.BindPlayCompleteCallBack(new Action<bool>(this.OnExpTweenComplete));
		this.CurrentExpData = new SelectableExpData();
		this.CurrentExpData.SetMaxExpFunction(new Func<int, int>(this.GetCurLevelExp));
	}

	// Token: 0x06015BAE RID: 89006 RVA: 0x0064D394 File Offset: 0x0064B594
	private void InitExp()
	{
		this.UpdateExpData();
		this.ExpComponent.UpdateInitState(this.CurrentExpData);
	}

	// Token: 0x06015BAF RID: 89007 RVA: 0x0064D3B0 File Offset: 0x0064B5B0
	private void UpdateExpData()
	{
		int level = this.WeaponInstance.GetLevel();
		int currentMaxLevel = this.WeaponInstance.GetCurrentMaxLevel();
		int exp = this.WeaponInstance.GetExp();
		int maxLevel = this.WeaponInstance.GetMaxLevel();
		this.CurrentExpData.UpdateComponent(level, currentMaxLevel, exp, new int?(maxLevel), false);
	}

	// Token: 0x06015BB0 RID: 89008 RVA: 0x0064D402 File Offset: 0x0064B602
	private int GetCurLevelExp(int level)
	{
		return this.WeaponInstance.GetLevelExp(level);
	}

	// Token: 0x06015BB1 RID: 89009 RVA: 0x0064D410 File Offset: 0x0064B610
	private int GetItemExpFunction(ISelectedData selectedData)
	{
		return WeaponModel.Instance.GetWeaponItemExp(selectedData.IncId, selectedData.ItemId);
	}

	// Token: 0x06015BB2 RID: 89010 RVA: 0x0064D428 File Offset: 0x0064B628
	private void OnExpTweenComplete(bool _)
	{
		this.InitExp();
		this.UpdateAttribute();
	}

	// Token: 0x06015BB3 RID: 89011 RVA: 0x0064D438 File Offset: 0x0064B638
	private void OnLevelUpSuccess()
	{
		int currentLevel = this.CurrentExpData.GetCurrentLevel();
		int level = this.WeaponInstance.GetLevel();
		this.WeaponObserver = UiSceneManager.Instance.GetWeaponObserver();
		this.WeaponScabbardObserver = UiSceneManager.Instance.GetWeaponScabbardObserver();
		WeaponController.Instance.PlayWeaponRenderingMaterial("WeaponLevelUpMaterialController", this.WeaponObserver, this.WeaponScabbardObserver);
		UiModelBase model = this.WeaponObserver.Model;
		UiModelUtil.Instance.PlayEffectAtRootComponent(model, "WeaponLevelUpEffect");
		if (currentLevel == level)
		{
			return;
		}
		List<IAttributeInfo> levelUpAttributeDataList = this.GetLevelUpAttributeDataList(currentLevel, level);
		ILevelUpSuccessAttributeData data = null;
		if (this.WeaponInstance.CanGoBreach())
		{
			data = new LevelUpSuccessAttributeData
			{
				Title = "Text_WeaponLevelUpSuccessText_Text",
				LevelInfo = new LevelInfo
				{
					PreUpgradeLv = currentLevel,
					UpgradeLv = level,
					FormatStringId = "Text_LevelShow_Text",
					IsMaxLevel = new bool?(true)
				},
				AttributeInfo = levelUpAttributeDataList,
				ClickText = "Text_TurnToBreach_Text",
				ClickFunction = new Action(this.TurnToBreachView)
			};
		}
		else
		{
			data = new LevelUpSuccessAttributeData
			{
				Title = "Text_WeaponLevelUpSuccessText_Text",
				LevelInfo = new LevelInfo
				{
					PreUpgradeLv = currentLevel,
					UpgradeLv = level,
					FormatStringId = "Text_LevelShow_Text",
					IsMaxLevel = new bool?(this.WeaponInstance.GetLevel() == this.WeaponInstance.GetMaxLevel())
				},
				AttributeInfo = levelUpAttributeDataList
			};
		}
		if (data == null)
		{
			return;
		}
		int? weaponLevelUpSuccessDelayTime = RoleConfig.Instance.GetWeaponLevelUpSuccessDelayTime();
		UiLayer.Instance.SetShowMaskLayer("OpenLevelUpSuccessView", true);
		TimerSystem.GameplayTimeInstance.Delay(delegate(float _)
		{
			RoleLevelUpSuccessController.Instance.OpenSuccessAttributeView(data, null);
			UiLayer.Instance.SetShowMaskLayer("OpenLevelUpSuccessView", false);
			this.TryOpenItemHintView();
		}, (float)weaponLevelUpSuccessDelayTime.Value, null, null, true, 1f);
	}

	// Token: 0x06015BB4 RID: 89012 RVA: 0x0064D602 File Offset: 0x0064B802
	private void InitAttributeItemList()
	{
		this.AttributeLayout = new GenericLayout<AttributeItem, CSharpScript.Game.Module.Common.AttributeData>(base.GetVerticalLayout(1), new Func<AttributeItem>(this.CreateAttributeItem), null, false, true);
	}

	// Token: 0x06015BB5 RID: 89013 RVA: 0x0064D625 File Offset: 0x0064B825
	private AttributeItem CreateAttributeItem()
	{
		return new AttributeItem();
	}

	// Token: 0x06015BB6 RID: 89014 RVA: 0x0064D62C File Offset: 0x0064B82C
	private void UpdateAttribute()
	{
		WeaponConf? weaponConfig = this.WeaponInstance.GetWeaponConfig();
		this.AttributeParamList = new List<IWeaponAttributeParam>(WeaponModel.Instance.GetWeaponAttributeParamList(weaponConfig.Value));
		int breachLevel = this.WeaponInstance.GetBreachLevel();
		int currentLevel = this.CurrentExpData.GetCurrentLevel();
		int arrivedLevel = this.CurrentExpData.GetArrivedLevel();
		List<CSharpScript.Game.Module.Common.AttributeData> list = new List<CSharpScript.Game.Module.Common.AttributeData>();
		foreach (IWeaponAttributeParam weaponAttributeParam in this.AttributeParamList)
		{
			int curveId = weaponAttributeParam.CurveId;
			float value = weaponAttributeParam.PropId.Value;
			float curveValue = WeaponModel.Instance.GetCurveValue(curveId, value, currentLevel, breachLevel);
			float num = 0f;
			if (arrivedLevel > currentLevel)
			{
				num = WeaponModel.Instance.GetCurveValue(curveId, value, arrivedLevel, breachLevel);
			}
			CSharpScript.Game.Module.Common.AttributeData item = new CSharpScript.Game.Module.Common.AttributeData
			{
				Id = weaponAttributeParam.PropId.Id,
				IsRatio = weaponAttributeParam.PropId.IsRatio,
				CurValue = curveValue,
				BgActive = new bool?(true),
				ShowNext = new bool?(num > curveValue),
				NextValue = new float?(num)
			};
			list.Add(item);
		}
		this.AttributeLayout.RefreshByData(list, null, false);
	}

	// Token: 0x06015BB7 RID: 89015 RVA: 0x0064D79C File Offset: 0x0064B99C
	private List<IAttributeInfo> GetLevelUpAttributeDataList(int currentLevel, int arrivedLevel)
	{
		List<IAttributeInfo> list = new List<IAttributeInfo>();
		int breachLevel = this.WeaponInstance.GetBreachLevel();
		foreach (IWeaponAttributeParam weaponAttributeParam in this.AttributeParamList)
		{
			float curveValue = WeaponModel.Instance.GetCurveValue(weaponAttributeParam.CurveId, weaponAttributeParam.PropId.Value, currentLevel, breachLevel);
			float curveValue2 = WeaponModel.Instance.GetCurveValue(weaponAttributeParam.CurveId, weaponAttributeParam.PropId.Value, arrivedLevel, breachLevel);
			if (curveValue != curveValue2)
			{
				AttrListScrollData attrData = new AttrListScrollData(weaponAttributeParam.PropId.Id, (double)curveValue, (double)curveValue2, 0, weaponAttributeParam.PropId.IsRatio, CommonComponentDefine.EAttributeType.NormalType);
				list.Add(RoleLevelUpSuccessController.ConvertsAttrListScrollDataToAttributeInfo(attrData));
			}
		}
		return list;
	}

	// Token: 0x06015BB8 RID: 89016 RVA: 0x0064D888 File Offset: 0x0064BA88
	private void InitConsumeComponent()
	{
		this.ItemGridConsumeComponent.InitFilter(EItemGridConsumeLocalDropDown.WeaponLevelUp, new Action<int>(this.ConditionFunction));
		this.ItemGridConsumeComponent.SetConsumeTexture(2);
		this.CurrentAutoQualityIndex = new int?(this.ItemGridConsumeComponent.GetCurrentDropDownSelectIndex());
		if (this.CurrentAutoQualityIndex != null)
		{
			this.RefreshConditionText();
		}
		int maxCount = this.ItemGridConsumeComponent.GetMaxCount();
		this.ConsumeList = new List<TCommonMultipleConsumeData>(maxCount);
		for (int i = 0; i < maxCount; i++)
		{
			this.ConsumeList.Add(new TCommonMultipleConsumeData(new InventoryDefine.GetItemData(0, 0), 0));
		}
	}

	// Token: 0x06015BB9 RID: 89017 RVA: 0x0064D91E File Offset: 0x0064BB1E
	private void UpdateConsumeComponent()
	{
		this.RefreshItemAndExp();
		this.ItemGridConsumeComponent.SetMaxState(this.WeaponInstance.IsLevelMax());
	}

	// Token: 0x06015BBA RID: 89018 RVA: 0x0064D93C File Offset: 0x0064BB3C
	private void LevelUpClick(int data)
	{
		if (this.SelectedList == null || this.SelectedList.Count <= 0)
		{
			ScrollingTipsController.Instance.ShowTipsById("WeaponSelectMaterialTipsText", Array.Empty<object>());
			return;
		}
		if (!this.ItemGridConsumeComponent.GetEnoughMoney())
		{
			ScrollingTipsController.Instance.ShowTipsById("WeaponNoEnoughMoneyText", Array.Empty<object>());
			return;
		}
		Action action = delegate()
		{
			int? incId = this.WeaponInstance.GetIncId();
			WeaponController.Instance.SendPbWeaponLevelUpRequest(incId.Value, this.SelectedList.ToArray());
		};
		if (WeaponModel.Instance.LevelUpConfirmTipsNotShow)
		{
			action();
			return;
		}
		List<string> conditionTextList = this.GetConditionTextList();
		Dictionary<int, int> overExpMap = this.GetOverExpMap();
		bool flag = overExpMap.Count > 0;
		bool flag2 = conditionTextList.Count > 0;
		ConfirmBoxDataNew confirmBoxDataNew = null;
		if (flag && flag2)
		{
			confirmBoxDataNew = this.CreateLevelUpTipsWithAll(conditionTextList, overExpMap);
		}
		else if (flag)
		{
			confirmBoxDataNew = this.CreateLevelUpTipsWithOverflow(overExpMap);
		}
		else if (flag2)
		{
			confirmBoxDataNew = this.CreateLevelUpTipsWithCondition(conditionTextList);
		}
		if (confirmBoxDataNew != null)
		{
			confirmBoxDataNew.FunctionMap.Add(2, action);
			confirmBoxDataNew.HasToggle = true;
			confirmBoxDataNew.ToggleText = ConfigMultiTextLang.GetLocalTextNew("Text_WeaponLevelUpTips_Text", null);
			confirmBoxDataNew.SetToggleFunction(delegate(bool isSelectOn)
			{
				WeaponModel.Instance.LevelUpConfirmTipsNotShow = isSelectOn;
			});
			ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
			return;
		}
		action();
	}

	// Token: 0x06015BBB RID: 89019 RVA: 0x0064DA70 File Offset: 0x0064BC70
	private List<string> GetConditionTextList()
	{
		bool flag = false;
		bool flag2 = false;
		bool flag3 = false;
		foreach (ISelectedData selectedData in this.SelectedList)
		{
			WeaponInstance weaponDataByIncId = WeaponModel.Instance.GetWeaponDataByIncId(selectedData.IncId);
			if (weaponDataByIncId != null)
			{
				if (!flag && WeaponModel.Instance.IsWeaponHighQuality(weaponDataByIncId))
				{
					flag = true;
				}
				if (!flag2 && WeaponModel.Instance.IsWeaponHighLevel(weaponDataByIncId))
				{
					flag2 = true;
				}
				if (!flag3 && WeaponModel.Instance.IsWeaponHighResonanceLevel(weaponDataByIncId))
				{
					flag3 = true;
				}
			}
		}
		List<string> list = new List<string>();
		if (flag)
		{
			string textById = TextConfig.Instance.GetTextById("WeaponHighQuality");
			list.Add(textById);
		}
		if (flag2)
		{
			string textById2 = TextConfig.Instance.GetTextById("WeaponHasLevelUp");
			list.Add(textById2);
		}
		if (flag3)
		{
			string textById3 = TextConfig.Instance.GetTextById("WeaponHasResonance");
			list.Add(textById3);
		}
		return list;
	}

	// Token: 0x06015BBC RID: 89020 RVA: 0x0064DB70 File Offset: 0x0064BD70
	private Dictionary<int, int> GetOverExpMap()
	{
		int overExp = this.CurrentExpData.GetOverExp();
		Dictionary<int, int> result;
		if (overExp > 0)
		{
			result = WeaponModel.Instance.GetCanChangeMaterialList(overExp);
		}
		else
		{
			result = new Dictionary<int, int>();
		}
		return result;
	}

	// Token: 0x06015BBD RID: 89021 RVA: 0x0064DBA4 File Offset: 0x0064BDA4
	private ConfirmBoxDataNew CreateLevelUpTipsWithCondition(List<string> words)
	{
		EConfirmBoxConfigId? econfirmBoxConfigId = null;
		switch (words.Count)
		{
		case 1:
			econfirmBoxConfigId = new EConfirmBoxConfigId?(EConfirmBoxConfigId.WeaponLevelUpOneCondition);
			break;
		case 2:
			econfirmBoxConfigId = new EConfirmBoxConfigId?(EConfirmBoxConfigId.WeaponLevelUpTwoCondition);
			break;
		case 3:
			econfirmBoxConfigId = new EConfirmBoxConfigId?(EConfirmBoxConfigId.WeaponLevelUpThreeCondition);
			break;
		}
		ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(econfirmBoxConfigId.Value);
		confirmBoxDataNew.SetTextArgs(words.ToArray());
		return confirmBoxDataNew;
	}

	// Token: 0x06015BBE RID: 89022 RVA: 0x0064DC0A File Offset: 0x0064BE0A
	private ConfirmBoxDataNew CreateLevelUpTipsWithOverflow(Dictionary<int, int> overItemMap)
	{
		return new ConfirmBoxDataNew(EConfirmBoxConfigId.WeaponOverflowExpTip)
		{
			ItemIdMap = overItemMap
		};
	}

	// Token: 0x06015BBF RID: 89023 RVA: 0x0064DC1C File Offset: 0x0064BE1C
	private ConfirmBoxDataNew CreateLevelUpTipsWithAll(List<string> words, Dictionary<int, int> overItemMap)
	{
		EConfirmBoxConfigId? econfirmBoxConfigId = null;
		switch (words.Count)
		{
		case 1:
			econfirmBoxConfigId = new EConfirmBoxConfigId?(EConfirmBoxConfigId.WeaponLevelUpTipsOverflow1);
			break;
		case 2:
			econfirmBoxConfigId = new EConfirmBoxConfigId?(EConfirmBoxConfigId.WeaponLevelUpTipsOverflow2);
			break;
		case 3:
			econfirmBoxConfigId = new EConfirmBoxConfigId?(EConfirmBoxConfigId.WeaponLevelUpTipsOverflow3);
			break;
		}
		ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(econfirmBoxConfigId.Value);
		confirmBoxDataNew.SetTextArgs(words.ToArray());
		confirmBoxDataNew.ItemIdMap = overItemMap;
		return confirmBoxDataNew;
	}

	// Token: 0x06015BC0 RID: 89024 RVA: 0x0064DC98 File Offset: 0x0064BE98
	private void MaterialItemFunction(int? incId, int? itemId)
	{
		CommonItemSelectViewOpenViewData<ItemDataBase> commonItemSelectViewOpenViewData = new CommonItemSelectViewOpenViewData<ItemDataBase>();
		List<ItemDataBase> weaponExpItemList = WeaponModel.Instance.GetWeaponExpItemList(this.WeaponInstance.GetIncId());
		CommonIntensifyPropExpData commonIntensifyPropExpData = new CommonIntensifyPropExpData();
		commonIntensifyPropExpData.CurrentExp = this.CurrentExpData.GetCurrentExp();
		commonIntensifyPropExpData.CurrentLevel = this.CurrentExpData.GetCurrentLevel();
		commonIntensifyPropExpData.CurrentMaxLevel = this.CurrentExpData.GetCurrentMaxLevel();
		commonIntensifyPropExpData.MaxExpFunction = new Func<int, int>(this.GetCurLevelExp);
		commonIntensifyPropExpData.GetItemExpFunction = new Func<ISelectedData, int>(this.GetItemExpFunction);
		List<ISelectedData> selectedList = this.SelectedList;
		SelectableComponentData selectableComponentData = new SelectableComponentData();
		selectableComponentData.IsSingleSelected = false;
		selectableComponentData.OnChangeSelectedFunction = new Action<List<ISelectedData>, SelectableExpData>(this.OnChangeSelectedFunction);
		selectableComponentData.MaxSelectedGridNum = this.ItemGridConsumeComponent.GetMaxCount();
		commonItemSelectViewOpenViewData.ItemDataBaseList = weaponExpItemList;
		commonItemSelectViewOpenViewData.SelectedDataList = (selectedList ?? new List<ISelectedData>());
		commonItemSelectViewOpenViewData.ExpData = commonIntensifyPropExpData;
		commonItemSelectViewOpenViewData.SelectableComponentData = selectableComponentData;
		commonItemSelectViewOpenViewData.UseWayId = EFilterSortGroupId.UseWayWeaponStrength;
		UiManager.Instance.OpenView(EUiViewName.CommonItemSelectViewRight, commonItemSelectViewOpenViewData, null);
	}

	// Token: 0x06015BC1 RID: 89025 RVA: 0x0064DD97 File Offset: 0x0064BF97
	private void OnChangeSelectedFunction(List<ISelectedData> currentSelectedData, SelectableExpData expData)
	{
		this.SelectedList = currentSelectedData;
		this.CurrentExpData = expData;
		this.RefreshItemAndExp();
	}

	// Token: 0x06015BC2 RID: 89026 RVA: 0x0064DDAD File Offset: 0x0064BFAD
	private void ItemClickFunction()
	{
		this.MaterialItemFunction(new int?(0), new int?(0));
	}

	// Token: 0x06015BC3 RID: 89027 RVA: 0x0064DDC1 File Offset: 0x0064BFC1
	private void OnClickDeleteSelectFunction()
	{
		this.SelectedList = new List<ISelectedData>();
		this.RefreshItemAndExp();
	}

	// Token: 0x06015BC4 RID: 89028 RVA: 0x0064DDD4 File Offset: 0x0064BFD4
	private void OnClickAutoFunction(int qualityId)
	{
		List<ItemDataBase> weaponExpItemListUseToAuto = WeaponModel.Instance.GetWeaponExpItemListUseToAuto(this.WeaponInstance.GetIncId());
		List<ISelectedData> list = new List<ISelectedData>();
		int qualityIdByIndex = this.GetQualityIdByIndex(this.CurrentAutoQualityIndex.Value);
		foreach (ItemDataBase itemDataBase in weaponExpItemListUseToAuto)
		{
			if (itemDataBase.GetQuality() <= qualityIdByIndex)
			{
				SelectedData item = new SelectedData
				{
					IncId = itemDataBase.GetUniqueId(),
					ItemId = itemDataBase.GetConfigId(),
					Count = itemDataBase.GetCount(),
					SelectedCount = 0
				};
				list.Add(item);
			}
		}
		if (list.Count == 0)
		{
			ScrollingTipsController.Instance.ShowTipsById("RoleNoMaterial", Array.Empty<object>());
			return;
		}
		int expDistanceToMax = this.CurrentExpData.GetExpDistanceToMax();
		int maxCount = this.ItemGridConsumeComponent.GetMaxCount();
		List<ISelectedData> selectedList = WeaponModel.Instance.AutoAddExpItem(expDistanceToMax, maxCount, list.ToArray(), new Func<ISelectedData, int>(this.GetItemExpFunction));
		this.SelectedList = selectedList;
		this.SelectedList.Sort(delegate(ISelectedData a, ISelectedData b)
		{
			bool flag = a.IncId > 0;
			bool flag2 = b.IncId > 0;
			if (flag == flag2)
			{
				return 0;
			}
			if (!flag)
			{
				return -1;
			}
			return 1;
		});
		this.RefreshItemAndExp();
	}

	// Token: 0x06015BC5 RID: 89029 RVA: 0x0064DF20 File Offset: 0x0064C120
	private void OnClickItemReduce(int? incId, int? itemId)
	{
		for (int i = this.SelectedList.Count - 1; i >= 0; i--)
		{
			int itemId2 = this.SelectedList[i].ItemId;
			int? num = itemId;
			if (itemId2 == num.GetValueOrDefault() & num != null)
			{
				int incId2 = this.SelectedList[i].IncId;
				num = incId;
				if (incId2 == num.GetValueOrDefault() & num != null)
				{
					ISelectedData selectedData = this.SelectedList[i];
					int selectedCount = selectedData.SelectedCount;
					selectedData.SelectedCount = selectedCount - 1;
					if (this.SelectedList[i].SelectedCount == 0)
					{
						this.SelectedList.RemoveAt(i);
					}
				}
			}
		}
		this.RefreshItemAndExp();
	}

	// Token: 0x06015BC6 RID: 89030 RVA: 0x0064DFD7 File Offset: 0x0064C1D7
	private void ConditionFunction(int index)
	{
		this.CurrentAutoQualityIndex = new int?(index);
		this.RefreshConditionText();
	}

	// Token: 0x06015BC7 RID: 89031 RVA: 0x0064DFEC File Offset: 0x0064C1EC
	private void RefreshConditionText()
	{
		int qualityIdByIndex = this.GetQualityIdByIndex(this.CurrentAutoQualityIndex.Value);
		this.ItemGridConsumeComponent.RefreshConditionText(CommonConfig.Instance.GetItemQualityById(qualityIdByIndex).Value.ConsumeFilterText);
	}

	// Token: 0x06015BC8 RID: 89032 RVA: 0x0064E034 File Offset: 0x0064C234
	private int GetQualityIdByIndex(int index)
	{
		List<QualityInfo> itemQualityList = CommonConfig.Instance.GetItemQualityList();
		int index2 = MathUtils.Instance.Clamp(index, 0, itemQualityList.Count - 1);
		return itemQualityList[index2].Id;
	}

	// Token: 0x06015BC9 RID: 89033 RVA: 0x0064E070 File Offset: 0x0064C270
	private void RefreshItemAndExp()
	{
		int num = 0;
		this.ClearConsume();
		if (this.SelectedList != null)
		{
			for (int i = 0; i < this.SelectedList.Count; i++)
			{
				ISelectedData selectedData = this.SelectedList[i];
				TCommonMultipleConsumeData value = this.ConsumeList[i];
				value.ItemData = new InventoryDefine.GetItemData(selectedData.ItemId, selectedData.IncId);
				value.Count = selectedData.SelectedCount;
				this.ConsumeList[i] = value;
				num += this.GetItemExpFunction(selectedData) * selectedData.SelectedCount;
			}
		}
		int weaponExpItemListCost = WeaponModel.Instance.GetWeaponExpItemListCost(this.ConsumeList.ToArray());
		this.ItemGridConsumeComponent.UpdateComponent(2, weaponExpItemListCost, this.ConsumeList);
		this.CurrentExpData.UpdateExp(num);
		this.ExpComponent.Update(this.CurrentExpData, true);
		this.UpdateAttribute();
	}

	// Token: 0x06015BCA RID: 89034 RVA: 0x0064E150 File Offset: 0x0064C350
	private void RefreshName()
	{
		WeaponConf value = this.WeaponInstance.GetWeaponConfig().Value;
		string weaponName = value.WeaponName;
		FColor color = FColor.FromHex(CSharpScript.Game.Module.Item.ItemConfig.Instance.GetQualityConfig(value.QualityId).Value.DropColor);
		base.GetText(4).SetColor(color);
		base.GetText(4).ShowTextNew(weaponName);
	}

	// Token: 0x06015BCB RID: 89035 RVA: 0x0064E1BC File Offset: 0x0064C3BC
	private void ClearConsume()
	{
		for (int i = 0; i < this.ConsumeList.Count; i++)
		{
			TCommonMultipleConsumeData value = this.ConsumeList[i];
			value.ItemData = new InventoryDefine.GetItemData(0, 0);
			value.Count = 0;
			this.ConsumeList[i] = value;
		}
	}

	// Token: 0x06015BCC RID: 89036 RVA: 0x0064E20F File Offset: 0x0064C40F
	private void TurnToBreachView()
	{
		UiInteractLogReport.ReportSpaceKeyInteract(EUiInteractSpaceKeyType.WeaponLevelUp);
		this.CheckAndCloseItemHintViewNew();
		EventSystem.Instance.Emit(EEventName.WeaponCanGoBreach);
	}

	// Token: 0x06015BCD RID: 89037 RVA: 0x0064E22D File Offset: 0x0064C42D
	private void CheckAndCloseItemHintViewNew()
	{
		if (!UiManager.Instance.IsViewOpen(EUiViewName.ItemHintViewNew))
		{
			return;
		}
		UiManager.Instance.CloseView(EUiViewName.ItemHintViewNew, null);
	}

	// Token: 0x06015BCE RID: 89038 RVA: 0x0064E254 File Offset: 0x0064C454
	private void TryOpenItemHintView()
	{
		if (this.ReceiveItemList.Count > 0)
		{
			ItemHintViewNewData itemHintViewNewData = new ItemHintViewNewData();
			itemHintViewNewData.CheckPriorNext = (() => this.ReceiveItemList.Count > 0);
			itemHintViewNewData.ShiftPriorItem = delegate()
			{
				TItem titem = this.ReceiveItemList[0];
				this.ReceiveItemList.RemoveAt(0);
				ItemRewardInfo itemRewardInfo = new ItemRewardInfo();
				itemRewardInfo.ItemId = new int?(titem.ItemData.ItemId);
				itemRewardInfo.ItemCount = new int?(titem.Count);
				CSharpScript.Game.Module.Inventory.ItemConfig itemConfigData = InventoryConfig.Instance.GetItemConfigData(titem.ItemData.ItemId);
				itemRewardInfo.Quality = itemConfigData.QualityId;
				return itemRewardInfo;
			};
			itemHintViewNewData.TitleTextId = "Text_ItemReturnTitle_Text";
			UiManager.Instance.OpenView(EUiViewName.ItemHintViewNew, itemHintViewNewData, null);
		}
	}

	// Token: 0x0400B74C RID: 46924
	[Nullable(2)]
	private ExpComponent ExpComponent;

	// Token: 0x0400B74D RID: 46925
	[Nullable(2)]
	private SelectableExpData CurrentExpData;

	// Token: 0x0400B74E RID: 46926
	[Nullable(2)]
	protected WeaponInstance WeaponInstance;

	// Token: 0x0400B74F RID: 46927
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private List<IWeaponAttributeParam> AttributeParamList;

	// Token: 0x0400B750 RID: 46928
	[Nullable(2)]
	private ItemGridConsumeComponent ItemGridConsumeComponent;

	// Token: 0x0400B751 RID: 46929
	[Nullable(2)]
	private List<TItem> ReceiveItemList = new List<TItem>();

	// Token: 0x0400B752 RID: 46930
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private List<ISelectedData> SelectedList;

	// Token: 0x0400B753 RID: 46931
	[Nullable(2)]
	private List<TCommonMultipleConsumeData> ConsumeList;

	// Token: 0x0400B754 RID: 46932
	private int? CurrentAutoQualityIndex;

	// Token: 0x0400B755 RID: 46933
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<AttributeItem, CSharpScript.Game.Module.Common.AttributeData> AttributeLayout;

	// Token: 0x0400B756 RID: 46934
	[Nullable(2)]
	private SkeletalObserverHandle WeaponObserver;

	// Token: 0x0400B757 RID: 46935
	[Nullable(2)]
	private SkeletalObserverHandle WeaponScabbardObserver;

	// Token: 0x020084B6 RID: 33974
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x0402ACB7 RID: 175287
		ExpItem,
		// Token: 0x0402ACB8 RID: 175288
		AttributeLayout,
		// Token: 0x0402ACB9 RID: 175289
		ConsumeItem,
		// Token: 0x0402ACBA RID: 175290
		AttributeItem,
		// Token: 0x0402ACBB RID: 175291
		WeaponNameText
	}
}
