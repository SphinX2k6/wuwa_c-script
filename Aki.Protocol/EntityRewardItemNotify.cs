using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020004BC RID: 1212
	[NetMessage(EMessageId.EntityRewardItemNotify)]
	public sealed class EntityRewardItemNotify : IMessage<EntityRewardItemNotify>, IMessage, IEquatable<EntityRewardItemNotify>, IDeepCloneable<EntityRewardItemNotify>, IBufferMessage
	{
		// Token: 0x0600735A RID: 29530 RVA: 0x0011ACD4 File Offset: 0x00118ED4
		[NullableContext(1)]
		public static EntityRewardItemNotify Create()
		{
			return new EntityRewardItemNotify();
		}

		// Token: 0x17001650 RID: 5712
		// (get) Token: 0x0600735B RID: 29531 RVA: 0x0011ACDB File Offset: 0x00118EDB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001651 RID: 5713
		// (get) Token: 0x0600735C RID: 29532 RVA: 0x0011ACDE File Offset: 0x00118EDE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EntityRewardItemNotify.Descriptor;
			}
		}

		// Token: 0x0600735D RID: 29533 RVA: 0x0011ACE5 File Offset: 0x00118EE5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityRewardItemNotify()
		{
		}

		// Token: 0x0600735E RID: 29534 RVA: 0x0011ACF0 File Offset: 0x00118EF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityRewardItemNotify(EntityRewardItemNotify other) : this()
		{
			this.id_ = other.id_;
			this.entityRewardItemPb_ = ((other.entityRewardItemPb_ != null) ? other.entityRewardItemPb_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600735F RID: 29535 RVA: 0x0011AD3C File Offset: 0x00118F3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityRewardItemNotify Clone()
		{
			return new EntityRewardItemNotify(this);
		}

		// Token: 0x17001652 RID: 5714
		// (get) Token: 0x06007360 RID: 29536 RVA: 0x0011AD44 File Offset: 0x00118F44
		// (set) Token: 0x06007361 RID: 29537 RVA: 0x0011AD4C File Offset: 0x00118F4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long Id
		{
			get
			{
				return this.id_;
			}
			set
			{
				this.id_ = value;
			}
		}

		// Token: 0x17001653 RID: 5715
		// (get) Token: 0x06007362 RID: 29538 RVA: 0x0011AD55 File Offset: 0x00118F55
		// (set) Token: 0x06007363 RID: 29539 RVA: 0x0011AD5D File Offset: 0x00118F5D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityRewardItemPb EntityRewardItemPb
		{
			get
			{
				return this.entityRewardItemPb_;
			}
			set
			{
				this.entityRewardItemPb_ = value;
			}
		}

		// Token: 0x06007364 RID: 29540 RVA: 0x0011AD66 File Offset: 0x00118F66
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EntityRewardItemNotify);
		}

		// Token: 0x06007365 RID: 29541 RVA: 0x0011AD74 File Offset: 0x00118F74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EntityRewardItemNotify other)
		{
			return other != null && (other == this || (this.Id == other.Id && object.Equals(this.EntityRewardItemPb, other.EntityRewardItemPb) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007366 RID: 29542 RVA: 0x0011ADC4 File Offset: 0x00118FC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0L)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.entityRewardItemPb_ != null)
			{
				num ^= this.EntityRewardItemPb.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06007367 RID: 29543 RVA: 0x0011AE19 File Offset: 0x00119019
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06007368 RID: 29544 RVA: 0x0011AE26 File Offset: 0x00119026
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007369 RID: 29545 RVA: 0x0011AE30 File Offset: 0x00119030
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.entityRewardItemPb_ != null)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.EntityRewardItemPb);
			}
			if (this.Id != 0L)
			{
				output.WriteRawTag(72);
				output.WriteInt64(this.Id);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600736A RID: 29546 RVA: 0x0011AE8C File Offset: 0x0011908C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.Id);
			}
			if (this.entityRewardItemPb_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.EntityRewardItemPb);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600736B RID: 29547 RVA: 0x0011AEE4 File Offset: 0x001190E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EntityRewardItemNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0L)
			{
				this.Id = other.Id;
			}
			if (other.entityRewardItemPb_ != null)
			{
				if (this.entityRewardItemPb_ == null)
				{
					this.EntityRewardItemPb = new EntityRewardItemPb();
				}
				this.EntityRewardItemPb.MergeFrom(other.EntityRewardItemPb);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600736C RID: 29548 RVA: 0x0011AF4C File Offset: 0x0011914C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600736D RID: 29549 RVA: 0x0011AF58 File Offset: 0x00119158
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
				if (num != 34U)
				{
					if (num != 72U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Id = input.ReadInt64();
					}
				}
				else
				{
					if (this.entityRewardItemPb_ == null)
					{
						this.EntityRewardItemPb = new EntityRewardItemPb();
					}
					input.ReadMessage(this.EntityRewardItemPb);
				}
			}
		}

		// Token: 0x04003D1F RID: 15647
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003D20 RID: 15648
		public const int IdFieldNumber = 9;

		// Token: 0x04003D21 RID: 15649
		private long id_;

		// Token: 0x04003D22 RID: 15650
		public const int EntityRewardItemPbFieldNumber = 4;

		// Token: 0x04003D23 RID: 15651
		private EntityRewardItemPb entityRewardItemPb_;
	}
}
