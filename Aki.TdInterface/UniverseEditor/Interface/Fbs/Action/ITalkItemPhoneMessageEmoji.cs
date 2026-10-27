using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020072F2 RID: 29426
	public struct ITalkItemPhoneMessageEmoji : IFlatbufferObject
	{
		// Token: 0x1700DD65 RID: 56677
		// (get) Token: 0x06034E95 RID: 216725 RVA: 0x0072AA14 File Offset: 0x00728C14
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06034E96 RID: 216726 RVA: 0x0072AA21 File Offset: 0x00728C21
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06034E97 RID: 216727 RVA: 0x0072AA28 File Offset: 0x00728C28
		public static ITalkItemPhoneMessageEmoji GetRootAsITalkItemPhoneMessageEmoji(ByteBuffer _bb)
		{
			return ITalkItemPhoneMessageEmoji.GetRootAsITalkItemPhoneMessageEmoji(_bb, default(ITalkItemPhoneMessageEmoji));
		}

		// Token: 0x06034E98 RID: 216728 RVA: 0x0072AA44 File Offset: 0x00728C44
		public static ITalkItemPhoneMessageEmoji GetRootAsITalkItemPhoneMessageEmoji(ByteBuffer _bb, ITalkItemPhoneMessageEmoji obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06034E99 RID: 216729 RVA: 0x0072AA61 File Offset: 0x00728C61
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06034E9A RID: 216730 RVA: 0x0072AA70 File Offset: 0x00728C70
		public ITalkItemPhoneMessageEmoji __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700DD66 RID: 56678
		// (get) Token: 0x06034E9B RID: 216731 RVA: 0x0072AA80 File Offset: 0x00728C80
		public EPhoneMessageType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EPhoneMessageType.Voice;
				}
				return (EPhoneMessageType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700DD67 RID: 56679
		// (get) Token: 0x06034E9C RID: 216732 RVA: 0x0072AABC File Offset: 0x00728CBC
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

		// Token: 0x06034E9D RID: 216733 RVA: 0x0072AAF8 File Offset: 0x00728CF8
		public static Offset<ITalkItemPhoneMessageEmoji> CreateITalkItemPhoneMessageEmoji(FlatBufferBuilder builder, EPhoneMessageType Type = EPhoneMessageType.Voice, int EmojiId = 0)
		{
			builder.StartTable(2);
			ITalkItemPhoneMessageEmoji.AddEmojiId(builder, EmojiId);
			ITalkItemPhoneMessageEmoji.AddType(builder, Type);
			return ITalkItemPhoneMessageEmoji.EndITalkItemPhoneMessageEmoji(builder);
		}

		// Token: 0x06034E9E RID: 216734 RVA: 0x0072AB15 File Offset: 0x00728D15
		public static void StartITalkItemPhoneMessageEmoji(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06034E9F RID: 216735 RVA: 0x0072AB1E File Offset: 0x00728D1E
		public static void AddType(FlatBufferBuilder builder, EPhoneMessageType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06034EA0 RID: 216736 RVA: 0x0072AB29 File Offset: 0x00728D29
		public static void AddEmojiId(FlatBufferBuilder builder, int emojiId)
		{
			builder.AddInt(1, emojiId, 0);
		}

		// Token: 0x06034EA1 RID: 216737 RVA: 0x0072AB34 File Offset: 0x00728D34
		public static Offset<ITalkItemPhoneMessageEmoji> EndITalkItemPhoneMessageEmoji(FlatBufferBuilder builder)
		{
			return new Offset<ITalkItemPhoneMessageEmoji>(builder.EndTable());
		}

		// Token: 0x06034EA2 RID: 216738 RVA: 0x0072AB44 File Offset: 0x00728D44
		public ITalkItemPhoneMessageEmojiT UnPack()
		{
			ITalkItemPhoneMessageEmojiT talkItemPhoneMessageEmojiT = new ITalkItemPhoneMessageEmojiT();
			this.UnPackTo(talkItemPhoneMessageEmojiT);
			return talkItemPhoneMessageEmojiT;
		}

		// Token: 0x06034EA3 RID: 216739 RVA: 0x0072AB5F File Offset: 0x00728D5F
		public void UnPackTo(ITalkItemPhoneMessageEmojiT _o)
		{
			_o.Type = this.Type;
			_o.EmojiId = this.EmojiId;
		}

		// Token: 0x06034EA4 RID: 216740 RVA: 0x0072AB7C File Offset: 0x00728D7C
		public static Offset<ITalkItemPhoneMessageEmoji> Pack(FlatBufferBuilder builder, ITalkItemPhoneMessageEmojiT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITalkItemPhoneMessageEmoji>);
			}
			return ITalkItemPhoneMessageEmoji.CreateITalkItemPhoneMessageEmoji(builder, _o.Type, _o.EmojiId);
		}

		// Token: 0x04011FAE RID: 73646
		private Table __p;
	}
}
