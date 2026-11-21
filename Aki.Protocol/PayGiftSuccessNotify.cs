using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000BD1 RID: 3025
	[NetMessage(EMessageId.PayGiftSuccessNotify)]
	public sealed class PayGiftSuccessNotify : IMessage<PayGiftSuccessNotify>, IMessage, IEquatable<PayGiftSuccessNotify>, IDeepCloneable<PayGiftSuccessNotify>, IBufferMessage
	{
		// Token: 0x06010698 RID: 67224 RVA: 0x002659F0 File Offset: 0x00263BF0
		[NullableContext(1)]
		public static PayGiftSuccessNotify Create()
		{
			return new PayGiftSuccessNotify();
		}

		// Token: 0x170035DE RID: 13790
		// (get) Token: 0x06010699 RID: 67225 RVA: 0x002659F7 File Offset: 0x00263BF7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170035DF RID: 13791
		// (get) Token: 0x0601069A RID: 67226 RVA: 0x002659FA File Offset: 0x00263BFA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PayGiftSuccessNotify.Descriptor;
			}
		}

		// Token: 0x0601069B RID: 67227 RVA: 0x00265A01 File Offset: 0x00263C01
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PayGiftSuccessNotify()
		{
		}

		// Token: 0x0601069C RID: 67228 RVA: 0x00265A14 File Offset: 0x00263C14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PayGiftSuccessNotify(PayGiftSuccessNotify other) : this()
		{
			this.id_ = other.id_;
			this.receiptId_ = other.receiptId_;
			this.itemId_ = other.itemId_;
			this.itemCount_ = other.itemCount_;
			this.payGiftInfo_ = ((other.payGiftInfo_ != null) ? other.payGiftInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601069D RID: 67229 RVA: 0x00265A84 File Offset: 0x00263C84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PayGiftSuccessNotify Clone()
		{
			return new PayGiftSuccessNotify(this);
		}

		// Token: 0x170035E0 RID: 13792
		// (get) Token: 0x0601069E RID: 67230 RVA: 0x00265A8C File Offset: 0x00263C8C
		// (set) Token: 0x0601069F RID: 67231 RVA: 0x00265A94 File Offset: 0x00263C94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Id
		{
			get
			{
				return this.id_;
			}
			set
			{
				this.id_ = value;
			}
		}

		// Token: 0x170035E1 RID: 13793
		// (get) Token: 0x060106A0 RID: 67232 RVA: 0x00265A9D File Offset: 0x00263C9D
		// (set) Token: 0x060106A1 RID: 67233 RVA: 0x00265AA5 File Offset: 0x00263CA5
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

		// Token: 0x170035E2 RID: 13794
		// (get) Token: 0x060106A2 RID: 67234 RVA: 0x00265AB8 File Offset: 0x00263CB8
		// (set) Token: 0x060106A3 RID: 67235 RVA: 0x00265AC0 File Offset: 0x00263CC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ItemId
		{
			get
			{
				return this.itemId_;
			}
			set
			{
				this.itemId_ = value;
			}
		}

		// Token: 0x170035E3 RID: 13795
		// (get) Token: 0x060106A4 RID: 67236 RVA: 0x00265AC9 File Offset: 0x00263CC9
		// (set) Token: 0x060106A5 RID: 67237 RVA: 0x00265AD1 File Offset: 0x00263CD1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ItemCount
		{
			get
			{
				return this.itemCount_;
			}
			set
			{
				this.itemCount_ = value;
			}
		}

		// Token: 0x170035E4 RID: 13796
		// (get) Token: 0x060106A6 RID: 67238 RVA: 0x00265ADA File Offset: 0x00263CDA
		// (set) Token: 0x060106A7 RID: 67239 RVA: 0x00265AE2 File Offset: 0x00263CE2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PayGiftInfo PayGiftInfo
		{
			get
			{
				return this.payGiftInfo_;
			}
			set
			{
				this.payGiftInfo_ = value;
			}
		}

		// Token: 0x060106A8 RID: 67240 RVA: 0x00265AEB File Offset: 0x00263CEB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PayGiftSuccessNotify);
		}

		// Token: 0x060106A9 RID: 67241 RVA: 0x00265AFC File Offset: 0x00263CFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PayGiftSuccessNotify other)
		{
			return other != null && (other == this || (this.Id == other.Id && !(this.ReceiptId != other.ReceiptId) && this.ItemId == other.ItemId && this.ItemCount == other.ItemCount && object.Equals(this.PayGiftInfo, other.PayGiftInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060106AA RID: 67242 RVA: 0x00265B80 File Offset: 0x00263D80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.ReceiptId.Length != 0)
			{
				num ^= this.ReceiptId.GetHashCode();
			}
			if (this.ItemId != 0)
			{
				num ^= this.ItemId.GetHashCode();
			}
			if (this.ItemCount != 0)
			{
				num ^= this.ItemCount.GetHashCode();
			}
			if (this.payGiftInfo_ != null)
			{
				num ^= this.PayGiftInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060106AB RID: 67243 RVA: 0x00265C22 File Offset: 0x00263E22
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060106AC RID: 67244 RVA: 0x00265C2F File Offset: 0x00263E2F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060106AD RID: 67245 RVA: 0x00265C38 File Offset: 0x00263E38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ReceiptId.Length != 0)
			{
				output.WriteRawTag(26);
				output.WriteString(this.ReceiptId);
			}
			if (this.ItemId != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.ItemId);
			}
			if (this.ItemCount != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.ItemCount);
			}
			if (this.Id != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.Id);
			}
			if (this.payGiftInfo_ != null)
			{
				output.WriteRawTag(122);
				output.WriteMessage(this.PayGiftInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060106AE RID: 67246 RVA: 0x00265CEC File Offset: 0x00263EEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			if (this.ReceiptId.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.ReceiptId);
			}
			if (this.ItemId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ItemId);
			}
			if (this.ItemCount != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ItemCount);
			}
			if (this.payGiftInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.PayGiftInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060106AF RID: 67247 RVA: 0x00265D90 File Offset: 0x00263F90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PayGiftSuccessNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			if (other.ReceiptId.Length != 0)
			{
				this.ReceiptId = other.ReceiptId;
			}
			if (other.ItemId != 0)
			{
				this.ItemId = other.ItemId;
			}
			if (other.ItemCount != 0)
			{
				this.ItemCount = other.ItemCount;
			}
			if (other.payGiftInfo_ != null)
			{
				if (this.payGiftInfo_ == null)
				{
					this.PayGiftInfo = new PayGiftInfo();
				}
				this.PayGiftInfo.MergeFrom(other.PayGiftInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060106B0 RID: 67248 RVA: 0x00265E39 File Offset: 0x00264039
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060106B1 RID: 67249 RVA: 0x00265E44 File Offset: 0x00264044
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
				if (num <= 40U)
				{
					if (num == 26U)
					{
						this.ReceiptId = input.ReadString();
						continue;
					}
					if (num == 40U)
					{
						this.ItemId = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 88U)
					{
						this.ItemCount = input.ReadInt32();
						continue;
					}
					if (num == 112U)
					{
						this.Id = input.ReadInt32();
						continue;
					}
					if (num == 122U)
					{
						if (this.payGiftInfo_ == null)
						{
							this.PayGiftInfo = new PayGiftInfo();
						}
						input.ReadMessage(this.PayGiftInfo);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04006899 RID: 26777
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400689A RID: 26778
		public const int IdFieldNumber = 14;

		// Token: 0x0400689B RID: 26779
		private int id_;

		// Token: 0x0400689C RID: 26780
		public const int ReceiptIdFieldNumber = 3;

		// Token: 0x0400689D RID: 26781
		private string receiptId_ = "";

		// Token: 0x0400689E RID: 26782
		public const int ItemIdFieldNumber = 5;

		// Token: 0x0400689F RID: 26783
		private int itemId_;

		// Token: 0x040068A0 RID: 26784
		public const int ItemCountFieldNumber = 11;

		// Token: 0x040068A1 RID: 26785
		private int itemCount_;

		// Token: 0x040068A2 RID: 26786
		public const int PayGiftInfoFieldNumber = 15;

		// Token: 0x040068A3 RID: 26787
		private PayGiftInfo payGiftInfo_;
	}
}
