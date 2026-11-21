using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000339 RID: 825
	public sealed class DangoBrawlActivityInfo : IMessage<DangoBrawlActivityInfo>, IMessage, IEquatable<DangoBrawlActivityInfo>, IDeepCloneable<DangoBrawlActivityInfo>, IBufferMessage
	{
		// Token: 0x06005313 RID: 21267 RVA: 0x000CAF28 File Offset: 0x000C9128
		[NullableContext(1)]
		public static DangoBrawlActivityInfo Create()
		{
			return new DangoBrawlActivityInfo();
		}

		// Token: 0x17000F0F RID: 3855
		// (get) Token: 0x06005314 RID: 21268 RVA: 0x000CAF2F File Offset: 0x000C912F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000F10 RID: 3856
		// (get) Token: 0x06005315 RID: 21269 RVA: 0x000CAF32 File Offset: 0x000C9132
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DangoBrawlActivityInfo.Descriptor;
			}
		}

		// Token: 0x06005316 RID: 21270 RVA: 0x000CAF39 File Offset: 0x000C9139
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlActivityInfo()
		{
		}

		// Token: 0x06005317 RID: 21271 RVA: 0x000CAF78 File Offset: 0x000C9178
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

		// Token: 0x06005318 RID: 21272 RVA: 0x000CB019 File Offset: 0x000C9219
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlActivityInfo Clone()
		{
			return new DangoBrawlActivityInfo(this);
		}

		// Token: 0x17000F11 RID: 3857
		// (get) Token: 0x06005319 RID: 21273 RVA: 0x000CB021 File Offset: 0x000C9221
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ConditionTask> ConditionTasks
		{
			get
			{
				return this.conditionTasks_;
			}
		}

		// Token: 0x17000F12 RID: 3858
		// (get) Token: 0x0600531A RID: 21274 RVA: 0x000CB029 File Offset: 0x000C9229
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> UnlockedRoleIds
		{
			get
			{
				return this.unlockedRoleIds_;
			}
		}

		// Token: 0x17000F13 RID: 3859
		// (get) Token: 0x0600531B RID: 21275 RVA: 0x000CB031 File Offset: 0x000C9231
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> UnlockedItemIds
		{
			get
			{
				return this.unlockedItemIds_;
			}
		}

		// Token: 0x17000F14 RID: 3860
		// (get) Token: 0x0600531C RID: 21276 RVA: 0x000CB039 File Offset: 0x000C9239
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<DangoBrawlChallengeInfo> ChallengeInfos
		{
			get
			{
				return this.challengeInfos_;
			}
		}

		// Token: 0x17000F15 RID: 3861
		// (get) Token: 0x0600531D RID: 21277 RVA: 0x000CB041 File Offset: 0x000C9241
		// (set) Token: 0x0600531E RID: 21278 RVA: 0x000CB049 File Offset: 0x000C9249
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

		// Token: 0x17000F16 RID: 3862
		// (get) Token: 0x0600531F RID: 21279 RVA: 0x000CB052 File Offset: 0x000C9252
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> RewardScoreIds
		{
			get
			{
				return this.rewardScoreIds_;
			}
		}

		// Token: 0x17000F17 RID: 3863
		// (get) Token: 0x06005320 RID: 21280 RVA: 0x000CB05A File Offset: 0x000C925A
		// (set) Token: 0x06005321 RID: 21281 RVA: 0x000CB062 File Offset: 0x000C9262
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

		// Token: 0x06005322 RID: 21282 RVA: 0x000CB06B File Offset: 0x000C926B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DangoBrawlActivityInfo);
		}

		// Token: 0x06005323 RID: 21283 RVA: 0x000CB07C File Offset: 0x000C927C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DangoBrawlActivityInfo other)
		{
			return other != null && (other == this || (this.conditionTasks_.Equals(other.conditionTasks_) && this.unlockedRoleIds_.Equals(other.unlockedRoleIds_) && this.unlockedItemIds_.Equals(other.unlockedItemIds_) && this.challengeInfos_.Equals(other.challengeInfos_) && object.Equals(this.SaveMatchBrief, other.SaveMatchBrief) && this.rewardScoreIds_.Equals(other.rewardScoreIds_) && this.LimitCoinCost == other.LimitCoinCost && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005324 RID: 21284 RVA: 0x000CB134 File Offset: 0x000C9334
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

		// Token: 0x06005325 RID: 21285 RVA: 0x000CB1CF File Offset: 0x000C93CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06005326 RID: 21286 RVA: 0x000CB1DC File Offset: 0x000C93DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005327 RID: 21287 RVA: 0x000CB1E8 File Offset: 0x000C93E8
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

		// Token: 0x06005328 RID: 21288 RVA: 0x000CB298 File Offset: 0x000C9498
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

		// Token: 0x06005329 RID: 21289 RVA: 0x000CB350 File Offset: 0x000C9550
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

		// Token: 0x0600532A RID: 21290 RVA: 0x000CB40D File Offset: 0x000C960D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600532B RID: 21291 RVA: 0x000CB418 File Offset: 0x000C9618
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

		// Token: 0x040033AF RID: 13231
		private UnknownFieldSet _unknownFields;

		// Token: 0x040033B0 RID: 13232
		public const int ConditionTasksFieldNumber = 1;

		// Token: 0x040033B1 RID: 13233
		private static readonly FieldCodec<ConditionTask> _repeated_conditionTasks_codec = FieldCodec.ForMessage<ConditionTask>(10U, ConditionTask.Parser);

		// Token: 0x040033B2 RID: 13234
		private readonly RepeatedField<ConditionTask> conditionTasks_ = new RepeatedField<ConditionTask>();

		// Token: 0x040033B3 RID: 13235
		public const int UnlockedRoleIdsFieldNumber = 2;

		// Token: 0x040033B4 RID: 13236
		private static readonly FieldCodec<int> _repeated_unlockedRoleIds_codec = FieldCodec.ForInt32(18U);

		// Token: 0x040033B5 RID: 13237
		private readonly RepeatedField<int> unlockedRoleIds_ = new RepeatedField<int>();

		// Token: 0x040033B6 RID: 13238
		public const int UnlockedItemIdsFieldNumber = 3;

		// Token: 0x040033B7 RID: 13239
		private static readonly FieldCodec<int> _repeated_unlockedItemIds_codec = FieldCodec.ForInt32(26U);

		// Token: 0x040033B8 RID: 13240
		private readonly RepeatedField<int> unlockedItemIds_ = new RepeatedField<int>();

		// Token: 0x040033B9 RID: 13241
		public const int ChallengeInfosFieldNumber = 4;

		// Token: 0x040033BA RID: 13242
		private static readonly FieldCodec<DangoBrawlChallengeInfo> _repeated_challengeInfos_codec = FieldCodec.ForMessage<DangoBrawlChallengeInfo>(34U, DangoBrawlChallengeInfo.Parser);

		// Token: 0x040033BB RID: 13243
		private readonly RepeatedField<DangoBrawlChallengeInfo> challengeInfos_ = new RepeatedField<DangoBrawlChallengeInfo>();

		// Token: 0x040033BC RID: 13244
		public const int SaveMatchBriefFieldNumber = 5;

		// Token: 0x040033BD RID: 13245
		private DangoBrawlSaveMatchBrief saveMatchBrief_;

		// Token: 0x040033BE RID: 13246
		public const int RewardScoreIdsFieldNumber = 6;

		// Token: 0x040033BF RID: 13247
		private static readonly FieldCodec<int> _repeated_rewardScoreIds_codec = FieldCodec.ForInt32(50U);

		// Token: 0x040033C0 RID: 13248
		private readonly RepeatedField<int> rewardScoreIds_ = new RepeatedField<int>();

		// Token: 0x040033C1 RID: 13249
		public const int LimitCoinCostFieldNumber = 7;

		// Token: 0x040033C2 RID: 13250
		private int limitCoinCost_;
	}
}
