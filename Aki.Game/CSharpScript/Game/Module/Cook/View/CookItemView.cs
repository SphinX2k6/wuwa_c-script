using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Cook.View
{
	// Token: 0x02005B0E RID: 23310
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class CookItemView : GridProxyAbstract<ICookItemData>
	{
		// Token: 0x0603B047 RID: 241735 RVA: 0x00E118CC File Offset: 0x00E0FACC
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

		// Token: 0x0603B048 RID: 241736 RVA: 0x00E11A1C File Offset: 0x00E0FC1C
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

		// Token: 0x0603B049 RID: 241737 RVA: 0x00E11A50 File Offset: 0x00E0FC50
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

		// Token: 0x0603B04A RID: 241738 RVA: 0x00E11A85 File Offset: 0x00E0FC85
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

		// Token: 0x0603B04B RID: 241739 RVA: 0x00E11ABC File Offset: 0x00E0FCBC
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

		// Token: 0x0603B04C RID: 241740 RVA: 0x00E11B88 File Offset: 0x00E0FD88
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

		// Token: 0x0603B04D RID: 241741 RVA: 0x00E11C54 File Offset: 0x00E0FE54
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

		// Token: 0x0603B04E RID: 241742 RVA: 0x00E11CE8 File Offset: 0x00E0FEE8
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

		// Token: 0x0603B04F RID: 241743 RVA: 0x00E11D3C File Offset: 0x00E0FF3C
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

		// Token: 0x0603B050 RID: 241744 RVA: 0x00E11DD8 File Offset: 0x00E0FFD8
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

		// Token: 0x0603B051 RID: 241745 RVA: 0x00E11E26 File Offset: 0x00E10026
		public void BindOnClickedCallback(Action<ICookingData> onItemButtonClicked)
		{
			this.OnCookingClickedCallback = onItemButtonClicked;
		}

		// Token: 0x0603B052 RID: 241746 RVA: 0x00E11E2F File Offset: 0x00E1002F
		public void BindOnClickedCallback(Action<IMachiningData> onItemButtonClicked)
		{
			this.OnMachiningClickedCallback = onItemButtonClicked;
		}

		// Token: 0x0603B053 RID: 241747 RVA: 0x00E11E38 File Offset: 0x00E10038
		public override void OnSelected(bool fireEvent)
		{
			this.Selected(true, true);
		}

		// Token: 0x0603B054 RID: 241748 RVA: 0x00E11E42 File Offset: 0x00E10042
		public override void OnDeselected(bool fireEvent)
		{
			this.Selected(false, true);
		}

		// Token: 0x0603B055 RID: 241749 RVA: 0x00E11E4C File Offset: 0x00E1004C
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

		// Token: 0x0603B056 RID: 241750 RVA: 0x00E11E7C File Offset: 0x00E1007C
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

		// Token: 0x0401ECA3 RID: 126115
		[Nullable(2)]
		private ICookingData ItemData;

		// Token: 0x0401ECA4 RID: 126116
		[Nullable(2)]
		private IMachiningData MachiningItemData;

		// Token: 0x0401ECA5 RID: 126117
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private Action<ICookingData> OnCookingClickedCallback;

		// Token: 0x0401ECA6 RID: 126118
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private Action<IMachiningData> OnMachiningClickedCallback;

		// Token: 0x0200BD4C RID: 48460
		[NullableContext(0)]
		private enum ECookItemDefine
		{
			// Token: 0x04039178 RID: 233848
			CookExtendToggle = 6,
			// Token: 0x04039179 RID: 233849
			LockItem,
			// Token: 0x0403917A RID: 233850
			ShadowItem,
			// Token: 0x0403917B RID: 233851
			NewItem,
			// Token: 0x0403917C RID: 233852
			QualitySprite,
			// Token: 0x0403917D RID: 233853
			IconTexture,
			// Token: 0x0403917E RID: 233854
			TxtName,
			// Token: 0x0403917F RID: 233855
			RedDotItem
		}
	}
}
