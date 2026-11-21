using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F0F RID: 3855
	[NetMessage(EMessageId.ReportPlayerRequest)]
	public sealed class ReportPlayerRequest : IMessage<ReportPlayerRequest>, IMessage, IEquatable<ReportPlayerRequest>, IDeepCloneable<ReportPlayerRequest>, IBufferMessage
	{
		// Token: 0x06014A95 RID: 84629 RVA: 0x003002A9 File Offset: 0x002FE4A9
		[NullableContext(1)]
		public static ReportPlayerRequest Create()
		{
			return new ReportPlayerRequest();
		}

		// Token: 0x170044B0 RID: 17584
		// (get) Token: 0x06014A96 RID: 84630 RVA: 0x003002B0 File Offset: 0x002FE4B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170044B1 RID: 17585
		// (get) Token: 0x06014A97 RID: 84631 RVA: 0x003002B3 File Offset: 0x002FE4B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ReportPlayerRequest.Descriptor;
			}
		}

		// Token: 0x06014A98 RID: 84632 RVA: 0x003002BA File Offset: 0x002FE4BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ReportPlayerRequest()
		{
		}

		// Token: 0x06014A99 RID: 84633 RVA: 0x003002D0 File Offset: 0x002FE4D0
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

		// Token: 0x06014A9A RID: 84634 RVA: 0x0030035C File Offset: 0x002FE55C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ReportPlayerRequest Clone()
		{
			return new ReportPlayerRequest(this);
		}

		// Token: 0x170044B2 RID: 17586
		// (get) Token: 0x06014A9B RID: 84635 RVA: 0x00300364 File Offset: 0x002FE564
		// (set) Token: 0x06014A9C RID: 84636 RVA: 0x0030036C File Offset: 0x002FE56C
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

		// Token: 0x170044B3 RID: 17587
		// (get) Token: 0x06014A9D RID: 84637 RVA: 0x00300375 File Offset: 0x002FE575
		// (set) Token: 0x06014A9E RID: 84638 RVA: 0x0030037D File Offset: 0x002FE57D
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

		// Token: 0x170044B4 RID: 17588
		// (get) Token: 0x06014A9F RID: 84639 RVA: 0x00300386 File Offset: 0x002FE586
		// (set) Token: 0x06014AA0 RID: 84640 RVA: 0x0030038E File Offset: 0x002FE58E
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

		// Token: 0x170044B5 RID: 17589
		// (get) Token: 0x06014AA1 RID: 84641 RVA: 0x00300397 File Offset: 0x002FE597
		// (set) Token: 0x06014AA2 RID: 84642 RVA: 0x0030039F File Offset: 0x002FE59F
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

		// Token: 0x170044B6 RID: 17590
		// (get) Token: 0x06014AA3 RID: 84643 RVA: 0x003003B2 File Offset: 0x002FE5B2
		// (set) Token: 0x06014AA4 RID: 84644 RVA: 0x003003BA File Offset: 0x002FE5BA
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

		// Token: 0x170044B7 RID: 17591
		// (get) Token: 0x06014AA5 RID: 84645 RVA: 0x003003C3 File Offset: 0x002FE5C3
		// (set) Token: 0x06014AA6 RID: 84646 RVA: 0x003003CB File Offset: 0x002FE5CB
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

		// Token: 0x06014AA7 RID: 84647 RVA: 0x003003D4 File Offset: 0x002FE5D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ReportPlayerRequest);
		}

		// Token: 0x06014AA8 RID: 84648 RVA: 0x003003E4 File Offset: 0x002FE5E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ReportPlayerRequest other)
		{
			return other != null && (other == this || (this.TargetPlayerId == other.TargetPlayerId && object.Equals(this.ChatInfo, other.ChatInfo) && this.ReportReason == other.ReportReason && !(this.ReportMessage != other.ReportMessage) && this.ReportSource == other.ReportSource && object.Equals(this.TargetInfo, other.TargetInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06014AA9 RID: 84649 RVA: 0x0030047C File Offset: 0x002FE67C
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

		// Token: 0x06014AAA RID: 84650 RVA: 0x00300534 File Offset: 0x002FE734
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06014AAB RID: 84651 RVA: 0x00300541 File Offset: 0x002FE741
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06014AAC RID: 84652 RVA: 0x0030054C File Offset: 0x002FE74C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.targetInfo_ != null)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.TargetInfo);
			}
			if (this.chatInfo_ != null)
			{
				output.WriteRawTag(58);
				output.WriteMessage(this.ChatInfo);
			}
			if (this.ReportMessage.Length != 0)
			{
				output.WriteRawTag(66);
				output.WriteString(this.ReportMessage);
			}
			if (this.TargetPlayerId != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.TargetPlayerId);
			}
			if (this.ReportSource != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.ReportSource);
			}
			if (this.ReportReason != 0)
			{
				output.WriteRawTag(120);
				output.WriteInt32(this.ReportReason);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06014AAD RID: 84653 RVA: 0x0030061C File Offset: 0x002FE81C
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

		// Token: 0x06014AAE RID: 84654 RVA: 0x003006D8 File Offset: 0x002FE8D8
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

		// Token: 0x06014AAF RID: 84655 RVA: 0x003007AD File Offset: 0x002FE9AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06014AB0 RID: 84656 RVA: 0x003007B8 File Offset: 0x002FE9B8
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
				if (num <= 66U)
				{
					if (num == 18U)
					{
						if (this.targetInfo_ == null)
						{
							this.TargetInfo = new ReportTargetInfo();
						}
						input.ReadMessage(this.TargetInfo);
						continue;
					}
					if (num == 58U)
					{
						if (this.chatInfo_ == null)
						{
							this.ChatInfo = new ReportChatInfo();
						}
						input.ReadMessage(this.ChatInfo);
						continue;
					}
					if (num == 66U)
					{
						this.ReportMessage = input.ReadString();
						continue;
					}
				}
				else
				{
					if (num == 72U)
					{
						this.TargetPlayerId = input.ReadInt32();
						continue;
					}
					if (num == 96U)
					{
						this.ReportSource = input.ReadInt32();
						continue;
					}
					if (num == 120U)
					{
						this.ReportReason = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04007D52 RID: 32082
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007D53 RID: 32083
		public const int TargetPlayerIdFieldNumber = 9;

		// Token: 0x04007D54 RID: 32084
		private int targetPlayerId_;

		// Token: 0x04007D55 RID: 32085
		public const int ChatInfoFieldNumber = 7;

		// Token: 0x04007D56 RID: 32086
		private ReportChatInfo chatInfo_;

		// Token: 0x04007D57 RID: 32087
		public const int ReportReasonFieldNumber = 15;

		// Token: 0x04007D58 RID: 32088
		private int reportReason_;

		// Token: 0x04007D59 RID: 32089
		public const int ReportMessageFieldNumber = 8;

		// Token: 0x04007D5A RID: 32090
		private string reportMessage_ = "";

		// Token: 0x04007D5B RID: 32091
		public const int ReportSourceFieldNumber = 12;

		// Token: 0x04007D5C RID: 32092
		private int reportSource_;

		// Token: 0x04007D5D RID: 32093
		public const int TargetInfoFieldNumber = 2;

		// Token: 0x04007D5E RID: 32094
		private ReportTargetInfo targetInfo_;
	}
}
