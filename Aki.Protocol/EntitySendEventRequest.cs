using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020004BE RID: 1214
	[NetMessage(EMessageId.EntitySendEventRequest)]
	public sealed class EntitySendEventRequest : IMessage<EntitySendEventRequest>, IMessage, IEquatable<EntitySendEventRequest>, IDeepCloneable<EntitySendEventRequest>, IBufferMessage
	{
		// Token: 0x06007382 RID: 29570 RVA: 0x0011B257 File Offset: 0x00119457
		[NullableContext(1)]
		public static EntitySendEventRequest Create()
		{
			return new EntitySendEventRequest();
		}

		// Token: 0x17001658 RID: 5720
		// (get) Token: 0x06007383 RID: 29571 RVA: 0x0011B25E File Offset: 0x0011945E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001659 RID: 5721
		// (get) Token: 0x06007384 RID: 29572 RVA: 0x0011B261 File Offset: 0x00119461
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EntitySendEventRequest.Descriptor;
			}
		}

		// Token: 0x06007385 RID: 29573 RVA: 0x0011B268 File Offset: 0x00119468
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntitySendEventRequest()
		{
		}

		// Token: 0x06007386 RID: 29574 RVA: 0x0011B27B File Offset: 0x0011947B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntitySendEventRequest(EntitySendEventRequest other) : this()
		{
			this.entityId_ = other.entityId_;
			this.eventKey_ = other.eventKey_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007387 RID: 29575 RVA: 0x0011B2AC File Offset: 0x001194AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntitySendEventRequest Clone()
		{
			return new EntitySendEventRequest(this);
		}

		// Token: 0x1700165A RID: 5722
		// (get) Token: 0x06007388 RID: 29576 RVA: 0x0011B2B4 File Offset: 0x001194B4
		// (set) Token: 0x06007389 RID: 29577 RVA: 0x0011B2BC File Offset: 0x001194BC
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

		// Token: 0x1700165B RID: 5723
		// (get) Token: 0x0600738A RID: 29578 RVA: 0x0011B2C5 File Offset: 0x001194C5
		// (set) Token: 0x0600738B RID: 29579 RVA: 0x0011B2CD File Offset: 0x001194CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string EventKey
		{
			get
			{
				return this.eventKey_;
			}
			set
			{
				this.eventKey_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x0600738C RID: 29580 RVA: 0x0011B2E0 File Offset: 0x001194E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EntitySendEventRequest);
		}

		// Token: 0x0600738D RID: 29581 RVA: 0x0011B2F0 File Offset: 0x001194F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EntitySendEventRequest other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && !(this.EventKey != other.EventKey) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600738E RID: 29582 RVA: 0x0011B340 File Offset: 0x00119540
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EntityId != 0L)
			{
				num ^= this.EntityId.GetHashCode();
			}
			if (this.EventKey.Length != 0)
			{
				num ^= this.EventKey.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600738F RID: 29583 RVA: 0x0011B39A File Offset: 0x0011959A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06007390 RID: 29584 RVA: 0x0011B3A7 File Offset: 0x001195A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007391 RID: 29585 RVA: 0x0011B3B0 File Offset: 0x001195B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EventKey.Length != 0)
			{
				output.WriteRawTag(26);
				output.WriteString(this.EventKey);
			}
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(72);
				output.WriteInt64(this.EntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007392 RID: 29586 RVA: 0x0011B410 File Offset: 0x00119610
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EntityId);
			}
			if (this.EventKey.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.EventKey);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06007393 RID: 29587 RVA: 0x0011B46C File Offset: 0x0011966C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EntitySendEventRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EntityId != 0L)
			{
				this.EntityId = other.EntityId;
			}
			if (other.EventKey.Length != 0)
			{
				this.EventKey = other.EventKey;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06007394 RID: 29588 RVA: 0x0011B4C1 File Offset: 0x001196C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007395 RID: 29589 RVA: 0x0011B4CC File Offset: 0x001196CC
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
				if (num != 26U)
				{
					if (num != 72U)
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
					this.EventKey = input.ReadString();
				}
			}
		}

		// Token: 0x04003D29 RID: 15657
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003D2A RID: 15658
		public const int EntityIdFieldNumber = 9;

		// Token: 0x04003D2B RID: 15659
		private long entityId_;

		// Token: 0x04003D2C RID: 15660
		public const int EventKeyFieldNumber = 3;

		// Token: 0x04003D2D RID: 15661
		private string eventKey_ = "";
	}
}
