using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200103D RID: 4157
	public sealed class RogueWhiteCatData : IMessage<RogueWhiteCatData>, IMessage, IEquatable<RogueWhiteCatData>, IDeepCloneable<RogueWhiteCatData>, IBufferMessage
	{
		// Token: 0x060163E0 RID: 91104 RVA: 0x0033BDE2 File Offset: 0x00339FE2
		[NullableContext(1)]
		public static RogueWhiteCatData Create()
		{
			return new RogueWhiteCatData();
		}

		// Token: 0x17004A66 RID: 19046
		// (get) Token: 0x060163E1 RID: 91105 RVA: 0x0033BDE9 File Offset: 0x00339FE9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004A67 RID: 19047
		// (get) Token: 0x060163E2 RID: 91106 RVA: 0x0033BDEC File Offset: 0x00339FEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueWhiteCatData.Descriptor;
			}
		}

		// Token: 0x060163E3 RID: 91107 RVA: 0x0033BDF4 File Offset: 0x00339FF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueWhiteCatData()
		{
		}

		// Token: 0x060163E4 RID: 91108 RVA: 0x0033BE60 File Offset: 0x0033A060
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

		// Token: 0x060163E5 RID: 91109 RVA: 0x0033BF3C File Offset: 0x0033A13C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueWhiteCatData Clone()
		{
			return new RogueWhiteCatData(this);
		}

		// Token: 0x17004A68 RID: 19048
		// (get) Token: 0x060163E6 RID: 91110 RVA: 0x0033BF44 File Offset: 0x0033A144
		// (set) Token: 0x060163E7 RID: 91111 RVA: 0x0033BF4C File Offset: 0x0033A14C
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

		// Token: 0x17004A69 RID: 19049
		// (get) Token: 0x060163E8 RID: 91112 RVA: 0x0033BF55 File Offset: 0x0033A155
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<SignState> SignStateList
		{
			get
			{
				return this.signStateList_;
			}
		}

		// Token: 0x17004A6A RID: 19050
		// (get) Token: 0x060163E9 RID: 91113 RVA: 0x0033BF5D File Offset: 0x0033A15D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RogueRoleInstData> RogueRoleInstData
		{
			get
			{
				return this.rogueRoleInstData_;
			}
		}

		// Token: 0x17004A6B RID: 19051
		// (get) Token: 0x060163EA RID: 91114 RVA: 0x0033BF65 File Offset: 0x0033A165
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RogueLevelPlayData> RogueLevelPlayData
		{
			get
			{
				return this.rogueLevelPlayData_;
			}
		}

		// Token: 0x17004A6C RID: 19052
		// (get) Token: 0x060163EB RID: 91115 RVA: 0x0033BF6D File Offset: 0x0033A16D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<SignState> BossRewardStateList
		{
			get
			{
				return this.bossRewardStateList_;
			}
		}

		// Token: 0x17004A6D RID: 19053
		// (get) Token: 0x060163EC RID: 91116 RVA: 0x0033BF75 File Offset: 0x0033A175
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RogueLimitedAward> RogueLimitedAwards
		{
			get
			{
				return this.rogueLimitedAwards_;
			}
		}

		// Token: 0x17004A6E RID: 19054
		// (get) Token: 0x060163ED RID: 91117 RVA: 0x0033BF7D File Offset: 0x0033A17D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, int> ScoreMap
		{
			get
			{
				return this.scoreMap_;
			}
		}

		// Token: 0x17004A6F RID: 19055
		// (get) Token: 0x060163EE RID: 91118 RVA: 0x0033BF85 File Offset: 0x0033A185
		// (set) Token: 0x060163EF RID: 91119 RVA: 0x0033BF8D File Offset: 0x0033A18D
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

		// Token: 0x17004A70 RID: 19056
		// (get) Token: 0x060163F0 RID: 91120 RVA: 0x0033BF96 File Offset: 0x0033A196
		// (set) Token: 0x060163F1 RID: 91121 RVA: 0x0033BF9E File Offset: 0x0033A19E
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

		// Token: 0x17004A71 RID: 19057
		// (get) Token: 0x060163F2 RID: 91122 RVA: 0x0033BFA7 File Offset: 0x0033A1A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RogueBossInstData> RogueBossInstDatas
		{
			get
			{
				return this.rogueBossInstDatas_;
			}
		}

		// Token: 0x17004A72 RID: 19058
		// (get) Token: 0x060163F3 RID: 91123 RVA: 0x0033BFAF File Offset: 0x0033A1AF
		// (set) Token: 0x060163F4 RID: 91124 RVA: 0x0033BFB7 File Offset: 0x0033A1B7
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

		// Token: 0x17004A73 RID: 19059
		// (get) Token: 0x060163F5 RID: 91125 RVA: 0x0033BFC0 File Offset: 0x0033A1C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> UnlockButtons
		{
			get
			{
				return this.unlockButtons_;
			}
		}

		// Token: 0x060163F6 RID: 91126 RVA: 0x0033BFC8 File Offset: 0x0033A1C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueWhiteCatData);
		}

		// Token: 0x060163F7 RID: 91127 RVA: 0x0033BFD8 File Offset: 0x0033A1D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueWhiteCatData other)
		{
			return other != null && (other == this || (this.MaxEnergy == other.MaxEnergy && this.signStateList_.Equals(other.signStateList_) && this.rogueRoleInstData_.Equals(other.rogueRoleInstData_) && this.rogueLevelPlayData_.Equals(other.rogueLevelPlayData_) && this.bossRewardStateList_.Equals(other.bossRewardStateList_) && this.rogueLimitedAwards_.Equals(other.rogueLimitedAwards_) && this.ScoreMap.Equals(other.ScoreMap) && this.LimitedStartTime == other.LimitedStartTime && this.LimitedEndTime == other.LimitedEndTime && this.rogueBossInstDatas_.Equals(other.rogueBossInstDatas_) && this.Record == other.Record && this.unlockButtons_.Equals(other.unlockButtons_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060163F8 RID: 91128 RVA: 0x0033C0EC File Offset: 0x0033A2EC
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

		// Token: 0x060163F9 RID: 91129 RVA: 0x0033C1E6 File Offset: 0x0033A3E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060163FA RID: 91130 RVA: 0x0033C1F3 File Offset: 0x0033A3F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060163FB RID: 91131 RVA: 0x0033C1FC File Offset: 0x0033A3FC
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

		// Token: 0x060163FC RID: 91132 RVA: 0x0033C314 File Offset: 0x0033A514
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

		// Token: 0x060163FD RID: 91133 RVA: 0x0033C434 File Offset: 0x0033A634
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

		// Token: 0x060163FE RID: 91134 RVA: 0x0033C534 File Offset: 0x0033A734
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060163FF RID: 91135 RVA: 0x0033C540 File Offset: 0x0033A740
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

		// Token: 0x04008586 RID: 34182
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008587 RID: 34183
		public const int MaxEnergyFieldNumber = 1;

		// Token: 0x04008588 RID: 34184
		private int maxEnergy_;

		// Token: 0x04008589 RID: 34185
		public const int SignStateListFieldNumber = 3;

		// Token: 0x0400858A RID: 34186
		private static readonly FieldCodec<SignState> _repeated_signStateList_codec = FieldCodec.ForEnum<SignState>(26U, (SignState x) => (int)x, (int x) => (SignState)x);

		// Token: 0x0400858B RID: 34187
		private readonly RepeatedField<SignState> signStateList_ = new RepeatedField<SignState>();

		// Token: 0x0400858C RID: 34188
		public const int RogueRoleInstDataFieldNumber = 5;

		// Token: 0x0400858D RID: 34189
		private static readonly FieldCodec<RogueRoleInstData> _repeated_rogueRoleInstData_codec = FieldCodec.ForMessage<RogueRoleInstData>(42U, Aki.Protocol.RogueRoleInstData.Parser);

		// Token: 0x0400858E RID: 34190
		private readonly RepeatedField<RogueRoleInstData> rogueRoleInstData_ = new RepeatedField<RogueRoleInstData>();

		// Token: 0x0400858F RID: 34191
		public const int RogueLevelPlayDataFieldNumber = 6;

		// Token: 0x04008590 RID: 34192
		private static readonly FieldCodec<RogueLevelPlayData> _repeated_rogueLevelPlayData_codec = FieldCodec.ForMessage<RogueLevelPlayData>(50U, Aki.Protocol.RogueLevelPlayData.Parser);

		// Token: 0x04008591 RID: 34193
		private readonly RepeatedField<RogueLevelPlayData> rogueLevelPlayData_ = new RepeatedField<RogueLevelPlayData>();

		// Token: 0x04008592 RID: 34194
		public const int BossRewardStateListFieldNumber = 7;

		// Token: 0x04008593 RID: 34195
		private static readonly FieldCodec<SignState> _repeated_bossRewardStateList_codec = FieldCodec.ForEnum<SignState>(58U, (SignState x) => (int)x, (int x) => (SignState)x);

		// Token: 0x04008594 RID: 34196
		private readonly RepeatedField<SignState> bossRewardStateList_ = new RepeatedField<SignState>();

		// Token: 0x04008595 RID: 34197
		public const int RogueLimitedAwardsFieldNumber = 8;

		// Token: 0x04008596 RID: 34198
		private static readonly FieldCodec<RogueLimitedAward> _repeated_rogueLimitedAwards_codec = FieldCodec.ForMessage<RogueLimitedAward>(66U, RogueLimitedAward.Parser);

		// Token: 0x04008597 RID: 34199
		private readonly RepeatedField<RogueLimitedAward> rogueLimitedAwards_ = new RepeatedField<RogueLimitedAward>();

		// Token: 0x04008598 RID: 34200
		public const int ScoreMapFieldNumber = 9;

		// Token: 0x04008599 RID: 34201
		private static readonly MapField<int, int>.Codec _map_scoreMap_codec = new MapField<int, int>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForInt32(16U, 0), 74U);

		// Token: 0x0400859A RID: 34202
		private readonly MapField<int, int> scoreMap_ = new MapField<int, int>();

		// Token: 0x0400859B RID: 34203
		public const int LimitedStartTimeFieldNumber = 10;

		// Token: 0x0400859C RID: 34204
		private long limitedStartTime_;

		// Token: 0x0400859D RID: 34205
		public const int LimitedEndTimeFieldNumber = 11;

		// Token: 0x0400859E RID: 34206
		private long limitedEndTime_;

		// Token: 0x0400859F RID: 34207
		public const int RogueBossInstDatasFieldNumber = 12;

		// Token: 0x040085A0 RID: 34208
		private static readonly FieldCodec<RogueBossInstData> _repeated_rogueBossInstDatas_codec = FieldCodec.ForMessage<RogueBossInstData>(98U, RogueBossInstData.Parser);

		// Token: 0x040085A1 RID: 34209
		private readonly RepeatedField<RogueBossInstData> rogueBossInstDatas_ = new RepeatedField<RogueBossInstData>();

		// Token: 0x040085A2 RID: 34210
		public const int RecordFieldNumber = 13;

		// Token: 0x040085A3 RID: 34211
		private int record_;

		// Token: 0x040085A4 RID: 34212
		public const int UnlockButtonsFieldNumber = 14;

		// Token: 0x040085A5 RID: 34213
		private static readonly FieldCodec<int> _repeated_unlockButtons_codec = FieldCodec.ForInt32(114U);

		// Token: 0x040085A6 RID: 34214
		private readonly RepeatedField<int> unlockButtons_ = new RepeatedField<int>();
	}
}
