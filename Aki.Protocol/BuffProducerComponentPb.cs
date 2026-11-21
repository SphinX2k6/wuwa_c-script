using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200020B RID: 523
	public sealed class BuffProducerComponentPb : IMessage<BuffProducerComponentPb>, IMessage, IEquatable<BuffProducerComponentPb>, IDeepCloneable<BuffProducerComponentPb>, IBufferMessage
	{
		// Token: 0x060039D6 RID: 14806 RVA: 0x000906A3 File Offset: 0x0008E8A3
		[NullableContext(1)]
		public static BuffProducerComponentPb Create()
		{
			return new BuffProducerComponentPb();
		}

		// Token: 0x17000972 RID: 2418
		// (get) Token: 0x060039D7 RID: 14807 RVA: 0x000906AA File Offset: 0x0008E8AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000973 RID: 2419
		// (get) Token: 0x060039D8 RID: 14808 RVA: 0x000906AD File Offset: 0x0008E8AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BuffProducerComponentPb.Descriptor;
			}
		}

		// Token: 0x060039D9 RID: 14809 RVA: 0x000906B4 File Offset: 0x0008E8B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BuffProducerComponentPb()
		{
		}

		// Token: 0x060039DA RID: 14810 RVA: 0x000906BC File Offset: 0x0008E8BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BuffProducerComponentPb(BuffProducerComponentPb other) : this()
		{
			this.contextId_ = other.contextId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060039DB RID: 14811 RVA: 0x000906E1 File Offset: 0x0008E8E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BuffProducerComponentPb Clone()
		{
			return new BuffProducerComponentPb(this);
		}

		// Token: 0x17000974 RID: 2420
		// (get) Token: 0x060039DC RID: 14812 RVA: 0x000906E9 File Offset: 0x0008E8E9
		// (set) Token: 0x060039DD RID: 14813 RVA: 0x000906F1 File Offset: 0x0008E8F1
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

		// Token: 0x060039DE RID: 14814 RVA: 0x000906FA File Offset: 0x0008E8FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BuffProducerComponentPb);
		}

		// Token: 0x060039DF RID: 14815 RVA: 0x00090708 File Offset: 0x0008E908
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BuffProducerComponentPb other)
		{
			return other != null && (other == this || (this.ContextId == other.ContextId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060039E0 RID: 14816 RVA: 0x00090738 File Offset: 0x0008E938
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

		// Token: 0x060039E1 RID: 14817 RVA: 0x00090777 File Offset: 0x0008E977
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060039E2 RID: 14818 RVA: 0x00090784 File Offset: 0x0008E984
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060039E3 RID: 14819 RVA: 0x0009078D File Offset: 0x0008E98D
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

		// Token: 0x060039E4 RID: 14820 RVA: 0x000907C0 File Offset: 0x0008E9C0
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

		// Token: 0x060039E5 RID: 14821 RVA: 0x000907FE File Offset: 0x0008E9FE
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

		// Token: 0x060039E6 RID: 14822 RVA: 0x0009082F File Offset: 0x0008EA2F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060039E7 RID: 14823 RVA: 0x00090838 File Offset: 0x0008EA38
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

		// Token: 0x04002BED RID: 11245
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002BEE RID: 11246
		public const int ContextIdFieldNumber = 1;

		// Token: 0x04002BEF RID: 11247
		private long contextId_;
	}
}
