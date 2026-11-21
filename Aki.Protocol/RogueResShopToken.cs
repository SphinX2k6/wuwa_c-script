using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000FF6 RID: 4086
	public sealed class RogueResShopToken : IMessage<RogueResShopToken>, IMessage, IEquatable<RogueResShopToken>, IDeepCloneable<RogueResShopToken>, IBufferMessage
	{
		// Token: 0x06015E11 RID: 89617 RVA: 0x0032F023 File Offset: 0x0032D223
		[NullableContext(1)]
		public static RogueResShopToken Create()
		{
			return new RogueResShopToken();
		}

		// Token: 0x17004925 RID: 18725
		// (get) Token: 0x06015E12 RID: 89618 RVA: 0x0032F02A File Offset: 0x0032D22A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004926 RID: 18726
		// (get) Token: 0x06015E13 RID: 89619 RVA: 0x0032F02D File Offset: 0x0032D22D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueResShopToken.Descriptor;
			}
		}

		// Token: 0x06015E14 RID: 89620 RVA: 0x0032F034 File Offset: 0x0032D234
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResShopToken()
		{
		}

		// Token: 0x06015E15 RID: 89621 RVA: 0x0032F048 File Offset: 0x0032D248
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResShopToken(RogueResShopToken other) : this()
		{
			this.configId_ = other.configId_;
			this.isNew_ = other.isNew_;
			this.isSell_ = other.isSell_;
			this.elementUnits_ = other.elementUnits_.Clone();
			this.sourcePrice_ = other.sourcePrice_;
			this.curPrice_ = other.curPrice_;
			this.itemId_ = other.itemId_;
			this.index_ = other.index_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06015E16 RID: 89622 RVA: 0x0032F0D1 File Offset: 0x0032D2D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResShopToken Clone()
		{
			return new RogueResShopToken(this);
		}

		// Token: 0x17004927 RID: 18727
		// (get) Token: 0x06015E17 RID: 89623 RVA: 0x0032F0D9 File Offset: 0x0032D2D9
		// (set) Token: 0x06015E18 RID: 89624 RVA: 0x0032F0E1 File Offset: 0x0032D2E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ConfigId
		{
			get
			{
				return this.configId_;
			}
			set
			{
				this.configId_ = value;
			}
		}

		// Token: 0x17004928 RID: 18728
		// (get) Token: 0x06015E19 RID: 89625 RVA: 0x0032F0EA File Offset: 0x0032D2EA
		// (set) Token: 0x06015E1A RID: 89626 RVA: 0x0032F0F2 File Offset: 0x0032D2F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsNew
		{
			get
			{
				return this.isNew_;
			}
			set
			{
				this.isNew_ = value;
			}
		}

		// Token: 0x17004929 RID: 18729
		// (get) Token: 0x06015E1B RID: 89627 RVA: 0x0032F0FB File Offset: 0x0032D2FB
		// (set) Token: 0x06015E1C RID: 89628 RVA: 0x0032F103 File Offset: 0x0032D303
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsSell
		{
			get
			{
				return this.isSell_;
			}
			set
			{
				this.isSell_ = value;
			}
		}

		// Token: 0x1700492A RID: 18730
		// (get) Token: 0x06015E1D RID: 89629 RVA: 0x0032F10C File Offset: 0x0032D30C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ElementUnit> ElementUnits
		{
			get
			{
				return this.elementUnits_;
			}
		}

		// Token: 0x1700492B RID: 18731
		// (get) Token: 0x06015E1E RID: 89630 RVA: 0x0032F114 File Offset: 0x0032D314
		// (set) Token: 0x06015E1F RID: 89631 RVA: 0x0032F11C File Offset: 0x0032D31C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SourcePrice
		{
			get
			{
				return this.sourcePrice_;
			}
			set
			{
				this.sourcePrice_ = value;
			}
		}

		// Token: 0x1700492C RID: 18732
		// (get) Token: 0x06015E20 RID: 89632 RVA: 0x0032F125 File Offset: 0x0032D325
		// (set) Token: 0x06015E21 RID: 89633 RVA: 0x0032F12D File Offset: 0x0032D32D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CurPrice
		{
			get
			{
				return this.curPrice_;
			}
			set
			{
				this.curPrice_ = value;
			}
		}

		// Token: 0x1700492D RID: 18733
		// (get) Token: 0x06015E22 RID: 89634 RVA: 0x0032F136 File Offset: 0x0032D336
		// (set) Token: 0x06015E23 RID: 89635 RVA: 0x0032F13E File Offset: 0x0032D33E
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

		// Token: 0x1700492E RID: 18734
		// (get) Token: 0x06015E24 RID: 89636 RVA: 0x0032F147 File Offset: 0x0032D347
		// (set) Token: 0x06015E25 RID: 89637 RVA: 0x0032F14F File Offset: 0x0032D34F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Index
		{
			get
			{
				return this.index_;
			}
			set
			{
				this.index_ = value;
			}
		}

		// Token: 0x06015E26 RID: 89638 RVA: 0x0032F158 File Offset: 0x0032D358
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueResShopToken);
		}

		// Token: 0x06015E27 RID: 89639 RVA: 0x0032F168 File Offset: 0x0032D368
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueResShopToken other)
		{
			return other != null && (other == this || (this.ConfigId == other.ConfigId && this.IsNew == other.IsNew && this.IsSell == other.IsSell && this.elementUnits_.Equals(other.elementUnits_) && this.SourcePrice == other.SourcePrice && this.CurPrice == other.CurPrice && this.ItemId == other.ItemId && this.Index == other.Index && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06015E28 RID: 89640 RVA: 0x0032F218 File Offset: 0x0032D418
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ConfigId != 0)
			{
				num ^= this.ConfigId.GetHashCode();
			}
			if (this.IsNew)
			{
				num ^= this.IsNew.GetHashCode();
			}
			if (this.IsSell)
			{
				num ^= this.IsSell.GetHashCode();
			}
			num ^= this.elementUnits_.GetHashCode();
			if (this.SourcePrice != 0)
			{
				num ^= this.SourcePrice.GetHashCode();
			}
			if (this.CurPrice != 0)
			{
				num ^= this.CurPrice.GetHashCode();
			}
			if (this.ItemId != 0)
			{
				num ^= this.ItemId.GetHashCode();
			}
			if (this.Index != 0)
			{
				num ^= this.Index.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06015E29 RID: 89641 RVA: 0x0032F2FB File Offset: 0x0032D4FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06015E2A RID: 89642 RVA: 0x0032F308 File Offset: 0x0032D508
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06015E2B RID: 89643 RVA: 0x0032F314 File Offset: 0x0032D514
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ConfigId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.ConfigId);
			}
			if (this.IsNew)
			{
				output.WriteRawTag(16);
				output.WriteBool(this.IsNew);
			}
			if (this.IsSell)
			{
				output.WriteRawTag(24);
				output.WriteBool(this.IsSell);
			}
			this.elementUnits_.WriteTo(ref output, RogueResShopToken._repeated_elementUnits_codec);
			if (this.SourcePrice != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.SourcePrice);
			}
			if (this.CurPrice != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.CurPrice);
			}
			if (this.ItemId != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.ItemId);
			}
			if (this.Index != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.Index);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06015E2C RID: 89644 RVA: 0x0032F40C File Offset: 0x0032D60C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ConfigId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ConfigId);
			}
			if (this.IsNew)
			{
				num += 2;
			}
			if (this.IsSell)
			{
				num += 2;
			}
			num += this.elementUnits_.CalculateSize(RogueResShopToken._repeated_elementUnits_codec);
			if (this.SourcePrice != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SourcePrice);
			}
			if (this.CurPrice != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CurPrice);
			}
			if (this.ItemId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ItemId);
			}
			if (this.Index != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Index);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06015E2D RID: 89645 RVA: 0x0032F4D8 File Offset: 0x0032D6D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueResShopToken other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ConfigId != 0)
			{
				this.ConfigId = other.ConfigId;
			}
			if (other.IsNew)
			{
				this.IsNew = other.IsNew;
			}
			if (other.IsSell)
			{
				this.IsSell = other.IsSell;
			}
			this.elementUnits_.Add(other.elementUnits_);
			if (other.SourcePrice != 0)
			{
				this.SourcePrice = other.SourcePrice;
			}
			if (other.CurPrice != 0)
			{
				this.CurPrice = other.CurPrice;
			}
			if (other.ItemId != 0)
			{
				this.ItemId = other.ItemId;
			}
			if (other.Index != 0)
			{
				this.Index = other.Index;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06015E2E RID: 89646 RVA: 0x0032F59D File Offset: 0x0032D79D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06015E2F RID: 89647 RVA: 0x0032F5A8 File Offset: 0x0032D7A8
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
				if (num <= 34U)
				{
					if (num <= 16U)
					{
						if (num == 8U)
						{
							this.ConfigId = input.ReadInt32();
							continue;
						}
						if (num == 16U)
						{
							this.IsNew = input.ReadBool();
							continue;
						}
					}
					else
					{
						if (num == 24U)
						{
							this.IsSell = input.ReadBool();
							continue;
						}
						if (num == 34U)
						{
							this.elementUnits_.AddEntriesFrom(ref input, RogueResShopToken._repeated_elementUnits_codec);
							continue;
						}
					}
				}
				else if (num <= 48U)
				{
					if (num == 40U)
					{
						this.SourcePrice = input.ReadInt32();
						continue;
					}
					if (num == 48U)
					{
						this.CurPrice = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 56U)
					{
						this.ItemId = input.ReadInt32();
						continue;
					}
					if (num == 64U)
					{
						this.Index = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040083CE RID: 33742
		private UnknownFieldSet _unknownFields;

		// Token: 0x040083CF RID: 33743
		public const int ConfigIdFieldNumber = 1;

		// Token: 0x040083D0 RID: 33744
		private int configId_;

		// Token: 0x040083D1 RID: 33745
		public const int IsNewFieldNumber = 2;

		// Token: 0x040083D2 RID: 33746
		private bool isNew_;

		// Token: 0x040083D3 RID: 33747
		public const int IsSellFieldNumber = 3;

		// Token: 0x040083D4 RID: 33748
		private bool isSell_;

		// Token: 0x040083D5 RID: 33749
		public const int ElementUnitsFieldNumber = 4;

		// Token: 0x040083D6 RID: 33750
		private static readonly FieldCodec<ElementUnit> _repeated_elementUnits_codec = FieldCodec.ForMessage<ElementUnit>(34U, ElementUnit.Parser);

		// Token: 0x040083D7 RID: 33751
		private readonly RepeatedField<ElementUnit> elementUnits_ = new RepeatedField<ElementUnit>();

		// Token: 0x040083D8 RID: 33752
		public const int SourcePriceFieldNumber = 5;

		// Token: 0x040083D9 RID: 33753
		private int sourcePrice_;

		// Token: 0x040083DA RID: 33754
		public const int CurPriceFieldNumber = 6;

		// Token: 0x040083DB RID: 33755
		private int curPrice_;

		// Token: 0x040083DC RID: 33756
		public const int ItemIdFieldNumber = 7;

		// Token: 0x040083DD RID: 33757
		private int itemId_;

		// Token: 0x040083DE RID: 33758
		public const int IndexFieldNumber = 8;

		// Token: 0x040083DF RID: 33759
		private int index_;
	}
}
