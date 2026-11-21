using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000BDD RID: 3037
	[NetMessage(EMessageId.PayShopDirectBuyResponse)]
	public sealed class PayShopDirectBuyResponse : IMessage<PayShopDirectBuyResponse>, IMessage, IEquatable<PayShopDirectBuyResponse>, IDeepCloneable<PayShopDirectBuyResponse>, IBufferMessage
	{
		// Token: 0x060107B0 RID: 67504 RVA: 0x0026889C File Offset: 0x00266A9C
		[NullableContext(1)]
		public static PayShopDirectBuyResponse Create()
		{
			return new PayShopDirectBuyResponse();
		}

		// Token: 0x17003622 RID: 13858
		// (get) Token: 0x060107B1 RID: 67505 RVA: 0x002688A3 File Offset: 0x00266AA3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003623 RID: 13859
		// (get) Token: 0x060107B2 RID: 67506 RVA: 0x002688A6 File Offset: 0x00266AA6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PayShopDirectBuyResponse.Descriptor;
			}
		}

		// Token: 0x060107B3 RID: 67507 RVA: 0x002688AD File Offset: 0x00266AAD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PayShopDirectBuyResponse()
		{
		}

		// Token: 0x060107B4 RID: 67508 RVA: 0x002688CB File Offset: 0x00266ACB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PayShopDirectBuyResponse(PayShopDirectBuyResponse other) : this()
		{
			this.receiptId_ = other.receiptId_;
			this.errorCode_ = other.errorCode_;
			this.callbackUrl_ = other.callbackUrl_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060107B5 RID: 67509 RVA: 0x00268908 File Offset: 0x00266B08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PayShopDirectBuyResponse Clone()
		{
			return new PayShopDirectBuyResponse(this);
		}

		// Token: 0x17003624 RID: 13860
		// (get) Token: 0x060107B6 RID: 67510 RVA: 0x00268910 File Offset: 0x00266B10
		// (set) Token: 0x060107B7 RID: 67511 RVA: 0x00268918 File Offset: 0x00266B18
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

		// Token: 0x17003625 RID: 13861
		// (get) Token: 0x060107B8 RID: 67512 RVA: 0x0026892B File Offset: 0x00266B2B
		// (set) Token: 0x060107B9 RID: 67513 RVA: 0x00268933 File Offset: 0x00266B33
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

		// Token: 0x17003626 RID: 13862
		// (get) Token: 0x060107BA RID: 67514 RVA: 0x0026893C File Offset: 0x00266B3C
		// (set) Token: 0x060107BB RID: 67515 RVA: 0x00268944 File Offset: 0x00266B44
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

		// Token: 0x060107BC RID: 67516 RVA: 0x00268957 File Offset: 0x00266B57
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PayShopDirectBuyResponse);
		}

		// Token: 0x060107BD RID: 67517 RVA: 0x00268968 File Offset: 0x00266B68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PayShopDirectBuyResponse other)
		{
			return other != null && (other == this || (!(this.ReceiptId != other.ReceiptId) && this.ErrorCode == other.ErrorCode && !(this.CallbackUrl != other.CallbackUrl) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060107BE RID: 67518 RVA: 0x002689CC File Offset: 0x00266BCC
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

		// Token: 0x060107BF RID: 67519 RVA: 0x00268A47 File Offset: 0x00266C47
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060107C0 RID: 67520 RVA: 0x00268A54 File Offset: 0x00266C54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060107C1 RID: 67521 RVA: 0x00268A60 File Offset: 0x00266C60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(48);
				output.WriteEnum((int)this.ErrorCode);
			}
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
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060107C2 RID: 67522 RVA: 0x00268AE0 File Offset: 0x00266CE0
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

		// Token: 0x060107C3 RID: 67523 RVA: 0x00268B58 File Offset: 0x00266D58
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

		// Token: 0x060107C4 RID: 67524 RVA: 0x00268BC6 File Offset: 0x00266DC6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060107C5 RID: 67525 RVA: 0x00268BD0 File Offset: 0x00266DD0
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
				if (num != 48U)
				{
					if (num != 66U)
					{
						if (num != 74U)
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

		// Token: 0x040068FE RID: 26878
		private UnknownFieldSet _unknownFields;

		// Token: 0x040068FF RID: 26879
		public const int ReceiptIdFieldNumber = 8;

		// Token: 0x04006900 RID: 26880
		private string receiptId_ = "";

		// Token: 0x04006901 RID: 26881
		public const int ErrorCodeFieldNumber = 6;

		// Token: 0x04006902 RID: 26882
		private ErrorCode errorCode_;

		// Token: 0x04006903 RID: 26883
		public const int CallbackUrlFieldNumber = 9;

		// Token: 0x04006904 RID: 26884
		private string callbackUrl_ = "";
	}
}
