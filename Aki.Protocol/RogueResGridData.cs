using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000FE4 RID: 4068
	public sealed class RogueResGridData : IMessage<RogueResGridData>, IMessage, IEquatable<RogueResGridData>, IDeepCloneable<RogueResGridData>, IBufferMessage
	{
		// Token: 0x06015BD3 RID: 89043 RVA: 0x00327D45 File Offset: 0x00325F45
		[NullableContext(1)]
		public static RogueResGridData Create()
		{
			return new RogueResGridData();
		}

		// Token: 0x17004883 RID: 18563
		// (get) Token: 0x06015BD4 RID: 89044 RVA: 0x00327D4C File Offset: 0x00325F4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueResGridData> Parser
		{
			get
			{
				return RogueResGridData._parser;
			}
		}

		// Token: 0x17004884 RID: 18564
		// (get) Token: 0x06015BD5 RID: 89045 RVA: 0x00327D53 File Offset: 0x00325F53
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004885 RID: 18565
		// (get) Token: 0x06015BD6 RID: 89046 RVA: 0x00327D56 File Offset: 0x00325F56
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueResGridData.Descriptor;
			}
		}

		// Token: 0x06015BD7 RID: 89047 RVA: 0x00327D5D File Offset: 0x00325F5D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResGridData()
		{
		}

		// Token: 0x06015BD8 RID: 89048 RVA: 0x00327D7C File Offset: 0x00325F7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResGridData(RogueResGridData other) : this()
		{
			this.configId_ = other.configId_;
			this.isExplore_ = other.isExplore_;
			this.hasVision_ = other.hasVision_;
			this.isBlock_ = other.isBlock_;
			this.pass_ = other.pass_;
			this.mapType_ = other.mapType_;
			this.cost_ = other.cost_;
			this.eventId_ = other.eventId_;
			this.recommondLevel_ = other.recommondLevel_;
			this.captureEffects_ = other.captureEffects_.Clone();
			this.eventCost_ = other.eventCost_;
			this.preAward_ = other.preAward_.Clone();
			this.condInfo_ = ((other.condInfo_ != null) ? other.condInfo_.Clone() : null);
			this.recommondLevelRange_ = other.recommondLevelRange_;
			this.canSkipBattle_ = other.canSkipBattle_;
			this.skipBattleLv_ = other.skipBattleLv_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06015BD9 RID: 89049 RVA: 0x00327E7A File Offset: 0x0032607A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResGridData Clone()
		{
			return new RogueResGridData(this);
		}

		// Token: 0x17004886 RID: 18566
		// (get) Token: 0x06015BDA RID: 89050 RVA: 0x00327E82 File Offset: 0x00326082
		// (set) Token: 0x06015BDB RID: 89051 RVA: 0x00327E8A File Offset: 0x0032608A
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

		// Token: 0x17004887 RID: 18567
		// (get) Token: 0x06015BDC RID: 89052 RVA: 0x00327E93 File Offset: 0x00326093
		// (set) Token: 0x06015BDD RID: 89053 RVA: 0x00327E9B File Offset: 0x0032609B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsExplore
		{
			get
			{
				return this.isExplore_;
			}
			set
			{
				this.isExplore_ = value;
			}
		}

		// Token: 0x17004888 RID: 18568
		// (get) Token: 0x06015BDE RID: 89054 RVA: 0x00327EA4 File Offset: 0x003260A4
		// (set) Token: 0x06015BDF RID: 89055 RVA: 0x00327EAC File Offset: 0x003260AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasVision
		{
			get
			{
				return this.hasVision_;
			}
			set
			{
				this.hasVision_ = value;
			}
		}

		// Token: 0x17004889 RID: 18569
		// (get) Token: 0x06015BE0 RID: 89056 RVA: 0x00327EB5 File Offset: 0x003260B5
		// (set) Token: 0x06015BE1 RID: 89057 RVA: 0x00327EBD File Offset: 0x003260BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsBlock
		{
			get
			{
				return this.isBlock_;
			}
			set
			{
				this.isBlock_ = value;
			}
		}

		// Token: 0x1700488A RID: 18570
		// (get) Token: 0x06015BE2 RID: 89058 RVA: 0x00327EC6 File Offset: 0x003260C6
		// (set) Token: 0x06015BE3 RID: 89059 RVA: 0x00327ECE File Offset: 0x003260CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Pass
		{
			get
			{
				return this.pass_;
			}
			set
			{
				this.pass_ = value;
			}
		}

		// Token: 0x1700488B RID: 18571
		// (get) Token: 0x06015BE4 RID: 89060 RVA: 0x00327ED7 File Offset: 0x003260D7
		// (set) Token: 0x06015BE5 RID: 89061 RVA: 0x00327EDF File Offset: 0x003260DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int MapType
		{
			get
			{
				return this.mapType_;
			}
			set
			{
				this.mapType_ = value;
			}
		}

		// Token: 0x1700488C RID: 18572
		// (get) Token: 0x06015BE6 RID: 89062 RVA: 0x00327EE8 File Offset: 0x003260E8
		// (set) Token: 0x06015BE7 RID: 89063 RVA: 0x00327EF0 File Offset: 0x003260F0
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

		// Token: 0x1700488D RID: 18573
		// (get) Token: 0x06015BE8 RID: 89064 RVA: 0x00327EF9 File Offset: 0x003260F9
		// (set) Token: 0x06015BE9 RID: 89065 RVA: 0x00327F01 File Offset: 0x00326101
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

		// Token: 0x1700488E RID: 18574
		// (get) Token: 0x06015BEA RID: 89066 RVA: 0x00327F0A File Offset: 0x0032610A
		// (set) Token: 0x06015BEB RID: 89067 RVA: 0x00327F12 File Offset: 0x00326112
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RecommondLevel
		{
			get
			{
				return this.recommondLevel_;
			}
			set
			{
				this.recommondLevel_ = value;
			}
		}

		// Token: 0x1700488F RID: 18575
		// (get) Token: 0x06015BEC RID: 89068 RVA: 0x00327F1B File Offset: 0x0032611B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> CaptureEffects
		{
			get
			{
				return this.captureEffects_;
			}
		}

		// Token: 0x17004890 RID: 18576
		// (get) Token: 0x06015BED RID: 89069 RVA: 0x00327F23 File Offset: 0x00326123
		// (set) Token: 0x06015BEE RID: 89070 RVA: 0x00327F2B File Offset: 0x0032612B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int EventCost
		{
			get
			{
				return this.eventCost_;
			}
			set
			{
				this.eventCost_ = value;
			}
		}

		// Token: 0x17004891 RID: 18577
		// (get) Token: 0x06015BEF RID: 89071 RVA: 0x00327F34 File Offset: 0x00326134
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> PreAward
		{
			get
			{
				return this.preAward_;
			}
		}

		// Token: 0x17004892 RID: 18578
		// (get) Token: 0x06015BF0 RID: 89072 RVA: 0x00327F3C File Offset: 0x0032613C
		// (set) Token: 0x06015BF1 RID: 89073 RVA: 0x00327F44 File Offset: 0x00326144
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CondInfo CondInfo
		{
			get
			{
				return this.condInfo_;
			}
			set
			{
				this.condInfo_ = value;
			}
		}

		// Token: 0x17004893 RID: 18579
		// (get) Token: 0x06015BF2 RID: 89074 RVA: 0x00327F4D File Offset: 0x0032614D
		// (set) Token: 0x06015BF3 RID: 89075 RVA: 0x00327F55 File Offset: 0x00326155
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RecommondLevelRange
		{
			get
			{
				return this.recommondLevelRange_;
			}
			set
			{
				this.recommondLevelRange_ = value;
			}
		}

		// Token: 0x17004894 RID: 18580
		// (get) Token: 0x06015BF4 RID: 89076 RVA: 0x00327F5E File Offset: 0x0032615E
		// (set) Token: 0x06015BF5 RID: 89077 RVA: 0x00327F66 File Offset: 0x00326166
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool CanSkipBattle
		{
			get
			{
				return this.canSkipBattle_;
			}
			set
			{
				this.canSkipBattle_ = value;
			}
		}

		// Token: 0x17004895 RID: 18581
		// (get) Token: 0x06015BF6 RID: 89078 RVA: 0x00327F6F File Offset: 0x0032616F
		// (set) Token: 0x06015BF7 RID: 89079 RVA: 0x00327F77 File Offset: 0x00326177
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SkipBattleLv
		{
			get
			{
				return this.skipBattleLv_;
			}
			set
			{
				this.skipBattleLv_ = value;
			}
		}

		// Token: 0x06015BF8 RID: 89080 RVA: 0x00327F80 File Offset: 0x00326180
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueResGridData);
		}

		// Token: 0x06015BF9 RID: 89081 RVA: 0x00327F90 File Offset: 0x00326190
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueResGridData other)
		{
			return other != null && (other == this || (this.ConfigId == other.ConfigId && this.IsExplore == other.IsExplore && this.HasVision == other.HasVision && this.IsBlock == other.IsBlock && this.Pass == other.Pass && this.MapType == other.MapType && this.Cost == other.Cost && this.EventId == other.EventId && this.RecommondLevel == other.RecommondLevel && this.captureEffects_.Equals(other.captureEffects_) && this.EventCost == other.EventCost && this.preAward_.Equals(other.preAward_) && object.Equals(this.CondInfo, other.CondInfo) && this.RecommondLevelRange == other.RecommondLevelRange && this.CanSkipBattle == other.CanSkipBattle && this.SkipBattleLv == other.SkipBattleLv && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06015BFA RID: 89082 RVA: 0x003280C8 File Offset: 0x003262C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ConfigId != 0)
			{
				num ^= this.ConfigId.GetHashCode();
			}
			if (this.IsExplore)
			{
				num ^= this.IsExplore.GetHashCode();
			}
			if (this.HasVision)
			{
				num ^= this.HasVision.GetHashCode();
			}
			if (this.IsBlock)
			{
				num ^= this.IsBlock.GetHashCode();
			}
			if (this.Pass)
			{
				num ^= this.Pass.GetHashCode();
			}
			if (this.MapType != 0)
			{
				num ^= this.MapType.GetHashCode();
			}
			if (this.Cost != 0)
			{
				num ^= this.Cost.GetHashCode();
			}
			if (this.EventId != 0)
			{
				num ^= this.EventId.GetHashCode();
			}
			if (this.RecommondLevel != 0)
			{
				num ^= this.RecommondLevel.GetHashCode();
			}
			num ^= this.captureEffects_.GetHashCode();
			if (this.EventCost != 0)
			{
				num ^= this.EventCost.GetHashCode();
			}
			num ^= this.preAward_.GetHashCode();
			if (this.condInfo_ != null)
			{
				num ^= this.CondInfo.GetHashCode();
			}
			if (this.RecommondLevelRange != 0)
			{
				num ^= this.RecommondLevelRange.GetHashCode();
			}
			if (this.CanSkipBattle)
			{
				num ^= this.CanSkipBattle.GetHashCode();
			}
			if (this.SkipBattleLv != 0)
			{
				num ^= this.SkipBattleLv.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06015BFB RID: 89083 RVA: 0x00328265 File Offset: 0x00326465
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06015BFC RID: 89084 RVA: 0x00328272 File Offset: 0x00326472
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06015BFD RID: 89085 RVA: 0x0032827C File Offset: 0x0032647C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ConfigId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.ConfigId);
			}
			if (this.IsExplore)
			{
				output.WriteRawTag(16);
				output.WriteBool(this.IsExplore);
			}
			if (this.HasVision)
			{
				output.WriteRawTag(24);
				output.WriteBool(this.HasVision);
			}
			if (this.IsBlock)
			{
				output.WriteRawTag(32);
				output.WriteBool(this.IsBlock);
			}
			if (this.MapType != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.MapType);
			}
			if (this.Cost != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.Cost);
			}
			if (this.EventId != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.EventId);
			}
			if (this.RecommondLevel != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.RecommondLevel);
			}
			this.captureEffects_.WriteTo(ref output, RogueResGridData._repeated_captureEffects_codec);
			if (this.EventCost != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.EventCost);
			}
			if (this.Pass)
			{
				output.WriteRawTag(88);
				output.WriteBool(this.Pass);
			}
			this.preAward_.WriteTo(ref output, RogueResGridData._repeated_preAward_codec);
			if (this.condInfo_ != null)
			{
				output.WriteRawTag(106);
				output.WriteMessage(this.CondInfo);
			}
			if (this.RecommondLevelRange != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.RecommondLevelRange);
			}
			if (this.CanSkipBattle)
			{
				output.WriteRawTag(120);
				output.WriteBool(this.CanSkipBattle);
			}
			if (this.SkipBattleLv != 0)
			{
				output.WriteRawTag(128, 1);
				output.WriteInt32(this.SkipBattleLv);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06015BFE RID: 89086 RVA: 0x0032844C File Offset: 0x0032664C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ConfigId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ConfigId);
			}
			if (this.IsExplore)
			{
				num += 2;
			}
			if (this.HasVision)
			{
				num += 2;
			}
			if (this.IsBlock)
			{
				num += 2;
			}
			if (this.Pass)
			{
				num += 2;
			}
			if (this.MapType != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.MapType);
			}
			if (this.Cost != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Cost);
			}
			if (this.EventId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.EventId);
			}
			if (this.RecommondLevel != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RecommondLevel);
			}
			num += this.captureEffects_.CalculateSize(RogueResGridData._repeated_captureEffects_codec);
			if (this.EventCost != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.EventCost);
			}
			num += this.preAward_.CalculateSize(RogueResGridData._repeated_preAward_codec);
			if (this.condInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.CondInfo);
			}
			if (this.RecommondLevelRange != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RecommondLevelRange);
			}
			if (this.CanSkipBattle)
			{
				num += 2;
			}
			if (this.SkipBattleLv != 0)
			{
				num += 2 + CodedOutputStream.ComputeInt32Size(this.SkipBattleLv);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06015BFF RID: 89087 RVA: 0x003285AC File Offset: 0x003267AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueResGridData other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ConfigId != 0)
			{
				this.ConfigId = other.ConfigId;
			}
			if (other.IsExplore)
			{
				this.IsExplore = other.IsExplore;
			}
			if (other.HasVision)
			{
				this.HasVision = other.HasVision;
			}
			if (other.IsBlock)
			{
				this.IsBlock = other.IsBlock;
			}
			if (other.Pass)
			{
				this.Pass = other.Pass;
			}
			if (other.MapType != 0)
			{
				this.MapType = other.MapType;
			}
			if (other.Cost != 0)
			{
				this.Cost = other.Cost;
			}
			if (other.EventId != 0)
			{
				this.EventId = other.EventId;
			}
			if (other.RecommondLevel != 0)
			{
				this.RecommondLevel = other.RecommondLevel;
			}
			this.captureEffects_.Add(other.captureEffects_);
			if (other.EventCost != 0)
			{
				this.EventCost = other.EventCost;
			}
			this.preAward_.Add(other.preAward_);
			if (other.condInfo_ != null)
			{
				if (this.condInfo_ == null)
				{
					this.CondInfo = new CondInfo();
				}
				this.CondInfo.MergeFrom(other.CondInfo);
			}
			if (other.RecommondLevelRange != 0)
			{
				this.RecommondLevelRange = other.RecommondLevelRange;
			}
			if (other.CanSkipBattle)
			{
				this.CanSkipBattle = other.CanSkipBattle;
			}
			if (other.SkipBattleLv != 0)
			{
				this.SkipBattleLv = other.SkipBattleLv;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06015C00 RID: 89088 RVA: 0x00328726 File Offset: 0x00326926
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06015C01 RID: 89089 RVA: 0x00328730 File Offset: 0x00326930
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
				if (num > 72U)
				{
					if (num <= 96U)
					{
						if (num <= 80U)
						{
							if (num == 74U)
							{
								goto IL_174;
							}
							if (num != 80U)
							{
								goto IL_D5;
							}
							this.EventCost = input.ReadInt32();
							continue;
						}
						else
						{
							if (num == 88U)
							{
								this.Pass = input.ReadBool();
								continue;
							}
							if (num != 96U)
							{
								goto IL_D5;
							}
						}
					}
					else if (num <= 106U)
					{
						if (num != 98U)
						{
							if (num != 106U)
							{
								goto IL_D5;
							}
							if (this.condInfo_ == null)
							{
								this.CondInfo = new CondInfo();
							}
							input.ReadMessage(this.CondInfo);
							continue;
						}
					}
					else
					{
						if (num == 112U)
						{
							this.RecommondLevelRange = input.ReadInt32();
							continue;
						}
						if (num == 120U)
						{
							this.CanSkipBattle = input.ReadBool();
							continue;
						}
						if (num != 128U)
						{
							goto IL_D5;
						}
						this.SkipBattleLv = input.ReadInt32();
						continue;
					}
					this.preAward_.AddEntriesFrom(ref input, RogueResGridData._repeated_preAward_codec);
					continue;
				}
				if (num <= 32U)
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
							this.IsExplore = input.ReadBool();
							continue;
						}
					}
					else
					{
						if (num == 24U)
						{
							this.HasVision = input.ReadBool();
							continue;
						}
						if (num == 32U)
						{
							this.IsBlock = input.ReadBool();
							continue;
						}
					}
				}
				else if (num <= 48U)
				{
					if (num == 40U)
					{
						this.MapType = input.ReadInt32();
						continue;
					}
					if (num == 48U)
					{
						this.Cost = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 56U)
					{
						this.EventId = input.ReadInt32();
						continue;
					}
					if (num == 64U)
					{
						this.RecommondLevel = input.ReadInt32();
						continue;
					}
					if (num == 72U)
					{
						goto IL_174;
					}
				}
				IL_D5:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				continue;
				IL_174:
				this.captureEffects_.AddEntriesFrom(ref input, RogueResGridData._repeated_captureEffects_codec);
			}
		}

		// Token: 0x0400826B RID: 33387
		private static readonly MessageParser<RogueResGridData> _parser = new MessageParser<RogueResGridData>(() => new RogueResGridData());

		// Token: 0x0400826C RID: 33388
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400826D RID: 33389
		public const int ConfigIdFieldNumber = 1;

		// Token: 0x0400826E RID: 33390
		private int configId_;

		// Token: 0x0400826F RID: 33391
		public const int IsExploreFieldNumber = 2;

		// Token: 0x04008270 RID: 33392
		private bool isExplore_;

		// Token: 0x04008271 RID: 33393
		public const int HasVisionFieldNumber = 3;

		// Token: 0x04008272 RID: 33394
		private bool hasVision_;

		// Token: 0x04008273 RID: 33395
		public const int IsBlockFieldNumber = 4;

		// Token: 0x04008274 RID: 33396
		private bool isBlock_;

		// Token: 0x04008275 RID: 33397
		public const int PassFieldNumber = 11;

		// Token: 0x04008276 RID: 33398
		private bool pass_;

		// Token: 0x04008277 RID: 33399
		public const int MapTypeFieldNumber = 5;

		// Token: 0x04008278 RID: 33400
		private int mapType_;

		// Token: 0x04008279 RID: 33401
		public const int CostFieldNumber = 6;

		// Token: 0x0400827A RID: 33402
		private int cost_;

		// Token: 0x0400827B RID: 33403
		public const int EventIdFieldNumber = 7;

		// Token: 0x0400827C RID: 33404
		private int eventId_;

		// Token: 0x0400827D RID: 33405
		public const int RecommondLevelFieldNumber = 8;

		// Token: 0x0400827E RID: 33406
		private int recommondLevel_;

		// Token: 0x0400827F RID: 33407
		public const int CaptureEffectsFieldNumber = 9;

		// Token: 0x04008280 RID: 33408
		private static readonly FieldCodec<int> _repeated_captureEffects_codec = FieldCodec.ForInt32(74U);

		// Token: 0x04008281 RID: 33409
		private readonly RepeatedField<int> captureEffects_ = new RepeatedField<int>();

		// Token: 0x04008282 RID: 33410
		public const int EventCostFieldNumber = 10;

		// Token: 0x04008283 RID: 33411
		private int eventCost_;

		// Token: 0x04008284 RID: 33412
		public const int PreAwardFieldNumber = 12;

		// Token: 0x04008285 RID: 33413
		private static readonly FieldCodec<int> _repeated_preAward_codec = FieldCodec.ForInt32(98U);

		// Token: 0x04008286 RID: 33414
		private readonly RepeatedField<int> preAward_ = new RepeatedField<int>();

		// Token: 0x04008287 RID: 33415
		public const int CondInfoFieldNumber = 13;

		// Token: 0x04008288 RID: 33416
		private CondInfo condInfo_;

		// Token: 0x04008289 RID: 33417
		public const int RecommondLevelRangeFieldNumber = 14;

		// Token: 0x0400828A RID: 33418
		private int recommondLevelRange_;

		// Token: 0x0400828B RID: 33419
		public const int CanSkipBattleFieldNumber = 15;

		// Token: 0x0400828C RID: 33420
		private bool canSkipBattle_;

		// Token: 0x0400828D RID: 33421
		public const int SkipBattleLvFieldNumber = 16;

		// Token: 0x0400828E RID: 33422
		private int skipBattleLv_;
	}
}
