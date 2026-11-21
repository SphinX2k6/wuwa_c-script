using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D45 RID: 3397
	public struct FavorRoleInfo : IFlatbufferObject
	{
		// Token: 0x170010C6 RID: 4294
		// (get) Token: 0x060072F3 RID: 29427 RVA: 0x0024AD10 File Offset: 0x00248F10
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060072F4 RID: 29428 RVA: 0x0024AD1D File Offset: 0x00248F1D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060072F5 RID: 29429 RVA: 0x0024AD24 File Offset: 0x00248F24
		public static FavorRoleInfo GetRootAsFavorRoleInfo(ByteBuffer _bb)
		{
			return FavorRoleInfo.GetRootAsFavorRoleInfo(_bb, default(FavorRoleInfo));
		}

		// Token: 0x060072F6 RID: 29430 RVA: 0x0024AD40 File Offset: 0x00248F40
		public static FavorRoleInfo GetRootAsFavorRoleInfo(ByteBuffer _bb, FavorRoleInfo obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060072F7 RID: 29431 RVA: 0x0024AD5D File Offset: 0x00248F5D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060072F8 RID: 29432 RVA: 0x0024AD6C File Offset: 0x00248F6C
		public FavorRoleInfo __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170010C7 RID: 4295
		// (get) Token: 0x060072F9 RID: 29433 RVA: 0x0024AD7C File Offset: 0x00248F7C
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

		// Token: 0x170010C8 RID: 4296
		// (get) Token: 0x060072FA RID: 29434 RVA: 0x0024ADB8 File Offset: 0x00248FB8
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

		// Token: 0x170010C9 RID: 4297
		// (get) Token: 0x060072FB RID: 29435 RVA: 0x0024ADF4 File Offset: 0x00248FF4
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

		// Token: 0x060072FC RID: 29436 RVA: 0x0024AE2B File Offset: 0x0024902B
		public Span<byte> GetBirthdayBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x060072FD RID: 29437 RVA: 0x0024AE3A File Offset: 0x0024903A
		public byte[] GetBirthdayArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x170010CA RID: 4298
		// (get) Token: 0x060072FE RID: 29438 RVA: 0x0024AE54 File Offset: 0x00249054
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

		// Token: 0x060072FF RID: 29439 RVA: 0x0024AE8C File Offset: 0x0024908C
		public Span<byte> GetSexBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06007300 RID: 29440 RVA: 0x0024AE9C File Offset: 0x0024909C
		public byte[] GetSexArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x170010CB RID: 4299
		// (get) Token: 0x06007301 RID: 29441 RVA: 0x0024AEB4 File Offset: 0x002490B4
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

		// Token: 0x06007302 RID: 29442 RVA: 0x0024AEEC File Offset: 0x002490EC
		public Span<byte> GetCountryBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06007303 RID: 29443 RVA: 0x0024AEFC File Offset: 0x002490FC
		public byte[] GetCountryArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x170010CC RID: 4300
		// (get) Token: 0x06007304 RID: 29444 RVA: 0x0024AF14 File Offset: 0x00249114
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

		// Token: 0x06007305 RID: 29445 RVA: 0x0024AF4C File Offset: 0x0024914C
		public Span<byte> GetInfluenceBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x06007306 RID: 29446 RVA: 0x0024AF5C File Offset: 0x0024915C
		public byte[] GetInfluenceArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x170010CD RID: 4301
		// (get) Token: 0x06007307 RID: 29447 RVA: 0x0024AF74 File Offset: 0x00249174
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

		// Token: 0x06007308 RID: 29448 RVA: 0x0024AFAC File Offset: 0x002491AC
		public Span<byte> GetInfoBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x06007309 RID: 29449 RVA: 0x0024AFBC File Offset: 0x002491BC
		public byte[] GetInfoArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x170010CE RID: 4302
		// (get) Token: 0x0600730A RID: 29450 RVA: 0x0024AFD4 File Offset: 0x002491D4
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

		// Token: 0x0600730B RID: 29451 RVA: 0x0024B00C File Offset: 0x0024920C
		public Span<byte> GetTalentNameBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0600730C RID: 29452 RVA: 0x0024B01C File Offset: 0x0024921C
		public byte[] GetTalentNameArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x170010CF RID: 4303
		// (get) Token: 0x0600730D RID: 29453 RVA: 0x0024B034 File Offset: 0x00249234
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

		// Token: 0x0600730E RID: 29454 RVA: 0x0024B06C File Offset: 0x0024926C
		public Span<byte> GetTalentDocBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x0600730F RID: 29455 RVA: 0x0024B07C File Offset: 0x0024927C
		public byte[] GetTalentDocArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x170010D0 RID: 4304
		// (get) Token: 0x06007310 RID: 29456 RVA: 0x0024B094 File Offset: 0x00249294
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

		// Token: 0x06007311 RID: 29457 RVA: 0x0024B0CC File Offset: 0x002492CC
		public Span<byte> GetTalentCertificationBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x06007312 RID: 29458 RVA: 0x0024B0DC File Offset: 0x002492DC
		public byte[] GetTalentCertificationArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x170010D1 RID: 4305
		// (get) Token: 0x06007313 RID: 29459 RVA: 0x0024B0F4 File Offset: 0x002492F4
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

		// Token: 0x170010D2 RID: 4306
		// (get) Token: 0x06007314 RID: 29460 RVA: 0x0024B134 File Offset: 0x00249334
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

		// Token: 0x06007315 RID: 29461 RVA: 0x0024B16C File Offset: 0x0024936C
		public Span<byte> GetCVNameCnBytes()
		{
			return this.__p.__vector_as_span<byte>(26, 1);
		}

		// Token: 0x06007316 RID: 29462 RVA: 0x0024B17C File Offset: 0x0024937C
		public byte[] GetCVNameCnArray()
		{
			return this.__p.__vector_as_array<byte>(26) ?? Array.Empty<byte>();
		}

		// Token: 0x170010D3 RID: 4307
		// (get) Token: 0x06007317 RID: 29463 RVA: 0x0024B194 File Offset: 0x00249394
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

		// Token: 0x06007318 RID: 29464 RVA: 0x0024B1CC File Offset: 0x002493CC
		public Span<byte> GetCVNameJpBytes()
		{
			return this.__p.__vector_as_span<byte>(28, 1);
		}

		// Token: 0x06007319 RID: 29465 RVA: 0x0024B1DC File Offset: 0x002493DC
		public byte[] GetCVNameJpArray()
		{
			return this.__p.__vector_as_array<byte>(28) ?? Array.Empty<byte>();
		}

		// Token: 0x170010D4 RID: 4308
		// (get) Token: 0x0600731A RID: 29466 RVA: 0x0024B1F4 File Offset: 0x002493F4
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

		// Token: 0x0600731B RID: 29467 RVA: 0x0024B22C File Offset: 0x0024942C
		public Span<byte> GetCVNameKoBytes()
		{
			return this.__p.__vector_as_span<byte>(30, 1);
		}

		// Token: 0x0600731C RID: 29468 RVA: 0x0024B23C File Offset: 0x0024943C
		public byte[] GetCVNameKoArray()
		{
			return this.__p.__vector_as_array<byte>(30) ?? Array.Empty<byte>();
		}

		// Token: 0x170010D5 RID: 4309
		// (get) Token: 0x0600731D RID: 29469 RVA: 0x0024B254 File Offset: 0x00249454
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

		// Token: 0x0600731E RID: 29470 RVA: 0x0024B28C File Offset: 0x0024948C
		public Span<byte> GetCVNameEnBytes()
		{
			return this.__p.__vector_as_span<byte>(32, 1);
		}

		// Token: 0x0600731F RID: 29471 RVA: 0x0024B29C File Offset: 0x0024949C
		public byte[] GetCVNameEnArray()
		{
			return this.__p.__vector_as_array<byte>(32) ?? Array.Empty<byte>();
		}

		// Token: 0x04005290 RID: 21136
		private Table __p;
	}
}
