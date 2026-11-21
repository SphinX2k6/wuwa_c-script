using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000BAF RID: 2991
	[NetMessage(EMessageId.ParkourChallengeTransRequest)]
	public sealed class ParkourChallengeTransRequest : IMessage<ParkourChallengeTransRequest>, IMessage, IEquatable<ParkourChallengeTransRequest>, IDeepCloneable<ParkourChallengeTransRequest>, IBufferMessage
	{
		// Token: 0x060103B9 RID: 66489 RVA: 0x0025EDA6 File Offset: 0x0025CFA6
		[NullableContext(1)]
		public static ParkourChallengeTransRequest Create()
		{
			return new ParkourChallengeTransRequest();
		}

		// Token: 0x1700353A RID: 13626
		// (get) Token: 0x060103BA RID: 66490 RVA: 0x0025EDAD File Offset: 0x0025CFAD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700353B RID: 13627
		// (get) Token: 0x060103BB RID: 66491 RVA: 0x0025EDB0 File Offset: 0x0025CFB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ParkourChallengeTransRequest.Descriptor;
			}
		}

		// Token: 0x060103BC RID: 66492 RVA: 0x0025EDB7 File Offset: 0x0025CFB7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ParkourChallengeTransRequest()
		{
		}

		// Token: 0x060103BD RID: 66493 RVA: 0x0025EDBF File Offset: 0x0025CFBF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ParkourChallengeTransRequest(ParkourChallengeTransRequest other) : this()
		{
			this.challengeId_ = other.challengeId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060103BE RID: 66494 RVA: 0x0025EDE4 File Offset: 0x0025CFE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ParkourChallengeTransRequest Clone()
		{
			return new ParkourChallengeTransRequest(this);
		}

		// Token: 0x1700353C RID: 13628
		// (get) Token: 0x060103BF RID: 66495 RVA: 0x0025EDEC File Offset: 0x0025CFEC
		// (set) Token: 0x060103C0 RID: 66496 RVA: 0x0025EDF4 File Offset: 0x0025CFF4
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

		// Token: 0x060103C1 RID: 66497 RVA: 0x0025EDFD File Offset: 0x0025CFFD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ParkourChallengeTransRequest);
		}

		// Token: 0x060103C2 RID: 66498 RVA: 0x0025EE0B File Offset: 0x0025D00B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ParkourChallengeTransRequest other)
		{
			return other != null && (other == this || (this.ChallengeId == other.ChallengeId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060103C3 RID: 66499 RVA: 0x0025EE3C File Offset: 0x0025D03C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ChallengeId != 0)
			{
				num ^= this.ChallengeId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060103C4 RID: 66500 RVA: 0x0025EE7B File Offset: 0x0025D07B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060103C5 RID: 66501 RVA: 0x0025EE88 File Offset: 0x0025D088
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060103C6 RID: 66502 RVA: 0x0025EE91 File Offset: 0x0025D091
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ChallengeId != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.ChallengeId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060103C7 RID: 66503 RVA: 0x0025EEC4 File Offset: 0x0025D0C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ChallengeId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ChallengeId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060103C8 RID: 66504 RVA: 0x0025EF02 File Offset: 0x0025D102
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ParkourChallengeTransRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ChallengeId != 0)
			{
				this.ChallengeId = other.ChallengeId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060103C9 RID: 66505 RVA: 0x0025EF33 File Offset: 0x0025D133
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060103CA RID: 66506 RVA: 0x0025EF3C File Offset: 0x0025D13C
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
				if (num != 48U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ChallengeId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040067B0 RID: 26544
		private UnknownFieldSet _unknownFields;

		// Token: 0x040067B1 RID: 26545
		public const int ChallengeIdFieldNumber = 6;

		// Token: 0x040067B2 RID: 26546
		private int challengeId_;
	}
}
