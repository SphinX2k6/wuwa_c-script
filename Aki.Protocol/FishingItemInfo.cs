using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000556 RID: 1366
	public sealed class FishingItemInfo : IMessage<FishingItemInfo>, IMessage, IEquatable<FishingItemInfo>, IDeepCloneable<FishingItemInfo>, IBufferMessage
	{
		// Token: 0x06007FC6 RID: 32710 RVA: 0x00135582 File Offset: 0x00133782
		[NullableContext(1)]
		public static FishingItemInfo Create()
		{
			return new FishingItemInfo();
		}

		// Token: 0x170018E0 RID: 6368
		// (get) Token: 0x06007FC7 RID: 32711 RVA: 0x00135589 File Offset: 0x00133789
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<FishingItemInfo> Parser
		{
			get
			{
				return FishingItemInfo._parser;
			}
		}

		// Token: 0x170018E1 RID: 6369
		// (get) Token: 0x06007FC8 RID: 32712 RVA: 0x00135590 File Offset: 0x00133790
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170018E2 RID: 6370
		// (get) Token: 0x06007FC9 RID: 32713 RVA: 0x00135593 File Offset: 0x00133793
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FishingItemInfo.Descriptor;
			}
		}

		// Token: 0x06007FCA RID: 32714 RVA: 0x0013559A File Offset: 0x0013379A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingItemInfo()
		{
		}

		// Token: 0x06007FCB RID: 32715 RVA: 0x001355A4 File Offset: 0x001337A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingItemInfo(FishingItemInfo other) : this()
		{
			this.itemId_ = other.itemId_;
			this.incrId_ = other.incrId_;
			this.rotate_ = other.rotate_;
			this.pos_ = ((other.pos_ != null) ? other.pos_.Clone() : null);
			this.size_ = other.size_;
			this.cup_ = other.cup_;
			this.quality_ = other.quality_;
			this.price_ = other.price_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007FCC RID: 32716 RVA: 0x00135638 File Offset: 0x00133838
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingItemInfo Clone()
		{
			return new FishingItemInfo(this);
		}

		// Token: 0x170018E3 RID: 6371
		// (get) Token: 0x06007FCD RID: 32717 RVA: 0x00135640 File Offset: 0x00133840
		// (set) Token: 0x06007FCE RID: 32718 RVA: 0x00135648 File Offset: 0x00133848
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

		// Token: 0x170018E4 RID: 6372
		// (get) Token: 0x06007FCF RID: 32719 RVA: 0x00135651 File Offset: 0x00133851
		// (set) Token: 0x06007FD0 RID: 32720 RVA: 0x00135659 File Offset: 0x00133859
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int IncrId
		{
			get
			{
				return this.incrId_;
			}
			set
			{
				this.incrId_ = value;
			}
		}

		// Token: 0x170018E5 RID: 6373
		// (get) Token: 0x06007FD1 RID: 32721 RVA: 0x00135662 File Offset: 0x00133862
		// (set) Token: 0x06007FD2 RID: 32722 RVA: 0x0013566A File Offset: 0x0013386A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingItemRotate Rotate
		{
			get
			{
				return this.rotate_;
			}
			set
			{
				this.rotate_ = value;
			}
		}

		// Token: 0x170018E6 RID: 6374
		// (get) Token: 0x06007FD3 RID: 32723 RVA: 0x00135673 File Offset: 0x00133873
		// (set) Token: 0x06007FD4 RID: 32724 RVA: 0x0013567B File Offset: 0x0013387B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public IntVector2D Pos
		{
			get
			{
				return this.pos_;
			}
			set
			{
				this.pos_ = value;
			}
		}

		// Token: 0x170018E7 RID: 6375
		// (get) Token: 0x06007FD5 RID: 32725 RVA: 0x00135684 File Offset: 0x00133884
		// (set) Token: 0x06007FD6 RID: 32726 RVA: 0x0013568C File Offset: 0x0013388C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Size
		{
			get
			{
				return this.size_;
			}
			set
			{
				this.size_ = value;
			}
		}

		// Token: 0x170018E8 RID: 6376
		// (get) Token: 0x06007FD7 RID: 32727 RVA: 0x00135695 File Offset: 0x00133895
		// (set) Token: 0x06007FD8 RID: 32728 RVA: 0x0013569D File Offset: 0x0013389D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishCup Cup
		{
			get
			{
				return this.cup_;
			}
			set
			{
				this.cup_ = value;
			}
		}

		// Token: 0x170018E9 RID: 6377
		// (get) Token: 0x06007FD9 RID: 32729 RVA: 0x001356A6 File Offset: 0x001338A6
		// (set) Token: 0x06007FDA RID: 32730 RVA: 0x001356AE File Offset: 0x001338AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Quality
		{
			get
			{
				return this.quality_;
			}
			set
			{
				this.quality_ = value;
			}
		}

		// Token: 0x170018EA RID: 6378
		// (get) Token: 0x06007FDB RID: 32731 RVA: 0x001356B7 File Offset: 0x001338B7
		// (set) Token: 0x06007FDC RID: 32732 RVA: 0x001356BF File Offset: 0x001338BF
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

		// Token: 0x06007FDD RID: 32733 RVA: 0x001356C8 File Offset: 0x001338C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FishingItemInfo);
		}

		// Token: 0x06007FDE RID: 32734 RVA: 0x001356D8 File Offset: 0x001338D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FishingItemInfo other)
		{
			return other != null && (other == this || (this.ItemId == other.ItemId && this.IncrId == other.IncrId && this.Rotate == other.Rotate && object.Equals(this.Pos, other.Pos) && this.Size == other.Size && this.Cup == other.Cup && this.Quality == other.Quality && this.Price == other.Price && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007FDF RID: 32735 RVA: 0x00135788 File Offset: 0x00133988
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ItemId != 0)
			{
				num ^= this.ItemId.GetHashCode();
			}
			if (this.IncrId != 0)
			{
				num ^= this.IncrId.GetHashCode();
			}
			if (this.Rotate != FishingItemRotate.No)
			{
				num ^= this.Rotate.GetHashCode();
			}
			if (this.pos_ != null)
			{
				num ^= this.Pos.GetHashCode();
			}
			if (this.Size != 0)
			{
				num ^= this.Size.GetHashCode();
			}
			if (this.Cup != FishCup.SilverCup)
			{
				num ^= this.Cup.GetHashCode();
			}
			if (this.Quality != 0)
			{
				num ^= this.Quality.GetHashCode();
			}
			if (this.Price != 0)
			{
				num ^= this.Price.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06007FE0 RID: 32736 RVA: 0x0013587F File Offset: 0x00133A7F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06007FE1 RID: 32737 RVA: 0x0013588C File Offset: 0x00133A8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007FE2 RID: 32738 RVA: 0x00135898 File Offset: 0x00133A98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ItemId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.ItemId);
			}
			if (this.IncrId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.IncrId);
			}
			if (this.Rotate != FishingItemRotate.No)
			{
				output.WriteRawTag(32);
				output.WriteEnum((int)this.Rotate);
			}
			if (this.pos_ != null)
			{
				output.WriteRawTag(42);
				output.WriteMessage(this.Pos);
			}
			if (this.Size != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.Size);
			}
			if (this.Cup != FishCup.SilverCup)
			{
				output.WriteRawTag(56);
				output.WriteEnum((int)this.Cup);
			}
			if (this.Quality != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.Quality);
			}
			if (this.Price != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.Price);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007FE3 RID: 32739 RVA: 0x00135998 File Offset: 0x00133B98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ItemId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ItemId);
			}
			if (this.IncrId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.IncrId);
			}
			if (this.Rotate != FishingItemRotate.No)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Rotate);
			}
			if (this.pos_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Pos);
			}
			if (this.Size != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Size);
			}
			if (this.Cup != FishCup.SilverCup)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Cup);
			}
			if (this.Quality != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Quality);
			}
			if (this.Price != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Price);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06007FE4 RID: 32740 RVA: 0x00135A80 File Offset: 0x00133C80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FishingItemInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ItemId != 0)
			{
				this.ItemId = other.ItemId;
			}
			if (other.IncrId != 0)
			{
				this.IncrId = other.IncrId;
			}
			if (other.Rotate != FishingItemRotate.No)
			{
				this.Rotate = other.Rotate;
			}
			if (other.pos_ != null)
			{
				if (this.pos_ == null)
				{
					this.Pos = new IntVector2D();
				}
				this.Pos.MergeFrom(other.Pos);
			}
			if (other.Size != 0)
			{
				this.Size = other.Size;
			}
			if (other.Cup != FishCup.SilverCup)
			{
				this.Cup = other.Cup;
			}
			if (other.Quality != 0)
			{
				this.Quality = other.Quality;
			}
			if (other.Price != 0)
			{
				this.Price = other.Price;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06007FE5 RID: 32741 RVA: 0x00135B60 File Offset: 0x00133D60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007FE6 RID: 32742 RVA: 0x00135B6C File Offset: 0x00133D6C
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
					if (num <= 16U)
					{
						if (num == 8U)
						{
							this.ItemId = input.ReadInt32();
							continue;
						}
						if (num == 16U)
						{
							this.IncrId = input.ReadInt32();
							continue;
						}
					}
					else
					{
						if (num == 32U)
						{
							this.Rotate = (FishingItemRotate)input.ReadEnum();
							continue;
						}
						if (num == 42U)
						{
							if (this.pos_ == null)
							{
								this.Pos = new IntVector2D();
							}
							input.ReadMessage(this.Pos);
							continue;
						}
					}
				}
				else if (num <= 56U)
				{
					if (num == 48U)
					{
						this.Size = input.ReadInt32();
						continue;
					}
					if (num == 56U)
					{
						this.Cup = (FishCup)input.ReadEnum();
						continue;
					}
				}
				else
				{
					if (num == 64U)
					{
						this.Quality = input.ReadInt32();
						continue;
					}
					if (num == 72U)
					{
						this.Price = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040040E0 RID: 16608
		private static readonly MessageParser<FishingItemInfo> _parser = new MessageParser<FishingItemInfo>(() => new FishingItemInfo());

		// Token: 0x040040E1 RID: 16609
		private UnknownFieldSet _unknownFields;

		// Token: 0x040040E2 RID: 16610
		public const int ItemIdFieldNumber = 1;

		// Token: 0x040040E3 RID: 16611
		private int itemId_;

		// Token: 0x040040E4 RID: 16612
		public const int IncrIdFieldNumber = 2;

		// Token: 0x040040E5 RID: 16613
		private int incrId_;

		// Token: 0x040040E6 RID: 16614
		public const int RotateFieldNumber = 4;

		// Token: 0x040040E7 RID: 16615
		private FishingItemRotate rotate_;

		// Token: 0x040040E8 RID: 16616
		public const int PosFieldNumber = 5;

		// Token: 0x040040E9 RID: 16617
		private IntVector2D pos_;

		// Token: 0x040040EA RID: 16618
		public const int SizeFieldNumber = 6;

		// Token: 0x040040EB RID: 16619
		private int size_;

		// Token: 0x040040EC RID: 16620
		public const int CupFieldNumber = 7;

		// Token: 0x040040ED RID: 16621
		private FishCup cup_;

		// Token: 0x040040EE RID: 16622
		public const int QualityFieldNumber = 8;

		// Token: 0x040040EF RID: 16623
		private int quality_;

		// Token: 0x040040F0 RID: 16624
		public const int PriceFieldNumber = 9;

		// Token: 0x040040F1 RID: 16625
		private int price_;
	}
}
