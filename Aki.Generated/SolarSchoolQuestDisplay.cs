using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020011F7 RID: 4599
	public struct SolarSchoolQuestDisplay : IFlatbufferObject
	{
		// Token: 0x17003A29 RID: 14889
		// (get) Token: 0x0600E2DC RID: 58076 RVA: 0x0034427D File Offset: 0x0034247D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600E2DD RID: 58077 RVA: 0x0034428A File Offset: 0x0034248A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600E2DE RID: 58078 RVA: 0x00344294 File Offset: 0x00342494
		public static SolarSchoolQuestDisplay GetRootAsSolarSchoolQuestDisplay(ByteBuffer _bb)
		{
			return SolarSchoolQuestDisplay.GetRootAsSolarSchoolQuestDisplay(_bb, default(SolarSchoolQuestDisplay));
		}

		// Token: 0x0600E2DF RID: 58079 RVA: 0x003442B0 File Offset: 0x003424B0
		public static SolarSchoolQuestDisplay GetRootAsSolarSchoolQuestDisplay(ByteBuffer _bb, SolarSchoolQuestDisplay obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600E2E0 RID: 58080 RVA: 0x003442CD File Offset: 0x003424CD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600E2E1 RID: 58081 RVA: 0x003442DC File Offset: 0x003424DC
		public SolarSchoolQuestDisplay __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003A2A RID: 14890
		// (get) Token: 0x0600E2E2 RID: 58082 RVA: 0x003442EC File Offset: 0x003424EC
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

		// Token: 0x17003A2B RID: 14891
		// (get) Token: 0x0600E2E3 RID: 58083 RVA: 0x00344328 File Offset: 0x00342528
		public int ActivityId
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

		// Token: 0x17003A2C RID: 14892
		// (get) Token: 0x0600E2E4 RID: 58084 RVA: 0x00344364 File Offset: 0x00342564
		public int StartDayIndex
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

		// Token: 0x17003A2D RID: 14893
		// (get) Token: 0x0600E2E5 RID: 58085 RVA: 0x003443A0 File Offset: 0x003425A0
		public int EndDayIndex
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

		// Token: 0x17003A2E RID: 14894
		// (get) Token: 0x0600E2E6 RID: 58086 RVA: 0x003443E0 File Offset: 0x003425E0
		public string NoQuestTips
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600E2E7 RID: 58087 RVA: 0x00344418 File Offset: 0x00342618
		public Span<byte> GetNoQuestTipsBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600E2E8 RID: 58088 RVA: 0x00344428 File Offset: 0x00342628
		public byte[] GetNoQuestTipsArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17003A2F RID: 14895
		// (get) Token: 0x0600E2E9 RID: 58089 RVA: 0x00344440 File Offset: 0x00342640
		public string TxtEndDayParam
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

		// Token: 0x0600E2EA RID: 58090 RVA: 0x00344478 File Offset: 0x00342678
		public Span<byte> GetTxtEndDayParamBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600E2EB RID: 58091 RVA: 0x00344488 File Offset: 0x00342688
		public byte[] GetTxtEndDayParamArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x04005835 RID: 22581
		private Table __p;
	}
}
