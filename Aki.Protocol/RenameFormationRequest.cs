using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F03 RID: 3843
	[NetMessage(EMessageId.RenameFormationRequest)]
	public sealed class RenameFormationRequest : IMessage<RenameFormationRequest>, IMessage, IEquatable<RenameFormationRequest>, IDeepCloneable<RenameFormationRequest>, IBufferMessage
	{
		// Token: 0x060149AB RID: 84395 RVA: 0x002FE48B File Offset: 0x002FC68B
		[NullableContext(1)]
		public static RenameFormationRequest Create()
		{
			return new RenameFormationRequest();
		}

		// Token: 0x17004483 RID: 17539
		// (get) Token: 0x060149AC RID: 84396 RVA: 0x002FE492 File Offset: 0x002FC692
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004484 RID: 17540
		// (get) Token: 0x060149AD RID: 84397 RVA: 0x002FE495 File Offset: 0x002FC695
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RenameFormationRequest.Descriptor;
			}
		}

		// Token: 0x060149AE RID: 84398 RVA: 0x002FE49C File Offset: 0x002FC69C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RenameFormationRequest()
		{
		}

		// Token: 0x060149AF RID: 84399 RVA: 0x002FE4AF File Offset: 0x002FC6AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RenameFormationRequest(RenameFormationRequest other) : this()
		{
			this.formationId_ = other.formationId_;
			this.name_ = other.name_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060149B0 RID: 84400 RVA: 0x002FE4E0 File Offset: 0x002FC6E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RenameFormationRequest Clone()
		{
			return new RenameFormationRequest(this);
		}

		// Token: 0x17004485 RID: 17541
		// (get) Token: 0x060149B1 RID: 84401 RVA: 0x002FE4E8 File Offset: 0x002FC6E8
		// (set) Token: 0x060149B2 RID: 84402 RVA: 0x002FE4F0 File Offset: 0x002FC6F0
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

		// Token: 0x17004486 RID: 17542
		// (get) Token: 0x060149B3 RID: 84403 RVA: 0x002FE4F9 File Offset: 0x002FC6F9
		// (set) Token: 0x060149B4 RID: 84404 RVA: 0x002FE501 File Offset: 0x002FC701
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

		// Token: 0x060149B5 RID: 84405 RVA: 0x002FE514 File Offset: 0x002FC714
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RenameFormationRequest);
		}

		// Token: 0x060149B6 RID: 84406 RVA: 0x002FE524 File Offset: 0x002FC724
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RenameFormationRequest other)
		{
			return other != null && (other == this || (this.FormationId == other.FormationId && !(this.Name != other.Name) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060149B7 RID: 84407 RVA: 0x002FE574 File Offset: 0x002FC774
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

		// Token: 0x060149B8 RID: 84408 RVA: 0x002FE5CE File Offset: 0x002FC7CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060149B9 RID: 84409 RVA: 0x002FE5DB File Offset: 0x002FC7DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060149BA RID: 84410 RVA: 0x002FE5E4 File Offset: 0x002FC7E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Name.Length != 0)
			{
				output.WriteRawTag(10);
				output.WriteString(this.Name);
			}
			if (this.FormationId != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.FormationId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060149BB RID: 84411 RVA: 0x002FE644 File Offset: 0x002FC844
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

		// Token: 0x060149BC RID: 84412 RVA: 0x002FE6A0 File Offset: 0x002FC8A0
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

		// Token: 0x060149BD RID: 84413 RVA: 0x002FE6F5 File Offset: 0x002FC8F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060149BE RID: 84414 RVA: 0x002FE700 File Offset: 0x002FC900
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
				if (num != 10U)
				{
					if (num != 64U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.FormationId = input.ReadInt32();
					}
				}
				else
				{
					this.Name = input.ReadString();
				}
			}
		}

		// Token: 0x04007D1C RID: 32028
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007D1D RID: 32029
		public const int FormationIdFieldNumber = 8;

		// Token: 0x04007D1E RID: 32030
		private int formationId_;

		// Token: 0x04007D1F RID: 32031
		public const int NameFieldNumber = 1;

		// Token: 0x04007D20 RID: 32032
		private string name_ = "";
	}
}
