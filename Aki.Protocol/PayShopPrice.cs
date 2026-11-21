using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000BE5 RID: 3045
	public sealed class PayShopPrice : IMessage<PayShopPrice>, IMessage, IEquatable<PayShopPrice>, IDeepCloneable<PayShopPrice>, IBufferMessage
	{
		// Token: 0x060108B9 RID: 67769 RVA: 0x0026C4A4 File Offset: 0x0026A6A4
		[NullableContext(1)]
		public static PayShopPrice Create()
		{
			return new PayShopPrice();
		}

		// Token: 0x1700367A RID: 13946
		// (get) Token: 0x060108BA RID: 67770 RVA: 0x0026C4AB File Offset: 0x0026A6AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700367B RID: 13947
		// (get) Token: 0x060108BB RID: 67771 RVA: 0x0026C4AE File Offset: 0x0026A6AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PayShopPrice.Descriptor;
			}
		}

		// Token: 0x060108BC RID: 67772 RVA: 0x0026C4B5 File Offset: 0x0026A6B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PayShopPrice()
		{
		}

		// Token: 0x060108BD RID: 67773 RVA: 0x0026C4BD File Offset: 0x0026A6BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PayShopPrice(PayShopPrice other) : this()
		{
			this.id_ = other.id_;
			this.count_ = other.count_;
			this.promotionCount_ = other.promotionCount_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060108BE RID: 67774 RVA: 0x0026C4FA File Offset: 0x0026A6FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PayShopPrice Clone()
		{
			return new PayShopPrice(this);
		}

		// Token: 0x1700367C RID: 13948
		// (get) Token: 0x060108BF RID: 67775 RVA: 0x0026C502 File Offset: 0x0026A702
		// (set) Token: 0x060108C0 RID: 67776 RVA: 0x0026C50A File Offset: 0x0026A70A
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

		// Token: 0x1700367D RID: 13949
		// (get) Token: 0x060108C1 RID: 67777 RVA: 0x0026C513 File Offset: 0x0026A713
		// (set) Token: 0x060108C2 RID: 67778 RVA: 0x0026C51B File Offset: 0x0026A71B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Count
		{
			get
			{
				return this.count_;
			}
			set
			{
				this.count_ = value;
			}
		}

		// Token: 0x1700367E RID: 13950
		// (get) Token: 0x060108C3 RID: 67779 RVA: 0x0026C524 File Offset: 0x0026A724
		// (set) Token: 0x060108C4 RID: 67780 RVA: 0x0026C52C File Offset: 0x0026A72C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int PromotionCount
		{
			get
			{
				return this.promotionCount_;
			}
			set
			{
				this.promotionCount_ = value;
			}
		}

		// Token: 0x060108C5 RID: 67781 RVA: 0x0026C535 File Offset: 0x0026A735
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PayShopPrice);
		}

		// Token: 0x060108C6 RID: 67782 RVA: 0x0026C544 File Offset: 0x0026A744
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PayShopPrice other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.Count == other.Count && this.PromotionCount == other.PromotionCount && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060108C7 RID: 67783 RVA: 0x0026C5A0 File Offset: 0x0026A7A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.Count != 0)
			{
				num ^= this.Count.GetHashCode();
			}
			if (this.PromotionCount != 0)
			{
				num ^= this.PromotionCount.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060108C8 RID: 67784 RVA: 0x0026C611 File Offset: 0x0026A811
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060108C9 RID: 67785 RVA: 0x0026C61E File Offset: 0x0026A81E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060108CA RID: 67786 RVA: 0x0026C628 File Offset: 0x0026A828
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Id);
			}
			if (this.Count != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Count);
			}
			if (this.PromotionCount != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.PromotionCount);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060108CB RID: 67787 RVA: 0x0026C69C File Offset: 0x0026A89C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			if (this.Count != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Count);
			}
			if (this.PromotionCount != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PromotionCount);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060108CC RID: 67788 RVA: 0x0026C70C File Offset: 0x0026A90C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PayShopPrice other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			if (other.Count != 0)
			{
				this.Count = other.Count;
			}
			if (other.PromotionCount != 0)
			{
				this.PromotionCount = other.PromotionCount;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060108CD RID: 67789 RVA: 0x0026C770 File Offset: 0x0026A970
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060108CE RID: 67790 RVA: 0x0026C77C File Offset: 0x0026A97C
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
					if (num != 16U)
					{
						if (num != 24U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.PromotionCount = input.ReadInt32();
						}
					}
					else
					{
						this.Count = input.ReadInt32();
					}
				}
				else
				{
					this.Id = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400699F RID: 27039
		private UnknownFieldSet _unknownFields;

		// Token: 0x040069A0 RID: 27040
		public const int IdFieldNumber = 1;

		// Token: 0x040069A1 RID: 27041
		private int id_;

		// Token: 0x040069A2 RID: 27042
		public const int CountFieldNumber = 2;

		// Token: 0x040069A3 RID: 27043
		private int count_;

		// Token: 0x040069A4 RID: 27044
		public const int PromotionCountFieldNumber = 3;

		// Token: 0x040069A5 RID: 27045
		private int promotionCount_;
	}
}
