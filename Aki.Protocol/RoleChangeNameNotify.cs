using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200105C RID: 4188
	[NetMessage(EMessageId.RoleChangeNameNotify)]
	public sealed class RoleChangeNameNotify : IMessage<RoleChangeNameNotify>, IMessage, IEquatable<RoleChangeNameNotify>, IDeepCloneable<RoleChangeNameNotify>, IBufferMessage
	{
		// Token: 0x0601660C RID: 91660 RVA: 0x003407F7 File Offset: 0x0033E9F7
		[NullableContext(1)]
		public static RoleChangeNameNotify Create()
		{
			return new RoleChangeNameNotify();
		}

		// Token: 0x17004ADE RID: 19166
		// (get) Token: 0x0601660D RID: 91661 RVA: 0x003407FE File Offset: 0x0033E9FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004ADF RID: 19167
		// (get) Token: 0x0601660E RID: 91662 RVA: 0x00340801 File Offset: 0x0033EA01
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleChangeNameNotify.Descriptor;
			}
		}

		// Token: 0x0601660F RID: 91663 RVA: 0x00340808 File Offset: 0x0033EA08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleChangeNameNotify()
		{
		}

		// Token: 0x06016610 RID: 91664 RVA: 0x0034081B File Offset: 0x0033EA1B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleChangeNameNotify(RoleChangeNameNotify other) : this()
		{
			this.roleId_ = other.roleId_;
			this.name_ = other.name_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06016611 RID: 91665 RVA: 0x0034084C File Offset: 0x0033EA4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleChangeNameNotify Clone()
		{
			return new RoleChangeNameNotify(this);
		}

		// Token: 0x17004AE0 RID: 19168
		// (get) Token: 0x06016612 RID: 91666 RVA: 0x00340854 File Offset: 0x0033EA54
		// (set) Token: 0x06016613 RID: 91667 RVA: 0x0034085C File Offset: 0x0033EA5C
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

		// Token: 0x17004AE1 RID: 19169
		// (get) Token: 0x06016614 RID: 91668 RVA: 0x00340865 File Offset: 0x0033EA65
		// (set) Token: 0x06016615 RID: 91669 RVA: 0x0034086D File Offset: 0x0033EA6D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string Name
		{
			get
			{
				return this.name_;
			}
			set
			{
				this.name_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x06016616 RID: 91670 RVA: 0x00340880 File Offset: 0x0033EA80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleChangeNameNotify);
		}

		// Token: 0x06016617 RID: 91671 RVA: 0x00340890 File Offset: 0x0033EA90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleChangeNameNotify other)
		{
			return other != null && (other == this || (this.RoleId == other.RoleId && !(this.Name != other.Name) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06016618 RID: 91672 RVA: 0x003408E0 File Offset: 0x0033EAE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.RoleId != 0)
			{
				num ^= this.RoleId.GetHashCode();
			}
			if (this.Name.Length != 0)
			{
				num ^= this.Name.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06016619 RID: 91673 RVA: 0x0034093A File Offset: 0x0033EB3A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601661A RID: 91674 RVA: 0x00340947 File Offset: 0x0033EB47
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601661B RID: 91675 RVA: 0x00340950 File Offset: 0x0033EB50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Name.Length != 0)
			{
				output.WriteRawTag(42);
				output.WriteString(this.Name);
			}
			if (this.RoleId != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.RoleId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601661C RID: 91676 RVA: 0x003409B0 File Offset: 0x0033EBB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.RoleId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RoleId);
			}
			if (this.Name.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Name);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601661D RID: 91677 RVA: 0x00340A0C File Offset: 0x0033EC0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoleChangeNameNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.RoleId != 0)
			{
				this.RoleId = other.RoleId;
			}
			if (other.Name.Length != 0)
			{
				this.Name = other.Name;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601661E RID: 91678 RVA: 0x00340A61 File Offset: 0x0033EC61
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601661F RID: 91679 RVA: 0x00340A6C File Offset: 0x0033EC6C
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
				if (num != 42U)
				{
					if (num != 64U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.RoleId = input.ReadInt32();
					}
				}
				else
				{
					this.Name = input.ReadString();
				}
			}
		}

		// Token: 0x040085D7 RID: 34263
		private UnknownFieldSet _unknownFields;

		// Token: 0x040085D8 RID: 34264
		public const int RoleIdFieldNumber = 8;

		// Token: 0x040085D9 RID: 34265
		private int roleId_;

		// Token: 0x040085DA RID: 34266
		public const int NameFieldNumber = 5;

		// Token: 0x040085DB RID: 34267
		private string name_ = "";
	}
}
