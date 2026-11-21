using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000CF5 RID: 3317
	public struct DropPlan : IFlatbufferObject
	{
		// Token: 0x17000E44 RID: 3652
		// (get) Token: 0x06006BF0 RID: 27632 RVA: 0x0023BB7C File Offset: 0x00239D7C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06006BF1 RID: 27633 RVA: 0x0023BB89 File Offset: 0x00239D89
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06006BF2 RID: 27634 RVA: 0x0023BB90 File Offset: 0x00239D90
		public static DropPlan GetRootAsDropPlan(ByteBuffer _bb)
		{
			return DropPlan.GetRootAsDropPlan(_bb, default(DropPlan));
		}

		// Token: 0x06006BF3 RID: 27635 RVA: 0x0023BBAC File Offset: 0x00239DAC
		public static DropPlan GetRootAsDropPlan(ByteBuffer _bb, DropPlan obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06006BF4 RID: 27636 RVA: 0x0023BBC9 File Offset: 0x00239DC9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06006BF5 RID: 27637 RVA: 0x0023BBD8 File Offset: 0x00239DD8
		public DropPlan __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000E45 RID: 3653
		// (get) Token: 0x06006BF6 RID: 27638 RVA: 0x0023BBE8 File Offset: 0x00239DE8
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

		// Token: 0x04005233 RID: 21043
		private Table __p;
	}
}
