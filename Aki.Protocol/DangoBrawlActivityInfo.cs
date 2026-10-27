using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000331 RID: 817
	public sealed class DangoBrawlActivityInfo : IMessage<DangoBrawlActivityInfo>, IMessage, IEquatable<DangoBrawlActivityInfo>, IDeepCloneable<DangoBrawlActivityInfo>, IBufferMessage
	{
		// Token: 0x06005226 RID: 21030 RVA: 0x000C88A2 File Offset: 0x000C6AA2
		[NullableContext(1)]
		public static DangoBrawlActivityInfo Create()
		{
			return new DangoBrawlActivityInfo();
		}

		// Token: 0x17000EDE RID: 3806
		// (get) Token: 0x06005227 RID: 21031 RVA: 0x000C88A9 File Offset: 0x000C6AA9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000EDF RID: 3807
		// (get) Token: 0x06005228 RID: 21032 RVA: 0x000C88AC File Offset: 0x000C6AAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DangoBrawlActivityInfo.Descriptor;
			}
		}

		// Token: 0x06005229 RID: 21033 RVA: 0x000C88B3 File Offset: 0x000C6AB3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlActivityInfo()
		{
		}

		// Token: 0x0600522A RID: 21034 RVA: 0x000C88F4 File Offset: 0x000C6AF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlActivityInfo(DangoBrawlActivityInfo other) : this()
		{
			this.conditionTasks_ = other.conditionTasks_.Clone();
			this.unlockedRoleIds_ = other.unlockedRoleIds_.Clone();
			this.unlockedItemIds_ = other.unlockedItemIds_.Clone();
			this.challengeInfos_ = other.challengeInfos_.Clone();
			this.saveMatchBrief_ = ((other.saveMatchBrief_ != null) ? other.saveMatchBrief_.Clone() : null);
			this.rewardScoreIds_ = other.rewardScoreIds_.Clone();
			this.limitCoinCost_ = other.limitCoinCost_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600522B RID: 21035 RVA: 0x000C8995 File Offset: 0x000C6B95
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlActivityInfo Clone()
		{
			return new DangoBrawlActivityInfo(this);
		}

		// Token: 0x17000EE0 RID: 3808
		// (get) Token: 0x0600522C RID: 21036 RVA: 0x000C899D File Offset: 0x000C6B9D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ConditionTask> ConditionTasks
		{
			get
			{
				return this.conditionTasks_;
			}
		}

		// Token: 0x17000EE1 RID: 3809
		// (get) Token: 0x0600522D RID: 21037 RVA: 0x000C89A5 File Offset: 0x000C6BA5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> UnlockedRoleIds
		{
			get
			{
				return this.unlockedRoleIds_;
			}
		}

		// Token: 0x17000EE2 RID: 3810
		// (get) Token: 0x0600522E RID: 21038 RVA: 0x000C89AD File Offset: 0x000C6BAD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> UnlockedItemIds
		{
			get
			{
				return this.unlockedItemIds_;
			}
		}

		// Token: 0x17000EE3 RID: 3811
		// (get) Token: 0x0600522F RID: 21039 RVA: 0x000C89B5 File Offset: 0x000C6BB5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<DangoBrawlChallengeInfo> ChallengeInfos
		{
			get
			{
				return this.challengeInfos_;
			}
		}

		// Token: 0x17000EE4 RID: 3812
		// (get) Token: 0x06005230 RID: 21040 RVA: 0x000C89BD File Offset: 0x000C6BBD
		// (set) Token: 0x06005231 RID: 21041 RVA: 0x000C89C5 File Offset: 0x000C6BC5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlSaveMatchBrief SaveMatchBrief
		{
			get
			{
				return this.saveMatchBrief_;
			}
			set
			{
				this.saveMatchBrief_ = value;
			}
		}

		// Token: 0x17000EE5 RID: 3813
		// (get) Token: 0x06005232 RID: 21042 RVA: 0x000C89CE File Offset: 0x000C6BCE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> RewardScoreIds
		{
			get
			{
				return this.rewardScoreIds_;
			}
		}

		// Token: 0x17000EE6 RID: 3814
		// (get) Token: 0x06005233 RID: 21043 RVA: 0x000C89D6 File Offset: 0x000C6BD6
		// (set) Token: 0x06005234 RID: 21044 RVA: 0x000C89DE File Offset: 0x000C6BDE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int LimitCoinCost
		{
			get
			{
				return this.limitCoinCost_;
			}
			set
			{
				this.limitCoinCost_ = value;
			}
		}

		// Token: 0x06005235 RID: 21045 RVA: 0x000C89E7 File Offset: 0x000C6BE7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DangoBrawlActivityInfo);
		}

		// Token: 0x06005236 RID: 21046 RVA: 0x000C89F8 File Offset: 0x000C6BF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DangoBrawlActivityInfo other)
		{
			return other != null && (other == this || (this.conditionTasks_.Equals(other.conditionTasks_) && this.unlockedRoleIds_.Equals(other.unlockedRoleIds_) && this.unlockedItemIds_.Equals(other.unlockedItemIds_) && this.challengeInfos_.Equals(other.challengeInfos_) && object.Equals(this.SaveMatchBrief, other.SaveMatchBrief) && this.rewardScoreIds_.Equals(other.rewardScoreIds_) && this.LimitCoinCost == other.LimitCoinCost && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005237 RID: 21047 RVA: 0x000C8AB0 File Offset: 0x000C6CB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.conditionTasks_.GetHashCode();
			num ^= this.unlockedRoleIds_.GetHashCode();
			num ^= this.unlockedItemIds_.GetHashCode();
			num ^= this.challengeInfos_.GetHashCode();
			if (this.saveMatchBrief_ != null)
			{
				num ^= this.SaveMatchBrief.GetHashCode();
			}
			num ^= this.rewardScoreIds_.GetHashCode();
			if (this.LimitCoinCost != 0)
			{
				num ^= this.LimitCoinCost.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06005238 RID: 21048 RVA: 0x000C8B4B File Offset: 0x000C6D4B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06005239 RID: 21049 RVA: 0x000C8B58 File Offset: 0x000C6D58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600523A RID: 21050 RVA: 0x000C8B64 File Offset: 0x000C6D64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.conditionTasks_.WriteTo(ref output, DangoBrawlActivityInfo._repeated_conditionTasks_codec);
			this.unlockedRoleIds_.WriteTo(ref output, DangoBrawlActivityInfo._repeated_unlockedRoleIds_codec);
			this.unlockedItemIds_.WriteTo(ref output, DangoBrawlActivityInfo._repeated_unlockedItemIds_codec);
			this.challengeInfos_.WriteTo(ref output, DangoBrawlActivityInfo._repeated_challengeInfos_codec);
			if (this.saveMatchBrief_ != null)
			{
				output.WriteRawTag(42);
				output.WriteMessage(this.SaveMatchBrief);
			}
			this.rewardScoreIds_.WriteTo(ref output, DangoBrawlActivityInfo._repeated_rewardScoreIds_codec);
			if (this.LimitCoinCost != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.LimitCoinCost);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600523B RID: 21051 RVA: 0x000C8C14 File Offset: 0x000C6E14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.conditionTasks_.CalculateSize(DangoBrawlActivityInfo._repeated_conditionTasks_codec);
			num += this.unlockedRoleIds_.CalculateSize(DangoBrawlActivityInfo._repeated_unlockedRoleIds_codec);
			num += this.unlockedItemIds_.CalculateSize(DangoBrawlActivityInfo._repeated_unlockedItemIds_codec);
			num += this.challengeInfos_.CalculateSize(DangoBrawlActivityInfo._repeated_challengeInfos_codec);
			if (this.saveMatchBrief_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.SaveMatchBrief);
			}
			num += this.rewardScoreIds_.CalculateSize(DangoBrawlActivityInfo._repeated_rewardScoreIds_codec);
			if (this.LimitCoinCost != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.LimitCoinCost);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600523C RID: 21052 RVA: 0x000C8CCC File Offset: 0x000C6ECC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DangoBrawlActivityInfo other)
		{
			if (other == null)
			{
				return;
			}
			this.conditionTasks_.Add(other.conditionTasks_);
			this.unlockedRoleIds_.Add(other.unlockedRoleIds_);
			this.unlockedItemIds_.Add(other.unlockedItemIds_);
			this.challengeInfos_.Add(other.challengeInfos_);
			if (other.saveMatchBrief_ != null)
			{
				if (this.saveMatchBrief_ == null)
				{
					this.SaveMatchBrief = new DangoBrawlSaveMatchBrief();
				}
				this.SaveMatchBrief.MergeFrom(other.SaveMatchBrief);
			}
			this.rewardScoreIds_.Add(other.rewardScoreIds_);
			if (other.LimitCoinCost != 0)
			{
				this.LimitCoinCost = other.LimitCoinCost;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600523D RID: 21053 RVA: 0x000C8D89 File Offset: 0x000C6F89
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600523E RID: 21054 RVA: 0x000C8D94 File Offset: 0x000C6F94
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
				if (num <= 26U)
				{
					if (num <= 16U)
					{
						if (num == 10U)
						{
							this.conditionTasks_.AddEntriesFrom(ref input, DangoBrawlActivityInfo._repeated_conditionTasks_codec);
							continue;
						}
						if (num != 16U)
						{
							goto IL_5C;
						}
					}
					else if (num != 18U)
					{
						if (num != 24U && num != 26U)
						{
							goto IL_5C;
						}
						this.unlockedItemIds_.AddEntriesFrom(ref input, DangoBrawlActivityInfo._repeated_unlockedItemIds_codec);
						continue;
					}
					this.unlockedRoleIds_.AddEntriesFrom(ref input, DangoBrawlActivityInfo._repeated_unlockedRoleIds_codec);
					continue;
				}
				if (num <= 42U)
				{
					if (num == 34U)
					{
						this.challengeInfos_.AddEntriesFrom(ref input, DangoBrawlActivityInfo._repeated_challengeInfos_codec);
						continue;
					}
					if (num == 42U)
					{
						if (this.saveMatchBrief_ == null)
						{
							this.SaveMatchBrief = new DangoBrawlSaveMatchBrief();
						}
						input.ReadMessage(this.SaveMatchBrief);
						continue;
					}
				}
				else
				{
					if (num == 48U || num == 50U)
					{
						this.rewardScoreIds_.AddEntriesFrom(ref input, DangoBrawlActivityInfo._repeated_rewardScoreIds_codec);
						continue;
					}
					if (num == 56U)
					{
						this.LimitCoinCost = input.ReadInt32();
						continue;
					}
				}
				IL_5C:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04003313 RID: 13075
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003314 RID: 13076
		public const int ConditionTasksFieldNumber = 1;

		// Token: 0x04003315 RID: 13077
		private static readonly FieldCodec<ConditionTask> _repeated_conditionTasks_codec = FieldCodec.ForMessage<ConditionTask>(10U, ConditionTask.Parser);

		// Token: 0x04003316 RID: 13078
		private readonly RepeatedField<ConditionTask> conditionTasks_ = new RepeatedField<ConditionTask>();

		// Token: 0x04003317 RID: 13079
		public const int UnlockedRoleIdsFieldNumber = 2;

		// Token: 0x04003318 RID: 13080
		private static readonly FieldCodec<int> _repeated_unlockedRoleIds_codec = FieldCodec.ForInt32(18U);

		// Token: 0x04003319 RID: 13081
		private readonly RepeatedField<int> unlockedRoleIds_ = new RepeatedField<int>();

		// Token: 0x0400331A RID: 13082
		public const int UnlockedItemIdsFieldNumber = 3;

		// Token: 0x0400331B RID: 13083
		private static readonly FieldCodec<int> _repeated_unlockedItemIds_codec = FieldCodec.ForInt32(26U);

		// Token: 0x0400331C RID: 13084
		private readonly RepeatedField<int> unlockedItemIds_ = new RepeatedField<int>();

		// Token: 0x0400331D RID: 13085
		public const int ChallengeInfosFieldNumber = 4;

		// Token: 0x0400331E RID: 13086
		private static readonly FieldCodec<DangoBrawlChallengeInfo> _repeated_challengeInfos_codec = FieldCodec.ForMessage<DangoBrawlChallengeInfo>(34U, DangoBrawlChallengeInfo.Parser);

		// Token: 0x0400331F RID: 13087
		private readonly RepeatedField<DangoBrawlChallengeInfo> challengeInfos_ = new RepeatedField<DangoBrawlChallengeInfo>();

		// Token: 0x04003320 RID: 13088
		public const int SaveMatchBriefFieldNumber = 5;

		// Token: 0x04003321 RID: 13089
		private DangoBrawlSaveMatchBrief saveMatchBrief_;

		// Token: 0x04003322 RID: 13090
		public const int RewardScoreIdsFieldNumber = 6;

		// Token: 0x04003323 RID: 13091
		private static readonly FieldCodec<int> _repeated_rewardScoreIds_codec = FieldCodec.ForInt32(50U);

		// Token: 0x04003324 RID: 13092
		private readonly RepeatedField<int> rewardScoreIds_ = new RepeatedField<int>();

		// Token: 0x04003325 RID: 13093
		public const int LimitCoinCostFieldNumber = 7;

		// Token: 0x04003326 RID: 13094
		private int limitCoinCost_;
	}
}
