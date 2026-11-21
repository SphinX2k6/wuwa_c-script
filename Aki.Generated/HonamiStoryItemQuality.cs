using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E1F RID: 3615
	public struct HonamiStoryItemQuality : IFlatbufferObject
	{
		// Token: 0x17001810 RID: 6160
		// (get) Token: 0x060085F6 RID: 34294 RVA: 0x00275C99 File Offset: 0x00273E99
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060085F7 RID: 34295 RVA: 0x00275CA6 File Offset: 0x00273EA6
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060085F8 RID: 34296 RVA: 0x00275CB0 File Offset: 0x00273EB0
		public static HonamiStoryItemQuality GetRootAsHonamiStoryItemQuality(ByteBuffer _bb)
		{
			return HonamiStoryItemQuality.GetRootAsHonamiStoryItemQuality(_bb, default(HonamiStoryItemQuality));
		}

		// Token: 0x060085F9 RID: 34297 RVA: 0x00275CCC File Offset: 0x00273ECC
		public static HonamiStoryItemQuality GetRootAsHonamiStoryItemQuality(ByteBuffer _bb, HonamiStoryItemQuality obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060085FA RID: 34298 RVA: 0x00275CE9 File Offset: 0x00273EE9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060085FB RID: 34299 RVA: 0x00275CF8 File Offset: 0x00273EF8
		public HonamiStoryItemQuality __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001811 RID: 6161
		// (get) Token: 0x060085FC RID: 34300 RVA: 0x00275D08 File Offset: 0x00273F08
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

		// Token: 0x17001812 RID: 6162
		// (get) Token: 0x060085FD RID: 34301 RVA: 0x00275D44 File Offset: 0x00273F44
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

		// Token: 0x060085FE RID: 34302 RVA: 0x00275D7B File Offset: 0x00273F7B
		public Span<byte> GetBgBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x060085FF RID: 34303 RVA: 0x00275D8A File Offset: 0x00273F8A
		public byte[] GetBgArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17001813 RID: 6163
		// (get) Token: 0x06008600 RID: 34304 RVA: 0x00275DA4 File Offset: 0x00273FA4
		public string Mesh
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

		// Token: 0x06008601 RID: 34305 RVA: 0x00275DDB File Offset: 0x00273FDB
		public Span<byte> GetMeshBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06008602 RID: 34306 RVA: 0x00275DEA File Offset: 0x00273FEA
		public byte[] GetMeshArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17001814 RID: 6164
		// (get) Token: 0x06008603 RID: 34307 RVA: 0x00275E04 File Offset: 0x00274004
		public string GridBg
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

		// Token: 0x06008604 RID: 34308 RVA: 0x00275E3C File Offset: 0x0027403C
		public Span<byte> GetGridBgBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06008605 RID: 34309 RVA: 0x00275E4C File Offset: 0x0027404C
		public byte[] GetGridBgArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17001815 RID: 6165
		// (get) Token: 0x06008606 RID: 34310 RVA: 0x00275E64 File Offset: 0x00274064
		public string MediumItemGridQualitySpritePath
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

		// Token: 0x06008607 RID: 34311 RVA: 0x00275E9C File Offset: 0x0027409C
		public Span<byte> GetMediumItemGridQualitySpritePathBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06008608 RID: 34312 RVA: 0x00275EAC File Offset: 0x002740AC
		public byte[] GetMediumItemGridQualitySpritePathArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17001816 RID: 6166
		// (get) Token: 0x06008609 RID: 34313 RVA: 0x00275EC4 File Offset: 0x002740C4
		public string PayShopQualitySprite
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

		// Token: 0x0600860A RID: 34314 RVA: 0x00275EFC File Offset: 0x002740FC
		public Span<byte> GetPayShopQualitySpriteBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600860B RID: 34315 RVA: 0x00275F0C File Offset: 0x0027410C
		public byte[] GetPayShopQualitySpriteArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17001817 RID: 6167
		// (get) Token: 0x0600860C RID: 34316 RVA: 0x00275F24 File Offset: 0x00274124
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

		// Token: 0x0600860D RID: 34317 RVA: 0x00275F5C File Offset: 0x0027415C
		public Span<byte> GetQualityColorBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600860E RID: 34318 RVA: 0x00275F6C File Offset: 0x0027416C
		public byte[] GetQualityColorArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x17001818 RID: 6168
		// (get) Token: 0x0600860F RID: 34319 RVA: 0x00275F84 File Offset: 0x00274184
		public string DropColor
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

		// Token: 0x06008610 RID: 34320 RVA: 0x00275FBC File Offset: 0x002741BC
		public Span<byte> GetDropColorBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x06008611 RID: 34321 RVA: 0x00275FCC File Offset: 0x002741CC
		public byte[] GetDropColorArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x17001819 RID: 6169
		// (get) Token: 0x06008612 RID: 34322 RVA: 0x00275FE4 File Offset: 0x002741E4
		public string TipsQualityTexturePath
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

		// Token: 0x06008613 RID: 34323 RVA: 0x0027601C File Offset: 0x0027421C
		public Span<byte> GetTipsQualityTexturePathBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x06008614 RID: 34324 RVA: 0x0027602C File Offset: 0x0027422C
		public byte[] GetTipsQualityTexturePathArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x1700181A RID: 6170
		// (get) Token: 0x06008615 RID: 34325 RVA: 0x00276044 File Offset: 0x00274244
		public string AcquireNewItemQualityTexPath
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

		// Token: 0x06008616 RID: 34326 RVA: 0x0027607C File Offset: 0x0027427C
		public Span<byte> GetAcquireNewItemQualityTexPathBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x06008617 RID: 34327 RVA: 0x0027608C File Offset: 0x0027428C
		public byte[] GetAcquireNewItemQualityTexPathArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x1700181B RID: 6171
		// (get) Token: 0x06008618 RID: 34328 RVA: 0x002760A4 File Offset: 0x002742A4
		public string AcquireQualityTexPath
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

		// Token: 0x06008619 RID: 34329 RVA: 0x002760DC File Offset: 0x002742DC
		public Span<byte> GetAcquireQualityTexPathBytes()
		{
			return this.__p.__vector_as_span<byte>(24, 1);
		}

		// Token: 0x0600861A RID: 34330 RVA: 0x002760EC File Offset: 0x002742EC
		public byte[] GetAcquireQualityTexPathArray()
		{
			return this.__p.__vector_as_array<byte>(24) ?? Array.Empty<byte>();
		}

		// Token: 0x1700181C RID: 6172
		// (get) Token: 0x0600861B RID: 34331 RVA: 0x00276104 File Offset: 0x00274304
		public string TextColor
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

		// Token: 0x0600861C RID: 34332 RVA: 0x0027613C File Offset: 0x0027433C
		public Span<byte> GetTextColorBytes()
		{
			return this.__p.__vector_as_span<byte>(26, 1);
		}

		// Token: 0x0600861D RID: 34333 RVA: 0x0027614C File Offset: 0x0027434C
		public byte[] GetTextColorArray()
		{
			return this.__p.__vector_as_array<byte>(26) ?? Array.Empty<byte>();
		}

		// Token: 0x1700181D RID: 6173
		// (get) Token: 0x0600861E RID: 34334 RVA: 0x00276164 File Offset: 0x00274364
		public string AcquireQualitySpritePath
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

		// Token: 0x0600861F RID: 34335 RVA: 0x0027619C File Offset: 0x0027439C
		public Span<byte> GetAcquireQualitySpritePathBytes()
		{
			return this.__p.__vector_as_span<byte>(28, 1);
		}

		// Token: 0x06008620 RID: 34336 RVA: 0x002761AC File Offset: 0x002743AC
		public byte[] GetAcquireQualitySpritePathArray()
		{
			return this.__p.__vector_as_array<byte>(28) ?? Array.Empty<byte>();
		}

		// Token: 0x1700181E RID: 6174
		// (get) Token: 0x06008621 RID: 34337 RVA: 0x002761C4 File Offset: 0x002743C4
		public string InteractionHintColor
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

		// Token: 0x06008622 RID: 34338 RVA: 0x002761FC File Offset: 0x002743FC
		public Span<byte> GetInteractionHintColorBytes()
		{
			return this.__p.__vector_as_span<byte>(30, 1);
		}

		// Token: 0x06008623 RID: 34339 RVA: 0x0027620C File Offset: 0x0027440C
		public byte[] GetInteractionHintColorArray()
		{
			return this.__p.__vector_as_array<byte>(30) ?? Array.Empty<byte>();
		}

		// Token: 0x1700181F RID: 6175
		// (get) Token: 0x06008624 RID: 34340 RVA: 0x00276224 File Offset: 0x00274424
		public string Name
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

		// Token: 0x06008625 RID: 34341 RVA: 0x0027625C File Offset: 0x0027445C
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(32, 1);
		}

		// Token: 0x06008626 RID: 34342 RVA: 0x0027626C File Offset: 0x0027446C
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(32) ?? Array.Empty<byte>();
		}

		// Token: 0x17001820 RID: 6176
		// (get) Token: 0x06008627 RID: 34343 RVA: 0x00276284 File Offset: 0x00274484
		public string BackgroundSprite
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

		// Token: 0x06008628 RID: 34344 RVA: 0x002762BC File Offset: 0x002744BC
		public Span<byte> GetBackgroundSpriteBytes()
		{
			return this.__p.__vector_as_span<byte>(34, 1);
		}

		// Token: 0x06008629 RID: 34345 RVA: 0x002762CC File Offset: 0x002744CC
		public byte[] GetBackgroundSpriteArray()
		{
			return this.__p.__vector_as_array<byte>(34) ?? Array.Empty<byte>();
		}

		// Token: 0x17001821 RID: 6177
		// (get) Token: 0x0600862A RID: 34346 RVA: 0x002762E4 File Offset: 0x002744E4
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

		// Token: 0x0600862B RID: 34347 RVA: 0x0027631C File Offset: 0x0027451C
		public Span<byte> GetSpecialEffectsBytes()
		{
			return this.__p.__vector_as_span<byte>(36, 1);
		}

		// Token: 0x0600862C RID: 34348 RVA: 0x0027632C File Offset: 0x0027452C
		public byte[] GetSpecialEffectsArray()
		{
			return this.__p.__vector_as_array<byte>(36) ?? Array.Empty<byte>();
		}

		// Token: 0x17001822 RID: 6178
		// (get) Token: 0x0600862D RID: 34349 RVA: 0x00276344 File Offset: 0x00274544
		public string FilterIconPath
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

		// Token: 0x0600862E RID: 34350 RVA: 0x0027637C File Offset: 0x0027457C
		public Span<byte> GetFilterIconPathBytes()
		{
			return this.__p.__vector_as_span<byte>(38, 1);
		}

		// Token: 0x0600862F RID: 34351 RVA: 0x0027638C File Offset: 0x0027458C
		public byte[] GetFilterIconPathArray()
		{
			return this.__p.__vector_as_array<byte>(38) ?? Array.Empty<byte>();
		}

		// Token: 0x17001823 RID: 6179
		// (get) Token: 0x06008630 RID: 34352 RVA: 0x002763A4 File Offset: 0x002745A4
		public string TextureAcquireFlow
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

		// Token: 0x06008631 RID: 34353 RVA: 0x002763DC File Offset: 0x002745DC
		public Span<byte> GetTextureAcquireFlowBytes()
		{
			return this.__p.__vector_as_span<byte>(40, 1);
		}

		// Token: 0x06008632 RID: 34354 RVA: 0x002763EC File Offset: 0x002745EC
		public byte[] GetTextureAcquireFlowArray()
		{
			return this.__p.__vector_as_array<byte>(40) ?? Array.Empty<byte>();
		}

		// Token: 0x17001824 RID: 6180
		// (get) Token: 0x06008633 RID: 34355 RVA: 0x00276404 File Offset: 0x00274604
		public string TextureAcquireBg
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

		// Token: 0x06008634 RID: 34356 RVA: 0x0027643C File Offset: 0x0027463C
		public Span<byte> GetTextureAcquireBgBytes()
		{
			return this.__p.__vector_as_span<byte>(42, 1);
		}

		// Token: 0x06008635 RID: 34357 RVA: 0x0027644C File Offset: 0x0027464C
		public byte[] GetTextureAcquireBgArray()
		{
			return this.__p.__vector_as_array<byte>(42) ?? Array.Empty<byte>();
		}

		// Token: 0x04005399 RID: 21401
		private Table __p;
	}
}
