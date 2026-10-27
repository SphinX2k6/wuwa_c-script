using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020010D6 RID: 4310
	public struct Sort : IFlatbufferObject
	{
		// Token: 0x1700378C RID: 14220
		// (get) Token: 0x0600D730 RID: 55088 RVA: 0x0031C780 File Offset: 0x0031A980
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600D731 RID: 55089 RVA: 0x0031C78D File Offset: 0x0031A98D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600D732 RID: 55090 RVA: 0x0031C794 File Offset: 0x0031A994
		public static Sort GetRootAsSort(ByteBuffer _bb)
		{
			return Sort.GetRootAsSort(_bb, default(Sort));
		}

		// Token: 0x0600D733 RID: 55091 RVA: 0x0031C7B0 File Offset: 0x0031A9B0
		public static Sort GetRootAsSort(ByteBuffer _bb, Sort obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600D734 RID: 55092 RVA: 0x0031C7CD File Offset: 0x0031A9CD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600D735 RID: 55093 RVA: 0x0031C7DC File Offset: 0x0031A9DC
		public Sort __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700378D RID: 14221
		// (get) Token: 0x0600D736 RID: 55094 RVA: 0x0031C7EC File Offset: 0x0031A9EC
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

		// Token: 0x0600D737 RID: 55095 RVA: 0x0031C828 File Offset: 0x0031AA28
		public int FrontSortList(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700378E RID: 14222
		// (get) Token: 0x0600D738 RID: 55096 RVA: 0x0031C868 File Offset: 0x0031AA68
		public int FrontSortListLength
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

		// Token: 0x0600D739 RID: 55097 RVA: 0x0031C893 File Offset: 0x0031AA93
		public Span<int> GetFrontSortListBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x0600D73A RID: 55098 RVA: 0x0031C8A2 File Offset: 0x0031AAA2
		public int[] GetFrontSortListArray()
		{
			return this.__p.__vector_as_array<int>(6) ?? Array.Empty<int>();
		}

		// Token: 0x0600D73B RID: 55099 RVA: 0x0031C8BC File Offset: 0x0031AABC
		public int BaseSortList(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700378F RID: 14223
		// (get) Token: 0x0600D73C RID: 55100 RVA: 0x0031C8FC File Offset: 0x0031AAFC
		public int BaseSortListLength
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

		// Token: 0x0600D73D RID: 55101 RVA: 0x0031C927 File Offset: 0x0031AB27
		public Span<int> GetBaseSortListBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x0600D73E RID: 55102 RVA: 0x0031C936 File Offset: 0x0031AB36
		public int[] GetBaseSortListArray()
		{
			return this.__p.__vector_as_array<int>(8) ?? Array.Empty<int>();
		}

		// Token: 0x0600D73F RID: 55103 RVA: 0x0031C950 File Offset: 0x0031AB50
		public int AttributeSortList(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003790 RID: 14224
		// (get) Token: 0x0600D740 RID: 55104 RVA: 0x0031C990 File Offset: 0x0031AB90
		public int AttributeSortListLength
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

		// Token: 0x0600D741 RID: 55105 RVA: 0x0031C9BC File Offset: 0x0031ABBC
		public Span<int> GetAttributeSortListBytes()
		{
			return this.__p.__vector_as_span<int>(10, 4);
		}

		// Token: 0x0600D742 RID: 55106 RVA: 0x0031C9CC File Offset: 0x0031ABCC
		public int[] GetAttributeSortListArray()
		{
			return this.__p.__vector_as_array<int>(10) ?? Array.Empty<int>();
		}

		// Token: 0x0600D743 RID: 55107 RVA: 0x0031C9E4 File Offset: 0x0031ABE4
		public int LastSortList(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003791 RID: 14225
		// (get) Token: 0x0600D744 RID: 55108 RVA: 0x0031CA24 File Offset: 0x0031AC24
		public int LastSortListLength
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

		// Token: 0x0600D745 RID: 55109 RVA: 0x0031CA50 File Offset: 0x0031AC50
		public Span<int> GetLastSortListBytes()
		{
			return this.__p.__vector_as_span<int>(12, 4);
		}

		// Token: 0x0600D746 RID: 55110 RVA: 0x0031CA60 File Offset: 0x0031AC60
		public int[] GetLastSortListArray()
		{
			return this.__p.__vector_as_array<int>(12) ?? Array.Empty<int>();
		}

		// Token: 0x17003792 RID: 14226
		// (get) Token: 0x0600D747 RID: 55111 RVA: 0x0031CA78 File Offset: 0x0031AC78
		public int LimitNum
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17003793 RID: 14227
		// (get) Token: 0x0600D748 RID: 55112 RVA: 0x0031CAB8 File Offset: 0x0031ACB8
		public int DataId
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600D749 RID: 55113 RVA: 0x0031CAF8 File Offset: 0x0031ACF8
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用AttributeSortListIter()或GetAttributeSortListBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] AttributeSortList()
		{
			Sort sort = this;
			return sort.GetAttributeSortListArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600D74A RID: 55114 RVA: 0x0031CB1C File Offset: 0x0031AD1C
		[NullableContext(1)]
		public readonly IEnumerable<int> AttributeSortListIter()
		{
			Sort.<AttributeSortListIter>d__35 <AttributeSortListIter>d__ = new Sort.<AttributeSortListIter>d__35(-2);
			<AttributeSortListIter>d__.<>3__<>4__this = this;
			return <AttributeSortListIter>d__;
		}

		// Token: 0x0600D74B RID: 55115 RVA: 0x0031CB34 File Offset: 0x0031AD34
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用BaseSortListIter()或GetBaseSortListBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] BaseSortList()
		{
			Sort sort = this;
			return sort.GetBaseSortListArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600D74C RID: 55116 RVA: 0x0031CB58 File Offset: 0x0031AD58
		[NullableContext(1)]
		public readonly IEnumerable<int> BaseSortListIter()
		{
			Sort.<BaseSortListIter>d__37 <BaseSortListIter>d__ = new Sort.<BaseSortListIter>d__37(-2);
			<BaseSortListIter>d__.<>3__<>4__this = this;
			return <BaseSortListIter>d__;
		}

		// Token: 0x0600D74D RID: 55117 RVA: 0x0031CB70 File Offset: 0x0031AD70
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用FrontSortListIter()或GetFrontSortListBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] FrontSortList()
		{
			Sort sort = this;
			return sort.GetFrontSortListArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600D74E RID: 55118 RVA: 0x0031CB94 File Offset: 0x0031AD94
		[NullableContext(1)]
		public readonly IEnumerable<int> FrontSortListIter()
		{
			Sort.<FrontSortListIter>d__39 <FrontSortListIter>d__ = new Sort.<FrontSortListIter>d__39(-2);
			<FrontSortListIter>d__.<>3__<>4__this = this;
			return <FrontSortListIter>d__;
		}

		// Token: 0x0600D74F RID: 55119 RVA: 0x0031CBAC File Offset: 0x0031ADAC
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用LastSortListIter()或GetLastSortListBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] LastSortList()
		{
			Sort sort = this;
			return sort.GetLastSortListArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600D750 RID: 55120 RVA: 0x0031CBD0 File Offset: 0x0031ADD0
		[NullableContext(1)]
		public readonly IEnumerable<int> LastSortListIter()
		{
			Sort.<LastSortListIter>d__41 <LastSortListIter>d__ = new Sort.<LastSortListIter>d__41(-2);
			<LastSortListIter>d__.<>3__<>4__this = this;
			return <LastSortListIter>d__;
		}

		// Token: 0x04005209 RID: 21001
		private Table __p;
	}
}
