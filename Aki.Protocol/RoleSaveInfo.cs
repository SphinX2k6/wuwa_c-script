using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020010A6 RID: 4262
	public sealed class RoleSaveInfo : IMessage<RoleSaveInfo>, IMessage, IEquatable<RoleSaveInfo>, IDeepCloneable<RoleSaveInfo>, IBufferMessage
	{
		// Token: 0x06016C2A RID: 93226 RVA: 0x0034EC33 File Offset: 0x0034CE33
		[NullableContext(1)]
		public static RoleSaveInfo Create()
		{
			return new RoleSaveInfo();
		}

		// Token: 0x17004C43 RID: 19523
		// (get) Token: 0x06016C2B RID: 93227 RVA: 0x0034EC3A File Offset: 0x0034CE3A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RoleSaveInfo> Parser
		{
			get
			{
				return RoleSaveInfo._parser;
			}
		}

		// Token: 0x17004C44 RID: 19524
		// (get) Token: 0x06016C2C RID: 93228 RVA: 0x0034EC41 File Offset: 0x0034CE41
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004C45 RID: 19525
		// (get) Token: 0x06016C2D RID: 93229 RVA: 0x0034EC44 File Offset: 0x0034CE44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleSaveInfo.Descriptor;
			}
		}

		// Token: 0x06016C2E RID: 93230 RVA: 0x0034EC4B File Offset: 0x0034CE4B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleSaveInfo()
		{
		}

		// Token: 0x06016C2F RID: 93231 RVA: 0x0034EC60 File Offset: 0x0034CE60
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

		// Token: 0x06016C30 RID: 93232 RVA: 0x0034ECB9 File Offset: 0x0034CEB9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleSaveInfo Clone()
		{
			return new RoleSaveInfo(this);
		}

		// Token: 0x17004C46 RID: 19526
		// (get) Token: 0x06016C31 RID: 93233 RVA: 0x0034ECC1 File Offset: 0x0034CEC1
		// (set) Token: 0x06016C32 RID: 93234 RVA: 0x0034ECC9 File Offset: 0x0034CEC9
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

		// Token: 0x17004C47 RID: 19527
		// (get) Token: 0x06016C33 RID: 93235 RVA: 0x0034ECD2 File Offset: 0x0034CED2
		// (set) Token: 0x06016C34 RID: 93236 RVA: 0x0034ECDA File Offset: 0x0034CEDA
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

		// Token: 0x17004C48 RID: 19528
		// (get) Token: 0x06016C35 RID: 93237 RVA: 0x0034ECE3 File Offset: 0x0034CEE3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> PhantomIncId
		{
			get
			{
				return this.phantomIncId_;
			}
		}

		// Token: 0x17004C49 RID: 19529
		// (get) Token: 0x06016C36 RID: 93238 RVA: 0x0034ECEB File Offset: 0x0034CEEB
		// (set) Token: 0x06016C37 RID: 93239 RVA: 0x0034ECF3 File Offset: 0x0034CEF3
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

		// Token: 0x06016C38 RID: 93240 RVA: 0x0034ECFC File Offset: 0x0034CEFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleSaveInfo);
		}

		// Token: 0x06016C39 RID: 93241 RVA: 0x0034ED0C File Offset: 0x0034CF0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleSaveInfo other)
		{
			return other != null && (other == this || (this.RoleId == other.RoleId && this.WeaponIncId == other.WeaponIncId && this.phantomIncId_.Equals(other.phantomIncId_) && this.SkillBranchId == other.SkillBranchId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06016C3A RID: 93242 RVA: 0x0034ED7C File Offset: 0x0034CF7C
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

		// Token: 0x06016C3B RID: 93243 RVA: 0x0034EDFB File Offset: 0x0034CFFB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06016C3C RID: 93244 RVA: 0x0034EE08 File Offset: 0x0034D008
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06016C3D RID: 93245 RVA: 0x0034EE14 File Offset: 0x0034D014
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

		// Token: 0x06016C3E RID: 93246 RVA: 0x0034EE9C File Offset: 0x0034D09C
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

		// Token: 0x06016C3F RID: 93247 RVA: 0x0034EF20 File Offset: 0x0034D120
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

		// Token: 0x06016C40 RID: 93248 RVA: 0x0034EF95 File Offset: 0x0034D195
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06016C41 RID: 93249 RVA: 0x0034EFA0 File Offset: 0x0034D1A0
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

		// Token: 0x040087EC RID: 34796
		private static readonly MessageParser<RoleSaveInfo> _parser = new MessageParser<RoleSaveInfo>(() => new RoleSaveInfo());

		// Token: 0x040087ED RID: 34797
		private UnknownFieldSet _unknownFields;

		// Token: 0x040087EE RID: 34798
		public const int RoleIdFieldNumber = 1;

		// Token: 0x040087EF RID: 34799
		private int roleId_;

		// Token: 0x040087F0 RID: 34800
		public const int WeaponIncIdFieldNumber = 2;

		// Token: 0x040087F1 RID: 34801
		private int weaponIncId_;

		// Token: 0x040087F2 RID: 34802
		public const int PhantomIncIdFieldNumber = 3;

		// Token: 0x040087F3 RID: 34803
		private static readonly FieldCodec<int> _repeated_phantomIncId_codec = FieldCodec.ForInt32(26U);

		// Token: 0x040087F4 RID: 34804
		private readonly RepeatedField<int> phantomIncId_ = new RepeatedField<int>();

		// Token: 0x040087F5 RID: 34805
		public const int SkillBranchIdFieldNumber = 4;

		// Token: 0x040087F6 RID: 34806
		private int skillBranchId_;
	}
}
