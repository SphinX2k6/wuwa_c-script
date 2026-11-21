using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000CA4 RID: 3236
	public struct DangoBrawlItemCompose : IFlatbufferObject
	{
		// Token: 0x17000B50 RID: 2896
		// (get) Token: 0x060063B3 RID: 25523 RVA: 0x002298E9 File Offset: 0x00227AE9
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060063B4 RID: 25524 RVA: 0x002298F6 File Offset: 0x00227AF6
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060063B5 RID: 25525 RVA: 0x00229900 File Offset: 0x00227B00
		public static DangoBrawlItemCompose GetRootAsDangoBrawlItemCompose(ByteBuffer _bb)
		{
			return DangoBrawlItemCompose.GetRootAsDangoBrawlItemCompose(_bb, default(DangoBrawlItemCompose));
		}

		// Token: 0x060063B6 RID: 25526 RVA: 0x0022991C File Offset: 0x00227B1C
		public static DangoBrawlItemCompose GetRootAsDangoBrawlItemCompose(ByteBuffer _bb, DangoBrawlItemCompose obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060063B7 RID: 25527 RVA: 0x00229939 File Offset: 0x00227B39
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060063B8 RID: 25528 RVA: 0x00229948 File Offset: 0x00227B48
		public DangoBrawlItemCompose __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000B51 RID: 2897
		// (get) Token: 0x060063B9 RID: 25529 RVA: 0x00229958 File Offset: 0x00227B58
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

		// Token: 0x060063BA RID: 25530 RVA: 0x00229994 File Offset: 0x00227B94
		public int NeedItems(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000B52 RID: 2898
		// (get) Token: 0x060063BB RID: 25531 RVA: 0x002299D4 File Offset: 0x00227BD4
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

		// Token: 0x060063BC RID: 25532 RVA: 0x002299FF File Offset: 0x00227BFF
		public Span<int> GetNeedItemsBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x060063BD RID: 25533 RVA: 0x00229A0E File Offset: 0x00227C0E
		public int[] GetNeedItemsArray()
		{
			return this.__p.__vector_as_array<int>(6) ?? Array.Empty<int>();
		}

		// Token: 0x17000B53 RID: 2899
		// (get) Token: 0x060063BE RID: 25534 RVA: 0x00229A28 File Offset: 0x00227C28
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

		// Token: 0x17000B54 RID: 2900
		// (get) Token: 0x060063BF RID: 25535 RVA: 0x00229A64 File Offset: 0x00227C64
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

		// Token: 0x060063C0 RID: 25536 RVA: 0x00229AA1 File Offset: 0x00227CA1
		[NullableContext(1)]
		public int[] NeedItems()
		{
			return this.GetNeedItemsArray();
		}

		// Token: 0x060063C1 RID: 25537 RVA: 0x00229AA9 File Offset: 0x00227CA9
		[NullableContext(1)]
		public IEnumerable<int> NeedItemsIter()
		{
			DangoBrawlItemCompose.<NeedItemsIter>d__20 <NeedItemsIter>d__ = new DangoBrawlItemCompose.<NeedItemsIter>d__20(-2);
			<NeedItemsIter>d__.<>3__<>4__this = this;
			return <NeedItemsIter>d__;
		}

		// Token: 0x040051CD RID: 20941
		private Table __p;
	}
}
