using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000AD9 RID: 2777
	public struct AdvertisingTabCharacter : IFlatbufferObject
	{
		// Token: 0x170001D6 RID: 470
		// (get) Token: 0x060044E9 RID: 17641 RVA: 0x001CF750 File Offset: 0x001CD950
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060044EA RID: 17642 RVA: 0x001CF75D File Offset: 0x001CD95D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060044EB RID: 17643 RVA: 0x001CF764 File Offset: 0x001CD964
		public static AdvertisingTabCharacter GetRootAsAdvertisingTabCharacter(ByteBuffer _bb)
		{
			return AdvertisingTabCharacter.GetRootAsAdvertisingTabCharacter(_bb, default(AdvertisingTabCharacter));
		}

		// Token: 0x060044EC RID: 17644 RVA: 0x001CF780 File Offset: 0x001CD980
		public static AdvertisingTabCharacter GetRootAsAdvertisingTabCharacter(ByteBuffer _bb, AdvertisingTabCharacter obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060044ED RID: 17645 RVA: 0x001CF79D File Offset: 0x001CD99D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060044EE RID: 17646 RVA: 0x001CF7AC File Offset: 0x001CD9AC
		public AdvertisingTabCharacter __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170001D7 RID: 471
		// (get) Token: 0x060044EF RID: 17647 RVA: 0x001CF7BC File Offset: 0x001CD9BC
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

		// Token: 0x170001D8 RID: 472
		// (get) Token: 0x060044F0 RID: 17648 RVA: 0x001CF7F8 File Offset: 0x001CD9F8
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

		// Token: 0x170001D9 RID: 473
		// (get) Token: 0x060044F1 RID: 17649 RVA: 0x001CF834 File Offset: 0x001CDA34
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

		// Token: 0x170001DA RID: 474
		// (get) Token: 0x060044F2 RID: 17650 RVA: 0x001CF870 File Offset: 0x001CDA70
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

		// Token: 0x060044F3 RID: 17651 RVA: 0x001CF8A8 File Offset: 0x001CDAA8
		public Span<byte> GetThumbnailTextBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x060044F4 RID: 17652 RVA: 0x001CF8B8 File Offset: 0x001CDAB8
		public byte[] GetThumbnailTextArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x170001DB RID: 475
		// (get) Token: 0x060044F5 RID: 17653 RVA: 0x001CF8D0 File Offset: 0x001CDAD0
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

		// Token: 0x060044F6 RID: 17654 RVA: 0x001CF908 File Offset: 0x001CDB08
		public Span<byte> GetThumbnailPicBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x060044F7 RID: 17655 RVA: 0x001CF918 File Offset: 0x001CDB18
		public byte[] GetThumbnailPicArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x170001DC RID: 476
		// (get) Token: 0x060044F8 RID: 17656 RVA: 0x001CF930 File Offset: 0x001CDB30
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

		// Token: 0x060044F9 RID: 17657 RVA: 0x001CF968 File Offset: 0x001CDB68
		public Span<byte> GetTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x060044FA RID: 17658 RVA: 0x001CF978 File Offset: 0x001CDB78
		public byte[] GetTitleArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x170001DD RID: 477
		// (get) Token: 0x060044FB RID: 17659 RVA: 0x001CF990 File Offset: 0x001CDB90
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

		// Token: 0x060044FC RID: 17660 RVA: 0x001CF9C8 File Offset: 0x001CDBC8
		public Span<byte> GetMainPicBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x060044FD RID: 17661 RVA: 0x001CF9D8 File Offset: 0x001CDBD8
		public byte[] GetMainPicArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x170001DE RID: 478
		// (get) Token: 0x060044FE RID: 17662 RVA: 0x001CF9F0 File Offset: 0x001CDBF0
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

		// Token: 0x060044FF RID: 17663 RVA: 0x001CFA28 File Offset: 0x001CDC28
		public Span<byte> GetMainBgPicBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x06004500 RID: 17664 RVA: 0x001CFA38 File Offset: 0x001CDC38
		public byte[] GetMainBgPicArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x170001DF RID: 479
		// (get) Token: 0x06004501 RID: 17665 RVA: 0x001CFA50 File Offset: 0x001CDC50
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

		// Token: 0x06004502 RID: 17666 RVA: 0x001CFA88 File Offset: 0x001CDC88
		public Span<byte> GetGetWayTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x06004503 RID: 17667 RVA: 0x001CFA98 File Offset: 0x001CDC98
		public byte[] GetGetWayTitleArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x170001E0 RID: 480
		// (get) Token: 0x06004504 RID: 17668 RVA: 0x001CFAB0 File Offset: 0x001CDCB0
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

		// Token: 0x06004505 RID: 17669 RVA: 0x001CFAE8 File Offset: 0x001CDCE8
		public Span<byte> GetGetWayDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x06004506 RID: 17670 RVA: 0x001CFAF8 File Offset: 0x001CDCF8
		public byte[] GetGetWayDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x170001E1 RID: 481
		// (get) Token: 0x06004507 RID: 17671 RVA: 0x001CFB10 File Offset: 0x001CDD10
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

		// Token: 0x06004508 RID: 17672 RVA: 0x001CFB48 File Offset: 0x001CDD48
		public Span<byte> GetNameTextBytes()
		{
			return this.__p.__vector_as_span<byte>(24, 1);
		}

		// Token: 0x06004509 RID: 17673 RVA: 0x001CFB58 File Offset: 0x001CDD58
		public byte[] GetNameTextArray()
		{
			return this.__p.__vector_as_array<byte>(24) ?? Array.Empty<byte>();
		}

		// Token: 0x170001E2 RID: 482
		// (get) Token: 0x0600450A RID: 17674 RVA: 0x001CFB70 File Offset: 0x001CDD70
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

		// Token: 0x170001E3 RID: 483
		// (get) Token: 0x0600450B RID: 17675 RVA: 0x001CFBB0 File Offset: 0x001CDDB0
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

		// Token: 0x0600450C RID: 17676 RVA: 0x001CFBE8 File Offset: 0x001CDDE8
		public Span<byte> GetElementIconPathBytes()
		{
			return this.__p.__vector_as_span<byte>(28, 1);
		}

		// Token: 0x0600450D RID: 17677 RVA: 0x001CFBF8 File Offset: 0x001CDDF8
		public byte[] GetElementIconPathArray()
		{
			return this.__p.__vector_as_array<byte>(28) ?? Array.Empty<byte>();
		}

		// Token: 0x170001E4 RID: 484
		// (get) Token: 0x0600450E RID: 17678 RVA: 0x001CFC10 File Offset: 0x001CDE10
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

		// Token: 0x0600450F RID: 17679 RVA: 0x001CFC48 File Offset: 0x001CDE48
		public Span<byte> GetElementBgIconPathBytes()
		{
			return this.__p.__vector_as_span<byte>(30, 1);
		}

		// Token: 0x06004510 RID: 17680 RVA: 0x001CFC58 File Offset: 0x001CDE58
		public byte[] GetElementBgIconPathArray()
		{
			return this.__p.__vector_as_array<byte>(30) ?? Array.Empty<byte>();
		}

		// Token: 0x170001E5 RID: 485
		// (get) Token: 0x06004511 RID: 17681 RVA: 0x001CFC70 File Offset: 0x001CDE70
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

		// Token: 0x06004512 RID: 17682 RVA: 0x001CFCA8 File Offset: 0x001CDEA8
		public Span<byte> GetWeaponTypeIconPathBytes()
		{
			return this.__p.__vector_as_span<byte>(32, 1);
		}

		// Token: 0x06004513 RID: 17683 RVA: 0x001CFCB8 File Offset: 0x001CDEB8
		public byte[] GetWeaponTypeIconPathArray()
		{
			return this.__p.__vector_as_array<byte>(32) ?? Array.Empty<byte>();
		}

		// Token: 0x170001E6 RID: 486
		// (get) Token: 0x06004514 RID: 17684 RVA: 0x001CFCD0 File Offset: 0x001CDED0
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

		// Token: 0x06004515 RID: 17685 RVA: 0x001CFD08 File Offset: 0x001CDF08
		public Span<byte> GetWeaponPrefabPathBytes()
		{
			return this.__p.__vector_as_span<byte>(34, 1);
		}

		// Token: 0x06004516 RID: 17686 RVA: 0x001CFD18 File Offset: 0x001CDF18
		public byte[] GetWeaponPrefabPathArray()
		{
			return this.__p.__vector_as_array<byte>(34) ?? Array.Empty<byte>();
		}

		// Token: 0x170001E7 RID: 487
		// (get) Token: 0x06004517 RID: 17687 RVA: 0x001CFD30 File Offset: 0x001CDF30
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

		// Token: 0x06004518 RID: 17688 RVA: 0x001CFD68 File Offset: 0x001CDF68
		public Span<byte> GetSpinePrefabResourceBytes()
		{
			return this.__p.__vector_as_span<byte>(36, 1);
		}

		// Token: 0x06004519 RID: 17689 RVA: 0x001CFD78 File Offset: 0x001CDF78
		public byte[] GetSpinePrefabResourceArray()
		{
			return this.__p.__vector_as_array<byte>(36) ?? Array.Empty<byte>();
		}

		// Token: 0x04004AB8 RID: 19128
		private Table __p;
	}
}
