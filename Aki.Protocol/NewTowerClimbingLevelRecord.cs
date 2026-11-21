using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B1F RID: 2847
	public sealed class NewTowerClimbingLevelRecord : IMessage<NewTowerClimbingLevelRecord>, IMessage, IEquatable<NewTowerClimbingLevelRecord>, IDeepCloneable<NewTowerClimbingLevelRecord>, IBufferMessage
	{
		// Token: 0x0600F77D RID: 63357 RVA: 0x00241EF8 File Offset: 0x002400F8
		[NullableContext(1)]
		public static NewTowerClimbingLevelRecord Create()
		{
			return new NewTowerClimbingLevelRecord();
		}

		// Token: 0x1700326B RID: 12907
		// (get) Token: 0x0600F77E RID: 63358 RVA: 0x00241EFF File Offset: 0x002400FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<NewTowerClimbingLevelRecord> Parser
		{
			get
			{
				return NewTowerClimbingLevelRecord._parser;
			}
		}

		// Token: 0x1700326C RID: 12908
		// (get) Token: 0x0600F77F RID: 63359 RVA: 0x00241F06 File Offset: 0x00240106
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700326D RID: 12909
		// (get) Token: 0x0600F780 RID: 63360 RVA: 0x00241F09 File Offset: 0x00240109
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NewTowerClimbingLevelRecord.Descriptor;
			}
		}

		// Token: 0x0600F781 RID: 63361 RVA: 0x00241F10 File Offset: 0x00240110
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewTowerClimbingLevelRecord()
		{
		}

		// Token: 0x0600F782 RID: 63362 RVA: 0x00241F3C File Offset: 0x0024013C
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

		// Token: 0x0600F783 RID: 63363 RVA: 0x00241FDF File Offset: 0x002401DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewTowerClimbingLevelRecord Clone()
		{
			return new NewTowerClimbingLevelRecord(this);
		}

		// Token: 0x1700326E RID: 12910
		// (get) Token: 0x0600F784 RID: 63364 RVA: 0x00241FE7 File Offset: 0x002401E7
		// (set) Token: 0x0600F785 RID: 63365 RVA: 0x00241FEF File Offset: 0x002401EF
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

		// Token: 0x1700326F RID: 12911
		// (get) Token: 0x0600F786 RID: 63366 RVA: 0x00241FF8 File Offset: 0x002401F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> WaveConfigIds
		{
			get
			{
				return this.waveConfigIds_;
			}
		}

		// Token: 0x17003270 RID: 12912
		// (get) Token: 0x0600F787 RID: 63367 RVA: 0x00242000 File Offset: 0x00240200
		// (set) Token: 0x0600F788 RID: 63368 RVA: 0x00242008 File Offset: 0x00240208
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

		// Token: 0x17003271 RID: 12913
		// (get) Token: 0x0600F789 RID: 63369 RVA: 0x00242011 File Offset: 0x00240211
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<TeamChallengeInfo> TeamChallengeInfos
		{
			get
			{
				return this.teamChallengeInfos_;
			}
		}

		// Token: 0x17003272 RID: 12914
		// (get) Token: 0x0600F78A RID: 63370 RVA: 0x00242019 File Offset: 0x00240219
		// (set) Token: 0x0600F78B RID: 63371 RVA: 0x00242021 File Offset: 0x00240221
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

		// Token: 0x17003273 RID: 12915
		// (get) Token: 0x0600F78C RID: 63372 RVA: 0x0024202A File Offset: 0x0024022A
		// (set) Token: 0x0600F78D RID: 63373 RVA: 0x00242032 File Offset: 0x00240232
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

		// Token: 0x17003274 RID: 12916
		// (get) Token: 0x0600F78E RID: 63374 RVA: 0x0024203B File Offset: 0x0024023B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, int> RoleEnergyDict
		{
			get
			{
				return this.roleEnergyDict_;
			}
		}

		// Token: 0x17003275 RID: 12917
		// (get) Token: 0x0600F78F RID: 63375 RVA: 0x00242043 File Offset: 0x00240243
		// (set) Token: 0x0600F790 RID: 63376 RVA: 0x0024204B File Offset: 0x0024024B
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

		// Token: 0x0600F791 RID: 63377 RVA: 0x00242054 File Offset: 0x00240254
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NewTowerClimbingLevelRecord);
		}

		// Token: 0x0600F792 RID: 63378 RVA: 0x00242064 File Offset: 0x00240264
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NewTowerClimbingLevelRecord other)
		{
			return other != null && (other == this || (this.LevelId == other.LevelId && this.waveConfigIds_.Equals(other.waveConfigIds_) && object.Equals(this.NextMonsterInfoPreview, other.NextMonsterInfoPreview) && this.teamChallengeInfos_.Equals(other.teamChallengeInfos_) && this.Score == other.Score && this.IsUnlock == other.IsUnlock && this.RoleEnergyDict.Equals(other.RoleEnergyDict) && this.HistoryScore == other.HistoryScore && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600F793 RID: 63379 RVA: 0x00242124 File Offset: 0x00240324
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

		// Token: 0x0600F794 RID: 63380 RVA: 0x002421EE File Offset: 0x002403EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600F795 RID: 63381 RVA: 0x002421FB File Offset: 0x002403FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600F796 RID: 63382 RVA: 0x00242204 File Offset: 0x00240404
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

		// Token: 0x0600F797 RID: 63383 RVA: 0x002422E4 File Offset: 0x002404E4
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

		// Token: 0x0600F798 RID: 63384 RVA: 0x002423B0 File Offset: 0x002405B0
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

		// Token: 0x0600F799 RID: 63385 RVA: 0x00242487 File Offset: 0x00240687
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600F79A RID: 63386 RVA: 0x00242490 File Offset: 0x00240690
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

		// Token: 0x040063B3 RID: 25523
		private static readonly MessageParser<NewTowerClimbingLevelRecord> _parser = new MessageParser<NewTowerClimbingLevelRecord>(() => new NewTowerClimbingLevelRecord());

		// Token: 0x040063B4 RID: 25524
		private UnknownFieldSet _unknownFields;

		// Token: 0x040063B5 RID: 25525
		public const int LevelIdFieldNumber = 1;

		// Token: 0x040063B6 RID: 25526
		private int levelId_;

		// Token: 0x040063B7 RID: 25527
		public const int WaveConfigIdsFieldNumber = 2;

		// Token: 0x040063B8 RID: 25528
		private static readonly FieldCodec<int> _repeated_waveConfigIds_codec = FieldCodec.ForInt32(18U);

		// Token: 0x040063B9 RID: 25529
		private readonly RepeatedField<int> waveConfigIds_ = new RepeatedField<int>();

		// Token: 0x040063BA RID: 25530
		public const int NextMonsterInfoPreviewFieldNumber = 3;

		// Token: 0x040063BB RID: 25531
		private MonsterInfoPreview nextMonsterInfoPreview_;

		// Token: 0x040063BC RID: 25532
		public const int TeamChallengeInfosFieldNumber = 4;

		// Token: 0x040063BD RID: 25533
		private static readonly FieldCodec<TeamChallengeInfo> _repeated_teamChallengeInfos_codec = FieldCodec.ForMessage<TeamChallengeInfo>(34U, TeamChallengeInfo.Parser);

		// Token: 0x040063BE RID: 25534
		private readonly RepeatedField<TeamChallengeInfo> teamChallengeInfos_ = new RepeatedField<TeamChallengeInfo>();

		// Token: 0x040063BF RID: 25535
		public const int ScoreFieldNumber = 7;

		// Token: 0x040063C0 RID: 25536
		private int score_;

		// Token: 0x040063C1 RID: 25537
		public const int IsUnlockFieldNumber = 8;

		// Token: 0x040063C2 RID: 25538
		private bool isUnlock_;

		// Token: 0x040063C3 RID: 25539
		public const int RoleEnergyDictFieldNumber = 9;

		// Token: 0x040063C4 RID: 25540
		private static readonly MapField<int, int>.Codec _map_roleEnergyDict_codec = new MapField<int, int>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForInt32(16U, 0), 74U);

		// Token: 0x040063C5 RID: 25541
		private readonly MapField<int, int> roleEnergyDict_ = new MapField<int, int>();

		// Token: 0x040063C6 RID: 25542
		public const int HistoryScoreFieldNumber = 10;

		// Token: 0x040063C7 RID: 25543
		private int historyScore_;
	}
}
