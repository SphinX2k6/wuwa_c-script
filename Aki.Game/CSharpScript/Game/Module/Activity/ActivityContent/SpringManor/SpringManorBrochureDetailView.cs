using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.SpringManor
{
	// Token: 0x02006085 RID: 24709
	[NullableContext(1)]
	[Nullable(0)]
	public class SpringManorBrochureDetailView : UiViewBase
	{
		// Token: 0x0603E788 RID: 255880 RVA: 0x00F18EEA File Offset: 0x00F170EA
		public SpringManorBrochureDetailView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0603E789 RID: 255881 RVA: 0x00F18F00 File Offset: 0x00F17100
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIItem)),
				new ValueTuple<int, Type>(1, typeof(UUITexture)),
				new ValueTuple<int, Type>(2, typeof(UUIItem)),
				new ValueTuple<int, Type>(3, typeof(UUIText)),
				new ValueTuple<int, Type>(4, typeof(UUIText)),
				new ValueTuple<int, Type>(5, typeof(UUIHorizontalLayout)),
				new ValueTuple<int, Type>(6, typeof(UUIItem)),
				new ValueTuple<int, Type>(7, typeof(UUIItem)),
				new ValueTuple<int, Type>(8, typeof(UUIScrollViewWithScrollbarComponent)),
				new ValueTuple<int, Type>(9, typeof(UUIHorizontalLayout)),
				new ValueTuple<int, Type>(10, typeof(UUIItem)),
				new ValueTuple<int, Type>(11, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(12, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(13, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(14, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(15, typeof(UUIItem))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(12, new Action(this.OnClickBtnBrochureNext)),
				new ValueTuple<int, Delegate>(13, new Action(this.OnClickBtnBrochurePre)),
				new ValueTuple<int, Delegate>(11, new Action(this.OnClickBtnTracking)),
				new ValueTuple<int, Delegate>(14, new Action(this.OnClickRewardBtn))
			};
		}

		// Token: 0x0603E78A RID: 255882 RVA: 0x00F190F0 File Offset: 0x00F172F0
		protected override void OnStart()
		{
			AUIBaseActor rootActor = this.RootActor;
			if (rootActor != null)
			{
				rootActor.OnSequencePlayEvent.Bind(new Action<string, string>(this.OnPlaySequenceEvent));
			}
			this.SequencePlayer = new LevelSequencePlayer(this.RootItem);
			this.CaptionItem = new PopupCaptionItem(base.GetItem(0));
			this.CaptionItem.SetCloseCallBack(delegate
			{
				base.CloseMe(null);
			});
			this.RewardItemLayout = new GenericLayout<CommonItemSmallItemGrid, TItem>(base.GetHorizontalLayout(9), new Func<CommonItemSmallItemGrid>(this.InitGridItem), null, false, true);
			UUIHorizontalLayout horizontalLayout = base.GetHorizontalLayout(5);
			this.BottomPointLayout = new GenericLayout<SpringManorBrochureDetailPointItem, int>(horizontalLayout, new Func<SpringManorBrochureDetailPointItem>(this.InitPointItem), null, false, true);
		}

		// Token: 0x0603E78B RID: 255883 RVA: 0x00F191A0 File Offset: 0x00F173A0
		protected override void OnBeforeShow()
		{
			SpringManorBrochureDetailViewOpenParam springManorBrochureDetailViewOpenParam = this.OpenParam as SpringManorBrochureDetailViewOpenParam;
			this.ActivityId = ((springManorBrochureDetailViewOpenParam != null) ? springManorBrochureDetailViewOpenParam.ActivityId : 0);
			this.CurrentDetailPointIndex = ((springManorBrochureDetailViewOpenParam != null) ? springManorBrochureDetailViewOpenParam.StartIndex : 0);
			this.IsHideReward = (springManorBrochureDetailViewOpenParam != null && springManorBrochureDetailViewOpenParam.IsHideReward);
			ActivityBaseData activityById = ActivityModel.Instance.GetActivityById(this.ActivityId);
			PopupCaptionItem captionItem = this.CaptionItem;
			if (captionItem != null)
			{
				captionItem.SetTitle((activityById != null) ? activityById.GetTitle() : null);
			}
			PopupCaptionItem captionItem2 = this.CaptionItem;
			if (captionItem2 != null)
			{
				captionItem2.SetHelpCallBack(new Action(this.OnClickMoreButton));
			}
			this.InitDetailData();
			this.RefreshPage();
			this.UpdateArrowBtnVisible();
		}

		// Token: 0x0603E78C RID: 255884 RVA: 0x00F1924C File Offset: 0x00F1744C
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.OnBrochureBookItemStateUpdate, new Action(this.OnBrochureBookItemStateUpdate));
		}

		// Token: 0x0603E78D RID: 255885 RVA: 0x00F1926A File Offset: 0x00F1746A
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.OnBrochureBookItemStateUpdate, new Action(this.OnBrochureBookItemStateUpdate));
		}

		// Token: 0x0603E78E RID: 255886 RVA: 0x00F19288 File Offset: 0x00F17488
		private void OnPlaySequenceEvent(string sequenceName, string eventName)
		{
			if (eventName == "Sequence_Switch_Left" || eventName == "Sequence_Switch_Right")
			{
				GenericLayout<SpringManorBrochureDetailPointItem, int> bottomPointLayout = this.BottomPointLayout;
				if (bottomPointLayout != null)
				{
					bottomPointLayout.SelectGridProxy(this.CurrentDetailPointIndex, false);
				}
				this.RefreshPage();
			}
		}

		// Token: 0x0603E78F RID: 255887 RVA: 0x00F192C2 File Offset: 0x00F174C2
		private void OnBrochureBookItemStateUpdate()
		{
			this.RefreshPage();
		}

		// Token: 0x0603E790 RID: 255888 RVA: 0x00F192CA File Offset: 0x00F174CA
		private CommonItemSmallItemGrid InitGridItem()
		{
			return new CommonItemSmallItemGrid
			{
				ShowReceivedCallBack = ((TItem _) => this.IsRewarded)
			};
		}

		// Token: 0x0603E791 RID: 255889 RVA: 0x00F192E3 File Offset: 0x00F174E3
		private SpringManorBrochureDetailPointItem InitPointItem()
		{
			return new SpringManorBrochureDetailPointItem();
		}

		// Token: 0x0603E792 RID: 255890 RVA: 0x00F192EC File Offset: 0x00F174EC
		private void OnClickMoreButton()
		{
			int helpId = ActivityModel.Instance.GetActivityById(this.ActivityId).GetHelpId();
			HelpController.Instance.OpenHelpById(helpId);
		}

		// Token: 0x0603E793 RID: 255891 RVA: 0x00F1931C File Offset: 0x00F1751C
		private void OnClickRewardBtn()
		{
			int getCurDetailConfigId = this.GetCurDetailConfigId;
			SpringManorData activityData = SpringManorModel.Instance.ActivityData;
			BookItemInfo bookItemInfo = (activityData != null) ? activityData.GetBookItemDataById(getCurDetailConfigId) : null;
			if (bookItemInfo != null && bookItemInfo.BookItemState == BookItemState.BookItemUnlock)
			{
				SpringManorController.Instance.RequestBrochureReward(this.ActivityId, EBrochureType.Brochure, getCurDetailConfigId, false);
			}
		}

		// Token: 0x17009076 RID: 36982
		// (get) Token: 0x0603E794 RID: 255892 RVA: 0x00F19368 File Offset: 0x00F17568
		private int GetCurDetailConfigId
		{
			get
			{
				int currentDetailPointIndex = this.CurrentDetailPointIndex;
				if (currentDetailPointIndex < 0 || currentDetailPointIndex >= this.DetailIds.Count)
				{
					return 0;
				}
				return this.DetailIds[currentDetailPointIndex];
			}
		}

		// Token: 0x0603E795 RID: 255893 RVA: 0x00F1939C File Offset: 0x00F1759C
		private void InitDetailData()
		{
			this.DetailIds.Clear();
			SpringManorConfig instance = SpringManorConfig.Instance;
			Brochure? brochure = (instance != null) ? instance.GetSpringManorBrochureByActivityAndType(this.ActivityId, EBrochureType.Brochure) : null;
			if (brochure == null)
			{
				return;
			}
			List<int> list = new List<int>();
			for (int i = 0; i < brochure.Value.BookItemIdsLength; i++)
			{
				int num = brochure.Value.BookItemIds(i);
				list.Add(num);
				SpringManorConfig instance2 = SpringManorConfig.Instance;
				BookItem? bookItem = (instance2 != null) ? instance2.GetSpringManorBookItemById(num) : null;
				if (bookItem != null)
				{
					this.DetailIds.Add(num);
				}
			}
			GenericLayout<SpringManorBrochureDetailPointItem, int> bottomPointLayout = this.BottomPointLayout;
			if (bottomPointLayout == null)
			{
				return;
			}
			bottomPointLayout.RefreshByData(list, delegate
			{
				GenericLayout<SpringManorBrochureDetailPointItem, int> bottomPointLayout2 = this.BottomPointLayout;
				if (bottomPointLayout2 == null)
				{
					return;
				}
				bottomPointLayout2.SelectGridProxy(this.CurrentDetailPointIndex, false);
			}, false);
		}

		// Token: 0x0603E796 RID: 255894 RVA: 0x00F19470 File Offset: 0x00F17670
		private void RefreshPage()
		{
			int getCurDetailConfigId = this.GetCurDetailConfigId;
			this.SetDetailInfo(getCurDetailConfigId);
			SpringManorConfig instance = SpringManorConfig.Instance;
			Brochure? brochure = (instance != null) ? instance.GetSpringManorBrochureByActivityAndType(this.ActivityId, EBrochureType.Brochure) : null;
			if (brochure == null)
			{
				return;
			}
			List<int> list = new List<int>();
			for (int i = 0; i < brochure.Value.BookItemIdsLength; i++)
			{
				list.Add(brochure.Value.BookItemIds(i));
			}
			GenericLayout<SpringManorBrochureDetailPointItem, int> bottomPointLayout = this.BottomPointLayout;
			if (bottomPointLayout == null)
			{
				return;
			}
			bottomPointLayout.RefreshByData(list, delegate
			{
				GenericLayout<SpringManorBrochureDetailPointItem, int> bottomPointLayout2 = this.BottomPointLayout;
				if (bottomPointLayout2 == null)
				{
					return;
				}
				bottomPointLayout2.SelectGridProxy(this.CurrentDetailPointIndex, false);
			}, false);
		}

		// Token: 0x0603E797 RID: 255895 RVA: 0x00F19514 File Offset: 0x00F17714
		private void SetDetailInfo(int configId)
		{
			SpringManorConfig instance = SpringManorConfig.Instance;
			BookItem? bookItem = (instance != null) ? instance.GetSpringManorBookItemById(configId) : null;
			if (bookItem == null)
			{
				return;
			}
			BookItemState bookItemState = BookItemState.BookItemRewarded;
			if (!this.IsHideReward)
			{
				SpringManorData activityData = SpringManorModel.Instance.ActivityData;
				BookItemInfo bookItemInfo = (activityData != null) ? activityData.GetBookItemDataById(configId) : null;
				if (bookItemInfo == null)
				{
					return;
				}
				bookItemState = bookItemInfo.BookItemState;
			}
			bool flag = bookItemState == BookItemState.BookItemLock;
			bool flag2 = bookItemState == BookItemState.BookItemRewarded;
			bool uiactive = bookItemState == BookItemState.BookItemUnlock;
			UUIItem item = base.GetItem(2);
			if (item != null)
			{
				item.SetUIActive(flag);
			}
			if (flag)
			{
				base.SetTextureByPath(bookItem.Value.ScreenIconPath, base.GetTexture(1), null, null);
				UUIText text = base.GetText(3);
				if (text != null)
				{
					text.ShowTextNew(bookItem.Value.GuideText);
				}
				string key = StringUtils.IsBlank(bookItem.Value.DescriptionTitle) ? bookItem.Value.GuideTitle : bookItem.Value.DescriptionTitle;
				UUIText text2 = base.GetText(4);
				if (text2 != null)
				{
					text2.ShowTextNew(key);
				}
			}
			else
			{
				UUIText text3 = base.GetText(3);
				if (text3 != null)
				{
					text3.ShowTextNew(bookItem.Value.DescriptionText);
				}
				base.SetTextureByPath(bookItem.Value.ScreenIconDonePath, base.GetTexture(1), null, null);
				UUIText text4 = base.GetText(4);
				if (text4 != null)
				{
					text4.ShowTextNew(bookItem.Value.DescriptionTitle);
				}
			}
			SpringManorConfig instance2 = SpringManorConfig.Instance;
			List<TItem> rewardItems = (instance2 != null) ? instance2.GetRewardItem(bookItem.Value.DroptId) : null;
			this.SetRewardItems(rewardItems, flag2);
			UUIButtonComponent button = base.GetButton(11);
			if (button != null)
			{
				button.RootUIComp.Get().SetUIActive(flag);
			}
			UUIButtonComponent button2 = base.GetButton(14);
			if (button2 != null)
			{
				button2.RootUIComp.Get().SetUIActive(uiactive);
			}
			UUIItem item2 = base.GetItem(15);
			if (item2 == null)
			{
				return;
			}
			item2.SetUIActive(flag2);
		}

		// Token: 0x0603E798 RID: 255896 RVA: 0x00F1972C File Offset: 0x00F1792C
		[NullableContext(2)]
		public void SetRewardItems(List<TItem> rewardItems, bool isRewarded)
		{
			this.IsRewarded = isRewarded;
			bool flag = !this.IsHideReward && rewardItems != null && rewardItems.Count > 0;
			GenericLayout<CommonItemSmallItemGrid, TItem> rewardItemLayout = this.RewardItemLayout;
			if (rewardItemLayout != null)
			{
				rewardItemLayout.SetActive(flag);
			}
			if (flag)
			{
				GenericLayout<CommonItemSmallItemGrid, TItem> rewardItemLayout2 = this.RewardItemLayout;
				if (rewardItemLayout2 != null)
				{
					rewardItemLayout2.RefreshByData(rewardItems, null, false);
				}
			}
			UUIItem item = base.GetItem(7);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(flag);
		}

		// Token: 0x0603E799 RID: 255897 RVA: 0x00F19794 File Offset: 0x00F17994
		private void OnClickBtnBrochurePre()
		{
			if (this.CurrentDetailPointIndex <= 0)
			{
				return;
			}
			this.SequencePlayer.PlayLevelSequenceByName("Switch_Left", false, null, false);
			this.CurrentDetailPointIndex--;
			this.UpdateArrowBtnVisible();
		}

		// Token: 0x0603E79A RID: 255898 RVA: 0x00F197DC File Offset: 0x00F179DC
		private void OnClickBtnBrochureNext()
		{
			if (this.CurrentDetailPointIndex >= this.DetailIds.Count - 1)
			{
				return;
			}
			this.SequencePlayer.PlayLevelSequenceByName("Switch_Right", false, null, false);
			this.CurrentDetailPointIndex++;
			this.UpdateArrowBtnVisible();
		}

		// Token: 0x0603E79B RID: 255899 RVA: 0x00F19830 File Offset: 0x00F17A30
		private void UpdateArrowBtnVisible()
		{
			int currentDetailPointIndex = this.CurrentDetailPointIndex;
			UUIButtonComponent button = base.GetButton(12);
			TWeakObjectPtr<UUIItem>? tweakObjectPtr = (button != null) ? new TWeakObjectPtr<UUIItem>?(button.RootUIComp) : null;
			if (tweakObjectPtr != null)
			{
				UUIItem uuiitem = tweakObjectPtr.GetValueOrDefault().Get();
				if (uuiitem != null)
				{
					uuiitem.SetUIActive(currentDetailPointIndex < this.DetailIds.Count - 1);
				}
			}
			UUIButtonComponent button2 = base.GetButton(13);
			TWeakObjectPtr<UUIItem>? tweakObjectPtr2 = (button2 != null) ? new TWeakObjectPtr<UUIItem>?(button2.RootUIComp) : null;
			if (tweakObjectPtr2 != null)
			{
				UUIItem uuiitem2 = tweakObjectPtr2.GetValueOrDefault().Get();
				if (uuiitem2 == null)
				{
					return;
				}
				uuiitem2.SetUIActive(currentDetailPointIndex > 0);
			}
		}

		// Token: 0x0603E79C RID: 255900 RVA: 0x00F198E4 File Offset: 0x00F17AE4
		private void OnClickBtnTracking()
		{
			SpringManorConfig instance = SpringManorConfig.Instance;
			BookItem? bookItem = (instance != null) ? instance.GetSpringManorBookItemById(this.GetCurDetailConfigId) : null;
			if (bookItem == null)
			{
				return;
			}
			if (bookItem.Value.TeleportEntityId > 0)
			{
				this.TeleportPlayerToEntity(this.GetCurDetailConfigId).Forget();
			}
		}

		// Token: 0x0603E79D RID: 255901 RVA: 0x00F19940 File Offset: 0x00F17B40
		private UniTask TeleportPlayerToEntity(int configId)
		{
			SpringManorBrochureDetailView.<TeleportPlayerToEntity>d__31 <TeleportPlayerToEntity>d__;
			<TeleportPlayerToEntity>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<TeleportPlayerToEntity>d__.configId = configId;
			<TeleportPlayerToEntity>d__.<>1__state = -1;
			<TeleportPlayerToEntity>d__.<>t__builder.Start<SpringManorBrochureDetailView.<TeleportPlayerToEntity>d__31>(ref <TeleportPlayerToEntity>d__);
			return <TeleportPlayerToEntity>d__.<>t__builder.Task;
		}

		// Token: 0x04020AF3 RID: 133875
		[Nullable(2)]
		private PopupCaptionItem CaptionItem;

		// Token: 0x04020AF4 RID: 133876
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericLayout<CommonItemSmallItemGrid, TItem> RewardItemLayout;

		// Token: 0x04020AF5 RID: 133877
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericLayout<SpringManorBrochureDetailPointItem, int> BottomPointLayout;

		// Token: 0x04020AF6 RID: 133878
		private bool IsRewarded;

		// Token: 0x04020AF7 RID: 133879
		private int CurrentDetailPointIndex;

		// Token: 0x04020AF8 RID: 133880
		private readonly List<int> DetailIds = new List<int>();

		// Token: 0x04020AF9 RID: 133881
		private int ActivityId;

		// Token: 0x04020AFA RID: 133882
		private bool IsHideReward;

		// Token: 0x04020AFB RID: 133883
		[Nullable(2)]
		private LevelSequencePlayer SequencePlayer;
	}
}
