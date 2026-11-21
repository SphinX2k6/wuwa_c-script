using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Common;
using CSharpScript.Game.Module.Item;
using CSharpScript.Game.Module.Manufacture.Compose.QuicklyPopup;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02002250 RID: 8784
[NullableContext(2)]
[Nullable(0)]
public class WeaponBreachView : UiTabViewBase
{
	// Token: 0x06015B5D RID: 88925 RVA: 0x0064BBC0 File Offset: 0x00649DC0
	protected unsafe override void OnRegisterComponent()
	{
		int num = 7;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIHorizontalLayout));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIVerticalLayout));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIText));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x06015B5E RID: 88926 RVA: 0x0064BCCE File Offset: 0x00649ECE
	protected override void AddEventListener()
	{
		EventSystem.Instance.Add<int, int>(EEventName.OnCommonItemCountAnyChange, new Action<int, int>(this.OnCommonItemCountAnyChange));
	}

	// Token: 0x06015B5F RID: 88927 RVA: 0x0064BCEC File Offset: 0x00649EEC
	protected override void RemoveEventListener()
	{
		EventSystem.Instance.Remove<int, int>(EEventName.OnCommonItemCountAnyChange, new Action<int, int>(this.OnCommonItemCountAnyChange));
	}

	// Token: 0x06015B60 RID: 88928 RVA: 0x0064BD0C File Offset: 0x00649F0C
	protected override void OnStart()
	{
		this.StarLayout = new GenericLayout<CSharpScript.Game.Module.RoleUi.StarItem, IStarItemData>(base.GetHorizontalLayout(2), new Func<CSharpScript.Game.Module.RoleUi.StarItem>(this.InitStarItem), null, false, true);
		this.CostItemGridComponent = new CostItemGridComponent(base.GetItem(4), new Action<int>(this.BreachClick), new Action(this.LevelUpLockTipClick), new EUiViewName?(EUiViewName.WeaponRootView));
		this.CostItemGridComponent.SetMaxItemActive(false);
		this.CostItemGridComponent.SetButtonItemLocalText("RoleBreakup");
		this.AttributeLayout = new GenericLayout<AttributeItem, CSharpScript.Game.Module.Common.AttributeData>(base.GetVerticalLayout(3), new Func<AttributeItem>(this.InitAttributeItem), base.GetItem(5).GetOwner() as AUIBaseActor, false, true);
	}

	// Token: 0x06015B61 RID: 88929 RVA: 0x0064BDBC File Offset: 0x00649FBC
	private void BreachClick(int _)
	{
		if (this.WeaponBreachState == EWeaponBreachState.NoEnoughMaterial || this.WeaponBreachState == EWeaponBreachState.NoEnoughMoney)
		{
			List<ISelectedData> selectedDataList = this.GetSelectedDataList();
			ComposePopupViewData param = new ComposePopupViewData
			{
				SelectedItemList = selectedDataList,
				ClickConfirm = new Action(this.BreachRequest),
				BelongView = new EUiViewName?(EUiViewName.WeaponRootView)
			};
			UiManager.Instance.OpenView(EUiViewName.SynthesisTipsInfoView, param, delegate(bool isSuccess, int viewId)
			{
				if (isSuccess)
				{
					UiViewBase viewByName = UiManager.Instance.GetViewByName(EUiViewName.WeaponRootView);
					if (viewByName == null)
					{
						return;
					}
					viewByName.AddChildViewById(viewId);
				}
			});
			return;
		}
		this.BreachRequest();
	}

	// Token: 0x06015B62 RID: 88930 RVA: 0x0064BE48 File Offset: 0x0064A048
	private void BreachRequest()
	{
		this.WeaponObserver = UiSceneManager.Instance.GetWeaponObserver();
		this.WeaponScabbardObserver = UiSceneManager.Instance.GetWeaponScabbardObserver();
		this.TsUiSceneRoleActor = UiSceneManager.Instance.GetRoleSystemRoleActor();
		WeaponInstance weaponDataByIncId = WeaponModel.Instance.GetWeaponDataByIncId(this.WeaponIncId);
		if (weaponDataByIncId != null)
		{
			weaponDataByIncId.GetRoleId();
		}
		WeaponController.Instance.SendPbWeaponBreachRequest(this.WeaponIncId, delegate(int weaponBreach)
		{
			UiModelBase model = this.WeaponObserver.Model;
			UiModelUtil.Instance.PlayEffectAtRootComponent(model, "WeaponBreachEffect");
			WeaponController.Instance.PlayWeaponRenderingMaterial("WeaponBreachMaterialController", this.WeaponObserver, this.WeaponScabbardObserver);
			int? weaponBreachDaDelayTime = RoleConfig.Instance.GetWeaponBreachDaDelayTime();
			TimerSystem.GameplayTimeInstance.Delay(delegate(float _)
			{
				foreach (SkeletalObserverHandle skeletalObserverHandle in new SkeletalObserverHandle[]
				{
					this.WeaponObserver,
					this.WeaponScabbardObserver
				})
				{
					if (((skeletalObserverHandle != null) ? skeletalObserverHandle.Model : null) != null)
					{
						UiModelUtil.Instance.SetWeaponLevelMaterialBreachLevel(skeletalObserverHandle.Model, weaponBreach);
						UiModelUtil.Instance.TryApplyWeaponLevelMaterial(skeletalObserverHandle.Model);
					}
				}
				TsUiSceneRoleActor tsUiSceneRoleActor = this.TsUiSceneRoleActor;
				if (tsUiSceneRoleActor == null)
				{
					return;
				}
				UiModelBase model2 = tsUiSceneRoleActor.Model;
				if (model2 == null)
				{
					return;
				}
				UiRoleWeaponComponent uiRoleWeaponComponent = model2.CheckGetComponent<UiRoleWeaponComponent>();
				if (uiRoleWeaponComponent == null)
				{
					return;
				}
				uiRoleWeaponComponent.RefreshWeaponDa();
			}, (float)weaponBreachDaDelayTime.Value, null, null, true, 1f);
		});
	}

	// Token: 0x06015B63 RID: 88931 RVA: 0x0064BEBD File Offset: 0x0064A0BD
	[NullableContext(1)]
	private List<ISelectedData> GetSelectedDataList()
	{
		return this.CachedConsumeList ?? new List<ISelectedData>();
	}

	// Token: 0x06015B64 RID: 88932 RVA: 0x0064BED0 File Offset: 0x0064A0D0
	protected void LevelUpLockTipClick()
	{
		ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.RoleBreakUpTip);
		int curQuestId = QuestNewModel.Instance.GetCurWorldLevelBreakQuest();
		if (curQuestId < 0)
		{
			confirmBoxDataNew.InteractionMap.Add(1, false);
		}
		else
		{
			confirmBoxDataNew.FunctionMap.Add(2, delegate
			{
				UiManager.Instance.OpenView(EUiViewName.QuestView, curQuestId, null);
			});
			confirmBoxDataNew.InteractionMap.Add(1, true);
		}
		ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
	}

	// Token: 0x06015B65 RID: 88933 RVA: 0x0064BF47 File Offset: 0x0064A147
	protected override void OnBeforeShow()
	{
		this.WeaponIncId = (int)this.ExtraParams;
		this.UpdateView();
		this.RefreshName();
	}

	// Token: 0x06015B66 RID: 88934 RVA: 0x0064BF66 File Offset: 0x0064A166
	private void OnCommonItemCountAnyChange(int i, int i1)
	{
		this.UpdateView();
	}

	// Token: 0x06015B67 RID: 88935 RVA: 0x0064BF70 File Offset: 0x0064A170
	private void UpdateView()
	{
		WeaponInstance weaponDataByIncId = WeaponModel.Instance.GetWeaponDataByIncId(this.WeaponIncId);
		WeaponBreach? breachConfig = weaponDataByIncId.GetBreachConfig();
		WeaponConf value = weaponDataByIncId.GetWeaponConfig().Value;
		WeaponBreach? weaponBreach = WeaponConfig.Instance.GetWeaponBreach(value.BreachId, weaponDataByIncId.GetBreachLevel() + 1);
		UUIText text = base.GetText(0);
		int levelLimit = weaponBreach.Value.LevelLimit;
		text.SetText(levelLimit.ToString(), true);
		int breachId = value.BreachId;
		int weaponBreachMaxLevel = WeaponModel.Instance.GetWeaponBreachMaxLevel(breachId);
		this.UpdateStar(weaponDataByIncId.GetBreachLevel(), weaponBreachMaxLevel);
		this.WeaponBreachState = WeaponModel.Instance.GetWeaponBreachState(this.WeaponIncId);
		if (this.WeaponBreachState == EWeaponBreachState.NoEnoughCondition)
		{
			string conditionGroupHintText = LevelGeneralCommons.GetConditionGroupHintText(breachConfig.Value.ConditionId);
			this.CostItemGridComponent.SetButtonItemActive(false);
			this.CostItemGridComponent.SetLockItemActive(true);
			this.CostItemGridComponent.SetLockLocalText(conditionGroupHintText ?? "", Array.Empty<object>());
		}
		else
		{
			this.CostItemGridComponent.SetButtonItemActive(true);
			this.CostItemGridComponent.SetLockItemActive(false);
		}
		List<ISelectedData> list = new List<ISelectedData>();
		Dictionary<int, int> dictionary = breachConfig.Value.Consume();
		if (dictionary != null)
		{
			foreach (KeyValuePair<int, int> keyValuePair in dictionary)
			{
				int num;
				keyValuePair.Deconstruct(out levelLimit, out num);
				int num2 = levelLimit;
				int count = num;
				SelectedData item = new SelectedData
				{
					ItemId = num2,
					IncId = 0,
					SelectedCount = InventoryModel.Instance.GetItemCountByConfigId(num2, 0),
					Count = count
				};
				list.Add(item);
			}
		}
		int goldConsume = breachConfig.Value.GoldConsume;
		this.CachedConsumeList = new List<ISelectedData>();
		foreach (ISelectedData selectedData in list)
		{
			this.CachedConsumeList.Add(new SelectedData
			{
				ItemId = selectedData.ItemId,
				IncId = selectedData.IncId,
				SelectedCount = selectedData.SelectedCount,
				Count = selectedData.Count
			});
		}
		if (goldConsume > 0)
		{
			this.CachedConsumeList.Add(new SelectedData
			{
				ItemId = 2,
				IncId = 0,
				Count = goldConsume,
				SelectedCount = InventoryModel.Instance.GetItemCountByConfigId(2, 0)
			});
		}
		this.CostItemGridComponent.Update(list, 2, goldConsume);
		LguiUtil.Instance.SetLocalText(base.GetText(1), "RoleBreakUpLevel", new <>z__ReadOnlySingleElementList<object>(weaponDataByIncId.GetBreachLevel() + 1));
		this.UpdateAttribute();
		this.RefreshCostItemButton();
	}

	// Token: 0x06015B68 RID: 88936 RVA: 0x0064C250 File Offset: 0x0064A450
	private void RefreshCostItemButton()
	{
		if (this.WeaponBreachState != EWeaponBreachState.CanBreach)
		{
			if (this.WeaponBreachState == EWeaponBreachState.NoEnoughMaterial || this.WeaponBreachState == EWeaponBreachState.NoEnoughMoney)
			{
				bool flag = ComposePopupModel.Instance.CheckOpenResult(this.GetSelectedDataList());
				if (flag)
				{
					this.CostItemGridComponent.SetButtonItemLocalTextNew("AutoSynthesis_MaterialReplenishBtn_Text");
				}
				else
				{
					this.CostItemGridComponent.SetButtonItemLocalTextNew("AutoSynthesis_MaterialMissingBtn_Text");
				}
				CostItemGridComponent costItemGridComponent = this.CostItemGridComponent;
				if (costItemGridComponent == null)
				{
					return;
				}
				costItemGridComponent.SetButtonItemInteractive(flag);
			}
			return;
		}
		this.CostItemGridComponent.SetButtonItemLocalText("RoleBreakup");
		CostItemGridComponent costItemGridComponent2 = this.CostItemGridComponent;
		if (costItemGridComponent2 == null)
		{
			return;
		}
		costItemGridComponent2.SetButtonItemInteractive(true);
	}

	// Token: 0x06015B69 RID: 88937 RVA: 0x0064C2E0 File Offset: 0x0064A4E0
	private void UpdateStar(int breachLevel, int maxLevel)
	{
		if (this.StarLayout == null)
		{
			this.StarLayout = new GenericLayout<CSharpScript.Game.Module.RoleUi.StarItem, IStarItemData>(base.GetHorizontalLayout(2), new Func<CSharpScript.Game.Module.RoleUi.StarItem>(this.InitStarItem), null, false, true);
		}
		IStarItemData[] array = new IStarItemData[maxLevel];
		for (int i = 0; i < maxLevel; i++)
		{
			StarItemData starItemData = new StarItemData
			{
				StarOnActive = (i < breachLevel),
				StarOffActive = (i > breachLevel),
				StarNextActive = (i == breachLevel),
				StarLoopActive = (i == breachLevel),
				PlayLoopSequence = (i == breachLevel),
				PlayActivateSequence = false
			};
			array[i] = starItemData;
		}
		this.StarLayout.RefreshByData(array, null, false);
	}

	// Token: 0x06015B6A RID: 88938 RVA: 0x0064C37A File Offset: 0x0064A57A
	[NullableContext(1)]
	private CSharpScript.Game.Module.RoleUi.StarItem InitStarItem()
	{
		return new CSharpScript.Game.Module.RoleUi.StarItem();
	}

	// Token: 0x06015B6B RID: 88939 RVA: 0x0064C384 File Offset: 0x0064A584
	private void UpdateAttribute()
	{
		WeaponInstance weaponDataByIncId = WeaponModel.Instance.GetWeaponDataByIncId(this.WeaponIncId);
		WeaponConf value = weaponDataByIncId.GetWeaponConfig().Value;
		this.AttributeParamList = new List<IWeaponAttributeParam>(WeaponModel.Instance.GetWeaponAttributeParamList(value));
		int breachLevel = weaponDataByIncId.GetBreachLevel();
		int num = breachLevel + 1;
		int level = weaponDataByIncId.GetLevel();
		List<CSharpScript.Game.Module.Common.AttributeData> list = new List<CSharpScript.Game.Module.Common.AttributeData>();
		foreach (IWeaponAttributeParam weaponAttributeParam in this.AttributeParamList)
		{
			int curveId = weaponAttributeParam.CurveId;
			ConfigPropValue propId = weaponAttributeParam.PropId;
			float value2 = propId.Value;
			float curveValue = WeaponModel.Instance.GetCurveValue(curveId, value2, level, breachLevel);
			float num2 = 0f;
			if (num > breachLevel)
			{
				num2 = WeaponModel.Instance.GetCurveValue(curveId, value2, level, num);
			}
			CSharpScript.Game.Module.Common.AttributeData item = new CSharpScript.Game.Module.Common.AttributeData
			{
				Id = propId.Id,
				IsRatio = propId.IsRatio,
				CurValue = curveValue,
				BgActive = new bool?(true),
				ShowNext = new bool?(num2 > curveValue),
				NextValue = new float?(num2)
			};
			list.Add(item);
		}
		this.AttributeLayout.RefreshByData(list, null, false);
	}

	// Token: 0x06015B6C RID: 88940 RVA: 0x0064C4D8 File Offset: 0x0064A6D8
	private void RefreshName()
	{
		WeaponConf value = WeaponModel.Instance.GetWeaponDataByIncId(this.WeaponIncId).GetWeaponConfig().Value;
		string weaponName = value.WeaponName;
		FColor color = FColor.FromHex(ItemConfig.Instance.GetQualityConfig(value.QualityId).Value.DropColor);
		base.GetText(6).SetColor(color);
		base.GetText(6).ShowTextNew(weaponName);
	}

	// Token: 0x06015B6D RID: 88941 RVA: 0x0064C54E File Offset: 0x0064A74E
	[NullableContext(1)]
	private AttributeItem InitAttributeItem()
	{
		return new AttributeItem();
	}

	// Token: 0x06015B6E RID: 88942 RVA: 0x0064C555 File Offset: 0x0064A755
	protected override void OnBeforeDestroy()
	{
		this.CostItemGridComponent.Destroy(null);
	}

	// Token: 0x0400B73D RID: 46909
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	protected GenericLayout<AttributeItem, CSharpScript.Game.Module.Common.AttributeData> AttributeLayout;

	// Token: 0x0400B73E RID: 46910
	private CostItemGridComponent CostItemGridComponent;

	// Token: 0x0400B73F RID: 46911
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	protected GenericLayout<CSharpScript.Game.Module.RoleUi.StarItem, IStarItemData> StarLayout;

	// Token: 0x0400B740 RID: 46912
	private EWeaponBreachState WeaponBreachState;

	// Token: 0x0400B741 RID: 46913
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private List<IWeaponAttributeParam> AttributeParamList;

	// Token: 0x0400B742 RID: 46914
	private int WeaponIncId;

	// Token: 0x0400B743 RID: 46915
	private SkeletalObserverHandle WeaponObserver;

	// Token: 0x0400B744 RID: 46916
	private SkeletalObserverHandle WeaponScabbardObserver;

	// Token: 0x0400B745 RID: 46917
	private TsUiSceneRoleActor TsUiSceneRoleActor;

	// Token: 0x0400B746 RID: 46918
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private List<ISelectedData> CachedConsumeList;

	// Token: 0x020084B1 RID: 33969
	[NullableContext(0)]
	private enum EComponents
	{
		// Token: 0x0402ACA4 RID: 175268
		NewLevelLimitText,
		// Token: 0x0402ACA5 RID: 175269
		LevelText,
		// Token: 0x0402ACA6 RID: 175270
		StarHorizontalLayout,
		// Token: 0x0402ACA7 RID: 175271
		AttributeLayout,
		// Token: 0x0402ACA8 RID: 175272
		ConsumeItem,
		// Token: 0x0402ACA9 RID: 175273
		AttributeItem,
		// Token: 0x0402ACAA RID: 175274
		WeaponNameText
	}
}
