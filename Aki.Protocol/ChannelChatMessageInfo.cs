using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200026E RID: 622
	public sealed class ChannelChatMessageInfo : IMessage<ChannelChatMessageInfo>, IMessage, IEquatable<ChannelChatMessageInfo>, IDeepCloneable<ChannelChatMessageInfo>, IBufferMessage
	{
		// Token: 0x060041BC RID: 16828 RVA: 0x000A16DF File Offset: 0x0009F8DF
		[NullableContext(1)]
		public static ChannelChatMessageInfo Create()
		{
			return new ChannelChatMessageInfo();
		}

		// Token: 0x17000B15 RID: 2837
		// (get) Token: 0x060041BD RID: 16829 RVA: 0x000A16E6 File Offset: 0x0009F8E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ChannelChatMessageInfo> Parser
		{
			get
			{
				return ChannelChatMessageInfo._parser;
			}
		}

		// Token: 0x17000B16 RID: 2838
		// (get) Token: 0x060041BE RID: 16830 RVA: 0x000A16ED File Offset: 0x0009F8ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000B17 RID: 2839
		// (get) Token: 0x060041BF RID: 16831 RVA: 0x000A16F0 File Offset: 0x0009F8F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ChannelChatMessageInfo.Descriptor;
			}
		}

		// Token: 0x060041C0 RID: 16832 RVA: 0x000A16F8 File Offset: 0x0009F8F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChannelChatMessageInfo()
		{
		}

		// Token: 0x060041C1 RID: 16833 RVA: 0x000A1750 File Offset: 0x0009F950
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

		// Token: 0x060041C2 RID: 16834 RVA: 0x000A1810 File Offset: 0x0009FA10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChannelChatMessageInfo Clone()
		{
			return new ChannelChatMessageInfo(this);
		}

		// Token: 0x17000B18 RID: 2840
		// (get) Token: 0x060041C3 RID: 16835 RVA: 0x000A1818 File Offset: 0x0009FA18
		// (set) Token: 0x060041C4 RID: 16836 RVA: 0x000A1820 File Offset: 0x0009FA20
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

		// Token: 0x17000B19 RID: 2841
		// (get) Token: 0x060041C5 RID: 16837 RVA: 0x000A1829 File Offset: 0x0009FA29
		// (set) Token: 0x060041C6 RID: 16838 RVA: 0x000A1831 File Offset: 0x0009FA31
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

		// Token: 0x17000B1A RID: 2842
		// (get) Token: 0x060041C7 RID: 16839 RVA: 0x000A183A File Offset: 0x0009FA3A
		// (set) Token: 0x060041C8 RID: 16840 RVA: 0x000A1842 File Offset: 0x0009FA42
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

		// Token: 0x17000B1B RID: 2843
		// (get) Token: 0x060041C9 RID: 16841 RVA: 0x000A1855 File Offset: 0x0009FA55
		// (set) Token: 0x060041CA RID: 16842 RVA: 0x000A185D File Offset: 0x0009FA5D
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

		// Token: 0x17000B1C RID: 2844
		// (get) Token: 0x060041CB RID: 16843 RVA: 0x000A1866 File Offset: 0x0009FA66
		// (set) Token: 0x060041CC RID: 16844 RVA: 0x000A186E File Offset: 0x0009FA6E
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

		// Token: 0x17000B1D RID: 2845
		// (get) Token: 0x060041CD RID: 16845 RVA: 0x000A1881 File Offset: 0x0009FA81
		// (set) Token: 0x060041CE RID: 16846 RVA: 0x000A1889 File Offset: 0x0009FA89
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

		// Token: 0x17000B1E RID: 2846
		// (get) Token: 0x060041CF RID: 16847 RVA: 0x000A1892 File Offset: 0x0009FA92
		// (set) Token: 0x060041D0 RID: 16848 RVA: 0x000A189A File Offset: 0x0009FA9A
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

		// Token: 0x17000B1F RID: 2847
		// (get) Token: 0x060041D1 RID: 16849 RVA: 0x000A18A3 File Offset: 0x0009FAA3
		// (set) Token: 0x060041D2 RID: 16850 RVA: 0x000A18AB File Offset: 0x0009FAAB
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

		// Token: 0x17000B20 RID: 2848
		// (get) Token: 0x060041D3 RID: 16851 RVA: 0x000A18BE File Offset: 0x0009FABE
		// (set) Token: 0x060041D4 RID: 16852 RVA: 0x000A18C6 File Offset: 0x0009FAC6
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

		// Token: 0x17000B21 RID: 2849
		// (get) Token: 0x060041D5 RID: 16853 RVA: 0x000A18D9 File Offset: 0x0009FAD9
		// (set) Token: 0x060041D6 RID: 16854 RVA: 0x000A18E1 File Offset: 0x0009FAE1
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

		// Token: 0x17000B22 RID: 2850
		// (get) Token: 0x060041D7 RID: 16855 RVA: 0x000A18EA File Offset: 0x0009FAEA
		// (set) Token: 0x060041D8 RID: 16856 RVA: 0x000A18F2 File Offset: 0x0009FAF2
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

		// Token: 0x17000B23 RID: 2851
		// (get) Token: 0x060041D9 RID: 16857 RVA: 0x000A18FB File Offset: 0x0009FAFB
		// (set) Token: 0x060041DA RID: 16858 RVA: 0x000A1903 File Offset: 0x0009FB03
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

		// Token: 0x17000B24 RID: 2852
		// (get) Token: 0x060041DB RID: 16859 RVA: 0x000A1916 File Offset: 0x0009FB16
		// (set) Token: 0x060041DC RID: 16860 RVA: 0x000A191E File Offset: 0x0009FB1E
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

		// Token: 0x060041DD RID: 16861 RVA: 0x000A1931 File Offset: 0x0009FB31
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ChannelChatMessageInfo);
		}

		// Token: 0x060041DE RID: 16862 RVA: 0x000A1940 File Offset: 0x0009FB40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ChannelChatMessageInfo other)
		{
			return other != null && (other == this || (this.SenderId == other.SenderId && this.SenderIcon == other.SenderIcon && !(this.SenderName != other.SenderName) && this.ChatContentType == other.ChatContentType && !(this.Content != other.Content) && this.NoticeType == other.NoticeType && this.SendTime == other.SendTime && !(this.SenderPsnOnlineId != other.SenderPsnOnlineId) && !(this.SenderPsnAccountId != other.SenderPsnAccountId) && this.TitleId == other.TitleId && this.TitleExtraParam == other.TitleExtraParam && !(this.SenderXboxOnlineId != other.SenderXboxOnlineId) && !(this.SenderXboxAccountId != other.SenderXboxAccountId) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060041DF RID: 16863 RVA: 0x000A1A58 File Offset: 0x0009FC58
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

		// Token: 0x060041E0 RID: 16864 RVA: 0x000A1BDC File Offset: 0x0009FDDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060041E1 RID: 16865 RVA: 0x000A1BE9 File Offset: 0x0009FDE9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060041E2 RID: 16866 RVA: 0x000A1BF4 File Offset: 0x0009FDF4
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

		// Token: 0x060041E3 RID: 16867 RVA: 0x000A1DA0 File Offset: 0x0009FFA0
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

		// Token: 0x060041E4 RID: 16868 RVA: 0x000A1F1C File Offset: 0x000A011C
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

		// Token: 0x060041E5 RID: 16869 RVA: 0x000A2066 File Offset: 0x000A0266
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060041E6 RID: 16870 RVA: 0x000A2070 File Offset: 0x000A0270
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

		// Token: 0x04002E13 RID: 11795
		private static readonly MessageParser<ChannelChatMessageInfo> _parser = new MessageParser<ChannelChatMessageInfo>(() => new ChannelChatMessageInfo());

		// Token: 0x04002E14 RID: 11796
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002E15 RID: 11797
		public const int SenderIdFieldNumber = 1;

		// Token: 0x04002E16 RID: 11798
		private int senderId_;

		// Token: 0x04002E17 RID: 11799
		public const int SenderIconFieldNumber = 2;

		// Token: 0x04002E18 RID: 11800
		private int senderIcon_;

		// Token: 0x04002E19 RID: 11801
		public const int SenderNameFieldNumber = 3;

		// Token: 0x04002E1A RID: 11802
		private string senderName_ = "";

		// Token: 0x04002E1B RID: 11803
		public const int ChatContentTypeFieldNumber = 4;

		// Token: 0x04002E1C RID: 11804
		private ChatContentType chatContentType_;

		// Token: 0x04002E1D RID: 11805
		public const int ContentFieldNumber = 5;

		// Token: 0x04002E1E RID: 11806
		private string content_ = "";

		// Token: 0x04002E1F RID: 11807
		public const int NoticeTypeFieldNumber = 6;

		// Token: 0x04002E20 RID: 11808
		private ChatChannelNoticeType noticeType_;

		// Token: 0x04002E21 RID: 11809
		public const int SendTimeFieldNumber = 7;

		// Token: 0x04002E22 RID: 11810
		private long sendTime_;

		// Token: 0x04002E23 RID: 11811
		public const int SenderPsnOnlineIdFieldNumber = 8;

		// Token: 0x04002E24 RID: 11812
		private string senderPsnOnlineId_ = "";

		// Token: 0x04002E25 RID: 11813
		public const int SenderPsnAccountIdFieldNumber = 9;

		// Token: 0x04002E26 RID: 11814
		private string senderPsnAccountId_ = "";

		// Token: 0x04002E27 RID: 11815
		public const int TitleIdFieldNumber = 10;

		// Token: 0x04002E28 RID: 11816
		private int titleId_;

		// Token: 0x04002E29 RID: 11817
		public const int TitleExtraParamFieldNumber = 11;

		// Token: 0x04002E2A RID: 11818
		private int titleExtraParam_;

		// Token: 0x04002E2B RID: 11819
		public const int SenderXboxOnlineIdFieldNumber = 12;

		// Token: 0x04002E2C RID: 11820
		private string senderXboxOnlineId_ = "";

		// Token: 0x04002E2D RID: 11821
		public const int SenderXboxAccountIdFieldNumber = 13;

		// Token: 0x04002E2E RID: 11822
		private string senderXboxAccountId_ = "";
	}
}
