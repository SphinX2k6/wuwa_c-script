using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D77 RID: 3447
	public struct FlagChallengeLevelDiffShow : IFlatbufferObject
	{
		// Token: 0x17001274 RID: 4724
		// (get) Token: 0x0600774A RID: 30538 RVA: 0x00254BBA File Offset: 0x00252DBA
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600774B RID: 30539 RVA: 0x00254BC7 File Offset: 0x00252DC7
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600774C RID: 30540 RVA: 0x00254BD0 File Offset: 0x00252DD0
		public static FlagChallengeLevelDiffShow GetRootAsFlagChallengeLevelDiffShow(ByteBuffer _bb)
		{
			return FlagChallengeLevelDiffShow.GetRootAsFlagChallengeLevelDiffShow(_bb, default(FlagChallengeLevelDiffShow));
		}

		// Token: 0x0600774D RID: 30541 RVA: 0x00254BEC File Offset: 0x00252DEC
		public static FlagChallengeLevelDiffShow GetRootAsFlagChallengeLevelDiffShow(ByteBuffer _bb, FlagChallengeLevelDiffShow obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600774E RID: 30542 RVA: 0x00254C09 File Offset: 0x00252E09
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600774F RID: 30543 RVA: 0x00254C18 File Offset: 0x00252E18
		public FlagChallengeLevelDiffShow __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001275 RID: 4725
		// (get) Token: 0x06007750 RID: 30544 RVA: 0x00254C28 File Offset: 0x00252E28
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

		// Token: 0x17001276 RID: 4726
		// (get) Token: 0x06007751 RID: 30545 RVA: 0x00254C64 File Offset: 0x00252E64
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

		// Token: 0x17001277 RID: 4727
		// (get) Token: 0x06007752 RID: 30546 RVA: 0x00254CA0 File Offset: 0x00252EA0
		public int LevelDiffLower
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

		// Token: 0x17001278 RID: 4728
		// (get) Token: 0x06007753 RID: 30547 RVA: 0x00254CDC File Offset: 0x00252EDC
		public int LevelDiffUpper
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

		// Token: 0x17001279 RID: 4729
		// (get) Token: 0x06007754 RID: 30548 RVA: 0x00254D1C File Offset: 0x00252F1C
		public int LevelPattern
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

		// Token: 0x040052CE RID: 21198
		private Table __p;
	}
}
