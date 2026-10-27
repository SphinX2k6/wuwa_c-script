using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000924 RID: 2340
	[NetMessage(EMessageId.LineCrossChallengeStartRequest)]
	public sealed class LineCrossChallengeStartRequest : IMessage<LineCrossChallengeStartRequest>, IMessage, IEquatable<LineCrossChallengeStartRequest>, IDeepCloneable<LineCrossChallengeStartRequest>, IBufferMessage
	{
		// Token: 0x0600CE72 RID: 52850 RVA: 0x001E6A10 File Offset: 0x001E4C10
		[NullableContext(1)]
		public static LineCrossChallengeStartRequest Create()
		{
			return new LineCrossChallengeStartRequest();
		}

		// Token: 0x170029B6 RID: 10678
		// (get) Token: 0x0600CE73 RID: 52851 RVA: 0x001E6A17 File Offset: 0x001E4C17
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170029B7 RID: 10679
		// (get) Token: 0x0600CE74 RID: 52852 RVA: 0x001E6A1A File Offset: 0x001E4C1A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LineCrossChallengeStartRequest.Descriptor;
			}
		}

		// Token: 0x0600CE75 RID: 52853 RVA: 0x001E6A21 File Offset: 0x001E4C21
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LineCrossChallengeStartRequest()
		{
		}

		// Token: 0x0600CE76 RID: 52854 RVA: 0x001E6A29 File Offset: 0x001E4C29
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LineCrossChallengeStartRequest(LineCrossChallengeStartRequest other) : this()
		{
			this.id_ = other.id_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600CE77 RID: 52855 RVA: 0x001E6A4E File Offset: 0x001E4C4E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LineCrossChallengeStartRequest Clone()
		{
			return new LineCrossChallengeStartRequest(this);
		}

		// Token: 0x170029B8 RID: 10680
		// (get) Token: 0x0600CE78 RID: 52856 RVA: 0x001E6A56 File Offset: 0x001E4C56
		// (set) Token: 0x0600CE79 RID: 52857 RVA: 0x001E6A5E File Offset: 0x001E4C5E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Id
		{
			get
			{
				return this.id_;
			}
			set
			{
				this.id_ = value;
			}
		}

		// Token: 0x0600CE7A RID: 52858 RVA: 0x001E6A67 File Offset: 0x001E4C67
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LineCrossChallengeStartRequest);
		}

		// Token: 0x0600CE7B RID: 52859 RVA: 0x001E6A75 File Offset: 0x001E4C75
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LineCrossChallengeStartRequest other)
		{
			return other != null && (other == this || (this.Id == other.Id && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600CE7C RID: 52860 RVA: 0x001E6AA4 File Offset: 0x001E4CA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600CE7D RID: 52861 RVA: 0x001E6AE3 File Offset: 0x001E4CE3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600CE7E RID: 52862 RVA: 0x001E6AF0 File Offset: 0x001E4CF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600CE7F RID: 52863 RVA: 0x001E6AF9 File Offset: 0x001E4CF9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.Id);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600CE80 RID: 52864 RVA: 0x001E6B2C File Offset: 0x001E4D2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600CE81 RID: 52865 RVA: 0x001E6B6A File Offset: 0x001E4D6A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(LineCrossChallengeStartRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600CE82 RID: 52866 RVA: 0x001E6B9B File Offset: 0x001E4D9B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600CE83 RID: 52867 RVA: 0x001E6BA4 File Offset: 0x001E4DA4
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
				if (num != 112U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Id = input.ReadInt32();
				}
			}
		}

		// Token: 0x04005742 RID: 22338
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005743 RID: 22339
		public const int IdFieldNumber = 14;

		// Token: 0x04005744 RID: 22340
		private int id_;
	}
}
