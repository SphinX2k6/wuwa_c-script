using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020006CA RID: 1738
	[NetMessage(EMessageId.GetInstExchangeRewardResponse)]
	public sealed class GetInstExchangeRewardResponse : IMessage<GetInstExchangeRewardResponse>, IMessage, IEquatable<GetInstExchangeRewardResponse>, IDeepCloneable<GetInstExchangeRewardResponse>, IBufferMessage
	{
		// Token: 0x06009EEF RID: 40687 RVA: 0x001817DD File Offset: 0x0017F9DD
		[NullableContext(1)]
		public static GetInstExchangeRewardResponse Create()
		{
			return new GetInstExchangeRewardResponse();
		}

		// Token: 0x17001FEE RID: 8174
		// (get) Token: 0x06009EF0 RID: 40688 RVA: 0x001817E4 File Offset: 0x0017F9E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001FEF RID: 8175
		// (get) Token: 0x06009EF1 RID: 40689 RVA: 0x001817E7 File Offset: 0x0017F9E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetInstExchangeRewardResponse.Descriptor;
			}
		}

		// Token: 0x06009EF2 RID: 40690 RVA: 0x001817EE File Offset: 0x0017F9EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetInstExchangeRewardResponse()
		{
		}

		// Token: 0x06009EF3 RID: 40691 RVA: 0x001817F6 File Offset: 0x0017F9F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetInstExchangeRewardResponse(GetInstExchangeRewardResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009EF4 RID: 40692 RVA: 0x0018181B File Offset: 0x0017FA1B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetInstExchangeRewardResponse Clone()
		{
			return new GetInstExchangeRewardResponse(this);
		}

		// Token: 0x17001FF0 RID: 8176
		// (get) Token: 0x06009EF5 RID: 40693 RVA: 0x00181823 File Offset: 0x0017FA23
		// (set) Token: 0x06009EF6 RID: 40694 RVA: 0x0018182B File Offset: 0x0017FA2B
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

		// Token: 0x06009EF7 RID: 40695 RVA: 0x00181834 File Offset: 0x0017FA34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetInstExchangeRewardResponse);
		}

		// Token: 0x06009EF8 RID: 40696 RVA: 0x00181842 File Offset: 0x0017FA42
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetInstExchangeRewardResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009EF9 RID: 40697 RVA: 0x00181870 File Offset: 0x0017FA70
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

		// Token: 0x06009EFA RID: 40698 RVA: 0x001818B5 File Offset: 0x0017FAB5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06009EFB RID: 40699 RVA: 0x001818C2 File Offset: 0x0017FAC2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009EFC RID: 40700 RVA: 0x001818CB File Offset: 0x0017FACB
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

		// Token: 0x06009EFD RID: 40701 RVA: 0x00181900 File Offset: 0x0017FB00
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

		// Token: 0x06009EFE RID: 40702 RVA: 0x0018193E File Offset: 0x0017FB3E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetInstExchangeRewardResponse other)
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

		// Token: 0x06009EFF RID: 40703 RVA: 0x0018196F File Offset: 0x0017FB6F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009F00 RID: 40704 RVA: 0x00181978 File Offset: 0x0017FB78
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

		// Token: 0x04004A4E RID: 19022
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004A4F RID: 19023
		public const int ErrorCodeFieldNumber = 7;

		// Token: 0x04004A50 RID: 19024
		private ErrorCode errorCode_;
	}
}
