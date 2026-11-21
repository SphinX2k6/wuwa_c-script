using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F58 RID: 3928
	public struct MowTowerRewardRe : IFlatbufferObject
	{
		// Token: 0x170022FF RID: 8959
		// (get) Token: 0x0600A36A RID: 41834 RVA: 0x002B753F File Offset: 0x002B573F
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600A36B RID: 41835 RVA: 0x002B754C File Offset: 0x002B574C
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600A36C RID: 41836 RVA: 0x002B7554 File Offset: 0x002B5754
		public static MowTowerRewardRe GetRootAsMowTowerRewardRe(ByteBuffer _bb)
		{
			return MowTowerRewardRe.GetRootAsMowTowerRewardRe(_bb, default(MowTowerRewardRe));
		}

		// Token: 0x0600A36D RID: 41837 RVA: 0x002B7570 File Offset: 0x002B5770
		public static MowTowerRewardRe GetRootAsMowTowerRewardRe(ByteBuffer _bb, MowTowerRewardRe obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600A36E RID: 41838 RVA: 0x002B758D File Offset: 0x002B578D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600A36F RID: 41839 RVA: 0x002B759C File Offset: 0x002B579C
		public MowTowerRewardRe __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002300 RID: 8960
		// (get) Token: 0x0600A370 RID: 41840 RVA: 0x002B75AC File Offset: 0x002B57AC
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

		// Token: 0x17002301 RID: 8961
		// (get) Token: 0x0600A371 RID: 41841 RVA: 0x002B75E8 File Offset: 0x002B57E8
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

		// Token: 0x17002302 RID: 8962
		// (get) Token: 0x0600A372 RID: 41842 RVA: 0x002B7624 File Offset: 0x002B5824
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

		// Token: 0x17002303 RID: 8963
		// (get) Token: 0x0600A373 RID: 41843 RVA: 0x002B7660 File Offset: 0x002B5860
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

		// Token: 0x17002304 RID: 8964
		// (get) Token: 0x0600A374 RID: 41844 RVA: 0x002B76A0 File Offset: 0x002B58A0
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

		// Token: 0x0600A375 RID: 41845 RVA: 0x002B76D8 File Offset: 0x002B58D8
		public Span<byte> GetLevelRewardDescBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600A376 RID: 41846 RVA: 0x002B76E8 File Offset: 0x002B58E8
		public byte[] GetLevelRewardDescArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x04005506 RID: 21766
		private Table __p;
	}
}
