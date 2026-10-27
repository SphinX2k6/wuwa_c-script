using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000218 RID: 536
	public sealed class CabinInfo : IMessage<CabinInfo>, IMessage, IEquatable<CabinInfo>, IDeepCloneable<CabinInfo>, IBufferMessage
	{
		// Token: 0x06003AC1 RID: 15041 RVA: 0x00092449 File Offset: 0x00090649
		[NullableContext(1)]
		public static CabinInfo Create()
		{
			return new CabinInfo();
		}

		// Token: 0x170009AF RID: 2479
		// (get) Token: 0x06003AC2 RID: 15042 RVA: 0x00092450 File Offset: 0x00090650
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170009B0 RID: 2480
		// (get) Token: 0x06003AC3 RID: 15043 RVA: 0x00092453 File Offset: 0x00090653
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CabinInfo.Descriptor;
			}
		}

		// Token: 0x06003AC4 RID: 15044 RVA: 0x0009245A File Offset: 0x0009065A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CabinInfo()
		{
		}

		// Token: 0x06003AC5 RID: 15045 RVA: 0x00092484 File Offset: 0x00090684
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CabinInfo(CabinInfo other) : this()
		{
			this.fishingItems_ = other.fishingItems_.Clone();
			this.cabinShape_ = other.cabinShape_;
			this.quickSellShape_ = other.quickSellShape_;
			this.netCabinItems_ = other.netCabinItems_.Clone();
			this.tempCabinItems_ = other.tempCabinItems_.Clone();
			this.quickSellRatio_ = other.quickSellRatio_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003AC6 RID: 15046 RVA: 0x000924FF File Offset: 0x000906FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CabinInfo Clone()
		{
			return new CabinInfo(this);
		}

		// Token: 0x170009B1 RID: 2481
		// (get) Token: 0x06003AC7 RID: 15047 RVA: 0x00092507 File Offset: 0x00090707
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<FishingItemInfo> FishingItems
		{
			get
			{
				return this.fishingItems_;
			}
		}

		// Token: 0x170009B2 RID: 2482
		// (get) Token: 0x06003AC8 RID: 15048 RVA: 0x0009250F File Offset: 0x0009070F
		// (set) Token: 0x06003AC9 RID: 15049 RVA: 0x00092517 File Offset: 0x00090717
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CabinShape
		{
			get
			{
				return this.cabinShape_;
			}
			set
			{
				this.cabinShape_ = value;
			}
		}

		// Token: 0x170009B3 RID: 2483
		// (get) Token: 0x06003ACA RID: 15050 RVA: 0x00092520 File Offset: 0x00090720
		// (set) Token: 0x06003ACB RID: 15051 RVA: 0x00092528 File Offset: 0x00090728
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int QuickSellShape
		{
			get
			{
				return this.quickSellShape_;
			}
			set
			{
				this.quickSellShape_ = value;
			}
		}

		// Token: 0x170009B4 RID: 2484
		// (get) Token: 0x06003ACC RID: 15052 RVA: 0x00092531 File Offset: 0x00090731
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<FishingItemInfo> NetCabinItems
		{
			get
			{
				return this.netCabinItems_;
			}
		}

		// Token: 0x170009B5 RID: 2485
		// (get) Token: 0x06003ACD RID: 15053 RVA: 0x00092539 File Offset: 0x00090739
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<FishingItemInfo> TempCabinItems
		{
			get
			{
				return this.tempCabinItems_;
			}
		}

		// Token: 0x170009B6 RID: 2486
		// (get) Token: 0x06003ACE RID: 15054 RVA: 0x00092541 File Offset: 0x00090741
		// (set) Token: 0x06003ACF RID: 15055 RVA: 0x00092549 File Offset: 0x00090749
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int QuickSellRatio
		{
			get
			{
				return this.quickSellRatio_;
			}
			set
			{
				this.quickSellRatio_ = value;
			}
		}

		// Token: 0x06003AD0 RID: 15056 RVA: 0x00092552 File Offset: 0x00090752
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CabinInfo);
		}

		// Token: 0x06003AD1 RID: 15057 RVA: 0x00092560 File Offset: 0x00090760
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CabinInfo other)
		{
			return other != null && (other == this || (this.fishingItems_.Equals(other.fishingItems_) && this.CabinShape == other.CabinShape && this.QuickSellShape == other.QuickSellShape && this.netCabinItems_.Equals(other.netCabinItems_) && this.tempCabinItems_.Equals(other.tempCabinItems_) && this.QuickSellRatio == other.QuickSellRatio && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003AD2 RID: 15058 RVA: 0x000925F8 File Offset: 0x000907F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.fishingItems_.GetHashCode();
			if (this.CabinShape != 0)
			{
				num ^= this.CabinShape.GetHashCode();
			}
			if (this.QuickSellShape != 0)
			{
				num ^= this.QuickSellShape.GetHashCode();
			}
			num ^= this.netCabinItems_.GetHashCode();
			num ^= this.tempCabinItems_.GetHashCode();
			if (this.QuickSellRatio != 0)
			{
				num ^= this.QuickSellRatio.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06003AD3 RID: 15059 RVA: 0x00092693 File Offset: 0x00090893
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06003AD4 RID: 15060 RVA: 0x000926A0 File Offset: 0x000908A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003AD5 RID: 15061 RVA: 0x000926AC File Offset: 0x000908AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.fishingItems_.WriteTo(ref output, CabinInfo._repeated_fishingItems_codec);
			if (this.CabinShape != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.CabinShape);
			}
			if (this.QuickSellShape != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.QuickSellShape);
			}
			this.netCabinItems_.WriteTo(ref output, CabinInfo._repeated_netCabinItems_codec);
			this.tempCabinItems_.WriteTo(ref output, CabinInfo._repeated_tempCabinItems_codec);
			if (this.QuickSellRatio != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.QuickSellRatio);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003AD6 RID: 15062 RVA: 0x00092754 File Offset: 0x00090954
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.fishingItems_.CalculateSize(CabinInfo._repeated_fishingItems_codec);
			if (this.CabinShape != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CabinShape);
			}
			if (this.QuickSellShape != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.QuickSellShape);
			}
			num += this.netCabinItems_.CalculateSize(CabinInfo._repeated_netCabinItems_codec);
			num += this.tempCabinItems_.CalculateSize(CabinInfo._repeated_tempCabinItems_codec);
			if (this.QuickSellRatio != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.QuickSellRatio);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06003AD7 RID: 15063 RVA: 0x000927FC File Offset: 0x000909FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CabinInfo other)
		{
			if (other == null)
			{
				return;
			}
			this.fishingItems_.Add(other.fishingItems_);
			if (other.CabinShape != 0)
			{
				this.CabinShape = other.CabinShape;
			}
			if (other.QuickSellShape != 0)
			{
				this.QuickSellShape = other.QuickSellShape;
			}
			this.netCabinItems_.Add(other.netCabinItems_);
			this.tempCabinItems_.Add(other.tempCabinItems_);
			if (other.QuickSellRatio != 0)
			{
				this.QuickSellRatio = other.QuickSellRatio;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06003AD8 RID: 15064 RVA: 0x00092893 File Offset: 0x00090A93
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003AD9 RID: 15065 RVA: 0x0009289C File Offset: 0x00090A9C
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
				if (num <= 24U)
				{
					if (num == 10U)
					{
						this.fishingItems_.AddEntriesFrom(ref input, CabinInfo._repeated_fishingItems_codec);
						continue;
					}
					if (num == 16U)
					{
						this.CabinShape = input.ReadInt32();
						continue;
					}
					if (num == 24U)
					{
						this.QuickSellShape = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 34U)
					{
						this.netCabinItems_.AddEntriesFrom(ref input, CabinInfo._repeated_netCabinItems_codec);
						continue;
					}
					if (num == 42U)
					{
						this.tempCabinItems_.AddEntriesFrom(ref input, CabinInfo._repeated_tempCabinItems_codec);
						continue;
					}
					if (num == 48U)
					{
						this.QuickSellRatio = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04002BEA RID: 11242
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002BEB RID: 11243
		public const int FishingItemsFieldNumber = 1;

		// Token: 0x04002BEC RID: 11244
		private static readonly FieldCodec<FishingItemInfo> _repeated_fishingItems_codec = FieldCodec.ForMessage<FishingItemInfo>(10U, FishingItemInfo.Parser);

		// Token: 0x04002BED RID: 11245
		private readonly RepeatedField<FishingItemInfo> fishingItems_ = new RepeatedField<FishingItemInfo>();

		// Token: 0x04002BEE RID: 11246
		public const int CabinShapeFieldNumber = 2;

		// Token: 0x04002BEF RID: 11247
		private int cabinShape_;

		// Token: 0x04002BF0 RID: 11248
		public const int QuickSellShapeFieldNumber = 3;

		// Token: 0x04002BF1 RID: 11249
		private int quickSellShape_;

		// Token: 0x04002BF2 RID: 11250
		public const int NetCabinItemsFieldNumber = 4;

		// Token: 0x04002BF3 RID: 11251
		private static readonly FieldCodec<FishingItemInfo> _repeated_netCabinItems_codec = FieldCodec.ForMessage<FishingItemInfo>(34U, FishingItemInfo.Parser);

		// Token: 0x04002BF4 RID: 11252
		private readonly RepeatedField<FishingItemInfo> netCabinItems_ = new RepeatedField<FishingItemInfo>();

		// Token: 0x04002BF5 RID: 11253
		public const int TempCabinItemsFieldNumber = 5;

		// Token: 0x04002BF6 RID: 11254
		private static readonly FieldCodec<FishingItemInfo> _repeated_tempCabinItems_codec = FieldCodec.ForMessage<FishingItemInfo>(42U, FishingItemInfo.Parser);

		// Token: 0x04002BF7 RID: 11255
		private readonly RepeatedField<FishingItemInfo> tempCabinItems_ = new RepeatedField<FishingItemInfo>();

		// Token: 0x04002BF8 RID: 11256
		public const int QuickSellRatioFieldNumber = 6;

		// Token: 0x04002BF9 RID: 11257
		private int quickSellRatio_;
	}
}
