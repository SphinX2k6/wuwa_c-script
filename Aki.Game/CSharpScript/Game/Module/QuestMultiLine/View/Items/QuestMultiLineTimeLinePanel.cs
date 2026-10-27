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
	// Token: 0x02004FC4 RID: 20420
	[NullableContext(1)]
	[Nullable(0)]
	public class QuestMultiLineTimeLinePanel : UiPanelBase
	{
		// Token: 0x0603441B RID: 214043 RVA: 0x00C455DC File Offset: 0x00C437DC
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

		// Token: 0x0603441C RID: 214044 RVA: 0x00C456E0 File Offset: 0x00C438E0
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

		// Token: 0x0603441D RID: 214045 RVA: 0x00C457A0 File Offset: 0x00C439A0
		protected override void OnBeforeDestroy()
		{
			LevelSequencePlayer sequencePlayer = this.SequencePlayer;
			if (sequencePlayer != null)
			{
				sequencePlayer.Clear();
			}
			this.SequencePlayer = null;
		}

		// Token: 0x0603441E RID: 214046 RVA: 0x00C457BC File Offset: 0x00C439BC
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

		// Token: 0x0603441F RID: 214047 RVA: 0x00C45808 File Offset: 0x00C43A08
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

		// Token: 0x06034420 RID: 214048 RVA: 0x00C458F1 File Offset: 0x00C43AF1
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

		// Token: 0x06034421 RID: 214049 RVA: 0x00C45918 File Offset: 0x00C43B18
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

		// Token: 0x06034422 RID: 214050 RVA: 0x00C4598F File Offset: 0x00C43B8F
		public void SetTimePointFunction(Action<QuestMultiLineTimePointData> timePointFunction)
		{
			this.TimePointFunction = timePointFunction;
		}

		// Token: 0x06034423 RID: 214051 RVA: 0x00C45998 File Offset: 0x00C43B98
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

		// Token: 0x06034424 RID: 214052 RVA: 0x00C45A08 File Offset: 0x00C43C08
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

		// Token: 0x06034425 RID: 214053 RVA: 0x00C45A70 File Offset: 0x00C43C70
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

		// Token: 0x06034426 RID: 214054 RVA: 0x00C45AD8 File Offset: 0x00C43CD8
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

		// Token: 0x06034427 RID: 214055 RVA: 0x00C45B70 File Offset: 0x00C43D70
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

		// Token: 0x06034428 RID: 214056 RVA: 0x00C45C07 File Offset: 0x00C43E07
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

		// Token: 0x06034429 RID: 214057 RVA: 0x00C45C24 File Offset: 0x00C43E24
		private void OnScrollValueChange(FVector2D _)
		{
			this.RefreshSideRedDotIndicator();
		}

		// Token: 0x0603442A RID: 214058 RVA: 0x00C45C2C File Offset: 0x00C43E2C
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

		// Token: 0x0603442B RID: 214059 RVA: 0x00C45D10 File Offset: 0x00C43F10
		public UniTask PlayShowAnimAsync()
		{
			QuestMultiLineTimeLinePanel.<PlayShowAnimAsync>d__26 <PlayShowAnimAsync>d__;
			<PlayShowAnimAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayShowAnimAsync>d__.<>4__this = this;
			<PlayShowAnimAsync>d__.<>1__state = -1;
			<PlayShowAnimAsync>d__.<>t__builder.Start<QuestMultiLineTimeLinePanel.<PlayShowAnimAsync>d__26>(ref <PlayShowAnimAsync>d__);
			return <PlayShowAnimAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0401BCB1 RID: 113841
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<QuestMultiLineTimePointData> TimePointDataArray;

		// Token: 0x0401BCB2 RID: 113842
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<QuestMultiLineTimePointData> ShowTimePointDataArray;

		// Token: 0x0401BCB3 RID: 113843
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private Action<QuestMultiLineTimePointData> TimePointFunction;

		// Token: 0x0401BCB4 RID: 113844
		private int CurTimePointIndex;

		// Token: 0x0401BCB5 RID: 113845
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericScrollViewNew<QuestMultiLineTimePointItem, QuestMultiLineTimePointData> ScrollView;

		// Token: 0x0401BCB6 RID: 113846
		[Nullable(2)]
		private UUIItem LeftRedDotIndicator;

		// Token: 0x0401BCB7 RID: 113847
		[Nullable(2)]
		private UUIItem RightRedDotIndicator;

		// Token: 0x0401BCB8 RID: 113848
		[Nullable(2)]
		private LevelSequencePlayer SequencePlayer;

		// Token: 0x0401BCB9 RID: 113849
		private float SvTimeLineMaxWidth;

		// Token: 0x0401BCBA RID: 113850
		private float RootMaxWidth;
	}
}
