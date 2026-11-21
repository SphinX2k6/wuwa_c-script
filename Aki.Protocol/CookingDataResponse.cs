using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020002FE RID: 766
	[NetMessage(EMessageId.CookingDataResponse)]
	public sealed class CookingDataResponse : IMessage<CookingDataResponse>, IMessage, IEquatable<CookingDataResponse>, IDeepCloneable<CookingDataResponse>, IBufferMessage
	{
		// Token: 0x06004DB3 RID: 19891 RVA: 0x000BD1C2 File Offset: 0x000BB3C2
		[NullableContext(1)]
		public static CookingDataResponse Create()
		{
			return new CookingDataResponse();
		}

		// Token: 0x17000DBB RID: 3515
		// (get) Token: 0x06004DB4 RID: 19892 RVA: 0x000BD1C9 File Offset: 0x000BB3C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000DBC RID: 3516
		// (get) Token: 0x06004DB5 RID: 19893 RVA: 0x000BD1CC File Offset: 0x000BB3CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CookingDataResponse.Descriptor;
			}
		}

		// Token: 0x06004DB6 RID: 19894 RVA: 0x000BD1D3 File Offset: 0x000BB3D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CookingDataResponse()
		{
		}

		// Token: 0x06004DB7 RID: 19895 RVA: 0x000BD1FC File Offset: 0x000BB3FC
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

		// Token: 0x06004DB8 RID: 19896 RVA: 0x000BD287 File Offset: 0x000BB487
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CookingDataResponse Clone()
		{
			return new CookingDataResponse(this);
		}

		// Token: 0x17000DBD RID: 3517
		// (get) Token: 0x06004DB9 RID: 19897 RVA: 0x000BD28F File Offset: 0x000BB48F
		// (set) Token: 0x06004DBA RID: 19898 RVA: 0x000BD297 File Offset: 0x000BB497
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

		// Token: 0x17000DBE RID: 3518
		// (get) Token: 0x06004DBB RID: 19899 RVA: 0x000BD2A0 File Offset: 0x000BB4A0
		// (set) Token: 0x06004DBC RID: 19900 RVA: 0x000BD2A8 File Offset: 0x000BB4A8
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

		// Token: 0x17000DBF RID: 3519
		// (get) Token: 0x06004DBD RID: 19901 RVA: 0x000BD2B1 File Offset: 0x000BB4B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<SingleFoodFormulaInfo> FoodFormulaInfos
		{
			get
			{
				return this.foodFormulaInfos_;
			}
		}

		// Token: 0x17000DC0 RID: 3520
		// (get) Token: 0x06004DBE RID: 19902 RVA: 0x000BD2B9 File Offset: 0x000BB4B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<SingleProcessedFoodFormulaInfo> ProcessedFoodFormulaInfos
		{
			get
			{
				return this.processedFoodFormulaInfos_;
			}
		}

		// Token: 0x17000DC1 RID: 3521
		// (get) Token: 0x06004DBF RID: 19903 RVA: 0x000BD2C1 File Offset: 0x000BB4C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<OneFormulaConfig> FormulaConfigs
		{
			get
			{
				return this.formulaConfigs_;
			}
		}

		// Token: 0x17000DC2 RID: 3522
		// (get) Token: 0x06004DC0 RID: 19904 RVA: 0x000BD2C9 File Offset: 0x000BB4C9
		// (set) Token: 0x06004DC1 RID: 19905 RVA: 0x000BD2D1 File Offset: 0x000BB4D1
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

		// Token: 0x06004DC2 RID: 19906 RVA: 0x000BD2DA File Offset: 0x000BB4DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CookingDataResponse);
		}

		// Token: 0x06004DC3 RID: 19907 RVA: 0x000BD2E8 File Offset: 0x000BB4E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CookingDataResponse other)
		{
			return other != null && (other == this || (this.Code == other.Code && object.Equals(this.CookingInfo, other.CookingInfo) && this.foodFormulaInfos_.Equals(other.foodFormulaInfos_) && this.processedFoodFormulaInfos_.Equals(other.processedFoodFormulaInfos_) && this.formulaConfigs_.Equals(other.formulaConfigs_) && this.LimitRefreshTime == other.LimitRefreshTime && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004DC4 RID: 19908 RVA: 0x000BD388 File Offset: 0x000BB588
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

		// Token: 0x06004DC5 RID: 19909 RVA: 0x000BD426 File Offset: 0x000BB626
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06004DC6 RID: 19910 RVA: 0x000BD433 File Offset: 0x000BB633
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004DC7 RID: 19911 RVA: 0x000BD43C File Offset: 0x000BB63C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.processedFoodFormulaInfos_.WriteTo(ref output, CookingDataResponse._repeated_processedFoodFormulaInfos_codec);
			this.formulaConfigs_.WriteTo(ref output, CookingDataResponse._repeated_formulaConfigs_codec);
			this.foodFormulaInfos_.WriteTo(ref output, CookingDataResponse._repeated_foodFormulaInfos_codec);
			if (this.Code != ErrorCode.Success)
			{
				output.WriteRawTag(72);
				output.WriteEnum((int)this.Code);
			}
			if (this.LimitRefreshTime != 0L)
			{
				output.WriteRawTag(96);
				output.WriteInt64(this.LimitRefreshTime);
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

		// Token: 0x06004DC8 RID: 19912 RVA: 0x000BD4E4 File Offset: 0x000BB6E4
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

		// Token: 0x06004DC9 RID: 19913 RVA: 0x000BD58C File Offset: 0x000BB78C
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

		// Token: 0x06004DCA RID: 19914 RVA: 0x000BD63B File Offset: 0x000BB83B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004DCB RID: 19915 RVA: 0x000BD644 File Offset: 0x000BB844
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
					if (num == 10U)
					{
						this.processedFoodFormulaInfos_.AddEntriesFrom(ref input, CookingDataResponse._repeated_processedFoodFormulaInfos_codec);
						continue;
					}
					if (num == 34U)
					{
						this.formulaConfigs_.AddEntriesFrom(ref input, CookingDataResponse._repeated_formulaConfigs_codec);
						continue;
					}
					if (num == 50U)
					{
						this.foodFormulaInfos_.AddEntriesFrom(ref input, CookingDataResponse._repeated_foodFormulaInfos_codec);
						continue;
					}
				}
				else
				{
					if (num == 72U)
					{
						this.Code = (ErrorCode)input.ReadEnum();
						continue;
					}
					if (num == 96U)
					{
						this.LimitRefreshTime = input.ReadInt64();
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

		// Token: 0x040031B1 RID: 12721
		private UnknownFieldSet _unknownFields;

		// Token: 0x040031B2 RID: 12722
		public const int CodeFieldNumber = 9;

		// Token: 0x040031B3 RID: 12723
		private ErrorCode code_;

		// Token: 0x040031B4 RID: 12724
		public const int CookingInfoFieldNumber = 14;

		// Token: 0x040031B5 RID: 12725
		private CookingInfo cookingInfo_;

		// Token: 0x040031B6 RID: 12726
		public const int FoodFormulaInfosFieldNumber = 6;

		// Token: 0x040031B7 RID: 12727
		private static readonly FieldCodec<SingleFoodFormulaInfo> _repeated_foodFormulaInfos_codec = FieldCodec.ForMessage<SingleFoodFormulaInfo>(50U, SingleFoodFormulaInfo.Parser);

		// Token: 0x040031B8 RID: 12728
		private readonly RepeatedField<SingleFoodFormulaInfo> foodFormulaInfos_ = new RepeatedField<SingleFoodFormulaInfo>();

		// Token: 0x040031B9 RID: 12729
		public const int ProcessedFoodFormulaInfosFieldNumber = 1;

		// Token: 0x040031BA RID: 12730
		private static readonly FieldCodec<SingleProcessedFoodFormulaInfo> _repeated_processedFoodFormulaInfos_codec = FieldCodec.ForMessage<SingleProcessedFoodFormulaInfo>(10U, SingleProcessedFoodFormulaInfo.Parser);

		// Token: 0x040031BB RID: 12731
		private readonly RepeatedField<SingleProcessedFoodFormulaInfo> processedFoodFormulaInfos_ = new RepeatedField<SingleProcessedFoodFormulaInfo>();

		// Token: 0x040031BC RID: 12732
		public const int FormulaConfigsFieldNumber = 4;

		// Token: 0x040031BD RID: 12733
		private static readonly FieldCodec<OneFormulaConfig> _repeated_formulaConfigs_codec = FieldCodec.ForMessage<OneFormulaConfig>(34U, OneFormulaConfig.Parser);

		// Token: 0x040031BE RID: 12734
		private readonly RepeatedField<OneFormulaConfig> formulaConfigs_ = new RepeatedField<OneFormulaConfig>();

		// Token: 0x040031BF RID: 12735
		public const int LimitRefreshTimeFieldNumber = 12;

		// Token: 0x040031C0 RID: 12736
		private long limitRefreshTime_;
	}
}
