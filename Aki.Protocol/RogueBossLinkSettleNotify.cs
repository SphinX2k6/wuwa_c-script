using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F84 RID: 3972
	[NetMessage(EMessageId.RogueBossLinkSettleNotify)]
	public sealed class RogueBossLinkSettleNotify : IMessage<RogueBossLinkSettleNotify>, IMessage, IEquatable<RogueBossLinkSettleNotify>, IDeepCloneable<RogueBossLinkSettleNotify>, IBufferMessage
	{
		// Token: 0x060153B6 RID: 86966 RVA: 0x00313ED8 File Offset: 0x003120D8
		[NullableContext(1)]
		public static RogueBossLinkSettleNotify Create()
		{
			return new RogueBossLinkSettleNotify();
		}

		// Token: 0x170046A5 RID: 18085
		// (get) Token: 0x060153B7 RID: 86967 RVA: 0x00313EDF File Offset: 0x003120DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170046A6 RID: 18086
		// (get) Token: 0x060153B8 RID: 86968 RVA: 0x00313EE2 File Offset: 0x003120E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueBossLinkSettleNotify.Descriptor;
			}
		}

		// Token: 0x060153B9 RID: 86969 RVA: 0x00313EE9 File Offset: 0x003120E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueBossLinkSettleNotify()
		{
		}

		// Token: 0x060153BA RID: 86970 RVA: 0x00313EF4 File Offset: 0x003120F4
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

		// Token: 0x060153BB RID: 86971 RVA: 0x00313F78 File Offset: 0x00312178
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueBossLinkSettleNotify Clone()
		{
			return new RogueBossLinkSettleNotify(this);
		}

		// Token: 0x170046A7 RID: 18087
		// (get) Token: 0x060153BC RID: 86972 RVA: 0x00313F80 File Offset: 0x00312180
		// (set) Token: 0x060153BD RID: 86973 RVA: 0x00313F88 File Offset: 0x00312188
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

		// Token: 0x170046A8 RID: 18088
		// (get) Token: 0x060153BE RID: 86974 RVA: 0x00313F91 File Offset: 0x00312191
		// (set) Token: 0x060153BF RID: 86975 RVA: 0x00313F99 File Offset: 0x00312199
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

		// Token: 0x170046A9 RID: 18089
		// (get) Token: 0x060153C0 RID: 86976 RVA: 0x00313FA2 File Offset: 0x003121A2
		// (set) Token: 0x060153C1 RID: 86977 RVA: 0x00313FAA File Offset: 0x003121AA
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

		// Token: 0x170046AA RID: 18090
		// (get) Token: 0x060153C2 RID: 86978 RVA: 0x00313FB3 File Offset: 0x003121B3
		// (set) Token: 0x060153C3 RID: 86979 RVA: 0x00313FBB File Offset: 0x003121BB
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

		// Token: 0x170046AB RID: 18091
		// (get) Token: 0x060153C4 RID: 86980 RVA: 0x00313FC4 File Offset: 0x003121C4
		// (set) Token: 0x060153C5 RID: 86981 RVA: 0x00313FCC File Offset: 0x003121CC
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

		// Token: 0x170046AC RID: 18092
		// (get) Token: 0x060153C6 RID: 86982 RVA: 0x00313FD5 File Offset: 0x003121D5
		// (set) Token: 0x060153C7 RID: 86983 RVA: 0x00313FDD File Offset: 0x003121DD
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

		// Token: 0x170046AD RID: 18093
		// (get) Token: 0x060153C8 RID: 86984 RVA: 0x00313FE6 File Offset: 0x003121E6
		// (set) Token: 0x060153C9 RID: 86985 RVA: 0x00313FEE File Offset: 0x003121EE
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

		// Token: 0x170046AE RID: 18094
		// (get) Token: 0x060153CA RID: 86986 RVA: 0x00313FF7 File Offset: 0x003121F7
		// (set) Token: 0x060153CB RID: 86987 RVA: 0x00313FFF File Offset: 0x003121FF
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

		// Token: 0x060153CC RID: 86988 RVA: 0x00314008 File Offset: 0x00312208
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueBossLinkSettleNotify);
		}

		// Token: 0x060153CD RID: 86989 RVA: 0x00314018 File Offset: 0x00312218
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueBossLinkSettleNotify other)
		{
			return other != null && (other == this || (this.IsSucc == other.IsSucc && this.TotalScore == other.TotalScore && this.TimeScore == other.TimeScore && this.LifeScore == other.LifeScore && this.StepScore == other.StepScore && this.IsNewRecord == other.IsNewRecord && this.HistoryTotalScore == other.HistoryTotalScore && this.CostTime == other.CostTime && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060153CE RID: 86990 RVA: 0x003140C4 File Offset: 0x003122C4
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

		// Token: 0x060153CF RID: 86991 RVA: 0x003141B2 File Offset: 0x003123B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060153D0 RID: 86992 RVA: 0x003141BF File Offset: 0x003123BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060153D1 RID: 86993 RVA: 0x003141C8 File Offset: 0x003123C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.LifeScore != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.LifeScore);
			}
			if (this.CostTime != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.CostTime);
			}
			if (this.StepScore != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.StepScore);
			}
			if (this.TotalScore != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.TotalScore);
			}
			if (this.IsNewRecord)
			{
				output.WriteRawTag(88);
				output.WriteBool(this.IsNewRecord);
			}
			if (this.HistoryTotalScore != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.HistoryTotalScore);
			}
			if (this.TimeScore != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.TimeScore);
			}
			if (this.IsSucc)
			{
				output.WriteRawTag(120);
				output.WriteBool(this.IsSucc);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060153D2 RID: 86994 RVA: 0x003142CC File Offset: 0x003124CC
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

		// Token: 0x060153D3 RID: 86995 RVA: 0x0031439C File Offset: 0x0031259C
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

		// Token: 0x060153D4 RID: 86996 RVA: 0x00314464 File Offset: 0x00312664
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060153D5 RID: 86997 RVA: 0x00314470 File Offset: 0x00312670
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
				if (num <= 72U)
				{
					if (num <= 40U)
					{
						if (num == 16U)
						{
							this.LifeScore = input.ReadInt32();
							continue;
						}
						if (num == 40U)
						{
							this.CostTime = input.ReadInt32();
							continue;
						}
					}
					else
					{
						if (num == 48U)
						{
							this.StepScore = input.ReadInt32();
							continue;
						}
						if (num == 72U)
						{
							this.TotalScore = input.ReadInt32();
							continue;
						}
					}
				}
				else if (num <= 96U)
				{
					if (num == 88U)
					{
						this.IsNewRecord = input.ReadBool();
						continue;
					}
					if (num == 96U)
					{
						this.HistoryTotalScore = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 112U)
					{
						this.TimeScore = input.ReadInt32();
						continue;
					}
					if (num == 120U)
					{
						this.IsSucc = input.ReadBool();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04007F9E RID: 32670
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007F9F RID: 32671
		public const int IsSuccFieldNumber = 15;

		// Token: 0x04007FA0 RID: 32672
		private bool isSucc_;

		// Token: 0x04007FA1 RID: 32673
		public const int TotalScoreFieldNumber = 9;

		// Token: 0x04007FA2 RID: 32674
		private int totalScore_;

		// Token: 0x04007FA3 RID: 32675
		public const int TimeScoreFieldNumber = 14;

		// Token: 0x04007FA4 RID: 32676
		private int timeScore_;

		// Token: 0x04007FA5 RID: 32677
		public const int LifeScoreFieldNumber = 2;

		// Token: 0x04007FA6 RID: 32678
		private int lifeScore_;

		// Token: 0x04007FA7 RID: 32679
		public const int StepScoreFieldNumber = 6;

		// Token: 0x04007FA8 RID: 32680
		private int stepScore_;

		// Token: 0x04007FA9 RID: 32681
		public const int IsNewRecordFieldNumber = 11;

		// Token: 0x04007FAA RID: 32682
		private bool isNewRecord_;

		// Token: 0x04007FAB RID: 32683
		public const int HistoryTotalScoreFieldNumber = 12;

		// Token: 0x04007FAC RID: 32684
		private int historyTotalScore_;

		// Token: 0x04007FAD RID: 32685
		public const int CostTimeFieldNumber = 5;

		// Token: 0x04007FAE RID: 32686
		private int costTime_;
	}
}
