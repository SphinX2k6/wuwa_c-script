using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.PermanentRogue
{
	// Token: 0x02005313 RID: 21267
	[NullableContext(1)]
	[Nullable(0)]
	public class RogueResEndingView : UiViewBase
	{
		// Token: 0x0603664A RID: 222794 RVA: 0x00CDF0CC File Offset: 0x00CDD2CC
		public RogueResEndingView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0603664B RID: 222795 RVA: 0x00CDF0F8 File Offset: 0x00CDD2F8
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIItem)),
				new ValueTuple<int, Type>(1, typeof(UUIText)),
				new ValueTuple<int, Type>(2, typeof(UUIHorizontalLayout)),
				new ValueTuple<int, Type>(3, typeof(UUIItem)),
				new ValueTuple<int, Type>(4, typeof(UUIItem)),
				new ValueTuple<int, Type>(5, typeof(UUISliderComponent)),
				new ValueTuple<int, Type>(6, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(7, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(8, typeof(UUIScrollViewWithScrollbarComponent)),
				new ValueTuple<int, Type>(9, typeof(UUIItem)),
				new ValueTuple<int, Type>(10, typeof(UUIItem)),
				new ValueTuple<int, Type>(11, typeof(UUIItem))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(6, new Action(this.OnClickLeft)),
				new ValueTuple<int, Delegate>(7, new Action(this.OnClickRight))
			};
		}

		// Token: 0x0603664C RID: 222796 RVA: 0x00CDF258 File Offset: 0x00CDD458
		protected override UniTask OnBeforeStartAsync()
		{
			RogueResEndingView.<OnBeforeStartAsync>d__12 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RogueResEndingView.<OnBeforeStartAsync>d__12>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603664D RID: 222797 RVA: 0x00CDF29B File Offset: 0x00CDD49B
		protected override void OnStart()
		{
			this.SeasonId = (int)this.OpenParam;
		}

		// Token: 0x0603664E RID: 222798 RVA: 0x00CDF2B0 File Offset: 0x00CDD4B0
		protected override void OnBeforeShow()
		{
			int[] endingAwardCount = ActivityPermanentRogueModel.Instance.GetEndingAwardCount(this.SeasonId);
			RogueButtonItemA btnMulti = this.BtnMulti;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
			defaultInterpolatedStringHandler.AppendFormatted<int>(endingAwardCount[0]);
			defaultInterpolatedStringHandler.AppendLiteral("/");
			defaultInterpolatedStringHandler.AppendFormatted<int>(endingAwardCount[1]);
			btnMulti.SetNum(defaultInterpolatedStringHandler.ToStringAndClear());
			RogueButtonItemA btnMulti2 = this.BtnMulti;
			if (btnMulti2 != null)
			{
				btnMulti2.BindRedDot(ERedDotName.RogueResEnding, new int?(this.SeasonId));
			}
			this.EndingIdList = ActivityPermanentRogueModel.Instance.GetEndingListBySeasonId(this.SeasonId);
			int[] endingCount = ActivityPermanentRogueModel.Instance.GetEndingCount(this.SeasonId);
			UUIItem item = base.GetItem(9);
			if (item != null)
			{
				item.SetUIActive(endingCount[0] == 0);
			}
			UUIItem item2 = base.GetItem(10);
			if (item2 != null)
			{
				item2.SetUIActive(endingCount[0] != 0);
			}
			UUIItem item3 = base.GetItem(11);
			if (item3 == null)
			{
				return;
			}
			item3.SetUIActive(endingCount[0] != 0);
		}

		// Token: 0x0603664F RID: 222799 RVA: 0x00CDF39B File Offset: 0x00CDD59B
		protected override void OnBeforeHide()
		{
			RogueButtonItemA btnMulti = this.BtnMulti;
			if (btnMulti == null)
			{
				return;
			}
			btnMulti.UnBindRedDot();
		}

		// Token: 0x06036650 RID: 222800 RVA: 0x00CDF3AD File Offset: 0x00CDD5AD
		protected override void OnBeforeDestroy()
		{
			this.CaptionItem = null;
			this.BtnMulti = null;
		}

		// Token: 0x06036651 RID: 222801 RVA: 0x00CDF3C0 File Offset: 0x00CDD5C0
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.PermanentRogueRewardUpdate, new Action(this.OnRefreshAward));
			EventSystem.Instance.Add(EEventName.RogueResEndingRedDotUpdate, new Action(this.RefreshEndingRedDotList));
			EventSystem.Instance.Add<int>(EEventName.RogueResEndingSwitch, new Action<int>(this.RefreshEndingScrollChange));
			EventSystem.Instance.Add(EEventName.OnActivitySequenceEmitEvent, new Action<string>(this.OnStartAnimStart));
			base.GetSlider(5).OnValueChangeCb.Bind(new Action<float>(this.OnSizeSliderValueChanged));
			base.GetScrollViewWithScrollbar(8).OnScrollValueChange.Bind(new Action<FVector2D>(this.OnScrollValueChanged));
		}

		// Token: 0x06036652 RID: 222802 RVA: 0x00CDF478 File Offset: 0x00CDD678
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.PermanentRogueRewardUpdate, new Action(this.OnRefreshAward));
			EventSystem.Instance.Remove(EEventName.RogueResEndingRedDotUpdate, new Action(this.RefreshEndingRedDotList));
			EventSystem.Instance.Remove(EEventName.RogueResEndingSwitch, new Action<int>(this.RefreshEndingScrollChange));
			EventSystem.Instance.Remove(EEventName.OnActivitySequenceEmitEvent, new Action<string>(this.OnStartAnimStart));
			base.GetSlider(5).OnValueChangeCb.Unbind();
			base.GetScrollViewWithScrollbar(8).OnScrollValueChange.Unbind();
		}

		// Token: 0x06036653 RID: 222803 RVA: 0x00CDF517 File Offset: 0x00CDD717
		private RogueEndingCollectionItem InitEndingItem()
		{
			return new RogueEndingCollectionItem
			{
				OnItemClickCall = new Action<int>(this.OnClickItem)
			};
		}

		// Token: 0x06036654 RID: 222804 RVA: 0x00CDF530 File Offset: 0x00CDD730
		private void OnClickBack()
		{
			base.CloseMe(null);
		}

		// Token: 0x06036655 RID: 222805 RVA: 0x00CDF53C File Offset: 0x00CDD73C
		private void OnClickItem(int id)
		{
			bool endingIsUnlock = ActivityPermanentRogueModel.Instance.GetEndingIsUnlock(id);
			if (!endingIsUnlock)
			{
				ScrollingTipsController.Instance.ShowTipsByTextId("Rogue_End_S1_Lock", Array.Empty<object>());
				return;
			}
			if (endingIsUnlock && !ActivityPermanentRogueModel.Instance.GetCacheEndingOpen(id))
			{
				ActivityPermanentRogueModel.Instance.SetCacheEndingOpen(id);
			}
			UiManager.Instance.OpenView(EUiViewName.RogueResEndingSubView, id, null);
		}

		// Token: 0x06036656 RID: 222806 RVA: 0x00CDF59E File Offset: 0x00CDD79E
		private void OnClickTask()
		{
			UiManager.Instance.OpenView(EUiViewName.ActivityRewardPopUpView, ActivityPermanentRogueModel.Instance.GetEndingAwardViewData(this.SeasonId), delegate(bool success, int viewId)
			{
				if (success)
				{
					base.AddChildViewById(viewId);
				}
			});
		}

		// Token: 0x06036657 RID: 222807 RVA: 0x00CDF5CB File Offset: 0x00CDD7CB
		private void OnRefreshAward()
		{
		}

		// Token: 0x06036658 RID: 222808 RVA: 0x00CDF5D0 File Offset: 0x00CDD7D0
		private void OnClickLeft()
		{
			int count = this.EndingRedDotList.Count;
			for (int i = count - 1; i >= 0; i--)
			{
				UUIItem itemByIndex = this.EndingScrollView.GetItemByIndex(this.EndingRedDotList[i]);
				if (this.EndingScrollView.IsItemInViewport(itemByIndex, 0.1f) == EOutOfBoundsType.OutOfBegin)
				{
					UUIItem itemByIndex2 = this.EndingScrollView.GetItemByIndex(this.EndingRedDotList[i]);
					this.EndingScrollView.ScrollTo(itemByIndex2, false);
					return;
				}
			}
			UUIItem itemByIndex3 = this.EndingScrollView.GetItemByIndex(this.EndingRedDotList[count - 1]);
			this.EndingScrollView.ScrollTo(itemByIndex3, false);
		}

		// Token: 0x06036659 RID: 222809 RVA: 0x00CDF674 File Offset: 0x00CDD874
		private void OnClickRight()
		{
			int count = this.EndingRedDotList.Count;
			for (int i = 0; i <= count - 2; i++)
			{
				UUIItem itemByIndex = this.EndingScrollView.GetItemByIndex(this.EndingRedDotList[i]);
				if (this.EndingScrollView.IsItemInViewport(itemByIndex, 0.1f) == EOutOfBoundsType.OutOfEnd)
				{
					UUIItem itemByIndex2 = this.EndingScrollView.GetItemByIndex(this.EndingRedDotList[i]);
					this.EndingScrollView.ScrollTo(itemByIndex2, false);
					return;
				}
			}
			UUIItem itemByIndex3 = this.EndingScrollView.GetItemByIndex(this.EndingRedDotList[count - 1]);
			this.EndingScrollView.ScrollTo(itemByIndex3, false);
		}

		// Token: 0x0603665A RID: 222810 RVA: 0x00CDF716 File Offset: 0x00CDD916
		private void OnSizeSliderValueChanged(float value)
		{
			UUIScrollViewWithScrollbarComponent scrollViewWithScrollbar = base.GetScrollViewWithScrollbar(8);
			if (scrollViewWithScrollbar != null)
			{
				scrollViewWithScrollbar.SetScrollProgress(1f - value);
			}
			this.StartFromSlider = true;
		}

		// Token: 0x0603665B RID: 222811 RVA: 0x00CDF738 File Offset: 0x00CDD938
		private void OnScrollValueChanged(FVector2D inVector)
		{
			float x = inVector.X;
			UUISliderComponent slider = base.GetSlider(5);
			if (!this.StartFromSlider && slider != null)
			{
				slider.SetValue(1f - x, false);
			}
			this.StartFromSlider = false;
			this.RefreshRedDotBtn();
		}

		// Token: 0x0603665C RID: 222812 RVA: 0x00CDF77C File Offset: 0x00CDD97C
		private void RefreshEndingRedDotList()
		{
			this.EndingRedDotList.Clear();
			for (int i = 0; i < this.EndingIdList.Count; i++)
			{
				int num = this.EndingIdList[i];
				if (ActivityPermanentRogueModel.Instance.GetEndingIsUnlock(num) && !ActivityPermanentRogueModel.Instance.GetCacheEndingOpen(num))
				{
					this.EndingRedDotList.Add(i);
				}
			}
			this.RefreshRedDotBtn();
		}

		// Token: 0x0603665D RID: 222813 RVA: 0x00CDF7E4 File Offset: 0x00CDD9E4
		private void RefreshEndingScrollChange(int endingId)
		{
			int num = this.EndingIdList.IndexOf(endingId);
			if (num == -1)
			{
				return;
			}
			UUIItem itemByIndex = this.EndingScrollView.GetItemByIndex(num);
			this.EndingScrollView.ScrollTo(itemByIndex, false);
		}

		// Token: 0x0603665E RID: 222814 RVA: 0x00CDF81D File Offset: 0x00CDDA1D
		private void OnStartAnimStart(string param)
		{
			this.RefreshEnding();
		}

		// Token: 0x0603665F RID: 222815 RVA: 0x00CDF828 File Offset: 0x00CDDA28
		private void RefreshEnding()
		{
			for (int i = 0; i < this.EndingIdList.Count; i++)
			{
				IRogueEndingItemParam item = new RogueEndingItemParam
				{
					ConfigId = this.EndingIdList[i],
					Index = i + 1,
					IsSubView = false,
					IsUnlock = ActivityPermanentRogueModel.Instance.GetEndingIsUnlock(this.EndingIdList[i]),
					Rotation = new float?((i % 2 == 0) ? 9f : -9f)
				};
				this.EndingItemList.Add(item);
			}
			GenericScrollViewNew<RogueEndingCollectionItem, IRogueEndingItemParam> endingScrollView = this.EndingScrollView;
			if (endingScrollView == null)
			{
				return;
			}
			endingScrollView.RefreshByData(this.EndingItemList, new Action(this.RefreshEndingRedDotList), true);
		}

		// Token: 0x06036660 RID: 222816 RVA: 0x00CDF8DC File Offset: 0x00CDDADC
		private void RefreshRedDotBtn()
		{
			if (this.EndingRedDotList.Count == 0)
			{
				UUIButtonComponent button = base.GetButton(6);
				if (button != null)
				{
					button.RootUIComp.Get().SetUIActive(false);
				}
				UUIButtonComponent button2 = base.GetButton(7);
				if (button2 == null)
				{
					return;
				}
				button2.RootUIComp.Get().SetUIActive(false);
				return;
			}
			else
			{
				UUIItem itemByIndex = this.EndingScrollView.GetItemByIndex(this.EndingRedDotList[0]);
				UUIItem itemByIndex2 = this.EndingScrollView.GetItemByIndex(this.EndingRedDotList[this.EndingRedDotList.Count - 1]);
				EOutOfBoundsType eoutOfBoundsType = this.EndingScrollView.IsItemInViewport(itemByIndex, 0.1f);
				UUIButtonComponent button3 = base.GetButton(6);
				if (button3 != null)
				{
					button3.RootUIComp.Get().SetUIActive(eoutOfBoundsType == EOutOfBoundsType.OutOfBegin);
				}
				EOutOfBoundsType eoutOfBoundsType2 = this.EndingScrollView.IsItemInViewport(itemByIndex2, 0.1f);
				UUIButtonComponent button4 = base.GetButton(7);
				if (button4 == null)
				{
					return;
				}
				button4.RootUIComp.Get().SetUIActive(eoutOfBoundsType2 == EOutOfBoundsType.OutOfEnd);
				return;
			}
		}

		// Token: 0x0401CBEF RID: 117743
		[Nullable(2)]
		private PopupCaptionItem CaptionItem;

		// Token: 0x0401CBF0 RID: 117744
		[Nullable(2)]
		private RogueButtonItemA BtnMulti;

		// Token: 0x0401CBF1 RID: 117745
		private const float ROTATION_PARAM = 9f;

		// Token: 0x0401CBF2 RID: 117746
		private const float REDDOT_TOLERANCE = 0.1f;

		// Token: 0x0401CBF3 RID: 117747
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericScrollViewNew<RogueEndingCollectionItem, IRogueEndingItemParam> EndingScrollView;

		// Token: 0x0401CBF4 RID: 117748
		private int SeasonId;

		// Token: 0x0401CBF5 RID: 117749
		private List<int> EndingIdList = new List<int>();

		// Token: 0x0401CBF6 RID: 117750
		private readonly List<int> EndingRedDotList = new List<int>();

		// Token: 0x0401CBF7 RID: 117751
		private readonly List<IRogueEndingItemParam> EndingItemList = new List<IRogueEndingItemParam>();

		// Token: 0x0401CBF8 RID: 117752
		private bool StartFromSlider;
	}
}
