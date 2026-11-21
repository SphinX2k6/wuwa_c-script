using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Cook.View
{
	// Token: 0x02004AEF RID: 19183
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class CookItemView : GridProxyAbstract<ICookItemData>
	{
		// Token: 0x0602FFB9 RID: 196537 RVA: 0x00D625E4 File Offset: 0x00D607E4
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

		// Token: 0x0602FFBA RID: 196538 RVA: 0x00D62734 File Offset: 0x00D60934
		public override void Refresh(ICookItemData data, bool isSelected, int gridIndex)
		{
			ICookingData cookingData = data as ICookingData;
			if (cookingData != null)
			{
				this.Refresh(cookingData, isSelected, gridIndex);
				return;
			}
			IMachiningData machiningData = data as IMachiningData;
			if (machiningData != null)
			{
				this.Refresh(machiningData, isSelected, gridIndex);
			}
		}

		// Token: 0x0602FFBB RID: 196539 RVA: 0x00D62768 File Offset: 0x00D60968
		public void Refresh(ICookingData data, bool isSelected, int gridIndex)
		{
			this.ItemData = data;
			this.RefreshQuality();
			this.RefreshIcon();
			this.RefreshLock();
			this.RefreshShadow();
			this.RefreshNew();
			this.RefreshName();
			this.Selected(isSelected, false);
		}

		// Token: 0x0602FFBC RID: 196540 RVA: 0x00D6279D File Offset: 0x00D6099D
		public void Refresh(IMachiningData data, bool isSelected, int gridIndex)
		{
			this.MachiningItemData = data;
			this.RefreshQuality();
			this.RefreshIcon();
			this.RefreshLock();
			this.RefreshShadow();
			this.RefreshNew();
			this.RefreshName();
			this.Selected(isSelected, false);
		}

		// Token: 0x0602FFBD RID: 196541 RVA: 0x00D627D4 File Offset: 0x00D609D4
		private void RefreshQuality()
		{
			if (this.ItemData != null)
			{
				if (this.ItemData.MainType == ECookListType.Cooking)
				{
					if (this.ItemData.SubType == ESubCookDataType.CookFood)
					{
						CookFormula cookFormulaById = CookConfig.Instance.GetCookFormulaById(this.ItemData.ItemId);
						base.SetItemQualityIcon(base.GetSprite(10), cookFormulaById.FoodItemId, null, CommonDefine.EQualityIconType.BackgroundSprite, null);
						return;
					}
					base.SetItemQualityIcon(base.GetSprite(10), this.ItemData.ItemId, null, CommonDefine.EQualityIconType.BackgroundSprite, null);
					return;
				}
			}
			else if (this.MachiningItemData != null)
			{
				CookProcessed cookProcessedById = CookConfig.Instance.GetCookProcessedById(this.MachiningItemData.ItemId);
				base.SetItemQualityIcon(base.GetSprite(10), cookProcessedById.FinalItemId, null, CommonDefine.EQualityIconType.BackgroundSprite, null);
			}
		}

		// Token: 0x0602FFBE RID: 196542 RVA: 0x00D628A0 File Offset: 0x00D60AA0
		private void RefreshIcon()
		{
			if (this.ItemData != null)
			{
				if (this.ItemData.MainType == ECookListType.Cooking)
				{
					if (this.ItemData.SubType == ESubCookDataType.CookFood)
					{
						CookFormula cookFormulaById = CookConfig.Instance.GetCookFormulaById(this.ItemData.ItemId);
						base.SetItemIcon(base.GetTexture(11), cookFormulaById.FoodItemId, null, null);
						return;
					}
					base.SetItemIcon(base.GetTexture(11), this.ItemData.ItemId, null, null);
					return;
				}
			}
			else if (this.MachiningItemData != null)
			{
				CookProcessed cookProcessedById = CookConfig.Instance.GetCookProcessedById(this.MachiningItemData.ItemId);
				base.SetItemIcon(base.GetTexture(11), cookProcessedById.FinalItemId, null, null);
			}
		}

		// Token: 0x0602FFBF RID: 196543 RVA: 0x00D6296C File Offset: 0x00D60B6C
		private void RefreshName()
		{
			if (this.ItemData != null)
			{
				if (this.ItemData.MainType == ECookListType.Cooking)
				{
					CookFormula cookFormulaById = CookConfig.Instance.GetCookFormulaById(this.ItemData.ItemId);
					LguiUtil.Instance.SetLocalTextNew(base.GetText(12), cookFormulaById.Name, Array.Empty<object>());
					return;
				}
			}
			else if (this.MachiningItemData != null)
			{
				CookProcessed cookProcessedById = CookConfig.Instance.GetCookProcessedById(this.MachiningItemData.ItemId);
				LguiUtil.Instance.SetLocalTextNew(base.GetText(12), cookProcessedById.Name, Array.Empty<object>());
			}
		}

		// Token: 0x0602FFC0 RID: 196544 RVA: 0x00D62A00 File Offset: 0x00D60C00
		private void RefreshLock()
		{
			if (this.MachiningItemData != null)
			{
				base.GetItem(7).SetUIActive(!this.MachiningItemData.IsUnLock);
				return;
			}
			if (this.ItemData != null)
			{
				base.GetItem(7).SetUIActive(!this.ItemData.IsUnLock);
			}
		}

		// Token: 0x0602FFC1 RID: 196545 RVA: 0x00D62A54 File Offset: 0x00D60C54
		private void RefreshShadow()
		{
			if (this.MachiningItemData != null)
			{
				bool flag = CookController.Instance.CheckCanProcessed(this.MachiningItemData.ItemId) && this.MachiningItemData.IsUnLock;
				base.GetItem(8).SetUIActive(!flag);
				return;
			}
			if (this.ItemData != null)
			{
				if (this.ItemData.SubType == ESubCookDataType.CookMenu)
				{
					base.GetItem(8).SetUIActive(false);
					return;
				}
				bool flag2 = CookController.Instance.CheckCanCook(this.ItemData.ItemId);
				base.GetItem(8).SetUIActive(!flag2);
			}
		}

		// Token: 0x0602FFC2 RID: 196546 RVA: 0x00D62AF0 File Offset: 0x00D60CF0
		private void RefreshNew()
		{
			if (this.ItemData != null)
			{
				base.GetItem(9).SetUIActive(this.ItemData.IsNew);
				return;
			}
			if (this.MachiningItemData != null)
			{
				base.GetItem(9).SetUIActive(this.MachiningItemData.IsNew);
			}
		}

		// Token: 0x0602FFC3 RID: 196547 RVA: 0x00D62B3E File Offset: 0x00D60D3E
		public void BindOnClickedCallback(Action<ICookingData> onItemButtonClicked)
		{
			this.OnCookingClickedCallback = onItemButtonClicked;
		}

		// Token: 0x0602FFC4 RID: 196548 RVA: 0x00D62B47 File Offset: 0x00D60D47
		public void BindOnClickedCallback(Action<IMachiningData> onItemButtonClicked)
		{
			this.OnMachiningClickedCallback = onItemButtonClicked;
		}

		// Token: 0x0602FFC5 RID: 196549 RVA: 0x00D62B50 File Offset: 0x00D60D50
		public override void OnSelected(bool fireEvent)
		{
			this.Selected(true, true);
		}

		// Token: 0x0602FFC6 RID: 196550 RVA: 0x00D62B5A File Offset: 0x00D60D5A
		public override void OnDeselected(bool fireEvent)
		{
			this.Selected(false, true);
		}

		// Token: 0x0602FFC7 RID: 196551 RVA: 0x00D62B64 File Offset: 0x00D60D64
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

		// Token: 0x0602FFC8 RID: 196552 RVA: 0x00D62B94 File Offset: 0x00D60D94
		private void OnItemButtonClicked(EToggleState state)
		{
			if (this.ItemData != null && this.OnCookingClickedCallback != null)
			{
				this.OnCookingClickedCallback(this.ItemData);
				this.RefreshNew();
				return;
			}
			if (this.MachiningItemData != null && this.OnMachiningClickedCallback != null)
			{
				this.OnMachiningClickedCallback(this.MachiningItemData);
				this.RefreshNew();
			}
		}

		// Token: 0x0401975F RID: 104287
		[Nullable(2)]
		private ICookingData ItemData;

		// Token: 0x04019760 RID: 104288
		[Nullable(2)]
		private IMachiningData MachiningItemData;

		// Token: 0x04019761 RID: 104289
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private Action<ICookingData> OnCookingClickedCallback;

		// Token: 0x04019762 RID: 104290
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private Action<IMachiningData> OnMachiningClickedCallback;

		// Token: 0x0200A755 RID: 42837
		[NullableContext(0)]
		private enum ECookItemDefine
		{
			// Token: 0x04033B44 RID: 211780
			CookExtendToggle = 6,
			// Token: 0x04033B45 RID: 211781
			LockItem,
			// Token: 0x04033B46 RID: 211782
			ShadowItem,
			// Token: 0x04033B47 RID: 211783
			NewItem,
			// Token: 0x04033B48 RID: 211784
			QualitySprite,
			// Token: 0x04033B49 RID: 211785
			IconTexture,
			// Token: 0x04033B4A RID: 211786
			TxtName,
			// Token: 0x04033B4B RID: 211787
			RedDotItem
		}
	}
}
