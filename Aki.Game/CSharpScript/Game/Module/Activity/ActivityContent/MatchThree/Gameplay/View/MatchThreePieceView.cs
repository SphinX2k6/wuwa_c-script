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
	// Token: 0x0200545E RID: 21598
	[NullableContext(1)]
	[Nullable(0)]
	public class MatchThreePieceView : UiPanelBase
	{
		// Token: 0x1700683E RID: 26686
		// (get) Token: 0x060359C6 RID: 219590 RVA: 0x00EF9BFA File Offset: 0x00EF7DFA
		// (set) Token: 0x060359C7 RID: 219591 RVA: 0x00EF9C02 File Offset: 0x00EF7E02
		public EPieceType Type { get; private set; }

		// Token: 0x1700683F RID: 26687
		// (get) Token: 0x060359C8 RID: 219592 RVA: 0x00EF9C0B File Offset: 0x00EF7E0B
		// (set) Token: 0x060359C9 RID: 219593 RVA: 0x00EF9C13 File Offset: 0x00EF7E13
		public string PrefabId { get; private set; } = string.Empty;

		// Token: 0x060359CA RID: 219594 RVA: 0x00EF9C1C File Offset: 0x00EF7E1C
		public static float FallFlightDuration(float arcLength, float cellStepY)
		{
			float val = (cellStepY <= 0f) ? 1f : (arcLength / cellStepY);
			return 0.13f * (float)Math.Sqrt((double)Math.Max(val, 1f));
		}

		// Token: 0x060359CB RID: 219595 RVA: 0x00EF9C54 File Offset: 0x00EF7E54
		[NullableContext(2)]
		public void SetFallCurve(UCurveFloat curve, float startTime, float landTime, float endTime)
		{
			this.FallCurve = curve;
			this.FallCurveStart = startTime;
			this.FallCurveLand = landTime;
			this.FallCurveEnd = endTime;
		}

		// Token: 0x060359CC RID: 219596 RVA: 0x00EF9C74 File Offset: 0x00EF7E74
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

		// Token: 0x060359CD RID: 219597 RVA: 0x00EF9D64 File Offset: 0x00EF7F64
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

		// Token: 0x060359CE RID: 219598 RVA: 0x00EF9DDF File Offset: 0x00EF7FDF
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

		// Token: 0x060359CF RID: 219599 RVA: 0x00EF9DF7 File Offset: 0x00EF7FF7
		public void BindData(GridPosition pos, EPieceType type, bool skipInitialVisualReset = false)
		{
			this.Pos = pos;
			this.Type = type;
			this.SkipInitialVisualReset = skipInitialVisualReset;
		}

		// Token: 0x060359D0 RID: 219600 RVA: 0x00EF9E0E File Offset: 0x00EF800E
		public void BindCellStep(float stepX, float stepY)
		{
			this.CellStepX = stepX;
			this.CellStepY = stepY;
		}

		// Token: 0x060359D1 RID: 219601 RVA: 0x00EF9E1E File Offset: 0x00EF801E
		public void BindInput(Action<GridPosition> pressed, Action<GridPosition> entered, Action released)
		{
			this.PressedCallback = pressed;
			this.EnteredCallback = entered;
			this.ReleasedCallback = released;
		}

		// Token: 0x060359D2 RID: 219602 RVA: 0x00EF9E38 File Offset: 0x00EF8038
		protected override UniTask OnBeforeStartAsync()
		{
			MatchThreePieceView.<OnBeforeStartAsync>d__51 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<MatchThreePieceView.<OnBeforeStartAsync>d__51>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060359D3 RID: 219603 RVA: 0x00EF9E7B File Offset: 0x00EF807B
		public void StartHint()
		{
			if (this.Hinting)
			{
				return;
			}
			this.Hinting = true;
			this.PlayHintOnce();
		}

		// Token: 0x060359D4 RID: 219604 RVA: 0x00EF9E93 File Offset: 0x00EF8093
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

		// Token: 0x060359D5 RID: 219605 RVA: 0x00EF9EBC File Offset: 0x00EF80BC
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

		// Token: 0x060359D6 RID: 219606 RVA: 0x00EF9EE4 File Offset: 0x00EF80E4
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

		// Token: 0x060359D7 RID: 219607 RVA: 0x00EF9F54 File Offset: 0x00EF8154
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

		// Token: 0x060359D8 RID: 219608 RVA: 0x00EF9FD7 File Offset: 0x00EF81D7
		private void OnPointDown()
		{
			Action<GridPosition> pressedCallback = this.PressedCallback;
			if (pressedCallback == null)
			{
				return;
			}
			pressedCallback(this.Pos);
		}

		// Token: 0x060359D9 RID: 219609 RVA: 0x00EF9FEF File Offset: 0x00EF81EF
		private void OnPointEnter()
		{
			Action<GridPosition> enteredCallback = this.EnteredCallback;
			if (enteredCallback == null)
			{
				return;
			}
			enteredCallback(this.Pos);
		}

		// Token: 0x060359DA RID: 219610 RVA: 0x00EFA007 File Offset: 0x00EF8207
		private void OnPointUp()
		{
			Action releasedCallback = this.ReleasedCallback;
			if (releasedCallback == null)
			{
				return;
			}
			releasedCallback();
		}

		// Token: 0x060359DB RID: 219611 RVA: 0x00EFA019 File Offset: 0x00EF8219
		public void SetLocationByRowCol(int row, int col)
		{
			UUIItem rootItem = this.RootItem;
			if (rootItem == null)
			{
				return;
			}
			rootItem.SetAnchorOffset(new FVector2D((float)col * this.CellStepX, (float)(-(float)row) * this.CellStepY));
		}

		// Token: 0x060359DC RID: 219612 RVA: 0x00EFA043 File Offset: 0x00EF8243
		public void SetType(EPieceType type)
		{
			this.Type = type;
			this.RefreshAppearance();
		}

		// Token: 0x060359DD RID: 219613 RVA: 0x00EFA052 File Offset: 0x00EF8252
		public UniTask SetTypeAsync(EPieceType type)
		{
			this.Type = type;
			return this.RefreshAppearanceAsync(false);
		}

		// Token: 0x060359DE RID: 219614 RVA: 0x00EFA062 File Offset: 0x00EF8262
		private UniTask SetTypeForBoardRefreshAsync(EPieceType type)
		{
			this.Type = type;
			return this.RefreshAppearanceAsync(true);
		}

		// Token: 0x060359DF RID: 219615 RVA: 0x00EFA074 File Offset: 0x00EF8274
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

		// Token: 0x060359E0 RID: 219616 RVA: 0x00EFA0D4 File Offset: 0x00EF82D4
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

		// Token: 0x060359E1 RID: 219617 RVA: 0x00EFA127 File Offset: 0x00EF8327
		public void SetVisible(bool visible)
		{
			UUIItem rootItem = this.RootItem;
			if (rootItem == null)
			{
				return;
			}
			rootItem.SetUIActive(visible);
		}

		// Token: 0x060359E2 RID: 219618 RVA: 0x00EFA13A File Offset: 0x00EF833A
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

		// Token: 0x060359E3 RID: 219619 RVA: 0x00EFA160 File Offset: 0x00EF8360
		private void RefreshAppearance()
		{
			this.RefreshAppearanceAsync(false).Forget();
		}

		// Token: 0x060359E4 RID: 219620 RVA: 0x00EFA170 File Offset: 0x00EF8370
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

		// Token: 0x060359E5 RID: 219621 RVA: 0x00EFA250 File Offset: 0x00EF8450
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

		// Token: 0x060359E6 RID: 219622 RVA: 0x00EFA2A4 File Offset: 0x00EF84A4
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

		// Token: 0x060359E7 RID: 219623 RVA: 0x00EFA2EA File Offset: 0x00EF84EA
		[NullableContext(2)]
		public void RefreshPieceState(Piece piece)
		{
			this.RefreshPieceStateCore(piece, null);
		}

		// Token: 0x060359E8 RID: 219624 RVA: 0x00EFA2F4 File Offset: 0x00EF84F4
		public void RefreshLives(int lives)
		{
			MatchThreePieceItemView itemView = this.ItemView;
			if (itemView == null)
			{
				return;
			}
			itemView.RefreshLives(lives);
		}

		// Token: 0x060359E9 RID: 219625 RVA: 0x00EFA307 File Offset: 0x00EF8507
		public bool HasPopupInfo()
		{
			return !MatchThreeGameplayDefine.NormalPieceTypes.Contains(this.Type) || this.ActiveAdditions.Count > 0;
		}

		// Token: 0x060359EA RID: 219626 RVA: 0x00EFA32C File Offset: 0x00EF852C
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

		// Token: 0x060359EB RID: 219627 RVA: 0x00EFA3BC File Offset: 0x00EF85BC
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

		// Token: 0x060359EC RID: 219628 RVA: 0x00EFA408 File Offset: 0x00EF8608
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

		// Token: 0x060359ED RID: 219629 RVA: 0x00EFA57C File Offset: 0x00EF877C
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

		// Token: 0x060359EE RID: 219630 RVA: 0x00EFA590 File Offset: 0x00EF8790
		private static UniTask ShowAdditionAsync(MatchThreePieceAdditionView panel)
		{
			MatchThreePieceView.<ShowAdditionAsync>d__84 <ShowAdditionAsync>d__;
			<ShowAdditionAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<ShowAdditionAsync>d__.panel = panel;
			<ShowAdditionAsync>d__.<>1__state = -1;
			<ShowAdditionAsync>d__.<>t__builder.Start<MatchThreePieceView.<ShowAdditionAsync>d__84>(ref <ShowAdditionAsync>d__);
			return <ShowAdditionAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060359EF RID: 219631 RVA: 0x00EFA5D3 File Offset: 0x00EF87D3
		private static void HideAddition(MatchThreePieceAdditionView panel)
		{
			if (!panel.IsHideOrHiding)
			{
				panel.HideAsync().Forget<bool>();
			}
		}

		// Token: 0x060359F0 RID: 219632 RVA: 0x00EFA5E8 File Offset: 0x00EF87E8
		private void HideAdditionsOnClear()
		{
			foreach (MatchThreePieceAdditionView panel in this.AdditionCache.Values)
			{
				MatchThreePieceView.HideAddition(panel);
			}
		}

		// Token: 0x060359F1 RID: 219633 RVA: 0x00EFA640 File Offset: 0x00EF8840
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

		// Token: 0x060359F2 RID: 219634 RVA: 0x00EFA678 File Offset: 0x00EF8878
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

		// Token: 0x060359F3 RID: 219635 RVA: 0x00EFA6B4 File Offset: 0x00EF88B4
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

		// Token: 0x060359F4 RID: 219636 RVA: 0x00EFA710 File Offset: 0x00EF8910
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

		// Token: 0x060359F5 RID: 219637 RVA: 0x00EFA7C8 File Offset: 0x00EF89C8
		[NullableContext(2)]
		public UniTask PlayClearAsync(EPieceClearReason reason, Action onUltimateFullUp = null)
		{
			this.HideAdditionsOnClear();
			return this.PlayClearItemAsyncOf(this.Type, reason, onUltimateFullUp);
		}

		// Token: 0x060359F6 RID: 219638 RVA: 0x00EFA7E0 File Offset: 0x00EF89E0
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

		// Token: 0x060359F7 RID: 219639 RVA: 0x00EFA83C File Offset: 0x00EF8A3C
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

		// Token: 0x060359F8 RID: 219640 RVA: 0x00EFA888 File Offset: 0x00EF8A88
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

		// Token: 0x060359F9 RID: 219641 RVA: 0x00EFA8D3 File Offset: 0x00EF8AD3
		private UniTask PlayClearChargerAsync(EPieceClearReason _)
		{
			return this.PlayItemAnimAsync("Close");
		}

		// Token: 0x060359FA RID: 219642 RVA: 0x00EFA8E0 File Offset: 0x00EF8AE0
		private UniTask PlayClearHourglassAsync(EPieceClearReason _)
		{
			return this.PlayItemAnimAsync("Close");
		}

		// Token: 0x060359FB RID: 219643 RVA: 0x00EFA8F0 File Offset: 0x00EF8AF0
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

		// Token: 0x060359FC RID: 219644 RVA: 0x00EFA943 File Offset: 0x00EF8B43
		public UniTask PlayHitAsync()
		{
			return this.PlaySelfAnimAsync("ClearClose");
		}

		// Token: 0x060359FD RID: 219645 RVA: 0x00EFA950 File Offset: 0x00EF8B50
		public UniTask PlaySpawnAsync()
		{
			return this.PlayItemAnimAsync("Start");
		}

		// Token: 0x060359FE RID: 219646 RVA: 0x00EFA960 File Offset: 0x00EF8B60
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

		// Token: 0x060359FF RID: 219647 RVA: 0x00EFA9AC File Offset: 0x00EF8BAC
		private void OnRootSequencePlayEvent(string sequenceName, string eventName)
		{
			if (sequenceName != EMatchThreePieceSequence.Clean.ToEnumString() || eventName != "On" || this.RestartCleanRefreshGate == null || this.RestartCleanOnReceived)
			{
				return;
			}
			this.RestartCleanOnReceived = true;
			this.ApplyRestartCleanPieceAsync(this.RestartCleanTargetPiece, this.RestartCleanVersion, this.RestartCleanRefreshGate).Forget();
		}

		// Token: 0x06035A00 RID: 219648 RVA: 0x00EFAA0C File Offset: 0x00EF8C0C
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

		// Token: 0x06035A01 RID: 219649 RVA: 0x00EFAA67 File Offset: 0x00EF8C67
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

		// Token: 0x06035A02 RID: 219650 RVA: 0x00EFAAA0 File Offset: 0x00EF8CA0
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

		// Token: 0x06035A03 RID: 219651 RVA: 0x00EFAB0C File Offset: 0x00EF8D0C
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

		// Token: 0x06035A04 RID: 219652 RVA: 0x00EFAB58 File Offset: 0x00EF8D58
		private UniTask PlaySelfAnimAsync(string sequence)
		{
			UiSequencePlayer sequencePlayer = this.SequencePlayer;
			if (sequencePlayer == null)
			{
				return UniTask.CompletedTask;
			}
			return sequencePlayer.PlaySequenceAsync(sequence, new CustomPromise<bool>(), false, false, null);
		}

		// Token: 0x06035A05 RID: 219653 RVA: 0x00EFAB8B File Offset: 0x00EF8D8B
		private UniTask PlayItemAnimAsync(string sequence)
		{
			if (this.ItemView == null)
			{
				return UniTask.CompletedTask;
			}
			return this.ItemView.PlayAnimAsync(sequence);
		}

		// Token: 0x06035A06 RID: 219654 RVA: 0x00EFABA8 File Offset: 0x00EF8DA8
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

		// Token: 0x06035A07 RID: 219655 RVA: 0x00EFAD60 File Offset: 0x00EF8F60
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

		// Token: 0x06035A08 RID: 219656 RVA: 0x00EFAE7C File Offset: 0x00EF907C
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

		// Token: 0x06035A09 RID: 219657 RVA: 0x00EFAF58 File Offset: 0x00EF9158
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

		// Token: 0x06035A0A RID: 219658 RVA: 0x00EFB0C9 File Offset: 0x00EF92C9
		public UniTask PlaySwapAsync(GridPosition to)
		{
			this.Pos = to;
			return this.TweenToCellAsync(to.Row, to.Col, 0.2f, LTweenEase.InOutSine);
		}

		// Token: 0x06035A0B RID: 219659 RVA: 0x00EFB0EC File Offset: 0x00EF92EC
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

		// Token: 0x06035A0C RID: 219660 RVA: 0x00EFB138 File Offset: 0x00EF9338
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

		// Token: 0x06035A0D RID: 219661 RVA: 0x00EFB22C File Offset: 0x00EF942C
		private void OnTweenLocation(FVector2D value)
		{
			UUIItem rootItem = this.RootItem;
			if (rootItem == null)
			{
				return;
			}
			rootItem.SetAnchorOffset(value);
		}

		// Token: 0x06035A0E RID: 219662 RVA: 0x00EFB23F File Offset: 0x00EF943F
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

		// Token: 0x06035A0F RID: 219663 RVA: 0x00EFB268 File Offset: 0x00EF9468
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

		// Token: 0x06035A10 RID: 219664 RVA: 0x00EFB2BC File Offset: 0x00EF94BC
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

		// Token: 0x0401C56A RID: 116074
		private GridPosition Pos;

		// Token: 0x0401C56D RID: 116077
		[Nullable(2)]
		private MatchThreePieceItemView ItemView;

		// Token: 0x0401C56E RID: 116078
		private readonly Dictionary<string, MatchThreePieceItemView> ItemViewCache = new Dictionary<string, MatchThreePieceItemView>();

		// Token: 0x0401C56F RID: 116079
		private readonly Dictionary<EMatchThreeResourceId, MatchThreePieceAdditionView> AdditionCache = new Dictionary<EMatchThreeResourceId, MatchThreePieceAdditionView>();

		// Token: 0x0401C570 RID: 116080
		private readonly HashSet<EMatchThreeResourceId> ActiveAdditions = new HashSet<EMatchThreeResourceId>();

		// Token: 0x0401C571 RID: 116081
		private readonly List<UniTask> AdditionShowTasks = new List<UniTask>();

		// Token: 0x0401C572 RID: 116082
		private const float SwapDuration = 0.2f;

		// Token: 0x0401C573 RID: 116083
		private const float FallDurationBase = 0.13f;

		// Token: 0x0401C574 RID: 116084
		[Nullable(2)]
		private ULTweener Tweener;

		// Token: 0x0401C575 RID: 116085
		[Nullable(2)]
		private AutoResetUniTaskCompletionSource Tcs;

		// Token: 0x0401C576 RID: 116086
		[Nullable(2)]
		private FLTweenVector2SetterDynamic MoveSetter;

		// Token: 0x0401C577 RID: 116087
		[Nullable(2)]
		private FLTweenFloatSetterDynamic FallSetter;

		// Token: 0x0401C578 RID: 116088
		[Nullable(2)]
		private Action CompleteAction;

		// Token: 0x0401C579 RID: 116089
		[Nullable(2)]
		private Action FallStarted;

		// Token: 0x0401C57A RID: 116090
		[Nullable(2)]
		private UCurveFloat FallCurve;

		// Token: 0x0401C57B RID: 116091
		private float FallCurveStart;

		// Token: 0x0401C57C RID: 116092
		private float FallCurveLand = 1f;

		// Token: 0x0401C57D RID: 116093
		private float FallCurveEnd = 1f;

		// Token: 0x0401C57E RID: 116094
		private readonly List<float> WayX = new List<float>();

		// Token: 0x0401C57F RID: 116095
		private readonly List<float> WayY = new List<float>();

		// Token: 0x0401C580 RID: 116096
		private readonly List<float> WayDist = new List<float>();

		// Token: 0x0401C581 RID: 116097
		private float WayTotal;

		// Token: 0x0401C582 RID: 116098
		private readonly Vector2D TempLocation = Vector2D.Create();

		// Token: 0x0401C583 RID: 116099
		private float HoldDuration;

		// Token: 0x0401C584 RID: 116100
		private float FlightDuration = 1f;

		// Token: 0x0401C585 RID: 116101
		private float BounceDuration;

		// Token: 0x0401C586 RID: 116102
		private float CellStepX;

		// Token: 0x0401C587 RID: 116103
		private float CellStepY;

		// Token: 0x0401C588 RID: 116104
		[Nullable(2)]
		private UiSequencePlayer SequencePlayer;

		// Token: 0x0401C589 RID: 116105
		[Nullable(2)]
		private AUIBaseActor SequenceActor;

		// Token: 0x0401C58A RID: 116106
		[Nullable(2)]
		private UniTaskCompletionSource RestartCleanRefreshGate;

		// Token: 0x0401C58B RID: 116107
		[Nullable(2)]
		private Piece RestartCleanTargetPiece;

		// Token: 0x0401C58C RID: 116108
		private bool RestartCleanOnReceived;

		// Token: 0x0401C58D RID: 116109
		private int RestartCleanVersion;

		// Token: 0x0401C58E RID: 116110
		private bool SkipInitialVisualReset;

		// Token: 0x0401C58F RID: 116111
		private bool Hinting;

		// Token: 0x0401C590 RID: 116112
		private bool PlayingHint;

		// Token: 0x0401C591 RID: 116113
		[Nullable(2)]
		private Action<GridPosition> PressedCallback;

		// Token: 0x0401C592 RID: 116114
		[Nullable(2)]
		private Action<GridPosition> EnteredCallback;

		// Token: 0x0401C593 RID: 116115
		[Nullable(2)]
		private Action ReleasedCallback;
	}
}
