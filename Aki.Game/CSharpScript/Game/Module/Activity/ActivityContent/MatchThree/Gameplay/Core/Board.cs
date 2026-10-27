using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay.Core.Components;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay.Core
{
	// Token: 0x02006527 RID: 25895
	[NullableContext(1)]
	[Nullable(0)]
	public class Board
	{
		// Token: 0x06040EE5 RID: 265957 RVA: 0x00FBBF1C File Offset: 0x00FBA11C
		public Board()
		{
			this.Cells = new Cell[7, 8];
			for (int i = 0; i < 7; i++)
			{
				for (int j = 0; j < 8; j++)
				{
					this.Cells[i, j] = new Cell();
				}
			}
		}

		// Token: 0x06040EE6 RID: 265958 RVA: 0x00FBBF92 File Offset: 0x00FBA192
		public bool InBounds(int row, int col)
		{
			return row >= 0 && row < 7 && col >= 0 && col < 8;
		}

		// Token: 0x06040EE7 RID: 265959 RVA: 0x00FBBFA8 File Offset: 0x00FBA1A8
		[NullableContext(2)]
		public Piece GetPiece(int row, int col)
		{
			return this.Cells[row, col].Piece;
		}

		// Token: 0x06040EE8 RID: 265960 RVA: 0x00FBBFBC File Offset: 0x00FBA1BC
		[NullableContext(2)]
		public void SetPiece(int row, int col, Piece piece)
		{
			this.Cells[row, col].Piece = piece;
		}

		// Token: 0x06040EE9 RID: 265961 RVA: 0x00FBBFD4 File Offset: 0x00FBA1D4
		public void SwapPiece(GridPosition a, GridPosition b)
		{
			Cell cell = this.Cells[a.Row, a.Col];
			Cell cell2 = this.Cells[b.Row, b.Col];
			Piece piece = this.Cells[b.Row, b.Col].Piece;
			Piece piece2 = this.Cells[a.Row, a.Col].Piece;
			cell.Piece = piece;
			cell2.Piece = piece2;
		}

		// Token: 0x06040EEA RID: 265962 RVA: 0x00FBC058 File Offset: 0x00FBA258
		public bool HasPieceWithComponentType(EPieceComponentType componentType)
		{
			return this.FindFirstPieceWithComponentTypes(new EPieceComponentType[]
			{
				componentType
			}) != null;
		}

		// Token: 0x06040EEB RID: 265963 RVA: 0x00FBC080 File Offset: 0x00FBA280
		public GridPosition? FindFirstPieceWithComponentTypes(EPieceComponentType[] componentTypes)
		{
			if (componentTypes == null || componentTypes.Length == 0)
			{
				return null;
			}
			for (int i = 0; i < 7; i++)
			{
				for (int j = 0; j < 8; j++)
				{
					Piece piece = this.Cells[i, j].Piece;
					if (piece != null)
					{
						foreach (IPieceComponent comp in piece.Components)
						{
							if (Array.IndexOf<EPieceComponentType>(componentTypes, PieceComponentFactory.GetComponentType(comp)) >= 0)
							{
								return new GridPosition?(new GridPosition(i, j));
							}
						}
					}
				}
			}
			return null;
		}

		// Token: 0x06040EEC RID: 265964 RVA: 0x00FBC138 File Offset: 0x00FBA338
		public Piece RentPiece()
		{
			Piece piece = (this.PiecePool.Count > 0) ? this.PiecePool.Pop() : new Piece();
			piece.Reset();
			return piece;
		}

		// Token: 0x06040EED RID: 265965 RVA: 0x00FBC160 File Offset: 0x00FBA360
		public Piece RentPiece(EPieceType type, [Nullable(2)] int[] extraComponentIds = null)
		{
			Piece piece = this.RentPiece();
			this.AssignProto(piece, type, extraComponentIds);
			return piece;
		}

		// Token: 0x06040EEE RID: 265966 RVA: 0x00FBC180 File Offset: 0x00FBA380
		[NullableContext(2)]
		public Piece ReplacePiece(int row, int col, EPieceType type, int[] extraComponentIds = null)
		{
			if (this.Cells[row, col].Piece == null)
			{
				return null;
			}
			Piece piece = this.RentPiece(type, extraComponentIds);
			this.SwapInPiece(row, col, piece);
			return piece;
		}

		// Token: 0x06040EEF RID: 265967 RVA: 0x00FBC1B8 File Offset: 0x00FBA3B8
		[NullableContext(2)]
		public Piece RecolorPiece(int row, int col, EPieceType targetType)
		{
			Piece piece = this.Cells[row, col].Piece;
			if (piece == null)
			{
				return null;
			}
			if (!MatchThreeGameplayDefine.NormalPieceTypes.Contains(piece.Type) || !MatchThreeGameplayDefine.NormalPieceTypes.Contains(targetType))
			{
				return null;
			}
			if (piece.Type == targetType)
			{
				return piece;
			}
			Piece piece2 = this.CloneForEdit(row, col);
			if (piece2 == null)
			{
				return null;
			}
			piece2.Type = targetType;
			this.SwapInPiece(row, col, piece2);
			return piece2;
		}

		// Token: 0x06040EF0 RID: 265968 RVA: 0x00FBC228 File Offset: 0x00FBA428
		[return: Nullable(2)]
		public Piece AppendComponents(int row, int col, int[] extraComponentIds)
		{
			Piece piece = this.CloneForEdit(row, col);
			if (piece == null)
			{
				return null;
			}
			for (int i = 0; i < extraComponentIds.Length; i++)
			{
				IPieceComponent pieceComponent = PieceComponentFactory.Create(extraComponentIds[i]);
				if (pieceComponent != null)
				{
					piece.Append(pieceComponent);
				}
			}
			this.SwapInPiece(row, col, piece);
			return piece;
		}

		// Token: 0x06040EF1 RID: 265969 RVA: 0x00FBC270 File Offset: 0x00FBA470
		[NullableContext(2)]
		private Piece CloneForEdit(int row, int col)
		{
			Piece piece = this.Cells[row, col].Piece;
			if (piece == null)
			{
				return null;
			}
			Piece piece2 = this.RentPiece();
			piece2.CopyFrom(piece);
			return piece2;
		}

		// Token: 0x06040EF2 RID: 265970 RVA: 0x00FBC2A4 File Offset: 0x00FBA4A4
		private void SwapInPiece(int row, int col, Piece piece)
		{
			Piece piece2 = this.Cells[row, col].Piece;
			this.Cells[row, col].Piece = piece;
			if (piece2 != null)
			{
				this.ReturnPiece(piece2);
			}
		}

		// Token: 0x06040EF3 RID: 265971 RVA: 0x00FBC2E4 File Offset: 0x00FBA4E4
		private void AssignProto(Piece piece, EPieceType type, [Nullable(2)] int[] extraComponentIds)
		{
			PiecePrototype proto = this.GetProto(type);
			piece.Type = type;
			if (extraComponentIds == null || extraComponentIds.Length == 0)
			{
				piece.Assign(proto.Components, proto.Caps);
				return;
			}
			List<IPieceComponent> list = new List<IPieceComponent>(proto.Components.Count + extraComponentIds.Length);
			foreach (IPieceComponent item in proto.Components)
			{
				list.Add(item);
			}
			EPieceCaps epieceCaps = proto.Caps;
			for (int i = 0; i < extraComponentIds.Length; i++)
			{
				IPieceComponent pieceComponent = PieceComponentFactory.Create(extraComponentIds[i]);
				if (pieceComponent != null)
				{
					list.Add(pieceComponent);
					epieceCaps |= pieceComponent.Caps;
				}
			}
			piece.Assign(list, epieceCaps);
		}

		// Token: 0x06040EF4 RID: 265972 RVA: 0x00FBC3B8 File Offset: 0x00FBA5B8
		public void ReturnPiece(Piece piece)
		{
			this.RecycleCurrent.Add(piece);
		}

		// Token: 0x06040EF5 RID: 265973 RVA: 0x00FBC3C8 File Offset: 0x00FBA5C8
		public void RotateRecycleBuffer()
		{
			for (int i = 0; i < this.RecyclePrevious.Count; i++)
			{
				this.PiecePool.Push(this.RecyclePrevious[i]);
			}
			this.RecyclePrevious.Clear();
			List<Piece> recyclePrevious = this.RecyclePrevious;
			List<Piece> recycleCurrent = this.RecycleCurrent;
			this.RecycleCurrent = recyclePrevious;
			this.RecyclePrevious = recycleCurrent;
		}

		// Token: 0x06040EF6 RID: 265974 RVA: 0x00FBC42C File Offset: 0x00FBA62C
		public void ClearPiece(int row, int col)
		{
			Piece piece = this.Cells[row, col].Piece;
			if (piece != null)
			{
				this.Cells[row, col].Piece = null;
				this.ReturnPiece(piece);
			}
		}

		// Token: 0x06040EF7 RID: 265975 RVA: 0x00FBC46C File Offset: 0x00FBA66C
		[NullableContext(0)]
		[return: TupleElementNames(new string[]
		{
			"Energy",
			"Score"
		})]
		public ValueTuple<int, int> GetPieceGain(EPieceType type)
		{
			PiecePrototype proto = this.GetProto(type);
			return new ValueTuple<int, int>(proto.Energy, proto.Score);
		}

		// Token: 0x06040EF8 RID: 265976 RVA: 0x00FBC494 File Offset: 0x00FBA694
		private PiecePrototype GetProto(EPieceType type)
		{
			PiecePrototype piecePrototype;
			if (this.ProtoByType.TryGetValue(type, out piecePrototype))
			{
				return piecePrototype;
			}
			MatchThreePiece? pieceConfig = MatchThreeConfig.Instance.GetPieceConfig((int)type);
			List<IPieceComponent> list = new List<IPieceComponent>();
			EPieceCaps epieceCaps = EPieceCaps.None;
			if (pieceConfig != null)
			{
				int[] bornComponentsArray = pieceConfig.Value.GetBornComponentsArray();
				if (bornComponentsArray != null)
				{
					int[] array = bornComponentsArray;
					for (int i = 0; i < array.Length; i++)
					{
						IPieceComponent pieceComponent = PieceComponentFactory.Create(array[i]);
						if (pieceComponent != null)
						{
							list.Add(pieceComponent);
							epieceCaps |= pieceComponent.Caps;
						}
					}
				}
			}
			piecePrototype = new PiecePrototype(list, epieceCaps, (pieceConfig != null) ? pieceConfig.GetValueOrDefault().Energy : 0, (pieceConfig != null) ? pieceConfig.GetValueOrDefault().Score : 0);
			this.ProtoByType[type] = piecePrototype;
			return piecePrototype;
		}

		// Token: 0x06040EF9 RID: 265977 RVA: 0x00FBC570 File Offset: 0x00FBA770
		public unsafe bool Apply(int boardId)
		{
			IReadOnlyList<MatchThreeBoard> boardConfigList = MatchThreeConfig.Instance.GetBoardConfigList(boardId);
			if (boardConfigList == null || boardConfigList.Count != 7)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.MatchThree;
				ELogAuthor author = ELogAuthor.CB;
				string message = "初始棋盘配置缺失或行数不符";
				<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("BoardId", boardId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("行数", (boardConfigList != null) ? boardConfigList.Count : 0);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("棋盘", 7);
				instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
				return false;
			}
			for (int i = 0; i < 7; i++)
			{
				MatchThreeBoard row = boardConfigList[i];
				for (int j = 0; j < 8; j++)
				{
					this.ClearPiece(i, j);
					int[] columnArray = Board.GetColumnArray(row, j);
					if (columnArray != null && columnArray.Length != 0 && columnArray[0] != 0)
					{
						this.SetPiece(i, j, this.RentPiece((EPieceType)columnArray[0], (columnArray.Length > 1) ? RuntimeHelpers.GetSubArray<int>(columnArray, Range.StartAt(1)) : null));
					}
				}
			}
			return true;
		}

		// Token: 0x06040EFA RID: 265978 RVA: 0x00FBC698 File Offset: 0x00FBA898
		[NullableContext(2)]
		private static int[] GetColumnArray(MatchThreeBoard row, int col)
		{
			int[] result;
			switch (col)
			{
			case 0:
				result = row.GetColumn1Array();
				break;
			case 1:
				result = row.GetColumn2Array();
				break;
			case 2:
				result = row.GetColumn3Array();
				break;
			case 3:
				result = row.GetColumn4Array();
				break;
			case 4:
				result = row.GetColumn5Array();
				break;
			case 5:
				result = row.GetColumn6Array();
				break;
			case 6:
				result = row.GetColumn7Array();
				break;
			case 7:
				result = row.GetColumn8Array();
				break;
			default:
				result = null;
				break;
			}
			return result;
		}

		// Token: 0x04021DEA RID: 138730
		private readonly Cell[,] Cells;

		// Token: 0x04021DEB RID: 138731
		private readonly System.Collections.Generic.Stack<Piece> PiecePool = new System.Collections.Generic.Stack<Piece>();

		// Token: 0x04021DEC RID: 138732
		private List<Piece> RecycleCurrent = new List<Piece>();

		// Token: 0x04021DED RID: 138733
		private List<Piece> RecyclePrevious = new List<Piece>();

		// Token: 0x04021DEE RID: 138734
		private readonly Dictionary<EPieceType, PiecePrototype> ProtoByType = new Dictionary<EPieceType, PiecePrototype>();
	}
}
