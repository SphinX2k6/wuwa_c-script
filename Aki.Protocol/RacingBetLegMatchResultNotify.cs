using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E2A RID: 3626
	[NetMessage(EMessageId.RacingBetLegMatchResultNotify)]
	public sealed class RacingBetLegMatchResultNotify : IMessage<RacingBetLegMatchResultNotify>, IMessage, IEquatable<RacingBetLegMatchResultNotify>, IDeepCloneable<RacingBetLegMatchResultNotify>, IBufferMessage
	{
		// Token: 0x060137DE RID: 79838 RVA: 0x002D581D File Offset: 0x002D3A1D
		[NullableContext(1)]
		public static RacingBetLegMatchResultNotify Create()
		{
			return new RacingBetLegMatchResultNotify();
		}

		// Token: 0x170040A2 RID: 16546
		// (get) Token: 0x060137DF RID: 79839 RVA: 0x002D5824 File Offset: 0x002D3A24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170040A3 RID: 16547
		// (get) Token: 0x060137E0 RID: 79840 RVA: 0x002D5827 File Offset: 0x002D3A27
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RacingBetLegMatchResultNotify.Descriptor;
			}
		}

		// Token: 0x060137E1 RID: 79841 RVA: 0x002D582E File Offset: 0x002D3A2E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetLegMatchResultNotify()
		{
		}

		// Token: 0x060137E2 RID: 79842 RVA: 0x002D5838 File Offset: 0x002D3A38
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

		// Token: 0x060137E3 RID: 79843 RVA: 0x002D58E4 File Offset: 0x002D3AE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetLegMatchResultNotify Clone()
		{
			return new RacingBetLegMatchResultNotify(this);
		}

		// Token: 0x170040A4 RID: 16548
		// (get) Token: 0x060137E4 RID: 79844 RVA: 0x002D58EC File Offset: 0x002D3AEC
		// (set) Token: 0x060137E5 RID: 79845 RVA: 0x002D58F4 File Offset: 0x002D3AF4
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

		// Token: 0x170040A5 RID: 16549
		// (get) Token: 0x060137E6 RID: 79846 RVA: 0x002D58FD File Offset: 0x002D3AFD
		// (set) Token: 0x060137E7 RID: 79847 RVA: 0x002D5905 File Offset: 0x002D3B05
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

		// Token: 0x170040A6 RID: 16550
		// (get) Token: 0x060137E8 RID: 79848 RVA: 0x002D590E File Offset: 0x002D3B0E
		// (set) Token: 0x060137E9 RID: 79849 RVA: 0x002D5916 File Offset: 0x002D3B16
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

		// Token: 0x170040A7 RID: 16551
		// (get) Token: 0x060137EA RID: 79850 RVA: 0x002D591F File Offset: 0x002D3B1F
		// (set) Token: 0x060137EB RID: 79851 RVA: 0x002D5927 File Offset: 0x002D3B27
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

		// Token: 0x170040A8 RID: 16552
		// (get) Token: 0x060137EC RID: 79852 RVA: 0x002D5930 File Offset: 0x002D3B30
		// (set) Token: 0x060137ED RID: 79853 RVA: 0x002D5938 File Offset: 0x002D3B38
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

		// Token: 0x170040A9 RID: 16553
		// (get) Token: 0x060137EE RID: 79854 RVA: 0x002D5941 File Offset: 0x002D3B41
		// (set) Token: 0x060137EF RID: 79855 RVA: 0x002D5949 File Offset: 0x002D3B49
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

		// Token: 0x170040AA RID: 16554
		// (get) Token: 0x060137F0 RID: 79856 RVA: 0x002D5952 File Offset: 0x002D3B52
		// (set) Token: 0x060137F1 RID: 79857 RVA: 0x002D595A File Offset: 0x002D3B5A
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

		// Token: 0x170040AB RID: 16555
		// (get) Token: 0x060137F2 RID: 79858 RVA: 0x002D5963 File Offset: 0x002D3B63
		// (set) Token: 0x060137F3 RID: 79859 RVA: 0x002D596B File Offset: 0x002D3B6B
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

		// Token: 0x170040AC RID: 16556
		// (get) Token: 0x060137F4 RID: 79860 RVA: 0x002D5974 File Offset: 0x002D3B74
		// (set) Token: 0x060137F5 RID: 79861 RVA: 0x002D597C File Offset: 0x002D3B7C
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

		// Token: 0x170040AD RID: 16557
		// (get) Token: 0x060137F6 RID: 79862 RVA: 0x002D5985 File Offset: 0x002D3B85
		// (set) Token: 0x060137F7 RID: 79863 RVA: 0x002D598D File Offset: 0x002D3B8D
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

		// Token: 0x060137F8 RID: 79864 RVA: 0x002D5996 File Offset: 0x002D3B96
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RacingBetLegMatchResultNotify);
		}

		// Token: 0x060137F9 RID: 79865 RVA: 0x002D59A4 File Offset: 0x002D3BA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RacingBetLegMatchResultNotify other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.ActivityId == other.ActivityId && this.LegMatchId == other.LegMatchId && this.BetDangoId == other.BetDangoId && this.BetCount == other.BetCount && this.Odds == other.Odds && this.Reward == other.Reward && this.WinnerDangoId == other.WinnerDangoId && this.BetDangoRank == other.BetDangoRank && object.Equals(this.PromoteInfo, other.PromoteInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060137FA RID: 79866 RVA: 0x002D5A74 File Offset: 0x002D3C74
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

		// Token: 0x060137FB RID: 79867 RVA: 0x002D5B97 File Offset: 0x002D3D97
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060137FC RID: 79868 RVA: 0x002D5BA4 File Offset: 0x002D3DA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060137FD RID: 79869 RVA: 0x002D5BB0 File Offset: 0x002D3DB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(16);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.ActivityId);
			}
			if (this.promoteInfo_ != null)
			{
				output.WriteRawTag(42);
				output.WriteMessage(this.PromoteInfo);
			}
			if (this.BetDangoRank != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.BetDangoRank);
			}
			if (this.Reward != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.Reward);
			}
			if (this.Odds != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.Odds);
			}
			if (this.WinnerDangoId != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.WinnerDangoId);
			}
			if (this.BetCount != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.BetCount);
			}
			if (this.LegMatchId != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.LegMatchId);
			}
			if (this.BetDangoId != 0)
			{
				output.WriteRawTag(120);
				output.WriteInt32(this.BetDangoId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060137FE RID: 79870 RVA: 0x002D5CEC File Offset: 0x002D3EEC
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

		// Token: 0x060137FF RID: 79871 RVA: 0x002D5E04 File Offset: 0x002D4004
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

		// Token: 0x06013800 RID: 79872 RVA: 0x002D5F0C File Offset: 0x002D410C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06013801 RID: 79873 RVA: 0x002D5F18 File Offset: 0x002D4118
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
					if (num <= 32U)
					{
						if (num == 16U)
						{
							this.ErrorCode = (ErrorCode)input.ReadEnum();
							continue;
						}
						if (num == 32U)
						{
							this.ActivityId = input.ReadInt32();
							continue;
						}
					}
					else
					{
						if (num == 42U)
						{
							if (this.promoteInfo_ == null)
							{
								this.PromoteInfo = new RacingBetsPromoteInfo();
							}
							input.ReadMessage(this.PromoteInfo);
							continue;
						}
						if (num == 56U)
						{
							this.BetDangoRank = input.ReadInt32();
							continue;
						}
						if (num == 72U)
						{
							this.Reward = input.ReadInt32();
							continue;
						}
					}
				}
				else if (num <= 96U)
				{
					if (num == 88U)
					{
						this.Odds = input.ReadInt32();
						continue;
					}
					if (num == 96U)
					{
						this.WinnerDangoId = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 104U)
					{
						this.BetCount = input.ReadInt32();
						continue;
					}
					if (num == 112U)
					{
						this.LegMatchId = input.ReadInt32();
						continue;
					}
					if (num == 120U)
					{
						this.BetDangoId = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040077C7 RID: 30663
		private UnknownFieldSet _unknownFields;

		// Token: 0x040077C8 RID: 30664
		public const int ErrorCodeFieldNumber = 2;

		// Token: 0x040077C9 RID: 30665
		private ErrorCode errorCode_;

		// Token: 0x040077CA RID: 30666
		public const int ActivityIdFieldNumber = 4;

		// Token: 0x040077CB RID: 30667
		private int activityId_;

		// Token: 0x040077CC RID: 30668
		public const int LegMatchIdFieldNumber = 14;

		// Token: 0x040077CD RID: 30669
		private int legMatchId_;

		// Token: 0x040077CE RID: 30670
		public const int BetDangoIdFieldNumber = 15;

		// Token: 0x040077CF RID: 30671
		private int betDangoId_;

		// Token: 0x040077D0 RID: 30672
		public const int BetCountFieldNumber = 13;

		// Token: 0x040077D1 RID: 30673
		private int betCount_;

		// Token: 0x040077D2 RID: 30674
		public const int OddsFieldNumber = 11;

		// Token: 0x040077D3 RID: 30675
		private int odds_;

		// Token: 0x040077D4 RID: 30676
		public const int RewardFieldNumber = 9;

		// Token: 0x040077D5 RID: 30677
		private int reward_;

		// Token: 0x040077D6 RID: 30678
		public const int WinnerDangoIdFieldNumber = 12;

		// Token: 0x040077D7 RID: 30679
		private int winnerDangoId_;

		// Token: 0x040077D8 RID: 30680
		public const int BetDangoRankFieldNumber = 7;

		// Token: 0x040077D9 RID: 30681
		private int betDangoRank_;

		// Token: 0x040077DA RID: 30682
		public const int PromoteInfoFieldNumber = 5;

		// Token: 0x040077DB RID: 30683
		private RacingBetsPromoteInfo promoteInfo_;
	}
}
