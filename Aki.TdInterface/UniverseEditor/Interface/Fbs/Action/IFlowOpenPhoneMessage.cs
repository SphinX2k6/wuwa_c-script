using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200681C RID: 26652
	public struct IFlowOpenPhoneMessage : IFlatbufferObject
	{
		// Token: 0x1700C5F8 RID: 50680
		// (get) Token: 0x0602E750 RID: 190288 RVA: 0x0065738E File Offset: 0x0065558E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602E751 RID: 190289 RVA: 0x0065739B File Offset: 0x0065559B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602E752 RID: 190290 RVA: 0x006573A4 File Offset: 0x006555A4
		public static IFlowOpenPhoneMessage GetRootAsIFlowOpenPhoneMessage(ByteBuffer _bb)
		{
			return IFlowOpenPhoneMessage.GetRootAsIFlowOpenPhoneMessage(_bb, default(IFlowOpenPhoneMessage));
		}

		// Token: 0x0602E753 RID: 190291 RVA: 0x006573C0 File Offset: 0x006555C0
		public static IFlowOpenPhoneMessage GetRootAsIFlowOpenPhoneMessage(ByteBuffer _bb, IFlowOpenPhoneMessage obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602E754 RID: 190292 RVA: 0x006573DD File Offset: 0x006555DD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602E755 RID: 190293 RVA: 0x006573EC File Offset: 0x006555EC
		public IFlowOpenPhoneMessage __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C5F9 RID: 50681
		// (get) Token: 0x0602E756 RID: 190294 RVA: 0x006573FC File Offset: 0x006555FC
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

		// Token: 0x1700C5FA RID: 50682
		// (get) Token: 0x0602E757 RID: 190295 RVA: 0x00657438 File Offset: 0x00655638
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

		// Token: 0x0602E758 RID: 190296 RVA: 0x00657495 File Offset: 0x00655695
		public static Offset<IFlowOpenPhoneMessage> CreateIFlowOpenPhoneMessage(FlatBufferBuilder builder, EPhoneSystemInteractType Type = EPhoneSystemInteractType.SendPhoneMessage, Offset<IMessageBoard> PhoneBoardTypeOffset = default(Offset<IMessageBoard>))
		{
			builder.StartTable(2);
			IFlowOpenPhoneMessage.AddPhoneBoardType(builder, PhoneBoardTypeOffset);
			IFlowOpenPhoneMessage.AddType(builder, Type);
			return IFlowOpenPhoneMessage.EndIFlowOpenPhoneMessage(builder);
		}

		// Token: 0x0602E759 RID: 190297 RVA: 0x006574B2 File Offset: 0x006556B2
		public static void StartIFlowOpenPhoneMessage(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602E75A RID: 190298 RVA: 0x006574BB File Offset: 0x006556BB
		public static void AddType(FlatBufferBuilder builder, EPhoneSystemInteractType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602E75B RID: 190299 RVA: 0x006574C6 File Offset: 0x006556C6
		public static void AddPhoneBoardType(FlatBufferBuilder builder, Offset<IMessageBoard> phoneBoardTypeOffset)
		{
			builder.AddOffset(1, phoneBoardTypeOffset.Value, 0);
		}

		// Token: 0x0602E75C RID: 190300 RVA: 0x006574D6 File Offset: 0x006556D6
		public static Offset<IFlowOpenPhoneMessage> EndIFlowOpenPhoneMessage(FlatBufferBuilder builder)
		{
			return new Offset<IFlowOpenPhoneMessage>(builder.EndTable());
		}

		// Token: 0x0602E75D RID: 190301 RVA: 0x006574E4 File Offset: 0x006556E4
		public IFlowOpenPhoneMessageT UnPack()
		{
			IFlowOpenPhoneMessageT flowOpenPhoneMessageT = new IFlowOpenPhoneMessageT();
			this.UnPackTo(flowOpenPhoneMessageT);
			return flowOpenPhoneMessageT;
		}

		// Token: 0x0602E75E RID: 190302 RVA: 0x00657500 File Offset: 0x00655700
		public void UnPackTo(IFlowOpenPhoneMessageT _o)
		{
			_o.Type = this.Type;
			_o.PhoneBoardType = ((this.PhoneBoardType != null) ? this.PhoneBoardType.Value.UnPack() : null);
		}

		// Token: 0x0602E75F RID: 190303 RVA: 0x00657548 File Offset: 0x00655748
		public static Offset<IFlowOpenPhoneMessage> Pack(FlatBufferBuilder builder, IFlowOpenPhoneMessageT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFlowOpenPhoneMessage>);
			}
			Offset<IMessageBoard> phoneBoardTypeOffset = (_o.PhoneBoardType == null) ? default(Offset<IMessageBoard>) : IMessageBoard.Pack(builder, _o.PhoneBoardType);
			return IFlowOpenPhoneMessage.CreateIFlowOpenPhoneMessage(builder, _o.Type, phoneBoardTypeOffset);
		}

		// Token: 0x04010F59 RID: 69465
		private Table __p;
	}
}
