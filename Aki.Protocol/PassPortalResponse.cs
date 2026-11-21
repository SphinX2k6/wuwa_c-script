using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000BC8 RID: 3016
	[NetMessage(EMessageId.PassPortalResponse)]
	public sealed class PassPortalResponse : IMessage<PassPortalResponse>, IMessage, IEquatable<PassPortalResponse>, IDeepCloneable<PassPortalResponse>, IBufferMessage
	{
		// Token: 0x060105A9 RID: 66985 RVA: 0x00262C4B File Offset: 0x00260E4B
		[NullableContext(1)]
		public static PassPortalResponse Create()
		{
			return new PassPortalResponse();
		}

		// Token: 0x1700359C RID: 13724
		// (get) Token: 0x060105AA RID: 66986 RVA: 0x00262C52 File Offset: 0x00260E52
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700359D RID: 13725
		// (get) Token: 0x060105AB RID: 66987 RVA: 0x00262C55 File Offset: 0x00260E55
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PassPortalResponse.Descriptor;
			}
		}

		// Token: 0x060105AC RID: 66988 RVA: 0x00262C5C File Offset: 0x00260E5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PassPortalResponse()
		{
		}

		// Token: 0x060105AD RID: 66989 RVA: 0x00262C64 File Offset: 0x00260E64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PassPortalResponse(PassPortalResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060105AE RID: 66990 RVA: 0x00262C89 File Offset: 0x00260E89
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PassPortalResponse Clone()
		{
			return new PassPortalResponse(this);
		}

		// Token: 0x1700359E RID: 13726
		// (get) Token: 0x060105AF RID: 66991 RVA: 0x00262C91 File Offset: 0x00260E91
		// (set) Token: 0x060105B0 RID: 66992 RVA: 0x00262C99 File Offset: 0x00260E99
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

		// Token: 0x060105B1 RID: 66993 RVA: 0x00262CA2 File Offset: 0x00260EA2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PassPortalResponse);
		}

		// Token: 0x060105B2 RID: 66994 RVA: 0x00262CB0 File Offset: 0x00260EB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PassPortalResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060105B3 RID: 66995 RVA: 0x00262CE0 File Offset: 0x00260EE0
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

		// Token: 0x060105B4 RID: 66996 RVA: 0x00262D25 File Offset: 0x00260F25
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060105B5 RID: 66997 RVA: 0x00262D32 File Offset: 0x00260F32
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060105B6 RID: 66998 RVA: 0x00262D3B File Offset: 0x00260F3B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(112);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060105B7 RID: 66999 RVA: 0x00262D70 File Offset: 0x00260F70
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

		// Token: 0x060105B8 RID: 67000 RVA: 0x00262DAE File Offset: 0x00260FAE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PassPortalResponse other)
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

		// Token: 0x060105B9 RID: 67001 RVA: 0x00262DDF File Offset: 0x00260FDF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060105BA RID: 67002 RVA: 0x00262DE8 File Offset: 0x00260FE8
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
				if (num != 112U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400682D RID: 26669
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400682E RID: 26670
		public const int ErrorCodeFieldNumber = 14;

		// Token: 0x0400682F RID: 26671
		private ErrorCode errorCode_;
	}
}
