using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020011AD RID: 4525
	public struct XboxGift : IFlatbufferObject
	{
		// Token: 0x17003E9F RID: 16031
		// (get) Token: 0x0600E9A3 RID: 59811 RVA: 0x003468CC File Offset: 0x00344ACC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600E9A4 RID: 59812 RVA: 0x003468D9 File Offset: 0x00344AD9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600E9A5 RID: 59813 RVA: 0x003468E0 File Offset: 0x00344AE0
		public static XboxGift GetRootAsXboxGift(ByteBuffer _bb)
		{
			return XboxGift.GetRootAsXboxGift(_bb, default(XboxGift));
		}

		// Token: 0x0600E9A6 RID: 59814 RVA: 0x003468FC File Offset: 0x00344AFC
		public static XboxGift GetRootAsXboxGift(ByteBuffer _bb, XboxGift obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600E9A7 RID: 59815 RVA: 0x00346919 File Offset: 0x00344B19
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600E9A8 RID: 59816 RVA: 0x00346928 File Offset: 0x00344B28
		public XboxGift __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003EA0 RID: 16032
		// (get) Token: 0x0600E9A9 RID: 59817 RVA: 0x00346938 File Offset: 0x00344B38
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

		// Token: 0x17003EA1 RID: 16033
		// (get) Token: 0x0600E9AA RID: 59818 RVA: 0x00346974 File Offset: 0x00344B74
		public int Type
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

		// Token: 0x17003EA2 RID: 16034
		// (get) Token: 0x0600E9AB RID: 59819 RVA: 0x003469B0 File Offset: 0x00344BB0
		public int Content
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

		// Token: 0x17003EA3 RID: 16035
		// (get) Token: 0x0600E9AC RID: 59820 RVA: 0x003469EC File Offset: 0x00344BEC
		public int MailId
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

		// Token: 0x040052FA RID: 21242
		private Table __p;
	}
}
