using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020014C7 RID: 5319
	[NetMessage(EMessageId.TrapDefenseSystemInfoNotify)]
	public sealed class TrapDefenseSystemInfoNotify : IMessage<TrapDefenseSystemInfoNotify>, IMessage, IEquatable<TrapDefenseSystemInfoNotify>, IDeepCloneable<TrapDefenseSystemInfoNotify>, IBufferMessage
	{
		// Token: 0x0601C377 RID: 115575 RVA: 0x004185F9 File Offset: 0x004167F9
		[NullableContext(1)]
		public static TrapDefenseSystemInfoNotify Create()
		{
			return new TrapDefenseSystemInfoNotify();
		}

		// Token: 0x17005F7F RID: 24447
		// (get) Token: 0x0601C378 RID: 115576 RVA: 0x00418600 File Offset: 0x00416800
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005F80 RID: 24448
		// (get) Token: 0x0601C379 RID: 115577 RVA: 0x00418603 File Offset: 0x00416803
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TrapDefenseSystemInfoNotify.Descriptor;
			}
		}

		// Token: 0x0601C37A RID: 115578 RVA: 0x0041860A File Offset: 0x0041680A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseSystemInfoNotify()
		{
		}

		// Token: 0x0601C37B RID: 115579 RVA: 0x0041864C File Offset: 0x0041684C
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

		// Token: 0x0601C37C RID: 115580 RVA: 0x004186F9 File Offset: 0x004168F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseSystemInfoNotify Clone()
		{
			return new TrapDefenseSystemInfoNotify(this);
		}

		// Token: 0x17005F81 RID: 24449
		// (get) Token: 0x0601C37D RID: 115581 RVA: 0x00418701 File Offset: 0x00416901
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<string, string> VariableKeyNames
		{
			get
			{
				return this.variableKeyNames_;
			}
		}

		// Token: 0x17005F82 RID: 24450
		// (get) Token: 0x0601C37E RID: 115582 RVA: 0x00418709 File Offset: 0x00416909
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<TrapDefenseSlot> Slots
		{
			get
			{
				return this.slots_;
			}
		}

		// Token: 0x17005F83 RID: 24451
		// (get) Token: 0x0601C37F RID: 115583 RVA: 0x00418711 File Offset: 0x00416911
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<TrapDefenseAuxiliaryInfo> Auxiliaries
		{
			get
			{
				return this.auxiliaries_;
			}
		}

		// Token: 0x17005F84 RID: 24452
		// (get) Token: 0x0601C380 RID: 115584 RVA: 0x00418719 File Offset: 0x00416919
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<TrapDefenseBuildingInfo> Buildings
		{
			get
			{
				return this.buildings_;
			}
		}

		// Token: 0x17005F85 RID: 24453
		// (get) Token: 0x0601C381 RID: 115585 RVA: 0x00418721 File Offset: 0x00416921
		// (set) Token: 0x0601C382 RID: 115586 RVA: 0x00418729 File Offset: 0x00416929
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

		// Token: 0x17005F86 RID: 24454
		// (get) Token: 0x0601C383 RID: 115587 RVA: 0x00418732 File Offset: 0x00416932
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<TrapDefenseItemPbData> ItemDatas
		{
			get
			{
				return this.itemDatas_;
			}
		}

		// Token: 0x17005F87 RID: 24455
		// (get) Token: 0x0601C384 RID: 115588 RVA: 0x0041873A File Offset: 0x0041693A
		// (set) Token: 0x0601C385 RID: 115589 RVA: 0x00418752 File Offset: 0x00416952
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

		// Token: 0x17005F88 RID: 24456
		// (get) Token: 0x0601C386 RID: 115590 RVA: 0x00418769 File Offset: 0x00416969
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasChangedMiniMap
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x0601C387 RID: 115591 RVA: 0x00418776 File Offset: 0x00416976
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearChangedMiniMap()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x0601C388 RID: 115592 RVA: 0x00418787 File Offset: 0x00416987
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TrapDefenseSystemInfoNotify);
		}

		// Token: 0x0601C389 RID: 115593 RVA: 0x00418798 File Offset: 0x00416998
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TrapDefenseSystemInfoNotify other)
		{
			return other != null && (other == this || (this.VariableKeyNames.Equals(other.VariableKeyNames) && this.slots_.Equals(other.slots_) && this.auxiliaries_.Equals(other.auxiliaries_) && this.buildings_.Equals(other.buildings_) && object.Equals(this.TechParams, other.TechParams) && this.itemDatas_.Equals(other.itemDatas_) && this.ChangedMiniMap == other.ChangedMiniMap && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601C38A RID: 115594 RVA: 0x00418850 File Offset: 0x00416A50
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

		// Token: 0x0601C38B RID: 115595 RVA: 0x004188EB File Offset: 0x00416AEB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601C38C RID: 115596 RVA: 0x004188F8 File Offset: 0x00416AF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601C38D RID: 115597 RVA: 0x00418904 File Offset: 0x00416B04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.techParams_ != null)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.TechParams);
			}
			this.buildings_.WriteTo(ref output, TrapDefenseSystemInfoNotify._repeated_buildings_codec);
			this.slots_.WriteTo(ref output, TrapDefenseSystemInfoNotify._repeated_slots_codec);
			this.variableKeyNames_.WriteTo(ref output, TrapDefenseSystemInfoNotify._map_variableKeyNames_codec);
			this.auxiliaries_.WriteTo(ref output, TrapDefenseSystemInfoNotify._repeated_auxiliaries_codec);
			this.itemDatas_.WriteTo(ref output, TrapDefenseSystemInfoNotify._repeated_itemDatas_codec);
			if (this.HasChangedMiniMap)
			{
				output.WriteRawTag(120);
				output.WriteInt32(this.ChangedMiniMap);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601C38E RID: 115598 RVA: 0x004189B4 File Offset: 0x00416BB4
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

		// Token: 0x0601C38F RID: 115599 RVA: 0x00418A6C File Offset: 0x00416C6C
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

		// Token: 0x0601C390 RID: 115600 RVA: 0x00418B29 File Offset: 0x00416D29
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601C391 RID: 115601 RVA: 0x00418B34 File Offset: 0x00416D34
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
					if (num == 18U)
					{
						if (this.techParams_ == null)
						{
							this.TechParams = new TrapDefenseTechParam();
						}
						input.ReadMessage(this.TechParams);
						continue;
					}
					if (num == 26U)
					{
						this.buildings_.AddEntriesFrom(ref input, TrapDefenseSystemInfoNotify._repeated_buildings_codec);
						continue;
					}
					if (num == 34U)
					{
						this.slots_.AddEntriesFrom(ref input, TrapDefenseSystemInfoNotify._repeated_slots_codec);
						continue;
					}
				}
				else if (num <= 66U)
				{
					if (num == 58U)
					{
						this.variableKeyNames_.AddEntriesFrom(ref input, TrapDefenseSystemInfoNotify._map_variableKeyNames_codec);
						continue;
					}
					if (num == 66U)
					{
						this.auxiliaries_.AddEntriesFrom(ref input, TrapDefenseSystemInfoNotify._repeated_auxiliaries_codec);
						continue;
					}
				}
				else
				{
					if (num == 74U)
					{
						this.itemDatas_.AddEntriesFrom(ref input, TrapDefenseSystemInfoNotify._repeated_itemDatas_codec);
						continue;
					}
					if (num == 120U)
					{
						this.ChangedMiniMap = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400A31F RID: 41759
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A320 RID: 41760
		private int _hasBits0;

		// Token: 0x0400A321 RID: 41761
		public const int VariableKeyNamesFieldNumber = 7;

		// Token: 0x0400A322 RID: 41762
		private static readonly MapField<string, string>.Codec _map_variableKeyNames_codec = new MapField<string, string>.Codec(FieldCodec.ForString(10U, ""), FieldCodec.ForString(18U, ""), 58U);

		// Token: 0x0400A323 RID: 41763
		private readonly MapField<string, string> variableKeyNames_ = new MapField<string, string>();

		// Token: 0x0400A324 RID: 41764
		public const int SlotsFieldNumber = 4;

		// Token: 0x0400A325 RID: 41765
		private static readonly FieldCodec<TrapDefenseSlot> _repeated_slots_codec = FieldCodec.ForMessage<TrapDefenseSlot>(34U, TrapDefenseSlot.Parser);

		// Token: 0x0400A326 RID: 41766
		private readonly RepeatedField<TrapDefenseSlot> slots_ = new RepeatedField<TrapDefenseSlot>();

		// Token: 0x0400A327 RID: 41767
		public const int AuxiliariesFieldNumber = 8;

		// Token: 0x0400A328 RID: 41768
		private static readonly FieldCodec<TrapDefenseAuxiliaryInfo> _repeated_auxiliaries_codec = FieldCodec.ForMessage<TrapDefenseAuxiliaryInfo>(66U, TrapDefenseAuxiliaryInfo.Parser);

		// Token: 0x0400A329 RID: 41769
		private readonly RepeatedField<TrapDefenseAuxiliaryInfo> auxiliaries_ = new RepeatedField<TrapDefenseAuxiliaryInfo>();

		// Token: 0x0400A32A RID: 41770
		public const int BuildingsFieldNumber = 3;

		// Token: 0x0400A32B RID: 41771
		private static readonly FieldCodec<TrapDefenseBuildingInfo> _repeated_buildings_codec = FieldCodec.ForMessage<TrapDefenseBuildingInfo>(26U, TrapDefenseBuildingInfo.Parser);

		// Token: 0x0400A32C RID: 41772
		private readonly RepeatedField<TrapDefenseBuildingInfo> buildings_ = new RepeatedField<TrapDefenseBuildingInfo>();

		// Token: 0x0400A32D RID: 41773
		public const int TechParamsFieldNumber = 2;

		// Token: 0x0400A32E RID: 41774
		private TrapDefenseTechParam techParams_;

		// Token: 0x0400A32F RID: 41775
		public const int ItemDatasFieldNumber = 9;

		// Token: 0x0400A330 RID: 41776
		private static readonly FieldCodec<TrapDefenseItemPbData> _repeated_itemDatas_codec = FieldCodec.ForMessage<TrapDefenseItemPbData>(74U, TrapDefenseItemPbData.Parser);

		// Token: 0x0400A331 RID: 41777
		private readonly RepeatedField<TrapDefenseItemPbData> itemDatas_ = new RepeatedField<TrapDefenseItemPbData>();

		// Token: 0x0400A332 RID: 41778
		public const int ChangedMiniMapFieldNumber = 15;

		// Token: 0x0400A333 RID: 41779
		private static readonly int ChangedMiniMapDefaultValue = 0;

		// Token: 0x0400A334 RID: 41780
		private int changedMiniMap_;
	}
}
