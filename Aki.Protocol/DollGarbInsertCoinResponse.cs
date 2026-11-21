using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020003D4 RID: 980
	[NetMessage(EMessageId.DollGarbInsertCoinResponse)]
	public sealed class DollGarbInsertCoinResponse : IMessage<DollGarbInsertCoinResponse>, IMessage, IEquatable<DollGarbInsertCoinResponse>, IDeepCloneable<DollGarbInsertCoinResponse>, IBufferMessage
	{
		// Token: 0x06005FBD RID: 24509 RVA: 0x000E7CB5 File Offset: 0x000E5EB5
		[NullableContext(1)]
		public static DollGarbInsertCoinResponse Create()
		{
			return new DollGarbInsertCoinResponse();
		}

		// Token: 0x170011CD RID: 4557
		// (get) Token: 0x06005FBE RID: 24510 RVA: 0x000E7CBC File Offset: 0x000E5EBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170011CE RID: 4558
		// (get) Token: 0x06005FBF RID: 24511 RVA: 0x000E7CBF File Offset: 0x000E5EBF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DollGarbInsertCoinResponse.Descriptor;
			}
		}

		// Token: 0x06005FC0 RID: 24512 RVA: 0x000E7CC6 File Offset: 0x000E5EC6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DollGarbInsertCoinResponse()
		{
		}

		// Token: 0x06005FC1 RID: 24513 RVA: 0x000E7CCE File Offset: 0x000E5ECE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DollGarbInsertCoinResponse(DollGarbInsertCoinResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005FC2 RID: 24514 RVA: 0x000E7CF3 File Offset: 0x000E5EF3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DollGarbInsertCoinResponse Clone()
		{
			return new DollGarbInsertCoinResponse(this);
		}

		// Token: 0x170011CF RID: 4559
		// (get) Token: 0x06005FC3 RID: 24515 RVA: 0x000E7CFB File Offset: 0x000E5EFB
		// (set) Token: 0x06005FC4 RID: 24516 RVA: 0x000E7D03 File Offset: 0x000E5F03
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

		// Token: 0x06005FC5 RID: 24517 RVA: 0x000E7D0C File Offset: 0x000E5F0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DollGarbInsertCoinResponse);
		}

		// Token: 0x06005FC6 RID: 24518 RVA: 0x000E7D1A File Offset: 0x000E5F1A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DollGarbInsertCoinResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005FC7 RID: 24519 RVA: 0x000E7D48 File Offset: 0x000E5F48
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

		// Token: 0x06005FC8 RID: 24520 RVA: 0x000E7D8D File Offset: 0x000E5F8D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06005FC9 RID: 24521 RVA: 0x000E7D9A File Offset: 0x000E5F9A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005FCA RID: 24522 RVA: 0x000E7DA3 File Offset: 0x000E5FA3
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

		// Token: 0x06005FCB RID: 24523 RVA: 0x000E7DD8 File Offset: 0x000E5FD8
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

		// Token: 0x06005FCC RID: 24524 RVA: 0x000E7E16 File Offset: 0x000E6016
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DollGarbInsertCoinResponse other)
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

		// Token: 0x06005FCD RID: 24525 RVA: 0x000E7E47 File Offset: 0x000E6047
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005FCE RID: 24526 RVA: 0x000E7E50 File Offset: 0x000E6050
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

		// Token: 0x04003784 RID: 14212
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003785 RID: 14213
		public const int ErrorCodeFieldNumber = 6;

		// Token: 0x04003786 RID: 14214
		private ErrorCode errorCode_;
	}
}
