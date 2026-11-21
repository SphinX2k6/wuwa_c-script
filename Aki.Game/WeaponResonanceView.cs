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

// Token: 0x02002259 RID: 8793
[NullableContext(2)]
[Nullable(0)]
public class WeaponResonanceView : UiTabViewBase
{
	// Token: 0x06015BF0 RID: 89072 RVA: 0x0064EC08 File Offset: 0x0064CE08
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

	// Token: 0x06015BF1 RID: 89073 RVA: 0x0064EE04 File Offset: 0x0064D004
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

	// Token: 0x06015BF2 RID: 89074 RVA: 0x0064EEA1 File Offset: 0x0064D0A1
	protected override void AddEventListener()
	{
		EventSystem.Instance.Add(EEventName.WeaponResonanceSuccess, new Action<int, int>(this.ResonanceSuccess));
	}

	// Token: 0x06015BF3 RID: 89075 RVA: 0x0064EEBF File Offset: 0x0064D0BF
	protected override void RemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.WeaponResonanceSuccess, new Action<int, int>(this.ResonanceSuccess));
	}

	// Token: 0x06015BF4 RID: 89076 RVA: 0x0064EEE0 File Offset: 0x0064D0E0
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

	// Token: 0x06015BF5 RID: 89077 RVA: 0x0064EF94 File Offset: 0x0064D194
	private void InitSingleItemSelect()
	{
		this.SingleItemSelect = new SingleItemSelect();
		this.SingleItemSelect.Init(base.GetItem(5), ESingleItemSelectViewType.Right);
		this.SingleItemSelect.SetUseWayId(28);
		this.SingleItemSelect.SetInitSortToggleState(true);
		this.SingleItemSelect.SetGetItemListFunction(new Func<List<ItemDataBase>>(this.GetItemList));
		this.SingleItemSelect.SetItemSelectChangeCallBack(new Action<ISelectedData>(this.OnItemSelectChange));
	}

	// Token: 0x06015BF6 RID: 89078 RVA: 0x0064F006 File Offset: 0x0064D206
	[NullableContext(1)]
	private List<ItemDataBase> GetItemList()
	{
		return WeaponModel.Instance.GetResonanceMaterialList(this.WeaponIncId);
	}

	// Token: 0x06015BF7 RID: 89079 RVA: 0x0064F018 File Offset: 0x0064D218
	[NullableContext(1)]
	private void OnItemSelectChange(ISelectedData currentSelectItem)
	{
		this.RefreshLevel();
	}

	// Token: 0x06015BF8 RID: 89080 RVA: 0x0064F020 File Offset: 0x0064D220
	private void InitMoney()
	{
		base.SetItemIcon(base.GetTexture(7), 2, null, null);
	}

	// Token: 0x06015BF9 RID: 89081 RVA: 0x0064F048 File Offset: 0x0064D248
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

	// Token: 0x06015BFA RID: 89082 RVA: 0x0064F0E4 File Offset: 0x0064D2E4
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

	// Token: 0x06015BFB RID: 89083 RVA: 0x0064F294 File Offset: 0x0064D494
	protected override void OnBeforeShow()
	{
		WeaponModel.Instance.SetCurSelectViewName(EWeaponViewName.WeaponResonanceView);
		this.RefreshSelectedList();
		this.Refresh();
	}

	// Token: 0x06015BFC RID: 89084 RVA: 0x0064F2B0 File Offset: 0x0064D4B0
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

	// Token: 0x06015BFD RID: 89085 RVA: 0x0064F324 File Offset: 0x0064D524
	public void Refresh()
	{
		this.RefreshName();
		this.RefreshLevel();
	}

	// Token: 0x06015BFE RID: 89086 RVA: 0x0064F334 File Offset: 0x0064D534
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

	// Token: 0x06015BFF RID: 89087 RVA: 0x0064F3FC File Offset: 0x0064D5FC
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

	// Token: 0x06015C00 RID: 89088 RVA: 0x0064F480 File Offset: 0x0064D680
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

	// Token: 0x06015C01 RID: 89089 RVA: 0x0064F664 File Offset: 0x0064D864
	private ISelectedData GetCurrentSelectedConsumeData()
	{
		if (!this.AutoPlaceItem)
		{
			return this.SingleItemSelect.GetCurrentSelectedData();
		}
		int[] array = this.GetCurrentResonanceConfig().AlternativeConsume();
		if (array.Length == 0)
		{
			return null;
		}
		int num = array[0];
		SelectedData selectedData = new SelectedData();
		selectedData.ItemId = num;
		selectedData.IncId = 0;
		InventoryModel instance = InventoryModel.Instance;
		selectedData.Count = ((instance != null) ? instance.GetCommonItemCount(num, 0) : 0);
		selectedData.SelectedCount = 1;
		return selectedData;
	}

	// Token: 0x06015C02 RID: 89090 RVA: 0x0064F6D4 File Offset: 0x0064D8D4
	private WeaponReson GetCurrentResonanceConfig()
	{
		WeaponInstance weaponDataByIncId = WeaponModel.Instance.GetWeaponDataByIncId(this.WeaponIncId);
		WeaponConf value = weaponDataByIncId.GetWeaponConfig().Value;
		return WeaponConfig.Instance.GetWeaponResonanceConfig(value.ResonId, weaponDataByIncId.GetResonanceLevel()).Value;
	}

	// Token: 0x06015C03 RID: 89091 RVA: 0x0064F720 File Offset: 0x0064D920
	private void RefreshAlternativeConsumeItem()
	{
		ISelectedData currentSelectedConsumeData = this.GetCurrentSelectedConsumeData();
		if (currentSelectedConsumeData == null)
		{
			return;
		}
		int consumeId = currentSelectedConsumeData.ItemId;
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
			ItemController.Instance.OpenItemTipsByItemId(consumeId, true, null, false);
		});
	}

	// Token: 0x0400B76A RID: 46954
	private bool IsMoneyEnough;

	// Token: 0x0400B76B RID: 46955
	private ButtonItem ConfirmButtonItem;

	// Token: 0x0400B76C RID: 46956
	private SingleItemSelect SingleItemSelect;

	// Token: 0x0400B76D RID: 46957
	private int WeaponIncId;

	// Token: 0x0400B76E RID: 46958
	private SkeletalObserverHandle WeaponObserver;

	// Token: 0x0400B76F RID: 46959
	private SkeletalObserverHandle WeaponScabbardObserver;

	// Token: 0x0400B770 RID: 46960
	private bool AutoPlaceItem;

	// Token: 0x0400B771 RID: 46961
	private MediumItemGrid ItemGridAlternativeConsume;

	// Token: 0x020084BE RID: 33982
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x0402ACD5 RID: 175317
		ResonanceLevelText,
		// Token: 0x0402ACD6 RID: 175318
		NextLevelText,
		// Token: 0x0402ACD7 RID: 175319
		CurrentEffectText,
		// Token: 0x0402ACD8 RID: 175320
		ArrowItem,
		// Token: 0x0402ACD9 RID: 175321
		ConsumeRootItem,
		// Token: 0x0402ACDA RID: 175322
		CostItem,
		// Token: 0x0402ACDB RID: 175323
		ConfirmButtonItem,
		// Token: 0x0402ACDC RID: 175324
		MoneyTexture,
		// Token: 0x0402ACDD RID: 175325
		MoneyText,
		// Token: 0x0402ACDE RID: 175326
		MaxItem,
		// Token: 0x0402ACDF RID: 175327
		TipTextItem,
		// Token: 0x0402ACE0 RID: 175328
		ConsumeItem,
		// Token: 0x0402ACE1 RID: 175329
		WeaponNameText,
		// Token: 0x0402ACE2 RID: 175330
		SkillNameText
	}
}
