using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E3A RID: 3642
	public struct MotorFightActivity : IFlatbufferObject
	{
		// Token: 0x17002066 RID: 8294
		// (get) Token: 0x060097AC RID: 38828 RVA: 0x0028D268 File Offset: 0x0028B468
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060097AD RID: 38829 RVA: 0x0028D275 File Offset: 0x0028B475
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060097AE RID: 38830 RVA: 0x0028D27C File Offset: 0x0028B47C
		public static MotorFightActivity GetRootAsMotorFightActivity(ByteBuffer _bb)
		{
			return MotorFightActivity.GetRootAsMotorFightActivity(_bb, default(MotorFightActivity));
		}

		// Token: 0x060097AF RID: 38831 RVA: 0x0028D298 File Offset: 0x0028B498
		public static MotorFightActivity GetRootAsMotorFightActivity(ByteBuffer _bb, MotorFightActivity obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060097B0 RID: 38832 RVA: 0x0028D2B5 File Offset: 0x0028B4B5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060097B1 RID: 38833 RVA: 0x0028D2C4 File Offset: 0x0028B4C4
		public MotorFightActivity __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002067 RID: 8295
		// (get) Token: 0x060097B2 RID: 38834 RVA: 0x0028D2D4 File Offset: 0x0028B4D4
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

		// Token: 0x17002068 RID: 8296
		// (get) Token: 0x060097B3 RID: 38835 RVA: 0x0028D310 File Offset: 0x0028B510
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

		// Token: 0x17002069 RID: 8297
		// (get) Token: 0x060097B4 RID: 38836 RVA: 0x0028D34C File Offset: 0x0028B54C
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

		// Token: 0x04004EE2 RID: 20194
		private Table __p;
	}
}
