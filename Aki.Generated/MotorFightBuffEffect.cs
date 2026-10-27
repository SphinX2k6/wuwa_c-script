using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E3F RID: 3647
	public struct MotorFightBuffEffect : IFlatbufferObject
	{
		// Token: 0x17002099 RID: 8345
		// (get) Token: 0x060097FC RID: 38908 RVA: 0x0028E00D File Offset: 0x0028C20D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060097FD RID: 38909 RVA: 0x0028E01A File Offset: 0x0028C21A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060097FE RID: 38910 RVA: 0x0028E024 File Offset: 0x0028C224
		public static MotorFightBuffEffect GetRootAsMotorFightBuffEffect(ByteBuffer _bb)
		{
			return MotorFightBuffEffect.GetRootAsMotorFightBuffEffect(_bb, default(MotorFightBuffEffect));
		}

		// Token: 0x060097FF RID: 38911 RVA: 0x0028E040 File Offset: 0x0028C240
		public static MotorFightBuffEffect GetRootAsMotorFightBuffEffect(ByteBuffer _bb, MotorFightBuffEffect obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06009800 RID: 38912 RVA: 0x0028E05D File Offset: 0x0028C25D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06009801 RID: 38913 RVA: 0x0028E06C File Offset: 0x0028C26C
		public MotorFightBuffEffect __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700209A RID: 8346
		// (get) Token: 0x06009802 RID: 38914 RVA: 0x0028E07C File Offset: 0x0028C27C
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

		// Token: 0x1700209B RID: 8347
		// (get) Token: 0x06009803 RID: 38915 RVA: 0x0028E0B8 File Offset: 0x0028C2B8
		public int BuffId
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

		// Token: 0x1700209C RID: 8348
		// (get) Token: 0x06009804 RID: 38916 RVA: 0x0028E0F4 File Offset: 0x0028C2F4
		public int DurationType
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

		// Token: 0x1700209D RID: 8349
		// (get) Token: 0x06009805 RID: 38917 RVA: 0x0028E130 File Offset: 0x0028C330
		public int Param1
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

		// Token: 0x04004EE7 RID: 20199
		private Table __p;
	}
}
