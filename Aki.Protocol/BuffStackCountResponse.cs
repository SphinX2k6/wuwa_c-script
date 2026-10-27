using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200020B RID: 523
	[NetMessage(EMessageId.BuffStackCountResponse)]
	public sealed class BuffStackCountResponse : IMessage<BuffStackCountResponse>, IMessage, IEquatable<BuffStackCountResponse>, IDeepCloneable<BuffStackCountResponse>, IBufferMessage
	{
		// Token: 0x060039B5 RID: 14773 RVA: 0x000900C5 File Offset: 0x0008E2C5
		[NullableContext(1)]
		public static BuffStackCountResponse Create()
		{
			return new BuffStackCountResponse();
		}

		// Token: 0x17000977 RID: 2423
		// (get) Token: 0x060039B6 RID: 14774 RVA: 0x000900CC File Offset: 0x0008E2CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000978 RID: 2424
		// (get) Token: 0x060039B7 RID: 14775 RVA: 0x000900CF File Offset: 0x0008E2CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BuffStackCountResponse.Descriptor;
			}
		}

		// Token: 0x060039B8 RID: 14776 RVA: 0x000900D6 File Offset: 0x0008E2D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BuffStackCountResponse()
		{
		}

		// Token: 0x060039B9 RID: 14777 RVA: 0x000900DE File Offset: 0x0008E2DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BuffStackCountResponse(BuffStackCountResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060039BA RID: 14778 RVA: 0x00090103 File Offset: 0x0008E303
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BuffStackCountResponse Clone()
		{
			return new BuffStackCountResponse(this);
		}

		// Token: 0x17000979 RID: 2425
		// (get) Token: 0x060039BB RID: 14779 RVA: 0x0009010B File Offset: 0x0008E30B
		// (set) Token: 0x060039BC RID: 14780 RVA: 0x00090113 File Offset: 0x0008E313
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

		// Token: 0x060039BD RID: 14781 RVA: 0x0009011C File Offset: 0x0008E31C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BuffStackCountResponse);
		}

		// Token: 0x060039BE RID: 14782 RVA: 0x0009012A File Offset: 0x0008E32A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BuffStackCountResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060039BF RID: 14783 RVA: 0x00090158 File Offset: 0x0008E358
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

		// Token: 0x060039C0 RID: 14784 RVA: 0x0009019D File Offset: 0x0008E39D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060039C1 RID: 14785 RVA: 0x000901AA File Offset: 0x0008E3AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060039C2 RID: 14786 RVA: 0x000901B3 File Offset: 0x0008E3B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(104);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060039C3 RID: 14787 RVA: 0x000901E8 File Offset: 0x0008E3E8
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

		// Token: 0x060039C4 RID: 14788 RVA: 0x00090226 File Offset: 0x0008E426
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BuffStackCountResponse other)
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

		// Token: 0x060039C5 RID: 14789 RVA: 0x00090257 File Offset: 0x0008E457
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060039C6 RID: 14790 RVA: 0x00090260 File Offset: 0x0008E460
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
				if (num != 104U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04002BA2 RID: 11170
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002BA3 RID: 11171
		public const int ErrorCodeFieldNumber = 13;

		// Token: 0x04002BA4 RID: 11172
		private ErrorCode errorCode_;
	}
}
