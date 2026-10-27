using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B6A RID: 2922
	public sealed class NpcPhantomBattleCardDurableSkillInfo : IMessage<NpcPhantomBattleCardDurableSkillInfo>, IMessage, IEquatable<NpcPhantomBattleCardDurableSkillInfo>, IDeepCloneable<NpcPhantomBattleCardDurableSkillInfo>, IBufferMessage
	{
		// Token: 0x0600FD22 RID: 64802 RVA: 0x0024DB59 File Offset: 0x0024BD59
		[NullableContext(1)]
		public static NpcPhantomBattleCardDurableSkillInfo Create()
		{
			return new NpcPhantomBattleCardDurableSkillInfo();
		}

		// Token: 0x1700339A RID: 13210
		// (get) Token: 0x0600FD23 RID: 64803 RVA: 0x0024DB60 File Offset: 0x0024BD60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700339B RID: 13211
		// (get) Token: 0x0600FD24 RID: 64804 RVA: 0x0024DB63 File Offset: 0x0024BD63
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NpcPhantomBattleCardDurableSkillInfo.Descriptor;
			}
		}

		// Token: 0x0600FD25 RID: 64805 RVA: 0x0024DB6A File Offset: 0x0024BD6A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NpcPhantomBattleCardDurableSkillInfo()
		{
		}

		// Token: 0x0600FD26 RID: 64806 RVA: 0x0024DB80 File Offset: 0x0024BD80
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

		// Token: 0x0600FD27 RID: 64807 RVA: 0x0024DC0D File Offset: 0x0024BE0D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NpcPhantomBattleCardDurableSkillInfo Clone()
		{
			return new NpcPhantomBattleCardDurableSkillInfo(this);
		}

		// Token: 0x1700339C RID: 13212
		// (get) Token: 0x0600FD28 RID: 64808 RVA: 0x0024DC15 File Offset: 0x0024BE15
		// (set) Token: 0x0600FD29 RID: 64809 RVA: 0x0024DC1D File Offset: 0x0024BE1D
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

		// Token: 0x1700339D RID: 13213
		// (get) Token: 0x0600FD2A RID: 64810 RVA: 0x0024DC26 File Offset: 0x0024BE26
		// (set) Token: 0x0600FD2B RID: 64811 RVA: 0x0024DC2E File Offset: 0x0024BE2E
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

		// Token: 0x1700339E RID: 13214
		// (get) Token: 0x0600FD2C RID: 64812 RVA: 0x0024DC37 File Offset: 0x0024BE37
		// (set) Token: 0x0600FD2D RID: 64813 RVA: 0x0024DC3F File Offset: 0x0024BE3F
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

		// Token: 0x1700339F RID: 13215
		// (get) Token: 0x0600FD2E RID: 64814 RVA: 0x0024DC48 File Offset: 0x0024BE48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> SelectFighterUId
		{
			get
			{
				return this.selectFighterUId_;
			}
		}

		// Token: 0x170033A0 RID: 13216
		// (get) Token: 0x0600FD2F RID: 64815 RVA: 0x0024DC50 File Offset: 0x0024BE50
		// (set) Token: 0x0600FD30 RID: 64816 RVA: 0x0024DC58 File Offset: 0x0024BE58
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

		// Token: 0x170033A1 RID: 13217
		// (get) Token: 0x0600FD31 RID: 64817 RVA: 0x0024DC61 File Offset: 0x0024BE61
		// (set) Token: 0x0600FD32 RID: 64818 RVA: 0x0024DC69 File Offset: 0x0024BE69
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

		// Token: 0x170033A2 RID: 13218
		// (get) Token: 0x0600FD33 RID: 64819 RVA: 0x0024DC72 File Offset: 0x0024BE72
		// (set) Token: 0x0600FD34 RID: 64820 RVA: 0x0024DC7A File Offset: 0x0024BE7A
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

		// Token: 0x0600FD35 RID: 64821 RVA: 0x0024DC83 File Offset: 0x0024BE83
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NpcPhantomBattleCardDurableSkillInfo);
		}

		// Token: 0x0600FD36 RID: 64822 RVA: 0x0024DC94 File Offset: 0x0024BE94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NpcPhantomBattleCardDurableSkillInfo other)
		{
			return other != null && (other == this || (this.CardUId == other.CardUId && this.CardConfId == other.CardConfId && this.SkillId == other.SkillId && this.selectFighterUId_.Equals(other.selectFighterUId_) && object.Equals(this.PhantomBattleEffectResultInfo, other.PhantomBattleEffectResultInfo) && this.CurCardLibraryNum == other.CurCardLibraryNum && this.HandCardNum == other.HandCardNum && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600FD37 RID: 64823 RVA: 0x0024DD38 File Offset: 0x0024BF38
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

		// Token: 0x0600FD38 RID: 64824 RVA: 0x0024DDFF File Offset: 0x0024BFFF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600FD39 RID: 64825 RVA: 0x0024DE0C File Offset: 0x0024C00C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600FD3A RID: 64826 RVA: 0x0024DE18 File Offset: 0x0024C018
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

		// Token: 0x0600FD3B RID: 64827 RVA: 0x0024DEF4 File Offset: 0x0024C0F4
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

		// Token: 0x0600FD3C RID: 64828 RVA: 0x0024DFC0 File Offset: 0x0024C1C0
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

		// Token: 0x0600FD3D RID: 64829 RVA: 0x0024E089 File Offset: 0x0024C289
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600FD3E RID: 64830 RVA: 0x0024E094 File Offset: 0x0024C294
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

		// Token: 0x040064F6 RID: 25846
		private UnknownFieldSet _unknownFields;

		// Token: 0x040064F7 RID: 25847
		public const int CardUIdFieldNumber = 1;

		// Token: 0x040064F8 RID: 25848
		private int cardUId_;

		// Token: 0x040064F9 RID: 25849
		public const int CardConfIdFieldNumber = 2;

		// Token: 0x040064FA RID: 25850
		private int cardConfId_;

		// Token: 0x040064FB RID: 25851
		public const int SkillIdFieldNumber = 3;

		// Token: 0x040064FC RID: 25852
		private int skillId_;

		// Token: 0x040064FD RID: 25853
		public const int SelectFighterUIdFieldNumber = 4;

		// Token: 0x040064FE RID: 25854
		private static readonly FieldCodec<int> _repeated_selectFighterUId_codec = FieldCodec.ForInt32(34U);

		// Token: 0x040064FF RID: 25855
		private readonly RepeatedField<int> selectFighterUId_ = new RepeatedField<int>();

		// Token: 0x04006500 RID: 25856
		public const int PhantomBattleEffectResultInfoFieldNumber = 5;

		// Token: 0x04006501 RID: 25857
		private PhantomBattleEffectResultInfo phantomBattleEffectResultInfo_;

		// Token: 0x04006502 RID: 25858
		public const int CurCardLibraryNumFieldNumber = 6;

		// Token: 0x04006503 RID: 25859
		private int curCardLibraryNum_;

		// Token: 0x04006504 RID: 25860
		public const int HandCardNumFieldNumber = 7;

		// Token: 0x04006505 RID: 25861
		private int handCardNum_;
	}
}
