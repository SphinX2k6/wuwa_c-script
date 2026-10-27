using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F0D RID: 3853
	public struct PhotoFrame : IFlatbufferObject
	{
		// Token: 0x170027EE RID: 10222
		// (get) Token: 0x0600ABEA RID: 44010 RVA: 0x002BA8BC File Offset: 0x002B8ABC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600ABEB RID: 44011 RVA: 0x002BA8C9 File Offset: 0x002B8AC9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600ABEC RID: 44012 RVA: 0x002BA8D0 File Offset: 0x002B8AD0
		public static PhotoFrame GetRootAsPhotoFrame(ByteBuffer _bb)
		{
			return PhotoFrame.GetRootAsPhotoFrame(_bb, default(PhotoFrame));
		}

		// Token: 0x0600ABED RID: 44013 RVA: 0x002BA8EC File Offset: 0x002B8AEC
		public static PhotoFrame GetRootAsPhotoFrame(ByteBuffer _bb, PhotoFrame obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600ABEE RID: 44014 RVA: 0x002BA909 File Offset: 0x002B8B09
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600ABEF RID: 44015 RVA: 0x002BA918 File Offset: 0x002B8B18
		public PhotoFrame __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170027EF RID: 10223
		// (get) Token: 0x0600ABF0 RID: 44016 RVA: 0x002BA928 File Offset: 0x002B8B28
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

		// Token: 0x170027F0 RID: 10224
		// (get) Token: 0x0600ABF1 RID: 44017 RVA: 0x002BA964 File Offset: 0x002B8B64
		public string Icon
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

		// Token: 0x0600ABF2 RID: 44018 RVA: 0x002BA99B File Offset: 0x002B8B9B
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600ABF3 RID: 44019 RVA: 0x002BA9AA File Offset: 0x002B8BAA
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x170027F1 RID: 10225
		// (get) Token: 0x0600ABF4 RID: 44020 RVA: 0x002BA9C4 File Offset: 0x002B8BC4
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

		// Token: 0x0600ABF5 RID: 44021 RVA: 0x002BA9FB File Offset: 0x002B8BFB
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600ABF6 RID: 44022 RVA: 0x002BAA0A File Offset: 0x002B8C0A
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x170027F2 RID: 10226
		// (get) Token: 0x0600ABF7 RID: 44023 RVA: 0x002BAA24 File Offset: 0x002B8C24
		public int RelativeItem
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170027F3 RID: 10227
		// (get) Token: 0x0600ABF8 RID: 44024 RVA: 0x002BAA64 File Offset: 0x002B8C64
		public int SortId
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

		// Token: 0x170027F4 RID: 10228
		// (get) Token: 0x0600ABF9 RID: 44025 RVA: 0x002BAAA4 File Offset: 0x002B8CA4
		public int Mode
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

		// Token: 0x170027F5 RID: 10229
		// (get) Token: 0x0600ABFA RID: 44026 RVA: 0x002BAAE4 File Offset: 0x002B8CE4
		public bool ShowDecoration
		{
			get
			{
				int num = this.__p.__offset(16);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170027F6 RID: 10230
		// (get) Token: 0x0600ABFB RID: 44027 RVA: 0x002BAB24 File Offset: 0x002B8D24
		public float MaskWidth
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 1f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170027F7 RID: 10231
		// (get) Token: 0x0600ABFC RID: 44028 RVA: 0x002BAB68 File Offset: 0x002B8D68
		public float MaskHeight
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return 1f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170027F8 RID: 10232
		// (get) Token: 0x0600ABFD RID: 44029 RVA: 0x002BABAC File Offset: 0x002B8DAC
		public float RhombusRadius
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return 1f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170027F9 RID: 10233
		// (get) Token: 0x0600ABFE RID: 44030 RVA: 0x002BABF0 File Offset: 0x002B8DF0
		public float CircleMaskRadius
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return 1f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170027FA RID: 10234
		// (get) Token: 0x0600ABFF RID: 44031 RVA: 0x002BAC34 File Offset: 0x002B8E34
		public float CircleMaskSoftness
		{
			get
			{
				int num = this.__p.__offset(26);
				if (num == 0)
				{
					return 1f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170027FB RID: 10235
		// (get) Token: 0x0600AC00 RID: 44032 RVA: 0x002BAC78 File Offset: 0x002B8E78
		public string MaskColor
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

		// Token: 0x0600AC01 RID: 44033 RVA: 0x002BACB0 File Offset: 0x002B8EB0
		public Span<byte> GetMaskColorBytes()
		{
			return this.__p.__vector_as_span<byte>(28, 1);
		}

		// Token: 0x0600AC02 RID: 44034 RVA: 0x002BACC0 File Offset: 0x002B8EC0
		public byte[] GetMaskColorArray()
		{
			return this.__p.__vector_as_array<byte>(28) ?? Array.Empty<byte>();
		}

		// Token: 0x170027FC RID: 10236
		// (get) Token: 0x0600AC03 RID: 44035 RVA: 0x002BACD8 File Offset: 0x002B8ED8
		public float BackgroundStrength
		{
			get
			{
				int num = this.__p.__offset(30);
				if (num == 0)
				{
					return 0.5f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170027FD RID: 10237
		// (get) Token: 0x0600AC04 RID: 44036 RVA: 0x002BAD1C File Offset: 0x002B8F1C
		public float RotationAngle
		{
			get
			{
				int num = this.__p.__offset(32);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170027FE RID: 10238
		// (get) Token: 0x0600AC05 RID: 44037 RVA: 0x002BAD60 File Offset: 0x002B8F60
		public float PreviewBlurIntensity
		{
			get
			{
				int num = this.__p.__offset(34);
				if (num == 0)
				{
					return 2f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170027FF RID: 10239
		// (get) Token: 0x0600AC06 RID: 44038 RVA: 0x002BADA4 File Offset: 0x002B8FA4
		public float CaptureBlurIntensity
		{
			get
			{
				int num = this.__p.__offset(36);
				if (num == 0)
				{
					return 3f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17002800 RID: 10240
		// (get) Token: 0x0600AC07 RID: 44039 RVA: 0x002BADE8 File Offset: 0x002B8FE8
		public float CircleRadius
		{
			get
			{
				int num = this.__p.__offset(38);
				if (num == 0)
				{
					return 0.03f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17002801 RID: 10241
		// (get) Token: 0x0600AC08 RID: 44040 RVA: 0x002BAE2C File Offset: 0x002B902C
		public float FrameThickness
		{
			get
			{
				int num = this.__p.__offset(40);
				if (num == 0)
				{
					return 0.003f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17002802 RID: 10242
		// (get) Token: 0x0600AC09 RID: 44041 RVA: 0x002BAE70 File Offset: 0x002B9070
		public float LineThickness
		{
			get
			{
				int num = this.__p.__offset(42);
				if (num == 0)
				{
					return 0.0005f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17002803 RID: 10243
		// (get) Token: 0x0600AC0A RID: 44042 RVA: 0x002BAEB4 File Offset: 0x002B90B4
		public float ScreenRatio
		{
			get
			{
				int num = this.__p.__offset(44);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17002804 RID: 10244
		// (get) Token: 0x0600AC0B RID: 44043 RVA: 0x002BAEF8 File Offset: 0x002B90F8
		public float AspectRatio
		{
			get
			{
				int num = this.__p.__offset(46);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17002805 RID: 10245
		// (get) Token: 0x0600AC0C RID: 44044 RVA: 0x002BAF3C File Offset: 0x002B913C
		public float LengthRatio
		{
			get
			{
				int num = this.__p.__offset(48);
				if (num == 0)
				{
					return 1f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17002806 RID: 10246
		// (get) Token: 0x0600AC0D RID: 44045 RVA: 0x002BAF80 File Offset: 0x002B9180
		public float WidthRatio
		{
			get
			{
				int num = this.__p.__offset(50);
				if (num == 0)
				{
					return 1f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17002807 RID: 10247
		// (get) Token: 0x0600AC0E RID: 44046 RVA: 0x002BAFC4 File Offset: 0x002B91C4
		public float ShadowPower
		{
			get
			{
				int num = this.__p.__offset(52);
				if (num == 0)
				{
					return 0.7f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17002808 RID: 10248
		// (get) Token: 0x0600AC0F RID: 44047 RVA: 0x002BB008 File Offset: 0x002B9208
		public float ShadowRange
		{
			get
			{
				int num = this.__p.__offset(54);
				if (num == 0)
				{
					return 0.03f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17002809 RID: 10249
		// (get) Token: 0x0600AC10 RID: 44048 RVA: 0x002BB04C File Offset: 0x002B924C
		public float ShadowStrength
		{
			get
			{
				int num = this.__p.__offset(56);
				if (num == 0)
				{
					return 0.03f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700280A RID: 10250
		// (get) Token: 0x0600AC11 RID: 44049 RVA: 0x002BB090 File Offset: 0x002B9290
		public string ShadowColor
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

		// Token: 0x0600AC12 RID: 44050 RVA: 0x002BB0C8 File Offset: 0x002B92C8
		public Span<byte> GetShadowColorBytes()
		{
			return this.__p.__vector_as_span<byte>(58, 1);
		}

		// Token: 0x0600AC13 RID: 44051 RVA: 0x002BB0D8 File Offset: 0x002B92D8
		public byte[] GetShadowColorArray()
		{
			return this.__p.__vector_as_array<byte>(58) ?? Array.Empty<byte>();
		}

		// Token: 0x1700280B RID: 10251
		// (get) Token: 0x0600AC14 RID: 44052 RVA: 0x002BB0F0 File Offset: 0x002B92F0
		public float EmissionPower
		{
			get
			{
				int num = this.__p.__offset(60);
				if (num == 0)
				{
					return 0.7f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700280C RID: 10252
		// (get) Token: 0x0600AC15 RID: 44053 RVA: 0x002BB134 File Offset: 0x002B9334
		public float EmissionRange
		{
			get
			{
				int num = this.__p.__offset(62);
				if (num == 0)
				{
					return 0.03f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700280D RID: 10253
		// (get) Token: 0x0600AC16 RID: 44054 RVA: 0x002BB178 File Offset: 0x002B9378
		public float EmissionStrength
		{
			get
			{
				int num = this.__p.__offset(64);
				if (num == 0)
				{
					return 0.03f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700280E RID: 10254
		// (get) Token: 0x0600AC17 RID: 44055 RVA: 0x002BB1BC File Offset: 0x002B93BC
		public string EmissionColor
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

		// Token: 0x0600AC18 RID: 44056 RVA: 0x002BB1F4 File Offset: 0x002B93F4
		public Span<byte> GetEmissionColorBytes()
		{
			return this.__p.__vector_as_span<byte>(66, 1);
		}

		// Token: 0x0600AC19 RID: 44057 RVA: 0x002BB204 File Offset: 0x002B9404
		public byte[] GetEmissionColorArray()
		{
			return this.__p.__vector_as_array<byte>(66) ?? Array.Empty<byte>();
		}

		// Token: 0x1700280F RID: 10255
		// (get) Token: 0x0600AC1A RID: 44058 RVA: 0x002BB21C File Offset: 0x002B941C
		public float PositionHorizon
		{
			get
			{
				int num = this.__p.__offset(68);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17002810 RID: 10256
		// (get) Token: 0x0600AC1B RID: 44059 RVA: 0x002BB260 File Offset: 0x002B9460
		public float PositionVertical
		{
			get
			{
				int num = this.__p.__offset(70);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17002811 RID: 10257
		// (get) Token: 0x0600AC1C RID: 44060 RVA: 0x002BB2A4 File Offset: 0x002B94A4
		public string TexturePath
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

		// Token: 0x0600AC1D RID: 44061 RVA: 0x002BB2DC File Offset: 0x002B94DC
		public Span<byte> GetTexturePathBytes()
		{
			return this.__p.__vector_as_span<byte>(72, 1);
		}

		// Token: 0x0600AC1E RID: 44062 RVA: 0x002BB2EC File Offset: 0x002B94EC
		public byte[] GetTexturePathArray()
		{
			return this.__p.__vector_as_array<byte>(72) ?? Array.Empty<byte>();
		}

		// Token: 0x04004FD5 RID: 20437
		private Table __p;
	}
}
