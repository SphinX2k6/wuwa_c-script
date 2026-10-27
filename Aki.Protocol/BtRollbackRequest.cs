using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020001EF RID: 495
	[NetMessage(EMessageId.BtRollbackRequest)]
	public sealed class BtRollbackRequest : IMessage<BtRollbackRequest>, IMessage, IEquatable<BtRollbackRequest>, IDeepCloneable<BtRollbackRequest>, IBufferMessage
	{
		// Token: 0x06003749 RID: 14153 RVA: 0x0008A56C File Offset: 0x0008876C
		[NullableContext(1)]
		public static BtRollbackRequest Create()
		{
			return new BtRollbackRequest();
		}

		// Token: 0x170008E8 RID: 2280
		// (get) Token: 0x0600374A RID: 14154 RVA: 0x0008A573 File Offset: 0x00088773
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170008E9 RID: 2281
		// (get) Token: 0x0600374B RID: 14155 RVA: 0x0008A576 File Offset: 0x00088776
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BtRollbackRequest.Descriptor;
			}
		}

		// Token: 0x0600374C RID: 14156 RVA: 0x0008A57D File Offset: 0x0008877D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BtRollbackRequest()
		{
		}

		// Token: 0x0600374D RID: 14157 RVA: 0x0008A585 File Offset: 0x00088785
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BtRollbackRequest(BtRollbackRequest other) : this()
		{
			this.treeOwnerId_ = other.treeOwnerId_;
			this.treeIncId_ = other.treeIncId_;
			this.select_ = other.select_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600374E RID: 14158 RVA: 0x0008A5C2 File Offset: 0x000887C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BtRollbackRequest Clone()
		{
			return new BtRollbackRequest(this);
		}

		// Token: 0x170008EA RID: 2282
		// (get) Token: 0x0600374F RID: 14159 RVA: 0x0008A5CA File Offset: 0x000887CA
		// (set) Token: 0x06003750 RID: 14160 RVA: 0x0008A5D2 File Offset: 0x000887D2
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

		// Token: 0x170008EB RID: 2283
		// (get) Token: 0x06003751 RID: 14161 RVA: 0x0008A5DB File Offset: 0x000887DB
		// (set) Token: 0x06003752 RID: 14162 RVA: 0x0008A5E3 File Offset: 0x000887E3
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

		// Token: 0x170008EC RID: 2284
		// (get) Token: 0x06003753 RID: 14163 RVA: 0x0008A5EC File Offset: 0x000887EC
		// (set) Token: 0x06003754 RID: 14164 RVA: 0x0008A5F4 File Offset: 0x000887F4
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

		// Token: 0x06003755 RID: 14165 RVA: 0x0008A5FD File Offset: 0x000887FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BtRollbackRequest);
		}

		// Token: 0x06003756 RID: 14166 RVA: 0x0008A60C File Offset: 0x0008880C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BtRollbackRequest other)
		{
			return other != null && (other == this || (this.TreeOwnerId == other.TreeOwnerId && this.TreeIncId == other.TreeIncId && this.Select == other.Select && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003757 RID: 14167 RVA: 0x0008A668 File Offset: 0x00088868
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

		// Token: 0x06003758 RID: 14168 RVA: 0x0008A6D9 File Offset: 0x000888D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06003759 RID: 14169 RVA: 0x0008A6E6 File Offset: 0x000888E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600375A RID: 14170 RVA: 0x0008A6F0 File Offset: 0x000888F0
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

		// Token: 0x0600375B RID: 14171 RVA: 0x0008A764 File Offset: 0x00088964
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

		// Token: 0x0600375C RID: 14172 RVA: 0x0008A7D4 File Offset: 0x000889D4
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

		// Token: 0x0600375D RID: 14173 RVA: 0x0008A838 File Offset: 0x00088A38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600375E RID: 14174 RVA: 0x0008A844 File Offset: 0x00088A44
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

		// Token: 0x04002AD8 RID: 10968
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002AD9 RID: 10969
		public const int TreeOwnerIdFieldNumber = 1;

		// Token: 0x04002ADA RID: 10970
		private int treeOwnerId_;

		// Token: 0x04002ADB RID: 10971
		public const int TreeIncIdFieldNumber = 3;

		// Token: 0x04002ADC RID: 10972
		private long treeIncId_;

		// Token: 0x04002ADD RID: 10973
		public const int SelectFieldNumber = 4;

		// Token: 0x04002ADE RID: 10974
		private int select_;
	}
}
