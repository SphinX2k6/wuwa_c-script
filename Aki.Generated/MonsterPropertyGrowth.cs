using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E1B RID: 3611
	public struct MonsterPropertyGrowth : IFlatbufferObject
	{
		// Token: 0x17001F8E RID: 8078
		// (get) Token: 0x06009571 RID: 38257 RVA: 0x00288515 File Offset: 0x00286715
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06009572 RID: 38258 RVA: 0x00288522 File Offset: 0x00286722
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06009573 RID: 38259 RVA: 0x0028852C File Offset: 0x0028672C
		public static MonsterPropertyGrowth GetRootAsMonsterPropertyGrowth(ByteBuffer _bb)
		{
			return MonsterPropertyGrowth.GetRootAsMonsterPropertyGrowth(_bb, default(MonsterPropertyGrowth));
		}

		// Token: 0x06009574 RID: 38260 RVA: 0x00288548 File Offset: 0x00286748
		public static MonsterPropertyGrowth GetRootAsMonsterPropertyGrowth(ByteBuffer _bb, MonsterPropertyGrowth obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06009575 RID: 38261 RVA: 0x00288565 File Offset: 0x00286765
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06009576 RID: 38262 RVA: 0x00288574 File Offset: 0x00286774
		public MonsterPropertyGrowth __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001F8F RID: 8079
		// (get) Token: 0x06009577 RID: 38263 RVA: 0x00288584 File Offset: 0x00286784
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

		// Token: 0x17001F90 RID: 8080
		// (get) Token: 0x06009578 RID: 38264 RVA: 0x002885C0 File Offset: 0x002867C0
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

		// Token: 0x17001F91 RID: 8081
		// (get) Token: 0x06009579 RID: 38265 RVA: 0x002885FC File Offset: 0x002867FC
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

		// Token: 0x17001F92 RID: 8082
		// (get) Token: 0x0600957A RID: 38266 RVA: 0x00288638 File Offset: 0x00286838
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

		// Token: 0x17001F93 RID: 8083
		// (get) Token: 0x0600957B RID: 38267 RVA: 0x00288678 File Offset: 0x00286878
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

		// Token: 0x17001F94 RID: 8084
		// (get) Token: 0x0600957C RID: 38268 RVA: 0x002886B8 File Offset: 0x002868B8
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

		// Token: 0x17001F95 RID: 8085
		// (get) Token: 0x0600957D RID: 38269 RVA: 0x002886F8 File Offset: 0x002868F8
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

		// Token: 0x17001F96 RID: 8086
		// (get) Token: 0x0600957E RID: 38270 RVA: 0x00288738 File Offset: 0x00286938
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

		// Token: 0x17001F97 RID: 8087
		// (get) Token: 0x0600957F RID: 38271 RVA: 0x00288778 File Offset: 0x00286978
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

		// Token: 0x17001F98 RID: 8088
		// (get) Token: 0x06009580 RID: 38272 RVA: 0x002887B8 File Offset: 0x002869B8
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

		// Token: 0x17001F99 RID: 8089
		// (get) Token: 0x06009581 RID: 38273 RVA: 0x002887F8 File Offset: 0x002869F8
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

		// Token: 0x17001F9A RID: 8090
		// (get) Token: 0x06009582 RID: 38274 RVA: 0x00288838 File Offset: 0x00286A38
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

		// Token: 0x17001F9B RID: 8091
		// (get) Token: 0x06009583 RID: 38275 RVA: 0x00288878 File Offset: 0x00286A78
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

		// Token: 0x04004EC0 RID: 20160
		private Table __p;
	}
}
