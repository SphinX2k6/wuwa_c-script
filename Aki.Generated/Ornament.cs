using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000EA6 RID: 3750
	public struct Ornament : IFlatbufferObject
	{
		// Token: 0x1700243E RID: 9278
		// (get) Token: 0x0600A1C1 RID: 41409 RVA: 0x002A393B File Offset: 0x002A1B3B
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600A1C2 RID: 41410 RVA: 0x002A3948 File Offset: 0x002A1B48
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600A1C3 RID: 41411 RVA: 0x002A3950 File Offset: 0x002A1B50
		public static Ornament GetRootAsOrnament(ByteBuffer _bb)
		{
			return Ornament.GetRootAsOrnament(_bb, default(Ornament));
		}

		// Token: 0x0600A1C4 RID: 41412 RVA: 0x002A396C File Offset: 0x002A1B6C
		public static Ornament GetRootAsOrnament(ByteBuffer _bb, Ornament obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600A1C5 RID: 41413 RVA: 0x002A3989 File Offset: 0x002A1B89
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600A1C6 RID: 41414 RVA: 0x002A3998 File Offset: 0x002A1B98
		public Ornament __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700243F RID: 9279
		// (get) Token: 0x0600A1C7 RID: 41415 RVA: 0x002A39A8 File Offset: 0x002A1BA8
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

		// Token: 0x17002440 RID: 9280
		// (get) Token: 0x0600A1C8 RID: 41416 RVA: 0x002A39E4 File Offset: 0x002A1BE4
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

		// Token: 0x0600A1C9 RID: 41417 RVA: 0x002A3A20 File Offset: 0x002A1C20
		public int RoleSkinIds(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002441 RID: 9281
		// (get) Token: 0x0600A1CA RID: 41418 RVA: 0x002A3A60 File Offset: 0x002A1C60
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

		// Token: 0x0600A1CB RID: 41419 RVA: 0x002A3A8B File Offset: 0x002A1C8B
		public Span<int> GetRoleSkinIdsBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x0600A1CC RID: 41420 RVA: 0x002A3A9A File Offset: 0x002A1C9A
		public int[] GetRoleSkinIdsArray()
		{
			return this.__p.__vector_as_array<int>(8) ?? Array.Empty<int>();
		}

		// Token: 0x17002442 RID: 9282
		// (get) Token: 0x0600A1CD RID: 41421 RVA: 0x002A3AB4 File Offset: 0x002A1CB4
		public bool DefaultOrnament
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17002443 RID: 9283
		// (get) Token: 0x0600A1CE RID: 41422 RVA: 0x002A3AF4 File Offset: 0x002A1CF4
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

		// Token: 0x17002444 RID: 9284
		// (get) Token: 0x0600A1CF RID: 41423 RVA: 0x002A3B34 File Offset: 0x002A1D34
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

		// Token: 0x0600A1D0 RID: 41424 RVA: 0x002A3B6C File Offset: 0x002A1D6C
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600A1D1 RID: 41425 RVA: 0x002A3B7C File Offset: 0x002A1D7C
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17002445 RID: 9285
		// (get) Token: 0x0600A1D2 RID: 41426 RVA: 0x002A3B94 File Offset: 0x002A1D94
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

		// Token: 0x0600A1D3 RID: 41427 RVA: 0x002A3BCC File Offset: 0x002A1DCC
		public Span<byte> GetBgDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600A1D4 RID: 41428 RVA: 0x002A3BDC File Offset: 0x002A1DDC
		public byte[] GetBgDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x17002446 RID: 9286
		// (get) Token: 0x0600A1D5 RID: 41429 RVA: 0x002A3BF4 File Offset: 0x002A1DF4
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

		// Token: 0x0600A1D6 RID: 41430 RVA: 0x002A3C2C File Offset: 0x002A1E2C
		public Span<byte> GetObtainedShowDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0600A1D7 RID: 41431 RVA: 0x002A3C3C File Offset: 0x002A1E3C
		public byte[] GetObtainedShowDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x17002447 RID: 9287
		// (get) Token: 0x0600A1D8 RID: 41432 RVA: 0x002A3C54 File Offset: 0x002A1E54
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

		// Token: 0x0600A1D9 RID: 41433 RVA: 0x002A3C8C File Offset: 0x002A1E8C
		public Span<byte> GetAttributesDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x0600A1DA RID: 41434 RVA: 0x002A3C9C File Offset: 0x002A1E9C
		public byte[] GetAttributesDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x17002448 RID: 9288
		// (get) Token: 0x0600A1DB RID: 41435 RVA: 0x002A3CB4 File Offset: 0x002A1EB4
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

		// Token: 0x0600A1DC RID: 41436 RVA: 0x002A3CEC File Offset: 0x002A1EEC
		public Span<byte> GetShopPreviewSubTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x0600A1DD RID: 41437 RVA: 0x002A3CFC File Offset: 0x002A1EFC
		public byte[] GetShopPreviewSubTitleArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x17002449 RID: 9289
		// (get) Token: 0x0600A1DE RID: 41438 RVA: 0x002A3D14 File Offset: 0x002A1F14
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

		// Token: 0x0600A1DF RID: 41439 RVA: 0x002A3D4C File Offset: 0x002A1F4C
		public Span<byte> GetTypeDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(24, 1);
		}

		// Token: 0x0600A1E0 RID: 41440 RVA: 0x002A3D5C File Offset: 0x002A1F5C
		public byte[] GetTypeDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(24) ?? Array.Empty<byte>();
		}

		// Token: 0x0600A1E1 RID: 41441 RVA: 0x002A3D74 File Offset: 0x002A1F74
		public int ItemAccess(int j)
		{
			int num = this.__p.__offset(26);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700244A RID: 9290
		// (get) Token: 0x0600A1E2 RID: 41442 RVA: 0x002A3DB4 File Offset: 0x002A1FB4
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

		// Token: 0x0600A1E3 RID: 41443 RVA: 0x002A3DE0 File Offset: 0x002A1FE0
		public Span<int> GetItemAccessBytes()
		{
			return this.__p.__vector_as_span<int>(26, 4);
		}

		// Token: 0x0600A1E4 RID: 41444 RVA: 0x002A3DF0 File Offset: 0x002A1FF0
		public int[] GetItemAccessArray()
		{
			return this.__p.__vector_as_array<int>(26) ?? Array.Empty<int>();
		}

		// Token: 0x1700244B RID: 9291
		// (get) Token: 0x0600A1E5 RID: 41445 RVA: 0x002A3E08 File Offset: 0x002A2008
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

		// Token: 0x1700244C RID: 9292
		// (get) Token: 0x0600A1E6 RID: 41446 RVA: 0x002A3E48 File Offset: 0x002A2048
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

		// Token: 0x1700244D RID: 9293
		// (get) Token: 0x0600A1E7 RID: 41447 RVA: 0x002A3E88 File Offset: 0x002A2088
		public bool ShowInBag
		{
			get
			{
				int num = this.__p.__offset(32);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700244E RID: 9294
		// (get) Token: 0x0600A1E8 RID: 41448 RVA: 0x002A3EC8 File Offset: 0x002A20C8
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

		// Token: 0x0600A1E9 RID: 41449 RVA: 0x002A3F00 File Offset: 0x002A2100
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(34, 1);
		}

		// Token: 0x0600A1EA RID: 41450 RVA: 0x002A3F10 File Offset: 0x002A2110
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(34) ?? Array.Empty<byte>();
		}

		// Token: 0x1700244F RID: 9295
		// (get) Token: 0x0600A1EB RID: 41451 RVA: 0x002A3F28 File Offset: 0x002A2128
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

		// Token: 0x0600A1EC RID: 41452 RVA: 0x002A3F60 File Offset: 0x002A2160
		public Span<byte> GetIconMiddleBytes()
		{
			return this.__p.__vector_as_span<byte>(36, 1);
		}

		// Token: 0x0600A1ED RID: 41453 RVA: 0x002A3F70 File Offset: 0x002A2170
		public byte[] GetIconMiddleArray()
		{
			return this.__p.__vector_as_array<byte>(36) ?? Array.Empty<byte>();
		}

		// Token: 0x17002450 RID: 9296
		// (get) Token: 0x0600A1EE RID: 41454 RVA: 0x002A3F88 File Offset: 0x002A2188
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

		// Token: 0x0600A1EF RID: 41455 RVA: 0x002A3FC0 File Offset: 0x002A21C0
		public Span<byte> GetIconSmallBytes()
		{
			return this.__p.__vector_as_span<byte>(38, 1);
		}

		// Token: 0x0600A1F0 RID: 41456 RVA: 0x002A3FD0 File Offset: 0x002A21D0
		public byte[] GetIconSmallArray()
		{
			return this.__p.__vector_as_array<byte>(38) ?? Array.Empty<byte>();
		}

		// Token: 0x17002451 RID: 9297
		// (get) Token: 0x0600A1F1 RID: 41457 RVA: 0x002A3FE8 File Offset: 0x002A21E8
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

		// Token: 0x0600A1F2 RID: 41458 RVA: 0x002A4020 File Offset: 0x002A2220
		public Span<byte> GetPreviewTextureInBuyViewBytes()
		{
			return this.__p.__vector_as_span<byte>(40, 1);
		}

		// Token: 0x0600A1F3 RID: 41459 RVA: 0x002A4030 File Offset: 0x002A2230
		public byte[] GetPreviewTextureInBuyViewArray()
		{
			return this.__p.__vector_as_array<byte>(40) ?? Array.Empty<byte>();
		}

		// Token: 0x0600A1F4 RID: 41460 RVA: 0x002A4048 File Offset: 0x002A2248
		public int ModelId(int j)
		{
			int num = this.__p.__offset(42);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002452 RID: 9298
		// (get) Token: 0x0600A1F5 RID: 41461 RVA: 0x002A4088 File Offset: 0x002A2288
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

		// Token: 0x0600A1F6 RID: 41462 RVA: 0x002A40B4 File Offset: 0x002A22B4
		public Span<int> GetModelIdBytes()
		{
			return this.__p.__vector_as_span<int>(42, 4);
		}

		// Token: 0x0600A1F7 RID: 41463 RVA: 0x002A40C4 File Offset: 0x002A22C4
		public int[] GetModelIdArray()
		{
			return this.__p.__vector_as_array<int>(42) ?? Array.Empty<int>();
		}

		// Token: 0x0600A1F8 RID: 41464 RVA: 0x002A40DC File Offset: 0x002A22DC
		public string UiCamera(int j)
		{
			int num = this.__p.__offset(44);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002453 RID: 9299
		// (get) Token: 0x0600A1F9 RID: 41465 RVA: 0x002A4118 File Offset: 0x002A2318
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

		// Token: 0x0600A1FA RID: 41466 RVA: 0x002A4144 File Offset: 0x002A2344
		public DicIntString? UiCameraBlend(int j)
		{
			int num = this.__p.__offset(46);
			if (num == 0)
			{
				return null;
			}
			return new DicIntString?(default(DicIntString).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17002454 RID: 9300
		// (get) Token: 0x0600A1FB RID: 41467 RVA: 0x002A41A8 File Offset: 0x002A23A8
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

		// Token: 0x17002455 RID: 9301
		// (get) Token: 0x0600A1FC RID: 41468 RVA: 0x002A41D4 File Offset: 0x002A23D4
		public bool AllowUiCameraRotate
		{
			get
			{
				int num = this.__p.__offset(48);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17002456 RID: 9302
		// (get) Token: 0x0600A1FD RID: 41469 RVA: 0x002A4214 File Offset: 0x002A2414
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

		// Token: 0x0600A1FE RID: 41470 RVA: 0x002A424C File Offset: 0x002A244C
		public Span<byte> GetUiCameraConfigBytes()
		{
			return this.__p.__vector_as_span<byte>(50, 1);
		}

		// Token: 0x0600A1FF RID: 41471 RVA: 0x002A425C File Offset: 0x002A245C
		public byte[] GetUiCameraConfigArray()
		{
			return this.__p.__vector_as_array<byte>(50) ?? Array.Empty<byte>();
		}

		// Token: 0x17002457 RID: 9303
		// (get) Token: 0x0600A200 RID: 41472 RVA: 0x002A4274 File Offset: 0x002A2474
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

		// Token: 0x0600A201 RID: 41473 RVA: 0x002A42AC File Offset: 0x002A24AC
		public Span<byte> GetUiCameraOffsetConfigBytes()
		{
			return this.__p.__vector_as_span<byte>(52, 1);
		}

		// Token: 0x0600A202 RID: 41474 RVA: 0x002A42BC File Offset: 0x002A24BC
		public byte[] GetUiCameraOffsetConfigArray()
		{
			return this.__p.__vector_as_array<byte>(52) ?? Array.Empty<byte>();
		}

		// Token: 0x0600A203 RID: 41475 RVA: 0x002A42D4 File Offset: 0x002A24D4
		public string HideUiCamera(int j)
		{
			int num = this.__p.__offset(54);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002458 RID: 9304
		// (get) Token: 0x0600A204 RID: 41476 RVA: 0x002A4310 File Offset: 0x002A2510
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

		// Token: 0x17002459 RID: 9305
		// (get) Token: 0x0600A205 RID: 41477 RVA: 0x002A433C File Offset: 0x002A253C
		public bool AllowHideUiCameraRotate
		{
			get
			{
				int num = this.__p.__offset(56);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700245A RID: 9306
		// (get) Token: 0x0600A206 RID: 41478 RVA: 0x002A437C File Offset: 0x002A257C
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

		// Token: 0x0600A207 RID: 41479 RVA: 0x002A43B4 File Offset: 0x002A25B4
		public Span<byte> GetHideUiCameraConfigBytes()
		{
			return this.__p.__vector_as_span<byte>(58, 1);
		}

		// Token: 0x0600A208 RID: 41480 RVA: 0x002A43C4 File Offset: 0x002A25C4
		public byte[] GetHideUiCameraConfigArray()
		{
			return this.__p.__vector_as_array<byte>(58) ?? Array.Empty<byte>();
		}

		// Token: 0x1700245B RID: 9307
		// (get) Token: 0x0600A209 RID: 41481 RVA: 0x002A43DC File Offset: 0x002A25DC
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

		// Token: 0x0600A20A RID: 41482 RVA: 0x002A4414 File Offset: 0x002A2614
		public Span<byte> GetHideUiCameraOffsetConfigBytes()
		{
			return this.__p.__vector_as_span<byte>(60, 1);
		}

		// Token: 0x0600A20B RID: 41483 RVA: 0x002A4424 File Offset: 0x002A2624
		public byte[] GetHideUiCameraOffsetConfigArray()
		{
			return this.__p.__vector_as_array<byte>(60) ?? Array.Empty<byte>();
		}

		// Token: 0x0600A20C RID: 41484 RVA: 0x002A443C File Offset: 0x002A263C
		public long OrnamentBuff(int j)
		{
			int num = this.__p.__offset(62);
			return (long)((num != 0) ? this.__p.bb.GetDouble(this.__p.__vector(num) + j * 8) : 0.0);
		}

		// Token: 0x1700245C RID: 9308
		// (get) Token: 0x0600A20D RID: 41485 RVA: 0x002A4488 File Offset: 0x002A2688
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

		// Token: 0x0600A20E RID: 41486 RVA: 0x002A44B4 File Offset: 0x002A26B4
		public Span<long> GetOrnamentBuffBytes()
		{
			return MemoryMarshal.Cast<double, long>(this.__p.__vector_as_span<double>(62, 8));
		}

		// Token: 0x0600A20F RID: 41487 RVA: 0x002A44C9 File Offset: 0x002A26C9
		public long[] GetOrnamentBuffArray()
		{
			return Array.ConvertAll<double, long>(this.__p.__vector_as_array<double>(62) ?? Array.Empty<double>(), (double x) => (long)x);
		}

		// Token: 0x0600A210 RID: 41488 RVA: 0x002A4508 File Offset: 0x002A2708
		public long OrnamentUiBuff(int j)
		{
			int num = this.__p.__offset(64);
			return (long)((num != 0) ? this.__p.bb.GetDouble(this.__p.__vector(num) + j * 8) : 0.0);
		}

		// Token: 0x1700245D RID: 9309
		// (get) Token: 0x0600A211 RID: 41489 RVA: 0x002A4554 File Offset: 0x002A2754
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

		// Token: 0x0600A212 RID: 41490 RVA: 0x002A4580 File Offset: 0x002A2780
		public Span<long> GetOrnamentUiBuffBytes()
		{
			return MemoryMarshal.Cast<double, long>(this.__p.__vector_as_span<double>(64, 8));
		}

		// Token: 0x0600A213 RID: 41491 RVA: 0x002A4595 File Offset: 0x002A2795
		public long[] GetOrnamentUiBuffArray()
		{
			return Array.ConvertAll<double, long>(this.__p.__vector_as_array<double>(64) ?? Array.Empty<double>(), (double x) => (long)x);
		}

		// Token: 0x1700245E RID: 9310
		// (get) Token: 0x0600A214 RID: 41492 RVA: 0x002A45D4 File Offset: 0x002A27D4
		public bool HideInUi
		{
			get
			{
				int num = this.__p.__offset(66);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700245F RID: 9311
		// (get) Token: 0x0600A215 RID: 41493 RVA: 0x002A4614 File Offset: 0x002A2814
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

		// Token: 0x17002460 RID: 9312
		// (get) Token: 0x0600A216 RID: 41494 RVA: 0x002A4654 File Offset: 0x002A2854
		public bool IsNewTag
		{
			get
			{
				int num = this.__p.__offset(70);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17002461 RID: 9313
		// (get) Token: 0x0600A217 RID: 41495 RVA: 0x002A4694 File Offset: 0x002A2894
		public bool ShowUseButton
		{
			get
			{
				int num = this.__p.__offset(72);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17002462 RID: 9314
		// (get) Token: 0x0600A218 RID: 41496 RVA: 0x002A46D4 File Offset: 0x002A28D4
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

		// Token: 0x0600A219 RID: 41497 RVA: 0x002A470C File Offset: 0x002A290C
		public Span<byte> GetPreviewTextureInPayShopBytes()
		{
			return this.__p.__vector_as_span<byte>(74, 1);
		}

		// Token: 0x0600A21A RID: 41498 RVA: 0x002A471C File Offset: 0x002A291C
		public byte[] GetPreviewTextureInPayShopArray()
		{
			return this.__p.__vector_as_array<byte>(74) ?? Array.Empty<byte>();
		}

		// Token: 0x17002463 RID: 9315
		// (get) Token: 0x0600A21B RID: 41499 RVA: 0x002A4734 File Offset: 0x002A2934
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

		// Token: 0x0600A21C RID: 41500 RVA: 0x002A476C File Offset: 0x002A296C
		public Span<byte> GetPopPreviewTextureBytes()
		{
			return this.__p.__vector_as_span<byte>(76, 1);
		}

		// Token: 0x0600A21D RID: 41501 RVA: 0x002A477C File Offset: 0x002A297C
		public byte[] GetPopPreviewTextureArray()
		{
			return this.__p.__vector_as_array<byte>(76) ?? Array.Empty<byte>();
		}

		// Token: 0x17002464 RID: 9316
		// (get) Token: 0x0600A21E RID: 41502 RVA: 0x002A4794 File Offset: 0x002A2994
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

		// Token: 0x0600A21F RID: 41503 RVA: 0x002A47CC File Offset: 0x002A29CC
		public Span<byte> GetTitleNameBytes()
		{
			return this.__p.__vector_as_span<byte>(78, 1);
		}

		// Token: 0x0600A220 RID: 41504 RVA: 0x002A47DC File Offset: 0x002A29DC
		public byte[] GetTitleNameArray()
		{
			return this.__p.__vector_as_array<byte>(78) ?? Array.Empty<byte>();
		}

		// Token: 0x17002465 RID: 9317
		// (get) Token: 0x0600A221 RID: 41505 RVA: 0x002A47F4 File Offset: 0x002A29F4
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

		// Token: 0x0600A222 RID: 41506 RVA: 0x002A482C File Offset: 0x002A2A2C
		public Span<byte> GetSubDecNameBytes()
		{
			return this.__p.__vector_as_span<byte>(80, 1);
		}

		// Token: 0x0600A223 RID: 41507 RVA: 0x002A483C File Offset: 0x002A2A3C
		public byte[] GetSubDecNameArray()
		{
			return this.__p.__vector_as_array<byte>(80) ?? Array.Empty<byte>();
		}

		// Token: 0x0600A224 RID: 41508 RVA: 0x002A4854 File Offset: 0x002A2A54
		public string UiModelEquipTags(int j)
		{
			int num = this.__p.__offset(82);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002466 RID: 9318
		// (get) Token: 0x0600A225 RID: 41509 RVA: 0x002A4890 File Offset: 0x002A2A90
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

		// Token: 0x0600A226 RID: 41510 RVA: 0x002A48BC File Offset: 0x002A2ABC
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用HideUiCameraIter()或GetHideUiCameraBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] HideUiCamera()
		{
			return this.HideUiCameraIter().ToArray<string>();
		}

		// Token: 0x0600A227 RID: 41511 RVA: 0x002A48C9 File Offset: 0x002A2AC9
		[NullableContext(1)]
		public readonly IEnumerable<string> HideUiCameraIter()
		{
			Ornament.<HideUiCameraIter>d__144 <HideUiCameraIter>d__ = new Ornament.<HideUiCameraIter>d__144(-2);
			<HideUiCameraIter>d__.<>3__<>4__this = this;
			return <HideUiCameraIter>d__;
		}

		// Token: 0x0600A228 RID: 41512 RVA: 0x002A48E0 File Offset: 0x002A2AE0
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用ItemAccessIter()或GetItemAccessBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] ItemAccess()
		{
			Ornament ornament = this;
			return ornament.GetItemAccessArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600A229 RID: 41513 RVA: 0x002A4904 File Offset: 0x002A2B04
		[NullableContext(1)]
		public readonly IEnumerable<int> ItemAccessIter()
		{
			Ornament.<ItemAccessIter>d__146 <ItemAccessIter>d__ = new Ornament.<ItemAccessIter>d__146(-2);
			<ItemAccessIter>d__.<>3__<>4__this = this;
			return <ItemAccessIter>d__;
		}

		// Token: 0x0600A22A RID: 41514 RVA: 0x002A491C File Offset: 0x002A2B1C
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用ModelIdIter()或GetModelIdBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] ModelId()
		{
			Ornament ornament = this;
			return ornament.GetModelIdArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600A22B RID: 41515 RVA: 0x002A4940 File Offset: 0x002A2B40
		[NullableContext(1)]
		public readonly IEnumerable<int> ModelIdIter()
		{
			Ornament.<ModelIdIter>d__148 <ModelIdIter>d__ = new Ornament.<ModelIdIter>d__148(-2);
			<ModelIdIter>d__.<>3__<>4__this = this;
			return <ModelIdIter>d__;
		}

		// Token: 0x0600A22C RID: 41516 RVA: 0x002A4958 File Offset: 0x002A2B58
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用OrnamentBuffIter()或GetOrnamentBuffBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly long[] OrnamentBuff()
		{
			Ornament ornament = this;
			return ornament.GetOrnamentBuffArray() ?? Array.Empty<long>();
		}

		// Token: 0x0600A22D RID: 41517 RVA: 0x002A497C File Offset: 0x002A2B7C
		[NullableContext(1)]
		public readonly IEnumerable<long> OrnamentBuffIter()
		{
			Ornament.<OrnamentBuffIter>d__150 <OrnamentBuffIter>d__ = new Ornament.<OrnamentBuffIter>d__150(-2);
			<OrnamentBuffIter>d__.<>3__<>4__this = this;
			return <OrnamentBuffIter>d__;
		}

		// Token: 0x0600A22E RID: 41518 RVA: 0x002A4994 File Offset: 0x002A2B94
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用OrnamentUiBuffIter()或GetOrnamentUiBuffBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly long[] OrnamentUiBuff()
		{
			Ornament ornament = this;
			return ornament.GetOrnamentUiBuffArray() ?? Array.Empty<long>();
		}

		// Token: 0x0600A22F RID: 41519 RVA: 0x002A49B8 File Offset: 0x002A2BB8
		[NullableContext(1)]
		public readonly IEnumerable<long> OrnamentUiBuffIter()
		{
			Ornament.<OrnamentUiBuffIter>d__152 <OrnamentUiBuffIter>d__ = new Ornament.<OrnamentUiBuffIter>d__152(-2);
			<OrnamentUiBuffIter>d__.<>3__<>4__this = this;
			return <OrnamentUiBuffIter>d__;
		}

		// Token: 0x0600A230 RID: 41520 RVA: 0x002A49D0 File Offset: 0x002A2BD0
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用RoleSkinIdsIter()或GetRoleSkinIdsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] RoleSkinIds()
		{
			Ornament ornament = this;
			return ornament.GetRoleSkinIdsArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600A231 RID: 41521 RVA: 0x002A49F4 File Offset: 0x002A2BF4
		[NullableContext(1)]
		public readonly IEnumerable<int> RoleSkinIdsIter()
		{
			Ornament.<RoleSkinIdsIter>d__154 <RoleSkinIdsIter>d__ = new Ornament.<RoleSkinIdsIter>d__154(-2);
			<RoleSkinIdsIter>d__.<>3__<>4__this = this;
			return <RoleSkinIdsIter>d__;
		}

		// Token: 0x0600A232 RID: 41522 RVA: 0x002A4A09 File Offset: 0x002A2C09
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用UiCameraIter()或GetUiCameraBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] UiCamera()
		{
			return this.UiCameraIter().ToArray<string>();
		}

		// Token: 0x0600A233 RID: 41523 RVA: 0x002A4A16 File Offset: 0x002A2C16
		[NullableContext(1)]
		public readonly IEnumerable<string> UiCameraIter()
		{
			Ornament.<UiCameraIter>d__156 <UiCameraIter>d__ = new Ornament.<UiCameraIter>d__156(-2);
			<UiCameraIter>d__.<>3__<>4__this = this;
			return <UiCameraIter>d__;
		}

		// Token: 0x0600A234 RID: 41524 RVA: 0x002A4A2C File Offset: 0x002A2C2C
		[NullableContext(1)]
		[Obsolete("已废弃，请使用UiCameraBlendFrozenDict()缓存字典，遍历请使用UiCameraBlendIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, string> UiCameraBlend()
		{
			return this.UiCameraBlendIter().ToDictionary((DicIntString element) => element.Key, (DicIntString element) => element.Value);
		}

		// Token: 0x0600A235 RID: 41525 RVA: 0x002A4A82 File Offset: 0x002A2C82
		[NullableContext(1)]
		public readonly IEnumerable<DicIntString> UiCameraBlendIter()
		{
			Ornament.<UiCameraBlendIter>d__158 <UiCameraBlendIter>d__ = new Ornament.<UiCameraBlendIter>d__158(-2);
			<UiCameraBlendIter>d__.<>3__<>4__this = this;
			return <UiCameraBlendIter>d__;
		}

		// Token: 0x0600A236 RID: 41526 RVA: 0x002A4A97 File Offset: 0x002A2C97
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用UiModelEquipTagsIter()或GetUiModelEquipTagsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] UiModelEquipTags()
		{
			return this.UiModelEquipTagsIter().ToArray<string>();
		}

		// Token: 0x0600A237 RID: 41527 RVA: 0x002A4AA4 File Offset: 0x002A2CA4
		[NullableContext(1)]
		public readonly IEnumerable<string> UiModelEquipTagsIter()
		{
			Ornament.<UiModelEquipTagsIter>d__160 <UiModelEquipTagsIter>d__ = new Ornament.<UiModelEquipTagsIter>d__160(-2);
			<UiModelEquipTagsIter>d__.<>3__<>4__this = this;
			return <UiModelEquipTagsIter>d__;
		}

		// Token: 0x0600A238 RID: 41528 RVA: 0x002A4ABC File Offset: 0x002A2CBC
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

		// Token: 0x0600A239 RID: 41529 RVA: 0x002A4AE4 File Offset: 0x002A2CE4
		private void EnsureUiCameraBlendCacheIfNeeded()
		{
			if (this.UiCameraBlendCache != null)
			{
				return;
			}
			this.UiCameraBlendCache = this.UiCameraBlendIter().ToFrozenDictionary((DicIntString kvp) => kvp.Key, (DicIntString kvp) => kvp.Value, null);
		}

		// Token: 0x0600A23A RID: 41530 RVA: 0x002A4B4A File Offset: 0x002A2D4A
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public FrozenDictionary<int, string> GetUiCameraBlendFrozenDict(int key)
		{
			this.EnsureUiCameraBlendCacheIfNeeded();
			return this.UiCameraBlendCache;
		}

		// Token: 0x04004F5A RID: 20314
		private Table __p;

		// Token: 0x04004F5B RID: 20315
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private FrozenDictionary<int, string> UiCameraBlendCache;
	}
}
