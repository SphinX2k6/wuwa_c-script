using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007499 RID: 29849
	public struct ITuningStandGridBoard : IFlatbufferObject
	{
		// Token: 0x1700E2A6 RID: 58022
		// (get) Token: 0x0603641C RID: 222236 RVA: 0x0076034C File Offset: 0x0075E54C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603641D RID: 222237 RVA: 0x00760359 File Offset: 0x0075E559
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603641E RID: 222238 RVA: 0x00760360 File Offset: 0x0075E560
		public static ITuningStandGridBoard GetRootAsITuningStandGridBoard(ByteBuffer _bb)
		{
			return ITuningStandGridBoard.GetRootAsITuningStandGridBoard(_bb, default(ITuningStandGridBoard));
		}

		// Token: 0x0603641F RID: 222239 RVA: 0x0076037C File Offset: 0x0075E57C
		public static ITuningStandGridBoard GetRootAsITuningStandGridBoard(ByteBuffer _bb, ITuningStandGridBoard obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06036420 RID: 222240 RVA: 0x00760399 File Offset: 0x0075E599
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06036421 RID: 222241 RVA: 0x007603A8 File Offset: 0x0075E5A8
		public ITuningStandGridBoard __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x06036422 RID: 222242 RVA: 0x007603B8 File Offset: 0x0075E5B8
		public ETuningStandGridType Grids(int j)
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return ETuningStandGridType.Empty;
			}
			return (ETuningStandGridType)this.__p.bb.Get(this.__p.__vector(num) + j);
		}

		// Token: 0x1700E2A7 RID: 58023
		// (get) Token: 0x06036423 RID: 222243 RVA: 0x007603F8 File Offset: 0x0075E5F8
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

		// Token: 0x06036424 RID: 222244 RVA: 0x00760423 File Offset: 0x0075E623
		public Span<ETuningStandGridType> GetGridsBytes()
		{
			return this.__p.__vector_as_span<ETuningStandGridType>(4, 1);
		}

		// Token: 0x06036425 RID: 222245 RVA: 0x00760434 File Offset: 0x0075E634
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

		// Token: 0x06036426 RID: 222246 RVA: 0x0076049D File Offset: 0x0075E69D
		public static Offset<ITuningStandGridBoard> CreateITuningStandGridBoard(FlatBufferBuilder builder, VectorOffset GridsOffset = default(VectorOffset))
		{
			builder.StartTable(1);
			ITuningStandGridBoard.AddGrids(builder, GridsOffset);
			return ITuningStandGridBoard.EndITuningStandGridBoard(builder);
		}

		// Token: 0x06036427 RID: 222247 RVA: 0x007604B3 File Offset: 0x0075E6B3
		public static void StartITuningStandGridBoard(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06036428 RID: 222248 RVA: 0x007604BC File Offset: 0x0075E6BC
		public static void AddGrids(FlatBufferBuilder builder, VectorOffset gridsOffset)
		{
			builder.AddOffset(0, gridsOffset.Value, 0);
		}

		// Token: 0x06036429 RID: 222249 RVA: 0x007604CC File Offset: 0x0075E6CC
		public static VectorOffset CreateGridsVector(FlatBufferBuilder builder, ETuningStandGridType[] data)
		{
			builder.StartVector(1, data.Length, 1);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddByte((byte)data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0603642A RID: 222250 RVA: 0x00760503 File Offset: 0x0075E703
		public static VectorOffset CreateGridsVectorBlock(FlatBufferBuilder builder, ETuningStandGridType[] data)
		{
			builder.StartVector(1, data.Length, 1);
			builder.Add<ETuningStandGridType>(data);
			return builder.EndVector();
		}

		// Token: 0x0603642B RID: 222251 RVA: 0x0076051D File Offset: 0x0075E71D
		public static VectorOffset CreateGridsVectorBlock(FlatBufferBuilder builder, ArraySegment<ETuningStandGridType> data)
		{
			builder.StartVector(1, data.Count, 1);
			builder.Add<ETuningStandGridType>(data);
			return builder.EndVector();
		}

		// Token: 0x0603642C RID: 222252 RVA: 0x0076053B File Offset: 0x0075E73B
		public static VectorOffset CreateGridsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<ETuningStandGridType>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0603642D RID: 222253 RVA: 0x00760554 File Offset: 0x0075E754
		public static void StartGridsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(1, numElems, 1);
		}

		// Token: 0x0603642E RID: 222254 RVA: 0x0076055F File Offset: 0x0075E75F
		public static Offset<ITuningStandGridBoard> EndITuningStandGridBoard(FlatBufferBuilder builder)
		{
			return new Offset<ITuningStandGridBoard>(builder.EndTable());
		}

		// Token: 0x0603642F RID: 222255 RVA: 0x0076056C File Offset: 0x0075E76C
		public ITuningStandGridBoardT UnPack()
		{
			ITuningStandGridBoardT tuningStandGridBoardT = new ITuningStandGridBoardT();
			this.UnPackTo(tuningStandGridBoardT);
			return tuningStandGridBoardT;
		}

		// Token: 0x06036430 RID: 222256 RVA: 0x00760588 File Offset: 0x0075E788
		public void UnPackTo(ITuningStandGridBoardT _o)
		{
			_o.Grids = new List<ETuningStandGridType>();
			for (int i = 0; i < this.GridsLength; i++)
			{
				_o.Grids.Add(this.Grids(i));
			}
		}

		// Token: 0x06036431 RID: 222257 RVA: 0x007605C4 File Offset: 0x0075E7C4
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

		// Token: 0x04012338 RID: 74552
		private Table __p;
	}
}
