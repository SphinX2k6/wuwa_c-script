using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B2D RID: 2861
	public struct BattleScoreConf : IFlatbufferObject
	{
		// Token: 0x170004FB RID: 1275
		// (get) Token: 0x06004CC8 RID: 19656 RVA: 0x001E27A0 File Offset: 0x001E09A0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06004CC9 RID: 19657 RVA: 0x001E27AD File Offset: 0x001E09AD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06004CCA RID: 19658 RVA: 0x001E27B4 File Offset: 0x001E09B4
		public static BattleScoreConf GetRootAsBattleScoreConf(ByteBuffer _bb)
		{
			return BattleScoreConf.GetRootAsBattleScoreConf(_bb, default(BattleScoreConf));
		}

		// Token: 0x06004CCB RID: 19659 RVA: 0x001E27D0 File Offset: 0x001E09D0
		public static BattleScoreConf GetRootAsBattleScoreConf(ByteBuffer _bb, BattleScoreConf obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06004CCC RID: 19660 RVA: 0x001E27ED File Offset: 0x001E09ED
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06004CCD RID: 19661 RVA: 0x001E27FC File Offset: 0x001E09FC
		public BattleScoreConf __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170004FC RID: 1276
		// (get) Token: 0x06004CCE RID: 19662 RVA: 0x001E280C File Offset: 0x001E0A0C
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

		// Token: 0x170004FD RID: 1277
		// (get) Token: 0x06004CCF RID: 19663 RVA: 0x001E2848 File Offset: 0x001E0A48
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

		// Token: 0x170004FE RID: 1278
		// (get) Token: 0x06004CD0 RID: 19664 RVA: 0x001E2884 File Offset: 0x001E0A84
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

		// Token: 0x04004B25 RID: 19237
		private Table __p;
	}
}
