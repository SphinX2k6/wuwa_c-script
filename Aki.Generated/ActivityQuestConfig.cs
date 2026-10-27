using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000AC8 RID: 2760
	public struct ActivityQuestConfig : IFlatbufferObject
	{
		// Token: 0x1700015D RID: 349
		// (get) Token: 0x06004394 RID: 17300 RVA: 0x001CC9A1 File Offset: 0x001CABA1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06004395 RID: 17301 RVA: 0x001CC9AE File Offset: 0x001CABAE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06004396 RID: 17302 RVA: 0x001CC9B8 File Offset: 0x001CABB8
		public static ActivityQuestConfig GetRootAsActivityQuestConfig(ByteBuffer _bb)
		{
			return ActivityQuestConfig.GetRootAsActivityQuestConfig(_bb, default(ActivityQuestConfig));
		}

		// Token: 0x06004397 RID: 17303 RVA: 0x001CC9D4 File Offset: 0x001CABD4
		public static ActivityQuestConfig GetRootAsActivityQuestConfig(ByteBuffer _bb, ActivityQuestConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06004398 RID: 17304 RVA: 0x001CC9F1 File Offset: 0x001CABF1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06004399 RID: 17305 RVA: 0x001CCA00 File Offset: 0x001CAC00
		public ActivityQuestConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700015E RID: 350
		// (get) Token: 0x0600439A RID: 17306 RVA: 0x001CCA10 File Offset: 0x001CAC10
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

		// Token: 0x1700015F RID: 351
		// (get) Token: 0x0600439B RID: 17307 RVA: 0x001CCA4C File Offset: 0x001CAC4C
		public int QuestId
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

		// Token: 0x17000160 RID: 352
		// (get) Token: 0x0600439C RID: 17308 RVA: 0x001CCA88 File Offset: 0x001CAC88
		public int ActivityId
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

		// Token: 0x17000161 RID: 353
		// (get) Token: 0x0600439D RID: 17309 RVA: 0x001CCAC4 File Offset: 0x001CACC4
		public int ConditionId
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

		// Token: 0x17000162 RID: 354
		// (get) Token: 0x0600439E RID: 17310 RVA: 0x001CCB04 File Offset: 0x001CAD04
		public int OpenDay
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

		// Token: 0x17000163 RID: 355
		// (get) Token: 0x0600439F RID: 17311 RVA: 0x001CCB44 File Offset: 0x001CAD44
		public bool IsDisplay
		{
			get
			{
				int num = this.__p.__offset(14);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x04004AA5 RID: 19109
		private Table __p;
	}
}
