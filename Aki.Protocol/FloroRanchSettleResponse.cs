using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020005CD RID: 1485
	[NetMessage(EMessageId.FloroRanchSettleResponse)]
	public sealed class FloroRanchSettleResponse : IMessage<FloroRanchSettleResponse>, IMessage, IEquatable<FloroRanchSettleResponse>, IDeepCloneable<FloroRanchSettleResponse>, IBufferMessage
	{
		// Token: 0x060089D7 RID: 35287 RVA: 0x0014DC23 File Offset: 0x0014BE23
		[NullableContext(1)]
		public static FloroRanchSettleResponse Create()
		{
			return new FloroRanchSettleResponse();
		}

		// Token: 0x17001B29 RID: 6953
		// (get) Token: 0x060089D8 RID: 35288 RVA: 0x0014DC2A File Offset: 0x0014BE2A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001B2A RID: 6954
		// (get) Token: 0x060089D9 RID: 35289 RVA: 0x0014DC2D File Offset: 0x0014BE2D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FloroRanchSettleResponse.Descriptor;
			}
		}

		// Token: 0x060089DA RID: 35290 RVA: 0x0014DC34 File Offset: 0x0014BE34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchSettleResponse()
		{
		}

		// Token: 0x060089DB RID: 35291 RVA: 0x0014DC48 File Offset: 0x0014BE48
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

		// Token: 0x060089DC RID: 35292 RVA: 0x0014DD29 File Offset: 0x0014BF29
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchSettleResponse Clone()
		{
			return new FloroRanchSettleResponse(this);
		}

		// Token: 0x17001B2B RID: 6955
		// (get) Token: 0x060089DD RID: 35293 RVA: 0x0014DD31 File Offset: 0x0014BF31
		// (set) Token: 0x060089DE RID: 35294 RVA: 0x0014DD39 File Offset: 0x0014BF39
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

		// Token: 0x17001B2C RID: 6956
		// (get) Token: 0x060089DF RID: 35295 RVA: 0x0014DD42 File Offset: 0x0014BF42
		// (set) Token: 0x060089E0 RID: 35296 RVA: 0x0014DD4A File Offset: 0x0014BF4A
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

		// Token: 0x17001B2D RID: 6957
		// (get) Token: 0x060089E1 RID: 35297 RVA: 0x0014DD53 File Offset: 0x0014BF53
		// (set) Token: 0x060089E2 RID: 35298 RVA: 0x0014DD5B File Offset: 0x0014BF5B
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

		// Token: 0x17001B2E RID: 6958
		// (get) Token: 0x060089E3 RID: 35299 RVA: 0x0014DD64 File Offset: 0x0014BF64
		// (set) Token: 0x060089E4 RID: 35300 RVA: 0x0014DD6C File Offset: 0x0014BF6C
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

		// Token: 0x17001B2F RID: 6959
		// (get) Token: 0x060089E5 RID: 35301 RVA: 0x0014DD75 File Offset: 0x0014BF75
		// (set) Token: 0x060089E6 RID: 35302 RVA: 0x0014DD7D File Offset: 0x0014BF7D
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

		// Token: 0x17001B30 RID: 6960
		// (get) Token: 0x060089E7 RID: 35303 RVA: 0x0014DD86 File Offset: 0x0014BF86
		// (set) Token: 0x060089E8 RID: 35304 RVA: 0x0014DD8E File Offset: 0x0014BF8E
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

		// Token: 0x17001B31 RID: 6961
		// (get) Token: 0x060089E9 RID: 35305 RVA: 0x0014DD97 File Offset: 0x0014BF97
		// (set) Token: 0x060089EA RID: 35306 RVA: 0x0014DD9F File Offset: 0x0014BF9F
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

		// Token: 0x17001B32 RID: 6962
		// (get) Token: 0x060089EB RID: 35307 RVA: 0x0014DDA8 File Offset: 0x0014BFA8
		// (set) Token: 0x060089EC RID: 35308 RVA: 0x0014DDB0 File Offset: 0x0014BFB0
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

		// Token: 0x17001B33 RID: 6963
		// (get) Token: 0x060089ED RID: 35309 RVA: 0x0014DDB9 File Offset: 0x0014BFB9
		// (set) Token: 0x060089EE RID: 35310 RVA: 0x0014DDC1 File Offset: 0x0014BFC1
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

		// Token: 0x17001B34 RID: 6964
		// (get) Token: 0x060089EF RID: 35311 RVA: 0x0014DDCA File Offset: 0x0014BFCA
		// (set) Token: 0x060089F0 RID: 35312 RVA: 0x0014DDD2 File Offset: 0x0014BFD2
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

		// Token: 0x17001B35 RID: 6965
		// (get) Token: 0x060089F1 RID: 35313 RVA: 0x0014DDDB File Offset: 0x0014BFDB
		// (set) Token: 0x060089F2 RID: 35314 RVA: 0x0014DDE3 File Offset: 0x0014BFE3
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

		// Token: 0x17001B36 RID: 6966
		// (get) Token: 0x060089F3 RID: 35315 RVA: 0x0014DDEC File Offset: 0x0014BFEC
		// (set) Token: 0x060089F4 RID: 35316 RVA: 0x0014DDF4 File Offset: 0x0014BFF4
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

		// Token: 0x17001B37 RID: 6967
		// (get) Token: 0x060089F5 RID: 35317 RVA: 0x0014DDFD File Offset: 0x0014BFFD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<FloroRanchSubInsSettleReward> Reward
		{
			get
			{
				return this.reward_;
			}
		}

		// Token: 0x17001B38 RID: 6968
		// (get) Token: 0x060089F6 RID: 35318 RVA: 0x0014DE05 File Offset: 0x0014C005
		// (set) Token: 0x060089F7 RID: 35319 RVA: 0x0014DE0D File Offset: 0x0014C00D
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

		// Token: 0x060089F8 RID: 35320 RVA: 0x0014DE16 File Offset: 0x0014C016
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FloroRanchSettleResponse);
		}

		// Token: 0x060089F9 RID: 35321 RVA: 0x0014DE24 File Offset: 0x0014C024
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FloroRanchSettleResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.TechNum == other.TechNum && this.AllowedTechUp == other.AllowedTechUp && this.TotalDays == other.TotalDays && this.IsNewMaxDays == other.IsNewMaxDays && this.TotalCoin == other.TotalCoin && this.IsNewMaxCoin == other.IsNewMaxCoin && this.MaxDayCoin == other.MaxDayCoin && this.ChampionConfigId == other.ChampionConfigId && this.ChampionTotalCoinNum == other.ChampionTotalCoinNum && this.Win == other.Win && this.IsUnlimited == other.IsUnlimited && this.reward_.Equals(other.reward_) && object.Equals(this.SettleData, other.SettleData) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060089FA RID: 35322 RVA: 0x0014DF38 File Offset: 0x0014C138
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

		// Token: 0x060089FB RID: 35323 RVA: 0x0014E0B7 File Offset: 0x0014C2B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060089FC RID: 35324 RVA: 0x0014E0C4 File Offset: 0x0014C2C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060089FD RID: 35325 RVA: 0x0014E0D0 File Offset: 0x0014C2D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TotalCoin != 0L)
			{
				output.WriteRawTag(8);
				output.WriteInt64(this.TotalCoin);
			}
			if (this.IsUnlimited)
			{
				output.WriteRawTag(16);
				output.WriteBool(this.IsUnlimited);
			}
			if (this.MaxDayCoin != 0L)
			{
				output.WriteRawTag(24);
				output.WriteInt64(this.MaxDayCoin);
			}
			if (this.TotalDays != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.TotalDays);
			}
			this.reward_.WriteTo(ref output, FloroRanchSettleResponse._repeated_reward_codec);
			if (this.Win)
			{
				output.WriteRawTag(48);
				output.WriteBool(this.Win);
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(56);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.IsNewMaxDays)
			{
				output.WriteRawTag(64);
				output.WriteBool(this.IsNewMaxDays);
			}
			if (this.IsNewMaxCoin)
			{
				output.WriteRawTag(80);
				output.WriteBool(this.IsNewMaxCoin);
			}
			if (this.ChampionConfigId != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.ChampionConfigId);
			}
			if (this.AllowedTechUp)
			{
				output.WriteRawTag(96);
				output.WriteBool(this.AllowedTechUp);
			}
			if (this.TechNum != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.TechNum);
			}
			if (this.ChampionTotalCoinNum != 0L)
			{
				output.WriteRawTag(112);
				output.WriteInt64(this.ChampionTotalCoinNum);
			}
			if (this.settleData_ != null)
			{
				output.WriteRawTag(122);
				output.WriteMessage(this.SettleData);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060089FE RID: 35326 RVA: 0x0014E270 File Offset: 0x0014C470
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

		// Token: 0x060089FF RID: 35327 RVA: 0x0014E3A8 File Offset: 0x0014C5A8
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

		// Token: 0x06008A00 RID: 35328 RVA: 0x0014E4FD File Offset: 0x0014C6FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008A01 RID: 35329 RVA: 0x0014E508 File Offset: 0x0014C708
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
					if (num <= 24U)
					{
						if (num == 8U)
						{
							this.TotalCoin = input.ReadInt64();
							continue;
						}
						if (num == 16U)
						{
							this.IsUnlimited = input.ReadBool();
							continue;
						}
						if (num == 24U)
						{
							this.MaxDayCoin = input.ReadInt64();
							continue;
						}
					}
					else if (num <= 42U)
					{
						if (num == 32U)
						{
							this.TotalDays = input.ReadInt32();
							continue;
						}
						if (num == 42U)
						{
							this.reward_.AddEntriesFrom(ref input, FloroRanchSettleResponse._repeated_reward_codec);
							continue;
						}
					}
					else
					{
						if (num == 48U)
						{
							this.Win = input.ReadBool();
							continue;
						}
						if (num == 56U)
						{
							this.ErrorCode = (ErrorCode)input.ReadEnum();
							continue;
						}
					}
				}
				else if (num <= 88U)
				{
					if (num == 64U)
					{
						this.IsNewMaxDays = input.ReadBool();
						continue;
					}
					if (num == 80U)
					{
						this.IsNewMaxCoin = input.ReadBool();
						continue;
					}
					if (num == 88U)
					{
						this.ChampionConfigId = input.ReadInt32();
						continue;
					}
				}
				else if (num <= 104U)
				{
					if (num == 96U)
					{
						this.AllowedTechUp = input.ReadBool();
						continue;
					}
					if (num == 104U)
					{
						this.TechNum = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 112U)
					{
						this.ChampionTotalCoinNum = input.ReadInt64();
						continue;
					}
					if (num == 122U)
					{
						if (this.settleData_ == null)
						{
							this.SettleData = new FloroRanchPlaySettleData();
						}
						input.ReadMessage(this.SettleData);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04004432 RID: 17458
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004433 RID: 17459
		public const int ErrorCodeFieldNumber = 7;

		// Token: 0x04004434 RID: 17460
		private ErrorCode errorCode_;

		// Token: 0x04004435 RID: 17461
		public const int TechNumFieldNumber = 13;

		// Token: 0x04004436 RID: 17462
		private int techNum_;

		// Token: 0x04004437 RID: 17463
		public const int AllowedTechUpFieldNumber = 12;

		// Token: 0x04004438 RID: 17464
		private bool allowedTechUp_;

		// Token: 0x04004439 RID: 17465
		public const int TotalDaysFieldNumber = 4;

		// Token: 0x0400443A RID: 17466
		private int totalDays_;

		// Token: 0x0400443B RID: 17467
		public const int IsNewMaxDaysFieldNumber = 8;

		// Token: 0x0400443C RID: 17468
		private bool isNewMaxDays_;

		// Token: 0x0400443D RID: 17469
		public const int TotalCoinFieldNumber = 1;

		// Token: 0x0400443E RID: 17470
		private long totalCoin_;

		// Token: 0x0400443F RID: 17471
		public const int IsNewMaxCoinFieldNumber = 10;

		// Token: 0x04004440 RID: 17472
		private bool isNewMaxCoin_;

		// Token: 0x04004441 RID: 17473
		public const int MaxDayCoinFieldNumber = 3;

		// Token: 0x04004442 RID: 17474
		private long maxDayCoin_;

		// Token: 0x04004443 RID: 17475
		public const int ChampionConfigIdFieldNumber = 11;

		// Token: 0x04004444 RID: 17476
		private int championConfigId_;

		// Token: 0x04004445 RID: 17477
		public const int ChampionTotalCoinNumFieldNumber = 14;

		// Token: 0x04004446 RID: 17478
		private long championTotalCoinNum_;

		// Token: 0x04004447 RID: 17479
		public const int WinFieldNumber = 6;

		// Token: 0x04004448 RID: 17480
		private bool win_;

		// Token: 0x04004449 RID: 17481
		public const int IsUnlimitedFieldNumber = 2;

		// Token: 0x0400444A RID: 17482
		private bool isUnlimited_;

		// Token: 0x0400444B RID: 17483
		public const int RewardFieldNumber = 5;

		// Token: 0x0400444C RID: 17484
		private static readonly FieldCodec<FloroRanchSubInsSettleReward> _repeated_reward_codec = FieldCodec.ForMessage<FloroRanchSubInsSettleReward>(42U, FloroRanchSubInsSettleReward.Parser);

		// Token: 0x0400444D RID: 17485
		private readonly RepeatedField<FloroRanchSubInsSettleReward> reward_ = new RepeatedField<FloroRanchSubInsSettleReward>();

		// Token: 0x0400444E RID: 17486
		public const int SettleDataFieldNumber = 15;

		// Token: 0x0400444F RID: 17487
		private FloroRanchPlaySettleData settleData_;
	}
}
