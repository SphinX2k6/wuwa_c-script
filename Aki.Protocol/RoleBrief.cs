using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200104A RID: 4170
	public sealed class RoleBrief : IMessage<RoleBrief>, IMessage, IEquatable<RoleBrief>, IDeepCloneable<RoleBrief>, IBufferMessage
	{
		// Token: 0x060164FD RID: 91389 RVA: 0x0033EB7A File Offset: 0x0033CD7A
		[NullableContext(1)]
		public static RoleBrief Create()
		{
			return new RoleBrief();
		}

		// Token: 0x17004AAB RID: 19115
		// (get) Token: 0x060164FE RID: 91390 RVA: 0x0033EB81 File Offset: 0x0033CD81
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RoleBrief> Parser
		{
			get
			{
				return RoleBrief._parser;
			}
		}

		// Token: 0x17004AAC RID: 19116
		// (get) Token: 0x060164FF RID: 91391 RVA: 0x0033EB88 File Offset: 0x0033CD88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004AAD RID: 19117
		// (get) Token: 0x06016500 RID: 91392 RVA: 0x0033EB8B File Offset: 0x0033CD8B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleBrief.Descriptor;
			}
		}

		// Token: 0x06016501 RID: 91393 RVA: 0x0033EB92 File Offset: 0x0033CD92
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleBrief()
		{
		}

		// Token: 0x06016502 RID: 91394 RVA: 0x0033EB9A File Offset: 0x0033CD9A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleBrief(RoleBrief other) : this()
		{
			this.roleId_ = other.roleId_;
			this.level_ = other.level_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06016503 RID: 91395 RVA: 0x0033EBCB File Offset: 0x0033CDCB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleBrief Clone()
		{
			return new RoleBrief(this);
		}

		// Token: 0x17004AAE RID: 19118
		// (get) Token: 0x06016504 RID: 91396 RVA: 0x0033EBD3 File Offset: 0x0033CDD3
		// (set) Token: 0x06016505 RID: 91397 RVA: 0x0033EBDB File Offset: 0x0033CDDB
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

		// Token: 0x17004AAF RID: 19119
		// (get) Token: 0x06016506 RID: 91398 RVA: 0x0033EBE4 File Offset: 0x0033CDE4
		// (set) Token: 0x06016507 RID: 91399 RVA: 0x0033EBEC File Offset: 0x0033CDEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Level
		{
			get
			{
				return this.level_;
			}
			set
			{
				this.level_ = value;
			}
		}

		// Token: 0x06016508 RID: 91400 RVA: 0x0033EBF5 File Offset: 0x0033CDF5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleBrief);
		}

		// Token: 0x06016509 RID: 91401 RVA: 0x0033EC03 File Offset: 0x0033CE03
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleBrief other)
		{
			return other != null && (other == this || (this.RoleId == other.RoleId && this.Level == other.Level && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601650A RID: 91402 RVA: 0x0033EC44 File Offset: 0x0033CE44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.RoleId != 0)
			{
				num ^= this.RoleId.GetHashCode();
			}
			if (this.Level != 0)
			{
				num ^= this.Level.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601650B RID: 91403 RVA: 0x0033EC9C File Offset: 0x0033CE9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601650C RID: 91404 RVA: 0x0033ECA9 File Offset: 0x0033CEA9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601650D RID: 91405 RVA: 0x0033ECB4 File Offset: 0x0033CEB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.RoleId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.RoleId);
			}
			if (this.Level != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Level);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601650E RID: 91406 RVA: 0x0033ED0C File Offset: 0x0033CF0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.RoleId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RoleId);
			}
			if (this.Level != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Level);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601650F RID: 91407 RVA: 0x0033ED64 File Offset: 0x0033CF64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoleBrief other)
		{
			if (other == null)
			{
				return;
			}
			if (other.RoleId != 0)
			{
				this.RoleId = other.RoleId;
			}
			if (other.Level != 0)
			{
				this.Level = other.Level;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06016510 RID: 91408 RVA: 0x0033EDB4 File Offset: 0x0033CFB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06016511 RID: 91409 RVA: 0x0033EDC0 File Offset: 0x0033CFC0
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
						this.Level = input.ReadInt32();
					}
				}
				else
				{
					this.RoleId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040085F5 RID: 34293
		private static readonly MessageParser<RoleBrief> _parser = new MessageParser<RoleBrief>(() => new RoleBrief());

		// Token: 0x040085F6 RID: 34294
		private UnknownFieldSet _unknownFields;

		// Token: 0x040085F7 RID: 34295
		public const int RoleIdFieldNumber = 1;

		// Token: 0x040085F8 RID: 34296
		private int roleId_;

		// Token: 0x040085F9 RID: 34297
		public const int LevelFieldNumber = 2;

		// Token: 0x040085FA RID: 34298
		private int level_;
	}
}
