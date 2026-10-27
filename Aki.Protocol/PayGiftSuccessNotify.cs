using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000BE1 RID: 3041
	[NetMessage(EMessageId.PayGiftSuccessNotify)]
	public sealed class PayGiftSuccessNotify : IMessage<PayGiftSuccessNotify>, IMessage, IEquatable<PayGiftSuccessNotify>, IDeepCloneable<PayGiftSuccessNotify>, IBufferMessage
	{
		// Token: 0x0601079C RID: 67484 RVA: 0x002678B0 File Offset: 0x00265AB0
		[NullableContext(1)]
		public static PayGiftSuccessNotify Create()
		{
			return new PayGiftSuccessNotify();
		}

		// Token: 0x17003617 RID: 13847
		// (get) Token: 0x0601079D RID: 67485 RVA: 0x002678B7 File Offset: 0x00265AB7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003618 RID: 13848
		// (get) Token: 0x0601079E RID: 67486 RVA: 0x002678BA File Offset: 0x00265ABA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PayGiftSuccessNotify.Descriptor;
			}
		}

		// Token: 0x0601079F RID: 67487 RVA: 0x002678C1 File Offset: 0x00265AC1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PayGiftSuccessNotify()
		{
		}

		// Token: 0x060107A0 RID: 67488 RVA: 0x002678D4 File Offset: 0x00265AD4
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

		// Token: 0x060107A1 RID: 67489 RVA: 0x00267944 File Offset: 0x00265B44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PayGiftSuccessNotify Clone()
		{
			return new PayGiftSuccessNotify(this);
		}

		// Token: 0x17003619 RID: 13849
		// (get) Token: 0x060107A2 RID: 67490 RVA: 0x0026794C File Offset: 0x00265B4C
		// (set) Token: 0x060107A3 RID: 67491 RVA: 0x00267954 File Offset: 0x00265B54
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

		// Token: 0x1700361A RID: 13850
		// (get) Token: 0x060107A4 RID: 67492 RVA: 0x0026795D File Offset: 0x00265B5D
		// (set) Token: 0x060107A5 RID: 67493 RVA: 0x00267965 File Offset: 0x00265B65
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

		// Token: 0x1700361B RID: 13851
		// (get) Token: 0x060107A6 RID: 67494 RVA: 0x00267978 File Offset: 0x00265B78
		// (set) Token: 0x060107A7 RID: 67495 RVA: 0x00267980 File Offset: 0x00265B80
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

		// Token: 0x1700361C RID: 13852
		// (get) Token: 0x060107A8 RID: 67496 RVA: 0x00267989 File Offset: 0x00265B89
		// (set) Token: 0x060107A9 RID: 67497 RVA: 0x00267991 File Offset: 0x00265B91
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

		// Token: 0x1700361D RID: 13853
		// (get) Token: 0x060107AA RID: 67498 RVA: 0x0026799A File Offset: 0x00265B9A
		// (set) Token: 0x060107AB RID: 67499 RVA: 0x002679A2 File Offset: 0x00265BA2
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

		// Token: 0x060107AC RID: 67500 RVA: 0x002679AB File Offset: 0x00265BAB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PayGiftSuccessNotify);
		}

		// Token: 0x060107AD RID: 67501 RVA: 0x002679BC File Offset: 0x00265BBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PayGiftSuccessNotify other)
		{
			return other != null && (other == this || (this.Id == other.Id && !(this.ReceiptId != other.ReceiptId) && this.ItemId == other.ItemId && this.ItemCount == other.ItemCount && object.Equals(this.PayGiftInfo, other.PayGiftInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060107AE RID: 67502 RVA: 0x00267A40 File Offset: 0x00265C40
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

		// Token: 0x060107AF RID: 67503 RVA: 0x00267AE2 File Offset: 0x00265CE2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060107B0 RID: 67504 RVA: 0x00267AEF File Offset: 0x00265CEF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060107B1 RID: 67505 RVA: 0x00267AF8 File Offset: 0x00265CF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.Id);
			}
			if (this.payGiftInfo_ != null)
			{
				output.WriteRawTag(58);
				output.WriteMessage(this.PayGiftInfo);
			}
			if (this.ItemId != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.ItemId);
			}
			if (this.ReceiptId.Length != 0)
			{
				output.WriteRawTag(90);
				output.WriteString(this.ReceiptId);
			}
			if (this.ItemCount != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.ItemCount);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060107B2 RID: 67506 RVA: 0x00267BAC File Offset: 0x00265DAC
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

		// Token: 0x060107B3 RID: 67507 RVA: 0x00267C50 File Offset: 0x00265E50
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

		// Token: 0x060107B4 RID: 67508 RVA: 0x00267CF9 File Offset: 0x00265EF9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060107B5 RID: 67509 RVA: 0x00267D04 File Offset: 0x00265F04
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
				if (num <= 58U)
				{
					if (num == 48U)
					{
						this.Id = input.ReadInt32();
						continue;
					}
					if (num == 58U)
					{
						if (this.payGiftInfo_ == null)
						{
							this.PayGiftInfo = new PayGiftInfo();
						}
						input.ReadMessage(this.PayGiftInfo);
						continue;
					}
				}
				else
				{
					if (num == 80U)
					{
						this.ItemId = input.ReadInt32();
						continue;
					}
					if (num == 90U)
					{
						this.ReceiptId = input.ReadString();
						continue;
					}
					if (num == 96U)
					{
						this.ItemCount = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04006889 RID: 26761
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400688A RID: 26762
		public const int IdFieldNumber = 6;

		// Token: 0x0400688B RID: 26763
		private int id_;

		// Token: 0x0400688C RID: 26764
		public const int ReceiptIdFieldNumber = 11;

		// Token: 0x0400688D RID: 26765
		private string receiptId_ = "";

		// Token: 0x0400688E RID: 26766
		public const int ItemIdFieldNumber = 10;

		// Token: 0x0400688F RID: 26767
		private int itemId_;

		// Token: 0x04006890 RID: 26768
		public const int ItemCountFieldNumber = 12;

		// Token: 0x04006891 RID: 26769
		private int itemCount_;

		// Token: 0x04006892 RID: 26770
		public const int PayGiftInfoFieldNumber = 7;

		// Token: 0x04006893 RID: 26771
		private PayGiftInfo payGiftInfo_;
	}
}
