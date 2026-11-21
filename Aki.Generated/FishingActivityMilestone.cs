using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D5B RID: 3419
	public struct FishingActivityMilestone : IFlatbufferObject
	{
		// Token: 0x17001186 RID: 4486
		// (get) Token: 0x060074D5 RID: 29909 RVA: 0x0024EDA1 File Offset: 0x0024CFA1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060074D6 RID: 29910 RVA: 0x0024EDAE File Offset: 0x0024CFAE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060074D7 RID: 29911 RVA: 0x0024EDB8 File Offset: 0x0024CFB8
		public static FishingActivityMilestone GetRootAsFishingActivityMilestone(ByteBuffer _bb)
		{
			return FishingActivityMilestone.GetRootAsFishingActivityMilestone(_bb, default(FishingActivityMilestone));
		}

		// Token: 0x060074D8 RID: 29912 RVA: 0x0024EDD4 File Offset: 0x0024CFD4
		public static FishingActivityMilestone GetRootAsFishingActivityMilestone(ByteBuffer _bb, FishingActivityMilestone obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060074D9 RID: 29913 RVA: 0x0024EDF1 File Offset: 0x0024CFF1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060074DA RID: 29914 RVA: 0x0024EE00 File Offset: 0x0024D000
		public FishingActivityMilestone __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001187 RID: 4487
		// (get) Token: 0x060074DB RID: 29915 RVA: 0x0024EE10 File Offset: 0x0024D010
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

		// Token: 0x17001188 RID: 4488
		// (get) Token: 0x060074DC RID: 29916 RVA: 0x0024EE4C File Offset: 0x0024D04C
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

		// Token: 0x17001189 RID: 4489
		// (get) Token: 0x060074DD RID: 29917 RVA: 0x0024EE88 File Offset: 0x0024D088
		public int ItemNum
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

		// Token: 0x1700118A RID: 4490
		// (get) Token: 0x060074DE RID: 29918 RVA: 0x0024EEC4 File Offset: 0x0024D0C4
		public int DropId
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

		// Token: 0x040052A6 RID: 21158
		private Table __p;
	}
}
