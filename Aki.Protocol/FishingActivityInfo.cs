using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000541 RID: 1345
	public sealed class FishingActivityInfo : IMessage<FishingActivityInfo>, IMessage, IEquatable<FishingActivityInfo>, IDeepCloneable<FishingActivityInfo>, IBufferMessage
	{
		// Token: 0x06007DED RID: 32237 RVA: 0x00131028 File Offset: 0x0012F228
		[NullableContext(1)]
		public static FishingActivityInfo Create()
		{
			return new FishingActivityInfo();
		}

		// Token: 0x17001881 RID: 6273
		// (get) Token: 0x06007DEE RID: 32238 RVA: 0x0013102F File Offset: 0x0012F22F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001882 RID: 6274
		// (get) Token: 0x06007DEF RID: 32239 RVA: 0x00131032 File Offset: 0x0012F232
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FishingActivityInfo.Descriptor;
			}
		}

		// Token: 0x06007DF0 RID: 32240 RVA: 0x00131039 File Offset: 0x0012F239
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingActivityInfo()
		{
		}

		// Token: 0x06007DF1 RID: 32241 RVA: 0x00131058 File Offset: 0x0012F258
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

		// Token: 0x06007DF2 RID: 32242 RVA: 0x001310C2 File Offset: 0x0012F2C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingActivityInfo Clone()
		{
			return new FishingActivityInfo(this);
		}

		// Token: 0x17001883 RID: 6275
		// (get) Token: 0x06007DF3 RID: 32243 RVA: 0x001310CA File Offset: 0x0012F2CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ActivityTask> LimitActivityTasks
		{
			get
			{
				return this.limitActivityTasks_;
			}
		}

		// Token: 0x17001884 RID: 6276
		// (get) Token: 0x06007DF4 RID: 32244 RVA: 0x001310D2 File Offset: 0x0012F2D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, SignState> MilestoneRewarded
		{
			get
			{
				return this.milestoneRewarded_;
			}
		}

		// Token: 0x17001885 RID: 6277
		// (get) Token: 0x06007DF5 RID: 32245 RVA: 0x001310DA File Offset: 0x0012F2DA
		// (set) Token: 0x06007DF6 RID: 32246 RVA: 0x001310E2 File Offset: 0x0012F2E2
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

		// Token: 0x17001886 RID: 6278
		// (get) Token: 0x06007DF7 RID: 32247 RVA: 0x001310EB File Offset: 0x0012F2EB
		// (set) Token: 0x06007DF8 RID: 32248 RVA: 0x001310F3 File Offset: 0x0012F2F3
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

		// Token: 0x17001887 RID: 6279
		// (get) Token: 0x06007DF9 RID: 32249 RVA: 0x001310FC File Offset: 0x0012F2FC
		// (set) Token: 0x06007DFA RID: 32250 RVA: 0x00131104 File Offset: 0x0012F304
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

		// Token: 0x06007DFB RID: 32251 RVA: 0x0013110D File Offset: 0x0012F30D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FishingActivityInfo);
		}

		// Token: 0x06007DFC RID: 32252 RVA: 0x0013111C File Offset: 0x0012F31C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FishingActivityInfo other)
		{
			return other != null && (other == this || (this.limitActivityTasks_.Equals(other.limitActivityTasks_) && this.MilestoneRewarded.Equals(other.MilestoneRewarded) && this.LimitedStartTime == other.LimitedStartTime && this.LimitedEndTime == other.LimitedEndTime && this.MilestoneItemNum == other.MilestoneItemNum && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007DFD RID: 32253 RVA: 0x001311A0 File Offset: 0x0012F3A0
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

		// Token: 0x06007DFE RID: 32254 RVA: 0x0013122D File Offset: 0x0012F42D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06007DFF RID: 32255 RVA: 0x0013123A File Offset: 0x0012F43A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007E00 RID: 32256 RVA: 0x00131244 File Offset: 0x0012F444
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

		// Token: 0x06007E01 RID: 32257 RVA: 0x001312DC File Offset: 0x0012F4DC
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

		// Token: 0x06007E02 RID: 32258 RVA: 0x00131370 File Offset: 0x0012F570
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

		// Token: 0x06007E03 RID: 32259 RVA: 0x001313F6 File Offset: 0x0012F5F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007E04 RID: 32260 RVA: 0x00131400 File Offset: 0x0012F600
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

		// Token: 0x04003FF6 RID: 16374
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003FF7 RID: 16375
		public const int LimitActivityTasksFieldNumber = 1;

		// Token: 0x04003FF8 RID: 16376
		private static readonly FieldCodec<ActivityTask> _repeated_limitActivityTasks_codec = FieldCodec.ForMessage<ActivityTask>(10U, ActivityTask.Parser);

		// Token: 0x04003FF9 RID: 16377
		private readonly RepeatedField<ActivityTask> limitActivityTasks_ = new RepeatedField<ActivityTask>();

		// Token: 0x04003FFA RID: 16378
		public const int MilestoneRewardedFieldNumber = 2;

		// Token: 0x04003FFB RID: 16379
		private static readonly MapField<int, SignState>.Codec _map_milestoneRewarded_codec = new MapField<int, SignState>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForEnum<SignState>(16U, (SignState x) => (int)x, (int x) => (SignState)x, SignState.Lock), 18U);

		// Token: 0x04003FFC RID: 16380
		private readonly MapField<int, SignState> milestoneRewarded_ = new MapField<int, SignState>();

		// Token: 0x04003FFD RID: 16381
		public const int LimitedStartTimeFieldNumber = 3;

		// Token: 0x04003FFE RID: 16382
		private long limitedStartTime_;

		// Token: 0x04003FFF RID: 16383
		public const int LimitedEndTimeFieldNumber = 4;

		// Token: 0x04004000 RID: 16384
		private long limitedEndTime_;

		// Token: 0x04004001 RID: 16385
		public const int MilestoneItemNumFieldNumber = 5;

		// Token: 0x04004002 RID: 16386
		private int milestoneItemNum_;
	}
}
