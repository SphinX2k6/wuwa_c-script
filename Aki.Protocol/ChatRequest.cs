using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000284 RID: 644
	[NetMessage(EMessageId.ChatRequest)]
	public sealed class ChatRequest : IMessage<ChatRequest>, IMessage, IEquatable<ChatRequest>, IDeepCloneable<ChatRequest>, IBufferMessage
	{
		// Token: 0x060043AA RID: 17322 RVA: 0x000A62B9 File Offset: 0x000A44B9
		[NullableContext(1)]
		public static ChatRequest Create()
		{
			return new ChatRequest();
		}

		// Token: 0x17000B88 RID: 2952
		// (get) Token: 0x060043AB RID: 17323 RVA: 0x000A62C0 File Offset: 0x000A44C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000B89 RID: 2953
		// (get) Token: 0x060043AC RID: 17324 RVA: 0x000A62C3 File Offset: 0x000A44C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ChatRequest.Descriptor;
			}
		}

		// Token: 0x060043AD RID: 17325 RVA: 0x000A62CA File Offset: 0x000A44CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChatRequest()
		{
		}

		// Token: 0x060043AE RID: 17326 RVA: 0x000A62E8 File Offset: 0x000A44E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChatRequest(ChatRequest other) : this()
		{
			this.channelId_ = other.channelId_;
			this.content_ = other.content_;
			this.chatParams_ = other.chatParams_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060043AF RID: 17327 RVA: 0x000A6335 File Offset: 0x000A4535
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChatRequest Clone()
		{
			return new ChatRequest(this);
		}

		// Token: 0x17000B8A RID: 2954
		// (get) Token: 0x060043B0 RID: 17328 RVA: 0x000A633D File Offset: 0x000A453D
		// (set) Token: 0x060043B1 RID: 17329 RVA: 0x000A6345 File Offset: 0x000A4545
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

		// Token: 0x17000B8B RID: 2955
		// (get) Token: 0x060043B2 RID: 17330 RVA: 0x000A634E File Offset: 0x000A454E
		// (set) Token: 0x060043B3 RID: 17331 RVA: 0x000A6356 File Offset: 0x000A4556
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

		// Token: 0x17000B8C RID: 2956
		// (get) Token: 0x060043B4 RID: 17332 RVA: 0x000A6369 File Offset: 0x000A4569
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<string> ChatParams
		{
			get
			{
				return this.chatParams_;
			}
		}

		// Token: 0x060043B5 RID: 17333 RVA: 0x000A6371 File Offset: 0x000A4571
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ChatRequest);
		}

		// Token: 0x060043B6 RID: 17334 RVA: 0x000A6380 File Offset: 0x000A4580
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ChatRequest other)
		{
			return other != null && (other == this || (this.ChannelId == other.ChannelId && !(this.Content != other.Content) && this.chatParams_.Equals(other.chatParams_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060043B7 RID: 17335 RVA: 0x000A63E4 File Offset: 0x000A45E4
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

		// Token: 0x060043B8 RID: 17336 RVA: 0x000A644C File Offset: 0x000A464C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060043B9 RID: 17337 RVA: 0x000A6459 File Offset: 0x000A4659
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060043BA RID: 17338 RVA: 0x000A6464 File Offset: 0x000A4664
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ChannelId != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.ChannelId);
			}
			this.chatParams_.WriteTo(ref output, ChatRequest._repeated_chatParams_codec);
			if (this.Content.Length != 0)
			{
				output.WriteRawTag(122);
				output.WriteString(this.Content);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060043BB RID: 17339 RVA: 0x000A64D4 File Offset: 0x000A46D4
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

		// Token: 0x060043BC RID: 17340 RVA: 0x000A6544 File Offset: 0x000A4744
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

		// Token: 0x060043BD RID: 17341 RVA: 0x000A65AA File Offset: 0x000A47AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060043BE RID: 17342 RVA: 0x000A65B4 File Offset: 0x000A47B4
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
				if (num != 40U)
				{
					if (num != 106U)
					{
						if (num != 122U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
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
				else
				{
					this.ChannelId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04002EB9 RID: 11961
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002EBA RID: 11962
		public const int ChannelIdFieldNumber = 5;

		// Token: 0x04002EBB RID: 11963
		private int channelId_;

		// Token: 0x04002EBC RID: 11964
		public const int ContentFieldNumber = 15;

		// Token: 0x04002EBD RID: 11965
		private string content_ = "";

		// Token: 0x04002EBE RID: 11966
		public const int ChatParamsFieldNumber = 13;

		// Token: 0x04002EBF RID: 11967
		private static readonly FieldCodec<string> _repeated_chatParams_codec = FieldCodec.ForString(106U);

		// Token: 0x04002EC0 RID: 11968
		private readonly RepeatedField<string> chatParams_ = new RepeatedField<string>();
	}
}
