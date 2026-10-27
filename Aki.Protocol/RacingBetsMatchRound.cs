using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E6A RID: 3690
	public sealed class RacingBetsMatchRound : IMessage<RacingBetsMatchRound>, IMessage, IEquatable<RacingBetsMatchRound>, IDeepCloneable<RacingBetsMatchRound>, IBufferMessage
	{
		// Token: 0x06013D2D RID: 81197 RVA: 0x002E3066 File Offset: 0x002E1266
		[NullableContext(1)]
		public static RacingBetsMatchRound Create()
		{
			return new RacingBetsMatchRound();
		}

		// Token: 0x170041E8 RID: 16872
		// (get) Token: 0x06013D2E RID: 81198 RVA: 0x002E306D File Offset: 0x002E126D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RacingBetsMatchRound> Parser
		{
			get
			{
				return RacingBetsMatchRound._parser;
			}
		}

		// Token: 0x170041E9 RID: 16873
		// (get) Token: 0x06013D2F RID: 81199 RVA: 0x002E3074 File Offset: 0x002E1274
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170041EA RID: 16874
		// (get) Token: 0x06013D30 RID: 81200 RVA: 0x002E3077 File Offset: 0x002E1277
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RacingBetsMatchRound.Descriptor;
			}
		}

		// Token: 0x06013D31 RID: 81201 RVA: 0x002E307E File Offset: 0x002E127E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsMatchRound()
		{
		}

		// Token: 0x06013D32 RID: 81202 RVA: 0x002E30A8 File Offset: 0x002E12A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsMatchRound(RacingBetsMatchRound other) : this()
		{
			this.roundRank_ = other.roundRank_;
			this.dangoSequence_ = other.dangoSequence_.Clone();
			this.dangoRound_ = other.dangoRound_.Clone();
			this.isFinalRound_ = other.isFinalRound_;
			this.idToNum_ = other.idToNum_.Clone();
			this.result_ = ((other.result_ != null) ? other.result_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06013D33 RID: 81203 RVA: 0x002E3133 File Offset: 0x002E1333
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsMatchRound Clone()
		{
			return new RacingBetsMatchRound(this);
		}

		// Token: 0x170041EB RID: 16875
		// (get) Token: 0x06013D34 RID: 81204 RVA: 0x002E313B File Offset: 0x002E133B
		// (set) Token: 0x06013D35 RID: 81205 RVA: 0x002E3143 File Offset: 0x002E1343
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RoundRank
		{
			get
			{
				return this.roundRank_;
			}
			set
			{
				this.roundRank_ = value;
			}
		}

		// Token: 0x170041EC RID: 16876
		// (get) Token: 0x06013D36 RID: 81206 RVA: 0x002E314C File Offset: 0x002E134C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> DangoSequence
		{
			get
			{
				return this.dangoSequence_;
			}
		}

		// Token: 0x170041ED RID: 16877
		// (get) Token: 0x06013D37 RID: 81207 RVA: 0x002E3154 File Offset: 0x002E1354
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RacingBetsInstanceDangoRound> DangoRound
		{
			get
			{
				return this.dangoRound_;
			}
		}

		// Token: 0x170041EE RID: 16878
		// (get) Token: 0x06013D38 RID: 81208 RVA: 0x002E315C File Offset: 0x002E135C
		// (set) Token: 0x06013D39 RID: 81209 RVA: 0x002E3164 File Offset: 0x002E1364
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsFinalRound
		{
			get
			{
				return this.isFinalRound_;
			}
			set
			{
				this.isFinalRound_ = value;
			}
		}

		// Token: 0x170041EF RID: 16879
		// (get) Token: 0x06013D3A RID: 81210 RVA: 0x002E316D File Offset: 0x002E136D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<DangoIdToDiceNum> IdToNum
		{
			get
			{
				return this.idToNum_;
			}
		}

		// Token: 0x170041F0 RID: 16880
		// (get) Token: 0x06013D3B RID: 81211 RVA: 0x002E3175 File Offset: 0x002E1375
		// (set) Token: 0x06013D3C RID: 81212 RVA: 0x002E317D File Offset: 0x002E137D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MatchResult Result
		{
			get
			{
				return this.result_;
			}
			set
			{
				this.result_ = value;
			}
		}

		// Token: 0x06013D3D RID: 81213 RVA: 0x002E3186 File Offset: 0x002E1386
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RacingBetsMatchRound);
		}

		// Token: 0x06013D3E RID: 81214 RVA: 0x002E3194 File Offset: 0x002E1394
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RacingBetsMatchRound other)
		{
			return other != null && (other == this || (this.RoundRank == other.RoundRank && this.dangoSequence_.Equals(other.dangoSequence_) && this.dangoRound_.Equals(other.dangoRound_) && this.IsFinalRound == other.IsFinalRound && this.idToNum_.Equals(other.idToNum_) && object.Equals(this.Result, other.Result) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06013D3F RID: 81215 RVA: 0x002E3234 File Offset: 0x002E1434
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.RoundRank != 0)
			{
				num ^= this.RoundRank.GetHashCode();
			}
			num ^= this.dangoSequence_.GetHashCode();
			num ^= this.dangoRound_.GetHashCode();
			if (this.IsFinalRound)
			{
				num ^= this.IsFinalRound.GetHashCode();
			}
			num ^= this.idToNum_.GetHashCode();
			if (this.result_ != null)
			{
				num ^= this.Result.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06013D40 RID: 81216 RVA: 0x002E32CC File Offset: 0x002E14CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06013D41 RID: 81217 RVA: 0x002E32D9 File Offset: 0x002E14D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06013D42 RID: 81218 RVA: 0x002E32E4 File Offset: 0x002E14E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.RoundRank != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.RoundRank);
			}
			this.dangoSequence_.WriteTo(ref output, RacingBetsMatchRound._repeated_dangoSequence_codec);
			this.dangoRound_.WriteTo(ref output, RacingBetsMatchRound._repeated_dangoRound_codec);
			if (this.IsFinalRound)
			{
				output.WriteRawTag(32);
				output.WriteBool(this.IsFinalRound);
			}
			this.idToNum_.WriteTo(ref output, RacingBetsMatchRound._repeated_idToNum_codec);
			if (this.result_ != null)
			{
				output.WriteRawTag(50);
				output.WriteMessage(this.Result);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06013D43 RID: 81219 RVA: 0x002E338C File Offset: 0x002E158C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.RoundRank != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RoundRank);
			}
			num += this.dangoSequence_.CalculateSize(RacingBetsMatchRound._repeated_dangoSequence_codec);
			num += this.dangoRound_.CalculateSize(RacingBetsMatchRound._repeated_dangoRound_codec);
			if (this.IsFinalRound)
			{
				num += 2;
			}
			num += this.idToNum_.CalculateSize(RacingBetsMatchRound._repeated_idToNum_codec);
			if (this.result_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Result);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06013D44 RID: 81220 RVA: 0x002E3428 File Offset: 0x002E1628
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RacingBetsMatchRound other)
		{
			if (other == null)
			{
				return;
			}
			if (other.RoundRank != 0)
			{
				this.RoundRank = other.RoundRank;
			}
			this.dangoSequence_.Add(other.dangoSequence_);
			this.dangoRound_.Add(other.dangoRound_);
			if (other.IsFinalRound)
			{
				this.IsFinalRound = other.IsFinalRound;
			}
			this.idToNum_.Add(other.idToNum_);
			if (other.result_ != null)
			{
				if (this.result_ == null)
				{
					this.Result = new MatchResult();
				}
				this.Result.MergeFrom(other.Result);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06013D45 RID: 81221 RVA: 0x002E34D7 File Offset: 0x002E16D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06013D46 RID: 81222 RVA: 0x002E34E0 File Offset: 0x002E16E0
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
				if (num <= 18U)
				{
					if (num == 8U)
					{
						this.RoundRank = input.ReadInt32();
						continue;
					}
					if (num == 16U || num == 18U)
					{
						this.dangoSequence_.AddEntriesFrom(ref input, RacingBetsMatchRound._repeated_dangoSequence_codec);
						continue;
					}
				}
				else if (num <= 32U)
				{
					if (num == 26U)
					{
						this.dangoRound_.AddEntriesFrom(ref input, RacingBetsMatchRound._repeated_dangoRound_codec);
						continue;
					}
					if (num == 32U)
					{
						this.IsFinalRound = input.ReadBool();
						continue;
					}
				}
				else
				{
					if (num == 42U)
					{
						this.idToNum_.AddEntriesFrom(ref input, RacingBetsMatchRound._repeated_idToNum_codec);
						continue;
					}
					if (num == 50U)
					{
						if (this.result_ == null)
						{
							this.Result = new MatchResult();
						}
						input.ReadMessage(this.Result);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04007943 RID: 31043
		private static readonly MessageParser<RacingBetsMatchRound> _parser = new MessageParser<RacingBetsMatchRound>(() => new RacingBetsMatchRound());

		// Token: 0x04007944 RID: 31044
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007945 RID: 31045
		public const int RoundRankFieldNumber = 1;

		// Token: 0x04007946 RID: 31046
		private int roundRank_;

		// Token: 0x04007947 RID: 31047
		public const int DangoSequenceFieldNumber = 2;

		// Token: 0x04007948 RID: 31048
		private static readonly FieldCodec<int> _repeated_dangoSequence_codec = FieldCodec.ForInt32(18U);

		// Token: 0x04007949 RID: 31049
		private readonly RepeatedField<int> dangoSequence_ = new RepeatedField<int>();

		// Token: 0x0400794A RID: 31050
		public const int DangoRoundFieldNumber = 3;

		// Token: 0x0400794B RID: 31051
		private static readonly FieldCodec<RacingBetsInstanceDangoRound> _repeated_dangoRound_codec = FieldCodec.ForMessage<RacingBetsInstanceDangoRound>(26U, RacingBetsInstanceDangoRound.Parser);

		// Token: 0x0400794C RID: 31052
		private readonly RepeatedField<RacingBetsInstanceDangoRound> dangoRound_ = new RepeatedField<RacingBetsInstanceDangoRound>();

		// Token: 0x0400794D RID: 31053
		public const int IsFinalRoundFieldNumber = 4;

		// Token: 0x0400794E RID: 31054
		private bool isFinalRound_;

		// Token: 0x0400794F RID: 31055
		public const int IdToNumFieldNumber = 5;

		// Token: 0x04007950 RID: 31056
		private static readonly FieldCodec<DangoIdToDiceNum> _repeated_idToNum_codec = FieldCodec.ForMessage<DangoIdToDiceNum>(42U, DangoIdToDiceNum.Parser);

		// Token: 0x04007951 RID: 31057
		private readonly RepeatedField<DangoIdToDiceNum> idToNum_ = new RepeatedField<DangoIdToDiceNum>();

		// Token: 0x04007952 RID: 31058
		public const int ResultFieldNumber = 6;

		// Token: 0x04007953 RID: 31059
		private MatchResult result_;
	}
}
