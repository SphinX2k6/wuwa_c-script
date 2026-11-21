using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000491 RID: 1169
	[NetMessage(EMessageId.EntityPatrolAddTagRequest)]
	public sealed class EntityPatrolAddTagRequest : IMessage<EntityPatrolAddTagRequest>, IMessage, IEquatable<EntityPatrolAddTagRequest>, IDeepCloneable<EntityPatrolAddTagRequest>, IBufferMessage
	{
		// Token: 0x0600700F RID: 28687 RVA: 0x001138EE File Offset: 0x00111AEE
		[NullableContext(1)]
		public static EntityPatrolAddTagRequest Create()
		{
			return new EntityPatrolAddTagRequest();
		}

		// Token: 0x17001595 RID: 5525
		// (get) Token: 0x06007010 RID: 28688 RVA: 0x001138F5 File Offset: 0x00111AF5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001596 RID: 5526
		// (get) Token: 0x06007011 RID: 28689 RVA: 0x001138F8 File Offset: 0x00111AF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EntityPatrolAddTagRequest.Descriptor;
			}
		}

		// Token: 0x06007012 RID: 28690 RVA: 0x001138FF File Offset: 0x00111AFF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityPatrolAddTagRequest()
		{
		}

		// Token: 0x06007013 RID: 28691 RVA: 0x00113908 File Offset: 0x00111B08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityPatrolAddTagRequest(EntityPatrolAddTagRequest other) : this()
		{
			this.entityId_ = other.entityId_;
			this.splineEntityConfigId_ = other.splineEntityConfigId_;
			this.index_ = other.index_;
			this.tagId_ = other.tagId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007014 RID: 28692 RVA: 0x0011395C File Offset: 0x00111B5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityPatrolAddTagRequest Clone()
		{
			return new EntityPatrolAddTagRequest(this);
		}

		// Token: 0x17001597 RID: 5527
		// (get) Token: 0x06007015 RID: 28693 RVA: 0x00113964 File Offset: 0x00111B64
		// (set) Token: 0x06007016 RID: 28694 RVA: 0x0011396C File Offset: 0x00111B6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long EntityId
		{
			get
			{
				return this.entityId_;
			}
			set
			{
				this.entityId_ = value;
			}
		}

		// Token: 0x17001598 RID: 5528
		// (get) Token: 0x06007017 RID: 28695 RVA: 0x00113975 File Offset: 0x00111B75
		// (set) Token: 0x06007018 RID: 28696 RVA: 0x0011397D File Offset: 0x00111B7D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SplineEntityConfigId
		{
			get
			{
				return this.splineEntityConfigId_;
			}
			set
			{
				this.splineEntityConfigId_ = value;
			}
		}

		// Token: 0x17001599 RID: 5529
		// (get) Token: 0x06007019 RID: 28697 RVA: 0x00113986 File Offset: 0x00111B86
		// (set) Token: 0x0600701A RID: 28698 RVA: 0x0011398E File Offset: 0x00111B8E
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

		// Token: 0x1700159A RID: 5530
		// (get) Token: 0x0600701B RID: 28699 RVA: 0x00113997 File Offset: 0x00111B97
		// (set) Token: 0x0600701C RID: 28700 RVA: 0x0011399F File Offset: 0x00111B9F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TagId
		{
			get
			{
				return this.tagId_;
			}
			set
			{
				this.tagId_ = value;
			}
		}

		// Token: 0x0600701D RID: 28701 RVA: 0x001139A8 File Offset: 0x00111BA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EntityPatrolAddTagRequest);
		}

		// Token: 0x0600701E RID: 28702 RVA: 0x001139B8 File Offset: 0x00111BB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EntityPatrolAddTagRequest other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && this.SplineEntityConfigId == other.SplineEntityConfigId && this.Index == other.Index && this.TagId == other.TagId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600701F RID: 28703 RVA: 0x00113A24 File Offset: 0x00111C24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EntityId != 0L)
			{
				num ^= this.EntityId.GetHashCode();
			}
			if (this.SplineEntityConfigId != 0)
			{
				num ^= this.SplineEntityConfigId.GetHashCode();
			}
			if (this.Index != 0)
			{
				num ^= this.Index.GetHashCode();
			}
			if (this.TagId != 0)
			{
				num ^= this.TagId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06007020 RID: 28704 RVA: 0x00113AAE File Offset: 0x00111CAE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06007021 RID: 28705 RVA: 0x00113ABB File Offset: 0x00111CBB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007022 RID: 28706 RVA: 0x00113AC4 File Offset: 0x00111CC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Index != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.Index);
			}
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(56);
				output.WriteInt64(this.EntityId);
			}
			if (this.TagId != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.TagId);
			}
			if (this.SplineEntityConfigId != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.SplineEntityConfigId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007023 RID: 28707 RVA: 0x00113B58 File Offset: 0x00111D58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EntityId);
			}
			if (this.SplineEntityConfigId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SplineEntityConfigId);
			}
			if (this.Index != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Index);
			}
			if (this.TagId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TagId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06007024 RID: 28708 RVA: 0x00113BE0 File Offset: 0x00111DE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EntityPatrolAddTagRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EntityId != 0L)
			{
				this.EntityId = other.EntityId;
			}
			if (other.SplineEntityConfigId != 0)
			{
				this.SplineEntityConfigId = other.SplineEntityConfigId;
			}
			if (other.Index != 0)
			{
				this.Index = other.Index;
			}
			if (other.TagId != 0)
			{
				this.TagId = other.TagId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06007025 RID: 28709 RVA: 0x00113C58 File Offset: 0x00111E58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007026 RID: 28710 RVA: 0x00113C64 File Offset: 0x00111E64
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
				if (num <= 56U)
				{
					if (num == 40U)
					{
						this.Index = input.ReadInt32();
						continue;
					}
					if (num == 56U)
					{
						this.EntityId = input.ReadInt64();
						continue;
					}
				}
				else
				{
					if (num == 72U)
					{
						this.TagId = input.ReadInt32();
						continue;
					}
					if (num == 88U)
					{
						this.SplineEntityConfigId = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04003C7A RID: 15482
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003C7B RID: 15483
		public const int EntityIdFieldNumber = 7;

		// Token: 0x04003C7C RID: 15484
		private long entityId_;

		// Token: 0x04003C7D RID: 15485
		public const int SplineEntityConfigIdFieldNumber = 11;

		// Token: 0x04003C7E RID: 15486
		private int splineEntityConfigId_;

		// Token: 0x04003C7F RID: 15487
		public const int IndexFieldNumber = 5;

		// Token: 0x04003C80 RID: 15488
		private int index_;

		// Token: 0x04003C81 RID: 15489
		public const int TagIdFieldNumber = 9;

		// Token: 0x04003C82 RID: 15490
		private int tagId_;
	}
}
