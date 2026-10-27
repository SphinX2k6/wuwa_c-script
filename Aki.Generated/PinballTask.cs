using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F3A RID: 3898
	public struct PinballTask : IFlatbufferObject
	{
		// Token: 0x170029E1 RID: 10721
		// (get) Token: 0x0600B06E RID: 45166 RVA: 0x002C51A9 File Offset: 0x002C33A9
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600B06F RID: 45167 RVA: 0x002C51B6 File Offset: 0x002C33B6
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600B070 RID: 45168 RVA: 0x002C51C0 File Offset: 0x002C33C0
		public static PinballTask GetRootAsPinballTask(ByteBuffer _bb)
		{
			return PinballTask.GetRootAsPinballTask(_bb, default(PinballTask));
		}

		// Token: 0x0600B071 RID: 45169 RVA: 0x002C51DC File Offset: 0x002C33DC
		public static PinballTask GetRootAsPinballTask(ByteBuffer _bb, PinballTask obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600B072 RID: 45170 RVA: 0x002C51F9 File Offset: 0x002C33F9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600B073 RID: 45171 RVA: 0x002C5208 File Offset: 0x002C3408
		public PinballTask __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170029E2 RID: 10722
		// (get) Token: 0x0600B074 RID: 45172 RVA: 0x002C5218 File Offset: 0x002C3418
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

		// Token: 0x170029E3 RID: 10723
		// (get) Token: 0x0600B075 RID: 45173 RVA: 0x002C5254 File Offset: 0x002C3454
		public int TaskType
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

		// Token: 0x170029E4 RID: 10724
		// (get) Token: 0x0600B076 RID: 45174 RVA: 0x002C5290 File Offset: 0x002C3490
		public int TaskTab
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

		// Token: 0x170029E5 RID: 10725
		// (get) Token: 0x0600B077 RID: 45175 RVA: 0x002C52CC File Offset: 0x002C34CC
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

		// Token: 0x170029E6 RID: 10726
		// (get) Token: 0x0600B078 RID: 45176 RVA: 0x002C530C File Offset: 0x002C350C
		public int ActivityId
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

		// Token: 0x170029E7 RID: 10727
		// (get) Token: 0x0600B079 RID: 45177 RVA: 0x002C534C File Offset: 0x002C354C
		public string TaskName
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600B07A RID: 45178 RVA: 0x002C5384 File Offset: 0x002C3584
		public Span<byte> GetTaskNameBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600B07B RID: 45179 RVA: 0x002C5394 File Offset: 0x002C3594
		public byte[] GetTaskNameArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x170029E8 RID: 10728
		// (get) Token: 0x0600B07C RID: 45180 RVA: 0x002C53AC File Offset: 0x002C35AC
		public int DropId
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

		// Token: 0x04005004 RID: 20484
		private Table __p;
	}
}
