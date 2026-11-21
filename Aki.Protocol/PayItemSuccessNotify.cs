using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000BD7 RID: 3031
	[NetMessage(EMessageId.PayItemSuccessNotify)]
	public sealed class PayItemSuccessNotify : IMessage<PayItemSuccessNotify>, IMessage, IEquatable<PayItemSuccessNotify>, IDeepCloneable<PayItemSuccessNotify>, IBufferMessage
	{
		// Token: 0x0601072E RID: 67374 RVA: 0x002674E7 File Offset: 0x002656E7
		[NullableContext(1)]
		public static PayItemSuccessNotify Create()
		{
			return new PayItemSuccessNotify();
		}

		// Token: 0x17003605 RID: 13829
		// (get) Token: 0x0601072F RID: 67375 RVA: 0x002674EE File Offset: 0x002656EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003606 RID: 13830
		// (get) Token: 0x06010730 RID: 67376 RVA: 0x002674F1 File Offset: 0x002656F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PayItemSuccessNotify.Descriptor;
			}
		}

		// Token: 0x06010731 RID: 67377 RVA: 0x002674F8 File Offset: 0x002656F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PayItemSuccessNotify()
		{
		}

		// Token: 0x06010732 RID: 67378 RVA: 0x0026750C File Offset: 0x0026570C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PayItemSuccessNotify(PayItemSuccessNotify other) : this()
		{
			this.id_ = other.id_;
			this.receiptId_ = other.receiptId_;
			this.itemId_ = other.itemId_;
			this.itemCount_ = other.itemCount_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06010733 RID: 67379 RVA: 0x00267560 File Offset: 0x00265760
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PayItemSuccessNotify Clone()
		{
			return new PayItemSuccessNotify(this);
		}

		// Token: 0x17003607 RID: 13831
		// (get) Token: 0x06010734 RID: 67380 RVA: 0x00267568 File Offset: 0x00265768
		// (set) Token: 0x06010735 RID: 67381 RVA: 0x00267570 File Offset: 0x00265770
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

		// Token: 0x17003608 RID: 13832
		// (get) Token: 0x06010736 RID: 67382 RVA: 0x00267579 File Offset: 0x00265779
		// (set) Token: 0x06010737 RID: 67383 RVA: 0x00267581 File Offset: 0x00265781
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

		// Token: 0x17003609 RID: 13833
		// (get) Token: 0x06010738 RID: 67384 RVA: 0x00267594 File Offset: 0x00265794
		// (set) Token: 0x06010739 RID: 67385 RVA: 0x0026759C File Offset: 0x0026579C
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

		// Token: 0x1700360A RID: 13834
		// (get) Token: 0x0601073A RID: 67386 RVA: 0x002675A5 File Offset: 0x002657A5
		// (set) Token: 0x0601073B RID: 67387 RVA: 0x002675AD File Offset: 0x002657AD
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

		// Token: 0x0601073C RID: 67388 RVA: 0x002675B6 File Offset: 0x002657B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PayItemSuccessNotify);
		}

		// Token: 0x0601073D RID: 67389 RVA: 0x002675C4 File Offset: 0x002657C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PayItemSuccessNotify other)
		{
			return other != null && (other == this || (this.Id == other.Id && !(this.ReceiptId != other.ReceiptId) && this.ItemId == other.ItemId && this.ItemCount == other.ItemCount && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601073E RID: 67390 RVA: 0x00267634 File Offset: 0x00265834
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
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601073F RID: 67391 RVA: 0x002676C0 File Offset: 0x002658C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06010740 RID: 67392 RVA: 0x002676CD File Offset: 0x002658CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06010741 RID: 67393 RVA: 0x002676D8 File Offset: 0x002658D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ReceiptId.Length != 0)
			{
				output.WriteRawTag(66);
				output.WriteString(this.ReceiptId);
			}
			if (this.Id != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.Id);
			}
			if (this.ItemCount != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.ItemCount);
			}
			if (this.ItemId != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.ItemId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06010742 RID: 67394 RVA: 0x00267770 File Offset: 0x00265970
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
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06010743 RID: 67395 RVA: 0x002677FC File Offset: 0x002659FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PayItemSuccessNotify other)
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
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06010744 RID: 67396 RVA: 0x00267879 File Offset: 0x00265A79
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06010745 RID: 67397 RVA: 0x00267884 File Offset: 0x00265A84
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
				if (num <= 80U)
				{
					if (num == 66U)
					{
						this.ReceiptId = input.ReadString();
						continue;
					}
					if (num == 80U)
					{
						this.Id = input.ReadInt32();
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
					if (num == 104U)
					{
						this.ItemId = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040068D5 RID: 26837
		private UnknownFieldSet _unknownFields;

		// Token: 0x040068D6 RID: 26838
		public const int IdFieldNumber = 10;

		// Token: 0x040068D7 RID: 26839
		private int id_;

		// Token: 0x040068D8 RID: 26840
		public const int ReceiptIdFieldNumber = 8;

		// Token: 0x040068D9 RID: 26841
		private string receiptId_ = "";

		// Token: 0x040068DA RID: 26842
		public const int ItemIdFieldNumber = 13;

		// Token: 0x040068DB RID: 26843
		private int itemId_;

		// Token: 0x040068DC RID: 26844
		public const int ItemCountFieldNumber = 11;

		// Token: 0x040068DD RID: 26845
		private int itemCount_;
	}
}
