using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001521 RID: 5409
	public sealed class WorldTeamRoleInfo : IMessage<WorldTeamRoleInfo>, IMessage, IEquatable<WorldTeamRoleInfo>, IDeepCloneable<WorldTeamRoleInfo>, IBufferMessage
	{
		// Token: 0x0601C959 RID: 117081 RVA: 0x00420C09 File Offset: 0x0041EE09
		[NullableContext(1)]
		public static WorldTeamRoleInfo Create()
		{
			return new WorldTeamRoleInfo();
		}

		// Token: 0x1700605D RID: 24669
		// (get) Token: 0x0601C95A RID: 117082 RVA: 0x00420C10 File Offset: 0x0041EE10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<WorldTeamRoleInfo> Parser
		{
			get
			{
				return WorldTeamRoleInfo._parser;
			}
		}

		// Token: 0x1700605E RID: 24670
		// (get) Token: 0x0601C95B RID: 117083 RVA: 0x00420C17 File Offset: 0x0041EE17
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700605F RID: 24671
		// (get) Token: 0x0601C95C RID: 117084 RVA: 0x00420C1A File Offset: 0x0041EE1A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return WorldTeamRoleInfo.Descriptor;
			}
		}

		// Token: 0x0601C95D RID: 117085 RVA: 0x00420C21 File Offset: 0x0041EE21
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WorldTeamRoleInfo()
		{
		}

		// Token: 0x0601C95E RID: 117086 RVA: 0x00420C29 File Offset: 0x0041EE29
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WorldTeamRoleInfo(WorldTeamRoleInfo other) : this()
		{
			this.roleId_ = other.roleId_;
			this.roleLevel_ = other.roleLevel_;
			this.roleSkinId_ = other.roleSkinId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601C95F RID: 117087 RVA: 0x00420C66 File Offset: 0x0041EE66
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WorldTeamRoleInfo Clone()
		{
			return new WorldTeamRoleInfo(this);
		}

		// Token: 0x17006060 RID: 24672
		// (get) Token: 0x0601C960 RID: 117088 RVA: 0x00420C6E File Offset: 0x0041EE6E
		// (set) Token: 0x0601C961 RID: 117089 RVA: 0x00420C76 File Offset: 0x0041EE76
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

		// Token: 0x17006061 RID: 24673
		// (get) Token: 0x0601C962 RID: 117090 RVA: 0x00420C7F File Offset: 0x0041EE7F
		// (set) Token: 0x0601C963 RID: 117091 RVA: 0x00420C87 File Offset: 0x0041EE87
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

		// Token: 0x17006062 RID: 24674
		// (get) Token: 0x0601C964 RID: 117092 RVA: 0x00420C90 File Offset: 0x0041EE90
		// (set) Token: 0x0601C965 RID: 117093 RVA: 0x00420C98 File Offset: 0x0041EE98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RoleSkinId
		{
			get
			{
				return this.roleSkinId_;
			}
			set
			{
				this.roleSkinId_ = value;
			}
		}

		// Token: 0x0601C966 RID: 117094 RVA: 0x00420CA1 File Offset: 0x0041EEA1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as WorldTeamRoleInfo);
		}

		// Token: 0x0601C967 RID: 117095 RVA: 0x00420CB0 File Offset: 0x0041EEB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(WorldTeamRoleInfo other)
		{
			return other != null && (other == this || (this.RoleId == other.RoleId && this.RoleLevel == other.RoleLevel && this.RoleSkinId == other.RoleSkinId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601C968 RID: 117096 RVA: 0x00420D0C File Offset: 0x0041EF0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.RoleId != 0)
			{
				num ^= this.RoleId.GetHashCode();
			}
			if (this.RoleLevel != 0)
			{
				num ^= this.RoleLevel.GetHashCode();
			}
			if (this.RoleSkinId != 0)
			{
				num ^= this.RoleSkinId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601C969 RID: 117097 RVA: 0x00420D7D File Offset: 0x0041EF7D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601C96A RID: 117098 RVA: 0x00420D8A File Offset: 0x0041EF8A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601C96B RID: 117099 RVA: 0x00420D94 File Offset: 0x0041EF94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.RoleId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.RoleId);
			}
			if (this.RoleLevel != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.RoleLevel);
			}
			if (this.RoleSkinId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.RoleSkinId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601C96C RID: 117100 RVA: 0x00420E08 File Offset: 0x0041F008
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.RoleId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RoleId);
			}
			if (this.RoleLevel != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RoleLevel);
			}
			if (this.RoleSkinId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RoleSkinId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601C96D RID: 117101 RVA: 0x00420E78 File Offset: 0x0041F078
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(WorldTeamRoleInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.RoleId != 0)
			{
				this.RoleId = other.RoleId;
			}
			if (other.RoleLevel != 0)
			{
				this.RoleLevel = other.RoleLevel;
			}
			if (other.RoleSkinId != 0)
			{
				this.RoleSkinId = other.RoleSkinId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601C96E RID: 117102 RVA: 0x00420EDC File Offset: 0x0041F0DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601C96F RID: 117103 RVA: 0x00420EE8 File Offset: 0x0041F0E8
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
						if (num != 24U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.RoleSkinId = input.ReadInt32();
						}
					}
					else
					{
						this.RoleLevel = input.ReadInt32();
					}
				}
				else
				{
					this.RoleId = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400A37A RID: 41850
		private static readonly MessageParser<WorldTeamRoleInfo> _parser = new MessageParser<WorldTeamRoleInfo>(() => new WorldTeamRoleInfo());

		// Token: 0x0400A37B RID: 41851
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A37C RID: 41852
		public const int RoleIdFieldNumber = 1;

		// Token: 0x0400A37D RID: 41853
		private int roleId_;

		// Token: 0x0400A37E RID: 41854
		public const int RoleLevelFieldNumber = 2;

		// Token: 0x0400A37F RID: 41855
		private int roleLevel_;

		// Token: 0x0400A380 RID: 41856
		public const int RoleSkinIdFieldNumber = 3;

		// Token: 0x0400A381 RID: 41857
		private int roleSkinId_;
	}
}
