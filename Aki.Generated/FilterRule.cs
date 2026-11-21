using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D52 RID: 3410
	public struct FilterRule : IFlatbufferObject
	{
		// Token: 0x17001150 RID: 4432
		// (get) Token: 0x0600744D RID: 29773 RVA: 0x0024DC19 File Offset: 0x0024BE19
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600744E RID: 29774 RVA: 0x0024DC26 File Offset: 0x0024BE26
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600744F RID: 29775 RVA: 0x0024DC30 File Offset: 0x0024BE30
		public static FilterRule GetRootAsFilterRule(ByteBuffer _bb)
		{
			return FilterRule.GetRootAsFilterRule(_bb, default(FilterRule));
		}

		// Token: 0x06007450 RID: 29776 RVA: 0x0024DC4C File Offset: 0x0024BE4C
		public static FilterRule GetRootAsFilterRule(ByteBuffer _bb, FilterRule obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06007451 RID: 29777 RVA: 0x0024DC69 File Offset: 0x0024BE69
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06007452 RID: 29778 RVA: 0x0024DC78 File Offset: 0x0024BE78
		public FilterRule __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001151 RID: 4433
		// (get) Token: 0x06007453 RID: 29779 RVA: 0x0024DC88 File Offset: 0x0024BE88
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

		// Token: 0x17001152 RID: 4434
		// (get) Token: 0x06007454 RID: 29780 RVA: 0x0024DCC4 File Offset: 0x0024BEC4
		public int FilterType
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

		// Token: 0x17001153 RID: 4435
		// (get) Token: 0x06007455 RID: 29781 RVA: 0x0024DD00 File Offset: 0x0024BF00
		public string Title
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06007456 RID: 29782 RVA: 0x0024DD37 File Offset: 0x0024BF37
		public Span<byte> GetTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06007457 RID: 29783 RVA: 0x0024DD46 File Offset: 0x0024BF46
		public byte[] GetTitleArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x06007458 RID: 29784 RVA: 0x0024DD60 File Offset: 0x0024BF60
		public int IdList(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001154 RID: 4436
		// (get) Token: 0x06007459 RID: 29785 RVA: 0x0024DDA0 File Offset: 0x0024BFA0
		public int IdListLength
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

		// Token: 0x0600745A RID: 29786 RVA: 0x0024DDCC File Offset: 0x0024BFCC
		public Span<int> GetIdListBytes()
		{
			return this.__p.__vector_as_span<int>(10, 4);
		}

		// Token: 0x0600745B RID: 29787 RVA: 0x0024DDDC File Offset: 0x0024BFDC
		public int[] GetIdListArray()
		{
			return this.__p.__vector_as_array<int>(10) ?? Array.Empty<int>();
		}

		// Token: 0x17001155 RID: 4437
		// (get) Token: 0x0600745C RID: 29788 RVA: 0x0024DDF4 File Offset: 0x0024BFF4
		public bool NeedChangeColor
		{
			get
			{
				int num = this.__p.__offset(12);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0600745D RID: 29789 RVA: 0x0024DE34 File Offset: 0x0024C034
		[NullableContext(1)]
		public int[] IdList()
		{
			return this.GetIdListArray();
		}

		// Token: 0x0600745E RID: 29790 RVA: 0x0024DE3C File Offset: 0x0024C03C
		[NullableContext(1)]
		public IEnumerable<int> IdListIter()
		{
			FilterRule.<IdListIter>d__24 <IdListIter>d__ = new FilterRule.<IdListIter>d__24(-2);
			<IdListIter>d__.<>3__<>4__this = this;
			return <IdListIter>d__;
		}

		// Token: 0x0400529D RID: 21149
		private Table __p;
	}
}
