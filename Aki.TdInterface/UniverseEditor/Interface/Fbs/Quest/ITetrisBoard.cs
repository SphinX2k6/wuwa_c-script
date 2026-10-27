using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020041B7 RID: 16823
	public struct ITetrisBoard : IFlatbufferObject
	{
		// Token: 0x1700774B RID: 30539
		// (get) Token: 0x06018C4E RID: 101454 RVA: 0x00390CB0 File Offset: 0x0038EEB0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06018C4F RID: 101455 RVA: 0x00390CBD File Offset: 0x0038EEBD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06018C50 RID: 101456 RVA: 0x00390CC4 File Offset: 0x0038EEC4
		public static ITetrisBoard GetRootAsITetrisBoard(ByteBuffer _bb)
		{
			return ITetrisBoard.GetRootAsITetrisBoard(_bb, default(ITetrisBoard));
		}

		// Token: 0x06018C51 RID: 101457 RVA: 0x00390CE0 File Offset: 0x0038EEE0
		public static ITetrisBoard GetRootAsITetrisBoard(ByteBuffer _bb, ITetrisBoard obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06018C52 RID: 101458 RVA: 0x00390CFD File Offset: 0x0038EEFD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06018C53 RID: 101459 RVA: 0x00390D0C File Offset: 0x0038EF0C
		public ITetrisBoard __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x06018C54 RID: 101460 RVA: 0x00390D1C File Offset: 0x0038EF1C
		public ITetrisSingleGrid? Grids(int j)
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return null;
			}
			return new ITetrisSingleGrid?(default(ITetrisSingleGrid).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700774C RID: 30540
		// (get) Token: 0x06018C55 RID: 101461 RVA: 0x00390D7C File Offset: 0x0038EF7C
		public int GridsLength
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

		// Token: 0x1700774D RID: 30541
		// (get) Token: 0x06018C56 RID: 101462 RVA: 0x00390DA8 File Offset: 0x0038EFA8
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

		// Token: 0x06018C57 RID: 101463 RVA: 0x00390E05 File Offset: 0x0038F005
		public static Offset<ITetrisBoard> CreateITetrisBoard(FlatBufferBuilder builder, VectorOffset GridsOffset = default(VectorOffset), Offset<IRequiredVector2> BoardSizeOffset = default(Offset<IRequiredVector2>))
		{
			builder.StartTable(2);
			ITetrisBoard.AddBoardSize(builder, BoardSizeOffset);
			ITetrisBoard.AddGrids(builder, GridsOffset);
			return ITetrisBoard.EndITetrisBoard(builder);
		}

		// Token: 0x06018C58 RID: 101464 RVA: 0x00390E22 File Offset: 0x0038F022
		public static void StartITetrisBoard(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06018C59 RID: 101465 RVA: 0x00390E2B File Offset: 0x0038F02B
		public static void AddGrids(FlatBufferBuilder builder, VectorOffset gridsOffset)
		{
			builder.AddOffset(0, gridsOffset.Value, 0);
		}

		// Token: 0x06018C5A RID: 101466 RVA: 0x00390E3C File Offset: 0x0038F03C
		public static VectorOffset CreateGridsVector(FlatBufferBuilder builder, Offset<ITetrisSingleGrid>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06018C5B RID: 101467 RVA: 0x00390E7C File Offset: 0x0038F07C
		public static VectorOffset CreateGridsVectorBlock(FlatBufferBuilder builder, Offset<ITetrisSingleGrid>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<ITetrisSingleGrid>>(data);
			return builder.EndVector();
		}

		// Token: 0x06018C5C RID: 101468 RVA: 0x00390E96 File Offset: 0x0038F096
		public static VectorOffset CreateGridsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<ITetrisSingleGrid>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<ITetrisSingleGrid>>(data);
			return builder.EndVector();
		}

		// Token: 0x06018C5D RID: 101469 RVA: 0x00390EB4 File Offset: 0x0038F0B4
		public static VectorOffset CreateGridsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<ITetrisSingleGrid>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06018C5E RID: 101470 RVA: 0x00390ECD File Offset: 0x0038F0CD
		public static void StartGridsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06018C5F RID: 101471 RVA: 0x00390ED8 File Offset: 0x0038F0D8
		public static void AddBoardSize(FlatBufferBuilder builder, Offset<IRequiredVector2> boardSizeOffset)
		{
			builder.AddOffset(1, boardSizeOffset.Value, 0);
		}

		// Token: 0x06018C60 RID: 101472 RVA: 0x00390EE8 File Offset: 0x0038F0E8
		public static Offset<ITetrisBoard> EndITetrisBoard(FlatBufferBuilder builder)
		{
			return new Offset<ITetrisBoard>(builder.EndTable());
		}

		// Token: 0x06018C61 RID: 101473 RVA: 0x00390EF8 File Offset: 0x0038F0F8
		public ITetrisBoardT UnPack()
		{
			ITetrisBoardT tetrisBoardT = new ITetrisBoardT();
			this.UnPackTo(tetrisBoardT);
			return tetrisBoardT;
		}

		// Token: 0x06018C62 RID: 101474 RVA: 0x00390F14 File Offset: 0x0038F114
		public void UnPackTo(ITetrisBoardT _o)
		{
			_o.Grids = new List<ITetrisSingleGridT>();
			for (int i = 0; i < this.GridsLength; i++)
			{
				_o.Grids.Add((this.Grids(i) != null) ? this.Grids(i).Value.UnPack() : null);
			}
			_o.BoardSize = ((this.BoardSize != null) ? this.BoardSize.Value.UnPack() : null);
		}

		// Token: 0x06018C63 RID: 101475 RVA: 0x00390FA4 File Offset: 0x0038F1A4
		public static Offset<ITetrisBoard> Pack(FlatBufferBuilder builder, ITetrisBoardT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITetrisBoard>);
			}
			VectorOffset gridsOffset = default(VectorOffset);
			if (_o.Grids != null)
			{
				Offset<ITetrisSingleGrid>[] array = new Offset<ITetrisSingleGrid>[_o.Grids.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = ITetrisSingleGrid.Pack(builder, _o.Grids[i]);
				}
				gridsOffset = ITetrisBoard.CreateGridsVector(builder, array);
			}
			Offset<IRequiredVector2> boardSizeOffset = (_o.BoardSize == null) ? default(Offset<IRequiredVector2>) : IRequiredVector2.Pack(builder, _o.BoardSize);
			return ITetrisBoard.CreateITetrisBoard(builder, gridsOffset, boardSizeOffset);
		}

		// Token: 0x0400BDFB RID: 48635
		private Table __p;
	}
}
