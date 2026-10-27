using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000498 RID: 1176
	[NetMessage(EMessageId.EntityInteractRequest)]
	public sealed class EntityInteractRequest : IMessage<EntityInteractRequest>, IMessage, IEquatable<EntityInteractRequest>, IDeepCloneable<EntityInteractRequest>, IBufferMessage
	{
		// Token: 0x06007052 RID: 28754 RVA: 0x00113B0C File Offset: 0x00111D0C
		[NullableContext(1)]
		public static EntityInteractRequest Create()
		{
			return new EntityInteractRequest();
		}

		// Token: 0x170015A3 RID: 5539
		// (get) Token: 0x06007053 RID: 28755 RVA: 0x00113B13 File Offset: 0x00111D13
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170015A4 RID: 5540
		// (get) Token: 0x06007054 RID: 28756 RVA: 0x00113B16 File Offset: 0x00111D16
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EntityInteractRequest.Descriptor;
			}
		}

		// Token: 0x06007055 RID: 28757 RVA: 0x00113B1D File Offset: 0x00111D1D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityInteractRequest()
		{
		}

		// Token: 0x06007056 RID: 28758 RVA: 0x00113B25 File Offset: 0x00111D25
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityInteractRequest(EntityInteractRequest other) : this()
		{
			this.entityId_ = other.entityId_;
			this.optionIndex_ = other.optionIndex_;
			this.visionEntityId_ = other.visionEntityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007057 RID: 28759 RVA: 0x00113B62 File Offset: 0x00111D62
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityInteractRequest Clone()
		{
			return new EntityInteractRequest(this);
		}

		// Token: 0x170015A5 RID: 5541
		// (get) Token: 0x06007058 RID: 28760 RVA: 0x00113B6A File Offset: 0x00111D6A
		// (set) Token: 0x06007059 RID: 28761 RVA: 0x00113B72 File Offset: 0x00111D72
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

		// Token: 0x170015A6 RID: 5542
		// (get) Token: 0x0600705A RID: 28762 RVA: 0x00113B7B File Offset: 0x00111D7B
		// (set) Token: 0x0600705B RID: 28763 RVA: 0x00113B83 File Offset: 0x00111D83
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

		// Token: 0x170015A7 RID: 5543
		// (get) Token: 0x0600705C RID: 28764 RVA: 0x00113B8C File Offset: 0x00111D8C
		// (set) Token: 0x0600705D RID: 28765 RVA: 0x00113B94 File Offset: 0x00111D94
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

		// Token: 0x0600705E RID: 28766 RVA: 0x00113B9D File Offset: 0x00111D9D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EntityInteractRequest);
		}

		// Token: 0x0600705F RID: 28767 RVA: 0x00113BAC File Offset: 0x00111DAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EntityInteractRequest other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && this.OptionIndex == other.OptionIndex && this.VisionEntityId == other.VisionEntityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007060 RID: 28768 RVA: 0x00113C08 File Offset: 0x00111E08
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

		// Token: 0x06007061 RID: 28769 RVA: 0x00113C79 File Offset: 0x00111E79
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06007062 RID: 28770 RVA: 0x00113C86 File Offset: 0x00111E86
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007063 RID: 28771 RVA: 0x00113C90 File Offset: 0x00111E90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.OptionIndex != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.OptionIndex);
			}
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(56);
				output.WriteInt64(this.EntityId);
			}
			if (this.VisionEntityId != 0L)
			{
				output.WriteRawTag(64);
				output.WriteInt64(this.VisionEntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007064 RID: 28772 RVA: 0x00113D08 File Offset: 0x00111F08
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

		// Token: 0x06007065 RID: 28773 RVA: 0x00113D78 File Offset: 0x00111F78
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

		// Token: 0x06007066 RID: 28774 RVA: 0x00113DDC File Offset: 0x00111FDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007067 RID: 28775 RVA: 0x00113DE8 File Offset: 0x00111FE8
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
				if (num != 16U)
				{
					if (num != 56U)
					{
						if (num != 64U)
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

		// Token: 0x04003C30 RID: 15408
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003C31 RID: 15409
		public const int EntityIdFieldNumber = 7;

		// Token: 0x04003C32 RID: 15410
		private long entityId_;

		// Token: 0x04003C33 RID: 15411
		public const int OptionIndexFieldNumber = 2;

		// Token: 0x04003C34 RID: 15412
		private int optionIndex_;

		// Token: 0x04003C35 RID: 15413
		public const int VisionEntityIdFieldNumber = 8;

		// Token: 0x04003C36 RID: 15414
		private long visionEntityId_;
	}
}
