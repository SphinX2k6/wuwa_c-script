using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000BBF RID: 3007
	[NetMessage(EMessageId.ParkourChallengeTransRequest)]
	public sealed class ParkourChallengeTransRequest : IMessage<ParkourChallengeTransRequest>, IMessage, IEquatable<ParkourChallengeTransRequest>, IDeepCloneable<ParkourChallengeTransRequest>, IBufferMessage
	{
		// Token: 0x060104BD RID: 66749 RVA: 0x00260C5E File Offset: 0x0025EE5E
		[NullableContext(1)]
		public static ParkourChallengeTransRequest Create()
		{
			return new ParkourChallengeTransRequest();
		}

		// Token: 0x17003573 RID: 13683
		// (get) Token: 0x060104BE RID: 66750 RVA: 0x00260C65 File Offset: 0x0025EE65
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003574 RID: 13684
		// (get) Token: 0x060104BF RID: 66751 RVA: 0x00260C68 File Offset: 0x0025EE68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ParkourChallengeTransRequest.Descriptor;
			}
		}

		// Token: 0x060104C0 RID: 66752 RVA: 0x00260C6F File Offset: 0x0025EE6F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ParkourChallengeTransRequest()
		{
		}

		// Token: 0x060104C1 RID: 66753 RVA: 0x00260C77 File Offset: 0x0025EE77
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ParkourChallengeTransRequest(ParkourChallengeTransRequest other) : this()
		{
			this.challengeId_ = other.challengeId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060104C2 RID: 66754 RVA: 0x00260C9C File Offset: 0x0025EE9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ParkourChallengeTransRequest Clone()
		{
			return new ParkourChallengeTransRequest(this);
		}

		// Token: 0x17003575 RID: 13685
		// (get) Token: 0x060104C3 RID: 66755 RVA: 0x00260CA4 File Offset: 0x0025EEA4
		// (set) Token: 0x060104C4 RID: 66756 RVA: 0x00260CAC File Offset: 0x0025EEAC
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

		// Token: 0x060104C5 RID: 66757 RVA: 0x00260CB5 File Offset: 0x0025EEB5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ParkourChallengeTransRequest);
		}

		// Token: 0x060104C6 RID: 66758 RVA: 0x00260CC3 File Offset: 0x0025EEC3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ParkourChallengeTransRequest other)
		{
			return other != null && (other == this || (this.ChallengeId == other.ChallengeId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060104C7 RID: 66759 RVA: 0x00260CF4 File Offset: 0x0025EEF4
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

		// Token: 0x060104C8 RID: 66760 RVA: 0x00260D33 File Offset: 0x0025EF33
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060104C9 RID: 66761 RVA: 0x00260D40 File Offset: 0x0025EF40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060104CA RID: 66762 RVA: 0x00260D49 File Offset: 0x0025EF49
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ChallengeId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.ChallengeId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060104CB RID: 66763 RVA: 0x00260D7C File Offset: 0x0025EF7C
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

		// Token: 0x060104CC RID: 66764 RVA: 0x00260DBA File Offset: 0x0025EFBA
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

		// Token: 0x060104CD RID: 66765 RVA: 0x00260DEB File Offset: 0x0025EFEB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060104CE RID: 66766 RVA: 0x00260DF4 File Offset: 0x0025EFF4
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
				if (num != 16U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ChallengeId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040067A0 RID: 26528
		private UnknownFieldSet _unknownFields;

		// Token: 0x040067A1 RID: 26529
		public const int ChallengeIdFieldNumber = 2;

		// Token: 0x040067A2 RID: 26530
		private int challengeId_;
	}
}
