using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020014D9 RID: 5337
	public sealed class TrialRoleItem : IMessage<TrialRoleItem>, IMessage, IEquatable<TrialRoleItem>, IDeepCloneable<TrialRoleItem>, IBufferMessage
	{
		// Token: 0x0601C4F4 RID: 115956 RVA: 0x0041BE11 File Offset: 0x0041A011
		[NullableContext(1)]
		public static TrialRoleItem Create()
		{
			return new TrialRoleItem();
		}

		// Token: 0x17005FD7 RID: 24535
		// (get) Token: 0x0601C4F5 RID: 115957 RVA: 0x0041BE18 File Offset: 0x0041A018
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<TrialRoleItem> Parser
		{
			get
			{
				return TrialRoleItem._parser;
			}
		}

		// Token: 0x17005FD8 RID: 24536
		// (get) Token: 0x0601C4F6 RID: 115958 RVA: 0x0041BE1F File Offset: 0x0041A01F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005FD9 RID: 24537
		// (get) Token: 0x0601C4F7 RID: 115959 RVA: 0x0041BE22 File Offset: 0x0041A022
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TrialRoleItem.Descriptor;
			}
		}

		// Token: 0x0601C4F8 RID: 115960 RVA: 0x0041BE29 File Offset: 0x0041A029
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrialRoleItem()
		{
		}

		// Token: 0x0601C4F9 RID: 115961 RVA: 0x0041BE31 File Offset: 0x0041A031
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrialRoleItem(TrialRoleItem other) : this()
		{
			this.roleId_ = other.roleId_;
			this.show_ = other.show_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601C4FA RID: 115962 RVA: 0x0041BE62 File Offset: 0x0041A062
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrialRoleItem Clone()
		{
			return new TrialRoleItem(this);
		}

		// Token: 0x17005FDA RID: 24538
		// (get) Token: 0x0601C4FB RID: 115963 RVA: 0x0041BE6A File Offset: 0x0041A06A
		// (set) Token: 0x0601C4FC RID: 115964 RVA: 0x0041BE72 File Offset: 0x0041A072
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

		// Token: 0x17005FDB RID: 24539
		// (get) Token: 0x0601C4FD RID: 115965 RVA: 0x0041BE7B File Offset: 0x0041A07B
		// (set) Token: 0x0601C4FE RID: 115966 RVA: 0x0041BE83 File Offset: 0x0041A083
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Show
		{
			get
			{
				return this.show_;
			}
			set
			{
				this.show_ = value;
			}
		}

		// Token: 0x0601C4FF RID: 115967 RVA: 0x0041BE8C File Offset: 0x0041A08C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TrialRoleItem);
		}

		// Token: 0x0601C500 RID: 115968 RVA: 0x0041BE9A File Offset: 0x0041A09A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TrialRoleItem other)
		{
			return other != null && (other == this || (this.RoleId == other.RoleId && this.Show == other.Show && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601C501 RID: 115969 RVA: 0x0041BED8 File Offset: 0x0041A0D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.RoleId != 0)
			{
				num ^= this.RoleId.GetHashCode();
			}
			if (this.Show)
			{
				num ^= this.Show.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601C502 RID: 115970 RVA: 0x0041BF30 File Offset: 0x0041A130
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601C503 RID: 115971 RVA: 0x0041BF3D File Offset: 0x0041A13D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601C504 RID: 115972 RVA: 0x0041BF48 File Offset: 0x0041A148
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.RoleId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.RoleId);
			}
			if (this.Show)
			{
				output.WriteRawTag(16);
				output.WriteBool(this.Show);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601C505 RID: 115973 RVA: 0x0041BFA0 File Offset: 0x0041A1A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.RoleId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RoleId);
			}
			if (this.Show)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601C506 RID: 115974 RVA: 0x0041BFEC File Offset: 0x0041A1EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TrialRoleItem other)
		{
			if (other == null)
			{
				return;
			}
			if (other.RoleId != 0)
			{
				this.RoleId = other.RoleId;
			}
			if (other.Show)
			{
				this.Show = other.Show;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601C507 RID: 115975 RVA: 0x0041C03C File Offset: 0x0041A23C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601C508 RID: 115976 RVA: 0x0041C048 File Offset: 0x0041A248
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
						this.Show = input.ReadBool();
					}
				}
				else
				{
					this.RoleId = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400A3AA RID: 41898
		private static readonly MessageParser<TrialRoleItem> _parser = new MessageParser<TrialRoleItem>(() => new TrialRoleItem());

		// Token: 0x0400A3AB RID: 41899
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A3AC RID: 41900
		public const int RoleIdFieldNumber = 1;

		// Token: 0x0400A3AD RID: 41901
		private int roleId_;

		// Token: 0x0400A3AE RID: 41902
		public const int ShowFieldNumber = 2;

		// Token: 0x0400A3AF RID: 41903
		private bool show_;
	}
}
