using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B6B RID: 2923
	public sealed class NpcPhantomBattleCardRoleSkillInfo : IMessage<NpcPhantomBattleCardRoleSkillInfo>, IMessage, IEquatable<NpcPhantomBattleCardRoleSkillInfo>, IDeepCloneable<NpcPhantomBattleCardRoleSkillInfo>, IBufferMessage
	{
		// Token: 0x0600FD40 RID: 64832 RVA: 0x0024E193 File Offset: 0x0024C393
		[NullableContext(1)]
		public static NpcPhantomBattleCardRoleSkillInfo Create()
		{
			return new NpcPhantomBattleCardRoleSkillInfo();
		}

		// Token: 0x170033A3 RID: 13219
		// (get) Token: 0x0600FD41 RID: 64833 RVA: 0x0024E19A File Offset: 0x0024C39A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170033A4 RID: 13220
		// (get) Token: 0x0600FD42 RID: 64834 RVA: 0x0024E19D File Offset: 0x0024C39D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NpcPhantomBattleCardRoleSkillInfo.Descriptor;
			}
		}

		// Token: 0x0600FD43 RID: 64835 RVA: 0x0024E1A4 File Offset: 0x0024C3A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NpcPhantomBattleCardRoleSkillInfo()
		{
		}

		// Token: 0x0600FD44 RID: 64836 RVA: 0x0024E1B8 File Offset: 0x0024C3B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NpcPhantomBattleCardRoleSkillInfo(NpcPhantomBattleCardRoleSkillInfo other) : this()
		{
			this.skillId_ = other.skillId_;
			this.selectFighterUId_ = other.selectFighterUId_.Clone();
			this.phantomBattleEffectResultInfo_ = ((other.phantomBattleEffectResultInfo_ != null) ? other.phantomBattleEffectResultInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600FD45 RID: 64837 RVA: 0x0024E215 File Offset: 0x0024C415
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NpcPhantomBattleCardRoleSkillInfo Clone()
		{
			return new NpcPhantomBattleCardRoleSkillInfo(this);
		}

		// Token: 0x170033A5 RID: 13221
		// (get) Token: 0x0600FD46 RID: 64838 RVA: 0x0024E21D File Offset: 0x0024C41D
		// (set) Token: 0x0600FD47 RID: 64839 RVA: 0x0024E225 File Offset: 0x0024C425
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

		// Token: 0x170033A6 RID: 13222
		// (get) Token: 0x0600FD48 RID: 64840 RVA: 0x0024E22E File Offset: 0x0024C42E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> SelectFighterUId
		{
			get
			{
				return this.selectFighterUId_;
			}
		}

		// Token: 0x170033A7 RID: 13223
		// (get) Token: 0x0600FD49 RID: 64841 RVA: 0x0024E236 File Offset: 0x0024C436
		// (set) Token: 0x0600FD4A RID: 64842 RVA: 0x0024E23E File Offset: 0x0024C43E
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

		// Token: 0x0600FD4B RID: 64843 RVA: 0x0024E247 File Offset: 0x0024C447
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NpcPhantomBattleCardRoleSkillInfo);
		}

		// Token: 0x0600FD4C RID: 64844 RVA: 0x0024E258 File Offset: 0x0024C458
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NpcPhantomBattleCardRoleSkillInfo other)
		{
			return other != null && (other == this || (this.SkillId == other.SkillId && this.selectFighterUId_.Equals(other.selectFighterUId_) && object.Equals(this.PhantomBattleEffectResultInfo, other.PhantomBattleEffectResultInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600FD4D RID: 64845 RVA: 0x0024E2BC File Offset: 0x0024C4BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.SkillId != 0)
			{
				num ^= this.SkillId.GetHashCode();
			}
			num ^= this.selectFighterUId_.GetHashCode();
			if (this.phantomBattleEffectResultInfo_ != null)
			{
				num ^= this.PhantomBattleEffectResultInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600FD4E RID: 64846 RVA: 0x0024E31F File Offset: 0x0024C51F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600FD4F RID: 64847 RVA: 0x0024E32C File Offset: 0x0024C52C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600FD50 RID: 64848 RVA: 0x0024E338 File Offset: 0x0024C538
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SkillId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.SkillId);
			}
			this.selectFighterUId_.WriteTo(ref output, NpcPhantomBattleCardRoleSkillInfo._repeated_selectFighterUId_codec);
			if (this.phantomBattleEffectResultInfo_ != null)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.PhantomBattleEffectResultInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600FD51 RID: 64849 RVA: 0x0024E3A4 File Offset: 0x0024C5A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.SkillId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SkillId);
			}
			num += this.selectFighterUId_.CalculateSize(NpcPhantomBattleCardRoleSkillInfo._repeated_selectFighterUId_codec);
			if (this.phantomBattleEffectResultInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.PhantomBattleEffectResultInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600FD52 RID: 64850 RVA: 0x0024E410 File Offset: 0x0024C610
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(NpcPhantomBattleCardRoleSkillInfo other)
		{
			if (other == null)
			{
				return;
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
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600FD53 RID: 64851 RVA: 0x0024E489 File Offset: 0x0024C689
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600FD54 RID: 64852 RVA: 0x0024E494 File Offset: 0x0024C694
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
				if (num <= 16U)
				{
					if (num == 8U)
					{
						this.SkillId = input.ReadInt32();
						continue;
					}
					if (num == 16U)
					{
						goto IL_45;
					}
				}
				else
				{
					if (num == 18U)
					{
						goto IL_45;
					}
					if (num == 26U)
					{
						if (this.phantomBattleEffectResultInfo_ == null)
						{
							this.PhantomBattleEffectResultInfo = new PhantomBattleEffectResultInfo();
						}
						input.ReadMessage(this.PhantomBattleEffectResultInfo);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				continue;
				IL_45:
				this.selectFighterUId_.AddEntriesFrom(ref input, NpcPhantomBattleCardRoleSkillInfo._repeated_selectFighterUId_codec);
			}
		}

		// Token: 0x04006506 RID: 25862
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006507 RID: 25863
		public const int SkillIdFieldNumber = 1;

		// Token: 0x04006508 RID: 25864
		private int skillId_;

		// Token: 0x04006509 RID: 25865
		public const int SelectFighterUIdFieldNumber = 2;

		// Token: 0x0400650A RID: 25866
		private static readonly FieldCodec<int> _repeated_selectFighterUId_codec = FieldCodec.ForInt32(18U);

		// Token: 0x0400650B RID: 25867
		private readonly RepeatedField<int> selectFighterUId_ = new RepeatedField<int>();

		// Token: 0x0400650C RID: 25868
		public const int PhantomBattleEffectResultInfoFieldNumber = 3;

		// Token: 0x0400650D RID: 25869
		private PhantomBattleEffectResultInfo phantomBattleEffectResultInfo_;
	}
}
