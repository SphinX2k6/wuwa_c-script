using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E55 RID: 3669
	public sealed class RacingBetsLegMatchesInfo : IMessage<RacingBetsLegMatchesInfo>, IMessage, IEquatable<RacingBetsLegMatchesInfo>, IDeepCloneable<RacingBetsLegMatchesInfo>, IBufferMessage
	{
		// Token: 0x06013BD5 RID: 80853 RVA: 0x002E0585 File Offset: 0x002DE785
		[NullableContext(1)]
		public static RacingBetsLegMatchesInfo Create()
		{
			return new RacingBetsLegMatchesInfo();
		}

		// Token: 0x170041A1 RID: 16801
		// (get) Token: 0x06013BD6 RID: 80854 RVA: 0x002E058C File Offset: 0x002DE78C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RacingBetsLegMatchesInfo> Parser
		{
			get
			{
				return RacingBetsLegMatchesInfo._parser;
			}
		}

		// Token: 0x170041A2 RID: 16802
		// (get) Token: 0x06013BD7 RID: 80855 RVA: 0x002E0593 File Offset: 0x002DE793
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170041A3 RID: 16803
		// (get) Token: 0x06013BD8 RID: 80856 RVA: 0x002E0596 File Offset: 0x002DE796
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RacingBetsLegMatchesInfo.Descriptor;
			}
		}

		// Token: 0x06013BD9 RID: 80857 RVA: 0x002E059D File Offset: 0x002DE79D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsLegMatchesInfo()
		{
		}

		// Token: 0x06013BDA RID: 80858 RVA: 0x002E05D4 File Offset: 0x002DE7D4
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

		// Token: 0x06013BDB RID: 80859 RVA: 0x002E06A3 File Offset: 0x002DE8A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsLegMatchesInfo Clone()
		{
			return new RacingBetsLegMatchesInfo(this);
		}

		// Token: 0x170041A4 RID: 16804
		// (get) Token: 0x06013BDC RID: 80860 RVA: 0x002E06AB File Offset: 0x002DE8AB
		// (set) Token: 0x06013BDD RID: 80861 RVA: 0x002E06B3 File Offset: 0x002DE8B3
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

		// Token: 0x170041A5 RID: 16805
		// (get) Token: 0x06013BDE RID: 80862 RVA: 0x002E06BC File Offset: 0x002DE8BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RacingBetsDangoInfo> DangoInfo
		{
			get
			{
				return this.dangoInfo_;
			}
		}

		// Token: 0x170041A6 RID: 16806
		// (get) Token: 0x06013BDF RID: 80863 RVA: 0x002E06C4 File Offset: 0x002DE8C4
		// (set) Token: 0x06013BE0 RID: 80864 RVA: 0x002E06CC File Offset: 0x002DE8CC
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

		// Token: 0x170041A7 RID: 16807
		// (get) Token: 0x06013BE1 RID: 80865 RVA: 0x002E06D5 File Offset: 0x002DE8D5
		// (set) Token: 0x06013BE2 RID: 80866 RVA: 0x002E06DD File Offset: 0x002DE8DD
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

		// Token: 0x170041A8 RID: 16808
		// (get) Token: 0x06013BE3 RID: 80867 RVA: 0x002E06E6 File Offset: 0x002DE8E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> DangoRank
		{
			get
			{
				return this.dangoRank_;
			}
		}

		// Token: 0x170041A9 RID: 16809
		// (get) Token: 0x06013BE4 RID: 80868 RVA: 0x002E06EE File Offset: 0x002DE8EE
		// (set) Token: 0x06013BE5 RID: 80869 RVA: 0x002E06F6 File Offset: 0x002DE8F6
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

		// Token: 0x170041AA RID: 16810
		// (get) Token: 0x06013BE6 RID: 80870 RVA: 0x002E06FF File Offset: 0x002DE8FF
		// (set) Token: 0x06013BE7 RID: 80871 RVA: 0x002E0707 File Offset: 0x002DE907
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

		// Token: 0x170041AB RID: 16811
		// (get) Token: 0x06013BE8 RID: 80872 RVA: 0x002E071A File Offset: 0x002DE91A
		// (set) Token: 0x06013BE9 RID: 80873 RVA: 0x002E0722 File Offset: 0x002DE922
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

		// Token: 0x170041AC RID: 16812
		// (get) Token: 0x06013BEA RID: 80874 RVA: 0x002E072B File Offset: 0x002DE92B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RacingBetsOrganInfo> OrganInfo
		{
			get
			{
				return this.organInfo_;
			}
		}

		// Token: 0x06013BEB RID: 80875 RVA: 0x002E0733 File Offset: 0x002DE933
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RacingBetsLegMatchesInfo);
		}

		// Token: 0x06013BEC RID: 80876 RVA: 0x002E0744 File Offset: 0x002DE944
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RacingBetsLegMatchesInfo other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.dangoInfo_.Equals(other.dangoInfo_) && object.Equals(this.MatchStartEndTime, other.MatchStartEndTime) && object.Equals(this.GearStartEndTime, other.GearStartEndTime) && this.dangoRank_.Equals(other.dangoRank_) && this.NextOddsTime == other.NextOddsTime && !(this.OddsVersion != other.OddsVersion) && object.Equals(this.LegMatchWholeTime, other.LegMatchWholeTime) && this.organInfo_.Equals(other.organInfo_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06013BED RID: 80877 RVA: 0x002E0820 File Offset: 0x002DEA20
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

		// Token: 0x06013BEE RID: 80878 RVA: 0x002E08FF File Offset: 0x002DEAFF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06013BEF RID: 80879 RVA: 0x002E090C File Offset: 0x002DEB0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06013BF0 RID: 80880 RVA: 0x002E0918 File Offset: 0x002DEB18
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

		// Token: 0x06013BF1 RID: 80881 RVA: 0x002E0A18 File Offset: 0x002DEC18
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

		// Token: 0x06013BF2 RID: 80882 RVA: 0x002E0B0C File Offset: 0x002DED0C
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

		// Token: 0x06013BF3 RID: 80883 RVA: 0x002E0C2C File Offset: 0x002DEE2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06013BF4 RID: 80884 RVA: 0x002E0C38 File Offset: 0x002DEE38
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

		// Token: 0x0400793F RID: 31039
		private static readonly MessageParser<RacingBetsLegMatchesInfo> _parser = new MessageParser<RacingBetsLegMatchesInfo>(() => new RacingBetsLegMatchesInfo());

		// Token: 0x04007940 RID: 31040
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007941 RID: 31041
		public const int IdFieldNumber = 1;

		// Token: 0x04007942 RID: 31042
		private int id_;

		// Token: 0x04007943 RID: 31043
		public const int DangoInfoFieldNumber = 2;

		// Token: 0x04007944 RID: 31044
		private static readonly FieldCodec<RacingBetsDangoInfo> _repeated_dangoInfo_codec = FieldCodec.ForMessage<RacingBetsDangoInfo>(18U, RacingBetsDangoInfo.Parser);

		// Token: 0x04007945 RID: 31045
		private readonly RepeatedField<RacingBetsDangoInfo> dangoInfo_ = new RepeatedField<RacingBetsDangoInfo>();

		// Token: 0x04007946 RID: 31046
		public const int MatchStartEndTimeFieldNumber = 3;

		// Token: 0x04007947 RID: 31047
		private RacingBetsTimeTuple matchStartEndTime_;

		// Token: 0x04007948 RID: 31048
		public const int GearStartEndTimeFieldNumber = 4;

		// Token: 0x04007949 RID: 31049
		private RacingBetsTimeTuple gearStartEndTime_;

		// Token: 0x0400794A RID: 31050
		public const int DangoRankFieldNumber = 5;

		// Token: 0x0400794B RID: 31051
		private static readonly FieldCodec<int> _repeated_dangoRank_codec = FieldCodec.ForInt32(42U);

		// Token: 0x0400794C RID: 31052
		private readonly RepeatedField<int> dangoRank_ = new RepeatedField<int>();

		// Token: 0x0400794D RID: 31053
		public const int NextOddsTimeFieldNumber = 6;

		// Token: 0x0400794E RID: 31054
		private long nextOddsTime_;

		// Token: 0x0400794F RID: 31055
		public const int OddsVersionFieldNumber = 7;

		// Token: 0x04007950 RID: 31056
		private string oddsVersion_ = "";

		// Token: 0x04007951 RID: 31057
		public const int LegMatchWholeTimeFieldNumber = 8;

		// Token: 0x04007952 RID: 31058
		private RacingBetsTimeTuple legMatchWholeTime_;

		// Token: 0x04007953 RID: 31059
		public const int OrganInfoFieldNumber = 9;

		// Token: 0x04007954 RID: 31060
		private static readonly FieldCodec<RacingBetsOrganInfo> _repeated_organInfo_codec = FieldCodec.ForMessage<RacingBetsOrganInfo>(74U, RacingBetsOrganInfo.Parser);

		// Token: 0x04007955 RID: 31061
		private readonly RepeatedField<RacingBetsOrganInfo> organInfo_ = new RepeatedField<RacingBetsOrganInfo>();
	}
}
