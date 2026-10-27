using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E49 RID: 3657
	public sealed class RacingBetsActivityData : IMessage<RacingBetsActivityData>, IMessage, IEquatable<RacingBetsActivityData>, IDeepCloneable<RacingBetsActivityData>, IBufferMessage
	{
		// Token: 0x06013A29 RID: 80425 RVA: 0x002DAAF0 File Offset: 0x002D8CF0
		[NullableContext(1)]
		public static RacingBetsActivityData Create()
		{
			return new RacingBetsActivityData();
		}

		// Token: 0x17004126 RID: 16678
		// (get) Token: 0x06013A2A RID: 80426 RVA: 0x002DAAF7 File Offset: 0x002D8CF7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004127 RID: 16679
		// (get) Token: 0x06013A2B RID: 80427 RVA: 0x002DAAFA File Offset: 0x002D8CFA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RacingBetsActivityData.Descriptor;
			}
		}

		// Token: 0x06013A2C RID: 80428 RVA: 0x002DAB01 File Offset: 0x002D8D01
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsActivityData()
		{
		}

		// Token: 0x06013A2D RID: 80429 RVA: 0x002DAB38 File Offset: 0x002D8D38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsActivityData(RacingBetsActivityData other) : this()
		{
			this.activityId_ = other.activityId_;
			this.activityStarAndEndTime_ = ((other.activityStarAndEndTime_ != null) ? other.activityStarAndEndTime_.Clone() : null);
			this.matchInfos_ = other.matchInfos_.Clone();
			this.playerInfo_ = ((other.playerInfo_ != null) ? other.playerInfo_.Clone() : null);
			this.taskDatas_ = other.taskDatas_.Clone();
			this.rankListUpdateTime_ = other.rankListUpdateTime_.Clone();
			this.closeSettleMenuLegMatchList_ = other.closeSettleMenuLegMatchList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06013A2E RID: 80430 RVA: 0x002DABE4 File Offset: 0x002D8DE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsActivityData Clone()
		{
			return new RacingBetsActivityData(this);
		}

		// Token: 0x17004128 RID: 16680
		// (get) Token: 0x06013A2F RID: 80431 RVA: 0x002DABEC File Offset: 0x002D8DEC
		// (set) Token: 0x06013A30 RID: 80432 RVA: 0x002DABF4 File Offset: 0x002D8DF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ActivityId
		{
			get
			{
				return this.activityId_;
			}
			set
			{
				this.activityId_ = value;
			}
		}

		// Token: 0x17004129 RID: 16681
		// (get) Token: 0x06013A31 RID: 80433 RVA: 0x002DABFD File Offset: 0x002D8DFD
		// (set) Token: 0x06013A32 RID: 80434 RVA: 0x002DAC05 File Offset: 0x002D8E05
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsTimeTuple ActivityStarAndEndTime
		{
			get
			{
				return this.activityStarAndEndTime_;
			}
			set
			{
				this.activityStarAndEndTime_ = value;
			}
		}

		// Token: 0x1700412A RID: 16682
		// (get) Token: 0x06013A33 RID: 80435 RVA: 0x002DAC0E File Offset: 0x002D8E0E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RacingBetsGroupMatchesInfo> MatchInfos
		{
			get
			{
				return this.matchInfos_;
			}
		}

		// Token: 0x1700412B RID: 16683
		// (get) Token: 0x06013A34 RID: 80436 RVA: 0x002DAC16 File Offset: 0x002D8E16
		// (set) Token: 0x06013A35 RID: 80437 RVA: 0x002DAC1E File Offset: 0x002D8E1E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetPlayerInfo PlayerInfo
		{
			get
			{
				return this.playerInfo_;
			}
			set
			{
				this.playerInfo_ = value;
			}
		}

		// Token: 0x1700412C RID: 16684
		// (get) Token: 0x06013A36 RID: 80438 RVA: 0x002DAC27 File Offset: 0x002D8E27
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ConditionTaskData> TaskDatas
		{
			get
			{
				return this.taskDatas_;
			}
		}

		// Token: 0x1700412D RID: 16685
		// (get) Token: 0x06013A37 RID: 80439 RVA: 0x002DAC2F File Offset: 0x002D8E2F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<long> RankListUpdateTime
		{
			get
			{
				return this.rankListUpdateTime_;
			}
		}

		// Token: 0x1700412E RID: 16686
		// (get) Token: 0x06013A38 RID: 80440 RVA: 0x002DAC37 File Offset: 0x002D8E37
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> CloseSettleMenuLegMatchList
		{
			get
			{
				return this.closeSettleMenuLegMatchList_;
			}
		}

		// Token: 0x06013A39 RID: 80441 RVA: 0x002DAC3F File Offset: 0x002D8E3F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RacingBetsActivityData);
		}

		// Token: 0x06013A3A RID: 80442 RVA: 0x002DAC50 File Offset: 0x002D8E50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RacingBetsActivityData other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && object.Equals(this.ActivityStarAndEndTime, other.ActivityStarAndEndTime) && this.matchInfos_.Equals(other.matchInfos_) && object.Equals(this.PlayerInfo, other.PlayerInfo) && this.taskDatas_.Equals(other.taskDatas_) && this.rankListUpdateTime_.Equals(other.rankListUpdateTime_) && this.closeSettleMenuLegMatchList_.Equals(other.closeSettleMenuLegMatchList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06013A3B RID: 80443 RVA: 0x002DAD08 File Offset: 0x002D8F08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ActivityId != 0)
			{
				num ^= this.ActivityId.GetHashCode();
			}
			if (this.activityStarAndEndTime_ != null)
			{
				num ^= this.ActivityStarAndEndTime.GetHashCode();
			}
			num ^= this.matchInfos_.GetHashCode();
			if (this.playerInfo_ != null)
			{
				num ^= this.PlayerInfo.GetHashCode();
			}
			num ^= this.taskDatas_.GetHashCode();
			num ^= this.rankListUpdateTime_.GetHashCode();
			num ^= this.closeSettleMenuLegMatchList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06013A3C RID: 80444 RVA: 0x002DADAB File Offset: 0x002D8FAB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06013A3D RID: 80445 RVA: 0x002DADB8 File Offset: 0x002D8FB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06013A3E RID: 80446 RVA: 0x002DADC4 File Offset: 0x002D8FC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.ActivityId);
			}
			if (this.activityStarAndEndTime_ != null)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.ActivityStarAndEndTime);
			}
			this.matchInfos_.WriteTo(ref output, RacingBetsActivityData._repeated_matchInfos_codec);
			if (this.playerInfo_ != null)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.PlayerInfo);
			}
			this.taskDatas_.WriteTo(ref output, RacingBetsActivityData._repeated_taskDatas_codec);
			this.rankListUpdateTime_.WriteTo(ref output, RacingBetsActivityData._repeated_rankListUpdateTime_codec);
			this.closeSettleMenuLegMatchList_.WriteTo(ref output, RacingBetsActivityData._repeated_closeSettleMenuLegMatchList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06013A3F RID: 80447 RVA: 0x002DAE7C File Offset: 0x002D907C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ActivityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActivityId);
			}
			if (this.activityStarAndEndTime_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ActivityStarAndEndTime);
			}
			num += this.matchInfos_.CalculateSize(RacingBetsActivityData._repeated_matchInfos_codec);
			if (this.playerInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.PlayerInfo);
			}
			num += this.taskDatas_.CalculateSize(RacingBetsActivityData._repeated_taskDatas_codec);
			num += this.rankListUpdateTime_.CalculateSize(RacingBetsActivityData._repeated_rankListUpdateTime_codec);
			num += this.closeSettleMenuLegMatchList_.CalculateSize(RacingBetsActivityData._repeated_closeSettleMenuLegMatchList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06013A40 RID: 80448 RVA: 0x002DAF38 File Offset: 0x002D9138
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RacingBetsActivityData other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ActivityId != 0)
			{
				this.ActivityId = other.ActivityId;
			}
			if (other.activityStarAndEndTime_ != null)
			{
				if (this.activityStarAndEndTime_ == null)
				{
					this.ActivityStarAndEndTime = new RacingBetsTimeTuple();
				}
				this.ActivityStarAndEndTime.MergeFrom(other.ActivityStarAndEndTime);
			}
			this.matchInfos_.Add(other.matchInfos_);
			if (other.playerInfo_ != null)
			{
				if (this.playerInfo_ == null)
				{
					this.PlayerInfo = new RacingBetPlayerInfo();
				}
				this.PlayerInfo.MergeFrom(other.PlayerInfo);
			}
			this.taskDatas_.Add(other.taskDatas_);
			this.rankListUpdateTime_.Add(other.rankListUpdateTime_);
			this.closeSettleMenuLegMatchList_.Add(other.closeSettleMenuLegMatchList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06013A41 RID: 80449 RVA: 0x002DB010 File Offset: 0x002D9210
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06013A42 RID: 80450 RVA: 0x002DB01C File Offset: 0x002D921C
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
				if (num > 34U)
				{
					if (num <= 48U)
					{
						if (num == 42U)
						{
							this.taskDatas_.AddEntriesFrom(ref input, RacingBetsActivityData._repeated_taskDatas_codec);
							continue;
						}
						if (num != 48U)
						{
							goto IL_62;
						}
					}
					else if (num != 50U)
					{
						if (num != 56U && num != 58U)
						{
							goto IL_62;
						}
						this.closeSettleMenuLegMatchList_.AddEntriesFrom(ref input, RacingBetsActivityData._repeated_closeSettleMenuLegMatchList_codec);
						continue;
					}
					this.rankListUpdateTime_.AddEntriesFrom(ref input, RacingBetsActivityData._repeated_rankListUpdateTime_codec);
					continue;
				}
				if (num <= 18U)
				{
					if (num == 8U)
					{
						this.ActivityId = input.ReadInt32();
						continue;
					}
					if (num == 18U)
					{
						if (this.activityStarAndEndTime_ == null)
						{
							this.ActivityStarAndEndTime = new RacingBetsTimeTuple();
						}
						input.ReadMessage(this.ActivityStarAndEndTime);
						continue;
					}
				}
				else
				{
					if (num == 26U)
					{
						this.matchInfos_.AddEntriesFrom(ref input, RacingBetsActivityData._repeated_matchInfos_codec);
						continue;
					}
					if (num == 34U)
					{
						if (this.playerInfo_ == null)
						{
							this.PlayerInfo = new RacingBetPlayerInfo();
						}
						input.ReadMessage(this.PlayerInfo);
						continue;
					}
				}
				IL_62:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400782B RID: 30763
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400782C RID: 30764
		public const int ActivityIdFieldNumber = 1;

		// Token: 0x0400782D RID: 30765
		private int activityId_;

		// Token: 0x0400782E RID: 30766
		public const int ActivityStarAndEndTimeFieldNumber = 2;

		// Token: 0x0400782F RID: 30767
		private RacingBetsTimeTuple activityStarAndEndTime_;

		// Token: 0x04007830 RID: 30768
		public const int MatchInfosFieldNumber = 3;

		// Token: 0x04007831 RID: 30769
		private static readonly FieldCodec<RacingBetsGroupMatchesInfo> _repeated_matchInfos_codec = FieldCodec.ForMessage<RacingBetsGroupMatchesInfo>(26U, RacingBetsGroupMatchesInfo.Parser);

		// Token: 0x04007832 RID: 30770
		private readonly RepeatedField<RacingBetsGroupMatchesInfo> matchInfos_ = new RepeatedField<RacingBetsGroupMatchesInfo>();

		// Token: 0x04007833 RID: 30771
		public const int PlayerInfoFieldNumber = 4;

		// Token: 0x04007834 RID: 30772
		private RacingBetPlayerInfo playerInfo_;

		// Token: 0x04007835 RID: 30773
		public const int TaskDatasFieldNumber = 5;

		// Token: 0x04007836 RID: 30774
		private static readonly FieldCodec<ConditionTaskData> _repeated_taskDatas_codec = FieldCodec.ForMessage<ConditionTaskData>(42U, ConditionTaskData.Parser);

		// Token: 0x04007837 RID: 30775
		private readonly RepeatedField<ConditionTaskData> taskDatas_ = new RepeatedField<ConditionTaskData>();

		// Token: 0x04007838 RID: 30776
		public const int RankListUpdateTimeFieldNumber = 6;

		// Token: 0x04007839 RID: 30777
		private static readonly FieldCodec<long> _repeated_rankListUpdateTime_codec = FieldCodec.ForInt64(50U);

		// Token: 0x0400783A RID: 30778
		private readonly RepeatedField<long> rankListUpdateTime_ = new RepeatedField<long>();

		// Token: 0x0400783B RID: 30779
		public const int CloseSettleMenuLegMatchListFieldNumber = 7;

		// Token: 0x0400783C RID: 30780
		private static readonly FieldCodec<int> _repeated_closeSettleMenuLegMatchList_codec = FieldCodec.ForInt32(58U);

		// Token: 0x0400783D RID: 30781
		private readonly RepeatedField<int> closeSettleMenuLegMatchList_ = new RepeatedField<int>();
	}
}
