using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200122C RID: 4652
	public sealed class ShopBuySyncDataPb : IMessage<ShopBuySyncDataPb>, IMessage, IEquatable<ShopBuySyncDataPb>, IDeepCloneable<ShopBuySyncDataPb>, IBufferMessage
	{
		// Token: 0x06018D86 RID: 101766 RVA: 0x0039F228 File Offset: 0x0039D428
		[NullableContext(1)]
		public static ShopBuySyncDataPb Create()
		{
			return new ShopBuySyncDataPb();
		}

		// Token: 0x170053EC RID: 21484
		// (get) Token: 0x06018D87 RID: 101767 RVA: 0x0039F22F File Offset: 0x0039D42F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170053ED RID: 21485
		// (get) Token: 0x06018D88 RID: 101768 RVA: 0x0039F232 File Offset: 0x0039D432
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ShopBuySyncDataPb.Descriptor;
			}
		}

		// Token: 0x06018D89 RID: 101769 RVA: 0x0039F239 File Offset: 0x0039D439
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ShopBuySyncDataPb()
		{
		}

		// Token: 0x06018D8A RID: 101770 RVA: 0x0039F241 File Offset: 0x0039D441
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ShopBuySyncDataPb(ShopBuySyncDataPb other) : this()
		{
			this.shopId_ = other.shopId_;
			this.goodsId_ = other.goodsId_;
			this.count_ = other.count_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06018D8B RID: 101771 RVA: 0x0039F27E File Offset: 0x0039D47E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ShopBuySyncDataPb Clone()
		{
			return new ShopBuySyncDataPb(this);
		}

		// Token: 0x170053EE RID: 21486
		// (get) Token: 0x06018D8C RID: 101772 RVA: 0x0039F286 File Offset: 0x0039D486
		// (set) Token: 0x06018D8D RID: 101773 RVA: 0x0039F28E File Offset: 0x0039D48E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ShopId
		{
			get
			{
				return this.shopId_;
			}
			set
			{
				this.shopId_ = value;
			}
		}

		// Token: 0x170053EF RID: 21487
		// (get) Token: 0x06018D8E RID: 101774 RVA: 0x0039F297 File Offset: 0x0039D497
		// (set) Token: 0x06018D8F RID: 101775 RVA: 0x0039F29F File Offset: 0x0039D49F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int GoodsId
		{
			get
			{
				return this.goodsId_;
			}
			set
			{
				this.goodsId_ = value;
			}
		}

		// Token: 0x170053F0 RID: 21488
		// (get) Token: 0x06018D90 RID: 101776 RVA: 0x0039F2A8 File Offset: 0x0039D4A8
		// (set) Token: 0x06018D91 RID: 101777 RVA: 0x0039F2B0 File Offset: 0x0039D4B0
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

		// Token: 0x06018D92 RID: 101778 RVA: 0x0039F2B9 File Offset: 0x0039D4B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ShopBuySyncDataPb);
		}

		// Token: 0x06018D93 RID: 101779 RVA: 0x0039F2C8 File Offset: 0x0039D4C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ShopBuySyncDataPb other)
		{
			return other != null && (other == this || (this.ShopId == other.ShopId && this.GoodsId == other.GoodsId && this.Count == other.Count && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06018D94 RID: 101780 RVA: 0x0039F324 File Offset: 0x0039D524
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ShopId != 0)
			{
				num ^= this.ShopId.GetHashCode();
			}
			if (this.GoodsId != 0)
			{
				num ^= this.GoodsId.GetHashCode();
			}
			if (this.Count != 0)
			{
				num ^= this.Count.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06018D95 RID: 101781 RVA: 0x0039F395 File Offset: 0x0039D595
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06018D96 RID: 101782 RVA: 0x0039F3A2 File Offset: 0x0039D5A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06018D97 RID: 101783 RVA: 0x0039F3AC File Offset: 0x0039D5AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ShopId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.ShopId);
			}
			if (this.GoodsId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.GoodsId);
			}
			if (this.Count != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.Count);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06018D98 RID: 101784 RVA: 0x0039F420 File Offset: 0x0039D620
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ShopId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ShopId);
			}
			if (this.GoodsId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.GoodsId);
			}
			if (this.Count != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Count);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06018D99 RID: 101785 RVA: 0x0039F490 File Offset: 0x0039D690
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ShopBuySyncDataPb other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ShopId != 0)
			{
				this.ShopId = other.ShopId;
			}
			if (other.GoodsId != 0)
			{
				this.GoodsId = other.GoodsId;
			}
			if (other.Count != 0)
			{
				this.Count = other.Count;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06018D9A RID: 101786 RVA: 0x0039F4F4 File Offset: 0x0039D6F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06018D9B RID: 101787 RVA: 0x0039F500 File Offset: 0x0039D700
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
							this.Count = input.ReadInt32();
						}
					}
					else
					{
						this.GoodsId = input.ReadInt32();
					}
				}
				else
				{
					this.ShopId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04009367 RID: 37735
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009368 RID: 37736
		public const int ShopIdFieldNumber = 1;

		// Token: 0x04009369 RID: 37737
		private int shopId_;

		// Token: 0x0400936A RID: 37738
		public const int GoodsIdFieldNumber = 2;

		// Token: 0x0400936B RID: 37739
		private int goodsId_;

		// Token: 0x0400936C RID: 37740
		public const int CountFieldNumber = 3;

		// Token: 0x0400936D RID: 37741
		private int count_;
	}
}
