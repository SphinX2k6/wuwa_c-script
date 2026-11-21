using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007AD9 RID: 31449
	public struct ITalkItemStylePhoneSendError : IFlatbufferObject
	{
		// Token: 0x1700E9BD RID: 59837
		// (get) Token: 0x06038304 RID: 230148 RVA: 0x0078FCB5 File Offset: 0x0078DEB5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06038305 RID: 230149 RVA: 0x0078FCC2 File Offset: 0x0078DEC2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06038306 RID: 230150 RVA: 0x0078FCCC File Offset: 0x0078DECC
		public static ITalkItemStylePhoneSendError GetRootAsITalkItemStylePhoneSendError(ByteBuffer _bb)
		{
			return ITalkItemStylePhoneSendError.GetRootAsITalkItemStylePhoneSendError(_bb, default(ITalkItemStylePhoneSendError));
		}

		// Token: 0x06038307 RID: 230151 RVA: 0x0078FCE8 File Offset: 0x0078DEE8
		public static ITalkItemStylePhoneSendError GetRootAsITalkItemStylePhoneSendError(ByteBuffer _bb, ITalkItemStylePhoneSendError obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06038308 RID: 230152 RVA: 0x0078FD05 File Offset: 0x0078DF05
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06038309 RID: 230153 RVA: 0x0078FD14 File Offset: 0x0078DF14
		public ITalkItemStylePhoneSendError __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E9BE RID: 59838
		// (get) Token: 0x0603830A RID: 230154 RVA: 0x0078FD24 File Offset: 0x0078DF24
		public ETalkItemStyle Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ETalkItemStyle.InnerVoice;
				}
				return (ETalkItemStyle)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0603830B RID: 230155 RVA: 0x0078FD60 File Offset: 0x0078DF60
		public static Offset<ITalkItemStylePhoneSendError> CreateITalkItemStylePhoneSendError(FlatBufferBuilder builder, ETalkItemStyle Type = ETalkItemStyle.InnerVoice)
		{
			builder.StartTable(1);
			ITalkItemStylePhoneSendError.AddType(builder, Type);
			return ITalkItemStylePhoneSendError.EndITalkItemStylePhoneSendError(builder);
		}

		// Token: 0x0603830C RID: 230156 RVA: 0x0078FD76 File Offset: 0x0078DF76
		public static void StartITalkItemStylePhoneSendError(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0603830D RID: 230157 RVA: 0x0078FD7F File Offset: 0x0078DF7F
		public static void AddType(FlatBufferBuilder builder, ETalkItemStyle type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0603830E RID: 230158 RVA: 0x0078FD8A File Offset: 0x0078DF8A
		public static Offset<ITalkItemStylePhoneSendError> EndITalkItemStylePhoneSendError(FlatBufferBuilder builder)
		{
			return new Offset<ITalkItemStylePhoneSendError>(builder.EndTable());
		}

		// Token: 0x0603830F RID: 230159 RVA: 0x0078FD98 File Offset: 0x0078DF98
		public ITalkItemStylePhoneSendErrorT UnPack()
		{
			ITalkItemStylePhoneSendErrorT talkItemStylePhoneSendErrorT = new ITalkItemStylePhoneSendErrorT();
			this.UnPackTo(talkItemStylePhoneSendErrorT);
			return talkItemStylePhoneSendErrorT;
		}

		// Token: 0x06038310 RID: 230160 RVA: 0x0078FDB3 File Offset: 0x0078DFB3
		public void UnPackTo(ITalkItemStylePhoneSendErrorT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06038311 RID: 230161 RVA: 0x0078FDC4 File Offset: 0x0078DFC4
		public static Offset<ITalkItemStylePhoneSendError> Pack(FlatBufferBuilder builder, ITalkItemStylePhoneSendErrorT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITalkItemStylePhoneSendError>);
			}
			return ITalkItemStylePhoneSendError.CreateITalkItemStylePhoneSendError(builder, _o.Type);
		}

		// Token: 0x04012FE3 RID: 77795
		private Table __p;
	}
}
