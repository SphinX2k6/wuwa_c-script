using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C94 RID: 3220
	public struct FlagChallengeMonGrowth : IFlatbufferObject
	{
		// Token: 0x1700121D RID: 4637
		// (get) Token: 0x0600714A RID: 29002 RVA: 0x00235D55 File Offset: 0x00233F55
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600714B RID: 29003 RVA: 0x00235D62 File Offset: 0x00233F62
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600714C RID: 29004 RVA: 0x00235D6C File Offset: 0x00233F6C
		public static FlagChallengeMonGrowth GetRootAsFlagChallengeMonGrowth(ByteBuffer _bb)
		{
			return FlagChallengeMonGrowth.GetRootAsFlagChallengeMonGrowth(_bb, default(FlagChallengeMonGrowth));
		}

		// Token: 0x0600714D RID: 29005 RVA: 0x00235D88 File Offset: 0x00233F88
		public static FlagChallengeMonGrowth GetRootAsFlagChallengeMonGrowth(ByteBuffer _bb, FlagChallengeMonGrowth obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600714E RID: 29006 RVA: 0x00235DA5 File Offset: 0x00233FA5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600714F RID: 29007 RVA: 0x00235DB4 File Offset: 0x00233FB4
		public FlagChallengeMonGrowth __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700121E RID: 4638
		// (get) Token: 0x06007150 RID: 29008 RVA: 0x00235DC4 File Offset: 0x00233FC4
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

		// Token: 0x1700121F RID: 4639
		// (get) Token: 0x06007151 RID: 29009 RVA: 0x00235E00 File Offset: 0x00234000
		public int Level
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

		// Token: 0x17001220 RID: 4640
		// (get) Token: 0x06007152 RID: 29010 RVA: 0x00235E3C File Offset: 0x0023403C
		public int ActivityId
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

		// Token: 0x17001221 RID: 4641
		// (get) Token: 0x06007153 RID: 29011 RVA: 0x00235E78 File Offset: 0x00234078
		public int LifeMaxRatio
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

		// Token: 0x17001222 RID: 4642
		// (get) Token: 0x06007154 RID: 29012 RVA: 0x00235EB8 File Offset: 0x002340B8
		public int AtkRatio
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

		// Token: 0x17001223 RID: 4643
		// (get) Token: 0x06007155 RID: 29013 RVA: 0x00235EF8 File Offset: 0x002340F8
		public int DefRatio
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

		// Token: 0x04004CEB RID: 19691
		private Table __p;
	}
}
