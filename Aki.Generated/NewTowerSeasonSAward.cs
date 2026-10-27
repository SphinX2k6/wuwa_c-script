using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E94 RID: 3732
	public struct NewTowerSeasonSAward : IFlatbufferObject
	{
		// Token: 0x17002396 RID: 9110
		// (get) Token: 0x0600A014 RID: 40980 RVA: 0x0029FE70 File Offset: 0x0029E070
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600A015 RID: 40981 RVA: 0x0029FE7D File Offset: 0x0029E07D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600A016 RID: 40982 RVA: 0x0029FE84 File Offset: 0x0029E084
		public static NewTowerSeasonSAward GetRootAsNewTowerSeasonSAward(ByteBuffer _bb)
		{
			return NewTowerSeasonSAward.GetRootAsNewTowerSeasonSAward(_bb, default(NewTowerSeasonSAward));
		}

		// Token: 0x0600A017 RID: 40983 RVA: 0x0029FEA0 File Offset: 0x0029E0A0
		public static NewTowerSeasonSAward GetRootAsNewTowerSeasonSAward(ByteBuffer _bb, NewTowerSeasonSAward obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600A018 RID: 40984 RVA: 0x0029FEBD File Offset: 0x0029E0BD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600A019 RID: 40985 RVA: 0x0029FECC File Offset: 0x0029E0CC
		public NewTowerSeasonSAward __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002397 RID: 9111
		// (get) Token: 0x0600A01A RID: 40986 RVA: 0x0029FEDC File Offset: 0x0029E0DC
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

		// Token: 0x17002398 RID: 9112
		// (get) Token: 0x0600A01B RID: 40987 RVA: 0x0029FF18 File Offset: 0x0029E118
		public int SeasonId
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17002399 RID: 9113
		// (get) Token: 0x0600A01C RID: 40988 RVA: 0x0029FF54 File Offset: 0x0029E154
		public int Index
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700239A RID: 9114
		// (get) Token: 0x0600A01D RID: 40989 RVA: 0x0029FF90 File Offset: 0x0029E190
		public int Score
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

		// Token: 0x1700239B RID: 9115
		// (get) Token: 0x0600A01E RID: 40990 RVA: 0x0029FFD0 File Offset: 0x0029E1D0
		public int DropId
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

		// Token: 0x1700239C RID: 9116
		// (get) Token: 0x0600A01F RID: 40991 RVA: 0x002A0010 File Offset: 0x0029E210
		public int MotorPreviewId
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

		// Token: 0x1700239D RID: 9117
		// (get) Token: 0x0600A020 RID: 40992 RVA: 0x002A0050 File Offset: 0x0029E250
		public int WeaponPreviewId
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700239E RID: 9118
		// (get) Token: 0x0600A021 RID: 40993 RVA: 0x002A0090 File Offset: 0x0029E290
		public string PreviewIcon
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

		// Token: 0x0600A022 RID: 40994 RVA: 0x002A00C8 File Offset: 0x0029E2C8
		public Span<byte> GetPreviewIconBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0600A023 RID: 40995 RVA: 0x002A00D8 File Offset: 0x0029E2D8
		public byte[] GetPreviewIconArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x04004F47 RID: 20295
		private Table __p;
	}
}
