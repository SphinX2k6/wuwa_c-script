using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000DE4 RID: 3556
	[NetMessage(EMessageId.PrivateChatRequest)]
	public sealed class PrivateChatRequest : IMessage<PrivateChatRequest>, IMessage, IEquatable<PrivateChatRequest>, IDeepCloneable<PrivateChatRequest>, IBufferMessage
	{
		// Token: 0x06013218 RID: 78360 RVA: 0x002C9585 File Offset: 0x002C7785
		[NullableContext(1)]
		public static PrivateChatRequest Create()
		{
			return new PrivateChatRequest();
		}

		// Token: 0x17003F76 RID: 16246
		// (get) Token: 0x06013219 RID: 78361 RVA: 0x002C958C File Offset: 0x002C778C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003F77 RID: 16247
		// (get) Token: 0x0601321A RID: 78362 RVA: 0x002C958F File Offset: 0x002C778F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PrivateChatRequest.Descriptor;
			}
		}

		// Token: 0x0601321B RID: 78363 RVA: 0x002C9596 File Offset: 0x002C7796
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PrivateChatRequest()
		{
		}

		// Token: 0x0601321C RID: 78364 RVA: 0x002C95B4 File Offset: 0x002C77B4
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

		// Token: 0x0601321D RID: 78365 RVA: 0x002C960D File Offset: 0x002C780D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PrivateChatRequest Clone()
		{
			return new PrivateChatRequest(this);
		}

		// Token: 0x17003F78 RID: 16248
		// (get) Token: 0x0601321E RID: 78366 RVA: 0x002C9615 File Offset: 0x002C7815
		// (set) Token: 0x0601321F RID: 78367 RVA: 0x002C961D File Offset: 0x002C781D
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

		// Token: 0x17003F79 RID: 16249
		// (get) Token: 0x06013220 RID: 78368 RVA: 0x002C9626 File Offset: 0x002C7826
		// (set) Token: 0x06013221 RID: 78369 RVA: 0x002C962E File Offset: 0x002C782E
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

		// Token: 0x17003F7A RID: 16250
		// (get) Token: 0x06013222 RID: 78370 RVA: 0x002C9637 File Offset: 0x002C7837
		// (set) Token: 0x06013223 RID: 78371 RVA: 0x002C963F File Offset: 0x002C783F
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

		// Token: 0x17003F7B RID: 16251
		// (get) Token: 0x06013224 RID: 78372 RVA: 0x002C9652 File Offset: 0x002C7852
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> XboxBlockedPlayerIds
		{
			get
			{
				return this.xboxBlockedPlayerIds_;
			}
		}

		// Token: 0x06013225 RID: 78373 RVA: 0x002C965A File Offset: 0x002C785A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PrivateChatRequest);
		}

		// Token: 0x06013226 RID: 78374 RVA: 0x002C9668 File Offset: 0x002C7868
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PrivateChatRequest other)
		{
			return other != null && (other == this || (this.TargetUID == other.TargetUID && this.ChatContentType == other.ChatContentType && !(this.Content != other.Content) && this.xboxBlockedPlayerIds_.Equals(other.xboxBlockedPlayerIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06013227 RID: 78375 RVA: 0x002C96DC File Offset: 0x002C78DC
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

		// Token: 0x06013228 RID: 78376 RVA: 0x002C9763 File Offset: 0x002C7963
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06013229 RID: 78377 RVA: 0x002C9770 File Offset: 0x002C7970
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601322A RID: 78378 RVA: 0x002C977C File Offset: 0x002C797C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.xboxBlockedPlayerIds_.WriteTo(ref output, PrivateChatRequest._repeated_xboxBlockedPlayerIds_codec);
			if (this.TargetUID != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.TargetUID);
			}
			if (this.ChatContentType != ChatContentType.Text)
			{
				output.WriteRawTag(80);
				output.WriteEnum((int)this.ChatContentType);
			}
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

		// Token: 0x0601322B RID: 78379 RVA: 0x002C9808 File Offset: 0x002C7A08
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

		// Token: 0x0601322C RID: 78380 RVA: 0x002C9890 File Offset: 0x002C7A90
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

		// Token: 0x0601322D RID: 78381 RVA: 0x002C990A File Offset: 0x002C7B0A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601322E RID: 78382 RVA: 0x002C9914 File Offset: 0x002C7B14
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
				if (num <= 42U)
				{
					if (num == 40U || num == 42U)
					{
						this.xboxBlockedPlayerIds_.AddEntriesFrom(ref input, PrivateChatRequest._repeated_xboxBlockedPlayerIds_codec);
						continue;
					}
				}
				else
				{
					if (num == 64U)
					{
						this.TargetUID = input.ReadInt32();
						continue;
					}
					if (num == 80U)
					{
						this.ChatContentType = (ChatContentType)input.ReadEnum();
						continue;
					}
					if (num == 122U)
					{
						this.Content = input.ReadString();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040075E1 RID: 30177
		private UnknownFieldSet _unknownFields;

		// Token: 0x040075E2 RID: 30178
		public const int TargetUIDFieldNumber = 8;

		// Token: 0x040075E3 RID: 30179
		private int targetUID_;

		// Token: 0x040075E4 RID: 30180
		public const int ChatContentTypeFieldNumber = 10;

		// Token: 0x040075E5 RID: 30181
		private ChatContentType chatContentType_;

		// Token: 0x040075E6 RID: 30182
		public const int ContentFieldNumber = 15;

		// Token: 0x040075E7 RID: 30183
		private string content_ = "";

		// Token: 0x040075E8 RID: 30184
		public const int XboxBlockedPlayerIdsFieldNumber = 5;

		// Token: 0x040075E9 RID: 30185
		private static readonly FieldCodec<int> _repeated_xboxBlockedPlayerIds_codec = FieldCodec.ForInt32(42U);

		// Token: 0x040075EA RID: 30186
		private readonly RepeatedField<int> xboxBlockedPlayerIds_ = new RepeatedField<int>();
	}
}
