using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F13 RID: 3859
	[NetMessage(EMessageId.RenameFormationRequest)]
	public sealed class RenameFormationRequest : IMessage<RenameFormationRequest>, IMessage, IEquatable<RenameFormationRequest>, IDeepCloneable<RenameFormationRequest>, IBufferMessage
	{
		// Token: 0x06014A90 RID: 84624 RVA: 0x002FFB47 File Offset: 0x002FDD47
		[NullableContext(1)]
		public static RenameFormationRequest Create()
		{
			return new RenameFormationRequest();
		}

		// Token: 0x170044AD RID: 17581
		// (get) Token: 0x06014A91 RID: 84625 RVA: 0x002FFB4E File Offset: 0x002FDD4E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170044AE RID: 17582
		// (get) Token: 0x06014A92 RID: 84626 RVA: 0x002FFB51 File Offset: 0x002FDD51
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RenameFormationRequest.Descriptor;
			}
		}

		// Token: 0x06014A93 RID: 84627 RVA: 0x002FFB58 File Offset: 0x002FDD58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RenameFormationRequest()
		{
		}

		// Token: 0x06014A94 RID: 84628 RVA: 0x002FFB6B File Offset: 0x002FDD6B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RenameFormationRequest(RenameFormationRequest other) : this()
		{
			this.formationId_ = other.formationId_;
			this.name_ = other.name_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06014A95 RID: 84629 RVA: 0x002FFB9C File Offset: 0x002FDD9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RenameFormationRequest Clone()
		{
			return new RenameFormationRequest(this);
		}

		// Token: 0x170044AF RID: 17583
		// (get) Token: 0x06014A96 RID: 84630 RVA: 0x002FFBA4 File Offset: 0x002FDDA4
		// (set) Token: 0x06014A97 RID: 84631 RVA: 0x002FFBAC File Offset: 0x002FDDAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int FormationId
		{
			get
			{
				return this.formationId_;
			}
			set
			{
				this.formationId_ = value;
			}
		}

		// Token: 0x170044B0 RID: 17584
		// (get) Token: 0x06014A98 RID: 84632 RVA: 0x002FFBB5 File Offset: 0x002FDDB5
		// (set) Token: 0x06014A99 RID: 84633 RVA: 0x002FFBBD File Offset: 0x002FDDBD
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

		// Token: 0x06014A9A RID: 84634 RVA: 0x002FFBD0 File Offset: 0x002FDDD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RenameFormationRequest);
		}

		// Token: 0x06014A9B RID: 84635 RVA: 0x002FFBE0 File Offset: 0x002FDDE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RenameFormationRequest other)
		{
			return other != null && (other == this || (this.FormationId == other.FormationId && !(this.Name != other.Name) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06014A9C RID: 84636 RVA: 0x002FFC30 File Offset: 0x002FDE30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.FormationId != 0)
			{
				num ^= this.FormationId.GetHashCode();
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

		// Token: 0x06014A9D RID: 84637 RVA: 0x002FFC8A File Offset: 0x002FDE8A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06014A9E RID: 84638 RVA: 0x002FFC97 File Offset: 0x002FDE97
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06014A9F RID: 84639 RVA: 0x002FFCA0 File Offset: 0x002FDEA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.FormationId != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.FormationId);
			}
			if (this.Name.Length != 0)
			{
				output.WriteRawTag(114);
				output.WriteString(this.Name);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06014AA0 RID: 84640 RVA: 0x002FFD00 File Offset: 0x002FDF00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.FormationId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.FormationId);
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

		// Token: 0x06014AA1 RID: 84641 RVA: 0x002FFD5C File Offset: 0x002FDF5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RenameFormationRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.FormationId != 0)
			{
				this.FormationId = other.FormationId;
			}
			if (other.Name.Length != 0)
			{
				this.Name = other.Name;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06014AA2 RID: 84642 RVA: 0x002FFDB1 File Offset: 0x002FDFB1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06014AA3 RID: 84643 RVA: 0x002FFDBC File Offset: 0x002FDFBC
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
				if (num != 56U)
				{
					if (num != 114U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Name = input.ReadString();
					}
				}
				else
				{
					this.FormationId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04007CF2 RID: 31986
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007CF3 RID: 31987
		public const int FormationIdFieldNumber = 7;

		// Token: 0x04007CF4 RID: 31988
		private int formationId_;

		// Token: 0x04007CF5 RID: 31989
		public const int NameFieldNumber = 14;

		// Token: 0x04007CF6 RID: 31990
		private string name_ = "";
	}
}
