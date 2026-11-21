using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000BA4 RID: 2980
	public struct ActivityRecommendCurrent : IFlatbufferObject
	{
		// Token: 0x17000185 RID: 389
		// (get) Token: 0x060048FC RID: 18684 RVA: 0x001ECA61 File Offset: 0x001EAC61
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060048FD RID: 18685 RVA: 0x001ECA6E File Offset: 0x001EAC6E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060048FE RID: 18686 RVA: 0x001ECA78 File Offset: 0x001EAC78
		public static ActivityRecommendCurrent GetRootAsActivityRecommendCurrent(ByteBuffer _bb)
		{
			return ActivityRecommendCurrent.GetRootAsActivityRecommendCurrent(_bb, default(ActivityRecommendCurrent));
		}

		// Token: 0x060048FF RID: 18687 RVA: 0x001ECA94 File Offset: 0x001EAC94
		public static ActivityRecommendCurrent GetRootAsActivityRecommendCurrent(ByteBuffer _bb, ActivityRecommendCurrent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06004900 RID: 18688 RVA: 0x001ECAB1 File Offset: 0x001EACB1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06004901 RID: 18689 RVA: 0x001ECAC0 File Offset: 0x001EACC0
		public ActivityRecommendCurrent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000186 RID: 390
		// (get) Token: 0x06004902 RID: 18690 RVA: 0x001ECAD0 File Offset: 0x001EACD0
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

		// Token: 0x17000187 RID: 391
		// (get) Token: 0x06004903 RID: 18691 RVA: 0x001ECB0C File Offset: 0x001EAD0C
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

		// Token: 0x04005081 RID: 20609
		private Table __p;
	}
}
