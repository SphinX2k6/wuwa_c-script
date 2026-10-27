using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200742D RID: 29741
	public struct ITraceTracingGridBoard : IFlatbufferObject
	{
		// Token: 0x1700E1D4 RID: 57812
		// (get) Token: 0x06036076 RID: 221302 RVA: 0x00759657 File Offset: 0x00757857
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06036077 RID: 221303 RVA: 0x00759664 File Offset: 0x00757864
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06036078 RID: 221304 RVA: 0x0075966C File Offset: 0x0075786C
		public static ITraceTracingGridBoard GetRootAsITraceTracingGridBoard(ByteBuffer _bb)
		{
			return ITraceTracingGridBoard.GetRootAsITraceTracingGridBoard(_bb, default(ITraceTracingGridBoard));
		}

		// Token: 0x06036079 RID: 221305 RVA: 0x00759688 File Offset: 0x00757888
		public static ITraceTracingGridBoard GetRootAsITraceTracingGridBoard(ByteBuffer _bb, ITraceTracingGridBoard obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603607A RID: 221306 RVA: 0x007596A5 File Offset: 0x007578A5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603607B RID: 221307 RVA: 0x007596B4 File Offset: 0x007578B4
		public ITraceTracingGridBoard __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x0603607C RID: 221308 RVA: 0x007596C4 File Offset: 0x007578C4
		public ETraceTracingGridType Grids(int j)
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return ETraceTracingGridType.Block;
			}
			return (ETraceTracingGridType)this.__p.bb.Get(this.__p.__vector(num) + j);
		}

		// Token: 0x1700E1D5 RID: 57813
		// (get) Token: 0x0603607D RID: 221309 RVA: 0x00759704 File Offset: 0x00757904
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

		// Token: 0x0603607E RID: 221310 RVA: 0x0075972F File Offset: 0x0075792F
		public Span<ETraceTracingGridType> GetGridsBytes()
		{
			return this.__p.__vector_as_span<ETraceTracingGridType>(4, 1);
		}

		// Token: 0x0603607F RID: 221311 RVA: 0x00759740 File Offset: 0x00757940
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

		// Token: 0x1700E1D6 RID: 57814
		// (get) Token: 0x06036080 RID: 221312 RVA: 0x007597AC File Offset: 0x007579AC
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

		// Token: 0x06036081 RID: 221313 RVA: 0x00759809 File Offset: 0x00757A09
		public static Offset<ITraceTracingGridBoard> CreateITraceTracingGridBoard(FlatBufferBuilder builder, VectorOffset GridsOffset = default(VectorOffset), Offset<IVector2> BoardSizeOffset = default(Offset<IVector2>))
		{
			builder.StartTable(2);
			ITraceTracingGridBoard.AddBoardSize(builder, BoardSizeOffset);
			ITraceTracingGridBoard.AddGrids(builder, GridsOffset);
			return ITraceTracingGridBoard.EndITraceTracingGridBoard(builder);
		}

		// Token: 0x06036082 RID: 221314 RVA: 0x00759826 File Offset: 0x00757A26
		public static void StartITraceTracingGridBoard(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06036083 RID: 221315 RVA: 0x0075982F File Offset: 0x00757A2F
		public static void AddGrids(FlatBufferBuilder builder, VectorOffset gridsOffset)
		{
			builder.AddOffset(0, gridsOffset.Value, 0);
		}

		// Token: 0x06036084 RID: 221316 RVA: 0x00759840 File Offset: 0x00757A40
		public static VectorOffset CreateGridsVector(FlatBufferBuilder builder, ETraceTracingGridType[] data)
		{
			builder.StartVector(1, data.Length, 1);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddByte((byte)data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06036085 RID: 221317 RVA: 0x00759877 File Offset: 0x00757A77
		public static VectorOffset CreateGridsVectorBlock(FlatBufferBuilder builder, ETraceTracingGridType[] data)
		{
			builder.StartVector(1, data.Length, 1);
			builder.Add<ETraceTracingGridType>(data);
			return builder.EndVector();
		}

		// Token: 0x06036086 RID: 221318 RVA: 0x00759891 File Offset: 0x00757A91
		public static VectorOffset CreateGridsVectorBlock(FlatBufferBuilder builder, ArraySegment<ETraceTracingGridType> data)
		{
			builder.StartVector(1, data.Count, 1);
			builder.Add<ETraceTracingGridType>(data);
			return builder.EndVector();
		}

		// Token: 0x06036087 RID: 221319 RVA: 0x007598AF File Offset: 0x00757AAF
		public static VectorOffset CreateGridsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<ETraceTracingGridType>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06036088 RID: 221320 RVA: 0x007598C8 File Offset: 0x00757AC8
		public static void StartGridsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(1, numElems, 1);
		}

		// Token: 0x06036089 RID: 221321 RVA: 0x007598D3 File Offset: 0x00757AD3
		public static void AddBoardSize(FlatBufferBuilder builder, Offset<IVector2> boardSizeOffset)
		{
			builder.AddOffset(1, boardSizeOffset.Value, 0);
		}

		// Token: 0x0603608A RID: 221322 RVA: 0x007598E3 File Offset: 0x00757AE3
		public static Offset<ITraceTracingGridBoard> EndITraceTracingGridBoard(FlatBufferBuilder builder)
		{
			return new Offset<ITraceTracingGridBoard>(builder.EndTable());
		}

		// Token: 0x0603608B RID: 221323 RVA: 0x007598F0 File Offset: 0x00757AF0
		public ITraceTracingGridBoardT UnPack()
		{
			ITraceTracingGridBoardT traceTracingGridBoardT = new ITraceTracingGridBoardT();
			this.UnPackTo(traceTracingGridBoardT);
			return traceTracingGridBoardT;
		}

		// Token: 0x0603608C RID: 221324 RVA: 0x0075990C File Offset: 0x00757B0C
		public void UnPackTo(ITraceTracingGridBoardT _o)
		{
			_o.Grids = new List<ETraceTracingGridType>();
			for (int i = 0; i < this.GridsLength; i++)
			{
				_o.Grids.Add(this.Grids(i));
			}
			_o.BoardSize = ((this.BoardSize != null) ? this.BoardSize.Value.UnPack() : null);
		}

		// Token: 0x0603608D RID: 221325 RVA: 0x00759978 File Offset: 0x00757B78
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

		// Token: 0x040122A6 RID: 74406
		private Table __p;
	}
}
