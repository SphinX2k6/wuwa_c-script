using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C11 RID: 3089
	[NetMessage(EMessageId.PbRoleSkillLevelNotify)]
	public sealed class PbRoleSkillLevelNotify : IMessage<PbRoleSkillLevelNotify>, IMessage, IEquatable<PbRoleSkillLevelNotify>, IDeepCloneable<PbRoleSkillLevelNotify>, IBufferMessage
	{
		// Token: 0x06010C4C RID: 68684 RVA: 0x00274A99 File Offset: 0x00272C99
		[NullableContext(1)]
		public static PbRoleSkillLevelNotify Create()
		{
			return new PbRoleSkillLevelNotify();
		}

		// Token: 0x17003756 RID: 14166
		// (get) Token: 0x06010C4D RID: 68685 RVA: 0x00274AA0 File Offset: 0x00272CA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003757 RID: 14167
		// (get) Token: 0x06010C4E RID: 68686 RVA: 0x00274AA3 File Offset: 0x00272CA3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PbRoleSkillLevelNotify.Descriptor;
			}
		}

		// Token: 0x06010C4F RID: 68687 RVA: 0x00274AAA File Offset: 0x00272CAA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PbRoleSkillLevelNotify()
		{
		}

		// Token: 0x06010C50 RID: 68688 RVA: 0x00274AB4 File Offset: 0x00272CB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PbRoleSkillLevelNotify(PbRoleSkillLevelNotify other) : this()
		{
			this.roleId_ = other.roleId_;
			this.skillInfo_ = ((other.skillInfo_ != null) ? other.skillInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06010C51 RID: 68689 RVA: 0x00274B00 File Offset: 0x00272D00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PbRoleSkillLevelNotify Clone()
		{
			return new PbRoleSkillLevelNotify(this);
		}

		// Token: 0x17003758 RID: 14168
		// (get) Token: 0x06010C52 RID: 68690 RVA: 0x00274B08 File Offset: 0x00272D08
		// (set) Token: 0x06010C53 RID: 68691 RVA: 0x00274B10 File Offset: 0x00272D10
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

		// Token: 0x17003759 RID: 14169
		// (get) Token: 0x06010C54 RID: 68692 RVA: 0x00274B19 File Offset: 0x00272D19
		// (set) Token: 0x06010C55 RID: 68693 RVA: 0x00274B21 File Offset: 0x00272D21
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

		// Token: 0x06010C56 RID: 68694 RVA: 0x00274B2A File Offset: 0x00272D2A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PbRoleSkillLevelNotify);
		}

		// Token: 0x06010C57 RID: 68695 RVA: 0x00274B38 File Offset: 0x00272D38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PbRoleSkillLevelNotify other)
		{
			return other != null && (other == this || (this.RoleId == other.RoleId && object.Equals(this.SkillInfo, other.SkillInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06010C58 RID: 68696 RVA: 0x00274B88 File Offset: 0x00272D88
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

		// Token: 0x06010C59 RID: 68697 RVA: 0x00274BDD File Offset: 0x00272DDD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06010C5A RID: 68698 RVA: 0x00274BEA File Offset: 0x00272DEA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06010C5B RID: 68699 RVA: 0x00274BF4 File Offset: 0x00272DF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.RoleId != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.RoleId);
			}
			if (this.skillInfo_ != null)
			{
				output.WriteRawTag(82);
				output.WriteMessage(this.SkillInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06010C5C RID: 68700 RVA: 0x00274C50 File Offset: 0x00272E50
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

		// Token: 0x06010C5D RID: 68701 RVA: 0x00274CA8 File Offset: 0x00272EA8
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

		// Token: 0x06010C5E RID: 68702 RVA: 0x00274D10 File Offset: 0x00272F10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06010C5F RID: 68703 RVA: 0x00274D1C File Offset: 0x00272F1C
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
				if (num != 40U)
				{
					if (num != 82U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
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
				else
				{
					this.RoleId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04006A84 RID: 27268
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006A85 RID: 27269
		public const int RoleIdFieldNumber = 5;

		// Token: 0x04006A86 RID: 27270
		private int roleId_;

		// Token: 0x04006A87 RID: 27271
		public const int SkillInfoFieldNumber = 10;

		// Token: 0x04006A88 RID: 27272
		private ArrayIntInt skillInfo_;
	}
}
