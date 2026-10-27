using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F85 RID: 3973
	public sealed class RogueGainEntry : IMessage<RogueGainEntry>, IMessage, IEquatable<RogueGainEntry>, IDeepCloneable<RogueGainEntry>, IBufferMessage
	{
		// Token: 0x060153D6 RID: 86998 RVA: 0x00314555 File Offset: 0x00312755
		[NullableContext(1)]
		public static RogueGainEntry Create()
		{
			return new RogueGainEntry();
		}

		// Token: 0x170046AF RID: 18095
		// (get) Token: 0x060153D7 RID: 86999 RVA: 0x0031455C File Offset: 0x0031275C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueGainEntry> Parser
		{
			get
			{
				return RogueGainEntry._parser;
			}
		}

		// Token: 0x170046B0 RID: 18096
		// (get) Token: 0x060153D8 RID: 87000 RVA: 0x00314563 File Offset: 0x00312763
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170046B1 RID: 18097
		// (get) Token: 0x060153D9 RID: 87001 RVA: 0x00314566 File Offset: 0x00312766
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueGainEntry.Descriptor;
			}
		}

		// Token: 0x060153DA RID: 87002 RVA: 0x0031456D File Offset: 0x0031276D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueGainEntry()
		{
		}

		// Token: 0x060153DB RID: 87003 RVA: 0x0031458C File Offset: 0x0031278C
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

		// Token: 0x060153DC RID: 87004 RVA: 0x00314672 File Offset: 0x00312872
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueGainEntry Clone()
		{
			return new RogueGainEntry(this);
		}

		// Token: 0x170046B2 RID: 18098
		// (get) Token: 0x060153DD RID: 87005 RVA: 0x0031467A File Offset: 0x0031287A
		// (set) Token: 0x060153DE RID: 87006 RVA: 0x00314682 File Offset: 0x00312882
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

		// Token: 0x170046B3 RID: 18099
		// (get) Token: 0x060153DF RID: 87007 RVA: 0x0031468B File Offset: 0x0031288B
		// (set) Token: 0x060153E0 RID: 87008 RVA: 0x00314693 File Offset: 0x00312893
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

		// Token: 0x170046B4 RID: 18100
		// (get) Token: 0x060153E1 RID: 87009 RVA: 0x0031469C File Offset: 0x0031289C
		// (set) Token: 0x060153E2 RID: 87010 RVA: 0x003146A4 File Offset: 0x003128A4
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

		// Token: 0x170046B5 RID: 18101
		// (get) Token: 0x060153E3 RID: 87011 RVA: 0x003146AD File Offset: 0x003128AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, int> ElementDict
		{
			get
			{
				return this.elementDict_;
			}
		}

		// Token: 0x170046B6 RID: 18102
		// (get) Token: 0x060153E4 RID: 87012 RVA: 0x003146B5 File Offset: 0x003128B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<AffixEntry> AffixEntryList
		{
			get
			{
				return this.affixEntryList_;
			}
		}

		// Token: 0x170046B7 RID: 18103
		// (get) Token: 0x060153E5 RID: 87013 RVA: 0x003146BD File Offset: 0x003128BD
		// (set) Token: 0x060153E6 RID: 87014 RVA: 0x003146C5 File Offset: 0x003128C5
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

		// Token: 0x170046B8 RID: 18104
		// (get) Token: 0x060153E7 RID: 87015 RVA: 0x003146CE File Offset: 0x003128CE
		// (set) Token: 0x060153E8 RID: 87016 RVA: 0x003146E6 File Offset: 0x003128E6
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

		// Token: 0x170046B9 RID: 18105
		// (get) Token: 0x060153E9 RID: 87017 RVA: 0x003146FD File Offset: 0x003128FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasIsSell
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x060153EA RID: 87018 RVA: 0x0031470A File Offset: 0x0031290A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearIsSell()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x170046BA RID: 18106
		// (get) Token: 0x060153EB RID: 87019 RVA: 0x0031471B File Offset: 0x0031291B
		// (set) Token: 0x060153EC RID: 87020 RVA: 0x00314723 File Offset: 0x00312923
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

		// Token: 0x170046BB RID: 18107
		// (get) Token: 0x060153ED RID: 87021 RVA: 0x0031472C File Offset: 0x0031292C
		// (set) Token: 0x060153EE RID: 87022 RVA: 0x00314734 File Offset: 0x00312934
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

		// Token: 0x170046BC RID: 18108
		// (get) Token: 0x060153EF RID: 87023 RVA: 0x0031473D File Offset: 0x0031293D
		// (set) Token: 0x060153F0 RID: 87024 RVA: 0x00314745 File Offset: 0x00312945
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

		// Token: 0x170046BD RID: 18109
		// (get) Token: 0x060153F1 RID: 87025 RVA: 0x0031474E File Offset: 0x0031294E
		// (set) Token: 0x060153F2 RID: 87026 RVA: 0x00314756 File Offset: 0x00312956
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

		// Token: 0x170046BE RID: 18110
		// (get) Token: 0x060153F3 RID: 87027 RVA: 0x0031475F File Offset: 0x0031295F
		// (set) Token: 0x060153F4 RID: 87028 RVA: 0x00314767 File Offset: 0x00312967
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

		// Token: 0x170046BF RID: 18111
		// (get) Token: 0x060153F5 RID: 87029 RVA: 0x00314770 File Offset: 0x00312970
		// (set) Token: 0x060153F6 RID: 87030 RVA: 0x00314778 File Offset: 0x00312978
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

		// Token: 0x060153F7 RID: 87031 RVA: 0x00314781 File Offset: 0x00312981
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueGainEntry);
		}

		// Token: 0x060153F8 RID: 87032 RVA: 0x00314790 File Offset: 0x00312990
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueGainEntry other)
		{
			return other != null && (other == this || (this.Type == other.Type && this.Index == other.Index && this.ConfigId == other.ConfigId && this.ElementDict.Equals(other.ElementDict) && this.affixEntryList_.Equals(other.affixEntryList_) && object.Equals(this.DiscountInfo, other.DiscountInfo) && this.IsSell == other.IsSell && this.IsSelect == other.IsSelect && this.IsNew == other.IsNew && this.Cost == other.Cost && this.RestCount == other.RestCount && this.IsValid == other.IsValid && this.IncId == other.IncId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060153F9 RID: 87033 RVA: 0x00314898 File Offset: 0x00312A98
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

		// Token: 0x060153FA RID: 87034 RVA: 0x003149F0 File Offset: 0x00312BF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060153FB RID: 87035 RVA: 0x003149FD File Offset: 0x00312BFD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060153FC RID: 87036 RVA: 0x00314A08 File Offset: 0x00312C08
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

		// Token: 0x060153FD RID: 87037 RVA: 0x00314B80 File Offset: 0x00312D80
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

		// Token: 0x060153FE RID: 87038 RVA: 0x00314CA4 File Offset: 0x00312EA4
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

		// Token: 0x060153FF RID: 87039 RVA: 0x00314DE2 File Offset: 0x00312FE2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06015400 RID: 87040 RVA: 0x00314DEC File Offset: 0x00312FEC
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

		// Token: 0x04007FAF RID: 32687
		private static readonly MessageParser<RogueGainEntry> _parser = new MessageParser<RogueGainEntry>(() => new RogueGainEntry());

		// Token: 0x04007FB0 RID: 32688
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007FB1 RID: 32689
		private int _hasBits0;

		// Token: 0x04007FB2 RID: 32690
		public const int TypeFieldNumber = 1;

		// Token: 0x04007FB3 RID: 32691
		private RoguelikeGainDataType type_;

		// Token: 0x04007FB4 RID: 32692
		public const int IndexFieldNumber = 2;

		// Token: 0x04007FB5 RID: 32693
		private int index_;

		// Token: 0x04007FB6 RID: 32694
		public const int ConfigIdFieldNumber = 3;

		// Token: 0x04007FB7 RID: 32695
		private int configId_;

		// Token: 0x04007FB8 RID: 32696
		public const int ElementDictFieldNumber = 4;

		// Token: 0x04007FB9 RID: 32697
		private static readonly MapField<int, int>.Codec _map_elementDict_codec = new MapField<int, int>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForInt32(16U, 0), 34U);

		// Token: 0x04007FBA RID: 32698
		private readonly MapField<int, int> elementDict_ = new MapField<int, int>();

		// Token: 0x04007FBB RID: 32699
		public const int AffixEntryListFieldNumber = 5;

		// Token: 0x04007FBC RID: 32700
		private static readonly FieldCodec<AffixEntry> _repeated_affixEntryList_codec = FieldCodec.ForMessage<AffixEntry>(42U, AffixEntry.Parser);

		// Token: 0x04007FBD RID: 32701
		private readonly RepeatedField<AffixEntry> affixEntryList_ = new RepeatedField<AffixEntry>();

		// Token: 0x04007FBE RID: 32702
		public const int DiscountInfoFieldNumber = 6;

		// Token: 0x04007FBF RID: 32703
		private DiscountInfo discountInfo_;

		// Token: 0x04007FC0 RID: 32704
		public const int IsSellFieldNumber = 7;

		// Token: 0x04007FC1 RID: 32705
		private static readonly bool IsSellDefaultValue = false;

		// Token: 0x04007FC2 RID: 32706
		private bool isSell_;

		// Token: 0x04007FC3 RID: 32707
		public const int IsSelectFieldNumber = 8;

		// Token: 0x04007FC4 RID: 32708
		private bool isSelect_;

		// Token: 0x04007FC5 RID: 32709
		public const int IsNewFieldNumber = 9;

		// Token: 0x04007FC6 RID: 32710
		private bool isNew_;

		// Token: 0x04007FC7 RID: 32711
		public const int CostFieldNumber = 10;

		// Token: 0x04007FC8 RID: 32712
		private int cost_;

		// Token: 0x04007FC9 RID: 32713
		public const int RestCountFieldNumber = 11;

		// Token: 0x04007FCA RID: 32714
		private int restCount_;

		// Token: 0x04007FCB RID: 32715
		public const int IsValidFieldNumber = 12;

		// Token: 0x04007FCC RID: 32716
		private bool isValid_;

		// Token: 0x04007FCD RID: 32717
		public const int IncIdFieldNumber = 13;

		// Token: 0x04007FCE RID: 32718
		private int incId_;
	}
}
