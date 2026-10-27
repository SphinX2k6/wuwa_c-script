using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E6B RID: 3691
	public sealed class RacingBetsMatchRoundInfo : IMessage<RacingBetsMatchRoundInfo>, IMessage, IEquatable<RacingBetsMatchRoundInfo>, IDeepCloneable<RacingBetsMatchRoundInfo>, IBufferMessage
	{
		// Token: 0x06013D48 RID: 81224 RVA: 0x002E3615 File Offset: 0x002E1815
		[NullableContext(1)]
		public static RacingBetsMatchRoundInfo Create()
		{
			return new RacingBetsMatchRoundInfo();
		}

		// Token: 0x170041F1 RID: 16881
		// (get) Token: 0x06013D49 RID: 81225 RVA: 0x002E361C File Offset: 0x002E181C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RacingBetsMatchRoundInfo> Parser
		{
			get
			{
				return RacingBetsMatchRoundInfo._parser;
			}
		}

		// Token: 0x170041F2 RID: 16882
		// (get) Token: 0x06013D4A RID: 81226 RVA: 0x002E3623 File Offset: 0x002E1823
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170041F3 RID: 16883
		// (get) Token: 0x06013D4B RID: 81227 RVA: 0x002E3626 File Offset: 0x002E1826
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RacingBetsMatchRoundInfo.Descriptor;
			}
		}

		// Token: 0x06013D4C RID: 81228 RVA: 0x002E362D File Offset: 0x002E182D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsMatchRoundInfo()
		{
		}

		// Token: 0x06013D4D RID: 81229 RVA: 0x002E3640 File Offset: 0x002E1840
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsMatchRoundInfo(RacingBetsMatchRoundInfo other) : this()
		{
			this.roundRank_ = other.roundRank_;
			this.roundAction_ = other.roundAction_.Clone();
			this.isFinalRound_ = other.isFinalRound_;
			this.result_ = ((other.result_ != null) ? other.result_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06013D4E RID: 81230 RVA: 0x002E36A9 File Offset: 0x002E18A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsMatchRoundInfo Clone()
		{
			return new RacingBetsMatchRoundInfo(this);
		}

		// Token: 0x170041F4 RID: 16884
		// (get) Token: 0x06013D4F RID: 81231 RVA: 0x002E36B1 File Offset: 0x002E18B1
		// (set) Token: 0x06013D50 RID: 81232 RVA: 0x002E36B9 File Offset: 0x002E18B9
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

		// Token: 0x170041F5 RID: 16885
		// (get) Token: 0x06013D51 RID: 81233 RVA: 0x002E36C2 File Offset: 0x002E18C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RacingBetsInstanceRoundAction> RoundAction
		{
			get
			{
				return this.roundAction_;
			}
		}

		// Token: 0x170041F6 RID: 16886
		// (get) Token: 0x06013D52 RID: 81234 RVA: 0x002E36CA File Offset: 0x002E18CA
		// (set) Token: 0x06013D53 RID: 81235 RVA: 0x002E36D2 File Offset: 0x002E18D2
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

		// Token: 0x170041F7 RID: 16887
		// (get) Token: 0x06013D54 RID: 81236 RVA: 0x002E36DB File Offset: 0x002E18DB
		// (set) Token: 0x06013D55 RID: 81237 RVA: 0x002E36E3 File Offset: 0x002E18E3
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

		// Token: 0x06013D56 RID: 81238 RVA: 0x002E36EC File Offset: 0x002E18EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RacingBetsMatchRoundInfo);
		}

		// Token: 0x06013D57 RID: 81239 RVA: 0x002E36FC File Offset: 0x002E18FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RacingBetsMatchRoundInfo other)
		{
			return other != null && (other == this || (this.RoundRank == other.RoundRank && this.roundAction_.Equals(other.roundAction_) && this.IsFinalRound == other.IsFinalRound && object.Equals(this.Result, other.Result) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06013D58 RID: 81240 RVA: 0x002E3770 File Offset: 0x002E1970
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.RoundRank != 0)
			{
				num ^= this.RoundRank.GetHashCode();
			}
			num ^= this.roundAction_.GetHashCode();
			if (this.IsFinalRound)
			{
				num ^= this.IsFinalRound.GetHashCode();
			}
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

		// Token: 0x06013D59 RID: 81241 RVA: 0x002E37EC File Offset: 0x002E19EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06013D5A RID: 81242 RVA: 0x002E37F9 File Offset: 0x002E19F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06013D5B RID: 81243 RVA: 0x002E3804 File Offset: 0x002E1A04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.RoundRank != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.RoundRank);
			}
			this.roundAction_.WriteTo(ref output, RacingBetsMatchRoundInfo._repeated_roundAction_codec);
			if (this.IsFinalRound)
			{
				output.WriteRawTag(24);
				output.WriteBool(this.IsFinalRound);
			}
			if (this.result_ != null)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.Result);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06013D5C RID: 81244 RVA: 0x002E388C File Offset: 0x002E1A8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.RoundRank != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RoundRank);
			}
			num += this.roundAction_.CalculateSize(RacingBetsMatchRoundInfo._repeated_roundAction_codec);
			if (this.IsFinalRound)
			{
				num += 2;
			}
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

		// Token: 0x06013D5D RID: 81245 RVA: 0x002E3904 File Offset: 0x002E1B04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RacingBetsMatchRoundInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.RoundRank != 0)
			{
				this.RoundRank = other.RoundRank;
			}
			this.roundAction_.Add(other.roundAction_);
			if (other.IsFinalRound)
			{
				this.IsFinalRound = other.IsFinalRound;
			}
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

		// Token: 0x06013D5E RID: 81246 RVA: 0x002E3991 File Offset: 0x002E1B91
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06013D5F RID: 81247 RVA: 0x002E399C File Offset: 0x002E1B9C
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
					if (num == 18U)
					{
						this.roundAction_.AddEntriesFrom(ref input, RacingBetsMatchRoundInfo._repeated_roundAction_codec);
						continue;
					}
				}
				else
				{
					if (num == 24U)
					{
						this.IsFinalRound = input.ReadBool();
						continue;
					}
					if (num == 34U)
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

		// Token: 0x04007954 RID: 31060
		private static readonly MessageParser<RacingBetsMatchRoundInfo> _parser = new MessageParser<RacingBetsMatchRoundInfo>(() => new RacingBetsMatchRoundInfo());

		// Token: 0x04007955 RID: 31061
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007956 RID: 31062
		public const int RoundRankFieldNumber = 1;

		// Token: 0x04007957 RID: 31063
		private int roundRank_;

		// Token: 0x04007958 RID: 31064
		public const int RoundActionFieldNumber = 2;

		// Token: 0x04007959 RID: 31065
		private static readonly FieldCodec<RacingBetsInstanceRoundAction> _repeated_roundAction_codec = FieldCodec.ForMessage<RacingBetsInstanceRoundAction>(18U, RacingBetsInstanceRoundAction.Parser);

		// Token: 0x0400795A RID: 31066
		private readonly RepeatedField<RacingBetsInstanceRoundAction> roundAction_ = new RepeatedField<RacingBetsInstanceRoundAction>();

		// Token: 0x0400795B RID: 31067
		public const int IsFinalRoundFieldNumber = 3;

		// Token: 0x0400795C RID: 31068
		private bool isFinalRound_;

		// Token: 0x0400795D RID: 31069
		public const int ResultFieldNumber = 4;

		// Token: 0x0400795E RID: 31070
		private MatchResult result_;
	}
}
