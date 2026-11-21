using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F4D RID: 3917
	public struct MotorSkin : IFlatbufferObject
	{
		// Token: 0x1700226F RID: 8815
		// (get) Token: 0x0600A1D7 RID: 41431 RVA: 0x002B3F04 File Offset: 0x002B2104
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600A1D8 RID: 41432 RVA: 0x002B3F11 File Offset: 0x002B2111
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600A1D9 RID: 41433 RVA: 0x002B3F18 File Offset: 0x002B2118
		public static MotorSkin GetRootAsMotorSkin(ByteBuffer _bb)
		{
			return MotorSkin.GetRootAsMotorSkin(_bb, default(MotorSkin));
		}

		// Token: 0x0600A1DA RID: 41434 RVA: 0x002B3F34 File Offset: 0x002B2134
		public static MotorSkin GetRootAsMotorSkin(ByteBuffer _bb, MotorSkin obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600A1DB RID: 41435 RVA: 0x002B3F51 File Offset: 0x002B2151
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600A1DC RID: 41436 RVA: 0x002B3F60 File Offset: 0x002B2160
		public MotorSkin __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002270 RID: 8816
		// (get) Token: 0x0600A1DD RID: 41437 RVA: 0x002B3F70 File Offset: 0x002B2170
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

		// Token: 0x17002271 RID: 8817
		// (get) Token: 0x0600A1DE RID: 41438 RVA: 0x002B3FAC File Offset: 0x002B21AC
		public bool DefaultFlag
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17002272 RID: 8818
		// (get) Token: 0x0600A1DF RID: 41439 RVA: 0x002B3FEC File Offset: 0x002B21EC
		public int SortIndex
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

		// Token: 0x17002273 RID: 8819
		// (get) Token: 0x0600A1E0 RID: 41440 RVA: 0x002B4028 File Offset: 0x002B2228
		public bool Editable
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0600A1E1 RID: 41441 RVA: 0x002B4068 File Offset: 0x002B2268
		public int BindSticker(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002274 RID: 8820
		// (get) Token: 0x0600A1E2 RID: 41442 RVA: 0x002B40A8 File Offset: 0x002B22A8
		public int BindStickerLength
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600A1E3 RID: 41443 RVA: 0x002B40D4 File Offset: 0x002B22D4
		public Span<int> GetBindStickerBytes()
		{
			return this.__p.__vector_as_span<int>(12, 4);
		}

		// Token: 0x0600A1E4 RID: 41444 RVA: 0x002B40E4 File Offset: 0x002B22E4
		public int[] GetBindStickerArray()
		{
			return this.__p.__vector_as_array<int>(12) ?? Array.Empty<int>();
		}

		// Token: 0x17002275 RID: 8821
		// (get) Token: 0x0600A1E5 RID: 41445 RVA: 0x002B40FC File Offset: 0x002B22FC
		public int BindFrame
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

		// Token: 0x0600A1E6 RID: 41446 RVA: 0x002B413C File Offset: 0x002B233C
		public int BindDecorations(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002276 RID: 8822
		// (get) Token: 0x0600A1E7 RID: 41447 RVA: 0x002B417C File Offset: 0x002B237C
		public int BindDecorationsLength
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600A1E8 RID: 41448 RVA: 0x002B41A8 File Offset: 0x002B23A8
		public Span<int> GetBindDecorationsBytes()
		{
			return this.__p.__vector_as_span<int>(16, 4);
		}

		// Token: 0x0600A1E9 RID: 41449 RVA: 0x002B41B8 File Offset: 0x002B23B8
		public int[] GetBindDecorationsArray()
		{
			return this.__p.__vector_as_array<int>(16) ?? Array.Empty<int>();
		}

		// Token: 0x17002277 RID: 8823
		// (get) Token: 0x0600A1EA RID: 41450 RVA: 0x002B41D0 File Offset: 0x002B23D0
		public int ModelId
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17002278 RID: 8824
		// (get) Token: 0x0600A1EB RID: 41451 RVA: 0x002B4210 File Offset: 0x002B2410
		public string StandAnim
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

		// Token: 0x0600A1EC RID: 41452 RVA: 0x002B4248 File Offset: 0x002B2448
		public Span<byte> GetStandAnimBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x0600A1ED RID: 41453 RVA: 0x002B4258 File Offset: 0x002B2458
		public byte[] GetStandAnimArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x17002279 RID: 8825
		// (get) Token: 0x0600A1EE RID: 41454 RVA: 0x002B4270 File Offset: 0x002B2470
		public int QualityId
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return 5;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700227A RID: 8826
		// (get) Token: 0x0600A1EF RID: 41455 RVA: 0x002B42B0 File Offset: 0x002B24B0
		public string Name
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

		// Token: 0x0600A1F0 RID: 41456 RVA: 0x002B42E8 File Offset: 0x002B24E8
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(24, 1);
		}

		// Token: 0x0600A1F1 RID: 41457 RVA: 0x002B42F8 File Offset: 0x002B24F8
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(24) ?? Array.Empty<byte>();
		}

		// Token: 0x1700227B RID: 8827
		// (get) Token: 0x0600A1F2 RID: 41458 RVA: 0x002B4310 File Offset: 0x002B2510
		public string TypeDescription
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

		// Token: 0x0600A1F3 RID: 41459 RVA: 0x002B4348 File Offset: 0x002B2548
		public Span<byte> GetTypeDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(26, 1);
		}

		// Token: 0x0600A1F4 RID: 41460 RVA: 0x002B4358 File Offset: 0x002B2558
		public byte[] GetTypeDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(26) ?? Array.Empty<byte>();
		}

		// Token: 0x1700227C RID: 8828
		// (get) Token: 0x0600A1F5 RID: 41461 RVA: 0x002B4370 File Offset: 0x002B2570
		public string AttributesDescription
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

		// Token: 0x0600A1F6 RID: 41462 RVA: 0x002B43A8 File Offset: 0x002B25A8
		public Span<byte> GetAttributesDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(28, 1);
		}

		// Token: 0x0600A1F7 RID: 41463 RVA: 0x002B43B8 File Offset: 0x002B25B8
		public byte[] GetAttributesDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(28) ?? Array.Empty<byte>();
		}

		// Token: 0x1700227D RID: 8829
		// (get) Token: 0x0600A1F8 RID: 41464 RVA: 0x002B43D0 File Offset: 0x002B25D0
		public string BgDescription
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

		// Token: 0x0600A1F9 RID: 41465 RVA: 0x002B4408 File Offset: 0x002B2608
		public Span<byte> GetBgDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(30, 1);
		}

		// Token: 0x0600A1FA RID: 41466 RVA: 0x002B4418 File Offset: 0x002B2618
		public byte[] GetBgDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(30) ?? Array.Empty<byte>();
		}

		// Token: 0x0600A1FB RID: 41467 RVA: 0x002B4430 File Offset: 0x002B2630
		public int ItemAccess(int j)
		{
			int num = this.__p.__offset(32);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700227E RID: 8830
		// (get) Token: 0x0600A1FC RID: 41468 RVA: 0x002B4470 File Offset: 0x002B2670
		public int ItemAccessLength
		{
			get
			{
				int num = this.__p.__offset(32);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600A1FD RID: 41469 RVA: 0x002B449C File Offset: 0x002B269C
		public Span<int> GetItemAccessBytes()
		{
			return this.__p.__vector_as_span<int>(32, 4);
		}

		// Token: 0x0600A1FE RID: 41470 RVA: 0x002B44AC File Offset: 0x002B26AC
		public int[] GetItemAccessArray()
		{
			return this.__p.__vector_as_array<int>(32) ?? Array.Empty<int>();
		}

		// Token: 0x1700227F RID: 8831
		// (get) Token: 0x0600A1FF RID: 41471 RVA: 0x002B44C4 File Offset: 0x002B26C4
		public string SkinIcon
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

		// Token: 0x0600A200 RID: 41472 RVA: 0x002B44FC File Offset: 0x002B26FC
		public Span<byte> GetSkinIconBytes()
		{
			return this.__p.__vector_as_span<byte>(34, 1);
		}

		// Token: 0x0600A201 RID: 41473 RVA: 0x002B450C File Offset: 0x002B270C
		public byte[] GetSkinIconArray()
		{
			return this.__p.__vector_as_array<byte>(34) ?? Array.Empty<byte>();
		}

		// Token: 0x17002280 RID: 8832
		// (get) Token: 0x0600A202 RID: 41474 RVA: 0x002B4524 File Offset: 0x002B2724
		public string MainIcon
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

		// Token: 0x0600A203 RID: 41475 RVA: 0x002B455C File Offset: 0x002B275C
		public Span<byte> GetMainIconBytes()
		{
			return this.__p.__vector_as_span<byte>(36, 1);
		}

		// Token: 0x0600A204 RID: 41476 RVA: 0x002B456C File Offset: 0x002B276C
		public byte[] GetMainIconArray()
		{
			return this.__p.__vector_as_array<byte>(36) ?? Array.Empty<byte>();
		}

		// Token: 0x17002281 RID: 8833
		// (get) Token: 0x0600A205 RID: 41477 RVA: 0x002B4584 File Offset: 0x002B2784
		public string Icon
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

		// Token: 0x0600A206 RID: 41478 RVA: 0x002B45BC File Offset: 0x002B27BC
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(38, 1);
		}

		// Token: 0x0600A207 RID: 41479 RVA: 0x002B45CC File Offset: 0x002B27CC
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(38) ?? Array.Empty<byte>();
		}

		// Token: 0x17002282 RID: 8834
		// (get) Token: 0x0600A208 RID: 41480 RVA: 0x002B45E4 File Offset: 0x002B27E4
		public string IconBig
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

		// Token: 0x0600A209 RID: 41481 RVA: 0x002B461C File Offset: 0x002B281C
		public Span<byte> GetIconBigBytes()
		{
			return this.__p.__vector_as_span<byte>(40, 1);
		}

		// Token: 0x0600A20A RID: 41482 RVA: 0x002B462C File Offset: 0x002B282C
		public byte[] GetIconBigArray()
		{
			return this.__p.__vector_as_array<byte>(40) ?? Array.Empty<byte>();
		}

		// Token: 0x17002283 RID: 8835
		// (get) Token: 0x0600A20B RID: 41483 RVA: 0x002B4644 File Offset: 0x002B2844
		public string IconMiddle
		{
			get
			{
				int num = this.__p.__offset(42);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600A20C RID: 41484 RVA: 0x002B467C File Offset: 0x002B287C
		public Span<byte> GetIconMiddleBytes()
		{
			return this.__p.__vector_as_span<byte>(42, 1);
		}

		// Token: 0x0600A20D RID: 41485 RVA: 0x002B468C File Offset: 0x002B288C
		public byte[] GetIconMiddleArray()
		{
			return this.__p.__vector_as_array<byte>(42) ?? Array.Empty<byte>();
		}

		// Token: 0x17002284 RID: 8836
		// (get) Token: 0x0600A20E RID: 41486 RVA: 0x002B46A4 File Offset: 0x002B28A4
		public string IconSmall
		{
			get
			{
				int num = this.__p.__offset(44);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600A20F RID: 41487 RVA: 0x002B46DC File Offset: 0x002B28DC
		public Span<byte> GetIconSmallBytes()
		{
			return this.__p.__vector_as_span<byte>(44, 1);
		}

		// Token: 0x0600A210 RID: 41488 RVA: 0x002B46EC File Offset: 0x002B28EC
		public byte[] GetIconSmallArray()
		{
			return this.__p.__vector_as_array<byte>(44) ?? Array.Empty<byte>();
		}

		// Token: 0x17002285 RID: 8837
		// (get) Token: 0x0600A211 RID: 41489 RVA: 0x002B4704 File Offset: 0x002B2904
		public string Mesh
		{
			get
			{
				int num = this.__p.__offset(46);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600A212 RID: 41490 RVA: 0x002B473C File Offset: 0x002B293C
		public Span<byte> GetMeshBytes()
		{
			return this.__p.__vector_as_span<byte>(46, 1);
		}

		// Token: 0x0600A213 RID: 41491 RVA: 0x002B474C File Offset: 0x002B294C
		public byte[] GetMeshArray()
		{
			return this.__p.__vector_as_array<byte>(46) ?? Array.Empty<byte>();
		}

		// Token: 0x17002286 RID: 8838
		// (get) Token: 0x0600A214 RID: 41492 RVA: 0x002B4764 File Offset: 0x002B2964
		public string ObtainedShowDescription
		{
			get
			{
				int num = this.__p.__offset(48);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600A215 RID: 41493 RVA: 0x002B479C File Offset: 0x002B299C
		public Span<byte> GetObtainedShowDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(48, 1);
		}

		// Token: 0x0600A216 RID: 41494 RVA: 0x002B47AC File Offset: 0x002B29AC
		public byte[] GetObtainedShowDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(48) ?? Array.Empty<byte>();
		}

		// Token: 0x17002287 RID: 8839
		// (get) Token: 0x0600A217 RID: 41495 RVA: 0x002B47C4 File Offset: 0x002B29C4
		public bool ShowInBag
		{
			get
			{
				int num = this.__p.__offset(50);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0600A218 RID: 41496 RVA: 0x002B4804 File Offset: 0x002B2A04
		[NullableContext(1)]
		public int[] BindDecorations()
		{
			return this.GetBindDecorationsArray();
		}

		// Token: 0x0600A219 RID: 41497 RVA: 0x002B480C File Offset: 0x002B2A0C
		[NullableContext(1)]
		public IEnumerable<int> BindDecorationsIter()
		{
			MotorSkin.<BindDecorationsIter>d__92 <BindDecorationsIter>d__ = new MotorSkin.<BindDecorationsIter>d__92(-2);
			<BindDecorationsIter>d__.<>3__<>4__this = this;
			return <BindDecorationsIter>d__;
		}

		// Token: 0x0600A21A RID: 41498 RVA: 0x002B4821 File Offset: 0x002B2A21
		[NullableContext(1)]
		public int[] BindSticker()
		{
			return this.GetBindStickerArray();
		}

		// Token: 0x0600A21B RID: 41499 RVA: 0x002B4829 File Offset: 0x002B2A29
		[NullableContext(1)]
		public IEnumerable<int> BindStickerIter()
		{
			MotorSkin.<BindStickerIter>d__94 <BindStickerIter>d__ = new MotorSkin.<BindStickerIter>d__94(-2);
			<BindStickerIter>d__.<>3__<>4__this = this;
			return <BindStickerIter>d__;
		}

		// Token: 0x0600A21C RID: 41500 RVA: 0x002B483E File Offset: 0x002B2A3E
		[NullableContext(1)]
		public int[] ItemAccess()
		{
			return this.GetItemAccessArray();
		}

		// Token: 0x0600A21D RID: 41501 RVA: 0x002B4846 File Offset: 0x002B2A46
		[NullableContext(1)]
		public IEnumerable<int> ItemAccessIter()
		{
			MotorSkin.<ItemAccessIter>d__96 <ItemAccessIter>d__ = new MotorSkin.<ItemAccessIter>d__96(-2);
			<ItemAccessIter>d__.<>3__<>4__this = this;
			return <ItemAccessIter>d__;
		}

		// Token: 0x040054F9 RID: 21753
		private Table __p;
	}
}
