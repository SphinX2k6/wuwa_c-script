using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000BC2 RID: 3010
	public struct DangoBrawlItemCompose : IFlatbufferObject
	{
		// Token: 0x17000B0A RID: 2826
		// (get) Token: 0x06005DDA RID: 24026 RVA: 0x0020A117 File Offset: 0x00208317
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06005DDB RID: 24027 RVA: 0x0020A124 File Offset: 0x00208324
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06005DDC RID: 24028 RVA: 0x0020A12C File Offset: 0x0020832C
		public static DangoBrawlItemCompose GetRootAsDangoBrawlItemCompose(ByteBuffer _bb)
		{
			return DangoBrawlItemCompose.GetRootAsDangoBrawlItemCompose(_bb, default(DangoBrawlItemCompose));
		}

		// Token: 0x06005DDD RID: 24029 RVA: 0x0020A148 File Offset: 0x00208348
		public static DangoBrawlItemCompose GetRootAsDangoBrawlItemCompose(ByteBuffer _bb, DangoBrawlItemCompose obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06005DDE RID: 24030 RVA: 0x0020A165 File Offset: 0x00208365
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06005DDF RID: 24031 RVA: 0x0020A174 File Offset: 0x00208374
		public DangoBrawlItemCompose __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000B0B RID: 2827
		// (get) Token: 0x06005DE0 RID: 24032 RVA: 0x0020A184 File Offset: 0x00208384
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

		// Token: 0x06005DE1 RID: 24033 RVA: 0x0020A1C0 File Offset: 0x002083C0
		public int NeedItems(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000B0C RID: 2828
		// (get) Token: 0x06005DE2 RID: 24034 RVA: 0x0020A200 File Offset: 0x00208400
		public int NeedItemsLength
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

		// Token: 0x06005DE3 RID: 24035 RVA: 0x0020A22B File Offset: 0x0020842B
		public Span<int> GetNeedItemsBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x06005DE4 RID: 24036 RVA: 0x0020A23A File Offset: 0x0020843A
		public int[] GetNeedItemsArray()
		{
			return this.__p.__vector_as_array<int>(6) ?? Array.Empty<int>();
		}

		// Token: 0x17000B0D RID: 2829
		// (get) Token: 0x06005DE5 RID: 24037 RVA: 0x0020A254 File Offset: 0x00208454
		public int MainItemId
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

		// Token: 0x17000B0E RID: 2830
		// (get) Token: 0x06005DE6 RID: 24038 RVA: 0x0020A290 File Offset: 0x00208490
		public int ResultItemId
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

		// Token: 0x06005DE7 RID: 24039 RVA: 0x0020A2D0 File Offset: 0x002084D0
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用NeedItemsIter()或GetNeedItemsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] NeedItems()
		{
			DangoBrawlItemCompose dangoBrawlItemCompose = this;
			return dangoBrawlItemCompose.GetNeedItemsArray() ?? Array.Empty<int>();
		}

		// Token: 0x06005DE8 RID: 24040 RVA: 0x0020A2F4 File Offset: 0x002084F4
		[NullableContext(1)]
		public readonly IEnumerable<int> NeedItemsIter()
		{
			DangoBrawlItemCompose.<NeedItemsIter>d__20 <NeedItemsIter>d__ = new DangoBrawlItemCompose.<NeedItemsIter>d__20(-2);
			<NeedItemsIter>d__.<>3__<>4__this = this;
			return <NeedItemsIter>d__;
		}

		// Token: 0x04004BEB RID: 19435
		private Table __p;
	}
}
