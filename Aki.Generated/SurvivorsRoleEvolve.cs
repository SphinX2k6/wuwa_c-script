using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001104 RID: 4356
	public struct SurvivorsRoleEvolve : IFlatbufferObject
	{
		// Token: 0x1700390E RID: 14606
		// (get) Token: 0x0600DB3F RID: 56127 RVA: 0x00325A14 File Offset: 0x00323C14
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600DB40 RID: 56128 RVA: 0x00325A21 File Offset: 0x00323C21
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600DB41 RID: 56129 RVA: 0x00325A28 File Offset: 0x00323C28
		public static SurvivorsRoleEvolve GetRootAsSurvivorsRoleEvolve(ByteBuffer _bb)
		{
			return SurvivorsRoleEvolve.GetRootAsSurvivorsRoleEvolve(_bb, default(SurvivorsRoleEvolve));
		}

		// Token: 0x0600DB42 RID: 56130 RVA: 0x00325A44 File Offset: 0x00323C44
		public static SurvivorsRoleEvolve GetRootAsSurvivorsRoleEvolve(ByteBuffer _bb, SurvivorsRoleEvolve obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600DB43 RID: 56131 RVA: 0x00325A61 File Offset: 0x00323C61
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600DB44 RID: 56132 RVA: 0x00325A70 File Offset: 0x00323C70
		public SurvivorsRoleEvolve __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700390F RID: 14607
		// (get) Token: 0x0600DB45 RID: 56133 RVA: 0x00325A80 File Offset: 0x00323C80
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

		// Token: 0x17003910 RID: 14608
		// (get) Token: 0x0600DB46 RID: 56134 RVA: 0x00325ABC File Offset: 0x00323CBC
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

		// Token: 0x17003911 RID: 14609
		// (get) Token: 0x0600DB47 RID: 56135 RVA: 0x00325AF8 File Offset: 0x00323CF8
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

		// Token: 0x17003912 RID: 14610
		// (get) Token: 0x0600DB48 RID: 56136 RVA: 0x00325B34 File Offset: 0x00323D34
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

		// Token: 0x17003913 RID: 14611
		// (get) Token: 0x0600DB49 RID: 56137 RVA: 0x00325B74 File Offset: 0x00323D74
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

		// Token: 0x17003914 RID: 14612
		// (get) Token: 0x0600DB4A RID: 56138 RVA: 0x00325BB4 File Offset: 0x00323DB4
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

		// Token: 0x17003915 RID: 14613
		// (get) Token: 0x0600DB4B RID: 56139 RVA: 0x00325BF4 File Offset: 0x00323DF4
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

		// Token: 0x0600DB4C RID: 56140 RVA: 0x00325C2C File Offset: 0x00323E2C
		public Span<byte> GetEvolveNameBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600DB4D RID: 56141 RVA: 0x00325C3C File Offset: 0x00323E3C
		public byte[] GetEvolveNameArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x17003916 RID: 14614
		// (get) Token: 0x0600DB4E RID: 56142 RVA: 0x00325C54 File Offset: 0x00323E54
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

		// Token: 0x0600DB4F RID: 56143 RVA: 0x00325C8C File Offset: 0x00323E8C
		public Span<byte> GetDescribeBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0600DB50 RID: 56144 RVA: 0x00325C9C File Offset: 0x00323E9C
		public byte[] GetDescribeArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x17003917 RID: 14615
		// (get) Token: 0x0600DB51 RID: 56145 RVA: 0x00325CB4 File Offset: 0x00323EB4
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

		// Token: 0x0600DB52 RID: 56146 RVA: 0x00325CEC File Offset: 0x00323EEC
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x0600DB53 RID: 56147 RVA: 0x00325CFC File Offset: 0x00323EFC
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x17003918 RID: 14616
		// (get) Token: 0x0600DB54 RID: 56148 RVA: 0x00325D14 File Offset: 0x00323F14
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

		// Token: 0x0400523D RID: 21053
		private Table __p;
	}
}
