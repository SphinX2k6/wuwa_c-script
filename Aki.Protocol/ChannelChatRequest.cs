using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200026B RID: 619
	[NetMessage(EMessageId.ChannelChatRequest)]
	public sealed class ChannelChatRequest : IMessage<ChannelChatRequest>, IMessage, IEquatable<ChannelChatRequest>, IDeepCloneable<ChannelChatRequest>, IBufferMessage
	{
		// Token: 0x06004157 RID: 16727 RVA: 0x000A08D6 File Offset: 0x0009EAD6
		[NullableContext(1)]
		public static ChannelChatRequest Create()
		{
			return new ChannelChatRequest();
		}

		// Token: 0x17000B0A RID: 2826
		// (get) Token: 0x06004158 RID: 16728 RVA: 0x000A08DD File Offset: 0x0009EADD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000B0B RID: 2827
		// (get) Token: 0x06004159 RID: 16729 RVA: 0x000A08E0 File Offset: 0x0009EAE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ChannelChatRequest.Descriptor;
			}
		}

		// Token: 0x0600415A RID: 16730 RVA: 0x000A08E7 File Offset: 0x0009EAE7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChannelChatRequest()
		{
		}

		// Token: 0x0600415B RID: 16731 RVA: 0x000A0908 File Offset: 0x0009EB08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChannelChatRequest(ChannelChatRequest other) : this()
		{
			this.channelType_ = other.channelType_;
			this.subChannelType_ = other.subChannelType_;
			this.chatContentType_ = other.chatContentType_;
			this.content_ = other.content_;
			this.xboxBlockedPlayerIds_ = other.xboxBlockedPlayerIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600415C RID: 16732 RVA: 0x000A096D File Offset: 0x0009EB6D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChannelChatRequest Clone()
		{
			return new ChannelChatRequest(this);
		}

		// Token: 0x17000B0C RID: 2828
		// (get) Token: 0x0600415D RID: 16733 RVA: 0x000A0975 File Offset: 0x0009EB75
		// (set) Token: 0x0600415E RID: 16734 RVA: 0x000A097D File Offset: 0x0009EB7D
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

		// Token: 0x17000B0D RID: 2829
		// (get) Token: 0x0600415F RID: 16735 RVA: 0x000A0986 File Offset: 0x0009EB86
		// (set) Token: 0x06004160 RID: 16736 RVA: 0x000A098E File Offset: 0x0009EB8E
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

		// Token: 0x17000B0E RID: 2830
		// (get) Token: 0x06004161 RID: 16737 RVA: 0x000A0997 File Offset: 0x0009EB97
		// (set) Token: 0x06004162 RID: 16738 RVA: 0x000A099F File Offset: 0x0009EB9F
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

		// Token: 0x17000B0F RID: 2831
		// (get) Token: 0x06004163 RID: 16739 RVA: 0x000A09A8 File Offset: 0x0009EBA8
		// (set) Token: 0x06004164 RID: 16740 RVA: 0x000A09B0 File Offset: 0x0009EBB0
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

		// Token: 0x17000B10 RID: 2832
		// (get) Token: 0x06004165 RID: 16741 RVA: 0x000A09C3 File Offset: 0x0009EBC3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> XboxBlockedPlayerIds
		{
			get
			{
				return this.xboxBlockedPlayerIds_;
			}
		}

		// Token: 0x06004166 RID: 16742 RVA: 0x000A09CB File Offset: 0x0009EBCB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ChannelChatRequest);
		}

		// Token: 0x06004167 RID: 16743 RVA: 0x000A09DC File Offset: 0x0009EBDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ChannelChatRequest other)
		{
			return other != null && (other == this || (this.ChannelType == other.ChannelType && this.SubChannelType == other.SubChannelType && this.ChatContentType == other.ChatContentType && !(this.Content != other.Content) && this.xboxBlockedPlayerIds_.Equals(other.xboxBlockedPlayerIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004168 RID: 16744 RVA: 0x000A0A60 File Offset: 0x0009EC60
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

		// Token: 0x06004169 RID: 16745 RVA: 0x000A0B0C File Offset: 0x0009ED0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600416A RID: 16746 RVA: 0x000A0B19 File Offset: 0x0009ED19
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600416B RID: 16747 RVA: 0x000A0B24 File Offset: 0x0009ED24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SubChannelType != SubChatChannelType.WorldTeam)
			{
				output.WriteRawTag(64);
				output.WriteEnum((int)this.SubChannelType);
			}
			if (this.ChannelType != ChatChannelType.Default)
			{
				output.WriteRawTag(72);
				output.WriteEnum((int)this.ChannelType);
			}
			this.xboxBlockedPlayerIds_.WriteTo(ref output, ChannelChatRequest._repeated_xboxBlockedPlayerIds_codec);
			if (this.ChatContentType != ChatContentType.Text)
			{
				output.WriteRawTag(104);
				output.WriteEnum((int)this.ChatContentType);
			}
			if (this.Content.Length != 0)
			{
				output.WriteRawTag(114);
				output.WriteString(this.Content);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600416C RID: 16748 RVA: 0x000A0BCC File Offset: 0x0009EDCC
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
			if (this.ChatContentType != ChatContentType.Text)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ChatContentType);
			}
			if (this.Content.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Content);
			}
			num += this.xboxBlockedPlayerIds_.CalculateSize(ChannelChatRequest._repeated_xboxBlockedPlayerIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600416D RID: 16749 RVA: 0x000A0C6C File Offset: 0x0009EE6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ChannelChatRequest other)
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

		// Token: 0x0600416E RID: 16750 RVA: 0x000A0CFA File Offset: 0x0009EEFA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600416F RID: 16751 RVA: 0x000A0D04 File Offset: 0x0009EF04
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
				if (num <= 96U)
				{
					if (num == 64U)
					{
						this.SubChannelType = (SubChatChannelType)input.ReadEnum();
						continue;
					}
					if (num == 72U)
					{
						this.ChannelType = (ChatChannelType)input.ReadEnum();
						continue;
					}
					if (num == 96U)
					{
						goto IL_61;
					}
				}
				else
				{
					if (num == 98U)
					{
						goto IL_61;
					}
					if (num == 104U)
					{
						this.ChatContentType = (ChatContentType)input.ReadEnum();
						continue;
					}
					if (num == 114U)
					{
						this.Content = input.ReadString();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				continue;
				IL_61:
				this.xboxBlockedPlayerIds_.AddEntriesFrom(ref input, ChannelChatRequest._repeated_xboxBlockedPlayerIds_codec);
			}
		}

		// Token: 0x04002DB2 RID: 11698
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002DB3 RID: 11699
		public const int ChannelTypeFieldNumber = 9;

		// Token: 0x04002DB4 RID: 11700
		private ChatChannelType channelType_;

		// Token: 0x04002DB5 RID: 11701
		public const int SubChannelTypeFieldNumber = 8;

		// Token: 0x04002DB6 RID: 11702
		private SubChatChannelType subChannelType_;

		// Token: 0x04002DB7 RID: 11703
		public const int ChatContentTypeFieldNumber = 13;

		// Token: 0x04002DB8 RID: 11704
		private ChatContentType chatContentType_;

		// Token: 0x04002DB9 RID: 11705
		public const int ContentFieldNumber = 14;

		// Token: 0x04002DBA RID: 11706
		private string content_ = "";

		// Token: 0x04002DBB RID: 11707
		public const int XboxBlockedPlayerIdsFieldNumber = 12;

		// Token: 0x04002DBC RID: 11708
		private static readonly FieldCodec<int> _repeated_xboxBlockedPlayerIds_codec = FieldCodec.ForInt32(98U);

		// Token: 0x04002DBD RID: 11709
		private readonly RepeatedField<int> xboxBlockedPlayerIds_ = new RepeatedField<int>();
	}
}
