using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006C15 RID: 27669
	public struct IOpenPhoneMessageBoard : IFlatbufferObject
	{
		// Token: 0x1700CDCD RID: 52685
		// (get) Token: 0x06030A91 RID: 199313 RVA: 0x0069B2CA File Offset: 0x006994CA
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06030A92 RID: 199314 RVA: 0x0069B2D7 File Offset: 0x006994D7
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06030A93 RID: 199315 RVA: 0x0069B2E0 File Offset: 0x006994E0
		public static IOpenPhoneMessageBoard GetRootAsIOpenPhoneMessageBoard(ByteBuffer _bb)
		{
			return IOpenPhoneMessageBoard.GetRootAsIOpenPhoneMessageBoard(_bb, default(IOpenPhoneMessageBoard));
		}

		// Token: 0x06030A94 RID: 199316 RVA: 0x0069B2FC File Offset: 0x006994FC
		public static IOpenPhoneMessageBoard GetRootAsIOpenPhoneMessageBoard(ByteBuffer _bb, IOpenPhoneMessageBoard obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06030A95 RID: 199317 RVA: 0x0069B319 File Offset: 0x00699519
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06030A96 RID: 199318 RVA: 0x0069B328 File Offset: 0x00699528
		public IOpenPhoneMessageBoard __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CDCE RID: 52686
		// (get) Token: 0x06030A97 RID: 199319 RVA: 0x0069B338 File Offset: 0x00699538
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

		// Token: 0x1700CDCF RID: 52687
		// (get) Token: 0x06030A98 RID: 199320 RVA: 0x0069B374 File Offset: 0x00699574
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

		// Token: 0x06030A99 RID: 199321 RVA: 0x0069B3D1 File Offset: 0x006995D1
		public static Offset<IOpenPhoneMessageBoard> CreateIOpenPhoneMessageBoard(FlatBufferBuilder builder, EPhoneSystemInteractType Type = EPhoneSystemInteractType.SendPhoneMessage, Offset<IMessageBoard> PhoneBoardTypeOffset = default(Offset<IMessageBoard>))
		{
			builder.StartTable(2);
			IOpenPhoneMessageBoard.AddPhoneBoardType(builder, PhoneBoardTypeOffset);
			IOpenPhoneMessageBoard.AddType(builder, Type);
			return IOpenPhoneMessageBoard.EndIOpenPhoneMessageBoard(builder);
		}

		// Token: 0x06030A9A RID: 199322 RVA: 0x0069B3EE File Offset: 0x006995EE
		public static void StartIOpenPhoneMessageBoard(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06030A9B RID: 199323 RVA: 0x0069B3F7 File Offset: 0x006995F7
		public static void AddType(FlatBufferBuilder builder, EPhoneSystemInteractType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06030A9C RID: 199324 RVA: 0x0069B402 File Offset: 0x00699602
		public static void AddPhoneBoardType(FlatBufferBuilder builder, Offset<IMessageBoard> phoneBoardTypeOffset)
		{
			builder.AddOffset(1, phoneBoardTypeOffset.Value, 0);
		}

		// Token: 0x06030A9D RID: 199325 RVA: 0x0069B412 File Offset: 0x00699612
		public static Offset<IOpenPhoneMessageBoard> EndIOpenPhoneMessageBoard(FlatBufferBuilder builder)
		{
			return new Offset<IOpenPhoneMessageBoard>(builder.EndTable());
		}

		// Token: 0x06030A9E RID: 199326 RVA: 0x0069B420 File Offset: 0x00699620
		public IOpenPhoneMessageBoardT UnPack()
		{
			IOpenPhoneMessageBoardT openPhoneMessageBoardT = new IOpenPhoneMessageBoardT();
			this.UnPackTo(openPhoneMessageBoardT);
			return openPhoneMessageBoardT;
		}

		// Token: 0x06030A9F RID: 199327 RVA: 0x0069B43C File Offset: 0x0069963C
		public void UnPackTo(IOpenPhoneMessageBoardT _o)
		{
			_o.Type = this.Type;
			_o.PhoneBoardType = ((this.PhoneBoardType != null) ? this.PhoneBoardType.Value.UnPack() : null);
		}

		// Token: 0x06030AA0 RID: 199328 RVA: 0x0069B484 File Offset: 0x00699684
		public static Offset<IOpenPhoneMessageBoard> Pack(FlatBufferBuilder builder, IOpenPhoneMessageBoardT _o)
		{
			if (_o == null)
			{
				return default(Offset<IOpenPhoneMessageBoard>);
			}
			Offset<IMessageBoard> phoneBoardTypeOffset = (_o.PhoneBoardType == null) ? default(Offset<IMessageBoard>) : IMessageBoard.Pack(builder, _o.PhoneBoardType);
			return IOpenPhoneMessageBoard.CreateIOpenPhoneMessageBoard(builder, _o.Type, phoneBoardTypeOffset);
		}

		// Token: 0x0401151A RID: 70938
		private Table __p;
	}
}
