using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200140F RID: 5135
	public sealed class TrapDefenseBuildingInfo : IMessage<TrapDefenseBuildingInfo>, IMessage, IEquatable<TrapDefenseBuildingInfo>, IDeepCloneable<TrapDefenseBuildingInfo>, IBufferMessage
	{
		// Token: 0x0601B379 RID: 111481 RVA: 0x003F1A25 File Offset: 0x003EFC25
		[NullableContext(1)]
		public static TrapDefenseBuildingInfo Create()
		{
			return new TrapDefenseBuildingInfo();
		}

		// Token: 0x17005BCA RID: 23498
		// (get) Token: 0x0601B37A RID: 111482 RVA: 0x003F1A2C File Offset: 0x003EFC2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<TrapDefenseBuildingInfo> Parser
		{
			get
			{
				return TrapDefenseBuildingInfo._parser;
			}
		}

		// Token: 0x17005BCB RID: 23499
		// (get) Token: 0x0601B37B RID: 111483 RVA: 0x003F1A33 File Offset: 0x003EFC33
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005BCC RID: 23500
		// (get) Token: 0x0601B37C RID: 111484 RVA: 0x003F1A36 File Offset: 0x003EFC36
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TrapDefenseBuildingInfo.Descriptor;
			}
		}

		// Token: 0x0601B37D RID: 111485 RVA: 0x003F1A3D File Offset: 0x003EFC3D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseBuildingInfo()
		{
		}

		// Token: 0x0601B37E RID: 111486 RVA: 0x003F1A48 File Offset: 0x003EFC48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseBuildingInfo(TrapDefenseBuildingInfo other) : this()
		{
			this.id_ = other.id_;
			this.level_ = other.level_;
			this.branch_ = other.branch_;
			this.curMaxLevel_ = other.curMaxLevel_;
			this.cellPrice_ = other.cellPrice_;
			this.originalConstructPrice_ = other.originalConstructPrice_;
			this.discountConstructPrice_ = other.discountConstructPrice_;
			this.deconstructReturn_ = other.deconstructReturn_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601B37F RID: 111487 RVA: 0x003F1ACC File Offset: 0x003EFCCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseBuildingInfo Clone()
		{
			return new TrapDefenseBuildingInfo(this);
		}

		// Token: 0x17005BCD RID: 23501
		// (get) Token: 0x0601B380 RID: 111488 RVA: 0x003F1AD4 File Offset: 0x003EFCD4
		// (set) Token: 0x0601B381 RID: 111489 RVA: 0x003F1ADC File Offset: 0x003EFCDC
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

		// Token: 0x17005BCE RID: 23502
		// (get) Token: 0x0601B382 RID: 111490 RVA: 0x003F1AE5 File Offset: 0x003EFCE5
		// (set) Token: 0x0601B383 RID: 111491 RVA: 0x003F1AED File Offset: 0x003EFCED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Level
		{
			get
			{
				return this.level_;
			}
			set
			{
				this.level_ = value;
			}
		}

		// Token: 0x17005BCF RID: 23503
		// (get) Token: 0x0601B384 RID: 111492 RVA: 0x003F1AF6 File Offset: 0x003EFCF6
		// (set) Token: 0x0601B385 RID: 111493 RVA: 0x003F1AFE File Offset: 0x003EFCFE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Branch
		{
			get
			{
				return this.branch_;
			}
			set
			{
				this.branch_ = value;
			}
		}

		// Token: 0x17005BD0 RID: 23504
		// (get) Token: 0x0601B386 RID: 111494 RVA: 0x003F1B07 File Offset: 0x003EFD07
		// (set) Token: 0x0601B387 RID: 111495 RVA: 0x003F1B0F File Offset: 0x003EFD0F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CurMaxLevel
		{
			get
			{
				return this.curMaxLevel_;
			}
			set
			{
				this.curMaxLevel_ = value;
			}
		}

		// Token: 0x17005BD1 RID: 23505
		// (get) Token: 0x0601B388 RID: 111496 RVA: 0x003F1B18 File Offset: 0x003EFD18
		// (set) Token: 0x0601B389 RID: 111497 RVA: 0x003F1B20 File Offset: 0x003EFD20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CellPrice
		{
			get
			{
				return this.cellPrice_;
			}
			set
			{
				this.cellPrice_ = value;
			}
		}

		// Token: 0x17005BD2 RID: 23506
		// (get) Token: 0x0601B38A RID: 111498 RVA: 0x003F1B29 File Offset: 0x003EFD29
		// (set) Token: 0x0601B38B RID: 111499 RVA: 0x003F1B31 File Offset: 0x003EFD31
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int OriginalConstructPrice
		{
			get
			{
				return this.originalConstructPrice_;
			}
			set
			{
				this.originalConstructPrice_ = value;
			}
		}

		// Token: 0x17005BD3 RID: 23507
		// (get) Token: 0x0601B38C RID: 111500 RVA: 0x003F1B3A File Offset: 0x003EFD3A
		// (set) Token: 0x0601B38D RID: 111501 RVA: 0x003F1B42 File Offset: 0x003EFD42
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int DiscountConstructPrice
		{
			get
			{
				return this.discountConstructPrice_;
			}
			set
			{
				this.discountConstructPrice_ = value;
			}
		}

		// Token: 0x17005BD4 RID: 23508
		// (get) Token: 0x0601B38E RID: 111502 RVA: 0x003F1B4B File Offset: 0x003EFD4B
		// (set) Token: 0x0601B38F RID: 111503 RVA: 0x003F1B53 File Offset: 0x003EFD53
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int DeconstructReturn
		{
			get
			{
				return this.deconstructReturn_;
			}
			set
			{
				this.deconstructReturn_ = value;
			}
		}

		// Token: 0x0601B390 RID: 111504 RVA: 0x003F1B5C File Offset: 0x003EFD5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TrapDefenseBuildingInfo);
		}

		// Token: 0x0601B391 RID: 111505 RVA: 0x003F1B6C File Offset: 0x003EFD6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TrapDefenseBuildingInfo other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.Level == other.Level && this.Branch == other.Branch && this.CurMaxLevel == other.CurMaxLevel && this.CellPrice == other.CellPrice && this.OriginalConstructPrice == other.OriginalConstructPrice && this.DiscountConstructPrice == other.DiscountConstructPrice && this.DeconstructReturn == other.DeconstructReturn && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601B392 RID: 111506 RVA: 0x003F1C18 File Offset: 0x003EFE18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.Level != 0)
			{
				num ^= this.Level.GetHashCode();
			}
			if (this.Branch != 0)
			{
				num ^= this.Branch.GetHashCode();
			}
			if (this.CurMaxLevel != 0)
			{
				num ^= this.CurMaxLevel.GetHashCode();
			}
			if (this.CellPrice != 0)
			{
				num ^= this.CellPrice.GetHashCode();
			}
			if (this.OriginalConstructPrice != 0)
			{
				num ^= this.OriginalConstructPrice.GetHashCode();
			}
			if (this.DiscountConstructPrice != 0)
			{
				num ^= this.DiscountConstructPrice.GetHashCode();
			}
			if (this.DeconstructReturn != 0)
			{
				num ^= this.DeconstructReturn.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601B393 RID: 111507 RVA: 0x003F1D06 File Offset: 0x003EFF06
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601B394 RID: 111508 RVA: 0x003F1D13 File Offset: 0x003EFF13
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601B395 RID: 111509 RVA: 0x003F1D1C File Offset: 0x003EFF1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Id);
			}
			if (this.Level != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Level);
			}
			if (this.Branch != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.Branch);
			}
			if (this.CurMaxLevel != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.CurMaxLevel);
			}
			if (this.CellPrice != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.CellPrice);
			}
			if (this.OriginalConstructPrice != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.OriginalConstructPrice);
			}
			if (this.DiscountConstructPrice != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.DiscountConstructPrice);
			}
			if (this.DeconstructReturn != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.DeconstructReturn);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601B396 RID: 111510 RVA: 0x003F1E1C File Offset: 0x003F001C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			if (this.Level != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Level);
			}
			if (this.Branch != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Branch);
			}
			if (this.CurMaxLevel != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CurMaxLevel);
			}
			if (this.CellPrice != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CellPrice);
			}
			if (this.OriginalConstructPrice != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.OriginalConstructPrice);
			}
			if (this.DiscountConstructPrice != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.DiscountConstructPrice);
			}
			if (this.DeconstructReturn != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.DeconstructReturn);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601B397 RID: 111511 RVA: 0x003F1F04 File Offset: 0x003F0104
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TrapDefenseBuildingInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			if (other.Level != 0)
			{
				this.Level = other.Level;
			}
			if (other.Branch != 0)
			{
				this.Branch = other.Branch;
			}
			if (other.CurMaxLevel != 0)
			{
				this.CurMaxLevel = other.CurMaxLevel;
			}
			if (other.CellPrice != 0)
			{
				this.CellPrice = other.CellPrice;
			}
			if (other.OriginalConstructPrice != 0)
			{
				this.OriginalConstructPrice = other.OriginalConstructPrice;
			}
			if (other.DiscountConstructPrice != 0)
			{
				this.DiscountConstructPrice = other.DiscountConstructPrice;
			}
			if (other.DeconstructReturn != 0)
			{
				this.DeconstructReturn = other.DeconstructReturn;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601B398 RID: 111512 RVA: 0x003F1FCC File Offset: 0x003F01CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601B399 RID: 111513 RVA: 0x003F1FD8 File Offset: 0x003F01D8
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
				if (num <= 32U)
				{
					if (num <= 16U)
					{
						if (num == 8U)
						{
							this.Id = input.ReadInt32();
							continue;
						}
						if (num == 16U)
						{
							this.Level = input.ReadInt32();
							continue;
						}
					}
					else
					{
						if (num == 24U)
						{
							this.Branch = input.ReadInt32();
							continue;
						}
						if (num == 32U)
						{
							this.CurMaxLevel = input.ReadInt32();
							continue;
						}
					}
				}
				else if (num <= 48U)
				{
					if (num == 40U)
					{
						this.CellPrice = input.ReadInt32();
						continue;
					}
					if (num == 48U)
					{
						this.OriginalConstructPrice = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 56U)
					{
						this.DiscountConstructPrice = input.ReadInt32();
						continue;
					}
					if (num == 64U)
					{
						this.DeconstructReturn = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04009D6C RID: 40300
		private static readonly MessageParser<TrapDefenseBuildingInfo> _parser = new MessageParser<TrapDefenseBuildingInfo>(() => new TrapDefenseBuildingInfo());

		// Token: 0x04009D6D RID: 40301
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009D6E RID: 40302
		public const int IdFieldNumber = 1;

		// Token: 0x04009D6F RID: 40303
		private int id_;

		// Token: 0x04009D70 RID: 40304
		public const int LevelFieldNumber = 2;

		// Token: 0x04009D71 RID: 40305
		private int level_;

		// Token: 0x04009D72 RID: 40306
		public const int BranchFieldNumber = 3;

		// Token: 0x04009D73 RID: 40307
		private int branch_;

		// Token: 0x04009D74 RID: 40308
		public const int CurMaxLevelFieldNumber = 4;

		// Token: 0x04009D75 RID: 40309
		private int curMaxLevel_;

		// Token: 0x04009D76 RID: 40310
		public const int CellPriceFieldNumber = 5;

		// Token: 0x04009D77 RID: 40311
		private int cellPrice_;

		// Token: 0x04009D78 RID: 40312
		public const int OriginalConstructPriceFieldNumber = 6;

		// Token: 0x04009D79 RID: 40313
		private int originalConstructPrice_;

		// Token: 0x04009D7A RID: 40314
		public const int DiscountConstructPriceFieldNumber = 7;

		// Token: 0x04009D7B RID: 40315
		private int discountConstructPrice_;

		// Token: 0x04009D7C RID: 40316
		public const int DeconstructReturnFieldNumber = 8;

		// Token: 0x04009D7D RID: 40317
		private int deconstructReturn_;
	}
}
