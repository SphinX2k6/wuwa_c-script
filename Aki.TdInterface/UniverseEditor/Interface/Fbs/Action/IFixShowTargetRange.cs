using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006E5A RID: 28250
	public struct IFixShowTargetRange : IFlatbufferObject
	{
		// Token: 0x1700CF0D RID: 53005
		// (get) Token: 0x06030CC8 RID: 199880 RVA: 0x0069F4C3 File Offset: 0x0069D6C3
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06030CC9 RID: 199881 RVA: 0x0069F4D0 File Offset: 0x0069D6D0
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06030CCA RID: 199882 RVA: 0x0069F4D8 File Offset: 0x0069D6D8
		public static IFixShowTargetRange GetRootAsIFixShowTargetRange(ByteBuffer _bb)
		{
			return IFixShowTargetRange.GetRootAsIFixShowTargetRange(_bb, default(IFixShowTargetRange));
		}

		// Token: 0x06030CCB RID: 199883 RVA: 0x0069F4F4 File Offset: 0x0069D6F4
		public static IFixShowTargetRange GetRootAsIFixShowTargetRange(ByteBuffer _bb, IFixShowTargetRange obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06030CCC RID: 199884 RVA: 0x0069F511 File Offset: 0x0069D711
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06030CCD RID: 199885 RVA: 0x0069F520 File Offset: 0x0069D720
		public IFixShowTargetRange __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x06030CCE RID: 199886 RVA: 0x0069F530 File Offset: 0x0069D730
		public int RangeEntities(int j)
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700CF0E RID: 53006
		// (get) Token: 0x06030CCF RID: 199887 RVA: 0x0069F570 File Offset: 0x0069D770
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

		// Token: 0x06030CD0 RID: 199888 RVA: 0x0069F59B File Offset: 0x0069D79B
		public Span<int> GetRangeEntitiesBytes()
		{
			return this.__p.__vector_as_span<int>(4, 4);
		}

		// Token: 0x06030CD1 RID: 199889 RVA: 0x0069F5AA File Offset: 0x0069D7AA
		public int[] GetRangeEntitiesArray()
		{
			return this.__p.__vector_as_array<int>(4);
		}

		// Token: 0x1700CF0F RID: 53007
		// (get) Token: 0x06030CD2 RID: 199890 RVA: 0x0069F5B8 File Offset: 0x0069D7B8
		public bool DelayShow
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x06030CD3 RID: 199891 RVA: 0x0069F5F7 File Offset: 0x0069D7F7
		public static Offset<IFixShowTargetRange> CreateIFixShowTargetRange(FlatBufferBuilder builder, VectorOffset RangeEntitiesOffset = default(VectorOffset), bool DelayShow = false)
		{
			builder.StartTable(2);
			IFixShowTargetRange.AddRangeEntities(builder, RangeEntitiesOffset);
			IFixShowTargetRange.AddDelayShow(builder, DelayShow);
			return IFixShowTargetRange.EndIFixShowTargetRange(builder);
		}

		// Token: 0x06030CD4 RID: 199892 RVA: 0x0069F614 File Offset: 0x0069D814
		public static void StartIFixShowTargetRange(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06030CD5 RID: 199893 RVA: 0x0069F61D File Offset: 0x0069D81D
		public static void AddRangeEntities(FlatBufferBuilder builder, VectorOffset rangeEntitiesOffset)
		{
			builder.AddOffset(0, rangeEntitiesOffset.Value, 0);
		}

		// Token: 0x06030CD6 RID: 199894 RVA: 0x0069F630 File Offset: 0x0069D830
		public static VectorOffset CreateRangeEntitiesVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06030CD7 RID: 199895 RVA: 0x0069F667 File Offset: 0x0069D867
		public static VectorOffset CreateRangeEntitiesVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06030CD8 RID: 199896 RVA: 0x0069F681 File Offset: 0x0069D881
		public static VectorOffset CreateRangeEntitiesVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06030CD9 RID: 199897 RVA: 0x0069F69F File Offset: 0x0069D89F
		public static VectorOffset CreateRangeEntitiesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06030CDA RID: 199898 RVA: 0x0069F6B8 File Offset: 0x0069D8B8
		public static void StartRangeEntitiesVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06030CDB RID: 199899 RVA: 0x0069F6C3 File Offset: 0x0069D8C3
		public static void AddDelayShow(FlatBufferBuilder builder, bool delayShow)
		{
			builder.AddBool(1, delayShow, false);
		}

		// Token: 0x06030CDC RID: 199900 RVA: 0x0069F6CE File Offset: 0x0069D8CE
		public static Offset<IFixShowTargetRange> EndIFixShowTargetRange(FlatBufferBuilder builder)
		{
			return new Offset<IFixShowTargetRange>(builder.EndTable());
		}

		// Token: 0x06030CDD RID: 199901 RVA: 0x0069F6DC File Offset: 0x0069D8DC
		public IFixShowTargetRangeT UnPack()
		{
			IFixShowTargetRangeT fixShowTargetRangeT = new IFixShowTargetRangeT();
			this.UnPackTo(fixShowTargetRangeT);
			return fixShowTargetRangeT;
		}

		// Token: 0x06030CDE RID: 199902 RVA: 0x0069F6F8 File Offset: 0x0069D8F8
		public void UnPackTo(IFixShowTargetRangeT _o)
		{
			_o.RangeEntities = new List<int>();
			for (int i = 0; i < this.RangeEntitiesLength; i++)
			{
				_o.RangeEntities.Add(this.RangeEntities(i));
			}
			_o.DelayShow = this.DelayShow;
		}

		// Token: 0x06030CDF RID: 199903 RVA: 0x0069F740 File Offset: 0x0069D940
		public static Offset<IFixShowTargetRange> Pack(FlatBufferBuilder builder, IFixShowTargetRangeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFixShowTargetRange>);
			}
			VectorOffset rangeEntitiesOffset = default(VectorOffset);
			if (_o.RangeEntities != null)
			{
				int[] data = _o.RangeEntities.ToArray();
				rangeEntitiesOffset = IFixShowTargetRange.CreateRangeEntitiesVector(builder, data);
			}
			return IFixShowTargetRange.CreateIFixShowTargetRange(builder, rangeEntitiesOffset, _o.DelayShow);
		}

		// Token: 0x04011D27 RID: 72999
		private Table __p;
	}
}
