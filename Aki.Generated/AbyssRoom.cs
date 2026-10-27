using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000AB7 RID: 2743
	public struct AbyssRoom : IFlatbufferObject
	{
		// Token: 0x170000BB RID: 187
		// (get) Token: 0x060041EF RID: 16879 RVA: 0x001C8C2C File Offset: 0x001C6E2C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060041F0 RID: 16880 RVA: 0x001C8C39 File Offset: 0x001C6E39
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060041F1 RID: 16881 RVA: 0x001C8C40 File Offset: 0x001C6E40
		public static AbyssRoom GetRootAsAbyssRoom(ByteBuffer _bb)
		{
			return AbyssRoom.GetRootAsAbyssRoom(_bb, default(AbyssRoom));
		}

		// Token: 0x060041F2 RID: 16882 RVA: 0x001C8C5C File Offset: 0x001C6E5C
		public static AbyssRoom GetRootAsAbyssRoom(ByteBuffer _bb, AbyssRoom obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060041F3 RID: 16883 RVA: 0x001C8C79 File Offset: 0x001C6E79
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060041F4 RID: 16884 RVA: 0x001C8C88 File Offset: 0x001C6E88
		public AbyssRoom __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170000BC RID: 188
		// (get) Token: 0x060041F5 RID: 16885 RVA: 0x001C8C98 File Offset: 0x001C6E98
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

		// Token: 0x170000BD RID: 189
		// (get) Token: 0x060041F6 RID: 16886 RVA: 0x001C8CD4 File Offset: 0x001C6ED4
		public int BehaviorTree
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

		// Token: 0x04004A8E RID: 19086
		private Table __p;
	}
}
