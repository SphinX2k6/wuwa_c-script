using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D5F RID: 3423
	public struct InfrActivityTask : IFlatbufferObject
	{
		// Token: 0x170018CC RID: 6348
		// (get) Token: 0x060082F8 RID: 33528 RVA: 0x0025DEA5 File Offset: 0x0025C0A5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060082F9 RID: 33529 RVA: 0x0025DEB2 File Offset: 0x0025C0B2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060082FA RID: 33530 RVA: 0x0025DEBC File Offset: 0x0025C0BC
		public static InfrActivityTask GetRootAsInfrActivityTask(ByteBuffer _bb)
		{
			return InfrActivityTask.GetRootAsInfrActivityTask(_bb, default(InfrActivityTask));
		}

		// Token: 0x060082FB RID: 33531 RVA: 0x0025DED8 File Offset: 0x0025C0D8
		public static InfrActivityTask GetRootAsInfrActivityTask(ByteBuffer _bb, InfrActivityTask obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060082FC RID: 33532 RVA: 0x0025DEF5 File Offset: 0x0025C0F5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060082FD RID: 33533 RVA: 0x0025DF04 File Offset: 0x0025C104
		public InfrActivityTask __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170018CD RID: 6349
		// (get) Token: 0x060082FE RID: 33534 RVA: 0x0025DF14 File Offset: 0x0025C114
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

		// Token: 0x170018CE RID: 6350
		// (get) Token: 0x060082FF RID: 33535 RVA: 0x0025DF50 File Offset: 0x0025C150
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

		// Token: 0x170018CF RID: 6351
		// (get) Token: 0x06008300 RID: 33536 RVA: 0x0025DF8C File Offset: 0x0025C18C
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

		// Token: 0x170018D0 RID: 6352
		// (get) Token: 0x06008301 RID: 33537 RVA: 0x0025DFC8 File Offset: 0x0025C1C8
		public string TaskDes
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06008302 RID: 33538 RVA: 0x0025E000 File Offset: 0x0025C200
		public Span<byte> GetTaskDesBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06008303 RID: 33539 RVA: 0x0025E010 File Offset: 0x0025C210
		public byte[] GetTaskDesArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x170018D1 RID: 6353
		// (get) Token: 0x06008304 RID: 33540 RVA: 0x0025E028 File Offset: 0x0025C228
		public int JumpId
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x04004DDE RID: 19934
		private Table __p;
	}
}
