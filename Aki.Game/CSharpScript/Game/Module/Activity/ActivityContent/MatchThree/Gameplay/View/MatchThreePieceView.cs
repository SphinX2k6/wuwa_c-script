using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay.Core;
using CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay.Core.Components;
using CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay.Jobs;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay.View
{
	// Token: 0x020064E0 RID: 25824
	[NullableContext(1)]
	[Nullable(0)]
	public class MatchThreePieceView : UiPanelBase
	{
		// Token: 0x170094DC RID: 38108
		// (get) Token: 0x06040D02 RID: 265474 RVA: 0x00FB2BCA File Offset: 0x00FB0DCA
		// (set) Token: 0x06040D03 RID: 265475 RVA: 0x00FB2BD2 File Offset: 0x00FB0DD2
		public EPieceType Type { get; private set; }

		// Token: 0x170094DD RID: 38109
		// (get) Token: 0x06040D04 RID: 265476 RVA: 0x00FB2BDB File Offset: 0x00FB0DDB
		// (set) Token: 0x06040D05 RID: 265477 RVA: 0x00FB2BE3 File Offset: 0x00FB0DE3
		public string PrefabId { get; private set; } = string.Empty;

		// Token: 0x06040D06 RID: 265478 RVA: 0x00FB2BEC File Offset: 0x00FB0DEC
		public static float FallFlightDuration(float arcLength, float cellStepY)
		{
			float val = (cellStepY <= 0f) ? 1f : (arcLength / cellStepY);
			return 0.13f * (float)Math.Sqrt((double)Math.Max(val, 1f));
		}

		// Token: 0x06040D07 RID: 265479 RVA: 0x00FB2C24 File Offset: 0x00FB0E24
		[NullableContext(2)]
		public void SetFallCurve(UCurveFloat curve, float startTime, float landTime, float endTime)
		{
			this.FallCurve = curve;
			this.FallCurveStart = startTime;
			this.FallCurveLand = landTime;
			this.FallCurveEnd = endTime;
		}

		// Token: 0x06040D08 RID: 265480 RVA: 0x00FB2C44 File Offset: 0x00FB0E44
		protected unsafe override void OnRegisterComponent()
		{
			int num = 6;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06040D09 RID: 265481 RVA: 0x00FB2D34 File Offset: 0x00FB0F34
		private void ResetPieceShellVisualState()
		{
			UUIItem item = base.GetItem(1);
			if (item != null)
			{
				item.SetAlpha(1f);
			}
			UUIItem item2 = base.GetItem(2);
			if (item2 != null)
			{
				item2.SetAlpha(1f);
			}
			UUIItem item3 = base.GetItem(3);
			if (item3 != null)
			{
				item3.SetAlpha(1f);
			}
			UUIItem item4 = base.GetItem(4);
			if (item4 != null)
			{
				item4.SetAlpha(0f);
			}
			UUIItem item5 = base.GetItem(5);
			if (item5 == null)
			{
				return;
			}
			item5.SetUIActive(false);
		}

		// Token: 0x06040D0A RID: 265482 RVA: 0x00FB2DAF File Offset: 0x00FB0FAF
		private void ResetVisualState()
		{
			this.ResetPieceShellVisualState();
			MatchThreePieceItemView itemView = this.ItemView;
			if (itemView == null)
			{
				return;
			}
			itemView.ResetVisualState();
		}

		// Token: 0x06040D0B RID: 265483 RVA: 0x00FB2DC7 File Offset: 0x00FB0FC7
		public void BindData(GridPosition pos, EPieceType type, bool skipInitialVisualReset = false)
		{
			this.Pos = pos;
			this.Type = type;
			this.SkipInitialVisualReset = skipInitialVisualReset;
		}

		// Token: 0x06040D0C RID: 265484 RVA: 0x00FB2DDE File Offset: 0x00FB0FDE
		public void BindCellStep(float stepX, float stepY)
		{
			this.CellStepX = stepX;
			this.CellStepY = stepY;
		}

		// Token: 0x06040D0D RID: 265485 RVA: 0x00FB2DEE File Offset: 0x00FB0FEE
		public void BindInput(Action<GridPosition> pressed, Action<GridPosition> entered, Action released)
		{
			this.PressedCallback = pressed;
			this.EnteredCallback = entered;
			this.ReleasedCallback = released;
		}

		// Token: 0x06040D0E RID: 265486 RVA: 0x00FB2E08 File Offset: 0x00FB1008
		protected override UniTask OnBeforeStartAsync()
		{
			MatchThreePieceView.<OnBeforeStartAsync>d__51 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<MatchThreePieceView.<OnBeforeStartAsync>d__51>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06040D0F RID: 265487 RVA: 0x00FB2E4B File Offset: 0x00FB104B
		public void StartHint()
		{
			if (this.Hinting)
			{
				return;
			}
			this.Hinting = true;
			this.PlayHintOnce();
		}

		// Token: 0x06040D10 RID: 265488 RVA: 0x00FB2E63 File Offset: 0x00FB1063
		public void StopHint()
		{
			if (!this.Hinting)
			{
				return;
			}
			this.Hinting = false;
			UiSequencePlayer sequencePlayer = this.SequencePlayer;
			if (sequencePlayer == null)
			{
				return;
			}
			sequencePlayer.StopSequenceByKey("Tip", false, true);
		}

		// Token: 0x06040D11 RID: 265489 RVA: 0x00FB2E8C File Offset: 0x00FB108C
		private void PlayHintOnce()
		{
			this.PlayingHint = true;
			UiSequencePlayer sequencePlayer = this.SequencePlayer;
			if (sequencePlayer != null)
			{
				sequencePlayer.PlaySequencePurely("Tip", false, false);
			}
			this.PlayingHint = false;
		}

		// Token: 0x06040D12 RID: 265490 RVA: 0x00FB2EB4 File Offset: 0x00FB10B4
		private void OnSequenceEnd(string sequenceName)
		{
			if (!this.Hinting || sequenceName != "Tip")
			{
				return;
			}
			if (this.PlayingHint)
			{
				this.Hinting = false;
				Log instance = Log.Instance;
				ELogModule module = ELogModule.MatchThree;
				ELogAuthor author = ELogAuthor.CB;
				string message = "[StartHint] 棋子单元模板上没配 Tip 序列，交换提示不播";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Type", this.Type);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			this.PlayHintOnce();
		}

		// Token: 0x06040D13 RID: 265491 RVA: 0x00FB2F24 File Offset: 0x00FB1124
		private void BindButtonInput()
		{
			UUIButtonComponent button = base.GetButton(0);
			if (button == null || !button.IsValid())
			{
				return;
			}
			button.OnPointDownCallBack.Bind(new Action(this.OnPointDown));
			button.OnPointEnterCallBack.Bind(new Action(this.OnPointEnter));
			button.OnPointUpCallBack.Bind(new Action(this.OnPointUp));
			button.OnPointCancelCallBack.Bind(new Action(this.OnPointUp));
		}

		// Token: 0x06040D14 RID: 265492 RVA: 0x00FB2FA7 File Offset: 0x00FB11A7
		private void OnPointDown()
		{
			Action<GridPosition> pressedCallback = this.PressedCallback;
			if (pressedCallback == null)
			{
				return;
			}
			pressedCallback(this.Pos);
		}

		// Token: 0x06040D15 RID: 265493 RVA: 0x00FB2FBF File Offset: 0x00FB11BF
		private void OnPointEnter()
		{
			Action<GridPosition> enteredCallback = this.EnteredCallback;
			if (enteredCallback == null)
			{
				return;
			}
			enteredCallback(this.Pos);
		}

		// Token: 0x06040D16 RID: 265494 RVA: 0x00FB2FD7 File Offset: 0x00FB11D7
		private void OnPointUp()
		{
			Action releasedCallback = this.ReleasedCallback;
			if (releasedCallback == null)
			{
				return;
			}
			releasedCallback();
		}

		// Token: 0x06040D17 RID: 265495 RVA: 0x00FB2FE9 File Offset: 0x00FB11E9
		public void SetLocationByRowCol(int row, int col)
		{
			UUIItem rootItem = this.RootItem;
			if (rootItem == null)
			{
				return;
			}
			rootItem.SetAnchorOffset(new FVector2D((float)col * this.CellStepX, (float)(-(float)row) * this.CellStepY));
		}

		// Token: 0x06040D18 RID: 265496 RVA: 0x00FB3013 File Offset: 0x00FB1213
		public void SetType(EPieceType type)
		{
			this.Type = type;
			this.RefreshAppearance();
		}

		// Token: 0x06040D19 RID: 265497 RVA: 0x00FB3022 File Offset: 0x00FB1222
		public UniTask SetTypeAsync(EPieceType type)
		{
			this.Type = type;
			return this.RefreshAppearanceAsync(false);
		}

		// Token: 0x06040D1A RID: 265498 RVA: 0x00FB3032 File Offset: 0x00FB1232
		private UniTask SetTypeForBoardRefreshAsync(EPieceType type)
		{
			this.Type = type;
			return this.RefreshAppearanceAsync(true);
		}

		// Token: 0x06040D1B RID: 265499 RVA: 0x00FB3044 File Offset: 0x00FB1244
		public void ResetForReuse(GridPosition pos, EPieceType type)
		{
			this.KillTween();
			this.StopHint();
			this.Pos = pos;
			this.Type = type;
			this.SetLocationByRowCol(pos.Row, pos.Col);
			this.RefreshAppearance();
			UUIItem rootItem = this.RootItem;
			if (rootItem != null)
			{
				rootItem.SetUIActive(true);
			}
			this.SetPieceContentVisible(true);
			this.ResetVisualState();
		}

		// Token: 0x06040D1C RID: 265500 RVA: 0x00FB30A4 File Offset: 0x00FB12A4
		public UniTask ResetForBoardRefreshAsync(GridPosition pos, EPieceType type)
		{
			MatchThreePieceView.<ResetForBoardRefreshAsync>d__70 <ResetForBoardRefreshAsync>d__;
			<ResetForBoardRefreshAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<ResetForBoardRefreshAsync>d__.<>4__this = this;
			<ResetForBoardRefreshAsync>d__.pos = pos;
			<ResetForBoardRefreshAsync>d__.type = type;
			<ResetForBoardRefreshAsync>d__.<>1__state = -1;
			<ResetForBoardRefreshAsync>d__.<>t__builder.Start<MatchThreePieceView.<ResetForBoardRefreshAsync>d__70>(ref <ResetForBoardRefreshAsync>d__);
			return <ResetForBoardRefreshAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06040D1D RID: 265501 RVA: 0x00FB30F7 File Offset: 0x00FB12F7
		public void SetVisible(bool visible)
		{
			UUIItem rootItem = this.RootItem;
			if (rootItem == null)
			{
				return;
			}
			rootItem.SetUIActive(visible);
		}

		// Token: 0x06040D1E RID: 265502 RVA: 0x00FB310A File Offset: 0x00FB130A
		public void RecycleToPool()
		{
			this.KillTween();
			this.StopHint();
			this.RefreshPieceState(null);
			UUIItem rootItem = this.RootItem;
			if (rootItem == null)
			{
				return;
			}
			rootItem.SetUIActive(false);
		}

		// Token: 0x06040D1F RID: 265503 RVA: 0x00FB3130 File Offset: 0x00FB1330
		private void RefreshAppearance()
		{
			this.RefreshAppearanceAsync(false).Forget();
		}

		// Token: 0x06040D20 RID: 265504 RVA: 0x00FB3140 File Offset: 0x00FB1340
		private UniTask RefreshAppearanceAsync(bool skipInitialVisualReset = false)
		{
			string item = MatchThreeGameplayDefine.GetPieceRes(this.Type).Item1;
			if (this.ItemView != null && this.PrefabId == item)
			{
				this.ItemView.SetType(this.Type);
				return UniTask.CompletedTask;
			}
			MatchThreePieceItemView itemView = this.ItemView;
			if (itemView != null)
			{
				UUIItem rootItem = itemView.GetRootItem();
				if (rootItem != null)
				{
					rootItem.SetUIActive(false);
				}
			}
			this.PrefabId = item;
			MatchThreePieceItemView matchThreePieceItemView;
			if (this.ItemViewCache.TryGetValue(item, out matchThreePieceItemView))
			{
				this.ItemView = matchThreePieceItemView;
				UUIItem rootItem2 = matchThreePieceItemView.GetRootItem();
				if (rootItem2 != null)
				{
					rootItem2.SetUIActive(true);
				}
				matchThreePieceItemView.SetType(this.Type);
				return UniTask.CompletedTask;
			}
			MatchThreePieceItemView matchThreePieceItemView2 = MatchThreePieceView.CreateItemView(this.Type);
			matchThreePieceItemView2.BindData(this.Type, skipInitialVisualReset);
			this.ItemView = matchThreePieceItemView2;
			this.ItemViewCache[item] = matchThreePieceItemView2;
			return this.MountItemViewAsync(matchThreePieceItemView2, item);
		}

		// Token: 0x06040D21 RID: 265505 RVA: 0x00FB3220 File Offset: 0x00FB1420
		private UniTask MountItemViewAsync(MatchThreePieceItemView itemView, string prefabId)
		{
			MatchThreePieceView.<MountItemViewAsync>d__75 <MountItemViewAsync>d__;
			<MountItemViewAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<MountItemViewAsync>d__.<>4__this = this;
			<MountItemViewAsync>d__.itemView = itemView;
			<MountItemViewAsync>d__.prefabId = prefabId;
			<MountItemViewAsync>d__.<>1__state = -1;
			<MountItemViewAsync>d__.<>t__builder.Start<MatchThreePieceView.<MountItemViewAsync>d__75>(ref <MountItemViewAsync>d__);
			return <MountItemViewAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06040D22 RID: 265506 RVA: 0x00FB3274 File Offset: 0x00FB1474
		private static MatchThreePieceItemView CreateItemView(EPieceType type)
		{
			MatchThreePieceItemView result;
			switch (type)
			{
			case EPieceType.Ultimate:
				result = new MatchThreeUltimatePieceItemView();
				break;
			case EPieceType.Hourglass:
			case EPieceType.Ice:
				result = new MatchThreePieceItemView();
				break;
			case EPieceType.Charger:
				result = new MatchThreeChargerPieceItemView();
				break;
			default:
				result = new MatchThreeNormalPieceItemView();
				break;
			}
			return result;
		}

		// Token: 0x06040D23 RID: 265507 RVA: 0x00FB32BA File Offset: 0x00FB14BA
		[NullableContext(2)]
		public void RefreshPieceState(Piece piece)
		{
			this.RefreshPieceStateCore(piece, null);
		}

		// Token: 0x06040D24 RID: 265508 RVA: 0x00FB32C4 File Offset: 0x00FB14C4
		public void RefreshLives(int lives)
		{
			MatchThreePieceItemView itemView = this.ItemView;
			if (itemView == null)
			{
				return;
			}
			itemView.RefreshLives(lives);
		}

		// Token: 0x06040D25 RID: 265509 RVA: 0x00FB32D7 File Offset: 0x00FB14D7
		public bool HasPopupInfo()
		{
			return !MatchThreeGameplayDefine.NormalPieceTypes.Contains(this.Type) || this.ActiveAdditions.Count > 0;
		}

		// Token: 0x06040D26 RID: 265510 RVA: 0x00FB32FC File Offset: 0x00FB14FC
		public int GetPopupFocusTileId()
		{
			if (this.ActiveAdditions.Contains(EMatchThreeResourceId.AdditionChain))
			{
				return 1004;
			}
			if (this.ActiveAdditions.Contains(EMatchThreeResourceId.AdditionCrossClear))
			{
				return 1002;
			}
			if (this.ActiveAdditions.Contains(EMatchThreeResourceId.AdditionBomb))
			{
				return 1001;
			}
			int result;
			switch (this.Type)
			{
			case EPieceType.Ultimate:
				result = 2001;
				break;
			case EPieceType.Hourglass:
				result = 2004;
				break;
			case EPieceType.Charger:
				result = 2003;
				break;
			case EPieceType.Ice:
				result = 2002;
				break;
			default:
				result = 0;
				break;
			}
			return result;
		}

		// Token: 0x06040D27 RID: 265511 RVA: 0x00FB338C File Offset: 0x00FB158C
		[NullableContext(2)]
		public UniTask RefreshPieceStateAsync(Piece piece)
		{
			MatchThreePieceView.<RefreshPieceStateAsync>d__81 <RefreshPieceStateAsync>d__;
			<RefreshPieceStateAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshPieceStateAsync>d__.<>4__this = this;
			<RefreshPieceStateAsync>d__.piece = piece;
			<RefreshPieceStateAsync>d__.<>1__state = -1;
			<RefreshPieceStateAsync>d__.<>t__builder.Start<MatchThreePieceView.<RefreshPieceStateAsync>d__81>(ref <RefreshPieceStateAsync>d__);
			return <RefreshPieceStateAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06040D28 RID: 265512 RVA: 0x00FB33D8 File Offset: 0x00FB15D8
		[NullableContext(2)]
		private void RefreshPieceStateCore(Piece piece, List<UniTask> showWaits)
		{
			this.ActiveAdditions.Clear();
			if (piece != null)
			{
				foreach (IPieceComponent comp in piece.Components)
				{
					EPieceComponentType additionType = MatchThreePieceView.GetAdditionType(comp);
					ValueTuple<EMatchThreeResourceId?, EPieceViewComponent> componentRes = MatchThreeGameplayDefine.GetComponentRes(additionType);
					EMatchThreeResourceId? item = componentRes.Item1;
					EPieceViewComponent item2 = componentRes.Item2;
					if (item != null)
					{
						this.ActiveAdditions.Add(item.Value);
						MatchThreePieceAdditionView matchThreePieceAdditionView;
						if (this.AdditionCache.TryGetValue(item.Value, out matchThreePieceAdditionView))
						{
							MatchThreePieceView.Collect(MatchThreePieceView.ShowAdditionAsync(matchThreePieceAdditionView), showWaits);
							matchThreePieceAdditionView.Refresh(piece, comp);
						}
						else
						{
							MatchThreePieceAdditionView matchThreePieceAdditionView2 = MatchThreePieceView.CreateAdditionView(additionType);
							matchThreePieceAdditionView2.Refresh(piece, comp);
							this.AdditionCache[item.Value] = matchThreePieceAdditionView2;
							MatchThreePieceView.Collect(this.MountAdditionAsync(matchThreePieceAdditionView2, item.Value, item2), showWaits);
						}
					}
				}
			}
			foreach (KeyValuePair<EMatchThreeResourceId, MatchThreePieceAdditionView> keyValuePair in this.AdditionCache)
			{
				if (!this.ActiveAdditions.Contains(keyValuePair.Key))
				{
					MatchThreePieceView.HideAddition(keyValuePair.Value);
				}
			}
			MatchThreePieceItemView itemView = this.ItemView;
			if (itemView == null)
			{
				return;
			}
			itemView.RefreshState(piece);
		}

		// Token: 0x06040D29 RID: 265513 RVA: 0x00FB354C File Offset: 0x00FB174C
		[NullableContext(2)]
		private static void Collect(UniTask task, List<UniTask> showWaits)
		{
			if (showWaits == null)
			{
				task.Forget();
				return;
			}
			showWaits.Add(task);
		}

		// Token: 0x06040D2A RID: 265514 RVA: 0x00FB3560 File Offset: 0x00FB1760
		private static UniTask ShowAdditionAsync(MatchThreePieceAdditionView panel)
		{
			MatchThreePieceView.<ShowAdditionAsync>d__84 <ShowAdditionAsync>d__;
			<ShowAdditionAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<ShowAdditionAsync>d__.panel = panel;
			<ShowAdditionAsync>d__.<>1__state = -1;
			<ShowAdditionAsync>d__.<>t__builder.Start<MatchThreePieceView.<ShowAdditionAsync>d__84>(ref <ShowAdditionAsync>d__);
			return <ShowAdditionAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06040D2B RID: 265515 RVA: 0x00FB35A3 File Offset: 0x00FB17A3
		private static void HideAddition(MatchThreePieceAdditionView panel)
		{
			if (!panel.IsHideOrHiding)
			{
				panel.HideAsync().Forget<bool>();
			}
		}

		// Token: 0x06040D2C RID: 265516 RVA: 0x00FB35B8 File Offset: 0x00FB17B8
		private void HideAdditionsOnClear()
		{
			foreach (MatchThreePieceAdditionView panel in this.AdditionCache.Values)
			{
				MatchThreePieceView.HideAddition(panel);
			}
		}

		// Token: 0x06040D2D RID: 265517 RVA: 0x00FB3610 File Offset: 0x00FB1810
		private static EPieceComponentType GetAdditionType(IPieceComponent comp)
		{
			EPieceComponentType result;
			if (!(comp is BombComponent))
			{
				if (!(comp is CrossClearComponent))
				{
					if (!(comp is ChainComponent))
					{
						result = (EPieceComponentType)0;
					}
					else
					{
						result = EPieceComponentType.Chain;
					}
				}
				else
				{
					result = EPieceComponentType.CrossClear;
				}
			}
			else
			{
				result = EPieceComponentType.Bomb;
			}
			return result;
		}

		// Token: 0x06040D2E RID: 265518 RVA: 0x00FB3648 File Offset: 0x00FB1848
		private static MatchThreePieceAdditionView CreateAdditionView(EPieceComponentType type)
		{
			MatchThreePieceAdditionView result;
			if (type != EPieceComponentType.Bomb)
			{
				if (type != EPieceComponentType.CrossClear)
				{
					if (type != EPieceComponentType.Chain)
					{
						result = new MatchThreePieceAdditionView();
					}
					else
					{
						result = new MatchThreeChainAdditionView();
					}
				}
				else
				{
					result = new MatchThreeCrossClearAdditionView();
				}
			}
			else
			{
				result = new MatchThreeBombAdditionView();
			}
			return result;
		}

		// Token: 0x06040D2F RID: 265519 RVA: 0x00FB3684 File Offset: 0x00FB1884
		private UniTask MountAdditionAsync(MatchThreePieceAdditionView panel, EMatchThreeResourceId prefabId, EPieceViewComponent uiParent)
		{
			MatchThreePieceView.<MountAdditionAsync>d__89 <MountAdditionAsync>d__;
			<MountAdditionAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<MountAdditionAsync>d__.<>4__this = this;
			<MountAdditionAsync>d__.panel = panel;
			<MountAdditionAsync>d__.prefabId = prefabId;
			<MountAdditionAsync>d__.uiParent = uiParent;
			<MountAdditionAsync>d__.<>1__state = -1;
			<MountAdditionAsync>d__.<>t__builder.Start<MatchThreePieceView.<MountAdditionAsync>d__89>(ref <MountAdditionAsync>d__);
			return <MountAdditionAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06040D30 RID: 265520 RVA: 0x00FB36E0 File Offset: 0x00FB18E0
		private void DestroyItemViews()
		{
			foreach (MatchThreePieceItemView matchThreePieceItemView in this.ItemViewCache.Values)
			{
				matchThreePieceItemView.Destroy(null);
			}
			this.ItemViewCache.Clear();
			this.ItemView = null;
			foreach (MatchThreePieceAdditionView matchThreePieceAdditionView in this.AdditionCache.Values)
			{
				matchThreePieceAdditionView.Destroy(null);
			}
			this.AdditionCache.Clear();
		}

		// Token: 0x06040D31 RID: 265521 RVA: 0x00FB3798 File Offset: 0x00FB1998
		[NullableContext(2)]
		public UniTask PlayClearAsync(EPieceClearReason reason, Action onUltimateFullUp = null)
		{
			this.HideAdditionsOnClear();
			return this.PlayClearItemAsyncOf(this.Type, reason, onUltimateFullUp);
		}

		// Token: 0x06040D32 RID: 265522 RVA: 0x00FB37B0 File Offset: 0x00FB19B0
		[NullableContext(2)]
		private UniTask PlayClearItemAsyncOf(EPieceType type, EPieceClearReason reason, Action onUltimateFullUp)
		{
			UniTask result;
			switch (type)
			{
			case EPieceType.Ultimate:
				result = this.PlayClearUltimateAsync(reason, onUltimateFullUp);
				break;
			case EPieceType.Hourglass:
				result = this.PlayClearHourglassAsync(reason);
				break;
			case EPieceType.Charger:
				result = this.PlayClearChargerAsync(reason);
				break;
			case EPieceType.Ice:
				result = this.PlayClearIceAsync(reason);
				break;
			default:
				result = this.PlayClearNormalAsync(reason);
				break;
			}
			return result;
		}

		// Token: 0x06040D33 RID: 265523 RVA: 0x00FB380C File Offset: 0x00FB1A0C
		private UniTask PlayClearNormalAsync(EPieceClearReason reason)
		{
			MatchThreePieceView.<PlayClearNormalAsync>d__93 <PlayClearNormalAsync>d__;
			<PlayClearNormalAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayClearNormalAsync>d__.<>4__this = this;
			<PlayClearNormalAsync>d__.reason = reason;
			<PlayClearNormalAsync>d__.<>1__state = -1;
			<PlayClearNormalAsync>d__.<>t__builder.Start<MatchThreePieceView.<PlayClearNormalAsync>d__93>(ref <PlayClearNormalAsync>d__);
			return <PlayClearNormalAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06040D34 RID: 265524 RVA: 0x00FB3858 File Offset: 0x00FB1A58
		private UniTask PlayClearIceAsync(EPieceClearReason reason)
		{
			MatchThreePieceView.<PlayClearIceAsync>d__94 <PlayClearIceAsync>d__;
			<PlayClearIceAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayClearIceAsync>d__.<>4__this = this;
			<PlayClearIceAsync>d__.reason = reason;
			<PlayClearIceAsync>d__.<>1__state = -1;
			<PlayClearIceAsync>d__.<>t__builder.Start<MatchThreePieceView.<PlayClearIceAsync>d__94>(ref <PlayClearIceAsync>d__);
			return <PlayClearIceAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06040D35 RID: 265525 RVA: 0x00FB38A3 File Offset: 0x00FB1AA3
		private UniTask PlayClearChargerAsync(EPieceClearReason _)
		{
			return this.PlayItemAnimAsync("Close");
		}

		// Token: 0x06040D36 RID: 265526 RVA: 0x00FB38B0 File Offset: 0x00FB1AB0
		private UniTask PlayClearHourglassAsync(EPieceClearReason _)
		{
			return this.PlayItemAnimAsync("Close");
		}

		// Token: 0x06040D37 RID: 265527 RVA: 0x00FB38C0 File Offset: 0x00FB1AC0
		[NullableContext(2)]
		private UniTask PlayClearUltimateAsync(EPieceClearReason reason, Action onUltimateFullUp)
		{
			MatchThreePieceView.<PlayClearUltimateAsync>d__97 <PlayClearUltimateAsync>d__;
			<PlayClearUltimateAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayClearUltimateAsync>d__.<>4__this = this;
			<PlayClearUltimateAsync>d__.reason = reason;
			<PlayClearUltimateAsync>d__.onUltimateFullUp = onUltimateFullUp;
			<PlayClearUltimateAsync>d__.<>1__state = -1;
			<PlayClearUltimateAsync>d__.<>t__builder.Start<MatchThreePieceView.<PlayClearUltimateAsync>d__97>(ref <PlayClearUltimateAsync>d__);
			return <PlayClearUltimateAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06040D38 RID: 265528 RVA: 0x00FB3913 File Offset: 0x00FB1B13
		public UniTask PlayHitAsync()
		{
			return this.PlaySelfAnimAsync("ClearClose");
		}

		// Token: 0x06040D39 RID: 265529 RVA: 0x00FB3920 File Offset: 0x00FB1B20
		public UniTask PlaySpawnAsync()
		{
			return this.PlayItemAnimAsync("Start");
		}

		// Token: 0x06040D3A RID: 265530 RVA: 0x00FB3930 File Offset: 0x00FB1B30
		[NullableContext(2)]
		public UniTask PlayRestartCleanAsync(Piece piece)
		{
			MatchThreePieceView.<PlayRestartCleanAsync>d__100 <PlayRestartCleanAsync>d__;
			<PlayRestartCleanAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayRestartCleanAsync>d__.<>4__this = this;
			<PlayRestartCleanAsync>d__.piece = piece;
			<PlayRestartCleanAsync>d__.<>1__state = -1;
			<PlayRestartCleanAsync>d__.<>t__builder.Start<MatchThreePieceView.<PlayRestartCleanAsync>d__100>(ref <PlayRestartCleanAsync>d__);
			return <PlayRestartCleanAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06040D3B RID: 265531 RVA: 0x00FB397C File Offset: 0x00FB1B7C
		private void OnRootSequencePlayEvent(string sequenceName, string eventName)
		{
			if (sequenceName != EMatchThreePieceSequence.Clean.ToEnumString() || eventName != "On" || this.RestartCleanRefreshGate == null || this.RestartCleanOnReceived)
			{
				return;
			}
			this.RestartCleanOnReceived = true;
			this.ApplyRestartCleanPieceAsync(this.RestartCleanTargetPiece, this.RestartCleanVersion, this.RestartCleanRefreshGate).Forget();
		}

		// Token: 0x06040D3C RID: 265532 RVA: 0x00FB39DC File Offset: 0x00FB1BDC
		private UniTask ApplyRestartCleanPieceAsync([Nullable(2)] Piece piece, int version, UniTaskCompletionSource gate)
		{
			MatchThreePieceView.<ApplyRestartCleanPieceAsync>d__102 <ApplyRestartCleanPieceAsync>d__;
			<ApplyRestartCleanPieceAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<ApplyRestartCleanPieceAsync>d__.<>4__this = this;
			<ApplyRestartCleanPieceAsync>d__.piece = piece;
			<ApplyRestartCleanPieceAsync>d__.version = version;
			<ApplyRestartCleanPieceAsync>d__.gate = gate;
			<ApplyRestartCleanPieceAsync>d__.<>1__state = -1;
			<ApplyRestartCleanPieceAsync>d__.<>t__builder.Start<MatchThreePieceView.<ApplyRestartCleanPieceAsync>d__102>(ref <ApplyRestartCleanPieceAsync>d__);
			return <ApplyRestartCleanPieceAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06040D3D RID: 265533 RVA: 0x00FB3A37 File Offset: 0x00FB1C37
		private void ReleaseRestartCleanRefreshGate()
		{
			this.RestartCleanVersion++;
			this.RestartCleanTargetPiece = null;
			this.RestartCleanOnReceived = false;
			UniTaskCompletionSource restartCleanRefreshGate = this.RestartCleanRefreshGate;
			this.RestartCleanRefreshGate = null;
			if (restartCleanRefreshGate == null)
			{
				return;
			}
			restartCleanRefreshGate.TrySetResult();
		}

		// Token: 0x06040D3E RID: 265534 RVA: 0x00FB3A70 File Offset: 0x00FB1C70
		private void SetPieceContentVisible(bool visible)
		{
			UUIItem item = base.GetItem(1);
			if (item != null)
			{
				item.SetUIActive(visible);
			}
			UUIItem item2 = base.GetItem(2);
			if (item2 != null)
			{
				item2.SetUIActive(visible);
			}
			UUIItem item3 = base.GetItem(3);
			if (item3 != null)
			{
				item3.SetUIActive(visible);
			}
			UUIButtonComponent button = base.GetButton(0);
			if (button == null)
			{
				return;
			}
			UUIItem uuiitem = button.RootUIComp.Get();
			if (uuiitem == null)
			{
				return;
			}
			uuiitem.SetRaycastTarget(visible);
		}

		// Token: 0x06040D3F RID: 265535 RVA: 0x00FB3ADC File Offset: 0x00FB1CDC
		public UniTask PlayRecolorAsync(Piece piece)
		{
			MatchThreePieceView.<PlayRecolorAsync>d__105 <PlayRecolorAsync>d__;
			<PlayRecolorAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayRecolorAsync>d__.<>4__this = this;
			<PlayRecolorAsync>d__.piece = piece;
			<PlayRecolorAsync>d__.<>1__state = -1;
			<PlayRecolorAsync>d__.<>t__builder.Start<MatchThreePieceView.<PlayRecolorAsync>d__105>(ref <PlayRecolorAsync>d__);
			return <PlayRecolorAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06040D40 RID: 265536 RVA: 0x00FB3B28 File Offset: 0x00FB1D28
		private UniTask PlaySelfAnimAsync(string sequence)
		{
			UiSequencePlayer sequencePlayer = this.SequencePlayer;
			if (sequencePlayer == null)
			{
				return UniTask.CompletedTask;
			}
			return sequencePlayer.PlaySequenceAsync(sequence, new CustomPromise<bool>(), false, false, null);
		}

		// Token: 0x06040D41 RID: 265537 RVA: 0x00FB3B5B File Offset: 0x00FB1D5B
		private UniTask PlayItemAnimAsync(string sequence)
		{
			if (this.ItemView == null)
			{
				return UniTask.CompletedTask;
			}
			return this.ItemView.PlayAnimAsync(sequence);
		}

		// Token: 0x06040D42 RID: 265538 RVA: 0x00FB3B78 File Offset: 0x00FB1D78
		public UniTask PlayFallTripAsync(List<PieceMoveEvent> moves, int start, int count, float flightDuration, [Nullable(2)] Action onFallStarted)
		{
			PieceMoveEvent pieceMoveEvent = moves[start + count - 1];
			this.Pos = new GridPosition(pieceMoveEvent.ToRow, pieceMoveEvent.ToCol);
			this.BuildWaypoints(moves, start, count);
			if (this.RootItem == null || this.WayTotal <= 0f)
			{
				this.SetLocationByRowCol(pieceMoveEvent.ToRow, pieceMoveEvent.ToCol);
				return UniTask.CompletedTask;
			}
			this.KillTween();
			this.FallStarted = onFallStarted;
			this.FlightDuration = ((flightDuration > 0f) ? flightDuration : MatchThreePieceView.FallFlightDuration(this.WayTotal, this.CellStepY));
			this.HoldDuration = ((this.FallCurve != null) ? this.FallCurveStart : 0f);
			this.BounceDuration = ((this.FallCurve != null) ? (this.FallCurveEnd - this.FallCurveLand) : 0f);
			float duration = this.HoldDuration + this.FlightDuration + this.BounceDuration;
			PieceMoveEvent pieceMoveEvent2 = moves[start];
			this.SetLocationByRowCol(pieceMoveEvent2.FromRow, pieceMoveEvent2.FromCol);
			if (this.FallSetter == null)
			{
				this.FallSetter = DelegateUtils.ToManualReleaseDelegate<FLTweenFloatSetterDynamic>(new Action<float>(this.OnFallProgress));
			}
			this.Tweener = ULTweenBPLibrary.FloatTo(GlobalData.World, this.FallSetter, 0f, 1f, duration, 0f, LTweenEase.Linear);
			if (this.Tweener == null)
			{
				this.FallStarted = null;
				this.SetLocationByRowCol(pieceMoveEvent.ToRow, pieceMoveEvent.ToCol);
				return UniTask.CompletedTask;
			}
			this.Tcs = AutoResetUniTaskCompletionSource.Create();
			FLTweenerDynamicDelegate onCompleteCallBack = this.Tweener.OnCompleteCallBack;
			Action callback;
			if ((callback = this.CompleteAction) == null)
			{
				callback = (this.CompleteAction = new Action(this.OnTweenComplete));
			}
			onCompleteCallBack.Bind(callback);
			return this.Tcs.Task;
		}

		// Token: 0x06040D43 RID: 265539 RVA: 0x00FB3D30 File Offset: 0x00FB1F30
		private void BuildWaypoints(List<PieceMoveEvent> moves, int start, int count)
		{
			this.WayX.Clear();
			this.WayY.Clear();
			this.WayDist.Clear();
			PieceMoveEvent pieceMoveEvent = moves[start];
			this.WayX.Add((float)pieceMoveEvent.FromCol * this.CellStepX);
			this.WayY.Add((float)(-(float)pieceMoveEvent.FromRow) * this.CellStepY);
			this.WayDist.Add(0f);
			float num = 0f;
			for (int i = 0; i < count; i++)
			{
				PieceMoveEvent pieceMoveEvent2 = moves[start + i];
				float num2 = (float)pieceMoveEvent2.ToCol * this.CellStepX;
				float num3 = (float)(-(float)pieceMoveEvent2.ToRow) * this.CellStepY;
				float num4 = num2 - this.WayX[i];
				float num5 = num3 - this.WayY[i];
				num += (float)Math.Sqrt((double)(num4 * num4 + num5 * num5));
				this.WayX.Add(num2);
				this.WayY.Add(num3);
				this.WayDist.Add(num);
			}
			this.WayTotal = num;
		}

		// Token: 0x06040D44 RID: 265540 RVA: 0x00FB3E4C File Offset: 0x00FB204C
		private float SampleFall(float t)
		{
			if (this.FallCurve == null)
			{
				return t * t;
			}
			float num = t * (this.HoldDuration + this.FlightDuration + this.BounceDuration);
			if (num <= this.HoldDuration)
			{
				return 0f;
			}
			num -= this.HoldDuration;
			if (num < this.FlightDuration)
			{
				float num2 = num / this.FlightDuration;
				return this.FallCurve.GetFloatValue(this.FallCurveStart + (this.FallCurveLand - this.FallCurveStart) * num2);
			}
			if (this.BounceDuration <= 0f)
			{
				return this.FallCurve.GetFloatValue(this.FallCurveLand);
			}
			float num3 = (num - this.FlightDuration) / this.BounceDuration;
			return this.FallCurve.GetFloatValue(this.FallCurveLand + (this.FallCurveEnd - this.FallCurveLand) * ((num3 < 1f) ? num3 : 1f));
		}

		// Token: 0x06040D45 RID: 265541 RVA: 0x00FB3F28 File Offset: 0x00FB2128
		private void OnFallProgress(float t)
		{
			float num = this.SampleFall(t);
			float num2 = ((num < 1f) ? num : 1f) * this.WayTotal;
			int num3 = this.WayDist.Count - 1;
			for (int i = 1; i < this.WayDist.Count; i++)
			{
				if (num2 <= this.WayDist[i])
				{
					num3 = i;
					break;
				}
			}
			float num4 = this.WayDist[num3] - this.WayDist[num3 - 1];
			float num5 = (num4 <= 0f) ? 1f : ((num2 - this.WayDist[num3 - 1]) / num4);
			float num6 = (num > 1f) ? ((num - 1f) * this.CellStepY) : 0f;
			this.TempLocation.Set((double)(this.WayX[num3 - 1] + (this.WayX[num3] - this.WayX[num3 - 1]) * num5), (double)(this.WayY[num3 - 1] + (this.WayY[num3] - this.WayY[num3 - 1]) * num5 - num6));
			UUIItem rootItem = this.RootItem;
			if (rootItem != null)
			{
				rootItem.SetAnchorOffset(this.TempLocation.ToUeVector2D(true));
			}
			if (num2 > 0f && this.FallStarted != null)
			{
				Action fallStarted = this.FallStarted;
				this.FallStarted = null;
				fallStarted();
			}
		}

		// Token: 0x06040D46 RID: 265542 RVA: 0x00FB4099 File Offset: 0x00FB2299
		public UniTask PlaySwapAsync(GridPosition to)
		{
			this.Pos = to;
			return this.TweenToCellAsync(to.Row, to.Col, 0.2f, LTweenEase.InOutSine);
		}

		// Token: 0x06040D47 RID: 265543 RVA: 0x00FB40BC File Offset: 0x00FB22BC
		public UniTask PlaySwapFailAsync(GridPosition other)
		{
			MatchThreePieceView.<PlaySwapFailAsync>d__113 <PlaySwapFailAsync>d__;
			<PlaySwapFailAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlaySwapFailAsync>d__.<>4__this = this;
			<PlaySwapFailAsync>d__.other = other;
			<PlaySwapFailAsync>d__.<>1__state = -1;
			<PlaySwapFailAsync>d__.<>t__builder.Start<MatchThreePieceView.<PlaySwapFailAsync>d__113>(ref <PlaySwapFailAsync>d__);
			return <PlaySwapFailAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06040D48 RID: 265544 RVA: 0x00FB4108 File Offset: 0x00FB2308
		private UniTask TweenToCellAsync(int row, int col, float duration, LTweenEase ease)
		{
			this.KillTween();
			if (this.RootItem == null)
			{
				this.SetLocationByRowCol(row, col);
				return UniTask.CompletedTask;
			}
			if (this.MoveSetter == null)
			{
				this.MoveSetter = DelegateUtils.ToManualReleaseDelegate<FLTweenVector2SetterDynamic>(new Action<FVector2D>(this.OnTweenLocation));
			}
			this.Tweener = ULTweenBPLibrary.Vector2To(GlobalData.World, this.MoveSetter, new FVector2D(this.RootItem.GetAnchorOffsetX(), this.RootItem.GetAnchorOffsetY()), new FVector2D((float)col * this.CellStepX, (float)(-(float)row) * this.CellStepY), duration, 0f, ease);
			if (this.Tweener == null)
			{
				this.SetLocationByRowCol(row, col);
				return UniTask.CompletedTask;
			}
			this.Tcs = AutoResetUniTaskCompletionSource.Create();
			FLTweenerDynamicDelegate onCompleteCallBack = this.Tweener.OnCompleteCallBack;
			Action callback;
			if ((callback = this.CompleteAction) == null)
			{
				callback = (this.CompleteAction = new Action(this.OnTweenComplete));
			}
			onCompleteCallBack.Bind(callback);
			return this.Tcs.Task;
		}

		// Token: 0x06040D49 RID: 265545 RVA: 0x00FB41FC File Offset: 0x00FB23FC
		private void OnTweenLocation(FVector2D value)
		{
			UUIItem rootItem = this.RootItem;
			if (rootItem == null)
			{
				return;
			}
			rootItem.SetAnchorOffset(value);
		}

		// Token: 0x06040D4A RID: 265546 RVA: 0x00FB420F File Offset: 0x00FB240F
		private void OnTweenComplete()
		{
			this.FallStarted = null;
			this.Tweener = null;
			AutoResetUniTaskCompletionSource tcs = this.Tcs;
			this.Tcs = null;
			if (tcs == null)
			{
				return;
			}
			tcs.TrySetResult();
		}

		// Token: 0x06040D4B RID: 265547 RVA: 0x00FB4238 File Offset: 0x00FB2438
		private void KillTween()
		{
			this.FallStarted = null;
			ULTweener tweener = this.Tweener;
			if (tweener != null && tweener.IsValid())
			{
				this.Tweener.Kill(false);
			}
			this.Tweener = null;
			AutoResetUniTaskCompletionSource tcs = this.Tcs;
			this.Tcs = null;
			if (tcs == null)
			{
				return;
			}
			tcs.TrySetResult();
		}

		// Token: 0x06040D4C RID: 265548 RVA: 0x00FB428C File Offset: 0x00FB248C
		protected override void OnBeforeDestroy()
		{
			this.Hinting = false;
			this.ReleaseRestartCleanRefreshGate();
			AUIBaseActor sequenceActor = this.SequenceActor;
			if (sequenceActor != null)
			{
				sequenceActor.OnSequencePlayEvent.Unbind();
			}
			this.SequenceActor = null;
			UiSequencePlayer sequencePlayer = this.SequencePlayer;
			if (sequencePlayer != null)
			{
				sequencePlayer.Clear();
			}
			this.SequencePlayer = null;
			this.DestroyItemViews();
			this.KillTween();
			FLTweenVector2SetterDynamic moveSetter = this.MoveSetter;
			if (moveSetter != null && moveSetter.IsBound())
			{
				DelegateUtils.ReleaseManualReleaseDelegate(new Action<FVector2D>(this.OnTweenLocation));
			}
			this.MoveSetter = null;
			FLTweenFloatSetterDynamic fallSetter = this.FallSetter;
			if (fallSetter != null && fallSetter.IsBound())
			{
				DelegateUtils.ReleaseManualReleaseDelegate(new Action<float>(this.OnFallProgress));
			}
			this.FallSetter = null;
		}

		// Token: 0x04021C39 RID: 138297
		private GridPosition Pos;

		// Token: 0x04021C3C RID: 138300
		[Nullable(2)]
		private MatchThreePieceItemView ItemView;

		// Token: 0x04021C3D RID: 138301
		private readonly Dictionary<string, MatchThreePieceItemView> ItemViewCache = new Dictionary<string, MatchThreePieceItemView>();

		// Token: 0x04021C3E RID: 138302
		private readonly Dictionary<EMatchThreeResourceId, MatchThreePieceAdditionView> AdditionCache = new Dictionary<EMatchThreeResourceId, MatchThreePieceAdditionView>();

		// Token: 0x04021C3F RID: 138303
		private readonly HashSet<EMatchThreeResourceId> ActiveAdditions = new HashSet<EMatchThreeResourceId>();

		// Token: 0x04021C40 RID: 138304
		private readonly List<UniTask> AdditionShowTasks = new List<UniTask>();

		// Token: 0x04021C41 RID: 138305
		private const float SwapDuration = 0.2f;

		// Token: 0x04021C42 RID: 138306
		private const float FallDurationBase = 0.13f;

		// Token: 0x04021C43 RID: 138307
		[Nullable(2)]
		private ULTweener Tweener;

		// Token: 0x04021C44 RID: 138308
		[Nullable(2)]
		private AutoResetUniTaskCompletionSource Tcs;

		// Token: 0x04021C45 RID: 138309
		[Nullable(2)]
		private FLTweenVector2SetterDynamic MoveSetter;

		// Token: 0x04021C46 RID: 138310
		[Nullable(2)]
		private FLTweenFloatSetterDynamic FallSetter;

		// Token: 0x04021C47 RID: 138311
		[Nullable(2)]
		private Action CompleteAction;

		// Token: 0x04021C48 RID: 138312
		[Nullable(2)]
		private Action FallStarted;

		// Token: 0x04021C49 RID: 138313
		[Nullable(2)]
		private UCurveFloat FallCurve;

		// Token: 0x04021C4A RID: 138314
		private float FallCurveStart;

		// Token: 0x04021C4B RID: 138315
		private float FallCurveLand = 1f;

		// Token: 0x04021C4C RID: 138316
		private float FallCurveEnd = 1f;

		// Token: 0x04021C4D RID: 138317
		private readonly List<float> WayX = new List<float>();

		// Token: 0x04021C4E RID: 138318
		private readonly List<float> WayY = new List<float>();

		// Token: 0x04021C4F RID: 138319
		private readonly List<float> WayDist = new List<float>();

		// Token: 0x04021C50 RID: 138320
		private float WayTotal;

		// Token: 0x04021C51 RID: 138321
		private readonly Vector2D TempLocation = Vector2D.Create();

		// Token: 0x04021C52 RID: 138322
		private float HoldDuration;

		// Token: 0x04021C53 RID: 138323
		private float FlightDuration = 1f;

		// Token: 0x04021C54 RID: 138324
		private float BounceDuration;

		// Token: 0x04021C55 RID: 138325
		private float CellStepX;

		// Token: 0x04021C56 RID: 138326
		private float CellStepY;

		// Token: 0x04021C57 RID: 138327
		[Nullable(2)]
		private UiSequencePlayer SequencePlayer;

		// Token: 0x04021C58 RID: 138328
		[Nullable(2)]
		private AUIBaseActor SequenceActor;

		// Token: 0x04021C59 RID: 138329
		[Nullable(2)]
		private UniTaskCompletionSource RestartCleanRefreshGate;

		// Token: 0x04021C5A RID: 138330
		[Nullable(2)]
		private Piece RestartCleanTargetPiece;

		// Token: 0x04021C5B RID: 138331
		private bool RestartCleanOnReceived;

		// Token: 0x04021C5C RID: 138332
		private int RestartCleanVersion;

		// Token: 0x04021C5D RID: 138333
		private bool SkipInitialVisualReset;

		// Token: 0x04021C5E RID: 138334
		private bool Hinting;

		// Token: 0x04021C5F RID: 138335
		private bool PlayingHint;

		// Token: 0x04021C60 RID: 138336
		[Nullable(2)]
		private Action<GridPosition> PressedCallback;

		// Token: 0x04021C61 RID: 138337
		[Nullable(2)]
		private Action<GridPosition> EnteredCallback;

		// Token: 0x04021C62 RID: 138338
		[Nullable(2)]
		private Action ReleasedCallback;
	}
}
