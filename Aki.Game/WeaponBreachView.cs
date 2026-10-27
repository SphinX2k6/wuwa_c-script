using System;
using System.Collections.Generic;
using System.Linq;
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

// Token: 0x02002CF6 RID: 11510
[NullableContext(2)]
[Nullable(0)]
public class WeaponBreachView : UiTabViewBase
{
	// Token: 0x060182BC RID: 99004 RVA: 0x00625BF4 File Offset: 0x00623DF4
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

	// Token: 0x060182BD RID: 99005 RVA: 0x00625D02 File Offset: 0x00623F02
	protected override void AddEventListener()
	{
		EventSystem.Instance.Add<int, int>(EEventName.OnCommonItemCountAnyChange, new Action<int, int>(this.OnCommonItemCountAnyChange));
	}

	// Token: 0x060182BE RID: 99006 RVA: 0x00625D20 File Offset: 0x00623F20
	protected override void RemoveEventListener()
	{
		EventSystem.Instance.Remove<int, int>(EEventName.OnCommonItemCountAnyChange, new Action<int, int>(this.OnCommonItemCountAnyChange));
	}

	// Token: 0x060182BF RID: 99007 RVA: 0x00625D40 File Offset: 0x00623F40
	protected override void OnStart()
	{
		this.StarLayout = new GenericLayout<CSharpScript.Game.Module.RoleUi.StarItem, IStarItemData>(base.GetHorizontalLayout(2), new Func<CSharpScript.Game.Module.RoleUi.StarItem>(this.InitStarItem), null, false, true);
		this.CostItemGridComponent = new CostItemGridComponent(base.GetItem(4), new Action<int>(this.BreachClick), new Action(this.LevelUpLockTipClick), new EUiViewName?(EUiViewName.WeaponRootView));
		this.CostItemGridComponent.SetMaxItemActive(false);
		this.CostItemGridComponent.SetButtonItemLocalText("RoleBreakup");
		this.AttributeLayout = new GenericLayout<AttributeItem, CSharpScript.Game.Module.Common.AttributeData>(base.GetVerticalLayout(3), new Func<AttributeItem>(this.InitAttributeItem), base.GetItem(5).GetOwner() as AUIBaseActor, false, true);
	}

	// Token: 0x060182C0 RID: 99008 RVA: 0x00625DF0 File Offset: 0x00623FF0
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

	// Token: 0x060182C1 RID: 99009 RVA: 0x00625E7C File Offset: 0x0062407C
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

	// Token: 0x060182C2 RID: 99010 RVA: 0x00625EF1 File Offset: 0x006240F1
	[NullableContext(1)]
	private List<ISelectedData> GetSelectedDataList()
	{
		return this.CachedConsumeList ?? new List<ISelectedData>();
	}

	// Token: 0x060182C3 RID: 99011 RVA: 0x00625F04 File Offset: 0x00624104
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

	// Token: 0x060182C4 RID: 99012 RVA: 0x00625F7B File Offset: 0x0062417B
	protected override void OnBeforeShow()
	{
		this.WeaponIncId = (int)this.ExtraParams;
		this.UpdateView();
		this.RefreshName();
	}

	// Token: 0x060182C5 RID: 99013 RVA: 0x00625F9A File Offset: 0x0062419A
	private void OnCommonItemCountAnyChange(int i, int i1)
	{
		this.UpdateView();
	}

	// Token: 0x060182C6 RID: 99014 RVA: 0x00625FA4 File Offset: 0x006241A4
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

	// Token: 0x060182C7 RID: 99015 RVA: 0x00626284 File Offset: 0x00624484
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

	// Token: 0x060182C8 RID: 99016 RVA: 0x00626314 File Offset: 0x00624514
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
		this.StarLayout.RefreshByData(array.ToList<IStarItemData>(), null, false);
	}

	// Token: 0x060182C9 RID: 99017 RVA: 0x006263B3 File Offset: 0x006245B3
	[NullableContext(1)]
	private CSharpScript.Game.Module.RoleUi.StarItem InitStarItem()
	{
		return new CSharpScript.Game.Module.RoleUi.StarItem();
	}

	// Token: 0x060182CA RID: 99018 RVA: 0x006263BC File Offset: 0x006245BC
	private void UpdateAttribute()
	{
		WeaponInstance weaponDataByIncId = WeaponModel.Instance.GetWeaponDataByIncId(this.WeaponIncId);
		WeaponConf value = weaponDataByIncId.GetWeaponConfig().Value;
		this.AttributeParamList = WeaponModel.Instance.GetWeaponAttributeParamList(value).ToList<IWeaponAttributeParam>();
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

	// Token: 0x060182CB RID: 99019 RVA: 0x00626510 File Offset: 0x00624710
	private void RefreshName()
	{
		WeaponConf value = WeaponModel.Instance.GetWeaponDataByIncId(this.WeaponIncId).GetWeaponConfig().Value;
		string weaponName = value.WeaponName;
		FColor color = FColor.FromHex(ItemConfig.Instance.GetQualityConfig(value.QualityId).Value.DropColor);
		base.GetText(6).SetColor(color);
		base.GetText(6).ShowTextNew(weaponName);
	}

	// Token: 0x060182CC RID: 99020 RVA: 0x00626586 File Offset: 0x00624786
	[NullableContext(1)]
	private AttributeItem InitAttributeItem()
	{
		return new AttributeItem();
	}

	// Token: 0x060182CD RID: 99021 RVA: 0x0062658D File Offset: 0x0062478D
	protected override void OnBeforeDestroy()
	{
		this.CostItemGridComponent.Destroy(null);
	}

	// Token: 0x0400B3C8 RID: 46024
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	protected GenericLayout<AttributeItem, CSharpScript.Game.Module.Common.AttributeData> AttributeLayout;

	// Token: 0x0400B3C9 RID: 46025
	private CostItemGridComponent CostItemGridComponent;

	// Token: 0x0400B3CA RID: 46026
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	protected GenericLayout<CSharpScript.Game.Module.RoleUi.StarItem, IStarItemData> StarLayout;

	// Token: 0x0400B3CB RID: 46027
	private EWeaponBreachState WeaponBreachState;

	// Token: 0x0400B3CC RID: 46028
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private List<IWeaponAttributeParam> AttributeParamList;

	// Token: 0x0400B3CD RID: 46029
	private int WeaponIncId;

	// Token: 0x0400B3CE RID: 46030
	private SkeletalObserverHandle WeaponObserver;

	// Token: 0x0400B3CF RID: 46031
	private SkeletalObserverHandle WeaponScabbardObserver;

	// Token: 0x0400B3D0 RID: 46032
	private TsUiSceneRoleActor TsUiSceneRoleActor;

	// Token: 0x0400B3D1 RID: 46033
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private List<ISelectedData> CachedConsumeList;

	// Token: 0x02009289 RID: 37513
	[NullableContext(0)]
	private enum EComponents
	{
		// Token: 0x0402F61A RID: 194074
		NewLevelLimitText,
		// Token: 0x0402F61B RID: 194075
		LevelText,
		// Token: 0x0402F61C RID: 194076
		StarHorizontalLayout,
		// Token: 0x0402F61D RID: 194077
		AttributeLayout,
		// Token: 0x0402F61E RID: 194078
		ConsumeItem,
		// Token: 0x0402F61F RID: 194079
		AttributeItem,
		// Token: 0x0402F620 RID: 194080
		WeaponNameText
	}
}
