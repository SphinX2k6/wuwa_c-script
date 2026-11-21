using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C97 RID: 3223
	public struct DailyTaskGroup : IFlatbufferObject
	{
		// Token: 0x17000A51 RID: 2641
		// (get) Token: 0x060060F6 RID: 24822 RVA: 0x00223348 File Offset: 0x00221548
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060060F7 RID: 24823 RVA: 0x00223355 File Offset: 0x00221555
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060060F8 RID: 24824 RVA: 0x0022335C File Offset: 0x0022155C
		public static DailyTaskGroup GetRootAsDailyTaskGroup(ByteBuffer _bb)
		{
			return DailyTaskGroup.GetRootAsDailyTaskGroup(_bb, default(DailyTaskGroup));
		}

		// Token: 0x060060F9 RID: 24825 RVA: 0x00223378 File Offset: 0x00221578
		public static DailyTaskGroup GetRootAsDailyTaskGroup(ByteBuffer _bb, DailyTaskGroup obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060060FA RID: 24826 RVA: 0x00223395 File Offset: 0x00221595
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060060FB RID: 24827 RVA: 0x002233A4 File Offset: 0x002215A4
		public DailyTaskGroup __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000A52 RID: 2642
		// (get) Token: 0x060060FC RID: 24828 RVA: 0x002233B4 File Offset: 0x002215B4
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

		// Token: 0x060060FD RID: 24829 RVA: 0x002233F0 File Offset: 0x002215F0
		public int TaskIds(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000A53 RID: 2643
		// (get) Token: 0x060060FE RID: 24830 RVA: 0x00223430 File Offset: 0x00221630
		public int TaskIdsLength
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

		// Token: 0x060060FF RID: 24831 RVA: 0x0022345B File Offset: 0x0022165B
		public Span<int> GetTaskIdsBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x06006100 RID: 24832 RVA: 0x0022346A File Offset: 0x0022166A
		public int[] GetTaskIdsArray()
		{
			return this.__p.__vector_as_array<int>(6) ?? Array.Empty<int>();
		}

		// Token: 0x17000A54 RID: 2644
		// (get) Token: 0x06006101 RID: 24833 RVA: 0x00223484 File Offset: 0x00221684
		public int TypeId
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

		// Token: 0x17000A55 RID: 2645
		// (get) Token: 0x06006102 RID: 24834 RVA: 0x002234C0 File Offset: 0x002216C0
		public int CountryId
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

		// Token: 0x06006103 RID: 24835 RVA: 0x002234FD File Offset: 0x002216FD
		[NullableContext(1)]
		public int[] TaskIds()
		{
			return this.GetTaskIdsArray();
		}

		// Token: 0x06006104 RID: 24836 RVA: 0x00223505 File Offset: 0x00221705
		[NullableContext(1)]
		public IEnumerable<int> TaskIdsIter()
		{
			DailyTaskGroup.<TaskIdsIter>d__20 <TaskIdsIter>d__ = new DailyTaskGroup.<TaskIdsIter>d__20(-2);
			<TaskIdsIter>d__.<>3__<>4__this = this;
			return <TaskIdsIter>d__;
		}

		// Token: 0x040051BB RID: 20923
		private Table __p;
	}
}
