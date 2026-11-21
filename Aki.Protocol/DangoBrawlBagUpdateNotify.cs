using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000340 RID: 832
	[NetMessage(EMessageId.DangoBrawlBagUpdateNotify)]
	public sealed class DangoBrawlBagUpdateNotify : IMessage<DangoBrawlBagUpdateNotify>, IMessage, IEquatable<DangoBrawlBagUpdateNotify>, IDeepCloneable<DangoBrawlBagUpdateNotify>, IBufferMessage
	{
		// Token: 0x060053A6 RID: 21414 RVA: 0x000CC56A File Offset: 0x000CA76A
		[NullableContext(1)]
		public static DangoBrawlBagUpdateNotify Create()
		{
			return new DangoBrawlBagUpdateNotify();
		}

		// Token: 0x17000F31 RID: 3889
		// (get) Token: 0x060053A7 RID: 21415 RVA: 0x000CC571 File Offset: 0x000CA771
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000F32 RID: 3890
		// (get) Token: 0x060053A8 RID: 21416 RVA: 0x000CC574 File Offset: 0x000CA774
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DangoBrawlBagUpdateNotify.Descriptor;
			}
		}

		// Token: 0x060053A9 RID: 21417 RVA: 0x000CC57B File Offset: 0x000CA77B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlBagUpdateNotify()
		{
		}

		// Token: 0x060053AA RID: 21418 RVA: 0x000CC584 File Offset: 0x000CA784
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlBagUpdateNotify(DangoBrawlBagUpdateNotify other) : this()
		{
			this.bag_ = ((other.bag_ != null) ? other.bag_.Clone() : null);
			this.shop_ = ((other.shop_ != null) ? other.shop_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060053AB RID: 21419 RVA: 0x000CC5E0 File Offset: 0x000CA7E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlBagUpdateNotify Clone()
		{
			return new DangoBrawlBagUpdateNotify(this);
		}

		// Token: 0x17000F33 RID: 3891
		// (get) Token: 0x060053AC RID: 21420 RVA: 0x000CC5E8 File Offset: 0x000CA7E8
		// (set) Token: 0x060053AD RID: 21421 RVA: 0x000CC5F0 File Offset: 0x000CA7F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlBagInfo Bag
		{
			get
			{
				return this.bag_;
			}
			set
			{
				this.bag_ = value;
			}
		}

		// Token: 0x17000F34 RID: 3892
		// (get) Token: 0x060053AE RID: 21422 RVA: 0x000CC5F9 File Offset: 0x000CA7F9
		// (set) Token: 0x060053AF RID: 21423 RVA: 0x000CC601 File Offset: 0x000CA801
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlShopInfo Shop
		{
			get
			{
				return this.shop_;
			}
			set
			{
				this.shop_ = value;
			}
		}

		// Token: 0x060053B0 RID: 21424 RVA: 0x000CC60A File Offset: 0x000CA80A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DangoBrawlBagUpdateNotify);
		}

		// Token: 0x060053B1 RID: 21425 RVA: 0x000CC618 File Offset: 0x000CA818
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DangoBrawlBagUpdateNotify other)
		{
			return other != null && (other == this || (object.Equals(this.Bag, other.Bag) && object.Equals(this.Shop, other.Shop) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060053B2 RID: 21426 RVA: 0x000CC66C File Offset: 0x000CA86C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.bag_ != null)
			{
				num ^= this.Bag.GetHashCode();
			}
			if (this.shop_ != null)
			{
				num ^= this.Shop.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060053B3 RID: 21427 RVA: 0x000CC6BE File Offset: 0x000CA8BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060053B4 RID: 21428 RVA: 0x000CC6CB File Offset: 0x000CA8CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060053B5 RID: 21429 RVA: 0x000CC6D4 File Offset: 0x000CA8D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.shop_ != null)
			{
				output.WriteRawTag(42);
				output.WriteMessage(this.Shop);
			}
			if (this.bag_ != null)
			{
				output.WriteRawTag(50);
				output.WriteMessage(this.Bag);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060053B6 RID: 21430 RVA: 0x000CC730 File Offset: 0x000CA930
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.bag_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Bag);
			}
			if (this.shop_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Shop);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060053B7 RID: 21431 RVA: 0x000CC788 File Offset: 0x000CA988
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DangoBrawlBagUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.bag_ != null)
			{
				if (this.bag_ == null)
				{
					this.Bag = new DangoBrawlBagInfo();
				}
				this.Bag.MergeFrom(other.Bag);
			}
			if (other.shop_ != null)
			{
				if (this.shop_ == null)
				{
					this.Shop = new DangoBrawlShopInfo();
				}
				this.Shop.MergeFrom(other.Shop);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060053B8 RID: 21432 RVA: 0x000CC808 File Offset: 0x000CAA08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060053B9 RID: 21433 RVA: 0x000CC814 File Offset: 0x000CAA14
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
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						if (this.bag_ == null)
						{
							this.Bag = new DangoBrawlBagInfo();
						}
						input.ReadMessage(this.Bag);
					}
				}
				else
				{
					if (this.shop_ == null)
					{
						this.Shop = new DangoBrawlShopInfo();
					}
					input.ReadMessage(this.Shop);
				}
			}
		}

		// Token: 0x040033E5 RID: 13285
		private UnknownFieldSet _unknownFields;

		// Token: 0x040033E6 RID: 13286
		public const int BagFieldNumber = 6;

		// Token: 0x040033E7 RID: 13287
		private DangoBrawlBagInfo bag_;

		// Token: 0x040033E8 RID: 13288
		public const int ShopFieldNumber = 5;

		// Token: 0x040033E9 RID: 13289
		private DangoBrawlShopInfo shop_;
	}
}
