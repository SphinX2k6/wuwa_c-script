using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C7C RID: 3196
	public struct ConsumptiveTask : IFlatbufferObject
	{
		// Token: 0x17000986 RID: 2438
		// (get) Token: 0x06005EDF RID: 24287 RVA: 0x0021EB18 File Offset: 0x0021CD18
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06005EE0 RID: 24288 RVA: 0x0021EB25 File Offset: 0x0021CD25
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06005EE1 RID: 24289 RVA: 0x0021EB2C File Offset: 0x0021CD2C
		public static ConsumptiveTask GetRootAsConsumptiveTask(ByteBuffer _bb)
		{
			return ConsumptiveTask.GetRootAsConsumptiveTask(_bb, default(ConsumptiveTask));
		}

		// Token: 0x06005EE2 RID: 24290 RVA: 0x0021EB48 File Offset: 0x0021CD48
		public static ConsumptiveTask GetRootAsConsumptiveTask(ByteBuffer _bb, ConsumptiveTask obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06005EE3 RID: 24291 RVA: 0x0021EB65 File Offset: 0x0021CD65
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06005EE4 RID: 24292 RVA: 0x0021EB74 File Offset: 0x0021CD74
		public ConsumptiveTask __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000987 RID: 2439
		// (get) Token: 0x06005EE5 RID: 24293 RVA: 0x0021EB84 File Offset: 0x0021CD84
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

		// Token: 0x17000988 RID: 2440
		// (get) Token: 0x06005EE6 RID: 24294 RVA: 0x0021EBC0 File Offset: 0x0021CDC0
		public int MaxFinishCount
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

		// Token: 0x17000989 RID: 2441
		// (get) Token: 0x06005EE7 RID: 24295 RVA: 0x0021EBFC File Offset: 0x0021CDFC
		public int RewardScore
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

		// Token: 0x1700098A RID: 2442
		// (get) Token: 0x06005EE8 RID: 24296 RVA: 0x0021EC38 File Offset: 0x0021CE38
		public int TaskTab
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

		// Token: 0x1700098B RID: 2443
		// (get) Token: 0x06005EE9 RID: 24297 RVA: 0x0021EC78 File Offset: 0x0021CE78
		public string DesString
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

		// Token: 0x06005EEA RID: 24298 RVA: 0x0021ECB0 File Offset: 0x0021CEB0
		public Span<byte> GetDesStringBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06005EEB RID: 24299 RVA: 0x0021ECC0 File Offset: 0x0021CEC0
		public byte[] GetDesStringArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x1700098C RID: 2444
		// (get) Token: 0x06005EEC RID: 24300 RVA: 0x0021ECD8 File Offset: 0x0021CED8
		public int SkipId
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

		// Token: 0x0400519D RID: 20893
		private Table __p;
	}
}
