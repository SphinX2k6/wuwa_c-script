using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B86 RID: 2950
	public struct AbyssQuality : IFlatbufferObject
	{
		// Token: 0x17000084 RID: 132
		// (get) Token: 0x06004655 RID: 18005 RVA: 0x001E6A81 File Offset: 0x001E4C81
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06004656 RID: 18006 RVA: 0x001E6A8E File Offset: 0x001E4C8E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06004657 RID: 18007 RVA: 0x001E6A98 File Offset: 0x001E4C98
		public static AbyssQuality GetRootAsAbyssQuality(ByteBuffer _bb)
		{
			return AbyssQuality.GetRootAsAbyssQuality(_bb, default(AbyssQuality));
		}

		// Token: 0x06004658 RID: 18008 RVA: 0x001E6AB4 File Offset: 0x001E4CB4
		public static AbyssQuality GetRootAsAbyssQuality(ByteBuffer _bb, AbyssQuality obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06004659 RID: 18009 RVA: 0x001E6AD1 File Offset: 0x001E4CD1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600465A RID: 18010 RVA: 0x001E6AE0 File Offset: 0x001E4CE0
		public AbyssQuality __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000085 RID: 133
		// (get) Token: 0x0600465B RID: 18011 RVA: 0x001E6AF0 File Offset: 0x001E4CF0
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
		// (get) Token: 0x0600465C RID: 18012 RVA: 0x001E6B2C File Offset: 0x001E4D2C
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

		// Token: 0x0600465D RID: 18013 RVA: 0x001E6B63 File Offset: 0x001E4D63
		public Span<byte> GetBgBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600465E RID: 18014 RVA: 0x001E6B72 File Offset: 0x001E4D72
		public byte[] GetBgArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17000087 RID: 135
		// (get) Token: 0x0600465F RID: 18015 RVA: 0x001E6B8C File Offset: 0x001E4D8C
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

		// Token: 0x06004660 RID: 18016 RVA: 0x001E6BC3 File Offset: 0x001E4DC3
		public Span<byte> GetAbyssItemBgBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06004661 RID: 18017 RVA: 0x001E6BD2 File Offset: 0x001E4DD2
		public byte[] GetAbyssItemBgArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17000088 RID: 136
		// (get) Token: 0x06004662 RID: 18018 RVA: 0x001E6BEC File Offset: 0x001E4DEC
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

		// Token: 0x06004663 RID: 18019 RVA: 0x001E6C24 File Offset: 0x001E4E24
		public Span<byte> GetAbyssCoreItemBgBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06004664 RID: 18020 RVA: 0x001E6C34 File Offset: 0x001E4E34
		public byte[] GetAbyssCoreItemBgArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17000089 RID: 137
		// (get) Token: 0x06004665 RID: 18021 RVA: 0x001E6C4C File Offset: 0x001E4E4C
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

		// Token: 0x06004666 RID: 18022 RVA: 0x001E6C84 File Offset: 0x001E4E84
		public Span<byte> GetAbyssCoreItemFormationBgBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06004667 RID: 18023 RVA: 0x001E6C94 File Offset: 0x001E4E94
		public byte[] GetAbyssCoreItemFormationBgArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x1700008A RID: 138
		// (get) Token: 0x06004668 RID: 18024 RVA: 0x001E6CAC File Offset: 0x001E4EAC
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

		// Token: 0x06004669 RID: 18025 RVA: 0x001E6CE4 File Offset: 0x001E4EE4
		public Span<byte> GetAbyssItemFormationBgBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600466A RID: 18026 RVA: 0x001E6CF4 File Offset: 0x001E4EF4
		public byte[] GetAbyssItemFormationBgArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x1700008B RID: 139
		// (get) Token: 0x0600466B RID: 18027 RVA: 0x001E6D0C File Offset: 0x001E4F0C
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

		// Token: 0x0600466C RID: 18028 RVA: 0x001E6D44 File Offset: 0x001E4F44
		public Span<byte> GetAbyssItemFormationBgColorBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600466D RID: 18029 RVA: 0x001E6D54 File Offset: 0x001E4F54
		public byte[] GetAbyssItemFormationBgColorArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x1700008C RID: 140
		// (get) Token: 0x0600466E RID: 18030 RVA: 0x001E6D6C File Offset: 0x001E4F6C
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

		// Token: 0x0600466F RID: 18031 RVA: 0x001E6DA4 File Offset: 0x001E4FA4
		public Span<byte> GetInteractionHintColorBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x06004670 RID: 18032 RVA: 0x001E6DB4 File Offset: 0x001E4FB4
		public byte[] GetInteractionHintColorArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x1700008D RID: 141
		// (get) Token: 0x06004671 RID: 18033 RVA: 0x001E6DCC File Offset: 0x001E4FCC
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

		// Token: 0x06004672 RID: 18034 RVA: 0x001E6E04 File Offset: 0x001E5004
		public Span<byte> GetMeshBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x06004673 RID: 18035 RVA: 0x001E6E14 File Offset: 0x001E5014
		public byte[] GetMeshArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x1700008E RID: 142
		// (get) Token: 0x06004674 RID: 18036 RVA: 0x001E6E2C File Offset: 0x001E502C
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

		// Token: 0x06004675 RID: 18037 RVA: 0x001E6E64 File Offset: 0x001E5064
		public Span<byte> GetPayShopQualitySpriteBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x06004676 RID: 18038 RVA: 0x001E6E74 File Offset: 0x001E5074
		public byte[] GetPayShopQualitySpriteArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x1700008F RID: 143
		// (get) Token: 0x06004677 RID: 18039 RVA: 0x001E6E8C File Offset: 0x001E508C
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

		// Token: 0x06004678 RID: 18040 RVA: 0x001E6EC4 File Offset: 0x001E50C4
		public Span<byte> GetAbyssPassiveItemBgBytes()
		{
			return this.__p.__vector_as_span<byte>(24, 1);
		}

		// Token: 0x06004679 RID: 18041 RVA: 0x001E6ED4 File Offset: 0x001E50D4
		public byte[] GetAbyssPassiveItemBgArray()
		{
			return this.__p.__vector_as_array<byte>(24) ?? Array.Empty<byte>();
		}

		// Token: 0x17000090 RID: 144
		// (get) Token: 0x0600467A RID: 18042 RVA: 0x001E6EEC File Offset: 0x001E50EC
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

		// Token: 0x0600467B RID: 18043 RVA: 0x001E6F24 File Offset: 0x001E5124
		public Span<byte> GetAbyssSpecialEffectsBytes()
		{
			return this.__p.__vector_as_span<byte>(26, 1);
		}

		// Token: 0x0600467C RID: 18044 RVA: 0x001E6F34 File Offset: 0x001E5134
		public byte[] GetAbyssSpecialEffectsArray()
		{
			return this.__p.__vector_as_array<byte>(26) ?? Array.Empty<byte>();
		}

		// Token: 0x17000091 RID: 145
		// (get) Token: 0x0600467D RID: 18045 RVA: 0x001E6F4C File Offset: 0x001E514C
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

		// Token: 0x0600467E RID: 18046 RVA: 0x001E6F84 File Offset: 0x001E5184
		public Span<byte> GetAbyssTailEffectsBytes()
		{
			return this.__p.__vector_as_span<byte>(28, 1);
		}

		// Token: 0x0600467F RID: 18047 RVA: 0x001E6F94 File Offset: 0x001E5194
		public byte[] GetAbyssTailEffectsArray()
		{
			return this.__p.__vector_as_array<byte>(28) ?? Array.Empty<byte>();
		}

		// Token: 0x17000092 RID: 146
		// (get) Token: 0x06004680 RID: 18048 RVA: 0x001E6FAC File Offset: 0x001E51AC
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

		// Token: 0x06004681 RID: 18049 RVA: 0x001E6FE4 File Offset: 0x001E51E4
		public Span<byte> GetAbyssDissipateEffectsBytes()
		{
			return this.__p.__vector_as_span<byte>(30, 1);
		}

		// Token: 0x06004682 RID: 18050 RVA: 0x001E6FF4 File Offset: 0x001E51F4
		public byte[] GetAbyssDissipateEffectsArray()
		{
			return this.__p.__vector_as_array<byte>(30) ?? Array.Empty<byte>();
		}

		// Token: 0x17000093 RID: 147
		// (get) Token: 0x06004683 RID: 18051 RVA: 0x001E700C File Offset: 0x001E520C
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

		// Token: 0x06004684 RID: 18052 RVA: 0x001E7044 File Offset: 0x001E5244
		public Span<byte> GetMediumItemGridQualitySpritePathBytes()
		{
			return this.__p.__vector_as_span<byte>(32, 1);
		}

		// Token: 0x06004685 RID: 18053 RVA: 0x001E7054 File Offset: 0x001E5254
		public byte[] GetMediumItemGridQualitySpritePathArray()
		{
			return this.__p.__vector_as_array<byte>(32) ?? Array.Empty<byte>();
		}

		// Token: 0x17000094 RID: 148
		// (get) Token: 0x06004686 RID: 18054 RVA: 0x001E706C File Offset: 0x001E526C
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

		// Token: 0x06004687 RID: 18055 RVA: 0x001E70A4 File Offset: 0x001E52A4
		public Span<byte> GetQualityColorBytes()
		{
			return this.__p.__vector_as_span<byte>(34, 1);
		}

		// Token: 0x06004688 RID: 18056 RVA: 0x001E70B4 File Offset: 0x001E52B4
		public byte[] GetQualityColorArray()
		{
			return this.__p.__vector_as_array<byte>(34) ?? Array.Empty<byte>();
		}

		// Token: 0x17000095 RID: 149
		// (get) Token: 0x06004689 RID: 18057 RVA: 0x001E70CC File Offset: 0x001E52CC
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

		// Token: 0x0600468A RID: 18058 RVA: 0x001E7104 File Offset: 0x001E5304
		public Span<byte> GetDropColorBytes()
		{
			return this.__p.__vector_as_span<byte>(36, 1);
		}

		// Token: 0x0600468B RID: 18059 RVA: 0x001E7114 File Offset: 0x001E5314
		public byte[] GetDropColorArray()
		{
			return this.__p.__vector_as_array<byte>(36) ?? Array.Empty<byte>();
		}

		// Token: 0x17000096 RID: 150
		// (get) Token: 0x0600468C RID: 18060 RVA: 0x001E712C File Offset: 0x001E532C
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

		// Token: 0x0600468D RID: 18061 RVA: 0x001E7164 File Offset: 0x001E5364
		public Span<byte> GetTipsQualityTexturePathBytes()
		{
			return this.__p.__vector_as_span<byte>(38, 1);
		}

		// Token: 0x0600468E RID: 18062 RVA: 0x001E7174 File Offset: 0x001E5374
		public byte[] GetTipsQualityTexturePathArray()
		{
			return this.__p.__vector_as_array<byte>(38) ?? Array.Empty<byte>();
		}

		// Token: 0x17000097 RID: 151
		// (get) Token: 0x0600468F RID: 18063 RVA: 0x001E718C File Offset: 0x001E538C
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
		// (get) Token: 0x06004690 RID: 18064 RVA: 0x001E71CC File Offset: 0x001E53CC
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

		// Token: 0x06004691 RID: 18065 RVA: 0x001E7204 File Offset: 0x001E5404
		public Span<byte> GetAcquireQualityTexPathBytes()
		{
			return this.__p.__vector_as_span<byte>(42, 1);
		}

		// Token: 0x06004692 RID: 18066 RVA: 0x001E7214 File Offset: 0x001E5414
		public byte[] GetAcquireQualityTexPathArray()
		{
			return this.__p.__vector_as_array<byte>(42) ?? Array.Empty<byte>();
		}

		// Token: 0x17000099 RID: 153
		// (get) Token: 0x06004693 RID: 18067 RVA: 0x001E722C File Offset: 0x001E542C
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

		// Token: 0x06004694 RID: 18068 RVA: 0x001E7264 File Offset: 0x001E5464
		public Span<byte> GetTextColorBytes()
		{
			return this.__p.__vector_as_span<byte>(44, 1);
		}

		// Token: 0x06004695 RID: 18069 RVA: 0x001E7274 File Offset: 0x001E5474
		public byte[] GetTextColorArray()
		{
			return this.__p.__vector_as_array<byte>(44) ?? Array.Empty<byte>();
		}

		// Token: 0x1700009A RID: 154
		// (get) Token: 0x06004696 RID: 18070 RVA: 0x001E728C File Offset: 0x001E548C
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

		// Token: 0x06004697 RID: 18071 RVA: 0x001E72C4 File Offset: 0x001E54C4
		public Span<byte> GetAcquireNewItemQualityTexPathBytes()
		{
			return this.__p.__vector_as_span<byte>(46, 1);
		}

		// Token: 0x06004698 RID: 18072 RVA: 0x001E72D4 File Offset: 0x001E54D4
		public byte[] GetAcquireNewItemQualityTexPathArray()
		{
			return this.__p.__vector_as_array<byte>(46) ?? Array.Empty<byte>();
		}

		// Token: 0x1700009B RID: 155
		// (get) Token: 0x06004699 RID: 18073 RVA: 0x001E72EC File Offset: 0x001E54EC
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

		// Token: 0x0600469A RID: 18074 RVA: 0x001E7324 File Offset: 0x001E5524
		public Span<byte> GetAcquireQualitySpritePathBytes()
		{
			return this.__p.__vector_as_span<byte>(48, 1);
		}

		// Token: 0x0600469B RID: 18075 RVA: 0x001E7334 File Offset: 0x001E5534
		public byte[] GetAcquireQualitySpritePathArray()
		{
			return this.__p.__vector_as_array<byte>(48) ?? Array.Empty<byte>();
		}

		// Token: 0x1700009C RID: 156
		// (get) Token: 0x0600469C RID: 18076 RVA: 0x001E734C File Offset: 0x001E554C
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

		// Token: 0x0600469D RID: 18077 RVA: 0x001E7384 File Offset: 0x001E5584
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(50, 1);
		}

		// Token: 0x0600469E RID: 18078 RVA: 0x001E7394 File Offset: 0x001E5594
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(50) ?? Array.Empty<byte>();
		}

		// Token: 0x1700009D RID: 157
		// (get) Token: 0x0600469F RID: 18079 RVA: 0x001E73AC File Offset: 0x001E55AC
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

		// Token: 0x060046A0 RID: 18080 RVA: 0x001E73E4 File Offset: 0x001E55E4
		public Span<byte> GetBackgroundSpriteBytes()
		{
			return this.__p.__vector_as_span<byte>(52, 1);
		}

		// Token: 0x060046A1 RID: 18081 RVA: 0x001E73F4 File Offset: 0x001E55F4
		public byte[] GetBackgroundSpriteArray()
		{
			return this.__p.__vector_as_array<byte>(52) ?? Array.Empty<byte>();
		}

		// Token: 0x1700009E RID: 158
		// (get) Token: 0x060046A2 RID: 18082 RVA: 0x001E740C File Offset: 0x001E560C
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

		// Token: 0x060046A3 RID: 18083 RVA: 0x001E7444 File Offset: 0x001E5644
		public Span<byte> GetFilterIconPathBytes()
		{
			return this.__p.__vector_as_span<byte>(54, 1);
		}

		// Token: 0x060046A4 RID: 18084 RVA: 0x001E7454 File Offset: 0x001E5654
		public byte[] GetFilterIconPathArray()
		{
			return this.__p.__vector_as_array<byte>(54) ?? Array.Empty<byte>();
		}

		// Token: 0x1700009F RID: 159
		// (get) Token: 0x060046A5 RID: 18085 RVA: 0x001E746C File Offset: 0x001E566C
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

		// Token: 0x060046A6 RID: 18086 RVA: 0x001E74A4 File Offset: 0x001E56A4
		public Span<byte> GetTextureAcquireFlowBytes()
		{
			return this.__p.__vector_as_span<byte>(56, 1);
		}

		// Token: 0x060046A7 RID: 18087 RVA: 0x001E74B4 File Offset: 0x001E56B4
		public byte[] GetTextureAcquireFlowArray()
		{
			return this.__p.__vector_as_array<byte>(56) ?? Array.Empty<byte>();
		}

		// Token: 0x170000A0 RID: 160
		// (get) Token: 0x060046A8 RID: 18088 RVA: 0x001E74CC File Offset: 0x001E56CC
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

		// Token: 0x060046A9 RID: 18089 RVA: 0x001E7504 File Offset: 0x001E5704
		public Span<byte> GetTextureAcquireBgBytes()
		{
			return this.__p.__vector_as_span<byte>(58, 1);
		}

		// Token: 0x060046AA RID: 18090 RVA: 0x001E7514 File Offset: 0x001E5714
		public byte[] GetTextureAcquireBgArray()
		{
			return this.__p.__vector_as_array<byte>(58) ?? Array.Empty<byte>();
		}

		// Token: 0x0400505A RID: 20570
		private Table __p;
	}
}
