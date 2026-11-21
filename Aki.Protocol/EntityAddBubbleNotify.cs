using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200044E RID: 1102
	[NetMessage(EMessageId.EntityAddBubbleNotify)]
	public sealed class EntityAddBubbleNotify : IMessage<EntityAddBubbleNotify>, IMessage, IEquatable<EntityAddBubbleNotify>, IDeepCloneable<EntityAddBubbleNotify>, IBufferMessage
	{
		// Token: 0x060069D2 RID: 27090 RVA: 0x0010005B File Offset: 0x000FE25B
		[NullableContext(1)]
		public static EntityAddBubbleNotify Create()
		{
			return new EntityAddBubbleNotify();
		}

		// Token: 0x17001405 RID: 5125
		// (get) Token: 0x060069D3 RID: 27091 RVA: 0x00100062 File Offset: 0x000FE262
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001406 RID: 5126
		// (get) Token: 0x060069D4 RID: 27092 RVA: 0x00100065 File Offset: 0x000FE265
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EntityAddBubbleNotify.Descriptor;
			}
		}

		// Token: 0x060069D5 RID: 27093 RVA: 0x0010006C File Offset: 0x000FE26C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityAddBubbleNotify()
		{
		}

		// Token: 0x060069D6 RID: 27094 RVA: 0x0010007F File Offset: 0x000FE27F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityAddBubbleNotify(EntityAddBubbleNotify other) : this()
		{
			this.entityId_ = other.entityId_;
			this.actionGuid_ = other.actionGuid_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060069D7 RID: 27095 RVA: 0x001000B0 File Offset: 0x000FE2B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityAddBubbleNotify Clone()
		{
			return new EntityAddBubbleNotify(this);
		}

		// Token: 0x17001407 RID: 5127
		// (get) Token: 0x060069D8 RID: 27096 RVA: 0x001000B8 File Offset: 0x000FE2B8
		// (set) Token: 0x060069D9 RID: 27097 RVA: 0x001000C0 File Offset: 0x000FE2C0
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

		// Token: 0x17001408 RID: 5128
		// (get) Token: 0x060069DA RID: 27098 RVA: 0x001000C9 File Offset: 0x000FE2C9
		// (set) Token: 0x060069DB RID: 27099 RVA: 0x001000D1 File Offset: 0x000FE2D1
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

		// Token: 0x060069DC RID: 27100 RVA: 0x001000E4 File Offset: 0x000FE2E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EntityAddBubbleNotify);
		}

		// Token: 0x060069DD RID: 27101 RVA: 0x001000F4 File Offset: 0x000FE2F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EntityAddBubbleNotify other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && !(this.ActionGuid != other.ActionGuid) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060069DE RID: 27102 RVA: 0x00100144 File Offset: 0x000FE344
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

		// Token: 0x060069DF RID: 27103 RVA: 0x0010019E File Offset: 0x000FE39E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060069E0 RID: 27104 RVA: 0x001001AB File Offset: 0x000FE3AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060069E1 RID: 27105 RVA: 0x001001B4 File Offset: 0x000FE3B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(48);
				output.WriteInt64(this.EntityId);
			}
			if (this.ActionGuid.Length != 0)
			{
				output.WriteRawTag(66);
				output.WriteString(this.ActionGuid);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060069E2 RID: 27106 RVA: 0x00100214 File Offset: 0x000FE414
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

		// Token: 0x060069E3 RID: 27107 RVA: 0x00100270 File Offset: 0x000FE470
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

		// Token: 0x060069E4 RID: 27108 RVA: 0x001002C5 File Offset: 0x000FE4C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060069E5 RID: 27109 RVA: 0x001002D0 File Offset: 0x000FE4D0
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
				if (num != 48U)
				{
					if (num != 66U)
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

		// Token: 0x04003A80 RID: 14976
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003A81 RID: 14977
		public const int EntityIdFieldNumber = 6;

		// Token: 0x04003A82 RID: 14978
		private long entityId_;

		// Token: 0x04003A83 RID: 14979
		public const int ActionGuidFieldNumber = 8;

		// Token: 0x04003A84 RID: 14980
		private string actionGuid_ = "";
	}
}
