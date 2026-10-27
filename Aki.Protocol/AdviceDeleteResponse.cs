using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020000CA RID: 202
	[NetMessage(EMessageId.AdviceDeleteResponse)]
	public sealed class AdviceDeleteResponse : IMessage<AdviceDeleteResponse>, IMessage, IEquatable<AdviceDeleteResponse>, IDeepCloneable<AdviceDeleteResponse>, IBufferMessage
	{
		// Token: 0x06001F8F RID: 8079 RVA: 0x00055CC5 File Offset: 0x00053EC5
		[NullableContext(1)]
		public static AdviceDeleteResponse Create()
		{
			return new AdviceDeleteResponse();
		}

		// Token: 0x170003CC RID: 972
		// (get) Token: 0x06001F90 RID: 8080 RVA: 0x00055CCC File Offset: 0x00053ECC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170003CD RID: 973
		// (get) Token: 0x06001F91 RID: 8081 RVA: 0x00055CCF File Offset: 0x00053ECF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AdviceDeleteResponse.Descriptor;
			}
		}

		// Token: 0x06001F92 RID: 8082 RVA: 0x00055CD6 File Offset: 0x00053ED6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AdviceDeleteResponse()
		{
		}

		// Token: 0x06001F93 RID: 8083 RVA: 0x00055CDE File Offset: 0x00053EDE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AdviceDeleteResponse(AdviceDeleteResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001F94 RID: 8084 RVA: 0x00055D03 File Offset: 0x00053F03
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AdviceDeleteResponse Clone()
		{
			return new AdviceDeleteResponse(this);
		}

		// Token: 0x170003CE RID: 974
		// (get) Token: 0x06001F95 RID: 8085 RVA: 0x00055D0B File Offset: 0x00053F0B
		// (set) Token: 0x06001F96 RID: 8086 RVA: 0x00055D13 File Offset: 0x00053F13
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

		// Token: 0x06001F97 RID: 8087 RVA: 0x00055D1C File Offset: 0x00053F1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AdviceDeleteResponse);
		}

		// Token: 0x06001F98 RID: 8088 RVA: 0x00055D2A File Offset: 0x00053F2A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AdviceDeleteResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001F99 RID: 8089 RVA: 0x00055D58 File Offset: 0x00053F58
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

		// Token: 0x06001F9A RID: 8090 RVA: 0x00055D9D File Offset: 0x00053F9D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06001F9B RID: 8091 RVA: 0x00055DAA File Offset: 0x00053FAA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001F9C RID: 8092 RVA: 0x00055DB3 File Offset: 0x00053FB3
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

		// Token: 0x06001F9D RID: 8093 RVA: 0x00055DE8 File Offset: 0x00053FE8
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

		// Token: 0x06001F9E RID: 8094 RVA: 0x00055E26 File Offset: 0x00054026
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AdviceDeleteResponse other)
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

		// Token: 0x06001F9F RID: 8095 RVA: 0x00055E57 File Offset: 0x00054057
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001FA0 RID: 8096 RVA: 0x00055E60 File Offset: 0x00054060
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

		// Token: 0x040023C3 RID: 9155
		private UnknownFieldSet _unknownFields;

		// Token: 0x040023C4 RID: 9156
		public const int ErrorCodeFieldNumber = 7;

		// Token: 0x040023C5 RID: 9157
		private ErrorCode errorCode_;
	}
}
