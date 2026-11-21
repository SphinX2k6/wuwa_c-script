using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020071C5 RID: 29125
	public struct IMessageBoard : IFlatbufferObject
	{
		// Token: 0x1700D545 RID: 54597
		// (get) Token: 0x06032A8A RID: 207498 RVA: 0x006D80D1 File Offset: 0x006D62D1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06032A8B RID: 207499 RVA: 0x006D80DE File Offset: 0x006D62DE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06032A8C RID: 207500 RVA: 0x006D80E8 File Offset: 0x006D62E8
		public static IMessageBoard GetRootAsIMessageBoard(ByteBuffer _bb)
		{
			return IMessageBoard.GetRootAsIMessageBoard(_bb, default(IMessageBoard));
		}

		// Token: 0x06032A8D RID: 207501 RVA: 0x006D8104 File Offset: 0x006D6304
		public static IMessageBoard GetRootAsIMessageBoard(ByteBuffer _bb, IMessageBoard obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06032A8E RID: 207502 RVA: 0x006D8121 File Offset: 0x006D6321
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06032A8F RID: 207503 RVA: 0x006D8130 File Offset: 0x006D6330
		public IMessageBoard __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D546 RID: 54598
		// (get) Token: 0x06032A90 RID: 207504 RVA: 0x006D8140 File Offset: 0x006D6340
		public EPhoneBoardType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EPhoneBoardType.MessageBoard;
				}
				return (EPhoneBoardType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700D547 RID: 54599
		// (get) Token: 0x06032A91 RID: 207505 RVA: 0x006D817C File Offset: 0x006D637C
		public IPhoneMessageBoardConfig? MessageBoardConfig
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IPhoneMessageBoardConfig?(default(IPhoneMessageBoardConfig).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x06032A92 RID: 207506 RVA: 0x006D81D9 File Offset: 0x006D63D9
		public static Offset<IMessageBoard> CreateIMessageBoard(FlatBufferBuilder builder, EPhoneBoardType Type = EPhoneBoardType.MessageBoard, Offset<IPhoneMessageBoardConfig> MessageBoardConfigOffset = default(Offset<IPhoneMessageBoardConfig>))
		{
			builder.StartTable(2);
			IMessageBoard.AddMessageBoardConfig(builder, MessageBoardConfigOffset);
			IMessageBoard.AddType(builder, Type);
			return IMessageBoard.EndIMessageBoard(builder);
		}

		// Token: 0x06032A93 RID: 207507 RVA: 0x006D81F6 File Offset: 0x006D63F6
		public static void StartIMessageBoard(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06032A94 RID: 207508 RVA: 0x006D81FF File Offset: 0x006D63FF
		public static void AddType(FlatBufferBuilder builder, EPhoneBoardType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06032A95 RID: 207509 RVA: 0x006D820A File Offset: 0x006D640A
		public static void AddMessageBoardConfig(FlatBufferBuilder builder, Offset<IPhoneMessageBoardConfig> messageBoardConfigOffset)
		{
			builder.AddOffset(1, messageBoardConfigOffset.Value, 0);
		}

		// Token: 0x06032A96 RID: 207510 RVA: 0x006D821A File Offset: 0x006D641A
		public static Offset<IMessageBoard> EndIMessageBoard(FlatBufferBuilder builder)
		{
			return new Offset<IMessageBoard>(builder.EndTable());
		}

		// Token: 0x06032A97 RID: 207511 RVA: 0x006D8228 File Offset: 0x006D6428
		public IMessageBoardT UnPack()
		{
			IMessageBoardT messageBoardT = new IMessageBoardT();
			this.UnPackTo(messageBoardT);
			return messageBoardT;
		}

		// Token: 0x06032A98 RID: 207512 RVA: 0x006D8244 File Offset: 0x006D6444
		public void UnPackTo(IMessageBoardT _o)
		{
			_o.Type = this.Type;
			_o.MessageBoardConfig = ((this.MessageBoardConfig != null) ? this.MessageBoardConfig.Value.UnPack() : null);
		}

		// Token: 0x06032A99 RID: 207513 RVA: 0x006D828C File Offset: 0x006D648C
		public static Offset<IMessageBoard> Pack(FlatBufferBuilder builder, IMessageBoardT _o)
		{
			if (_o == null)
			{
				return default(Offset<IMessageBoard>);
			}
			Offset<IPhoneMessageBoardConfig> messageBoardConfigOffset = (_o.MessageBoardConfig == null) ? default(Offset<IPhoneMessageBoardConfig>) : IPhoneMessageBoardConfig.Pack(builder, _o.MessageBoardConfig);
			return IMessageBoard.CreateIMessageBoard(builder, _o.Type, messageBoardConfigOffset);
		}

		// Token: 0x040121D8 RID: 74200
		private Table __p;
	}
}
