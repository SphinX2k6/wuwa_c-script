using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000481 RID: 1153
	[NetMessage(EMessageId.EntityInteractRequest)]
	public sealed class EntityInteractRequest : IMessage<EntityInteractRequest>, IMessage, IEquatable<EntityInteractRequest>, IDeepCloneable<EntityInteractRequest>, IBufferMessage
	{
		// Token: 0x06006EC4 RID: 28356 RVA: 0x00110A98 File Offset: 0x0010EC98
		[NullableContext(1)]
		public static EntityInteractRequest Create()
		{
			return new EntityInteractRequest();
		}

		// Token: 0x1700154F RID: 5455
		// (get) Token: 0x06006EC5 RID: 28357 RVA: 0x00110A9F File Offset: 0x0010EC9F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001550 RID: 5456
		// (get) Token: 0x06006EC6 RID: 28358 RVA: 0x00110AA2 File Offset: 0x0010ECA2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EntityInteractRequest.Descriptor;
			}
		}

		// Token: 0x06006EC7 RID: 28359 RVA: 0x00110AA9 File Offset: 0x0010ECA9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityInteractRequest()
		{
		}

		// Token: 0x06006EC8 RID: 28360 RVA: 0x00110AB1 File Offset: 0x0010ECB1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityInteractRequest(EntityInteractRequest other) : this()
		{
			this.entityId_ = other.entityId_;
			this.optionIndex_ = other.optionIndex_;
			this.visionEntityId_ = other.visionEntityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006EC9 RID: 28361 RVA: 0x00110AEE File Offset: 0x0010ECEE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityInteractRequest Clone()
		{
			return new EntityInteractRequest(this);
		}

		// Token: 0x17001551 RID: 5457
		// (get) Token: 0x06006ECA RID: 28362 RVA: 0x00110AF6 File Offset: 0x0010ECF6
		// (set) Token: 0x06006ECB RID: 28363 RVA: 0x00110AFE File Offset: 0x0010ECFE
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

		// Token: 0x17001552 RID: 5458
		// (get) Token: 0x06006ECC RID: 28364 RVA: 0x00110B07 File Offset: 0x0010ED07
		// (set) Token: 0x06006ECD RID: 28365 RVA: 0x00110B0F File Offset: 0x0010ED0F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int OptionIndex
		{
			get
			{
				return this.optionIndex_;
			}
			set
			{
				this.optionIndex_ = value;
			}
		}

		// Token: 0x17001553 RID: 5459
		// (get) Token: 0x06006ECE RID: 28366 RVA: 0x00110B18 File Offset: 0x0010ED18
		// (set) Token: 0x06006ECF RID: 28367 RVA: 0x00110B20 File Offset: 0x0010ED20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long VisionEntityId
		{
			get
			{
				return this.visionEntityId_;
			}
			set
			{
				this.visionEntityId_ = value;
			}
		}

		// Token: 0x06006ED0 RID: 28368 RVA: 0x00110B29 File Offset: 0x0010ED29
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EntityInteractRequest);
		}

		// Token: 0x06006ED1 RID: 28369 RVA: 0x00110B38 File Offset: 0x0010ED38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EntityInteractRequest other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && this.OptionIndex == other.OptionIndex && this.VisionEntityId == other.VisionEntityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006ED2 RID: 28370 RVA: 0x00110B94 File Offset: 0x0010ED94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EntityId != 0L)
			{
				num ^= this.EntityId.GetHashCode();
			}
			if (this.OptionIndex != 0)
			{
				num ^= this.OptionIndex.GetHashCode();
			}
			if (this.VisionEntityId != 0L)
			{
				num ^= this.VisionEntityId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06006ED3 RID: 28371 RVA: 0x00110C05 File Offset: 0x0010EE05
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06006ED4 RID: 28372 RVA: 0x00110C12 File Offset: 0x0010EE12
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006ED5 RID: 28373 RVA: 0x00110C1C File Offset: 0x0010EE1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.OptionIndex != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.OptionIndex);
			}
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(56);
				output.WriteInt64(this.EntityId);
			}
			if (this.VisionEntityId != 0L)
			{
				output.WriteRawTag(112);
				output.WriteInt64(this.VisionEntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006ED6 RID: 28374 RVA: 0x00110C94 File Offset: 0x0010EE94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EntityId);
			}
			if (this.OptionIndex != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.OptionIndex);
			}
			if (this.VisionEntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.VisionEntityId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06006ED7 RID: 28375 RVA: 0x00110D04 File Offset: 0x0010EF04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EntityInteractRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EntityId != 0L)
			{
				this.EntityId = other.EntityId;
			}
			if (other.OptionIndex != 0)
			{
				this.OptionIndex = other.OptionIndex;
			}
			if (other.VisionEntityId != 0L)
			{
				this.VisionEntityId = other.VisionEntityId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06006ED8 RID: 28376 RVA: 0x00110D68 File Offset: 0x0010EF68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006ED9 RID: 28377 RVA: 0x00110D74 File Offset: 0x0010EF74
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
					if (num != 56U)
					{
						if (num != 112U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.VisionEntityId = input.ReadInt64();
						}
					}
					else
					{
						this.EntityId = input.ReadInt64();
					}
				}
				else
				{
					this.OptionIndex = input.ReadInt32();
				}
			}
		}

		// Token: 0x04003C1E RID: 15390
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003C1F RID: 15391
		public const int EntityIdFieldNumber = 7;

		// Token: 0x04003C20 RID: 15392
		private long entityId_;

		// Token: 0x04003C21 RID: 15393
		public const int OptionIndexFieldNumber = 6;

		// Token: 0x04003C22 RID: 15394
		private int optionIndex_;

		// Token: 0x04003C23 RID: 15395
		public const int VisionEntityIdFieldNumber = 14;

		// Token: 0x04003C24 RID: 15396
		private long visionEntityId_;
	}
}
