using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000DE9 RID: 3561
	[NetMessage(EMessageId.PushDataCompleteNotify)]
	public sealed class PushDataCompleteNotify : IMessage<PushDataCompleteNotify>, IMessage, IEquatable<PushDataCompleteNotify>, IDeepCloneable<PushDataCompleteNotify>, IBufferMessage
	{
		// Token: 0x060132F2 RID: 78578 RVA: 0x002CBEF5 File Offset: 0x002CA0F5
		[NullableContext(1)]
		public static PushDataCompleteNotify Create()
		{
			return new PushDataCompleteNotify();
		}

		// Token: 0x17003FAF RID: 16303
		// (get) Token: 0x060132F3 RID: 78579 RVA: 0x002CBEFC File Offset: 0x002CA0FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003FB0 RID: 16304
		// (get) Token: 0x060132F4 RID: 78580 RVA: 0x002CBEFF File Offset: 0x002CA0FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PushDataCompleteNotify.Descriptor;
			}
		}

		// Token: 0x060132F5 RID: 78581 RVA: 0x002CBF06 File Offset: 0x002CA106
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PushDataCompleteNotify()
		{
		}

		// Token: 0x060132F6 RID: 78582 RVA: 0x002CBF0E File Offset: 0x002CA10E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PushDataCompleteNotify(PushDataCompleteNotify other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060132F7 RID: 78583 RVA: 0x002CBF27 File Offset: 0x002CA127
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PushDataCompleteNotify Clone()
		{
			return new PushDataCompleteNotify(this);
		}

		// Token: 0x060132F8 RID: 78584 RVA: 0x002CBF2F File Offset: 0x002CA12F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PushDataCompleteNotify);
		}

		// Token: 0x060132F9 RID: 78585 RVA: 0x002CBF3D File Offset: 0x002CA13D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PushDataCompleteNotify other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x060132FA RID: 78586 RVA: 0x002CBF5C File Offset: 0x002CA15C
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

		// Token: 0x060132FB RID: 78587 RVA: 0x002CBF82 File Offset: 0x002CA182
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060132FC RID: 78588 RVA: 0x002CBF8F File Offset: 0x002CA18F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060132FD RID: 78589 RVA: 0x002CBF98 File Offset: 0x002CA198
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060132FE RID: 78590 RVA: 0x002CBFB0 File Offset: 0x002CA1B0
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

		// Token: 0x060132FF RID: 78591 RVA: 0x002CBFD6 File Offset: 0x002CA1D6
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

		// Token: 0x06013300 RID: 78592 RVA: 0x002CBFF3 File Offset: 0x002CA1F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06013301 RID: 78593 RVA: 0x002CBFFC File Offset: 0x002CA1FC
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

		// Token: 0x04007694 RID: 30356
		private UnknownFieldSet _unknownFields;
	}
}
