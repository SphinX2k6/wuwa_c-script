using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020000C1 RID: 193
	[NetMessage(EMessageId.AdventureManualResponse)]
	public sealed class AdventureManualResponse : IMessage<AdventureManualResponse>, IMessage, IEquatable<AdventureManualResponse>, IDeepCloneable<AdventureManualResponse>, IBufferMessage
	{
		// Token: 0x06001F05 RID: 7941 RVA: 0x000547A9 File Offset: 0x000529A9
		[NullableContext(1)]
		public static AdventureManualResponse Create()
		{
			return new AdventureManualResponse();
		}

		// Token: 0x170003A4 RID: 932
		// (get) Token: 0x06001F06 RID: 7942 RVA: 0x000547B0 File Offset: 0x000529B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170003A5 RID: 933
		// (get) Token: 0x06001F07 RID: 7943 RVA: 0x000547B3 File Offset: 0x000529B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AdventureManualResponse.Descriptor;
			}
		}

		// Token: 0x06001F08 RID: 7944 RVA: 0x000547BC File Offset: 0x000529BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AdventureManualResponse()
		{
		}

		// Token: 0x06001F09 RID: 7945 RVA: 0x0005481C File Offset: 0x00052A1C
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

		// Token: 0x06001F0A RID: 7946 RVA: 0x00054917 File Offset: 0x00052B17
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AdventureManualResponse Clone()
		{
			return new AdventureManualResponse(this);
		}

		// Token: 0x170003A6 RID: 934
		// (get) Token: 0x06001F0B RID: 7947 RVA: 0x0005491F File Offset: 0x00052B1F
		// (set) Token: 0x06001F0C RID: 7948 RVA: 0x00054927 File Offset: 0x00052B27
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

		// Token: 0x170003A7 RID: 935
		// (get) Token: 0x06001F0D RID: 7949 RVA: 0x00054930 File Offset: 0x00052B30
		// (set) Token: 0x06001F0E RID: 7950 RVA: 0x00054938 File Offset: 0x00052B38
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

		// Token: 0x170003A8 RID: 936
		// (get) Token: 0x06001F0F RID: 7951 RVA: 0x00054941 File Offset: 0x00052B41
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<DetectionTarget> DetectionTarget
		{
			get
			{
				return this.detectionTarget_;
			}
		}

		// Token: 0x170003A9 RID: 937
		// (get) Token: 0x06001F10 RID: 7952 RVA: 0x00054949 File Offset: 0x00052B49
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<AdventureRewardData> AdventureRewardData
		{
			get
			{
				return this.adventureRewardData_;
			}
		}

		// Token: 0x170003AA RID: 938
		// (get) Token: 0x06001F11 RID: 7953 RVA: 0x00054951 File Offset: 0x00052B51
		// (set) Token: 0x06001F12 RID: 7954 RVA: 0x00054959 File Offset: 0x00052B59
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

		// Token: 0x170003AB RID: 939
		// (get) Token: 0x06001F13 RID: 7955 RVA: 0x00054962 File Offset: 0x00052B62
		// (set) Token: 0x06001F14 RID: 7956 RVA: 0x0005496A File Offset: 0x00052B6A
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

		// Token: 0x170003AC RID: 940
		// (get) Token: 0x06001F15 RID: 7957 RVA: 0x00054973 File Offset: 0x00052B73
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, SlientFirstAwardState> SlientFirstAwardMap
		{
			get
			{
				return this.slientFirstAwardMap_;
			}
		}

		// Token: 0x170003AD RID: 941
		// (get) Token: 0x06001F16 RID: 7958 RVA: 0x0005497B File Offset: 0x00052B7B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<AdventureDetectionConfig> SilenceAreaConfigs
		{
			get
			{
				return this.silenceAreaConfigs_;
			}
		}

		// Token: 0x170003AE RID: 942
		// (get) Token: 0x06001F17 RID: 7959 RVA: 0x00054983 File Offset: 0x00052B83
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<AdventureDetectionConfig> DungeonDetectionConfigs
		{
			get
			{
				return this.dungeonDetectionConfigs_;
			}
		}

		// Token: 0x170003AF RID: 943
		// (get) Token: 0x06001F18 RID: 7960 RVA: 0x0005498B File Offset: 0x00052B8B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PreOpenDetections> PreOpenDungeonDetections
		{
			get
			{
				return this.preOpenDungeonDetections_;
			}
		}

		// Token: 0x170003B0 RID: 944
		// (get) Token: 0x06001F19 RID: 7961 RVA: 0x00054993 File Offset: 0x00052B93
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PreOpenDetections> PreOpenSilenceAreaDetections
		{
			get
			{
				return this.preOpenSilenceAreaDetections_;
			}
		}

		// Token: 0x06001F1A RID: 7962 RVA: 0x0005499B File Offset: 0x00052B9B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AdventureManualResponse);
		}

		// Token: 0x06001F1B RID: 7963 RVA: 0x000549AC File Offset: 0x00052BAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AdventureManualResponse other)
		{
			return other != null && (other == this || (this.Code == other.Code && object.Equals(this.AdventureManualData, other.AdventureManualData) && this.detectionTarget_.Equals(other.detectionTarget_) && this.adventureRewardData_.Equals(other.adventureRewardData_) && object.Equals(this.DetectionUnlocks, other.DetectionUnlocks) && object.Equals(this.NowSelectDetectionTarget, other.NowSelectDetectionTarget) && this.SlientFirstAwardMap.Equals(other.SlientFirstAwardMap) && this.silenceAreaConfigs_.Equals(other.silenceAreaConfigs_) && this.dungeonDetectionConfigs_.Equals(other.dungeonDetectionConfigs_) && this.preOpenDungeonDetections_.Equals(other.preOpenDungeonDetections_) && this.preOpenSilenceAreaDetections_.Equals(other.preOpenSilenceAreaDetections_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001F1C RID: 7964 RVA: 0x00054AB8 File Offset: 0x00052CB8
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

		// Token: 0x06001F1D RID: 7965 RVA: 0x00054BA1 File Offset: 0x00052DA1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06001F1E RID: 7966 RVA: 0x00054BAE File Offset: 0x00052DAE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001F1F RID: 7967 RVA: 0x00054BB8 File Offset: 0x00052DB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.detectionUnlocks_ != null)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.DetectionUnlocks);
			}
			this.adventureRewardData_.WriteTo(ref output, AdventureManualResponse._repeated_adventureRewardData_codec);
			this.preOpenSilenceAreaDetections_.WriteTo(ref output, AdventureManualResponse._repeated_preOpenSilenceAreaDetections_codec);
			this.dungeonDetectionConfigs_.WriteTo(ref output, AdventureManualResponse._repeated_dungeonDetectionConfigs_codec);
			if (this.Code != ErrorCode.Success)
			{
				output.WriteRawTag(56);
				output.WriteEnum((int)this.Code);
			}
			this.slientFirstAwardMap_.WriteTo(ref output, AdventureManualResponse._map_slientFirstAwardMap_codec);
			this.preOpenDungeonDetections_.WriteTo(ref output, AdventureManualResponse._repeated_preOpenDungeonDetections_codec);
			this.silenceAreaConfigs_.WriteTo(ref output, AdventureManualResponse._repeated_silenceAreaConfigs_codec);
			if (this.nowSelectDetectionTarget_ != null)
			{
				output.WriteRawTag(98);
				output.WriteMessage(this.NowSelectDetectionTarget);
			}
			if (this.adventureManualData_ != null)
			{
				output.WriteRawTag(114);
				output.WriteMessage(this.AdventureManualData);
			}
			this.detectionTarget_.WriteTo(ref output, AdventureManualResponse._repeated_detectionTarget_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001F20 RID: 7968 RVA: 0x00054CC0 File Offset: 0x00052EC0
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

		// Token: 0x06001F21 RID: 7969 RVA: 0x00054DCC File Offset: 0x00052FCC
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

		// Token: 0x06001F22 RID: 7970 RVA: 0x00054F03 File Offset: 0x00053103
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001F23 RID: 7971 RVA: 0x00054F0C File Offset: 0x0005310C
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
					if (num <= 34U)
					{
						if (num == 18U)
						{
							if (this.detectionUnlocks_ == null)
							{
								this.DetectionUnlocks = new DetectionUnlock();
							}
							input.ReadMessage(this.DetectionUnlocks);
							continue;
						}
						if (num == 34U)
						{
							this.adventureRewardData_.AddEntriesFrom(ref input, AdventureManualResponse._repeated_adventureRewardData_codec);
							continue;
						}
					}
					else
					{
						if (num == 42U)
						{
							this.preOpenSilenceAreaDetections_.AddEntriesFrom(ref input, AdventureManualResponse._repeated_preOpenSilenceAreaDetections_codec);
							continue;
						}
						if (num == 50U)
						{
							this.dungeonDetectionConfigs_.AddEntriesFrom(ref input, AdventureManualResponse._repeated_dungeonDetectionConfigs_codec);
							continue;
						}
						if (num == 56U)
						{
							this.Code = (ErrorCode)input.ReadEnum();
							continue;
						}
					}
				}
				else if (num <= 90U)
				{
					if (num == 66U)
					{
						this.slientFirstAwardMap_.AddEntriesFrom(ref input, AdventureManualResponse._map_slientFirstAwardMap_codec);
						continue;
					}
					if (num == 82U)
					{
						this.preOpenDungeonDetections_.AddEntriesFrom(ref input, AdventureManualResponse._repeated_preOpenDungeonDetections_codec);
						continue;
					}
					if (num == 90U)
					{
						this.silenceAreaConfigs_.AddEntriesFrom(ref input, AdventureManualResponse._repeated_silenceAreaConfigs_codec);
						continue;
					}
				}
				else
				{
					if (num == 98U)
					{
						if (this.nowSelectDetectionTarget_ == null)
						{
							this.NowSelectDetectionTarget = new SelectDetectionTarget();
						}
						input.ReadMessage(this.NowSelectDetectionTarget);
						continue;
					}
					if (num == 114U)
					{
						if (this.adventureManualData_ == null)
						{
							this.AdventureManualData = new AdventureManualData();
						}
						input.ReadMessage(this.AdventureManualData);
						continue;
					}
					if (num == 122U)
					{
						this.detectionTarget_.AddEntriesFrom(ref input, AdventureManualResponse._repeated_detectionTarget_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040023D8 RID: 9176
		private UnknownFieldSet _unknownFields;

		// Token: 0x040023D9 RID: 9177
		public const int CodeFieldNumber = 7;

		// Token: 0x040023DA RID: 9178
		private ErrorCode code_;

		// Token: 0x040023DB RID: 9179
		public const int AdventureManualDataFieldNumber = 14;

		// Token: 0x040023DC RID: 9180
		private AdventureManualData adventureManualData_;

		// Token: 0x040023DD RID: 9181
		public const int DetectionTargetFieldNumber = 15;

		// Token: 0x040023DE RID: 9182
		private static readonly FieldCodec<DetectionTarget> _repeated_detectionTarget_codec = FieldCodec.ForMessage<DetectionTarget>(122U, Aki.Protocol.DetectionTarget.Parser);

		// Token: 0x040023DF RID: 9183
		private readonly RepeatedField<DetectionTarget> detectionTarget_ = new RepeatedField<DetectionTarget>();

		// Token: 0x040023E0 RID: 9184
		public const int AdventureRewardDataFieldNumber = 4;

		// Token: 0x040023E1 RID: 9185
		private static readonly FieldCodec<AdventureRewardData> _repeated_adventureRewardData_codec = FieldCodec.ForMessage<AdventureRewardData>(34U, Aki.Protocol.AdventureRewardData.Parser);

		// Token: 0x040023E2 RID: 9186
		private readonly RepeatedField<AdventureRewardData> adventureRewardData_ = new RepeatedField<AdventureRewardData>();

		// Token: 0x040023E3 RID: 9187
		public const int DetectionUnlocksFieldNumber = 2;

		// Token: 0x040023E4 RID: 9188
		private DetectionUnlock detectionUnlocks_;

		// Token: 0x040023E5 RID: 9189
		public const int NowSelectDetectionTargetFieldNumber = 12;

		// Token: 0x040023E6 RID: 9190
		private SelectDetectionTarget nowSelectDetectionTarget_;

		// Token: 0x040023E7 RID: 9191
		public const int SlientFirstAwardMapFieldNumber = 8;

		// Token: 0x040023E8 RID: 9192
		private static readonly MapField<int, SlientFirstAwardState>.Codec _map_slientFirstAwardMap_codec = new MapField<int, SlientFirstAwardState>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForEnum<SlientFirstAwardState>(16U, (SlientFirstAwardState x) => (int)x, (int x) => (SlientFirstAwardState)x, SlientFirstAwardState.NotUnlock), 66U);

		// Token: 0x040023E9 RID: 9193
		private readonly MapField<int, SlientFirstAwardState> slientFirstAwardMap_ = new MapField<int, SlientFirstAwardState>();

		// Token: 0x040023EA RID: 9194
		public const int SilenceAreaConfigsFieldNumber = 11;

		// Token: 0x040023EB RID: 9195
		private static readonly FieldCodec<AdventureDetectionConfig> _repeated_silenceAreaConfigs_codec = FieldCodec.ForMessage<AdventureDetectionConfig>(90U, AdventureDetectionConfig.Parser);

		// Token: 0x040023EC RID: 9196
		private readonly RepeatedField<AdventureDetectionConfig> silenceAreaConfigs_ = new RepeatedField<AdventureDetectionConfig>();

		// Token: 0x040023ED RID: 9197
		public const int DungeonDetectionConfigsFieldNumber = 6;

		// Token: 0x040023EE RID: 9198
		private static readonly FieldCodec<AdventureDetectionConfig> _repeated_dungeonDetectionConfigs_codec = FieldCodec.ForMessage<AdventureDetectionConfig>(50U, AdventureDetectionConfig.Parser);

		// Token: 0x040023EF RID: 9199
		private readonly RepeatedField<AdventureDetectionConfig> dungeonDetectionConfigs_ = new RepeatedField<AdventureDetectionConfig>();

		// Token: 0x040023F0 RID: 9200
		public const int PreOpenDungeonDetectionsFieldNumber = 10;

		// Token: 0x040023F1 RID: 9201
		private static readonly FieldCodec<PreOpenDetections> _repeated_preOpenDungeonDetections_codec = FieldCodec.ForMessage<PreOpenDetections>(82U, PreOpenDetections.Parser);

		// Token: 0x040023F2 RID: 9202
		private readonly RepeatedField<PreOpenDetections> preOpenDungeonDetections_ = new RepeatedField<PreOpenDetections>();

		// Token: 0x040023F3 RID: 9203
		public const int PreOpenSilenceAreaDetectionsFieldNumber = 5;

		// Token: 0x040023F4 RID: 9204
		private static readonly FieldCodec<PreOpenDetections> _repeated_preOpenSilenceAreaDetections_codec = FieldCodec.ForMessage<PreOpenDetections>(42U, PreOpenDetections.Parser);

		// Token: 0x040023F5 RID: 9205
		private readonly RepeatedField<PreOpenDetections> preOpenSilenceAreaDetections_ = new RepeatedField<PreOpenDetections>();
	}
}
