using System;
using System.Collections.Generic;
using System.Linq;
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
	// Token: 0x02005905 RID: 22789
	[NullableContext(1)]
	[Nullable(0)]
	public class InfrArchiveMainView : UiViewBase
	{
		// Token: 0x06039DE9 RID: 237033 RVA: 0x00DBE850 File Offset: 0x00DBCA50
		public InfrArchiveMainView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x06039DEA RID: 237034 RVA: 0x00DBE86C File Offset: 0x00DBCA6C
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

		// Token: 0x06039DEB RID: 237035 RVA: 0x00DBEA3E File Offset: 0x00DBCC3E
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.InfrastructureArchiveReadUpdate, new Action(this.OnArchiveReadUpdate));
		}

		// Token: 0x06039DEC RID: 237036 RVA: 0x00DBEA5C File Offset: 0x00DBCC5C
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.InfrastructureArchiveReadUpdate, new Action(this.OnArchiveReadUpdate));
		}

		// Token: 0x06039DED RID: 237037 RVA: 0x00DBEA7C File Offset: 0x00DBCC7C
		protected override UniTask OnBeforeStartAsync()
		{
			InfrArchiveMainView.<OnBeforeStartAsync>d__9 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<InfrArchiveMainView.<OnBeforeStartAsync>d__9>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06039DEE RID: 237038 RVA: 0x00DBEABF File Offset: 0x00DBCCBF
		protected override void OnStart()
		{
			this.RefreshCaption();
			this.RefreshCardInfo();
			this.RefreshRedDot();
			this.MenuItemLayout.GetLayoutItemList()[0].SetToggleSelected(EToggleState.ETT_Checked);
		}

		// Token: 0x06039DEF RID: 237039 RVA: 0x00DBEAEA File Offset: 0x00DBCCEA
		protected override void OnBeforeDestroy()
		{
			this.UnBindRedDot();
		}

		// Token: 0x06039DF0 RID: 237040 RVA: 0x00DBEAF2 File Offset: 0x00DBCCF2
		private void UnBindRedDot()
		{
			RedDotController.Instance.UnBindRedDot(ERedDotName.InfrArchive);
		}

		// Token: 0x06039DF1 RID: 237041 RVA: 0x00DBEB04 File Offset: 0x00DBCD04
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

		// Token: 0x06039DF2 RID: 237042 RVA: 0x00DBEB58 File Offset: 0x00DBCD58
		private UniTask CreateCaption()
		{
			InfrArchiveMainView.<CreateCaption>d__14 <CreateCaption>d__;
			<CreateCaption>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateCaption>d__.<>4__this = this;
			<CreateCaption>d__.<>1__state = -1;
			<CreateCaption>d__.<>t__builder.Start<InfrArchiveMainView.<CreateCaption>d__14>(ref <CreateCaption>d__);
			return <CreateCaption>d__.<>t__builder.Task;
		}

		// Token: 0x06039DF3 RID: 237043 RVA: 0x00DBEB9C File Offset: 0x00DBCD9C
		private UniTask CreateMenuItemLayout()
		{
			InfrArchiveMainView.<CreateMenuItemLayout>d__15 <CreateMenuItemLayout>d__;
			<CreateMenuItemLayout>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateMenuItemLayout>d__.<>4__this = this;
			<CreateMenuItemLayout>d__.<>1__state = -1;
			<CreateMenuItemLayout>d__.<>t__builder.Start<InfrArchiveMainView.<CreateMenuItemLayout>d__15>(ref <CreateMenuItemLayout>d__);
			return <CreateMenuItemLayout>d__.<>t__builder.Task;
		}

		// Token: 0x06039DF4 RID: 237044 RVA: 0x00DBEBDF File Offset: 0x00DBCDDF
		private void CreateRoleCardLayout()
		{
			this.RoleCardLayout = new GenericScrollViewNew<InfrArchiveRoleCardItem, int>(base.GetScrollViewWithScrollbar(6), delegate()
			{
				InfrArchiveRoleCardItem infrArchiveRoleCardItem = new InfrArchiveRoleCardItem();
				infrArchiveRoleCardItem.SetSelectedCallBack(new Action<int>(this.OnClickRoleCard));
				return infrArchiveRoleCardItem;
			}, null, false, null);
		}

		// Token: 0x06039DF5 RID: 237045 RVA: 0x00DBEC02 File Offset: 0x00DBCE02
		private void CreateCollectCardLayout()
		{
			this.CollectCardLayout = new GenericScrollViewNew<InfrArchiveCollectCardItem, int>(base.GetScrollViewWithScrollbar(8), () => new InfrArchiveCollectCardItem(), null, false, null);
		}

		// Token: 0x06039DF6 RID: 237046 RVA: 0x00DBEC38 File Offset: 0x00DBCE38
		private void RefreshCaption()
		{
			this.Caption.SetCloseCallBack(delegate
			{
				base.CloseMe(null);
			});
			this.Caption.SetHelpBtnActive(false);
		}

		// Token: 0x06039DF7 RID: 237047 RVA: 0x00DBEC60 File Offset: 0x00DBCE60
		private void RefreshRoleCard()
		{
			IEnumerable<InfrPhoneMessage> infrPhoneMessageConfigList = InfrastructureConfig.Instance.GetInfrPhoneMessageConfigList();
			PhoneMsgModel phoneMsgModel = PhoneMsgModel.Instance;
			List<int> data = (from item in infrPhoneMessageConfigList
			select item.Id into a
			orderby (!phoneMsgModel.IsPhoneMsgUnlock(a)) ? 1 : 0, a
			select a).ToList<int>();
			this.RoleCardLayout.RefreshByData(data, null, false);
		}

		// Token: 0x06039DF8 RID: 237048 RVA: 0x00DBECF8 File Offset: 0x00DBCEF8
		private void RefreshCollectCard()
		{
			List<int> data = (from config in InfrastructureConfig.Instance.GetArchiveItemIdConfigList()
			select config.Id).OrderBy(delegate(int a)
			{
				InfrArchiveItem? archiveItemConfig = InfrastructureConfig.Instance.GetArchiveItemConfig(a);
				return (InventoryModel.Instance.GetItemCountByConfigId(archiveItemConfig.Value.ItemId, 0) <= 0) ? 1 : 0;
			}).ThenBy((int a) => a).ToList<int>();
			this.CollectCardLayout.RefreshByData(data, null, false);
		}

		// Token: 0x06039DF9 RID: 237049 RVA: 0x00DBED8F File Offset: 0x00DBCF8F
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

		// Token: 0x06039DFA RID: 237050 RVA: 0x00DBEDCC File Offset: 0x00DBCFCC
		private void OnClickMenuItem(InfrastructureDefine.EInfrArchiveTabType cardType)
		{
			this.CardType = cardType;
			GenericLayout<InfrArchiveMenuItem, IInfrArchiveMenuItemData> menuItemLayout = this.MenuItemLayout;
			if (menuItemLayout != null)
			{
				(from item in menuItemLayout.GetLayoutItemList()
				where item.CardType != cardType
				select item).ToList<InfrArchiveMenuItem>().ForEach(delegate(InfrArchiveMenuItem item)
				{
					item.SetToggleSelected(EToggleState.ETT_UnChecked);
				});
			}
			this.RefreshCardInfo();
		}

		// Token: 0x06039DFB RID: 237051 RVA: 0x00DBEE44 File Offset: 0x00DBD044
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

		// Token: 0x06039DFC RID: 237052 RVA: 0x00DBEEB5 File Offset: 0x00DBD0B5
		private void OnArchiveReadUpdate()
		{
			this.RefreshCollectCard();
		}

		// Token: 0x06039DFD RID: 237053 RVA: 0x00DBEEC0 File Offset: 0x00DBD0C0
		private void RefreshRedDot()
		{
			UUIItem item = base.GetItem(10);
			RedDotController.Instance.BindRedDot(ERedDotName.InfrArchive, item, null, 0);
		}

		// Token: 0x06039DFE RID: 237054 RVA: 0x00DBEEE8 File Offset: 0x00DBD0E8
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

		// Token: 0x0401E300 RID: 123648
		private PopupCaptionItem Caption = new PopupCaptionItem(null);

		// Token: 0x0401E301 RID: 123649
		private GenericLayout<InfrArchiveMenuItem, IInfrArchiveMenuItemData> MenuItemLayout;

		// Token: 0x0401E302 RID: 123650
		private GenericScrollViewNew<InfrArchiveRoleCardItem, int> RoleCardLayout;

		// Token: 0x0401E303 RID: 123651
		private GenericScrollViewNew<InfrArchiveCollectCardItem, int> CollectCardLayout;

		// Token: 0x0401E304 RID: 123652
		private InfrastructureDefine.EInfrArchiveTabType CardType = InfrastructureDefine.EInfrArchiveTabType.RoleCard;

		// Token: 0x0200BB67 RID: 47975
		[NullableContext(0)]
		private class EChildType
		{
			// Token: 0x04038911 RID: 231697
			public const int ItemCaption = 0;

			// Token: 0x04038912 RID: 231698
			public const int PanelMenuLayout = 1;

			// Token: 0x04038913 RID: 231699
			public const int PanelMenuItem = 2;

			// Token: 0x04038914 RID: 231700
			public const int PanelLimitStore = 3;

			// Token: 0x04038915 RID: 231701
			public const int BtnStore = 4;

			// Token: 0x04038916 RID: 231702
			public const int TextTitle = 5;

			// Token: 0x04038917 RID: 231703
			public const int ScrollRoleCard = 6;

			// Token: 0x04038918 RID: 231704
			public const int ItemRoleCard = 7;

			// Token: 0x04038919 RID: 231705
			public const int ScrollCollectCard = 8;

			// Token: 0x0403891A RID: 231706
			public const int ItemCollectCard = 9;

			// Token: 0x0403891B RID: 231707
			public const int ItemRedDot = 10;
		}
	}
}
