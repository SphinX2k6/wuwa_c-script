using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200021D RID: 541
	public sealed class CabinInfo : IMessage<CabinInfo>, IMessage, IEquatable<CabinInfo>, IDeepCloneable<CabinInfo>, IBufferMessage
	{
		// Token: 0x06003B66 RID: 15206 RVA: 0x00094061 File Offset: 0x00092261
		[NullableContext(1)]
		public static CabinInfo Create()
		{
			return new CabinInfo();
		}

		// Token: 0x170009CE RID: 2510
		// (get) Token: 0x06003B67 RID: 15207 RVA: 0x00094068 File Offset: 0x00092268
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170009CF RID: 2511
		// (get) Token: 0x06003B68 RID: 15208 RVA: 0x0009406B File Offset: 0x0009226B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CabinInfo.Descriptor;
			}
		}

		// Token: 0x06003B69 RID: 15209 RVA: 0x00094072 File Offset: 0x00092272
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CabinInfo()
		{
		}

		// Token: 0x06003B6A RID: 15210 RVA: 0x0009409C File Offset: 0x0009229C
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

		// Token: 0x06003B6B RID: 15211 RVA: 0x00094117 File Offset: 0x00092317
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CabinInfo Clone()
		{
			return new CabinInfo(this);
		}

		// Token: 0x170009D0 RID: 2512
		// (get) Token: 0x06003B6C RID: 15212 RVA: 0x0009411F File Offset: 0x0009231F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<FishingItemInfo> FishingItems
		{
			get
			{
				return this.fishingItems_;
			}
		}

		// Token: 0x170009D1 RID: 2513
		// (get) Token: 0x06003B6D RID: 15213 RVA: 0x00094127 File Offset: 0x00092327
		// (set) Token: 0x06003B6E RID: 15214 RVA: 0x0009412F File Offset: 0x0009232F
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

		// Token: 0x170009D2 RID: 2514
		// (get) Token: 0x06003B6F RID: 15215 RVA: 0x00094138 File Offset: 0x00092338
		// (set) Token: 0x06003B70 RID: 15216 RVA: 0x00094140 File Offset: 0x00092340
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

		// Token: 0x170009D3 RID: 2515
		// (get) Token: 0x06003B71 RID: 15217 RVA: 0x00094149 File Offset: 0x00092349
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<FishingItemInfo> NetCabinItems
		{
			get
			{
				return this.netCabinItems_;
			}
		}

		// Token: 0x170009D4 RID: 2516
		// (get) Token: 0x06003B72 RID: 15218 RVA: 0x00094151 File Offset: 0x00092351
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<FishingItemInfo> TempCabinItems
		{
			get
			{
				return this.tempCabinItems_;
			}
		}

		// Token: 0x170009D5 RID: 2517
		// (get) Token: 0x06003B73 RID: 15219 RVA: 0x00094159 File Offset: 0x00092359
		// (set) Token: 0x06003B74 RID: 15220 RVA: 0x00094161 File Offset: 0x00092361
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

		// Token: 0x06003B75 RID: 15221 RVA: 0x0009416A File Offset: 0x0009236A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CabinInfo);
		}

		// Token: 0x06003B76 RID: 15222 RVA: 0x00094178 File Offset: 0x00092378
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CabinInfo other)
		{
			return other != null && (other == this || (this.fishingItems_.Equals(other.fishingItems_) && this.CabinShape == other.CabinShape && this.QuickSellShape == other.QuickSellShape && this.netCabinItems_.Equals(other.netCabinItems_) && this.tempCabinItems_.Equals(other.tempCabinItems_) && this.QuickSellRatio == other.QuickSellRatio && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003B77 RID: 15223 RVA: 0x00094210 File Offset: 0x00092410
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

		// Token: 0x06003B78 RID: 15224 RVA: 0x000942AB File Offset: 0x000924AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06003B79 RID: 15225 RVA: 0x000942B8 File Offset: 0x000924B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003B7A RID: 15226 RVA: 0x000942C4 File Offset: 0x000924C4
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

		// Token: 0x06003B7B RID: 15227 RVA: 0x0009436C File Offset: 0x0009256C
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

		// Token: 0x06003B7C RID: 15228 RVA: 0x00094414 File Offset: 0x00092614
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

		// Token: 0x06003B7D RID: 15229 RVA: 0x000944AB File Offset: 0x000926AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003B7E RID: 15230 RVA: 0x000944B4 File Offset: 0x000926B4
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

		// Token: 0x04002C6C RID: 11372
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002C6D RID: 11373
		public const int FishingItemsFieldNumber = 1;

		// Token: 0x04002C6E RID: 11374
		private static readonly FieldCodec<FishingItemInfo> _repeated_fishingItems_codec = FieldCodec.ForMessage<FishingItemInfo>(10U, FishingItemInfo.Parser);

		// Token: 0x04002C6F RID: 11375
		private readonly RepeatedField<FishingItemInfo> fishingItems_ = new RepeatedField<FishingItemInfo>();

		// Token: 0x04002C70 RID: 11376
		public const int CabinShapeFieldNumber = 2;

		// Token: 0x04002C71 RID: 11377
		private int cabinShape_;

		// Token: 0x04002C72 RID: 11378
		public const int QuickSellShapeFieldNumber = 3;

		// Token: 0x04002C73 RID: 11379
		private int quickSellShape_;

		// Token: 0x04002C74 RID: 11380
		public const int NetCabinItemsFieldNumber = 4;

		// Token: 0x04002C75 RID: 11381
		private static readonly FieldCodec<FishingItemInfo> _repeated_netCabinItems_codec = FieldCodec.ForMessage<FishingItemInfo>(34U, FishingItemInfo.Parser);

		// Token: 0x04002C76 RID: 11382
		private readonly RepeatedField<FishingItemInfo> netCabinItems_ = new RepeatedField<FishingItemInfo>();

		// Token: 0x04002C77 RID: 11383
		public const int TempCabinItemsFieldNumber = 5;

		// Token: 0x04002C78 RID: 11384
		private static readonly FieldCodec<FishingItemInfo> _repeated_tempCabinItems_codec = FieldCodec.ForMessage<FishingItemInfo>(42U, FishingItemInfo.Parser);

		// Token: 0x04002C79 RID: 11385
		private readonly RepeatedField<FishingItemInfo> tempCabinItems_ = new RepeatedField<FishingItemInfo>();

		// Token: 0x04002C7A RID: 11386
		public const int QuickSellRatioFieldNumber = 6;

		// Token: 0x04002C7B RID: 11387
		private int quickSellRatio_;
	}
}
