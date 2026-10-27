using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E65 RID: 3685
	public sealed class RacingBetsLegMatchesInfo : IMessage<RacingBetsLegMatchesInfo>, IMessage, IEquatable<RacingBetsLegMatchesInfo>, IDeepCloneable<RacingBetsLegMatchesInfo>, IBufferMessage
	{
		// Token: 0x06013CBA RID: 81082 RVA: 0x002E1C41 File Offset: 0x002DFE41
		[NullableContext(1)]
		public static RacingBetsLegMatchesInfo Create()
		{
			return new RacingBetsLegMatchesInfo();
		}

		// Token: 0x170041CB RID: 16843
		// (get) Token: 0x06013CBB RID: 81083 RVA: 0x002E1C48 File Offset: 0x002DFE48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RacingBetsLegMatchesInfo> Parser
		{
			get
			{
				return RacingBetsLegMatchesInfo._parser;
			}
		}

		// Token: 0x170041CC RID: 16844
		// (get) Token: 0x06013CBC RID: 81084 RVA: 0x002E1C4F File Offset: 0x002DFE4F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170041CD RID: 16845
		// (get) Token: 0x06013CBD RID: 81085 RVA: 0x002E1C52 File Offset: 0x002DFE52
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RacingBetsLegMatchesInfo.Descriptor;
			}
		}

		// Token: 0x06013CBE RID: 81086 RVA: 0x002E1C59 File Offset: 0x002DFE59
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsLegMatchesInfo()
		{
		}

		// Token: 0x06013CBF RID: 81087 RVA: 0x002E1C90 File Offset: 0x002DFE90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsLegMatchesInfo(RacingBetsLegMatchesInfo other) : this()
		{
			this.id_ = other.id_;
			this.dangoInfo_ = other.dangoInfo_.Clone();
			this.matchStartEndTime_ = ((other.matchStartEndTime_ != null) ? other.matchStartEndTime_.Clone() : null);
			this.gearStartEndTime_ = ((other.gearStartEndTime_ != null) ? other.gearStartEndTime_.Clone() : null);
			this.dangoRank_ = other.dangoRank_.Clone();
			this.nextOddsTime_ = other.nextOddsTime_;
			this.oddsVersion_ = other.oddsVersion_;
			this.legMatchWholeTime_ = ((other.legMatchWholeTime_ != null) ? other.legMatchWholeTime_.Clone() : null);
			this.organInfo_ = other.organInfo_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06013CC0 RID: 81088 RVA: 0x002E1D5F File Offset: 0x002DFF5F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsLegMatchesInfo Clone()
		{
			return new RacingBetsLegMatchesInfo(this);
		}

		// Token: 0x170041CE RID: 16846
		// (get) Token: 0x06013CC1 RID: 81089 RVA: 0x002E1D67 File Offset: 0x002DFF67
		// (set) Token: 0x06013CC2 RID: 81090 RVA: 0x002E1D6F File Offset: 0x002DFF6F
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

		// Token: 0x170041CF RID: 16847
		// (get) Token: 0x06013CC3 RID: 81091 RVA: 0x002E1D78 File Offset: 0x002DFF78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RacingBetsDangoInfo> DangoInfo
		{
			get
			{
				return this.dangoInfo_;
			}
		}

		// Token: 0x170041D0 RID: 16848
		// (get) Token: 0x06013CC4 RID: 81092 RVA: 0x002E1D80 File Offset: 0x002DFF80
		// (set) Token: 0x06013CC5 RID: 81093 RVA: 0x002E1D88 File Offset: 0x002DFF88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsTimeTuple MatchStartEndTime
		{
			get
			{
				return this.matchStartEndTime_;
			}
			set
			{
				this.matchStartEndTime_ = value;
			}
		}

		// Token: 0x170041D1 RID: 16849
		// (get) Token: 0x06013CC6 RID: 81094 RVA: 0x002E1D91 File Offset: 0x002DFF91
		// (set) Token: 0x06013CC7 RID: 81095 RVA: 0x002E1D99 File Offset: 0x002DFF99
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsTimeTuple GearStartEndTime
		{
			get
			{
				return this.gearStartEndTime_;
			}
			set
			{
				this.gearStartEndTime_ = value;
			}
		}

		// Token: 0x170041D2 RID: 16850
		// (get) Token: 0x06013CC8 RID: 81096 RVA: 0x002E1DA2 File Offset: 0x002DFFA2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> DangoRank
		{
			get
			{
				return this.dangoRank_;
			}
		}

		// Token: 0x170041D3 RID: 16851
		// (get) Token: 0x06013CC9 RID: 81097 RVA: 0x002E1DAA File Offset: 0x002DFFAA
		// (set) Token: 0x06013CCA RID: 81098 RVA: 0x002E1DB2 File Offset: 0x002DFFB2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long NextOddsTime
		{
			get
			{
				return this.nextOddsTime_;
			}
			set
			{
				this.nextOddsTime_ = value;
			}
		}

		// Token: 0x170041D4 RID: 16852
		// (get) Token: 0x06013CCB RID: 81099 RVA: 0x002E1DBB File Offset: 0x002DFFBB
		// (set) Token: 0x06013CCC RID: 81100 RVA: 0x002E1DC3 File Offset: 0x002DFFC3
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

		// Token: 0x170041D5 RID: 16853
		// (get) Token: 0x06013CCD RID: 81101 RVA: 0x002E1DD6 File Offset: 0x002DFFD6
		// (set) Token: 0x06013CCE RID: 81102 RVA: 0x002E1DDE File Offset: 0x002DFFDE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsTimeTuple LegMatchWholeTime
		{
			get
			{
				return this.legMatchWholeTime_;
			}
			set
			{
				this.legMatchWholeTime_ = value;
			}
		}

		// Token: 0x170041D6 RID: 16854
		// (get) Token: 0x06013CCF RID: 81103 RVA: 0x002E1DE7 File Offset: 0x002DFFE7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RacingBetsOrganInfo> OrganInfo
		{
			get
			{
				return this.organInfo_;
			}
		}

		// Token: 0x06013CD0 RID: 81104 RVA: 0x002E1DEF File Offset: 0x002DFFEF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RacingBetsLegMatchesInfo);
		}

		// Token: 0x06013CD1 RID: 81105 RVA: 0x002E1E00 File Offset: 0x002E0000
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RacingBetsLegMatchesInfo other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.dangoInfo_.Equals(other.dangoInfo_) && object.Equals(this.MatchStartEndTime, other.MatchStartEndTime) && object.Equals(this.GearStartEndTime, other.GearStartEndTime) && this.dangoRank_.Equals(other.dangoRank_) && this.NextOddsTime == other.NextOddsTime && !(this.OddsVersion != other.OddsVersion) && object.Equals(this.LegMatchWholeTime, other.LegMatchWholeTime) && this.organInfo_.Equals(other.organInfo_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06013CD2 RID: 81106 RVA: 0x002E1EDC File Offset: 0x002E00DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			num ^= this.dangoInfo_.GetHashCode();
			if (this.matchStartEndTime_ != null)
			{
				num ^= this.MatchStartEndTime.GetHashCode();
			}
			if (this.gearStartEndTime_ != null)
			{
				num ^= this.GearStartEndTime.GetHashCode();
			}
			num ^= this.dangoRank_.GetHashCode();
			if (this.NextOddsTime != 0L)
			{
				num ^= this.NextOddsTime.GetHashCode();
			}
			if (this.OddsVersion.Length != 0)
			{
				num ^= this.OddsVersion.GetHashCode();
			}
			if (this.legMatchWholeTime_ != null)
			{
				num ^= this.LegMatchWholeTime.GetHashCode();
			}
			num ^= this.organInfo_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06013CD3 RID: 81107 RVA: 0x002E1FBB File Offset: 0x002E01BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06013CD4 RID: 81108 RVA: 0x002E1FC8 File Offset: 0x002E01C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06013CD5 RID: 81109 RVA: 0x002E1FD4 File Offset: 0x002E01D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Id);
			}
			this.dangoInfo_.WriteTo(ref output, RacingBetsLegMatchesInfo._repeated_dangoInfo_codec);
			if (this.matchStartEndTime_ != null)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.MatchStartEndTime);
			}
			if (this.gearStartEndTime_ != null)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.GearStartEndTime);
			}
			this.dangoRank_.WriteTo(ref output, RacingBetsLegMatchesInfo._repeated_dangoRank_codec);
			if (this.NextOddsTime != 0L)
			{
				output.WriteRawTag(48);
				output.WriteInt64(this.NextOddsTime);
			}
			if (this.OddsVersion.Length != 0)
			{
				output.WriteRawTag(58);
				output.WriteString(this.OddsVersion);
			}
			if (this.legMatchWholeTime_ != null)
			{
				output.WriteRawTag(66);
				output.WriteMessage(this.LegMatchWholeTime);
			}
			this.organInfo_.WriteTo(ref output, RacingBetsLegMatchesInfo._repeated_organInfo_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06013CD6 RID: 81110 RVA: 0x002E20D4 File Offset: 0x002E02D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			num += this.dangoInfo_.CalculateSize(RacingBetsLegMatchesInfo._repeated_dangoInfo_codec);
			if (this.matchStartEndTime_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.MatchStartEndTime);
			}
			if (this.gearStartEndTime_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.GearStartEndTime);
			}
			num += this.dangoRank_.CalculateSize(RacingBetsLegMatchesInfo._repeated_dangoRank_codec);
			if (this.NextOddsTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.NextOddsTime);
			}
			if (this.OddsVersion.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.OddsVersion);
			}
			if (this.legMatchWholeTime_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.LegMatchWholeTime);
			}
			num += this.organInfo_.CalculateSize(RacingBetsLegMatchesInfo._repeated_organInfo_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06013CD7 RID: 81111 RVA: 0x002E21C8 File Offset: 0x002E03C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RacingBetsLegMatchesInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			this.dangoInfo_.Add(other.dangoInfo_);
			if (other.matchStartEndTime_ != null)
			{
				if (this.matchStartEndTime_ == null)
				{
					this.MatchStartEndTime = new RacingBetsTimeTuple();
				}
				this.MatchStartEndTime.MergeFrom(other.MatchStartEndTime);
			}
			if (other.gearStartEndTime_ != null)
			{
				if (this.gearStartEndTime_ == null)
				{
					this.GearStartEndTime = new RacingBetsTimeTuple();
				}
				this.GearStartEndTime.MergeFrom(other.GearStartEndTime);
			}
			this.dangoRank_.Add(other.dangoRank_);
			if (other.NextOddsTime != 0L)
			{
				this.NextOddsTime = other.NextOddsTime;
			}
			if (other.OddsVersion.Length != 0)
			{
				this.OddsVersion = other.OddsVersion;
			}
			if (other.legMatchWholeTime_ != null)
			{
				if (this.legMatchWholeTime_ == null)
				{
					this.LegMatchWholeTime = new RacingBetsTimeTuple();
				}
				this.LegMatchWholeTime.MergeFrom(other.LegMatchWholeTime);
			}
			this.organInfo_.Add(other.organInfo_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06013CD8 RID: 81112 RVA: 0x002E22E8 File Offset: 0x002E04E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06013CD9 RID: 81113 RVA: 0x002E22F4 File Offset: 0x002E04F4
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
					if (num <= 18U)
					{
						if (num == 8U)
						{
							this.Id = input.ReadInt32();
							continue;
						}
						if (num == 18U)
						{
							this.dangoInfo_.AddEntriesFrom(ref input, RacingBetsLegMatchesInfo._repeated_dangoInfo_codec);
							continue;
						}
					}
					else
					{
						if (num == 26U)
						{
							if (this.matchStartEndTime_ == null)
							{
								this.MatchStartEndTime = new RacingBetsTimeTuple();
							}
							input.ReadMessage(this.MatchStartEndTime);
							continue;
						}
						if (num == 34U)
						{
							if (this.gearStartEndTime_ == null)
							{
								this.GearStartEndTime = new RacingBetsTimeTuple();
							}
							input.ReadMessage(this.GearStartEndTime);
							continue;
						}
						if (num == 40U)
						{
							goto IL_EA;
						}
					}
				}
				else if (num <= 48U)
				{
					if (num == 42U)
					{
						goto IL_EA;
					}
					if (num == 48U)
					{
						this.NextOddsTime = input.ReadInt64();
						continue;
					}
				}
				else
				{
					if (num == 58U)
					{
						this.OddsVersion = input.ReadString();
						continue;
					}
					if (num == 66U)
					{
						if (this.legMatchWholeTime_ == null)
						{
							this.LegMatchWholeTime = new RacingBetsTimeTuple();
						}
						input.ReadMessage(this.LegMatchWholeTime);
						continue;
					}
					if (num == 74U)
					{
						this.organInfo_.AddEntriesFrom(ref input, RacingBetsLegMatchesInfo._repeated_organInfo_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				continue;
				IL_EA:
				this.dangoRank_.AddEntriesFrom(ref input, RacingBetsLegMatchesInfo._repeated_dangoRank_codec);
			}
		}

		// Token: 0x04007915 RID: 30997
		private static readonly MessageParser<RacingBetsLegMatchesInfo> _parser = new MessageParser<RacingBetsLegMatchesInfo>(() => new RacingBetsLegMatchesInfo());

		// Token: 0x04007916 RID: 30998
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007917 RID: 30999
		public const int IdFieldNumber = 1;

		// Token: 0x04007918 RID: 31000
		private int id_;

		// Token: 0x04007919 RID: 31001
		public const int DangoInfoFieldNumber = 2;

		// Token: 0x0400791A RID: 31002
		private static readonly FieldCodec<RacingBetsDangoInfo> _repeated_dangoInfo_codec = FieldCodec.ForMessage<RacingBetsDangoInfo>(18U, RacingBetsDangoInfo.Parser);

		// Token: 0x0400791B RID: 31003
		private readonly RepeatedField<RacingBetsDangoInfo> dangoInfo_ = new RepeatedField<RacingBetsDangoInfo>();

		// Token: 0x0400791C RID: 31004
		public const int MatchStartEndTimeFieldNumber = 3;

		// Token: 0x0400791D RID: 31005
		private RacingBetsTimeTuple matchStartEndTime_;

		// Token: 0x0400791E RID: 31006
		public const int GearStartEndTimeFieldNumber = 4;

		// Token: 0x0400791F RID: 31007
		private RacingBetsTimeTuple gearStartEndTime_;

		// Token: 0x04007920 RID: 31008
		public const int DangoRankFieldNumber = 5;

		// Token: 0x04007921 RID: 31009
		private static readonly FieldCodec<int> _repeated_dangoRank_codec = FieldCodec.ForInt32(42U);

		// Token: 0x04007922 RID: 31010
		private readonly RepeatedField<int> dangoRank_ = new RepeatedField<int>();

		// Token: 0x04007923 RID: 31011
		public const int NextOddsTimeFieldNumber = 6;

		// Token: 0x04007924 RID: 31012
		private long nextOddsTime_;

		// Token: 0x04007925 RID: 31013
		public const int OddsVersionFieldNumber = 7;

		// Token: 0x04007926 RID: 31014
		private string oddsVersion_ = "";

		// Token: 0x04007927 RID: 31015
		public const int LegMatchWholeTimeFieldNumber = 8;

		// Token: 0x04007928 RID: 31016
		private RacingBetsTimeTuple legMatchWholeTime_;

		// Token: 0x04007929 RID: 31017
		public const int OrganInfoFieldNumber = 9;

		// Token: 0x0400792A RID: 31018
		private static readonly FieldCodec<RacingBetsOrganInfo> _repeated_organInfo_codec = FieldCodec.ForMessage<RacingBetsOrganInfo>(74U, RacingBetsOrganInfo.Parser);

		// Token: 0x0400792B RID: 31019
		private readonly RepeatedField<RacingBetsOrganInfo> organInfo_ = new RepeatedField<RacingBetsOrganInfo>();
	}
}
