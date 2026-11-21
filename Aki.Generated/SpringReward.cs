using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001226 RID: 4646
	public struct SpringReward : IFlatbufferObject
	{
		// Token: 0x17003BB5 RID: 15285
		// (get) Token: 0x0600E698 RID: 59032 RVA: 0x0034C7A1 File Offset: 0x0034A9A1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600E699 RID: 59033 RVA: 0x0034C7AE File Offset: 0x0034A9AE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600E69A RID: 59034 RVA: 0x0034C7B8 File Offset: 0x0034A9B8
		public static SpringReward GetRootAsSpringReward(ByteBuffer _bb)
		{
			return SpringReward.GetRootAsSpringReward(_bb, default(SpringReward));
		}

		// Token: 0x0600E69B RID: 59035 RVA: 0x0034C7D4 File Offset: 0x0034A9D4
		public static SpringReward GetRootAsSpringReward(ByteBuffer _bb, SpringReward obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600E69C RID: 59036 RVA: 0x0034C7F1 File Offset: 0x0034A9F1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600E69D RID: 59037 RVA: 0x0034C800 File Offset: 0x0034AA00
		public SpringReward __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003BB6 RID: 15286
		// (get) Token: 0x0600E69E RID: 59038 RVA: 0x0034C810 File Offset: 0x0034AA10
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

		// Token: 0x17003BB7 RID: 15287
		// (get) Token: 0x0600E69F RID: 59039 RVA: 0x0034C84C File Offset: 0x0034AA4C
		public int TaskThreshold
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

		// Token: 0x17003BB8 RID: 15288
		// (get) Token: 0x0600E6A0 RID: 59040 RVA: 0x0034C888 File Offset: 0x0034AA88
		public int ActivityId
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

		// Token: 0x17003BB9 RID: 15289
		// (get) Token: 0x0600E6A1 RID: 59041 RVA: 0x0034C8C4 File Offset: 0x0034AAC4
		public int TaskReward
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

		// Token: 0x17003BBA RID: 15290
		// (get) Token: 0x0600E6A2 RID: 59042 RVA: 0x0034C904 File Offset: 0x0034AB04
		public string TaskTitle
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600E6A3 RID: 59043 RVA: 0x0034C93C File Offset: 0x0034AB3C
		public Span<byte> GetTaskTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600E6A4 RID: 59044 RVA: 0x0034C94C File Offset: 0x0034AB4C
		public byte[] GetTaskTitleArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x04005867 RID: 22631
		private Table __p;
	}
}
