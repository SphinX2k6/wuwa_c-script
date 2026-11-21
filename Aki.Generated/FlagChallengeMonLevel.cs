using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D79 RID: 3449
	public struct FlagChallengeMonLevel : IFlatbufferObject
	{
		// Token: 0x17001281 RID: 4737
		// (get) Token: 0x06007761 RID: 30561 RVA: 0x00254F39 File Offset: 0x00253139
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06007762 RID: 30562 RVA: 0x00254F46 File Offset: 0x00253146
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06007763 RID: 30563 RVA: 0x00254F50 File Offset: 0x00253150
		public static FlagChallengeMonLevel GetRootAsFlagChallengeMonLevel(ByteBuffer _bb)
		{
			return FlagChallengeMonLevel.GetRootAsFlagChallengeMonLevel(_bb, default(FlagChallengeMonLevel));
		}

		// Token: 0x06007764 RID: 30564 RVA: 0x00254F6C File Offset: 0x0025316C
		public static FlagChallengeMonLevel GetRootAsFlagChallengeMonLevel(ByteBuffer _bb, FlagChallengeMonLevel obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06007765 RID: 30565 RVA: 0x00254F89 File Offset: 0x00253189
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06007766 RID: 30566 RVA: 0x00254F98 File Offset: 0x00253198
		public FlagChallengeMonLevel __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001282 RID: 4738
		// (get) Token: 0x06007767 RID: 30567 RVA: 0x00254FA8 File Offset: 0x002531A8
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

		// Token: 0x17001283 RID: 4739
		// (get) Token: 0x06007768 RID: 30568 RVA: 0x00254FE4 File Offset: 0x002531E4
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

		// Token: 0x17001284 RID: 4740
		// (get) Token: 0x06007769 RID: 30569 RVA: 0x00255020 File Offset: 0x00253220
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

		// Token: 0x17001285 RID: 4741
		// (get) Token: 0x0600776A RID: 30570 RVA: 0x0025505C File Offset: 0x0025325C
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

		// Token: 0x040052D0 RID: 21200
		private Table __p;
	}
}
