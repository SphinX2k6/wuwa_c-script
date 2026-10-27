using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020041BA RID: 16826
	public struct ITetrisIndexedBoard : IFlatbufferObject
	{
		// Token: 0x17007750 RID: 30544
		// (get) Token: 0x06018C6A RID: 101482 RVA: 0x003910E3 File Offset: 0x0038F2E3
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06018C6B RID: 101483 RVA: 0x003910F0 File Offset: 0x0038F2F0
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06018C6C RID: 101484 RVA: 0x003910F8 File Offset: 0x0038F2F8
		public static ITetrisIndexedBoard GetRootAsITetrisIndexedBoard(ByteBuffer _bb)
		{
			return ITetrisIndexedBoard.GetRootAsITetrisIndexedBoard(_bb, default(ITetrisIndexedBoard));
		}

		// Token: 0x06018C6D RID: 101485 RVA: 0x00391114 File Offset: 0x0038F314
		public static ITetrisIndexedBoard GetRootAsITetrisIndexedBoard(ByteBuffer _bb, ITetrisIndexedBoard obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06018C6E RID: 101486 RVA: 0x00391131 File Offset: 0x0038F331
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06018C6F RID: 101487 RVA: 0x00391140 File Offset: 0x0038F340
		public ITetrisIndexedBoard __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x06018C70 RID: 101488 RVA: 0x00391150 File Offset: 0x0038F350
		public ITetrisSingleIndexGrid? IndexedGrids(int j)
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return null;
			}
			return new ITetrisSingleIndexGrid?(default(ITetrisSingleIndexGrid).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17007751 RID: 30545
		// (get) Token: 0x06018C71 RID: 101489 RVA: 0x003911B0 File Offset: 0x0038F3B0
		public int IndexedGridsLength
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x17007752 RID: 30546
		// (get) Token: 0x06018C72 RID: 101490 RVA: 0x003911DC File Offset: 0x0038F3DC
		public IRequiredVector2? BoardSize
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IRequiredVector2?(default(IRequiredVector2).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x06018C73 RID: 101491 RVA: 0x00391239 File Offset: 0x0038F439
		public static Offset<ITetrisIndexedBoard> CreateITetrisIndexedBoard(FlatBufferBuilder builder, VectorOffset IndexedGridsOffset = default(VectorOffset), Offset<IRequiredVector2> BoardSizeOffset = default(Offset<IRequiredVector2>))
		{
			builder.StartTable(2);
			ITetrisIndexedBoard.AddBoardSize(builder, BoardSizeOffset);
			ITetrisIndexedBoard.AddIndexedGrids(builder, IndexedGridsOffset);
			return ITetrisIndexedBoard.EndITetrisIndexedBoard(builder);
		}

		// Token: 0x06018C74 RID: 101492 RVA: 0x00391256 File Offset: 0x0038F456
		public static void StartITetrisIndexedBoard(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06018C75 RID: 101493 RVA: 0x0039125F File Offset: 0x0038F45F
		public static void AddIndexedGrids(FlatBufferBuilder builder, VectorOffset indexedGridsOffset)
		{
			builder.AddOffset(0, indexedGridsOffset.Value, 0);
		}

		// Token: 0x06018C76 RID: 101494 RVA: 0x00391270 File Offset: 0x0038F470
		public static VectorOffset CreateIndexedGridsVector(FlatBufferBuilder builder, Offset<ITetrisSingleIndexGrid>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06018C77 RID: 101495 RVA: 0x003912B0 File Offset: 0x0038F4B0
		public static VectorOffset CreateIndexedGridsVectorBlock(FlatBufferBuilder builder, Offset<ITetrisSingleIndexGrid>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<ITetrisSingleIndexGrid>>(data);
			return builder.EndVector();
		}

		// Token: 0x06018C78 RID: 101496 RVA: 0x003912CA File Offset: 0x0038F4CA
		public static VectorOffset CreateIndexedGridsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<ITetrisSingleIndexGrid>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<ITetrisSingleIndexGrid>>(data);
			return builder.EndVector();
		}

		// Token: 0x06018C79 RID: 101497 RVA: 0x003912E8 File Offset: 0x0038F4E8
		public static VectorOffset CreateIndexedGridsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<ITetrisSingleIndexGrid>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06018C7A RID: 101498 RVA: 0x00391301 File Offset: 0x0038F501
		public static void StartIndexedGridsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06018C7B RID: 101499 RVA: 0x0039130C File Offset: 0x0038F50C
		public static void AddBoardSize(FlatBufferBuilder builder, Offset<IRequiredVector2> boardSizeOffset)
		{
			builder.AddOffset(1, boardSizeOffset.Value, 0);
		}

		// Token: 0x06018C7C RID: 101500 RVA: 0x0039131C File Offset: 0x0038F51C
		public static Offset<ITetrisIndexedBoard> EndITetrisIndexedBoard(FlatBufferBuilder builder)
		{
			return new Offset<ITetrisIndexedBoard>(builder.EndTable());
		}

		// Token: 0x06018C7D RID: 101501 RVA: 0x0039132C File Offset: 0x0038F52C
		public ITetrisIndexedBoardT UnPack()
		{
			ITetrisIndexedBoardT tetrisIndexedBoardT = new ITetrisIndexedBoardT();
			this.UnPackTo(tetrisIndexedBoardT);
			return tetrisIndexedBoardT;
		}

		// Token: 0x06018C7E RID: 101502 RVA: 0x00391348 File Offset: 0x0038F548
		public void UnPackTo(ITetrisIndexedBoardT _o)
		{
			_o.IndexedGrids = new List<ITetrisSingleIndexGridT>();
			for (int i = 0; i < this.IndexedGridsLength; i++)
			{
				_o.IndexedGrids.Add((this.IndexedGrids(i) != null) ? this.IndexedGrids(i).Value.UnPack() : null);
			}
			_o.BoardSize = ((this.BoardSize != null) ? this.BoardSize.Value.UnPack() : null);
		}

		// Token: 0x06018C7F RID: 101503 RVA: 0x003913D8 File Offset: 0x0038F5D8
		public static Offset<ITetrisIndexedBoard> Pack(FlatBufferBuilder builder, ITetrisIndexedBoardT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITetrisIndexedBoard>);
			}
			VectorOffset indexedGridsOffset = default(VectorOffset);
			if (_o.IndexedGrids != null)
			{
				Offset<ITetrisSingleIndexGrid>[] array = new Offset<ITetrisSingleIndexGrid>[_o.IndexedGrids.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = ITetrisSingleIndexGrid.Pack(builder, _o.IndexedGrids[i]);
				}
				indexedGridsOffset = ITetrisIndexedBoard.CreateIndexedGridsVector(builder, array);
			}
			Offset<IRequiredVector2> boardSizeOffset = (_o.BoardSize == null) ? default(Offset<IRequiredVector2>) : IRequiredVector2.Pack(builder, _o.BoardSize);
			return ITetrisIndexedBoard.CreateITetrisIndexedBoard(builder, indexedGridsOffset, boardSizeOffset);
		}

		// Token: 0x0400BDFE RID: 48638
		private Table __p;
	}
}
