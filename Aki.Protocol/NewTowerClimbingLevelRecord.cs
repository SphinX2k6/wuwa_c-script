using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B30 RID: 2864
	public sealed class NewTowerClimbingLevelRecord : IMessage<NewTowerClimbingLevelRecord>, IMessage, IEquatable<NewTowerClimbingLevelRecord>, IDeepCloneable<NewTowerClimbingLevelRecord>, IBufferMessage
	{
		// Token: 0x0600F897 RID: 63639 RVA: 0x00244114 File Offset: 0x00242314
		[NullableContext(1)]
		public static NewTowerClimbingLevelRecord Create()
		{
			return new NewTowerClimbingLevelRecord();
		}

		// Token: 0x170032A9 RID: 12969
		// (get) Token: 0x0600F898 RID: 63640 RVA: 0x0024411B File Offset: 0x0024231B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<NewTowerClimbingLevelRecord> Parser
		{
			get
			{
				return NewTowerClimbingLevelRecord._parser;
			}
		}

		// Token: 0x170032AA RID: 12970
		// (get) Token: 0x0600F899 RID: 63641 RVA: 0x00244122 File Offset: 0x00242322
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170032AB RID: 12971
		// (get) Token: 0x0600F89A RID: 63642 RVA: 0x00244125 File Offset: 0x00242325
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NewTowerClimbingLevelRecord.Descriptor;
			}
		}

		// Token: 0x0600F89B RID: 63643 RVA: 0x0024412C File Offset: 0x0024232C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewTowerClimbingLevelRecord()
		{
		}

		// Token: 0x0600F89C RID: 63644 RVA: 0x00244158 File Offset: 0x00242358
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewTowerClimbingLevelRecord(NewTowerClimbingLevelRecord other) : this()
		{
			this.levelId_ = other.levelId_;
			this.waveConfigIds_ = other.waveConfigIds_.Clone();
			this.nextMonsterInfoPreview_ = ((other.nextMonsterInfoPreview_ != null) ? other.nextMonsterInfoPreview_.Clone() : null);
			this.teamChallengeInfos_ = other.teamChallengeInfos_.Clone();
			this.score_ = other.score_;
			this.isUnlock_ = other.isUnlock_;
			this.roleEnergyDict_ = other.roleEnergyDict_.Clone();
			this.historyScore_ = other.historyScore_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600F89D RID: 63645 RVA: 0x002441FB File Offset: 0x002423FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewTowerClimbingLevelRecord Clone()
		{
			return new NewTowerClimbingLevelRecord(this);
		}

		// Token: 0x170032AC RID: 12972
		// (get) Token: 0x0600F89E RID: 63646 RVA: 0x00244203 File Offset: 0x00242403
		// (set) Token: 0x0600F89F RID: 63647 RVA: 0x0024420B File Offset: 0x0024240B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int LevelId
		{
			get
			{
				return this.levelId_;
			}
			set
			{
				this.levelId_ = value;
			}
		}

		// Token: 0x170032AD RID: 12973
		// (get) Token: 0x0600F8A0 RID: 63648 RVA: 0x00244214 File Offset: 0x00242414
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> WaveConfigIds
		{
			get
			{
				return this.waveConfigIds_;
			}
		}

		// Token: 0x170032AE RID: 12974
		// (get) Token: 0x0600F8A1 RID: 63649 RVA: 0x0024421C File Offset: 0x0024241C
		// (set) Token: 0x0600F8A2 RID: 63650 RVA: 0x00244224 File Offset: 0x00242424
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonsterInfoPreview NextMonsterInfoPreview
		{
			get
			{
				return this.nextMonsterInfoPreview_;
			}
			set
			{
				this.nextMonsterInfoPreview_ = value;
			}
		}

		// Token: 0x170032AF RID: 12975
		// (get) Token: 0x0600F8A3 RID: 63651 RVA: 0x0024422D File Offset: 0x0024242D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<TeamChallengeInfo> TeamChallengeInfos
		{
			get
			{
				return this.teamChallengeInfos_;
			}
		}

		// Token: 0x170032B0 RID: 12976
		// (get) Token: 0x0600F8A4 RID: 63652 RVA: 0x00244235 File Offset: 0x00242435
		// (set) Token: 0x0600F8A5 RID: 63653 RVA: 0x0024423D File Offset: 0x0024243D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Score
		{
			get
			{
				return this.score_;
			}
			set
			{
				this.score_ = value;
			}
		}

		// Token: 0x170032B1 RID: 12977
		// (get) Token: 0x0600F8A6 RID: 63654 RVA: 0x00244246 File Offset: 0x00242446
		// (set) Token: 0x0600F8A7 RID: 63655 RVA: 0x0024424E File Offset: 0x0024244E
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

		// Token: 0x170032B2 RID: 12978
		// (get) Token: 0x0600F8A8 RID: 63656 RVA: 0x00244257 File Offset: 0x00242457
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, int> RoleEnergyDict
		{
			get
			{
				return this.roleEnergyDict_;
			}
		}

		// Token: 0x170032B3 RID: 12979
		// (get) Token: 0x0600F8A9 RID: 63657 RVA: 0x0024425F File Offset: 0x0024245F
		// (set) Token: 0x0600F8AA RID: 63658 RVA: 0x00244267 File Offset: 0x00242467
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int HistoryScore
		{
			get
			{
				return this.historyScore_;
			}
			set
			{
				this.historyScore_ = value;
			}
		}

		// Token: 0x0600F8AB RID: 63659 RVA: 0x00244270 File Offset: 0x00242470
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NewTowerClimbingLevelRecord);
		}

		// Token: 0x0600F8AC RID: 63660 RVA: 0x00244280 File Offset: 0x00242480
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NewTowerClimbingLevelRecord other)
		{
			return other != null && (other == this || (this.LevelId == other.LevelId && this.waveConfigIds_.Equals(other.waveConfigIds_) && object.Equals(this.NextMonsterInfoPreview, other.NextMonsterInfoPreview) && this.teamChallengeInfos_.Equals(other.teamChallengeInfos_) && this.Score == other.Score && this.IsUnlock == other.IsUnlock && this.RoleEnergyDict.Equals(other.RoleEnergyDict) && this.HistoryScore == other.HistoryScore && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600F8AD RID: 63661 RVA: 0x00244340 File Offset: 0x00242540
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.LevelId != 0)
			{
				num ^= this.LevelId.GetHashCode();
			}
			num ^= this.waveConfigIds_.GetHashCode();
			if (this.nextMonsterInfoPreview_ != null)
			{
				num ^= this.NextMonsterInfoPreview.GetHashCode();
			}
			num ^= this.teamChallengeInfos_.GetHashCode();
			if (this.Score != 0)
			{
				num ^= this.Score.GetHashCode();
			}
			if (this.IsUnlock)
			{
				num ^= this.IsUnlock.GetHashCode();
			}
			num ^= this.RoleEnergyDict.GetHashCode();
			if (this.HistoryScore != 0)
			{
				num ^= this.HistoryScore.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600F8AE RID: 63662 RVA: 0x0024440A File Offset: 0x0024260A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600F8AF RID: 63663 RVA: 0x00244417 File Offset: 0x00242617
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600F8B0 RID: 63664 RVA: 0x00244420 File Offset: 0x00242620
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.LevelId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.LevelId);
			}
			this.waveConfigIds_.WriteTo(ref output, NewTowerClimbingLevelRecord._repeated_waveConfigIds_codec);
			if (this.nextMonsterInfoPreview_ != null)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.NextMonsterInfoPreview);
			}
			this.teamChallengeInfos_.WriteTo(ref output, NewTowerClimbingLevelRecord._repeated_teamChallengeInfos_codec);
			if (this.Score != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.Score);
			}
			if (this.IsUnlock)
			{
				output.WriteRawTag(64);
				output.WriteBool(this.IsUnlock);
			}
			this.roleEnergyDict_.WriteTo(ref output, NewTowerClimbingLevelRecord._map_roleEnergyDict_codec);
			if (this.HistoryScore != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.HistoryScore);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600F8B1 RID: 63665 RVA: 0x00244500 File Offset: 0x00242700
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.LevelId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.LevelId);
			}
			num += this.waveConfigIds_.CalculateSize(NewTowerClimbingLevelRecord._repeated_waveConfigIds_codec);
			if (this.nextMonsterInfoPreview_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.NextMonsterInfoPreview);
			}
			num += this.teamChallengeInfos_.CalculateSize(NewTowerClimbingLevelRecord._repeated_teamChallengeInfos_codec);
			if (this.Score != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Score);
			}
			if (this.IsUnlock)
			{
				num += 2;
			}
			num += this.roleEnergyDict_.CalculateSize(NewTowerClimbingLevelRecord._map_roleEnergyDict_codec);
			if (this.HistoryScore != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.HistoryScore);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600F8B2 RID: 63666 RVA: 0x002445CC File Offset: 0x002427CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(NewTowerClimbingLevelRecord other)
		{
			if (other == null)
			{
				return;
			}
			if (other.LevelId != 0)
			{
				this.LevelId = other.LevelId;
			}
			this.waveConfigIds_.Add(other.waveConfigIds_);
			if (other.nextMonsterInfoPreview_ != null)
			{
				if (this.nextMonsterInfoPreview_ == null)
				{
					this.NextMonsterInfoPreview = new MonsterInfoPreview();
				}
				this.NextMonsterInfoPreview.MergeFrom(other.NextMonsterInfoPreview);
			}
			this.teamChallengeInfos_.Add(other.teamChallengeInfos_);
			if (other.Score != 0)
			{
				this.Score = other.Score;
			}
			if (other.IsUnlock)
			{
				this.IsUnlock = other.IsUnlock;
			}
			this.roleEnergyDict_.MergeFrom(other.roleEnergyDict_);
			if (other.HistoryScore != 0)
			{
				this.HistoryScore = other.HistoryScore;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600F8B3 RID: 63667 RVA: 0x002446A3 File Offset: 0x002428A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600F8B4 RID: 63668 RVA: 0x002446AC File Offset: 0x002428AC
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
						if (num == 8U)
						{
							this.LevelId = input.ReadInt32();
							continue;
						}
						if (num != 16U)
						{
							goto IL_59;
						}
					}
					else if (num != 18U)
					{
						if (num != 26U)
						{
							goto IL_59;
						}
						if (this.nextMonsterInfoPreview_ == null)
						{
							this.NextMonsterInfoPreview = new MonsterInfoPreview();
						}
						input.ReadMessage(this.NextMonsterInfoPreview);
						continue;
					}
					this.waveConfigIds_.AddEntriesFrom(ref input, NewTowerClimbingLevelRecord._repeated_waveConfigIds_codec);
					continue;
				}
				if (num <= 56U)
				{
					if (num == 34U)
					{
						this.teamChallengeInfos_.AddEntriesFrom(ref input, NewTowerClimbingLevelRecord._repeated_teamChallengeInfos_codec);
						continue;
					}
					if (num == 56U)
					{
						this.Score = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 64U)
					{
						this.IsUnlock = input.ReadBool();
						continue;
					}
					if (num == 74U)
					{
						this.roleEnergyDict_.AddEntriesFrom(ref input, NewTowerClimbingLevelRecord._map_roleEnergyDict_codec);
						continue;
					}
					if (num == 80U)
					{
						this.HistoryScore = input.ReadInt32();
						continue;
					}
				}
				IL_59:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040063AA RID: 25514
		private static readonly MessageParser<NewTowerClimbingLevelRecord> _parser = new MessageParser<NewTowerClimbingLevelRecord>(() => new NewTowerClimbingLevelRecord());

		// Token: 0x040063AB RID: 25515
		private UnknownFieldSet _unknownFields;

		// Token: 0x040063AC RID: 25516
		public const int LevelIdFieldNumber = 1;

		// Token: 0x040063AD RID: 25517
		private int levelId_;

		// Token: 0x040063AE RID: 25518
		public const int WaveConfigIdsFieldNumber = 2;

		// Token: 0x040063AF RID: 25519
		private static readonly FieldCodec<int> _repeated_waveConfigIds_codec = FieldCodec.ForInt32(18U);

		// Token: 0x040063B0 RID: 25520
		private readonly RepeatedField<int> waveConfigIds_ = new RepeatedField<int>();

		// Token: 0x040063B1 RID: 25521
		public const int NextMonsterInfoPreviewFieldNumber = 3;

		// Token: 0x040063B2 RID: 25522
		private MonsterInfoPreview nextMonsterInfoPreview_;

		// Token: 0x040063B3 RID: 25523
		public const int TeamChallengeInfosFieldNumber = 4;

		// Token: 0x040063B4 RID: 25524
		private static readonly FieldCodec<TeamChallengeInfo> _repeated_teamChallengeInfos_codec = FieldCodec.ForMessage<TeamChallengeInfo>(34U, TeamChallengeInfo.Parser);

		// Token: 0x040063B5 RID: 25525
		private readonly RepeatedField<TeamChallengeInfo> teamChallengeInfos_ = new RepeatedField<TeamChallengeInfo>();

		// Token: 0x040063B6 RID: 25526
		public const int ScoreFieldNumber = 7;

		// Token: 0x040063B7 RID: 25527
		private int score_;

		// Token: 0x040063B8 RID: 25528
		public const int IsUnlockFieldNumber = 8;

		// Token: 0x040063B9 RID: 25529
		private bool isUnlock_;

		// Token: 0x040063BA RID: 25530
		public const int RoleEnergyDictFieldNumber = 9;

		// Token: 0x040063BB RID: 25531
		private static readonly MapField<int, int>.Codec _map_roleEnergyDict_codec = new MapField<int, int>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForInt32(16U, 0), 74U);

		// Token: 0x040063BC RID: 25532
		private readonly MapField<int, int> roleEnergyDict_ = new MapField<int, int>();

		// Token: 0x040063BD RID: 25533
		public const int HistoryScoreFieldNumber = 10;

		// Token: 0x040063BE RID: 25534
		private int historyScore_;
	}
}
