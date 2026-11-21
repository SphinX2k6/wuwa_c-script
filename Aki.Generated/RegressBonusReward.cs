using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001092 RID: 4242
	public struct RegressBonusReward : IFlatbufferObject
	{
		// Token: 0x17002E04 RID: 11780
		// (get) Token: 0x0600C107 RID: 49415 RVA: 0x002F7DA1 File Offset: 0x002F5FA1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600C108 RID: 49416 RVA: 0x002F7DAE File Offset: 0x002F5FAE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600C109 RID: 49417 RVA: 0x002F7DB8 File Offset: 0x002F5FB8
		public static RegressBonusReward GetRootAsRegressBonusReward(ByteBuffer _bb)
		{
			return RegressBonusReward.GetRootAsRegressBonusReward(_bb, default(RegressBonusReward));
		}

		// Token: 0x0600C10A RID: 49418 RVA: 0x002F7DD4 File Offset: 0x002F5FD4
		public static RegressBonusReward GetRootAsRegressBonusReward(ByteBuffer _bb, RegressBonusReward obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600C10B RID: 49419 RVA: 0x002F7DF1 File Offset: 0x002F5FF1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600C10C RID: 49420 RVA: 0x002F7E00 File Offset: 0x002F6000
		public RegressBonusReward __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002E05 RID: 11781
		// (get) Token: 0x0600C10D RID: 49421 RVA: 0x002F7E10 File Offset: 0x002F6010
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

		// Token: 0x17002E06 RID: 11782
		// (get) Token: 0x0600C10E RID: 49422 RVA: 0x002F7E4C File Offset: 0x002F604C
		public int Grade
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17002E07 RID: 11783
		// (get) Token: 0x0600C10F RID: 49423 RVA: 0x002F7E88 File Offset: 0x002F6088
		public int NeedScore
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

		// Token: 0x17002E08 RID: 11784
		// (get) Token: 0x0600C110 RID: 49424 RVA: 0x002F7EC4 File Offset: 0x002F60C4
		public int Drop
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

		// Token: 0x17002E09 RID: 11785
		// (get) Token: 0x0600C111 RID: 49425 RVA: 0x002F7F04 File Offset: 0x002F6104
		public int PayDrop
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

		// Token: 0x17002E0A RID: 11786
		// (get) Token: 0x0600C112 RID: 49426 RVA: 0x002F7F44 File Offset: 0x002F6144
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

		// Token: 0x0400566B RID: 22123
		private Table __p;
	}
}
