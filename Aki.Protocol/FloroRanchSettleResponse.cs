using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020005E2 RID: 1506
	[NetMessage(EMessageId.FloroRanchSettleResponse)]
	public sealed class FloroRanchSettleResponse : IMessage<FloroRanchSettleResponse>, IMessage, IEquatable<FloroRanchSettleResponse>, IDeepCloneable<FloroRanchSettleResponse>, IBufferMessage
	{
		// Token: 0x06008B3F RID: 35647 RVA: 0x0015083B File Offset: 0x0014EA3B
		[NullableContext(1)]
		public static FloroRanchSettleResponse Create()
		{
			return new FloroRanchSettleResponse();
		}

		// Token: 0x17001B76 RID: 7030
		// (get) Token: 0x06008B40 RID: 35648 RVA: 0x00150842 File Offset: 0x0014EA42
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001B77 RID: 7031
		// (get) Token: 0x06008B41 RID: 35649 RVA: 0x00150845 File Offset: 0x0014EA45
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FloroRanchSettleResponse.Descriptor;
			}
		}

		// Token: 0x06008B42 RID: 35650 RVA: 0x0015084C File Offset: 0x0014EA4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchSettleResponse()
		{
		}

		// Token: 0x06008B43 RID: 35651 RVA: 0x00150860 File Offset: 0x0014EA60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchSettleResponse(FloroRanchSettleResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
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
			this.reward_ = other.reward_.Clone();
			this.settleData_ = ((other.settleData_ != null) ? other.settleData_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008B44 RID: 35652 RVA: 0x00150941 File Offset: 0x0014EB41
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchSettleResponse Clone()
		{
			return new FloroRanchSettleResponse(this);
		}

		// Token: 0x17001B78 RID: 7032
		// (get) Token: 0x06008B45 RID: 35653 RVA: 0x00150949 File Offset: 0x0014EB49
		// (set) Token: 0x06008B46 RID: 35654 RVA: 0x00150951 File Offset: 0x0014EB51
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode ErrorCode
		{
			get
			{
				return this.errorCode_;
			}
			set
			{
				this.errorCode_ = value;
			}
		}

		// Token: 0x17001B79 RID: 7033
		// (get) Token: 0x06008B47 RID: 35655 RVA: 0x0015095A File Offset: 0x0014EB5A
		// (set) Token: 0x06008B48 RID: 35656 RVA: 0x00150962 File Offset: 0x0014EB62
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

		// Token: 0x17001B7A RID: 7034
		// (get) Token: 0x06008B49 RID: 35657 RVA: 0x0015096B File Offset: 0x0014EB6B
		// (set) Token: 0x06008B4A RID: 35658 RVA: 0x00150973 File Offset: 0x0014EB73
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

		// Token: 0x17001B7B RID: 7035
		// (get) Token: 0x06008B4B RID: 35659 RVA: 0x0015097C File Offset: 0x0014EB7C
		// (set) Token: 0x06008B4C RID: 35660 RVA: 0x00150984 File Offset: 0x0014EB84
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

		// Token: 0x17001B7C RID: 7036
		// (get) Token: 0x06008B4D RID: 35661 RVA: 0x0015098D File Offset: 0x0014EB8D
		// (set) Token: 0x06008B4E RID: 35662 RVA: 0x00150995 File Offset: 0x0014EB95
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

		// Token: 0x17001B7D RID: 7037
		// (get) Token: 0x06008B4F RID: 35663 RVA: 0x0015099E File Offset: 0x0014EB9E
		// (set) Token: 0x06008B50 RID: 35664 RVA: 0x001509A6 File Offset: 0x0014EBA6
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

		// Token: 0x17001B7E RID: 7038
		// (get) Token: 0x06008B51 RID: 35665 RVA: 0x001509AF File Offset: 0x0014EBAF
		// (set) Token: 0x06008B52 RID: 35666 RVA: 0x001509B7 File Offset: 0x0014EBB7
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

		// Token: 0x17001B7F RID: 7039
		// (get) Token: 0x06008B53 RID: 35667 RVA: 0x001509C0 File Offset: 0x0014EBC0
		// (set) Token: 0x06008B54 RID: 35668 RVA: 0x001509C8 File Offset: 0x0014EBC8
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

		// Token: 0x17001B80 RID: 7040
		// (get) Token: 0x06008B55 RID: 35669 RVA: 0x001509D1 File Offset: 0x0014EBD1
		// (set) Token: 0x06008B56 RID: 35670 RVA: 0x001509D9 File Offset: 0x0014EBD9
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

		// Token: 0x17001B81 RID: 7041
		// (get) Token: 0x06008B57 RID: 35671 RVA: 0x001509E2 File Offset: 0x0014EBE2
		// (set) Token: 0x06008B58 RID: 35672 RVA: 0x001509EA File Offset: 0x0014EBEA
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

		// Token: 0x17001B82 RID: 7042
		// (get) Token: 0x06008B59 RID: 35673 RVA: 0x001509F3 File Offset: 0x0014EBF3
		// (set) Token: 0x06008B5A RID: 35674 RVA: 0x001509FB File Offset: 0x0014EBFB
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

		// Token: 0x17001B83 RID: 7043
		// (get) Token: 0x06008B5B RID: 35675 RVA: 0x00150A04 File Offset: 0x0014EC04
		// (set) Token: 0x06008B5C RID: 35676 RVA: 0x00150A0C File Offset: 0x0014EC0C
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

		// Token: 0x17001B84 RID: 7044
		// (get) Token: 0x06008B5D RID: 35677 RVA: 0x00150A15 File Offset: 0x0014EC15
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<FloroRanchSubInsSettleReward> Reward
		{
			get
			{
				return this.reward_;
			}
		}

		// Token: 0x17001B85 RID: 7045
		// (get) Token: 0x06008B5E RID: 35678 RVA: 0x00150A1D File Offset: 0x0014EC1D
		// (set) Token: 0x06008B5F RID: 35679 RVA: 0x00150A25 File Offset: 0x0014EC25
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchPlaySettleData SettleData
		{
			get
			{
				return this.settleData_;
			}
			set
			{
				this.settleData_ = value;
			}
		}

		// Token: 0x06008B60 RID: 35680 RVA: 0x00150A2E File Offset: 0x0014EC2E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FloroRanchSettleResponse);
		}

		// Token: 0x06008B61 RID: 35681 RVA: 0x00150A3C File Offset: 0x0014EC3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FloroRanchSettleResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.TechNum == other.TechNum && this.AllowedTechUp == other.AllowedTechUp && this.TotalDays == other.TotalDays && this.IsNewMaxDays == other.IsNewMaxDays && this.TotalCoin == other.TotalCoin && this.IsNewMaxCoin == other.IsNewMaxCoin && this.MaxDayCoin == other.MaxDayCoin && this.ChampionConfigId == other.ChampionConfigId && this.ChampionTotalCoinNum == other.ChampionTotalCoinNum && this.Win == other.Win && this.IsUnlimited == other.IsUnlimited && this.reward_.Equals(other.reward_) && object.Equals(this.SettleData, other.SettleData) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008B62 RID: 35682 RVA: 0x00150B50 File Offset: 0x0014ED50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
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
			num ^= this.reward_.GetHashCode();
			if (this.settleData_ != null)
			{
				num ^= this.SettleData.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008B63 RID: 35683 RVA: 0x00150CCF File Offset: 0x0014EECF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06008B64 RID: 35684 RVA: 0x00150CDC File Offset: 0x0014EEDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008B65 RID: 35685 RVA: 0x00150CE8 File Offset: 0x0014EEE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TechNum != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.TechNum);
			}
			if (this.IsNewMaxCoin)
			{
				output.WriteRawTag(24);
				output.WriteBool(this.IsNewMaxCoin);
			}
			if (this.IsUnlimited)
			{
				output.WriteRawTag(32);
				output.WriteBool(this.IsUnlimited);
			}
			if (this.MaxDayCoin != 0L)
			{
				output.WriteRawTag(40);
				output.WriteInt64(this.MaxDayCoin);
			}
			if (this.settleData_ != null)
			{
				output.WriteRawTag(50);
				output.WriteMessage(this.SettleData);
			}
			if (this.ChampionTotalCoinNum != 0L)
			{
				output.WriteRawTag(56);
				output.WriteInt64(this.ChampionTotalCoinNum);
			}
			if (this.ChampionConfigId != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.ChampionConfigId);
			}
			if (this.IsNewMaxDays)
			{
				output.WriteRawTag(72);
				output.WriteBool(this.IsNewMaxDays);
			}
			if (this.Win)
			{
				output.WriteRawTag(80);
				output.WriteBool(this.Win);
			}
			if (this.TotalCoin != 0L)
			{
				output.WriteRawTag(88);
				output.WriteInt64(this.TotalCoin);
			}
			if (this.TotalDays != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.TotalDays);
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(104);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.AllowedTechUp)
			{
				output.WriteRawTag(112);
				output.WriteBool(this.AllowedTechUp);
			}
			this.reward_.WriteTo(ref output, FloroRanchSettleResponse._repeated_reward_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008B66 RID: 35686 RVA: 0x00150E88 File Offset: 0x0014F088
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
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
			num += this.reward_.CalculateSize(FloroRanchSettleResponse._repeated_reward_codec);
			if (this.settleData_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.SettleData);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008B67 RID: 35687 RVA: 0x00150FC0 File Offset: 0x0014F1C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FloroRanchSettleResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
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
			this.reward_.Add(other.reward_);
			if (other.settleData_ != null)
			{
				if (this.settleData_ == null)
				{
					this.SettleData = new FloroRanchPlaySettleData();
				}
				this.SettleData.MergeFrom(other.SettleData);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06008B68 RID: 35688 RVA: 0x00151115 File Offset: 0x0014F315
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008B69 RID: 35689 RVA: 0x00151120 File Offset: 0x0014F320
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
						if (num == 8U)
						{
							this.TechNum = input.ReadInt32();
							continue;
						}
						if (num == 24U)
						{
							this.IsNewMaxCoin = input.ReadBool();
							continue;
						}
						if (num == 32U)
						{
							this.IsUnlimited = input.ReadBool();
							continue;
						}
					}
					else if (num <= 50U)
					{
						if (num == 40U)
						{
							this.MaxDayCoin = input.ReadInt64();
							continue;
						}
						if (num == 50U)
						{
							if (this.settleData_ == null)
							{
								this.SettleData = new FloroRanchPlaySettleData();
							}
							input.ReadMessage(this.SettleData);
							continue;
						}
					}
					else
					{
						if (num == 56U)
						{
							this.ChampionTotalCoinNum = input.ReadInt64();
							continue;
						}
						if (num == 64U)
						{
							this.ChampionConfigId = input.ReadInt32();
							continue;
						}
					}
				}
				else if (num <= 88U)
				{
					if (num == 72U)
					{
						this.IsNewMaxDays = input.ReadBool();
						continue;
					}
					if (num == 80U)
					{
						this.Win = input.ReadBool();
						continue;
					}
					if (num == 88U)
					{
						this.TotalCoin = input.ReadInt64();
						continue;
					}
				}
				else if (num <= 104U)
				{
					if (num == 96U)
					{
						this.TotalDays = input.ReadInt32();
						continue;
					}
					if (num == 104U)
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
						continue;
					}
				}
				else
				{
					if (num == 112U)
					{
						this.AllowedTechUp = input.ReadBool();
						continue;
					}
					if (num == 122U)
					{
						this.reward_.AddEntriesFrom(ref input, FloroRanchSettleResponse._repeated_reward_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400443C RID: 17468
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400443D RID: 17469
		public const int ErrorCodeFieldNumber = 13;

		// Token: 0x0400443E RID: 17470
		private ErrorCode errorCode_;

		// Token: 0x0400443F RID: 17471
		public const int TechNumFieldNumber = 1;

		// Token: 0x04004440 RID: 17472
		private int techNum_;

		// Token: 0x04004441 RID: 17473
		public const int AllowedTechUpFieldNumber = 14;

		// Token: 0x04004442 RID: 17474
		private bool allowedTechUp_;

		// Token: 0x04004443 RID: 17475
		public const int TotalDaysFieldNumber = 12;

		// Token: 0x04004444 RID: 17476
		private int totalDays_;

		// Token: 0x04004445 RID: 17477
		public const int IsNewMaxDaysFieldNumber = 9;

		// Token: 0x04004446 RID: 17478
		private bool isNewMaxDays_;

		// Token: 0x04004447 RID: 17479
		public const int TotalCoinFieldNumber = 11;

		// Token: 0x04004448 RID: 17480
		private long totalCoin_;

		// Token: 0x04004449 RID: 17481
		public const int IsNewMaxCoinFieldNumber = 3;

		// Token: 0x0400444A RID: 17482
		private bool isNewMaxCoin_;

		// Token: 0x0400444B RID: 17483
		public const int MaxDayCoinFieldNumber = 5;

		// Token: 0x0400444C RID: 17484
		private long maxDayCoin_;

		// Token: 0x0400444D RID: 17485
		public const int ChampionConfigIdFieldNumber = 8;

		// Token: 0x0400444E RID: 17486
		private int championConfigId_;

		// Token: 0x0400444F RID: 17487
		public const int ChampionTotalCoinNumFieldNumber = 7;

		// Token: 0x04004450 RID: 17488
		private long championTotalCoinNum_;

		// Token: 0x04004451 RID: 17489
		public const int WinFieldNumber = 10;

		// Token: 0x04004452 RID: 17490
		private bool win_;

		// Token: 0x04004453 RID: 17491
		public const int IsUnlimitedFieldNumber = 4;

		// Token: 0x04004454 RID: 17492
		private bool isUnlimited_;

		// Token: 0x04004455 RID: 17493
		public const int RewardFieldNumber = 15;

		// Token: 0x04004456 RID: 17494
		private static readonly FieldCodec<FloroRanchSubInsSettleReward> _repeated_reward_codec = FieldCodec.ForMessage<FloroRanchSubInsSettleReward>(122U, FloroRanchSubInsSettleReward.Parser);

		// Token: 0x04004457 RID: 17495
		private readonly RepeatedField<FloroRanchSubInsSettleReward> reward_ = new RepeatedField<FloroRanchSubInsSettleReward>();

		// Token: 0x04004458 RID: 17496
		public const int SettleDataFieldNumber = 6;

		// Token: 0x04004459 RID: 17497
		private FloroRanchPlaySettleData settleData_;
	}
}
