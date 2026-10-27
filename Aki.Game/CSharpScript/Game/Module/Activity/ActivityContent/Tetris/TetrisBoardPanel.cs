using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Tetris
{
	// Token: 0x02005FF6 RID: 24566
	[NullableContext(1)]
	[Nullable(0)]
	public class TetrisBoardPanel : UiPanelBase
	{
		// Token: 0x0603E3D6 RID: 254934 RVA: 0x00F062A8 File Offset: 0x00F044A8
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIItem)),
				new ValueTuple<int, Type>(1, typeof(UUIItem))
			};
		}

		// Token: 0x0603E3D7 RID: 254935 RVA: 0x00F062E4 File Offset: 0x00F044E4
		protected override UniTask OnBeforeStartAsync()
		{
			TetrisBoardPanel.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<TetrisBoardPanel.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603E3D8 RID: 254936 RVA: 0x00F06328 File Offset: 0x00F04528
		[NullableContext(2)]
		public void RefreshView(TetrisBoardData data, bool isInit, bool isTakeBack = false)
		{
			if (data == null)
			{
				return;
			}
			this.CurrentBoardData = data;
			TetrisCellData[][] cells = data.Cells;
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
						TetrisCellData tetrisCellData = cells[i][j];
						if (tetrisCellData.IsOccupied)
						{
							itemView.Refresh(tetrisCellData);
							if (flag)
							{
								itemView.HideGrid();
								float num = 3.5f;
								float num2 = 3.5f;
								float num3 = Math.Abs((float)i - num) + Math.Abs((float)j - num2);
								TetrisCellData capturedCellData = tetrisCellData;
								TimerSystem.GameplayTimeInstance.Delay(delegate(float _)
								{
									itemView.Refresh(capturedCellData);
									itemView.PlayAnim("Start", null);
								}, (float)((int)(50f * num3)), null, null, true, 1f);
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

		// Token: 0x0603E3D9 RID: 254937 RVA: 0x00F06458 File Offset: 0x00F04658
		public void PlayLoseRefreshAnimation(TetrisBoardData data, TTimerAction onComplete)
		{
			this.CurrentBoardData = data;
			TetrisCellData[][] cells = data.Cells;
			for (int i = 0; i < 8; i++)
			{
				for (int j = 0; j < 8; j++)
				{
					TetrisBoardGridPanel tetrisBoardGridPanel;
					if (this.ListItems.TryGetValue(TetrisUtils.GenPosKey(i, j), out tetrisBoardGridPanel) && tetrisBoardGridPanel != null)
					{
						tetrisBoardGridPanel.RefreshWithColorId(tetrisBoardGridPanel.ColorId);
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
						TetrisCellData cellData = cells[k][l];
						TimerSystem.GameplayTimeInstance.Delay(delegate(float _)
						{
							TetrisBoardGridPanel itemView;
							itemView.RefreshWithColorId(cellData.ColorId);
							itemView = itemView;
							if (itemView == null)
							{
								return;
							}
							itemView.PlayAnim("Start", null);
						}, (float)num2, null, null, true, 1f);
					}
				}
			}
			AudioSystem.Instance.PostEvent("play_ui_cube_efx_stone");
			if (onComplete != null)
			{
				int num3 = 700;
				TimerSystem.GameplayTimeInstance.Delay(onComplete, (float)(num + num3), null, null, true, 1f);
			}
		}

		// Token: 0x0603E3DA RID: 254938 RVA: 0x00F0657C File Offset: 0x00F0477C
		[NullableContext(2)]
		public void PlayPlaceAnimation([TupleElementNames(new string[]
		{
			"Row",
			"Column"
		})] [Nullable(new byte[]
		{
			1,
			0
		})] List<ValueTuple<int, int>> positions, TTimerAction onComplete = null)
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
				int num = 500;
				TimerSystem.GameplayTimeInstance.Delay(onComplete, (float)num, null, null, true, 1f);
			}
		}

		// Token: 0x0603E3DB RID: 254939 RVA: 0x00F06614 File Offset: 0x00F04814
		public void PlayRemoveAnimation([TupleElementNames(new string[]
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
		})] List<ValueTuple<int, int, int>> sealChangePositions, List<int> clearedRows, List<int> clearedCols, [Nullable(2)] TTimerAction onComplete = null)
		{
			TetrisBoardPanel.<>c__DisplayClass9_0 CS$<>8__locals1 = new TetrisBoardPanel.<>c__DisplayClass9_0();
			CS$<>8__locals1.<>4__this = this;
			CS$<>8__locals1.rowSet = new HashSet<int>(clearedRows);
			CS$<>8__locals1.colSet = new HashSet<int>(clearedCols);
			CS$<>8__locals1.maxDelay = 0;
			foreach (ValueTuple<int, int, int> pos in positions)
			{
				CS$<>8__locals1.<PlayRemoveAnimation>g__playOne|0(pos, false);
			}
			foreach (ValueTuple<int, int, int> pos2 in sealChangePositions)
			{
				CS$<>8__locals1.<PlayRemoveAnimation>g__playOne|0(pos2, true);
			}
			if (onComplete != null)
			{
				int num = 1000;
				TimerSystem.GameplayTimeInstance.Delay(onComplete, (float)(CS$<>8__locals1.maxDelay + num), null, null, true, 1f);
			}
		}

		// Token: 0x0603E3DC RID: 254940 RVA: 0x00F066F8 File Offset: 0x00F048F8
		[NullableContext(2)]
		public void PlayCleanAnimation(TTimerAction onComplete = null)
		{
			int num = 0;
			for (int i = 0; i < 8; i++)
			{
				for (int j = 0; j < 8; j++)
				{
					int key = TetrisUtils.GenPosKey(i, j);
					TetrisBoardGridPanel itemView;
					if (this.ListItems.TryGetValue(key, out itemView))
					{
						int num2 = (i + j + 1) * 25;
						if (num2 > num)
						{
							num = num2;
						}
						TimerSystem.GameplayTimeInstance.Delay(delegate(float _)
						{
							itemView.HideGrid();
							itemView.PlayAnim("Clean", null);
						}, (float)num2, null, null, true, 1f);
					}
				}
			}
			if (onComplete != null)
			{
				int num3 = 700;
				TimerSystem.GameplayTimeInstance.Delay(onComplete, (float)(num + num3), null, null, true, 1f);
			}
		}

		// Token: 0x0603E3DD RID: 254941 RVA: 0x00F0679C File Offset: 0x00F0499C
		[NullableContext(2)]
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

		// Token: 0x0603E3DE RID: 254942 RVA: 0x00F068B4 File Offset: 0x00F04AB4
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

		// Token: 0x0603E3DF RID: 254943 RVA: 0x00F06998 File Offset: 0x00F04B98
		[NullableContext(2)]
		private TetrisCellData GetCellData(int row, int column)
		{
			if (this.CurrentBoardData == null)
			{
				return null;
			}
			return this.CurrentBoardData.Cells[row][column];
		}

		// Token: 0x0603E3E0 RID: 254944 RVA: 0x00F069B4 File Offset: 0x00F04BB4
		[NullableContext(2)]
		public TetrisBoardGridPanel GetGridPanel(int row, int column)
		{
			TetrisBoardGridPanel result;
			if (this.ListItems.TryGetValue(TetrisUtils.GenPosKey(row, column), out result))
			{
				return result;
			}
			return null;
		}

		// Token: 0x0603E3E1 RID: 254945 RVA: 0x00F069DC File Offset: 0x00F04BDC
		private UniTask CreateShape(UUIItem itemTemplate, UUIItem list, [TupleElementNames(new string[]
		{
			"R",
			"C"
		})] [Nullable(0)] ValueTuple<int, int> offset)
		{
			TetrisBoardPanel.<CreateShape>d__15 <CreateShape>d__;
			<CreateShape>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateShape>d__.<>4__this = this;
			<CreateShape>d__.itemTemplate = itemTemplate;
			<CreateShape>d__.list = list;
			<CreateShape>d__.offset = offset;
			<CreateShape>d__.<>1__state = -1;
			<CreateShape>d__.<>t__builder.Start<TetrisBoardPanel.<CreateShape>d__15>(ref <CreateShape>d__);
			return <CreateShape>d__.<>t__builder.Task;
		}

		// Token: 0x0603E3E2 RID: 254946 RVA: 0x00F06A38 File Offset: 0x00F04C38
		private UniTask CreateItemTemplate(UUIItem item, TetrisBoardGridPanel itemView)
		{
			TetrisBoardPanel.<CreateItemTemplate>d__16 <CreateItemTemplate>d__;
			<CreateItemTemplate>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateItemTemplate>d__.<>4__this = this;
			<CreateItemTemplate>d__.item = item;
			<CreateItemTemplate>d__.itemView = itemView;
			<CreateItemTemplate>d__.<>1__state = -1;
			<CreateItemTemplate>d__.<>t__builder.Start<TetrisBoardPanel.<CreateItemTemplate>d__16>(ref <CreateItemTemplate>d__);
			return <CreateItemTemplate>d__.<>t__builder.Task;
		}

		// Token: 0x0603E3E3 RID: 254947 RVA: 0x00F06A8B File Offset: 0x00F04C8B
		protected override void OnBeforeDestroy()
		{
			this.ListItems.Clear();
		}

		// Token: 0x04020824 RID: 133156
		private readonly Dictionary<int, TetrisBoardGridPanel> ListItems = new Dictionary<int, TetrisBoardGridPanel>();

		// Token: 0x04020825 RID: 133157
		private readonly HashSet<int> DragHighlightedPositions = new HashSet<int>();

		// Token: 0x04020826 RID: 133158
		private readonly HashSet<int> RemovingPositions = new HashSet<int>();

		// Token: 0x04020827 RID: 133159
		[Nullable(2)]
		private TetrisBoardData CurrentBoardData;
	}
}
