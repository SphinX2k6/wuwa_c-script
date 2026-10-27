using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E73 RID: 3699
	public struct MowTowerRewardRe : IFlatbufferObject
	{
		// Token: 0x1700229A RID: 8858
		// (get) Token: 0x06009D4A RID: 40266 RVA: 0x00299D59 File Offset: 0x00297F59
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06009D4B RID: 40267 RVA: 0x00299D66 File Offset: 0x00297F66
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06009D4C RID: 40268 RVA: 0x00299D70 File Offset: 0x00297F70
		public static MowTowerRewardRe GetRootAsMowTowerRewardRe(ByteBuffer _bb)
		{
			return MowTowerRewardRe.GetRootAsMowTowerRewardRe(_bb, default(MowTowerRewardRe));
		}

		// Token: 0x06009D4D RID: 40269 RVA: 0x00299D8C File Offset: 0x00297F8C
		public static MowTowerRewardRe GetRootAsMowTowerRewardRe(ByteBuffer _bb, MowTowerRewardRe obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06009D4E RID: 40270 RVA: 0x00299DA9 File Offset: 0x00297FA9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06009D4F RID: 40271 RVA: 0x00299DB8 File Offset: 0x00297FB8
		public MowTowerRewardRe __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700229B RID: 8859
		// (get) Token: 0x06009D50 RID: 40272 RVA: 0x00299DC8 File Offset: 0x00297FC8
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

		// Token: 0x1700229C RID: 8860
		// (get) Token: 0x06009D51 RID: 40273 RVA: 0x00299E04 File Offset: 0x00298004
		public int MowTowerLevelsId
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

		// Token: 0x1700229D RID: 8861
		// (get) Token: 0x06009D52 RID: 40274 RVA: 0x00299E40 File Offset: 0x00298040
		public int Score
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

		// Token: 0x1700229E RID: 8862
		// (get) Token: 0x06009D53 RID: 40275 RVA: 0x00299E7C File Offset: 0x0029807C
		public int RewardId
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

		// Token: 0x1700229F RID: 8863
		// (get) Token: 0x06009D54 RID: 40276 RVA: 0x00299EBC File Offset: 0x002980BC
		public string LevelRewardDesc
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

		// Token: 0x06009D55 RID: 40277 RVA: 0x00299EF4 File Offset: 0x002980F4
		public Span<byte> GetLevelRewardDescBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06009D56 RID: 40278 RVA: 0x00299F04 File Offset: 0x00298104
		public byte[] GetLevelRewardDescArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x04004F21 RID: 20257
		private Table __p;
	}
}
