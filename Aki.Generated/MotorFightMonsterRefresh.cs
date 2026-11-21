using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F2F RID: 3887
	public struct MotorFightMonsterRefresh : IFlatbufferObject
	{
		// Token: 0x17002162 RID: 8546
		// (get) Token: 0x06009F12 RID: 40722 RVA: 0x002ADDBD File Offset: 0x002ABFBD
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06009F13 RID: 40723 RVA: 0x002ADDCA File Offset: 0x002ABFCA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06009F14 RID: 40724 RVA: 0x002ADDD4 File Offset: 0x002ABFD4
		public static MotorFightMonsterRefresh GetRootAsMotorFightMonsterRefresh(ByteBuffer _bb)
		{
			return MotorFightMonsterRefresh.GetRootAsMotorFightMonsterRefresh(_bb, default(MotorFightMonsterRefresh));
		}

		// Token: 0x06009F15 RID: 40725 RVA: 0x002ADDF0 File Offset: 0x002ABFF0
		public static MotorFightMonsterRefresh GetRootAsMotorFightMonsterRefresh(ByteBuffer _bb, MotorFightMonsterRefresh obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06009F16 RID: 40726 RVA: 0x002ADE0D File Offset: 0x002AC00D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06009F17 RID: 40727 RVA: 0x002ADE1C File Offset: 0x002AC01C
		public MotorFightMonsterRefresh __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002163 RID: 8547
		// (get) Token: 0x06009F18 RID: 40728 RVA: 0x002ADE2C File Offset: 0x002AC02C
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

		// Token: 0x17002164 RID: 8548
		// (get) Token: 0x06009F19 RID: 40729 RVA: 0x002ADE68 File Offset: 0x002AC068
		public int GroupId
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

		// Token: 0x17002165 RID: 8549
		// (get) Token: 0x06009F1A RID: 40730 RVA: 0x002ADEA4 File Offset: 0x002AC0A4
		public int Weight
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

		// Token: 0x17002166 RID: 8550
		// (get) Token: 0x06009F1B RID: 40731 RVA: 0x002ADEE0 File Offset: 0x002AC0E0
		public int MonsterId
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

		// Token: 0x17002167 RID: 8551
		// (get) Token: 0x06009F1C RID: 40732 RVA: 0x002ADF20 File Offset: 0x002AC120
		public int DropGroupId
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

		// Token: 0x040054D7 RID: 21719
		private Table __p;
	}
}
