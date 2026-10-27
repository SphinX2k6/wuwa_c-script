using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001005 RID: 4101
	public sealed class RogueResSeasonData : IMessage<RogueResSeasonData>, IMessage, IEquatable<RogueResSeasonData>, IDeepCloneable<RogueResSeasonData>, IBufferMessage
	{
		// Token: 0x06015ED9 RID: 89817 RVA: 0x0032FFE7 File Offset: 0x0032E1E7
		[NullableContext(1)]
		public static RogueResSeasonData Create()
		{
			return new RogueResSeasonData();
		}

		// Token: 0x17004944 RID: 18756
		// (get) Token: 0x06015EDA RID: 89818 RVA: 0x0032FFEE File Offset: 0x0032E1EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueResSeasonData> Parser
		{
			get
			{
				return RogueResSeasonData._parser;
			}
		}

		// Token: 0x17004945 RID: 18757
		// (get) Token: 0x06015EDB RID: 89819 RVA: 0x0032FFF5 File Offset: 0x0032E1F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004946 RID: 18758
		// (get) Token: 0x06015EDC RID: 89820 RVA: 0x0032FFF8 File Offset: 0x0032E1F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueResSeasonData.Descriptor;
			}
		}

		// Token: 0x06015EDD RID: 89821 RVA: 0x0032FFFF File Offset: 0x0032E1FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResSeasonData()
		{
		}

		// Token: 0x06015EDE RID: 89822 RVA: 0x00330040 File Offset: 0x0032E240
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResSeasonData(RogueResSeasonData other) : this()
		{
			this.seasonId_ = other.seasonId_;
			this.talentSkillDict_ = other.talentSkillDict_.Clone();
			this.endings_ = other.endings_.Clone();
			this.endingRewardIds_ = other.endingRewardIds_.Clone();
			this.staticTrialRoles_ = other.staticTrialRoles_.Clone();
			this.dynamicTrialRoles_ = other.dynamicTrialRoles_.Clone();
			this.endTime_ = other.endTime_;
			this.totalShopItem_ = other.totalShopItem_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06015EDF RID: 89823 RVA: 0x003300DD File Offset: 0x0032E2DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResSeasonData Clone()
		{
			return new RogueResSeasonData(this);
		}

		// Token: 0x17004947 RID: 18759
		// (get) Token: 0x06015EE0 RID: 89824 RVA: 0x003300E5 File Offset: 0x0032E2E5
		// (set) Token: 0x06015EE1 RID: 89825 RVA: 0x003300ED File Offset: 0x0032E2ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SeasonId
		{
			get
			{
				return this.seasonId_;
			}
			set
			{
				this.seasonId_ = value;
			}
		}

		// Token: 0x17004948 RID: 18760
		// (get) Token: 0x06015EE2 RID: 89826 RVA: 0x003300F6 File Offset: 0x0032E2F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, int> TalentSkillDict
		{
			get
			{
				return this.talentSkillDict_;
			}
		}

		// Token: 0x17004949 RID: 18761
		// (get) Token: 0x06015EE3 RID: 89827 RVA: 0x003300FE File Offset: 0x0032E2FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> Endings
		{
			get
			{
				return this.endings_;
			}
		}

		// Token: 0x1700494A RID: 18762
		// (get) Token: 0x06015EE4 RID: 89828 RVA: 0x00330106 File Offset: 0x0032E306
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ActivityTask> EndingRewardIds
		{
			get
			{
				return this.endingRewardIds_;
			}
		}

		// Token: 0x1700494B RID: 18763
		// (get) Token: 0x06015EE5 RID: 89829 RVA: 0x0033010E File Offset: 0x0032E30E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> StaticTrialRoles
		{
			get
			{
				return this.staticTrialRoles_;
			}
		}

		// Token: 0x1700494C RID: 18764
		// (get) Token: 0x06015EE6 RID: 89830 RVA: 0x00330116 File Offset: 0x0032E316
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> DynamicTrialRoles
		{
			get
			{
				return this.dynamicTrialRoles_;
			}
		}

		// Token: 0x1700494D RID: 18765
		// (get) Token: 0x06015EE7 RID: 89831 RVA: 0x0033011E File Offset: 0x0032E31E
		// (set) Token: 0x06015EE8 RID: 89832 RVA: 0x00330126 File Offset: 0x0032E326
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long EndTime
		{
			get
			{
				return this.endTime_;
			}
			set
			{
				this.endTime_ = value;
			}
		}

		// Token: 0x1700494E RID: 18766
		// (get) Token: 0x06015EE9 RID: 89833 RVA: 0x0033012F File Offset: 0x0032E32F
		// (set) Token: 0x06015EEA RID: 89834 RVA: 0x00330137 File Offset: 0x0032E337
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TotalShopItem
		{
			get
			{
				return this.totalShopItem_;
			}
			set
			{
				this.totalShopItem_ = value;
			}
		}

		// Token: 0x06015EEB RID: 89835 RVA: 0x00330140 File Offset: 0x0032E340
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueResSeasonData);
		}

		// Token: 0x06015EEC RID: 89836 RVA: 0x00330150 File Offset: 0x0032E350
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueResSeasonData other)
		{
			return other != null && (other == this || (this.SeasonId == other.SeasonId && this.TalentSkillDict.Equals(other.TalentSkillDict) && this.endings_.Equals(other.endings_) && this.endingRewardIds_.Equals(other.endingRewardIds_) && this.staticTrialRoles_.Equals(other.staticTrialRoles_) && this.dynamicTrialRoles_.Equals(other.dynamicTrialRoles_) && this.EndTime == other.EndTime && this.TotalShopItem == other.TotalShopItem && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06015EED RID: 89837 RVA: 0x00330214 File Offset: 0x0032E414
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.SeasonId != 0)
			{
				num ^= this.SeasonId.GetHashCode();
			}
			num ^= this.TalentSkillDict.GetHashCode();
			num ^= this.endings_.GetHashCode();
			num ^= this.endingRewardIds_.GetHashCode();
			num ^= this.staticTrialRoles_.GetHashCode();
			num ^= this.dynamicTrialRoles_.GetHashCode();
			if (this.EndTime != 0L)
			{
				num ^= this.EndTime.GetHashCode();
			}
			if (this.TotalShopItem != 0)
			{
				num ^= this.TotalShopItem.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06015EEE RID: 89838 RVA: 0x003302CB File Offset: 0x0032E4CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06015EEF RID: 89839 RVA: 0x003302D8 File Offset: 0x0032E4D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06015EF0 RID: 89840 RVA: 0x003302E4 File Offset: 0x0032E4E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SeasonId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.SeasonId);
			}
			this.talentSkillDict_.WriteTo(ref output, RogueResSeasonData._map_talentSkillDict_codec);
			this.endings_.WriteTo(ref output, RogueResSeasonData._repeated_endings_codec);
			this.endingRewardIds_.WriteTo(ref output, RogueResSeasonData._repeated_endingRewardIds_codec);
			this.staticTrialRoles_.WriteTo(ref output, RogueResSeasonData._repeated_staticTrialRoles_codec);
			this.dynamicTrialRoles_.WriteTo(ref output, RogueResSeasonData._repeated_dynamicTrialRoles_codec);
			if (this.EndTime != 0L)
			{
				output.WriteRawTag(56);
				output.WriteInt64(this.EndTime);
			}
			if (this.TotalShopItem != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.TotalShopItem);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06015EF1 RID: 89841 RVA: 0x003303B0 File Offset: 0x0032E5B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.SeasonId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SeasonId);
			}
			num += this.talentSkillDict_.CalculateSize(RogueResSeasonData._map_talentSkillDict_codec);
			num += this.endings_.CalculateSize(RogueResSeasonData._repeated_endings_codec);
			num += this.endingRewardIds_.CalculateSize(RogueResSeasonData._repeated_endingRewardIds_codec);
			num += this.staticTrialRoles_.CalculateSize(RogueResSeasonData._repeated_staticTrialRoles_codec);
			num += this.dynamicTrialRoles_.CalculateSize(RogueResSeasonData._repeated_dynamicTrialRoles_codec);
			if (this.EndTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EndTime);
			}
			if (this.TotalShopItem != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TotalShopItem);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06015EF2 RID: 89842 RVA: 0x00330480 File Offset: 0x0032E680
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueResSeasonData other)
		{
			if (other == null)
			{
				return;
			}
			if (other.SeasonId != 0)
			{
				this.SeasonId = other.SeasonId;
			}
			this.talentSkillDict_.MergeFrom(other.talentSkillDict_);
			this.endings_.Add(other.endings_);
			this.endingRewardIds_.Add(other.endingRewardIds_);
			this.staticTrialRoles_.Add(other.staticTrialRoles_);
			this.dynamicTrialRoles_.Add(other.dynamicTrialRoles_);
			if (other.EndTime != 0L)
			{
				this.EndTime = other.EndTime;
			}
			if (other.TotalShopItem != 0)
			{
				this.TotalShopItem = other.TotalShopItem;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06015EF3 RID: 89843 RVA: 0x00330539 File Offset: 0x0032E739
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06015EF4 RID: 89844 RVA: 0x00330544 File Offset: 0x0032E744
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
				if (num > 34U)
				{
					if (num <= 48U)
					{
						if (num == 40U || num == 42U)
						{
							this.staticTrialRoles_.AddEntriesFrom(ref input, RogueResSeasonData._repeated_staticTrialRoles_codec);
							continue;
						}
						if (num != 48U)
						{
							goto IL_6C;
						}
					}
					else if (num != 50U)
					{
						if (num == 56U)
						{
							this.EndTime = input.ReadInt64();
							continue;
						}
						if (num != 64U)
						{
							goto IL_6C;
						}
						this.TotalShopItem = input.ReadInt32();
						continue;
					}
					this.dynamicTrialRoles_.AddEntriesFrom(ref input, RogueResSeasonData._repeated_dynamicTrialRoles_codec);
					continue;
				}
				if (num <= 18U)
				{
					if (num == 8U)
					{
						this.SeasonId = input.ReadInt32();
						continue;
					}
					if (num == 18U)
					{
						this.talentSkillDict_.AddEntriesFrom(ref input, RogueResSeasonData._map_talentSkillDict_codec);
						continue;
					}
				}
				else
				{
					if (num == 24U || num == 26U)
					{
						this.endings_.AddEntriesFrom(ref input, RogueResSeasonData._repeated_endings_codec);
						continue;
					}
					if (num == 34U)
					{
						this.endingRewardIds_.AddEntriesFrom(ref input, RogueResSeasonData._repeated_endingRewardIds_codec);
						continue;
					}
				}
				IL_6C:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400838D RID: 33677
		private static readonly MessageParser<RogueResSeasonData> _parser = new MessageParser<RogueResSeasonData>(() => new RogueResSeasonData());

		// Token: 0x0400838E RID: 33678
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400838F RID: 33679
		public const int SeasonIdFieldNumber = 1;

		// Token: 0x04008390 RID: 33680
		private int seasonId_;

		// Token: 0x04008391 RID: 33681
		public const int TalentSkillDictFieldNumber = 2;

		// Token: 0x04008392 RID: 33682
		private static readonly MapField<int, int>.Codec _map_talentSkillDict_codec = new MapField<int, int>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForInt32(16U, 0), 18U);

		// Token: 0x04008393 RID: 33683
		private readonly MapField<int, int> talentSkillDict_ = new MapField<int, int>();

		// Token: 0x04008394 RID: 33684
		public const int EndingsFieldNumber = 3;

		// Token: 0x04008395 RID: 33685
		private static readonly FieldCodec<int> _repeated_endings_codec = FieldCodec.ForInt32(26U);

		// Token: 0x04008396 RID: 33686
		private readonly RepeatedField<int> endings_ = new RepeatedField<int>();

		// Token: 0x04008397 RID: 33687
		public const int EndingRewardIdsFieldNumber = 4;

		// Token: 0x04008398 RID: 33688
		private static readonly FieldCodec<ActivityTask> _repeated_endingRewardIds_codec = FieldCodec.ForMessage<ActivityTask>(34U, ActivityTask.Parser);

		// Token: 0x04008399 RID: 33689
		private readonly RepeatedField<ActivityTask> endingRewardIds_ = new RepeatedField<ActivityTask>();

		// Token: 0x0400839A RID: 33690
		public const int StaticTrialRolesFieldNumber = 5;

		// Token: 0x0400839B RID: 33691
		private static readonly FieldCodec<int> _repeated_staticTrialRoles_codec = FieldCodec.ForInt32(42U);

		// Token: 0x0400839C RID: 33692
		private readonly RepeatedField<int> staticTrialRoles_ = new RepeatedField<int>();

		// Token: 0x0400839D RID: 33693
		public const int DynamicTrialRolesFieldNumber = 6;

		// Token: 0x0400839E RID: 33694
		private static readonly FieldCodec<int> _repeated_dynamicTrialRoles_codec = FieldCodec.ForInt32(50U);

		// Token: 0x0400839F RID: 33695
		private readonly RepeatedField<int> dynamicTrialRoles_ = new RepeatedField<int>();

		// Token: 0x040083A0 RID: 33696
		public const int EndTimeFieldNumber = 7;

		// Token: 0x040083A1 RID: 33697
		private long endTime_;

		// Token: 0x040083A2 RID: 33698
		public const int TotalShopItemFieldNumber = 8;

		// Token: 0x040083A3 RID: 33699
		private int totalShopItem_;
	}
}
