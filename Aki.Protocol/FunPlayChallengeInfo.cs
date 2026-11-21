using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000669 RID: 1641
	public sealed class FunPlayChallengeInfo : IMessage<FunPlayChallengeInfo>, IMessage, IEquatable<FunPlayChallengeInfo>, IDeepCloneable<FunPlayChallengeInfo>, IBufferMessage
	{
		// Token: 0x060096CF RID: 38607 RVA: 0x0016BFA5 File Offset: 0x0016A1A5
		[NullableContext(1)]
		public static FunPlayChallengeInfo Create()
		{
			return new FunPlayChallengeInfo();
		}

		// Token: 0x17001E04 RID: 7684
		// (get) Token: 0x060096D0 RID: 38608 RVA: 0x0016BFAC File Offset: 0x0016A1AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<FunPlayChallengeInfo> Parser
		{
			get
			{
				return FunPlayChallengeInfo._parser;
			}
		}

		// Token: 0x17001E05 RID: 7685
		// (get) Token: 0x060096D1 RID: 38609 RVA: 0x0016BFB3 File Offset: 0x0016A1B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001E06 RID: 7686
		// (get) Token: 0x060096D2 RID: 38610 RVA: 0x0016BFB6 File Offset: 0x0016A1B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FunPlayChallengeInfo.Descriptor;
			}
		}

		// Token: 0x060096D3 RID: 38611 RVA: 0x0016BFBD File Offset: 0x0016A1BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FunPlayChallengeInfo()
		{
		}

		// Token: 0x060096D4 RID: 38612 RVA: 0x0016BFD0 File Offset: 0x0016A1D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FunPlayChallengeInfo(FunPlayChallengeInfo other) : this()
		{
			this.challengeId_ = other.challengeId_;
			this.unlockTime_ = other.unlockTime_;
			this.rewardStatus_ = other.rewardStatus_;
			this.sharpCommentIds_ = other.sharpCommentIds_.Clone();
			this.finishTime_ = other.finishTime_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060096D5 RID: 38613 RVA: 0x0016C035 File Offset: 0x0016A235
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FunPlayChallengeInfo Clone()
		{
			return new FunPlayChallengeInfo(this);
		}

		// Token: 0x17001E07 RID: 7687
		// (get) Token: 0x060096D6 RID: 38614 RVA: 0x0016C03D File Offset: 0x0016A23D
		// (set) Token: 0x060096D7 RID: 38615 RVA: 0x0016C045 File Offset: 0x0016A245
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ChallengeId
		{
			get
			{
				return this.challengeId_;
			}
			set
			{
				this.challengeId_ = value;
			}
		}

		// Token: 0x17001E08 RID: 7688
		// (get) Token: 0x060096D8 RID: 38616 RVA: 0x0016C04E File Offset: 0x0016A24E
		// (set) Token: 0x060096D9 RID: 38617 RVA: 0x0016C056 File Offset: 0x0016A256
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long UnlockTime
		{
			get
			{
				return this.unlockTime_;
			}
			set
			{
				this.unlockTime_ = value;
			}
		}

		// Token: 0x17001E09 RID: 7689
		// (get) Token: 0x060096DA RID: 38618 RVA: 0x0016C05F File Offset: 0x0016A25F
		// (set) Token: 0x060096DB RID: 38619 RVA: 0x0016C067 File Offset: 0x0016A267
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FunPlayChallengeRewardStatus RewardStatus
		{
			get
			{
				return this.rewardStatus_;
			}
			set
			{
				this.rewardStatus_ = value;
			}
		}

		// Token: 0x17001E0A RID: 7690
		// (get) Token: 0x060096DC RID: 38620 RVA: 0x0016C070 File Offset: 0x0016A270
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> SharpCommentIds
		{
			get
			{
				return this.sharpCommentIds_;
			}
		}

		// Token: 0x17001E0B RID: 7691
		// (get) Token: 0x060096DD RID: 38621 RVA: 0x0016C078 File Offset: 0x0016A278
		// (set) Token: 0x060096DE RID: 38622 RVA: 0x0016C080 File Offset: 0x0016A280
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long FinishTime
		{
			get
			{
				return this.finishTime_;
			}
			set
			{
				this.finishTime_ = value;
			}
		}

		// Token: 0x060096DF RID: 38623 RVA: 0x0016C089 File Offset: 0x0016A289
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FunPlayChallengeInfo);
		}

		// Token: 0x060096E0 RID: 38624 RVA: 0x0016C098 File Offset: 0x0016A298
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FunPlayChallengeInfo other)
		{
			return other != null && (other == this || (this.ChallengeId == other.ChallengeId && this.UnlockTime == other.UnlockTime && this.RewardStatus == other.RewardStatus && this.sharpCommentIds_.Equals(other.sharpCommentIds_) && this.FinishTime == other.FinishTime && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060096E1 RID: 38625 RVA: 0x0016C118 File Offset: 0x0016A318
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ChallengeId != 0)
			{
				num ^= this.ChallengeId.GetHashCode();
			}
			if (this.UnlockTime != 0L)
			{
				num ^= this.UnlockTime.GetHashCode();
			}
			if (this.RewardStatus != FunPlayChallengeRewardStatus.FunPlayCanNoReward)
			{
				num ^= this.RewardStatus.GetHashCode();
			}
			num ^= this.sharpCommentIds_.GetHashCode();
			if (this.FinishTime != 0L)
			{
				num ^= this.FinishTime.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060096E2 RID: 38626 RVA: 0x0016C1B6 File Offset: 0x0016A3B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060096E3 RID: 38627 RVA: 0x0016C1C3 File Offset: 0x0016A3C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060096E4 RID: 38628 RVA: 0x0016C1CC File Offset: 0x0016A3CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ChallengeId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.ChallengeId);
			}
			if (this.UnlockTime != 0L)
			{
				output.WriteRawTag(16);
				output.WriteInt64(this.UnlockTime);
			}
			if (this.RewardStatus != FunPlayChallengeRewardStatus.FunPlayCanNoReward)
			{
				output.WriteRawTag(24);
				output.WriteEnum((int)this.RewardStatus);
			}
			this.sharpCommentIds_.WriteTo(ref output, FunPlayChallengeInfo._repeated_sharpCommentIds_codec);
			if (this.FinishTime != 0L)
			{
				output.WriteRawTag(40);
				output.WriteInt64(this.FinishTime);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060096E5 RID: 38629 RVA: 0x0016C270 File Offset: 0x0016A470
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ChallengeId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ChallengeId);
			}
			if (this.UnlockTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.UnlockTime);
			}
			if (this.RewardStatus != FunPlayChallengeRewardStatus.FunPlayCanNoReward)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.RewardStatus);
			}
			num += this.sharpCommentIds_.CalculateSize(FunPlayChallengeInfo._repeated_sharpCommentIds_codec);
			if (this.FinishTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.FinishTime);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060096E6 RID: 38630 RVA: 0x0016C30C File Offset: 0x0016A50C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FunPlayChallengeInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ChallengeId != 0)
			{
				this.ChallengeId = other.ChallengeId;
			}
			if (other.UnlockTime != 0L)
			{
				this.UnlockTime = other.UnlockTime;
			}
			if (other.RewardStatus != FunPlayChallengeRewardStatus.FunPlayCanNoReward)
			{
				this.RewardStatus = other.RewardStatus;
			}
			this.sharpCommentIds_.Add(other.sharpCommentIds_);
			if (other.FinishTime != 0L)
			{
				this.FinishTime = other.FinishTime;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060096E7 RID: 38631 RVA: 0x0016C395 File Offset: 0x0016A595
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060096E8 RID: 38632 RVA: 0x0016C3A0 File Offset: 0x0016A5A0
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
				if (num <= 24U)
				{
					if (num == 8U)
					{
						this.ChallengeId = input.ReadInt32();
						continue;
					}
					if (num == 16U)
					{
						this.UnlockTime = input.ReadInt64();
						continue;
					}
					if (num == 24U)
					{
						this.RewardStatus = (FunPlayChallengeRewardStatus)input.ReadEnum();
						continue;
					}
				}
				else
				{
					if (num == 32U || num == 34U)
					{
						this.sharpCommentIds_.AddEntriesFrom(ref input, FunPlayChallengeInfo._repeated_sharpCommentIds_codec);
						continue;
					}
					if (num == 40U)
					{
						this.FinishTime = input.ReadInt64();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04004822 RID: 18466
		private static readonly MessageParser<FunPlayChallengeInfo> _parser = new MessageParser<FunPlayChallengeInfo>(() => new FunPlayChallengeInfo());

		// Token: 0x04004823 RID: 18467
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004824 RID: 18468
		public const int ChallengeIdFieldNumber = 1;

		// Token: 0x04004825 RID: 18469
		private int challengeId_;

		// Token: 0x04004826 RID: 18470
		public const int UnlockTimeFieldNumber = 2;

		// Token: 0x04004827 RID: 18471
		private long unlockTime_;

		// Token: 0x04004828 RID: 18472
		public const int RewardStatusFieldNumber = 3;

		// Token: 0x04004829 RID: 18473
		private FunPlayChallengeRewardStatus rewardStatus_;

		// Token: 0x0400482A RID: 18474
		public const int SharpCommentIdsFieldNumber = 4;

		// Token: 0x0400482B RID: 18475
		private static readonly FieldCodec<int> _repeated_sharpCommentIds_codec = FieldCodec.ForInt32(34U);

		// Token: 0x0400482C RID: 18476
		private readonly RepeatedField<int> sharpCommentIds_ = new RepeatedField<int>();

		// Token: 0x0400482D RID: 18477
		public const int FinishTimeFieldNumber = 5;

		// Token: 0x0400482E RID: 18478
		private long finishTime_;
	}
}
