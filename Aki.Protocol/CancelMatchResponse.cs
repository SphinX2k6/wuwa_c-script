using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000232 RID: 562
	[NetMessage(EMessageId.CancelMatchResponse)]
	public sealed class CancelMatchResponse : IMessage<CancelMatchResponse>, IMessage, IEquatable<CancelMatchResponse>, IDeepCloneable<CancelMatchResponse>, IBufferMessage
	{
		// Token: 0x06003CD9 RID: 15577 RVA: 0x00096FD2 File Offset: 0x000951D2
		[NullableContext(1)]
		public static CancelMatchResponse Create()
		{
			return new CancelMatchResponse();
		}

		// Token: 0x17000A21 RID: 2593
		// (get) Token: 0x06003CDA RID: 15578 RVA: 0x00096FD9 File Offset: 0x000951D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000A22 RID: 2594
		// (get) Token: 0x06003CDB RID: 15579 RVA: 0x00096FDC File Offset: 0x000951DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CancelMatchResponse.Descriptor;
			}
		}

		// Token: 0x06003CDC RID: 15580 RVA: 0x00096FE3 File Offset: 0x000951E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CancelMatchResponse()
		{
		}

		// Token: 0x06003CDD RID: 15581 RVA: 0x00096FEB File Offset: 0x000951EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CancelMatchResponse(CancelMatchResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003CDE RID: 15582 RVA: 0x00097010 File Offset: 0x00095210
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CancelMatchResponse Clone()
		{
			return new CancelMatchResponse(this);
		}

		// Token: 0x17000A23 RID: 2595
		// (get) Token: 0x06003CDF RID: 15583 RVA: 0x00097018 File Offset: 0x00095218
		// (set) Token: 0x06003CE0 RID: 15584 RVA: 0x00097020 File Offset: 0x00095220
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

		// Token: 0x06003CE1 RID: 15585 RVA: 0x00097029 File Offset: 0x00095229
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CancelMatchResponse);
		}

		// Token: 0x06003CE2 RID: 15586 RVA: 0x00097037 File Offset: 0x00095237
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CancelMatchResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003CE3 RID: 15587 RVA: 0x00097068 File Offset: 0x00095268
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

		// Token: 0x06003CE4 RID: 15588 RVA: 0x000970AD File Offset: 0x000952AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06003CE5 RID: 15589 RVA: 0x000970BA File Offset: 0x000952BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003CE6 RID: 15590 RVA: 0x000970C3 File Offset: 0x000952C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(88);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003CE7 RID: 15591 RVA: 0x000970F8 File Offset: 0x000952F8
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

		// Token: 0x06003CE8 RID: 15592 RVA: 0x00097136 File Offset: 0x00095336
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CancelMatchResponse other)
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

		// Token: 0x06003CE9 RID: 15593 RVA: 0x00097167 File Offset: 0x00095367
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003CEA RID: 15594 RVA: 0x00097170 File Offset: 0x00095370
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
				if (num != 88U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04002C87 RID: 11399
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002C88 RID: 11400
		public const int ErrorCodeFieldNumber = 11;

		// Token: 0x04002C89 RID: 11401
		private ErrorCode errorCode_;
	}
}
