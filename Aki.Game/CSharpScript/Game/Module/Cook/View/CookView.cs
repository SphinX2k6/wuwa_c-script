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
	// Token: 0x02005B29 RID: 23337
	[NullableContext(1)]
	[Nullable(0)]
	public class CookView : UiNavigationView
	{
		// Token: 0x0603B16F RID: 242031 RVA: 0x00E1752C File Offset: 0x00E1572C
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

		// Token: 0x0603B170 RID: 242032 RVA: 0x00E1769C File Offset: 0x00E1589C
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

		// Token: 0x0603B171 RID: 242033 RVA: 0x00E17744 File Offset: 0x00E15944
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

		// Token: 0x0603B172 RID: 242034 RVA: 0x00E17796 File Offset: 0x00E15996
		private int GetMaxCount()
		{
			return CookController.Instance.GetMaxCreateCount(this.ItemId, CookModel.Instance.CurrentCookListType);
		}

		// Token: 0x0603B173 RID: 242035 RVA: 0x00E177B2 File Offset: 0x00E159B2
		private void SetSum(int sum)
		{
			this.Count = sum;
			this.RefreshMaterialNeedNum();
		}

		// Token: 0x0603B174 RID: 242036 RVA: 0x00E177C1 File Offset: 0x00E159C1
		protected override void OnBeforeDestroy()
		{
			this.RemoveEventListener();
			this.MaterialHorizontal.ClearChildren();
			this.MaterialHorizontal = null;
			this.AmountItem = null;
		}

		// Token: 0x0603B175 RID: 242037 RVA: 0x00E177E4 File Offset: 0x00E159E4
		private void AddEventListener()
		{
			EventSystem.Instance.Add(EEventName.CookSuccess, new Action(this.OnCookSuccess));
			EventSystem.Instance.Add(EEventName.MachiningSuccess, new Action(this.OnOpenMachiningCookPopView));
			EventSystem.Instance.Add(EEventName.MachiningSuccess, new Action(this.Refresh));
			EventSystem.Instance.Add(EEventName.CloseCookRole, new Action(this.RefreshCurrentCookRole));
		}

		// Token: 0x0603B176 RID: 242038 RVA: 0x00E17864 File Offset: 0x00E15A64
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

		// Token: 0x0603B177 RID: 242039 RVA: 0x00E178E9 File Offset: 0x00E15AE9
		public void HideView(bool isHide)
		{
			this.SetActive(!isHide);
			if (!isHide)
			{
				CookModel.Instance.CurrentCookViewType = ECookDataType.Cook;
			}
		}

		// Token: 0x0603B178 RID: 242040 RVA: 0x00E17903 File Offset: 0x00E15B03
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

		// Token: 0x0603B179 RID: 242041 RVA: 0x00E1793C File Offset: 0x00E15B3C
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

		// Token: 0x0603B17A RID: 242042 RVA: 0x00E179EC File Offset: 0x00E15BEC
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

		// Token: 0x0603B17B RID: 242043 RVA: 0x00E17A4C File Offset: 0x00E15C4C
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

		// Token: 0x0603B17C RID: 242044 RVA: 0x00E17AC8 File Offset: 0x00E15CC8
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

		// Token: 0x0603B17D RID: 242045 RVA: 0x00E17B24 File Offset: 0x00E15D24
		private void RefreshCurrentCookRole()
		{
			this.RoleId = CookModel.Instance.CurrentCookRoleId.Value;
			this.RefreshOpenCookRoleButton();
		}

		// Token: 0x0603B17E RID: 242046 RVA: 0x00E17B50 File Offset: 0x00E15D50
		private void RefreshMaterialList()
		{
			List<ISingleItemInfo> cookMaterialList = CookModel.Instance.GetCookMaterialList(this.ItemId, CookModel.Instance.CurrentCookListType);
			this.MaterialHorizontal.RebuildLayoutByDataNew<ISingleItemInfo>(cookMaterialList, null);
		}

		// Token: 0x0603B17F RID: 242047 RVA: 0x00E17B90 File Offset: 0x00E15D90
		private void RefreshMaterialNeedNum()
		{
			foreach (MaterialItem materialItem in this.MaterialHorizontal.GetLayoutItemMap().Values)
			{
				materialItem.RefreshNeed(this.Count);
			}
		}

		// Token: 0x0603B180 RID: 242048 RVA: 0x00E17BF0 File Offset: 0x00E15DF0
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

		// Token: 0x0603B181 RID: 242049 RVA: 0x00E17C90 File Offset: 0x00E15E90
		private void RefreshAmountItem()
		{
			this.AmountItem.ResetSum();
			this.AmountItem.RefreshAddAndDelButton();
		}

		// Token: 0x0603B182 RID: 242050 RVA: 0x00E17CA8 File Offset: 0x00E15EA8
		private void OpenCookRoleView()
		{
			EventSystem.Instance.Emit<int>(EEventName.OpenCookRole, this.ItemId);
		}

		// Token: 0x0603B183 RID: 242051 RVA: 0x00E17CC0 File Offset: 0x00E15EC0
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

		// Token: 0x0603B184 RID: 242052 RVA: 0x00E17D20 File Offset: 0x00E15F20
		private void OnDisableCook()
		{
			GenericPromptController.Instance.ShowPromptByCode("MaterialShort", Array.Empty<object>());
		}

		// Token: 0x0603B185 RID: 242053 RVA: 0x00E17D36 File Offset: 0x00E15F36
		private void OnClickMaterial(ISingleItemInfo itemData, int _)
		{
			ItemController.Instance.OpenItemTipsByItemId(itemData.Proto_ItemId, true, null);
		}

		// Token: 0x0603B186 RID: 242054 RVA: 0x00E17D4A File Offset: 0x00E15F4A
		private void OnCookSuccess()
		{
			this.Refresh();
		}

		// Token: 0x0603B187 RID: 242055 RVA: 0x00E17D54 File Offset: 0x00E15F54
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

		// Token: 0x0603B188 RID: 242056 RVA: 0x00E17D88 File Offset: 0x00E15F88
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

		// Token: 0x0401ECEF RID: 126191
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericLayoutNew<MaterialItem> MaterialHorizontal;

		// Token: 0x0401ECF0 RID: 126192
		[Nullable(2)]
		private OpenCookRoleButton OpenCookRoleButton;

		// Token: 0x0401ECF1 RID: 126193
		[Nullable(2)]
		private IconItem IconItem;

		// Token: 0x0401ECF2 RID: 126194
		[Nullable(2)]
		private AmountItem AmountItem;

		// Token: 0x0401ECF3 RID: 126195
		private bool IsFirstShow = true;

		// Token: 0x0401ECF4 RID: 126196
		private int ItemId;

		// Token: 0x0401ECF5 RID: 126197
		private int RoleId;

		// Token: 0x0401ECF6 RID: 126198
		private int Count = 1;

		// Token: 0x0401ECF7 RID: 126199
		private CookFormula? CookFormula;

		// Token: 0x0401ECF8 RID: 126200
		private CookProcessed? CookProcessed;

		// Token: 0x0200BD66 RID: 48486
		[NullableContext(0)]
		public enum ECookViewDefine
		{
			// Token: 0x04039212 RID: 234002
			CookNameText,
			// Token: 0x04039213 RID: 234003
			CookIconItem,
			// Token: 0x04039214 RID: 234004
			CookMaterialHorizontalLayout,
			// Token: 0x04039215 RID: 234005
			CookConfirmButton,
			// Token: 0x04039216 RID: 234006
			CookRoleItem,
			// Token: 0x04039217 RID: 234007
			AmountItem,
			// Token: 0x04039218 RID: 234008
			CookDefaultButton
		}
	}
}
