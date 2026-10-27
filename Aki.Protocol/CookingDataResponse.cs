using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020002F7 RID: 759
	[NetMessage(EMessageId.CookingDataResponse)]
	public sealed class CookingDataResponse : IMessage<CookingDataResponse>, IMessage, IEquatable<CookingDataResponse>, IDeepCloneable<CookingDataResponse>, IBufferMessage
	{
		// Token: 0x06004CDA RID: 19674 RVA: 0x000BADD6 File Offset: 0x000B8FD6
		[NullableContext(1)]
		public static CookingDataResponse Create()
		{
			return new CookingDataResponse();
		}

		// Token: 0x17000D8E RID: 3470
		// (get) Token: 0x06004CDB RID: 19675 RVA: 0x000BADDD File Offset: 0x000B8FDD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000D8F RID: 3471
		// (get) Token: 0x06004CDC RID: 19676 RVA: 0x000BADE0 File Offset: 0x000B8FE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CookingDataResponse.Descriptor;
			}
		}

		// Token: 0x06004CDD RID: 19677 RVA: 0x000BADE7 File Offset: 0x000B8FE7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CookingDataResponse()
		{
		}

		// Token: 0x06004CDE RID: 19678 RVA: 0x000BAE10 File Offset: 0x000B9010
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CookingDataResponse(CookingDataResponse other) : this()
		{
			this.code_ = other.code_;
			this.cookingInfo_ = ((other.cookingInfo_ != null) ? other.cookingInfo_.Clone() : null);
			this.foodFormulaInfos_ = other.foodFormulaInfos_.Clone();
			this.processedFoodFormulaInfos_ = other.processedFoodFormulaInfos_.Clone();
			this.formulaConfigs_ = other.formulaConfigs_.Clone();
			this.limitRefreshTime_ = other.limitRefreshTime_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004CDF RID: 19679 RVA: 0x000BAE9B File Offset: 0x000B909B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CookingDataResponse Clone()
		{
			return new CookingDataResponse(this);
		}

		// Token: 0x17000D90 RID: 3472
		// (get) Token: 0x06004CE0 RID: 19680 RVA: 0x000BAEA3 File Offset: 0x000B90A3
		// (set) Token: 0x06004CE1 RID: 19681 RVA: 0x000BAEAB File Offset: 0x000B90AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode Code
		{
			get
			{
				return this.code_;
			}
			set
			{
				this.code_ = value;
			}
		}

		// Token: 0x17000D91 RID: 3473
		// (get) Token: 0x06004CE2 RID: 19682 RVA: 0x000BAEB4 File Offset: 0x000B90B4
		// (set) Token: 0x06004CE3 RID: 19683 RVA: 0x000BAEBC File Offset: 0x000B90BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CookingInfo CookingInfo
		{
			get
			{
				return this.cookingInfo_;
			}
			set
			{
				this.cookingInfo_ = value;
			}
		}

		// Token: 0x17000D92 RID: 3474
		// (get) Token: 0x06004CE4 RID: 19684 RVA: 0x000BAEC5 File Offset: 0x000B90C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<SingleFoodFormulaInfo> FoodFormulaInfos
		{
			get
			{
				return this.foodFormulaInfos_;
			}
		}

		// Token: 0x17000D93 RID: 3475
		// (get) Token: 0x06004CE5 RID: 19685 RVA: 0x000BAECD File Offset: 0x000B90CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<SingleProcessedFoodFormulaInfo> ProcessedFoodFormulaInfos
		{
			get
			{
				return this.processedFoodFormulaInfos_;
			}
		}

		// Token: 0x17000D94 RID: 3476
		// (get) Token: 0x06004CE6 RID: 19686 RVA: 0x000BAED5 File Offset: 0x000B90D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<OneFormulaConfig> FormulaConfigs
		{
			get
			{
				return this.formulaConfigs_;
			}
		}

		// Token: 0x17000D95 RID: 3477
		// (get) Token: 0x06004CE7 RID: 19687 RVA: 0x000BAEDD File Offset: 0x000B90DD
		// (set) Token: 0x06004CE8 RID: 19688 RVA: 0x000BAEE5 File Offset: 0x000B90E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long LimitRefreshTime
		{
			get
			{
				return this.limitRefreshTime_;
			}
			set
			{
				this.limitRefreshTime_ = value;
			}
		}

		// Token: 0x06004CE9 RID: 19689 RVA: 0x000BAEEE File Offset: 0x000B90EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CookingDataResponse);
		}

		// Token: 0x06004CEA RID: 19690 RVA: 0x000BAEFC File Offset: 0x000B90FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CookingDataResponse other)
		{
			return other != null && (other == this || (this.Code == other.Code && object.Equals(this.CookingInfo, other.CookingInfo) && this.foodFormulaInfos_.Equals(other.foodFormulaInfos_) && this.processedFoodFormulaInfos_.Equals(other.processedFoodFormulaInfos_) && this.formulaConfigs_.Equals(other.formulaConfigs_) && this.LimitRefreshTime == other.LimitRefreshTime && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004CEB RID: 19691 RVA: 0x000BAF9C File Offset: 0x000B919C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Code != ErrorCode.Success)
			{
				num ^= this.Code.GetHashCode();
			}
			if (this.cookingInfo_ != null)
			{
				num ^= this.CookingInfo.GetHashCode();
			}
			num ^= this.foodFormulaInfos_.GetHashCode();
			num ^= this.processedFoodFormulaInfos_.GetHashCode();
			num ^= this.formulaConfigs_.GetHashCode();
			if (this.LimitRefreshTime != 0L)
			{
				num ^= this.LimitRefreshTime.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06004CEC RID: 19692 RVA: 0x000BB03A File Offset: 0x000B923A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06004CED RID: 19693 RVA: 0x000BB047 File Offset: 0x000B9247
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004CEE RID: 19694 RVA: 0x000BB050 File Offset: 0x000B9250
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.formulaConfigs_.WriteTo(ref output, CookingDataResponse._repeated_formulaConfigs_codec);
			this.processedFoodFormulaInfos_.WriteTo(ref output, CookingDataResponse._repeated_processedFoodFormulaInfos_codec);
			this.foodFormulaInfos_.WriteTo(ref output, CookingDataResponse._repeated_foodFormulaInfos_codec);
			if (this.LimitRefreshTime != 0L)
			{
				output.WriteRawTag(96);
				output.WriteInt64(this.LimitRefreshTime);
			}
			if (this.Code != ErrorCode.Success)
			{
				output.WriteRawTag(104);
				output.WriteEnum((int)this.Code);
			}
			if (this.cookingInfo_ != null)
			{
				output.WriteRawTag(114);
				output.WriteMessage(this.CookingInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004CEF RID: 19695 RVA: 0x000BB0F8 File Offset: 0x000B92F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Code != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Code);
			}
			if (this.cookingInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.CookingInfo);
			}
			num += this.foodFormulaInfos_.CalculateSize(CookingDataResponse._repeated_foodFormulaInfos_codec);
			num += this.processedFoodFormulaInfos_.CalculateSize(CookingDataResponse._repeated_processedFoodFormulaInfos_codec);
			num += this.formulaConfigs_.CalculateSize(CookingDataResponse._repeated_formulaConfigs_codec);
			if (this.LimitRefreshTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.LimitRefreshTime);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06004CF0 RID: 19696 RVA: 0x000BB1A0 File Offset: 0x000B93A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CookingDataResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Code != ErrorCode.Success)
			{
				this.Code = other.Code;
			}
			if (other.cookingInfo_ != null)
			{
				if (this.cookingInfo_ == null)
				{
					this.CookingInfo = new CookingInfo();
				}
				this.CookingInfo.MergeFrom(other.CookingInfo);
			}
			this.foodFormulaInfos_.Add(other.foodFormulaInfos_);
			this.processedFoodFormulaInfos_.Add(other.processedFoodFormulaInfos_);
			this.formulaConfigs_.Add(other.formulaConfigs_);
			if (other.LimitRefreshTime != 0L)
			{
				this.LimitRefreshTime = other.LimitRefreshTime;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06004CF1 RID: 19697 RVA: 0x000BB24F File Offset: 0x000B944F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004CF2 RID: 19698 RVA: 0x000BB258 File Offset: 0x000B9458
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
				if (num <= 66U)
				{
					if (num == 42U)
					{
						this.formulaConfigs_.AddEntriesFrom(ref input, CookingDataResponse._repeated_formulaConfigs_codec);
						continue;
					}
					if (num == 50U)
					{
						this.processedFoodFormulaInfos_.AddEntriesFrom(ref input, CookingDataResponse._repeated_processedFoodFormulaInfos_codec);
						continue;
					}
					if (num == 66U)
					{
						this.foodFormulaInfos_.AddEntriesFrom(ref input, CookingDataResponse._repeated_foodFormulaInfos_codec);
						continue;
					}
				}
				else
				{
					if (num == 96U)
					{
						this.LimitRefreshTime = input.ReadInt64();
						continue;
					}
					if (num == 104U)
					{
						this.Code = (ErrorCode)input.ReadEnum();
						continue;
					}
					if (num == 114U)
					{
						if (this.cookingInfo_ == null)
						{
							this.CookingInfo = new CookingInfo();
						}
						input.ReadMessage(this.CookingInfo);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400311A RID: 12570
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400311B RID: 12571
		public const int CodeFieldNumber = 13;

		// Token: 0x0400311C RID: 12572
		private ErrorCode code_;

		// Token: 0x0400311D RID: 12573
		public const int CookingInfoFieldNumber = 14;

		// Token: 0x0400311E RID: 12574
		private CookingInfo cookingInfo_;

		// Token: 0x0400311F RID: 12575
		public const int FoodFormulaInfosFieldNumber = 8;

		// Token: 0x04003120 RID: 12576
		private static readonly FieldCodec<SingleFoodFormulaInfo> _repeated_foodFormulaInfos_codec = FieldCodec.ForMessage<SingleFoodFormulaInfo>(66U, SingleFoodFormulaInfo.Parser);

		// Token: 0x04003121 RID: 12577
		private readonly RepeatedField<SingleFoodFormulaInfo> foodFormulaInfos_ = new RepeatedField<SingleFoodFormulaInfo>();

		// Token: 0x04003122 RID: 12578
		public const int ProcessedFoodFormulaInfosFieldNumber = 6;

		// Token: 0x04003123 RID: 12579
		private static readonly FieldCodec<SingleProcessedFoodFormulaInfo> _repeated_processedFoodFormulaInfos_codec = FieldCodec.ForMessage<SingleProcessedFoodFormulaInfo>(50U, SingleProcessedFoodFormulaInfo.Parser);

		// Token: 0x04003124 RID: 12580
		private readonly RepeatedField<SingleProcessedFoodFormulaInfo> processedFoodFormulaInfos_ = new RepeatedField<SingleProcessedFoodFormulaInfo>();

		// Token: 0x04003125 RID: 12581
		public const int FormulaConfigsFieldNumber = 5;

		// Token: 0x04003126 RID: 12582
		private static readonly FieldCodec<OneFormulaConfig> _repeated_formulaConfigs_codec = FieldCodec.ForMessage<OneFormulaConfig>(42U, OneFormulaConfig.Parser);

		// Token: 0x04003127 RID: 12583
		private readonly RepeatedField<OneFormulaConfig> formulaConfigs_ = new RepeatedField<OneFormulaConfig>();

		// Token: 0x04003128 RID: 12584
		public const int LimitRefreshTimeFieldNumber = 12;

		// Token: 0x04003129 RID: 12585
		private long limitRefreshTime_;
	}
}
