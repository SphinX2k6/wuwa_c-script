using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace Aki.Game.Module.Activity.ActivityContent.Tetris.View
{
	// Token: 0x02002FC2 RID: 12226
	[NullableContext(2)]
	[Nullable(0)]
	public class TetrisBoardPanel : UiPanelBase
	{
		// Token: 0x0601D062 RID: 118882 RVA: 0x008DCF60 File Offset: 0x008DB160
		protected unsafe override void OnRegisterComponent()
		{
			int num = 2;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0601D063 RID: 118883 RVA: 0x008DCFCC File Offset: 0x008DB1CC
		protected override UniTask OnBeforeStartAsync()
		{
			TetrisBoardPanel.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<TetrisBoardPanel.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0601D064 RID: 118884 RVA: 0x008DD010 File Offset: 0x008DB210
		public void RefreshView(TetrisBoardData data, bool isInit, bool isTakeBack = false)
		{
			if (data == null)
			{
				return;
			}
			this.CurrentBoardData = data;
			TetrisCellData[,] cells = data.Cells;
			bool flag = isInit || isTakeBack;
			if (flag)
			{
				AudioSystem.Instance.PostEvent("play_ui_cube_efx_up");
			}
			for (int i = 0; i < 8; i++)
			{
				for (int j = 0; j < 8; j++)
				{
					TetrisBoardGridPanel itemView;
					if (this.ListItems.TryGetValue(TetrisUtils.GenPosKey(i, j), out itemView))
					{
						TetrisCellData tetrisCellData = cells[i, j];
						if (tetrisCellData.IsOccupied)
						{
							itemView.Refresh(tetrisCellData);
							if (flag)
							{
								itemView.HideGrid();
								float num = Math.Abs((float)i - 3.5f) + Math.Abs((float)j - 3.5f);
								TetrisCellData capturedCellData = tetrisCellData;
								TimerSystem.GameplayTimeInstance.Delay(this.GuardTimerCallback(delegate(float _)
								{
									itemView.Refresh(capturedCellData);
									itemView.PlayAnim("Start", null);
								}), 50f * num, null, null, true, 1f);
							}
						}
						else
						{
							int item = TetrisUtils.GenPosKey(i, j);
							if (!this.RemovingPositions.Contains(item))
							{
								itemView.HideGrid();
							}
						}
					}
				}
			}
		}

		// Token: 0x0601D065 RID: 118885 RVA: 0x008DD13C File Offset: 0x008DB33C
		[NullableContext(1)]
		public void PlayLoseRefreshAnimation(TetrisBoardData data, [Nullable(2)] Action onComplete)
		{
			this.CurrentBoardData = data;
			TetrisCellData[,] cells = data.Cells;
			for (int i = 0; i < 8; i++)
			{
				for (int j = 0; j < 8; j++)
				{
					TetrisBoardGridPanel tetrisBoardGridPanel;
					if (this.ListItems.TryGetValue(TetrisUtils.GenPosKey(i, j), out tetrisBoardGridPanel))
					{
						tetrisBoardGridPanel.RefreshWithColorId(tetrisBoardGridPanel.ColorId, EBombType.None);
					}
				}
			}
			int num = 0;
			for (int k = 0; k < 8; k++)
			{
				for (int l = 0; l < 8; l++)
				{
					int key = TetrisUtils.GenPosKey(k, l);
					TetrisBoardGridPanel itemView;
					if (this.ListItems.TryGetValue(key, out itemView))
					{
						int num2 = (k + l + 1) * 25;
						if (num2 > num)
						{
							num = num2;
						}
						TetrisCellData cellData = cells[k, l];
						TimerSystem.GameplayTimeInstance.Delay(this.GuardTimerCallback(delegate(float _)
						{
							itemView.RefreshWithColorId(cellData.ColorId, EBombType.None);
							itemView.PlayAnim("Start", null);
						}), (float)num2, null, null, true, 1f);
					}
				}
			}
			AudioSystem.Instance.PostEvent("play_ui_cube_efx_stone");
			if (onComplete != null)
			{
				TimerSystem.GameplayTimeInstance.Delay(this.GuardTimerCallback(delegate(float _)
				{
					onComplete();
				}), (float)(num + 700), null, null, true, 1f);
			}
		}

		// Token: 0x0601D066 RID: 118886 RVA: 0x008DD28C File Offset: 0x008DB48C
		public void PlayPlaceAnimation([TupleElementNames(new string[]
		{
			"Row",
			"Column"
		})] [Nullable(new byte[]
		{
			1,
			0
		})] IReadOnlyList<ValueTuple<int, int>> positions, Action onComplete = null)
		{
			foreach (ValueTuple<int, int> valueTuple in positions)
			{
				int key = TetrisUtils.GenPosKey(valueTuple.Item1, valueTuple.Item2);
				TetrisBoardGridPanel tetrisBoardGridPanel;
				if (this.ListItems.TryGetValue(key, out tetrisBoardGridPanel))
				{
					tetrisBoardGridPanel.PlayAnim("Up", null);
				}
			}
			if (onComplete != null)
			{
				TimerSystem.GameplayTimeInstance.Delay(this.GuardTimerCallback(delegate(float _)
				{
					onComplete();
				}), 500f, null, null, true, 1f);
			}
		}

		// Token: 0x0601D067 RID: 118887 RVA: 0x008DD33C File Offset: 0x008DB53C
		public void PlayRemoveAnimation(TetrisClearInfo clearInfo, Action onNext = null, Action onComplete = null)
		{
			TetrisBoardPanel.<>c__DisplayClass10_0 CS$<>8__locals1 = new TetrisBoardPanel.<>c__DisplayClass10_0();
			CS$<>8__locals1.onNext = onNext;
			CS$<>8__locals1.onComplete = onComplete;
			CS$<>8__locals1.<>4__this = this;
			CS$<>8__locals1.clearInfo = clearInfo;
			HashSet<int> hashSet = new HashSet<int>();
			foreach (int item in CS$<>8__locals1.clearInfo.ClearedRows)
			{
				hashSet.Add(item);
			}
			CS$<>8__locals1.rowSet = hashSet;
			hashSet = new HashSet<int>();
			foreach (int item in CS$<>8__locals1.clearInfo.ClearedCols)
			{
				hashSet.Add(item);
			}
			CS$<>8__locals1.colSet = hashSet;
			CS$<>8__locals1.maxDelay = 0;
			foreach (ValueTuple<int, int, int> pos in CS$<>8__locals1.clearInfo.ClearedPositions)
			{
				CS$<>8__locals1.<PlayRemoveAnimation>g__playOne|0(pos, false);
			}
			foreach (ValueTuple<int, int, int> pos2 in CS$<>8__locals1.clearInfo.SealChangePositions)
			{
				CS$<>8__locals1.<PlayRemoveAnimation>g__playOne|0(pos2, true);
			}
			foreach (ValueTuple<int, int, int> valueTuple in CS$<>8__locals1.clearInfo.TriggeredBombs)
			{
				int key = TetrisUtils.GenPosKey(valueTuple.Item1, valueTuple.Item2);
				TetrisBoardGridPanel tetrisBoardGridPanel;
				if (this.ListItems.TryGetValue(key, out tetrisBoardGridPanel))
				{
					tetrisBoardGridPanel.RefreshWithColorId(valueTuple.Item3, EBombType.Bomb);
					tetrisBoardGridPanel.PlayAnim("Bomb", null);
				}
			}
			foreach (ValueTuple<int, int, int> valueTuple2 in CS$<>8__locals1.clearInfo.TriggeredSuperBombs)
			{
				int key2 = TetrisUtils.GenPosKey(valueTuple2.Item1, valueTuple2.Item2);
				TetrisBoardGridPanel tetrisBoardGridPanel2;
				if (this.ListItems.TryGetValue(key2, out tetrisBoardGridPanel2))
				{
					tetrisBoardGridPanel2.RefreshWithColorId(valueTuple2.Item3, EBombType.SuperBomb);
					tetrisBoardGridPanel2.PlayAnim("Bomb2", null);
				}
			}
			if (CS$<>8__locals1.clearInfo.HasTriggeredBombs)
			{
				if (CS$<>8__locals1.onNext != null)
				{
					TimerSystem.GameplayTimeInstance.Delay(this.GuardTimerCallback(delegate(float _)
					{
						CS$<>8__locals1.onNext();
					}), 550f, null, null, true, 1f);
				}
			}
			else
			{
				Action onNext2 = CS$<>8__locals1.onNext;
				if (onNext2 != null)
				{
					onNext2();
				}
			}
			if (CS$<>8__locals1.clearInfo.HasRemoveAnimation)
			{
				if (CS$<>8__locals1.onComplete != null)
				{
					TimerSystem.GameplayTimeInstance.Delay(this.GuardTimerCallback(delegate(float _)
					{
						CS$<>8__locals1.onComplete();
					}), (float)(CS$<>8__locals1.maxDelay + 1000), null, null, true, 1f);
					return;
				}
			}
			else
			{
				Action onComplete2 = CS$<>8__locals1.onComplete;
				if (onComplete2 == null)
				{
					return;
				}
				onComplete2();
			}
		}

		// Token: 0x0601D068 RID: 118888 RVA: 0x008DD5B4 File Offset: 0x008DB7B4
		public void PlayCleanAnimation(bool isReset, Action onComplete = null)
		{
			float num = 0f;
			for (int i = 0; i < 8; i++)
			{
				for (int j = 0; j < 8; j++)
				{
					int key = TetrisUtils.GenPosKey(i, j);
					TetrisBoardGridPanel itemView;
					if (this.ListItems.TryGetValue(key, out itemView))
					{
						float num2 = (float)((i + j + 1) * 25);
						float num3 = num2 + 1000f;
						TetrisCellData cellData = this.GetCellData(i, j);
						if (cellData != null)
						{
							if (cellData.Type == ECellType.Fixed)
							{
								if (!isReset)
								{
									num3 += 500f;
								}
							}
							else
							{
								itemView.HideGrid();
							}
							if (num < num3)
							{
								num = num3;
							}
							Action onCleanAnimationComplete = (cellData.Type == ECellType.Fixed && !isReset) ? this.GuardCallback(delegate
							{
								itemView.PlayAnim("Start", null);
							}) : null;
							TimerSystem.GameplayTimeInstance.Delay(this.GuardTimerCallback(delegate(float _)
							{
								itemView.PlayAnim("Clean", onCleanAnimationComplete);
							}), num2, null, null, true, 1f);
						}
					}
				}
			}
			if (onComplete != null)
			{
				TimerSystem.GameplayTimeInstance.Delay(this.GuardTimerCallback(delegate(float _)
				{
					onComplete();
				}), num, null, null, true, 1f);
			}
		}

		// Token: 0x0601D069 RID: 118889 RVA: 0x008DD710 File Offset: 0x008DB910
		public void ShowDragHighlight([TupleElementNames(new string[]
		{
			"Row",
			"Column"
		})] [Nullable(new byte[]
		{
			1,
			0
		})] List<ValueTuple<int, int>> positions, int colorId, List<int> clearAbleRows = null, List<int> clearAbleCols = null)
		{
			if (clearAbleRows == null)
			{
				clearAbleRows = new List<int>();
			}
			if (clearAbleCols == null)
			{
				clearAbleCols = new List<int>();
			}
			foreach (ValueTuple<int, int> valueTuple in positions)
			{
				int num = TetrisUtils.GenPosKey(valueTuple.Item1, valueTuple.Item2);
				TetrisBoardGridPanel tetrisBoardGridPanel;
				if (this.ListItems.TryGetValue(num, out tetrisBoardGridPanel))
				{
					this.DragHighlightedPositions.Add(num);
					tetrisBoardGridPanel.ShowDragFrame(colorId);
				}
			}
			HashSet<int> hashSet = new HashSet<int>(clearAbleRows);
			HashSet<int> hashSet2 = new HashSet<int>(clearAbleCols);
			foreach (KeyValuePair<int, TetrisBoardGridPanel> keyValuePair in this.ListItems)
			{
				TetrisBoardGridPanel value = keyValuePair.Value;
				bool flag = hashSet.Contains(value.Row);
				bool flag2 = hashSet2.Contains(value.Column);
				value.SetMaskItemActive(flag || flag2);
			}
		}

		// Token: 0x0601D06A RID: 118890 RVA: 0x008DD828 File Offset: 0x008DBA28
		public void ClearDragHighlight()
		{
			foreach (int key in this.DragHighlightedPositions)
			{
				TetrisBoardGridPanel tetrisBoardGridPanel;
				if (this.ListItems.TryGetValue(key, out tetrisBoardGridPanel))
				{
					tetrisBoardGridPanel.HideDragFrame();
					TetrisCellData cellData = this.GetCellData(tetrisBoardGridPanel.Row, tetrisBoardGridPanel.Column);
					if (cellData != null && cellData.IsOccupied)
					{
						tetrisBoardGridPanel.Refresh(cellData);
					}
					else
					{
						tetrisBoardGridPanel.HideGrid();
					}
				}
			}
			this.DragHighlightedPositions.Clear();
			foreach (KeyValuePair<int, TetrisBoardGridPanel> keyValuePair in this.ListItems)
			{
				keyValuePair.Value.SetMaskItemActive(false);
			}
		}

		// Token: 0x0601D06B RID: 118891 RVA: 0x008DD90C File Offset: 0x008DBB0C
		private TetrisCellData GetCellData(int row, int column)
		{
			TetrisBoardData currentBoardData = this.CurrentBoardData;
			if (currentBoardData == null)
			{
				return null;
			}
			return currentBoardData.Cells[row, column];
		}

		// Token: 0x0601D06C RID: 118892 RVA: 0x008DD926 File Offset: 0x008DBB26
		public TetrisBoardGridPanel GetGridPanel(int row, int column)
		{
			return this.ListItems.GetValueOrDefault(TetrisUtils.GenPosKey(row, column));
		}

		// Token: 0x0601D06D RID: 118893 RVA: 0x008DD93C File Offset: 0x008DBB3C
		[NullableContext(1)]
		private UniTask CreateShape(UUIItem itemTemplate, UUIItem list, [TupleElementNames(new string[]
		{
			"R",
			"C"
		})] [Nullable(0)] ValueTuple<int, int> offset)
		{
			TetrisBoardPanel.<CreateShape>d__16 <CreateShape>d__;
			<CreateShape>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateShape>d__.<>4__this = this;
			<CreateShape>d__.itemTemplate = itemTemplate;
			<CreateShape>d__.list = list;
			<CreateShape>d__.offset = offset;
			<CreateShape>d__.<>1__state = -1;
			<CreateShape>d__.<>t__builder.Start<TetrisBoardPanel.<CreateShape>d__16>(ref <CreateShape>d__);
			return <CreateShape>d__.<>t__builder.Task;
		}

		// Token: 0x0601D06E RID: 118894 RVA: 0x008DD998 File Offset: 0x008DBB98
		[NullableContext(1)]
		private UniTask CreateItemTemplate(UUIItem item, TetrisBoardGridPanel itemView)
		{
			TetrisBoardPanel.<CreateItemTemplate>d__17 <CreateItemTemplate>d__;
			<CreateItemTemplate>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateItemTemplate>d__.<>4__this = this;
			<CreateItemTemplate>d__.item = item;
			<CreateItemTemplate>d__.itemView = itemView;
			<CreateItemTemplate>d__.<>1__state = -1;
			<CreateItemTemplate>d__.<>t__builder.Start<TetrisBoardPanel.<CreateItemTemplate>d__17>(ref <CreateItemTemplate>d__);
			return <CreateItemTemplate>d__.<>t__builder.Task;
		}

		// Token: 0x0601D06F RID: 118895 RVA: 0x008DD9EB File Offset: 0x008DBBEB
		protected override void OnBeforeDestroy()
		{
			this.ListItems.Clear();
		}

		// Token: 0x0601D070 RID: 118896 RVA: 0x008DD9F8 File Offset: 0x008DBBF8
		private Action GuardCallback(Action callback)
		{
			if (callback == null)
			{
				return null;
			}
			return delegate()
			{
				if (this.WaitToDestroy || this.IsDestroyOrDestroying || this.IsPendingDestroy)
				{
					return;
				}
				callback();
			};
		}

		// Token: 0x0601D071 RID: 118897 RVA: 0x008DDA2F File Offset: 0x008DBC2F
		[NullableContext(1)]
		private TTimerAction GuardTimerCallback(TTimerAction callback)
		{
			return delegate(float delta)
			{
				if (this.WaitToDestroy || this.IsDestroyOrDestroying || this.IsPendingDestroy)
				{
					return;
				}
				callback(delta);
			};
		}

		// Token: 0x0400F483 RID: 62595
		[Nullable(1)]
		private readonly Dictionary<int, TetrisBoardGridPanel> ListItems = new Dictionary<int, TetrisBoardGridPanel>();

		// Token: 0x0400F484 RID: 62596
		[Nullable(1)]
		private readonly HashSet<int> DragHighlightedPositions = new HashSet<int>();

		// Token: 0x0400F485 RID: 62597
		[Nullable(1)]
		private readonly HashSet<int> RemovingPositions = new HashSet<int>();

		// Token: 0x0400F486 RID: 62598
		private TetrisBoardData CurrentBoardData;

		// Token: 0x02008C3D RID: 35901
		[NullableContext(0)]
		private static class EComponents
		{
			// Token: 0x0402C63E RID: 181822
			public const int GridItem = 0;

			// Token: 0x0402C63F RID: 181823
			public const int List = 1;
		}
	}
}
