using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200056B RID: 1387
	public sealed class FishingItemInfo : IMessage<FishingItemInfo>, IMessage, IEquatable<FishingItemInfo>, IDeepCloneable<FishingItemInfo>, IBufferMessage
	{
		// Token: 0x0600812E RID: 33070 RVA: 0x00138182 File Offset: 0x00136382
		[NullableContext(1)]
		public static FishingItemInfo Create()
		{
			return new FishingItemInfo();
		}

		// Token: 0x1700192D RID: 6445
		// (get) Token: 0x0600812F RID: 33071 RVA: 0x00138189 File Offset: 0x00136389
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<FishingItemInfo> Parser
		{
			get
			{
				return FishingItemInfo._parser;
			}
		}

		// Token: 0x1700192E RID: 6446
		// (get) Token: 0x06008130 RID: 33072 RVA: 0x00138190 File Offset: 0x00136390
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700192F RID: 6447
		// (get) Token: 0x06008131 RID: 33073 RVA: 0x00138193 File Offset: 0x00136393
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FishingItemInfo.Descriptor;
			}
		}

		// Token: 0x06008132 RID: 33074 RVA: 0x0013819A File Offset: 0x0013639A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingItemInfo()
		{
		}

		// Token: 0x06008133 RID: 33075 RVA: 0x001381A4 File Offset: 0x001363A4
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

		// Token: 0x06008134 RID: 33076 RVA: 0x00138238 File Offset: 0x00136438
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingItemInfo Clone()
		{
			return new FishingItemInfo(this);
		}

		// Token: 0x17001930 RID: 6448
		// (get) Token: 0x06008135 RID: 33077 RVA: 0x00138240 File Offset: 0x00136440
		// (set) Token: 0x06008136 RID: 33078 RVA: 0x00138248 File Offset: 0x00136448
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

		// Token: 0x17001931 RID: 6449
		// (get) Token: 0x06008137 RID: 33079 RVA: 0x00138251 File Offset: 0x00136451
		// (set) Token: 0x06008138 RID: 33080 RVA: 0x00138259 File Offset: 0x00136459
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

		// Token: 0x17001932 RID: 6450
		// (get) Token: 0x06008139 RID: 33081 RVA: 0x00138262 File Offset: 0x00136462
		// (set) Token: 0x0600813A RID: 33082 RVA: 0x0013826A File Offset: 0x0013646A
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

		// Token: 0x17001933 RID: 6451
		// (get) Token: 0x0600813B RID: 33083 RVA: 0x00138273 File Offset: 0x00136473
		// (set) Token: 0x0600813C RID: 33084 RVA: 0x0013827B File Offset: 0x0013647B
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

		// Token: 0x17001934 RID: 6452
		// (get) Token: 0x0600813D RID: 33085 RVA: 0x00138284 File Offset: 0x00136484
		// (set) Token: 0x0600813E RID: 33086 RVA: 0x0013828C File Offset: 0x0013648C
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

		// Token: 0x17001935 RID: 6453
		// (get) Token: 0x0600813F RID: 33087 RVA: 0x00138295 File Offset: 0x00136495
		// (set) Token: 0x06008140 RID: 33088 RVA: 0x0013829D File Offset: 0x0013649D
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

		// Token: 0x17001936 RID: 6454
		// (get) Token: 0x06008141 RID: 33089 RVA: 0x001382A6 File Offset: 0x001364A6
		// (set) Token: 0x06008142 RID: 33090 RVA: 0x001382AE File Offset: 0x001364AE
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

		// Token: 0x17001937 RID: 6455
		// (get) Token: 0x06008143 RID: 33091 RVA: 0x001382B7 File Offset: 0x001364B7
		// (set) Token: 0x06008144 RID: 33092 RVA: 0x001382BF File Offset: 0x001364BF
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

		// Token: 0x06008145 RID: 33093 RVA: 0x001382C8 File Offset: 0x001364C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FishingItemInfo);
		}

		// Token: 0x06008146 RID: 33094 RVA: 0x001382D8 File Offset: 0x001364D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FishingItemInfo other)
		{
			return other != null && (other == this || (this.ItemId == other.ItemId && this.IncrId == other.IncrId && this.Rotate == other.Rotate && object.Equals(this.Pos, other.Pos) && this.Size == other.Size && this.Cup == other.Cup && this.Quality == other.Quality && this.Price == other.Price && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008147 RID: 33095 RVA: 0x00138388 File Offset: 0x00136588
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

		// Token: 0x06008148 RID: 33096 RVA: 0x0013847F File Offset: 0x0013667F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06008149 RID: 33097 RVA: 0x0013848C File Offset: 0x0013668C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600814A RID: 33098 RVA: 0x00138498 File Offset: 0x00136698
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

		// Token: 0x0600814B RID: 33099 RVA: 0x00138598 File Offset: 0x00136798
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

		// Token: 0x0600814C RID: 33100 RVA: 0x00138680 File Offset: 0x00136880
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

		// Token: 0x0600814D RID: 33101 RVA: 0x00138760 File Offset: 0x00136960
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600814E RID: 33102 RVA: 0x0013876C File Offset: 0x0013696C
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

		// Token: 0x040040EA RID: 16618
		private static readonly MessageParser<FishingItemInfo> _parser = new MessageParser<FishingItemInfo>(() => new FishingItemInfo());

		// Token: 0x040040EB RID: 16619
		private UnknownFieldSet _unknownFields;

		// Token: 0x040040EC RID: 16620
		public const int ItemIdFieldNumber = 1;

		// Token: 0x040040ED RID: 16621
		private int itemId_;

		// Token: 0x040040EE RID: 16622
		public const int IncrIdFieldNumber = 2;

		// Token: 0x040040EF RID: 16623
		private int incrId_;

		// Token: 0x040040F0 RID: 16624
		public const int RotateFieldNumber = 4;

		// Token: 0x040040F1 RID: 16625
		private FishingItemRotate rotate_;

		// Token: 0x040040F2 RID: 16626
		public const int PosFieldNumber = 5;

		// Token: 0x040040F3 RID: 16627
		private IntVector2D pos_;

		// Token: 0x040040F4 RID: 16628
		public const int SizeFieldNumber = 6;

		// Token: 0x040040F5 RID: 16629
		private int size_;

		// Token: 0x040040F6 RID: 16630
		public const int CupFieldNumber = 7;

		// Token: 0x040040F7 RID: 16631
		private FishCup cup_;

		// Token: 0x040040F8 RID: 16632
		public const int QualityFieldNumber = 8;

		// Token: 0x040040F9 RID: 16633
		private int quality_;

		// Token: 0x040040FA RID: 16634
		public const int PriceFieldNumber = 9;

		// Token: 0x040040FB RID: 16635
		private int price_;
	}
}
