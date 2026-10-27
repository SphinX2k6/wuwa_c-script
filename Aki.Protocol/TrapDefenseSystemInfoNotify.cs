using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001454 RID: 5204
	[NetMessage(EMessageId.TrapDefenseSystemInfoNotify)]
	public sealed class TrapDefenseSystemInfoNotify : IMessage<TrapDefenseSystemInfoNotify>, IMessage, IEquatable<TrapDefenseSystemInfoNotify>, IDeepCloneable<TrapDefenseSystemInfoNotify>, IBufferMessage
	{
		// Token: 0x0601B8EC RID: 112876 RVA: 0x003FD329 File Offset: 0x003FB529
		[NullableContext(1)]
		public static TrapDefenseSystemInfoNotify Create()
		{
			return new TrapDefenseSystemInfoNotify();
		}

		// Token: 0x17005CEA RID: 23786
		// (get) Token: 0x0601B8ED RID: 112877 RVA: 0x003FD330 File Offset: 0x003FB530
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005CEB RID: 23787
		// (get) Token: 0x0601B8EE RID: 112878 RVA: 0x003FD333 File Offset: 0x003FB533
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TrapDefenseSystemInfoNotify.Descriptor;
			}
		}

		// Token: 0x0601B8EF RID: 112879 RVA: 0x003FD33A File Offset: 0x003FB53A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseSystemInfoNotify()
		{
		}

		// Token: 0x0601B8F0 RID: 112880 RVA: 0x003FD37C File Offset: 0x003FB57C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseSystemInfoNotify(TrapDefenseSystemInfoNotify other) : this()
		{
			this._hasBits0 = other._hasBits0;
			this.variableKeyNames_ = other.variableKeyNames_.Clone();
			this.slots_ = other.slots_.Clone();
			this.auxiliaries_ = other.auxiliaries_.Clone();
			this.buildings_ = other.buildings_.Clone();
			this.techParams_ = ((other.techParams_ != null) ? other.techParams_.Clone() : null);
			this.itemDatas_ = other.itemDatas_.Clone();
			this.changedMiniMap_ = other.changedMiniMap_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601B8F1 RID: 112881 RVA: 0x003FD429 File Offset: 0x003FB629
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseSystemInfoNotify Clone()
		{
			return new TrapDefenseSystemInfoNotify(this);
		}

		// Token: 0x17005CEC RID: 23788
		// (get) Token: 0x0601B8F2 RID: 112882 RVA: 0x003FD431 File Offset: 0x003FB631
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<string, string> VariableKeyNames
		{
			get
			{
				return this.variableKeyNames_;
			}
		}

		// Token: 0x17005CED RID: 23789
		// (get) Token: 0x0601B8F3 RID: 112883 RVA: 0x003FD439 File Offset: 0x003FB639
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<TrapDefenseSlot> Slots
		{
			get
			{
				return this.slots_;
			}
		}

		// Token: 0x17005CEE RID: 23790
		// (get) Token: 0x0601B8F4 RID: 112884 RVA: 0x003FD441 File Offset: 0x003FB641
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<TrapDefenseAuxiliaryInfo> Auxiliaries
		{
			get
			{
				return this.auxiliaries_;
			}
		}

		// Token: 0x17005CEF RID: 23791
		// (get) Token: 0x0601B8F5 RID: 112885 RVA: 0x003FD449 File Offset: 0x003FB649
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<TrapDefenseBuildingInfo> Buildings
		{
			get
			{
				return this.buildings_;
			}
		}

		// Token: 0x17005CF0 RID: 23792
		// (get) Token: 0x0601B8F6 RID: 112886 RVA: 0x003FD451 File Offset: 0x003FB651
		// (set) Token: 0x0601B8F7 RID: 112887 RVA: 0x003FD459 File Offset: 0x003FB659
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseTechParam TechParams
		{
			get
			{
				return this.techParams_;
			}
			set
			{
				this.techParams_ = value;
			}
		}

		// Token: 0x17005CF1 RID: 23793
		// (get) Token: 0x0601B8F8 RID: 112888 RVA: 0x003FD462 File Offset: 0x003FB662
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<TrapDefenseItemPbData> ItemDatas
		{
			get
			{
				return this.itemDatas_;
			}
		}

		// Token: 0x17005CF2 RID: 23794
		// (get) Token: 0x0601B8F9 RID: 112889 RVA: 0x003FD46A File Offset: 0x003FB66A
		// (set) Token: 0x0601B8FA RID: 112890 RVA: 0x003FD482 File Offset: 0x003FB682
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ChangedMiniMap
		{
			get
			{
				if ((this._hasBits0 & 1) != 0)
				{
					return this.changedMiniMap_;
				}
				return TrapDefenseSystemInfoNotify.ChangedMiniMapDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.changedMiniMap_ = value;
			}
		}

		// Token: 0x17005CF3 RID: 23795
		// (get) Token: 0x0601B8FB RID: 112891 RVA: 0x003FD499 File Offset: 0x003FB699
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasChangedMiniMap
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x0601B8FC RID: 112892 RVA: 0x003FD4A6 File Offset: 0x003FB6A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearChangedMiniMap()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x0601B8FD RID: 112893 RVA: 0x003FD4B7 File Offset: 0x003FB6B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TrapDefenseSystemInfoNotify);
		}

		// Token: 0x0601B8FE RID: 112894 RVA: 0x003FD4C8 File Offset: 0x003FB6C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TrapDefenseSystemInfoNotify other)
		{
			return other != null && (other == this || (this.VariableKeyNames.Equals(other.VariableKeyNames) && this.slots_.Equals(other.slots_) && this.auxiliaries_.Equals(other.auxiliaries_) && this.buildings_.Equals(other.buildings_) && object.Equals(this.TechParams, other.TechParams) && this.itemDatas_.Equals(other.itemDatas_) && this.ChangedMiniMap == other.ChangedMiniMap && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601B8FF RID: 112895 RVA: 0x003FD580 File Offset: 0x003FB780
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.VariableKeyNames.GetHashCode();
			num ^= this.slots_.GetHashCode();
			num ^= this.auxiliaries_.GetHashCode();
			num ^= this.buildings_.GetHashCode();
			if (this.techParams_ != null)
			{
				num ^= this.TechParams.GetHashCode();
			}
			num ^= this.itemDatas_.GetHashCode();
			if (this.HasChangedMiniMap)
			{
				num ^= this.ChangedMiniMap.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601B900 RID: 112896 RVA: 0x003FD61B File Offset: 0x003FB81B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601B901 RID: 112897 RVA: 0x003FD628 File Offset: 0x003FB828
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601B902 RID: 112898 RVA: 0x003FD634 File Offset: 0x003FB834
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.HasChangedMiniMap)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.ChangedMiniMap);
			}
			this.auxiliaries_.WriteTo(ref output, TrapDefenseSystemInfoNotify._repeated_auxiliaries_codec);
			this.itemDatas_.WriteTo(ref output, TrapDefenseSystemInfoNotify._repeated_itemDatas_codec);
			this.variableKeyNames_.WriteTo(ref output, TrapDefenseSystemInfoNotify._map_variableKeyNames_codec);
			this.slots_.WriteTo(ref output, TrapDefenseSystemInfoNotify._repeated_slots_codec);
			if (this.techParams_ != null)
			{
				output.WriteRawTag(74);
				output.WriteMessage(this.TechParams);
			}
			this.buildings_.WriteTo(ref output, TrapDefenseSystemInfoNotify._repeated_buildings_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601B903 RID: 112899 RVA: 0x003FD6E4 File Offset: 0x003FB8E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.variableKeyNames_.CalculateSize(TrapDefenseSystemInfoNotify._map_variableKeyNames_codec);
			num += this.slots_.CalculateSize(TrapDefenseSystemInfoNotify._repeated_slots_codec);
			num += this.auxiliaries_.CalculateSize(TrapDefenseSystemInfoNotify._repeated_auxiliaries_codec);
			num += this.buildings_.CalculateSize(TrapDefenseSystemInfoNotify._repeated_buildings_codec);
			if (this.techParams_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.TechParams);
			}
			num += this.itemDatas_.CalculateSize(TrapDefenseSystemInfoNotify._repeated_itemDatas_codec);
			if (this.HasChangedMiniMap)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ChangedMiniMap);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601B904 RID: 112900 RVA: 0x003FD79C File Offset: 0x003FB99C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TrapDefenseSystemInfoNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.variableKeyNames_.MergeFrom(other.variableKeyNames_);
			this.slots_.Add(other.slots_);
			this.auxiliaries_.Add(other.auxiliaries_);
			this.buildings_.Add(other.buildings_);
			if (other.techParams_ != null)
			{
				if (this.techParams_ == null)
				{
					this.TechParams = new TrapDefenseTechParam();
				}
				this.TechParams.MergeFrom(other.TechParams);
			}
			this.itemDatas_.Add(other.itemDatas_);
			if (other.HasChangedMiniMap)
			{
				this.ChangedMiniMap = other.ChangedMiniMap;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601B905 RID: 112901 RVA: 0x003FD859 File Offset: 0x003FBA59
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601B906 RID: 112902 RVA: 0x003FD864 File Offset: 0x003FBA64
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
					if (num == 16U)
					{
						this.ChangedMiniMap = input.ReadInt32();
						continue;
					}
					if (num == 26U)
					{
						this.auxiliaries_.AddEntriesFrom(ref input, TrapDefenseSystemInfoNotify._repeated_auxiliaries_codec);
						continue;
					}
					if (num == 34U)
					{
						this.itemDatas_.AddEntriesFrom(ref input, TrapDefenseSystemInfoNotify._repeated_itemDatas_codec);
						continue;
					}
				}
				else if (num <= 66U)
				{
					if (num == 42U)
					{
						this.variableKeyNames_.AddEntriesFrom(ref input, TrapDefenseSystemInfoNotify._map_variableKeyNames_codec);
						continue;
					}
					if (num == 66U)
					{
						this.slots_.AddEntriesFrom(ref input, TrapDefenseSystemInfoNotify._repeated_slots_codec);
						continue;
					}
				}
				else
				{
					if (num == 74U)
					{
						if (this.techParams_ == null)
						{
							this.TechParams = new TrapDefenseTechParam();
						}
						input.ReadMessage(this.TechParams);
						continue;
					}
					if (num == 114U)
					{
						this.buildings_.AddEntriesFrom(ref input, TrapDefenseSystemInfoNotify._repeated_buildings_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04009ED8 RID: 40664
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009ED9 RID: 40665
		private int _hasBits0;

		// Token: 0x04009EDA RID: 40666
		public const int VariableKeyNamesFieldNumber = 5;

		// Token: 0x04009EDB RID: 40667
		private static readonly MapField<string, string>.Codec _map_variableKeyNames_codec = new MapField<string, string>.Codec(FieldCodec.ForString(10U, ""), FieldCodec.ForString(18U, ""), 42U);

		// Token: 0x04009EDC RID: 40668
		private readonly MapField<string, string> variableKeyNames_ = new MapField<string, string>();

		// Token: 0x04009EDD RID: 40669
		public const int SlotsFieldNumber = 8;

		// Token: 0x04009EDE RID: 40670
		private static readonly FieldCodec<TrapDefenseSlot> _repeated_slots_codec = FieldCodec.ForMessage<TrapDefenseSlot>(66U, TrapDefenseSlot.Parser);

		// Token: 0x04009EDF RID: 40671
		private readonly RepeatedField<TrapDefenseSlot> slots_ = new RepeatedField<TrapDefenseSlot>();

		// Token: 0x04009EE0 RID: 40672
		public const int AuxiliariesFieldNumber = 3;

		// Token: 0x04009EE1 RID: 40673
		private static readonly FieldCodec<TrapDefenseAuxiliaryInfo> _repeated_auxiliaries_codec = FieldCodec.ForMessage<TrapDefenseAuxiliaryInfo>(26U, TrapDefenseAuxiliaryInfo.Parser);

		// Token: 0x04009EE2 RID: 40674
		private readonly RepeatedField<TrapDefenseAuxiliaryInfo> auxiliaries_ = new RepeatedField<TrapDefenseAuxiliaryInfo>();

		// Token: 0x04009EE3 RID: 40675
		public const int BuildingsFieldNumber = 14;

		// Token: 0x04009EE4 RID: 40676
		private static readonly FieldCodec<TrapDefenseBuildingInfo> _repeated_buildings_codec = FieldCodec.ForMessage<TrapDefenseBuildingInfo>(114U, TrapDefenseBuildingInfo.Parser);

		// Token: 0x04009EE5 RID: 40677
		private readonly RepeatedField<TrapDefenseBuildingInfo> buildings_ = new RepeatedField<TrapDefenseBuildingInfo>();

		// Token: 0x04009EE6 RID: 40678
		public const int TechParamsFieldNumber = 9;

		// Token: 0x04009EE7 RID: 40679
		private TrapDefenseTechParam techParams_;

		// Token: 0x04009EE8 RID: 40680
		public const int ItemDatasFieldNumber = 4;

		// Token: 0x04009EE9 RID: 40681
		private static readonly FieldCodec<TrapDefenseItemPbData> _repeated_itemDatas_codec = FieldCodec.ForMessage<TrapDefenseItemPbData>(34U, TrapDefenseItemPbData.Parser);

		// Token: 0x04009EEA RID: 40682
		private readonly RepeatedField<TrapDefenseItemPbData> itemDatas_ = new RepeatedField<TrapDefenseItemPbData>();

		// Token: 0x04009EEB RID: 40683
		public const int ChangedMiniMapFieldNumber = 2;

		// Token: 0x04009EEC RID: 40684
		private static readonly int ChangedMiniMapDefaultValue = 0;

		// Token: 0x04009EED RID: 40685
		private int changedMiniMap_;
	}
}
