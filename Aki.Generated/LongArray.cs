using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020011D2 RID: 4562
	public struct LongArray : IFlatbufferObject
	{
		// Token: 0x17003EFC RID: 16124
		// (get) Token: 0x0600EAC6 RID: 60102 RVA: 0x00348B31 File Offset: 0x00346D31
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600EAC7 RID: 60103 RVA: 0x00348B3E File Offset: 0x00346D3E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600EAC8 RID: 60104 RVA: 0x00348B48 File Offset: 0x00346D48
		public static LongArray GetRootAsLongArray(ByteBuffer _bb)
		{
			return LongArray.GetRootAsLongArray(_bb, default(LongArray));
		}

		// Token: 0x0600EAC9 RID: 60105 RVA: 0x00348B64 File Offset: 0x00346D64
		public static LongArray GetRootAsLongArray(ByteBuffer _bb, LongArray obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600EACA RID: 60106 RVA: 0x00348B81 File Offset: 0x00346D81
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600EACB RID: 60107 RVA: 0x00348B90 File Offset: 0x00346D90
		public LongArray __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x0600EACC RID: 60108 RVA: 0x00348BA0 File Offset: 0x00346DA0
		public long ArrayLong(int j)
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return 0L;
			}
			return this.__p.bb.GetLong(this.__p.__vector(num) + j * 8);
		}

		// Token: 0x17003EFD RID: 16125
		// (get) Token: 0x0600EACD RID: 60109 RVA: 0x00348BE0 File Offset: 0x00346DE0
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

		// Token: 0x0600EACE RID: 60110 RVA: 0x00348C0B File Offset: 0x00346E0B
		public Span<long> GetArrayLongBytes()
		{
			return this.__p.__vector_as_span<long>(4, 8);
		}

		// Token: 0x0600EACF RID: 60111 RVA: 0x00348C1A File Offset: 0x00346E1A
		public long[] GetArrayLongArray()
		{
			return this.__p.__vector_as_array<long>(4) ?? Array.Empty<long>();
		}

		// Token: 0x0600EAD0 RID: 60112 RVA: 0x00348C34 File Offset: 0x00346E34
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用ArrayLongIter()或GetArrayLongBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly long[] ArrayLong()
		{
			LongArray longArray = this;
			return longArray.GetArrayLongArray() ?? Array.Empty<long>();
		}

		// Token: 0x0600EAD1 RID: 60113 RVA: 0x00348C58 File Offset: 0x00346E58
		[NullableContext(1)]
		public readonly IEnumerable<long> ArrayLongIter()
		{
			LongArray.<ArrayLongIter>d__14 <ArrayLongIter>d__ = new LongArray.<ArrayLongIter>d__14(-2);
			<ArrayLongIter>d__.<>3__<>4__this = this;
			return <ArrayLongIter>d__;
		}

		// Token: 0x04005340 RID: 21312
		private Table __p;
	}
}
