using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020010BC RID: 4284
	public sealed class RoleTowerChallengeInfo : IMessage<RoleTowerChallengeInfo>, IMessage, IEquatable<RoleTowerChallengeInfo>, IDeepCloneable<RoleTowerChallengeInfo>, IBufferMessage
	{
		// Token: 0x06016E49 RID: 93769 RVA: 0x00353BA8 File Offset: 0x00351DA8
		[NullableContext(1)]
		public static RoleTowerChallengeInfo Create()
		{
			return new RoleTowerChallengeInfo();
		}

		// Token: 0x17004CBA RID: 19642
		// (get) Token: 0x06016E4A RID: 93770 RVA: 0x00353BAF File Offset: 0x00351DAF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RoleTowerChallengeInfo> Parser
		{
			get
			{
				return RoleTowerChallengeInfo._parser;
			}
		}

		// Token: 0x17004CBB RID: 19643
		// (get) Token: 0x06016E4B RID: 93771 RVA: 0x00353BB6 File Offset: 0x00351DB6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004CBC RID: 19644
		// (get) Token: 0x06016E4C RID: 93772 RVA: 0x00353BB9 File Offset: 0x00351DB9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleTowerChallengeInfo.Descriptor;
			}
		}

		// Token: 0x06016E4D RID: 93773 RVA: 0x00353BC0 File Offset: 0x00351DC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTowerChallengeInfo()
		{
		}

		// Token: 0x06016E4E RID: 93774 RVA: 0x00353BEC File Offset: 0x00351DEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTowerChallengeInfo(RoleTowerChallengeInfo other) : this()
		{
			this.challengeId_ = other.challengeId_;
			this.isUnlock_ = other.isUnlock_;
			this.unlockTime_ = other.unlockTime_;
			this.isAllPassed_ = other.isAllPassed_;
			this.hasSave_ = other.hasSave_;
			this.saveBrief_ = ((other.saveBrief_ != null) ? other.saveBrief_.Clone() : null);
			this.bestRecord_ = ((other.bestRecord_ != null) ? other.bestRecord_.Clone() : null);
			this.stageInfos_ = other.stageInfos_.Clone();
			this.roleEnergyInfos_ = other.roleEnergyInfos_.Clone();
			this.initialTokens_ = other.initialTokens_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06016E4F RID: 93775 RVA: 0x00353CB7 File Offset: 0x00351EB7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTowerChallengeInfo Clone()
		{
			return new RoleTowerChallengeInfo(this);
		}

		// Token: 0x17004CBD RID: 19645
		// (get) Token: 0x06016E50 RID: 93776 RVA: 0x00353CBF File Offset: 0x00351EBF
		// (set) Token: 0x06016E51 RID: 93777 RVA: 0x00353CC7 File Offset: 0x00351EC7
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

		// Token: 0x17004CBE RID: 19646
		// (get) Token: 0x06016E52 RID: 93778 RVA: 0x00353CD0 File Offset: 0x00351ED0
		// (set) Token: 0x06016E53 RID: 93779 RVA: 0x00353CD8 File Offset: 0x00351ED8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsUnlock
		{
			get
			{
				return this.isUnlock_;
			}
			set
			{
				this.isUnlock_ = value;
			}
		}

		// Token: 0x17004CBF RID: 19647
		// (get) Token: 0x06016E54 RID: 93780 RVA: 0x00353CE1 File Offset: 0x00351EE1
		// (set) Token: 0x06016E55 RID: 93781 RVA: 0x00353CE9 File Offset: 0x00351EE9
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

		// Token: 0x17004CC0 RID: 19648
		// (get) Token: 0x06016E56 RID: 93782 RVA: 0x00353CF2 File Offset: 0x00351EF2
		// (set) Token: 0x06016E57 RID: 93783 RVA: 0x00353CFA File Offset: 0x00351EFA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsAllPassed
		{
			get
			{
				return this.isAllPassed_;
			}
			set
			{
				this.isAllPassed_ = value;
			}
		}

		// Token: 0x17004CC1 RID: 19649
		// (get) Token: 0x06016E58 RID: 93784 RVA: 0x00353D03 File Offset: 0x00351F03
		// (set) Token: 0x06016E59 RID: 93785 RVA: 0x00353D0B File Offset: 0x00351F0B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasSave
		{
			get
			{
				return this.hasSave_;
			}
			set
			{
				this.hasSave_ = value;
			}
		}

		// Token: 0x17004CC2 RID: 19650
		// (get) Token: 0x06016E5A RID: 93786 RVA: 0x00353D14 File Offset: 0x00351F14
		// (set) Token: 0x06016E5B RID: 93787 RVA: 0x00353D1C File Offset: 0x00351F1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTowerChallengeSaveBrief SaveBrief
		{
			get
			{
				return this.saveBrief_;
			}
			set
			{
				this.saveBrief_ = value;
			}
		}

		// Token: 0x17004CC3 RID: 19651
		// (get) Token: 0x06016E5C RID: 93788 RVA: 0x00353D25 File Offset: 0x00351F25
		// (set) Token: 0x06016E5D RID: 93789 RVA: 0x00353D2D File Offset: 0x00351F2D
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

		// Token: 0x17004CC4 RID: 19652
		// (get) Token: 0x06016E5E RID: 93790 RVA: 0x00353D36 File Offset: 0x00351F36
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RoleTowerStageInfo> StageInfos
		{
			get
			{
				return this.stageInfos_;
			}
		}

		// Token: 0x17004CC5 RID: 19653
		// (get) Token: 0x06016E5F RID: 93791 RVA: 0x00353D3E File Offset: 0x00351F3E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RoleTowerRoleEnergyInfo> RoleEnergyInfos
		{
			get
			{
				return this.roleEnergyInfos_;
			}
		}

		// Token: 0x17004CC6 RID: 19654
		// (get) Token: 0x06016E60 RID: 93792 RVA: 0x00353D46 File Offset: 0x00351F46
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, int> InitialTokens
		{
			get
			{
				return this.initialTokens_;
			}
		}

		// Token: 0x06016E61 RID: 93793 RVA: 0x00353D4E File Offset: 0x00351F4E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleTowerChallengeInfo);
		}

		// Token: 0x06016E62 RID: 93794 RVA: 0x00353D5C File Offset: 0x00351F5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleTowerChallengeInfo other)
		{
			return other != null && (other == this || (this.ChallengeId == other.ChallengeId && this.IsUnlock == other.IsUnlock && this.UnlockTime == other.UnlockTime && this.IsAllPassed == other.IsAllPassed && this.HasSave == other.HasSave && object.Equals(this.SaveBrief, other.SaveBrief) && object.Equals(this.BestRecord, other.BestRecord) && this.stageInfos_.Equals(other.stageInfos_) && this.roleEnergyInfos_.Equals(other.roleEnergyInfos_) && this.InitialTokens.Equals(other.InitialTokens) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06016E63 RID: 93795 RVA: 0x00353E40 File Offset: 0x00352040
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ChallengeId != 0)
			{
				num ^= this.ChallengeId.GetHashCode();
			}
			if (this.IsUnlock)
			{
				num ^= this.IsUnlock.GetHashCode();
			}
			if (this.UnlockTime != 0L)
			{
				num ^= this.UnlockTime.GetHashCode();
			}
			if (this.IsAllPassed)
			{
				num ^= this.IsAllPassed.GetHashCode();
			}
			if (this.HasSave)
			{
				num ^= this.HasSave.GetHashCode();
			}
			if (this.saveBrief_ != null)
			{
				num ^= this.SaveBrief.GetHashCode();
			}
			if (this.bestRecord_ != null)
			{
				num ^= this.BestRecord.GetHashCode();
			}
			num ^= this.stageInfos_.GetHashCode();
			num ^= this.roleEnergyInfos_.GetHashCode();
			num ^= this.InitialTokens.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06016E64 RID: 93796 RVA: 0x00353F39 File Offset: 0x00352139
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06016E65 RID: 93797 RVA: 0x00353F46 File Offset: 0x00352146
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06016E66 RID: 93798 RVA: 0x00353F50 File Offset: 0x00352150
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ChallengeId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.ChallengeId);
			}
			if (this.IsUnlock)
			{
				output.WriteRawTag(16);
				output.WriteBool(this.IsUnlock);
			}
			if (this.UnlockTime != 0L)
			{
				output.WriteRawTag(24);
				output.WriteInt64(this.UnlockTime);
			}
			if (this.IsAllPassed)
			{
				output.WriteRawTag(32);
				output.WriteBool(this.IsAllPassed);
			}
			if (this.HasSave)
			{
				output.WriteRawTag(40);
				output.WriteBool(this.HasSave);
			}
			if (this.saveBrief_ != null)
			{
				output.WriteRawTag(50);
				output.WriteMessage(this.SaveBrief);
			}
			if (this.bestRecord_ != null)
			{
				output.WriteRawTag(58);
				output.WriteMessage(this.BestRecord);
			}
			this.stageInfos_.WriteTo(ref output, RoleTowerChallengeInfo._repeated_stageInfos_codec);
			this.roleEnergyInfos_.WriteTo(ref output, RoleTowerChallengeInfo._repeated_roleEnergyInfos_codec);
			this.initialTokens_.WriteTo(ref output, RoleTowerChallengeInfo._map_initialTokens_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06016E67 RID: 93799 RVA: 0x00354068 File Offset: 0x00352268
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ChallengeId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ChallengeId);
			}
			if (this.IsUnlock)
			{
				num += 2;
			}
			if (this.UnlockTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.UnlockTime);
			}
			if (this.IsAllPassed)
			{
				num += 2;
			}
			if (this.HasSave)
			{
				num += 2;
			}
			if (this.saveBrief_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.SaveBrief);
			}
			if (this.bestRecord_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.BestRecord);
			}
			num += this.stageInfos_.CalculateSize(RoleTowerChallengeInfo._repeated_stageInfos_codec);
			num += this.roleEnergyInfos_.CalculateSize(RoleTowerChallengeInfo._repeated_roleEnergyInfos_codec);
			num += this.initialTokens_.CalculateSize(RoleTowerChallengeInfo._map_initialTokens_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06016E68 RID: 93800 RVA: 0x0035414C File Offset: 0x0035234C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoleTowerChallengeInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ChallengeId != 0)
			{
				this.ChallengeId = other.ChallengeId;
			}
			if (other.IsUnlock)
			{
				this.IsUnlock = other.IsUnlock;
			}
			if (other.UnlockTime != 0L)
			{
				this.UnlockTime = other.UnlockTime;
			}
			if (other.IsAllPassed)
			{
				this.IsAllPassed = other.IsAllPassed;
			}
			if (other.HasSave)
			{
				this.HasSave = other.HasSave;
			}
			if (other.saveBrief_ != null)
			{
				if (this.saveBrief_ == null)
				{
					this.SaveBrief = new RoleTowerChallengeSaveBrief();
				}
				this.SaveBrief.MergeFrom(other.SaveBrief);
			}
			if (other.bestRecord_ != null)
			{
				if (this.bestRecord_ == null)
				{
					this.BestRecord = new RoleTowerBestRecord();
				}
				this.BestRecord.MergeFrom(other.BestRecord);
			}
			this.stageInfos_.Add(other.stageInfos_);
			this.roleEnergyInfos_.Add(other.roleEnergyInfos_);
			this.initialTokens_.MergeFrom(other.initialTokens_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06016E69 RID: 93801 RVA: 0x00354263 File Offset: 0x00352463
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06016E6A RID: 93802 RVA: 0x0035426C File Offset: 0x0035246C
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
				if (num <= 40U)
				{
					if (num <= 16U)
					{
						if (num == 8U)
						{
							this.ChallengeId = input.ReadInt32();
							continue;
						}
						if (num == 16U)
						{
							this.IsUnlock = input.ReadBool();
							continue;
						}
					}
					else
					{
						if (num == 24U)
						{
							this.UnlockTime = input.ReadInt64();
							continue;
						}
						if (num == 32U)
						{
							this.IsAllPassed = input.ReadBool();
							continue;
						}
						if (num == 40U)
						{
							this.HasSave = input.ReadBool();
							continue;
						}
					}
				}
				else if (num <= 58U)
				{
					if (num == 50U)
					{
						if (this.saveBrief_ == null)
						{
							this.SaveBrief = new RoleTowerChallengeSaveBrief();
						}
						input.ReadMessage(this.SaveBrief);
						continue;
					}
					if (num == 58U)
					{
						if (this.bestRecord_ == null)
						{
							this.BestRecord = new RoleTowerBestRecord();
						}
						input.ReadMessage(this.BestRecord);
						continue;
					}
				}
				else
				{
					if (num == 66U)
					{
						this.stageInfos_.AddEntriesFrom(ref input, RoleTowerChallengeInfo._repeated_stageInfos_codec);
						continue;
					}
					if (num == 74U)
					{
						this.roleEnergyInfos_.AddEntriesFrom(ref input, RoleTowerChallengeInfo._repeated_roleEnergyInfos_codec);
						continue;
					}
					if (num == 82U)
					{
						this.initialTokens_.AddEntriesFrom(ref input, RoleTowerChallengeInfo._map_initialTokens_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040088F3 RID: 35059
		private static readonly MessageParser<RoleTowerChallengeInfo> _parser = new MessageParser<RoleTowerChallengeInfo>(() => new RoleTowerChallengeInfo());

		// Token: 0x040088F4 RID: 35060
		private UnknownFieldSet _unknownFields;

		// Token: 0x040088F5 RID: 35061
		public const int ChallengeIdFieldNumber = 1;

		// Token: 0x040088F6 RID: 35062
		private int challengeId_;

		// Token: 0x040088F7 RID: 35063
		public const int IsUnlockFieldNumber = 2;

		// Token: 0x040088F8 RID: 35064
		private bool isUnlock_;

		// Token: 0x040088F9 RID: 35065
		public const int UnlockTimeFieldNumber = 3;

		// Token: 0x040088FA RID: 35066
		private long unlockTime_;

		// Token: 0x040088FB RID: 35067
		public const int IsAllPassedFieldNumber = 4;

		// Token: 0x040088FC RID: 35068
		private bool isAllPassed_;

		// Token: 0x040088FD RID: 35069
		public const int HasSaveFieldNumber = 5;

		// Token: 0x040088FE RID: 35070
		private bool hasSave_;

		// Token: 0x040088FF RID: 35071
		public const int SaveBriefFieldNumber = 6;

		// Token: 0x04008900 RID: 35072
		private RoleTowerChallengeSaveBrief saveBrief_;

		// Token: 0x04008901 RID: 35073
		public const int BestRecordFieldNumber = 7;

		// Token: 0x04008902 RID: 35074
		private RoleTowerBestRecord bestRecord_;

		// Token: 0x04008903 RID: 35075
		public const int StageInfosFieldNumber = 8;

		// Token: 0x04008904 RID: 35076
		private static readonly FieldCodec<RoleTowerStageInfo> _repeated_stageInfos_codec = FieldCodec.ForMessage<RoleTowerStageInfo>(66U, RoleTowerStageInfo.Parser);

		// Token: 0x04008905 RID: 35077
		private readonly RepeatedField<RoleTowerStageInfo> stageInfos_ = new RepeatedField<RoleTowerStageInfo>();

		// Token: 0x04008906 RID: 35078
		public const int RoleEnergyInfosFieldNumber = 9;

		// Token: 0x04008907 RID: 35079
		private static readonly FieldCodec<RoleTowerRoleEnergyInfo> _repeated_roleEnergyInfos_codec = FieldCodec.ForMessage<RoleTowerRoleEnergyInfo>(74U, RoleTowerRoleEnergyInfo.Parser);

		// Token: 0x04008908 RID: 35080
		private readonly RepeatedField<RoleTowerRoleEnergyInfo> roleEnergyInfos_ = new RepeatedField<RoleTowerRoleEnergyInfo>();

		// Token: 0x04008909 RID: 35081
		public const int InitialTokensFieldNumber = 10;

		// Token: 0x0400890A RID: 35082
		private static readonly MapField<int, int>.Codec _map_initialTokens_codec = new MapField<int, int>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForInt32(16U, 0), 82U);

		// Token: 0x0400890B RID: 35083
		private readonly MapField<int, int> initialTokens_ = new MapField<int, int>();
	}
}
