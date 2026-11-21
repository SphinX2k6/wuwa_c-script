using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001093 RID: 4243
	public struct RegressDisposableReward : IFlatbufferObject
	{
		// Token: 0x17002E0B RID: 11787
		// (get) Token: 0x0600C113 RID: 49427 RVA: 0x002F7F81 File Offset: 0x002F6181
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600C114 RID: 49428 RVA: 0x002F7F8E File Offset: 0x002F618E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600C115 RID: 49429 RVA: 0x002F7F98 File Offset: 0x002F6198
		public static RegressDisposableReward GetRootAsRegressDisposableReward(ByteBuffer _bb)
		{
			return RegressDisposableReward.GetRootAsRegressDisposableReward(_bb, default(RegressDisposableReward));
		}

		// Token: 0x0600C116 RID: 49430 RVA: 0x002F7FB4 File Offset: 0x002F61B4
		public static RegressDisposableReward GetRootAsRegressDisposableReward(ByteBuffer _bb, RegressDisposableReward obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600C117 RID: 49431 RVA: 0x002F7FD1 File Offset: 0x002F61D1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600C118 RID: 49432 RVA: 0x002F7FE0 File Offset: 0x002F61E0
		public RegressDisposableReward __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002E0C RID: 11788
		// (get) Token: 0x0600C119 RID: 49433 RVA: 0x002F7FF0 File Offset: 0x002F61F0
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

		// Token: 0x17002E0D RID: 11789
		// (get) Token: 0x0600C11A RID: 49434 RVA: 0x002F802C File Offset: 0x002F622C
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

		// Token: 0x17002E0E RID: 11790
		// (get) Token: 0x0600C11B RID: 49435 RVA: 0x002F8068 File Offset: 0x002F6268
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

		// Token: 0x17002E0F RID: 11791
		// (get) Token: 0x0600C11C RID: 49436 RVA: 0x002F80A4 File Offset: 0x002F62A4
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

		// Token: 0x17002E10 RID: 11792
		// (get) Token: 0x0600C11D RID: 49437 RVA: 0x002F80E4 File Offset: 0x002F62E4
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

		// Token: 0x17002E11 RID: 11793
		// (get) Token: 0x0600C11E RID: 49438 RVA: 0x002F8124 File Offset: 0x002F6324
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

		// Token: 0x17002E12 RID: 11794
		// (get) Token: 0x0600C11F RID: 49439 RVA: 0x002F8164 File Offset: 0x002F6364
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

		// Token: 0x0400566C RID: 22124
		private Table __p;
	}
}
