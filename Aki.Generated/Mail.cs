using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000DE3 RID: 3555
	public struct Mail : IFlatbufferObject
	{
		// Token: 0x17001DAE RID: 7598
		// (get) Token: 0x0600904B RID: 36939 RVA: 0x0027CB57 File Offset: 0x0027AD57
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600904C RID: 36940 RVA: 0x0027CB64 File Offset: 0x0027AD64
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600904D RID: 36941 RVA: 0x0027CB6C File Offset: 0x0027AD6C
		public static Mail GetRootAsMail(ByteBuffer _bb)
		{
			return Mail.GetRootAsMail(_bb, default(Mail));
		}

		// Token: 0x0600904E RID: 36942 RVA: 0x0027CB88 File Offset: 0x0027AD88
		public static Mail GetRootAsMail(ByteBuffer _bb, Mail obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600904F RID: 36943 RVA: 0x0027CBA5 File Offset: 0x0027ADA5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06009050 RID: 36944 RVA: 0x0027CBB4 File Offset: 0x0027ADB4
		public Mail __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001DAF RID: 7599
		// (get) Token: 0x06009051 RID: 36945 RVA: 0x0027CBC4 File Offset: 0x0027ADC4
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

		// Token: 0x17001DB0 RID: 7600
		// (get) Token: 0x06009052 RID: 36946 RVA: 0x0027CC00 File Offset: 0x0027AE00
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

		// Token: 0x04004E7F RID: 20095
		private Table __p;
	}
}
