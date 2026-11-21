using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200115F RID: 4447
	public sealed class RoverRogueShopItem : IMessage<RoverRogueShopItem>, IMessage, IEquatable<RoverRogueShopItem>, IDeepCloneable<RoverRogueShopItem>, IBufferMessage
	{
		// Token: 0x06017C41 RID: 97345 RVA: 0x00375E3C File Offset: 0x0037403C
		[NullableContext(1)]
		public static RoverRogueShopItem Create()
		{
			return new RoverRogueShopItem();
		}

		// Token: 0x17005002 RID: 20482
		// (get) Token: 0x06017C42 RID: 97346 RVA: 0x00375E43 File Offset: 0x00374043
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005003 RID: 20483
		// (get) Token: 0x06017C43 RID: 97347 RVA: 0x00375E46 File Offset: 0x00374046
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoverRogueShopItem.Descriptor;
			}
		}

		// Token: 0x06017C44 RID: 97348 RVA: 0x00375E4D File Offset: 0x0037404D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueShopItem()
		{
		}

		// Token: 0x06017C45 RID: 97349 RVA: 0x00375E58 File Offset: 0x00374058
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

		// Token: 0x06017C46 RID: 97350 RVA: 0x00375EAC File Offset: 0x003740AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueShopItem Clone()
		{
			return new RoverRogueShopItem(this);
		}

		// Token: 0x17005004 RID: 20484
		// (get) Token: 0x06017C47 RID: 97351 RVA: 0x00375EB4 File Offset: 0x003740B4
		// (set) Token: 0x06017C48 RID: 97352 RVA: 0x00375EBC File Offset: 0x003740BC
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

		// Token: 0x17005005 RID: 20485
		// (get) Token: 0x06017C49 RID: 97353 RVA: 0x00375EC5 File Offset: 0x003740C5
		// (set) Token: 0x06017C4A RID: 97354 RVA: 0x00375ECD File Offset: 0x003740CD
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

		// Token: 0x17005006 RID: 20486
		// (get) Token: 0x06017C4B RID: 97355 RVA: 0x00375ED6 File Offset: 0x003740D6
		// (set) Token: 0x06017C4C RID: 97356 RVA: 0x00375EDE File Offset: 0x003740DE
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

		// Token: 0x17005007 RID: 20487
		// (get) Token: 0x06017C4D RID: 97357 RVA: 0x00375EE7 File Offset: 0x003740E7
		// (set) Token: 0x06017C4E RID: 97358 RVA: 0x00375EEF File Offset: 0x003740EF
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

		// Token: 0x06017C4F RID: 97359 RVA: 0x00375EF8 File Offset: 0x003740F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoverRogueShopItem);
		}

		// Token: 0x06017C50 RID: 97360 RVA: 0x00375F08 File Offset: 0x00374108
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoverRogueShopItem other)
		{
			return other != null && (other == this || (this.IncId == other.IncId && this.ItemId == other.ItemId && this.FinalPrice == other.FinalPrice && this.IsBought == other.IsBought && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06017C51 RID: 97361 RVA: 0x00375F74 File Offset: 0x00374174
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

		// Token: 0x06017C52 RID: 97362 RVA: 0x00375FFE File Offset: 0x003741FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06017C53 RID: 97363 RVA: 0x0037600B File Offset: 0x0037420B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06017C54 RID: 97364 RVA: 0x00376014 File Offset: 0x00374214
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

		// Token: 0x06017C55 RID: 97365 RVA: 0x003760A4 File Offset: 0x003742A4
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

		// Token: 0x06017C56 RID: 97366 RVA: 0x00376120 File Offset: 0x00374320
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

		// Token: 0x06017C57 RID: 97367 RVA: 0x00376198 File Offset: 0x00374398
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06017C58 RID: 97368 RVA: 0x003761A4 File Offset: 0x003743A4
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

		// Token: 0x04008DD7 RID: 36311
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008DD8 RID: 36312
		public const int IncIdFieldNumber = 1;

		// Token: 0x04008DD9 RID: 36313
		private int incId_;

		// Token: 0x04008DDA RID: 36314
		public const int ItemIdFieldNumber = 2;

		// Token: 0x04008DDB RID: 36315
		private int itemId_;

		// Token: 0x04008DDC RID: 36316
		public const int FinalPriceFieldNumber = 3;

		// Token: 0x04008DDD RID: 36317
		private int finalPrice_;

		// Token: 0x04008DDE RID: 36318
		public const int IsBoughtFieldNumber = 4;

		// Token: 0x04008DDF RID: 36319
		private bool isBought_;
	}
}
