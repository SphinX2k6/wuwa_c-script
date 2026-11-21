using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000BA2 RID: 2978
	public struct ActivityQuestConfig : IFlatbufferObject
	{
		// Token: 0x17000174 RID: 372
		// (get) Token: 0x060048DB RID: 18651 RVA: 0x001EC581 File Offset: 0x001EA781
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060048DC RID: 18652 RVA: 0x001EC58E File Offset: 0x001EA78E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060048DD RID: 18653 RVA: 0x001EC598 File Offset: 0x001EA798
		public static ActivityQuestConfig GetRootAsActivityQuestConfig(ByteBuffer _bb)
		{
			return ActivityQuestConfig.GetRootAsActivityQuestConfig(_bb, default(ActivityQuestConfig));
		}

		// Token: 0x060048DE RID: 18654 RVA: 0x001EC5B4 File Offset: 0x001EA7B4
		public static ActivityQuestConfig GetRootAsActivityQuestConfig(ByteBuffer _bb, ActivityQuestConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060048DF RID: 18655 RVA: 0x001EC5D1 File Offset: 0x001EA7D1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060048E0 RID: 18656 RVA: 0x001EC5E0 File Offset: 0x001EA7E0
		public ActivityQuestConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000175 RID: 373
		// (get) Token: 0x060048E1 RID: 18657 RVA: 0x001EC5F0 File Offset: 0x001EA7F0
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

		// Token: 0x17000176 RID: 374
		// (get) Token: 0x060048E2 RID: 18658 RVA: 0x001EC62C File Offset: 0x001EA82C
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

		// Token: 0x17000177 RID: 375
		// (get) Token: 0x060048E3 RID: 18659 RVA: 0x001EC668 File Offset: 0x001EA868
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

		// Token: 0x17000178 RID: 376
		// (get) Token: 0x060048E4 RID: 18660 RVA: 0x001EC6A4 File Offset: 0x001EA8A4
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

		// Token: 0x17000179 RID: 377
		// (get) Token: 0x060048E5 RID: 18661 RVA: 0x001EC6E4 File Offset: 0x001EA8E4
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

		// Token: 0x1700017A RID: 378
		// (get) Token: 0x060048E6 RID: 18662 RVA: 0x001EC724 File Offset: 0x001EA924
		public bool IsDisplay
		{
			get
			{
				int num = this.__p.__offset(14);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0400507F RID: 20607
		private Table __p;
	}
}
