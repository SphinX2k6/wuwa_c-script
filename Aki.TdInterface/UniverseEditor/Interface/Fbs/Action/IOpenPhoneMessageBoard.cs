using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200737C RID: 29564
	public struct IOpenPhoneMessageBoard : IFlatbufferObject
	{
		// Token: 0x1700D8E8 RID: 55528
		// (get) Token: 0x060339E5 RID: 211429 RVA: 0x006F55C6 File Offset: 0x006F37C6
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060339E6 RID: 211430 RVA: 0x006F55D3 File Offset: 0x006F37D3
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060339E7 RID: 211431 RVA: 0x006F55DC File Offset: 0x006F37DC
		public static IOpenPhoneMessageBoard GetRootAsIOpenPhoneMessageBoard(ByteBuffer _bb)
		{
			return IOpenPhoneMessageBoard.GetRootAsIOpenPhoneMessageBoard(_bb, default(IOpenPhoneMessageBoard));
		}

		// Token: 0x060339E8 RID: 211432 RVA: 0x006F55F8 File Offset: 0x006F37F8
		public static IOpenPhoneMessageBoard GetRootAsIOpenPhoneMessageBoard(ByteBuffer _bb, IOpenPhoneMessageBoard obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060339E9 RID: 211433 RVA: 0x006F5615 File Offset: 0x006F3815
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060339EA RID: 211434 RVA: 0x006F5624 File Offset: 0x006F3824
		public IOpenPhoneMessageBoard __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D8E9 RID: 55529
		// (get) Token: 0x060339EB RID: 211435 RVA: 0x006F5634 File Offset: 0x006F3834
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

		// Token: 0x1700D8EA RID: 55530
		// (get) Token: 0x060339EC RID: 211436 RVA: 0x006F5670 File Offset: 0x006F3870
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

		// Token: 0x060339ED RID: 211437 RVA: 0x006F56CD File Offset: 0x006F38CD
		public static Offset<IOpenPhoneMessageBoard> CreateIOpenPhoneMessageBoard(FlatBufferBuilder builder, EPhoneSystemInteractType Type = EPhoneSystemInteractType.SendPhoneMessage, Offset<IMessageBoard> PhoneBoardTypeOffset = default(Offset<IMessageBoard>))
		{
			builder.StartTable(2);
			IOpenPhoneMessageBoard.AddPhoneBoardType(builder, PhoneBoardTypeOffset);
			IOpenPhoneMessageBoard.AddType(builder, Type);
			return IOpenPhoneMessageBoard.EndIOpenPhoneMessageBoard(builder);
		}

		// Token: 0x060339EE RID: 211438 RVA: 0x006F56EA File Offset: 0x006F38EA
		public static void StartIOpenPhoneMessageBoard(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060339EF RID: 211439 RVA: 0x006F56F3 File Offset: 0x006F38F3
		public static void AddType(FlatBufferBuilder builder, EPhoneSystemInteractType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060339F0 RID: 211440 RVA: 0x006F56FE File Offset: 0x006F38FE
		public static void AddPhoneBoardType(FlatBufferBuilder builder, Offset<IMessageBoard> phoneBoardTypeOffset)
		{
			builder.AddOffset(1, phoneBoardTypeOffset.Value, 0);
		}

		// Token: 0x060339F1 RID: 211441 RVA: 0x006F570E File Offset: 0x006F390E
		public static Offset<IOpenPhoneMessageBoard> EndIOpenPhoneMessageBoard(FlatBufferBuilder builder)
		{
			return new Offset<IOpenPhoneMessageBoard>(builder.EndTable());
		}

		// Token: 0x060339F2 RID: 211442 RVA: 0x006F571C File Offset: 0x006F391C
		public IOpenPhoneMessageBoardT UnPack()
		{
			IOpenPhoneMessageBoardT openPhoneMessageBoardT = new IOpenPhoneMessageBoardT();
			this.UnPackTo(openPhoneMessageBoardT);
			return openPhoneMessageBoardT;
		}

		// Token: 0x060339F3 RID: 211443 RVA: 0x006F5738 File Offset: 0x006F3938
		public void UnPackTo(IOpenPhoneMessageBoardT _o)
		{
			_o.Type = this.Type;
			_o.PhoneBoardType = ((this.PhoneBoardType != null) ? this.PhoneBoardType.Value.UnPack() : null);
		}

		// Token: 0x060339F4 RID: 211444 RVA: 0x006F5780 File Offset: 0x006F3980
		public static Offset<IOpenPhoneMessageBoard> Pack(FlatBufferBuilder builder, IOpenPhoneMessageBoardT _o)
		{
			if (_o == null)
			{
				return default(Offset<IOpenPhoneMessageBoard>);
			}
			Offset<IMessageBoard> phoneBoardTypeOffset = (_o.PhoneBoardType == null) ? default(Offset<IMessageBoard>) : IMessageBoard.Pack(builder, _o.PhoneBoardType);
			return IOpenPhoneMessageBoard.CreateIOpenPhoneMessageBoard(builder, _o.Type, phoneBoardTypeOffset);
		}

		// Token: 0x04012471 RID: 74865
		private Table __p;
	}
}
