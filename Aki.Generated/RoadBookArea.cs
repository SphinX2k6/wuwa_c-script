using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000FD0 RID: 4048
	public struct RoadBookArea : IFlatbufferObject
	{
		// Token: 0x17002EB0 RID: 11952
		// (get) Token: 0x0600BDA8 RID: 48552 RVA: 0x002E1CE0 File Offset: 0x002DFEE0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600BDA9 RID: 48553 RVA: 0x002E1CED File Offset: 0x002DFEED
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600BDAA RID: 48554 RVA: 0x002E1CF4 File Offset: 0x002DFEF4
		public static RoadBookArea GetRootAsRoadBookArea(ByteBuffer _bb)
		{
			return RoadBookArea.GetRootAsRoadBookArea(_bb, default(RoadBookArea));
		}

		// Token: 0x0600BDAB RID: 48555 RVA: 0x002E1D10 File Offset: 0x002DFF10
		public static RoadBookArea GetRootAsRoadBookArea(ByteBuffer _bb, RoadBookArea obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600BDAC RID: 48556 RVA: 0x002E1D2D File Offset: 0x002DFF2D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600BDAD RID: 48557 RVA: 0x002E1D3C File Offset: 0x002DFF3C
		public RoadBookArea __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002EB1 RID: 11953
		// (get) Token: 0x0600BDAE RID: 48558 RVA: 0x002E1D4C File Offset: 0x002DFF4C
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

		// Token: 0x17002EB2 RID: 11954
		// (get) Token: 0x0600BDAF RID: 48559 RVA: 0x002E1D88 File Offset: 0x002DFF88
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

		// Token: 0x17002EB3 RID: 11955
		// (get) Token: 0x0600BDB0 RID: 48560 RVA: 0x002E1DC4 File Offset: 0x002DFFC4
		public int UnLockCondition
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

		// Token: 0x17002EB4 RID: 11956
		// (get) Token: 0x0600BDB1 RID: 48561 RVA: 0x002E1E00 File Offset: 0x002E0000
		public int UnlockAccessId
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

		// Token: 0x17002EB5 RID: 11957
		// (get) Token: 0x0600BDB2 RID: 48562 RVA: 0x002E1E40 File Offset: 0x002E0040
		public int Sort
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x040050AB RID: 20651
		private Table __p;
	}
}
