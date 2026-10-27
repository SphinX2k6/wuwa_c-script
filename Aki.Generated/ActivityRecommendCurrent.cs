using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000ACA RID: 2762
	public struct ActivityRecommendCurrent : IFlatbufferObject
	{
		// Token: 0x1700016E RID: 366
		// (get) Token: 0x060043B5 RID: 17333 RVA: 0x001CCE81 File Offset: 0x001CB081
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060043B6 RID: 17334 RVA: 0x001CCE8E File Offset: 0x001CB08E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060043B7 RID: 17335 RVA: 0x001CCE98 File Offset: 0x001CB098
		public static ActivityRecommendCurrent GetRootAsActivityRecommendCurrent(ByteBuffer _bb)
		{
			return ActivityRecommendCurrent.GetRootAsActivityRecommendCurrent(_bb, default(ActivityRecommendCurrent));
		}

		// Token: 0x060043B8 RID: 17336 RVA: 0x001CCEB4 File Offset: 0x001CB0B4
		public static ActivityRecommendCurrent GetRootAsActivityRecommendCurrent(ByteBuffer _bb, ActivityRecommendCurrent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060043B9 RID: 17337 RVA: 0x001CCED1 File Offset: 0x001CB0D1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060043BA RID: 17338 RVA: 0x001CCEE0 File Offset: 0x001CB0E0
		public ActivityRecommendCurrent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700016F RID: 367
		// (get) Token: 0x060043BB RID: 17339 RVA: 0x001CCEF0 File Offset: 0x001CB0F0
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

		// Token: 0x17000170 RID: 368
		// (get) Token: 0x060043BC RID: 17340 RVA: 0x001CCF2C File Offset: 0x001CB12C
		public int ActivityGroup
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

		// Token: 0x04004AA7 RID: 19111
		private Table __p;
	}
}
