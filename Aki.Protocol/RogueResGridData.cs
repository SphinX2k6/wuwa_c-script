using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000FD4 RID: 4052
	public sealed class RogueResGridData : IMessage<RogueResGridData>, IMessage, IEquatable<RogueResGridData>, IDeepCloneable<RogueResGridData>, IBufferMessage
	{
		// Token: 0x06015AEE RID: 88814 RVA: 0x00326691 File Offset: 0x00324891
		[NullableContext(1)]
		public static RogueResGridData Create()
		{
			return new RogueResGridData();
		}

		// Token: 0x17004859 RID: 18521
		// (get) Token: 0x06015AEF RID: 88815 RVA: 0x00326698 File Offset: 0x00324898
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueResGridData> Parser
		{
			get
			{
				return RogueResGridData._parser;
			}
		}

		// Token: 0x1700485A RID: 18522
		// (get) Token: 0x06015AF0 RID: 88816 RVA: 0x0032669F File Offset: 0x0032489F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700485B RID: 18523
		// (get) Token: 0x06015AF1 RID: 88817 RVA: 0x003266A2 File Offset: 0x003248A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueResGridData.Descriptor;
			}
		}

		// Token: 0x06015AF2 RID: 88818 RVA: 0x003266A9 File Offset: 0x003248A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResGridData()
		{
		}

		// Token: 0x06015AF3 RID: 88819 RVA: 0x003266C8 File Offset: 0x003248C8
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

		// Token: 0x06015AF4 RID: 88820 RVA: 0x003267C6 File Offset: 0x003249C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResGridData Clone()
		{
			return new RogueResGridData(this);
		}

		// Token: 0x1700485C RID: 18524
		// (get) Token: 0x06015AF5 RID: 88821 RVA: 0x003267CE File Offset: 0x003249CE
		// (set) Token: 0x06015AF6 RID: 88822 RVA: 0x003267D6 File Offset: 0x003249D6
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

		// Token: 0x1700485D RID: 18525
		// (get) Token: 0x06015AF7 RID: 88823 RVA: 0x003267DF File Offset: 0x003249DF
		// (set) Token: 0x06015AF8 RID: 88824 RVA: 0x003267E7 File Offset: 0x003249E7
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

		// Token: 0x1700485E RID: 18526
		// (get) Token: 0x06015AF9 RID: 88825 RVA: 0x003267F0 File Offset: 0x003249F0
		// (set) Token: 0x06015AFA RID: 88826 RVA: 0x003267F8 File Offset: 0x003249F8
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

		// Token: 0x1700485F RID: 18527
		// (get) Token: 0x06015AFB RID: 88827 RVA: 0x00326801 File Offset: 0x00324A01
		// (set) Token: 0x06015AFC RID: 88828 RVA: 0x00326809 File Offset: 0x00324A09
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

		// Token: 0x17004860 RID: 18528
		// (get) Token: 0x06015AFD RID: 88829 RVA: 0x00326812 File Offset: 0x00324A12
		// (set) Token: 0x06015AFE RID: 88830 RVA: 0x0032681A File Offset: 0x00324A1A
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

		// Token: 0x17004861 RID: 18529
		// (get) Token: 0x06015AFF RID: 88831 RVA: 0x00326823 File Offset: 0x00324A23
		// (set) Token: 0x06015B00 RID: 88832 RVA: 0x0032682B File Offset: 0x00324A2B
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

		// Token: 0x17004862 RID: 18530
		// (get) Token: 0x06015B01 RID: 88833 RVA: 0x00326834 File Offset: 0x00324A34
		// (set) Token: 0x06015B02 RID: 88834 RVA: 0x0032683C File Offset: 0x00324A3C
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

		// Token: 0x17004863 RID: 18531
		// (get) Token: 0x06015B03 RID: 88835 RVA: 0x00326845 File Offset: 0x00324A45
		// (set) Token: 0x06015B04 RID: 88836 RVA: 0x0032684D File Offset: 0x00324A4D
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

		// Token: 0x17004864 RID: 18532
		// (get) Token: 0x06015B05 RID: 88837 RVA: 0x00326856 File Offset: 0x00324A56
		// (set) Token: 0x06015B06 RID: 88838 RVA: 0x0032685E File Offset: 0x00324A5E
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

		// Token: 0x17004865 RID: 18533
		// (get) Token: 0x06015B07 RID: 88839 RVA: 0x00326867 File Offset: 0x00324A67
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> CaptureEffects
		{
			get
			{
				return this.captureEffects_;
			}
		}

		// Token: 0x17004866 RID: 18534
		// (get) Token: 0x06015B08 RID: 88840 RVA: 0x0032686F File Offset: 0x00324A6F
		// (set) Token: 0x06015B09 RID: 88841 RVA: 0x00326877 File Offset: 0x00324A77
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

		// Token: 0x17004867 RID: 18535
		// (get) Token: 0x06015B0A RID: 88842 RVA: 0x00326880 File Offset: 0x00324A80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> PreAward
		{
			get
			{
				return this.preAward_;
			}
		}

		// Token: 0x17004868 RID: 18536
		// (get) Token: 0x06015B0B RID: 88843 RVA: 0x00326888 File Offset: 0x00324A88
		// (set) Token: 0x06015B0C RID: 88844 RVA: 0x00326890 File Offset: 0x00324A90
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

		// Token: 0x17004869 RID: 18537
		// (get) Token: 0x06015B0D RID: 88845 RVA: 0x00326899 File Offset: 0x00324A99
		// (set) Token: 0x06015B0E RID: 88846 RVA: 0x003268A1 File Offset: 0x00324AA1
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

		// Token: 0x1700486A RID: 18538
		// (get) Token: 0x06015B0F RID: 88847 RVA: 0x003268AA File Offset: 0x00324AAA
		// (set) Token: 0x06015B10 RID: 88848 RVA: 0x003268B2 File Offset: 0x00324AB2
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

		// Token: 0x1700486B RID: 18539
		// (get) Token: 0x06015B11 RID: 88849 RVA: 0x003268BB File Offset: 0x00324ABB
		// (set) Token: 0x06015B12 RID: 88850 RVA: 0x003268C3 File Offset: 0x00324AC3
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

		// Token: 0x06015B13 RID: 88851 RVA: 0x003268CC File Offset: 0x00324ACC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueResGridData);
		}

		// Token: 0x06015B14 RID: 88852 RVA: 0x003268DC File Offset: 0x00324ADC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueResGridData other)
		{
			return other != null && (other == this || (this.ConfigId == other.ConfigId && this.IsExplore == other.IsExplore && this.HasVision == other.HasVision && this.IsBlock == other.IsBlock && this.Pass == other.Pass && this.MapType == other.MapType && this.Cost == other.Cost && this.EventId == other.EventId && this.RecommondLevel == other.RecommondLevel && this.captureEffects_.Equals(other.captureEffects_) && this.EventCost == other.EventCost && this.preAward_.Equals(other.preAward_) && object.Equals(this.CondInfo, other.CondInfo) && this.RecommondLevelRange == other.RecommondLevelRange && this.CanSkipBattle == other.CanSkipBattle && this.SkipBattleLv == other.SkipBattleLv && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06015B15 RID: 88853 RVA: 0x00326A14 File Offset: 0x00324C14
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

		// Token: 0x06015B16 RID: 88854 RVA: 0x00326BB1 File Offset: 0x00324DB1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06015B17 RID: 88855 RVA: 0x00326BBE File Offset: 0x00324DBE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06015B18 RID: 88856 RVA: 0x00326BC8 File Offset: 0x00324DC8
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

		// Token: 0x06015B19 RID: 88857 RVA: 0x00326D98 File Offset: 0x00324F98
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

		// Token: 0x06015B1A RID: 88858 RVA: 0x00326EF8 File Offset: 0x003250F8
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

		// Token: 0x06015B1B RID: 88859 RVA: 0x00327072 File Offset: 0x00325272
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06015B1C RID: 88860 RVA: 0x0032707C File Offset: 0x0032527C
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

		// Token: 0x04008295 RID: 33429
		private static readonly MessageParser<RogueResGridData> _parser = new MessageParser<RogueResGridData>(() => new RogueResGridData());

		// Token: 0x04008296 RID: 33430
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008297 RID: 33431
		public const int ConfigIdFieldNumber = 1;

		// Token: 0x04008298 RID: 33432
		private int configId_;

		// Token: 0x04008299 RID: 33433
		public const int IsExploreFieldNumber = 2;

		// Token: 0x0400829A RID: 33434
		private bool isExplore_;

		// Token: 0x0400829B RID: 33435
		public const int HasVisionFieldNumber = 3;

		// Token: 0x0400829C RID: 33436
		private bool hasVision_;

		// Token: 0x0400829D RID: 33437
		public const int IsBlockFieldNumber = 4;

		// Token: 0x0400829E RID: 33438
		private bool isBlock_;

		// Token: 0x0400829F RID: 33439
		public const int PassFieldNumber = 11;

		// Token: 0x040082A0 RID: 33440
		private bool pass_;

		// Token: 0x040082A1 RID: 33441
		public const int MapTypeFieldNumber = 5;

		// Token: 0x040082A2 RID: 33442
		private int mapType_;

		// Token: 0x040082A3 RID: 33443
		public const int CostFieldNumber = 6;

		// Token: 0x040082A4 RID: 33444
		private int cost_;

		// Token: 0x040082A5 RID: 33445
		public const int EventIdFieldNumber = 7;

		// Token: 0x040082A6 RID: 33446
		private int eventId_;

		// Token: 0x040082A7 RID: 33447
		public const int RecommondLevelFieldNumber = 8;

		// Token: 0x040082A8 RID: 33448
		private int recommondLevel_;

		// Token: 0x040082A9 RID: 33449
		public const int CaptureEffectsFieldNumber = 9;

		// Token: 0x040082AA RID: 33450
		private static readonly FieldCodec<int> _repeated_captureEffects_codec = FieldCodec.ForInt32(74U);

		// Token: 0x040082AB RID: 33451
		private readonly RepeatedField<int> captureEffects_ = new RepeatedField<int>();

		// Token: 0x040082AC RID: 33452
		public const int EventCostFieldNumber = 10;

		// Token: 0x040082AD RID: 33453
		private int eventCost_;

		// Token: 0x040082AE RID: 33454
		public const int PreAwardFieldNumber = 12;

		// Token: 0x040082AF RID: 33455
		private static readonly FieldCodec<int> _repeated_preAward_codec = FieldCodec.ForInt32(98U);

		// Token: 0x040082B0 RID: 33456
		private readonly RepeatedField<int> preAward_ = new RepeatedField<int>();

		// Token: 0x040082B1 RID: 33457
		public const int CondInfoFieldNumber = 13;

		// Token: 0x040082B2 RID: 33458
		private CondInfo condInfo_;

		// Token: 0x040082B3 RID: 33459
		public const int RecommondLevelRangeFieldNumber = 14;

		// Token: 0x040082B4 RID: 33460
		private int recommondLevelRange_;

		// Token: 0x040082B5 RID: 33461
		public const int CanSkipBattleFieldNumber = 15;

		// Token: 0x040082B6 RID: 33462
		private bool canSkipBattle_;

		// Token: 0x040082B7 RID: 33463
		public const int SkipBattleLvFieldNumber = 16;

		// Token: 0x040082B8 RID: 33464
		private int skipBattleLv_;
	}
}
