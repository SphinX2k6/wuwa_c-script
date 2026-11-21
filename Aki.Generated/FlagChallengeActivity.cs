using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D74 RID: 3444
	public struct FlagChallengeActivity : IFlatbufferObject
	{
		// Token: 0x1700125B RID: 4699
		// (get) Token: 0x06007704 RID: 30468 RVA: 0x002542B2 File Offset: 0x002524B2
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06007705 RID: 30469 RVA: 0x002542BF File Offset: 0x002524BF
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06007706 RID: 30470 RVA: 0x002542C8 File Offset: 0x002524C8
		public static FlagChallengeActivity GetRootAsFlagChallengeActivity(ByteBuffer _bb)
		{
			return FlagChallengeActivity.GetRootAsFlagChallengeActivity(_bb, default(FlagChallengeActivity));
		}

		// Token: 0x06007707 RID: 30471 RVA: 0x002542E4 File Offset: 0x002524E4
		public static FlagChallengeActivity GetRootAsFlagChallengeActivity(ByteBuffer _bb, FlagChallengeActivity obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06007708 RID: 30472 RVA: 0x00254301 File Offset: 0x00252501
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06007709 RID: 30473 RVA: 0x00254310 File Offset: 0x00252510
		public FlagChallengeActivity __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700125C RID: 4700
		// (get) Token: 0x0600770A RID: 30474 RVA: 0x00254320 File Offset: 0x00252520
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

		// Token: 0x1700125D RID: 4701
		// (get) Token: 0x0600770B RID: 30475 RVA: 0x0025435C File Offset: 0x0025255C
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

		// Token: 0x1700125E RID: 4702
		// (get) Token: 0x0600770C RID: 30476 RVA: 0x00254398 File Offset: 0x00252598
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

		// Token: 0x1700125F RID: 4703
		// (get) Token: 0x0600770D RID: 30477 RVA: 0x002543D4 File Offset: 0x002525D4
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

		// Token: 0x040052CB RID: 21195
		private Table __p;
	}
}
