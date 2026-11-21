using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F8B RID: 3979
	public struct Ornament : IFlatbufferObject
	{
		// Token: 0x170024A3 RID: 9379
		// (get) Token: 0x0600A7E1 RID: 42977 RVA: 0x002C0DA7 File Offset: 0x002BEFA7
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600A7E2 RID: 42978 RVA: 0x002C0DB4 File Offset: 0x002BEFB4
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600A7E3 RID: 42979 RVA: 0x002C0DBC File Offset: 0x002BEFBC
		public static Ornament GetRootAsOrnament(ByteBuffer _bb)
		{
			return Ornament.GetRootAsOrnament(_bb, default(Ornament));
		}

		// Token: 0x0600A7E4 RID: 42980 RVA: 0x002C0DD8 File Offset: 0x002BEFD8
		public static Ornament GetRootAsOrnament(ByteBuffer _bb, Ornament obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600A7E5 RID: 42981 RVA: 0x002C0DF5 File Offset: 0x002BEFF5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600A7E6 RID: 42982 RVA: 0x002C0E04 File Offset: 0x002BF004
		public Ornament __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170024A4 RID: 9380
		// (get) Token: 0x0600A7E7 RID: 42983 RVA: 0x002C0E14 File Offset: 0x002BF014
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

		// Token: 0x170024A5 RID: 9381
		// (get) Token: 0x0600A7E8 RID: 42984 RVA: 0x002C0E50 File Offset: 0x002BF050
		public int QualityId
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600A7E9 RID: 42985 RVA: 0x002C0E8C File Offset: 0x002BF08C
		public int RoleSkinIds(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170024A6 RID: 9382
		// (get) Token: 0x0600A7EA RID: 42986 RVA: 0x002C0ECC File Offset: 0x002BF0CC
		public int RoleSkinIdsLength
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600A7EB RID: 42987 RVA: 0x002C0EF7 File Offset: 0x002BF0F7
		public Span<int> GetRoleSkinIdsBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x0600A7EC RID: 42988 RVA: 0x002C0F06 File Offset: 0x002BF106
		public int[] GetRoleSkinIdsArray()
		{
			return this.__p.__vector_as_array<int>(8) ?? Array.Empty<int>();
		}

		// Token: 0x170024A7 RID: 9383
		// (get) Token: 0x0600A7ED RID: 42989 RVA: 0x002C0F20 File Offset: 0x002BF120
		public bool DefaultOrnament
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170024A8 RID: 9384
		// (get) Token: 0x0600A7EE RID: 42990 RVA: 0x002C0F60 File Offset: 0x002BF160
		public int OrGroupId
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

		// Token: 0x170024A9 RID: 9385
		// (get) Token: 0x0600A7EF RID: 42991 RVA: 0x002C0FA0 File Offset: 0x002BF1A0
		public string Name
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

		// Token: 0x0600A7F0 RID: 42992 RVA: 0x002C0FD8 File Offset: 0x002BF1D8
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600A7F1 RID: 42993 RVA: 0x002C0FE8 File Offset: 0x002BF1E8
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x170024AA RID: 9386
		// (get) Token: 0x0600A7F2 RID: 42994 RVA: 0x002C1000 File Offset: 0x002BF200
		public string BgDescription
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

		// Token: 0x0600A7F3 RID: 42995 RVA: 0x002C1038 File Offset: 0x002BF238
		public Span<byte> GetBgDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600A7F4 RID: 42996 RVA: 0x002C1048 File Offset: 0x002BF248
		public byte[] GetBgDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x170024AB RID: 9387
		// (get) Token: 0x0600A7F5 RID: 42997 RVA: 0x002C1060 File Offset: 0x002BF260
		public string ObtainedShowDescription
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

		// Token: 0x0600A7F6 RID: 42998 RVA: 0x002C1098 File Offset: 0x002BF298
		public Span<byte> GetObtainedShowDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0600A7F7 RID: 42999 RVA: 0x002C10A8 File Offset: 0x002BF2A8
		public byte[] GetObtainedShowDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x170024AC RID: 9388
		// (get) Token: 0x0600A7F8 RID: 43000 RVA: 0x002C10C0 File Offset: 0x002BF2C0
		public string AttributesDescription
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

		// Token: 0x0600A7F9 RID: 43001 RVA: 0x002C10F8 File Offset: 0x002BF2F8
		public Span<byte> GetAttributesDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x0600A7FA RID: 43002 RVA: 0x002C1108 File Offset: 0x002BF308
		public byte[] GetAttributesDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x170024AD RID: 9389
		// (get) Token: 0x0600A7FB RID: 43003 RVA: 0x002C1120 File Offset: 0x002BF320
		public string ShopPreviewSubTitle
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

		// Token: 0x0600A7FC RID: 43004 RVA: 0x002C1158 File Offset: 0x002BF358
		public Span<byte> GetShopPreviewSubTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x0600A7FD RID: 43005 RVA: 0x002C1168 File Offset: 0x002BF368
		public byte[] GetShopPreviewSubTitleArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x170024AE RID: 9390
		// (get) Token: 0x0600A7FE RID: 43006 RVA: 0x002C1180 File Offset: 0x002BF380
		public string TypeDescription
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

		// Token: 0x0600A7FF RID: 43007 RVA: 0x002C11B8 File Offset: 0x002BF3B8
		public Span<byte> GetTypeDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(24, 1);
		}

		// Token: 0x0600A800 RID: 43008 RVA: 0x002C11C8 File Offset: 0x002BF3C8
		public byte[] GetTypeDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(24) ?? Array.Empty<byte>();
		}

		// Token: 0x0600A801 RID: 43009 RVA: 0x002C11E0 File Offset: 0x002BF3E0
		public int ItemAccess(int j)
		{
			int num = this.__p.__offset(26);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170024AF RID: 9391
		// (get) Token: 0x0600A802 RID: 43010 RVA: 0x002C1220 File Offset: 0x002BF420
		public int ItemAccessLength
		{
			get
			{
				int num = this.__p.__offset(26);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600A803 RID: 43011 RVA: 0x002C124C File Offset: 0x002BF44C
		public Span<int> GetItemAccessBytes()
		{
			return this.__p.__vector_as_span<int>(26, 4);
		}

		// Token: 0x0600A804 RID: 43012 RVA: 0x002C125C File Offset: 0x002BF45C
		public int[] GetItemAccessArray()
		{
			return this.__p.__vector_as_array<int>(26) ?? Array.Empty<int>();
		}

		// Token: 0x170024B0 RID: 9392
		// (get) Token: 0x0600A805 RID: 43013 RVA: 0x002C1274 File Offset: 0x002BF474
		public int SortIndex
		{
			get
			{
				int num = this.__p.__offset(28);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170024B1 RID: 9393
		// (get) Token: 0x0600A806 RID: 43014 RVA: 0x002C12B4 File Offset: 0x002BF4B4
		public int RedDotDisableRule
		{
			get
			{
				int num = this.__p.__offset(30);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170024B2 RID: 9394
		// (get) Token: 0x0600A807 RID: 43015 RVA: 0x002C12F4 File Offset: 0x002BF4F4
		public bool ShowInBag
		{
			get
			{
				int num = this.__p.__offset(32);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170024B3 RID: 9395
		// (get) Token: 0x0600A808 RID: 43016 RVA: 0x002C1334 File Offset: 0x002BF534
		public string Icon
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

		// Token: 0x0600A809 RID: 43017 RVA: 0x002C136C File Offset: 0x002BF56C
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(34, 1);
		}

		// Token: 0x0600A80A RID: 43018 RVA: 0x002C137C File Offset: 0x002BF57C
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(34) ?? Array.Empty<byte>();
		}

		// Token: 0x170024B4 RID: 9396
		// (get) Token: 0x0600A80B RID: 43019 RVA: 0x002C1394 File Offset: 0x002BF594
		public string IconMiddle
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

		// Token: 0x0600A80C RID: 43020 RVA: 0x002C13CC File Offset: 0x002BF5CC
		public Span<byte> GetIconMiddleBytes()
		{
			return this.__p.__vector_as_span<byte>(36, 1);
		}

		// Token: 0x0600A80D RID: 43021 RVA: 0x002C13DC File Offset: 0x002BF5DC
		public byte[] GetIconMiddleArray()
		{
			return this.__p.__vector_as_array<byte>(36) ?? Array.Empty<byte>();
		}

		// Token: 0x170024B5 RID: 9397
		// (get) Token: 0x0600A80E RID: 43022 RVA: 0x002C13F4 File Offset: 0x002BF5F4
		public string IconSmall
		{
			get
			{
				int num = this.__p.__offset(38);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600A80F RID: 43023 RVA: 0x002C142C File Offset: 0x002BF62C
		public Span<byte> GetIconSmallBytes()
		{
			return this.__p.__vector_as_span<byte>(38, 1);
		}

		// Token: 0x0600A810 RID: 43024 RVA: 0x002C143C File Offset: 0x002BF63C
		public byte[] GetIconSmallArray()
		{
			return this.__p.__vector_as_array<byte>(38) ?? Array.Empty<byte>();
		}

		// Token: 0x170024B6 RID: 9398
		// (get) Token: 0x0600A811 RID: 43025 RVA: 0x002C1454 File Offset: 0x002BF654
		public string PreviewTextureInBuyView
		{
			get
			{
				int num = this.__p.__offset(40);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600A812 RID: 43026 RVA: 0x002C148C File Offset: 0x002BF68C
		public Span<byte> GetPreviewTextureInBuyViewBytes()
		{
			return this.__p.__vector_as_span<byte>(40, 1);
		}

		// Token: 0x0600A813 RID: 43027 RVA: 0x002C149C File Offset: 0x002BF69C
		public byte[] GetPreviewTextureInBuyViewArray()
		{
			return this.__p.__vector_as_array<byte>(40) ?? Array.Empty<byte>();
		}

		// Token: 0x0600A814 RID: 43028 RVA: 0x002C14B4 File Offset: 0x002BF6B4
		public int ModelId(int j)
		{
			int num = this.__p.__offset(42);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170024B7 RID: 9399
		// (get) Token: 0x0600A815 RID: 43029 RVA: 0x002C14F4 File Offset: 0x002BF6F4
		public int ModelIdLength
		{
			get
			{
				int num = this.__p.__offset(42);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600A816 RID: 43030 RVA: 0x002C1520 File Offset: 0x002BF720
		public Span<int> GetModelIdBytes()
		{
			return this.__p.__vector_as_span<int>(42, 4);
		}

		// Token: 0x0600A817 RID: 43031 RVA: 0x002C1530 File Offset: 0x002BF730
		public int[] GetModelIdArray()
		{
			return this.__p.__vector_as_array<int>(42) ?? Array.Empty<int>();
		}

		// Token: 0x0600A818 RID: 43032 RVA: 0x002C1548 File Offset: 0x002BF748
		public string UiCamera(int j)
		{
			int num = this.__p.__offset(44);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170024B8 RID: 9400
		// (get) Token: 0x0600A819 RID: 43033 RVA: 0x002C1584 File Offset: 0x002BF784
		public int UiCameraLength
		{
			get
			{
				int num = this.__p.__offset(44);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600A81A RID: 43034 RVA: 0x002C15B0 File Offset: 0x002BF7B0
		public DicIntString? UiCameraBlend(int j)
		{
			int num = this.__p.__offset(46);
			if (num == 0)
			{
				return null;
			}
			return new DicIntString?(default(DicIntString).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170024B9 RID: 9401
		// (get) Token: 0x0600A81B RID: 43035 RVA: 0x002C1614 File Offset: 0x002BF814
		public int UiCameraBlendLength
		{
			get
			{
				int num = this.__p.__offset(46);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x170024BA RID: 9402
		// (get) Token: 0x0600A81C RID: 43036 RVA: 0x002C1640 File Offset: 0x002BF840
		public bool AllowUiCameraRotate
		{
			get
			{
				int num = this.__p.__offset(48);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170024BB RID: 9403
		// (get) Token: 0x0600A81D RID: 43037 RVA: 0x002C1680 File Offset: 0x002BF880
		public string UiCameraConfig
		{
			get
			{
				int num = this.__p.__offset(50);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600A81E RID: 43038 RVA: 0x002C16B8 File Offset: 0x002BF8B8
		public Span<byte> GetUiCameraConfigBytes()
		{
			return this.__p.__vector_as_span<byte>(50, 1);
		}

		// Token: 0x0600A81F RID: 43039 RVA: 0x002C16C8 File Offset: 0x002BF8C8
		public byte[] GetUiCameraConfigArray()
		{
			return this.__p.__vector_as_array<byte>(50) ?? Array.Empty<byte>();
		}

		// Token: 0x170024BC RID: 9404
		// (get) Token: 0x0600A820 RID: 43040 RVA: 0x002C16E0 File Offset: 0x002BF8E0
		public string UiCameraOffsetConfig
		{
			get
			{
				int num = this.__p.__offset(52);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600A821 RID: 43041 RVA: 0x002C1718 File Offset: 0x002BF918
		public Span<byte> GetUiCameraOffsetConfigBytes()
		{
			return this.__p.__vector_as_span<byte>(52, 1);
		}

		// Token: 0x0600A822 RID: 43042 RVA: 0x002C1728 File Offset: 0x002BF928
		public byte[] GetUiCameraOffsetConfigArray()
		{
			return this.__p.__vector_as_array<byte>(52) ?? Array.Empty<byte>();
		}

		// Token: 0x0600A823 RID: 43043 RVA: 0x002C1740 File Offset: 0x002BF940
		public string HideUiCamera(int j)
		{
			int num = this.__p.__offset(54);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170024BD RID: 9405
		// (get) Token: 0x0600A824 RID: 43044 RVA: 0x002C177C File Offset: 0x002BF97C
		public int HideUiCameraLength
		{
			get
			{
				int num = this.__p.__offset(54);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x170024BE RID: 9406
		// (get) Token: 0x0600A825 RID: 43045 RVA: 0x002C17A8 File Offset: 0x002BF9A8
		public bool AllowHideUiCameraRotate
		{
			get
			{
				int num = this.__p.__offset(56);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170024BF RID: 9407
		// (get) Token: 0x0600A826 RID: 43046 RVA: 0x002C17E8 File Offset: 0x002BF9E8
		public string HideUiCameraConfig
		{
			get
			{
				int num = this.__p.__offset(58);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600A827 RID: 43047 RVA: 0x002C1820 File Offset: 0x002BFA20
		public Span<byte> GetHideUiCameraConfigBytes()
		{
			return this.__p.__vector_as_span<byte>(58, 1);
		}

		// Token: 0x0600A828 RID: 43048 RVA: 0x002C1830 File Offset: 0x002BFA30
		public byte[] GetHideUiCameraConfigArray()
		{
			return this.__p.__vector_as_array<byte>(58) ?? Array.Empty<byte>();
		}

		// Token: 0x170024C0 RID: 9408
		// (get) Token: 0x0600A829 RID: 43049 RVA: 0x002C1848 File Offset: 0x002BFA48
		public string HideUiCameraOffsetConfig
		{
			get
			{
				int num = this.__p.__offset(60);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600A82A RID: 43050 RVA: 0x002C1880 File Offset: 0x002BFA80
		public Span<byte> GetHideUiCameraOffsetConfigBytes()
		{
			return this.__p.__vector_as_span<byte>(60, 1);
		}

		// Token: 0x0600A82B RID: 43051 RVA: 0x002C1890 File Offset: 0x002BFA90
		public byte[] GetHideUiCameraOffsetConfigArray()
		{
			return this.__p.__vector_as_array<byte>(60) ?? Array.Empty<byte>();
		}

		// Token: 0x0600A82C RID: 43052 RVA: 0x002C18A8 File Offset: 0x002BFAA8
		public long OrnamentBuff(int j)
		{
			int num = this.__p.__offset(62);
			return (long)((num != 0) ? this.__p.bb.GetDouble(this.__p.__vector(num) + j * 8) : 0.0);
		}

		// Token: 0x170024C1 RID: 9409
		// (get) Token: 0x0600A82D RID: 43053 RVA: 0x002C18F4 File Offset: 0x002BFAF4
		public int OrnamentBuffLength
		{
			get
			{
				int num = this.__p.__offset(62);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600A82E RID: 43054 RVA: 0x002C1920 File Offset: 0x002BFB20
		public Span<long> GetOrnamentBuffBytes()
		{
			return MemoryMarshal.Cast<double, long>(this.__p.__vector_as_span<double>(62, 8));
		}

		// Token: 0x0600A82F RID: 43055 RVA: 0x002C1935 File Offset: 0x002BFB35
		public long[] GetOrnamentBuffArray()
		{
			return Array.ConvertAll<double, long>(this.__p.__vector_as_array<double>(62) ?? Array.Empty<double>(), (double x) => (long)x);
		}

		// Token: 0x0600A830 RID: 43056 RVA: 0x002C1974 File Offset: 0x002BFB74
		public long OrnamentUiBuff(int j)
		{
			int num = this.__p.__offset(64);
			return (long)((num != 0) ? this.__p.bb.GetDouble(this.__p.__vector(num) + j * 8) : 0.0);
		}

		// Token: 0x170024C2 RID: 9410
		// (get) Token: 0x0600A831 RID: 43057 RVA: 0x002C19C0 File Offset: 0x002BFBC0
		public int OrnamentUiBuffLength
		{
			get
			{
				int num = this.__p.__offset(64);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600A832 RID: 43058 RVA: 0x002C19EC File Offset: 0x002BFBEC
		public Span<long> GetOrnamentUiBuffBytes()
		{
			return MemoryMarshal.Cast<double, long>(this.__p.__vector_as_span<double>(64, 8));
		}

		// Token: 0x0600A833 RID: 43059 RVA: 0x002C1A01 File Offset: 0x002BFC01
		public long[] GetOrnamentUiBuffArray()
		{
			return Array.ConvertAll<double, long>(this.__p.__vector_as_array<double>(64) ?? Array.Empty<double>(), (double x) => (long)x);
		}

		// Token: 0x170024C3 RID: 9411
		// (get) Token: 0x0600A834 RID: 43060 RVA: 0x002C1A40 File Offset: 0x002BFC40
		public bool HideInUi
		{
			get
			{
				int num = this.__p.__offset(66);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170024C4 RID: 9412
		// (get) Token: 0x0600A835 RID: 43061 RVA: 0x002C1A80 File Offset: 0x002BFC80
		public int UiRoleState
		{
			get
			{
				int num = this.__p.__offset(68);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170024C5 RID: 9413
		// (get) Token: 0x0600A836 RID: 43062 RVA: 0x002C1AC0 File Offset: 0x002BFCC0
		public bool IsNewTag
		{
			get
			{
				int num = this.__p.__offset(70);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170024C6 RID: 9414
		// (get) Token: 0x0600A837 RID: 43063 RVA: 0x002C1B00 File Offset: 0x002BFD00
		public bool ShowUseButton
		{
			get
			{
				int num = this.__p.__offset(72);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170024C7 RID: 9415
		// (get) Token: 0x0600A838 RID: 43064 RVA: 0x002C1B40 File Offset: 0x002BFD40
		public string PreviewTextureInPayShop
		{
			get
			{
				int num = this.__p.__offset(74);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600A839 RID: 43065 RVA: 0x002C1B78 File Offset: 0x002BFD78
		public Span<byte> GetPreviewTextureInPayShopBytes()
		{
			return this.__p.__vector_as_span<byte>(74, 1);
		}

		// Token: 0x0600A83A RID: 43066 RVA: 0x002C1B88 File Offset: 0x002BFD88
		public byte[] GetPreviewTextureInPayShopArray()
		{
			return this.__p.__vector_as_array<byte>(74) ?? Array.Empty<byte>();
		}

		// Token: 0x170024C8 RID: 9416
		// (get) Token: 0x0600A83B RID: 43067 RVA: 0x002C1BA0 File Offset: 0x002BFDA0
		public string PopPreviewTexture
		{
			get
			{
				int num = this.__p.__offset(76);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600A83C RID: 43068 RVA: 0x002C1BD8 File Offset: 0x002BFDD8
		public Span<byte> GetPopPreviewTextureBytes()
		{
			return this.__p.__vector_as_span<byte>(76, 1);
		}

		// Token: 0x0600A83D RID: 43069 RVA: 0x002C1BE8 File Offset: 0x002BFDE8
		public byte[] GetPopPreviewTextureArray()
		{
			return this.__p.__vector_as_array<byte>(76) ?? Array.Empty<byte>();
		}

		// Token: 0x170024C9 RID: 9417
		// (get) Token: 0x0600A83E RID: 43070 RVA: 0x002C1C00 File Offset: 0x002BFE00
		public string TitleName
		{
			get
			{
				int num = this.__p.__offset(78);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600A83F RID: 43071 RVA: 0x002C1C38 File Offset: 0x002BFE38
		public Span<byte> GetTitleNameBytes()
		{
			return this.__p.__vector_as_span<byte>(78, 1);
		}

		// Token: 0x0600A840 RID: 43072 RVA: 0x002C1C48 File Offset: 0x002BFE48
		public byte[] GetTitleNameArray()
		{
			return this.__p.__vector_as_array<byte>(78) ?? Array.Empty<byte>();
		}

		// Token: 0x170024CA RID: 9418
		// (get) Token: 0x0600A841 RID: 43073 RVA: 0x002C1C60 File Offset: 0x002BFE60
		public string SubDecName
		{
			get
			{
				int num = this.__p.__offset(80);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600A842 RID: 43074 RVA: 0x002C1C98 File Offset: 0x002BFE98
		public Span<byte> GetSubDecNameBytes()
		{
			return this.__p.__vector_as_span<byte>(80, 1);
		}

		// Token: 0x0600A843 RID: 43075 RVA: 0x002C1CA8 File Offset: 0x002BFEA8
		public byte[] GetSubDecNameArray()
		{
			return this.__p.__vector_as_array<byte>(80) ?? Array.Empty<byte>();
		}

		// Token: 0x0600A844 RID: 43076 RVA: 0x002C1CC0 File Offset: 0x002BFEC0
		public string UiModelEquipTags(int j)
		{
			int num = this.__p.__offset(82);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170024CB RID: 9419
		// (get) Token: 0x0600A845 RID: 43077 RVA: 0x002C1CFC File Offset: 0x002BFEFC
		public int UiModelEquipTagsLength
		{
			get
			{
				int num = this.__p.__offset(82);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600A846 RID: 43078 RVA: 0x002C1D28 File Offset: 0x002BFF28
		[NullableContext(1)]
		public string[] HideUiCamera()
		{
			return this.HideUiCameraIter().ToArray<string>();
		}

		// Token: 0x0600A847 RID: 43079 RVA: 0x002C1D35 File Offset: 0x002BFF35
		[NullableContext(1)]
		public IEnumerable<string> HideUiCameraIter()
		{
			Ornament.<HideUiCameraIter>d__144 <HideUiCameraIter>d__ = new Ornament.<HideUiCameraIter>d__144(-2);
			<HideUiCameraIter>d__.<>3__<>4__this = this;
			return <HideUiCameraIter>d__;
		}

		// Token: 0x0600A848 RID: 43080 RVA: 0x002C1D4A File Offset: 0x002BFF4A
		[NullableContext(1)]
		public int[] ItemAccess()
		{
			return this.GetItemAccessArray();
		}

		// Token: 0x0600A849 RID: 43081 RVA: 0x002C1D52 File Offset: 0x002BFF52
		[NullableContext(1)]
		public IEnumerable<int> ItemAccessIter()
		{
			Ornament.<ItemAccessIter>d__146 <ItemAccessIter>d__ = new Ornament.<ItemAccessIter>d__146(-2);
			<ItemAccessIter>d__.<>3__<>4__this = this;
			return <ItemAccessIter>d__;
		}

		// Token: 0x0600A84A RID: 43082 RVA: 0x002C1D67 File Offset: 0x002BFF67
		[NullableContext(1)]
		public int[] ModelId()
		{
			return this.GetModelIdArray();
		}

		// Token: 0x0600A84B RID: 43083 RVA: 0x002C1D6F File Offset: 0x002BFF6F
		[NullableContext(1)]
		public IEnumerable<int> ModelIdIter()
		{
			Ornament.<ModelIdIter>d__148 <ModelIdIter>d__ = new Ornament.<ModelIdIter>d__148(-2);
			<ModelIdIter>d__.<>3__<>4__this = this;
			return <ModelIdIter>d__;
		}

		// Token: 0x0600A84C RID: 43084 RVA: 0x002C1D84 File Offset: 0x002BFF84
		[NullableContext(1)]
		public long[] OrnamentBuff()
		{
			return this.GetOrnamentBuffArray();
		}

		// Token: 0x0600A84D RID: 43085 RVA: 0x002C1D8C File Offset: 0x002BFF8C
		[NullableContext(1)]
		public IEnumerable<long> OrnamentBuffIter()
		{
			Ornament.<OrnamentBuffIter>d__150 <OrnamentBuffIter>d__ = new Ornament.<OrnamentBuffIter>d__150(-2);
			<OrnamentBuffIter>d__.<>3__<>4__this = this;
			return <OrnamentBuffIter>d__;
		}

		// Token: 0x0600A84E RID: 43086 RVA: 0x002C1DA1 File Offset: 0x002BFFA1
		[NullableContext(1)]
		public long[] OrnamentUiBuff()
		{
			return this.GetOrnamentUiBuffArray();
		}

		// Token: 0x0600A84F RID: 43087 RVA: 0x002C1DA9 File Offset: 0x002BFFA9
		[NullableContext(1)]
		public IEnumerable<long> OrnamentUiBuffIter()
		{
			Ornament.<OrnamentUiBuffIter>d__152 <OrnamentUiBuffIter>d__ = new Ornament.<OrnamentUiBuffIter>d__152(-2);
			<OrnamentUiBuffIter>d__.<>3__<>4__this = this;
			return <OrnamentUiBuffIter>d__;
		}

		// Token: 0x0600A850 RID: 43088 RVA: 0x002C1DBE File Offset: 0x002BFFBE
		[NullableContext(1)]
		public int[] RoleSkinIds()
		{
			return this.GetRoleSkinIdsArray();
		}

		// Token: 0x0600A851 RID: 43089 RVA: 0x002C1DC6 File Offset: 0x002BFFC6
		[NullableContext(1)]
		public IEnumerable<int> RoleSkinIdsIter()
		{
			Ornament.<RoleSkinIdsIter>d__154 <RoleSkinIdsIter>d__ = new Ornament.<RoleSkinIdsIter>d__154(-2);
			<RoleSkinIdsIter>d__.<>3__<>4__this = this;
			return <RoleSkinIdsIter>d__;
		}

		// Token: 0x0600A852 RID: 43090 RVA: 0x002C1DDB File Offset: 0x002BFFDB
		[NullableContext(1)]
		public string[] UiCamera()
		{
			return this.UiCameraIter().ToArray<string>();
		}

		// Token: 0x0600A853 RID: 43091 RVA: 0x002C1DE8 File Offset: 0x002BFFE8
		[NullableContext(1)]
		public IEnumerable<string> UiCameraIter()
		{
			Ornament.<UiCameraIter>d__156 <UiCameraIter>d__ = new Ornament.<UiCameraIter>d__156(-2);
			<UiCameraIter>d__.<>3__<>4__this = this;
			return <UiCameraIter>d__;
		}

		// Token: 0x0600A854 RID: 43092 RVA: 0x002C1E00 File Offset: 0x002C0000
		[NullableContext(1)]
		public Dictionary<int, string> UiCameraBlend()
		{
			return this.UiCameraBlendIter().ToDictionary((DicIntString element) => element.Key, (DicIntString element) => element.Value);
		}

		// Token: 0x0600A855 RID: 43093 RVA: 0x002C1E56 File Offset: 0x002C0056
		[NullableContext(1)]
		public IEnumerable<DicIntString> UiCameraBlendIter()
		{
			Ornament.<UiCameraBlendIter>d__158 <UiCameraBlendIter>d__ = new Ornament.<UiCameraBlendIter>d__158(-2);
			<UiCameraBlendIter>d__.<>3__<>4__this = this;
			return <UiCameraBlendIter>d__;
		}

		// Token: 0x0600A856 RID: 43094 RVA: 0x002C1E6B File Offset: 0x002C006B
		[NullableContext(1)]
		public string[] UiModelEquipTags()
		{
			return this.UiModelEquipTagsIter().ToArray<string>();
		}

		// Token: 0x0600A857 RID: 43095 RVA: 0x002C1E78 File Offset: 0x002C0078
		[NullableContext(1)]
		public IEnumerable<string> UiModelEquipTagsIter()
		{
			Ornament.<UiModelEquipTagsIter>d__160 <UiModelEquipTagsIter>d__ = new Ornament.<UiModelEquipTagsIter>d__160(-2);
			<UiModelEquipTagsIter>d__.<>3__<>4__this = this;
			return <UiModelEquipTagsIter>d__;
		}

		// Token: 0x0600A858 RID: 43096 RVA: 0x002C1E90 File Offset: 0x002C0090
		[NullableContext(2)]
		public string GetUiCameraBlend(int key)
		{
			this.EnsureUiCameraBlendCacheIfNeeded();
			string result;
			if (!this.UiCameraBlendCache.TryGetValue(key, out result))
			{
				return null;
			}
			return result;
		}

		// Token: 0x0600A859 RID: 43097 RVA: 0x002C1EB8 File Offset: 0x002C00B8
		private void EnsureUiCameraBlendCacheIfNeeded()
		{
			if (this.UiCameraBlendCache != null)
			{
				return;
			}
			this.UiCameraBlendCache = this.UiCameraBlendIter().ToFrozenDictionary((DicIntString kvp) => kvp.Key, (DicIntString kvp) => kvp.Value, null);
		}

		// Token: 0x0600A85A RID: 43098 RVA: 0x002C1F1E File Offset: 0x002C011E
		[NullableContext(1)]
		public FrozenDictionary<int, string> GetUiCameraBlendFrozenDict()
		{
			this.EnsureUiCameraBlendCacheIfNeeded();
			return this.UiCameraBlendCache;
		}

		// Token: 0x0400553F RID: 21823
		private Table __p;

		// Token: 0x04005540 RID: 21824
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private FrozenDictionary<int, string> UiCameraBlendCache;
	}
}
