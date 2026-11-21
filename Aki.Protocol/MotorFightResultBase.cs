using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A4C RID: 2636
	public sealed class MotorFightResultBase : IMessage<MotorFightResultBase>, IMessage, IEquatable<MotorFightResultBase>, IDeepCloneable<MotorFightResultBase>, IBufferMessage
	{
		// Token: 0x0600E64B RID: 58955 RVA: 0x0021AA27 File Offset: 0x00218C27
		[NullableContext(1)]
		public static MotorFightResultBase Create()
		{
			return new MotorFightResultBase();
		}

		// Token: 0x17002EAD RID: 11949
		// (get) Token: 0x0600E64C RID: 58956 RVA: 0x0021AA2E File Offset: 0x00218C2E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002EAE RID: 11950
		// (get) Token: 0x0600E64D RID: 58957 RVA: 0x0021AA31 File Offset: 0x00218C31
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorFightResultBase.Descriptor;
			}
		}

		// Token: 0x0600E64E RID: 58958 RVA: 0x0021AA38 File Offset: 0x00218C38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightResultBase()
		{
		}

		// Token: 0x0600E64F RID: 58959 RVA: 0x0021AA4C File Offset: 0x00218C4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightResultBase(MotorFightResultBase other) : this()
		{
			this.levelId_ = other.levelId_;
			this.passedWaveNum_ = other.passedWaveNum_;
			this.roleId_ = other.roleId_;
			this.items_ = other.items_.Clone();
			this.selectedBuffGateCount_ = other.selectedBuffGateCount_;
			this.totalScore_ = other.totalScore_;
			this.scoreDetail_ = ((other.scoreDetail_ != null) ? other.scoreDetail_.Clone() : null);
			this.killMonsterCount_ = other.killMonsterCount_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E650 RID: 58960 RVA: 0x0021AAE5 File Offset: 0x00218CE5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightResultBase Clone()
		{
			return new MotorFightResultBase(this);
		}

		// Token: 0x17002EAF RID: 11951
		// (get) Token: 0x0600E651 RID: 58961 RVA: 0x0021AAED File Offset: 0x00218CED
		// (set) Token: 0x0600E652 RID: 58962 RVA: 0x0021AAF5 File Offset: 0x00218CF5
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

		// Token: 0x17002EB0 RID: 11952
		// (get) Token: 0x0600E653 RID: 58963 RVA: 0x0021AAFE File Offset: 0x00218CFE
		// (set) Token: 0x0600E654 RID: 58964 RVA: 0x0021AB06 File Offset: 0x00218D06
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int PassedWaveNum
		{
			get
			{
				return this.passedWaveNum_;
			}
			set
			{
				this.passedWaveNum_ = value;
			}
		}

		// Token: 0x17002EB1 RID: 11953
		// (get) Token: 0x0600E655 RID: 58965 RVA: 0x0021AB0F File Offset: 0x00218D0F
		// (set) Token: 0x0600E656 RID: 58966 RVA: 0x0021AB17 File Offset: 0x00218D17
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RoleId
		{
			get
			{
				return this.roleId_;
			}
			set
			{
				this.roleId_ = value;
			}
		}

		// Token: 0x17002EB2 RID: 11954
		// (get) Token: 0x0600E657 RID: 58967 RVA: 0x0021AB20 File Offset: 0x00218D20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<MotorFightCollectItemInfo> Items
		{
			get
			{
				return this.items_;
			}
		}

		// Token: 0x17002EB3 RID: 11955
		// (get) Token: 0x0600E658 RID: 58968 RVA: 0x0021AB28 File Offset: 0x00218D28
		// (set) Token: 0x0600E659 RID: 58969 RVA: 0x0021AB30 File Offset: 0x00218D30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SelectedBuffGateCount
		{
			get
			{
				return this.selectedBuffGateCount_;
			}
			set
			{
				this.selectedBuffGateCount_ = value;
			}
		}

		// Token: 0x17002EB4 RID: 11956
		// (get) Token: 0x0600E65A RID: 58970 RVA: 0x0021AB39 File Offset: 0x00218D39
		// (set) Token: 0x0600E65B RID: 58971 RVA: 0x0021AB41 File Offset: 0x00218D41
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

		// Token: 0x17002EB5 RID: 11957
		// (get) Token: 0x0600E65C RID: 58972 RVA: 0x0021AB4A File Offset: 0x00218D4A
		// (set) Token: 0x0600E65D RID: 58973 RVA: 0x0021AB52 File Offset: 0x00218D52
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightScoreDetailPb ScoreDetail
		{
			get
			{
				return this.scoreDetail_;
			}
			set
			{
				this.scoreDetail_ = value;
			}
		}

		// Token: 0x17002EB6 RID: 11958
		// (get) Token: 0x0600E65E RID: 58974 RVA: 0x0021AB5B File Offset: 0x00218D5B
		// (set) Token: 0x0600E65F RID: 58975 RVA: 0x0021AB63 File Offset: 0x00218D63
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int KillMonsterCount
		{
			get
			{
				return this.killMonsterCount_;
			}
			set
			{
				this.killMonsterCount_ = value;
			}
		}

		// Token: 0x0600E660 RID: 58976 RVA: 0x0021AB6C File Offset: 0x00218D6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorFightResultBase);
		}

		// Token: 0x0600E661 RID: 58977 RVA: 0x0021AB7C File Offset: 0x00218D7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorFightResultBase other)
		{
			return other != null && (other == this || (this.LevelId == other.LevelId && this.PassedWaveNum == other.PassedWaveNum && this.RoleId == other.RoleId && this.items_.Equals(other.items_) && this.SelectedBuffGateCount == other.SelectedBuffGateCount && this.TotalScore == other.TotalScore && object.Equals(this.ScoreDetail, other.ScoreDetail) && this.KillMonsterCount == other.KillMonsterCount && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E662 RID: 58978 RVA: 0x0021AC30 File Offset: 0x00218E30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.LevelId != 0)
			{
				num ^= this.LevelId.GetHashCode();
			}
			if (this.PassedWaveNum != 0)
			{
				num ^= this.PassedWaveNum.GetHashCode();
			}
			if (this.RoleId != 0)
			{
				num ^= this.RoleId.GetHashCode();
			}
			num ^= this.items_.GetHashCode();
			if (this.SelectedBuffGateCount != 0)
			{
				num ^= this.SelectedBuffGateCount.GetHashCode();
			}
			if (this.TotalScore != 0)
			{
				num ^= this.TotalScore.GetHashCode();
			}
			if (this.scoreDetail_ != null)
			{
				num ^= this.ScoreDetail.GetHashCode();
			}
			if (this.KillMonsterCount != 0)
			{
				num ^= this.KillMonsterCount.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600E663 RID: 58979 RVA: 0x0021AD10 File Offset: 0x00218F10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600E664 RID: 58980 RVA: 0x0021AD1D File Offset: 0x00218F1D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E665 RID: 58981 RVA: 0x0021AD28 File Offset: 0x00218F28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.LevelId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.LevelId);
			}
			if (this.PassedWaveNum != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.PassedWaveNum);
			}
			if (this.RoleId != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.RoleId);
			}
			this.items_.WriteTo(ref output, MotorFightResultBase._repeated_items_codec);
			if (this.TotalScore != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.TotalScore);
			}
			if (this.scoreDetail_ != null)
			{
				output.WriteRawTag(58);
				output.WriteMessage(this.ScoreDetail);
			}
			if (this.KillMonsterCount != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.KillMonsterCount);
			}
			if (this.SelectedBuffGateCount != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.SelectedBuffGateCount);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600E666 RID: 58982 RVA: 0x0021AE20 File Offset: 0x00219020
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.LevelId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.LevelId);
			}
			if (this.PassedWaveNum != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PassedWaveNum);
			}
			if (this.RoleId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RoleId);
			}
			num += this.items_.CalculateSize(MotorFightResultBase._repeated_items_codec);
			if (this.SelectedBuffGateCount != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SelectedBuffGateCount);
			}
			if (this.TotalScore != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TotalScore);
			}
			if (this.scoreDetail_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ScoreDetail);
			}
			if (this.KillMonsterCount != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.KillMonsterCount);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600E667 RID: 58983 RVA: 0x0021AF04 File Offset: 0x00219104
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MotorFightResultBase other)
		{
			if (other == null)
			{
				return;
			}
			if (other.LevelId != 0)
			{
				this.LevelId = other.LevelId;
			}
			if (other.PassedWaveNum != 0)
			{
				this.PassedWaveNum = other.PassedWaveNum;
			}
			if (other.RoleId != 0)
			{
				this.RoleId = other.RoleId;
			}
			this.items_.Add(other.items_);
			if (other.SelectedBuffGateCount != 0)
			{
				this.SelectedBuffGateCount = other.SelectedBuffGateCount;
			}
			if (other.TotalScore != 0)
			{
				this.TotalScore = other.TotalScore;
			}
			if (other.scoreDetail_ != null)
			{
				if (this.scoreDetail_ == null)
				{
					this.ScoreDetail = new MotorFightScoreDetailPb();
				}
				this.ScoreDetail.MergeFrom(other.ScoreDetail);
			}
			if (other.KillMonsterCount != 0)
			{
				this.KillMonsterCount = other.KillMonsterCount;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600E668 RID: 58984 RVA: 0x0021AFE1 File Offset: 0x002191E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E669 RID: 58985 RVA: 0x0021AFEC File Offset: 0x002191EC
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
				if (num <= 42U)
				{
					if (num <= 24U)
					{
						if (num == 8U)
						{
							this.LevelId = input.ReadInt32();
							continue;
						}
						if (num == 24U)
						{
							this.PassedWaveNum = input.ReadInt32();
							continue;
						}
					}
					else
					{
						if (num == 32U)
						{
							this.RoleId = input.ReadInt32();
							continue;
						}
						if (num == 42U)
						{
							this.items_.AddEntriesFrom(ref input, MotorFightResultBase._repeated_items_codec);
							continue;
						}
					}
				}
				else if (num <= 58U)
				{
					if (num == 48U)
					{
						this.TotalScore = input.ReadInt32();
						continue;
					}
					if (num == 58U)
					{
						if (this.scoreDetail_ == null)
						{
							this.ScoreDetail = new MotorFightScoreDetailPb();
						}
						input.ReadMessage(this.ScoreDetail);
						continue;
					}
				}
				else
				{
					if (num == 64U)
					{
						this.KillMonsterCount = input.ReadInt32();
						continue;
					}
					if (num == 72U)
					{
						this.SelectedBuffGateCount = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04005E4E RID: 24142
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005E4F RID: 24143
		public const int LevelIdFieldNumber = 1;

		// Token: 0x04005E50 RID: 24144
		private int levelId_;

		// Token: 0x04005E51 RID: 24145
		public const int PassedWaveNumFieldNumber = 3;

		// Token: 0x04005E52 RID: 24146
		private int passedWaveNum_;

		// Token: 0x04005E53 RID: 24147
		public const int RoleIdFieldNumber = 4;

		// Token: 0x04005E54 RID: 24148
		private int roleId_;

		// Token: 0x04005E55 RID: 24149
		public const int ItemsFieldNumber = 5;

		// Token: 0x04005E56 RID: 24150
		private static readonly FieldCodec<MotorFightCollectItemInfo> _repeated_items_codec = FieldCodec.ForMessage<MotorFightCollectItemInfo>(42U, MotorFightCollectItemInfo.Parser);

		// Token: 0x04005E57 RID: 24151
		private readonly RepeatedField<MotorFightCollectItemInfo> items_ = new RepeatedField<MotorFightCollectItemInfo>();

		// Token: 0x04005E58 RID: 24152
		public const int SelectedBuffGateCountFieldNumber = 9;

		// Token: 0x04005E59 RID: 24153
		private int selectedBuffGateCount_;

		// Token: 0x04005E5A RID: 24154
		public const int TotalScoreFieldNumber = 6;

		// Token: 0x04005E5B RID: 24155
		private int totalScore_;

		// Token: 0x04005E5C RID: 24156
		public const int ScoreDetailFieldNumber = 7;

		// Token: 0x04005E5D RID: 24157
		private MotorFightScoreDetailPb scoreDetail_;

		// Token: 0x04005E5E RID: 24158
		public const int KillMonsterCountFieldNumber = 8;

		// Token: 0x04005E5F RID: 24159
		private int killMonsterCount_;
	}
}
