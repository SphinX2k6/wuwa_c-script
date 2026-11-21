using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000542 RID: 1346
	[NetMessage(EMessageId.FishingEntrustTraceResponse)]
	public sealed class FishingEntrustTraceResponse : IMessage<FishingEntrustTraceResponse>, IMessage, IEquatable<FishingEntrustTraceResponse>, IDeepCloneable<FishingEntrustTraceResponse>, IBufferMessage
	{
		// Token: 0x06007E33 RID: 32307 RVA: 0x00131C1D File Offset: 0x0012FE1D
		[NullableContext(1)]
		public static FishingEntrustTraceResponse Create()
		{
			return new FishingEntrustTraceResponse();
		}

		// Token: 0x17001889 RID: 6281
		// (get) Token: 0x06007E34 RID: 32308 RVA: 0x00131C24 File Offset: 0x0012FE24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700188A RID: 6282
		// (get) Token: 0x06007E35 RID: 32309 RVA: 0x00131C27 File Offset: 0x0012FE27
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FishingEntrustTraceResponse.Descriptor;
			}
		}

		// Token: 0x06007E36 RID: 32310 RVA: 0x00131C2E File Offset: 0x0012FE2E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingEntrustTraceResponse()
		{
		}

		// Token: 0x06007E37 RID: 32311 RVA: 0x00131C36 File Offset: 0x0012FE36
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingEntrustTraceResponse(FishingEntrustTraceResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007E38 RID: 32312 RVA: 0x00131C5B File Offset: 0x0012FE5B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingEntrustTraceResponse Clone()
		{
			return new FishingEntrustTraceResponse(this);
		}

		// Token: 0x1700188B RID: 6283
		// (get) Token: 0x06007E39 RID: 32313 RVA: 0x00131C63 File Offset: 0x0012FE63
		// (set) Token: 0x06007E3A RID: 32314 RVA: 0x00131C6B File Offset: 0x0012FE6B
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

		// Token: 0x06007E3B RID: 32315 RVA: 0x00131C74 File Offset: 0x0012FE74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FishingEntrustTraceResponse);
		}

		// Token: 0x06007E3C RID: 32316 RVA: 0x00131C82 File Offset: 0x0012FE82
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FishingEntrustTraceResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007E3D RID: 32317 RVA: 0x00131CB0 File Offset: 0x0012FEB0
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

		// Token: 0x06007E3E RID: 32318 RVA: 0x00131CF5 File Offset: 0x0012FEF5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06007E3F RID: 32319 RVA: 0x00131D02 File Offset: 0x0012FF02
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007E40 RID: 32320 RVA: 0x00131D0B File Offset: 0x0012FF0B
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

		// Token: 0x06007E41 RID: 32321 RVA: 0x00131D40 File Offset: 0x0012FF40
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

		// Token: 0x06007E42 RID: 32322 RVA: 0x00131D7E File Offset: 0x0012FF7E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FishingEntrustTraceResponse other)
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

		// Token: 0x06007E43 RID: 32323 RVA: 0x00131DAF File Offset: 0x0012FFAF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007E44 RID: 32324 RVA: 0x00131DB8 File Offset: 0x0012FFB8
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

		// Token: 0x0400405F RID: 16479
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004060 RID: 16480
		public const int ErrorCodeFieldNumber = 14;

		// Token: 0x04004061 RID: 16481
		private ErrorCode errorCode_;
	}
}
