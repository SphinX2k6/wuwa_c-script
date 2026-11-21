using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B5A RID: 2906
	public sealed class NpcPhantomBattleCardDurableSkillInfo : IMessage<NpcPhantomBattleCardDurableSkillInfo>, IMessage, IEquatable<NpcPhantomBattleCardDurableSkillInfo>, IDeepCloneable<NpcPhantomBattleCardDurableSkillInfo>, IBufferMessage
	{
		// Token: 0x0600FC1E RID: 64542 RVA: 0x0024BC89 File Offset: 0x00249E89
		[NullableContext(1)]
		public static NpcPhantomBattleCardDurableSkillInfo Create()
		{
			return new NpcPhantomBattleCardDurableSkillInfo();
		}

		// Token: 0x17003361 RID: 13153
		// (get) Token: 0x0600FC1F RID: 64543 RVA: 0x0024BC90 File Offset: 0x00249E90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003362 RID: 13154
		// (get) Token: 0x0600FC20 RID: 64544 RVA: 0x0024BC93 File Offset: 0x00249E93
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NpcPhantomBattleCardDurableSkillInfo.Descriptor;
			}
		}

		// Token: 0x0600FC21 RID: 64545 RVA: 0x0024BC9A File Offset: 0x00249E9A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NpcPhantomBattleCardDurableSkillInfo()
		{
		}

		// Token: 0x0600FC22 RID: 64546 RVA: 0x0024BCB0 File Offset: 0x00249EB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NpcPhantomBattleCardDurableSkillInfo(NpcPhantomBattleCardDurableSkillInfo other) : this()
		{
			this.cardUId_ = other.cardUId_;
			this.cardConfId_ = other.cardConfId_;
			this.skillId_ = other.skillId_;
			this.selectFighterUId_ = other.selectFighterUId_.Clone();
			this.phantomBattleEffectResultInfo_ = ((other.phantomBattleEffectResultInfo_ != null) ? other.phantomBattleEffectResultInfo_.Clone() : null);
			this.curCardLibraryNum_ = other.curCardLibraryNum_;
			this.handCardNum_ = other.handCardNum_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600FC23 RID: 64547 RVA: 0x0024BD3D File Offset: 0x00249F3D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NpcPhantomBattleCardDurableSkillInfo Clone()
		{
			return new NpcPhantomBattleCardDurableSkillInfo(this);
		}

		// Token: 0x17003363 RID: 13155
		// (get) Token: 0x0600FC24 RID: 64548 RVA: 0x0024BD45 File Offset: 0x00249F45
		// (set) Token: 0x0600FC25 RID: 64549 RVA: 0x0024BD4D File Offset: 0x00249F4D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CardUId
		{
			get
			{
				return this.cardUId_;
			}
			set
			{
				this.cardUId_ = value;
			}
		}

		// Token: 0x17003364 RID: 13156
		// (get) Token: 0x0600FC26 RID: 64550 RVA: 0x0024BD56 File Offset: 0x00249F56
		// (set) Token: 0x0600FC27 RID: 64551 RVA: 0x0024BD5E File Offset: 0x00249F5E
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

		// Token: 0x17003365 RID: 13157
		// (get) Token: 0x0600FC28 RID: 64552 RVA: 0x0024BD67 File Offset: 0x00249F67
		// (set) Token: 0x0600FC29 RID: 64553 RVA: 0x0024BD6F File Offset: 0x00249F6F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SkillId
		{
			get
			{
				return this.skillId_;
			}
			set
			{
				this.skillId_ = value;
			}
		}

		// Token: 0x17003366 RID: 13158
		// (get) Token: 0x0600FC2A RID: 64554 RVA: 0x0024BD78 File Offset: 0x00249F78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> SelectFighterUId
		{
			get
			{
				return this.selectFighterUId_;
			}
		}

		// Token: 0x17003367 RID: 13159
		// (get) Token: 0x0600FC2B RID: 64555 RVA: 0x0024BD80 File Offset: 0x00249F80
		// (set) Token: 0x0600FC2C RID: 64556 RVA: 0x0024BD88 File Offset: 0x00249F88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleEffectResultInfo PhantomBattleEffectResultInfo
		{
			get
			{
				return this.phantomBattleEffectResultInfo_;
			}
			set
			{
				this.phantomBattleEffectResultInfo_ = value;
			}
		}

		// Token: 0x17003368 RID: 13160
		// (get) Token: 0x0600FC2D RID: 64557 RVA: 0x0024BD91 File Offset: 0x00249F91
		// (set) Token: 0x0600FC2E RID: 64558 RVA: 0x0024BD99 File Offset: 0x00249F99
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CurCardLibraryNum
		{
			get
			{
				return this.curCardLibraryNum_;
			}
			set
			{
				this.curCardLibraryNum_ = value;
			}
		}

		// Token: 0x17003369 RID: 13161
		// (get) Token: 0x0600FC2F RID: 64559 RVA: 0x0024BDA2 File Offset: 0x00249FA2
		// (set) Token: 0x0600FC30 RID: 64560 RVA: 0x0024BDAA File Offset: 0x00249FAA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int HandCardNum
		{
			get
			{
				return this.handCardNum_;
			}
			set
			{
				this.handCardNum_ = value;
			}
		}

		// Token: 0x0600FC31 RID: 64561 RVA: 0x0024BDB3 File Offset: 0x00249FB3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NpcPhantomBattleCardDurableSkillInfo);
		}

		// Token: 0x0600FC32 RID: 64562 RVA: 0x0024BDC4 File Offset: 0x00249FC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NpcPhantomBattleCardDurableSkillInfo other)
		{
			return other != null && (other == this || (this.CardUId == other.CardUId && this.CardConfId == other.CardConfId && this.SkillId == other.SkillId && this.selectFighterUId_.Equals(other.selectFighterUId_) && object.Equals(this.PhantomBattleEffectResultInfo, other.PhantomBattleEffectResultInfo) && this.CurCardLibraryNum == other.CurCardLibraryNum && this.HandCardNum == other.HandCardNum && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600FC33 RID: 64563 RVA: 0x0024BE68 File Offset: 0x0024A068
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.CardUId != 0)
			{
				num ^= this.CardUId.GetHashCode();
			}
			if (this.CardConfId != 0)
			{
				num ^= this.CardConfId.GetHashCode();
			}
			if (this.SkillId != 0)
			{
				num ^= this.SkillId.GetHashCode();
			}
			num ^= this.selectFighterUId_.GetHashCode();
			if (this.phantomBattleEffectResultInfo_ != null)
			{
				num ^= this.PhantomBattleEffectResultInfo.GetHashCode();
			}
			if (this.CurCardLibraryNum != 0)
			{
				num ^= this.CurCardLibraryNum.GetHashCode();
			}
			if (this.HandCardNum != 0)
			{
				num ^= this.HandCardNum.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600FC34 RID: 64564 RVA: 0x0024BF2F File Offset: 0x0024A12F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600FC35 RID: 64565 RVA: 0x0024BF3C File Offset: 0x0024A13C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600FC36 RID: 64566 RVA: 0x0024BF48 File Offset: 0x0024A148
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.CardUId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.CardUId);
			}
			if (this.CardConfId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.CardConfId);
			}
			if (this.SkillId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.SkillId);
			}
			this.selectFighterUId_.WriteTo(ref output, NpcPhantomBattleCardDurableSkillInfo._repeated_selectFighterUId_codec);
			if (this.phantomBattleEffectResultInfo_ != null)
			{
				output.WriteRawTag(42);
				output.WriteMessage(this.PhantomBattleEffectResultInfo);
			}
			if (this.CurCardLibraryNum != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.CurCardLibraryNum);
			}
			if (this.HandCardNum != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.HandCardNum);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600FC37 RID: 64567 RVA: 0x0024C024 File Offset: 0x0024A224
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.CardUId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CardUId);
			}
			if (this.CardConfId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CardConfId);
			}
			if (this.SkillId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SkillId);
			}
			num += this.selectFighterUId_.CalculateSize(NpcPhantomBattleCardDurableSkillInfo._repeated_selectFighterUId_codec);
			if (this.phantomBattleEffectResultInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.PhantomBattleEffectResultInfo);
			}
			if (this.CurCardLibraryNum != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CurCardLibraryNum);
			}
			if (this.HandCardNum != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.HandCardNum);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600FC38 RID: 64568 RVA: 0x0024C0F0 File Offset: 0x0024A2F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(NpcPhantomBattleCardDurableSkillInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.CardUId != 0)
			{
				this.CardUId = other.CardUId;
			}
			if (other.CardConfId != 0)
			{
				this.CardConfId = other.CardConfId;
			}
			if (other.SkillId != 0)
			{
				this.SkillId = other.SkillId;
			}
			this.selectFighterUId_.Add(other.selectFighterUId_);
			if (other.phantomBattleEffectResultInfo_ != null)
			{
				if (this.phantomBattleEffectResultInfo_ == null)
				{
					this.PhantomBattleEffectResultInfo = new PhantomBattleEffectResultInfo();
				}
				this.PhantomBattleEffectResultInfo.MergeFrom(other.PhantomBattleEffectResultInfo);
			}
			if (other.CurCardLibraryNum != 0)
			{
				this.CurCardLibraryNum = other.CurCardLibraryNum;
			}
			if (other.HandCardNum != 0)
			{
				this.HandCardNum = other.HandCardNum;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600FC39 RID: 64569 RVA: 0x0024C1B9 File Offset: 0x0024A3B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600FC3A RID: 64570 RVA: 0x0024C1C4 File Offset: 0x0024A3C4
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
				if (num <= 32U)
				{
					if (num <= 16U)
					{
						if (num == 8U)
						{
							this.CardUId = input.ReadInt32();
							continue;
						}
						if (num == 16U)
						{
							this.CardConfId = input.ReadInt32();
							continue;
						}
					}
					else
					{
						if (num == 24U)
						{
							this.SkillId = input.ReadInt32();
							continue;
						}
						if (num == 32U)
						{
							goto IL_89;
						}
					}
				}
				else if (num <= 42U)
				{
					if (num == 34U)
					{
						goto IL_89;
					}
					if (num == 42U)
					{
						if (this.phantomBattleEffectResultInfo_ == null)
						{
							this.PhantomBattleEffectResultInfo = new PhantomBattleEffectResultInfo();
						}
						input.ReadMessage(this.PhantomBattleEffectResultInfo);
						continue;
					}
				}
				else
				{
					if (num == 48U)
					{
						this.CurCardLibraryNum = input.ReadInt32();
						continue;
					}
					if (num == 56U)
					{
						this.HandCardNum = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				continue;
				IL_89:
				this.selectFighterUId_.AddEntriesFrom(ref input, NpcPhantomBattleCardDurableSkillInfo._repeated_selectFighterUId_codec);
			}
		}

		// Token: 0x04006506 RID: 25862
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006507 RID: 25863
		public const int CardUIdFieldNumber = 1;

		// Token: 0x04006508 RID: 25864
		private int cardUId_;

		// Token: 0x04006509 RID: 25865
		public const int CardConfIdFieldNumber = 2;

		// Token: 0x0400650A RID: 25866
		private int cardConfId_;

		// Token: 0x0400650B RID: 25867
		public const int SkillIdFieldNumber = 3;

		// Token: 0x0400650C RID: 25868
		private int skillId_;

		// Token: 0x0400650D RID: 25869
		public const int SelectFighterUIdFieldNumber = 4;

		// Token: 0x0400650E RID: 25870
		private static readonly FieldCodec<int> _repeated_selectFighterUId_codec = FieldCodec.ForInt32(34U);

		// Token: 0x0400650F RID: 25871
		private readonly RepeatedField<int> selectFighterUId_ = new RepeatedField<int>();

		// Token: 0x04006510 RID: 25872
		public const int PhantomBattleEffectResultInfoFieldNumber = 5;

		// Token: 0x04006511 RID: 25873
		private PhantomBattleEffectResultInfo phantomBattleEffectResultInfo_;

		// Token: 0x04006512 RID: 25874
		public const int CurCardLibraryNumFieldNumber = 6;

		// Token: 0x04006513 RID: 25875
		private int curCardLibraryNum_;

		// Token: 0x04006514 RID: 25876
		public const int HandCardNumFieldNumber = 7;

		// Token: 0x04006515 RID: 25877
		private int handCardNum_;
	}
}
