using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200070A RID: 1802
	public sealed class GPUMonsterKilledCtxPb : IMessage<GPUMonsterKilledCtxPb>, IMessage, IEquatable<GPUMonsterKilledCtxPb>, IDeepCloneable<GPUMonsterKilledCtxPb>, IBufferMessage
	{
		// Token: 0x0600A402 RID: 41986 RVA: 0x0018C39A File Offset: 0x0018A59A
		[NullableContext(1)]
		public static GPUMonsterKilledCtxPb Create()
		{
			return new GPUMonsterKilledCtxPb();
		}

		// Token: 0x170020FD RID: 8445
		// (get) Token: 0x0600A403 RID: 41987 RVA: 0x0018C3A1 File Offset: 0x0018A5A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170020FE RID: 8446
		// (get) Token: 0x0600A404 RID: 41988 RVA: 0x0018C3A4 File Offset: 0x0018A5A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GPUMonsterKilledCtxPb.Descriptor;
			}
		}

		// Token: 0x0600A405 RID: 41989 RVA: 0x0018C3AB File Offset: 0x0018A5AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GPUMonsterKilledCtxPb()
		{
		}

		// Token: 0x0600A406 RID: 41990 RVA: 0x0018C3B3 File Offset: 0x0018A5B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GPUMonsterKilledCtxPb(GPUMonsterKilledCtxPb other) : this()
		{
			this.entityId_ = other.entityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A407 RID: 41991 RVA: 0x0018C3D8 File Offset: 0x0018A5D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GPUMonsterKilledCtxPb Clone()
		{
			return new GPUMonsterKilledCtxPb(this);
		}

		// Token: 0x170020FF RID: 8447
		// (get) Token: 0x0600A408 RID: 41992 RVA: 0x0018C3E0 File Offset: 0x0018A5E0
		// (set) Token: 0x0600A409 RID: 41993 RVA: 0x0018C3E8 File Offset: 0x0018A5E8
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

		// Token: 0x0600A40A RID: 41994 RVA: 0x0018C3F1 File Offset: 0x0018A5F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GPUMonsterKilledCtxPb);
		}

		// Token: 0x0600A40B RID: 41995 RVA: 0x0018C3FF File Offset: 0x0018A5FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GPUMonsterKilledCtxPb other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A40C RID: 41996 RVA: 0x0018C430 File Offset: 0x0018A630
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

		// Token: 0x0600A40D RID: 41997 RVA: 0x0018C46F File Offset: 0x0018A66F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600A40E RID: 41998 RVA: 0x0018C47C File Offset: 0x0018A67C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A40F RID: 41999 RVA: 0x0018C485 File Offset: 0x0018A685
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

		// Token: 0x0600A410 RID: 42000 RVA: 0x0018C4B8 File Offset: 0x0018A6B8
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

		// Token: 0x0600A411 RID: 42001 RVA: 0x0018C4F6 File Offset: 0x0018A6F6
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

		// Token: 0x0600A412 RID: 42002 RVA: 0x0018C527 File Offset: 0x0018A727
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A413 RID: 42003 RVA: 0x0018C530 File Offset: 0x0018A730
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

		// Token: 0x04004BB8 RID: 19384
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004BB9 RID: 19385
		public const int EntityIdFieldNumber = 1;

		// Token: 0x04004BBA RID: 19386
		private long entityId_;
	}
}
