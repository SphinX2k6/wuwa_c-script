using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006F75 RID: 28533
	public struct ISendPhoneMessage : IFlatbufferObject
	{
		// Token: 0x1700D3F3 RID: 54259
		// (get) Token: 0x0603268B RID: 206475 RVA: 0x006CDF81 File Offset: 0x006CC181
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603268C RID: 206476 RVA: 0x006CDF8E File Offset: 0x006CC18E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603268D RID: 206477 RVA: 0x006CDF98 File Offset: 0x006CC198
		public static ISendPhoneMessage GetRootAsISendPhoneMessage(ByteBuffer _bb)
		{
			return ISendPhoneMessage.GetRootAsISendPhoneMessage(_bb, default(ISendPhoneMessage));
		}

		// Token: 0x0603268E RID: 206478 RVA: 0x006CDFB4 File Offset: 0x006CC1B4
		public static ISendPhoneMessage GetRootAsISendPhoneMessage(ByteBuffer _bb, ISendPhoneMessage obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603268F RID: 206479 RVA: 0x006CDFD1 File Offset: 0x006CC1D1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06032690 RID: 206480 RVA: 0x006CDFE0 File Offset: 0x006CC1E0
		public ISendPhoneMessage __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D3F4 RID: 54260
		// (get) Token: 0x06032691 RID: 206481 RVA: 0x006CDFF0 File Offset: 0x006CC1F0
		public EPhoneSystemInteractType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EPhoneSystemInteractType.SendPhoneMessage;
				}
				return (EPhoneSystemInteractType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700D3F5 RID: 54261
		// (get) Token: 0x06032692 RID: 206482 RVA: 0x006CE02C File Offset: 0x006CC22C
		public IPhoneRecordActionConfig? PhoneRecordActionConfig
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IPhoneRecordActionConfig?(default(IPhoneRecordActionConfig).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x06032693 RID: 206483 RVA: 0x006CE089 File Offset: 0x006CC289
		public static Offset<ISendPhoneMessage> CreateISendPhoneMessage(FlatBufferBuilder builder, EPhoneSystemInteractType Type = EPhoneSystemInteractType.SendPhoneMessage, Offset<IPhoneRecordActionConfig> PhoneRecordActionConfigOffset = default(Offset<IPhoneRecordActionConfig>))
		{
			builder.StartTable(2);
			ISendPhoneMessage.AddPhoneRecordActionConfig(builder, PhoneRecordActionConfigOffset);
			ISendPhoneMessage.AddType(builder, Type);
			return ISendPhoneMessage.EndISendPhoneMessage(builder);
		}

		// Token: 0x06032694 RID: 206484 RVA: 0x006CE0A6 File Offset: 0x006CC2A6
		public static void StartISendPhoneMessage(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06032695 RID: 206485 RVA: 0x006CE0AF File Offset: 0x006CC2AF
		public static void AddType(FlatBufferBuilder builder, EPhoneSystemInteractType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06032696 RID: 206486 RVA: 0x006CE0BA File Offset: 0x006CC2BA
		public static void AddPhoneRecordActionConfig(FlatBufferBuilder builder, Offset<IPhoneRecordActionConfig> phoneRecordActionConfigOffset)
		{
			builder.AddOffset(1, phoneRecordActionConfigOffset.Value, 0);
		}

		// Token: 0x06032697 RID: 206487 RVA: 0x006CE0CA File Offset: 0x006CC2CA
		public static Offset<ISendPhoneMessage> EndISendPhoneMessage(FlatBufferBuilder builder)
		{
			return new Offset<ISendPhoneMessage>(builder.EndTable());
		}

		// Token: 0x06032698 RID: 206488 RVA: 0x006CE0D8 File Offset: 0x006CC2D8
		public ISendPhoneMessageT UnPack()
		{
			ISendPhoneMessageT sendPhoneMessageT = new ISendPhoneMessageT();
			this.UnPackTo(sendPhoneMessageT);
			return sendPhoneMessageT;
		}

		// Token: 0x06032699 RID: 206489 RVA: 0x006CE0F4 File Offset: 0x006CC2F4
		public void UnPackTo(ISendPhoneMessageT _o)
		{
			_o.Type = this.Type;
			_o.PhoneRecordActionConfig = ((this.PhoneRecordActionConfig != null) ? this.PhoneRecordActionConfig.Value.UnPack() : null);
		}

		// Token: 0x0603269A RID: 206490 RVA: 0x006CE13C File Offset: 0x006CC33C
		public static Offset<ISendPhoneMessage> Pack(FlatBufferBuilder builder, ISendPhoneMessageT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISendPhoneMessage>);
			}
			Offset<IPhoneRecordActionConfig> phoneRecordActionConfigOffset = (_o.PhoneRecordActionConfig == null) ? default(Offset<IPhoneRecordActionConfig>) : IPhoneRecordActionConfig.Pack(builder, _o.PhoneRecordActionConfig);
			return ISendPhoneMessage.CreateISendPhoneMessage(builder, _o.Type, phoneRecordActionConfigOffset);
		}

		// Token: 0x04011972 RID: 72050
		private Table __p;
	}
}
