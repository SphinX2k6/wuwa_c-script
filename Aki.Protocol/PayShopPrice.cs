using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000BF5 RID: 3061
	public sealed class PayShopPrice : IMessage<PayShopPrice>, IMessage, IEquatable<PayShopPrice>, IDeepCloneable<PayShopPrice>, IBufferMessage
	{
		// Token: 0x060109B9 RID: 68025 RVA: 0x0026E20C File Offset: 0x0026C40C
		[NullableContext(1)]
		public static PayShopPrice Create()
		{
			return new PayShopPrice();
		}

		// Token: 0x170036B1 RID: 14001
		// (get) Token: 0x060109BA RID: 68026 RVA: 0x0026E213 File Offset: 0x0026C413
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170036B2 RID: 14002
		// (get) Token: 0x060109BB RID: 68027 RVA: 0x0026E216 File Offset: 0x0026C416
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PayShopPrice.Descriptor;
			}
		}

		// Token: 0x060109BC RID: 68028 RVA: 0x0026E21D File Offset: 0x0026C41D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PayShopPrice()
		{
		}

		// Token: 0x060109BD RID: 68029 RVA: 0x0026E225 File Offset: 0x0026C425
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PayShopPrice(PayShopPrice other) : this()
		{
			this.id_ = other.id_;
			this.count_ = other.count_;
			this.promotionCount_ = other.promotionCount_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060109BE RID: 68030 RVA: 0x0026E262 File Offset: 0x0026C462
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PayShopPrice Clone()
		{
			return new PayShopPrice(this);
		}

		// Token: 0x170036B3 RID: 14003
		// (get) Token: 0x060109BF RID: 68031 RVA: 0x0026E26A File Offset: 0x0026C46A
		// (set) Token: 0x060109C0 RID: 68032 RVA: 0x0026E272 File Offset: 0x0026C472
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

		// Token: 0x170036B4 RID: 14004
		// (get) Token: 0x060109C1 RID: 68033 RVA: 0x0026E27B File Offset: 0x0026C47B
		// (set) Token: 0x060109C2 RID: 68034 RVA: 0x0026E283 File Offset: 0x0026C483
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

		// Token: 0x170036B5 RID: 14005
		// (get) Token: 0x060109C3 RID: 68035 RVA: 0x0026E28C File Offset: 0x0026C48C
		// (set) Token: 0x060109C4 RID: 68036 RVA: 0x0026E294 File Offset: 0x0026C494
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

		// Token: 0x060109C5 RID: 68037 RVA: 0x0026E29D File Offset: 0x0026C49D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PayShopPrice);
		}

		// Token: 0x060109C6 RID: 68038 RVA: 0x0026E2AC File Offset: 0x0026C4AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PayShopPrice other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.Count == other.Count && this.PromotionCount == other.PromotionCount && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060109C7 RID: 68039 RVA: 0x0026E308 File Offset: 0x0026C508
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

		// Token: 0x060109C8 RID: 68040 RVA: 0x0026E379 File Offset: 0x0026C579
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060109C9 RID: 68041 RVA: 0x0026E386 File Offset: 0x0026C586
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060109CA RID: 68042 RVA: 0x0026E390 File Offset: 0x0026C590
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

		// Token: 0x060109CB RID: 68043 RVA: 0x0026E404 File Offset: 0x0026C604
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

		// Token: 0x060109CC RID: 68044 RVA: 0x0026E474 File Offset: 0x0026C674
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

		// Token: 0x060109CD RID: 68045 RVA: 0x0026E4D8 File Offset: 0x0026C6D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060109CE RID: 68046 RVA: 0x0026E4E4 File Offset: 0x0026C6E4
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

		// Token: 0x0400698B RID: 27019
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400698C RID: 27020
		public const int IdFieldNumber = 1;

		// Token: 0x0400698D RID: 27021
		private int id_;

		// Token: 0x0400698E RID: 27022
		public const int CountFieldNumber = 2;

		// Token: 0x0400698F RID: 27023
		private int count_;

		// Token: 0x04006990 RID: 27024
		public const int PromotionCountFieldNumber = 3;

		// Token: 0x04006991 RID: 27025
		private int promotionCount_;
	}
}
