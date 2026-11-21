using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200099E RID: 2462
	[NetMessage(EMessageId.MatchChangePlayerUiStateResponse)]
	public sealed class MatchChangePlayerUiStateResponse : IMessage<MatchChangePlayerUiStateResponse>, IMessage, IEquatable<MatchChangePlayerUiStateResponse>, IDeepCloneable<MatchChangePlayerUiStateResponse>, IBufferMessage
	{
		// Token: 0x0600D885 RID: 55429 RVA: 0x001FD595 File Offset: 0x001FB795
		[NullableContext(1)]
		public static MatchChangePlayerUiStateResponse Create()
		{
			return new MatchChangePlayerUiStateResponse();
		}

		// Token: 0x17002BD6 RID: 11222
		// (get) Token: 0x0600D886 RID: 55430 RVA: 0x001FD59C File Offset: 0x001FB79C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002BD7 RID: 11223
		// (get) Token: 0x0600D887 RID: 55431 RVA: 0x001FD59F File Offset: 0x001FB79F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MatchChangePlayerUiStateResponse.Descriptor;
			}
		}

		// Token: 0x0600D888 RID: 55432 RVA: 0x001FD5A6 File Offset: 0x001FB7A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MatchChangePlayerUiStateResponse()
		{
		}

		// Token: 0x0600D889 RID: 55433 RVA: 0x001FD5AE File Offset: 0x001FB7AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MatchChangePlayerUiStateResponse(MatchChangePlayerUiStateResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D88A RID: 55434 RVA: 0x001FD5D3 File Offset: 0x001FB7D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MatchChangePlayerUiStateResponse Clone()
		{
			return new MatchChangePlayerUiStateResponse(this);
		}

		// Token: 0x17002BD8 RID: 11224
		// (get) Token: 0x0600D88B RID: 55435 RVA: 0x001FD5DB File Offset: 0x001FB7DB
		// (set) Token: 0x0600D88C RID: 55436 RVA: 0x001FD5E3 File Offset: 0x001FB7E3
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

		// Token: 0x0600D88D RID: 55437 RVA: 0x001FD5EC File Offset: 0x001FB7EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MatchChangePlayerUiStateResponse);
		}

		// Token: 0x0600D88E RID: 55438 RVA: 0x001FD5FA File Offset: 0x001FB7FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MatchChangePlayerUiStateResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D88F RID: 55439 RVA: 0x001FD628 File Offset: 0x001FB828
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

		// Token: 0x0600D890 RID: 55440 RVA: 0x001FD66D File Offset: 0x001FB86D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600D891 RID: 55441 RVA: 0x001FD67A File Offset: 0x001FB87A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D892 RID: 55442 RVA: 0x001FD683 File Offset: 0x001FB883
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

		// Token: 0x0600D893 RID: 55443 RVA: 0x001FD6B8 File Offset: 0x001FB8B8
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

		// Token: 0x0600D894 RID: 55444 RVA: 0x001FD6F6 File Offset: 0x001FB8F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MatchChangePlayerUiStateResponse other)
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

		// Token: 0x0600D895 RID: 55445 RVA: 0x001FD727 File Offset: 0x001FB927
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D896 RID: 55446 RVA: 0x001FD730 File Offset: 0x001FB930
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

		// Token: 0x04005A8B RID: 23179
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005A8C RID: 23180
		public const int ErrorCodeFieldNumber = 11;

		// Token: 0x04005A8D RID: 23181
		private ErrorCode errorCode_;
	}
}
