using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200015E RID: 350
	public sealed class BatchBulletCastComponentPb : IMessage<BatchBulletCastComponentPb>, IMessage, IEquatable<BatchBulletCastComponentPb>, IDeepCloneable<BatchBulletCastComponentPb>, IBufferMessage
	{
		// Token: 0x06002C30 RID: 11312 RVA: 0x0007375E File Offset: 0x0007195E
		[NullableContext(1)]
		public static BatchBulletCastComponentPb Create()
		{
			return new BatchBulletCastComponentPb();
		}

		// Token: 0x170006A2 RID: 1698
		// (get) Token: 0x06002C31 RID: 11313 RVA: 0x00073765 File Offset: 0x00071965
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170006A3 RID: 1699
		// (get) Token: 0x06002C32 RID: 11314 RVA: 0x00073768 File Offset: 0x00071968
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BatchBulletCastComponentPb.Descriptor;
			}
		}

		// Token: 0x06002C33 RID: 11315 RVA: 0x0007376F File Offset: 0x0007196F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BatchBulletCastComponentPb()
		{
		}

		// Token: 0x06002C34 RID: 11316 RVA: 0x00073777 File Offset: 0x00071977
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BatchBulletCastComponentPb(BatchBulletCastComponentPb other) : this()
		{
			this.contextId_ = other.contextId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002C35 RID: 11317 RVA: 0x0007379C File Offset: 0x0007199C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BatchBulletCastComponentPb Clone()
		{
			return new BatchBulletCastComponentPb(this);
		}

		// Token: 0x170006A4 RID: 1700
		// (get) Token: 0x06002C36 RID: 11318 RVA: 0x000737A4 File Offset: 0x000719A4
		// (set) Token: 0x06002C37 RID: 11319 RVA: 0x000737AC File Offset: 0x000719AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long ContextId
		{
			get
			{
				return this.contextId_;
			}
			set
			{
				this.contextId_ = value;
			}
		}

		// Token: 0x06002C38 RID: 11320 RVA: 0x000737B5 File Offset: 0x000719B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BatchBulletCastComponentPb);
		}

		// Token: 0x06002C39 RID: 11321 RVA: 0x000737C3 File Offset: 0x000719C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BatchBulletCastComponentPb other)
		{
			return other != null && (other == this || (this.ContextId == other.ContextId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002C3A RID: 11322 RVA: 0x000737F4 File Offset: 0x000719F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ContextId != 0L)
			{
				num ^= this.ContextId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06002C3B RID: 11323 RVA: 0x00073833 File Offset: 0x00071A33
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06002C3C RID: 11324 RVA: 0x00073840 File Offset: 0x00071A40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002C3D RID: 11325 RVA: 0x00073849 File Offset: 0x00071A49
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ContextId != 0L)
			{
				output.WriteRawTag(8);
				output.WriteInt64(this.ContextId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002C3E RID: 11326 RVA: 0x0007387C File Offset: 0x00071A7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ContextId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.ContextId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06002C3F RID: 11327 RVA: 0x000738BA File Offset: 0x00071ABA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BatchBulletCastComponentPb other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ContextId != 0L)
			{
				this.ContextId = other.ContextId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06002C40 RID: 11328 RVA: 0x000738EB File Offset: 0x00071AEB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002C41 RID: 11329 RVA: 0x000738F4 File Offset: 0x00071AF4
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
					this.ContextId = input.ReadInt64();
				}
			}
		}

		// Token: 0x0400283D RID: 10301
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400283E RID: 10302
		public const int ContextIdFieldNumber = 1;

		// Token: 0x0400283F RID: 10303
		private long contextId_;
	}
}
