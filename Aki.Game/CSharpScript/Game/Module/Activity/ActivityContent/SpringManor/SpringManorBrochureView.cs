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
	// Token: 0x02005005 RID: 20485
	[NullableContext(1)]
	[Nullable(0)]
	public class SpringManorBrochureView : UiViewBase
	{
		// Token: 0x06033466 RID: 210022 RVA: 0x00E6078A File Offset: 0x00E5E98A
		public SpringManorBrochureView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06033467 RID: 210023 RVA: 0x00E60794 File Offset: 0x00E5E994
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

		// Token: 0x06033468 RID: 210024 RVA: 0x00E60830 File Offset: 0x00E5EA30
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

		// Token: 0x06033469 RID: 210025 RVA: 0x00E608C8 File Offset: 0x00E5EAC8
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

		// Token: 0x0603346A RID: 210026 RVA: 0x00E60951 File Offset: 0x00E5EB51
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.OnBrochureBookItemStateUpdate, new Action(this.OnBrochureBookItemStateUpdate));
		}

		// Token: 0x0603346B RID: 210027 RVA: 0x00E6096F File Offset: 0x00E5EB6F
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.OnBrochureBookItemStateUpdate, new Action(this.OnBrochureBookItemStateUpdate));
		}

		// Token: 0x0603346C RID: 210028 RVA: 0x00E60990 File Offset: 0x00E5EB90
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

		// Token: 0x0603346D RID: 210029 RVA: 0x00E609ED File Offset: 0x00E5EBED
		private SpringManorBrochureItem InitDeTermItem()
		{
			SpringManorBrochureItem springManorBrochureItem = new SpringManorBrochureItem();
			springManorBrochureItem.SetToggleCallBack(new Action<BrochureItemData>(this.ClickItem));
			springManorBrochureItem.SetClickGetButtonCallBack(new Action<BrochureItemData>(this.ClickGetButton));
			return springManorBrochureItem;
		}

		// Token: 0x0603346E RID: 210030 RVA: 0x00E60A18 File Offset: 0x00E5EC18
		private void OnClickMoreButton()
		{
			int helpId = ActivityModel.Instance.GetActivityById(this.ActivityId).GetHelpId();
			HelpController.Instance.OpenHelpById(helpId);
		}

		// Token: 0x0603346F RID: 210031 RVA: 0x00E60A48 File Offset: 0x00E5EC48
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

		// Token: 0x06033470 RID: 210032 RVA: 0x00E60A98 File Offset: 0x00E5EC98
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

		// Token: 0x06033471 RID: 210033 RVA: 0x00E60AE6 File Offset: 0x00E5ECE6
		private void OnBrochureBookItemStateUpdate()
		{
			this.RefreshBrochureItem();
		}

		// Token: 0x06033472 RID: 210034 RVA: 0x00E60AF0 File Offset: 0x00E5ECF0
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

		// Token: 0x06033473 RID: 210035 RVA: 0x00E60C6C File Offset: 0x00E5EE6C
		private void CheckAllItemPlayedSequence()
		{
			GenericScrollViewNew<SpringManorBrochureItem, BrochureItemData> scrollList = this.ScrollList;
			foreach (SpringManorBrochureItem springManorBrochureItem in (((scrollList != null) ? scrollList.GetScrollItemList() : null) ?? new List<SpringManorBrochureItem>()))
			{
				springManorBrochureItem.CheckPlayUnlockSequence();
			}
		}

		// Token: 0x0401B430 RID: 111664
		[Nullable(2)]
		private PopupCaptionItem CaptionItem;

		// Token: 0x0401B431 RID: 111665
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericScrollViewNew<SpringManorBrochureItem, BrochureItemData> ScrollList;

		// Token: 0x0401B432 RID: 111666
		private int ActivityId;

		// Token: 0x0401B433 RID: 111667
		private int ScrollToTargetIndex;

		// Token: 0x0401B434 RID: 111668
		private bool IsHideReward;
	}
}
