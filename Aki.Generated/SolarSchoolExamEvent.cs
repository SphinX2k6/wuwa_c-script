using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020011E4 RID: 4580
	public struct SolarSchoolExamEvent : IFlatbufferObject
	{
		// Token: 0x1700396C RID: 14700
		// (get) Token: 0x0600E115 RID: 57621 RVA: 0x0034030C File Offset: 0x0033E50C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600E116 RID: 57622 RVA: 0x00340319 File Offset: 0x0033E519
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600E117 RID: 57623 RVA: 0x00340320 File Offset: 0x0033E520
		public static SolarSchoolExamEvent GetRootAsSolarSchoolExamEvent(ByteBuffer _bb)
		{
			return SolarSchoolExamEvent.GetRootAsSolarSchoolExamEvent(_bb, default(SolarSchoolExamEvent));
		}

		// Token: 0x0600E118 RID: 57624 RVA: 0x0034033C File Offset: 0x0033E53C
		public static SolarSchoolExamEvent GetRootAsSolarSchoolExamEvent(ByteBuffer _bb, SolarSchoolExamEvent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600E119 RID: 57625 RVA: 0x00340359 File Offset: 0x0033E559
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600E11A RID: 57626 RVA: 0x00340368 File Offset: 0x0033E568
		public SolarSchoolExamEvent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700396D RID: 14701
		// (get) Token: 0x0600E11B RID: 57627 RVA: 0x00340378 File Offset: 0x0033E578
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

		// Token: 0x1700396E RID: 14702
		// (get) Token: 0x0600E11C RID: 57628 RVA: 0x003403B4 File Offset: 0x0033E5B4
		public int ChoiceGroupId
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

		// Token: 0x1700396F RID: 14703
		// (get) Token: 0x0600E11D RID: 57629 RVA: 0x003403F0 File Offset: 0x0033E5F0
		public string Title
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600E11E RID: 57630 RVA: 0x00340427 File Offset: 0x0033E627
		public Span<byte> GetTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600E11F RID: 57631 RVA: 0x00340436 File Offset: 0x0033E636
		public byte[] GetTitleArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17003970 RID: 14704
		// (get) Token: 0x0600E120 RID: 57632 RVA: 0x00340450 File Offset: 0x0033E650
		public string Desc
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600E121 RID: 57633 RVA: 0x00340488 File Offset: 0x0033E688
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600E122 RID: 57634 RVA: 0x00340498 File Offset: 0x0033E698
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17003971 RID: 14705
		// (get) Token: 0x0600E123 RID: 57635 RVA: 0x003404B0 File Offset: 0x0033E6B0
		public string Image
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

		// Token: 0x0600E124 RID: 57636 RVA: 0x003404E8 File Offset: 0x0033E6E8
		public Span<byte> GetImageBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600E125 RID: 57637 RVA: 0x003404F8 File Offset: 0x0033E6F8
		public byte[] GetImageArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17003972 RID: 14706
		// (get) Token: 0x0600E126 RID: 57638 RVA: 0x00340510 File Offset: 0x0033E710
		public int AddScore
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x04005821 RID: 22561
		private Table __p;
	}
}
