using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Manufacture.Compose.Item
{
	// Token: 0x0200465A RID: 18010
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class ComposeItem : GridProxyAbstract<IBaseItemData>
	{
		// Token: 0x0602D4BF RID: 185535 RVA: 0x00CAF364 File Offset: 0x00CAD564
		protected unsafe override void OnRegisterComponent()
		{
			int num = 7;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIExtendToggle));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(10, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(11, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIText));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(6, new Action<EToggleState>(this.OnItemButtonClicked));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0602D4C0 RID: 185536 RVA: 0x00CAF4B3 File Offset: 0x00CAD6B3
		public override void Refresh(IBaseItemData data, bool isSelected, int gridIndex)
		{
			this.ItemData = data;
			this.RefreshName();
			this.RefreshQuality();
			this.RefreshIcon();
			this.RefreshLock();
			this.RefreshShadow();
			this.RefreshNew();
			this.Selected(isSelected, false);
		}

		// Token: 0x0602D4C1 RID: 185537 RVA: 0x00CAF4E8 File Offset: 0x00CAD6E8
		private void RefreshName()
		{
			SynthesisFormula? synthesisFormulaById = ComposeConfig.Instance.GetSynthesisFormulaById(this.GetConfigId(this.ItemData));
			string localText = ComposeConfig.Instance.GetLocalText(synthesisFormulaById.Value.Name);
			base.GetText(12).SetText(localText, true);
		}

		// Token: 0x0602D4C2 RID: 185538 RVA: 0x00CAF538 File Offset: 0x00CAD738
		private void RefreshQuality()
		{
			switch (this.GetMainType(this.ItemData))
			{
			case EComposeListType.ReagentProduction:
				if (((IReagentProductionData)this.ItemData).SubType == ESubComposeDataType.ComposeMenu)
				{
					base.SetItemQualityIcon(base.GetSprite(10), this.GetConfigId(this.ItemData), null, CommonDefine.EQualityIconType.BackgroundSprite, null);
					return;
				}
				break;
			case EComposeListType.Structure:
				if (((IStructureData)this.ItemData).SubType == ESubStructureDataType.StructureMenu)
				{
					base.SetItemQualityIcon(base.GetSprite(10), this.GetConfigId(this.ItemData), null, CommonDefine.EQualityIconType.BackgroundSprite, null);
					return;
				}
				break;
			}
			SynthesisFormula? synthesisFormulaById = ComposeConfig.Instance.GetSynthesisFormulaById(this.GetConfigId(this.ItemData));
			base.SetItemQualityIcon(base.GetSprite(10), synthesisFormulaById.Value.ItemId, null, CommonDefine.EQualityIconType.BackgroundSprite, null);
		}

		// Token: 0x0602D4C3 RID: 185539 RVA: 0x00CAF624 File Offset: 0x00CAD824
		private void RefreshIcon()
		{
			switch (this.GetMainType(this.ItemData))
			{
			case EComposeListType.ReagentProduction:
				if (((IReagentProductionData)this.ItemData).SubType == ESubComposeDataType.Compose)
				{
					SynthesisFormula? synthesisFormulaById = ComposeConfig.Instance.GetSynthesisFormulaById(this.GetConfigId(this.ItemData));
					base.SetItemIcon(base.GetTexture(11), synthesisFormulaById.Value.ItemId, null, null);
					return;
				}
				base.SetItemIcon(base.GetTexture(11), this.GetConfigId(this.ItemData), null, null);
				return;
			case EComposeListType.Structure:
				if (((IStructureData)this.ItemData).SubType == ESubStructureDataType.Structure)
				{
					SynthesisFormula? synthesisFormulaById2 = ComposeConfig.Instance.GetSynthesisFormulaById(this.GetConfigId(this.ItemData));
					base.SetItemIcon(base.GetTexture(11), synthesisFormulaById2.Value.ItemId, null, null);
					return;
				}
				base.SetItemIcon(base.GetTexture(11), this.GetConfigId(this.ItemData), null, null);
				return;
			case EComposeListType.Purification:
			{
				SynthesisFormula? synthesisFormulaById3 = ComposeConfig.Instance.GetSynthesisFormulaById(this.GetConfigId(this.ItemData));
				base.SetItemIcon(base.GetTexture(11), synthesisFormulaById3.Value.ItemId, null, null);
				return;
			}
			case EComposeListType.Exchange:
				break;
			case EComposeListType.Collect:
			{
				SynthesisFormula? synthesisFormulaById4 = ComposeConfig.Instance.GetSynthesisFormulaById(this.GetConfigId(this.ItemData));
				base.SetItemIcon(base.GetTexture(11), synthesisFormulaById4.Value.ItemId, null, null);
				break;
			}
			default:
				return;
			}
		}

		// Token: 0x0602D4C4 RID: 185540 RVA: 0x00CAF7C8 File Offset: 0x00CAD9C8
		private void RefreshLock()
		{
			switch (this.GetMainType(this.ItemData))
			{
			case EComposeListType.ReagentProduction:
				base.GetItem(7).SetUIActive(false);
				return;
			case EComposeListType.Structure:
				base.GetItem(7).SetUIActive(false);
				return;
			case EComposeListType.Purification:
			{
				IPurificationData purificationData = (IPurificationData)this.ItemData;
				base.GetItem(7).SetUIActive(purificationData.IsUnlock == 0);
				return;
			}
			case EComposeListType.Exchange:
				break;
			case EComposeListType.Collect:
			{
				ICollectData collectData = (ICollectData)this.ItemData;
				base.GetItem(7).SetUIActive(collectData.IsUnlock == 0);
				break;
			}
			default:
				return;
			}
		}

		// Token: 0x0602D4C5 RID: 185541 RVA: 0x00CAF860 File Offset: 0x00CADA60
		private void RefreshShadow()
		{
			switch (this.GetMainType(this.ItemData))
			{
			case EComposeListType.ReagentProduction:
			{
				IReagentProductionData reagentProductionData = (IReagentProductionData)this.ItemData;
				if (reagentProductionData.SubType == ESubComposeDataType.ComposeMenu)
				{
					base.GetItem(8).SetUIActive(false);
					return;
				}
				bool flag = ComposeController.Instance.CheckCanReagentProduction(reagentProductionData.ConfigId);
				base.GetItem(8).SetUIActive(!flag);
				return;
			}
			case EComposeListType.Structure:
			{
				IStructureData structureData = (IStructureData)this.ItemData;
				if (structureData.SubType == ESubStructureDataType.StructureMenu)
				{
					base.GetItem(8).SetUIActive(false);
					return;
				}
				bool flag2 = ComposeController.Instance.CheckCanStructure(structureData.ConfigId);
				base.GetItem(8).SetUIActive(!flag2);
				return;
			}
			case EComposeListType.Purification:
			{
				IPurificationData purificationData = (IPurificationData)this.ItemData;
				if (ComposeModel.Instance.GetPurificationDataById(purificationData.ConfigId).IsUnlock == 0)
				{
					base.GetItem(8).SetUIActive(true);
					return;
				}
				bool flag3 = ComposeController.Instance.CheckCanPurification(purificationData.ConfigId);
				base.GetItem(8).SetUIActive(!flag3);
				return;
			}
			case EComposeListType.Exchange:
				break;
			case EComposeListType.Collect:
			{
				ICollectData collectData = (ICollectData)this.ItemData;
				if (ComposeModel.Instance.GetCollectDataById(collectData.ConfigId).IsUnlock == 0)
				{
					base.GetItem(8).SetUIActive(true);
					return;
				}
				bool flag4 = ComposeController.Instance.CheckCanCollect(collectData.ConfigId);
				base.GetItem(8).SetUIActive(!flag4);
				break;
			}
			default:
				return;
			}
		}

		// Token: 0x0602D4C6 RID: 185542 RVA: 0x00CAF9D4 File Offset: 0x00CADBD4
		private void RefreshNew()
		{
			base.GetItem(9).SetUIActive(this.GetIsNew(this.ItemData));
		}

		// Token: 0x0602D4C7 RID: 185543 RVA: 0x00CAF9EF File Offset: 0x00CADBEF
		public void BindOnClickedCallback(Action<object> onItemButtonClicked)
		{
			this.OnClickedCallback = onItemButtonClicked;
		}

		// Token: 0x0602D4C8 RID: 185544 RVA: 0x00CAF9F8 File Offset: 0x00CADBF8
		public override void OnSelected(bool fireEvent)
		{
			this.Selected(true, true);
		}

		// Token: 0x0602D4C9 RID: 185545 RVA: 0x00CAFA02 File Offset: 0x00CADC02
		public override void OnDeselected(bool fireEvent)
		{
			this.Selected(false, true);
		}

		// Token: 0x0602D4CA RID: 185546 RVA: 0x00CAFA0C File Offset: 0x00CADC0C
		private void Selected(bool bSelected, bool fire = true)
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(6);
			if (bSelected)
			{
				extendToggle.SetToggleState(EToggleState.ETT_Checked, fire, false, false);
				return;
			}
			extendToggle.SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
		}

		// Token: 0x0602D4CB RID: 185547 RVA: 0x00CAFA3B File Offset: 0x00CADC3B
		private void OnItemButtonClicked(EToggleState state)
		{
			if (this.OnClickedCallback != null)
			{
				this.OnClickedCallback(this.ItemData);
				this.RefreshNew();
			}
		}

		// Token: 0x0602D4CC RID: 185548 RVA: 0x00CAFA5C File Offset: 0x00CADC5C
		private int GetConfigId(object data)
		{
			ICollectData collectData = data as ICollectData;
			if (collectData != null)
			{
				return collectData.ConfigId;
			}
			IPurificationData purificationData = data as IPurificationData;
			if (purificationData != null)
			{
				return purificationData.ConfigId;
			}
			IReagentProductionData reagentProductionData = data as IReagentProductionData;
			if (reagentProductionData != null)
			{
				return reagentProductionData.ConfigId;
			}
			IStructureData structureData = data as IStructureData;
			if (structureData != null)
			{
				return structureData.ConfigId;
			}
			return 0;
		}

		// Token: 0x0602D4CD RID: 185549 RVA: 0x00CAFAB0 File Offset: 0x00CADCB0
		private EComposeListType GetMainType(object data)
		{
			ICollectData collectData = data as ICollectData;
			if (collectData != null)
			{
				return collectData.MainType;
			}
			IPurificationData purificationData = data as IPurificationData;
			if (purificationData != null)
			{
				return purificationData.MainType;
			}
			IReagentProductionData reagentProductionData = data as IReagentProductionData;
			if (reagentProductionData != null)
			{
				return reagentProductionData.MainType;
			}
			IStructureData structureData = data as IStructureData;
			if (structureData != null)
			{
				return structureData.MainType;
			}
			return EComposeListType.Purification;
		}

		// Token: 0x0602D4CE RID: 185550 RVA: 0x00CAFB04 File Offset: 0x00CADD04
		private bool GetIsNew(object data)
		{
			ICollectData collectData = data as ICollectData;
			if (collectData != null)
			{
				return collectData.IsNew;
			}
			IPurificationData purificationData = data as IPurificationData;
			if (purificationData != null)
			{
				return purificationData.IsNew;
			}
			IReagentProductionData reagentProductionData = data as IReagentProductionData;
			if (reagentProductionData != null)
			{
				return reagentProductionData.IsNew;
			}
			IStructureData structureData = data as IStructureData;
			return structureData != null && structureData.IsNew;
		}

		// Token: 0x0401846E RID: 99438
		[Nullable(2)]
		private IBaseItemData ItemData;

		// Token: 0x0401846F RID: 99439
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private Action<IBaseItemData> OnClickedCallback;

		// Token: 0x0200A277 RID: 41591
		[NullableContext(0)]
		private class EComposeContentItemDefine
		{
			// Token: 0x040326AF RID: 206511
			public const int ComposeExtendToggle = 6;

			// Token: 0x040326B0 RID: 206512
			public const int LockItem = 7;

			// Token: 0x040326B1 RID: 206513
			public const int ShadowItem = 8;

			// Token: 0x040326B2 RID: 206514
			public const int NewItem = 9;

			// Token: 0x040326B3 RID: 206515
			public const int QualitySprite = 10;

			// Token: 0x040326B4 RID: 206516
			public const int IconTexture = 11;

			// Token: 0x040326B5 RID: 206517
			public const int TxtName = 12;
		}
	}
}
