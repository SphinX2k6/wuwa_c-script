using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020000C0 RID: 192
	[NetMessage(EMessageId.AdventureManualResponse)]
	public sealed class AdventureManualResponse : IMessage<AdventureManualResponse>, IMessage, IEquatable<AdventureManualResponse>, IDeepCloneable<AdventureManualResponse>, IBufferMessage
	{
		// Token: 0x06001EBC RID: 7868 RVA: 0x00053AF5 File Offset: 0x00051CF5
		[NullableContext(1)]
		public static AdventureManualResponse Create()
		{
			return new AdventureManualResponse();
		}

		// Token: 0x1700039B RID: 923
		// (get) Token: 0x06001EBD RID: 7869 RVA: 0x00053AFC File Offset: 0x00051CFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700039C RID: 924
		// (get) Token: 0x06001EBE RID: 7870 RVA: 0x00053AFF File Offset: 0x00051CFF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AdventureManualResponse.Descriptor;
			}
		}

		// Token: 0x06001EBF RID: 7871 RVA: 0x00053B08 File Offset: 0x00051D08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AdventureManualResponse()
		{
		}

		// Token: 0x06001EC0 RID: 7872 RVA: 0x00053B68 File Offset: 0x00051D68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AdventureManualResponse(AdventureManualResponse other) : this()
		{
			this.code_ = other.code_;
			this.adventureManualData_ = ((other.adventureManualData_ != null) ? other.adventureManualData_.Clone() : null);
			this.detectionTarget_ = other.detectionTarget_.Clone();
			this.adventureRewardData_ = other.adventureRewardData_.Clone();
			this.detectionUnlocks_ = ((other.detectionUnlocks_ != null) ? other.detectionUnlocks_.Clone() : null);
			this.nowSelectDetectionTarget_ = ((other.nowSelectDetectionTarget_ != null) ? other.nowSelectDetectionTarget_.Clone() : null);
			this.slientFirstAwardMap_ = other.slientFirstAwardMap_.Clone();
			this.silenceAreaConfigs_ = other.silenceAreaConfigs_.Clone();
			this.dungeonDetectionConfigs_ = other.dungeonDetectionConfigs_.Clone();
			this.preOpenDungeonDetections_ = other.preOpenDungeonDetections_.Clone();
			this.preOpenSilenceAreaDetections_ = other.preOpenSilenceAreaDetections_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001EC1 RID: 7873 RVA: 0x00053C63 File Offset: 0x00051E63
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AdventureManualResponse Clone()
		{
			return new AdventureManualResponse(this);
		}

		// Token: 0x1700039D RID: 925
		// (get) Token: 0x06001EC2 RID: 7874 RVA: 0x00053C6B File Offset: 0x00051E6B
		// (set) Token: 0x06001EC3 RID: 7875 RVA: 0x00053C73 File Offset: 0x00051E73
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

		// Token: 0x1700039E RID: 926
		// (get) Token: 0x06001EC4 RID: 7876 RVA: 0x00053C7C File Offset: 0x00051E7C
		// (set) Token: 0x06001EC5 RID: 7877 RVA: 0x00053C84 File Offset: 0x00051E84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AdventureManualData AdventureManualData
		{
			get
			{
				return this.adventureManualData_;
			}
			set
			{
				this.adventureManualData_ = value;
			}
		}

		// Token: 0x1700039F RID: 927
		// (get) Token: 0x06001EC6 RID: 7878 RVA: 0x00053C8D File Offset: 0x00051E8D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<DetectionTarget> DetectionTarget
		{
			get
			{
				return this.detectionTarget_;
			}
		}

		// Token: 0x170003A0 RID: 928
		// (get) Token: 0x06001EC7 RID: 7879 RVA: 0x00053C95 File Offset: 0x00051E95
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<AdventureRewardData> AdventureRewardData
		{
			get
			{
				return this.adventureRewardData_;
			}
		}

		// Token: 0x170003A1 RID: 929
		// (get) Token: 0x06001EC8 RID: 7880 RVA: 0x00053C9D File Offset: 0x00051E9D
		// (set) Token: 0x06001EC9 RID: 7881 RVA: 0x00053CA5 File Offset: 0x00051EA5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DetectionUnlock DetectionUnlocks
		{
			get
			{
				return this.detectionUnlocks_;
			}
			set
			{
				this.detectionUnlocks_ = value;
			}
		}

		// Token: 0x170003A2 RID: 930
		// (get) Token: 0x06001ECA RID: 7882 RVA: 0x00053CAE File Offset: 0x00051EAE
		// (set) Token: 0x06001ECB RID: 7883 RVA: 0x00053CB6 File Offset: 0x00051EB6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SelectDetectionTarget NowSelectDetectionTarget
		{
			get
			{
				return this.nowSelectDetectionTarget_;
			}
			set
			{
				this.nowSelectDetectionTarget_ = value;
			}
		}

		// Token: 0x170003A3 RID: 931
		// (get) Token: 0x06001ECC RID: 7884 RVA: 0x00053CBF File Offset: 0x00051EBF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, SlientFirstAwardState> SlientFirstAwardMap
		{
			get
			{
				return this.slientFirstAwardMap_;
			}
		}

		// Token: 0x170003A4 RID: 932
		// (get) Token: 0x06001ECD RID: 7885 RVA: 0x00053CC7 File Offset: 0x00051EC7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<AdventureDetectionConfig> SilenceAreaConfigs
		{
			get
			{
				return this.silenceAreaConfigs_;
			}
		}

		// Token: 0x170003A5 RID: 933
		// (get) Token: 0x06001ECE RID: 7886 RVA: 0x00053CCF File Offset: 0x00051ECF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<AdventureDetectionConfig> DungeonDetectionConfigs
		{
			get
			{
				return this.dungeonDetectionConfigs_;
			}
		}

		// Token: 0x170003A6 RID: 934
		// (get) Token: 0x06001ECF RID: 7887 RVA: 0x00053CD7 File Offset: 0x00051ED7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PreOpenDetections> PreOpenDungeonDetections
		{
			get
			{
				return this.preOpenDungeonDetections_;
			}
		}

		// Token: 0x170003A7 RID: 935
		// (get) Token: 0x06001ED0 RID: 7888 RVA: 0x00053CDF File Offset: 0x00051EDF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PreOpenDetections> PreOpenSilenceAreaDetections
		{
			get
			{
				return this.preOpenSilenceAreaDetections_;
			}
		}

		// Token: 0x06001ED1 RID: 7889 RVA: 0x00053CE7 File Offset: 0x00051EE7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AdventureManualResponse);
		}

		// Token: 0x06001ED2 RID: 7890 RVA: 0x00053CF8 File Offset: 0x00051EF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AdventureManualResponse other)
		{
			return other != null && (other == this || (this.Code == other.Code && object.Equals(this.AdventureManualData, other.AdventureManualData) && this.detectionTarget_.Equals(other.detectionTarget_) && this.adventureRewardData_.Equals(other.adventureRewardData_) && object.Equals(this.DetectionUnlocks, other.DetectionUnlocks) && object.Equals(this.NowSelectDetectionTarget, other.NowSelectDetectionTarget) && this.SlientFirstAwardMap.Equals(other.SlientFirstAwardMap) && this.silenceAreaConfigs_.Equals(other.silenceAreaConfigs_) && this.dungeonDetectionConfigs_.Equals(other.dungeonDetectionConfigs_) && this.preOpenDungeonDetections_.Equals(other.preOpenDungeonDetections_) && this.preOpenSilenceAreaDetections_.Equals(other.preOpenSilenceAreaDetections_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001ED3 RID: 7891 RVA: 0x00053E04 File Offset: 0x00052004
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Code != ErrorCode.Success)
			{
				num ^= this.Code.GetHashCode();
			}
			if (this.adventureManualData_ != null)
			{
				num ^= this.AdventureManualData.GetHashCode();
			}
			num ^= this.detectionTarget_.GetHashCode();
			num ^= this.adventureRewardData_.GetHashCode();
			if (this.detectionUnlocks_ != null)
			{
				num ^= this.DetectionUnlocks.GetHashCode();
			}
			if (this.nowSelectDetectionTarget_ != null)
			{
				num ^= this.NowSelectDetectionTarget.GetHashCode();
			}
			num ^= this.SlientFirstAwardMap.GetHashCode();
			num ^= this.silenceAreaConfigs_.GetHashCode();
			num ^= this.dungeonDetectionConfigs_.GetHashCode();
			num ^= this.preOpenDungeonDetections_.GetHashCode();
			num ^= this.preOpenSilenceAreaDetections_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06001ED4 RID: 7892 RVA: 0x00053EED File Offset: 0x000520ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06001ED5 RID: 7893 RVA: 0x00053EFA File Offset: 0x000520FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001ED6 RID: 7894 RVA: 0x00053F04 File Offset: 0x00052104
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.nowSelectDetectionTarget_ != null)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.NowSelectDetectionTarget);
			}
			this.slientFirstAwardMap_.WriteTo(ref output, AdventureManualResponse._map_slientFirstAwardMap_codec);
			this.dungeonDetectionConfigs_.WriteTo(ref output, AdventureManualResponse._repeated_dungeonDetectionConfigs_codec);
			this.adventureRewardData_.WriteTo(ref output, AdventureManualResponse._repeated_adventureRewardData_codec);
			if (this.Code != ErrorCode.Success)
			{
				output.WriteRawTag(64);
				output.WriteEnum((int)this.Code);
			}
			this.preOpenSilenceAreaDetections_.WriteTo(ref output, AdventureManualResponse._repeated_preOpenSilenceAreaDetections_codec);
			this.detectionTarget_.WriteTo(ref output, AdventureManualResponse._repeated_detectionTarget_codec);
			this.preOpenDungeonDetections_.WriteTo(ref output, AdventureManualResponse._repeated_preOpenDungeonDetections_codec);
			if (this.detectionUnlocks_ != null)
			{
				output.WriteRawTag(98);
				output.WriteMessage(this.DetectionUnlocks);
			}
			if (this.adventureManualData_ != null)
			{
				output.WriteRawTag(106);
				output.WriteMessage(this.AdventureManualData);
			}
			this.silenceAreaConfigs_.WriteTo(ref output, AdventureManualResponse._repeated_silenceAreaConfigs_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001ED7 RID: 7895 RVA: 0x0005400C File Offset: 0x0005220C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Code != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Code);
			}
			if (this.adventureManualData_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.AdventureManualData);
			}
			num += this.detectionTarget_.CalculateSize(AdventureManualResponse._repeated_detectionTarget_codec);
			num += this.adventureRewardData_.CalculateSize(AdventureManualResponse._repeated_adventureRewardData_codec);
			if (this.detectionUnlocks_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.DetectionUnlocks);
			}
			if (this.nowSelectDetectionTarget_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.NowSelectDetectionTarget);
			}
			num += this.slientFirstAwardMap_.CalculateSize(AdventureManualResponse._map_slientFirstAwardMap_codec);
			num += this.silenceAreaConfigs_.CalculateSize(AdventureManualResponse._repeated_silenceAreaConfigs_codec);
			num += this.dungeonDetectionConfigs_.CalculateSize(AdventureManualResponse._repeated_dungeonDetectionConfigs_codec);
			num += this.preOpenDungeonDetections_.CalculateSize(AdventureManualResponse._repeated_preOpenDungeonDetections_codec);
			num += this.preOpenSilenceAreaDetections_.CalculateSize(AdventureManualResponse._repeated_preOpenSilenceAreaDetections_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06001ED8 RID: 7896 RVA: 0x00054118 File Offset: 0x00052318
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AdventureManualResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Code != ErrorCode.Success)
			{
				this.Code = other.Code;
			}
			if (other.adventureManualData_ != null)
			{
				if (this.adventureManualData_ == null)
				{
					this.AdventureManualData = new AdventureManualData();
				}
				this.AdventureManualData.MergeFrom(other.AdventureManualData);
			}
			this.detectionTarget_.Add(other.detectionTarget_);
			this.adventureRewardData_.Add(other.adventureRewardData_);
			if (other.detectionUnlocks_ != null)
			{
				if (this.detectionUnlocks_ == null)
				{
					this.DetectionUnlocks = new DetectionUnlock();
				}
				this.DetectionUnlocks.MergeFrom(other.DetectionUnlocks);
			}
			if (other.nowSelectDetectionTarget_ != null)
			{
				if (this.nowSelectDetectionTarget_ == null)
				{
					this.NowSelectDetectionTarget = new SelectDetectionTarget();
				}
				this.NowSelectDetectionTarget.MergeFrom(other.NowSelectDetectionTarget);
			}
			this.slientFirstAwardMap_.MergeFrom(other.slientFirstAwardMap_);
			this.silenceAreaConfigs_.Add(other.silenceAreaConfigs_);
			this.dungeonDetectionConfigs_.Add(other.dungeonDetectionConfigs_);
			this.preOpenDungeonDetections_.Add(other.preOpenDungeonDetections_);
			this.preOpenSilenceAreaDetections_.Add(other.preOpenSilenceAreaDetections_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06001ED9 RID: 7897 RVA: 0x0005424F File Offset: 0x0005244F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001EDA RID: 7898 RVA: 0x00054258 File Offset: 0x00052458
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
					if (num <= 26U)
					{
						if (num == 18U)
						{
							if (this.nowSelectDetectionTarget_ == null)
							{
								this.NowSelectDetectionTarget = new SelectDetectionTarget();
							}
							input.ReadMessage(this.NowSelectDetectionTarget);
							continue;
						}
						if (num == 26U)
						{
							this.slientFirstAwardMap_.AddEntriesFrom(ref input, AdventureManualResponse._map_slientFirstAwardMap_codec);
							continue;
						}
					}
					else
					{
						if (num == 34U)
						{
							this.dungeonDetectionConfigs_.AddEntriesFrom(ref input, AdventureManualResponse._repeated_dungeonDetectionConfigs_codec);
							continue;
						}
						if (num == 58U)
						{
							this.adventureRewardData_.AddEntriesFrom(ref input, AdventureManualResponse._repeated_adventureRewardData_codec);
							continue;
						}
						if (num == 64U)
						{
							this.Code = (ErrorCode)input.ReadEnum();
							continue;
						}
					}
				}
				else if (num <= 90U)
				{
					if (num == 74U)
					{
						this.preOpenSilenceAreaDetections_.AddEntriesFrom(ref input, AdventureManualResponse._repeated_preOpenSilenceAreaDetections_codec);
						continue;
					}
					if (num == 82U)
					{
						this.detectionTarget_.AddEntriesFrom(ref input, AdventureManualResponse._repeated_detectionTarget_codec);
						continue;
					}
					if (num == 90U)
					{
						this.preOpenDungeonDetections_.AddEntriesFrom(ref input, AdventureManualResponse._repeated_preOpenDungeonDetections_codec);
						continue;
					}
				}
				else
				{
					if (num == 98U)
					{
						if (this.detectionUnlocks_ == null)
						{
							this.DetectionUnlocks = new DetectionUnlock();
						}
						input.ReadMessage(this.DetectionUnlocks);
						continue;
					}
					if (num == 106U)
					{
						if (this.adventureManualData_ == null)
						{
							this.AdventureManualData = new AdventureManualData();
						}
						input.ReadMessage(this.AdventureManualData);
						continue;
					}
					if (num == 114U)
					{
						this.silenceAreaConfigs_.AddEntriesFrom(ref input, AdventureManualResponse._repeated_silenceAreaConfigs_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04002375 RID: 9077
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002376 RID: 9078
		public const int CodeFieldNumber = 8;

		// Token: 0x04002377 RID: 9079
		private ErrorCode code_;

		// Token: 0x04002378 RID: 9080
		public const int AdventureManualDataFieldNumber = 13;

		// Token: 0x04002379 RID: 9081
		private AdventureManualData adventureManualData_;

		// Token: 0x0400237A RID: 9082
		public const int DetectionTargetFieldNumber = 10;

		// Token: 0x0400237B RID: 9083
		private static readonly FieldCodec<DetectionTarget> _repeated_detectionTarget_codec = FieldCodec.ForMessage<DetectionTarget>(82U, Aki.Protocol.DetectionTarget.Parser);

		// Token: 0x0400237C RID: 9084
		private readonly RepeatedField<DetectionTarget> detectionTarget_ = new RepeatedField<DetectionTarget>();

		// Token: 0x0400237D RID: 9085
		public const int AdventureRewardDataFieldNumber = 7;

		// Token: 0x0400237E RID: 9086
		private static readonly FieldCodec<AdventureRewardData> _repeated_adventureRewardData_codec = FieldCodec.ForMessage<AdventureRewardData>(58U, Aki.Protocol.AdventureRewardData.Parser);

		// Token: 0x0400237F RID: 9087
		private readonly RepeatedField<AdventureRewardData> adventureRewardData_ = new RepeatedField<AdventureRewardData>();

		// Token: 0x04002380 RID: 9088
		public const int DetectionUnlocksFieldNumber = 12;

		// Token: 0x04002381 RID: 9089
		private DetectionUnlock detectionUnlocks_;

		// Token: 0x04002382 RID: 9090
		public const int NowSelectDetectionTargetFieldNumber = 2;

		// Token: 0x04002383 RID: 9091
		private SelectDetectionTarget nowSelectDetectionTarget_;

		// Token: 0x04002384 RID: 9092
		public const int SlientFirstAwardMapFieldNumber = 3;

		// Token: 0x04002385 RID: 9093
		private static readonly MapField<int, SlientFirstAwardState>.Codec _map_slientFirstAwardMap_codec = new MapField<int, SlientFirstAwardState>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForEnum<SlientFirstAwardState>(16U, (SlientFirstAwardState x) => (int)x, (int x) => (SlientFirstAwardState)x, SlientFirstAwardState.NotUnlock), 26U);

		// Token: 0x04002386 RID: 9094
		private readonly MapField<int, SlientFirstAwardState> slientFirstAwardMap_ = new MapField<int, SlientFirstAwardState>();

		// Token: 0x04002387 RID: 9095
		public const int SilenceAreaConfigsFieldNumber = 14;

		// Token: 0x04002388 RID: 9096
		private static readonly FieldCodec<AdventureDetectionConfig> _repeated_silenceAreaConfigs_codec = FieldCodec.ForMessage<AdventureDetectionConfig>(114U, AdventureDetectionConfig.Parser);

		// Token: 0x04002389 RID: 9097
		private readonly RepeatedField<AdventureDetectionConfig> silenceAreaConfigs_ = new RepeatedField<AdventureDetectionConfig>();

		// Token: 0x0400238A RID: 9098
		public const int DungeonDetectionConfigsFieldNumber = 4;

		// Token: 0x0400238B RID: 9099
		private static readonly FieldCodec<AdventureDetectionConfig> _repeated_dungeonDetectionConfigs_codec = FieldCodec.ForMessage<AdventureDetectionConfig>(34U, AdventureDetectionConfig.Parser);

		// Token: 0x0400238C RID: 9100
		private readonly RepeatedField<AdventureDetectionConfig> dungeonDetectionConfigs_ = new RepeatedField<AdventureDetectionConfig>();

		// Token: 0x0400238D RID: 9101
		public const int PreOpenDungeonDetectionsFieldNumber = 11;

		// Token: 0x0400238E RID: 9102
		private static readonly FieldCodec<PreOpenDetections> _repeated_preOpenDungeonDetections_codec = FieldCodec.ForMessage<PreOpenDetections>(90U, PreOpenDetections.Parser);

		// Token: 0x0400238F RID: 9103
		private readonly RepeatedField<PreOpenDetections> preOpenDungeonDetections_ = new RepeatedField<PreOpenDetections>();

		// Token: 0x04002390 RID: 9104
		public const int PreOpenSilenceAreaDetectionsFieldNumber = 9;

		// Token: 0x04002391 RID: 9105
		private static readonly FieldCodec<PreOpenDetections> _repeated_preOpenSilenceAreaDetections_codec = FieldCodec.ForMessage<PreOpenDetections>(74U, PreOpenDetections.Parser);

		// Token: 0x04002392 RID: 9106
		private readonly RepeatedField<PreOpenDetections> preOpenSilenceAreaDetections_ = new RepeatedField<PreOpenDetections>();
	}
}
