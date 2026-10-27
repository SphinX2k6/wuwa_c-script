using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C13 RID: 3091
	public struct DropPlan : IFlatbufferObject
	{
		// Token: 0x17000DF8 RID: 3576
		// (get) Token: 0x06006611 RID: 26129 RVA: 0x0021C8A8 File Offset: 0x0021AAA8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06006612 RID: 26130 RVA: 0x0021C8B5 File Offset: 0x0021AAB5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06006613 RID: 26131 RVA: 0x0021C8BC File Offset: 0x0021AABC
		public static DropPlan GetRootAsDropPlan(ByteBuffer _bb)
		{
			return DropPlan.GetRootAsDropPlan(_bb, default(DropPlan));
		}

		// Token: 0x06006614 RID: 26132 RVA: 0x0021C8D8 File Offset: 0x0021AAD8
		public static DropPlan GetRootAsDropPlan(ByteBuffer _bb, DropPlan obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06006615 RID: 26133 RVA: 0x0021C8F5 File Offset: 0x0021AAF5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06006616 RID: 26134 RVA: 0x0021C904 File Offset: 0x0021AB04
		public DropPlan __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000DF9 RID: 3577
		// (get) Token: 0x06006617 RID: 26135 RVA: 0x0021C914 File Offset: 0x0021AB14
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

		// Token: 0x04004C51 RID: 19537
		private Table __p;
	}
}
