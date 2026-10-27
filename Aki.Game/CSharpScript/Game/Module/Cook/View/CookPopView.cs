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
	// Token: 0x02005B1B RID: 23323
	public class CookPopView : UiViewBase
	{
		// Token: 0x0603B0A6 RID: 241830 RVA: 0x00E135CB File Offset: 0x00E117CB
		[NullableContext(1)]
		public CookPopView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0603B0A7 RID: 241831 RVA: 0x00E135D4 File Offset: 0x00E117D4
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

		// Token: 0x0603B0A8 RID: 241832 RVA: 0x00E137F0 File Offset: 0x00E119F0
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

		// Token: 0x0603B0A9 RID: 241833 RVA: 0x00E138F0 File Offset: 0x00E11AF0
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

		// Token: 0x0603B0AA RID: 241834 RVA: 0x00E1392F File Offset: 0x00E11B2F
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.FixSuccess, new Action(this.OnClose));
		}

		// Token: 0x0603B0AB RID: 241835 RVA: 0x00E1394D File Offset: 0x00E11B4D
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.FixSuccess, new Action(this.OnClose));
		}

		// Token: 0x0603B0AC RID: 241836 RVA: 0x00E1396B File Offset: 0x00E11B6B
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

		// Token: 0x0603B0AD RID: 241837 RVA: 0x00E139A4 File Offset: 0x00E11BA4
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

		// Token: 0x0603B0AE RID: 241838 RVA: 0x00E139F8 File Offset: 0x00E11BF8
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

		// Token: 0x0603B0AF RID: 241839 RVA: 0x00E13A94 File Offset: 0x00E11C94
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

		// Token: 0x0603B0B0 RID: 241840 RVA: 0x00E13B68 File Offset: 0x00E11D68
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

		// Token: 0x0603B0B1 RID: 241841 RVA: 0x00E13C70 File Offset: 0x00E11E70
		private void SetExpItem()
		{
			ICookerInfoData cookerInfo = CookModel.Instance.GetCookerInfo();
			int sumExpByLevel = CookModel.Instance.GetSumExpByLevel(CookModel.Instance.GetCookerInfo().CookingLevel);
			this.ExpItem.SetExpSprite(cookerInfo.TotalProficiencys, sumExpByLevel);
			this.ExpItem.SetAddText(cookerInfo.AddExp);
			this.ExpItem.SetLastText(cookerInfo.TotalProficiencys);
			this.ExpItem.SetSumText(sumExpByLevel);
		}

		// Token: 0x0603B0B2 RID: 241842 RVA: 0x00E13CE4 File Offset: 0x00E11EE4
		private void RefreshDoubleConfirmButton()
		{
			UUIInteractionGroup uuiinteractionGroup = (base.GetButton(6).GetOwner() as AUIBaseActor).GetComponentByClass(UUIInteractionGroup.StaticClass()) as UUIInteractionGroup;
			bool flag = CookController.Instance.CheckCanFix();
			uuiinteractionGroup.SetInteractable(flag);
			(base.GetButton(9).GetOwner() as AUIBaseActor).GetUIItem().SetUIActive(!flag);
		}

		// Token: 0x0603B0B3 RID: 241843 RVA: 0x00E13D47 File Offset: 0x00E11F47
		private void OnClose()
		{
			this.DoClose();
		}

		// Token: 0x0603B0B4 RID: 241844 RVA: 0x00E13D4F File Offset: 0x00E11F4F
		private void OnCancel()
		{
			this.DoClose();
		}

		// Token: 0x0603B0B5 RID: 241845 RVA: 0x00E13D58 File Offset: 0x00E11F58
		private void OnConfirm()
		{
			CookController.Instance.SendFixToolRequest(CookController.Instance.GetCurrentFixId(), CookController.Instance.GetCurrentEntityId().Value);
			this.DoClose();
		}

		// Token: 0x0603B0B6 RID: 241846 RVA: 0x00E13D91 File Offset: 0x00E11F91
		private void OnSingleConfirm()
		{
			this.DoClose();
		}

		// Token: 0x0603B0B7 RID: 241847 RVA: 0x00E13D99 File Offset: 0x00E11F99
		private void DoClose()
		{
			if (this.Type == ECookPopType.Unlock)
			{
				UiManager.Instance.CloseView(EUiViewName.CookPopFixView, null);
				return;
			}
			UiManager.Instance.CloseView(EUiViewName.CookPopView, null);
		}

		// Token: 0x0603B0B8 RID: 241848 RVA: 0x00E13DC4 File Offset: 0x00E11FC4
		private void OnDisable()
		{
			GenericPromptController.Instance.ShowPromptByCode("MaterialShort", Array.Empty<object>());
		}

		// Token: 0x0401ECBB RID: 126139
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericScrollView<CookPopItem> CookPopScroll;

		// Token: 0x0401ECBC RID: 126140
		[Nullable(2)]
		private ExpItem ExpItem;

		// Token: 0x0401ECBD RID: 126141
		private ECookPopType Type;

		// Token: 0x0200BD55 RID: 48469
		public enum ECookPopDefine
		{
			// Token: 0x040391A8 RID: 233896
			TitleText,
			// Token: 0x040391A9 RID: 233897
			ItemScrollView,
			// Token: 0x040391AA RID: 233898
			InfoTextItem,
			// Token: 0x040391AB RID: 233899
			InfoText,
			// Token: 0x040391AC RID: 233900
			DoubleButtonItem,
			// Token: 0x040391AD RID: 233901
			CancelButton,
			// Token: 0x040391AE RID: 233902
			ConfirmButton,
			// Token: 0x040391AF RID: 233903
			ExpItem,
			// Token: 0x040391B0 RID: 233904
			SingleConfirmButton,
			// Token: 0x040391B1 RID: 233905
			DisableButton
		}
	}
}
