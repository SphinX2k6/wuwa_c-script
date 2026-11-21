using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B5B RID: 2907
	public sealed class NpcPhantomBattleCardRoleSkillInfo : IMessage<NpcPhantomBattleCardRoleSkillInfo>, IMessage, IEquatable<NpcPhantomBattleCardRoleSkillInfo>, IDeepCloneable<NpcPhantomBattleCardRoleSkillInfo>, IBufferMessage
	{
		// Token: 0x0600FC3C RID: 64572 RVA: 0x0024C2C3 File Offset: 0x0024A4C3
		[NullableContext(1)]
		public static NpcPhantomBattleCardRoleSkillInfo Create()
		{
			return new NpcPhantomBattleCardRoleSkillInfo();
		}

		// Token: 0x1700336A RID: 13162
		// (get) Token: 0x0600FC3D RID: 64573 RVA: 0x0024C2CA File Offset: 0x0024A4CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700336B RID: 13163
		// (get) Token: 0x0600FC3E RID: 64574 RVA: 0x0024C2CD File Offset: 0x0024A4CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NpcPhantomBattleCardRoleSkillInfo.Descriptor;
			}
		}

		// Token: 0x0600FC3F RID: 64575 RVA: 0x0024C2D4 File Offset: 0x0024A4D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NpcPhantomBattleCardRoleSkillInfo()
		{
		}

		// Token: 0x0600FC40 RID: 64576 RVA: 0x0024C2E8 File Offset: 0x0024A4E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NpcPhantomBattleCardRoleSkillInfo(NpcPhantomBattleCardRoleSkillInfo other) : this()
		{
			this.skillId_ = other.skillId_;
			this.selectFighterUId_ = other.selectFighterUId_.Clone();
			this.phantomBattleEffectResultInfo_ = ((other.phantomBattleEffectResultInfo_ != null) ? other.phantomBattleEffectResultInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600FC41 RID: 64577 RVA: 0x0024C345 File Offset: 0x0024A545
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NpcPhantomBattleCardRoleSkillInfo Clone()
		{
			return new NpcPhantomBattleCardRoleSkillInfo(this);
		}

		// Token: 0x1700336C RID: 13164
		// (get) Token: 0x0600FC42 RID: 64578 RVA: 0x0024C34D File Offset: 0x0024A54D
		// (set) Token: 0x0600FC43 RID: 64579 RVA: 0x0024C355 File Offset: 0x0024A555
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

		// Token: 0x1700336D RID: 13165
		// (get) Token: 0x0600FC44 RID: 64580 RVA: 0x0024C35E File Offset: 0x0024A55E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> SelectFighterUId
		{
			get
			{
				return this.selectFighterUId_;
			}
		}

		// Token: 0x1700336E RID: 13166
		// (get) Token: 0x0600FC45 RID: 64581 RVA: 0x0024C366 File Offset: 0x0024A566
		// (set) Token: 0x0600FC46 RID: 64582 RVA: 0x0024C36E File Offset: 0x0024A56E
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

		// Token: 0x0600FC47 RID: 64583 RVA: 0x0024C377 File Offset: 0x0024A577
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NpcPhantomBattleCardRoleSkillInfo);
		}

		// Token: 0x0600FC48 RID: 64584 RVA: 0x0024C388 File Offset: 0x0024A588
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NpcPhantomBattleCardRoleSkillInfo other)
		{
			return other != null && (other == this || (this.SkillId == other.SkillId && this.selectFighterUId_.Equals(other.selectFighterUId_) && object.Equals(this.PhantomBattleEffectResultInfo, other.PhantomBattleEffectResultInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600FC49 RID: 64585 RVA: 0x0024C3EC File Offset: 0x0024A5EC
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

		// Token: 0x0600FC4A RID: 64586 RVA: 0x0024C44F File Offset: 0x0024A64F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600FC4B RID: 64587 RVA: 0x0024C45C File Offset: 0x0024A65C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600FC4C RID: 64588 RVA: 0x0024C468 File Offset: 0x0024A668
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

		// Token: 0x0600FC4D RID: 64589 RVA: 0x0024C4D4 File Offset: 0x0024A6D4
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

		// Token: 0x0600FC4E RID: 64590 RVA: 0x0024C540 File Offset: 0x0024A740
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

		// Token: 0x0600FC4F RID: 64591 RVA: 0x0024C5B9 File Offset: 0x0024A7B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600FC50 RID: 64592 RVA: 0x0024C5C4 File Offset: 0x0024A7C4
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

		// Token: 0x04006516 RID: 25878
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006517 RID: 25879
		public const int SkillIdFieldNumber = 1;

		// Token: 0x04006518 RID: 25880
		private int skillId_;

		// Token: 0x04006519 RID: 25881
		public const int SelectFighterUIdFieldNumber = 2;

		// Token: 0x0400651A RID: 25882
		private static readonly FieldCodec<int> _repeated_selectFighterUId_codec = FieldCodec.ForInt32(18U);

		// Token: 0x0400651B RID: 25883
		private readonly RepeatedField<int> selectFighterUId_ = new RepeatedField<int>();

		// Token: 0x0400651C RID: 25884
		public const int PhantomBattleEffectResultInfoFieldNumber = 3;

		// Token: 0x0400651D RID: 25885
		private PhantomBattleEffectResultInfo phantomBattleEffectResultInfo_;
	}
}
