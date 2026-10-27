using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020011E7 RID: 4583
	public struct StringArray : IFlatbufferObject
	{
		// Token: 0x17003F4A RID: 16202
		// (get) Token: 0x0600EBBB RID: 60347 RVA: 0x0034AE28 File Offset: 0x00349028
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600EBBC RID: 60348 RVA: 0x0034AE35 File Offset: 0x00349035
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600EBBD RID: 60349 RVA: 0x0034AE3C File Offset: 0x0034903C
		public static StringArray GetRootAsStringArray(ByteBuffer _bb)
		{
			return StringArray.GetRootAsStringArray(_bb, default(StringArray));
		}

		// Token: 0x0600EBBE RID: 60350 RVA: 0x0034AE58 File Offset: 0x00349058
		public static StringArray GetRootAsStringArray(ByteBuffer _bb, StringArray obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600EBBF RID: 60351 RVA: 0x0034AE75 File Offset: 0x00349075
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600EBC0 RID: 60352 RVA: 0x0034AE84 File Offset: 0x00349084
		public StringArray __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x0600EBC1 RID: 60353 RVA: 0x0034AE94 File Offset: 0x00349094
		public string ArrayString(int j)
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003F4B RID: 16203
		// (get) Token: 0x0600EBC2 RID: 60354 RVA: 0x0034AED0 File Offset: 0x003490D0
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

		// Token: 0x0600EBC3 RID: 60355 RVA: 0x0034AEFB File Offset: 0x003490FB
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用ArrayStringIter()或GetArrayStringBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] ArrayString()
		{
			return this.ArrayStringIter().ToArray<string>();
		}

		// Token: 0x0600EBC4 RID: 60356 RVA: 0x0034AF08 File Offset: 0x00349108
		[NullableContext(1)]
		public readonly IEnumerable<string> ArrayStringIter()
		{
			StringArray.<ArrayStringIter>d__12 <ArrayStringIter>d__ = new StringArray.<ArrayStringIter>d__12(-2);
			<ArrayStringIter>d__.<>3__<>4__this = this;
			return <ArrayStringIter>d__;
		}

		// Token: 0x04005360 RID: 21344
		private Table __p;
	}
}
