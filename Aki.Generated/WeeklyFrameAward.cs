using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020012D9 RID: 4825
	public struct WeeklyFrameAward : IFlatbufferObject
	{
		// Token: 0x170041BE RID: 16830
		// (get) Token: 0x0600F672 RID: 63090 RVA: 0x0036FEA9 File Offset: 0x0036E0A9
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600F673 RID: 63091 RVA: 0x0036FEB6 File Offset: 0x0036E0B6
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600F674 RID: 63092 RVA: 0x0036FEC0 File Offset: 0x0036E0C0
		public static WeeklyFrameAward GetRootAsWeeklyFrameAward(ByteBuffer _bb)
		{
			return WeeklyFrameAward.GetRootAsWeeklyFrameAward(_bb, default(WeeklyFrameAward));
		}

		// Token: 0x0600F675 RID: 63093 RVA: 0x0036FEDC File Offset: 0x0036E0DC
		public static WeeklyFrameAward GetRootAsWeeklyFrameAward(ByteBuffer _bb, WeeklyFrameAward obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600F676 RID: 63094 RVA: 0x0036FEF9 File Offset: 0x0036E0F9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600F677 RID: 63095 RVA: 0x0036FF08 File Offset: 0x0036E108
		public WeeklyFrameAward __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170041BF RID: 16831
		// (get) Token: 0x0600F678 RID: 63096 RVA: 0x0036FF18 File Offset: 0x0036E118
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

		// Token: 0x170041C0 RID: 16832
		// (get) Token: 0x0600F679 RID: 63097 RVA: 0x0036FF54 File Offset: 0x0036E154
		public int Score
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

		// Token: 0x170041C1 RID: 16833
		// (get) Token: 0x0600F67A RID: 63098 RVA: 0x0036FF90 File Offset: 0x0036E190
		public int DropId
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

		// Token: 0x04005932 RID: 22834
		private Table __p;
	}
}
