using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020004C4 RID: 1220
	[NetMessage(EMessageId.EntityStateReadyNotify)]
	public sealed class EntityStateReadyNotify : IMessage<EntityStateReadyNotify>, IMessage, IEquatable<EntityStateReadyNotify>, IDeepCloneable<EntityStateReadyNotify>, IBufferMessage
	{
		// Token: 0x060073FC RID: 29692 RVA: 0x0011C230 File Offset: 0x0011A430
		[NullableContext(1)]
		public static EntityStateReadyNotify Create()
		{
			return new EntityStateReadyNotify();
		}

		// Token: 0x17001671 RID: 5745
		// (get) Token: 0x060073FD RID: 29693 RVA: 0x0011C237 File Offset: 0x0011A437
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001672 RID: 5746
		// (get) Token: 0x060073FE RID: 29694 RVA: 0x0011C23A File Offset: 0x0011A43A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EntityStateReadyNotify.Descriptor;
			}
		}

		// Token: 0x060073FF RID: 29695 RVA: 0x0011C241 File Offset: 0x0011A441
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityStateReadyNotify()
		{
		}

		// Token: 0x06007400 RID: 29696 RVA: 0x0011C249 File Offset: 0x0011A449
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityStateReadyNotify(EntityStateReadyNotify other) : this()
		{
			this.entityId_ = other.entityId_;
			this.tagId_ = other.tagId_;
			this.ready_ = other.ready_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007401 RID: 29697 RVA: 0x0011C286 File Offset: 0x0011A486
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityStateReadyNotify Clone()
		{
			return new EntityStateReadyNotify(this);
		}

		// Token: 0x17001673 RID: 5747
		// (get) Token: 0x06007402 RID: 29698 RVA: 0x0011C28E File Offset: 0x0011A48E
		// (set) Token: 0x06007403 RID: 29699 RVA: 0x0011C296 File Offset: 0x0011A496
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

		// Token: 0x17001674 RID: 5748
		// (get) Token: 0x06007404 RID: 29700 RVA: 0x0011C29F File Offset: 0x0011A49F
		// (set) Token: 0x06007405 RID: 29701 RVA: 0x0011C2A7 File Offset: 0x0011A4A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TagId
		{
			get
			{
				return this.tagId_;
			}
			set
			{
				this.tagId_ = value;
			}
		}

		// Token: 0x17001675 RID: 5749
		// (get) Token: 0x06007406 RID: 29702 RVA: 0x0011C2B0 File Offset: 0x0011A4B0
		// (set) Token: 0x06007407 RID: 29703 RVA: 0x0011C2B8 File Offset: 0x0011A4B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Ready
		{
			get
			{
				return this.ready_;
			}
			set
			{
				this.ready_ = value;
			}
		}

		// Token: 0x06007408 RID: 29704 RVA: 0x0011C2C1 File Offset: 0x0011A4C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EntityStateReadyNotify);
		}

		// Token: 0x06007409 RID: 29705 RVA: 0x0011C2D0 File Offset: 0x0011A4D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EntityStateReadyNotify other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && this.TagId == other.TagId && this.Ready == other.Ready && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600740A RID: 29706 RVA: 0x0011C32C File Offset: 0x0011A52C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EntityId != 0L)
			{
				num ^= this.EntityId.GetHashCode();
			}
			if (this.TagId != 0)
			{
				num ^= this.TagId.GetHashCode();
			}
			if (this.Ready)
			{
				num ^= this.Ready.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600740B RID: 29707 RVA: 0x0011C39D File Offset: 0x0011A59D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600740C RID: 29708 RVA: 0x0011C3AA File Offset: 0x0011A5AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600740D RID: 29709 RVA: 0x0011C3B4 File Offset: 0x0011A5B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(8);
				output.WriteInt64(this.EntityId);
			}
			if (this.Ready)
			{
				output.WriteRawTag(64);
				output.WriteBool(this.Ready);
			}
			if (this.TagId != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.TagId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600740E RID: 29710 RVA: 0x0011C428 File Offset: 0x0011A628
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EntityId);
			}
			if (this.TagId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TagId);
			}
			if (this.Ready)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600740F RID: 29711 RVA: 0x0011C48C File Offset: 0x0011A68C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EntityStateReadyNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EntityId != 0L)
			{
				this.EntityId = other.EntityId;
			}
			if (other.TagId != 0)
			{
				this.TagId = other.TagId;
			}
			if (other.Ready)
			{
				this.Ready = other.Ready;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06007410 RID: 29712 RVA: 0x0011C4F0 File Offset: 0x0011A6F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007411 RID: 29713 RVA: 0x0011C4FC File Offset: 0x0011A6FC
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
				if (num != 8U)
				{
					if (num != 64U)
					{
						if (num != 80U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.TagId = input.ReadInt32();
						}
					}
					else
					{
						this.Ready = input.ReadBool();
					}
				}
				else
				{
					this.EntityId = input.ReadInt64();
				}
			}
		}

		// Token: 0x04003D49 RID: 15689
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003D4A RID: 15690
		public const int EntityIdFieldNumber = 1;

		// Token: 0x04003D4B RID: 15691
		private long entityId_;

		// Token: 0x04003D4C RID: 15692
		public const int TagIdFieldNumber = 10;

		// Token: 0x04003D4D RID: 15693
		private int tagId_;

		// Token: 0x04003D4E RID: 15694
		public const int ReadyFieldNumber = 8;

		// Token: 0x04003D4F RID: 15695
		private bool ready_;
	}
}
