using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020006B6 RID: 1718
	[NetMessage(EMessageId.GetInstExchangeRewardResponse)]
	public sealed class GetInstExchangeRewardResponse : IMessage<GetInstExchangeRewardResponse>, IMessage, IEquatable<GetInstExchangeRewardResponse>, IDeepCloneable<GetInstExchangeRewardResponse>, IBufferMessage
	{
		// Token: 0x06009D99 RID: 40345 RVA: 0x0017EDA9 File Offset: 0x0017CFA9
		[NullableContext(1)]
		public static GetInstExchangeRewardResponse Create()
		{
			return new GetInstExchangeRewardResponse();
		}

		// Token: 0x17001FA4 RID: 8100
		// (get) Token: 0x06009D9A RID: 40346 RVA: 0x0017EDB0 File Offset: 0x0017CFB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001FA5 RID: 8101
		// (get) Token: 0x06009D9B RID: 40347 RVA: 0x0017EDB3 File Offset: 0x0017CFB3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetInstExchangeRewardResponse.Descriptor;
			}
		}

		// Token: 0x06009D9C RID: 40348 RVA: 0x0017EDBA File Offset: 0x0017CFBA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetInstExchangeRewardResponse()
		{
		}

		// Token: 0x06009D9D RID: 40349 RVA: 0x0017EDC2 File Offset: 0x0017CFC2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetInstExchangeRewardResponse(GetInstExchangeRewardResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009D9E RID: 40350 RVA: 0x0017EDE7 File Offset: 0x0017CFE7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetInstExchangeRewardResponse Clone()
		{
			return new GetInstExchangeRewardResponse(this);
		}

		// Token: 0x17001FA6 RID: 8102
		// (get) Token: 0x06009D9F RID: 40351 RVA: 0x0017EDEF File Offset: 0x0017CFEF
		// (set) Token: 0x06009DA0 RID: 40352 RVA: 0x0017EDF7 File Offset: 0x0017CFF7
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

		// Token: 0x06009DA1 RID: 40353 RVA: 0x0017EE00 File Offset: 0x0017D000
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetInstExchangeRewardResponse);
		}

		// Token: 0x06009DA2 RID: 40354 RVA: 0x0017EE0E File Offset: 0x0017D00E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetInstExchangeRewardResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009DA3 RID: 40355 RVA: 0x0017EE3C File Offset: 0x0017D03C
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

		// Token: 0x06009DA4 RID: 40356 RVA: 0x0017EE81 File Offset: 0x0017D081
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06009DA5 RID: 40357 RVA: 0x0017EE8E File Offset: 0x0017D08E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009DA6 RID: 40358 RVA: 0x0017EE97 File Offset: 0x0017D097
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

		// Token: 0x06009DA7 RID: 40359 RVA: 0x0017EECC File Offset: 0x0017D0CC
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

		// Token: 0x06009DA8 RID: 40360 RVA: 0x0017EF0A File Offset: 0x0017D10A
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

		// Token: 0x06009DA9 RID: 40361 RVA: 0x0017EF3B File Offset: 0x0017D13B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009DAA RID: 40362 RVA: 0x0017EF44 File Offset: 0x0017D144
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

		// Token: 0x04004A47 RID: 19015
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004A48 RID: 19016
		public const int ErrorCodeFieldNumber = 13;

		// Token: 0x04004A49 RID: 19017
		private ErrorCode errorCode_;
	}
}
