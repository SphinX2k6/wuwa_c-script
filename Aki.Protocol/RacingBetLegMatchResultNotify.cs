using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E3A RID: 3642
	[NetMessage(EMessageId.RacingBetLegMatchResultNotify)]
	public sealed class RacingBetLegMatchResultNotify : IMessage<RacingBetLegMatchResultNotify>, IMessage, IEquatable<RacingBetLegMatchResultNotify>, IDeepCloneable<RacingBetLegMatchResultNotify>, IBufferMessage
	{
		// Token: 0x060138C3 RID: 80067 RVA: 0x002D6EDD File Offset: 0x002D50DD
		[NullableContext(1)]
		public static RacingBetLegMatchResultNotify Create()
		{
			return new RacingBetLegMatchResultNotify();
		}

		// Token: 0x170040CC RID: 16588
		// (get) Token: 0x060138C4 RID: 80068 RVA: 0x002D6EE4 File Offset: 0x002D50E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170040CD RID: 16589
		// (get) Token: 0x060138C5 RID: 80069 RVA: 0x002D6EE7 File Offset: 0x002D50E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RacingBetLegMatchResultNotify.Descriptor;
			}
		}

		// Token: 0x060138C6 RID: 80070 RVA: 0x002D6EEE File Offset: 0x002D50EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetLegMatchResultNotify()
		{
		}

		// Token: 0x060138C7 RID: 80071 RVA: 0x002D6EF8 File Offset: 0x002D50F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetLegMatchResultNotify(RacingBetLegMatchResultNotify other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.activityId_ = other.activityId_;
			this.legMatchId_ = other.legMatchId_;
			this.betDangoId_ = other.betDangoId_;
			this.betCount_ = other.betCount_;
			this.odds_ = other.odds_;
			this.reward_ = other.reward_;
			this.winnerDangoId_ = other.winnerDangoId_;
			this.betDangoRank_ = other.betDangoRank_;
			this.promoteInfo_ = ((other.promoteInfo_ != null) ? other.promoteInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060138C8 RID: 80072 RVA: 0x002D6FA4 File Offset: 0x002D51A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetLegMatchResultNotify Clone()
		{
			return new RacingBetLegMatchResultNotify(this);
		}

		// Token: 0x170040CE RID: 16590
		// (get) Token: 0x060138C9 RID: 80073 RVA: 0x002D6FAC File Offset: 0x002D51AC
		// (set) Token: 0x060138CA RID: 80074 RVA: 0x002D6FB4 File Offset: 0x002D51B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode ErrorCode
		{
			get
			{
				return this.errorCode_;
			}
			set
			{
				this.errorCode_ = value;
			}
		}

		// Token: 0x170040CF RID: 16591
		// (get) Token: 0x060138CB RID: 80075 RVA: 0x002D6FBD File Offset: 0x002D51BD
		// (set) Token: 0x060138CC RID: 80076 RVA: 0x002D6FC5 File Offset: 0x002D51C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ActivityId
		{
			get
			{
				return this.activityId_;
			}
			set
			{
				this.activityId_ = value;
			}
		}

		// Token: 0x170040D0 RID: 16592
		// (get) Token: 0x060138CD RID: 80077 RVA: 0x002D6FCE File Offset: 0x002D51CE
		// (set) Token: 0x060138CE RID: 80078 RVA: 0x002D6FD6 File Offset: 0x002D51D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int LegMatchId
		{
			get
			{
				return this.legMatchId_;
			}
			set
			{
				this.legMatchId_ = value;
			}
		}

		// Token: 0x170040D1 RID: 16593
		// (get) Token: 0x060138CF RID: 80079 RVA: 0x002D6FDF File Offset: 0x002D51DF
		// (set) Token: 0x060138D0 RID: 80080 RVA: 0x002D6FE7 File Offset: 0x002D51E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int BetDangoId
		{
			get
			{
				return this.betDangoId_;
			}
			set
			{
				this.betDangoId_ = value;
			}
		}

		// Token: 0x170040D2 RID: 16594
		// (get) Token: 0x060138D1 RID: 80081 RVA: 0x002D6FF0 File Offset: 0x002D51F0
		// (set) Token: 0x060138D2 RID: 80082 RVA: 0x002D6FF8 File Offset: 0x002D51F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int BetCount
		{
			get
			{
				return this.betCount_;
			}
			set
			{
				this.betCount_ = value;
			}
		}

		// Token: 0x170040D3 RID: 16595
		// (get) Token: 0x060138D3 RID: 80083 RVA: 0x002D7001 File Offset: 0x002D5201
		// (set) Token: 0x060138D4 RID: 80084 RVA: 0x002D7009 File Offset: 0x002D5209
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Odds
		{
			get
			{
				return this.odds_;
			}
			set
			{
				this.odds_ = value;
			}
		}

		// Token: 0x170040D4 RID: 16596
		// (get) Token: 0x060138D5 RID: 80085 RVA: 0x002D7012 File Offset: 0x002D5212
		// (set) Token: 0x060138D6 RID: 80086 RVA: 0x002D701A File Offset: 0x002D521A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Reward
		{
			get
			{
				return this.reward_;
			}
			set
			{
				this.reward_ = value;
			}
		}

		// Token: 0x170040D5 RID: 16597
		// (get) Token: 0x060138D7 RID: 80087 RVA: 0x002D7023 File Offset: 0x002D5223
		// (set) Token: 0x060138D8 RID: 80088 RVA: 0x002D702B File Offset: 0x002D522B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int WinnerDangoId
		{
			get
			{
				return this.winnerDangoId_;
			}
			set
			{
				this.winnerDangoId_ = value;
			}
		}

		// Token: 0x170040D6 RID: 16598
		// (get) Token: 0x060138D9 RID: 80089 RVA: 0x002D7034 File Offset: 0x002D5234
		// (set) Token: 0x060138DA RID: 80090 RVA: 0x002D703C File Offset: 0x002D523C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int BetDangoRank
		{
			get
			{
				return this.betDangoRank_;
			}
			set
			{
				this.betDangoRank_ = value;
			}
		}

		// Token: 0x170040D7 RID: 16599
		// (get) Token: 0x060138DB RID: 80091 RVA: 0x002D7045 File Offset: 0x002D5245
		// (set) Token: 0x060138DC RID: 80092 RVA: 0x002D704D File Offset: 0x002D524D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsPromoteInfo PromoteInfo
		{
			get
			{
				return this.promoteInfo_;
			}
			set
			{
				this.promoteInfo_ = value;
			}
		}

		// Token: 0x060138DD RID: 80093 RVA: 0x002D7056 File Offset: 0x002D5256
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RacingBetLegMatchResultNotify);
		}

		// Token: 0x060138DE RID: 80094 RVA: 0x002D7064 File Offset: 0x002D5264
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RacingBetLegMatchResultNotify other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.ActivityId == other.ActivityId && this.LegMatchId == other.LegMatchId && this.BetDangoId == other.BetDangoId && this.BetCount == other.BetCount && this.Odds == other.Odds && this.Reward == other.Reward && this.WinnerDangoId == other.WinnerDangoId && this.BetDangoRank == other.BetDangoRank && object.Equals(this.PromoteInfo, other.PromoteInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060138DF RID: 80095 RVA: 0x002D7134 File Offset: 0x002D5334
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.ActivityId != 0)
			{
				num ^= this.ActivityId.GetHashCode();
			}
			if (this.LegMatchId != 0)
			{
				num ^= this.LegMatchId.GetHashCode();
			}
			if (this.BetDangoId != 0)
			{
				num ^= this.BetDangoId.GetHashCode();
			}
			if (this.BetCount != 0)
			{
				num ^= this.BetCount.GetHashCode();
			}
			if (this.Odds != 0)
			{
				num ^= this.Odds.GetHashCode();
			}
			if (this.Reward != 0)
			{
				num ^= this.Reward.GetHashCode();
			}
			if (this.WinnerDangoId != 0)
			{
				num ^= this.WinnerDangoId.GetHashCode();
			}
			if (this.BetDangoRank != 0)
			{
				num ^= this.BetDangoRank.GetHashCode();
			}
			if (this.promoteInfo_ != null)
			{
				num ^= this.PromoteInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060138E0 RID: 80096 RVA: 0x002D7257 File Offset: 0x002D5457
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060138E1 RID: 80097 RVA: 0x002D7264 File Offset: 0x002D5464
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060138E2 RID: 80098 RVA: 0x002D7270 File Offset: 0x002D5470
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.promoteInfo_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.PromoteInfo);
			}
			if (this.WinnerDangoId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.WinnerDangoId);
			}
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.ActivityId);
			}
			if (this.BetDangoRank != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.BetDangoRank);
			}
			if (this.LegMatchId != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.LegMatchId);
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(64);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.Reward != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.Reward);
			}
			if (this.Odds != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.Odds);
			}
			if (this.BetDangoId != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.BetDangoId);
			}
			if (this.BetCount != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.BetCount);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060138E3 RID: 80099 RVA: 0x002D73AC File Offset: 0x002D55AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.ActivityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActivityId);
			}
			if (this.LegMatchId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.LegMatchId);
			}
			if (this.BetDangoId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.BetDangoId);
			}
			if (this.BetCount != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.BetCount);
			}
			if (this.Odds != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Odds);
			}
			if (this.Reward != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Reward);
			}
			if (this.WinnerDangoId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.WinnerDangoId);
			}
			if (this.BetDangoRank != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.BetDangoRank);
			}
			if (this.promoteInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.PromoteInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060138E4 RID: 80100 RVA: 0x002D74C4 File Offset: 0x002D56C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RacingBetLegMatchResultNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.ActivityId != 0)
			{
				this.ActivityId = other.ActivityId;
			}
			if (other.LegMatchId != 0)
			{
				this.LegMatchId = other.LegMatchId;
			}
			if (other.BetDangoId != 0)
			{
				this.BetDangoId = other.BetDangoId;
			}
			if (other.BetCount != 0)
			{
				this.BetCount = other.BetCount;
			}
			if (other.Odds != 0)
			{
				this.Odds = other.Odds;
			}
			if (other.Reward != 0)
			{
				this.Reward = other.Reward;
			}
			if (other.WinnerDangoId != 0)
			{
				this.WinnerDangoId = other.WinnerDangoId;
			}
			if (other.BetDangoRank != 0)
			{
				this.BetDangoRank = other.BetDangoRank;
			}
			if (other.promoteInfo_ != null)
			{
				if (this.promoteInfo_ == null)
				{
					this.PromoteInfo = new RacingBetsPromoteInfo();
				}
				this.PromoteInfo.MergeFrom(other.PromoteInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060138E5 RID: 80101 RVA: 0x002D75CC File Offset: 0x002D57CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060138E6 RID: 80102 RVA: 0x002D75D8 File Offset: 0x002D57D8
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
				if (num <= 56U)
				{
					if (num <= 16U)
					{
						if (num == 10U)
						{
							if (this.promoteInfo_ == null)
							{
								this.PromoteInfo = new RacingBetsPromoteInfo();
							}
							input.ReadMessage(this.PromoteInfo);
							continue;
						}
						if (num == 16U)
						{
							this.WinnerDangoId = input.ReadInt32();
							continue;
						}
					}
					else
					{
						if (num == 24U)
						{
							this.ActivityId = input.ReadInt32();
							continue;
						}
						if (num == 48U)
						{
							this.BetDangoRank = input.ReadInt32();
							continue;
						}
						if (num == 56U)
						{
							this.LegMatchId = input.ReadInt32();
							continue;
						}
					}
				}
				else if (num <= 88U)
				{
					if (num == 64U)
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
						continue;
					}
					if (num == 88U)
					{
						this.Reward = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 96U)
					{
						this.Odds = input.ReadInt32();
						continue;
					}
					if (num == 104U)
					{
						this.BetDangoId = input.ReadInt32();
						continue;
					}
					if (num == 112U)
					{
						this.BetCount = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400779D RID: 30621
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400779E RID: 30622
		public const int ErrorCodeFieldNumber = 8;

		// Token: 0x0400779F RID: 30623
		private ErrorCode errorCode_;

		// Token: 0x040077A0 RID: 30624
		public const int ActivityIdFieldNumber = 3;

		// Token: 0x040077A1 RID: 30625
		private int activityId_;

		// Token: 0x040077A2 RID: 30626
		public const int LegMatchIdFieldNumber = 7;

		// Token: 0x040077A3 RID: 30627
		private int legMatchId_;

		// Token: 0x040077A4 RID: 30628
		public const int BetDangoIdFieldNumber = 13;

		// Token: 0x040077A5 RID: 30629
		private int betDangoId_;

		// Token: 0x040077A6 RID: 30630
		public const int BetCountFieldNumber = 14;

		// Token: 0x040077A7 RID: 30631
		private int betCount_;

		// Token: 0x040077A8 RID: 30632
		public const int OddsFieldNumber = 12;

		// Token: 0x040077A9 RID: 30633
		private int odds_;

		// Token: 0x040077AA RID: 30634
		public const int RewardFieldNumber = 11;

		// Token: 0x040077AB RID: 30635
		private int reward_;

		// Token: 0x040077AC RID: 30636
		public const int WinnerDangoIdFieldNumber = 2;

		// Token: 0x040077AD RID: 30637
		private int winnerDangoId_;

		// Token: 0x040077AE RID: 30638
		public const int BetDangoRankFieldNumber = 6;

		// Token: 0x040077AF RID: 30639
		private int betDangoRank_;

		// Token: 0x040077B0 RID: 30640
		public const int PromoteInfoFieldNumber = 1;

		// Token: 0x040077B1 RID: 30641
		private RacingBetsPromoteInfo promoteInfo_;
	}
}
