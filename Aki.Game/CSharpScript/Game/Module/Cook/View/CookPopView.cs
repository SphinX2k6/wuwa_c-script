using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.GenericPrompt;
using CSharpScript.Game.Module.Item;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Module.Util.Layout;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Cook.View
{
	// Token: 0x02004AFC RID: 19196
	public class CookPopView : UiViewBase
	{
		// Token: 0x06030018 RID: 196632 RVA: 0x00D642E3 File Offset: 0x00D624E3
		[NullableContext(1)]
		public CookPopView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06030019 RID: 196633 RVA: 0x00D642EC File Offset: 0x00D624EC
		protected unsafe override void OnRegisterComponent()
		{
			int num = 10;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIScrollViewWithScrollbarComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIButtonComponent));
			this.ComponentRegisterInfos = list;
			num2 = 4;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(5, new Action(delegate()
			{
				this.OnCancel();
			}));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(6, new Action(delegate()
			{
				this.OnConfirm();
			}));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(8, new Action(delegate()
			{
				this.OnSingleConfirm();
			}));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(9, new Action(delegate()
			{
				this.OnDisable();
			}));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0603001A RID: 196634 RVA: 0x00D64508 File Offset: 0x00D62708
		protected override void OnStart()
		{
			IUiPopFrameInterface childPopView = this.ChildPopView;
			if (childPopView != null)
			{
				childPopView.PopItem.OverrideBackBtnCallBack(new Action(this.OnClose));
			}
			CookRewardPopData cookRewardPopData = this.OpenParam as CookRewardPopData;
			this.Type = cookRewardPopData.CookRewardPopType;
			this.CookPopScroll = new GenericScrollView<CookPopItem>(base.GetScrollViewWithScrollbar(1), new CSharpScript.Game.Module.Util.Layout.TLayoutRefresh<CookPopItem>(this.InitCookPopItem), null);
			base.GetItem(2).SetUIActive(this.Type == ECookPopType.Unlock || this.Type == ECookPopType.StudyFail);
			base.GetItem(4).SetUIActive(this.Type == ECookPopType.Unlock);
			bool uiactive = this.Type == ECookPopType.Cook && CookController.Instance.CheckCanShowExpItem();
			base.GetItem(7).SetUIActive(uiactive);
			if (this.Type == ECookPopType.Cook)
			{
				this.ExpItem = new ExpItem(base.GetItem(7));
			}
			(base.GetButton(8).GetOwner() as AUIBaseActor).GetUIItem().SetUIActive(this.Type > ECookPopType.Unlock);
		}

		// Token: 0x0603001B RID: 196635 RVA: 0x00D64608 File Offset: 0x00D62808
		[NullableContext(1)]
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		private ILayoutItem<CookPopItem> InitCookPopItem([Nullable(2)] object data, UUIItem item, int index)
		{
			ICookPopItem cookPopItem = data as ICookPopItem;
			if (cookPopItem == null)
			{
				return null;
			}
			CookPopItem cookPopItem2 = new CookPopItem(item);
			cookPopItem2.Update(cookPopItem);
			return new LayoutItem<CookPopItem>
			{
				Key = index,
				Value = cookPopItem2
			};
		}

		// Token: 0x0603001C RID: 196636 RVA: 0x00D64647 File Offset: 0x00D62847
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.FixSuccess, new Action(this.OnClose));
		}

		// Token: 0x0603001D RID: 196637 RVA: 0x00D64665 File Offset: 0x00D62865
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.FixSuccess, new Action(this.OnClose));
		}

		// Token: 0x0603001E RID: 196638 RVA: 0x00D64683 File Offset: 0x00D62883
		protected override void OnBeforeDestroy()
		{
			if (this.CookPopScroll != null)
			{
				this.CookPopScroll.ClearChildren();
				this.CookPopScroll = null;
			}
			if (this.ExpItem != null)
			{
				this.ExpItem.Destroy(null);
				this.ExpItem = null;
			}
		}

		// Token: 0x0603001F RID: 196639 RVA: 0x00D646BC File Offset: 0x00D628BC
		protected override void OnAfterShow()
		{
			this.SetTitle();
			this.SetItemScroll();
			switch (this.Type)
			{
			case ECookPopType.Unlock:
				this.SetInfoText();
				this.RefreshDoubleConfirmButton();
				return;
			case ECookPopType.Cook:
				this.SetExpItem();
				return;
			case ECookPopType.Machining:
				break;
			case ECookPopType.StudyFail:
				this.SetInfoText();
				break;
			default:
				return;
			}
		}

		// Token: 0x06030020 RID: 196640 RVA: 0x00D64710 File Offset: 0x00D62910
		private void SetTitle()
		{
			switch (this.Type)
			{
			case ECookPopType.Unlock:
				LguiUtil.Instance.SetLocalText(base.GetText(0), "UnlockTitle", Array.Empty<object>());
				return;
			case ECookPopType.Cook:
				LguiUtil.Instance.SetLocalText(base.GetText(0), "GetItem", Array.Empty<object>());
				return;
			case ECookPopType.Machining:
				LguiUtil.Instance.SetLocalText(base.GetText(0), "GetItem", Array.Empty<object>());
				return;
			case ECookPopType.StudyFail:
				LguiUtil.Instance.SetLocalText(base.GetText(0), "StudyFail", Array.Empty<object>());
				return;
			default:
				return;
			}
		}

		// Token: 0x06030021 RID: 196641 RVA: 0x00D647AC File Offset: 0x00D629AC
		private void SetItemScroll()
		{
			if (this.Type == ECookPopType.Unlock)
			{
				List<ICookPopItem> list = new List<ICookPopItem>();
				CookFixTool cookFixToolById = CookConfig.Instance.GetCookFixToolById(CookController.Instance.GetCurrentFixId());
				for (int i = 0; i < cookFixToolById.ItemsLength; i++)
				{
					DicIntInt? dicIntInt = cookFixToolById.Items(i);
					if (dicIntInt != null)
					{
						int itemCountByConfigId = InventoryModel.Instance.GetItemCountByConfigId(dicIntInt.Value.Key, 0);
						list.Add(new CookPopItem
						{
							ItemId = dicIntInt.Value.Key,
							ItemNum = itemCountByConfigId
						});
					}
				}
				this.CookPopScroll.RefreshByData<ICookPopItem>(list, null);
				return;
			}
			this.CookPopScroll.RefreshByData<ICookPopItem>(CookModel.Instance.GetCookItemList(), null);
		}

		// Token: 0x06030022 RID: 196642 RVA: 0x00D64880 File Offset: 0x00D62A80
		private void SetInfoText()
		{
			if (this.Type == ECookPopType.Unlock)
			{
				CookFixTool cookFixToolById = CookConfig.Instance.GetCookFixToolById(CookController.Instance.GetCurrentFixId());
				string localText = CookConfig.Instance.GetLocalText(cookFixToolById.Description);
				int num = 0;
				string text = "";
				for (int i = 0; i < cookFixToolById.ItemsLength; i++)
				{
					DicIntInt? dicIntInt = cookFixToolById.Items(i);
					if (dicIntInt != null)
					{
						num = dicIntInt.Value.Value;
						ItemInfo? config = ItemConfig.Instance.GetConfig(dicIntInt.Value.Key);
						text = CookConfig.Instance.GetLocalText(config.Value.Name);
					}
				}
				LguiUtil.Instance.SetLocalText(base.GetText(3), "FixText", new <>z__ReadOnlyArray<object>(new object[]
				{
					num,
					text,
					localText
				}));
				return;
			}
			LguiUtil.Instance.SetLocalText(base.GetText(3), "MaciningStudyFail", Array.Empty<object>());
		}

		// Token: 0x06030023 RID: 196643 RVA: 0x00D64988 File Offset: 0x00D62B88
		private void SetExpItem()
		{
			ICookerInfoData cookerInfo = CookModel.Instance.GetCookerInfo();
			int sumExpByLevel = CookModel.Instance.GetSumExpByLevel(CookModel.Instance.GetCookerInfo().CookingLevel);
			this.ExpItem.SetExpSprite(cookerInfo.TotalProficiencys, sumExpByLevel);
			this.ExpItem.SetAddText(cookerInfo.AddExp);
			this.ExpItem.SetLastText(cookerInfo.TotalProficiencys);
			this.ExpItem.SetSumText(sumExpByLevel);
		}

		// Token: 0x06030024 RID: 196644 RVA: 0x00D649FC File Offset: 0x00D62BFC
		private void RefreshDoubleConfirmButton()
		{
			UUIInteractionGroup uuiinteractionGroup = (base.GetButton(6).GetOwner() as AUIBaseActor).GetComponentByClass(UUIInteractionGroup.StaticClass()) as UUIInteractionGroup;
			bool flag = CookController.Instance.CheckCanFix();
			uuiinteractionGroup.SetInteractable(flag);
			(base.GetButton(9).GetOwner() as AUIBaseActor).GetUIItem().SetUIActive(!flag);
		}

		// Token: 0x06030025 RID: 196645 RVA: 0x00D64A5F File Offset: 0x00D62C5F
		private void OnClose()
		{
			this.DoClose();
		}

		// Token: 0x06030026 RID: 196646 RVA: 0x00D64A67 File Offset: 0x00D62C67
		private void OnCancel()
		{
			this.DoClose();
		}

		// Token: 0x06030027 RID: 196647 RVA: 0x00D64A70 File Offset: 0x00D62C70
		private void OnConfirm()
		{
			CookController.Instance.SendFixToolRequest(CookController.Instance.GetCurrentFixId(), CookController.Instance.GetCurrentEntityId().Value);
			this.DoClose();
		}

		// Token: 0x06030028 RID: 196648 RVA: 0x00D64AA9 File Offset: 0x00D62CA9
		private void OnSingleConfirm()
		{
			this.DoClose();
		}

		// Token: 0x06030029 RID: 196649 RVA: 0x00D64AB1 File Offset: 0x00D62CB1
		private void DoClose()
		{
			if (this.Type == ECookPopType.Unlock)
			{
				UiManager.Instance.CloseView(EUiViewName.CookPopFixView, null);
				return;
			}
			UiManager.Instance.CloseView(EUiViewName.CookPopView, null);
		}

		// Token: 0x0603002A RID: 196650 RVA: 0x00D64ADC File Offset: 0x00D62CDC
		private void OnDisable()
		{
			GenericPromptController.Instance.ShowPromptByCode("MaterialShort", Array.Empty<object>());
		}

		// Token: 0x04019777 RID: 104311
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericScrollView<CookPopItem> CookPopScroll;

		// Token: 0x04019778 RID: 104312
		[Nullable(2)]
		private ExpItem ExpItem;

		// Token: 0x04019779 RID: 104313
		private ECookPopType Type;

		// Token: 0x0200A75E RID: 42846
		public enum ECookPopDefine
		{
			// Token: 0x04033B74 RID: 211828
			TitleText,
			// Token: 0x04033B75 RID: 211829
			ItemScrollView,
			// Token: 0x04033B76 RID: 211830
			InfoTextItem,
			// Token: 0x04033B77 RID: 211831
			InfoText,
			// Token: 0x04033B78 RID: 211832
			DoubleButtonItem,
			// Token: 0x04033B79 RID: 211833
			CancelButton,
			// Token: 0x04033B7A RID: 211834
			ConfirmButton,
			// Token: 0x04033B7B RID: 211835
			ExpItem,
			// Token: 0x04033B7C RID: 211836
			SingleConfirmButton,
			// Token: 0x04033B7D RID: 211837
			DisableButton
		}
	}
}
