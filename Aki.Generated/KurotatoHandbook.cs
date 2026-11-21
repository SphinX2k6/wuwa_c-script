using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E85 RID: 3717
	public struct KurotatoHandbook : IFlatbufferObject
	{
		// Token: 0x17001BDD RID: 7133
		// (get) Token: 0x06008FC1 RID: 36801 RVA: 0x0028CD9C File Offset: 0x0028AF9C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06008FC2 RID: 36802 RVA: 0x0028CDA9 File Offset: 0x0028AFA9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06008FC3 RID: 36803 RVA: 0x0028CDB0 File Offset: 0x0028AFB0
		public static KurotatoHandbook GetRootAsKurotatoHandbook(ByteBuffer _bb)
		{
			return KurotatoHandbook.GetRootAsKurotatoHandbook(_bb, default(KurotatoHandbook));
		}

		// Token: 0x06008FC4 RID: 36804 RVA: 0x0028CDCC File Offset: 0x0028AFCC
		public static KurotatoHandbook GetRootAsKurotatoHandbook(ByteBuffer _bb, KurotatoHandbook obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06008FC5 RID: 36805 RVA: 0x0028CDE9 File Offset: 0x0028AFE9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06008FC6 RID: 36806 RVA: 0x0028CDF8 File Offset: 0x0028AFF8
		public KurotatoHandbook __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001BDE RID: 7134
		// (get) Token: 0x06008FC7 RID: 36807 RVA: 0x0028CE08 File Offset: 0x0028B008
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

		// Token: 0x17001BDF RID: 7135
		// (get) Token: 0x06008FC8 RID: 36808 RVA: 0x0028CE44 File Offset: 0x0028B044
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

		// Token: 0x17001BE0 RID: 7136
		// (get) Token: 0x06008FC9 RID: 36809 RVA: 0x0028CE80 File Offset: 0x0028B080
		public int Type
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

		// Token: 0x17001BE1 RID: 7137
		// (get) Token: 0x06008FCA RID: 36810 RVA: 0x0028CEBC File Offset: 0x0028B0BC
		public int Index
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

		// Token: 0x04005416 RID: 21526
		private Table __p;
	}
}
