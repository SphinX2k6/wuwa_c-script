using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020010B1 RID: 4273
	public struct RiskHarvestActivityInfo : IFlatbufferObject
	{
		// Token: 0x17002EEE RID: 12014
		// (get) Token: 0x0600C35E RID: 50014 RVA: 0x002FCE25 File Offset: 0x002FB025
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600C35F RID: 50015 RVA: 0x002FCE32 File Offset: 0x002FB032
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600C360 RID: 50016 RVA: 0x002FCE3C File Offset: 0x002FB03C
		public static RiskHarvestActivityInfo GetRootAsRiskHarvestActivityInfo(ByteBuffer _bb)
		{
			return RiskHarvestActivityInfo.GetRootAsRiskHarvestActivityInfo(_bb, default(RiskHarvestActivityInfo));
		}

		// Token: 0x0600C361 RID: 50017 RVA: 0x002FCE58 File Offset: 0x002FB058
		public static RiskHarvestActivityInfo GetRootAsRiskHarvestActivityInfo(ByteBuffer _bb, RiskHarvestActivityInfo obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600C362 RID: 50018 RVA: 0x002FCE75 File Offset: 0x002FB075
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600C363 RID: 50019 RVA: 0x002FCE84 File Offset: 0x002FB084
		public RiskHarvestActivityInfo __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002EEF RID: 12015
		// (get) Token: 0x0600C364 RID: 50020 RVA: 0x002FCE94 File Offset: 0x002FB094
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

		// Token: 0x17002EF0 RID: 12016
		// (get) Token: 0x0600C365 RID: 50021 RVA: 0x002FCED0 File Offset: 0x002FB0D0
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

		// Token: 0x17002EF1 RID: 12017
		// (get) Token: 0x0600C366 RID: 50022 RVA: 0x002FCF0C File Offset: 0x002FB10C
		public int EntranceId
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

		// Token: 0x17002EF2 RID: 12018
		// (get) Token: 0x0600C367 RID: 50023 RVA: 0x002FCF48 File Offset: 0x002FB148
		public int QuestId
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

		// Token: 0x17002EF3 RID: 12019
		// (get) Token: 0x0600C368 RID: 50024 RVA: 0x002FCF88 File Offset: 0x002FB188
		public int MarkId
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

		// Token: 0x0400568C RID: 22156
		private Table __p;
	}
}
