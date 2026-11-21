using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000913 RID: 2323
	[NetMessage(EMessageId.LineCrossChallengeStartRequest)]
	public sealed class LineCrossChallengeStartRequest : IMessage<LineCrossChallengeStartRequest>, IMessage, IEquatable<LineCrossChallengeStartRequest>, IDeepCloneable<LineCrossChallengeStartRequest>, IBufferMessage
	{
		// Token: 0x0600CD56 RID: 52566 RVA: 0x001E4740 File Offset: 0x001E2940
		[NullableContext(1)]
		public static LineCrossChallengeStartRequest Create()
		{
			return new LineCrossChallengeStartRequest();
		}

		// Token: 0x17002977 RID: 10615
		// (get) Token: 0x0600CD57 RID: 52567 RVA: 0x001E4747 File Offset: 0x001E2947
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002978 RID: 10616
		// (get) Token: 0x0600CD58 RID: 52568 RVA: 0x001E474A File Offset: 0x001E294A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LineCrossChallengeStartRequest.Descriptor;
			}
		}

		// Token: 0x0600CD59 RID: 52569 RVA: 0x001E4751 File Offset: 0x001E2951
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LineCrossChallengeStartRequest()
		{
		}

		// Token: 0x0600CD5A RID: 52570 RVA: 0x001E4759 File Offset: 0x001E2959
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LineCrossChallengeStartRequest(LineCrossChallengeStartRequest other) : this()
		{
			this.id_ = other.id_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600CD5B RID: 52571 RVA: 0x001E477E File Offset: 0x001E297E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LineCrossChallengeStartRequest Clone()
		{
			return new LineCrossChallengeStartRequest(this);
		}

		// Token: 0x17002979 RID: 10617
		// (get) Token: 0x0600CD5C RID: 52572 RVA: 0x001E4786 File Offset: 0x001E2986
		// (set) Token: 0x0600CD5D RID: 52573 RVA: 0x001E478E File Offset: 0x001E298E
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

		// Token: 0x0600CD5E RID: 52574 RVA: 0x001E4797 File Offset: 0x001E2997
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LineCrossChallengeStartRequest);
		}

		// Token: 0x0600CD5F RID: 52575 RVA: 0x001E47A5 File Offset: 0x001E29A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LineCrossChallengeStartRequest other)
		{
			return other != null && (other == this || (this.Id == other.Id && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600CD60 RID: 52576 RVA: 0x001E47D4 File Offset: 0x001E29D4
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

		// Token: 0x0600CD61 RID: 52577 RVA: 0x001E4813 File Offset: 0x001E2A13
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600CD62 RID: 52578 RVA: 0x001E4820 File Offset: 0x001E2A20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600CD63 RID: 52579 RVA: 0x001E4829 File Offset: 0x001E2A29
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.Id);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600CD64 RID: 52580 RVA: 0x001E485C File Offset: 0x001E2A5C
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

		// Token: 0x0600CD65 RID: 52581 RVA: 0x001E489A File Offset: 0x001E2A9A
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

		// Token: 0x0600CD66 RID: 52582 RVA: 0x001E48CB File Offset: 0x001E2ACB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600CD67 RID: 52583 RVA: 0x001E48D4 File Offset: 0x001E2AD4
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
				if (num != 96U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Id = input.ReadInt32();
				}
			}
		}

		// Token: 0x04005749 RID: 22345
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400574A RID: 22346
		public const int IdFieldNumber = 12;

		// Token: 0x0400574B RID: 22347
		private int id_;
	}
}
