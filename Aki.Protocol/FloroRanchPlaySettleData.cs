using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020005B7 RID: 1463
	public sealed class FloroRanchPlaySettleData : IMessage<FloroRanchPlaySettleData>, IMessage, IEquatable<FloroRanchPlaySettleData>, IDeepCloneable<FloroRanchPlaySettleData>, IBufferMessage
	{
		// Token: 0x060087B2 RID: 34738 RVA: 0x00147978 File Offset: 0x00145B78
		[NullableContext(1)]
		public static FloroRanchPlaySettleData Create()
		{
			return new FloroRanchPlaySettleData();
		}

		// Token: 0x17001A9A RID: 6810
		// (get) Token: 0x060087B3 RID: 34739 RVA: 0x0014797F File Offset: 0x00145B7F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001A9B RID: 6811
		// (get) Token: 0x060087B4 RID: 34740 RVA: 0x00147982 File Offset: 0x00145B82
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FloroRanchPlaySettleData.Descriptor;
			}
		}

		// Token: 0x060087B5 RID: 34741 RVA: 0x00147989 File Offset: 0x00145B89
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchPlaySettleData()
		{
		}

		// Token: 0x060087B6 RID: 34742 RVA: 0x001479A8 File Offset: 0x00145BA8
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

		// Token: 0x060087B7 RID: 34743 RVA: 0x00147A91 File Offset: 0x00145C91
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchPlaySettleData Clone()
		{
			return new FloroRanchPlaySettleData(this);
		}

		// Token: 0x17001A9C RID: 6812
		// (get) Token: 0x060087B8 RID: 34744 RVA: 0x00147A99 File Offset: 0x00145C99
		// (set) Token: 0x060087B9 RID: 34745 RVA: 0x00147AA1 File Offset: 0x00145CA1
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

		// Token: 0x17001A9D RID: 6813
		// (get) Token: 0x060087BA RID: 34746 RVA: 0x00147AAA File Offset: 0x00145CAA
		// (set) Token: 0x060087BB RID: 34747 RVA: 0x00147AB2 File Offset: 0x00145CB2
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

		// Token: 0x17001A9E RID: 6814
		// (get) Token: 0x060087BC RID: 34748 RVA: 0x00147ABB File Offset: 0x00145CBB
		// (set) Token: 0x060087BD RID: 34749 RVA: 0x00147AC3 File Offset: 0x00145CC3
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

		// Token: 0x17001A9F RID: 6815
		// (get) Token: 0x060087BE RID: 34750 RVA: 0x00147ACC File Offset: 0x00145CCC
		// (set) Token: 0x060087BF RID: 34751 RVA: 0x00147AD4 File Offset: 0x00145CD4
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

		// Token: 0x17001AA0 RID: 6816
		// (get) Token: 0x060087C0 RID: 34752 RVA: 0x00147ADD File Offset: 0x00145CDD
		// (set) Token: 0x060087C1 RID: 34753 RVA: 0x00147AE5 File Offset: 0x00145CE5
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

		// Token: 0x17001AA1 RID: 6817
		// (get) Token: 0x060087C2 RID: 34754 RVA: 0x00147AEE File Offset: 0x00145CEE
		// (set) Token: 0x060087C3 RID: 34755 RVA: 0x00147AF6 File Offset: 0x00145CF6
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

		// Token: 0x17001AA2 RID: 6818
		// (get) Token: 0x060087C4 RID: 34756 RVA: 0x00147AFF File Offset: 0x00145CFF
		// (set) Token: 0x060087C5 RID: 34757 RVA: 0x00147B07 File Offset: 0x00145D07
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

		// Token: 0x17001AA3 RID: 6819
		// (get) Token: 0x060087C6 RID: 34758 RVA: 0x00147B10 File Offset: 0x00145D10
		// (set) Token: 0x060087C7 RID: 34759 RVA: 0x00147B18 File Offset: 0x00145D18
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

		// Token: 0x17001AA4 RID: 6820
		// (get) Token: 0x060087C8 RID: 34760 RVA: 0x00147B21 File Offset: 0x00145D21
		// (set) Token: 0x060087C9 RID: 34761 RVA: 0x00147B29 File Offset: 0x00145D29
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

		// Token: 0x17001AA5 RID: 6821
		// (get) Token: 0x060087CA RID: 34762 RVA: 0x00147B32 File Offset: 0x00145D32
		// (set) Token: 0x060087CB RID: 34763 RVA: 0x00147B3A File Offset: 0x00145D3A
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

		// Token: 0x17001AA6 RID: 6822
		// (get) Token: 0x060087CC RID: 34764 RVA: 0x00147B43 File Offset: 0x00145D43
		// (set) Token: 0x060087CD RID: 34765 RVA: 0x00147B4B File Offset: 0x00145D4B
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

		// Token: 0x17001AA7 RID: 6823
		// (get) Token: 0x060087CE RID: 34766 RVA: 0x00147B54 File Offset: 0x00145D54
		// (set) Token: 0x060087CF RID: 34767 RVA: 0x00147B5C File Offset: 0x00145D5C
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

		// Token: 0x17001AA8 RID: 6824
		// (get) Token: 0x060087D0 RID: 34768 RVA: 0x00147B65 File Offset: 0x00145D65
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<FloroRanchSubInsSettleReward> Reward
		{
			get
			{
				return this.reward_;
			}
		}

		// Token: 0x17001AA9 RID: 6825
		// (get) Token: 0x060087D1 RID: 34769 RVA: 0x00147B6D File Offset: 0x00145D6D
		// (set) Token: 0x060087D2 RID: 34770 RVA: 0x00147B75 File Offset: 0x00145D75
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

		// Token: 0x17001AAA RID: 6826
		// (get) Token: 0x060087D3 RID: 34771 RVA: 0x00147B88 File Offset: 0x00145D88
		// (set) Token: 0x060087D4 RID: 34772 RVA: 0x00147B90 File Offset: 0x00145D90
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

		// Token: 0x17001AAB RID: 6827
		// (get) Token: 0x060087D5 RID: 34773 RVA: 0x00147B99 File Offset: 0x00145D99
		// (set) Token: 0x060087D6 RID: 34774 RVA: 0x00147BA1 File Offset: 0x00145DA1
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

		// Token: 0x060087D7 RID: 34775 RVA: 0x00147BAA File Offset: 0x00145DAA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FloroRanchPlaySettleData);
		}

		// Token: 0x060087D8 RID: 34776 RVA: 0x00147BB8 File Offset: 0x00145DB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FloroRanchPlaySettleData other)
		{
			return other != null && (other == this || (this.TechNum == other.TechNum && this.AllowedTechUp == other.AllowedTechUp && this.TotalDays == other.TotalDays && this.IsNewMaxDays == other.IsNewMaxDays && this.TotalCoin == other.TotalCoin && this.IsNewMaxCoin == other.IsNewMaxCoin && this.MaxDayCoin == other.MaxDayCoin && this.ChampionConfigId == other.ChampionConfigId && this.ChampionTotalCoinNum == other.ChampionTotalCoinNum && this.Win == other.Win && this.IsUnlimited == other.IsUnlimited && this.EnableUnlimitedMode == other.EnableUnlimitedMode && this.reward_.Equals(other.reward_) && !(this.ForceSettleTextKey != other.ForceSettleTextKey) && this.CurWeeklyScoreNum == other.CurWeeklyScoreNum && this.RewardWeeklyScoreNum == other.RewardWeeklyScoreNum && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060087D9 RID: 34777 RVA: 0x00147CEC File Offset: 0x00145EEC
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

		// Token: 0x060087DA RID: 34778 RVA: 0x00147E99 File Offset: 0x00146099
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060087DB RID: 34779 RVA: 0x00147EA6 File Offset: 0x001460A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060087DC RID: 34780 RVA: 0x00147EB0 File Offset: 0x001460B0
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

		// Token: 0x060087DD RID: 34781 RVA: 0x00148090 File Offset: 0x00146290
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

		// Token: 0x060087DE RID: 34782 RVA: 0x001481F0 File Offset: 0x001463F0
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

		// Token: 0x060087DF RID: 34783 RVA: 0x0014835A File Offset: 0x0014655A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060087E0 RID: 34784 RVA: 0x00148364 File Offset: 0x00146564
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

		// Token: 0x0400435E RID: 17246
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400435F RID: 17247
		public const int TechNumFieldNumber = 1;

		// Token: 0x04004360 RID: 17248
		private int techNum_;

		// Token: 0x04004361 RID: 17249
		public const int AllowedTechUpFieldNumber = 2;

		// Token: 0x04004362 RID: 17250
		private bool allowedTechUp_;

		// Token: 0x04004363 RID: 17251
		public const int TotalDaysFieldNumber = 3;

		// Token: 0x04004364 RID: 17252
		private int totalDays_;

		// Token: 0x04004365 RID: 17253
		public const int IsNewMaxDaysFieldNumber = 4;

		// Token: 0x04004366 RID: 17254
		private bool isNewMaxDays_;

		// Token: 0x04004367 RID: 17255
		public const int TotalCoinFieldNumber = 5;

		// Token: 0x04004368 RID: 17256
		private long totalCoin_;

		// Token: 0x04004369 RID: 17257
		public const int IsNewMaxCoinFieldNumber = 6;

		// Token: 0x0400436A RID: 17258
		private bool isNewMaxCoin_;

		// Token: 0x0400436B RID: 17259
		public const int MaxDayCoinFieldNumber = 7;

		// Token: 0x0400436C RID: 17260
		private long maxDayCoin_;

		// Token: 0x0400436D RID: 17261
		public const int ChampionConfigIdFieldNumber = 8;

		// Token: 0x0400436E RID: 17262
		private int championConfigId_;

		// Token: 0x0400436F RID: 17263
		public const int ChampionTotalCoinNumFieldNumber = 9;

		// Token: 0x04004370 RID: 17264
		private long championTotalCoinNum_;

		// Token: 0x04004371 RID: 17265
		public const int WinFieldNumber = 10;

		// Token: 0x04004372 RID: 17266
		private bool win_;

		// Token: 0x04004373 RID: 17267
		public const int IsUnlimitedFieldNumber = 11;

		// Token: 0x04004374 RID: 17268
		private bool isUnlimited_;

		// Token: 0x04004375 RID: 17269
		public const int EnableUnlimitedModeFieldNumber = 12;

		// Token: 0x04004376 RID: 17270
		private bool enableUnlimitedMode_;

		// Token: 0x04004377 RID: 17271
		public const int RewardFieldNumber = 13;

		// Token: 0x04004378 RID: 17272
		private static readonly FieldCodec<FloroRanchSubInsSettleReward> _repeated_reward_codec = FieldCodec.ForMessage<FloroRanchSubInsSettleReward>(106U, FloroRanchSubInsSettleReward.Parser);

		// Token: 0x04004379 RID: 17273
		private readonly RepeatedField<FloroRanchSubInsSettleReward> reward_ = new RepeatedField<FloroRanchSubInsSettleReward>();

		// Token: 0x0400437A RID: 17274
		public const int ForceSettleTextKeyFieldNumber = 14;

		// Token: 0x0400437B RID: 17275
		private string forceSettleTextKey_ = "";

		// Token: 0x0400437C RID: 17276
		public const int CurWeeklyScoreNumFieldNumber = 15;

		// Token: 0x0400437D RID: 17277
		private int curWeeklyScoreNum_;

		// Token: 0x0400437E RID: 17278
		public const int RewardWeeklyScoreNumFieldNumber = 16;

		// Token: 0x0400437F RID: 17279
		private int rewardWeeklyScoreNum_;
	}
}
