using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using Aki.Game.Module.Activity.ActivityContent.Tetris.Activity;
using Aki.Game.Module.Activity.ActivityContent.Tetris.Input;
using Aki.TDConfigMgr.Quest;
using CSharpScript.Core.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Plot.PlotView;
using CSharpScript.Game.Module.UiNavigation;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace Aki.Game.Module.Activity.ActivityContent.Tetris.View
{
	// Token: 0x02002FD4 RID: 12244
	[NullableContext(1)]
	[Nullable(0)]
	public class TetrisPlayView : UiTickViewBase, IGridPoolManager, ITetrisDragHost
	{
		// Token: 0x0601D0D6 RID: 118998 RVA: 0x008E0398 File Offset: 0x008DE598
		public TetrisPlayView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x17002E27 RID: 11815
		// (get) Token: 0x0601D0D7 RID: 118999 RVA: 0x008E03D4 File Offset: 0x008DE5D4
		private int CurrentDragIndex
		{
			get
			{
				TetrisPlayView.TetrisDragSession dragSession = this.DragSession;
				if (dragSession == null)
				{
					return -1;
				}
				return dragSession.CurrentHandIndex;
			}
		}

		// Token: 0x17002E28 RID: 11816
		// (get) Token: 0x0601D0D8 RID: 119000 RVA: 0x008E03E7 File Offset: 0x008DE5E7
		[Nullable(2)]
		private BlockInstance CurrentDragShape
		{
			[NullableContext(2)]
			get
			{
				TetrisPlayView.TetrisDragSession dragSession = this.DragSession;
				if (dragSession == null)
				{
					return null;
				}
				return dragSession.CurrentShape;
			}
		}

		// Token: 0x17002E29 RID: 11817
		// (get) Token: 0x0601D0D9 RID: 119001 RVA: 0x008E03FA File Offset: 0x008DE5FA
		private bool IsAnimating
		{
			get
			{
				return this.TetrisPlayController.IsAnimating;
			}
		}

		// Token: 0x17002E2A RID: 11818
		// (get) Token: 0x0601D0DA RID: 119002 RVA: 0x008E0408 File Offset: 0x008DE608
		private bool ShouldShowCloseButton
		{
			get
			{
				if (!this.IsGamepadDragging)
				{
					TetrisPlayController tetrisPlayController = this.TetrisPlayController;
					return tetrisPlayController == null || !tetrisPlayController.IsSettlingScore;
				}
				return false;
			}
		}

		// Token: 0x0601D0DB RID: 119003 RVA: 0x008E0438 File Offset: 0x008DE638
		protected unsafe override void OnRegisterComponent()
		{
			int num = 22;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIVerticalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIVerticalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(13, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(14, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(15, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(16, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(17, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(18, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(19, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(20, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(21, typeof(UUIButtonComponent));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(18, new Action(this.OnClickRotationButton));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0601D0DC RID: 119004 RVA: 0x008E0784 File Offset: 0x008DE984
		protected override UniTask OnBeforeStartAsync()
		{
			TetrisPlayView.<OnBeforeStartAsync>d__37 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<TetrisPlayView.<OnBeforeStartAsync>d__37>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0601D0DD RID: 119005 RVA: 0x008E07C8 File Offset: 0x008DE9C8
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.InputControllerMainTypeChange, new Action<EInputControllerMainType, EInputControllerMainType>(this.OnInputControllerMainTypeChange));
			EventSystem.Instance.Add(EEventName.OnActivityClose, new Action<IReadOnlySet<int>>(this.OnActivityClose));
			EventSystem.Instance.Add(EEventName.TetrisRotate, new Action(this.OnTetrisRotate));
			EventSystem.Instance.Add(EEventName.TetrisPickShape, new Action<int>(this.OnTetrisPickShape));
		}

		// Token: 0x0601D0DE RID: 119006 RVA: 0x008E0848 File Offset: 0x008DEA48
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.InputControllerMainTypeChange, new Action<EInputControllerMainType, EInputControllerMainType>(this.OnInputControllerMainTypeChange));
			EventSystem.Instance.Remove(EEventName.OnActivityClose, new Action<IReadOnlySet<int>>(this.OnActivityClose));
			EventSystem.Instance.Remove(EEventName.TetrisRotate, new Action(this.OnTetrisRotate));
			EventSystem.Instance.Remove(EEventName.TetrisPickShape, new Action<int>(this.OnTetrisPickShape));
		}

		// Token: 0x0601D0DF RID: 119007 RVA: 0x008E08C8 File Offset: 0x008DEAC8
		protected override void OnStart()
		{
			this.Param = (int)this.OpenParam;
			this.CaptionItem = new PopupCaptionItem(base.GetItem(0));
			this.CaptionItem.SetCloseCallBack(new Action(this.OnClickedCloseButton));
			this.CaptionItem.SetHelpCallBack(new Action(this.OnClickHelpBtn));
			this.PoolContainer = base.GetItem(2);
			this.GemProgressList = new GenericLayout<TetrisGemProgressGrid, TetrisGemProgressData>(base.GetVerticalLayout(12), new Func<TetrisGemProgressGrid>(this.UpdateProgressItem), null, false, true);
			UUIItem item = base.GetItem(5);
			this.CellSize.Item1 = item.GetWidth();
			this.CellSize.Item2 = item.GetHeight();
			this.TetrisPlayController = new TetrisPlayController
			{
				OnAnimatingChanged = new Action<bool>(this.OnAnimatingChanged),
				OnScoreSettlementChanged = new Action(this.OnScoreSettlementChanged),
				OnBeforeOpenPopup = new Action(this.OnBeforeOpenPopup),
				OnDataUpdate = new Action<bool, bool>(this.OnLogicUpdate),
				OnCombo = new Action<ComboData>(this.OnCombo),
				OnRefillHandShapes = new Action(this.OnRefillHandShapes),
				OnHandShapesCleared = new Action(this.OnHandShapesCleared),
				OnPlaceAnimation = new TetrisPlayController.Delegate_OnPlaceAnimation(this.OnPlaceAnimation),
				OnRemoveAnimation = new TetrisPlayController.Delegate_OnRemoveAnimation(this.OnRemoveAnimation),
				OnCleanAnimation = new TetrisPlayController.Delegate_OnCleanAnimation(this.OnCleanAnimation),
				OnLoseBoardAnimation = new TetrisPlayController.Delegate_OnLoseBoardAnimation(this.OnLoseBoardAnimation)
			};
			this.TetrisPlayController.InitLevel(this.Param);
			this.TetrisPlayController.RefillHandShapes();
			this.DragInputController = new TetrisInputController(base.GetViewId(), this, new Func<UiNavigationViewHandle>(this.GetDragNavigationHandle));
			if (this.TetrisPlayController.IsActivityLevel())
			{
				ActivityTetrisData tetrisData = ActivityTetrisController.Instance.GetTetrisData();
				if (tetrisData != null)
				{
					this.CaptionItem.SetTitleLocalText(tetrisData.GetTitleTextId());
				}
			}
			this.RefreshTouchRotationButton();
			this.RefreshCloseBtn();
			base.ApplyCommandSwitcher("r.PSO.IgnoreCreationHints", 1, null, null);
			base.ApplyCommandSwitcher("r.PSO.CompilationMode", 1, null, null);
		}

		// Token: 0x0601D0E0 RID: 119008 RVA: 0x008E0AF0 File Offset: 0x008DECF0
		protected override void OnAfterShow()
		{
			TetrisInputController dragInputController = this.DragInputController;
			if (dragInputController != null)
			{
				dragInputController.Start();
			}
			this.RefreshTouchRotationButton();
		}

		// Token: 0x0601D0E1 RID: 119009 RVA: 0x008E0B0C File Offset: 0x008DED0C
		private void RefreshTouchRotationButton()
		{
			bool flag = Info.Instance.IsInTouch();
			this.RotationButton.SetUiActive(flag && this.TetrisPlayController.IsRotationEnabled());
			this.RotationButton.SetEnabled(flag && this.DragSession != null && this.IsRotateActionEnabled);
		}

		// Token: 0x0601D0E2 RID: 119010 RVA: 0x008E0B5F File Offset: 0x008DED5F
		[NullableContext(2)]
		private void OnPlaceAnimation([TupleElementNames(new string[]
		{
			"Row",
			"Column"
		})] [Nullable(new byte[]
		{
			1,
			0
		})] IReadOnlyList<ValueTuple<int, int>> positions, Action onComplete = null)
		{
			this.Board.PlayPlaceAnimation(positions, onComplete);
		}

		// Token: 0x0601D0E3 RID: 119011 RVA: 0x008E0B6E File Offset: 0x008DED6E
		[NullableContext(2)]
		private void OnRemoveAnimation(TetrisClearInfo clearInfo, Action onNext = null, Action onComplete = null)
		{
			this.Board.PlayRemoveAnimation(clearInfo, onNext, onComplete);
		}

		// Token: 0x0601D0E4 RID: 119012 RVA: 0x008E0B7E File Offset: 0x008DED7E
		[NullableContext(2)]
		private void OnCleanAnimation(bool isReset, Action onComplete = null)
		{
			this.Board.PlayCleanAnimation(isReset, onComplete);
		}

		// Token: 0x0601D0E5 RID: 119013 RVA: 0x008E0B8D File Offset: 0x008DED8D
		[NullableContext(2)]
		private void OnLoseBoardAnimation(Action onComplete)
		{
			this.Board.PlayLoseRefreshAnimation(this.TetrisPlayController.GetGridModel(), onComplete);
		}

		// Token: 0x0601D0E6 RID: 119014 RVA: 0x008E0BA8 File Offset: 0x008DEDA8
		private void OnCombo(ComboData data)
		{
			if (data.ClearInfo.Lines > 0)
			{
				this.AdjustComboPanelPosition(data.ClearInfo.ClearedRows, data.ClearInfo.ClearedCols);
			}
			else if (data.ClearInfo.IsBombExplosion)
			{
				this.AdjustComboPanelPositionByBombs(data.ClearInfo.Bombs, data.ClearInfo.SuperBombs);
			}
			this.ComboPanel.Refresh(data);
		}

		// Token: 0x0601D0E7 RID: 119015 RVA: 0x008E0C28 File Offset: 0x008DEE28
		private void AdjustComboPanelPosition(int[] clearedRows, int[] clearedCols)
		{
			float anchorOffsetX = 0f;
			float anchorOffsetY = 0f;
			if (clearedRows.Length != 0)
			{
				List<int> list = new List<int>(clearedRows);
				list.Sort();
				float num = (float)list[list.Count / 2];
				anchorOffsetX = 0f;
				float num2 = -(num - 3.5f) * this.CellSize.Item2;
				float num3 = (this.TetrisPlayController.GetRandomFloat() - 0.5f) * 2f * this.CellSize.Item2;
				anchorOffsetY = num2 + num3;
			}
			else if (clearedCols.Length != 0)
			{
				List<int> list2 = new List<int>(clearedCols);
				list2.Sort();
				float num4 = (float)list2[list2.Count / 2];
				anchorOffsetY = 0f;
				float num5 = (num4 - 3.5f) * this.CellSize.Item1;
				float num6 = (this.TetrisPlayController.GetRandomFloat() - 0.5f) * 2f * this.CellSize.Item1;
				anchorOffsetX = num5 + num6;
			}
			UUIItem rootItem = this.ComboPanel.GetRootItem();
			if (rootItem != null)
			{
				rootItem.SetAnchorOffsetX(anchorOffsetX);
			}
			UUIItem rootItem2 = this.ComboPanel.GetRootItem();
			if (rootItem2 == null)
			{
				return;
			}
			rootItem2.SetAnchorOffsetY(anchorOffsetY);
		}

		// Token: 0x0601D0E8 RID: 119016 RVA: 0x008E0D2C File Offset: 0x008DEF2C
		private void AdjustComboPanelPositionByBombs([TupleElementNames(new string[]
		{
			"Row",
			"Column",
			"ColorId"
		})] [Nullable(new byte[]
		{
			1,
			0
		})] ValueTuple<int, int, int>[] bombs, [TupleElementNames(new string[]
		{
			"Row",
			"Column",
			"ColorId"
		})] [Nullable(new byte[]
		{
			1,
			0
		})] ValueTuple<int, int, int>[] superBombs)
		{
			UUIItem rootItem = this.ComboPanel.GetRootItem();
			if (rootItem == null || bombs.Length + superBombs.Length == 0)
			{
				return;
			}
			List<ValueTuple<float, float, int, float>> list = new List<ValueTuple<float, float, int, float>>();
			foreach (ValueTuple<int, int, int> valueTuple in bombs)
			{
				list.Add(new ValueTuple<float, float, int, float>((float)valueTuple.Item1, (float)valueTuple.Item2, 1, 1f));
			}
			foreach (ValueTuple<int, int, int> valueTuple2 in superBombs)
			{
				list.Add(new ValueTuple<float, float, int, float>((float)valueTuple2.Item1, (float)valueTuple2.Item2, 2, 2f));
			}
			float num = 0f;
			float num2 = 0f;
			float num3 = 0f;
			foreach (ValueTuple<float, float, int, float> valueTuple3 in list)
			{
				num += valueTuple3.Item1 * valueTuple3.Item4;
				num2 += valueTuple3.Item2 * valueTuple3.Item4;
				num3 += valueTuple3.Item4;
			}
			num /= num3;
			num2 /= num3;
			float num4 = rootItem.GetWidth() / this.CellSize.Item1 / 2f + 0.25f;
			float num5 = rootItem.GetHeight() / this.CellSize.Item2 / 2f + 0.25f;
			num4 = Math.Clamp(num4, 0.5f, 4f);
			num5 = Math.Clamp(num5, 0.5f, 4f);
			float num6 = -0.5f + num4;
			float num7 = 7.5f - num4;
			float num8 = -0.5f + num5;
			float num9 = 7.5f - num5;
			float num10 = 3.5f;
			float num11 = 3.5f;
			float num12 = float.MaxValue;
			float num13 = float.MaxValue;
			for (float num14 = num8; num14 <= num9 + 0.0001f; num14 += 0.5f)
			{
				for (float num15 = num6; num15 <= num7 + 0.0001f; num15 += 0.5f)
				{
					float val = num14 - num5;
					float val2 = num14 + num5;
					float val3 = num15 - num4;
					float val4 = num15 + num4;
					float num16 = 0f;
					foreach (ValueTuple<float, float, int, float> valueTuple4 in list)
					{
						float num17 = (float)valueTuple4.Item3 + 0.5f;
						float val5 = Math.Max(valueTuple4.Item1 - num17, -0.5f);
						float val6 = Math.Min(valueTuple4.Item1 + num17, 7.5f);
						float val7 = Math.Max(valueTuple4.Item2 - num17, -0.5f);
						float val8 = Math.Min(valueTuple4.Item2 + num17, 7.5f);
						float num18 = Math.Max(0f, Math.Min(val2, val6) - Math.Max(val, val5));
						float num19 = Math.Max(0f, Math.Min(val4, val8) - Math.Max(val3, val7));
						num16 += num19 * num18 * valueTuple4.Item4;
					}
					float num20 = num14 - num;
					float num21 = num15 - num2;
					float num22 = num20 * num20 + num21 * num21;
					if (num16 < num12 - 0.0001f || (Math.Abs(num16 - num12) <= 0.0001f && num22 < num13))
					{
						num12 = num16;
						num13 = num22;
						num10 = num14;
						num11 = num15;
					}
				}
			}
			float anchorOffsetX = (num11 - 3.5f) * this.CellSize.Item1;
			float anchorOffsetY = -(num10 - 3.5f) * this.CellSize.Item2;
			rootItem.SetAnchorOffsetX(anchorOffsetX);
			rootItem.SetAnchorOffsetY(anchorOffsetY);
		}

		// Token: 0x0601D0E9 RID: 119017 RVA: 0x008E10EC File Offset: 0x008DF2EC
		private void OnRefillHandShapes()
		{
			if (this.DragSession != null)
			{
				TetrisInputController dragInputController = this.DragInputController;
				if (dragInputController != null)
				{
					dragInputController.CancelDrag(ETetrisDragCancelReason.InvalidHandShape);
				}
			}
			for (int i = 0; i < this.BlockNum; i++)
			{
				this.ShapeBagViews[i].PlayRefreshAnimation();
			}
		}

		// Token: 0x0601D0EA RID: 119018 RVA: 0x008E1131 File Offset: 0x008DF331
		private void OnHandShapesCleared()
		{
			this.RefreshScroller(new BlockInstance[this.BlockNum]);
		}

		// Token: 0x0601D0EB RID: 119019 RVA: 0x008E1144 File Offset: 0x008DF344
		protected override void OnBeforeShow()
		{
			TetrisPlayView.<>c__DisplayClass52_0 CS$<>8__locals1 = new TetrisPlayView.<>c__DisplayClass52_0();
			CS$<>8__locals1.<>4__this = this;
			if (this.IsFirstShow)
			{
				this.RefreshCount();
				this.OnBeforeOpenPopup();
				if (this.TetrisPlayController.GetGameMode() != EGameMode.Infinite)
				{
					UiManager.Instance.OpenView(EUiViewName.TetrisTipsTargetView, this.TetrisPlayController.GetCurrentTarget(), null);
				}
				else if (this.TetrisPlayController.IsActivityLevel())
				{
					UiManager.Instance.OpenView(EUiViewName.TetrisTipsEndLessStartView, true, null);
				}
				CS$<>8__locals1.config = this.TetrisPlayController.GetCurrentConfig();
				TetrisPlayView.<>c__DisplayClass52_0 CS$<>8__locals2 = CS$<>8__locals1;
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
					TetrisPlayView.<>c__DisplayClass52_0 CS$<>8__locals3 = CS$<>8__locals1;
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
							CS$<>8__locals1.<>4__this.CloseMe(null);
						}
					};
					this.OnBeforeOpenPopup();
					UiManager.Instance.OpenView(EUiViewName.ChatPopView, param, null);
				}
				this.OnLogicUpdate(true, false);
				this.IsFirstShow = false;
			}
		}

		// Token: 0x0601D0EC RID: 119020 RVA: 0x008E12D8 File Offset: 0x008DF4D8
		public void RefreshEndlessLoading()
		{
			this.OnBeforeOpenPopup();
			if (this.TetrisPlayController.GetGameMode() == EGameMode.Infinite)
			{
				UiManager.Instance.OpenView(EUiViewName.TetrisTipsEndLessStartView, null, null);
				return;
			}
			UiManager.Instance.OpenView(EUiViewName.TetrisTipsTargetView, this.TetrisPlayController.GetCurrentTarget(), null);
		}

		// Token: 0x0601D0ED RID: 119021 RVA: 0x008E1328 File Offset: 0x008DF528
		private void RefreshCount()
		{
			Tetris? currentConfig = this.TetrisPlayController.GetCurrentConfig();
			if (currentConfig != null)
			{
				this.BlockNum = currentConfig.GetValueOrDefault().BlockNum;
				switch (this.BlockNum)
				{
				case 2:
					base.GetItem(9).SetUIActive(true);
					base.GetItem(10).SetUIActive(false);
					base.GetItem(11).SetUIActive(false);
					this.ShapeBagViews[0].SetUiActive(true);
					this.ShapeBagViews[1].SetUiActive(true);
					this.ShapeBagViews[2].SetUiActive(false);
					this.ShapeBagViews[3].SetUiActive(false);
					return;
				case 3:
					base.GetItem(10).SetUIActive(true);
					base.GetItem(9).SetUIActive(false);
					base.GetItem(11).SetUIActive(false);
					this.ShapeBagViews[0].SetUiActive(true);
					this.ShapeBagViews[1].SetUiActive(true);
					this.ShapeBagViews[2].SetUiActive(true);
					this.ShapeBagViews[3].SetUiActive(false);
					return;
				case 4:
					base.GetItem(11).SetUIActive(true);
					base.GetItem(9).SetUIActive(false);
					base.GetItem(10).SetUIActive(false);
					this.ShapeBagViews[0].SetUiActive(true);
					this.ShapeBagViews[1].SetUiActive(true);
					this.ShapeBagViews[2].SetUiActive(true);
					this.ShapeBagViews[3].SetUiActive(true);
					break;
				default:
					return;
				}
			}
		}

		// Token: 0x0601D0EE RID: 119022 RVA: 0x008E14A6 File Offset: 0x008DF6A6
		public TetrisPlayController GetTetrisPlayController()
		{
			return this.TetrisPlayController;
		}

		// Token: 0x0601D0EF RID: 119023 RVA: 0x008E14B0 File Offset: 0x008DF6B0
		private void RefreshScroller([Nullable(new byte[]
		{
			1,
			2
		})] IReadOnlyList<BlockInstance> shapes)
		{
			TetrisPlayView.TetrisDragSession dragSession = this.DragSession;
			if (dragSession != null && (dragSession.CurrentHandIndex < 0 || dragSession.CurrentHandIndex >= shapes.Count || shapes[dragSession.CurrentHandIndex] != dragSession.CurrentShape))
			{
				TetrisInputController dragInputController = this.DragInputController;
				if (dragInputController != null)
				{
					dragInputController.CancelDrag(ETetrisDragCancelReason.InvalidHandShape);
				}
			}
			for (int i = 0; i < this.BlockNum; i++)
			{
				this.ShapeBagViews[i].Refresh((i < shapes.Count) ? shapes[i] : null, false, i);
			}
			this.SetShapesInteractable();
		}

		// Token: 0x0601D0F0 RID: 119024 RVA: 0x008E153D File Offset: 0x008DF73D
		private void RefreshBoard(TetrisBoardData gridModel, bool isInit, bool isTakeBack = false)
		{
			this.Board.RefreshView(gridModel, isInit, isTakeBack);
		}

		// Token: 0x0601D0F1 RID: 119025 RVA: 0x008E1550 File Offset: 0x008DF750
		private void OnAnimatingChanged(bool isAnimating)
		{
			if (!isAnimating)
			{
				TetrisPlayView.TetrisDragSession dragSession = this.DragSession;
				if (dragSession != null)
				{
					this.ResetDragHighlight();
					this.RefreshDragPosition(dragSession);
				}
			}
		}

		// Token: 0x0601D0F2 RID: 119026 RVA: 0x008E1577 File Offset: 0x008DF777
		private void OnScoreSettlementChanged()
		{
			this.RefreshCloseBtn();
		}

		// Token: 0x0601D0F3 RID: 119027 RVA: 0x008E1580 File Offset: 0x008DF780
		private void OnLogicUpdate(bool isInit = false, bool isTakeBack = false)
		{
			TetrisBoardData gridModel = this.TetrisPlayController.GetGridModel();
			List<BlockInstance> handShapes = this.TetrisPlayController.GetHandShapes();
			this.RefreshScroller(handShapes);
			this.RefreshBoard(gridModel, isInit, isTakeBack);
			this.RefreshProgress(isInit);
			TetrisPlayView.TetrisDragSession dragSession = this.DragSession;
			if (dragSession != null)
			{
				this.ResetDragHighlight();
				this.RefreshDragPosition(dragSession);
			}
		}

		// Token: 0x17002E2B RID: 11819
		// (get) Token: 0x0601D0F4 RID: 119028 RVA: 0x008E15D4 File Offset: 0x008DF7D4
		long? ITetrisDragHost.ActiveDragSessionId
		{
			get
			{
				TetrisPlayView.TetrisDragSession dragSession = this.DragSession;
				if (dragSession == null)
				{
					return null;
				}
				return new long?(dragSession.SessionId);
			}
		}

		// Token: 0x17002E2C RID: 11820
		// (get) Token: 0x0601D0F5 RID: 119029 RVA: 0x008E15FF File Offset: 0x008DF7FF
		int ITetrisDragHost.CurrentDragHandIndex
		{
			get
			{
				return this.CurrentDragIndex;
			}
		}

		// Token: 0x17002E2D RID: 11821
		// (get) Token: 0x0601D0F6 RID: 119030 RVA: 0x008E1607 File Offset: 0x008DF807
		bool ITetrisDragHost.CanHandleDragInput
		{
			get
			{
				return this.CanHandleDrag();
			}
		}

		// Token: 0x0601D0F7 RID: 119031 RVA: 0x008E160F File Offset: 0x008DF80F
		bool ITetrisDragHost.MatchesNativeDrag(long sessionId, in TetrisPointerSnapshot pointer)
		{
			return this.MatchesNativeDrag(sessionId, pointer);
		}

		// Token: 0x0601D0F8 RID: 119032 RVA: 0x008E161C File Offset: 0x008DF81C
		[NullableContext(2)]
		bool ITetrisDragHost.TryGetHitHandPointer(out TetrisPointerSnapshot pointer, out BlockInstance shape)
		{
			pointer = default(TetrisPointerSnapshot);
			shape = null;
			if (this.CanHandleDrag() && Info.Instance.IsInGamepad())
			{
				UiNavigationViewHandle dragNavigationHandle = this.GetDragNavigationHandle();
				if (dragNavigationHandle != null)
				{
					TsUiNavigationBehaviorListener tsUiNavigationBehaviorListener = dragNavigationHandle.GetGuideUiListener() ?? dragNavigationHandle.GetHitComponentListener();
					if (tsUiNavigationBehaviorListener != null && tsUiNavigationBehaviorListener.IsValid() && tsUiNavigationBehaviorListener.IsUseDrag && tsUiNavigationBehaviorListener.IsCanFocus())
					{
						TsUiNavigationPanelConfig panelConfig = tsUiNavigationBehaviorListener.PanelConfig;
						if (((panelConfig != null) ? panelConfig.ViewHandle : null) == dragNavigationHandle)
						{
							ULGUIBehaviour behaviorComponent = tsUiNavigationBehaviorListener.GetBehaviorComponent();
							if (behaviorComponent != null && behaviorComponent.IsValid())
							{
								for (int i = 0; i < this.BlockNum; i++)
								{
									TetrisShapeBagGridView tetrisShapeBagGridView = this.ShapeBagViews[i];
									if (tetrisShapeBagGridView != null && !tetrisShapeBagGridView.IsDestroyOrDestroying && tetrisShapeBagGridView.CanDrag() && tetrisShapeBagGridView.MatchesNavigationBehavior(behaviorComponent))
									{
										if (tetrisShapeBagGridView.TryCreatePointerSnapshot(0, out pointer, out shape) && shape != null)
										{
											TetrisPointerSnapshot tetrisPointerSnapshot = pointer;
											if (tetrisPointerSnapshot.InputMode == EInputControllerMainType.Gamepad && tetrisPointerSnapshot.PointerInputType == ELGUIPointerInputType.Navigation)
											{
												return this.IsValidHandShape(i, shape);
											}
										}
										return false;
									}
								}
								return false;
							}
						}
					}
					return false;
				}
			}
			return false;
		}

		// Token: 0x0601D0F9 RID: 119033 RVA: 0x008E1724 File Offset: 0x008DF924
		[NullableContext(2)]
		bool ITetrisDragHost.TryGetHandPointer(int handIndex, out TetrisPointerSnapshot pointer, out BlockInstance shape)
		{
			pointer = default(TetrisPointerSnapshot);
			shape = null;
			if (this.CanHandleDrag() && Info.Instance.IsInGamepad())
			{
				UiNavigationViewHandle dragNavigationHandle = this.GetDragNavigationHandle();
				if (dragNavigationHandle != null && handIndex >= 0 && handIndex < this.BlockNum)
				{
					TetrisShapeBagGridView tetrisShapeBagGridView = this.ShapeBagViews[handIndex];
					if (tetrisShapeBagGridView != null && !tetrisShapeBagGridView.IsDestroyOrDestroying && tetrisShapeBagGridView.CanDrag())
					{
						UUIItem rootItem = tetrisShapeBagGridView.GetRootItem();
						if (rootItem != null && tetrisShapeBagGridView.TryCreatePointerSnapshot(0, out pointer, out shape) && shape != null && this.IsValidHandShape(handIndex, shape) && pointer.PointerInputType == ELGUIPointerInputType.Navigation)
						{
							dragNavigationHandle.UpdateMousePositionByItem(rootItem);
							return tetrisShapeBagGridView.TryCreatePointerSnapshot(0, out pointer, out shape);
						}
					}
				}
			}
			return false;
		}

		// Token: 0x0601D0FA RID: 119034 RVA: 0x008E17C1 File Offset: 0x008DF9C1
		void ITetrisDragHost.SetGamepadDragging(bool isDragging)
		{
			this.IsGamepadDragging = isDragging;
			this.RefreshCloseBtn();
		}

		// Token: 0x0601D0FB RID: 119035 RVA: 0x008E17D0 File Offset: 0x008DF9D0
		[NullableContext(2)]
		bool ITetrisDragHost.TryBeginDrag(in TetrisPointerSnapshot pointer, BlockInstance shape, out long sessionId)
		{
			return this.TryBeginDrag(pointer, shape, out sessionId);
		}

		// Token: 0x0601D0FC RID: 119036 RVA: 0x008E17DB File Offset: 0x008DF9DB
		bool ITetrisDragHost.UpdateDrag(long sessionId, FVector pointerPosition)
		{
			return this.UpdateDrag(sessionId, pointerPosition);
		}

		// Token: 0x0601D0FD RID: 119037 RVA: 0x008E17E5 File Offset: 0x008DF9E5
		ETetrisDragCompleteResult ITetrisDragHost.CompleteDrag(long sessionId, FVector pointerPosition)
		{
			return this.CompleteDrag(sessionId, pointerPosition);
		}

		// Token: 0x0601D0FE RID: 119038 RVA: 0x008E17EF File Offset: 0x008DF9EF
		bool ITetrisDragHost.CancelDrag(ETetrisDragCancelReason reason, long? expectedSessionId)
		{
			return this.CancelDrag(reason, expectedSessionId);
		}

		// Token: 0x0601D0FF RID: 119039 RVA: 0x008E17F9 File Offset: 0x008DF9F9
		bool ITetrisDragHost.TryReplaceDragShape(long sessionId, int handIndex)
		{
			return this.TryReplaceDragShape(sessionId, handIndex);
		}

		// Token: 0x0601D100 RID: 119040 RVA: 0x008E1803 File Offset: 0x008DFA03
		[NullableContext(2)]
		private long OnBeginDrag(TetrisPointerSnapshot pointer, BlockInstance shapeData)
		{
			TetrisInputController dragInputController = this.DragInputController;
			if (dragInputController == null)
			{
				return 0L;
			}
			return dragInputController.OnBeginDrag(pointer, shapeData);
		}

		// Token: 0x0601D101 RID: 119041 RVA: 0x008E1819 File Offset: 0x008DFA19
		private bool OnDrag(long sessionId, TetrisPointerSnapshot pointer)
		{
			TetrisInputController dragInputController = this.DragInputController;
			return dragInputController != null && dragInputController.OnDrag(sessionId, pointer);
		}

		// Token: 0x0601D102 RID: 119042 RVA: 0x008E182E File Offset: 0x008DFA2E
		private bool OnEndDrag(long sessionId, TetrisPointerSnapshot pointer)
		{
			TetrisInputController dragInputController = this.DragInputController;
			return dragInputController != null && dragInputController.OnEndDrag(sessionId, pointer);
		}

		// Token: 0x0601D103 RID: 119043 RVA: 0x008E1843 File Offset: 0x008DFA43
		private bool OnCancelDrag(long sessionId, ETetrisDragCancelReason reason)
		{
			TetrisInputController dragInputController = this.DragInputController;
			return dragInputController != null && dragInputController.OnCancelDrag(sessionId, reason);
		}

		// Token: 0x0601D104 RID: 119044 RVA: 0x008E1858 File Offset: 0x008DFA58
		[NullableContext(2)]
		private void OnPointerDown(TetrisPointerSnapshot pointer, BlockInstance shape)
		{
			TetrisInputController dragInputController = this.DragInputController;
			if (dragInputController == null)
			{
				return;
			}
			dragInputController.OnPointerDown(pointer, shape);
		}

		// Token: 0x0601D105 RID: 119045 RVA: 0x008E186C File Offset: 0x008DFA6C
		private void OnPointerUp(TetrisPointerSnapshot pointer)
		{
			TetrisInputController dragInputController = this.DragInputController;
			if (dragInputController == null)
			{
				return;
			}
			dragInputController.OnPointerUp(pointer);
		}

		// Token: 0x0601D106 RID: 119046 RVA: 0x008E1880 File Offset: 0x008DFA80
		private bool MatchesNativeDrag(long sessionId, in TetrisPointerSnapshot pointer)
		{
			TetrisPlayView.TetrisDragSession dragSession = this.DragSession;
			return dragSession != null && dragSession.SessionId == sessionId && dragSession.InputMode == pointer.InputMode && dragSession.PointerId == pointer.PointerId && dragSession.OriginSourceId == pointer.SourceId && dragSession.OriginIndex == pointer.SourceIndex;
		}

		// Token: 0x0601D107 RID: 119047 RVA: 0x008E18DC File Offset: 0x008DFADC
		private bool CanHandleDrag()
		{
			if (base.IsShowOrShowing && !base.IsDestroyOrDestroying && base.IsUiActiveInHierarchy() && !UiModel.Instance.NormalStack.Empty && UiModel.Instance.NormalStack.Peek() == this && UiModel.Instance.GetTopView(ELayerType.Pop) == null && UiModel.Instance.GetTopView(ELayerType.Loading) == null && !ReConnectController.Instance.IsAnyNetworkReconnectViewOpen && UiModel.Instance.PlotNormalStack.Empty)
			{
				bool? windowActivationState = Application.Instance.GetWindowActivationState();
				bool flag = false;
				if (!(windowActivationState.GetValueOrDefault() == flag & windowActivationState != null))
				{
					if (Info.Instance.InputControllerMainType == EInputControllerMainType.Touch)
					{
						return true;
					}
					TsUiNavigationPanelConfig dragNavigationPanel = this.GetDragNavigationPanel();
					if (dragNavigationPanel != null && (!dragNavigationPanel.IsInActive || dragNavigationPanel.ViewHandle == null || UiNavigationViewManager.Instance.GetCurrentViewHandle() != dragNavigationPanel.ViewHandle))
					{
						return false;
					}
					string tag = (Info.Instance.InputControllerMainType == EInputControllerMainType.Gamepad) ? "UiInputRoot.Navigation" : "UiInputRoot.MouseInputTag";
					return dragNavigationPanel != null && !UiNavigationGlobalData.IsBlockNavigation && InputDistributeModel.Instance.IsTagMatchAnyCurrentInputTag(tag, false);
				}
			}
			return false;
		}

		// Token: 0x0601D108 RID: 119048 RVA: 0x008E19FC File Offset: 0x008DFBFC
		[NullableContext(2)]
		private TsUiNavigationPanelConfig GetDragNavigationPanel()
		{
			UUIButtonComponent button = base.GetButton(3);
			AActor aactor = (button != null) ? button.GetOwner() : null;
			if (aactor == null || !aactor.IsValid())
			{
				return null;
			}
			TsUiNavigationPanelConfig tsUiNavigationPanelConfig = UiNavigationLogic.FindUiNavigationPanelConfig(aactor);
			if (tsUiNavigationPanelConfig == null || !tsUiNavigationPanelConfig.IsValid())
			{
				return null;
			}
			return tsUiNavigationPanelConfig;
		}

		// Token: 0x0601D109 RID: 119049 RVA: 0x008E1A3F File Offset: 0x008DFC3F
		[NullableContext(2)]
		private UiNavigationViewHandle GetDragNavigationHandle()
		{
			TsUiNavigationPanelConfig dragNavigationPanel = this.GetDragNavigationPanel();
			if (dragNavigationPanel == null)
			{
				return null;
			}
			return dragNavigationPanel.ViewHandle;
		}

		// Token: 0x0601D10A RID: 119050 RVA: 0x008E1A54 File Offset: 0x008DFC54
		private bool IsValidHandShape(int handIndex, BlockInstance shape)
		{
			if (handIndex >= 0 && handIndex < this.BlockNum && handIndex < this.ShapeBagViews.Length && handIndex < this.TetrisPlayController.HandShapes.Count)
			{
				TetrisShapeBagGridView tetrisShapeBagGridView = this.ShapeBagViews[handIndex];
				if (tetrisShapeBagGridView != null && !tetrisShapeBagGridView.IsDestroyOrDestroying)
				{
					return this.TetrisPlayController.HandShapes[handIndex] == shape;
				}
			}
			return false;
		}

		// Token: 0x0601D10B RID: 119051 RVA: 0x008E1AB6 File Offset: 0x008DFCB6
		private static bool IsValidPointerPosition(FVector pointerPosition)
		{
			return float.IsFinite(pointerPosition.X) && float.IsFinite(pointerPosition.Y);
		}

		// Token: 0x0601D10C RID: 119052 RVA: 0x008E1AD4 File Offset: 0x008DFCD4
		[NullableContext(2)]
		private TetrisPlayView.TetrisDragSession GetDragSession(long sessionId)
		{
			TetrisPlayView.TetrisDragSession dragSession = this.DragSession;
			if (dragSession == null || dragSession.SessionId != sessionId)
			{
				return null;
			}
			if (!this.IsValidHandShape(dragSession.CurrentHandIndex, dragSession.CurrentShape))
			{
				this.CancelDrag(ETetrisDragCancelReason.InvalidHandShape, new long?(sessionId));
				return null;
			}
			if (dragSession.InputMode != Info.Instance.InputControllerMainType)
			{
				this.CancelDrag(ETetrisDragCancelReason.InputModeChanged, new long?(sessionId));
				return null;
			}
			if (!this.CanHandleDrag())
			{
				this.CancelDrag(ETetrisDragCancelReason.GameplayUnavailable, new long?(sessionId));
				return null;
			}
			return dragSession;
		}

		// Token: 0x0601D10D RID: 119053 RVA: 0x008E1B58 File Offset: 0x008DFD58
		[NullableContext(2)]
		private bool TryBeginDrag(in TetrisPointerSnapshot pointer, BlockInstance shape, out long sessionId)
		{
			sessionId = 0L;
			if (this.DragSession != null || !this.CanHandleDrag() || shape == null || pointer.InputMode == EInputControllerMainType.None || pointer.InputMode != Info.Instance.InputControllerMainType || !TetrisPlayView.IsValidPointerPosition(pointer.PointerPosition) || !this.IsValidHandShape(pointer.SourceIndex, shape) || this.ShapeBagViews[pointer.SourceIndex].ComponentId != pointer.SourceId)
			{
				return false;
			}
			long num = this.NextDragSessionId + 1L;
			this.NextDragSessionId = num;
			TetrisPlayView.TetrisDragSession tetrisDragSession = new TetrisPlayView.TetrisDragSession(num, pointer, shape);
			this.DragSession = tetrisDragSession;
			this.SetShapesInteractable();
			this.ShapeBagViews[tetrisDragSession.CurrentHandIndex].SetShapeVisible(false);
			this.ResetDragHighlight();
			this.DragItem.SetUiActive(true);
			this.DragItem.RefreshView(shape);
			if (!this.UpdateDrag(tetrisDragSession.SessionId, pointer.PointerPosition))
			{
				return false;
			}
			bool rotateActionEnabled = this.TetrisPlayController.IsRotationEnabled();
			this.SetRotateActionEnabled(rotateActionEnabled);
			this.RefreshTouchRotationButton();
			sessionId = tetrisDragSession.SessionId;
			this.ShapeBagViews[tetrisDragSession.OriginIndex].SetDragRoute(sessionId, tetrisDragSession.OriginIndex);
			return true;
		}

		// Token: 0x0601D10E RID: 119054 RVA: 0x008E1C80 File Offset: 0x008DFE80
		private bool UpdateDrag(long sessionId, FVector pointerPosition)
		{
			TetrisPlayView.TetrisDragSession dragSession = this.GetDragSession(sessionId);
			if (dragSession == null)
			{
				return false;
			}
			if (!TetrisPlayView.IsValidPointerPosition(pointerPosition))
			{
				this.CancelDrag(ETetrisDragCancelReason.InvalidPointerPosition, new long?(sessionId));
				return false;
			}
			this.CurrentDragPosition = LguiUtil.Instance.ConvertPointerPositionToLguiCenterPosition(pointerPosition);
			if (this.CurrentDragPosition.ContainsNaN())
			{
				this.CancelDrag(ETetrisDragCancelReason.InvalidPointerPosition, new long?(sessionId));
				return false;
			}
			this.RefreshDragPosition(dragSession);
			return true;
		}

		// Token: 0x0601D10F RID: 119055 RVA: 0x008E1CE8 File Offset: 0x008DFEE8
		private void RefreshDragPosition(TetrisPlayView.TetrisDragSession session)
		{
			if (this.CurrentDragPosition.ContainsNaN())
			{
				return;
			}
			UUIItem rootItem = this.DragItem.GetRootItem();
			if (rootItem != null)
			{
				rootItem.SetAnchorOffset(TetrisUtils.GetRotateCentreVector(this.CurrentDragPosition, session.CurrentShape.BoundRectWidth, session.CurrentShape.BoundRectHeight, this.CellSize.Item1, this.CellSize.Item2, session.CurrentShape.Rotation));
			}
			this.UpdateDragHighlight(this.CurrentDragPosition);
		}

		// Token: 0x0601D110 RID: 119056 RVA: 0x008E1D66 File Offset: 0x008DFF66
		private void ResetDragHighlight()
		{
			this.Board.ClearDragHighlight();
			this.LastIsRotating = false;
			this.LastDragRotation = ETetrisRotation.Origin;
			this.LastDragHighlightRowColumn = null;
		}

		// Token: 0x0601D111 RID: 119057 RVA: 0x008E1D90 File Offset: 0x008DFF90
		private void UpdateDragHighlight(FVector2D curDragPos)
		{
			if (this.CurrentDragShape == null)
			{
				return;
			}
			FVector2D rotateCentreVector = TetrisUtils.GetRotateCentreVector(curDragPos, this.CurrentDragShape.BoundRectWidth, this.CurrentDragShape.BoundRectHeight, this.CellSize.Item1, this.CellSize.Item2, this.CurrentDragShape.Rotation);
			ValueTuple<int, int>? dropTargetOffset = TetrisUtils.GetDropTargetOffset(this.CurrentDragShape, rotateCentreVector, this.CellSize.Item1, this.CellSize.Item2);
			if (this.DragItem.IsRotating == this.LastIsRotating && this.CurrentDragShape.Rotation == this.LastDragRotation && ((dropTargetOffset == null && this.LastDragHighlightRowColumn == null) || (dropTargetOffset != null && this.LastDragHighlightRowColumn != null && dropTargetOffset.Value.Equals(this.LastDragHighlightRowColumn.Value))))
			{
				return;
			}
			this.LastIsRotating = this.DragItem.IsRotating;
			this.LastDragRotation = this.CurrentDragShape.Rotation;
			this.LastDragHighlightRowColumn = ((dropTargetOffset != null) ? new ValueTuple<int, int>?(new ValueTuple<int, int>(dropTargetOffset.Value.Item1, dropTargetOffset.Value.Item2)) : null);
			this.Board.ClearDragHighlight();
			if (dropTargetOffset == null)
			{
				return;
			}
			TetrisDragItemPanel dragItem = this.DragItem;
			if (dragItem != null && dragItem.IsRotating)
			{
				return;
			}
			ValueTuple<int, int>? dropTargetOffset2 = TetrisUtils.GetDropTargetOffset(this.CurrentDragShape, rotateCentreVector, this.CellSize.Item1, this.CellSize.Item2);
			if (dropTargetOffset2 != null)
			{
				ValueTuple<int, int> valueOrDefault = dropTargetOffset2.GetValueOrDefault();
				if (this.TetrisPlayController.CanPlaceShape(this.CurrentDragShape, valueOrDefault.Item1, valueOrDefault.Item2, false))
				{
					int boundRectWidth = this.CurrentDragShape.BoundRectWidth;
					int boundRectHeight = this.CurrentDragShape.BoundRectHeight;
					List<ValueTuple<int, int>> list = new List<ValueTuple<int, int>>();
					ValueTuple<int, int>[] offsets = this.CurrentDragShape.Offsets;
					for (int i = 0; i < offsets.Length; i++)
					{
						ValueTuple<int, int> rotatedOffset = TetrisUtils.GetRotatedOffset(offsets[i], boundRectWidth, boundRectHeight, this.CurrentDragShape.Rotation);
						list.Add(new ValueTuple<int, int>(valueOrDefault.Item1 + rotatedOffset.Item1, valueOrDefault.Item2 + rotatedOffset.Item2));
					}
					ValueTuple<List<int>, List<int>> clearableRowsAndColsIfPlace = this.TetrisPlayController.GetClearableRowsAndColsIfPlace(list);
					this.Board.ShowDragHighlight(list, this.CurrentDragShape.ColorId, clearableRowsAndColsIfPlace.Item1, clearableRowsAndColsIfPlace.Item2);
				}
			}
		}

		// Token: 0x0601D112 RID: 119058 RVA: 0x008E2018 File Offset: 0x008E0218
		private ETetrisDragCompleteResult CompleteDrag(long sessionId, FVector pointerPosition)
		{
			TetrisPlayView.TetrisDragSession dragSession = this.GetDragSession(sessionId);
			if (dragSession == null)
			{
				return ETetrisDragCompleteResult.Ignored;
			}
			if (!TetrisPlayView.IsValidPointerPosition(pointerPosition))
			{
				this.CancelDrag(ETetrisDragCancelReason.InvalidPointerPosition, new long?(sessionId));
				return ETetrisDragCompleteResult.Cancelled;
			}
			int currentHandIndex = dragSession.CurrentHandIndex;
			BlockInstance currentShape = dragSession.CurrentShape;
			TetrisDragItemPanel dragItem = this.DragItem;
			bool flag = dragItem != null && dragItem.IsRotating;
			this.FinishDragSession(dragSession);
			if (this.TetrisPlayController.IsGameOver)
			{
				return ETetrisDragCompleteResult.GameOver;
			}
			if (this.IsAnimating)
			{
				return ETetrisDragCompleteResult.IsAnimating;
			}
			FVector2D dragPosition = LguiUtil.Instance.ConvertPointerPositionToLguiCenterPosition(pointerPosition);
			if (dragPosition.ContainsNaN())
			{
				return ETetrisDragCompleteResult.Cancelled;
			}
			FVector2D rotateCentreVector = TetrisUtils.GetRotateCentreVector(dragPosition, currentShape.BoundRectWidth, currentShape.BoundRectHeight, this.CellSize.Item1, this.CellSize.Item2, currentShape.Rotation);
			if (TetrisUtils.CalcBoardRawColumnByPosition(rotateCentreVector, this.CellSize.Item1, this.CellSize.Item2) == null)
			{
				return ETetrisDragCompleteResult.OutsideBoard;
			}
			if (flag)
			{
				return ETetrisDragCompleteResult.Rotating;
			}
			if (!this.CanHandleDrag() || !this.IsValidHandShape(currentHandIndex, currentShape))
			{
				return ETetrisDragCompleteResult.Cancelled;
			}
			ValueTuple<int, int>? dropTargetOffset = TetrisUtils.GetDropTargetOffset(currentShape, rotateCentreVector, this.CellSize.Item1, this.CellSize.Item2);
			if (dropTargetOffset != null)
			{
				ValueTuple<int, int> valueOrDefault = dropTargetOffset.GetValueOrDefault();
				this.TetrisPlayController.OnPlayerDropShape(currentHandIndex, valueOrDefault.Item1, valueOrDefault.Item2);
				return ETetrisDragCompleteResult.DropRequested;
			}
			return ETetrisDragCompleteResult.NoDropTarget;
		}

		// Token: 0x0601D113 RID: 119059 RVA: 0x008E216C File Offset: 0x008E036C
		private bool CancelDrag(ETetrisDragCancelReason reason, long? expectedSessionId = null)
		{
			TetrisPlayView.TetrisDragSession dragSession = this.DragSession;
			if (dragSession == null || (expectedSessionId != null && dragSession.SessionId != expectedSessionId.Value))
			{
				return false;
			}
			this.FinishDragSession(dragSession);
			return true;
		}

		// Token: 0x0601D114 RID: 119060 RVA: 0x008E21A8 File Offset: 0x008E03A8
		private void FinishDragSession(TetrisPlayView.TetrisDragSession session)
		{
			this.DragSession = null;
			this.CurrentDragPosition.Set(float.NaN, float.NaN);
			this.ResetDragHighlight();
			this.DragItem.StopRotation();
			this.SetRotateActionEnabled(false);
			this.RotationButton.SetEnabled(false);
			this.DragItem.SetUiActive(false);
			if (session.OriginIndex >= 0 && session.OriginIndex < this.ShapeBagViews.Length)
			{
				TetrisShapeBagGridView tetrisShapeBagGridView = this.ShapeBagViews[session.OriginIndex];
				if (tetrisShapeBagGridView != null && !tetrisShapeBagGridView.IsDestroy && tetrisShapeBagGridView.ComponentId == session.OriginSourceId)
				{
					tetrisShapeBagGridView.ClearDragRoute(session.SessionId);
				}
			}
			if (session.CurrentHandIndex >= 0 && session.CurrentHandIndex < this.ShapeBagViews.Length)
			{
				TetrisShapeBagGridView tetrisShapeBagGridView2 = this.ShapeBagViews[session.CurrentHandIndex];
				if (tetrisShapeBagGridView2 != null && !tetrisShapeBagGridView2.IsDestroyOrDestroying)
				{
					tetrisShapeBagGridView2.SetShapeVisible(true);
				}
			}
			this.SetShapesInteractable();
			this.RefreshCloseBtn();
		}

		// Token: 0x0601D115 RID: 119061 RVA: 0x008E2294 File Offset: 0x008E0494
		private void SetShapesInteractable()
		{
			bool interactable = this.DragSession == null;
			for (int i = 0; i < this.BlockNum; i++)
			{
				TetrisShapeBagGridView tetrisShapeBagGridView = this.ShapeBagViews[i];
				if (tetrisShapeBagGridView != null && !tetrisShapeBagGridView.IsDestroyOrDestroying)
				{
					tetrisShapeBagGridView.SetInteractable(interactable);
				}
			}
		}

		// Token: 0x0601D116 RID: 119062 RVA: 0x008E22D7 File Offset: 0x008E04D7
		private void SetRotateActionEnabled(bool enabled)
		{
			this.IsRotateActionEnabled = enabled;
			this.DragItem.SetHotkeyVisible(enabled);
		}

		// Token: 0x0601D117 RID: 119063 RVA: 0x008E22EC File Offset: 0x008E04EC
		private bool TryReplaceDragShape(long sessionId, int index)
		{
			TetrisPlayView.TetrisDragSession dragSession = this.GetDragSession(sessionId);
			if (dragSession != null && index >= 0 && index < this.BlockNum && index < this.TetrisPlayController.HandShapes.Count)
			{
				BlockInstance blockInstance = this.TetrisPlayController.HandShapes[index];
				if (blockInstance != null && this.IsValidHandShape(index, blockInstance))
				{
					if (dragSession.CurrentHandIndex == index)
					{
						return true;
					}
					this.ShapeBagViews[dragSession.CurrentHandIndex].SetShapeVisible(true);
					this.ShapeBagViews[index].SetShapeVisible(false);
					dragSession.CurrentHandIndex = index;
					dragSession.CurrentShape = blockInstance;
					this.DragItem.StopRotation();
					this.DragItem.RefreshView(blockInstance);
					this.ResetDragHighlight();
					this.RefreshDragPosition(dragSession);
					return true;
				}
			}
			return false;
		}

		// Token: 0x0601D118 RID: 119064 RVA: 0x008E23A4 File Offset: 0x008E05A4
		private TetrisGemProgressGrid UpdateProgressItem()
		{
			return new TetrisGemProgressGrid();
		}

		// Token: 0x0601D119 RID: 119065 RVA: 0x008E23AC File Offset: 0x008E05AC
		private void RefreshProgress(bool isInit = false)
		{
			switch (this.TetrisPlayController.GetGameMode())
			{
			case EGameMode.Score:
				this.RefreshScore();
				return;
			case EGameMode.GemCollection:
				this.RefreshGem();
				return;
			case EGameMode.Infinite:
				this.RefreshInfinite();
				if (isInit)
				{
					if (this.TetrisPlayController.IsActivityLevel())
					{
						int num;
						if (this.TetrisPlayController.GetCurrentTarget().TryGetValue(0, out num) && (this.TetrisPlayController.GetHighestScore().GetValueOrDefault() < (long)num || this.TetrisPlayController.HasPendingFirstTimeRewards))
						{
							this.RewardTipPanel.SetUiActive(true);
							this.RewardTipPanel.SetTargetText(num);
							return;
						}
						this.RewardTipPanel.SetUiActive(false);
						return;
					}
					else
					{
						this.RewardTipPanel.SetUiActive(false);
					}
				}
				return;
			default:
				return;
			}
		}

		// Token: 0x0601D11A RID: 119066 RVA: 0x008E246C File Offset: 0x008E066C
		private void RefreshInfinite()
		{
			this.ScoreProgressItem.SetUiActive(true);
			long? highestScore = this.TetrisPlayController.GetHighestScore();
			UUIItem item = base.GetItem(15);
			if (item != null)
			{
				item.SetUIActive(highestScore != null);
			}
			if (highestScore != null)
			{
				UUIText text = base.GetText(14);
				if (text != null)
				{
					text.SetText(highestScore.Value.ToString(), true);
				}
			}
			this.ScoreProgressItem.RefreshInfinite(this.TetrisPlayController.GetCurrentScore(), this.TetrisPlayController.GetHighestScore());
			if (this.TetrisPlayController.IsActivityLevel())
			{
				this.RewardTipPanel.SetTargetCompleted(this.TetrisPlayController.IsAllTargetsCompleted(true));
			}
		}

		// Token: 0x0601D11B RID: 119067 RVA: 0x008E251C File Offset: 0x008E071C
		private void RefreshScore()
		{
			this.ScoreProgressItem.SetUiActive(true);
			int targetScore;
			this.TetrisPlayController.GetCurrentTarget().TryGetValue(0, out targetScore);
			this.ScoreProgressItem.Refresh(this.TetrisPlayController.GetCurrentScore(), targetScore);
		}

		// Token: 0x0601D11C RID: 119068 RVA: 0x008E2560 File Offset: 0x008E0760
		private void RefreshGem()
		{
			Dictionary<int, int> currentTarget = this.TetrisPlayController.GetCurrentTarget();
			if (currentTarget.Count == 0)
			{
				return;
			}
			List<TetrisGemProgressData> list = new List<TetrisGemProgressData>();
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

		// Token: 0x0601D11D RID: 119069 RVA: 0x008E2610 File Offset: 0x008E0810
		private void OnBeforeOpenPopup()
		{
			TetrisInputController dragInputController = this.DragInputController;
			if (dragInputController == null)
			{
				return;
			}
			dragInputController.CancelDrag(ETetrisDragCancelReason.InputOwnershipLost);
		}

		// Token: 0x0601D11E RID: 119070 RVA: 0x008E2624 File Offset: 0x008E0824
		private void OnClickedCloseButton()
		{
			if (this.TetrisPlayController.IsSettlingScore)
			{
				return;
			}
			this.OnBeforeOpenPopup();
			bool flag = this.TetrisPlayController.GetGameMode() == EGameMode.Infinite && this.TetrisPlayController.IsActivityLevel();
			ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(flag ? EConfirmBoxConfigId.TetrisEndlessQuitConfirm : EConfirmBoxConfigId.TetrisQuitConfirm)
			{
				IsEscViewTriggerCallBack = false
			};
			confirmBoxDataNew.FunctionMap.Add(1, new Action(this.<OnClickedCloseButton>g__cancelCallback|106_0));
			confirmBoxDataNew.FunctionMap.Add(2, new Action(this.<OnClickedCloseButton>g__confirmCallback|106_1));
			if (flag)
			{
				confirmBoxDataNew.TextArgs = new string[]
				{
					this.TetrisPlayController.GetCurrentScore().ToString()
				};
			}
			ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
		}

		// Token: 0x0601D11F RID: 119071 RVA: 0x008E26E0 File Offset: 0x008E08E0
		private void OnClickHelpBtn()
		{
			this.OnBeforeOpenPopup();
			HelpController.Instance.OpenHelpById(this.TetrisPlayController.GetCurrentConfig().Value.HelpId);
		}

		// Token: 0x0601D120 RID: 119072 RVA: 0x008E2718 File Offset: 0x008E0918
		private void OnClickRotationButton()
		{
			TetrisInputController dragInputController = this.DragInputController;
			if (dragInputController == null || !dragInputController.CanRouteInput)
			{
				return;
			}
			if (this.IsRotateActionEnabled && this.TetrisPlayController.IsRotationEnabled())
			{
				TetrisPlayView.TetrisDragSession dragSession = this.DragSession;
				if (dragSession != null)
				{
					TetrisPlayView.TetrisDragSession dragSession2 = this.GetDragSession(dragSession.SessionId);
					if (dragSession2 != null)
					{
						TetrisDragItemPanel dragItem = this.DragItem;
						if (dragItem != null && !dragItem.IsRotating)
						{
							dragSession2.CurrentShape.Rotate();
							this.TetrisPlayController.RecordRotation(dragSession2.CurrentHandIndex);
							this.Board.ClearDragHighlight();
							this.DragItem.StartRotation(dragSession2.CurrentShape);
							AudioSystem.Instance.PostEvent("play_ui_cube_spin_click");
						}
					}
				}
			}
		}

		// Token: 0x0601D121 RID: 119073 RVA: 0x008E27CC File Offset: 0x008E09CC
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
				List<TetrisGridPanel> gridPool = this.GridPool;
				TetrisGridPanel tetrisGridPanel = gridPool[gridPool.Count - 1];
				this.GridPool.RemoveAt(this.GridPool.Count - 1);
				tetrisGridPanel.GetRootItem().K2_AttachToComponent(poolContainer, null, EAttachmentRule.KeepRelative, EAttachmentRule.KeepRelative, EAttachmentRule.KeepRelative, false, true);
				return new ValueTuple<TetrisGridPanel, bool>(tetrisGridPanel, false);
			}
			return new ValueTuple<TetrisGridPanel, bool>(new TetrisGridPanel(0, 0), true);
		}

		// Token: 0x0601D122 RID: 119074 RVA: 0x008E2840 File Offset: 0x008E0A40
		public void ReturnGrid(TetrisGridPanel grid)
		{
			if (grid.IsDestroyOrDestroying || grid.WaitToDestroy)
			{
				return;
			}
			if (!base.IsDestroyOrDestroying && !this.WaitToDestroy)
			{
				UUIItem poolContainer = this.PoolContainer;
				if (poolContainer != null && poolContainer.IsValid())
				{
					UUIItem rootItem = grid.GetRootItem();
					if (rootItem != null && rootItem.IsValid())
					{
						grid.SetUiActive(false);
						rootItem.K2_AttachToComponent(this.PoolContainer, null, EAttachmentRule.KeepRelative, EAttachmentRule.KeepRelative, EAttachmentRule.KeepRelative, false, true);
						this.GridPool.Add(grid);
						return;
					}
				}
			}
			grid.Destroy(null);
		}

		// Token: 0x0601D123 RID: 119075 RVA: 0x008E28CC File Offset: 0x008E0ACC
		public void TetrisRewardClose()
		{
			base.CloseMe(null);
			if (TetrisUtils.IsHardLevel(this.TetrisPlayController.GetCurrentConfig().Value) || TetrisUtils.IsActivityEggLevel(this.TetrisPlayController.GetCurrentConfig().Value))
			{
				UiManager.Instance.CloseView(EUiViewName.TetrisLevelDetailView, null);
			}
		}

		// Token: 0x0601D124 RID: 119076 RVA: 0x008E2924 File Offset: 0x008E0B24
		public void RefreshCloseBtn()
		{
			this.CaptionItem.SetCloseBtnActive(this.ShouldShowCloseButton);
		}

		// Token: 0x0601D125 RID: 119077 RVA: 0x008E2937 File Offset: 0x008E0B37
		protected override void OnBeforeHide()
		{
			TetrisInputController dragInputController = this.DragInputController;
			if (dragInputController == null)
			{
				return;
			}
			dragInputController.Stop(ETetrisDragCancelReason.ViewHidden);
		}

		// Token: 0x0601D126 RID: 119078 RVA: 0x008E294C File Offset: 0x008E0B4C
		protected override void OnBeforeDestroy()
		{
			this.SetRotateActionEnabled(false);
			if (this.TetrisPlayController != null)
			{
				this.TetrisPlayController.ClearCallback();
				this.TetrisPlayController = null;
			}
			if (this.DragInputController != null)
			{
				this.DragInputController.Stop(ETetrisDragCancelReason.ViewDestroyed);
				this.DragInputController = null;
			}
			if (this.Board != null)
			{
				this.Board.Destroy(null);
				this.Board = null;
			}
			if (this.DragItem != null)
			{
				this.DragItem.OnRotationFinished = null;
				this.DragItem.StopRotation();
				this.DragItem.Destroy(null);
				this.DragItem = null;
			}
			if (this.ScoreProgressItem != null)
			{
				this.ScoreProgressItem.Destroy(null);
				this.ScoreProgressItem = null;
			}
			if (this.ComboPanel != null)
			{
				this.ComboPanel.Destroy(null);
				this.ComboPanel = null;
			}
			if (this.RewardTipPanel != null)
			{
				this.RewardTipPanel.Destroy(null);
				this.RewardTipPanel = null;
			}
			if (this.RotationButton != null)
			{
				this.RotationButton.Destroy(null);
				this.RotationButton = null;
			}
			foreach (TetrisGridPanel tetrisGridPanel in this.GridPool)
			{
				tetrisGridPanel.Destroy(null);
			}
			this.GridPool.Clear();
			this.PoolContainer = null;
		}

		// Token: 0x0601D127 RID: 119079 RVA: 0x008E2AA8 File Offset: 0x008E0CA8
		private void OnInputControllerMainTypeChange(EInputControllerMainType last, EInputControllerMainType now)
		{
			TetrisInputController dragInputController = this.DragInputController;
			if (dragInputController != null)
			{
				dragInputController.OnInputControllerMainTypeChange(now);
			}
			this.RefreshTouchRotationButton();
		}

		// Token: 0x0601D128 RID: 119080 RVA: 0x008E2AC4 File Offset: 0x008E0CC4
		private void OnActivityClose(IReadOnlySet<int> closeActivities)
		{
			if (!TetrisUtils.IsActivityLevel(this.TetrisPlayController.GetCurrentConfig().Value))
			{
				return;
			}
			if (closeActivities.Contains(ActivityTetrisController.Instance.ActivityId))
			{
				TetrisInputController dragInputController = this.DragInputController;
				if (dragInputController != null)
				{
					dragInputController.CancelDrag(ETetrisDragCancelReason.GameplayUnavailable);
				}
				ActivityController.Instance.ShowActivityRefreshAndBackToBattleView();
			}
		}

		// Token: 0x0601D129 RID: 119081 RVA: 0x008E2B1A File Offset: 0x008E0D1A
		private void OnTetrisRotate()
		{
			this.OnClickRotationButton();
		}

		// Token: 0x0601D12A RID: 119082 RVA: 0x008E2B22 File Offset: 0x008E0D22
		private void OnTetrisPickShape(int index)
		{
			TetrisInputController dragInputController = this.DragInputController;
			if (dragInputController == null)
			{
				return;
			}
			dragInputController.OnPickShape(index);
		}

		// Token: 0x0601D12B RID: 119083 RVA: 0x008E2B38 File Offset: 0x008E0D38
		public void OpenLoseConfirm()
		{
			this.OnBeforeOpenPopup();
			ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew((this.TetrisPlayController.GetGameMode() == EGameMode.Infinite) ? EConfirmBoxConfigId.TetrisEndlessLoseConfirm : EConfirmBoxConfigId.TetrisLoseConfirm);
			confirmBoxDataNew.FunctionMap.Add(1, new Action(this.<OpenLoseConfirm>g__cancelCallback|119_0));
			confirmBoxDataNew.FunctionMap.Add(2, new Action(this.<OpenLoseConfirm>g__confirmCallback|119_1));
			ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
		}

		// Token: 0x0601D12C RID: 119084 RVA: 0x008E2BA8 File Offset: 0x008E0DA8
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
				TetrisBoardGridPanel gridPanel = this.Board.GetGridPanel(row, column);
				UUIItem uuiitem = (gridPanel != null) ? gridPanel.GetRootItem() : null;
				if (uuiitem == null)
				{
					return null;
				}
				return new UUIItem[]
				{
					uuiitem,
					uuiitem
				};
			}
			else
			{
				if (!(a == "Shape"))
				{
					return null;
				}
				int num = int.Parse(configParams[1]);
				UUIItem rootItem = this.ShapeBagViews[num].GetRootItem();
				if (rootItem == null)
				{
					return null;
				}
				return new UUIItem[]
				{
					rootItem,
					rootItem
				};
			}
		}

		// Token: 0x0601D12D RID: 119085 RVA: 0x008E2C48 File Offset: 0x008E0E48
		protected override void OnTick(float delta)
		{
			TetrisInputController dragInputController = this.DragInputController;
			if (dragInputController != null)
			{
				dragInputController.OnTick(delta);
			}
			TetrisPlayView.TetrisDragSession dragSession = this.DragSession;
			if (dragSession != null)
			{
				this.GetDragSession(dragSession.SessionId);
			}
			this.DragItem.HandleRotation(delta, this.CurrentDragPosition);
		}

		// Token: 0x0601D12E RID: 119086 RVA: 0x008E2C90 File Offset: 0x008E0E90
		private void OnRotationFinished()
		{
			if (!this.CurrentDragPosition.ContainsNaN())
			{
				this.UpdateDragHighlight(this.CurrentDragPosition);
			}
		}

		// Token: 0x0601D12F RID: 119087 RVA: 0x008E2CAB File Offset: 0x008E0EAB
		private void ResetLevel()
		{
			if (base.IsDestroyOrDestroying || this.WaitToDestroy)
			{
				return;
			}
			TetrisInputController dragInputController = this.DragInputController;
			if (dragInputController != null)
			{
				dragInputController.CancelDrag(ETetrisDragCancelReason.InvalidHandShape);
			}
			this.TetrisPlayController.DoResetTetris();
		}

		// Token: 0x0601D130 RID: 119088 RVA: 0x008E2CDB File Offset: 0x008E0EDB
		private void QuitLevel()
		{
			this.TetrisPlayController.TryShowPendingFirstTimeRewards(delegate
			{
				base.CloseMe(null);
			});
		}

		// Token: 0x0601D131 RID: 119089 RVA: 0x008E2CF4 File Offset: 0x008E0EF4
		private void QuitEndlessLevel()
		{
			this.TetrisPlayController.QuitEndlessLevel();
		}

		// Token: 0x0601D132 RID: 119090 RVA: 0x008E2D01 File Offset: 0x008E0F01
		[CompilerGenerated]
		private void <OnClickedCloseButton>g__cancelCallback|106_0()
		{
			if (this.TetrisPlayController.GetGameMode() == EGameMode.Infinite)
			{
				this.TetrisPlayController.SendInfiniteFinishRequest(new Action(this.ResetLevel));
				return;
			}
			this.ResetLevel();
		}

		// Token: 0x0601D133 RID: 119091 RVA: 0x008E2D2F File Offset: 0x008E0F2F
		[CompilerGenerated]
		private void <OnClickedCloseButton>g__confirmCallback|106_1()
		{
			if (this.TetrisPlayController.GetGameMode() == EGameMode.Infinite)
			{
				this.TetrisPlayController.SendInfiniteFinishRequest(new Action(this.QuitEndlessLevel));
			}
			else
			{
				this.QuitLevel();
			}
			this.TetrisPlayController.SendResultLogData(2);
		}

		// Token: 0x0601D134 RID: 119092 RVA: 0x008E2D6A File Offset: 0x008E0F6A
		[CompilerGenerated]
		private void <OpenLoseConfirm>g__cancelCallback|119_0()
		{
			this.QuitLevel();
			this.TetrisPlayController.SendResultLogData(0);
		}

		// Token: 0x0601D135 RID: 119093 RVA: 0x008E2D7E File Offset: 0x008E0F7E
		[CompilerGenerated]
		private void <OpenLoseConfirm>g__confirmCallback|119_1()
		{
			this.TetrisPlayController.OnLoseReset();
		}

		// Token: 0x0400F4E5 RID: 62693
		private PopupCaptionItem CaptionItem;

		// Token: 0x0400F4E6 RID: 62694
		private GenericLayout<TetrisGemProgressGrid, TetrisGemProgressData> GemProgressList;

		// Token: 0x0400F4E7 RID: 62695
		private TetrisDragItemPanel DragItem;

		// Token: 0x0400F4E8 RID: 62696
		private TetrisBoardPanel Board;

		// Token: 0x0400F4E9 RID: 62697
		private TetrisComboPanel ComboPanel;

		// Token: 0x0400F4EA RID: 62698
		private TetrisScoreProgressPanel ScoreProgressItem;

		// Token: 0x0400F4EB RID: 62699
		private TetrisRewardTipPanel RewardTipPanel;

		// Token: 0x0400F4EC RID: 62700
		private TetrisRotationButton RotationButton;

		// Token: 0x0400F4ED RID: 62701
		[TupleElementNames(new string[]
		{
			"Width",
			"Height"
		})]
		[Nullable(0)]
		private ValueTuple<float, float> CellSize;

		// Token: 0x0400F4EE RID: 62702
		private TetrisPlayController TetrisPlayController;

		// Token: 0x0400F4EF RID: 62703
		private int Param;

		// Token: 0x0400F4F0 RID: 62704
		private bool IsFirstShow = true;

		// Token: 0x0400F4F1 RID: 62705
		[Nullable(2)]
		private TetrisPlayView.TetrisDragSession DragSession;

		// Token: 0x0400F4F2 RID: 62706
		private long NextDragSessionId;

		// Token: 0x0400F4F3 RID: 62707
		[Nullable(2)]
		private TetrisInputController DragInputController;

		// Token: 0x0400F4F4 RID: 62708
		private FVector2D CurrentDragPosition = new FVector2D(float.NaN, float.NaN);

		// Token: 0x0400F4F5 RID: 62709
		private bool LastIsRotating;

		// Token: 0x0400F4F6 RID: 62710
		private ETetrisRotation LastDragRotation;

		// Token: 0x0400F4F7 RID: 62711
		[TupleElementNames(new string[]
		{
			"Row",
			"Column"
		})]
		[Nullable(0)]
		private ValueTuple<int, int>? LastDragHighlightRowColumn;

		// Token: 0x0400F4F8 RID: 62712
		private bool IsRotateActionEnabled;

		// Token: 0x0400F4F9 RID: 62713
		private bool IsGamepadDragging;

		// Token: 0x0400F4FA RID: 62714
		private readonly TetrisShapeBagGridView[] ShapeBagViews = new TetrisShapeBagGridView[4];

		// Token: 0x0400F4FB RID: 62715
		private int BlockNum;

		// Token: 0x0400F4FC RID: 62716
		private readonly List<TetrisGridPanel> GridPool = new List<TetrisGridPanel>();

		// Token: 0x0400F4FD RID: 62717
		[Nullable(2)]
		private UUIItem PoolContainer;

		// Token: 0x02008C54 RID: 35924
		[NullableContext(0)]
		private static class EComponents
		{
			// Token: 0x0402C698 RID: 181912
			public const int Caption = 0;

			// Token: 0x0402C699 RID: 181913
			public const int LeftMenu = 1;

			// Token: 0x0402C69A RID: 181914
			public const int ShapeContainerItem = 2;

			// Token: 0x0402C69B RID: 181915
			public const int ShapeItem1 = 3;

			// Token: 0x0402C69C RID: 181916
			public const int MapItem = 4;

			// Token: 0x0402C69D RID: 181917
			public const int MapGridItem = 5;

			// Token: 0x0402C69E RID: 181918
			public const int AttachFinish = 6;

			// Token: 0x0402C69F RID: 181919
			public const int Attach = 7;

			// Token: 0x0402C6A0 RID: 181920
			public const int DragShape = 8;

			// Token: 0x0402C6A1 RID: 181921
			public const int Count2 = 9;

			// Token: 0x0402C6A2 RID: 181922
			public const int Count3 = 10;

			// Token: 0x0402C6A3 RID: 181923
			public const int Count4 = 11;

			// Token: 0x0402C6A4 RID: 181924
			public const int BarList = 12;

			// Token: 0x0402C6A5 RID: 181925
			public const int ProgressItem = 13;

			// Token: 0x0402C6A6 RID: 181926
			public const int HighestScoreTxt = 14;

			// Token: 0x0402C6A7 RID: 181927
			public const int HighestScoreItem = 15;

			// Token: 0x0402C6A8 RID: 181928
			public const int ComboPanel = 16;

			// Token: 0x0402C6A9 RID: 181929
			public const int PnlRewardTip = 17;

			// Token: 0x0402C6AA RID: 181930
			public const int BtnRotation = 18;

			// Token: 0x0402C6AB RID: 181931
			public const int ShapeItem2 = 19;

			// Token: 0x0402C6AC RID: 181932
			public const int ShapeItem3 = 20;

			// Token: 0x0402C6AD RID: 181933
			public const int ShapeItem4 = 21;
		}

		// Token: 0x02008C55 RID: 35925
		[Nullable(0)]
		private sealed class TetrisDragSession
		{
			// Token: 0x06042CE6 RID: 273638 RVA: 0x013DED2C File Offset: 0x013DCF2C
			public TetrisDragSession(long sessionId, TetrisPointerSnapshot pointer, BlockInstance shape)
			{
			}

			// Token: 0x170078D5 RID: 30933
			// (get) Token: 0x06042CE7 RID: 273639 RVA: 0x013DED8E File Offset: 0x013DCF8E
			public long SessionId { get; } = sessionId;

			// Token: 0x170078D6 RID: 30934
			// (get) Token: 0x06042CE8 RID: 273640 RVA: 0x013DED96 File Offset: 0x013DCF96
			public EInputControllerMainType InputMode { get; } = pointer.InputMode;

			// Token: 0x170078D7 RID: 30935
			// (get) Token: 0x06042CE9 RID: 273641 RVA: 0x013DED9E File Offset: 0x013DCF9E
			public int PointerId { get; } = pointer.PointerId;

			// Token: 0x170078D8 RID: 30936
			// (get) Token: 0x06042CEA RID: 273642 RVA: 0x013DEDA6 File Offset: 0x013DCFA6
			public int OriginSourceId { get; } = pointer.SourceId;

			// Token: 0x170078D9 RID: 30937
			// (get) Token: 0x06042CEB RID: 273643 RVA: 0x013DEDAE File Offset: 0x013DCFAE
			public int OriginIndex { get; } = pointer.SourceIndex;

			// Token: 0x170078DA RID: 30938
			// (get) Token: 0x06042CEC RID: 273644 RVA: 0x013DEDB6 File Offset: 0x013DCFB6
			// (set) Token: 0x06042CED RID: 273645 RVA: 0x013DEDBE File Offset: 0x013DCFBE
			public int CurrentHandIndex { get; set; } = pointer.SourceIndex;

			// Token: 0x170078DB RID: 30939
			// (get) Token: 0x06042CEE RID: 273646 RVA: 0x013DEDC7 File Offset: 0x013DCFC7
			// (set) Token: 0x06042CEF RID: 273647 RVA: 0x013DEDCF File Offset: 0x013DCFCF
			public BlockInstance CurrentShape { get; set; } = shape;
		}
	}
}
