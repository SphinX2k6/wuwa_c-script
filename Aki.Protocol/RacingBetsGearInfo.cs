using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E4B RID: 3659
	public sealed class RacingBetsGearInfo : IMessage<RacingBetsGearInfo>, IMessage, IEquatable<RacingBetsGearInfo>, IDeepCloneable<RacingBetsGearInfo>, IBufferMessage
	{
		// Token: 0x06013AB3 RID: 80563 RVA: 0x002DC570 File Offset: 0x002DA770
		[NullableContext(1)]
		public static RacingBetsGearInfo Create()
		{
			return new RacingBetsGearInfo();
		}

		// Token: 0x17004149 RID: 16713
		// (get) Token: 0x06013AB4 RID: 80564 RVA: 0x002DC577 File Offset: 0x002DA777
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RacingBetsGearInfo> Parser
		{
			get
			{
				return RacingBetsGearInfo._parser;
			}
		}

		// Token: 0x1700414A RID: 16714
		// (get) Token: 0x06013AB5 RID: 80565 RVA: 0x002DC57E File Offset: 0x002DA77E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700414B RID: 16715
		// (get) Token: 0x06013AB6 RID: 80566 RVA: 0x002DC581 File Offset: 0x002DA781
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RacingBetsGearInfo.Descriptor;
			}
		}

		// Token: 0x06013AB7 RID: 80567 RVA: 0x002DC588 File Offset: 0x002DA788
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsGearInfo()
		{
		}

		// Token: 0x06013AB8 RID: 80568 RVA: 0x002DC59C File Offset: 0x002DA79C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsGearInfo(RacingBetsGearInfo other) : this()
		{
			this.legMatchesId_ = other.legMatchesId_;
			this.dangoId_ = other.dangoId_;
			this.bettingGearId_ = other.bettingGearId_;
			this.bettingGearCash_ = other.bettingGearCash_;
			this.odds_ = other.odds_;
			this.oddsVersion_ = other.oddsVersion_;
			this.leaveCancelNum_ = other.leaveCancelNum_;
			this.oddsReward_ = other.oddsReward_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06013AB9 RID: 80569 RVA: 0x002DC620 File Offset: 0x002DA820
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsGearInfo Clone()
		{
			return new RacingBetsGearInfo(this);
		}

		// Token: 0x1700414C RID: 16716
		// (get) Token: 0x06013ABA RID: 80570 RVA: 0x002DC628 File Offset: 0x002DA828
		// (set) Token: 0x06013ABB RID: 80571 RVA: 0x002DC630 File Offset: 0x002DA830
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int LegMatchesId
		{
			get
			{
				return this.legMatchesId_;
			}
			set
			{
				this.legMatchesId_ = value;
			}
		}

		// Token: 0x1700414D RID: 16717
		// (get) Token: 0x06013ABC RID: 80572 RVA: 0x002DC639 File Offset: 0x002DA839
		// (set) Token: 0x06013ABD RID: 80573 RVA: 0x002DC641 File Offset: 0x002DA841
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int DangoId
		{
			get
			{
				return this.dangoId_;
			}
			set
			{
				this.dangoId_ = value;
			}
		}

		// Token: 0x1700414E RID: 16718
		// (get) Token: 0x06013ABE RID: 80574 RVA: 0x002DC64A File Offset: 0x002DA84A
		// (set) Token: 0x06013ABF RID: 80575 RVA: 0x002DC652 File Offset: 0x002DA852
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int BettingGearId
		{
			get
			{
				return this.bettingGearId_;
			}
			set
			{
				this.bettingGearId_ = value;
			}
		}

		// Token: 0x1700414F RID: 16719
		// (get) Token: 0x06013AC0 RID: 80576 RVA: 0x002DC65B File Offset: 0x002DA85B
		// (set) Token: 0x06013AC1 RID: 80577 RVA: 0x002DC663 File Offset: 0x002DA863
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int BettingGearCash
		{
			get
			{
				return this.bettingGearCash_;
			}
			set
			{
				this.bettingGearCash_ = value;
			}
		}

		// Token: 0x17004150 RID: 16720
		// (get) Token: 0x06013AC2 RID: 80578 RVA: 0x002DC66C File Offset: 0x002DA86C
		// (set) Token: 0x06013AC3 RID: 80579 RVA: 0x002DC674 File Offset: 0x002DA874
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

		// Token: 0x17004151 RID: 16721
		// (get) Token: 0x06013AC4 RID: 80580 RVA: 0x002DC67D File Offset: 0x002DA87D
		// (set) Token: 0x06013AC5 RID: 80581 RVA: 0x002DC685 File Offset: 0x002DA885
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string OddsVersion
		{
			get
			{
				return this.oddsVersion_;
			}
			set
			{
				this.oddsVersion_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17004152 RID: 16722
		// (get) Token: 0x06013AC6 RID: 80582 RVA: 0x002DC698 File Offset: 0x002DA898
		// (set) Token: 0x06013AC7 RID: 80583 RVA: 0x002DC6A0 File Offset: 0x002DA8A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int LeaveCancelNum
		{
			get
			{
				return this.leaveCancelNum_;
			}
			set
			{
				this.leaveCancelNum_ = value;
			}
		}

		// Token: 0x17004153 RID: 16723
		// (get) Token: 0x06013AC8 RID: 80584 RVA: 0x002DC6A9 File Offset: 0x002DA8A9
		// (set) Token: 0x06013AC9 RID: 80585 RVA: 0x002DC6B1 File Offset: 0x002DA8B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int OddsReward
		{
			get
			{
				return this.oddsReward_;
			}
			set
			{
				this.oddsReward_ = value;
			}
		}

		// Token: 0x06013ACA RID: 80586 RVA: 0x002DC6BA File Offset: 0x002DA8BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RacingBetsGearInfo);
		}

		// Token: 0x06013ACB RID: 80587 RVA: 0x002DC6C8 File Offset: 0x002DA8C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RacingBetsGearInfo other)
		{
			return other != null && (other == this || (this.LegMatchesId == other.LegMatchesId && this.DangoId == other.DangoId && this.BettingGearId == other.BettingGearId && this.BettingGearCash == other.BettingGearCash && this.Odds == other.Odds && !(this.OddsVersion != other.OddsVersion) && this.LeaveCancelNum == other.LeaveCancelNum && this.OddsReward == other.OddsReward && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06013ACC RID: 80588 RVA: 0x002DC778 File Offset: 0x002DA978
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.LegMatchesId != 0)
			{
				num ^= this.LegMatchesId.GetHashCode();
			}
			if (this.DangoId != 0)
			{
				num ^= this.DangoId.GetHashCode();
			}
			if (this.BettingGearId != 0)
			{
				num ^= this.BettingGearId.GetHashCode();
			}
			if (this.BettingGearCash != 0)
			{
				num ^= this.BettingGearCash.GetHashCode();
			}
			if (this.Odds != 0)
			{
				num ^= this.Odds.GetHashCode();
			}
			if (this.OddsVersion.Length != 0)
			{
				num ^= this.OddsVersion.GetHashCode();
			}
			if (this.LeaveCancelNum != 0)
			{
				num ^= this.LeaveCancelNum.GetHashCode();
			}
			if (this.OddsReward != 0)
			{
				num ^= this.OddsReward.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06013ACD RID: 80589 RVA: 0x002DC868 File Offset: 0x002DAA68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06013ACE RID: 80590 RVA: 0x002DC875 File Offset: 0x002DAA75
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06013ACF RID: 80591 RVA: 0x002DC880 File Offset: 0x002DAA80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.LegMatchesId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.LegMatchesId);
			}
			if (this.DangoId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.DangoId);
			}
			if (this.BettingGearId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.BettingGearId);
			}
			if (this.BettingGearCash != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.BettingGearCash);
			}
			if (this.Odds != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.Odds);
			}
			if (this.OddsVersion.Length != 0)
			{
				output.WriteRawTag(50);
				output.WriteString(this.OddsVersion);
			}
			if (this.LeaveCancelNum != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.LeaveCancelNum);
			}
			if (this.OddsReward != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.OddsReward);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06013AD0 RID: 80592 RVA: 0x002DC988 File Offset: 0x002DAB88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.LegMatchesId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.LegMatchesId);
			}
			if (this.DangoId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.DangoId);
			}
			if (this.BettingGearId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.BettingGearId);
			}
			if (this.BettingGearCash != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.BettingGearCash);
			}
			if (this.Odds != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Odds);
			}
			if (this.OddsVersion.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.OddsVersion);
			}
			if (this.LeaveCancelNum != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.LeaveCancelNum);
			}
			if (this.OddsReward != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.OddsReward);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06013AD1 RID: 80593 RVA: 0x002DCA74 File Offset: 0x002DAC74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RacingBetsGearInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.LegMatchesId != 0)
			{
				this.LegMatchesId = other.LegMatchesId;
			}
			if (other.DangoId != 0)
			{
				this.DangoId = other.DangoId;
			}
			if (other.BettingGearId != 0)
			{
				this.BettingGearId = other.BettingGearId;
			}
			if (other.BettingGearCash != 0)
			{
				this.BettingGearCash = other.BettingGearCash;
			}
			if (other.Odds != 0)
			{
				this.Odds = other.Odds;
			}
			if (other.OddsVersion.Length != 0)
			{
				this.OddsVersion = other.OddsVersion;
			}
			if (other.LeaveCancelNum != 0)
			{
				this.LeaveCancelNum = other.LeaveCancelNum;
			}
			if (other.OddsReward != 0)
			{
				this.OddsReward = other.OddsReward;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06013AD2 RID: 80594 RVA: 0x002DCB41 File Offset: 0x002DAD41
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06013AD3 RID: 80595 RVA: 0x002DCB4C File Offset: 0x002DAD4C
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
				if (num <= 32U)
				{
					if (num <= 16U)
					{
						if (num == 8U)
						{
							this.LegMatchesId = input.ReadInt32();
							continue;
						}
						if (num == 16U)
						{
							this.DangoId = input.ReadInt32();
							continue;
						}
					}
					else
					{
						if (num == 24U)
						{
							this.BettingGearId = input.ReadInt32();
							continue;
						}
						if (num == 32U)
						{
							this.BettingGearCash = input.ReadInt32();
							continue;
						}
					}
				}
				else if (num <= 50U)
				{
					if (num == 40U)
					{
						this.Odds = input.ReadInt32();
						continue;
					}
					if (num == 50U)
					{
						this.OddsVersion = input.ReadString();
						continue;
					}
				}
				else
				{
					if (num == 56U)
					{
						this.LeaveCancelNum = input.ReadInt32();
						continue;
					}
					if (num == 64U)
					{
						this.OddsReward = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040078C1 RID: 30913
		private static readonly MessageParser<RacingBetsGearInfo> _parser = new MessageParser<RacingBetsGearInfo>(() => new RacingBetsGearInfo());

		// Token: 0x040078C2 RID: 30914
		private UnknownFieldSet _unknownFields;

		// Token: 0x040078C3 RID: 30915
		public const int LegMatchesIdFieldNumber = 1;

		// Token: 0x040078C4 RID: 30916
		private int legMatchesId_;

		// Token: 0x040078C5 RID: 30917
		public const int DangoIdFieldNumber = 2;

		// Token: 0x040078C6 RID: 30918
		private int dangoId_;

		// Token: 0x040078C7 RID: 30919
		public const int BettingGearIdFieldNumber = 3;

		// Token: 0x040078C8 RID: 30920
		private int bettingGearId_;

		// Token: 0x040078C9 RID: 30921
		public const int BettingGearCashFieldNumber = 4;

		// Token: 0x040078CA RID: 30922
		private int bettingGearCash_;

		// Token: 0x040078CB RID: 30923
		public const int OddsFieldNumber = 5;

		// Token: 0x040078CC RID: 30924
		private int odds_;

		// Token: 0x040078CD RID: 30925
		public const int OddsVersionFieldNumber = 6;

		// Token: 0x040078CE RID: 30926
		private string oddsVersion_ = "";

		// Token: 0x040078CF RID: 30927
		public const int LeaveCancelNumFieldNumber = 7;

		// Token: 0x040078D0 RID: 30928
		private int leaveCancelNum_;

		// Token: 0x040078D1 RID: 30929
		public const int OddsRewardFieldNumber = 8;

		// Token: 0x040078D2 RID: 30930
		private int oddsReward_;
	}
}
