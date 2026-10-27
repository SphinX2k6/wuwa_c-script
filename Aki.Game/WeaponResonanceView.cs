using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using Aki.Protocol;
using AkiClient.Game.Aki.Character.Role.Common.Data.Enum;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using CSharpScript.Game.Module.Item;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02002CFF RID: 11519
[NullableContext(2)]
[Nullable(0)]
public class WeaponResonanceView : UiTabViewBase
{
	// Token: 0x0601834F RID: 99151 RVA: 0x00628C40 File Offset: 0x00626E40
	protected unsafe override void OnRegisterComponent()
	{
		int num = 14;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(13, typeof(UUIText));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x06018350 RID: 99152 RVA: 0x00628E3C File Offset: 0x0062703C
	protected override void OnStart()
	{
		this.WeaponIncId = (int)this.ExtraParams;
		if (this.GetCurrentResonanceConfig().MaterialPlaceType == 1)
		{
			this.AutoPlaceItem = true;
		}
		if (this.AutoPlaceItem)
		{
			this.ItemGridAlternativeConsume = new MediumItemGrid();
			this.ItemGridAlternativeConsume.Initialize(base.GetItem(5).GetOwner());
			this.RefreshAlternativeConsumeItem();
		}
		else
		{
			this.InitSingleItemSelect();
		}
		this.ConfirmButtonItem = new ButtonItem(base.GetItem(6));
		this.ConfirmButtonItem.SetFunction(new Action<int>(this.ResonanceClick));
		this.InitMoney();
	}

	// Token: 0x06018351 RID: 99153 RVA: 0x00628ED9 File Offset: 0x006270D9
	protected override void AddEventListener()
	{
		EventSystem.Instance.Add(EEventName.WeaponResonanceSuccess, new Action<int, int>(this.ResonanceSuccess));
	}

	// Token: 0x06018352 RID: 99154 RVA: 0x00628EF7 File Offset: 0x006270F7
	protected override void RemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.WeaponResonanceSuccess, new Action<int, int>(this.ResonanceSuccess));
	}

	// Token: 0x06018353 RID: 99155 RVA: 0x00628F18 File Offset: 0x00627118
	private void ResonanceSuccess(int incId, int lastLevel)
	{
		if (incId != this.WeaponIncId)
		{
			return;
		}
		this.WeaponObserver = UiSceneManager.Instance.GetWeaponObserver();
		this.WeaponScabbardObserver = UiSceneManager.Instance.GetWeaponScabbardObserver();
		WeaponController.Instance.PlayWeaponRenderingMaterial("WeaponResonanceUpMaterialController", this.WeaponObserver, this.WeaponScabbardObserver);
		UiModelBase model = this.WeaponObserver.Model;
		UiModelUtil.Instance.PlayEffectAtRootComponent(model, "WeaponResonanceUpEffect");
		if (this.AutoPlaceItem)
		{
			this.RefreshAlternativeConsumeItem();
		}
		else
		{
			this.SingleItemSelect.ClearSelectData();
		}
		this.RefreshLevel();
		WeaponResonanceSuccessViewParam param = new WeaponResonanceSuccessViewParam
		{
			WeaponIncId = incId,
			LastLevel = lastLevel
		};
		UiManager.Instance.OpenView(EUiViewName.WeaponResonanceSuccessView, param, null);
	}

	// Token: 0x06018354 RID: 99156 RVA: 0x00628FCC File Offset: 0x006271CC
	private void InitSingleItemSelect()
	{
		this.SingleItemSelect = new SingleItemSelect();
		this.SingleItemSelect.Init(base.GetItem(5), ESingleItemSelectViewType.Right);
		this.SingleItemSelect.SetUseWayId(28);
		this.SingleItemSelect.SetInitSortToggleState(true);
		this.SingleItemSelect.SetGetItemListFunction(new Func<List<ItemDataBase>>(this.GetItemList));
		this.SingleItemSelect.SetItemSelectChangeCallBack(new Action<ISelectedData>(this.OnItemSelectChange));
	}

	// Token: 0x06018355 RID: 99157 RVA: 0x0062903E File Offset: 0x0062723E
	[NullableContext(1)]
	private List<ItemDataBase> GetItemList()
	{
		return WeaponModel.Instance.GetResonanceMaterialList(this.WeaponIncId);
	}

	// Token: 0x06018356 RID: 99158 RVA: 0x00629050 File Offset: 0x00627250
	[NullableContext(1)]
	private void OnItemSelectChange(ISelectedData currentSelectItem)
	{
		this.RefreshLevel();
	}

	// Token: 0x06018357 RID: 99159 RVA: 0x00629058 File Offset: 0x00627258
	private void InitMoney()
	{
		base.SetItemIcon(base.GetTexture(7), 2, null, null);
	}

	// Token: 0x06018358 RID: 99160 RVA: 0x00629080 File Offset: 0x00627280
	private void RefreshMoney(int startLevel, int endLevel)
	{
		int num = 0;
		if (this.AutoPlaceItem || this.SingleItemSelect.GetCurrentSelectedData() != null)
		{
			WeaponConf value = WeaponModel.Instance.GetWeaponDataByIncId(this.WeaponIncId).GetWeaponConfig().Value;
			num = WeaponModel.Instance.GetResonanceNeedMoney(value.ResonId, startLevel, endLevel);
		}
		int itemCountByConfigId = InventoryModel.Instance.GetItemCountByConfigId(2, 0);
		base.GetText(8).SetText(num.ToString(), true);
		this.IsMoneyEnough = (itemCountByConfigId >= num);
		base.GetText(8).useChangeColor = !this.IsMoneyEnough;
	}

	// Token: 0x06018359 RID: 99161 RVA: 0x0062911C File Offset: 0x0062731C
	private void RefreshLevel()
	{
		WeaponInstance weaponDataByIncId = WeaponModel.Instance.GetWeaponDataByIncId(this.WeaponIncId);
		WeaponConf value = weaponDataByIncId.GetWeaponConfig().Value;
		int resonanceLevel = weaponDataByIncId.GetResonanceLevel();
		bool flag = resonanceLevel == value.ResonLevelLimit;
		base.GetItem(3).SetUIActive(!flag);
		base.GetText(1).SetUIActive(!flag);
		base.GetItem(10).SetUIActive(!flag);
		base.GetItem(4).SetUIActive(!flag);
		this.ConfirmButtonItem.GetRootItem().SetUIActive(!flag);
		base.GetItem(9).SetUIActive(flag);
		LguiUtil.Instance.SetLocalText(base.GetText(0), "WeaponResonanceLevelText", new <>z__ReadOnlySingleElementList<object>(resonanceLevel));
		string[] weaponConfigDescParams = WeaponModel.Instance.GetWeaponConfigDescParams(value, resonanceLevel);
		string[] array = null;
		if (!flag)
		{
			int arrivedLevel = this.GetArrivedLevel();
			LguiUtil.Instance.SetLocalText(base.GetText(1), "WeaponResonanceLevelText", new <>z__ReadOnlySingleElementList<object>(arrivedLevel));
			this.RefreshMoney(resonanceLevel, arrivedLevel);
			string[] weaponConfigDescParams2 = WeaponModel.Instance.GetWeaponConfigDescParams(value, arrivedLevel);
			array = new string[weaponConfigDescParams.Length];
			string stringConfig = ConfigCommonParamById.GetStringConfig("HighlightColor");
			for (int i = 0; i < weaponConfigDescParams.Length; i++)
			{
				string text = weaponConfigDescParams[i];
				string text2 = weaponConfigDescParams2[i];
				string text3;
				if (text == text2)
				{
					text3 = text.ToString();
				}
				else
				{
					text3 = StringUtils.Format("{0}-><color=#{1}>{2}</color>", new string[]
					{
						text,
						stringConfig,
						text2
					});
				}
				array[i] = text3;
			}
		}
		array = (array ?? weaponConfigDescParams);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(2), value.Desc, array);
	}

	// Token: 0x0601835A RID: 99162 RVA: 0x006292CC File Offset: 0x006274CC
	protected override void OnBeforeShow()
	{
		WeaponModel.Instance.SetCurSelectViewName(EWeaponViewName.WeaponResonanceView);
		this.RefreshSelectedList();
		this.Refresh();
	}

	// Token: 0x0601835B RID: 99163 RVA: 0x006292E8 File Offset: 0x006274E8
	private void RefreshSelectedList()
	{
		if (this.AutoPlaceItem || this.SingleItemSelect == null)
		{
			return;
		}
		ISelectedData currentSelectedData = this.SingleItemSelect.GetCurrentSelectedData();
		if (currentSelectedData == null)
		{
			return;
		}
		if (currentSelectedData.IncId > 0)
		{
			if (WeaponModel.Instance.GetWeaponDataByIncId(currentSelectedData.IncId) == null)
			{
				this.SingleItemSelect.ClearSelectData();
				return;
			}
		}
		else if (InventoryModel.Instance.GetCommonItemCount(currentSelectedData.ItemId, 0) <= 0)
		{
			this.SingleItemSelect.ClearSelectData();
		}
	}

	// Token: 0x0601835C RID: 99164 RVA: 0x0062935C File Offset: 0x0062755C
	public void Refresh()
	{
		this.RefreshName();
		this.RefreshLevel();
	}

	// Token: 0x0601835D RID: 99165 RVA: 0x0062936C File Offset: 0x0062756C
	public void RefreshName()
	{
		WeaponInstance weaponDataByIncId = WeaponModel.Instance.GetWeaponDataByIncId(this.WeaponIncId);
		WeaponConf value = weaponDataByIncId.GetWeaponConfig().Value;
		string weaponName = value.WeaponName;
		FColor color = FColor.FromHex(ItemConfig.Instance.GetQualityConfig(value.QualityId).Value.DropColor);
		base.GetText(12).SetColor(color);
		base.GetText(12).ShowTextNew(weaponName);
		int resonanceLevel = weaponDataByIncId.GetResonanceLevel();
		WeaponReson? weaponResonanceConfig = WeaponConfig.Instance.GetWeaponResonanceConfig(value.ResonId, resonanceLevel);
		if (weaponResonanceConfig != null)
		{
			base.GetText(13).SetText(WeaponConfig.Instance.GetWeaponResonanceDesc(weaponResonanceConfig.Value.Name), true);
		}
	}

	// Token: 0x0601835E RID: 99166 RVA: 0x00629434 File Offset: 0x00627634
	private int GetArrivedLevel()
	{
		WeaponInstance weaponDataByIncId = WeaponModel.Instance.GetWeaponDataByIncId(this.WeaponIncId);
		int resonanceLevel = weaponDataByIncId.GetResonanceLevel();
		ISelectedData currentSelectedConsumeData = this.GetCurrentSelectedConsumeData();
		if (this.AutoPlaceItem || currentSelectedConsumeData == null || currentSelectedConsumeData.IncId == 0)
		{
			return resonanceLevel + 1;
		}
		int num = WeaponModel.Instance.GetWeaponDataByIncId(currentSelectedConsumeData.IncId).GetResonanceLevel() + weaponDataByIncId.GetResonanceLevel();
		int resonLevelLimit = weaponDataByIncId.GetWeaponConfig().Value.ResonLevelLimit;
		if (num <= resonLevelLimit)
		{
			return num;
		}
		return resonLevelLimit;
	}

	// Token: 0x0601835F RID: 99167 RVA: 0x006294B8 File Offset: 0x006276B8
	private void ResonanceClick(int _)
	{
		ISelectedData materialData = this.GetCurrentSelectedConsumeData();
		if (materialData == null)
		{
			ScrollingTipsController.Instance.ShowTipsById("WeaponSelectMaterialTipsText", Array.Empty<object>());
			return;
		}
		if (!this.IsMoneyEnough)
		{
			ScrollingTipsController.Instance.ShowTipsById("WeaponResonanceNoEnoughMoneyText", Array.Empty<object>());
			return;
		}
		int incId2 = materialData.IncId;
		if (incId2 <= 0 && InventoryModel.Instance.GetCommonItemCount(materialData.ItemId, 0) == 0)
		{
			ScrollingTipsController.Instance.ShowTipsById("ResonanceItemNotEnough", Array.Empty<object>());
			return;
		}
		WeaponInstance weaponDataByIncId = WeaponModel.Instance.GetWeaponDataByIncId(this.WeaponIncId);
		EConfirmBoxConfigId configId = EConfirmBoxConfigId.WeaponResonanceTip;
		if (incId2 > 0)
		{
			WeaponInstance weaponDataByIncId2 = WeaponModel.Instance.GetWeaponDataByIncId(incId2);
			bool flag = WeaponModel.Instance.IsWeaponHighLevel(weaponDataByIncId2);
			bool flag2 = WeaponModel.Instance.HasWeaponResonance(weaponDataByIncId2);
			if (flag && flag2)
			{
				configId = EConfirmBoxConfigId.WeaponResonanceBoth;
			}
			else if (flag2)
			{
				configId = EConfirmBoxConfigId.WeaponResonanceHasResonance;
			}
			else if (flag)
			{
				configId = EConfirmBoxConfigId.WeaponResonanceHasStrength;
			}
		}
		WeaponConfig instance = WeaponConfig.Instance;
		string text;
		if (incId2 > 0)
		{
			text = instance.GetWeaponName(instance.GetWeaponConfigByItemId(materialData.ItemId).Value.WeaponName);
		}
		else
		{
			text = ConfigMultiTextLang.GetLocalTextNew(ItemConfig.Instance.GetConfig(materialData.ItemId).Value.Name, null);
		}
		string weaponName = instance.GetWeaponName(weaponDataByIncId.GetWeaponConfig().Value.WeaponName);
		int arrivedLevel = this.GetArrivedLevel();
		int? incId = weaponDataByIncId.GetIncId();
		ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(configId);
		Action value = delegate()
		{
			List<WeaponConsumeItem> list = new List<WeaponConsumeItem>();
			WeaponConsumeItem weaponConsumeItem = WeaponConsumeItem.Create();
			weaponConsumeItem.IncId = materialData.IncId;
			weaponConsumeItem.Count = 1;
			weaponConsumeItem.ItemId = materialData.ItemId;
			list.Add(weaponConsumeItem);
			WeaponController.Instance.SendPbResonUpRequest(incId.Value, list.ToArray());
		};
		confirmBoxDataNew.SetTextArgs(new string[]
		{
			text,
			weaponName,
			arrivedLevel.ToString()
		});
		confirmBoxDataNew.FunctionMap.Add(2, value);
		ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
	}

	// Token: 0x06018360 RID: 99168 RVA: 0x0062969C File Offset: 0x0062789C
	private ISelectedData GetCurrentSelectedConsumeData()
	{
		if (this.AutoPlaceItem)
		{
			int num = this.GetCurrentResonanceConfig().AlternativeConsume()[0];
			SelectedData selectedData = new SelectedData();
			selectedData.ItemId = num;
			selectedData.IncId = 0;
			InventoryModel instance = InventoryModel.Instance;
			selectedData.Count = ((instance != null) ? instance.GetCommonItemCount(num, 0) : 0);
			selectedData.SelectedCount = 1;
			return selectedData;
		}
		return this.SingleItemSelect.GetCurrentSelectedData();
	}

	// Token: 0x06018361 RID: 99169 RVA: 0x00629704 File Offset: 0x00627904
	private WeaponReson GetCurrentResonanceConfig()
	{
		WeaponInstance weaponDataByIncId = WeaponModel.Instance.GetWeaponDataByIncId(this.WeaponIncId);
		WeaponConf value = weaponDataByIncId.GetWeaponConfig().Value;
		return WeaponConfig.Instance.GetWeaponResonanceConfig(value.ResonId, weaponDataByIncId.GetResonanceLevel()).Value;
	}

	// Token: 0x06018362 RID: 99170 RVA: 0x00629750 File Offset: 0x00627950
	private void RefreshAlternativeConsumeItem()
	{
		int consumeId = this.GetCurrentSelectedConsumeData().ItemId;
		PropMediumItemGrid propMediumItemGrid = new PropMediumItemGrid
		{
			ItemConfigId = new int?(consumeId)
		};
		int commonItemCount = InventoryModel.Instance.GetCommonItemCount(consumeId, 0);
		propMediumItemGrid.BottomTextId = "Text_ItemEnoughText_Text";
		if (commonItemCount < 1)
		{
			propMediumItemGrid.BottomTextId = "Text_ItemNotEnoughText_Text";
		}
		propMediumItemGrid.BottomTextParameter = new object[]
		{
			commonItemCount,
			1
		};
		this.ItemGridAlternativeConsume.Apply<PropMediumItemGrid>(propMediumItemGrid);
		this.ItemGridAlternativeConsume.BindOnCanExecuteChange((object _1, bool _2, EToggleState _3) => false);
		this.ItemGridAlternativeConsume.BindOnExtendToggleClicked(delegate(MediumItemGridExtendCallback _)
		{
			ItemController.Instance.OpenItemTipsByItemId(consumeId, true, null);
		});
	}

	// Token: 0x0400B3F5 RID: 46069
	private bool IsMoneyEnough;

	// Token: 0x0400B3F6 RID: 46070
	private ButtonItem ConfirmButtonItem;

	// Token: 0x0400B3F7 RID: 46071
	private SingleItemSelect SingleItemSelect;

	// Token: 0x0400B3F8 RID: 46072
	private int WeaponIncId;

	// Token: 0x0400B3F9 RID: 46073
	private SkeletalObserverHandle WeaponObserver;

	// Token: 0x0400B3FA RID: 46074
	private SkeletalObserverHandle WeaponScabbardObserver;

	// Token: 0x0400B3FB RID: 46075
	private bool AutoPlaceItem;

	// Token: 0x0400B3FC RID: 46076
	private MediumItemGrid ItemGridAlternativeConsume;

	// Token: 0x02009296 RID: 37526
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x0402F64B RID: 194123
		ResonanceLevelText,
		// Token: 0x0402F64C RID: 194124
		NextLevelText,
		// Token: 0x0402F64D RID: 194125
		CurrentEffectText,
		// Token: 0x0402F64E RID: 194126
		ArrowItem,
		// Token: 0x0402F64F RID: 194127
		ConsumeRootItem,
		// Token: 0x0402F650 RID: 194128
		CostItem,
		// Token: 0x0402F651 RID: 194129
		ConfirmButtonItem,
		// Token: 0x0402F652 RID: 194130
		MoneyTexture,
		// Token: 0x0402F653 RID: 194131
		MoneyText,
		// Token: 0x0402F654 RID: 194132
		MaxItem,
		// Token: 0x0402F655 RID: 194133
		TipTextItem,
		// Token: 0x0402F656 RID: 194134
		ConsumeItem,
		// Token: 0x0402F657 RID: 194135
		WeaponNameText,
		// Token: 0x0402F658 RID: 194136
		SkillNameText
	}
}
