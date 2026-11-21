using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D42 RID: 3394
	public struct FarmGoldScore : IFlatbufferObject
	{
		// Token: 0x170010B2 RID: 4274
		// (get) Token: 0x060072C4 RID: 29380 RVA: 0x0024A6E9 File Offset: 0x002488E9
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060072C5 RID: 29381 RVA: 0x0024A6F6 File Offset: 0x002488F6
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060072C6 RID: 29382 RVA: 0x0024A700 File Offset: 0x00248900
		public static FarmGoldScore GetRootAsFarmGoldScore(ByteBuffer _bb)
		{
			return FarmGoldScore.GetRootAsFarmGoldScore(_bb, default(FarmGoldScore));
		}

		// Token: 0x060072C7 RID: 29383 RVA: 0x0024A71C File Offset: 0x0024891C
		public static FarmGoldScore GetRootAsFarmGoldScore(ByteBuffer _bb, FarmGoldScore obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060072C8 RID: 29384 RVA: 0x0024A739 File Offset: 0x00248939
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060072C9 RID: 29385 RVA: 0x0024A748 File Offset: 0x00248948
		public FarmGoldScore __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170010B3 RID: 4275
		// (get) Token: 0x060072CA RID: 29386 RVA: 0x0024A758 File Offset: 0x00248958
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

		// Token: 0x170010B4 RID: 4276
		// (get) Token: 0x060072CB RID: 29387 RVA: 0x0024A794 File Offset: 0x00248994
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

		// Token: 0x170010B5 RID: 4277
		// (get) Token: 0x060072CC RID: 29388 RVA: 0x0024A7D0 File Offset: 0x002489D0
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

		// Token: 0x170010B6 RID: 4278
		// (get) Token: 0x060072CD RID: 29389 RVA: 0x0024A80C File Offset: 0x00248A0C
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

		// Token: 0x0400528D RID: 21133
		private Table __p;
	}
}
