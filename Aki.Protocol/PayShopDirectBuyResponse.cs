using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000BED RID: 3053
	[NetMessage(EMessageId.PayShopDirectBuyResponse)]
	public sealed class PayShopDirectBuyResponse : IMessage<PayShopDirectBuyResponse>, IMessage, IEquatable<PayShopDirectBuyResponse>, IDeepCloneable<PayShopDirectBuyResponse>, IBufferMessage
	{
		// Token: 0x060108B4 RID: 67764 RVA: 0x0026A760 File Offset: 0x00268960
		[NullableContext(1)]
		public static PayShopDirectBuyResponse Create()
		{
			return new PayShopDirectBuyResponse();
		}

		// Token: 0x1700365B RID: 13915
		// (get) Token: 0x060108B5 RID: 67765 RVA: 0x0026A767 File Offset: 0x00268967
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700365C RID: 13916
		// (get) Token: 0x060108B6 RID: 67766 RVA: 0x0026A76A File Offset: 0x0026896A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PayShopDirectBuyResponse.Descriptor;
			}
		}

		// Token: 0x060108B7 RID: 67767 RVA: 0x0026A771 File Offset: 0x00268971
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PayShopDirectBuyResponse()
		{
		}

		// Token: 0x060108B8 RID: 67768 RVA: 0x0026A78F File Offset: 0x0026898F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PayShopDirectBuyResponse(PayShopDirectBuyResponse other) : this()
		{
			this.receiptId_ = other.receiptId_;
			this.errorCode_ = other.errorCode_;
			this.callbackUrl_ = other.callbackUrl_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060108B9 RID: 67769 RVA: 0x0026A7CC File Offset: 0x002689CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PayShopDirectBuyResponse Clone()
		{
			return new PayShopDirectBuyResponse(this);
		}

		// Token: 0x1700365D RID: 13917
		// (get) Token: 0x060108BA RID: 67770 RVA: 0x0026A7D4 File Offset: 0x002689D4
		// (set) Token: 0x060108BB RID: 67771 RVA: 0x0026A7DC File Offset: 0x002689DC
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

		// Token: 0x1700365E RID: 13918
		// (get) Token: 0x060108BC RID: 67772 RVA: 0x0026A7EF File Offset: 0x002689EF
		// (set) Token: 0x060108BD RID: 67773 RVA: 0x0026A7F7 File Offset: 0x002689F7
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

		// Token: 0x1700365F RID: 13919
		// (get) Token: 0x060108BE RID: 67774 RVA: 0x0026A800 File Offset: 0x00268A00
		// (set) Token: 0x060108BF RID: 67775 RVA: 0x0026A808 File Offset: 0x00268A08
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

		// Token: 0x060108C0 RID: 67776 RVA: 0x0026A81B File Offset: 0x00268A1B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PayShopDirectBuyResponse);
		}

		// Token: 0x060108C1 RID: 67777 RVA: 0x0026A82C File Offset: 0x00268A2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PayShopDirectBuyResponse other)
		{
			return other != null && (other == this || (!(this.ReceiptId != other.ReceiptId) && this.ErrorCode == other.ErrorCode && !(this.CallbackUrl != other.CallbackUrl) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060108C2 RID: 67778 RVA: 0x0026A890 File Offset: 0x00268A90
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

		// Token: 0x060108C3 RID: 67779 RVA: 0x0026A90B File Offset: 0x00268B0B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060108C4 RID: 67780 RVA: 0x0026A918 File Offset: 0x00268B18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060108C5 RID: 67781 RVA: 0x0026A924 File Offset: 0x00268B24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(8);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.ReceiptId.Length != 0)
			{
				output.WriteRawTag(42);
				output.WriteString(this.ReceiptId);
			}
			if (this.CallbackUrl.Length != 0)
			{
				output.WriteRawTag(114);
				output.WriteString(this.CallbackUrl);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060108C6 RID: 67782 RVA: 0x0026A9A4 File Offset: 0x00268BA4
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

		// Token: 0x060108C7 RID: 67783 RVA: 0x0026AA1C File Offset: 0x00268C1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PayShopDirectBuyResponse other)
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

		// Token: 0x060108C8 RID: 67784 RVA: 0x0026AA8A File Offset: 0x00268C8A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060108C9 RID: 67785 RVA: 0x0026AA94 File Offset: 0x00268C94
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
					if (num != 42U)
					{
						if (num != 114U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
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
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x040068EE RID: 26862
		private UnknownFieldSet _unknownFields;

		// Token: 0x040068EF RID: 26863
		public const int ReceiptIdFieldNumber = 5;

		// Token: 0x040068F0 RID: 26864
		private string receiptId_ = "";

		// Token: 0x040068F1 RID: 26865
		public const int ErrorCodeFieldNumber = 1;

		// Token: 0x040068F2 RID: 26866
		private ErrorCode errorCode_;

		// Token: 0x040068F3 RID: 26867
		public const int CallbackUrlFieldNumber = 14;

		// Token: 0x040068F4 RID: 26868
		private string callbackUrl_ = "";
	}
}
