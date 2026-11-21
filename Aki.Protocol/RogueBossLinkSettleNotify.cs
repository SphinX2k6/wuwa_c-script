using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F74 RID: 3956
	[NetMessage(EMessageId.RogueBossLinkSettleNotify)]
	public sealed class RogueBossLinkSettleNotify : IMessage<RogueBossLinkSettleNotify>, IMessage, IEquatable<RogueBossLinkSettleNotify>, IDeepCloneable<RogueBossLinkSettleNotify>, IBufferMessage
	{
		// Token: 0x060152D1 RID: 86737 RVA: 0x00312828 File Offset: 0x00310A28
		[NullableContext(1)]
		public static RogueBossLinkSettleNotify Create()
		{
			return new RogueBossLinkSettleNotify();
		}

		// Token: 0x1700467B RID: 18043
		// (get) Token: 0x060152D2 RID: 86738 RVA: 0x0031282F File Offset: 0x00310A2F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700467C RID: 18044
		// (get) Token: 0x060152D3 RID: 86739 RVA: 0x00312832 File Offset: 0x00310A32
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueBossLinkSettleNotify.Descriptor;
			}
		}

		// Token: 0x060152D4 RID: 86740 RVA: 0x00312839 File Offset: 0x00310A39
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueBossLinkSettleNotify()
		{
		}

		// Token: 0x060152D5 RID: 86741 RVA: 0x00312844 File Offset: 0x00310A44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueBossLinkSettleNotify(RogueBossLinkSettleNotify other) : this()
		{
			this.isSucc_ = other.isSucc_;
			this.totalScore_ = other.totalScore_;
			this.timeScore_ = other.timeScore_;
			this.lifeScore_ = other.lifeScore_;
			this.stepScore_ = other.stepScore_;
			this.isNewRecord_ = other.isNewRecord_;
			this.historyTotalScore_ = other.historyTotalScore_;
			this.costTime_ = other.costTime_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060152D6 RID: 86742 RVA: 0x003128C8 File Offset: 0x00310AC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueBossLinkSettleNotify Clone()
		{
			return new RogueBossLinkSettleNotify(this);
		}

		// Token: 0x1700467D RID: 18045
		// (get) Token: 0x060152D7 RID: 86743 RVA: 0x003128D0 File Offset: 0x00310AD0
		// (set) Token: 0x060152D8 RID: 86744 RVA: 0x003128D8 File Offset: 0x00310AD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsSucc
		{
			get
			{
				return this.isSucc_;
			}
			set
			{
				this.isSucc_ = value;
			}
		}

		// Token: 0x1700467E RID: 18046
		// (get) Token: 0x060152D9 RID: 86745 RVA: 0x003128E1 File Offset: 0x00310AE1
		// (set) Token: 0x060152DA RID: 86746 RVA: 0x003128E9 File Offset: 0x00310AE9
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

		// Token: 0x1700467F RID: 18047
		// (get) Token: 0x060152DB RID: 86747 RVA: 0x003128F2 File Offset: 0x00310AF2
		// (set) Token: 0x060152DC RID: 86748 RVA: 0x003128FA File Offset: 0x00310AFA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TimeScore
		{
			get
			{
				return this.timeScore_;
			}
			set
			{
				this.timeScore_ = value;
			}
		}

		// Token: 0x17004680 RID: 18048
		// (get) Token: 0x060152DD RID: 86749 RVA: 0x00312903 File Offset: 0x00310B03
		// (set) Token: 0x060152DE RID: 86750 RVA: 0x0031290B File Offset: 0x00310B0B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int LifeScore
		{
			get
			{
				return this.lifeScore_;
			}
			set
			{
				this.lifeScore_ = value;
			}
		}

		// Token: 0x17004681 RID: 18049
		// (get) Token: 0x060152DF RID: 86751 RVA: 0x00312914 File Offset: 0x00310B14
		// (set) Token: 0x060152E0 RID: 86752 RVA: 0x0031291C File Offset: 0x00310B1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int StepScore
		{
			get
			{
				return this.stepScore_;
			}
			set
			{
				this.stepScore_ = value;
			}
		}

		// Token: 0x17004682 RID: 18050
		// (get) Token: 0x060152E1 RID: 86753 RVA: 0x00312925 File Offset: 0x00310B25
		// (set) Token: 0x060152E2 RID: 86754 RVA: 0x0031292D File Offset: 0x00310B2D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsNewRecord
		{
			get
			{
				return this.isNewRecord_;
			}
			set
			{
				this.isNewRecord_ = value;
			}
		}

		// Token: 0x17004683 RID: 18051
		// (get) Token: 0x060152E3 RID: 86755 RVA: 0x00312936 File Offset: 0x00310B36
		// (set) Token: 0x060152E4 RID: 86756 RVA: 0x0031293E File Offset: 0x00310B3E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int HistoryTotalScore
		{
			get
			{
				return this.historyTotalScore_;
			}
			set
			{
				this.historyTotalScore_ = value;
			}
		}

		// Token: 0x17004684 RID: 18052
		// (get) Token: 0x060152E5 RID: 86757 RVA: 0x00312947 File Offset: 0x00310B47
		// (set) Token: 0x060152E6 RID: 86758 RVA: 0x0031294F File Offset: 0x00310B4F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CostTime
		{
			get
			{
				return this.costTime_;
			}
			set
			{
				this.costTime_ = value;
			}
		}

		// Token: 0x060152E7 RID: 86759 RVA: 0x00312958 File Offset: 0x00310B58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueBossLinkSettleNotify);
		}

		// Token: 0x060152E8 RID: 86760 RVA: 0x00312968 File Offset: 0x00310B68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueBossLinkSettleNotify other)
		{
			return other != null && (other == this || (this.IsSucc == other.IsSucc && this.TotalScore == other.TotalScore && this.TimeScore == other.TimeScore && this.LifeScore == other.LifeScore && this.StepScore == other.StepScore && this.IsNewRecord == other.IsNewRecord && this.HistoryTotalScore == other.HistoryTotalScore && this.CostTime == other.CostTime && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060152E9 RID: 86761 RVA: 0x00312A14 File Offset: 0x00310C14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.IsSucc)
			{
				num ^= this.IsSucc.GetHashCode();
			}
			if (this.TotalScore != 0)
			{
				num ^= this.TotalScore.GetHashCode();
			}
			if (this.TimeScore != 0)
			{
				num ^= this.TimeScore.GetHashCode();
			}
			if (this.LifeScore != 0)
			{
				num ^= this.LifeScore.GetHashCode();
			}
			if (this.StepScore != 0)
			{
				num ^= this.StepScore.GetHashCode();
			}
			if (this.IsNewRecord)
			{
				num ^= this.IsNewRecord.GetHashCode();
			}
			if (this.HistoryTotalScore != 0)
			{
				num ^= this.HistoryTotalScore.GetHashCode();
			}
			if (this.CostTime != 0)
			{
				num ^= this.CostTime.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060152EA RID: 86762 RVA: 0x00312B02 File Offset: 0x00310D02
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060152EB RID: 86763 RVA: 0x00312B0F File Offset: 0x00310D0F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060152EC RID: 86764 RVA: 0x00312B18 File Offset: 0x00310D18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TimeScore != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.TimeScore);
			}
			if (this.HistoryTotalScore != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.HistoryTotalScore);
			}
			if (this.TotalScore != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.TotalScore);
			}
			if (this.IsNewRecord)
			{
				output.WriteRawTag(40);
				output.WriteBool(this.IsNewRecord);
			}
			if (this.IsSucc)
			{
				output.WriteRawTag(72);
				output.WriteBool(this.IsSucc);
			}
			if (this.LifeScore != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.LifeScore);
			}
			if (this.StepScore != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.StepScore);
			}
			if (this.CostTime != 0)
			{
				output.WriteRawTag(120);
				output.WriteInt32(this.CostTime);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060152ED RID: 86765 RVA: 0x00312C18 File Offset: 0x00310E18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.IsSucc)
			{
				num += 2;
			}
			if (this.TotalScore != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TotalScore);
			}
			if (this.TimeScore != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TimeScore);
			}
			if (this.LifeScore != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.LifeScore);
			}
			if (this.StepScore != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.StepScore);
			}
			if (this.IsNewRecord)
			{
				num += 2;
			}
			if (this.HistoryTotalScore != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.HistoryTotalScore);
			}
			if (this.CostTime != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CostTime);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060152EE RID: 86766 RVA: 0x00312CE8 File Offset: 0x00310EE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueBossLinkSettleNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.IsSucc)
			{
				this.IsSucc = other.IsSucc;
			}
			if (other.TotalScore != 0)
			{
				this.TotalScore = other.TotalScore;
			}
			if (other.TimeScore != 0)
			{
				this.TimeScore = other.TimeScore;
			}
			if (other.LifeScore != 0)
			{
				this.LifeScore = other.LifeScore;
			}
			if (other.StepScore != 0)
			{
				this.StepScore = other.StepScore;
			}
			if (other.IsNewRecord)
			{
				this.IsNewRecord = other.IsNewRecord;
			}
			if (other.HistoryTotalScore != 0)
			{
				this.HistoryTotalScore = other.HistoryTotalScore;
			}
			if (other.CostTime != 0)
			{
				this.CostTime = other.CostTime;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060152EF RID: 86767 RVA: 0x00312DB0 File Offset: 0x00310FB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060152F0 RID: 86768 RVA: 0x00312DBC File Offset: 0x00310FBC
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
				if (num <= 40U)
				{
					if (num <= 24U)
					{
						if (num == 8U)
						{
							this.TimeScore = input.ReadInt32();
							continue;
						}
						if (num == 24U)
						{
							this.HistoryTotalScore = input.ReadInt32();
							continue;
						}
					}
					else
					{
						if (num == 32U)
						{
							this.TotalScore = input.ReadInt32();
							continue;
						}
						if (num == 40U)
						{
							this.IsNewRecord = input.ReadBool();
							continue;
						}
					}
				}
				else if (num <= 80U)
				{
					if (num == 72U)
					{
						this.IsSucc = input.ReadBool();
						continue;
					}
					if (num == 80U)
					{
						this.LifeScore = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 88U)
					{
						this.StepScore = input.ReadInt32();
						continue;
					}
					if (num == 120U)
					{
						this.CostTime = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04007FC8 RID: 32712
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007FC9 RID: 32713
		public const int IsSuccFieldNumber = 9;

		// Token: 0x04007FCA RID: 32714
		private bool isSucc_;

		// Token: 0x04007FCB RID: 32715
		public const int TotalScoreFieldNumber = 4;

		// Token: 0x04007FCC RID: 32716
		private int totalScore_;

		// Token: 0x04007FCD RID: 32717
		public const int TimeScoreFieldNumber = 1;

		// Token: 0x04007FCE RID: 32718
		private int timeScore_;

		// Token: 0x04007FCF RID: 32719
		public const int LifeScoreFieldNumber = 10;

		// Token: 0x04007FD0 RID: 32720
		private int lifeScore_;

		// Token: 0x04007FD1 RID: 32721
		public const int StepScoreFieldNumber = 11;

		// Token: 0x04007FD2 RID: 32722
		private int stepScore_;

		// Token: 0x04007FD3 RID: 32723
		public const int IsNewRecordFieldNumber = 5;

		// Token: 0x04007FD4 RID: 32724
		private bool isNewRecord_;

		// Token: 0x04007FD5 RID: 32725
		public const int HistoryTotalScoreFieldNumber = 3;

		// Token: 0x04007FD6 RID: 32726
		private int historyTotalScore_;

		// Token: 0x04007FD7 RID: 32727
		public const int CostTimeFieldNumber = 15;

		// Token: 0x04007FD8 RID: 32728
		private int costTime_;
	}
}
