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
	// Token: 0x0200464B RID: 17995
	[NullableContext(1)]
	[Nullable(0)]
	public class ComposeTipsView : UiPanelBase
	{
		// Token: 0x0602D42C RID: 185388 RVA: 0x00CAB1D3 File Offset: 0x00CA93D3
		public ComposeTipsView(UUIItem uiItem)
		{
			base.CreateThenShowByActor(uiItem.GetOwner(), null);
		}

		// Token: 0x0602D42D RID: 185389 RVA: 0x00CAB1E8 File Offset: 0x00CA93E8
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

		// Token: 0x0602D42E RID: 185390 RVA: 0x00CAB48C File Offset: 0x00CA968C
		protected override void OnStart()
		{
			this.ConfirmButtonCompose = new ConfirmButtonCompose(base.GetItem(8));
			this.ConfirmButtonCompose.BindClickFunction(new Action(this.OnClickConfirmButton));
			this.MaterialHorizontal = new GenericLayoutNew<MaterialItem>(base.GetHorizontalLayout(18), new CSharpScript.Game.Module.Util.Layout.TLayoutRefresh<MaterialItem>(this.InitMaterial), null);
		}

		// Token: 0x0602D42F RID: 185391 RVA: 0x00CAB4E4 File Offset: 0x00CA96E4
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

		// Token: 0x0602D430 RID: 185392 RVA: 0x00CAB535 File Offset: 0x00CA9735
		private void OnClicked(ISingleItemInfo itemData)
		{
			if (!itemData.Proto_IsUnlock)
			{
				return;
			}
			ItemController.Instance.OpenItemTipsByItemId(itemData.Proto_ItemId, true, null, false);
		}

		// Token: 0x0602D431 RID: 185393 RVA: 0x00CAB553 File Offset: 0x00CA9753
		protected override void OnBeforeDestroy()
		{
			if (this.MaterialHorizontal != null)
			{
				this.MaterialHorizontal.ClearChildren();
				this.MaterialHorizontal = null;
			}
			this.OnDisableCallback = null;
		}

		// Token: 0x0602D432 RID: 185394 RVA: 0x00CAB578 File Offset: 0x00CA9778
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

		// Token: 0x0602D433 RID: 185395 RVA: 0x00CAB5BC File Offset: 0x00CA97BC
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

		// Token: 0x0602D434 RID: 185396 RVA: 0x00CAB600 File Offset: 0x00CA9800
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

		// Token: 0x0602D435 RID: 185397 RVA: 0x00CAB6DC File Offset: 0x00CA98DC
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

		// Token: 0x0602D436 RID: 185398 RVA: 0x00CAB810 File Offset: 0x00CA9A10
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

		// Token: 0x0602D437 RID: 185399 RVA: 0x00CAB880 File Offset: 0x00CA9A80
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

		// Token: 0x0602D438 RID: 185400 RVA: 0x00CAB8F0 File Offset: 0x00CA9AF0
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

		// Token: 0x0602D439 RID: 185401 RVA: 0x00CAB934 File Offset: 0x00CA9B34
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

		// Token: 0x0602D43A RID: 185402 RVA: 0x00CABA48 File Offset: 0x00CA9C48
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

		// Token: 0x0602D43B RID: 185403 RVA: 0x00CABB24 File Offset: 0x00CA9D24
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

		// Token: 0x0602D43C RID: 185404 RVA: 0x00CABB94 File Offset: 0x00CA9D94
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

		// Token: 0x0602D43D RID: 185405 RVA: 0x00CABC04 File Offset: 0x00CA9E04
		public void RefreshPurificationData()
		{
			IPurificationData data = (IPurificationData)this.ItemData;
			this.SetPurificationHide();
			this.RefreshPurification(data);
		}

		// Token: 0x0602D43E RID: 185406 RVA: 0x00CABC2C File Offset: 0x00CA9E2C
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

		// Token: 0x0602D43F RID: 185407 RVA: 0x00CABD8C File Offset: 0x00CA9F8C
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

		// Token: 0x0602D440 RID: 185408 RVA: 0x00CABDF9 File Offset: 0x00CA9FF9
		private void SetNameText(string name)
		{
			base.GetText(0).SetText(name, true);
		}

		// Token: 0x0602D441 RID: 185409 RVA: 0x00CABE0C File Offset: 0x00CAA00C
		private void SetIconTexture(string icon)
		{
			base.SetTextureByPath(icon, base.GetTexture(1), null, null);
		}

		// Token: 0x0602D442 RID: 185410 RVA: 0x00CABE31 File Offset: 0x00CAA031
		private void SetContentText(string text)
		{
			base.GetText(3).SetText(text, true);
		}

		// Token: 0x0602D443 RID: 185411 RVA: 0x00CABE41 File Offset: 0x00CAA041
		private void SetAttributeText(string text)
		{
			base.GetText(12).SetText(text, true);
		}

		// Token: 0x0602D444 RID: 185412 RVA: 0x00CABE52 File Offset: 0x00CAA052
		private void SetTypeNameText(string text)
		{
			base.GetText(15).SetText(text, true);
		}

		// Token: 0x0602D445 RID: 185413 RVA: 0x00CABE63 File Offset: 0x00CAA063
		private void SetHaveText(int have)
		{
			LguiUtil.Instance.SetLocalText(base.GetText(14), "Have", new <>z__ReadOnlySingleElementList<object>(have));
		}

		// Token: 0x0602D446 RID: 185414 RVA: 0x00CABE88 File Offset: 0x00CAA088
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

		// Token: 0x0602D447 RID: 185415 RVA: 0x00CABF31 File Offset: 0x00CAA131
		private void RefreshConfirmButton(string text, bool isEnable)
		{
			this.ConfirmButtonCompose.UpdateText(text);
			this.ConfirmButtonCompose.RefreshButton(isEnable);
		}

		// Token: 0x0602D448 RID: 185416 RVA: 0x00CABF4B File Offset: 0x00CAA14B
		private void RefreshDisableButton(bool isEnable)
		{
			((AUIBaseActor)base.GetButton(23).GetOwner()).GetUIItem().SetUIActive(!isEnable);
		}

		// Token: 0x0602D449 RID: 185417 RVA: 0x00CABF70 File Offset: 0x00CAA170
		private void SetMaterialList(int itemId)
		{
			this.MaterialHorizontal.RebuildLayoutByDataNew<ISingleItemInfo>(ComposeModel.Instance.GetComposeMaterialList(itemId), null);
		}

		// Token: 0x0602D44A RID: 185418 RVA: 0x00CABF9C File Offset: 0x00CAA19C
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

		// Token: 0x0602D44B RID: 185419 RVA: 0x00CAC099 File Offset: 0x00CAA299
		private void OnDisable()
		{
			if (this.OnDisableCallback != null)
			{
				this.OnDisableCallback();
			}
		}

		// Token: 0x0602D44C RID: 185420 RVA: 0x00CAC0AE File Offset: 0x00CAA2AE
		public void BindOnDisable(Action onDisable)
		{
			this.OnDisableCallback = onDisable;
		}

		// Token: 0x04018439 RID: 99385
		[Nullable(2)]
		private IBaseItemData ItemData;

		// Token: 0x0401843A RID: 99386
		[Nullable(2)]
		private ConfirmButtonCompose ConfirmButtonCompose;

		// Token: 0x0401843B RID: 99387
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericLayoutNew<MaterialItem> MaterialHorizontal;

		// Token: 0x0401843C RID: 99388
		[Nullable(2)]
		private Action OnDisableCallback;

		// Token: 0x0200A267 RID: 41575
		[NullableContext(0)]
		private class EComposeTipsDefine
		{
			// Token: 0x0403265F RID: 206431
			public const int NameText = 0;

			// Token: 0x04032660 RID: 206432
			public const int IconTexture = 1;

			// Token: 0x04032661 RID: 206433
			public const int ComposeCountText = 2;

			// Token: 0x04032662 RID: 206434
			public const int ConTentText = 3;

			// Token: 0x04032663 RID: 206435
			public const int TipsBtnItem = 6;

			// Token: 0x04032664 RID: 206436
			public const int TipsConfirmButton = 8;

			// Token: 0x04032665 RID: 206437
			public const int AttributeText = 12;

			// Token: 0x04032666 RID: 206438
			public const int HaveText = 14;

			// Token: 0x04032667 RID: 206439
			public const int TypeNameText = 15;

			// Token: 0x04032668 RID: 206440
			public const int SumText = 16;

			// Token: 0x04032669 RID: 206441
			public const int MaterialLayoutItem = 17;

			// Token: 0x0403266A RID: 206442
			public const int MaterialHorizontalLayout = 18;

			// Token: 0x0403266B RID: 206443
			public const int ComposeIntroduceItem = 19;

			// Token: 0x0403266C RID: 206444
			public const int MachiningConditionItem = 20;

			// Token: 0x0403266D RID: 206445
			public const int MachiningVerticalLayout = 21;

			// Token: 0x0403266E RID: 206446
			public const int MachiningAttributeText = 22;

			// Token: 0x0403266F RID: 206447
			public const int DisableButton = 23;
		}
	}
}
