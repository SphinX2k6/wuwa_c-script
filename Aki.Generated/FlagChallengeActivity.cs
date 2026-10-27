using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C90 RID: 3216
	public struct FlagChallengeActivity : IFlatbufferObject
	{
		// Token: 0x170011FE RID: 4606
		// (get) Token: 0x060070F9 RID: 28921 RVA: 0x00235231 File Offset: 0x00233431
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060070FA RID: 28922 RVA: 0x0023523E File Offset: 0x0023343E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060070FB RID: 28923 RVA: 0x00235248 File Offset: 0x00233448
		public static FlagChallengeActivity GetRootAsFlagChallengeActivity(ByteBuffer _bb)
		{
			return FlagChallengeActivity.GetRootAsFlagChallengeActivity(_bb, default(FlagChallengeActivity));
		}

		// Token: 0x060070FC RID: 28924 RVA: 0x00235264 File Offset: 0x00233464
		public static FlagChallengeActivity GetRootAsFlagChallengeActivity(ByteBuffer _bb, FlagChallengeActivity obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060070FD RID: 28925 RVA: 0x00235281 File Offset: 0x00233481
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060070FE RID: 28926 RVA: 0x00235290 File Offset: 0x00233490
		public FlagChallengeActivity __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170011FF RID: 4607
		// (get) Token: 0x060070FF RID: 28927 RVA: 0x002352A0 File Offset: 0x002334A0
		public int ActivityId
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

		// Token: 0x17001200 RID: 4608
		// (get) Token: 0x06007100 RID: 28928 RVA: 0x002352DC File Offset: 0x002334DC
		public int ExpItemId
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

		// Token: 0x17001201 RID: 4609
		// (get) Token: 0x06007101 RID: 28929 RVA: 0x00235318 File Offset: 0x00233518
		public int BoxExpItemId
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

		// Token: 0x17001202 RID: 4610
		// (get) Token: 0x06007102 RID: 28930 RVA: 0x00235354 File Offset: 0x00233554
		public int BattleScoreId
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

		// Token: 0x04004CE7 RID: 19687
		private Table __p;
	}
}
