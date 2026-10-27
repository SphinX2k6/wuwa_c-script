using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000551 RID: 1361
	[NetMessage(EMessageId.FishingEntrustAcceptResponse)]
	public sealed class FishingEntrustAcceptResponse : IMessage<FishingEntrustAcceptResponse>, IMessage, IEquatable<FishingEntrustAcceptResponse>, IDeepCloneable<FishingEntrustAcceptResponse>, IBufferMessage
	{
		// Token: 0x06007F2B RID: 32555 RVA: 0x00133B5F File Offset: 0x00131D5F
		[NullableContext(1)]
		public static FishingEntrustAcceptResponse Create()
		{
			return new FishingEntrustAcceptResponse();
		}

		// Token: 0x170018C2 RID: 6338
		// (get) Token: 0x06007F2C RID: 32556 RVA: 0x00133B66 File Offset: 0x00131D66
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170018C3 RID: 6339
		// (get) Token: 0x06007F2D RID: 32557 RVA: 0x00133B69 File Offset: 0x00131D69
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FishingEntrustAcceptResponse.Descriptor;
			}
		}

		// Token: 0x06007F2E RID: 32558 RVA: 0x00133B70 File Offset: 0x00131D70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingEntrustAcceptResponse()
		{
		}

		// Token: 0x06007F2F RID: 32559 RVA: 0x00133B78 File Offset: 0x00131D78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingEntrustAcceptResponse(FishingEntrustAcceptResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007F30 RID: 32560 RVA: 0x00133B9D File Offset: 0x00131D9D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingEntrustAcceptResponse Clone()
		{
			return new FishingEntrustAcceptResponse(this);
		}

		// Token: 0x170018C4 RID: 6340
		// (get) Token: 0x06007F31 RID: 32561 RVA: 0x00133BA5 File Offset: 0x00131DA5
		// (set) Token: 0x06007F32 RID: 32562 RVA: 0x00133BAD File Offset: 0x00131DAD
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

		// Token: 0x06007F33 RID: 32563 RVA: 0x00133BB6 File Offset: 0x00131DB6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FishingEntrustAcceptResponse);
		}

		// Token: 0x06007F34 RID: 32564 RVA: 0x00133BC4 File Offset: 0x00131DC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FishingEntrustAcceptResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007F35 RID: 32565 RVA: 0x00133BF4 File Offset: 0x00131DF4
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

		// Token: 0x06007F36 RID: 32566 RVA: 0x00133C39 File Offset: 0x00131E39
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06007F37 RID: 32567 RVA: 0x00133C46 File Offset: 0x00131E46
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007F38 RID: 32568 RVA: 0x00133C4F File Offset: 0x00131E4F
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

		// Token: 0x06007F39 RID: 32569 RVA: 0x00133C84 File Offset: 0x00131E84
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

		// Token: 0x06007F3A RID: 32570 RVA: 0x00133CC2 File Offset: 0x00131EC2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FishingEntrustAcceptResponse other)
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

		// Token: 0x06007F3B RID: 32571 RVA: 0x00133CF3 File Offset: 0x00131EF3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007F3C RID: 32572 RVA: 0x00133CFC File Offset: 0x00131EFC
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

		// Token: 0x04004052 RID: 16466
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004053 RID: 16467
		public const int ErrorCodeFieldNumber = 13;

		// Token: 0x04004054 RID: 16468
		private ErrorCode errorCode_;
	}
}
