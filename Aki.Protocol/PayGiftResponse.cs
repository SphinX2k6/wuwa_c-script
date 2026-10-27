using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000BDF RID: 3039
	[NetMessage(EMessageId.PayGiftResponse)]
	public sealed class PayGiftResponse : IMessage<PayGiftResponse>, IMessage, IEquatable<PayGiftResponse>, IDeepCloneable<PayGiftResponse>, IBufferMessage
	{
		// Token: 0x06010772 RID: 67442 RVA: 0x0026723C File Offset: 0x0026543C
		[NullableContext(1)]
		public static PayGiftResponse Create()
		{
			return new PayGiftResponse();
		}

		// Token: 0x1700360E RID: 13838
		// (get) Token: 0x06010773 RID: 67443 RVA: 0x00267243 File Offset: 0x00265443
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700360F RID: 13839
		// (get) Token: 0x06010774 RID: 67444 RVA: 0x00267246 File Offset: 0x00265446
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PayGiftResponse.Descriptor;
			}
		}

		// Token: 0x06010775 RID: 67445 RVA: 0x0026724D File Offset: 0x0026544D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PayGiftResponse()
		{
		}

		// Token: 0x06010776 RID: 67446 RVA: 0x0026726B File Offset: 0x0026546B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PayGiftResponse(PayGiftResponse other) : this()
		{
			this.receiptId_ = other.receiptId_;
			this.errorCode_ = other.errorCode_;
			this.callbackUrl_ = other.callbackUrl_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06010777 RID: 67447 RVA: 0x002672A8 File Offset: 0x002654A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PayGiftResponse Clone()
		{
			return new PayGiftResponse(this);
		}

		// Token: 0x17003610 RID: 13840
		// (get) Token: 0x06010778 RID: 67448 RVA: 0x002672B0 File Offset: 0x002654B0
		// (set) Token: 0x06010779 RID: 67449 RVA: 0x002672B8 File Offset: 0x002654B8
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

		// Token: 0x17003611 RID: 13841
		// (get) Token: 0x0601077A RID: 67450 RVA: 0x002672CB File Offset: 0x002654CB
		// (set) Token: 0x0601077B RID: 67451 RVA: 0x002672D3 File Offset: 0x002654D3
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

		// Token: 0x17003612 RID: 13842
		// (get) Token: 0x0601077C RID: 67452 RVA: 0x002672DC File Offset: 0x002654DC
		// (set) Token: 0x0601077D RID: 67453 RVA: 0x002672E4 File Offset: 0x002654E4
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

		// Token: 0x0601077E RID: 67454 RVA: 0x002672F7 File Offset: 0x002654F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PayGiftResponse);
		}

		// Token: 0x0601077F RID: 67455 RVA: 0x00267308 File Offset: 0x00265508
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PayGiftResponse other)
		{
			return other != null && (other == this || (!(this.ReceiptId != other.ReceiptId) && this.ErrorCode == other.ErrorCode && !(this.CallbackUrl != other.CallbackUrl) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06010780 RID: 67456 RVA: 0x0026736C File Offset: 0x0026556C
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

		// Token: 0x06010781 RID: 67457 RVA: 0x002673E7 File Offset: 0x002655E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06010782 RID: 67458 RVA: 0x002673F4 File Offset: 0x002655F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06010783 RID: 67459 RVA: 0x00267400 File Offset: 0x00265600
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ReceiptId.Length != 0)
			{
				output.WriteRawTag(66);
				output.WriteString(this.ReceiptId);
			}
			if (this.CallbackUrl.Length != 0)
			{
				output.WriteRawTag(74);
				output.WriteString(this.CallbackUrl);
			}
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

		// Token: 0x06010784 RID: 67460 RVA: 0x00267480 File Offset: 0x00265680
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

		// Token: 0x06010785 RID: 67461 RVA: 0x002674F8 File Offset: 0x002656F8
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

		// Token: 0x06010786 RID: 67462 RVA: 0x00267566 File Offset: 0x00265766
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06010787 RID: 67463 RVA: 0x00267570 File Offset: 0x00265770
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
				if (num != 66U)
				{
					if (num != 74U)
					{
						if (num != 104U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.ErrorCode = (ErrorCode)input.ReadEnum();
						}
					}
					else
					{
						this.CallbackUrl = input.ReadString();
					}
				}
				else
				{
					this.ReceiptId = input.ReadString();
				}
			}
		}

		// Token: 0x0400687C RID: 26748
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400687D RID: 26749
		public const int ReceiptIdFieldNumber = 8;

		// Token: 0x0400687E RID: 26750
		private string receiptId_ = "";

		// Token: 0x0400687F RID: 26751
		public const int ErrorCodeFieldNumber = 13;

		// Token: 0x04006880 RID: 26752
		private ErrorCode errorCode_;

		// Token: 0x04006881 RID: 26753
		public const int CallbackUrlFieldNumber = 9;

		// Token: 0x04006882 RID: 26754
		private string callbackUrl_ = "";
	}
}
