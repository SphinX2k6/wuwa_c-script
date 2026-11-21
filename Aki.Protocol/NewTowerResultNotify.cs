using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B32 RID: 2866
	[NetMessage(EMessageId.NewTowerResultNotify)]
	public sealed class NewTowerResultNotify : IMessage<NewTowerResultNotify>, IMessage, IEquatable<NewTowerResultNotify>, IDeepCloneable<NewTowerResultNotify>, IBufferMessage
	{
		// Token: 0x0600F904 RID: 63748 RVA: 0x00245567 File Offset: 0x00243767
		[NullableContext(1)]
		public static NewTowerResultNotify Create()
		{
			return new NewTowerResultNotify();
		}

		// Token: 0x170032C1 RID: 12993
		// (get) Token: 0x0600F905 RID: 63749 RVA: 0x0024556E File Offset: 0x0024376E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170032C2 RID: 12994
		// (get) Token: 0x0600F906 RID: 63750 RVA: 0x00245571 File Offset: 0x00243771
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NewTowerResultNotify.Descriptor;
			}
		}

		// Token: 0x0600F907 RID: 63751 RVA: 0x00245578 File Offset: 0x00243778
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewTowerResultNotify()
		{
		}

		// Token: 0x0600F908 RID: 63752 RVA: 0x00245598 File Offset: 0x00243798
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewTowerResultNotify(NewTowerResultNotify other) : this()
		{
			this.levelId_ = other.levelId_;
			this.score_ = other.score_;
			this.totalScore_ = other.totalScore_;
			this.teamChallengeInfo_ = ((other.teamChallengeInfo_ != null) ? other.teamChallengeInfo_.Clone() : null);
			this.monsterInfoPreviews_ = other.monsterInfoPreviews_.Clone();
			this.beforeLevelScore_ = other.beforeLevelScore_;
			this.afterLevelScore_ = other.afterLevelScore_;
			this.beforeTeamScore_ = other.beforeTeamScore_;
			this.afterTeamScore_ = other.afterTeamScore_;
			this.completedSeasonTaskIds_ = other.completedSeasonTaskIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600F909 RID: 63753 RVA: 0x0024564E File Offset: 0x0024384E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewTowerResultNotify Clone()
		{
			return new NewTowerResultNotify(this);
		}

		// Token: 0x170032C3 RID: 12995
		// (get) Token: 0x0600F90A RID: 63754 RVA: 0x00245656 File Offset: 0x00243856
		// (set) Token: 0x0600F90B RID: 63755 RVA: 0x0024565E File Offset: 0x0024385E
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

		// Token: 0x170032C4 RID: 12996
		// (get) Token: 0x0600F90C RID: 63756 RVA: 0x00245667 File Offset: 0x00243867
		// (set) Token: 0x0600F90D RID: 63757 RVA: 0x0024566F File Offset: 0x0024386F
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

		// Token: 0x170032C5 RID: 12997
		// (get) Token: 0x0600F90E RID: 63758 RVA: 0x00245678 File Offset: 0x00243878
		// (set) Token: 0x0600F90F RID: 63759 RVA: 0x00245680 File Offset: 0x00243880
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TotalScore
		{
			get
			{
				return this.totalScore_;
			}
			set
			{
				this.totalScore_ = value;
			}
		}

		// Token: 0x170032C6 RID: 12998
		// (get) Token: 0x0600F910 RID: 63760 RVA: 0x00245689 File Offset: 0x00243889
		// (set) Token: 0x0600F911 RID: 63761 RVA: 0x00245691 File Offset: 0x00243891
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TeamChallengeInfo TeamChallengeInfo
		{
			get
			{
				return this.teamChallengeInfo_;
			}
			set
			{
				this.teamChallengeInfo_ = value;
			}
		}

		// Token: 0x170032C7 RID: 12999
		// (get) Token: 0x0600F912 RID: 63762 RVA: 0x0024569A File Offset: 0x0024389A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<MonsterInfoPreview> MonsterInfoPreviews
		{
			get
			{
				return this.monsterInfoPreviews_;
			}
		}

		// Token: 0x170032C8 RID: 13000
		// (get) Token: 0x0600F913 RID: 63763 RVA: 0x002456A2 File Offset: 0x002438A2
		// (set) Token: 0x0600F914 RID: 63764 RVA: 0x002456AA File Offset: 0x002438AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int BeforeLevelScore
		{
			get
			{
				return this.beforeLevelScore_;
			}
			set
			{
				this.beforeLevelScore_ = value;
			}
		}

		// Token: 0x170032C9 RID: 13001
		// (get) Token: 0x0600F915 RID: 63765 RVA: 0x002456B3 File Offset: 0x002438B3
		// (set) Token: 0x0600F916 RID: 63766 RVA: 0x002456BB File Offset: 0x002438BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int AfterLevelScore
		{
			get
			{
				return this.afterLevelScore_;
			}
			set
			{
				this.afterLevelScore_ = value;
			}
		}

		// Token: 0x170032CA RID: 13002
		// (get) Token: 0x0600F917 RID: 63767 RVA: 0x002456C4 File Offset: 0x002438C4
		// (set) Token: 0x0600F918 RID: 63768 RVA: 0x002456CC File Offset: 0x002438CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int BeforeTeamScore
		{
			get
			{
				return this.beforeTeamScore_;
			}
			set
			{
				this.beforeTeamScore_ = value;
			}
		}

		// Token: 0x170032CB RID: 13003
		// (get) Token: 0x0600F919 RID: 63769 RVA: 0x002456D5 File Offset: 0x002438D5
		// (set) Token: 0x0600F91A RID: 63770 RVA: 0x002456DD File Offset: 0x002438DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int AfterTeamScore
		{
			get
			{
				return this.afterTeamScore_;
			}
			set
			{
				this.afterTeamScore_ = value;
			}
		}

		// Token: 0x170032CC RID: 13004
		// (get) Token: 0x0600F91B RID: 63771 RVA: 0x002456E6 File Offset: 0x002438E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> CompletedSeasonTaskIds
		{
			get
			{
				return this.completedSeasonTaskIds_;
			}
		}

		// Token: 0x0600F91C RID: 63772 RVA: 0x002456EE File Offset: 0x002438EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NewTowerResultNotify);
		}

		// Token: 0x0600F91D RID: 63773 RVA: 0x002456FC File Offset: 0x002438FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NewTowerResultNotify other)
		{
			return other != null && (other == this || (this.LevelId == other.LevelId && this.Score == other.Score && this.TotalScore == other.TotalScore && object.Equals(this.TeamChallengeInfo, other.TeamChallengeInfo) && this.monsterInfoPreviews_.Equals(other.monsterInfoPreviews_) && this.BeforeLevelScore == other.BeforeLevelScore && this.AfterLevelScore == other.AfterLevelScore && this.BeforeTeamScore == other.BeforeTeamScore && this.AfterTeamScore == other.AfterTeamScore && this.completedSeasonTaskIds_.Equals(other.completedSeasonTaskIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600F91E RID: 63774 RVA: 0x002457D4 File Offset: 0x002439D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.LevelId != 0)
			{
				num ^= this.LevelId.GetHashCode();
			}
			if (this.Score != 0)
			{
				num ^= this.Score.GetHashCode();
			}
			if (this.TotalScore != 0)
			{
				num ^= this.TotalScore.GetHashCode();
			}
			if (this.teamChallengeInfo_ != null)
			{
				num ^= this.TeamChallengeInfo.GetHashCode();
			}
			num ^= this.monsterInfoPreviews_.GetHashCode();
			if (this.BeforeLevelScore != 0)
			{
				num ^= this.BeforeLevelScore.GetHashCode();
			}
			if (this.AfterLevelScore != 0)
			{
				num ^= this.AfterLevelScore.GetHashCode();
			}
			if (this.BeforeTeamScore != 0)
			{
				num ^= this.BeforeTeamScore.GetHashCode();
			}
			if (this.AfterTeamScore != 0)
			{
				num ^= this.AfterTeamScore.GetHashCode();
			}
			num ^= this.completedSeasonTaskIds_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600F91F RID: 63775 RVA: 0x002458DB File Offset: 0x00243ADB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600F920 RID: 63776 RVA: 0x002458E8 File Offset: 0x00243AE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600F921 RID: 63777 RVA: 0x002458F4 File Offset: 0x00243AF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.teamChallengeInfo_ != null)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.TeamChallengeInfo);
			}
			if (this.BeforeLevelScore != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.BeforeLevelScore);
			}
			if (this.BeforeTeamScore != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.BeforeTeamScore);
			}
			if (this.AfterTeamScore != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.AfterTeamScore);
			}
			this.monsterInfoPreviews_.WriteTo(ref output, NewTowerResultNotify._repeated_monsterInfoPreviews_codec);
			this.completedSeasonTaskIds_.WriteTo(ref output, NewTowerResultNotify._repeated_completedSeasonTaskIds_codec);
			if (this.AfterLevelScore != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.AfterLevelScore);
			}
			if (this.LevelId != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.LevelId);
			}
			if (this.Score != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.Score);
			}
			if (this.TotalScore != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.TotalScore);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600F922 RID: 63778 RVA: 0x00245A18 File Offset: 0x00243C18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.LevelId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.LevelId);
			}
			if (this.Score != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Score);
			}
			if (this.TotalScore != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TotalScore);
			}
			if (this.teamChallengeInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.TeamChallengeInfo);
			}
			num += this.monsterInfoPreviews_.CalculateSize(NewTowerResultNotify._repeated_monsterInfoPreviews_codec);
			if (this.BeforeLevelScore != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.BeforeLevelScore);
			}
			if (this.AfterLevelScore != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.AfterLevelScore);
			}
			if (this.BeforeTeamScore != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.BeforeTeamScore);
			}
			if (this.AfterTeamScore != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.AfterTeamScore);
			}
			num += this.completedSeasonTaskIds_.CalculateSize(NewTowerResultNotify._repeated_completedSeasonTaskIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600F923 RID: 63779 RVA: 0x00245B24 File Offset: 0x00243D24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(NewTowerResultNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.LevelId != 0)
			{
				this.LevelId = other.LevelId;
			}
			if (other.Score != 0)
			{
				this.Score = other.Score;
			}
			if (other.TotalScore != 0)
			{
				this.TotalScore = other.TotalScore;
			}
			if (other.teamChallengeInfo_ != null)
			{
				if (this.teamChallengeInfo_ == null)
				{
					this.TeamChallengeInfo = new TeamChallengeInfo();
				}
				this.TeamChallengeInfo.MergeFrom(other.TeamChallengeInfo);
			}
			this.monsterInfoPreviews_.Add(other.monsterInfoPreviews_);
			if (other.BeforeLevelScore != 0)
			{
				this.BeforeLevelScore = other.BeforeLevelScore;
			}
			if (other.AfterLevelScore != 0)
			{
				this.AfterLevelScore = other.AfterLevelScore;
			}
			if (other.BeforeTeamScore != 0)
			{
				this.BeforeTeamScore = other.BeforeTeamScore;
			}
			if (other.AfterTeamScore != 0)
			{
				this.AfterTeamScore = other.AfterTeamScore;
			}
			this.completedSeasonTaskIds_.Add(other.completedSeasonTaskIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600F924 RID: 63780 RVA: 0x00245C26 File Offset: 0x00243E26
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600F925 RID: 63781 RVA: 0x00245C30 File Offset: 0x00243E30
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
						if (num == 18U)
						{
							if (this.teamChallengeInfo_ == null)
							{
								this.TeamChallengeInfo = new TeamChallengeInfo();
							}
							input.ReadMessage(this.TeamChallengeInfo);
							continue;
						}
						if (num == 24U)
						{
							this.BeforeLevelScore = input.ReadInt32();
							continue;
						}
					}
					else
					{
						if (num == 32U)
						{
							this.BeforeTeamScore = input.ReadInt32();
							continue;
						}
						if (num == 40U)
						{
							this.AfterTeamScore = input.ReadInt32();
							continue;
						}
						if (num == 50U)
						{
							this.monsterInfoPreviews_.AddEntriesFrom(ref input, NewTowerResultNotify._repeated_monsterInfoPreviews_codec);
							continue;
						}
					}
				}
				else if (num <= 80U)
				{
					if (num == 72U || num == 74U)
					{
						this.completedSeasonTaskIds_.AddEntriesFrom(ref input, NewTowerResultNotify._repeated_completedSeasonTaskIds_codec);
						continue;
					}
					if (num == 80U)
					{
						this.AfterLevelScore = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 88U)
					{
						this.LevelId = input.ReadInt32();
						continue;
					}
					if (num == 96U)
					{
						this.Score = input.ReadInt32();
						continue;
					}
					if (num == 104U)
					{
						this.TotalScore = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400642E RID: 25646
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400642F RID: 25647
		public const int LevelIdFieldNumber = 11;

		// Token: 0x04006430 RID: 25648
		private int levelId_;

		// Token: 0x04006431 RID: 25649
		public const int ScoreFieldNumber = 12;

		// Token: 0x04006432 RID: 25650
		private int score_;

		// Token: 0x04006433 RID: 25651
		public const int TotalScoreFieldNumber = 13;

		// Token: 0x04006434 RID: 25652
		private int totalScore_;

		// Token: 0x04006435 RID: 25653
		public const int TeamChallengeInfoFieldNumber = 2;

		// Token: 0x04006436 RID: 25654
		private TeamChallengeInfo teamChallengeInfo_;

		// Token: 0x04006437 RID: 25655
		public const int MonsterInfoPreviewsFieldNumber = 6;

		// Token: 0x04006438 RID: 25656
		private static readonly FieldCodec<MonsterInfoPreview> _repeated_monsterInfoPreviews_codec = FieldCodec.ForMessage<MonsterInfoPreview>(50U, MonsterInfoPreview.Parser);

		// Token: 0x04006439 RID: 25657
		private readonly RepeatedField<MonsterInfoPreview> monsterInfoPreviews_ = new RepeatedField<MonsterInfoPreview>();

		// Token: 0x0400643A RID: 25658
		public const int BeforeLevelScoreFieldNumber = 3;

		// Token: 0x0400643B RID: 25659
		private int beforeLevelScore_;

		// Token: 0x0400643C RID: 25660
		public const int AfterLevelScoreFieldNumber = 10;

		// Token: 0x0400643D RID: 25661
		private int afterLevelScore_;

		// Token: 0x0400643E RID: 25662
		public const int BeforeTeamScoreFieldNumber = 4;

		// Token: 0x0400643F RID: 25663
		private int beforeTeamScore_;

		// Token: 0x04006440 RID: 25664
		public const int AfterTeamScoreFieldNumber = 5;

		// Token: 0x04006441 RID: 25665
		private int afterTeamScore_;

		// Token: 0x04006442 RID: 25666
		public const int CompletedSeasonTaskIdsFieldNumber = 9;

		// Token: 0x04006443 RID: 25667
		private static readonly FieldCodec<int> _repeated_completedSeasonTaskIds_codec = FieldCodec.ForInt32(74U);

		// Token: 0x04006444 RID: 25668
		private readonly RepeatedField<int> completedSeasonTaskIds_ = new RepeatedField<int>();
	}
}
