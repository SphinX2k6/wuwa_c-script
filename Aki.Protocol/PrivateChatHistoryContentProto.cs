using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000DDE RID: 3550
	public sealed class PrivateChatHistoryContentProto : IMessage<PrivateChatHistoryContentProto>, IMessage, IEquatable<PrivateChatHistoryContentProto>, IDeepCloneable<PrivateChatHistoryContentProto>, IBufferMessage
	{
		// Token: 0x0601319F RID: 78239 RVA: 0x002C857D File Offset: 0x002C677D
		[NullableContext(1)]
		public static PrivateChatHistoryContentProto Create()
		{
			return new PrivateChatHistoryContentProto();
		}

		// Token: 0x17003F5D RID: 16221
		// (get) Token: 0x060131A0 RID: 78240 RVA: 0x002C8584 File Offset: 0x002C6784
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PrivateChatHistoryContentProto> Parser
		{
			get
			{
				return PrivateChatHistoryContentProto._parser;
			}
		}

		// Token: 0x17003F5E RID: 16222
		// (get) Token: 0x060131A1 RID: 78241 RVA: 0x002C858B File Offset: 0x002C678B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003F5F RID: 16223
		// (get) Token: 0x060131A2 RID: 78242 RVA: 0x002C858E File Offset: 0x002C678E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PrivateChatHistoryContentProto.Descriptor;
			}
		}

		// Token: 0x060131A3 RID: 78243 RVA: 0x002C8595 File Offset: 0x002C6795
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PrivateChatHistoryContentProto()
		{
		}

		// Token: 0x060131A4 RID: 78244 RVA: 0x002C85A8 File Offset: 0x002C67A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PrivateChatHistoryContentProto(PrivateChatHistoryContentProto other) : this()
		{
			this.targetUID_ = other.targetUID_;
			this.chats_ = other.chats_.Clone();
			this.historyIsEnd_ = other.historyIsEnd_;
			this.totalNums_ = other.totalNums_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060131A5 RID: 78245 RVA: 0x002C8601 File Offset: 0x002C6801
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PrivateChatHistoryContentProto Clone()
		{
			return new PrivateChatHistoryContentProto(this);
		}

		// Token: 0x17003F60 RID: 16224
		// (get) Token: 0x060131A6 RID: 78246 RVA: 0x002C8609 File Offset: 0x002C6809
		// (set) Token: 0x060131A7 RID: 78247 RVA: 0x002C8611 File Offset: 0x002C6811
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TargetUID
		{
			get
			{
				return this.targetUID_;
			}
			set
			{
				this.targetUID_ = value;
			}
		}

		// Token: 0x17003F61 RID: 16225
		// (get) Token: 0x060131A8 RID: 78248 RVA: 0x002C861A File Offset: 0x002C681A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ChatContentProto> Chats
		{
			get
			{
				return this.chats_;
			}
		}

		// Token: 0x17003F62 RID: 16226
		// (get) Token: 0x060131A9 RID: 78249 RVA: 0x002C8622 File Offset: 0x002C6822
		// (set) Token: 0x060131AA RID: 78250 RVA: 0x002C862A File Offset: 0x002C682A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HistoryIsEnd
		{
			get
			{
				return this.historyIsEnd_;
			}
			set
			{
				this.historyIsEnd_ = value;
			}
		}

		// Token: 0x17003F63 RID: 16227
		// (get) Token: 0x060131AB RID: 78251 RVA: 0x002C8633 File Offset: 0x002C6833
		// (set) Token: 0x060131AC RID: 78252 RVA: 0x002C863B File Offset: 0x002C683B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TotalNums
		{
			get
			{
				return this.totalNums_;
			}
			set
			{
				this.totalNums_ = value;
			}
		}

		// Token: 0x060131AD RID: 78253 RVA: 0x002C8644 File Offset: 0x002C6844
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PrivateChatHistoryContentProto);
		}

		// Token: 0x060131AE RID: 78254 RVA: 0x002C8654 File Offset: 0x002C6854
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PrivateChatHistoryContentProto other)
		{
			return other != null && (other == this || (this.TargetUID == other.TargetUID && this.chats_.Equals(other.chats_) && this.HistoryIsEnd == other.HistoryIsEnd && this.TotalNums == other.TotalNums && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060131AF RID: 78255 RVA: 0x002C86C4 File Offset: 0x002C68C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.TargetUID != 0)
			{
				num ^= this.TargetUID.GetHashCode();
			}
			num ^= this.chats_.GetHashCode();
			if (this.HistoryIsEnd)
			{
				num ^= this.HistoryIsEnd.GetHashCode();
			}
			if (this.TotalNums != 0)
			{
				num ^= this.TotalNums.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060131B0 RID: 78256 RVA: 0x002C8743 File Offset: 0x002C6943
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060131B1 RID: 78257 RVA: 0x002C8750 File Offset: 0x002C6950
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060131B2 RID: 78258 RVA: 0x002C875C File Offset: 0x002C695C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TargetUID != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.TargetUID);
			}
			this.chats_.WriteTo(ref output, PrivateChatHistoryContentProto._repeated_chats_codec);
			if (this.HistoryIsEnd)
			{
				output.WriteRawTag(24);
				output.WriteBool(this.HistoryIsEnd);
			}
			if (this.TotalNums != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.TotalNums);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060131B3 RID: 78259 RVA: 0x002C87E4 File Offset: 0x002C69E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.TargetUID != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TargetUID);
			}
			num += this.chats_.CalculateSize(PrivateChatHistoryContentProto._repeated_chats_codec);
			if (this.HistoryIsEnd)
			{
				num += 2;
			}
			if (this.TotalNums != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TotalNums);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060131B4 RID: 78260 RVA: 0x002C885C File Offset: 0x002C6A5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PrivateChatHistoryContentProto other)
		{
			if (other == null)
			{
				return;
			}
			if (other.TargetUID != 0)
			{
				this.TargetUID = other.TargetUID;
			}
			this.chats_.Add(other.chats_);
			if (other.HistoryIsEnd)
			{
				this.HistoryIsEnd = other.HistoryIsEnd;
			}
			if (other.TotalNums != 0)
			{
				this.TotalNums = other.TotalNums;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060131B5 RID: 78261 RVA: 0x002C88D1 File Offset: 0x002C6AD1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060131B6 RID: 78262 RVA: 0x002C88DC File Offset: 0x002C6ADC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if ((num & 7U) == 4U)
				{
					return;
				}
				if (num <= 18U)
				{
					if (num == 8U)
					{
						this.TargetUID = input.ReadInt32();
						continue;
					}
					if (num == 18U)
					{
						this.chats_.AddEntriesFrom(ref input, PrivateChatHistoryContentProto._repeated_chats_codec);
						continue;
					}
				}
				else
				{
					if (num == 24U)
					{
						this.HistoryIsEnd = input.ReadBool();
						continue;
					}
					if (num == 32U)
					{
						this.TotalNums = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040075C0 RID: 30144
		private static readonly MessageParser<PrivateChatHistoryContentProto> _parser = new MessageParser<PrivateChatHistoryContentProto>(() => new PrivateChatHistoryContentProto());

		// Token: 0x040075C1 RID: 30145
		private UnknownFieldSet _unknownFields;

		// Token: 0x040075C2 RID: 30146
		public const int TargetUIDFieldNumber = 1;

		// Token: 0x040075C3 RID: 30147
		private int targetUID_;

		// Token: 0x040075C4 RID: 30148
		public const int ChatsFieldNumber = 2;

		// Token: 0x040075C5 RID: 30149
		private static readonly FieldCodec<ChatContentProto> _repeated_chats_codec = FieldCodec.ForMessage<ChatContentProto>(18U, ChatContentProto.Parser);

		// Token: 0x040075C6 RID: 30150
		private readonly RepeatedField<ChatContentProto> chats_ = new RepeatedField<ChatContentProto>();

		// Token: 0x040075C7 RID: 30151
		public const int HistoryIsEndFieldNumber = 3;

		// Token: 0x040075C8 RID: 30152
		private bool historyIsEnd_;

		// Token: 0x040075C9 RID: 30153
		public const int TotalNumsFieldNumber = 4;

		// Token: 0x040075CA RID: 30154
		private int totalNums_;
	}
}
