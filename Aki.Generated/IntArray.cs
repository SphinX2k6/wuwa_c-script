using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020011CC RID: 4556
	public struct IntArray : IFlatbufferObject
	{
		// Token: 0x17003EEC RID: 16108
		// (get) Token: 0x0600EA88 RID: 60040 RVA: 0x00348394 File Offset: 0x00346594
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600EA89 RID: 60041 RVA: 0x003483A1 File Offset: 0x003465A1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600EA8A RID: 60042 RVA: 0x003483A8 File Offset: 0x003465A8
		public static IntArray GetRootAsIntArray(ByteBuffer _bb)
		{
			return IntArray.GetRootAsIntArray(_bb, default(IntArray));
		}

		// Token: 0x0600EA8B RID: 60043 RVA: 0x003483C4 File Offset: 0x003465C4
		public static IntArray GetRootAsIntArray(ByteBuffer _bb, IntArray obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600EA8C RID: 60044 RVA: 0x003483E1 File Offset: 0x003465E1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600EA8D RID: 60045 RVA: 0x003483F0 File Offset: 0x003465F0
		public IntArray __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x0600EA8E RID: 60046 RVA: 0x00348400 File Offset: 0x00346600
		public int ArrayInt(int j)
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003EED RID: 16109
		// (get) Token: 0x0600EA8F RID: 60047 RVA: 0x00348440 File Offset: 0x00346640
		public int ArrayIntLength
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

		// Token: 0x0600EA90 RID: 60048 RVA: 0x0034846B File Offset: 0x0034666B
		public Span<int> GetArrayIntBytes()
		{
			return this.__p.__vector_as_span<int>(4, 4);
		}

		// Token: 0x0600EA91 RID: 60049 RVA: 0x0034847A File Offset: 0x0034667A
		public int[] GetArrayIntArray()
		{
			return this.__p.__vector_as_array<int>(4) ?? Array.Empty<int>();
		}

		// Token: 0x0600EA92 RID: 60050 RVA: 0x00348494 File Offset: 0x00346694
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用ArrayIntIter()或GetArrayIntBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] ArrayInt()
		{
			IntArray intArray = this;
			return intArray.GetArrayIntArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600EA93 RID: 60051 RVA: 0x003484B8 File Offset: 0x003466B8
		[NullableContext(1)]
		public readonly IEnumerable<int> ArrayIntIter()
		{
			IntArray.<ArrayIntIter>d__14 <ArrayIntIter>d__ = new IntArray.<ArrayIntIter>d__14(-2);
			<ArrayIntIter>d__.<>3__<>4__this = this;
			return <ArrayIntIter>d__;
		}

		// Token: 0x04005339 RID: 21305
		private Table __p;
	}
}
