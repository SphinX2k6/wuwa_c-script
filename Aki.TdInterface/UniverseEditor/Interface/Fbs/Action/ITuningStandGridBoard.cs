using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007C8C RID: 31884
	public struct ITuningStandGridBoard : IFlatbufferObject
	{
		// Token: 0x1700EEC5 RID: 61125
		// (get) Token: 0x06039809 RID: 235529 RVA: 0x007C3108 File Offset: 0x007C1308
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603980A RID: 235530 RVA: 0x007C3115 File Offset: 0x007C1315
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603980B RID: 235531 RVA: 0x007C311C File Offset: 0x007C131C
		public static ITuningStandGridBoard GetRootAsITuningStandGridBoard(ByteBuffer _bb)
		{
			return ITuningStandGridBoard.GetRootAsITuningStandGridBoard(_bb, default(ITuningStandGridBoard));
		}

		// Token: 0x0603980C RID: 235532 RVA: 0x007C3138 File Offset: 0x007C1338
		public static ITuningStandGridBoard GetRootAsITuningStandGridBoard(ByteBuffer _bb, ITuningStandGridBoard obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603980D RID: 235533 RVA: 0x007C3155 File Offset: 0x007C1355
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603980E RID: 235534 RVA: 0x007C3164 File Offset: 0x007C1364
		public ITuningStandGridBoard __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x0603980F RID: 235535 RVA: 0x007C3174 File Offset: 0x007C1374
		public ETuningStandGridType Grids(int j)
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return ETuningStandGridType.Empty;
			}
			return (ETuningStandGridType)this.__p.bb.Get(this.__p.__vector(num) + j);
		}

		// Token: 0x1700EEC6 RID: 61126
		// (get) Token: 0x06039810 RID: 235536 RVA: 0x007C31B4 File Offset: 0x007C13B4
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

		// Token: 0x06039811 RID: 235537 RVA: 0x007C31DF File Offset: 0x007C13DF
		public Span<ETuningStandGridType> GetGridsBytes()
		{
			return this.__p.__vector_as_span<ETuningStandGridType>(4, 1);
		}

		// Token: 0x06039812 RID: 235538 RVA: 0x007C31F0 File Offset: 0x007C13F0
		public ETuningStandGridType[] GetGridsArray()
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return null;
			}
			int num2 = this.__p.__vector(num);
			int num3 = this.__p.__vector_len(num);
			ETuningStandGridType[] array = new ETuningStandGridType[num3];
			for (int i = 0; i < num3; i++)
			{
				array[i] = (ETuningStandGridType)this.__p.bb.Get(num2 + i);
			}
			return array;
		}

		// Token: 0x06039813 RID: 235539 RVA: 0x007C3259 File Offset: 0x007C1459
		public static Offset<ITuningStandGridBoard> CreateITuningStandGridBoard(FlatBufferBuilder builder, VectorOffset GridsOffset = default(VectorOffset))
		{
			builder.StartTable(1);
			ITuningStandGridBoard.AddGrids(builder, GridsOffset);
			return ITuningStandGridBoard.EndITuningStandGridBoard(builder);
		}

		// Token: 0x06039814 RID: 235540 RVA: 0x007C326F File Offset: 0x007C146F
		public static void StartITuningStandGridBoard(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06039815 RID: 235541 RVA: 0x007C3278 File Offset: 0x007C1478
		public static void AddGrids(FlatBufferBuilder builder, VectorOffset gridsOffset)
		{
			builder.AddOffset(0, gridsOffset.Value, 0);
		}

		// Token: 0x06039816 RID: 235542 RVA: 0x007C3288 File Offset: 0x007C1488
		public static VectorOffset CreateGridsVector(FlatBufferBuilder builder, ETuningStandGridType[] data)
		{
			builder.StartVector(1, data.Length, 1);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddByte((byte)data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06039817 RID: 235543 RVA: 0x007C32BF File Offset: 0x007C14BF
		public static VectorOffset CreateGridsVectorBlock(FlatBufferBuilder builder, ETuningStandGridType[] data)
		{
			builder.StartVector(1, data.Length, 1);
			builder.Add<ETuningStandGridType>(data);
			return builder.EndVector();
		}

		// Token: 0x06039818 RID: 235544 RVA: 0x007C32D9 File Offset: 0x007C14D9
		public static VectorOffset CreateGridsVectorBlock(FlatBufferBuilder builder, ArraySegment<ETuningStandGridType> data)
		{
			builder.StartVector(1, data.Count, 1);
			builder.Add<ETuningStandGridType>(data);
			return builder.EndVector();
		}

		// Token: 0x06039819 RID: 235545 RVA: 0x007C32F7 File Offset: 0x007C14F7
		public static VectorOffset CreateGridsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<ETuningStandGridType>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0603981A RID: 235546 RVA: 0x007C3310 File Offset: 0x007C1510
		public static void StartGridsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(1, numElems, 1);
		}

		// Token: 0x0603981B RID: 235547 RVA: 0x007C331B File Offset: 0x007C151B
		public static Offset<ITuningStandGridBoard> EndITuningStandGridBoard(FlatBufferBuilder builder)
		{
			return new Offset<ITuningStandGridBoard>(builder.EndTable());
		}

		// Token: 0x0603981C RID: 235548 RVA: 0x007C3328 File Offset: 0x007C1528
		public ITuningStandGridBoardT UnPack()
		{
			ITuningStandGridBoardT tuningStandGridBoardT = new ITuningStandGridBoardT();
			this.UnPackTo(tuningStandGridBoardT);
			return tuningStandGridBoardT;
		}

		// Token: 0x0603981D RID: 235549 RVA: 0x007C3344 File Offset: 0x007C1544
		public void UnPackTo(ITuningStandGridBoardT _o)
		{
			_o.Grids = new List<ETuningStandGridType>();
			for (int i = 0; i < this.GridsLength; i++)
			{
				_o.Grids.Add(this.Grids(i));
			}
		}

		// Token: 0x0603981E RID: 235550 RVA: 0x007C3380 File Offset: 0x007C1580
		public static Offset<ITuningStandGridBoard> Pack(FlatBufferBuilder builder, ITuningStandGridBoardT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITuningStandGridBoard>);
			}
			VectorOffset gridsOffset = default(VectorOffset);
			if (_o.Grids != null)
			{
				ETuningStandGridType[] data = _o.Grids.ToArray();
				gridsOffset = ITuningStandGridBoard.CreateGridsVector(builder, data);
			}
			return ITuningStandGridBoard.CreateITuningStandGridBoard(builder, gridsOffset);
		}

		// Token: 0x04013360 RID: 78688
		private Table __p;
	}
}
