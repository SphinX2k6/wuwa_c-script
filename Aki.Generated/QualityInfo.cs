using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200104A RID: 4170
	public struct QualityInfo : IFlatbufferObject
	{
		// Token: 0x17002BAA RID: 11178
		// (get) Token: 0x0600BA49 RID: 47689 RVA: 0x002E9869 File Offset: 0x002E7A69
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600BA4A RID: 47690 RVA: 0x002E9876 File Offset: 0x002E7A76
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600BA4B RID: 47691 RVA: 0x002E9880 File Offset: 0x002E7A80
		public static QualityInfo GetRootAsQualityInfo(ByteBuffer _bb)
		{
			return QualityInfo.GetRootAsQualityInfo(_bb, default(QualityInfo));
		}

		// Token: 0x0600BA4C RID: 47692 RVA: 0x002E989C File Offset: 0x002E7A9C
		public static QualityInfo GetRootAsQualityInfo(ByteBuffer _bb, QualityInfo obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600BA4D RID: 47693 RVA: 0x002E98B9 File Offset: 0x002E7AB9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600BA4E RID: 47694 RVA: 0x002E98C8 File Offset: 0x002E7AC8
		public QualityInfo __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002BAB RID: 11179
		// (get) Token: 0x0600BA4F RID: 47695 RVA: 0x002E98D8 File Offset: 0x002E7AD8
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

		// Token: 0x17002BAC RID: 11180
		// (get) Token: 0x0600BA50 RID: 47696 RVA: 0x002E9914 File Offset: 0x002E7B14
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

		// Token: 0x0600BA51 RID: 47697 RVA: 0x002E994B File Offset: 0x002E7B4B
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600BA52 RID: 47698 RVA: 0x002E995A File Offset: 0x002E7B5A
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17002BAD RID: 11181
		// (get) Token: 0x0600BA53 RID: 47699 RVA: 0x002E9974 File Offset: 0x002E7B74
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

		// Token: 0x0600BA54 RID: 47700 RVA: 0x002E99AB File Offset: 0x002E7BAB
		public Span<byte> GetTextColorBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600BA55 RID: 47701 RVA: 0x002E99BA File Offset: 0x002E7BBA
		public byte[] GetTextColorArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17002BAE RID: 11182
		// (get) Token: 0x0600BA56 RID: 47702 RVA: 0x002E99D4 File Offset: 0x002E7BD4
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

		// Token: 0x0600BA57 RID: 47703 RVA: 0x002E9A0C File Offset: 0x002E7C0C
		public Span<byte> GetDropColorBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600BA58 RID: 47704 RVA: 0x002E9A1C File Offset: 0x002E7C1C
		public byte[] GetDropColorArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17002BAF RID: 11183
		// (get) Token: 0x0600BA59 RID: 47705 RVA: 0x002E9A34 File Offset: 0x002E7C34
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

		// Token: 0x0600BA5A RID: 47706 RVA: 0x002E9A6C File Offset: 0x002E7C6C
		public Span<byte> GetTypeADropColorBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600BA5B RID: 47707 RVA: 0x002E9A7C File Offset: 0x002E7C7C
		public byte[] GetTypeADropColorArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17002BB0 RID: 11184
		// (get) Token: 0x0600BA5C RID: 47708 RVA: 0x002E9A94 File Offset: 0x002E7C94
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

		// Token: 0x0600BA5D RID: 47709 RVA: 0x002E9ACC File Offset: 0x002E7CCC
		public Span<byte> GetFrameIconColorBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600BA5E RID: 47710 RVA: 0x002E9ADC File Offset: 0x002E7CDC
		public byte[] GetFrameIconColorArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17002BB1 RID: 11185
		// (get) Token: 0x0600BA5F RID: 47711 RVA: 0x002E9AF4 File Offset: 0x002E7CF4
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

		// Token: 0x0600BA60 RID: 47712 RVA: 0x002E9B2C File Offset: 0x002E7D2C
		public Span<byte> GetBackgroundColorBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600BA61 RID: 47713 RVA: 0x002E9B3C File Offset: 0x002E7D3C
		public byte[] GetBackgroundColorArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x17002BB2 RID: 11186
		// (get) Token: 0x0600BA62 RID: 47714 RVA: 0x002E9B54 File Offset: 0x002E7D54
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

		// Token: 0x0600BA63 RID: 47715 RVA: 0x002E9B8C File Offset: 0x002E7D8C
		public Span<byte> GetPhantomColorBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0600BA64 RID: 47716 RVA: 0x002E9B9C File Offset: 0x002E7D9C
		public byte[] GetPhantomColorArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x17002BB3 RID: 11187
		// (get) Token: 0x0600BA65 RID: 47717 RVA: 0x002E9BB4 File Offset: 0x002E7DB4
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

		// Token: 0x0600BA66 RID: 47718 RVA: 0x002E9BEC File Offset: 0x002E7DEC
		public Span<byte> GetInteractionHintColorBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x0600BA67 RID: 47719 RVA: 0x002E9BFC File Offset: 0x002E7DFC
		public byte[] GetInteractionHintColorArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x17002BB4 RID: 11188
		// (get) Token: 0x0600BA68 RID: 47720 RVA: 0x002E9C14 File Offset: 0x002E7E14
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

		// Token: 0x0600BA69 RID: 47721 RVA: 0x002E9C4C File Offset: 0x002E7E4C
		public Span<byte> GetGachaQualityNiagaraBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x0600BA6A RID: 47722 RVA: 0x002E9C5C File Offset: 0x002E7E5C
		public byte[] GetGachaQualityNiagaraArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x17002BB5 RID: 11189
		// (get) Token: 0x0600BA6B RID: 47723 RVA: 0x002E9C74 File Offset: 0x002E7E74
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

		// Token: 0x0600BA6C RID: 47724 RVA: 0x002E9CAC File Offset: 0x002E7EAC
		public Span<byte> GetTipQualityTextureBytes()
		{
			return this.__p.__vector_as_span<byte>(24, 1);
		}

		// Token: 0x0600BA6D RID: 47725 RVA: 0x002E9CBC File Offset: 0x002E7EBC
		public byte[] GetTipQualityTextureArray()
		{
			return this.__p.__vector_as_array<byte>(24) ?? Array.Empty<byte>();
		}

		// Token: 0x17002BB6 RID: 11190
		// (get) Token: 0x0600BA6E RID: 47726 RVA: 0x002E9CD4 File Offset: 0x002E7ED4
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

		// Token: 0x0600BA6F RID: 47727 RVA: 0x002E9D0C File Offset: 0x002E7F0C
		public Span<byte> GetGachaQualityTextureBytes()
		{
			return this.__p.__vector_as_span<byte>(26, 1);
		}

		// Token: 0x0600BA70 RID: 47728 RVA: 0x002E9D1C File Offset: 0x002E7F1C
		public byte[] GetGachaQualityTextureArray()
		{
			return this.__p.__vector_as_array<byte>(26) ?? Array.Empty<byte>();
		}

		// Token: 0x17002BB7 RID: 11191
		// (get) Token: 0x0600BA71 RID: 47729 RVA: 0x002E9D34 File Offset: 0x002E7F34
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

		// Token: 0x0600BA72 RID: 47730 RVA: 0x002E9D6C File Offset: 0x002E7F6C
		public Span<byte> GetGachaBgTextureBytes()
		{
			return this.__p.__vector_as_span<byte>(28, 1);
		}

		// Token: 0x0600BA73 RID: 47731 RVA: 0x002E9D7C File Offset: 0x002E7F7C
		public byte[] GetGachaBgTextureArray()
		{
			return this.__p.__vector_as_array<byte>(28) ?? Array.Empty<byte>();
		}

		// Token: 0x17002BB8 RID: 11192
		// (get) Token: 0x0600BA74 RID: 47732 RVA: 0x002E9D94 File Offset: 0x002E7F94
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

		// Token: 0x0600BA75 RID: 47733 RVA: 0x002E9DCC File Offset: 0x002E7FCC
		public Span<byte> GetBackgroundSpriteBytes()
		{
			return this.__p.__vector_as_span<byte>(30, 1);
		}

		// Token: 0x0600BA76 RID: 47734 RVA: 0x002E9DDC File Offset: 0x002E7FDC
		public byte[] GetBackgroundSpriteArray()
		{
			return this.__p.__vector_as_array<byte>(30) ?? Array.Empty<byte>();
		}

		// Token: 0x17002BB9 RID: 11193
		// (get) Token: 0x0600BA77 RID: 47735 RVA: 0x002E9DF4 File Offset: 0x002E7FF4
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

		// Token: 0x0600BA78 RID: 47736 RVA: 0x002E9E2C File Offset: 0x002E802C
		public Span<byte> GetVerticalGradientSpriteBytes()
		{
			return this.__p.__vector_as_span<byte>(32, 1);
		}

		// Token: 0x0600BA79 RID: 47737 RVA: 0x002E9E3C File Offset: 0x002E803C
		public byte[] GetVerticalGradientSpriteArray()
		{
			return this.__p.__vector_as_array<byte>(32) ?? Array.Empty<byte>();
		}

		// Token: 0x17002BBA RID: 11194
		// (get) Token: 0x0600BA7A RID: 47738 RVA: 0x002E9E54 File Offset: 0x002E8054
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

		// Token: 0x0600BA7B RID: 47739 RVA: 0x002E9E8C File Offset: 0x002E808C
		public Span<byte> GetTipsSpriteBytes()
		{
			return this.__p.__vector_as_span<byte>(34, 1);
		}

		// Token: 0x0600BA7C RID: 47740 RVA: 0x002E9E9C File Offset: 0x002E809C
		public byte[] GetTipsSpriteArray()
		{
			return this.__p.__vector_as_array<byte>(34) ?? Array.Empty<byte>();
		}

		// Token: 0x17002BBB RID: 11195
		// (get) Token: 0x0600BA7D RID: 47741 RVA: 0x002E9EB4 File Offset: 0x002E80B4
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

		// Token: 0x0600BA7E RID: 47742 RVA: 0x002E9EEC File Offset: 0x002E80EC
		public Span<byte> GetSpecialEffectsBytes()
		{
			return this.__p.__vector_as_span<byte>(36, 1);
		}

		// Token: 0x0600BA7F RID: 47743 RVA: 0x002E9EFC File Offset: 0x002E80FC
		public byte[] GetSpecialEffectsArray()
		{
			return this.__p.__vector_as_array<byte>(36) ?? Array.Empty<byte>();
		}

		// Token: 0x17002BBC RID: 11196
		// (get) Token: 0x0600BA80 RID: 47744 RVA: 0x002E9F14 File Offset: 0x002E8114
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

		// Token: 0x0600BA81 RID: 47745 RVA: 0x002E9F4C File Offset: 0x002E814C
		public Span<byte> GetDissipateEffectsBytes()
		{
			return this.__p.__vector_as_span<byte>(38, 1);
		}

		// Token: 0x0600BA82 RID: 47746 RVA: 0x002E9F5C File Offset: 0x002E815C
		public byte[] GetDissipateEffectsArray()
		{
			return this.__p.__vector_as_array<byte>(38) ?? Array.Empty<byte>();
		}

		// Token: 0x17002BBD RID: 11197
		// (get) Token: 0x0600BA83 RID: 47747 RVA: 0x002E9F74 File Offset: 0x002E8174
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

		// Token: 0x0600BA84 RID: 47748 RVA: 0x002E9FAC File Offset: 0x002E81AC
		public Span<byte> GetNewItemGetEffectsBytes()
		{
			return this.__p.__vector_as_span<byte>(40, 1);
		}

		// Token: 0x0600BA85 RID: 47749 RVA: 0x002E9FBC File Offset: 0x002E81BC
		public byte[] GetNewItemGetEffectsArray()
		{
			return this.__p.__vector_as_array<byte>(40) ?? Array.Empty<byte>();
		}

		// Token: 0x17002BBE RID: 11198
		// (get) Token: 0x0600BA86 RID: 47750 RVA: 0x002E9FD4 File Offset: 0x002E81D4
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

		// Token: 0x0600BA87 RID: 47751 RVA: 0x002EA00C File Offset: 0x002E820C
		public Span<byte> GetConsumeFilterTextBytes()
		{
			return this.__p.__vector_as_span<byte>(42, 1);
		}

		// Token: 0x0600BA88 RID: 47752 RVA: 0x002EA01C File Offset: 0x002E821C
		public byte[] GetConsumeFilterTextArray()
		{
			return this.__p.__vector_as_array<byte>(42) ?? Array.Empty<byte>();
		}

		// Token: 0x17002BBF RID: 11199
		// (get) Token: 0x0600BA89 RID: 47753 RVA: 0x002EA034 File Offset: 0x002E8234
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

		// Token: 0x0600BA8A RID: 47754 RVA: 0x002EA06C File Offset: 0x002E826C
		public Span<byte> GetPayShopTextureBytes()
		{
			return this.__p.__vector_as_span<byte>(44, 1);
		}

		// Token: 0x0600BA8B RID: 47755 RVA: 0x002EA07C File Offset: 0x002E827C
		public byte[] GetPayShopTextureArray()
		{
			return this.__p.__vector_as_array<byte>(44) ?? Array.Empty<byte>();
		}

		// Token: 0x17002BC0 RID: 11200
		// (get) Token: 0x0600BA8C RID: 47756 RVA: 0x002EA094 File Offset: 0x002E8294
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

		// Token: 0x0600BA8D RID: 47757 RVA: 0x002EA0CC File Offset: 0x002E82CC
		public Span<byte> GetNewPayShopTextureBytes()
		{
			return this.__p.__vector_as_span<byte>(46, 1);
		}

		// Token: 0x0600BA8E RID: 47758 RVA: 0x002EA0DC File Offset: 0x002E82DC
		public byte[] GetNewPayShopTextureArray()
		{
			return this.__p.__vector_as_array<byte>(46) ?? Array.Empty<byte>();
		}

		// Token: 0x17002BC1 RID: 11201
		// (get) Token: 0x0600BA8F RID: 47759 RVA: 0x002EA0F4 File Offset: 0x002E82F4
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

		// Token: 0x0600BA90 RID: 47760 RVA: 0x002EA12C File Offset: 0x002E832C
		public Span<byte> GetPayShopQualitySpriteBytes()
		{
			return this.__p.__vector_as_span<byte>(48, 1);
		}

		// Token: 0x0600BA91 RID: 47761 RVA: 0x002EA13C File Offset: 0x002E833C
		public byte[] GetPayShopQualitySpriteArray()
		{
			return this.__p.__vector_as_array<byte>(48) ?? Array.Empty<byte>();
		}

		// Token: 0x17002BC2 RID: 11202
		// (get) Token: 0x0600BA92 RID: 47762 RVA: 0x002EA154 File Offset: 0x002E8354
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

		// Token: 0x0600BA93 RID: 47763 RVA: 0x002EA18C File Offset: 0x002E838C
		public Span<byte> GetPhantomSpriteBytes()
		{
			return this.__p.__vector_as_span<byte>(50, 1);
		}

		// Token: 0x0600BA94 RID: 47764 RVA: 0x002EA19C File Offset: 0x002E839C
		public byte[] GetPhantomSpriteArray()
		{
			return this.__p.__vector_as_array<byte>(50) ?? Array.Empty<byte>();
		}

		// Token: 0x17002BC3 RID: 11203
		// (get) Token: 0x0600BA95 RID: 47765 RVA: 0x002EA1B4 File Offset: 0x002E83B4
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

		// Token: 0x0600BA96 RID: 47766 RVA: 0x002EA1EC File Offset: 0x002E83EC
		public Span<byte> GetDropItemQualityNiagaraPathBytes()
		{
			return this.__p.__vector_as_span<byte>(52, 1);
		}

		// Token: 0x0600BA97 RID: 47767 RVA: 0x002EA1FC File Offset: 0x002E83FC
		public byte[] GetDropItemQualityNiagaraPathArray()
		{
			return this.__p.__vector_as_array<byte>(52) ?? Array.Empty<byte>();
		}

		// Token: 0x17002BC4 RID: 11204
		// (get) Token: 0x0600BA98 RID: 47768 RVA: 0x002EA214 File Offset: 0x002E8414
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

		// Token: 0x0600BA99 RID: 47769 RVA: 0x002EA24C File Offset: 0x002E844C
		public Span<byte> GetMediumItemGridQualitySpritePathBytes()
		{
			return this.__p.__vector_as_span<byte>(54, 1);
		}

		// Token: 0x0600BA9A RID: 47770 RVA: 0x002EA25C File Offset: 0x002E845C
		public byte[] GetMediumItemGridQualitySpritePathArray()
		{
			return this.__p.__vector_as_array<byte>(54) ?? Array.Empty<byte>();
		}

		// Token: 0x17002BC5 RID: 11205
		// (get) Token: 0x0600BA9B RID: 47771 RVA: 0x002EA274 File Offset: 0x002E8474
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

		// Token: 0x0600BA9C RID: 47772 RVA: 0x002EA2AC File Offset: 0x002E84AC
		public Span<byte> GetTypeAGridQualitySpritePathBytes()
		{
			return this.__p.__vector_as_span<byte>(56, 1);
		}

		// Token: 0x0600BA9D RID: 47773 RVA: 0x002EA2BC File Offset: 0x002E84BC
		public byte[] GetTypeAGridQualitySpritePathArray()
		{
			return this.__p.__vector_as_array<byte>(56) ?? Array.Empty<byte>();
		}

		// Token: 0x17002BC6 RID: 11206
		// (get) Token: 0x0600BA9E RID: 47774 RVA: 0x002EA2D4 File Offset: 0x002E84D4
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

		// Token: 0x0600BA9F RID: 47775 RVA: 0x002EA30C File Offset: 0x002E850C
		public Span<byte> GetQualityColorBytes()
		{
			return this.__p.__vector_as_span<byte>(58, 1);
		}

		// Token: 0x0600BAA0 RID: 47776 RVA: 0x002EA31C File Offset: 0x002E851C
		public byte[] GetQualityColorArray()
		{
			return this.__p.__vector_as_array<byte>(58) ?? Array.Empty<byte>();
		}

		// Token: 0x17002BC7 RID: 11207
		// (get) Token: 0x0600BAA1 RID: 47777 RVA: 0x002EA334 File Offset: 0x002E8534
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

		// Token: 0x0600BAA2 RID: 47778 RVA: 0x002EA36C File Offset: 0x002E856C
		public Span<byte> GetRouletteTipsQualityTexPathBytes()
		{
			return this.__p.__vector_as_span<byte>(60, 1);
		}

		// Token: 0x0600BAA3 RID: 47779 RVA: 0x002EA37C File Offset: 0x002E857C
		public byte[] GetRouletteTipsQualityTexPathArray()
		{
			return this.__p.__vector_as_array<byte>(60) ?? Array.Empty<byte>();
		}

		// Token: 0x17002BC8 RID: 11208
		// (get) Token: 0x0600BAA4 RID: 47780 RVA: 0x002EA394 File Offset: 0x002E8594
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

		// Token: 0x0600BAA5 RID: 47781 RVA: 0x002EA3CC File Offset: 0x002E85CC
		public Span<byte> GetAcquireQualityTexPathBytes()
		{
			return this.__p.__vector_as_span<byte>(62, 1);
		}

		// Token: 0x0600BAA6 RID: 47782 RVA: 0x002EA3DC File Offset: 0x002E85DC
		public byte[] GetAcquireQualityTexPathArray()
		{
			return this.__p.__vector_as_array<byte>(62) ?? Array.Empty<byte>();
		}

		// Token: 0x17002BC9 RID: 11209
		// (get) Token: 0x0600BAA7 RID: 47783 RVA: 0x002EA3F4 File Offset: 0x002E85F4
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

		// Token: 0x0600BAA8 RID: 47784 RVA: 0x002EA42C File Offset: 0x002E862C
		public Span<byte> GetAcquireNewItemQualityTexPathBytes()
		{
			return this.__p.__vector_as_span<byte>(64, 1);
		}

		// Token: 0x0600BAA9 RID: 47785 RVA: 0x002EA43C File Offset: 0x002E863C
		public byte[] GetAcquireNewItemQualityTexPathArray()
		{
			return this.__p.__vector_as_array<byte>(64) ?? Array.Empty<byte>();
		}

		// Token: 0x17002BCA RID: 11210
		// (get) Token: 0x0600BAAA RID: 47786 RVA: 0x002EA454 File Offset: 0x002E8654
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

		// Token: 0x0600BAAB RID: 47787 RVA: 0x002EA48C File Offset: 0x002E868C
		public Span<byte> GetAcquireQualitySpritePathBytes()
		{
			return this.__p.__vector_as_span<byte>(66, 1);
		}

		// Token: 0x0600BAAC RID: 47788 RVA: 0x002EA49C File Offset: 0x002E869C
		public byte[] GetAcquireQualitySpritePathArray()
		{
			return this.__p.__vector_as_array<byte>(66) ?? Array.Empty<byte>();
		}

		// Token: 0x17002BCB RID: 11211
		// (get) Token: 0x0600BAAD RID: 47789 RVA: 0x002EA4B4 File Offset: 0x002E86B4
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

		// Token: 0x0600BAAE RID: 47790 RVA: 0x002EA4EC File Offset: 0x002E86EC
		public Span<byte> GetFilterIconPathBytes()
		{
			return this.__p.__vector_as_span<byte>(68, 1);
		}

		// Token: 0x0600BAAF RID: 47791 RVA: 0x002EA4FC File Offset: 0x002E86FC
		public byte[] GetFilterIconPathArray()
		{
			return this.__p.__vector_as_array<byte>(68) ?? Array.Empty<byte>();
		}

		// Token: 0x17002BCC RID: 11212
		// (get) Token: 0x0600BAB0 RID: 47792 RVA: 0x002EA514 File Offset: 0x002E8714
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

		// Token: 0x0600BAB1 RID: 47793 RVA: 0x002EA54C File Offset: 0x002E874C
		public Span<byte> GetCalabashLevelUpViewShowTextBytes()
		{
			return this.__p.__vector_as_span<byte>(70, 1);
		}

		// Token: 0x0600BAB2 RID: 47794 RVA: 0x002EA55C File Offset: 0x002E875C
		public byte[] GetCalabashLevelUpViewShowTextArray()
		{
			return this.__p.__vector_as_array<byte>(70) ?? Array.Empty<byte>();
		}

		// Token: 0x17002BCD RID: 11213
		// (get) Token: 0x0600BAB3 RID: 47795 RVA: 0x002EA574 File Offset: 0x002E8774
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

		// Token: 0x0600BAB4 RID: 47796 RVA: 0x002EA5AC File Offset: 0x002E87AC
		public Span<byte> GetUnlockVisionQualityBytes()
		{
			return this.__p.__vector_as_span<byte>(72, 1);
		}

		// Token: 0x0600BAB5 RID: 47797 RVA: 0x002EA5BC File Offset: 0x002E87BC
		public byte[] GetUnlockVisionQualityArray()
		{
			return this.__p.__vector_as_array<byte>(72) ?? Array.Empty<byte>();
		}

		// Token: 0x17002BCE RID: 11214
		// (get) Token: 0x0600BAB6 RID: 47798 RVA: 0x002EA5D4 File Offset: 0x002E87D4
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

		// Token: 0x0600BAB7 RID: 47799 RVA: 0x002EA60C File Offset: 0x002E880C
		public Span<byte> GetUnlockVisionQualityColorBytes()
		{
			return this.__p.__vector_as_span<byte>(74, 1);
		}

		// Token: 0x0600BAB8 RID: 47800 RVA: 0x002EA61C File Offset: 0x002E881C
		public byte[] GetUnlockVisionQualityColorArray()
		{
			return this.__p.__vector_as_array<byte>(74) ?? Array.Empty<byte>();
		}

		// Token: 0x17002BCF RID: 11215
		// (get) Token: 0x0600BAB9 RID: 47801 RVA: 0x002EA634 File Offset: 0x002E8834
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

		// Token: 0x17002BD0 RID: 11216
		// (get) Token: 0x0600BABA RID: 47802 RVA: 0x002EA674 File Offset: 0x002E8874
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

		// Token: 0x0600BABB RID: 47803 RVA: 0x002EA6AC File Offset: 0x002E88AC
		public Span<byte> GetRoleTrialQualityColorBytes()
		{
			return this.__p.__vector_as_span<byte>(78, 1);
		}

		// Token: 0x0600BABC RID: 47804 RVA: 0x002EA6BC File Offset: 0x002E88BC
		public byte[] GetRoleTrialQualityColorArray()
		{
			return this.__p.__vector_as_array<byte>(78) ?? Array.Empty<byte>();
		}

		// Token: 0x17002BD1 RID: 11217
		// (get) Token: 0x0600BABD RID: 47805 RVA: 0x002EA6D4 File Offset: 0x002E88D4
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

		// Token: 0x0600BABE RID: 47806 RVA: 0x002EA70C File Offset: 0x002E890C
		public Span<byte> GetSkinQualityBytes()
		{
			return this.__p.__vector_as_span<byte>(80, 1);
		}

		// Token: 0x0600BABF RID: 47807 RVA: 0x002EA71C File Offset: 0x002E891C
		public byte[] GetSkinQualityArray()
		{
			return this.__p.__vector_as_array<byte>(80) ?? Array.Empty<byte>();
		}

		// Token: 0x17002BD2 RID: 11218
		// (get) Token: 0x0600BAC0 RID: 47808 RVA: 0x002EA734 File Offset: 0x002E8934
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

		// Token: 0x0600BAC1 RID: 47809 RVA: 0x002EA76C File Offset: 0x002E896C
		public Span<byte> GetSkinQualityItemABytes()
		{
			return this.__p.__vector_as_span<byte>(82, 1);
		}

		// Token: 0x0600BAC2 RID: 47810 RVA: 0x002EA77C File Offset: 0x002E897C
		public byte[] GetSkinQualityItemAArray()
		{
			return this.__p.__vector_as_array<byte>(82) ?? Array.Empty<byte>();
		}

		// Token: 0x17002BD3 RID: 11219
		// (get) Token: 0x0600BAC3 RID: 47811 RVA: 0x002EA794 File Offset: 0x002E8994
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

		// Token: 0x0600BAC4 RID: 47812 RVA: 0x002EA7CC File Offset: 0x002E89CC
		public Span<byte> GetSkinItemColorBytes()
		{
			return this.__p.__vector_as_span<byte>(84, 1);
		}

		// Token: 0x0600BAC5 RID: 47813 RVA: 0x002EA7DC File Offset: 0x002E89DC
		public byte[] GetSkinItemColorArray()
		{
			return this.__p.__vector_as_array<byte>(84) ?? Array.Empty<byte>();
		}

		// Token: 0x17002BD4 RID: 11220
		// (get) Token: 0x0600BAC6 RID: 47814 RVA: 0x002EA7F4 File Offset: 0x002E89F4
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

		// Token: 0x0600BAC7 RID: 47815 RVA: 0x002EA82C File Offset: 0x002E8A2C
		public Span<byte> GetSkinItemBgBytes()
		{
			return this.__p.__vector_as_span<byte>(86, 1);
		}

		// Token: 0x0600BAC8 RID: 47816 RVA: 0x002EA83C File Offset: 0x002E8A3C
		public byte[] GetSkinItemBgArray()
		{
			return this.__p.__vector_as_array<byte>(86) ?? Array.Empty<byte>();
		}

		// Token: 0x17002BD5 RID: 11221
		// (get) Token: 0x0600BAC9 RID: 47817 RVA: 0x002EA854 File Offset: 0x002E8A54
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

		// Token: 0x0600BACA RID: 47818 RVA: 0x002EA88C File Offset: 0x002E8A8C
		public Span<byte> GetRoleSkinQualityBgBytes()
		{
			return this.__p.__vector_as_span<byte>(88, 1);
		}

		// Token: 0x0600BACB RID: 47819 RVA: 0x002EA89C File Offset: 0x002E8A9C
		public byte[] GetRoleSkinQualityBgArray()
		{
			return this.__p.__vector_as_array<byte>(88) ?? Array.Empty<byte>();
		}

		// Token: 0x17002BD6 RID: 11222
		// (get) Token: 0x0600BACC RID: 47820 RVA: 0x002EA8B4 File Offset: 0x002E8AB4
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

		// Token: 0x0600BACD RID: 47821 RVA: 0x002EA8EC File Offset: 0x002E8AEC
		public Span<byte> GetWeaponSkinQualityBgBytes()
		{
			return this.__p.__vector_as_span<byte>(90, 1);
		}

		// Token: 0x0600BACE RID: 47822 RVA: 0x002EA8FC File Offset: 0x002E8AFC
		public byte[] GetWeaponSkinQualityBgArray()
		{
			return this.__p.__vector_as_array<byte>(90) ?? Array.Empty<byte>();
		}

		// Token: 0x17002BD7 RID: 11223
		// (get) Token: 0x0600BACF RID: 47823 RVA: 0x002EA914 File Offset: 0x002E8B14
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

		// Token: 0x0600BAD0 RID: 47824 RVA: 0x002EA94C File Offset: 0x002E8B4C
		public Span<byte> GetComposeQualityBgBytes()
		{
			return this.__p.__vector_as_span<byte>(92, 1);
		}

		// Token: 0x0600BAD1 RID: 47825 RVA: 0x002EA95C File Offset: 0x002E8B5C
		public byte[] GetComposeQualityBgArray()
		{
			return this.__p.__vector_as_array<byte>(92) ?? Array.Empty<byte>();
		}

		// Token: 0x17002BD8 RID: 11224
		// (get) Token: 0x0600BAD2 RID: 47826 RVA: 0x002EA974 File Offset: 0x002E8B74
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

		// Token: 0x0600BAD3 RID: 47827 RVA: 0x002EA9AC File Offset: 0x002E8BAC
		public Span<byte> GetPayShopQualityTextureBytes()
		{
			return this.__p.__vector_as_span<byte>(94, 1);
		}

		// Token: 0x0600BAD4 RID: 47828 RVA: 0x002EA9BC File Offset: 0x002E8BBC
		public byte[] GetPayShopQualityTextureArray()
		{
			return this.__p.__vector_as_array<byte>(94) ?? Array.Empty<byte>();
		}

		// Token: 0x17002BD9 RID: 11225
		// (get) Token: 0x0600BAD5 RID: 47829 RVA: 0x002EA9D4 File Offset: 0x002E8BD4
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

		// Token: 0x0600BAD6 RID: 47830 RVA: 0x002EAA0C File Offset: 0x002E8C0C
		public Span<byte> GetPayShopQualityLightTextureBytes()
		{
			return this.__p.__vector_as_span<byte>(96, 1);
		}

		// Token: 0x0600BAD7 RID: 47831 RVA: 0x002EAA1C File Offset: 0x002E8C1C
		public byte[] GetPayShopQualityLightTextureArray()
		{
			return this.__p.__vector_as_array<byte>(96) ?? Array.Empty<byte>();
		}

		// Token: 0x17002BDA RID: 11226
		// (get) Token: 0x0600BAD8 RID: 47832 RVA: 0x002EAA34 File Offset: 0x002E8C34
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

		// Token: 0x0600BAD9 RID: 47833 RVA: 0x002EAA6C File Offset: 0x002E8C6C
		public Span<byte> GetPayShopLineColorBytes()
		{
			return this.__p.__vector_as_span<byte>(98, 1);
		}

		// Token: 0x0600BADA RID: 47834 RVA: 0x002EAA7C File Offset: 0x002E8C7C
		public byte[] GetPayShopLineColorArray()
		{
			return this.__p.__vector_as_array<byte>(98) ?? Array.Empty<byte>();
		}

		// Token: 0x17002BDB RID: 11227
		// (get) Token: 0x0600BADB RID: 47835 RVA: 0x002EAA94 File Offset: 0x002E8C94
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

		// Token: 0x0600BADC RID: 47836 RVA: 0x002EAACC File Offset: 0x002E8CCC
		public Span<byte> GetVisionGridQualitySpritePathBytes()
		{
			return this.__p.__vector_as_span<byte>(100, 1);
		}

		// Token: 0x0600BADD RID: 47837 RVA: 0x002EAADC File Offset: 0x002E8CDC
		public byte[] GetVisionGridQualitySpritePathArray()
		{
			return this.__p.__vector_as_array<byte>(100) ?? Array.Empty<byte>();
		}

		// Token: 0x17002BDC RID: 11228
		// (get) Token: 0x0600BADE RID: 47838 RVA: 0x002EAAF4 File Offset: 0x002E8CF4
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

		// Token: 0x0600BADF RID: 47839 RVA: 0x002EAB2C File Offset: 0x002E8D2C
		public Span<byte> GetPayShopItemQualityTextureBytes()
		{
			return this.__p.__vector_as_span<byte>(102, 1);
		}

		// Token: 0x0600BAE0 RID: 47840 RVA: 0x002EAB3C File Offset: 0x002E8D3C
		public byte[] GetPayShopItemQualityTextureArray()
		{
			return this.__p.__vector_as_array<byte>(102) ?? Array.Empty<byte>();
		}

		// Token: 0x17002BDD RID: 11229
		// (get) Token: 0x0600BAE1 RID: 47841 RVA: 0x002EAB54 File Offset: 0x002E8D54
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

		// Token: 0x0600BAE2 RID: 47842 RVA: 0x002EAB8C File Offset: 0x002E8D8C
		public Span<byte> GetPayShopItemQualityLightTextureBytes()
		{
			return this.__p.__vector_as_span<byte>(104, 1);
		}

		// Token: 0x0600BAE3 RID: 47843 RVA: 0x002EAB9C File Offset: 0x002E8D9C
		public byte[] GetPayShopItemQualityLightTextureArray()
		{
			return this.__p.__vector_as_array<byte>(104) ?? Array.Empty<byte>();
		}

		// Token: 0x17002BDE RID: 11230
		// (get) Token: 0x0600BAE4 RID: 47844 RVA: 0x002EABB4 File Offset: 0x002E8DB4
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

		// Token: 0x0600BAE5 RID: 47845 RVA: 0x002EABEC File Offset: 0x002E8DEC
		public Span<byte> GetPayShopItemLineColorBytes()
		{
			return this.__p.__vector_as_span<byte>(106, 1);
		}

		// Token: 0x0600BAE6 RID: 47846 RVA: 0x002EABFC File Offset: 0x002E8DFC
		public byte[] GetPayShopItemLineColorArray()
		{
			return this.__p.__vector_as_array<byte>(106) ?? Array.Empty<byte>();
		}

		// Token: 0x17002BDF RID: 11231
		// (get) Token: 0x0600BAE7 RID: 47847 RVA: 0x002EAC14 File Offset: 0x002E8E14
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

		// Token: 0x0600BAE8 RID: 47848 RVA: 0x002EAC4C File Offset: 0x002E8E4C
		public Span<byte> GetVisionNameColorBytes()
		{
			return this.__p.__vector_as_span<byte>(108, 1);
		}

		// Token: 0x0600BAE9 RID: 47849 RVA: 0x002EAC5C File Offset: 0x002E8E5C
		public byte[] GetVisionNameColorArray()
		{
			return this.__p.__vector_as_array<byte>(108) ?? Array.Empty<byte>();
		}

		// Token: 0x17002BE0 RID: 11232
		// (get) Token: 0x0600BAEA RID: 47850 RVA: 0x002EAC74 File Offset: 0x002E8E74
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

		// Token: 0x0600BAEB RID: 47851 RVA: 0x002EACAC File Offset: 0x002E8EAC
		public Span<byte> GetVisionGetTipsBgPathBytes()
		{
			return this.__p.__vector_as_span<byte>(110, 1);
		}

		// Token: 0x0600BAEC RID: 47852 RVA: 0x002EACBC File Offset: 0x002E8EBC
		public byte[] GetVisionGetTipsBgPathArray()
		{
			return this.__p.__vector_as_array<byte>(110) ?? Array.Empty<byte>();
		}

		// Token: 0x17002BE1 RID: 11233
		// (get) Token: 0x0600BAED RID: 47853 RVA: 0x002EACD4 File Offset: 0x002E8ED4
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

		// Token: 0x0600BAEE RID: 47854 RVA: 0x002EAD0C File Offset: 0x002E8F0C
		public Span<byte> GetItemTipsEffectColorBytes()
		{
			return this.__p.__vector_as_span<byte>(112, 1);
		}

		// Token: 0x0600BAEF RID: 47855 RVA: 0x002EAD1C File Offset: 0x002E8F1C
		public byte[] GetItemTipsEffectColorArray()
		{
			return this.__p.__vector_as_array<byte>(112) ?? Array.Empty<byte>();
		}

		// Token: 0x17002BE2 RID: 11234
		// (get) Token: 0x0600BAF0 RID: 47856 RVA: 0x002EAD34 File Offset: 0x002E8F34
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

		// Token: 0x0600BAF1 RID: 47857 RVA: 0x002EAD6C File Offset: 0x002E8F6C
		public Span<byte> GetTypeAItemTipsEffectColorBytes()
		{
			return this.__p.__vector_as_span<byte>(114, 1);
		}

		// Token: 0x0600BAF2 RID: 47858 RVA: 0x002EAD7C File Offset: 0x002E8F7C
		public byte[] GetTypeAItemTipsEffectColorArray()
		{
			return this.__p.__vector_as_array<byte>(114) ?? Array.Empty<byte>();
		}

		// Token: 0x17002BE3 RID: 11235
		// (get) Token: 0x0600BAF3 RID: 47859 RVA: 0x002EAD94 File Offset: 0x002E8F94
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

		// Token: 0x0600BAF4 RID: 47860 RVA: 0x002EADCC File Offset: 0x002E8FCC
		public Span<byte> GetTextureAcquireFlowBytes()
		{
			return this.__p.__vector_as_span<byte>(116, 1);
		}

		// Token: 0x0600BAF5 RID: 47861 RVA: 0x002EADDC File Offset: 0x002E8FDC
		public byte[] GetTextureAcquireFlowArray()
		{
			return this.__p.__vector_as_array<byte>(116) ?? Array.Empty<byte>();
		}

		// Token: 0x17002BE4 RID: 11236
		// (get) Token: 0x0600BAF6 RID: 47862 RVA: 0x002EADF4 File Offset: 0x002E8FF4
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

		// Token: 0x0600BAF7 RID: 47863 RVA: 0x002EAE2C File Offset: 0x002E902C
		public Span<byte> GetTextureAcquireBgBytes()
		{
			return this.__p.__vector_as_span<byte>(118, 1);
		}

		// Token: 0x0600BAF8 RID: 47864 RVA: 0x002EAE3C File Offset: 0x002E903C
		public byte[] GetTextureAcquireBgArray()
		{
			return this.__p.__vector_as_array<byte>(118) ?? Array.Empty<byte>();
		}

		// Token: 0x17002BE5 RID: 11237
		// (get) Token: 0x0600BAF9 RID: 47865 RVA: 0x002EAE54 File Offset: 0x002E9054
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

		// Token: 0x0600BAFA RID: 47866 RVA: 0x002EAE8C File Offset: 0x002E908C
		public Span<byte> GetTextureVisionQuailtyFlowBytes()
		{
			return this.__p.__vector_as_span<byte>(120, 1);
		}

		// Token: 0x0600BAFB RID: 47867 RVA: 0x002EAE9C File Offset: 0x002E909C
		public byte[] GetTextureVisionQuailtyFlowArray()
		{
			return this.__p.__vector_as_array<byte>(120) ?? Array.Empty<byte>();
		}

		// Token: 0x17002BE6 RID: 11238
		// (get) Token: 0x0600BAFC RID: 47868 RVA: 0x002EAEB4 File Offset: 0x002E90B4
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

		// Token: 0x0600BAFD RID: 47869 RVA: 0x002EAEEC File Offset: 0x002E90EC
		public Span<byte> GetTextureVisionQuailtyBgBytes()
		{
			return this.__p.__vector_as_span<byte>(122, 1);
		}

		// Token: 0x0600BAFE RID: 47870 RVA: 0x002EAEFC File Offset: 0x002E90FC
		public byte[] GetTextureVisionQuailtyBgArray()
		{
			return this.__p.__vector_as_array<byte>(122) ?? Array.Empty<byte>();
		}

		// Token: 0x04005618 RID: 22040
		private Table __p;
	}
}
