using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F15 RID: 3861
	public struct MotorcycleChallenge : IFlatbufferObject
	{
		// Token: 0x1700207E RID: 8318
		// (get) Token: 0x06009CEC RID: 40172 RVA: 0x002A8FBB File Offset: 0x002A71BB
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06009CED RID: 40173 RVA: 0x002A8FC8 File Offset: 0x002A71C8
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06009CEE RID: 40174 RVA: 0x002A8FD0 File Offset: 0x002A71D0
		public static MotorcycleChallenge GetRootAsMotorcycleChallenge(ByteBuffer _bb)
		{
			return MotorcycleChallenge.GetRootAsMotorcycleChallenge(_bb, default(MotorcycleChallenge));
		}

		// Token: 0x06009CEF RID: 40175 RVA: 0x002A8FEC File Offset: 0x002A71EC
		public static MotorcycleChallenge GetRootAsMotorcycleChallenge(ByteBuffer _bb, MotorcycleChallenge obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06009CF0 RID: 40176 RVA: 0x002A9009 File Offset: 0x002A7209
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06009CF1 RID: 40177 RVA: 0x002A9018 File Offset: 0x002A7218
		public MotorcycleChallenge __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700207F RID: 8319
		// (get) Token: 0x06009CF2 RID: 40178 RVA: 0x002A9028 File Offset: 0x002A7228
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

		// Token: 0x17002080 RID: 8320
		// (get) Token: 0x06009CF3 RID: 40179 RVA: 0x002A9064 File Offset: 0x002A7264
		public int LevelPlayId
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

		// Token: 0x17002081 RID: 8321
		// (get) Token: 0x06009CF4 RID: 40180 RVA: 0x002A90A0 File Offset: 0x002A72A0
		public string Name
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

		// Token: 0x06009CF5 RID: 40181 RVA: 0x002A90D7 File Offset: 0x002A72D7
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06009CF6 RID: 40182 RVA: 0x002A90E6 File Offset: 0x002A72E6
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17002082 RID: 8322
		// (get) Token: 0x06009CF7 RID: 40183 RVA: 0x002A9100 File Offset: 0x002A7300
		public int NeedScore
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

		// Token: 0x17002083 RID: 8323
		// (get) Token: 0x06009CF8 RID: 40184 RVA: 0x002A9140 File Offset: 0x002A7340
		public int Reward
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

		// Token: 0x17002084 RID: 8324
		// (get) Token: 0x06009CF9 RID: 40185 RVA: 0x002A9180 File Offset: 0x002A7380
		public string ScoreText
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

		// Token: 0x06009CFA RID: 40186 RVA: 0x002A91B8 File Offset: 0x002A73B8
		public Span<byte> GetScoreTextBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x06009CFB RID: 40187 RVA: 0x002A91C8 File Offset: 0x002A73C8
		public byte[] GetScoreTextArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17002085 RID: 8325
		// (get) Token: 0x06009CFC RID: 40188 RVA: 0x002A91E0 File Offset: 0x002A73E0
		public int JumpId
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

		// Token: 0x17002086 RID: 8326
		// (get) Token: 0x06009CFD RID: 40189 RVA: 0x002A9220 File Offset: 0x002A7420
		public int UnlockTravelLevel
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17002087 RID: 8327
		// (get) Token: 0x06009CFE RID: 40190 RVA: 0x002A9260 File Offset: 0x002A7460
		public int UnlockQuestId
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17002088 RID: 8328
		// (get) Token: 0x06009CFF RID: 40191 RVA: 0x002A92A0 File Offset: 0x002A74A0
		public string LockTips
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

		// Token: 0x06009D00 RID: 40192 RVA: 0x002A92D8 File Offset: 0x002A74D8
		public Span<byte> GetLockTipsBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x06009D01 RID: 40193 RVA: 0x002A92E8 File Offset: 0x002A74E8
		public byte[] GetLockTipsArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x17002089 RID: 8329
		// (get) Token: 0x06009D02 RID: 40194 RVA: 0x002A9300 File Offset: 0x002A7500
		public int ClassificationId
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x040054BA RID: 21690
		private Table __p;
	}
}
