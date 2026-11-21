using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F75 RID: 3957
	public sealed class RogueGainEntry : IMessage<RogueGainEntry>, IMessage, IEquatable<RogueGainEntry>, IDeepCloneable<RogueGainEntry>, IBufferMessage
	{
		// Token: 0x060152F1 RID: 86769 RVA: 0x00312EA0 File Offset: 0x003110A0
		[NullableContext(1)]
		public static RogueGainEntry Create()
		{
			return new RogueGainEntry();
		}

		// Token: 0x17004685 RID: 18053
		// (get) Token: 0x060152F2 RID: 86770 RVA: 0x00312EA7 File Offset: 0x003110A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueGainEntry> Parser
		{
			get
			{
				return RogueGainEntry._parser;
			}
		}

		// Token: 0x17004686 RID: 18054
		// (get) Token: 0x060152F3 RID: 86771 RVA: 0x00312EAE File Offset: 0x003110AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004687 RID: 18055
		// (get) Token: 0x060152F4 RID: 86772 RVA: 0x00312EB1 File Offset: 0x003110B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueGainEntry.Descriptor;
			}
		}

		// Token: 0x060152F5 RID: 86773 RVA: 0x00312EB8 File Offset: 0x003110B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueGainEntry()
		{
		}

		// Token: 0x060152F6 RID: 86774 RVA: 0x00312ED8 File Offset: 0x003110D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueGainEntry(RogueGainEntry other) : this()
		{
			this._hasBits0 = other._hasBits0;
			this.type_ = other.type_;
			this.index_ = other.index_;
			this.configId_ = other.configId_;
			this.elementDict_ = other.elementDict_.Clone();
			this.affixEntryList_ = other.affixEntryList_.Clone();
			this.discountInfo_ = ((other.discountInfo_ != null) ? other.discountInfo_.Clone() : null);
			this.isSell_ = other.isSell_;
			this.isSelect_ = other.isSelect_;
			this.isNew_ = other.isNew_;
			this.cost_ = other.cost_;
			this.restCount_ = other.restCount_;
			this.isValid_ = other.isValid_;
			this.incId_ = other.incId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060152F7 RID: 86775 RVA: 0x00312FBE File Offset: 0x003111BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueGainEntry Clone()
		{
			return new RogueGainEntry(this);
		}

		// Token: 0x17004688 RID: 18056
		// (get) Token: 0x060152F8 RID: 86776 RVA: 0x00312FC6 File Offset: 0x003111C6
		// (set) Token: 0x060152F9 RID: 86777 RVA: 0x00312FCE File Offset: 0x003111CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeGainDataType Type
		{
			get
			{
				return this.type_;
			}
			set
			{
				this.type_ = value;
			}
		}

		// Token: 0x17004689 RID: 18057
		// (get) Token: 0x060152FA RID: 86778 RVA: 0x00312FD7 File Offset: 0x003111D7
		// (set) Token: 0x060152FB RID: 86779 RVA: 0x00312FDF File Offset: 0x003111DF
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

		// Token: 0x1700468A RID: 18058
		// (get) Token: 0x060152FC RID: 86780 RVA: 0x00312FE8 File Offset: 0x003111E8
		// (set) Token: 0x060152FD RID: 86781 RVA: 0x00312FF0 File Offset: 0x003111F0
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

		// Token: 0x1700468B RID: 18059
		// (get) Token: 0x060152FE RID: 86782 RVA: 0x00312FF9 File Offset: 0x003111F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, int> ElementDict
		{
			get
			{
				return this.elementDict_;
			}
		}

		// Token: 0x1700468C RID: 18060
		// (get) Token: 0x060152FF RID: 86783 RVA: 0x00313001 File Offset: 0x00311201
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<AffixEntry> AffixEntryList
		{
			get
			{
				return this.affixEntryList_;
			}
		}

		// Token: 0x1700468D RID: 18061
		// (get) Token: 0x06015300 RID: 86784 RVA: 0x00313009 File Offset: 0x00311209
		// (set) Token: 0x06015301 RID: 86785 RVA: 0x00313011 File Offset: 0x00311211
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DiscountInfo DiscountInfo
		{
			get
			{
				return this.discountInfo_;
			}
			set
			{
				this.discountInfo_ = value;
			}
		}

		// Token: 0x1700468E RID: 18062
		// (get) Token: 0x06015302 RID: 86786 RVA: 0x0031301A File Offset: 0x0031121A
		// (set) Token: 0x06015303 RID: 86787 RVA: 0x00313032 File Offset: 0x00311232
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsSell
		{
			get
			{
				if ((this._hasBits0 & 1) != 0)
				{
					return this.isSell_;
				}
				return RogueGainEntry.IsSellDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.isSell_ = value;
			}
		}

		// Token: 0x1700468F RID: 18063
		// (get) Token: 0x06015304 RID: 86788 RVA: 0x00313049 File Offset: 0x00311249
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasIsSell
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06015305 RID: 86789 RVA: 0x00313056 File Offset: 0x00311256
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearIsSell()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17004690 RID: 18064
		// (get) Token: 0x06015306 RID: 86790 RVA: 0x00313067 File Offset: 0x00311267
		// (set) Token: 0x06015307 RID: 86791 RVA: 0x0031306F File Offset: 0x0031126F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsSelect
		{
			get
			{
				return this.isSelect_;
			}
			set
			{
				this.isSelect_ = value;
			}
		}

		// Token: 0x17004691 RID: 18065
		// (get) Token: 0x06015308 RID: 86792 RVA: 0x00313078 File Offset: 0x00311278
		// (set) Token: 0x06015309 RID: 86793 RVA: 0x00313080 File Offset: 0x00311280
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

		// Token: 0x17004692 RID: 18066
		// (get) Token: 0x0601530A RID: 86794 RVA: 0x00313089 File Offset: 0x00311289
		// (set) Token: 0x0601530B RID: 86795 RVA: 0x00313091 File Offset: 0x00311291
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Cost
		{
			get
			{
				return this.cost_;
			}
			set
			{
				this.cost_ = value;
			}
		}

		// Token: 0x17004693 RID: 18067
		// (get) Token: 0x0601530C RID: 86796 RVA: 0x0031309A File Offset: 0x0031129A
		// (set) Token: 0x0601530D RID: 86797 RVA: 0x003130A2 File Offset: 0x003112A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RestCount
		{
			get
			{
				return this.restCount_;
			}
			set
			{
				this.restCount_ = value;
			}
		}

		// Token: 0x17004694 RID: 18068
		// (get) Token: 0x0601530E RID: 86798 RVA: 0x003130AB File Offset: 0x003112AB
		// (set) Token: 0x0601530F RID: 86799 RVA: 0x003130B3 File Offset: 0x003112B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsValid
		{
			get
			{
				return this.isValid_;
			}
			set
			{
				this.isValid_ = value;
			}
		}

		// Token: 0x17004695 RID: 18069
		// (get) Token: 0x06015310 RID: 86800 RVA: 0x003130BC File Offset: 0x003112BC
		// (set) Token: 0x06015311 RID: 86801 RVA: 0x003130C4 File Offset: 0x003112C4
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

		// Token: 0x06015312 RID: 86802 RVA: 0x003130CD File Offset: 0x003112CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueGainEntry);
		}

		// Token: 0x06015313 RID: 86803 RVA: 0x003130DC File Offset: 0x003112DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueGainEntry other)
		{
			return other != null && (other == this || (this.Type == other.Type && this.Index == other.Index && this.ConfigId == other.ConfigId && this.ElementDict.Equals(other.ElementDict) && this.affixEntryList_.Equals(other.affixEntryList_) && object.Equals(this.DiscountInfo, other.DiscountInfo) && this.IsSell == other.IsSell && this.IsSelect == other.IsSelect && this.IsNew == other.IsNew && this.Cost == other.Cost && this.RestCount == other.RestCount && this.IsValid == other.IsValid && this.IncId == other.IncId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06015314 RID: 86804 RVA: 0x003131E4 File Offset: 0x003113E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Type != RoguelikeGainDataType.Unkonw)
			{
				num ^= this.Type.GetHashCode();
			}
			if (this.Index != 0)
			{
				num ^= this.Index.GetHashCode();
			}
			if (this.ConfigId != 0)
			{
				num ^= this.ConfigId.GetHashCode();
			}
			num ^= this.ElementDict.GetHashCode();
			num ^= this.affixEntryList_.GetHashCode();
			if (this.discountInfo_ != null)
			{
				num ^= this.DiscountInfo.GetHashCode();
			}
			if (this.HasIsSell)
			{
				num ^= this.IsSell.GetHashCode();
			}
			if (this.IsSelect)
			{
				num ^= this.IsSelect.GetHashCode();
			}
			if (this.IsNew)
			{
				num ^= this.IsNew.GetHashCode();
			}
			if (this.Cost != 0)
			{
				num ^= this.Cost.GetHashCode();
			}
			if (this.RestCount != 0)
			{
				num ^= this.RestCount.GetHashCode();
			}
			if (this.IsValid)
			{
				num ^= this.IsValid.GetHashCode();
			}
			if (this.IncId != 0)
			{
				num ^= this.IncId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06015315 RID: 86805 RVA: 0x0031333C File Offset: 0x0031153C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06015316 RID: 86806 RVA: 0x00313349 File Offset: 0x00311549
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06015317 RID: 86807 RVA: 0x00313354 File Offset: 0x00311554
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Type != RoguelikeGainDataType.Unkonw)
			{
				output.WriteRawTag(8);
				output.WriteEnum((int)this.Type);
			}
			if (this.Index != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Index);
			}
			if (this.ConfigId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.ConfigId);
			}
			this.elementDict_.WriteTo(ref output, RogueGainEntry._map_elementDict_codec);
			this.affixEntryList_.WriteTo(ref output, RogueGainEntry._repeated_affixEntryList_codec);
			if (this.discountInfo_ != null)
			{
				output.WriteRawTag(50);
				output.WriteMessage(this.DiscountInfo);
			}
			if (this.HasIsSell)
			{
				output.WriteRawTag(56);
				output.WriteBool(this.IsSell);
			}
			if (this.IsSelect)
			{
				output.WriteRawTag(64);
				output.WriteBool(this.IsSelect);
			}
			if (this.IsNew)
			{
				output.WriteRawTag(72);
				output.WriteBool(this.IsNew);
			}
			if (this.Cost != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.Cost);
			}
			if (this.RestCount != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.RestCount);
			}
			if (this.IsValid)
			{
				output.WriteRawTag(96);
				output.WriteBool(this.IsValid);
			}
			if (this.IncId != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.IncId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06015318 RID: 86808 RVA: 0x003134CC File Offset: 0x003116CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Type != RoguelikeGainDataType.Unkonw)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Type);
			}
			if (this.Index != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Index);
			}
			if (this.ConfigId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ConfigId);
			}
			num += this.elementDict_.CalculateSize(RogueGainEntry._map_elementDict_codec);
			num += this.affixEntryList_.CalculateSize(RogueGainEntry._repeated_affixEntryList_codec);
			if (this.discountInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.DiscountInfo);
			}
			if (this.HasIsSell)
			{
				num += 2;
			}
			if (this.IsSelect)
			{
				num += 2;
			}
			if (this.IsNew)
			{
				num += 2;
			}
			if (this.Cost != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Cost);
			}
			if (this.RestCount != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RestCount);
			}
			if (this.IsValid)
			{
				num += 2;
			}
			if (this.IncId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.IncId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06015319 RID: 86809 RVA: 0x003135F0 File Offset: 0x003117F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueGainEntry other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Type != RoguelikeGainDataType.Unkonw)
			{
				this.Type = other.Type;
			}
			if (other.Index != 0)
			{
				this.Index = other.Index;
			}
			if (other.ConfigId != 0)
			{
				this.ConfigId = other.ConfigId;
			}
			this.elementDict_.MergeFrom(other.elementDict_);
			this.affixEntryList_.Add(other.affixEntryList_);
			if (other.discountInfo_ != null)
			{
				if (this.discountInfo_ == null)
				{
					this.DiscountInfo = new DiscountInfo();
				}
				this.DiscountInfo.MergeFrom(other.DiscountInfo);
			}
			if (other.HasIsSell)
			{
				this.IsSell = other.IsSell;
			}
			if (other.IsSelect)
			{
				this.IsSelect = other.IsSelect;
			}
			if (other.IsNew)
			{
				this.IsNew = other.IsNew;
			}
			if (other.Cost != 0)
			{
				this.Cost = other.Cost;
			}
			if (other.RestCount != 0)
			{
				this.RestCount = other.RestCount;
			}
			if (other.IsValid)
			{
				this.IsValid = other.IsValid;
			}
			if (other.IncId != 0)
			{
				this.IncId = other.IncId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601531A RID: 86810 RVA: 0x0031372E File Offset: 0x0031192E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601531B RID: 86811 RVA: 0x00313738 File Offset: 0x00311938
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
				if (num <= 50U)
				{
					if (num <= 24U)
					{
						if (num == 8U)
						{
							this.Type = (RoguelikeGainDataType)input.ReadEnum();
							continue;
						}
						if (num == 16U)
						{
							this.Index = input.ReadInt32();
							continue;
						}
						if (num == 24U)
						{
							this.ConfigId = input.ReadInt32();
							continue;
						}
					}
					else
					{
						if (num == 34U)
						{
							this.elementDict_.AddEntriesFrom(ref input, RogueGainEntry._map_elementDict_codec);
							continue;
						}
						if (num == 42U)
						{
							this.affixEntryList_.AddEntriesFrom(ref input, RogueGainEntry._repeated_affixEntryList_codec);
							continue;
						}
						if (num == 50U)
						{
							if (this.discountInfo_ == null)
							{
								this.DiscountInfo = new DiscountInfo();
							}
							input.ReadMessage(this.DiscountInfo);
							continue;
						}
					}
				}
				else if (num <= 72U)
				{
					if (num == 56U)
					{
						this.IsSell = input.ReadBool();
						continue;
					}
					if (num == 64U)
					{
						this.IsSelect = input.ReadBool();
						continue;
					}
					if (num == 72U)
					{
						this.IsNew = input.ReadBool();
						continue;
					}
				}
				else if (num <= 88U)
				{
					if (num == 80U)
					{
						this.Cost = input.ReadInt32();
						continue;
					}
					if (num == 88U)
					{
						this.RestCount = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 96U)
					{
						this.IsValid = input.ReadBool();
						continue;
					}
					if (num == 104U)
					{
						this.IncId = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04007FD9 RID: 32729
		private static readonly MessageParser<RogueGainEntry> _parser = new MessageParser<RogueGainEntry>(() => new RogueGainEntry());

		// Token: 0x04007FDA RID: 32730
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007FDB RID: 32731
		private int _hasBits0;

		// Token: 0x04007FDC RID: 32732
		public const int TypeFieldNumber = 1;

		// Token: 0x04007FDD RID: 32733
		private RoguelikeGainDataType type_;

		// Token: 0x04007FDE RID: 32734
		public const int IndexFieldNumber = 2;

		// Token: 0x04007FDF RID: 32735
		private int index_;

		// Token: 0x04007FE0 RID: 32736
		public const int ConfigIdFieldNumber = 3;

		// Token: 0x04007FE1 RID: 32737
		private int configId_;

		// Token: 0x04007FE2 RID: 32738
		public const int ElementDictFieldNumber = 4;

		// Token: 0x04007FE3 RID: 32739
		private static readonly MapField<int, int>.Codec _map_elementDict_codec = new MapField<int, int>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForInt32(16U, 0), 34U);

		// Token: 0x04007FE4 RID: 32740
		private readonly MapField<int, int> elementDict_ = new MapField<int, int>();

		// Token: 0x04007FE5 RID: 32741
		public const int AffixEntryListFieldNumber = 5;

		// Token: 0x04007FE6 RID: 32742
		private static readonly FieldCodec<AffixEntry> _repeated_affixEntryList_codec = FieldCodec.ForMessage<AffixEntry>(42U, AffixEntry.Parser);

		// Token: 0x04007FE7 RID: 32743
		private readonly RepeatedField<AffixEntry> affixEntryList_ = new RepeatedField<AffixEntry>();

		// Token: 0x04007FE8 RID: 32744
		public const int DiscountInfoFieldNumber = 6;

		// Token: 0x04007FE9 RID: 32745
		private DiscountInfo discountInfo_;

		// Token: 0x04007FEA RID: 32746
		public const int IsSellFieldNumber = 7;

		// Token: 0x04007FEB RID: 32747
		private static readonly bool IsSellDefaultValue = false;

		// Token: 0x04007FEC RID: 32748
		private bool isSell_;

		// Token: 0x04007FED RID: 32749
		public const int IsSelectFieldNumber = 8;

		// Token: 0x04007FEE RID: 32750
		private bool isSelect_;

		// Token: 0x04007FEF RID: 32751
		public const int IsNewFieldNumber = 9;

		// Token: 0x04007FF0 RID: 32752
		private bool isNew_;

		// Token: 0x04007FF1 RID: 32753
		public const int CostFieldNumber = 10;

		// Token: 0x04007FF2 RID: 32754
		private int cost_;

		// Token: 0x04007FF3 RID: 32755
		public const int RestCountFieldNumber = 11;

		// Token: 0x04007FF4 RID: 32756
		private int restCount_;

		// Token: 0x04007FF5 RID: 32757
		public const int IsValidFieldNumber = 12;

		// Token: 0x04007FF6 RID: 32758
		private bool isValid_;

		// Token: 0x04007FF7 RID: 32759
		public const int IncIdFieldNumber = 13;

		// Token: 0x04007FF8 RID: 32760
		private int incId_;
	}
}
