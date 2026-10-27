using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001125 RID: 4389
	public sealed class RoverRogueShopItem : IMessage<RoverRogueShopItem>, IMessage, IEquatable<RoverRogueShopItem>, IDeepCloneable<RoverRogueShopItem>, IBufferMessage
	{
		// Token: 0x060176A0 RID: 95904 RVA: 0x00366AF0 File Offset: 0x00364CF0
		[NullableContext(1)]
		public static RoverRogueShopItem Create()
		{
			return new RoverRogueShopItem();
		}

		// Token: 0x17004E96 RID: 20118
		// (get) Token: 0x060176A1 RID: 95905 RVA: 0x00366AF7 File Offset: 0x00364CF7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004E97 RID: 20119
		// (get) Token: 0x060176A2 RID: 95906 RVA: 0x00366AFA File Offset: 0x00364CFA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoverRogueShopItem.Descriptor;
			}
		}

		// Token: 0x060176A3 RID: 95907 RVA: 0x00366B01 File Offset: 0x00364D01
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueShopItem()
		{
		}

		// Token: 0x060176A4 RID: 95908 RVA: 0x00366B0C File Offset: 0x00364D0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueShopItem(RoverRogueShopItem other) : this()
		{
			this.incId_ = other.incId_;
			this.itemId_ = other.itemId_;
			this.finalPrice_ = other.finalPrice_;
			this.isBought_ = other.isBought_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060176A5 RID: 95909 RVA: 0x00366B60 File Offset: 0x00364D60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueShopItem Clone()
		{
			return new RoverRogueShopItem(this);
		}

		// Token: 0x17004E98 RID: 20120
		// (get) Token: 0x060176A6 RID: 95910 RVA: 0x00366B68 File Offset: 0x00364D68
		// (set) Token: 0x060176A7 RID: 95911 RVA: 0x00366B70 File Offset: 0x00364D70
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

		// Token: 0x17004E99 RID: 20121
		// (get) Token: 0x060176A8 RID: 95912 RVA: 0x00366B79 File Offset: 0x00364D79
		// (set) Token: 0x060176A9 RID: 95913 RVA: 0x00366B81 File Offset: 0x00364D81
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ItemId
		{
			get
			{
				return this.itemId_;
			}
			set
			{
				this.itemId_ = value;
			}
		}

		// Token: 0x17004E9A RID: 20122
		// (get) Token: 0x060176AA RID: 95914 RVA: 0x00366B8A File Offset: 0x00364D8A
		// (set) Token: 0x060176AB RID: 95915 RVA: 0x00366B92 File Offset: 0x00364D92
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int FinalPrice
		{
			get
			{
				return this.finalPrice_;
			}
			set
			{
				this.finalPrice_ = value;
			}
		}

		// Token: 0x17004E9B RID: 20123
		// (get) Token: 0x060176AC RID: 95916 RVA: 0x00366B9B File Offset: 0x00364D9B
		// (set) Token: 0x060176AD RID: 95917 RVA: 0x00366BA3 File Offset: 0x00364DA3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsBought
		{
			get
			{
				return this.isBought_;
			}
			set
			{
				this.isBought_ = value;
			}
		}

		// Token: 0x060176AE RID: 95918 RVA: 0x00366BAC File Offset: 0x00364DAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoverRogueShopItem);
		}

		// Token: 0x060176AF RID: 95919 RVA: 0x00366BBC File Offset: 0x00364DBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoverRogueShopItem other)
		{
			return other != null && (other == this || (this.IncId == other.IncId && this.ItemId == other.ItemId && this.FinalPrice == other.FinalPrice && this.IsBought == other.IsBought && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060176B0 RID: 95920 RVA: 0x00366C28 File Offset: 0x00364E28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.IncId != 0)
			{
				num ^= this.IncId.GetHashCode();
			}
			if (this.ItemId != 0)
			{
				num ^= this.ItemId.GetHashCode();
			}
			if (this.FinalPrice != 0)
			{
				num ^= this.FinalPrice.GetHashCode();
			}
			if (this.IsBought)
			{
				num ^= this.IsBought.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060176B1 RID: 95921 RVA: 0x00366CB2 File Offset: 0x00364EB2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060176B2 RID: 95922 RVA: 0x00366CBF File Offset: 0x00364EBF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060176B3 RID: 95923 RVA: 0x00366CC8 File Offset: 0x00364EC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.IncId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.IncId);
			}
			if (this.ItemId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.ItemId);
			}
			if (this.FinalPrice != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.FinalPrice);
			}
			if (this.IsBought)
			{
				output.WriteRawTag(32);
				output.WriteBool(this.IsBought);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060176B4 RID: 95924 RVA: 0x00366D58 File Offset: 0x00364F58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.IncId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.IncId);
			}
			if (this.ItemId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ItemId);
			}
			if (this.FinalPrice != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.FinalPrice);
			}
			if (this.IsBought)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060176B5 RID: 95925 RVA: 0x00366DD4 File Offset: 0x00364FD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoverRogueShopItem other)
		{
			if (other == null)
			{
				return;
			}
			if (other.IncId != 0)
			{
				this.IncId = other.IncId;
			}
			if (other.ItemId != 0)
			{
				this.ItemId = other.ItemId;
			}
			if (other.FinalPrice != 0)
			{
				this.FinalPrice = other.FinalPrice;
			}
			if (other.IsBought)
			{
				this.IsBought = other.IsBought;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060176B6 RID: 95926 RVA: 0x00366E4C File Offset: 0x0036504C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060176B7 RID: 95927 RVA: 0x00366E58 File Offset: 0x00365058
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
						this.IncId = input.ReadInt32();
						continue;
					}
					if (num == 16U)
					{
						this.ItemId = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 24U)
					{
						this.FinalPrice = input.ReadInt32();
						continue;
					}
					if (num == 32U)
					{
						this.IsBought = input.ReadBool();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04008B44 RID: 35652
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008B45 RID: 35653
		public const int IncIdFieldNumber = 1;

		// Token: 0x04008B46 RID: 35654
		private int incId_;

		// Token: 0x04008B47 RID: 35655
		public const int ItemIdFieldNumber = 2;

		// Token: 0x04008B48 RID: 35656
		private int itemId_;

		// Token: 0x04008B49 RID: 35657
		public const int FinalPriceFieldNumber = 3;

		// Token: 0x04008B4A RID: 35658
		private int finalPrice_;

		// Token: 0x04008B4B RID: 35659
		public const int IsBoughtFieldNumber = 4;

		// Token: 0x04008B4C RID: 35660
		private bool isBought_;
	}
}
