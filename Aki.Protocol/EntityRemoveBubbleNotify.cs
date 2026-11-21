using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020004A1 RID: 1185
	[NetMessage(EMessageId.EntityRemoveBubbleNotify)]
	public sealed class EntityRemoveBubbleNotify : IMessage<EntityRemoveBubbleNotify>, IMessage, IEquatable<EntityRemoveBubbleNotify>, IDeepCloneable<EntityRemoveBubbleNotify>, IBufferMessage
	{
		// Token: 0x06007178 RID: 29048 RVA: 0x001170C4 File Offset: 0x001152C4
		[NullableContext(1)]
		public static EntityRemoveBubbleNotify Create()
		{
			return new EntityRemoveBubbleNotify();
		}

		// Token: 0x170015EA RID: 5610
		// (get) Token: 0x06007179 RID: 29049 RVA: 0x001170CB File Offset: 0x001152CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170015EB RID: 5611
		// (get) Token: 0x0600717A RID: 29050 RVA: 0x001170CE File Offset: 0x001152CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EntityRemoveBubbleNotify.Descriptor;
			}
		}

		// Token: 0x0600717B RID: 29051 RVA: 0x001170D5 File Offset: 0x001152D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityRemoveBubbleNotify()
		{
		}

		// Token: 0x0600717C RID: 29052 RVA: 0x001170E8 File Offset: 0x001152E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityRemoveBubbleNotify(EntityRemoveBubbleNotify other) : this()
		{
			this.entityId_ = other.entityId_;
			this.actionGuid_ = other.actionGuid_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600717D RID: 29053 RVA: 0x00117119 File Offset: 0x00115319
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityRemoveBubbleNotify Clone()
		{
			return new EntityRemoveBubbleNotify(this);
		}

		// Token: 0x170015EC RID: 5612
		// (get) Token: 0x0600717E RID: 29054 RVA: 0x00117121 File Offset: 0x00115321
		// (set) Token: 0x0600717F RID: 29055 RVA: 0x00117129 File Offset: 0x00115329
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

		// Token: 0x170015ED RID: 5613
		// (get) Token: 0x06007180 RID: 29056 RVA: 0x00117132 File Offset: 0x00115332
		// (set) Token: 0x06007181 RID: 29057 RVA: 0x0011713A File Offset: 0x0011533A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string ActionGuid
		{
			get
			{
				return this.actionGuid_;
			}
			set
			{
				this.actionGuid_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x06007182 RID: 29058 RVA: 0x0011714D File Offset: 0x0011534D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EntityRemoveBubbleNotify);
		}

		// Token: 0x06007183 RID: 29059 RVA: 0x0011715C File Offset: 0x0011535C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EntityRemoveBubbleNotify other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && !(this.ActionGuid != other.ActionGuid) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007184 RID: 29060 RVA: 0x001171AC File Offset: 0x001153AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EntityId != 0L)
			{
				num ^= this.EntityId.GetHashCode();
			}
			if (this.ActionGuid.Length != 0)
			{
				num ^= this.ActionGuid.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06007185 RID: 29061 RVA: 0x00117206 File Offset: 0x00115406
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06007186 RID: 29062 RVA: 0x00117213 File Offset: 0x00115413
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007187 RID: 29063 RVA: 0x0011721C File Offset: 0x0011541C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ActionGuid.Length != 0)
			{
				output.WriteRawTag(74);
				output.WriteString(this.ActionGuid);
			}
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(112);
				output.WriteInt64(this.EntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007188 RID: 29064 RVA: 0x0011727C File Offset: 0x0011547C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EntityId);
			}
			if (this.ActionGuid.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.ActionGuid);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06007189 RID: 29065 RVA: 0x001172D8 File Offset: 0x001154D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EntityRemoveBubbleNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EntityId != 0L)
			{
				this.EntityId = other.EntityId;
			}
			if (other.ActionGuid.Length != 0)
			{
				this.ActionGuid = other.ActionGuid;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600718A RID: 29066 RVA: 0x0011732D File Offset: 0x0011552D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600718B RID: 29067 RVA: 0x00117338 File Offset: 0x00115538
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
				if (num != 74U)
				{
					if (num != 112U)
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
					this.ActionGuid = input.ReadString();
				}
			}
		}

		// Token: 0x04003CF5 RID: 15605
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003CF6 RID: 15606
		public const int EntityIdFieldNumber = 14;

		// Token: 0x04003CF7 RID: 15607
		private long entityId_;

		// Token: 0x04003CF8 RID: 15608
		public const int ActionGuidFieldNumber = 9;

		// Token: 0x04003CF9 RID: 15609
		private string actionGuid_ = "";
	}
}
