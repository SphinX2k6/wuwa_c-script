using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006AE5 RID: 27365
	public struct ICommonTalkMessage : IFlatbufferObject
	{
		// Token: 0x1700C8F1 RID: 51441
		// (get) Token: 0x0602F067 RID: 192615 RVA: 0x0066A01E File Offset: 0x0066821E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602F068 RID: 192616 RVA: 0x0066A02B File Offset: 0x0066822B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602F069 RID: 192617 RVA: 0x0066A034 File Offset: 0x00668234
		public static ICommonTalkMessage GetRootAsICommonTalkMessage(ByteBuffer _bb)
		{
			return ICommonTalkMessage.GetRootAsICommonTalkMessage(_bb, default(ICommonTalkMessage));
		}

		// Token: 0x0602F06A RID: 192618 RVA: 0x0066A050 File Offset: 0x00668250
		public static ICommonTalkMessage GetRootAsICommonTalkMessage(ByteBuffer _bb, ICommonTalkMessage obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602F06B RID: 192619 RVA: 0x0066A06D File Offset: 0x0066826D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602F06C RID: 192620 RVA: 0x0066A07C File Offset: 0x0066827C
		public ICommonTalkMessage __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C8F2 RID: 51442
		// (get) Token: 0x0602F06D RID: 192621 RVA: 0x0066A08C File Offset: 0x0066828C
		public string Text
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602F06E RID: 192622 RVA: 0x0066A0C3 File Offset: 0x006682C3
		public Span<byte> GetTextBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x0602F06F RID: 192623 RVA: 0x0066A0D2 File Offset: 0x006682D2
		public byte[] GetTextArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x1700C8F3 RID: 51443
		// (get) Token: 0x0602F070 RID: 192624 RVA: 0x0066A0E0 File Offset: 0x006682E0
		public int TalkerId
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

		// Token: 0x1700C8F4 RID: 51444
		// (get) Token: 0x0602F071 RID: 192625 RVA: 0x0066A11C File Offset: 0x0066831C
		public float TextShowDelay
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700C8F5 RID: 51445
		// (get) Token: 0x0602F072 RID: 192626 RVA: 0x0066A15C File Offset: 0x0066835C
		public float TextShowDuration
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700C8F6 RID: 51446
		// (get) Token: 0x0602F073 RID: 192627 RVA: 0x0066A1A0 File Offset: 0x006683A0
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602F074 RID: 192628 RVA: 0x0066A1DD File Offset: 0x006683DD
		public static Offset<ICommonTalkMessage> CreateICommonTalkMessage(FlatBufferBuilder builder, StringOffset TextOffset = default(StringOffset), int TalkerId = 0, float TextShowDelay = 0f, float TextShowDuration = 0f, byte NullMask = 0)
		{
			builder.StartTable(5);
			ICommonTalkMessage.AddTextShowDuration(builder, TextShowDuration);
			ICommonTalkMessage.AddTextShowDelay(builder, TextShowDelay);
			ICommonTalkMessage.AddTalkerId(builder, TalkerId);
			ICommonTalkMessage.AddText(builder, TextOffset);
			ICommonTalkMessage.AddNullMask(builder, NullMask);
			return ICommonTalkMessage.EndICommonTalkMessage(builder);
		}

		// Token: 0x0602F075 RID: 192629 RVA: 0x0066A211 File Offset: 0x00668411
		public static void StartICommonTalkMessage(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x0602F076 RID: 192630 RVA: 0x0066A21A File Offset: 0x0066841A
		public static void AddText(FlatBufferBuilder builder, StringOffset textOffset)
		{
			builder.AddOffset(0, textOffset.Value, 0);
		}

		// Token: 0x0602F077 RID: 192631 RVA: 0x0066A22A File Offset: 0x0066842A
		public static void AddTalkerId(FlatBufferBuilder builder, int talkerId)
		{
			builder.AddInt(1, talkerId, 0);
		}

		// Token: 0x0602F078 RID: 192632 RVA: 0x0066A235 File Offset: 0x00668435
		public static void AddTextShowDelay(FlatBufferBuilder builder, float textShowDelay)
		{
			builder.AddFloat(2, textShowDelay, 0.0);
		}

		// Token: 0x0602F079 RID: 192633 RVA: 0x0066A248 File Offset: 0x00668448
		public static void AddTextShowDuration(FlatBufferBuilder builder, float textShowDuration)
		{
			builder.AddFloat(3, textShowDuration, 0.0);
		}

		// Token: 0x0602F07A RID: 192634 RVA: 0x0066A25B File Offset: 0x0066845B
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x0602F07B RID: 192635 RVA: 0x0066A266 File Offset: 0x00668466
		public static Offset<ICommonTalkMessage> EndICommonTalkMessage(FlatBufferBuilder builder)
		{
			return new Offset<ICommonTalkMessage>(builder.EndTable());
		}

		// Token: 0x0602F07C RID: 192636 RVA: 0x0066A274 File Offset: 0x00668474
		public ICommonTalkMessageT UnPack()
		{
			ICommonTalkMessageT commonTalkMessageT = new ICommonTalkMessageT();
			this.UnPackTo(commonTalkMessageT);
			return commonTalkMessageT;
		}

		// Token: 0x0602F07D RID: 192637 RVA: 0x0066A28F File Offset: 0x0066848F
		public void UnPackTo(ICommonTalkMessageT _o)
		{
			_o.Text = this.Text;
			_o.TalkerId = this.TalkerId;
			_o.TextShowDelay = this.TextShowDelay;
			_o.TextShowDuration = this.TextShowDuration;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602F07E RID: 192638 RVA: 0x0066A2D0 File Offset: 0x006684D0
		public static Offset<ICommonTalkMessage> Pack(FlatBufferBuilder builder, ICommonTalkMessageT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICommonTalkMessage>);
			}
			StringOffset textOffset = (_o.Text == null) ? default(StringOffset) : builder.CreateString(_o.Text);
			return ICommonTalkMessage.CreateICommonTalkMessage(builder, textOffset, _o.TalkerId, _o.TextShowDelay, _o.TextShowDuration, _o.NullMask);
		}

		// Token: 0x0401188D RID: 71821
		private Table __p;
	}
}
