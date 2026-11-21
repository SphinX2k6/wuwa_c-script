using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000EC8 RID: 3784
	public struct Mail : IFlatbufferObject
	{
		// Token: 0x17001E12 RID: 7698
		// (get) Token: 0x06009667 RID: 38503 RVA: 0x0029ADD7 File Offset: 0x00298FD7
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06009668 RID: 38504 RVA: 0x0029ADE4 File Offset: 0x00298FE4
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06009669 RID: 38505 RVA: 0x0029ADEC File Offset: 0x00298FEC
		public static Mail GetRootAsMail(ByteBuffer _bb)
		{
			return Mail.GetRootAsMail(_bb, default(Mail));
		}

		// Token: 0x0600966A RID: 38506 RVA: 0x0029AE08 File Offset: 0x00299008
		public static Mail GetRootAsMail(ByteBuffer _bb, Mail obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600966B RID: 38507 RVA: 0x0029AE25 File Offset: 0x00299025
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600966C RID: 38508 RVA: 0x0029AE34 File Offset: 0x00299034
		public Mail __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001E13 RID: 7699
		// (get) Token: 0x0600966D RID: 38509 RVA: 0x0029AE44 File Offset: 0x00299044
		public int MailId
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

		// Token: 0x17001E14 RID: 7700
		// (get) Token: 0x0600966E RID: 38510 RVA: 0x0029AE80 File Offset: 0x00299080
		public int JumpId
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

		// Token: 0x04005464 RID: 21604
		private Table __p;
	}
}
