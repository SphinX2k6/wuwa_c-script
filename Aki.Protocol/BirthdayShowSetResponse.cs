using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020001A0 RID: 416
	[NetMessage(EMessageId.BirthdayShowSetResponse)]
	public sealed class BirthdayShowSetResponse : IMessage<BirthdayShowSetResponse>, IMessage, IEquatable<BirthdayShowSetResponse>, IDeepCloneable<BirthdayShowSetResponse>, IBufferMessage
	{
		// Token: 0x060030F7 RID: 12535 RVA: 0x0007C951 File Offset: 0x0007AB51
		[NullableContext(1)]
		public static BirthdayShowSetResponse Create()
		{
			return new BirthdayShowSetResponse();
		}

		// Token: 0x17000791 RID: 1937
		// (get) Token: 0x060030F8 RID: 12536 RVA: 0x0007C958 File Offset: 0x0007AB58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000792 RID: 1938
		// (get) Token: 0x060030F9 RID: 12537 RVA: 0x0007C95B File Offset: 0x0007AB5B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BirthdayShowSetResponse.Descriptor;
			}
		}

		// Token: 0x060030FA RID: 12538 RVA: 0x0007C962 File Offset: 0x0007AB62
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BirthdayShowSetResponse()
		{
		}

		// Token: 0x060030FB RID: 12539 RVA: 0x0007C96A File Offset: 0x0007AB6A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BirthdayShowSetResponse(BirthdayShowSetResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060030FC RID: 12540 RVA: 0x0007C98F File Offset: 0x0007AB8F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BirthdayShowSetResponse Clone()
		{
			return new BirthdayShowSetResponse(this);
		}

		// Token: 0x17000793 RID: 1939
		// (get) Token: 0x060030FD RID: 12541 RVA: 0x0007C997 File Offset: 0x0007AB97
		// (set) Token: 0x060030FE RID: 12542 RVA: 0x0007C99F File Offset: 0x0007AB9F
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

		// Token: 0x060030FF RID: 12543 RVA: 0x0007C9A8 File Offset: 0x0007ABA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BirthdayShowSetResponse);
		}

		// Token: 0x06003100 RID: 12544 RVA: 0x0007C9B6 File Offset: 0x0007ABB6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BirthdayShowSetResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003101 RID: 12545 RVA: 0x0007C9E4 File Offset: 0x0007ABE4
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

		// Token: 0x06003102 RID: 12546 RVA: 0x0007CA29 File Offset: 0x0007AC29
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06003103 RID: 12547 RVA: 0x0007CA36 File Offset: 0x0007AC36
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003104 RID: 12548 RVA: 0x0007CA3F File Offset: 0x0007AC3F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(56);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003105 RID: 12549 RVA: 0x0007CA74 File Offset: 0x0007AC74
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

		// Token: 0x06003106 RID: 12550 RVA: 0x0007CAB2 File Offset: 0x0007ACB2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BirthdayShowSetResponse other)
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

		// Token: 0x06003107 RID: 12551 RVA: 0x0007CAE3 File Offset: 0x0007ACE3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003108 RID: 12552 RVA: 0x0007CAEC File Offset: 0x0007ACEC
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
				if (num != 56U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400290F RID: 10511
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002910 RID: 10512
		public const int ErrorCodeFieldNumber = 7;

		// Token: 0x04002911 RID: 10513
		private ErrorCode errorCode_;
	}
}
