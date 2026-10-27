using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000AB1 RID: 2737
	public struct AbyssQuality : IFlatbufferObject
	{
		// Token: 0x17000084 RID: 132
		// (get) Token: 0x06004157 RID: 16727 RVA: 0x001C7821 File Offset: 0x001C5A21
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06004158 RID: 16728 RVA: 0x001C782E File Offset: 0x001C5A2E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06004159 RID: 16729 RVA: 0x001C7838 File Offset: 0x001C5A38
		public static AbyssQuality GetRootAsAbyssQuality(ByteBuffer _bb)
		{
			return AbyssQuality.GetRootAsAbyssQuality(_bb, default(AbyssQuality));
		}

		// Token: 0x0600415A RID: 16730 RVA: 0x001C7854 File Offset: 0x001C5A54
		public static AbyssQuality GetRootAsAbyssQuality(ByteBuffer _bb, AbyssQuality obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600415B RID: 16731 RVA: 0x001C7871 File Offset: 0x001C5A71
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600415C RID: 16732 RVA: 0x001C7880 File Offset: 0x001C5A80
		public AbyssQuality __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000085 RID: 133
		// (get) Token: 0x0600415D RID: 16733 RVA: 0x001C7890 File Offset: 0x001C5A90
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

		// Token: 0x17000086 RID: 134
		// (get) Token: 0x0600415E RID: 16734 RVA: 0x001C78CC File Offset: 0x001C5ACC
		public string Bg
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

		// Token: 0x0600415F RID: 16735 RVA: 0x001C7903 File Offset: 0x001C5B03
		public Span<byte> GetBgBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06004160 RID: 16736 RVA: 0x001C7912 File Offset: 0x001C5B12
		public byte[] GetBgArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17000087 RID: 135
		// (get) Token: 0x06004161 RID: 16737 RVA: 0x001C792C File Offset: 0x001C5B2C
		public string AbyssItemBg
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

		// Token: 0x06004162 RID: 16738 RVA: 0x001C7963 File Offset: 0x001C5B63
		public Span<byte> GetAbyssItemBgBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06004163 RID: 16739 RVA: 0x001C7972 File Offset: 0x001C5B72
		public byte[] GetAbyssItemBgArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17000088 RID: 136
		// (get) Token: 0x06004164 RID: 16740 RVA: 0x001C798C File Offset: 0x001C5B8C
		public string AbyssCoreItemBg
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

		// Token: 0x06004165 RID: 16741 RVA: 0x001C79C4 File Offset: 0x001C5BC4
		public Span<byte> GetAbyssCoreItemBgBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06004166 RID: 16742 RVA: 0x001C79D4 File Offset: 0x001C5BD4
		public byte[] GetAbyssCoreItemBgArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17000089 RID: 137
		// (get) Token: 0x06004167 RID: 16743 RVA: 0x001C79EC File Offset: 0x001C5BEC
		public string AbyssCoreItemFormationBg
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

		// Token: 0x06004168 RID: 16744 RVA: 0x001C7A24 File Offset: 0x001C5C24
		public Span<byte> GetAbyssCoreItemFormationBgBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06004169 RID: 16745 RVA: 0x001C7A34 File Offset: 0x001C5C34
		public byte[] GetAbyssCoreItemFormationBgArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x1700008A RID: 138
		// (get) Token: 0x0600416A RID: 16746 RVA: 0x001C7A4C File Offset: 0x001C5C4C
		public string AbyssItemFormationBg
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

		// Token: 0x0600416B RID: 16747 RVA: 0x001C7A84 File Offset: 0x001C5C84
		public Span<byte> GetAbyssItemFormationBgBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600416C RID: 16748 RVA: 0x001C7A94 File Offset: 0x001C5C94
		public byte[] GetAbyssItemFormationBgArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x1700008B RID: 139
		// (get) Token: 0x0600416D RID: 16749 RVA: 0x001C7AAC File Offset: 0x001C5CAC
		public string AbyssItemFormationBgColor
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

		// Token: 0x0600416E RID: 16750 RVA: 0x001C7AE4 File Offset: 0x001C5CE4
		public Span<byte> GetAbyssItemFormationBgColorBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600416F RID: 16751 RVA: 0x001C7AF4 File Offset: 0x001C5CF4
		public byte[] GetAbyssItemFormationBgColorArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x1700008C RID: 140
		// (get) Token: 0x06004170 RID: 16752 RVA: 0x001C7B0C File Offset: 0x001C5D0C
		public string InteractionHintColor
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

		// Token: 0x06004171 RID: 16753 RVA: 0x001C7B44 File Offset: 0x001C5D44
		public Span<byte> GetInteractionHintColorBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x06004172 RID: 16754 RVA: 0x001C7B54 File Offset: 0x001C5D54
		public byte[] GetInteractionHintColorArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x1700008D RID: 141
		// (get) Token: 0x06004173 RID: 16755 RVA: 0x001C7B6C File Offset: 0x001C5D6C
		public string Mesh
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

		// Token: 0x06004174 RID: 16756 RVA: 0x001C7BA4 File Offset: 0x001C5DA4
		public Span<byte> GetMeshBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x06004175 RID: 16757 RVA: 0x001C7BB4 File Offset: 0x001C5DB4
		public byte[] GetMeshArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x1700008E RID: 142
		// (get) Token: 0x06004176 RID: 16758 RVA: 0x001C7BCC File Offset: 0x001C5DCC
		public string PayShopQualitySprite
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

		// Token: 0x06004177 RID: 16759 RVA: 0x001C7C04 File Offset: 0x001C5E04
		public Span<byte> GetPayShopQualitySpriteBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x06004178 RID: 16760 RVA: 0x001C7C14 File Offset: 0x001C5E14
		public byte[] GetPayShopQualitySpriteArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x1700008F RID: 143
		// (get) Token: 0x06004179 RID: 16761 RVA: 0x001C7C2C File Offset: 0x001C5E2C
		public string AbyssPassiveItemBg
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

		// Token: 0x0600417A RID: 16762 RVA: 0x001C7C64 File Offset: 0x001C5E64
		public Span<byte> GetAbyssPassiveItemBgBytes()
		{
			return this.__p.__vector_as_span<byte>(24, 1);
		}

		// Token: 0x0600417B RID: 16763 RVA: 0x001C7C74 File Offset: 0x001C5E74
		public byte[] GetAbyssPassiveItemBgArray()
		{
			return this.__p.__vector_as_array<byte>(24) ?? Array.Empty<byte>();
		}

		// Token: 0x17000090 RID: 144
		// (get) Token: 0x0600417C RID: 16764 RVA: 0x001C7C8C File Offset: 0x001C5E8C
		public string AbyssSpecialEffects
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

		// Token: 0x0600417D RID: 16765 RVA: 0x001C7CC4 File Offset: 0x001C5EC4
		public Span<byte> GetAbyssSpecialEffectsBytes()
		{
			return this.__p.__vector_as_span<byte>(26, 1);
		}

		// Token: 0x0600417E RID: 16766 RVA: 0x001C7CD4 File Offset: 0x001C5ED4
		public byte[] GetAbyssSpecialEffectsArray()
		{
			return this.__p.__vector_as_array<byte>(26) ?? Array.Empty<byte>();
		}

		// Token: 0x17000091 RID: 145
		// (get) Token: 0x0600417F RID: 16767 RVA: 0x001C7CEC File Offset: 0x001C5EEC
		public string AbyssTailEffects
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

		// Token: 0x06004180 RID: 16768 RVA: 0x001C7D24 File Offset: 0x001C5F24
		public Span<byte> GetAbyssTailEffectsBytes()
		{
			return this.__p.__vector_as_span<byte>(28, 1);
		}

		// Token: 0x06004181 RID: 16769 RVA: 0x001C7D34 File Offset: 0x001C5F34
		public byte[] GetAbyssTailEffectsArray()
		{
			return this.__p.__vector_as_array<byte>(28) ?? Array.Empty<byte>();
		}

		// Token: 0x17000092 RID: 146
		// (get) Token: 0x06004182 RID: 16770 RVA: 0x001C7D4C File Offset: 0x001C5F4C
		public string AbyssDissipateEffects
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

		// Token: 0x06004183 RID: 16771 RVA: 0x001C7D84 File Offset: 0x001C5F84
		public Span<byte> GetAbyssDissipateEffectsBytes()
		{
			return this.__p.__vector_as_span<byte>(30, 1);
		}

		// Token: 0x06004184 RID: 16772 RVA: 0x001C7D94 File Offset: 0x001C5F94
		public byte[] GetAbyssDissipateEffectsArray()
		{
			return this.__p.__vector_as_array<byte>(30) ?? Array.Empty<byte>();
		}

		// Token: 0x17000093 RID: 147
		// (get) Token: 0x06004185 RID: 16773 RVA: 0x001C7DAC File Offset: 0x001C5FAC
		public string MediumItemGridQualitySpritePath
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

		// Token: 0x06004186 RID: 16774 RVA: 0x001C7DE4 File Offset: 0x001C5FE4
		public Span<byte> GetMediumItemGridQualitySpritePathBytes()
		{
			return this.__p.__vector_as_span<byte>(32, 1);
		}

		// Token: 0x06004187 RID: 16775 RVA: 0x001C7DF4 File Offset: 0x001C5FF4
		public byte[] GetMediumItemGridQualitySpritePathArray()
		{
			return this.__p.__vector_as_array<byte>(32) ?? Array.Empty<byte>();
		}

		// Token: 0x17000094 RID: 148
		// (get) Token: 0x06004188 RID: 16776 RVA: 0x001C7E0C File Offset: 0x001C600C
		public string QualityColor
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

		// Token: 0x06004189 RID: 16777 RVA: 0x001C7E44 File Offset: 0x001C6044
		public Span<byte> GetQualityColorBytes()
		{
			return this.__p.__vector_as_span<byte>(34, 1);
		}

		// Token: 0x0600418A RID: 16778 RVA: 0x001C7E54 File Offset: 0x001C6054
		public byte[] GetQualityColorArray()
		{
			return this.__p.__vector_as_array<byte>(34) ?? Array.Empty<byte>();
		}

		// Token: 0x17000095 RID: 149
		// (get) Token: 0x0600418B RID: 16779 RVA: 0x001C7E6C File Offset: 0x001C606C
		public string DropColor
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

		// Token: 0x0600418C RID: 16780 RVA: 0x001C7EA4 File Offset: 0x001C60A4
		public Span<byte> GetDropColorBytes()
		{
			return this.__p.__vector_as_span<byte>(36, 1);
		}

		// Token: 0x0600418D RID: 16781 RVA: 0x001C7EB4 File Offset: 0x001C60B4
		public byte[] GetDropColorArray()
		{
			return this.__p.__vector_as_array<byte>(36) ?? Array.Empty<byte>();
		}

		// Token: 0x17000096 RID: 150
		// (get) Token: 0x0600418E RID: 16782 RVA: 0x001C7ECC File Offset: 0x001C60CC
		public string TipsQualityTexturePath
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

		// Token: 0x0600418F RID: 16783 RVA: 0x001C7F04 File Offset: 0x001C6104
		public Span<byte> GetTipsQualityTexturePathBytes()
		{
			return this.__p.__vector_as_span<byte>(38, 1);
		}

		// Token: 0x06004190 RID: 16784 RVA: 0x001C7F14 File Offset: 0x001C6114
		public byte[] GetTipsQualityTexturePathArray()
		{
			return this.__p.__vector_as_array<byte>(38) ?? Array.Empty<byte>();
		}

		// Token: 0x17000097 RID: 151
		// (get) Token: 0x06004191 RID: 16785 RVA: 0x001C7F2C File Offset: 0x001C612C
		public int RecoveryRewardItem
		{
			get
			{
				int num = this.__p.__offset(40);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000098 RID: 152
		// (get) Token: 0x06004192 RID: 16786 RVA: 0x001C7F6C File Offset: 0x001C616C
		public string AcquireQualityTexPath
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

		// Token: 0x06004193 RID: 16787 RVA: 0x001C7FA4 File Offset: 0x001C61A4
		public Span<byte> GetAcquireQualityTexPathBytes()
		{
			return this.__p.__vector_as_span<byte>(42, 1);
		}

		// Token: 0x06004194 RID: 16788 RVA: 0x001C7FB4 File Offset: 0x001C61B4
		public byte[] GetAcquireQualityTexPathArray()
		{
			return this.__p.__vector_as_array<byte>(42) ?? Array.Empty<byte>();
		}

		// Token: 0x17000099 RID: 153
		// (get) Token: 0x06004195 RID: 16789 RVA: 0x001C7FCC File Offset: 0x001C61CC
		public string TextColor
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

		// Token: 0x06004196 RID: 16790 RVA: 0x001C8004 File Offset: 0x001C6204
		public Span<byte> GetTextColorBytes()
		{
			return this.__p.__vector_as_span<byte>(44, 1);
		}

		// Token: 0x06004197 RID: 16791 RVA: 0x001C8014 File Offset: 0x001C6214
		public byte[] GetTextColorArray()
		{
			return this.__p.__vector_as_array<byte>(44) ?? Array.Empty<byte>();
		}

		// Token: 0x1700009A RID: 154
		// (get) Token: 0x06004198 RID: 16792 RVA: 0x001C802C File Offset: 0x001C622C
		public string AcquireNewItemQualityTexPath
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

		// Token: 0x06004199 RID: 16793 RVA: 0x001C8064 File Offset: 0x001C6264
		public Span<byte> GetAcquireNewItemQualityTexPathBytes()
		{
			return this.__p.__vector_as_span<byte>(46, 1);
		}

		// Token: 0x0600419A RID: 16794 RVA: 0x001C8074 File Offset: 0x001C6274
		public byte[] GetAcquireNewItemQualityTexPathArray()
		{
			return this.__p.__vector_as_array<byte>(46) ?? Array.Empty<byte>();
		}

		// Token: 0x1700009B RID: 155
		// (get) Token: 0x0600419B RID: 16795 RVA: 0x001C808C File Offset: 0x001C628C
		public string AcquireQualitySpritePath
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

		// Token: 0x0600419C RID: 16796 RVA: 0x001C80C4 File Offset: 0x001C62C4
		public Span<byte> GetAcquireQualitySpritePathBytes()
		{
			return this.__p.__vector_as_span<byte>(48, 1);
		}

		// Token: 0x0600419D RID: 16797 RVA: 0x001C80D4 File Offset: 0x001C62D4
		public byte[] GetAcquireQualitySpritePathArray()
		{
			return this.__p.__vector_as_array<byte>(48) ?? Array.Empty<byte>();
		}

		// Token: 0x1700009C RID: 156
		// (get) Token: 0x0600419E RID: 16798 RVA: 0x001C80EC File Offset: 0x001C62EC
		public string Name
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

		// Token: 0x0600419F RID: 16799 RVA: 0x001C8124 File Offset: 0x001C6324
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(50, 1);
		}

		// Token: 0x060041A0 RID: 16800 RVA: 0x001C8134 File Offset: 0x001C6334
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(50) ?? Array.Empty<byte>();
		}

		// Token: 0x1700009D RID: 157
		// (get) Token: 0x060041A1 RID: 16801 RVA: 0x001C814C File Offset: 0x001C634C
		public string BackgroundSprite
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

		// Token: 0x060041A2 RID: 16802 RVA: 0x001C8184 File Offset: 0x001C6384
		public Span<byte> GetBackgroundSpriteBytes()
		{
			return this.__p.__vector_as_span<byte>(52, 1);
		}

		// Token: 0x060041A3 RID: 16803 RVA: 0x001C8194 File Offset: 0x001C6394
		public byte[] GetBackgroundSpriteArray()
		{
			return this.__p.__vector_as_array<byte>(52) ?? Array.Empty<byte>();
		}

		// Token: 0x1700009E RID: 158
		// (get) Token: 0x060041A4 RID: 16804 RVA: 0x001C81AC File Offset: 0x001C63AC
		public string FilterIconPath
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

		// Token: 0x060041A5 RID: 16805 RVA: 0x001C81E4 File Offset: 0x001C63E4
		public Span<byte> GetFilterIconPathBytes()
		{
			return this.__p.__vector_as_span<byte>(54, 1);
		}

		// Token: 0x060041A6 RID: 16806 RVA: 0x001C81F4 File Offset: 0x001C63F4
		public byte[] GetFilterIconPathArray()
		{
			return this.__p.__vector_as_array<byte>(54) ?? Array.Empty<byte>();
		}

		// Token: 0x1700009F RID: 159
		// (get) Token: 0x060041A7 RID: 16807 RVA: 0x001C820C File Offset: 0x001C640C
		public string TextureAcquireFlow
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

		// Token: 0x060041A8 RID: 16808 RVA: 0x001C8244 File Offset: 0x001C6444
		public Span<byte> GetTextureAcquireFlowBytes()
		{
			return this.__p.__vector_as_span<byte>(56, 1);
		}

		// Token: 0x060041A9 RID: 16809 RVA: 0x001C8254 File Offset: 0x001C6454
		public byte[] GetTextureAcquireFlowArray()
		{
			return this.__p.__vector_as_array<byte>(56) ?? Array.Empty<byte>();
		}

		// Token: 0x170000A0 RID: 160
		// (get) Token: 0x060041AA RID: 16810 RVA: 0x001C826C File Offset: 0x001C646C
		public string TextureAcquireBg
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

		// Token: 0x060041AB RID: 16811 RVA: 0x001C82A4 File Offset: 0x001C64A4
		public Span<byte> GetTextureAcquireBgBytes()
		{
			return this.__p.__vector_as_span<byte>(58, 1);
		}

		// Token: 0x060041AC RID: 16812 RVA: 0x001C82B4 File Offset: 0x001C64B4
		public byte[] GetTextureAcquireBgArray()
		{
			return this.__p.__vector_as_array<byte>(58) ?? Array.Empty<byte>();
		}

		// Token: 0x04004A87 RID: 19079
		private Table __p;
	}
}
