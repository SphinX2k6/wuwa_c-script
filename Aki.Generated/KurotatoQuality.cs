using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000DAF RID: 3503
	public struct KurotatoQuality : IFlatbufferObject
	{
		// Token: 0x17001C05 RID: 7173
		// (get) Token: 0x06008B3D RID: 35645 RVA: 0x00271998 File Offset: 0x0026FB98
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06008B3E RID: 35646 RVA: 0x002719A5 File Offset: 0x0026FBA5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06008B3F RID: 35647 RVA: 0x002719AC File Offset: 0x0026FBAC
		public static KurotatoQuality GetRootAsKurotatoQuality(ByteBuffer _bb)
		{
			return KurotatoQuality.GetRootAsKurotatoQuality(_bb, default(KurotatoQuality));
		}

		// Token: 0x06008B40 RID: 35648 RVA: 0x002719C8 File Offset: 0x0026FBC8
		public static KurotatoQuality GetRootAsKurotatoQuality(ByteBuffer _bb, KurotatoQuality obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06008B41 RID: 35649 RVA: 0x002719E5 File Offset: 0x0026FBE5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06008B42 RID: 35650 RVA: 0x002719F4 File Offset: 0x0026FBF4
		public KurotatoQuality __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001C06 RID: 7174
		// (get) Token: 0x06008B43 RID: 35651 RVA: 0x00271A04 File Offset: 0x0026FC04
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

		// Token: 0x17001C07 RID: 7175
		// (get) Token: 0x06008B44 RID: 35652 RVA: 0x00271A40 File Offset: 0x0026FC40
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

		// Token: 0x06008B45 RID: 35653 RVA: 0x00271A77 File Offset: 0x0026FC77
		public Span<byte> GetCardQualityTextureBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06008B46 RID: 35654 RVA: 0x00271A86 File Offset: 0x0026FC86
		public byte[] GetCardQualityTextureArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17001C08 RID: 7176
		// (get) Token: 0x06008B47 RID: 35655 RVA: 0x00271AA0 File Offset: 0x0026FCA0
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

		// Token: 0x06008B48 RID: 35656 RVA: 0x00271AD7 File Offset: 0x0026FCD7
		public Span<byte> GetInfoQualityTextureBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06008B49 RID: 35657 RVA: 0x00271AE6 File Offset: 0x0026FCE6
		public byte[] GetInfoQualityTextureArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17001C09 RID: 7177
		// (get) Token: 0x06008B4A RID: 35658 RVA: 0x00271B00 File Offset: 0x0026FD00
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

		// Token: 0x06008B4B RID: 35659 RVA: 0x00271B38 File Offset: 0x0026FD38
		public Span<byte> GetMediumItemGridQualitySpritePathBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06008B4C RID: 35660 RVA: 0x00271B48 File Offset: 0x0026FD48
		public byte[] GetMediumItemGridQualitySpritePathArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17001C0A RID: 7178
		// (get) Token: 0x06008B4D RID: 35661 RVA: 0x00271B60 File Offset: 0x0026FD60
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

		// Token: 0x17001C0B RID: 7179
		// (get) Token: 0x06008B4E RID: 35662 RVA: 0x00271BA0 File Offset: 0x0026FDA0
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

		// Token: 0x06008B4F RID: 35663 RVA: 0x00271BD8 File Offset: 0x0026FDD8
		public Span<byte> GetQualityNameBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x06008B50 RID: 35664 RVA: 0x00271BE8 File Offset: 0x0026FDE8
		public byte[] GetQualityNameArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17001C0C RID: 7180
		// (get) Token: 0x06008B51 RID: 35665 RVA: 0x00271C00 File Offset: 0x0026FE00
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

		// Token: 0x06008B52 RID: 35666 RVA: 0x00271C38 File Offset: 0x0026FE38
		public Span<byte> GetQualityColorBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x06008B53 RID: 35667 RVA: 0x00271C48 File Offset: 0x0026FE48
		public byte[] GetQualityColorArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x17001C0D RID: 7181
		// (get) Token: 0x06008B54 RID: 35668 RVA: 0x00271C60 File Offset: 0x0026FE60
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

		// Token: 0x06008B55 RID: 35669 RVA: 0x00271C98 File Offset: 0x0026FE98
		public Span<byte> GetQualityBoxColorBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x06008B56 RID: 35670 RVA: 0x00271CA8 File Offset: 0x0026FEA8
		public byte[] GetQualityBoxColorArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x17001C0E RID: 7182
		// (get) Token: 0x06008B57 RID: 35671 RVA: 0x00271CC0 File Offset: 0x0026FEC0
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

		// Token: 0x06008B58 RID: 35672 RVA: 0x00271CF8 File Offset: 0x0026FEF8
		public Span<byte> GetAttrSelectQualityBgBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x06008B59 RID: 35673 RVA: 0x00271D08 File Offset: 0x0026FF08
		public byte[] GetAttrSelectQualityBgArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x17001C0F RID: 7183
		// (get) Token: 0x06008B5A RID: 35674 RVA: 0x00271D20 File Offset: 0x0026FF20
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

		// Token: 0x06008B5B RID: 35675 RVA: 0x00271D58 File Offset: 0x0026FF58
		public Span<byte> GetAttrSelectCircleLightBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x06008B5C RID: 35676 RVA: 0x00271D68 File Offset: 0x0026FF68
		public byte[] GetAttrSelectCircleLightArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x17001C10 RID: 7184
		// (get) Token: 0x06008B5D RID: 35677 RVA: 0x00271D80 File Offset: 0x0026FF80
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

		// Token: 0x06008B5E RID: 35678 RVA: 0x00271DB8 File Offset: 0x0026FFB8
		public Span<byte> GetAttrSelectCircleBytes()
		{
			return this.__p.__vector_as_span<byte>(24, 1);
		}

		// Token: 0x06008B5F RID: 35679 RVA: 0x00271DC8 File Offset: 0x0026FFC8
		public byte[] GetAttrSelectCircleArray()
		{
			return this.__p.__vector_as_array<byte>(24) ?? Array.Empty<byte>();
		}

		// Token: 0x17001C11 RID: 7185
		// (get) Token: 0x06008B60 RID: 35680 RVA: 0x00271DE0 File Offset: 0x0026FFE0
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

		// Token: 0x06008B61 RID: 35681 RVA: 0x00271E18 File Offset: 0x00270018
		public Span<byte> GetAttrSelectFrameBytes()
		{
			return this.__p.__vector_as_span<byte>(26, 1);
		}

		// Token: 0x06008B62 RID: 35682 RVA: 0x00271E28 File Offset: 0x00270028
		public byte[] GetAttrSelectFrameArray()
		{
			return this.__p.__vector_as_array<byte>(26) ?? Array.Empty<byte>();
		}

		// Token: 0x17001C12 RID: 7186
		// (get) Token: 0x06008B63 RID: 35683 RVA: 0x00271E40 File Offset: 0x00270040
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

		// Token: 0x06008B64 RID: 35684 RVA: 0x00271E78 File Offset: 0x00270078
		public Span<byte> GetAttrSelectLineTextureBytes()
		{
			return this.__p.__vector_as_span<byte>(28, 1);
		}

		// Token: 0x06008B65 RID: 35685 RVA: 0x00271E88 File Offset: 0x00270088
		public byte[] GetAttrSelectLineTextureArray()
		{
			return this.__p.__vector_as_array<byte>(28) ?? Array.Empty<byte>();
		}

		// Token: 0x17001C13 RID: 7187
		// (get) Token: 0x06008B66 RID: 35686 RVA: 0x00271EA0 File Offset: 0x002700A0
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

		// Token: 0x06008B67 RID: 35687 RVA: 0x00271ED8 File Offset: 0x002700D8
		public Span<byte> GetItemGridNiagaraColorBytes()
		{
			return this.__p.__vector_as_span<byte>(30, 1);
		}

		// Token: 0x06008B68 RID: 35688 RVA: 0x00271EE8 File Offset: 0x002700E8
		public byte[] GetItemGridNiagaraColorArray()
		{
			return this.__p.__vector_as_array<byte>(30) ?? Array.Empty<byte>();
		}

		// Token: 0x04004E41 RID: 20033
		private Table __p;
	}
}
