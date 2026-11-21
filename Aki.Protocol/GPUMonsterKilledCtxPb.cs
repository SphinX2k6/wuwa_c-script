using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020006F6 RID: 1782
	public sealed class GPUMonsterKilledCtxPb : IMessage<GPUMonsterKilledCtxPb>, IMessage, IEquatable<GPUMonsterKilledCtxPb>, IDeepCloneable<GPUMonsterKilledCtxPb>, IBufferMessage
	{
		// Token: 0x0600A2AC RID: 41644 RVA: 0x00189966 File Offset: 0x00187B66
		[NullableContext(1)]
		public static GPUMonsterKilledCtxPb Create()
		{
			return new GPUMonsterKilledCtxPb();
		}

		// Token: 0x170020B3 RID: 8371
		// (get) Token: 0x0600A2AD RID: 41645 RVA: 0x0018996D File Offset: 0x00187B6D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170020B4 RID: 8372
		// (get) Token: 0x0600A2AE RID: 41646 RVA: 0x00189970 File Offset: 0x00187B70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GPUMonsterKilledCtxPb.Descriptor;
			}
		}

		// Token: 0x0600A2AF RID: 41647 RVA: 0x00189977 File Offset: 0x00187B77
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GPUMonsterKilledCtxPb()
		{
		}

		// Token: 0x0600A2B0 RID: 41648 RVA: 0x0018997F File Offset: 0x00187B7F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GPUMonsterKilledCtxPb(GPUMonsterKilledCtxPb other) : this()
		{
			this.entityId_ = other.entityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A2B1 RID: 41649 RVA: 0x001899A4 File Offset: 0x00187BA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GPUMonsterKilledCtxPb Clone()
		{
			return new GPUMonsterKilledCtxPb(this);
		}

		// Token: 0x170020B5 RID: 8373
		// (get) Token: 0x0600A2B2 RID: 41650 RVA: 0x001899AC File Offset: 0x00187BAC
		// (set) Token: 0x0600A2B3 RID: 41651 RVA: 0x001899B4 File Offset: 0x00187BB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long EntityId
		{
			get
			{
				return this.entityId_;
			}
			set
			{
				this.entityId_ = value;
			}
		}

		// Token: 0x0600A2B4 RID: 41652 RVA: 0x001899BD File Offset: 0x00187BBD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GPUMonsterKilledCtxPb);
		}

		// Token: 0x0600A2B5 RID: 41653 RVA: 0x001899CB File Offset: 0x00187BCB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GPUMonsterKilledCtxPb other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A2B6 RID: 41654 RVA: 0x001899FC File Offset: 0x00187BFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EntityId != 0L)
			{
				num ^= this.EntityId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600A2B7 RID: 41655 RVA: 0x00189A3B File Offset: 0x00187C3B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600A2B8 RID: 41656 RVA: 0x00189A48 File Offset: 0x00187C48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A2B9 RID: 41657 RVA: 0x00189A51 File Offset: 0x00187C51
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(8);
				output.WriteInt64(this.EntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A2BA RID: 41658 RVA: 0x00189A84 File Offset: 0x00187C84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EntityId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600A2BB RID: 41659 RVA: 0x00189AC2 File Offset: 0x00187CC2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GPUMonsterKilledCtxPb other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EntityId != 0L)
			{
				this.EntityId = other.EntityId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600A2BC RID: 41660 RVA: 0x00189AF3 File Offset: 0x00187CF3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A2BD RID: 41661 RVA: 0x00189AFC File Offset: 0x00187CFC
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
					this.EntityId = input.ReadInt64();
				}
			}
		}

		// Token: 0x04004BB1 RID: 19377
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004BB2 RID: 19378
		public const int EntityIdFieldNumber = 1;

		// Token: 0x04004BB3 RID: 19379
		private long entityId_;
	}
}
