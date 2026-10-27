using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B4F RID: 2895
	public struct Brochure : IFlatbufferObject
	{
		// Token: 0x17000605 RID: 1541
		// (get) Token: 0x06004FB4 RID: 20404 RVA: 0x001E8C48 File Offset: 0x001E6E48
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06004FB5 RID: 20405 RVA: 0x001E8C55 File Offset: 0x001E6E55
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06004FB6 RID: 20406 RVA: 0x001E8C5C File Offset: 0x001E6E5C
		public static Brochure GetRootAsBrochure(ByteBuffer _bb)
		{
			return Brochure.GetRootAsBrochure(_bb, default(Brochure));
		}

		// Token: 0x06004FB7 RID: 20407 RVA: 0x001E8C78 File Offset: 0x001E6E78
		public static Brochure GetRootAsBrochure(ByteBuffer _bb, Brochure obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06004FB8 RID: 20408 RVA: 0x001E8C95 File Offset: 0x001E6E95
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06004FB9 RID: 20409 RVA: 0x001E8CA4 File Offset: 0x001E6EA4
		public Brochure __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000606 RID: 1542
		// (get) Token: 0x06004FBA RID: 20410 RVA: 0x001E8CB4 File Offset: 0x001E6EB4
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

		// Token: 0x17000607 RID: 1543
		// (get) Token: 0x06004FBB RID: 20411 RVA: 0x001E8CF0 File Offset: 0x001E6EF0
		public int ActivityId
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000608 RID: 1544
		// (get) Token: 0x06004FBC RID: 20412 RVA: 0x001E8D2C File Offset: 0x001E6F2C
		public int Type
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000609 RID: 1545
		// (get) Token: 0x06004FBD RID: 20413 RVA: 0x001E8D68 File Offset: 0x001E6F68
		public int ConditionGroup
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06004FBE RID: 20414 RVA: 0x001E8DA8 File Offset: 0x001E6FA8
		public int BookItemIds(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700060A RID: 1546
		// (get) Token: 0x06004FBF RID: 20415 RVA: 0x001E8DE8 File Offset: 0x001E6FE8
		public int BookItemIdsLength
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06004FC0 RID: 20416 RVA: 0x001E8E14 File Offset: 0x001E7014
		public Span<int> GetBookItemIdsBytes()
		{
			return this.__p.__vector_as_span<int>(12, 4);
		}

		// Token: 0x06004FC1 RID: 20417 RVA: 0x001E8E24 File Offset: 0x001E7024
		public int[] GetBookItemIdsArray()
		{
			return this.__p.__vector_as_array<int>(12) ?? Array.Empty<int>();
		}

		// Token: 0x06004FC2 RID: 20418 RVA: 0x001E8E3C File Offset: 0x001E703C
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用BookItemIdsIter()或GetBookItemIdsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] BookItemIds()
		{
			Brochure brochure = this;
			return brochure.GetBookItemIdsArray() ?? Array.Empty<int>();
		}

		// Token: 0x06004FC3 RID: 20419 RVA: 0x001E8E60 File Offset: 0x001E7060
		[NullableContext(1)]
		public readonly IEnumerable<int> BookItemIdsIter()
		{
			Brochure.<BookItemIdsIter>d__22 <BookItemIdsIter>d__ = new Brochure.<BookItemIdsIter>d__22(-2);
			<BookItemIdsIter>d__.<>3__<>4__this = this;
			return <BookItemIdsIter>d__;
		}

		// Token: 0x04004B4A RID: 19274
		private Table __p;
	}
}
