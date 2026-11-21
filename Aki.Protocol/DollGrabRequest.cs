using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020003DD RID: 989
	[NetMessage(EMessageId.DollGrabRequest)]
	public sealed class DollGrabRequest : IMessage<DollGrabRequest>, IMessage, IEquatable<DollGrabRequest>, IDeepCloneable<DollGrabRequest>, IBufferMessage
	{
		// Token: 0x06006067 RID: 24679 RVA: 0x000E8FD1 File Offset: 0x000E71D1
		[NullableContext(1)]
		public static DollGrabRequest Create()
		{
			return new DollGrabRequest();
		}

		// Token: 0x170011EC RID: 4588
		// (get) Token: 0x06006068 RID: 24680 RVA: 0x000E8FD8 File Offset: 0x000E71D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170011ED RID: 4589
		// (get) Token: 0x06006069 RID: 24681 RVA: 0x000E8FDB File Offset: 0x000E71DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DollGrabRequest.Descriptor;
			}
		}

		// Token: 0x0600606A RID: 24682 RVA: 0x000E8FE2 File Offset: 0x000E71E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DollGrabRequest()
		{
		}

		// Token: 0x0600606B RID: 24683 RVA: 0x000E8FEA File Offset: 0x000E71EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DollGrabRequest(DollGrabRequest other) : this()
		{
			this.entityIncId_ = other.entityIncId_;
			this.itemUniId_ = other.itemUniId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600606C RID: 24684 RVA: 0x000E901B File Offset: 0x000E721B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DollGrabRequest Clone()
		{
			return new DollGrabRequest(this);
		}

		// Token: 0x170011EE RID: 4590
		// (get) Token: 0x0600606D RID: 24685 RVA: 0x000E9023 File Offset: 0x000E7223
		// (set) Token: 0x0600606E RID: 24686 RVA: 0x000E902B File Offset: 0x000E722B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long EntityIncId
		{
			get
			{
				return this.entityIncId_;
			}
			set
			{
				this.entityIncId_ = value;
			}
		}

		// Token: 0x170011EF RID: 4591
		// (get) Token: 0x0600606F RID: 24687 RVA: 0x000E9034 File Offset: 0x000E7234
		// (set) Token: 0x06006070 RID: 24688 RVA: 0x000E903C File Offset: 0x000E723C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ItemUniId
		{
			get
			{
				return this.itemUniId_;
			}
			set
			{
				this.itemUniId_ = value;
			}
		}

		// Token: 0x06006071 RID: 24689 RVA: 0x000E9045 File Offset: 0x000E7245
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DollGrabRequest);
		}

		// Token: 0x06006072 RID: 24690 RVA: 0x000E9053 File Offset: 0x000E7253
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DollGrabRequest other)
		{
			return other != null && (other == this || (this.EntityIncId == other.EntityIncId && this.ItemUniId == other.ItemUniId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006073 RID: 24691 RVA: 0x000E9094 File Offset: 0x000E7294
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EntityIncId != 0L)
			{
				num ^= this.EntityIncId.GetHashCode();
			}
			if (this.ItemUniId != 0)
			{
				num ^= this.ItemUniId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06006074 RID: 24692 RVA: 0x000E90EC File Offset: 0x000E72EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06006075 RID: 24693 RVA: 0x000E90F9 File Offset: 0x000E72F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006076 RID: 24694 RVA: 0x000E9104 File Offset: 0x000E7304
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ItemUniId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.ItemUniId);
			}
			if (this.EntityIncId != 0L)
			{
				output.WriteRawTag(64);
				output.WriteInt64(this.EntityIncId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006077 RID: 24695 RVA: 0x000E9160 File Offset: 0x000E7360
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EntityIncId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EntityIncId);
			}
			if (this.ItemUniId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ItemUniId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06006078 RID: 24696 RVA: 0x000E91B8 File Offset: 0x000E73B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DollGrabRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EntityIncId != 0L)
			{
				this.EntityIncId = other.EntityIncId;
			}
			if (other.ItemUniId != 0)
			{
				this.ItemUniId = other.ItemUniId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06006079 RID: 24697 RVA: 0x000E9208 File Offset: 0x000E7408
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600607A RID: 24698 RVA: 0x000E9214 File Offset: 0x000E7414
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
					if (num != 64U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.EntityIncId = input.ReadInt64();
					}
				}
				else
				{
					this.ItemUniId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040037A7 RID: 14247
		private UnknownFieldSet _unknownFields;

		// Token: 0x040037A8 RID: 14248
		public const int EntityIncIdFieldNumber = 8;

		// Token: 0x040037A9 RID: 14249
		private long entityIncId_;

		// Token: 0x040037AA RID: 14250
		public const int ItemUniIdFieldNumber = 2;

		// Token: 0x040037AB RID: 14251
		private int itemUniId_;
	}
}
