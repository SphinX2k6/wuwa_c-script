using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E2A RID: 3626
	public struct MoraleMonsterGrowth : IFlatbufferObject
	{
		// Token: 0x17001FEA RID: 8170
		// (get) Token: 0x0600965C RID: 38492 RVA: 0x0028A384 File Offset: 0x00288584
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600965D RID: 38493 RVA: 0x0028A391 File Offset: 0x00288591
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600965E RID: 38494 RVA: 0x0028A398 File Offset: 0x00288598
		public static MoraleMonsterGrowth GetRootAsMoraleMonsterGrowth(ByteBuffer _bb)
		{
			return MoraleMonsterGrowth.GetRootAsMoraleMonsterGrowth(_bb, default(MoraleMonsterGrowth));
		}

		// Token: 0x0600965F RID: 38495 RVA: 0x0028A3B4 File Offset: 0x002885B4
		public static MoraleMonsterGrowth GetRootAsMoraleMonsterGrowth(ByteBuffer _bb, MoraleMonsterGrowth obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06009660 RID: 38496 RVA: 0x0028A3D1 File Offset: 0x002885D1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06009661 RID: 38497 RVA: 0x0028A3E0 File Offset: 0x002885E0
		public MoraleMonsterGrowth __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001FEB RID: 8171
		// (get) Token: 0x06009662 RID: 38498 RVA: 0x0028A3F0 File Offset: 0x002885F0
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

		// Token: 0x17001FEC RID: 8172
		// (get) Token: 0x06009663 RID: 38499 RVA: 0x0028A42C File Offset: 0x0028862C
		public int LifeMaxRatio
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

		// Token: 0x17001FED RID: 8173
		// (get) Token: 0x06009664 RID: 38500 RVA: 0x0028A468 File Offset: 0x00288668
		public int AtkRatio
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

		// Token: 0x17001FEE RID: 8174
		// (get) Token: 0x06009665 RID: 38501 RVA: 0x0028A4A4 File Offset: 0x002886A4
		public int DefRatio
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

		// Token: 0x17001FEF RID: 8175
		// (get) Token: 0x06009666 RID: 38502 RVA: 0x0028A4E4 File Offset: 0x002886E4
		public int ExpRatio
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 10000;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x04004ECF RID: 20175
		private Table __p;
	}
}
