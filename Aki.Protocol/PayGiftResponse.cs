using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000BCF RID: 3023
	[NetMessage(EMessageId.PayGiftResponse)]
	public sealed class PayGiftResponse : IMessage<PayGiftResponse>, IMessage, IEquatable<PayGiftResponse>, IDeepCloneable<PayGiftResponse>, IBufferMessage
	{
		// Token: 0x0601066E RID: 67182 RVA: 0x00265380 File Offset: 0x00263580
		[NullableContext(1)]
		public static PayGiftResponse Create()
		{
			return new PayGiftResponse();
		}

		// Token: 0x170035D5 RID: 13781
		// (get) Token: 0x0601066F RID: 67183 RVA: 0x00265387 File Offset: 0x00263587
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170035D6 RID: 13782
		// (get) Token: 0x06010670 RID: 67184 RVA: 0x0026538A File Offset: 0x0026358A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PayGiftResponse.Descriptor;
			}
		}

		// Token: 0x06010671 RID: 67185 RVA: 0x00265391 File Offset: 0x00263591
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PayGiftResponse()
		{
		}

		// Token: 0x06010672 RID: 67186 RVA: 0x002653AF File Offset: 0x002635AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PayGiftResponse(PayGiftResponse other) : this()
		{
			this.receiptId_ = other.receiptId_;
			this.errorCode_ = other.errorCode_;
			this.callbackUrl_ = other.callbackUrl_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06010673 RID: 67187 RVA: 0x002653EC File Offset: 0x002635EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PayGiftResponse Clone()
		{
			return new PayGiftResponse(this);
		}

		// Token: 0x170035D7 RID: 13783
		// (get) Token: 0x06010674 RID: 67188 RVA: 0x002653F4 File Offset: 0x002635F4
		// (set) Token: 0x06010675 RID: 67189 RVA: 0x002653FC File Offset: 0x002635FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string ReceiptId
		{
			get
			{
				return this.receiptId_;
			}
			set
			{
				this.receiptId_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x170035D8 RID: 13784
		// (get) Token: 0x06010676 RID: 67190 RVA: 0x0026540F File Offset: 0x0026360F
		// (set) Token: 0x06010677 RID: 67191 RVA: 0x00265417 File Offset: 0x00263617
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

		// Token: 0x170035D9 RID: 13785
		// (get) Token: 0x06010678 RID: 67192 RVA: 0x00265420 File Offset: 0x00263620
		// (set) Token: 0x06010679 RID: 67193 RVA: 0x00265428 File Offset: 0x00263628
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string CallbackUrl
		{
			get
			{
				return this.callbackUrl_;
			}
			set
			{
				this.callbackUrl_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x0601067A RID: 67194 RVA: 0x0026543B File Offset: 0x0026363B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PayGiftResponse);
		}

		// Token: 0x0601067B RID: 67195 RVA: 0x0026544C File Offset: 0x0026364C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PayGiftResponse other)
		{
			return other != null && (other == this || (!(this.ReceiptId != other.ReceiptId) && this.ErrorCode == other.ErrorCode && !(this.CallbackUrl != other.CallbackUrl) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601067C RID: 67196 RVA: 0x002654B0 File Offset: 0x002636B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ReceiptId.Length != 0)
			{
				num ^= this.ReceiptId.GetHashCode();
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.CallbackUrl.Length != 0)
			{
				num ^= this.CallbackUrl.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601067D RID: 67197 RVA: 0x0026552B File Offset: 0x0026372B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601067E RID: 67198 RVA: 0x00265538 File Offset: 0x00263738
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601067F RID: 67199 RVA: 0x00265544 File Offset: 0x00263744
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(8);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.CallbackUrl.Length != 0)
			{
				output.WriteRawTag(82);
				output.WriteString(this.CallbackUrl);
			}
			if (this.ReceiptId.Length != 0)
			{
				output.WriteRawTag(114);
				output.WriteString(this.ReceiptId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06010680 RID: 67200 RVA: 0x002655C4 File Offset: 0x002637C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ReceiptId.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.ReceiptId);
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.CallbackUrl.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.CallbackUrl);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06010681 RID: 67201 RVA: 0x0026563C File Offset: 0x0026383C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PayGiftResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ReceiptId.Length != 0)
			{
				this.ReceiptId = other.ReceiptId;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.CallbackUrl.Length != 0)
			{
				this.CallbackUrl = other.CallbackUrl;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06010682 RID: 67202 RVA: 0x002656AA File Offset: 0x002638AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06010683 RID: 67203 RVA: 0x002656B4 File Offset: 0x002638B4
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
				if (num != 8U)
				{
					if (num != 82U)
					{
						if (num != 114U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.ReceiptId = input.ReadString();
						}
					}
					else
					{
						this.CallbackUrl = input.ReadString();
					}
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400688C RID: 26764
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400688D RID: 26765
		public const int ReceiptIdFieldNumber = 14;

		// Token: 0x0400688E RID: 26766
		private string receiptId_ = "";

		// Token: 0x0400688F RID: 26767
		public const int ErrorCodeFieldNumber = 1;

		// Token: 0x04006890 RID: 26768
		private ErrorCode errorCode_;

		// Token: 0x04006891 RID: 26769
		public const int CallbackUrlFieldNumber = 10;

		// Token: 0x04006892 RID: 26770
		private string callbackUrl_ = "";
	}
}
