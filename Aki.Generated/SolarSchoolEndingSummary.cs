using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020011DE RID: 4574
	public struct SolarSchoolEndingSummary : IFlatbufferObject
	{
		// Token: 0x1700393E RID: 14654
		// (get) Token: 0x0600E09B RID: 57499 RVA: 0x0033F310 File Offset: 0x0033D510
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600E09C RID: 57500 RVA: 0x0033F31D File Offset: 0x0033D51D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600E09D RID: 57501 RVA: 0x0033F324 File Offset: 0x0033D524
		public static SolarSchoolEndingSummary GetRootAsSolarSchoolEndingSummary(ByteBuffer _bb)
		{
			return SolarSchoolEndingSummary.GetRootAsSolarSchoolEndingSummary(_bb, default(SolarSchoolEndingSummary));
		}

		// Token: 0x0600E09E RID: 57502 RVA: 0x0033F340 File Offset: 0x0033D540
		public static SolarSchoolEndingSummary GetRootAsSolarSchoolEndingSummary(ByteBuffer _bb, SolarSchoolEndingSummary obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600E09F RID: 57503 RVA: 0x0033F35D File Offset: 0x0033D55D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600E0A0 RID: 57504 RVA: 0x0033F36C File Offset: 0x0033D56C
		public SolarSchoolEndingSummary __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700393F RID: 14655
		// (get) Token: 0x0600E0A1 RID: 57505 RVA: 0x0033F37C File Offset: 0x0033D57C
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

		// Token: 0x17003940 RID: 14656
		// (get) Token: 0x0600E0A2 RID: 57506 RVA: 0x0033F3B8 File Offset: 0x0033D5B8
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

		// Token: 0x17003941 RID: 14657
		// (get) Token: 0x0600E0A3 RID: 57507 RVA: 0x0033F3F4 File Offset: 0x0033D5F4
		public int ScrollDurationMs
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 60000;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17003942 RID: 14658
		// (get) Token: 0x0600E0A4 RID: 57508 RVA: 0x0033F434 File Offset: 0x0033D634
		public int EndStayDurationMs
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 3000;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17003943 RID: 14659
		// (get) Token: 0x0600E0A5 RID: 57509 RVA: 0x0033F478 File Offset: 0x0033D678
		public string AudioResource
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

		// Token: 0x0600E0A6 RID: 57510 RVA: 0x0033F4B0 File Offset: 0x0033D6B0
		public Span<byte> GetAudioResourceBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600E0A7 RID: 57511 RVA: 0x0033F4C0 File Offset: 0x0033D6C0
		public byte[] GetAudioResourceArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17003944 RID: 14660
		// (get) Token: 0x0600E0A8 RID: 57512 RVA: 0x0033F4D8 File Offset: 0x0033D6D8
		public string Comments
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

		// Token: 0x0600E0A9 RID: 57513 RVA: 0x0033F510 File Offset: 0x0033D710
		public Span<byte> GetCommentsBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600E0AA RID: 57514 RVA: 0x0033F520 File Offset: 0x0033D720
		public byte[] GetCommentsArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x0400581B RID: 22555
		private Table __p;
	}
}
