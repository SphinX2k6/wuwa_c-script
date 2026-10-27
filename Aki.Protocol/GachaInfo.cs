using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000691 RID: 1681
	public sealed class GachaInfo : IMessage<GachaInfo>, IMessage, IEquatable<GachaInfo>, IDeepCloneable<GachaInfo>, IBufferMessage
	{
		// Token: 0x060099D5 RID: 39381 RVA: 0x00172820 File Offset: 0x00170A20
		[NullableContext(1)]
		public static GachaInfo Create()
		{
			return new GachaInfo();
		}

		// Token: 0x17001EB0 RID: 7856
		// (get) Token: 0x060099D6 RID: 39382 RVA: 0x00172827 File Offset: 0x00170A27
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GachaInfo> Parser
		{
			get
			{
				return GachaInfo._parser;
			}
		}

		// Token: 0x17001EB1 RID: 7857
		// (get) Token: 0x060099D7 RID: 39383 RVA: 0x0017282E File Offset: 0x00170A2E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001EB2 RID: 7858
		// (get) Token: 0x060099D8 RID: 39384 RVA: 0x00172831 File Offset: 0x00170A31
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GachaInfo.Descriptor;
			}
		}

		// Token: 0x060099D9 RID: 39385 RVA: 0x00172838 File Offset: 0x00170A38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GachaInfo()
		{
		}

		// Token: 0x060099DA RID: 39386 RVA: 0x00172878 File Offset: 0x00170A78
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

		// Token: 0x060099DB RID: 39387 RVA: 0x0017297C File Offset: 0x00170B7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GachaInfo Clone()
		{
			return new GachaInfo(this);
		}

		// Token: 0x17001EB3 RID: 7859
		// (get) Token: 0x060099DC RID: 39388 RVA: 0x00172984 File Offset: 0x00170B84
		// (set) Token: 0x060099DD RID: 39389 RVA: 0x0017298C File Offset: 0x00170B8C
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

		// Token: 0x17001EB4 RID: 7860
		// (get) Token: 0x060099DE RID: 39390 RVA: 0x00172995 File Offset: 0x00170B95
		// (set) Token: 0x060099DF RID: 39391 RVA: 0x0017299D File Offset: 0x00170B9D
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

		// Token: 0x17001EB5 RID: 7861
		// (get) Token: 0x060099E0 RID: 39392 RVA: 0x001729A6 File Offset: 0x00170BA6
		// (set) Token: 0x060099E1 RID: 39393 RVA: 0x001729AE File Offset: 0x00170BAE
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

		// Token: 0x17001EB6 RID: 7862
		// (get) Token: 0x060099E2 RID: 39394 RVA: 0x001729B7 File Offset: 0x00170BB7
		// (set) Token: 0x060099E3 RID: 39395 RVA: 0x001729BF File Offset: 0x00170BBF
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

		// Token: 0x17001EB7 RID: 7863
		// (get) Token: 0x060099E4 RID: 39396 RVA: 0x001729C8 File Offset: 0x00170BC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<GachaConsume> GachaConsumes
		{
			get
			{
				return this.gachaConsumes_;
			}
		}

		// Token: 0x17001EB8 RID: 7864
		// (get) Token: 0x060099E5 RID: 39397 RVA: 0x001729D0 File Offset: 0x00170BD0
		// (set) Token: 0x060099E6 RID: 39398 RVA: 0x001729D8 File Offset: 0x00170BD8
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

		// Token: 0x17001EB9 RID: 7865
		// (get) Token: 0x060099E7 RID: 39399 RVA: 0x001729E1 File Offset: 0x00170BE1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<GachaPoolInfo> Pools
		{
			get
			{
				return this.pools_;
			}
		}

		// Token: 0x17001EBA RID: 7866
		// (get) Token: 0x060099E8 RID: 39400 RVA: 0x001729E9 File Offset: 0x00170BE9
		// (set) Token: 0x060099E9 RID: 39401 RVA: 0x001729F1 File Offset: 0x00170BF1
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

		// Token: 0x17001EBB RID: 7867
		// (get) Token: 0x060099EA RID: 39402 RVA: 0x001729FA File Offset: 0x00170BFA
		// (set) Token: 0x060099EB RID: 39403 RVA: 0x00172A02 File Offset: 0x00170C02
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

		// Token: 0x17001EBC RID: 7868
		// (get) Token: 0x060099EC RID: 39404 RVA: 0x00172A0B File Offset: 0x00170C0B
		// (set) Token: 0x060099ED RID: 39405 RVA: 0x00172A13 File Offset: 0x00170C13
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

		// Token: 0x17001EBD RID: 7869
		// (get) Token: 0x060099EE RID: 39406 RVA: 0x00172A1C File Offset: 0x00170C1C
		// (set) Token: 0x060099EF RID: 39407 RVA: 0x00172A24 File Offset: 0x00170C24
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

		// Token: 0x17001EBE RID: 7870
		// (get) Token: 0x060099F0 RID: 39408 RVA: 0x00172A2D File Offset: 0x00170C2D
		// (set) Token: 0x060099F1 RID: 39409 RVA: 0x00172A35 File Offset: 0x00170C35
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

		// Token: 0x17001EBF RID: 7871
		// (get) Token: 0x060099F2 RID: 39410 RVA: 0x00172A48 File Offset: 0x00170C48
		// (set) Token: 0x060099F3 RID: 39411 RVA: 0x00172A50 File Offset: 0x00170C50
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

		// Token: 0x17001EC0 RID: 7872
		// (get) Token: 0x060099F4 RID: 39412 RVA: 0x00172A59 File Offset: 0x00170C59
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<GachaDiscountInfo> GachaDiscountInfos
		{
			get
			{
				return this.gachaDiscountInfos_;
			}
		}

		// Token: 0x17001EC1 RID: 7873
		// (get) Token: 0x060099F5 RID: 39413 RVA: 0x00172A61 File Offset: 0x00170C61
		// (set) Token: 0x060099F6 RID: 39414 RVA: 0x00172A69 File Offset: 0x00170C69
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

		// Token: 0x17001EC2 RID: 7874
		// (get) Token: 0x060099F7 RID: 39415 RVA: 0x00172A72 File Offset: 0x00170C72
		// (set) Token: 0x060099F8 RID: 39416 RVA: 0x00172A7A File Offset: 0x00170C7A
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

		// Token: 0x17001EC3 RID: 7875
		// (get) Token: 0x060099F9 RID: 39417 RVA: 0x00172A83 File Offset: 0x00170C83
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, string> DiscountTagDetails
		{
			get
			{
				return this.discountTagDetails_;
			}
		}

		// Token: 0x060099FA RID: 39418 RVA: 0x00172A8B File Offset: 0x00170C8B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GachaInfo);
		}

		// Token: 0x060099FB RID: 39419 RVA: 0x00172A9C File Offset: 0x00170C9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GachaInfo other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.TodayTimes == other.TodayTimes && this.TotalTimes == other.TotalTimes && this.ItemId == other.ItemId && this.gachaConsumes_.Equals(other.gachaConsumes_) && this.UsePoolId == other.UsePoolId && this.pools_.Equals(other.pools_) && this.BeginTime == other.BeginTime && this.EndTime == other.EndTime && this.DailyLimitTimes == other.DailyLimitTimes && this.TotalLimitTimes == other.TotalLimitTimes && !(this.ResourcesId != other.ResourcesId) && this.GachaAccumulateId == other.GachaAccumulateId && this.gachaDiscountInfos_.Equals(other.gachaDiscountInfos_) && this.OnlyViewDiscount == other.OnlyViewDiscount && this.IsShowProgress == other.IsShowProgress && this.DiscountTagDetails.Equals(other.DiscountTagDetails) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060099FC RID: 39420 RVA: 0x00172BF0 File Offset: 0x00170DF0
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

		// Token: 0x060099FD RID: 39421 RVA: 0x00172D95 File Offset: 0x00170F95
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060099FE RID: 39422 RVA: 0x00172DA2 File Offset: 0x00170FA2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060099FF RID: 39423 RVA: 0x00172DAC File Offset: 0x00170FAC
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

		// Token: 0x06009A00 RID: 39424 RVA: 0x00172F88 File Offset: 0x00171188
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

		// Token: 0x06009A01 RID: 39425 RVA: 0x00173120 File Offset: 0x00171320
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

		// Token: 0x06009A02 RID: 39426 RVA: 0x00173295 File Offset: 0x00171495
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009A03 RID: 39427 RVA: 0x001732A0 File Offset: 0x001714A0
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

		// Token: 0x040048B6 RID: 18614
		private static readonly MessageParser<GachaInfo> _parser = new MessageParser<GachaInfo>(() => new GachaInfo());

		// Token: 0x040048B7 RID: 18615
		private UnknownFieldSet _unknownFields;

		// Token: 0x040048B8 RID: 18616
		public const int IdFieldNumber = 1;

		// Token: 0x040048B9 RID: 18617
		private int id_;

		// Token: 0x040048BA RID: 18618
		public const int TodayTimesFieldNumber = 2;

		// Token: 0x040048BB RID: 18619
		private int todayTimes_;

		// Token: 0x040048BC RID: 18620
		public const int TotalTimesFieldNumber = 3;

		// Token: 0x040048BD RID: 18621
		private int totalTimes_;

		// Token: 0x040048BE RID: 18622
		public const int ItemIdFieldNumber = 4;

		// Token: 0x040048BF RID: 18623
		private int itemId_;

		// Token: 0x040048C0 RID: 18624
		public const int GachaConsumesFieldNumber = 5;

		// Token: 0x040048C1 RID: 18625
		private static readonly FieldCodec<GachaConsume> _repeated_gachaConsumes_codec = FieldCodec.ForMessage<GachaConsume>(42U, GachaConsume.Parser);

		// Token: 0x040048C2 RID: 18626
		private readonly RepeatedField<GachaConsume> gachaConsumes_ = new RepeatedField<GachaConsume>();

		// Token: 0x040048C3 RID: 18627
		public const int UsePoolIdFieldNumber = 6;

		// Token: 0x040048C4 RID: 18628
		private int usePoolId_;

		// Token: 0x040048C5 RID: 18629
		public const int PoolsFieldNumber = 7;

		// Token: 0x040048C6 RID: 18630
		private static readonly FieldCodec<GachaPoolInfo> _repeated_pools_codec = FieldCodec.ForMessage<GachaPoolInfo>(58U, GachaPoolInfo.Parser);

		// Token: 0x040048C7 RID: 18631
		private readonly RepeatedField<GachaPoolInfo> pools_ = new RepeatedField<GachaPoolInfo>();

		// Token: 0x040048C8 RID: 18632
		public const int BeginTimeFieldNumber = 8;

		// Token: 0x040048C9 RID: 18633
		private long beginTime_;

		// Token: 0x040048CA RID: 18634
		public const int EndTimeFieldNumber = 9;

		// Token: 0x040048CB RID: 18635
		private long endTime_;

		// Token: 0x040048CC RID: 18636
		public const int DailyLimitTimesFieldNumber = 10;

		// Token: 0x040048CD RID: 18637
		private int dailyLimitTimes_;

		// Token: 0x040048CE RID: 18638
		public const int TotalLimitTimesFieldNumber = 11;

		// Token: 0x040048CF RID: 18639
		private int totalLimitTimes_;

		// Token: 0x040048D0 RID: 18640
		public const int ResourcesIdFieldNumber = 12;

		// Token: 0x040048D1 RID: 18641
		private string resourcesId_ = "";

		// Token: 0x040048D2 RID: 18642
		public const int GachaAccumulateIdFieldNumber = 13;

		// Token: 0x040048D3 RID: 18643
		private int gachaAccumulateId_;

		// Token: 0x040048D4 RID: 18644
		public const int GachaDiscountInfosFieldNumber = 14;

		// Token: 0x040048D5 RID: 18645
		private static readonly FieldCodec<GachaDiscountInfo> _repeated_gachaDiscountInfos_codec = FieldCodec.ForMessage<GachaDiscountInfo>(114U, GachaDiscountInfo.Parser);

		// Token: 0x040048D6 RID: 18646
		private readonly RepeatedField<GachaDiscountInfo> gachaDiscountInfos_ = new RepeatedField<GachaDiscountInfo>();

		// Token: 0x040048D7 RID: 18647
		public const int OnlyViewDiscountFieldNumber = 15;

		// Token: 0x040048D8 RID: 18648
		private bool onlyViewDiscount_;

		// Token: 0x040048D9 RID: 18649
		public const int IsShowProgressFieldNumber = 16;

		// Token: 0x040048DA RID: 18650
		private bool isShowProgress_;

		// Token: 0x040048DB RID: 18651
		public const int DiscountTagDetailsFieldNumber = 17;

		// Token: 0x040048DC RID: 18652
		private static readonly MapField<int, string>.Codec _map_discountTagDetails_codec = new MapField<int, string>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForString(18U, ""), 138U);

		// Token: 0x040048DD RID: 18653
		private readonly MapField<int, string> discountTagDetails_ = new MapField<int, string>();
	}
}
