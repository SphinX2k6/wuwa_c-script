using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D7F RID: 3455
	public struct FloatingSubtitle2D : IFlatbufferObject
	{
		// Token: 0x170012B1 RID: 4785
		// (get) Token: 0x060077CD RID: 30669 RVA: 0x00255E22 File Offset: 0x00254022
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060077CE RID: 30670 RVA: 0x00255E2F File Offset: 0x0025402F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060077CF RID: 30671 RVA: 0x00255E38 File Offset: 0x00254038
		public static FloatingSubtitle2D GetRootAsFloatingSubtitle2D(ByteBuffer _bb)
		{
			return FloatingSubtitle2D.GetRootAsFloatingSubtitle2D(_bb, default(FloatingSubtitle2D));
		}

		// Token: 0x060077D0 RID: 30672 RVA: 0x00255E54 File Offset: 0x00254054
		public static FloatingSubtitle2D GetRootAsFloatingSubtitle2D(ByteBuffer _bb, FloatingSubtitle2D obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060077D1 RID: 30673 RVA: 0x00255E71 File Offset: 0x00254071
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060077D2 RID: 30674 RVA: 0x00255E80 File Offset: 0x00254080
		public FloatingSubtitle2D __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170012B2 RID: 4786
		// (get) Token: 0x060077D3 RID: 30675 RVA: 0x00255E90 File Offset: 0x00254090
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

		// Token: 0x170012B3 RID: 4787
		// (get) Token: 0x060077D4 RID: 30676 RVA: 0x00255ECC File Offset: 0x002540CC
		public string SequenceName
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

		// Token: 0x060077D5 RID: 30677 RVA: 0x00255F03 File Offset: 0x00254103
		public Span<byte> GetSequenceNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x060077D6 RID: 30678 RVA: 0x00255F12 File Offset: 0x00254112
		public byte[] GetSequenceNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x170012B4 RID: 4788
		// (get) Token: 0x060077D7 RID: 30679 RVA: 0x00255F2C File Offset: 0x0025412C
		public string TextKey
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

		// Token: 0x060077D8 RID: 30680 RVA: 0x00255F63 File Offset: 0x00254163
		public Span<byte> GetTextKeyBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x060077D9 RID: 30681 RVA: 0x00255F72 File Offset: 0x00254172
		public byte[] GetTextKeyArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x170012B5 RID: 4789
		// (get) Token: 0x060077DA RID: 30682 RVA: 0x00255F8C File Offset: 0x0025418C
		public float ScaleEn
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 1f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170012B6 RID: 4790
		// (get) Token: 0x060077DB RID: 30683 RVA: 0x00255FD0 File Offset: 0x002541D0
		public float ScaleJa
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 1f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170012B7 RID: 4791
		// (get) Token: 0x060077DC RID: 30684 RVA: 0x00256014 File Offset: 0x00254214
		public float ScaleKo
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 1f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170012B8 RID: 4792
		// (get) Token: 0x060077DD RID: 30685 RVA: 0x00256058 File Offset: 0x00254258
		public float ScaleRu
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

		// Token: 0x170012B9 RID: 4793
		// (get) Token: 0x060077DE RID: 30686 RVA: 0x0025609C File Offset: 0x0025429C
		public float ScaleZhHant
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

		// Token: 0x170012BA RID: 4794
		// (get) Token: 0x060077DF RID: 30687 RVA: 0x002560E0 File Offset: 0x002542E0
		public float ScaleDe
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

		// Token: 0x170012BB RID: 4795
		// (get) Token: 0x060077E0 RID: 30688 RVA: 0x00256124 File Offset: 0x00254324
		public float ScaleEs
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

		// Token: 0x170012BC RID: 4796
		// (get) Token: 0x060077E1 RID: 30689 RVA: 0x00256168 File Offset: 0x00254368
		public float ScalePt
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

		// Token: 0x170012BD RID: 4797
		// (get) Token: 0x060077E2 RID: 30690 RVA: 0x002561AC File Offset: 0x002543AC
		public float ScaleIdn
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

		// Token: 0x170012BE RID: 4798
		// (get) Token: 0x060077E3 RID: 30691 RVA: 0x002561F0 File Offset: 0x002543F0
		public float ScaleFr
		{
			get
			{
				int num = this.__p.__offset(28);
				if (num == 0)
				{
					return 1f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170012BF RID: 4799
		// (get) Token: 0x060077E4 RID: 30692 RVA: 0x00256234 File Offset: 0x00254434
		public float ScaleVi
		{
			get
			{
				int num = this.__p.__offset(30);
				if (num == 0)
				{
					return 1f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170012C0 RID: 4800
		// (get) Token: 0x060077E5 RID: 30693 RVA: 0x00256278 File Offset: 0x00254478
		public float ScaleTh
		{
			get
			{
				int num = this.__p.__offset(32);
				if (num == 0)
				{
					return 1f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x040052D6 RID: 21206
		private Table __p;
	}
}
