using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020010D8 RID: 4312
	public sealed class RoleTowerRankInfo : IMessage<RoleTowerRankInfo>, IMessage, IEquatable<RoleTowerRankInfo>, IDeepCloneable<RoleTowerRankInfo>, IBufferMessage
	{
		// Token: 0x060170D8 RID: 94424 RVA: 0x0035AACF File Offset: 0x00358CCF
		[NullableContext(1)]
		public static RoleTowerRankInfo Create()
		{
			return new RoleTowerRankInfo();
		}

		// Token: 0x17004D62 RID: 19810
		// (get) Token: 0x060170D9 RID: 94425 RVA: 0x0035AAD6 File Offset: 0x00358CD6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RoleTowerRankInfo> Parser
		{
			get
			{
				return RoleTowerRankInfo._parser;
			}
		}

		// Token: 0x17004D63 RID: 19811
		// (get) Token: 0x060170DA RID: 94426 RVA: 0x0035AADD File Offset: 0x00358CDD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004D64 RID: 19812
		// (get) Token: 0x060170DB RID: 94427 RVA: 0x0035AAE0 File Offset: 0x00358CE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleTowerRankInfo.Descriptor;
			}
		}

		// Token: 0x060170DC RID: 94428 RVA: 0x0035AAE7 File Offset: 0x00358CE7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTowerRankInfo()
		{
		}

		// Token: 0x060170DD RID: 94429 RVA: 0x0035AB08 File Offset: 0x00358D08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTowerRankInfo(RoleTowerRankInfo other) : this()
		{
			this.challengeId_ = other.challengeId_;
			this.rankType_ = other.rankType_;
			this.rewardSettleTime_ = other.rewardSettleTime_;
			this.friendEntries_ = other.friendEntries_.Clone();
			this.selfServerEntry_ = ((other.selfServerEntry_ != null) ? other.selfServerEntry_.Clone() : null);
			this.canGetServerRankReward_ = other.canGetServerRankReward_;
			this.state_ = other.state_;
			this.rewardPreview_ = other.rewardPreview_.Clone();
			this.nextRefreshTime_ = other.nextRefreshTime_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060170DE RID: 94430 RVA: 0x0035ABB2 File Offset: 0x00358DB2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTowerRankInfo Clone()
		{
			return new RoleTowerRankInfo(this);
		}

		// Token: 0x17004D65 RID: 19813
		// (get) Token: 0x060170DF RID: 94431 RVA: 0x0035ABBA File Offset: 0x00358DBA
		// (set) Token: 0x060170E0 RID: 94432 RVA: 0x0035ABC2 File Offset: 0x00358DC2
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

		// Token: 0x17004D66 RID: 19814
		// (get) Token: 0x060170E1 RID: 94433 RVA: 0x0035ABCB File Offset: 0x00358DCB
		// (set) Token: 0x060170E2 RID: 94434 RVA: 0x0035ABD3 File Offset: 0x00358DD3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTowerRankType RankType
		{
			get
			{
				return this.rankType_;
			}
			set
			{
				this.rankType_ = value;
			}
		}

		// Token: 0x17004D67 RID: 19815
		// (get) Token: 0x060170E3 RID: 94435 RVA: 0x0035ABDC File Offset: 0x00358DDC
		// (set) Token: 0x060170E4 RID: 94436 RVA: 0x0035ABE4 File Offset: 0x00358DE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long RewardSettleTime
		{
			get
			{
				return this.rewardSettleTime_;
			}
			set
			{
				this.rewardSettleTime_ = value;
			}
		}

		// Token: 0x17004D68 RID: 19816
		// (get) Token: 0x060170E5 RID: 94437 RVA: 0x0035ABED File Offset: 0x00358DED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RoleTowerRankEntry> FriendEntries
		{
			get
			{
				return this.friendEntries_;
			}
		}

		// Token: 0x17004D69 RID: 19817
		// (get) Token: 0x060170E6 RID: 94438 RVA: 0x0035ABF5 File Offset: 0x00358DF5
		// (set) Token: 0x060170E7 RID: 94439 RVA: 0x0035ABFD File Offset: 0x00358DFD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTowerRankEntry SelfServerEntry
		{
			get
			{
				return this.selfServerEntry_;
			}
			set
			{
				this.selfServerEntry_ = value;
			}
		}

		// Token: 0x17004D6A RID: 19818
		// (get) Token: 0x060170E8 RID: 94440 RVA: 0x0035AC06 File Offset: 0x00358E06
		// (set) Token: 0x060170E9 RID: 94441 RVA: 0x0035AC0E File Offset: 0x00358E0E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool CanGetServerRankReward
		{
			get
			{
				return this.canGetServerRankReward_;
			}
			set
			{
				this.canGetServerRankReward_ = value;
			}
		}

		// Token: 0x17004D6B RID: 19819
		// (get) Token: 0x060170EA RID: 94442 RVA: 0x0035AC17 File Offset: 0x00358E17
		// (set) Token: 0x060170EB RID: 94443 RVA: 0x0035AC1F File Offset: 0x00358E1F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ConditionTaskState State
		{
			get
			{
				return this.state_;
			}
			set
			{
				this.state_ = value;
			}
		}

		// Token: 0x17004D6C RID: 19820
		// (get) Token: 0x060170EC RID: 94444 RVA: 0x0035AC28 File Offset: 0x00358E28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RewardItem> RewardPreview
		{
			get
			{
				return this.rewardPreview_;
			}
		}

		// Token: 0x17004D6D RID: 19821
		// (get) Token: 0x060170ED RID: 94445 RVA: 0x0035AC30 File Offset: 0x00358E30
		// (set) Token: 0x060170EE RID: 94446 RVA: 0x0035AC38 File Offset: 0x00358E38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long NextRefreshTime
		{
			get
			{
				return this.nextRefreshTime_;
			}
			set
			{
				this.nextRefreshTime_ = value;
			}
		}

		// Token: 0x060170EF RID: 94447 RVA: 0x0035AC41 File Offset: 0x00358E41
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleTowerRankInfo);
		}

		// Token: 0x060170F0 RID: 94448 RVA: 0x0035AC50 File Offset: 0x00358E50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleTowerRankInfo other)
		{
			return other != null && (other == this || (this.ChallengeId == other.ChallengeId && this.RankType == other.RankType && this.RewardSettleTime == other.RewardSettleTime && this.friendEntries_.Equals(other.friendEntries_) && object.Equals(this.SelfServerEntry, other.SelfServerEntry) && this.CanGetServerRankReward == other.CanGetServerRankReward && this.State == other.State && this.rewardPreview_.Equals(other.rewardPreview_) && this.NextRefreshTime == other.NextRefreshTime && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060170F1 RID: 94449 RVA: 0x0035AD18 File Offset: 0x00358F18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ChallengeId != 0)
			{
				num ^= this.ChallengeId.GetHashCode();
			}
			if (this.RankType != RoleTowerRankType.Friend)
			{
				num ^= this.RankType.GetHashCode();
			}
			if (this.RewardSettleTime != 0L)
			{
				num ^= this.RewardSettleTime.GetHashCode();
			}
			num ^= this.friendEntries_.GetHashCode();
			if (this.selfServerEntry_ != null)
			{
				num ^= this.SelfServerEntry.GetHashCode();
			}
			if (this.CanGetServerRankReward)
			{
				num ^= this.CanGetServerRankReward.GetHashCode();
			}
			if (this.State != ConditionTaskState.ConditionTaskRunning)
			{
				num ^= this.State.GetHashCode();
			}
			num ^= this.rewardPreview_.GetHashCode();
			if (this.NextRefreshTime != 0L)
			{
				num ^= this.NextRefreshTime.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060170F2 RID: 94450 RVA: 0x0035AE14 File Offset: 0x00359014
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060170F3 RID: 94451 RVA: 0x0035AE21 File Offset: 0x00359021
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060170F4 RID: 94452 RVA: 0x0035AE2C File Offset: 0x0035902C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ChallengeId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.ChallengeId);
			}
			if (this.RankType != RoleTowerRankType.Friend)
			{
				output.WriteRawTag(24);
				output.WriteEnum((int)this.RankType);
			}
			if (this.RewardSettleTime != 0L)
			{
				output.WriteRawTag(40);
				output.WriteInt64(this.RewardSettleTime);
			}
			this.friendEntries_.WriteTo(ref output, RoleTowerRankInfo._repeated_friendEntries_codec);
			if (this.selfServerEntry_ != null)
			{
				output.WriteRawTag(58);
				output.WriteMessage(this.SelfServerEntry);
			}
			if (this.CanGetServerRankReward)
			{
				output.WriteRawTag(64);
				output.WriteBool(this.CanGetServerRankReward);
			}
			if (this.State != ConditionTaskState.ConditionTaskRunning)
			{
				output.WriteRawTag(72);
				output.WriteEnum((int)this.State);
			}
			this.rewardPreview_.WriteTo(ref output, RoleTowerRankInfo._repeated_rewardPreview_codec);
			if (this.NextRefreshTime != 0L)
			{
				output.WriteRawTag(88);
				output.WriteInt64(this.NextRefreshTime);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060170F5 RID: 94453 RVA: 0x0035AF34 File Offset: 0x00359134
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ChallengeId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ChallengeId);
			}
			if (this.RankType != RoleTowerRankType.Friend)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.RankType);
			}
			if (this.RewardSettleTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.RewardSettleTime);
			}
			num += this.friendEntries_.CalculateSize(RoleTowerRankInfo._repeated_friendEntries_codec);
			if (this.selfServerEntry_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.SelfServerEntry);
			}
			if (this.CanGetServerRankReward)
			{
				num += 2;
			}
			if (this.State != ConditionTaskState.ConditionTaskRunning)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.State);
			}
			num += this.rewardPreview_.CalculateSize(RoleTowerRankInfo._repeated_rewardPreview_codec);
			if (this.NextRefreshTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.NextRefreshTime);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060170F6 RID: 94454 RVA: 0x0035B01C File Offset: 0x0035921C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoleTowerRankInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ChallengeId != 0)
			{
				this.ChallengeId = other.ChallengeId;
			}
			if (other.RankType != RoleTowerRankType.Friend)
			{
				this.RankType = other.RankType;
			}
			if (other.RewardSettleTime != 0L)
			{
				this.RewardSettleTime = other.RewardSettleTime;
			}
			this.friendEntries_.Add(other.friendEntries_);
			if (other.selfServerEntry_ != null)
			{
				if (this.selfServerEntry_ == null)
				{
					this.SelfServerEntry = new RoleTowerRankEntry();
				}
				this.SelfServerEntry.MergeFrom(other.SelfServerEntry);
			}
			if (other.CanGetServerRankReward)
			{
				this.CanGetServerRankReward = other.CanGetServerRankReward;
			}
			if (other.State != ConditionTaskState.ConditionTaskRunning)
			{
				this.State = other.State;
			}
			this.rewardPreview_.Add(other.rewardPreview_);
			if (other.NextRefreshTime != 0L)
			{
				this.NextRefreshTime = other.NextRefreshTime;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060170F7 RID: 94455 RVA: 0x0035B10A File Offset: 0x0035930A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060170F8 RID: 94456 RVA: 0x0035B114 File Offset: 0x00359314
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
				if (num <= 50U)
				{
					if (num <= 24U)
					{
						if (num == 16U)
						{
							this.ChallengeId = input.ReadInt32();
							continue;
						}
						if (num == 24U)
						{
							this.RankType = (RoleTowerRankType)input.ReadEnum();
							continue;
						}
					}
					else
					{
						if (num == 40U)
						{
							this.RewardSettleTime = input.ReadInt64();
							continue;
						}
						if (num == 50U)
						{
							this.friendEntries_.AddEntriesFrom(ref input, RoleTowerRankInfo._repeated_friendEntries_codec);
							continue;
						}
					}
				}
				else if (num <= 64U)
				{
					if (num == 58U)
					{
						if (this.selfServerEntry_ == null)
						{
							this.SelfServerEntry = new RoleTowerRankEntry();
						}
						input.ReadMessage(this.SelfServerEntry);
						continue;
					}
					if (num == 64U)
					{
						this.CanGetServerRankReward = input.ReadBool();
						continue;
					}
				}
				else
				{
					if (num == 72U)
					{
						this.State = (ConditionTaskState)input.ReadEnum();
						continue;
					}
					if (num == 82U)
					{
						this.rewardPreview_.AddEntriesFrom(ref input, RoleTowerRankInfo._repeated_rewardPreview_codec);
						continue;
					}
					if (num == 88U)
					{
						this.NextRefreshTime = input.ReadInt64();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04008A03 RID: 35331
		private static readonly MessageParser<RoleTowerRankInfo> _parser = new MessageParser<RoleTowerRankInfo>(() => new RoleTowerRankInfo());

		// Token: 0x04008A04 RID: 35332
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008A05 RID: 35333
		public const int ChallengeIdFieldNumber = 2;

		// Token: 0x04008A06 RID: 35334
		private int challengeId_;

		// Token: 0x04008A07 RID: 35335
		public const int RankTypeFieldNumber = 3;

		// Token: 0x04008A08 RID: 35336
		private RoleTowerRankType rankType_;

		// Token: 0x04008A09 RID: 35337
		public const int RewardSettleTimeFieldNumber = 5;

		// Token: 0x04008A0A RID: 35338
		private long rewardSettleTime_;

		// Token: 0x04008A0B RID: 35339
		public const int FriendEntriesFieldNumber = 6;

		// Token: 0x04008A0C RID: 35340
		private static readonly FieldCodec<RoleTowerRankEntry> _repeated_friendEntries_codec = FieldCodec.ForMessage<RoleTowerRankEntry>(50U, RoleTowerRankEntry.Parser);

		// Token: 0x04008A0D RID: 35341
		private readonly RepeatedField<RoleTowerRankEntry> friendEntries_ = new RepeatedField<RoleTowerRankEntry>();

		// Token: 0x04008A0E RID: 35342
		public const int SelfServerEntryFieldNumber = 7;

		// Token: 0x04008A0F RID: 35343
		private RoleTowerRankEntry selfServerEntry_;

		// Token: 0x04008A10 RID: 35344
		public const int CanGetServerRankRewardFieldNumber = 8;

		// Token: 0x04008A11 RID: 35345
		private bool canGetServerRankReward_;

		// Token: 0x04008A12 RID: 35346
		public const int StateFieldNumber = 9;

		// Token: 0x04008A13 RID: 35347
		private ConditionTaskState state_;

		// Token: 0x04008A14 RID: 35348
		public const int RewardPreviewFieldNumber = 10;

		// Token: 0x04008A15 RID: 35349
		private static readonly FieldCodec<RewardItem> _repeated_rewardPreview_codec = FieldCodec.ForMessage<RewardItem>(82U, RewardItem.Parser);

		// Token: 0x04008A16 RID: 35350
		private readonly RepeatedField<RewardItem> rewardPreview_ = new RepeatedField<RewardItem>();

		// Token: 0x04008A17 RID: 35351
		public const int NextRefreshTimeFieldNumber = 11;

		// Token: 0x04008A18 RID: 35352
		private long nextRefreshTime_;
	}
}
