using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020010E3 RID: 4323
	public sealed class RoleTowerRoleBrief : IMessage<RoleTowerRoleBrief>, IMessage, IEquatable<RoleTowerRoleBrief>, IDeepCloneable<RoleTowerRoleBrief>, IBufferMessage
	{
		// Token: 0x060171C3 RID: 94659 RVA: 0x0035CC15 File Offset: 0x0035AE15
		[NullableContext(1)]
		public static RoleTowerRoleBrief Create()
		{
			return new RoleTowerRoleBrief();
		}

		// Token: 0x17004D97 RID: 19863
		// (get) Token: 0x060171C4 RID: 94660 RVA: 0x0035CC1C File Offset: 0x0035AE1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RoleTowerRoleBrief> Parser
		{
			get
			{
				return RoleTowerRoleBrief._parser;
			}
		}

		// Token: 0x17004D98 RID: 19864
		// (get) Token: 0x060171C5 RID: 94661 RVA: 0x0035CC23 File Offset: 0x0035AE23
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004D99 RID: 19865
		// (get) Token: 0x060171C6 RID: 94662 RVA: 0x0035CC26 File Offset: 0x0035AE26
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleTowerRoleBrief.Descriptor;
			}
		}

		// Token: 0x060171C7 RID: 94663 RVA: 0x0035CC2D File Offset: 0x0035AE2D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTowerRoleBrief()
		{
		}

		// Token: 0x060171C8 RID: 94664 RVA: 0x0035CC35 File Offset: 0x0035AE35
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTowerRoleBrief(RoleTowerRoleBrief other) : this()
		{
			this.roleIdOrTrialRoleId_ = other.roleIdOrTrialRoleId_;
			this.skillBranchId_ = other.skillBranchId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060171C9 RID: 94665 RVA: 0x0035CC66 File Offset: 0x0035AE66
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTowerRoleBrief Clone()
		{
			return new RoleTowerRoleBrief(this);
		}

		// Token: 0x17004D9A RID: 19866
		// (get) Token: 0x060171CA RID: 94666 RVA: 0x0035CC6E File Offset: 0x0035AE6E
		// (set) Token: 0x060171CB RID: 94667 RVA: 0x0035CC76 File Offset: 0x0035AE76
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RoleIdOrTrialRoleId
		{
			get
			{
				return this.roleIdOrTrialRoleId_;
			}
			set
			{
				this.roleIdOrTrialRoleId_ = value;
			}
		}

		// Token: 0x17004D9B RID: 19867
		// (get) Token: 0x060171CC RID: 94668 RVA: 0x0035CC7F File Offset: 0x0035AE7F
		// (set) Token: 0x060171CD RID: 94669 RVA: 0x0035CC87 File Offset: 0x0035AE87
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SkillBranchId
		{
			get
			{
				return this.skillBranchId_;
			}
			set
			{
				this.skillBranchId_ = value;
			}
		}

		// Token: 0x060171CE RID: 94670 RVA: 0x0035CC90 File Offset: 0x0035AE90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleTowerRoleBrief);
		}

		// Token: 0x060171CF RID: 94671 RVA: 0x0035CC9E File Offset: 0x0035AE9E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleTowerRoleBrief other)
		{
			return other != null && (other == this || (this.RoleIdOrTrialRoleId == other.RoleIdOrTrialRoleId && this.SkillBranchId == other.SkillBranchId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060171D0 RID: 94672 RVA: 0x0035CCDC File Offset: 0x0035AEDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.RoleIdOrTrialRoleId != 0)
			{
				num ^= this.RoleIdOrTrialRoleId.GetHashCode();
			}
			if (this.SkillBranchId != 0)
			{
				num ^= this.SkillBranchId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060171D1 RID: 94673 RVA: 0x0035CD34 File Offset: 0x0035AF34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060171D2 RID: 94674 RVA: 0x0035CD41 File Offset: 0x0035AF41
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060171D3 RID: 94675 RVA: 0x0035CD4C File Offset: 0x0035AF4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.RoleIdOrTrialRoleId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.RoleIdOrTrialRoleId);
			}
			if (this.SkillBranchId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.SkillBranchId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060171D4 RID: 94676 RVA: 0x0035CDA4 File Offset: 0x0035AFA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.RoleIdOrTrialRoleId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RoleIdOrTrialRoleId);
			}
			if (this.SkillBranchId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SkillBranchId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060171D5 RID: 94677 RVA: 0x0035CDFC File Offset: 0x0035AFFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoleTowerRoleBrief other)
		{
			if (other == null)
			{
				return;
			}
			if (other.RoleIdOrTrialRoleId != 0)
			{
				this.RoleIdOrTrialRoleId = other.RoleIdOrTrialRoleId;
			}
			if (other.SkillBranchId != 0)
			{
				this.SkillBranchId = other.SkillBranchId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060171D6 RID: 94678 RVA: 0x0035CE4C File Offset: 0x0035B04C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060171D7 RID: 94679 RVA: 0x0035CE58 File Offset: 0x0035B058
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
				if (num != 8U)
				{
					if (num != 16U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.SkillBranchId = input.ReadInt32();
					}
				}
				else
				{
					this.RoleIdOrTrialRoleId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04008A51 RID: 35409
		private static readonly MessageParser<RoleTowerRoleBrief> _parser = new MessageParser<RoleTowerRoleBrief>(() => new RoleTowerRoleBrief());

		// Token: 0x04008A52 RID: 35410
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008A53 RID: 35411
		public const int RoleIdOrTrialRoleIdFieldNumber = 1;

		// Token: 0x04008A54 RID: 35412
		private int roleIdOrTrialRoleId_;

		// Token: 0x04008A55 RID: 35413
		public const int SkillBranchIdFieldNumber = 2;

		// Token: 0x04008A56 RID: 35414
		private int skillBranchId_;
	}
}
