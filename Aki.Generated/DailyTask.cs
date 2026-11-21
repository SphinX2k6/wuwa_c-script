using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C95 RID: 3221
	public struct DailyTask : IFlatbufferObject
	{
		// Token: 0x17000A4D RID: 2637
		// (get) Token: 0x060060E8 RID: 24808 RVA: 0x002231F8 File Offset: 0x002213F8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060060E9 RID: 24809 RVA: 0x00223205 File Offset: 0x00221405
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060060EA RID: 24810 RVA: 0x0022320C File Offset: 0x0022140C
		public static DailyTask GetRootAsDailyTask(ByteBuffer _bb)
		{
			return DailyTask.GetRootAsDailyTask(_bb, default(DailyTask));
		}

		// Token: 0x060060EB RID: 24811 RVA: 0x00223228 File Offset: 0x00221428
		public static DailyTask GetRootAsDailyTask(ByteBuffer _bb, DailyTask obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060060EC RID: 24812 RVA: 0x00223245 File Offset: 0x00221445
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060060ED RID: 24813 RVA: 0x00223254 File Offset: 0x00221454
		public DailyTask __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000A4E RID: 2638
		// (get) Token: 0x060060EE RID: 24814 RVA: 0x00223264 File Offset: 0x00221464
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

		// Token: 0x040051B9 RID: 20921
		private Table __p;
	}
}
