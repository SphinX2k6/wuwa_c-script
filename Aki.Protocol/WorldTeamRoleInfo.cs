using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001597 RID: 5527
	public sealed class WorldTeamRoleInfo : IMessage<WorldTeamRoleInfo>, IMessage, IEquatable<WorldTeamRoleInfo>, IDeepCloneable<WorldTeamRoleInfo>, IBufferMessage
	{
		// Token: 0x0601D420 RID: 119840 RVA: 0x0043C6C5 File Offset: 0x0043A8C5
		[NullableContext(1)]
		public static WorldTeamRoleInfo Create()
		{
			return new WorldTeamRoleInfo();
		}

		// Token: 0x170062FE RID: 25342
		// (get) Token: 0x0601D421 RID: 119841 RVA: 0x0043C6CC File Offset: 0x0043A8CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<WorldTeamRoleInfo> Parser
		{
			get
			{
				return WorldTeamRoleInfo._parser;
			}
		}

		// Token: 0x170062FF RID: 25343
		// (get) Token: 0x0601D422 RID: 119842 RVA: 0x0043C6D3 File Offset: 0x0043A8D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17006300 RID: 25344
		// (get) Token: 0x0601D423 RID: 119843 RVA: 0x0043C6D6 File Offset: 0x0043A8D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return WorldTeamRoleInfo.Descriptor;
			}
		}

		// Token: 0x0601D424 RID: 119844 RVA: 0x0043C6DD File Offset: 0x0043A8DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WorldTeamRoleInfo()
		{
		}

		// Token: 0x0601D425 RID: 119845 RVA: 0x0043C6E5 File Offset: 0x0043A8E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WorldTeamRoleInfo(WorldTeamRoleInfo other) : this()
		{
			this.roleId_ = other.roleId_;
			this.roleLevel_ = other.roleLevel_;
			this.roleSkinId_ = other.roleSkinId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601D426 RID: 119846 RVA: 0x0043C722 File Offset: 0x0043A922
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WorldTeamRoleInfo Clone()
		{
			return new WorldTeamRoleInfo(this);
		}

		// Token: 0x17006301 RID: 25345
		// (get) Token: 0x0601D427 RID: 119847 RVA: 0x0043C72A File Offset: 0x0043A92A
		// (set) Token: 0x0601D428 RID: 119848 RVA: 0x0043C732 File Offset: 0x0043A932
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

		// Token: 0x17006302 RID: 25346
		// (get) Token: 0x0601D429 RID: 119849 RVA: 0x0043C73B File Offset: 0x0043A93B
		// (set) Token: 0x0601D42A RID: 119850 RVA: 0x0043C743 File Offset: 0x0043A943
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

		// Token: 0x17006303 RID: 25347
		// (get) Token: 0x0601D42B RID: 119851 RVA: 0x0043C74C File Offset: 0x0043A94C
		// (set) Token: 0x0601D42C RID: 119852 RVA: 0x0043C754 File Offset: 0x0043A954
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

		// Token: 0x0601D42D RID: 119853 RVA: 0x0043C75D File Offset: 0x0043A95D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as WorldTeamRoleInfo);
		}

		// Token: 0x0601D42E RID: 119854 RVA: 0x0043C76C File Offset: 0x0043A96C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(WorldTeamRoleInfo other)
		{
			return other != null && (other == this || (this.RoleId == other.RoleId && this.RoleLevel == other.RoleLevel && this.RoleSkinId == other.RoleSkinId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601D42F RID: 119855 RVA: 0x0043C7C8 File Offset: 0x0043A9C8
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

		// Token: 0x0601D430 RID: 119856 RVA: 0x0043C839 File Offset: 0x0043AA39
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601D431 RID: 119857 RVA: 0x0043C846 File Offset: 0x0043AA46
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601D432 RID: 119858 RVA: 0x0043C850 File Offset: 0x0043AA50
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

		// Token: 0x0601D433 RID: 119859 RVA: 0x0043C8C4 File Offset: 0x0043AAC4
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

		// Token: 0x0601D434 RID: 119860 RVA: 0x0043C934 File Offset: 0x0043AB34
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

		// Token: 0x0601D435 RID: 119861 RVA: 0x0043C998 File Offset: 0x0043AB98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601D436 RID: 119862 RVA: 0x0043C9A4 File Offset: 0x0043ABA4
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

		// Token: 0x0400A7D3 RID: 42963
		private static readonly MessageParser<WorldTeamRoleInfo> _parser = new MessageParser<WorldTeamRoleInfo>(() => new WorldTeamRoleInfo());

		// Token: 0x0400A7D4 RID: 42964
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A7D5 RID: 42965
		public const int RoleIdFieldNumber = 1;

		// Token: 0x0400A7D6 RID: 42966
		private int roleId_;

		// Token: 0x0400A7D7 RID: 42967
		public const int RoleLevelFieldNumber = 2;

		// Token: 0x0400A7D8 RID: 42968
		private int roleLevel_;

		// Token: 0x0400A7D9 RID: 42969
		public const int RoleSkinIdFieldNumber = 3;

		// Token: 0x0400A7DA RID: 42970
		private int roleSkinId_;
	}
}
