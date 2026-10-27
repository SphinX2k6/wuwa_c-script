using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020001F8 RID: 504
	public sealed class BuffConsumerComponentPb : IMessage<BuffConsumerComponentPb>, IMessage, IEquatable<BuffConsumerComponentPb>, IDeepCloneable<BuffConsumerComponentPb>, IBufferMessage
	{
		// Token: 0x06003813 RID: 14355 RVA: 0x0008C47F File Offset: 0x0008A67F
		[NullableContext(1)]
		public static BuffConsumerComponentPb Create()
		{
			return new BuffConsumerComponentPb();
		}

		// Token: 0x17000917 RID: 2327
		// (get) Token: 0x06003814 RID: 14356 RVA: 0x0008C486 File Offset: 0x0008A686
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000918 RID: 2328
		// (get) Token: 0x06003815 RID: 14357 RVA: 0x0008C489 File Offset: 0x0008A689
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BuffConsumerComponentPb.Descriptor;
			}
		}

		// Token: 0x06003816 RID: 14358 RVA: 0x0008C490 File Offset: 0x0008A690
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BuffConsumerComponentPb()
		{
		}

		// Token: 0x06003817 RID: 14359 RVA: 0x0008C498 File Offset: 0x0008A698
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BuffConsumerComponentPb(BuffConsumerComponentPb other) : this()
		{
			this.contextId_ = other.contextId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003818 RID: 14360 RVA: 0x0008C4BD File Offset: 0x0008A6BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BuffConsumerComponentPb Clone()
		{
			return new BuffConsumerComponentPb(this);
		}

		// Token: 0x17000919 RID: 2329
		// (get) Token: 0x06003819 RID: 14361 RVA: 0x0008C4C5 File Offset: 0x0008A6C5
		// (set) Token: 0x0600381A RID: 14362 RVA: 0x0008C4CD File Offset: 0x0008A6CD
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

		// Token: 0x0600381B RID: 14363 RVA: 0x0008C4D6 File Offset: 0x0008A6D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BuffConsumerComponentPb);
		}

		// Token: 0x0600381C RID: 14364 RVA: 0x0008C4E4 File Offset: 0x0008A6E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BuffConsumerComponentPb other)
		{
			return other != null && (other == this || (this.ContextId == other.ContextId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600381D RID: 14365 RVA: 0x0008C514 File Offset: 0x0008A714
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

		// Token: 0x0600381E RID: 14366 RVA: 0x0008C553 File Offset: 0x0008A753
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600381F RID: 14367 RVA: 0x0008C560 File Offset: 0x0008A760
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003820 RID: 14368 RVA: 0x0008C569 File Offset: 0x0008A769
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

		// Token: 0x06003821 RID: 14369 RVA: 0x0008C59C File Offset: 0x0008A79C
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

		// Token: 0x06003822 RID: 14370 RVA: 0x0008C5DA File Offset: 0x0008A7DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BuffConsumerComponentPb other)
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

		// Token: 0x06003823 RID: 14371 RVA: 0x0008C60B File Offset: 0x0008A80B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003824 RID: 14372 RVA: 0x0008C614 File Offset: 0x0008A814
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

		// Token: 0x04002B1C RID: 11036
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002B1D RID: 11037
		public const int ContextIdFieldNumber = 1;

		// Token: 0x04002B1E RID: 11038
		private long contextId_;
	}
}
