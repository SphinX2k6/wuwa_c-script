using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C9C RID: 3228
	public struct FloatingSubtitle3D : IFlatbufferObject
	{
		// Token: 0x17001264 RID: 4708
		// (get) Token: 0x060071DB RID: 29147 RVA: 0x002372F1 File Offset: 0x002354F1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060071DC RID: 29148 RVA: 0x002372FE File Offset: 0x002354FE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060071DD RID: 29149 RVA: 0x00237308 File Offset: 0x00235508
		public static FloatingSubtitle3D GetRootAsFloatingSubtitle3D(ByteBuffer _bb)
		{
			return FloatingSubtitle3D.GetRootAsFloatingSubtitle3D(_bb, default(FloatingSubtitle3D));
		}

		// Token: 0x060071DE RID: 29150 RVA: 0x00237324 File Offset: 0x00235524
		public static FloatingSubtitle3D GetRootAsFloatingSubtitle3D(ByteBuffer _bb, FloatingSubtitle3D obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060071DF RID: 29151 RVA: 0x00237341 File Offset: 0x00235541
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060071E0 RID: 29152 RVA: 0x00237350 File Offset: 0x00235550
		public FloatingSubtitle3D __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001265 RID: 4709
		// (get) Token: 0x060071E1 RID: 29153 RVA: 0x00237360 File Offset: 0x00235560
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

		// Token: 0x17001266 RID: 4710
		// (get) Token: 0x060071E2 RID: 29154 RVA: 0x0023739C File Offset: 0x0023559C
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

		// Token: 0x060071E3 RID: 29155 RVA: 0x002373D3 File Offset: 0x002355D3
		public Span<byte> GetTextKeyBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x060071E4 RID: 29156 RVA: 0x002373E2 File Offset: 0x002355E2
		public byte[] GetTextKeyArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17001267 RID: 4711
		// (get) Token: 0x060071E5 RID: 29157 RVA: 0x002373FC File Offset: 0x002355FC
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

		// Token: 0x060071E6 RID: 29158 RVA: 0x00237433 File Offset: 0x00235633
		public Span<byte> GetColorBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x060071E7 RID: 29159 RVA: 0x00237442 File Offset: 0x00235642
		public byte[] GetColorArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17001268 RID: 4712
		// (get) Token: 0x060071E8 RID: 29160 RVA: 0x0023745C File Offset: 0x0023565C
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

		// Token: 0x17001269 RID: 4713
		// (get) Token: 0x060071E9 RID: 29161 RVA: 0x002374A0 File Offset: 0x002356A0
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

		// Token: 0x1700126A RID: 4714
		// (get) Token: 0x060071EA RID: 29162 RVA: 0x002374E4 File Offset: 0x002356E4
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

		// Token: 0x1700126B RID: 4715
		// (get) Token: 0x060071EB RID: 29163 RVA: 0x00237528 File Offset: 0x00235728
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

		// Token: 0x1700126C RID: 4716
		// (get) Token: 0x060071EC RID: 29164 RVA: 0x0023756C File Offset: 0x0023576C
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

		// Token: 0x1700126D RID: 4717
		// (get) Token: 0x060071ED RID: 29165 RVA: 0x002375B0 File Offset: 0x002357B0
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

		// Token: 0x1700126E RID: 4718
		// (get) Token: 0x060071EE RID: 29166 RVA: 0x002375F4 File Offset: 0x002357F4
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

		// Token: 0x1700126F RID: 4719
		// (get) Token: 0x060071EF RID: 29167 RVA: 0x00237638 File Offset: 0x00235838
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

		// Token: 0x17001270 RID: 4720
		// (get) Token: 0x060071F0 RID: 29168 RVA: 0x0023767C File Offset: 0x0023587C
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

		// Token: 0x17001271 RID: 4721
		// (get) Token: 0x060071F1 RID: 29169 RVA: 0x002376C0 File Offset: 0x002358C0
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

		// Token: 0x17001272 RID: 4722
		// (get) Token: 0x060071F2 RID: 29170 RVA: 0x00237704 File Offset: 0x00235904
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

		// Token: 0x17001273 RID: 4723
		// (get) Token: 0x060071F3 RID: 29171 RVA: 0x00237748 File Offset: 0x00235948
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

		// Token: 0x17001274 RID: 4724
		// (get) Token: 0x060071F4 RID: 29172 RVA: 0x0023778C File Offset: 0x0023598C
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

		// Token: 0x17001275 RID: 4725
		// (get) Token: 0x060071F5 RID: 29173 RVA: 0x002377D0 File Offset: 0x002359D0
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

		// Token: 0x060071F6 RID: 29174 RVA: 0x00237808 File Offset: 0x00235A08
		public Span<byte> GetAudioBytes()
		{
			return this.__p.__vector_as_span<byte>(36, 1);
		}

		// Token: 0x060071F7 RID: 29175 RVA: 0x00237818 File Offset: 0x00235A18
		public byte[] GetAudioArray()
		{
			return this.__p.__vector_as_array<byte>(36) ?? Array.Empty<byte>();
		}

		// Token: 0x04004CF3 RID: 19699
		private Table __p;
	}
}
