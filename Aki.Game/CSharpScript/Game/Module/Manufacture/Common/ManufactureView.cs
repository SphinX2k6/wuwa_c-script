using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.GenericPrompt;
using CSharpScript.Game.Module.Item;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Module.Util.Layout;
using UnrealEngine;

namespace CSharpScript.Game.Module.Manufacture.Common
{
	// Token: 0x02005698 RID: 22168
	[NullableContext(1)]
	[Nullable(0)]
	public class ManufactureView : UiNavigationView
	{
		// Token: 0x06038685 RID: 231045 RVA: 0x00D641F4 File Offset: 0x00D623F4
		protected unsafe override void OnRegisterComponent()
		{
			int num = 7;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIHorizontalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIButtonComponent));
			this.ComponentRegisterInfos = list;
			num2 = 2;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(3, new Action(this.OnConfirm));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(6, new Action(this.OnDisable));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06038686 RID: 231046 RVA: 0x00D64364 File Offset: 0x00D62564
		protected override void OnStart()
		{
			this.OpenHelpRoleButton = new OpenHelpRoleButton(base.GetItem(4));
			this.OpenHelpRoleButton.BindOnCallback(new Action(this.OpenHelpRoleView));
			this.MaterialHorizontal = new GenericLayoutNew<MaterialItem>(base.GetHorizontalLayout(2), new CSharpScript.Game.Module.Util.Layout.TLayoutRefresh<MaterialItem>(this.InitMaterial), null);
			if (CommonManager.Instance.CheckShowAmountItem().GetValueOrDefault())
			{
				base.GetItem(5).SetUIActive(true);
				this.AmountItem = new AmountItem(base.GetItem(5));
				this.AmountItem.BindGetMaxCallback(new Func<int>(this.GetMaxCount));
				this.AmountItem.BindSetSumCallback(new Action<int>(this.SetSum));
			}
			else
			{
				base.GetItem(5).SetUIActive(false);
			}
			this.IconItem = new IconItem(base.GetItem(1));
		}

