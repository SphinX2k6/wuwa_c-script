using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000210 RID: 528
	[NetMessage(EMessageId.BuffStackCountResponse)]
	public sealed class BuffStackCountResponse : IMessage<BuffStackCountResponse>, IMessage, IEquatable<BuffStackCountResponse>, IDeepCloneable<BuffStackCountResponse>, IBufferMessage
	{
		// Token: 0x06003A5A RID: 14938 RVA: 0x00091CD9 File Offset: 0x0008FED9
		[NullableContext(1)]
		public static BuffStackCountResponse Create()
		{
			return new BuffStackCountResponse();
		}

		// Token: 0x17000996 RID: 2454
		// (get) Token: 0x06003A5B RID: 14939 RVA: 0x00091CE0 File Offset: 0x0008FEE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000997 RID: 2455
		// (get) Token: 0x06003A5C RID: 14940 RVA: 0x00091CE3 File Offset: 0x0008FEE3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BuffStackCountResponse.Descriptor;
			}
		}

		// Token: 0x06003A5D RID: 14941 RVA: 0x00091CEA File Offset: 0x0008FEEA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BuffStackCountResponse()
		{
		}

		// Token: 0x06003A5E RID: 14942 RVA: 0x00091CF2 File Offset: 0x0008FEF2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BuffStackCountResponse(BuffStackCountResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003A5F RID: 14943 RVA: 0x00091D17 File Offset: 0x0008FF17
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BuffStackCountResponse Clone()
		{
			return new BuffStackCountResponse(this);
		}

		// Token: 0x17000998 RID: 2456
		// (get) Token: 0x06003A60 RID: 14944 RVA: 0x00091D1F File Offset: 0x0008FF1F
		// (set) Token: 0x06003A61 RID: 14945 RVA: 0x00091D27 File Offset: 0x0008FF27
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

		// Token: 0x06003A62 RID: 14946 RVA: 0x00091D30 File Offset: 0x0008FF30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BuffStackCountResponse);
		}

		// Token: 0x06003A63 RID: 14947 RVA: 0x00091D3E File Offset: 0x0008FF3E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BuffStackCountResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003A64 RID: 14948 RVA: 0x00091D6C File Offset: 0x0008FF6C
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

		// Token: 0x06003A65 RID: 14949 RVA: 0x00091DB1 File Offset: 0x0008FFB1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06003A66 RID: 14950 RVA: 0x00091DBE File Offset: 0x0008FFBE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003A67 RID: 14951 RVA: 0x00091DC7 File Offset: 0x0008FFC7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(80);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003A68 RID: 14952 RVA: 0x00091DFC File Offset: 0x0008FFFC
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

		// Token: 0x06003A69 RID: 14953 RVA: 0x00091E3A File Offset: 0x0009003A
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

		// Token: 0x06003A6A RID: 14954 RVA: 0x00091E6B File Offset: 0x0009006B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003A6B RID: 14955 RVA: 0x00091E74 File Offset: 0x00090074
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
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04002C24 RID: 11300
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002C25 RID: 11301
		public const int ErrorCodeFieldNumber = 10;

		// Token: 0x04002C26 RID: 11302
		private ErrorCode errorCode_;
	}
}
