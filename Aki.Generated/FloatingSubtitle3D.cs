using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D80 RID: 3456
	public struct FloatingSubtitle3D : IFlatbufferObject
	{
		// Token: 0x170012C1 RID: 4801
		// (get) Token: 0x060077E6 RID: 30694 RVA: 0x002562B9 File Offset: 0x002544B9
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060077E7 RID: 30695 RVA: 0x002562C6 File Offset: 0x002544C6
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060077E8 RID: 30696 RVA: 0x002562D0 File Offset: 0x002544D0
		public static FloatingSubtitle3D GetRootAsFloatingSubtitle3D(ByteBuffer _bb)
		{
			return FloatingSubtitle3D.GetRootAsFloatingSubtitle3D(_bb, default(FloatingSubtitle3D));
		}

		// Token: 0x060077E9 RID: 30697 RVA: 0x002562EC File Offset: 0x002544EC
		public static FloatingSubtitle3D GetRootAsFloatingSubtitle3D(ByteBuffer _bb, FloatingSubtitle3D obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060077EA RID: 30698 RVA: 0x00256309 File Offset: 0x00254509
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060077EB RID: 30699 RVA: 0x00256318 File Offset: 0x00254518
		public FloatingSubtitle3D __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170012C2 RID: 4802
		// (get) Token: 0x060077EC RID: 30700 RVA: 0x00256328 File Offset: 0x00254528
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

		// Token: 0x170012C3 RID: 4803
		// (get) Token: 0x060077ED RID: 30701 RVA: 0x00256364 File Offset: 0x00254564
		public string TextKey
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

		// Token: 0x060077EE RID: 30702 RVA: 0x0025639B File Offset: 0x0025459B
		public Span<byte> GetTextKeyBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x060077EF RID: 30703 RVA: 0x002563AA File Offset: 0x002545AA
		public byte[] GetTextKeyArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x170012C4 RID: 4804
		// (get) Token: 0x060077F0 RID: 30704 RVA: 0x002563C4 File Offset: 0x002545C4
		public string Color
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

		// Token: 0x060077F1 RID: 30705 RVA: 0x002563FB File Offset: 0x002545FB
		public Span<byte> GetColorBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x060077F2 RID: 30706 RVA: 0x0025640A File Offset: 0x0025460A
		public byte[] GetColorArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x170012C5 RID: 4805
		// (get) Token: 0x060077F3 RID: 30707 RVA: 0x00256424 File Offset: 0x00254624
		public float Size
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170012C6 RID: 4806
		// (get) Token: 0x060077F4 RID: 30708 RVA: 0x00256468 File Offset: 0x00254668
		public float SizeEn
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170012C7 RID: 4807
		// (get) Token: 0x060077F5 RID: 30709 RVA: 0x002564AC File Offset: 0x002546AC
		public float SizeJa
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170012C8 RID: 4808
		// (get) Token: 0x060077F6 RID: 30710 RVA: 0x002564F0 File Offset: 0x002546F0
		public float SizeKo
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170012C9 RID: 4809
		// (get) Token: 0x060077F7 RID: 30711 RVA: 0x00256534 File Offset: 0x00254734
		public float SizeRu
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170012CA RID: 4810
		// (get) Token: 0x060077F8 RID: 30712 RVA: 0x00256578 File Offset: 0x00254778
		public float SizeZhHant
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170012CB RID: 4811
		// (get) Token: 0x060077F9 RID: 30713 RVA: 0x002565BC File Offset: 0x002547BC
		public float SizeDe
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170012CC RID: 4812
		// (get) Token: 0x060077FA RID: 30714 RVA: 0x00256600 File Offset: 0x00254800
		public float SizeEs
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

		// Token: 0x170012CD RID: 4813
		// (get) Token: 0x060077FB RID: 30715 RVA: 0x00256644 File Offset: 0x00254844
		public float SizePt
		{
			get
			{
				int num = this.__p.__offset(26);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170012CE RID: 4814
		// (get) Token: 0x060077FC RID: 30716 RVA: 0x00256688 File Offset: 0x00254888
		public float SizeIdn
		{
			get
			{
				int num = this.__p.__offset(28);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170012CF RID: 4815
		// (get) Token: 0x060077FD RID: 30717 RVA: 0x002566CC File Offset: 0x002548CC
		public float SizeFr
		{
			get
			{
				int num = this.__p.__offset(30);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170012D0 RID: 4816
		// (get) Token: 0x060077FE RID: 30718 RVA: 0x00256710 File Offset: 0x00254910
		public float SizeVi
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

		// Token: 0x170012D1 RID: 4817
		// (get) Token: 0x060077FF RID: 30719 RVA: 0x00256754 File Offset: 0x00254954
		public float SizeTh
		{
			get
			{
				int num = this.__p.__offset(34);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170012D2 RID: 4818
		// (get) Token: 0x06007800 RID: 30720 RVA: 0x00256798 File Offset: 0x00254998
		public string Audio
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

		// Token: 0x06007801 RID: 30721 RVA: 0x002567D0 File Offset: 0x002549D0
		public Span<byte> GetAudioBytes()
		{
			return this.__p.__vector_as_span<byte>(36, 1);
		}

		// Token: 0x06007802 RID: 30722 RVA: 0x002567E0 File Offset: 0x002549E0
		public byte[] GetAudioArray()
		{
			return this.__p.__vector_as_array<byte>(36) ?? Array.Empty<byte>();
		}

		// Token: 0x040052D7 RID: 21207
		private Table __p;
	}
}
