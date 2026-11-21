using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001308 RID: 4872
	public struct Long54Array : IFlatbufferObject
	{
		// Token: 0x17004262 RID: 16994
		// (get) Token: 0x0600F833 RID: 63539 RVA: 0x003736F4 File Offset: 0x003718F4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600F834 RID: 63540 RVA: 0x00373701 File Offset: 0x00371901
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600F835 RID: 63541 RVA: 0x00373708 File Offset: 0x00371908
		public static Long54Array GetRootAsLong54Array(ByteBuffer _bb)
		{
			return Long54Array.GetRootAsLong54Array(_bb, default(Long54Array));
		}

		// Token: 0x0600F836 RID: 63542 RVA: 0x00373724 File Offset: 0x00371924
		public static Long54Array GetRootAsLong54Array(ByteBuffer _bb, Long54Array obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600F837 RID: 63543 RVA: 0x00373741 File Offset: 0x00371941
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600F838 RID: 63544 RVA: 0x00373750 File Offset: 0x00371950
		public Long54Array __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x0600F839 RID: 63545 RVA: 0x00373760 File Offset: 0x00371960
		public long ArrayLong(int j)
		{
			int num = this.__p.__offset(4);
			return (long)((num != 0) ? this.__p.bb.GetDouble(this.__p.__vector(num) + j * 8) : 0.0);
		}

		// Token: 0x17004263 RID: 16995
		// (get) Token: 0x0600F83A RID: 63546 RVA: 0x003737AC File Offset: 0x003719AC
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

		// Token: 0x0600F83B RID: 63547 RVA: 0x003737D7 File Offset: 0x003719D7
		public Span<long> GetArrayLongBytes()
		{
			return MemoryMarshal.Cast<double, long>(this.__p.__vector_as_span<double>(4, 8));
		}

		// Token: 0x0600F83C RID: 63548 RVA: 0x003737EB File Offset: 0x003719EB
		public long[] GetArrayLongArray()
		{
			return Array.ConvertAll<double, long>(this.__p.__vector_as_array<double>(4) ?? Array.Empty<double>(), (double x) => (long)x);
		}

		// Token: 0x0600F83D RID: 63549 RVA: 0x00373826 File Offset: 0x00371A26
		[NullableContext(1)]
		public long[] ArrayLong()
		{
			return this.GetArrayLongArray();
		}

		// Token: 0x0600F83E RID: 63550 RVA: 0x0037382E File Offset: 0x00371A2E
		[NullableContext(1)]
		public IEnumerable<long> ArrayLongIter()
		{
			Long54Array.<ArrayLongIter>d__14 <ArrayLongIter>d__ = new Long54Array.<ArrayLongIter>d__14(-2);
			<ArrayLongIter>d__.<>3__<>4__this = this;
			return <ArrayLongIter>d__;
		}

		// Token: 0x04005983 RID: 22915
		private Table __p;
	}
}
