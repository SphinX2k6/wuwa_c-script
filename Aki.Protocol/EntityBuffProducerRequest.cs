using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000460 RID: 1120
	[NetMessage(EMessageId.EntityBuffProducerRequest)]
	public sealed class EntityBuffProducerRequest : IMessage<EntityBuffProducerRequest>, IMessage, IEquatable<EntityBuffProducerRequest>, IDeepCloneable<EntityBuffProducerRequest>, IBufferMessage
	{
		// Token: 0x06006B5A RID: 27482 RVA: 0x00103D33 File Offset: 0x00101F33
		[NullableContext(1)]
		public static EntityBuffProducerRequest Create()
		{
			return new EntityBuffProducerRequest();
		}

		// Token: 0x1700145F RID: 5215
		// (get) Token: 0x06006B5B RID: 27483 RVA: 0x00103D3A File Offset: 0x00101F3A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001460 RID: 5216
		// (get) Token: 0x06006B5C RID: 27484 RVA: 0x00103D3D File Offset: 0x00101F3D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EntityBuffProducerRequest.Descriptor;
			}
		}

		// Token: 0x06006B5D RID: 27485 RVA: 0x00103D44 File Offset: 0x00101F44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityBuffProducerRequest()
		{
		}

		// Token: 0x06006B5E RID: 27486 RVA: 0x00103D4C File Offset: 0x00101F4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityBuffProducerRequest(EntityBuffProducerRequest other) : this()
		{
			this.buffConsumerId_ = other.buffConsumerId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006B5F RID: 27487 RVA: 0x00103D71 File Offset: 0x00101F71
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityBuffProducerRequest Clone()
		{
			return new EntityBuffProducerRequest(this);
		}

		// Token: 0x17001461 RID: 5217
		// (get) Token: 0x06006B60 RID: 27488 RVA: 0x00103D79 File Offset: 0x00101F79
		// (set) Token: 0x06006B61 RID: 27489 RVA: 0x00103D81 File Offset: 0x00101F81
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long BuffConsumerId
		{
			get
			{
				return this.buffConsumerId_;
			}
			set
			{
				this.buffConsumerId_ = value;
			}
		}

		// Token: 0x06006B62 RID: 27490 RVA: 0x00103D8A File Offset: 0x00101F8A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EntityBuffProducerRequest);
		}

		// Token: 0x06006B63 RID: 27491 RVA: 0x00103D98 File Offset: 0x00101F98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EntityBuffProducerRequest other)
		{
			return other != null && (other == this || (this.BuffConsumerId == other.BuffConsumerId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006B64 RID: 27492 RVA: 0x00103DC8 File Offset: 0x00101FC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.BuffConsumerId != 0L)
			{
				num ^= this.BuffConsumerId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06006B65 RID: 27493 RVA: 0x00103E07 File Offset: 0x00102007
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06006B66 RID: 27494 RVA: 0x00103E14 File Offset: 0x00102014
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006B67 RID: 27495 RVA: 0x00103E1D File Offset: 0x0010201D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.BuffConsumerId != 0L)
			{
				output.WriteRawTag(16);
				output.WriteInt64(this.BuffConsumerId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006B68 RID: 27496 RVA: 0x00103E50 File Offset: 0x00102050
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.BuffConsumerId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.BuffConsumerId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06006B69 RID: 27497 RVA: 0x00103E8E File Offset: 0x0010208E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EntityBuffProducerRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.BuffConsumerId != 0L)
			{
				this.BuffConsumerId = other.BuffConsumerId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06006B6A RID: 27498 RVA: 0x00103EBF File Offset: 0x001020BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006B6B RID: 27499 RVA: 0x00103EC8 File Offset: 0x001020C8
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
					this.BuffConsumerId = input.ReadInt64();
				}
			}
		}

		// Token: 0x04003B01 RID: 15105
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003B02 RID: 15106
		public const int BuffConsumerIdFieldNumber = 2;

		// Token: 0x04003B03 RID: 15107
		private long buffConsumerId_;
	}
}
