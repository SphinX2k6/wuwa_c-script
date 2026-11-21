using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F35 RID: 3893
	public struct MotorFightTask : IFlatbufferObject
	{
		// Token: 0x170021A0 RID: 8608
		// (get) Token: 0x06009FA5 RID: 40869 RVA: 0x002AF327 File Offset: 0x002AD527
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06009FA6 RID: 40870 RVA: 0x002AF334 File Offset: 0x002AD534
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06009FA7 RID: 40871 RVA: 0x002AF33C File Offset: 0x002AD53C
		public static MotorFightTask GetRootAsMotorFightTask(ByteBuffer _bb)
		{
			return MotorFightTask.GetRootAsMotorFightTask(_bb, default(MotorFightTask));
		}

		// Token: 0x06009FA8 RID: 40872 RVA: 0x002AF358 File Offset: 0x002AD558
		public static MotorFightTask GetRootAsMotorFightTask(ByteBuffer _bb, MotorFightTask obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06009FA9 RID: 40873 RVA: 0x002AF375 File Offset: 0x002AD575
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06009FAA RID: 40874 RVA: 0x002AF384 File Offset: 0x002AD584
		public MotorFightTask __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170021A1 RID: 8609
		// (get) Token: 0x06009FAB RID: 40875 RVA: 0x002AF394 File Offset: 0x002AD594
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

		// Token: 0x170021A2 RID: 8610
		// (get) Token: 0x06009FAC RID: 40876 RVA: 0x002AF3D0 File Offset: 0x002AD5D0
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

		// Token: 0x170021A3 RID: 8611
		// (get) Token: 0x06009FAD RID: 40877 RVA: 0x002AF40C File Offset: 0x002AD60C
		public int SortId
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

		// Token: 0x170021A4 RID: 8612
		// (get) Token: 0x06009FAE RID: 40878 RVA: 0x002AF448 File Offset: 0x002AD648
		public int PageType
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

		// Token: 0x170021A5 RID: 8613
		// (get) Token: 0x06009FAF RID: 40879 RVA: 0x002AF488 File Offset: 0x002AD688
		public string TaskName
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

		// Token: 0x06009FB0 RID: 40880 RVA: 0x002AF4C0 File Offset: 0x002AD6C0
		public Span<byte> GetTaskNameBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06009FB1 RID: 40881 RVA: 0x002AF4D0 File Offset: 0x002AD6D0
		public byte[] GetTaskNameArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x170021A6 RID: 8614
		// (get) Token: 0x06009FB2 RID: 40882 RVA: 0x002AF4E8 File Offset: 0x002AD6E8
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

		// Token: 0x170021A7 RID: 8615
		// (get) Token: 0x06009FB3 RID: 40883 RVA: 0x002AF528 File Offset: 0x002AD728
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

		// Token: 0x040054DE RID: 21726
		private Table __p;
	}
}
