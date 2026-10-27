using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020011E8 RID: 4584
	public struct StringArrayLang : IFlatbufferObject
	{
		// Token: 0x17003F4C RID: 16204
		// (get) Token: 0x0600EBC5 RID: 60357 RVA: 0x0034AF1D File Offset: 0x0034911D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600EBC6 RID: 60358 RVA: 0x0034AF2A File Offset: 0x0034912A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600EBC7 RID: 60359 RVA: 0x0034AF34 File Offset: 0x00349134
		public static StringArrayLang GetRootAsStringArrayLang(ByteBuffer _bb)
		{
			return StringArrayLang.GetRootAsStringArrayLang(_bb, default(StringArrayLang));
		}

		// Token: 0x0600EBC8 RID: 60360 RVA: 0x0034AF50 File Offset: 0x00349150
		public static StringArrayLang GetRootAsStringArrayLang(ByteBuffer _bb, StringArrayLang obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600EBC9 RID: 60361 RVA: 0x0034AF6D File Offset: 0x0034916D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600EBCA RID: 60362 RVA: 0x0034AF7C File Offset: 0x0034917C
		public StringArrayLang __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x0600EBCB RID: 60363 RVA: 0x0034AF8C File Offset: 0x0034918C
		public int ArrayString(int j)
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003F4D RID: 16205
		// (get) Token: 0x0600EBCC RID: 60364 RVA: 0x0034AFCC File Offset: 0x003491CC
		public int ArrayStringLength
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

		// Token: 0x0600EBCD RID: 60365 RVA: 0x0034AFF7 File Offset: 0x003491F7
		public Span<int> GetArrayStringBytes()
		{
			return this.__p.__vector_as_span<int>(4, 4);
		}

		// Token: 0x0600EBCE RID: 60366 RVA: 0x0034B006 File Offset: 0x00349206
		public int[] GetArrayStringArray()
		{
			return this.__p.__vector_as_array<int>(4) ?? Array.Empty<int>();
		}

		// Token: 0x0600EBCF RID: 60367 RVA: 0x0034B020 File Offset: 0x00349220
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用ArrayStringIter()或GetArrayStringBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] ArrayString()
		{
			StringArrayLang stringArrayLang = this;
			return stringArrayLang.GetArrayStringArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600EBD0 RID: 60368 RVA: 0x0034B044 File Offset: 0x00349244
		[NullableContext(1)]
		public readonly IEnumerable<int> ArrayStringIter()
		{
			StringArrayLang.<ArrayStringIter>d__14 <ArrayStringIter>d__ = new StringArrayLang.<ArrayStringIter>d__14(-2);
			<ArrayStringIter>d__.<>3__<>4__this = this;
			return <ArrayStringIter>d__;
		}

		// Token: 0x04005361 RID: 21345
		private Table __p;
	}
}
