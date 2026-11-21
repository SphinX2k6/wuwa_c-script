using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000517 RID: 1303
	[NetMessage(EMessageId.FarmGoldResultResponse)]
	public sealed class FarmGoldResultResponse : IMessage<FarmGoldResultResponse>, IMessage, IEquatable<FarmGoldResultResponse>, IDeepCloneable<FarmGoldResultResponse>, IBufferMessage
	{
		// Token: 0x06007AB2 RID: 31410 RVA: 0x0012A036 File Offset: 0x00128236
		[NullableContext(1)]
		public static FarmGoldResultResponse Create()
		{
			return new FarmGoldResultResponse();
		}

		// Token: 0x170017C6 RID: 6086
		// (get) Token: 0x06007AB3 RID: 31411 RVA: 0x0012A03D File Offset: 0x0012823D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170017C7 RID: 6087
		// (get) Token: 0x06007AB4 RID: 31412 RVA: 0x0012A040 File Offset: 0x00128240
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FarmGoldResultResponse.Descriptor;
			}
		}

		// Token: 0x06007AB5 RID: 31413 RVA: 0x0012A047 File Offset: 0x00128247
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FarmGoldResultResponse()
		{
		}

		// Token: 0x06007AB6 RID: 31414 RVA: 0x0012A04F File Offset: 0x0012824F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FarmGoldResultResponse(FarmGoldResultResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007AB7 RID: 31415 RVA: 0x0012A074 File Offset: 0x00128274
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FarmGoldResultResponse Clone()
		{
			return new FarmGoldResultResponse(this);
		}

		// Token: 0x170017C8 RID: 6088
		// (get) Token: 0x06007AB8 RID: 31416 RVA: 0x0012A07C File Offset: 0x0012827C
		// (set) Token: 0x06007AB9 RID: 31417 RVA: 0x0012A084 File Offset: 0x00128284
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

		// Token: 0x06007ABA RID: 31418 RVA: 0x0012A08D File Offset: 0x0012828D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FarmGoldResultResponse);
		}

		// Token: 0x06007ABB RID: 31419 RVA: 0x0012A09B File Offset: 0x0012829B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FarmGoldResultResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007ABC RID: 31420 RVA: 0x0012A0CC File Offset: 0x001282CC
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

		// Token: 0x06007ABD RID: 31421 RVA: 0x0012A111 File Offset: 0x00128311
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06007ABE RID: 31422 RVA: 0x0012A11E File Offset: 0x0012831E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007ABF RID: 31423 RVA: 0x0012A127 File Offset: 0x00128327
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

		// Token: 0x06007AC0 RID: 31424 RVA: 0x0012A15C File Offset: 0x0012835C
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

		// Token: 0x06007AC1 RID: 31425 RVA: 0x0012A19A File Offset: 0x0012839A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FarmGoldResultResponse other)
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

		// Token: 0x06007AC2 RID: 31426 RVA: 0x0012A1CB File Offset: 0x001283CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007AC3 RID: 31427 RVA: 0x0012A1D4 File Offset: 0x001283D4
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

		// Token: 0x04003F4C RID: 16204
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003F4D RID: 16205
		public const int ErrorCodeFieldNumber = 10;

		// Token: 0x04003F4E RID: 16206
		private ErrorCode errorCode_;
	}
}
