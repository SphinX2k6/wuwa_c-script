using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200105D RID: 4189
	public struct RoleSkinBirthday : IFlatbufferObject
	{
		// Token: 0x1700335C RID: 13148
		// (get) Token: 0x0600CB1C RID: 51996 RVA: 0x00300318 File Offset: 0x002FE518
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600CB1D RID: 51997 RVA: 0x00300325 File Offset: 0x002FE525
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600CB1E RID: 51998 RVA: 0x0030032C File Offset: 0x002FE52C
		public static RoleSkinBirthday GetRootAsRoleSkinBirthday(ByteBuffer _bb)
		{
			return RoleSkinBirthday.GetRootAsRoleSkinBirthday(_bb, default(RoleSkinBirthday));
		}

		// Token: 0x0600CB1F RID: 51999 RVA: 0x00300348 File Offset: 0x002FE548
		public static RoleSkinBirthday GetRootAsRoleSkinBirthday(ByteBuffer _bb, RoleSkinBirthday obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600CB20 RID: 52000 RVA: 0x00300365 File Offset: 0x002FE565
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600CB21 RID: 52001 RVA: 0x00300374 File Offset: 0x002FE574
		public RoleSkinBirthday __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700335D RID: 13149
		// (get) Token: 0x0600CB22 RID: 52002 RVA: 0x00300384 File Offset: 0x002FE584
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

		// Token: 0x04005161 RID: 20833
		private Table __p;
	}
}
