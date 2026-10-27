using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000BE6 RID: 3046
	[NetMessage(EMessageId.PayItemResponse)]
	public sealed class PayItemResponse : IMessage<PayItemResponse>, IMessage, IEquatable<PayItemResponse>, IDeepCloneable<PayItemResponse>, IBufferMessage
	{
		// Token: 0x0601081C RID: 67612 RVA: 0x0026900C File Offset: 0x0026720C
		[NullableContext(1)]
		public static PayItemResponse Create()
		{
			return new PayItemResponse();
		}

		// Token: 0x17003639 RID: 13881
		// (get) Token: 0x0601081D RID: 67613 RVA: 0x00269013 File Offset: 0x00267213
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700363A RID: 13882
		// (get) Token: 0x0601081E RID: 67614 RVA: 0x00269016 File Offset: 0x00267216
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PayItemResponse.Descriptor;
			}
		}

		// Token: 0x0601081F RID: 67615 RVA: 0x0026901D File Offset: 0x0026721D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PayItemResponse()
		{
		}

		// Token: 0x06010820 RID: 67616 RVA: 0x0026903B File Offset: 0x0026723B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PayItemResponse(PayItemResponse other) : this()
		{
			this.receiptId_ = other.receiptId_;
			this.errorCode_ = other.errorCode_;
			this.callbackUrl_ = other.callbackUrl_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06010821 RID: 67617 RVA: 0x00269078 File Offset: 0x00267278
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PayItemResponse Clone()
		{
			return new PayItemResponse(this);
		}

		// Token: 0x1700363B RID: 13883
		// (get) Token: 0x06010822 RID: 67618 RVA: 0x00269080 File Offset: 0x00267280
		// (set) Token: 0x06010823 RID: 67619 RVA: 0x00269088 File Offset: 0x00267288
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

		// Token: 0x1700363C RID: 13884
		// (get) Token: 0x06010824 RID: 67620 RVA: 0x0026909B File Offset: 0x0026729B
		// (set) Token: 0x06010825 RID: 67621 RVA: 0x002690A3 File Offset: 0x002672A3
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

		// Token: 0x1700363D RID: 13885
		// (get) Token: 0x06010826 RID: 67622 RVA: 0x002690AC File Offset: 0x002672AC
		// (set) Token: 0x06010827 RID: 67623 RVA: 0x002690B4 File Offset: 0x002672B4
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

		// Token: 0x06010828 RID: 67624 RVA: 0x002690C7 File Offset: 0x002672C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PayItemResponse);
		}

		// Token: 0x06010829 RID: 67625 RVA: 0x002690D8 File Offset: 0x002672D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PayItemResponse other)
		{
			return other != null && (other == this || (!(this.ReceiptId != other.ReceiptId) && this.ErrorCode == other.ErrorCode && !(this.CallbackUrl != other.CallbackUrl) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601082A RID: 67626 RVA: 0x0026913C File Offset: 0x0026733C
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

		// Token: 0x0601082B RID: 67627 RVA: 0x002691B7 File Offset: 0x002673B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601082C RID: 67628 RVA: 0x002691C4 File Offset: 0x002673C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601082D RID: 67629 RVA: 0x002691D0 File Offset: 0x002673D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.CallbackUrl.Length != 0)
			{
				output.WriteRawTag(42);
				output.WriteString(this.CallbackUrl);
			}
			if (this.ReceiptId.Length != 0)
			{
				output.WriteRawTag(50);
				output.WriteString(this.ReceiptId);
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(120);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601082E RID: 67630 RVA: 0x00269250 File Offset: 0x00267450
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

		// Token: 0x0601082F RID: 67631 RVA: 0x002692C8 File Offset: 0x002674C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PayItemResponse other)
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

		// Token: 0x06010830 RID: 67632 RVA: 0x00269336 File Offset: 0x00267536
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06010831 RID: 67633 RVA: 0x00269340 File Offset: 0x00267540
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
				if (num != 42U)
				{
					if (num != 50U)
					{
						if (num != 120U)
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
						this.ReceiptId = input.ReadString();
					}
				}
				else
				{
					this.CallbackUrl = input.ReadString();
				}
			}
		}

		// Token: 0x040068BE RID: 26814
		private UnknownFieldSet _unknownFields;

		// Token: 0x040068BF RID: 26815
		public const int ReceiptIdFieldNumber = 6;

		// Token: 0x040068C0 RID: 26816
		private string receiptId_ = "";

		// Token: 0x040068C1 RID: 26817
		public const int ErrorCodeFieldNumber = 15;

		// Token: 0x040068C2 RID: 26818
		private ErrorCode errorCode_;

		// Token: 0x040068C3 RID: 26819
		public const int CallbackUrlFieldNumber = 5;

		// Token: 0x040068C4 RID: 26820
		private string callbackUrl_ = "";
	}
}
