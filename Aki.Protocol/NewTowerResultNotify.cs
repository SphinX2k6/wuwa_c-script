using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B43 RID: 2883
	[NetMessage(EMessageId.NewTowerResultNotify)]
	public sealed class NewTowerResultNotify : IMessage<NewTowerResultNotify>, IMessage, IEquatable<NewTowerResultNotify>, IDeepCloneable<NewTowerResultNotify>, IBufferMessage
	{
		// Token: 0x0600FA1E RID: 64030 RVA: 0x0024777F File Offset: 0x0024597F
		[NullableContext(1)]
		public static NewTowerResultNotify Create()
		{
			return new NewTowerResultNotify();
		}

		// Token: 0x170032FF RID: 13055
		// (get) Token: 0x0600FA1F RID: 64031 RVA: 0x00247786 File Offset: 0x00245986
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003300 RID: 13056
		// (get) Token: 0x0600FA20 RID: 64032 RVA: 0x00247789 File Offset: 0x00245989
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NewTowerResultNotify.Descriptor;
			}
		}

		// Token: 0x0600FA21 RID: 64033 RVA: 0x00247790 File Offset: 0x00245990
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewTowerResultNotify()
		{
		}

		// Token: 0x0600FA22 RID: 64034 RVA: 0x002477B0 File Offset: 0x002459B0
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

		// Token: 0x0600FA23 RID: 64035 RVA: 0x00247866 File Offset: 0x00245A66
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewTowerResultNotify Clone()
		{
			return new NewTowerResultNotify(this);
		}

		// Token: 0x17003301 RID: 13057
		// (get) Token: 0x0600FA24 RID: 64036 RVA: 0x0024786E File Offset: 0x00245A6E
		// (set) Token: 0x0600FA25 RID: 64037 RVA: 0x00247876 File Offset: 0x00245A76
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

		// Token: 0x17003302 RID: 13058
		// (get) Token: 0x0600FA26 RID: 64038 RVA: 0x0024787F File Offset: 0x00245A7F
		// (set) Token: 0x0600FA27 RID: 64039 RVA: 0x00247887 File Offset: 0x00245A87
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

		// Token: 0x17003303 RID: 13059
		// (get) Token: 0x0600FA28 RID: 64040 RVA: 0x00247890 File Offset: 0x00245A90
		// (set) Token: 0x0600FA29 RID: 64041 RVA: 0x00247898 File Offset: 0x00245A98
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

		// Token: 0x17003304 RID: 13060
		// (get) Token: 0x0600FA2A RID: 64042 RVA: 0x002478A1 File Offset: 0x00245AA1
		// (set) Token: 0x0600FA2B RID: 64043 RVA: 0x002478A9 File Offset: 0x00245AA9
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

		// Token: 0x17003305 RID: 13061
		// (get) Token: 0x0600FA2C RID: 64044 RVA: 0x002478B2 File Offset: 0x00245AB2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<MonsterInfoPreview> MonsterInfoPreviews
		{
			get
			{
				return this.monsterInfoPreviews_;
			}
		}

		// Token: 0x17003306 RID: 13062
		// (get) Token: 0x0600FA2D RID: 64045 RVA: 0x002478BA File Offset: 0x00245ABA
		// (set) Token: 0x0600FA2E RID: 64046 RVA: 0x002478C2 File Offset: 0x00245AC2
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

		// Token: 0x17003307 RID: 13063
		// (get) Token: 0x0600FA2F RID: 64047 RVA: 0x002478CB File Offset: 0x00245ACB
		// (set) Token: 0x0600FA30 RID: 64048 RVA: 0x002478D3 File Offset: 0x00245AD3
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

		// Token: 0x17003308 RID: 13064
		// (get) Token: 0x0600FA31 RID: 64049 RVA: 0x002478DC File Offset: 0x00245ADC
		// (set) Token: 0x0600FA32 RID: 64050 RVA: 0x002478E4 File Offset: 0x00245AE4
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

		// Token: 0x17003309 RID: 13065
		// (get) Token: 0x0600FA33 RID: 64051 RVA: 0x002478ED File Offset: 0x00245AED
		// (set) Token: 0x0600FA34 RID: 64052 RVA: 0x002478F5 File Offset: 0x00245AF5
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

		// Token: 0x1700330A RID: 13066
		// (get) Token: 0x0600FA35 RID: 64053 RVA: 0x002478FE File Offset: 0x00245AFE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> CompletedSeasonTaskIds
		{
			get
			{
				return this.completedSeasonTaskIds_;
			}
		}

		// Token: 0x0600FA36 RID: 64054 RVA: 0x00247906 File Offset: 0x00245B06
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NewTowerResultNotify);
		}

		// Token: 0x0600FA37 RID: 64055 RVA: 0x00247914 File Offset: 0x00245B14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NewTowerResultNotify other)
		{
			return other != null && (other == this || (this.LevelId == other.LevelId && this.Score == other.Score && this.TotalScore == other.TotalScore && object.Equals(this.TeamChallengeInfo, other.TeamChallengeInfo) && this.monsterInfoPreviews_.Equals(other.monsterInfoPreviews_) && this.BeforeLevelScore == other.BeforeLevelScore && this.AfterLevelScore == other.AfterLevelScore && this.BeforeTeamScore == other.BeforeTeamScore && this.AfterTeamScore == other.AfterTeamScore && this.completedSeasonTaskIds_.Equals(other.completedSeasonTaskIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600FA38 RID: 64056 RVA: 0x002479EC File Offset: 0x00245BEC
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

		// Token: 0x0600FA39 RID: 64057 RVA: 0x00247AF3 File Offset: 0x00245CF3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600FA3A RID: 64058 RVA: 0x00247B00 File Offset: 0x00245D00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600FA3B RID: 64059 RVA: 0x00247B0C File Offset: 0x00245D0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.LevelId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.LevelId);
			}
			if (this.Score != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Score);
			}
			if (this.teamChallengeInfo_ != null)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.TeamChallengeInfo);
			}
			if (this.AfterTeamScore != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.AfterTeamScore);
			}
			if (this.BeforeLevelScore != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.BeforeLevelScore);
			}
			this.completedSeasonTaskIds_.WriteTo(ref output, NewTowerResultNotify._repeated_completedSeasonTaskIds_codec);
			this.monsterInfoPreviews_.WriteTo(ref output, NewTowerResultNotify._repeated_monsterInfoPreviews_codec);
			if (this.TotalScore != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.TotalScore);
			}
			if (this.AfterLevelScore != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.AfterLevelScore);
			}
			if (this.BeforeTeamScore != 0)
			{
				output.WriteRawTag(120);
				output.WriteInt32(this.BeforeTeamScore);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600FA3C RID: 64060 RVA: 0x00247C30 File Offset: 0x00245E30
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

		// Token: 0x0600FA3D RID: 64061 RVA: 0x00247D3C File Offset: 0x00245F3C
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

		// Token: 0x0600FA3E RID: 64062 RVA: 0x00247E3E File Offset: 0x0024603E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600FA3F RID: 64063 RVA: 0x00247E48 File Offset: 0x00246048
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
				if (num <= 64U)
				{
					if (num <= 16U)
					{
						if (num == 8U)
						{
							this.LevelId = input.ReadInt32();
							continue;
						}
						if (num == 16U)
						{
							this.Score = input.ReadInt32();
							continue;
						}
					}
					else
					{
						if (num == 34U)
						{
							if (this.teamChallengeInfo_ == null)
							{
								this.TeamChallengeInfo = new TeamChallengeInfo();
							}
							input.ReadMessage(this.TeamChallengeInfo);
							continue;
						}
						if (num == 40U)
						{
							this.AfterTeamScore = input.ReadInt32();
							continue;
						}
						if (num == 64U)
						{
							this.BeforeLevelScore = input.ReadInt32();
							continue;
						}
					}
				}
				else if (num <= 90U)
				{
					if (num == 72U || num == 74U)
					{
						this.completedSeasonTaskIds_.AddEntriesFrom(ref input, NewTowerResultNotify._repeated_completedSeasonTaskIds_codec);
						continue;
					}
					if (num == 90U)
					{
						this.monsterInfoPreviews_.AddEntriesFrom(ref input, NewTowerResultNotify._repeated_monsterInfoPreviews_codec);
						continue;
					}
				}
				else
				{
					if (num == 96U)
					{
						this.TotalScore = input.ReadInt32();
						continue;
					}
					if (num == 104U)
					{
						this.AfterLevelScore = input.ReadInt32();
						continue;
					}
					if (num == 120U)
					{
						this.BeforeTeamScore = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04006425 RID: 25637
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006426 RID: 25638
		public const int LevelIdFieldNumber = 1;

		// Token: 0x04006427 RID: 25639
		private int levelId_;

		// Token: 0x04006428 RID: 25640
		public const int ScoreFieldNumber = 2;

		// Token: 0x04006429 RID: 25641
		private int score_;

		// Token: 0x0400642A RID: 25642
		public const int TotalScoreFieldNumber = 12;

		// Token: 0x0400642B RID: 25643
		private int totalScore_;

		// Token: 0x0400642C RID: 25644
		public const int TeamChallengeInfoFieldNumber = 4;

		// Token: 0x0400642D RID: 25645
		private TeamChallengeInfo teamChallengeInfo_;

		// Token: 0x0400642E RID: 25646
		public const int MonsterInfoPreviewsFieldNumber = 11;

		// Token: 0x0400642F RID: 25647
		private static readonly FieldCodec<MonsterInfoPreview> _repeated_monsterInfoPreviews_codec = FieldCodec.ForMessage<MonsterInfoPreview>(90U, MonsterInfoPreview.Parser);

		// Token: 0x04006430 RID: 25648
		private readonly RepeatedField<MonsterInfoPreview> monsterInfoPreviews_ = new RepeatedField<MonsterInfoPreview>();

		// Token: 0x04006431 RID: 25649
		public const int BeforeLevelScoreFieldNumber = 8;

		// Token: 0x04006432 RID: 25650
		private int beforeLevelScore_;

		// Token: 0x04006433 RID: 25651
		public const int AfterLevelScoreFieldNumber = 13;

		// Token: 0x04006434 RID: 25652
		private int afterLevelScore_;

		// Token: 0x04006435 RID: 25653
		public const int BeforeTeamScoreFieldNumber = 15;

		// Token: 0x04006436 RID: 25654
		private int beforeTeamScore_;

		// Token: 0x04006437 RID: 25655
		public const int AfterTeamScoreFieldNumber = 5;

		// Token: 0x04006438 RID: 25656
		private int afterTeamScore_;

		// Token: 0x04006439 RID: 25657
		public const int CompletedSeasonTaskIdsFieldNumber = 9;

		// Token: 0x0400643A RID: 25658
		private static readonly FieldCodec<int> _repeated_completedSeasonTaskIds_codec = FieldCodec.ForInt32(74U);

		// Token: 0x0400643B RID: 25659
		private readonly RepeatedField<int> completedSeasonTaskIds_ = new RepeatedField<int>();
	}
}
