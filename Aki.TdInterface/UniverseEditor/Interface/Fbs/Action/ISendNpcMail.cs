using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006F72 RID: 28530
	public struct ISendNpcMail : IFlatbufferObject
	{
		// Token: 0x1700D3F0 RID: 54256
		// (get) Token: 0x06032679 RID: 206457 RVA: 0x006CDE0C File Offset: 0x006CC00C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603267A RID: 206458 RVA: 0x006CDE19 File Offset: 0x006CC019
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603267B RID: 206459 RVA: 0x006CDE20 File Offset: 0x006CC020
		public static ISendNpcMail GetRootAsISendNpcMail(ByteBuffer _bb)
		{
			return ISendNpcMail.GetRootAsISendNpcMail(_bb, default(ISendNpcMail));
		}

		// Token: 0x0603267C RID: 206460 RVA: 0x006CDE3C File Offset: 0x006CC03C
		public static ISendNpcMail GetRootAsISendNpcMail(ByteBuffer _bb, ISendNpcMail obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603267D RID: 206461 RVA: 0x006CDE59 File Offset: 0x006CC059
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603267E RID: 206462 RVA: 0x006CDE68 File Offset: 0x006CC068
		public ISendNpcMail __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D3F1 RID: 54257
		// (get) Token: 0x0603267F RID: 206463 RVA: 0x006CDE78 File Offset: 0x006CC078
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

		// Token: 0x06032680 RID: 206464 RVA: 0x006CDEB4 File Offset: 0x006CC0B4
		public static Offset<ISendNpcMail> CreateISendNpcMail(FlatBufferBuilder builder, int MailId = 0)
		{
			builder.StartTable(1);
			ISendNpcMail.AddMailId(builder, MailId);
			return ISendNpcMail.EndISendNpcMail(builder);
		}

		// Token: 0x06032681 RID: 206465 RVA: 0x006CDECA File Offset: 0x006CC0CA
		public static void StartISendNpcMail(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06032682 RID: 206466 RVA: 0x006CDED3 File Offset: 0x006CC0D3
		public static void AddMailId(FlatBufferBuilder builder, int mailId)
		{
			builder.AddInt(0, mailId, 0);
		}

		// Token: 0x06032683 RID: 206467 RVA: 0x006CDEDE File Offset: 0x006CC0DE
		public static Offset<ISendNpcMail> EndISendNpcMail(FlatBufferBuilder builder)
		{
			return new Offset<ISendNpcMail>(builder.EndTable());
		}

		// Token: 0x06032684 RID: 206468 RVA: 0x006CDEEC File Offset: 0x006CC0EC
		public ISendNpcMailT UnPack()
		{
			ISendNpcMailT sendNpcMailT = new ISendNpcMailT();
			this.UnPackTo(sendNpcMailT);
			return sendNpcMailT;
		}

		// Token: 0x06032685 RID: 206469 RVA: 0x006CDF07 File Offset: 0x006CC107
		public void UnPackTo(ISendNpcMailT _o)
		{
			_o.MailId = this.MailId;
		}

		// Token: 0x06032686 RID: 206470 RVA: 0x006CDF18 File Offset: 0x006CC118
		public static Offset<ISendNpcMail> Pack(FlatBufferBuilder builder, ISendNpcMailT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISendNpcMail>);
			}
			return ISendNpcMail.CreateISendNpcMail(builder, _o.MailId);
		}

		// Token: 0x04011970 RID: 72048
		private Table __p;
	}
}
