using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020012E1 RID: 4833
	public sealed class SpringFestivalActivityInfo : IMessage<SpringFestivalActivityInfo>, IMessage, IEquatable<SpringFestivalActivityInfo>, IDeepCloneable<SpringFestivalActivityInfo>, IBufferMessage
	{
		// Token: 0x06019CAC RID: 105644 RVA: 0x003C32A9 File Offset: 0x003C14A9
		[NullableContext(1)]
		public static SpringFestivalActivityInfo Create()
		{
			return new SpringFestivalActivityInfo();
		}

		// Token: 0x17005759 RID: 22361
		// (get) Token: 0x06019CAD RID: 105645 RVA: 0x003C32B0 File Offset: 0x003C14B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700575A RID: 22362
		// (get) Token: 0x06019CAE RID: 105646 RVA: 0x003C32B3 File Offset: 0x003C14B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SpringFestivalActivityInfo.Descriptor;
			}
		}

		// Token: 0x06019CAF RID: 105647 RVA: 0x003C32BC File Offset: 0x003C14BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SpringFestivalActivityInfo()
		{
		}

		// Token: 0x06019CB0 RID: 105648 RVA: 0x003C3334 File Offset: 0x003C1534
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

		// Token: 0x06019CB1 RID: 105649 RVA: 0x003C3425 File Offset: 0x003C1625
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SpringFestivalActivityInfo Clone()
		{
			return new SpringFestivalActivityInfo(this);
		}

		// Token: 0x1700575B RID: 22363
		// (get) Token: 0x06019CB2 RID: 105650 RVA: 0x003C342D File Offset: 0x003C162D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<AreaInfo> AreaInfos
		{
			get
			{
				return this.areaInfos_;
			}
		}

		// Token: 0x1700575C RID: 22364
		// (get) Token: 0x06019CB3 RID: 105651 RVA: 0x003C3435 File Offset: 0x003C1635
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> UnlockFurnitures
		{
			get
			{
				return this.unlockFurnitures_;
			}
		}

		// Token: 0x1700575D RID: 22365
		// (get) Token: 0x06019CB4 RID: 105652 RVA: 0x003C343D File Offset: 0x003C163D
		// (set) Token: 0x06019CB5 RID: 105653 RVA: 0x003C3445 File Offset: 0x003C1645
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

		// Token: 0x1700575E RID: 22366
		// (get) Token: 0x06019CB6 RID: 105654 RVA: 0x003C344E File Offset: 0x003C164E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<OneBrochureInfo> OneBrochureInfos
		{
			get
			{
				return this.oneBrochureInfos_;
			}
		}

		// Token: 0x1700575F RID: 22367
		// (get) Token: 0x06019CB7 RID: 105655 RVA: 0x003C3456 File Offset: 0x003C1656
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<GuessJokerLevelInfo> JokerLevelInfos
		{
			get
			{
				return this.jokerLevelInfos_;
			}
		}

		// Token: 0x17005760 RID: 22368
		// (get) Token: 0x06019CB8 RID: 105656 RVA: 0x003C345E File Offset: 0x003C165E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ConditionTask> ConditionTasks
		{
			get
			{
				return this.conditionTasks_;
			}
		}

		// Token: 0x17005761 RID: 22369
		// (get) Token: 0x06019CB9 RID: 105657 RVA: 0x003C3466 File Offset: 0x003C1666
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> SpringFunctionIds
		{
			get
			{
				return this.springFunctionIds_;
			}
		}

		// Token: 0x17005762 RID: 22370
		// (get) Token: 0x06019CBA RID: 105658 RVA: 0x003C346E File Offset: 0x003C166E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> RewardScoreIds
		{
			get
			{
				return this.rewardScoreIds_;
			}
		}

		// Token: 0x17005763 RID: 22371
		// (get) Token: 0x06019CBB RID: 105659 RVA: 0x003C3476 File Offset: 0x003C1676
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> RewardLevelIds
		{
			get
			{
				return this.rewardLevelIds_;
			}
		}

		// Token: 0x17005764 RID: 22372
		// (get) Token: 0x06019CBC RID: 105660 RVA: 0x003C347E File Offset: 0x003C167E
		// (set) Token: 0x06019CBD RID: 105661 RVA: 0x003C3486 File Offset: 0x003C1686
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

		// Token: 0x17005765 RID: 22373
		// (get) Token: 0x06019CBE RID: 105662 RVA: 0x003C348F File Offset: 0x003C168F
		// (set) Token: 0x06019CBF RID: 105663 RVA: 0x003C3497 File Offset: 0x003C1697
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

		// Token: 0x17005766 RID: 22374
		// (get) Token: 0x06019CC0 RID: 105664 RVA: 0x003C34A0 File Offset: 0x003C16A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<SpringSkipEntry> SpringSkipEntries
		{
			get
			{
				return this.springSkipEntries_;
			}
		}

		// Token: 0x06019CC1 RID: 105665 RVA: 0x003C34A8 File Offset: 0x003C16A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SpringFestivalActivityInfo);
		}

		// Token: 0x06019CC2 RID: 105666 RVA: 0x003C34B8 File Offset: 0x003C16B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SpringFestivalActivityInfo other)
		{
			return other != null && (other == this || (this.areaInfos_.Equals(other.areaInfos_) && this.unlockFurnitures_.Equals(other.unlockFurnitures_) && object.Equals(this.DrinkMixData, other.DrinkMixData) && this.oneBrochureInfos_.Equals(other.oneBrochureInfos_) && this.jokerLevelInfos_.Equals(other.jokerLevelInfos_) && this.conditionTasks_.Equals(other.conditionTasks_) && this.springFunctionIds_.Equals(other.springFunctionIds_) && this.rewardScoreIds_.Equals(other.rewardScoreIds_) && this.rewardLevelIds_.Equals(other.rewardLevelIds_) && this.Atmosphere == other.Atmosphere && this.AtmosphereLevel == other.AtmosphereLevel && this.springSkipEntries_.Equals(other.springSkipEntries_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06019CC3 RID: 105667 RVA: 0x003C35D4 File Offset: 0x003C17D4
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

		// Token: 0x06019CC4 RID: 105668 RVA: 0x003C36C0 File Offset: 0x003C18C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06019CC5 RID: 105669 RVA: 0x003C36CD File Offset: 0x003C18CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06019CC6 RID: 105670 RVA: 0x003C36D8 File Offset: 0x003C18D8
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

		// Token: 0x06019CC7 RID: 105671 RVA: 0x003C37E8 File Offset: 0x003C19E8
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

		// Token: 0x06019CC8 RID: 105672 RVA: 0x003C3904 File Offset: 0x003C1B04
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

		// Token: 0x06019CC9 RID: 105673 RVA: 0x003C3A19 File Offset: 0x003C1C19
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06019CCA RID: 105674 RVA: 0x003C3A24 File Offset: 0x003C1C24
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

		// Token: 0x04009836 RID: 38966
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009837 RID: 38967
		public const int AreaInfosFieldNumber = 1;

		// Token: 0x04009838 RID: 38968
		private static readonly FieldCodec<AreaInfo> _repeated_areaInfos_codec = FieldCodec.ForMessage<AreaInfo>(10U, AreaInfo.Parser);

		// Token: 0x04009839 RID: 38969
		private readonly RepeatedField<AreaInfo> areaInfos_ = new RepeatedField<AreaInfo>();

		// Token: 0x0400983A RID: 38970
		public const int UnlockFurnituresFieldNumber = 2;

		// Token: 0x0400983B RID: 38971
		private static readonly FieldCodec<int> _repeated_unlockFurnitures_codec = FieldCodec.ForInt32(18U);

		// Token: 0x0400983C RID: 38972
		private readonly RepeatedField<int> unlockFurnitures_ = new RepeatedField<int>();

		// Token: 0x0400983D RID: 38973
		public const int DrinkMixDataFieldNumber = 3;

		// Token: 0x0400983E RID: 38974
		private DrinkMixData drinkMixData_;

		// Token: 0x0400983F RID: 38975
		public const int OneBrochureInfosFieldNumber = 4;

		// Token: 0x04009840 RID: 38976
		private static readonly FieldCodec<OneBrochureInfo> _repeated_oneBrochureInfos_codec = FieldCodec.ForMessage<OneBrochureInfo>(34U, OneBrochureInfo.Parser);

		// Token: 0x04009841 RID: 38977
		private readonly RepeatedField<OneBrochureInfo> oneBrochureInfos_ = new RepeatedField<OneBrochureInfo>();

		// Token: 0x04009842 RID: 38978
		public const int JokerLevelInfosFieldNumber = 5;

		// Token: 0x04009843 RID: 38979
		private static readonly FieldCodec<GuessJokerLevelInfo> _repeated_jokerLevelInfos_codec = FieldCodec.ForMessage<GuessJokerLevelInfo>(42U, GuessJokerLevelInfo.Parser);

		// Token: 0x04009844 RID: 38980
		private readonly RepeatedField<GuessJokerLevelInfo> jokerLevelInfos_ = new RepeatedField<GuessJokerLevelInfo>();

		// Token: 0x04009845 RID: 38981
		public const int ConditionTasksFieldNumber = 6;

		// Token: 0x04009846 RID: 38982
		private static readonly FieldCodec<ConditionTask> _repeated_conditionTasks_codec = FieldCodec.ForMessage<ConditionTask>(50U, ConditionTask.Parser);

		// Token: 0x04009847 RID: 38983
		private readonly RepeatedField<ConditionTask> conditionTasks_ = new RepeatedField<ConditionTask>();

		// Token: 0x04009848 RID: 38984
		public const int SpringFunctionIdsFieldNumber = 7;

		// Token: 0x04009849 RID: 38985
		private static readonly FieldCodec<int> _repeated_springFunctionIds_codec = FieldCodec.ForInt32(58U);

		// Token: 0x0400984A RID: 38986
		private readonly RepeatedField<int> springFunctionIds_ = new RepeatedField<int>();

		// Token: 0x0400984B RID: 38987
		public const int RewardScoreIdsFieldNumber = 8;

		// Token: 0x0400984C RID: 38988
		private static readonly FieldCodec<int> _repeated_rewardScoreIds_codec = FieldCodec.ForInt32(66U);

		// Token: 0x0400984D RID: 38989
		private readonly RepeatedField<int> rewardScoreIds_ = new RepeatedField<int>();

		// Token: 0x0400984E RID: 38990
		public const int RewardLevelIdsFieldNumber = 9;

		// Token: 0x0400984F RID: 38991
		private static readonly FieldCodec<int> _repeated_rewardLevelIds_codec = FieldCodec.ForInt32(74U);

		// Token: 0x04009850 RID: 38992
		private readonly RepeatedField<int> rewardLevelIds_ = new RepeatedField<int>();

		// Token: 0x04009851 RID: 38993
		public const int AtmosphereFieldNumber = 10;

		// Token: 0x04009852 RID: 38994
		private int atmosphere_;

		// Token: 0x04009853 RID: 38995
		public const int AtmosphereLevelFieldNumber = 11;

		// Token: 0x04009854 RID: 38996
		private int atmosphereLevel_;

		// Token: 0x04009855 RID: 38997
		public const int SpringSkipEntriesFieldNumber = 12;

		// Token: 0x04009856 RID: 38998
		private static readonly FieldCodec<SpringSkipEntry> _repeated_springSkipEntries_codec = FieldCodec.ForMessage<SpringSkipEntry>(98U, SpringSkipEntry.Parser);

		// Token: 0x04009857 RID: 38999
		private readonly RepeatedField<SpringSkipEntry> springSkipEntries_ = new RepeatedField<SpringSkipEntry>();
	}
}
