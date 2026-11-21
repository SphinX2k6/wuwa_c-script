using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020001F4 RID: 500
	[NetMessage(EMessageId.BtRollbackRequest)]
	public sealed class BtRollbackRequest : IMessage<BtRollbackRequest>, IMessage, IEquatable<BtRollbackRequest>, IDeepCloneable<BtRollbackRequest>, IBufferMessage
	{
		// Token: 0x060037EE RID: 14318 RVA: 0x0008C179 File Offset: 0x0008A379
		[NullableContext(1)]
		public static BtRollbackRequest Create()
		{
			return new BtRollbackRequest();
		}

		// Token: 0x17000907 RID: 2311
		// (get) Token: 0x060037EF RID: 14319 RVA: 0x0008C180 File Offset: 0x0008A380
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000908 RID: 2312
		// (get) Token: 0x060037F0 RID: 14320 RVA: 0x0008C183 File Offset: 0x0008A383
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BtRollbackRequest.Descriptor;
			}
		}

		// Token: 0x060037F1 RID: 14321 RVA: 0x0008C18A File Offset: 0x0008A38A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BtRollbackRequest()
		{
		}

		// Token: 0x060037F2 RID: 14322 RVA: 0x0008C192 File Offset: 0x0008A392
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BtRollbackRequest(BtRollbackRequest other) : this()
		{
			this.treeOwnerId_ = other.treeOwnerId_;
			this.treeIncId_ = other.treeIncId_;
			this.select_ = other.select_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060037F3 RID: 14323 RVA: 0x0008C1CF File Offset: 0x0008A3CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BtRollbackRequest Clone()
		{
			return new BtRollbackRequest(this);
		}

		// Token: 0x17000909 RID: 2313
		// (get) Token: 0x060037F4 RID: 14324 RVA: 0x0008C1D7 File Offset: 0x0008A3D7
		// (set) Token: 0x060037F5 RID: 14325 RVA: 0x0008C1DF File Offset: 0x0008A3DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TreeOwnerId
		{
			get
			{
				return this.treeOwnerId_;
			}
			set
			{
				this.treeOwnerId_ = value;
			}
		}

		// Token: 0x1700090A RID: 2314
		// (get) Token: 0x060037F6 RID: 14326 RVA: 0x0008C1E8 File Offset: 0x0008A3E8
		// (set) Token: 0x060037F7 RID: 14327 RVA: 0x0008C1F0 File Offset: 0x0008A3F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long TreeIncId
		{
			get
			{
				return this.treeIncId_;
			}
			set
			{
				this.treeIncId_ = value;
			}
		}

		// Token: 0x1700090B RID: 2315
		// (get) Token: 0x060037F8 RID: 14328 RVA: 0x0008C1F9 File Offset: 0x0008A3F9
		// (set) Token: 0x060037F9 RID: 14329 RVA: 0x0008C201 File Offset: 0x0008A401
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Select
		{
			get
			{
				return this.select_;
			}
			set
			{
				this.select_ = value;
			}
		}

		// Token: 0x060037FA RID: 14330 RVA: 0x0008C20A File Offset: 0x0008A40A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BtRollbackRequest);
		}

		// Token: 0x060037FB RID: 14331 RVA: 0x0008C218 File Offset: 0x0008A418
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BtRollbackRequest other)
		{
			return other != null && (other == this || (this.TreeOwnerId == other.TreeOwnerId && this.TreeIncId == other.TreeIncId && this.Select == other.Select && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060037FC RID: 14332 RVA: 0x0008C274 File Offset: 0x0008A474
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.TreeOwnerId != 0)
			{
				num ^= this.TreeOwnerId.GetHashCode();
			}
			if (this.TreeIncId != 0L)
			{
				num ^= this.TreeIncId.GetHashCode();
			}
			if (this.Select != 0)
			{
				num ^= this.Select.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060037FD RID: 14333 RVA: 0x0008C2E5 File Offset: 0x0008A4E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060037FE RID: 14334 RVA: 0x0008C2F2 File Offset: 0x0008A4F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060037FF RID: 14335 RVA: 0x0008C2FC File Offset: 0x0008A4FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TreeOwnerId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.TreeOwnerId);
			}
			if (this.TreeIncId != 0L)
			{
				output.WriteRawTag(24);
				output.WriteInt64(this.TreeIncId);
			}
			if (this.Select != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.Select);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003800 RID: 14336 RVA: 0x0008C370 File Offset: 0x0008A570
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.TreeOwnerId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TreeOwnerId);
			}
			if (this.TreeIncId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.TreeIncId);
			}
			if (this.Select != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Select);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06003801 RID: 14337 RVA: 0x0008C3E0 File Offset: 0x0008A5E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BtRollbackRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.TreeOwnerId != 0)
			{
				this.TreeOwnerId = other.TreeOwnerId;
			}
			if (other.TreeIncId != 0L)
			{
				this.TreeIncId = other.TreeIncId;
			}
			if (other.Select != 0)
			{
				this.Select = other.Select;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06003802 RID: 14338 RVA: 0x0008C444 File Offset: 0x0008A644
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003803 RID: 14339 RVA: 0x0008C450 File Offset: 0x0008A650
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
					if (num != 24U)
					{
						if (num != 32U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.Select = input.ReadInt32();
						}
					}
					else
					{
						this.TreeIncId = input.ReadInt64();
					}
				}
				else
				{
					this.TreeOwnerId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04002B5A RID: 11098
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002B5B RID: 11099
		public const int TreeOwnerIdFieldNumber = 1;

		// Token: 0x04002B5C RID: 11100
		private int treeOwnerId_;

		// Token: 0x04002B5D RID: 11101
		public const int TreeIncIdFieldNumber = 3;

		// Token: 0x04002B5E RID: 11102
		private long treeIncId_;

		// Token: 0x04002B5F RID: 11103
		public const int SelectFieldNumber = 4;

		// Token: 0x04002B60 RID: 11104
		private int select_;
	}
}
