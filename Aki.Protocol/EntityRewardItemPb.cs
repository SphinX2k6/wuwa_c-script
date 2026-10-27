using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020004BD RID: 1213
	public sealed class EntityRewardItemPb : IMessage<EntityRewardItemPb>, IMessage, IEquatable<EntityRewardItemPb>, IDeepCloneable<EntityRewardItemPb>, IBufferMessage
	{
		// Token: 0x0600736E RID: 29550 RVA: 0x0011AFC3 File Offset: 0x001191C3
		[NullableContext(1)]
		public static EntityRewardItemPb Create()
		{
			return new EntityRewardItemPb();
		}

		// Token: 0x17001654 RID: 5716
		// (get) Token: 0x0600736F RID: 29551 RVA: 0x0011AFCA File Offset: 0x001191CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001655 RID: 5717
		// (get) Token: 0x06007370 RID: 29552 RVA: 0x0011AFCD File Offset: 0x001191CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EntityRewardItemPb.Descriptor;
			}
		}

		// Token: 0x06007371 RID: 29553 RVA: 0x0011AFD4 File Offset: 0x001191D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityRewardItemPb()
		{
		}

		// Token: 0x06007372 RID: 29554 RVA: 0x0011AFDC File Offset: 0x001191DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityRewardItemPb(EntityRewardItemPb other) : this()
		{
			this.hasCount_ = other.hasCount_;
			this.nextResetTime_ = other.nextResetTime_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007373 RID: 29555 RVA: 0x0011B00D File Offset: 0x0011920D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityRewardItemPb Clone()
		{
			return new EntityRewardItemPb(this);
		}

		// Token: 0x17001656 RID: 5718
		// (get) Token: 0x06007374 RID: 29556 RVA: 0x0011B015 File Offset: 0x00119215
		// (set) Token: 0x06007375 RID: 29557 RVA: 0x0011B01D File Offset: 0x0011921D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int HasCount
		{
			get
			{
				return this.hasCount_;
			}
			set
			{
				this.hasCount_ = value;
			}
		}

		// Token: 0x17001657 RID: 5719
		// (get) Token: 0x06007376 RID: 29558 RVA: 0x0011B026 File Offset: 0x00119226
		// (set) Token: 0x06007377 RID: 29559 RVA: 0x0011B02E File Offset: 0x0011922E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long NextResetTime
		{
			get
			{
				return this.nextResetTime_;
			}
			set
			{
				this.nextResetTime_ = value;
			}
		}

		// Token: 0x06007378 RID: 29560 RVA: 0x0011B037 File Offset: 0x00119237
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EntityRewardItemPb);
		}

		// Token: 0x06007379 RID: 29561 RVA: 0x0011B045 File Offset: 0x00119245
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EntityRewardItemPb other)
		{
			return other != null && (other == this || (this.HasCount == other.HasCount && this.NextResetTime == other.NextResetTime && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600737A RID: 29562 RVA: 0x0011B084 File Offset: 0x00119284
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.HasCount != 0)
			{
				num ^= this.HasCount.GetHashCode();
			}
			if (this.NextResetTime != 0L)
			{
				num ^= this.NextResetTime.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600737B RID: 29563 RVA: 0x0011B0DC File Offset: 0x001192DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600737C RID: 29564 RVA: 0x0011B0E9 File Offset: 0x001192E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600737D RID: 29565 RVA: 0x0011B0F4 File Offset: 0x001192F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.HasCount != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.HasCount);
			}
			if (this.NextResetTime != 0L)
			{
				output.WriteRawTag(16);
				output.WriteInt64(this.NextResetTime);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600737E RID: 29566 RVA: 0x0011B14C File Offset: 0x0011934C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.HasCount != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.HasCount);
			}
			if (this.NextResetTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.NextResetTime);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600737F RID: 29567 RVA: 0x0011B1A4 File Offset: 0x001193A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EntityRewardItemPb other)
		{
			if (other == null)
			{
				return;
			}
			if (other.HasCount != 0)
			{
				this.HasCount = other.HasCount;
			}
			if (other.NextResetTime != 0L)
			{
				this.NextResetTime = other.NextResetTime;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06007380 RID: 29568 RVA: 0x0011B1F4 File Offset: 0x001193F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007381 RID: 29569 RVA: 0x0011B200 File Offset: 0x00119400
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
					if (num != 16U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.NextResetTime = input.ReadInt64();
					}
				}
				else
				{
					this.HasCount = input.ReadInt32();
				}
			}
		}

		// Token: 0x04003D24 RID: 15652
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003D25 RID: 15653
		public const int HasCountFieldNumber = 1;

		// Token: 0x04003D26 RID: 15654
		private int hasCount_;

		// Token: 0x04003D27 RID: 15655
		public const int NextResetTimeFieldNumber = 2;

		// Token: 0x04003D28 RID: 15656
		private long nextResetTime_;
	}
}
