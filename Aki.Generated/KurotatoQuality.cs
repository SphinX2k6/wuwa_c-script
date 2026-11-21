using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E94 RID: 3732
	public struct KurotatoQuality : IFlatbufferObject
	{
		// Token: 0x17001C69 RID: 7273
		// (get) Token: 0x06009159 RID: 37209 RVA: 0x002902F4 File Offset: 0x0028E4F4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600915A RID: 37210 RVA: 0x00290301 File Offset: 0x0028E501
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600915B RID: 37211 RVA: 0x00290308 File Offset: 0x0028E508
		public static KurotatoQuality GetRootAsKurotatoQuality(ByteBuffer _bb)
		{
			return KurotatoQuality.GetRootAsKurotatoQuality(_bb, default(KurotatoQuality));
		}

		// Token: 0x0600915C RID: 37212 RVA: 0x00290324 File Offset: 0x0028E524
		public static KurotatoQuality GetRootAsKurotatoQuality(ByteBuffer _bb, KurotatoQuality obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600915D RID: 37213 RVA: 0x00290341 File Offset: 0x0028E541
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600915E RID: 37214 RVA: 0x00290350 File Offset: 0x0028E550
		public KurotatoQuality __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001C6A RID: 7274
		// (get) Token: 0x0600915F RID: 37215 RVA: 0x00290360 File Offset: 0x0028E560
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

		// Token: 0x17001C6B RID: 7275
		// (get) Token: 0x06009160 RID: 37216 RVA: 0x0029039C File Offset: 0x0028E59C
		public string CardQualityTexture
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

		// Token: 0x06009161 RID: 37217 RVA: 0x002903D3 File Offset: 0x0028E5D3
		public Span<byte> GetCardQualityTextureBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06009162 RID: 37218 RVA: 0x002903E2 File Offset: 0x0028E5E2
		public byte[] GetCardQualityTextureArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17001C6C RID: 7276
		// (get) Token: 0x06009163 RID: 37219 RVA: 0x002903FC File Offset: 0x0028E5FC
		public string InfoQualityTexture
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

		// Token: 0x06009164 RID: 37220 RVA: 0x00290433 File Offset: 0x0028E633
		public Span<byte> GetInfoQualityTextureBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06009165 RID: 37221 RVA: 0x00290442 File Offset: 0x0028E642
		public byte[] GetInfoQualityTextureArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17001C6D RID: 7277
		// (get) Token: 0x06009166 RID: 37222 RVA: 0x0029045C File Offset: 0x0028E65C
		public string MediumItemGridQualitySpritePath
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

		// Token: 0x06009167 RID: 37223 RVA: 0x00290494 File Offset: 0x0028E694
		public Span<byte> GetMediumItemGridQualitySpritePathBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06009168 RID: 37224 RVA: 0x002904A4 File Offset: 0x0028E6A4
		public byte[] GetMediumItemGridQualitySpritePathArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17001C6E RID: 7278
		// (get) Token: 0x06009169 RID: 37225 RVA: 0x002904BC File Offset: 0x0028E6BC
		public int SmallItemGridQualityId
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

		// Token: 0x17001C6F RID: 7279
		// (get) Token: 0x0600916A RID: 37226 RVA: 0x002904FC File Offset: 0x0028E6FC
		public string QualityName
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

		// Token: 0x0600916B RID: 37227 RVA: 0x00290534 File Offset: 0x0028E734
		public Span<byte> GetQualityNameBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600916C RID: 37228 RVA: 0x00290544 File Offset: 0x0028E744
		public byte[] GetQualityNameArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17001C70 RID: 7280
		// (get) Token: 0x0600916D RID: 37229 RVA: 0x0029055C File Offset: 0x0028E75C
		public string QualityColor
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

		// Token: 0x0600916E RID: 37230 RVA: 0x00290594 File Offset: 0x0028E794
		public Span<byte> GetQualityColorBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600916F RID: 37231 RVA: 0x002905A4 File Offset: 0x0028E7A4
		public byte[] GetQualityColorArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x17001C71 RID: 7281
		// (get) Token: 0x06009170 RID: 37232 RVA: 0x002905BC File Offset: 0x0028E7BC
		public string QualityBoxColor
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

		// Token: 0x06009171 RID: 37233 RVA: 0x002905F4 File Offset: 0x0028E7F4
		public Span<byte> GetQualityBoxColorBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x06009172 RID: 37234 RVA: 0x00290604 File Offset: 0x0028E804
		public byte[] GetQualityBoxColorArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x17001C72 RID: 7282
		// (get) Token: 0x06009173 RID: 37235 RVA: 0x0029061C File Offset: 0x0028E81C
		public string AttrSelectQualityBg
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

		// Token: 0x06009174 RID: 37236 RVA: 0x00290654 File Offset: 0x0028E854
		public Span<byte> GetAttrSelectQualityBgBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x06009175 RID: 37237 RVA: 0x00290664 File Offset: 0x0028E864
		public byte[] GetAttrSelectQualityBgArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x17001C73 RID: 7283
		// (get) Token: 0x06009176 RID: 37238 RVA: 0x0029067C File Offset: 0x0028E87C
		public string AttrSelectCircleLight
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

		// Token: 0x06009177 RID: 37239 RVA: 0x002906B4 File Offset: 0x0028E8B4
		public Span<byte> GetAttrSelectCircleLightBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x06009178 RID: 37240 RVA: 0x002906C4 File Offset: 0x0028E8C4
		public byte[] GetAttrSelectCircleLightArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x17001C74 RID: 7284
		// (get) Token: 0x06009179 RID: 37241 RVA: 0x002906DC File Offset: 0x0028E8DC
		public string AttrSelectCircle
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

		// Token: 0x0600917A RID: 37242 RVA: 0x00290714 File Offset: 0x0028E914
		public Span<byte> GetAttrSelectCircleBytes()
		{
			return this.__p.__vector_as_span<byte>(24, 1);
		}

		// Token: 0x0600917B RID: 37243 RVA: 0x00290724 File Offset: 0x0028E924
		public byte[] GetAttrSelectCircleArray()
		{
			return this.__p.__vector_as_array<byte>(24) ?? Array.Empty<byte>();
		}

		// Token: 0x17001C75 RID: 7285
		// (get) Token: 0x0600917C RID: 37244 RVA: 0x0029073C File Offset: 0x0028E93C
		public string AttrSelectFrame
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

		// Token: 0x0600917D RID: 37245 RVA: 0x00290774 File Offset: 0x0028E974
		public Span<byte> GetAttrSelectFrameBytes()
		{
			return this.__p.__vector_as_span<byte>(26, 1);
		}

		// Token: 0x0600917E RID: 37246 RVA: 0x00290784 File Offset: 0x0028E984
		public byte[] GetAttrSelectFrameArray()
		{
			return this.__p.__vector_as_array<byte>(26) ?? Array.Empty<byte>();
		}

		// Token: 0x17001C76 RID: 7286
		// (get) Token: 0x0600917F RID: 37247 RVA: 0x0029079C File Offset: 0x0028E99C
		public string AttrSelectLineTexture
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

		// Token: 0x06009180 RID: 37248 RVA: 0x002907D4 File Offset: 0x0028E9D4
		public Span<byte> GetAttrSelectLineTextureBytes()
		{
			return this.__p.__vector_as_span<byte>(28, 1);
		}

		// Token: 0x06009181 RID: 37249 RVA: 0x002907E4 File Offset: 0x0028E9E4
		public byte[] GetAttrSelectLineTextureArray()
		{
			return this.__p.__vector_as_array<byte>(28) ?? Array.Empty<byte>();
		}

		// Token: 0x17001C77 RID: 7287
		// (get) Token: 0x06009182 RID: 37250 RVA: 0x002907FC File Offset: 0x0028E9FC
		public string ItemGridNiagaraColor
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

		// Token: 0x06009183 RID: 37251 RVA: 0x00290834 File Offset: 0x0028EA34
		public Span<byte> GetItemGridNiagaraColorBytes()
		{
			return this.__p.__vector_as_span<byte>(30, 1);
		}

		// Token: 0x06009184 RID: 37252 RVA: 0x00290844 File Offset: 0x0028EA44
		public byte[] GetItemGridNiagaraColorArray()
		{
			return this.__p.__vector_as_array<byte>(30) ?? Array.Empty<byte>();
		}

		// Token: 0x04005426 RID: 21542
		private Table __p;
	}
}
