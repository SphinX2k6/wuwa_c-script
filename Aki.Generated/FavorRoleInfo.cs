using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C61 RID: 3169
	public struct FavorRoleInfo : IFlatbufferObject
	{
		// Token: 0x17001069 RID: 4201
		// (get) Token: 0x06006CE8 RID: 27880 RVA: 0x0022B9C0 File Offset: 0x00229BC0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06006CE9 RID: 27881 RVA: 0x0022B9CD File Offset: 0x00229BCD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06006CEA RID: 27882 RVA: 0x0022B9D4 File Offset: 0x00229BD4
		public static FavorRoleInfo GetRootAsFavorRoleInfo(ByteBuffer _bb)
		{
			return FavorRoleInfo.GetRootAsFavorRoleInfo(_bb, default(FavorRoleInfo));
		}

		// Token: 0x06006CEB RID: 27883 RVA: 0x0022B9F0 File Offset: 0x00229BF0
		public static FavorRoleInfo GetRootAsFavorRoleInfo(ByteBuffer _bb, FavorRoleInfo obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06006CEC RID: 27884 RVA: 0x0022BA0D File Offset: 0x00229C0D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06006CED RID: 27885 RVA: 0x0022BA1C File Offset: 0x00229C1C
		public FavorRoleInfo __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700106A RID: 4202
		// (get) Token: 0x06006CEE RID: 27886 RVA: 0x0022BA2C File Offset: 0x00229C2C
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

		// Token: 0x1700106B RID: 4203
		// (get) Token: 0x06006CEF RID: 27887 RVA: 0x0022BA68 File Offset: 0x00229C68
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

		// Token: 0x1700106C RID: 4204
		// (get) Token: 0x06006CF0 RID: 27888 RVA: 0x0022BAA4 File Offset: 0x00229CA4
		public string Birthday
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

		// Token: 0x06006CF1 RID: 27889 RVA: 0x0022BADB File Offset: 0x00229CDB
		public Span<byte> GetBirthdayBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06006CF2 RID: 27890 RVA: 0x0022BAEA File Offset: 0x00229CEA
		public byte[] GetBirthdayArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x1700106D RID: 4205
		// (get) Token: 0x06006CF3 RID: 27891 RVA: 0x0022BB04 File Offset: 0x00229D04
		public string Sex
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

		// Token: 0x06006CF4 RID: 27892 RVA: 0x0022BB3C File Offset: 0x00229D3C
		public Span<byte> GetSexBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06006CF5 RID: 27893 RVA: 0x0022BB4C File Offset: 0x00229D4C
		public byte[] GetSexArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x1700106E RID: 4206
		// (get) Token: 0x06006CF6 RID: 27894 RVA: 0x0022BB64 File Offset: 0x00229D64
		public string Country
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

		// Token: 0x06006CF7 RID: 27895 RVA: 0x0022BB9C File Offset: 0x00229D9C
		public Span<byte> GetCountryBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06006CF8 RID: 27896 RVA: 0x0022BBAC File Offset: 0x00229DAC
		public byte[] GetCountryArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x1700106F RID: 4207
		// (get) Token: 0x06006CF9 RID: 27897 RVA: 0x0022BBC4 File Offset: 0x00229DC4
		public string Influence
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

		// Token: 0x06006CFA RID: 27898 RVA: 0x0022BBFC File Offset: 0x00229DFC
		public Span<byte> GetInfluenceBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x06006CFB RID: 27899 RVA: 0x0022BC0C File Offset: 0x00229E0C
		public byte[] GetInfluenceArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17001070 RID: 4208
		// (get) Token: 0x06006CFC RID: 27900 RVA: 0x0022BC24 File Offset: 0x00229E24
		public string Info
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

		// Token: 0x06006CFD RID: 27901 RVA: 0x0022BC5C File Offset: 0x00229E5C
		public Span<byte> GetInfoBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x06006CFE RID: 27902 RVA: 0x0022BC6C File Offset: 0x00229E6C
		public byte[] GetInfoArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x17001071 RID: 4209
		// (get) Token: 0x06006CFF RID: 27903 RVA: 0x0022BC84 File Offset: 0x00229E84
		public string TalentName
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

		// Token: 0x06006D00 RID: 27904 RVA: 0x0022BCBC File Offset: 0x00229EBC
		public Span<byte> GetTalentNameBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x06006D01 RID: 27905 RVA: 0x0022BCCC File Offset: 0x00229ECC
		public byte[] GetTalentNameArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x17001072 RID: 4210
		// (get) Token: 0x06006D02 RID: 27906 RVA: 0x0022BCE4 File Offset: 0x00229EE4
		public string TalentDoc
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

		// Token: 0x06006D03 RID: 27907 RVA: 0x0022BD1C File Offset: 0x00229F1C
		public Span<byte> GetTalentDocBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x06006D04 RID: 27908 RVA: 0x0022BD2C File Offset: 0x00229F2C
		public byte[] GetTalentDocArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x17001073 RID: 4211
		// (get) Token: 0x06006D05 RID: 27909 RVA: 0x0022BD44 File Offset: 0x00229F44
		public string TalentCertification
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06006D06 RID: 27910 RVA: 0x0022BD7C File Offset: 0x00229F7C
		public Span<byte> GetTalentCertificationBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x06006D07 RID: 27911 RVA: 0x0022BD8C File Offset: 0x00229F8C
		public byte[] GetTalentCertificationArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x17001074 RID: 4212
		// (get) Token: 0x06006D08 RID: 27912 RVA: 0x0022BDA4 File Offset: 0x00229FA4
		public int CondGroupId
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

		// Token: 0x17001075 RID: 4213
		// (get) Token: 0x06006D09 RID: 27913 RVA: 0x0022BDE4 File Offset: 0x00229FE4
		public string CVNameCn
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

		// Token: 0x06006D0A RID: 27914 RVA: 0x0022BE1C File Offset: 0x0022A01C
		public Span<byte> GetCVNameCnBytes()
		{
			return this.__p.__vector_as_span<byte>(26, 1);
		}

		// Token: 0x06006D0B RID: 27915 RVA: 0x0022BE2C File Offset: 0x0022A02C
		public byte[] GetCVNameCnArray()
		{
			return this.__p.__vector_as_array<byte>(26) ?? Array.Empty<byte>();
		}

		// Token: 0x17001076 RID: 4214
		// (get) Token: 0x06006D0C RID: 27916 RVA: 0x0022BE44 File Offset: 0x0022A044
		public string CVNameJp
		{
			get
			{
				int num = this.__p.__offset(28);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06006D0D RID: 27917 RVA: 0x0022BE7C File Offset: 0x0022A07C
		public Span<byte> GetCVNameJpBytes()
		{
			return this.__p.__vector_as_span<byte>(28, 1);
		}

		// Token: 0x06006D0E RID: 27918 RVA: 0x0022BE8C File Offset: 0x0022A08C
		public byte[] GetCVNameJpArray()
		{
			return this.__p.__vector_as_array<byte>(28) ?? Array.Empty<byte>();
		}

		// Token: 0x17001077 RID: 4215
		// (get) Token: 0x06006D0F RID: 27919 RVA: 0x0022BEA4 File Offset: 0x0022A0A4
		public string CVNameKo
		{
			get
			{
				int num = this.__p.__offset(30);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06006D10 RID: 27920 RVA: 0x0022BEDC File Offset: 0x0022A0DC
		public Span<byte> GetCVNameKoBytes()
		{
			return this.__p.__vector_as_span<byte>(30, 1);
		}

		// Token: 0x06006D11 RID: 27921 RVA: 0x0022BEEC File Offset: 0x0022A0EC
		public byte[] GetCVNameKoArray()
		{
			return this.__p.__vector_as_array<byte>(30) ?? Array.Empty<byte>();
		}

		// Token: 0x17001078 RID: 4216
		// (get) Token: 0x06006D12 RID: 27922 RVA: 0x0022BF04 File Offset: 0x0022A104
		public string CVNameEn
		{
			get
			{
				int num = this.__p.__offset(32);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06006D13 RID: 27923 RVA: 0x0022BF3C File Offset: 0x0022A13C
		public Span<byte> GetCVNameEnBytes()
		{
			return this.__p.__vector_as_span<byte>(32, 1);
		}

		// Token: 0x06006D14 RID: 27924 RVA: 0x0022BF4C File Offset: 0x0022A14C
		public byte[] GetCVNameEnArray()
		{
			return this.__p.__vector_as_array<byte>(32) ?? Array.Empty<byte>();
		}

		// Token: 0x04004CAC RID: 19628
		private Table __p;
	}
}
