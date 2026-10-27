using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200132D RID: 4909
	public sealed class TeamParkourLevelPlayInfo : IMessage<TeamParkourLevelPlayInfo>, IMessage, IEquatable<TeamParkourLevelPlayInfo>, IDeepCloneable<TeamParkourLevelPlayInfo>, IBufferMessage
	{
		// Token: 0x0601A151 RID: 106833 RVA: 0x003C9E1B File Offset: 0x003C801B
		[NullableContext(1)]
		public static TeamParkourLevelPlayInfo Create()
		{
			return new TeamParkourLevelPlayInfo();
		}

		// Token: 0x170057F6 RID: 22518
		// (get) Token: 0x0601A152 RID: 106834 RVA: 0x003C9E22 File Offset: 0x003C8022
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<TeamParkourLevelPlayInfo> Parser
		{
			get
			{
				return TeamParkourLevelPlayInfo._parser;
			}
		}

		// Token: 0x170057F7 RID: 22519
		// (get) Token: 0x0601A153 RID: 106835 RVA: 0x003C9E29 File Offset: 0x003C8029
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170057F8 RID: 22520
		// (get) Token: 0x0601A154 RID: 106836 RVA: 0x003C9E2C File Offset: 0x003C802C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TeamParkourLevelPlayInfo.Descriptor;
			}
		}

		// Token: 0x0601A155 RID: 106837 RVA: 0x003C9E33 File Offset: 0x003C8033
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TeamParkourLevelPlayInfo()
		{
		}

		// Token: 0x0601A156 RID: 106838 RVA: 0x003C9E3C File Offset: 0x003C803C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TeamParkourLevelPlayInfo(TeamParkourLevelPlayInfo other) : this()
		{
			this.levelId_ = other.levelId_;
			this.score_ = other.score_;
			this.ranking_ = other.ranking_;
			this.startTime_ = other.startTime_;
			this.timeCost_ = other.timeCost_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601A157 RID: 106839 RVA: 0x003C9E9C File Offset: 0x003C809C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TeamParkourLevelPlayInfo Clone()
		{
			return new TeamParkourLevelPlayInfo(this);
		}

		// Token: 0x170057F9 RID: 22521
		// (get) Token: 0x0601A158 RID: 106840 RVA: 0x003C9EA4 File Offset: 0x003C80A4
		// (set) Token: 0x0601A159 RID: 106841 RVA: 0x003C9EAC File Offset: 0x003C80AC
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

		// Token: 0x170057FA RID: 22522
		// (get) Token: 0x0601A15A RID: 106842 RVA: 0x003C9EB5 File Offset: 0x003C80B5
		// (set) Token: 0x0601A15B RID: 106843 RVA: 0x003C9EBD File Offset: 0x003C80BD
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

		// Token: 0x170057FB RID: 22523
		// (get) Token: 0x0601A15C RID: 106844 RVA: 0x003C9EC6 File Offset: 0x003C80C6
		// (set) Token: 0x0601A15D RID: 106845 RVA: 0x003C9ECE File Offset: 0x003C80CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Ranking
		{
			get
			{
				return this.ranking_;
			}
			set
			{
				this.ranking_ = value;
			}
		}

		// Token: 0x170057FC RID: 22524
		// (get) Token: 0x0601A15E RID: 106846 RVA: 0x003C9ED7 File Offset: 0x003C80D7
		// (set) Token: 0x0601A15F RID: 106847 RVA: 0x003C9EDF File Offset: 0x003C80DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int StartTime
		{
			get
			{
				return this.startTime_;
			}
			set
			{
				this.startTime_ = value;
			}
		}

		// Token: 0x170057FD RID: 22525
		// (get) Token: 0x0601A160 RID: 106848 RVA: 0x003C9EE8 File Offset: 0x003C80E8
		// (set) Token: 0x0601A161 RID: 106849 RVA: 0x003C9EF0 File Offset: 0x003C80F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TimeCost
		{
			get
			{
				return this.timeCost_;
			}
			set
			{
				this.timeCost_ = value;
			}
		}

		// Token: 0x0601A162 RID: 106850 RVA: 0x003C9EF9 File Offset: 0x003C80F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TeamParkourLevelPlayInfo);
		}

		// Token: 0x0601A163 RID: 106851 RVA: 0x003C9F08 File Offset: 0x003C8108
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TeamParkourLevelPlayInfo other)
		{
			return other != null && (other == this || (this.LevelId == other.LevelId && this.Score == other.Score && this.Ranking == other.Ranking && this.StartTime == other.StartTime && this.TimeCost == other.TimeCost && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601A164 RID: 106852 RVA: 0x003C9F84 File Offset: 0x003C8184
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
			if (this.Ranking != 0)
			{
				num ^= this.Ranking.GetHashCode();
			}
			if (this.StartTime != 0)
			{
				num ^= this.StartTime.GetHashCode();
			}
			if (this.TimeCost != 0)
			{
				num ^= this.TimeCost.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601A165 RID: 106853 RVA: 0x003CA027 File Offset: 0x003C8227
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601A166 RID: 106854 RVA: 0x003CA034 File Offset: 0x003C8234
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601A167 RID: 106855 RVA: 0x003CA040 File Offset: 0x003C8240
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
			if (this.Ranking != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.Ranking);
			}
			if (this.StartTime != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.StartTime);
			}
			if (this.TimeCost != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.TimeCost);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601A168 RID: 106856 RVA: 0x003CA0EC File Offset: 0x003C82EC
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
			if (this.Ranking != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Ranking);
			}
			if (this.StartTime != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.StartTime);
			}
			if (this.TimeCost != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TimeCost);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601A169 RID: 106857 RVA: 0x003CA18C File Offset: 0x003C838C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TeamParkourLevelPlayInfo other)
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
			if (other.Ranking != 0)
			{
				this.Ranking = other.Ranking;
			}
			if (other.StartTime != 0)
			{
				this.StartTime = other.StartTime;
			}
			if (other.TimeCost != 0)
			{
				this.TimeCost = other.TimeCost;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601A16A RID: 106858 RVA: 0x003CA218 File Offset: 0x003C8418
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601A16B RID: 106859 RVA: 0x003CA224 File Offset: 0x003C8424
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
					if (num == 24U)
					{
						this.Ranking = input.ReadInt32();
						continue;
					}
					if (num == 32U)
					{
						this.StartTime = input.ReadInt32();
						continue;
					}
					if (num == 40U)
					{
						this.TimeCost = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04009846 RID: 38982
		private static readonly MessageParser<TeamParkourLevelPlayInfo> _parser = new MessageParser<TeamParkourLevelPlayInfo>(() => new TeamParkourLevelPlayInfo());

		// Token: 0x04009847 RID: 38983
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009848 RID: 38984
		public const int LevelIdFieldNumber = 1;

		// Token: 0x04009849 RID: 38985
		private int levelId_;

		// Token: 0x0400984A RID: 38986
		public const int ScoreFieldNumber = 2;

		// Token: 0x0400984B RID: 38987
		private int score_;

		// Token: 0x0400984C RID: 38988
		public const int RankingFieldNumber = 3;

		// Token: 0x0400984D RID: 38989
		private int ranking_;

		// Token: 0x0400984E RID: 38990
		public const int StartTimeFieldNumber = 4;

		// Token: 0x0400984F RID: 38991
		private int startTime_;

		// Token: 0x04009850 RID: 38992
		public const int TimeCostFieldNumber = 5;

		// Token: 0x04009851 RID: 38993
		private int timeCost_;
	}
}
