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
	// Token: 0x0200466E RID: 18030
	[NullableContext(1)]
	[Nullable(0)]
	public class ManufactureView : UiNavigationView
	{
		// Token: 0x0602D582 RID: 185730 RVA: 0x00CB2344 File Offset: 0x00CB0544
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

		// Token: 0x0602D583 RID: 185731 RVA: 0x00CB24B4 File Offset: 0x00CB06B4
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

		// Token: 0x0602D584 RID: 185732 RVA: 0x00CB258C File Offset: 0x00CB078C
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

		// Token: 0x0602D585 RID: 185733 RVA: 0x00CB25DD File Offset: 0x00CB07DD
		private int GetMaxCount()
		{
			return CommonManager.Instance.GetMaxCreateCount(this.ItemId);
		}

		// Token: 0x0602D586 RID: 185734 RVA: 0x00CB25EF File Offset: 0x00CB07EF
		private void SetSum(int sum)
		{
			this.Count = sum;
			this.RefreshMaterialNeedNum();
		}

		// Token: 0x0602D587 RID: 185735 RVA: 0x00CB25FE File Offset: 0x00CB07FE
		protected override void OnBeforeDestroy()
		{
			this.RemoveEventListener();
			this.MaterialHorizontal.ClearChildren();
			this.MaterialHorizontal = null;
			this.AmountItem = null;
		}

		// Token: 0x0602D588 RID: 185736 RVA: 0x00CB2620 File Offset: 0x00CB0820
		private void AddEventListener()
		{
			EventSystem.Instance.Add(EEventName.ComposeSuccess, new Action(this.OnComposeOpenRewardPopView));
			EventSystem.Instance.Add(EEventName.ComposeSuccess, new Action(this.Refresh));
			EventSystem.Instance.Add(EEventName.ForgingSuccess, new Action(this.OnForgingOpenRewardPopView));
			EventSystem.Instance.Add(EEventName.ForgingSuccess, new Action(this.Refresh));
			EventSystem.Instance.Add(EEventName.CloseHelpRole, new Action(this.RefreshCurrentRole));
		}

		// Token: 0x0602D589 RID: 185737 RVA: 0x00CB26BC File Offset: 0x00CB08BC
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

		// Token: 0x0602D58A RID: 185738 RVA: 0x00CB2760 File Offset: 0x00CB0960
		public void HideView(bool isHide)
		{
			this.SetActive(!isHide);
			if (!isHide)
			{
				EventSystem.Instance.Emit<EViewType>(EEventName.SwitchViewType, EViewType.ManufactureViewType);
			}
		}

		// Token: 0x0602D58B RID: 185739 RVA: 0x00CB2780 File Offset: 0x00CB0980
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

		// Token: 0x0602D58C RID: 185740 RVA: 0x00CB27BC File Offset: 0x00CB09BC
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

		// Token: 0x0602D58D RID: 185741 RVA: 0x00CB2820 File Offset: 0x00CB0A20
		private void RefreshText()
		{
			string commonManufactureText = CommonManager.Instance.GetCommonManufactureText(this.ItemId);
			base.GetText(0).SetText(commonManufactureText, true);
		}

		// Token: 0x0602D58E RID: 185742 RVA: 0x00CB284C File Offset: 0x00CB0A4C
		private void RefreshItemIcon()
		{
			int value = CommonManager.Instance.GetCommonManufactureId(this.ItemId).Value;
			this.IconItem.SetIcon(value);
			this.IconItem.SetQuality(value);
		}

		// Token: 0x0602D58F RID: 185743 RVA: 0x00CB288C File Offset: 0x00CB0A8C
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

		// Token: 0x0602D590 RID: 185744 RVA: 0x00CB28E2 File Offset: 0x00CB0AE2
		private void RefreshCurrentRole()
		{
			this.RefreshOpenRoleButton();
		}

		// Token: 0x0602D591 RID: 185745 RVA: 0x00CB28EC File Offset: 0x00CB0AEC
		private void RefreshMaterialList()
		{
			this.MaterialHorizontal.RebuildLayoutByDataNew<ISingleItemInfo>(CommonManager.Instance.GetManufactureMaterialList(this.ItemId), null);
		}

		// Token: 0x0602D592 RID: 185746 RVA: 0x00CB2920 File Offset: 0x00CB0B20
		private void RefreshMaterialNeedNum()
		{
			foreach (MaterialItem materialItem in this.MaterialHorizontal.GetLayoutItemMap().Values)
			{
				materialItem.RefreshNeed(this.Count);
			}
		}

		// Token: 0x0602D593 RID: 185747 RVA: 0x00CB2980 File Offset: 0x00CB0B80
		private void RefreshConfirmButton()
		{
			UUIInteractionGroup uuiinteractionGroup = (base.GetButton(3).GetOwner() as AUIBaseActor).GetComponentByClass(UUIInteractionGroup.StaticClass()) as UUIInteractionGroup;
			AUIBaseActor auibaseActor = base.GetButton(6).GetOwner() as AUIBaseActor;
			bool valueOrDefault = CommonManager.Instance.CheckCanManufacture(this.ItemId).GetValueOrDefault();
			uuiinteractionGroup.SetInteractable(valueOrDefault);
			auibaseActor.GetUIItem().SetUIActive(!valueOrDefault);
		}

		// Token: 0x0602D594 RID: 185748 RVA: 0x00CB29F2 File Offset: 0x00CB0BF2
		private void RefreshAmountItem()
		{
			if (this.AmountItem == null)
			{
				return;
			}
			this.AmountItem.ResetSum();
			this.AmountItem.RefreshAddAndDelButton();
		}

		// Token: 0x0602D595 RID: 185749 RVA: 0x00CB2A13 File Offset: 0x00CB0C13
		private void OpenHelpRoleView()
		{
			EventSystem.Instance.Emit<int>(EEventName.OpenHelpRole, this.ItemId);
		}

		// Token: 0x0602D596 RID: 185750 RVA: 0x00CB2A2B File Offset: 0x00CB0C2B
		private void OnConfirm()
		{
			CommonManager.Instance.SendManufacture(this.ItemId, this.Count);
		}

		// Token: 0x0602D597 RID: 185751 RVA: 0x00CB2A43 File Offset: 0x00CB0C43
		private void OnDisable()
		{
			GenericPromptController.Instance.ShowPromptByCode("MaterialShort", Array.Empty<object>());
		}

		// Token: 0x0602D598 RID: 185752 RVA: 0x00CB2A59 File Offset: 0x00CB0C59
		private void OnClickMaterial(ISingleItemInfo itemData)
		{
			ItemController.Instance.OpenItemTipsByItemId(itemData.Proto_ItemId, true, null, false);
		}

		// Token: 0x0602D599 RID: 185753 RVA: 0x00CB2A6E File Offset: 0x00CB0C6E
		private void OnForgingOpenRewardPopView()
		{
		}

		// Token: 0x0602D59A RID: 185754 RVA: 0x00CB2A70 File Offset: 0x00CB0C70
		private void OnComposeOpenRewardPopView()
		{
		}

		// Token: 0x0602D59B RID: 185755 RVA: 0x00CB2A74 File Offset: 0x00CB0C74
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

		// Token: 0x040184A9 RID: 99497
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericLayoutNew<MaterialItem> MaterialHorizontal;

		// Token: 0x040184AA RID: 99498
		[Nullable(2)]
		private OpenHelpRoleButton OpenHelpRoleButton;

		// Token: 0x040184AB RID: 99499
		[Nullable(2)]
		private AmountItem AmountItem;

		// Token: 0x040184AC RID: 99500
		[Nullable(2)]
		private IconItem IconItem;

		// Token: 0x040184AD RID: 99501
		private bool IsFirstShow = true;

		// Token: 0x040184AE RID: 99502
		private int ItemId;

		// Token: 0x040184AF RID: 99503
		private int Count = 1;

		// Token: 0x0200A282 RID: 41602
		[NullableContext(0)]
		private class EManufactureViewDefine
		{
			// Token: 0x040326E7 RID: 206567
			public const int ManufactureNameText = 0;

			// Token: 0x040326E8 RID: 206568
			public const int ManufactureIconItem = 1;

			// Token: 0x040326E9 RID: 206569
			public const int ManufactureMaterialHorizontalLayout = 2;

			// Token: 0x040326EA RID: 206570
			public const int ManufactureConfirmButton = 3;

			// Token: 0x040326EB RID: 206571
			public const int ManufactureRoleItem = 4;

			// Token: 0x040326EC RID: 206572
			public const int AmountItem = 5;

			// Token: 0x040326ED RID: 206573
			public const int ManufactureDefaultButton = 6;
		}
	}
}
