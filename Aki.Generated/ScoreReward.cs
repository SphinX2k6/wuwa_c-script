using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200108E RID: 4238
	public struct ScoreReward : IFlatbufferObject
	{
		// Token: 0x170034EF RID: 13551
		// (get) Token: 0x0600CFA2 RID: 53154 RVA: 0x0030A158 File Offset: 0x00308358
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600CFA3 RID: 53155 RVA: 0x0030A165 File Offset: 0x00308365
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600CFA4 RID: 53156 RVA: 0x0030A16C File Offset: 0x0030836C
		public static ScoreReward GetRootAsScoreReward(ByteBuffer _bb)
		{
			return ScoreReward.GetRootAsScoreReward(_bb, default(ScoreReward));
		}

		// Token: 0x0600CFA5 RID: 53157 RVA: 0x0030A188 File Offset: 0x00308388
		public static ScoreReward GetRootAsScoreReward(ByteBuffer _bb, ScoreReward obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600CFA6 RID: 53158 RVA: 0x0030A1A5 File Offset: 0x003083A5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600CFA7 RID: 53159 RVA: 0x0030A1B4 File Offset: 0x003083B4
		public ScoreReward __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170034F0 RID: 13552
		// (get) Token: 0x0600CFA8 RID: 53160 RVA: 0x0030A1C4 File Offset: 0x003083C4
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

		// Token: 0x170034F1 RID: 13553
		// (get) Token: 0x0600CFA9 RID: 53161 RVA: 0x0030A200 File Offset: 0x00308400
		public int ActivityId
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

		// Token: 0x170034F2 RID: 13554
		// (get) Token: 0x0600CFAA RID: 53162 RVA: 0x0030A23C File Offset: 0x0030843C
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

		// Token: 0x170034F3 RID: 13555
		// (get) Token: 0x0600CFAB RID: 53163 RVA: 0x0030A278 File Offset: 0x00308478
		public int Reward
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

		// Token: 0x170034F4 RID: 13556
		// (get) Token: 0x0600CFAC RID: 53164 RVA: 0x0030A2B8 File Offset: 0x003084B8
		public string Desc
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

		// Token: 0x0600CFAD RID: 53165 RVA: 0x0030A2F0 File Offset: 0x003084F0
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600CFAE RID: 53166 RVA: 0x0030A300 File Offset: 0x00308500
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x0400519B RID: 20891
		private Table __p;
	}
}
