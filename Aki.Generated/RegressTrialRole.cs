using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000FB5 RID: 4021
	public struct RegressTrialRole : IFlatbufferObject
	{
		// Token: 0x17002DD4 RID: 11732
		// (get) Token: 0x0600BB51 RID: 47953 RVA: 0x002DCB6D File Offset: 0x002DAD6D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600BB52 RID: 47954 RVA: 0x002DCB7A File Offset: 0x002DAD7A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600BB53 RID: 47955 RVA: 0x002DCB84 File Offset: 0x002DAD84
		public static RegressTrialRole GetRootAsRegressTrialRole(ByteBuffer _bb)
		{
			return RegressTrialRole.GetRootAsRegressTrialRole(_bb, default(RegressTrialRole));
		}

		// Token: 0x0600BB54 RID: 47956 RVA: 0x002DCBA0 File Offset: 0x002DADA0
		public static RegressTrialRole GetRootAsRegressTrialRole(ByteBuffer _bb, RegressTrialRole obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600BB55 RID: 47957 RVA: 0x002DCBBD File Offset: 0x002DADBD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600BB56 RID: 47958 RVA: 0x002DCBCC File Offset: 0x002DADCC
		public RegressTrialRole __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002DD5 RID: 11733
		// (get) Token: 0x0600BB57 RID: 47959 RVA: 0x002DCBDC File Offset: 0x002DADDC
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

		// Token: 0x17002DD6 RID: 11734
		// (get) Token: 0x0600BB58 RID: 47960 RVA: 0x002DCC18 File Offset: 0x002DAE18
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

		// Token: 0x17002DD7 RID: 11735
		// (get) Token: 0x0600BB59 RID: 47961 RVA: 0x002DCC54 File Offset: 0x002DAE54
		public int ConditionGroup
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

		// Token: 0x17002DD8 RID: 11736
		// (get) Token: 0x0600BB5A RID: 47962 RVA: 0x002DCC90 File Offset: 0x002DAE90
		public int TrialRoleGroupId
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

		// Token: 0x0400508E RID: 20622
		private Table __p;
	}
}
