using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D7B RID: 3451
	public struct FlagChallengeRoleGrowth : IFlatbufferObject
	{
		// Token: 0x17001290 RID: 4752
		// (get) Token: 0x06007789 RID: 30601 RVA: 0x00255451 File Offset: 0x00253651
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600778A RID: 30602 RVA: 0x0025545E File Offset: 0x0025365E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600778B RID: 30603 RVA: 0x00255468 File Offset: 0x00253668
		public static FlagChallengeRoleGrowth GetRootAsFlagChallengeRoleGrowth(ByteBuffer _bb)
		{
			return FlagChallengeRoleGrowth.GetRootAsFlagChallengeRoleGrowth(_bb, default(FlagChallengeRoleGrowth));
		}

		// Token: 0x0600778C RID: 30604 RVA: 0x00255484 File Offset: 0x00253684
		public static FlagChallengeRoleGrowth GetRootAsFlagChallengeRoleGrowth(ByteBuffer _bb, FlagChallengeRoleGrowth obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600778D RID: 30605 RVA: 0x002554A1 File Offset: 0x002536A1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600778E RID: 30606 RVA: 0x002554B0 File Offset: 0x002536B0
		public FlagChallengeRoleGrowth __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001291 RID: 4753
		// (get) Token: 0x0600778F RID: 30607 RVA: 0x002554C0 File Offset: 0x002536C0
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

		// Token: 0x17001292 RID: 4754
		// (get) Token: 0x06007790 RID: 30608 RVA: 0x002554FC File Offset: 0x002536FC
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

		// Token: 0x17001293 RID: 4755
		// (get) Token: 0x06007791 RID: 30609 RVA: 0x00255538 File Offset: 0x00253738
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

		// Token: 0x17001294 RID: 4756
		// (get) Token: 0x06007792 RID: 30610 RVA: 0x00255574 File Offset: 0x00253774
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

		// Token: 0x17001295 RID: 4757
		// (get) Token: 0x06007793 RID: 30611 RVA: 0x002555B4 File Offset: 0x002537B4
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

		// Token: 0x17001296 RID: 4758
		// (get) Token: 0x06007794 RID: 30612 RVA: 0x002555F4 File Offset: 0x002537F4
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

		// Token: 0x040052D2 RID: 21202
		private Table __p;
	}
}
