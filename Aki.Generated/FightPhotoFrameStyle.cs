using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C69 RID: 3177
	public struct FightPhotoFrameStyle : IFlatbufferObject
	{
		// Token: 0x170010B0 RID: 4272
		// (get) Token: 0x06006DBD RID: 28093 RVA: 0x0022D4DD File Offset: 0x0022B6DD
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06006DBE RID: 28094 RVA: 0x0022D4EA File Offset: 0x0022B6EA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06006DBF RID: 28095 RVA: 0x0022D4F4 File Offset: 0x0022B6F4
		public static FightPhotoFrameStyle GetRootAsFightPhotoFrameStyle(ByteBuffer _bb)
		{
			return FightPhotoFrameStyle.GetRootAsFightPhotoFrameStyle(_bb, default(FightPhotoFrameStyle));
		}

		// Token: 0x06006DC0 RID: 28096 RVA: 0x0022D510 File Offset: 0x0022B710
		public static FightPhotoFrameStyle GetRootAsFightPhotoFrameStyle(ByteBuffer _bb, FightPhotoFrameStyle obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06006DC1 RID: 28097 RVA: 0x0022D52D File Offset: 0x0022B72D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06006DC2 RID: 28098 RVA: 0x0022D53C File Offset: 0x0022B73C
		public FightPhotoFrameStyle __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170010B1 RID: 4273
		// (get) Token: 0x06006DC3 RID: 28099 RVA: 0x0022D54C File Offset: 0x0022B74C
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

		// Token: 0x170010B2 RID: 4274
		// (get) Token: 0x06006DC4 RID: 28100 RVA: 0x0022D588 File Offset: 0x0022B788
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

		// Token: 0x06006DC5 RID: 28101 RVA: 0x0022D5BF File Offset: 0x0022B7BF
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06006DC6 RID: 28102 RVA: 0x0022D5CE File Offset: 0x0022B7CE
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x170010B3 RID: 4275
		// (get) Token: 0x06006DC7 RID: 28103 RVA: 0x0022D5E8 File Offset: 0x0022B7E8
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

		// Token: 0x06006DC8 RID: 28104 RVA: 0x0022D61F File Offset: 0x0022B81F
		public Span<byte> GetPictureBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06006DC9 RID: 28105 RVA: 0x0022D62E File Offset: 0x0022B82E
		public byte[] GetPictureArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x170010B4 RID: 4276
		// (get) Token: 0x06006DCA RID: 28106 RVA: 0x0022D648 File Offset: 0x0022B848
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

		// Token: 0x170010B5 RID: 4277
		// (get) Token: 0x06006DCB RID: 28107 RVA: 0x0022D688 File Offset: 0x0022B888
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

		// Token: 0x170010B6 RID: 4278
		// (get) Token: 0x06006DCC RID: 28108 RVA: 0x0022D6C8 File Offset: 0x0022B8C8
		public bool ShowDecoration
		{
			get
			{
				int num = this.__p.__offset(14);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170010B7 RID: 4279
		// (get) Token: 0x06006DCD RID: 28109 RVA: 0x0022D708 File Offset: 0x0022B908
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

		// Token: 0x170010B8 RID: 4280
		// (get) Token: 0x06006DCE RID: 28110 RVA: 0x0022D74C File Offset: 0x0022B94C
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

		// Token: 0x170010B9 RID: 4281
		// (get) Token: 0x06006DCF RID: 28111 RVA: 0x0022D790 File Offset: 0x0022B990
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

		// Token: 0x06006DD0 RID: 28112 RVA: 0x0022D7C8 File Offset: 0x0022B9C8
		public Span<byte> GetMaskColorBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x06006DD1 RID: 28113 RVA: 0x0022D7D8 File Offset: 0x0022B9D8
		public byte[] GetMaskColorArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x170010BA RID: 4282
		// (get) Token: 0x06006DD2 RID: 28114 RVA: 0x0022D7F0 File Offset: 0x0022B9F0
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

		// Token: 0x170010BB RID: 4283
		// (get) Token: 0x06006DD3 RID: 28115 RVA: 0x0022D834 File Offset: 0x0022BA34
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

		// Token: 0x170010BC RID: 4284
		// (get) Token: 0x06006DD4 RID: 28116 RVA: 0x0022D878 File Offset: 0x0022BA78
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

		// Token: 0x170010BD RID: 4285
		// (get) Token: 0x06006DD5 RID: 28117 RVA: 0x0022D8BC File Offset: 0x0022BABC
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

		// Token: 0x170010BE RID: 4286
		// (get) Token: 0x06006DD6 RID: 28118 RVA: 0x0022D900 File Offset: 0x0022BB00
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

		// Token: 0x170010BF RID: 4287
		// (get) Token: 0x06006DD7 RID: 28119 RVA: 0x0022D944 File Offset: 0x0022BB44
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

		// Token: 0x170010C0 RID: 4288
		// (get) Token: 0x06006DD8 RID: 28120 RVA: 0x0022D988 File Offset: 0x0022BB88
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

		// Token: 0x170010C1 RID: 4289
		// (get) Token: 0x06006DD9 RID: 28121 RVA: 0x0022D9CC File Offset: 0x0022BBCC
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

		// Token: 0x170010C2 RID: 4290
		// (get) Token: 0x06006DDA RID: 28122 RVA: 0x0022DA10 File Offset: 0x0022BC10
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

		// Token: 0x170010C3 RID: 4291
		// (get) Token: 0x06006DDB RID: 28123 RVA: 0x0022DA54 File Offset: 0x0022BC54
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

		// Token: 0x170010C4 RID: 4292
		// (get) Token: 0x06006DDC RID: 28124 RVA: 0x0022DA98 File Offset: 0x0022BC98
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

		// Token: 0x170010C5 RID: 4293
		// (get) Token: 0x06006DDD RID: 28125 RVA: 0x0022DADC File Offset: 0x0022BCDC
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

		// Token: 0x170010C6 RID: 4294
		// (get) Token: 0x06006DDE RID: 28126 RVA: 0x0022DB20 File Offset: 0x0022BD20
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

		// Token: 0x06006DDF RID: 28127 RVA: 0x0022DB58 File Offset: 0x0022BD58
		public Span<byte> GetShadowColorBytes()
		{
			return this.__p.__vector_as_span<byte>(46, 1);
		}

		// Token: 0x06006DE0 RID: 28128 RVA: 0x0022DB68 File Offset: 0x0022BD68
		public byte[] GetShadowColorArray()
		{
			return this.__p.__vector_as_array<byte>(46) ?? Array.Empty<byte>();
		}

		// Token: 0x170010C7 RID: 4295
		// (get) Token: 0x06006DE1 RID: 28129 RVA: 0x0022DB80 File Offset: 0x0022BD80
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

		// Token: 0x170010C8 RID: 4296
		// (get) Token: 0x06006DE2 RID: 28130 RVA: 0x0022DBC4 File Offset: 0x0022BDC4
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

		// Token: 0x170010C9 RID: 4297
		// (get) Token: 0x06006DE3 RID: 28131 RVA: 0x0022DC08 File Offset: 0x0022BE08
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

		// Token: 0x170010CA RID: 4298
		// (get) Token: 0x06006DE4 RID: 28132 RVA: 0x0022DC4C File Offset: 0x0022BE4C
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

		// Token: 0x06006DE5 RID: 28133 RVA: 0x0022DC84 File Offset: 0x0022BE84
		public Span<byte> GetEmissionColorBytes()
		{
			return this.__p.__vector_as_span<byte>(54, 1);
		}

		// Token: 0x06006DE6 RID: 28134 RVA: 0x0022DC94 File Offset: 0x0022BE94
		public byte[] GetEmissionColorArray()
		{
			return this.__p.__vector_as_array<byte>(54) ?? Array.Empty<byte>();
		}

		// Token: 0x04004CB4 RID: 19636
		private Table __p;
	}
}
