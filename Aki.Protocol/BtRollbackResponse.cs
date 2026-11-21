using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020001F5 RID: 501
	[NetMessage(EMessageId.BtRollbackResponse)]
	public sealed class BtRollbackResponse : IMessage<BtRollbackResponse>, IMessage, IEquatable<BtRollbackResponse>, IDeepCloneable<BtRollbackResponse>, IBufferMessage
	{
		// Token: 0x06003804 RID: 14340 RVA: 0x0008C4BA File Offset: 0x0008A6BA
		[NullableContext(1)]
		public static BtRollbackResponse Create()
		{
			return new BtRollbackResponse();
		}

		// Token: 0x1700090C RID: 2316
		// (get) Token: 0x06003805 RID: 14341 RVA: 0x0008C4C1 File Offset: 0x0008A6C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700090D RID: 2317
		// (get) Token: 0x06003806 RID: 14342 RVA: 0x0008C4C4 File Offset: 0x0008A6C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BtRollbackResponse.Descriptor;
			}
		}

		// Token: 0x06003807 RID: 14343 RVA: 0x0008C4CB File Offset: 0x0008A6CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BtRollbackResponse()
		{
		}

		// Token: 0x06003808 RID: 14344 RVA: 0x0008C4D3 File Offset: 0x0008A6D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BtRollbackResponse(BtRollbackResponse other) : this()
		{
			this.errorId_ = other.errorId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003809 RID: 14345 RVA: 0x0008C4F8 File Offset: 0x0008A6F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BtRollbackResponse Clone()
		{
			return new BtRollbackResponse(this);
		}

		// Token: 0x1700090E RID: 2318
		// (get) Token: 0x0600380A RID: 14346 RVA: 0x0008C500 File Offset: 0x0008A700
		// (set) Token: 0x0600380B RID: 14347 RVA: 0x0008C508 File Offset: 0x0008A708
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode ErrorId
		{
			get
			{
				return this.errorId_;
			}
			set
			{
				this.errorId_ = value;
			}
		}

		// Token: 0x0600380C RID: 14348 RVA: 0x0008C511 File Offset: 0x0008A711
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BtRollbackResponse);
		}

		// Token: 0x0600380D RID: 14349 RVA: 0x0008C51F File Offset: 0x0008A71F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BtRollbackResponse other)
		{
			return other != null && (other == this || (this.ErrorId == other.ErrorId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600380E RID: 14350 RVA: 0x0008C550 File Offset: 0x0008A750
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorId != ErrorCode.Success)
			{
				num ^= this.ErrorId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600380F RID: 14351 RVA: 0x0008C595 File Offset: 0x0008A795
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06003810 RID: 14352 RVA: 0x0008C5A2 File Offset: 0x0008A7A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003811 RID: 14353 RVA: 0x0008C5AB File Offset: 0x0008A7AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorId != ErrorCode.Success)
			{
				output.WriteRawTag(24);
				output.WriteEnum((int)this.ErrorId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003812 RID: 14354 RVA: 0x0008C5E0 File Offset: 0x0008A7E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorId != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06003813 RID: 14355 RVA: 0x0008C61E File Offset: 0x0008A81E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BtRollbackResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorId != ErrorCode.Success)
			{
				this.ErrorId = other.ErrorId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06003814 RID: 14356 RVA: 0x0008C64F File Offset: 0x0008A84F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003815 RID: 14357 RVA: 0x0008C658 File Offset: 0x0008A858
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
				if (num != 24U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorId = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04002B61 RID: 11105
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002B62 RID: 11106
		public const int ErrorIdFieldNumber = 3;

		// Token: 0x04002B63 RID: 11107
		private ErrorCode errorId_;
	}
}
