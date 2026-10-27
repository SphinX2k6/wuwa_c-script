using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C10 RID: 3088
	public struct DropCatchRoleBook : IFlatbufferObject
	{
		// Token: 0x17000DE8 RID: 3560
		// (get) Token: 0x060065EA RID: 26090 RVA: 0x0021C2B5 File Offset: 0x0021A4B5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060065EB RID: 26091 RVA: 0x0021C2C2 File Offset: 0x0021A4C2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060065EC RID: 26092 RVA: 0x0021C2CC File Offset: 0x0021A4CC
		public static DropCatchRoleBook GetRootAsDropCatchRoleBook(ByteBuffer _bb)
		{
			return DropCatchRoleBook.GetRootAsDropCatchRoleBook(_bb, default(DropCatchRoleBook));
		}

		// Token: 0x060065ED RID: 26093 RVA: 0x0021C2E8 File Offset: 0x0021A4E8
		public static DropCatchRoleBook GetRootAsDropCatchRoleBook(ByteBuffer _bb, DropCatchRoleBook obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060065EE RID: 26094 RVA: 0x0021C305 File Offset: 0x0021A505
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060065EF RID: 26095 RVA: 0x0021C314 File Offset: 0x0021A514
		public DropCatchRoleBook __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000DE9 RID: 3561
		// (get) Token: 0x060065F0 RID: 26096 RVA: 0x0021C324 File Offset: 0x0021A524
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

		// Token: 0x17000DEA RID: 3562
		// (get) Token: 0x060065F1 RID: 26097 RVA: 0x0021C360 File Offset: 0x0021A560
		public int RoleId
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

		// Token: 0x04004C4D RID: 19533
		private Table __p;
	}
}