		// Token: 0x06038687 RID: 231047 RVA: 0x00D6443C File Offset: 0x00D6263C
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
			materialItem.BindOnClickedCallback(new Action<ISingleItemInfo>(this.OnClickMaterial));
			return new LayoutItem<MaterialItem>
			{
				Key = index,
				Value = materialItem
			};
		}

		// Token: 0x06038688 RID: 231048 RVA: 0x00D6448D File Offset: 0x00D6268D
		private int GetMaxCount()
		{
			return CommonManager.Instance.GetMaxCreateCount(this.ItemId);
		}

		// Token: 0x06038689 RID: 231049 RVA: 0x00D6449F File Offset: 0x00D6269F
		private void SetSum(int sum)
		{
			this.Count = sum;
			this.RefreshMaterialNeedNum();
		}

		// Token: 0x0603868A RID: 231050 RVA: 0x00D644AE File Offset: 0x00D626AE
		protected override void OnBeforeDestroy()
		{
			this.RemoveEventListener();
			this.MaterialHorizontal.ClearChildren();
			this.MaterialHorizontal = null;
			this.AmountItem = null;
		}

		// Token: 0x0603868B RID: 231051 RVA: 0x00D644D0 File Offset: 0x00D626D0
		private void AddEventListener()
		{
			EventSystem.Instance.Add(EEventName.ComposeSuccess, new Action(this.OnComposeOpenRewardPopView));
			EventSystem.Instance.Add(EEventName.ComposeSuccess, new Action(this.Refresh));
			EventSystem.Instance.Add(EEventName.ForgingSuccess, new Action(this.OnForgingOpenRewardPopView));
			EventSystem.Instance.Add(EEventName.ForgingSuccess, new Action(this.Refresh));
			EventSystem.Instance.Add(EEventName.CloseHelpRole, new Action(this.RefreshCurrentRole));
		}

		// Token: 0x0603868C RID: 231052 RVA: 0x00D6456C File Offset: 0x00D6276C
		private void RemoveEventListener()
		{
			if (!this.IsFirstShow)
			{
				EventSystem.Instance.Remove(EEventName.ComposeSuccess, new Action(this.OnComposeOpenRewardPopView));
				EventSystem.Instance.Remove(EEventName.ComposeSuccess, new Action(this.Refresh));
				EventSystem.Instance.Remove(EEventName.ForgingSuccess, new Action(this.OnForgingOpenRewardPopView));
				EventSystem.Instance.Remove(EEventName.ForgingSuccess, new Action(this.Refresh));
				EventSystem.Instance.Remove(EEventName.CloseHelpRole, new Action(this.RefreshCurrentRole));
			}
		}

		// Token: 0x0603868D RID: 231053 RVA: 0x00D64610 File Offset: 0x00D62810
		public void HideView(bool isHide)
		{
			this.SetActive(!isHide);
			if (!isHide)
			{
				EventSystem.Instance.Emit<EViewType>(EEventName.SwitchViewType, EViewType.ManufactureViewType);
			}
		}

		// Token: 0x0603868E RID: 231054 RVA: 0x00D64630 File Offset: 0x00D62830
		public void ShowView(int itemId)
		{
			EventSystem.Instance.Emit<EViewType>(EEventName.SwitchViewType, EViewType.ManufactureViewType);
			this.SetActive(true);
			if (this.IsFirstShow)
			{
				this.AddEventListener();
				this.IsFirstShow = false;
			}
			this.ItemId = itemId;
			this.Refresh();
		}

		// Token: 0x0603868F RID: 231055 RVA: 0x00D6466C File Offset: 0x00D6286C
		private void Refresh()
		{
			if (!base.GetActive())
			{
				return;
			}
			CommonManager.Instance.SetCurrentRoleId(CommonManager.Instance.GetManufactureRoleId(this.ItemId).Value);
			this.Count = 1;
			this.RefreshText();
			this.RefreshItemIcon();
			this.RefreshOpenRoleButton();
			this.RefreshMaterialList();
			this.RefreshConfirmButton();
			this.RefreshAmountItem();
		}

		// Token: 0x06038690 RID: 231056 RVA: 0x00D646D0 File Offset: 0x00D628D0
		private void RefreshText()
		{
			string commonManufactureText = CommonManager.Instance.GetCommonManufactureText(this.ItemId);
			base.GetText(0).SetText(commonManufactureText, true);
		}

		// Token: 0x06038691 RID: 231057 RVA: 0x00D646FC File Offset: 0x00D628FC
		private void RefreshItemIcon()
		{
			int value = CommonManager.Instance.GetCommonManufactureId(this.ItemId).Value;
			this.IconItem.SetIcon(value);
			this.IconItem.SetQuality(value);
		}

		// Token: 0x06038692 RID: 231058 RVA: 0x00D6473C File Offset: 0x00D6293C
		private void RefreshOpenRoleButton()
		{
			if (CommonManager.Instance.CheckShowRoleView().GetValueOrDefault())
			{
				this.OpenHelpRoleButton.SetActive(true);
				this.OpenHelpRoleButton.RefreshIcon();
				this.OpenHelpRoleButton.RefreshRedDot(this.ItemId);
				return;
			}
			this.OpenHelpRoleButton.SetActive(false);
		}

		// Token: 0x06038693 RID: 231059 RVA: 0x00D64792 File Offset: 0x00D62992
		private void RefreshCurrentRole()
		{
			this.RefreshOpenRoleButton();
		}

		// Token: 0x06038694 RID: 231060 RVA: 0x00D6479C File Offset: 0x00D6299C
		private void RefreshMaterialList()
		{
			this.MaterialHorizontal.RebuildLayoutByDataNew<ISingleItemInfo>(CommonManager.Instance.GetManufactureMaterialList(this.ItemId), null);
		}

		// Token: 0x06038695 RID: 231061 RVA: 0x00D647D0 File Offset: 0x00D629D0
		private void RefreshMaterialNeedNum()
		{
			foreach (MaterialItem materialItem in this.MaterialHorizontal.GetLayoutItemMap().Values)
			{
				materialItem.RefreshNeed(this.Count);
			}
		}

		// Token: 0x06038696 RID: 231062 RVA: 0x00D64830 File Offset: 0x00D62A30
		private void RefreshConfirmButton()
		{
			UUIInteractionGroup uuiinteractionGroup = (base.GetButton(3).GetOwner() as AUIBaseActor).GetComponentByClass(UUIInteractionGroup.StaticClass()) as UUIInteractionGroup;
			AUIBaseActor auibaseActor = base.GetButton(6).GetOwner() as AUIBaseActor;
			bool valueOrDefault = CommonManager.Instance.CheckCanManufacture(this.ItemId).GetValueOrDefault();
			uuiinteractionGroup.SetInteractable(valueOrDefault);
			auibaseActor.GetUIItem().SetUIActive(!valueOrDefault);
		}

		// Token: 0x06038697 RID: 231063 RVA: 0x00D648A2 File Offset: 0x00D62AA2
		private void RefreshAmountItem()
		{
			if (this.AmountItem == null)
			{
				return;
			}
			this.AmountItem.ResetSum();
			this.AmountItem.RefreshAddAndDelButton();
		}

		// Token: 0x06038698 RID: 231064 RVA: 0x00D648C3 File Offset: 0x00D62AC3
		private void OpenHelpRoleView()
		{
			EventSystem.Instance.Emit<int>(EEventName.OpenHelpRole, this.ItemId);
		}

		// Token: 0x06038699 RID: 231065 RVA: 0x00D648DB File Offset: 0x00D62ADB
		private void OnConfirm()
		{
			CommonManager.Instance.SendManufacture(this.ItemId, this.Count);
		}

		// Token: 0x0603869A RID: 231066 RVA: 0x00D648F3 File Offset: 0x00D62AF3
		private void OnDisable()
		{
			GenericPromptController.Instance.ShowPromptByCode("MaterialShort", Array.Empty<object>());
		}

		// Token: 0x0603869B RID: 231067 RVA: 0x00D64909 File Offset: 0x00D62B09
		private void OnClickMaterial(ISingleItemInfo itemData)
		{
			ItemController.Instance.OpenItemTipsByItemId(itemData.Proto_ItemId, true, null);
		}

		// Token: 0x0603869C RID: 231068 RVA: 0x00D6491D File Offset: 0x00D62B1D
		private void OnForgingOpenRewardPopView()
		{
		}

		// Token: 0x0603869D RID: 231069 RVA: 0x00D6491F File Offset: 0x00D62B1F
		private void OnComposeOpenRewardPopView()
		{
		}

		// Token: 0x0603869E RID: 231070 RVA: 0x00D64924 File Offset: 0x00D62B24
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public override UUIItem[] GetGuideUiItemAndUiItemForShowEx(string[] configParams)
		{
			UUIItem guideUiItem = base.GetGuideUiItem(configParams[1]);
			if (guideUiItem == null)
			{
				return null;
			}
			return new UUIItem[]
			{
				guideUiItem,
				guideUiItem
			};
		}

		// Token: 0x0401DA1E RID: 121374
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericLayoutNew<MaterialItem> MaterialHorizontal;

		// Token: 0x0401DA1F RID: 121375
		[Nullable(2)]
		private OpenHelpRoleButton OpenHelpRoleButton;

		// Token: 0x0401DA20 RID: 121376
		[Nullable(2)]
		private AmountItem AmountItem;

		// Token: 0x0401DA21 RID: 121377
		[Nullable(2)]
		private IconItem IconItem;

		// Token: 0x0401DA22 RID: 121378
		private bool IsFirstShow = true;

		// Token: 0x0401DA23 RID: 121379
		private int ItemId;

		// Token: 0x0401DA24 RID: 121380
		private int Count = 1;

		// Token: 0x0200B85A RID: 47194
		[NullableContext(0)]
		private class EManufactureViewDefine
		{
			// Token: 0x04037CCA RID: 228554
			public const int ManufactureNameText = 0;

			// Token: 0x04037CCB RID: 228555
			public const int ManufactureIconItem = 1;

			// Token: 0x04037CCC RID: 228556
			public const int ManufactureMaterialHorizontalLayout = 2;

			// Token: 0x04037CCD RID: 228557
			public const int ManufactureConfirmButton = 3;

			// Token: 0x04037CCE RID: 228558
			public const int ManufactureRoleItem = 4;

			// Token: 0x04037CCF RID: 228559
			public const int AmountItem = 5;

			// Token: 0x04037CD0 RID: 228560
			public const int ManufactureDefaultButton = 6;
		}
	}
}
