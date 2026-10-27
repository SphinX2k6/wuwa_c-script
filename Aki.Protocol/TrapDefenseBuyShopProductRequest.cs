using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001415 RID: 5141
	[NetMessage(EMessageId.TrapDefenseBuyShopProductRequest)]
	public sealed class TrapDefenseBuyShopProductRequest : IMessage<TrapDefenseBuyShopProductRequest>, IMessage, IEquatable<TrapDefenseBuyShopProductRequest>, IDeepCloneable<TrapDefenseBuyShopProductRequest>, IBufferMessage
	{
		// Token: 0x0601B3FB RID: 111611 RVA: 0x003F2C41 File Offset: 0x003F0E41
		[NullableContext(1)]
		public static TrapDefenseBuyShopProductRequest Create()
		{
			return new TrapDefenseBuyShopProductRequest();
		}

		// Token: 0x17005BE7 RID: 23527
		// (get) Token: 0x0601B3FC RID: 111612 RVA: 0x003F2C48 File Offset: 0x003F0E48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005BE8 RID: 23528
		// (get) Token: 0x0601B3FD RID: 111613 RVA: 0x003F2C4B File Offset: 0x003F0E4B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TrapDefenseBuyShopProductRequest.Descriptor;
			}
		}

		// Token: 0x0601B3FE RID: 111614 RVA: 0x003F2C52 File Offset: 0x003F0E52
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseBuyShopProductRequest()
		{
		}

		// Token: 0x0601B3FF RID: 111615 RVA: 0x003F2C5C File Offset: 0x003F0E5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseBuyShopProductRequest(TrapDefenseBuyShopProductRequest other) : this()
		{
			this.buyCount_ = other.buyCount_;
			TrapDefenseBuyShopProductRequest.ProductOneofCase productCase = other.ProductCase;
			if (productCase != TrapDefenseBuyShopProductRequest.ProductOneofCase.ItemConfigId)
			{
				if (productCase == TrapDefenseBuyShopProductRequest.ProductOneofCase.BdGroupConfigId)
				{
					this.BdGroupConfigId = other.BdGroupConfigId;
				}
			}
			else
			{
				this.ItemConfigId = other.ItemConfigId;
			}
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601B400 RID: 111616 RVA: 0x003F2CB6 File Offset: 0x003F0EB6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseBuyShopProductRequest Clone()
		{
			return new TrapDefenseBuyShopProductRequest(this);
		}

		// Token: 0x17005BE9 RID: 23529
		// (get) Token: 0x0601B401 RID: 111617 RVA: 0x003F2CBE File Offset: 0x003F0EBE
		// (set) Token: 0x0601B402 RID: 111618 RVA: 0x003F2CC6 File Offset: 0x003F0EC6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int BuyCount
		{
			get
			{
				return this.buyCount_;
			}
			set
			{
				this.buyCount_ = value;
			}
		}

		// Token: 0x17005BEA RID: 23530
		// (get) Token: 0x0601B403 RID: 111619 RVA: 0x003F2CCF File Offset: 0x003F0ECF
		// (set) Token: 0x0601B404 RID: 111620 RVA: 0x003F2CE6 File Offset: 0x003F0EE6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int BdGroupConfigId
		{
			get
			{
				if (!this.HasBdGroupConfigId)
				{
					return 0;
				}
				return (int)this.product_;
			}
			set
			{
				this.product_ = value;
				this.productCase_ = TrapDefenseBuyShopProductRequest.ProductOneofCase.BdGroupConfigId;
			}
		}

		// Token: 0x17005BEB RID: 23531
		// (get) Token: 0x0601B405 RID: 111621 RVA: 0x003F2CFC File Offset: 0x003F0EFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasBdGroupConfigId
		{
			get
			{
				return this.productCase_ == TrapDefenseBuyShopProductRequest.ProductOneofCase.BdGroupConfigId;
			}
		}

		// Token: 0x0601B406 RID: 111622 RVA: 0x003F2D08 File Offset: 0x003F0F08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearBdGroupConfigId()
		{
			if (this.HasBdGroupConfigId)
			{
				this.ClearProduct();
			}
		}

		// Token: 0x17005BEC RID: 23532
		// (get) Token: 0x0601B407 RID: 111623 RVA: 0x003F2D18 File Offset: 0x003F0F18
		// (set) Token: 0x0601B408 RID: 111624 RVA: 0x003F2D2F File Offset: 0x003F0F2F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ItemConfigId
		{
			get
			{
				if (!this.HasItemConfigId)
				{
					return 0;
				}
				return (int)this.product_;
			}
			set
			{
				this.product_ = value;
				this.productCase_ = TrapDefenseBuyShopProductRequest.ProductOneofCase.ItemConfigId;
			}
		}

		// Token: 0x17005BED RID: 23533
		// (get) Token: 0x0601B409 RID: 111625 RVA: 0x003F2D44 File Offset: 0x003F0F44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasItemConfigId
		{
			get
			{
				return this.productCase_ == TrapDefenseBuyShopProductRequest.ProductOneofCase.ItemConfigId;
			}
		}

		// Token: 0x0601B40A RID: 111626 RVA: 0x003F2D4F File Offset: 0x003F0F4F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearItemConfigId()
		{
			if (this.HasItemConfigId)
			{
				this.ClearProduct();
			}
		}

		// Token: 0x17005BEE RID: 23534
		// (get) Token: 0x0601B40B RID: 111627 RVA: 0x003F2D5F File Offset: 0x003F0F5F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseBuyShopProductRequest.ProductOneofCase ProductCase
		{
			get
			{
				return this.productCase_;
			}
		}

		// Token: 0x0601B40C RID: 111628 RVA: 0x003F2D67 File Offset: 0x003F0F67
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearProduct()
		{
			this.productCase_ = TrapDefenseBuyShopProductRequest.ProductOneofCase.None;
			this.product_ = null;
		}

		// Token: 0x0601B40D RID: 111629 RVA: 0x003F2D77 File Offset: 0x003F0F77
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TrapDefenseBuyShopProductRequest);
		}

		// Token: 0x0601B40E RID: 111630 RVA: 0x003F2D88 File Offset: 0x003F0F88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TrapDefenseBuyShopProductRequest other)
		{
			return other != null && (other == this || (this.BuyCount == other.BuyCount && this.BdGroupConfigId == other.BdGroupConfigId && this.ItemConfigId == other.ItemConfigId && this.ProductCase == other.ProductCase && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601B40F RID: 111631 RVA: 0x003F2DF4 File Offset: 0x003F0FF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.BuyCount != 0)
			{
				num ^= this.BuyCount.GetHashCode();
			}
			if (this.HasBdGroupConfigId)
			{
				num ^= this.BdGroupConfigId.GetHashCode();
			}
			if (this.HasItemConfigId)
			{
				num ^= this.ItemConfigId.GetHashCode();
			}
			num ^= (int)this.productCase_;
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601B410 RID: 111632 RVA: 0x003F2E6E File Offset: 0x003F106E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601B411 RID: 111633 RVA: 0x003F2E7B File Offset: 0x003F107B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601B412 RID: 111634 RVA: 0x003F2E84 File Offset: 0x003F1084
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.BuyCount != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.BuyCount);
			}
			if (this.HasItemConfigId)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.ItemConfigId);
			}
			if (this.HasBdGroupConfigId)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.BdGroupConfigId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601B413 RID: 111635 RVA: 0x003F2EFC File Offset: 0x003F10FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.BuyCount != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.BuyCount);
			}
			if (this.HasBdGroupConfigId)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.BdGroupConfigId);
			}
			if (this.HasItemConfigId)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ItemConfigId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601B414 RID: 111636 RVA: 0x003F2F6C File Offset: 0x003F116C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TrapDefenseBuyShopProductRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.BuyCount != 0)
			{
				this.BuyCount = other.BuyCount;
			}
			TrapDefenseBuyShopProductRequest.ProductOneofCase productCase = other.ProductCase;
			if (productCase != TrapDefenseBuyShopProductRequest.ProductOneofCase.ItemConfigId)
			{
				if (productCase == TrapDefenseBuyShopProductRequest.ProductOneofCase.BdGroupConfigId)
				{
					this.BdGroupConfigId = other.BdGroupConfigId;
				}
			}
			else
			{
				this.ItemConfigId = other.ItemConfigId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601B415 RID: 111637 RVA: 0x003F2FD2 File Offset: 0x003F11D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601B416 RID: 111638 RVA: 0x003F2FDC File Offset: 0x003F11DC
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
					if (num != 48U)
					{
						if (num != 80U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.BdGroupConfigId = input.ReadInt32();
						}
					}
					else
					{
						this.ItemConfigId = input.ReadInt32();
					}
				}
				else
				{
					this.BuyCount = input.ReadInt32();
				}
			}
		}

		// Token: 0x04009D93 RID: 40339
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009D94 RID: 40340
		public const int BuyCountFieldNumber = 4;

		// Token: 0x04009D95 RID: 40341
		private int buyCount_;

		// Token: 0x04009D96 RID: 40342
		public const int BdGroupConfigIdFieldNumber = 10;

		// Token: 0x04009D97 RID: 40343
		public const int ItemConfigIdFieldNumber = 6;

		// Token: 0x04009D98 RID: 40344
		private object product_;

		// Token: 0x04009D99 RID: 40345
		private TrapDefenseBuyShopProductRequest.ProductOneofCase productCase_;

		// Token: 0x020019D6 RID: 6614
		public enum ProductOneofCase
		{
			// Token: 0x0400CA9D RID: 51869
			None,
			// Token: 0x0400CA9E RID: 51870
			BdGroupConfigId = 10,
			// Token: 0x0400CA9F RID: 51871
			ItemConfigId = 6
		}
	}
}
