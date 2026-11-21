using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F1F RID: 3871
	public struct MotorFightActivity : IFlatbufferObject
	{
		// Token: 0x170020CB RID: 8395
		// (get) Token: 0x06009DCC RID: 40396 RVA: 0x002AAECC File Offset: 0x002A90CC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06009DCD RID: 40397 RVA: 0x002AAED9 File Offset: 0x002A90D9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06009DCE RID: 40398 RVA: 0x002AAEE0 File Offset: 0x002A90E0
		public static MotorFightActivity GetRootAsMotorFightActivity(ByteBuffer _bb)
		{
			return MotorFightActivity.GetRootAsMotorFightActivity(_bb, default(MotorFightActivity));
		}

		// Token: 0x06009DCF RID: 40399 RVA: 0x002AAEFC File Offset: 0x002A90FC
		public static MotorFightActivity GetRootAsMotorFightActivity(ByteBuffer _bb, MotorFightActivity obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06009DD0 RID: 40400 RVA: 0x002AAF19 File Offset: 0x002A9119
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06009DD1 RID: 40401 RVA: 0x002AAF28 File Offset: 0x002A9128
		public MotorFightActivity __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170020CC RID: 8396
		// (get) Token: 0x06009DD2 RID: 40402 RVA: 0x002AAF38 File Offset: 0x002A9138
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

		// Token: 0x170020CD RID: 8397
		// (get) Token: 0x06009DD3 RID: 40403 RVA: 0x002AAF74 File Offset: 0x002A9174
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

		// Token: 0x170020CE RID: 8398
		// (get) Token: 0x06009DD4 RID: 40404 RVA: 0x002AAFB0 File Offset: 0x002A91B0
		public int TalentTreeItemId
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

		// Token: 0x040054C7 RID: 21703
		private Table __p;
	}
}
