using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001482 RID: 5250
	public sealed class TrapDefenseBuildingInfo : IMessage<TrapDefenseBuildingInfo>, IMessage, IEquatable<TrapDefenseBuildingInfo>, IDeepCloneable<TrapDefenseBuildingInfo>, IBufferMessage
	{
		// Token: 0x0601BE04 RID: 114180 RVA: 0x0040CCF9 File Offset: 0x0040AEF9
		[NullableContext(1)]
		public static TrapDefenseBuildingInfo Create()
		{
			return new TrapDefenseBuildingInfo();
		}

		// Token: 0x17005E5F RID: 24159
		// (get) Token: 0x0601BE05 RID: 114181 RVA: 0x0040CD00 File Offset: 0x0040AF00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<TrapDefenseBuildingInfo> Parser
		{
			get
			{
				return TrapDefenseBuildingInfo._parser;
			}
		}

		// Token: 0x17005E60 RID: 24160
		// (get) Token: 0x0601BE06 RID: 114182 RVA: 0x0040CD07 File Offset: 0x0040AF07
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005E61 RID: 24161
		// (get) Token: 0x0601BE07 RID: 114183 RVA: 0x0040CD0A File Offset: 0x0040AF0A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TrapDefenseBuildingInfo.Descriptor;
			}
		}

		// Token: 0x0601BE08 RID: 114184 RVA: 0x0040CD11 File Offset: 0x0040AF11
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseBuildingInfo()
		{
		}

		// Token: 0x0601BE09 RID: 114185 RVA: 0x0040CD1C File Offset: 0x0040AF1C
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

		// Token: 0x0601BE0A RID: 114186 RVA: 0x0040CDA0 File Offset: 0x0040AFA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseBuildingInfo Clone()
		{
			return new TrapDefenseBuildingInfo(this);
		}

		// Token: 0x17005E62 RID: 24162
		// (get) Token: 0x0601BE0B RID: 114187 RVA: 0x0040CDA8 File Offset: 0x0040AFA8
		// (set) Token: 0x0601BE0C RID: 114188 RVA: 0x0040CDB0 File Offset: 0x0040AFB0
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

		// Token: 0x17005E63 RID: 24163
		// (get) Token: 0x0601BE0D RID: 114189 RVA: 0x0040CDB9 File Offset: 0x0040AFB9
		// (set) Token: 0x0601BE0E RID: 114190 RVA: 0x0040CDC1 File Offset: 0x0040AFC1
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

		// Token: 0x17005E64 RID: 24164
		// (get) Token: 0x0601BE0F RID: 114191 RVA: 0x0040CDCA File Offset: 0x0040AFCA
		// (set) Token: 0x0601BE10 RID: 114192 RVA: 0x0040CDD2 File Offset: 0x0040AFD2
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

		// Token: 0x17005E65 RID: 24165
		// (get) Token: 0x0601BE11 RID: 114193 RVA: 0x0040CDDB File Offset: 0x0040AFDB
		// (set) Token: 0x0601BE12 RID: 114194 RVA: 0x0040CDE3 File Offset: 0x0040AFE3
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

		// Token: 0x17005E66 RID: 24166
		// (get) Token: 0x0601BE13 RID: 114195 RVA: 0x0040CDEC File Offset: 0x0040AFEC
		// (set) Token: 0x0601BE14 RID: 114196 RVA: 0x0040CDF4 File Offset: 0x0040AFF4
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

		// Token: 0x17005E67 RID: 24167
		// (get) Token: 0x0601BE15 RID: 114197 RVA: 0x0040CDFD File Offset: 0x0040AFFD
		// (set) Token: 0x0601BE16 RID: 114198 RVA: 0x0040CE05 File Offset: 0x0040B005
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

		// Token: 0x17005E68 RID: 24168
		// (get) Token: 0x0601BE17 RID: 114199 RVA: 0x0040CE0E File Offset: 0x0040B00E
		// (set) Token: 0x0601BE18 RID: 114200 RVA: 0x0040CE16 File Offset: 0x0040B016
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

		// Token: 0x17005E69 RID: 24169
		// (get) Token: 0x0601BE19 RID: 114201 RVA: 0x0040CE1F File Offset: 0x0040B01F
		// (set) Token: 0x0601BE1A RID: 114202 RVA: 0x0040CE27 File Offset: 0x0040B027
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

		// Token: 0x0601BE1B RID: 114203 RVA: 0x0040CE30 File Offset: 0x0040B030
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TrapDefenseBuildingInfo);
		}

		// Token: 0x0601BE1C RID: 114204 RVA: 0x0040CE40 File Offset: 0x0040B040
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TrapDefenseBuildingInfo other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.Level == other.Level && this.Branch == other.Branch && this.CurMaxLevel == other.CurMaxLevel && this.CellPrice == other.CellPrice && this.OriginalConstructPrice == other.OriginalConstructPrice && this.DiscountConstructPrice == other.DiscountConstructPrice && this.DeconstructReturn == other.DeconstructReturn && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601BE1D RID: 114205 RVA: 0x0040CEEC File Offset: 0x0040B0EC
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

		// Token: 0x0601BE1E RID: 114206 RVA: 0x0040CFDA File Offset: 0x0040B1DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601BE1F RID: 114207 RVA: 0x0040CFE7 File Offset: 0x0040B1E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601BE20 RID: 114208 RVA: 0x0040CFF0 File Offset: 0x0040B1F0
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

		// Token: 0x0601BE21 RID: 114209 RVA: 0x0040D0F0 File Offset: 0x0040B2F0
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

		// Token: 0x0601BE22 RID: 114210 RVA: 0x0040D1D8 File Offset: 0x0040B3D8
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

		// Token: 0x0601BE23 RID: 114211 RVA: 0x0040D2A0 File Offset: 0x0040B4A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601BE24 RID: 114212 RVA: 0x0040D2AC File Offset: 0x0040B4AC
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

		// Token: 0x0400A1B3 RID: 41395
		private static readonly MessageParser<TrapDefenseBuildingInfo> _parser = new MessageParser<TrapDefenseBuildingInfo>(() => new TrapDefenseBuildingInfo());

		// Token: 0x0400A1B4 RID: 41396
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A1B5 RID: 41397
		public const int IdFieldNumber = 1;

		// Token: 0x0400A1B6 RID: 41398
		private int id_;

		// Token: 0x0400A1B7 RID: 41399
		public const int LevelFieldNumber = 2;

		// Token: 0x0400A1B8 RID: 41400
		private int level_;

		// Token: 0x0400A1B9 RID: 41401
		public const int BranchFieldNumber = 3;

		// Token: 0x0400A1BA RID: 41402
		private int branch_;

		// Token: 0x0400A1BB RID: 41403
		public const int CurMaxLevelFieldNumber = 4;

		// Token: 0x0400A1BC RID: 41404
		private int curMaxLevel_;

		// Token: 0x0400A1BD RID: 41405
		public const int CellPriceFieldNumber = 5;

		// Token: 0x0400A1BE RID: 41406
		private int cellPrice_;

		// Token: 0x0400A1BF RID: 41407
		public const int OriginalConstructPriceFieldNumber = 6;

		// Token: 0x0400A1C0 RID: 41408
		private int originalConstructPrice_;

		// Token: 0x0400A1C1 RID: 41409
		public const int DiscountConstructPriceFieldNumber = 7;

		// Token: 0x0400A1C2 RID: 41410
		private int discountConstructPrice_;

		// Token: 0x0400A1C3 RID: 41411
		public const int DeconstructReturnFieldNumber = 8;

		// Token: 0x0400A1C4 RID: 41412
		private int deconstructReturn_;
	}
}
