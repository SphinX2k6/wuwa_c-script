using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020010A1 RID: 4257
	[NetMessage(EMessageId.RoleSkillLevelUpViewRequest)]
	public sealed class RoleSkillLevelUpViewRequest : IMessage<RoleSkillLevelUpViewRequest>, IMessage, IEquatable<RoleSkillLevelUpViewRequest>, IDeepCloneable<RoleSkillLevelUpViewRequest>, IBufferMessage
	{
		// Token: 0x06016C1E RID: 93214 RVA: 0x0034EFAE File Offset: 0x0034D1AE
		[NullableContext(1)]
		public static RoleSkillLevelUpViewRequest Create()
		{
			return new RoleSkillLevelUpViewRequest();
		}

		// Token: 0x17004C44 RID: 19524
		// (get) Token: 0x06016C1F RID: 93215 RVA: 0x0034EFB5 File Offset: 0x0034D1B5
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
		// (get) Token: 0x06016C20 RID: 93216 RVA: 0x0034EFB8 File Offset: 0x0034D1B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleSkillLevelUpViewRequest.Descriptor;
			}
		}

		// Token: 0x06016C21 RID: 93217 RVA: 0x0034EFBF File Offset: 0x0034D1BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleSkillLevelUpViewRequest()
		{
		}

		// Token: 0x06016C22 RID: 93218 RVA: 0x0034EFC7 File Offset: 0x0034D1C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleSkillLevelUpViewRequest(RoleSkillLevelUpViewRequest other) : this()
		{
			this.roleId_ = other.roleId_;
			this.skillId_ = other.skillId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06016C23 RID: 93219 RVA: 0x0034EFF8 File Offset: 0x0034D1F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleSkillLevelUpViewRequest Clone()
		{
			return new RoleSkillLevelUpViewRequest(this);
		}

		// Token: 0x17004C46 RID: 19526
		// (get) Token: 0x06016C24 RID: 93220 RVA: 0x0034F000 File Offset: 0x0034D200
		// (set) Token: 0x06016C25 RID: 93221 RVA: 0x0034F008 File Offset: 0x0034D208
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
		// (get) Token: 0x06016C26 RID: 93222 RVA: 0x0034F011 File Offset: 0x0034D211
		// (set) Token: 0x06016C27 RID: 93223 RVA: 0x0034F019 File Offset: 0x0034D219
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

		// Token: 0x06016C28 RID: 93224 RVA: 0x0034F022 File Offset: 0x0034D222
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleSkillLevelUpViewRequest);
		}

		// Token: 0x06016C29 RID: 93225 RVA: 0x0034F030 File Offset: 0x0034D230
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleSkillLevelUpViewRequest other)
		{
			return other != null && (other == this || (this.RoleId == other.RoleId && this.SkillId == other.SkillId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06016C2A RID: 93226 RVA: 0x0034F070 File Offset: 0x0034D270
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.RoleId != 0)
			{
				num ^= this.RoleId.GetHashCode();
			}
			if (this.SkillId != 0)
			{
				num ^= this.SkillId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06016C2B RID: 93227 RVA: 0x0034F0C8 File Offset: 0x0034D2C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06016C2C RID: 93228 RVA: 0x0034F0D5 File Offset: 0x0034D2D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06016C2D RID: 93229 RVA: 0x0034F0E0 File Offset: 0x0034D2E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SkillId != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.SkillId);
			}
			if (this.RoleId != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.RoleId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06016C2E RID: 93230 RVA: 0x0034F13C File Offset: 0x0034D33C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.RoleId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RoleId);
			}
			if (this.SkillId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SkillId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06016C2F RID: 93231 RVA: 0x0034F194 File Offset: 0x0034D394
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoleSkillLevelUpViewRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.RoleId != 0)
			{
				this.RoleId = other.RoleId;
			}
			if (other.SkillId != 0)
			{
				this.SkillId = other.SkillId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06016C30 RID: 93232 RVA: 0x0034F1E4 File Offset: 0x0034D3E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06016C31 RID: 93233 RVA: 0x0034F1F0 File Offset: 0x0034D3F0
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
				if (num != 64U)
				{
					if (num != 96U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.RoleId = input.ReadInt32();
					}
				}
				else
				{
					this.SkillId = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400884B RID: 34891
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400884C RID: 34892
		public const int RoleIdFieldNumber = 12;

		// Token: 0x0400884D RID: 34893
		private int roleId_;

		// Token: 0x0400884E RID: 34894
		public const int SkillIdFieldNumber = 8;

		// Token: 0x0400884F RID: 34895
		private int skillId_;
	}
}
