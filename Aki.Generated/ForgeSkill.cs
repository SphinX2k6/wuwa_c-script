using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000CCC RID: 3276
	public struct ForgeSkill : IFlatbufferObject
	{
		// Token: 0x17001406 RID: 5126
		// (get) Token: 0x0600767F RID: 30335 RVA: 0x00242429 File Offset: 0x00240629
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06007680 RID: 30336 RVA: 0x00242436 File Offset: 0x00240636
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06007681 RID: 30337 RVA: 0x00242440 File Offset: 0x00240640
		public static ForgeSkill GetRootAsForgeSkill(ByteBuffer _bb)
		{
			return ForgeSkill.GetRootAsForgeSkill(_bb, default(ForgeSkill));
		}

		// Token: 0x06007682 RID: 30338 RVA: 0x0024245C File Offset: 0x0024065C
		public static ForgeSkill GetRootAsForgeSkill(ByteBuffer _bb, ForgeSkill obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06007683 RID: 30339 RVA: 0x00242479 File Offset: 0x00240679
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06007684 RID: 30340 RVA: 0x00242488 File Offset: 0x00240688
		public ForgeSkill __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001407 RID: 5127
		// (get) Token: 0x06007685 RID: 30341 RVA: 0x00242498 File Offset: 0x00240698
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

		// Token: 0x17001408 RID: 5128
		// (get) Token: 0x06007686 RID: 30342 RVA: 0x002424D4 File Offset: 0x002406D4
		public int ExtraItemId
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

		// Token: 0x17001409 RID: 5129
		// (get) Token: 0x06007687 RID: 30343 RVA: 0x00242510 File Offset: 0x00240710
		public int EffectiveProbability
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

		// Token: 0x1700140A RID: 5130
		// (get) Token: 0x06007688 RID: 30344 RVA: 0x0024254C File Offset: 0x0024074C
		public int Typeld
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

		// Token: 0x1700140B RID: 5131
		// (get) Token: 0x06007689 RID: 30345 RVA: 0x0024258C File Offset: 0x0024078C
		public int SkillDescription
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

		// Token: 0x04004D3C RID: 19772
		private Table __p;
	}
}
