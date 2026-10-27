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
	// Token: 0x02005B28 RID: 23336
	[NullableContext(1)]
	[Nullable(0)]
	public class CookTipsView : UiPanelBase
	{
		// Token: 0x0603B151 RID: 242001 RVA: 0x00E168A1 File Offset: 0x00E14AA1
		public CookTipsView(UUIItem uiItem)
		{
			base.CreateThenShowByActor(uiItem.GetOwner(), null);
		}

		// Token: 0x0603B152 RID: 242002 RVA: 0x00E168B8 File Offset: 0x00E14AB8
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

		// Token: 0x0603B153 RID: 242003 RVA: 0x00E16B5A File Offset: 0x00E14D5A
		protected override void OnBeforeDestroy()
		{
			this.MaterialHorizontal.ClearChildren();
			this.MaterialHorizontal = null;
			this.MachiningVertical.ClearChildren();
			this.MachiningVertical = null;
		}

		// Token: 0x0603B154 RID: 242004 RVA: 0x00E16B80 File Offset: 0x00E14D80
		protected override void OnStart()
		{
			this.ConfirmButtonCompose = new ConfirmButtonCompose(base.GetItem(8));
			this.ConfirmButtonCompose.BindClickFunction(new Action(this.OnClickConfirmButton));
			this.MaterialHorizontal = new GenericLayoutNew<MaterialItem>(base.GetHorizontalLayout(18), new CSharpScript.Game.Module.Util.Layout.TLayoutRefresh<MaterialItem>(this.InitMaterial), null);
			this.MachiningVertical = new GenericLayoutNew<MachiningClueItem>(base.GetVerticalLayout(21), new CSharpScript.Game.Module.Util.Layout.TLayoutRefresh<MachiningClueItem>(this.InitMachining), null);
		}

		// Token: 0x0603B155 RID: 242005 RVA: 0x00E16BF8 File Offset: 0x00E14DF8
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

		// Token: 0x0603B156 RID: 242006 RVA: 0x00E16C4A File Offset: 0x00E14E4A
		private void OnClicked(ISingleItemInfo itemData, int _)
		{
			if (!itemData.Proto_IsUnlock)
			{
				return;
			}
			ItemController.Instance.OpenItemTipsByItemId(itemData.Proto_ItemId, true, null);
		}

		// Token: 0x0603B157 RID: 242007 RVA: 0x00E16C68 File Offset: 0x00E14E68
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

		// Token: 0x0603B158 RID: 242008 RVA: 0x00E16CB4 File Offset: 0x00E14EB4
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

		// Token: 0x0603B159 RID: 242009 RVA: 0x00E16CE4 File Offset: 0x00E14EE4
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

		// Token: 0x0603B15A RID: 242010 RVA: 0x00E16D2C File Offset: 0x00E14F2C
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

		// Token: 0x0603B15B RID: 242011 RVA: 0x00E16E00 File Offset: 0x00E15000
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

		// Token: 0x0603B15C RID: 242012 RVA: 0x00E16F40 File Offset: 0x00E15140
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

		// Token: 0x0603B15D RID: 242013 RVA: 0x00E16FB0 File Offset: 0x00E151B0
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

		// Token: 0x0603B15E RID: 242014 RVA: 0x00E17020 File Offset: 0x00E15220
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

		// Token: 0x0603B15F RID: 242015 RVA: 0x00E17154 File Offset: 0x00E15354
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

		// Token: 0x0603B160 RID: 242016 RVA: 0x00E171C1 File Offset: 0x00E153C1
		private void SetNameText(string name)
		{
			base.GetText(0).SetText(name, true);
		}

		// Token: 0x0603B161 RID: 242017 RVA: 0x00E171D4 File Offset: 0x00E153D4
		private void SetIconTexture(string icon)
		{
			base.SetTextureByPath(icon, base.GetTexture(1), null, null);
		}

		// Token: 0x0603B162 RID: 242018 RVA: 0x00E171F9 File Offset: 0x00E153F9
		private void SetContentText(string text)
		{
			base.GetText(3).SetText(text, true);
		}

		// Token: 0x0603B163 RID: 242019 RVA: 0x00E17209 File Offset: 0x00E15409
		private void SetAttributeText(string text)
		{
			base.GetText(12).SetText(text, true);
		}

		// Token: 0x0603B164 RID: 242020 RVA: 0x00E1721A File Offset: 0x00E1541A
		private void SetMachiningAttributeText(string text)
		{
			base.GetText(22).SetText(text, true);
		}

		// Token: 0x0603B165 RID: 242021 RVA: 0x00E1722B File Offset: 0x00E1542B
		private void SetTypeNameText(string text)
		{
			base.GetText(15).SetText(text, true);
		}

		// Token: 0x0603B166 RID: 242022 RVA: 0x00E1723C File Offset: 0x00E1543C
		private void SetHaveText(int have)
		{
			LguiUtil.Instance.SetLocalText(base.GetText(14), "Have", new <>z__ReadOnlySingleElementList<object>(have));
		}

		// Token: 0x0603B167 RID: 242023 RVA: 0x00E17260 File Offset: 0x00E15460
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

		// Token: 0x0603B168 RID: 242024 RVA: 0x00E17309 File Offset: 0x00E15509
		private void RefreshConfirmButton(string text, bool isEnable)
		{
			this.ConfirmButtonCompose.UpdateText(text);
			this.ConfirmButtonCompose.RefreshButton(isEnable);
		}

		// Token: 0x0603B169 RID: 242025 RVA: 0x00E17323 File Offset: 0x00E15523
		private void RefreshDisableButton(bool isEnable)
		{
			(base.GetButton(23).GetOwner() as AUIBaseActor).GetUIItem().SetUIActive(!isEnable);
		}

		// Token: 0x0603B16A RID: 242026 RVA: 0x00E17348 File Offset: 0x00E15548
		private void SetMaterialList(int itemId, ECookListType type)
		{
			List<ISingleItemInfo> cookMaterialList = CookModel.Instance.GetCookMaterialList(itemId, type);
			this.MaterialHorizontal.RebuildLayoutByDataNew<ISingleItemInfo>(cookMaterialList, null);
		}

		// Token: 0x0603B16B RID: 242027 RVA: 0x00E17378 File Offset: 0x00E15578
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

		// Token: 0x0603B16C RID: 242028 RVA: 0x00E1745C File Offset: 0x00E1565C
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

		// Token: 0x0603B16D RID: 242029 RVA: 0x00E1750E File Offset: 0x00E1570E
		private void OnDisableCook()
		{
			GenericPromptController.Instance.ShowPromptByCode("MaterialShort", Array.Empty<object>());
		}

		// Token: 0x0401ECEB RID: 126187
		[Nullable(2)]
		private ICookItemData ItemData;

		// Token: 0x0401ECEC RID: 126188
		[Nullable(2)]
		private ConfirmButtonCompose ConfirmButtonCompose;

		// Token: 0x0401ECED RID: 126189
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericLayoutNew<MaterialItem> MaterialHorizontal;

		// Token: 0x0401ECEE RID: 126190
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericLayoutNew<MachiningClueItem> MachiningVertical;

		// Token: 0x0200BD65 RID: 48485
		[NullableContext(0)]
		private enum ECookTipsDefine
		{
			// Token: 0x04039200 RID: 233984
			NameText,
			// Token: 0x04039201 RID: 233985
			IconTexture,
			// Token: 0x04039202 RID: 233986
			CookCountText,
			// Token: 0x04039203 RID: 233987
			ConTentText,
			// Token: 0x04039204 RID: 233988
			TipsBtnItem = 6,
			// Token: 0x04039205 RID: 233989
			TipsConfirmButton = 8,
			// Token: 0x04039206 RID: 233990
			AttributeText = 12,
			// Token: 0x04039207 RID: 233991
			HaveText = 14,
			// Token: 0x04039208 RID: 233992
			TypeNameText,
			// Token: 0x04039209 RID: 233993
			SumText,
			// Token: 0x0403920A RID: 233994
			MaterialLayoutItem,
			// Token: 0x0403920B RID: 233995
			MaterialHorizontalLayout,
			// Token: 0x0403920C RID: 233996
			CookingIntroduceItem,
			// Token: 0x0403920D RID: 233997
			MachiningConditionItem,
			// Token: 0x0403920E RID: 233998
			MachiningVerticalLayout,
			// Token: 0x0403920F RID: 233999
			MachiningAttributeText,
			// Token: 0x04039210 RID: 234000
			DisableButton
		}
	}
}
