using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006AA0 RID: 27296
	public struct IMessageBoard : IFlatbufferObject
	{
		// Token: 0x1700CA95 RID: 51861
		// (get) Token: 0x0602FD4E RID: 195918 RVA: 0x00681E11 File Offset: 0x00680011
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602FD4F RID: 195919 RVA: 0x00681E1E File Offset: 0x0068001E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602FD50 RID: 195920 RVA: 0x00681E28 File Offset: 0x00680028
		public static IMessageBoard GetRootAsIMessageBoard(ByteBuffer _bb)
		{
			return IMessageBoard.GetRootAsIMessageBoard(_bb, default(IMessageBoard));
		}

		// Token: 0x0602FD51 RID: 195921 RVA: 0x00681E44 File Offset: 0x00680044
		public static IMessageBoard GetRootAsIMessageBoard(ByteBuffer _bb, IMessageBoard obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602FD52 RID: 195922 RVA: 0x00681E61 File Offset: 0x00680061
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602FD53 RID: 195923 RVA: 0x00681E70 File Offset: 0x00680070
		public IMessageBoard __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CA96 RID: 51862
		// (get) Token: 0x0602FD54 RID: 195924 RVA: 0x00681E80 File Offset: 0x00680080
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

		// Token: 0x1700CA97 RID: 51863
		// (get) Token: 0x0602FD55 RID: 195925 RVA: 0x00681EBC File Offset: 0x006800BC
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

		// Token: 0x0602FD56 RID: 195926 RVA: 0x00681F19 File Offset: 0x00680119
		public static Offset<IMessageBoard> CreateIMessageBoard(FlatBufferBuilder builder, EPhoneBoardType Type = EPhoneBoardType.MessageBoard, Offset<IPhoneMessageBoardConfig> MessageBoardConfigOffset = default(Offset<IPhoneMessageBoardConfig>))
		{
			builder.StartTable(2);
			IMessageBoard.AddMessageBoardConfig(builder, MessageBoardConfigOffset);
			IMessageBoard.AddType(builder, Type);
			return IMessageBoard.EndIMessageBoard(builder);
		}

		// Token: 0x0602FD57 RID: 195927 RVA: 0x00681F36 File Offset: 0x00680136
		public static void StartIMessageBoard(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602FD58 RID: 195928 RVA: 0x00681F3F File Offset: 0x0068013F
		public static void AddType(FlatBufferBuilder builder, EPhoneBoardType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602FD59 RID: 195929 RVA: 0x00681F4A File Offset: 0x0068014A
		public static void AddMessageBoardConfig(FlatBufferBuilder builder, Offset<IPhoneMessageBoardConfig> messageBoardConfigOffset)
		{
			builder.AddOffset(1, messageBoardConfigOffset.Value, 0);
		}

		// Token: 0x0602FD5A RID: 195930 RVA: 0x00681F5A File Offset: 0x0068015A
		public static Offset<IMessageBoard> EndIMessageBoard(FlatBufferBuilder builder)
		{
			return new Offset<IMessageBoard>(builder.EndTable());
		}

		// Token: 0x0602FD5B RID: 195931 RVA: 0x00681F68 File Offset: 0x00680168
		public IMessageBoardT UnPack()
		{
			IMessageBoardT messageBoardT = new IMessageBoardT();
			this.UnPackTo(messageBoardT);
			return messageBoardT;
		}

		// Token: 0x0602FD5C RID: 195932 RVA: 0x00681F84 File Offset: 0x00680184
		public void UnPackTo(IMessageBoardT _o)
		{
			_o.Type = this.Type;
			_o.MessageBoardConfig = ((this.MessageBoardConfig != null) ? this.MessageBoardConfig.Value.UnPack() : null);
		}

		// Token: 0x0602FD5D RID: 195933 RVA: 0x00681FCC File Offset: 0x006801CC
		public static Offset<IMessageBoard> Pack(FlatBufferBuilder builder, IMessageBoardT _o)
		{
			if (_o == null)
			{
				return default(Offset<IMessageBoard>);
			}
			Offset<IPhoneMessageBoardConfig> messageBoardConfigOffset = (_o.MessageBoardConfig == null) ? default(Offset<IPhoneMessageBoardConfig>) : IPhoneMessageBoardConfig.Pack(builder, _o.MessageBoardConfig);
			return IMessageBoard.CreateIMessageBoard(builder, _o.Type, messageBoardConfigOffset);
		}

		// Token: 0x040112DD RID: 70365
		private Table __p;
	}
}
