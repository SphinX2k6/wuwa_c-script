using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F1F RID: 3871
	[NetMessage(EMessageId.ReportPlayerRequest)]
	public sealed class ReportPlayerRequest : IMessage<ReportPlayerRequest>, IMessage, IEquatable<ReportPlayerRequest>, IDeepCloneable<ReportPlayerRequest>, IBufferMessage
	{
		// Token: 0x06014B7A RID: 84858 RVA: 0x00301965 File Offset: 0x002FFB65
		[NullableContext(1)]
		public static ReportPlayerRequest Create()
		{
			return new ReportPlayerRequest();
		}

		// Token: 0x170044DA RID: 17626
		// (get) Token: 0x06014B7B RID: 84859 RVA: 0x0030196C File Offset: 0x002FFB6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170044DB RID: 17627
		// (get) Token: 0x06014B7C RID: 84860 RVA: 0x0030196F File Offset: 0x002FFB6F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ReportPlayerRequest.Descriptor;
			}
		}

		// Token: 0x06014B7D RID: 84861 RVA: 0x00301976 File Offset: 0x002FFB76
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ReportPlayerRequest()
		{
		}

		// Token: 0x06014B7E RID: 84862 RVA: 0x0030198C File Offset: 0x002FFB8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ReportPlayerRequest(ReportPlayerRequest other) : this()
		{
			this.targetPlayerId_ = other.targetPlayerId_;
			this.chatInfo_ = ((other.chatInfo_ != null) ? other.chatInfo_.Clone() : null);
			this.reportReason_ = other.reportReason_;
			this.reportMessage_ = other.reportMessage_;
			this.reportSource_ = other.reportSource_;
			this.targetInfo_ = ((other.targetInfo_ != null) ? other.targetInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06014B7F RID: 84863 RVA: 0x00301A18 File Offset: 0x002FFC18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ReportPlayerRequest Clone()
		{
			return new ReportPlayerRequest(this);
		}

		// Token: 0x170044DC RID: 17628
		// (get) Token: 0x06014B80 RID: 84864 RVA: 0x00301A20 File Offset: 0x002FFC20
		// (set) Token: 0x06014B81 RID: 84865 RVA: 0x00301A28 File Offset: 0x002FFC28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TargetPlayerId
		{
			get
			{
				return this.targetPlayerId_;
			}
			set
			{
				this.targetPlayerId_ = value;
			}
		}

		// Token: 0x170044DD RID: 17629
		// (get) Token: 0x06014B82 RID: 84866 RVA: 0x00301A31 File Offset: 0x002FFC31
		// (set) Token: 0x06014B83 RID: 84867 RVA: 0x00301A39 File Offset: 0x002FFC39
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ReportChatInfo ChatInfo
		{
			get
			{
				return this.chatInfo_;
			}
			set
			{
				this.chatInfo_ = value;
			}
		}

		// Token: 0x170044DE RID: 17630
		// (get) Token: 0x06014B84 RID: 84868 RVA: 0x00301A42 File Offset: 0x002FFC42
		// (set) Token: 0x06014B85 RID: 84869 RVA: 0x00301A4A File Offset: 0x002FFC4A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ReportReason
		{
			get
			{
				return this.reportReason_;
			}
			set
			{
				this.reportReason_ = value;
			}
		}

		// Token: 0x170044DF RID: 17631
		// (get) Token: 0x06014B86 RID: 84870 RVA: 0x00301A53 File Offset: 0x002FFC53
		// (set) Token: 0x06014B87 RID: 84871 RVA: 0x00301A5B File Offset: 0x002FFC5B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string ReportMessage
		{
			get
			{
				return this.reportMessage_;
			}
			set
			{
				this.reportMessage_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x170044E0 RID: 17632
		// (get) Token: 0x06014B88 RID: 84872 RVA: 0x00301A6E File Offset: 0x002FFC6E
		// (set) Token: 0x06014B89 RID: 84873 RVA: 0x00301A76 File Offset: 0x002FFC76
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ReportSource
		{
			get
			{
				return this.reportSource_;
			}
			set
			{
				this.reportSource_ = value;
			}
		}

		// Token: 0x170044E1 RID: 17633
		// (get) Token: 0x06014B8A RID: 84874 RVA: 0x00301A7F File Offset: 0x002FFC7F
		// (set) Token: 0x06014B8B RID: 84875 RVA: 0x00301A87 File Offset: 0x002FFC87
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ReportTargetInfo TargetInfo
		{
			get
			{
				return this.targetInfo_;
			}
			set
			{
				this.targetInfo_ = value;
			}
		}

		// Token: 0x06014B8C RID: 84876 RVA: 0x00301A90 File Offset: 0x002FFC90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ReportPlayerRequest);
		}

		// Token: 0x06014B8D RID: 84877 RVA: 0x00301AA0 File Offset: 0x002FFCA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ReportPlayerRequest other)
		{
			return other != null && (other == this || (this.TargetPlayerId == other.TargetPlayerId && object.Equals(this.ChatInfo, other.ChatInfo) && this.ReportReason == other.ReportReason && !(this.ReportMessage != other.ReportMessage) && this.ReportSource == other.ReportSource && object.Equals(this.TargetInfo, other.TargetInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06014B8E RID: 84878 RVA: 0x00301B38 File Offset: 0x002FFD38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.TargetPlayerId != 0)
			{
				num ^= this.TargetPlayerId.GetHashCode();
			}
			if (this.chatInfo_ != null)
			{
				num ^= this.ChatInfo.GetHashCode();
			}
			if (this.ReportReason != 0)
			{
				num ^= this.ReportReason.GetHashCode();
			}
			if (this.ReportMessage.Length != 0)
			{
				num ^= this.ReportMessage.GetHashCode();
			}
			if (this.ReportSource != 0)
			{
				num ^= this.ReportSource.GetHashCode();
			}
			if (this.targetInfo_ != null)
			{
				num ^= this.TargetInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06014B8F RID: 84879 RVA: 0x00301BF0 File Offset: 0x002FFDF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06014B90 RID: 84880 RVA: 0x00301BFD File Offset: 0x002FFDFD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06014B91 RID: 84881 RVA: 0x00301C08 File Offset: 0x002FFE08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TargetPlayerId != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.TargetPlayerId);
			}
			if (this.targetInfo_ != null)
			{
				output.WriteRawTag(42);
				output.WriteMessage(this.TargetInfo);
			}
			if (this.ReportSource != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.ReportSource);
			}
			if (this.chatInfo_ != null)
			{
				output.WriteRawTag(90);
				output.WriteMessage(this.ChatInfo);
			}
			if (this.ReportReason != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.ReportReason);
			}
			if (this.ReportMessage.Length != 0)
			{
				output.WriteRawTag(106);
				output.WriteString(this.ReportMessage);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06014B92 RID: 84882 RVA: 0x00301CD8 File Offset: 0x002FFED8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.TargetPlayerId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TargetPlayerId);
			}
			if (this.chatInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ChatInfo);
			}
			if (this.ReportReason != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ReportReason);
			}
			if (this.ReportMessage.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.ReportMessage);
			}
			if (this.ReportSource != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ReportSource);
			}
			if (this.targetInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.TargetInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06014B93 RID: 84883 RVA: 0x00301D94 File Offset: 0x002FFF94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ReportPlayerRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.TargetPlayerId != 0)
			{
				this.TargetPlayerId = other.TargetPlayerId;
			}
			if (other.chatInfo_ != null)
			{
				if (this.chatInfo_ == null)
				{
					this.ChatInfo = new ReportChatInfo();
				}
				this.ChatInfo.MergeFrom(other.ChatInfo);
			}
			if (other.ReportReason != 0)
			{
				this.ReportReason = other.ReportReason;
			}
			if (other.ReportMessage.Length != 0)
			{
				this.ReportMessage = other.ReportMessage;
			}
			if (other.ReportSource != 0)
			{
				this.ReportSource = other.ReportSource;
			}
			if (other.targetInfo_ != null)
			{
				if (this.targetInfo_ == null)
				{
					this.TargetInfo = new ReportTargetInfo();
				}
				this.TargetInfo.MergeFrom(other.TargetInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06014B94 RID: 84884 RVA: 0x00301E69 File Offset: 0x00300069
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06014B95 RID: 84885 RVA: 0x00301E74 File Offset: 0x00300074
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
					if (num == 32U)
					{
						this.TargetPlayerId = input.ReadInt32();
						continue;
					}
					if (num == 42U)
					{
						if (this.targetInfo_ == null)
						{
							this.TargetInfo = new ReportTargetInfo();
						}
						input.ReadMessage(this.TargetInfo);
						continue;
					}
					if (num == 64U)
					{
						this.ReportSource = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 90U)
					{
						if (this.chatInfo_ == null)
						{
							this.ChatInfo = new ReportChatInfo();
						}
						input.ReadMessage(this.ChatInfo);
						continue;
					}
					if (num == 96U)
					{
						this.ReportReason = input.ReadInt32();
						continue;
					}
					if (num == 106U)
					{
						this.ReportMessage = input.ReadString();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04007D28 RID: 32040
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007D29 RID: 32041
		public const int TargetPlayerIdFieldNumber = 4;

		// Token: 0x04007D2A RID: 32042
		private int targetPlayerId_;

		// Token: 0x04007D2B RID: 32043
		public const int ChatInfoFieldNumber = 11;

		// Token: 0x04007D2C RID: 32044
		private ReportChatInfo chatInfo_;

		// Token: 0x04007D2D RID: 32045
		public const int ReportReasonFieldNumber = 12;

		// Token: 0x04007D2E RID: 32046
		private int reportReason_;

		// Token: 0x04007D2F RID: 32047
		public const int ReportMessageFieldNumber = 13;

		// Token: 0x04007D30 RID: 32048
		private string reportMessage_ = "";

		// Token: 0x04007D31 RID: 32049
		public const int ReportSourceFieldNumber = 8;

		// Token: 0x04007D32 RID: 32050
		private int reportSource_;

		// Token: 0x04007D33 RID: 32051
		public const int TargetInfoFieldNumber = 5;

		// Token: 0x04007D34 RID: 32052
		private ReportTargetInfo targetInfo_;
	}
}
