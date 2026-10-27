using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200104D RID: 4173
	public sealed class RogueWhiteCatData : IMessage<RogueWhiteCatData>, IMessage, IEquatable<RogueWhiteCatData>, IDeepCloneable<RogueWhiteCatData>, IBufferMessage
	{
		// Token: 0x060164C5 RID: 91333 RVA: 0x0033D4AE File Offset: 0x0033B6AE
		[NullableContext(1)]
		public static RogueWhiteCatData Create()
		{
			return new RogueWhiteCatData();
		}

		// Token: 0x17004A90 RID: 19088
		// (get) Token: 0x060164C6 RID: 91334 RVA: 0x0033D4B5 File Offset: 0x0033B6B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004A91 RID: 19089
		// (get) Token: 0x060164C7 RID: 91335 RVA: 0x0033D4B8 File Offset: 0x0033B6B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueWhiteCatData.Descriptor;
			}
		}

		// Token: 0x060164C8 RID: 91336 RVA: 0x0033D4C0 File Offset: 0x0033B6C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueWhiteCatData()
		{
		}

		// Token: 0x060164C9 RID: 91337 RVA: 0x0033D52C File Offset: 0x0033B72C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueWhiteCatData(RogueWhiteCatData other) : this()
		{
			this.maxEnergy_ = other.maxEnergy_;
			this.signStateList_ = other.signStateList_.Clone();
			this.rogueRoleInstData_ = other.rogueRoleInstData_.Clone();
			this.rogueLevelPlayData_ = other.rogueLevelPlayData_.Clone();
			this.bossRewardStateList_ = other.bossRewardStateList_.Clone();
			this.rogueLimitedAwards_ = other.rogueLimitedAwards_.Clone();
			this.scoreMap_ = other.scoreMap_.Clone();
			this.limitedStartTime_ = other.limitedStartTime_;
			this.limitedEndTime_ = other.limitedEndTime_;
			this.rogueBossInstDatas_ = other.rogueBossInstDatas_.Clone();
			this.record_ = other.record_;
			this.unlockButtons_ = other.unlockButtons_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060164CA RID: 91338 RVA: 0x0033D608 File Offset: 0x0033B808
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueWhiteCatData Clone()
		{
			return new RogueWhiteCatData(this);
		}

		// Token: 0x17004A92 RID: 19090
		// (get) Token: 0x060164CB RID: 91339 RVA: 0x0033D610 File Offset: 0x0033B810
		// (set) Token: 0x060164CC RID: 91340 RVA: 0x0033D618 File Offset: 0x0033B818
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int MaxEnergy
		{
			get
			{
				return this.maxEnergy_;
			}
			set
			{
				this.maxEnergy_ = value;
			}
		}

		// Token: 0x17004A93 RID: 19091
		// (get) Token: 0x060164CD RID: 91341 RVA: 0x0033D621 File Offset: 0x0033B821
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<SignState> SignStateList
		{
			get
			{
				return this.signStateList_;
			}
		}

		// Token: 0x17004A94 RID: 19092
		// (get) Token: 0x060164CE RID: 91342 RVA: 0x0033D629 File Offset: 0x0033B829
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RogueRoleInstData> RogueRoleInstData
		{
			get
			{
				return this.rogueRoleInstData_;
			}
		}

		// Token: 0x17004A95 RID: 19093
		// (get) Token: 0x060164CF RID: 91343 RVA: 0x0033D631 File Offset: 0x0033B831
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RogueLevelPlayData> RogueLevelPlayData
		{
			get
			{
				return this.rogueLevelPlayData_;
			}
		}

		// Token: 0x17004A96 RID: 19094
		// (get) Token: 0x060164D0 RID: 91344 RVA: 0x0033D639 File Offset: 0x0033B839
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<SignState> BossRewardStateList
		{
			get
			{
				return this.bossRewardStateList_;
			}
		}

		// Token: 0x17004A97 RID: 19095
		// (get) Token: 0x060164D1 RID: 91345 RVA: 0x0033D641 File Offset: 0x0033B841
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RogueLimitedAward> RogueLimitedAwards
		{
			get
			{
				return this.rogueLimitedAwards_;
			}
		}

		// Token: 0x17004A98 RID: 19096
		// (get) Token: 0x060164D2 RID: 91346 RVA: 0x0033D649 File Offset: 0x0033B849
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, int> ScoreMap
		{
			get
			{
				return this.scoreMap_;
			}
		}

		// Token: 0x17004A99 RID: 19097
		// (get) Token: 0x060164D3 RID: 91347 RVA: 0x0033D651 File Offset: 0x0033B851
		// (set) Token: 0x060164D4 RID: 91348 RVA: 0x0033D659 File Offset: 0x0033B859
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long LimitedStartTime
		{
			get
			{
				return this.limitedStartTime_;
			}
			set
			{
				this.limitedStartTime_ = value;
			}
		}

		// Token: 0x17004A9A RID: 19098
		// (get) Token: 0x060164D5 RID: 91349 RVA: 0x0033D662 File Offset: 0x0033B862
		// (set) Token: 0x060164D6 RID: 91350 RVA: 0x0033D66A File Offset: 0x0033B86A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long LimitedEndTime
		{
			get
			{
				return this.limitedEndTime_;
			}
			set
			{
				this.limitedEndTime_ = value;
			}
		}

		// Token: 0x17004A9B RID: 19099
		// (get) Token: 0x060164D7 RID: 91351 RVA: 0x0033D673 File Offset: 0x0033B873
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RogueBossInstData> RogueBossInstDatas
		{
			get
			{
				return this.rogueBossInstDatas_;
			}
		}

		// Token: 0x17004A9C RID: 19100
		// (get) Token: 0x060164D8 RID: 91352 RVA: 0x0033D67B File Offset: 0x0033B87B
		// (set) Token: 0x060164D9 RID: 91353 RVA: 0x0033D683 File Offset: 0x0033B883
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Record
		{
			get
			{
				return this.record_;
			}
			set
			{
				this.record_ = value;
			}
		}

		// Token: 0x17004A9D RID: 19101
		// (get) Token: 0x060164DA RID: 91354 RVA: 0x0033D68C File Offset: 0x0033B88C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> UnlockButtons
		{
			get
			{
				return this.unlockButtons_;
			}
		}

		// Token: 0x060164DB RID: 91355 RVA: 0x0033D694 File Offset: 0x0033B894
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueWhiteCatData);
		}

		// Token: 0x060164DC RID: 91356 RVA: 0x0033D6A4 File Offset: 0x0033B8A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueWhiteCatData other)
		{
			return other != null && (other == this || (this.MaxEnergy == other.MaxEnergy && this.signStateList_.Equals(other.signStateList_) && this.rogueRoleInstData_.Equals(other.rogueRoleInstData_) && this.rogueLevelPlayData_.Equals(other.rogueLevelPlayData_) && this.bossRewardStateList_.Equals(other.bossRewardStateList_) && this.rogueLimitedAwards_.Equals(other.rogueLimitedAwards_) && this.ScoreMap.Equals(other.ScoreMap) && this.LimitedStartTime == other.LimitedStartTime && this.LimitedEndTime == other.LimitedEndTime && this.rogueBossInstDatas_.Equals(other.rogueBossInstDatas_) && this.Record == other.Record && this.unlockButtons_.Equals(other.unlockButtons_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060164DD RID: 91357 RVA: 0x0033D7B8 File Offset: 0x0033B9B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.MaxEnergy != 0)
			{
				num ^= this.MaxEnergy.GetHashCode();
			}
			num ^= this.signStateList_.GetHashCode();
			num ^= this.rogueRoleInstData_.GetHashCode();
			num ^= this.rogueLevelPlayData_.GetHashCode();
			num ^= this.bossRewardStateList_.GetHashCode();
			num ^= this.rogueLimitedAwards_.GetHashCode();
			num ^= this.ScoreMap.GetHashCode();
			if (this.LimitedStartTime != 0L)
			{
				num ^= this.LimitedStartTime.GetHashCode();
			}
			if (this.LimitedEndTime != 0L)
			{
				num ^= this.LimitedEndTime.GetHashCode();
			}
			num ^= this.rogueBossInstDatas_.GetHashCode();
			if (this.Record != 0)
			{
				num ^= this.Record.GetHashCode();
			}
			num ^= this.unlockButtons_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060164DE RID: 91358 RVA: 0x0033D8B2 File Offset: 0x0033BAB2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060164DF RID: 91359 RVA: 0x0033D8BF File Offset: 0x0033BABF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060164E0 RID: 91360 RVA: 0x0033D8C8 File Offset: 0x0033BAC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.MaxEnergy != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.MaxEnergy);
			}
			this.signStateList_.WriteTo(ref output, RogueWhiteCatData._repeated_signStateList_codec);
			this.rogueRoleInstData_.WriteTo(ref output, RogueWhiteCatData._repeated_rogueRoleInstData_codec);
			this.rogueLevelPlayData_.WriteTo(ref output, RogueWhiteCatData._repeated_rogueLevelPlayData_codec);
			this.bossRewardStateList_.WriteTo(ref output, RogueWhiteCatData._repeated_bossRewardStateList_codec);
			this.rogueLimitedAwards_.WriteTo(ref output, RogueWhiteCatData._repeated_rogueLimitedAwards_codec);
			this.scoreMap_.WriteTo(ref output, RogueWhiteCatData._map_scoreMap_codec);
			if (this.LimitedStartTime != 0L)
			{
				output.WriteRawTag(80);
				output.WriteInt64(this.LimitedStartTime);
			}
			if (this.LimitedEndTime != 0L)
			{
				output.WriteRawTag(88);
				output.WriteInt64(this.LimitedEndTime);
			}
			this.rogueBossInstDatas_.WriteTo(ref output, RogueWhiteCatData._repeated_rogueBossInstDatas_codec);
			if (this.Record != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.Record);
			}
			this.unlockButtons_.WriteTo(ref output, RogueWhiteCatData._repeated_unlockButtons_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060164E1 RID: 91361 RVA: 0x0033D9E0 File Offset: 0x0033BBE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.MaxEnergy != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.MaxEnergy);
			}
			num += this.signStateList_.CalculateSize(RogueWhiteCatData._repeated_signStateList_codec);
			num += this.rogueRoleInstData_.CalculateSize(RogueWhiteCatData._repeated_rogueRoleInstData_codec);
			num += this.rogueLevelPlayData_.CalculateSize(RogueWhiteCatData._repeated_rogueLevelPlayData_codec);
			num += this.bossRewardStateList_.CalculateSize(RogueWhiteCatData._repeated_bossRewardStateList_codec);
			num += this.rogueLimitedAwards_.CalculateSize(RogueWhiteCatData._repeated_rogueLimitedAwards_codec);
			num += this.scoreMap_.CalculateSize(RogueWhiteCatData._map_scoreMap_codec);
			if (this.LimitedStartTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.LimitedStartTime);
			}
			if (this.LimitedEndTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.LimitedEndTime);
			}
			num += this.rogueBossInstDatas_.CalculateSize(RogueWhiteCatData._repeated_rogueBossInstDatas_codec);
			if (this.Record != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Record);
			}
			num += this.unlockButtons_.CalculateSize(RogueWhiteCatData._repeated_unlockButtons_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060164E2 RID: 91362 RVA: 0x0033DB00 File Offset: 0x0033BD00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueWhiteCatData other)
		{
			if (other == null)
			{
				return;
			}
			if (other.MaxEnergy != 0)
			{
				this.MaxEnergy = other.MaxEnergy;
			}
			this.signStateList_.Add(other.signStateList_);
			this.rogueRoleInstData_.Add(other.rogueRoleInstData_);
			this.rogueLevelPlayData_.Add(other.rogueLevelPlayData_);
			this.bossRewardStateList_.Add(other.bossRewardStateList_);
			this.rogueLimitedAwards_.Add(other.rogueLimitedAwards_);
			this.scoreMap_.MergeFrom(other.scoreMap_);
			if (other.LimitedStartTime != 0L)
			{
				this.LimitedStartTime = other.LimitedStartTime;
			}
			if (other.LimitedEndTime != 0L)
			{
				this.LimitedEndTime = other.LimitedEndTime;
			}
			this.rogueBossInstDatas_.Add(other.rogueBossInstDatas_);
			if (other.Record != 0)
			{
				this.Record = other.Record;
			}
			this.unlockButtons_.Add(other.unlockButtons_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060164E3 RID: 91363 RVA: 0x0033DC00 File Offset: 0x0033BE00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060164E4 RID: 91364 RVA: 0x0033DC0C File Offset: 0x0033BE0C
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
				if (num <= 58U)
				{
					if (num <= 26U)
					{
						if (num == 8U)
						{
							this.MaxEnergy = input.ReadInt32();
							continue;
						}
						if (num == 24U || num == 26U)
						{
							this.signStateList_.AddEntriesFrom(ref input, RogueWhiteCatData._repeated_signStateList_codec);
							continue;
						}
					}
					else if (num <= 50U)
					{
						if (num == 42U)
						{
							this.rogueRoleInstData_.AddEntriesFrom(ref input, RogueWhiteCatData._repeated_rogueRoleInstData_codec);
							continue;
						}
						if (num == 50U)
						{
							this.rogueLevelPlayData_.AddEntriesFrom(ref input, RogueWhiteCatData._repeated_rogueLevelPlayData_codec);
							continue;
						}
					}
					else if (num == 56U || num == 58U)
					{
						this.bossRewardStateList_.AddEntriesFrom(ref input, RogueWhiteCatData._repeated_bossRewardStateList_codec);
						continue;
					}
				}
				else if (num <= 88U)
				{
					if (num <= 74U)
					{
						if (num == 66U)
						{
							this.rogueLimitedAwards_.AddEntriesFrom(ref input, RogueWhiteCatData._repeated_rogueLimitedAwards_codec);
							continue;
						}
						if (num == 74U)
						{
							this.scoreMap_.AddEntriesFrom(ref input, RogueWhiteCatData._map_scoreMap_codec);
							continue;
						}
					}
					else
					{
						if (num == 80U)
						{
							this.LimitedStartTime = input.ReadInt64();
							continue;
						}
						if (num == 88U)
						{
							this.LimitedEndTime = input.ReadInt64();
							continue;
						}
					}
				}
				else if (num <= 104U)
				{
					if (num == 98U)
					{
						this.rogueBossInstDatas_.AddEntriesFrom(ref input, RogueWhiteCatData._repeated_rogueBossInstDatas_codec);
						continue;
					}
					if (num == 104U)
					{
						this.Record = input.ReadInt32();
						continue;
					}
				}
				else if (num == 112U || num == 114U)
				{
					this.unlockButtons_.AddEntriesFrom(ref input, RogueWhiteCatData._repeated_unlockButtons_codec);
					continue;
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400855C RID: 34140
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400855D RID: 34141
		public const int MaxEnergyFieldNumber = 1;

		// Token: 0x0400855E RID: 34142
		private int maxEnergy_;

		// Token: 0x0400855F RID: 34143
		public const int SignStateListFieldNumber = 3;

		// Token: 0x04008560 RID: 34144
		private static readonly FieldCodec<SignState> _repeated_signStateList_codec = FieldCodec.ForEnum<SignState>(26U, (SignState x) => (int)x, (int x) => (SignState)x);

		// Token: 0x04008561 RID: 34145
		private readonly RepeatedField<SignState> signStateList_ = new RepeatedField<SignState>();

		// Token: 0x04008562 RID: 34146
		public const int RogueRoleInstDataFieldNumber = 5;

		// Token: 0x04008563 RID: 34147
		private static readonly FieldCodec<RogueRoleInstData> _repeated_rogueRoleInstData_codec = FieldCodec.ForMessage<RogueRoleInstData>(42U, Aki.Protocol.RogueRoleInstData.Parser);

		// Token: 0x04008564 RID: 34148
		private readonly RepeatedField<RogueRoleInstData> rogueRoleInstData_ = new RepeatedField<RogueRoleInstData>();

		// Token: 0x04008565 RID: 34149
		public const int RogueLevelPlayDataFieldNumber = 6;

		// Token: 0x04008566 RID: 34150
		private static readonly FieldCodec<RogueLevelPlayData> _repeated_rogueLevelPlayData_codec = FieldCodec.ForMessage<RogueLevelPlayData>(50U, Aki.Protocol.RogueLevelPlayData.Parser);

		// Token: 0x04008567 RID: 34151
		private readonly RepeatedField<RogueLevelPlayData> rogueLevelPlayData_ = new RepeatedField<RogueLevelPlayData>();

		// Token: 0x04008568 RID: 34152
		public const int BossRewardStateListFieldNumber = 7;

		// Token: 0x04008569 RID: 34153
		private static readonly FieldCodec<SignState> _repeated_bossRewardStateList_codec = FieldCodec.ForEnum<SignState>(58U, (SignState x) => (int)x, (int x) => (SignState)x);

		// Token: 0x0400856A RID: 34154
		private readonly RepeatedField<SignState> bossRewardStateList_ = new RepeatedField<SignState>();

		// Token: 0x0400856B RID: 34155
		public const int RogueLimitedAwardsFieldNumber = 8;

		// Token: 0x0400856C RID: 34156
		private static readonly FieldCodec<RogueLimitedAward> _repeated_rogueLimitedAwards_codec = FieldCodec.ForMessage<RogueLimitedAward>(66U, RogueLimitedAward.Parser);

		// Token: 0x0400856D RID: 34157
		private readonly RepeatedField<RogueLimitedAward> rogueLimitedAwards_ = new RepeatedField<RogueLimitedAward>();

		// Token: 0x0400856E RID: 34158
		public const int ScoreMapFieldNumber = 9;

		// Token: 0x0400856F RID: 34159
		private static readonly MapField<int, int>.Codec _map_scoreMap_codec = new MapField<int, int>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForInt32(16U, 0), 74U);

		// Token: 0x04008570 RID: 34160
		private readonly MapField<int, int> scoreMap_ = new MapField<int, int>();

		// Token: 0x04008571 RID: 34161
		public const int LimitedStartTimeFieldNumber = 10;

		// Token: 0x04008572 RID: 34162
		private long limitedStartTime_;

		// Token: 0x04008573 RID: 34163
		public const int LimitedEndTimeFieldNumber = 11;

		// Token: 0x04008574 RID: 34164
		private long limitedEndTime_;

		// Token: 0x04008575 RID: 34165
		public const int RogueBossInstDatasFieldNumber = 12;

		// Token: 0x04008576 RID: 34166
		private static readonly FieldCodec<RogueBossInstData> _repeated_rogueBossInstDatas_codec = FieldCodec.ForMessage<RogueBossInstData>(98U, RogueBossInstData.Parser);

		// Token: 0x04008577 RID: 34167
		private readonly RepeatedField<RogueBossInstData> rogueBossInstDatas_ = new RepeatedField<RogueBossInstData>();

		// Token: 0x04008578 RID: 34168
		public const int RecordFieldNumber = 13;

		// Token: 0x04008579 RID: 34169
		private int record_;

		// Token: 0x0400857A RID: 34170
		public const int UnlockButtonsFieldNumber = 14;

		// Token: 0x0400857B RID: 34171
		private static readonly FieldCodec<int> _repeated_unlockButtons_codec = FieldCodec.ForInt32(114U);

		// Token: 0x0400857C RID: 34172
		private readonly RepeatedField<int> unlockButtons_ = new RepeatedField<int>();
	}
}
