using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001203 RID: 4611
	public struct SolarSchoolScratchTicketRe : IFlatbufferObject
	{
		// Token: 0x17003A9F RID: 15007
		// (get) Token: 0x0600E3E9 RID: 58345 RVA: 0x00346885 File Offset: 0x00344A85
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600E3EA RID: 58346 RVA: 0x00346892 File Offset: 0x00344A92
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600E3EB RID: 58347 RVA: 0x0034689C File Offset: 0x00344A9C
		public static SolarSchoolScratchTicketRe GetRootAsSolarSchoolScratchTicketRe(ByteBuffer _bb)
		{
			return SolarSchoolScratchTicketRe.GetRootAsSolarSchoolScratchTicketRe(_bb, default(SolarSchoolScratchTicketRe));
		}

		// Token: 0x0600E3EC RID: 58348 RVA: 0x003468B8 File Offset: 0x00344AB8
		public static SolarSchoolScratchTicketRe GetRootAsSolarSchoolScratchTicketRe(ByteBuffer _bb, SolarSchoolScratchTicketRe obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600E3ED RID: 58349 RVA: 0x003468D5 File Offset: 0x00344AD5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600E3EE RID: 58350 RVA: 0x003468E4 File Offset: 0x00344AE4
		public SolarSchoolScratchTicketRe __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003AA0 RID: 15008
		// (get) Token: 0x0600E3EF RID: 58351 RVA: 0x003468F4 File Offset: 0x00344AF4
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

		// Token: 0x17003AA1 RID: 15009
		// (get) Token: 0x0600E3F0 RID: 58352 RVA: 0x00346930 File Offset: 0x00344B30
		public int RoundId
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

		// Token: 0x17003AA2 RID: 15010
		// (get) Token: 0x0600E3F1 RID: 58353 RVA: 0x0034696C File Offset: 0x00344B6C
		public int Weight
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

		// Token: 0x17003AA3 RID: 15011
		// (get) Token: 0x0600E3F2 RID: 58354 RVA: 0x003469A8 File Offset: 0x00344BA8
		public int RewardId
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

		// Token: 0x04005841 RID: 22593
		private Table __p;
	}
}
