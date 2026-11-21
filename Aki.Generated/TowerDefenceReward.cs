using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001273 RID: 4723
	public struct TowerDefenceReward : IFlatbufferObject
	{
		// Token: 0x17003E4E RID: 15950
		// (get) Token: 0x0600ED8C RID: 60812 RVA: 0x0035C076 File Offset: 0x0035A276
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600ED8D RID: 60813 RVA: 0x0035C083 File Offset: 0x0035A283
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600ED8E RID: 60814 RVA: 0x0035C08C File Offset: 0x0035A28C
		public static TowerDefenceReward GetRootAsTowerDefenceReward(ByteBuffer _bb)
		{
			return TowerDefenceReward.GetRootAsTowerDefenceReward(_bb, default(TowerDefenceReward));
		}

		// Token: 0x0600ED8F RID: 60815 RVA: 0x0035C0A8 File Offset: 0x0035A2A8
		public static TowerDefenceReward GetRootAsTowerDefenceReward(ByteBuffer _bb, TowerDefenceReward obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600ED90 RID: 60816 RVA: 0x0035C0C5 File Offset: 0x0035A2C5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600ED91 RID: 60817 RVA: 0x0035C0D4 File Offset: 0x0035A2D4
		public TowerDefenceReward __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003E4F RID: 15951
		// (get) Token: 0x0600ED92 RID: 60818 RVA: 0x0035C0E4 File Offset: 0x0035A2E4
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

		// Token: 0x17003E50 RID: 15952
		// (get) Token: 0x0600ED93 RID: 60819 RVA: 0x0035C120 File Offset: 0x0035A320
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

		// Token: 0x17003E51 RID: 15953
		// (get) Token: 0x0600ED94 RID: 60820 RVA: 0x0035C15C File Offset: 0x0035A35C
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

		// Token: 0x17003E52 RID: 15954
		// (get) Token: 0x0600ED95 RID: 60821 RVA: 0x0035C198 File Offset: 0x0035A398
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

		// Token: 0x040058C1 RID: 22721
		private Table __p;
	}
}
