using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200074A RID: 1866
	public sealed class HonamiStoryActivityInfo : IMessage<HonamiStoryActivityInfo>, IMessage, IEquatable<HonamiStoryActivityInfo>, IDeepCloneable<HonamiStoryActivityInfo>, IBufferMessage
	{
		// Token: 0x0600A95E RID: 43358 RVA: 0x00198030 File Offset: 0x00196230
		[NullableContext(1)]
		public static HonamiStoryActivityInfo Create()
		{
			return new HonamiStoryActivityInfo();
		}

		// Token: 0x17002216 RID: 8726
		// (get) Token: 0x0600A95F RID: 43359 RVA: 0x00198037 File Offset: 0x00196237
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002217 RID: 8727
		// (get) Token: 0x0600A960 RID: 43360 RVA: 0x0019803A File Offset: 0x0019623A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HonamiStoryActivityInfo.Descriptor;
			}
		}

		// Token: 0x0600A961 RID: 43361 RVA: 0x00198044 File Offset: 0x00196244
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryActivityInfo()
		{
		}

		// Token: 0x0600A962 RID: 43362 RVA: 0x001980C8 File Offset: 0x001962C8
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

		// Token: 0x0600A963 RID: 43363 RVA: 0x001981D6 File Offset: 0x001963D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryActivityInfo Clone()
		{
			return new HonamiStoryActivityInfo(this);
		}

		// Token: 0x17002218 RID: 8728
		// (get) Token: 0x0600A964 RID: 43364 RVA: 0x001981DE File Offset: 0x001963DE
		// (set) Token: 0x0600A965 RID: 43365 RVA: 0x001981E6 File Offset: 0x001963E6
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

		// Token: 0x17002219 RID: 8729
		// (get) Token: 0x0600A966 RID: 43366 RVA: 0x001981EF File Offset: 0x001963EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> ActivatedTalentId
		{
			get
			{
				return this.activatedTalentId_;
			}
		}

		// Token: 0x1700221A RID: 8730
		// (get) Token: 0x0600A967 RID: 43367 RVA: 0x001981F7 File Offset: 0x001963F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<HonamiStoryItemCollectionInfo> HonamiStoryItemCollectionInfos
		{
			get
			{
				return this.honamiStoryItemCollectionInfos_;
			}
		}

		// Token: 0x1700221B RID: 8731
		// (get) Token: 0x0600A968 RID: 43368 RVA: 0x001981FF File Offset: 0x001963FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<HonamiStoryMascotInfo> HonamiStoryMascotInfos
		{
			get
			{
				return this.honamiStoryMascotInfos_;
			}
		}

		// Token: 0x1700221C RID: 8732
		// (get) Token: 0x0600A969 RID: 43369 RVA: 0x00198207 File Offset: 0x00196407
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<HonamiStoryAreaInfo> HonamiStoryAreaInfos
		{
			get
			{
				return this.honamiStoryAreaInfos_;
			}
		}

		// Token: 0x1700221D RID: 8733
		// (get) Token: 0x0600A96A RID: 43370 RVA: 0x0019820F File Offset: 0x0019640F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ConditionTask> HonamiStoryLimitTask
		{
			get
			{
				return this.honamiStoryLimitTask_;
			}
		}

		// Token: 0x1700221E RID: 8734
		// (get) Token: 0x0600A96B RID: 43371 RVA: 0x00198217 File Offset: 0x00196417
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ConditionTask> AreaTask
		{
			get
			{
				return this.areaTask_;
			}
		}

		// Token: 0x1700221F RID: 8735
		// (get) Token: 0x0600A96C RID: 43372 RVA: 0x0019821F File Offset: 0x0019641F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<HonamiStoryScoreRewardInfo> HonamiStoryScoreRewardInfos
		{
			get
			{
				return this.honamiStoryScoreRewardInfos_;
			}
		}

		// Token: 0x17002220 RID: 8736
		// (get) Token: 0x0600A96D RID: 43373 RVA: 0x00198227 File Offset: 0x00196427
		// (set) Token: 0x0600A96E RID: 43374 RVA: 0x0019822F File Offset: 0x0019642F
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

		// Token: 0x17002221 RID: 8737
		// (get) Token: 0x0600A96F RID: 43375 RVA: 0x00198238 File Offset: 0x00196438
		// (set) Token: 0x0600A970 RID: 43376 RVA: 0x00198240 File Offset: 0x00196440
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

		// Token: 0x17002222 RID: 8738
		// (get) Token: 0x0600A971 RID: 43377 RVA: 0x00198249 File Offset: 0x00196449
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<HonamiStoryTopInfo> HonamiStoryTopInfos
		{
			get
			{
				return this.honamiStoryTopInfos_;
			}
		}

		// Token: 0x17002223 RID: 8739
		// (get) Token: 0x0600A972 RID: 43378 RVA: 0x00198251 File Offset: 0x00196451
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<HonamiStoryTalentInfo> HonamiStoryTalentInfos
		{
			get
			{
				return this.honamiStoryTalentInfos_;
			}
		}

		// Token: 0x17002224 RID: 8740
		// (get) Token: 0x0600A973 RID: 43379 RVA: 0x00198259 File Offset: 0x00196459
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ConditionTask> HonamiStoryResidentTask
		{
			get
			{
				return this.honamiStoryResidentTask_;
			}
		}

		// Token: 0x17002225 RID: 8741
		// (get) Token: 0x0600A974 RID: 43380 RVA: 0x00198261 File Offset: 0x00196461
		// (set) Token: 0x0600A975 RID: 43381 RVA: 0x00198269 File Offset: 0x00196469
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

		// Token: 0x0600A976 RID: 43382 RVA: 0x00198272 File Offset: 0x00196472
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HonamiStoryActivityInfo);
		}

		// Token: 0x0600A977 RID: 43383 RVA: 0x00198280 File Offset: 0x00196480
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HonamiStoryActivityInfo other)
		{
			return other != null && (other == this || (object.Equals(this.HonamiStoryPlayerBagInfo, other.HonamiStoryPlayerBagInfo) && this.activatedTalentId_.Equals(other.activatedTalentId_) && this.honamiStoryItemCollectionInfos_.Equals(other.honamiStoryItemCollectionInfos_) && this.honamiStoryMascotInfos_.Equals(other.honamiStoryMascotInfos_) && this.honamiStoryAreaInfos_.Equals(other.honamiStoryAreaInfos_) && this.honamiStoryLimitTask_.Equals(other.honamiStoryLimitTask_) && this.areaTask_.Equals(other.areaTask_) && this.honamiStoryScoreRewardInfos_.Equals(other.honamiStoryScoreRewardInfos_) && this.LifeSupportLevel == other.LifeSupportLevel && this.LimitShopConsumeItemNum == other.LimitShopConsumeItemNum && this.honamiStoryTopInfos_.Equals(other.honamiStoryTopInfos_) && this.honamiStoryTalentInfos_.Equals(other.honamiStoryTalentInfos_) && this.honamiStoryResidentTask_.Equals(other.honamiStoryResidentTask_) && this.TotalRevenue == other.TotalRevenue && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A978 RID: 43384 RVA: 0x001983C0 File Offset: 0x001965C0
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

		// Token: 0x0600A979 RID: 43385 RVA: 0x001984D3 File Offset: 0x001966D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600A97A RID: 43386 RVA: 0x001984E0 File Offset: 0x001966E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A97B RID: 43387 RVA: 0x001984EC File Offset: 0x001966EC
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

		// Token: 0x0600A97C RID: 43388 RVA: 0x00198628 File Offset: 0x00196828
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

		// Token: 0x0600A97D RID: 43389 RVA: 0x0019876C File Offset: 0x0019696C
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

		// Token: 0x0600A97E RID: 43390 RVA: 0x001988A6 File Offset: 0x00196AA6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A97F RID: 43391 RVA: 0x001988B0 File Offset: 0x00196AB0
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

		// Token: 0x04004D83 RID: 19843
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004D84 RID: 19844
		public const int HonamiStoryPlayerBagInfoFieldNumber = 1;

		// Token: 0x04004D85 RID: 19845
		private HonamiStoryPlayerBagInfo honamiStoryPlayerBagInfo_;

		// Token: 0x04004D86 RID: 19846
		public const int ActivatedTalentIdFieldNumber = 2;

		// Token: 0x04004D87 RID: 19847
		private static readonly FieldCodec<int> _repeated_activatedTalentId_codec = FieldCodec.ForInt32(18U);

		// Token: 0x04004D88 RID: 19848
		private readonly RepeatedField<int> activatedTalentId_ = new RepeatedField<int>();

		// Token: 0x04004D89 RID: 19849
		public const int HonamiStoryItemCollectionInfosFieldNumber = 3;

		// Token: 0x04004D8A RID: 19850
		private static readonly FieldCodec<HonamiStoryItemCollectionInfo> _repeated_honamiStoryItemCollectionInfos_codec = FieldCodec.ForMessage<HonamiStoryItemCollectionInfo>(26U, HonamiStoryItemCollectionInfo.Parser);

		// Token: 0x04004D8B RID: 19851
		private readonly RepeatedField<HonamiStoryItemCollectionInfo> honamiStoryItemCollectionInfos_ = new RepeatedField<HonamiStoryItemCollectionInfo>();

		// Token: 0x04004D8C RID: 19852
		public const int HonamiStoryMascotInfosFieldNumber = 4;

		// Token: 0x04004D8D RID: 19853
		private static readonly FieldCodec<HonamiStoryMascotInfo> _repeated_honamiStoryMascotInfos_codec = FieldCodec.ForMessage<HonamiStoryMascotInfo>(34U, HonamiStoryMascotInfo.Parser);

		// Token: 0x04004D8E RID: 19854
		private readonly RepeatedField<HonamiStoryMascotInfo> honamiStoryMascotInfos_ = new RepeatedField<HonamiStoryMascotInfo>();

		// Token: 0x04004D8F RID: 19855
		public const int HonamiStoryAreaInfosFieldNumber = 5;

		// Token: 0x04004D90 RID: 19856
		private static readonly FieldCodec<HonamiStoryAreaInfo> _repeated_honamiStoryAreaInfos_codec = FieldCodec.ForMessage<HonamiStoryAreaInfo>(42U, HonamiStoryAreaInfo.Parser);

		// Token: 0x04004D91 RID: 19857
		private readonly RepeatedField<HonamiStoryAreaInfo> honamiStoryAreaInfos_ = new RepeatedField<HonamiStoryAreaInfo>();

		// Token: 0x04004D92 RID: 19858
		public const int HonamiStoryLimitTaskFieldNumber = 6;

		// Token: 0x04004D93 RID: 19859
		private static readonly FieldCodec<ConditionTask> _repeated_honamiStoryLimitTask_codec = FieldCodec.ForMessage<ConditionTask>(50U, ConditionTask.Parser);

		// Token: 0x04004D94 RID: 19860
		private readonly RepeatedField<ConditionTask> honamiStoryLimitTask_ = new RepeatedField<ConditionTask>();

		// Token: 0x04004D95 RID: 19861
		public const int AreaTaskFieldNumber = 7;

		// Token: 0x04004D96 RID: 19862
		private static readonly FieldCodec<ConditionTask> _repeated_areaTask_codec = FieldCodec.ForMessage<ConditionTask>(58U, ConditionTask.Parser);

		// Token: 0x04004D97 RID: 19863
		private readonly RepeatedField<ConditionTask> areaTask_ = new RepeatedField<ConditionTask>();

		// Token: 0x04004D98 RID: 19864
		public const int HonamiStoryScoreRewardInfosFieldNumber = 8;

		// Token: 0x04004D99 RID: 19865
		private static readonly FieldCodec<HonamiStoryScoreRewardInfo> _repeated_honamiStoryScoreRewardInfos_codec = FieldCodec.ForMessage<HonamiStoryScoreRewardInfo>(66U, HonamiStoryScoreRewardInfo.Parser);

		// Token: 0x04004D9A RID: 19866
		private readonly RepeatedField<HonamiStoryScoreRewardInfo> honamiStoryScoreRewardInfos_ = new RepeatedField<HonamiStoryScoreRewardInfo>();

		// Token: 0x04004D9B RID: 19867
		public const int LifeSupportLevelFieldNumber = 10;

		// Token: 0x04004D9C RID: 19868
		private int lifeSupportLevel_;

		// Token: 0x04004D9D RID: 19869
		public const int LimitShopConsumeItemNumFieldNumber = 11;

		// Token: 0x04004D9E RID: 19870
		private int limitShopConsumeItemNum_;

		// Token: 0x04004D9F RID: 19871
		public const int HonamiStoryTopInfosFieldNumber = 12;

		// Token: 0x04004DA0 RID: 19872
		private static readonly FieldCodec<HonamiStoryTopInfo> _repeated_honamiStoryTopInfos_codec = FieldCodec.ForMessage<HonamiStoryTopInfo>(98U, HonamiStoryTopInfo.Parser);

		// Token: 0x04004DA1 RID: 19873
		private readonly RepeatedField<HonamiStoryTopInfo> honamiStoryTopInfos_ = new RepeatedField<HonamiStoryTopInfo>();

		// Token: 0x04004DA2 RID: 19874
		public const int HonamiStoryTalentInfosFieldNumber = 13;

		// Token: 0x04004DA3 RID: 19875
		private static readonly FieldCodec<HonamiStoryTalentInfo> _repeated_honamiStoryTalentInfos_codec = FieldCodec.ForMessage<HonamiStoryTalentInfo>(106U, HonamiStoryTalentInfo.Parser);

		// Token: 0x04004DA4 RID: 19876
		private readonly RepeatedField<HonamiStoryTalentInfo> honamiStoryTalentInfos_ = new RepeatedField<HonamiStoryTalentInfo>();

		// Token: 0x04004DA5 RID: 19877
		public const int HonamiStoryResidentTaskFieldNumber = 14;

		// Token: 0x04004DA6 RID: 19878
		private static readonly FieldCodec<ConditionTask> _repeated_honamiStoryResidentTask_codec = FieldCodec.ForMessage<ConditionTask>(114U, ConditionTask.Parser);

		// Token: 0x04004DA7 RID: 19879
		private readonly RepeatedField<ConditionTask> honamiStoryResidentTask_ = new RepeatedField<ConditionTask>();

		// Token: 0x04004DA8 RID: 19880
		public const int TotalRevenueFieldNumber = 15;

		// Token: 0x04004DA9 RID: 19881
		private int totalRevenue_;
	}
}
