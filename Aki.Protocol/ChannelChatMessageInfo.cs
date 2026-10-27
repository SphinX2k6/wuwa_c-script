using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000269 RID: 617
	public sealed class ChannelChatMessageInfo : IMessage<ChannelChatMessageInfo>, IMessage, IEquatable<ChannelChatMessageInfo>, IDeepCloneable<ChannelChatMessageInfo>, IBufferMessage
	{
		// Token: 0x06004115 RID: 16661 RVA: 0x0009FA0F File Offset: 0x0009DC0F
		[NullableContext(1)]
		public static ChannelChatMessageInfo Create()
		{
			return new ChannelChatMessageInfo();
		}

		// Token: 0x17000AF5 RID: 2805
		// (get) Token: 0x06004116 RID: 16662 RVA: 0x0009FA16 File Offset: 0x0009DC16
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ChannelChatMessageInfo> Parser
		{
			get
			{
				return ChannelChatMessageInfo._parser;
			}
		}

		// Token: 0x17000AF6 RID: 2806
		// (get) Token: 0x06004117 RID: 16663 RVA: 0x0009FA1D File Offset: 0x0009DC1D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000AF7 RID: 2807
		// (get) Token: 0x06004118 RID: 16664 RVA: 0x0009FA20 File Offset: 0x0009DC20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ChannelChatMessageInfo.Descriptor;
			}
		}

		// Token: 0x06004119 RID: 16665 RVA: 0x0009FA28 File Offset: 0x0009DC28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChannelChatMessageInfo()
		{
		}

		// Token: 0x0600411A RID: 16666 RVA: 0x0009FA80 File Offset: 0x0009DC80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChannelChatMessageInfo(ChannelChatMessageInfo other) : this()
		{
			this.senderId_ = other.senderId_;
			this.senderIcon_ = other.senderIcon_;
			this.senderName_ = other.senderName_;
			this.chatContentType_ = other.chatContentType_;
			this.content_ = other.content_;
			this.noticeType_ = other.noticeType_;
			this.sendTime_ = other.sendTime_;
			this.senderPsnOnlineId_ = other.senderPsnOnlineId_;
			this.senderPsnAccountId_ = other.senderPsnAccountId_;
			this.titleId_ = other.titleId_;
			this.titleExtraParam_ = other.titleExtraParam_;
			this.senderXboxOnlineId_ = other.senderXboxOnlineId_;
			this.senderXboxAccountId_ = other.senderXboxAccountId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600411B RID: 16667 RVA: 0x0009FB40 File Offset: 0x0009DD40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChannelChatMessageInfo Clone()
		{
			return new ChannelChatMessageInfo(this);
		}

		// Token: 0x17000AF8 RID: 2808
		// (get) Token: 0x0600411C RID: 16668 RVA: 0x0009FB48 File Offset: 0x0009DD48
		// (set) Token: 0x0600411D RID: 16669 RVA: 0x0009FB50 File Offset: 0x0009DD50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SenderId
		{
			get
			{
				return this.senderId_;
			}
			set
			{
				this.senderId_ = value;
			}
		}

		// Token: 0x17000AF9 RID: 2809
		// (get) Token: 0x0600411E RID: 16670 RVA: 0x0009FB59 File Offset: 0x0009DD59
		// (set) Token: 0x0600411F RID: 16671 RVA: 0x0009FB61 File Offset: 0x0009DD61
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SenderIcon
		{
			get
			{
				return this.senderIcon_;
			}
			set
			{
				this.senderIcon_ = value;
			}
		}

		// Token: 0x17000AFA RID: 2810
		// (get) Token: 0x06004120 RID: 16672 RVA: 0x0009FB6A File Offset: 0x0009DD6A
		// (set) Token: 0x06004121 RID: 16673 RVA: 0x0009FB72 File Offset: 0x0009DD72
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string SenderName
		{
			get
			{
				return this.senderName_;
			}
			set
			{
				this.senderName_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17000AFB RID: 2811
		// (get) Token: 0x06004122 RID: 16674 RVA: 0x0009FB85 File Offset: 0x0009DD85
		// (set) Token: 0x06004123 RID: 16675 RVA: 0x0009FB8D File Offset: 0x0009DD8D
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

		// Token: 0x17000AFC RID: 2812
		// (get) Token: 0x06004124 RID: 16676 RVA: 0x0009FB96 File Offset: 0x0009DD96
		// (set) Token: 0x06004125 RID: 16677 RVA: 0x0009FB9E File Offset: 0x0009DD9E
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

		// Token: 0x17000AFD RID: 2813
		// (get) Token: 0x06004126 RID: 16678 RVA: 0x0009FBB1 File Offset: 0x0009DDB1
		// (set) Token: 0x06004127 RID: 16679 RVA: 0x0009FBB9 File Offset: 0x0009DDB9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChatChannelNoticeType NoticeType
		{
			get
			{
				return this.noticeType_;
			}
			set
			{
				this.noticeType_ = value;
			}
		}

		// Token: 0x17000AFE RID: 2814
		// (get) Token: 0x06004128 RID: 16680 RVA: 0x0009FBC2 File Offset: 0x0009DDC2
		// (set) Token: 0x06004129 RID: 16681 RVA: 0x0009FBCA File Offset: 0x0009DDCA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long SendTime
		{
			get
			{
				return this.sendTime_;
			}
			set
			{
				this.sendTime_ = value;
			}
		}

		// Token: 0x17000AFF RID: 2815
		// (get) Token: 0x0600412A RID: 16682 RVA: 0x0009FBD3 File Offset: 0x0009DDD3
		// (set) Token: 0x0600412B RID: 16683 RVA: 0x0009FBDB File Offset: 0x0009DDDB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string SenderPsnOnlineId
		{
			get
			{
				return this.senderPsnOnlineId_;
			}
			set
			{
				this.senderPsnOnlineId_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17000B00 RID: 2816
		// (get) Token: 0x0600412C RID: 16684 RVA: 0x0009FBEE File Offset: 0x0009DDEE
		// (set) Token: 0x0600412D RID: 16685 RVA: 0x0009FBF6 File Offset: 0x0009DDF6
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

		// Token: 0x17000B01 RID: 2817
		// (get) Token: 0x0600412E RID: 16686 RVA: 0x0009FC09 File Offset: 0x0009DE09
		// (set) Token: 0x0600412F RID: 16687 RVA: 0x0009FC11 File Offset: 0x0009DE11
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TitleId
		{
			get
			{
				return this.titleId_;
			}
			set
			{
				this.titleId_ = value;
			}
		}

		// Token: 0x17000B02 RID: 2818
		// (get) Token: 0x06004130 RID: 16688 RVA: 0x0009FC1A File Offset: 0x0009DE1A
		// (set) Token: 0x06004131 RID: 16689 RVA: 0x0009FC22 File Offset: 0x0009DE22
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TitleExtraParam
		{
			get
			{
				return this.titleExtraParam_;
			}
			set
			{
				this.titleExtraParam_ = value;
			}
		}

		// Token: 0x17000B03 RID: 2819
		// (get) Token: 0x06004132 RID: 16690 RVA: 0x0009FC2B File Offset: 0x0009DE2B
		// (set) Token: 0x06004133 RID: 16691 RVA: 0x0009FC33 File Offset: 0x0009DE33
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string SenderXboxOnlineId
		{
			get
			{
				return this.senderXboxOnlineId_;
			}
			set
			{
				this.senderXboxOnlineId_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17000B04 RID: 2820
		// (get) Token: 0x06004134 RID: 16692 RVA: 0x0009FC46 File Offset: 0x0009DE46
		// (set) Token: 0x06004135 RID: 16693 RVA: 0x0009FC4E File Offset: 0x0009DE4E
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

		// Token: 0x06004136 RID: 16694 RVA: 0x0009FC61 File Offset: 0x0009DE61
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ChannelChatMessageInfo);
		}

		// Token: 0x06004137 RID: 16695 RVA: 0x0009FC70 File Offset: 0x0009DE70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ChannelChatMessageInfo other)
		{
			return other != null && (other == this || (this.SenderId == other.SenderId && this.SenderIcon == other.SenderIcon && !(this.SenderName != other.SenderName) && this.ChatContentType == other.ChatContentType && !(this.Content != other.Content) && this.NoticeType == other.NoticeType && this.SendTime == other.SendTime && !(this.SenderPsnOnlineId != other.SenderPsnOnlineId) && !(this.SenderPsnAccountId != other.SenderPsnAccountId) && this.TitleId == other.TitleId && this.TitleExtraParam == other.TitleExtraParam && !(this.SenderXboxOnlineId != other.SenderXboxOnlineId) && !(this.SenderXboxAccountId != other.SenderXboxAccountId) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004138 RID: 16696 RVA: 0x0009FD88 File Offset: 0x0009DF88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.SenderId != 0)
			{
				num ^= this.SenderId.GetHashCode();
			}
			if (this.SenderIcon != 0)
			{
				num ^= this.SenderIcon.GetHashCode();
			}
			if (this.SenderName.Length != 0)
			{
				num ^= this.SenderName.GetHashCode();
			}
			if (this.ChatContentType != ChatContentType.Text)
			{
				num ^= this.ChatContentType.GetHashCode();
			}
			if (this.Content.Length != 0)
			{
				num ^= this.Content.GetHashCode();
			}
			if (this.NoticeType != ChatChannelNoticeType.None)
			{
				num ^= this.NoticeType.GetHashCode();
			}
			if (this.SendTime != 0L)
			{
				num ^= this.SendTime.GetHashCode();
			}
			if (this.SenderPsnOnlineId.Length != 0)
			{
				num ^= this.SenderPsnOnlineId.GetHashCode();
			}
			if (this.SenderPsnAccountId.Length != 0)
			{
				num ^= this.SenderPsnAccountId.GetHashCode();
			}
			if (this.TitleId != 0)
			{
				num ^= this.TitleId.GetHashCode();
			}
			if (this.TitleExtraParam != 0)
			{
				num ^= this.TitleExtraParam.GetHashCode();
			}
			if (this.SenderXboxOnlineId.Length != 0)
			{
				num ^= this.SenderXboxOnlineId.GetHashCode();
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

		// Token: 0x06004139 RID: 16697 RVA: 0x0009FF0C File Offset: 0x0009E10C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600413A RID: 16698 RVA: 0x0009FF19 File Offset: 0x0009E119
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600413B RID: 16699 RVA: 0x0009FF24 File Offset: 0x0009E124
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SenderId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.SenderId);
			}
			if (this.SenderIcon != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.SenderIcon);
			}
			if (this.SenderName.Length != 0)
			{
				output.WriteRawTag(26);
				output.WriteString(this.SenderName);
			}
			if (this.ChatContentType != ChatContentType.Text)
			{
				output.WriteRawTag(32);
				output.WriteEnum((int)this.ChatContentType);
			}
			if (this.Content.Length != 0)
			{
				output.WriteRawTag(42);
				output.WriteString(this.Content);
			}
			if (this.NoticeType != ChatChannelNoticeType.None)
			{
				output.WriteRawTag(48);
				output.WriteEnum((int)this.NoticeType);
			}
			if (this.SendTime != 0L)
			{
				output.WriteRawTag(56);
				output.WriteInt64(this.SendTime);
			}
			if (this.SenderPsnOnlineId.Length != 0)
			{
				output.WriteRawTag(66);
				output.WriteString(this.SenderPsnOnlineId);
			}
			if (this.SenderPsnAccountId.Length != 0)
			{
				output.WriteRawTag(74);
				output.WriteString(this.SenderPsnAccountId);
			}
			if (this.TitleId != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.TitleId);
			}
			if (this.TitleExtraParam != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.TitleExtraParam);
			}
			if (this.SenderXboxOnlineId.Length != 0)
			{
				output.WriteRawTag(98);
				output.WriteString(this.SenderXboxOnlineId);
			}
			if (this.SenderXboxAccountId.Length != 0)
			{
				output.WriteRawTag(106);
				output.WriteString(this.SenderXboxAccountId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600413C RID: 16700 RVA: 0x000A00D0 File Offset: 0x0009E2D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.SenderId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SenderId);
			}
			if (this.SenderIcon != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SenderIcon);
			}
			if (this.SenderName.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.SenderName);
			}
			if (this.ChatContentType != ChatContentType.Text)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ChatContentType);
			}
			if (this.Content.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Content);
			}
			if (this.NoticeType != ChatChannelNoticeType.None)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.NoticeType);
			}
			if (this.SendTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.SendTime);
			}
			if (this.SenderPsnOnlineId.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.SenderPsnOnlineId);
			}
			if (this.SenderPsnAccountId.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.SenderPsnAccountId);
			}
			if (this.TitleId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TitleId);
			}
			if (this.TitleExtraParam != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TitleExtraParam);
			}
			if (this.SenderXboxOnlineId.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.SenderXboxOnlineId);
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

		// Token: 0x0600413D RID: 16701 RVA: 0x000A024C File Offset: 0x0009E44C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ChannelChatMessageInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.SenderId != 0)
			{
				this.SenderId = other.SenderId;
			}
			if (other.SenderIcon != 0)
			{
				this.SenderIcon = other.SenderIcon;
			}
			if (other.SenderName.Length != 0)
			{
				this.SenderName = other.SenderName;
			}
			if (other.ChatContentType != ChatContentType.Text)
			{
				this.ChatContentType = other.ChatContentType;
			}
			if (other.Content.Length != 0)
			{
				this.Content = other.Content;
			}
			if (other.NoticeType != ChatChannelNoticeType.None)
			{
				this.NoticeType = other.NoticeType;
			}
			if (other.SendTime != 0L)
			{
				this.SendTime = other.SendTime;
			}
			if (other.SenderPsnOnlineId.Length != 0)
			{
				this.SenderPsnOnlineId = other.SenderPsnOnlineId;
			}
			if (other.SenderPsnAccountId.Length != 0)
			{
				this.SenderPsnAccountId = other.SenderPsnAccountId;
			}
			if (other.TitleId != 0)
			{
				this.TitleId = other.TitleId;
			}
			if (other.TitleExtraParam != 0)
			{
				this.TitleExtraParam = other.TitleExtraParam;
			}
			if (other.SenderXboxOnlineId.Length != 0)
			{
				this.SenderXboxOnlineId = other.SenderXboxOnlineId;
			}
			if (other.SenderXboxAccountId.Length != 0)
			{
				this.SenderXboxAccountId = other.SenderXboxAccountId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600413E RID: 16702 RVA: 0x000A0396 File Offset: 0x0009E596
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600413F RID: 16703 RVA: 0x000A03A0 File Offset: 0x0009E5A0
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
				if (num <= 48U)
				{
					if (num <= 26U)
					{
						if (num == 8U)
						{
							this.SenderId = input.ReadInt32();
							continue;
						}
						if (num == 16U)
						{
							this.SenderIcon = input.ReadInt32();
							continue;
						}
						if (num == 26U)
						{
							this.SenderName = input.ReadString();
							continue;
						}
					}
					else
					{
						if (num == 32U)
						{
							this.ChatContentType = (ChatContentType)input.ReadEnum();
							continue;
						}
						if (num == 42U)
						{
							this.Content = input.ReadString();
							continue;
						}
						if (num == 48U)
						{
							this.NoticeType = (ChatChannelNoticeType)input.ReadEnum();
							continue;
						}
					}
				}
				else if (num <= 74U)
				{
					if (num == 56U)
					{
						this.SendTime = input.ReadInt64();
						continue;
					}
					if (num == 66U)
					{
						this.SenderPsnOnlineId = input.ReadString();
						continue;
					}
					if (num == 74U)
					{
						this.SenderPsnAccountId = input.ReadString();
						continue;
					}
				}
				else if (num <= 88U)
				{
					if (num == 80U)
					{
						this.TitleId = input.ReadInt32();
						continue;
					}
					if (num == 88U)
					{
						this.TitleExtraParam = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 98U)
					{
						this.SenderXboxOnlineId = input.ReadString();
						continue;
					}
					if (num == 106U)
					{
						this.SenderXboxAccountId = input.ReadString();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04002D8F RID: 11663
		private static readonly MessageParser<ChannelChatMessageInfo> _parser = new MessageParser<ChannelChatMessageInfo>(() => new ChannelChatMessageInfo());

		// Token: 0x04002D90 RID: 11664
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002D91 RID: 11665
		public const int SenderIdFieldNumber = 1;

		// Token: 0x04002D92 RID: 11666
		private int senderId_;

		// Token: 0x04002D93 RID: 11667
		public const int SenderIconFieldNumber = 2;

		// Token: 0x04002D94 RID: 11668
		private int senderIcon_;

		// Token: 0x04002D95 RID: 11669
		public const int SenderNameFieldNumber = 3;

		// Token: 0x04002D96 RID: 11670
		private string senderName_ = "";

		// Token: 0x04002D97 RID: 11671
		public const int ChatContentTypeFieldNumber = 4;

		// Token: 0x04002D98 RID: 11672
		private ChatContentType chatContentType_;

		// Token: 0x04002D99 RID: 11673
		public const int ContentFieldNumber = 5;

		// Token: 0x04002D9A RID: 11674
		private string content_ = "";

		// Token: 0x04002D9B RID: 11675
		public const int NoticeTypeFieldNumber = 6;

		// Token: 0x04002D9C RID: 11676
		private ChatChannelNoticeType noticeType_;

		// Token: 0x04002D9D RID: 11677
		public const int SendTimeFieldNumber = 7;

		// Token: 0x04002D9E RID: 11678
		private long sendTime_;

		// Token: 0x04002D9F RID: 11679
		public const int SenderPsnOnlineIdFieldNumber = 8;

		// Token: 0x04002DA0 RID: 11680
		private string senderPsnOnlineId_ = "";

		// Token: 0x04002DA1 RID: 11681
		public const int SenderPsnAccountIdFieldNumber = 9;

		// Token: 0x04002DA2 RID: 11682
		private string senderPsnAccountId_ = "";

		// Token: 0x04002DA3 RID: 11683
		public const int TitleIdFieldNumber = 10;

		// Token: 0x04002DA4 RID: 11684
		private int titleId_;

		// Token: 0x04002DA5 RID: 11685
		public const int TitleExtraParamFieldNumber = 11;

		// Token: 0x04002DA6 RID: 11686
		private int titleExtraParam_;

		// Token: 0x04002DA7 RID: 11687
		public const int SenderXboxOnlineIdFieldNumber = 12;

		// Token: 0x04002DA8 RID: 11688
		private string senderXboxOnlineId_ = "";

		// Token: 0x04002DA9 RID: 11689
		public const int SenderXboxAccountIdFieldNumber = 13;

		// Token: 0x04002DAA RID: 11690
		private string senderXboxAccountId_ = "";
	}
}
