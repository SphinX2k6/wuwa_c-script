using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001006 RID: 4102
	public sealed class RogueResShopToken : IMessage<RogueResShopToken>, IMessage, IEquatable<RogueResShopToken>, IDeepCloneable<RogueResShopToken>, IBufferMessage
	{
		// Token: 0x06015EF6 RID: 89846 RVA: 0x003306DF File Offset: 0x0032E8DF
		[NullableContext(1)]
		public static RogueResShopToken Create()
		{
			return new RogueResShopToken();
		}

		// Token: 0x1700494F RID: 18767
		// (get) Token: 0x06015EF7 RID: 89847 RVA: 0x003306E6 File Offset: 0x0032E8E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004950 RID: 18768
		// (get) Token: 0x06015EF8 RID: 89848 RVA: 0x003306E9 File Offset: 0x0032E8E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueResShopToken.Descriptor;
			}
		}

		// Token: 0x06015EF9 RID: 89849 RVA: 0x003306F0 File Offset: 0x0032E8F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResShopToken()
		{
		}

		// Token: 0x06015EFA RID: 89850 RVA: 0x00330704 File Offset: 0x0032E904
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

		// Token: 0x06015EFB RID: 89851 RVA: 0x0033078D File Offset: 0x0032E98D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResShopToken Clone()
		{
			return new RogueResShopToken(this);
		}

		// Token: 0x17004951 RID: 18769
		// (get) Token: 0x06015EFC RID: 89852 RVA: 0x00330795 File Offset: 0x0032E995
		// (set) Token: 0x06015EFD RID: 89853 RVA: 0x0033079D File Offset: 0x0032E99D
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

		// Token: 0x17004952 RID: 18770
		// (get) Token: 0x06015EFE RID: 89854 RVA: 0x003307A6 File Offset: 0x0032E9A6
		// (set) Token: 0x06015EFF RID: 89855 RVA: 0x003307AE File Offset: 0x0032E9AE
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

		// Token: 0x17004953 RID: 18771
		// (get) Token: 0x06015F00 RID: 89856 RVA: 0x003307B7 File Offset: 0x0032E9B7
		// (set) Token: 0x06015F01 RID: 89857 RVA: 0x003307BF File Offset: 0x0032E9BF
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

		// Token: 0x17004954 RID: 18772
		// (get) Token: 0x06015F02 RID: 89858 RVA: 0x003307C8 File Offset: 0x0032E9C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ElementUnit> ElementUnits
		{
			get
			{
				return this.elementUnits_;
			}
		}

		// Token: 0x17004955 RID: 18773
		// (get) Token: 0x06015F03 RID: 89859 RVA: 0x003307D0 File Offset: 0x0032E9D0
		// (set) Token: 0x06015F04 RID: 89860 RVA: 0x003307D8 File Offset: 0x0032E9D8
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

		// Token: 0x17004956 RID: 18774
		// (get) Token: 0x06015F05 RID: 89861 RVA: 0x003307E1 File Offset: 0x0032E9E1
		// (set) Token: 0x06015F06 RID: 89862 RVA: 0x003307E9 File Offset: 0x0032E9E9
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

		// Token: 0x17004957 RID: 18775
		// (get) Token: 0x06015F07 RID: 89863 RVA: 0x003307F2 File Offset: 0x0032E9F2
		// (set) Token: 0x06015F08 RID: 89864 RVA: 0x003307FA File Offset: 0x0032E9FA
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

		// Token: 0x17004958 RID: 18776
		// (get) Token: 0x06015F09 RID: 89865 RVA: 0x00330803 File Offset: 0x0032EA03
		// (set) Token: 0x06015F0A RID: 89866 RVA: 0x0033080B File Offset: 0x0032EA0B
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

		// Token: 0x06015F0B RID: 89867 RVA: 0x00330814 File Offset: 0x0032EA14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueResShopToken);
		}

		// Token: 0x06015F0C RID: 89868 RVA: 0x00330824 File Offset: 0x0032EA24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueResShopToken other)
		{
			return other != null && (other == this || (this.ConfigId == other.ConfigId && this.IsNew == other.IsNew && this.IsSell == other.IsSell && this.elementUnits_.Equals(other.elementUnits_) && this.SourcePrice == other.SourcePrice && this.CurPrice == other.CurPrice && this.ItemId == other.ItemId && this.Index == other.Index && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06015F0D RID: 89869 RVA: 0x003308D4 File Offset: 0x0032EAD4
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

		// Token: 0x06015F0E RID: 89870 RVA: 0x003309B7 File Offset: 0x0032EBB7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06015F0F RID: 89871 RVA: 0x003309C4 File Offset: 0x0032EBC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06015F10 RID: 89872 RVA: 0x003309D0 File Offset: 0x0032EBD0
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

		// Token: 0x06015F11 RID: 89873 RVA: 0x00330AC8 File Offset: 0x0032ECC8
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

		// Token: 0x06015F12 RID: 89874 RVA: 0x00330B94 File Offset: 0x0032ED94
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

		// Token: 0x06015F13 RID: 89875 RVA: 0x00330C59 File Offset: 0x0032EE59
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06015F14 RID: 89876 RVA: 0x00330C64 File Offset: 0x0032EE64
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

		// Token: 0x040083A4 RID: 33700
		private UnknownFieldSet _unknownFields;

		// Token: 0x040083A5 RID: 33701
		public const int ConfigIdFieldNumber = 1;

		// Token: 0x040083A6 RID: 33702
		private int configId_;

		// Token: 0x040083A7 RID: 33703
		public const int IsNewFieldNumber = 2;

		// Token: 0x040083A8 RID: 33704
		private bool isNew_;

		// Token: 0x040083A9 RID: 33705
		public const int IsSellFieldNumber = 3;

		// Token: 0x040083AA RID: 33706
		private bool isSell_;

		// Token: 0x040083AB RID: 33707
		public const int ElementUnitsFieldNumber = 4;

		// Token: 0x040083AC RID: 33708
		private static readonly FieldCodec<ElementUnit> _repeated_elementUnits_codec = FieldCodec.ForMessage<ElementUnit>(34U, ElementUnit.Parser);

		// Token: 0x040083AD RID: 33709
		private readonly RepeatedField<ElementUnit> elementUnits_ = new RepeatedField<ElementUnit>();

		// Token: 0x040083AE RID: 33710
		public const int SourcePriceFieldNumber = 5;

		// Token: 0x040083AF RID: 33711
		private int sourcePrice_;

		// Token: 0x040083B0 RID: 33712
		public const int CurPriceFieldNumber = 6;

		// Token: 0x040083B1 RID: 33713
		private int curPrice_;

		// Token: 0x040083B2 RID: 33714
		public const int ItemIdFieldNumber = 7;

		// Token: 0x040083B3 RID: 33715
		private int itemId_;

		// Token: 0x040083B4 RID: 33716
		public const int IndexFieldNumber = 8;

		// Token: 0x040083B5 RID: 33717
		private int index_;
	}
}
