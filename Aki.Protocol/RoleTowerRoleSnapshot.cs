using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020010E5 RID: 4325
	public sealed class RoleTowerRoleSnapshot : IMessage<RoleTowerRoleSnapshot>, IMessage, IEquatable<RoleTowerRoleSnapshot>, IDeepCloneable<RoleTowerRoleSnapshot>, IBufferMessage
	{
		// Token: 0x060171F5 RID: 94709 RVA: 0x0035D38A File Offset: 0x0035B58A
		[NullableContext(1)]
		public static RoleTowerRoleSnapshot Create()
		{
			return new RoleTowerRoleSnapshot();
		}

		// Token: 0x17004DA4 RID: 19876
		// (get) Token: 0x060171F6 RID: 94710 RVA: 0x0035D391 File Offset: 0x0035B591
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RoleTowerRoleSnapshot> Parser
		{
			get
			{
				return RoleTowerRoleSnapshot._parser;
			}
		}

		// Token: 0x17004DA5 RID: 19877
		// (get) Token: 0x060171F7 RID: 94711 RVA: 0x0035D398 File Offset: 0x0035B598
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004DA6 RID: 19878
		// (get) Token: 0x060171F8 RID: 94712 RVA: 0x0035D39B File Offset: 0x0035B59B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleTowerRoleSnapshot.Descriptor;
			}
		}

		// Token: 0x060171F9 RID: 94713 RVA: 0x0035D3A2 File Offset: 0x0035B5A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTowerRoleSnapshot()
		{
		}

		// Token: 0x060171FA RID: 94714 RVA: 0x0035D3B8 File Offset: 0x0035B5B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTowerRoleSnapshot(RoleTowerRoleSnapshot other) : this()
		{
			this.roleIdOrTrialRoleId_ = other.roleIdOrTrialRoleId_;
			this.roleLevel_ = other.roleLevel_;
			this.weaponIncId_ = other.weaponIncId_;
			this.phantomIncIds_ = other.phantomIncIds_.Clone();
			this.skillBranchId_ = other.skillBranchId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060171FB RID: 94715 RVA: 0x0035D41D File Offset: 0x0035B61D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTowerRoleSnapshot Clone()
		{
			return new RoleTowerRoleSnapshot(this);
		}

		// Token: 0x17004DA7 RID: 19879
		// (get) Token: 0x060171FC RID: 94716 RVA: 0x0035D425 File Offset: 0x0035B625
		// (set) Token: 0x060171FD RID: 94717 RVA: 0x0035D42D File Offset: 0x0035B62D
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

		// Token: 0x17004DA8 RID: 19880
		// (get) Token: 0x060171FE RID: 94718 RVA: 0x0035D436 File Offset: 0x0035B636
		// (set) Token: 0x060171FF RID: 94719 RVA: 0x0035D43E File Offset: 0x0035B63E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RoleLevel
		{
			get
			{
				return this.roleLevel_;
			}
			set
			{
				this.roleLevel_ = value;
			}
		}

		// Token: 0x17004DA9 RID: 19881
		// (get) Token: 0x06017200 RID: 94720 RVA: 0x0035D447 File Offset: 0x0035B647
		// (set) Token: 0x06017201 RID: 94721 RVA: 0x0035D44F File Offset: 0x0035B64F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int WeaponIncId
		{
			get
			{
				return this.weaponIncId_;
			}
			set
			{
				this.weaponIncId_ = value;
			}
		}

		// Token: 0x17004DAA RID: 19882
		// (get) Token: 0x06017202 RID: 94722 RVA: 0x0035D458 File Offset: 0x0035B658
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> PhantomIncIds
		{
			get
			{
				return this.phantomIncIds_;
			}
		}

		// Token: 0x17004DAB RID: 19883
		// (get) Token: 0x06017203 RID: 94723 RVA: 0x0035D460 File Offset: 0x0035B660
		// (set) Token: 0x06017204 RID: 94724 RVA: 0x0035D468 File Offset: 0x0035B668
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

		// Token: 0x06017205 RID: 94725 RVA: 0x0035D471 File Offset: 0x0035B671
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleTowerRoleSnapshot);
		}

		// Token: 0x06017206 RID: 94726 RVA: 0x0035D480 File Offset: 0x0035B680
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleTowerRoleSnapshot other)
		{
			return other != null && (other == this || (this.RoleIdOrTrialRoleId == other.RoleIdOrTrialRoleId && this.RoleLevel == other.RoleLevel && this.WeaponIncId == other.WeaponIncId && this.phantomIncIds_.Equals(other.phantomIncIds_) && this.SkillBranchId == other.SkillBranchId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06017207 RID: 94727 RVA: 0x0035D500 File Offset: 0x0035B700
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.RoleIdOrTrialRoleId != 0)
			{
				num ^= this.RoleIdOrTrialRoleId.GetHashCode();
			}
			if (this.RoleLevel != 0)
			{
				num ^= this.RoleLevel.GetHashCode();
			}
			if (this.WeaponIncId != 0)
			{
				num ^= this.WeaponIncId.GetHashCode();
			}
			num ^= this.phantomIncIds_.GetHashCode();
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

		// Token: 0x06017208 RID: 94728 RVA: 0x0035D598 File Offset: 0x0035B798
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06017209 RID: 94729 RVA: 0x0035D5A5 File Offset: 0x0035B7A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601720A RID: 94730 RVA: 0x0035D5B0 File Offset: 0x0035B7B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.RoleIdOrTrialRoleId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.RoleIdOrTrialRoleId);
			}
			if (this.RoleLevel != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.RoleLevel);
			}
			if (this.WeaponIncId != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.WeaponIncId);
			}
			this.phantomIncIds_.WriteTo(ref output, RoleTowerRoleSnapshot._repeated_phantomIncIds_codec);
			if (this.SkillBranchId != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.SkillBranchId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601720B RID: 94731 RVA: 0x0035D654 File Offset: 0x0035B854
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.RoleIdOrTrialRoleId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RoleIdOrTrialRoleId);
			}
			if (this.RoleLevel != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RoleLevel);
			}
			if (this.WeaponIncId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.WeaponIncId);
			}
			num += this.phantomIncIds_.CalculateSize(RoleTowerRoleSnapshot._repeated_phantomIncIds_codec);
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

		// Token: 0x0601720C RID: 94732 RVA: 0x0035D6F0 File Offset: 0x0035B8F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoleTowerRoleSnapshot other)
		{
			if (other == null)
			{
				return;
			}
			if (other.RoleIdOrTrialRoleId != 0)
			{
				this.RoleIdOrTrialRoleId = other.RoleIdOrTrialRoleId;
			}
			if (other.RoleLevel != 0)
			{
				this.RoleLevel = other.RoleLevel;
			}
			if (other.WeaponIncId != 0)
			{
				this.WeaponIncId = other.WeaponIncId;
			}
			this.phantomIncIds_.Add(other.phantomIncIds_);
			if (other.SkillBranchId != 0)
			{
				this.SkillBranchId = other.SkillBranchId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601720D RID: 94733 RVA: 0x0035D779 File Offset: 0x0035B979
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601720E RID: 94734 RVA: 0x0035D784 File Offset: 0x0035B984
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
				if (num <= 40U)
				{
					if (num == 8U)
					{
						this.RoleIdOrTrialRoleId = input.ReadInt32();
						continue;
					}
					if (num == 24U)
					{
						this.RoleLevel = input.ReadInt32();
						continue;
					}
					if (num == 40U)
					{
						this.WeaponIncId = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 48U || num == 50U)
					{
						this.phantomIncIds_.AddEntriesFrom(ref input, RoleTowerRoleSnapshot._repeated_phantomIncIds_codec);
						continue;
					}
					if (num == 56U)
					{
						this.SkillBranchId = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04008A63 RID: 35427
		private static readonly MessageParser<RoleTowerRoleSnapshot> _parser = new MessageParser<RoleTowerRoleSnapshot>(() => new RoleTowerRoleSnapshot());

		// Token: 0x04008A64 RID: 35428
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008A65 RID: 35429
		public const int RoleIdOrTrialRoleIdFieldNumber = 1;

		// Token: 0x04008A66 RID: 35430
		private int roleIdOrTrialRoleId_;

		// Token: 0x04008A67 RID: 35431
		public const int RoleLevelFieldNumber = 3;

		// Token: 0x04008A68 RID: 35432
		private int roleLevel_;

		// Token: 0x04008A69 RID: 35433
		public const int WeaponIncIdFieldNumber = 5;

		// Token: 0x04008A6A RID: 35434
		private int weaponIncId_;

		// Token: 0x04008A6B RID: 35435
		public const int PhantomIncIdsFieldNumber = 6;

		// Token: 0x04008A6C RID: 35436
		private static readonly FieldCodec<int> _repeated_phantomIncIds_codec = FieldCodec.ForInt32(50U);

		// Token: 0x04008A6D RID: 35437
		private readonly RepeatedField<int> phantomIncIds_ = new RepeatedField<int>();

		// Token: 0x04008A6E RID: 35438
		public const int SkillBranchIdFieldNumber = 7;

		// Token: 0x04008A6F RID: 35439
		private int skillBranchId_;
	}
}
