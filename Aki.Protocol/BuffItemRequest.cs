using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000203 RID: 515
	[NetMessage(EMessageId.BuffItemRequest)]
	public sealed class BuffItemRequest : IMessage<BuffItemRequest>, IMessage, IEquatable<BuffItemRequest>, IDeepCloneable<BuffItemRequest>, IBufferMessage
	{
		// Token: 0x060038F1 RID: 14577 RVA: 0x0008E0C2 File Offset: 0x0008C2C2
		[NullableContext(1)]
		public static BuffItemRequest Create()
		{
			return new BuffItemRequest();
		}

		// Token: 0x17000945 RID: 2373
		// (get) Token: 0x060038F2 RID: 14578 RVA: 0x0008E0C9 File Offset: 0x0008C2C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000946 RID: 2374
		// (get) Token: 0x060038F3 RID: 14579 RVA: 0x0008E0CC File Offset: 0x0008C2CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BuffItemRequest.Descriptor;
			}
		}

		// Token: 0x060038F4 RID: 14580 RVA: 0x0008E0D3 File Offset: 0x0008C2D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BuffItemRequest()
		{
		}

		// Token: 0x060038F5 RID: 14581 RVA: 0x0008E0DB File Offset: 0x0008C2DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BuffItemRequest(BuffItemRequest other) : this()
		{
			this.itemId_ = other.itemId_;
			this.num_ = other.num_;
			this.roleId_ = other.roleId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060038F6 RID: 14582 RVA: 0x0008E118 File Offset: 0x0008C318
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BuffItemRequest Clone()
		{
			return new BuffItemRequest(this);
		}

		// Token: 0x17000947 RID: 2375
		// (get) Token: 0x060038F7 RID: 14583 RVA: 0x0008E120 File Offset: 0x0008C320
		// (set) Token: 0x060038F8 RID: 14584 RVA: 0x0008E128 File Offset: 0x0008C328
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

		// Token: 0x17000948 RID: 2376
		// (get) Token: 0x060038F9 RID: 14585 RVA: 0x0008E131 File Offset: 0x0008C331
		// (set) Token: 0x060038FA RID: 14586 RVA: 0x0008E139 File Offset: 0x0008C339
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

		// Token: 0x17000949 RID: 2377
		// (get) Token: 0x060038FB RID: 14587 RVA: 0x0008E142 File Offset: 0x0008C342
		// (set) Token: 0x060038FC RID: 14588 RVA: 0x0008E14A File Offset: 0x0008C34A
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

		// Token: 0x060038FD RID: 14589 RVA: 0x0008E153 File Offset: 0x0008C353
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BuffItemRequest);
		}

		// Token: 0x060038FE RID: 14590 RVA: 0x0008E164 File Offset: 0x0008C364
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BuffItemRequest other)
		{
			return other != null && (other == this || (this.ItemId == other.ItemId && this.Num == other.Num && this.RoleId == other.RoleId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060038FF RID: 14591 RVA: 0x0008E1C0 File Offset: 0x0008C3C0
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

		// Token: 0x06003900 RID: 14592 RVA: 0x0008E231 File Offset: 0x0008C431
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06003901 RID: 14593 RVA: 0x0008E23E File Offset: 0x0008C43E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003902 RID: 14594 RVA: 0x0008E248 File Offset: 0x0008C448
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ItemId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.ItemId);
			}
			if (this.Num != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.Num);
			}
			if (this.RoleId != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.RoleId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003903 RID: 14595 RVA: 0x0008E2C0 File Offset: 0x0008C4C0
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

		// Token: 0x06003904 RID: 14596 RVA: 0x0008E330 File Offset: 0x0008C530
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

		// Token: 0x06003905 RID: 14597 RVA: 0x0008E394 File Offset: 0x0008C594
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003906 RID: 14598 RVA: 0x0008E3A0 File Offset: 0x0008C5A0
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
				if (num != 16U)
				{
					if (num != 48U)
					{
						if (num != 80U)
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

		// Token: 0x04002B57 RID: 11095
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002B58 RID: 11096
		public const int ItemIdFieldNumber = 2;

		// Token: 0x04002B59 RID: 11097
		private int itemId_;

		// Token: 0x04002B5A RID: 11098
		public const int NumFieldNumber = 6;

		// Token: 0x04002B5B RID: 11099
		private int num_;

		// Token: 0x04002B5C RID: 11100
		public const int RoleIdFieldNumber = 10;

		// Token: 0x04002B5D RID: 11101
		private int roleId_;
	}
}
