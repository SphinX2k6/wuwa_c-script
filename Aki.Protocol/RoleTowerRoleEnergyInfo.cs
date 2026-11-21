using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020010E4 RID: 4324
	public sealed class RoleTowerRoleEnergyInfo : IMessage<RoleTowerRoleEnergyInfo>, IMessage, IEquatable<RoleTowerRoleEnergyInfo>, IDeepCloneable<RoleTowerRoleEnergyInfo>, IBufferMessage
	{
		// Token: 0x060171D9 RID: 94681 RVA: 0x0035CECB File Offset: 0x0035B0CB
		[NullableContext(1)]
		public static RoleTowerRoleEnergyInfo Create()
		{
			return new RoleTowerRoleEnergyInfo();
		}

		// Token: 0x17004D9C RID: 19868
		// (get) Token: 0x060171DA RID: 94682 RVA: 0x0035CED2 File Offset: 0x0035B0D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RoleTowerRoleEnergyInfo> Parser
		{
			get
			{
				return RoleTowerRoleEnergyInfo._parser;
			}
		}

		// Token: 0x17004D9D RID: 19869
		// (get) Token: 0x060171DB RID: 94683 RVA: 0x0035CED9 File Offset: 0x0035B0D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004D9E RID: 19870
		// (get) Token: 0x060171DC RID: 94684 RVA: 0x0035CEDC File Offset: 0x0035B0DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleTowerRoleEnergyInfo.Descriptor;
			}
		}

		// Token: 0x060171DD RID: 94685 RVA: 0x0035CEE3 File Offset: 0x0035B0E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTowerRoleEnergyInfo()
		{
		}

		// Token: 0x060171DE RID: 94686 RVA: 0x0035CEEC File Offset: 0x0035B0EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTowerRoleEnergyInfo(RoleTowerRoleEnergyInfo other) : this()
		{
			this.roleIdOrTrialRoleId_ = other.roleIdOrTrialRoleId_;
			this.trialRoleId_ = other.trialRoleId_;
			this.curEnergy_ = other.curEnergy_;
			this.maxEnergy_ = other.maxEnergy_;
			this.energyCost_ = other.energyCost_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060171DF RID: 94687 RVA: 0x0035CF4C File Offset: 0x0035B14C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTowerRoleEnergyInfo Clone()
		{
			return new RoleTowerRoleEnergyInfo(this);
		}

		// Token: 0x17004D9F RID: 19871
		// (get) Token: 0x060171E0 RID: 94688 RVA: 0x0035CF54 File Offset: 0x0035B154
		// (set) Token: 0x060171E1 RID: 94689 RVA: 0x0035CF5C File Offset: 0x0035B15C
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

		// Token: 0x17004DA0 RID: 19872
		// (get) Token: 0x060171E2 RID: 94690 RVA: 0x0035CF65 File Offset: 0x0035B165
		// (set) Token: 0x060171E3 RID: 94691 RVA: 0x0035CF6D File Offset: 0x0035B16D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TrialRoleId
		{
			get
			{
				return this.trialRoleId_;
			}
			set
			{
				this.trialRoleId_ = value;
			}
		}

		// Token: 0x17004DA1 RID: 19873
		// (get) Token: 0x060171E4 RID: 94692 RVA: 0x0035CF76 File Offset: 0x0035B176
		// (set) Token: 0x060171E5 RID: 94693 RVA: 0x0035CF7E File Offset: 0x0035B17E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CurEnergy
		{
			get
			{
				return this.curEnergy_;
			}
			set
			{
				this.curEnergy_ = value;
			}
		}

		// Token: 0x17004DA2 RID: 19874
		// (get) Token: 0x060171E6 RID: 94694 RVA: 0x0035CF87 File Offset: 0x0035B187
		// (set) Token: 0x060171E7 RID: 94695 RVA: 0x0035CF8F File Offset: 0x0035B18F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int MaxEnergy
		{
			get
			{
				return this.maxEnergy_;
			}
			set
			{
				this.maxEnergy_ = value;
			}
		}

		// Token: 0x17004DA3 RID: 19875
		// (get) Token: 0x060171E8 RID: 94696 RVA: 0x0035CF98 File Offset: 0x0035B198
		// (set) Token: 0x060171E9 RID: 94697 RVA: 0x0035CFA0 File Offset: 0x0035B1A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int EnergyCost
		{
			get
			{
				return this.energyCost_;
			}
			set
			{
				this.energyCost_ = value;
			}
		}

		// Token: 0x060171EA RID: 94698 RVA: 0x0035CFA9 File Offset: 0x0035B1A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleTowerRoleEnergyInfo);
		}

		// Token: 0x060171EB RID: 94699 RVA: 0x0035CFB8 File Offset: 0x0035B1B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleTowerRoleEnergyInfo other)
		{
			return other != null && (other == this || (this.RoleIdOrTrialRoleId == other.RoleIdOrTrialRoleId && this.TrialRoleId == other.TrialRoleId && this.CurEnergy == other.CurEnergy && this.MaxEnergy == other.MaxEnergy && this.EnergyCost == other.EnergyCost && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060171EC RID: 94700 RVA: 0x0035D034 File Offset: 0x0035B234
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.RoleIdOrTrialRoleId != 0)
			{
				num ^= this.RoleIdOrTrialRoleId.GetHashCode();
			}
			if (this.TrialRoleId != 0)
			{
				num ^= this.TrialRoleId.GetHashCode();
			}
			if (this.CurEnergy != 0)
			{
				num ^= this.CurEnergy.GetHashCode();
			}
			if (this.MaxEnergy != 0)
			{
				num ^= this.MaxEnergy.GetHashCode();
			}
			if (this.EnergyCost != 0)
			{
				num ^= this.EnergyCost.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060171ED RID: 94701 RVA: 0x0035D0D7 File Offset: 0x0035B2D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060171EE RID: 94702 RVA: 0x0035D0E4 File Offset: 0x0035B2E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060171EF RID: 94703 RVA: 0x0035D0F0 File Offset: 0x0035B2F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.RoleIdOrTrialRoleId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.RoleIdOrTrialRoleId);
			}
			if (this.TrialRoleId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.TrialRoleId);
			}
			if (this.CurEnergy != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.CurEnergy);
			}
			if (this.MaxEnergy != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.MaxEnergy);
			}
			if (this.EnergyCost != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.EnergyCost);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060171F0 RID: 94704 RVA: 0x0035D19C File Offset: 0x0035B39C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.RoleIdOrTrialRoleId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RoleIdOrTrialRoleId);
			}
			if (this.TrialRoleId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TrialRoleId);
			}
			if (this.CurEnergy != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CurEnergy);
			}
			if (this.MaxEnergy != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.MaxEnergy);
			}
			if (this.EnergyCost != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.EnergyCost);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060171F1 RID: 94705 RVA: 0x0035D23C File Offset: 0x0035B43C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoleTowerRoleEnergyInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.RoleIdOrTrialRoleId != 0)
			{
				this.RoleIdOrTrialRoleId = other.RoleIdOrTrialRoleId;
			}
			if (other.TrialRoleId != 0)
			{
				this.TrialRoleId = other.TrialRoleId;
			}
			if (other.CurEnergy != 0)
			{
				this.CurEnergy = other.CurEnergy;
			}
			if (other.MaxEnergy != 0)
			{
				this.MaxEnergy = other.MaxEnergy;
			}
			if (other.EnergyCost != 0)
			{
				this.EnergyCost = other.EnergyCost;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060171F2 RID: 94706 RVA: 0x0035D2C8 File Offset: 0x0035B4C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060171F3 RID: 94707 RVA: 0x0035D2D4 File Offset: 0x0035B4D4
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
						this.RoleIdOrTrialRoleId = input.ReadInt32();
						continue;
					}
					if (num == 16U)
					{
						this.TrialRoleId = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 24U)
					{
						this.CurEnergy = input.ReadInt32();
						continue;
					}
					if (num == 32U)
					{
						this.MaxEnergy = input.ReadInt32();
						continue;
					}
					if (num == 40U)
					{
						this.EnergyCost = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04008A57 RID: 35415
		private static readonly MessageParser<RoleTowerRoleEnergyInfo> _parser = new MessageParser<RoleTowerRoleEnergyInfo>(() => new RoleTowerRoleEnergyInfo());

		// Token: 0x04008A58 RID: 35416
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008A59 RID: 35417
		public const int RoleIdOrTrialRoleIdFieldNumber = 1;

		// Token: 0x04008A5A RID: 35418
		private int roleIdOrTrialRoleId_;

		// Token: 0x04008A5B RID: 35419
		public const int TrialRoleIdFieldNumber = 2;

		// Token: 0x04008A5C RID: 35420
		private int trialRoleId_;

		// Token: 0x04008A5D RID: 35421
		public const int CurEnergyFieldNumber = 3;

		// Token: 0x04008A5E RID: 35422
		private int curEnergy_;

		// Token: 0x04008A5F RID: 35423
		public const int MaxEnergyFieldNumber = 4;

		// Token: 0x04008A60 RID: 35424
		private int maxEnergy_;

		// Token: 0x04008A61 RID: 35425
		public const int EnergyCostFieldNumber = 5;

		// Token: 0x04008A62 RID: 35426
		private int energyCost_;
	}
}
