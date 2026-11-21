using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020011DC RID: 4572
	public struct SolarSchoolEnding : IFlatbufferObject
	{
		// Token: 0x17003926 RID: 14630
		// (get) Token: 0x0600E06D RID: 57453 RVA: 0x0033EC0C File Offset: 0x0033CE0C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600E06E RID: 57454 RVA: 0x0033EC19 File Offset: 0x0033CE19
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600E06F RID: 57455 RVA: 0x0033EC20 File Offset: 0x0033CE20
		public static SolarSchoolEnding GetRootAsSolarSchoolEnding(ByteBuffer _bb)
		{
			return SolarSchoolEnding.GetRootAsSolarSchoolEnding(_bb, default(SolarSchoolEnding));
		}

		// Token: 0x0600E070 RID: 57456 RVA: 0x0033EC3C File Offset: 0x0033CE3C
		public static SolarSchoolEnding GetRootAsSolarSchoolEnding(ByteBuffer _bb, SolarSchoolEnding obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600E071 RID: 57457 RVA: 0x0033EC59 File Offset: 0x0033CE59
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600E072 RID: 57458 RVA: 0x0033EC68 File Offset: 0x0033CE68
		public SolarSchoolEnding __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003927 RID: 14631
		// (get) Token: 0x0600E073 RID: 57459 RVA: 0x0033EC78 File Offset: 0x0033CE78
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

		// Token: 0x17003928 RID: 14632
		// (get) Token: 0x0600E074 RID: 57460 RVA: 0x0033ECB4 File Offset: 0x0033CEB4
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

		// Token: 0x17003929 RID: 14633
		// (get) Token: 0x0600E075 RID: 57461 RVA: 0x0033ECF0 File Offset: 0x0033CEF0
		public int ConditionId
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

		// Token: 0x1700392A RID: 14634
		// (get) Token: 0x0600E076 RID: 57462 RVA: 0x0033ED2C File Offset: 0x0033CF2C
		public int FlowId
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

		// Token: 0x1700392B RID: 14635
		// (get) Token: 0x0600E077 RID: 57463 RVA: 0x0033ED6C File Offset: 0x0033CF6C
		public int EndingType
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700392C RID: 14636
		// (get) Token: 0x0600E078 RID: 57464 RVA: 0x0033EDAC File Offset: 0x0033CFAC
		public string IconMale
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

		// Token: 0x0600E079 RID: 57465 RVA: 0x0033EDE4 File Offset: 0x0033CFE4
		public Span<byte> GetIconMaleBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600E07A RID: 57466 RVA: 0x0033EDF4 File Offset: 0x0033CFF4
		public byte[] GetIconMaleArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x1700392D RID: 14637
		// (get) Token: 0x0600E07B RID: 57467 RVA: 0x0033EE0C File Offset: 0x0033D00C
		public string IconFemale
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600E07C RID: 57468 RVA: 0x0033EE44 File Offset: 0x0033D044
		public Span<byte> GetIconFemaleBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600E07D RID: 57469 RVA: 0x0033EE54 File Offset: 0x0033D054
		public byte[] GetIconFemaleArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x1700392E RID: 14638
		// (get) Token: 0x0600E07E RID: 57470 RVA: 0x0033EE6C File Offset: 0x0033D06C
		public string IconQuality
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600E07F RID: 57471 RVA: 0x0033EEA4 File Offset: 0x0033D0A4
		public Span<byte> GetIconQualityBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0600E080 RID: 57472 RVA: 0x0033EEB4 File Offset: 0x0033D0B4
		public byte[] GetIconQualityArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x1700392F RID: 14639
		// (get) Token: 0x0600E081 RID: 57473 RVA: 0x0033EECC File Offset: 0x0033D0CC
		public string Desc
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600E082 RID: 57474 RVA: 0x0033EF04 File Offset: 0x0033D104
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x0600E083 RID: 57475 RVA: 0x0033EF14 File Offset: 0x0033D114
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x17003930 RID: 14640
		// (get) Token: 0x0600E084 RID: 57476 RVA: 0x0033EF2C File Offset: 0x0033D12C
		public int Star
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return 1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17003931 RID: 14641
		// (get) Token: 0x0600E085 RID: 57477 RVA: 0x0033EF6C File Offset: 0x0033D16C
		public int Sort
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17003932 RID: 14642
		// (get) Token: 0x0600E086 RID: 57478 RVA: 0x0033EFAC File Offset: 0x0033D1AC
		public string Comments
		{
			get
			{
				int num = this.__p.__offset(26);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600E087 RID: 57479 RVA: 0x0033EFE4 File Offset: 0x0033D1E4
		public Span<byte> GetCommentsBytes()
		{
			return this.__p.__vector_as_span<byte>(26, 1);
		}

		// Token: 0x0600E088 RID: 57480 RVA: 0x0033EFF4 File Offset: 0x0033D1F4
		public byte[] GetCommentsArray()
		{
			return this.__p.__vector_as_array<byte>(26) ?? Array.Empty<byte>();
		}

		// Token: 0x04005819 RID: 22553
		private Table __p;
	}
}
