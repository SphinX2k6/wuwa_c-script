using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D48 RID: 3400
	public sealed class PinballRoleData : IMessage<PinballRoleData>, IMessage, IEquatable<PinballRoleData>, IDeepCloneable<PinballRoleData>, IBufferMessage
	{
		// Token: 0x060125E2 RID: 75234 RVA: 0x002AEE2E File Offset: 0x002AD02E
		[NullableContext(1)]
		public static PinballRoleData Create()
		{
			return new PinballRoleData();
		}

		// Token: 0x17003CE5 RID: 15589
		// (get) Token: 0x060125E3 RID: 75235 RVA: 0x002AEE35 File Offset: 0x002AD035
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PinballRoleData> Parser
		{
			get
			{
				return PinballRoleData._parser;
			}
		}

		// Token: 0x17003CE6 RID: 15590
		// (get) Token: 0x060125E4 RID: 75236 RVA: 0x002AEE3C File Offset: 0x002AD03C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003CE7 RID: 15591
		// (get) Token: 0x060125E5 RID: 75237 RVA: 0x002AEE3F File Offset: 0x002AD03F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PinballRoleData.Descriptor;
			}
		}

		// Token: 0x060125E6 RID: 75238 RVA: 0x002AEE46 File Offset: 0x002AD046
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballRoleData()
		{
		}

		// Token: 0x060125E7 RID: 75239 RVA: 0x002AEE4E File Offset: 0x002AD04E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballRoleData(PinballRoleData other) : this()
		{
			this.configId_ = other.configId_;
			this.roleLevel_ = other.roleLevel_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060125E8 RID: 75240 RVA: 0x002AEE7F File Offset: 0x002AD07F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballRoleData Clone()
		{
			return new PinballRoleData(this);
		}

		// Token: 0x17003CE8 RID: 15592
		// (get) Token: 0x060125E9 RID: 75241 RVA: 0x002AEE87 File Offset: 0x002AD087
		// (set) Token: 0x060125EA RID: 75242 RVA: 0x002AEE8F File Offset: 0x002AD08F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ConfigId
		{
			get
			{
				return this.configId_;
			}
			set
			{
				this.configId_ = value;
			}
		}

		// Token: 0x17003CE9 RID: 15593
		// (get) Token: 0x060125EB RID: 75243 RVA: 0x002AEE98 File Offset: 0x002AD098
		// (set) Token: 0x060125EC RID: 75244 RVA: 0x002AEEA0 File Offset: 0x002AD0A0
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

		// Token: 0x060125ED RID: 75245 RVA: 0x002AEEA9 File Offset: 0x002AD0A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PinballRoleData);
		}

		// Token: 0x060125EE RID: 75246 RVA: 0x002AEEB7 File Offset: 0x002AD0B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PinballRoleData other)
		{
			return other != null && (other == this || (this.ConfigId == other.ConfigId && this.RoleLevel == other.RoleLevel && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060125EF RID: 75247 RVA: 0x002AEEF8 File Offset: 0x002AD0F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ConfigId != 0)
			{
				num ^= this.ConfigId.GetHashCode();
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

		// Token: 0x060125F0 RID: 75248 RVA: 0x002AEF50 File Offset: 0x002AD150
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060125F1 RID: 75249 RVA: 0x002AEF5D File Offset: 0x002AD15D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060125F2 RID: 75250 RVA: 0x002AEF68 File Offset: 0x002AD168
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ConfigId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.ConfigId);
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

		// Token: 0x060125F3 RID: 75251 RVA: 0x002AEFC0 File Offset: 0x002AD1C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ConfigId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ConfigId);
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

		// Token: 0x060125F4 RID: 75252 RVA: 0x002AF018 File Offset: 0x002AD218
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PinballRoleData other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ConfigId != 0)
			{
				this.ConfigId = other.ConfigId;
			}
			if (other.RoleLevel != 0)
			{
				this.RoleLevel = other.RoleLevel;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060125F5 RID: 75253 RVA: 0x002AF068 File Offset: 0x002AD268
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060125F6 RID: 75254 RVA: 0x002AF074 File Offset: 0x002AD274
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
					this.ConfigId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040072D7 RID: 29399
		private static readonly MessageParser<PinballRoleData> _parser = new MessageParser<PinballRoleData>(() => new PinballRoleData());

		// Token: 0x040072D8 RID: 29400
		private UnknownFieldSet _unknownFields;

		// Token: 0x040072D9 RID: 29401
		public const int ConfigIdFieldNumber = 1;

		// Token: 0x040072DA RID: 29402
		private int configId_;

		// Token: 0x040072DB RID: 29403
		public const int RoleLevelFieldNumber = 2;

		// Token: 0x040072DC RID: 29404
		private int roleLevel_;
	}
}
