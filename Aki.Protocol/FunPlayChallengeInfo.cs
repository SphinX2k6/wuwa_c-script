using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200067D RID: 1661
	public sealed class FunPlayChallengeInfo : IMessage<FunPlayChallengeInfo>, IMessage, IEquatable<FunPlayChallengeInfo>, IDeepCloneable<FunPlayChallengeInfo>, IBufferMessage
	{
		// Token: 0x06009825 RID: 38949 RVA: 0x0016E9D9 File Offset: 0x0016CBD9
		[NullableContext(1)]
		public static FunPlayChallengeInfo Create()
		{
			return new FunPlayChallengeInfo();
		}

		// Token: 0x17001E4E RID: 7758
		// (get) Token: 0x06009826 RID: 38950 RVA: 0x0016E9E0 File Offset: 0x0016CBE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<FunPlayChallengeInfo> Parser
		{
			get
			{
				return FunPlayChallengeInfo._parser;
			}
		}

		// Token: 0x17001E4F RID: 7759
		// (get) Token: 0x06009827 RID: 38951 RVA: 0x0016E9E7 File Offset: 0x0016CBE7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001E50 RID: 7760
		// (get) Token: 0x06009828 RID: 38952 RVA: 0x0016E9EA File Offset: 0x0016CBEA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FunPlayChallengeInfo.Descriptor;
			}
		}

		// Token: 0x06009829 RID: 38953 RVA: 0x0016E9F1 File Offset: 0x0016CBF1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FunPlayChallengeInfo()
		{
		}

		// Token: 0x0600982A RID: 38954 RVA: 0x0016EA04 File Offset: 0x0016CC04
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

		// Token: 0x0600982B RID: 38955 RVA: 0x0016EA69 File Offset: 0x0016CC69
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FunPlayChallengeInfo Clone()
		{
			return new FunPlayChallengeInfo(this);
		}

		// Token: 0x17001E51 RID: 7761
		// (get) Token: 0x0600982C RID: 38956 RVA: 0x0016EA71 File Offset: 0x0016CC71
		// (set) Token: 0x0600982D RID: 38957 RVA: 0x0016EA79 File Offset: 0x0016CC79
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

		// Token: 0x17001E52 RID: 7762
		// (get) Token: 0x0600982E RID: 38958 RVA: 0x0016EA82 File Offset: 0x0016CC82
		// (set) Token: 0x0600982F RID: 38959 RVA: 0x0016EA8A File Offset: 0x0016CC8A
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

		// Token: 0x17001E53 RID: 7763
		// (get) Token: 0x06009830 RID: 38960 RVA: 0x0016EA93 File Offset: 0x0016CC93
		// (set) Token: 0x06009831 RID: 38961 RVA: 0x0016EA9B File Offset: 0x0016CC9B
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

		// Token: 0x17001E54 RID: 7764
		// (get) Token: 0x06009832 RID: 38962 RVA: 0x0016EAA4 File Offset: 0x0016CCA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> SharpCommentIds
		{
			get
			{
				return this.sharpCommentIds_;
			}
		}

		// Token: 0x17001E55 RID: 7765
		// (get) Token: 0x06009833 RID: 38963 RVA: 0x0016EAAC File Offset: 0x0016CCAC
		// (set) Token: 0x06009834 RID: 38964 RVA: 0x0016EAB4 File Offset: 0x0016CCB4
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

		// Token: 0x06009835 RID: 38965 RVA: 0x0016EABD File Offset: 0x0016CCBD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FunPlayChallengeInfo);
		}

		// Token: 0x06009836 RID: 38966 RVA: 0x0016EACC File Offset: 0x0016CCCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FunPlayChallengeInfo other)
		{
			return other != null && (other == this || (this.ChallengeId == other.ChallengeId && this.UnlockTime == other.UnlockTime && this.RewardStatus == other.RewardStatus && this.sharpCommentIds_.Equals(other.sharpCommentIds_) && this.FinishTime == other.FinishTime && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009837 RID: 38967 RVA: 0x0016EB4C File Offset: 0x0016CD4C
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

		// Token: 0x06009838 RID: 38968 RVA: 0x0016EBEA File Offset: 0x0016CDEA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06009839 RID: 38969 RVA: 0x0016EBF7 File Offset: 0x0016CDF7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600983A RID: 38970 RVA: 0x0016EC00 File Offset: 0x0016CE00
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

		// Token: 0x0600983B RID: 38971 RVA: 0x0016ECA4 File Offset: 0x0016CEA4
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

		// Token: 0x0600983C RID: 38972 RVA: 0x0016ED40 File Offset: 0x0016CF40
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

		// Token: 0x0600983D RID: 38973 RVA: 0x0016EDC9 File Offset: 0x0016CFC9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600983E RID: 38974 RVA: 0x0016EDD4 File Offset: 0x0016CFD4
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

		// Token: 0x04004829 RID: 18473
		private static readonly MessageParser<FunPlayChallengeInfo> _parser = new MessageParser<FunPlayChallengeInfo>(() => new FunPlayChallengeInfo());

		// Token: 0x0400482A RID: 18474
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400482B RID: 18475
		public const int ChallengeIdFieldNumber = 1;

		// Token: 0x0400482C RID: 18476
		private int challengeId_;

		// Token: 0x0400482D RID: 18477
		public const int UnlockTimeFieldNumber = 2;

		// Token: 0x0400482E RID: 18478
		private long unlockTime_;

		// Token: 0x0400482F RID: 18479
		public const int RewardStatusFieldNumber = 3;

		// Token: 0x04004830 RID: 18480
		private FunPlayChallengeRewardStatus rewardStatus_;

		// Token: 0x04004831 RID: 18481
		public const int SharpCommentIdsFieldNumber = 4;

		// Token: 0x04004832 RID: 18482
		private static readonly FieldCodec<int> _repeated_sharpCommentIds_codec = FieldCodec.ForInt32(34U);

		// Token: 0x04004833 RID: 18483
		private readonly RepeatedField<int> sharpCommentIds_ = new RepeatedField<int>();

		// Token: 0x04004834 RID: 18484
		public const int FinishTimeFieldNumber = 5;

		// Token: 0x04004835 RID: 18485
		private long finishTime_;
	}
}
