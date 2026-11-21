using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E50 RID: 3664
	public sealed class RacingBetsGroupMatchesInfo : IMessage<RacingBetsGroupMatchesInfo>, IMessage, IEquatable<RacingBetsGroupMatchesInfo>, IDeepCloneable<RacingBetsGroupMatchesInfo>, IBufferMessage
	{
		// Token: 0x06013B2F RID: 80687 RVA: 0x002DDAE2 File Offset: 0x002DBCE2
		[NullableContext(1)]
		public static RacingBetsGroupMatchesInfo Create()
		{
			return new RacingBetsGroupMatchesInfo();
		}

		// Token: 0x17004169 RID: 16745
		// (get) Token: 0x06013B30 RID: 80688 RVA: 0x002DDAE9 File Offset: 0x002DBCE9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RacingBetsGroupMatchesInfo> Parser
		{
			get
			{
				return RacingBetsGroupMatchesInfo._parser;
			}
		}

		// Token: 0x1700416A RID: 16746
		// (get) Token: 0x06013B31 RID: 80689 RVA: 0x002DDAF0 File Offset: 0x002DBCF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700416B RID: 16747
		// (get) Token: 0x06013B32 RID: 80690 RVA: 0x002DDAF3 File Offset: 0x002DBCF3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RacingBetsGroupMatchesInfo.Descriptor;
			}
		}

		// Token: 0x06013B33 RID: 80691 RVA: 0x002DDAFA File Offset: 0x002DBCFA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsGroupMatchesInfo()
		{
		}

		// Token: 0x06013B34 RID: 80692 RVA: 0x002DDB24 File Offset: 0x002DBD24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsGroupMatchesInfo(RacingBetsGroupMatchesInfo other) : this()
		{
			this.groupMatchId_ = other.groupMatchId_;
			this.groupMatchTime_ = ((other.groupMatchTime_ != null) ? other.groupMatchTime_.Clone() : null);
			this.legMatchesInfo_ = other.legMatchesInfo_.Clone();
			this.promoteDangos_ = other.promoteDangos_.Clone();
			this.dangos_ = other.dangos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06013B35 RID: 80693 RVA: 0x002DDBA3 File Offset: 0x002DBDA3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsGroupMatchesInfo Clone()
		{
			return new RacingBetsGroupMatchesInfo(this);
		}

		// Token: 0x1700416C RID: 16748
		// (get) Token: 0x06013B36 RID: 80694 RVA: 0x002DDBAB File Offset: 0x002DBDAB
		// (set) Token: 0x06013B37 RID: 80695 RVA: 0x002DDBB3 File Offset: 0x002DBDB3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int GroupMatchId
		{
			get
			{
				return this.groupMatchId_;
			}
			set
			{
				this.groupMatchId_ = value;
			}
		}

		// Token: 0x1700416D RID: 16749
		// (get) Token: 0x06013B38 RID: 80696 RVA: 0x002DDBBC File Offset: 0x002DBDBC
		// (set) Token: 0x06013B39 RID: 80697 RVA: 0x002DDBC4 File Offset: 0x002DBDC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsTimeTuple GroupMatchTime
		{
			get
			{
				return this.groupMatchTime_;
			}
			set
			{
				this.groupMatchTime_ = value;
			}
		}

		// Token: 0x1700416E RID: 16750
		// (get) Token: 0x06013B3A RID: 80698 RVA: 0x002DDBCD File Offset: 0x002DBDCD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RacingBetsLegMatchesInfo> LegMatchesInfo
		{
			get
			{
				return this.legMatchesInfo_;
			}
		}

		// Token: 0x1700416F RID: 16751
		// (get) Token: 0x06013B3B RID: 80699 RVA: 0x002DDBD5 File Offset: 0x002DBDD5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> PromoteDangos
		{
			get
			{
				return this.promoteDangos_;
			}
		}

		// Token: 0x17004170 RID: 16752
		// (get) Token: 0x06013B3C RID: 80700 RVA: 0x002DDBDD File Offset: 0x002DBDDD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> Dangos
		{
			get
			{
				return this.dangos_;
			}
		}

		// Token: 0x06013B3D RID: 80701 RVA: 0x002DDBE5 File Offset: 0x002DBDE5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RacingBetsGroupMatchesInfo);
		}

		// Token: 0x06013B3E RID: 80702 RVA: 0x002DDBF4 File Offset: 0x002DBDF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RacingBetsGroupMatchesInfo other)
		{
			return other != null && (other == this || (this.GroupMatchId == other.GroupMatchId && object.Equals(this.GroupMatchTime, other.GroupMatchTime) && this.legMatchesInfo_.Equals(other.legMatchesInfo_) && this.promoteDangos_.Equals(other.promoteDangos_) && this.dangos_.Equals(other.dangos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06013B3F RID: 80703 RVA: 0x002DDC84 File Offset: 0x002DBE84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.GroupMatchId != 0)
			{
				num ^= this.GroupMatchId.GetHashCode();
			}
			if (this.groupMatchTime_ != null)
			{
				num ^= this.GroupMatchTime.GetHashCode();
			}
			num ^= this.legMatchesInfo_.GetHashCode();
			num ^= this.promoteDangos_.GetHashCode();
			num ^= this.dangos_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06013B40 RID: 80704 RVA: 0x002DDD03 File Offset: 0x002DBF03
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06013B41 RID: 80705 RVA: 0x002DDD10 File Offset: 0x002DBF10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06013B42 RID: 80706 RVA: 0x002DDD1C File Offset: 0x002DBF1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.GroupMatchId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.GroupMatchId);
			}
			if (this.groupMatchTime_ != null)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.GroupMatchTime);
			}
			this.legMatchesInfo_.WriteTo(ref output, RacingBetsGroupMatchesInfo._repeated_legMatchesInfo_codec);
			this.promoteDangos_.WriteTo(ref output, RacingBetsGroupMatchesInfo._repeated_promoteDangos_codec);
			this.dangos_.WriteTo(ref output, RacingBetsGroupMatchesInfo._repeated_dangos_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06013B43 RID: 80707 RVA: 0x002DDDA8 File Offset: 0x002DBFA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.GroupMatchId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.GroupMatchId);
			}
			if (this.groupMatchTime_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.GroupMatchTime);
			}
			num += this.legMatchesInfo_.CalculateSize(RacingBetsGroupMatchesInfo._repeated_legMatchesInfo_codec);
			num += this.promoteDangos_.CalculateSize(RacingBetsGroupMatchesInfo._repeated_promoteDangos_codec);
			num += this.dangos_.CalculateSize(RacingBetsGroupMatchesInfo._repeated_dangos_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06013B44 RID: 80708 RVA: 0x002DDE38 File Offset: 0x002DC038
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RacingBetsGroupMatchesInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.GroupMatchId != 0)
			{
				this.GroupMatchId = other.GroupMatchId;
			}
			if (other.groupMatchTime_ != null)
			{
				if (this.groupMatchTime_ == null)
				{
					this.GroupMatchTime = new RacingBetsTimeTuple();
				}
				this.GroupMatchTime.MergeFrom(other.GroupMatchTime);
			}
			this.legMatchesInfo_.Add(other.legMatchesInfo_);
			this.promoteDangos_.Add(other.promoteDangos_);
			this.dangos_.Add(other.dangos_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06013B45 RID: 80709 RVA: 0x002DDED3 File Offset: 0x002DC0D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06013B46 RID: 80710 RVA: 0x002DDEDC File Offset: 0x002DC0DC
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
				if (num <= 26U)
				{
					if (num == 8U)
					{
						this.GroupMatchId = input.ReadInt32();
						continue;
					}
					if (num == 18U)
					{
						if (this.groupMatchTime_ == null)
						{
							this.GroupMatchTime = new RacingBetsTimeTuple();
						}
						input.ReadMessage(this.GroupMatchTime);
						continue;
					}
					if (num == 26U)
					{
						this.legMatchesInfo_.AddEntriesFrom(ref input, RacingBetsGroupMatchesInfo._repeated_legMatchesInfo_codec);
						continue;
					}
				}
				else if (num <= 34U)
				{
					if (num == 32U || num == 34U)
					{
						this.promoteDangos_.AddEntriesFrom(ref input, RacingBetsGroupMatchesInfo._repeated_promoteDangos_codec);
						continue;
					}
				}
				else if (num == 40U || num == 42U)
				{
					this.dangos_.AddEntriesFrom(ref input, RacingBetsGroupMatchesInfo._repeated_dangos_codec);
					continue;
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040078F1 RID: 30961
		private static readonly MessageParser<RacingBetsGroupMatchesInfo> _parser = new MessageParser<RacingBetsGroupMatchesInfo>(() => new RacingBetsGroupMatchesInfo());

		// Token: 0x040078F2 RID: 30962
		private UnknownFieldSet _unknownFields;

		// Token: 0x040078F3 RID: 30963
		public const int GroupMatchIdFieldNumber = 1;

		// Token: 0x040078F4 RID: 30964
		private int groupMatchId_;

		// Token: 0x040078F5 RID: 30965
		public const int GroupMatchTimeFieldNumber = 2;

		// Token: 0x040078F6 RID: 30966
		private RacingBetsTimeTuple groupMatchTime_;

		// Token: 0x040078F7 RID: 30967
		public const int LegMatchesInfoFieldNumber = 3;

		// Token: 0x040078F8 RID: 30968
		private static readonly FieldCodec<RacingBetsLegMatchesInfo> _repeated_legMatchesInfo_codec = FieldCodec.ForMessage<RacingBetsLegMatchesInfo>(26U, RacingBetsLegMatchesInfo.Parser);

		// Token: 0x040078F9 RID: 30969
		private readonly RepeatedField<RacingBetsLegMatchesInfo> legMatchesInfo_ = new RepeatedField<RacingBetsLegMatchesInfo>();

		// Token: 0x040078FA RID: 30970
		public const int PromoteDangosFieldNumber = 4;

		// Token: 0x040078FB RID: 30971
		private static readonly FieldCodec<int> _repeated_promoteDangos_codec = FieldCodec.ForInt32(34U);

		// Token: 0x040078FC RID: 30972
		private readonly RepeatedField<int> promoteDangos_ = new RepeatedField<int>();

		// Token: 0x040078FD RID: 30973
		public const int DangosFieldNumber = 5;

		// Token: 0x040078FE RID: 30974
		private static readonly FieldCodec<int> _repeated_dangos_codec = FieldCodec.ForInt32(42U);

		// Token: 0x040078FF RID: 30975
		private readonly RepeatedField<int> dangos_ = new RepeatedField<int>();
	}
}
