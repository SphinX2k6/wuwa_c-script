using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001309 RID: 4873
	public struct LongArray : IFlatbufferObject
	{
		// Token: 0x17004264 RID: 16996
		// (get) Token: 0x0600F83F RID: 63551 RVA: 0x00373843 File Offset: 0x00371A43
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600F840 RID: 63552 RVA: 0x00373850 File Offset: 0x00371A50
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600F841 RID: 63553 RVA: 0x00373858 File Offset: 0x00371A58
		public static LongArray GetRootAsLongArray(ByteBuffer _bb)
		{
			return LongArray.GetRootAsLongArray(_bb, default(LongArray));
		}

		// Token: 0x0600F842 RID: 63554 RVA: 0x00373874 File Offset: 0x00371A74
		public static LongArray GetRootAsLongArray(ByteBuffer _bb, LongArray obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600F843 RID: 63555 RVA: 0x00373891 File Offset: 0x00371A91
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600F844 RID: 63556 RVA: 0x003738A0 File Offset: 0x00371AA0
		public LongArray __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x0600F845 RID: 63557 RVA: 0x003738B0 File Offset: 0x00371AB0
		public long ArrayLong(int j)
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return 0L;
			}
			return this.__p.bb.GetLong(this.__p.__vector(num) + j * 8);
		}

		// Token: 0x17004265 RID: 16997
		// (get) Token: 0x0600F846 RID: 63558 RVA: 0x003738F0 File Offset: 0x00371AF0
		public int ArrayLongLength
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

		// Token: 0x0600F847 RID: 63559 RVA: 0x0037391B File Offset: 0x00371B1B
		public Span<long> GetArrayLongBytes()
		{
			return this.__p.__vector_as_span<long>(4, 8);
		}

		// Token: 0x0600F848 RID: 63560 RVA: 0x0037392A File Offset: 0x00371B2A
		public long[] GetArrayLongArray()
		{
			return this.__p.__vector_as_array<long>(4) ?? Array.Empty<long>();
		}

		// Token: 0x0600F849 RID: 63561 RVA: 0x00373941 File Offset: 0x00371B41
		[NullableContext(1)]
		public long[] ArrayLong()
		{
			return this.GetArrayLongArray();
		}

		// Token: 0x0600F84A RID: 63562 RVA: 0x00373949 File Offset: 0x00371B49
		[NullableContext(1)]
		public IEnumerable<long> ArrayLongIter()
		{
			LongArray.<ArrayLongIter>d__14 <ArrayLongIter>d__ = new LongArray.<ArrayLongIter>d__14(-2);
			<ArrayLongIter>d__.<>3__<>4__this = this;
			return <ArrayLongIter>d__;
		}

		// Token: 0x04005984 RID: 22916
		private Table __p;
	}
}
