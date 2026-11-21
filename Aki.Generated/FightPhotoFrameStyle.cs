using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D4D RID: 3405
	public struct FightPhotoFrameStyle : IFlatbufferObject
	{
		// Token: 0x1700110D RID: 4365
		// (get) Token: 0x060073C8 RID: 29640 RVA: 0x0024C755 File Offset: 0x0024A955
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060073C9 RID: 29641 RVA: 0x0024C762 File Offset: 0x0024A962
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060073CA RID: 29642 RVA: 0x0024C76C File Offset: 0x0024A96C
		public static FightPhotoFrameStyle GetRootAsFightPhotoFrameStyle(ByteBuffer _bb)
		{
			return FightPhotoFrameStyle.GetRootAsFightPhotoFrameStyle(_bb, default(FightPhotoFrameStyle));
		}

		// Token: 0x060073CB RID: 29643 RVA: 0x0024C788 File Offset: 0x0024A988
		public static FightPhotoFrameStyle GetRootAsFightPhotoFrameStyle(ByteBuffer _bb, FightPhotoFrameStyle obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060073CC RID: 29644 RVA: 0x0024C7A5 File Offset: 0x0024A9A5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060073CD RID: 29645 RVA: 0x0024C7B4 File Offset: 0x0024A9B4
		public FightPhotoFrameStyle __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700110E RID: 4366
		// (get) Token: 0x060073CE RID: 29646 RVA: 0x0024C7C4 File Offset: 0x0024A9C4
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

		// Token: 0x1700110F RID: 4367
		// (get) Token: 0x060073CF RID: 29647 RVA: 0x0024C800 File Offset: 0x0024AA00
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

		// Token: 0x060073D0 RID: 29648 RVA: 0x0024C837 File Offset: 0x0024AA37
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x060073D1 RID: 29649 RVA: 0x0024C846 File Offset: 0x0024AA46
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17001110 RID: 4368
		// (get) Token: 0x060073D2 RID: 29650 RVA: 0x0024C860 File Offset: 0x0024AA60
		public string Picture
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

		// Token: 0x060073D3 RID: 29651 RVA: 0x0024C897 File Offset: 0x0024AA97
		public Span<byte> GetPictureBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x060073D4 RID: 29652 RVA: 0x0024C8A6 File Offset: 0x0024AAA6
		public byte[] GetPictureArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17001111 RID: 4369
		// (get) Token: 0x060073D5 RID: 29653 RVA: 0x0024C8C0 File Offset: 0x0024AAC0
		public int SortId
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

		// Token: 0x17001112 RID: 4370
		// (get) Token: 0x060073D6 RID: 29654 RVA: 0x0024C900 File Offset: 0x0024AB00
		public int Mode
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

		// Token: 0x17001113 RID: 4371
		// (get) Token: 0x060073D7 RID: 29655 RVA: 0x0024C940 File Offset: 0x0024AB40
		public bool ShowDecoration
		{
			get
			{
				int num = this.__p.__offset(14);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17001114 RID: 4372
		// (get) Token: 0x060073D8 RID: 29656 RVA: 0x0024C980 File Offset: 0x0024AB80
		public float MaskWidth
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 1f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001115 RID: 4373
		// (get) Token: 0x060073D9 RID: 29657 RVA: 0x0024C9C4 File Offset: 0x0024ABC4
		public float MaskHeight
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

		// Token: 0x17001116 RID: 4374
		// (get) Token: 0x060073DA RID: 29658 RVA: 0x0024CA08 File Offset: 0x0024AC08
		public string MaskColor
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

		// Token: 0x060073DB RID: 29659 RVA: 0x0024CA40 File Offset: 0x0024AC40
		public Span<byte> GetMaskColorBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x060073DC RID: 29660 RVA: 0x0024CA50 File Offset: 0x0024AC50
		public byte[] GetMaskColorArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x17001117 RID: 4375
		// (get) Token: 0x060073DD RID: 29661 RVA: 0x0024CA68 File Offset: 0x0024AC68
		public float BackgroundStrength
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return 0.5f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001118 RID: 4376
		// (get) Token: 0x060073DE RID: 29662 RVA: 0x0024CAAC File Offset: 0x0024ACAC
		public float RotationAngle
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001119 RID: 4377
		// (get) Token: 0x060073DF RID: 29663 RVA: 0x0024CAF0 File Offset: 0x0024ACF0
		public float PreviewBlurIntensity
		{
			get
			{
				int num = this.__p.__offset(26);
				if (num == 0)
				{
					return 2f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700111A RID: 4378
		// (get) Token: 0x060073E0 RID: 29664 RVA: 0x0024CB34 File Offset: 0x0024AD34
		public float CaptureBlurIntensity
		{
			get
			{
				int num = this.__p.__offset(28);
				if (num == 0)
				{
					return 3f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700111B RID: 4379
		// (get) Token: 0x060073E1 RID: 29665 RVA: 0x0024CB78 File Offset: 0x0024AD78
		public float CircleRadius
		{
			get
			{
				int num = this.__p.__offset(30);
				if (num == 0)
				{
					return 0.03f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700111C RID: 4380
		// (get) Token: 0x060073E2 RID: 29666 RVA: 0x0024CBBC File Offset: 0x0024ADBC
		public float FrameThickness
		{
			get
			{
				int num = this.__p.__offset(32);
				if (num == 0)
				{
					return 0.003f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700111D RID: 4381
		// (get) Token: 0x060073E3 RID: 29667 RVA: 0x0024CC00 File Offset: 0x0024AE00
		public float LineThickness
		{
			get
			{
				int num = this.__p.__offset(34);
				if (num == 0)
				{
					return 0.0005f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700111E RID: 4382
		// (get) Token: 0x060073E4 RID: 29668 RVA: 0x0024CC44 File Offset: 0x0024AE44
		public float ScreenRatio
		{
			get
			{
				int num = this.__p.__offset(36);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700111F RID: 4383
		// (get) Token: 0x060073E5 RID: 29669 RVA: 0x0024CC88 File Offset: 0x0024AE88
		public float AspectRatio
		{
			get
			{
				int num = this.__p.__offset(38);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001120 RID: 4384
		// (get) Token: 0x060073E6 RID: 29670 RVA: 0x0024CCCC File Offset: 0x0024AECC
		public float ShadowPower
		{
			get
			{
				int num = this.__p.__offset(40);
				if (num == 0)
				{
					return 0.7f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001121 RID: 4385
		// (get) Token: 0x060073E7 RID: 29671 RVA: 0x0024CD10 File Offset: 0x0024AF10
		public float ShadowRange
		{
			get
			{
				int num = this.__p.__offset(42);
				if (num == 0)
				{
					return 0.03f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001122 RID: 4386
		// (get) Token: 0x060073E8 RID: 29672 RVA: 0x0024CD54 File Offset: 0x0024AF54
		public float ShadowStrength
		{
			get
			{
				int num = this.__p.__offset(44);
				if (num == 0)
				{
					return 0.03f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001123 RID: 4387
		// (get) Token: 0x060073E9 RID: 29673 RVA: 0x0024CD98 File Offset: 0x0024AF98
		public string ShadowColor
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

		// Token: 0x060073EA RID: 29674 RVA: 0x0024CDD0 File Offset: 0x0024AFD0
		public Span<byte> GetShadowColorBytes()
		{
			return this.__p.__vector_as_span<byte>(46, 1);
		}

		// Token: 0x060073EB RID: 29675 RVA: 0x0024CDE0 File Offset: 0x0024AFE0
		public byte[] GetShadowColorArray()
		{
			return this.__p.__vector_as_array<byte>(46) ?? Array.Empty<byte>();
		}

		// Token: 0x17001124 RID: 4388
		// (get) Token: 0x060073EC RID: 29676 RVA: 0x0024CDF8 File Offset: 0x0024AFF8
		public float EmissionPower
		{
			get
			{
				int num = this.__p.__offset(48);
				if (num == 0)
				{
					return 0.7f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001125 RID: 4389
		// (get) Token: 0x060073ED RID: 29677 RVA: 0x0024CE3C File Offset: 0x0024B03C
		public float EmissionRange
		{
			get
			{
				int num = this.__p.__offset(50);
				if (num == 0)
				{
					return 0.03f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001126 RID: 4390
		// (get) Token: 0x060073EE RID: 29678 RVA: 0x0024CE80 File Offset: 0x0024B080
		public float EmissionStrength
		{
			get
			{
				int num = this.__p.__offset(52);
				if (num == 0)
				{
					return 0.03f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001127 RID: 4391
		// (get) Token: 0x060073EF RID: 29679 RVA: 0x0024CEC4 File Offset: 0x0024B0C4
		public string EmissionColor
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

		// Token: 0x060073F0 RID: 29680 RVA: 0x0024CEFC File Offset: 0x0024B0FC
		public Span<byte> GetEmissionColorBytes()
		{
			return this.__p.__vector_as_span<byte>(54, 1);
		}

		// Token: 0x060073F1 RID: 29681 RVA: 0x0024CF0C File Offset: 0x0024B10C
		public byte[] GetEmissionColorArray()
		{
			return this.__p.__vector_as_array<byte>(54) ?? Array.Empty<byte>();
		}

		// Token: 0x04005298 RID: 21144
		private Table __p;
	}
}
