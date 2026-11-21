using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020001A5 RID: 421
	public sealed class BirthRoleSelect : IMessage<BirthRoleSelect>, IMessage, IEquatable<BirthRoleSelect>, IDeepCloneable<BirthRoleSelect>, IBufferMessage
	{
		// Token: 0x06003196 RID: 12694 RVA: 0x0007E298 File Offset: 0x0007C498
		[NullableContext(1)]
		public static BirthRoleSelect Create()
		{
			return new BirthRoleSelect();
		}

		// Token: 0x170007AD RID: 1965
		// (get) Token: 0x06003197 RID: 12695 RVA: 0x0007E29F File Offset: 0x0007C49F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<BirthRoleSelect> Parser
		{
			get
			{
				return BirthRoleSelect._parser;
			}
		}

		// Token: 0x170007AE RID: 1966
		// (get) Token: 0x06003198 RID: 12696 RVA: 0x0007E2A6 File Offset: 0x0007C4A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170007AF RID: 1967
		// (get) Token: 0x06003199 RID: 12697 RVA: 0x0007E2A9 File Offset: 0x0007C4A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BirthRoleSelect.Descriptor;
			}
		}

		// Token: 0x0600319A RID: 12698 RVA: 0x0007E2B0 File Offset: 0x0007C4B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BirthRoleSelect()
		{
		}

		// Token: 0x0600319B RID: 12699 RVA: 0x0007E2B8 File Offset: 0x0007C4B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BirthRoleSelect(BirthRoleSelect other) : this()
		{
			this.year_ = other.year_;
			this.role_ = other.role_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600319C RID: 12700 RVA: 0x0007E2E9 File Offset: 0x0007C4E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BirthRoleSelect Clone()
		{
			return new BirthRoleSelect(this);
		}

		// Token: 0x170007B0 RID: 1968
		// (get) Token: 0x0600319D RID: 12701 RVA: 0x0007E2F1 File Offset: 0x0007C4F1
		// (set) Token: 0x0600319E RID: 12702 RVA: 0x0007E2F9 File Offset: 0x0007C4F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Year
		{
			get
			{
				return this.year_;
			}
			set
			{
				this.year_ = value;
			}
		}

		// Token: 0x170007B1 RID: 1969
		// (get) Token: 0x0600319F RID: 12703 RVA: 0x0007E302 File Offset: 0x0007C502
		// (set) Token: 0x060031A0 RID: 12704 RVA: 0x0007E30A File Offset: 0x0007C50A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Role
		{
			get
			{
				return this.role_;
			}
			set
			{
				this.role_ = value;
			}
		}

		// Token: 0x060031A1 RID: 12705 RVA: 0x0007E313 File Offset: 0x0007C513
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BirthRoleSelect);
		}

		// Token: 0x060031A2 RID: 12706 RVA: 0x0007E321 File Offset: 0x0007C521
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BirthRoleSelect other)
		{
			return other != null && (other == this || (this.Year == other.Year && this.Role == other.Role && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060031A3 RID: 12707 RVA: 0x0007E360 File Offset: 0x0007C560
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Year != 0)
			{
				num ^= this.Year.GetHashCode();
			}
			if (this.Role != 0)
			{
				num ^= this.Role.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060031A4 RID: 12708 RVA: 0x0007E3B8 File Offset: 0x0007C5B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060031A5 RID: 12709 RVA: 0x0007E3C5 File Offset: 0x0007C5C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060031A6 RID: 12710 RVA: 0x0007E3D0 File Offset: 0x0007C5D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Year != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Year);
			}
			if (this.Role != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Role);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060031A7 RID: 12711 RVA: 0x0007E428 File Offset: 0x0007C628
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Year != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Year);
			}
			if (this.Role != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Role);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060031A8 RID: 12712 RVA: 0x0007E480 File Offset: 0x0007C680
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BirthRoleSelect other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Year != 0)
			{
				this.Year = other.Year;
			}
			if (other.Role != 0)
			{
				this.Role = other.Role;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060031A9 RID: 12713 RVA: 0x0007E4D0 File Offset: 0x0007C6D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060031AA RID: 12714 RVA: 0x0007E4DC File Offset: 0x0007C6DC
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
						this.Role = input.ReadInt32();
					}
				}
				else
				{
					this.Year = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400298D RID: 10637
		private static readonly MessageParser<BirthRoleSelect> _parser = new MessageParser<BirthRoleSelect>(() => new BirthRoleSelect());

		// Token: 0x0400298E RID: 10638
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400298F RID: 10639
		public const int YearFieldNumber = 1;

		// Token: 0x04002990 RID: 10640
		private int year_;

		// Token: 0x04002991 RID: 10641
		public const int RoleFieldNumber = 2;

		// Token: 0x04002992 RID: 10642
		private int role_;
	}
}
