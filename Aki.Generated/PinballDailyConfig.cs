using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200100D RID: 4109
	public struct PinballDailyConfig : IFlatbufferObject
	{
		// Token: 0x1700298E RID: 10638
		// (get) Token: 0x0600B4BC RID: 46268 RVA: 0x002DDA56 File Offset: 0x002DBC56
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600B4BD RID: 46269 RVA: 0x002DDA63 File Offset: 0x002DBC63
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600B4BE RID: 46270 RVA: 0x002DDA6C File Offset: 0x002DBC6C
		public static PinballDailyConfig GetRootAsPinballDailyConfig(ByteBuffer _bb)
		{
			return PinballDailyConfig.GetRootAsPinballDailyConfig(_bb, default(PinballDailyConfig));
		}

		// Token: 0x0600B4BF RID: 46271 RVA: 0x002DDA88 File Offset: 0x002DBC88
		public static PinballDailyConfig GetRootAsPinballDailyConfig(ByteBuffer _bb, PinballDailyConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600B4C0 RID: 46272 RVA: 0x002DDAA5 File Offset: 0x002DBCA5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600B4C1 RID: 46273 RVA: 0x002DDAB4 File Offset: 0x002DBCB4
		public PinballDailyConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700298F RID: 10639
		// (get) Token: 0x0600B4C2 RID: 46274 RVA: 0x002DDAC4 File Offset: 0x002DBCC4
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

		// Token: 0x17002990 RID: 10640
		// (get) Token: 0x0600B4C3 RID: 46275 RVA: 0x002DDB00 File Offset: 0x002DBD00
		public int LevelCompleteNum
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

		// Token: 0x17002991 RID: 10641
		// (get) Token: 0x0600B4C4 RID: 46276 RVA: 0x002DDB3C File Offset: 0x002DBD3C
		public int DailyClearDropId
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

		// Token: 0x040055D6 RID: 21974
		private Table __p;
	}
}
