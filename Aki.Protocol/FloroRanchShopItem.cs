using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020005E4 RID: 1508
	public sealed class FloroRanchShopItem : IMessage<FloroRanchShopItem>, IMessage, IEquatable<FloroRanchShopItem>, IDeepCloneable<FloroRanchShopItem>, IBufferMessage
	{
		// Token: 0x06008B86 RID: 35718 RVA: 0x00151817 File Offset: 0x0014FA17
		[NullableContext(1)]
		public static FloroRanchShopItem Create()
		{
			return new FloroRanchShopItem();
		}

		// Token: 0x17001B8E RID: 7054
		// (get) Token: 0x06008B87 RID: 35719 RVA: 0x0015181E File Offset: 0x0014FA1E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<FloroRanchShopItem> Parser
		{
			get
			{
				return FloroRanchShopItem._parser;
			}
		}

		// Token: 0x17001B8F RID: 7055
		// (get) Token: 0x06008B88 RID: 35720 RVA: 0x00151825 File Offset: 0x0014FA25
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001B90 RID: 7056
		// (get) Token: 0x06008B89 RID: 35721 RVA: 0x00151828 File Offset: 0x0014FA28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FloroRanchShopItem.Descriptor;
			}
		}

		// Token: 0x06008B8A RID: 35722 RVA: 0x0015182F File Offset: 0x0014FA2F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchShopItem()
		{
		}

		// Token: 0x06008B8B RID: 35723 RVA: 0x00151838 File Offset: 0x0014FA38
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

		// Token: 0x06008B8C RID: 35724 RVA: 0x00151898 File Offset: 0x0014FA98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchShopItem Clone()
		{
			return new FloroRanchShopItem(this);
		}

		// Token: 0x17001B91 RID: 7057
		// (get) Token: 0x06008B8D RID: 35725 RVA: 0x001518A0 File Offset: 0x0014FAA0
		// (set) Token: 0x06008B8E RID: 35726 RVA: 0x001518A8 File Offset: 0x0014FAA8
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

		// Token: 0x17001B92 RID: 7058
		// (get) Token: 0x06008B8F RID: 35727 RVA: 0x001518B1 File Offset: 0x0014FAB1
		// (set) Token: 0x06008B90 RID: 35728 RVA: 0x001518B9 File Offset: 0x0014FAB9
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

		// Token: 0x17001B93 RID: 7059
		// (get) Token: 0x06008B91 RID: 35729 RVA: 0x001518C2 File Offset: 0x0014FAC2
		// (set) Token: 0x06008B92 RID: 35730 RVA: 0x001518CA File Offset: 0x0014FACA
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

		// Token: 0x17001B94 RID: 7060
		// (get) Token: 0x06008B93 RID: 35731 RVA: 0x001518D3 File Offset: 0x0014FAD3
		// (set) Token: 0x06008B94 RID: 35732 RVA: 0x001518DB File Offset: 0x0014FADB
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

		// Token: 0x17001B95 RID: 7061
		// (get) Token: 0x06008B95 RID: 35733 RVA: 0x001518E4 File Offset: 0x0014FAE4
		// (set) Token: 0x06008B96 RID: 35734 RVA: 0x001518EC File Offset: 0x0014FAEC
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

		// Token: 0x06008B97 RID: 35735 RVA: 0x001518F5 File Offset: 0x0014FAF5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FloroRanchShopItem);
		}

		// Token: 0x06008B98 RID: 35736 RVA: 0x00151904 File Offset: 0x0014FB04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FloroRanchShopItem other)
		{
			return other != null && (other == this || (this.Type == other.Type && this.Id == other.Id && this.Price == other.Price && this.Sold == other.Sold && this.IncId == other.IncId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008B99 RID: 35737 RVA: 0x00151980 File Offset: 0x0014FB80
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

		// Token: 0x06008B9A RID: 35738 RVA: 0x00151A29 File Offset: 0x0014FC29
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06008B9B RID: 35739 RVA: 0x00151A36 File Offset: 0x0014FC36
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008B9C RID: 35740 RVA: 0x00151A40 File Offset: 0x0014FC40
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

		// Token: 0x06008B9D RID: 35741 RVA: 0x00151AEC File Offset: 0x0014FCEC
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

		// Token: 0x06008B9E RID: 35742 RVA: 0x00151B80 File Offset: 0x0014FD80
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

		// Token: 0x06008B9F RID: 35743 RVA: 0x00151C0C File Offset: 0x0014FE0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008BA0 RID: 35744 RVA: 0x00151C18 File Offset: 0x0014FE18
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

		// Token: 0x04004469 RID: 17513
		private static readonly MessageParser<FloroRanchShopItem> _parser = new MessageParser<FloroRanchShopItem>(() => new FloroRanchShopItem());

		// Token: 0x0400446A RID: 17514
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400446B RID: 17515
		public const int TypeFieldNumber = 1;

		// Token: 0x0400446C RID: 17516
		private FloroRanchShopItemType type_;

		// Token: 0x0400446D RID: 17517
		public const int IdFieldNumber = 2;

		// Token: 0x0400446E RID: 17518
		private int id_;

		// Token: 0x0400446F RID: 17519
		public const int PriceFieldNumber = 3;

		// Token: 0x04004470 RID: 17520
		private int price_;

		// Token: 0x04004471 RID: 17521
		public const int SoldFieldNumber = 4;

		// Token: 0x04004472 RID: 17522
		private bool sold_;

		// Token: 0x04004473 RID: 17523
		public const int IncIdFieldNumber = 5;

		// Token: 0x04004474 RID: 17524
		private int incId_;
	}
}
