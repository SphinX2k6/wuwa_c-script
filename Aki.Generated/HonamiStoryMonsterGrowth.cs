using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E26 RID: 3622
	public struct HonamiStoryMonsterGrowth : IFlatbufferObject
	{
		// Token: 0x1700184F RID: 6223
		// (get) Token: 0x060086A2 RID: 34466 RVA: 0x002772F0 File Offset: 0x002754F0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060086A3 RID: 34467 RVA: 0x002772FD File Offset: 0x002754FD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060086A4 RID: 34468 RVA: 0x00277304 File Offset: 0x00275504
		public static HonamiStoryMonsterGrowth GetRootAsHonamiStoryMonsterGrowth(ByteBuffer _bb)
		{
			return HonamiStoryMonsterGrowth.GetRootAsHonamiStoryMonsterGrowth(_bb, default(HonamiStoryMonsterGrowth));
		}

		// Token: 0x060086A5 RID: 34469 RVA: 0x00277320 File Offset: 0x00275520
		public static HonamiStoryMonsterGrowth GetRootAsHonamiStoryMonsterGrowth(ByteBuffer _bb, HonamiStoryMonsterGrowth obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060086A6 RID: 34470 RVA: 0x0027733D File Offset: 0x0027553D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060086A7 RID: 34471 RVA: 0x0027734C File Offset: 0x0027554C
		public HonamiStoryMonsterGrowth __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001850 RID: 6224
		// (get) Token: 0x060086A8 RID: 34472 RVA: 0x0027735C File Offset: 0x0027555C
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

		// Token: 0x17001851 RID: 6225
		// (get) Token: 0x060086A9 RID: 34473 RVA: 0x00277398 File Offset: 0x00275598
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

		// Token: 0x17001852 RID: 6226
		// (get) Token: 0x060086AA RID: 34474 RVA: 0x002773D4 File Offset: 0x002755D4
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

		// Token: 0x17001853 RID: 6227
		// (get) Token: 0x060086AB RID: 34475 RVA: 0x00277410 File Offset: 0x00275610
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

		// Token: 0x17001854 RID: 6228
		// (get) Token: 0x060086AC RID: 34476 RVA: 0x00277450 File Offset: 0x00275650
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

		// Token: 0x040053A1 RID: 21409
		private Table __p;
	}
}
