using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001402 RID: 5122
	public sealed class TrapDefenseActivityInfo : IMessage<TrapDefenseActivityInfo>, IMessage, IEquatable<TrapDefenseActivityInfo>, IDeepCloneable<TrapDefenseActivityInfo>, IBufferMessage
	{
		// Token: 0x0601B270 RID: 111216 RVA: 0x003EF50F File Offset: 0x003ED70F
		[NullableContext(1)]
		public static TrapDefenseActivityInfo Create()
		{
			return new TrapDefenseActivityInfo();
		}

		// Token: 0x17005B90 RID: 23440
		// (get) Token: 0x0601B271 RID: 111217 RVA: 0x003EF516 File Offset: 0x003ED716
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005B91 RID: 23441
		// (get) Token: 0x0601B272 RID: 111218 RVA: 0x003EF519 File Offset: 0x003ED719
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TrapDefenseActivityInfo.Descriptor;
			}
		}

		// Token: 0x0601B273 RID: 111219 RVA: 0x003EF520 File Offset: 0x003ED720
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseActivityInfo()
		{
		}

		// Token: 0x0601B274 RID: 111220 RVA: 0x003EF58C File Offset: 0x003ED78C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseActivityInfo(TrapDefenseActivityInfo other) : this()
		{
			this.unlockTechNodes_ = other.unlockTechNodes_.Clone();
			this.specialRewards_ = other.specialRewards_.Clone();
			this.rewards_ = other.rewards_.Clone();
			this.auxiliaries_ = other.auxiliaries_.Clone();
			this.buildings_ = other.buildings_.Clone();
			this.challenges_ = other.challenges_.Clone();
			this.limitBeginTime_ = other.limitBeginTime_;
			this.limitEndTime_ = other.limitEndTime_;
			this.unlockBds_ = other.unlockBds_.Clone();
			this.totalTechPoint_ = other.totalTechPoint_;
			this.leftTechPoint_ = other.leftTechPoint_;
			this.leftLevelUpPoint_ = other.leftLevelUpPoint_;
			this.totalLevelUpPoint_ = other.totalLevelUpPoint_;
			this.unlockBdGroups_ = other.unlockBdGroups_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601B275 RID: 111221 RVA: 0x003EF680 File Offset: 0x003ED880
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseActivityInfo Clone()
		{
			return new TrapDefenseActivityInfo(this);
		}

		// Token: 0x17005B92 RID: 23442
		// (get) Token: 0x0601B276 RID: 111222 RVA: 0x003EF688 File Offset: 0x003ED888
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> UnlockTechNodes
		{
			get
			{
				return this.unlockTechNodes_;
			}
		}

		// Token: 0x17005B93 RID: 23443
		// (get) Token: 0x0601B277 RID: 111223 RVA: 0x003EF690 File Offset: 0x003ED890
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<TrapDefenseRewardInfo> SpecialRewards
		{
			get
			{
				return this.specialRewards_;
			}
		}

		// Token: 0x17005B94 RID: 23444
		// (get) Token: 0x0601B278 RID: 111224 RVA: 0x003EF698 File Offset: 0x003ED898
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<TrapDefenseRewardInfo> Rewards
		{
			get
			{
				return this.rewards_;
			}
		}

		// Token: 0x17005B95 RID: 23445
		// (get) Token: 0x0601B279 RID: 111225 RVA: 0x003EF6A0 File Offset: 0x003ED8A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<TrapDefenseAuxiliaryInfo> Auxiliaries
		{
			get
			{
				return this.auxiliaries_;
			}
		}

		// Token: 0x17005B96 RID: 23446
		// (get) Token: 0x0601B27A RID: 111226 RVA: 0x003EF6A8 File Offset: 0x003ED8A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<TrapDefenseBuildingInfo> Buildings
		{
			get
			{
				return this.buildings_;
			}
		}

		// Token: 0x17005B97 RID: 23447
		// (get) Token: 0x0601B27B RID: 111227 RVA: 0x003EF6B0 File Offset: 0x003ED8B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<TrapDefenseChallengeInfo> Challenges
		{
			get
			{
				return this.challenges_;
			}
		}

		// Token: 0x17005B98 RID: 23448
		// (get) Token: 0x0601B27C RID: 111228 RVA: 0x003EF6B8 File Offset: 0x003ED8B8
		// (set) Token: 0x0601B27D RID: 111229 RVA: 0x003EF6C0 File Offset: 0x003ED8C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long LimitBeginTime
		{
			get
			{
				return this.limitBeginTime_;
			}
			set
			{
				this.limitBeginTime_ = value;
			}
		}

		// Token: 0x17005B99 RID: 23449
		// (get) Token: 0x0601B27E RID: 111230 RVA: 0x003EF6C9 File Offset: 0x003ED8C9
		// (set) Token: 0x0601B27F RID: 111231 RVA: 0x003EF6D1 File Offset: 0x003ED8D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long LimitEndTime
		{
			get
			{
				return this.limitEndTime_;
			}
			set
			{
				this.limitEndTime_ = value;
			}
		}

		// Token: 0x17005B9A RID: 23450
		// (get) Token: 0x0601B280 RID: 111232 RVA: 0x003EF6DA File Offset: 0x003ED8DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> UnlockBds
		{
			get
			{
				return this.unlockBds_;
			}
		}

		// Token: 0x17005B9B RID: 23451
		// (get) Token: 0x0601B281 RID: 111233 RVA: 0x003EF6E2 File Offset: 0x003ED8E2
		// (set) Token: 0x0601B282 RID: 111234 RVA: 0x003EF6EA File Offset: 0x003ED8EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TotalTechPoint
		{
			get
			{
				return this.totalTechPoint_;
			}
			set
			{
				this.totalTechPoint_ = value;
			}
		}

		// Token: 0x17005B9C RID: 23452
		// (get) Token: 0x0601B283 RID: 111235 RVA: 0x003EF6F3 File Offset: 0x003ED8F3
		// (set) Token: 0x0601B284 RID: 111236 RVA: 0x003EF6FB File Offset: 0x003ED8FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int LeftTechPoint
		{
			get
			{
				return this.leftTechPoint_;
			}
			set
			{
				this.leftTechPoint_ = value;
			}
		}

		// Token: 0x17005B9D RID: 23453
		// (get) Token: 0x0601B285 RID: 111237 RVA: 0x003EF704 File Offset: 0x003ED904
		// (set) Token: 0x0601B286 RID: 111238 RVA: 0x003EF70C File Offset: 0x003ED90C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int LeftLevelUpPoint
		{
			get
			{
				return this.leftLevelUpPoint_;
			}
			set
			{
				this.leftLevelUpPoint_ = value;
			}
		}

		// Token: 0x17005B9E RID: 23454
		// (get) Token: 0x0601B287 RID: 111239 RVA: 0x003EF715 File Offset: 0x003ED915
		// (set) Token: 0x0601B288 RID: 111240 RVA: 0x003EF71D File Offset: 0x003ED91D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TotalLevelUpPoint
		{
			get
			{
				return this.totalLevelUpPoint_;
			}
			set
			{
				this.totalLevelUpPoint_ = value;
			}
		}

		// Token: 0x17005B9F RID: 23455
		// (get) Token: 0x0601B289 RID: 111241 RVA: 0x003EF726 File Offset: 0x003ED926
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> UnlockBdGroups
		{
			get
			{
				return this.unlockBdGroups_;
			}
		}

		// Token: 0x0601B28A RID: 111242 RVA: 0x003EF72E File Offset: 0x003ED92E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TrapDefenseActivityInfo);
		}

		// Token: 0x0601B28B RID: 111243 RVA: 0x003EF73C File Offset: 0x003ED93C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TrapDefenseActivityInfo other)
		{
			return other != null && (other == this || (this.unlockTechNodes_.Equals(other.unlockTechNodes_) && this.specialRewards_.Equals(other.specialRewards_) && this.rewards_.Equals(other.rewards_) && this.auxiliaries_.Equals(other.auxiliaries_) && this.buildings_.Equals(other.buildings_) && this.challenges_.Equals(other.challenges_) && this.LimitBeginTime == other.LimitBeginTime && this.LimitEndTime == other.LimitEndTime && this.unlockBds_.Equals(other.unlockBds_) && this.TotalTechPoint == other.TotalTechPoint && this.LeftTechPoint == other.LeftTechPoint && this.LeftLevelUpPoint == other.LeftLevelUpPoint && this.TotalLevelUpPoint == other.TotalLevelUpPoint && this.unlockBdGroups_.Equals(other.unlockBdGroups_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601B28C RID: 111244 RVA: 0x003EF870 File Offset: 0x003EDA70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.unlockTechNodes_.GetHashCode();
			num ^= this.specialRewards_.GetHashCode();
			num ^= this.rewards_.GetHashCode();
			num ^= this.auxiliaries_.GetHashCode();
			num ^= this.buildings_.GetHashCode();
			num ^= this.challenges_.GetHashCode();
			if (this.LimitBeginTime != 0L)
			{
				num ^= this.LimitBeginTime.GetHashCode();
			}
			if (this.LimitEndTime != 0L)
			{
				num ^= this.LimitEndTime.GetHashCode();
			}
			num ^= this.unlockBds_.GetHashCode();
			if (this.TotalTechPoint != 0)
			{
				num ^= this.TotalTechPoint.GetHashCode();
			}
			if (this.LeftTechPoint != 0)
			{
				num ^= this.LeftTechPoint.GetHashCode();
			}
			if (this.LeftLevelUpPoint != 0)
			{
				num ^= this.LeftLevelUpPoint.GetHashCode();
			}
			if (this.TotalLevelUpPoint != 0)
			{
				num ^= this.TotalLevelUpPoint.GetHashCode();
			}
			num ^= this.unlockBdGroups_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601B28D RID: 111245 RVA: 0x003EF99C File Offset: 0x003EDB9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601B28E RID: 111246 RVA: 0x003EF9A9 File Offset: 0x003EDBA9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601B28F RID: 111247 RVA: 0x003EF9B4 File Offset: 0x003EDBB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.unlockTechNodes_.WriteTo(ref output, TrapDefenseActivityInfo._repeated_unlockTechNodes_codec);
			this.specialRewards_.WriteTo(ref output, TrapDefenseActivityInfo._repeated_specialRewards_codec);
			this.rewards_.WriteTo(ref output, TrapDefenseActivityInfo._repeated_rewards_codec);
			this.auxiliaries_.WriteTo(ref output, TrapDefenseActivityInfo._repeated_auxiliaries_codec);
			this.buildings_.WriteTo(ref output, TrapDefenseActivityInfo._repeated_buildings_codec);
			this.challenges_.WriteTo(ref output, TrapDefenseActivityInfo._repeated_challenges_codec);
			if (this.LimitBeginTime != 0L)
			{
				output.WriteRawTag(56);
				output.WriteInt64(this.LimitBeginTime);
			}
			if (this.LimitEndTime != 0L)
			{
				output.WriteRawTag(64);
				output.WriteInt64(this.LimitEndTime);
			}
			this.unlockBds_.WriteTo(ref output, TrapDefenseActivityInfo._repeated_unlockBds_codec);
			if (this.TotalTechPoint != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.TotalTechPoint);
			}
			if (this.LeftTechPoint != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.LeftTechPoint);
			}
			if (this.LeftLevelUpPoint != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.LeftLevelUpPoint);
			}
			if (this.TotalLevelUpPoint != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.TotalLevelUpPoint);
			}
			this.unlockBdGroups_.WriteTo(ref output, TrapDefenseActivityInfo._repeated_unlockBdGroups_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601B290 RID: 111248 RVA: 0x003EFB08 File Offset: 0x003EDD08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.unlockTechNodes_.CalculateSize(TrapDefenseActivityInfo._repeated_unlockTechNodes_codec);
			num += this.specialRewards_.CalculateSize(TrapDefenseActivityInfo._repeated_specialRewards_codec);
			num += this.rewards_.CalculateSize(TrapDefenseActivityInfo._repeated_rewards_codec);
			num += this.auxiliaries_.CalculateSize(TrapDefenseActivityInfo._repeated_auxiliaries_codec);
			num += this.buildings_.CalculateSize(TrapDefenseActivityInfo._repeated_buildings_codec);
			num += this.challenges_.CalculateSize(TrapDefenseActivityInfo._repeated_challenges_codec);
			if (this.LimitBeginTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.LimitBeginTime);
			}
			if (this.LimitEndTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.LimitEndTime);
			}
			num += this.unlockBds_.CalculateSize(TrapDefenseActivityInfo._repeated_unlockBds_codec);
			if (this.TotalTechPoint != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TotalTechPoint);
			}
			if (this.LeftTechPoint != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.LeftTechPoint);
			}
			if (this.LeftLevelUpPoint != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.LeftLevelUpPoint);
			}
			if (this.TotalLevelUpPoint != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TotalLevelUpPoint);
			}
			num += this.unlockBdGroups_.CalculateSize(TrapDefenseActivityInfo._repeated_unlockBdGroups_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601B291 RID: 111249 RVA: 0x003EFC58 File Offset: 0x003EDE58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TrapDefenseActivityInfo other)
		{
			if (other == null)
			{
				return;
			}
			this.unlockTechNodes_.Add(other.unlockTechNodes_);
			this.specialRewards_.Add(other.specialRewards_);
			this.rewards_.Add(other.rewards_);
			this.auxiliaries_.Add(other.auxiliaries_);
			this.buildings_.Add(other.buildings_);
			this.challenges_.Add(other.challenges_);
			if (other.LimitBeginTime != 0L)
			{
				this.LimitBeginTime = other.LimitBeginTime;
			}
			if (other.LimitEndTime != 0L)
			{
				this.LimitEndTime = other.LimitEndTime;
			}
			this.unlockBds_.Add(other.unlockBds_);
			if (other.TotalTechPoint != 0)
			{
				this.TotalTechPoint = other.TotalTechPoint;
			}
			if (other.LeftTechPoint != 0)
			{
				this.LeftTechPoint = other.LeftTechPoint;
			}
			if (other.LeftLevelUpPoint != 0)
			{
				this.LeftLevelUpPoint = other.LeftLevelUpPoint;
			}
			if (other.TotalLevelUpPoint != 0)
			{
				this.TotalLevelUpPoint = other.TotalLevelUpPoint;
			}
			this.unlockBdGroups_.Add(other.unlockBdGroups_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601B292 RID: 111250 RVA: 0x003EFD80 File Offset: 0x003EDF80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601B293 RID: 111251 RVA: 0x003EFD8C File Offset: 0x003EDF8C
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
				if (num <= 56U)
				{
					if (num <= 26U)
					{
						if (num <= 10U)
						{
							if (num == 8U || num == 10U)
							{
								this.unlockTechNodes_.AddEntriesFrom(ref input, TrapDefenseActivityInfo._repeated_unlockTechNodes_codec);
								continue;
							}
						}
						else
						{
							if (num == 18U)
							{
								this.specialRewards_.AddEntriesFrom(ref input, TrapDefenseActivityInfo._repeated_specialRewards_codec);
								continue;
							}
							if (num == 26U)
							{
								this.rewards_.AddEntriesFrom(ref input, TrapDefenseActivityInfo._repeated_rewards_codec);
								continue;
							}
						}
					}
					else if (num <= 42U)
					{
						if (num == 34U)
						{
							this.auxiliaries_.AddEntriesFrom(ref input, TrapDefenseActivityInfo._repeated_auxiliaries_codec);
							continue;
						}
						if (num == 42U)
						{
							this.buildings_.AddEntriesFrom(ref input, TrapDefenseActivityInfo._repeated_buildings_codec);
							continue;
						}
					}
					else
					{
						if (num == 50U)
						{
							this.challenges_.AddEntriesFrom(ref input, TrapDefenseActivityInfo._repeated_challenges_codec);
							continue;
						}
						if (num == 56U)
						{
							this.LimitBeginTime = input.ReadInt64();
							continue;
						}
					}
				}
				else
				{
					if (num <= 80U)
					{
						if (num <= 72U)
						{
							if (num == 64U)
							{
								this.LimitEndTime = input.ReadInt64();
								continue;
							}
							if (num != 72U)
							{
								goto IL_CA;
							}
						}
						else if (num != 74U)
						{
							if (num != 80U)
							{
								goto IL_CA;
							}
							this.TotalTechPoint = input.ReadInt32();
							continue;
						}
						this.unlockBds_.AddEntriesFrom(ref input, TrapDefenseActivityInfo._repeated_unlockBds_codec);
						continue;
					}
					if (num <= 96U)
					{
						if (num == 88U)
						{
							this.LeftTechPoint = input.ReadInt32();
							continue;
						}
						if (num == 96U)
						{
							this.LeftLevelUpPoint = input.ReadInt32();
							continue;
						}
					}
					else
					{
						if (num == 104U)
						{
							this.TotalLevelUpPoint = input.ReadInt32();
							continue;
						}
						if (num == 112U || num == 114U)
						{
							this.unlockBdGroups_.AddEntriesFrom(ref input, TrapDefenseActivityInfo._repeated_unlockBdGroups_codec);
							continue;
						}
					}
				}
				IL_CA:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04009D15 RID: 40213
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009D16 RID: 40214
		public const int UnlockTechNodesFieldNumber = 1;

		// Token: 0x04009D17 RID: 40215
		private static readonly FieldCodec<int> _repeated_unlockTechNodes_codec = FieldCodec.ForInt32(10U);

		// Token: 0x04009D18 RID: 40216
		private readonly RepeatedField<int> unlockTechNodes_ = new RepeatedField<int>();

		// Token: 0x04009D19 RID: 40217
		public const int SpecialRewardsFieldNumber = 2;

		// Token: 0x04009D1A RID: 40218
		private static readonly FieldCodec<TrapDefenseRewardInfo> _repeated_specialRewards_codec = FieldCodec.ForMessage<TrapDefenseRewardInfo>(18U, TrapDefenseRewardInfo.Parser);

		// Token: 0x04009D1B RID: 40219
		private readonly RepeatedField<TrapDefenseRewardInfo> specialRewards_ = new RepeatedField<TrapDefenseRewardInfo>();

		// Token: 0x04009D1C RID: 40220
		public const int RewardsFieldNumber = 3;

		// Token: 0x04009D1D RID: 40221
		private static readonly FieldCodec<TrapDefenseRewardInfo> _repeated_rewards_codec = FieldCodec.ForMessage<TrapDefenseRewardInfo>(26U, TrapDefenseRewardInfo.Parser);

		// Token: 0x04009D1E RID: 40222
		private readonly RepeatedField<TrapDefenseRewardInfo> rewards_ = new RepeatedField<TrapDefenseRewardInfo>();

		// Token: 0x04009D1F RID: 40223
		public const int AuxiliariesFieldNumber = 4;

		// Token: 0x04009D20 RID: 40224
		private static readonly FieldCodec<TrapDefenseAuxiliaryInfo> _repeated_auxiliaries_codec = FieldCodec.ForMessage<TrapDefenseAuxiliaryInfo>(34U, TrapDefenseAuxiliaryInfo.Parser);

		// Token: 0x04009D21 RID: 40225
		private readonly RepeatedField<TrapDefenseAuxiliaryInfo> auxiliaries_ = new RepeatedField<TrapDefenseAuxiliaryInfo>();

		// Token: 0x04009D22 RID: 40226
		public const int BuildingsFieldNumber = 5;

		// Token: 0x04009D23 RID: 40227
		private static readonly FieldCodec<TrapDefenseBuildingInfo> _repeated_buildings_codec = FieldCodec.ForMessage<TrapDefenseBuildingInfo>(42U, TrapDefenseBuildingInfo.Parser);

		// Token: 0x04009D24 RID: 40228
		private readonly RepeatedField<TrapDefenseBuildingInfo> buildings_ = new RepeatedField<TrapDefenseBuildingInfo>();

		// Token: 0x04009D25 RID: 40229
		public const int ChallengesFieldNumber = 6;

		// Token: 0x04009D26 RID: 40230
		private static readonly FieldCodec<TrapDefenseChallengeInfo> _repeated_challenges_codec = FieldCodec.ForMessage<TrapDefenseChallengeInfo>(50U, TrapDefenseChallengeInfo.Parser);

		// Token: 0x04009D27 RID: 40231
		private readonly RepeatedField<TrapDefenseChallengeInfo> challenges_ = new RepeatedField<TrapDefenseChallengeInfo>();

		// Token: 0x04009D28 RID: 40232
		public const int LimitBeginTimeFieldNumber = 7;

		// Token: 0x04009D29 RID: 40233
		private long limitBeginTime_;

		// Token: 0x04009D2A RID: 40234
		public const int LimitEndTimeFieldNumber = 8;

		// Token: 0x04009D2B RID: 40235
		private long limitEndTime_;

		// Token: 0x04009D2C RID: 40236
		public const int UnlockBdsFieldNumber = 9;

		// Token: 0x04009D2D RID: 40237
		private static readonly FieldCodec<int> _repeated_unlockBds_codec = FieldCodec.ForInt32(74U);

		// Token: 0x04009D2E RID: 40238
		private readonly RepeatedField<int> unlockBds_ = new RepeatedField<int>();

		// Token: 0x04009D2F RID: 40239
		public const int TotalTechPointFieldNumber = 10;

		// Token: 0x04009D30 RID: 40240
		private int totalTechPoint_;

		// Token: 0x04009D31 RID: 40241
		public const int LeftTechPointFieldNumber = 11;

		// Token: 0x04009D32 RID: 40242
		private int leftTechPoint_;

		// Token: 0x04009D33 RID: 40243
		public const int LeftLevelUpPointFieldNumber = 12;

		// Token: 0x04009D34 RID: 40244
		private int leftLevelUpPoint_;

		// Token: 0x04009D35 RID: 40245
		public const int TotalLevelUpPointFieldNumber = 13;

		// Token: 0x04009D36 RID: 40246
		private int totalLevelUpPoint_;

		// Token: 0x04009D37 RID: 40247
		public const int UnlockBdGroupsFieldNumber = 14;

		// Token: 0x04009D38 RID: 40248
		private static readonly FieldCodec<int> _repeated_unlockBdGroups_codec = FieldCodec.ForInt32(114U);

		// Token: 0x04009D39 RID: 40249
		private readonly RepeatedField<int> unlockBdGroups_ = new RepeatedField<int>();
	}
}
