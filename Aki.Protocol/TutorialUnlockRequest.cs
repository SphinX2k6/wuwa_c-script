using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020014EC RID: 5356
	[NetMessage(EMessageId.TutorialUnlockRequest)]
	public sealed class TutorialUnlockRequest : IMessage<TutorialUnlockRequest>, IMessage, IEquatable<TutorialUnlockRequest>, IDeepCloneable<TutorialUnlockRequest>, IBufferMessage
	{
		// Token: 0x0601C664 RID: 116324 RVA: 0x0041EA99 File Offset: 0x0041CC99
		[NullableContext(1)]
		public static TutorialUnlockRequest Create()
		{
			return new TutorialUnlockRequest();
		}

		// Token: 0x1700601E RID: 24606
		// (get) Token: 0x0601C665 RID: 116325 RVA: 0x0041EAA0 File Offset: 0x0041CCA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700601F RID: 24607
		// (get) Token: 0x0601C666 RID: 116326 RVA: 0x0041EAA3 File Offset: 0x0041CCA3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TutorialUnlockRequest.Descriptor;
			}
		}

		// Token: 0x0601C667 RID: 116327 RVA: 0x0041EAAA File Offset: 0x0041CCAA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TutorialUnlockRequest()
		{
		}

		// Token: 0x0601C668 RID: 116328 RVA: 0x0041EAB2 File Offset: 0x0041CCB2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TutorialUnlockRequest(TutorialUnlockRequest other) : this()
		{
			this.id_ = other.id_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601C669 RID: 116329 RVA: 0x0041EAD7 File Offset: 0x0041CCD7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TutorialUnlockRequest Clone()
		{
			return new TutorialUnlockRequest(this);
		}

		// Token: 0x17006020 RID: 24608
		// (get) Token: 0x0601C66A RID: 116330 RVA: 0x0041EADF File Offset: 0x0041CCDF
		// (set) Token: 0x0601C66B RID: 116331 RVA: 0x0041EAE7 File Offset: 0x0041CCE7
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

		// Token: 0x0601C66C RID: 116332 RVA: 0x0041EAF0 File Offset: 0x0041CCF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TutorialUnlockRequest);
		}

		// Token: 0x0601C66D RID: 116333 RVA: 0x0041EAFE File Offset: 0x0041CCFE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TutorialUnlockRequest other)
		{
			return other != null && (other == this || (this.Id == other.Id && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601C66E RID: 116334 RVA: 0x0041EB2C File Offset: 0x0041CD2C
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

		// Token: 0x0601C66F RID: 116335 RVA: 0x0041EB6B File Offset: 0x0041CD6B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601C670 RID: 116336 RVA: 0x0041EB78 File Offset: 0x0041CD78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601C671 RID: 116337 RVA: 0x0041EB81 File Offset: 0x0041CD81
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Id);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601C672 RID: 116338 RVA: 0x0041EBB4 File Offset: 0x0041CDB4
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

		// Token: 0x0601C673 RID: 116339 RVA: 0x0041EBF2 File Offset: 0x0041CDF2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TutorialUnlockRequest other)
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

		// Token: 0x0601C674 RID: 116340 RVA: 0x0041EC23 File Offset: 0x0041CE23
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601C675 RID: 116341 RVA: 0x0041EC2C File Offset: 0x0041CE2C
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
				if (num != 8U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Id = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400A403 RID: 41987
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A404 RID: 41988
		public const int IdFieldNumber = 1;

		// Token: 0x0400A405 RID: 41989
		private int id_;
	}
}
