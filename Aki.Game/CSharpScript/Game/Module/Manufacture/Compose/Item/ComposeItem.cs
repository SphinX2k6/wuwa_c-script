using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Manufacture.Compose.Item
{
	// Token: 0x02005684 RID: 22148
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class ComposeItem : GridProxyAbstract<IBaseItemData>
	{
		// Token: 0x060385C2 RID: 230850 RVA: 0x00D61214 File Offset: 0x00D5F414
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

		// Token: 0x060385C3 RID: 230851 RVA: 0x00D61363 File Offset: 0x00D5F563
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

		// Token: 0x060385C4 RID: 230852 RVA: 0x00D61398 File Offset: 0x00D5F598
		private void RefreshName()
		{
			SynthesisFormula? synthesisFormulaById = ComposeConfig.Instance.GetSynthesisFormulaById(this.GetConfigId(this.ItemData));
			string localText = ComposeConfig.Instance.GetLocalText(synthesisFormulaById.Value.Name);
			base.GetText(12).SetText(localText, true);
		}

		// Token: 0x060385C5 RID: 230853 RVA: 0x00D613E8 File Offset: 0x00D5F5E8
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

		// Token: 0x060385C6 RID: 230854 RVA: 0x00D614D4 File Offset: 0x00D5F6D4
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

		// Token: 0x060385C7 RID: 230855 RVA: 0x00D61678 File Offset: 0x00D5F878
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

		// Token: 0x060385C8 RID: 230856 RVA: 0x00D61710 File Offset: 0x00D5F910
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

		// Token: 0x060385C9 RID: 230857 RVA: 0x00D61884 File Offset: 0x00D5FA84
		private void RefreshNew()
		{
			base.GetItem(9).SetUIActive(this.GetIsNew(this.ItemData));
		}

		// Token: 0x060385CA RID: 230858 RVA: 0x00D6189F File Offset: 0x00D5FA9F
		public void BindOnClickedCallback(Action<object> onItemButtonClicked)
		{
			this.OnClickedCallback = onItemButtonClicked;
		}

		// Token: 0x060385CB RID: 230859 RVA: 0x00D618A8 File Offset: 0x00D5FAA8
		public override void OnSelected(bool fireEvent)
		{
			this.Selected(true, true);
		}

		// Token: 0x060385CC RID: 230860 RVA: 0x00D618B2 File Offset: 0x00D5FAB2
		public override void OnDeselected(bool fireEvent)
		{
			this.Selected(false, true);
		}

		// Token: 0x060385CD RID: 230861 RVA: 0x00D618BC File Offset: 0x00D5FABC
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

		// Token: 0x060385CE RID: 230862 RVA: 0x00D618EB File Offset: 0x00D5FAEB
		private void OnItemButtonClicked(EToggleState state)
		{
			if (this.OnClickedCallback != null)
			{
				this.OnClickedCallback(this.ItemData);
				this.RefreshNew();
			}
		}

		// Token: 0x060385CF RID: 230863 RVA: 0x00D6190C File Offset: 0x00D5FB0C
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

		// Token: 0x060385D0 RID: 230864 RVA: 0x00D61960 File Offset: 0x00D5FB60
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

		// Token: 0x060385D1 RID: 230865 RVA: 0x00D619B4 File Offset: 0x00D5FBB4
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

		// Token: 0x0401D9E3 RID: 121315
		[Nullable(2)]
		private IBaseItemData ItemData;

		// Token: 0x0401D9E4 RID: 121316
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private Action<IBaseItemData> OnClickedCallback;

		// Token: 0x0200B84F RID: 47183
		[NullableContext(0)]
		private class EComposeContentItemDefine
		{
			// Token: 0x04037C92 RID: 228498
			public const int ComposeExtendToggle = 6;

			// Token: 0x04037C93 RID: 228499
			public const int LockItem = 7;

			// Token: 0x04037C94 RID: 228500
			public const int ShadowItem = 8;

			// Token: 0x04037C95 RID: 228501
			public const int NewItem = 9;

			// Token: 0x04037C96 RID: 228502
			public const int QualitySprite = 10;

			// Token: 0x04037C97 RID: 228503
			public const int IconTexture = 11;

			// Token: 0x04037C98 RID: 228504
			public const int TxtName = 12;
		}
	}
}
