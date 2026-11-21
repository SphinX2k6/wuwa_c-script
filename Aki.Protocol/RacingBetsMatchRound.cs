using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E5A RID: 3674
	public sealed class RacingBetsMatchRound : IMessage<RacingBetsMatchRound>, IMessage, IEquatable<RacingBetsMatchRound>, IDeepCloneable<RacingBetsMatchRound>, IBufferMessage
	{
		// Token: 0x06013C48 RID: 80968 RVA: 0x002E19A6 File Offset: 0x002DFBA6
		[NullableContext(1)]
		public static RacingBetsMatchRound Create()
		{
			return new RacingBetsMatchRound();
		}

		// Token: 0x170041BE RID: 16830
		// (get) Token: 0x06013C49 RID: 80969 RVA: 0x002E19AD File Offset: 0x002DFBAD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RacingBetsMatchRound> Parser
		{
			get
			{
				return RacingBetsMatchRound._parser;
			}
		}

		// Token: 0x170041BF RID: 16831
		// (get) Token: 0x06013C4A RID: 80970 RVA: 0x002E19B4 File Offset: 0x002DFBB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170041C0 RID: 16832
		// (get) Token: 0x06013C4B RID: 80971 RVA: 0x002E19B7 File Offset: 0x002DFBB7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RacingBetsMatchRound.Descriptor;
			}
		}

		// Token: 0x06013C4C RID: 80972 RVA: 0x002E19BE File Offset: 0x002DFBBE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsMatchRound()
		{
		}

		// Token: 0x06013C4D RID: 80973 RVA: 0x002E19E8 File Offset: 0x002DFBE8
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

		// Token: 0x06013C4E RID: 80974 RVA: 0x002E1A73 File Offset: 0x002DFC73
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsMatchRound Clone()
		{
			return new RacingBetsMatchRound(this);
		}

		// Token: 0x170041C1 RID: 16833
		// (get) Token: 0x06013C4F RID: 80975 RVA: 0x002E1A7B File Offset: 0x002DFC7B
		// (set) Token: 0x06013C50 RID: 80976 RVA: 0x002E1A83 File Offset: 0x002DFC83
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

		// Token: 0x170041C2 RID: 16834
		// (get) Token: 0x06013C51 RID: 80977 RVA: 0x002E1A8C File Offset: 0x002DFC8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> DangoSequence
		{
			get
			{
				return this.dangoSequence_;
			}
		}

		// Token: 0x170041C3 RID: 16835
		// (get) Token: 0x06013C52 RID: 80978 RVA: 0x002E1A94 File Offset: 0x002DFC94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RacingBetsInstanceDangoRound> DangoRound
		{
			get
			{
				return this.dangoRound_;
			}
		}

		// Token: 0x170041C4 RID: 16836
		// (get) Token: 0x06013C53 RID: 80979 RVA: 0x002E1A9C File Offset: 0x002DFC9C
		// (set) Token: 0x06013C54 RID: 80980 RVA: 0x002E1AA4 File Offset: 0x002DFCA4
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

		// Token: 0x170041C5 RID: 16837
		// (get) Token: 0x06013C55 RID: 80981 RVA: 0x002E1AAD File Offset: 0x002DFCAD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<DangoIdToDiceNum> IdToNum
		{
			get
			{
				return this.idToNum_;
			}
		}

		// Token: 0x170041C6 RID: 16838
		// (get) Token: 0x06013C56 RID: 80982 RVA: 0x002E1AB5 File Offset: 0x002DFCB5
		// (set) Token: 0x06013C57 RID: 80983 RVA: 0x002E1ABD File Offset: 0x002DFCBD
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

		// Token: 0x06013C58 RID: 80984 RVA: 0x002E1AC6 File Offset: 0x002DFCC6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RacingBetsMatchRound);
		}

		// Token: 0x06013C59 RID: 80985 RVA: 0x002E1AD4 File Offset: 0x002DFCD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RacingBetsMatchRound other)
		{
			return other != null && (other == this || (this.RoundRank == other.RoundRank && this.dangoSequence_.Equals(other.dangoSequence_) && this.dangoRound_.Equals(other.dangoRound_) && this.IsFinalRound == other.IsFinalRound && this.idToNum_.Equals(other.idToNum_) && object.Equals(this.Result, other.Result) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06013C5A RID: 80986 RVA: 0x002E1B74 File Offset: 0x002DFD74
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

		// Token: 0x06013C5B RID: 80987 RVA: 0x002E1C0C File Offset: 0x002DFE0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06013C5C RID: 80988 RVA: 0x002E1C19 File Offset: 0x002DFE19
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06013C5D RID: 80989 RVA: 0x002E1C24 File Offset: 0x002DFE24
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

		// Token: 0x06013C5E RID: 80990 RVA: 0x002E1CCC File Offset: 0x002DFECC
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

		// Token: 0x06013C5F RID: 80991 RVA: 0x002E1D68 File Offset: 0x002DFF68
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

		// Token: 0x06013C60 RID: 80992 RVA: 0x002E1E17 File Offset: 0x002E0017
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06013C61 RID: 80993 RVA: 0x002E1E20 File Offset: 0x002E0020
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

		// Token: 0x0400796D RID: 31085
		private static readonly MessageParser<RacingBetsMatchRound> _parser = new MessageParser<RacingBetsMatchRound>(() => new RacingBetsMatchRound());

		// Token: 0x0400796E RID: 31086
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400796F RID: 31087
		public const int RoundRankFieldNumber = 1;

		// Token: 0x04007970 RID: 31088
		private int roundRank_;

		// Token: 0x04007971 RID: 31089
		public const int DangoSequenceFieldNumber = 2;

		// Token: 0x04007972 RID: 31090
		private static readonly FieldCodec<int> _repeated_dangoSequence_codec = FieldCodec.ForInt32(18U);

		// Token: 0x04007973 RID: 31091
		private readonly RepeatedField<int> dangoSequence_ = new RepeatedField<int>();

		// Token: 0x04007974 RID: 31092
		public const int DangoRoundFieldNumber = 3;

		// Token: 0x04007975 RID: 31093
		private static readonly FieldCodec<RacingBetsInstanceDangoRound> _repeated_dangoRound_codec = FieldCodec.ForMessage<RacingBetsInstanceDangoRound>(26U, RacingBetsInstanceDangoRound.Parser);

		// Token: 0x04007976 RID: 31094
		private readonly RepeatedField<RacingBetsInstanceDangoRound> dangoRound_ = new RepeatedField<RacingBetsInstanceDangoRound>();

		// Token: 0x04007977 RID: 31095
		public const int IsFinalRoundFieldNumber = 4;

		// Token: 0x04007978 RID: 31096
		private bool isFinalRound_;

		// Token: 0x04007979 RID: 31097
		public const int IdToNumFieldNumber = 5;

		// Token: 0x0400797A RID: 31098
		private static readonly FieldCodec<DangoIdToDiceNum> _repeated_idToNum_codec = FieldCodec.ForMessage<DangoIdToDiceNum>(42U, DangoIdToDiceNum.Parser);

		// Token: 0x0400797B RID: 31099
		private readonly RepeatedField<DangoIdToDiceNum> idToNum_ = new RepeatedField<DangoIdToDiceNum>();

		// Token: 0x0400797C RID: 31100
		public const int ResultFieldNumber = 6;

		// Token: 0x0400797D RID: 31101
		private MatchResult result_;
	}
}
