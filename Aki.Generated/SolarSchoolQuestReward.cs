using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020011F9 RID: 4601
	public struct SolarSchoolQuestReward : IFlatbufferObject
	{
		// Token: 0x17003A3B RID: 14907
		// (get) Token: 0x0600E2FC RID: 58108 RVA: 0x0034477D File Offset: 0x0034297D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600E2FD RID: 58109 RVA: 0x0034478A File Offset: 0x0034298A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600E2FE RID: 58110 RVA: 0x00344794 File Offset: 0x00342994
		public static SolarSchoolQuestReward GetRootAsSolarSchoolQuestReward(ByteBuffer _bb)
		{
			return SolarSchoolQuestReward.GetRootAsSolarSchoolQuestReward(_bb, default(SolarSchoolQuestReward));
		}

		// Token: 0x0600E2FF RID: 58111 RVA: 0x003447B0 File Offset: 0x003429B0
		public static SolarSchoolQuestReward GetRootAsSolarSchoolQuestReward(ByteBuffer _bb, SolarSchoolQuestReward obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600E300 RID: 58112 RVA: 0x003447CD File Offset: 0x003429CD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600E301 RID: 58113 RVA: 0x003447DC File Offset: 0x003429DC
		public SolarSchoolQuestReward __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003A3C RID: 14908
		// (get) Token: 0x0600E302 RID: 58114 RVA: 0x003447EC File Offset: 0x003429EC
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

		// Token: 0x17003A3D RID: 14909
		// (get) Token: 0x0600E303 RID: 58115 RVA: 0x00344828 File Offset: 0x00342A28
		public string Desc
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600E304 RID: 58116 RVA: 0x0034485F File Offset: 0x00342A5F
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600E305 RID: 58117 RVA: 0x0034486E File Offset: 0x00342A6E
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17003A3E RID: 14910
		// (get) Token: 0x0600E306 RID: 58118 RVA: 0x00344888 File Offset: 0x00342A88
		public int Sort
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

		// Token: 0x17003A3F RID: 14911
		// (get) Token: 0x0600E307 RID: 58119 RVA: 0x003448C4 File Offset: 0x00342AC4
		public int ConditionId
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

		// Token: 0x17003A40 RID: 14912
		// (get) Token: 0x0600E308 RID: 58120 RVA: 0x00344904 File Offset: 0x00342B04
		public bool LocalCondition
		{
			get
			{
				int num = this.__p.__offset(12);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17003A41 RID: 14913
		// (get) Token: 0x0600E309 RID: 58121 RVA: 0x00344944 File Offset: 0x00342B44
		public string TxtHelpInfo
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600E30A RID: 58122 RVA: 0x0034497C File Offset: 0x00342B7C
		public Span<byte> GetTxtHelpInfoBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600E30B RID: 58123 RVA: 0x0034498C File Offset: 0x00342B8C
		public byte[] GetTxtHelpInfoArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17003A42 RID: 14914
		// (get) Token: 0x0600E30C RID: 58124 RVA: 0x003449A4 File Offset: 0x00342BA4
		public int RewardProgress
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

		// Token: 0x17003A43 RID: 14915
		// (get) Token: 0x0600E30D RID: 58125 RVA: 0x003449E4 File Offset: 0x00342BE4
		public int JumpMap
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return -1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17003A44 RID: 14916
		// (get) Token: 0x0600E30E RID: 58126 RVA: 0x00344A24 File Offset: 0x00342C24
		public int JumpSchedule
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return -1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17003A45 RID: 14917
		// (get) Token: 0x0600E30F RID: 58127 RVA: 0x00344A64 File Offset: 0x00342C64
		public int JumpFriend
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return -1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x04005837 RID: 22583
		private Table __p;
	}
}
