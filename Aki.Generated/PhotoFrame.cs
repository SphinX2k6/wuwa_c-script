using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000FF2 RID: 4082
	public struct PhotoFrame : IFlatbufferObject
	{
		// Token: 0x17002854 RID: 10324
		// (get) Token: 0x0600B20B RID: 45579 RVA: 0x002D7568 File Offset: 0x002D5768
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600B20C RID: 45580 RVA: 0x002D7575 File Offset: 0x002D5775
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600B20D RID: 45581 RVA: 0x002D757C File Offset: 0x002D577C
		public static PhotoFrame GetRootAsPhotoFrame(ByteBuffer _bb)
		{
			return PhotoFrame.GetRootAsPhotoFrame(_bb, default(PhotoFrame));
		}

		// Token: 0x0600B20E RID: 45582 RVA: 0x002D7598 File Offset: 0x002D5798
		public static PhotoFrame GetRootAsPhotoFrame(ByteBuffer _bb, PhotoFrame obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600B20F RID: 45583 RVA: 0x002D75B5 File Offset: 0x002D57B5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600B210 RID: 45584 RVA: 0x002D75C4 File Offset: 0x002D57C4
		public PhotoFrame __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002855 RID: 10325
		// (get) Token: 0x0600B211 RID: 45585 RVA: 0x002D75D4 File Offset: 0x002D57D4
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

		// Token: 0x17002856 RID: 10326
		// (get) Token: 0x0600B212 RID: 45586 RVA: 0x002D7610 File Offset: 0x002D5810
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

		// Token: 0x0600B213 RID: 45587 RVA: 0x002D7647 File Offset: 0x002D5847
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600B214 RID: 45588 RVA: 0x002D7656 File Offset: 0x002D5856
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17002857 RID: 10327
		// (get) Token: 0x0600B215 RID: 45589 RVA: 0x002D7670 File Offset: 0x002D5870
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

		// Token: 0x0600B216 RID: 45590 RVA: 0x002D76A7 File Offset: 0x002D58A7
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600B217 RID: 45591 RVA: 0x002D76B6 File Offset: 0x002D58B6
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17002858 RID: 10328
		// (get) Token: 0x0600B218 RID: 45592 RVA: 0x002D76D0 File Offset: 0x002D58D0
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

		// Token: 0x17002859 RID: 10329
		// (get) Token: 0x0600B219 RID: 45593 RVA: 0x002D7710 File Offset: 0x002D5910
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

		// Token: 0x1700285A RID: 10330
		// (get) Token: 0x0600B21A RID: 45594 RVA: 0x002D7750 File Offset: 0x002D5950
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

		// Token: 0x1700285B RID: 10331
		// (get) Token: 0x0600B21B RID: 45595 RVA: 0x002D7790 File Offset: 0x002D5990
		public bool ShowDecoration
		{
			get
			{
				int num = this.__p.__offset(16);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700285C RID: 10332
		// (get) Token: 0x0600B21C RID: 45596 RVA: 0x002D77D0 File Offset: 0x002D59D0
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

		// Token: 0x1700285D RID: 10333
		// (get) Token: 0x0600B21D RID: 45597 RVA: 0x002D7814 File Offset: 0x002D5A14
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

		// Token: 0x1700285E RID: 10334
		// (get) Token: 0x0600B21E RID: 45598 RVA: 0x002D7858 File Offset: 0x002D5A58
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

		// Token: 0x1700285F RID: 10335
		// (get) Token: 0x0600B21F RID: 45599 RVA: 0x002D789C File Offset: 0x002D5A9C
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

		// Token: 0x17002860 RID: 10336
		// (get) Token: 0x0600B220 RID: 45600 RVA: 0x002D78E0 File Offset: 0x002D5AE0
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

		// Token: 0x17002861 RID: 10337
		// (get) Token: 0x0600B221 RID: 45601 RVA: 0x002D7924 File Offset: 0x002D5B24
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

		// Token: 0x0600B222 RID: 45602 RVA: 0x002D795C File Offset: 0x002D5B5C
		public Span<byte> GetMaskColorBytes()
		{
			return this.__p.__vector_as_span<byte>(28, 1);
		}

		// Token: 0x0600B223 RID: 45603 RVA: 0x002D796C File Offset: 0x002D5B6C
		public byte[] GetMaskColorArray()
		{
			return this.__p.__vector_as_array<byte>(28) ?? Array.Empty<byte>();
		}

		// Token: 0x17002862 RID: 10338
		// (get) Token: 0x0600B224 RID: 45604 RVA: 0x002D7984 File Offset: 0x002D5B84
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

		// Token: 0x17002863 RID: 10339
		// (get) Token: 0x0600B225 RID: 45605 RVA: 0x002D79C8 File Offset: 0x002D5BC8
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

		// Token: 0x17002864 RID: 10340
		// (get) Token: 0x0600B226 RID: 45606 RVA: 0x002D7A0C File Offset: 0x002D5C0C
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

		// Token: 0x17002865 RID: 10341
		// (get) Token: 0x0600B227 RID: 45607 RVA: 0x002D7A50 File Offset: 0x002D5C50
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

		// Token: 0x17002866 RID: 10342
		// (get) Token: 0x0600B228 RID: 45608 RVA: 0x002D7A94 File Offset: 0x002D5C94
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

		// Token: 0x17002867 RID: 10343
		// (get) Token: 0x0600B229 RID: 45609 RVA: 0x002D7AD8 File Offset: 0x002D5CD8
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

		// Token: 0x17002868 RID: 10344
		// (get) Token: 0x0600B22A RID: 45610 RVA: 0x002D7B1C File Offset: 0x002D5D1C
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

		// Token: 0x17002869 RID: 10345
		// (get) Token: 0x0600B22B RID: 45611 RVA: 0x002D7B60 File Offset: 0x002D5D60
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

		// Token: 0x1700286A RID: 10346
		// (get) Token: 0x0600B22C RID: 45612 RVA: 0x002D7BA4 File Offset: 0x002D5DA4
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

		// Token: 0x1700286B RID: 10347
		// (get) Token: 0x0600B22D RID: 45613 RVA: 0x002D7BE8 File Offset: 0x002D5DE8
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

		// Token: 0x1700286C RID: 10348
		// (get) Token: 0x0600B22E RID: 45614 RVA: 0x002D7C2C File Offset: 0x002D5E2C
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

		// Token: 0x1700286D RID: 10349
		// (get) Token: 0x0600B22F RID: 45615 RVA: 0x002D7C70 File Offset: 0x002D5E70
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

		// Token: 0x1700286E RID: 10350
		// (get) Token: 0x0600B230 RID: 45616 RVA: 0x002D7CB4 File Offset: 0x002D5EB4
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

		// Token: 0x1700286F RID: 10351
		// (get) Token: 0x0600B231 RID: 45617 RVA: 0x002D7CF8 File Offset: 0x002D5EF8
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

		// Token: 0x17002870 RID: 10352
		// (get) Token: 0x0600B232 RID: 45618 RVA: 0x002D7D3C File Offset: 0x002D5F3C
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

		// Token: 0x0600B233 RID: 45619 RVA: 0x002D7D74 File Offset: 0x002D5F74
		public Span<byte> GetShadowColorBytes()
		{
			return this.__p.__vector_as_span<byte>(58, 1);
		}

		// Token: 0x0600B234 RID: 45620 RVA: 0x002D7D84 File Offset: 0x002D5F84
		public byte[] GetShadowColorArray()
		{
			return this.__p.__vector_as_array<byte>(58) ?? Array.Empty<byte>();
		}

		// Token: 0x17002871 RID: 10353
		// (get) Token: 0x0600B235 RID: 45621 RVA: 0x002D7D9C File Offset: 0x002D5F9C
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

		// Token: 0x17002872 RID: 10354
		// (get) Token: 0x0600B236 RID: 45622 RVA: 0x002D7DE0 File Offset: 0x002D5FE0
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

		// Token: 0x17002873 RID: 10355
		// (get) Token: 0x0600B237 RID: 45623 RVA: 0x002D7E24 File Offset: 0x002D6024
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

		// Token: 0x17002874 RID: 10356
		// (get) Token: 0x0600B238 RID: 45624 RVA: 0x002D7E68 File Offset: 0x002D6068
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

		// Token: 0x0600B239 RID: 45625 RVA: 0x002D7EA0 File Offset: 0x002D60A0
		public Span<byte> GetEmissionColorBytes()
		{
			return this.__p.__vector_as_span<byte>(66, 1);
		}

		// Token: 0x0600B23A RID: 45626 RVA: 0x002D7EB0 File Offset: 0x002D60B0
		public byte[] GetEmissionColorArray()
		{
			return this.__p.__vector_as_array<byte>(66) ?? Array.Empty<byte>();
		}

		// Token: 0x17002875 RID: 10357
		// (get) Token: 0x0600B23B RID: 45627 RVA: 0x002D7EC8 File Offset: 0x002D60C8
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

		// Token: 0x17002876 RID: 10358
		// (get) Token: 0x0600B23C RID: 45628 RVA: 0x002D7F0C File Offset: 0x002D610C
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

		// Token: 0x17002877 RID: 10359
		// (get) Token: 0x0600B23D RID: 45629 RVA: 0x002D7F50 File Offset: 0x002D6150
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

		// Token: 0x0600B23E RID: 45630 RVA: 0x002D7F88 File Offset: 0x002D6188
		public Span<byte> GetTexturePathBytes()
		{
			return this.__p.__vector_as_span<byte>(72, 1);
		}

		// Token: 0x0600B23F RID: 45631 RVA: 0x002D7F98 File Offset: 0x002D6198
		public byte[] GetTexturePathArray()
		{
			return this.__p.__vector_as_array<byte>(72) ?? Array.Empty<byte>();
		}

		// Token: 0x040055BA RID: 21946
		private Table __p;
	}
}
