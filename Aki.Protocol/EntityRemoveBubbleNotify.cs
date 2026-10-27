using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020004B8 RID: 1208
	[NetMessage(EMessageId.EntityRemoveBubbleNotify)]
	public sealed class EntityRemoveBubbleNotify : IMessage<EntityRemoveBubbleNotify>, IMessage, IEquatable<EntityRemoveBubbleNotify>, IDeepCloneable<EntityRemoveBubbleNotify>, IBufferMessage
	{
		// Token: 0x06007308 RID: 29448 RVA: 0x0011A1E4 File Offset: 0x001183E4
		[NullableContext(1)]
		public static EntityRemoveBubbleNotify Create()
		{
			return new EntityRemoveBubbleNotify();
		}

		// Token: 0x1700163F RID: 5695
		// (get) Token: 0x06007309 RID: 29449 RVA: 0x0011A1EB File Offset: 0x001183EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001640 RID: 5696
		// (get) Token: 0x0600730A RID: 29450 RVA: 0x0011A1EE File Offset: 0x001183EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EntityRemoveBubbleNotify.Descriptor;
			}
		}

		// Token: 0x0600730B RID: 29451 RVA: 0x0011A1F5 File Offset: 0x001183F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityRemoveBubbleNotify()
		{
		}

		// Token: 0x0600730C RID: 29452 RVA: 0x0011A208 File Offset: 0x00118408
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityRemoveBubbleNotify(EntityRemoveBubbleNotify other) : this()
		{
			this.entityId_ = other.entityId_;
			this.actionGuid_ = other.actionGuid_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600730D RID: 29453 RVA: 0x0011A239 File Offset: 0x00118439
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityRemoveBubbleNotify Clone()
		{
			return new EntityRemoveBubbleNotify(this);
		}

		// Token: 0x17001641 RID: 5697
		// (get) Token: 0x0600730E RID: 29454 RVA: 0x0011A241 File Offset: 0x00118441
		// (set) Token: 0x0600730F RID: 29455 RVA: 0x0011A249 File Offset: 0x00118449
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

		// Token: 0x17001642 RID: 5698
		// (get) Token: 0x06007310 RID: 29456 RVA: 0x0011A252 File Offset: 0x00118452
		// (set) Token: 0x06007311 RID: 29457 RVA: 0x0011A25A File Offset: 0x0011845A
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

		// Token: 0x06007312 RID: 29458 RVA: 0x0011A26D File Offset: 0x0011846D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EntityRemoveBubbleNotify);
		}

		// Token: 0x06007313 RID: 29459 RVA: 0x0011A27C File Offset: 0x0011847C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EntityRemoveBubbleNotify other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && !(this.ActionGuid != other.ActionGuid) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007314 RID: 29460 RVA: 0x0011A2CC File Offset: 0x001184CC
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

		// Token: 0x06007315 RID: 29461 RVA: 0x0011A326 File Offset: 0x00118526
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06007316 RID: 29462 RVA: 0x0011A333 File Offset: 0x00118533
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007317 RID: 29463 RVA: 0x0011A33C File Offset: 0x0011853C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ActionGuid.Length != 0)
			{
				output.WriteRawTag(50);
				output.WriteString(this.ActionGuid);
			}
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(64);
				output.WriteInt64(this.EntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007318 RID: 29464 RVA: 0x0011A39C File Offset: 0x0011859C
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

		// Token: 0x06007319 RID: 29465 RVA: 0x0011A3F8 File Offset: 0x001185F8
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

		// Token: 0x0600731A RID: 29466 RVA: 0x0011A44D File Offset: 0x0011864D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600731B RID: 29467 RVA: 0x0011A458 File Offset: 0x00118658
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
				if (num != 50U)
				{
					if (num != 64U)
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

		// Token: 0x04003D09 RID: 15625
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003D0A RID: 15626
		public const int EntityIdFieldNumber = 8;

		// Token: 0x04003D0B RID: 15627
		private long entityId_;

		// Token: 0x04003D0C RID: 15628
		public const int ActionGuidFieldNumber = 6;

		// Token: 0x04003D0D RID: 15629
		private string actionGuid_ = "";
	}
}
