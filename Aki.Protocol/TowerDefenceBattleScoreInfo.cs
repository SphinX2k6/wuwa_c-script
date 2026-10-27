using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200139A RID: 5018
	public sealed class TowerDefenceBattleScoreInfo : IMessage<TowerDefenceBattleScoreInfo>, IMessage, IEquatable<TowerDefenceBattleScoreInfo>, IDeepCloneable<TowerDefenceBattleScoreInfo>, IBufferMessage
	{
		// Token: 0x0601AA04 RID: 109060 RVA: 0x003DCBBA File Offset: 0x003DADBA
		[NullableContext(1)]
		public static TowerDefenceBattleScoreInfo Create()
		{
			return new TowerDefenceBattleScoreInfo();
		}

		// Token: 0x170059C6 RID: 22982
		// (get) Token: 0x0601AA05 RID: 109061 RVA: 0x003DCBC1 File Offset: 0x003DADC1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<TowerDefenceBattleScoreInfo> Parser
		{
			get
			{
				return TowerDefenceBattleScoreInfo._parser;
			}
		}

		// Token: 0x170059C7 RID: 22983
		// (get) Token: 0x0601AA06 RID: 109062 RVA: 0x003DCBC8 File Offset: 0x003DADC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170059C8 RID: 22984
		// (get) Token: 0x0601AA07 RID: 109063 RVA: 0x003DCBCB File Offset: 0x003DADCB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TowerDefenceBattleScoreInfo.Descriptor;
			}
		}

		// Token: 0x0601AA08 RID: 109064 RVA: 0x003DCBD2 File Offset: 0x003DADD2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerDefenceBattleScoreInfo()
		{
		}

		// Token: 0x0601AA09 RID: 109065 RVA: 0x003DCBDA File Offset: 0x003DADDA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerDefenceBattleScoreInfo(TowerDefenceBattleScoreInfo other) : this()
		{
			this.id_ = other.id_;
			this.score_ = other.score_;
			this.rankScore_ = other.rankScore_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601AA0A RID: 109066 RVA: 0x003DCC17 File Offset: 0x003DAE17
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerDefenceBattleScoreInfo Clone()
		{
			return new TowerDefenceBattleScoreInfo(this);
		}

		// Token: 0x170059C9 RID: 22985
		// (get) Token: 0x0601AA0B RID: 109067 RVA: 0x003DCC1F File Offset: 0x003DAE1F
		// (set) Token: 0x0601AA0C RID: 109068 RVA: 0x003DCC27 File Offset: 0x003DAE27
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Id
		{
			get
			{
				return this.id_;
			}
			set
			{
				this.id_ = value;
			}
		}

		// Token: 0x170059CA RID: 22986
		// (get) Token: 0x0601AA0D RID: 109069 RVA: 0x003DCC30 File Offset: 0x003DAE30
		// (set) Token: 0x0601AA0E RID: 109070 RVA: 0x003DCC38 File Offset: 0x003DAE38
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

		// Token: 0x170059CB RID: 22987
		// (get) Token: 0x0601AA0F RID: 109071 RVA: 0x003DCC41 File Offset: 0x003DAE41
		// (set) Token: 0x0601AA10 RID: 109072 RVA: 0x003DCC49 File Offset: 0x003DAE49
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RankScore
		{
			get
			{
				return this.rankScore_;
			}
			set
			{
				this.rankScore_ = value;
			}
		}

		// Token: 0x0601AA11 RID: 109073 RVA: 0x003DCC52 File Offset: 0x003DAE52
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TowerDefenceBattleScoreInfo);
		}

		// Token: 0x0601AA12 RID: 109074 RVA: 0x003DCC60 File Offset: 0x003DAE60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TowerDefenceBattleScoreInfo other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.Score == other.Score && this.RankScore == other.RankScore && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601AA13 RID: 109075 RVA: 0x003DCCBC File Offset: 0x003DAEBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.Score != 0)
			{
				num ^= this.Score.GetHashCode();
			}
			if (this.RankScore != 0)
			{
				num ^= this.RankScore.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601AA14 RID: 109076 RVA: 0x003DCD2D File Offset: 0x003DAF2D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601AA15 RID: 109077 RVA: 0x003DCD3A File Offset: 0x003DAF3A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601AA16 RID: 109078 RVA: 0x003DCD44 File Offset: 0x003DAF44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Id);
			}
			if (this.Score != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Score);
			}
			if (this.RankScore != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.RankScore);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601AA17 RID: 109079 RVA: 0x003DCDB8 File Offset: 0x003DAFB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			if (this.Score != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Score);
			}
			if (this.RankScore != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RankScore);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601AA18 RID: 109080 RVA: 0x003DCE28 File Offset: 0x003DB028
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TowerDefenceBattleScoreInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			if (other.Score != 0)
			{
				this.Score = other.Score;
			}
			if (other.RankScore != 0)
			{
				this.RankScore = other.RankScore;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601AA19 RID: 109081 RVA: 0x003DCE8C File Offset: 0x003DB08C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601AA1A RID: 109082 RVA: 0x003DCE98 File Offset: 0x003DB098
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
				if (num != 8U)
				{
					if (num != 16U)
					{
						if (num != 24U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.RankScore = input.ReadInt32();
						}
					}
					else
					{
						this.Score = input.ReadInt32();
					}
				}
				else
				{
					this.Id = input.ReadInt32();
				}
			}
		}

		// Token: 0x04009AB5 RID: 39605
		private static readonly MessageParser<TowerDefenceBattleScoreInfo> _parser = new MessageParser<TowerDefenceBattleScoreInfo>(() => new TowerDefenceBattleScoreInfo());

		// Token: 0x04009AB6 RID: 39606
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009AB7 RID: 39607
		public const int IdFieldNumber = 1;

		// Token: 0x04009AB8 RID: 39608
		private int id_;

		// Token: 0x04009AB9 RID: 39609
		public const int ScoreFieldNumber = 2;

		// Token: 0x04009ABA RID: 39610
		private int score_;

		// Token: 0x04009ABB RID: 39611
		public const int RankScoreFieldNumber = 3;

		// Token: 0x04009ABC RID: 39612
		private int rankScore_;
	}
}
