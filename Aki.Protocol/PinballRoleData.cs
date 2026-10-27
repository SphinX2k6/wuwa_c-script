using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D58 RID: 3416
	public sealed class PinballRoleData : IMessage<PinballRoleData>, IMessage, IEquatable<PinballRoleData>, IDeepCloneable<PinballRoleData>, IBufferMessage
	{
		// Token: 0x060126DE RID: 75486 RVA: 0x002B0A4E File Offset: 0x002AEC4E
		[NullableContext(1)]
		public static PinballRoleData Create()
		{
			return new PinballRoleData();
		}

		// Token: 0x17003D1A RID: 15642
		// (get) Token: 0x060126DF RID: 75487 RVA: 0x002B0A55 File Offset: 0x002AEC55
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PinballRoleData> Parser
		{
			get
			{
				return PinballRoleData._parser;
			}
		}

		// Token: 0x17003D1B RID: 15643
		// (get) Token: 0x060126E0 RID: 75488 RVA: 0x002B0A5C File Offset: 0x002AEC5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003D1C RID: 15644
		// (get) Token: 0x060126E1 RID: 75489 RVA: 0x002B0A5F File Offset: 0x002AEC5F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PinballRoleData.Descriptor;
			}
		}

		// Token: 0x060126E2 RID: 75490 RVA: 0x002B0A66 File Offset: 0x002AEC66
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballRoleData()
		{
		}

		// Token: 0x060126E3 RID: 75491 RVA: 0x002B0A6E File Offset: 0x002AEC6E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballRoleData(PinballRoleData other) : this()
		{
			this.configId_ = other.configId_;
			this.roleLevel_ = other.roleLevel_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060126E4 RID: 75492 RVA: 0x002B0A9F File Offset: 0x002AEC9F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballRoleData Clone()
		{
			return new PinballRoleData(this);
		}

		// Token: 0x17003D1D RID: 15645
		// (get) Token: 0x060126E5 RID: 75493 RVA: 0x002B0AA7 File Offset: 0x002AECA7
		// (set) Token: 0x060126E6 RID: 75494 RVA: 0x002B0AAF File Offset: 0x002AECAF
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

		// Token: 0x17003D1E RID: 15646
		// (get) Token: 0x060126E7 RID: 75495 RVA: 0x002B0AB8 File Offset: 0x002AECB8
		// (set) Token: 0x060126E8 RID: 75496 RVA: 0x002B0AC0 File Offset: 0x002AECC0
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

		// Token: 0x060126E9 RID: 75497 RVA: 0x002B0AC9 File Offset: 0x002AECC9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PinballRoleData);
		}

		// Token: 0x060126EA RID: 75498 RVA: 0x002B0AD7 File Offset: 0x002AECD7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PinballRoleData other)
		{
			return other != null && (other == this || (this.ConfigId == other.ConfigId && this.RoleLevel == other.RoleLevel && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060126EB RID: 75499 RVA: 0x002B0B18 File Offset: 0x002AED18
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

		// Token: 0x060126EC RID: 75500 RVA: 0x002B0B70 File Offset: 0x002AED70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060126ED RID: 75501 RVA: 0x002B0B7D File Offset: 0x002AED7D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060126EE RID: 75502 RVA: 0x002B0B88 File Offset: 0x002AED88
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

		// Token: 0x060126EF RID: 75503 RVA: 0x002B0BE0 File Offset: 0x002AEDE0
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

		// Token: 0x060126F0 RID: 75504 RVA: 0x002B0C38 File Offset: 0x002AEE38
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

		// Token: 0x060126F1 RID: 75505 RVA: 0x002B0C88 File Offset: 0x002AEE88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060126F2 RID: 75506 RVA: 0x002B0C94 File Offset: 0x002AEE94
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

		// Token: 0x040072BF RID: 29375
		private static readonly MessageParser<PinballRoleData> _parser = new MessageParser<PinballRoleData>(() => new PinballRoleData());

		// Token: 0x040072C0 RID: 29376
		private UnknownFieldSet _unknownFields;

		// Token: 0x040072C1 RID: 29377
		public const int ConfigIdFieldNumber = 1;

		// Token: 0x040072C2 RID: 29378
		private int configId_;

		// Token: 0x040072C3 RID: 29379
		public const int RoleLevelFieldNumber = 2;

		// Token: 0x040072C4 RID: 29380
		private int roleLevel_;
	}
}
