using System;
using System.Collections.Generic;
using System.Linq;
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

// Token: 0x02002CFA RID: 11514
[NullableContext(1)]
[Nullable(0)]
public class WeaponLevelUpView : UiTabViewBase
{
	// Token: 0x06018300 RID: 99072 RVA: 0x00626F40 File Offset: 0x00625140
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

	// Token: 0x06018301 RID: 99073 RVA: 0x0062700C File Offset: 0x0062520C
	protected override UniTask OnBeforeStartAsync()
	{
		WeaponLevelUpView.<OnBeforeStartAsync>d__14 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<WeaponLevelUpView.<OnBeforeStartAsync>d__14>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06018302 RID: 99074 RVA: 0x00627050 File Offset: 0x00625250
	protected override void OnStart()
	{
		int incId = (int)this.ExtraParams;
		this.WeaponInstance = WeaponModel.Instance.GetWeaponDataByIncId(incId);
		this.InitExpComponent();
		this.InitAttributeItemList();
		this.InitConsumeComponent();
	}

	// Token: 0x06018303 RID: 99075 RVA: 0x0062708C File Offset: 0x0062528C
	protected override void OnBeforeDestroy()
	{
		this.ExpComponent.Destroy(null);
		this.ItemGridConsumeComponent.Destroy(null);
		this.CheckAndCloseItemHintViewNew();
	}

	// Token: 0x06018304 RID: 99076 RVA: 0x006270AC File Offset: 0x006252AC
	protected override void OnBeforeShow()
	{
		this.RefreshSelectedList();
		this.InitExp();
		this.RefreshName();
		this.UpdateAttribute();
		this.UpdateConsumeComponent();
	}

	// Token: 0x06018305 RID: 99077 RVA: 0x006270CC File Offset: 0x006252CC
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

	// Token: 0x06018306 RID: 99078 RVA: 0x006271DC File Offset: 0x006253DC
	protected override void AddEventListener()
	{
		EventSystem.Instance.Add(EEventName.WeaponLevelUp, new Action(this.WeaponLevelUpEvent));
		EventSystem.Instance.Add<IReadOnlyList<TItem>>(EEventName.WeaponLevelUpReceiveItem, new Action<IReadOnlyList<TItem>>(this.WeaponLevelUpReceiveItem));
		EventSystem.Instance.Add<int>(EEventName.OnPlayerCurrencyChange, new Action<int>(this.OnPlayerCurrencyChange));
	}

	// Token: 0x06018307 RID: 99079 RVA: 0x00627240 File Offset: 0x00625440
	protected override void RemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.WeaponLevelUp, new Action(this.WeaponLevelUpEvent));
		EventSystem.Instance.Remove<IReadOnlyList<TItem>>(EEventName.WeaponLevelUpReceiveItem, new Action<IReadOnlyList<TItem>>(this.WeaponLevelUpReceiveItem));
		EventSystem.Instance.Remove<int>(EEventName.OnPlayerCurrencyChange, new Action<int>(this.OnPlayerCurrencyChange));
	}

	// Token: 0x06018308 RID: 99080 RVA: 0x006272A1 File Offset: 0x006254A1
	private void OnPlayerCurrencyChange(int i)
	{
		this.UpdateConsumeComponent();
	}

	// Token: 0x06018309 RID: 99081 RVA: 0x006272A9 File Offset: 0x006254A9
	protected override void OnHideUiTabViewBase(bool fromToggle)
	{
		if (fromToggle)
		{
			UiManager.Instance.CloseView(EUiViewName.CommonItemSelectViewRight, null);
		}
	}

	// Token: 0x0601830A RID: 99082 RVA: 0x006272C0 File Offset: 0x006254C0
	private void WeaponLevelUpEvent()
	{
		this.OnLevelUpSuccess();
		this.ExpComponent.PlayExpTween(this.CurrentExpData);
		this.SelectedList.Clear();
		this.ClearConsume();
		this.ItemGridConsumeComponent.UpdateComponent(2, 0, this.ConsumeList);
		this.ItemGridConsumeComponent.SetMaxState(this.WeaponInstance.IsLevelMax());
	}

	// Token: 0x0601830B RID: 99083 RVA: 0x0062731E File Offset: 0x0062551E
	private void WeaponLevelUpReceiveItem(IReadOnlyList<TItem> itemList)
	{
		this.ReceiveItemList = itemList.ToList<TItem>();
		this.ReceiveItemList.Sort(delegate(TItem a, TItem b)
		{
			CSharpScript.Game.Module.Inventory.ItemConfig itemConfigData = InventoryConfig.Instance.GetItemConfigData(a.ItemData.ItemId);
			return InventoryConfig.Instance.GetItemConfigData(b.ItemData.ItemId).QualityId - itemConfigData.QualityId;
		});
	}

	// Token: 0x0601830C RID: 99084 RVA: 0x00627358 File Offset: 0x00625558
	private void InitExpComponent()
	{
		this.ExpComponent = new ExpComponent(base.GetItem(0), false);
		this.ExpComponent.Init();
		this.ExpComponent.SetLevelFormatText("LevelNumber");
		this.ExpComponent.BindPlayCompleteCallBack(new Action<bool>(this.OnExpTweenComplete));
		this.CurrentExpData = new SelectableExpData();
		this.CurrentExpData.SetMaxExpFunction(new Func<int, int>(this.GetCurLevelExp));
	}

	// Token: 0x0601830D RID: 99085 RVA: 0x006273CC File Offset: 0x006255CC
	private void InitExp()
	{
		this.UpdateExpData();
		this.ExpComponent.UpdateInitState(this.CurrentExpData);
	}

	// Token: 0x0601830E RID: 99086 RVA: 0x006273E8 File Offset: 0x006255E8
	private void UpdateExpData()
	{
		int level = this.WeaponInstance.GetLevel();
		int currentMaxLevel = this.WeaponInstance.GetCurrentMaxLevel();
		int exp = this.WeaponInstance.GetExp();
		int maxLevel = this.WeaponInstance.GetMaxLevel();
		this.CurrentExpData.UpdateComponent(level, currentMaxLevel, exp, new int?(maxLevel), false);
	}

	// Token: 0x0601830F RID: 99087 RVA: 0x0062743A File Offset: 0x0062563A
	private int GetCurLevelExp(int level)
	{
		return this.WeaponInstance.GetLevelExp(level);
	}

	// Token: 0x06018310 RID: 99088 RVA: 0x00627448 File Offset: 0x00625648
	private int GetItemExpFunction(ISelectedData selectedData)
	{
		return WeaponModel.Instance.GetWeaponItemExp(selectedData.IncId, selectedData.ItemId);
	}

	// Token: 0x06018311 RID: 99089 RVA: 0x00627460 File Offset: 0x00625660
	private void OnExpTweenComplete(bool _)
	{
		this.InitExp();
		this.UpdateAttribute();
	}

	// Token: 0x06018312 RID: 99090 RVA: 0x00627470 File Offset: 0x00625670
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

	// Token: 0x06018313 RID: 99091 RVA: 0x0062763A File Offset: 0x0062583A
	private void InitAttributeItemList()
	{
		this.AttributeLayout = new GenericLayout<AttributeItem, CSharpScript.Game.Module.Common.AttributeData>(base.GetVerticalLayout(1), new Func<AttributeItem>(this.CreateAttributeItem), null, false, true);
	}

	// Token: 0x06018314 RID: 99092 RVA: 0x0062765D File Offset: 0x0062585D
	private AttributeItem CreateAttributeItem()
	{
		return new AttributeItem();
	}

	// Token: 0x06018315 RID: 99093 RVA: 0x00627664 File Offset: 0x00625864
	private void UpdateAttribute()
	{
		WeaponConf? weaponConfig = this.WeaponInstance.GetWeaponConfig();
		this.AttributeParamList = WeaponModel.Instance.GetWeaponAttributeParamList(weaponConfig.Value).ToList<IWeaponAttributeParam>();
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

	// Token: 0x06018316 RID: 99094 RVA: 0x006277D4 File Offset: 0x006259D4
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

	// Token: 0x06018317 RID: 99095 RVA: 0x006278C0 File Offset: 0x00625AC0
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

	// Token: 0x06018318 RID: 99096 RVA: 0x00627956 File Offset: 0x00625B56
	private void UpdateConsumeComponent()
	{
		this.RefreshItemAndExp();
		this.ItemGridConsumeComponent.SetMaxState(this.WeaponInstance.IsLevelMax());
	}

	// Token: 0x06018319 RID: 99097 RVA: 0x00627974 File Offset: 0x00625B74
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

	// Token: 0x0601831A RID: 99098 RVA: 0x00627AA8 File Offset: 0x00625CA8
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

	// Token: 0x0601831B RID: 99099 RVA: 0x00627BA8 File Offset: 0x00625DA8
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

	// Token: 0x0601831C RID: 99100 RVA: 0x00627BDC File Offset: 0x00625DDC
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

	// Token: 0x0601831D RID: 99101 RVA: 0x00627C42 File Offset: 0x00625E42
	private ConfirmBoxDataNew CreateLevelUpTipsWithOverflow(Dictionary<int, int> overItemMap)
	{
		return new ConfirmBoxDataNew(EConfirmBoxConfigId.WeaponOverflowExpTip)
		{
			ItemIdMap = overItemMap
		};
	}

	// Token: 0x0601831E RID: 99102 RVA: 0x00627C54 File Offset: 0x00625E54
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

	// Token: 0x0601831F RID: 99103 RVA: 0x00627CD0 File Offset: 0x00625ED0
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

	// Token: 0x06018320 RID: 99104 RVA: 0x00627DCF File Offset: 0x00625FCF
	private void OnChangeSelectedFunction(List<ISelectedData> currentSelectedData, SelectableExpData expData)
	{
		this.SelectedList = currentSelectedData;
		this.CurrentExpData = expData;
		this.RefreshItemAndExp();
	}

	// Token: 0x06018321 RID: 99105 RVA: 0x00627DE5 File Offset: 0x00625FE5
	private void ItemClickFunction()
	{
		this.MaterialItemFunction(new int?(0), new int?(0));
	}

	// Token: 0x06018322 RID: 99106 RVA: 0x00627DF9 File Offset: 0x00625FF9
	private void OnClickDeleteSelectFunction()
	{
		this.SelectedList = new List<ISelectedData>();
		this.RefreshItemAndExp();
	}

	// Token: 0x06018323 RID: 99107 RVA: 0x00627E0C File Offset: 0x0062600C
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

	// Token: 0x06018324 RID: 99108 RVA: 0x00627F58 File Offset: 0x00626158
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

	// Token: 0x06018325 RID: 99109 RVA: 0x0062800F File Offset: 0x0062620F
	private void ConditionFunction(int index)
	{
		this.CurrentAutoQualityIndex = new int?(index);
		this.RefreshConditionText();
	}

	// Token: 0x06018326 RID: 99110 RVA: 0x00628024 File Offset: 0x00626224
	private void RefreshConditionText()
	{
		int qualityIdByIndex = this.GetQualityIdByIndex(this.CurrentAutoQualityIndex.Value);
		this.ItemGridConsumeComponent.RefreshConditionText(CommonConfig.Instance.GetItemQualityById(qualityIdByIndex).Value.ConsumeFilterText);
	}

	// Token: 0x06018327 RID: 99111 RVA: 0x0062806C File Offset: 0x0062626C
	private int GetQualityIdByIndex(int index)
	{
		List<QualityInfo> itemQualityList = CommonConfig.Instance.GetItemQualityList();
		int index2 = MathUtils.Instance.Clamp(index, 0, itemQualityList.Count - 1);
		return itemQualityList[index2].Id;
	}

	// Token: 0x06018328 RID: 99112 RVA: 0x006280A8 File Offset: 0x006262A8
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

	// Token: 0x06018329 RID: 99113 RVA: 0x00628188 File Offset: 0x00626388
	private void RefreshName()
	{
		WeaponConf value = this.WeaponInstance.GetWeaponConfig().Value;
		string weaponName = value.WeaponName;
		FColor color = FColor.FromHex(CSharpScript.Game.Module.Item.ItemConfig.Instance.GetQualityConfig(value.QualityId).Value.DropColor);
		base.GetText(4).SetColor(color);
		base.GetText(4).ShowTextNew(weaponName);
	}

	// Token: 0x0601832A RID: 99114 RVA: 0x006281F4 File Offset: 0x006263F4
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

	// Token: 0x0601832B RID: 99115 RVA: 0x00628247 File Offset: 0x00626447
	private void TurnToBreachView()
	{
		UiInteractLogReport.ReportSpaceKeyInteract(EUiInteractSpaceKeyType.WeaponLevelUp);
		this.CheckAndCloseItemHintViewNew();
		EventSystem.Instance.Emit(EEventName.WeaponCanGoBreach);
	}

	// Token: 0x0601832C RID: 99116 RVA: 0x00628265 File Offset: 0x00626465
	private void CheckAndCloseItemHintViewNew()
	{
		if (!UiManager.Instance.IsViewOpen(EUiViewName.ItemHintViewNew))
		{
			return;
		}
		UiManager.Instance.CloseView(EUiViewName.ItemHintViewNew, null);
	}

	// Token: 0x0601832D RID: 99117 RVA: 0x0062828C File Offset: 0x0062648C
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

	// Token: 0x0400B3D7 RID: 46039
	[Nullable(2)]
	private ExpComponent ExpComponent;

	// Token: 0x0400B3D8 RID: 46040
	[Nullable(2)]
	private SelectableExpData CurrentExpData;

	// Token: 0x0400B3D9 RID: 46041
	[Nullable(2)]
	protected WeaponInstance WeaponInstance;

	// Token: 0x0400B3DA RID: 46042
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private List<IWeaponAttributeParam> AttributeParamList;

	// Token: 0x0400B3DB RID: 46043
	[Nullable(2)]
	private ItemGridConsumeComponent ItemGridConsumeComponent;

	// Token: 0x0400B3DC RID: 46044
	[Nullable(2)]
	private List<TItem> ReceiveItemList = new List<TItem>();

	// Token: 0x0400B3DD RID: 46045
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private List<ISelectedData> SelectedList;

	// Token: 0x0400B3DE RID: 46046
	[Nullable(2)]
	private List<TCommonMultipleConsumeData> ConsumeList;

	// Token: 0x0400B3DF RID: 46047
	private int? CurrentAutoQualityIndex;

	// Token: 0x0400B3E0 RID: 46048
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<AttributeItem, CSharpScript.Game.Module.Common.AttributeData> AttributeLayout;

	// Token: 0x0400B3E1 RID: 46049
	[Nullable(2)]
	private SkeletalObserverHandle WeaponObserver;

	// Token: 0x0400B3E2 RID: 46050
	[Nullable(2)]
	private SkeletalObserverHandle WeaponScabbardObserver;

	// Token: 0x0200928E RID: 37518
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x0402F62D RID: 194093
		ExpItem,
		// Token: 0x0402F62E RID: 194094
		AttributeLayout,
		// Token: 0x0402F62F RID: 194095
		ConsumeItem,
		// Token: 0x0402F630 RID: 194096
		AttributeItem,
		// Token: 0x0402F631 RID: 194097
		WeaponNameText
	}
}
