using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020011C6 RID: 4550
	public struct FloatArray : IFlatbufferObject
	{
		// Token: 0x17003EE1 RID: 16097
		// (get) Token: 0x0600EA61 RID: 60001 RVA: 0x00347F50 File Offset: 0x00346150
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600EA62 RID: 60002 RVA: 0x00347F5D File Offset: 0x0034615D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600EA63 RID: 60003 RVA: 0x00347F64 File Offset: 0x00346164
		public static FloatArray GetRootAsFloatArray(ByteBuffer _bb)
		{
			return FloatArray.GetRootAsFloatArray(_bb, default(FloatArray));
		}

		// Token: 0x0600EA64 RID: 60004 RVA: 0x00347F80 File Offset: 0x00346180
		public static FloatArray GetRootAsFloatArray(ByteBuffer _bb, FloatArray obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600EA65 RID: 60005 RVA: 0x00347F9D File Offset: 0x0034619D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600EA66 RID: 60006 RVA: 0x00347FAC File Offset: 0x003461AC
		public FloatArray __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x0600EA67 RID: 60007 RVA: 0x00347FBC File Offset: 0x003461BC
		public float ArrayFloat(int j)
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return 0f;
			}
			return this.__p.bb.GetFloat(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003EE2 RID: 16098
		// (get) Token: 0x0600EA68 RID: 60008 RVA: 0x00348000 File Offset: 0x00346200
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

		// Token: 0x0600EA69 RID: 60009 RVA: 0x0034802B File Offset: 0x0034622B
		public Span<float> GetArrayFloatBytes()
		{
			return this.__p.__vector_as_span<float>(4, 4);
		}

		// Token: 0x0600EA6A RID: 60010 RVA: 0x0034803A File Offset: 0x0034623A
		public float[] GetArrayFloatArray()
		{
			return this.__p.__vector_as_array<float>(4) ?? Array.Empty<float>();
		}

		// Token: 0x0600EA6B RID: 60011 RVA: 0x00348054 File Offset: 0x00346254
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用ArrayFloatIter()或GetArrayFloatBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly float[] ArrayFloat()
		{
			FloatArray floatArray = this;
			return floatArray.GetArrayFloatArray() ?? Array.Empty<float>();
		}

		// Token: 0x0600EA6C RID: 60012 RVA: 0x00348078 File Offset: 0x00346278
		[NullableContext(1)]
		public readonly IEnumerable<float> ArrayFloatIter()
		{
			FloatArray.<ArrayFloatIter>d__14 <ArrayFloatIter>d__ = new FloatArray.<ArrayFloatIter>d__14(-2);
			<ArrayFloatIter>d__.<>3__<>4__this = this;
			return <ArrayFloatIter>d__;
		}

		// Token: 0x04005329 RID: 21289
		private Table __p;
	}
}
