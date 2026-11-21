using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000270 RID: 624
	[NetMessage(EMessageId.ChannelChatRequest)]
	public sealed class ChannelChatRequest : IMessage<ChannelChatRequest>, IMessage, IEquatable<ChannelChatRequest>, IDeepCloneable<ChannelChatRequest>, IBufferMessage
	{
		// Token: 0x060041FE RID: 16894 RVA: 0x000A25A1 File Offset: 0x000A07A1
		[NullableContext(1)]
		public static ChannelChatRequest Create()
		{
			return new ChannelChatRequest();
		}

		// Token: 0x17000B2A RID: 2858
		// (get) Token: 0x060041FF RID: 16895 RVA: 0x000A25A8 File Offset: 0x000A07A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000B2B RID: 2859
		// (get) Token: 0x06004200 RID: 16896 RVA: 0x000A25AB File Offset: 0x000A07AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ChannelChatRequest.Descriptor;
			}
		}

		// Token: 0x06004201 RID: 16897 RVA: 0x000A25B2 File Offset: 0x000A07B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChannelChatRequest()
		{
		}

		// Token: 0x06004202 RID: 16898 RVA: 0x000A25D0 File Offset: 0x000A07D0
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

		// Token: 0x06004203 RID: 16899 RVA: 0x000A2635 File Offset: 0x000A0835
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChannelChatRequest Clone()
		{
			return new ChannelChatRequest(this);
		}

		// Token: 0x17000B2C RID: 2860
		// (get) Token: 0x06004204 RID: 16900 RVA: 0x000A263D File Offset: 0x000A083D
		// (set) Token: 0x06004205 RID: 16901 RVA: 0x000A2645 File Offset: 0x000A0845
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

		// Token: 0x17000B2D RID: 2861
		// (get) Token: 0x06004206 RID: 16902 RVA: 0x000A264E File Offset: 0x000A084E
		// (set) Token: 0x06004207 RID: 16903 RVA: 0x000A2656 File Offset: 0x000A0856
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

		// Token: 0x17000B2E RID: 2862
		// (get) Token: 0x06004208 RID: 16904 RVA: 0x000A265F File Offset: 0x000A085F
		// (set) Token: 0x06004209 RID: 16905 RVA: 0x000A2667 File Offset: 0x000A0867
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

		// Token: 0x17000B2F RID: 2863
		// (get) Token: 0x0600420A RID: 16906 RVA: 0x000A2670 File Offset: 0x000A0870
		// (set) Token: 0x0600420B RID: 16907 RVA: 0x000A2678 File Offset: 0x000A0878
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

		// Token: 0x17000B30 RID: 2864
		// (get) Token: 0x0600420C RID: 16908 RVA: 0x000A268B File Offset: 0x000A088B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> XboxBlockedPlayerIds
		{
			get
			{
				return this.xboxBlockedPlayerIds_;
			}
		}

		// Token: 0x0600420D RID: 16909 RVA: 0x000A2693 File Offset: 0x000A0893
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ChannelChatRequest);
		}

		// Token: 0x0600420E RID: 16910 RVA: 0x000A26A4 File Offset: 0x000A08A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ChannelChatRequest other)
		{
			return other != null && (other == this || (this.ChannelType == other.ChannelType && this.SubChannelType == other.SubChannelType && this.ChatContentType == other.ChatContentType && !(this.Content != other.Content) && this.xboxBlockedPlayerIds_.Equals(other.xboxBlockedPlayerIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600420F RID: 16911 RVA: 0x000A2728 File Offset: 0x000A0928
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

		// Token: 0x06004210 RID: 16912 RVA: 0x000A27D4 File Offset: 0x000A09D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06004211 RID: 16913 RVA: 0x000A27E1 File Offset: 0x000A09E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004212 RID: 16914 RVA: 0x000A27EC File Offset: 0x000A09EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SubChannelType != SubChatChannelType.WorldTeam)
			{
				output.WriteRawTag(16);
				output.WriteEnum((int)this.SubChannelType);
			}
			if (this.ChannelType != ChatChannelType.Default)
			{
				output.WriteRawTag(32);
				output.WriteEnum((int)this.ChannelType);
			}
			if (this.ChatContentType != ChatContentType.Text)
			{
				output.WriteRawTag(40);
				output.WriteEnum((int)this.ChatContentType);
			}
			if (this.Content.Length != 0)
			{
				output.WriteRawTag(98);
				output.WriteString(this.Content);
			}
			this.xboxBlockedPlayerIds_.WriteTo(ref output, ChannelChatRequest._repeated_xboxBlockedPlayerIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004213 RID: 16915 RVA: 0x000A2894 File Offset: 0x000A0A94
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

		// Token: 0x06004214 RID: 16916 RVA: 0x000A2934 File Offset: 0x000A0B34
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

		// Token: 0x06004215 RID: 16917 RVA: 0x000A29C2 File Offset: 0x000A0BC2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004216 RID: 16918 RVA: 0x000A29CC File Offset: 0x000A0BCC
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
				if (num <= 40U)
				{
					if (num == 16U)
					{
						this.SubChannelType = (SubChatChannelType)input.ReadEnum();
						continue;
					}
					if (num == 32U)
					{
						this.ChannelType = (ChatChannelType)input.ReadEnum();
						continue;
					}
					if (num == 40U)
					{
						this.ChatContentType = (ChatContentType)input.ReadEnum();
						continue;
					}
				}
				else
				{
					if (num == 98U)
					{
						this.Content = input.ReadString();
						continue;
					}
					if (num == 120U || num == 122U)
					{
						this.xboxBlockedPlayerIds_.AddEntriesFrom(ref input, ChannelChatRequest._repeated_xboxBlockedPlayerIds_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04002E36 RID: 11830
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002E37 RID: 11831
		public const int ChannelTypeFieldNumber = 4;

		// Token: 0x04002E38 RID: 11832
		private ChatChannelType channelType_;

		// Token: 0x04002E39 RID: 11833
		public const int SubChannelTypeFieldNumber = 2;

		// Token: 0x04002E3A RID: 11834
		private SubChatChannelType subChannelType_;

		// Token: 0x04002E3B RID: 11835
		public const int ChatContentTypeFieldNumber = 5;

		// Token: 0x04002E3C RID: 11836
		private ChatContentType chatContentType_;

		// Token: 0x04002E3D RID: 11837
		public const int ContentFieldNumber = 12;

		// Token: 0x04002E3E RID: 11838
		private string content_ = "";

		// Token: 0x04002E3F RID: 11839
		public const int XboxBlockedPlayerIdsFieldNumber = 15;

		// Token: 0x04002E40 RID: 11840
		private static readonly FieldCodec<int> _repeated_xboxBlockedPlayerIds_codec = FieldCodec.ForInt32(122U);

		// Token: 0x04002E41 RID: 11841
		private readonly RepeatedField<int> xboxBlockedPlayerIds_ = new RepeatedField<int>();
	}
}
