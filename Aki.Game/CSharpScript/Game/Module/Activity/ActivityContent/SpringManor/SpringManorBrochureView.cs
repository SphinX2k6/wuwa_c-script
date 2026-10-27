using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.SpringManor
{
	// Token: 0x02006087 RID: 24711
	[NullableContext(1)]
	[Nullable(0)]
	public class SpringManorBrochureView : UiViewBase
	{
		// Token: 0x0603E7A2 RID: 255906 RVA: 0x00F199C6 File Offset: 0x00F17BC6
		public SpringManorBrochureView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0603E7A3 RID: 255907 RVA: 0x00F199D0 File Offset: 0x00F17BD0
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIText)),
				new ValueTuple<int, Type>(1, typeof(UUIScrollViewWithScrollbarComponent)),
				new ValueTuple<int, Type>(2, typeof(UUIHorizontalLayout)),
				new ValueTuple<int, Type>(3, typeof(UUIItem)),
				new ValueTuple<int, Type>(4, typeof(UUIItem)),
				new ValueTuple<int, Type>(5, typeof(UUIText))
			};
		}

		// Token: 0x0603E7A4 RID: 255908 RVA: 0x00F19A6C File Offset: 0x00F17C6C
		protected override void OnStart()
		{
			AUIBaseActor rootActor = this.RootActor;
			if (rootActor != null)
			{
				rootActor.OnSequencePlayEvent.Bind(new Action<string, string>(this.OnPlaySequenceEvent));
			}
			this.CaptionItem = new PopupCaptionItem(base.GetItem(4));
			this.CaptionItem.SetHelpBtnActive(false);
			this.CaptionItem.SetCloseCallBack(delegate
			{
				UiManager.Instance.ResetToBattleView(null);
			});
			this.ScrollList = new GenericScrollViewNew<SpringManorBrochureItem, BrochureItemData>(base.GetScrollViewWithScrollbar(1), new Func<SpringManorBrochureItem>(this.InitDeTermItem), null, false, null);
		}

		// Token: 0x0603E7A5 RID: 255909 RVA: 0x00F19B04 File Offset: 0x00F17D04
		protected override void OnBeforeShow()
		{
			SpringManorBrochureViewOpenParam springManorBrochureViewOpenParam = this.OpenParam as SpringManorBrochureViewOpenParam;
			this.IsHideReward = (springManorBrochureViewOpenParam != null && springManorBrochureViewOpenParam.IsHideReward);
			this.ActivityId = ((springManorBrochureViewOpenParam != null) ? springManorBrochureViewOpenParam.ActivityId : SpringManorModel.Instance.ActivityData.Id);
			PopupCaptionItem captionItem = this.CaptionItem;
			if (captionItem != null)
			{
				captionItem.SetTitleByTextIdAndArgNew("Brochure_ActivityName", Array.Empty<object>());
			}
			PopupCaptionItem captionItem2 = this.CaptionItem;
			if (captionItem2 != null)
			{
				captionItem2.SetHelpCallBack(new Action(this.OnClickMoreButton));
			}
			this.RefreshBrochureItem();
		}

		// Token: 0x0603E7A6 RID: 255910 RVA: 0x00F19B8D File Offset: 0x00F17D8D
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.OnBrochureBookItemStateUpdate, new Action(this.OnBrochureBookItemStateUpdate));
		}

		// Token: 0x0603E7A7 RID: 255911 RVA: 0x00F19BAB File Offset: 0x00F17DAB
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.OnBrochureBookItemStateUpdate, new Action(this.OnBrochureBookItemStateUpdate));
		}

		// Token: 0x0603E7A8 RID: 255912 RVA: 0x00F19BCC File Offset: 0x00F17DCC
		private void OnPlaySequenceEvent(string sequenceName, string eventName)
		{
			if (eventName == "Sequence_Content_In")
			{
				GenericScrollViewNew<SpringManorBrochureItem, BrochureItemData> scrollList = this.ScrollList;
				UUIItem uuiitem = (scrollList != null) ? scrollList.GetItemByIndex(this.ScrollToTargetIndex) : null;
				if (uuiitem != null)
				{
					UUIScrollViewWithScrollbarComponent scrollViewWithScrollbar = base.GetScrollViewWithScrollbar(1);
					if (scrollViewWithScrollbar == null)
					{
						return;
					}
					scrollViewWithScrollbar.ScrollTo(uuiitem, true);
					return;
				}
			}
			else if (eventName == "Sequence_Brochure_Start_Unlock")
			{
				this.CheckAllItemPlayedSequence();
			}
		}

		// Token: 0x0603E7A9 RID: 255913 RVA: 0x00F19C29 File Offset: 0x00F17E29
		private SpringManorBrochureItem InitDeTermItem()
		{
			SpringManorBrochureItem springManorBrochureItem = new SpringManorBrochureItem();
			springManorBrochureItem.SetToggleCallBack(new Action<BrochureItemData>(this.ClickItem));
			springManorBrochureItem.SetClickGetButtonCallBack(new Action<BrochureItemData>(this.ClickGetButton));
			return springManorBrochureItem;
		}

		// Token: 0x0603E7AA RID: 255914 RVA: 0x00F19C54 File Offset: 0x00F17E54
		private void OnClickMoreButton()
		{
			int helpId = ActivityModel.Instance.GetActivityById(this.ActivityId).GetHelpId();
			HelpController.Instance.OpenHelpById(helpId);
		}

		// Token: 0x0603E7AB RID: 255915 RVA: 0x00F19C84 File Offset: 0x00F17E84
		[NullableContext(2)]
		private void ClickGetButton(BrochureItemData tabData)
		{
			int num = (tabData != null) ? tabData.ConfigId : 0;
			if (num > 0)
			{
				BookItemInfo bookItemDataById = SpringManorModel.Instance.ActivityData.GetBookItemDataById(num);
				if (bookItemDataById != null && bookItemDataById.BookItemState == BookItemState.BookItemUnlock)
				{
					SpringManorController.Instance.RequestBrochureReward(this.ActivityId, EBrochureType.Brochure, num, true);
				}
			}
		}

		// Token: 0x0603E7AC RID: 255916 RVA: 0x00F19CD4 File Offset: 0x00F17ED4
		[NullableContext(2)]
		public void ClickItem(BrochureItemData tabData)
		{
			SpringManorBrochureDetailViewOpenParam param = new SpringManorBrochureDetailViewOpenParam
			{
				ActivityId = this.ActivityId,
				StartIndex = ((tabData != null) ? tabData.Index : 0),
				IsHideReward = this.IsHideReward
			};
			UiManager.Instance.OpenView(EUiViewName.SpringManorBrochureDetailView, param, null);
		}

		// Token: 0x0603E7AD RID: 255917 RVA: 0x00F19D22 File Offset: 0x00F17F22
		private void OnBrochureBookItemStateUpdate()
		{
			this.RefreshBrochureItem();
		}

		// Token: 0x0603E7AE RID: 255918 RVA: 0x00F19D2C File Offset: 0x00F17F2C
		private void RefreshBrochureItem()
		{
			Brochure? springManorBrochureByActivityAndType = SpringManorConfig.Instance.GetSpringManorBrochureByActivityAndType(this.ActivityId, EBrochureType.Brochure);
			if (springManorBrochureByActivityAndType == null)
			{
				return;
			}
			List<BrochureItemData> list = new List<BrochureItemData>();
			int num = 0;
			int num2 = -1;
			int num3 = -1;
			for (int i = 0; i < springManorBrochureByActivityAndType.Value.BookItemIdsLength; i++)
			{
				int num4 = springManorBrochureByActivityAndType.Value.BookItemIds(i);
				if (SpringManorConfig.Instance.GetSpringManorBookItemById(num4) != null)
				{
					BrochureItemData brochureItemData = new BrochureItemData();
					if (this.IsHideReward)
					{
						brochureItemData.State = EBrochureState.Rewarded;
					}
					else
					{
						SpringManorData activityData = SpringManorModel.Instance.ActivityData;
						brochureItemData.State = activityData.GetBookItemStateById(num4);
					}
					if (brochureItemData.State == EBrochureState.Rewarded)
					{
						num++;
					}
					else if (num2 < 0 && brochureItemData.State == EBrochureState.Lock)
					{
						num2 = i;
					}
					else if (num3 < 0 && brochureItemData.State == EBrochureState.Unlock)
					{
						num3 = i;
					}
					brochureItemData.ConfigId = num4;
					brochureItemData.Index = i;
					list.Add(brochureItemData);
				}
			}
			LguiUtil.Instance.SetLocalTextNew(base.GetText(5), "Brochure_ProgressStatus", new <>z__ReadOnlyArray<object>(new object[]
			{
				num,
				springManorBrochureByActivityAndType.Value.BookItemIdsLength
			}));
			this.ScrollToTargetIndex = ((num3 >= 0) ? num3 : ((num2 >= 0) ? num2 : 0));
			GenericScrollViewNew<SpringManorBrochureItem, BrochureItemData> scrollList = this.ScrollList;
			if (scrollList == null)
			{
				return;
			}
			scrollList.RefreshByData(list, null, false);
		}

		// Token: 0x0603E7AF RID: 255919 RVA: 0x00F19EA8 File Offset: 0x00F180A8
		private void CheckAllItemPlayedSequence()
		{
			GenericScrollViewNew<SpringManorBrochureItem, BrochureItemData> scrollList = this.ScrollList;
			foreach (SpringManorBrochureItem springManorBrochureItem in (((scrollList != null) ? scrollList.GetScrollItemList() : null) ?? new List<SpringManorBrochureItem>()))
			{
				springManorBrochureItem.CheckPlayUnlockSequence();
			}
		}

		// Token: 0x04020B03 RID: 133891
		[Nullable(2)]
		private PopupCaptionItem CaptionItem;

		// Token: 0x04020B04 RID: 133892
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericScrollViewNew<SpringManorBrochureItem, BrochureItemData> ScrollList;

		// Token: 0x04020B05 RID: 133893
		private int ActivityId;

		// Token: 0x04020B06 RID: 133894
		private int ScrollToTargetIndex;

		// Token: 0x04020B07 RID: 133895
		private bool IsHideReward;
	}
}
