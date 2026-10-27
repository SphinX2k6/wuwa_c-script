using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020009B2 RID: 2482
	[NetMessage(EMessageId.MatchChangeReadyResponse)]
	public sealed class MatchChangeReadyResponse : IMessage<MatchChangeReadyResponse>, IMessage, IEquatable<MatchChangeReadyResponse>, IDeepCloneable<MatchChangeReadyResponse>, IBufferMessage
	{
		// Token: 0x0600D9D7 RID: 55767 RVA: 0x001FFDC1 File Offset: 0x001FDFC1
		[NullableContext(1)]
		public static MatchChangeReadyResponse Create()
		{
			return new MatchChangeReadyResponse();
		}

		// Token: 0x17002C1E RID: 11294
		// (get) Token: 0x0600D9D8 RID: 55768 RVA: 0x001FFDC8 File Offset: 0x001FDFC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002C1F RID: 11295
		// (get) Token: 0x0600D9D9 RID: 55769 RVA: 0x001FFDCB File Offset: 0x001FDFCB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MatchChangeReadyResponse.Descriptor;
			}
		}

		// Token: 0x0600D9DA RID: 55770 RVA: 0x001FFDD2 File Offset: 0x001FDFD2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MatchChangeReadyResponse()
		{
		}

		// Token: 0x0600D9DB RID: 55771 RVA: 0x001FFDDA File Offset: 0x001FDFDA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MatchChangeReadyResponse(MatchChangeReadyResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D9DC RID: 55772 RVA: 0x001FFDFF File Offset: 0x001FDFFF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MatchChangeReadyResponse Clone()
		{
			return new MatchChangeReadyResponse(this);
		}

		// Token: 0x17002C20 RID: 11296
		// (get) Token: 0x0600D9DD RID: 55773 RVA: 0x001FFE07 File Offset: 0x001FE007
		// (set) Token: 0x0600D9DE RID: 55774 RVA: 0x001FFE0F File Offset: 0x001FE00F
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

		// Token: 0x0600D9DF RID: 55775 RVA: 0x001FFE18 File Offset: 0x001FE018
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MatchChangeReadyResponse);
		}

		// Token: 0x0600D9E0 RID: 55776 RVA: 0x001FFE26 File Offset: 0x001FE026
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MatchChangeReadyResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D9E1 RID: 55777 RVA: 0x001FFE54 File Offset: 0x001FE054
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

		// Token: 0x0600D9E2 RID: 55778 RVA: 0x001FFE99 File Offset: 0x001FE099
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600D9E3 RID: 55779 RVA: 0x001FFEA6 File Offset: 0x001FE0A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D9E4 RID: 55780 RVA: 0x001FFEAF File Offset: 0x001FE0AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(64);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D9E5 RID: 55781 RVA: 0x001FFEE4 File Offset: 0x001FE0E4
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

		// Token: 0x0600D9E6 RID: 55782 RVA: 0x001FFF22 File Offset: 0x001FE122
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MatchChangeReadyResponse other)
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

		// Token: 0x0600D9E7 RID: 55783 RVA: 0x001FFF53 File Offset: 0x001FE153
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D9E8 RID: 55784 RVA: 0x001FFF5C File Offset: 0x001FE15C
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
				if (num != 64U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04005A8D RID: 23181
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005A8E RID: 23182
		public const int ErrorCodeFieldNumber = 8;

		// Token: 0x04005A8F RID: 23183
		private ErrorCode errorCode_;
	}
}
