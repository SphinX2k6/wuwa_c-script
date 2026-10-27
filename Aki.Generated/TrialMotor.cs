using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001177 RID: 4471
	public struct TrialMotor : IFlatbufferObject
	{
		// Token: 0x17003CD4 RID: 15572
		// (get) Token: 0x0600E557 RID: 58711 RVA: 0x0033C82D File Offset: 0x0033AA2D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600E558 RID: 58712 RVA: 0x0033C83A File Offset: 0x0033AA3A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600E559 RID: 58713 RVA: 0x0033C844 File Offset: 0x0033AA44
		public static TrialMotor GetRootAsTrialMotor(ByteBuffer _bb)
		{
			return TrialMotor.GetRootAsTrialMotor(_bb, default(TrialMotor));
		}

		// Token: 0x0600E55A RID: 58714 RVA: 0x0033C860 File Offset: 0x0033AA60
		public static TrialMotor GetRootAsTrialMotor(ByteBuffer _bb, TrialMotor obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600E55B RID: 58715 RVA: 0x0033C87D File Offset: 0x0033AA7D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600E55C RID: 58716 RVA: 0x0033C88C File Offset: 0x0033AA8C
		public TrialMotor __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003CD5 RID: 15573
		// (get) Token: 0x0600E55D RID: 58717 RVA: 0x0033C89C File Offset: 0x0033AA9C
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

		// Token: 0x17003CD6 RID: 15574
		// (get) Token: 0x0600E55E RID: 58718 RVA: 0x0033C8D8 File Offset: 0x0033AAD8
		public int MotorLoadProjectId
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

		// Token: 0x17003CD7 RID: 15575
		// (get) Token: 0x0600E55F RID: 58719 RVA: 0x0033C914 File Offset: 0x0033AB14
		public int MotorLoadType
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

		// Token: 0x17003CD8 RID: 15576
		// (get) Token: 0x0600E560 RID: 58720 RVA: 0x0033C950 File Offset: 0x0033AB50
		public int Level
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

		// Token: 0x17003CD9 RID: 15577
		// (get) Token: 0x0600E561 RID: 58721 RVA: 0x0033C990 File Offset: 0x0033AB90
		public bool UseMotorTechTree
		{
			get
			{
				int num = this.__p.__offset(12);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17003CDA RID: 15578
		// (get) Token: 0x0600E562 RID: 58722 RVA: 0x0033C9D0 File Offset: 0x0033ABD0
		public int TechTreeType
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

		// Token: 0x040052BD RID: 21181
		private Table __p;
	}
}
