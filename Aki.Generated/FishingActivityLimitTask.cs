using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C76 RID: 3190
	public struct FishingActivityLimitTask : IFlatbufferObject
	{
		// Token: 0x17001121 RID: 4385
		// (get) Token: 0x06006EBB RID: 28347 RVA: 0x0022F991 File Offset: 0x0022DB91
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06006EBC RID: 28348 RVA: 0x0022F99E File Offset: 0x0022DB9E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06006EBD RID: 28349 RVA: 0x0022F9A8 File Offset: 0x0022DBA8
		public static FishingActivityLimitTask GetRootAsFishingActivityLimitTask(ByteBuffer _bb)
		{
			return FishingActivityLimitTask.GetRootAsFishingActivityLimitTask(_bb, default(FishingActivityLimitTask));
		}

		// Token: 0x06006EBE RID: 28350 RVA: 0x0022F9C4 File Offset: 0x0022DBC4
		public static FishingActivityLimitTask GetRootAsFishingActivityLimitTask(ByteBuffer _bb, FishingActivityLimitTask obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06006EBF RID: 28351 RVA: 0x0022F9E1 File Offset: 0x0022DBE1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06006EC0 RID: 28352 RVA: 0x0022F9F0 File Offset: 0x0022DBF0
		public FishingActivityLimitTask __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001122 RID: 4386
		// (get) Token: 0x06006EC1 RID: 28353 RVA: 0x0022FA00 File Offset: 0x0022DC00
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

		// Token: 0x17001123 RID: 4387
		// (get) Token: 0x06006EC2 RID: 28354 RVA: 0x0022FA3C File Offset: 0x0022DC3C
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

		// Token: 0x17001124 RID: 4388
		// (get) Token: 0x06006EC3 RID: 28355 RVA: 0x0022FA78 File Offset: 0x0022DC78
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

		// Token: 0x06006EC4 RID: 28356 RVA: 0x0022FAAF File Offset: 0x0022DCAF
		public Span<byte> GetTaskNameBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06006EC5 RID: 28357 RVA: 0x0022FABE File Offset: 0x0022DCBE
		public byte[] GetTaskNameArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17001125 RID: 4389
		// (get) Token: 0x06006EC6 RID: 28358 RVA: 0x0022FAD8 File Offset: 0x0022DCD8
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

		// Token: 0x17001126 RID: 4390
		// (get) Token: 0x06006EC7 RID: 28359 RVA: 0x0022FB18 File Offset: 0x0022DD18
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

		// Token: 0x17001127 RID: 4391
		// (get) Token: 0x06006EC8 RID: 28360 RVA: 0x0022FB58 File Offset: 0x0022DD58
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

		// Token: 0x17001128 RID: 4392
		// (get) Token: 0x06006EC9 RID: 28361 RVA: 0x0022FB98 File Offset: 0x0022DD98
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

		// Token: 0x04004CC1 RID: 19649
		private Table __p;
	}
}
