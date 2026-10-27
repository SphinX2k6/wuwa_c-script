using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C93 RID: 3219
	public struct FlagChallengeLevelDiffShow : IFlatbufferObject
	{
		// Token: 0x17001217 RID: 4631
		// (get) Token: 0x0600713F RID: 28991 RVA: 0x00235BB5 File Offset: 0x00233DB5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06007140 RID: 28992 RVA: 0x00235BC2 File Offset: 0x00233DC2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06007141 RID: 28993 RVA: 0x00235BCC File Offset: 0x00233DCC
		public static FlagChallengeLevelDiffShow GetRootAsFlagChallengeLevelDiffShow(ByteBuffer _bb)
		{
			return FlagChallengeLevelDiffShow.GetRootAsFlagChallengeLevelDiffShow(_bb, default(FlagChallengeLevelDiffShow));
		}

		// Token: 0x06007142 RID: 28994 RVA: 0x00235BE8 File Offset: 0x00233DE8
		public static FlagChallengeLevelDiffShow GetRootAsFlagChallengeLevelDiffShow(ByteBuffer _bb, FlagChallengeLevelDiffShow obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06007143 RID: 28995 RVA: 0x00235C05 File Offset: 0x00233E05
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06007144 RID: 28996 RVA: 0x00235C14 File Offset: 0x00233E14
		public FlagChallengeLevelDiffShow __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001218 RID: 4632
		// (get) Token: 0x06007145 RID: 28997 RVA: 0x00235C24 File Offset: 0x00233E24
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

		// Token: 0x17001219 RID: 4633
		// (get) Token: 0x06007146 RID: 28998 RVA: 0x00235C60 File Offset: 0x00233E60
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

		// Token: 0x1700121A RID: 4634
		// (get) Token: 0x06007147 RID: 28999 RVA: 0x00235C9C File Offset: 0x00233E9C
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

		// Token: 0x1700121B RID: 4635
		// (get) Token: 0x06007148 RID: 29000 RVA: 0x00235CD8 File Offset: 0x00233ED8
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

		// Token: 0x1700121C RID: 4636
		// (get) Token: 0x06007149 RID: 29001 RVA: 0x00235D18 File Offset: 0x00233F18
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

		// Token: 0x04004CEA RID: 19690
		private Table __p;
	}
}
