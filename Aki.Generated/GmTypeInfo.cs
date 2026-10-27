using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D08 RID: 3336
	public struct GmTypeInfo : IFlatbufferObject
	{
		// Token: 0x170015E4 RID: 5604
		// (get) Token: 0x06007B4F RID: 31567 RVA: 0x0024CFE9 File Offset: 0x0024B1E9
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06007B50 RID: 31568 RVA: 0x0024CFF6 File Offset: 0x0024B1F6
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06007B51 RID: 31569 RVA: 0x0024D000 File Offset: 0x0024B200
		public static GmTypeInfo GetRootAsGmTypeInfo(ByteBuffer _bb)
		{
			return GmTypeInfo.GetRootAsGmTypeInfo(_bb, default(GmTypeInfo));
		}

		// Token: 0x06007B52 RID: 31570 RVA: 0x0024D01C File Offset: 0x0024B21C
		public static GmTypeInfo GetRootAsGmTypeInfo(ByteBuffer _bb, GmTypeInfo obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06007B53 RID: 31571 RVA: 0x0024D039 File Offset: 0x0024B239
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06007B54 RID: 31572 RVA: 0x0024D048 File Offset: 0x0024B248
		public GmTypeInfo __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170015E5 RID: 5605
		// (get) Token: 0x06007B55 RID: 31573 RVA: 0x0024D058 File Offset: 0x0024B258
		public int Id
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170015E6 RID: 5606
		// (get) Token: 0x06007B56 RID: 31574 RVA: 0x0024D094 File Offset: 0x0024B294
		public string Name
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06007B57 RID: 31575 RVA: 0x0024D0CB File Offset: 0x0024B2CB
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06007B58 RID: 31576 RVA: 0x0024D0DA File Offset: 0x0024B2DA
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x06007B59 RID: 31577 RVA: 0x0024D0F4 File Offset: 0x0024B2F4
		public string KeyWords(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170015E7 RID: 5607
		// (get) Token: 0x06007B5A RID: 31578 RVA: 0x0024D130 File Offset: 0x0024B330
		public int KeyWordsLength
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06007B5B RID: 31579 RVA: 0x0024D15C File Offset: 0x0024B35C
		public int GmOrderConfigList(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170015E8 RID: 5608
		// (get) Token: 0x06007B5C RID: 31580 RVA: 0x0024D19C File Offset: 0x0024B39C
		public int GmOrderConfigListLength
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06007B5D RID: 31581 RVA: 0x0024D1C8 File Offset: 0x0024B3C8
		public Span<int> GetGmOrderConfigListBytes()
		{
			return this.__p.__vector_as_span<int>(10, 4);
		}

		// Token: 0x06007B5E RID: 31582 RVA: 0x0024D1D8 File Offset: 0x0024B3D8
		public int[] GetGmOrderConfigListArray()
		{
			return this.__p.__vector_as_array<int>(10) ?? Array.Empty<int>();
		}

		// Token: 0x06007B5F RID: 31583 RVA: 0x0024D1F0 File Offset: 0x0024B3F0
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用GmOrderConfigListIter()或GetGmOrderConfigListBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] GmOrderConfigList()
		{
			GmTypeInfo gmTypeInfo = this;
			return gmTypeInfo.GetGmOrderConfigListArray() ?? Array.Empty<int>();
		}

		// Token: 0x06007B60 RID: 31584 RVA: 0x0024D214 File Offset: 0x0024B414
		[NullableContext(1)]
		public readonly IEnumerable<int> GmOrderConfigListIter()
		{
			GmTypeInfo.<GmOrderConfigListIter>d__23 <GmOrderConfigListIter>d__ = new GmTypeInfo.<GmOrderConfigListIter>d__23(-2);
			<GmOrderConfigListIter>d__.<>3__<>4__this = this;
			return <GmOrderConfigListIter>d__;
		}

		// Token: 0x06007B61 RID: 31585 RVA: 0x0024D229 File Offset: 0x0024B429
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用KeyWordsIter()或GetKeyWordsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] KeyWords()
		{
			return this.KeyWordsIter().ToArray<string>();
		}

		// Token: 0x06007B62 RID: 31586 RVA: 0x0024D236 File Offset: 0x0024B436
		[NullableContext(1)]
		public readonly IEnumerable<string> KeyWordsIter()
		{
			GmTypeInfo.<KeyWordsIter>d__25 <KeyWordsIter>d__ = new GmTypeInfo.<KeyWordsIter>d__25(-2);
			<KeyWordsIter>d__.<>3__<>4__this = this;
			return <KeyWordsIter>d__;
		}

		// Token: 0x04004D7E RID: 19838
		private Table __p;
	}
}
