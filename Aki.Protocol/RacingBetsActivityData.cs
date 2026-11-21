using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E39 RID: 3641
	public sealed class RacingBetsActivityData : IMessage<RacingBetsActivityData>, IMessage, IEquatable<RacingBetsActivityData>, IDeepCloneable<RacingBetsActivityData>, IBufferMessage
	{
		// Token: 0x06013944 RID: 80196 RVA: 0x002D9434 File Offset: 0x002D7634
		[NullableContext(1)]
		public static RacingBetsActivityData Create()
		{
			return new RacingBetsActivityData();
		}

		// Token: 0x170040FC RID: 16636
		// (get) Token: 0x06013945 RID: 80197 RVA: 0x002D943B File Offset: 0x002D763B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170040FD RID: 16637
		// (get) Token: 0x06013946 RID: 80198 RVA: 0x002D943E File Offset: 0x002D763E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RacingBetsActivityData.Descriptor;
			}
		}

		// Token: 0x06013947 RID: 80199 RVA: 0x002D9445 File Offset: 0x002D7645
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsActivityData()
		{
		}

		// Token: 0x06013948 RID: 80200 RVA: 0x002D947C File Offset: 0x002D767C
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

		// Token: 0x06013949 RID: 80201 RVA: 0x002D9528 File Offset: 0x002D7728
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsActivityData Clone()
		{
			return new RacingBetsActivityData(this);
		}

		// Token: 0x170040FE RID: 16638
		// (get) Token: 0x0601394A RID: 80202 RVA: 0x002D9530 File Offset: 0x002D7730
		// (set) Token: 0x0601394B RID: 80203 RVA: 0x002D9538 File Offset: 0x002D7738
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

		// Token: 0x170040FF RID: 16639
		// (get) Token: 0x0601394C RID: 80204 RVA: 0x002D9541 File Offset: 0x002D7741
		// (set) Token: 0x0601394D RID: 80205 RVA: 0x002D9549 File Offset: 0x002D7749
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

		// Token: 0x17004100 RID: 16640
		// (get) Token: 0x0601394E RID: 80206 RVA: 0x002D9552 File Offset: 0x002D7752
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RacingBetsGroupMatchesInfo> MatchInfos
		{
			get
			{
				return this.matchInfos_;
			}
		}

		// Token: 0x17004101 RID: 16641
		// (get) Token: 0x0601394F RID: 80207 RVA: 0x002D955A File Offset: 0x002D775A
		// (set) Token: 0x06013950 RID: 80208 RVA: 0x002D9562 File Offset: 0x002D7762
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

		// Token: 0x17004102 RID: 16642
		// (get) Token: 0x06013951 RID: 80209 RVA: 0x002D956B File Offset: 0x002D776B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ConditionTaskData> TaskDatas
		{
			get
			{
				return this.taskDatas_;
			}
		}

		// Token: 0x17004103 RID: 16643
		// (get) Token: 0x06013952 RID: 80210 RVA: 0x002D9573 File Offset: 0x002D7773
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<long> RankListUpdateTime
		{
			get
			{
				return this.rankListUpdateTime_;
			}
		}

		// Token: 0x17004104 RID: 16644
		// (get) Token: 0x06013953 RID: 80211 RVA: 0x002D957B File Offset: 0x002D777B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> CloseSettleMenuLegMatchList
		{
			get
			{
				return this.closeSettleMenuLegMatchList_;
			}
		}

		// Token: 0x06013954 RID: 80212 RVA: 0x002D9583 File Offset: 0x002D7783
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RacingBetsActivityData);
		}

		// Token: 0x06013955 RID: 80213 RVA: 0x002D9594 File Offset: 0x002D7794
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RacingBetsActivityData other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && object.Equals(this.ActivityStarAndEndTime, other.ActivityStarAndEndTime) && this.matchInfos_.Equals(other.matchInfos_) && object.Equals(this.PlayerInfo, other.PlayerInfo) && this.taskDatas_.Equals(other.taskDatas_) && this.rankListUpdateTime_.Equals(other.rankListUpdateTime_) && this.closeSettleMenuLegMatchList_.Equals(other.closeSettleMenuLegMatchList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06013956 RID: 80214 RVA: 0x002D964C File Offset: 0x002D784C
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

		// Token: 0x06013957 RID: 80215 RVA: 0x002D96EF File Offset: 0x002D78EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06013958 RID: 80216 RVA: 0x002D96FC File Offset: 0x002D78FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06013959 RID: 80217 RVA: 0x002D9708 File Offset: 0x002D7908
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

		// Token: 0x0601395A RID: 80218 RVA: 0x002D97C0 File Offset: 0x002D79C0
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

		// Token: 0x0601395B RID: 80219 RVA: 0x002D987C File Offset: 0x002D7A7C
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

		// Token: 0x0601395C RID: 80220 RVA: 0x002D9954 File Offset: 0x002D7B54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601395D RID: 80221 RVA: 0x002D9960 File Offset: 0x002D7B60
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

		// Token: 0x04007855 RID: 30805
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007856 RID: 30806
		public const int ActivityIdFieldNumber = 1;

		// Token: 0x04007857 RID: 30807
		private int activityId_;

		// Token: 0x04007858 RID: 30808
		public const int ActivityStarAndEndTimeFieldNumber = 2;

		// Token: 0x04007859 RID: 30809
		private RacingBetsTimeTuple activityStarAndEndTime_;

		// Token: 0x0400785A RID: 30810
		public const int MatchInfosFieldNumber = 3;

		// Token: 0x0400785B RID: 30811
		private static readonly FieldCodec<RacingBetsGroupMatchesInfo> _repeated_matchInfos_codec = FieldCodec.ForMessage<RacingBetsGroupMatchesInfo>(26U, RacingBetsGroupMatchesInfo.Parser);

		// Token: 0x0400785C RID: 30812
		private readonly RepeatedField<RacingBetsGroupMatchesInfo> matchInfos_ = new RepeatedField<RacingBetsGroupMatchesInfo>();

		// Token: 0x0400785D RID: 30813
		public const int PlayerInfoFieldNumber = 4;

		// Token: 0x0400785E RID: 30814
		private RacingBetPlayerInfo playerInfo_;

		// Token: 0x0400785F RID: 30815
		public const int TaskDatasFieldNumber = 5;

		// Token: 0x04007860 RID: 30816
		private static readonly FieldCodec<ConditionTaskData> _repeated_taskDatas_codec = FieldCodec.ForMessage<ConditionTaskData>(42U, ConditionTaskData.Parser);

		// Token: 0x04007861 RID: 30817
		private readonly RepeatedField<ConditionTaskData> taskDatas_ = new RepeatedField<ConditionTaskData>();

		// Token: 0x04007862 RID: 30818
		public const int RankListUpdateTimeFieldNumber = 6;

		// Token: 0x04007863 RID: 30819
		private static readonly FieldCodec<long> _repeated_rankListUpdateTime_codec = FieldCodec.ForInt64(50U);

		// Token: 0x04007864 RID: 30820
		private readonly RepeatedField<long> rankListUpdateTime_ = new RepeatedField<long>();

		// Token: 0x04007865 RID: 30821
		public const int CloseSettleMenuLegMatchListFieldNumber = 7;

		// Token: 0x04007866 RID: 30822
		private static readonly FieldCodec<int> _repeated_closeSettleMenuLegMatchList_codec = FieldCodec.ForInt32(58U);

		// Token: 0x04007867 RID: 30823
		private readonly RepeatedField<int> closeSettleMenuLegMatchList_ = new RepeatedField<int>();
	}
}
