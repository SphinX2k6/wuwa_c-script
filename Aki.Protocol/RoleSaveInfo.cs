using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001096 RID: 4246
	public sealed class RoleSaveInfo : IMessage<RoleSaveInfo>, IMessage, IEquatable<RoleSaveInfo>, IDeepCloneable<RoleSaveInfo>, IBufferMessage
	{
		// Token: 0x06016B45 RID: 92997 RVA: 0x0034D556 File Offset: 0x0034B756
		[NullableContext(1)]
		public static RoleSaveInfo Create()
		{
			return new RoleSaveInfo();
		}

		// Token: 0x17004C19 RID: 19481
		// (get) Token: 0x06016B46 RID: 92998 RVA: 0x0034D55D File Offset: 0x0034B75D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RoleSaveInfo> Parser
		{
			get
			{
				return RoleSaveInfo._parser;
			}
		}

		// Token: 0x17004C1A RID: 19482
		// (get) Token: 0x06016B47 RID: 92999 RVA: 0x0034D564 File Offset: 0x0034B764
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004C1B RID: 19483
		// (get) Token: 0x06016B48 RID: 93000 RVA: 0x0034D567 File Offset: 0x0034B767
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleSaveInfo.Descriptor;
			}
		}

		// Token: 0x06016B49 RID: 93001 RVA: 0x0034D56E File Offset: 0x0034B76E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleSaveInfo()
		{
		}

		// Token: 0x06016B4A RID: 93002 RVA: 0x0034D584 File Offset: 0x0034B784
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleSaveInfo(RoleSaveInfo other) : this()
		{
			this.roleId_ = other.roleId_;
			this.weaponIncId_ = other.weaponIncId_;
			this.phantomIncId_ = other.phantomIncId_.Clone();
			this.skillBranchId_ = other.skillBranchId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06016B4B RID: 93003 RVA: 0x0034D5DD File Offset: 0x0034B7DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleSaveInfo Clone()
		{
			return new RoleSaveInfo(this);
		}

		// Token: 0x17004C1C RID: 19484
		// (get) Token: 0x06016B4C RID: 93004 RVA: 0x0034D5E5 File Offset: 0x0034B7E5
		// (set) Token: 0x06016B4D RID: 93005 RVA: 0x0034D5ED File Offset: 0x0034B7ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RoleId
		{
			get
			{
				return this.roleId_;
			}
			set
			{
				this.roleId_ = value;
			}
		}

		// Token: 0x17004C1D RID: 19485
		// (get) Token: 0x06016B4E RID: 93006 RVA: 0x0034D5F6 File Offset: 0x0034B7F6
		// (set) Token: 0x06016B4F RID: 93007 RVA: 0x0034D5FE File Offset: 0x0034B7FE
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

		// Token: 0x17004C1E RID: 19486
		// (get) Token: 0x06016B50 RID: 93008 RVA: 0x0034D607 File Offset: 0x0034B807
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> PhantomIncId
		{
			get
			{
				return this.phantomIncId_;
			}
		}

		// Token: 0x17004C1F RID: 19487
		// (get) Token: 0x06016B51 RID: 93009 RVA: 0x0034D60F File Offset: 0x0034B80F
		// (set) Token: 0x06016B52 RID: 93010 RVA: 0x0034D617 File Offset: 0x0034B817
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

		// Token: 0x06016B53 RID: 93011 RVA: 0x0034D620 File Offset: 0x0034B820
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleSaveInfo);
		}

		// Token: 0x06016B54 RID: 93012 RVA: 0x0034D630 File Offset: 0x0034B830
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleSaveInfo other)
		{
			return other != null && (other == this || (this.RoleId == other.RoleId && this.WeaponIncId == other.WeaponIncId && this.phantomIncId_.Equals(other.phantomIncId_) && this.SkillBranchId == other.SkillBranchId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06016B55 RID: 93013 RVA: 0x0034D6A0 File Offset: 0x0034B8A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.RoleId != 0)
			{
				num ^= this.RoleId.GetHashCode();
			}
			if (this.WeaponIncId != 0)
			{
				num ^= this.WeaponIncId.GetHashCode();
			}
			num ^= this.phantomIncId_.GetHashCode();
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

		// Token: 0x06016B56 RID: 93014 RVA: 0x0034D71F File Offset: 0x0034B91F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06016B57 RID: 93015 RVA: 0x0034D72C File Offset: 0x0034B92C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06016B58 RID: 93016 RVA: 0x0034D738 File Offset: 0x0034B938
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.RoleId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.RoleId);
			}
			if (this.WeaponIncId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.WeaponIncId);
			}
			this.phantomIncId_.WriteTo(ref output, RoleSaveInfo._repeated_phantomIncId_codec);
			if (this.SkillBranchId != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.SkillBranchId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06016B59 RID: 93017 RVA: 0x0034D7C0 File Offset: 0x0034B9C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.RoleId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RoleId);
			}
			if (this.WeaponIncId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.WeaponIncId);
			}
			num += this.phantomIncId_.CalculateSize(RoleSaveInfo._repeated_phantomIncId_codec);
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

		// Token: 0x06016B5A RID: 93018 RVA: 0x0034D844 File Offset: 0x0034BA44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoleSaveInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.RoleId != 0)
			{
				this.RoleId = other.RoleId;
			}
			if (other.WeaponIncId != 0)
			{
				this.WeaponIncId = other.WeaponIncId;
			}
			this.phantomIncId_.Add(other.phantomIncId_);
			if (other.SkillBranchId != 0)
			{
				this.SkillBranchId = other.SkillBranchId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06016B5B RID: 93019 RVA: 0x0034D8B9 File Offset: 0x0034BAB9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06016B5C RID: 93020 RVA: 0x0034D8C4 File Offset: 0x0034BAC4
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
						this.RoleId = input.ReadInt32();
						continue;
					}
					if (num == 16U)
					{
						this.WeaponIncId = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 24U || num == 26U)
					{
						this.phantomIncId_.AddEntriesFrom(ref input, RoleSaveInfo._repeated_phantomIncId_codec);
						continue;
					}
					if (num == 32U)
					{
						this.SkillBranchId = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04008816 RID: 34838
		private static readonly MessageParser<RoleSaveInfo> _parser = new MessageParser<RoleSaveInfo>(() => new RoleSaveInfo());

		// Token: 0x04008817 RID: 34839
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008818 RID: 34840
		public const int RoleIdFieldNumber = 1;

		// Token: 0x04008819 RID: 34841
		private int roleId_;

		// Token: 0x0400881A RID: 34842
		public const int WeaponIncIdFieldNumber = 2;

		// Token: 0x0400881B RID: 34843
		private int weaponIncId_;

		// Token: 0x0400881C RID: 34844
		public const int PhantomIncIdFieldNumber = 3;

		// Token: 0x0400881D RID: 34845
		private static readonly FieldCodec<int> _repeated_phantomIncId_codec = FieldCodec.ForInt32(26U);

		// Token: 0x0400881E RID: 34846
		private readonly RepeatedField<int> phantomIncId_ = new RepeatedField<int>();

		// Token: 0x0400881F RID: 34847
		public const int SkillBranchIdFieldNumber = 4;

		// Token: 0x04008820 RID: 34848
		private int skillBranchId_;
	}
}
