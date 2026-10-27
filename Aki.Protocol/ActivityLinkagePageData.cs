using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000088 RID: 136
	public sealed class ActivityLinkagePageData : IMessage<ActivityLinkagePageData>, IMessage, IEquatable<ActivityLinkagePageData>, IDeepCloneable<ActivityLinkagePageData>, IBufferMessage
	{
		// Token: 0x06001A59 RID: 6745 RVA: 0x0004A797 File Offset: 0x00048997
		[NullableContext(1)]
		public static ActivityLinkagePageData Create()
		{
			return new ActivityLinkagePageData();
		}

		// Token: 0x170002B7 RID: 695
		// (get) Token: 0x06001A5A RID: 6746 RVA: 0x0004A79E File Offset: 0x0004899E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ActivityLinkagePageData> Parser
		{
			get
			{
				return ActivityLinkagePageData._parser;
			}
		}

		// Token: 0x170002B8 RID: 696
		// (get) Token: 0x06001A5B RID: 6747 RVA: 0x0004A7A5 File Offset: 0x000489A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170002B9 RID: 697
		// (get) Token: 0x06001A5C RID: 6748 RVA: 0x0004A7A8 File Offset: 0x000489A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ActivityLinkagePageData.Descriptor;
			}
		}

		// Token: 0x06001A5D RID: 6749 RVA: 0x0004A7AF File Offset: 0x000489AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActivityLinkagePageData()
		{
		}

		// Token: 0x06001A5E RID: 6750 RVA: 0x0004A7C4 File Offset: 0x000489C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActivityLinkagePageData(ActivityLinkagePageData other) : this()
		{
			this.pageActivityId_ = other.pageActivityId_;
			this.endTime_ = other.endTime_;
			this.rewards_ = other.rewards_.Clone();
			this.receive_ = other.receive_;
			this.startTime_ = other.startTime_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001A5F RID: 6751 RVA: 0x0004A829 File Offset: 0x00048A29
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActivityLinkagePageData Clone()
		{
			return new ActivityLinkagePageData(this);
		}

		// Token: 0x170002BA RID: 698
		// (get) Token: 0x06001A60 RID: 6752 RVA: 0x0004A831 File Offset: 0x00048A31
		// (set) Token: 0x06001A61 RID: 6753 RVA: 0x0004A839 File Offset: 0x00048A39
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int PageActivityId
		{
			get
			{
				return this.pageActivityId_;
			}
			set
			{
				this.pageActivityId_ = value;
			}
		}

		// Token: 0x170002BB RID: 699
		// (get) Token: 0x06001A62 RID: 6754 RVA: 0x0004A842 File Offset: 0x00048A42
		// (set) Token: 0x06001A63 RID: 6755 RVA: 0x0004A84A File Offset: 0x00048A4A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long EndTime
		{
			get
			{
				return this.endTime_;
			}
			set
			{
				this.endTime_ = value;
			}
		}

		// Token: 0x170002BC RID: 700
		// (get) Token: 0x06001A64 RID: 6756 RVA: 0x0004A853 File Offset: 0x00048A53
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ActivityLinkageReward> Rewards
		{
			get
			{
				return this.rewards_;
			}
		}

		// Token: 0x170002BD RID: 701
		// (get) Token: 0x06001A65 RID: 6757 RVA: 0x0004A85B File Offset: 0x00048A5B
		// (set) Token: 0x06001A66 RID: 6758 RVA: 0x0004A863 File Offset: 0x00048A63
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Receive
		{
			get
			{
				return this.receive_;
			}
			set
			{
				this.receive_ = value;
			}
		}

		// Token: 0x170002BE RID: 702
		// (get) Token: 0x06001A67 RID: 6759 RVA: 0x0004A86C File Offset: 0x00048A6C
		// (set) Token: 0x06001A68 RID: 6760 RVA: 0x0004A874 File Offset: 0x00048A74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long StartTime
		{
			get
			{
				return this.startTime_;
			}
			set
			{
				this.startTime_ = value;
			}
		}

		// Token: 0x06001A69 RID: 6761 RVA: 0x0004A87D File Offset: 0x00048A7D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ActivityLinkagePageData);
		}

		// Token: 0x06001A6A RID: 6762 RVA: 0x0004A88C File Offset: 0x00048A8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ActivityLinkagePageData other)
		{
			return other != null && (other == this || (this.PageActivityId == other.PageActivityId && this.EndTime == other.EndTime && this.rewards_.Equals(other.rewards_) && this.Receive == other.Receive && this.StartTime == other.StartTime && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001A6B RID: 6763 RVA: 0x0004A90C File Offset: 0x00048B0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.PageActivityId != 0)
			{
				num ^= this.PageActivityId.GetHashCode();
			}
			if (this.EndTime != 0L)
			{
				num ^= this.EndTime.GetHashCode();
			}
			num ^= this.rewards_.GetHashCode();
			if (this.Receive)
			{
				num ^= this.Receive.GetHashCode();
			}
			if (this.StartTime != 0L)
			{
				num ^= this.StartTime.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06001A6C RID: 6764 RVA: 0x0004A9A4 File Offset: 0x00048BA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06001A6D RID: 6765 RVA: 0x0004A9B1 File Offset: 0x00048BB1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001A6E RID: 6766 RVA: 0x0004A9BC File Offset: 0x00048BBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.PageActivityId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.PageActivityId);
			}
			if (this.EndTime != 0L)
			{
				output.WriteRawTag(16);
				output.WriteInt64(this.EndTime);
			}
			this.rewards_.WriteTo(ref output, ActivityLinkagePageData._repeated_rewards_codec);
			if (this.Receive)
			{
				output.WriteRawTag(32);
				output.WriteBool(this.Receive);
			}
			if (this.StartTime != 0L)
			{
				output.WriteRawTag(40);
				output.WriteInt64(this.StartTime);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001A6F RID: 6767 RVA: 0x0004AA60 File Offset: 0x00048C60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.PageActivityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PageActivityId);
			}
			if (this.EndTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EndTime);
			}
			num += this.rewards_.CalculateSize(ActivityLinkagePageData._repeated_rewards_codec);
			if (this.Receive)
			{
				num += 2;
			}
			if (this.StartTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.StartTime);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06001A70 RID: 6768 RVA: 0x0004AAF0 File Offset: 0x00048CF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ActivityLinkagePageData other)
		{
			if (other == null)
			{
				return;
			}
			if (other.PageActivityId != 0)
			{
				this.PageActivityId = other.PageActivityId;
			}
			if (other.EndTime != 0L)
			{
				this.EndTime = other.EndTime;
			}
			this.rewards_.Add(other.rewards_);
			if (other.Receive)
			{
				this.Receive = other.Receive;
			}
			if (other.StartTime != 0L)
			{
				this.StartTime = other.StartTime;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06001A71 RID: 6769 RVA: 0x0004AB79 File Offset: 0x00048D79
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001A72 RID: 6770 RVA: 0x0004AB84 File Offset: 0x00048D84
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
				if (num <= 16U)
				{
					if (num == 8U)
					{
						this.PageActivityId = input.ReadInt32();
						continue;
					}
					if (num == 16U)
					{
						this.EndTime = input.ReadInt64();
						continue;
					}
				}
				else
				{
					if (num == 26U)
					{
						this.rewards_.AddEntriesFrom(ref input, ActivityLinkagePageData._repeated_rewards_codec);
						continue;
					}
					if (num == 32U)
					{
						this.Receive = input.ReadBool();
						continue;
					}
					if (num == 40U)
					{
						this.StartTime = input.ReadInt64();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04002249 RID: 8777
		private static readonly MessageParser<ActivityLinkagePageData> _parser = new MessageParser<ActivityLinkagePageData>(() => new ActivityLinkagePageData());

		// Token: 0x0400224A RID: 8778
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400224B RID: 8779
		public const int PageActivityIdFieldNumber = 1;

		// Token: 0x0400224C RID: 8780
		private int pageActivityId_;

		// Token: 0x0400224D RID: 8781
		public const int EndTimeFieldNumber = 2;

		// Token: 0x0400224E RID: 8782
		private long endTime_;

		// Token: 0x0400224F RID: 8783
		public const int RewardsFieldNumber = 3;

		// Token: 0x04002250 RID: 8784
		private static readonly FieldCodec<ActivityLinkageReward> _repeated_rewards_codec = FieldCodec.ForMessage<ActivityLinkageReward>(26U, ActivityLinkageReward.Parser);

		// Token: 0x04002251 RID: 8785
		private readonly RepeatedField<ActivityLinkageReward> rewards_ = new RepeatedField<ActivityLinkageReward>();

		// Token: 0x04002252 RID: 8786
		public const int ReceiveFieldNumber = 4;

		// Token: 0x04002253 RID: 8787
		private bool receive_;

		// Token: 0x04002254 RID: 8788
		public const int StartTimeFieldNumber = 5;

		// Token: 0x04002255 RID: 8789
		private long startTime_;
	}
}
