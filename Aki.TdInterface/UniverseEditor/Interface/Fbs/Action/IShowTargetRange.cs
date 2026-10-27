using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007106 RID: 28934
	public struct IShowTargetRange : IFlatbufferObject
	{
		// Token: 0x1700D715 RID: 55061
		// (get) Token: 0x060334A7 RID: 210087 RVA: 0x006EA3CE File Offset: 0x006E85CE
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060334A8 RID: 210088 RVA: 0x006EA3DB File Offset: 0x006E85DB
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060334A9 RID: 210089 RVA: 0x006EA3E4 File Offset: 0x006E85E4
		public static IShowTargetRange GetRootAsIShowTargetRange(ByteBuffer _bb)
		{
			return IShowTargetRange.GetRootAsIShowTargetRange(_bb, default(IShowTargetRange));
		}

		// Token: 0x060334AA RID: 210090 RVA: 0x006EA400 File Offset: 0x006E8600
		public static IShowTargetRange GetRootAsIShowTargetRange(ByteBuffer _bb, IShowTargetRange obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060334AB RID: 210091 RVA: 0x006EA41D File Offset: 0x006E861D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060334AC RID: 210092 RVA: 0x006EA42C File Offset: 0x006E862C
		public IShowTargetRange __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x060334AD RID: 210093 RVA: 0x006EA43C File Offset: 0x006E863C
		public int RangeEntities(int j)
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700D716 RID: 55062
		// (get) Token: 0x060334AE RID: 210094 RVA: 0x006EA47C File Offset: 0x006E867C
		public int RangeEntitiesLength
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

		// Token: 0x060334AF RID: 210095 RVA: 0x006EA4A7 File Offset: 0x006E86A7
		public Span<int> GetRangeEntitiesBytes()
		{
			return this.__p.__vector_as_span<int>(4, 4);
		}

		// Token: 0x060334B0 RID: 210096 RVA: 0x006EA4B6 File Offset: 0x006E86B6
		public int[] GetRangeEntitiesArray()
		{
			return this.__p.__vector_as_array<int>(4);
		}

		// Token: 0x1700D717 RID: 55063
		// (get) Token: 0x060334B1 RID: 210097 RVA: 0x006EA4C4 File Offset: 0x006E86C4
		public bool DelayShow
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x060334B2 RID: 210098 RVA: 0x006EA503 File Offset: 0x006E8703
		public static Offset<IShowTargetRange> CreateIShowTargetRange(FlatBufferBuilder builder, VectorOffset RangeEntitiesOffset = default(VectorOffset), bool DelayShow = false)
		{
			builder.StartTable(2);
			IShowTargetRange.AddRangeEntities(builder, RangeEntitiesOffset);
			IShowTargetRange.AddDelayShow(builder, DelayShow);
			return IShowTargetRange.EndIShowTargetRange(builder);
		}

		// Token: 0x060334B3 RID: 210099 RVA: 0x006EA520 File Offset: 0x006E8720
		public static void StartIShowTargetRange(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060334B4 RID: 210100 RVA: 0x006EA529 File Offset: 0x006E8729
		public static void AddRangeEntities(FlatBufferBuilder builder, VectorOffset rangeEntitiesOffset)
		{
			builder.AddOffset(0, rangeEntitiesOffset.Value, 0);
		}

		// Token: 0x060334B5 RID: 210101 RVA: 0x006EA53C File Offset: 0x006E873C
		public static VectorOffset CreateRangeEntitiesVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x060334B6 RID: 210102 RVA: 0x006EA573 File Offset: 0x006E8773
		public static VectorOffset CreateRangeEntitiesVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x060334B7 RID: 210103 RVA: 0x006EA58D File Offset: 0x006E878D
		public static VectorOffset CreateRangeEntitiesVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x060334B8 RID: 210104 RVA: 0x006EA5AB File Offset: 0x006E87AB
		public static VectorOffset CreateRangeEntitiesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060334B9 RID: 210105 RVA: 0x006EA5C4 File Offset: 0x006E87C4
		public static void StartRangeEntitiesVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060334BA RID: 210106 RVA: 0x006EA5CF File Offset: 0x006E87CF
		public static void AddDelayShow(FlatBufferBuilder builder, bool delayShow)
		{
			builder.AddBool(1, delayShow, false);
		}

		// Token: 0x060334BB RID: 210107 RVA: 0x006EA5DA File Offset: 0x006E87DA
		public static Offset<IShowTargetRange> EndIShowTargetRange(FlatBufferBuilder builder)
		{
			return new Offset<IShowTargetRange>(builder.EndTable());
		}

		// Token: 0x060334BC RID: 210108 RVA: 0x006EA5E8 File Offset: 0x006E87E8
		public IShowTargetRangeT UnPack()
		{
			IShowTargetRangeT showTargetRangeT = new IShowTargetRangeT();
			this.UnPackTo(showTargetRangeT);
			return showTargetRangeT;
		}

		// Token: 0x060334BD RID: 210109 RVA: 0x006EA604 File Offset: 0x006E8804
		public void UnPackTo(IShowTargetRangeT _o)
		{
			_o.RangeEntities = new List<int>();
			for (int i = 0; i < this.RangeEntitiesLength; i++)
			{
				_o.RangeEntities.Add(this.RangeEntities(i));
			}
			_o.DelayShow = this.DelayShow;
		}

		// Token: 0x060334BE RID: 210110 RVA: 0x006EA64C File Offset: 0x006E884C
		public static Offset<IShowTargetRange> Pack(FlatBufferBuilder builder, IShowTargetRangeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IShowTargetRange>);
			}
			VectorOffset rangeEntitiesOffset = default(VectorOffset);
			if (_o.RangeEntities != null)
			{
				int[] data = _o.RangeEntities.ToArray();
				rangeEntitiesOffset = IShowTargetRange.CreateRangeEntitiesVector(builder, data);
			}
			return IShowTargetRange.CreateIShowTargetRange(builder, rangeEntitiesOffset, _o.DelayShow);
		}

		// Token: 0x04011B94 RID: 72596
		private Table __p;
	}
}
