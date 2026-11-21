using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200123A RID: 4666
	public struct SurvivorsRoleEvolve : IFlatbufferObject
	{
		// Token: 0x17003C64 RID: 15460
		// (get) Token: 0x0600E88A RID: 59530 RVA: 0x00350D10 File Offset: 0x0034EF10
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600E88B RID: 59531 RVA: 0x00350D1D File Offset: 0x0034EF1D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600E88C RID: 59532 RVA: 0x00350D24 File Offset: 0x0034EF24
		public static SurvivorsRoleEvolve GetRootAsSurvivorsRoleEvolve(ByteBuffer _bb)
		{
			return SurvivorsRoleEvolve.GetRootAsSurvivorsRoleEvolve(_bb, default(SurvivorsRoleEvolve));
		}

		// Token: 0x0600E88D RID: 59533 RVA: 0x00350D40 File Offset: 0x0034EF40
		public static SurvivorsRoleEvolve GetRootAsSurvivorsRoleEvolve(ByteBuffer _bb, SurvivorsRoleEvolve obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600E88E RID: 59534 RVA: 0x00350D5D File Offset: 0x0034EF5D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600E88F RID: 59535 RVA: 0x00350D6C File Offset: 0x0034EF6C
		public SurvivorsRoleEvolve __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003C65 RID: 15461
		// (get) Token: 0x0600E890 RID: 59536 RVA: 0x00350D7C File Offset: 0x0034EF7C
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

		// Token: 0x17003C66 RID: 15462
		// (get) Token: 0x0600E891 RID: 59537 RVA: 0x00350DB8 File Offset: 0x0034EFB8
		public int RoleId
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

		// Token: 0x17003C67 RID: 15463
		// (get) Token: 0x0600E892 RID: 59538 RVA: 0x00350DF4 File Offset: 0x0034EFF4
		public int Level
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

		// Token: 0x17003C68 RID: 15464
		// (get) Token: 0x0600E893 RID: 59539 RVA: 0x00350E30 File Offset: 0x0034F030
		public int Quality
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

		// Token: 0x17003C69 RID: 15465
		// (get) Token: 0x0600E894 RID: 59540 RVA: 0x00350E70 File Offset: 0x0034F070
		public int CondLevel
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

		// Token: 0x17003C6A RID: 15466
		// (get) Token: 0x0600E895 RID: 59541 RVA: 0x00350EB0 File Offset: 0x0034F0B0
		public int CondType
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

		// Token: 0x17003C6B RID: 15467
		// (get) Token: 0x0600E896 RID: 59542 RVA: 0x00350EF0 File Offset: 0x0034F0F0
		public string EvolveName
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

		// Token: 0x0600E897 RID: 59543 RVA: 0x00350F28 File Offset: 0x0034F128
		public Span<byte> GetEvolveNameBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600E898 RID: 59544 RVA: 0x00350F38 File Offset: 0x0034F138
		public byte[] GetEvolveNameArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x17003C6C RID: 15468
		// (get) Token: 0x0600E899 RID: 59545 RVA: 0x00350F50 File Offset: 0x0034F150
		public string Describe
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

		// Token: 0x0600E89A RID: 59546 RVA: 0x00350F88 File Offset: 0x0034F188
		public Span<byte> GetDescribeBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0600E89B RID: 59547 RVA: 0x00350F98 File Offset: 0x0034F198
		public byte[] GetDescribeArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x17003C6D RID: 15469
		// (get) Token: 0x0600E89C RID: 59548 RVA: 0x00350FB0 File Offset: 0x0034F1B0
		public string Icon
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

		// Token: 0x0600E89D RID: 59549 RVA: 0x00350FE8 File Offset: 0x0034F1E8
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x0600E89E RID: 59550 RVA: 0x00350FF8 File Offset: 0x0034F1F8
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x17003C6E RID: 15470
		// (get) Token: 0x0600E89F RID: 59551 RVA: 0x00351010 File Offset: 0x0034F210
		public int SkillId
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x04005880 RID: 22656
		private Table __p;
	}
}
