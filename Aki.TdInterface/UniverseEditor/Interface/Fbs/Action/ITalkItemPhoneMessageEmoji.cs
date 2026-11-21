using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007AC7 RID: 31431
	public struct ITalkItemPhoneMessageEmoji : IFlatbufferObject
	{
		// Token: 0x1700E95E RID: 59742
		// (get) Token: 0x0603819B RID: 229787 RVA: 0x0078BE78 File Offset: 0x0078A078
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603819C RID: 229788 RVA: 0x0078BE85 File Offset: 0x0078A085
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603819D RID: 229789 RVA: 0x0078BE8C File Offset: 0x0078A08C
		public static ITalkItemPhoneMessageEmoji GetRootAsITalkItemPhoneMessageEmoji(ByteBuffer _bb)
		{
			return ITalkItemPhoneMessageEmoji.GetRootAsITalkItemPhoneMessageEmoji(_bb, default(ITalkItemPhoneMessageEmoji));
		}

		// Token: 0x0603819E RID: 229790 RVA: 0x0078BEA8 File Offset: 0x0078A0A8
		public static ITalkItemPhoneMessageEmoji GetRootAsITalkItemPhoneMessageEmoji(ByteBuffer _bb, ITalkItemPhoneMessageEmoji obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603819F RID: 229791 RVA: 0x0078BEC5 File Offset: 0x0078A0C5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060381A0 RID: 229792 RVA: 0x0078BED4 File Offset: 0x0078A0D4
		public ITalkItemPhoneMessageEmoji __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E95F RID: 59743
		// (get) Token: 0x060381A1 RID: 229793 RVA: 0x0078BEE4 File Offset: 0x0078A0E4
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

		// Token: 0x1700E960 RID: 59744
		// (get) Token: 0x060381A2 RID: 229794 RVA: 0x0078BF20 File Offset: 0x0078A120
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

		// Token: 0x060381A3 RID: 229795 RVA: 0x0078BF5C File Offset: 0x0078A15C
		public static Offset<ITalkItemPhoneMessageEmoji> CreateITalkItemPhoneMessageEmoji(FlatBufferBuilder builder, EPhoneMessageType Type = EPhoneMessageType.Voice, int EmojiId = 0)
		{
			builder.StartTable(2);
			ITalkItemPhoneMessageEmoji.AddEmojiId(builder, EmojiId);
			ITalkItemPhoneMessageEmoji.AddType(builder, Type);
			return ITalkItemPhoneMessageEmoji.EndITalkItemPhoneMessageEmoji(builder);
		}

		// Token: 0x060381A4 RID: 229796 RVA: 0x0078BF79 File Offset: 0x0078A179
		public static void StartITalkItemPhoneMessageEmoji(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060381A5 RID: 229797 RVA: 0x0078BF82 File Offset: 0x0078A182
		public static void AddType(FlatBufferBuilder builder, EPhoneMessageType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060381A6 RID: 229798 RVA: 0x0078BF8D File Offset: 0x0078A18D
		public static void AddEmojiId(FlatBufferBuilder builder, int emojiId)
		{
			builder.AddInt(1, emojiId, 0);
		}

		// Token: 0x060381A7 RID: 229799 RVA: 0x0078BF98 File Offset: 0x0078A198
		public static Offset<ITalkItemPhoneMessageEmoji> EndITalkItemPhoneMessageEmoji(FlatBufferBuilder builder)
		{
			return new Offset<ITalkItemPhoneMessageEmoji>(builder.EndTable());
		}

		// Token: 0x060381A8 RID: 229800 RVA: 0x0078BFA8 File Offset: 0x0078A1A8
		public ITalkItemPhoneMessageEmojiT UnPack()
		{
			ITalkItemPhoneMessageEmojiT talkItemPhoneMessageEmojiT = new ITalkItemPhoneMessageEmojiT();
			this.UnPackTo(talkItemPhoneMessageEmojiT);
			return talkItemPhoneMessageEmojiT;
		}

		// Token: 0x060381A9 RID: 229801 RVA: 0x0078BFC3 File Offset: 0x0078A1C3
		public void UnPackTo(ITalkItemPhoneMessageEmojiT _o)
		{
			_o.Type = this.Type;
			_o.EmojiId = this.EmojiId;
		}

		// Token: 0x060381AA RID: 229802 RVA: 0x0078BFE0 File Offset: 0x0078A1E0
		public static Offset<ITalkItemPhoneMessageEmoji> Pack(FlatBufferBuilder builder, ITalkItemPhoneMessageEmojiT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITalkItemPhoneMessageEmoji>);
			}
			return ITalkItemPhoneMessageEmoji.CreateITalkItemPhoneMessageEmoji(builder, _o.Type, _o.EmojiId);
		}

		// Token: 0x04012FB1 RID: 77745
		private Table __p;
	}
}
