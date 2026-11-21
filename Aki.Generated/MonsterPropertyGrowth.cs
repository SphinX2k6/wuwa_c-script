using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F00 RID: 3840
	public struct MonsterPropertyGrowth : IFlatbufferObject
	{
		// Token: 0x17001FF3 RID: 8179
		// (get) Token: 0x06009B91 RID: 39825 RVA: 0x002A6285 File Offset: 0x002A4485
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06009B92 RID: 39826 RVA: 0x002A6292 File Offset: 0x002A4492
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06009B93 RID: 39827 RVA: 0x002A629C File Offset: 0x002A449C
		public static MonsterPropertyGrowth GetRootAsMonsterPropertyGrowth(ByteBuffer _bb)
		{
			return MonsterPropertyGrowth.GetRootAsMonsterPropertyGrowth(_bb, default(MonsterPropertyGrowth));
		}

		// Token: 0x06009B94 RID: 39828 RVA: 0x002A62B8 File Offset: 0x002A44B8
		public static MonsterPropertyGrowth GetRootAsMonsterPropertyGrowth(ByteBuffer _bb, MonsterPropertyGrowth obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06009B95 RID: 39829 RVA: 0x002A62D5 File Offset: 0x002A44D5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06009B96 RID: 39830 RVA: 0x002A62E4 File Offset: 0x002A44E4
		public MonsterPropertyGrowth __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001FF4 RID: 8180
		// (get) Token: 0x06009B97 RID: 39831 RVA: 0x002A62F4 File Offset: 0x002A44F4
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

		// Token: 0x17001FF5 RID: 8181
		// (get) Token: 0x06009B98 RID: 39832 RVA: 0x002A6330 File Offset: 0x002A4530
		public int CurveId
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

		// Token: 0x17001FF6 RID: 8182
		// (get) Token: 0x06009B99 RID: 39833 RVA: 0x002A636C File Offset: 0x002A456C
		public int Level
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

		// Token: 0x17001FF7 RID: 8183
		// (get) Token: 0x06009B9A RID: 39834 RVA: 0x002A63A8 File Offset: 0x002A45A8
		public int LifeMaxRatio
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

		// Token: 0x17001FF8 RID: 8184
		// (get) Token: 0x06009B9B RID: 39835 RVA: 0x002A63E8 File Offset: 0x002A45E8
		public int AtkRatio
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

		// Token: 0x17001FF9 RID: 8185
		// (get) Token: 0x06009B9C RID: 39836 RVA: 0x002A6428 File Offset: 0x002A4628
		public int DefRatio
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

		// Token: 0x17001FFA RID: 8186
		// (get) Token: 0x06009B9D RID: 39837 RVA: 0x002A6468 File Offset: 0x002A4668
		public int HardnessMaxRatio
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001FFB RID: 8187
		// (get) Token: 0x06009B9E RID: 39838 RVA: 0x002A64A8 File Offset: 0x002A46A8
		public int HardnessRatio
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001FFC RID: 8188
		// (get) Token: 0x06009B9F RID: 39839 RVA: 0x002A64E8 File Offset: 0x002A46E8
		public int HardnessRecoverRatio
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001FFD RID: 8189
		// (get) Token: 0x06009BA0 RID: 39840 RVA: 0x002A6528 File Offset: 0x002A4728
		public int RageMaxRatio
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001FFE RID: 8190
		// (get) Token: 0x06009BA1 RID: 39841 RVA: 0x002A6568 File Offset: 0x002A4768
		public int RageRatio
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001FFF RID: 8191
		// (get) Token: 0x06009BA2 RID: 39842 RVA: 0x002A65A8 File Offset: 0x002A47A8
		public int RageRecoverRatio
		{
			get
			{
				int num = this.__p.__offset(26);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17002000 RID: 8192
		// (get) Token: 0x06009BA3 RID: 39843 RVA: 0x002A65E8 File Offset: 0x002A47E8
		public int WeaknessBuildUpMaxRatio
		{
			get
			{
				int num = this.__p.__offset(28);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x040054A5 RID: 21669
		private Table __p;
	}
}
