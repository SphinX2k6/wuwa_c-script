using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200092F RID: 2351
	public sealed class LivenessInfo : IMessage<LivenessInfo>, IMessage, IEquatable<LivenessInfo>, IDeepCloneable<LivenessInfo>, IBufferMessage
	{
		// Token: 0x0600CF4B RID: 53067 RVA: 0x001E8610 File Offset: 0x001E6810
		[NullableContext(1)]
		public static LivenessInfo Create()
		{
			return new LivenessInfo();
		}

		// Token: 0x170029E1 RID: 10721
		// (get) Token: 0x0600CF4C RID: 53068 RVA: 0x001E8617 File Offset: 0x001E6817
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170029E2 RID: 10722
		// (get) Token: 0x0600CF4D RID: 53069 RVA: 0x001E861A File Offset: 0x001E681A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LivenessInfo.Descriptor;
			}
		}

		// Token: 0x0600CF4E RID: 53070 RVA: 0x001E8621 File Offset: 0x001E6821
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LivenessInfo()
		{
		}

		// Token: 0x0600CF4F RID: 53071 RVA: 0x001E8640 File Offset: 0x001E6840
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

		// Token: 0x0600CF50 RID: 53072 RVA: 0x001E86AA File Offset: 0x001E68AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LivenessInfo Clone()
		{
			return new LivenessInfo(this);
		}

		// Token: 0x170029E3 RID: 10723
		// (get) Token: 0x0600CF51 RID: 53073 RVA: 0x001E86B2 File Offset: 0x001E68B2
		// (set) Token: 0x0600CF52 RID: 53074 RVA: 0x001E86BA File Offset: 0x001E68BA
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

		// Token: 0x170029E4 RID: 10724
		// (get) Token: 0x0600CF53 RID: 53075 RVA: 0x001E86C3 File Offset: 0x001E68C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> RewardedLiveness
		{
			get
			{
				return this.rewardedLiveness_;
			}
		}

		// Token: 0x170029E5 RID: 10725
		// (get) Token: 0x0600CF54 RID: 53076 RVA: 0x001E86CB File Offset: 0x001E68CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<LivenessTask> Tasks
		{
			get
			{
				return this.tasks_;
			}
		}

		// Token: 0x170029E6 RID: 10726
		// (get) Token: 0x0600CF55 RID: 53077 RVA: 0x001E86D3 File Offset: 0x001E68D3
		// (set) Token: 0x0600CF56 RID: 53078 RVA: 0x001E86DB File Offset: 0x001E68DB
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

		// Token: 0x170029E7 RID: 10727
		// (get) Token: 0x0600CF57 RID: 53079 RVA: 0x001E86E4 File Offset: 0x001E68E4
		// (set) Token: 0x0600CF58 RID: 53080 RVA: 0x001E86EC File Offset: 0x001E68EC
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

		// Token: 0x0600CF59 RID: 53081 RVA: 0x001E86F5 File Offset: 0x001E68F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LivenessInfo);
		}

		// Token: 0x0600CF5A RID: 53082 RVA: 0x001E8704 File Offset: 0x001E6904
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LivenessInfo other)
		{
			return other != null && (other == this || (this.LivenessCount == other.LivenessCount && this.rewardedLiveness_.Equals(other.rewardedLiveness_) && this.tasks_.Equals(other.tasks_) && this.DayEnd == other.DayEnd && this.AreaId == other.AreaId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600CF5B RID: 53083 RVA: 0x001E8788 File Offset: 0x001E6988
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

		// Token: 0x0600CF5C RID: 53084 RVA: 0x001E8815 File Offset: 0x001E6A15
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600CF5D RID: 53085 RVA: 0x001E8822 File Offset: 0x001E6A22
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600CF5E RID: 53086 RVA: 0x001E882C File Offset: 0x001E6A2C
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

		// Token: 0x0600CF5F RID: 53087 RVA: 0x001E88C4 File Offset: 0x001E6AC4
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

		// Token: 0x0600CF60 RID: 53088 RVA: 0x001E8958 File Offset: 0x001E6B58
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

		// Token: 0x0600CF61 RID: 53089 RVA: 0x001E89DE File Offset: 0x001E6BDE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600CF62 RID: 53090 RVA: 0x001E89E8 File Offset: 0x001E6BE8
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

		// Token: 0x0400577B RID: 22395
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400577C RID: 22396
		public const int LivenessCountFieldNumber = 1;

		// Token: 0x0400577D RID: 22397
		private int livenessCount_;

		// Token: 0x0400577E RID: 22398
		public const int RewardedLivenessFieldNumber = 2;

		// Token: 0x0400577F RID: 22399
		private static readonly FieldCodec<int> _repeated_rewardedLiveness_codec = FieldCodec.ForInt32(18U);

		// Token: 0x04005780 RID: 22400
		private readonly RepeatedField<int> rewardedLiveness_ = new RepeatedField<int>();

		// Token: 0x04005781 RID: 22401
		public const int TasksFieldNumber = 3;

		// Token: 0x04005782 RID: 22402
		private static readonly FieldCodec<LivenessTask> _repeated_tasks_codec = FieldCodec.ForMessage<LivenessTask>(26U, LivenessTask.Parser);

		// Token: 0x04005783 RID: 22403
		private readonly RepeatedField<LivenessTask> tasks_ = new RepeatedField<LivenessTask>();

		// Token: 0x04005784 RID: 22404
		public const int DayEndFieldNumber = 4;

		// Token: 0x04005785 RID: 22405
		private long dayEnd_;

		// Token: 0x04005786 RID: 22406
		public const int AreaIdFieldNumber = 5;

		// Token: 0x04005787 RID: 22407
		private int areaId_;
	}
}
