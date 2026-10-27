using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200104B RID: 4171
	public struct RoleExpItem : IFlatbufferObject
	{
		// Token: 0x17003262 RID: 12898
		// (get) Token: 0x0600C880 RID: 51328 RVA: 0x002FA3AC File Offset: 0x002F85AC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600C881 RID: 51329 RVA: 0x002FA3B9 File Offset: 0x002F85B9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600C882 RID: 51330 RVA: 0x002FA3C0 File Offset: 0x002F85C0
		public static RoleExpItem GetRootAsRoleExpItem(ByteBuffer _bb)
		{
			return RoleExpItem.GetRootAsRoleExpItem(_bb, default(RoleExpItem));
		}

		// Token: 0x0600C883 RID: 51331 RVA: 0x002FA3DC File Offset: 0x002F85DC
		public static RoleExpItem GetRootAsRoleExpItem(ByteBuffer _bb, RoleExpItem obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600C884 RID: 51332 RVA: 0x002FA3F9 File Offset: 0x002F85F9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600C885 RID: 51333 RVA: 0x002FA408 File Offset: 0x002F8608
		public RoleExpItem __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003263 RID: 12899
		// (get) Token: 0x0600C886 RID: 51334 RVA: 0x002FA418 File Offset: 0x002F8618
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

		// Token: 0x17003264 RID: 12900
		// (get) Token: 0x0600C887 RID: 51335 RVA: 0x002FA454 File Offset: 0x002F8654
		public int BasicExp
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

		// Token: 0x04005149 RID: 20809
		private Table __p;
	}
}
