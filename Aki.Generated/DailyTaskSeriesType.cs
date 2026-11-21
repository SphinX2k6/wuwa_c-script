using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C98 RID: 3224
	public struct DailyTaskSeriesType : IFlatbufferObject
	{
		// Token: 0x17000A56 RID: 2646
		// (get) Token: 0x06006105 RID: 24837 RVA: 0x0022351A File Offset: 0x0022171A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06006106 RID: 24838 RVA: 0x00223527 File Offset: 0x00221727
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06006107 RID: 24839 RVA: 0x00223530 File Offset: 0x00221730
		public static DailyTaskSeriesType GetRootAsDailyTaskSeriesType(ByteBuffer _bb)
		{
			return DailyTaskSeriesType.GetRootAsDailyTaskSeriesType(_bb, default(DailyTaskSeriesType));
		}

		// Token: 0x06006108 RID: 24840 RVA: 0x0022354C File Offset: 0x0022174C
		public static DailyTaskSeriesType GetRootAsDailyTaskSeriesType(ByteBuffer _bb, DailyTaskSeriesType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06006109 RID: 24841 RVA: 0x00223569 File Offset: 0x00221769
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600610A RID: 24842 RVA: 0x00223578 File Offset: 0x00221778
		public DailyTaskSeriesType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000A57 RID: 2647
		// (get) Token: 0x0600610B RID: 24843 RVA: 0x00223588 File Offset: 0x00221788
		public int SeriesType
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

		// Token: 0x040051BC RID: 20924
		private Table __p;
	}
}
