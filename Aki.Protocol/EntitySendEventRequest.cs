using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020004A7 RID: 1191
	[NetMessage(EMessageId.EntitySendEventRequest)]
	public sealed class EntitySendEventRequest : IMessage<EntitySendEventRequest>, IMessage, IEquatable<EntitySendEventRequest>, IDeepCloneable<EntitySendEventRequest>, IBufferMessage
	{
		// Token: 0x060071F2 RID: 29170 RVA: 0x00118137 File Offset: 0x00116337
		[NullableContext(1)]
		public static EntitySendEventRequest Create()
		{
			return new EntitySendEventRequest();
		}

		// Token: 0x17001603 RID: 5635
		// (get) Token: 0x060071F3 RID: 29171 RVA: 0x0011813E File Offset: 0x0011633E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001604 RID: 5636
		// (get) Token: 0x060071F4 RID: 29172 RVA: 0x00118141 File Offset: 0x00116341
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EntitySendEventRequest.Descriptor;
			}
		}

		// Token: 0x060071F5 RID: 29173 RVA: 0x00118148 File Offset: 0x00116348
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntitySendEventRequest()
		{
		}

		// Token: 0x060071F6 RID: 29174 RVA: 0x0011815B File Offset: 0x0011635B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntitySendEventRequest(EntitySendEventRequest other) : this()
		{
			this.entityId_ = other.entityId_;
			this.eventKey_ = other.eventKey_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060071F7 RID: 29175 RVA: 0x0011818C File Offset: 0x0011638C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntitySendEventRequest Clone()
		{
			return new EntitySendEventRequest(this);
		}

		// Token: 0x17001605 RID: 5637
		// (get) Token: 0x060071F8 RID: 29176 RVA: 0x00118194 File Offset: 0x00116394
		// (set) Token: 0x060071F9 RID: 29177 RVA: 0x0011819C File Offset: 0x0011639C
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

		// Token: 0x17001606 RID: 5638
		// (get) Token: 0x060071FA RID: 29178 RVA: 0x001181A5 File Offset: 0x001163A5
		// (set) Token: 0x060071FB RID: 29179 RVA: 0x001181AD File Offset: 0x001163AD
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

		// Token: 0x060071FC RID: 29180 RVA: 0x001181C0 File Offset: 0x001163C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EntitySendEventRequest);
		}

		// Token: 0x060071FD RID: 29181 RVA: 0x001181D0 File Offset: 0x001163D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EntitySendEventRequest other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && !(this.EventKey != other.EventKey) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060071FE RID: 29182 RVA: 0x00118220 File Offset: 0x00116420
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

		// Token: 0x060071FF RID: 29183 RVA: 0x0011827A File Offset: 0x0011647A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06007200 RID: 29184 RVA: 0x00118287 File Offset: 0x00116487
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007201 RID: 29185 RVA: 0x00118290 File Offset: 0x00116490
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EventKey.Length != 0)
			{
				output.WriteRawTag(42);
				output.WriteString(this.EventKey);
			}
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(104);
				output.WriteInt64(this.EntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007202 RID: 29186 RVA: 0x001182F0 File Offset: 0x001164F0
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

		// Token: 0x06007203 RID: 29187 RVA: 0x0011834C File Offset: 0x0011654C
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

		// Token: 0x06007204 RID: 29188 RVA: 0x001183A1 File Offset: 0x001165A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007205 RID: 29189 RVA: 0x001183AC File Offset: 0x001165AC
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
				if (num != 42U)
				{
					if (num != 104U)
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

		// Token: 0x04003D15 RID: 15637
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003D16 RID: 15638
		public const int EntityIdFieldNumber = 13;

		// Token: 0x04003D17 RID: 15639
		private long entityId_;

		// Token: 0x04003D18 RID: 15640
		public const int EventKeyFieldNumber = 5;

		// Token: 0x04003D19 RID: 15641
		private string eventKey_ = "";
	}
}
