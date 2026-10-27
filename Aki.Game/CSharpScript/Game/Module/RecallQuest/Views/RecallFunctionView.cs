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
	// Token: 0x02004F1B RID: 20251
	[NullableContext(1)]
	[Nullable(0)]
	public class RecallFunctionView : UiViewBase
	{
		// Token: 0x06033EC4 RID: 212676 RVA: 0x00C2B4E8 File Offset: 0x00C296E8
		public RecallFunctionView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06033EC5 RID: 212677 RVA: 0x00C2B508 File Offset: 0x00C29708
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

		// Token: 0x06033EC6 RID: 212678 RVA: 0x00C2B7EE File Offset: 0x00C299EE
		private void InitCaption()
		{
			this.CaptionItem = new PopupCaptionItem(base.GetItem(0));
			this.CaptionItem.SetCloseCallBack(new Action(this.OnCaptionClose));
		}

		// Token: 0x06033EC7 RID: 212679 RVA: 0x00C2B819 File Offset: 0x00C29A19
		private void OnCaptionClose()
		{
			base.CloseMe(null);
		}

		// Token: 0x06033EC8 RID: 212680 RVA: 0x00C2B824 File Offset: 0x00C29A24
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

		// Token: 0x06033EC9 RID: 212681 RVA: 0x00C2B93A File Offset: 0x00C29B3A
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add<int>(EEventName.FunctionGridSelected, new Action<int>(this.OnFunctionGridSelected));
		}

		// Token: 0x06033ECA RID: 212682 RVA: 0x00C2B958 File Offset: 0x00C29B58
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.FunctionGridSelected, new Action<int>(this.OnFunctionGridSelected));
		}

		// Token: 0x06033ECB RID: 212683 RVA: 0x00C2B976 File Offset: 0x00C29B76
		private void OnFunctionGridSelected(int index)
		{
			this.TabLayout.SetToggleSelectByIndex(index);
			this.RefreshTurnPageBtn(index);
			this.ReSizeDragContentSize(index);
		}

		// Token: 0x06033ECC RID: 212684 RVA: 0x00C2B994 File Offset: 0x00C29B94
		private void RefreshTurnPageBtn(int index)
		{
			int dataLength = this.NoCircleExhibitionView.GetDataLength();
			this.LeftButtonItem.SetUIActive(index > 0);
			this.RightButtonItem.SetUIActive(index < dataLength - 1);
		}

		// Token: 0x06033ECD RID: 212685 RVA: 0x00C2B9CD File Offset: 0x00C29BCD
		private void HideTurnPageBtn()
		{
			this.LeftButtonItem.SetUIActive(false);
			this.RightButtonItem.SetUIActive(false);
		}

		// Token: 0x06033ECE RID: 212686 RVA: 0x00C2B9E8 File Offset: 0x00C29BE8
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

		// Token: 0x06033ECF RID: 212687 RVA: 0x00C2BA30 File Offset: 0x00C29C30
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

		// Token: 0x06033ED0 RID: 212688 RVA: 0x00C2BA80 File Offset: 0x00C29C80
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

		// Token: 0x06033ED1 RID: 212689 RVA: 0x00C2BAB5 File Offset: 0x00C29CB5
		private int GetShowFunctionIdListLength()
		{
			return RecallQuestModel.Instance.GetCurrentRecallFunctionIds().Count;
		}

		// Token: 0x06033ED2 RID: 212690 RVA: 0x00C2BAC8 File Offset: 0x00C29CC8
		private void SetPanelTabItemStretchRight(float offsetValue)
		{
			UUIItem item = base.GetItem(6);
			float stretchRight = item.GetStretchRight();
			item.SetStretchRight(stretchRight + offsetValue);
		}

		// Token: 0x06033ED3 RID: 212691 RVA: 0x00C2BAEC File Offset: 0x00C29CEC
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

		// Token: 0x06033ED4 RID: 212692 RVA: 0x00C2BBE8 File Offset: 0x00C29DE8
		private RecallFunctionAttachGrid InitFunctionGrid(AActor actor, int index, int showNum)
		{
			RecallFunctionAttachGrid recallFunctionAttachGrid = new RecallFunctionAttachGrid(actor);
			recallFunctionAttachGrid.SetNeedAnim(index == 0);
			this.FunctionGridMap[index] = recallFunctionAttachGrid;
			return recallFunctionAttachGrid;
		}

		// Token: 0x06033ED5 RID: 212693 RVA: 0x00C2BC14 File Offset: 0x00C29E14
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

		// Token: 0x06033ED6 RID: 212694 RVA: 0x00C2BD30 File Offset: 0x00C29F30
		protected override void OnBeforeShow()
		{
			RecallConfig? currentRecallQuestConfig = RecallQuestModel.Instance.GetCurrentRecallQuestConfig();
			this.RefreshChapterInfo(currentRecallQuestConfig);
			this.RefreshAreaInfo(currentRecallQuestConfig);
			this.RefreshQuestInfo(currentRecallQuestConfig);
		}

		// Token: 0x06033ED7 RID: 212695 RVA: 0x00C2BD60 File Offset: 0x00C29F60
		protected override void OnBeforeDestroy()
		{
			foreach (RecallFunctionAttachGrid child in this.NoCircleExhibitionView.GetItems())
			{
				base.AddChild(child);
			}
			this.TabLayout.Destroy(null);
		}

		// Token: 0x06033ED8 RID: 212696 RVA: 0x00C2BDC4 File Offset: 0x00C29FC4
		private void RefreshChapterInfo(RecallConfig? config)
		{
			if (config == null)
			{
				return;
			}
			LguiUtil.Instance.SetLocalTextNew(base.GetText(4), config.Value.ChapterName, Array.Empty<object>());
			LguiUtil.Instance.SetLocalTextNew(base.GetText(5), config.Value.SmallChapterName, Array.Empty<object>());
		}

		// Token: 0x06033ED9 RID: 212697 RVA: 0x00C2BE28 File Offset: 0x00C2A028
		private void RefreshAreaInfo(RecallConfig? config)
		{
			if (config == null)
			{
				return;
			}
			string areaTexture = config.Value.AreaTexture;
			base.SetTextureByPath(areaTexture, base.GetTexture(1), null, null);
		}

		// Token: 0x06033EDA RID: 212698 RVA: 0x00C2BE68 File Offset: 0x00C2A068
		private void RefreshQuestInfo(RecallConfig? config)
		{
			if (config == null)
			{
				return;
			}
			LguiUtil.Instance.SetLocalTextNew(base.GetText(2), config.Value.QuestName, Array.Empty<object>());
		}

		// Token: 0x06033EDB RID: 212699 RVA: 0x00C2BEA4 File Offset: 0x00C2A0A4
		private void OnClickLeaveButton()
		{
			InstanceDungeonController.Instance.OnClickInstanceDungeonExitButton(null, null, true);
		}

		// Token: 0x06033EDC RID: 212700 RVA: 0x00C2BEB4 File Offset: 0x00C2A0B4
		private void RefreshBgTexture()
		{
			string bgTexturePath = RecallQuestModel.Instance.GetBgTexturePath();
			base.SetTextureByPath(bgTexturePath, base.GetTexture(16), null, null);
		}

		// Token: 0x0401B977 RID: 113015
		private const int DRAG_PANEL_HEIGHT_ITEM_THRESHOLD = 8;

		// Token: 0x0401B978 RID: 113016
		private const float DRAG_PANEL_HEIGHT_SMALL = 595f;

		// Token: 0x0401B979 RID: 113017
		private const float DRAG_PANEL_HEIGHT_LARGE = 740f;

		// Token: 0x0401B97A RID: 113018
		[Nullable(2)]
		private PopupCaptionItem CaptionItem;

		// Token: 0x0401B97B RID: 113019
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private NoCircleAttachView<List<int>, RecallFunctionAttachGrid> NoCircleExhibitionView;

		// Token: 0x0401B97C RID: 113020
		[Nullable(2)]
		private FunctionTabLayout TabLayout;

		// Token: 0x0401B97D RID: 113021
		[Nullable(2)]
		private UUIItem LeftButtonItem;

		// Token: 0x0401B97E RID: 113022
		[Nullable(2)]
		private UUIItem RightButtonItem;

		// Token: 0x0401B97F RID: 113023
		private readonly Dictionary<int, RecallFunctionAttachGrid> FunctionGridMap = new Dictionary<int, RecallFunctionAttachGrid>();

		// Token: 0x0401B980 RID: 113024
		private List<List<int>> DataList = new List<List<int>>();

		// Token: 0x0401B981 RID: 113025
		private RecallFunctionView.ICalculateData CalculateData;

		// Token: 0x0200B062 RID: 45154
		[NullableContext(0)]
		private class ICalculateData
		{
			// Token: 0x04035872 RID: 219250
			public int TotalGridNumber;

			// Token: 0x04035873 RID: 219251
			public float OffsetWidth;

			// Token: 0x04035874 RID: 219252
			public int HorizontalGridNum;

			// Token: 0x04035875 RID: 219253
			public int VerticalGridNum;
		}

		// Token: 0x0200B063 RID: 45155
		[NullableContext(0)]
		private class ERecallFunctionComponent
		{
			// Token: 0x04035876 RID: 219254
			public const int CaptionItem = 0;

			// Token: 0x04035877 RID: 219255
			public const int AreaTexture = 1;

			// Token: 0x04035878 RID: 219256
			public const int QuestText = 2;

			// Token: 0x04035879 RID: 219257
			public const int QuestStateText = 3;

			// Token: 0x0403587A RID: 219258
			public const int ChapterText = 4;

			// Token: 0x0403587B RID: 219259
			public const int SmallChapterText = 5;

			// Token: 0x0403587C RID: 219260
			public const int DragPanel = 6;

			// Token: 0x0403587D RID: 219261
			public const int DragContentItem = 7;

			// Token: 0x0403587E RID: 219262
			public const int LeftButton = 8;

			// Token: 0x0403587F RID: 219263
			public const int RightButton = 9;

			// Token: 0x04035880 RID: 219264
			public const int PageDotLayout = 10;

			// Token: 0x04035881 RID: 219265
			public const int PageDotItem = 11;

			// Token: 0x04035882 RID: 219266
			public const int QuitButton = 12;

			// Token: 0x04035883 RID: 219267
			public const int TaskButton = 13;

			// Token: 0x04035884 RID: 219268
			public const int GridItem = 14;

			// Token: 0x04035885 RID: 219269
			public const int GridInsideLayout = 15;

			// Token: 0x04035886 RID: 219270
			public const int BgTexture = 16;
		}
	}
}
