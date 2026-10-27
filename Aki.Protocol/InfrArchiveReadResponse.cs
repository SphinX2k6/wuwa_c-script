using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020007D5 RID: 2005
	[NetMessage(EMessageId.InfrArchiveReadResponse)]
	public sealed class InfrArchiveReadResponse : IMessage<InfrArchiveReadResponse>, IMessage, IEquatable<InfrArchiveReadResponse>, IDeepCloneable<InfrArchiveReadResponse>, IBufferMessage
	{
		// Token: 0x0600B42C RID: 46124 RVA: 0x001AEEE5 File Offset: 0x001AD0E5
		[NullableContext(1)]
		public static InfrArchiveReadResponse Create()
		{
			return new InfrArchiveReadResponse();
		}

		// Token: 0x1700245A RID: 9306
		// (get) Token: 0x0600B42D RID: 46125 RVA: 0x001AEEEC File Offset: 0x001AD0EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700245B RID: 9307
		// (get) Token: 0x0600B42E RID: 46126 RVA: 0x001AEEEF File Offset: 0x001AD0EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return InfrArchiveReadResponse.Descriptor;
			}
		}

		// Token: 0x0600B42F RID: 46127 RVA: 0x001AEEF6 File Offset: 0x001AD0F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrArchiveReadResponse()
		{
		}

		// Token: 0x0600B430 RID: 46128 RVA: 0x001AEEFE File Offset: 0x001AD0FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrArchiveReadResponse(InfrArchiveReadResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B431 RID: 46129 RVA: 0x001AEF23 File Offset: 0x001AD123
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrArchiveReadResponse Clone()
		{
			return new InfrArchiveReadResponse(this);
		}

		// Token: 0x1700245C RID: 9308
		// (get) Token: 0x0600B432 RID: 46130 RVA: 0x001AEF2B File Offset: 0x001AD12B
		// (set) Token: 0x0600B433 RID: 46131 RVA: 0x001AEF33 File Offset: 0x001AD133
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

		// Token: 0x0600B434 RID: 46132 RVA: 0x001AEF3C File Offset: 0x001AD13C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as InfrArchiveReadResponse);
		}

		// Token: 0x0600B435 RID: 46133 RVA: 0x001AEF4A File Offset: 0x001AD14A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(InfrArchiveReadResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B436 RID: 46134 RVA: 0x001AEF78 File Offset: 0x001AD178
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

		// Token: 0x0600B437 RID: 46135 RVA: 0x001AEFBD File Offset: 0x001AD1BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600B438 RID: 46136 RVA: 0x001AEFCA File Offset: 0x001AD1CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B439 RID: 46137 RVA: 0x001AEFD3 File Offset: 0x001AD1D3
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

		// Token: 0x0600B43A RID: 46138 RVA: 0x001AF008 File Offset: 0x001AD208
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

		// Token: 0x0600B43B RID: 46139 RVA: 0x001AF046 File Offset: 0x001AD246
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(InfrArchiveReadResponse other)
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

		// Token: 0x0600B43C RID: 46140 RVA: 0x001AF077 File Offset: 0x001AD277
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B43D RID: 46141 RVA: 0x001AF080 File Offset: 0x001AD280
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

		// Token: 0x0400503E RID: 20542
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400503F RID: 20543
		public const int ErrorCodeFieldNumber = 7;

		// Token: 0x04005040 RID: 20544
		private ErrorCode errorCode_;
	}
}
