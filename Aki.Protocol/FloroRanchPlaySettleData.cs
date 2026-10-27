using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020005CC RID: 1484
	public sealed class FloroRanchPlaySettleData : IMessage<FloroRanchPlaySettleData>, IMessage, IEquatable<FloroRanchPlaySettleData>, IDeepCloneable<FloroRanchPlaySettleData>, IBufferMessage
	{
		// Token: 0x0600891A RID: 35098 RVA: 0x0014A58F File Offset: 0x0014878F
		[NullableContext(1)]
		public static FloroRanchPlaySettleData Create()
		{
			return new FloroRanchPlaySettleData();
		}

		// Token: 0x17001AE7 RID: 6887
		// (get) Token: 0x0600891B RID: 35099 RVA: 0x0014A596 File Offset: 0x00148796
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001AE8 RID: 6888
		// (get) Token: 0x0600891C RID: 35100 RVA: 0x0014A599 File Offset: 0x00148799
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FloroRanchPlaySettleData.Descriptor;
			}
		}

		// Token: 0x0600891D RID: 35101 RVA: 0x0014A5A0 File Offset: 0x001487A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchPlaySettleData()
		{
		}

		// Token: 0x0600891E RID: 35102 RVA: 0x0014A5C0 File Offset: 0x001487C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchPlaySettleData(FloroRanchPlaySettleData other) : this()
		{
			this.techNum_ = other.techNum_;
			this.allowedTechUp_ = other.allowedTechUp_;
			this.totalDays_ = other.totalDays_;
			this.isNewMaxDays_ = other.isNewMaxDays_;
			this.totalCoin_ = other.totalCoin_;
			this.isNewMaxCoin_ = other.isNewMaxCoin_;
			this.maxDayCoin_ = other.maxDayCoin_;
			this.championConfigId_ = other.championConfigId_;
			this.championTotalCoinNum_ = other.championTotalCoinNum_;
			this.win_ = other.win_;
			this.isUnlimited_ = other.isUnlimited_;
			this.enableUnlimitedMode_ = other.enableUnlimitedMode_;
			this.reward_ = other.reward_.Clone();
			this.forceSettleTextKey_ = other.forceSettleTextKey_;
			this.curWeeklyScoreNum_ = other.curWeeklyScoreNum_;
			this.rewardWeeklyScoreNum_ = other.rewardWeeklyScoreNum_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600891F RID: 35103 RVA: 0x0014A6A9 File Offset: 0x001488A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchPlaySettleData Clone()
		{
			return new FloroRanchPlaySettleData(this);
		}

		// Token: 0x17001AE9 RID: 6889
		// (get) Token: 0x06008920 RID: 35104 RVA: 0x0014A6B1 File Offset: 0x001488B1
		// (set) Token: 0x06008921 RID: 35105 RVA: 0x0014A6B9 File Offset: 0x001488B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TechNum
		{
			get
			{
				return this.techNum_;
			}
			set
			{
				this.techNum_ = value;
			}
		}

		// Token: 0x17001AEA RID: 6890
		// (get) Token: 0x06008922 RID: 35106 RVA: 0x0014A6C2 File Offset: 0x001488C2
		// (set) Token: 0x06008923 RID: 35107 RVA: 0x0014A6CA File Offset: 0x001488CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool AllowedTechUp
		{
			get
			{
				return this.allowedTechUp_;
			}
			set
			{
				this.allowedTechUp_ = value;
			}
		}

		// Token: 0x17001AEB RID: 6891
		// (get) Token: 0x06008924 RID: 35108 RVA: 0x0014A6D3 File Offset: 0x001488D3
		// (set) Token: 0x06008925 RID: 35109 RVA: 0x0014A6DB File Offset: 0x001488DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TotalDays
		{
			get
			{
				return this.totalDays_;
			}
			set
			{
				this.totalDays_ = value;
			}
		}

		// Token: 0x17001AEC RID: 6892
		// (get) Token: 0x06008926 RID: 35110 RVA: 0x0014A6E4 File Offset: 0x001488E4
		// (set) Token: 0x06008927 RID: 35111 RVA: 0x0014A6EC File Offset: 0x001488EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsNewMaxDays
		{
			get
			{
				return this.isNewMaxDays_;
			}
			set
			{
				this.isNewMaxDays_ = value;
			}
		}

		// Token: 0x17001AED RID: 6893
		// (get) Token: 0x06008928 RID: 35112 RVA: 0x0014A6F5 File Offset: 0x001488F5
		// (set) Token: 0x06008929 RID: 35113 RVA: 0x0014A6FD File Offset: 0x001488FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long TotalCoin
		{
			get
			{
				return this.totalCoin_;
			}
			set
			{
				this.totalCoin_ = value;
			}
		}

		// Token: 0x17001AEE RID: 6894
		// (get) Token: 0x0600892A RID: 35114 RVA: 0x0014A706 File Offset: 0x00148906
		// (set) Token: 0x0600892B RID: 35115 RVA: 0x0014A70E File Offset: 0x0014890E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsNewMaxCoin
		{
			get
			{
				return this.isNewMaxCoin_;
			}
			set
			{
				this.isNewMaxCoin_ = value;
			}
		}

		// Token: 0x17001AEF RID: 6895
		// (get) Token: 0x0600892C RID: 35116 RVA: 0x0014A717 File Offset: 0x00148917
		// (set) Token: 0x0600892D RID: 35117 RVA: 0x0014A71F File Offset: 0x0014891F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long MaxDayCoin
		{
			get
			{
				return this.maxDayCoin_;
			}
			set
			{
				this.maxDayCoin_ = value;
			}
		}

		// Token: 0x17001AF0 RID: 6896
		// (get) Token: 0x0600892E RID: 35118 RVA: 0x0014A728 File Offset: 0x00148928
		// (set) Token: 0x0600892F RID: 35119 RVA: 0x0014A730 File Offset: 0x00148930
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ChampionConfigId
		{
			get
			{
				return this.championConfigId_;
			}
			set
			{
				this.championConfigId_ = value;
			}
		}

		// Token: 0x17001AF1 RID: 6897
		// (get) Token: 0x06008930 RID: 35120 RVA: 0x0014A739 File Offset: 0x00148939
		// (set) Token: 0x06008931 RID: 35121 RVA: 0x0014A741 File Offset: 0x00148941
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long ChampionTotalCoinNum
		{
			get
			{
				return this.championTotalCoinNum_;
			}
			set
			{
				this.championTotalCoinNum_ = value;
			}
		}

		// Token: 0x17001AF2 RID: 6898
		// (get) Token: 0x06008932 RID: 35122 RVA: 0x0014A74A File Offset: 0x0014894A
		// (set) Token: 0x06008933 RID: 35123 RVA: 0x0014A752 File Offset: 0x00148952
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Win
		{
			get
			{
				return this.win_;
			}
			set
			{
				this.win_ = value;
			}
		}

		// Token: 0x17001AF3 RID: 6899
		// (get) Token: 0x06008934 RID: 35124 RVA: 0x0014A75B File Offset: 0x0014895B
		// (set) Token: 0x06008935 RID: 35125 RVA: 0x0014A763 File Offset: 0x00148963
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsUnlimited
		{
			get
			{
				return this.isUnlimited_;
			}
			set
			{
				this.isUnlimited_ = value;
			}
		}

		// Token: 0x17001AF4 RID: 6900
		// (get) Token: 0x06008936 RID: 35126 RVA: 0x0014A76C File Offset: 0x0014896C
		// (set) Token: 0x06008937 RID: 35127 RVA: 0x0014A774 File Offset: 0x00148974
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool EnableUnlimitedMode
		{
			get
			{
				return this.enableUnlimitedMode_;
			}
			set
			{
				this.enableUnlimitedMode_ = value;
			}
		}

		// Token: 0x17001AF5 RID: 6901
		// (get) Token: 0x06008938 RID: 35128 RVA: 0x0014A77D File Offset: 0x0014897D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<FloroRanchSubInsSettleReward> Reward
		{
			get
			{
				return this.reward_;
			}
		}

		// Token: 0x17001AF6 RID: 6902
		// (get) Token: 0x06008939 RID: 35129 RVA: 0x0014A785 File Offset: 0x00148985
		// (set) Token: 0x0600893A RID: 35130 RVA: 0x0014A78D File Offset: 0x0014898D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string ForceSettleTextKey
		{
			get
			{
				return this.forceSettleTextKey_;
			}
			set
			{
				this.forceSettleTextKey_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17001AF7 RID: 6903
		// (get) Token: 0x0600893B RID: 35131 RVA: 0x0014A7A0 File Offset: 0x001489A0
		// (set) Token: 0x0600893C RID: 35132 RVA: 0x0014A7A8 File Offset: 0x001489A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CurWeeklyScoreNum
		{
			get
			{
				return this.curWeeklyScoreNum_;
			}
			set
			{
				this.curWeeklyScoreNum_ = value;
			}
		}

		// Token: 0x17001AF8 RID: 6904
		// (get) Token: 0x0600893D RID: 35133 RVA: 0x0014A7B1 File Offset: 0x001489B1
		// (set) Token: 0x0600893E RID: 35134 RVA: 0x0014A7B9 File Offset: 0x001489B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RewardWeeklyScoreNum
		{
			get
			{
				return this.rewardWeeklyScoreNum_;
			}
			set
			{
				this.rewardWeeklyScoreNum_ = value;
			}
		}

		// Token: 0x0600893F RID: 35135 RVA: 0x0014A7C2 File Offset: 0x001489C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FloroRanchPlaySettleData);
		}

		// Token: 0x06008940 RID: 35136 RVA: 0x0014A7D0 File Offset: 0x001489D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FloroRanchPlaySettleData other)
		{
			return other != null && (other == this || (this.TechNum == other.TechNum && this.AllowedTechUp == other.AllowedTechUp && this.TotalDays == other.TotalDays && this.IsNewMaxDays == other.IsNewMaxDays && this.TotalCoin == other.TotalCoin && this.IsNewMaxCoin == other.IsNewMaxCoin && this.MaxDayCoin == other.MaxDayCoin && this.ChampionConfigId == other.ChampionConfigId && this.ChampionTotalCoinNum == other.ChampionTotalCoinNum && this.Win == other.Win && this.IsUnlimited == other.IsUnlimited && this.EnableUnlimitedMode == other.EnableUnlimitedMode && this.reward_.Equals(other.reward_) && !(this.ForceSettleTextKey != other.ForceSettleTextKey) && this.CurWeeklyScoreNum == other.CurWeeklyScoreNum && this.RewardWeeklyScoreNum == other.RewardWeeklyScoreNum && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008941 RID: 35137 RVA: 0x0014A904 File Offset: 0x00148B04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.TechNum != 0)
			{
				num ^= this.TechNum.GetHashCode();
			}
			if (this.AllowedTechUp)
			{
				num ^= this.AllowedTechUp.GetHashCode();
			}
			if (this.TotalDays != 0)
			{
				num ^= this.TotalDays.GetHashCode();
			}
			if (this.IsNewMaxDays)
			{
				num ^= this.IsNewMaxDays.GetHashCode();
			}
			if (this.TotalCoin != 0L)
			{
				num ^= this.TotalCoin.GetHashCode();
			}
			if (this.IsNewMaxCoin)
			{
				num ^= this.IsNewMaxCoin.GetHashCode();
			}
			if (this.MaxDayCoin != 0L)
			{
				num ^= this.MaxDayCoin.GetHashCode();
			}
			if (this.ChampionConfigId != 0)
			{
				num ^= this.ChampionConfigId.GetHashCode();
			}
			if (this.ChampionTotalCoinNum != 0L)
			{
				num ^= this.ChampionTotalCoinNum.GetHashCode();
			}
			if (this.Win)
			{
				num ^= this.Win.GetHashCode();
			}
			if (this.IsUnlimited)
			{
				num ^= this.IsUnlimited.GetHashCode();
			}
			if (this.EnableUnlimitedMode)
			{
				num ^= this.EnableUnlimitedMode.GetHashCode();
			}
			num ^= this.reward_.GetHashCode();
			if (this.ForceSettleTextKey.Length != 0)
			{
				num ^= this.ForceSettleTextKey.GetHashCode();
			}
			if (this.CurWeeklyScoreNum != 0)
			{
				num ^= this.CurWeeklyScoreNum.GetHashCode();
			}
			if (this.RewardWeeklyScoreNum != 0)
			{
				num ^= this.RewardWeeklyScoreNum.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008942 RID: 35138 RVA: 0x0014AAB1 File Offset: 0x00148CB1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06008943 RID: 35139 RVA: 0x0014AABE File Offset: 0x00148CBE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008944 RID: 35140 RVA: 0x0014AAC8 File Offset: 0x00148CC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TechNum != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.TechNum);
			}
			if (this.AllowedTechUp)
			{
				output.WriteRawTag(16);
				output.WriteBool(this.AllowedTechUp);
			}
			if (this.TotalDays != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.TotalDays);
			}
			if (this.IsNewMaxDays)
			{
				output.WriteRawTag(32);
				output.WriteBool(this.IsNewMaxDays);
			}
			if (this.TotalCoin != 0L)
			{
				output.WriteRawTag(40);
				output.WriteInt64(this.TotalCoin);
			}
			if (this.IsNewMaxCoin)
			{
				output.WriteRawTag(48);
				output.WriteBool(this.IsNewMaxCoin);
			}
			if (this.MaxDayCoin != 0L)
			{
				output.WriteRawTag(56);
				output.WriteInt64(this.MaxDayCoin);
			}
			if (this.ChampionConfigId != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.ChampionConfigId);
			}
			if (this.ChampionTotalCoinNum != 0L)
			{
				output.WriteRawTag(72);
				output.WriteInt64(this.ChampionTotalCoinNum);
			}
			if (this.Win)
			{
				output.WriteRawTag(80);
				output.WriteBool(this.Win);
			}
			if (this.IsUnlimited)
			{
				output.WriteRawTag(88);
				output.WriteBool(this.IsUnlimited);
			}
			if (this.EnableUnlimitedMode)
			{
				output.WriteRawTag(96);
				output.WriteBool(this.EnableUnlimitedMode);
			}
			this.reward_.WriteTo(ref output, FloroRanchPlaySettleData._repeated_reward_codec);
			if (this.ForceSettleTextKey.Length != 0)
			{
				output.WriteRawTag(114);
				output.WriteString(this.ForceSettleTextKey);
			}
			if (this.CurWeeklyScoreNum != 0)
			{
				output.WriteRawTag(120);
				output.WriteInt32(this.CurWeeklyScoreNum);
			}
			if (this.RewardWeeklyScoreNum != 0)
			{
				output.WriteRawTag(128, 1);
				output.WriteInt32(this.RewardWeeklyScoreNum);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008945 RID: 35141 RVA: 0x0014ACA8 File Offset: 0x00148EA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.TechNum != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TechNum);
			}
			if (this.AllowedTechUp)
			{
				num += 2;
			}
			if (this.TotalDays != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TotalDays);
			}
			if (this.IsNewMaxDays)
			{
				num += 2;
			}
			if (this.TotalCoin != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.TotalCoin);
			}
			if (this.IsNewMaxCoin)
			{
				num += 2;
			}
			if (this.MaxDayCoin != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.MaxDayCoin);
			}
			if (this.ChampionConfigId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ChampionConfigId);
			}
			if (this.ChampionTotalCoinNum != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.ChampionTotalCoinNum);
			}
			if (this.Win)
			{
				num += 2;
			}
			if (this.IsUnlimited)
			{
				num += 2;
			}
			if (this.EnableUnlimitedMode)
			{
				num += 2;
			}
			num += this.reward_.CalculateSize(FloroRanchPlaySettleData._repeated_reward_codec);
			if (this.ForceSettleTextKey.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.ForceSettleTextKey);
			}
			if (this.CurWeeklyScoreNum != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CurWeeklyScoreNum);
			}
			if (this.RewardWeeklyScoreNum != 0)
			{
				num += 2 + CodedOutputStream.ComputeInt32Size(this.RewardWeeklyScoreNum);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008946 RID: 35142 RVA: 0x0014AE08 File Offset: 0x00149008
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FloroRanchPlaySettleData other)
		{
			if (other == null)
			{
				return;
			}
			if (other.TechNum != 0)
			{
				this.TechNum = other.TechNum;
			}
			if (other.AllowedTechUp)
			{
				this.AllowedTechUp = other.AllowedTechUp;
			}
			if (other.TotalDays != 0)
			{
				this.TotalDays = other.TotalDays;
			}
			if (other.IsNewMaxDays)
			{
				this.IsNewMaxDays = other.IsNewMaxDays;
			}
			if (other.TotalCoin != 0L)
			{
				this.TotalCoin = other.TotalCoin;
			}
			if (other.IsNewMaxCoin)
			{
				this.IsNewMaxCoin = other.IsNewMaxCoin;
			}
			if (other.MaxDayCoin != 0L)
			{
				this.MaxDayCoin = other.MaxDayCoin;
			}
			if (other.ChampionConfigId != 0)
			{
				this.ChampionConfigId = other.ChampionConfigId;
			}
			if (other.ChampionTotalCoinNum != 0L)
			{
				this.ChampionTotalCoinNum = other.ChampionTotalCoinNum;
			}
			if (other.Win)
			{
				this.Win = other.Win;
			}
			if (other.IsUnlimited)
			{
				this.IsUnlimited = other.IsUnlimited;
			}
			if (other.EnableUnlimitedMode)
			{
				this.EnableUnlimitedMode = other.EnableUnlimitedMode;
			}
			this.reward_.Add(other.reward_);
			if (other.ForceSettleTextKey.Length != 0)
			{
				this.ForceSettleTextKey = other.ForceSettleTextKey;
			}
			if (other.CurWeeklyScoreNum != 0)
			{
				this.CurWeeklyScoreNum = other.CurWeeklyScoreNum;
			}
			if (other.RewardWeeklyScoreNum != 0)
			{
				this.RewardWeeklyScoreNum = other.RewardWeeklyScoreNum;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06008947 RID: 35143 RVA: 0x0014AF72 File Offset: 0x00149172
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008948 RID: 35144 RVA: 0x0014AF7C File Offset: 0x0014917C
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
				if (num <= 64U)
				{
					if (num <= 32U)
					{
						if (num <= 16U)
						{
							if (num == 8U)
							{
								this.TechNum = input.ReadInt32();
								continue;
							}
							if (num == 16U)
							{
								this.AllowedTechUp = input.ReadBool();
								continue;
							}
						}
						else
						{
							if (num == 24U)
							{
								this.TotalDays = input.ReadInt32();
								continue;
							}
							if (num == 32U)
							{
								this.IsNewMaxDays = input.ReadBool();
								continue;
							}
						}
					}
					else if (num <= 48U)
					{
						if (num == 40U)
						{
							this.TotalCoin = input.ReadInt64();
							continue;
						}
						if (num == 48U)
						{
							this.IsNewMaxCoin = input.ReadBool();
							continue;
						}
					}
					else
					{
						if (num == 56U)
						{
							this.MaxDayCoin = input.ReadInt64();
							continue;
						}
						if (num == 64U)
						{
							this.ChampionConfigId = input.ReadInt32();
							continue;
						}
					}
				}
				else if (num <= 96U)
				{
					if (num <= 80U)
					{
						if (num == 72U)
						{
							this.ChampionTotalCoinNum = input.ReadInt64();
							continue;
						}
						if (num == 80U)
						{
							this.Win = input.ReadBool();
							continue;
						}
					}
					else
					{
						if (num == 88U)
						{
							this.IsUnlimited = input.ReadBool();
							continue;
						}
						if (num == 96U)
						{
							this.EnableUnlimitedMode = input.ReadBool();
							continue;
						}
					}
				}
				else if (num <= 114U)
				{
					if (num == 106U)
					{
						this.reward_.AddEntriesFrom(ref input, FloroRanchPlaySettleData._repeated_reward_codec);
						continue;
					}
					if (num == 114U)
					{
						this.ForceSettleTextKey = input.ReadString();
						continue;
					}
				}
				else
				{
					if (num == 120U)
					{
						this.CurWeeklyScoreNum = input.ReadInt32();
						continue;
					}
					if (num == 128U)
					{
						this.RewardWeeklyScoreNum = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04004368 RID: 17256
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004369 RID: 17257
		public const int TechNumFieldNumber = 1;

		// Token: 0x0400436A RID: 17258
		private int techNum_;

		// Token: 0x0400436B RID: 17259
		public const int AllowedTechUpFieldNumber = 2;

		// Token: 0x0400436C RID: 17260
		private bool allowedTechUp_;

		// Token: 0x0400436D RID: 17261
		public const int TotalDaysFieldNumber = 3;

		// Token: 0x0400436E RID: 17262
		private int totalDays_;

		// Token: 0x0400436F RID: 17263
		public const int IsNewMaxDaysFieldNumber = 4;

		// Token: 0x04004370 RID: 17264
		private bool isNewMaxDays_;

		// Token: 0x04004371 RID: 17265
		public const int TotalCoinFieldNumber = 5;

		// Token: 0x04004372 RID: 17266
		private long totalCoin_;

		// Token: 0x04004373 RID: 17267
		public const int IsNewMaxCoinFieldNumber = 6;

		// Token: 0x04004374 RID: 17268
		private bool isNewMaxCoin_;

		// Token: 0x04004375 RID: 17269
		public const int MaxDayCoinFieldNumber = 7;

		// Token: 0x04004376 RID: 17270
		private long maxDayCoin_;

		// Token: 0x04004377 RID: 17271
		public const int ChampionConfigIdFieldNumber = 8;

		// Token: 0x04004378 RID: 17272
		private int championConfigId_;

		// Token: 0x04004379 RID: 17273
		public const int ChampionTotalCoinNumFieldNumber = 9;

		// Token: 0x0400437A RID: 17274
		private long championTotalCoinNum_;

		// Token: 0x0400437B RID: 17275
		public const int WinFieldNumber = 10;

		// Token: 0x0400437C RID: 17276
		private bool win_;

		// Token: 0x0400437D RID: 17277
		public const int IsUnlimitedFieldNumber = 11;

		// Token: 0x0400437E RID: 17278
		private bool isUnlimited_;

		// Token: 0x0400437F RID: 17279
		public const int EnableUnlimitedModeFieldNumber = 12;

		// Token: 0x04004380 RID: 17280
		private bool enableUnlimitedMode_;

		// Token: 0x04004381 RID: 17281
		public const int RewardFieldNumber = 13;

		// Token: 0x04004382 RID: 17282
		private static readonly FieldCodec<FloroRanchSubInsSettleReward> _repeated_reward_codec = FieldCodec.ForMessage<FloroRanchSubInsSettleReward>(106U, FloroRanchSubInsSettleReward.Parser);

		// Token: 0x04004383 RID: 17283
		private readonly RepeatedField<FloroRanchSubInsSettleReward> reward_ = new RepeatedField<FloroRanchSubInsSettleReward>();

		// Token: 0x04004384 RID: 17284
		public const int ForceSettleTextKeyFieldNumber = 14;

		// Token: 0x04004385 RID: 17285
		private string forceSettleTextKey_ = "";

		// Token: 0x04004386 RID: 17286
		public const int CurWeeklyScoreNumFieldNumber = 15;

		// Token: 0x04004387 RID: 17287
		private int curWeeklyScoreNum_;

		// Token: 0x04004388 RID: 17288
		public const int RewardWeeklyScoreNumFieldNumber = 16;

		// Token: 0x04004389 RID: 17289
		private int rewardWeeklyScoreNum_;
	}
}
