using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000BA8 RID: 2984
	public sealed class ParkourChallenge : IMessage<ParkourChallenge>, IMessage, IEquatable<ParkourChallenge>, IDeepCloneable<ParkourChallenge>, IBufferMessage
	{
		// Token: 0x06010329 RID: 66345 RVA: 0x0025D9E6 File Offset: 0x0025BBE6
		[NullableContext(1)]
		public static ParkourChallenge Create()
		{
			return new ParkourChallenge();
		}

		// Token: 0x1700351B RID: 13595
		// (get) Token: 0x0601032A RID: 66346 RVA: 0x0025D9ED File Offset: 0x0025BBED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ParkourChallenge> Parser
		{
			get
			{
				return ParkourChallenge._parser;
			}
		}

		// Token: 0x1700351C RID: 13596
		// (get) Token: 0x0601032B RID: 66347 RVA: 0x0025D9F4 File Offset: 0x0025BBF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700351D RID: 13597
		// (get) Token: 0x0601032C RID: 66348 RVA: 0x0025D9F7 File Offset: 0x0025BBF7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ParkourChallenge.Descriptor;
			}
		}

		// Token: 0x0601032D RID: 66349 RVA: 0x0025D9FE File Offset: 0x0025BBFE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ParkourChallenge()
		{
		}

		// Token: 0x0601032E RID: 66350 RVA: 0x0025DA14 File Offset: 0x0025BC14
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

		// Token: 0x0601032F RID: 66351 RVA: 0x0025DA6D File Offset: 0x0025BC6D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ParkourChallenge Clone()
		{
			return new ParkourChallenge(this);
		}

		// Token: 0x1700351E RID: 13598
		// (get) Token: 0x06010330 RID: 66352 RVA: 0x0025DA75 File Offset: 0x0025BC75
		// (set) Token: 0x06010331 RID: 66353 RVA: 0x0025DA7D File Offset: 0x0025BC7D
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

		// Token: 0x1700351F RID: 13599
		// (get) Token: 0x06010332 RID: 66354 RVA: 0x0025DA86 File Offset: 0x0025BC86
		// (set) Token: 0x06010333 RID: 66355 RVA: 0x0025DA8E File Offset: 0x0025BC8E
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

		// Token: 0x17003520 RID: 13600
		// (get) Token: 0x06010334 RID: 66356 RVA: 0x0025DA97 File Offset: 0x0025BC97
		// (set) Token: 0x06010335 RID: 66357 RVA: 0x0025DA9F File Offset: 0x0025BC9F
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

		// Token: 0x17003521 RID: 13601
		// (get) Token: 0x06010336 RID: 66358 RVA: 0x0025DAA8 File Offset: 0x0025BCA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> TakenScoreIndex
		{
			get
			{
				return this.takenScoreIndex_;
			}
		}

		// Token: 0x06010337 RID: 66359 RVA: 0x0025DAB0 File Offset: 0x0025BCB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ParkourChallenge);
		}

		// Token: 0x06010338 RID: 66360 RVA: 0x0025DAC0 File Offset: 0x0025BCC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ParkourChallenge other)
		{
			return other != null && (other == this || (this.ChallengeId == other.ChallengeId && this.MaxScore == other.MaxScore && this.MinDuration == other.MinDuration && this.takenScoreIndex_.Equals(other.takenScoreIndex_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06010339 RID: 66361 RVA: 0x0025DB30 File Offset: 0x0025BD30
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

		// Token: 0x0601033A RID: 66362 RVA: 0x0025DBAF File Offset: 0x0025BDAF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601033B RID: 66363 RVA: 0x0025DBBC File Offset: 0x0025BDBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601033C RID: 66364 RVA: 0x0025DBC8 File Offset: 0x0025BDC8
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

		// Token: 0x0601033D RID: 66365 RVA: 0x0025DC50 File Offset: 0x0025BE50
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

		// Token: 0x0601033E RID: 66366 RVA: 0x0025DCD4 File Offset: 0x0025BED4
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

		// Token: 0x0601033F RID: 66367 RVA: 0x0025DD49 File Offset: 0x0025BF49
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06010340 RID: 66368 RVA: 0x0025DD54 File Offset: 0x0025BF54
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

		// Token: 0x04006784 RID: 26500
		private static readonly MessageParser<ParkourChallenge> _parser = new MessageParser<ParkourChallenge>(() => new ParkourChallenge());

		// Token: 0x04006785 RID: 26501
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006786 RID: 26502
		public const int ChallengeIdFieldNumber = 1;

		// Token: 0x04006787 RID: 26503
		private int challengeId_;

		// Token: 0x04006788 RID: 26504
		public const int MaxScoreFieldNumber = 3;

		// Token: 0x04006789 RID: 26505
		private int maxScore_;

		// Token: 0x0400678A RID: 26506
		public const int MinDurationFieldNumber = 4;

		// Token: 0x0400678B RID: 26507
		private int minDuration_;

		// Token: 0x0400678C RID: 26508
		public const int TakenScoreIndexFieldNumber = 5;

		// Token: 0x0400678D RID: 26509
		private static readonly FieldCodec<int> _repeated_takenScoreIndex_codec = FieldCodec.ForInt32(42U);

		// Token: 0x0400678E RID: 26510
		private readonly RepeatedField<int> takenScoreIndex_ = new RepeatedField<int>();
	}
}
