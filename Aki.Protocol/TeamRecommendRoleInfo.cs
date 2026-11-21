using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020013A3 RID: 5027
	public sealed class TeamRecommendRoleInfo : IMessage<TeamRecommendRoleInfo>, IMessage, IEquatable<TeamRecommendRoleInfo>, IDeepCloneable<TeamRecommendRoleInfo>, IBufferMessage
	{
		// Token: 0x0601AC15 RID: 109589 RVA: 0x003E5791 File Offset: 0x003E3991
		[NullableContext(1)]
		public static TeamRecommendRoleInfo Create()
		{
			return new TeamRecommendRoleInfo();
		}

		// Token: 0x17005A95 RID: 23189
		// (get) Token: 0x0601AC16 RID: 109590 RVA: 0x003E5798 File Offset: 0x003E3998
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<TeamRecommendRoleInfo> Parser
		{
			get
			{
				return TeamRecommendRoleInfo._parser;
			}
		}

		// Token: 0x17005A96 RID: 23190
		// (get) Token: 0x0601AC17 RID: 109591 RVA: 0x003E579F File Offset: 0x003E399F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005A97 RID: 23191
		// (get) Token: 0x0601AC18 RID: 109592 RVA: 0x003E57A2 File Offset: 0x003E39A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TeamRecommendRoleInfo.Descriptor;
			}
		}

		// Token: 0x0601AC19 RID: 109593 RVA: 0x003E57A9 File Offset: 0x003E39A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TeamRecommendRoleInfo()
		{
		}

		// Token: 0x0601AC1A RID: 109594 RVA: 0x003E57B1 File Offset: 0x003E39B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TeamRecommendRoleInfo(TeamRecommendRoleInfo other) : this()
		{
			this.roleId_ = other.roleId_;
			this.skillBranchId_ = other.skillBranchId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601AC1B RID: 109595 RVA: 0x003E57E2 File Offset: 0x003E39E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TeamRecommendRoleInfo Clone()
		{
			return new TeamRecommendRoleInfo(this);
		}

		// Token: 0x17005A98 RID: 23192
		// (get) Token: 0x0601AC1C RID: 109596 RVA: 0x003E57EA File Offset: 0x003E39EA
		// (set) Token: 0x0601AC1D RID: 109597 RVA: 0x003E57F2 File Offset: 0x003E39F2
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

		// Token: 0x17005A99 RID: 23193
		// (get) Token: 0x0601AC1E RID: 109598 RVA: 0x003E57FB File Offset: 0x003E39FB
		// (set) Token: 0x0601AC1F RID: 109599 RVA: 0x003E5803 File Offset: 0x003E3A03
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

		// Token: 0x0601AC20 RID: 109600 RVA: 0x003E580C File Offset: 0x003E3A0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TeamRecommendRoleInfo);
		}

		// Token: 0x0601AC21 RID: 109601 RVA: 0x003E581A File Offset: 0x003E3A1A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TeamRecommendRoleInfo other)
		{
			return other != null && (other == this || (this.RoleId == other.RoleId && this.SkillBranchId == other.SkillBranchId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601AC22 RID: 109602 RVA: 0x003E5858 File Offset: 0x003E3A58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.RoleId != 0)
			{
				num ^= this.RoleId.GetHashCode();
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

		// Token: 0x0601AC23 RID: 109603 RVA: 0x003E58B0 File Offset: 0x003E3AB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601AC24 RID: 109604 RVA: 0x003E58BD File Offset: 0x003E3ABD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601AC25 RID: 109605 RVA: 0x003E58C8 File Offset: 0x003E3AC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.RoleId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.RoleId);
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

		// Token: 0x0601AC26 RID: 109606 RVA: 0x003E5920 File Offset: 0x003E3B20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.RoleId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RoleId);
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

		// Token: 0x0601AC27 RID: 109607 RVA: 0x003E5978 File Offset: 0x003E3B78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TeamRecommendRoleInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.RoleId != 0)
			{
				this.RoleId = other.RoleId;
			}
			if (other.SkillBranchId != 0)
			{
				this.SkillBranchId = other.SkillBranchId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601AC28 RID: 109608 RVA: 0x003E59C8 File Offset: 0x003E3BC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601AC29 RID: 109609 RVA: 0x003E59D4 File Offset: 0x003E3BD4
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
					this.RoleId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04009C98 RID: 40088
		private static readonly MessageParser<TeamRecommendRoleInfo> _parser = new MessageParser<TeamRecommendRoleInfo>(() => new TeamRecommendRoleInfo());

		// Token: 0x04009C99 RID: 40089
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009C9A RID: 40090
		public const int RoleIdFieldNumber = 1;

		// Token: 0x04009C9B RID: 40091
		private int roleId_;

		// Token: 0x04009C9C RID: 40092
		public const int SkillBranchIdFieldNumber = 2;

		// Token: 0x04009C9D RID: 40093
		private int skillBranchId_;
	}
}
