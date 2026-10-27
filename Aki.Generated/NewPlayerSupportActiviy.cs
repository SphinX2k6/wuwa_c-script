using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E87 RID: 3719
	public struct NewPlayerSupportActiviy : IFlatbufferObject
	{
		// Token: 0x17002320 RID: 8992
		// (get) Token: 0x06009ED2 RID: 40658 RVA: 0x0029D051 File Offset: 0x0029B251
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06009ED3 RID: 40659 RVA: 0x0029D05E File Offset: 0x0029B25E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06009ED4 RID: 40660 RVA: 0x0029D068 File Offset: 0x0029B268
		public static NewPlayerSupportActiviy GetRootAsNewPlayerSupportActiviy(ByteBuffer _bb)
		{
			return NewPlayerSupportActiviy.GetRootAsNewPlayerSupportActiviy(_bb, default(NewPlayerSupportActiviy));
		}

		// Token: 0x06009ED5 RID: 40661 RVA: 0x0029D084 File Offset: 0x0029B284
		public static NewPlayerSupportActiviy GetRootAsNewPlayerSupportActiviy(ByteBuffer _bb, NewPlayerSupportActiviy obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06009ED6 RID: 40662 RVA: 0x0029D0A1 File Offset: 0x0029B2A1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06009ED7 RID: 40663 RVA: 0x0029D0B0 File Offset: 0x0029B2B0
		public NewPlayerSupportActiviy __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002321 RID: 8993
		// (get) Token: 0x06009ED8 RID: 40664 RVA: 0x0029D0C0 File Offset: 0x0029B2C0
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

		// Token: 0x17002322 RID: 8994
		// (get) Token: 0x06009ED9 RID: 40665 RVA: 0x0029D0FC File Offset: 0x0029B2FC
		public int ContinueDays
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

		// Token: 0x17002323 RID: 8995
		// (get) Token: 0x06009EDA RID: 40666 RVA: 0x0029D138 File Offset: 0x0029B338
		public int EnableTime
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

		// Token: 0x17002324 RID: 8996
		// (get) Token: 0x06009EDB RID: 40667 RVA: 0x0029D174 File Offset: 0x0029B374
		public int EnableMaxLv
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x04004F35 RID: 20277
		private Table __p;
	}
}
