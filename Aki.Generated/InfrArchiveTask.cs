using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E47 RID: 3655
	public struct InfrArchiveTask : IFlatbufferObject
	{
		// Token: 0x1700193E RID: 6462
		// (get) Token: 0x06008934 RID: 35124 RVA: 0x0027C9BD File Offset: 0x0027ABBD
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06008935 RID: 35125 RVA: 0x0027C9CA File Offset: 0x0027ABCA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06008936 RID: 35126 RVA: 0x0027C9D4 File Offset: 0x0027ABD4
		public static InfrArchiveTask GetRootAsInfrArchiveTask(ByteBuffer _bb)
		{
			return InfrArchiveTask.GetRootAsInfrArchiveTask(_bb, default(InfrArchiveTask));
		}

		// Token: 0x06008937 RID: 35127 RVA: 0x0027C9F0 File Offset: 0x0027ABF0
		public static InfrArchiveTask GetRootAsInfrArchiveTask(ByteBuffer _bb, InfrArchiveTask obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06008938 RID: 35128 RVA: 0x0027CA0D File Offset: 0x0027AC0D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06008939 RID: 35129 RVA: 0x0027CA1C File Offset: 0x0027AC1C
		public InfrArchiveTask __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700193F RID: 6463
		// (get) Token: 0x0600893A RID: 35130 RVA: 0x0027CA2C File Offset: 0x0027AC2C
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

		// Token: 0x17001940 RID: 6464
		// (get) Token: 0x0600893B RID: 35131 RVA: 0x0027CA68 File Offset: 0x0027AC68
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

		// Token: 0x17001941 RID: 6465
		// (get) Token: 0x0600893C RID: 35132 RVA: 0x0027CAA4 File Offset: 0x0027ACA4
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

		// Token: 0x040053C6 RID: 21446
		private Table __p;
	}
}
