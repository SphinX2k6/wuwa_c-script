using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C79 RID: 3193
	public struct FishingBomb : IFlatbufferObject
	{
		// Token: 0x17001135 RID: 4405
		// (get) Token: 0x06006EE0 RID: 28384 RVA: 0x0022FF15 File Offset: 0x0022E115
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06006EE1 RID: 28385 RVA: 0x0022FF22 File Offset: 0x0022E122
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06006EE2 RID: 28386 RVA: 0x0022FF2C File Offset: 0x0022E12C
		public static FishingBomb GetRootAsFishingBomb(ByteBuffer _bb)
		{
			return FishingBomb.GetRootAsFishingBomb(_bb, default(FishingBomb));
		}

		// Token: 0x06006EE3 RID: 28387 RVA: 0x0022FF48 File Offset: 0x0022E148
		public static FishingBomb GetRootAsFishingBomb(ByteBuffer _bb, FishingBomb obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06006EE4 RID: 28388 RVA: 0x0022FF65 File Offset: 0x0022E165
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06006EE5 RID: 28389 RVA: 0x0022FF74 File Offset: 0x0022E174
		public FishingBomb __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001136 RID: 4406
		// (get) Token: 0x06006EE6 RID: 28390 RVA: 0x0022FF84 File Offset: 0x0022E184
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

		// Token: 0x17001137 RID: 4407
		// (get) Token: 0x06006EE7 RID: 28391 RVA: 0x0022FFC0 File Offset: 0x0022E1C0
		public int ItemId
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

		// Token: 0x17001138 RID: 4408
		// (get) Token: 0x06006EE8 RID: 28392 RVA: 0x0022FFFC File Offset: 0x0022E1FC
		public int ExploreToolId
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

		// Token: 0x04004CC4 RID: 19652
		private Table __p;
	}
}
