using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000FF5 RID: 4085
	public sealed class RogueResSeasonData : IMessage<RogueResSeasonData>, IMessage, IEquatable<RogueResSeasonData>, IDeepCloneable<RogueResSeasonData>, IBufferMessage
	{
		// Token: 0x06015DF4 RID: 89588 RVA: 0x0032E92B File Offset: 0x0032CB2B
		[NullableContext(1)]
		public static RogueResSeasonData Create()
		{
			return new RogueResSeasonData();
		}

		// Token: 0x1700491A RID: 18714
		// (get) Token: 0x06015DF5 RID: 89589 RVA: 0x0032E932 File Offset: 0x0032CB32
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueResSeasonData> Parser
		{
			get
			{
				return RogueResSeasonData._parser;
			}
		}

		// Token: 0x1700491B RID: 18715
		// (get) Token: 0x06015DF6 RID: 89590 RVA: 0x0032E939 File Offset: 0x0032CB39
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700491C RID: 18716
		// (get) Token: 0x06015DF7 RID: 89591 RVA: 0x0032E93C File Offset: 0x0032CB3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueResSeasonData.Descriptor;
			}
		}

		// Token: 0x06015DF8 RID: 89592 RVA: 0x0032E943 File Offset: 0x0032CB43
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResSeasonData()
		{
		}

		// Token: 0x06015DF9 RID: 89593 RVA: 0x0032E984 File Offset: 0x0032CB84
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

		// Token: 0x06015DFA RID: 89594 RVA: 0x0032EA21 File Offset: 0x0032CC21
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResSeasonData Clone()
		{
			return new RogueResSeasonData(this);
		}

		// Token: 0x1700491D RID: 18717
		// (get) Token: 0x06015DFB RID: 89595 RVA: 0x0032EA29 File Offset: 0x0032CC29
		// (set) Token: 0x06015DFC RID: 89596 RVA: 0x0032EA31 File Offset: 0x0032CC31
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

		// Token: 0x1700491E RID: 18718
		// (get) Token: 0x06015DFD RID: 89597 RVA: 0x0032EA3A File Offset: 0x0032CC3A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, int> TalentSkillDict
		{
			get
			{
				return this.talentSkillDict_;
			}
		}

		// Token: 0x1700491F RID: 18719
		// (get) Token: 0x06015DFE RID: 89598 RVA: 0x0032EA42 File Offset: 0x0032CC42
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> Endings
		{
			get
			{
				return this.endings_;
			}
		}

		// Token: 0x17004920 RID: 18720
		// (get) Token: 0x06015DFF RID: 89599 RVA: 0x0032EA4A File Offset: 0x0032CC4A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ActivityTask> EndingRewardIds
		{
			get
			{
				return this.endingRewardIds_;
			}
		}

		// Token: 0x17004921 RID: 18721
		// (get) Token: 0x06015E00 RID: 89600 RVA: 0x0032EA52 File Offset: 0x0032CC52
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> StaticTrialRoles
		{
			get
			{
				return this.staticTrialRoles_;
			}
		}

		// Token: 0x17004922 RID: 18722
		// (get) Token: 0x06015E01 RID: 89601 RVA: 0x0032EA5A File Offset: 0x0032CC5A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> DynamicTrialRoles
		{
			get
			{
				return this.dynamicTrialRoles_;
			}
		}

		// Token: 0x17004923 RID: 18723
		// (get) Token: 0x06015E02 RID: 89602 RVA: 0x0032EA62 File Offset: 0x0032CC62
		// (set) Token: 0x06015E03 RID: 89603 RVA: 0x0032EA6A File Offset: 0x0032CC6A
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

		// Token: 0x17004924 RID: 18724
		// (get) Token: 0x06015E04 RID: 89604 RVA: 0x0032EA73 File Offset: 0x0032CC73
		// (set) Token: 0x06015E05 RID: 89605 RVA: 0x0032EA7B File Offset: 0x0032CC7B
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

		// Token: 0x06015E06 RID: 89606 RVA: 0x0032EA84 File Offset: 0x0032CC84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueResSeasonData);
		}

		// Token: 0x06015E07 RID: 89607 RVA: 0x0032EA94 File Offset: 0x0032CC94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueResSeasonData other)
		{
			return other != null && (other == this || (this.SeasonId == other.SeasonId && this.TalentSkillDict.Equals(other.TalentSkillDict) && this.endings_.Equals(other.endings_) && this.endingRewardIds_.Equals(other.endingRewardIds_) && this.staticTrialRoles_.Equals(other.staticTrialRoles_) && this.dynamicTrialRoles_.Equals(other.dynamicTrialRoles_) && this.EndTime == other.EndTime && this.TotalShopItem == other.TotalShopItem && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06015E08 RID: 89608 RVA: 0x0032EB58 File Offset: 0x0032CD58
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

		// Token: 0x06015E09 RID: 89609 RVA: 0x0032EC0F File Offset: 0x0032CE0F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06015E0A RID: 89610 RVA: 0x0032EC1C File Offset: 0x0032CE1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06015E0B RID: 89611 RVA: 0x0032EC28 File Offset: 0x0032CE28
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

		// Token: 0x06015E0C RID: 89612 RVA: 0x0032ECF4 File Offset: 0x0032CEF4
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

		// Token: 0x06015E0D RID: 89613 RVA: 0x0032EDC4 File Offset: 0x0032CFC4
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

		// Token: 0x06015E0E RID: 89614 RVA: 0x0032EE7D File Offset: 0x0032D07D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06015E0F RID: 89615 RVA: 0x0032EE88 File Offset: 0x0032D088
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

		// Token: 0x040083B7 RID: 33719
		private static readonly MessageParser<RogueResSeasonData> _parser = new MessageParser<RogueResSeasonData>(() => new RogueResSeasonData());

		// Token: 0x040083B8 RID: 33720
		private UnknownFieldSet _unknownFields;

		// Token: 0x040083B9 RID: 33721
		public const int SeasonIdFieldNumber = 1;

		// Token: 0x040083BA RID: 33722
		private int seasonId_;

		// Token: 0x040083BB RID: 33723
		public const int TalentSkillDictFieldNumber = 2;

		// Token: 0x040083BC RID: 33724
		private static readonly MapField<int, int>.Codec _map_talentSkillDict_codec = new MapField<int, int>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForInt32(16U, 0), 18U);

		// Token: 0x040083BD RID: 33725
		private readonly MapField<int, int> talentSkillDict_ = new MapField<int, int>();

		// Token: 0x040083BE RID: 33726
		public const int EndingsFieldNumber = 3;

		// Token: 0x040083BF RID: 33727
		private static readonly FieldCodec<int> _repeated_endings_codec = FieldCodec.ForInt32(26U);

		// Token: 0x040083C0 RID: 33728
		private readonly RepeatedField<int> endings_ = new RepeatedField<int>();

		// Token: 0x040083C1 RID: 33729
		public const int EndingRewardIdsFieldNumber = 4;

		// Token: 0x040083C2 RID: 33730
		private static readonly FieldCodec<ActivityTask> _repeated_endingRewardIds_codec = FieldCodec.ForMessage<ActivityTask>(34U, ActivityTask.Parser);

		// Token: 0x040083C3 RID: 33731
		private readonly RepeatedField<ActivityTask> endingRewardIds_ = new RepeatedField<ActivityTask>();

		// Token: 0x040083C4 RID: 33732
		public const int StaticTrialRolesFieldNumber = 5;

		// Token: 0x040083C5 RID: 33733
		private static readonly FieldCodec<int> _repeated_staticTrialRoles_codec = FieldCodec.ForInt32(42U);

		// Token: 0x040083C6 RID: 33734
		private readonly RepeatedField<int> staticTrialRoles_ = new RepeatedField<int>();

		// Token: 0x040083C7 RID: 33735
		public const int DynamicTrialRolesFieldNumber = 6;

		// Token: 0x040083C8 RID: 33736
		private static readonly FieldCodec<int> _repeated_dynamicTrialRoles_codec = FieldCodec.ForInt32(50U);

		// Token: 0x040083C9 RID: 33737
		private readonly RepeatedField<int> dynamicTrialRoles_ = new RepeatedField<int>();

		// Token: 0x040083CA RID: 33738
		public const int EndTimeFieldNumber = 7;

		// Token: 0x040083CB RID: 33739
		private long endTime_;

		// Token: 0x040083CC RID: 33740
		public const int TotalShopItemFieldNumber = 8;

		// Token: 0x040083CD RID: 33741
		private int totalShopItem_;
	}
}
