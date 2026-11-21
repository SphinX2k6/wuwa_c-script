using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200026F RID: 623
	[NetMessage(EMessageId.ChannelChatMessageNotify)]
	public sealed class ChannelChatMessageNotify : IMessage<ChannelChatMessageNotify>, IMessage, IEquatable<ChannelChatMessageNotify>, IDeepCloneable<ChannelChatMessageNotify>, IBufferMessage
	{
		// Token: 0x060041E8 RID: 16872 RVA: 0x000A2209 File Offset: 0x000A0409
		[NullableContext(1)]
		public static ChannelChatMessageNotify Create()
		{
			return new ChannelChatMessageNotify();
		}

		// Token: 0x17000B25 RID: 2853
		// (get) Token: 0x060041E9 RID: 16873 RVA: 0x000A2210 File Offset: 0x000A0410
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000B26 RID: 2854
		// (get) Token: 0x060041EA RID: 16874 RVA: 0x000A2213 File Offset: 0x000A0413
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ChannelChatMessageNotify.Descriptor;
			}
		}

		// Token: 0x060041EB RID: 16875 RVA: 0x000A221A File Offset: 0x000A041A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChannelChatMessageNotify()
		{
		}

		// Token: 0x060041EC RID: 16876 RVA: 0x000A2224 File Offset: 0x000A0424
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChannelChatMessageNotify(ChannelChatMessageNotify other) : this()
		{
			this.channelType_ = other.channelType_;
			this.subChannelType_ = other.subChannelType_;
			this.messageInfo_ = ((other.messageInfo_ != null) ? other.messageInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060041ED RID: 16877 RVA: 0x000A227C File Offset: 0x000A047C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChannelChatMessageNotify Clone()
		{
			return new ChannelChatMessageNotify(this);
		}

		// Token: 0x17000B27 RID: 2855
		// (get) Token: 0x060041EE RID: 16878 RVA: 0x000A2284 File Offset: 0x000A0484
		// (set) Token: 0x060041EF RID: 16879 RVA: 0x000A228C File Offset: 0x000A048C
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

		// Token: 0x17000B28 RID: 2856
		// (get) Token: 0x060041F0 RID: 16880 RVA: 0x000A2295 File Offset: 0x000A0495
		// (set) Token: 0x060041F1 RID: 16881 RVA: 0x000A229D File Offset: 0x000A049D
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

		// Token: 0x17000B29 RID: 2857
		// (get) Token: 0x060041F2 RID: 16882 RVA: 0x000A22A6 File Offset: 0x000A04A6
		// (set) Token: 0x060041F3 RID: 16883 RVA: 0x000A22AE File Offset: 0x000A04AE
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

		// Token: 0x060041F4 RID: 16884 RVA: 0x000A22B7 File Offset: 0x000A04B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ChannelChatMessageNotify);
		}

		// Token: 0x060041F5 RID: 16885 RVA: 0x000A22C8 File Offset: 0x000A04C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ChannelChatMessageNotify other)
		{
			return other != null && (other == this || (this.ChannelType == other.ChannelType && this.SubChannelType == other.SubChannelType && object.Equals(this.MessageInfo, other.MessageInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060041F6 RID: 16886 RVA: 0x000A2328 File Offset: 0x000A0528
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

		// Token: 0x060041F7 RID: 16887 RVA: 0x000A23A2 File Offset: 0x000A05A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060041F8 RID: 16888 RVA: 0x000A23AF File Offset: 0x000A05AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060041F9 RID: 16889 RVA: 0x000A23B8 File Offset: 0x000A05B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SubChannelType != SubChatChannelType.WorldTeam)
			{
				output.WriteRawTag(8);
				output.WriteEnum((int)this.SubChannelType);
			}
			if (this.ChannelType != ChatChannelType.Default)
			{
				output.WriteRawTag(16);
				output.WriteEnum((int)this.ChannelType);
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

		// Token: 0x060041FA RID: 16890 RVA: 0x000A242C File Offset: 0x000A062C
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

		// Token: 0x060041FB RID: 16891 RVA: 0x000A249C File Offset: 0x000A069C
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

		// Token: 0x060041FC RID: 16892 RVA: 0x000A2518 File Offset: 0x000A0718
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060041FD RID: 16893 RVA: 0x000A2524 File Offset: 0x000A0724
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
				if (num != 8U)
				{
					if (num != 16U)
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
						this.ChannelType = (ChatChannelType)input.ReadEnum();
					}
				}
				else
				{
					this.SubChannelType = (SubChatChannelType)input.ReadEnum();
				}
			}
		}

		// Token: 0x04002E2F RID: 11823
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002E30 RID: 11824
		public const int ChannelTypeFieldNumber = 2;

		// Token: 0x04002E31 RID: 11825
		private ChatChannelType channelType_;

		// Token: 0x04002E32 RID: 11826
		public const int SubChannelTypeFieldNumber = 1;

		// Token: 0x04002E33 RID: 11827
		private SubChatChannelType subChannelType_;

		// Token: 0x04002E34 RID: 11828
		public const int MessageInfoFieldNumber = 15;

		// Token: 0x04002E35 RID: 11829
		private ChannelChatMessageInfo messageInfo_;
	}
}
