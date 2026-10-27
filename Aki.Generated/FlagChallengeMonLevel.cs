using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C95 RID: 3221
	public struct FlagChallengeMonLevel : IFlatbufferObject
	{
		// Token: 0x17001224 RID: 4644
		// (get) Token: 0x06007156 RID: 29014 RVA: 0x00235F35 File Offset: 0x00234135
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06007157 RID: 29015 RVA: 0x00235F42 File Offset: 0x00234142
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06007158 RID: 29016 RVA: 0x00235F4C File Offset: 0x0023414C
		public static FlagChallengeMonLevel GetRootAsFlagChallengeMonLevel(ByteBuffer _bb)
		{
			return FlagChallengeMonLevel.GetRootAsFlagChallengeMonLevel(_bb, default(FlagChallengeMonLevel));
		}

		// Token: 0x06007159 RID: 29017 RVA: 0x00235F68 File Offset: 0x00234168
		public static FlagChallengeMonLevel GetRootAsFlagChallengeMonLevel(ByteBuffer _bb, FlagChallengeMonLevel obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600715A RID: 29018 RVA: 0x00235F85 File Offset: 0x00234185
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600715B RID: 29019 RVA: 0x00235F94 File Offset: 0x00234194
		public FlagChallengeMonLevel __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001225 RID: 4645
		// (get) Token: 0x0600715C RID: 29020 RVA: 0x00235FA4 File Offset: 0x002341A4
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

		// Token: 0x17001226 RID: 4646
		// (get) Token: 0x0600715D RID: 29021 RVA: 0x00235FE0 File Offset: 0x002341E0
		public int ChallengeLevelId
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

		// Token: 0x17001227 RID: 4647
		// (get) Token: 0x0600715E RID: 29022 RVA: 0x0023601C File Offset: 0x0023421C
		public int PropGroup
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

		// Token: 0x17001228 RID: 4648
		// (get) Token: 0x0600715F RID: 29023 RVA: 0x00236058 File Offset: 0x00234258
		public int Level
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

		// Token: 0x04004CEC RID: 19692
		private Table __p;
	}
}
