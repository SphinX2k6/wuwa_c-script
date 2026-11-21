using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007B0F RID: 31503
	public struct ITalkOptionPhoneMessageEmoji : IFlatbufferObject
	{
		// Token: 0x1700EBFF RID: 60415
		// (get) Token: 0x06038B9B RID: 232347 RVA: 0x007AC53E File Offset: 0x007AA73E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06038B9C RID: 232348 RVA: 0x007AC54B File Offset: 0x007AA74B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06038B9D RID: 232349 RVA: 0x007AC554 File Offset: 0x007AA754
		public static ITalkOptionPhoneMessageEmoji GetRootAsITalkOptionPhoneMessageEmoji(ByteBuffer _bb)
		{
			return ITalkOptionPhoneMessageEmoji.GetRootAsITalkOptionPhoneMessageEmoji(_bb, default(ITalkOptionPhoneMessageEmoji));
		}

		// Token: 0x06038B9E RID: 232350 RVA: 0x007AC570 File Offset: 0x007AA770
		public static ITalkOptionPhoneMessageEmoji GetRootAsITalkOptionPhoneMessageEmoji(ByteBuffer _bb, ITalkOptionPhoneMessageEmoji obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06038B9F RID: 232351 RVA: 0x007AC58D File Offset: 0x007AA78D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06038BA0 RID: 232352 RVA: 0x007AC59C File Offset: 0x007AA79C
		public ITalkOptionPhoneMessageEmoji __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700EC00 RID: 60416
		// (get) Token: 0x06038BA1 RID: 232353 RVA: 0x007AC5AC File Offset: 0x007AA7AC
		public ETalkOptionParamType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ETalkOptionParamType.QteSucceed;
				}
				return (ETalkOptionParamType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700EC01 RID: 60417
		// (get) Token: 0x06038BA2 RID: 232354 RVA: 0x007AC5E8 File Offset: 0x007AA7E8
		public int EmojiId
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700EC02 RID: 60418
		// (get) Token: 0x06038BA3 RID: 232355 RVA: 0x007AC624 File Offset: 0x007AA824
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06038BA4 RID: 232356 RVA: 0x007AC660 File Offset: 0x007AA860
		public static Offset<ITalkOptionPhoneMessageEmoji> CreateITalkOptionPhoneMessageEmoji(FlatBufferBuilder builder, ETalkOptionParamType Type = ETalkOptionParamType.QteSucceed, int EmojiId = 0, byte NullMask = 0)
		{
			builder.StartTable(3);
			ITalkOptionPhoneMessageEmoji.AddEmojiId(builder, EmojiId);
			ITalkOptionPhoneMessageEmoji.AddNullMask(builder, NullMask);
			ITalkOptionPhoneMessageEmoji.AddType(builder, Type);
			return ITalkOptionPhoneMessageEmoji.EndITalkOptionPhoneMessageEmoji(builder);
		}

		// Token: 0x06038BA5 RID: 232357 RVA: 0x007AC684 File Offset: 0x007AA884
		public static void StartITalkOptionPhoneMessageEmoji(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06038BA6 RID: 232358 RVA: 0x007AC68D File Offset: 0x007AA88D
		public static void AddType(FlatBufferBuilder builder, ETalkOptionParamType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06038BA7 RID: 232359 RVA: 0x007AC698 File Offset: 0x007AA898
		public static void AddEmojiId(FlatBufferBuilder builder, int emojiId)
		{
			builder.AddInt(1, emojiId, 0);
		}

		// Token: 0x06038BA8 RID: 232360 RVA: 0x007AC6A3 File Offset: 0x007AA8A3
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x06038BA9 RID: 232361 RVA: 0x007AC6AE File Offset: 0x007AA8AE
		public static Offset<ITalkOptionPhoneMessageEmoji> EndITalkOptionPhoneMessageEmoji(FlatBufferBuilder builder)
		{
			return new Offset<ITalkOptionPhoneMessageEmoji>(builder.EndTable());
		}

		// Token: 0x06038BAA RID: 232362 RVA: 0x007AC6BC File Offset: 0x007AA8BC
		public ITalkOptionPhoneMessageEmojiT UnPack()
		{
			ITalkOptionPhoneMessageEmojiT talkOptionPhoneMessageEmojiT = new ITalkOptionPhoneMessageEmojiT();
			this.UnPackTo(talkOptionPhoneMessageEmojiT);
			return talkOptionPhoneMessageEmojiT;
		}

		// Token: 0x06038BAB RID: 232363 RVA: 0x007AC6D7 File Offset: 0x007AA8D7
		public void UnPackTo(ITalkOptionPhoneMessageEmojiT _o)
		{
			_o.Type = this.Type;
			_o.EmojiId = this.EmojiId;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06038BAC RID: 232364 RVA: 0x007AC700 File Offset: 0x007AA900
		public static Offset<ITalkOptionPhoneMessageEmoji> Pack(FlatBufferBuilder builder, ITalkOptionPhoneMessageEmojiT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITalkOptionPhoneMessageEmoji>);
			}
			return ITalkOptionPhoneMessageEmoji.CreateITalkOptionPhoneMessageEmoji(builder, _o.Type, _o.EmojiId, _o.NullMask);
		}

		// Token: 0x04013132 RID: 78130
		private Table __p;
	}
}
