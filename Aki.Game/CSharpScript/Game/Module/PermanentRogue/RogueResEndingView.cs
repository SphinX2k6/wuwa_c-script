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
	// Token: 0x020042E3 RID: 17123
	[NullableContext(1)]
	[Nullable(0)]
	public class RogueResEndingView : UiViewBase
	{
		// Token: 0x0602B546 RID: 177478 RVA: 0x00C2CA9C File Offset: 0x00C2AC9C
		public RogueResEndingView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0602B547 RID: 177479 RVA: 0x00C2CAC8 File Offset: 0x00C2ACC8
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

		// Token: 0x0602B548 RID: 177480 RVA: 0x00C2CC28 File Offset: 0x00C2AE28
		protected override UniTask OnBeforeStartAsync()
		{
			RogueResEndingView.<OnBeforeStartAsync>d__12 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RogueResEndingView.<OnBeforeStartAsync>d__12>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602B549 RID: 177481 RVA: 0x00C2CC6B File Offset: 0x00C2AE6B
		protected override void OnStart()
		{
			this.SeasonId = (int)this.OpenParam;
		}

		// Token: 0x0602B54A RID: 177482 RVA: 0x00C2CC80 File Offset: 0x00C2AE80
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

		// Token: 0x0602B54B RID: 177483 RVA: 0x00C2CD6B File Offset: 0x00C2AF6B
		protected override void OnBeforeHide()
		{
			RogueButtonItemA btnMulti = this.BtnMulti;
			if (btnMulti == null)
			{
				return;
			}
			btnMulti.UnBindRedDot();
		}

		// Token: 0x0602B54C RID: 177484 RVA: 0x00C2CD7D File Offset: 0x00C2AF7D
		protected override void OnBeforeDestroy()
		{
			this.CaptionItem = null;
			this.BtnMulti = null;
		}

		// Token: 0x0602B54D RID: 177485 RVA: 0x00C2CD90 File Offset: 0x00C2AF90
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.PermanentRogueRewardUpdate, new Action(this.OnRefreshAward));
			EventSystem.Instance.Add(EEventName.RogueResEndingRedDotUpdate, new Action(this.RefreshEndingRedDotList));
			EventSystem.Instance.Add<int>(EEventName.RogueResEndingSwitch, new Action<int>(this.RefreshEndingScrollChange));
			EventSystem.Instance.Add(EEventName.OnActivitySequenceEmitEvent, new Action<string>(this.OnStartAnimStart));
			base.GetSlider(5).OnValueChangeCb.Bind(new Action<float>(this.OnSizeSliderValueChanged));
			base.GetScrollViewWithScrollbar(8).OnScrollValueChange.Bind(new Action<FVector2D>(this.OnScrollValueChanged));
		}

		// Token: 0x0602B54E RID: 177486 RVA: 0x00C2CE48 File Offset: 0x00C2B048
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.PermanentRogueRewardUpdate, new Action(this.OnRefreshAward));
			EventSystem.Instance.Remove(EEventName.RogueResEndingRedDotUpdate, new Action(this.RefreshEndingRedDotList));
			EventSystem.Instance.Remove(EEventName.RogueResEndingSwitch, new Action<int>(this.RefreshEndingScrollChange));
			EventSystem.Instance.Remove(EEventName.OnActivitySequenceEmitEvent, new Action<string>(this.OnStartAnimStart));
			base.GetSlider(5).OnValueChangeCb.Unbind();
			base.GetScrollViewWithScrollbar(8).OnScrollValueChange.Unbind();
		}

		// Token: 0x0602B54F RID: 177487 RVA: 0x00C2CEE7 File Offset: 0x00C2B0E7
		private RogueEndingCollectionItem InitEndingItem()
		{
			return new RogueEndingCollectionItem
			{
				OnItemClickCall = new Action<int>(this.OnClickItem)
			};
		}

		// Token: 0x0602B550 RID: 177488 RVA: 0x00C2CF00 File Offset: 0x00C2B100
		private void OnClickBack()
		{
			base.CloseMe(null);
		}

		// Token: 0x0602B551 RID: 177489 RVA: 0x00C2CF0C File Offset: 0x00C2B10C
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

		// Token: 0x0602B552 RID: 177490 RVA: 0x00C2CF6E File Offset: 0x00C2B16E
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

		// Token: 0x0602B553 RID: 177491 RVA: 0x00C2CF9B File Offset: 0x00C2B19B
		private void OnRefreshAward()
		{
		}

		// Token: 0x0602B554 RID: 177492 RVA: 0x00C2CFA0 File Offset: 0x00C2B1A0
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

		// Token: 0x0602B555 RID: 177493 RVA: 0x00C2D044 File Offset: 0x00C2B244
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

		// Token: 0x0602B556 RID: 177494 RVA: 0x00C2D0E6 File Offset: 0x00C2B2E6
		private void OnSizeSliderValueChanged(float value)
		{
			UUIScrollViewWithScrollbarComponent scrollViewWithScrollbar = base.GetScrollViewWithScrollbar(8);
			if (scrollViewWithScrollbar != null)
			{
				scrollViewWithScrollbar.SetScrollProgress(1f - value);
			}
			this.StartFromSlider = true;
		}

		// Token: 0x0602B557 RID: 177495 RVA: 0x00C2D108 File Offset: 0x00C2B308
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

		// Token: 0x0602B558 RID: 177496 RVA: 0x00C2D14C File Offset: 0x00C2B34C
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

		// Token: 0x0602B559 RID: 177497 RVA: 0x00C2D1B4 File Offset: 0x00C2B3B4
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

		// Token: 0x0602B55A RID: 177498 RVA: 0x00C2D1ED File Offset: 0x00C2B3ED
		private void OnStartAnimStart(string param)
		{
			this.RefreshEnding();
		}

		// Token: 0x0602B55B RID: 177499 RVA: 0x00C2D1F8 File Offset: 0x00C2B3F8
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

		// Token: 0x0602B55C RID: 177500 RVA: 0x00C2D2AC File Offset: 0x00C2B4AC
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

		// Token: 0x04017625 RID: 95781
		[Nullable(2)]
		private PopupCaptionItem CaptionItem;

		// Token: 0x04017626 RID: 95782
		[Nullable(2)]
		private RogueButtonItemA BtnMulti;

		// Token: 0x04017627 RID: 95783
		private const float ROTATION_PARAM = 9f;

		// Token: 0x04017628 RID: 95784
		private const float REDDOT_TOLERANCE = 0.1f;

		// Token: 0x04017629 RID: 95785
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericScrollViewNew<RogueEndingCollectionItem, IRogueEndingItemParam> EndingScrollView;

		// Token: 0x0401762A RID: 95786
		private int SeasonId;

		// Token: 0x0401762B RID: 95787
		private List<int> EndingIdList = new List<int>();

		// Token: 0x0401762C RID: 95788
		private readonly List<int> EndingRedDotList = new List<int>();

		// Token: 0x0401762D RID: 95789
		private readonly List<IRogueEndingItemParam> EndingItemList = new List<IRogueEndingItemParam>();

		// Token: 0x0401762E RID: 95790
		private bool StartFromSlider;
	}
}
