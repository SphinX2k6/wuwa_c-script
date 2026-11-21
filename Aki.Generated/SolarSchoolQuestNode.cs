using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020011F8 RID: 4600
	public struct SolarSchoolQuestNode : IFlatbufferObject
	{
		// Token: 0x17003A30 RID: 14896
		// (get) Token: 0x0600E2EC RID: 58092 RVA: 0x003444A0 File Offset: 0x003426A0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600E2ED RID: 58093 RVA: 0x003444AD File Offset: 0x003426AD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600E2EE RID: 58094 RVA: 0x003444B4 File Offset: 0x003426B4
		public static SolarSchoolQuestNode GetRootAsSolarSchoolQuestNode(ByteBuffer _bb)
		{
			return SolarSchoolQuestNode.GetRootAsSolarSchoolQuestNode(_bb, default(SolarSchoolQuestNode));
		}

		// Token: 0x0600E2EF RID: 58095 RVA: 0x003444D0 File Offset: 0x003426D0
		public static SolarSchoolQuestNode GetRootAsSolarSchoolQuestNode(ByteBuffer _bb, SolarSchoolQuestNode obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600E2F0 RID: 58096 RVA: 0x003444ED File Offset: 0x003426ED
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600E2F1 RID: 58097 RVA: 0x003444FC File Offset: 0x003426FC
		public SolarSchoolQuestNode __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003A31 RID: 14897
		// (get) Token: 0x0600E2F2 RID: 58098 RVA: 0x0034450C File Offset: 0x0034270C
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

		// Token: 0x17003A32 RID: 14898
		// (get) Token: 0x0600E2F3 RID: 58099 RVA: 0x00344548 File Offset: 0x00342748
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

		// Token: 0x17003A33 RID: 14899
		// (get) Token: 0x0600E2F4 RID: 58100 RVA: 0x00344584 File Offset: 0x00342784
		public int PreNodeId
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

		// Token: 0x17003A34 RID: 14900
		// (get) Token: 0x0600E2F5 RID: 58101 RVA: 0x003445C0 File Offset: 0x003427C0
		public int UnlockConditionGroupId
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

		// Token: 0x17003A35 RID: 14901
		// (get) Token: 0x0600E2F6 RID: 58102 RVA: 0x00344600 File Offset: 0x00342800
		public int AvailableConditionGroupId
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

		// Token: 0x17003A36 RID: 14902
		// (get) Token: 0x0600E2F7 RID: 58103 RVA: 0x00344640 File Offset: 0x00342840
		public int ActionId
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

		// Token: 0x17003A37 RID: 14903
		// (get) Token: 0x0600E2F8 RID: 58104 RVA: 0x00344680 File Offset: 0x00342880
		public int TriggerTiming
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17003A38 RID: 14904
		// (get) Token: 0x0600E2F9 RID: 58105 RVA: 0x003446C0 File Offset: 0x003428C0
		public int TriggerParam
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17003A39 RID: 14905
		// (get) Token: 0x0600E2FA RID: 58106 RVA: 0x00344700 File Offset: 0x00342900
		public int Priority
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17003A3A RID: 14906
		// (get) Token: 0x0600E2FB RID: 58107 RVA: 0x00344740 File Offset: 0x00342940
		public int BitFlag
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x04005836 RID: 22582
		private Table __p;
	}
}
