using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D4F RID: 3407
	public sealed class PinballInProgressPb : IMessage<PinballInProgressPb>, IMessage, IEquatable<PinballInProgressPb>, IDeepCloneable<PinballInProgressPb>, IBufferMessage
	{
		// Token: 0x06012607 RID: 75271 RVA: 0x002AE591 File Offset: 0x002AC791
		[NullableContext(1)]
		public static PinballInProgressPb Create()
		{
			return new PinballInProgressPb();
		}

		// Token: 0x17003CE2 RID: 15586
		// (get) Token: 0x06012608 RID: 75272 RVA: 0x002AE598 File Offset: 0x002AC798
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003CE3 RID: 15587
		// (get) Token: 0x06012609 RID: 75273 RVA: 0x002AE59B File Offset: 0x002AC79B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PinballInProgressPb.Descriptor;
			}
		}

		// Token: 0x0601260A RID: 75274 RVA: 0x002AE5A2 File Offset: 0x002AC7A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballInProgressPb()
		{
		}

		// Token: 0x0601260B RID: 75275 RVA: 0x002AE5D8 File Offset: 0x002AC7D8
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

		// Token: 0x0601260C RID: 75276 RVA: 0x002AE664 File Offset: 0x002AC864
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballInProgressPb Clone()
		{
			return new PinballInProgressPb(this);
		}

		// Token: 0x17003CE4 RID: 15588
		// (get) Token: 0x0601260D RID: 75277 RVA: 0x002AE66C File Offset: 0x002AC86C
		// (set) Token: 0x0601260E RID: 75278 RVA: 0x002AE674 File Offset: 0x002AC874
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

		// Token: 0x17003CE5 RID: 15589
		// (get) Token: 0x0601260F RID: 75279 RVA: 0x002AE67D File Offset: 0x002AC87D
		// (set) Token: 0x06012610 RID: 75280 RVA: 0x002AE685 File Offset: 0x002AC885
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

		// Token: 0x17003CE6 RID: 15590
		// (get) Token: 0x06012611 RID: 75281 RVA: 0x002AE68E File Offset: 0x002AC88E
		// (set) Token: 0x06012612 RID: 75282 RVA: 0x002AE696 File Offset: 0x002AC896
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

		// Token: 0x17003CE7 RID: 15591
		// (get) Token: 0x06012613 RID: 75283 RVA: 0x002AE69F File Offset: 0x002AC89F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PinballFormationRolePb> PinballFormation
		{
			get
			{
				return this.pinballFormation_;
			}
		}

		// Token: 0x17003CE8 RID: 15592
		// (get) Token: 0x06012614 RID: 75284 RVA: 0x002AE6A7 File Offset: 0x002AC8A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> StarInfo
		{
			get
			{
				return this.starInfo_;
			}
		}

		// Token: 0x17003CE9 RID: 15593
		// (get) Token: 0x06012615 RID: 75285 RVA: 0x002AE6AF File Offset: 0x002AC8AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> MonsterAttrRate
		{
			get
			{
				return this.monsterAttrRate_;
			}
		}

		// Token: 0x17003CEA RID: 15594
		// (get) Token: 0x06012616 RID: 75286 RVA: 0x002AE6B7 File Offset: 0x002AC8B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> AllyKscBuffIds
		{
			get
			{
				return this.allyKscBuffIds_;
			}
		}

		// Token: 0x06012617 RID: 75287 RVA: 0x002AE6BF File Offset: 0x002AC8BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PinballInProgressPb);
		}

		// Token: 0x06012618 RID: 75288 RVA: 0x002AE6D0 File Offset: 0x002AC8D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PinballInProgressPb other)
		{
			return other != null && (other == this || (this.LevelId == other.LevelId && this.ReviveTimesCost == other.ReviveTimesCost && this.MaxReviveTimes == other.MaxReviveTimes && this.pinballFormation_.Equals(other.pinballFormation_) && this.starInfo_.Equals(other.starInfo_) && this.monsterAttrRate_.Equals(other.monsterAttrRate_) && this.allyKscBuffIds_.Equals(other.allyKscBuffIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06012619 RID: 75289 RVA: 0x002AE780 File Offset: 0x002AC980
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

		// Token: 0x0601261A RID: 75290 RVA: 0x002AE829 File Offset: 0x002ACA29
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601261B RID: 75291 RVA: 0x002AE836 File Offset: 0x002ACA36
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601261C RID: 75292 RVA: 0x002AE840 File Offset: 0x002ACA40
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

		// Token: 0x0601261D RID: 75293 RVA: 0x002AE8F8 File Offset: 0x002ACAF8
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

		// Token: 0x0601261E RID: 75294 RVA: 0x002AE9B4 File Offset: 0x002ACBB4
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

		// Token: 0x0601261F RID: 75295 RVA: 0x002AEA5C File Offset: 0x002ACC5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06012620 RID: 75296 RVA: 0x002AEA68 File Offset: 0x002ACC68
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

		// Token: 0x0400726A RID: 29290
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400726B RID: 29291
		public const int LevelIdFieldNumber = 1;

		// Token: 0x0400726C RID: 29292
		private int levelId_;

		// Token: 0x0400726D RID: 29293
		public const int ReviveTimesCostFieldNumber = 2;

		// Token: 0x0400726E RID: 29294
		private int reviveTimesCost_;

		// Token: 0x0400726F RID: 29295
		public const int MaxReviveTimesFieldNumber = 3;

		// Token: 0x04007270 RID: 29296
		private int maxReviveTimes_;

		// Token: 0x04007271 RID: 29297
		public const int PinballFormationFieldNumber = 4;

		// Token: 0x04007272 RID: 29298
		private static readonly FieldCodec<PinballFormationRolePb> _repeated_pinballFormation_codec = FieldCodec.ForMessage<PinballFormationRolePb>(34U, PinballFormationRolePb.Parser);

		// Token: 0x04007273 RID: 29299
		private readonly RepeatedField<PinballFormationRolePb> pinballFormation_ = new RepeatedField<PinballFormationRolePb>();

		// Token: 0x04007274 RID: 29300
		public const int StarInfoFieldNumber = 5;

		// Token: 0x04007275 RID: 29301
		private static readonly FieldCodec<int> _repeated_starInfo_codec = FieldCodec.ForInt32(42U);

		// Token: 0x04007276 RID: 29302
		private readonly RepeatedField<int> starInfo_ = new RepeatedField<int>();

		// Token: 0x04007277 RID: 29303
		public const int MonsterAttrRateFieldNumber = 6;

		// Token: 0x04007278 RID: 29304
		private static readonly FieldCodec<int> _repeated_monsterAttrRate_codec = FieldCodec.ForInt32(50U);

		// Token: 0x04007279 RID: 29305
		private readonly RepeatedField<int> monsterAttrRate_ = new RepeatedField<int>();

		// Token: 0x0400727A RID: 29306
		public const int AllyKscBuffIdsFieldNumber = 7;

		// Token: 0x0400727B RID: 29307
		private static readonly FieldCodec<int> _repeated_allyKscBuffIds_codec = FieldCodec.ForInt32(58U);

		// Token: 0x0400727C RID: 29308
		private readonly RepeatedField<int> allyKscBuffIds_ = new RepeatedField<int>();
	}
}
