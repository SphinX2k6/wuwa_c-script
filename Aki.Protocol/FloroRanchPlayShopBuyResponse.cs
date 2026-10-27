using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020005D0 RID: 1488
	[NetMessage(EMessageId.FloroRanchPlayShopBuyResponse)]
	public sealed class FloroRanchPlayShopBuyResponse : IMessage<FloroRanchPlayShopBuyResponse>, IMessage, IEquatable<FloroRanchPlayShopBuyResponse>, IDeepCloneable<FloroRanchPlayShopBuyResponse>, IBufferMessage
	{
		// Token: 0x0600898A RID: 35210 RVA: 0x0014BAC8 File Offset: 0x00149CC8
		[NullableContext(1)]
		public static FloroRanchPlayShopBuyResponse Create()
		{
			return new FloroRanchPlayShopBuyResponse();
		}

		// Token: 0x17001B07 RID: 6919
		// (get) Token: 0x0600898B RID: 35211 RVA: 0x0014BACF File Offset: 0x00149CCF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001B08 RID: 6920
		// (get) Token: 0x0600898C RID: 35212 RVA: 0x0014BAD2 File Offset: 0x00149CD2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FloroRanchPlayShopBuyResponse.Descriptor;
			}
		}

		// Token: 0x0600898D RID: 35213 RVA: 0x0014BAD9 File Offset: 0x00149CD9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchPlayShopBuyResponse()
		{
		}

		// Token: 0x0600898E RID: 35214 RVA: 0x0014BAE4 File Offset: 0x00149CE4
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
				if (dataCase != FloroRanchPlayShopBuyResponse.DataOneofCase.Toy)
				{
					if (dataCase == FloroRanchPlayShopBuyResponse.DataOneofCase.CardGroup)
					{
						this.CardGroup = other.CardGroup.Clone();
					}
				}
				else
				{
					this.Toy = other.Toy.Clone();
				}
			}
			else
			{
				this.Card = other.Card.Clone();
			}
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600898F RID: 35215 RVA: 0x0014BBA1 File Offset: 0x00149DA1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchPlayShopBuyResponse Clone()
		{
			return new FloroRanchPlayShopBuyResponse(this);
		}

		// Token: 0x17001B09 RID: 6921
		// (get) Token: 0x06008990 RID: 35216 RVA: 0x0014BBA9 File Offset: 0x00149DA9
		// (set) Token: 0x06008991 RID: 35217 RVA: 0x0014BBB1 File Offset: 0x00149DB1
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

		// Token: 0x17001B0A RID: 6922
		// (get) Token: 0x06008992 RID: 35218 RVA: 0x0014BBBA File Offset: 0x00149DBA
		// (set) Token: 0x06008993 RID: 35219 RVA: 0x0014BBC2 File Offset: 0x00149DC2
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

		// Token: 0x17001B0B RID: 6923
		// (get) Token: 0x06008994 RID: 35220 RVA: 0x0014BBCB File Offset: 0x00149DCB
		// (set) Token: 0x06008995 RID: 35221 RVA: 0x0014BBD3 File Offset: 0x00149DD3
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

		// Token: 0x17001B0C RID: 6924
		// (get) Token: 0x06008996 RID: 35222 RVA: 0x0014BBDC File Offset: 0x00149DDC
		// (set) Token: 0x06008997 RID: 35223 RVA: 0x0014BBE4 File Offset: 0x00149DE4
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

		// Token: 0x17001B0D RID: 6925
		// (get) Token: 0x06008998 RID: 35224 RVA: 0x0014BBED File Offset: 0x00149DED
		// (set) Token: 0x06008999 RID: 35225 RVA: 0x0014BBF5 File Offset: 0x00149DF5
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

		// Token: 0x17001B0E RID: 6926
		// (get) Token: 0x0600899A RID: 35226 RVA: 0x0014BBFE File Offset: 0x00149DFE
		// (set) Token: 0x0600899B RID: 35227 RVA: 0x0014BC16 File Offset: 0x00149E16
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

		// Token: 0x17001B0F RID: 6927
		// (get) Token: 0x0600899C RID: 35228 RVA: 0x0014BC2C File Offset: 0x00149E2C
		// (set) Token: 0x0600899D RID: 35229 RVA: 0x0014BC45 File Offset: 0x00149E45
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

		// Token: 0x17001B10 RID: 6928
		// (get) Token: 0x0600899E RID: 35230 RVA: 0x0014BC5C File Offset: 0x00149E5C
		// (set) Token: 0x0600899F RID: 35231 RVA: 0x0014BC74 File Offset: 0x00149E74
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

		// Token: 0x17001B11 RID: 6929
		// (get) Token: 0x060089A0 RID: 35232 RVA: 0x0014BC8A File Offset: 0x00149E8A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchPlayShopBuyResponse.DataOneofCase DataCase
		{
			get
			{
				return this.dataCase_;
			}
		}

		// Token: 0x060089A1 RID: 35233 RVA: 0x0014BC92 File Offset: 0x00149E92
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearData()
		{
			this.dataCase_ = FloroRanchPlayShopBuyResponse.DataOneofCase.None;
			this.data_ = null;
		}

		// Token: 0x060089A2 RID: 35234 RVA: 0x0014BCA2 File Offset: 0x00149EA2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FloroRanchPlayShopBuyResponse);
		}

		// Token: 0x060089A3 RID: 35235 RVA: 0x0014BCB0 File Offset: 0x00149EB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FloroRanchPlayShopBuyResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.Type == other.Type && this.CurCoin == other.CurCoin && this.CurDiamond == other.CurDiamond && object.Equals(this.Shop, other.Shop) && object.Equals(this.Card, other.Card) && object.Equals(this.CardGroup, other.CardGroup) && object.Equals(this.Toy, other.Toy) && this.DataCase == other.DataCase && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060089A4 RID: 35236 RVA: 0x0014BD80 File Offset: 0x00149F80
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

		// Token: 0x060089A5 RID: 35237 RVA: 0x0014BE7B File Offset: 0x0014A07B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060089A6 RID: 35238 RVA: 0x0014BE88 File Offset: 0x0014A088
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060089A7 RID: 35239 RVA: 0x0014BE94 File Offset: 0x0014A094
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.dataCase_ == FloroRanchPlayShopBuyResponse.DataOneofCase.Card)
			{
				output.WriteRawTag(58);
				output.WriteMessage(this.Card);
			}
			if (this.dataCase_ == FloroRanchPlayShopBuyResponse.DataOneofCase.Toy)
			{
				output.WriteRawTag(66);
				output.WriteMessage(this.Toy);
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(72);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.shop_ != null)
			{
				output.WriteRawTag(90);
				output.WriteMessage(this.Shop);
			}
			if (this.CurDiamond != 0L)
			{
				output.WriteRawTag(96);
				output.WriteInt64(this.CurDiamond);
			}
			if (this.dataCase_ == FloroRanchPlayShopBuyResponse.DataOneofCase.CardGroup)
			{
				output.WriteRawTag(106);
				output.WriteMessage(this.CardGroup);
			}
			if (this.CurCoin != 0L)
			{
				output.WriteRawTag(112);
				output.WriteInt64(this.CurCoin);
			}
			if (this.Type != FloroRanchPlayShopBuyType.BuyCard)
			{
				output.WriteRawTag(120);
				output.WriteEnum((int)this.Type);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060089A8 RID: 35240 RVA: 0x0014BF9C File Offset: 0x0014A19C
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

		// Token: 0x060089A9 RID: 35241 RVA: 0x0014C088 File Offset: 0x0014A288
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
				if (dataCase != FloroRanchPlayShopBuyResponse.DataOneofCase.Toy)
				{
					if (dataCase == FloroRanchPlayShopBuyResponse.DataOneofCase.CardGroup)
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
					if (this.Toy == null)
					{
						this.Toy = new FloroRanchPlayShopBuyToy();
					}
					this.Toy.MergeFrom(other.Toy);
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

		// Token: 0x060089AA RID: 35242 RVA: 0x0014C1B2 File Offset: 0x0014A3B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060089AB RID: 35243 RVA: 0x0014C1BC File Offset: 0x0014A3BC
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
				if (num <= 90U)
				{
					if (num <= 66U)
					{
						if (num == 58U)
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
						if (num == 66U)
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
					}
					else
					{
						if (num == 72U)
						{
							this.ErrorCode = (ErrorCode)input.ReadEnum();
							continue;
						}
						if (num == 90U)
						{
							if (this.shop_ == null)
							{
								this.Shop = new FloroRanchShop();
							}
							input.ReadMessage(this.Shop);
							continue;
						}
					}
				}
				else if (num <= 106U)
				{
					if (num == 96U)
					{
						this.CurDiamond = input.ReadInt64();
						continue;
					}
					if (num == 106U)
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
				else
				{
					if (num == 112U)
					{
						this.CurCoin = input.ReadInt64();
						continue;
					}
					if (num == 120U)
					{
						this.Type = (FloroRanchPlayShopBuyType)input.ReadEnum();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400439E RID: 17310
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400439F RID: 17311
		public const int ErrorCodeFieldNumber = 9;

		// Token: 0x040043A0 RID: 17312
		private ErrorCode errorCode_;

		// Token: 0x040043A1 RID: 17313
		public const int TypeFieldNumber = 15;

		// Token: 0x040043A2 RID: 17314
		private FloroRanchPlayShopBuyType type_;

		// Token: 0x040043A3 RID: 17315
		public const int CurCoinFieldNumber = 14;

		// Token: 0x040043A4 RID: 17316
		private long curCoin_;

		// Token: 0x040043A5 RID: 17317
		public const int CurDiamondFieldNumber = 12;

		// Token: 0x040043A6 RID: 17318
		private long curDiamond_;

		// Token: 0x040043A7 RID: 17319
		public const int ShopFieldNumber = 11;

		// Token: 0x040043A8 RID: 17320
		private FloroRanchShop shop_;

		// Token: 0x040043A9 RID: 17321
		public const int CardFieldNumber = 7;

		// Token: 0x040043AA RID: 17322
		public const int CardGroupFieldNumber = 13;

		// Token: 0x040043AB RID: 17323
		public const int ToyFieldNumber = 8;

		// Token: 0x040043AC RID: 17324
		private object data_;

		// Token: 0x040043AD RID: 17325
		private FloroRanchPlayShopBuyResponse.DataOneofCase dataCase_;

		// Token: 0x020017A0 RID: 6048
		public enum DataOneofCase
		{
			// Token: 0x0400C6C5 RID: 50885
			None,
			// Token: 0x0400C6C6 RID: 50886
			Card = 7,
			// Token: 0x0400C6C7 RID: 50887
			CardGroup = 13,
			// Token: 0x0400C6C8 RID: 50888
			Toy = 8
		}
	}
}
