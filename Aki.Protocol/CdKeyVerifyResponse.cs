using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000241 RID: 577
	[NetMessage(EMessageId.CdKeyVerifyResponse)]
	public sealed class CdKeyVerifyResponse : IMessage<CdKeyVerifyResponse>, IMessage, IEquatable<CdKeyVerifyResponse>, IDeepCloneable<CdKeyVerifyResponse>, IBufferMessage
	{
		// Token: 0x06003DFB RID: 15867 RVA: 0x000993B1 File Offset: 0x000975B1
		[NullableContext(1)]
		public static CdKeyVerifyResponse Create()
		{
			return new CdKeyVerifyResponse();
		}

		// Token: 0x17000A58 RID: 2648
		// (get) Token: 0x06003DFC RID: 15868 RVA: 0x000993B8 File Offset: 0x000975B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000A59 RID: 2649
		// (get) Token: 0x06003DFD RID: 15869 RVA: 0x000993BB File Offset: 0x000975BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CdKeyVerifyResponse.Descriptor;
			}
		}

		// Token: 0x06003DFE RID: 15870 RVA: 0x000993C2 File Offset: 0x000975C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CdKeyVerifyResponse()
		{
		}

		// Token: 0x06003DFF RID: 15871 RVA: 0x000993CA File Offset: 0x000975CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CdKeyVerifyResponse(CdKeyVerifyResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003E00 RID: 15872 RVA: 0x000993EF File Offset: 0x000975EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CdKeyVerifyResponse Clone()
		{
			return new CdKeyVerifyResponse(this);
		}

		// Token: 0x17000A5A RID: 2650
		// (get) Token: 0x06003E01 RID: 15873 RVA: 0x000993F7 File Offset: 0x000975F7
		// (set) Token: 0x06003E02 RID: 15874 RVA: 0x000993FF File Offset: 0x000975FF
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

		// Token: 0x06003E03 RID: 15875 RVA: 0x00099408 File Offset: 0x00097608
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CdKeyVerifyResponse);
		}

		// Token: 0x06003E04 RID: 15876 RVA: 0x00099416 File Offset: 0x00097616
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CdKeyVerifyResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003E05 RID: 15877 RVA: 0x00099444 File Offset: 0x00097644
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

		// Token: 0x06003E06 RID: 15878 RVA: 0x00099489 File Offset: 0x00097689
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06003E07 RID: 15879 RVA: 0x00099496 File Offset: 0x00097696
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003E08 RID: 15880 RVA: 0x0009949F File Offset: 0x0009769F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(72);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003E09 RID: 15881 RVA: 0x000994D4 File Offset: 0x000976D4
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

		// Token: 0x06003E0A RID: 15882 RVA: 0x00099512 File Offset: 0x00097712
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CdKeyVerifyResponse other)
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

		// Token: 0x06003E0B RID: 15883 RVA: 0x00099543 File Offset: 0x00097743
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003E0C RID: 15884 RVA: 0x0009954C File Offset: 0x0009774C
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
				if (num != 72U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04002CC9 RID: 11465
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002CCA RID: 11466
		public const int ErrorCodeFieldNumber = 9;

		// Token: 0x04002CCB RID: 11467
		private ErrorCode errorCode_;
	}
}
