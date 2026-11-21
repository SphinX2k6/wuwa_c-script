using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.GenericPrompt;
using CSharpScript.Game.Module.Item;
using CSharpScript.Game.Module.Manufacture.Common;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Module.Util.Layout;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Cook.View
{
	// Token: 0x02004B09 RID: 19209
	[NullableContext(1)]
	[Nullable(0)]
	public class CookTipsView : UiPanelBase
	{
		// Token: 0x060300C3 RID: 196803 RVA: 0x00D675B9 File Offset: 0x00D657B9
		public CookTipsView(UUIItem uiItem)
		{
			base.CreateThenShowByActor(uiItem.GetOwner(), null);
		}

		// Token: 0x060300C4 RID: 196804 RVA: 0x00D675D0 File Offset: 0x00D657D0
		protected unsafe override void OnRegisterComponent()
		{
			int num = 17;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(14, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(15, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(16, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(17, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(18, typeof(UUIHorizontalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(19, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(20, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(21, typeof(UUIVerticalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(22, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(23, typeof(UUIButtonComponent));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(23, new Action(delegate()
			{
				this.OnDisableCook();
			}));
			this.BtnBindInfo = list2;
		}

		// Token: 0x060300C5 RID: 196805 RVA: 0x00D67872 File Offset: 0x00D65A72
		protected override void OnBeforeDestroy()
		{
			this.MaterialHorizontal.ClearChildren();
			this.MaterialHorizontal = null;
			this.MachiningVertical.ClearChildren();
			this.MachiningVertical = null;
		}

		// Token: 0x060300C6 RID: 196806 RVA: 0x00D67898 File Offset: 0x00D65A98
		protected override void OnStart()
		{
			this.ConfirmButtonCompose = new ConfirmButtonCompose(base.GetItem(8));
			this.ConfirmButtonCompose.BindClickFunction(new Action(this.OnClickConfirmButton));
			this.MaterialHorizontal = new GenericLayoutNew<MaterialItem>(base.GetHorizontalLayout(18), new CSharpScript.Game.Module.Util.Layout.TLayoutRefresh<MaterialItem>(this.InitMaterial), null);
			this.MachiningVertical = new GenericLayoutNew<MachiningClueItem>(base.GetVerticalLayout(21), new CSharpScript.Game.Module.Util.Layout.TLayoutRefresh<MachiningClueItem>(this.InitMachining), null);
		}

		// Token: 0x060300C7 RID: 196807 RVA: 0x00D67910 File Offset: 0x00D65B10
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		private ILayoutItem<MaterialItem> InitMaterial([Nullable(2)] object data, UUIItem uiItem, int index)
		{
			ISingleItemInfo singleItemInfo = data as ISingleItemInfo;
			if (singleItemInfo == null)
			{
				return null;
			}
			MaterialItem materialItem = new MaterialItem(uiItem);
			materialItem.Update(singleItemInfo, index);
			materialItem.BindOnClickedCallback(new Action<ISingleItemInfo, int>(this.OnClicked));
			return new LayoutItem<MaterialItem>
			{
				Key = index,
				Value = materialItem
			};
		}

		// Token: 0x060300C8 RID: 196808 RVA: 0x00D67962 File Offset: 0x00D65B62
		private void OnClicked(ISingleItemInfo itemData, int _)
		{
			if (!itemData.Proto_IsUnlock)
			{
				return;
			}
			ItemController.Instance.OpenItemTipsByItemId(itemData.Proto_ItemId, true, null, false);
		}

		// Token: 0x060300C9 RID: 196809 RVA: 0x00D67980 File Offset: 0x00D65B80
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		private ILayoutItem<MachiningClueItem> InitMachining([Nullable(2)] object data, UUIItem uiItem, int index)
		{
			IMachiningClueData machiningClueData = data as IMachiningClueData;
			if (machiningClueData == null)
			{
				return null;
			}
			MachiningClueItem machiningClueItem = new MachiningClueItem(uiItem);
			machiningClueItem.Update(machiningClueData.IsUnlock, machiningClueData.ContentText);
			return new LayoutItem<MachiningClueItem>
			{
				Key = index,
				Value = machiningClueItem
			};
		}

		// Token: 0x060300CA RID: 196810 RVA: 0x00D679CC File Offset: 0x00D65BCC
		public void RefreshTips(ICookingData itemData)
		{
			this.ItemData = itemData;
			ECookListType mainType = itemData.MainType;
			if (mainType == ECookListType.Cooking)
			{
				this.RefreshCooking();
				return;
			}
			if (mainType != ECookListType.Machining)
			{
				return;
			}
			this.RefreshMachining();
		}

		// Token: 0x060300CB RID: 196811 RVA: 0x00D679FC File Offset: 0x00D65BFC
		private void RefreshCooking()
		{
			ICookingData cookingData = this.ItemData as ICookingData;
			ESubCookDataType subType = cookingData.SubType;
			if (subType != ESubCookDataType.CookFood)
			{
				if (subType == ESubCookDataType.CookMenu)
				{
					this.SetCookMenuHide();
					this.RefreshCookMenu(cookingData);
					return;
				}
			}
			else
			{
				this.SetCookFoodHide();
				this.RefreshCookFood(cookingData);
			}
		}

		// Token: 0x060300CC RID: 196812 RVA: 0x00D67A44 File Offset: 0x00D65C44
		private void RefreshCookMenu(ICookingData data)
		{
			CookFormula cookFormulaByFormulaItemId = CookConfig.Instance.GetCookFormulaByFormulaItemId(data.ItemId);
			this.SetHaveText(1);
			string textById = TextConfig.Instance.GetTextById("Recipe");
			this.SetTypeNameText(textById);
			string localText = CookConfig.Instance.GetLocalText(cookFormulaByFormulaItemId.Name);
			this.SetNameText(localText);
			this.SetIconTexture(ItemConfig.Instance.GetConfig(data.ItemId).Value.Icon);
			string localText2 = CookConfig.Instance.GetLocalText(cookFormulaByFormulaItemId.FoodContent);
			this.SetContentText(localText2);
			string localText3 = CookConfig.Instance.GetLocalText(cookFormulaByFormulaItemId.FoodBackground);
			this.SetAttributeText(localText3);
			this.RefreshDisableButton(true);
			string textById2 = TextConfig.Instance.GetTextById("Study");
			this.RefreshConfirmButton(textById2, true);
		}

		// Token: 0x060300CD RID: 196813 RVA: 0x00D67B18 File Offset: 0x00D65D18
		private void RefreshCookFood(ICookingData data)
		{
			CookFormula cookFormulaById = CookConfig.Instance.GetCookFormulaById(data.ItemId);
			int commonItemCount = InventoryModel.Instance.GetCommonItemCount(cookFormulaById.FoodItemId, 0);
			this.SetHaveText(commonItemCount);
			string textById = TextConfig.Instance.GetTextById("Dishes");
			this.SetTypeNameText(textById);
			string localText = CookConfig.Instance.GetLocalText(cookFormulaById.Name);
			this.SetNameText(localText);
			ItemInfo? config = ItemConfig.Instance.GetConfig(cookFormulaById.FoodItemId);
			this.SetIconTexture(config.Value.Icon);
			string localText2 = CookConfig.Instance.GetLocalText(config.Value.AttributesDescription);
			this.SetContentText(localText2);
			string localText3 = CookConfig.Instance.GetLocalText(config.Value.BgDescription);
			this.SetAttributeText(localText3);
			int proficiency = cookFormulaById.Proficiency;
			int maxProficiencyCount = cookFormulaById.MaxProficiencyCount;
			this.SetProficiencyText(data.CookCount, proficiency, maxProficiencyCount);
			string textById2 = TextConfig.Instance.GetTextById("Cooking");
			bool isEnable = CookController.Instance.CheckCanCook(data.ItemId);
			this.RefreshConfirmButton(textById2, isEnable);
			this.RefreshDisableButton(isEnable);
			this.SetMaterialList(data.ItemId, ECookListType.Cooking);
		}

		// Token: 0x060300CE RID: 196814 RVA: 0x00D67C58 File Offset: 0x00D65E58
		private void SetCookMenuHide()
		{
			base.GetText(3).SetUIActive(true);
			base.GetText(12).SetUIActive(true);
			base.GetItem(17).SetUIActive(false);
			base.GetItem(19).SetUIActive(true);
			base.GetItem(20).SetUIActive(false);
			base.GetText(2).SetUIActive(false);
			base.GetText(16).SetUIActive(false);
		}

		// Token: 0x060300CF RID: 196815 RVA: 0x00D67CC8 File Offset: 0x00D65EC8
		private void SetCookFoodHide()
		{
			base.GetText(3).SetUIActive(true);
			base.GetText(12).SetUIActive(true);
			base.GetItem(17).SetUIActive(true);
			base.GetItem(19).SetUIActive(true);
			base.GetItem(20).SetUIActive(false);
			base.GetText(2).SetUIActive(true);
			base.GetText(16).SetUIActive(true);
		}

		// Token: 0x060300D0 RID: 196816 RVA: 0x00D67D38 File Offset: 0x00D65F38
		private void RefreshMachining()
		{
			this.SetMachiningHide();
			IMachiningData machiningData = this.ItemData as IMachiningData;
			CookProcessed cookProcessedById = CookConfig.Instance.GetCookProcessedById(machiningData.ItemId);
			int commonItemCount = InventoryModel.Instance.GetCommonItemCount(cookProcessedById.FinalItemId, 0);
			this.SetHaveText(commonItemCount);
			string textById = TextConfig.Instance.GetTextById("Accessory");
			this.SetTypeNameText(textById);
			string localText = CookConfig.Instance.GetLocalText(cookProcessedById.Name);
			this.SetNameText(localText);
			ItemInfo? config = ItemConfig.Instance.GetConfig(cookProcessedById.FinalItemId);
			this.SetIconTexture(config.Value.Icon);
			this.SetInterations();
			string localText2 = CookConfig.Instance.GetLocalText(config.Value.BgDescription);
			this.SetMachiningAttributeText(localText2);
			bool isEnable = true;
			string textById2;
			if (!machiningData.IsUnLock)
			{
				textById2 = TextConfig.Instance.GetTextById("Research");
			}
			else
			{
				textById2 = TextConfig.Instance.GetTextById("Cooking");
				isEnable = CookController.Instance.CheckCanProcessed(machiningData.ItemId);
			}
			this.RefreshConfirmButton(textById2, isEnable);
			this.RefreshDisableButton(isEnable);
			this.SetMaterialList(machiningData.ItemId, ECookListType.Machining);
		}

		// Token: 0x060300D1 RID: 196817 RVA: 0x00D67E6C File Offset: 0x00D6606C
		private void SetMachiningHide()
		{
			base.GetText(3).SetUIActive(false);
			base.GetText(12).SetUIActive(false);
			base.GetItem(19).SetUIActive(false);
			base.GetItem(20).SetUIActive(true);
			base.GetItem(17).SetUIActive(true);
			base.GetText(2).SetUIActive(false);
			base.GetText(16).SetUIActive(false);
		}

		// Token: 0x060300D2 RID: 196818 RVA: 0x00D67ED9 File Offset: 0x00D660D9
		private void SetNameText(string name)
		{
			base.GetText(0).SetText(name, true);
		}

		// Token: 0x060300D3 RID: 196819 RVA: 0x00D67EEC File Offset: 0x00D660EC
		private void SetIconTexture(string icon)
		{
			base.SetTextureByPath(icon, base.GetTexture(1), null, null);
		}

		// Token: 0x060300D4 RID: 196820 RVA: 0x00D67F11 File Offset: 0x00D66111
		private void SetContentText(string text)
		{
			base.GetText(3).SetText(text, true);
		}

		// Token: 0x060300D5 RID: 196821 RVA: 0x00D67F21 File Offset: 0x00D66121
		private void SetAttributeText(string text)
		{
			base.GetText(12).SetText(text, true);
		}

		// Token: 0x060300D6 RID: 196822 RVA: 0x00D67F32 File Offset: 0x00D66132
		private void SetMachiningAttributeText(string text)
		{
			base.GetText(22).SetText(text, true);
		}

		// Token: 0x060300D7 RID: 196823 RVA: 0x00D67F43 File Offset: 0x00D66143
		private void SetTypeNameText(string text)
		{
			base.GetText(15).SetText(text, true);
		}

		// Token: 0x060300D8 RID: 196824 RVA: 0x00D67F54 File Offset: 0x00D66154
		private void SetHaveText(int have)
		{
			LguiUtil.Instance.SetLocalText(base.GetText(14), "Have", new <>z__ReadOnlySingleElementList<object>(have));
		}

		// Token: 0x060300D9 RID: 196825 RVA: 0x00D67F78 File Offset: 0x00D66178
		private void SetProficiencyText(int cookCount, int single, int sum)
		{
			int num = single * sum;
			int num2 = cookCount * single;
			if (num2 != num)
			{
				LguiUtil instance = LguiUtil.Instance;
				UUIText text = base.GetText(2);
				string textTableId = "AddProficiency";
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 1);
				defaultInterpolatedStringHandler.AppendLiteral("+");
				defaultInterpolatedStringHandler.AppendFormatted<int>(single);
				instance.SetLocalText(text, textTableId, new <>z__ReadOnlySingleElementList<object>(defaultInterpolatedStringHandler.ToStringAndClear()));
			}
			else
			{
				LguiUtil.Instance.SetLocalText(base.GetText(2), "Proficiency", Array.Empty<object>());
			}
			LguiUtil.Instance.SetLocalText(base.GetText(16), "CumulativeProficiency", new <>z__ReadOnlyArray<object>(new object[]
			{
				num2,
				num
			}));
		}

		// Token: 0x060300DA RID: 196826 RVA: 0x00D68021 File Offset: 0x00D66221
		private void RefreshConfirmButton(string text, bool isEnable)
		{
			this.ConfirmButtonCompose.UpdateText(text);
			this.ConfirmButtonCompose.RefreshButton(isEnable);
		}

		// Token: 0x060300DB RID: 196827 RVA: 0x00D6803B File Offset: 0x00D6623B
		private void RefreshDisableButton(bool isEnable)
		{
			(base.GetButton(23).GetOwner() as AUIBaseActor).GetUIItem().SetUIActive(!isEnable);
		}

		// Token: 0x060300DC RID: 196828 RVA: 0x00D68060 File Offset: 0x00D66260
		private void SetMaterialList(int itemId, ECookListType type)
		{
			List<ISingleItemInfo> cookMaterialList = CookModel.Instance.GetCookMaterialList(itemId, type);
			this.MaterialHorizontal.RebuildLayoutByDataNew<ISingleItemInfo>(cookMaterialList, null);
		}

		// Token: 0x060300DD RID: 196829 RVA: 0x00D68090 File Offset: 0x00D66290
		private void SetInterations()
		{
			IMachiningData machiningData = this.ItemData as IMachiningData;
			CookProcessed cookProcessedById = CookConfig.Instance.GetCookProcessedById(machiningData.ItemId);
			List<IMachiningClueData> list = new List<IMachiningClueData>();
			for (int i = 0; i < cookProcessedById.InterationIdLength; i++)
			{
				int num = cookProcessedById.InterationId(i);
				CookProcessMsg cookProcessMsgById = CookConfig.Instance.GetCookProcessMsgById(num);
				if (machiningData.InteractiveList.Contains(num))
				{
					string localText = CookConfig.Instance.GetLocalText(cookProcessMsgById.Introduce);
					list.Add(new MachiningClueData
					{
						IsUnlock = true,
						ContentText = localText
					});
				}
				else
				{
					string localText2 = CookConfig.Instance.GetLocalText(cookProcessMsgById.Description);
					list.Add(new MachiningClueData
					{
						IsUnlock = false,
						ContentText = localText2
					});
				}
			}
			this.MachiningVertical.RebuildLayoutByDataNew<IMachiningClueData>(list, null);
		}

		// Token: 0x060300DE RID: 196830 RVA: 0x00D68174 File Offset: 0x00D66374
		private void OnClickConfirmButton()
		{
			if (CookModel.Instance.CurrentCookListType == ECookListType.Cooking)
			{
				ICookingData cookingData = this.ItemData as ICookingData;
				ESubCookDataType subType = cookingData.SubType;
				if (subType == ESubCookDataType.CookFood)
				{
					EventSystem.Instance.Emit<int>(EEventName.OpenCook, cookingData.ItemId);
					return;
				}
				if (subType == ESubCookDataType.CookMenu)
				{
					CookFormula cookFormulaByFormulaItemId = CookConfig.Instance.GetCookFormulaByFormulaItemId(cookingData.ItemId);
					CookController.Instance.SendCookFormulaRequest(cookFormulaByFormulaItemId.Id);
					return;
				}
			}
			else
			{
				IMachiningData machiningData = this.ItemData as IMachiningData;
				if (machiningData.IsUnLock)
				{
					EventSystem.Instance.Emit<int>(EEventName.OpenCook, machiningData.ItemId);
					return;
				}
				EventSystem.Instance.Emit<int>(EEventName.OpenProcessedStudy, machiningData.ItemId);
			}
		}

		// Token: 0x060300DF RID: 196831 RVA: 0x00D68226 File Offset: 0x00D66426
		private void OnDisableCook()
		{
			GenericPromptController.Instance.ShowPromptByCode("MaterialShort", Array.Empty<object>());
		}

		// Token: 0x040197A7 RID: 104359
		[Nullable(2)]
		private ICookItemData ItemData;

		// Token: 0x040197A8 RID: 104360
		[Nullable(2)]
		private ConfirmButtonCompose ConfirmButtonCompose;

		// Token: 0x040197A9 RID: 104361
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericLayoutNew<MaterialItem> MaterialHorizontal;

		// Token: 0x040197AA RID: 104362
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericLayoutNew<MachiningClueItem> MachiningVertical;

		// Token: 0x0200A76E RID: 42862
		[NullableContext(0)]
		private enum ECookTipsDefine
		{
			// Token: 0x04033BCC RID: 211916
			NameText,
			// Token: 0x04033BCD RID: 211917
			IconTexture,
			// Token: 0x04033BCE RID: 211918
			CookCountText,
			// Token: 0x04033BCF RID: 211919
			ConTentText,
			// Token: 0x04033BD0 RID: 211920
			TipsBtnItem = 6,
			// Token: 0x04033BD1 RID: 211921
			TipsConfirmButton = 8,
			// Token: 0x04033BD2 RID: 211922
			AttributeText = 12,
			// Token: 0x04033BD3 RID: 211923
			HaveText = 14,
			// Token: 0x04033BD4 RID: 211924
			TypeNameText,
			// Token: 0x04033BD5 RID: 211925
			SumText,
			// Token: 0x04033BD6 RID: 211926
			MaterialLayoutItem,
			// Token: 0x04033BD7 RID: 211927
			MaterialHorizontalLayout,
			// Token: 0x04033BD8 RID: 211928
			CookingIntroduceItem,
			// Token: 0x04033BD9 RID: 211929
			MachiningConditionItem,
			// Token: 0x04033BDA RID: 211930
			MachiningVerticalLayout,
			// Token: 0x04033BDB RID: 211931
			MachiningAttributeText,
			// Token: 0x04033BDC RID: 211932
			DisableButton
		}
	}
}
