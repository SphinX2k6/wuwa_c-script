using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C46 RID: 3142
	public sealed class PhantomBattleCardFighterInfoCtx : IMessage<PhantomBattleCardFighterInfoCtx>, IMessage, IEquatable<PhantomBattleCardFighterInfoCtx>, IDeepCloneable<PhantomBattleCardFighterInfoCtx>, IBufferMessage
	{
		// Token: 0x0601109B RID: 69787 RVA: 0x0027E88B File Offset: 0x0027CA8B
		[NullableContext(1)]
		public static PhantomBattleCardFighterInfoCtx Create()
		{
			return new PhantomBattleCardFighterInfoCtx();
		}

		// Token: 0x17003849 RID: 14409
		// (get) Token: 0x0601109C RID: 69788 RVA: 0x0027E892 File Offset: 0x0027CA92
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700384A RID: 14410
		// (get) Token: 0x0601109D RID: 69789 RVA: 0x0027E895 File Offset: 0x0027CA95
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleCardFighterInfoCtx.Descriptor;
			}
		}

		// Token: 0x0601109E RID: 69790 RVA: 0x0027E89C File Offset: 0x0027CA9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleCardFighterInfoCtx()
		{
		}

		// Token: 0x0601109F RID: 69791 RVA: 0x0027E8C8 File Offset: 0x0027CAC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleCardFighterInfoCtx(PhantomBattleCardFighterInfoCtx other) : this()
		{
			this.cardUid_ = other.cardUid_;
			this.cardConfId_ = other.cardConfId_;
			this.gamerIndex_ = other.gamerIndex_;
			this.slotIndex_ = other.slotIndex_;
			this.attrs_ = other.attrs_.Clone();
			this.evolveCount_ = other.evolveCount_;
			this.factors_ = other.factors_.Clone();
			this.canUnlimitedEvolve_ = other.canUnlimitedEvolve_;
			this.isCopy_ = other.isCopy_;
			this.skillUnlockInfo_ = ((other.skillUnlockInfo_ != null) ? other.skillUnlockInfo_.Clone() : null);
			this.lockFactors_ = other.lockFactors_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060110A0 RID: 69792 RVA: 0x0027E98F File Offset: 0x0027CB8F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleCardFighterInfoCtx Clone()
		{
			return new PhantomBattleCardFighterInfoCtx(this);
		}

		// Token: 0x1700384B RID: 14411
		// (get) Token: 0x060110A1 RID: 69793 RVA: 0x0027E997 File Offset: 0x0027CB97
		// (set) Token: 0x060110A2 RID: 69794 RVA: 0x0027E99F File Offset: 0x0027CB9F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CardUid
		{
			get
			{
				return this.cardUid_;
			}
			set
			{
				this.cardUid_ = value;
			}
		}

		// Token: 0x1700384C RID: 14412
		// (get) Token: 0x060110A3 RID: 69795 RVA: 0x0027E9A8 File Offset: 0x0027CBA8
		// (set) Token: 0x060110A4 RID: 69796 RVA: 0x0027E9B0 File Offset: 0x0027CBB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CardConfId
		{
			get
			{
				return this.cardConfId_;
			}
			set
			{
				this.cardConfId_ = value;
			}
		}

		// Token: 0x1700384D RID: 14413
		// (get) Token: 0x060110A5 RID: 69797 RVA: 0x0027E9B9 File Offset: 0x0027CBB9
		// (set) Token: 0x060110A6 RID: 69798 RVA: 0x0027E9C1 File Offset: 0x0027CBC1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int GamerIndex
		{
			get
			{
				return this.gamerIndex_;
			}
			set
			{
				this.gamerIndex_ = value;
			}
		}

		// Token: 0x1700384E RID: 14414
		// (get) Token: 0x060110A7 RID: 69799 RVA: 0x0027E9CA File Offset: 0x0027CBCA
		// (set) Token: 0x060110A8 RID: 69800 RVA: 0x0027E9D2 File Offset: 0x0027CBD2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SlotIndex
		{
			get
			{
				return this.slotIndex_;
			}
			set
			{
				this.slotIndex_ = value;
			}
		}

		// Token: 0x1700384F RID: 14415
		// (get) Token: 0x060110A9 RID: 69801 RVA: 0x0027E9DB File Offset: 0x0027CBDB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, int> Attrs
		{
			get
			{
				return this.attrs_;
			}
		}

		// Token: 0x17003850 RID: 14416
		// (get) Token: 0x060110AA RID: 69802 RVA: 0x0027E9E3 File Offset: 0x0027CBE3
		// (set) Token: 0x060110AB RID: 69803 RVA: 0x0027E9EB File Offset: 0x0027CBEB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int EvolveCount
		{
			get
			{
				return this.evolveCount_;
			}
			set
			{
				this.evolveCount_ = value;
			}
		}

		// Token: 0x17003851 RID: 14417
		// (get) Token: 0x060110AC RID: 69804 RVA: 0x0027E9F4 File Offset: 0x0027CBF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> Factors
		{
			get
			{
				return this.factors_;
			}
		}

		// Token: 0x17003852 RID: 14418
		// (get) Token: 0x060110AD RID: 69805 RVA: 0x0027E9FC File Offset: 0x0027CBFC
		// (set) Token: 0x060110AE RID: 69806 RVA: 0x0027EA04 File Offset: 0x0027CC04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool CanUnlimitedEvolve
		{
			get
			{
				return this.canUnlimitedEvolve_;
			}
			set
			{
				this.canUnlimitedEvolve_ = value;
			}
		}

		// Token: 0x17003853 RID: 14419
		// (get) Token: 0x060110AF RID: 69807 RVA: 0x0027EA0D File Offset: 0x0027CC0D
		// (set) Token: 0x060110B0 RID: 69808 RVA: 0x0027EA15 File Offset: 0x0027CC15
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsCopy
		{
			get
			{
				return this.isCopy_;
			}
			set
			{
				this.isCopy_ = value;
			}
		}

		// Token: 0x17003854 RID: 14420
		// (get) Token: 0x060110B1 RID: 69809 RVA: 0x0027EA1E File Offset: 0x0027CC1E
		// (set) Token: 0x060110B2 RID: 69810 RVA: 0x0027EA26 File Offset: 0x0027CC26
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleCardSkillUnlockInfo SkillUnlockInfo
		{
			get
			{
				return this.skillUnlockInfo_;
			}
			set
			{
				this.skillUnlockInfo_ = value;
			}
		}

		// Token: 0x17003855 RID: 14421
		// (get) Token: 0x060110B3 RID: 69811 RVA: 0x0027EA2F File Offset: 0x0027CC2F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> LockFactors
		{
			get
			{
				return this.lockFactors_;
			}
		}

		// Token: 0x060110B4 RID: 69812 RVA: 0x0027EA37 File Offset: 0x0027CC37
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleCardFighterInfoCtx);
		}

		// Token: 0x060110B5 RID: 69813 RVA: 0x0027EA48 File Offset: 0x0027CC48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleCardFighterInfoCtx other)
		{
			return other != null && (other == this || (this.CardUid == other.CardUid && this.CardConfId == other.CardConfId && this.GamerIndex == other.GamerIndex && this.SlotIndex == other.SlotIndex && this.Attrs.Equals(other.Attrs) && this.EvolveCount == other.EvolveCount && this.factors_.Equals(other.factors_) && this.CanUnlimitedEvolve == other.CanUnlimitedEvolve && this.IsCopy == other.IsCopy && object.Equals(this.SkillUnlockInfo, other.SkillUnlockInfo) && this.lockFactors_.Equals(other.lockFactors_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060110B6 RID: 69814 RVA: 0x0027EB38 File Offset: 0x0027CD38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.CardUid != 0)
			{
				num ^= this.CardUid.GetHashCode();
			}
			if (this.CardConfId != 0)
			{
				num ^= this.CardConfId.GetHashCode();
			}
			if (this.GamerIndex != 0)
			{
				num ^= this.GamerIndex.GetHashCode();
			}
			if (this.SlotIndex != 0)
			{
				num ^= this.SlotIndex.GetHashCode();
			}
			num ^= this.Attrs.GetHashCode();
			if (this.EvolveCount != 0)
			{
				num ^= this.EvolveCount.GetHashCode();
			}
			num ^= this.factors_.GetHashCode();
			if (this.CanUnlimitedEvolve)
			{
				num ^= this.CanUnlimitedEvolve.GetHashCode();
			}
			if (this.IsCopy)
			{
				num ^= this.IsCopy.GetHashCode();
			}
			if (this.skillUnlockInfo_ != null)
			{
				num ^= this.SkillUnlockInfo.GetHashCode();
			}
			num ^= this.lockFactors_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060110B7 RID: 69815 RVA: 0x0027EC4D File Offset: 0x0027CE4D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060110B8 RID: 69816 RVA: 0x0027EC5A File Offset: 0x0027CE5A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060110B9 RID: 69817 RVA: 0x0027EC64 File Offset: 0x0027CE64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.CardUid != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.CardUid);
			}
			if (this.CardConfId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.CardConfId);
			}
			if (this.GamerIndex != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.GamerIndex);
			}
			if (this.SlotIndex != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.SlotIndex);
			}
			this.attrs_.WriteTo(ref output, PhantomBattleCardFighterInfoCtx._map_attrs_codec);
			if (this.EvolveCount != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.EvolveCount);
			}
			this.factors_.WriteTo(ref output, PhantomBattleCardFighterInfoCtx._repeated_factors_codec);
			if (this.CanUnlimitedEvolve)
			{
				output.WriteRawTag(64);
				output.WriteBool(this.CanUnlimitedEvolve);
			}
			if (this.IsCopy)
			{
				output.WriteRawTag(72);
				output.WriteBool(this.IsCopy);
			}
			if (this.skillUnlockInfo_ != null)
			{
				output.WriteRawTag(82);
				output.WriteMessage(this.SkillUnlockInfo);
			}
			this.lockFactors_.WriteTo(ref output, PhantomBattleCardFighterInfoCtx._repeated_lockFactors_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060110BA RID: 69818 RVA: 0x0027ED98 File Offset: 0x0027CF98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.CardUid != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CardUid);
			}
			if (this.CardConfId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CardConfId);
			}
			if (this.GamerIndex != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.GamerIndex);
			}
			if (this.SlotIndex != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SlotIndex);
			}
			num += this.attrs_.CalculateSize(PhantomBattleCardFighterInfoCtx._map_attrs_codec);
			if (this.EvolveCount != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.EvolveCount);
			}
			num += this.factors_.CalculateSize(PhantomBattleCardFighterInfoCtx._repeated_factors_codec);
			if (this.CanUnlimitedEvolve)
			{
				num += 2;
			}
			if (this.IsCopy)
			{
				num += 2;
			}
			if (this.skillUnlockInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.SkillUnlockInfo);
			}
			num += this.lockFactors_.CalculateSize(PhantomBattleCardFighterInfoCtx._repeated_lockFactors_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060110BB RID: 69819 RVA: 0x0027EEA0 File Offset: 0x0027D0A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomBattleCardFighterInfoCtx other)
		{
			if (other == null)
			{
				return;
			}
			if (other.CardUid != 0)
			{
				this.CardUid = other.CardUid;
			}
			if (other.CardConfId != 0)
			{
				this.CardConfId = other.CardConfId;
			}
			if (other.GamerIndex != 0)
			{
				this.GamerIndex = other.GamerIndex;
			}
			if (other.SlotIndex != 0)
			{
				this.SlotIndex = other.SlotIndex;
			}
			this.attrs_.MergeFrom(other.attrs_);
			if (other.EvolveCount != 0)
			{
				this.EvolveCount = other.EvolveCount;
			}
			this.factors_.Add(other.factors_);
			if (other.CanUnlimitedEvolve)
			{
				this.CanUnlimitedEvolve = other.CanUnlimitedEvolve;
			}
			if (other.IsCopy)
			{
				this.IsCopy = other.IsCopy;
			}
			if (other.skillUnlockInfo_ != null)
			{
				if (this.skillUnlockInfo_ == null)
				{
					this.SkillUnlockInfo = new PhantomBattleCardSkillUnlockInfo();
				}
				this.SkillUnlockInfo.MergeFrom(other.SkillUnlockInfo);
			}
			this.lockFactors_.Add(other.lockFactors_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060110BC RID: 69820 RVA: 0x0027EFB3 File Offset: 0x0027D1B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060110BD RID: 69821 RVA: 0x0027EFBC File Offset: 0x0027D1BC
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
				if (num <= 48U)
				{
					if (num <= 24U)
					{
						if (num == 8U)
						{
							this.CardUid = input.ReadInt32();
							continue;
						}
						if (num == 16U)
						{
							this.CardConfId = input.ReadInt32();
							continue;
						}
						if (num == 24U)
						{
							this.GamerIndex = input.ReadInt32();
							continue;
						}
					}
					else
					{
						if (num == 32U)
						{
							this.SlotIndex = input.ReadInt32();
							continue;
						}
						if (num == 42U)
						{
							this.attrs_.AddEntriesFrom(ref input, PhantomBattleCardFighterInfoCtx._map_attrs_codec);
							continue;
						}
						if (num == 48U)
						{
							this.EvolveCount = input.ReadInt32();
							continue;
						}
					}
				}
				else if (num <= 64U)
				{
					if (num == 56U || num == 58U)
					{
						this.factors_.AddEntriesFrom(ref input, PhantomBattleCardFighterInfoCtx._repeated_factors_codec);
						continue;
					}
					if (num == 64U)
					{
						this.CanUnlimitedEvolve = input.ReadBool();
						continue;
					}
				}
				else if (num <= 82U)
				{
					if (num == 72U)
					{
						this.IsCopy = input.ReadBool();
						continue;
					}
					if (num == 82U)
					{
						if (this.skillUnlockInfo_ == null)
						{
							this.SkillUnlockInfo = new PhantomBattleCardSkillUnlockInfo();
						}
						input.ReadMessage(this.SkillUnlockInfo);
						continue;
					}
				}
				else if (num == 88U || num == 90U)
				{
					this.lockFactors_.AddEntriesFrom(ref input, PhantomBattleCardFighterInfoCtx._repeated_lockFactors_codec);
					continue;
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04006BF1 RID: 27633
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006BF2 RID: 27634
		public const int CardUidFieldNumber = 1;

		// Token: 0x04006BF3 RID: 27635
		private int cardUid_;

		// Token: 0x04006BF4 RID: 27636
		public const int CardConfIdFieldNumber = 2;

		// Token: 0x04006BF5 RID: 27637
		private int cardConfId_;

		// Token: 0x04006BF6 RID: 27638
		public const int GamerIndexFieldNumber = 3;

		// Token: 0x04006BF7 RID: 27639
		private int gamerIndex_;

		// Token: 0x04006BF8 RID: 27640
		public const int SlotIndexFieldNumber = 4;

		// Token: 0x04006BF9 RID: 27641
		private int slotIndex_;

		// Token: 0x04006BFA RID: 27642
		public const int AttrsFieldNumber = 5;

		// Token: 0x04006BFB RID: 27643
		private static readonly MapField<int, int>.Codec _map_attrs_codec = new MapField<int, int>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForInt32(16U, 0), 42U);

		// Token: 0x04006BFC RID: 27644
		private readonly MapField<int, int> attrs_ = new MapField<int, int>();

		// Token: 0x04006BFD RID: 27645
		public const int EvolveCountFieldNumber = 6;

		// Token: 0x04006BFE RID: 27646
		private int evolveCount_;

		// Token: 0x04006BFF RID: 27647
		public const int FactorsFieldNumber = 7;

		// Token: 0x04006C00 RID: 27648
		private static readonly FieldCodec<int> _repeated_factors_codec = FieldCodec.ForInt32(58U);

		// Token: 0x04006C01 RID: 27649
		private readonly RepeatedField<int> factors_ = new RepeatedField<int>();

		// Token: 0x04006C02 RID: 27650
		public const int CanUnlimitedEvolveFieldNumber = 8;

		// Token: 0x04006C03 RID: 27651
		private bool canUnlimitedEvolve_;

		// Token: 0x04006C04 RID: 27652
		public const int IsCopyFieldNumber = 9;

		// Token: 0x04006C05 RID: 27653
		private bool isCopy_;

		// Token: 0x04006C06 RID: 27654
		public const int SkillUnlockInfoFieldNumber = 10;

		// Token: 0x04006C07 RID: 27655
		private PhantomBattleCardSkillUnlockInfo skillUnlockInfo_;

		// Token: 0x04006C08 RID: 27656
		public const int LockFactorsFieldNumber = 11;

		// Token: 0x04006C09 RID: 27657
		private static readonly FieldCodec<int> _repeated_lockFactors_codec = FieldCodec.ForInt32(90U);

		// Token: 0x04006C0A RID: 27658
		private readonly RepeatedField<int> lockFactors_ = new RepeatedField<int>();
	}
}
