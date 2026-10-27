using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007304 RID: 29444
	public struct ITalkItemStylePhoneSendError : IFlatbufferObject
	{
		// Token: 0x1700DDC4 RID: 56772
		// (get) Token: 0x06034FFE RID: 217086 RVA: 0x0072E851 File Offset: 0x0072CA51
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06034FFF RID: 217087 RVA: 0x0072E85E File Offset: 0x0072CA5E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06035000 RID: 217088 RVA: 0x0072E868 File Offset: 0x0072CA68
		public static ITalkItemStylePhoneSendError GetRootAsITalkItemStylePhoneSendError(ByteBuffer _bb)
		{
			return ITalkItemStylePhoneSendError.GetRootAsITalkItemStylePhoneSendError(_bb, default(ITalkItemStylePhoneSendError));
		}

		// Token: 0x06035001 RID: 217089 RVA: 0x0072E884 File Offset: 0x0072CA84
		public static ITalkItemStylePhoneSendError GetRootAsITalkItemStylePhoneSendError(ByteBuffer _bb, ITalkItemStylePhoneSendError obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06035002 RID: 217090 RVA: 0x0072E8A1 File Offset: 0x0072CAA1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06035003 RID: 217091 RVA: 0x0072E8B0 File Offset: 0x0072CAB0
		public ITalkItemStylePhoneSendError __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700DDC5 RID: 56773
		// (get) Token: 0x06035004 RID: 217092 RVA: 0x0072E8C0 File Offset: 0x0072CAC0
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

		// Token: 0x06035005 RID: 217093 RVA: 0x0072E8FC File Offset: 0x0072CAFC
		public static Offset<ITalkItemStylePhoneSendError> CreateITalkItemStylePhoneSendError(FlatBufferBuilder builder, ETalkItemStyle Type = ETalkItemStyle.InnerVoice)
		{
			builder.StartTable(1);
			ITalkItemStylePhoneSendError.AddType(builder, Type);
			return ITalkItemStylePhoneSendError.EndITalkItemStylePhoneSendError(builder);
		}

		// Token: 0x06035006 RID: 217094 RVA: 0x0072E912 File Offset: 0x0072CB12
		public static void StartITalkItemStylePhoneSendError(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06035007 RID: 217095 RVA: 0x0072E91B File Offset: 0x0072CB1B
		public static void AddType(FlatBufferBuilder builder, ETalkItemStyle type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06035008 RID: 217096 RVA: 0x0072E926 File Offset: 0x0072CB26
		public static Offset<ITalkItemStylePhoneSendError> EndITalkItemStylePhoneSendError(FlatBufferBuilder builder)
		{
			return new Offset<ITalkItemStylePhoneSendError>(builder.EndTable());
		}

		// Token: 0x06035009 RID: 217097 RVA: 0x0072E934 File Offset: 0x0072CB34
		public ITalkItemStylePhoneSendErrorT UnPack()
		{
			ITalkItemStylePhoneSendErrorT talkItemStylePhoneSendErrorT = new ITalkItemStylePhoneSendErrorT();
			this.UnPackTo(talkItemStylePhoneSendErrorT);
			return talkItemStylePhoneSendErrorT;
		}

		// Token: 0x0603500A RID: 217098 RVA: 0x0072E94F File Offset: 0x0072CB4F
		public void UnPackTo(ITalkItemStylePhoneSendErrorT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0603500B RID: 217099 RVA: 0x0072E960 File Offset: 0x0072CB60
		public static Offset<ITalkItemStylePhoneSendError> Pack(FlatBufferBuilder builder, ITalkItemStylePhoneSendErrorT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITalkItemStylePhoneSendError>);
			}
			return ITalkItemStylePhoneSendError.CreateITalkItemStylePhoneSendError(builder, _o.Type);
		}

		// Token: 0x04011FE0 RID: 73696
		private Table __p;
	}
}
