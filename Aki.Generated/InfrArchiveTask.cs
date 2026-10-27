using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D62 RID: 3426
	public struct InfrArchiveTask : IFlatbufferObject
	{
		// Token: 0x170018DB RID: 6363
		// (get) Token: 0x0600831A RID: 33562 RVA: 0x0025E30D File Offset: 0x0025C50D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600831B RID: 33563 RVA: 0x0025E31A File Offset: 0x0025C51A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600831C RID: 33564 RVA: 0x0025E324 File Offset: 0x0025C524
		public static InfrArchiveTask GetRootAsInfrArchiveTask(ByteBuffer _bb)
		{
			return InfrArchiveTask.GetRootAsInfrArchiveTask(_bb, default(InfrArchiveTask));
		}

		// Token: 0x0600831D RID: 33565 RVA: 0x0025E340 File Offset: 0x0025C540
		public static InfrArchiveTask GetRootAsInfrArchiveTask(ByteBuffer _bb, InfrArchiveTask obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600831E RID: 33566 RVA: 0x0025E35D File Offset: 0x0025C55D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600831F RID: 33567 RVA: 0x0025E36C File Offset: 0x0025C56C
		public InfrArchiveTask __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170018DC RID: 6364
		// (get) Token: 0x06008320 RID: 33568 RVA: 0x0025E37C File Offset: 0x0025C57C
		public int TaskId
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

		// Token: 0x170018DD RID: 6365
		// (get) Token: 0x06008321 RID: 33569 RVA: 0x0025E3B8 File Offset: 0x0025C5B8
		public int Target
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

		// Token: 0x170018DE RID: 6366
		// (get) Token: 0x06008322 RID: 33570 RVA: 0x0025E3F4 File Offset: 0x0025C5F4
		public int TaskReward
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

		// Token: 0x04004DE1 RID: 19937
		private Table __p;
	}
}
