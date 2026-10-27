using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol.Ai
{
	// Token: 0x020016B2 RID: 5810
	[NetMessage(EMessageId.AiHateResponse)]
	public sealed class AiHateResponse : IMessage<AiHateResponse>, IMessage, IEquatable<AiHateResponse>, IDeepCloneable<AiHateResponse>, IBufferMessage
	{
		// Token: 0x0601D1BF RID: 119231 RVA: 0x00442419 File Offset: 0x00440619
		[NullableContext(1)]
		public static AiHateResponse Create()
		{
			return new AiHateResponse();
		}

		// Token: 0x170062C0 RID: 25280
		// (get) Token: 0x0601D1C0 RID: 119232 RVA: 0x00442420 File Offset: 0x00440620
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170062C1 RID: 25281
		// (get) Token: 0x0601D1C1 RID: 119233 RVA: 0x00442423 File Offset: 0x00440623
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AiHateResponse.Descriptor;
			}
		}

		// Token: 0x0601D1C2 RID: 119234 RVA: 0x0044242A File Offset: 0x0044062A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AiHateResponse()
		{
		}

		// Token: 0x0601D1C3 RID: 119235 RVA: 0x00442432 File Offset: 0x00440632
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AiHateResponse(AiHateResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601D1C4 RID: 119236 RVA: 0x00442457 File Offset: 0x00440657
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AiHateResponse Clone()
		{
			return new AiHateResponse(this);
		}

		// Token: 0x170062C2 RID: 25282
		// (get) Token: 0x0601D1C5 RID: 119237 RVA: 0x0044245F File Offset: 0x0044065F
		// (set) Token: 0x0601D1C6 RID: 119238 RVA: 0x00442467 File Offset: 0x00440667
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

		// Token: 0x0601D1C7 RID: 119239 RVA: 0x00442470 File Offset: 0x00440670
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AiHateResponse);
		}

		// Token: 0x0601D1C8 RID: 119240 RVA: 0x0044247E File Offset: 0x0044067E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AiHateResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601D1C9 RID: 119241 RVA: 0x004424AC File Offset: 0x004406AC
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

		// Token: 0x0601D1CA RID: 119242 RVA: 0x004424F1 File Offset: 0x004406F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601D1CB RID: 119243 RVA: 0x004424FE File Offset: 0x004406FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601D1CC RID: 119244 RVA: 0x00442507 File Offset: 0x00440707
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(72);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601D1CD RID: 119245 RVA: 0x0044253C File Offset: 0x0044073C
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

		// Token: 0x0601D1CE RID: 119246 RVA: 0x0044257A File Offset: 0x0044077A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AiHateResponse other)
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

		// Token: 0x0601D1CF RID: 119247 RVA: 0x004425AB File Offset: 0x004407AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601D1D0 RID: 119248 RVA: 0x004425B4 File Offset: 0x004407B4
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
				if (num != 72U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400C44C RID: 50252
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400C44D RID: 50253
		public const int ErrorCodeFieldNumber = 9;

		// Token: 0x0400C44E RID: 50254
		private ErrorCode errorCode_;
	}
}
