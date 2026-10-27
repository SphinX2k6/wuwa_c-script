using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001109 RID: 4361
	public struct SurvivorsTask : IFlatbufferObject
	{
		// Token: 0x17003941 RID: 14657
		// (get) Token: 0x0600DBB2 RID: 56242 RVA: 0x00326B85 File Offset: 0x00324D85
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600DBB3 RID: 56243 RVA: 0x00326B92 File Offset: 0x00324D92
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600DBB4 RID: 56244 RVA: 0x00326B9C File Offset: 0x00324D9C
		public static SurvivorsTask GetRootAsSurvivorsTask(ByteBuffer _bb)
		{
			return SurvivorsTask.GetRootAsSurvivorsTask(_bb, default(SurvivorsTask));
		}

		// Token: 0x0600DBB5 RID: 56245 RVA: 0x00326BB8 File Offset: 0x00324DB8
		public static SurvivorsTask GetRootAsSurvivorsTask(ByteBuffer _bb, SurvivorsTask obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600DBB6 RID: 56246 RVA: 0x00326BD5 File Offset: 0x00324DD5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600DBB7 RID: 56247 RVA: 0x00326BE4 File Offset: 0x00324DE4
		public SurvivorsTask __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003942 RID: 14658
		// (get) Token: 0x0600DBB8 RID: 56248 RVA: 0x00326BF4 File Offset: 0x00324DF4
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

		// Token: 0x17003943 RID: 14659
		// (get) Token: 0x0600DBB9 RID: 56249 RVA: 0x00326C30 File Offset: 0x00324E30
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

		// Token: 0x17003944 RID: 14660
		// (get) Token: 0x0600DBBA RID: 56250 RVA: 0x00326C6C File Offset: 0x00324E6C
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

		// Token: 0x17003945 RID: 14661
		// (get) Token: 0x0600DBBB RID: 56251 RVA: 0x00326CA8 File Offset: 0x00324EA8
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

		// Token: 0x17003946 RID: 14662
		// (get) Token: 0x0600DBBC RID: 56252 RVA: 0x00326CE8 File Offset: 0x00324EE8
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

		// Token: 0x0600DBBD RID: 56253 RVA: 0x00326D20 File Offset: 0x00324F20
		public Span<byte> GetTaskNameBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600DBBE RID: 56254 RVA: 0x00326D30 File Offset: 0x00324F30
		public byte[] GetTaskNameArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17003947 RID: 14663
		// (get) Token: 0x0600DBBF RID: 56255 RVA: 0x00326D48 File Offset: 0x00324F48
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

		// Token: 0x17003948 RID: 14664
		// (get) Token: 0x0600DBC0 RID: 56256 RVA: 0x00326D88 File Offset: 0x00324F88
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

		// Token: 0x04005243 RID: 21059
		private Table __p;
	}
}
