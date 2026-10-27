using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000BB8 RID: 3000
	public sealed class ParkourChallenge : IMessage<ParkourChallenge>, IMessage, IEquatable<ParkourChallenge>, IDeepCloneable<ParkourChallenge>, IBufferMessage
	{
		// Token: 0x0601042D RID: 66605 RVA: 0x0025F89A File Offset: 0x0025DA9A
		[NullableContext(1)]
		public static ParkourChallenge Create()
		{
			return new ParkourChallenge();
		}

		// Token: 0x17003554 RID: 13652
		// (get) Token: 0x0601042E RID: 66606 RVA: 0x0025F8A1 File Offset: 0x0025DAA1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ParkourChallenge> Parser
		{
			get
			{
				return ParkourChallenge._parser;
			}
		}

		// Token: 0x17003555 RID: 13653
		// (get) Token: 0x0601042F RID: 66607 RVA: 0x0025F8A8 File Offset: 0x0025DAA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003556 RID: 13654
		// (get) Token: 0x06010430 RID: 66608 RVA: 0x0025F8AB File Offset: 0x0025DAAB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ParkourChallenge.Descriptor;
			}
		}

		// Token: 0x06010431 RID: 66609 RVA: 0x0025F8B2 File Offset: 0x0025DAB2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ParkourChallenge()
		{
		}

		// Token: 0x06010432 RID: 66610 RVA: 0x0025F8C8 File Offset: 0x0025DAC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ParkourChallenge(ParkourChallenge other) : this()
		{
			this.challengeId_ = other.challengeId_;
			this.maxScore_ = other.maxScore_;
			this.minDuration_ = other.minDuration_;
			this.takenScoreIndex_ = other.takenScoreIndex_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06010433 RID: 66611 RVA: 0x0025F921 File Offset: 0x0025DB21
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ParkourChallenge Clone()
		{
			return new ParkourChallenge(this);
		}

		// Token: 0x17003557 RID: 13655
		// (get) Token: 0x06010434 RID: 66612 RVA: 0x0025F929 File Offset: 0x0025DB29
		// (set) Token: 0x06010435 RID: 66613 RVA: 0x0025F931 File Offset: 0x0025DB31
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ChallengeId
		{
			get
			{
				return this.challengeId_;
			}
			set
			{
				this.challengeId_ = value;
			}
		}

		// Token: 0x17003558 RID: 13656
		// (get) Token: 0x06010436 RID: 66614 RVA: 0x0025F93A File Offset: 0x0025DB3A
		// (set) Token: 0x06010437 RID: 66615 RVA: 0x0025F942 File Offset: 0x0025DB42
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int MaxScore
		{
			get
			{
				return this.maxScore_;
			}
			set
			{
				this.maxScore_ = value;
			}
		}

		// Token: 0x17003559 RID: 13657
		// (get) Token: 0x06010438 RID: 66616 RVA: 0x0025F94B File Offset: 0x0025DB4B
		// (set) Token: 0x06010439 RID: 66617 RVA: 0x0025F953 File Offset: 0x0025DB53
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int MinDuration
		{
			get
			{
				return this.minDuration_;
			}
			set
			{
				this.minDuration_ = value;
			}
		}

		// Token: 0x1700355A RID: 13658
		// (get) Token: 0x0601043A RID: 66618 RVA: 0x0025F95C File Offset: 0x0025DB5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> TakenScoreIndex
		{
			get
			{
				return this.takenScoreIndex_;
			}
		}

		// Token: 0x0601043B RID: 66619 RVA: 0x0025F964 File Offset: 0x0025DB64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ParkourChallenge);
		}

		// Token: 0x0601043C RID: 66620 RVA: 0x0025F974 File Offset: 0x0025DB74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ParkourChallenge other)
		{
			return other != null && (other == this || (this.ChallengeId == other.ChallengeId && this.MaxScore == other.MaxScore && this.MinDuration == other.MinDuration && this.takenScoreIndex_.Equals(other.takenScoreIndex_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601043D RID: 66621 RVA: 0x0025F9E4 File Offset: 0x0025DBE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ChallengeId != 0)
			{
				num ^= this.ChallengeId.GetHashCode();
			}
			if (this.MaxScore != 0)
			{
				num ^= this.MaxScore.GetHashCode();
			}
			if (this.MinDuration != 0)
			{
				num ^= this.MinDuration.GetHashCode();
			}
			num ^= this.takenScoreIndex_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601043E RID: 66622 RVA: 0x0025FA63 File Offset: 0x0025DC63
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601043F RID: 66623 RVA: 0x0025FA70 File Offset: 0x0025DC70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06010440 RID: 66624 RVA: 0x0025FA7C File Offset: 0x0025DC7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ChallengeId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.ChallengeId);
			}
			if (this.MaxScore != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.MaxScore);
			}
			if (this.MinDuration != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.MinDuration);
			}
			this.takenScoreIndex_.WriteTo(ref output, ParkourChallenge._repeated_takenScoreIndex_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06010441 RID: 66625 RVA: 0x0025FB04 File Offset: 0x0025DD04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ChallengeId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ChallengeId);
			}
			if (this.MaxScore != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.MaxScore);
			}
			if (this.MinDuration != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.MinDuration);
			}
			num += this.takenScoreIndex_.CalculateSize(ParkourChallenge._repeated_takenScoreIndex_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06010442 RID: 66626 RVA: 0x0025FB88 File Offset: 0x0025DD88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ParkourChallenge other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ChallengeId != 0)
			{
				this.ChallengeId = other.ChallengeId;
			}
			if (other.MaxScore != 0)
			{
				this.MaxScore = other.MaxScore;
			}
			if (other.MinDuration != 0)
			{
				this.MinDuration = other.MinDuration;
			}
			this.takenScoreIndex_.Add(other.takenScoreIndex_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06010443 RID: 66627 RVA: 0x0025FBFD File Offset: 0x0025DDFD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06010444 RID: 66628 RVA: 0x0025FC08 File Offset: 0x0025DE08
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
				if (num <= 24U)
				{
					if (num == 8U)
					{
						this.ChallengeId = input.ReadInt32();
						continue;
					}
					if (num == 24U)
					{
						this.MaxScore = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 32U)
					{
						this.MinDuration = input.ReadInt32();
						continue;
					}
					if (num == 40U || num == 42U)
					{
						this.takenScoreIndex_.AddEntriesFrom(ref input, ParkourChallenge._repeated_takenScoreIndex_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04006774 RID: 26484
		private static readonly MessageParser<ParkourChallenge> _parser = new MessageParser<ParkourChallenge>(() => new ParkourChallenge());

		// Token: 0x04006775 RID: 26485
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006776 RID: 26486
		public const int ChallengeIdFieldNumber = 1;

		// Token: 0x04006777 RID: 26487
		private int challengeId_;

		// Token: 0x04006778 RID: 26488
		public const int MaxScoreFieldNumber = 3;

		// Token: 0x04006779 RID: 26489
		private int maxScore_;

		// Token: 0x0400677A RID: 26490
		public const int MinDurationFieldNumber = 4;

		// Token: 0x0400677B RID: 26491
		private int minDuration_;

		// Token: 0x0400677C RID: 26492
		public const int TakenScoreIndexFieldNumber = 5;

		// Token: 0x0400677D RID: 26493
		private static readonly FieldCodec<int> _repeated_takenScoreIndex_codec = FieldCodec.ForInt32(42U);

		// Token: 0x0400677E RID: 26494
		private readonly RepeatedField<int> takenScoreIndex_ = new RepeatedField<int>();
	}
}
