using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C0D RID: 3085
	public struct BattleScoreConf : IFlatbufferObject
	{
		// Token: 0x1700053B RID: 1339
		// (get) Token: 0x0600528A RID: 21130 RVA: 0x00202B9C File Offset: 0x00200D9C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600528B RID: 21131 RVA: 0x00202BA9 File Offset: 0x00200DA9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600528C RID: 21132 RVA: 0x00202BB0 File Offset: 0x00200DB0
		public static BattleScoreConf GetRootAsBattleScoreConf(ByteBuffer _bb)
		{
			return BattleScoreConf.GetRootAsBattleScoreConf(_bb, default(BattleScoreConf));
		}

		// Token: 0x0600528D RID: 21133 RVA: 0x00202BCC File Offset: 0x00200DCC
		public static BattleScoreConf GetRootAsBattleScoreConf(ByteBuffer _bb, BattleScoreConf obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600528E RID: 21134 RVA: 0x00202BE9 File Offset: 0x00200DE9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600528F RID: 21135 RVA: 0x00202BF8 File Offset: 0x00200DF8
		public BattleScoreConf __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700053C RID: 1340
		// (get) Token: 0x06005290 RID: 21136 RVA: 0x00202C08 File Offset: 0x00200E08
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

		// Token: 0x1700053D RID: 1341
		// (get) Token: 0x06005291 RID: 21137 RVA: 0x00202C44 File Offset: 0x00200E44
		public int Type
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

		// Token: 0x1700053E RID: 1342
		// (get) Token: 0x06005292 RID: 21138 RVA: 0x00202C80 File Offset: 0x00200E80
		public int LevelGroupId
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

		// Token: 0x04005105 RID: 20741
		private Table __p;
	}
}
