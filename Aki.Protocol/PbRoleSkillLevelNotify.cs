using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C01 RID: 3073
	[NetMessage(EMessageId.PbRoleSkillLevelNotify)]
	public sealed class PbRoleSkillLevelNotify : IMessage<PbRoleSkillLevelNotify>, IMessage, IEquatable<PbRoleSkillLevelNotify>, IDeepCloneable<PbRoleSkillLevelNotify>, IBufferMessage
	{
		// Token: 0x06010B4C RID: 68428 RVA: 0x00272D2D File Offset: 0x00270F2D
		[NullableContext(1)]
		public static PbRoleSkillLevelNotify Create()
		{
			return new PbRoleSkillLevelNotify();
		}

		// Token: 0x1700371F RID: 14111
		// (get) Token: 0x06010B4D RID: 68429 RVA: 0x00272D34 File Offset: 0x00270F34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003720 RID: 14112
		// (get) Token: 0x06010B4E RID: 68430 RVA: 0x00272D37 File Offset: 0x00270F37
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PbRoleSkillLevelNotify.Descriptor;
			}
		}

		// Token: 0x06010B4F RID: 68431 RVA: 0x00272D3E File Offset: 0x00270F3E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PbRoleSkillLevelNotify()
		{
		}

		// Token: 0x06010B50 RID: 68432 RVA: 0x00272D48 File Offset: 0x00270F48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PbRoleSkillLevelNotify(PbRoleSkillLevelNotify other) : this()
		{
			this.roleId_ = other.roleId_;
			this.skillInfo_ = ((other.skillInfo_ != null) ? other.skillInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06010B51 RID: 68433 RVA: 0x00272D94 File Offset: 0x00270F94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PbRoleSkillLevelNotify Clone()
		{
			return new PbRoleSkillLevelNotify(this);
		}

		// Token: 0x17003721 RID: 14113
		// (get) Token: 0x06010B52 RID: 68434 RVA: 0x00272D9C File Offset: 0x00270F9C
		// (set) Token: 0x06010B53 RID: 68435 RVA: 0x00272DA4 File Offset: 0x00270FA4
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

		// Token: 0x17003722 RID: 14114
		// (get) Token: 0x06010B54 RID: 68436 RVA: 0x00272DAD File Offset: 0x00270FAD
		// (set) Token: 0x06010B55 RID: 68437 RVA: 0x00272DB5 File Offset: 0x00270FB5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ArrayIntInt SkillInfo
		{
			get
			{
				return this.skillInfo_;
			}
			set
			{
				this.skillInfo_ = value;
			}
		}

		// Token: 0x06010B56 RID: 68438 RVA: 0x00272DBE File Offset: 0x00270FBE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PbRoleSkillLevelNotify);
		}

		// Token: 0x06010B57 RID: 68439 RVA: 0x00272DCC File Offset: 0x00270FCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PbRoleSkillLevelNotify other)
		{
			return other != null && (other == this || (this.RoleId == other.RoleId && object.Equals(this.SkillInfo, other.SkillInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06010B58 RID: 68440 RVA: 0x00272E1C File Offset: 0x0027101C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.RoleId != 0)
			{
				num ^= this.RoleId.GetHashCode();
			}
			if (this.skillInfo_ != null)
			{
				num ^= this.SkillInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06010B59 RID: 68441 RVA: 0x00272E71 File Offset: 0x00271071
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06010B5A RID: 68442 RVA: 0x00272E7E File Offset: 0x0027107E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06010B5B RID: 68443 RVA: 0x00272E88 File Offset: 0x00271088
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.skillInfo_ != null)
			{
				output.WriteRawTag(50);
				output.WriteMessage(this.SkillInfo);
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

		// Token: 0x06010B5C RID: 68444 RVA: 0x00272EE4 File Offset: 0x002710E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.RoleId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RoleId);
			}
			if (this.skillInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.SkillInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06010B5D RID: 68445 RVA: 0x00272F3C File Offset: 0x0027113C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PbRoleSkillLevelNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.RoleId != 0)
			{
				this.RoleId = other.RoleId;
			}
			if (other.skillInfo_ != null)
			{
				if (this.skillInfo_ == null)
				{
					this.SkillInfo = new ArrayIntInt();
				}
				this.SkillInfo.MergeFrom(other.SkillInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06010B5E RID: 68446 RVA: 0x00272FA4 File Offset: 0x002711A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06010B5F RID: 68447 RVA: 0x00272FB0 File Offset: 0x002711B0
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
				if (num != 50U)
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
					if (this.skillInfo_ == null)
					{
						this.SkillInfo = new ArrayIntInt();
					}
					input.ReadMessage(this.SkillInfo);
				}
			}
		}

		// Token: 0x04006A98 RID: 27288
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006A99 RID: 27289
		public const int RoleIdFieldNumber = 12;

		// Token: 0x04006A9A RID: 27290
		private int roleId_;

		// Token: 0x04006A9B RID: 27291
		public const int SkillInfoFieldNumber = 6;

		// Token: 0x04006A9C RID: 27292
		private ArrayIntInt skillInfo_;
	}
}
