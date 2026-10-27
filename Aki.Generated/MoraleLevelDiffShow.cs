using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E28 RID: 3624
	public struct MoraleLevelDiffShow : IFlatbufferObject
	{
		// Token: 0x17001FDD RID: 8157
		// (get) Token: 0x0600963B RID: 38459 RVA: 0x00289F60 File Offset: 0x00288160
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600963C RID: 38460 RVA: 0x00289F6D File Offset: 0x0028816D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600963D RID: 38461 RVA: 0x00289F74 File Offset: 0x00288174
		public static MoraleLevelDiffShow GetRootAsMoraleLevelDiffShow(ByteBuffer _bb)
		{
			return MoraleLevelDiffShow.GetRootAsMoraleLevelDiffShow(_bb, default(MoraleLevelDiffShow));
		}

		// Token: 0x0600963E RID: 38462 RVA: 0x00289F90 File Offset: 0x00288190
		public static MoraleLevelDiffShow GetRootAsMoraleLevelDiffShow(ByteBuffer _bb, MoraleLevelDiffShow obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600963F RID: 38463 RVA: 0x00289FAD File Offset: 0x002881AD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06009640 RID: 38464 RVA: 0x00289FBC File Offset: 0x002881BC
		public MoraleLevelDiffShow __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001FDE RID: 8158
		// (get) Token: 0x06009641 RID: 38465 RVA: 0x00289FCC File Offset: 0x002881CC
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

		// Token: 0x17001FDF RID: 8159
		// (get) Token: 0x06009642 RID: 38466 RVA: 0x0028A008 File Offset: 0x00288208
		public int LevelDiffLower
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

		// Token: 0x17001FE0 RID: 8160
		// (get) Token: 0x06009643 RID: 38467 RVA: 0x0028A044 File Offset: 0x00288244
		public int LevelDiffUpper
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

		// Token: 0x17001FE1 RID: 8161
		// (get) Token: 0x06009644 RID: 38468 RVA: 0x0028A080 File Offset: 0x00288280
		public int MonsterLevelPattern
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

		// Token: 0x04004ECD RID: 20173
		private Table __p;
	}
}
