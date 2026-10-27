using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B99 RID: 2969
	public struct ConsumptiveActivity : IFlatbufferObject
	{
		// Token: 0x1700093C RID: 2364
		// (get) Token: 0x060058FD RID: 22781 RVA: 0x001FEC55 File Offset: 0x001FCE55
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060058FE RID: 22782 RVA: 0x001FEC62 File Offset: 0x001FCE62
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060058FF RID: 22783 RVA: 0x001FEC6C File Offset: 0x001FCE6C
		public static ConsumptiveActivity GetRootAsConsumptiveActivity(ByteBuffer _bb)
		{
			return ConsumptiveActivity.GetRootAsConsumptiveActivity(_bb, default(ConsumptiveActivity));
		}

		// Token: 0x06005900 RID: 22784 RVA: 0x001FEC88 File Offset: 0x001FCE88
		public static ConsumptiveActivity GetRootAsConsumptiveActivity(ByteBuffer _bb, ConsumptiveActivity obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06005901 RID: 22785 RVA: 0x001FECA5 File Offset: 0x001FCEA5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06005902 RID: 22786 RVA: 0x001FECB4 File Offset: 0x001FCEB4
		public ConsumptiveActivity __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700093D RID: 2365
		// (get) Token: 0x06005903 RID: 22787 RVA: 0x001FECC4 File Offset: 0x001FCEC4
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

		// Token: 0x1700093E RID: 2366
		// (get) Token: 0x06005904 RID: 22788 RVA: 0x001FED00 File Offset: 0x001FCF00
		public int ScoreItemId
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

		// Token: 0x1700093F RID: 2367
		// (get) Token: 0x06005905 RID: 22789 RVA: 0x001FED3C File Offset: 0x001FCF3C
		public int ShopId
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

		// Token: 0x04004BBA RID: 19386
		private Table __p;
	}
}
