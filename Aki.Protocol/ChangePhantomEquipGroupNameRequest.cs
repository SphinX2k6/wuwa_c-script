using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200025A RID: 602
	[NetMessage(EMessageId.ChangePhantomEquipGroupNameRequest)]
	public sealed class ChangePhantomEquipGroupNameRequest : IMessage<ChangePhantomEquipGroupNameRequest>, IMessage, IEquatable<ChangePhantomEquipGroupNameRequest>, IDeepCloneable<ChangePhantomEquipGroupNameRequest>, IBufferMessage
	{
		// Token: 0x06004026 RID: 16422 RVA: 0x0009DFA5 File Offset: 0x0009C1A5
		[NullableContext(1)]
		public static ChangePhantomEquipGroupNameRequest Create()
		{
			return new ChangePhantomEquipGroupNameRequest();
		}

		// Token: 0x17000AC2 RID: 2754
		// (get) Token: 0x06004027 RID: 16423 RVA: 0x0009DFAC File Offset: 0x0009C1AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000AC3 RID: 2755
		// (get) Token: 0x06004028 RID: 16424 RVA: 0x0009DFAF File Offset: 0x0009C1AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ChangePhantomEquipGroupNameRequest.Descriptor;
			}
		}

		// Token: 0x06004029 RID: 16425 RVA: 0x0009DFB6 File Offset: 0x0009C1B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChangePhantomEquipGroupNameRequest()
		{
		}

		// Token: 0x0600402A RID: 16426 RVA: 0x0009DFC9 File Offset: 0x0009C1C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChangePhantomEquipGroupNameRequest(ChangePhantomEquipGroupNameRequest other) : this()
		{
			this.index_ = other.index_;
			this.name_ = other.name_;
			this.roleId_ = other.roleId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600402B RID: 16427 RVA: 0x0009E006 File Offset: 0x0009C206
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChangePhantomEquipGroupNameRequest Clone()
		{
			return new ChangePhantomEquipGroupNameRequest(this);
		}

		// Token: 0x17000AC4 RID: 2756
		// (get) Token: 0x0600402C RID: 16428 RVA: 0x0009E00E File Offset: 0x0009C20E
		// (set) Token: 0x0600402D RID: 16429 RVA: 0x0009E016 File Offset: 0x0009C216
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Index
		{
			get
			{
				return this.index_;
			}
			set
			{
				this.index_ = value;
			}
		}

		// Token: 0x17000AC5 RID: 2757
		// (get) Token: 0x0600402E RID: 16430 RVA: 0x0009E01F File Offset: 0x0009C21F
		// (set) Token: 0x0600402F RID: 16431 RVA: 0x0009E027 File Offset: 0x0009C227
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

		// Token: 0x17000AC6 RID: 2758
		// (get) Token: 0x06004030 RID: 16432 RVA: 0x0009E03A File Offset: 0x0009C23A
		// (set) Token: 0x06004031 RID: 16433 RVA: 0x0009E042 File Offset: 0x0009C242
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

		// Token: 0x06004032 RID: 16434 RVA: 0x0009E04B File Offset: 0x0009C24B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ChangePhantomEquipGroupNameRequest);
		}

		// Token: 0x06004033 RID: 16435 RVA: 0x0009E05C File Offset: 0x0009C25C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ChangePhantomEquipGroupNameRequest other)
		{
			return other != null && (other == this || (this.Index == other.Index && !(this.Name != other.Name) && this.RoleId == other.RoleId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004034 RID: 16436 RVA: 0x0009E0BC File Offset: 0x0009C2BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Index != 0)
			{
				num ^= this.Index.GetHashCode();
			}
			if (this.Name.Length != 0)
			{
				num ^= this.Name.GetHashCode();
			}
			if (this.RoleId != 0)
			{
				num ^= this.RoleId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06004035 RID: 16437 RVA: 0x0009E12F File Offset: 0x0009C32F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06004036 RID: 16438 RVA: 0x0009E13C File Offset: 0x0009C33C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004037 RID: 16439 RVA: 0x0009E148 File Offset: 0x0009C348
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.RoleId != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.RoleId);
			}
			if (this.Index != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.Index);
			}
			if (this.Name.Length != 0)
			{
				output.WriteRawTag(106);
				output.WriteString(this.Name);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004038 RID: 16440 RVA: 0x0009E1C4 File Offset: 0x0009C3C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Index != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Index);
			}
			if (this.Name.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Name);
			}
			if (this.RoleId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RoleId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06004039 RID: 16441 RVA: 0x0009E238 File Offset: 0x0009C438
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ChangePhantomEquipGroupNameRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Index != 0)
			{
				this.Index = other.Index;
			}
			if (other.Name.Length != 0)
			{
				this.Name = other.Name;
			}
			if (other.RoleId != 0)
			{
				this.RoleId = other.RoleId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600403A RID: 16442 RVA: 0x0009E2A1 File Offset: 0x0009C4A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600403B RID: 16443 RVA: 0x0009E2AC File Offset: 0x0009C4AC
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
				if (num != 48U)
				{
					if (num != 72U)
					{
						if (num != 106U)
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
						this.Index = input.ReadInt32();
					}
				}
				else
				{
					this.RoleId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04002DA5 RID: 11685
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002DA6 RID: 11686
		public const int IndexFieldNumber = 9;

		// Token: 0x04002DA7 RID: 11687
		private int index_;

		// Token: 0x04002DA8 RID: 11688
		public const int NameFieldNumber = 13;

		// Token: 0x04002DA9 RID: 11689
		private string name_ = "";

		// Token: 0x04002DAA RID: 11690
		public const int RoleIdFieldNumber = 6;

		// Token: 0x04002DAB RID: 11691
		private int roleId_;
	}
}
