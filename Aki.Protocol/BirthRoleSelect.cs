using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020001A1 RID: 417
	public sealed class BirthRoleSelect : IMessage<BirthRoleSelect>, IMessage, IEquatable<BirthRoleSelect>, IDeepCloneable<BirthRoleSelect>, IBufferMessage
	{
		// Token: 0x06003109 RID: 12553 RVA: 0x0007CB31 File Offset: 0x0007AD31
		[NullableContext(1)]
		public static BirthRoleSelect Create()
		{
			return new BirthRoleSelect();
		}

		// Token: 0x17000794 RID: 1940
		// (get) Token: 0x0600310A RID: 12554 RVA: 0x0007CB38 File Offset: 0x0007AD38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<BirthRoleSelect> Parser
		{
			get
			{
				return BirthRoleSelect._parser;
			}
		}

		// Token: 0x17000795 RID: 1941
		// (get) Token: 0x0600310B RID: 12555 RVA: 0x0007CB3F File Offset: 0x0007AD3F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000796 RID: 1942
		// (get) Token: 0x0600310C RID: 12556 RVA: 0x0007CB42 File Offset: 0x0007AD42
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BirthRoleSelect.Descriptor;
			}
		}

		// Token: 0x0600310D RID: 12557 RVA: 0x0007CB49 File Offset: 0x0007AD49
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BirthRoleSelect()
		{
		}

		// Token: 0x0600310E RID: 12558 RVA: 0x0007CB51 File Offset: 0x0007AD51
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BirthRoleSelect(BirthRoleSelect other) : this()
		{
			this.year_ = other.year_;
			this.role_ = other.role_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600310F RID: 12559 RVA: 0x0007CB82 File Offset: 0x0007AD82
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BirthRoleSelect Clone()
		{
			return new BirthRoleSelect(this);
		}

		// Token: 0x17000797 RID: 1943
		// (get) Token: 0x06003110 RID: 12560 RVA: 0x0007CB8A File Offset: 0x0007AD8A
		// (set) Token: 0x06003111 RID: 12561 RVA: 0x0007CB92 File Offset: 0x0007AD92
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

		// Token: 0x17000798 RID: 1944
		// (get) Token: 0x06003112 RID: 12562 RVA: 0x0007CB9B File Offset: 0x0007AD9B
		// (set) Token: 0x06003113 RID: 12563 RVA: 0x0007CBA3 File Offset: 0x0007ADA3
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

		// Token: 0x06003114 RID: 12564 RVA: 0x0007CBAC File Offset: 0x0007ADAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BirthRoleSelect);
		}

		// Token: 0x06003115 RID: 12565 RVA: 0x0007CBBA File Offset: 0x0007ADBA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BirthRoleSelect other)
		{
			return other != null && (other == this || (this.Year == other.Year && this.Role == other.Role && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003116 RID: 12566 RVA: 0x0007CBF8 File Offset: 0x0007ADF8
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

		// Token: 0x06003117 RID: 12567 RVA: 0x0007CC50 File Offset: 0x0007AE50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06003118 RID: 12568 RVA: 0x0007CC5D File Offset: 0x0007AE5D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003119 RID: 12569 RVA: 0x0007CC68 File Offset: 0x0007AE68
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

		// Token: 0x0600311A RID: 12570 RVA: 0x0007CCC0 File Offset: 0x0007AEC0
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

		// Token: 0x0600311B RID: 12571 RVA: 0x0007CD18 File Offset: 0x0007AF18
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

		// Token: 0x0600311C RID: 12572 RVA: 0x0007CD68 File Offset: 0x0007AF68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600311D RID: 12573 RVA: 0x0007CD74 File Offset: 0x0007AF74
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

		// Token: 0x04002912 RID: 10514
		private static readonly MessageParser<BirthRoleSelect> _parser = new MessageParser<BirthRoleSelect>(() => new BirthRoleSelect());

		// Token: 0x04002913 RID: 10515
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002914 RID: 10516
		public const int YearFieldNumber = 1;

		// Token: 0x04002915 RID: 10517
		private int year_;

		// Token: 0x04002916 RID: 10518
		public const int RoleFieldNumber = 2;

		// Token: 0x04002917 RID: 10519
		private int role_;
	}
}
