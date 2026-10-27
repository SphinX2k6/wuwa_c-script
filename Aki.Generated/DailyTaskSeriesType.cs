using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000BB6 RID: 2998
	public struct DailyTaskSeriesType : IFlatbufferObject
	{
		// Token: 0x17000A10 RID: 2576
		// (get) Token: 0x06005B2C RID: 23340 RVA: 0x00203891 File Offset: 0x00201A91
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06005B2D RID: 23341 RVA: 0x0020389E File Offset: 0x00201A9E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06005B2E RID: 23342 RVA: 0x002038A8 File Offset: 0x00201AA8
		public static DailyTaskSeriesType GetRootAsDailyTaskSeriesType(ByteBuffer _bb)
		{
			return DailyTaskSeriesType.GetRootAsDailyTaskSeriesType(_bb, default(DailyTaskSeriesType));
		}

		// Token: 0x06005B2F RID: 23343 RVA: 0x002038C4 File Offset: 0x00201AC4
		public static DailyTaskSeriesType GetRootAsDailyTaskSeriesType(ByteBuffer _bb, DailyTaskSeriesType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06005B30 RID: 23344 RVA: 0x002038E1 File Offset: 0x00201AE1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06005B31 RID: 23345 RVA: 0x002038F0 File Offset: 0x00201AF0
		public DailyTaskSeriesType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000A11 RID: 2577
		// (get) Token: 0x06005B32 RID: 23346 RVA: 0x00203900 File Offset: 0x00201B00
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

		// Token: 0x04004BDA RID: 19418
		private Table __p;
	}
}
