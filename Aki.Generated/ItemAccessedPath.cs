using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D7B RID: 3451
	public struct ItemAccessedPath : IFlatbufferObject
	{
		// Token: 0x170019F1 RID: 6641
		// (get) Token: 0x06008630 RID: 34352 RVA: 0x00265820 File Offset: 0x00263A20
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06008631 RID: 34353 RVA: 0x0026582D File Offset: 0x00263A2D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06008632 RID: 34354 RVA: 0x00265834 File Offset: 0x00263A34
		public static ItemAccessedPath GetRootAsItemAccessedPath(ByteBuffer _bb)
		{
			return ItemAccessedPath.GetRootAsItemAccessedPath(_bb, default(ItemAccessedPath));
		}

		// Token: 0x06008633 RID: 34355 RVA: 0x00265850 File Offset: 0x00263A50
		public static ItemAccessedPath GetRootAsItemAccessedPath(ByteBuffer _bb, ItemAccessedPath obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06008634 RID: 34356 RVA: 0x0026586D File Offset: 0x00263A6D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06008635 RID: 34357 RVA: 0x0026587C File Offset: 0x00263A7C
		public ItemAccessedPath __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170019F2 RID: 6642
		// (get) Token: 0x06008636 RID: 34358 RVA: 0x0026588C File Offset: 0x00263A8C
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

		// Token: 0x06008637 RID: 34359 RVA: 0x002658C8 File Offset: 0x00263AC8
		public int GiftItemGroup(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170019F3 RID: 6643
		// (get) Token: 0x06008638 RID: 34360 RVA: 0x00265908 File Offset: 0x00263B08
		public int GiftItemGroupLength
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06008639 RID: 34361 RVA: 0x00265933 File Offset: 0x00263B33
		public Span<int> GetGiftItemGroupBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x0600863A RID: 34362 RVA: 0x00265942 File Offset: 0x00263B42
		public int[] GetGiftItemGroupArray()
		{
			return this.__p.__vector_as_array<int>(6) ?? Array.Empty<int>();
		}

		// Token: 0x0600863B RID: 34363 RVA: 0x0026595C File Offset: 0x00263B5C
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用GiftItemGroupIter()或GetGiftItemGroupBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] GiftItemGroup()
		{
			ItemAccessedPath itemAccessedPath = this;
			return itemAccessedPath.GetGiftItemGroupArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600863C RID: 34364 RVA: 0x00265980 File Offset: 0x00263B80
		[NullableContext(1)]
		public readonly IEnumerable<int> GiftItemGroupIter()
		{
			ItemAccessedPath.<GiftItemGroupIter>d__16 <GiftItemGroupIter>d__ = new ItemAccessedPath.<GiftItemGroupIter>d__16(-2);
			<GiftItemGroupIter>d__.<>3__<>4__this = this;
			return <GiftItemGroupIter>d__;
		}

		// Token: 0x04004E03 RID: 19971
		private Table __p;
	}
}
