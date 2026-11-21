using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000745 RID: 1861
	[NetMessage(EMessageId.HoldHandResponse)]
	public sealed class HoldHandResponse : IMessage<HoldHandResponse>, IMessage, IEquatable<HoldHandResponse>, IDeepCloneable<HoldHandResponse>, IBufferMessage
	{
		// Token: 0x0600A8FE RID: 43262 RVA: 0x001974A4 File Offset: 0x001956A4
		[NullableContext(1)]
		public static HoldHandResponse Create()
		{
			return new HoldHandResponse();
		}

		// Token: 0x17002204 RID: 8708
		// (get) Token: 0x0600A8FF RID: 43263 RVA: 0x001974AB File Offset: 0x001956AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002205 RID: 8709
		// (get) Token: 0x0600A900 RID: 43264 RVA: 0x001974AE File Offset: 0x001956AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HoldHandResponse.Descriptor;
			}
		}

		// Token: 0x0600A901 RID: 43265 RVA: 0x001974B5 File Offset: 0x001956B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HoldHandResponse()
		{
		}

		// Token: 0x0600A902 RID: 43266 RVA: 0x001974BD File Offset: 0x001956BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HoldHandResponse(HoldHandResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A903 RID: 43267 RVA: 0x001974E2 File Offset: 0x001956E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HoldHandResponse Clone()
		{
			return new HoldHandResponse(this);
		}

		// Token: 0x17002206 RID: 8710
		// (get) Token: 0x0600A904 RID: 43268 RVA: 0x001974EA File Offset: 0x001956EA
		// (set) Token: 0x0600A905 RID: 43269 RVA: 0x001974F2 File Offset: 0x001956F2
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

		// Token: 0x0600A906 RID: 43270 RVA: 0x001974FB File Offset: 0x001956FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HoldHandResponse);
		}

		// Token: 0x0600A907 RID: 43271 RVA: 0x00197509 File Offset: 0x00195709
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HoldHandResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A908 RID: 43272 RVA: 0x00197538 File Offset: 0x00195738
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

		// Token: 0x0600A909 RID: 43273 RVA: 0x0019757D File Offset: 0x0019577D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600A90A RID: 43274 RVA: 0x0019758A File Offset: 0x0019578A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A90B RID: 43275 RVA: 0x00197593 File Offset: 0x00195793
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

		// Token: 0x0600A90C RID: 43276 RVA: 0x001975C8 File Offset: 0x001957C8
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

		// Token: 0x0600A90D RID: 43277 RVA: 0x00197606 File Offset: 0x00195806
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(HoldHandResponse other)
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

		// Token: 0x0600A90E RID: 43278 RVA: 0x00197637 File Offset: 0x00195837
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A90F RID: 43279 RVA: 0x00197640 File Offset: 0x00195840
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

		// Token: 0x04004D6E RID: 19822
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004D6F RID: 19823
		public const int ErrorCodeFieldNumber = 7;

		// Token: 0x04004D70 RID: 19824
		private ErrorCode errorCode_;
	}
}
