using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000244 RID: 580
	[NetMessage(EMessageId.CaughtResponse)]
	public sealed class CaughtResponse : IMessage<CaughtResponse>, IMessage, IEquatable<CaughtResponse>, IDeepCloneable<CaughtResponse>, IBufferMessage
	{
		// Token: 0x06003E7C RID: 15996 RVA: 0x0009ABE4 File Offset: 0x00098DE4
		[NullableContext(1)]
		public static CaughtResponse Create()
		{
			return new CaughtResponse();
		}

		// Token: 0x17000A71 RID: 2673
		// (get) Token: 0x06003E7D RID: 15997 RVA: 0x0009ABEB File Offset: 0x00098DEB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000A72 RID: 2674
		// (get) Token: 0x06003E7E RID: 15998 RVA: 0x0009ABEE File Offset: 0x00098DEE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CaughtResponse.Descriptor;
			}
		}

		// Token: 0x06003E7F RID: 15999 RVA: 0x0009ABF5 File Offset: 0x00098DF5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CaughtResponse()
		{
		}

		// Token: 0x06003E80 RID: 16000 RVA: 0x0009ABFD File Offset: 0x00098DFD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CaughtResponse(CaughtResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003E81 RID: 16001 RVA: 0x0009AC22 File Offset: 0x00098E22
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CaughtResponse Clone()
		{
			return new CaughtResponse(this);
		}

		// Token: 0x17000A73 RID: 2675
		// (get) Token: 0x06003E82 RID: 16002 RVA: 0x0009AC2A File Offset: 0x00098E2A
		// (set) Token: 0x06003E83 RID: 16003 RVA: 0x0009AC32 File Offset: 0x00098E32
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

		// Token: 0x06003E84 RID: 16004 RVA: 0x0009AC3B File Offset: 0x00098E3B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CaughtResponse);
		}

		// Token: 0x06003E85 RID: 16005 RVA: 0x0009AC49 File Offset: 0x00098E49
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CaughtResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003E86 RID: 16006 RVA: 0x0009AC78 File Offset: 0x00098E78
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

		// Token: 0x06003E87 RID: 16007 RVA: 0x0009ACBD File Offset: 0x00098EBD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06003E88 RID: 16008 RVA: 0x0009ACCA File Offset: 0x00098ECA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003E89 RID: 16009 RVA: 0x0009ACD3 File Offset: 0x00098ED3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(120);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003E8A RID: 16010 RVA: 0x0009AD08 File Offset: 0x00098F08
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

		// Token: 0x06003E8B RID: 16011 RVA: 0x0009AD46 File Offset: 0x00098F46
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CaughtResponse other)
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

		// Token: 0x06003E8C RID: 16012 RVA: 0x0009AD77 File Offset: 0x00098F77
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003E8D RID: 16013 RVA: 0x0009AD80 File Offset: 0x00098F80
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
				if (num != 120U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04002D45 RID: 11589
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002D46 RID: 11590
		public const int ErrorCodeFieldNumber = 15;

		// Token: 0x04002D47 RID: 11591
		private ErrorCode errorCode_;
	}
}
