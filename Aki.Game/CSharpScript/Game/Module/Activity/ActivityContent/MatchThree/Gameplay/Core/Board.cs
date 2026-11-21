using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay.Core.Components;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay.Core
{
	// Token: 0x020054A5 RID: 21669
	[NullableContext(1)]
	[Nullable(0)]
	public class Board
	{
		// Token: 0x06035BA9 RID: 220073 RVA: 0x00F02F4C File Offset: 0x00F0114C
		public Board()
		{
			this.Cells = new Cell[56];
			for (int i = 0; i < 7; i++)
			{
				for (int j = 0; j < 8; j++)
				{
					this.Cells[Board.CellIndex(i, j)] = new Cell();
				}
			}
		}

		// Token: 0x06035BAA RID: 220074 RVA: 0x00F02FC3 File Offset: 0x00F011C3
		private static int CellIndex(int row, int col)
		{
			return row * 8 + col;
		}

		// Token: 0x06035BAB RID: 220075 RVA: 0x00F02FCA File Offset: 0x00F011CA
		public bool InBounds(int row, int col)
		{
			return row >= 0 && row < 7 && col >= 0 && col < 8;
		}

		// Token: 0x06035BAC RID: 220076 RVA: 0x00F02FE0 File Offset: 0x00F011E0
		[NullableContext(2)]
		public Piece GetPiece(int row, int col)
		{
			return this.Cells[Board.CellIndex(row, col)].Piece;
		}

		// Token: 0x06035BAD RID: 220077 RVA: 0x00F02FF5 File Offset: 0x00F011F5
		[NullableContext(2)]
		public void SetPiece(int row, int col, Piece piece)
		{
			this.Cells[Board.CellIndex(row, col)].Piece = piece;
		}

		// Token: 0x06035BAE RID: 220078 RVA: 0x00F0300C File Offset: 0x00F0120C
		public void SwapPiece(GridPosition a, GridPosition b)
		{
			Cell cell = this.Cells[Board.CellIndex(a.Row, a.Col)];
			Cell cell2 = this.Cells[Board.CellIndex(b.Row, b.Col)];
			Piece piece = this.Cells[Board.CellIndex(b.Row, b.Col)].Piece;
			Piece piece2 = this.Cells[Board.CellIndex(a.Row, a.Col)].Piece;
			cell.Piece = piece;
			cell2.Piece = piece2;
		}

		// Token: 0x06035BAF RID: 220079 RVA: 0x00F03094 File Offset: 0x00F01294
		public bool HasPieceWithComponentType(EPieceComponentType componentType)
		{
			return this.FindFirstPieceWithComponentTypes(new EPieceComponentType[]
			{
				componentType
			}) != null;
		}

		// Token: 0x06035BB0 RID: 220080 RVA: 0x00F030BC File Offset: 0x00F012BC
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
					Piece piece = this.Cells[Board.CellIndex(i, j)].Piece;
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

		// Token: 0x06035BB1 RID: 220081 RVA: 0x00F03178 File Offset: 0x00F01378
		public Piece RentPiece()
		{
			Piece piece = (this.PiecePool.Count > 0) ? this.PiecePool.Pop() : new Piece();
			piece.Reset();
			return piece;
		}

		// Token: 0x06035BB2 RID: 220082 RVA: 0x00F031A0 File Offset: 0x00F013A0
		public Piece RentPiece(EPieceType type, [Nullable(2)] int[] extraComponentIds = null)
		{
			Piece piece = this.RentPiece();
			this.AssignProto(piece, type, extraComponentIds);
			return piece;
		}

		// Token: 0x06035BB3 RID: 220083 RVA: 0x00F031C0 File Offset: 0x00F013C0
		[NullableContext(2)]
		public Piece ReplacePiece(int row, int col, EPieceType type, int[] extraComponentIds = null)
		{
			if (this.Cells[Board.CellIndex(row, col)].Piece == null)
			{
				return null;
			}
			Piece piece = this.RentPiece(type, extraComponentIds);
			this.SwapInPiece(row, col, piece);
			return piece;
		}

		// Token: 0x06035BB4 RID: 220084 RVA: 0x00F031F8 File Offset: 0x00F013F8
		[NullableContext(2)]
		public Piece RecolorPiece(int row, int col, EPieceType targetType)
		{
			Piece piece = this.Cells[Board.CellIndex(row, col)].Piece;
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

		// Token: 0x06035BB5 RID: 220085 RVA: 0x00F0326C File Offset: 0x00F0146C
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

		// Token: 0x06035BB6 RID: 220086 RVA: 0x00F032B4 File Offset: 0x00F014B4
		[NullableContext(2)]
		private Piece CloneForEdit(int row, int col)
		{
			Piece piece = this.Cells[Board.CellIndex(row, col)].Piece;
			if (piece == null)
			{
				return null;
			}
			Piece piece2 = this.RentPiece();
			piece2.CopyFrom(piece);
			return piece2;
		}

		// Token: 0x06035BB7 RID: 220087 RVA: 0x00F032E8 File Offset: 0x00F014E8
		private void SwapInPiece(int row, int col, Piece piece)
		{
			Piece piece2 = this.Cells[Board.CellIndex(row, col)].Piece;
			this.Cells[Board.CellIndex(row, col)].Piece = piece;
			if (piece2 != null)
			{
				this.ReturnPiece(piece2);
			}
		}

		// Token: 0x06035BB8 RID: 220088 RVA: 0x00F03328 File Offset: 0x00F01528
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

		// Token: 0x06035BB9 RID: 220089 RVA: 0x00F033FC File Offset: 0x00F015FC
		public void ReturnPiece(Piece piece)
		{
			this.RecycleCurrent.Add(piece);
		}

		// Token: 0x06035BBA RID: 220090 RVA: 0x00F0340C File Offset: 0x00F0160C
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

		// Token: 0x06035BBB RID: 220091 RVA: 0x00F03470 File Offset: 0x00F01670
		public void ClearPiece(int row, int col)
		{
			Piece piece = this.Cells[Board.CellIndex(row, col)].Piece;
			if (piece != null)
			{
				this.Cells[Board.CellIndex(row, col)].Piece = null;
				this.ReturnPiece(piece);
			}
		}

		// Token: 0x06035BBC RID: 220092 RVA: 0x00F034B0 File Offset: 0x00F016B0
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

		// Token: 0x06035BBD RID: 220093 RVA: 0x00F034D8 File Offset: 0x00F016D8
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

		// Token: 0x06035BBE RID: 220094 RVA: 0x00F035B4 File Offset: 0x00F017B4
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

		// Token: 0x06035BBF RID: 220095 RVA: 0x00F036DC File Offset: 0x00F018DC
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

		// Token: 0x0401C71B RID: 116507
		private readonly Cell[] Cells;

		// Token: 0x0401C71C RID: 116508
		private readonly System.Collections.Generic.Stack<Piece> PiecePool = new System.Collections.Generic.Stack<Piece>();

		// Token: 0x0401C71D RID: 116509
		private List<Piece> RecycleCurrent = new List<Piece>();

		// Token: 0x0401C71E RID: 116510
		private List<Piece> RecyclePrevious = new List<Piece>();

		// Token: 0x0401C71F RID: 116511
		private readonly Dictionary<EPieceType, PiecePrototype> ProtoByType = new Dictionary<EPieceType, PiecePrototype>();
	}
}
