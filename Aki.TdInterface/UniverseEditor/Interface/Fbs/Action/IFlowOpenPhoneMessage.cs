using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006E9C RID: 28316
	public struct IFlowOpenPhoneMessage : IFlatbufferObject
	{
		// Token: 0x1700CFB2 RID: 53170
		// (get) Token: 0x06030FAC RID: 200620 RVA: 0x006A4EC8 File Offset: 0x006A30C8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06030FAD RID: 200621 RVA: 0x006A4ED5 File Offset: 0x006A30D5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06030FAE RID: 200622 RVA: 0x006A4EDC File Offset: 0x006A30DC
		public static IFlowOpenPhoneMessage GetRootAsIFlowOpenPhoneMessage(ByteBuffer _bb)
		{
			return IFlowOpenPhoneMessage.GetRootAsIFlowOpenPhoneMessage(_bb, default(IFlowOpenPhoneMessage));
		}

		// Token: 0x06030FAF RID: 200623 RVA: 0x006A4EF8 File Offset: 0x006A30F8
		public static IFlowOpenPhoneMessage GetRootAsIFlowOpenPhoneMessage(ByteBuffer _bb, IFlowOpenPhoneMessage obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06030FB0 RID: 200624 RVA: 0x006A4F15 File Offset: 0x006A3115
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06030FB1 RID: 200625 RVA: 0x006A4F24 File Offset: 0x006A3124
		public IFlowOpenPhoneMessage __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CFB3 RID: 53171
		// (get) Token: 0x06030FB2 RID: 200626 RVA: 0x006A4F34 File Offset: 0x006A3134
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

		// Token: 0x1700CFB4 RID: 53172
		// (get) Token: 0x06030FB3 RID: 200627 RVA: 0x006A4F70 File Offset: 0x006A3170
		public IMessageBoard? PhoneBoardType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IMessageBoard?(default(IMessageBoard).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x06030FB4 RID: 200628 RVA: 0x006A4FCD File Offset: 0x006A31CD
		public static Offset<IFlowOpenPhoneMessage> CreateIFlowOpenPhoneMessage(FlatBufferBuilder builder, EPhoneSystemInteractType Type = EPhoneSystemInteractType.SendPhoneMessage, Offset<IMessageBoard> PhoneBoardTypeOffset = default(Offset<IMessageBoard>))
		{
			builder.StartTable(2);
			IFlowOpenPhoneMessage.AddPhoneBoardType(builder, PhoneBoardTypeOffset);
			IFlowOpenPhoneMessage.AddType(builder, Type);
			return IFlowOpenPhoneMessage.EndIFlowOpenPhoneMessage(builder);
		}

		// Token: 0x06030FB5 RID: 200629 RVA: 0x006A4FEA File Offset: 0x006A31EA
		public static void StartIFlowOpenPhoneMessage(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06030FB6 RID: 200630 RVA: 0x006A4FF3 File Offset: 0x006A31F3
		public static void AddType(FlatBufferBuilder builder, EPhoneSystemInteractType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06030FB7 RID: 200631 RVA: 0x006A4FFE File Offset: 0x006A31FE
		public static void AddPhoneBoardType(FlatBufferBuilder builder, Offset<IMessageBoard> phoneBoardTypeOffset)
		{
			builder.AddOffset(1, phoneBoardTypeOffset.Value, 0);
		}

		// Token: 0x06030FB8 RID: 200632 RVA: 0x006A500E File Offset: 0x006A320E
		public static Offset<IFlowOpenPhoneMessage> EndIFlowOpenPhoneMessage(FlatBufferBuilder builder)
		{
			return new Offset<IFlowOpenPhoneMessage>(builder.EndTable());
		}

		// Token: 0x06030FB9 RID: 200633 RVA: 0x006A501C File Offset: 0x006A321C
		public IFlowOpenPhoneMessageT UnPack()
		{
			IFlowOpenPhoneMessageT flowOpenPhoneMessageT = new IFlowOpenPhoneMessageT();
			this.UnPackTo(flowOpenPhoneMessageT);
			return flowOpenPhoneMessageT;
		}

		// Token: 0x06030FBA RID: 200634 RVA: 0x006A5038 File Offset: 0x006A3238
		public void UnPackTo(IFlowOpenPhoneMessageT _o)
		{
			_o.Type = this.Type;
			_o.PhoneBoardType = ((this.PhoneBoardType != null) ? this.PhoneBoardType.Value.UnPack() : null);
		}

		// Token: 0x06030FBB RID: 200635 RVA: 0x006A5080 File Offset: 0x006A3280
		public static Offset<IFlowOpenPhoneMessage> Pack(FlatBufferBuilder builder, IFlowOpenPhoneMessageT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFlowOpenPhoneMessage>);
			}
			Offset<IMessageBoard> phoneBoardTypeOffset = (_o.PhoneBoardType == null) ? default(Offset<IMessageBoard>) : IMessageBoard.Pack(builder, _o.PhoneBoardType);
			return IFlowOpenPhoneMessage.CreateIFlowOpenPhoneMessage(builder, _o.Type, phoneBoardTypeOffset);
		}

		// Token: 0x04011D8D RID: 73101
		private Table __p;
	}
}
