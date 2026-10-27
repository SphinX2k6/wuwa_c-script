using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000BB3 RID: 2995
	public struct DailyTask : IFlatbufferObject
	{
		// Token: 0x17000A07 RID: 2567
		// (get) Token: 0x06005B0F RID: 23311 RVA: 0x00203550 File Offset: 0x00201750
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06005B10 RID: 23312 RVA: 0x0020355D File Offset: 0x0020175D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06005B11 RID: 23313 RVA: 0x00203564 File Offset: 0x00201764
		public static DailyTask GetRootAsDailyTask(ByteBuffer _bb)
		{
			return DailyTask.GetRootAsDailyTask(_bb, default(DailyTask));
		}

		// Token: 0x06005B12 RID: 23314 RVA: 0x00203580 File Offset: 0x00201780
		public static DailyTask GetRootAsDailyTask(ByteBuffer _bb, DailyTask obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06005B13 RID: 23315 RVA: 0x0020359D File Offset: 0x0020179D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06005B14 RID: 23316 RVA: 0x002035AC File Offset: 0x002017AC
		public DailyTask __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000A08 RID: 2568
		// (get) Token: 0x06005B15 RID: 23317 RVA: 0x002035BC File Offset: 0x002017BC
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

		// Token: 0x04004BD7 RID: 19415
		private Table __p;
	}
}
