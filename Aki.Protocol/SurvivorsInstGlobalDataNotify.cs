using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200133A RID: 4922
	[NetMessage(EMessageId.SurvivorsInstGlobalDataNotify)]
	public sealed class SurvivorsInstGlobalDataNotify : IMessage<SurvivorsInstGlobalDataNotify>, IMessage, IEquatable<SurvivorsInstGlobalDataNotify>, IDeepCloneable<SurvivorsInstGlobalDataNotify>, IBufferMessage
	{
		// Token: 0x0601A3C9 RID: 107465 RVA: 0x003D320A File Offset: 0x003D140A
		[NullableContext(1)]
		public static SurvivorsInstGlobalDataNotify Create()
		{
			return new SurvivorsInstGlobalDataNotify();
		}

		// Token: 0x170058DC RID: 22748
		// (get) Token: 0x0601A3CA RID: 107466 RVA: 0x003D3211 File Offset: 0x003D1411
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170058DD RID: 22749
		// (get) Token: 0x0601A3CB RID: 107467 RVA: 0x003D3214 File Offset: 0x003D1414
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SurvivorsInstGlobalDataNotify.Descriptor;
			}
		}

		// Token: 0x0601A3CC RID: 107468 RVA: 0x003D321B File Offset: 0x003D141B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsInstGlobalDataNotify()
		{
		}

		// Token: 0x0601A3CD RID: 107469 RVA: 0x003D325C File Offset: 0x003D145C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsInstGlobalDataNotify(SurvivorsInstGlobalDataNotify other) : this()
		{
			this.forceIncId_ = other.forceIncId_;
			this.survivorsOpDatas_ = other.survivorsOpDatas_.Clone();
			this.survivorsGainDatas_ = other.survivorsGainDatas_.Clone();
			this.globalParams_ = other.globalParams_.Clone();
			this.levelId_ = other.levelId_;
			this.weaponMaxCount_ = other.weaponMaxCount_;
			this.unlockWeaponWave_ = other.unlockWeaponWave_.Clone();
			this.comboParamInfos_ = other.comboParamInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601A3CE RID: 107470 RVA: 0x003D32F9 File Offset: 0x003D14F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsInstGlobalDataNotify Clone()
		{
			return new SurvivorsInstGlobalDataNotify(this);
		}

		// Token: 0x170058DE RID: 22750
		// (get) Token: 0x0601A3CF RID: 107471 RVA: 0x003D3301 File Offset: 0x003D1501
		// (set) Token: 0x0601A3D0 RID: 107472 RVA: 0x003D3309 File Offset: 0x003D1509
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ForceIncId
		{
			get
			{
				return this.forceIncId_;
			}
			set
			{
				this.forceIncId_ = value;
			}
		}

		// Token: 0x170058DF RID: 22751
		// (get) Token: 0x0601A3D1 RID: 107473 RVA: 0x003D3312 File Offset: 0x003D1512
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<SurvivorsOpData> SurvivorsOpDatas
		{
			get
			{
				return this.survivorsOpDatas_;
			}
		}

		// Token: 0x170058E0 RID: 22752
		// (get) Token: 0x0601A3D2 RID: 107474 RVA: 0x003D331A File Offset: 0x003D151A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<SurvivorsGainData> SurvivorsGainDatas
		{
			get
			{
				return this.survivorsGainDatas_;
			}
		}

		// Token: 0x170058E1 RID: 22753
		// (get) Token: 0x0601A3D3 RID: 107475 RVA: 0x003D3322 File Offset: 0x003D1522
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, int> GlobalParams
		{
			get
			{
				return this.globalParams_;
			}
		}

		// Token: 0x170058E2 RID: 22754
		// (get) Token: 0x0601A3D4 RID: 107476 RVA: 0x003D332A File Offset: 0x003D152A
		// (set) Token: 0x0601A3D5 RID: 107477 RVA: 0x003D3332 File Offset: 0x003D1532
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int LevelId
		{
			get
			{
				return this.levelId_;
			}
			set
			{
				this.levelId_ = value;
			}
		}

		// Token: 0x170058E3 RID: 22755
		// (get) Token: 0x0601A3D6 RID: 107478 RVA: 0x003D333B File Offset: 0x003D153B
		// (set) Token: 0x0601A3D7 RID: 107479 RVA: 0x003D3343 File Offset: 0x003D1543
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int WeaponMaxCount
		{
			get
			{
				return this.weaponMaxCount_;
			}
			set
			{
				this.weaponMaxCount_ = value;
			}
		}

		// Token: 0x170058E4 RID: 22756
		// (get) Token: 0x0601A3D8 RID: 107480 RVA: 0x003D334C File Offset: 0x003D154C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> UnlockWeaponWave
		{
			get
			{
				return this.unlockWeaponWave_;
			}
		}

		// Token: 0x170058E5 RID: 22757
		// (get) Token: 0x0601A3D9 RID: 107481 RVA: 0x003D3354 File Offset: 0x003D1554
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ComboParamInfo> ComboParamInfos
		{
			get
			{
				return this.comboParamInfos_;
			}
		}

		// Token: 0x0601A3DA RID: 107482 RVA: 0x003D335C File Offset: 0x003D155C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SurvivorsInstGlobalDataNotify);
		}

		// Token: 0x0601A3DB RID: 107483 RVA: 0x003D336C File Offset: 0x003D156C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SurvivorsInstGlobalDataNotify other)
		{
			return other != null && (other == this || (this.ForceIncId == other.ForceIncId && this.survivorsOpDatas_.Equals(other.survivorsOpDatas_) && this.survivorsGainDatas_.Equals(other.survivorsGainDatas_) && this.GlobalParams.Equals(other.GlobalParams) && this.LevelId == other.LevelId && this.WeaponMaxCount == other.WeaponMaxCount && this.unlockWeaponWave_.Equals(other.unlockWeaponWave_) && this.comboParamInfos_.Equals(other.comboParamInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601A3DC RID: 107484 RVA: 0x003D3430 File Offset: 0x003D1630
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ForceIncId != 0)
			{
				num ^= this.ForceIncId.GetHashCode();
			}
			num ^= this.survivorsOpDatas_.GetHashCode();
			num ^= this.survivorsGainDatas_.GetHashCode();
			num ^= this.GlobalParams.GetHashCode();
			if (this.LevelId != 0)
			{
				num ^= this.LevelId.GetHashCode();
			}
			if (this.WeaponMaxCount != 0)
			{
				num ^= this.WeaponMaxCount.GetHashCode();
			}
			num ^= this.unlockWeaponWave_.GetHashCode();
			num ^= this.comboParamInfos_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601A3DD RID: 107485 RVA: 0x003D34E7 File Offset: 0x003D16E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601A3DE RID: 107486 RVA: 0x003D34F4 File Offset: 0x003D16F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601A3DF RID: 107487 RVA: 0x003D3500 File Offset: 0x003D1700
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ForceIncId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.ForceIncId);
			}
			if (this.WeaponMaxCount != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.WeaponMaxCount);
			}
			this.survivorsOpDatas_.WriteTo(ref output, SurvivorsInstGlobalDataNotify._repeated_survivorsOpDatas_codec);
			if (this.LevelId != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.LevelId);
			}
			this.survivorsGainDatas_.WriteTo(ref output, SurvivorsInstGlobalDataNotify._repeated_survivorsGainDatas_codec);
			this.unlockWeaponWave_.WriteTo(ref output, SurvivorsInstGlobalDataNotify._repeated_unlockWeaponWave_codec);
			this.comboParamInfos_.WriteTo(ref output, SurvivorsInstGlobalDataNotify._repeated_comboParamInfos_codec);
			this.globalParams_.WriteTo(ref output, SurvivorsInstGlobalDataNotify._map_globalParams_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601A3E0 RID: 107488 RVA: 0x003D35CC File Offset: 0x003D17CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ForceIncId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ForceIncId);
			}
			num += this.survivorsOpDatas_.CalculateSize(SurvivorsInstGlobalDataNotify._repeated_survivorsOpDatas_codec);
			num += this.survivorsGainDatas_.CalculateSize(SurvivorsInstGlobalDataNotify._repeated_survivorsGainDatas_codec);
			num += this.globalParams_.CalculateSize(SurvivorsInstGlobalDataNotify._map_globalParams_codec);
			if (this.LevelId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.LevelId);
			}
			if (this.WeaponMaxCount != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.WeaponMaxCount);
			}
			num += this.unlockWeaponWave_.CalculateSize(SurvivorsInstGlobalDataNotify._repeated_unlockWeaponWave_codec);
			num += this.comboParamInfos_.CalculateSize(SurvivorsInstGlobalDataNotify._repeated_comboParamInfos_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601A3E1 RID: 107489 RVA: 0x003D369C File Offset: 0x003D189C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SurvivorsInstGlobalDataNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ForceIncId != 0)
			{
				this.ForceIncId = other.ForceIncId;
			}
			this.survivorsOpDatas_.Add(other.survivorsOpDatas_);
			this.survivorsGainDatas_.Add(other.survivorsGainDatas_);
			this.globalParams_.MergeFrom(other.globalParams_);
			if (other.LevelId != 0)
			{
				this.LevelId = other.LevelId;
			}
			if (other.WeaponMaxCount != 0)
			{
				this.WeaponMaxCount = other.WeaponMaxCount;
			}
			this.unlockWeaponWave_.Add(other.unlockWeaponWave_);
			this.comboParamInfos_.Add(other.comboParamInfos_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601A3E2 RID: 107490 RVA: 0x003D3755 File Offset: 0x003D1955
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601A3E3 RID: 107491 RVA: 0x003D3760 File Offset: 0x003D1960
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
					if (num <= 80U)
					{
						if (num == 66U)
						{
							this.survivorsGainDatas_.AddEntriesFrom(ref input, SurvivorsInstGlobalDataNotify._repeated_survivorsGainDatas_codec);
							continue;
						}
						if (num != 80U)
						{
							goto IL_54;
						}
					}
					else if (num != 82U)
					{
						if (num == 90U)
						{
							this.comboParamInfos_.AddEntriesFrom(ref input, SurvivorsInstGlobalDataNotify._repeated_comboParamInfos_codec);
							continue;
						}
						if (num != 98U)
						{
							goto IL_54;
						}
						this.globalParams_.AddEntriesFrom(ref input, SurvivorsInstGlobalDataNotify._map_globalParams_codec);
						continue;
					}
					this.unlockWeaponWave_.AddEntriesFrom(ref input, SurvivorsInstGlobalDataNotify._repeated_unlockWeaponWave_codec);
					continue;
				}
				if (num <= 24U)
				{
					if (num == 16U)
					{
						this.ForceIncId = input.ReadInt32();
						continue;
					}
					if (num == 24U)
					{
						this.WeaponMaxCount = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 50U)
					{
						this.survivorsOpDatas_.AddEntriesFrom(ref input, SurvivorsInstGlobalDataNotify._repeated_survivorsOpDatas_codec);
						continue;
					}
					if (num == 56U)
					{
						this.LevelId = input.ReadInt32();
						continue;
					}
				}
				IL_54:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04009A4E RID: 39502
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009A4F RID: 39503
		public const int ForceIncIdFieldNumber = 2;

		// Token: 0x04009A50 RID: 39504
		private int forceIncId_;

		// Token: 0x04009A51 RID: 39505
		public const int SurvivorsOpDatasFieldNumber = 6;

		// Token: 0x04009A52 RID: 39506
		private static readonly FieldCodec<SurvivorsOpData> _repeated_survivorsOpDatas_codec = FieldCodec.ForMessage<SurvivorsOpData>(50U, SurvivorsOpData.Parser);

		// Token: 0x04009A53 RID: 39507
		private readonly RepeatedField<SurvivorsOpData> survivorsOpDatas_ = new RepeatedField<SurvivorsOpData>();

		// Token: 0x04009A54 RID: 39508
		public const int SurvivorsGainDatasFieldNumber = 8;

		// Token: 0x04009A55 RID: 39509
		private static readonly FieldCodec<SurvivorsGainData> _repeated_survivorsGainDatas_codec = FieldCodec.ForMessage<SurvivorsGainData>(66U, SurvivorsGainData.Parser);

		// Token: 0x04009A56 RID: 39510
		private readonly RepeatedField<SurvivorsGainData> survivorsGainDatas_ = new RepeatedField<SurvivorsGainData>();

		// Token: 0x04009A57 RID: 39511
		public const int GlobalParamsFieldNumber = 12;

		// Token: 0x04009A58 RID: 39512
		private static readonly MapField<int, int>.Codec _map_globalParams_codec = new MapField<int, int>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForInt32(16U, 0), 98U);

		// Token: 0x04009A59 RID: 39513
		private readonly MapField<int, int> globalParams_ = new MapField<int, int>();

		// Token: 0x04009A5A RID: 39514
		public const int LevelIdFieldNumber = 7;

		// Token: 0x04009A5B RID: 39515
		private int levelId_;

		// Token: 0x04009A5C RID: 39516
		public const int WeaponMaxCountFieldNumber = 3;

		// Token: 0x04009A5D RID: 39517
		private int weaponMaxCount_;

		// Token: 0x04009A5E RID: 39518
		public const int UnlockWeaponWaveFieldNumber = 10;

		// Token: 0x04009A5F RID: 39519
		private static readonly FieldCodec<int> _repeated_unlockWeaponWave_codec = FieldCodec.ForInt32(82U);

		// Token: 0x04009A60 RID: 39520
		private readonly RepeatedField<int> unlockWeaponWave_ = new RepeatedField<int>();

		// Token: 0x04009A61 RID: 39521
		public const int ComboParamInfosFieldNumber = 11;

		// Token: 0x04009A62 RID: 39522
		private static readonly FieldCodec<ComboParamInfo> _repeated_comboParamInfos_codec = FieldCodec.ForMessage<ComboParamInfo>(90U, ComboParamInfo.Parser);

		// Token: 0x04009A63 RID: 39523
		private readonly RepeatedField<ComboParamInfo> comboParamInfos_ = new RepeatedField<ComboParamInfo>();
	}
}
