using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E4D RID: 3661
	public struct InfrPhoneTask : IFlatbufferObject
	{
		// Token: 0x17001966 RID: 6502
		// (get) Token: 0x060089AC RID: 35244 RVA: 0x0027D935 File Offset: 0x0027BB35
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060089AD RID: 35245 RVA: 0x0027D942 File Offset: 0x0027BB42
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060089AE RID: 35246 RVA: 0x0027D94C File Offset: 0x0027BB4C
		public static InfrPhoneTask GetRootAsInfrPhoneTask(ByteBuffer _bb)
		{
			return InfrPhoneTask.GetRootAsInfrPhoneTask(_bb, default(InfrPhoneTask));
		}

		// Token: 0x060089AF RID: 35247 RVA: 0x0027D968 File Offset: 0x0027BB68
		public static InfrPhoneTask GetRootAsInfrPhoneTask(ByteBuffer _bb, InfrPhoneTask obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060089B0 RID: 35248 RVA: 0x0027D985 File Offset: 0x0027BB85
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060089B1 RID: 35249 RVA: 0x0027D994 File Offset: 0x0027BB94
		public InfrPhoneTask __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001967 RID: 6503
		// (get) Token: 0x060089B2 RID: 35250 RVA: 0x0027D9A4 File Offset: 0x0027BBA4
		public int TaskId
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

		// Token: 0x17001968 RID: 6504
		// (get) Token: 0x060089B3 RID: 35251 RVA: 0x0027D9E0 File Offset: 0x0027BBE0
		public int Target
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

		// Token: 0x17001969 RID: 6505
		// (get) Token: 0x060089B4 RID: 35252 RVA: 0x0027DA1C File Offset: 0x0027BC1C
		public int TaskReward
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

		// Token: 0x040053CD RID: 21453
		private Table __p;
	}
}
