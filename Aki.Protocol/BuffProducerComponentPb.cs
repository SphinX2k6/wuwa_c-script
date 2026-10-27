using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000206 RID: 518
	public sealed class BuffProducerComponentPb : IMessage<BuffProducerComponentPb>, IMessage, IEquatable<BuffProducerComponentPb>, IDeepCloneable<BuffProducerComponentPb>, IBufferMessage
	{
		// Token: 0x06003931 RID: 14641 RVA: 0x0008EA93 File Offset: 0x0008CC93
		[NullableContext(1)]
		public static BuffProducerComponentPb Create()
		{
			return new BuffProducerComponentPb();
		}

		// Token: 0x17000953 RID: 2387
		// (get) Token: 0x06003932 RID: 14642 RVA: 0x0008EA9A File Offset: 0x0008CC9A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000954 RID: 2388
		// (get) Token: 0x06003933 RID: 14643 RVA: 0x0008EA9D File Offset: 0x0008CC9D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BuffProducerComponentPb.Descriptor;
			}
		}

		// Token: 0x06003934 RID: 14644 RVA: 0x0008EAA4 File Offset: 0x0008CCA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BuffProducerComponentPb()
		{
		}

		// Token: 0x06003935 RID: 14645 RVA: 0x0008EAAC File Offset: 0x0008CCAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BuffProducerComponentPb(BuffProducerComponentPb other) : this()
		{
			this.contextId_ = other.contextId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003936 RID: 14646 RVA: 0x0008EAD1 File Offset: 0x0008CCD1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BuffProducerComponentPb Clone()
		{
			return new BuffProducerComponentPb(this);
		}

		// Token: 0x17000955 RID: 2389
		// (get) Token: 0x06003937 RID: 14647 RVA: 0x0008EAD9 File Offset: 0x0008CCD9
		// (set) Token: 0x06003938 RID: 14648 RVA: 0x0008EAE1 File Offset: 0x0008CCE1
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

		// Token: 0x06003939 RID: 14649 RVA: 0x0008EAEA File Offset: 0x0008CCEA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BuffProducerComponentPb);
		}

		// Token: 0x0600393A RID: 14650 RVA: 0x0008EAF8 File Offset: 0x0008CCF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BuffProducerComponentPb other)
		{
			return other != null && (other == this || (this.ContextId == other.ContextId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600393B RID: 14651 RVA: 0x0008EB28 File Offset: 0x0008CD28
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

		// Token: 0x0600393C RID: 14652 RVA: 0x0008EB67 File Offset: 0x0008CD67
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600393D RID: 14653 RVA: 0x0008EB74 File Offset: 0x0008CD74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600393E RID: 14654 RVA: 0x0008EB7D File Offset: 0x0008CD7D
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

		// Token: 0x0600393F RID: 14655 RVA: 0x0008EBB0 File Offset: 0x0008CDB0
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

		// Token: 0x06003940 RID: 14656 RVA: 0x0008EBEE File Offset: 0x0008CDEE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BuffProducerComponentPb other)
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

		// Token: 0x06003941 RID: 14657 RVA: 0x0008EC1F File Offset: 0x0008CE1F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003942 RID: 14658 RVA: 0x0008EC28 File Offset: 0x0008CE28
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

		// Token: 0x04002B6B RID: 11115
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002B6C RID: 11116
		public const int ContextIdFieldNumber = 1;

		// Token: 0x04002B6D RID: 11117
		private long contextId_;
	}
}
