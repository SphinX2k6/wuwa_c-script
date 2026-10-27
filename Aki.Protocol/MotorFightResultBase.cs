using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A5D RID: 2653
	public sealed class MotorFightResultBase : IMessage<MotorFightResultBase>, IMessage, IEquatable<MotorFightResultBase>, IDeepCloneable<MotorFightResultBase>, IBufferMessage
	{
		// Token: 0x0600E765 RID: 59237 RVA: 0x0021CC1B File Offset: 0x0021AE1B
		[NullableContext(1)]
		public static MotorFightResultBase Create()
		{
			return new MotorFightResultBase();
		}

		// Token: 0x17002EEB RID: 12011
		// (get) Token: 0x0600E766 RID: 59238 RVA: 0x0021CC22 File Offset: 0x0021AE22
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002EEC RID: 12012
		// (get) Token: 0x0600E767 RID: 59239 RVA: 0x0021CC25 File Offset: 0x0021AE25
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorFightResultBase.Descriptor;
			}
		}

		// Token: 0x0600E768 RID: 59240 RVA: 0x0021CC2C File Offset: 0x0021AE2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightResultBase()
		{
		}

		// Token: 0x0600E769 RID: 59241 RVA: 0x0021CC40 File Offset: 0x0021AE40
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

		// Token: 0x0600E76A RID: 59242 RVA: 0x0021CCD9 File Offset: 0x0021AED9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightResultBase Clone()
		{
			return new MotorFightResultBase(this);
		}

		// Token: 0x17002EED RID: 12013
		// (get) Token: 0x0600E76B RID: 59243 RVA: 0x0021CCE1 File Offset: 0x0021AEE1
		// (set) Token: 0x0600E76C RID: 59244 RVA: 0x0021CCE9 File Offset: 0x0021AEE9
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

		// Token: 0x17002EEE RID: 12014
		// (get) Token: 0x0600E76D RID: 59245 RVA: 0x0021CCF2 File Offset: 0x0021AEF2
		// (set) Token: 0x0600E76E RID: 59246 RVA: 0x0021CCFA File Offset: 0x0021AEFA
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

		// Token: 0x17002EEF RID: 12015
		// (get) Token: 0x0600E76F RID: 59247 RVA: 0x0021CD03 File Offset: 0x0021AF03
		// (set) Token: 0x0600E770 RID: 59248 RVA: 0x0021CD0B File Offset: 0x0021AF0B
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

		// Token: 0x17002EF0 RID: 12016
		// (get) Token: 0x0600E771 RID: 59249 RVA: 0x0021CD14 File Offset: 0x0021AF14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<MotorFightCollectItemInfo> Items
		{
			get
			{
				return this.items_;
			}
		}

		// Token: 0x17002EF1 RID: 12017
		// (get) Token: 0x0600E772 RID: 59250 RVA: 0x0021CD1C File Offset: 0x0021AF1C
		// (set) Token: 0x0600E773 RID: 59251 RVA: 0x0021CD24 File Offset: 0x0021AF24
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

		// Token: 0x17002EF2 RID: 12018
		// (get) Token: 0x0600E774 RID: 59252 RVA: 0x0021CD2D File Offset: 0x0021AF2D
		// (set) Token: 0x0600E775 RID: 59253 RVA: 0x0021CD35 File Offset: 0x0021AF35
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

		// Token: 0x17002EF3 RID: 12019
		// (get) Token: 0x0600E776 RID: 59254 RVA: 0x0021CD3E File Offset: 0x0021AF3E
		// (set) Token: 0x0600E777 RID: 59255 RVA: 0x0021CD46 File Offset: 0x0021AF46
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

		// Token: 0x17002EF4 RID: 12020
		// (get) Token: 0x0600E778 RID: 59256 RVA: 0x0021CD4F File Offset: 0x0021AF4F
		// (set) Token: 0x0600E779 RID: 59257 RVA: 0x0021CD57 File Offset: 0x0021AF57
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

		// Token: 0x0600E77A RID: 59258 RVA: 0x0021CD60 File Offset: 0x0021AF60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorFightResultBase);
		}

		// Token: 0x0600E77B RID: 59259 RVA: 0x0021CD70 File Offset: 0x0021AF70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorFightResultBase other)
		{
			return other != null && (other == this || (this.LevelId == other.LevelId && this.PassedWaveNum == other.PassedWaveNum && this.RoleId == other.RoleId && this.items_.Equals(other.items_) && this.SelectedBuffGateCount == other.SelectedBuffGateCount && this.TotalScore == other.TotalScore && object.Equals(this.ScoreDetail, other.ScoreDetail) && this.KillMonsterCount == other.KillMonsterCount && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E77C RID: 59260 RVA: 0x0021CE24 File Offset: 0x0021B024
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

		// Token: 0x0600E77D RID: 59261 RVA: 0x0021CF04 File Offset: 0x0021B104
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600E77E RID: 59262 RVA: 0x0021CF11 File Offset: 0x0021B111
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E77F RID: 59263 RVA: 0x0021CF1C File Offset: 0x0021B11C
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

		// Token: 0x0600E780 RID: 59264 RVA: 0x0021D014 File Offset: 0x0021B214
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

		// Token: 0x0600E781 RID: 59265 RVA: 0x0021D0F8 File Offset: 0x0021B2F8
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

		// Token: 0x0600E782 RID: 59266 RVA: 0x0021D1D5 File Offset: 0x0021B3D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E783 RID: 59267 RVA: 0x0021D1E0 File Offset: 0x0021B3E0
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

		// Token: 0x04005E45 RID: 24133
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005E46 RID: 24134
		public const int LevelIdFieldNumber = 1;

		// Token: 0x04005E47 RID: 24135
		private int levelId_;

		// Token: 0x04005E48 RID: 24136
		public const int PassedWaveNumFieldNumber = 3;

		// Token: 0x04005E49 RID: 24137
		private int passedWaveNum_;

		// Token: 0x04005E4A RID: 24138
		public const int RoleIdFieldNumber = 4;

		// Token: 0x04005E4B RID: 24139
		private int roleId_;

		// Token: 0x04005E4C RID: 24140
		public const int ItemsFieldNumber = 5;

		// Token: 0x04005E4D RID: 24141
		private static readonly FieldCodec<MotorFightCollectItemInfo> _repeated_items_codec = FieldCodec.ForMessage<MotorFightCollectItemInfo>(42U, MotorFightCollectItemInfo.Parser);

		// Token: 0x04005E4E RID: 24142
		private readonly RepeatedField<MotorFightCollectItemInfo> items_ = new RepeatedField<MotorFightCollectItemInfo>();

		// Token: 0x04005E4F RID: 24143
		public const int SelectedBuffGateCountFieldNumber = 9;

		// Token: 0x04005E50 RID: 24144
		private int selectedBuffGateCount_;

		// Token: 0x04005E51 RID: 24145
		public const int TotalScoreFieldNumber = 6;

		// Token: 0x04005E52 RID: 24146
		private int totalScore_;

		// Token: 0x04005E53 RID: 24147
		public const int ScoreDetailFieldNumber = 7;

		// Token: 0x04005E54 RID: 24148
		private MotorFightScoreDetailPb scoreDetail_;

		// Token: 0x04005E55 RID: 24149
		public const int KillMonsterCountFieldNumber = 8;

		// Token: 0x04005E56 RID: 24150
		private int killMonsterCount_;
	}
}
