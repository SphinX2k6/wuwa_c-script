using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000DF9 RID: 3577
	[NetMessage(EMessageId.PushDataCompleteNotify)]
	public sealed class PushDataCompleteNotify : IMessage<PushDataCompleteNotify>, IMessage, IEquatable<PushDataCompleteNotify>, IDeepCloneable<PushDataCompleteNotify>, IBufferMessage
	{
		// Token: 0x060133D7 RID: 78807 RVA: 0x002CD5B9 File Offset: 0x002CB7B9
		[NullableContext(1)]
		public static PushDataCompleteNotify Create()
		{
			return new PushDataCompleteNotify();
		}

		// Token: 0x17003FD9 RID: 16345
		// (get) Token: 0x060133D8 RID: 78808 RVA: 0x002CD5C0 File Offset: 0x002CB7C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003FDA RID: 16346
		// (get) Token: 0x060133D9 RID: 78809 RVA: 0x002CD5C3 File Offset: 0x002CB7C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PushDataCompleteNotify.Descriptor;
			}
		}

		// Token: 0x060133DA RID: 78810 RVA: 0x002CD5CA File Offset: 0x002CB7CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PushDataCompleteNotify()
		{
		}

		// Token: 0x060133DB RID: 78811 RVA: 0x002CD5D2 File Offset: 0x002CB7D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PushDataCompleteNotify(PushDataCompleteNotify other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060133DC RID: 78812 RVA: 0x002CD5EB File Offset: 0x002CB7EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PushDataCompleteNotify Clone()
		{
			return new PushDataCompleteNotify(this);
		}

		// Token: 0x060133DD RID: 78813 RVA: 0x002CD5F3 File Offset: 0x002CB7F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PushDataCompleteNotify);
		}

		// Token: 0x060133DE RID: 78814 RVA: 0x002CD601 File Offset: 0x002CB801
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PushDataCompleteNotify other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x060133DF RID: 78815 RVA: 0x002CD620 File Offset: 0x002CB820
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060133E0 RID: 78816 RVA: 0x002CD646 File Offset: 0x002CB846
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060133E1 RID: 78817 RVA: 0x002CD653 File Offset: 0x002CB853
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060133E2 RID: 78818 RVA: 0x002CD65C File Offset: 0x002CB85C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060133E3 RID: 78819 RVA: 0x002CD674 File Offset: 0x002CB874
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060133E4 RID: 78820 RVA: 0x002CD69A File Offset: 0x002CB89A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PushDataCompleteNotify other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060133E5 RID: 78821 RVA: 0x002CD6B7 File Offset: 0x002CB8B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060133E6 RID: 78822 RVA: 0x002CD6C0 File Offset: 0x002CB8C0
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
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400766A RID: 30314
		private UnknownFieldSet _unknownFields;
	}
}
