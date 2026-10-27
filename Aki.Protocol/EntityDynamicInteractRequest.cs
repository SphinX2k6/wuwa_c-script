using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000485 RID: 1157
	[NetMessage(EMessageId.EntityDynamicInteractRequest)]
	public sealed class EntityDynamicInteractRequest : IMessage<EntityDynamicInteractRequest>, IMessage, IEquatable<EntityDynamicInteractRequest>, IDeepCloneable<EntityDynamicInteractRequest>, IBufferMessage
	{
		// Token: 0x06006EC2 RID: 28354 RVA: 0x0010FFF7 File Offset: 0x0010E1F7
		[NullableContext(1)]
		public static EntityDynamicInteractRequest Create()
		{
			return new EntityDynamicInteractRequest();
		}

		// Token: 0x1700154C RID: 5452
		// (get) Token: 0x06006EC3 RID: 28355 RVA: 0x0010FFFE File Offset: 0x0010E1FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700154D RID: 5453
		// (get) Token: 0x06006EC4 RID: 28356 RVA: 0x00110001 File Offset: 0x0010E201
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EntityDynamicInteractRequest.Descriptor;
			}
		}

		// Token: 0x06006EC5 RID: 28357 RVA: 0x00110008 File Offset: 0x0010E208
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityDynamicInteractRequest()
		{
		}

		// Token: 0x06006EC6 RID: 28358 RVA: 0x0011001B File Offset: 0x0010E21B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityDynamicInteractRequest(EntityDynamicInteractRequest other) : this()
		{
			this.entityId_ = other.entityId_;
			this.optionGuid_ = other.optionGuid_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006EC7 RID: 28359 RVA: 0x0011004C File Offset: 0x0010E24C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityDynamicInteractRequest Clone()
		{
			return new EntityDynamicInteractRequest(this);
		}

		// Token: 0x1700154E RID: 5454
		// (get) Token: 0x06006EC8 RID: 28360 RVA: 0x00110054 File Offset: 0x0010E254
		// (set) Token: 0x06006EC9 RID: 28361 RVA: 0x0011005C File Offset: 0x0010E25C
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

		// Token: 0x1700154F RID: 5455
		// (get) Token: 0x06006ECA RID: 28362 RVA: 0x00110065 File Offset: 0x0010E265
		// (set) Token: 0x06006ECB RID: 28363 RVA: 0x0011006D File Offset: 0x0010E26D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string OptionGuid
		{
			get
			{
				return this.optionGuid_;
			}
			set
			{
				this.optionGuid_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x06006ECC RID: 28364 RVA: 0x00110080 File Offset: 0x0010E280
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EntityDynamicInteractRequest);
		}

		// Token: 0x06006ECD RID: 28365 RVA: 0x00110090 File Offset: 0x0010E290
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EntityDynamicInteractRequest other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && !(this.OptionGuid != other.OptionGuid) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006ECE RID: 28366 RVA: 0x001100E0 File Offset: 0x0010E2E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EntityId != 0L)
			{
				num ^= this.EntityId.GetHashCode();
			}
			if (this.OptionGuid.Length != 0)
			{
				num ^= this.OptionGuid.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06006ECF RID: 28367 RVA: 0x0011013A File Offset: 0x0010E33A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06006ED0 RID: 28368 RVA: 0x00110147 File Offset: 0x0010E347
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006ED1 RID: 28369 RVA: 0x00110150 File Offset: 0x0010E350
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.OptionGuid.Length != 0)
			{
				output.WriteRawTag(42);
				output.WriteString(this.OptionGuid);
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

		// Token: 0x06006ED2 RID: 28370 RVA: 0x001101B0 File Offset: 0x0010E3B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EntityId);
			}
			if (this.OptionGuid.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.OptionGuid);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06006ED3 RID: 28371 RVA: 0x0011020C File Offset: 0x0010E40C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EntityDynamicInteractRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EntityId != 0L)
			{
				this.EntityId = other.EntityId;
			}
			if (other.OptionGuid.Length != 0)
			{
				this.OptionGuid = other.OptionGuid;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06006ED4 RID: 28372 RVA: 0x00110261 File Offset: 0x0010E461
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006ED5 RID: 28373 RVA: 0x0011026C File Offset: 0x0010E46C
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
					if (num != 80U)
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
					this.OptionGuid = input.ReadString();
				}
			}
		}

		// Token: 0x04003BB8 RID: 15288
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003BB9 RID: 15289
		public const int EntityIdFieldNumber = 10;

		// Token: 0x04003BBA RID: 15290
		private long entityId_;

		// Token: 0x04003BBB RID: 15291
		public const int OptionGuidFieldNumber = 5;

		// Token: 0x04003BBC RID: 15292
		private string optionGuid_ = "";
	}
}
