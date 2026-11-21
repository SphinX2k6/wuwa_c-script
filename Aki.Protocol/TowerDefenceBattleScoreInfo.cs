using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200140D RID: 5133
	public sealed class TowerDefenceBattleScoreInfo : IMessage<TowerDefenceBattleScoreInfo>, IMessage, IEquatable<TowerDefenceBattleScoreInfo>, IDeepCloneable<TowerDefenceBattleScoreInfo>, IBufferMessage
	{
		// Token: 0x0601B48F RID: 111759 RVA: 0x003F7E82 File Offset: 0x003F6082
		[NullableContext(1)]
		public static TowerDefenceBattleScoreInfo Create()
		{
			return new TowerDefenceBattleScoreInfo();
		}

		// Token: 0x17005C5B RID: 23643
		// (get) Token: 0x0601B490 RID: 111760 RVA: 0x003F7E89 File Offset: 0x003F6089
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<TowerDefenceBattleScoreInfo> Parser
		{
			get
			{
				return TowerDefenceBattleScoreInfo._parser;
			}
		}

		// Token: 0x17005C5C RID: 23644
		// (get) Token: 0x0601B491 RID: 111761 RVA: 0x003F7E90 File Offset: 0x003F6090
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005C5D RID: 23645
		// (get) Token: 0x0601B492 RID: 111762 RVA: 0x003F7E93 File Offset: 0x003F6093
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TowerDefenceBattleScoreInfo.Descriptor;
			}
		}

		// Token: 0x0601B493 RID: 111763 RVA: 0x003F7E9A File Offset: 0x003F609A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerDefenceBattleScoreInfo()
		{
		}

		// Token: 0x0601B494 RID: 111764 RVA: 0x003F7EA2 File Offset: 0x003F60A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerDefenceBattleScoreInfo(TowerDefenceBattleScoreInfo other) : this()
		{
			this.id_ = other.id_;
			this.score_ = other.score_;
			this.rankScore_ = other.rankScore_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601B495 RID: 111765 RVA: 0x003F7EDF File Offset: 0x003F60DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerDefenceBattleScoreInfo Clone()
		{
			return new TowerDefenceBattleScoreInfo(this);
		}

		// Token: 0x17005C5E RID: 23646
		// (get) Token: 0x0601B496 RID: 111766 RVA: 0x003F7EE7 File Offset: 0x003F60E7
		// (set) Token: 0x0601B497 RID: 111767 RVA: 0x003F7EEF File Offset: 0x003F60EF
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

		// Token: 0x17005C5F RID: 23647
		// (get) Token: 0x0601B498 RID: 111768 RVA: 0x003F7EF8 File Offset: 0x003F60F8
		// (set) Token: 0x0601B499 RID: 111769 RVA: 0x003F7F00 File Offset: 0x003F6100
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

		// Token: 0x17005C60 RID: 23648
		// (get) Token: 0x0601B49A RID: 111770 RVA: 0x003F7F09 File Offset: 0x003F6109
		// (set) Token: 0x0601B49B RID: 111771 RVA: 0x003F7F11 File Offset: 0x003F6111
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

		// Token: 0x0601B49C RID: 111772 RVA: 0x003F7F1A File Offset: 0x003F611A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TowerDefenceBattleScoreInfo);
		}

		// Token: 0x0601B49D RID: 111773 RVA: 0x003F7F28 File Offset: 0x003F6128
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TowerDefenceBattleScoreInfo other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.Score == other.Score && this.RankScore == other.RankScore && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601B49E RID: 111774 RVA: 0x003F7F84 File Offset: 0x003F6184
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

		// Token: 0x0601B49F RID: 111775 RVA: 0x003F7FF5 File Offset: 0x003F61F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601B4A0 RID: 111776 RVA: 0x003F8002 File Offset: 0x003F6202
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601B4A1 RID: 111777 RVA: 0x003F800C File Offset: 0x003F620C
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

		// Token: 0x0601B4A2 RID: 111778 RVA: 0x003F8080 File Offset: 0x003F6280
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

		// Token: 0x0601B4A3 RID: 111779 RVA: 0x003F80F0 File Offset: 0x003F62F0
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

		// Token: 0x0601B4A4 RID: 111780 RVA: 0x003F8154 File Offset: 0x003F6354
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601B4A5 RID: 111781 RVA: 0x003F8160 File Offset: 0x003F6360
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

		// Token: 0x04009EFC RID: 40700
		private static readonly MessageParser<TowerDefenceBattleScoreInfo> _parser = new MessageParser<TowerDefenceBattleScoreInfo>(() => new TowerDefenceBattleScoreInfo());

		// Token: 0x04009EFD RID: 40701
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009EFE RID: 40702
		public const int IdFieldNumber = 1;

		// Token: 0x04009EFF RID: 40703
		private int id_;

		// Token: 0x04009F00 RID: 40704
		public const int ScoreFieldNumber = 2;

		// Token: 0x04009F01 RID: 40705
		private int score_;

		// Token: 0x04009F02 RID: 40706
		public const int RankScoreFieldNumber = 3;

		// Token: 0x04009F03 RID: 40707
		private int rankScore_;
	}
}
