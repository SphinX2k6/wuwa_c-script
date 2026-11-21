using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000BD6 RID: 3030
	[NetMessage(EMessageId.PayItemResponse)]
	public sealed class PayItemResponse : IMessage<PayItemResponse>, IMessage, IEquatable<PayItemResponse>, IDeepCloneable<PayItemResponse>, IBufferMessage
	{
		// Token: 0x06010718 RID: 67352 RVA: 0x0026714B File Offset: 0x0026534B
		[NullableContext(1)]
		public static PayItemResponse Create()
		{
			return new PayItemResponse();
		}

		// Token: 0x17003600 RID: 13824
		// (get) Token: 0x06010719 RID: 67353 RVA: 0x00267152 File Offset: 0x00265352
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003601 RID: 13825
		// (get) Token: 0x0601071A RID: 67354 RVA: 0x00267155 File Offset: 0x00265355
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PayItemResponse.Descriptor;
			}
		}

		// Token: 0x0601071B RID: 67355 RVA: 0x0026715C File Offset: 0x0026535C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PayItemResponse()
		{
		}

		// Token: 0x0601071C RID: 67356 RVA: 0x0026717A File Offset: 0x0026537A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PayItemResponse(PayItemResponse other) : this()
		{
			this.receiptId_ = other.receiptId_;
			this.errorCode_ = other.errorCode_;
			this.callbackUrl_ = other.callbackUrl_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601071D RID: 67357 RVA: 0x002671B7 File Offset: 0x002653B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PayItemResponse Clone()
		{
			return new PayItemResponse(this);
		}

		// Token: 0x17003602 RID: 13826
		// (get) Token: 0x0601071E RID: 67358 RVA: 0x002671BF File Offset: 0x002653BF
		// (set) Token: 0x0601071F RID: 67359 RVA: 0x002671C7 File Offset: 0x002653C7
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

		// Token: 0x17003603 RID: 13827
		// (get) Token: 0x06010720 RID: 67360 RVA: 0x002671DA File Offset: 0x002653DA
		// (set) Token: 0x06010721 RID: 67361 RVA: 0x002671E2 File Offset: 0x002653E2
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

		// Token: 0x17003604 RID: 13828
		// (get) Token: 0x06010722 RID: 67362 RVA: 0x002671EB File Offset: 0x002653EB
		// (set) Token: 0x06010723 RID: 67363 RVA: 0x002671F3 File Offset: 0x002653F3
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

		// Token: 0x06010724 RID: 67364 RVA: 0x00267206 File Offset: 0x00265406
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PayItemResponse);
		}

		// Token: 0x06010725 RID: 67365 RVA: 0x00267214 File Offset: 0x00265414
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PayItemResponse other)
		{
			return other != null && (other == this || (!(this.ReceiptId != other.ReceiptId) && this.ErrorCode == other.ErrorCode && !(this.CallbackUrl != other.CallbackUrl) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06010726 RID: 67366 RVA: 0x00267278 File Offset: 0x00265478
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

		// Token: 0x06010727 RID: 67367 RVA: 0x002672F3 File Offset: 0x002654F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06010728 RID: 67368 RVA: 0x00267300 File Offset: 0x00265500
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06010729 RID: 67369 RVA: 0x0026730C File Offset: 0x0026550C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(32);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.CallbackUrl.Length != 0)
			{
				output.WriteRawTag(50);
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

		// Token: 0x0601072A RID: 67370 RVA: 0x0026738C File Offset: 0x0026558C
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

		// Token: 0x0601072B RID: 67371 RVA: 0x00267404 File Offset: 0x00265604
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

		// Token: 0x0601072C RID: 67372 RVA: 0x00267472 File Offset: 0x00265672
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601072D RID: 67373 RVA: 0x0026747C File Offset: 0x0026567C
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
				if (num != 32U)
				{
					if (num != 50U)
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

		// Token: 0x040068CE RID: 26830
		private UnknownFieldSet _unknownFields;

		// Token: 0x040068CF RID: 26831
		public const int ReceiptIdFieldNumber = 14;

		// Token: 0x040068D0 RID: 26832
		private string receiptId_ = "";

		// Token: 0x040068D1 RID: 26833
		public const int ErrorCodeFieldNumber = 4;

		// Token: 0x040068D2 RID: 26834
		private ErrorCode errorCode_;

		// Token: 0x040068D3 RID: 26835
		public const int CallbackUrlFieldNumber = 6;

		// Token: 0x040068D4 RID: 26836
		private string callbackUrl_ = "";
	}
}
