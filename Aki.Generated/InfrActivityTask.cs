using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E44 RID: 3652
	public struct InfrActivityTask : IFlatbufferObject
	{
		// Token: 0x1700192F RID: 6447
		// (get) Token: 0x06008912 RID: 35090 RVA: 0x0027C556 File Offset: 0x0027A756
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06008913 RID: 35091 RVA: 0x0027C563 File Offset: 0x0027A763
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06008914 RID: 35092 RVA: 0x0027C56C File Offset: 0x0027A76C
		public static InfrActivityTask GetRootAsInfrActivityTask(ByteBuffer _bb)
		{
			return InfrActivityTask.GetRootAsInfrActivityTask(_bb, default(InfrActivityTask));
		}

		// Token: 0x06008915 RID: 35093 RVA: 0x0027C588 File Offset: 0x0027A788
		public static InfrActivityTask GetRootAsInfrActivityTask(ByteBuffer _bb, InfrActivityTask obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06008916 RID: 35094 RVA: 0x0027C5A5 File Offset: 0x0027A7A5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06008917 RID: 35095 RVA: 0x0027C5B4 File Offset: 0x0027A7B4
		public InfrActivityTask __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001930 RID: 6448
		// (get) Token: 0x06008918 RID: 35096 RVA: 0x0027C5C4 File Offset: 0x0027A7C4
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

		// Token: 0x17001931 RID: 6449
		// (get) Token: 0x06008919 RID: 35097 RVA: 0x0027C600 File Offset: 0x0027A800
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

		// Token: 0x17001932 RID: 6450
		// (get) Token: 0x0600891A RID: 35098 RVA: 0x0027C63C File Offset: 0x0027A83C
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

		// Token: 0x17001933 RID: 6451
		// (get) Token: 0x0600891B RID: 35099 RVA: 0x0027C678 File Offset: 0x0027A878
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

		// Token: 0x0600891C RID: 35100 RVA: 0x0027C6B0 File Offset: 0x0027A8B0
		public Span<byte> GetTaskDesBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600891D RID: 35101 RVA: 0x0027C6C0 File Offset: 0x0027A8C0
		public byte[] GetTaskDesArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17001934 RID: 6452
		// (get) Token: 0x0600891E RID: 35102 RVA: 0x0027C6D8 File Offset: 0x0027A8D8
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

		// Token: 0x040053C3 RID: 21443
		private Table __p;
	}
}
