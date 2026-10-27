using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020012CB RID: 4811
	[NetMessage(EMessageId.SurvivorsInstGlobalDataNotify)]
	public sealed class SurvivorsInstGlobalDataNotify : IMessage<SurvivorsInstGlobalDataNotify>, IMessage, IEquatable<SurvivorsInstGlobalDataNotify>, IDeepCloneable<SurvivorsInstGlobalDataNotify>, IBufferMessage
	{
		// Token: 0x06019993 RID: 104851 RVA: 0x003B8ACD File Offset: 0x003B6CCD
		[NullableContext(1)]
		public static SurvivorsInstGlobalDataNotify Create()
		{
			return new SurvivorsInstGlobalDataNotify();
		}

		// Token: 0x1700565B RID: 22107
		// (get) Token: 0x06019994 RID: 104852 RVA: 0x003B8AD4 File Offset: 0x003B6CD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700565C RID: 22108
		// (get) Token: 0x06019995 RID: 104853 RVA: 0x003B8AD7 File Offset: 0x003B6CD7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SurvivorsInstGlobalDataNotify.Descriptor;
			}
		}

		// Token: 0x06019996 RID: 104854 RVA: 0x003B8ADE File Offset: 0x003B6CDE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsInstGlobalDataNotify()
		{
		}

		// Token: 0x06019997 RID: 104855 RVA: 0x003B8B20 File Offset: 0x003B6D20
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

		// Token: 0x06019998 RID: 104856 RVA: 0x003B8BBD File Offset: 0x003B6DBD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsInstGlobalDataNotify Clone()
		{
			return new SurvivorsInstGlobalDataNotify(this);
		}

		// Token: 0x1700565D RID: 22109
		// (get) Token: 0x06019999 RID: 104857 RVA: 0x003B8BC5 File Offset: 0x003B6DC5
		// (set) Token: 0x0601999A RID: 104858 RVA: 0x003B8BCD File Offset: 0x003B6DCD
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

		// Token: 0x1700565E RID: 22110
		// (get) Token: 0x0601999B RID: 104859 RVA: 0x003B8BD6 File Offset: 0x003B6DD6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<SurvivorsOpData> SurvivorsOpDatas
		{
			get
			{
				return this.survivorsOpDatas_;
			}
		}

		// Token: 0x1700565F RID: 22111
		// (get) Token: 0x0601999C RID: 104860 RVA: 0x003B8BDE File Offset: 0x003B6DDE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<SurvivorsGainData> SurvivorsGainDatas
		{
			get
			{
				return this.survivorsGainDatas_;
			}
		}

		// Token: 0x17005660 RID: 22112
		// (get) Token: 0x0601999D RID: 104861 RVA: 0x003B8BE6 File Offset: 0x003B6DE6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, int> GlobalParams
		{
			get
			{
				return this.globalParams_;
			}
		}

		// Token: 0x17005661 RID: 22113
		// (get) Token: 0x0601999E RID: 104862 RVA: 0x003B8BEE File Offset: 0x003B6DEE
		// (set) Token: 0x0601999F RID: 104863 RVA: 0x003B8BF6 File Offset: 0x003B6DF6
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

		// Token: 0x17005662 RID: 22114
		// (get) Token: 0x060199A0 RID: 104864 RVA: 0x003B8BFF File Offset: 0x003B6DFF
		// (set) Token: 0x060199A1 RID: 104865 RVA: 0x003B8C07 File Offset: 0x003B6E07
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

		// Token: 0x17005663 RID: 22115
		// (get) Token: 0x060199A2 RID: 104866 RVA: 0x003B8C10 File Offset: 0x003B6E10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> UnlockWeaponWave
		{
			get
			{
				return this.unlockWeaponWave_;
			}
		}

		// Token: 0x17005664 RID: 22116
		// (get) Token: 0x060199A3 RID: 104867 RVA: 0x003B8C18 File Offset: 0x003B6E18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ComboParamInfo> ComboParamInfos
		{
			get
			{
				return this.comboParamInfos_;
			}
		}

		// Token: 0x060199A4 RID: 104868 RVA: 0x003B8C20 File Offset: 0x003B6E20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SurvivorsInstGlobalDataNotify);
		}

		// Token: 0x060199A5 RID: 104869 RVA: 0x003B8C30 File Offset: 0x003B6E30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SurvivorsInstGlobalDataNotify other)
		{
			return other != null && (other == this || (this.ForceIncId == other.ForceIncId && this.survivorsOpDatas_.Equals(other.survivorsOpDatas_) && this.survivorsGainDatas_.Equals(other.survivorsGainDatas_) && this.GlobalParams.Equals(other.GlobalParams) && this.LevelId == other.LevelId && this.WeaponMaxCount == other.WeaponMaxCount && this.unlockWeaponWave_.Equals(other.unlockWeaponWave_) && this.comboParamInfos_.Equals(other.comboParamInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060199A6 RID: 104870 RVA: 0x003B8CF4 File Offset: 0x003B6EF4
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

		// Token: 0x060199A7 RID: 104871 RVA: 0x003B8DAB File Offset: 0x003B6FAB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060199A8 RID: 104872 RVA: 0x003B8DB8 File Offset: 0x003B6FB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060199A9 RID: 104873 RVA: 0x003B8DC4 File Offset: 0x003B6FC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.comboParamInfos_.WriteTo(ref output, SurvivorsInstGlobalDataNotify._repeated_comboParamInfos_codec);
			this.survivorsGainDatas_.WriteTo(ref output, SurvivorsInstGlobalDataNotify._repeated_survivorsGainDatas_codec);
			if (this.LevelId != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.LevelId);
			}
			this.survivorsOpDatas_.WriteTo(ref output, SurvivorsInstGlobalDataNotify._repeated_survivorsOpDatas_codec);
			this.globalParams_.WriteTo(ref output, SurvivorsInstGlobalDataNotify._map_globalParams_codec);
			if (this.WeaponMaxCount != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.WeaponMaxCount);
			}
			if (this.ForceIncId != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.ForceIncId);
			}
			this.unlockWeaponWave_.WriteTo(ref output, SurvivorsInstGlobalDataNotify._repeated_unlockWeaponWave_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060199AA RID: 104874 RVA: 0x003B8E90 File Offset: 0x003B7090
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

		// Token: 0x060199AB RID: 104875 RVA: 0x003B8F60 File Offset: 0x003B7160
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

		// Token: 0x060199AC RID: 104876 RVA: 0x003B9019 File Offset: 0x003B7219
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060199AD RID: 104877 RVA: 0x003B9024 File Offset: 0x003B7224
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
				if (num <= 90U)
				{
					if (num <= 26U)
					{
						if (num == 10U)
						{
							this.comboParamInfos_.AddEntriesFrom(ref input, SurvivorsInstGlobalDataNotify._repeated_comboParamInfos_codec);
							continue;
						}
						if (num == 26U)
						{
							this.survivorsGainDatas_.AddEntriesFrom(ref input, SurvivorsInstGlobalDataNotify._repeated_survivorsGainDatas_codec);
							continue;
						}
					}
					else
					{
						if (num == 64U)
						{
							this.LevelId = input.ReadInt32();
							continue;
						}
						if (num == 90U)
						{
							this.survivorsOpDatas_.AddEntriesFrom(ref input, SurvivorsInstGlobalDataNotify._repeated_survivorsOpDatas_codec);
							continue;
						}
					}
				}
				else if (num <= 104U)
				{
					if (num == 98U)
					{
						this.globalParams_.AddEntriesFrom(ref input, SurvivorsInstGlobalDataNotify._map_globalParams_codec);
						continue;
					}
					if (num == 104U)
					{
						this.WeaponMaxCount = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 112U)
					{
						this.ForceIncId = input.ReadInt32();
						continue;
					}
					if (num == 120U || num == 122U)
					{
						this.unlockWeaponWave_.AddEntriesFrom(ref input, SurvivorsInstGlobalDataNotify._repeated_unlockWeaponWave_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04009624 RID: 38436
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009625 RID: 38437
		public const int ForceIncIdFieldNumber = 14;

		// Token: 0x04009626 RID: 38438
		private int forceIncId_;

		// Token: 0x04009627 RID: 38439
		public const int SurvivorsOpDatasFieldNumber = 11;

		// Token: 0x04009628 RID: 38440
		private static readonly FieldCodec<SurvivorsOpData> _repeated_survivorsOpDatas_codec = FieldCodec.ForMessage<SurvivorsOpData>(90U, SurvivorsOpData.Parser);

		// Token: 0x04009629 RID: 38441
		private readonly RepeatedField<SurvivorsOpData> survivorsOpDatas_ = new RepeatedField<SurvivorsOpData>();

		// Token: 0x0400962A RID: 38442
		public const int SurvivorsGainDatasFieldNumber = 3;

		// Token: 0x0400962B RID: 38443
		private static readonly FieldCodec<SurvivorsGainData> _repeated_survivorsGainDatas_codec = FieldCodec.ForMessage<SurvivorsGainData>(26U, SurvivorsGainData.Parser);

		// Token: 0x0400962C RID: 38444
		private readonly RepeatedField<SurvivorsGainData> survivorsGainDatas_ = new RepeatedField<SurvivorsGainData>();

		// Token: 0x0400962D RID: 38445
		public const int GlobalParamsFieldNumber = 12;

		// Token: 0x0400962E RID: 38446
		private static readonly MapField<int, int>.Codec _map_globalParams_codec = new MapField<int, int>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForInt32(16U, 0), 98U);

		// Token: 0x0400962F RID: 38447
		private readonly MapField<int, int> globalParams_ = new MapField<int, int>();

		// Token: 0x04009630 RID: 38448
		public const int LevelIdFieldNumber = 8;

		// Token: 0x04009631 RID: 38449
		private int levelId_;

		// Token: 0x04009632 RID: 38450
		public const int WeaponMaxCountFieldNumber = 13;

		// Token: 0x04009633 RID: 38451
		private int weaponMaxCount_;

		// Token: 0x04009634 RID: 38452
		public const int UnlockWeaponWaveFieldNumber = 15;

		// Token: 0x04009635 RID: 38453
		private static readonly FieldCodec<int> _repeated_unlockWeaponWave_codec = FieldCodec.ForInt32(122U);

		// Token: 0x04009636 RID: 38454
		private readonly RepeatedField<int> unlockWeaponWave_ = new RepeatedField<int>();

		// Token: 0x04009637 RID: 38455
		public const int ComboParamInfosFieldNumber = 1;

		// Token: 0x04009638 RID: 38456
		private static readonly FieldCodec<ComboParamInfo> _repeated_comboParamInfos_codec = FieldCodec.ForMessage<ComboParamInfo>(10U, ComboParamInfo.Parser);

		// Token: 0x04009639 RID: 38457
		private readonly RepeatedField<ComboParamInfo> comboParamInfos_ = new RepeatedField<ComboParamInfo>();
	}
}
