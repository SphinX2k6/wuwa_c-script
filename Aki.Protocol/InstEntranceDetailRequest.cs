using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000823 RID: 2083
	[NetMessage(EMessageId.InstEntranceDetailRequest)]
	public sealed class InstEntranceDetailRequest : IMessage<InstEntranceDetailRequest>, IMessage, IEquatable<InstEntranceDetailRequest>, IDeepCloneable<InstEntranceDetailRequest>, IBufferMessage
	{
		// Token: 0x0600BA14 RID: 47636 RVA: 0x001BABCD File Offset: 0x001B8DCD
		[NullableContext(1)]
		public static InstEntranceDetailRequest Create()
		{
			return new InstEntranceDetailRequest();
		}

		// Token: 0x1700257E RID: 9598
		// (get) Token: 0x0600BA15 RID: 47637 RVA: 0x001BABD4 File Offset: 0x001B8DD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700257F RID: 9599
		// (get) Token: 0x0600BA16 RID: 47638 RVA: 0x001BABD7 File Offset: 0x001B8DD7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return InstEntranceDetailRequest.Descriptor;
			}
		}

		// Token: 0x0600BA17 RID: 47639 RVA: 0x001BABDE File Offset: 0x001B8DDE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InstEntranceDetailRequest()
		{
		}

		// Token: 0x0600BA18 RID: 47640 RVA: 0x001BABE6 File Offset: 0x001B8DE6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InstEntranceDetailRequest(InstEntranceDetailRequest other) : this()
		{
			this.entranceId_ = other.entranceId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600BA19 RID: 47641 RVA: 0x001BAC0B File Offset: 0x001B8E0B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InstEntranceDetailRequest Clone()
		{
			return new InstEntranceDetailRequest(this);
		}

		// Token: 0x17002580 RID: 9600
		// (get) Token: 0x0600BA1A RID: 47642 RVA: 0x001BAC13 File Offset: 0x001B8E13
		// (set) Token: 0x0600BA1B RID: 47643 RVA: 0x001BAC1B File Offset: 0x001B8E1B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int EntranceId
		{
			get
			{
				return this.entranceId_;
			}
			set
			{
				this.entranceId_ = value;
			}
		}

		// Token: 0x0600BA1C RID: 47644 RVA: 0x001BAC24 File Offset: 0x001B8E24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as InstEntranceDetailRequest);
		}

		// Token: 0x0600BA1D RID: 47645 RVA: 0x001BAC32 File Offset: 0x001B8E32
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(InstEntranceDetailRequest other)
		{
			return other != null && (other == this || (this.EntranceId == other.EntranceId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600BA1E RID: 47646 RVA: 0x001BAC60 File Offset: 0x001B8E60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EntranceId != 0)
			{
				num ^= this.EntranceId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600BA1F RID: 47647 RVA: 0x001BAC9F File Offset: 0x001B8E9F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600BA20 RID: 47648 RVA: 0x001BACAC File Offset: 0x001B8EAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600BA21 RID: 47649 RVA: 0x001BACB5 File Offset: 0x001B8EB5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntranceId != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.EntranceId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600BA22 RID: 47650 RVA: 0x001BACE8 File Offset: 0x001B8EE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EntranceId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.EntranceId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600BA23 RID: 47651 RVA: 0x001BAD26 File Offset: 0x001B8F26
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(InstEntranceDetailRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EntranceId != 0)
			{
				this.EntranceId = other.EntranceId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600BA24 RID: 47652 RVA: 0x001BAD57 File Offset: 0x001B8F57
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600BA25 RID: 47653 RVA: 0x001BAD60 File Offset: 0x001B8F60
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
				if (num != 72U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.EntranceId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040051AC RID: 20908
		private UnknownFieldSet _unknownFields;

		// Token: 0x040051AD RID: 20909
		public const int EntranceIdFieldNumber = 9;

		// Token: 0x040051AE RID: 20910
		private int entranceId_;
	}
}
