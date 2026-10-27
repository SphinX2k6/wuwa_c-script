using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000149 RID: 329
	public sealed class BabelPassRoleInfo : IMessage<BabelPassRoleInfo>, IMessage, IEquatable<BabelPassRoleInfo>, IDeepCloneable<BabelPassRoleInfo>, IBufferMessage
	{
		// Token: 0x06002A48 RID: 10824 RVA: 0x0006EFA5 File Offset: 0x0006D1A5
		[NullableContext(1)]
		public static BabelPassRoleInfo Create()
		{
			return new BabelPassRoleInfo();
		}

		// Token: 0x1700063F RID: 1599
		// (get) Token: 0x06002A49 RID: 10825 RVA: 0x0006EFAC File Offset: 0x0006D1AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<BabelPassRoleInfo> Parser
		{
			get
			{
				return BabelPassRoleInfo._parser;
			}
		}

		// Token: 0x17000640 RID: 1600
		// (get) Token: 0x06002A4A RID: 10826 RVA: 0x0006EFB3 File Offset: 0x0006D1B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000641 RID: 1601
		// (get) Token: 0x06002A4B RID: 10827 RVA: 0x0006EFB6 File Offset: 0x0006D1B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BabelPassRoleInfo.Descriptor;
			}
		}

		// Token: 0x06002A4C RID: 10828 RVA: 0x0006EFBD File Offset: 0x0006D1BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BabelPassRoleInfo()
		{
		}

		// Token: 0x06002A4D RID: 10829 RVA: 0x0006EFC5 File Offset: 0x0006D1C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BabelPassRoleInfo(BabelPassRoleInfo other) : this()
		{
			this.roleId_ = other.roleId_;
			this.roleLevel_ = other.roleLevel_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002A4E RID: 10830 RVA: 0x0006EFF6 File Offset: 0x0006D1F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BabelPassRoleInfo Clone()
		{
			return new BabelPassRoleInfo(this);
		}

		// Token: 0x17000642 RID: 1602
		// (get) Token: 0x06002A4F RID: 10831 RVA: 0x0006EFFE File Offset: 0x0006D1FE
		// (set) Token: 0x06002A50 RID: 10832 RVA: 0x0006F006 File Offset: 0x0006D206
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

		// Token: 0x17000643 RID: 1603
		// (get) Token: 0x06002A51 RID: 10833 RVA: 0x0006F00F File Offset: 0x0006D20F
		// (set) Token: 0x06002A52 RID: 10834 RVA: 0x0006F017 File Offset: 0x0006D217
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

		// Token: 0x06002A53 RID: 10835 RVA: 0x0006F020 File Offset: 0x0006D220
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BabelPassRoleInfo);
		}

		// Token: 0x06002A54 RID: 10836 RVA: 0x0006F02E File Offset: 0x0006D22E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BabelPassRoleInfo other)
		{
			return other != null && (other == this || (this.RoleId == other.RoleId && this.RoleLevel == other.RoleLevel && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002A55 RID: 10837 RVA: 0x0006F06C File Offset: 0x0006D26C
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

		// Token: 0x06002A56 RID: 10838 RVA: 0x0006F0C4 File Offset: 0x0006D2C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06002A57 RID: 10839 RVA: 0x0006F0D1 File Offset: 0x0006D2D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002A58 RID: 10840 RVA: 0x0006F0DC File Offset: 0x0006D2DC
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

		// Token: 0x06002A59 RID: 10841 RVA: 0x0006F134 File Offset: 0x0006D334
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

		// Token: 0x06002A5A RID: 10842 RVA: 0x0006F18C File Offset: 0x0006D38C
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

		// Token: 0x06002A5B RID: 10843 RVA: 0x0006F1DC File Offset: 0x0006D3DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002A5C RID: 10844 RVA: 0x0006F1E8 File Offset: 0x0006D3E8
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

		// Token: 0x04002759 RID: 10073
		private static readonly MessageParser<BabelPassRoleInfo> _parser = new MessageParser<BabelPassRoleInfo>(() => new BabelPassRoleInfo());

		// Token: 0x0400275A RID: 10074
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400275B RID: 10075
		public const int RoleIdFieldNumber = 1;

		// Token: 0x0400275C RID: 10076
		private int roleId_;

		// Token: 0x0400275D RID: 10077
		public const int RoleLevelFieldNumber = 2;

		// Token: 0x0400275E RID: 10078
		private int roleLevel_;
	}
}
