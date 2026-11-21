using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001475 RID: 5237
	public sealed class TrapDefenseActivityInfo : IMessage<TrapDefenseActivityInfo>, IMessage, IEquatable<TrapDefenseActivityInfo>, IDeepCloneable<TrapDefenseActivityInfo>, IBufferMessage
	{
		// Token: 0x0601BCFB RID: 113915 RVA: 0x0040A7E3 File Offset: 0x004089E3
		[NullableContext(1)]
		public static TrapDefenseActivityInfo Create()
		{
			return new TrapDefenseActivityInfo();
		}

		// Token: 0x17005E25 RID: 24101
		// (get) Token: 0x0601BCFC RID: 113916 RVA: 0x0040A7EA File Offset: 0x004089EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005E26 RID: 24102
		// (get) Token: 0x0601BCFD RID: 113917 RVA: 0x0040A7ED File Offset: 0x004089ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TrapDefenseActivityInfo.Descriptor;
			}
		}

		// Token: 0x0601BCFE RID: 113918 RVA: 0x0040A7F4 File Offset: 0x004089F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseActivityInfo()
		{
		}

		// Token: 0x0601BCFF RID: 113919 RVA: 0x0040A860 File Offset: 0x00408A60
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

		// Token: 0x0601BD00 RID: 113920 RVA: 0x0040A954 File Offset: 0x00408B54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseActivityInfo Clone()
		{
			return new TrapDefenseActivityInfo(this);
		}

		// Token: 0x17005E27 RID: 24103
		// (get) Token: 0x0601BD01 RID: 113921 RVA: 0x0040A95C File Offset: 0x00408B5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> UnlockTechNodes
		{
			get
			{
				return this.unlockTechNodes_;
			}
		}

		// Token: 0x17005E28 RID: 24104
		// (get) Token: 0x0601BD02 RID: 113922 RVA: 0x0040A964 File Offset: 0x00408B64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<TrapDefenseRewardInfo> SpecialRewards
		{
			get
			{
				return this.specialRewards_;
			}
		}

		// Token: 0x17005E29 RID: 24105
		// (get) Token: 0x0601BD03 RID: 113923 RVA: 0x0040A96C File Offset: 0x00408B6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<TrapDefenseRewardInfo> Rewards
		{
			get
			{
				return this.rewards_;
			}
		}

		// Token: 0x17005E2A RID: 24106
		// (get) Token: 0x0601BD04 RID: 113924 RVA: 0x0040A974 File Offset: 0x00408B74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<TrapDefenseAuxiliaryInfo> Auxiliaries
		{
			get
			{
				return this.auxiliaries_;
			}
		}

		// Token: 0x17005E2B RID: 24107
		// (get) Token: 0x0601BD05 RID: 113925 RVA: 0x0040A97C File Offset: 0x00408B7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<TrapDefenseBuildingInfo> Buildings
		{
			get
			{
				return this.buildings_;
			}
		}

		// Token: 0x17005E2C RID: 24108
		// (get) Token: 0x0601BD06 RID: 113926 RVA: 0x0040A984 File Offset: 0x00408B84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<TrapDefenseChallengeInfo> Challenges
		{
			get
			{
				return this.challenges_;
			}
		}

		// Token: 0x17005E2D RID: 24109
		// (get) Token: 0x0601BD07 RID: 113927 RVA: 0x0040A98C File Offset: 0x00408B8C
		// (set) Token: 0x0601BD08 RID: 113928 RVA: 0x0040A994 File Offset: 0x00408B94
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

		// Token: 0x17005E2E RID: 24110
		// (get) Token: 0x0601BD09 RID: 113929 RVA: 0x0040A99D File Offset: 0x00408B9D
		// (set) Token: 0x0601BD0A RID: 113930 RVA: 0x0040A9A5 File Offset: 0x00408BA5
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

		// Token: 0x17005E2F RID: 24111
		// (get) Token: 0x0601BD0B RID: 113931 RVA: 0x0040A9AE File Offset: 0x00408BAE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> UnlockBds
		{
			get
			{
				return this.unlockBds_;
			}
		}

		// Token: 0x17005E30 RID: 24112
		// (get) Token: 0x0601BD0C RID: 113932 RVA: 0x0040A9B6 File Offset: 0x00408BB6
		// (set) Token: 0x0601BD0D RID: 113933 RVA: 0x0040A9BE File Offset: 0x00408BBE
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

		// Token: 0x17005E31 RID: 24113
		// (get) Token: 0x0601BD0E RID: 113934 RVA: 0x0040A9C7 File Offset: 0x00408BC7
		// (set) Token: 0x0601BD0F RID: 113935 RVA: 0x0040A9CF File Offset: 0x00408BCF
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

		// Token: 0x17005E32 RID: 24114
		// (get) Token: 0x0601BD10 RID: 113936 RVA: 0x0040A9D8 File Offset: 0x00408BD8
		// (set) Token: 0x0601BD11 RID: 113937 RVA: 0x0040A9E0 File Offset: 0x00408BE0
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

		// Token: 0x17005E33 RID: 24115
		// (get) Token: 0x0601BD12 RID: 113938 RVA: 0x0040A9E9 File Offset: 0x00408BE9
		// (set) Token: 0x0601BD13 RID: 113939 RVA: 0x0040A9F1 File Offset: 0x00408BF1
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

		// Token: 0x17005E34 RID: 24116
		// (get) Token: 0x0601BD14 RID: 113940 RVA: 0x0040A9FA File Offset: 0x00408BFA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> UnlockBdGroups
		{
			get
			{
				return this.unlockBdGroups_;
			}
		}

		// Token: 0x0601BD15 RID: 113941 RVA: 0x0040AA02 File Offset: 0x00408C02
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TrapDefenseActivityInfo);
		}

		// Token: 0x0601BD16 RID: 113942 RVA: 0x0040AA10 File Offset: 0x00408C10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TrapDefenseActivityInfo other)
		{
			return other != null && (other == this || (this.unlockTechNodes_.Equals(other.unlockTechNodes_) && this.specialRewards_.Equals(other.specialRewards_) && this.rewards_.Equals(other.rewards_) && this.auxiliaries_.Equals(other.auxiliaries_) && this.buildings_.Equals(other.buildings_) && this.challenges_.Equals(other.challenges_) && this.LimitBeginTime == other.LimitBeginTime && this.LimitEndTime == other.LimitEndTime && this.unlockBds_.Equals(other.unlockBds_) && this.TotalTechPoint == other.TotalTechPoint && this.LeftTechPoint == other.LeftTechPoint && this.LeftLevelUpPoint == other.LeftLevelUpPoint && this.TotalLevelUpPoint == other.TotalLevelUpPoint && this.unlockBdGroups_.Equals(other.unlockBdGroups_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601BD17 RID: 113943 RVA: 0x0040AB44 File Offset: 0x00408D44
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

		// Token: 0x0601BD18 RID: 113944 RVA: 0x0040AC70 File Offset: 0x00408E70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601BD19 RID: 113945 RVA: 0x0040AC7D File Offset: 0x00408E7D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601BD1A RID: 113946 RVA: 0x0040AC88 File Offset: 0x00408E88
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

		// Token: 0x0601BD1B RID: 113947 RVA: 0x0040ADDC File Offset: 0x00408FDC
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

		// Token: 0x0601BD1C RID: 113948 RVA: 0x0040AF2C File Offset: 0x0040912C
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

		// Token: 0x0601BD1D RID: 113949 RVA: 0x0040B054 File Offset: 0x00409254
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601BD1E RID: 113950 RVA: 0x0040B060 File Offset: 0x00409260
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

		// Token: 0x0400A15C RID: 41308
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A15D RID: 41309
		public const int UnlockTechNodesFieldNumber = 1;

		// Token: 0x0400A15E RID: 41310
		private static readonly FieldCodec<int> _repeated_unlockTechNodes_codec = FieldCodec.ForInt32(10U);

		// Token: 0x0400A15F RID: 41311
		private readonly RepeatedField<int> unlockTechNodes_ = new RepeatedField<int>();

		// Token: 0x0400A160 RID: 41312
		public const int SpecialRewardsFieldNumber = 2;

		// Token: 0x0400A161 RID: 41313
		private static readonly FieldCodec<TrapDefenseRewardInfo> _repeated_specialRewards_codec = FieldCodec.ForMessage<TrapDefenseRewardInfo>(18U, TrapDefenseRewardInfo.Parser);

		// Token: 0x0400A162 RID: 41314
		private readonly RepeatedField<TrapDefenseRewardInfo> specialRewards_ = new RepeatedField<TrapDefenseRewardInfo>();

		// Token: 0x0400A163 RID: 41315
		public const int RewardsFieldNumber = 3;

		// Token: 0x0400A164 RID: 41316
		private static readonly FieldCodec<TrapDefenseRewardInfo> _repeated_rewards_codec = FieldCodec.ForMessage<TrapDefenseRewardInfo>(26U, TrapDefenseRewardInfo.Parser);

		// Token: 0x0400A165 RID: 41317
		private readonly RepeatedField<TrapDefenseRewardInfo> rewards_ = new RepeatedField<TrapDefenseRewardInfo>();

		// Token: 0x0400A166 RID: 41318
		public const int AuxiliariesFieldNumber = 4;

		// Token: 0x0400A167 RID: 41319
		private static readonly FieldCodec<TrapDefenseAuxiliaryInfo> _repeated_auxiliaries_codec = FieldCodec.ForMessage<TrapDefenseAuxiliaryInfo>(34U, TrapDefenseAuxiliaryInfo.Parser);

		// Token: 0x0400A168 RID: 41320
		private readonly RepeatedField<TrapDefenseAuxiliaryInfo> auxiliaries_ = new RepeatedField<TrapDefenseAuxiliaryInfo>();

		// Token: 0x0400A169 RID: 41321
		public const int BuildingsFieldNumber = 5;

		// Token: 0x0400A16A RID: 41322
		private static readonly FieldCodec<TrapDefenseBuildingInfo> _repeated_buildings_codec = FieldCodec.ForMessage<TrapDefenseBuildingInfo>(42U, TrapDefenseBuildingInfo.Parser);

		// Token: 0x0400A16B RID: 41323
		private readonly RepeatedField<TrapDefenseBuildingInfo> buildings_ = new RepeatedField<TrapDefenseBuildingInfo>();

		// Token: 0x0400A16C RID: 41324
		public const int ChallengesFieldNumber = 6;

		// Token: 0x0400A16D RID: 41325
		private static readonly FieldCodec<TrapDefenseChallengeInfo> _repeated_challenges_codec = FieldCodec.ForMessage<TrapDefenseChallengeInfo>(50U, TrapDefenseChallengeInfo.Parser);

		// Token: 0x0400A16E RID: 41326
		private readonly RepeatedField<TrapDefenseChallengeInfo> challenges_ = new RepeatedField<TrapDefenseChallengeInfo>();

		// Token: 0x0400A16F RID: 41327
		public const int LimitBeginTimeFieldNumber = 7;

		// Token: 0x0400A170 RID: 41328
		private long limitBeginTime_;

		// Token: 0x0400A171 RID: 41329
		public const int LimitEndTimeFieldNumber = 8;

		// Token: 0x0400A172 RID: 41330
		private long limitEndTime_;

		// Token: 0x0400A173 RID: 41331
		public const int UnlockBdsFieldNumber = 9;

		// Token: 0x0400A174 RID: 41332
		private static readonly FieldCodec<int> _repeated_unlockBds_codec = FieldCodec.ForInt32(74U);

		// Token: 0x0400A175 RID: 41333
		private readonly RepeatedField<int> unlockBds_ = new RepeatedField<int>();

		// Token: 0x0400A176 RID: 41334
		public const int TotalTechPointFieldNumber = 10;

		// Token: 0x0400A177 RID: 41335
		private int totalTechPoint_;

		// Token: 0x0400A178 RID: 41336
		public const int LeftTechPointFieldNumber = 11;

		// Token: 0x0400A179 RID: 41337
		private int leftTechPoint_;

		// Token: 0x0400A17A RID: 41338
		public const int LeftLevelUpPointFieldNumber = 12;

		// Token: 0x0400A17B RID: 41339
		private int leftLevelUpPoint_;

		// Token: 0x0400A17C RID: 41340
		public const int TotalLevelUpPointFieldNumber = 13;

		// Token: 0x0400A17D RID: 41341
		private int totalLevelUpPoint_;

		// Token: 0x0400A17E RID: 41342
		public const int UnlockBdGroupsFieldNumber = 14;

		// Token: 0x0400A17F RID: 41343
		private static readonly FieldCodec<int> _repeated_unlockBdGroups_codec = FieldCodec.ForInt32(114U);

		// Token: 0x0400A180 RID: 41344
		private readonly RepeatedField<int> unlockBdGroups_ = new RepeatedField<int>();
	}
}
