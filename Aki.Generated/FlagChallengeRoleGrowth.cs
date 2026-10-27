using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C97 RID: 3223
	public struct FlagChallengeRoleGrowth : IFlatbufferObject
	{
		// Token: 0x17001233 RID: 4659
		// (get) Token: 0x0600717E RID: 29054 RVA: 0x00236469 File Offset: 0x00234669
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600717F RID: 29055 RVA: 0x00236476 File Offset: 0x00234676
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06007180 RID: 29056 RVA: 0x00236480 File Offset: 0x00234680
		public static FlagChallengeRoleGrowth GetRootAsFlagChallengeRoleGrowth(ByteBuffer _bb)
		{
			return FlagChallengeRoleGrowth.GetRootAsFlagChallengeRoleGrowth(_bb, default(FlagChallengeRoleGrowth));
		}

		// Token: 0x06007181 RID: 29057 RVA: 0x0023649C File Offset: 0x0023469C
		public static FlagChallengeRoleGrowth GetRootAsFlagChallengeRoleGrowth(ByteBuffer _bb, FlagChallengeRoleGrowth obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06007182 RID: 29058 RVA: 0x002364B9 File Offset: 0x002346B9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06007183 RID: 29059 RVA: 0x002364C8 File Offset: 0x002346C8
		public FlagChallengeRoleGrowth __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001234 RID: 4660
		// (get) Token: 0x06007184 RID: 29060 RVA: 0x002364D8 File Offset: 0x002346D8
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

		// Token: 0x17001235 RID: 4661
		// (get) Token: 0x06007185 RID: 29061 RVA: 0x00236514 File Offset: 0x00234714
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

		// Token: 0x17001236 RID: 4662
		// (get) Token: 0x06007186 RID: 29062 RVA: 0x00236550 File Offset: 0x00234750
		public int Level
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

		// Token: 0x17001237 RID: 4663
		// (get) Token: 0x06007187 RID: 29063 RVA: 0x0023658C File Offset: 0x0023478C
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

		// Token: 0x17001238 RID: 4664
		// (get) Token: 0x06007188 RID: 29064 RVA: 0x002365CC File Offset: 0x002347CC
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

		// Token: 0x17001239 RID: 4665
		// (get) Token: 0x06007189 RID: 29065 RVA: 0x0023660C File Offset: 0x0023480C
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

		// Token: 0x04004CEE RID: 19694
		private Table __p;
	}
}
