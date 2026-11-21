using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200067D RID: 1661
	public sealed class GachaInfo : IMessage<GachaInfo>, IMessage, IEquatable<GachaInfo>, IDeepCloneable<GachaInfo>, IBufferMessage
	{
		// Token: 0x0600987F RID: 39039 RVA: 0x0016FDEC File Offset: 0x0016DFEC
		[NullableContext(1)]
		public static GachaInfo Create()
		{
			return new GachaInfo();
		}

		// Token: 0x17001E66 RID: 7782
		// (get) Token: 0x06009880 RID: 39040 RVA: 0x0016FDF3 File Offset: 0x0016DFF3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GachaInfo> Parser
		{
			get
			{
				return GachaInfo._parser;
			}
		}

		// Token: 0x17001E67 RID: 7783
		// (get) Token: 0x06009881 RID: 39041 RVA: 0x0016FDFA File Offset: 0x0016DFFA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001E68 RID: 7784
		// (get) Token: 0x06009882 RID: 39042 RVA: 0x0016FDFD File Offset: 0x0016DFFD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GachaInfo.Descriptor;
			}
		}

		// Token: 0x06009883 RID: 39043 RVA: 0x0016FE04 File Offset: 0x0016E004
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GachaInfo()
		{
		}

		// Token: 0x06009884 RID: 39044 RVA: 0x0016FE44 File Offset: 0x0016E044
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GachaInfo(GachaInfo other) : this()
		{
			this.id_ = other.id_;
			this.todayTimes_ = other.todayTimes_;
			this.totalTimes_ = other.totalTimes_;
			this.itemId_ = other.itemId_;
			this.gachaConsumes_ = other.gachaConsumes_.Clone();
			this.usePoolId_ = other.usePoolId_;
			this.pools_ = other.pools_.Clone();
			this.beginTime_ = other.beginTime_;
			this.endTime_ = other.endTime_;
			this.dailyLimitTimes_ = other.dailyLimitTimes_;
			this.totalLimitTimes_ = other.totalLimitTimes_;
			this.resourcesId_ = other.resourcesId_;
			this.gachaAccumulateId_ = other.gachaAccumulateId_;
			this.gachaDiscountInfos_ = other.gachaDiscountInfos_.Clone();
			this.onlyViewDiscount_ = other.onlyViewDiscount_;
			this.isShowProgress_ = other.isShowProgress_;
			this.discountTagDetails_ = other.discountTagDetails_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009885 RID: 39045 RVA: 0x0016FF48 File Offset: 0x0016E148
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GachaInfo Clone()
		{
			return new GachaInfo(this);
		}

		// Token: 0x17001E69 RID: 7785
		// (get) Token: 0x06009886 RID: 39046 RVA: 0x0016FF50 File Offset: 0x0016E150
		// (set) Token: 0x06009887 RID: 39047 RVA: 0x0016FF58 File Offset: 0x0016E158
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Id
		{
			get
			{
				return this.id_;
			}
			set
			{
				this.id_ = value;
			}
		}

		// Token: 0x17001E6A RID: 7786
		// (get) Token: 0x06009888 RID: 39048 RVA: 0x0016FF61 File Offset: 0x0016E161
		// (set) Token: 0x06009889 RID: 39049 RVA: 0x0016FF69 File Offset: 0x0016E169
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TodayTimes
		{
			get
			{
				return this.todayTimes_;
			}
			set
			{
				this.todayTimes_ = value;
			}
		}

		// Token: 0x17001E6B RID: 7787
		// (get) Token: 0x0600988A RID: 39050 RVA: 0x0016FF72 File Offset: 0x0016E172
		// (set) Token: 0x0600988B RID: 39051 RVA: 0x0016FF7A File Offset: 0x0016E17A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TotalTimes
		{
			get
			{
				return this.totalTimes_;
			}
			set
			{
				this.totalTimes_ = value;
			}
		}

		// Token: 0x17001E6C RID: 7788
		// (get) Token: 0x0600988C RID: 39052 RVA: 0x0016FF83 File Offset: 0x0016E183
		// (set) Token: 0x0600988D RID: 39053 RVA: 0x0016FF8B File Offset: 0x0016E18B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ItemId
		{
			get
			{
				return this.itemId_;
			}
			set
			{
				this.itemId_ = value;
			}
		}

		// Token: 0x17001E6D RID: 7789
		// (get) Token: 0x0600988E RID: 39054 RVA: 0x0016FF94 File Offset: 0x0016E194
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<GachaConsume> GachaConsumes
		{
			get
			{
				return this.gachaConsumes_;
			}
		}

		// Token: 0x17001E6E RID: 7790
		// (get) Token: 0x0600988F RID: 39055 RVA: 0x0016FF9C File Offset: 0x0016E19C
		// (set) Token: 0x06009890 RID: 39056 RVA: 0x0016FFA4 File Offset: 0x0016E1A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int UsePoolId
		{
			get
			{
				return this.usePoolId_;
			}
			set
			{
				this.usePoolId_ = value;
			}
		}

		// Token: 0x17001E6F RID: 7791
		// (get) Token: 0x06009891 RID: 39057 RVA: 0x0016FFAD File Offset: 0x0016E1AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<GachaPoolInfo> Pools
		{
			get
			{
				return this.pools_;
			}
		}

		// Token: 0x17001E70 RID: 7792
		// (get) Token: 0x06009892 RID: 39058 RVA: 0x0016FFB5 File Offset: 0x0016E1B5
		// (set) Token: 0x06009893 RID: 39059 RVA: 0x0016FFBD File Offset: 0x0016E1BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long BeginTime
		{
			get
			{
				return this.beginTime_;
			}
			set
			{
				this.beginTime_ = value;
			}
		}

		// Token: 0x17001E71 RID: 7793
		// (get) Token: 0x06009894 RID: 39060 RVA: 0x0016FFC6 File Offset: 0x0016E1C6
		// (set) Token: 0x06009895 RID: 39061 RVA: 0x0016FFCE File Offset: 0x0016E1CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long EndTime
		{
			get
			{
				return this.endTime_;
			}
			set
			{
				this.endTime_ = value;
			}
		}

		// Token: 0x17001E72 RID: 7794
		// (get) Token: 0x06009896 RID: 39062 RVA: 0x0016FFD7 File Offset: 0x0016E1D7
		// (set) Token: 0x06009897 RID: 39063 RVA: 0x0016FFDF File Offset: 0x0016E1DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int DailyLimitTimes
		{
			get
			{
				return this.dailyLimitTimes_;
			}
			set
			{
				this.dailyLimitTimes_ = value;
			}
		}

		// Token: 0x17001E73 RID: 7795
		// (get) Token: 0x06009898 RID: 39064 RVA: 0x0016FFE8 File Offset: 0x0016E1E8
		// (set) Token: 0x06009899 RID: 39065 RVA: 0x0016FFF0 File Offset: 0x0016E1F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TotalLimitTimes
		{
			get
			{
				return this.totalLimitTimes_;
			}
			set
			{
				this.totalLimitTimes_ = value;
			}
		}

		// Token: 0x17001E74 RID: 7796
		// (get) Token: 0x0600989A RID: 39066 RVA: 0x0016FFF9 File Offset: 0x0016E1F9
		// (set) Token: 0x0600989B RID: 39067 RVA: 0x00170001 File Offset: 0x0016E201
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string ResourcesId
		{
			get
			{
				return this.resourcesId_;
			}
			set
			{
				this.resourcesId_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17001E75 RID: 7797
		// (get) Token: 0x0600989C RID: 39068 RVA: 0x00170014 File Offset: 0x0016E214
		// (set) Token: 0x0600989D RID: 39069 RVA: 0x0017001C File Offset: 0x0016E21C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int GachaAccumulateId
		{
			get
			{
				return this.gachaAccumulateId_;
			}
			set
			{
				this.gachaAccumulateId_ = value;
			}
		}

		// Token: 0x17001E76 RID: 7798
		// (get) Token: 0x0600989E RID: 39070 RVA: 0x00170025 File Offset: 0x0016E225
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<GachaDiscountInfo> GachaDiscountInfos
		{
			get
			{
				return this.gachaDiscountInfos_;
			}
		}

		// Token: 0x17001E77 RID: 7799
		// (get) Token: 0x0600989F RID: 39071 RVA: 0x0017002D File Offset: 0x0016E22D
		// (set) Token: 0x060098A0 RID: 39072 RVA: 0x00170035 File Offset: 0x0016E235
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool OnlyViewDiscount
		{
			get
			{
				return this.onlyViewDiscount_;
			}
			set
			{
				this.onlyViewDiscount_ = value;
			}
		}

		// Token: 0x17001E78 RID: 7800
		// (get) Token: 0x060098A1 RID: 39073 RVA: 0x0017003E File Offset: 0x0016E23E
		// (set) Token: 0x060098A2 RID: 39074 RVA: 0x00170046 File Offset: 0x0016E246
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsShowProgress
		{
			get
			{
				return this.isShowProgress_;
			}
			set
			{
				this.isShowProgress_ = value;
			}
		}

		// Token: 0x17001E79 RID: 7801
		// (get) Token: 0x060098A3 RID: 39075 RVA: 0x0017004F File Offset: 0x0016E24F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, string> DiscountTagDetails
		{
			get
			{
				return this.discountTagDetails_;
			}
		}

		// Token: 0x060098A4 RID: 39076 RVA: 0x00170057 File Offset: 0x0016E257
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GachaInfo);
		}

		// Token: 0x060098A5 RID: 39077 RVA: 0x00170068 File Offset: 0x0016E268
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GachaInfo other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.TodayTimes == other.TodayTimes && this.TotalTimes == other.TotalTimes && this.ItemId == other.ItemId && this.gachaConsumes_.Equals(other.gachaConsumes_) && this.UsePoolId == other.UsePoolId && this.pools_.Equals(other.pools_) && this.BeginTime == other.BeginTime && this.EndTime == other.EndTime && this.DailyLimitTimes == other.DailyLimitTimes && this.TotalLimitTimes == other.TotalLimitTimes && !(this.ResourcesId != other.ResourcesId) && this.GachaAccumulateId == other.GachaAccumulateId && this.gachaDiscountInfos_.Equals(other.gachaDiscountInfos_) && this.OnlyViewDiscount == other.OnlyViewDiscount && this.IsShowProgress == other.IsShowProgress && this.DiscountTagDetails.Equals(other.DiscountTagDetails) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060098A6 RID: 39078 RVA: 0x001701BC File Offset: 0x0016E3BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.TodayTimes != 0)
			{
				num ^= this.TodayTimes.GetHashCode();
			}
			if (this.TotalTimes != 0)
			{
				num ^= this.TotalTimes.GetHashCode();
			}
			if (this.ItemId != 0)
			{
				num ^= this.ItemId.GetHashCode();
			}
			num ^= this.gachaConsumes_.GetHashCode();
			if (this.UsePoolId != 0)
			{
				num ^= this.UsePoolId.GetHashCode();
			}
			num ^= this.pools_.GetHashCode();
			if (this.BeginTime != 0L)
			{
				num ^= this.BeginTime.GetHashCode();
			}
			if (this.EndTime != 0L)
			{
				num ^= this.EndTime.GetHashCode();
			}
			if (this.DailyLimitTimes != 0)
			{
				num ^= this.DailyLimitTimes.GetHashCode();
			}
			if (this.TotalLimitTimes != 0)
			{
				num ^= this.TotalLimitTimes.GetHashCode();
			}
			if (this.ResourcesId.Length != 0)
			{
				num ^= this.ResourcesId.GetHashCode();
			}
			if (this.GachaAccumulateId != 0)
			{
				num ^= this.GachaAccumulateId.GetHashCode();
			}
			num ^= this.gachaDiscountInfos_.GetHashCode();
			if (this.OnlyViewDiscount)
			{
				num ^= this.OnlyViewDiscount.GetHashCode();
			}
			if (this.IsShowProgress)
			{
				num ^= this.IsShowProgress.GetHashCode();
			}
			num ^= this.DiscountTagDetails.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060098A7 RID: 39079 RVA: 0x00170361 File Offset: 0x0016E561
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060098A8 RID: 39080 RVA: 0x0017036E File Offset: 0x0016E56E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060098A9 RID: 39081 RVA: 0x00170378 File Offset: 0x0016E578
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Id);
			}
			if (this.TodayTimes != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.TodayTimes);
			}
			if (this.TotalTimes != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.TotalTimes);
			}
			if (this.ItemId != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.ItemId);
			}
			this.gachaConsumes_.WriteTo(ref output, GachaInfo._repeated_gachaConsumes_codec);
			if (this.UsePoolId != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.UsePoolId);
			}
			this.pools_.WriteTo(ref output, GachaInfo._repeated_pools_codec);
			if (this.BeginTime != 0L)
			{
				output.WriteRawTag(64);
				output.WriteInt64(this.BeginTime);
			}
			if (this.EndTime != 0L)
			{
				output.WriteRawTag(72);
				output.WriteInt64(this.EndTime);
			}
			if (this.DailyLimitTimes != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.DailyLimitTimes);
			}
			if (this.TotalLimitTimes != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.TotalLimitTimes);
			}
			if (this.ResourcesId.Length != 0)
			{
				output.WriteRawTag(98);
				output.WriteString(this.ResourcesId);
			}
			if (this.GachaAccumulateId != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.GachaAccumulateId);
			}
			this.gachaDiscountInfos_.WriteTo(ref output, GachaInfo._repeated_gachaDiscountInfos_codec);
			if (this.OnlyViewDiscount)
			{
				output.WriteRawTag(120);
				output.WriteBool(this.OnlyViewDiscount);
			}
			if (this.IsShowProgress)
			{
				output.WriteRawTag(128, 1);
				output.WriteBool(this.IsShowProgress);
			}
			this.discountTagDetails_.WriteTo(ref output, GachaInfo._map_discountTagDetails_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060098AA RID: 39082 RVA: 0x00170554 File Offset: 0x0016E754
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			if (this.TodayTimes != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TodayTimes);
			}
			if (this.TotalTimes != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TotalTimes);
			}
			if (this.ItemId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ItemId);
			}
			num += this.gachaConsumes_.CalculateSize(GachaInfo._repeated_gachaConsumes_codec);
			if (this.UsePoolId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.UsePoolId);
			}
			num += this.pools_.CalculateSize(GachaInfo._repeated_pools_codec);
			if (this.BeginTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.BeginTime);
			}
			if (this.EndTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EndTime);
			}
			if (this.DailyLimitTimes != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.DailyLimitTimes);
			}
			if (this.TotalLimitTimes != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TotalLimitTimes);
			}
			if (this.ResourcesId.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.ResourcesId);
			}
			if (this.GachaAccumulateId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.GachaAccumulateId);
			}
			num += this.gachaDiscountInfos_.CalculateSize(GachaInfo._repeated_gachaDiscountInfos_codec);
			if (this.OnlyViewDiscount)
			{
				num += 2;
			}
			if (this.IsShowProgress)
			{
				num += 3;
			}
			num += this.discountTagDetails_.CalculateSize(GachaInfo._map_discountTagDetails_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060098AB RID: 39083 RVA: 0x001706EC File Offset: 0x0016E8EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GachaInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			if (other.TodayTimes != 0)
			{
				this.TodayTimes = other.TodayTimes;
			}
			if (other.TotalTimes != 0)
			{
				this.TotalTimes = other.TotalTimes;
			}
			if (other.ItemId != 0)
			{
				this.ItemId = other.ItemId;
			}
			this.gachaConsumes_.Add(other.gachaConsumes_);
			if (other.UsePoolId != 0)
			{
				this.UsePoolId = other.UsePoolId;
			}
			this.pools_.Add(other.pools_);
			if (other.BeginTime != 0L)
			{
				this.BeginTime = other.BeginTime;
			}
			if (other.EndTime != 0L)
			{
				this.EndTime = other.EndTime;
			}
			if (other.DailyLimitTimes != 0)
			{
				this.DailyLimitTimes = other.DailyLimitTimes;
			}
			if (other.TotalLimitTimes != 0)
			{
				this.TotalLimitTimes = other.TotalLimitTimes;
			}
			if (other.ResourcesId.Length != 0)
			{
				this.ResourcesId = other.ResourcesId;
			}
			if (other.GachaAccumulateId != 0)
			{
				this.GachaAccumulateId = other.GachaAccumulateId;
			}
			this.gachaDiscountInfos_.Add(other.gachaDiscountInfos_);
			if (other.OnlyViewDiscount)
			{
				this.OnlyViewDiscount = other.OnlyViewDiscount;
			}
			if (other.IsShowProgress)
			{
				this.IsShowProgress = other.IsShowProgress;
			}
			this.discountTagDetails_.MergeFrom(other.discountTagDetails_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060098AC RID: 39084 RVA: 0x00170861 File Offset: 0x0016EA61
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060098AD RID: 39085 RVA: 0x0017086C File Offset: 0x0016EA6C
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
								this.Id = input.ReadInt32();
								continue;
							}
							if (num == 16U)
							{
								this.TodayTimes = input.ReadInt32();
								continue;
							}
						}
						else
						{
							if (num == 24U)
							{
								this.TotalTimes = input.ReadInt32();
								continue;
							}
							if (num == 32U)
							{
								this.ItemId = input.ReadInt32();
								continue;
							}
						}
					}
					else if (num <= 48U)
					{
						if (num == 42U)
						{
							this.gachaConsumes_.AddEntriesFrom(ref input, GachaInfo._repeated_gachaConsumes_codec);
							continue;
						}
						if (num == 48U)
						{
							this.UsePoolId = input.ReadInt32();
							continue;
						}
					}
					else
					{
						if (num == 58U)
						{
							this.pools_.AddEntriesFrom(ref input, GachaInfo._repeated_pools_codec);
							continue;
						}
						if (num == 64U)
						{
							this.BeginTime = input.ReadInt64();
							continue;
						}
					}
				}
				else if (num <= 98U)
				{
					if (num <= 80U)
					{
						if (num == 72U)
						{
							this.EndTime = input.ReadInt64();
							continue;
						}
						if (num == 80U)
						{
							this.DailyLimitTimes = input.ReadInt32();
							continue;
						}
					}
					else
					{
						if (num == 88U)
						{
							this.TotalLimitTimes = input.ReadInt32();
							continue;
						}
						if (num == 98U)
						{
							this.ResourcesId = input.ReadString();
							continue;
						}
					}
				}
				else if (num <= 114U)
				{
					if (num == 104U)
					{
						this.GachaAccumulateId = input.ReadInt32();
						continue;
					}
					if (num == 114U)
					{
						this.gachaDiscountInfos_.AddEntriesFrom(ref input, GachaInfo._repeated_gachaDiscountInfos_codec);
						continue;
					}
				}
				else
				{
					if (num == 120U)
					{
						this.OnlyViewDiscount = input.ReadBool();
						continue;
					}
					if (num == 128U)
					{
						this.IsShowProgress = input.ReadBool();
						continue;
					}
					if (num == 138U)
					{
						this.discountTagDetails_.AddEntriesFrom(ref input, GachaInfo._map_discountTagDetails_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040048AF RID: 18607
		private static readonly MessageParser<GachaInfo> _parser = new MessageParser<GachaInfo>(() => new GachaInfo());

		// Token: 0x040048B0 RID: 18608
		private UnknownFieldSet _unknownFields;

		// Token: 0x040048B1 RID: 18609
		public const int IdFieldNumber = 1;

		// Token: 0x040048B2 RID: 18610
		private int id_;

		// Token: 0x040048B3 RID: 18611
		public const int TodayTimesFieldNumber = 2;

		// Token: 0x040048B4 RID: 18612
		private int todayTimes_;

		// Token: 0x040048B5 RID: 18613
		public const int TotalTimesFieldNumber = 3;

		// Token: 0x040048B6 RID: 18614
		private int totalTimes_;

		// Token: 0x040048B7 RID: 18615
		public const int ItemIdFieldNumber = 4;

		// Token: 0x040048B8 RID: 18616
		private int itemId_;

		// Token: 0x040048B9 RID: 18617
		public const int GachaConsumesFieldNumber = 5;

		// Token: 0x040048BA RID: 18618
		private static readonly FieldCodec<GachaConsume> _repeated_gachaConsumes_codec = FieldCodec.ForMessage<GachaConsume>(42U, GachaConsume.Parser);

		// Token: 0x040048BB RID: 18619
		private readonly RepeatedField<GachaConsume> gachaConsumes_ = new RepeatedField<GachaConsume>();

		// Token: 0x040048BC RID: 18620
		public const int UsePoolIdFieldNumber = 6;

		// Token: 0x040048BD RID: 18621
		private int usePoolId_;

		// Token: 0x040048BE RID: 18622
		public const int PoolsFieldNumber = 7;

		// Token: 0x040048BF RID: 18623
		private static readonly FieldCodec<GachaPoolInfo> _repeated_pools_codec = FieldCodec.ForMessage<GachaPoolInfo>(58U, GachaPoolInfo.Parser);

		// Token: 0x040048C0 RID: 18624
		private readonly RepeatedField<GachaPoolInfo> pools_ = new RepeatedField<GachaPoolInfo>();

		// Token: 0x040048C1 RID: 18625
		public const int BeginTimeFieldNumber = 8;

		// Token: 0x040048C2 RID: 18626
		private long beginTime_;

		// Token: 0x040048C3 RID: 18627
		public const int EndTimeFieldNumber = 9;

		// Token: 0x040048C4 RID: 18628
		private long endTime_;

		// Token: 0x040048C5 RID: 18629
		public const int DailyLimitTimesFieldNumber = 10;

		// Token: 0x040048C6 RID: 18630
		private int dailyLimitTimes_;

		// Token: 0x040048C7 RID: 18631
		public const int TotalLimitTimesFieldNumber = 11;

		// Token: 0x040048C8 RID: 18632
		private int totalLimitTimes_;

		// Token: 0x040048C9 RID: 18633
		public const int ResourcesIdFieldNumber = 12;

		// Token: 0x040048CA RID: 18634
		private string resourcesId_ = "";

		// Token: 0x040048CB RID: 18635
		public const int GachaAccumulateIdFieldNumber = 13;

		// Token: 0x040048CC RID: 18636
		private int gachaAccumulateId_;

		// Token: 0x040048CD RID: 18637
		public const int GachaDiscountInfosFieldNumber = 14;

		// Token: 0x040048CE RID: 18638
		private static readonly FieldCodec<GachaDiscountInfo> _repeated_gachaDiscountInfos_codec = FieldCodec.ForMessage<GachaDiscountInfo>(114U, GachaDiscountInfo.Parser);

		// Token: 0x040048CF RID: 18639
		private readonly RepeatedField<GachaDiscountInfo> gachaDiscountInfos_ = new RepeatedField<GachaDiscountInfo>();

		// Token: 0x040048D0 RID: 18640
		public const int OnlyViewDiscountFieldNumber = 15;

		// Token: 0x040048D1 RID: 18641
		private bool onlyViewDiscount_;

		// Token: 0x040048D2 RID: 18642
		public const int IsShowProgressFieldNumber = 16;

		// Token: 0x040048D3 RID: 18643
		private bool isShowProgress_;

		// Token: 0x040048D4 RID: 18644
		public const int DiscountTagDetailsFieldNumber = 17;

		// Token: 0x040048D5 RID: 18645
		private static readonly MapField<int, string>.Codec _map_discountTagDetails_codec = new MapField<int, string>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForString(18U, ""), 138U);

		// Token: 0x040048D6 RID: 18646
		private readonly MapField<int, string> discountTagDetails_ = new MapField<int, string>();
	}
}
