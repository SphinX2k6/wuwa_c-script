using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000089 RID: 137
	public sealed class ActivityLinkagePageData : IMessage<ActivityLinkagePageData>, IMessage, IEquatable<ActivityLinkagePageData>, IDeepCloneable<ActivityLinkagePageData>, IBufferMessage
	{
		// Token: 0x06001AA0 RID: 6816 RVA: 0x0004B3A7 File Offset: 0x000495A7
		[NullableContext(1)]
		public static ActivityLinkagePageData Create()
		{
			return new ActivityLinkagePageData();
		}

		// Token: 0x170002BF RID: 703
		// (get) Token: 0x06001AA1 RID: 6817 RVA: 0x0004B3AE File Offset: 0x000495AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ActivityLinkagePageData> Parser
		{
			get
			{
				return ActivityLinkagePageData._parser;
			}
		}

		// Token: 0x170002C0 RID: 704
		// (get) Token: 0x06001AA2 RID: 6818 RVA: 0x0004B3B5 File Offset: 0x000495B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170002C1 RID: 705
		// (get) Token: 0x06001AA3 RID: 6819 RVA: 0x0004B3B8 File Offset: 0x000495B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ActivityLinkagePageData.Descriptor;
			}
		}

		// Token: 0x06001AA4 RID: 6820 RVA: 0x0004B3BF File Offset: 0x000495BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActivityLinkagePageData()
		{
		}

		// Token: 0x06001AA5 RID: 6821 RVA: 0x0004B3D4 File Offset: 0x000495D4
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

		// Token: 0x06001AA6 RID: 6822 RVA: 0x0004B439 File Offset: 0x00049639
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActivityLinkagePageData Clone()
		{
			return new ActivityLinkagePageData(this);
		}

		// Token: 0x170002C2 RID: 706
		// (get) Token: 0x06001AA7 RID: 6823 RVA: 0x0004B441 File Offset: 0x00049641
		// (set) Token: 0x06001AA8 RID: 6824 RVA: 0x0004B449 File Offset: 0x00049649
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

		// Token: 0x170002C3 RID: 707
		// (get) Token: 0x06001AA9 RID: 6825 RVA: 0x0004B452 File Offset: 0x00049652
		// (set) Token: 0x06001AAA RID: 6826 RVA: 0x0004B45A File Offset: 0x0004965A
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

		// Token: 0x170002C4 RID: 708
		// (get) Token: 0x06001AAB RID: 6827 RVA: 0x0004B463 File Offset: 0x00049663
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ActivityLinkageReward> Rewards
		{
			get
			{
				return this.rewards_;
			}
		}

		// Token: 0x170002C5 RID: 709
		// (get) Token: 0x06001AAC RID: 6828 RVA: 0x0004B46B File Offset: 0x0004966B
		// (set) Token: 0x06001AAD RID: 6829 RVA: 0x0004B473 File Offset: 0x00049673
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

		// Token: 0x170002C6 RID: 710
		// (get) Token: 0x06001AAE RID: 6830 RVA: 0x0004B47C File Offset: 0x0004967C
		// (set) Token: 0x06001AAF RID: 6831 RVA: 0x0004B484 File Offset: 0x00049684
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

		// Token: 0x06001AB0 RID: 6832 RVA: 0x0004B48D File Offset: 0x0004968D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ActivityLinkagePageData);
		}

		// Token: 0x06001AB1 RID: 6833 RVA: 0x0004B49C File Offset: 0x0004969C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ActivityLinkagePageData other)
		{
			return other != null && (other == this || (this.PageActivityId == other.PageActivityId && this.EndTime == other.EndTime && this.rewards_.Equals(other.rewards_) && this.Receive == other.Receive && this.StartTime == other.StartTime && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001AB2 RID: 6834 RVA: 0x0004B51C File Offset: 0x0004971C
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

		// Token: 0x06001AB3 RID: 6835 RVA: 0x0004B5B4 File Offset: 0x000497B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06001AB4 RID: 6836 RVA: 0x0004B5C1 File Offset: 0x000497C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001AB5 RID: 6837 RVA: 0x0004B5CC File Offset: 0x000497CC
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

		// Token: 0x06001AB6 RID: 6838 RVA: 0x0004B670 File Offset: 0x00049870
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

		// Token: 0x06001AB7 RID: 6839 RVA: 0x0004B700 File Offset: 0x00049900
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

		// Token: 0x06001AB8 RID: 6840 RVA: 0x0004B789 File Offset: 0x00049989
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001AB9 RID: 6841 RVA: 0x0004B794 File Offset: 0x00049994
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

		// Token: 0x040022AA RID: 8874
		private static readonly MessageParser<ActivityLinkagePageData> _parser = new MessageParser<ActivityLinkagePageData>(() => new ActivityLinkagePageData());

		// Token: 0x040022AB RID: 8875
		private UnknownFieldSet _unknownFields;

		// Token: 0x040022AC RID: 8876
		public const int PageActivityIdFieldNumber = 1;

		// Token: 0x040022AD RID: 8877
		private int pageActivityId_;

		// Token: 0x040022AE RID: 8878
		public const int EndTimeFieldNumber = 2;

		// Token: 0x040022AF RID: 8879
		private long endTime_;

		// Token: 0x040022B0 RID: 8880
		public const int RewardsFieldNumber = 3;

		// Token: 0x040022B1 RID: 8881
		private static readonly FieldCodec<ActivityLinkageReward> _repeated_rewards_codec = FieldCodec.ForMessage<ActivityLinkageReward>(26U, ActivityLinkageReward.Parser);

		// Token: 0x040022B2 RID: 8882
		private readonly RepeatedField<ActivityLinkageReward> rewards_ = new RepeatedField<ActivityLinkageReward>();

		// Token: 0x040022B3 RID: 8883
		public const int ReceiveFieldNumber = 4;

		// Token: 0x040022B4 RID: 8884
		private bool receive_;

		// Token: 0x040022B5 RID: 8885
		public const int StartTimeFieldNumber = 5;

		// Token: 0x040022B6 RID: 8886
		private long startTime_;
	}
}
