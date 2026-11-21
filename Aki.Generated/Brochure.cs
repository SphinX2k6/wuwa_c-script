using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C2F RID: 3119
	public struct Brochure : IFlatbufferObject
	{
		// Token: 0x17000645 RID: 1605
		// (get) Token: 0x06005576 RID: 21878 RVA: 0x00208D88 File Offset: 0x00206F88
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06005577 RID: 21879 RVA: 0x00208D95 File Offset: 0x00206F95
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06005578 RID: 21880 RVA: 0x00208D9C File Offset: 0x00206F9C
		public static Brochure GetRootAsBrochure(ByteBuffer _bb)
		{
			return Brochure.GetRootAsBrochure(_bb, default(Brochure));
		}

		// Token: 0x06005579 RID: 21881 RVA: 0x00208DB8 File Offset: 0x00206FB8
		public static Brochure GetRootAsBrochure(ByteBuffer _bb, Brochure obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600557A RID: 21882 RVA: 0x00208DD5 File Offset: 0x00206FD5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600557B RID: 21883 RVA: 0x00208DE4 File Offset: 0x00206FE4
		public Brochure __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000646 RID: 1606
		// (get) Token: 0x0600557C RID: 21884 RVA: 0x00208DF4 File Offset: 0x00206FF4
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

		// Token: 0x17000647 RID: 1607
		// (get) Token: 0x0600557D RID: 21885 RVA: 0x00208E30 File Offset: 0x00207030
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

		// Token: 0x17000648 RID: 1608
		// (get) Token: 0x0600557E RID: 21886 RVA: 0x00208E6C File Offset: 0x0020706C
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

		// Token: 0x17000649 RID: 1609
		// (get) Token: 0x0600557F RID: 21887 RVA: 0x00208EA8 File Offset: 0x002070A8
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

		// Token: 0x06005580 RID: 21888 RVA: 0x00208EE8 File Offset: 0x002070E8
		public int BookItemIds(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700064A RID: 1610
		// (get) Token: 0x06005581 RID: 21889 RVA: 0x00208F28 File Offset: 0x00207128
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

		// Token: 0x06005582 RID: 21890 RVA: 0x00208F54 File Offset: 0x00207154
		public Span<int> GetBookItemIdsBytes()
		{
			return this.__p.__vector_as_span<int>(12, 4);
		}

		// Token: 0x06005583 RID: 21891 RVA: 0x00208F64 File Offset: 0x00207164
		public int[] GetBookItemIdsArray()
		{
			return this.__p.__vector_as_array<int>(12) ?? Array.Empty<int>();
		}

		// Token: 0x06005584 RID: 21892 RVA: 0x00208F7C File Offset: 0x0020717C
		[NullableContext(1)]
		public int[] BookItemIds()
		{
			return this.GetBookItemIdsArray();
		}

		// Token: 0x06005585 RID: 21893 RVA: 0x00208F84 File Offset: 0x00207184
		[NullableContext(1)]
		public IEnumerable<int> BookItemIdsIter()
		{
			Brochure.<BookItemIdsIter>d__22 <BookItemIdsIter>d__ = new Brochure.<BookItemIdsIter>d__22(-2);
			<BookItemIdsIter>d__.<>3__<>4__this = this;
			return <BookItemIdsIter>d__;
		}

		// Token: 0x0400512A RID: 20778
		private Table __p;
	}
}
