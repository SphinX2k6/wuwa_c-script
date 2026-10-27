using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200026A RID: 618
	[NetMessage(EMessageId.ChannelChatMessageNotify)]
	public sealed class ChannelChatMessageNotify : IMessage<ChannelChatMessageNotify>, IMessage, IEquatable<ChannelChatMessageNotify>, IDeepCloneable<ChannelChatMessageNotify>, IBufferMessage
	{
		// Token: 0x06004141 RID: 16705 RVA: 0x000A0539 File Offset: 0x0009E739
		[NullableContext(1)]
		public static ChannelChatMessageNotify Create()
		{
			return new ChannelChatMessageNotify();
		}

		// Token: 0x17000B05 RID: 2821
		// (get) Token: 0x06004142 RID: 16706 RVA: 0x000A0540 File Offset: 0x0009E740
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000B06 RID: 2822
		// (get) Token: 0x06004143 RID: 16707 RVA: 0x000A0543 File Offset: 0x0009E743
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ChannelChatMessageNotify.Descriptor;
			}
		}

		// Token: 0x06004144 RID: 16708 RVA: 0x000A054A File Offset: 0x0009E74A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChannelChatMessageNotify()
		{
		}

		// Token: 0x06004145 RID: 16709 RVA: 0x000A0554 File Offset: 0x0009E754
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChannelChatMessageNotify(ChannelChatMessageNotify other) : this()
		{
			this.channelType_ = other.channelType_;
			this.subChannelType_ = other.subChannelType_;
			this.messageInfo_ = ((other.messageInfo_ != null) ? other.messageInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004146 RID: 16710 RVA: 0x000A05AC File Offset: 0x0009E7AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChannelChatMessageNotify Clone()
		{
			return new ChannelChatMessageNotify(this);
		}

		// Token: 0x17000B07 RID: 2823
		// (get) Token: 0x06004147 RID: 16711 RVA: 0x000A05B4 File Offset: 0x0009E7B4
		// (set) Token: 0x06004148 RID: 16712 RVA: 0x000A05BC File Offset: 0x0009E7BC
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

		// Token: 0x17000B08 RID: 2824
		// (get) Token: 0x06004149 RID: 16713 RVA: 0x000A05C5 File Offset: 0x0009E7C5
		// (set) Token: 0x0600414A RID: 16714 RVA: 0x000A05CD File Offset: 0x0009E7CD
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

		// Token: 0x17000B09 RID: 2825
		// (get) Token: 0x0600414B RID: 16715 RVA: 0x000A05D6 File Offset: 0x0009E7D6
		// (set) Token: 0x0600414C RID: 16716 RVA: 0x000A05DE File Offset: 0x0009E7DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChannelChatMessageInfo MessageInfo
		{
			get
			{
				return this.messageInfo_;
			}
			set
			{
				this.messageInfo_ = value;
			}
		}

		// Token: 0x0600414D RID: 16717 RVA: 0x000A05E7 File Offset: 0x0009E7E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ChannelChatMessageNotify);
		}

		// Token: 0x0600414E RID: 16718 RVA: 0x000A05F8 File Offset: 0x0009E7F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ChannelChatMessageNotify other)
		{
			return other != null && (other == this || (this.ChannelType == other.ChannelType && this.SubChannelType == other.SubChannelType && object.Equals(this.MessageInfo, other.MessageInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600414F RID: 16719 RVA: 0x000A0658 File Offset: 0x0009E858
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
			if (this.messageInfo_ != null)
			{
				num ^= this.MessageInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06004150 RID: 16720 RVA: 0x000A06D2 File Offset: 0x0009E8D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06004151 RID: 16721 RVA: 0x000A06DF File Offset: 0x0009E8DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004152 RID: 16722 RVA: 0x000A06E8 File Offset: 0x0009E8E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ChannelType != ChatChannelType.Default)
			{
				output.WriteRawTag(56);
				output.WriteEnum((int)this.ChannelType);
			}
			if (this.SubChannelType != SubChatChannelType.WorldTeam)
			{
				output.WriteRawTag(104);
				output.WriteEnum((int)this.SubChannelType);
			}
			if (this.messageInfo_ != null)
			{
				output.WriteRawTag(122);
				output.WriteMessage(this.MessageInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004153 RID: 16723 RVA: 0x000A0760 File Offset: 0x0009E960
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
			if (this.messageInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.MessageInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06004154 RID: 16724 RVA: 0x000A07D0 File Offset: 0x0009E9D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ChannelChatMessageNotify other)
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
			if (other.messageInfo_ != null)
			{
				if (this.messageInfo_ == null)
				{
					this.MessageInfo = new ChannelChatMessageInfo();
				}
				this.MessageInfo.MergeFrom(other.MessageInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06004155 RID: 16725 RVA: 0x000A084C File Offset: 0x0009EA4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004156 RID: 16726 RVA: 0x000A0858 File Offset: 0x0009EA58
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
					if (num != 104U)
					{
						if (num != 122U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							if (this.messageInfo_ == null)
							{
								this.MessageInfo = new ChannelChatMessageInfo();
							}
							input.ReadMessage(this.MessageInfo);
						}
					}
					else
					{
						this.SubChannelType = (SubChatChannelType)input.ReadEnum();
					}
				}
				else
				{
					this.ChannelType = (ChatChannelType)input.ReadEnum();
				}
			}
		}

		// Token: 0x04002DAB RID: 11691
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002DAC RID: 11692
		public const int ChannelTypeFieldNumber = 7;

		// Token: 0x04002DAD RID: 11693
		private ChatChannelType channelType_;

		// Token: 0x04002DAE RID: 11694
		public const int SubChannelTypeFieldNumber = 13;

		// Token: 0x04002DAF RID: 11695
		private SubChatChannelType subChannelType_;

		// Token: 0x04002DB0 RID: 11696
		public const int MessageInfoFieldNumber = 15;

		// Token: 0x04002DB1 RID: 11697
		private ChannelChatMessageInfo messageInfo_;
	}
}
