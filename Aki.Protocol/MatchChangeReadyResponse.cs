using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020009A1 RID: 2465
	[NetMessage(EMessageId.MatchChangeReadyResponse)]
	public sealed class MatchChangeReadyResponse : IMessage<MatchChangeReadyResponse>, IMessage, IEquatable<MatchChangeReadyResponse>, IDeepCloneable<MatchChangeReadyResponse>, IBufferMessage
	{
		// Token: 0x0600D8BD RID: 55485 RVA: 0x001FDBCD File Offset: 0x001FBDCD
		[NullableContext(1)]
		public static MatchChangeReadyResponse Create()
		{
			return new MatchChangeReadyResponse();
		}

		// Token: 0x17002BE0 RID: 11232
		// (get) Token: 0x0600D8BE RID: 55486 RVA: 0x001FDBD4 File Offset: 0x001FBDD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002BE1 RID: 11233
		// (get) Token: 0x0600D8BF RID: 55487 RVA: 0x001FDBD7 File Offset: 0x001FBDD7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MatchChangeReadyResponse.Descriptor;
			}
		}

		// Token: 0x0600D8C0 RID: 55488 RVA: 0x001FDBDE File Offset: 0x001FBDDE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MatchChangeReadyResponse()
		{
		}

		// Token: 0x0600D8C1 RID: 55489 RVA: 0x001FDBE6 File Offset: 0x001FBDE6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MatchChangeReadyResponse(MatchChangeReadyResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D8C2 RID: 55490 RVA: 0x001FDC0B File Offset: 0x001FBE0B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MatchChangeReadyResponse Clone()
		{
			return new MatchChangeReadyResponse(this);
		}

		// Token: 0x17002BE2 RID: 11234
		// (get) Token: 0x0600D8C3 RID: 55491 RVA: 0x001FDC13 File Offset: 0x001FBE13
		// (set) Token: 0x0600D8C4 RID: 55492 RVA: 0x001FDC1B File Offset: 0x001FBE1B
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

		// Token: 0x0600D8C5 RID: 55493 RVA: 0x001FDC24 File Offset: 0x001FBE24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MatchChangeReadyResponse);
		}

		// Token: 0x0600D8C6 RID: 55494 RVA: 0x001FDC32 File Offset: 0x001FBE32
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MatchChangeReadyResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D8C7 RID: 55495 RVA: 0x001FDC60 File Offset: 0x001FBE60
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

		// Token: 0x0600D8C8 RID: 55496 RVA: 0x001FDCA5 File Offset: 0x001FBEA5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600D8C9 RID: 55497 RVA: 0x001FDCB2 File Offset: 0x001FBEB2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D8CA RID: 55498 RVA: 0x001FDCBB File Offset: 0x001FBEBB
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

		// Token: 0x0600D8CB RID: 55499 RVA: 0x001FDCF0 File Offset: 0x001FBEF0
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

		// Token: 0x0600D8CC RID: 55500 RVA: 0x001FDD2E File Offset: 0x001FBF2E
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

		// Token: 0x0600D8CD RID: 55501 RVA: 0x001FDD5F File Offset: 0x001FBF5F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D8CE RID: 55502 RVA: 0x001FDD68 File Offset: 0x001FBF68
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

		// Token: 0x04005A96 RID: 23190
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005A97 RID: 23191
		public const int ErrorCodeFieldNumber = 13;

		// Token: 0x04005A98 RID: 23192
		private ErrorCode errorCode_;
	}
}
