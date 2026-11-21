using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.PhoneMessage;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Infrastructure
{
	// Token: 0x020048DE RID: 18654
	[NullableContext(1)]
	[Nullable(0)]
	public class InfrArchiveMainView : UiViewBase
	{
		// Token: 0x0602ED0C RID: 191756 RVA: 0x00D0DAC0 File Offset: 0x00D0BCC0
		public InfrArchiveMainView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x0602ED0D RID: 191757 RVA: 0x00D0DADC File Offset: 0x00D0BCDC
		protected unsafe override void OnRegisterComponent()
		{
			int num = 11;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIVerticalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIScrollViewWithScrollbarComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIScrollViewWithScrollbarComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(4, new Action(this.OnClickBtnStore));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0602ED0E RID: 191758 RVA: 0x00D0DCAE File Offset: 0x00D0BEAE
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.InfrastructureArchiveReadUpdate, new Action(this.OnArchiveReadUpdate));
		}

		// Token: 0x0602ED0F RID: 191759 RVA: 0x00D0DCCC File Offset: 0x00D0BECC
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.InfrastructureArchiveReadUpdate, new Action(this.OnArchiveReadUpdate));
		}

		// Token: 0x0602ED10 RID: 191760 RVA: 0x00D0DCEC File Offset: 0x00D0BEEC
		protected override UniTask OnBeforeStartAsync()
		{
			InfrArchiveMainView.<OnBeforeStartAsync>d__9 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<InfrArchiveMainView.<OnBeforeStartAsync>d__9>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602ED11 RID: 191761 RVA: 0x00D0DD2F File Offset: 0x00D0BF2F
		protected override void OnStart()
		{
			this.RefreshCaption();
			this.RefreshCardInfo();
			this.RefreshRedDot();
			this.MenuItemLayout.GetLayoutItemList()[0].SetToggleSelected(EToggleState.ETT_Checked);
		}

		// Token: 0x0602ED12 RID: 191762 RVA: 0x00D0DD5A File Offset: 0x00D0BF5A
		protected override void OnBeforeDestroy()
		{
			this.UnBindRedDot();
		}

		// Token: 0x0602ED13 RID: 191763 RVA: 0x00D0DD62 File Offset: 0x00D0BF62
		private void UnBindRedDot()
		{
			RedDotController.Instance.UnBindRedDot(ERedDotName.InfrArchive);
		}

		// Token: 0x0602ED14 RID: 191764 RVA: 0x00D0DD74 File Offset: 0x00D0BF74
		private void RefreshCardInfo()
		{
			InfrastructureDefine.EInfrArchiveTabType cardType = this.CardType;
			if (cardType != InfrastructureDefine.EInfrArchiveTabType.CollectCard)
			{
				if (cardType == InfrastructureDefine.EInfrArchiveTabType.RoleCard)
				{
					this.RefreshRoleCard();
				}
			}
			else
			{
				this.RefreshCollectCard();
			}
			this.RoleCardLayout.SetActive(this.CardType == InfrastructureDefine.EInfrArchiveTabType.RoleCard);
			this.CollectCardLayout.SetActive(this.CardType == InfrastructureDefine.EInfrArchiveTabType.CollectCard);
		}

		// Token: 0x0602ED15 RID: 191765 RVA: 0x00D0DDC8 File Offset: 0x00D0BFC8
		private UniTask CreateCaption()
		{
			InfrArchiveMainView.<CreateCaption>d__14 <CreateCaption>d__;
			<CreateCaption>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateCaption>d__.<>4__this = this;
			<CreateCaption>d__.<>1__state = -1;
			<CreateCaption>d__.<>t__builder.Start<InfrArchiveMainView.<CreateCaption>d__14>(ref <CreateCaption>d__);
			return <CreateCaption>d__.<>t__builder.Task;
		}

		// Token: 0x0602ED16 RID: 191766 RVA: 0x00D0DE0C File Offset: 0x00D0C00C
		private UniTask CreateMenuItemLayout()
		{
			InfrArchiveMainView.<CreateMenuItemLayout>d__15 <CreateMenuItemLayout>d__;
			<CreateMenuItemLayout>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateMenuItemLayout>d__.<>4__this = this;
			<CreateMenuItemLayout>d__.<>1__state = -1;
			<CreateMenuItemLayout>d__.<>t__builder.Start<InfrArchiveMainView.<CreateMenuItemLayout>d__15>(ref <CreateMenuItemLayout>d__);
			return <CreateMenuItemLayout>d__.<>t__builder.Task;
		}

		// Token: 0x0602ED17 RID: 191767 RVA: 0x00D0DE4F File Offset: 0x00D0C04F
		private void CreateRoleCardLayout()
		{
			this.RoleCardLayout = new GenericScrollViewNew<InfrArchiveRoleCardItem, int>(base.GetScrollViewWithScrollbar(6), delegate()
			{
				InfrArchiveRoleCardItem infrArchiveRoleCardItem = new InfrArchiveRoleCardItem();
				infrArchiveRoleCardItem.SetSelectedCallBack(new Action<int>(this.OnClickRoleCard));
				return infrArchiveRoleCardItem;
			}, null, false, null);
		}

		// Token: 0x0602ED18 RID: 191768 RVA: 0x00D0DE72 File Offset: 0x00D0C072
		private void CreateCollectCardLayout()
		{
			this.CollectCardLayout = new GenericScrollViewNew<InfrArchiveCollectCardItem, int>(base.GetScrollViewWithScrollbar(8), () => new InfrArchiveCollectCardItem(), null, false, null);
		}

		// Token: 0x0602ED19 RID: 191769 RVA: 0x00D0DEA8 File Offset: 0x00D0C0A8
		private void RefreshCaption()
		{
			this.Caption.SetCloseCallBack(delegate
			{
				base.CloseMe(null);
			});
			this.Caption.SetHelpBtnActive(false);
		}

		// Token: 0x0602ED1A RID: 191770 RVA: 0x00D0DED0 File Offset: 0x00D0C0D0
		private void RefreshRoleCard()
		{
			IReadOnlyList<InfrPhoneMessage> infrPhoneMessageConfigList = InfrastructureConfig.Instance.GetInfrPhoneMessageConfigList();
			PhoneMsgModel instance = PhoneMsgModel.Instance;
			List<int> list = new List<int>(infrPhoneMessageConfigList.Count);
			List<int> list2 = new List<int>();
			for (int i = 0; i < infrPhoneMessageConfigList.Count; i++)
			{
				int id = infrPhoneMessageConfigList[i].Id;
				if (instance.IsPhoneMsgUnlock(id))
				{
					list.Add(id);
				}
				else
				{
					list2.Add(id);
				}
			}
			list.Sort();
			if (list2.Count > 0)
			{
				list2.Sort();
				list.AddRange(list2);
			}
			this.RoleCardLayout.RefreshByData(list, null, false);
		}

		// Token: 0x0602ED1B RID: 191771 RVA: 0x00D0DF70 File Offset: 0x00D0C170
		private void RefreshCollectCard()
		{
			IReadOnlyList<InfrArchiveItem> archiveItemIdConfigList = InfrastructureConfig.Instance.GetArchiveItemIdConfigList();
			List<int> list = new List<int>(archiveItemIdConfigList.Count);
			List<int> list2 = new List<int>();
			for (int i = 0; i < archiveItemIdConfigList.Count; i++)
			{
				int id = archiveItemIdConfigList[i].Id;
				InfrArchiveItem? archiveItemConfig = InfrastructureConfig.Instance.GetArchiveItemConfig(id);
				if (InventoryModel.Instance.GetItemCountByConfigId(archiveItemConfig.Value.ItemId, 0) > 0)
				{
					list.Add(id);
				}
				else
				{
					list2.Add(id);
				}
			}
			list.Sort();
			if (list2.Count > 0)
			{
				list2.Sort();
				list.AddRange(list2);
			}
			this.CollectCardLayout.RefreshByData(list, null, false);
		}

		// Token: 0x0602ED1C RID: 191772 RVA: 0x00D0E025 File Offset: 0x00D0C225
		private void OnClickBtnStore()
		{
			UiManager.Instance.OpenView(EUiViewName.ActivityRewardPopUpView, InfrastructureModel.Instance.GetScoreRewardData(), delegate(bool success, int viewId)
			{
				if (success && UiManager.Instance.IsViewShow(EUiViewName.InfrArchiveMainView))
				{
					UiViewBase viewByName = UiManager.Instance.GetViewByName(EUiViewName.InfrArchiveMainView);
					if (viewByName == null)
					{
						return;
					}
					viewByName.AddChildViewById(viewId);
				}
			});
		}

		// Token: 0x0602ED1D RID: 191773 RVA: 0x00D0E060 File Offset: 0x00D0C260
		private void OnClickMenuItem(InfrastructureDefine.EInfrArchiveTabType cardType)
		{
			this.CardType = cardType;
			GenericLayout<InfrArchiveMenuItem, IInfrArchiveMenuItemData> menuItemLayout = this.MenuItemLayout;
			List<InfrArchiveMenuItem> list = (menuItemLayout != null) ? menuItemLayout.GetLayoutItemList() : null;
			if (list != null)
			{
				foreach (InfrArchiveMenuItem infrArchiveMenuItem in list)
				{
					if (infrArchiveMenuItem.CardType != cardType)
					{
						infrArchiveMenuItem.SetToggleSelected(EToggleState.ETT_UnChecked);
					}
				}
			}
			this.RefreshCardInfo();
		}

		// Token: 0x0602ED1E RID: 191774 RVA: 0x00D0E0DC File Offset: 0x00D0C2DC
		private void OnClickRoleCard(int index)
		{
			InfrArchiveRoleCardItem scrollItemByIndex = this.RoleCardLayout.GetScrollItemByIndex(index);
			if (!PhoneMsgModel.Instance.IsPhoneMsgUnlock(scrollItemByIndex.MsgId))
			{
				return;
			}
			ShortMessage? phoneMsgConfig = PhoneMsgConfig.Instance.GetPhoneMsgConfig(scrollItemByIndex.MsgId);
			PhoneMsgPanelViewData param = new PhoneMsgPanelViewData
			{
				ShortMessage = phoneMsgConfig,
				NeedShowTips = false,
				OpenWay = EPhoneMsgOpenWay.Infrastructure,
				ViewType = EPhoneMsgViewType.Big
			};
			UiManager.Instance.OpenView(EUiViewName.PhoneMsgPanelViewBig, param, null);
		}

		// Token: 0x0602ED1F RID: 191775 RVA: 0x00D0E14D File Offset: 0x00D0C34D
		private void OnArchiveReadUpdate()
		{
			this.RefreshCollectCard();
		}

		// Token: 0x0602ED20 RID: 191776 RVA: 0x00D0E158 File Offset: 0x00D0C358
		private void RefreshRedDot()
		{
			UUIItem item = base.GetItem(10);
			RedDotController.Instance.BindRedDot(ERedDotName.InfrArchive, item, null, 0);
		}

		// Token: 0x0602ED21 RID: 191777 RVA: 0x00D0E180 File Offset: 0x00D0C380
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public override UUIItem[] GetGuideUiItemAndUiItemForShowEx(string[] configParams)
		{
			if (configParams.Length == 0)
			{
				return null;
			}
			if (!(configParams[0] == "MenuItem"))
			{
				return null;
			}
			int index = int.Parse(configParams[1]);
			GenericLayout<InfrArchiveMenuItem, IInfrArchiveMenuItemData> menuItemLayout = this.MenuItemLayout;
			InfrArchiveMenuItem infrArchiveMenuItem = (menuItemLayout != null) ? menuItemLayout.GetLayoutItemByIndex(index) : null;
			if (infrArchiveMenuItem == null)
			{
				return null;
			}
			return infrArchiveMenuItem.GetGuideUiItemAndUiItemForShowEx(configParams);
		}

		// Token: 0x04018D9D RID: 101789
		private PopupCaptionItem Caption = new PopupCaptionItem(null);

		// Token: 0x04018D9E RID: 101790
		private GenericLayout<InfrArchiveMenuItem, IInfrArchiveMenuItemData> MenuItemLayout;

		// Token: 0x04018D9F RID: 101791
		private GenericScrollViewNew<InfrArchiveRoleCardItem, int> RoleCardLayout;

		// Token: 0x04018DA0 RID: 101792
		private GenericScrollViewNew<InfrArchiveCollectCardItem, int> CollectCardLayout;

		// Token: 0x04018DA1 RID: 101793
		private InfrastructureDefine.EInfrArchiveTabType CardType = InfrastructureDefine.EInfrArchiveTabType.RoleCard;

		// Token: 0x0200A579 RID: 42361
		[NullableContext(0)]
		private class EChildType
		{
			// Token: 0x04033303 RID: 209667
			public const int ItemCaption = 0;

			// Token: 0x04033304 RID: 209668
			public const int PanelMenuLayout = 1;

			// Token: 0x04033305 RID: 209669
			public const int PanelMenuItem = 2;

			// Token: 0x04033306 RID: 209670
			public const int PanelLimitStore = 3;

			// Token: 0x04033307 RID: 209671
			public const int BtnStore = 4;

			// Token: 0x04033308 RID: 209672
			public const int TextTitle = 5;

			// Token: 0x04033309 RID: 209673
			public const int ScrollRoleCard = 6;

			// Token: 0x0403330A RID: 209674
			public const int ItemRoleCard = 7;

			// Token: 0x0403330B RID: 209675
			public const int ScrollCollectCard = 8;

			// Token: 0x0403330C RID: 209676
			public const int ItemCollectCard = 9;

			// Token: 0x0403330D RID: 209677
			public const int ItemRedDot = 10;
		}
	}
}
