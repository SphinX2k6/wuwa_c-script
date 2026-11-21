using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200014C RID: 332
	public sealed class BabelPassRoleInfo : IMessage<BabelPassRoleInfo>, IMessage, IEquatable<BabelPassRoleInfo>, IDeepCloneable<BabelPassRoleInfo>, IBufferMessage
	{
		// Token: 0x06002ABF RID: 10943 RVA: 0x000703D9 File Offset: 0x0006E5D9
		[NullableContext(1)]
		public static BabelPassRoleInfo Create()
		{
			return new BabelPassRoleInfo();
		}

		// Token: 0x17000653 RID: 1619
		// (get) Token: 0x06002AC0 RID: 10944 RVA: 0x000703E0 File Offset: 0x0006E5E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<BabelPassRoleInfo> Parser
		{
			get
			{
				return BabelPassRoleInfo._parser;
			}
		}

		// Token: 0x17000654 RID: 1620
		// (get) Token: 0x06002AC1 RID: 10945 RVA: 0x000703E7 File Offset: 0x0006E5E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000655 RID: 1621
		// (get) Token: 0x06002AC2 RID: 10946 RVA: 0x000703EA File Offset: 0x0006E5EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BabelPassRoleInfo.Descriptor;
			}
		}

		// Token: 0x06002AC3 RID: 10947 RVA: 0x000703F1 File Offset: 0x0006E5F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BabelPassRoleInfo()
		{
		}

		// Token: 0x06002AC4 RID: 10948 RVA: 0x000703F9 File Offset: 0x0006E5F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BabelPassRoleInfo(BabelPassRoleInfo other) : this()
		{
			this.roleId_ = other.roleId_;
			this.roleLevel_ = other.roleLevel_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002AC5 RID: 10949 RVA: 0x0007042A File Offset: 0x0006E62A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BabelPassRoleInfo Clone()
		{
			return new BabelPassRoleInfo(this);
		}

		// Token: 0x17000656 RID: 1622
		// (get) Token: 0x06002AC6 RID: 10950 RVA: 0x00070432 File Offset: 0x0006E632
		// (set) Token: 0x06002AC7 RID: 10951 RVA: 0x0007043A File Offset: 0x0006E63A
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

		// Token: 0x17000657 RID: 1623
		// (get) Token: 0x06002AC8 RID: 10952 RVA: 0x00070443 File Offset: 0x0006E643
		// (set) Token: 0x06002AC9 RID: 10953 RVA: 0x0007044B File Offset: 0x0006E64B
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

		// Token: 0x06002ACA RID: 10954 RVA: 0x00070454 File Offset: 0x0006E654
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BabelPassRoleInfo);
		}

		// Token: 0x06002ACB RID: 10955 RVA: 0x00070462 File Offset: 0x0006E662
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BabelPassRoleInfo other)
		{
			return other != null && (other == this || (this.RoleId == other.RoleId && this.RoleLevel == other.RoleLevel && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002ACC RID: 10956 RVA: 0x000704A0 File Offset: 0x0006E6A0
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
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06002ACD RID: 10957 RVA: 0x000704F8 File Offset: 0x0006E6F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06002ACE RID: 10958 RVA: 0x00070505 File Offset: 0x0006E705
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002ACF RID: 10959 RVA: 0x00070510 File Offset: 0x0006E710
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
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002AD0 RID: 10960 RVA: 0x00070568 File Offset: 0x0006E768
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
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06002AD1 RID: 10961 RVA: 0x000705C0 File Offset: 0x0006E7C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BabelPassRoleInfo other)
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
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06002AD2 RID: 10962 RVA: 0x00070610 File Offset: 0x0006E810
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002AD3 RID: 10963 RVA: 0x0007061C File Offset: 0x0006E81C
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
						this.RoleLevel = input.ReadInt32();
					}
				}
				else
				{
					this.RoleId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040027CD RID: 10189
		private static readonly MessageParser<BabelPassRoleInfo> _parser = new MessageParser<BabelPassRoleInfo>(() => new BabelPassRoleInfo());

		// Token: 0x040027CE RID: 10190
		private UnknownFieldSet _unknownFields;

		// Token: 0x040027CF RID: 10191
		public const int RoleIdFieldNumber = 1;

		// Token: 0x040027D0 RID: 10192
		private int roleId_;

		// Token: 0x040027D1 RID: 10193
		public const int RoleLevelFieldNumber = 2;

		// Token: 0x040027D2 RID: 10194
		private int roleLevel_;
	}
}
