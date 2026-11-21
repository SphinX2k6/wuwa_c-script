using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004613 RID: 17939
	public struct ITetrisIndexedBoard : IFlatbufferObject
	{
		// Token: 0x17007D7C RID: 32124
		// (get) Token: 0x0601A3C0 RID: 107456 RVA: 0x003BC537 File Offset: 0x003BA737
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601A3C1 RID: 107457 RVA: 0x003BC544 File Offset: 0x003BA744
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601A3C2 RID: 107458 RVA: 0x003BC54C File Offset: 0x003BA74C
		public static ITetrisIndexedBoard GetRootAsITetrisIndexedBoard(ByteBuffer _bb)
		{
			return ITetrisIndexedBoard.GetRootAsITetrisIndexedBoard(_bb, default(ITetrisIndexedBoard));
		}

		// Token: 0x0601A3C3 RID: 107459 RVA: 0x003BC568 File Offset: 0x003BA768
		public static ITetrisIndexedBoard GetRootAsITetrisIndexedBoard(ByteBuffer _bb, ITetrisIndexedBoard obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601A3C4 RID: 107460 RVA: 0x003BC585 File Offset: 0x003BA785
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601A3C5 RID: 107461 RVA: 0x003BC594 File Offset: 0x003BA794
		public ITetrisIndexedBoard __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x0601A3C6 RID: 107462 RVA: 0x003BC5A4 File Offset: 0x003BA7A4
		public ITetrisSingleIndexGrid? IndexedGrids(int j)
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return null;
			}
			return new ITetrisSingleIndexGrid?(default(ITetrisSingleIndexGrid).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17007D7D RID: 32125
		// (get) Token: 0x0601A3C7 RID: 107463 RVA: 0x003BC604 File Offset: 0x003BA804
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

		// Token: 0x17007D7E RID: 32126
		// (get) Token: 0x0601A3C8 RID: 107464 RVA: 0x003BC630 File Offset: 0x003BA830
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

		// Token: 0x0601A3C9 RID: 107465 RVA: 0x003BC68D File Offset: 0x003BA88D
		public static Offset<ITetrisIndexedBoard> CreateITetrisIndexedBoard(FlatBufferBuilder builder, VectorOffset IndexedGridsOffset = default(VectorOffset), Offset<IRequiredVector2> BoardSizeOffset = default(Offset<IRequiredVector2>))
		{
			builder.StartTable(2);
			ITetrisIndexedBoard.AddBoardSize(builder, BoardSizeOffset);
			ITetrisIndexedBoard.AddIndexedGrids(builder, IndexedGridsOffset);
			return ITetrisIndexedBoard.EndITetrisIndexedBoard(builder);
		}

		// Token: 0x0601A3CA RID: 107466 RVA: 0x003BC6AA File Offset: 0x003BA8AA
		public static void StartITetrisIndexedBoard(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601A3CB RID: 107467 RVA: 0x003BC6B3 File Offset: 0x003BA8B3
		public static void AddIndexedGrids(FlatBufferBuilder builder, VectorOffset indexedGridsOffset)
		{
			builder.AddOffset(0, indexedGridsOffset.Value, 0);
		}

		// Token: 0x0601A3CC RID: 107468 RVA: 0x003BC6C4 File Offset: 0x003BA8C4
		public static VectorOffset CreateIndexedGridsVector(FlatBufferBuilder builder, Offset<ITetrisSingleIndexGrid>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601A3CD RID: 107469 RVA: 0x003BC704 File Offset: 0x003BA904
		public static VectorOffset CreateIndexedGridsVectorBlock(FlatBufferBuilder builder, Offset<ITetrisSingleIndexGrid>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<ITetrisSingleIndexGrid>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601A3CE RID: 107470 RVA: 0x003BC71E File Offset: 0x003BA91E
		public static VectorOffset CreateIndexedGridsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<ITetrisSingleIndexGrid>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<ITetrisSingleIndexGrid>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601A3CF RID: 107471 RVA: 0x003BC73C File Offset: 0x003BA93C
		public static VectorOffset CreateIndexedGridsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<ITetrisSingleIndexGrid>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601A3D0 RID: 107472 RVA: 0x003BC755 File Offset: 0x003BA955
		public static void StartIndexedGridsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601A3D1 RID: 107473 RVA: 0x003BC760 File Offset: 0x003BA960
		public static void AddBoardSize(FlatBufferBuilder builder, Offset<IRequiredVector2> boardSizeOffset)
		{
			builder.AddOffset(1, boardSizeOffset.Value, 0);
		}

		// Token: 0x0601A3D2 RID: 107474 RVA: 0x003BC770 File Offset: 0x003BA970
		public static Offset<ITetrisIndexedBoard> EndITetrisIndexedBoard(FlatBufferBuilder builder)
		{
			return new Offset<ITetrisIndexedBoard>(builder.EndTable());
		}

		// Token: 0x0601A3D3 RID: 107475 RVA: 0x003BC780 File Offset: 0x003BA980
		public ITetrisIndexedBoardT UnPack()
		{
			ITetrisIndexedBoardT tetrisIndexedBoardT = new ITetrisIndexedBoardT();
			this.UnPackTo(tetrisIndexedBoardT);
			return tetrisIndexedBoardT;
		}

		// Token: 0x0601A3D4 RID: 107476 RVA: 0x003BC79C File Offset: 0x003BA99C
		public void UnPackTo(ITetrisIndexedBoardT _o)
		{
			_o.IndexedGrids = new List<ITetrisSingleIndexGridT>();
			for (int i = 0; i < this.IndexedGridsLength; i++)
			{
				_o.IndexedGrids.Add((this.IndexedGrids(i) != null) ? this.IndexedGrids(i).Value.UnPack() : null);
			}
			_o.BoardSize = ((this.BoardSize != null) ? this.BoardSize.Value.UnPack() : null);
		}

		// Token: 0x0601A3D5 RID: 107477 RVA: 0x003BC82C File Offset: 0x003BAA2C
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

		// Token: 0x0400C808 RID: 51208
		private Table __p;
	}
}
