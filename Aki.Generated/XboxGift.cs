using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020012E3 RID: 4835
	public struct XboxGift : IFlatbufferObject
	{
		// Token: 0x17004204 RID: 16900
		// (get) Token: 0x0600F714 RID: 63252 RVA: 0x00371558 File Offset: 0x0036F758
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600F715 RID: 63253 RVA: 0x00371565 File Offset: 0x0036F765
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600F716 RID: 63254 RVA: 0x0037156C File Offset: 0x0036F76C
		public static XboxGift GetRootAsXboxGift(ByteBuffer _bb)
		{
			return XboxGift.GetRootAsXboxGift(_bb, default(XboxGift));
		}

		// Token: 0x0600F717 RID: 63255 RVA: 0x00371588 File Offset: 0x0036F788
		public static XboxGift GetRootAsXboxGift(ByteBuffer _bb, XboxGift obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600F718 RID: 63256 RVA: 0x003715A5 File Offset: 0x0036F7A5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600F719 RID: 63257 RVA: 0x003715B4 File Offset: 0x0036F7B4
		public XboxGift __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17004205 RID: 16901
		// (get) Token: 0x0600F71A RID: 63258 RVA: 0x003715C4 File Offset: 0x0036F7C4
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

		// Token: 0x17004206 RID: 16902
		// (get) Token: 0x0600F71B RID: 63259 RVA: 0x00371600 File Offset: 0x0036F800
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

		// Token: 0x17004207 RID: 16903
		// (get) Token: 0x0600F71C RID: 63260 RVA: 0x0037163C File Offset: 0x0036F83C
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

		// Token: 0x17004208 RID: 16904
		// (get) Token: 0x0600F71D RID: 63261 RVA: 0x00371678 File Offset: 0x0036F878
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

		// Token: 0x0400593D RID: 22845
		private Table __p;
	}
}
