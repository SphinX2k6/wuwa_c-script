using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200139A RID: 5018
	public sealed class TeamParkourLevelPlayInfo : IMessage<TeamParkourLevelPlayInfo>, IMessage, IEquatable<TeamParkourLevelPlayInfo>, IDeepCloneable<TeamParkourLevelPlayInfo>, IBufferMessage
	{
		// Token: 0x0601AB61 RID: 109409 RVA: 0x003E40D7 File Offset: 0x003E22D7
		[NullableContext(1)]
		public static TeamParkourLevelPlayInfo Create()
		{
			return new TeamParkourLevelPlayInfo();
		}

		// Token: 0x17005A70 RID: 23152
		// (get) Token: 0x0601AB62 RID: 109410 RVA: 0x003E40DE File Offset: 0x003E22DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<TeamParkourLevelPlayInfo> Parser
		{
			get
			{
				return TeamParkourLevelPlayInfo._parser;
			}
		}

		// Token: 0x17005A71 RID: 23153
		// (get) Token: 0x0601AB63 RID: 109411 RVA: 0x003E40E5 File Offset: 0x003E22E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005A72 RID: 23154
		// (get) Token: 0x0601AB64 RID: 109412 RVA: 0x003E40E8 File Offset: 0x003E22E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TeamParkourLevelPlayInfo.Descriptor;
			}
		}

		// Token: 0x0601AB65 RID: 109413 RVA: 0x003E40EF File Offset: 0x003E22EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TeamParkourLevelPlayInfo()
		{
		}

		// Token: 0x0601AB66 RID: 109414 RVA: 0x003E40F8 File Offset: 0x003E22F8
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

		// Token: 0x0601AB67 RID: 109415 RVA: 0x003E4158 File Offset: 0x003E2358
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TeamParkourLevelPlayInfo Clone()
		{
			return new TeamParkourLevelPlayInfo(this);
		}

		// Token: 0x17005A73 RID: 23155
		// (get) Token: 0x0601AB68 RID: 109416 RVA: 0x003E4160 File Offset: 0x003E2360
		// (set) Token: 0x0601AB69 RID: 109417 RVA: 0x003E4168 File Offset: 0x003E2368
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

		// Token: 0x17005A74 RID: 23156
		// (get) Token: 0x0601AB6A RID: 109418 RVA: 0x003E4171 File Offset: 0x003E2371
		// (set) Token: 0x0601AB6B RID: 109419 RVA: 0x003E4179 File Offset: 0x003E2379
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

		// Token: 0x17005A75 RID: 23157
		// (get) Token: 0x0601AB6C RID: 109420 RVA: 0x003E4182 File Offset: 0x003E2382
		// (set) Token: 0x0601AB6D RID: 109421 RVA: 0x003E418A File Offset: 0x003E238A
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

		// Token: 0x17005A76 RID: 23158
		// (get) Token: 0x0601AB6E RID: 109422 RVA: 0x003E4193 File Offset: 0x003E2393
		// (set) Token: 0x0601AB6F RID: 109423 RVA: 0x003E419B File Offset: 0x003E239B
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

		// Token: 0x17005A77 RID: 23159
		// (get) Token: 0x0601AB70 RID: 109424 RVA: 0x003E41A4 File Offset: 0x003E23A4
		// (set) Token: 0x0601AB71 RID: 109425 RVA: 0x003E41AC File Offset: 0x003E23AC
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

		// Token: 0x0601AB72 RID: 109426 RVA: 0x003E41B5 File Offset: 0x003E23B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TeamParkourLevelPlayInfo);
		}

		// Token: 0x0601AB73 RID: 109427 RVA: 0x003E41C4 File Offset: 0x003E23C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TeamParkourLevelPlayInfo other)
		{
			return other != null && (other == this || (this.LevelId == other.LevelId && this.Score == other.Score && this.Ranking == other.Ranking && this.StartTime == other.StartTime && this.TimeCost == other.TimeCost && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601AB74 RID: 109428 RVA: 0x003E4240 File Offset: 0x003E2440
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

		// Token: 0x0601AB75 RID: 109429 RVA: 0x003E42E3 File Offset: 0x003E24E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601AB76 RID: 109430 RVA: 0x003E42F0 File Offset: 0x003E24F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601AB77 RID: 109431 RVA: 0x003E42FC File Offset: 0x003E24FC
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

		// Token: 0x0601AB78 RID: 109432 RVA: 0x003E43A8 File Offset: 0x003E25A8
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

		// Token: 0x0601AB79 RID: 109433 RVA: 0x003E4448 File Offset: 0x003E2648
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

		// Token: 0x0601AB7A RID: 109434 RVA: 0x003E44D4 File Offset: 0x003E26D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601AB7B RID: 109435 RVA: 0x003E44E0 File Offset: 0x003E26E0
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

		// Token: 0x04009C68 RID: 40040
		private static readonly MessageParser<TeamParkourLevelPlayInfo> _parser = new MessageParser<TeamParkourLevelPlayInfo>(() => new TeamParkourLevelPlayInfo());

		// Token: 0x04009C69 RID: 40041
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009C6A RID: 40042
		public const int LevelIdFieldNumber = 1;

		// Token: 0x04009C6B RID: 40043
		private int levelId_;

		// Token: 0x04009C6C RID: 40044
		public const int ScoreFieldNumber = 2;

		// Token: 0x04009C6D RID: 40045
		private int score_;

		// Token: 0x04009C6E RID: 40046
		public const int RankingFieldNumber = 3;

		// Token: 0x04009C6F RID: 40047
		private int ranking_;

		// Token: 0x04009C70 RID: 40048
		public const int StartTimeFieldNumber = 4;

		// Token: 0x04009C71 RID: 40049
		private int startTime_;

		// Token: 0x04009C72 RID: 40050
		public const int TimeCostFieldNumber = 5;

		// Token: 0x04009C73 RID: 40051
		private int timeCost_;
	}
}
