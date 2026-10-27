using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020011D1 RID: 4561
	public struct Long54Array : IFlatbufferObject
	{
		// Token: 0x17003EFA RID: 16122
		// (get) Token: 0x0600EABA RID: 60090 RVA: 0x003489C4 File Offset: 0x00346BC4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600EABB RID: 60091 RVA: 0x003489D1 File Offset: 0x00346BD1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600EABC RID: 60092 RVA: 0x003489D8 File Offset: 0x00346BD8
		public static Long54Array GetRootAsLong54Array(ByteBuffer _bb)
		{
			return Long54Array.GetRootAsLong54Array(_bb, default(Long54Array));
		}

		// Token: 0x0600EABD RID: 60093 RVA: 0x003489F4 File Offset: 0x00346BF4
		public static Long54Array GetRootAsLong54Array(ByteBuffer _bb, Long54Array obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600EABE RID: 60094 RVA: 0x00348A11 File Offset: 0x00346C11
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600EABF RID: 60095 RVA: 0x00348A20 File Offset: 0x00346C20
		public Long54Array __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x0600EAC0 RID: 60096 RVA: 0x00348A30 File Offset: 0x00346C30
		public long ArrayLong(int j)
		{
			int num = this.__p.__offset(4);
			return (long)((num != 0) ? this.__p.bb.GetDouble(this.__p.__vector(num) + j * 8) : 0.0);
		}

		// Token: 0x17003EFB RID: 16123
		// (get) Token: 0x0600EAC1 RID: 60097 RVA: 0x00348A7C File Offset: 0x00346C7C
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

		// Token: 0x0600EAC2 RID: 60098 RVA: 0x00348AA7 File Offset: 0x00346CA7
		public Span<long> GetArrayLongBytes()
		{
			return MemoryMarshal.Cast<double, long>(this.__p.__vector_as_span<double>(4, 8));
		}

		// Token: 0x0600EAC3 RID: 60099 RVA: 0x00348ABB File Offset: 0x00346CBB
		public long[] GetArrayLongArray()
		{
			return Array.ConvertAll<double, long>(this.__p.__vector_as_array<double>(4) ?? Array.Empty<double>(), (double x) => (long)x);
		}

		// Token: 0x0600EAC4 RID: 60100 RVA: 0x00348AF8 File Offset: 0x00346CF8
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用ArrayLongIter()或GetArrayLongBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly long[] ArrayLong()
		{
			Long54Array long54Array = this;
			return long54Array.GetArrayLongArray() ?? Array.Empty<long>();
		}

		// Token: 0x0600EAC5 RID: 60101 RVA: 0x00348B1C File Offset: 0x00346D1C
		[NullableContext(1)]
		public readonly IEnumerable<long> ArrayLongIter()
		{
			Long54Array.<ArrayLongIter>d__14 <ArrayLongIter>d__ = new Long54Array.<ArrayLongIter>d__14(-2);
			<ArrayLongIter>d__.<>3__<>4__this = this;
			return <ArrayLongIter>d__;
		}

		// Token: 0x0400533F RID: 21311
		private Table __p;
	}
}
