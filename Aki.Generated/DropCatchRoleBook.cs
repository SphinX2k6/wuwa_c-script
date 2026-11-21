using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000CF2 RID: 3314
	public struct DropCatchRoleBook : IFlatbufferObject
	{
		// Token: 0x17000E34 RID: 3636
		// (get) Token: 0x06006BC9 RID: 27593 RVA: 0x0023B58C File Offset: 0x0023978C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06006BCA RID: 27594 RVA: 0x0023B599 File Offset: 0x00239799
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06006BCB RID: 27595 RVA: 0x0023B5A0 File Offset: 0x002397A0
		public static DropCatchRoleBook GetRootAsDropCatchRoleBook(ByteBuffer _bb)
		{
			return DropCatchRoleBook.GetRootAsDropCatchRoleBook(_bb, default(DropCatchRoleBook));
		}

		// Token: 0x06006BCC RID: 27596 RVA: 0x0023B5BC File Offset: 0x002397BC
		public static DropCatchRoleBook GetRootAsDropCatchRoleBook(ByteBuffer _bb, DropCatchRoleBook obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06006BCD RID: 27597 RVA: 0x0023B5D9 File Offset: 0x002397D9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06006BCE RID: 27598 RVA: 0x0023B5E8 File Offset: 0x002397E8
		public DropCatchRoleBook __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000E35 RID: 3637
		// (get) Token: 0x06006BCF RID: 27599 RVA: 0x0023B5F8 File Offset: 0x002397F8
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

		// Token: 0x17000E36 RID: 3638
		// (get) Token: 0x06006BD0 RID: 27600 RVA: 0x0023B634 File Offset: 0x00239834
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

		// Token: 0x0400522F RID: 21039
		private Table __p;
	}
}
