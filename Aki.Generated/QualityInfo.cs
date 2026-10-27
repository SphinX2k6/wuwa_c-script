using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F63 RID: 3939
	public struct QualityInfo : IFlatbufferObject
	{
		// Token: 0x17002B32 RID: 11058
		// (get) Token: 0x0600B40C RID: 46092 RVA: 0x002CCBB5 File Offset: 0x002CADB5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600B40D RID: 46093 RVA: 0x002CCBC2 File Offset: 0x002CADC2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600B40E RID: 46094 RVA: 0x002CCBCC File Offset: 0x002CADCC
		public static QualityInfo GetRootAsQualityInfo(ByteBuffer _bb)
		{
			return QualityInfo.GetRootAsQualityInfo(_bb, default(QualityInfo));
		}

		// Token: 0x0600B40F RID: 46095 RVA: 0x002CCBE8 File Offset: 0x002CADE8
		public static QualityInfo GetRootAsQualityInfo(ByteBuffer _bb, QualityInfo obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600B410 RID: 46096 RVA: 0x002CCC05 File Offset: 0x002CAE05
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600B411 RID: 46097 RVA: 0x002CCC14 File Offset: 0x002CAE14
		public QualityInfo __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002B33 RID: 11059
		// (get) Token: 0x0600B412 RID: 46098 RVA: 0x002CCC24 File Offset: 0x002CAE24
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

		// Token: 0x17002B34 RID: 11060
		// (get) Token: 0x0600B413 RID: 46099 RVA: 0x002CCC60 File Offset: 0x002CAE60
		public string Name
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600B414 RID: 46100 RVA: 0x002CCC97 File Offset: 0x002CAE97
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600B415 RID: 46101 RVA: 0x002CCCA6 File Offset: 0x002CAEA6
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17002B35 RID: 11061
		// (get) Token: 0x0600B416 RID: 46102 RVA: 0x002CCCC0 File Offset: 0x002CAEC0
		public string TextColor
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

		// Token: 0x0600B417 RID: 46103 RVA: 0x002CCCF7 File Offset: 0x002CAEF7
		public Span<byte> GetTextColorBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600B418 RID: 46104 RVA: 0x002CCD06 File Offset: 0x002CAF06
		public byte[] GetTextColorArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17002B36 RID: 11062
		// (get) Token: 0x0600B419 RID: 46105 RVA: 0x002CCD20 File Offset: 0x002CAF20
		public string DropColor
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

		// Token: 0x0600B41A RID: 46106 RVA: 0x002CCD58 File Offset: 0x002CAF58
		public Span<byte> GetDropColorBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600B41B RID: 46107 RVA: 0x002CCD68 File Offset: 0x002CAF68
		public byte[] GetDropColorArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17002B37 RID: 11063
		// (get) Token: 0x0600B41C RID: 46108 RVA: 0x002CCD80 File Offset: 0x002CAF80
		public string TypeADropColor
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

		// Token: 0x0600B41D RID: 46109 RVA: 0x002CCDB8 File Offset: 0x002CAFB8
		public Span<byte> GetTypeADropColorBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600B41E RID: 46110 RVA: 0x002CCDC8 File Offset: 0x002CAFC8
		public byte[] GetTypeADropColorArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17002B38 RID: 11064
		// (get) Token: 0x0600B41F RID: 46111 RVA: 0x002CCDE0 File Offset: 0x002CAFE0
		public string FrameIconColor
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

		// Token: 0x0600B420 RID: 46112 RVA: 0x002CCE18 File Offset: 0x002CB018
		public Span<byte> GetFrameIconColorBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600B421 RID: 46113 RVA: 0x002CCE28 File Offset: 0x002CB028
		public byte[] GetFrameIconColorArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17002B39 RID: 11065
		// (get) Token: 0x0600B422 RID: 46114 RVA: 0x002CCE40 File Offset: 0x002CB040
		public string BackgroundColor
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

		// Token: 0x0600B423 RID: 46115 RVA: 0x002CCE78 File Offset: 0x002CB078
		public Span<byte> GetBackgroundColorBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600B424 RID: 46116 RVA: 0x002CCE88 File Offset: 0x002CB088
		public byte[] GetBackgroundColorArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x17002B3A RID: 11066
		// (get) Token: 0x0600B425 RID: 46117 RVA: 0x002CCEA0 File Offset: 0x002CB0A0
		public string PhantomColor
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

		// Token: 0x0600B426 RID: 46118 RVA: 0x002CCED8 File Offset: 0x002CB0D8
		public Span<byte> GetPhantomColorBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0600B427 RID: 46119 RVA: 0x002CCEE8 File Offset: 0x002CB0E8
		public byte[] GetPhantomColorArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x17002B3B RID: 11067
		// (get) Token: 0x0600B428 RID: 46120 RVA: 0x002CCF00 File Offset: 0x002CB100
		public string InteractionHintColor
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

		// Token: 0x0600B429 RID: 46121 RVA: 0x002CCF38 File Offset: 0x002CB138
		public Span<byte> GetInteractionHintColorBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x0600B42A RID: 46122 RVA: 0x002CCF48 File Offset: 0x002CB148
		public byte[] GetInteractionHintColorArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x17002B3C RID: 11068
		// (get) Token: 0x0600B42B RID: 46123 RVA: 0x002CCF60 File Offset: 0x002CB160
		public string GachaQualityNiagara
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

		// Token: 0x0600B42C RID: 46124 RVA: 0x002CCF98 File Offset: 0x002CB198
		public Span<byte> GetGachaQualityNiagaraBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x0600B42D RID: 46125 RVA: 0x002CCFA8 File Offset: 0x002CB1A8
		public byte[] GetGachaQualityNiagaraArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x17002B3D RID: 11069
		// (get) Token: 0x0600B42E RID: 46126 RVA: 0x002CCFC0 File Offset: 0x002CB1C0
		public string TipQualityTexture
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

		// Token: 0x0600B42F RID: 46127 RVA: 0x002CCFF8 File Offset: 0x002CB1F8
		public Span<byte> GetTipQualityTextureBytes()
		{
			return this.__p.__vector_as_span<byte>(24, 1);
		}

		// Token: 0x0600B430 RID: 46128 RVA: 0x002CD008 File Offset: 0x002CB208
		public byte[] GetTipQualityTextureArray()
		{
			return this.__p.__vector_as_array<byte>(24) ?? Array.Empty<byte>();
		}

		// Token: 0x17002B3E RID: 11070
		// (get) Token: 0x0600B431 RID: 46129 RVA: 0x002CD020 File Offset: 0x002CB220
		public string GachaQualityTexture
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

		// Token: 0x0600B432 RID: 46130 RVA: 0x002CD058 File Offset: 0x002CB258
		public Span<byte> GetGachaQualityTextureBytes()
		{
			return this.__p.__vector_as_span<byte>(26, 1);
		}

		// Token: 0x0600B433 RID: 46131 RVA: 0x002CD068 File Offset: 0x002CB268
		public byte[] GetGachaQualityTextureArray()
		{
			return this.__p.__vector_as_array<byte>(26) ?? Array.Empty<byte>();
		}

		// Token: 0x17002B3F RID: 11071
		// (get) Token: 0x0600B434 RID: 46132 RVA: 0x002CD080 File Offset: 0x002CB280
		public string GachaBgTexture
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

		// Token: 0x0600B435 RID: 46133 RVA: 0x002CD0B8 File Offset: 0x002CB2B8
		public Span<byte> GetGachaBgTextureBytes()
		{
			return this.__p.__vector_as_span<byte>(28, 1);
		}

		// Token: 0x0600B436 RID: 46134 RVA: 0x002CD0C8 File Offset: 0x002CB2C8
		public byte[] GetGachaBgTextureArray()
		{
			return this.__p.__vector_as_array<byte>(28) ?? Array.Empty<byte>();
		}

		// Token: 0x17002B40 RID: 11072
		// (get) Token: 0x0600B437 RID: 46135 RVA: 0x002CD0E0 File Offset: 0x002CB2E0
		public string BackgroundSprite
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

		// Token: 0x0600B438 RID: 46136 RVA: 0x002CD118 File Offset: 0x002CB318
		public Span<byte> GetBackgroundSpriteBytes()
		{
			return this.__p.__vector_as_span<byte>(30, 1);
		}

		// Token: 0x0600B439 RID: 46137 RVA: 0x002CD128 File Offset: 0x002CB328
		public byte[] GetBackgroundSpriteArray()
		{
			return this.__p.__vector_as_array<byte>(30) ?? Array.Empty<byte>();
		}

		// Token: 0x17002B41 RID: 11073
		// (get) Token: 0x0600B43A RID: 46138 RVA: 0x002CD140 File Offset: 0x002CB340
		public string VerticalGradientSprite
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

		// Token: 0x0600B43B RID: 46139 RVA: 0x002CD178 File Offset: 0x002CB378
		public Span<byte> GetVerticalGradientSpriteBytes()
		{
			return this.__p.__vector_as_span<byte>(32, 1);
		}

		// Token: 0x0600B43C RID: 46140 RVA: 0x002CD188 File Offset: 0x002CB388
		public byte[] GetVerticalGradientSpriteArray()
		{
			return this.__p.__vector_as_array<byte>(32) ?? Array.Empty<byte>();
		}

		// Token: 0x17002B42 RID: 11074
		// (get) Token: 0x0600B43D RID: 46141 RVA: 0x002CD1A0 File Offset: 0x002CB3A0
		public string TipsSprite
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

		// Token: 0x0600B43E RID: 46142 RVA: 0x002CD1D8 File Offset: 0x002CB3D8
		public Span<byte> GetTipsSpriteBytes()
		{
			return this.__p.__vector_as_span<byte>(34, 1);
		}

		// Token: 0x0600B43F RID: 46143 RVA: 0x002CD1E8 File Offset: 0x002CB3E8
		public byte[] GetTipsSpriteArray()
		{
			return this.__p.__vector_as_array<byte>(34) ?? Array.Empty<byte>();
		}

		// Token: 0x17002B43 RID: 11075
		// (get) Token: 0x0600B440 RID: 46144 RVA: 0x002CD200 File Offset: 0x002CB400
		public string SpecialEffects
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

		// Token: 0x0600B441 RID: 46145 RVA: 0x002CD238 File Offset: 0x002CB438
		public Span<byte> GetSpecialEffectsBytes()
		{
			return this.__p.__vector_as_span<byte>(36, 1);
		}

		// Token: 0x0600B442 RID: 46146 RVA: 0x002CD248 File Offset: 0x002CB448
		public byte[] GetSpecialEffectsArray()
		{
			return this.__p.__vector_as_array<byte>(36) ?? Array.Empty<byte>();
		}

		// Token: 0x17002B44 RID: 11076
		// (get) Token: 0x0600B443 RID: 46147 RVA: 0x002CD260 File Offset: 0x002CB460
		public string DissipateEffects
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

		// Token: 0x0600B444 RID: 46148 RVA: 0x002CD298 File Offset: 0x002CB498
		public Span<byte> GetDissipateEffectsBytes()
		{
			return this.__p.__vector_as_span<byte>(38, 1);
		}

		// Token: 0x0600B445 RID: 46149 RVA: 0x002CD2A8 File Offset: 0x002CB4A8
		public byte[] GetDissipateEffectsArray()
		{
			return this.__p.__vector_as_array<byte>(38) ?? Array.Empty<byte>();
		}

		// Token: 0x17002B45 RID: 11077
		// (get) Token: 0x0600B446 RID: 46150 RVA: 0x002CD2C0 File Offset: 0x002CB4C0
		public string NewItemGetEffects
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

		// Token: 0x0600B447 RID: 46151 RVA: 0x002CD2F8 File Offset: 0x002CB4F8
		public Span<byte> GetNewItemGetEffectsBytes()
		{
			return this.__p.__vector_as_span<byte>(40, 1);
		}

		// Token: 0x0600B448 RID: 46152 RVA: 0x002CD308 File Offset: 0x002CB508
		public byte[] GetNewItemGetEffectsArray()
		{
			return this.__p.__vector_as_array<byte>(40) ?? Array.Empty<byte>();
		}

		// Token: 0x17002B46 RID: 11078
		// (get) Token: 0x0600B449 RID: 46153 RVA: 0x002CD320 File Offset: 0x002CB520
		public string ConsumeFilterText
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

		// Token: 0x0600B44A RID: 46154 RVA: 0x002CD358 File Offset: 0x002CB558
		public Span<byte> GetConsumeFilterTextBytes()
		{
			return this.__p.__vector_as_span<byte>(42, 1);
		}

		// Token: 0x0600B44B RID: 46155 RVA: 0x002CD368 File Offset: 0x002CB568
		public byte[] GetConsumeFilterTextArray()
		{
			return this.__p.__vector_as_array<byte>(42) ?? Array.Empty<byte>();
		}

		// Token: 0x17002B47 RID: 11079
		// (get) Token: 0x0600B44C RID: 46156 RVA: 0x002CD380 File Offset: 0x002CB580
		public string PayShopTexture
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

		// Token: 0x0600B44D RID: 46157 RVA: 0x002CD3B8 File Offset: 0x002CB5B8
		public Span<byte> GetPayShopTextureBytes()
		{
			return this.__p.__vector_as_span<byte>(44, 1);
		}

		// Token: 0x0600B44E RID: 46158 RVA: 0x002CD3C8 File Offset: 0x002CB5C8
		public byte[] GetPayShopTextureArray()
		{
			return this.__p.__vector_as_array<byte>(44) ?? Array.Empty<byte>();
		}

		// Token: 0x17002B48 RID: 11080
		// (get) Token: 0x0600B44F RID: 46159 RVA: 0x002CD3E0 File Offset: 0x002CB5E0
		public string NewPayShopTexture
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

		// Token: 0x0600B450 RID: 46160 RVA: 0x002CD418 File Offset: 0x002CB618
		public Span<byte> GetNewPayShopTextureBytes()
		{
			return this.__p.__vector_as_span<byte>(46, 1);
		}

		// Token: 0x0600B451 RID: 46161 RVA: 0x002CD428 File Offset: 0x002CB628
		public byte[] GetNewPayShopTextureArray()
		{
			return this.__p.__vector_as_array<byte>(46) ?? Array.Empty<byte>();
		}

		// Token: 0x17002B49 RID: 11081
		// (get) Token: 0x0600B452 RID: 46162 RVA: 0x002CD440 File Offset: 0x002CB640
		public string PayShopQualitySprite
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

		// Token: 0x0600B453 RID: 46163 RVA: 0x002CD478 File Offset: 0x002CB678
		public Span<byte> GetPayShopQualitySpriteBytes()
		{
			return this.__p.__vector_as_span<byte>(48, 1);
		}

		// Token: 0x0600B454 RID: 46164 RVA: 0x002CD488 File Offset: 0x002CB688
		public byte[] GetPayShopQualitySpriteArray()
		{
			return this.__p.__vector_as_array<byte>(48) ?? Array.Empty<byte>();
		}

		// Token: 0x17002B4A RID: 11082
		// (get) Token: 0x0600B455 RID: 46165 RVA: 0x002CD4A0 File Offset: 0x002CB6A0
		public string PhantomSprite
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

		// Token: 0x0600B456 RID: 46166 RVA: 0x002CD4D8 File Offset: 0x002CB6D8
		public Span<byte> GetPhantomSpriteBytes()
		{
			return this.__p.__vector_as_span<byte>(50, 1);
		}

		// Token: 0x0600B457 RID: 46167 RVA: 0x002CD4E8 File Offset: 0x002CB6E8
		public byte[] GetPhantomSpriteArray()
		{
			return this.__p.__vector_as_array<byte>(50) ?? Array.Empty<byte>();
		}

		// Token: 0x17002B4B RID: 11083
		// (get) Token: 0x0600B458 RID: 46168 RVA: 0x002CD500 File Offset: 0x002CB700
		public string DropItemQualityNiagaraPath
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

		// Token: 0x0600B459 RID: 46169 RVA: 0x002CD538 File Offset: 0x002CB738
		public Span<byte> GetDropItemQualityNiagaraPathBytes()
		{
			return this.__p.__vector_as_span<byte>(52, 1);
		}

		// Token: 0x0600B45A RID: 46170 RVA: 0x002CD548 File Offset: 0x002CB748
		public byte[] GetDropItemQualityNiagaraPathArray()
		{
			return this.__p.__vector_as_array<byte>(52) ?? Array.Empty<byte>();
		}

		// Token: 0x17002B4C RID: 11084
		// (get) Token: 0x0600B45B RID: 46171 RVA: 0x002CD560 File Offset: 0x002CB760
		public string MediumItemGridQualitySpritePath
		{
			get
			{
				int num = this.__p.__offset(54);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600B45C RID: 46172 RVA: 0x002CD598 File Offset: 0x002CB798
		public Span<byte> GetMediumItemGridQualitySpritePathBytes()
		{
			return this.__p.__vector_as_span<byte>(54, 1);
		}

		// Token: 0x0600B45D RID: 46173 RVA: 0x002CD5A8 File Offset: 0x002CB7A8
		public byte[] GetMediumItemGridQualitySpritePathArray()
		{
			return this.__p.__vector_as_array<byte>(54) ?? Array.Empty<byte>();
		}

		// Token: 0x17002B4D RID: 11085
		// (get) Token: 0x0600B45E RID: 46174 RVA: 0x002CD5C0 File Offset: 0x002CB7C0
		public string TypeAGridQualitySpritePath
		{
			get
			{
				int num = this.__p.__offset(56);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600B45F RID: 46175 RVA: 0x002CD5F8 File Offset: 0x002CB7F8
		public Span<byte> GetTypeAGridQualitySpritePathBytes()
		{
			return this.__p.__vector_as_span<byte>(56, 1);
		}

		// Token: 0x0600B460 RID: 46176 RVA: 0x002CD608 File Offset: 0x002CB808
		public byte[] GetTypeAGridQualitySpritePathArray()
		{
			return this.__p.__vector_as_array<byte>(56) ?? Array.Empty<byte>();
		}

		// Token: 0x17002B4E RID: 11086
		// (get) Token: 0x0600B461 RID: 46177 RVA: 0x002CD620 File Offset: 0x002CB820
		public string QualityColor
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

		// Token: 0x0600B462 RID: 46178 RVA: 0x002CD658 File Offset: 0x002CB858
		public Span<byte> GetQualityColorBytes()
		{
			return this.__p.__vector_as_span<byte>(58, 1);
		}

		// Token: 0x0600B463 RID: 46179 RVA: 0x002CD668 File Offset: 0x002CB868
		public byte[] GetQualityColorArray()
		{
			return this.__p.__vector_as_array<byte>(58) ?? Array.Empty<byte>();
		}

		// Token: 0x17002B4F RID: 11087
		// (get) Token: 0x0600B464 RID: 46180 RVA: 0x002CD680 File Offset: 0x002CB880
		public string RouletteTipsQualityTexPath
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

		// Token: 0x0600B465 RID: 46181 RVA: 0x002CD6B8 File Offset: 0x002CB8B8
		public Span<byte> GetRouletteTipsQualityTexPathBytes()
		{
			return this.__p.__vector_as_span<byte>(60, 1);
		}

		// Token: 0x0600B466 RID: 46182 RVA: 0x002CD6C8 File Offset: 0x002CB8C8
		public byte[] GetRouletteTipsQualityTexPathArray()
		{
			return this.__p.__vector_as_array<byte>(60) ?? Array.Empty<byte>();
		}

		// Token: 0x17002B50 RID: 11088
		// (get) Token: 0x0600B467 RID: 46183 RVA: 0x002CD6E0 File Offset: 0x002CB8E0
		public string AcquireQualityTexPath
		{
			get
			{
				int num = this.__p.__offset(62);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600B468 RID: 46184 RVA: 0x002CD718 File Offset: 0x002CB918
		public Span<byte> GetAcquireQualityTexPathBytes()
		{
			return this.__p.__vector_as_span<byte>(62, 1);
		}

		// Token: 0x0600B469 RID: 46185 RVA: 0x002CD728 File Offset: 0x002CB928
		public byte[] GetAcquireQualityTexPathArray()
		{
			return this.__p.__vector_as_array<byte>(62) ?? Array.Empty<byte>();
		}

		// Token: 0x17002B51 RID: 11089
		// (get) Token: 0x0600B46A RID: 46186 RVA: 0x002CD740 File Offset: 0x002CB940
		public string AcquireNewItemQualityTexPath
		{
			get
			{
				int num = this.__p.__offset(64);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600B46B RID: 46187 RVA: 0x002CD778 File Offset: 0x002CB978
		public Span<byte> GetAcquireNewItemQualityTexPathBytes()
		{
			return this.__p.__vector_as_span<byte>(64, 1);
		}

		// Token: 0x0600B46C RID: 46188 RVA: 0x002CD788 File Offset: 0x002CB988
		public byte[] GetAcquireNewItemQualityTexPathArray()
		{
			return this.__p.__vector_as_array<byte>(64) ?? Array.Empty<byte>();
		}

		// Token: 0x17002B52 RID: 11090
		// (get) Token: 0x0600B46D RID: 46189 RVA: 0x002CD7A0 File Offset: 0x002CB9A0
		public string AcquireQualitySpritePath
		{
			get
			{
				int num = this.__p.__offset(66);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600B46E RID: 46190 RVA: 0x002CD7D8 File Offset: 0x002CB9D8
		public Span<byte> GetAcquireQualitySpritePathBytes()
		{
			return this.__p.__vector_as_span<byte>(66, 1);
		}

		// Token: 0x0600B46F RID: 46191 RVA: 0x002CD7E8 File Offset: 0x002CB9E8
		public byte[] GetAcquireQualitySpritePathArray()
		{
			return this.__p.__vector_as_array<byte>(66) ?? Array.Empty<byte>();
		}

		// Token: 0x17002B53 RID: 11091
		// (get) Token: 0x0600B470 RID: 46192 RVA: 0x002CD800 File Offset: 0x002CBA00
		public string FilterIconPath
		{
			get
			{
				int num = this.__p.__offset(68);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600B471 RID: 46193 RVA: 0x002CD838 File Offset: 0x002CBA38
		public Span<byte> GetFilterIconPathBytes()
		{
			return this.__p.__vector_as_span<byte>(68, 1);
		}

		// Token: 0x0600B472 RID: 46194 RVA: 0x002CD848 File Offset: 0x002CBA48
		public byte[] GetFilterIconPathArray()
		{
			return this.__p.__vector_as_array<byte>(68) ?? Array.Empty<byte>();
		}

		// Token: 0x17002B54 RID: 11092
		// (get) Token: 0x0600B473 RID: 46195 RVA: 0x002CD860 File Offset: 0x002CBA60
		public string CalabashLevelUpViewShowText
		{
			get
			{
				int num = this.__p.__offset(70);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600B474 RID: 46196 RVA: 0x002CD898 File Offset: 0x002CBA98
		public Span<byte> GetCalabashLevelUpViewShowTextBytes()
		{
			return this.__p.__vector_as_span<byte>(70, 1);
		}

		// Token: 0x0600B475 RID: 46197 RVA: 0x002CD8A8 File Offset: 0x002CBAA8
		public byte[] GetCalabashLevelUpViewShowTextArray()
		{
			return this.__p.__vector_as_array<byte>(70) ?? Array.Empty<byte>();
		}

		// Token: 0x17002B55 RID: 11093
		// (get) Token: 0x0600B476 RID: 46198 RVA: 0x002CD8C0 File Offset: 0x002CBAC0
		public string UnlockVisionQuality
		{
			get
			{
				int num = this.__p.__offset(72);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600B477 RID: 46199 RVA: 0x002CD8F8 File Offset: 0x002CBAF8
		public Span<byte> GetUnlockVisionQualityBytes()
		{
			return this.__p.__vector_as_span<byte>(72, 1);
		}

		// Token: 0x0600B478 RID: 46200 RVA: 0x002CD908 File Offset: 0x002CBB08
		public byte[] GetUnlockVisionQualityArray()
		{
			return this.__p.__vector_as_array<byte>(72) ?? Array.Empty<byte>();
		}

		// Token: 0x17002B56 RID: 11094
		// (get) Token: 0x0600B479 RID: 46201 RVA: 0x002CD920 File Offset: 0x002CBB20
		public string UnlockVisionQualityColor
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

		// Token: 0x0600B47A RID: 46202 RVA: 0x002CD958 File Offset: 0x002CBB58
		public Span<byte> GetUnlockVisionQualityColorBytes()
		{
			return this.__p.__vector_as_span<byte>(74, 1);
		}

		// Token: 0x0600B47B RID: 46203 RVA: 0x002CD968 File Offset: 0x002CBB68
		public byte[] GetUnlockVisionQualityColorArray()
		{
			return this.__p.__vector_as_array<byte>(74) ?? Array.Empty<byte>();
		}

		// Token: 0x17002B57 RID: 11095
		// (get) Token: 0x0600B47C RID: 46204 RVA: 0x002CD980 File Offset: 0x002CBB80
		public int TrainingWeight
		{
			get
			{
				int num = this.__p.__offset(76);
				if (num == 0)
				{
					return 1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17002B58 RID: 11096
		// (get) Token: 0x0600B47D RID: 46205 RVA: 0x002CD9C0 File Offset: 0x002CBBC0
		public string RoleTrialQualityColor
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

		// Token: 0x0600B47E RID: 46206 RVA: 0x002CD9F8 File Offset: 0x002CBBF8
		public Span<byte> GetRoleTrialQualityColorBytes()
		{
			return this.__p.__vector_as_span<byte>(78, 1);
		}

		// Token: 0x0600B47F RID: 46207 RVA: 0x002CDA08 File Offset: 0x002CBC08
		public byte[] GetRoleTrialQualityColorArray()
		{
			return this.__p.__vector_as_array<byte>(78) ?? Array.Empty<byte>();
		}

		// Token: 0x17002B59 RID: 11097
		// (get) Token: 0x0600B480 RID: 46208 RVA: 0x002CDA20 File Offset: 0x002CBC20
		public string SkinQuality
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

		// Token: 0x0600B481 RID: 46209 RVA: 0x002CDA58 File Offset: 0x002CBC58
		public Span<byte> GetSkinQualityBytes()
		{
			return this.__p.__vector_as_span<byte>(80, 1);
		}

		// Token: 0x0600B482 RID: 46210 RVA: 0x002CDA68 File Offset: 0x002CBC68
		public byte[] GetSkinQualityArray()
		{
			return this.__p.__vector_as_array<byte>(80) ?? Array.Empty<byte>();
		}

		// Token: 0x17002B5A RID: 11098
		// (get) Token: 0x0600B483 RID: 46211 RVA: 0x002CDA80 File Offset: 0x002CBC80
		public string SkinQualityItemA
		{
			get
			{
				int num = this.__p.__offset(82);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600B484 RID: 46212 RVA: 0x002CDAB8 File Offset: 0x002CBCB8
		public Span<byte> GetSkinQualityItemABytes()
		{
			return this.__p.__vector_as_span<byte>(82, 1);
		}

		// Token: 0x0600B485 RID: 46213 RVA: 0x002CDAC8 File Offset: 0x002CBCC8
		public byte[] GetSkinQualityItemAArray()
		{
			return this.__p.__vector_as_array<byte>(82) ?? Array.Empty<byte>();
		}

		// Token: 0x17002B5B RID: 11099
		// (get) Token: 0x0600B486 RID: 46214 RVA: 0x002CDAE0 File Offset: 0x002CBCE0
		public string SkinItemColor
		{
			get
			{
				int num = this.__p.__offset(84);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600B487 RID: 46215 RVA: 0x002CDB18 File Offset: 0x002CBD18
		public Span<byte> GetSkinItemColorBytes()
		{
			return this.__p.__vector_as_span<byte>(84, 1);
		}

		// Token: 0x0600B488 RID: 46216 RVA: 0x002CDB28 File Offset: 0x002CBD28
		public byte[] GetSkinItemColorArray()
		{
			return this.__p.__vector_as_array<byte>(84) ?? Array.Empty<byte>();
		}

		// Token: 0x17002B5C RID: 11100
		// (get) Token: 0x0600B489 RID: 46217 RVA: 0x002CDB40 File Offset: 0x002CBD40
		public string SkinItemBg
		{
			get
			{
				int num = this.__p.__offset(86);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600B48A RID: 46218 RVA: 0x002CDB78 File Offset: 0x002CBD78
		public Span<byte> GetSkinItemBgBytes()
		{
			return this.__p.__vector_as_span<byte>(86, 1);
		}

		// Token: 0x0600B48B RID: 46219 RVA: 0x002CDB88 File Offset: 0x002CBD88
		public byte[] GetSkinItemBgArray()
		{
			return this.__p.__vector_as_array<byte>(86) ?? Array.Empty<byte>();
		}

		// Token: 0x17002B5D RID: 11101
		// (get) Token: 0x0600B48C RID: 46220 RVA: 0x002CDBA0 File Offset: 0x002CBDA0
		public string RoleSkinQualityBg
		{
			get
			{
				int num = this.__p.__offset(88);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600B48D RID: 46221 RVA: 0x002CDBD8 File Offset: 0x002CBDD8
		public Span<byte> GetRoleSkinQualityBgBytes()
		{
			return this.__p.__vector_as_span<byte>(88, 1);
		}

		// Token: 0x0600B48E RID: 46222 RVA: 0x002CDBE8 File Offset: 0x002CBDE8
		public byte[] GetRoleSkinQualityBgArray()
		{
			return this.__p.__vector_as_array<byte>(88) ?? Array.Empty<byte>();
		}

		// Token: 0x17002B5E RID: 11102
		// (get) Token: 0x0600B48F RID: 46223 RVA: 0x002CDC00 File Offset: 0x002CBE00
		public string WeaponSkinQualityBg
		{
			get
			{
				int num = this.__p.__offset(90);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600B490 RID: 46224 RVA: 0x002CDC38 File Offset: 0x002CBE38
		public Span<byte> GetWeaponSkinQualityBgBytes()
		{
			return this.__p.__vector_as_span<byte>(90, 1);
		}

		// Token: 0x0600B491 RID: 46225 RVA: 0x002CDC48 File Offset: 0x002CBE48
		public byte[] GetWeaponSkinQualityBgArray()
		{
			return this.__p.__vector_as_array<byte>(90) ?? Array.Empty<byte>();
		}

		// Token: 0x17002B5F RID: 11103
		// (get) Token: 0x0600B492 RID: 46226 RVA: 0x002CDC60 File Offset: 0x002CBE60
		public string ComposeQualityBg
		{
			get
			{
				int num = this.__p.__offset(92);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600B493 RID: 46227 RVA: 0x002CDC98 File Offset: 0x002CBE98
		public Span<byte> GetComposeQualityBgBytes()
		{
			return this.__p.__vector_as_span<byte>(92, 1);
		}

		// Token: 0x0600B494 RID: 46228 RVA: 0x002CDCA8 File Offset: 0x002CBEA8
		public byte[] GetComposeQualityBgArray()
		{
			return this.__p.__vector_as_array<byte>(92) ?? Array.Empty<byte>();
		}

		// Token: 0x17002B60 RID: 11104
		// (get) Token: 0x0600B495 RID: 46229 RVA: 0x002CDCC0 File Offset: 0x002CBEC0
		public string PayShopQualityTexture
		{
			get
			{
				int num = this.__p.__offset(94);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600B496 RID: 46230 RVA: 0x002CDCF8 File Offset: 0x002CBEF8
		public Span<byte> GetPayShopQualityTextureBytes()
		{
			return this.__p.__vector_as_span<byte>(94, 1);
		}

		// Token: 0x0600B497 RID: 46231 RVA: 0x002CDD08 File Offset: 0x002CBF08
		public byte[] GetPayShopQualityTextureArray()
		{
			return this.__p.__vector_as_array<byte>(94) ?? Array.Empty<byte>();
		}

		// Token: 0x17002B61 RID: 11105
		// (get) Token: 0x0600B498 RID: 46232 RVA: 0x002CDD20 File Offset: 0x002CBF20
		public string PayShopQualityLightTexture
		{
			get
			{
				int num = this.__p.__offset(96);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600B499 RID: 46233 RVA: 0x002CDD58 File Offset: 0x002CBF58
		public Span<byte> GetPayShopQualityLightTextureBytes()
		{
			return this.__p.__vector_as_span<byte>(96, 1);
		}

		// Token: 0x0600B49A RID: 46234 RVA: 0x002CDD68 File Offset: 0x002CBF68
		public byte[] GetPayShopQualityLightTextureArray()
		{
			return this.__p.__vector_as_array<byte>(96) ?? Array.Empty<byte>();
		}

		// Token: 0x17002B62 RID: 11106
		// (get) Token: 0x0600B49B RID: 46235 RVA: 0x002CDD80 File Offset: 0x002CBF80
		public string PayShopLineColor
		{
			get
			{
				int num = this.__p.__offset(98);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600B49C RID: 46236 RVA: 0x002CDDB8 File Offset: 0x002CBFB8
		public Span<byte> GetPayShopLineColorBytes()
		{
			return this.__p.__vector_as_span<byte>(98, 1);
		}

		// Token: 0x0600B49D RID: 46237 RVA: 0x002CDDC8 File Offset: 0x002CBFC8
		public byte[] GetPayShopLineColorArray()
		{
			return this.__p.__vector_as_array<byte>(98) ?? Array.Empty<byte>();
		}

		// Token: 0x17002B63 RID: 11107
		// (get) Token: 0x0600B49E RID: 46238 RVA: 0x002CDDE0 File Offset: 0x002CBFE0
		public string VisionGridQualitySpritePath
		{
			get
			{
				int num = this.__p.__offset(100);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600B49F RID: 46239 RVA: 0x002CDE18 File Offset: 0x002CC018
		public Span<byte> GetVisionGridQualitySpritePathBytes()
		{
			return this.__p.__vector_as_span<byte>(100, 1);
		}

		// Token: 0x0600B4A0 RID: 46240 RVA: 0x002CDE28 File Offset: 0x002CC028
		public byte[] GetVisionGridQualitySpritePathArray()
		{
			return this.__p.__vector_as_array<byte>(100) ?? Array.Empty<byte>();
		}

		// Token: 0x17002B64 RID: 11108
		// (get) Token: 0x0600B4A1 RID: 46241 RVA: 0x002CDE40 File Offset: 0x002CC040
		public string PayShopItemQualityTexture
		{
			get
			{
				int num = this.__p.__offset(102);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600B4A2 RID: 46242 RVA: 0x002CDE78 File Offset: 0x002CC078
		public Span<byte> GetPayShopItemQualityTextureBytes()
		{
			return this.__p.__vector_as_span<byte>(102, 1);
		}

		// Token: 0x0600B4A3 RID: 46243 RVA: 0x002CDE88 File Offset: 0x002CC088
		public byte[] GetPayShopItemQualityTextureArray()
		{
			return this.__p.__vector_as_array<byte>(102) ?? Array.Empty<byte>();
		}

		// Token: 0x17002B65 RID: 11109
		// (get) Token: 0x0600B4A4 RID: 46244 RVA: 0x002CDEA0 File Offset: 0x002CC0A0
		public string PayShopItemQualityLightTexture
		{
			get
			{
				int num = this.__p.__offset(104);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600B4A5 RID: 46245 RVA: 0x002CDED8 File Offset: 0x002CC0D8
		public Span<byte> GetPayShopItemQualityLightTextureBytes()
		{
			return this.__p.__vector_as_span<byte>(104, 1);
		}

		// Token: 0x0600B4A6 RID: 46246 RVA: 0x002CDEE8 File Offset: 0x002CC0E8
		public byte[] GetPayShopItemQualityLightTextureArray()
		{
			return this.__p.__vector_as_array<byte>(104) ?? Array.Empty<byte>();
		}

		// Token: 0x17002B66 RID: 11110
		// (get) Token: 0x0600B4A7 RID: 46247 RVA: 0x002CDF00 File Offset: 0x002CC100
		public string PayShopItemLineColor
		{
			get
			{
				int num = this.__p.__offset(106);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600B4A8 RID: 46248 RVA: 0x002CDF38 File Offset: 0x002CC138
		public Span<byte> GetPayShopItemLineColorBytes()
		{
			return this.__p.__vector_as_span<byte>(106, 1);
		}

		// Token: 0x0600B4A9 RID: 46249 RVA: 0x002CDF48 File Offset: 0x002CC148
		public byte[] GetPayShopItemLineColorArray()
		{
			return this.__p.__vector_as_array<byte>(106) ?? Array.Empty<byte>();
		}

		// Token: 0x17002B67 RID: 11111
		// (get) Token: 0x0600B4AA RID: 46250 RVA: 0x002CDF60 File Offset: 0x002CC160
		public string VisionNameColor
		{
			get
			{
				int num = this.__p.__offset(108);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600B4AB RID: 46251 RVA: 0x002CDF98 File Offset: 0x002CC198
		public Span<byte> GetVisionNameColorBytes()
		{
			return this.__p.__vector_as_span<byte>(108, 1);
		}

		// Token: 0x0600B4AC RID: 46252 RVA: 0x002CDFA8 File Offset: 0x002CC1A8
		public byte[] GetVisionNameColorArray()
		{
			return this.__p.__vector_as_array<byte>(108) ?? Array.Empty<byte>();
		}

		// Token: 0x17002B68 RID: 11112
		// (get) Token: 0x0600B4AD RID: 46253 RVA: 0x002CDFC0 File Offset: 0x002CC1C0
		public string VisionGetTipsBgPath
		{
			get
			{
				int num = this.__p.__offset(110);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600B4AE RID: 46254 RVA: 0x002CDFF8 File Offset: 0x002CC1F8
		public Span<byte> GetVisionGetTipsBgPathBytes()
		{
			return this.__p.__vector_as_span<byte>(110, 1);
		}

		// Token: 0x0600B4AF RID: 46255 RVA: 0x002CE008 File Offset: 0x002CC208
		public byte[] GetVisionGetTipsBgPathArray()
		{
			return this.__p.__vector_as_array<byte>(110) ?? Array.Empty<byte>();
		}

		// Token: 0x17002B69 RID: 11113
		// (get) Token: 0x0600B4B0 RID: 46256 RVA: 0x002CE020 File Offset: 0x002CC220
		public string ItemTipsEffectColor
		{
			get
			{
				int num = this.__p.__offset(112);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600B4B1 RID: 46257 RVA: 0x002CE058 File Offset: 0x002CC258
		public Span<byte> GetItemTipsEffectColorBytes()
		{
			return this.__p.__vector_as_span<byte>(112, 1);
		}

		// Token: 0x0600B4B2 RID: 46258 RVA: 0x002CE068 File Offset: 0x002CC268
		public byte[] GetItemTipsEffectColorArray()
		{
			return this.__p.__vector_as_array<byte>(112) ?? Array.Empty<byte>();
		}

		// Token: 0x17002B6A RID: 11114
		// (get) Token: 0x0600B4B3 RID: 46259 RVA: 0x002CE080 File Offset: 0x002CC280
		public string TypeAItemTipsEffectColor
		{
			get
			{
				int num = this.__p.__offset(114);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600B4B4 RID: 46260 RVA: 0x002CE0B8 File Offset: 0x002CC2B8
		public Span<byte> GetTypeAItemTipsEffectColorBytes()
		{
			return this.__p.__vector_as_span<byte>(114, 1);
		}

		// Token: 0x0600B4B5 RID: 46261 RVA: 0x002CE0C8 File Offset: 0x002CC2C8
		public byte[] GetTypeAItemTipsEffectColorArray()
		{
			return this.__p.__vector_as_array<byte>(114) ?? Array.Empty<byte>();
		}

		// Token: 0x17002B6B RID: 11115
		// (get) Token: 0x0600B4B6 RID: 46262 RVA: 0x002CE0E0 File Offset: 0x002CC2E0
		public string TextureAcquireFlow
		{
			get
			{
				int num = this.__p.__offset(116);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600B4B7 RID: 46263 RVA: 0x002CE118 File Offset: 0x002CC318
		public Span<byte> GetTextureAcquireFlowBytes()
		{
			return this.__p.__vector_as_span<byte>(116, 1);
		}

		// Token: 0x0600B4B8 RID: 46264 RVA: 0x002CE128 File Offset: 0x002CC328
		public byte[] GetTextureAcquireFlowArray()
		{
			return this.__p.__vector_as_array<byte>(116) ?? Array.Empty<byte>();
		}

		// Token: 0x17002B6C RID: 11116
		// (get) Token: 0x0600B4B9 RID: 46265 RVA: 0x002CE140 File Offset: 0x002CC340
		public string TextureAcquireBg
		{
			get
			{
				int num = this.__p.__offset(118);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600B4BA RID: 46266 RVA: 0x002CE178 File Offset: 0x002CC378
		public Span<byte> GetTextureAcquireBgBytes()
		{
			return this.__p.__vector_as_span<byte>(118, 1);
		}

		// Token: 0x0600B4BB RID: 46267 RVA: 0x002CE188 File Offset: 0x002CC388
		public byte[] GetTextureAcquireBgArray()
		{
			return this.__p.__vector_as_array<byte>(118) ?? Array.Empty<byte>();
		}

		// Token: 0x17002B6D RID: 11117
		// (get) Token: 0x0600B4BC RID: 46268 RVA: 0x002CE1A0 File Offset: 0x002CC3A0
		public string TextureVisionQuailtyFlow
		{
			get
			{
				int num = this.__p.__offset(120);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600B4BD RID: 46269 RVA: 0x002CE1D8 File Offset: 0x002CC3D8
		public Span<byte> GetTextureVisionQuailtyFlowBytes()
		{
			return this.__p.__vector_as_span<byte>(120, 1);
		}

		// Token: 0x0600B4BE RID: 46270 RVA: 0x002CE1E8 File Offset: 0x002CC3E8
		public byte[] GetTextureVisionQuailtyFlowArray()
		{
			return this.__p.__vector_as_array<byte>(120) ?? Array.Empty<byte>();
		}

		// Token: 0x17002B6E RID: 11118
		// (get) Token: 0x0600B4BF RID: 46271 RVA: 0x002CE200 File Offset: 0x002CC400
		public string TextureVisionQuailtyBg
		{
			get
			{
				int num = this.__p.__offset(122);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600B4C0 RID: 46272 RVA: 0x002CE238 File Offset: 0x002CC438
		public Span<byte> GetTextureVisionQuailtyBgBytes()
		{
			return this.__p.__vector_as_span<byte>(122, 1);
		}

		// Token: 0x0600B4C1 RID: 46273 RVA: 0x002CE248 File Offset: 0x002CC448
		public byte[] GetTextureVisionQuailtyBgArray()
		{
			return this.__p.__vector_as_array<byte>(122) ?? Array.Empty<byte>();
		}

		// Token: 0x04005031 RID: 20529
		private Table __p;
	}
}
