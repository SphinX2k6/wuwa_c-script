using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E27 RID: 3623
	public struct MoraleLevelDiff : IFlatbufferObject
	{
		// Token: 0x17001FD9 RID: 8153
		// (get) Token: 0x06009632 RID: 38450 RVA: 0x00289E39 File Offset: 0x00288039
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06009633 RID: 38451 RVA: 0x00289E46 File Offset: 0x00288046
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06009634 RID: 38452 RVA: 0x00289E50 File Offset: 0x00288050
		public static MoraleLevelDiff GetRootAsMoraleLevelDiff(ByteBuffer _bb)
		{
			return MoraleLevelDiff.GetRootAsMoraleLevelDiff(_bb, default(MoraleLevelDiff));
		}

		// Token: 0x06009635 RID: 38453 RVA: 0x00289E6C File Offset: 0x0028806C
		public static MoraleLevelDiff GetRootAsMoraleLevelDiff(ByteBuffer _bb, MoraleLevelDiff obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06009636 RID: 38454 RVA: 0x00289E89 File Offset: 0x00288089
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06009637 RID: 38455 RVA: 0x00289E98 File Offset: 0x00288098
		public MoraleLevelDiff __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001FDA RID: 8154
		// (get) Token: 0x06009638 RID: 38456 RVA: 0x00289EA8 File Offset: 0x002880A8
		public int Level
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

		// Token: 0x17001FDB RID: 8155
		// (get) Token: 0x06009639 RID: 38457 RVA: 0x00289EE4 File Offset: 0x002880E4
		public int DamageRatio
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

		// Token: 0x17001FDC RID: 8156
		// (get) Token: 0x0600963A RID: 38458 RVA: 0x00289F20 File Offset: 0x00288120
		public int DropRatio
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 10000;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x04004ECC RID: 20172
		private Table __p;
	}
}
