using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007738 RID: 30520
	public struct ISendNpcMail : IFlatbufferObject
	{
		// Token: 0x1700DFBF RID: 57279
		// (get) Token: 0x060358C9 RID: 219337 RVA: 0x0072D7C4 File Offset: 0x0072B9C4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060358CA RID: 219338 RVA: 0x0072D7D1 File Offset: 0x0072B9D1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060358CB RID: 219339 RVA: 0x0072D7D8 File Offset: 0x0072B9D8
		public static ISendNpcMail GetRootAsISendNpcMail(ByteBuffer _bb)
		{
			return ISendNpcMail.GetRootAsISendNpcMail(_bb, default(ISendNpcMail));
		}

		// Token: 0x060358CC RID: 219340 RVA: 0x0072D7F4 File Offset: 0x0072B9F4
		public static ISendNpcMail GetRootAsISendNpcMail(ByteBuffer _bb, ISendNpcMail obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060358CD RID: 219341 RVA: 0x0072D811 File Offset: 0x0072BA11
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060358CE RID: 219342 RVA: 0x0072D820 File Offset: 0x0072BA20
		public ISendNpcMail __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700DFC0 RID: 57280
		// (get) Token: 0x060358CF RID: 219343 RVA: 0x0072D830 File Offset: 0x0072BA30
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

		// Token: 0x060358D0 RID: 219344 RVA: 0x0072D86C File Offset: 0x0072BA6C
		public static Offset<ISendNpcMail> CreateISendNpcMail(FlatBufferBuilder builder, int MailId = 0)
		{
			builder.StartTable(1);
			ISendNpcMail.AddMailId(builder, MailId);
			return ISendNpcMail.EndISendNpcMail(builder);
		}

		// Token: 0x060358D1 RID: 219345 RVA: 0x0072D882 File Offset: 0x0072BA82
		public static void StartISendNpcMail(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060358D2 RID: 219346 RVA: 0x0072D88B File Offset: 0x0072BA8B
		public static void AddMailId(FlatBufferBuilder builder, int mailId)
		{
			builder.AddInt(0, mailId, 0);
		}

		// Token: 0x060358D3 RID: 219347 RVA: 0x0072D896 File Offset: 0x0072BA96
		public static Offset<ISendNpcMail> EndISendNpcMail(FlatBufferBuilder builder)
		{
			return new Offset<ISendNpcMail>(builder.EndTable());
		}

		// Token: 0x060358D4 RID: 219348 RVA: 0x0072D8A4 File Offset: 0x0072BAA4
		public ISendNpcMailT UnPack()
		{
			ISendNpcMailT sendNpcMailT = new ISendNpcMailT();
			this.UnPackTo(sendNpcMailT);
			return sendNpcMailT;
		}

		// Token: 0x060358D5 RID: 219349 RVA: 0x0072D8BF File Offset: 0x0072BABF
		public void UnPackTo(ISendNpcMailT _o)
		{
			_o.MailId = this.MailId;
		}

		// Token: 0x060358D6 RID: 219350 RVA: 0x0072D8D0 File Offset: 0x0072BAD0
		public static Offset<ISendNpcMail> Pack(FlatBufferBuilder builder, ISendNpcMailT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISendNpcMail>);
			}
			return ISendNpcMail.CreateISendNpcMail(builder, _o.MailId);
		}

		// Token: 0x04012952 RID: 76114
		private Table __p;
	}
}
