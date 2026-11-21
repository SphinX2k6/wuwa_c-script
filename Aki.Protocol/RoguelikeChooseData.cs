using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F82 RID: 3970
	public sealed class RoguelikeChooseData : IMessage<RoguelikeChooseData>, IMessage, IEquatable<RoguelikeChooseData>, IDeepCloneable<RoguelikeChooseData>, IBufferMessage
	{
		// Token: 0x06015429 RID: 87081 RVA: 0x003164B1 File Offset: 0x003146B1
		[NullableContext(1)]
		public static RoguelikeChooseData Create()
		{
			return new RoguelikeChooseData();
		}

		// Token: 0x170046D9 RID: 18137
		// (get) Token: 0x0601542A RID: 87082 RVA: 0x003164B8 File Offset: 0x003146B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RoguelikeChooseData> Parser
		{
			get
			{
				return RoguelikeChooseData._parser;
			}
		}

		// Token: 0x170046DA RID: 18138
		// (get) Token: 0x0601542B RID: 87083 RVA: 0x003164BF File Offset: 0x003146BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170046DB RID: 18139
		// (get) Token: 0x0601542C RID: 87084 RVA: 0x003164C2 File Offset: 0x003146C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoguelikeChooseData.Descriptor;
			}
		}

		// Token: 0x0601542D RID: 87085 RVA: 0x003164C9 File Offset: 0x003146C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeChooseData()
		{
		}

		// Token: 0x0601542E RID: 87086 RVA: 0x003164E8 File Offset: 0x003146E8
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

		// Token: 0x0601542F RID: 87087 RVA: 0x00316582 File Offset: 0x00314782
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeChooseData Clone()
		{
			return new RoguelikeChooseData(this);
		}

		// Token: 0x170046DC RID: 18140
		// (get) Token: 0x06015430 RID: 87088 RVA: 0x0031658A File Offset: 0x0031478A
		// (set) Token: 0x06015431 RID: 87089 RVA: 0x00316592 File Offset: 0x00314792
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

		// Token: 0x170046DD RID: 18141
		// (get) Token: 0x06015432 RID: 87090 RVA: 0x0031659B File Offset: 0x0031479B
		// (set) Token: 0x06015433 RID: 87091 RVA: 0x003165A3 File Offset: 0x003147A3
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

		// Token: 0x170046DE RID: 18142
		// (get) Token: 0x06015434 RID: 87092 RVA: 0x003165AC File Offset: 0x003147AC
		// (set) Token: 0x06015435 RID: 87093 RVA: 0x003165B4 File Offset: 0x003147B4
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

		// Token: 0x170046DF RID: 18143
		// (get) Token: 0x06015436 RID: 87094 RVA: 0x003165BD File Offset: 0x003147BD
		// (set) Token: 0x06015437 RID: 87095 RVA: 0x003165C5 File Offset: 0x003147C5
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

		// Token: 0x170046E0 RID: 18144
		// (get) Token: 0x06015438 RID: 87096 RVA: 0x003165CE File Offset: 0x003147CE
		// (set) Token: 0x06015439 RID: 87097 RVA: 0x003165D6 File Offset: 0x003147D6
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

		// Token: 0x170046E1 RID: 18145
		// (get) Token: 0x0601543A RID: 87098 RVA: 0x003165DF File Offset: 0x003147DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RogueGainEntry> RogueGainEntryList
		{
			get
			{
				return this.rogueGainEntryList_;
			}
		}

		// Token: 0x170046E2 RID: 18146
		// (get) Token: 0x0601543B RID: 87099 RVA: 0x003165E7 File Offset: 0x003147E7
		// (set) Token: 0x0601543C RID: 87100 RVA: 0x003165EF File Offset: 0x003147EF
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

		// Token: 0x170046E3 RID: 18147
		// (get) Token: 0x0601543D RID: 87101 RVA: 0x003165F8 File Offset: 0x003147F8
		// (set) Token: 0x0601543E RID: 87102 RVA: 0x00316600 File Offset: 0x00314800
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

		// Token: 0x170046E4 RID: 18148
		// (get) Token: 0x0601543F RID: 87103 RVA: 0x00316609 File Offset: 0x00314809
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<NumItem> NumItems
		{
			get
			{
				return this.numItems_;
			}
		}

		// Token: 0x06015440 RID: 87104 RVA: 0x00316611 File Offset: 0x00314811
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoguelikeChooseData);
		}

		// Token: 0x06015441 RID: 87105 RVA: 0x00316620 File Offset: 0x00314820
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoguelikeChooseData other)
		{
			return other != null && (other == this || (this.Index == other.Index && this.Type == other.Type && this.MaxTime == other.MaxTime && this.UseTime == other.UseTime && this.EventId == other.EventId && this.rogueGainEntryList_.Equals(other.rogueGainEntryList_) && this.Layer == other.Layer && this.IsSelect == other.IsSelect && this.numItems_.Equals(other.numItems_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06015442 RID: 87106 RVA: 0x003166E4 File Offset: 0x003148E4
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

		// Token: 0x06015443 RID: 87107 RVA: 0x003167DB File Offset: 0x003149DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06015444 RID: 87108 RVA: 0x003167E8 File Offset: 0x003149E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06015445 RID: 87109 RVA: 0x003167F4 File Offset: 0x003149F4
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

		// Token: 0x06015446 RID: 87110 RVA: 0x003168FC File Offset: 0x00314AFC
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

		// Token: 0x06015447 RID: 87111 RVA: 0x003169E4 File Offset: 0x00314BE4
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

		// Token: 0x06015448 RID: 87112 RVA: 0x00316ABA File Offset: 0x00314CBA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06015449 RID: 87113 RVA: 0x00316AC4 File Offset: 0x00314CC4
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

		// Token: 0x04008064 RID: 32868
		private static readonly MessageParser<RoguelikeChooseData> _parser = new MessageParser<RoguelikeChooseData>(() => new RoguelikeChooseData());

		// Token: 0x04008065 RID: 32869
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008066 RID: 32870
		public const int IndexFieldNumber = 1;

		// Token: 0x04008067 RID: 32871
		private int index_;

		// Token: 0x04008068 RID: 32872
		public const int TypeFieldNumber = 2;

		// Token: 0x04008069 RID: 32873
		private RoguelikeGainDataType type_;

		// Token: 0x0400806A RID: 32874
		public const int MaxTimeFieldNumber = 3;

		// Token: 0x0400806B RID: 32875
		private int maxTime_;

		// Token: 0x0400806C RID: 32876
		public const int UseTimeFieldNumber = 4;

		// Token: 0x0400806D RID: 32877
		private int useTime_;

		// Token: 0x0400806E RID: 32878
		public const int EventIdFieldNumber = 5;

		// Token: 0x0400806F RID: 32879
		private int eventId_;

		// Token: 0x04008070 RID: 32880
		public const int RogueGainEntryListFieldNumber = 6;

		// Token: 0x04008071 RID: 32881
		private static readonly FieldCodec<RogueGainEntry> _repeated_rogueGainEntryList_codec = FieldCodec.ForMessage<RogueGainEntry>(50U, RogueGainEntry.Parser);

		// Token: 0x04008072 RID: 32882
		private readonly RepeatedField<RogueGainEntry> rogueGainEntryList_ = new RepeatedField<RogueGainEntry>();

		// Token: 0x04008073 RID: 32883
		public const int LayerFieldNumber = 7;

		// Token: 0x04008074 RID: 32884
		private int layer_;

		// Token: 0x04008075 RID: 32885
		public const int IsSelectFieldNumber = 8;

		// Token: 0x04008076 RID: 32886
		private bool isSelect_;

		// Token: 0x04008077 RID: 32887
		public const int NumItemsFieldNumber = 9;

		// Token: 0x04008078 RID: 32888
		private static readonly FieldCodec<NumItem> _repeated_numItems_codec = FieldCodec.ForMessage<NumItem>(74U, NumItem.Parser);

		// Token: 0x04008079 RID: 32889
		private readonly RepeatedField<NumItem> numItems_ = new RepeatedField<NumItem>();
	}
}
