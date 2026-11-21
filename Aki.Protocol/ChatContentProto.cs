using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200027F RID: 639
	public sealed class ChatContentProto : IMessage<ChatContentProto>, IMessage, IEquatable<ChatContentProto>, IDeepCloneable<ChatContentProto>, IBufferMessage
	{
		// Token: 0x0600433C RID: 17212 RVA: 0x000A523F File Offset: 0x000A343F
		[NullableContext(1)]
		public static ChatContentProto Create()
		{
			return new ChatContentProto();
		}

		// Token: 0x17000B6F RID: 2927
		// (get) Token: 0x0600433D RID: 17213 RVA: 0x000A5246 File Offset: 0x000A3446
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ChatContentProto> Parser
		{
			get
			{
				return ChatContentProto._parser;
			}
		}

		// Token: 0x17000B70 RID: 2928
		// (get) Token: 0x0600433E RID: 17214 RVA: 0x000A524D File Offset: 0x000A344D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000B71 RID: 2929
		// (get) Token: 0x0600433F RID: 17215 RVA: 0x000A5250 File Offset: 0x000A3450
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ChatContentProto.Descriptor;
			}
		}

		// Token: 0x06004340 RID: 17216 RVA: 0x000A5257 File Offset: 0x000A3457
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChatContentProto()
		{
		}

		// Token: 0x06004341 RID: 17217 RVA: 0x000A528C File Offset: 0x000A348C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChatContentProto(ChatContentProto other) : this()
		{
			this.senderUID_ = other.senderUID_;
			this.chatContentType_ = other.chatContentType_;
			this.content_ = other.content_;
			this.offlineMsg_ = other.offlineMsg_;
			this.uTCTime_ = other.uTCTime_;
			this.msgId_ = other.msgId_;
			this.senderPsnAccountId_ = other.senderPsnAccountId_;
			this.senderXboxAccountId_ = other.senderXboxAccountId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004342 RID: 17218 RVA: 0x000A5310 File Offset: 0x000A3510
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChatContentProto Clone()
		{
			return new ChatContentProto(this);
		}

		// Token: 0x17000B72 RID: 2930
		// (get) Token: 0x06004343 RID: 17219 RVA: 0x000A5318 File Offset: 0x000A3518
		// (set) Token: 0x06004344 RID: 17220 RVA: 0x000A5320 File Offset: 0x000A3520
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SenderUID
		{
			get
			{
				return this.senderUID_;
			}
			set
			{
				this.senderUID_ = value;
			}
		}

		// Token: 0x17000B73 RID: 2931
		// (get) Token: 0x06004345 RID: 17221 RVA: 0x000A5329 File Offset: 0x000A3529
		// (set) Token: 0x06004346 RID: 17222 RVA: 0x000A5331 File Offset: 0x000A3531
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChatContentType ChatContentType
		{
			get
			{
				return this.chatContentType_;
			}
			set
			{
				this.chatContentType_ = value;
			}
		}

		// Token: 0x17000B74 RID: 2932
		// (get) Token: 0x06004347 RID: 17223 RVA: 0x000A533A File Offset: 0x000A353A
		// (set) Token: 0x06004348 RID: 17224 RVA: 0x000A5342 File Offset: 0x000A3542
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

		// Token: 0x17000B75 RID: 2933
		// (get) Token: 0x06004349 RID: 17225 RVA: 0x000A5355 File Offset: 0x000A3555
		// (set) Token: 0x0600434A RID: 17226 RVA: 0x000A535D File Offset: 0x000A355D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool OfflineMsg
		{
			get
			{
				return this.offlineMsg_;
			}
			set
			{
				this.offlineMsg_ = value;
			}
		}

		// Token: 0x17000B76 RID: 2934
		// (get) Token: 0x0600434B RID: 17227 RVA: 0x000A5366 File Offset: 0x000A3566
		// (set) Token: 0x0600434C RID: 17228 RVA: 0x000A536E File Offset: 0x000A356E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long UTCTime
		{
			get
			{
				return this.uTCTime_;
			}
			set
			{
				this.uTCTime_ = value;
			}
		}

		// Token: 0x17000B77 RID: 2935
		// (get) Token: 0x0600434D RID: 17229 RVA: 0x000A5377 File Offset: 0x000A3577
		// (set) Token: 0x0600434E RID: 17230 RVA: 0x000A537F File Offset: 0x000A357F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string MsgId
		{
			get
			{
				return this.msgId_;
			}
			set
			{
				this.msgId_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17000B78 RID: 2936
		// (get) Token: 0x0600434F RID: 17231 RVA: 0x000A5392 File Offset: 0x000A3592
		// (set) Token: 0x06004350 RID: 17232 RVA: 0x000A539A File Offset: 0x000A359A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string SenderPsnAccountId
		{
			get
			{
				return this.senderPsnAccountId_;
			}
			set
			{
				this.senderPsnAccountId_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17000B79 RID: 2937
		// (get) Token: 0x06004351 RID: 17233 RVA: 0x000A53AD File Offset: 0x000A35AD
		// (set) Token: 0x06004352 RID: 17234 RVA: 0x000A53B5 File Offset: 0x000A35B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string SenderXboxAccountId
		{
			get
			{
				return this.senderXboxAccountId_;
			}
			set
			{
				this.senderXboxAccountId_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x06004353 RID: 17235 RVA: 0x000A53C8 File Offset: 0x000A35C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ChatContentProto);
		}

		// Token: 0x06004354 RID: 17236 RVA: 0x000A53D8 File Offset: 0x000A35D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ChatContentProto other)
		{
			return other != null && (other == this || (this.SenderUID == other.SenderUID && this.ChatContentType == other.ChatContentType && !(this.Content != other.Content) && this.OfflineMsg == other.OfflineMsg && this.UTCTime == other.UTCTime && !(this.MsgId != other.MsgId) && !(this.SenderPsnAccountId != other.SenderPsnAccountId) && !(this.SenderXboxAccountId != other.SenderXboxAccountId) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004355 RID: 17237 RVA: 0x000A5498 File Offset: 0x000A3698
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.SenderUID != 0)
			{
				num ^= this.SenderUID.GetHashCode();
			}
			if (this.ChatContentType != ChatContentType.Text)
			{
				num ^= this.ChatContentType.GetHashCode();
			}
			if (this.Content.Length != 0)
			{
				num ^= this.Content.GetHashCode();
			}
			if (this.OfflineMsg)
			{
				num ^= this.OfflineMsg.GetHashCode();
			}
			if (this.UTCTime != 0L)
			{
				num ^= this.UTCTime.GetHashCode();
			}
			if (this.MsgId.Length != 0)
			{
				num ^= this.MsgId.GetHashCode();
			}
			if (this.SenderPsnAccountId.Length != 0)
			{
				num ^= this.SenderPsnAccountId.GetHashCode();
			}
			if (this.SenderXboxAccountId.Length != 0)
			{
				num ^= this.SenderXboxAccountId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06004356 RID: 17238 RVA: 0x000A5595 File Offset: 0x000A3795
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06004357 RID: 17239 RVA: 0x000A55A2 File Offset: 0x000A37A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004358 RID: 17240 RVA: 0x000A55AC File Offset: 0x000A37AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SenderUID != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.SenderUID);
			}
			if (this.ChatContentType != ChatContentType.Text)
			{
				output.WriteRawTag(16);
				output.WriteEnum((int)this.ChatContentType);
			}
			if (this.Content.Length != 0)
			{
				output.WriteRawTag(26);
				output.WriteString(this.Content);
			}
			if (this.OfflineMsg)
			{
				output.WriteRawTag(32);
				output.WriteBool(this.OfflineMsg);
			}
			if (this.UTCTime != 0L)
			{
				output.WriteRawTag(40);
				output.WriteInt64(this.UTCTime);
			}
			if (this.MsgId.Length != 0)
			{
				output.WriteRawTag(50);
				output.WriteString(this.MsgId);
			}
			if (this.SenderPsnAccountId.Length != 0)
			{
				output.WriteRawTag(58);
				output.WriteString(this.SenderPsnAccountId);
			}
			if (this.SenderXboxAccountId.Length != 0)
			{
				output.WriteRawTag(66);
				output.WriteString(this.SenderXboxAccountId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004359 RID: 17241 RVA: 0x000A56C0 File Offset: 0x000A38C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.SenderUID != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SenderUID);
			}
			if (this.ChatContentType != ChatContentType.Text)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ChatContentType);
			}
			if (this.Content.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Content);
			}
			if (this.OfflineMsg)
			{
				num += 2;
			}
			if (this.UTCTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.UTCTime);
			}
			if (this.MsgId.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.MsgId);
			}
			if (this.SenderPsnAccountId.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.SenderPsnAccountId);
			}
			if (this.SenderXboxAccountId.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.SenderXboxAccountId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600435A RID: 17242 RVA: 0x000A57B0 File Offset: 0x000A39B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ChatContentProto other)
		{
			if (other == null)
			{
				return;
			}
			if (other.SenderUID != 0)
			{
				this.SenderUID = other.SenderUID;
			}
			if (other.ChatContentType != ChatContentType.Text)
			{
				this.ChatContentType = other.ChatContentType;
			}
			if (other.Content.Length != 0)
			{
				this.Content = other.Content;
			}
			if (other.OfflineMsg)
			{
				this.OfflineMsg = other.OfflineMsg;
			}
			if (other.UTCTime != 0L)
			{
				this.UTCTime = other.UTCTime;
			}
			if (other.MsgId.Length != 0)
			{
				this.MsgId = other.MsgId;
			}
			if (other.SenderPsnAccountId.Length != 0)
			{
				this.SenderPsnAccountId = other.SenderPsnAccountId;
			}
			if (other.SenderXboxAccountId.Length != 0)
			{
				this.SenderXboxAccountId = other.SenderXboxAccountId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600435B RID: 17243 RVA: 0x000A588C File Offset: 0x000A3A8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600435C RID: 17244 RVA: 0x000A5898 File Offset: 0x000A3A98
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
				if (num <= 32U)
				{
					if (num <= 16U)
					{
						if (num == 8U)
						{
							this.SenderUID = input.ReadInt32();
							continue;
						}
						if (num == 16U)
						{
							this.ChatContentType = (ChatContentType)input.ReadEnum();
							continue;
						}
					}
					else
					{
						if (num == 26U)
						{
							this.Content = input.ReadString();
							continue;
						}
						if (num == 32U)
						{
							this.OfflineMsg = input.ReadBool();
							continue;
						}
					}
				}
				else if (num <= 50U)
				{
					if (num == 40U)
					{
						this.UTCTime = input.ReadInt64();
						continue;
					}
					if (num == 50U)
					{
						this.MsgId = input.ReadString();
						continue;
					}
				}
				else
				{
					if (num == 58U)
					{
						this.SenderPsnAccountId = input.ReadString();
						continue;
					}
					if (num == 66U)
					{
						this.SenderXboxAccountId = input.ReadString();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04002E95 RID: 11925
		private static readonly MessageParser<ChatContentProto> _parser = new MessageParser<ChatContentProto>(() => new ChatContentProto());

		// Token: 0x04002E96 RID: 11926
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002E97 RID: 11927
		public const int SenderUIDFieldNumber = 1;

		// Token: 0x04002E98 RID: 11928
		private int senderUID_;

		// Token: 0x04002E99 RID: 11929
		public const int ChatContentTypeFieldNumber = 2;

		// Token: 0x04002E9A RID: 11930
		private ChatContentType chatContentType_;

		// Token: 0x04002E9B RID: 11931
		public const int ContentFieldNumber = 3;

		// Token: 0x04002E9C RID: 11932
		private string content_ = "";

		// Token: 0x04002E9D RID: 11933
		public const int OfflineMsgFieldNumber = 4;

		// Token: 0x04002E9E RID: 11934
		private bool offlineMsg_;

		// Token: 0x04002E9F RID: 11935
		public const int UTCTimeFieldNumber = 5;

		// Token: 0x04002EA0 RID: 11936
		private long uTCTime_;

		// Token: 0x04002EA1 RID: 11937
		public const int MsgIdFieldNumber = 6;

		// Token: 0x04002EA2 RID: 11938
		private string msgId_ = "";

		// Token: 0x04002EA3 RID: 11939
		public const int SenderPsnAccountIdFieldNumber = 7;

		// Token: 0x04002EA4 RID: 11940
		private string senderPsnAccountId_ = "";

		// Token: 0x04002EA5 RID: 11941
		public const int SenderXboxAccountIdFieldNumber = 8;

		// Token: 0x04002EA6 RID: 11942
		private string senderXboxAccountId_ = "";
	}
}
