using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020010BE RID: 4286
	public sealed class RoleTowerChallengeSettleInfo : IMessage<RoleTowerChallengeSettleInfo>, IMessage, IEquatable<RoleTowerChallengeSettleInfo>, IDeepCloneable<RoleTowerChallengeSettleInfo>, IBufferMessage
	{
		// Token: 0x06016E8F RID: 93839 RVA: 0x00354E54 File Offset: 0x00353054
		[NullableContext(1)]
		public static RoleTowerChallengeSettleInfo Create()
		{
			return new RoleTowerChallengeSettleInfo();
		}

		// Token: 0x17004CD5 RID: 19669
		// (get) Token: 0x06016E90 RID: 93840 RVA: 0x00354E5B File Offset: 0x0035305B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004CD6 RID: 19670
		// (get) Token: 0x06016E91 RID: 93841 RVA: 0x00354E5E File Offset: 0x0035305E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleTowerChallengeSettleInfo.Descriptor;
			}
		}

		// Token: 0x06016E92 RID: 93842 RVA: 0x00354E65 File Offset: 0x00353065
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTowerChallengeSettleInfo()
		{
		}

		// Token: 0x06016E93 RID: 93843 RVA: 0x00354E70 File Offset: 0x00353070
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTowerChallengeSettleInfo(RoleTowerChallengeSettleInfo other) : this()
		{
			this.activityId_ = other.activityId_;
			this.challengeId_ = other.challengeId_;
			this.settleReason_ = other.settleReason_;
			this.currentRecord_ = ((other.currentRecord_ != null) ? other.currentRecord_.Clone() : null);
			this.bestRecord_ = ((other.bestRecord_ != null) ? other.bestRecord_.Clone() : null);
			this.isBestRecordUpdated_ = other.isBestRecordUpdated_;
			this.currentRankPercent_ = other.currentRankPercent_;
			this.bestRankPercent_ = other.bestRankPercent_;
			this.rankErrorCode_ = other.rankErrorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06016E94 RID: 93844 RVA: 0x00354F20 File Offset: 0x00353120
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTowerChallengeSettleInfo Clone()
		{
			return new RoleTowerChallengeSettleInfo(this);
		}

		// Token: 0x17004CD7 RID: 19671
		// (get) Token: 0x06016E95 RID: 93845 RVA: 0x00354F28 File Offset: 0x00353128
		// (set) Token: 0x06016E96 RID: 93846 RVA: 0x00354F30 File Offset: 0x00353130
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

		// Token: 0x17004CD8 RID: 19672
		// (get) Token: 0x06016E97 RID: 93847 RVA: 0x00354F39 File Offset: 0x00353139
		// (set) Token: 0x06016E98 RID: 93848 RVA: 0x00354F41 File Offset: 0x00353141
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

		// Token: 0x17004CD9 RID: 19673
		// (get) Token: 0x06016E99 RID: 93849 RVA: 0x00354F4A File Offset: 0x0035314A
		// (set) Token: 0x06016E9A RID: 93850 RVA: 0x00354F52 File Offset: 0x00353152
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTowerSettleReason SettleReason
		{
			get
			{
				return this.settleReason_;
			}
			set
			{
				this.settleReason_ = value;
			}
		}

		// Token: 0x17004CDA RID: 19674
		// (get) Token: 0x06016E9B RID: 93851 RVA: 0x00354F5B File Offset: 0x0035315B
		// (set) Token: 0x06016E9C RID: 93852 RVA: 0x00354F63 File Offset: 0x00353163
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTowerBestRecord CurrentRecord
		{
			get
			{
				return this.currentRecord_;
			}
			set
			{
				this.currentRecord_ = value;
			}
		}

		// Token: 0x17004CDB RID: 19675
		// (get) Token: 0x06016E9D RID: 93853 RVA: 0x00354F6C File Offset: 0x0035316C
		// (set) Token: 0x06016E9E RID: 93854 RVA: 0x00354F74 File Offset: 0x00353174
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTowerBestRecord BestRecord
		{
			get
			{
				return this.bestRecord_;
			}
			set
			{
				this.bestRecord_ = value;
			}
		}

		// Token: 0x17004CDC RID: 19676
		// (get) Token: 0x06016E9F RID: 93855 RVA: 0x00354F7D File Offset: 0x0035317D
		// (set) Token: 0x06016EA0 RID: 93856 RVA: 0x00354F85 File Offset: 0x00353185
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsBestRecordUpdated
		{
			get
			{
				return this.isBestRecordUpdated_;
			}
			set
			{
				this.isBestRecordUpdated_ = value;
			}
		}

		// Token: 0x17004CDD RID: 19677
		// (get) Token: 0x06016EA1 RID: 93857 RVA: 0x00354F8E File Offset: 0x0035318E
		// (set) Token: 0x06016EA2 RID: 93858 RVA: 0x00354F96 File Offset: 0x00353196
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CurrentRankPercent
		{
			get
			{
				return this.currentRankPercent_;
			}
			set
			{
				this.currentRankPercent_ = value;
			}
		}

		// Token: 0x17004CDE RID: 19678
		// (get) Token: 0x06016EA3 RID: 93859 RVA: 0x00354F9F File Offset: 0x0035319F
		// (set) Token: 0x06016EA4 RID: 93860 RVA: 0x00354FA7 File Offset: 0x003531A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int BestRankPercent
		{
			get
			{
				return this.bestRankPercent_;
			}
			set
			{
				this.bestRankPercent_ = value;
			}
		}

		// Token: 0x17004CDF RID: 19679
		// (get) Token: 0x06016EA5 RID: 93861 RVA: 0x00354FB0 File Offset: 0x003531B0
		// (set) Token: 0x06016EA6 RID: 93862 RVA: 0x00354FB8 File Offset: 0x003531B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode RankErrorCode
		{
			get
			{
				return this.rankErrorCode_;
			}
			set
			{
				this.rankErrorCode_ = value;
			}
		}

		// Token: 0x06016EA7 RID: 93863 RVA: 0x00354FC1 File Offset: 0x003531C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleTowerChallengeSettleInfo);
		}

		// Token: 0x06016EA8 RID: 93864 RVA: 0x00354FD0 File Offset: 0x003531D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleTowerChallengeSettleInfo other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.ChallengeId == other.ChallengeId && this.SettleReason == other.SettleReason && object.Equals(this.CurrentRecord, other.CurrentRecord) && object.Equals(this.BestRecord, other.BestRecord) && this.IsBestRecordUpdated == other.IsBestRecordUpdated && this.CurrentRankPercent == other.CurrentRankPercent && this.BestRankPercent == other.BestRankPercent && this.RankErrorCode == other.RankErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06016EA9 RID: 93865 RVA: 0x00355094 File Offset: 0x00353294
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ActivityId != 0)
			{
				num ^= this.ActivityId.GetHashCode();
			}
			if (this.ChallengeId != 0)
			{
				num ^= this.ChallengeId.GetHashCode();
			}
			if (this.SettleReason != RoleTowerSettleReason.None)
			{
				num ^= this.SettleReason.GetHashCode();
			}
			if (this.currentRecord_ != null)
			{
				num ^= this.CurrentRecord.GetHashCode();
			}
			if (this.bestRecord_ != null)
			{
				num ^= this.BestRecord.GetHashCode();
			}
			if (this.IsBestRecordUpdated)
			{
				num ^= this.IsBestRecordUpdated.GetHashCode();
			}
			if (this.CurrentRankPercent != 0)
			{
				num ^= this.CurrentRankPercent.GetHashCode();
			}
			if (this.BestRankPercent != 0)
			{
				num ^= this.BestRankPercent.GetHashCode();
			}
			if (this.RankErrorCode != ErrorCode.Success)
			{
				num ^= this.RankErrorCode.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06016EAA RID: 93866 RVA: 0x003551A2 File Offset: 0x003533A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06016EAB RID: 93867 RVA: 0x003551AF File Offset: 0x003533AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06016EAC RID: 93868 RVA: 0x003551B8 File Offset: 0x003533B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.ActivityId);
			}
			if (this.ChallengeId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.ChallengeId);
			}
			if (this.SettleReason != RoleTowerSettleReason.None)
			{
				output.WriteRawTag(24);
				output.WriteEnum((int)this.SettleReason);
			}
			if (this.currentRecord_ != null)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.CurrentRecord);
			}
			if (this.bestRecord_ != null)
			{
				output.WriteRawTag(42);
				output.WriteMessage(this.BestRecord);
			}
			if (this.IsBestRecordUpdated)
			{
				output.WriteRawTag(48);
				output.WriteBool(this.IsBestRecordUpdated);
			}
			if (this.CurrentRankPercent != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.CurrentRankPercent);
			}
			if (this.BestRankPercent != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.BestRankPercent);
			}
			if (this.RankErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(72);
				output.WriteEnum((int)this.RankErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06016EAD RID: 93869 RVA: 0x003552D4 File Offset: 0x003534D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ActivityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActivityId);
			}
			if (this.ChallengeId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ChallengeId);
			}
			if (this.SettleReason != RoleTowerSettleReason.None)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.SettleReason);
			}
			if (this.currentRecord_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.CurrentRecord);
			}
			if (this.bestRecord_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.BestRecord);
			}
			if (this.IsBestRecordUpdated)
			{
				num += 2;
			}
			if (this.CurrentRankPercent != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CurrentRankPercent);
			}
			if (this.BestRankPercent != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.BestRankPercent);
			}
			if (this.RankErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.RankErrorCode);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06016EAE RID: 93870 RVA: 0x003553C8 File Offset: 0x003535C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoleTowerChallengeSettleInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ActivityId != 0)
			{
				this.ActivityId = other.ActivityId;
			}
			if (other.ChallengeId != 0)
			{
				this.ChallengeId = other.ChallengeId;
			}
			if (other.SettleReason != RoleTowerSettleReason.None)
			{
				this.SettleReason = other.SettleReason;
			}
			if (other.currentRecord_ != null)
			{
				if (this.currentRecord_ == null)
				{
					this.CurrentRecord = new RoleTowerBestRecord();
				}
				this.CurrentRecord.MergeFrom(other.CurrentRecord);
			}
			if (other.bestRecord_ != null)
			{
				if (this.bestRecord_ == null)
				{
					this.BestRecord = new RoleTowerBestRecord();
				}
				this.BestRecord.MergeFrom(other.BestRecord);
			}
			if (other.IsBestRecordUpdated)
			{
				this.IsBestRecordUpdated = other.IsBestRecordUpdated;
			}
			if (other.CurrentRankPercent != 0)
			{
				this.CurrentRankPercent = other.CurrentRankPercent;
			}
			if (other.BestRankPercent != 0)
			{
				this.BestRankPercent = other.BestRankPercent;
			}
			if (other.RankErrorCode != ErrorCode.Success)
			{
				this.RankErrorCode = other.RankErrorCode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06016EAF RID: 93871 RVA: 0x003554D4 File Offset: 0x003536D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06016EB0 RID: 93872 RVA: 0x003554E0 File Offset: 0x003536E0
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
				if (num <= 34U)
				{
					if (num <= 16U)
					{
						if (num == 8U)
						{
							this.ActivityId = input.ReadInt32();
							continue;
						}
						if (num == 16U)
						{
							this.ChallengeId = input.ReadInt32();
							continue;
						}
					}
					else
					{
						if (num == 24U)
						{
							this.SettleReason = (RoleTowerSettleReason)input.ReadEnum();
							continue;
						}
						if (num == 34U)
						{
							if (this.currentRecord_ == null)
							{
								this.CurrentRecord = new RoleTowerBestRecord();
							}
							input.ReadMessage(this.CurrentRecord);
							continue;
						}
					}
				}
				else if (num <= 48U)
				{
					if (num == 42U)
					{
						if (this.bestRecord_ == null)
						{
							this.BestRecord = new RoleTowerBestRecord();
						}
						input.ReadMessage(this.BestRecord);
						continue;
					}
					if (num == 48U)
					{
						this.IsBestRecordUpdated = input.ReadBool();
						continue;
					}
				}
				else
				{
					if (num == 56U)
					{
						this.CurrentRankPercent = input.ReadInt32();
						continue;
					}
					if (num == 64U)
					{
						this.BestRankPercent = input.ReadInt32();
						continue;
					}
					if (num == 72U)
					{
						this.RankErrorCode = (ErrorCode)input.ReadEnum();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400892B RID: 35115
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400892C RID: 35116
		public const int ActivityIdFieldNumber = 1;

		// Token: 0x0400892D RID: 35117
		private int activityId_;

		// Token: 0x0400892E RID: 35118
		public const int ChallengeIdFieldNumber = 2;

		// Token: 0x0400892F RID: 35119
		private int challengeId_;

		// Token: 0x04008930 RID: 35120
		public const int SettleReasonFieldNumber = 3;

		// Token: 0x04008931 RID: 35121
		private RoleTowerSettleReason settleReason_;

		// Token: 0x04008932 RID: 35122
		public const int CurrentRecordFieldNumber = 4;

		// Token: 0x04008933 RID: 35123
		private RoleTowerBestRecord currentRecord_;

		// Token: 0x04008934 RID: 35124
		public const int BestRecordFieldNumber = 5;

		// Token: 0x04008935 RID: 35125
		private RoleTowerBestRecord bestRecord_;

		// Token: 0x04008936 RID: 35126
		public const int IsBestRecordUpdatedFieldNumber = 6;

		// Token: 0x04008937 RID: 35127
		private bool isBestRecordUpdated_;

		// Token: 0x04008938 RID: 35128
		public const int CurrentRankPercentFieldNumber = 7;

		// Token: 0x04008939 RID: 35129
		private int currentRankPercent_;

		// Token: 0x0400893A RID: 35130
		public const int BestRankPercentFieldNumber = 8;

		// Token: 0x0400893B RID: 35131
		private int bestRankPercent_;

		// Token: 0x0400893C RID: 35132
		public const int RankErrorCodeFieldNumber = 9;

		// Token: 0x0400893D RID: 35133
		private ErrorCode rankErrorCode_;
	}
}
