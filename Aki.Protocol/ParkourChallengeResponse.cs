using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000BAC RID: 2988
	[NetMessage(EMessageId.ParkourChallengeResponse)]
	public sealed class ParkourChallengeResponse : IMessage<ParkourChallengeResponse>, IMessage, IEquatable<ParkourChallengeResponse>, IDeepCloneable<ParkourChallengeResponse>, IBufferMessage
	{
		// Token: 0x0601037E RID: 66430 RVA: 0x0025E5BE File Offset: 0x0025C7BE
		[NullableContext(1)]
		public static ParkourChallengeResponse Create()
		{
			return new ParkourChallengeResponse();
		}

		// Token: 0x1700352E RID: 13614
		// (get) Token: 0x0601037F RID: 66431 RVA: 0x0025E5C5 File Offset: 0x0025C7C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700352F RID: 13615
		// (get) Token: 0x06010380 RID: 66432 RVA: 0x0025E5C8 File Offset: 0x0025C7C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ParkourChallengeResponse.Descriptor;
			}
		}

		// Token: 0x06010381 RID: 66433 RVA: 0x0025E5CF File Offset: 0x0025C7CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ParkourChallengeResponse()
		{
		}

		// Token: 0x06010382 RID: 66434 RVA: 0x0025E5ED File Offset: 0x0025C7ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ParkourChallengeResponse(ParkourChallengeResponse other) : this()
		{
			this.challenges_ = other.challenges_.Clone();
			this.openIds_ = other.openIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06010383 RID: 66435 RVA: 0x0025E628 File Offset: 0x0025C828
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ParkourChallengeResponse Clone()
		{
			return new ParkourChallengeResponse(this);
		}

		// Token: 0x17003530 RID: 13616
		// (get) Token: 0x06010384 RID: 66436 RVA: 0x0025E630 File Offset: 0x0025C830
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ParkourChallenge> Challenges
		{
			get
			{
				return this.challenges_;
			}
		}

		// Token: 0x17003531 RID: 13617
		// (get) Token: 0x06010385 RID: 66437 RVA: 0x0025E638 File Offset: 0x0025C838
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> OpenIds
		{
			get
			{
				return this.openIds_;
			}
		}

		// Token: 0x06010386 RID: 66438 RVA: 0x0025E640 File Offset: 0x0025C840
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ParkourChallengeResponse);
		}

		// Token: 0x06010387 RID: 66439 RVA: 0x0025E650 File Offset: 0x0025C850
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ParkourChallengeResponse other)
		{
			return other != null && (other == this || (this.challenges_.Equals(other.challenges_) && this.openIds_.Equals(other.openIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06010388 RID: 66440 RVA: 0x0025E6A4 File Offset: 0x0025C8A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.challenges_.GetHashCode();
			num ^= this.openIds_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06010389 RID: 66441 RVA: 0x0025E6E6 File Offset: 0x0025C8E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601038A RID: 66442 RVA: 0x0025E6F3 File Offset: 0x0025C8F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601038B RID: 66443 RVA: 0x0025E6FC File Offset: 0x0025C8FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.openIds_.WriteTo(ref output, ParkourChallengeResponse._repeated_openIds_codec);
			this.challenges_.WriteTo(ref output, ParkourChallengeResponse._repeated_challenges_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601038C RID: 66444 RVA: 0x0025E734 File Offset: 0x0025C934
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.challenges_.CalculateSize(ParkourChallengeResponse._repeated_challenges_codec);
			num += this.openIds_.CalculateSize(ParkourChallengeResponse._repeated_openIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601038D RID: 66445 RVA: 0x0025E780 File Offset: 0x0025C980
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ParkourChallengeResponse other)
		{
			if (other == null)
			{
				return;
			}
			this.challenges_.Add(other.challenges_);
			this.openIds_.Add(other.openIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601038E RID: 66446 RVA: 0x0025E7BF File Offset: 0x0025C9BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601038F RID: 66447 RVA: 0x0025E7C8 File Offset: 0x0025C9C8
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
				if (num != 16U && num != 18U)
				{
					if (num != 42U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.challenges_.AddEntriesFrom(ref input, ParkourChallengeResponse._repeated_challenges_codec);
					}
				}
				else
				{
					this.openIds_.AddEntriesFrom(ref input, ParkourChallengeResponse._repeated_openIds_codec);
				}
			}
		}

		// Token: 0x0400679E RID: 26526
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400679F RID: 26527
		public const int ChallengesFieldNumber = 5;

		// Token: 0x040067A0 RID: 26528
		private static readonly FieldCodec<ParkourChallenge> _repeated_challenges_codec = FieldCodec.ForMessage<ParkourChallenge>(42U, ParkourChallenge.Parser);

		// Token: 0x040067A1 RID: 26529
		private readonly RepeatedField<ParkourChallenge> challenges_ = new RepeatedField<ParkourChallenge>();

		// Token: 0x040067A2 RID: 26530
		public const int OpenIdsFieldNumber = 2;

		// Token: 0x040067A3 RID: 26531
		private static readonly FieldCodec<int> _repeated_openIds_codec = FieldCodec.ForInt32(18U);

		// Token: 0x040067A4 RID: 26532
		private readonly RepeatedField<int> openIds_ = new RepeatedField<int>();
	}
}
