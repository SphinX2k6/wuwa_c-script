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
	// Token: 0x02004B0A RID: 19210
	[NullableContext(1)]
	[Nullable(0)]
	public class CookView : UiNavigationView
	{
		// Token: 0x060300E1 RID: 196833 RVA: 0x00D68244 File Offset: 0x00D66444
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
			*span2[num] = new ValueTuple<int, Delegate>(3, new Action(delegate()
			{
				this.OnConfirm();
			}));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(6, new Action(delegate()
			{
				this.OnDisableCook();
			}));
			this.BtnBindInfo = list2;
		}

		// Token: 0x060300E2 RID: 196834 RVA: 0x00D683B4 File Offset: 0x00D665B4
		protected override void OnStart()
		{
			this.OpenCookRoleButton = new OpenCookRoleButton(base.GetItem(4));
			this.OpenCookRoleButton.BindOnCallback(new Action(this.OpenCookRoleView));
			this.MaterialHorizontal = new GenericLayoutNew<MaterialItem>(base.GetHorizontalLayout(2), new CSharpScript.Game.Module.Util.Layout.TLayoutRefresh<MaterialItem>(this.InitMaterial), null);
			this.AmountItem = new AmountItem(base.GetItem(5));
			this.AmountItem.BindGetMaxCallback(new Func<int>(this.GetMaxCount));
			this.AmountItem.BindSetSumCallback(new Action<int>(this.SetSum));
			this.IconItem = new IconItem(base.GetItem(1));
		}

		// Token: 0x060300E3 RID: 196835 RVA: 0x00D6845C File Offset: 0x00D6665C
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
			materialItem.BindOnClickedCallback(new Action<ISingleItemInfo, int>(this.OnClickMaterial));
			return new LayoutItem<MaterialItem>
			{
				Key = index,
				Value = materialItem
			};
		}

		// Token: 0x060300E4 RID: 196836 RVA: 0x00D684AE File Offset: 0x00D666AE
		private int GetMaxCount()
		{
			return CookController.Instance.GetMaxCreateCount(this.ItemId, CookModel.Instance.CurrentCookListType);
		}

		// Token: 0x060300E5 RID: 196837 RVA: 0x00D684CA File Offset: 0x00D666CA
		private void SetSum(int sum)
		{
			this.Count = sum;
			this.RefreshMaterialNeedNum();
		}

		// Token: 0x060300E6 RID: 196838 RVA: 0x00D684D9 File Offset: 0x00D666D9
		protected override void OnBeforeDestroy()
		{
			this.RemoveEventListener();
			this.MaterialHorizontal.ClearChildren();
			this.MaterialHorizontal = null;
			this.AmountItem = null;
		}

		// Token: 0x060300E7 RID: 196839 RVA: 0x00D684FC File Offset: 0x00D666FC
		private void AddEventListener()
		{
			EventSystem.Instance.Add(EEventName.CookSuccess, new Action(this.OnCookSuccess));
			EventSystem.Instance.Add(EEventName.MachiningSuccess, new Action(this.OnOpenMachiningCookPopView));
			EventSystem.Instance.Add(EEventName.MachiningSuccess, new Action(this.Refresh));
			EventSystem.Instance.Add(EEventName.CloseCookRole, new Action(this.RefreshCurrentCookRole));
		}

		// Token: 0x060300E8 RID: 196840 RVA: 0x00D6857C File Offset: 0x00D6677C
		private void RemoveEventListener()
		{
			if (!this.IsFirstShow)
			{
				EventSystem.Instance.Remove(EEventName.CookSuccess, new Action(this.OnCookSuccess));
				EventSystem.Instance.Remove(EEventName.MachiningSuccess, new Action(this.OnOpenMachiningCookPopView));
				EventSystem.Instance.Remove(EEventName.MachiningSuccess, new Action(this.Refresh));
				EventSystem.Instance.Remove(EEventName.CloseCookRole, new Action(this.RefreshCurrentCookRole));
			}
		}

		// Token: 0x060300E9 RID: 196841 RVA: 0x00D68601 File Offset: 0x00D66801
		public void HideView(bool isHide)
		{
			this.SetActive(!isHide);
			if (!isHide)
			{
				CookModel.Instance.CurrentCookViewType = ECookDataType.Cook;
			}
		}

		// Token: 0x060300EA RID: 196842 RVA: 0x00D6861B File Offset: 0x00D6681B
		public void ShowView(int itemId)
		{
			CookModel.Instance.CurrentCookViewType = ECookDataType.Cook;
			this.SetActive(true);
			if (this.IsFirstShow)
			{
				this.AddEventListener();
				this.IsFirstShow = false;
			}
			this.ItemId = itemId;
			this.Refresh();
		}

		// Token: 0x060300EB RID: 196843 RVA: 0x00D68654 File Offset: 0x00D66854
		private void Refresh()
		{
			if (!base.GetActive())
			{
				return;
			}
			if (CookModel.Instance.CurrentCookListType == ECookListType.Cooking)
			{
				this.RoleId = CookModel.Instance.GetCookRoleId(this.ItemId);
				CookModel.Instance.CurrentCookRoleId = new int?(this.RoleId);
				this.CookFormula = new CookFormula?(CookConfig.Instance.GetCookFormulaById(this.ItemId));
			}
			else
			{
				this.CookProcessed = new CookProcessed?(CookConfig.Instance.GetCookProcessedById(this.ItemId));
			}
			this.Count = 1;
			this.RefreshText();
			this.RefreshItemIcon();
			this.RefreshOpenCookRoleButton();
			this.RefreshMaterialList();
			this.RefreshConfirmButton();
			this.RefreshAmountItem();
		}

		// Token: 0x060300EC RID: 196844 RVA: 0x00D68704 File Offset: 0x00D66904
		private void RefreshText()
		{
			string name;
			if (CookModel.Instance.CurrentCookListType == ECookListType.Cooking)
			{
				name = this.CookFormula.Value.Name;
				base.GetText(0).ShowTextNew(name);
				return;
			}
			name = this.CookProcessed.Value.Name;
			base.GetText(0).ShowTextNew(name);
		}

		// Token: 0x060300ED RID: 196845 RVA: 0x00D68764 File Offset: 0x00D66964
		private void RefreshItemIcon()
		{
			int? num = null;
			if (CookModel.Instance.CurrentCookListType == ECookListType.Cooking)
			{
				num = new int?(this.CookFormula.Value.FoodItemId);
			}
			else
			{
				num = new int?(this.CookProcessed.Value.FinalItemId);
			}
			this.IconItem.SetIcon(num.Value);
			this.IconItem.SetQuality(num.Value);
		}

		// Token: 0x060300EE RID: 196846 RVA: 0x00D687E0 File Offset: 0x00D669E0
		private void RefreshOpenCookRoleButton()
		{
			if (CookModel.Instance.CurrentCookListType == ECookListType.Cooking)
			{
				this.OpenCookRoleButton.SetActive(true);
				this.OpenCookRoleButton.RefreshIcon(this.RoleId);
				this.OpenCookRoleButton.RefreshRedDot(this.RoleId, this.ItemId);
				return;
			}
			this.OpenCookRoleButton.SetActive(false);
		}

		// Token: 0x060300EF RID: 196847 RVA: 0x00D6883C File Offset: 0x00D66A3C
		private void RefreshCurrentCookRole()
		{
			this.RoleId = CookModel.Instance.CurrentCookRoleId.Value;
			this.RefreshOpenCookRoleButton();
		}

		// Token: 0x060300F0 RID: 196848 RVA: 0x00D68868 File Offset: 0x00D66A68
		private void RefreshMaterialList()
		{
			List<ISingleItemInfo> cookMaterialList = CookModel.Instance.GetCookMaterialList(this.ItemId, CookModel.Instance.CurrentCookListType);
			this.MaterialHorizontal.RebuildLayoutByDataNew<ISingleItemInfo>(cookMaterialList, null);
		}

		// Token: 0x060300F1 RID: 196849 RVA: 0x00D688A8 File Offset: 0x00D66AA8
		private void RefreshMaterialNeedNum()
		{
			foreach (MaterialItem materialItem in this.MaterialHorizontal.GetLayoutItemMap().Values)
			{
				materialItem.RefreshNeed(this.Count);
			}
		}

		// Token: 0x060300F2 RID: 196850 RVA: 0x00D68908 File Offset: 0x00D66B08
		private void RefreshConfirmButton()
		{
			UUIInteractionGroup uuiinteractionGroup = (base.GetButton(3).GetOwner() as AUIBaseActor).GetComponentByClass(UUIInteractionGroup.StaticClass()) as UUIInteractionGroup;
			AUIBaseActor auibaseActor = base.GetButton(6).GetOwner() as AUIBaseActor;
			if (CookModel.Instance.CurrentCookListType == ECookListType.Cooking)
			{
				bool flag = CookController.Instance.CheckCanCook(this.ItemId);
				uuiinteractionGroup.SetInteractable(flag);
				auibaseActor.GetUIItem().SetUIActive(!flag);
				return;
			}
			bool flag2 = CookController.Instance.CheckCanProcessed(this.ItemId);
			uuiinteractionGroup.SetInteractable(flag2);
			auibaseActor.GetUIItem().SetUIActive(!flag2);
		}

		// Token: 0x060300F3 RID: 196851 RVA: 0x00D689A8 File Offset: 0x00D66BA8
		private void RefreshAmountItem()
		{
			this.AmountItem.ResetSum();
			this.AmountItem.RefreshAddAndDelButton();
		}

		// Token: 0x060300F4 RID: 196852 RVA: 0x00D689C0 File Offset: 0x00D66BC0
		private void OpenCookRoleView()
		{
			EventSystem.Instance.Emit<int>(EEventName.OpenCookRole, this.ItemId);
		}

		// Token: 0x060300F5 RID: 196853 RVA: 0x00D689D8 File Offset: 0x00D66BD8
		private void OnConfirm()
		{
			if (CookModel.Instance.CurrentCookListType == ECookListType.Cooking)
			{
				CookModel.Instance.CleanAddExp();
				CookController.Instance.SendCookFoodRequest(this.ItemId, this.RoleId, this.Count);
				return;
			}
			CookController.Instance.SendFoodProcessRequest(this.ItemId, CookModel.Instance.GetTmpMachiningItemList(), this.Count);
		}

		// Token: 0x060300F6 RID: 196854 RVA: 0x00D68A38 File Offset: 0x00D66C38
		private void OnDisableCook()
		{
			GenericPromptController.Instance.ShowPromptByCode("MaterialShort", Array.Empty<object>());
		}

		// Token: 0x060300F7 RID: 196855 RVA: 0x00D68A4E File Offset: 0x00D66C4E
		private void OnClickMaterial(ISingleItemInfo itemData, int _)
		{
			ItemController.Instance.OpenItemTipsByItemId(itemData.Proto_ItemId, true, null, false);
		}

		// Token: 0x060300F8 RID: 196856 RVA: 0x00D68A63 File Offset: 0x00D66C63
		private void OnCookSuccess()
		{
			this.Refresh();
		}

		// Token: 0x060300F9 RID: 196857 RVA: 0x00D68A6C File Offset: 0x00D66C6C
		private void OnOpenMachiningCookPopView()
		{
			if (!base.GetActive())
			{
				return;
			}
			CookRewardPopData cookRewardPopData = new CookRewardPopData();
			cookRewardPopData.CookRewardPopType = ECookPopType.Machining;
			UiManager.Instance.OpenView(EUiViewName.CookSuccessView, cookRewardPopData, null);
		}

		// Token: 0x060300FA RID: 196858 RVA: 0x00D68AA0 File Offset: 0x00D66CA0
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

		// Token: 0x040197AB RID: 104363
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericLayoutNew<MaterialItem> MaterialHorizontal;

		// Token: 0x040197AC RID: 104364
		[Nullable(2)]
		private OpenCookRoleButton OpenCookRoleButton;

		// Token: 0x040197AD RID: 104365
		[Nullable(2)]
		private IconItem IconItem;

		// Token: 0x040197AE RID: 104366
		[Nullable(2)]
		private AmountItem AmountItem;

		// Token: 0x040197AF RID: 104367
		private bool IsFirstShow = true;

		// Token: 0x040197B0 RID: 104368
		private int ItemId;

		// Token: 0x040197B1 RID: 104369
		private int RoleId;

		// Token: 0x040197B2 RID: 104370
		private int Count = 1;

		// Token: 0x040197B3 RID: 104371
		private CookFormula? CookFormula;

		// Token: 0x040197B4 RID: 104372
		private CookProcessed? CookProcessed;

		// Token: 0x0200A76F RID: 42863
		[NullableContext(0)]
		public enum ECookViewDefine
		{
			// Token: 0x04033BDE RID: 211934
			CookNameText,
			// Token: 0x04033BDF RID: 211935
			CookIconItem,
			// Token: 0x04033BE0 RID: 211936
			CookMaterialHorizontalLayout,
			// Token: 0x04033BE1 RID: 211937
			CookConfirmButton,
			// Token: 0x04033BE2 RID: 211938
			CookRoleItem,
			// Token: 0x04033BE3 RID: 211939
			AmountItem,
			// Token: 0x04033BE4 RID: 211940
			CookDefaultButton
		}
	}
}
