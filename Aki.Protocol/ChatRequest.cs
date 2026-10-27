using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200027F RID: 639
	[NetMessage(EMessageId.ChatRequest)]
	public sealed class ChatRequest : IMessage<ChatRequest>, IMessage, IEquatable<ChatRequest>, IDeepCloneable<ChatRequest>, IBufferMessage
	{
		// Token: 0x06004303 RID: 17155 RVA: 0x000A45F1 File Offset: 0x000A27F1
		[NullableContext(1)]
		public static ChatRequest Create()
		{
			return new ChatRequest();
		}

		// Token: 0x17000B68 RID: 2920
		// (get) Token: 0x06004304 RID: 17156 RVA: 0x000A45F8 File Offset: 0x000A27F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000B69 RID: 2921
		// (get) Token: 0x06004305 RID: 17157 RVA: 0x000A45FB File Offset: 0x000A27FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ChatRequest.Descriptor;
			}
		}

		// Token: 0x06004306 RID: 17158 RVA: 0x000A4602 File Offset: 0x000A2802
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChatRequest()
		{
		}

		// Token: 0x06004307 RID: 17159 RVA: 0x000A4620 File Offset: 0x000A2820
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChatRequest(ChatRequest other) : this()
		{
			this.channelId_ = other.channelId_;
			this.content_ = other.content_;
			this.chatParams_ = other.chatParams_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004308 RID: 17160 RVA: 0x000A466D File Offset: 0x000A286D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChatRequest Clone()
		{
			return new ChatRequest(this);
		}

		// Token: 0x17000B6A RID: 2922
		// (get) Token: 0x06004309 RID: 17161 RVA: 0x000A4675 File Offset: 0x000A2875
		// (set) Token: 0x0600430A RID: 17162 RVA: 0x000A467D File Offset: 0x000A287D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ChannelId
		{
			get
			{
				return this.channelId_;
			}
			set
			{
				this.channelId_ = value;
			}
		}

		// Token: 0x17000B6B RID: 2923
		// (get) Token: 0x0600430B RID: 17163 RVA: 0x000A4686 File Offset: 0x000A2886
		// (set) Token: 0x0600430C RID: 17164 RVA: 0x000A468E File Offset: 0x000A288E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string Content
		{
			get
			{
				return this.content_;
			}
			set
			{
				this.content_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17000B6C RID: 2924
		// (get) Token: 0x0600430D RID: 17165 RVA: 0x000A46A1 File Offset: 0x000A28A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<string> ChatParams
		{
			get
			{
				return this.chatParams_;
			}
		}

		// Token: 0x0600430E RID: 17166 RVA: 0x000A46A9 File Offset: 0x000A28A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ChatRequest);
		}

		// Token: 0x0600430F RID: 17167 RVA: 0x000A46B8 File Offset: 0x000A28B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ChatRequest other)
		{
			return other != null && (other == this || (this.ChannelId == other.ChannelId && !(this.Content != other.Content) && this.chatParams_.Equals(other.chatParams_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004310 RID: 17168 RVA: 0x000A471C File Offset: 0x000A291C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ChannelId != 0)
			{
				num ^= this.ChannelId.GetHashCode();
			}
			if (this.Content.Length != 0)
			{
				num ^= this.Content.GetHashCode();
			}
			num ^= this.chatParams_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06004311 RID: 17169 RVA: 0x000A4784 File Offset: 0x000A2984
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06004312 RID: 17170 RVA: 0x000A4791 File Offset: 0x000A2991
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004313 RID: 17171 RVA: 0x000A479C File Offset: 0x000A299C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.chatParams_.WriteTo(ref output, ChatRequest._repeated_chatParams_codec);
			if (this.Content.Length != 0)
			{
				output.WriteRawTag(58);
				output.WriteString(this.Content);
			}
			if (this.ChannelId != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.ChannelId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004314 RID: 17172 RVA: 0x000A480C File Offset: 0x000A2A0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ChannelId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ChannelId);
			}
			if (this.Content.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Content);
			}
			num += this.chatParams_.CalculateSize(ChatRequest._repeated_chatParams_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06004315 RID: 17173 RVA: 0x000A487C File Offset: 0x000A2A7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ChatRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ChannelId != 0)
			{
				this.ChannelId = other.ChannelId;
			}
			if (other.Content.Length != 0)
			{
				this.Content = other.Content;
			}
			this.chatParams_.Add(other.chatParams_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06004316 RID: 17174 RVA: 0x000A48E2 File Offset: 0x000A2AE2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004317 RID: 17175 RVA: 0x000A48EC File Offset: 0x000A2AEC
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
				if (num != 18U)
				{
					if (num != 58U)
					{
						if (num != 88U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.ChannelId = input.ReadInt32();
						}
					}
					else
					{
						this.Content = input.ReadString();
					}
				}
				else
				{
					this.chatParams_.AddEntriesFrom(ref input, ChatRequest._repeated_chatParams_codec);
				}
			}
		}

		// Token: 0x04002E35 RID: 11829
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002E36 RID: 11830
		public const int ChannelIdFieldNumber = 11;

		// Token: 0x04002E37 RID: 11831
		private int channelId_;

		// Token: 0x04002E38 RID: 11832
		public const int ContentFieldNumber = 7;

		// Token: 0x04002E39 RID: 11833
		private string content_ = "";

		// Token: 0x04002E3A RID: 11834
		public const int ChatParamsFieldNumber = 2;

		// Token: 0x04002E3B RID: 11835
		private static readonly FieldCodec<string> _repeated_chatParams_codec = FieldCodec.ForString(18U);

		// Token: 0x04002E3C RID: 11836
		private readonly RepeatedField<string> chatParams_ = new RepeatedField<string>();
	}
}
