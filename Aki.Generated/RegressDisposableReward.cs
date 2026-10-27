using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000FAB RID: 4011
	public struct RegressDisposableReward : IFlatbufferObject
	{
		// Token: 0x17002D90 RID: 11664
		// (get) Token: 0x0600BAC9 RID: 47817 RVA: 0x002DB7F1 File Offset: 0x002D99F1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600BACA RID: 47818 RVA: 0x002DB7FE File Offset: 0x002D99FE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600BACB RID: 47819 RVA: 0x002DB808 File Offset: 0x002D9A08
		public static RegressDisposableReward GetRootAsRegressDisposableReward(ByteBuffer _bb)
		{
			return RegressDisposableReward.GetRootAsRegressDisposableReward(_bb, default(RegressDisposableReward));
		}

		// Token: 0x0600BACC RID: 47820 RVA: 0x002DB824 File Offset: 0x002D9A24
		public static RegressDisposableReward GetRootAsRegressDisposableReward(ByteBuffer _bb, RegressDisposableReward obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600BACD RID: 47821 RVA: 0x002DB841 File Offset: 0x002D9A41
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600BACE RID: 47822 RVA: 0x002DB850 File Offset: 0x002D9A50
		public RegressDisposableReward __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002D91 RID: 11665
		// (get) Token: 0x0600BACF RID: 47823 RVA: 0x002DB860 File Offset: 0x002D9A60
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

		// Token: 0x17002D92 RID: 11666
		// (get) Token: 0x0600BAD0 RID: 47824 RVA: 0x002DB89C File Offset: 0x002D9A9C
		public int DropId
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

		// Token: 0x17002D93 RID: 11667
		// (get) Token: 0x0600BAD1 RID: 47825 RVA: 0x002DB8D8 File Offset: 0x002D9AD8
		public int HighDropId
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

		// Token: 0x17002D94 RID: 11668
		// (get) Token: 0x0600BAD2 RID: 47826 RVA: 0x002DB914 File Offset: 0x002D9B14
		public int BuyLvConsumeItem
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

		// Token: 0x17002D95 RID: 11669
		// (get) Token: 0x0600BAD3 RID: 47827 RVA: 0x002DB954 File Offset: 0x002D9B54
		public int BuyLvConsumeNum
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

		// Token: 0x17002D96 RID: 11670
		// (get) Token: 0x0600BAD4 RID: 47828 RVA: 0x002DB994 File Offset: 0x002D9B94
		public int HighRewardPreviewId
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

		// Token: 0x17002D97 RID: 11671
		// (get) Token: 0x0600BAD5 RID: 47829 RVA: 0x002DB9D4 File Offset: 0x002D9BD4
		public int ShowRecommendActivityGroup
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

		// Token: 0x04005084 RID: 20612
		private Table __p;
	}
}
