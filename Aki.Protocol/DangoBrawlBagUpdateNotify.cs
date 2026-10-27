using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000338 RID: 824
	[NetMessage(EMessageId.DangoBrawlBagUpdateNotify)]
	public sealed class DangoBrawlBagUpdateNotify : IMessage<DangoBrawlBagUpdateNotify>, IMessage, IEquatable<DangoBrawlBagUpdateNotify>, IDeepCloneable<DangoBrawlBagUpdateNotify>, IBufferMessage
	{
		// Token: 0x060052B9 RID: 21177 RVA: 0x000C9EE6 File Offset: 0x000C80E6
		[NullableContext(1)]
		public static DangoBrawlBagUpdateNotify Create()
		{
			return new DangoBrawlBagUpdateNotify();
		}

		// Token: 0x17000F00 RID: 3840
		// (get) Token: 0x060052BA RID: 21178 RVA: 0x000C9EED File Offset: 0x000C80ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000F01 RID: 3841
		// (get) Token: 0x060052BB RID: 21179 RVA: 0x000C9EF0 File Offset: 0x000C80F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DangoBrawlBagUpdateNotify.Descriptor;
			}
		}

		// Token: 0x060052BC RID: 21180 RVA: 0x000C9EF7 File Offset: 0x000C80F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlBagUpdateNotify()
		{
		}

		// Token: 0x060052BD RID: 21181 RVA: 0x000C9F00 File Offset: 0x000C8100
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlBagUpdateNotify(DangoBrawlBagUpdateNotify other) : this()
		{
			this.bag_ = ((other.bag_ != null) ? other.bag_.Clone() : null);
			this.shop_ = ((other.shop_ != null) ? other.shop_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060052BE RID: 21182 RVA: 0x000C9F5C File Offset: 0x000C815C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlBagUpdateNotify Clone()
		{
			return new DangoBrawlBagUpdateNotify(this);
		}

		// Token: 0x17000F02 RID: 3842
		// (get) Token: 0x060052BF RID: 21183 RVA: 0x000C9F64 File Offset: 0x000C8164
		// (set) Token: 0x060052C0 RID: 21184 RVA: 0x000C9F6C File Offset: 0x000C816C
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

		// Token: 0x17000F03 RID: 3843
		// (get) Token: 0x060052C1 RID: 21185 RVA: 0x000C9F75 File Offset: 0x000C8175
		// (set) Token: 0x060052C2 RID: 21186 RVA: 0x000C9F7D File Offset: 0x000C817D
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

		// Token: 0x060052C3 RID: 21187 RVA: 0x000C9F86 File Offset: 0x000C8186
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DangoBrawlBagUpdateNotify);
		}

		// Token: 0x060052C4 RID: 21188 RVA: 0x000C9F94 File Offset: 0x000C8194
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DangoBrawlBagUpdateNotify other)
		{
			return other != null && (other == this || (object.Equals(this.Bag, other.Bag) && object.Equals(this.Shop, other.Shop) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060052C5 RID: 21189 RVA: 0x000C9FE8 File Offset: 0x000C81E8
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

		// Token: 0x060052C6 RID: 21190 RVA: 0x000CA03A File Offset: 0x000C823A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060052C7 RID: 21191 RVA: 0x000CA047 File Offset: 0x000C8247
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060052C8 RID: 21192 RVA: 0x000CA050 File Offset: 0x000C8250
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.shop_ != null)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.Shop);
			}
			if (this.bag_ != null)
			{
				output.WriteRawTag(90);
				output.WriteMessage(this.Bag);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060052C9 RID: 21193 RVA: 0x000CA0AC File Offset: 0x000C82AC
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

		// Token: 0x060052CA RID: 21194 RVA: 0x000CA104 File Offset: 0x000C8304
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

		// Token: 0x060052CB RID: 21195 RVA: 0x000CA184 File Offset: 0x000C8384
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060052CC RID: 21196 RVA: 0x000CA190 File Offset: 0x000C8390
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
				if (num != 34U)
				{
					if (num != 90U)
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

		// Token: 0x04003349 RID: 13129
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400334A RID: 13130
		public const int BagFieldNumber = 11;

		// Token: 0x0400334B RID: 13131
		private DangoBrawlBagInfo bag_;

		// Token: 0x0400334C RID: 13132
		public const int ShopFieldNumber = 4;

		// Token: 0x0400334D RID: 13133
		private DangoBrawlShopInfo shop_;
	}
}
