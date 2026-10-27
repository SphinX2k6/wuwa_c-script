using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E90 RID: 3728
	public struct NewTowerScoreLevel : IFlatbufferObject
	{
		// Token: 0x1700236D RID: 9069
		// (get) Token: 0x06009FA4 RID: 40868 RVA: 0x0029F032 File Offset: 0x0029D232
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06009FA5 RID: 40869 RVA: 0x0029F03F File Offset: 0x0029D23F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06009FA6 RID: 40870 RVA: 0x0029F048 File Offset: 0x0029D248
		public static NewTowerScoreLevel GetRootAsNewTowerScoreLevel(ByteBuffer _bb)
		{
			return NewTowerScoreLevel.GetRootAsNewTowerScoreLevel(_bb, default(NewTowerScoreLevel));
		}

		// Token: 0x06009FA7 RID: 40871 RVA: 0x0029F064 File Offset: 0x0029D264
		public static NewTowerScoreLevel GetRootAsNewTowerScoreLevel(ByteBuffer _bb, NewTowerScoreLevel obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06009FA8 RID: 40872 RVA: 0x0029F081 File Offset: 0x0029D281
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06009FA9 RID: 40873 RVA: 0x0029F090 File Offset: 0x0029D290
		public NewTowerScoreLevel __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700236E RID: 9070
		// (get) Token: 0x06009FAA RID: 40874 RVA: 0x0029F0A0 File Offset: 0x0029D2A0
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

		// Token: 0x1700236F RID: 9071
		// (get) Token: 0x06009FAB RID: 40875 RVA: 0x0029F0DC File Offset: 0x0029D2DC
		public string Level
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

		// Token: 0x06009FAC RID: 40876 RVA: 0x0029F113 File Offset: 0x0029D313
		public Span<byte> GetLevelBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06009FAD RID: 40877 RVA: 0x0029F122 File Offset: 0x0029D322
		public byte[] GetLevelArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17002370 RID: 9072
		// (get) Token: 0x06009FAE RID: 40878 RVA: 0x0029F13C File Offset: 0x0029D33C
		public string Icon
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

		// Token: 0x06009FAF RID: 40879 RVA: 0x0029F173 File Offset: 0x0029D373
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06009FB0 RID: 40880 RVA: 0x0029F182 File Offset: 0x0029D382
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17002371 RID: 9073
		// (get) Token: 0x06009FB1 RID: 40881 RVA: 0x0029F19C File Offset: 0x0029D39C
		public string IconSettlement
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

		// Token: 0x06009FB2 RID: 40882 RVA: 0x0029F1D4 File Offset: 0x0029D3D4
		public Span<byte> GetIconSettlementBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06009FB3 RID: 40883 RVA: 0x0029F1E4 File Offset: 0x0029D3E4
		public byte[] GetIconSettlementArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17002372 RID: 9074
		// (get) Token: 0x06009FB4 RID: 40884 RVA: 0x0029F1FC File Offset: 0x0029D3FC
		public string BgColor
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

		// Token: 0x06009FB5 RID: 40885 RVA: 0x0029F234 File Offset: 0x0029D434
		public Span<byte> GetBgColorBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06009FB6 RID: 40886 RVA: 0x0029F244 File Offset: 0x0029D444
		public byte[] GetBgColorArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17002373 RID: 9075
		// (get) Token: 0x06009FB7 RID: 40887 RVA: 0x0029F25C File Offset: 0x0029D45C
		public string SquareColor
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

		// Token: 0x06009FB8 RID: 40888 RVA: 0x0029F294 File Offset: 0x0029D494
		public Span<byte> GetSquareColorBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x06009FB9 RID: 40889 RVA: 0x0029F2A4 File Offset: 0x0029D4A4
		public byte[] GetSquareColorArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17002374 RID: 9076
		// (get) Token: 0x06009FBA RID: 40890 RVA: 0x0029F2BC File Offset: 0x0029D4BC
		public string CircleColor
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

		// Token: 0x06009FBB RID: 40891 RVA: 0x0029F2F4 File Offset: 0x0029D4F4
		public Span<byte> GetCircleColorBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x06009FBC RID: 40892 RVA: 0x0029F304 File Offset: 0x0029D504
		public byte[] GetCircleColorArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x17002375 RID: 9077
		// (get) Token: 0x06009FBD RID: 40893 RVA: 0x0029F31C File Offset: 0x0029D51C
		public string GridColor
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

		// Token: 0x06009FBE RID: 40894 RVA: 0x0029F354 File Offset: 0x0029D554
		public Span<byte> GetGridColorBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x06009FBF RID: 40895 RVA: 0x0029F364 File Offset: 0x0029D564
		public byte[] GetGridColorArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x17002376 RID: 9078
		// (get) Token: 0x06009FC0 RID: 40896 RVA: 0x0029F37C File Offset: 0x0029D57C
		public string BgLightColor
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

		// Token: 0x06009FC1 RID: 40897 RVA: 0x0029F3B4 File Offset: 0x0029D5B4
		public Span<byte> GetBgLightColorBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x06009FC2 RID: 40898 RVA: 0x0029F3C4 File Offset: 0x0029D5C4
		public byte[] GetBgLightColorArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x17002377 RID: 9079
		// (get) Token: 0x06009FC3 RID: 40899 RVA: 0x0029F3DC File Offset: 0x0029D5DC
		public string TextColor
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

		// Token: 0x06009FC4 RID: 40900 RVA: 0x0029F414 File Offset: 0x0029D614
		public Span<byte> GetTextColorBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x06009FC5 RID: 40901 RVA: 0x0029F424 File Offset: 0x0029D624
		public byte[] GetTextColorArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x04004F43 RID: 20291
		private Table __p;
	}
}
