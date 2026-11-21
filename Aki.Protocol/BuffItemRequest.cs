using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000208 RID: 520
	[NetMessage(EMessageId.BuffItemRequest)]
	public sealed class BuffItemRequest : IMessage<BuffItemRequest>, IMessage, IEquatable<BuffItemRequest>, IDeepCloneable<BuffItemRequest>, IBufferMessage
	{
		// Token: 0x06003996 RID: 14742 RVA: 0x0008FCD2 File Offset: 0x0008DED2
		[NullableContext(1)]
		public static BuffItemRequest Create()
		{
			return new BuffItemRequest();
		}

		// Token: 0x17000964 RID: 2404
		// (get) Token: 0x06003997 RID: 14743 RVA: 0x0008FCD9 File Offset: 0x0008DED9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000965 RID: 2405
		// (get) Token: 0x06003998 RID: 14744 RVA: 0x0008FCDC File Offset: 0x0008DEDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BuffItemRequest.Descriptor;
			}
		}

		// Token: 0x06003999 RID: 14745 RVA: 0x0008FCE3 File Offset: 0x0008DEE3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BuffItemRequest()
		{
		}

		// Token: 0x0600399A RID: 14746 RVA: 0x0008FCEB File Offset: 0x0008DEEB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BuffItemRequest(BuffItemRequest other) : this()
		{
			this.itemId_ = other.itemId_;
			this.num_ = other.num_;
			this.roleId_ = other.roleId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600399B RID: 14747 RVA: 0x0008FD28 File Offset: 0x0008DF28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BuffItemRequest Clone()
		{
			return new BuffItemRequest(this);
		}

		// Token: 0x17000966 RID: 2406
		// (get) Token: 0x0600399C RID: 14748 RVA: 0x0008FD30 File Offset: 0x0008DF30
		// (set) Token: 0x0600399D RID: 14749 RVA: 0x0008FD38 File Offset: 0x0008DF38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ItemId
		{
			get
			{
				return this.itemId_;
			}
			set
			{
				this.itemId_ = value;
			}
		}

		// Token: 0x17000967 RID: 2407
		// (get) Token: 0x0600399E RID: 14750 RVA: 0x0008FD41 File Offset: 0x0008DF41
		// (set) Token: 0x0600399F RID: 14751 RVA: 0x0008FD49 File Offset: 0x0008DF49
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Num
		{
			get
			{
				return this.num_;
			}
			set
			{
				this.num_ = value;
			}
		}

		// Token: 0x17000968 RID: 2408
		// (get) Token: 0x060039A0 RID: 14752 RVA: 0x0008FD52 File Offset: 0x0008DF52
		// (set) Token: 0x060039A1 RID: 14753 RVA: 0x0008FD5A File Offset: 0x0008DF5A
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

		// Token: 0x060039A2 RID: 14754 RVA: 0x0008FD63 File Offset: 0x0008DF63
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BuffItemRequest);
		}

		// Token: 0x060039A3 RID: 14755 RVA: 0x0008FD74 File Offset: 0x0008DF74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BuffItemRequest other)
		{
			return other != null && (other == this || (this.ItemId == other.ItemId && this.Num == other.Num && this.RoleId == other.RoleId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060039A4 RID: 14756 RVA: 0x0008FDD0 File Offset: 0x0008DFD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ItemId != 0)
			{
				num ^= this.ItemId.GetHashCode();
			}
			if (this.Num != 0)
			{
				num ^= this.Num.GetHashCode();
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

		// Token: 0x060039A5 RID: 14757 RVA: 0x0008FE41 File Offset: 0x0008E041
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060039A6 RID: 14758 RVA: 0x0008FE4E File Offset: 0x0008E04E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060039A7 RID: 14759 RVA: 0x0008FE58 File Offset: 0x0008E058
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ItemId != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.ItemId);
			}
			if (this.Num != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.Num);
			}
			if (this.RoleId != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.RoleId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060039A8 RID: 14760 RVA: 0x0008FED0 File Offset: 0x0008E0D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ItemId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ItemId);
			}
			if (this.Num != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Num);
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

		// Token: 0x060039A9 RID: 14761 RVA: 0x0008FF40 File Offset: 0x0008E140
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BuffItemRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ItemId != 0)
			{
				this.ItemId = other.ItemId;
			}
			if (other.Num != 0)
			{
				this.Num = other.Num;
			}
			if (other.RoleId != 0)
			{
				this.RoleId = other.RoleId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060039AA RID: 14762 RVA: 0x0008FFA4 File Offset: 0x0008E1A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060039AB RID: 14763 RVA: 0x0008FFB0 File Offset: 0x0008E1B0
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
				if (num != 40U)
				{
					if (num != 72U)
					{
						if (num != 112U)
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
						this.Num = input.ReadInt32();
					}
				}
				else
				{
					this.ItemId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04002BD9 RID: 11225
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002BDA RID: 11226
		public const int ItemIdFieldNumber = 5;

		// Token: 0x04002BDB RID: 11227
		private int itemId_;

		// Token: 0x04002BDC RID: 11228
		public const int NumFieldNumber = 9;

		// Token: 0x04002BDD RID: 11229
		private int num_;

		// Token: 0x04002BDE RID: 11230
		public const int RoleIdFieldNumber = 14;

		// Token: 0x04002BDF RID: 11231
		private int roleId_;
	}
}
