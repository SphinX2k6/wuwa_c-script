using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D0A RID: 3338
	public struct ElementInfo : IFlatbufferObject
	{
		// Token: 0x17000F02 RID: 3842
		// (get) Token: 0x06006DE2 RID: 28130 RVA: 0x0023FFBD File Offset: 0x0023E1BD
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06006DE3 RID: 28131 RVA: 0x0023FFCA File Offset: 0x0023E1CA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06006DE4 RID: 28132 RVA: 0x0023FFD4 File Offset: 0x0023E1D4
		public static ElementInfo GetRootAsElementInfo(ByteBuffer _bb)
		{
			return ElementInfo.GetRootAsElementInfo(_bb, default(ElementInfo));
		}

		// Token: 0x06006DE5 RID: 28133 RVA: 0x0023FFF0 File Offset: 0x0023E1F0
		public static ElementInfo GetRootAsElementInfo(ByteBuffer _bb, ElementInfo obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06006DE6 RID: 28134 RVA: 0x0024000D File Offset: 0x0023E20D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06006DE7 RID: 28135 RVA: 0x0024001C File Offset: 0x0023E21C
		public ElementInfo __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000F03 RID: 3843
		// (get) Token: 0x06006DE8 RID: 28136 RVA: 0x0024002C File Offset: 0x0023E22C
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

		// Token: 0x17000F04 RID: 3844
		// (get) Token: 0x06006DE9 RID: 28137 RVA: 0x00240068 File Offset: 0x0023E268
		public string Describe
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

		// Token: 0x06006DEA RID: 28138 RVA: 0x0024009F File Offset: 0x0023E29F
		public Span<byte> GetDescribeBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06006DEB RID: 28139 RVA: 0x002400AE File Offset: 0x0023E2AE
		public byte[] GetDescribeArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17000F05 RID: 3845
		// (get) Token: 0x06006DEC RID: 28140 RVA: 0x002400C8 File Offset: 0x0023E2C8
		public string Name
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

		// Token: 0x06006DED RID: 28141 RVA: 0x002400FF File Offset: 0x0023E2FF
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06006DEE RID: 28142 RVA: 0x0024010E File Offset: 0x0023E30E
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17000F06 RID: 3846
		// (get) Token: 0x06006DEF RID: 28143 RVA: 0x00240128 File Offset: 0x0023E328
		public string Icon
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

		// Token: 0x06006DF0 RID: 28144 RVA: 0x00240160 File Offset: 0x0023E360
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06006DF1 RID: 28145 RVA: 0x00240170 File Offset: 0x0023E370
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17000F07 RID: 3847
		// (get) Token: 0x06006DF2 RID: 28146 RVA: 0x00240188 File Offset: 0x0023E388
		public string Icon2
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

		// Token: 0x06006DF3 RID: 28147 RVA: 0x002401C0 File Offset: 0x0023E3C0
		public Span<byte> GetIcon2Bytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06006DF4 RID: 28148 RVA: 0x002401D0 File Offset: 0x0023E3D0
		public byte[] GetIcon2Array()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17000F08 RID: 3848
		// (get) Token: 0x06006DF5 RID: 28149 RVA: 0x002401E8 File Offset: 0x0023E3E8
		public string Icon3
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

		// Token: 0x06006DF6 RID: 28150 RVA: 0x00240220 File Offset: 0x0023E420
		public Span<byte> GetIcon3Bytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x06006DF7 RID: 28151 RVA: 0x00240230 File Offset: 0x0023E430
		public byte[] GetIcon3Array()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17000F09 RID: 3849
		// (get) Token: 0x06006DF8 RID: 28152 RVA: 0x00240248 File Offset: 0x0023E448
		public string Icon4
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

		// Token: 0x06006DF9 RID: 28153 RVA: 0x00240280 File Offset: 0x0023E480
		public Span<byte> GetIcon4Bytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x06006DFA RID: 28154 RVA: 0x00240290 File Offset: 0x0023E490
		public byte[] GetIcon4Array()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x17000F0A RID: 3850
		// (get) Token: 0x06006DFB RID: 28155 RVA: 0x002402A8 File Offset: 0x0023E4A8
		public string Icon4Pure
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

		// Token: 0x06006DFC RID: 28156 RVA: 0x002402E0 File Offset: 0x0023E4E0
		public Span<byte> GetIcon4PureBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x06006DFD RID: 28157 RVA: 0x002402F0 File Offset: 0x0023E4F0
		public byte[] GetIcon4PureArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x17000F0B RID: 3851
		// (get) Token: 0x06006DFE RID: 28158 RVA: 0x00240308 File Offset: 0x0023E508
		public string Icon5
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

		// Token: 0x06006DFF RID: 28159 RVA: 0x00240340 File Offset: 0x0023E540
		public Span<byte> GetIcon5Bytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x06006E00 RID: 28160 RVA: 0x00240350 File Offset: 0x0023E550
		public byte[] GetIcon5Array()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x17000F0C RID: 3852
		// (get) Token: 0x06006E01 RID: 28161 RVA: 0x00240368 File Offset: 0x0023E568
		public string Icon6
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

		// Token: 0x06006E02 RID: 28162 RVA: 0x002403A0 File Offset: 0x0023E5A0
		public Span<byte> GetIcon6Bytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x06006E03 RID: 28163 RVA: 0x002403B0 File Offset: 0x0023E5B0
		public byte[] GetIcon6Array()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x17000F0D RID: 3853
		// (get) Token: 0x06006E04 RID: 28164 RVA: 0x002403C8 File Offset: 0x0023E5C8
		public string Icon7
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

		// Token: 0x06006E05 RID: 28165 RVA: 0x00240400 File Offset: 0x0023E600
		public Span<byte> GetIcon7Bytes()
		{
			return this.__p.__vector_as_span<byte>(24, 1);
		}

		// Token: 0x06006E06 RID: 28166 RVA: 0x00240410 File Offset: 0x0023E610
		public byte[] GetIcon7Array()
		{
			return this.__p.__vector_as_array<byte>(24) ?? Array.Empty<byte>();
		}

		// Token: 0x17000F0E RID: 3854
		// (get) Token: 0x06006E07 RID: 28167 RVA: 0x00240428 File Offset: 0x0023E628
		public string ElementChangeTexture
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

		// Token: 0x06006E08 RID: 28168 RVA: 0x00240460 File Offset: 0x0023E660
		public Span<byte> GetElementChangeTextureBytes()
		{
			return this.__p.__vector_as_span<byte>(26, 1);
		}

		// Token: 0x06006E09 RID: 28169 RVA: 0x00240470 File Offset: 0x0023E670
		public byte[] GetElementChangeTextureArray()
		{
			return this.__p.__vector_as_array<byte>(26) ?? Array.Empty<byte>();
		}

		// Token: 0x17000F0F RID: 3855
		// (get) Token: 0x06006E0A RID: 28170 RVA: 0x00240488 File Offset: 0x0023E688
		public string ElementChangeColor
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

		// Token: 0x06006E0B RID: 28171 RVA: 0x002404C0 File Offset: 0x0023E6C0
		public Span<byte> GetElementChangeColorBytes()
		{
			return this.__p.__vector_as_span<byte>(28, 1);
		}

		// Token: 0x06006E0C RID: 28172 RVA: 0x002404D0 File Offset: 0x0023E6D0
		public byte[] GetElementChangeColorArray()
		{
			return this.__p.__vector_as_array<byte>(28) ?? Array.Empty<byte>();
		}

		// Token: 0x17000F10 RID: 3856
		// (get) Token: 0x06006E0D RID: 28173 RVA: 0x002404E8 File Offset: 0x0023E6E8
		public string ElementEffectColor
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

		// Token: 0x06006E0E RID: 28174 RVA: 0x00240520 File Offset: 0x0023E720
		public Span<byte> GetElementEffectColorBytes()
		{
			return this.__p.__vector_as_span<byte>(30, 1);
		}

		// Token: 0x06006E0F RID: 28175 RVA: 0x00240530 File Offset: 0x0023E730
		public byte[] GetElementEffectColorArray()
		{
			return this.__p.__vector_as_array<byte>(30) ?? Array.Empty<byte>();
		}

		// Token: 0x17000F11 RID: 3857
		// (get) Token: 0x06006E10 RID: 28176 RVA: 0x00240548 File Offset: 0x0023E748
		public string ElementColor
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

		// Token: 0x06006E11 RID: 28177 RVA: 0x00240580 File Offset: 0x0023E780
		public Span<byte> GetElementColorBytes()
		{
			return this.__p.__vector_as_span<byte>(32, 1);
		}

		// Token: 0x06006E12 RID: 28178 RVA: 0x00240590 File Offset: 0x0023E790
		public byte[] GetElementColorArray()
		{
			return this.__p.__vector_as_array<byte>(32) ?? Array.Empty<byte>();
		}

		// Token: 0x17000F12 RID: 3858
		// (get) Token: 0x06006E13 RID: 28179 RVA: 0x002405A8 File Offset: 0x0023E7A8
		public string SkillTreeEffectColor
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

		// Token: 0x06006E14 RID: 28180 RVA: 0x002405E0 File Offset: 0x0023E7E0
		public Span<byte> GetSkillTreeEffectColorBytes()
		{
			return this.__p.__vector_as_span<byte>(34, 1);
		}

		// Token: 0x06006E15 RID: 28181 RVA: 0x002405F0 File Offset: 0x0023E7F0
		public byte[] GetSkillTreeEffectColorArray()
		{
			return this.__p.__vector_as_array<byte>(34) ?? Array.Empty<byte>();
		}

		// Token: 0x17000F13 RID: 3859
		// (get) Token: 0x06006E16 RID: 28182 RVA: 0x00240608 File Offset: 0x0023E808
		public string SkillTreeIconColor
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

		// Token: 0x06006E17 RID: 28183 RVA: 0x00240640 File Offset: 0x0023E840
		public Span<byte> GetSkillTreeIconColorBytes()
		{
			return this.__p.__vector_as_span<byte>(36, 1);
		}

		// Token: 0x06006E18 RID: 28184 RVA: 0x00240650 File Offset: 0x0023E850
		public byte[] GetSkillTreeIconColorArray()
		{
			return this.__p.__vector_as_array<byte>(36) ?? Array.Empty<byte>();
		}

		// Token: 0x17000F14 RID: 3860
		// (get) Token: 0x06006E19 RID: 28185 RVA: 0x00240668 File Offset: 0x0023E868
		public string SkillTreeLineColor
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

		// Token: 0x06006E1A RID: 28186 RVA: 0x002406A0 File Offset: 0x0023E8A0
		public Span<byte> GetSkillTreeLineColorBytes()
		{
			return this.__p.__vector_as_span<byte>(38, 1);
		}

		// Token: 0x06006E1B RID: 28187 RVA: 0x002406B0 File Offset: 0x0023E8B0
		public byte[] GetSkillTreeLineColorArray()
		{
			return this.__p.__vector_as_array<byte>(38) ?? Array.Empty<byte>();
		}

		// Token: 0x17000F15 RID: 3861
		// (get) Token: 0x06006E1C RID: 28188 RVA: 0x002406C8 File Offset: 0x0023E8C8
		public string Effect
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

		// Token: 0x06006E1D RID: 28189 RVA: 0x00240700 File Offset: 0x0023E900
		public Span<byte> GetEffectBytes()
		{
			return this.__p.__vector_as_span<byte>(40, 1);
		}

		// Token: 0x06006E1E RID: 28190 RVA: 0x00240710 File Offset: 0x0023E910
		public byte[] GetEffectArray()
		{
			return this.__p.__vector_as_array<byte>(40) ?? Array.Empty<byte>();
		}

		// Token: 0x17000F16 RID: 3862
		// (get) Token: 0x06006E1F RID: 28191 RVA: 0x00240728 File Offset: 0x0023E928
		public string EffectTexturePath
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

		// Token: 0x06006E20 RID: 28192 RVA: 0x00240760 File Offset: 0x0023E960
		public Span<byte> GetEffectTexturePathBytes()
		{
			return this.__p.__vector_as_span<byte>(42, 1);
		}

		// Token: 0x06006E21 RID: 28193 RVA: 0x00240770 File Offset: 0x0023E970
		public byte[] GetEffectTexturePathArray()
		{
			return this.__p.__vector_as_array<byte>(42) ?? Array.Empty<byte>();
		}

		// Token: 0x17000F17 RID: 3863
		// (get) Token: 0x06006E22 RID: 28194 RVA: 0x00240788 File Offset: 0x0023E988
		public string GachaElementBgSpritePath
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

		// Token: 0x06006E23 RID: 28195 RVA: 0x002407C0 File Offset: 0x0023E9C0
		public Span<byte> GetGachaElementBgSpritePathBytes()
		{
			return this.__p.__vector_as_span<byte>(44, 1);
		}

		// Token: 0x06006E24 RID: 28196 RVA: 0x002407D0 File Offset: 0x0023E9D0
		public byte[] GetGachaElementBgSpritePathArray()
		{
			return this.__p.__vector_as_array<byte>(44) ?? Array.Empty<byte>();
		}

		// Token: 0x17000F18 RID: 3864
		// (get) Token: 0x06006E25 RID: 28197 RVA: 0x002407E8 File Offset: 0x0023E9E8
		public string GachaSpritePath
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

		// Token: 0x06006E26 RID: 28198 RVA: 0x00240820 File Offset: 0x0023EA20
		public Span<byte> GetGachaSpritePathBytes()
		{
			return this.__p.__vector_as_span<byte>(46, 1);
		}

		// Token: 0x06006E27 RID: 28199 RVA: 0x00240830 File Offset: 0x0023EA30
		public byte[] GetGachaSpritePathArray()
		{
			return this.__p.__vector_as_array<byte>(46) ?? Array.Empty<byte>();
		}

		// Token: 0x17000F19 RID: 3865
		// (get) Token: 0x06006E28 RID: 28200 RVA: 0x00240848 File Offset: 0x0023EA48
		public string UltimateSkillColor
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

		// Token: 0x06006E29 RID: 28201 RVA: 0x00240880 File Offset: 0x0023EA80
		public Span<byte> GetUltimateSkillColorBytes()
		{
			return this.__p.__vector_as_span<byte>(48, 1);
		}

		// Token: 0x06006E2A RID: 28202 RVA: 0x00240890 File Offset: 0x0023EA90
		public byte[] GetUltimateSkillColorArray()
		{
			return this.__p.__vector_as_array<byte>(48) ?? Array.Empty<byte>();
		}

		// Token: 0x17000F1A RID: 3866
		// (get) Token: 0x06006E2B RID: 28203 RVA: 0x002408A8 File Offset: 0x0023EAA8
		public string SkillEffectColor
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

		// Token: 0x06006E2C RID: 28204 RVA: 0x002408E0 File Offset: 0x0023EAE0
		public Span<byte> GetSkillEffectColorBytes()
		{
			return this.__p.__vector_as_span<byte>(50, 1);
		}

		// Token: 0x06006E2D RID: 28205 RVA: 0x002408F0 File Offset: 0x0023EAF0
		public byte[] GetSkillEffectColorArray()
		{
			return this.__p.__vector_as_array<byte>(50) ?? Array.Empty<byte>();
		}

		// Token: 0x17000F1B RID: 3867
		// (get) Token: 0x06006E2E RID: 28206 RVA: 0x00240908 File Offset: 0x0023EB08
		public string SkillButtonEffectPath
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

		// Token: 0x06006E2F RID: 28207 RVA: 0x00240940 File Offset: 0x0023EB40
		public Span<byte> GetSkillButtonEffectPathBytes()
		{
			return this.__p.__vector_as_span<byte>(52, 1);
		}

		// Token: 0x06006E30 RID: 28208 RVA: 0x00240950 File Offset: 0x0023EB50
		public byte[] GetSkillButtonEffectPathArray()
		{
			return this.__p.__vector_as_array<byte>(52) ?? Array.Empty<byte>();
		}

		// Token: 0x17000F1C RID: 3868
		// (get) Token: 0x06006E31 RID: 28209 RVA: 0x00240968 File Offset: 0x0023EB68
		public string ElementBallEffectPath
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

		// Token: 0x06006E32 RID: 28210 RVA: 0x002409A0 File Offset: 0x0023EBA0
		public Span<byte> GetElementBallEffectPathBytes()
		{
			return this.__p.__vector_as_span<byte>(54, 1);
		}

		// Token: 0x06006E33 RID: 28211 RVA: 0x002409B0 File Offset: 0x0023EBB0
		public byte[] GetElementBallEffectPathArray()
		{
			return this.__p.__vector_as_array<byte>(54) ?? Array.Empty<byte>();
		}

		// Token: 0x17000F1D RID: 3869
		// (get) Token: 0x06006E34 RID: 28212 RVA: 0x002409C8 File Offset: 0x0023EBC8
		public string SpriteIcon1
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

		// Token: 0x06006E35 RID: 28213 RVA: 0x00240A00 File Offset: 0x0023EC00
		public Span<byte> GetSpriteIcon1Bytes()
		{
			return this.__p.__vector_as_span<byte>(56, 1);
		}

		// Token: 0x06006E36 RID: 28214 RVA: 0x00240A10 File Offset: 0x0023EC10
		public byte[] GetSpriteIcon1Array()
		{
			return this.__p.__vector_as_array<byte>(56) ?? Array.Empty<byte>();
		}

		// Token: 0x17000F1E RID: 3870
		// (get) Token: 0x06006E37 RID: 28215 RVA: 0x00240A28 File Offset: 0x0023EC28
		public string AudioEvent
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

		// Token: 0x06006E38 RID: 28216 RVA: 0x00240A60 File Offset: 0x0023EC60
		public Span<byte> GetAudioEventBytes()
		{
			return this.__p.__vector_as_span<byte>(58, 1);
		}

		// Token: 0x06006E39 RID: 28217 RVA: 0x00240A70 File Offset: 0x0023EC70
		public byte[] GetAudioEventArray()
		{
			return this.__p.__vector_as_array<byte>(58) ?? Array.Empty<byte>();
		}

		// Token: 0x17000F1F RID: 3871
		// (get) Token: 0x06006E3A RID: 28218 RVA: 0x00240A88 File Offset: 0x0023EC88
		public string ItemTexture
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

		// Token: 0x06006E3B RID: 28219 RVA: 0x00240AC0 File Offset: 0x0023ECC0
		public Span<byte> GetItemTextureBytes()
		{
			return this.__p.__vector_as_span<byte>(60, 1);
		}

		// Token: 0x06006E3C RID: 28220 RVA: 0x00240AD0 File Offset: 0x0023ECD0
		public byte[] GetItemTextureArray()
		{
			return this.__p.__vector_as_array<byte>(60) ?? Array.Empty<byte>();
		}

		// Token: 0x17000F20 RID: 3872
		// (get) Token: 0x06006E3D RID: 28221 RVA: 0x00240AE8 File Offset: 0x0023ECE8
		public string ElementChangeLineColor
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

		// Token: 0x06006E3E RID: 28222 RVA: 0x00240B20 File Offset: 0x0023ED20
		public Span<byte> GetElementChangeLineColorBytes()
		{
			return this.__p.__vector_as_span<byte>(62, 1);
		}

		// Token: 0x06006E3F RID: 28223 RVA: 0x00240B30 File Offset: 0x0023ED30
		public byte[] GetElementChangeLineColorArray()
		{
			return this.__p.__vector_as_array<byte>(62) ?? Array.Empty<byte>();
		}

		// Token: 0x17000F21 RID: 3873
		// (get) Token: 0x06006E40 RID: 28224 RVA: 0x00240B48 File Offset: 0x0023ED48
		public string ElementChangeMainLineColor
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

		// Token: 0x06006E41 RID: 28225 RVA: 0x00240B80 File Offset: 0x0023ED80
		public Span<byte> GetElementChangeMainLineColorBytes()
		{
			return this.__p.__vector_as_span<byte>(64, 1);
		}

		// Token: 0x06006E42 RID: 28226 RVA: 0x00240B90 File Offset: 0x0023ED90
		public byte[] GetElementChangeMainLineColorArray()
		{
			return this.__p.__vector_as_array<byte>(64) ?? Array.Empty<byte>();
		}

		// Token: 0x17000F22 RID: 3874
		// (get) Token: 0x06006E43 RID: 28227 RVA: 0x00240BA8 File Offset: 0x0023EDA8
		public string ElementChangeIconBgColor
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

		// Token: 0x06006E44 RID: 28228 RVA: 0x00240BE0 File Offset: 0x0023EDE0
		public Span<byte> GetElementChangeIconBgColorBytes()
		{
			return this.__p.__vector_as_span<byte>(66, 1);
		}

		// Token: 0x06006E45 RID: 28229 RVA: 0x00240BF0 File Offset: 0x0023EDF0
		public byte[] GetElementChangeIconBgColorArray()
		{
			return this.__p.__vector_as_array<byte>(66) ?? Array.Empty<byte>();
		}

		// Token: 0x0400524A RID: 21066
		private Table __p;
	}
}
