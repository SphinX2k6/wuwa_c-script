using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200113D RID: 4413
	public struct TowerDefenceReward : IFlatbufferObject
	{
		// Token: 0x17003AEA RID: 15082
		// (get) Token: 0x0600E01E RID: 57374 RVA: 0x00330C0D File Offset: 0x0032EE0D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600E01F RID: 57375 RVA: 0x00330C1A File Offset: 0x0032EE1A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600E020 RID: 57376 RVA: 0x00330C24 File Offset: 0x0032EE24
		public static TowerDefenceReward GetRootAsTowerDefenceReward(ByteBuffer _bb)
		{
			return TowerDefenceReward.GetRootAsTowerDefenceReward(_bb, default(TowerDefenceReward));
		}

		// Token: 0x0600E021 RID: 57377 RVA: 0x00330C40 File Offset: 0x0032EE40
		public static TowerDefenceReward GetRootAsTowerDefenceReward(ByteBuffer _bb, TowerDefenceReward obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600E022 RID: 57378 RVA: 0x00330C5D File Offset: 0x0032EE5D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600E023 RID: 57379 RVA: 0x00330C6C File Offset: 0x0032EE6C
		public TowerDefenceReward __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003AEB RID: 15083
		// (get) Token: 0x0600E024 RID: 57380 RVA: 0x00330C7C File Offset: 0x0032EE7C
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

		// Token: 0x17003AEC RID: 15084
		// (get) Token: 0x0600E025 RID: 57381 RVA: 0x00330CB8 File Offset: 0x0032EEB8
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

		// Token: 0x17003AED RID: 15085
		// (get) Token: 0x0600E026 RID: 57382 RVA: 0x00330CF4 File Offset: 0x0032EEF4
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

		// Token: 0x17003AEE RID: 15086
		// (get) Token: 0x0600E027 RID: 57383 RVA: 0x00330D30 File Offset: 0x0032EF30
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

		// Token: 0x0400527E RID: 21118
		private Table __p;
	}
}
