using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.AutoAttach;
using CSharpScript.Game.Module.Functional;
using CSharpScript.Game.Module.InstanceDungeon;
using CSharpScript.Game.Module.RecallQuest.Model;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.RecallQuest.Views
{
	// Token: 0x02003EE4 RID: 16100
	[NullableContext(1)]
	[Nullable(0)]
	public class RecallFunctionView : UiViewBase
	{
		// Token: 0x06028D2F RID: 167215 RVA: 0x00B74B5C File Offset: 0x00B72D5C
		public RecallFunctionView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06028D30 RID: 167216 RVA: 0x00B74B7C File Offset: 0x00B72D7C
		protected unsafe override void OnRegisterComponent()
		{
			int num = 17;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(13, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(14, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(15, typeof(UUIGridLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(16, typeof(UUITexture));
			this.ComponentRegisterInfos = list;
			num2 = 3;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(8, new Action(this.MoveToLeft));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(9, new Action(this.MoveToRight));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(12, new Action(this.OnClickLeaveButton));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06028D31 RID: 167217 RVA: 0x00B74E62 File Offset: 0x00B73062
		private void InitCaption()
		{
			this.CaptionItem = new PopupCaptionItem(base.GetItem(0));
			this.CaptionItem.SetCloseCallBack(new Action(this.OnCaptionClose));
		}

		// Token: 0x06028D32 RID: 167218 RVA: 0x00B74E8D File Offset: 0x00B7308D
		private void OnCaptionClose()
		{
			base.CloseMe(null);
		}

		// Token: 0x06028D33 RID: 167219 RVA: 0x00B74E98 File Offset: 0x00B73098
		protected override void OnStart()
		{
			this.InitCaption();
			this.LeftButtonItem = base.GetButton(8).RootUIComp.Get();
			this.RightButtonItem = base.GetButton(9).RootUIComp.Get();
			this.TabLayout = new FunctionTabLayout(base.GetItem(10));
			this.NoCircleExhibitionView = new NoCircleAttachView<List<int>, RecallFunctionAttachGrid>(base.GetItem(6).GetOwner(), false);
			UUIItem item = base.GetItem(7);
			item.SetUIActive(false);
			this.CalculateData = this.CalculateGridNum();
			this.ReSizeDragContentSize(0);
			this.NoCircleExhibitionView.CreateItems(item.GetOwner(), 0f, new Func<AActor, int, int, RecallFunctionAttachGrid>(this.InitFunctionGrid), EAttachDirection.Horizontal);
			this.NoCircleExhibitionView.SetDragBeginCallback(new Action(this.HideTurnPageBtn));
			this.NoCircleExhibitionView.SetMoveMultiFactor(50f);
			this.NoCircleExhibitionView.SetPageLimitState(true);
			this.RefreshFunctionGrid();
			int currentSelectIndex = this.NoCircleExhibitionView.GetCurrentSelectIndex();
			this.TabLayout.SetToggleSelectByIndex(currentSelectIndex);
			this.RefreshTurnPageBtn(currentSelectIndex);
			this.RefreshBgTexture();
		}

		// Token: 0x06028D34 RID: 167220 RVA: 0x00B74FAE File Offset: 0x00B731AE
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add<int>(EEventName.FunctionGridSelected, new Action<int>(this.OnFunctionGridSelected));
		}

		// Token: 0x06028D35 RID: 167221 RVA: 0x00B74FCC File Offset: 0x00B731CC
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.FunctionGridSelected, new Action<int>(this.OnFunctionGridSelected));
		}

		// Token: 0x06028D36 RID: 167222 RVA: 0x00B74FEA File Offset: 0x00B731EA
		private void OnFunctionGridSelected(int index)
		{
			this.TabLayout.SetToggleSelectByIndex(index);
			this.RefreshTurnPageBtn(index);
			this.ReSizeDragContentSize(index);
		}

		// Token: 0x06028D37 RID: 167223 RVA: 0x00B75008 File Offset: 0x00B73208
		private void RefreshTurnPageBtn(int index)
		{
			int dataLength = this.NoCircleExhibitionView.GetDataLength();
			this.LeftButtonItem.SetUIActive(index > 0);
			this.RightButtonItem.SetUIActive(index < dataLength - 1);
		}

		// Token: 0x06028D38 RID: 167224 RVA: 0x00B75041 File Offset: 0x00B73241
		private void HideTurnPageBtn()
		{
			this.LeftButtonItem.SetUIActive(false);
			this.RightButtonItem.SetUIActive(false);
		}

		// Token: 0x06028D39 RID: 167225 RVA: 0x00B7505C File Offset: 0x00B7325C
		private void MoveToLeft()
		{
			if (this.NoCircleExhibitionView.MovingState())
			{
				return;
			}
			if (this.NoCircleExhibitionView.GetCurrentSelectIndex() <= 0)
			{
				return;
			}
			int showItemIndex = this.NoCircleExhibitionView.GetCurrentSelectIndex() - 1;
			this.NoCircleExhibitionView.AttachToIndex(showItemIndex, false);
		}

		// Token: 0x06028D3A RID: 167226 RVA: 0x00B750A4 File Offset: 0x00B732A4
		private void MoveToRight()
		{
			if (this.NoCircleExhibitionView.MovingState())
			{
				return;
			}
			if (this.NoCircleExhibitionView.GetCurrentSelectIndex() >= this.NoCircleExhibitionView.GetDataLength())
			{
				return;
			}
			int showItemIndex = this.NoCircleExhibitionView.GetCurrentSelectIndex() + 1;
			this.NoCircleExhibitionView.AttachToIndex(showItemIndex, false);
		}

		// Token: 0x06028D3B RID: 167227 RVA: 0x00B750F4 File Offset: 0x00B732F4
		private void ReSizeDragContentSize(int index)
		{
			float height = (this.GetShowFunctionIdListLength() > 8) ? 740f : 595f;
			UUIItem item = base.GetItem(7);
			if (item == null)
			{
				return;
			}
			item.SetHeight(height);
		}

		// Token: 0x06028D3C RID: 167228 RVA: 0x00B75129 File Offset: 0x00B73329
		private int GetShowFunctionIdListLength()
		{
			return RecallQuestModel.Instance.GetCurrentRecallFunctionIds().Count;
		}

		// Token: 0x06028D3D RID: 167229 RVA: 0x00B7513C File Offset: 0x00B7333C
		private void SetPanelTabItemStretchRight(float offsetValue)
		{
			UUIItem item = base.GetItem(6);
			float stretchRight = item.GetStretchRight();
			item.SetStretchRight(stretchRight + offsetValue);
		}

		// Token: 0x06028D3E RID: 167230 RVA: 0x00B75160 File Offset: 0x00B73360
		private void RefreshFunctionGrid()
		{
			this.CalculateData = this.CalculateGridNum();
			this.SetPanelTabItemStretchRight(this.CalculateData.OffsetWidth);
			List<int> currentRecallFunctionIds = RecallQuestModel.Instance.GetCurrentRecallFunctionIds();
			int count = currentRecallFunctionIds.Count;
			int num = Math.Max(1, this.CalculateData.TotalGridNumber);
			this.DataList = new List<List<int>>();
			if (count == 0)
			{
				this.DataList.Add(new List<int>());
			}
			else
			{
				int num2 = 0;
				while (num2 + num < count)
				{
					this.DataList.Add(currentRecallFunctionIds.GetRange(num2, num));
					num2 += num;
				}
				this.DataList.Add(currentRecallFunctionIds.GetRange(num2, count - num2));
			}
			int count2 = this.DataList.Count;
			this.TabLayout.RefreshTab(count2);
			this.NoCircleExhibitionView.SetBoundDistance(0f);
			this.NoCircleExhibitionView.ReloadView(count2, this.DataList.ToArray(), 0);
			this.ReSizeDragContentSize(this.NoCircleExhibitionView.GetCurrentSelectIndex());
		}

		// Token: 0x06028D3F RID: 167231 RVA: 0x00B7525C File Offset: 0x00B7345C
		private RecallFunctionAttachGrid InitFunctionGrid(AActor actor, int index, int showNum)
		{
			RecallFunctionAttachGrid recallFunctionAttachGrid = new RecallFunctionAttachGrid(actor);
			recallFunctionAttachGrid.SetNeedAnim(index == 0);
			this.FunctionGridMap[index] = recallFunctionAttachGrid;
			return recallFunctionAttachGrid;
		}

		// Token: 0x06028D40 RID: 167232 RVA: 0x00B75288 File Offset: 0x00B73488
		private RecallFunctionView.ICalculateData CalculateGridNum()
		{
			UUIItem item = base.GetItem(7);
			UUIGridLayout gridLayout = base.GetGridLayout(15);
			FVector2D cellSize = gridLayout.GetCellSize();
			FVector2D spacing = gridLayout.GetSpacing();
			FMargin padding = gridLayout.GetPadding();
			float width = item.GetWidth();
			double height = (double)item.GetHeight();
			float num = width - padding.Left - padding.Right;
			int num2 = (int)Math.Floor((double)((num + spacing.X) / (cellSize.X + spacing.X)));
			float num3 = (num2 > 0) ? ((float)num2 * cellSize.X + (float)(num2 - 1) * spacing.X) : 0f;
			float num4 = num - num3;
			int val = (int)Math.Floor((height - (double)padding.Top - (double)padding.Bottom + (double)spacing.Y) / (double)(cellSize.Y + spacing.Y));
			float offsetWidth = (num4 >= cellSize.X) ? (num4 - cellSize.X) : (num4 + spacing.X);
			int num5 = Math.Max(1, num2);
			int num6 = Math.Max(1, val);
			return new RecallFunctionView.ICalculateData
			{
				TotalGridNumber = num5 * num6,
				OffsetWidth = offsetWidth,
				HorizontalGridNum = num5,
				VerticalGridNum = num6
			};
		}

		// Token: 0x06028D41 RID: 167233 RVA: 0x00B753A4 File Offset: 0x00B735A4
		protected override void OnBeforeShow()
		{
			RecallConfig? currentRecallQuestConfig = RecallQuestModel.Instance.GetCurrentRecallQuestConfig();
			this.RefreshChapterInfo(currentRecallQuestConfig);
			this.RefreshAreaInfo(currentRecallQuestConfig);
			this.RefreshQuestInfo(currentRecallQuestConfig);
		}

		// Token: 0x06028D42 RID: 167234 RVA: 0x00B753D4 File Offset: 0x00B735D4
		protected override void OnBeforeDestroy()
		{
			foreach (RecallFunctionAttachGrid child in this.NoCircleExhibitionView.GetItems())
			{
				base.AddChild(child);
			}
			this.TabLayout.Destroy(null);
		}

		// Token: 0x06028D43 RID: 167235 RVA: 0x00B75438 File Offset: 0x00B73638
		private void RefreshChapterInfo(RecallConfig? config)
		{
			if (config == null)
			{
				return;
			}
			LguiUtil.Instance.SetLocalTextNew(base.GetText(4), config.Value.ChapterName, Array.Empty<object>());
			LguiUtil.Instance.SetLocalTextNew(base.GetText(5), config.Value.SmallChapterName, Array.Empty<object>());
		}

		// Token: 0x06028D44 RID: 167236 RVA: 0x00B7549C File Offset: 0x00B7369C
		private void RefreshAreaInfo(RecallConfig? config)
		{
			if (config == null)
			{
				return;
			}
			string areaTexture = config.Value.AreaTexture;
			base.SetTextureByPath(areaTexture, base.GetTexture(1), null, null);
		}

		// Token: 0x06028D45 RID: 167237 RVA: 0x00B754DC File Offset: 0x00B736DC
		private void RefreshQuestInfo(RecallConfig? config)
		{
			if (config == null)
			{
				return;
			}
			LguiUtil.Instance.SetLocalTextNew(base.GetText(2), config.Value.QuestName, Array.Empty<object>());
		}

		// Token: 0x06028D46 RID: 167238 RVA: 0x00B75518 File Offset: 0x00B73718
		private void OnClickLeaveButton()
		{
			InstanceDungeonController.Instance.OnClickInstanceDungeonExitButton(null, null, true);
		}

		// Token: 0x06028D47 RID: 167239 RVA: 0x00B75528 File Offset: 0x00B73728
		private void RefreshBgTexture()
		{
			string bgTexturePath = RecallQuestModel.Instance.GetBgTexturePath();
			base.SetTextureByPath(bgTexturePath, base.GetTexture(16), null, null);
		}

		// Token: 0x0401634A RID: 90954
		private const int DRAG_PANEL_HEIGHT_ITEM_THRESHOLD = 8;

		// Token: 0x0401634B RID: 90955
		private const float DRAG_PANEL_HEIGHT_SMALL = 595f;

		// Token: 0x0401634C RID: 90956
		private const float DRAG_PANEL_HEIGHT_LARGE = 740f;

		// Token: 0x0401634D RID: 90957
		[Nullable(2)]
		private PopupCaptionItem CaptionItem;

		// Token: 0x0401634E RID: 90958
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private NoCircleAttachView<List<int>, RecallFunctionAttachGrid> NoCircleExhibitionView;

		// Token: 0x0401634F RID: 90959
		[Nullable(2)]
		private FunctionTabLayout TabLayout;

		// Token: 0x04016350 RID: 90960
		[Nullable(2)]
		private UUIItem LeftButtonItem;

		// Token: 0x04016351 RID: 90961
		[Nullable(2)]
		private UUIItem RightButtonItem;

		// Token: 0x04016352 RID: 90962
		private readonly Dictionary<int, RecallFunctionAttachGrid> FunctionGridMap = new Dictionary<int, RecallFunctionAttachGrid>();

		// Token: 0x04016353 RID: 90963
		private List<List<int>> DataList = new List<List<int>>();

		// Token: 0x04016354 RID: 90964
		private RecallFunctionView.ICalculateData CalculateData;

		// Token: 0x02009A92 RID: 39570
		[NullableContext(0)]
		private class ICalculateData
		{
			// Token: 0x0403029D RID: 197277
			public int TotalGridNumber;

			// Token: 0x0403029E RID: 197278
			public float OffsetWidth;

			// Token: 0x0403029F RID: 197279
			public int HorizontalGridNum;

			// Token: 0x040302A0 RID: 197280
			public int VerticalGridNum;
		}

		// Token: 0x02009A93 RID: 39571
		[NullableContext(0)]
		private class ERecallFunctionComponent
		{
			// Token: 0x040302A1 RID: 197281
			public const int CaptionItem = 0;

			// Token: 0x040302A2 RID: 197282
			public const int AreaTexture = 1;

			// Token: 0x040302A3 RID: 197283
			public const int QuestText = 2;

			// Token: 0x040302A4 RID: 197284
			public const int QuestStateText = 3;

			// Token: 0x040302A5 RID: 197285
			public const int ChapterText = 4;

			// Token: 0x040302A6 RID: 197286
			public const int SmallChapterText = 5;

			// Token: 0x040302A7 RID: 197287
			public const int DragPanel = 6;

			// Token: 0x040302A8 RID: 197288
			public const int DragContentItem = 7;

			// Token: 0x040302A9 RID: 197289
			public const int LeftButton = 8;

			// Token: 0x040302AA RID: 197290
			public const int RightButton = 9;

			// Token: 0x040302AB RID: 197291
			public const int PageDotLayout = 10;

			// Token: 0x040302AC RID: 197292
			public const int PageDotItem = 11;

			// Token: 0x040302AD RID: 197293
			public const int QuitButton = 12;

			// Token: 0x040302AE RID: 197294
			public const int TaskButton = 13;

			// Token: 0x040302AF RID: 197295
			public const int GridItem = 14;

			// Token: 0x040302B0 RID: 197296
			public const int GridInsideLayout = 15;

			// Token: 0x040302B1 RID: 197297
			public const int BgTexture = 16;
		}
	}
}
