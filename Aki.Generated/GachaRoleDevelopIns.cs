using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000DC5 RID: 3525
	public struct GachaRoleDevelopIns : IFlatbufferObject
	{
		// Token: 0x17001509 RID: 5385
		// (get) Token: 0x06007E31 RID: 32305 RVA: 0x00264AA5 File Offset: 0x00262CA5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06007E32 RID: 32306 RVA: 0x00264AB2 File Offset: 0x00262CB2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06007E33 RID: 32307 RVA: 0x00264ABC File Offset: 0x00262CBC
		public static GachaRoleDevelopIns GetRootAsGachaRoleDevelopIns(ByteBuffer _bb)
		{
			return GachaRoleDevelopIns.GetRootAsGachaRoleDevelopIns(_bb, default(GachaRoleDevelopIns));
		}

		// Token: 0x06007E34 RID: 32308 RVA: 0x00264AD8 File Offset: 0x00262CD8
		public static GachaRoleDevelopIns GetRootAsGachaRoleDevelopIns(ByteBuffer _bb, GachaRoleDevelopIns obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06007E35 RID: 32309 RVA: 0x00264AF5 File Offset: 0x00262CF5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06007E36 RID: 32310 RVA: 0x00264B04 File Offset: 0x00262D04
		public GachaRoleDevelopIns __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700150A RID: 5386
		// (get) Token: 0x06007E37 RID: 32311 RVA: 0x00264B14 File Offset: 0x00262D14
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

		// Token: 0x1700150B RID: 5387
		// (get) Token: 0x06007E38 RID: 32312 RVA: 0x00264B50 File Offset: 0x00262D50
		public int RoleId
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

		// Token: 0x1700150C RID: 5388
		// (get) Token: 0x06007E39 RID: 32313 RVA: 0x00264B8C File Offset: 0x00262D8C
		public int AdventureGuide
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

		// Token: 0x1700150D RID: 5389
		// (get) Token: 0x06007E3A RID: 32314 RVA: 0x00264BC8 File Offset: 0x00262DC8
		public int DungeonDetection
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

		// Token: 0x1700150E RID: 5390
		// (get) Token: 0x06007E3B RID: 32315 RVA: 0x00264C08 File Offset: 0x00262E08
		public int Type
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

		// Token: 0x1700150F RID: 5391
		// (get) Token: 0x06007E3C RID: 32316 RVA: 0x00264C48 File Offset: 0x00262E48
		public int DungeonEntranceId
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001510 RID: 5392
		// (get) Token: 0x06007E3D RID: 32317 RVA: 0x00264C88 File Offset: 0x00262E88
		public int LevelPlayParam
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 36;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x04005336 RID: 21302
		private Table __p;
	}
}
