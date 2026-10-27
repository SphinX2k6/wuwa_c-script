using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E5B RID: 3675
	public sealed class RacingBetsGearInfo : IMessage<RacingBetsGearInfo>, IMessage, IEquatable<RacingBetsGearInfo>, IDeepCloneable<RacingBetsGearInfo>, IBufferMessage
	{
		// Token: 0x06013B98 RID: 80792 RVA: 0x002DDC2C File Offset: 0x002DBE2C
		[NullableContext(1)]
		public static RacingBetsGearInfo Create()
		{
			return new RacingBetsGearInfo();
		}

		// Token: 0x17004173 RID: 16755
		// (get) Token: 0x06013B99 RID: 80793 RVA: 0x002DDC33 File Offset: 0x002DBE33
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RacingBetsGearInfo> Parser
		{
			get
			{
				return RacingBetsGearInfo._parser;
			}
		}

		// Token: 0x17004174 RID: 16756
		// (get) Token: 0x06013B9A RID: 80794 RVA: 0x002DDC3A File Offset: 0x002DBE3A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004175 RID: 16757
		// (get) Token: 0x06013B9B RID: 80795 RVA: 0x002DDC3D File Offset: 0x002DBE3D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RacingBetsGearInfo.Descriptor;
			}
		}

		// Token: 0x06013B9C RID: 80796 RVA: 0x002DDC44 File Offset: 0x002DBE44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsGearInfo()
		{
		}

		// Token: 0x06013B9D RID: 80797 RVA: 0x002DDC58 File Offset: 0x002DBE58
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

		// Token: 0x06013B9E RID: 80798 RVA: 0x002DDCDC File Offset: 0x002DBEDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsGearInfo Clone()
		{
			return new RacingBetsGearInfo(this);
		}

		// Token: 0x17004176 RID: 16758
		// (get) Token: 0x06013B9F RID: 80799 RVA: 0x002DDCE4 File Offset: 0x002DBEE4
		// (set) Token: 0x06013BA0 RID: 80800 RVA: 0x002DDCEC File Offset: 0x002DBEEC
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

		// Token: 0x17004177 RID: 16759
		// (get) Token: 0x06013BA1 RID: 80801 RVA: 0x002DDCF5 File Offset: 0x002DBEF5
		// (set) Token: 0x06013BA2 RID: 80802 RVA: 0x002DDCFD File Offset: 0x002DBEFD
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

		// Token: 0x17004178 RID: 16760
		// (get) Token: 0x06013BA3 RID: 80803 RVA: 0x002DDD06 File Offset: 0x002DBF06
		// (set) Token: 0x06013BA4 RID: 80804 RVA: 0x002DDD0E File Offset: 0x002DBF0E
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

		// Token: 0x17004179 RID: 16761
		// (get) Token: 0x06013BA5 RID: 80805 RVA: 0x002DDD17 File Offset: 0x002DBF17
		// (set) Token: 0x06013BA6 RID: 80806 RVA: 0x002DDD1F File Offset: 0x002DBF1F
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

		// Token: 0x1700417A RID: 16762
		// (get) Token: 0x06013BA7 RID: 80807 RVA: 0x002DDD28 File Offset: 0x002DBF28
		// (set) Token: 0x06013BA8 RID: 80808 RVA: 0x002DDD30 File Offset: 0x002DBF30
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

		// Token: 0x1700417B RID: 16763
		// (get) Token: 0x06013BA9 RID: 80809 RVA: 0x002DDD39 File Offset: 0x002DBF39
		// (set) Token: 0x06013BAA RID: 80810 RVA: 0x002DDD41 File Offset: 0x002DBF41
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

		// Token: 0x1700417C RID: 16764
		// (get) Token: 0x06013BAB RID: 80811 RVA: 0x002DDD54 File Offset: 0x002DBF54
		// (set) Token: 0x06013BAC RID: 80812 RVA: 0x002DDD5C File Offset: 0x002DBF5C
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

		// Token: 0x1700417D RID: 16765
		// (get) Token: 0x06013BAD RID: 80813 RVA: 0x002DDD65 File Offset: 0x002DBF65
		// (set) Token: 0x06013BAE RID: 80814 RVA: 0x002DDD6D File Offset: 0x002DBF6D
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

		// Token: 0x06013BAF RID: 80815 RVA: 0x002DDD76 File Offset: 0x002DBF76
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RacingBetsGearInfo);
		}

		// Token: 0x06013BB0 RID: 80816 RVA: 0x002DDD84 File Offset: 0x002DBF84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RacingBetsGearInfo other)
		{
			return other != null && (other == this || (this.LegMatchesId == other.LegMatchesId && this.DangoId == other.DangoId && this.BettingGearId == other.BettingGearId && this.BettingGearCash == other.BettingGearCash && this.Odds == other.Odds && !(this.OddsVersion != other.OddsVersion) && this.LeaveCancelNum == other.LeaveCancelNum && this.OddsReward == other.OddsReward && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06013BB1 RID: 80817 RVA: 0x002DDE34 File Offset: 0x002DC034
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

		// Token: 0x06013BB2 RID: 80818 RVA: 0x002DDF24 File Offset: 0x002DC124
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06013BB3 RID: 80819 RVA: 0x002DDF31 File Offset: 0x002DC131
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06013BB4 RID: 80820 RVA: 0x002DDF3C File Offset: 0x002DC13C
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

		// Token: 0x06013BB5 RID: 80821 RVA: 0x002DE044 File Offset: 0x002DC244
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

		// Token: 0x06013BB6 RID: 80822 RVA: 0x002DE130 File Offset: 0x002DC330
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

		// Token: 0x06013BB7 RID: 80823 RVA: 0x002DE1FD File Offset: 0x002DC3FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06013BB8 RID: 80824 RVA: 0x002DE208 File Offset: 0x002DC408
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

		// Token: 0x04007897 RID: 30871
		private static readonly MessageParser<RacingBetsGearInfo> _parser = new MessageParser<RacingBetsGearInfo>(() => new RacingBetsGearInfo());

		// Token: 0x04007898 RID: 30872
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007899 RID: 30873
		public const int LegMatchesIdFieldNumber = 1;

		// Token: 0x0400789A RID: 30874
		private int legMatchesId_;

		// Token: 0x0400789B RID: 30875
		public const int DangoIdFieldNumber = 2;

		// Token: 0x0400789C RID: 30876
		private int dangoId_;

		// Token: 0x0400789D RID: 30877
		public const int BettingGearIdFieldNumber = 3;

		// Token: 0x0400789E RID: 30878
		private int bettingGearId_;

		// Token: 0x0400789F RID: 30879
		public const int BettingGearCashFieldNumber = 4;

		// Token: 0x040078A0 RID: 30880
		private int bettingGearCash_;

		// Token: 0x040078A1 RID: 30881
		public const int OddsFieldNumber = 5;

		// Token: 0x040078A2 RID: 30882
		private int odds_;

		// Token: 0x040078A3 RID: 30883
		public const int OddsVersionFieldNumber = 6;

		// Token: 0x040078A4 RID: 30884
		private string oddsVersion_ = "";

		// Token: 0x040078A5 RID: 30885
		public const int LeaveCancelNumFieldNumber = 7;

		// Token: 0x040078A6 RID: 30886
		private int leaveCancelNum_;

		// Token: 0x040078A7 RID: 30887
		public const int OddsRewardFieldNumber = 8;

		// Token: 0x040078A8 RID: 30888
		private int oddsReward_;
	}
}
