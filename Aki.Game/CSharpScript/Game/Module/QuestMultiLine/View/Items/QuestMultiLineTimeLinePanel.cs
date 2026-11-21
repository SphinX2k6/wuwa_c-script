using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.QuestMultiLine.QuestMultiLineData;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.QuestMultiLine.View.Items
{
	// Token: 0x02003F8D RID: 16269
	[NullableContext(1)]
	[Nullable(0)]
	public class QuestMultiLineTimeLinePanel : UiPanelBase
	{
		// Token: 0x06029289 RID: 168585 RVA: 0x00B8ED94 File Offset: 0x00B8CF94
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIScrollViewWithScrollbarComponent)),
				new ValueTuple<int, Type>(1, typeof(UUIHorizontalLayout)),
				new ValueTuple<int, Type>(2, typeof(UUIItem)),
				new ValueTuple<int, Type>(3, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(4, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(5, typeof(UUIItem)),
				new ValueTuple<int, Type>(6, typeof(UUIItem)),
				new ValueTuple<int, Type>(7, typeof(UUIItem))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(3, new Action(this.OnClickLeft)),
				new ValueTuple<int, Delegate>(4, new Action(this.OnClickRight))
			};
		}

		// Token: 0x0602928A RID: 168586 RVA: 0x00B8EE98 File Offset: 0x00B8D098
		protected override void OnStart()
		{
			this.ScrollView = new GenericScrollViewNew<QuestMultiLineTimePointItem, QuestMultiLineTimePointData>(base.GetScrollViewWithScrollbar(0), delegate()
			{
				QuestMultiLineTimePointItem questMultiLineTimePointItem = new QuestMultiLineTimePointItem();
				questMultiLineTimePointItem.SetFunction(new Action<QuestMultiLineTimePointData>(this.OnClickTimePoint));
				return questMultiLineTimePointItem;
			}, null, false, null);
			this.LeftRedDotIndicator = base.GetItem(6);
			this.RightRedDotIndicator = base.GetItem(7);
			UUIItem leftRedDotIndicator = this.LeftRedDotIndicator;
			if (leftRedDotIndicator != null)
			{
				leftRedDotIndicator.SetUIActive(false);
			}
			UUIItem rightRedDotIndicator = this.RightRedDotIndicator;
			if (rightRedDotIndicator != null)
			{
				rightRedDotIndicator.SetUIActive(false);
			}
			this.ScrollView.BindScrollValueChange(new Action<FVector2D>(this.OnScrollValueChange));
			this.SequencePlayer = new LevelSequencePlayer(base.GetRootItem());
			UUIItem svTimeLineRootItem = this.GetSvTimeLineRootItem();
			if (svTimeLineRootItem != null)
			{
				this.SvTimeLineMaxWidth = svTimeLineRootItem.GetWidth();
			}
			UUIItem rootItem = base.GetRootItem();
			if (rootItem != null)
			{
				this.RootMaxWidth = rootItem.GetWidth();
			}
		}

		// Token: 0x0602928B RID: 168587 RVA: 0x00B8EF58 File Offset: 0x00B8D158
		protected override void OnBeforeDestroy()
		{
			LevelSequencePlayer sequencePlayer = this.SequencePlayer;
			if (sequencePlayer != null)
			{
				sequencePlayer.Clear();
			}
			this.SequencePlayer = null;
		}

		// Token: 0x0602928C RID: 168588 RVA: 0x00B8EF74 File Offset: 0x00B8D174
		public UniTask RefreshTimeLine(List<QuestMultiLineTimePointData> timePointDataArray)
		{
			QuestMultiLineTimeLinePanel.<RefreshTimeLine>d__13 <RefreshTimeLine>d__;
			<RefreshTimeLine>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshTimeLine>d__.<>4__this = this;
			<RefreshTimeLine>d__.timePointDataArray = timePointDataArray;
			<RefreshTimeLine>d__.<>1__state = -1;
			<RefreshTimeLine>d__.<>t__builder.Start<QuestMultiLineTimeLinePanel.<RefreshTimeLine>d__13>(ref <RefreshTimeLine>d__);
			return <RefreshTimeLine>d__.<>t__builder.Task;
		}

		// Token: 0x0602928D RID: 168589 RVA: 0x00B8EFC0 File Offset: 0x00B8D1C0
		private void AdjustTimeLineWidth()
		{
			UUIItem svTimeLineRootItem = this.GetSvTimeLineRootItem();
			UUIHorizontalLayout horizontalLayout = base.GetHorizontalLayout(1);
			UUIItem rootItem = base.GetRootItem();
			List<QuestMultiLineTimePointData> showTimePointDataArray = this.ShowTimePointDataArray;
			GenericScrollViewNew<QuestMultiLineTimePointItem, QuestMultiLineTimePointData> scrollView = this.ScrollView;
			UUIItem uuiitem = (scrollView != null) ? scrollView.GetItemByIndex(0) : null;
			if (svTimeLineRootItem == null || horizontalLayout == null || rootItem == null || showTimePointDataArray == null || uuiitem == null || this.SvTimeLineMaxWidth <= 0f)
			{
				return;
			}
			int count = showTimePointDataArray.Count;
			if (count == 0)
			{
				return;
			}
			float width = uuiitem.GetWidth();
			float spacing = horizontalLayout.GetSpacing();
			FMargin padding = horizontalLayout.GetPadding();
			float num = (float)count * width + (float)(count - 1) * spacing + padding.Left + padding.Right;
			if (num <= this.SvTimeLineMaxWidth)
			{
				float num2 = this.SvTimeLineMaxWidth - num;
				svTimeLineRootItem.SetWidth(num);
				rootItem.SetWidth(this.RootMaxWidth - num2);
				return;
			}
			svTimeLineRootItem.SetWidth(this.SvTimeLineMaxWidth);
			rootItem.SetWidth(this.RootMaxWidth);
		}

		// Token: 0x0602928E RID: 168590 RVA: 0x00B8F0A9 File Offset: 0x00B8D2A9
		[NullableContext(2)]
		private UUIItem GetSvTimeLineRootItem()
		{
			UUIScrollViewWithScrollbarComponent scrollViewWithScrollbar = base.GetScrollViewWithScrollbar(0);
			object obj;
			if (scrollViewWithScrollbar == null)
			{
				obj = null;
			}
			else
			{
				AActor owner = scrollViewWithScrollbar.GetOwner();
				obj = ((owner != null) ? owner.K2_GetRootComponent() : null);
			}
			return obj as UUIItem;
		}

		// Token: 0x0602928F RID: 168591 RVA: 0x00B8F0D0 File Offset: 0x00B8D2D0
		public void RefreshLeftRightBtnState()
		{
			List<QuestMultiLineTimePointData> list = this.ShowTimePointDataArray ?? new List<QuestMultiLineTimePointData>();
			bool flag = this.CurTimePointIndex <= 0;
			int num = this.CurTimePointIndex + 1;
			QuestMultiLineTimePointData questMultiLineTimePointData = (num >= 0 && num < list.Count) ? list[num] : null;
			bool selfInteractive = questMultiLineTimePointData != null && questMultiLineTimePointData.IsUnLock;
			base.GetButton(3).SetSelfInteractive(!flag);
			base.GetButton(4).SetSelfInteractive(selfInteractive);
		}

		// Token: 0x06029290 RID: 168592 RVA: 0x00B8F147 File Offset: 0x00B8D347
		public void SetTimePointFunction(Action<QuestMultiLineTimePointData> timePointFunction)
		{
			this.TimePointFunction = timePointFunction;
		}

		// Token: 0x06029291 RID: 168593 RVA: 0x00B8F150 File Offset: 0x00B8D350
		public bool SelectTimePoint(QuestMultiLineTimePointData timePoint)
		{
			if (!timePoint.IsUnLock)
			{
				return false;
			}
			if (this.ShowTimePointDataArray == null || this.ShowTimePointDataArray.Count == 0 || this.ScrollView == null)
			{
				return false;
			}
			int num = this.ShowTimePointDataArray.IndexOf(timePoint);
			if (num < 0)
			{
				return false;
			}
			this.CurTimePointIndex = num;
			this.ScrollView.SelectGridProxy(this.CurTimePointIndex, false);
			this.RefreshLeftRightBtnState();
			this.RefreshSideRedDotIndicator();
			return true;
		}

		// Token: 0x06029292 RID: 168594 RVA: 0x00B8F1C0 File Offset: 0x00B8D3C0
		public void ScrollTimePointToViewportCenter(QuestMultiLineTimePointData timePoint)
		{
			if (this.ShowTimePointDataArray == null || this.ShowTimePointDataArray.Count == 0 || this.ScrollView == null)
			{
				return;
			}
			int num = this.ShowTimePointDataArray.IndexOf(timePoint);
			if (num < 0)
			{
				return;
			}
			QuestMultiLineTimePointItem scrollItemByIndex = this.ScrollView.GetScrollItemByIndex(num);
			UUIItem uuiitem = (scrollItemByIndex != null) ? scrollItemByIndex.GetRootItem() : null;
			if (uuiitem == null)
			{
				return;
			}
			this.ScrollView.LateScrollTo(uuiitem, null, false);
		}

		// Token: 0x06029293 RID: 168595 RVA: 0x00B8F228 File Offset: 0x00B8D428
		[NullableContext(2)]
		public UUIItem GetGuideTimePointUiItem(int showIndex)
		{
			List<QuestMultiLineTimePointData> showTimePointDataArray = this.ShowTimePointDataArray;
			if (showTimePointDataArray == null || showTimePointDataArray.Count == 0 || this.ScrollView == null)
			{
				return null;
			}
			if (showIndex < 0 || showIndex >= showTimePointDataArray.Count)
			{
				return null;
			}
			QuestMultiLineTimePointItem scrollItemByIndex = this.ScrollView.GetScrollItemByIndex(showIndex);
			UUIItem uuiitem = (scrollItemByIndex != null) ? scrollItemByIndex.GetRootItem() : null;
			if (uuiitem == null)
			{
				return null;
			}
			this.ScrollView.LateScrollTo(uuiitem, null, false);
			return uuiitem;
		}

		// Token: 0x06029294 RID: 168596 RVA: 0x00B8F290 File Offset: 0x00B8D490
		private void OnClickLeft()
		{
			int num = this.CurTimePointIndex - 1;
			QuestMultiLineTimePointData questMultiLineTimePointData = this.ShowTimePointDataArray[num];
			if (questMultiLineTimePointData == null || !questMultiLineTimePointData.IsUnLock)
			{
				return;
			}
			this.CurTimePointIndex = num;
			this.ScrollView.ScrollTo(this.ScrollView.GetScrollItemByIndex(this.CurTimePointIndex).GetRootItem(), false);
			this.ScrollView.SelectGridProxy(this.CurTimePointIndex, false);
			Action<QuestMultiLineTimePointData> timePointFunction = this.TimePointFunction;
			if (timePointFunction != null)
			{
				timePointFunction(this.ShowTimePointDataArray[this.CurTimePointIndex]);
			}
			this.RefreshLeftRightBtnState();
		}

		// Token: 0x06029295 RID: 168597 RVA: 0x00B8F328 File Offset: 0x00B8D528
		private void OnClickRight()
		{
			int num = this.CurTimePointIndex + 1;
			QuestMultiLineTimePointData questMultiLineTimePointData = this.ShowTimePointDataArray[num];
			if (questMultiLineTimePointData == null || !questMultiLineTimePointData.IsUnLock)
			{
				return;
			}
			this.CurTimePointIndex = num;
			this.ScrollView.ScrollTo(this.ScrollView.GetScrollItemByIndex(this.CurTimePointIndex).GetRootItem(), false);
			this.ScrollView.SelectGridProxy(this.CurTimePointIndex, false);
			Action<QuestMultiLineTimePointData> timePointFunction = this.TimePointFunction;
			if (timePointFunction != null)
			{
				timePointFunction(this.ShowTimePointDataArray[this.CurTimePointIndex]);
			}
			this.RefreshLeftRightBtnState();
		}

		// Token: 0x06029296 RID: 168598 RVA: 0x00B8F3BF File Offset: 0x00B8D5BF
		public void OnClickTimePoint(QuestMultiLineTimePointData timePoint)
		{
			if (!this.SelectTimePoint(timePoint))
			{
				return;
			}
			Action<QuestMultiLineTimePointData> timePointFunction = this.TimePointFunction;
			if (timePointFunction == null)
			{
				return;
			}
			timePointFunction(timePoint);
		}

		// Token: 0x06029297 RID: 168599 RVA: 0x00B8F3DC File Offset: 0x00B8D5DC
		private void OnScrollValueChange(FVector2D _)
		{
			this.RefreshSideRedDotIndicator();
		}

		// Token: 0x06029298 RID: 168600 RVA: 0x00B8F3E4 File Offset: 0x00B8D5E4
		private void RefreshSideRedDotIndicator()
		{
			if (this.ScrollView == null)
			{
				return;
			}
			List<QuestMultiLineTimePointData> list = this.ShowTimePointDataArray ?? new List<QuestMultiLineTimePointData>();
			UUIItem uuiitem = null;
			UUIItem uuiitem2 = null;
			QuestMultiLineModel instance = QuestMultiLineModel.Instance;
			for (int i = 0; i < list.Count; i++)
			{
				QuestMultiLineTimePointData questMultiLineTimePointData = list[i];
				if (questMultiLineTimePointData.IsUnLock && instance != null && instance.GetTimePointRedDot(questMultiLineTimePointData.Id))
				{
					UUIItem itemByIndex = this.ScrollView.GetItemByIndex(i);
					if (itemByIndex != null)
					{
						if (uuiitem == null)
						{
							uuiitem = itemByIndex;
						}
						uuiitem2 = itemByIndex;
					}
				}
			}
			bool uiactive = false;
			bool uiactive2 = false;
			if (uuiitem != null)
			{
				uiactive = (this.ScrollView.IsItemFullyOutOfViewport(uuiitem, 0.1f) == EOutOfBoundsType.OutOfBegin);
			}
			if (uuiitem2 != null)
			{
				uiactive2 = (this.ScrollView.IsItemInViewport(uuiitem2, 0.1f) == EOutOfBoundsType.OutOfEnd);
			}
			UUIItem leftRedDotIndicator = this.LeftRedDotIndicator;
			if (leftRedDotIndicator != null)
			{
				leftRedDotIndicator.SetUIActive(uiactive2);
			}
			UUIItem rightRedDotIndicator = this.RightRedDotIndicator;
			if (rightRedDotIndicator == null)
			{
				return;
			}
			rightRedDotIndicator.SetUIActive(uiactive);
		}

		// Token: 0x06029299 RID: 168601 RVA: 0x00B8F4C8 File Offset: 0x00B8D6C8
		public UniTask PlayShowAnimAsync()
		{
			QuestMultiLineTimeLinePanel.<PlayShowAnimAsync>d__26 <PlayShowAnimAsync>d__;
			<PlayShowAnimAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayShowAnimAsync>d__.<>4__this = this;
			<PlayShowAnimAsync>d__.<>1__state = -1;
			<PlayShowAnimAsync>d__.<>t__builder.Start<QuestMultiLineTimeLinePanel.<PlayShowAnimAsync>d__26>(ref <PlayShowAnimAsync>d__);
			return <PlayShowAnimAsync>d__.<>t__builder.Task;
		}

		// Token: 0x04016686 RID: 91782
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<QuestMultiLineTimePointData> TimePointDataArray;

		// Token: 0x04016687 RID: 91783
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<QuestMultiLineTimePointData> ShowTimePointDataArray;

		// Token: 0x04016688 RID: 91784
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private Action<QuestMultiLineTimePointData> TimePointFunction;

		// Token: 0x04016689 RID: 91785
		private int CurTimePointIndex;

		// Token: 0x0401668A RID: 91786
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericScrollViewNew<QuestMultiLineTimePointItem, QuestMultiLineTimePointData> ScrollView;

		// Token: 0x0401668B RID: 91787
		[Nullable(2)]
		private UUIItem LeftRedDotIndicator;

		// Token: 0x0401668C RID: 91788
		[Nullable(2)]
		private UUIItem RightRedDotIndicator;

		// Token: 0x0401668D RID: 91789
		[Nullable(2)]
		private LevelSequencePlayer SequencePlayer;

		// Token: 0x0401668E RID: 91790
		private float SvTimeLineMaxWidth;

		// Token: 0x0401668F RID: 91791
		private float RootMaxWidth;
	}
}
