using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D3F RID: 3391
	public sealed class PinballInProgressPb : IMessage<PinballInProgressPb>, IMessage, IEquatable<PinballInProgressPb>, IDeepCloneable<PinballInProgressPb>, IBufferMessage
	{
		// Token: 0x0601250B RID: 75019 RVA: 0x002AC971 File Offset: 0x002AAB71
		[NullableContext(1)]
		public static PinballInProgressPb Create()
		{
			return new PinballInProgressPb();
		}

		// Token: 0x17003CAD RID: 15533
		// (get) Token: 0x0601250C RID: 75020 RVA: 0x002AC978 File Offset: 0x002AAB78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003CAE RID: 15534
		// (get) Token: 0x0601250D RID: 75021 RVA: 0x002AC97B File Offset: 0x002AAB7B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PinballInProgressPb.Descriptor;
			}
		}

		// Token: 0x0601250E RID: 75022 RVA: 0x002AC982 File Offset: 0x002AAB82
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballInProgressPb()
		{
		}

		// Token: 0x0601250F RID: 75023 RVA: 0x002AC9B8 File Offset: 0x002AABB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballInProgressPb(PinballInProgressPb other) : this()
		{
			this.levelId_ = other.levelId_;
			this.reviveTimesCost_ = other.reviveTimesCost_;
			this.maxReviveTimes_ = other.maxReviveTimes_;
			this.pinballFormation_ = other.pinballFormation_.Clone();
			this.starInfo_ = other.starInfo_.Clone();
			this.monsterAttrRate_ = other.monsterAttrRate_.Clone();
			this.allyKscBuffIds_ = other.allyKscBuffIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06012510 RID: 75024 RVA: 0x002ACA44 File Offset: 0x002AAC44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballInProgressPb Clone()
		{
			return new PinballInProgressPb(this);
		}

		// Token: 0x17003CAF RID: 15535
		// (get) Token: 0x06012511 RID: 75025 RVA: 0x002ACA4C File Offset: 0x002AAC4C
		// (set) Token: 0x06012512 RID: 75026 RVA: 0x002ACA54 File Offset: 0x002AAC54
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

		// Token: 0x17003CB0 RID: 15536
		// (get) Token: 0x06012513 RID: 75027 RVA: 0x002ACA5D File Offset: 0x002AAC5D
		// (set) Token: 0x06012514 RID: 75028 RVA: 0x002ACA65 File Offset: 0x002AAC65
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ReviveTimesCost
		{
			get
			{
				return this.reviveTimesCost_;
			}
			set
			{
				this.reviveTimesCost_ = value;
			}
		}

		// Token: 0x17003CB1 RID: 15537
		// (get) Token: 0x06012515 RID: 75029 RVA: 0x002ACA6E File Offset: 0x002AAC6E
		// (set) Token: 0x06012516 RID: 75030 RVA: 0x002ACA76 File Offset: 0x002AAC76
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int MaxReviveTimes
		{
			get
			{
				return this.maxReviveTimes_;
			}
			set
			{
				this.maxReviveTimes_ = value;
			}
		}

		// Token: 0x17003CB2 RID: 15538
		// (get) Token: 0x06012517 RID: 75031 RVA: 0x002ACA7F File Offset: 0x002AAC7F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PinballFormationRolePb> PinballFormation
		{
			get
			{
				return this.pinballFormation_;
			}
		}

		// Token: 0x17003CB3 RID: 15539
		// (get) Token: 0x06012518 RID: 75032 RVA: 0x002ACA87 File Offset: 0x002AAC87
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> StarInfo
		{
			get
			{
				return this.starInfo_;
			}
		}

		// Token: 0x17003CB4 RID: 15540
		// (get) Token: 0x06012519 RID: 75033 RVA: 0x002ACA8F File Offset: 0x002AAC8F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> MonsterAttrRate
		{
			get
			{
				return this.monsterAttrRate_;
			}
		}

		// Token: 0x17003CB5 RID: 15541
		// (get) Token: 0x0601251A RID: 75034 RVA: 0x002ACA97 File Offset: 0x002AAC97
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> AllyKscBuffIds
		{
			get
			{
				return this.allyKscBuffIds_;
			}
		}

		// Token: 0x0601251B RID: 75035 RVA: 0x002ACA9F File Offset: 0x002AAC9F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PinballInProgressPb);
		}

		// Token: 0x0601251C RID: 75036 RVA: 0x002ACAB0 File Offset: 0x002AACB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PinballInProgressPb other)
		{
			return other != null && (other == this || (this.LevelId == other.LevelId && this.ReviveTimesCost == other.ReviveTimesCost && this.MaxReviveTimes == other.MaxReviveTimes && this.pinballFormation_.Equals(other.pinballFormation_) && this.starInfo_.Equals(other.starInfo_) && this.monsterAttrRate_.Equals(other.monsterAttrRate_) && this.allyKscBuffIds_.Equals(other.allyKscBuffIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601251D RID: 75037 RVA: 0x002ACB60 File Offset: 0x002AAD60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.LevelId != 0)
			{
				num ^= this.LevelId.GetHashCode();
			}
			if (this.ReviveTimesCost != 0)
			{
				num ^= this.ReviveTimesCost.GetHashCode();
			}
			if (this.MaxReviveTimes != 0)
			{
				num ^= this.MaxReviveTimes.GetHashCode();
			}
			num ^= this.pinballFormation_.GetHashCode();
			num ^= this.starInfo_.GetHashCode();
			num ^= this.monsterAttrRate_.GetHashCode();
			num ^= this.allyKscBuffIds_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601251E RID: 75038 RVA: 0x002ACC09 File Offset: 0x002AAE09
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601251F RID: 75039 RVA: 0x002ACC16 File Offset: 0x002AAE16
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06012520 RID: 75040 RVA: 0x002ACC20 File Offset: 0x002AAE20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.LevelId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.LevelId);
			}
			if (this.ReviveTimesCost != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.ReviveTimesCost);
			}
			if (this.MaxReviveTimes != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.MaxReviveTimes);
			}
			this.pinballFormation_.WriteTo(ref output, PinballInProgressPb._repeated_pinballFormation_codec);
			this.starInfo_.WriteTo(ref output, PinballInProgressPb._repeated_starInfo_codec);
			this.monsterAttrRate_.WriteTo(ref output, PinballInProgressPb._repeated_monsterAttrRate_codec);
			this.allyKscBuffIds_.WriteTo(ref output, PinballInProgressPb._repeated_allyKscBuffIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06012521 RID: 75041 RVA: 0x002ACCD8 File Offset: 0x002AAED8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.LevelId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.LevelId);
			}
			if (this.ReviveTimesCost != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ReviveTimesCost);
			}
			if (this.MaxReviveTimes != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.MaxReviveTimes);
			}
			num += this.pinballFormation_.CalculateSize(PinballInProgressPb._repeated_pinballFormation_codec);
			num += this.starInfo_.CalculateSize(PinballInProgressPb._repeated_starInfo_codec);
			num += this.monsterAttrRate_.CalculateSize(PinballInProgressPb._repeated_monsterAttrRate_codec);
			num += this.allyKscBuffIds_.CalculateSize(PinballInProgressPb._repeated_allyKscBuffIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06012522 RID: 75042 RVA: 0x002ACD94 File Offset: 0x002AAF94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PinballInProgressPb other)
		{
			if (other == null)
			{
				return;
			}
			if (other.LevelId != 0)
			{
				this.LevelId = other.LevelId;
			}
			if (other.ReviveTimesCost != 0)
			{
				this.ReviveTimesCost = other.ReviveTimesCost;
			}
			if (other.MaxReviveTimes != 0)
			{
				this.MaxReviveTimes = other.MaxReviveTimes;
			}
			this.pinballFormation_.Add(other.pinballFormation_);
			this.starInfo_.Add(other.starInfo_);
			this.monsterAttrRate_.Add(other.monsterAttrRate_);
			this.allyKscBuffIds_.Add(other.allyKscBuffIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06012523 RID: 75043 RVA: 0x002ACE3C File Offset: 0x002AB03C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06012524 RID: 75044 RVA: 0x002ACE48 File Offset: 0x002AB048
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
				if (num > 40U)
				{
					if (num <= 48U)
					{
						if (num == 42U)
						{
							goto IL_A3;
						}
						if (num != 48U)
						{
							goto IL_52;
						}
					}
					else if (num != 50U)
					{
						if (num != 56U && num != 58U)
						{
							goto IL_52;
						}
						this.allyKscBuffIds_.AddEntriesFrom(ref input, PinballInProgressPb._repeated_allyKscBuffIds_codec);
						continue;
					}
					this.monsterAttrRate_.AddEntriesFrom(ref input, PinballInProgressPb._repeated_monsterAttrRate_codec);
					continue;
				}
				if (num <= 16U)
				{
					if (num == 8U)
					{
						this.LevelId = input.ReadInt32();
						continue;
					}
					if (num == 16U)
					{
						this.ReviveTimesCost = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 24U)
					{
						this.MaxReviveTimes = input.ReadInt32();
						continue;
					}
					if (num == 34U)
					{
						this.pinballFormation_.AddEntriesFrom(ref input, PinballInProgressPb._repeated_pinballFormation_codec);
						continue;
					}
					if (num == 40U)
					{
						goto IL_A3;
					}
				}
				IL_52:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				continue;
				IL_A3:
				this.starInfo_.AddEntriesFrom(ref input, PinballInProgressPb._repeated_starInfo_codec);
			}
		}

		// Token: 0x04007282 RID: 29314
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007283 RID: 29315
		public const int LevelIdFieldNumber = 1;

		// Token: 0x04007284 RID: 29316
		private int levelId_;

		// Token: 0x04007285 RID: 29317
		public const int ReviveTimesCostFieldNumber = 2;

		// Token: 0x04007286 RID: 29318
		private int reviveTimesCost_;

		// Token: 0x04007287 RID: 29319
		public const int MaxReviveTimesFieldNumber = 3;

		// Token: 0x04007288 RID: 29320
		private int maxReviveTimes_;

		// Token: 0x04007289 RID: 29321
		public const int PinballFormationFieldNumber = 4;

		// Token: 0x0400728A RID: 29322
		private static readonly FieldCodec<PinballFormationRolePb> _repeated_pinballFormation_codec = FieldCodec.ForMessage<PinballFormationRolePb>(34U, PinballFormationRolePb.Parser);

		// Token: 0x0400728B RID: 29323
		private readonly RepeatedField<PinballFormationRolePb> pinballFormation_ = new RepeatedField<PinballFormationRolePb>();

		// Token: 0x0400728C RID: 29324
		public const int StarInfoFieldNumber = 5;

		// Token: 0x0400728D RID: 29325
		private static readonly FieldCodec<int> _repeated_starInfo_codec = FieldCodec.ForInt32(42U);

		// Token: 0x0400728E RID: 29326
		private readonly RepeatedField<int> starInfo_ = new RepeatedField<int>();

		// Token: 0x0400728F RID: 29327
		public const int MonsterAttrRateFieldNumber = 6;

		// Token: 0x04007290 RID: 29328
		private static readonly FieldCodec<int> _repeated_monsterAttrRate_codec = FieldCodec.ForInt32(50U);

		// Token: 0x04007291 RID: 29329
		private readonly RepeatedField<int> monsterAttrRate_ = new RepeatedField<int>();

		// Token: 0x04007292 RID: 29330
		public const int AllyKscBuffIdsFieldNumber = 7;

		// Token: 0x04007293 RID: 29331
		private static readonly FieldCodec<int> _repeated_allyKscBuffIds_codec = FieldCodec.ForInt32(58U);

		// Token: 0x04007294 RID: 29332
		private readonly RepeatedField<int> allyKscBuffIds_ = new RepeatedField<int>();
	}
}
