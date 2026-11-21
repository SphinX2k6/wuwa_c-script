using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D2E RID: 3374
	[NetMessage(EMessageId.PilotThrowOperationResponse)]
	public sealed class PilotThrowOperationResponse : IMessage<PilotThrowOperationResponse>, IMessage, IEquatable<PilotThrowOperationResponse>, IDeepCloneable<PilotThrowOperationResponse>, IBufferMessage
	{
		// Token: 0x060123B5 RID: 74677 RVA: 0x002A9ACD File Offset: 0x002A7CCD
		[NullableContext(1)]
		public static PilotThrowOperationResponse Create()
		{
			return new PilotThrowOperationResponse();
		}

		// Token: 0x17003C66 RID: 15462
		// (get) Token: 0x060123B6 RID: 74678 RVA: 0x002A9AD4 File Offset: 0x002A7CD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003C67 RID: 15463
		// (get) Token: 0x060123B7 RID: 74679 RVA: 0x002A9AD7 File Offset: 0x002A7CD7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PilotThrowOperationResponse.Descriptor;
			}
		}

		// Token: 0x060123B8 RID: 74680 RVA: 0x002A9ADE File Offset: 0x002A7CDE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PilotThrowOperationResponse()
		{
		}

		// Token: 0x060123B9 RID: 74681 RVA: 0x002A9AE6 File Offset: 0x002A7CE6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PilotThrowOperationResponse(PilotThrowOperationResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060123BA RID: 74682 RVA: 0x002A9B0B File Offset: 0x002A7D0B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PilotThrowOperationResponse Clone()
		{
			return new PilotThrowOperationResponse(this);
		}

		// Token: 0x17003C68 RID: 15464
		// (get) Token: 0x060123BB RID: 74683 RVA: 0x002A9B13 File Offset: 0x002A7D13
		// (set) Token: 0x060123BC RID: 74684 RVA: 0x002A9B1B File Offset: 0x002A7D1B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode ErrorCode
		{
			get
			{
				return this.errorCode_;
			}
			set
			{
				this.errorCode_ = value;
			}
		}

		// Token: 0x060123BD RID: 74685 RVA: 0x002A9B24 File Offset: 0x002A7D24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PilotThrowOperationResponse);
		}

		// Token: 0x060123BE RID: 74686 RVA: 0x002A9B32 File Offset: 0x002A7D32
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PilotThrowOperationResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060123BF RID: 74687 RVA: 0x002A9B60 File Offset: 0x002A7D60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060123C0 RID: 74688 RVA: 0x002A9BA5 File Offset: 0x002A7DA5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060123C1 RID: 74689 RVA: 0x002A9BB2 File Offset: 0x002A7DB2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060123C2 RID: 74690 RVA: 0x002A9BBB File Offset: 0x002A7DBB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(48);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060123C3 RID: 74691 RVA: 0x002A9BF0 File Offset: 0x002A7DF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060123C4 RID: 74692 RVA: 0x002A9C2E File Offset: 0x002A7E2E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PilotThrowOperationResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060123C5 RID: 74693 RVA: 0x002A9C5F File Offset: 0x002A7E5F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060123C6 RID: 74694 RVA: 0x002A9C68 File Offset: 0x002A7E68
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
				if (num != 48U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04007223 RID: 29219
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007224 RID: 29220
		public const int ErrorCodeFieldNumber = 6;

		// Token: 0x04007225 RID: 29221
		private ErrorCode errorCode_;
	}
}
