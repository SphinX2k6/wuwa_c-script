using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020005CF RID: 1487
	public sealed class FloroRanchShopItem : IMessage<FloroRanchShopItem>, IMessage, IEquatable<FloroRanchShopItem>, IDeepCloneable<FloroRanchShopItem>, IBufferMessage
	{
		// Token: 0x06008A1E RID: 35358 RVA: 0x0014EC03 File Offset: 0x0014CE03
		[NullableContext(1)]
		public static FloroRanchShopItem Create()
		{
			return new FloroRanchShopItem();
		}

		// Token: 0x17001B41 RID: 6977
		// (get) Token: 0x06008A1F RID: 35359 RVA: 0x0014EC0A File Offset: 0x0014CE0A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<FloroRanchShopItem> Parser
		{
			get
			{
				return FloroRanchShopItem._parser;
			}
		}

		// Token: 0x17001B42 RID: 6978
		// (get) Token: 0x06008A20 RID: 35360 RVA: 0x0014EC11 File Offset: 0x0014CE11
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001B43 RID: 6979
		// (get) Token: 0x06008A21 RID: 35361 RVA: 0x0014EC14 File Offset: 0x0014CE14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FloroRanchShopItem.Descriptor;
			}
		}

		// Token: 0x06008A22 RID: 35362 RVA: 0x0014EC1B File Offset: 0x0014CE1B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchShopItem()
		{
		}

		// Token: 0x06008A23 RID: 35363 RVA: 0x0014EC24 File Offset: 0x0014CE24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchShopItem(FloroRanchShopItem other) : this()
		{
			this.type_ = other.type_;
			this.id_ = other.id_;
			this.price_ = other.price_;
			this.sold_ = other.sold_;
			this.incId_ = other.incId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008A24 RID: 35364 RVA: 0x0014EC84 File Offset: 0x0014CE84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchShopItem Clone()
		{
			return new FloroRanchShopItem(this);
		}

		// Token: 0x17001B44 RID: 6980
		// (get) Token: 0x06008A25 RID: 35365 RVA: 0x0014EC8C File Offset: 0x0014CE8C
		// (set) Token: 0x06008A26 RID: 35366 RVA: 0x0014EC94 File Offset: 0x0014CE94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchShopItemType Type
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

		// Token: 0x17001B45 RID: 6981
		// (get) Token: 0x06008A27 RID: 35367 RVA: 0x0014EC9D File Offset: 0x0014CE9D
		// (set) Token: 0x06008A28 RID: 35368 RVA: 0x0014ECA5 File Offset: 0x0014CEA5
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

		// Token: 0x17001B46 RID: 6982
		// (get) Token: 0x06008A29 RID: 35369 RVA: 0x0014ECAE File Offset: 0x0014CEAE
		// (set) Token: 0x06008A2A RID: 35370 RVA: 0x0014ECB6 File Offset: 0x0014CEB6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Price
		{
			get
			{
				return this.price_;
			}
			set
			{
				this.price_ = value;
			}
		}

		// Token: 0x17001B47 RID: 6983
		// (get) Token: 0x06008A2B RID: 35371 RVA: 0x0014ECBF File Offset: 0x0014CEBF
		// (set) Token: 0x06008A2C RID: 35372 RVA: 0x0014ECC7 File Offset: 0x0014CEC7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Sold
		{
			get
			{
				return this.sold_;
			}
			set
			{
				this.sold_ = value;
			}
		}

		// Token: 0x17001B48 RID: 6984
		// (get) Token: 0x06008A2D RID: 35373 RVA: 0x0014ECD0 File Offset: 0x0014CED0
		// (set) Token: 0x06008A2E RID: 35374 RVA: 0x0014ECD8 File Offset: 0x0014CED8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int IncId
		{
			get
			{
				return this.incId_;
			}
			set
			{
				this.incId_ = value;
			}
		}

		// Token: 0x06008A2F RID: 35375 RVA: 0x0014ECE1 File Offset: 0x0014CEE1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FloroRanchShopItem);
		}

		// Token: 0x06008A30 RID: 35376 RVA: 0x0014ECF0 File Offset: 0x0014CEF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FloroRanchShopItem other)
		{
			return other != null && (other == this || (this.Type == other.Type && this.Id == other.Id && this.Price == other.Price && this.Sold == other.Sold && this.IncId == other.IncId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008A31 RID: 35377 RVA: 0x0014ED6C File Offset: 0x0014CF6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Type != FloroRanchShopItemType.Card)
			{
				num ^= this.Type.GetHashCode();
			}
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.Price != 0)
			{
				num ^= this.Price.GetHashCode();
			}
			if (this.Sold)
			{
				num ^= this.Sold.GetHashCode();
			}
			if (this.IncId != 0)
			{
				num ^= this.IncId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008A32 RID: 35378 RVA: 0x0014EE15 File Offset: 0x0014D015
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06008A33 RID: 35379 RVA: 0x0014EE22 File Offset: 0x0014D022
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008A34 RID: 35380 RVA: 0x0014EE2C File Offset: 0x0014D02C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Type != FloroRanchShopItemType.Card)
			{
				output.WriteRawTag(8);
				output.WriteEnum((int)this.Type);
			}
			if (this.Id != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Id);
			}
			if (this.Price != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.Price);
			}
			if (this.Sold)
			{
				output.WriteRawTag(32);
				output.WriteBool(this.Sold);
			}
			if (this.IncId != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.IncId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008A35 RID: 35381 RVA: 0x0014EED8 File Offset: 0x0014D0D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Type != FloroRanchShopItemType.Card)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Type);
			}
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			if (this.Price != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Price);
			}
			if (this.Sold)
			{
				num += 2;
			}
			if (this.IncId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.IncId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008A36 RID: 35382 RVA: 0x0014EF6C File Offset: 0x0014D16C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FloroRanchShopItem other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Type != FloroRanchShopItemType.Card)
			{
				this.Type = other.Type;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			if (other.Price != 0)
			{
				this.Price = other.Price;
			}
			if (other.Sold)
			{
				this.Sold = other.Sold;
			}
			if (other.IncId != 0)
			{
				this.IncId = other.IncId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06008A37 RID: 35383 RVA: 0x0014EFF8 File Offset: 0x0014D1F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008A38 RID: 35384 RVA: 0x0014F004 File Offset: 0x0014D204
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
				if (num <= 16U)
				{
					if (num == 8U)
					{
						this.Type = (FloroRanchShopItemType)input.ReadEnum();
						continue;
					}
					if (num == 16U)
					{
						this.Id = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 24U)
					{
						this.Price = input.ReadInt32();
						continue;
					}
					if (num == 32U)
					{
						this.Sold = input.ReadBool();
						continue;
					}
					if (num == 40U)
					{
						this.IncId = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400445F RID: 17503
		private static readonly MessageParser<FloroRanchShopItem> _parser = new MessageParser<FloroRanchShopItem>(() => new FloroRanchShopItem());

		// Token: 0x04004460 RID: 17504
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004461 RID: 17505
		public const int TypeFieldNumber = 1;

		// Token: 0x04004462 RID: 17506
		private FloroRanchShopItemType type_;

		// Token: 0x04004463 RID: 17507
		public const int IdFieldNumber = 2;

		// Token: 0x04004464 RID: 17508
		private int id_;

		// Token: 0x04004465 RID: 17509
		public const int PriceFieldNumber = 3;

		// Token: 0x04004466 RID: 17510
		private int price_;

		// Token: 0x04004467 RID: 17511
		public const int SoldFieldNumber = 4;

		// Token: 0x04004468 RID: 17512
		private bool sold_;

		// Token: 0x04004469 RID: 17513
		public const int IncIdFieldNumber = 5;

		// Token: 0x0400446A RID: 17514
		private int incId_;
	}
}
