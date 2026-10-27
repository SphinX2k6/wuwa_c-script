using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007337 RID: 29495
	public struct ITalkOptionPhoneMessageEmoji : IFlatbufferObject
	{
		// Token: 0x1700E003 RID: 57347
		// (get) Token: 0x06035868 RID: 219240 RVA: 0x0074A9B6 File Offset: 0x00748BB6
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06035869 RID: 219241 RVA: 0x0074A9C3 File Offset: 0x00748BC3
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603586A RID: 219242 RVA: 0x0074A9CC File Offset: 0x00748BCC
		public static ITalkOptionPhoneMessageEmoji GetRootAsITalkOptionPhoneMessageEmoji(ByteBuffer _bb)
		{
			return ITalkOptionPhoneMessageEmoji.GetRootAsITalkOptionPhoneMessageEmoji(_bb, default(ITalkOptionPhoneMessageEmoji));
		}

		// Token: 0x0603586B RID: 219243 RVA: 0x0074A9E8 File Offset: 0x00748BE8
		public static ITalkOptionPhoneMessageEmoji GetRootAsITalkOptionPhoneMessageEmoji(ByteBuffer _bb, ITalkOptionPhoneMessageEmoji obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603586C RID: 219244 RVA: 0x0074AA05 File Offset: 0x00748C05
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603586D RID: 219245 RVA: 0x0074AA14 File Offset: 0x00748C14
		public ITalkOptionPhoneMessageEmoji __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E004 RID: 57348
		// (get) Token: 0x0603586E RID: 219246 RVA: 0x0074AA24 File Offset: 0x00748C24
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

		// Token: 0x1700E005 RID: 57349
		// (get) Token: 0x0603586F RID: 219247 RVA: 0x0074AA60 File Offset: 0x00748C60
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

		// Token: 0x1700E006 RID: 57350
		// (get) Token: 0x06035870 RID: 219248 RVA: 0x0074AA9C File Offset: 0x00748C9C
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

		// Token: 0x06035871 RID: 219249 RVA: 0x0074AAD8 File Offset: 0x00748CD8
		public static Offset<ITalkOptionPhoneMessageEmoji> CreateITalkOptionPhoneMessageEmoji(FlatBufferBuilder builder, ETalkOptionParamType Type = ETalkOptionParamType.QteSucceed, int EmojiId = 0, byte NullMask = 0)
		{
			builder.StartTable(3);
			ITalkOptionPhoneMessageEmoji.AddEmojiId(builder, EmojiId);
			ITalkOptionPhoneMessageEmoji.AddNullMask(builder, NullMask);
			ITalkOptionPhoneMessageEmoji.AddType(builder, Type);
			return ITalkOptionPhoneMessageEmoji.EndITalkOptionPhoneMessageEmoji(builder);
		}

		// Token: 0x06035872 RID: 219250 RVA: 0x0074AAFC File Offset: 0x00748CFC
		public static void StartITalkOptionPhoneMessageEmoji(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06035873 RID: 219251 RVA: 0x0074AB05 File Offset: 0x00748D05
		public static void AddType(FlatBufferBuilder builder, ETalkOptionParamType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06035874 RID: 219252 RVA: 0x0074AB10 File Offset: 0x00748D10
		public static void AddEmojiId(FlatBufferBuilder builder, int emojiId)
		{
			builder.AddInt(1, emojiId, 0);
		}

		// Token: 0x06035875 RID: 219253 RVA: 0x0074AB1B File Offset: 0x00748D1B
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x06035876 RID: 219254 RVA: 0x0074AB26 File Offset: 0x00748D26
		public static Offset<ITalkOptionPhoneMessageEmoji> EndITalkOptionPhoneMessageEmoji(FlatBufferBuilder builder)
		{
			return new Offset<ITalkOptionPhoneMessageEmoji>(builder.EndTable());
		}

		// Token: 0x06035877 RID: 219255 RVA: 0x0074AB34 File Offset: 0x00748D34
		public ITalkOptionPhoneMessageEmojiT UnPack()
		{
			ITalkOptionPhoneMessageEmojiT talkOptionPhoneMessageEmojiT = new ITalkOptionPhoneMessageEmojiT();
			this.UnPackTo(talkOptionPhoneMessageEmojiT);
			return talkOptionPhoneMessageEmojiT;
		}

		// Token: 0x06035878 RID: 219256 RVA: 0x0074AB4F File Offset: 0x00748D4F
		public void UnPackTo(ITalkOptionPhoneMessageEmojiT _o)
		{
			_o.Type = this.Type;
			_o.EmojiId = this.EmojiId;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06035879 RID: 219257 RVA: 0x0074AB78 File Offset: 0x00748D78
		public static Offset<ITalkOptionPhoneMessageEmoji> Pack(FlatBufferBuilder builder, ITalkOptionPhoneMessageEmojiT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITalkOptionPhoneMessageEmoji>);
			}
			return ITalkOptionPhoneMessageEmoji.CreateITalkOptionPhoneMessageEmoji(builder, _o.Type, _o.EmojiId, _o.NullMask);
		}

		// Token: 0x0401212C RID: 74028
		private Table __p;
	}
}
