using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000BE7 RID: 3047
	[NetMessage(EMessageId.PayItemSuccessNotify)]
	public sealed class PayItemSuccessNotify : IMessage<PayItemSuccessNotify>, IMessage, IEquatable<PayItemSuccessNotify>, IDeepCloneable<PayItemSuccessNotify>, IBufferMessage
	{
		// Token: 0x06010832 RID: 67634 RVA: 0x002693AB File Offset: 0x002675AB
		[NullableContext(1)]
		public static PayItemSuccessNotify Create()
		{
			return new PayItemSuccessNotify();
		}

		// Token: 0x1700363E RID: 13886
		// (get) Token: 0x06010833 RID: 67635 RVA: 0x002693B2 File Offset: 0x002675B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700363F RID: 13887
		// (get) Token: 0x06010834 RID: 67636 RVA: 0x002693B5 File Offset: 0x002675B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PayItemSuccessNotify.Descriptor;
			}
		}

		// Token: 0x06010835 RID: 67637 RVA: 0x002693BC File Offset: 0x002675BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PayItemSuccessNotify()
		{
		}

		// Token: 0x06010836 RID: 67638 RVA: 0x002693D0 File Offset: 0x002675D0
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

		// Token: 0x06010837 RID: 67639 RVA: 0x00269424 File Offset: 0x00267624
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PayItemSuccessNotify Clone()
		{
			return new PayItemSuccessNotify(this);
		}

		// Token: 0x17003640 RID: 13888
		// (get) Token: 0x06010838 RID: 67640 RVA: 0x0026942C File Offset: 0x0026762C
		// (set) Token: 0x06010839 RID: 67641 RVA: 0x00269434 File Offset: 0x00267634
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

		// Token: 0x17003641 RID: 13889
		// (get) Token: 0x0601083A RID: 67642 RVA: 0x0026943D File Offset: 0x0026763D
		// (set) Token: 0x0601083B RID: 67643 RVA: 0x00269445 File Offset: 0x00267645
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

		// Token: 0x17003642 RID: 13890
		// (get) Token: 0x0601083C RID: 67644 RVA: 0x00269458 File Offset: 0x00267658
		// (set) Token: 0x0601083D RID: 67645 RVA: 0x00269460 File Offset: 0x00267660
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

		// Token: 0x17003643 RID: 13891
		// (get) Token: 0x0601083E RID: 67646 RVA: 0x00269469 File Offset: 0x00267669
		// (set) Token: 0x0601083F RID: 67647 RVA: 0x00269471 File Offset: 0x00267671
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

		// Token: 0x06010840 RID: 67648 RVA: 0x0026947A File Offset: 0x0026767A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PayItemSuccessNotify);
		}

		// Token: 0x06010841 RID: 67649 RVA: 0x00269488 File Offset: 0x00267688
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PayItemSuccessNotify other)
		{
			return other != null && (other == this || (this.Id == other.Id && !(this.ReceiptId != other.ReceiptId) && this.ItemId == other.ItemId && this.ItemCount == other.ItemCount && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06010842 RID: 67650 RVA: 0x002694F8 File Offset: 0x002676F8
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

		// Token: 0x06010843 RID: 67651 RVA: 0x00269584 File Offset: 0x00267784
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06010844 RID: 67652 RVA: 0x00269591 File Offset: 0x00267791
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06010845 RID: 67653 RVA: 0x0026959C File Offset: 0x0026779C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Id);
			}
			if (this.ItemId != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.ItemId);
			}
			if (this.ItemCount != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.ItemCount);
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

		// Token: 0x06010846 RID: 67654 RVA: 0x00269634 File Offset: 0x00267834
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

		// Token: 0x06010847 RID: 67655 RVA: 0x002696C0 File Offset: 0x002678C0
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

		// Token: 0x06010848 RID: 67656 RVA: 0x0026973D File Offset: 0x0026793D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06010849 RID: 67657 RVA: 0x00269748 File Offset: 0x00267948
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
				if (num <= 64U)
				{
					if (num == 16U)
					{
						this.Id = input.ReadInt32();
						continue;
					}
					if (num == 64U)
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
					if (num == 114U)
					{
						this.ReceiptId = input.ReadString();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040068C5 RID: 26821
		private UnknownFieldSet _unknownFields;

		// Token: 0x040068C6 RID: 26822
		public const int IdFieldNumber = 2;

		// Token: 0x040068C7 RID: 26823
		private int id_;

		// Token: 0x040068C8 RID: 26824
		public const int ReceiptIdFieldNumber = 14;

		// Token: 0x040068C9 RID: 26825
		private string receiptId_ = "";

		// Token: 0x040068CA RID: 26826
		public const int ItemIdFieldNumber = 8;

		// Token: 0x040068CB RID: 26827
		private int itemId_;

		// Token: 0x040068CC RID: 26828
		public const int ItemCountFieldNumber = 11;

		// Token: 0x040068CD RID: 26829
		private int itemCount_;
	}
}
