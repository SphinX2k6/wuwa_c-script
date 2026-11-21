using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000DD4 RID: 3540
	[NetMessage(EMessageId.PrivateChatRequest)]
	public sealed class PrivateChatRequest : IMessage<PrivateChatRequest>, IMessage, IEquatable<PrivateChatRequest>, IDeepCloneable<PrivateChatRequest>, IBufferMessage
	{
		// Token: 0x06013133 RID: 78131 RVA: 0x002C7EC1 File Offset: 0x002C60C1
		[NullableContext(1)]
		public static PrivateChatRequest Create()
		{
			return new PrivateChatRequest();
		}

		// Token: 0x17003F4C RID: 16204
		// (get) Token: 0x06013134 RID: 78132 RVA: 0x002C7EC8 File Offset: 0x002C60C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003F4D RID: 16205
		// (get) Token: 0x06013135 RID: 78133 RVA: 0x002C7ECB File Offset: 0x002C60CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PrivateChatRequest.Descriptor;
			}
		}

		// Token: 0x06013136 RID: 78134 RVA: 0x002C7ED2 File Offset: 0x002C60D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PrivateChatRequest()
		{
		}

		// Token: 0x06013137 RID: 78135 RVA: 0x002C7EF0 File Offset: 0x002C60F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PrivateChatRequest(PrivateChatRequest other) : this()
		{
			this.targetUID_ = other.targetUID_;
			this.chatContentType_ = other.chatContentType_;
			this.content_ = other.content_;
			this.xboxBlockedPlayerIds_ = other.xboxBlockedPlayerIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06013138 RID: 78136 RVA: 0x002C7F49 File Offset: 0x002C6149
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PrivateChatRequest Clone()
		{
			return new PrivateChatRequest(this);
		}

		// Token: 0x17003F4E RID: 16206
		// (get) Token: 0x06013139 RID: 78137 RVA: 0x002C7F51 File Offset: 0x002C6151
		// (set) Token: 0x0601313A RID: 78138 RVA: 0x002C7F59 File Offset: 0x002C6159
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

		// Token: 0x17003F4F RID: 16207
		// (get) Token: 0x0601313B RID: 78139 RVA: 0x002C7F62 File Offset: 0x002C6162
		// (set) Token: 0x0601313C RID: 78140 RVA: 0x002C7F6A File Offset: 0x002C616A
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

		// Token: 0x17003F50 RID: 16208
		// (get) Token: 0x0601313D RID: 78141 RVA: 0x002C7F73 File Offset: 0x002C6173
		// (set) Token: 0x0601313E RID: 78142 RVA: 0x002C7F7B File Offset: 0x002C617B
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

		// Token: 0x17003F51 RID: 16209
		// (get) Token: 0x0601313F RID: 78143 RVA: 0x002C7F8E File Offset: 0x002C618E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> XboxBlockedPlayerIds
		{
			get
			{
				return this.xboxBlockedPlayerIds_;
			}
		}

		// Token: 0x06013140 RID: 78144 RVA: 0x002C7F96 File Offset: 0x002C6196
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PrivateChatRequest);
		}

		// Token: 0x06013141 RID: 78145 RVA: 0x002C7FA4 File Offset: 0x002C61A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PrivateChatRequest other)
		{
			return other != null && (other == this || (this.TargetUID == other.TargetUID && this.ChatContentType == other.ChatContentType && !(this.Content != other.Content) && this.xboxBlockedPlayerIds_.Equals(other.xboxBlockedPlayerIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06013142 RID: 78146 RVA: 0x002C8018 File Offset: 0x002C6218
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.TargetUID != 0)
			{
				num ^= this.TargetUID.GetHashCode();
			}
			if (this.ChatContentType != ChatContentType.Text)
			{
				num ^= this.ChatContentType.GetHashCode();
			}
			if (this.Content.Length != 0)
			{
				num ^= this.Content.GetHashCode();
			}
			num ^= this.xboxBlockedPlayerIds_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06013143 RID: 78147 RVA: 0x002C809F File Offset: 0x002C629F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06013144 RID: 78148 RVA: 0x002C80AC File Offset: 0x002C62AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06013145 RID: 78149 RVA: 0x002C80B8 File Offset: 0x002C62B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ChatContentType != ChatContentType.Text)
			{
				output.WriteRawTag(24);
				output.WriteEnum((int)this.ChatContentType);
			}
			this.xboxBlockedPlayerIds_.WriteTo(ref output, PrivateChatRequest._repeated_xboxBlockedPlayerIds_codec);
			if (this.TargetUID != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.TargetUID);
			}
			if (this.Content.Length != 0)
			{
				output.WriteRawTag(98);
				output.WriteString(this.Content);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06013146 RID: 78150 RVA: 0x002C8144 File Offset: 0x002C6344
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.TargetUID != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TargetUID);
			}
			if (this.ChatContentType != ChatContentType.Text)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ChatContentType);
			}
			if (this.Content.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Content);
			}
			num += this.xboxBlockedPlayerIds_.CalculateSize(PrivateChatRequest._repeated_xboxBlockedPlayerIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06013147 RID: 78151 RVA: 0x002C81CC File Offset: 0x002C63CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PrivateChatRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.TargetUID != 0)
			{
				this.TargetUID = other.TargetUID;
			}
			if (other.ChatContentType != ChatContentType.Text)
			{
				this.ChatContentType = other.ChatContentType;
			}
			if (other.Content.Length != 0)
			{
				this.Content = other.Content;
			}
			this.xboxBlockedPlayerIds_.Add(other.xboxBlockedPlayerIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06013148 RID: 78152 RVA: 0x002C8246 File Offset: 0x002C6446
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06013149 RID: 78153 RVA: 0x002C8250 File Offset: 0x002C6450
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
				if (num <= 64U)
				{
					if (num == 24U)
					{
						this.ChatContentType = (ChatContentType)input.ReadEnum();
						continue;
					}
					if (num == 64U)
					{
						goto IL_4B;
					}
				}
				else
				{
					if (num == 66U)
					{
						goto IL_4B;
					}
					if (num == 72U)
					{
						this.TargetUID = input.ReadInt32();
						continue;
					}
					if (num == 98U)
					{
						this.Content = input.ReadString();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				continue;
				IL_4B:
				this.xboxBlockedPlayerIds_.AddEntriesFrom(ref input, PrivateChatRequest._repeated_xboxBlockedPlayerIds_codec);
			}
		}

		// Token: 0x0400760B RID: 30219
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400760C RID: 30220
		public const int TargetUIDFieldNumber = 9;

		// Token: 0x0400760D RID: 30221
		private int targetUID_;

		// Token: 0x0400760E RID: 30222
		public const int ChatContentTypeFieldNumber = 3;

		// Token: 0x0400760F RID: 30223
		private ChatContentType chatContentType_;

		// Token: 0x04007610 RID: 30224
		public const int ContentFieldNumber = 12;

		// Token: 0x04007611 RID: 30225
		private string content_ = "";

		// Token: 0x04007612 RID: 30226
		public const int XboxBlockedPlayerIdsFieldNumber = 8;

		// Token: 0x04007613 RID: 30227
		private static readonly FieldCodec<int> _repeated_xboxBlockedPlayerIds_codec = FieldCodec.ForInt32(66U);

		// Token: 0x04007614 RID: 30228
		private readonly RepeatedField<int> xboxBlockedPlayerIds_ = new RepeatedField<int>();
	}
}
