using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E59 RID: 3673
	public struct InstanceRandomPlot : IFlatbufferObject
	{
		// Token: 0x17001A21 RID: 6689
		// (get) Token: 0x06008BB4 RID: 35764 RVA: 0x002827E9 File Offset: 0x002809E9
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06008BB5 RID: 35765 RVA: 0x002827F6 File Offset: 0x002809F6
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06008BB6 RID: 35766 RVA: 0x00282800 File Offset: 0x00280A00
		public static InstanceRandomPlot GetRootAsInstanceRandomPlot(ByteBuffer _bb)
		{
			return InstanceRandomPlot.GetRootAsInstanceRandomPlot(_bb, default(InstanceRandomPlot));
		}

		// Token: 0x06008BB7 RID: 35767 RVA: 0x0028281C File Offset: 0x00280A1C
		public static InstanceRandomPlot GetRootAsInstanceRandomPlot(ByteBuffer _bb, InstanceRandomPlot obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06008BB8 RID: 35768 RVA: 0x00282839 File Offset: 0x00280A39
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06008BB9 RID: 35769 RVA: 0x00282848 File Offset: 0x00280A48
		public InstanceRandomPlot __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001A22 RID: 6690
		// (get) Token: 0x06008BBA RID: 35770 RVA: 0x00282858 File Offset: 0x00280A58
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

		// Token: 0x17001A23 RID: 6691
		// (get) Token: 0x06008BBB RID: 35771 RVA: 0x00282894 File Offset: 0x00280A94
		public int InstId
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

		// Token: 0x06008BBC RID: 35772 RVA: 0x002828D0 File Offset: 0x00280AD0
		public int ActiveTriggerGroupIdList(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001A24 RID: 6692
		// (get) Token: 0x06008BBD RID: 35773 RVA: 0x00282910 File Offset: 0x00280B10
		public int ActiveTriggerGroupIdListLength
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

		// Token: 0x06008BBE RID: 35774 RVA: 0x0028293B File Offset: 0x00280B3B
		public Span<int> GetActiveTriggerGroupIdListBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x06008BBF RID: 35775 RVA: 0x0028294A File Offset: 0x00280B4A
		public int[] GetActiveTriggerGroupIdListArray()
		{
			return this.__p.__vector_as_array<int>(8) ?? Array.Empty<int>();
		}

		// Token: 0x06008BC0 RID: 35776 RVA: 0x00282961 File Offset: 0x00280B61
		[NullableContext(1)]
		public int[] ActiveTriggerGroupIdList()
		{
			return this.GetActiveTriggerGroupIdListArray();
		}

		// Token: 0x06008BC1 RID: 35777 RVA: 0x00282969 File Offset: 0x00280B69
		[NullableContext(1)]
		public IEnumerable<int> ActiveTriggerGroupIdListIter()
		{
			InstanceRandomPlot.<ActiveTriggerGroupIdListIter>d__18 <ActiveTriggerGroupIdListIter>d__ = new InstanceRandomPlot.<ActiveTriggerGroupIdListIter>d__18(-2);
			<ActiveTriggerGroupIdListIter>d__.<>3__<>4__this = this;
			return <ActiveTriggerGroupIdListIter>d__;
		}

		// Token: 0x040053E1 RID: 21473
		private Table __p;
	}
}
