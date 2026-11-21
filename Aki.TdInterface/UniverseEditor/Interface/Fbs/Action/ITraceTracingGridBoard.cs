using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007C20 RID: 31776
	public struct ITraceTracingGridBoard : IFlatbufferObject
	{
		// Token: 0x1700EDF1 RID: 60913
		// (get) Token: 0x0603945F RID: 234591 RVA: 0x007BC383 File Offset: 0x007BA583
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06039460 RID: 234592 RVA: 0x007BC390 File Offset: 0x007BA590
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06039461 RID: 234593 RVA: 0x007BC398 File Offset: 0x007BA598
		public static ITraceTracingGridBoard GetRootAsITraceTracingGridBoard(ByteBuffer _bb)
		{
			return ITraceTracingGridBoard.GetRootAsITraceTracingGridBoard(_bb, default(ITraceTracingGridBoard));
		}

		// Token: 0x06039462 RID: 234594 RVA: 0x007BC3B4 File Offset: 0x007BA5B4
		public static ITraceTracingGridBoard GetRootAsITraceTracingGridBoard(ByteBuffer _bb, ITraceTracingGridBoard obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06039463 RID: 234595 RVA: 0x007BC3D1 File Offset: 0x007BA5D1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06039464 RID: 234596 RVA: 0x007BC3E0 File Offset: 0x007BA5E0
		public ITraceTracingGridBoard __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x06039465 RID: 234597 RVA: 0x007BC3F0 File Offset: 0x007BA5F0
		public ETraceTracingGridType Grids(int j)
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return ETraceTracingGridType.Block;
			}
			return (ETraceTracingGridType)this.__p.bb.Get(this.__p.__vector(num) + j);
		}

		// Token: 0x1700EDF2 RID: 60914
		// (get) Token: 0x06039466 RID: 234598 RVA: 0x007BC430 File Offset: 0x007BA630
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

		// Token: 0x06039467 RID: 234599 RVA: 0x007BC45B File Offset: 0x007BA65B
		public Span<ETraceTracingGridType> GetGridsBytes()
		{
			return this.__p.__vector_as_span<ETraceTracingGridType>(4, 1);
		}

		// Token: 0x06039468 RID: 234600 RVA: 0x007BC46C File Offset: 0x007BA66C
		public ETraceTracingGridType[] GetGridsArray()
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return null;
			}
			int num2 = this.__p.__vector(num);
			int num3 = this.__p.__vector_len(num);
			ETraceTracingGridType[] array = new ETraceTracingGridType[num3];
			for (int i = 0; i < num3; i++)
			{
				array[i] = (ETraceTracingGridType)this.__p.bb.Get(num2 + i);
			}
			return array;
		}

		// Token: 0x1700EDF3 RID: 60915
		// (get) Token: 0x06039469 RID: 234601 RVA: 0x007BC4D8 File Offset: 0x007BA6D8
		public IVector2? BoardSize
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IVector2?(default(IVector2).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x0603946A RID: 234602 RVA: 0x007BC535 File Offset: 0x007BA735
		public static Offset<ITraceTracingGridBoard> CreateITraceTracingGridBoard(FlatBufferBuilder builder, VectorOffset GridsOffset = default(VectorOffset), Offset<IVector2> BoardSizeOffset = default(Offset<IVector2>))
		{
			builder.StartTable(2);
			ITraceTracingGridBoard.AddBoardSize(builder, BoardSizeOffset);
			ITraceTracingGridBoard.AddGrids(builder, GridsOffset);
			return ITraceTracingGridBoard.EndITraceTracingGridBoard(builder);
		}

		// Token: 0x0603946B RID: 234603 RVA: 0x007BC552 File Offset: 0x007BA752
		public static void StartITraceTracingGridBoard(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0603946C RID: 234604 RVA: 0x007BC55B File Offset: 0x007BA75B
		public static void AddGrids(FlatBufferBuilder builder, VectorOffset gridsOffset)
		{
			builder.AddOffset(0, gridsOffset.Value, 0);
		}

		// Token: 0x0603946D RID: 234605 RVA: 0x007BC56C File Offset: 0x007BA76C
		public static VectorOffset CreateGridsVector(FlatBufferBuilder builder, ETraceTracingGridType[] data)
		{
			builder.StartVector(1, data.Length, 1);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddByte((byte)data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0603946E RID: 234606 RVA: 0x007BC5A3 File Offset: 0x007BA7A3
		public static VectorOffset CreateGridsVectorBlock(FlatBufferBuilder builder, ETraceTracingGridType[] data)
		{
			builder.StartVector(1, data.Length, 1);
			builder.Add<ETraceTracingGridType>(data);
			return builder.EndVector();
		}

		// Token: 0x0603946F RID: 234607 RVA: 0x007BC5BD File Offset: 0x007BA7BD
		public static VectorOffset CreateGridsVectorBlock(FlatBufferBuilder builder, ArraySegment<ETraceTracingGridType> data)
		{
			builder.StartVector(1, data.Count, 1);
			builder.Add<ETraceTracingGridType>(data);
			return builder.EndVector();
		}

		// Token: 0x06039470 RID: 234608 RVA: 0x007BC5DB File Offset: 0x007BA7DB
		public static VectorOffset CreateGridsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<ETraceTracingGridType>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06039471 RID: 234609 RVA: 0x007BC5F4 File Offset: 0x007BA7F4
		public static void StartGridsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(1, numElems, 1);
		}

		// Token: 0x06039472 RID: 234610 RVA: 0x007BC5FF File Offset: 0x007BA7FF
		public static void AddBoardSize(FlatBufferBuilder builder, Offset<IVector2> boardSizeOffset)
		{
			builder.AddOffset(1, boardSizeOffset.Value, 0);
		}

		// Token: 0x06039473 RID: 234611 RVA: 0x007BC60F File Offset: 0x007BA80F
		public static Offset<ITraceTracingGridBoard> EndITraceTracingGridBoard(FlatBufferBuilder builder)
		{
			return new Offset<ITraceTracingGridBoard>(builder.EndTable());
		}

		// Token: 0x06039474 RID: 234612 RVA: 0x007BC61C File Offset: 0x007BA81C
		public ITraceTracingGridBoardT UnPack()
		{
			ITraceTracingGridBoardT traceTracingGridBoardT = new ITraceTracingGridBoardT();
			this.UnPackTo(traceTracingGridBoardT);
			return traceTracingGridBoardT;
		}

		// Token: 0x06039475 RID: 234613 RVA: 0x007BC638 File Offset: 0x007BA838
		public void UnPackTo(ITraceTracingGridBoardT _o)
		{
			_o.Grids = new List<ETraceTracingGridType>();
			for (int i = 0; i < this.GridsLength; i++)
			{
				_o.Grids.Add(this.Grids(i));
			}
			_o.BoardSize = ((this.BoardSize != null) ? this.BoardSize.Value.UnPack() : null);
		}

		// Token: 0x06039476 RID: 234614 RVA: 0x007BC6A4 File Offset: 0x007BA8A4
		public static Offset<ITraceTracingGridBoard> Pack(FlatBufferBuilder builder, ITraceTracingGridBoardT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITraceTracingGridBoard>);
			}
			VectorOffset gridsOffset = default(VectorOffset);
			if (_o.Grids != null)
			{
				ETraceTracingGridType[] data = _o.Grids.ToArray();
				gridsOffset = ITraceTracingGridBoard.CreateGridsVector(builder, data);
			}
			Offset<IVector2> boardSizeOffset = (_o.BoardSize == null) ? default(Offset<IVector2>) : IVector2.Pack(builder, _o.BoardSize);
			return ITraceTracingGridBoard.CreateITraceTracingGridBoard(builder, gridsOffset, boardSizeOffset);
		}

		// Token: 0x040132CD RID: 78541
		private Table __p;
	}
}
