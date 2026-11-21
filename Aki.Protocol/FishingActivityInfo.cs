using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200052C RID: 1324
	public sealed class FishingActivityInfo : IMessage<FishingActivityInfo>, IMessage, IEquatable<FishingActivityInfo>, IDeepCloneable<FishingActivityInfo>, IBufferMessage
	{
		// Token: 0x06007C85 RID: 31877 RVA: 0x0012E424 File Offset: 0x0012C624
		[NullableContext(1)]
		public static FishingActivityInfo Create()
		{
			return new FishingActivityInfo();
		}

		// Token: 0x17001834 RID: 6196
		// (get) Token: 0x06007C86 RID: 31878 RVA: 0x0012E42B File Offset: 0x0012C62B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001835 RID: 6197
		// (get) Token: 0x06007C87 RID: 31879 RVA: 0x0012E42E File Offset: 0x0012C62E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FishingActivityInfo.Descriptor;
			}
		}

		// Token: 0x06007C88 RID: 31880 RVA: 0x0012E435 File Offset: 0x0012C635
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingActivityInfo()
		{
		}

		// Token: 0x06007C89 RID: 31881 RVA: 0x0012E454 File Offset: 0x0012C654
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingActivityInfo(FishingActivityInfo other) : this()
		{
			this.limitActivityTasks_ = other.limitActivityTasks_.Clone();
			this.milestoneRewarded_ = other.milestoneRewarded_.Clone();
			this.limitedStartTime_ = other.limitedStartTime_;
			this.limitedEndTime_ = other.limitedEndTime_;
			this.milestoneItemNum_ = other.milestoneItemNum_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007C8A RID: 31882 RVA: 0x0012E4BE File Offset: 0x0012C6BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingActivityInfo Clone()
		{
			return new FishingActivityInfo(this);
		}

		// Token: 0x17001836 RID: 6198
		// (get) Token: 0x06007C8B RID: 31883 RVA: 0x0012E4C6 File Offset: 0x0012C6C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ActivityTask> LimitActivityTasks
		{
			get
			{
				return this.limitActivityTasks_;
			}
		}

		// Token: 0x17001837 RID: 6199
		// (get) Token: 0x06007C8C RID: 31884 RVA: 0x0012E4CE File Offset: 0x0012C6CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, SignState> MilestoneRewarded
		{
			get
			{
				return this.milestoneRewarded_;
			}
		}

		// Token: 0x17001838 RID: 6200
		// (get) Token: 0x06007C8D RID: 31885 RVA: 0x0012E4D6 File Offset: 0x0012C6D6
		// (set) Token: 0x06007C8E RID: 31886 RVA: 0x0012E4DE File Offset: 0x0012C6DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long LimitedStartTime
		{
			get
			{
				return this.limitedStartTime_;
			}
			set
			{
				this.limitedStartTime_ = value;
			}
		}

		// Token: 0x17001839 RID: 6201
		// (get) Token: 0x06007C8F RID: 31887 RVA: 0x0012E4E7 File Offset: 0x0012C6E7
		// (set) Token: 0x06007C90 RID: 31888 RVA: 0x0012E4EF File Offset: 0x0012C6EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long LimitedEndTime
		{
			get
			{
				return this.limitedEndTime_;
			}
			set
			{
				this.limitedEndTime_ = value;
			}
		}

		// Token: 0x1700183A RID: 6202
		// (get) Token: 0x06007C91 RID: 31889 RVA: 0x0012E4F8 File Offset: 0x0012C6F8
		// (set) Token: 0x06007C92 RID: 31890 RVA: 0x0012E500 File Offset: 0x0012C700
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int MilestoneItemNum
		{
			get
			{
				return this.milestoneItemNum_;
			}
			set
			{
				this.milestoneItemNum_ = value;
			}
		}

		// Token: 0x06007C93 RID: 31891 RVA: 0x0012E509 File Offset: 0x0012C709
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FishingActivityInfo);
		}

		// Token: 0x06007C94 RID: 31892 RVA: 0x0012E518 File Offset: 0x0012C718
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FishingActivityInfo other)
		{
			return other != null && (other == this || (this.limitActivityTasks_.Equals(other.limitActivityTasks_) && this.MilestoneRewarded.Equals(other.MilestoneRewarded) && this.LimitedStartTime == other.LimitedStartTime && this.LimitedEndTime == other.LimitedEndTime && this.MilestoneItemNum == other.MilestoneItemNum && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007C95 RID: 31893 RVA: 0x0012E59C File Offset: 0x0012C79C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.limitActivityTasks_.GetHashCode();
			num ^= this.MilestoneRewarded.GetHashCode();
			if (this.LimitedStartTime != 0L)
			{
				num ^= this.LimitedStartTime.GetHashCode();
			}
			if (this.LimitedEndTime != 0L)
			{
				num ^= this.LimitedEndTime.GetHashCode();
			}
			if (this.MilestoneItemNum != 0)
			{
				num ^= this.MilestoneItemNum.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06007C96 RID: 31894 RVA: 0x0012E629 File Offset: 0x0012C829
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06007C97 RID: 31895 RVA: 0x0012E636 File Offset: 0x0012C836
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007C98 RID: 31896 RVA: 0x0012E640 File Offset: 0x0012C840
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.limitActivityTasks_.WriteTo(ref output, FishingActivityInfo._repeated_limitActivityTasks_codec);
			this.milestoneRewarded_.WriteTo(ref output, FishingActivityInfo._map_milestoneRewarded_codec);
			if (this.LimitedStartTime != 0L)
			{
				output.WriteRawTag(24);
				output.WriteInt64(this.LimitedStartTime);
			}
			if (this.LimitedEndTime != 0L)
			{
				output.WriteRawTag(32);
				output.WriteInt64(this.LimitedEndTime);
			}
			if (this.MilestoneItemNum != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.MilestoneItemNum);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007C99 RID: 31897 RVA: 0x0012E6D8 File Offset: 0x0012C8D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.limitActivityTasks_.CalculateSize(FishingActivityInfo._repeated_limitActivityTasks_codec);
			num += this.milestoneRewarded_.CalculateSize(FishingActivityInfo._map_milestoneRewarded_codec);
			if (this.LimitedStartTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.LimitedStartTime);
			}
			if (this.LimitedEndTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.LimitedEndTime);
			}
			if (this.MilestoneItemNum != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.MilestoneItemNum);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06007C9A RID: 31898 RVA: 0x0012E76C File Offset: 0x0012C96C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FishingActivityInfo other)
		{
			if (other == null)
			{
				return;
			}
			this.limitActivityTasks_.Add(other.limitActivityTasks_);
			this.milestoneRewarded_.MergeFrom(other.milestoneRewarded_);
			if (other.LimitedStartTime != 0L)
			{
				this.LimitedStartTime = other.LimitedStartTime;
			}
			if (other.LimitedEndTime != 0L)
			{
				this.LimitedEndTime = other.LimitedEndTime;
			}
			if (other.MilestoneItemNum != 0)
			{
				this.MilestoneItemNum = other.MilestoneItemNum;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06007C9B RID: 31899 RVA: 0x0012E7F2 File Offset: 0x0012C9F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007C9C RID: 31900 RVA: 0x0012E7FC File Offset: 0x0012C9FC
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
				if (num <= 18U)
				{
					if (num == 10U)
					{
						this.limitActivityTasks_.AddEntriesFrom(ref input, FishingActivityInfo._repeated_limitActivityTasks_codec);
						continue;
					}
					if (num == 18U)
					{
						this.milestoneRewarded_.AddEntriesFrom(ref input, FishingActivityInfo._map_milestoneRewarded_codec);
						continue;
					}
				}
				else
				{
					if (num == 24U)
					{
						this.LimitedStartTime = input.ReadInt64();
						continue;
					}
					if (num == 32U)
					{
						this.LimitedEndTime = input.ReadInt64();
						continue;
					}
					if (num == 40U)
					{
						this.MilestoneItemNum = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04003FEC RID: 16364
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003FED RID: 16365
		public const int LimitActivityTasksFieldNumber = 1;

		// Token: 0x04003FEE RID: 16366
		private static readonly FieldCodec<ActivityTask> _repeated_limitActivityTasks_codec = FieldCodec.ForMessage<ActivityTask>(10U, ActivityTask.Parser);

		// Token: 0x04003FEF RID: 16367
		private readonly RepeatedField<ActivityTask> limitActivityTasks_ = new RepeatedField<ActivityTask>();

		// Token: 0x04003FF0 RID: 16368
		public const int MilestoneRewardedFieldNumber = 2;

		// Token: 0x04003FF1 RID: 16369
		private static readonly MapField<int, SignState>.Codec _map_milestoneRewarded_codec = new MapField<int, SignState>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForEnum<SignState>(16U, (SignState x) => (int)x, (int x) => (SignState)x, SignState.Lock), 18U);

		// Token: 0x04003FF2 RID: 16370
		private readonly MapField<int, SignState> milestoneRewarded_ = new MapField<int, SignState>();

		// Token: 0x04003FF3 RID: 16371
		public const int LimitedStartTimeFieldNumber = 3;

		// Token: 0x04003FF4 RID: 16372
		private long limitedStartTime_;

		// Token: 0x04003FF5 RID: 16373
		public const int LimitedEndTimeFieldNumber = 4;

		// Token: 0x04003FF6 RID: 16374
		private long limitedEndTime_;

		// Token: 0x04003FF7 RID: 16375
		public const int MilestoneItemNumFieldNumber = 5;

		// Token: 0x04003FF8 RID: 16376
		private int milestoneItemNum_;
	}
}
