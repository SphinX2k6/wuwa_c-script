using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020012FC RID: 4860
	public struct FloatArray : IFlatbufferObject
	{
		// Token: 0x17004246 RID: 16966
		// (get) Token: 0x0600F7D2 RID: 63442 RVA: 0x00372BDC File Offset: 0x00370DDC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600F7D3 RID: 63443 RVA: 0x00372BE9 File Offset: 0x00370DE9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600F7D4 RID: 63444 RVA: 0x00372BF0 File Offset: 0x00370DF0
		public static FloatArray GetRootAsFloatArray(ByteBuffer _bb)
		{
			return FloatArray.GetRootAsFloatArray(_bb, default(FloatArray));
		}

		// Token: 0x0600F7D5 RID: 63445 RVA: 0x00372C0C File Offset: 0x00370E0C
		public static FloatArray GetRootAsFloatArray(ByteBuffer _bb, FloatArray obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600F7D6 RID: 63446 RVA: 0x00372C29 File Offset: 0x00370E29
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600F7D7 RID: 63447 RVA: 0x00372C38 File Offset: 0x00370E38
		public FloatArray __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x0600F7D8 RID: 63448 RVA: 0x00372C48 File Offset: 0x00370E48
		public float ArrayFloat(int j)
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return 0f;
			}
			return this.__p.bb.GetFloat(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17004247 RID: 16967
		// (get) Token: 0x0600F7D9 RID: 63449 RVA: 0x00372C8C File Offset: 0x00370E8C
		public int ArrayFloatLength
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

		// Token: 0x0600F7DA RID: 63450 RVA: 0x00372CB7 File Offset: 0x00370EB7
		public Span<float> GetArrayFloatBytes()
		{
			return this.__p.__vector_as_span<float>(4, 4);
		}

		// Token: 0x0600F7DB RID: 63451 RVA: 0x00372CC6 File Offset: 0x00370EC6
		public float[] GetArrayFloatArray()
		{
			return this.__p.__vector_as_array<float>(4) ?? Array.Empty<float>();
		}

		// Token: 0x0600F7DC RID: 63452 RVA: 0x00372CDD File Offset: 0x00370EDD
		[NullableContext(1)]
		public float[] ArrayFloat()
		{
			return this.GetArrayFloatArray();
		}

		// Token: 0x0600F7DD RID: 63453 RVA: 0x00372CE5 File Offset: 0x00370EE5
		[NullableContext(1)]
		public IEnumerable<float> ArrayFloatIter()
		{
			FloatArray.<ArrayFloatIter>d__14 <ArrayFloatIter>d__ = new FloatArray.<ArrayFloatIter>d__14(-2);
			<ArrayFloatIter>d__.<>3__<>4__this = this;
			return <ArrayFloatIter>d__;
		}

		// Token: 0x0400596C RID: 22892
		private Table __p;
	}
}
