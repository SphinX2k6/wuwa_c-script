using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001143 RID: 4419
	public struct TowerSeason : IFlatbufferObject
	{
		// Token: 0x17003B07 RID: 15111
		// (get) Token: 0x0600E06B RID: 57451 RVA: 0x003316A6 File Offset: 0x0032F8A6
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600E06C RID: 57452 RVA: 0x003316B3 File Offset: 0x0032F8B3
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600E06D RID: 57453 RVA: 0x003316BC File Offset: 0x0032F8BC
		public static TowerSeason GetRootAsTowerSeason(ByteBuffer _bb)
		{
			return TowerSeason.GetRootAsTowerSeason(_bb, default(TowerSeason));
		}

		// Token: 0x0600E06E RID: 57454 RVA: 0x003316D8 File Offset: 0x0032F8D8
		public static TowerSeason GetRootAsTowerSeason(ByteBuffer _bb, TowerSeason obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600E06F RID: 57455 RVA: 0x003316F5 File Offset: 0x0032F8F5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600E070 RID: 57456 RVA: 0x00331704 File Offset: 0x0032F904
		public TowerSeason __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003B08 RID: 15112
		// (get) Token: 0x0600E071 RID: 57457 RVA: 0x00331714 File Offset: 0x0032F914
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

		// Token: 0x17003B09 RID: 15113
		// (get) Token: 0x0600E072 RID: 57458 RVA: 0x00331750 File Offset: 0x0032F950
		public int RewardGroup
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

		// Token: 0x04005285 RID: 21125
		private Table __p;
	}
}
