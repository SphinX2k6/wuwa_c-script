using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D3A RID: 3386
	public struct HonamiStoryItemQuality : IFlatbufferObject
	{
		// Token: 0x170017AD RID: 6061
		// (get) Token: 0x06007FDC RID: 32732 RVA: 0x0025749D File Offset: 0x0025569D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06007FDD RID: 32733 RVA: 0x002574AA File Offset: 0x002556AA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06007FDE RID: 32734 RVA: 0x002574B4 File Offset: 0x002556B4
		public static HonamiStoryItemQuality GetRootAsHonamiStoryItemQuality(ByteBuffer _bb)
		{
			return HonamiStoryItemQuality.GetRootAsHonamiStoryItemQuality(_bb, default(HonamiStoryItemQuality));
		}

		// Token: 0x06007FDF RID: 32735 RVA: 0x002574D0 File Offset: 0x002556D0
		public static HonamiStoryItemQuality GetRootAsHonamiStoryItemQuality(ByteBuffer _bb, HonamiStoryItemQuality obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06007FE0 RID: 32736 RVA: 0x002574ED File Offset: 0x002556ED
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06007FE1 RID: 32737 RVA: 0x002574FC File Offset: 0x002556FC
		public HonamiStoryItemQuality __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170017AE RID: 6062
		// (get) Token: 0x06007FE2 RID: 32738 RVA: 0x0025750C File Offset: 0x0025570C
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

		// Token: 0x170017AF RID: 6063
		// (get) Token: 0x06007FE3 RID: 32739 RVA: 0x00257548 File Offset: 0x00255748
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

		// Token: 0x06007FE4 RID: 32740 RVA: 0x0025757F File Offset: 0x0025577F
		public Span<byte> GetBgBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06007FE5 RID: 32741 RVA: 0x0025758E File Offset: 0x0025578E
		public byte[] GetBgArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x170017B0 RID: 6064
		// (get) Token: 0x06007FE6 RID: 32742 RVA: 0x002575A8 File Offset: 0x002557A8
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

		// Token: 0x06007FE7 RID: 32743 RVA: 0x002575DF File Offset: 0x002557DF
		public Span<byte> GetMeshBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06007FE8 RID: 32744 RVA: 0x002575EE File Offset: 0x002557EE
		public byte[] GetMeshArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x170017B1 RID: 6065
		// (get) Token: 0x06007FE9 RID: 32745 RVA: 0x00257608 File Offset: 0x00255808
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

		// Token: 0x06007FEA RID: 32746 RVA: 0x00257640 File Offset: 0x00255840
		public Span<byte> GetGridBgBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06007FEB RID: 32747 RVA: 0x00257650 File Offset: 0x00255850
		public byte[] GetGridBgArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x170017B2 RID: 6066
		// (get) Token: 0x06007FEC RID: 32748 RVA: 0x00257668 File Offset: 0x00255868
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

		// Token: 0x06007FED RID: 32749 RVA: 0x002576A0 File Offset: 0x002558A0
		public Span<byte> GetMediumItemGridQualitySpritePathBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06007FEE RID: 32750 RVA: 0x002576B0 File Offset: 0x002558B0
		public byte[] GetMediumItemGridQualitySpritePathArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x170017B3 RID: 6067
		// (get) Token: 0x06007FEF RID: 32751 RVA: 0x002576C8 File Offset: 0x002558C8
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

		// Token: 0x06007FF0 RID: 32752 RVA: 0x00257700 File Offset: 0x00255900
		public Span<byte> GetPayShopQualitySpriteBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x06007FF1 RID: 32753 RVA: 0x00257710 File Offset: 0x00255910
		public byte[] GetPayShopQualitySpriteArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x170017B4 RID: 6068
		// (get) Token: 0x06007FF2 RID: 32754 RVA: 0x00257728 File Offset: 0x00255928
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

		// Token: 0x06007FF3 RID: 32755 RVA: 0x00257760 File Offset: 0x00255960
		public Span<byte> GetQualityColorBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x06007FF4 RID: 32756 RVA: 0x00257770 File Offset: 0x00255970
		public byte[] GetQualityColorArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x170017B5 RID: 6069
		// (get) Token: 0x06007FF5 RID: 32757 RVA: 0x00257788 File Offset: 0x00255988
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

		// Token: 0x06007FF6 RID: 32758 RVA: 0x002577C0 File Offset: 0x002559C0
		public Span<byte> GetDropColorBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x06007FF7 RID: 32759 RVA: 0x002577D0 File Offset: 0x002559D0
		public byte[] GetDropColorArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x170017B6 RID: 6070
		// (get) Token: 0x06007FF8 RID: 32760 RVA: 0x002577E8 File Offset: 0x002559E8
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

		// Token: 0x06007FF9 RID: 32761 RVA: 0x00257820 File Offset: 0x00255A20
		public Span<byte> GetTipsQualityTexturePathBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x06007FFA RID: 32762 RVA: 0x00257830 File Offset: 0x00255A30
		public byte[] GetTipsQualityTexturePathArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x170017B7 RID: 6071
		// (get) Token: 0x06007FFB RID: 32763 RVA: 0x00257848 File Offset: 0x00255A48
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

		// Token: 0x06007FFC RID: 32764 RVA: 0x00257880 File Offset: 0x00255A80
		public Span<byte> GetAcquireNewItemQualityTexPathBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x06007FFD RID: 32765 RVA: 0x00257890 File Offset: 0x00255A90
		public byte[] GetAcquireNewItemQualityTexPathArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x170017B8 RID: 6072
		// (get) Token: 0x06007FFE RID: 32766 RVA: 0x002578A8 File Offset: 0x00255AA8
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

		// Token: 0x06007FFF RID: 32767 RVA: 0x002578E0 File Offset: 0x00255AE0
		public Span<byte> GetAcquireQualityTexPathBytes()
		{
			return this.__p.__vector_as_span<byte>(24, 1);
		}

		// Token: 0x06008000 RID: 32768 RVA: 0x002578F0 File Offset: 0x00255AF0
		public byte[] GetAcquireQualityTexPathArray()
		{
			return this.__p.__vector_as_array<byte>(24) ?? Array.Empty<byte>();
		}

		// Token: 0x170017B9 RID: 6073
		// (get) Token: 0x06008001 RID: 32769 RVA: 0x00257908 File Offset: 0x00255B08
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

		// Token: 0x06008002 RID: 32770 RVA: 0x00257940 File Offset: 0x00255B40
		public Span<byte> GetTextColorBytes()
		{
			return this.__p.__vector_as_span<byte>(26, 1);
		}

		// Token: 0x06008003 RID: 32771 RVA: 0x00257950 File Offset: 0x00255B50
		public byte[] GetTextColorArray()
		{
			return this.__p.__vector_as_array<byte>(26) ?? Array.Empty<byte>();
		}

		// Token: 0x170017BA RID: 6074
		// (get) Token: 0x06008004 RID: 32772 RVA: 0x00257968 File Offset: 0x00255B68
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

		// Token: 0x06008005 RID: 32773 RVA: 0x002579A0 File Offset: 0x00255BA0
		public Span<byte> GetAcquireQualitySpritePathBytes()
		{
			return this.__p.__vector_as_span<byte>(28, 1);
		}

		// Token: 0x06008006 RID: 32774 RVA: 0x002579B0 File Offset: 0x00255BB0
		public byte[] GetAcquireQualitySpritePathArray()
		{
			return this.__p.__vector_as_array<byte>(28) ?? Array.Empty<byte>();
		}

		// Token: 0x170017BB RID: 6075
		// (get) Token: 0x06008007 RID: 32775 RVA: 0x002579C8 File Offset: 0x00255BC8
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

		// Token: 0x06008008 RID: 32776 RVA: 0x00257A00 File Offset: 0x00255C00
		public Span<byte> GetInteractionHintColorBytes()
		{
			return this.__p.__vector_as_span<byte>(30, 1);
		}

		// Token: 0x06008009 RID: 32777 RVA: 0x00257A10 File Offset: 0x00255C10
		public byte[] GetInteractionHintColorArray()
		{
			return this.__p.__vector_as_array<byte>(30) ?? Array.Empty<byte>();
		}

		// Token: 0x170017BC RID: 6076
		// (get) Token: 0x0600800A RID: 32778 RVA: 0x00257A28 File Offset: 0x00255C28
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

		// Token: 0x0600800B RID: 32779 RVA: 0x00257A60 File Offset: 0x00255C60
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(32, 1);
		}

		// Token: 0x0600800C RID: 32780 RVA: 0x00257A70 File Offset: 0x00255C70
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(32) ?? Array.Empty<byte>();
		}

		// Token: 0x170017BD RID: 6077
		// (get) Token: 0x0600800D RID: 32781 RVA: 0x00257A88 File Offset: 0x00255C88
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

		// Token: 0x0600800E RID: 32782 RVA: 0x00257AC0 File Offset: 0x00255CC0
		public Span<byte> GetBackgroundSpriteBytes()
		{
			return this.__p.__vector_as_span<byte>(34, 1);
		}

		// Token: 0x0600800F RID: 32783 RVA: 0x00257AD0 File Offset: 0x00255CD0
		public byte[] GetBackgroundSpriteArray()
		{
			return this.__p.__vector_as_array<byte>(34) ?? Array.Empty<byte>();
		}

		// Token: 0x170017BE RID: 6078
		// (get) Token: 0x06008010 RID: 32784 RVA: 0x00257AE8 File Offset: 0x00255CE8
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

		// Token: 0x06008011 RID: 32785 RVA: 0x00257B20 File Offset: 0x00255D20
		public Span<byte> GetSpecialEffectsBytes()
		{
			return this.__p.__vector_as_span<byte>(36, 1);
		}

		// Token: 0x06008012 RID: 32786 RVA: 0x00257B30 File Offset: 0x00255D30
		public byte[] GetSpecialEffectsArray()
		{
			return this.__p.__vector_as_array<byte>(36) ?? Array.Empty<byte>();
		}

		// Token: 0x170017BF RID: 6079
		// (get) Token: 0x06008013 RID: 32787 RVA: 0x00257B48 File Offset: 0x00255D48
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

		// Token: 0x06008014 RID: 32788 RVA: 0x00257B80 File Offset: 0x00255D80
		public Span<byte> GetFilterIconPathBytes()
		{
			return this.__p.__vector_as_span<byte>(38, 1);
		}

		// Token: 0x06008015 RID: 32789 RVA: 0x00257B90 File Offset: 0x00255D90
		public byte[] GetFilterIconPathArray()
		{
			return this.__p.__vector_as_array<byte>(38) ?? Array.Empty<byte>();
		}

		// Token: 0x170017C0 RID: 6080
		// (get) Token: 0x06008016 RID: 32790 RVA: 0x00257BA8 File Offset: 0x00255DA8
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

		// Token: 0x06008017 RID: 32791 RVA: 0x00257BE0 File Offset: 0x00255DE0
		public Span<byte> GetTextureAcquireFlowBytes()
		{
			return this.__p.__vector_as_span<byte>(40, 1);
		}

		// Token: 0x06008018 RID: 32792 RVA: 0x00257BF0 File Offset: 0x00255DF0
		public byte[] GetTextureAcquireFlowArray()
		{
			return this.__p.__vector_as_array<byte>(40) ?? Array.Empty<byte>();
		}

		// Token: 0x170017C1 RID: 6081
		// (get) Token: 0x06008019 RID: 32793 RVA: 0x00257C08 File Offset: 0x00255E08
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

		// Token: 0x0600801A RID: 32794 RVA: 0x00257C40 File Offset: 0x00255E40
		public Span<byte> GetTextureAcquireBgBytes()
		{
			return this.__p.__vector_as_span<byte>(42, 1);
		}

		// Token: 0x0600801B RID: 32795 RVA: 0x00257C50 File Offset: 0x00255E50
		public byte[] GetTextureAcquireBgArray()
		{
			return this.__p.__vector_as_array<byte>(42) ?? Array.Empty<byte>();
		}

		// Token: 0x04004DB4 RID: 19892
		private Table __p;
	}
}
