using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001302 RID: 4866
	public struct IntArray : IFlatbufferObject
	{
		// Token: 0x17004251 RID: 16977
		// (get) Token: 0x0600F7F9 RID: 63481 RVA: 0x00373000 File Offset: 0x00371200
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600F7FA RID: 63482 RVA: 0x0037300D File Offset: 0x0037120D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600F7FB RID: 63483 RVA: 0x00373014 File Offset: 0x00371214
		public static IntArray GetRootAsIntArray(ByteBuffer _bb)
		{
			return IntArray.GetRootAsIntArray(_bb, default(IntArray));
		}

		// Token: 0x0600F7FC RID: 63484 RVA: 0x00373030 File Offset: 0x00371230
		public static IntArray GetRootAsIntArray(ByteBuffer _bb, IntArray obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600F7FD RID: 63485 RVA: 0x0037304D File Offset: 0x0037124D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600F7FE RID: 63486 RVA: 0x0037305C File Offset: 0x0037125C
		public IntArray __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x0600F7FF RID: 63487 RVA: 0x0037306C File Offset: 0x0037126C
		public int ArrayInt(int j)
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17004252 RID: 16978
		// (get) Token: 0x0600F800 RID: 63488 RVA: 0x003730AC File Offset: 0x003712AC
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

		// Token: 0x0600F801 RID: 63489 RVA: 0x003730D7 File Offset: 0x003712D7
		public Span<int> GetArrayIntBytes()
		{
			return this.__p.__vector_as_span<int>(4, 4);
		}

		// Token: 0x0600F802 RID: 63490 RVA: 0x003730E6 File Offset: 0x003712E6
		public int[] GetArrayIntArray()
		{
			return this.__p.__vector_as_array<int>(4) ?? Array.Empty<int>();
		}

		// Token: 0x0600F803 RID: 63491 RVA: 0x003730FD File Offset: 0x003712FD
		[NullableContext(1)]
		public int[] ArrayInt()
		{
			return this.GetArrayIntArray();
		}

		// Token: 0x0600F804 RID: 63492 RVA: 0x00373105 File Offset: 0x00371305
		[NullableContext(1)]
		public IEnumerable<int> ArrayIntIter()
		{
			IntArray.<ArrayIntIter>d__14 <ArrayIntIter>d__ = new IntArray.<ArrayIntIter>d__14(-2);
			<ArrayIntIter>d__.<>3__<>4__this = this;
			return <ArrayIntIter>d__;
		}

		// Token: 0x0400597C RID: 22908
		private Table __p;
	}
}
