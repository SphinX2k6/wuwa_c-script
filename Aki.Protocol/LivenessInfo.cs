using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200091E RID: 2334
	public sealed class LivenessInfo : IMessage<LivenessInfo>, IMessage, IEquatable<LivenessInfo>, IDeepCloneable<LivenessInfo>, IBufferMessage
	{
		// Token: 0x0600CE2F RID: 52783 RVA: 0x001E633D File Offset: 0x001E453D
		[NullableContext(1)]
		public static LivenessInfo Create()
		{
			return new LivenessInfo();
		}

		// Token: 0x170029A2 RID: 10658
		// (get) Token: 0x0600CE30 RID: 52784 RVA: 0x001E6344 File Offset: 0x001E4544
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170029A3 RID: 10659
		// (get) Token: 0x0600CE31 RID: 52785 RVA: 0x001E6347 File Offset: 0x001E4547
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LivenessInfo.Descriptor;
			}
		}

		// Token: 0x0600CE32 RID: 52786 RVA: 0x001E634E File Offset: 0x001E454E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LivenessInfo()
		{
		}

		// Token: 0x0600CE33 RID: 52787 RVA: 0x001E636C File Offset: 0x001E456C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LivenessInfo(LivenessInfo other) : this()
		{
			this.livenessCount_ = other.livenessCount_;
			this.rewardedLiveness_ = other.rewardedLiveness_.Clone();
			this.tasks_ = other.tasks_.Clone();
			this.dayEnd_ = other.dayEnd_;
			this.areaId_ = other.areaId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600CE34 RID: 52788 RVA: 0x001E63D6 File Offset: 0x001E45D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LivenessInfo Clone()
		{
			return new LivenessInfo(this);
		}

		// Token: 0x170029A4 RID: 10660
		// (get) Token: 0x0600CE35 RID: 52789 RVA: 0x001E63DE File Offset: 0x001E45DE
		// (set) Token: 0x0600CE36 RID: 52790 RVA: 0x001E63E6 File Offset: 0x001E45E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int LivenessCount
		{
			get
			{
				return this.livenessCount_;
			}
			set
			{
				this.livenessCount_ = value;
			}
		}

		// Token: 0x170029A5 RID: 10661
		// (get) Token: 0x0600CE37 RID: 52791 RVA: 0x001E63EF File Offset: 0x001E45EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> RewardedLiveness
		{
			get
			{
				return this.rewardedLiveness_;
			}
		}

		// Token: 0x170029A6 RID: 10662
		// (get) Token: 0x0600CE38 RID: 52792 RVA: 0x001E63F7 File Offset: 0x001E45F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<LivenessTask> Tasks
		{
			get
			{
				return this.tasks_;
			}
		}

		// Token: 0x170029A7 RID: 10663
		// (get) Token: 0x0600CE39 RID: 52793 RVA: 0x001E63FF File Offset: 0x001E45FF
		// (set) Token: 0x0600CE3A RID: 52794 RVA: 0x001E6407 File Offset: 0x001E4607
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long DayEnd
		{
			get
			{
				return this.dayEnd_;
			}
			set
			{
				this.dayEnd_ = value;
			}
		}

		// Token: 0x170029A8 RID: 10664
		// (get) Token: 0x0600CE3B RID: 52795 RVA: 0x001E6410 File Offset: 0x001E4610
		// (set) Token: 0x0600CE3C RID: 52796 RVA: 0x001E6418 File Offset: 0x001E4618
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int AreaId
		{
			get
			{
				return this.areaId_;
			}
			set
			{
				this.areaId_ = value;
			}
		}

		// Token: 0x0600CE3D RID: 52797 RVA: 0x001E6421 File Offset: 0x001E4621
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LivenessInfo);
		}

		// Token: 0x0600CE3E RID: 52798 RVA: 0x001E6430 File Offset: 0x001E4630
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LivenessInfo other)
		{
			return other != null && (other == this || (this.LivenessCount == other.LivenessCount && this.rewardedLiveness_.Equals(other.rewardedLiveness_) && this.tasks_.Equals(other.tasks_) && this.DayEnd == other.DayEnd && this.AreaId == other.AreaId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600CE3F RID: 52799 RVA: 0x001E64B4 File Offset: 0x001E46B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.LivenessCount != 0)
			{
				num ^= this.LivenessCount.GetHashCode();
			}
			num ^= this.rewardedLiveness_.GetHashCode();
			num ^= this.tasks_.GetHashCode();
			if (this.DayEnd != 0L)
			{
				num ^= this.DayEnd.GetHashCode();
			}
			if (this.AreaId != 0)
			{
				num ^= this.AreaId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600CE40 RID: 52800 RVA: 0x001E6541 File Offset: 0x001E4741
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600CE41 RID: 52801 RVA: 0x001E654E File Offset: 0x001E474E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600CE42 RID: 52802 RVA: 0x001E6558 File Offset: 0x001E4758
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.LivenessCount != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.LivenessCount);
			}
			this.rewardedLiveness_.WriteTo(ref output, LivenessInfo._repeated_rewardedLiveness_codec);
			this.tasks_.WriteTo(ref output, LivenessInfo._repeated_tasks_codec);
			if (this.DayEnd != 0L)
			{
				output.WriteRawTag(32);
				output.WriteInt64(this.DayEnd);
			}
			if (this.AreaId != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.AreaId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600CE43 RID: 52803 RVA: 0x001E65F0 File Offset: 0x001E47F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.LivenessCount != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.LivenessCount);
			}
			num += this.rewardedLiveness_.CalculateSize(LivenessInfo._repeated_rewardedLiveness_codec);
			num += this.tasks_.CalculateSize(LivenessInfo._repeated_tasks_codec);
			if (this.DayEnd != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.DayEnd);
			}
			if (this.AreaId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.AreaId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600CE44 RID: 52804 RVA: 0x001E6684 File Offset: 0x001E4884
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(LivenessInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.LivenessCount != 0)
			{
				this.LivenessCount = other.LivenessCount;
			}
			this.rewardedLiveness_.Add(other.rewardedLiveness_);
			this.tasks_.Add(other.tasks_);
			if (other.DayEnd != 0L)
			{
				this.DayEnd = other.DayEnd;
			}
			if (other.AreaId != 0)
			{
				this.AreaId = other.AreaId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600CE45 RID: 52805 RVA: 0x001E670A File Offset: 0x001E490A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600CE46 RID: 52806 RVA: 0x001E6714 File Offset: 0x001E4914
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
					if (num == 8U)
					{
						this.LivenessCount = input.ReadInt32();
						continue;
					}
					if (num == 16U || num == 18U)
					{
						this.rewardedLiveness_.AddEntriesFrom(ref input, LivenessInfo._repeated_rewardedLiveness_codec);
						continue;
					}
				}
				else
				{
					if (num == 26U)
					{
						this.tasks_.AddEntriesFrom(ref input, LivenessInfo._repeated_tasks_codec);
						continue;
					}
					if (num == 32U)
					{
						this.DayEnd = input.ReadInt64();
						continue;
					}
					if (num == 40U)
					{
						this.AreaId = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04005782 RID: 22402
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005783 RID: 22403
		public const int LivenessCountFieldNumber = 1;

		// Token: 0x04005784 RID: 22404
		private int livenessCount_;

		// Token: 0x04005785 RID: 22405
		public const int RewardedLivenessFieldNumber = 2;

		// Token: 0x04005786 RID: 22406
		private static readonly FieldCodec<int> _repeated_rewardedLiveness_codec = FieldCodec.ForInt32(18U);

		// Token: 0x04005787 RID: 22407
		private readonly RepeatedField<int> rewardedLiveness_ = new RepeatedField<int>();

		// Token: 0x04005788 RID: 22408
		public const int TasksFieldNumber = 3;

		// Token: 0x04005789 RID: 22409
		private static readonly FieldCodec<LivenessTask> _repeated_tasks_codec = FieldCodec.ForMessage<LivenessTask>(26U, LivenessTask.Parser);

		// Token: 0x0400578A RID: 22410
		private readonly RepeatedField<LivenessTask> tasks_ = new RepeatedField<LivenessTask>();

		// Token: 0x0400578B RID: 22411
		public const int DayEndFieldNumber = 4;

		// Token: 0x0400578C RID: 22412
		private long dayEnd_;

		// Token: 0x0400578D RID: 22413
		public const int AreaIdFieldNumber = 5;

		// Token: 0x0400578E RID: 22414
		private int areaId_;
	}
}
