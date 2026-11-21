using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D2D RID: 3373
	[NetMessage(EMessageId.PilotThrowOperationRequest)]
	public sealed class PilotThrowOperationRequest : IMessage<PilotThrowOperationRequest>, IMessage, IEquatable<PilotThrowOperationRequest>, IDeepCloneable<PilotThrowOperationRequest>, IBufferMessage
	{
		// Token: 0x060123A3 RID: 74659 RVA: 0x002A98ED File Offset: 0x002A7AED
		[NullableContext(1)]
		public static PilotThrowOperationRequest Create()
		{
			return new PilotThrowOperationRequest();
		}

		// Token: 0x17003C63 RID: 15459
		// (get) Token: 0x060123A4 RID: 74660 RVA: 0x002A98F4 File Offset: 0x002A7AF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003C64 RID: 15460
		// (get) Token: 0x060123A5 RID: 74661 RVA: 0x002A98F7 File Offset: 0x002A7AF7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PilotThrowOperationRequest.Descriptor;
			}
		}

		// Token: 0x060123A6 RID: 74662 RVA: 0x002A98FE File Offset: 0x002A7AFE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PilotThrowOperationRequest()
		{
		}

		// Token: 0x060123A7 RID: 74663 RVA: 0x002A9906 File Offset: 0x002A7B06
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PilotThrowOperationRequest(PilotThrowOperationRequest other) : this()
		{
			this.opType_ = other.opType_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060123A8 RID: 74664 RVA: 0x002A992B File Offset: 0x002A7B2B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PilotThrowOperationRequest Clone()
		{
			return new PilotThrowOperationRequest(this);
		}

		// Token: 0x17003C65 RID: 15461
		// (get) Token: 0x060123A9 RID: 74665 RVA: 0x002A9933 File Offset: 0x002A7B33
		// (set) Token: 0x060123AA RID: 74666 RVA: 0x002A993B File Offset: 0x002A7B3B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PilotThrowOperationType OpType
		{
			get
			{
				return this.opType_;
			}
			set
			{
				this.opType_ = value;
			}
		}

		// Token: 0x060123AB RID: 74667 RVA: 0x002A9944 File Offset: 0x002A7B44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PilotThrowOperationRequest);
		}

		// Token: 0x060123AC RID: 74668 RVA: 0x002A9952 File Offset: 0x002A7B52
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PilotThrowOperationRequest other)
		{
			return other != null && (other == this || (this.OpType == other.OpType && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060123AD RID: 74669 RVA: 0x002A9980 File Offset: 0x002A7B80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.OpType != PilotThrowOperationType.Ptothrow)
			{
				num ^= this.OpType.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060123AE RID: 74670 RVA: 0x002A99C5 File Offset: 0x002A7BC5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060123AF RID: 74671 RVA: 0x002A99D2 File Offset: 0x002A7BD2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060123B0 RID: 74672 RVA: 0x002A99DB File Offset: 0x002A7BDB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.OpType != PilotThrowOperationType.Ptothrow)
			{
				output.WriteRawTag(80);
				output.WriteEnum((int)this.OpType);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060123B1 RID: 74673 RVA: 0x002A9A10 File Offset: 0x002A7C10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.OpType != PilotThrowOperationType.Ptothrow)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.OpType);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060123B2 RID: 74674 RVA: 0x002A9A4E File Offset: 0x002A7C4E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PilotThrowOperationRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.OpType != PilotThrowOperationType.Ptothrow)
			{
				this.OpType = other.OpType;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060123B3 RID: 74675 RVA: 0x002A9A7F File Offset: 0x002A7C7F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060123B4 RID: 74676 RVA: 0x002A9A88 File Offset: 0x002A7C88
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
				if (num != 80U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.OpType = (PilotThrowOperationType)input.ReadEnum();
				}
			}
		}

		// Token: 0x04007220 RID: 29216
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007221 RID: 29217
		public const int OpTypeFieldNumber = 10;

		// Token: 0x04007222 RID: 29218
		private PilotThrowOperationType opType_;
	}
}
