using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Item;
using CSharpScript.Game.Module.Manufacture.Common;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Module.Util.Layout;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Manufacture.Compose.View
{
	// Token: 0x02005675 RID: 22133
	[NullableContext(1)]
	[Nullable(0)]
	public class ComposeTipsView : UiPanelBase
	{
		// Token: 0x0603852F RID: 230703 RVA: 0x00D5D0D3 File Offset: 0x00D5B2D3
		public ComposeTipsView(UUIItem uiItem)
		{
			base.CreateThenShowByActor(uiItem.GetOwner(), null);
		}

		// Token: 0x06038530 RID: 230704 RVA: 0x00D5D0E8 File Offset: 0x00D5B2E8
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
			*span2[num] = new ValueTuple<int, Delegate>(23, new Action(this.OnDisable));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06038531 RID: 230705 RVA: 0x00D5D38C File Offset: 0x00D5B58C
		protected override void OnStart()
		{
			this.ConfirmButtonCompose = new ConfirmButtonCompose(base.GetItem(8));
			this.ConfirmButtonCompose.BindClickFunction(new Action(this.OnClickConfirmButton));
			this.MaterialHorizontal = new GenericLayoutNew<MaterialItem>(base.GetHorizontalLayout(18), new CSharpScript.Game.Module.Util.Layout.TLayoutRefresh<MaterialItem>(this.InitMaterial), null);
		}

		// Token: 0x06038532 RID: 230706 RVA: 0x00D5D3E4 File Offset: 0x00D5B5E4
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
			materialItem.Update(singleItemInfo);
			materialItem.BindOnClickedCallback(new Action<ISingleItemInfo>(this.OnClicked));
			return new LayoutItem<MaterialItem>
			{
				Key = index,
				Value = materialItem
			};
		}

		// Token: 0x06038533 RID: 230707 RVA: 0x00D5D435 File Offset: 0x00D5B635
		private void OnClicked(ISingleItemInfo itemData)
		{
			if (!itemData.Proto_IsUnlock)
			{
				return;
			}
			ItemController.Instance.OpenItemTipsByItemId(itemData.Proto_ItemId, true, null);
		}

		// Token: 0x06038534 RID: 230708 RVA: 0x00D5D452 File Offset: 0x00D5B652
		protected override void OnBeforeDestroy()
		{
			if (this.MaterialHorizontal != null)
			{
				this.MaterialHorizontal.ClearChildren();
				this.MaterialHorizontal = null;
			}
			this.OnDisableCallback = null;
		}

		// Token: 0x06038535 RID: 230709 RVA: 0x00D5D478 File Offset: 0x00D5B678
		public void RefreshTips(IBaseItemData itemData)
		{
			this.ItemData = itemData;
			switch (itemData.MainType)
			{
			case EComposeListType.ReagentProduction:
				this.RefreshReagentProductionData();
				return;
			case EComposeListType.Structure:
				this.RefreshStructureData();
				return;
			case EComposeListType.Purification:
				this.RefreshPurificationData();
				return;
			default:
				return;
			}
		}

		// Token: 0x06038536 RID: 230710 RVA: 0x00D5D4BC File Offset: 0x00D5B6BC
		private void RefreshReagentProductionData()
		{
			IReagentProductionData reagentProductionData = (IReagentProductionData)this.ItemData;
			ESubComposeDataType subType = reagentProductionData.SubType;
			if (subType != ESubComposeDataType.Compose)
			{
				if (subType == ESubComposeDataType.ComposeMenu)
				{
					this.SetRefreshReagentProductionMenuHide();
					this.RefreshReagentProductionMenu(reagentProductionData);
					return;
				}
			}
			else
			{
				this.SetRefreshReagentProductionHide();
				this.RefreshReagentProduction(reagentProductionData);
			}
		}

		// Token: 0x06038537 RID: 230711 RVA: 0x00D5D500 File Offset: 0x00D5B700
		private void RefreshReagentProductionMenu(IReagentProductionData data)
		{
			SynthesisFormula value = ComposeConfig.Instance.GetSynthesisFormulaByFormulaItemId(data.ConfigId).Value;
			this.SetHaveText(1);
			string textById = TextConfig.Instance.GetTextById("Formula");
			this.SetTypeNameText(textById);
			string localText = ComposeConfig.Instance.GetLocalText(value.Name);
			this.SetNameText(localText);
			this.SetIconTexture(ItemConfig.Instance.GetConfig(data.ConfigId).Value.Icon);
			string localText2 = ComposeConfig.Instance.GetLocalText(value.ComposeContent);
			this.SetContentText(localText2);
			string localText3 = ComposeConfig.Instance.GetLocalText(value.ComposeBackground);
			this.SetAttributeText(localText3);
			this.RefreshDisableButton(true);
			string textById2 = TextConfig.Instance.GetTextById("Study");
			this.RefreshConfirmButton(textById2, true);
		}

		// Token: 0x06038538 RID: 230712 RVA: 0x00D5D5DC File Offset: 0x00D5B7DC
		private void RefreshReagentProduction(IReagentProductionData data)
		{
			SynthesisFormula value = ComposeConfig.Instance.GetSynthesisFormulaById(data.ConfigId).Value;
			int commonItemCount = InventoryModel.Instance.GetCommonItemCount(value.ItemId, 0);
			this.SetHaveText(commonItemCount);
			string textById = TextConfig.Instance.GetTextById("Medicament");
			this.SetTypeNameText(textById);
			string localText = ComposeConfig.Instance.GetLocalText(value.Name);
			this.SetNameText(localText);
			ItemInfo value2 = ItemConfig.Instance.GetConfig(value.ItemId).Value;
			this.SetIconTexture(value2.Icon);
			string localText2 = ComposeConfig.Instance.GetLocalText(value2.AttributesDescription);
			this.SetContentText(localText2);
			string localText3 = ComposeConfig.Instance.GetLocalText(value2.BgDescription);
			this.SetAttributeText(localText3);
			int proficiency = value.Proficiency;
			int maxProficiencyCount = value.MaxProficiencyCount;
			this.SetProficiencyText(data.ComposeCount, proficiency, maxProficiencyCount);
			string textById2 = TextConfig.Instance.GetTextById("Making");
			bool isEnable = ComposeController.Instance.CheckCanReagentProduction(data.ConfigId);
			this.RefreshConfirmButton(textById2, isEnable);
			this.RefreshDisableButton(isEnable);
			this.SetMaterialList(data.ConfigId);
		}

		// Token: 0x06038539 RID: 230713 RVA: 0x00D5D710 File Offset: 0x00D5B910
		private void SetRefreshReagentProductionMenuHide()
		{
			base.GetText(3).SetUIActive(true);
			base.GetText(12).SetUIActive(true);
			base.GetItem(17).SetUIActive(false);
			base.GetItem(19).SetUIActive(true);
			base.GetItem(20).SetUIActive(false);
			base.GetText(2).SetUIActive(false);
			base.GetText(16).SetUIActive(false);
		}

		// Token: 0x0603853A RID: 230714 RVA: 0x00D5D780 File Offset: 0x00D5B980
		private void SetRefreshReagentProductionHide()
		{
			base.GetText(3).SetUIActive(true);
			base.GetText(12).SetUIActive(true);
			base.GetItem(17).SetUIActive(true);
			base.GetItem(19).SetUIActive(true);
			base.GetItem(20).SetUIActive(false);
			base.GetText(2).SetUIActive(true);
			base.GetText(16).SetUIActive(true);
		}

		// Token: 0x0603853B RID: 230715 RVA: 0x00D5D7F0 File Offset: 0x00D5B9F0
		public void RefreshStructureData()
		{
			IStructureData structureData = (IStructureData)this.ItemData;
			ESubStructureDataType subType = structureData.SubType;
			if (subType != ESubStructureDataType.Structure)
			{
				if (subType == ESubStructureDataType.StructureMenu)
				{
					this.SetStructureMenuHide();
					this.RefreshStructureMenu(structureData);
					return;
				}
			}
			else
			{
				this.SetStructureHide();
				this.RefreshStructure(structureData);
			}
		}

		// Token: 0x0603853C RID: 230716 RVA: 0x00D5D834 File Offset: 0x00D5BA34
		public void RefreshStructure(IStructureData data)
		{
			SynthesisFormula value = ComposeConfig.Instance.GetSynthesisFormulaById(data.ConfigId).Value;
			int commonItemCount = InventoryModel.Instance.GetCommonItemCount(value.ItemId, 0);
			this.SetHaveText(commonItemCount);
			string textById = TextConfig.Instance.GetTextById("Prop");
			this.SetTypeNameText(textById);
			string localText = ComposeConfig.Instance.GetLocalText(value.Name);
			this.SetNameText(localText);
			ItemInfo value2 = ItemConfig.Instance.GetConfig(value.ItemId).Value;
			this.SetIconTexture(value2.Icon);
			string localText2 = ComposeConfig.Instance.GetLocalText(value2.AttributesDescription);
			this.SetContentText(localText2);
			string localText3 = ComposeConfig.Instance.GetLocalText(value2.BgDescription);
			this.SetAttributeText(localText3);
			string textById2 = TextConfig.Instance.GetTextById("Making");
			bool isEnable = ComposeController.Instance.CheckCanStructure(data.ConfigId);
			this.RefreshConfirmButton(textById2, isEnable);
			this.RefreshDisableButton(isEnable);
			this.SetMaterialList(data.ConfigId);
		}

		// Token: 0x0603853D RID: 230717 RVA: 0x00D5D948 File Offset: 0x00D5BB48
		public void RefreshStructureMenu(IStructureData data)
		{
			SynthesisFormula value = ComposeConfig.Instance.GetSynthesisFormulaByFormulaItemId(data.ConfigId).Value;
			this.SetHaveText(1);
			string textById = TextConfig.Instance.GetTextById("Formula");
			this.SetTypeNameText(textById);
			string localText = ComposeConfig.Instance.GetLocalText(value.Name);
			this.SetNameText(localText);
			this.SetIconTexture(ItemConfig.Instance.GetConfig(data.ConfigId).Value.Icon);
			string localText2 = ComposeConfig.Instance.GetLocalText(value.ComposeContent);
			this.SetContentText(localText2);
			string localText3 = ComposeConfig.Instance.GetLocalText(value.ComposeBackground);
			this.SetAttributeText(localText3);
			this.RefreshDisableButton(true);
			string textById2 = TextConfig.Instance.GetTextById("Study");
			this.RefreshConfirmButton(textById2, true);
		}

		// Token: 0x0603853E RID: 230718 RVA: 0x00D5DA24 File Offset: 0x00D5BC24
		private void SetStructureHide()
		{
			base.GetText(3).SetUIActive(true);
			base.GetText(12).SetUIActive(true);
			base.GetItem(17).SetUIActive(true);
			base.GetItem(19).SetUIActive(true);
			base.GetItem(20).SetUIActive(false);
			base.GetText(2).SetUIActive(false);
			base.GetText(16).SetUIActive(false);
		}

		// Token: 0x0603853F RID: 230719 RVA: 0x00D5DA94 File Offset: 0x00D5BC94
		private void SetStructureMenuHide()
		{
			base.GetText(3).SetUIActive(true);
			base.GetText(12).SetUIActive(true);
			base.GetItem(17).SetUIActive(false);
			base.GetItem(19).SetUIActive(true);
			base.GetItem(20).SetUIActive(false);
			base.GetText(2).SetUIActive(false);
			base.GetText(16).SetUIActive(false);
		}

		// Token: 0x06038540 RID: 230720 RVA: 0x00D5DB04 File Offset: 0x00D5BD04
		public void RefreshPurificationData()
		{
			IPurificationData data = (IPurificationData)this.ItemData;
			this.SetPurificationHide();
			this.RefreshPurification(data);
		}

		// Token: 0x06038541 RID: 230721 RVA: 0x00D5DB2C File Offset: 0x00D5BD2C
		public void RefreshPurification(IPurificationData data)
		{
			SynthesisFormula value = ComposeConfig.Instance.GetSynthesisFormulaById(data.ConfigId).Value;
			int commonItemCount = InventoryModel.Instance.GetCommonItemCount(value.ItemId, 0);
			this.SetHaveText(commonItemCount);
			string textById = TextConfig.Instance.GetTextById("Material");
			this.SetTypeNameText(textById);
			string localText = ComposeConfig.Instance.GetLocalText(value.Name);
			this.SetNameText(localText);
			ItemInfo value2 = ItemConfig.Instance.GetConfig(value.ItemId).Value;
			this.SetIconTexture(value2.Icon);
			string localText2 = ComposeConfig.Instance.GetLocalText(value2.AttributesDescription);
			this.SetContentText(localText2);
			string localText3 = ComposeConfig.Instance.GetLocalText(value2.BgDescription);
			this.SetAttributeText(localText3);
			string text;
			bool isEnable;
			if (data.IsUnlock == 1)
			{
				text = TextConfig.Instance.GetTextById("Making");
				isEnable = ComposeController.Instance.CheckCanPurification(data.ConfigId);
				this.RefreshDisableButton(isEnable);
			}
			else
			{
				ConditionGroup value3 = ComposeConfig.Instance.GetConditionInfo(value.UnlockCondition).Value;
				text = ComposeConfig.Instance.GetLocalText(value3.HintText);
				isEnable = false;
				this.RefreshDisableButton(true);
			}
			this.RefreshConfirmButton(text, isEnable);
			this.SetMaterialList(data.ConfigId);
		}

		// Token: 0x06038542 RID: 230722 RVA: 0x00D5DC8C File Offset: 0x00D5BE8C
		public void SetPurificationHide()
		{
			base.GetText(3).SetUIActive(true);
			base.GetText(12).SetUIActive(true);
			base.GetItem(17).SetUIActive(true);
			base.GetItem(19).SetUIActive(true);
			base.GetItem(20).SetUIActive(false);
			base.GetText(2).SetUIActive(false);
			base.GetText(16).SetUIActive(false);
		}

		// Token: 0x06038543 RID: 230723 RVA: 0x00D5DCF9 File Offset: 0x00D5BEF9
		private void SetNameText(string name)
		{
			base.GetText(0).SetText(name, true);
		}

		// Token: 0x06038544 RID: 230724 RVA: 0x00D5DD0C File Offset: 0x00D5BF0C
		private void SetIconTexture(string icon)
		{
			base.SetTextureByPath(icon, base.GetTexture(1), null, null);
		}

		// Token: 0x06038545 RID: 230725 RVA: 0x00D5DD31 File Offset: 0x00D5BF31
		private void SetContentText(string text)
		{
			base.GetText(3).SetText(text, true);
		}

		// Token: 0x06038546 RID: 230726 RVA: 0x00D5DD41 File Offset: 0x00D5BF41
		private void SetAttributeText(string text)
		{
			base.GetText(12).SetText(text, true);
		}

		// Token: 0x06038547 RID: 230727 RVA: 0x00D5DD52 File Offset: 0x00D5BF52
		private void SetTypeNameText(string text)
		{
			base.GetText(15).SetText(text, true);
		}

		// Token: 0x06038548 RID: 230728 RVA: 0x00D5DD63 File Offset: 0x00D5BF63
		private void SetHaveText(int have)
		{
			LguiUtil.Instance.SetLocalText(base.GetText(14), "Have", new <>z__ReadOnlySingleElementList<object>(have));
		}

		// Token: 0x06038549 RID: 230729 RVA: 0x00D5DD88 File Offset: 0x00D5BF88
		private void SetProficiencyText(int composeCount, int single, int sum)
		{
			int num = single * sum;
			int num2 = composeCount * single;
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

		// Token: 0x0603854A RID: 230730 RVA: 0x00D5DE31 File Offset: 0x00D5C031
		private void RefreshConfirmButton(string text, bool isEnable)
		{
			this.ConfirmButtonCompose.UpdateText(text);
			this.ConfirmButtonCompose.RefreshButton(isEnable);
		}

		// Token: 0x0603854B RID: 230731 RVA: 0x00D5DE4B File Offset: 0x00D5C04B
		private void RefreshDisableButton(bool isEnable)
		{
			((AUIBaseActor)base.GetButton(23).GetOwner()).GetUIItem().SetUIActive(!isEnable);
		}

		// Token: 0x0603854C RID: 230732 RVA: 0x00D5DE70 File Offset: 0x00D5C070
		private void SetMaterialList(int itemId)
		{
			this.MaterialHorizontal.RebuildLayoutByDataNew<ISingleItemInfo>(ComposeModel.Instance.GetComposeMaterialList(itemId), null);
		}

		// Token: 0x0603854D RID: 230733 RVA: 0x00D5DE9C File Offset: 0x00D5C09C
		private void OnClickConfirmButton()
		{
			switch (ComposeModel.Instance.CurrentComposeListType)
			{
			case EComposeListType.ReagentProduction:
			{
				IReagentProductionData reagentProductionData = (IReagentProductionData)this.ItemData;
				if (reagentProductionData.SubType == ESubComposeDataType.ComposeMenu)
				{
					SynthesisFormula value = ComposeConfig.Instance.GetSynthesisFormulaByFormulaItemId(reagentProductionData.ConfigId).Value;
					ComposeController.Instance.SendSynthesisFormulaUnlockRequest(value.Id);
					return;
				}
				EventSystem.Instance.Emit<int>(EEventName.OpenCompose, reagentProductionData.ConfigId);
				return;
			}
			case EComposeListType.Structure:
			{
				IStructureData structureData = (IStructureData)this.ItemData;
				if (structureData.SubType == ESubStructureDataType.StructureMenu)
				{
					SynthesisFormula value2 = ComposeConfig.Instance.GetSynthesisFormulaByFormulaItemId(structureData.ConfigId).Value;
					ComposeController.Instance.SendSynthesisFormulaUnlockRequest(value2.Id);
					return;
				}
				EventSystem.Instance.Emit<int>(EEventName.OpenCompose, structureData.ConfigId);
				return;
			}
			case EComposeListType.Purification:
				EventSystem.Instance.Emit<int>(EEventName.OpenCompose, this.ItemData.ConfigId);
				return;
			default:
				return;
			}
		}

		// Token: 0x0603854E RID: 230734 RVA: 0x00D5DF99 File Offset: 0x00D5C199
		private void OnDisable()
		{
			if (this.OnDisableCallback != null)
			{
				this.OnDisableCallback();
			}
		}

		// Token: 0x0603854F RID: 230735 RVA: 0x00D5DFAE File Offset: 0x00D5C1AE
		public void BindOnDisable(Action onDisable)
		{
			this.OnDisableCallback = onDisable;
		}

		// Token: 0x0401D9AE RID: 121262
		[Nullable(2)]
		private IBaseItemData ItemData;

		// Token: 0x0401D9AF RID: 121263
		[Nullable(2)]
		private ConfirmButtonCompose ConfirmButtonCompose;

		// Token: 0x0401D9B0 RID: 121264
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericLayoutNew<MaterialItem> MaterialHorizontal;

		// Token: 0x0401D9B1 RID: 121265
		[Nullable(2)]
		private Action OnDisableCallback;

		// Token: 0x0200B83F RID: 47167
		[NullableContext(0)]
		private class EComposeTipsDefine
		{
			// Token: 0x04037C41 RID: 228417
			public const int NameText = 0;

			// Token: 0x04037C42 RID: 228418
			public const int IconTexture = 1;

			// Token: 0x04037C43 RID: 228419
			public const int ComposeCountText = 2;

			// Token: 0x04037C44 RID: 228420
			public const int ConTentText = 3;

			// Token: 0x04037C45 RID: 228421
			public const int TipsBtnItem = 6;

			// Token: 0x04037C46 RID: 228422
			public const int TipsConfirmButton = 8;

			// Token: 0x04037C47 RID: 228423
			public const int AttributeText = 12;

			// Token: 0x04037C48 RID: 228424
			public const int HaveText = 14;

			// Token: 0x04037C49 RID: 228425
			public const int TypeNameText = 15;

			// Token: 0x04037C4A RID: 228426
			public const int SumText = 16;

			// Token: 0x04037C4B RID: 228427
			public const int MaterialLayoutItem = 17;

			// Token: 0x04037C4C RID: 228428
			public const int MaterialHorizontalLayout = 18;

			// Token: 0x04037C4D RID: 228429
			public const int ComposeIntroduceItem = 19;

			// Token: 0x04037C4E RID: 228430
			public const int MachiningConditionItem = 20;

			// Token: 0x04037C4F RID: 228431
			public const int MachiningVerticalLayout = 21;

			// Token: 0x04037C50 RID: 228432
			public const int MachiningAttributeText = 22;

			// Token: 0x04037C51 RID: 228433
			public const int DisableButton = 23;
		}
	}
}
