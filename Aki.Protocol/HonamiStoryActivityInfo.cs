using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200075E RID: 1886
	public sealed class HonamiStoryActivityInfo : IMessage<HonamiStoryActivityInfo>, IMessage, IEquatable<HonamiStoryActivityInfo>, IDeepCloneable<HonamiStoryActivityInfo>, IBufferMessage
	{
		// Token: 0x0600AAB4 RID: 43700 RVA: 0x0019AA58 File Offset: 0x00198C58
		[NullableContext(1)]
		public static HonamiStoryActivityInfo Create()
		{
			return new HonamiStoryActivityInfo();
		}

		// Token: 0x17002260 RID: 8800
		// (get) Token: 0x0600AAB5 RID: 43701 RVA: 0x0019AA5F File Offset: 0x00198C5F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002261 RID: 8801
		// (get) Token: 0x0600AAB6 RID: 43702 RVA: 0x0019AA62 File Offset: 0x00198C62
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HonamiStoryActivityInfo.Descriptor;
			}
		}

		// Token: 0x0600AAB7 RID: 43703 RVA: 0x0019AA6C File Offset: 0x00198C6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryActivityInfo()
		{
		}

		// Token: 0x0600AAB8 RID: 43704 RVA: 0x0019AAF0 File Offset: 0x00198CF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryActivityInfo(HonamiStoryActivityInfo other) : this()
		{
			this.honamiStoryPlayerBagInfo_ = ((other.honamiStoryPlayerBagInfo_ != null) ? other.honamiStoryPlayerBagInfo_.Clone() : null);
			this.activatedTalentId_ = other.activatedTalentId_.Clone();
			this.honamiStoryItemCollectionInfos_ = other.honamiStoryItemCollectionInfos_.Clone();
			this.honamiStoryMascotInfos_ = other.honamiStoryMascotInfos_.Clone();
			this.honamiStoryAreaInfos_ = other.honamiStoryAreaInfos_.Clone();
			this.honamiStoryLimitTask_ = other.honamiStoryLimitTask_.Clone();
			this.areaTask_ = other.areaTask_.Clone();
			this.honamiStoryScoreRewardInfos_ = other.honamiStoryScoreRewardInfos_.Clone();
			this.lifeSupportLevel_ = other.lifeSupportLevel_;
			this.limitShopConsumeItemNum_ = other.limitShopConsumeItemNum_;
			this.honamiStoryTopInfos_ = other.honamiStoryTopInfos_.Clone();
			this.honamiStoryTalentInfos_ = other.honamiStoryTalentInfos_.Clone();
			this.honamiStoryResidentTask_ = other.honamiStoryResidentTask_.Clone();
			this.totalRevenue_ = other.totalRevenue_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600AAB9 RID: 43705 RVA: 0x0019ABFE File Offset: 0x00198DFE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryActivityInfo Clone()
		{
			return new HonamiStoryActivityInfo(this);
		}

		// Token: 0x17002262 RID: 8802
		// (get) Token: 0x0600AABA RID: 43706 RVA: 0x0019AC06 File Offset: 0x00198E06
		// (set) Token: 0x0600AABB RID: 43707 RVA: 0x0019AC0E File Offset: 0x00198E0E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryPlayerBagInfo HonamiStoryPlayerBagInfo
		{
			get
			{
				return this.honamiStoryPlayerBagInfo_;
			}
			set
			{
				this.honamiStoryPlayerBagInfo_ = value;
			}
		}

		// Token: 0x17002263 RID: 8803
		// (get) Token: 0x0600AABC RID: 43708 RVA: 0x0019AC17 File Offset: 0x00198E17
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> ActivatedTalentId
		{
			get
			{
				return this.activatedTalentId_;
			}
		}

		// Token: 0x17002264 RID: 8804
		// (get) Token: 0x0600AABD RID: 43709 RVA: 0x0019AC1F File Offset: 0x00198E1F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<HonamiStoryItemCollectionInfo> HonamiStoryItemCollectionInfos
		{
			get
			{
				return this.honamiStoryItemCollectionInfos_;
			}
		}

		// Token: 0x17002265 RID: 8805
		// (get) Token: 0x0600AABE RID: 43710 RVA: 0x0019AC27 File Offset: 0x00198E27
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<HonamiStoryMascotInfo> HonamiStoryMascotInfos
		{
			get
			{
				return this.honamiStoryMascotInfos_;
			}
		}

		// Token: 0x17002266 RID: 8806
		// (get) Token: 0x0600AABF RID: 43711 RVA: 0x0019AC2F File Offset: 0x00198E2F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<HonamiStoryAreaInfo> HonamiStoryAreaInfos
		{
			get
			{
				return this.honamiStoryAreaInfos_;
			}
		}

		// Token: 0x17002267 RID: 8807
		// (get) Token: 0x0600AAC0 RID: 43712 RVA: 0x0019AC37 File Offset: 0x00198E37
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ConditionTask> HonamiStoryLimitTask
		{
			get
			{
				return this.honamiStoryLimitTask_;
			}
		}

		// Token: 0x17002268 RID: 8808
		// (get) Token: 0x0600AAC1 RID: 43713 RVA: 0x0019AC3F File Offset: 0x00198E3F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ConditionTask> AreaTask
		{
			get
			{
				return this.areaTask_;
			}
		}

		// Token: 0x17002269 RID: 8809
		// (get) Token: 0x0600AAC2 RID: 43714 RVA: 0x0019AC47 File Offset: 0x00198E47
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<HonamiStoryScoreRewardInfo> HonamiStoryScoreRewardInfos
		{
			get
			{
				return this.honamiStoryScoreRewardInfos_;
			}
		}

		// Token: 0x1700226A RID: 8810
		// (get) Token: 0x0600AAC3 RID: 43715 RVA: 0x0019AC4F File Offset: 0x00198E4F
		// (set) Token: 0x0600AAC4 RID: 43716 RVA: 0x0019AC57 File Offset: 0x00198E57
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int LifeSupportLevel
		{
			get
			{
				return this.lifeSupportLevel_;
			}
			set
			{
				this.lifeSupportLevel_ = value;
			}
		}

		// Token: 0x1700226B RID: 8811
		// (get) Token: 0x0600AAC5 RID: 43717 RVA: 0x0019AC60 File Offset: 0x00198E60
		// (set) Token: 0x0600AAC6 RID: 43718 RVA: 0x0019AC68 File Offset: 0x00198E68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int LimitShopConsumeItemNum
		{
			get
			{
				return this.limitShopConsumeItemNum_;
			}
			set
			{
				this.limitShopConsumeItemNum_ = value;
			}
		}

		// Token: 0x1700226C RID: 8812
		// (get) Token: 0x0600AAC7 RID: 43719 RVA: 0x0019AC71 File Offset: 0x00198E71
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<HonamiStoryTopInfo> HonamiStoryTopInfos
		{
			get
			{
				return this.honamiStoryTopInfos_;
			}
		}

		// Token: 0x1700226D RID: 8813
		// (get) Token: 0x0600AAC8 RID: 43720 RVA: 0x0019AC79 File Offset: 0x00198E79
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<HonamiStoryTalentInfo> HonamiStoryTalentInfos
		{
			get
			{
				return this.honamiStoryTalentInfos_;
			}
		}

		// Token: 0x1700226E RID: 8814
		// (get) Token: 0x0600AAC9 RID: 43721 RVA: 0x0019AC81 File Offset: 0x00198E81
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ConditionTask> HonamiStoryResidentTask
		{
			get
			{
				return this.honamiStoryResidentTask_;
			}
		}

		// Token: 0x1700226F RID: 8815
		// (get) Token: 0x0600AACA RID: 43722 RVA: 0x0019AC89 File Offset: 0x00198E89
		// (set) Token: 0x0600AACB RID: 43723 RVA: 0x0019AC91 File Offset: 0x00198E91
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TotalRevenue
		{
			get
			{
				return this.totalRevenue_;
			}
			set
			{
				this.totalRevenue_ = value;
			}
		}

		// Token: 0x0600AACC RID: 43724 RVA: 0x0019AC9A File Offset: 0x00198E9A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HonamiStoryActivityInfo);
		}

		// Token: 0x0600AACD RID: 43725 RVA: 0x0019ACA8 File Offset: 0x00198EA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HonamiStoryActivityInfo other)
		{
			return other != null && (other == this || (object.Equals(this.HonamiStoryPlayerBagInfo, other.HonamiStoryPlayerBagInfo) && this.activatedTalentId_.Equals(other.activatedTalentId_) && this.honamiStoryItemCollectionInfos_.Equals(other.honamiStoryItemCollectionInfos_) && this.honamiStoryMascotInfos_.Equals(other.honamiStoryMascotInfos_) && this.honamiStoryAreaInfos_.Equals(other.honamiStoryAreaInfos_) && this.honamiStoryLimitTask_.Equals(other.honamiStoryLimitTask_) && this.areaTask_.Equals(other.areaTask_) && this.honamiStoryScoreRewardInfos_.Equals(other.honamiStoryScoreRewardInfos_) && this.LifeSupportLevel == other.LifeSupportLevel && this.LimitShopConsumeItemNum == other.LimitShopConsumeItemNum && this.honamiStoryTopInfos_.Equals(other.honamiStoryTopInfos_) && this.honamiStoryTalentInfos_.Equals(other.honamiStoryTalentInfos_) && this.honamiStoryResidentTask_.Equals(other.honamiStoryResidentTask_) && this.TotalRevenue == other.TotalRevenue && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600AACE RID: 43726 RVA: 0x0019ADE8 File Offset: 0x00198FE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.honamiStoryPlayerBagInfo_ != null)
			{
				num ^= this.HonamiStoryPlayerBagInfo.GetHashCode();
			}
			num ^= this.activatedTalentId_.GetHashCode();
			num ^= this.honamiStoryItemCollectionInfos_.GetHashCode();
			num ^= this.honamiStoryMascotInfos_.GetHashCode();
			num ^= this.honamiStoryAreaInfos_.GetHashCode();
			num ^= this.honamiStoryLimitTask_.GetHashCode();
			num ^= this.areaTask_.GetHashCode();
			num ^= this.honamiStoryScoreRewardInfos_.GetHashCode();
			if (this.LifeSupportLevel != 0)
			{
				num ^= this.LifeSupportLevel.GetHashCode();
			}
			if (this.LimitShopConsumeItemNum != 0)
			{
				num ^= this.LimitShopConsumeItemNum.GetHashCode();
			}
			num ^= this.honamiStoryTopInfos_.GetHashCode();
			num ^= this.honamiStoryTalentInfos_.GetHashCode();
			num ^= this.honamiStoryResidentTask_.GetHashCode();
			if (this.TotalRevenue != 0)
			{
				num ^= this.TotalRevenue.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600AACF RID: 43727 RVA: 0x0019AEFB File Offset: 0x001990FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600AAD0 RID: 43728 RVA: 0x0019AF08 File Offset: 0x00199108
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600AAD1 RID: 43729 RVA: 0x0019AF14 File Offset: 0x00199114
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.honamiStoryPlayerBagInfo_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.HonamiStoryPlayerBagInfo);
			}
			this.activatedTalentId_.WriteTo(ref output, HonamiStoryActivityInfo._repeated_activatedTalentId_codec);
			this.honamiStoryItemCollectionInfos_.WriteTo(ref output, HonamiStoryActivityInfo._repeated_honamiStoryItemCollectionInfos_codec);
			this.honamiStoryMascotInfos_.WriteTo(ref output, HonamiStoryActivityInfo._repeated_honamiStoryMascotInfos_codec);
			this.honamiStoryAreaInfos_.WriteTo(ref output, HonamiStoryActivityInfo._repeated_honamiStoryAreaInfos_codec);
			this.honamiStoryLimitTask_.WriteTo(ref output, HonamiStoryActivityInfo._repeated_honamiStoryLimitTask_codec);
			this.areaTask_.WriteTo(ref output, HonamiStoryActivityInfo._repeated_areaTask_codec);
			this.honamiStoryScoreRewardInfos_.WriteTo(ref output, HonamiStoryActivityInfo._repeated_honamiStoryScoreRewardInfos_codec);
			if (this.LifeSupportLevel != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.LifeSupportLevel);
			}
			if (this.LimitShopConsumeItemNum != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.LimitShopConsumeItemNum);
			}
			this.honamiStoryTopInfos_.WriteTo(ref output, HonamiStoryActivityInfo._repeated_honamiStoryTopInfos_codec);
			this.honamiStoryTalentInfos_.WriteTo(ref output, HonamiStoryActivityInfo._repeated_honamiStoryTalentInfos_codec);
			this.honamiStoryResidentTask_.WriteTo(ref output, HonamiStoryActivityInfo._repeated_honamiStoryResidentTask_codec);
			if (this.TotalRevenue != 0)
			{
				output.WriteRawTag(120);
				output.WriteInt32(this.TotalRevenue);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600AAD2 RID: 43730 RVA: 0x0019B050 File Offset: 0x00199250
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.honamiStoryPlayerBagInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.HonamiStoryPlayerBagInfo);
			}
			num += this.activatedTalentId_.CalculateSize(HonamiStoryActivityInfo._repeated_activatedTalentId_codec);
			num += this.honamiStoryItemCollectionInfos_.CalculateSize(HonamiStoryActivityInfo._repeated_honamiStoryItemCollectionInfos_codec);
			num += this.honamiStoryMascotInfos_.CalculateSize(HonamiStoryActivityInfo._repeated_honamiStoryMascotInfos_codec);
			num += this.honamiStoryAreaInfos_.CalculateSize(HonamiStoryActivityInfo._repeated_honamiStoryAreaInfos_codec);
			num += this.honamiStoryLimitTask_.CalculateSize(HonamiStoryActivityInfo._repeated_honamiStoryLimitTask_codec);
			num += this.areaTask_.CalculateSize(HonamiStoryActivityInfo._repeated_areaTask_codec);
			num += this.honamiStoryScoreRewardInfos_.CalculateSize(HonamiStoryActivityInfo._repeated_honamiStoryScoreRewardInfos_codec);
			if (this.LifeSupportLevel != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.LifeSupportLevel);
			}
			if (this.LimitShopConsumeItemNum != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.LimitShopConsumeItemNum);
			}
			num += this.honamiStoryTopInfos_.CalculateSize(HonamiStoryActivityInfo._repeated_honamiStoryTopInfos_codec);
			num += this.honamiStoryTalentInfos_.CalculateSize(HonamiStoryActivityInfo._repeated_honamiStoryTalentInfos_codec);
			num += this.honamiStoryResidentTask_.CalculateSize(HonamiStoryActivityInfo._repeated_honamiStoryResidentTask_codec);
			if (this.TotalRevenue != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TotalRevenue);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600AAD3 RID: 43731 RVA: 0x0019B194 File Offset: 0x00199394
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(HonamiStoryActivityInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.honamiStoryPlayerBagInfo_ != null)
			{
				if (this.honamiStoryPlayerBagInfo_ == null)
				{
					this.HonamiStoryPlayerBagInfo = new HonamiStoryPlayerBagInfo();
				}
				this.HonamiStoryPlayerBagInfo.MergeFrom(other.HonamiStoryPlayerBagInfo);
			}
			this.activatedTalentId_.Add(other.activatedTalentId_);
			this.honamiStoryItemCollectionInfos_.Add(other.honamiStoryItemCollectionInfos_);
			this.honamiStoryMascotInfos_.Add(other.honamiStoryMascotInfos_);
			this.honamiStoryAreaInfos_.Add(other.honamiStoryAreaInfos_);
			this.honamiStoryLimitTask_.Add(other.honamiStoryLimitTask_);
			this.areaTask_.Add(other.areaTask_);
			this.honamiStoryScoreRewardInfos_.Add(other.honamiStoryScoreRewardInfos_);
			if (other.LifeSupportLevel != 0)
			{
				this.LifeSupportLevel = other.LifeSupportLevel;
			}
			if (other.LimitShopConsumeItemNum != 0)
			{
				this.LimitShopConsumeItemNum = other.LimitShopConsumeItemNum;
			}
			this.honamiStoryTopInfos_.Add(other.honamiStoryTopInfos_);
			this.honamiStoryTalentInfos_.Add(other.honamiStoryTalentInfos_);
			this.honamiStoryResidentTask_.Add(other.honamiStoryResidentTask_);
			if (other.TotalRevenue != 0)
			{
				this.TotalRevenue = other.TotalRevenue;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600AAD4 RID: 43732 RVA: 0x0019B2CE File Offset: 0x001994CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600AAD5 RID: 43733 RVA: 0x0019B2D8 File Offset: 0x001994D8
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
				if (num <= 50U)
				{
					if (num <= 18U)
					{
						if (num == 10U)
						{
							if (this.honamiStoryPlayerBagInfo_ == null)
							{
								this.HonamiStoryPlayerBagInfo = new HonamiStoryPlayerBagInfo();
							}
							input.ReadMessage(this.HonamiStoryPlayerBagInfo);
							continue;
						}
						if (num == 16U || num == 18U)
						{
							this.activatedTalentId_.AddEntriesFrom(ref input, HonamiStoryActivityInfo._repeated_activatedTalentId_codec);
							continue;
						}
					}
					else if (num <= 34U)
					{
						if (num == 26U)
						{
							this.honamiStoryItemCollectionInfos_.AddEntriesFrom(ref input, HonamiStoryActivityInfo._repeated_honamiStoryItemCollectionInfos_codec);
							continue;
						}
						if (num == 34U)
						{
							this.honamiStoryMascotInfos_.AddEntriesFrom(ref input, HonamiStoryActivityInfo._repeated_honamiStoryMascotInfos_codec);
							continue;
						}
					}
					else
					{
						if (num == 42U)
						{
							this.honamiStoryAreaInfos_.AddEntriesFrom(ref input, HonamiStoryActivityInfo._repeated_honamiStoryAreaInfos_codec);
							continue;
						}
						if (num == 50U)
						{
							this.honamiStoryLimitTask_.AddEntriesFrom(ref input, HonamiStoryActivityInfo._repeated_honamiStoryLimitTask_codec);
							continue;
						}
					}
				}
				else if (num <= 88U)
				{
					if (num <= 66U)
					{
						if (num == 58U)
						{
							this.areaTask_.AddEntriesFrom(ref input, HonamiStoryActivityInfo._repeated_areaTask_codec);
							continue;
						}
						if (num == 66U)
						{
							this.honamiStoryScoreRewardInfos_.AddEntriesFrom(ref input, HonamiStoryActivityInfo._repeated_honamiStoryScoreRewardInfos_codec);
							continue;
						}
					}
					else
					{
						if (num == 80U)
						{
							this.LifeSupportLevel = input.ReadInt32();
							continue;
						}
						if (num == 88U)
						{
							this.LimitShopConsumeItemNum = input.ReadInt32();
							continue;
						}
					}
				}
				else if (num <= 106U)
				{
					if (num == 98U)
					{
						this.honamiStoryTopInfos_.AddEntriesFrom(ref input, HonamiStoryActivityInfo._repeated_honamiStoryTopInfos_codec);
						continue;
					}
					if (num == 106U)
					{
						this.honamiStoryTalentInfos_.AddEntriesFrom(ref input, HonamiStoryActivityInfo._repeated_honamiStoryTalentInfos_codec);
						continue;
					}
				}
				else
				{
					if (num == 114U)
					{
						this.honamiStoryResidentTask_.AddEntriesFrom(ref input, HonamiStoryActivityInfo._repeated_honamiStoryResidentTask_codec);
						continue;
					}
					if (num == 120U)
					{
						this.TotalRevenue = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04004D8A RID: 19850
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004D8B RID: 19851
		public const int HonamiStoryPlayerBagInfoFieldNumber = 1;

		// Token: 0x04004D8C RID: 19852
		private HonamiStoryPlayerBagInfo honamiStoryPlayerBagInfo_;

		// Token: 0x04004D8D RID: 19853
		public const int ActivatedTalentIdFieldNumber = 2;

		// Token: 0x04004D8E RID: 19854
		private static readonly FieldCodec<int> _repeated_activatedTalentId_codec = FieldCodec.ForInt32(18U);

		// Token: 0x04004D8F RID: 19855
		private readonly RepeatedField<int> activatedTalentId_ = new RepeatedField<int>();

		// Token: 0x04004D90 RID: 19856
		public const int HonamiStoryItemCollectionInfosFieldNumber = 3;

		// Token: 0x04004D91 RID: 19857
		private static readonly FieldCodec<HonamiStoryItemCollectionInfo> _repeated_honamiStoryItemCollectionInfos_codec = FieldCodec.ForMessage<HonamiStoryItemCollectionInfo>(26U, HonamiStoryItemCollectionInfo.Parser);

		// Token: 0x04004D92 RID: 19858
		private readonly RepeatedField<HonamiStoryItemCollectionInfo> honamiStoryItemCollectionInfos_ = new RepeatedField<HonamiStoryItemCollectionInfo>();

		// Token: 0x04004D93 RID: 19859
		public const int HonamiStoryMascotInfosFieldNumber = 4;

		// Token: 0x04004D94 RID: 19860
		private static readonly FieldCodec<HonamiStoryMascotInfo> _repeated_honamiStoryMascotInfos_codec = FieldCodec.ForMessage<HonamiStoryMascotInfo>(34U, HonamiStoryMascotInfo.Parser);

		// Token: 0x04004D95 RID: 19861
		private readonly RepeatedField<HonamiStoryMascotInfo> honamiStoryMascotInfos_ = new RepeatedField<HonamiStoryMascotInfo>();

		// Token: 0x04004D96 RID: 19862
		public const int HonamiStoryAreaInfosFieldNumber = 5;

		// Token: 0x04004D97 RID: 19863
		private static readonly FieldCodec<HonamiStoryAreaInfo> _repeated_honamiStoryAreaInfos_codec = FieldCodec.ForMessage<HonamiStoryAreaInfo>(42U, HonamiStoryAreaInfo.Parser);

		// Token: 0x04004D98 RID: 19864
		private readonly RepeatedField<HonamiStoryAreaInfo> honamiStoryAreaInfos_ = new RepeatedField<HonamiStoryAreaInfo>();

		// Token: 0x04004D99 RID: 19865
		public const int HonamiStoryLimitTaskFieldNumber = 6;

		// Token: 0x04004D9A RID: 19866
		private static readonly FieldCodec<ConditionTask> _repeated_honamiStoryLimitTask_codec = FieldCodec.ForMessage<ConditionTask>(50U, ConditionTask.Parser);

		// Token: 0x04004D9B RID: 19867
		private readonly RepeatedField<ConditionTask> honamiStoryLimitTask_ = new RepeatedField<ConditionTask>();

		// Token: 0x04004D9C RID: 19868
		public const int AreaTaskFieldNumber = 7;

		// Token: 0x04004D9D RID: 19869
		private static readonly FieldCodec<ConditionTask> _repeated_areaTask_codec = FieldCodec.ForMessage<ConditionTask>(58U, ConditionTask.Parser);

		// Token: 0x04004D9E RID: 19870
		private readonly RepeatedField<ConditionTask> areaTask_ = new RepeatedField<ConditionTask>();

		// Token: 0x04004D9F RID: 19871
		public const int HonamiStoryScoreRewardInfosFieldNumber = 8;

		// Token: 0x04004DA0 RID: 19872
		private static readonly FieldCodec<HonamiStoryScoreRewardInfo> _repeated_honamiStoryScoreRewardInfos_codec = FieldCodec.ForMessage<HonamiStoryScoreRewardInfo>(66U, HonamiStoryScoreRewardInfo.Parser);

		// Token: 0x04004DA1 RID: 19873
		private readonly RepeatedField<HonamiStoryScoreRewardInfo> honamiStoryScoreRewardInfos_ = new RepeatedField<HonamiStoryScoreRewardInfo>();

		// Token: 0x04004DA2 RID: 19874
		public const int LifeSupportLevelFieldNumber = 10;

		// Token: 0x04004DA3 RID: 19875
		private int lifeSupportLevel_;

		// Token: 0x04004DA4 RID: 19876
		public const int LimitShopConsumeItemNumFieldNumber = 11;

		// Token: 0x04004DA5 RID: 19877
		private int limitShopConsumeItemNum_;

		// Token: 0x04004DA6 RID: 19878
		public const int HonamiStoryTopInfosFieldNumber = 12;

		// Token: 0x04004DA7 RID: 19879
		private static readonly FieldCodec<HonamiStoryTopInfo> _repeated_honamiStoryTopInfos_codec = FieldCodec.ForMessage<HonamiStoryTopInfo>(98U, HonamiStoryTopInfo.Parser);

		// Token: 0x04004DA8 RID: 19880
		private readonly RepeatedField<HonamiStoryTopInfo> honamiStoryTopInfos_ = new RepeatedField<HonamiStoryTopInfo>();

		// Token: 0x04004DA9 RID: 19881
		public const int HonamiStoryTalentInfosFieldNumber = 13;

		// Token: 0x04004DAA RID: 19882
		private static readonly FieldCodec<HonamiStoryTalentInfo> _repeated_honamiStoryTalentInfos_codec = FieldCodec.ForMessage<HonamiStoryTalentInfo>(106U, HonamiStoryTalentInfo.Parser);

		// Token: 0x04004DAB RID: 19883
		private readonly RepeatedField<HonamiStoryTalentInfo> honamiStoryTalentInfos_ = new RepeatedField<HonamiStoryTalentInfo>();

		// Token: 0x04004DAC RID: 19884
		public const int HonamiStoryResidentTaskFieldNumber = 14;

		// Token: 0x04004DAD RID: 19885
		private static readonly FieldCodec<ConditionTask> _repeated_honamiStoryResidentTask_codec = FieldCodec.ForMessage<ConditionTask>(114U, ConditionTask.Parser);

		// Token: 0x04004DAE RID: 19886
		private readonly RepeatedField<ConditionTask> honamiStoryResidentTask_ = new RepeatedField<ConditionTask>();

		// Token: 0x04004DAF RID: 19887
		public const int TotalRevenueFieldNumber = 15;

		// Token: 0x04004DB0 RID: 19888
		private int totalRevenue_;
	}
}
