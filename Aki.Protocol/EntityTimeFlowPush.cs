using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020004B2 RID: 1202
	[NetMessage(EMessageId.EntityTimeFlowPush)]
	public sealed class EntityTimeFlowPush : IMessage<EntityTimeFlowPush>, IMessage, IEquatable<EntityTimeFlowPush>, IDeepCloneable<EntityTimeFlowPush>, IBufferMessage
	{
		// Token: 0x060072E8 RID: 29416 RVA: 0x0011A4DD File Offset: 0x001186DD
		[NullableContext(1)]
		public static EntityTimeFlowPush Create()
		{
			return new EntityTimeFlowPush();
		}

		// Token: 0x1700163C RID: 5692
		// (get) Token: 0x060072E9 RID: 29417 RVA: 0x0011A4E4 File Offset: 0x001186E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700163D RID: 5693
		// (get) Token: 0x060072EA RID: 29418 RVA: 0x0011A4E7 File Offset: 0x001186E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EntityTimeFlowPush.Descriptor;
			}
		}

		// Token: 0x060072EB RID: 29419 RVA: 0x0011A4EE File Offset: 0x001186EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityTimeFlowPush()
		{
		}

		// Token: 0x060072EC RID: 29420 RVA: 0x0011A4F6 File Offset: 0x001186F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityTimeFlowPush(EntityTimeFlowPush other) : this()
		{
			this.entityId_ = other.entityId_;
			this.timeDilation_ = other.timeDilation_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060072ED RID: 29421 RVA: 0x0011A527 File Offset: 0x00118727
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityTimeFlowPush Clone()
		{
			return new EntityTimeFlowPush(this);
		}

		// Token: 0x1700163E RID: 5694
		// (get) Token: 0x060072EE RID: 29422 RVA: 0x0011A52F File Offset: 0x0011872F
		// (set) Token: 0x060072EF RID: 29423 RVA: 0x0011A537 File Offset: 0x00118737
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

		// Token: 0x1700163F RID: 5695
		// (get) Token: 0x060072F0 RID: 29424 RVA: 0x0011A540 File Offset: 0x00118740
		// (set) Token: 0x060072F1 RID: 29425 RVA: 0x0011A548 File Offset: 0x00118748
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public float TimeDilation
		{
			get
			{
				return this.timeDilation_;
			}
			set
			{
				this.timeDilation_ = value;
			}
		}

		// Token: 0x060072F2 RID: 29426 RVA: 0x0011A551 File Offset: 0x00118751
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EntityTimeFlowPush);
		}

		// Token: 0x060072F3 RID: 29427 RVA: 0x0011A560 File Offset: 0x00118760
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EntityTimeFlowPush other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.TimeDilation, other.TimeDilation) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060072F4 RID: 29428 RVA: 0x0011A5B4 File Offset: 0x001187B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EntityId != 0L)
			{
				num ^= this.EntityId.GetHashCode();
			}
			if (this.TimeDilation != 0f)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.TimeDilation);
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060072F5 RID: 29429 RVA: 0x0011A613 File Offset: 0x00118813
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060072F6 RID: 29430 RVA: 0x0011A620 File Offset: 0x00118820
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060072F7 RID: 29431 RVA: 0x0011A62C File Offset: 0x0011882C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(24);
				output.WriteInt64(this.EntityId);
			}
			if (this.TimeDilation != 0f)
			{
				output.WriteRawTag(61);
				output.WriteFloat(this.TimeDilation);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060072F8 RID: 29432 RVA: 0x0011A68C File Offset: 0x0011888C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EntityId);
			}
			if (this.TimeDilation != 0f)
			{
				num += 5;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060072F9 RID: 29433 RVA: 0x0011A6DC File Offset: 0x001188DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EntityTimeFlowPush other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EntityId != 0L)
			{
				this.EntityId = other.EntityId;
			}
			if (other.TimeDilation != 0f)
			{
				this.TimeDilation = other.TimeDilation;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060072FA RID: 29434 RVA: 0x0011A731 File Offset: 0x00118931
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060072FB RID: 29435 RVA: 0x0011A73C File Offset: 0x0011893C
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
				if (num != 24U)
				{
					if (num != 61U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.TimeDilation = input.ReadFloat();
					}
				}
				else
				{
					this.EntityId = input.ReadInt64();
				}
			}
		}

		// Token: 0x04003D5A RID: 15706
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003D5B RID: 15707
		public const int EntityIdFieldNumber = 3;

		// Token: 0x04003D5C RID: 15708
		private long entityId_;

		// Token: 0x04003D5D RID: 15709
		public const int TimeDilationFieldNumber = 7;

		// Token: 0x04003D5E RID: 15710
		private float timeDilation_;
	}
}
