using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000465 RID: 1125
	[NetMessage(EMessageId.EntityAddBubbleNotify)]
	public sealed class EntityAddBubbleNotify : IMessage<EntityAddBubbleNotify>, IMessage, IEquatable<EntityAddBubbleNotify>, IDeepCloneable<EntityAddBubbleNotify>, IBufferMessage
	{
		// Token: 0x06006B60 RID: 27488 RVA: 0x001030CA File Offset: 0x001012CA
		[NullableContext(1)]
		public static EntityAddBubbleNotify Create()
		{
			return new EntityAddBubbleNotify();
		}

		// Token: 0x17001459 RID: 5209
		// (get) Token: 0x06006B61 RID: 27489 RVA: 0x001030D1 File Offset: 0x001012D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700145A RID: 5210
		// (get) Token: 0x06006B62 RID: 27490 RVA: 0x001030D4 File Offset: 0x001012D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EntityAddBubbleNotify.Descriptor;
			}
		}

		// Token: 0x06006B63 RID: 27491 RVA: 0x001030DB File Offset: 0x001012DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityAddBubbleNotify()
		{
		}

		// Token: 0x06006B64 RID: 27492 RVA: 0x001030EE File Offset: 0x001012EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityAddBubbleNotify(EntityAddBubbleNotify other) : this()
		{
			this.entityId_ = other.entityId_;
			this.actionGuid_ = other.actionGuid_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006B65 RID: 27493 RVA: 0x0010311F File Offset: 0x0010131F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityAddBubbleNotify Clone()
		{
			return new EntityAddBubbleNotify(this);
		}

		// Token: 0x1700145B RID: 5211
		// (get) Token: 0x06006B66 RID: 27494 RVA: 0x00103127 File Offset: 0x00101327
		// (set) Token: 0x06006B67 RID: 27495 RVA: 0x0010312F File Offset: 0x0010132F
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

		// Token: 0x1700145C RID: 5212
		// (get) Token: 0x06006B68 RID: 27496 RVA: 0x00103138 File Offset: 0x00101338
		// (set) Token: 0x06006B69 RID: 27497 RVA: 0x00103140 File Offset: 0x00101340
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

		// Token: 0x06006B6A RID: 27498 RVA: 0x00103153 File Offset: 0x00101353
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EntityAddBubbleNotify);
		}

		// Token: 0x06006B6B RID: 27499 RVA: 0x00103164 File Offset: 0x00101364
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EntityAddBubbleNotify other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && !(this.ActionGuid != other.ActionGuid) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006B6C RID: 27500 RVA: 0x001031B4 File Offset: 0x001013B4
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

		// Token: 0x06006B6D RID: 27501 RVA: 0x0010320E File Offset: 0x0010140E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06006B6E RID: 27502 RVA: 0x0010321B File Offset: 0x0010141B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006B6F RID: 27503 RVA: 0x00103224 File Offset: 0x00101424
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(40);
				output.WriteInt64(this.EntityId);
			}
			if (this.ActionGuid.Length != 0)
			{
				output.WriteRawTag(90);
				output.WriteString(this.ActionGuid);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006B70 RID: 27504 RVA: 0x00103284 File Offset: 0x00101484
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

		// Token: 0x06006B71 RID: 27505 RVA: 0x001032E0 File Offset: 0x001014E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EntityAddBubbleNotify other)
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

		// Token: 0x06006B72 RID: 27506 RVA: 0x00103335 File Offset: 0x00101535
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006B73 RID: 27507 RVA: 0x00103340 File Offset: 0x00101540
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
					if (num != 90U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ActionGuid = input.ReadString();
					}
				}
				else
				{
					this.EntityId = input.ReadInt64();
				}
			}
		}

		// Token: 0x04003A92 RID: 14994
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003A93 RID: 14995
		public const int EntityIdFieldNumber = 5;

		// Token: 0x04003A94 RID: 14996
		private long entityId_;

		// Token: 0x04003A95 RID: 14997
		public const int ActionGuidFieldNumber = 11;

		// Token: 0x04003A96 RID: 14998
		private string actionGuid_ = "";
	}
}
