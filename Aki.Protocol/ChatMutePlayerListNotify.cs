using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000280 RID: 640
	[NetMessage(EMessageId.ChatMutePlayerListNotify)]
	public sealed class ChatMutePlayerListNotify : IMessage<ChatMutePlayerListNotify>, IMessage, IEquatable<ChatMutePlayerListNotify>, IDeepCloneable<ChatMutePlayerListNotify>, IBufferMessage
	{
		// Token: 0x0600435E RID: 17246 RVA: 0x000A5998 File Offset: 0x000A3B98
		[NullableContext(1)]
		public static ChatMutePlayerListNotify Create()
		{
			return new ChatMutePlayerListNotify();
		}

		// Token: 0x17000B7A RID: 2938
		// (get) Token: 0x0600435F RID: 17247 RVA: 0x000A599F File Offset: 0x000A3B9F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000B7B RID: 2939
		// (get) Token: 0x06004360 RID: 17248 RVA: 0x000A59A2 File Offset: 0x000A3BA2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ChatMutePlayerListNotify.Descriptor;
			}
		}

		// Token: 0x06004361 RID: 17249 RVA: 0x000A59A9 File Offset: 0x000A3BA9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChatMutePlayerListNotify()
		{
		}

		// Token: 0x06004362 RID: 17250 RVA: 0x000A59BC File Offset: 0x000A3BBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChatMutePlayerListNotify(ChatMutePlayerListNotify other) : this()
		{
			this.playerId_ = other.playerId_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004363 RID: 17251 RVA: 0x000A59E6 File Offset: 0x000A3BE6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChatMutePlayerListNotify Clone()
		{
			return new ChatMutePlayerListNotify(this);
		}

		// Token: 0x17000B7C RID: 2940
		// (get) Token: 0x06004364 RID: 17252 RVA: 0x000A59EE File Offset: 0x000A3BEE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> PlayerId
		{
			get
			{
				return this.playerId_;
			}
		}

		// Token: 0x06004365 RID: 17253 RVA: 0x000A59F6 File Offset: 0x000A3BF6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ChatMutePlayerListNotify);
		}

		// Token: 0x06004366 RID: 17254 RVA: 0x000A5A04 File Offset: 0x000A3C04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ChatMutePlayerListNotify other)
		{
			return other != null && (other == this || (this.playerId_.Equals(other.playerId_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004367 RID: 17255 RVA: 0x000A5A38 File Offset: 0x000A3C38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.playerId_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06004368 RID: 17256 RVA: 0x000A5A6C File Offset: 0x000A3C6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06004369 RID: 17257 RVA: 0x000A5A79 File Offset: 0x000A3C79
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600436A RID: 17258 RVA: 0x000A5A82 File Offset: 0x000A3C82
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.playerId_.WriteTo(ref output, ChatMutePlayerListNotify._repeated_playerId_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600436B RID: 17259 RVA: 0x000A5AAC File Offset: 0x000A3CAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.playerId_.CalculateSize(ChatMutePlayerListNotify._repeated_playerId_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600436C RID: 17260 RVA: 0x000A5AE5 File Offset: 0x000A3CE5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ChatMutePlayerListNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.playerId_.Add(other.playerId_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600436D RID: 17261 RVA: 0x000A5B13 File Offset: 0x000A3D13
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600436E RID: 17262 RVA: 0x000A5B1C File Offset: 0x000A3D1C
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
				if (num != 8U && num != 10U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.playerId_.AddEntriesFrom(ref input, ChatMutePlayerListNotify._repeated_playerId_codec);
				}
			}
		}

		// Token: 0x04002EA7 RID: 11943
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002EA8 RID: 11944
		public const int PlayerIdFieldNumber = 1;

		// Token: 0x04002EA9 RID: 11945
		private static readonly FieldCodec<int> _repeated_playerId_codec = FieldCodec.ForInt32(10U);

		// Token: 0x04002EAA RID: 11946
		private readonly RepeatedField<int> playerId_ = new RepeatedField<int>();
	}
}
