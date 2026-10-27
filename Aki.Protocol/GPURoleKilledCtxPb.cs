using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200070D RID: 1805
	public sealed class GPURoleKilledCtxPb : IMessage<GPURoleKilledCtxPb>, IMessage, IEquatable<GPURoleKilledCtxPb>, IDeepCloneable<GPURoleKilledCtxPb>, IBufferMessage
	{
		// Token: 0x0600A438 RID: 42040 RVA: 0x0018C924 File Offset: 0x0018AB24
		[NullableContext(1)]
		public static GPURoleKilledCtxPb Create()
		{
			return new GPURoleKilledCtxPb();
		}

		// Token: 0x17002106 RID: 8454
		// (get) Token: 0x0600A439 RID: 42041 RVA: 0x0018C92B File Offset: 0x0018AB2B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002107 RID: 8455
		// (get) Token: 0x0600A43A RID: 42042 RVA: 0x0018C92E File Offset: 0x0018AB2E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GPURoleKilledCtxPb.Descriptor;
			}
		}

		// Token: 0x0600A43B RID: 42043 RVA: 0x0018C935 File Offset: 0x0018AB35
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GPURoleKilledCtxPb()
		{
		}

		// Token: 0x0600A43C RID: 42044 RVA: 0x0018C93D File Offset: 0x0018AB3D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GPURoleKilledCtxPb(GPURoleKilledCtxPb other) : this()
		{
			this.entityId_ = other.entityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A43D RID: 42045 RVA: 0x0018C962 File Offset: 0x0018AB62
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GPURoleKilledCtxPb Clone()
		{
			return new GPURoleKilledCtxPb(this);
		}

		// Token: 0x17002108 RID: 8456
		// (get) Token: 0x0600A43E RID: 42046 RVA: 0x0018C96A File Offset: 0x0018AB6A
		// (set) Token: 0x0600A43F RID: 42047 RVA: 0x0018C972 File Offset: 0x0018AB72
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

		// Token: 0x0600A440 RID: 42048 RVA: 0x0018C97B File Offset: 0x0018AB7B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GPURoleKilledCtxPb);
		}

		// Token: 0x0600A441 RID: 42049 RVA: 0x0018C989 File Offset: 0x0018AB89
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GPURoleKilledCtxPb other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A442 RID: 42050 RVA: 0x0018C9B8 File Offset: 0x0018ABB8
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

		// Token: 0x0600A443 RID: 42051 RVA: 0x0018C9F7 File Offset: 0x0018ABF7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600A444 RID: 42052 RVA: 0x0018CA04 File Offset: 0x0018AC04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A445 RID: 42053 RVA: 0x0018CA0D File Offset: 0x0018AC0D
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

		// Token: 0x0600A446 RID: 42054 RVA: 0x0018CA40 File Offset: 0x0018AC40
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

		// Token: 0x0600A447 RID: 42055 RVA: 0x0018CA7E File Offset: 0x0018AC7E
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

		// Token: 0x0600A448 RID: 42056 RVA: 0x0018CAAF File Offset: 0x0018ACAF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A449 RID: 42057 RVA: 0x0018CAB8 File Offset: 0x0018ACB8
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

		// Token: 0x04004BC1 RID: 19393
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004BC2 RID: 19394
		public const int EntityIdFieldNumber = 1;

		// Token: 0x04004BC3 RID: 19395
		private long entityId_;
	}
}
