using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C77 RID: 3191
	public struct FishingActivityMilestone : IFlatbufferObject
	{
		// Token: 0x17001129 RID: 4393
		// (get) Token: 0x06006ECA RID: 28362 RVA: 0x0022FBD5 File Offset: 0x0022DDD5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06006ECB RID: 28363 RVA: 0x0022FBE2 File Offset: 0x0022DDE2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06006ECC RID: 28364 RVA: 0x0022FBEC File Offset: 0x0022DDEC
		public static FishingActivityMilestone GetRootAsFishingActivityMilestone(ByteBuffer _bb)
		{
			return FishingActivityMilestone.GetRootAsFishingActivityMilestone(_bb, default(FishingActivityMilestone));
		}

		// Token: 0x06006ECD RID: 28365 RVA: 0x0022FC08 File Offset: 0x0022DE08
		public static FishingActivityMilestone GetRootAsFishingActivityMilestone(ByteBuffer _bb, FishingActivityMilestone obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06006ECE RID: 28366 RVA: 0x0022FC25 File Offset: 0x0022DE25
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06006ECF RID: 28367 RVA: 0x0022FC34 File Offset: 0x0022DE34
		public FishingActivityMilestone __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700112A RID: 4394
		// (get) Token: 0x06006ED0 RID: 28368 RVA: 0x0022FC44 File Offset: 0x0022DE44
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

		// Token: 0x1700112B RID: 4395
		// (get) Token: 0x06006ED1 RID: 28369 RVA: 0x0022FC80 File Offset: 0x0022DE80
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

		// Token: 0x1700112C RID: 4396
		// (get) Token: 0x06006ED2 RID: 28370 RVA: 0x0022FCBC File Offset: 0x0022DEBC
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

		// Token: 0x1700112D RID: 4397
		// (get) Token: 0x06006ED3 RID: 28371 RVA: 0x0022FCF8 File Offset: 0x0022DEF8
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

		// Token: 0x04004CC2 RID: 19650
		private Table __p;
	}
}
