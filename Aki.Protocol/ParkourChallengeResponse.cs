using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000BBC RID: 3004
	[NetMessage(EMessageId.ParkourChallengeResponse)]
	public sealed class ParkourChallengeResponse : IMessage<ParkourChallengeResponse>, IMessage, IEquatable<ParkourChallengeResponse>, IDeepCloneable<ParkourChallengeResponse>, IBufferMessage
	{
		// Token: 0x06010482 RID: 66690 RVA: 0x00260476 File Offset: 0x0025E676
		[NullableContext(1)]
		public static ParkourChallengeResponse Create()
		{
			return new ParkourChallengeResponse();
		}

		// Token: 0x17003567 RID: 13671
		// (get) Token: 0x06010483 RID: 66691 RVA: 0x0026047D File Offset: 0x0025E67D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003568 RID: 13672
		// (get) Token: 0x06010484 RID: 66692 RVA: 0x00260480 File Offset: 0x0025E680
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ParkourChallengeResponse.Descriptor;
			}
		}

		// Token: 0x06010485 RID: 66693 RVA: 0x00260487 File Offset: 0x0025E687
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ParkourChallengeResponse()
		{
		}

		// Token: 0x06010486 RID: 66694 RVA: 0x002604A5 File Offset: 0x0025E6A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ParkourChallengeResponse(ParkourChallengeResponse other) : this()
		{
			this.challenges_ = other.challenges_.Clone();
			this.openIds_ = other.openIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06010487 RID: 66695 RVA: 0x002604E0 File Offset: 0x0025E6E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ParkourChallengeResponse Clone()
		{
			return new ParkourChallengeResponse(this);
		}

		// Token: 0x17003569 RID: 13673
		// (get) Token: 0x06010488 RID: 66696 RVA: 0x002604E8 File Offset: 0x0025E6E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ParkourChallenge> Challenges
		{
			get
			{
				return this.challenges_;
			}
		}

		// Token: 0x1700356A RID: 13674
		// (get) Token: 0x06010489 RID: 66697 RVA: 0x002604F0 File Offset: 0x0025E6F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> OpenIds
		{
			get
			{
				return this.openIds_;
			}
		}

		// Token: 0x0601048A RID: 66698 RVA: 0x002604F8 File Offset: 0x0025E6F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ParkourChallengeResponse);
		}

		// Token: 0x0601048B RID: 66699 RVA: 0x00260508 File Offset: 0x0025E708
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ParkourChallengeResponse other)
		{
			return other != null && (other == this || (this.challenges_.Equals(other.challenges_) && this.openIds_.Equals(other.openIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601048C RID: 66700 RVA: 0x0026055C File Offset: 0x0025E75C
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

		// Token: 0x0601048D RID: 66701 RVA: 0x0026059E File Offset: 0x0025E79E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601048E RID: 66702 RVA: 0x002605AB File Offset: 0x0025E7AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601048F RID: 66703 RVA: 0x002605B4 File Offset: 0x0025E7B4
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

		// Token: 0x06010490 RID: 66704 RVA: 0x002605EC File Offset: 0x0025E7EC
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

		// Token: 0x06010491 RID: 66705 RVA: 0x00260638 File Offset: 0x0025E838
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

		// Token: 0x06010492 RID: 66706 RVA: 0x00260677 File Offset: 0x0025E877
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06010493 RID: 66707 RVA: 0x00260680 File Offset: 0x0025E880
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
				if (num != 32U && num != 34U)
				{
					if (num != 106U)
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

		// Token: 0x0400678E RID: 26510
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400678F RID: 26511
		public const int ChallengesFieldNumber = 13;

		// Token: 0x04006790 RID: 26512
		private static readonly FieldCodec<ParkourChallenge> _repeated_challenges_codec = FieldCodec.ForMessage<ParkourChallenge>(106U, ParkourChallenge.Parser);

		// Token: 0x04006791 RID: 26513
		private readonly RepeatedField<ParkourChallenge> challenges_ = new RepeatedField<ParkourChallenge>();

		// Token: 0x04006792 RID: 26514
		public const int OpenIdsFieldNumber = 4;

		// Token: 0x04006793 RID: 26515
		private static readonly FieldCodec<int> _repeated_openIds_codec = FieldCodec.ForInt32(34U);

		// Token: 0x04006794 RID: 26516
		private readonly RepeatedField<int> openIds_ = new RepeatedField<int>();
	}
}
