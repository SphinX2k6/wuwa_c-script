using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020012AD RID: 4781
	public struct TrialMotor : IFlatbufferObject
	{
		// Token: 0x17004038 RID: 16440
		// (get) Token: 0x0600F2C5 RID: 62149 RVA: 0x00367646 File Offset: 0x00365846
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600F2C6 RID: 62150 RVA: 0x00367653 File Offset: 0x00365853
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600F2C7 RID: 62151 RVA: 0x0036765C File Offset: 0x0036585C
		public static TrialMotor GetRootAsTrialMotor(ByteBuffer _bb)
		{
			return TrialMotor.GetRootAsTrialMotor(_bb, default(TrialMotor));
		}

		// Token: 0x0600F2C8 RID: 62152 RVA: 0x00367678 File Offset: 0x00365878
		public static TrialMotor GetRootAsTrialMotor(ByteBuffer _bb, TrialMotor obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600F2C9 RID: 62153 RVA: 0x00367695 File Offset: 0x00365895
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600F2CA RID: 62154 RVA: 0x003676A4 File Offset: 0x003658A4
		public TrialMotor __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17004039 RID: 16441
		// (get) Token: 0x0600F2CB RID: 62155 RVA: 0x003676B4 File Offset: 0x003658B4
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

		// Token: 0x1700403A RID: 16442
		// (get) Token: 0x0600F2CC RID: 62156 RVA: 0x003676F0 File Offset: 0x003658F0
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

		// Token: 0x1700403B RID: 16443
		// (get) Token: 0x0600F2CD RID: 62157 RVA: 0x0036772C File Offset: 0x0036592C
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

		// Token: 0x1700403C RID: 16444
		// (get) Token: 0x0600F2CE RID: 62158 RVA: 0x00367768 File Offset: 0x00365968
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

		// Token: 0x1700403D RID: 16445
		// (get) Token: 0x0600F2CF RID: 62159 RVA: 0x003677A8 File Offset: 0x003659A8
		public bool UseMotorTechTree
		{
			get
			{
				int num = this.__p.__offset(12);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700403E RID: 16446
		// (get) Token: 0x0600F2D0 RID: 62160 RVA: 0x003677E8 File Offset: 0x003659E8
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

		// Token: 0x04005900 RID: 22784
		private Table __p;
	}
}
