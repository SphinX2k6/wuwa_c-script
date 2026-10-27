using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F92 RID: 3986
	public sealed class RoguelikeChooseData : IMessage<RoguelikeChooseData>, IMessage, IEquatable<RoguelikeChooseData>, IDeepCloneable<RoguelikeChooseData>, IBufferMessage
	{
		// Token: 0x0601550E RID: 87310 RVA: 0x00317B65 File Offset: 0x00315D65
		[NullableContext(1)]
		public static RoguelikeChooseData Create()
		{
			return new RoguelikeChooseData();
		}

		// Token: 0x17004703 RID: 18179
		// (get) Token: 0x0601550F RID: 87311 RVA: 0x00317B6C File Offset: 0x00315D6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RoguelikeChooseData> Parser
		{
			get
			{
				return RoguelikeChooseData._parser;
			}
		}

		// Token: 0x17004704 RID: 18180
		// (get) Token: 0x06015510 RID: 87312 RVA: 0x00317B73 File Offset: 0x00315D73
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004705 RID: 18181
		// (get) Token: 0x06015511 RID: 87313 RVA: 0x00317B76 File Offset: 0x00315D76
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoguelikeChooseData.Descriptor;
			}
		}

		// Token: 0x06015512 RID: 87314 RVA: 0x00317B7D File Offset: 0x00315D7D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeChooseData()
		{
		}

		// Token: 0x06015513 RID: 87315 RVA: 0x00317B9C File Offset: 0x00315D9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeChooseData(RoguelikeChooseData other) : this()
		{
			this.index_ = other.index_;
			this.type_ = other.type_;
			this.maxTime_ = other.maxTime_;
			this.useTime_ = other.useTime_;
			this.eventId_ = other.eventId_;
			this.rogueGainEntryList_ = other.rogueGainEntryList_.Clone();
			this.layer_ = other.layer_;
			this.isSelect_ = other.isSelect_;
			this.numItems_ = other.numItems_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06015514 RID: 87316 RVA: 0x00317C36 File Offset: 0x00315E36
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeChooseData Clone()
		{
			return new RoguelikeChooseData(this);
		}

		// Token: 0x17004706 RID: 18182
		// (get) Token: 0x06015515 RID: 87317 RVA: 0x00317C3E File Offset: 0x00315E3E
		// (set) Token: 0x06015516 RID: 87318 RVA: 0x00317C46 File Offset: 0x00315E46
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

		// Token: 0x17004707 RID: 18183
		// (get) Token: 0x06015517 RID: 87319 RVA: 0x00317C4F File Offset: 0x00315E4F
		// (set) Token: 0x06015518 RID: 87320 RVA: 0x00317C57 File Offset: 0x00315E57
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

		// Token: 0x17004708 RID: 18184
		// (get) Token: 0x06015519 RID: 87321 RVA: 0x00317C60 File Offset: 0x00315E60
		// (set) Token: 0x0601551A RID: 87322 RVA: 0x00317C68 File Offset: 0x00315E68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int MaxTime
		{
			get
			{
				return this.maxTime_;
			}
			set
			{
				this.maxTime_ = value;
			}
		}

		// Token: 0x17004709 RID: 18185
		// (get) Token: 0x0601551B RID: 87323 RVA: 0x00317C71 File Offset: 0x00315E71
		// (set) Token: 0x0601551C RID: 87324 RVA: 0x00317C79 File Offset: 0x00315E79
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int UseTime
		{
			get
			{
				return this.useTime_;
			}
			set
			{
				this.useTime_ = value;
			}
		}

		// Token: 0x1700470A RID: 18186
		// (get) Token: 0x0601551D RID: 87325 RVA: 0x00317C82 File Offset: 0x00315E82
		// (set) Token: 0x0601551E RID: 87326 RVA: 0x00317C8A File Offset: 0x00315E8A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int EventId
		{
			get
			{
				return this.eventId_;
			}
			set
			{
				this.eventId_ = value;
			}
		}

		// Token: 0x1700470B RID: 18187
		// (get) Token: 0x0601551F RID: 87327 RVA: 0x00317C93 File Offset: 0x00315E93
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RogueGainEntry> RogueGainEntryList
		{
			get
			{
				return this.rogueGainEntryList_;
			}
		}

		// Token: 0x1700470C RID: 18188
		// (get) Token: 0x06015520 RID: 87328 RVA: 0x00317C9B File Offset: 0x00315E9B
		// (set) Token: 0x06015521 RID: 87329 RVA: 0x00317CA3 File Offset: 0x00315EA3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Layer
		{
			get
			{
				return this.layer_;
			}
			set
			{
				this.layer_ = value;
			}
		}

		// Token: 0x1700470D RID: 18189
		// (get) Token: 0x06015522 RID: 87330 RVA: 0x00317CAC File Offset: 0x00315EAC
		// (set) Token: 0x06015523 RID: 87331 RVA: 0x00317CB4 File Offset: 0x00315EB4
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

		// Token: 0x1700470E RID: 18190
		// (get) Token: 0x06015524 RID: 87332 RVA: 0x00317CBD File Offset: 0x00315EBD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<NumItem> NumItems
		{
			get
			{
				return this.numItems_;
			}
		}

		// Token: 0x06015525 RID: 87333 RVA: 0x00317CC5 File Offset: 0x00315EC5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoguelikeChooseData);
		}

		// Token: 0x06015526 RID: 87334 RVA: 0x00317CD4 File Offset: 0x00315ED4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoguelikeChooseData other)
		{
			return other != null && (other == this || (this.Index == other.Index && this.Type == other.Type && this.MaxTime == other.MaxTime && this.UseTime == other.UseTime && this.EventId == other.EventId && this.rogueGainEntryList_.Equals(other.rogueGainEntryList_) && this.Layer == other.Layer && this.IsSelect == other.IsSelect && this.numItems_.Equals(other.numItems_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06015527 RID: 87335 RVA: 0x00317D98 File Offset: 0x00315F98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Index != 0)
			{
				num ^= this.Index.GetHashCode();
			}
			if (this.Type != RoguelikeGainDataType.Unkonw)
			{
				num ^= this.Type.GetHashCode();
			}
			if (this.MaxTime != 0)
			{
				num ^= this.MaxTime.GetHashCode();
			}
			if (this.UseTime != 0)
			{
				num ^= this.UseTime.GetHashCode();
			}
			if (this.EventId != 0)
			{
				num ^= this.EventId.GetHashCode();
			}
			num ^= this.rogueGainEntryList_.GetHashCode();
			if (this.Layer != 0)
			{
				num ^= this.Layer.GetHashCode();
			}
			if (this.IsSelect)
			{
				num ^= this.IsSelect.GetHashCode();
			}
			num ^= this.numItems_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06015528 RID: 87336 RVA: 0x00317E8F File Offset: 0x0031608F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06015529 RID: 87337 RVA: 0x00317E9C File Offset: 0x0031609C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601552A RID: 87338 RVA: 0x00317EA8 File Offset: 0x003160A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Index != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Index);
			}
			if (this.Type != RoguelikeGainDataType.Unkonw)
			{
				output.WriteRawTag(16);
				output.WriteEnum((int)this.Type);
			}
			if (this.MaxTime != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.MaxTime);
			}
			if (this.UseTime != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.UseTime);
			}
			if (this.EventId != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.EventId);
			}
			this.rogueGainEntryList_.WriteTo(ref output, RoguelikeChooseData._repeated_rogueGainEntryList_codec);
			if (this.Layer != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.Layer);
			}
			if (this.IsSelect)
			{
				output.WriteRawTag(64);
				output.WriteBool(this.IsSelect);
			}
			this.numItems_.WriteTo(ref output, RoguelikeChooseData._repeated_numItems_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601552B RID: 87339 RVA: 0x00317FB0 File Offset: 0x003161B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Index != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Index);
			}
			if (this.Type != RoguelikeGainDataType.Unkonw)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Type);
			}
			if (this.MaxTime != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.MaxTime);
			}
			if (this.UseTime != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.UseTime);
			}
			if (this.EventId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.EventId);
			}
			num += this.rogueGainEntryList_.CalculateSize(RoguelikeChooseData._repeated_rogueGainEntryList_codec);
			if (this.Layer != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Layer);
			}
			if (this.IsSelect)
			{
				num += 2;
			}
			num += this.numItems_.CalculateSize(RoguelikeChooseData._repeated_numItems_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601552C RID: 87340 RVA: 0x00318098 File Offset: 0x00316298
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoguelikeChooseData other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Index != 0)
			{
				this.Index = other.Index;
			}
			if (other.Type != RoguelikeGainDataType.Unkonw)
			{
				this.Type = other.Type;
			}
			if (other.MaxTime != 0)
			{
				this.MaxTime = other.MaxTime;
			}
			if (other.UseTime != 0)
			{
				this.UseTime = other.UseTime;
			}
			if (other.EventId != 0)
			{
				this.EventId = other.EventId;
			}
			this.rogueGainEntryList_.Add(other.rogueGainEntryList_);
			if (other.Layer != 0)
			{
				this.Layer = other.Layer;
			}
			if (other.IsSelect)
			{
				this.IsSelect = other.IsSelect;
			}
			this.numItems_.Add(other.numItems_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601552D RID: 87341 RVA: 0x0031816E File Offset: 0x0031636E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601552E RID: 87342 RVA: 0x00318178 File Offset: 0x00316378
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
							this.Index = input.ReadInt32();
							continue;
						}
						if (num == 16U)
						{
							this.Type = (RoguelikeGainDataType)input.ReadEnum();
							continue;
						}
					}
					else
					{
						if (num == 24U)
						{
							this.MaxTime = input.ReadInt32();
							continue;
						}
						if (num == 32U)
						{
							this.UseTime = input.ReadInt32();
							continue;
						}
					}
				}
				else if (num <= 50U)
				{
					if (num == 40U)
					{
						this.EventId = input.ReadInt32();
						continue;
					}
					if (num == 50U)
					{
						this.rogueGainEntryList_.AddEntriesFrom(ref input, RoguelikeChooseData._repeated_rogueGainEntryList_codec);
						continue;
					}
				}
				else
				{
					if (num == 56U)
					{
						this.Layer = input.ReadInt32();
						continue;
					}
					if (num == 64U)
					{
						this.IsSelect = input.ReadBool();
						continue;
					}
					if (num == 74U)
					{
						this.numItems_.AddEntriesFrom(ref input, RoguelikeChooseData._repeated_numItems_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400803A RID: 32826
		private static readonly MessageParser<RoguelikeChooseData> _parser = new MessageParser<RoguelikeChooseData>(() => new RoguelikeChooseData());

		// Token: 0x0400803B RID: 32827
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400803C RID: 32828
		public const int IndexFieldNumber = 1;

		// Token: 0x0400803D RID: 32829
		private int index_;

		// Token: 0x0400803E RID: 32830
		public const int TypeFieldNumber = 2;

		// Token: 0x0400803F RID: 32831
		private RoguelikeGainDataType type_;

		// Token: 0x04008040 RID: 32832
		public const int MaxTimeFieldNumber = 3;

		// Token: 0x04008041 RID: 32833
		private int maxTime_;

		// Token: 0x04008042 RID: 32834
		public const int UseTimeFieldNumber = 4;

		// Token: 0x04008043 RID: 32835
		private int useTime_;

		// Token: 0x04008044 RID: 32836
		public const int EventIdFieldNumber = 5;

		// Token: 0x04008045 RID: 32837
		private int eventId_;

		// Token: 0x04008046 RID: 32838
		public const int RogueGainEntryListFieldNumber = 6;

		// Token: 0x04008047 RID: 32839
		private static readonly FieldCodec<RogueGainEntry> _repeated_rogueGainEntryList_codec = FieldCodec.ForMessage<RogueGainEntry>(50U, RogueGainEntry.Parser);

		// Token: 0x04008048 RID: 32840
		private readonly RepeatedField<RogueGainEntry> rogueGainEntryList_ = new RepeatedField<RogueGainEntry>();

		// Token: 0x04008049 RID: 32841
		public const int LayerFieldNumber = 7;

		// Token: 0x0400804A RID: 32842
		private int layer_;

		// Token: 0x0400804B RID: 32843
		public const int IsSelectFieldNumber = 8;

		// Token: 0x0400804C RID: 32844
		private bool isSelect_;

		// Token: 0x0400804D RID: 32845
		public const int NumItemsFieldNumber = 9;

		// Token: 0x0400804E RID: 32846
		private static readonly FieldCodec<NumItem> _repeated_numItems_codec = FieldCodec.ForMessage<NumItem>(74U, NumItem.Parser);

		// Token: 0x0400804F RID: 32847
		private readonly RepeatedField<NumItem> numItems_ = new RepeatedField<NumItem>();
	}
}
