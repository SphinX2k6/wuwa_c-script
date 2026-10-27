using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000268 RID: 616
	[NetMessage(EMessageId.ChannelChatHistoryNotify)]
	public sealed class ChannelChatHistoryNotify : IMessage<ChannelChatHistoryNotify>, IMessage, IEquatable<ChannelChatHistoryNotify>, IDeepCloneable<ChannelChatHistoryNotify>, IBufferMessage
	{
		// Token: 0x060040FF RID: 16639 RVA: 0x0009F6AC File Offset: 0x0009D8AC
		[NullableContext(1)]
		public static ChannelChatHistoryNotify Create()
		{
			return new ChannelChatHistoryNotify();
		}

		// Token: 0x17000AF0 RID: 2800
		// (get) Token: 0x06004100 RID: 16640 RVA: 0x0009F6B3 File Offset: 0x0009D8B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000AF1 RID: 2801
		// (get) Token: 0x06004101 RID: 16641 RVA: 0x0009F6B6 File Offset: 0x0009D8B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ChannelChatHistoryNotify.Descriptor;
			}
		}

		// Token: 0x06004102 RID: 16642 RVA: 0x0009F6BD File Offset: 0x0009D8BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChannelChatHistoryNotify()
		{
		}

		// Token: 0x06004103 RID: 16643 RVA: 0x0009F6D0 File Offset: 0x0009D8D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChannelChatHistoryNotify(ChannelChatHistoryNotify other) : this()
		{
			this.channelType_ = other.channelType_;
			this.subChannelType_ = other.subChannelType_;
			this.messageInfos_ = other.messageInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004104 RID: 16644 RVA: 0x0009F71D File Offset: 0x0009D91D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChannelChatHistoryNotify Clone()
		{
			return new ChannelChatHistoryNotify(this);
		}

		// Token: 0x17000AF2 RID: 2802
		// (get) Token: 0x06004105 RID: 16645 RVA: 0x0009F725 File Offset: 0x0009D925
		// (set) Token: 0x06004106 RID: 16646 RVA: 0x0009F72D File Offset: 0x0009D92D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChatChannelType ChannelType
		{
			get
			{
				return this.channelType_;
			}
			set
			{
				this.channelType_ = value;
			}
		}

		// Token: 0x17000AF3 RID: 2803
		// (get) Token: 0x06004107 RID: 16647 RVA: 0x0009F736 File Offset: 0x0009D936
		// (set) Token: 0x06004108 RID: 16648 RVA: 0x0009F73E File Offset: 0x0009D93E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SubChatChannelType SubChannelType
		{
			get
			{
				return this.subChannelType_;
			}
			set
			{
				this.subChannelType_ = value;
			}
		}

		// Token: 0x17000AF4 RID: 2804
		// (get) Token: 0x06004109 RID: 16649 RVA: 0x0009F747 File Offset: 0x0009D947
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ChannelChatMessageInfo> MessageInfos
		{
			get
			{
				return this.messageInfos_;
			}
		}

		// Token: 0x0600410A RID: 16650 RVA: 0x0009F74F File Offset: 0x0009D94F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ChannelChatHistoryNotify);
		}

		// Token: 0x0600410B RID: 16651 RVA: 0x0009F760 File Offset: 0x0009D960
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ChannelChatHistoryNotify other)
		{
			return other != null && (other == this || (this.ChannelType == other.ChannelType && this.SubChannelType == other.SubChannelType && this.messageInfos_.Equals(other.messageInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600410C RID: 16652 RVA: 0x0009F7C0 File Offset: 0x0009D9C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ChannelType != ChatChannelType.Default)
			{
				num ^= this.ChannelType.GetHashCode();
			}
			if (this.SubChannelType != SubChatChannelType.WorldTeam)
			{
				num ^= this.SubChannelType.GetHashCode();
			}
			num ^= this.messageInfos_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600410D RID: 16653 RVA: 0x0009F832 File Offset: 0x0009DA32
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600410E RID: 16654 RVA: 0x0009F83F File Offset: 0x0009DA3F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600410F RID: 16655 RVA: 0x0009F848 File Offset: 0x0009DA48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SubChannelType != SubChatChannelType.WorldTeam)
			{
				output.WriteRawTag(56);
				output.WriteEnum((int)this.SubChannelType);
			}
			if (this.ChannelType != ChatChannelType.Default)
			{
				output.WriteRawTag(64);
				output.WriteEnum((int)this.ChannelType);
			}
			this.messageInfos_.WriteTo(ref output, ChannelChatHistoryNotify._repeated_messageInfos_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004110 RID: 16656 RVA: 0x0009F8B4 File Offset: 0x0009DAB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ChannelType != ChatChannelType.Default)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ChannelType);
			}
			if (this.SubChannelType != SubChatChannelType.WorldTeam)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.SubChannelType);
			}
			num += this.messageInfos_.CalculateSize(ChannelChatHistoryNotify._repeated_messageInfos_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06004111 RID: 16657 RVA: 0x0009F920 File Offset: 0x0009DB20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ChannelChatHistoryNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ChannelType != ChatChannelType.Default)
			{
				this.ChannelType = other.ChannelType;
			}
			if (other.SubChannelType != SubChatChannelType.WorldTeam)
			{
				this.SubChannelType = other.SubChannelType;
			}
			this.messageInfos_.Add(other.messageInfos_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06004112 RID: 16658 RVA: 0x0009F981 File Offset: 0x0009DB81
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004113 RID: 16659 RVA: 0x0009F98C File Offset: 0x0009DB8C
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
				if (num != 56U)
				{
					if (num != 64U)
					{
						if (num != 98U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.messageInfos_.AddEntriesFrom(ref input, ChannelChatHistoryNotify._repeated_messageInfos_codec);
						}
					}
					else
					{
						this.ChannelType = (ChatChannelType)input.ReadEnum();
					}
				}
				else
				{
					this.SubChannelType = (SubChatChannelType)input.ReadEnum();
				}
			}
		}

		// Token: 0x04002D87 RID: 11655
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002D88 RID: 11656
		public const int ChannelTypeFieldNumber = 8;

		// Token: 0x04002D89 RID: 11657
		private ChatChannelType channelType_;

		// Token: 0x04002D8A RID: 11658
		public const int SubChannelTypeFieldNumber = 7;

		// Token: 0x04002D8B RID: 11659
		private SubChatChannelType subChannelType_;

		// Token: 0x04002D8C RID: 11660
		public const int MessageInfosFieldNumber = 12;

		// Token: 0x04002D8D RID: 11661
		private static readonly FieldCodec<ChannelChatMessageInfo> _repeated_messageInfos_codec = FieldCodec.ForMessage<ChannelChatMessageInfo>(98U, ChannelChatMessageInfo.Parser);

		// Token: 0x04002D8E RID: 11662
		private readonly RepeatedField<ChannelChatMessageInfo> messageInfos_ = new RepeatedField<ChannelChatMessageInfo>();
	}
}
