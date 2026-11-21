using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000495 RID: 1173
	[NetMessage(EMessageId.EntityPatrolStartRequest)]
	public sealed class EntityPatrolStartRequest : IMessage<EntityPatrolStartRequest>, IMessage, IEquatable<EntityPatrolStartRequest>, IDeepCloneable<EntityPatrolStartRequest>, IBufferMessage
	{
		// Token: 0x0600705F RID: 28767 RVA: 0x00114335 File Offset: 0x00112535
		[NullableContext(1)]
		public static EntityPatrolStartRequest Create()
		{
			return new EntityPatrolStartRequest();
		}

		// Token: 0x170015A5 RID: 5541
		// (get) Token: 0x06007060 RID: 28768 RVA: 0x0011433C File Offset: 0x0011253C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170015A6 RID: 5542
		// (get) Token: 0x06007061 RID: 28769 RVA: 0x0011433F File Offset: 0x0011253F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EntityPatrolStartRequest.Descriptor;
			}
		}

		// Token: 0x06007062 RID: 28770 RVA: 0x00114346 File Offset: 0x00112546
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityPatrolStartRequest()
		{
		}

		// Token: 0x06007063 RID: 28771 RVA: 0x0011434E File Offset: 0x0011254E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityPatrolStartRequest(EntityPatrolStartRequest other) : this()
		{
			this.entityId_ = other.entityId_;
			this.dir_ = other.dir_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007064 RID: 28772 RVA: 0x0011437F File Offset: 0x0011257F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityPatrolStartRequest Clone()
		{
			return new EntityPatrolStartRequest(this);
		}

		// Token: 0x170015A7 RID: 5543
		// (get) Token: 0x06007065 RID: 28773 RVA: 0x00114387 File Offset: 0x00112587
		// (set) Token: 0x06007066 RID: 28774 RVA: 0x0011438F File Offset: 0x0011258F
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

		// Token: 0x170015A8 RID: 5544
		// (get) Token: 0x06007067 RID: 28775 RVA: 0x00114398 File Offset: 0x00112598
		// (set) Token: 0x06007068 RID: 28776 RVA: 0x001143A0 File Offset: 0x001125A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Dir
		{
			get
			{
				return this.dir_;
			}
			set
			{
				this.dir_ = value;
			}
		}

		// Token: 0x06007069 RID: 28777 RVA: 0x001143A9 File Offset: 0x001125A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EntityPatrolStartRequest);
		}

		// Token: 0x0600706A RID: 28778 RVA: 0x001143B7 File Offset: 0x001125B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EntityPatrolStartRequest other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && this.Dir == other.Dir && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600706B RID: 28779 RVA: 0x001143F8 File Offset: 0x001125F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EntityId != 0L)
			{
				num ^= this.EntityId.GetHashCode();
			}
			if (this.Dir)
			{
				num ^= this.Dir.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600706C RID: 28780 RVA: 0x00114450 File Offset: 0x00112650
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600706D RID: 28781 RVA: 0x0011445D File Offset: 0x0011265D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600706E RID: 28782 RVA: 0x00114468 File Offset: 0x00112668
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Dir)
			{
				output.WriteRawTag(88);
				output.WriteBool(this.Dir);
			}
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(96);
				output.WriteInt64(this.EntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600706F RID: 28783 RVA: 0x001144C4 File Offset: 0x001126C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EntityId);
			}
			if (this.Dir)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06007070 RID: 28784 RVA: 0x00114510 File Offset: 0x00112710
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EntityPatrolStartRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EntityId != 0L)
			{
				this.EntityId = other.EntityId;
			}
			if (other.Dir)
			{
				this.Dir = other.Dir;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06007071 RID: 28785 RVA: 0x00114560 File Offset: 0x00112760
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007072 RID: 28786 RVA: 0x0011456C File Offset: 0x0011276C
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
				if (num != 88U)
				{
					if (num != 96U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.EntityId = input.ReadInt64();
					}
				}
				else
				{
					this.Dir = input.ReadBool();
				}
			}
		}

		// Token: 0x04003C8E RID: 15502
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003C8F RID: 15503
		public const int EntityIdFieldNumber = 12;

		// Token: 0x04003C90 RID: 15504
		private long entityId_;

		// Token: 0x04003C91 RID: 15505
		public const int DirFieldNumber = 11;

		// Token: 0x04003C92 RID: 15506
		private bool dir_;
	}
}
