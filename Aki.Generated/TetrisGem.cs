using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001124 RID: 4388
	public struct TetrisGem : IFlatbufferObject
	{
		// Token: 0x17003A2C RID: 14892
		// (get) Token: 0x0600DE12 RID: 56850 RVA: 0x0032C2C8 File Offset: 0x0032A4C8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600DE13 RID: 56851 RVA: 0x0032C2D5 File Offset: 0x0032A4D5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600DE14 RID: 56852 RVA: 0x0032C2DC File Offset: 0x0032A4DC
		public static TetrisGem GetRootAsTetrisGem(ByteBuffer _bb)
		{
			return TetrisGem.GetRootAsTetrisGem(_bb, default(TetrisGem));
		}

		// Token: 0x0600DE15 RID: 56853 RVA: 0x0032C2F8 File Offset: 0x0032A4F8
		public static TetrisGem GetRootAsTetrisGem(ByteBuffer _bb, TetrisGem obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600DE16 RID: 56854 RVA: 0x0032C315 File Offset: 0x0032A515
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600DE17 RID: 56855 RVA: 0x0032C324 File Offset: 0x0032A524
		public TetrisGem __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003A2D RID: 14893
		// (get) Token: 0x0600DE18 RID: 56856 RVA: 0x0032C334 File Offset: 0x0032A534
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

		// Token: 0x17003A2E RID: 14894
		// (get) Token: 0x0600DE19 RID: 56857 RVA: 0x0032C370 File Offset: 0x0032A570
		public string BgPath
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

		// Token: 0x0600DE1A RID: 56858 RVA: 0x0032C3A7 File Offset: 0x0032A5A7
		public Span<byte> GetBgPathBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600DE1B RID: 56859 RVA: 0x0032C3B6 File Offset: 0x0032A5B6
		public byte[] GetBgPathArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17003A2F RID: 14895
		// (get) Token: 0x0600DE1C RID: 56860 RVA: 0x0032C3D0 File Offset: 0x0032A5D0
		public string FramePath
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

		// Token: 0x0600DE1D RID: 56861 RVA: 0x0032C407 File Offset: 0x0032A607
		public Span<byte> GetFramePathBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600DE1E RID: 56862 RVA: 0x0032C416 File Offset: 0x0032A616
		public byte[] GetFramePathArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17003A30 RID: 14896
		// (get) Token: 0x0600DE1F RID: 56863 RVA: 0x0032C430 File Offset: 0x0032A630
		public string GemPath
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

		// Token: 0x0600DE20 RID: 56864 RVA: 0x0032C468 File Offset: 0x0032A668
		public Span<byte> GetGemPathBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600DE21 RID: 56865 RVA: 0x0032C478 File Offset: 0x0032A678
		public byte[] GetGemPathArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17003A31 RID: 14897
		// (get) Token: 0x0600DE22 RID: 56866 RVA: 0x0032C490 File Offset: 0x0032A690
		public string IconPath
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

		// Token: 0x0600DE23 RID: 56867 RVA: 0x0032C4C8 File Offset: 0x0032A6C8
		public Span<byte> GetIconPathBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600DE24 RID: 56868 RVA: 0x0032C4D8 File Offset: 0x0032A6D8
		public byte[] GetIconPathArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17003A32 RID: 14898
		// (get) Token: 0x0600DE25 RID: 56869 RVA: 0x0032C4F0 File Offset: 0x0032A6F0
		public string TargetIconPath
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

		// Token: 0x0600DE26 RID: 56870 RVA: 0x0032C528 File Offset: 0x0032A728
		public Span<byte> GetTargetIconPathBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600DE27 RID: 56871 RVA: 0x0032C538 File Offset: 0x0032A738
		public byte[] GetTargetIconPathArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17003A33 RID: 14899
		// (get) Token: 0x0600DE28 RID: 56872 RVA: 0x0032C550 File Offset: 0x0032A750
		public string TargetBgPath
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

		// Token: 0x0600DE29 RID: 56873 RVA: 0x0032C588 File Offset: 0x0032A788
		public Span<byte> GetTargetBgPathBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600DE2A RID: 56874 RVA: 0x0032C598 File Offset: 0x0032A798
		public byte[] GetTargetBgPathArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x17003A34 RID: 14900
		// (get) Token: 0x0600DE2B RID: 56875 RVA: 0x0032C5B0 File Offset: 0x0032A7B0
		public string TargetTextureBgPath
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

		// Token: 0x0600DE2C RID: 56876 RVA: 0x0032C5E8 File Offset: 0x0032A7E8
		public Span<byte> GetTargetTextureBgPathBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0600DE2D RID: 56877 RVA: 0x0032C5F8 File Offset: 0x0032A7F8
		public byte[] GetTargetTextureBgPathArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x17003A35 RID: 14901
		// (get) Token: 0x0600DE2E RID: 56878 RVA: 0x0032C610 File Offset: 0x0032A810
		public string ColorValue
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

		// Token: 0x0600DE2F RID: 56879 RVA: 0x0032C648 File Offset: 0x0032A848
		public Span<byte> GetColorValueBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x0600DE30 RID: 56880 RVA: 0x0032C658 File Offset: 0x0032A858
		public byte[] GetColorValueArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x17003A36 RID: 14902
		// (get) Token: 0x0600DE31 RID: 56881 RVA: 0x0032C670 File Offset: 0x0032A870
		public string NiaGlowColorValue
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

		// Token: 0x0600DE32 RID: 56882 RVA: 0x0032C6A8 File Offset: 0x0032A8A8
		public Span<byte> GetNiaGlowColorValueBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x0600DE33 RID: 56883 RVA: 0x0032C6B8 File Offset: 0x0032A8B8
		public byte[] GetNiaGlowColorValueArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x17003A37 RID: 14903
		// (get) Token: 0x0600DE34 RID: 56884 RVA: 0x0032C6D0 File Offset: 0x0032A8D0
		public string NiaGlowSweepColorValue
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

		// Token: 0x0600DE35 RID: 56885 RVA: 0x0032C708 File Offset: 0x0032A908
		public Span<byte> GetNiaGlowSweepColorValueBytes()
		{
			return this.__p.__vector_as_span<byte>(24, 1);
		}

		// Token: 0x0600DE36 RID: 56886 RVA: 0x0032C718 File Offset: 0x0032A918
		public byte[] GetNiaGlowSweepColorValueArray()
		{
			return this.__p.__vector_as_array<byte>(24) ?? Array.Empty<byte>();
		}

		// Token: 0x17003A38 RID: 14904
		// (get) Token: 0x0600DE37 RID: 56887 RVA: 0x0032C730 File Offset: 0x0032A930
		public string OneSealPath
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

		// Token: 0x0600DE38 RID: 56888 RVA: 0x0032C768 File Offset: 0x0032A968
		public Span<byte> GetOneSealPathBytes()
		{
			return this.__p.__vector_as_span<byte>(26, 1);
		}

		// Token: 0x0600DE39 RID: 56889 RVA: 0x0032C778 File Offset: 0x0032A978
		public byte[] GetOneSealPathArray()
		{
			return this.__p.__vector_as_array<byte>(26) ?? Array.Empty<byte>();
		}

		// Token: 0x17003A39 RID: 14905
		// (get) Token: 0x0600DE3A RID: 56890 RVA: 0x0032C790 File Offset: 0x0032A990
		public string TwoSealPath
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

		// Token: 0x0600DE3B RID: 56891 RVA: 0x0032C7C8 File Offset: 0x0032A9C8
		public Span<byte> GetTwoSealPathBytes()
		{
			return this.__p.__vector_as_span<byte>(28, 1);
		}

		// Token: 0x0600DE3C RID: 56892 RVA: 0x0032C7D8 File Offset: 0x0032A9D8
		public byte[] GetTwoSealPathArray()
		{
			return this.__p.__vector_as_array<byte>(28) ?? Array.Empty<byte>();
		}

		// Token: 0x04005262 RID: 21090
		private Table __p;
	}
}
