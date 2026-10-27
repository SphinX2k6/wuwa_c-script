using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C9B RID: 3227
	public struct FloatingSubtitle2D : IFlatbufferObject
	{
		// Token: 0x17001254 RID: 4692
		// (get) Token: 0x060071C2 RID: 29122 RVA: 0x00236E59 File Offset: 0x00235059
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060071C3 RID: 29123 RVA: 0x00236E66 File Offset: 0x00235066
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060071C4 RID: 29124 RVA: 0x00236E70 File Offset: 0x00235070
		public static FloatingSubtitle2D GetRootAsFloatingSubtitle2D(ByteBuffer _bb)
		{
			return FloatingSubtitle2D.GetRootAsFloatingSubtitle2D(_bb, default(FloatingSubtitle2D));
		}

		// Token: 0x060071C5 RID: 29125 RVA: 0x00236E8C File Offset: 0x0023508C
		public static FloatingSubtitle2D GetRootAsFloatingSubtitle2D(ByteBuffer _bb, FloatingSubtitle2D obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060071C6 RID: 29126 RVA: 0x00236EA9 File Offset: 0x002350A9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060071C7 RID: 29127 RVA: 0x00236EB8 File Offset: 0x002350B8
		public FloatingSubtitle2D __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001255 RID: 4693
		// (get) Token: 0x060071C8 RID: 29128 RVA: 0x00236EC8 File Offset: 0x002350C8
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

		// Token: 0x17001256 RID: 4694
		// (get) Token: 0x060071C9 RID: 29129 RVA: 0x00236F04 File Offset: 0x00235104
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

		// Token: 0x060071CA RID: 29130 RVA: 0x00236F3B File Offset: 0x0023513B
		public Span<byte> GetSequenceNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x060071CB RID: 29131 RVA: 0x00236F4A File Offset: 0x0023514A
		public byte[] GetSequenceNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17001257 RID: 4695
		// (get) Token: 0x060071CC RID: 29132 RVA: 0x00236F64 File Offset: 0x00235164
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

		// Token: 0x060071CD RID: 29133 RVA: 0x00236F9B File Offset: 0x0023519B
		public Span<byte> GetTextKeyBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x060071CE RID: 29134 RVA: 0x00236FAA File Offset: 0x002351AA
		public byte[] GetTextKeyArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17001258 RID: 4696
		// (get) Token: 0x060071CF RID: 29135 RVA: 0x00236FC4 File Offset: 0x002351C4
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

		// Token: 0x17001259 RID: 4697
		// (get) Token: 0x060071D0 RID: 29136 RVA: 0x00237008 File Offset: 0x00235208
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

		// Token: 0x1700125A RID: 4698
		// (get) Token: 0x060071D1 RID: 29137 RVA: 0x0023704C File Offset: 0x0023524C
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

		// Token: 0x1700125B RID: 4699
		// (get) Token: 0x060071D2 RID: 29138 RVA: 0x00237090 File Offset: 0x00235290
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

		// Token: 0x1700125C RID: 4700
		// (get) Token: 0x060071D3 RID: 29139 RVA: 0x002370D4 File Offset: 0x002352D4
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

		// Token: 0x1700125D RID: 4701
		// (get) Token: 0x060071D4 RID: 29140 RVA: 0x00237118 File Offset: 0x00235318
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

		// Token: 0x1700125E RID: 4702
		// (get) Token: 0x060071D5 RID: 29141 RVA: 0x0023715C File Offset: 0x0023535C
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

		// Token: 0x1700125F RID: 4703
		// (get) Token: 0x060071D6 RID: 29142 RVA: 0x002371A0 File Offset: 0x002353A0
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

		// Token: 0x17001260 RID: 4704
		// (get) Token: 0x060071D7 RID: 29143 RVA: 0x002371E4 File Offset: 0x002353E4
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

		// Token: 0x17001261 RID: 4705
		// (get) Token: 0x060071D8 RID: 29144 RVA: 0x00237228 File Offset: 0x00235428
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

		// Token: 0x17001262 RID: 4706
		// (get) Token: 0x060071D9 RID: 29145 RVA: 0x0023726C File Offset: 0x0023546C
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

		// Token: 0x17001263 RID: 4707
		// (get) Token: 0x060071DA RID: 29146 RVA: 0x002372B0 File Offset: 0x002354B0
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

		// Token: 0x04004CF2 RID: 19698
		private Table __p;
	}
}
