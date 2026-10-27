using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001272 RID: 4722
	public sealed class SpringFestivalActivityInfo : IMessage<SpringFestivalActivityInfo>, IMessage, IEquatable<SpringFestivalActivityInfo>, IDeepCloneable<SpringFestivalActivityInfo>, IBufferMessage
	{
		// Token: 0x06019276 RID: 103030 RVA: 0x003A8B59 File Offset: 0x003A6D59
		[NullableContext(1)]
		public static SpringFestivalActivityInfo Create()
		{
			return new SpringFestivalActivityInfo();
		}

		// Token: 0x170054D8 RID: 21720
		// (get) Token: 0x06019277 RID: 103031 RVA: 0x003A8B60 File Offset: 0x003A6D60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170054D9 RID: 21721
		// (get) Token: 0x06019278 RID: 103032 RVA: 0x003A8B63 File Offset: 0x003A6D63
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SpringFestivalActivityInfo.Descriptor;
			}
		}

		// Token: 0x06019279 RID: 103033 RVA: 0x003A8B6C File Offset: 0x003A6D6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SpringFestivalActivityInfo()
		{
		}

		// Token: 0x0601927A RID: 103034 RVA: 0x003A8BE4 File Offset: 0x003A6DE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SpringFestivalActivityInfo(SpringFestivalActivityInfo other) : this()
		{
			this.areaInfos_ = other.areaInfos_.Clone();
			this.unlockFurnitures_ = other.unlockFurnitures_.Clone();
			this.drinkMixData_ = ((other.drinkMixData_ != null) ? other.drinkMixData_.Clone() : null);
			this.oneBrochureInfos_ = other.oneBrochureInfos_.Clone();
			this.jokerLevelInfos_ = other.jokerLevelInfos_.Clone();
			this.conditionTasks_ = other.conditionTasks_.Clone();
			this.springFunctionIds_ = other.springFunctionIds_.Clone();
			this.rewardScoreIds_ = other.rewardScoreIds_.Clone();
			this.rewardLevelIds_ = other.rewardLevelIds_.Clone();
			this.atmosphere_ = other.atmosphere_;
			this.atmosphereLevel_ = other.atmosphereLevel_;
			this.springSkipEntries_ = other.springSkipEntries_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601927B RID: 103035 RVA: 0x003A8CD5 File Offset: 0x003A6ED5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SpringFestivalActivityInfo Clone()
		{
			return new SpringFestivalActivityInfo(this);
		}

		// Token: 0x170054DA RID: 21722
		// (get) Token: 0x0601927C RID: 103036 RVA: 0x003A8CDD File Offset: 0x003A6EDD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<AreaInfo> AreaInfos
		{
			get
			{
				return this.areaInfos_;
			}
		}

		// Token: 0x170054DB RID: 21723
		// (get) Token: 0x0601927D RID: 103037 RVA: 0x003A8CE5 File Offset: 0x003A6EE5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> UnlockFurnitures
		{
			get
			{
				return this.unlockFurnitures_;
			}
		}

		// Token: 0x170054DC RID: 21724
		// (get) Token: 0x0601927E RID: 103038 RVA: 0x003A8CED File Offset: 0x003A6EED
		// (set) Token: 0x0601927F RID: 103039 RVA: 0x003A8CF5 File Offset: 0x003A6EF5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DrinkMixData DrinkMixData
		{
			get
			{
				return this.drinkMixData_;
			}
			set
			{
				this.drinkMixData_ = value;
			}
		}

		// Token: 0x170054DD RID: 21725
		// (get) Token: 0x06019280 RID: 103040 RVA: 0x003A8CFE File Offset: 0x003A6EFE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<OneBrochureInfo> OneBrochureInfos
		{
			get
			{
				return this.oneBrochureInfos_;
			}
		}

		// Token: 0x170054DE RID: 21726
		// (get) Token: 0x06019281 RID: 103041 RVA: 0x003A8D06 File Offset: 0x003A6F06
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<GuessJokerLevelInfo> JokerLevelInfos
		{
			get
			{
				return this.jokerLevelInfos_;
			}
		}

		// Token: 0x170054DF RID: 21727
		// (get) Token: 0x06019282 RID: 103042 RVA: 0x003A8D0E File Offset: 0x003A6F0E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ConditionTask> ConditionTasks
		{
			get
			{
				return this.conditionTasks_;
			}
		}

		// Token: 0x170054E0 RID: 21728
		// (get) Token: 0x06019283 RID: 103043 RVA: 0x003A8D16 File Offset: 0x003A6F16
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> SpringFunctionIds
		{
			get
			{
				return this.springFunctionIds_;
			}
		}

		// Token: 0x170054E1 RID: 21729
		// (get) Token: 0x06019284 RID: 103044 RVA: 0x003A8D1E File Offset: 0x003A6F1E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> RewardScoreIds
		{
			get
			{
				return this.rewardScoreIds_;
			}
		}

		// Token: 0x170054E2 RID: 21730
		// (get) Token: 0x06019285 RID: 103045 RVA: 0x003A8D26 File Offset: 0x003A6F26
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> RewardLevelIds
		{
			get
			{
				return this.rewardLevelIds_;
			}
		}

		// Token: 0x170054E3 RID: 21731
		// (get) Token: 0x06019286 RID: 103046 RVA: 0x003A8D2E File Offset: 0x003A6F2E
		// (set) Token: 0x06019287 RID: 103047 RVA: 0x003A8D36 File Offset: 0x003A6F36
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Atmosphere
		{
			get
			{
				return this.atmosphere_;
			}
			set
			{
				this.atmosphere_ = value;
			}
		}

		// Token: 0x170054E4 RID: 21732
		// (get) Token: 0x06019288 RID: 103048 RVA: 0x003A8D3F File Offset: 0x003A6F3F
		// (set) Token: 0x06019289 RID: 103049 RVA: 0x003A8D47 File Offset: 0x003A6F47
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int AtmosphereLevel
		{
			get
			{
				return this.atmosphereLevel_;
			}
			set
			{
				this.atmosphereLevel_ = value;
			}
		}

		// Token: 0x170054E5 RID: 21733
		// (get) Token: 0x0601928A RID: 103050 RVA: 0x003A8D50 File Offset: 0x003A6F50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<SpringSkipEntry> SpringSkipEntries
		{
			get
			{
				return this.springSkipEntries_;
			}
		}

		// Token: 0x0601928B RID: 103051 RVA: 0x003A8D58 File Offset: 0x003A6F58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SpringFestivalActivityInfo);
		}

		// Token: 0x0601928C RID: 103052 RVA: 0x003A8D68 File Offset: 0x003A6F68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SpringFestivalActivityInfo other)
		{
			return other != null && (other == this || (this.areaInfos_.Equals(other.areaInfos_) && this.unlockFurnitures_.Equals(other.unlockFurnitures_) && object.Equals(this.DrinkMixData, other.DrinkMixData) && this.oneBrochureInfos_.Equals(other.oneBrochureInfos_) && this.jokerLevelInfos_.Equals(other.jokerLevelInfos_) && this.conditionTasks_.Equals(other.conditionTasks_) && this.springFunctionIds_.Equals(other.springFunctionIds_) && this.rewardScoreIds_.Equals(other.rewardScoreIds_) && this.rewardLevelIds_.Equals(other.rewardLevelIds_) && this.Atmosphere == other.Atmosphere && this.AtmosphereLevel == other.AtmosphereLevel && this.springSkipEntries_.Equals(other.springSkipEntries_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601928D RID: 103053 RVA: 0x003A8E84 File Offset: 0x003A7084
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.areaInfos_.GetHashCode();
			num ^= this.unlockFurnitures_.GetHashCode();
			if (this.drinkMixData_ != null)
			{
				num ^= this.DrinkMixData.GetHashCode();
			}
			num ^= this.oneBrochureInfos_.GetHashCode();
			num ^= this.jokerLevelInfos_.GetHashCode();
			num ^= this.conditionTasks_.GetHashCode();
			num ^= this.springFunctionIds_.GetHashCode();
			num ^= this.rewardScoreIds_.GetHashCode();
			num ^= this.rewardLevelIds_.GetHashCode();
			if (this.Atmosphere != 0)
			{
				num ^= this.Atmosphere.GetHashCode();
			}
			if (this.AtmosphereLevel != 0)
			{
				num ^= this.AtmosphereLevel.GetHashCode();
			}
			num ^= this.springSkipEntries_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601928E RID: 103054 RVA: 0x003A8F70 File Offset: 0x003A7170
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601928F RID: 103055 RVA: 0x003A8F7D File Offset: 0x003A717D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06019290 RID: 103056 RVA: 0x003A8F88 File Offset: 0x003A7188
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.areaInfos_.WriteTo(ref output, SpringFestivalActivityInfo._repeated_areaInfos_codec);
			this.unlockFurnitures_.WriteTo(ref output, SpringFestivalActivityInfo._repeated_unlockFurnitures_codec);
			if (this.drinkMixData_ != null)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.DrinkMixData);
			}
			this.oneBrochureInfos_.WriteTo(ref output, SpringFestivalActivityInfo._repeated_oneBrochureInfos_codec);
			this.jokerLevelInfos_.WriteTo(ref output, SpringFestivalActivityInfo._repeated_jokerLevelInfos_codec);
			this.conditionTasks_.WriteTo(ref output, SpringFestivalActivityInfo._repeated_conditionTasks_codec);
			this.springFunctionIds_.WriteTo(ref output, SpringFestivalActivityInfo._repeated_springFunctionIds_codec);
			this.rewardScoreIds_.WriteTo(ref output, SpringFestivalActivityInfo._repeated_rewardScoreIds_codec);
			this.rewardLevelIds_.WriteTo(ref output, SpringFestivalActivityInfo._repeated_rewardLevelIds_codec);
			if (this.Atmosphere != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.Atmosphere);
			}
			if (this.AtmosphereLevel != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.AtmosphereLevel);
			}
			this.springSkipEntries_.WriteTo(ref output, SpringFestivalActivityInfo._repeated_springSkipEntries_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06019291 RID: 103057 RVA: 0x003A9098 File Offset: 0x003A7298
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.areaInfos_.CalculateSize(SpringFestivalActivityInfo._repeated_areaInfos_codec);
			num += this.unlockFurnitures_.CalculateSize(SpringFestivalActivityInfo._repeated_unlockFurnitures_codec);
			if (this.drinkMixData_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.DrinkMixData);
			}
			num += this.oneBrochureInfos_.CalculateSize(SpringFestivalActivityInfo._repeated_oneBrochureInfos_codec);
			num += this.jokerLevelInfos_.CalculateSize(SpringFestivalActivityInfo._repeated_jokerLevelInfos_codec);
			num += this.conditionTasks_.CalculateSize(SpringFestivalActivityInfo._repeated_conditionTasks_codec);
			num += this.springFunctionIds_.CalculateSize(SpringFestivalActivityInfo._repeated_springFunctionIds_codec);
			num += this.rewardScoreIds_.CalculateSize(SpringFestivalActivityInfo._repeated_rewardScoreIds_codec);
			num += this.rewardLevelIds_.CalculateSize(SpringFestivalActivityInfo._repeated_rewardLevelIds_codec);
			if (this.Atmosphere != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Atmosphere);
			}
			if (this.AtmosphereLevel != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.AtmosphereLevel);
			}
			num += this.springSkipEntries_.CalculateSize(SpringFestivalActivityInfo._repeated_springSkipEntries_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06019292 RID: 103058 RVA: 0x003A91B4 File Offset: 0x003A73B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SpringFestivalActivityInfo other)
		{
			if (other == null)
			{
				return;
			}
			this.areaInfos_.Add(other.areaInfos_);
			this.unlockFurnitures_.Add(other.unlockFurnitures_);
			if (other.drinkMixData_ != null)
			{
				if (this.drinkMixData_ == null)
				{
					this.DrinkMixData = new DrinkMixData();
				}
				this.DrinkMixData.MergeFrom(other.DrinkMixData);
			}
			this.oneBrochureInfos_.Add(other.oneBrochureInfos_);
			this.jokerLevelInfos_.Add(other.jokerLevelInfos_);
			this.conditionTasks_.Add(other.conditionTasks_);
			this.springFunctionIds_.Add(other.springFunctionIds_);
			this.rewardScoreIds_.Add(other.rewardScoreIds_);
			this.rewardLevelIds_.Add(other.rewardLevelIds_);
			if (other.Atmosphere != 0)
			{
				this.Atmosphere = other.Atmosphere;
			}
			if (other.AtmosphereLevel != 0)
			{
				this.AtmosphereLevel = other.AtmosphereLevel;
			}
			this.springSkipEntries_.Add(other.springSkipEntries_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06019293 RID: 103059 RVA: 0x003A92C9 File Offset: 0x003A74C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06019294 RID: 103060 RVA: 0x003A92D4 File Offset: 0x003A74D4
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
				if (num > 56U)
				{
					if (num <= 72U)
					{
						if (num <= 64U)
						{
							if (num == 58U)
							{
								goto IL_163;
							}
							if (num != 64U)
							{
								goto IL_C0;
							}
						}
						else if (num != 66U)
						{
							if (num != 72U)
							{
								goto IL_C0;
							}
							goto IL_189;
						}
						this.rewardScoreIds_.AddEntriesFrom(ref input, SpringFestivalActivityInfo._repeated_rewardScoreIds_codec);
						continue;
					}
					if (num <= 80U)
					{
						if (num != 74U)
						{
							if (num != 80U)
							{
								goto IL_C0;
							}
							this.Atmosphere = input.ReadInt32();
							continue;
						}
					}
					else
					{
						if (num == 88U)
						{
							this.AtmosphereLevel = input.ReadInt32();
							continue;
						}
						if (num != 98U)
						{
							goto IL_C0;
						}
						this.springSkipEntries_.AddEntriesFrom(ref input, SpringFestivalActivityInfo._repeated_springSkipEntries_codec);
						continue;
					}
					IL_189:
					this.rewardLevelIds_.AddEntriesFrom(ref input, SpringFestivalActivityInfo._repeated_rewardLevelIds_codec);
					continue;
				}
				if (num <= 26U)
				{
					if (num <= 16U)
					{
						if (num == 10U)
						{
							this.areaInfos_.AddEntriesFrom(ref input, SpringFestivalActivityInfo._repeated_areaInfos_codec);
							continue;
						}
						if (num != 16U)
						{
							goto IL_C0;
						}
					}
					else if (num != 18U)
					{
						if (num != 26U)
						{
							goto IL_C0;
						}
						if (this.drinkMixData_ == null)
						{
							this.DrinkMixData = new DrinkMixData();
						}
						input.ReadMessage(this.DrinkMixData);
						continue;
					}
					this.unlockFurnitures_.AddEntriesFrom(ref input, SpringFestivalActivityInfo._repeated_unlockFurnitures_codec);
					continue;
				}
				if (num <= 42U)
				{
					if (num == 34U)
					{
						this.oneBrochureInfos_.AddEntriesFrom(ref input, SpringFestivalActivityInfo._repeated_oneBrochureInfos_codec);
						continue;
					}
					if (num == 42U)
					{
						this.jokerLevelInfos_.AddEntriesFrom(ref input, SpringFestivalActivityInfo._repeated_jokerLevelInfos_codec);
						continue;
					}
				}
				else
				{
					if (num == 50U)
					{
						this.conditionTasks_.AddEntriesFrom(ref input, SpringFestivalActivityInfo._repeated_conditionTasks_codec);
						continue;
					}
					if (num == 56U)
					{
						goto IL_163;
					}
				}
				IL_C0:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				continue;
				IL_163:
				this.springFunctionIds_.AddEntriesFrom(ref input, SpringFestivalActivityInfo._repeated_springFunctionIds_codec);
			}
		}

		// Token: 0x0400940C RID: 37900
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400940D RID: 37901
		public const int AreaInfosFieldNumber = 1;

		// Token: 0x0400940E RID: 37902
		private static readonly FieldCodec<AreaInfo> _repeated_areaInfos_codec = FieldCodec.ForMessage<AreaInfo>(10U, AreaInfo.Parser);

		// Token: 0x0400940F RID: 37903
		private readonly RepeatedField<AreaInfo> areaInfos_ = new RepeatedField<AreaInfo>();

		// Token: 0x04009410 RID: 37904
		public const int UnlockFurnituresFieldNumber = 2;

		// Token: 0x04009411 RID: 37905
		private static readonly FieldCodec<int> _repeated_unlockFurnitures_codec = FieldCodec.ForInt32(18U);

		// Token: 0x04009412 RID: 37906
		private readonly RepeatedField<int> unlockFurnitures_ = new RepeatedField<int>();

		// Token: 0x04009413 RID: 37907
		public const int DrinkMixDataFieldNumber = 3;

		// Token: 0x04009414 RID: 37908
		private DrinkMixData drinkMixData_;

		// Token: 0x04009415 RID: 37909
		public const int OneBrochureInfosFieldNumber = 4;

		// Token: 0x04009416 RID: 37910
		private static readonly FieldCodec<OneBrochureInfo> _repeated_oneBrochureInfos_codec = FieldCodec.ForMessage<OneBrochureInfo>(34U, OneBrochureInfo.Parser);

		// Token: 0x04009417 RID: 37911
		private readonly RepeatedField<OneBrochureInfo> oneBrochureInfos_ = new RepeatedField<OneBrochureInfo>();

		// Token: 0x04009418 RID: 37912
		public const int JokerLevelInfosFieldNumber = 5;

		// Token: 0x04009419 RID: 37913
		private static readonly FieldCodec<GuessJokerLevelInfo> _repeated_jokerLevelInfos_codec = FieldCodec.ForMessage<GuessJokerLevelInfo>(42U, GuessJokerLevelInfo.Parser);

		// Token: 0x0400941A RID: 37914
		private readonly RepeatedField<GuessJokerLevelInfo> jokerLevelInfos_ = new RepeatedField<GuessJokerLevelInfo>();

		// Token: 0x0400941B RID: 37915
		public const int ConditionTasksFieldNumber = 6;

		// Token: 0x0400941C RID: 37916
		private static readonly FieldCodec<ConditionTask> _repeated_conditionTasks_codec = FieldCodec.ForMessage<ConditionTask>(50U, ConditionTask.Parser);

		// Token: 0x0400941D RID: 37917
		private readonly RepeatedField<ConditionTask> conditionTasks_ = new RepeatedField<ConditionTask>();

		// Token: 0x0400941E RID: 37918
		public const int SpringFunctionIdsFieldNumber = 7;

		// Token: 0x0400941F RID: 37919
		private static readonly FieldCodec<int> _repeated_springFunctionIds_codec = FieldCodec.ForInt32(58U);

		// Token: 0x04009420 RID: 37920
		private readonly RepeatedField<int> springFunctionIds_ = new RepeatedField<int>();

		// Token: 0x04009421 RID: 37921
		public const int RewardScoreIdsFieldNumber = 8;

		// Token: 0x04009422 RID: 37922
		private static readonly FieldCodec<int> _repeated_rewardScoreIds_codec = FieldCodec.ForInt32(66U);

		// Token: 0x04009423 RID: 37923
		private readonly RepeatedField<int> rewardScoreIds_ = new RepeatedField<int>();

		// Token: 0x04009424 RID: 37924
		public const int RewardLevelIdsFieldNumber = 9;

		// Token: 0x04009425 RID: 37925
		private static readonly FieldCodec<int> _repeated_rewardLevelIds_codec = FieldCodec.ForInt32(74U);

		// Token: 0x04009426 RID: 37926
		private readonly RepeatedField<int> rewardLevelIds_ = new RepeatedField<int>();

		// Token: 0x04009427 RID: 37927
		public const int AtmosphereFieldNumber = 10;

		// Token: 0x04009428 RID: 37928
		private int atmosphere_;

		// Token: 0x04009429 RID: 37929
		public const int AtmosphereLevelFieldNumber = 11;

		// Token: 0x0400942A RID: 37930
		private int atmosphereLevel_;

		// Token: 0x0400942B RID: 37931
		public const int SpringSkipEntriesFieldNumber = 12;

		// Token: 0x0400942C RID: 37932
		private static readonly FieldCodec<SpringSkipEntry> _repeated_springSkipEntries_codec = FieldCodec.ForMessage<SpringSkipEntry>(98U, SpringSkipEntry.Parser);

		// Token: 0x0400942D RID: 37933
		private readonly RepeatedField<SpringSkipEntry> springSkipEntries_ = new RepeatedField<SpringSkipEntry>();
	}
}
