using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020011AF RID: 4527
	public struct BlackScreenLang : IFlatbufferObject
	{
		// Token: 0x17003EA7 RID: 16039
		// (get) Token: 0x0600E9B9 RID: 59833 RVA: 0x00346B55 File Offset: 0x00344D55
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600E9BA RID: 59834 RVA: 0x00346B62 File Offset: 0x00344D62
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600E9BB RID: 59835 RVA: 0x00346B6C File Offset: 0x00344D6C
		public static BlackScreenLang GetRootAsBlackScreenLang(ByteBuffer _bb)
		{
			return BlackScreenLang.GetRootAsBlackScreenLang(_bb, default(BlackScreenLang));
		}

		// Token: 0x0600E9BC RID: 59836 RVA: 0x00346B88 File Offset: 0x00344D88
		public static BlackScreenLang GetRootAsBlackScreenLang(ByteBuffer _bb, BlackScreenLang obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600E9BD RID: 59837 RVA: 0x00346BA5 File Offset: 0x00344DA5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600E9BE RID: 59838 RVA: 0x00346BB4 File Offset: 0x00344DB4
		public BlackScreenLang __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003EA8 RID: 16040
		// (get) Token: 0x0600E9BF RID: 59839 RVA: 0x00346BC4 File Offset: 0x00344DC4
		public int ShowAnimName
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

		// Token: 0x17003EA9 RID: 16041
		// (get) Token: 0x0600E9C0 RID: 59840 RVA: 0x00346C00 File Offset: 0x00344E00
		public int HideAnimName
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

		// Token: 0x040052FC RID: 21244
		private Table __p;
	}
}
