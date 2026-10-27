using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020004A8 RID: 1192
	[NetMessage(EMessageId.EntityPatrolAddTagRequest)]
	public sealed class EntityPatrolAddTagRequest : IMessage<EntityPatrolAddTagRequest>, IMessage, IEquatable<EntityPatrolAddTagRequest>, IDeepCloneable<EntityPatrolAddTagRequest>, IBufferMessage
	{
		// Token: 0x0600719D RID: 29085 RVA: 0x00116966 File Offset: 0x00114B66
		[NullableContext(1)]
		public static EntityPatrolAddTagRequest Create()
		{
			return new EntityPatrolAddTagRequest();
		}

		// Token: 0x170015E9 RID: 5609
		// (get) Token: 0x0600719E RID: 29086 RVA: 0x0011696D File Offset: 0x00114B6D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170015EA RID: 5610
		// (get) Token: 0x0600719F RID: 29087 RVA: 0x00116970 File Offset: 0x00114B70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EntityPatrolAddTagRequest.Descriptor;
			}
		}

		// Token: 0x060071A0 RID: 29088 RVA: 0x00116977 File Offset: 0x00114B77
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityPatrolAddTagRequest()
		{
		}

		// Token: 0x060071A1 RID: 29089 RVA: 0x00116980 File Offset: 0x00114B80
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

		// Token: 0x060071A2 RID: 29090 RVA: 0x001169D4 File Offset: 0x00114BD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityPatrolAddTagRequest Clone()
		{
			return new EntityPatrolAddTagRequest(this);
		}

		// Token: 0x170015EB RID: 5611
		// (get) Token: 0x060071A3 RID: 29091 RVA: 0x001169DC File Offset: 0x00114BDC
		// (set) Token: 0x060071A4 RID: 29092 RVA: 0x001169E4 File Offset: 0x00114BE4
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

		// Token: 0x170015EC RID: 5612
		// (get) Token: 0x060071A5 RID: 29093 RVA: 0x001169ED File Offset: 0x00114BED
		// (set) Token: 0x060071A6 RID: 29094 RVA: 0x001169F5 File Offset: 0x00114BF5
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

		// Token: 0x170015ED RID: 5613
		// (get) Token: 0x060071A7 RID: 29095 RVA: 0x001169FE File Offset: 0x00114BFE
		// (set) Token: 0x060071A8 RID: 29096 RVA: 0x00116A06 File Offset: 0x00114C06
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

		// Token: 0x170015EE RID: 5614
		// (get) Token: 0x060071A9 RID: 29097 RVA: 0x00116A0F File Offset: 0x00114C0F
		// (set) Token: 0x060071AA RID: 29098 RVA: 0x00116A17 File Offset: 0x00114C17
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

		// Token: 0x060071AB RID: 29099 RVA: 0x00116A20 File Offset: 0x00114C20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EntityPatrolAddTagRequest);
		}

		// Token: 0x060071AC RID: 29100 RVA: 0x00116A30 File Offset: 0x00114C30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EntityPatrolAddTagRequest other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && this.SplineEntityConfigId == other.SplineEntityConfigId && this.Index == other.Index && this.TagId == other.TagId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060071AD RID: 29101 RVA: 0x00116A9C File Offset: 0x00114C9C
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

		// Token: 0x060071AE RID: 29102 RVA: 0x00116B26 File Offset: 0x00114D26
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060071AF RID: 29103 RVA: 0x00116B33 File Offset: 0x00114D33
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060071B0 RID: 29104 RVA: 0x00116B3C File Offset: 0x00114D3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Index != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Index);
			}
			if (this.SplineEntityConfigId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.SplineEntityConfigId);
			}
			if (this.TagId != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.TagId);
			}
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(80);
				output.WriteInt64(this.EntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060071B1 RID: 29105 RVA: 0x00116BCC File Offset: 0x00114DCC
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

		// Token: 0x060071B2 RID: 29106 RVA: 0x00116C54 File Offset: 0x00114E54
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

		// Token: 0x060071B3 RID: 29107 RVA: 0x00116CCC File Offset: 0x00114ECC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060071B4 RID: 29108 RVA: 0x00116CD8 File Offset: 0x00114ED8
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
				if (num <= 24U)
				{
					if (num == 8U)
					{
						this.Index = input.ReadInt32();
						continue;
					}
					if (num == 24U)
					{
						this.SplineEntityConfigId = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 64U)
					{
						this.TagId = input.ReadInt32();
						continue;
					}
					if (num == 80U)
					{
						this.EntityId = input.ReadInt64();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04003C8C RID: 15500
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003C8D RID: 15501
		public const int EntityIdFieldNumber = 10;

		// Token: 0x04003C8E RID: 15502
		private long entityId_;

		// Token: 0x04003C8F RID: 15503
		public const int SplineEntityConfigIdFieldNumber = 3;

		// Token: 0x04003C90 RID: 15504
		private int splineEntityConfigId_;

		// Token: 0x04003C91 RID: 15505
		public const int IndexFieldNumber = 1;

		// Token: 0x04003C92 RID: 15506
		private int index_;

		// Token: 0x04003C93 RID: 15507
		public const int TagIdFieldNumber = 8;

		// Token: 0x04003C94 RID: 15508
		private int tagId_;
	}
}
