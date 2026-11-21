using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200109D RID: 4253
	public struct RegressTrialRole : IFlatbufferObject
	{
		// Token: 0x17002E4F RID: 11855
		// (get) Token: 0x0600C19B RID: 49563 RVA: 0x002F92FD File Offset: 0x002F74FD
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600C19C RID: 49564 RVA: 0x002F930A File Offset: 0x002F750A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600C19D RID: 49565 RVA: 0x002F9314 File Offset: 0x002F7514
		public static RegressTrialRole GetRootAsRegressTrialRole(ByteBuffer _bb)
		{
			return RegressTrialRole.GetRootAsRegressTrialRole(_bb, default(RegressTrialRole));
		}

		// Token: 0x0600C19E RID: 49566 RVA: 0x002F9330 File Offset: 0x002F7530
		public static RegressTrialRole GetRootAsRegressTrialRole(ByteBuffer _bb, RegressTrialRole obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600C19F RID: 49567 RVA: 0x002F934D File Offset: 0x002F754D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600C1A0 RID: 49568 RVA: 0x002F935C File Offset: 0x002F755C
		public RegressTrialRole __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002E50 RID: 11856
		// (get) Token: 0x0600C1A1 RID: 49569 RVA: 0x002F936C File Offset: 0x002F756C
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

		// Token: 0x17002E51 RID: 11857
		// (get) Token: 0x0600C1A2 RID: 49570 RVA: 0x002F93A8 File Offset: 0x002F75A8
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

		// Token: 0x17002E52 RID: 11858
		// (get) Token: 0x0600C1A3 RID: 49571 RVA: 0x002F93E4 File Offset: 0x002F75E4
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

		// Token: 0x17002E53 RID: 11859
		// (get) Token: 0x0600C1A4 RID: 49572 RVA: 0x002F9420 File Offset: 0x002F7620
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

		// Token: 0x04005676 RID: 22134
		private Table __p;
	}
}
