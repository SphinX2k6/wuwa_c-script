using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020006F9 RID: 1785
	public sealed class GPURoleKilledCtxPb : IMessage<GPURoleKilledCtxPb>, IMessage, IEquatable<GPURoleKilledCtxPb>, IDeepCloneable<GPURoleKilledCtxPb>, IBufferMessage
	{
		// Token: 0x0600A2E2 RID: 41698 RVA: 0x00189EF0 File Offset: 0x001880F0
		[NullableContext(1)]
		public static GPURoleKilledCtxPb Create()
		{
			return new GPURoleKilledCtxPb();
		}

		// Token: 0x170020BC RID: 8380
		// (get) Token: 0x0600A2E3 RID: 41699 RVA: 0x00189EF7 File Offset: 0x001880F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170020BD RID: 8381
		// (get) Token: 0x0600A2E4 RID: 41700 RVA: 0x00189EFA File Offset: 0x001880FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GPURoleKilledCtxPb.Descriptor;
			}
		}

		// Token: 0x0600A2E5 RID: 41701 RVA: 0x00189F01 File Offset: 0x00188101
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GPURoleKilledCtxPb()
		{
		}

		// Token: 0x0600A2E6 RID: 41702 RVA: 0x00189F09 File Offset: 0x00188109
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GPURoleKilledCtxPb(GPURoleKilledCtxPb other) : this()
		{
			this.entityId_ = other.entityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A2E7 RID: 41703 RVA: 0x00189F2E File Offset: 0x0018812E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GPURoleKilledCtxPb Clone()
		{
			return new GPURoleKilledCtxPb(this);
		}

		// Token: 0x170020BE RID: 8382
		// (get) Token: 0x0600A2E8 RID: 41704 RVA: 0x00189F36 File Offset: 0x00188136
		// (set) Token: 0x0600A2E9 RID: 41705 RVA: 0x00189F3E File Offset: 0x0018813E
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

		// Token: 0x0600A2EA RID: 41706 RVA: 0x00189F47 File Offset: 0x00188147
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GPURoleKilledCtxPb);
		}

		// Token: 0x0600A2EB RID: 41707 RVA: 0x00189F55 File Offset: 0x00188155
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GPURoleKilledCtxPb other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A2EC RID: 41708 RVA: 0x00189F84 File Offset: 0x00188184
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

		// Token: 0x0600A2ED RID: 41709 RVA: 0x00189FC3 File Offset: 0x001881C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600A2EE RID: 41710 RVA: 0x00189FD0 File Offset: 0x001881D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A2EF RID: 41711 RVA: 0x00189FD9 File Offset: 0x001881D9
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

		// Token: 0x0600A2F0 RID: 41712 RVA: 0x0018A00C File Offset: 0x0018820C
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

		// Token: 0x0600A2F1 RID: 41713 RVA: 0x0018A04A File Offset: 0x0018824A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GPURoleKilledCtxPb other)
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

		// Token: 0x0600A2F2 RID: 41714 RVA: 0x0018A07B File Offset: 0x0018827B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A2F3 RID: 41715 RVA: 0x0018A084 File Offset: 0x00188284
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

		// Token: 0x04004BBA RID: 19386
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004BBB RID: 19387
		public const int EntityIdFieldNumber = 1;

		// Token: 0x04004BBC RID: 19388
		private long entityId_;
	}
}
