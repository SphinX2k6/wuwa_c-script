using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200109C RID: 4252
	public struct RegressSignReward : IFlatbufferObject
	{
		// Token: 0x17002E48 RID: 11848
		// (get) Token: 0x0600C18F RID: 49551 RVA: 0x002F9120 File Offset: 0x002F7320
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600C190 RID: 49552 RVA: 0x002F912D File Offset: 0x002F732D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600C191 RID: 49553 RVA: 0x002F9134 File Offset: 0x002F7334
		public static RegressSignReward GetRootAsRegressSignReward(ByteBuffer _bb)
		{
			return RegressSignReward.GetRootAsRegressSignReward(_bb, default(RegressSignReward));
		}

		// Token: 0x0600C192 RID: 49554 RVA: 0x002F9150 File Offset: 0x002F7350
		public static RegressSignReward GetRootAsRegressSignReward(ByteBuffer _bb, RegressSignReward obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600C193 RID: 49555 RVA: 0x002F916D File Offset: 0x002F736D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600C194 RID: 49556 RVA: 0x002F917C File Offset: 0x002F737C
		public RegressSignReward __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002E49 RID: 11849
		// (get) Token: 0x0600C195 RID: 49557 RVA: 0x002F918C File Offset: 0x002F738C
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

		// Token: 0x17002E4A RID: 11850
		// (get) Token: 0x0600C196 RID: 49558 RVA: 0x002F91C8 File Offset: 0x002F73C8
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

		// Token: 0x17002E4B RID: 11851
		// (get) Token: 0x0600C197 RID: 49559 RVA: 0x002F9204 File Offset: 0x002F7404
		public int Grade
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17002E4C RID: 11852
		// (get) Token: 0x0600C198 RID: 49560 RVA: 0x002F9240 File Offset: 0x002F7440
		public int SignDayNum
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

		// Token: 0x17002E4D RID: 11853
		// (get) Token: 0x0600C199 RID: 49561 RVA: 0x002F9280 File Offset: 0x002F7480
		public int SignReward
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

		// Token: 0x17002E4E RID: 11854
		// (get) Token: 0x0600C19A RID: 49562 RVA: 0x002F92C0 File Offset: 0x002F74C0
		public int Version
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x04005675 RID: 22133
		private Table __p;
	}
}
