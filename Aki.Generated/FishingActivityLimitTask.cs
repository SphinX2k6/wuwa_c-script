using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D5A RID: 3418
	public struct FishingActivityLimitTask : IFlatbufferObject
	{
		// Token: 0x1700117E RID: 4478
		// (get) Token: 0x060074C6 RID: 29894 RVA: 0x0024EB5D File Offset: 0x0024CD5D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060074C7 RID: 29895 RVA: 0x0024EB6A File Offset: 0x0024CD6A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060074C8 RID: 29896 RVA: 0x0024EB74 File Offset: 0x0024CD74
		public static FishingActivityLimitTask GetRootAsFishingActivityLimitTask(ByteBuffer _bb)
		{
			return FishingActivityLimitTask.GetRootAsFishingActivityLimitTask(_bb, default(FishingActivityLimitTask));
		}

		// Token: 0x060074C9 RID: 29897 RVA: 0x0024EB90 File Offset: 0x0024CD90
		public static FishingActivityLimitTask GetRootAsFishingActivityLimitTask(ByteBuffer _bb, FishingActivityLimitTask obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060074CA RID: 29898 RVA: 0x0024EBAD File Offset: 0x0024CDAD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060074CB RID: 29899 RVA: 0x0024EBBC File Offset: 0x0024CDBC
		public FishingActivityLimitTask __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700117F RID: 4479
		// (get) Token: 0x060074CC RID: 29900 RVA: 0x0024EBCC File Offset: 0x0024CDCC
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

		// Token: 0x17001180 RID: 4480
		// (get) Token: 0x060074CD RID: 29901 RVA: 0x0024EC08 File Offset: 0x0024CE08
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

		// Token: 0x17001181 RID: 4481
		// (get) Token: 0x060074CE RID: 29902 RVA: 0x0024EC44 File Offset: 0x0024CE44
		public string TaskName
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060074CF RID: 29903 RVA: 0x0024EC7B File Offset: 0x0024CE7B
		public Span<byte> GetTaskNameBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x060074D0 RID: 29904 RVA: 0x0024EC8A File Offset: 0x0024CE8A
		public byte[] GetTaskNameArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17001182 RID: 4482
		// (get) Token: 0x060074D1 RID: 29905 RVA: 0x0024ECA4 File Offset: 0x0024CEA4
		public int SortId
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

		// Token: 0x17001183 RID: 4483
		// (get) Token: 0x060074D2 RID: 29906 RVA: 0x0024ECE4 File Offset: 0x0024CEE4
		public int GroupId
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

		// Token: 0x17001184 RID: 4484
		// (get) Token: 0x060074D3 RID: 29907 RVA: 0x0024ED24 File Offset: 0x0024CF24
		public int DropId
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001185 RID: 4485
		// (get) Token: 0x060074D4 RID: 29908 RVA: 0x0024ED64 File Offset: 0x0024CF64
		public int JumpId
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x040052A5 RID: 21157
		private Table __p;
	}
}
