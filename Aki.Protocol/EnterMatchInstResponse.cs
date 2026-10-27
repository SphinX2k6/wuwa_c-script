using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000459 RID: 1113
	[NetMessage(EMessageId.EnterMatchInstResponse)]
	public sealed class EnterMatchInstResponse : IMessage<EnterMatchInstResponse>, IMessage, IEquatable<EnterMatchInstResponse>, IDeepCloneable<EnterMatchInstResponse>, IBufferMessage
	{
		// Token: 0x06006A6E RID: 27246 RVA: 0x0010100E File Offset: 0x000FF20E
		[NullableContext(1)]
		public static EnterMatchInstResponse Create()
		{
			return new EnterMatchInstResponse();
		}

		// Token: 0x17001428 RID: 5160
		// (get) Token: 0x06006A6F RID: 27247 RVA: 0x00101015 File Offset: 0x000FF215
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001429 RID: 5161
		// (get) Token: 0x06006A70 RID: 27248 RVA: 0x00101018 File Offset: 0x000FF218
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EnterMatchInstResponse.Descriptor;
			}
		}

		// Token: 0x06006A71 RID: 27249 RVA: 0x0010101F File Offset: 0x000FF21F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnterMatchInstResponse()
		{
		}

		// Token: 0x06006A72 RID: 27250 RVA: 0x00101027 File Offset: 0x000FF227
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnterMatchInstResponse(EnterMatchInstResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006A73 RID: 27251 RVA: 0x0010104C File Offset: 0x000FF24C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnterMatchInstResponse Clone()
		{
			return new EnterMatchInstResponse(this);
		}

		// Token: 0x1700142A RID: 5162
		// (get) Token: 0x06006A74 RID: 27252 RVA: 0x00101054 File Offset: 0x000FF254
		// (set) Token: 0x06006A75 RID: 27253 RVA: 0x0010105C File Offset: 0x000FF25C
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

		// Token: 0x06006A76 RID: 27254 RVA: 0x00101065 File Offset: 0x000FF265
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EnterMatchInstResponse);
		}

		// Token: 0x06006A77 RID: 27255 RVA: 0x00101073 File Offset: 0x000FF273
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EnterMatchInstResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006A78 RID: 27256 RVA: 0x001010A4 File Offset: 0x000FF2A4
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

		// Token: 0x06006A79 RID: 27257 RVA: 0x001010E9 File Offset: 0x000FF2E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06006A7A RID: 27258 RVA: 0x001010F6 File Offset: 0x000FF2F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006A7B RID: 27259 RVA: 0x001010FF File Offset: 0x000FF2FF
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

		// Token: 0x06006A7C RID: 27260 RVA: 0x00101134 File Offset: 0x000FF334
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

		// Token: 0x06006A7D RID: 27261 RVA: 0x00101172 File Offset: 0x000FF372
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EnterMatchInstResponse other)
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

		// Token: 0x06006A7E RID: 27262 RVA: 0x001011A3 File Offset: 0x000FF3A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006A7F RID: 27263 RVA: 0x001011AC File Offset: 0x000FF3AC
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

		// Token: 0x04003A4F RID: 14927
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003A50 RID: 14928
		public const int ErrorCodeFieldNumber = 13;

		// Token: 0x04003A51 RID: 14929
		private ErrorCode errorCode_;
	}
}
