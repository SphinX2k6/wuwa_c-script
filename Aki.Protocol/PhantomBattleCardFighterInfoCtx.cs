using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C36 RID: 3126
	public sealed class PhantomBattleCardFighterInfoCtx : IMessage<PhantomBattleCardFighterInfoCtx>, IMessage, IEquatable<PhantomBattleCardFighterInfoCtx>, IDeepCloneable<PhantomBattleCardFighterInfoCtx>, IBufferMessage
	{
		// Token: 0x06010F9B RID: 69531 RVA: 0x0027CB23 File Offset: 0x0027AD23
		[NullableContext(1)]
		public static PhantomBattleCardFighterInfoCtx Create()
		{
			return new PhantomBattleCardFighterInfoCtx();
		}

		// Token: 0x17003812 RID: 14354
		// (get) Token: 0x06010F9C RID: 69532 RVA: 0x0027CB2A File Offset: 0x0027AD2A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003813 RID: 14355
		// (get) Token: 0x06010F9D RID: 69533 RVA: 0x0027CB2D File Offset: 0x0027AD2D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleCardFighterInfoCtx.Descriptor;
			}
		}

		// Token: 0x06010F9E RID: 69534 RVA: 0x0027CB34 File Offset: 0x0027AD34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleCardFighterInfoCtx()
		{
		}

		// Token: 0x06010F9F RID: 69535 RVA: 0x0027CB60 File Offset: 0x0027AD60
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

		// Token: 0x06010FA0 RID: 69536 RVA: 0x0027CC27 File Offset: 0x0027AE27
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleCardFighterInfoCtx Clone()
		{
			return new PhantomBattleCardFighterInfoCtx(this);
		}

		// Token: 0x17003814 RID: 14356
		// (get) Token: 0x06010FA1 RID: 69537 RVA: 0x0027CC2F File Offset: 0x0027AE2F
		// (set) Token: 0x06010FA2 RID: 69538 RVA: 0x0027CC37 File Offset: 0x0027AE37
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

		// Token: 0x17003815 RID: 14357
		// (get) Token: 0x06010FA3 RID: 69539 RVA: 0x0027CC40 File Offset: 0x0027AE40
		// (set) Token: 0x06010FA4 RID: 69540 RVA: 0x0027CC48 File Offset: 0x0027AE48
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

		// Token: 0x17003816 RID: 14358
		// (get) Token: 0x06010FA5 RID: 69541 RVA: 0x0027CC51 File Offset: 0x0027AE51
		// (set) Token: 0x06010FA6 RID: 69542 RVA: 0x0027CC59 File Offset: 0x0027AE59
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

		// Token: 0x17003817 RID: 14359
		// (get) Token: 0x06010FA7 RID: 69543 RVA: 0x0027CC62 File Offset: 0x0027AE62
		// (set) Token: 0x06010FA8 RID: 69544 RVA: 0x0027CC6A File Offset: 0x0027AE6A
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

		// Token: 0x17003818 RID: 14360
		// (get) Token: 0x06010FA9 RID: 69545 RVA: 0x0027CC73 File Offset: 0x0027AE73
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, int> Attrs
		{
			get
			{
				return this.attrs_;
			}
		}

		// Token: 0x17003819 RID: 14361
		// (get) Token: 0x06010FAA RID: 69546 RVA: 0x0027CC7B File Offset: 0x0027AE7B
		// (set) Token: 0x06010FAB RID: 69547 RVA: 0x0027CC83 File Offset: 0x0027AE83
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

		// Token: 0x1700381A RID: 14362
		// (get) Token: 0x06010FAC RID: 69548 RVA: 0x0027CC8C File Offset: 0x0027AE8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> Factors
		{
			get
			{
				return this.factors_;
			}
		}

		// Token: 0x1700381B RID: 14363
		// (get) Token: 0x06010FAD RID: 69549 RVA: 0x0027CC94 File Offset: 0x0027AE94
		// (set) Token: 0x06010FAE RID: 69550 RVA: 0x0027CC9C File Offset: 0x0027AE9C
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

		// Token: 0x1700381C RID: 14364
		// (get) Token: 0x06010FAF RID: 69551 RVA: 0x0027CCA5 File Offset: 0x0027AEA5
		// (set) Token: 0x06010FB0 RID: 69552 RVA: 0x0027CCAD File Offset: 0x0027AEAD
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

		// Token: 0x1700381D RID: 14365
		// (get) Token: 0x06010FB1 RID: 69553 RVA: 0x0027CCB6 File Offset: 0x0027AEB6
		// (set) Token: 0x06010FB2 RID: 69554 RVA: 0x0027CCBE File Offset: 0x0027AEBE
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

		// Token: 0x1700381E RID: 14366
		// (get) Token: 0x06010FB3 RID: 69555 RVA: 0x0027CCC7 File Offset: 0x0027AEC7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> LockFactors
		{
			get
			{
				return this.lockFactors_;
			}
		}

		// Token: 0x06010FB4 RID: 69556 RVA: 0x0027CCCF File Offset: 0x0027AECF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleCardFighterInfoCtx);
		}

		// Token: 0x06010FB5 RID: 69557 RVA: 0x0027CCE0 File Offset: 0x0027AEE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleCardFighterInfoCtx other)
		{
			return other != null && (other == this || (this.CardUid == other.CardUid && this.CardConfId == other.CardConfId && this.GamerIndex == other.GamerIndex && this.SlotIndex == other.SlotIndex && this.Attrs.Equals(other.Attrs) && this.EvolveCount == other.EvolveCount && this.factors_.Equals(other.factors_) && this.CanUnlimitedEvolve == other.CanUnlimitedEvolve && this.IsCopy == other.IsCopy && object.Equals(this.SkillUnlockInfo, other.SkillUnlockInfo) && this.lockFactors_.Equals(other.lockFactors_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06010FB6 RID: 69558 RVA: 0x0027CDD0 File Offset: 0x0027AFD0
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

		// Token: 0x06010FB7 RID: 69559 RVA: 0x0027CEE5 File Offset: 0x0027B0E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06010FB8 RID: 69560 RVA: 0x0027CEF2 File Offset: 0x0027B0F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06010FB9 RID: 69561 RVA: 0x0027CEFC File Offset: 0x0027B0FC
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

		// Token: 0x06010FBA RID: 69562 RVA: 0x0027D030 File Offset: 0x0027B230
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

		// Token: 0x06010FBB RID: 69563 RVA: 0x0027D138 File Offset: 0x0027B338
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

		// Token: 0x06010FBC RID: 69564 RVA: 0x0027D24B File Offset: 0x0027B44B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06010FBD RID: 69565 RVA: 0x0027D254 File Offset: 0x0027B454
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

		// Token: 0x04006C05 RID: 27653
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006C06 RID: 27654
		public const int CardUidFieldNumber = 1;

		// Token: 0x04006C07 RID: 27655
		private int cardUid_;

		// Token: 0x04006C08 RID: 27656
		public const int CardConfIdFieldNumber = 2;

		// Token: 0x04006C09 RID: 27657
		private int cardConfId_;

		// Token: 0x04006C0A RID: 27658
		public const int GamerIndexFieldNumber = 3;

		// Token: 0x04006C0B RID: 27659
		private int gamerIndex_;

		// Token: 0x04006C0C RID: 27660
		public const int SlotIndexFieldNumber = 4;

		// Token: 0x04006C0D RID: 27661
		private int slotIndex_;

		// Token: 0x04006C0E RID: 27662
		public const int AttrsFieldNumber = 5;

		// Token: 0x04006C0F RID: 27663
		private static readonly MapField<int, int>.Codec _map_attrs_codec = new MapField<int, int>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForInt32(16U, 0), 42U);

		// Token: 0x04006C10 RID: 27664
		private readonly MapField<int, int> attrs_ = new MapField<int, int>();

		// Token: 0x04006C11 RID: 27665
		public const int EvolveCountFieldNumber = 6;

		// Token: 0x04006C12 RID: 27666
		private int evolveCount_;

		// Token: 0x04006C13 RID: 27667
		public const int FactorsFieldNumber = 7;

		// Token: 0x04006C14 RID: 27668
		private static readonly FieldCodec<int> _repeated_factors_codec = FieldCodec.ForInt32(58U);

		// Token: 0x04006C15 RID: 27669
		private readonly RepeatedField<int> factors_ = new RepeatedField<int>();

		// Token: 0x04006C16 RID: 27670
		public const int CanUnlimitedEvolveFieldNumber = 8;

		// Token: 0x04006C17 RID: 27671
		private bool canUnlimitedEvolve_;

		// Token: 0x04006C18 RID: 27672
		public const int IsCopyFieldNumber = 9;

		// Token: 0x04006C19 RID: 27673
		private bool isCopy_;

		// Token: 0x04006C1A RID: 27674
		public const int SkillUnlockInfoFieldNumber = 10;

		// Token: 0x04006C1B RID: 27675
		private PhantomBattleCardSkillUnlockInfo skillUnlockInfo_;

		// Token: 0x04006C1C RID: 27676
		public const int LockFactorsFieldNumber = 11;

		// Token: 0x04006C1D RID: 27677
		private static readonly FieldCodec<int> _repeated_lockFactors_codec = FieldCodec.ForInt32(90U);

		// Token: 0x04006C1E RID: 27678
		private readonly RepeatedField<int> lockFactors_ = new RepeatedField<int>();
	}
}
