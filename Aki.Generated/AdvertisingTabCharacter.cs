using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000BB3 RID: 2995
	public struct AdvertisingTabCharacter : IFlatbufferObject
	{
		// Token: 0x170001ED RID: 493
		// (get) Token: 0x06004A30 RID: 18992 RVA: 0x001EF224 File Offset: 0x001ED424
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06004A31 RID: 18993 RVA: 0x001EF231 File Offset: 0x001ED431
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06004A32 RID: 18994 RVA: 0x001EF238 File Offset: 0x001ED438
		public static AdvertisingTabCharacter GetRootAsAdvertisingTabCharacter(ByteBuffer _bb)
		{
			return AdvertisingTabCharacter.GetRootAsAdvertisingTabCharacter(_bb, default(AdvertisingTabCharacter));
		}

		// Token: 0x06004A33 RID: 18995 RVA: 0x001EF254 File Offset: 0x001ED454
		public static AdvertisingTabCharacter GetRootAsAdvertisingTabCharacter(ByteBuffer _bb, AdvertisingTabCharacter obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06004A34 RID: 18996 RVA: 0x001EF271 File Offset: 0x001ED471
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06004A35 RID: 18997 RVA: 0x001EF280 File Offset: 0x001ED480
		public AdvertisingTabCharacter __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170001EE RID: 494
		// (get) Token: 0x06004A36 RID: 18998 RVA: 0x001EF290 File Offset: 0x001ED490
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

		// Token: 0x170001EF RID: 495
		// (get) Token: 0x06004A37 RID: 18999 RVA: 0x001EF2CC File Offset: 0x001ED4CC
		public int RoleOrWeaponId
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

		// Token: 0x170001F0 RID: 496
		// (get) Token: 0x06004A38 RID: 19000 RVA: 0x001EF308 File Offset: 0x001ED508
		public int Type
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

		// Token: 0x170001F1 RID: 497
		// (get) Token: 0x06004A39 RID: 19001 RVA: 0x001EF344 File Offset: 0x001ED544
		public string ThumbnailText
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

		// Token: 0x06004A3A RID: 19002 RVA: 0x001EF37C File Offset: 0x001ED57C
		public Span<byte> GetThumbnailTextBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06004A3B RID: 19003 RVA: 0x001EF38C File Offset: 0x001ED58C
		public byte[] GetThumbnailTextArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x170001F2 RID: 498
		// (get) Token: 0x06004A3C RID: 19004 RVA: 0x001EF3A4 File Offset: 0x001ED5A4
		public string ThumbnailPic
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

		// Token: 0x06004A3D RID: 19005 RVA: 0x001EF3DC File Offset: 0x001ED5DC
		public Span<byte> GetThumbnailPicBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06004A3E RID: 19006 RVA: 0x001EF3EC File Offset: 0x001ED5EC
		public byte[] GetThumbnailPicArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x170001F3 RID: 499
		// (get) Token: 0x06004A3F RID: 19007 RVA: 0x001EF404 File Offset: 0x001ED604
		public string Title
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

		// Token: 0x06004A40 RID: 19008 RVA: 0x001EF43C File Offset: 0x001ED63C
		public Span<byte> GetTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x06004A41 RID: 19009 RVA: 0x001EF44C File Offset: 0x001ED64C
		public byte[] GetTitleArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x170001F4 RID: 500
		// (get) Token: 0x06004A42 RID: 19010 RVA: 0x001EF464 File Offset: 0x001ED664
		public string MainPic
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

		// Token: 0x06004A43 RID: 19011 RVA: 0x001EF49C File Offset: 0x001ED69C
		public Span<byte> GetMainPicBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x06004A44 RID: 19012 RVA: 0x001EF4AC File Offset: 0x001ED6AC
		public byte[] GetMainPicArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x170001F5 RID: 501
		// (get) Token: 0x06004A45 RID: 19013 RVA: 0x001EF4C4 File Offset: 0x001ED6C4
		public string MainBgPic
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

		// Token: 0x06004A46 RID: 19014 RVA: 0x001EF4FC File Offset: 0x001ED6FC
		public Span<byte> GetMainBgPicBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x06004A47 RID: 19015 RVA: 0x001EF50C File Offset: 0x001ED70C
		public byte[] GetMainBgPicArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x170001F6 RID: 502
		// (get) Token: 0x06004A48 RID: 19016 RVA: 0x001EF524 File Offset: 0x001ED724
		public string GetWayTitle
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

		// Token: 0x06004A49 RID: 19017 RVA: 0x001EF55C File Offset: 0x001ED75C
		public Span<byte> GetGetWayTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x06004A4A RID: 19018 RVA: 0x001EF56C File Offset: 0x001ED76C
		public byte[] GetGetWayTitleArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x170001F7 RID: 503
		// (get) Token: 0x06004A4B RID: 19019 RVA: 0x001EF584 File Offset: 0x001ED784
		public string GetWayDescription
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

		// Token: 0x06004A4C RID: 19020 RVA: 0x001EF5BC File Offset: 0x001ED7BC
		public Span<byte> GetGetWayDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x06004A4D RID: 19021 RVA: 0x001EF5CC File Offset: 0x001ED7CC
		public byte[] GetGetWayDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x170001F8 RID: 504
		// (get) Token: 0x06004A4E RID: 19022 RVA: 0x001EF5E4 File Offset: 0x001ED7E4
		public string NameText
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06004A4F RID: 19023 RVA: 0x001EF61C File Offset: 0x001ED81C
		public Span<byte> GetNameTextBytes()
		{
			return this.__p.__vector_as_span<byte>(24, 1);
		}

		// Token: 0x06004A50 RID: 19024 RVA: 0x001EF62C File Offset: 0x001ED82C
		public byte[] GetNameTextArray()
		{
			return this.__p.__vector_as_array<byte>(24) ?? Array.Empty<byte>();
		}

		// Token: 0x170001F9 RID: 505
		// (get) Token: 0x06004A51 RID: 19025 RVA: 0x001EF644 File Offset: 0x001ED844
		public int QualityId
		{
			get
			{
				int num = this.__p.__offset(26);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170001FA RID: 506
		// (get) Token: 0x06004A52 RID: 19026 RVA: 0x001EF684 File Offset: 0x001ED884
		public string ElementIconPath
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

		// Token: 0x06004A53 RID: 19027 RVA: 0x001EF6BC File Offset: 0x001ED8BC
		public Span<byte> GetElementIconPathBytes()
		{
			return this.__p.__vector_as_span<byte>(28, 1);
		}

		// Token: 0x06004A54 RID: 19028 RVA: 0x001EF6CC File Offset: 0x001ED8CC
		public byte[] GetElementIconPathArray()
		{
			return this.__p.__vector_as_array<byte>(28) ?? Array.Empty<byte>();
		}

		// Token: 0x170001FB RID: 507
		// (get) Token: 0x06004A55 RID: 19029 RVA: 0x001EF6E4 File Offset: 0x001ED8E4
		public string ElementBgIconPath
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

		// Token: 0x06004A56 RID: 19030 RVA: 0x001EF71C File Offset: 0x001ED91C
		public Span<byte> GetElementBgIconPathBytes()
		{
			return this.__p.__vector_as_span<byte>(30, 1);
		}

		// Token: 0x06004A57 RID: 19031 RVA: 0x001EF72C File Offset: 0x001ED92C
		public byte[] GetElementBgIconPathArray()
		{
			return this.__p.__vector_as_array<byte>(30) ?? Array.Empty<byte>();
		}

		// Token: 0x170001FC RID: 508
		// (get) Token: 0x06004A58 RID: 19032 RVA: 0x001EF744 File Offset: 0x001ED944
		public string WeaponTypeIconPath
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

		// Token: 0x06004A59 RID: 19033 RVA: 0x001EF77C File Offset: 0x001ED97C
		public Span<byte> GetWeaponTypeIconPathBytes()
		{
			return this.__p.__vector_as_span<byte>(32, 1);
		}

		// Token: 0x06004A5A RID: 19034 RVA: 0x001EF78C File Offset: 0x001ED98C
		public byte[] GetWeaponTypeIconPathArray()
		{
			return this.__p.__vector_as_array<byte>(32) ?? Array.Empty<byte>();
		}

		// Token: 0x170001FD RID: 509
		// (get) Token: 0x06004A5B RID: 19035 RVA: 0x001EF7A4 File Offset: 0x001ED9A4
		public string WeaponPrefabPath
		{
			get
			{
				int num = this.__p.__offset(34);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06004A5C RID: 19036 RVA: 0x001EF7DC File Offset: 0x001ED9DC
		public Span<byte> GetWeaponPrefabPathBytes()
		{
			return this.__p.__vector_as_span<byte>(34, 1);
		}

		// Token: 0x06004A5D RID: 19037 RVA: 0x001EF7EC File Offset: 0x001ED9EC
		public byte[] GetWeaponPrefabPathArray()
		{
			return this.__p.__vector_as_array<byte>(34) ?? Array.Empty<byte>();
		}

		// Token: 0x170001FE RID: 510
		// (get) Token: 0x06004A5E RID: 19038 RVA: 0x001EF804 File Offset: 0x001EDA04
		public string SpinePrefabResource
		{
			get
			{
				int num = this.__p.__offset(36);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06004A5F RID: 19039 RVA: 0x001EF83C File Offset: 0x001EDA3C
		public Span<byte> GetSpinePrefabResourceBytes()
		{
			return this.__p.__vector_as_span<byte>(36, 1);
		}

		// Token: 0x06004A60 RID: 19040 RVA: 0x001EF84C File Offset: 0x001EDA4C
		public byte[] GetSpinePrefabResourceArray()
		{
			return this.__p.__vector_as_array<byte>(36) ?? Array.Empty<byte>();
		}

		// Token: 0x04005092 RID: 20626
		private Table __p;
	}
}
