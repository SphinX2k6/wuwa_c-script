using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.TDConfigMgr.Quest;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Plot.PlotView;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Tetris
{
	// Token: 0x0200600E RID: 24590
	[NullableContext(1)]
	[Nullable(0)]
	public class TetrisPlayView : UiViewBase, IGridPoolManager
	{
		// Token: 0x0603E44F RID: 255055 RVA: 0x00F08EA4 File Offset: 0x00F070A4
		public TetrisPlayView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0603E450 RID: 255056 RVA: 0x00F08EC4 File Offset: 0x00F070C4
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIItem)),
				new ValueTuple<int, Type>(1, typeof(UUIItem)),
				new ValueTuple<int, Type>(2, typeof(UUIVerticalLayout)),
				new ValueTuple<int, Type>(3, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(4, typeof(UUIItem)),
				new ValueTuple<int, Type>(5, typeof(UUIItem)),
				new ValueTuple<int, Type>(6, typeof(UUIItem)),
				new ValueTuple<int, Type>(7, typeof(UUIItem)),
				new ValueTuple<int, Type>(8, typeof(UUIItem)),
				new ValueTuple<int, Type>(9, typeof(UUIItem)),
				new ValueTuple<int, Type>(10, typeof(UUIItem)),
				new ValueTuple<int, Type>(11, typeof(UUIItem)),
				new ValueTuple<int, Type>(12, typeof(UUIVerticalLayout)),
				new ValueTuple<int, Type>(13, typeof(UUIItem)),
				new ValueTuple<int, Type>(14, typeof(UUIText)),
				new ValueTuple<int, Type>(15, typeof(UUIItem)),
				new ValueTuple<int, Type>(16, typeof(UUIItem))
			};
		}

		// Token: 0x0603E451 RID: 255057 RVA: 0x00F0905C File Offset: 0x00F0725C
		protected override UniTask OnBeforeStartAsync()
		{
			TetrisPlayView.<OnBeforeStartAsync>d__18 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<TetrisPlayView.<OnBeforeStartAsync>d__18>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603E452 RID: 255058 RVA: 0x00F0909F File Offset: 0x00F0729F
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.OnActivityClose, new Action<IReadOnlySet<int>>(this.OnActivityClose));
		}

		// Token: 0x0603E453 RID: 255059 RVA: 0x00F090BD File Offset: 0x00F072BD
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.OnActivityClose, new Action<IReadOnlySet<int>>(this.OnActivityClose));
		}

		// Token: 0x0603E454 RID: 255060 RVA: 0x00F090DC File Offset: 0x00F072DC
		protected override void OnStart()
		{
			this.Param = (int)this.OpenParam;
			this.CaptionItem = new PopupCaptionItem(base.GetItem(0));
			this.CaptionItem.SetCloseCallBack(new Action(this.OnClickedCloseButton));
			this.CaptionItem.SetHelpCallBack(new Action(this.OnClickHelpBtn));
			this.PoolContainer = base.GetItem(2);
			this.GenerateShapeList = new GenericLayout<TetrisShapeBagGridView, BlockInstance>(base.GetVerticalLayout(2), new Func<TetrisShapeBagGridView>(this.UpdateItem), null, false, true);
			this.GemProgressList = new GenericLayout<TetrisGemProgressGrid, ITetrisGemProgressData>(base.GetVerticalLayout(12), new Func<TetrisGemProgressGrid>(this.UpdateProgressItem), null, false, true);
			this.CellSize = new ValueTuple<float, float>?(new ValueTuple<float, float>(base.GetItem(5).GetWidth(), base.GetItem(5).GetHeight()));
			this.TetrisPlayController = new TetrisPlayController();
			this.TetrisPlayController.OnDataUpdate = new Action<bool, bool>(this.OnLogicUpdate);
			this.TetrisPlayController.OnRefillHandShapes = delegate()
			{
				foreach (TetrisShapeBagGridView tetrisShapeBagGridView in this.ShapeBagViews)
				{
					tetrisShapeBagGridView.PlayRefreshAnimation();
				}
			};
			this.TetrisPlayController.OnPlaceAnimation = new Action<List<ValueTuple<int, int>>, TTimerAction>(this.OnPlaceAnimation);
			this.TetrisPlayController.OnRemoveAnimation = new Action<List<ValueTuple<int, int, int>>, List<ValueTuple<int, int, int>>, List<int>, List<int>, bool, Action>(this.OnRemoveAnimation);
			this.TetrisPlayController.OnCleanAnimation = new Action<Action>(this.OnCleanAnimation);
			this.TetrisPlayController.OnLoseBoardAnimation = delegate(Action onComplete)
			{
				if (this.CurrentDragShape != null)
				{
					TetrisBoardPanel board = this.Board;
					if (board != null)
					{
						board.ClearDragHighlight();
					}
					this.CurrentDragShape = null;
					TetrisDragItemPanel dragItem = this.DragItem;
					if (dragItem != null)
					{
						dragItem.SetUiActive(false);
					}
				}
				this.IsAnimating = true;
				this.SetShapesInteractAble();
				TetrisBoardPanel board2 = this.Board;
				if (board2 == null)
				{
					return;
				}
				board2.PlayLoseRefreshAnimation(this.TetrisPlayController.GetGridModel(), delegate(float delta)
				{
					onComplete();
					this.IsAnimating = false;
					this.SetShapesInteractAble();
				});
			};
			this.TetrisPlayController.OnCombo = new Action<IComboData>(this.OnCombo);
			this.TetrisPlayController.InitLevel(this.Param);
			this.TetrisPlayController.RefillHandShapes();
		}

		// Token: 0x0603E455 RID: 255061 RVA: 0x00F0927A File Offset: 0x00F0747A
		[NullableContext(2)]
		private void OnPlaceAnimation([TupleElementNames(new string[]
		{
			"Row",
			"Column"
		})] [Nullable(new byte[]
		{
			1,
			0
		})] List<ValueTuple<int, int>> positions, TTimerAction onComplete = null)
		{
			TetrisBoardPanel board = this.Board;
			if (board == null)
			{
				return;
			}
			board.PlayPlaceAnimation(positions, onComplete);
		}

		// Token: 0x0603E456 RID: 255062 RVA: 0x00F09290 File Offset: 0x00F07490
		private void OnRemoveAnimation([TupleElementNames(new string[]
		{
			"Row",
			"Column",
			"ColorId"
		})] [Nullable(new byte[]
		{
			1,
			0
		})] List<ValueTuple<int, int, int>> positions, [TupleElementNames(new string[]
		{
			"Row",
			"Column",
			"ColorId"
		})] [Nullable(new byte[]
		{
			1,
			0
		})] List<ValueTuple<int, int, int>> sealChangePositions, List<int> clearedRows, List<int> clearedCols, bool hasCleanAnimation, [Nullable(2)] Action onComplete = null)
		{
			this.IsAnimating = true;
			this.SetShapesInteractAble();
			TTimerAction onComplete2 = delegate(float _)
			{
				TetrisComboPanel comboPanel = this.ComboPanel;
				if (comboPanel != null)
				{
					comboPanel.SetUiActive(false);
				}
				Action onComplete3 = onComplete;
				if (onComplete3 != null)
				{
					onComplete3();
				}
				if (hasCleanAnimation)
				{
					return;
				}
				this.IsAnimating = false;
				this.SetShapesInteractAble();
			};
			TetrisBoardPanel board = this.Board;
			if (board == null)
			{
				return;
			}
			board.PlayRemoveAnimation(positions, sealChangePositions, clearedRows, clearedCols, onComplete2);
		}

		// Token: 0x0603E457 RID: 255063 RVA: 0x00F092E8 File Offset: 0x00F074E8
		[NullableContext(2)]
		private void OnCleanAnimation(Action onComplete = null)
		{
			this.IsAnimating = true;
			this.SetShapesInteractAble();
			TetrisBoardPanel board = this.Board;
			if (board == null)
			{
				return;
			}
			board.PlayCleanAnimation(delegate(float _)
			{
				Action onComplete2 = onComplete;
				if (onComplete2 != null)
				{
					onComplete2();
				}
				this.IsAnimating = false;
				this.SetShapesInteractAble();
			});
		}

		// Token: 0x0603E458 RID: 255064 RVA: 0x00F09332 File Offset: 0x00F07532
		private void OnCombo(IComboData data)
		{
			this.AdjustComboPanelPosition(data.ClearedRows, data.ClearedCols);
			TetrisComboPanel comboPanel = this.ComboPanel;
			if (comboPanel == null)
			{
				return;
			}
			comboPanel.Refresh(data);
		}

		// Token: 0x0603E459 RID: 255065 RVA: 0x00F09358 File Offset: 0x00F07558
		private void AdjustComboPanelPosition(List<int> clearedRows, List<int> clearedCols)
		{
			if (this.ComboPanel == null || this.CellSize == null)
			{
				return;
			}
			float num = 3.5f;
			float num2 = 3.5f;
			float anchorOffsetX = 0f;
			float anchorOffsetY = 0f;
			if (clearedRows.Count > 0)
			{
				List<int> list = new List<int>(clearedRows);
				list.Sort();
				float num3 = (float)list[list.Count / 2];
				anchorOffsetX = 0f;
				float num4 = -(num3 - num) * this.CellSize.Value.Item2;
				float num5 = ((float)new Random().NextDouble() - 0.5f) * 2f * this.CellSize.Value.Item2;
				anchorOffsetY = num4 + num5;
			}
			else if (clearedCols.Count > 0)
			{
				List<int> list2 = new List<int>(clearedCols);
				list2.Sort();
				float num6 = (float)list2[list2.Count / 2];
				anchorOffsetY = 0f;
				float num7 = (num6 - num2) * this.CellSize.Value.Item1;
				float num8 = ((float)new Random().NextDouble() - 0.5f) * 2f * this.CellSize.Value.Item1;
				anchorOffsetX = num7 + num8;
			}
			this.ComboPanel.GetRootItem().SetAnchorOffsetX(anchorOffsetX);
			this.ComboPanel.GetRootItem().SetAnchorOffsetY(anchorOffsetY);
		}

		// Token: 0x0603E45A RID: 255066 RVA: 0x00F0948C File Offset: 0x00F0768C
		protected override void OnBeforeShow()
		{
			TetrisPlayView.<>c__DisplayClass27_0 CS$<>8__locals1 = new TetrisPlayView.<>c__DisplayClass27_0();
			this.RefreshCount();
			if (this.TetrisPlayController.GetGameMode() != EGameMode.Infinite)
			{
				UiManager.Instance.OpenView(EUiViewName.TetrisTipsTargetView, this.TetrisPlayController.GetCurrentTarget(), null);
			}
			CS$<>8__locals1.config = this.TetrisPlayController.GetCurrentConfig();
			TetrisPlayView.<>c__DisplayClass27_0 CS$<>8__locals2 = CS$<>8__locals1;
			int num = (CS$<>8__locals2.config != null) ? CS$<>8__locals2.config.GetValueOrDefault().FlowIdLength : 0;
			List<string> list = new List<string>();
			for (int i = 0; i < num; i++)
			{
				list.Add(CS$<>8__locals1.config.Value.FlowId(i));
			}
			bool flag = list.Count > 0;
			this.TetrisPlayController.SetUseDialogWinOnly(flag);
			if (flag)
			{
				TetrisPlayView.<>c__DisplayClass27_0 CS$<>8__locals3 = CS$<>8__locals1;
				int? num2 = (CS$<>8__locals3.config != null) ? new int?(CS$<>8__locals3.config.GetValueOrDefault().ConditionGroup) : null;
				ChatPopViewData param = new ChatPopViewData
				{
					FlowId = list,
					Condition = num2.GetValueOrDefault(),
					ParentViewId = new int?(base.GetViewId()),
					OnAllShownCallback = delegate()
					{
						int? num3 = (CS$<>8__locals1.config != null) ? new int?(CS$<>8__locals1.config.GetValueOrDefault().Id) : null;
						if (num3 == null)
						{
							return;
						}
						EventSystem.Instance.Emit<EArcadeGameplayType, int>(EEventName.OnArcadeGameplayFinish, EArcadeGameplayType.TetrisBoardGame, num3.Value);
						UiManager.Instance.CloseView(EUiViewName.TetrisPlayView, null);
					}
				};
				UiManager.Instance.OpenView(EUiViewName.ChatPopView, param, null);
			}
			this.OnLogicUpdate(true, false);
		}

		// Token: 0x0603E45B RID: 255067 RVA: 0x00F095D6 File Offset: 0x00F077D6
		public void RefreshEndlessLoading()
		{
			if (this.TetrisPlayController.GetGameMode() == EGameMode.Infinite)
			{
				UiManager.Instance.OpenView(EUiViewName.TetrisTipsEndLessStartView, null, null);
				return;
			}
			UiManager.Instance.OpenView(EUiViewName.TetrisTipsTargetView, this.TetrisPlayController.GetCurrentTarget(), null);
		}

		// Token: 0x0603E45C RID: 255068 RVA: 0x00F09614 File Offset: 0x00F07814
		private void RefreshCount()
		{
			Tetris? tetris;
			int? num = (this.TetrisPlayController.GetCurrentConfig() != null) ? new int?(tetris.GetValueOrDefault().BlockNum) : null;
			if (num.GetValueOrDefault() == 2)
			{
				base.GetItem(9).SetUIActive(true);
				base.GetItem(10).SetUIActive(false);
				base.GetItem(11).SetUIActive(false);
				return;
			}
			if (num.GetValueOrDefault() == 3)
			{
				base.GetItem(10).SetUIActive(true);
				base.GetItem(9).SetUIActive(false);
				base.GetItem(11).SetUIActive(false);
				return;
			}
			if (num.GetValueOrDefault() == 4)
			{
				base.GetItem(11).SetUIActive(true);
				base.GetItem(9).SetUIActive(false);
				base.GetItem(10).SetUIActive(false);
			}
		}

		// Token: 0x0603E45D RID: 255069 RVA: 0x00F096F4 File Offset: 0x00F078F4
		public TetrisPlayController GetTetrisPlayController()
		{
			return this.TetrisPlayController;
		}

		// Token: 0x0603E45E RID: 255070 RVA: 0x00F096FC File Offset: 0x00F078FC
		private void RefreshScroller([Nullable(new byte[]
		{
			1,
			2
		})] List<BlockInstance> shapes)
		{
			this.GenerateShapeList.RefreshByData(shapes, null, false);
		}

		// Token: 0x0603E45F RID: 255071 RVA: 0x00F0970C File Offset: 0x00F0790C
		private void RefreshBoard(TetrisBoardData gridModel, bool isInit, bool isTakeBack = false)
		{
			this.Board.RefreshView(gridModel, isInit, isTakeBack);
		}

		// Token: 0x0603E460 RID: 255072 RVA: 0x00F0971C File Offset: 0x00F0791C
		private void OnLogicUpdate(bool isInit = false, bool isTakeBack = false)
		{
			TetrisBoardData gridModel = this.TetrisPlayController.GetGridModel();
			List<BlockInstance> handShapes = this.TetrisPlayController.GetHandShapes();
			this.RefreshScroller(handShapes);
			this.RefreshBoard(gridModel, isInit, isTakeBack);
			if (this.TetrisPlayController.GetGameMode() == EGameMode.Score)
			{
				this.RefreshScore();
				return;
			}
			if (this.TetrisPlayController.GetGameMode() == EGameMode.GemCollection)
			{
				this.RefreshGem();
				return;
			}
			if (this.TetrisPlayController.GetGameMode() == EGameMode.Infinite)
			{
				this.RefreshInfinite();
			}
		}

		// Token: 0x0603E461 RID: 255073 RVA: 0x00F09790 File Offset: 0x00F07990
		[NullableContext(2)]
		private bool OnBeginDrag(ULGUIPointerEventData eventData, BlockInstance shapeData)
		{
			if (eventData == null)
			{
				return false;
			}
			if (shapeData == null)
			{
				return false;
			}
			this.CurrentDragShape = shapeData;
			this.SetShapesInteractAble();
			Vector2D vector2D = Vector2D.Create();
			LguiUtil.Instance.ConvertPointerPositionToLguiCenterPosition(eventData.pointerPosition, vector2D);
			TetrisDragItemPanel dragItem = this.DragItem;
			if (dragItem != null)
			{
				dragItem.GetRootItem().SetAnchorOffsetX((float)vector2D.X);
			}
			TetrisDragItemPanel dragItem2 = this.DragItem;
			if (dragItem2 != null)
			{
				dragItem2.GetRootItem().SetAnchorOffsetY((float)vector2D.Y);
			}
			TetrisDragItemPanel dragItem3 = this.DragItem;
			if (dragItem3 != null)
			{
				dragItem3.SetUiActive(true);
			}
			TetrisDragItemPanel dragItem4 = this.DragItem;
			if (dragItem4 != null)
			{
				dragItem4.RefreshView(shapeData);
			}
			return true;
		}

		// Token: 0x0603E462 RID: 255074 RVA: 0x00F0982C File Offset: 0x00F07A2C
		[NullableContext(2)]
		private bool OnDrag(ULGUIPointerEventData eventData)
		{
			if (eventData == null)
			{
				return false;
			}
			Vector2D vector2D = Vector2D.Create();
			LguiUtil.Instance.ConvertPointerPositionToLguiCenterPosition(eventData.pointerPosition, vector2D);
			TetrisDragItemPanel dragItem = this.DragItem;
			if (dragItem != null)
			{
				dragItem.GetRootItem().SetAnchorOffsetX((float)vector2D.X);
			}
			TetrisDragItemPanel dragItem2 = this.DragItem;
			if (dragItem2 != null)
			{
				dragItem2.GetRootItem().SetAnchorOffsetY((float)vector2D.Y);
			}
			this.UpdateDragHighlight(vector2D);
			return true;
		}

		// Token: 0x0603E463 RID: 255075 RVA: 0x00F09898 File Offset: 0x00F07A98
		private void UpdateDragHighlight(Vector2D curDragPos)
		{
			if (this.CurrentDragShape == null)
			{
				return;
			}
			ValueTuple<int, int>? valueTuple = this.CalcBoardRawColumnByPosition(curDragPos);
			if ((valueTuple == null && this.LastDragHighlightRowColumn == null) || (valueTuple != null && this.LastDragHighlightRowColumn != null && valueTuple.Value.Item1 == this.LastDragHighlightRowColumn.Value.Item1 && valueTuple.Value.Item2 == this.LastDragHighlightRowColumn.Value.Item2))
			{
				return;
			}
			this.LastDragHighlightRowColumn = ((valueTuple != null) ? new ValueTuple<int, int>?(new ValueTuple<int, int>(valueTuple.Value.Item1, valueTuple.Value.Item2)) : null);
			TetrisBoardPanel board = this.Board;
			if (board != null)
			{
				board.ClearDragHighlight();
			}
			if (valueTuple == null)
			{
				return;
			}
			ValueTuple<int, int> valueTuple2 = TetrisUtils.Instance.FindAnchorOffset(this.CurrentDragShape.Offsets);
			int num = valueTuple.Value.Item1 - valueTuple2.Item1;
			int num2 = valueTuple.Value.Item2 - valueTuple2.Item2;
			if (this.TetrisPlayController.CanPlaceShape(this.CurrentDragShape.Offsets, num, num2))
			{
				List<ValueTuple<int, int>> list = new List<ValueTuple<int, int>>();
				foreach (ValueTuple<int, int> valueTuple3 in this.CurrentDragShape.Offsets)
				{
					list.Add(new ValueTuple<int, int>(num + valueTuple3.Item1, num2 + valueTuple3.Item2));
				}
				ValueTuple<List<int>, List<int>> clearAbleRowsAndColsIfPlace = this.TetrisPlayController.GetClearAbleRowsAndColsIfPlace(list);
				TetrisBoardPanel board2 = this.Board;
				if (board2 == null)
				{
					return;
				}
				board2.ShowDragHighlight(list, this.CurrentDragShape.ColorId, clearAbleRowsAndColsIfPlace.Item1, clearAbleRowsAndColsIfPlace.Item2);
			}
		}

		// Token: 0x0603E464 RID: 255076 RVA: 0x00F09A78 File Offset: 0x00F07C78
		[NullableContext(2)]
		private bool OnEndDrag(ULGUIPointerEventData eventData, int index, BlockInstance shapeData)
		{
			TetrisBoardPanel board = this.Board;
			if (board != null)
			{
				board.ClearDragHighlight();
			}
			this.CurrentDragShape = null;
			this.LastDragHighlightRowColumn = null;
			this.SetShapesInteractAble();
			if (eventData == null || shapeData == null)
			{
				TetrisDragItemPanel dragItem = this.DragItem;
				if (dragItem != null)
				{
					dragItem.SetUiActive(false);
				}
				return true;
			}
			Vector2D vector2D = Vector2D.Create();
			LguiUtil.Instance.ConvertPointerPositionToLguiCenterPosition(eventData.pointerPosition, vector2D);
			ValueTuple<int, int>? valueTuple = this.CalcBoardRawColumnByPosition(vector2D);
			TetrisDragItemPanel dragItem2 = this.DragItem;
			if (dragItem2 != null)
			{
				dragItem2.SetUiActive(false);
			}
			if (valueTuple == null)
			{
				return false;
			}
			ValueTuple<int, int> valueTuple2 = TetrisUtils.Instance.FindAnchorOffset(shapeData.Offsets);
			this.TetrisPlayController.OnPlayerDropShape(index, valueTuple.Value.Item1 - valueTuple2.Item1, valueTuple.Value.Item2 - valueTuple2.Item2);
			return true;
		}

		// Token: 0x0603E465 RID: 255077 RVA: 0x00F09B4C File Offset: 0x00F07D4C
		[NullableContext(0)]
		[return: TupleElementNames(new string[]
		{
			"Row",
			"Column"
		})]
		public ValueTuple<int, int>? CalcBoardRawColumnByPosition([Nullable(1)] Vector2D pos)
		{
			double num = (double)4f;
			float num2 = 4f;
			int num3 = (int)Math.Floor(pos.X / (double)this.CellSize.Value.Item1 + (double)num2);
			int num4 = (int)Math.Floor(num - pos.Y / (double)this.CellSize.Value.Item2);
			if (num3 < 0 || num3 >= 8 || num4 < 0 || num4 >= 8)
			{
				return null;
			}
			return new ValueTuple<int, int>?(new ValueTuple<int, int>(num4, num3));
		}

		// Token: 0x0603E466 RID: 255078 RVA: 0x00F09BD0 File Offset: 0x00F07DD0
		private TetrisShapeBagGridView UpdateItem()
		{
			TetrisShapeBagGridView tetrisShapeBagGridView = new TetrisShapeBagGridView();
			tetrisShapeBagGridView.OnViewBeginDrag = new Func<ULGUIPointerEventData, BlockInstance, bool>(this.OnBeginDrag);
			tetrisShapeBagGridView.OnViewDrag = new Func<ULGUIPointerEventData, bool>(this.OnDrag);
			tetrisShapeBagGridView.OnViewEndDrag = new Func<ULGUIPointerEventData, int, BlockInstance, bool>(this.OnEndDrag);
			tetrisShapeBagGridView.SetPoolManager(this);
			this.ShapeBagViews.Add(tetrisShapeBagGridView);
			return tetrisShapeBagGridView;
		}

		// Token: 0x0603E467 RID: 255079 RVA: 0x00F09C30 File Offset: 0x00F07E30
		private void SetShapesInteractAble()
		{
			bool interactAble = !this.IsAnimating && this.CurrentDragShape == null;
			foreach (TetrisShapeBagGridView tetrisShapeBagGridView in this.ShapeBagViews)
			{
				tetrisShapeBagGridView.SetInteractAble(interactAble);
			}
		}

		// Token: 0x0603E468 RID: 255080 RVA: 0x00F09C98 File Offset: 0x00F07E98
		private TetrisGemProgressGrid UpdateProgressItem()
		{
			return new TetrisGemProgressGrid();
		}

		// Token: 0x0603E469 RID: 255081 RVA: 0x00F09CA0 File Offset: 0x00F07EA0
		private void RefreshInfinite()
		{
			TetrisScoreProgressPanel scoreProgressItem = this.ScoreProgressItem;
			if (scoreProgressItem != null)
			{
				scoreProgressItem.SetUiActive(true);
			}
			UUIItem item = base.GetItem(15);
			if (item != null)
			{
				item.SetUIActive(true);
			}
			UUIText text = base.GetText(14);
			if (text != null)
			{
				text.SetText(TetrisController.Instance.GetHighestScore().ToString(), true);
			}
			this.ScoreProgressItem.RefreshInfinite(this.TetrisPlayController.GetCurrentScore());
		}

		// Token: 0x0603E46A RID: 255082 RVA: 0x00F09D10 File Offset: 0x00F07F10
		private void RefreshScore()
		{
			TetrisScoreProgressPanel scoreProgressItem = this.ScoreProgressItem;
			if (scoreProgressItem != null)
			{
				scoreProgressItem.SetUiActive(true);
			}
			int targetScore;
			this.TetrisPlayController.GetCurrentTarget().TryGetValue(0, out targetScore);
			this.ScoreProgressItem.Refresh(this.TetrisPlayController.GetCurrentScore(), targetScore);
		}

		// Token: 0x0603E46B RID: 255083 RVA: 0x00F09D5C File Offset: 0x00F07F5C
		private void RefreshGem()
		{
			Dictionary<int, int> currentTarget = this.TetrisPlayController.GetCurrentTarget();
			if (currentTarget == null)
			{
				return;
			}
			List<ITetrisGemProgressData> list = new List<ITetrisGemProgressData>();
			foreach (KeyValuePair<int, int> keyValuePair in currentTarget)
			{
				list.Add(new TetrisGemProgressData
				{
					GemId = keyValuePair.Key,
					CurrentGemCount = this.TetrisPlayController.GetCurrentGem(keyValuePair.Key),
					TargetGemCount = keyValuePair.Value
				});
			}
			this.GemProgressList.RefreshByData(list, null, false);
		}

		// Token: 0x0603E46C RID: 255084 RVA: 0x00F09E04 File Offset: 0x00F08004
		private void OnClickedCloseButton()
		{
			ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.TetrisQuitConfirm);
			confirmBoxDataNew.IsEscViewTriggerCallBack = false;
			confirmBoxDataNew.FunctionMap.Add(1, new Action(this.<OnClickedCloseButton>g__cancelCallback|45_0));
			confirmBoxDataNew.FunctionMap.Add(2, new Action(this.<OnClickedCloseButton>g__confirmCallback|45_1));
			ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
		}

		// Token: 0x0603E46D RID: 255085 RVA: 0x00F09E60 File Offset: 0x00F08060
		private void OnClickHelpBtn()
		{
			HelpController.Instance.OpenHelpById(this.TetrisPlayController.GetCurrentConfig().Value.HelpId);
		}

		// Token: 0x0603E46E RID: 255086 RVA: 0x00F09E94 File Offset: 0x00F08094
		[return: TupleElementNames(new string[]
		{
			"Grid",
			"IsNew"
		})]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public ValueTuple<TetrisGridPanel, bool> GetGrid(UUIItem poolContainer)
		{
			if (this.GridPool.Count > 0)
			{
				TetrisGridPanel tetrisGridPanel = this.GridPool[this.GridPool.Count - 1];
				this.GridPool.RemoveAt(this.GridPool.Count - 1);
				tetrisGridPanel.GetRootItem().K2_AttachToComponent(poolContainer, null, EAttachmentRule.KeepRelative, EAttachmentRule.KeepRelative, EAttachmentRule.KeepRelative, false, true);
				return new ValueTuple<TetrisGridPanel, bool>(tetrisGridPanel, false);
			}
			return new ValueTuple<TetrisGridPanel, bool>(new TetrisGridPanel(0, 0), true);
		}

		// Token: 0x0603E46F RID: 255087 RVA: 0x00F09F0C File Offset: 0x00F0810C
		public void ReturnGrid(TetrisGridPanel grid)
		{
			grid.SetUiActive(false);
			if (this.PoolContainer != null)
			{
				UUIItem rootItem = grid.GetRootItem();
				if (rootItem != null)
				{
					rootItem.K2_AttachToComponent(this.PoolContainer, null, EAttachmentRule.KeepRelative, EAttachmentRule.KeepRelative, EAttachmentRule.KeepRelative, false, true);
				}
			}
			this.GridPool.Add(grid);
		}

		// Token: 0x0603E470 RID: 255088 RVA: 0x00F09F58 File Offset: 0x00F08158
		public void TetrisRewardClose()
		{
			UiManager.Instance.CloseView(EUiViewName.TetrisPlayView, null);
			if (TetrisUtils.IsHardLevel(this.TetrisPlayController.GetCurrentConfig().Value) || TetrisUtils.IsEggLevel(this.TetrisPlayController.GetCurrentConfig().Value))
			{
				UiManager.Instance.CloseView(EUiViewName.TetrisLevelDetailView, null);
			}
		}

		// Token: 0x0603E471 RID: 255089 RVA: 0x00F09FB9 File Offset: 0x00F081B9
		public void HideCloseBtn()
		{
			PopupCaptionItem captionItem = this.CaptionItem;
			if (captionItem == null)
			{
				return;
			}
			captionItem.SetCloseBtnActive(false);
		}

		// Token: 0x0603E472 RID: 255090 RVA: 0x00F09FCC File Offset: 0x00F081CC
		public void ShowCloseBtn()
		{
			PopupCaptionItem captionItem = this.CaptionItem;
			if (captionItem == null)
			{
				return;
			}
			captionItem.SetCloseBtnActive(true);
		}

		// Token: 0x0603E473 RID: 255091 RVA: 0x00F09FE0 File Offset: 0x00F081E0
		protected override void OnBeforeDestroy()
		{
			base.OnBeforeDestroy();
			if (this.TetrisPlayController != null)
			{
				this.TetrisPlayController.ClearCallBack();
			}
			foreach (TetrisGridPanel tetrisGridPanel in this.GridPool)
			{
				tetrisGridPanel.Destroy(null);
			}
			this.GridPool = new List<TetrisGridPanel>();
		}

		// Token: 0x0603E474 RID: 255092 RVA: 0x00F0A058 File Offset: 0x00F08258
		private void OnActivityClose(IReadOnlySet<int> closeActivities)
		{
			if (!TetrisUtils.IsActivityLevel(this.TetrisPlayController.GetCurrentConfig().Value))
			{
				return;
			}
			if (closeActivities.Contains(ActivityTetrisController.Instance.ActivityId))
			{
				ActivityController.Instance.ShowActivityRefreshAndBackToBattleView();
			}
		}

		// Token: 0x0603E475 RID: 255093 RVA: 0x00F0A09C File Offset: 0x00F0829C
		public void OpenLoseConfirm()
		{
			ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.TetrisLoseConfirm);
			confirmBoxDataNew.FunctionMap.Add(1, new Action(this.<OpenLoseConfirm>g__cancelCallback|54_0));
			confirmBoxDataNew.FunctionMap.Add(2, new Action(this.<OpenLoseConfirm>g__confirmCallback|54_1));
			ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
		}

		// Token: 0x0603E476 RID: 255094 RVA: 0x00F0A0F0 File Offset: 0x00F082F0
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public override UUIItem[] GetGuideUiItemAndUiItemForShowEx(string[] configParams)
		{
			string a = configParams[0];
			if (a == "Grid")
			{
				int row = int.Parse(configParams[1]);
				int column = int.Parse(configParams[2]);
				TetrisBoardPanel board = this.Board;
				UUIItem uuiitem;
				if (board == null)
				{
					uuiitem = null;
				}
				else
				{
					TetrisBoardGridPanel gridPanel = board.GetGridPanel(row, column);
					uuiitem = ((gridPanel != null) ? gridPanel.GetRootItem() : null);
				}
				UUIItem uuiitem2 = uuiitem;
				if (uuiitem2 == null)
				{
					return null;
				}
				return new UUIItem[]
				{
					uuiitem2,
					uuiitem2
				};
			}
			else
			{
				if (!(a == "Shape"))
				{
					return null;
				}
				int index = int.Parse(configParams[1]);
				GenericLayout<TetrisShapeBagGridView, BlockInstance> generateShapeList = this.GenerateShapeList;
				UUIItem uuiitem3 = (generateShapeList != null) ? generateShapeList.GetItemByIndex(index) : null;
				if (uuiitem3 == null)
				{
					return null;
				}
				return new UUIItem[]
				{
					uuiitem3,
					uuiitem3
				};
			}
		}

		// Token: 0x0603E479 RID: 255097 RVA: 0x00F0A273 File Offset: 0x00F08473
		[CompilerGenerated]
		private void <OnClickedCloseButton>g__cancelCallback|45_0()
		{
			this.TetrisPlayController.DoResetTetris();
		}

		// Token: 0x0603E47A RID: 255098 RVA: 0x00F0A280 File Offset: 0x00F08480
		[CompilerGenerated]
		private void <OnClickedCloseButton>g__confirmCallback|45_1()
		{
			if (this.TetrisPlayController.GetGameMode() == EGameMode.Infinite)
			{
				TetrisController.Instance.SendCompleteRequest(this.TetrisPlayController.GenInfiniteRequestMsg(), null);
				EndLessEndOpenParam endLessEndOpenParam = new EndLessEndOpenParam();
				TetrisPlayController tetrisPlayController = this.TetrisPlayController;
				endLessEndOpenParam.Score = ((tetrisPlayController != null) ? tetrisPlayController.GetCurrentScore() : 0);
				endLessEndOpenParam.IsQuit = true;
				EndLessEndOpenParam param = endLessEndOpenParam;
				UiManager.Instance.OpenView(EUiViewName.TetrisTipsEndLessEndView, param, null);
			}
			else
			{
				UiManager.Instance.CloseView(EUiViewName.TetrisPlayView, null);
			}
			this.TetrisPlayController.SendResultLogData(2);
		}

		// Token: 0x0603E47B RID: 255099 RVA: 0x00F0A308 File Offset: 0x00F08508
		[CompilerGenerated]
		private void <OpenLoseConfirm>g__cancelCallback|54_0()
		{
			UiManager.Instance.CloseView(EUiViewName.TetrisPlayView, null);
			if (this.TetrisPlayController.GetGameMode() == EGameMode.Infinite)
			{
				TetrisController.Instance.SendCompleteRequest(this.TetrisPlayController.GenInfiniteRequestMsg(), null);
			}
			this.TetrisPlayController.SendResultLogData(0);
		}

		// Token: 0x0603E47C RID: 255100 RVA: 0x00F0A355 File Offset: 0x00F08555
		[CompilerGenerated]
		private void <OpenLoseConfirm>g__confirmCallback|54_1()
		{
			if (this.TetrisPlayController.GetGameMode() == EGameMode.Infinite)
			{
				TetrisController.Instance.SendCompleteRequest(this.TetrisPlayController.GenInfiniteRequestMsg(), null);
			}
			this.TetrisPlayController.OnLoseReset();
		}

		// Token: 0x040208A8 RID: 133288
		[Nullable(2)]
		private PopupCaptionItem CaptionItem;

		// Token: 0x040208A9 RID: 133289
		[Nullable(new byte[]
		{
			1,
			1,
			2
		})]
		private GenericLayout<TetrisShapeBagGridView, BlockInstance> GenerateShapeList;

		// Token: 0x040208AA RID: 133290
		private GenericLayout<TetrisGemProgressGrid, ITetrisGemProgressData> GemProgressList;

		// Token: 0x040208AB RID: 133291
		[Nullable(2)]
		private TetrisDragItemPanel DragItem;

		// Token: 0x040208AC RID: 133292
		[Nullable(2)]
		private TetrisBoardPanel Board;

		// Token: 0x040208AD RID: 133293
		[Nullable(2)]
		private TetrisComboPanel ComboPanel;

		// Token: 0x040208AE RID: 133294
		[TupleElementNames(new string[]
		{
			"Width",
			"Height"
		})]
		[Nullable(0)]
		private ValueTuple<float, float>? CellSize;

		// Token: 0x040208AF RID: 133295
		[Nullable(2)]
		private TetrisScoreProgressPanel ScoreProgressItem;

		// Token: 0x040208B0 RID: 133296
		[Nullable(2)]
		private TetrisPlayController TetrisPlayController;

		// Token: 0x040208B1 RID: 133297
		private int Param;

		// Token: 0x040208B2 RID: 133298
		[Nullable(2)]
		private BlockInstance CurrentDragShape;

		// Token: 0x040208B3 RID: 133299
		[TupleElementNames(new string[]
		{
			"Row",
			"Column"
		})]
		[Nullable(0)]
		private ValueTuple<int, int>? LastDragHighlightRowColumn;

		// Token: 0x040208B4 RID: 133300
		private bool IsAnimating;

		// Token: 0x040208B5 RID: 133301
		private readonly List<TetrisShapeBagGridView> ShapeBagViews = new List<TetrisShapeBagGridView>();

		// Token: 0x040208B6 RID: 133302
		private List<TetrisGridPanel> GridPool = new List<TetrisGridPanel>();

		// Token: 0x040208B7 RID: 133303
		[Nullable(2)]
		private UUIItem PoolContainer;
	}
}
