using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200120C RID: 4620
	public struct Sort : IFlatbufferObject
	{
		// Token: 0x17003AE2 RID: 15074
		// (get) Token: 0x0600E47B RID: 58491 RVA: 0x00347E90 File Offset: 0x00346090
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600E47C RID: 58492 RVA: 0x00347E9D File Offset: 0x0034609D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600E47D RID: 58493 RVA: 0x00347EA4 File Offset: 0x003460A4
		public static Sort GetRootAsSort(ByteBuffer _bb)
		{
			return Sort.GetRootAsSort(_bb, default(Sort));
		}

		// Token: 0x0600E47E RID: 58494 RVA: 0x00347EC0 File Offset: 0x003460C0
		public static Sort GetRootAsSort(ByteBuffer _bb, Sort obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600E47F RID: 58495 RVA: 0x00347EDD File Offset: 0x003460DD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600E480 RID: 58496 RVA: 0x00347EEC File Offset: 0x003460EC
		public Sort __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003AE3 RID: 15075
		// (get) Token: 0x0600E481 RID: 58497 RVA: 0x00347EFC File Offset: 0x003460FC
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

		// Token: 0x0600E482 RID: 58498 RVA: 0x00347F38 File Offset: 0x00346138
		public int FrontSortList(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003AE4 RID: 15076
		// (get) Token: 0x0600E483 RID: 58499 RVA: 0x00347F78 File Offset: 0x00346178
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

		// Token: 0x0600E484 RID: 58500 RVA: 0x00347FA3 File Offset: 0x003461A3
		public Span<int> GetFrontSortListBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x0600E485 RID: 58501 RVA: 0x00347FB2 File Offset: 0x003461B2
		public int[] GetFrontSortListArray()
		{
			return this.__p.__vector_as_array<int>(6) ?? Array.Empty<int>();
		}

		// Token: 0x0600E486 RID: 58502 RVA: 0x00347FCC File Offset: 0x003461CC
		public int BaseSortList(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003AE5 RID: 15077
		// (get) Token: 0x0600E487 RID: 58503 RVA: 0x0034800C File Offset: 0x0034620C
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

		// Token: 0x0600E488 RID: 58504 RVA: 0x00348037 File Offset: 0x00346237
		public Span<int> GetBaseSortListBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x0600E489 RID: 58505 RVA: 0x00348046 File Offset: 0x00346246
		public int[] GetBaseSortListArray()
		{
			return this.__p.__vector_as_array<int>(8) ?? Array.Empty<int>();
		}

		// Token: 0x0600E48A RID: 58506 RVA: 0x00348060 File Offset: 0x00346260
		public int AttributeSortList(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003AE6 RID: 15078
		// (get) Token: 0x0600E48B RID: 58507 RVA: 0x003480A0 File Offset: 0x003462A0
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

		// Token: 0x0600E48C RID: 58508 RVA: 0x003480CC File Offset: 0x003462CC
		public Span<int> GetAttributeSortListBytes()
		{
			return this.__p.__vector_as_span<int>(10, 4);
		}

		// Token: 0x0600E48D RID: 58509 RVA: 0x003480DC File Offset: 0x003462DC
		public int[] GetAttributeSortListArray()
		{
			return this.__p.__vector_as_array<int>(10) ?? Array.Empty<int>();
		}

		// Token: 0x0600E48E RID: 58510 RVA: 0x003480F4 File Offset: 0x003462F4
		public int LastSortList(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003AE7 RID: 15079
		// (get) Token: 0x0600E48F RID: 58511 RVA: 0x00348134 File Offset: 0x00346334
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

		// Token: 0x0600E490 RID: 58512 RVA: 0x00348160 File Offset: 0x00346360
		public Span<int> GetLastSortListBytes()
		{
			return this.__p.__vector_as_span<int>(12, 4);
		}

		// Token: 0x0600E491 RID: 58513 RVA: 0x00348170 File Offset: 0x00346370
		public int[] GetLastSortListArray()
		{
			return this.__p.__vector_as_array<int>(12) ?? Array.Empty<int>();
		}

		// Token: 0x17003AE8 RID: 15080
		// (get) Token: 0x0600E492 RID: 58514 RVA: 0x00348188 File Offset: 0x00346388
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

		// Token: 0x17003AE9 RID: 15081
		// (get) Token: 0x0600E493 RID: 58515 RVA: 0x003481C8 File Offset: 0x003463C8
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

		// Token: 0x0600E494 RID: 58516 RVA: 0x00348205 File Offset: 0x00346405
		[NullableContext(1)]
		public int[] AttributeSortList()
		{
			return this.GetAttributeSortListArray();
		}

		// Token: 0x0600E495 RID: 58517 RVA: 0x0034820D File Offset: 0x0034640D
		[NullableContext(1)]
		public IEnumerable<int> AttributeSortListIter()
		{
			Sort.<AttributeSortListIter>d__35 <AttributeSortListIter>d__ = new Sort.<AttributeSortListIter>d__35(-2);
			<AttributeSortListIter>d__.<>3__<>4__this = this;
			return <AttributeSortListIter>d__;
		}

		// Token: 0x0600E496 RID: 58518 RVA: 0x00348222 File Offset: 0x00346422
		[NullableContext(1)]
		public int[] BaseSortList()
		{
			return this.GetBaseSortListArray();
		}

		// Token: 0x0600E497 RID: 58519 RVA: 0x0034822A File Offset: 0x0034642A
		[NullableContext(1)]
		public IEnumerable<int> BaseSortListIter()
		{
			Sort.<BaseSortListIter>d__37 <BaseSortListIter>d__ = new Sort.<BaseSortListIter>d__37(-2);
			<BaseSortListIter>d__.<>3__<>4__this = this;
			return <BaseSortListIter>d__;
		}

		// Token: 0x0600E498 RID: 58520 RVA: 0x0034823F File Offset: 0x0034643F
		[NullableContext(1)]
		public int[] FrontSortList()
		{
			return this.GetFrontSortListArray();
		}

		// Token: 0x0600E499 RID: 58521 RVA: 0x00348247 File Offset: 0x00346447
		[NullableContext(1)]
		public IEnumerable<int> FrontSortListIter()
		{
			Sort.<FrontSortListIter>d__39 <FrontSortListIter>d__ = new Sort.<FrontSortListIter>d__39(-2);
			<FrontSortListIter>d__.<>3__<>4__this = this;
			return <FrontSortListIter>d__;
		}

		// Token: 0x0600E49A RID: 58522 RVA: 0x0034825C File Offset: 0x0034645C
		[NullableContext(1)]
		public int[] LastSortList()
		{
			return this.GetLastSortListArray();
		}

		// Token: 0x0600E49B RID: 58523 RVA: 0x00348264 File Offset: 0x00346464
		[NullableContext(1)]
		public IEnumerable<int> LastSortListIter()
		{
			Sort.<LastSortListIter>d__41 <LastSortListIter>d__ = new Sort.<LastSortListIter>d__41(-2);
			<LastSortListIter>d__.<>3__<>4__this = this;
			return <LastSortListIter>d__;
		}

		// Token: 0x0400584C RID: 22604
		private Table __p;
	}
}
