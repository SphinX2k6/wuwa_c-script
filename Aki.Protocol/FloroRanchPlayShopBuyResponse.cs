using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020005BB RID: 1467
	[NetMessage(EMessageId.FloroRanchPlayShopBuyResponse)]
	public sealed class FloroRanchPlayShopBuyResponse : IMessage<FloroRanchPlayShopBuyResponse>, IMessage, IEquatable<FloroRanchPlayShopBuyResponse>, IDeepCloneable<FloroRanchPlayShopBuyResponse>, IBufferMessage
	{
		// Token: 0x06008822 RID: 34850 RVA: 0x00148EB0 File Offset: 0x001470B0
		[NullableContext(1)]
		public static FloroRanchPlayShopBuyResponse Create()
		{
			return new FloroRanchPlayShopBuyResponse();
		}

		// Token: 0x17001ABA RID: 6842
		// (get) Token: 0x06008823 RID: 34851 RVA: 0x00148EB7 File Offset: 0x001470B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001ABB RID: 6843
		// (get) Token: 0x06008824 RID: 34852 RVA: 0x00148EBA File Offset: 0x001470BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FloroRanchPlayShopBuyResponse.Descriptor;
			}
		}

		// Token: 0x06008825 RID: 34853 RVA: 0x00148EC1 File Offset: 0x001470C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchPlayShopBuyResponse()
		{
		}

		// Token: 0x06008826 RID: 34854 RVA: 0x00148ECC File Offset: 0x001470CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchPlayShopBuyResponse(FloroRanchPlayShopBuyResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.type_ = other.type_;
			this.curCoin_ = other.curCoin_;
			this.curDiamond_ = other.curDiamond_;
			this.shop_ = ((other.shop_ != null) ? other.shop_.Clone() : null);
			FloroRanchPlayShopBuyResponse.DataOneofCase dataCase = other.DataCase;
			if (dataCase != FloroRanchPlayShopBuyResponse.DataOneofCase.Card)
			{
				if (dataCase != FloroRanchPlayShopBuyResponse.DataOneofCase.CardGroup)
				{
					if (dataCase == FloroRanchPlayShopBuyResponse.DataOneofCase.Toy)
					{
						this.Toy = other.Toy.Clone();
					}
				}
				else
				{
					this.CardGroup = other.CardGroup.Clone();
				}
			}
			else
			{
				this.Card = other.Card.Clone();
			}
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008827 RID: 34855 RVA: 0x00148F89 File Offset: 0x00147189
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchPlayShopBuyResponse Clone()
		{
			return new FloroRanchPlayShopBuyResponse(this);
		}

		// Token: 0x17001ABC RID: 6844
		// (get) Token: 0x06008828 RID: 34856 RVA: 0x00148F91 File Offset: 0x00147191
		// (set) Token: 0x06008829 RID: 34857 RVA: 0x00148F99 File Offset: 0x00147199
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode ErrorCode
		{
			get
			{
				return this.errorCode_;
			}
			set
			{
				this.errorCode_ = value;
			}
		}

		// Token: 0x17001ABD RID: 6845
		// (get) Token: 0x0600882A RID: 34858 RVA: 0x00148FA2 File Offset: 0x001471A2
		// (set) Token: 0x0600882B RID: 34859 RVA: 0x00148FAA File Offset: 0x001471AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchPlayShopBuyType Type
		{
			get
			{
				return this.type_;
			}
			set
			{
				this.type_ = value;
			}
		}

		// Token: 0x17001ABE RID: 6846
		// (get) Token: 0x0600882C RID: 34860 RVA: 0x00148FB3 File Offset: 0x001471B3
		// (set) Token: 0x0600882D RID: 34861 RVA: 0x00148FBB File Offset: 0x001471BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long CurCoin
		{
			get
			{
				return this.curCoin_;
			}
			set
			{
				this.curCoin_ = value;
			}
		}

		// Token: 0x17001ABF RID: 6847
		// (get) Token: 0x0600882E RID: 34862 RVA: 0x00148FC4 File Offset: 0x001471C4
		// (set) Token: 0x0600882F RID: 34863 RVA: 0x00148FCC File Offset: 0x001471CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long CurDiamond
		{
			get
			{
				return this.curDiamond_;
			}
			set
			{
				this.curDiamond_ = value;
			}
		}

		// Token: 0x17001AC0 RID: 6848
		// (get) Token: 0x06008830 RID: 34864 RVA: 0x00148FD5 File Offset: 0x001471D5
		// (set) Token: 0x06008831 RID: 34865 RVA: 0x00148FDD File Offset: 0x001471DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchShop Shop
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

		// Token: 0x17001AC1 RID: 6849
		// (get) Token: 0x06008832 RID: 34866 RVA: 0x00148FE6 File Offset: 0x001471E6
		// (set) Token: 0x06008833 RID: 34867 RVA: 0x00148FFE File Offset: 0x001471FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchPlayShopBuyCard Card
		{
			get
			{
				if (this.dataCase_ != FloroRanchPlayShopBuyResponse.DataOneofCase.Card)
				{
					return null;
				}
				return (FloroRanchPlayShopBuyCard)this.data_;
			}
			set
			{
				this.data_ = value;
				this.dataCase_ = ((value == null) ? FloroRanchPlayShopBuyResponse.DataOneofCase.None : FloroRanchPlayShopBuyResponse.DataOneofCase.Card);
			}
		}

		// Token: 0x17001AC2 RID: 6850
		// (get) Token: 0x06008834 RID: 34868 RVA: 0x00149014 File Offset: 0x00147214
		// (set) Token: 0x06008835 RID: 34869 RVA: 0x0014902C File Offset: 0x0014722C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchPlayShopBuyCardGroup CardGroup
		{
			get
			{
				if (this.dataCase_ != FloroRanchPlayShopBuyResponse.DataOneofCase.CardGroup)
				{
					return null;
				}
				return (FloroRanchPlayShopBuyCardGroup)this.data_;
			}
			set
			{
				this.data_ = value;
				this.dataCase_ = ((value == null) ? FloroRanchPlayShopBuyResponse.DataOneofCase.None : FloroRanchPlayShopBuyResponse.DataOneofCase.CardGroup);
			}
		}

		// Token: 0x17001AC3 RID: 6851
		// (get) Token: 0x06008836 RID: 34870 RVA: 0x00149042 File Offset: 0x00147242
		// (set) Token: 0x06008837 RID: 34871 RVA: 0x0014905B File Offset: 0x0014725B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchPlayShopBuyToy Toy
		{
			get
			{
				if (this.dataCase_ != FloroRanchPlayShopBuyResponse.DataOneofCase.Toy)
				{
					return null;
				}
				return (FloroRanchPlayShopBuyToy)this.data_;
			}
			set
			{
				this.data_ = value;
				this.dataCase_ = ((value == null) ? FloroRanchPlayShopBuyResponse.DataOneofCase.None : FloroRanchPlayShopBuyResponse.DataOneofCase.Toy);
			}
		}

		// Token: 0x17001AC4 RID: 6852
		// (get) Token: 0x06008838 RID: 34872 RVA: 0x00149072 File Offset: 0x00147272
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchPlayShopBuyResponse.DataOneofCase DataCase
		{
			get
			{
				return this.dataCase_;
			}
		}

		// Token: 0x06008839 RID: 34873 RVA: 0x0014907A File Offset: 0x0014727A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearData()
		{
			this.dataCase_ = FloroRanchPlayShopBuyResponse.DataOneofCase.None;
			this.data_ = null;
		}

		// Token: 0x0600883A RID: 34874 RVA: 0x0014908A File Offset: 0x0014728A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FloroRanchPlayShopBuyResponse);
		}

		// Token: 0x0600883B RID: 34875 RVA: 0x00149098 File Offset: 0x00147298
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FloroRanchPlayShopBuyResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.Type == other.Type && this.CurCoin == other.CurCoin && this.CurDiamond == other.CurDiamond && object.Equals(this.Shop, other.Shop) && object.Equals(this.Card, other.Card) && object.Equals(this.CardGroup, other.CardGroup) && object.Equals(this.Toy, other.Toy) && this.DataCase == other.DataCase && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600883C RID: 34876 RVA: 0x00149168 File Offset: 0x00147368
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.Type != FloroRanchPlayShopBuyType.BuyCard)
			{
				num ^= this.Type.GetHashCode();
			}
			if (this.CurCoin != 0L)
			{
				num ^= this.CurCoin.GetHashCode();
			}
			if (this.CurDiamond != 0L)
			{
				num ^= this.CurDiamond.GetHashCode();
			}
			if (this.shop_ != null)
			{
				num ^= this.Shop.GetHashCode();
			}
			if (this.dataCase_ == FloroRanchPlayShopBuyResponse.DataOneofCase.Card)
			{
				num ^= this.Card.GetHashCode();
			}
			if (this.dataCase_ == FloroRanchPlayShopBuyResponse.DataOneofCase.CardGroup)
			{
				num ^= this.CardGroup.GetHashCode();
			}
			if (this.dataCase_ == FloroRanchPlayShopBuyResponse.DataOneofCase.Toy)
			{
				num ^= this.Toy.GetHashCode();
			}
			num ^= (int)this.dataCase_;
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600883D RID: 34877 RVA: 0x00149263 File Offset: 0x00147463
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600883E RID: 34878 RVA: 0x00149270 File Offset: 0x00147470
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600883F RID: 34879 RVA: 0x0014927C File Offset: 0x0014747C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Type != FloroRanchPlayShopBuyType.BuyCard)
			{
				output.WriteRawTag(16);
				output.WriteEnum((int)this.Type);
			}
			if (this.dataCase_ == FloroRanchPlayShopBuyResponse.DataOneofCase.Card)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.Card);
			}
			if (this.shop_ != null)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.Shop);
			}
			if (this.dataCase_ == FloroRanchPlayShopBuyResponse.DataOneofCase.CardGroup)
			{
				output.WriteRawTag(42);
				output.WriteMessage(this.CardGroup);
			}
			if (this.CurCoin != 0L)
			{
				output.WriteRawTag(48);
				output.WriteInt64(this.CurCoin);
			}
			if (this.CurDiamond != 0L)
			{
				output.WriteRawTag(72);
				output.WriteInt64(this.CurDiamond);
			}
			if (this.dataCase_ == FloroRanchPlayShopBuyResponse.DataOneofCase.Toy)
			{
				output.WriteRawTag(82);
				output.WriteMessage(this.Toy);
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(104);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008840 RID: 34880 RVA: 0x00149384 File Offset: 0x00147584
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.Type != FloroRanchPlayShopBuyType.BuyCard)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Type);
			}
			if (this.CurCoin != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.CurCoin);
			}
			if (this.CurDiamond != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.CurDiamond);
			}
			if (this.shop_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Shop);
			}
			if (this.dataCase_ == FloroRanchPlayShopBuyResponse.DataOneofCase.Card)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Card);
			}
			if (this.dataCase_ == FloroRanchPlayShopBuyResponse.DataOneofCase.CardGroup)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.CardGroup);
			}
			if (this.dataCase_ == FloroRanchPlayShopBuyResponse.DataOneofCase.Toy)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Toy);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008841 RID: 34881 RVA: 0x00149470 File Offset: 0x00147670
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FloroRanchPlayShopBuyResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.Type != FloroRanchPlayShopBuyType.BuyCard)
			{
				this.Type = other.Type;
			}
			if (other.CurCoin != 0L)
			{
				this.CurCoin = other.CurCoin;
			}
			if (other.CurDiamond != 0L)
			{
				this.CurDiamond = other.CurDiamond;
			}
			if (other.shop_ != null)
			{
				if (this.shop_ == null)
				{
					this.Shop = new FloroRanchShop();
				}
				this.Shop.MergeFrom(other.Shop);
			}
			FloroRanchPlayShopBuyResponse.DataOneofCase dataCase = other.DataCase;
			if (dataCase != FloroRanchPlayShopBuyResponse.DataOneofCase.Card)
			{
				if (dataCase != FloroRanchPlayShopBuyResponse.DataOneofCase.CardGroup)
				{
					if (dataCase == FloroRanchPlayShopBuyResponse.DataOneofCase.Toy)
					{
						if (this.Toy == null)
						{
							this.Toy = new FloroRanchPlayShopBuyToy();
						}
						this.Toy.MergeFrom(other.Toy);
					}
				}
				else
				{
					if (this.CardGroup == null)
					{
						this.CardGroup = new FloroRanchPlayShopBuyCardGroup();
					}
					this.CardGroup.MergeFrom(other.CardGroup);
				}
			}
			else
			{
				if (this.Card == null)
				{
					this.Card = new FloroRanchPlayShopBuyCard();
				}
				this.Card.MergeFrom(other.Card);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06008842 RID: 34882 RVA: 0x0014959A File Offset: 0x0014779A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008843 RID: 34883 RVA: 0x001495A4 File Offset: 0x001477A4
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
				if (num <= 42U)
				{
					if (num <= 26U)
					{
						if (num == 16U)
						{
							this.Type = (FloroRanchPlayShopBuyType)input.ReadEnum();
							continue;
						}
						if (num == 26U)
						{
							FloroRanchPlayShopBuyCard floroRanchPlayShopBuyCard = new FloroRanchPlayShopBuyCard();
							if (this.dataCase_ == FloroRanchPlayShopBuyResponse.DataOneofCase.Card)
							{
								floroRanchPlayShopBuyCard.MergeFrom(this.Card);
							}
							input.ReadMessage(floroRanchPlayShopBuyCard);
							this.Card = floroRanchPlayShopBuyCard;
							continue;
						}
					}
					else
					{
						if (num == 34U)
						{
							if (this.shop_ == null)
							{
								this.Shop = new FloroRanchShop();
							}
							input.ReadMessage(this.Shop);
							continue;
						}
						if (num == 42U)
						{
							FloroRanchPlayShopBuyCardGroup floroRanchPlayShopBuyCardGroup = new FloroRanchPlayShopBuyCardGroup();
							if (this.dataCase_ == FloroRanchPlayShopBuyResponse.DataOneofCase.CardGroup)
							{
								floroRanchPlayShopBuyCardGroup.MergeFrom(this.CardGroup);
							}
							input.ReadMessage(floroRanchPlayShopBuyCardGroup);
							this.CardGroup = floroRanchPlayShopBuyCardGroup;
							continue;
						}
					}
				}
				else if (num <= 72U)
				{
					if (num == 48U)
					{
						this.CurCoin = input.ReadInt64();
						continue;
					}
					if (num == 72U)
					{
						this.CurDiamond = input.ReadInt64();
						continue;
					}
				}
				else
				{
					if (num == 82U)
					{
						FloroRanchPlayShopBuyToy floroRanchPlayShopBuyToy = new FloroRanchPlayShopBuyToy();
						if (this.dataCase_ == FloroRanchPlayShopBuyResponse.DataOneofCase.Toy)
						{
							floroRanchPlayShopBuyToy.MergeFrom(this.Toy);
						}
						input.ReadMessage(floroRanchPlayShopBuyToy);
						this.Toy = floroRanchPlayShopBuyToy;
						continue;
					}
					if (num == 104U)
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04004394 RID: 17300
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004395 RID: 17301
		public const int ErrorCodeFieldNumber = 13;

		// Token: 0x04004396 RID: 17302
		private ErrorCode errorCode_;

		// Token: 0x04004397 RID: 17303
		public const int TypeFieldNumber = 2;

		// Token: 0x04004398 RID: 17304
		private FloroRanchPlayShopBuyType type_;

		// Token: 0x04004399 RID: 17305
		public const int CurCoinFieldNumber = 6;

		// Token: 0x0400439A RID: 17306
		private long curCoin_;

		// Token: 0x0400439B RID: 17307
		public const int CurDiamondFieldNumber = 9;

		// Token: 0x0400439C RID: 17308
		private long curDiamond_;

		// Token: 0x0400439D RID: 17309
		public const int ShopFieldNumber = 4;

		// Token: 0x0400439E RID: 17310
		private FloroRanchShop shop_;

		// Token: 0x0400439F RID: 17311
		public const int CardFieldNumber = 3;

		// Token: 0x040043A0 RID: 17312
		public const int CardGroupFieldNumber = 5;

		// Token: 0x040043A1 RID: 17313
		public const int ToyFieldNumber = 10;

		// Token: 0x040043A2 RID: 17314
		private object data_;

		// Token: 0x040043A3 RID: 17315
		private FloroRanchPlayShopBuyResponse.DataOneofCase dataCase_;

		// Token: 0x02001818 RID: 6168
		public enum DataOneofCase
		{
			// Token: 0x0400CBF0 RID: 52208
			None,
			// Token: 0x0400CBF1 RID: 52209
			Card = 3,
			// Token: 0x0400CBF2 RID: 52210
			CardGroup = 5,
			// Token: 0x0400CBF3 RID: 52211
			Toy = 10
		}
	}
}
