using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020004C9 RID: 1225
	[NetMessage(EMessageId.EntityTimeFlowPush)]
	public sealed class EntityTimeFlowPush : IMessage<EntityTimeFlowPush>, IMessage, IEquatable<EntityTimeFlowPush>, IDeepCloneable<EntityTimeFlowPush>, IBufferMessage
	{
		// Token: 0x06007478 RID: 29816 RVA: 0x0011D5F5 File Offset: 0x0011B7F5
		[NullableContext(1)]
		public static EntityTimeFlowPush Create()
		{
			return new EntityTimeFlowPush();
		}

		// Token: 0x17001691 RID: 5777
		// (get) Token: 0x06007479 RID: 29817 RVA: 0x0011D5FC File Offset: 0x0011B7FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001692 RID: 5778
		// (get) Token: 0x0600747A RID: 29818 RVA: 0x0011D5FF File Offset: 0x0011B7FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EntityTimeFlowPush.Descriptor;
			}
		}

		// Token: 0x0600747B RID: 29819 RVA: 0x0011D606 File Offset: 0x0011B806
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityTimeFlowPush()
		{
		}

		// Token: 0x0600747C RID: 29820 RVA: 0x0011D60E File Offset: 0x0011B80E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityTimeFlowPush(EntityTimeFlowPush other) : this()
		{
			this.entityId_ = other.entityId_;
			this.timeDilation_ = other.timeDilation_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600747D RID: 29821 RVA: 0x0011D63F File Offset: 0x0011B83F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityTimeFlowPush Clone()
		{
			return new EntityTimeFlowPush(this);
		}

		// Token: 0x17001693 RID: 5779
		// (get) Token: 0x0600747E RID: 29822 RVA: 0x0011D647 File Offset: 0x0011B847
		// (set) Token: 0x0600747F RID: 29823 RVA: 0x0011D64F File Offset: 0x0011B84F
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

		// Token: 0x17001694 RID: 5780
		// (get) Token: 0x06007480 RID: 29824 RVA: 0x0011D658 File Offset: 0x0011B858
		// (set) Token: 0x06007481 RID: 29825 RVA: 0x0011D660 File Offset: 0x0011B860
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

		// Token: 0x06007482 RID: 29826 RVA: 0x0011D669 File Offset: 0x0011B869
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EntityTimeFlowPush);
		}

		// Token: 0x06007483 RID: 29827 RVA: 0x0011D678 File Offset: 0x0011B878
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EntityTimeFlowPush other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.TimeDilation, other.TimeDilation) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007484 RID: 29828 RVA: 0x0011D6CC File Offset: 0x0011B8CC
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

		// Token: 0x06007485 RID: 29829 RVA: 0x0011D72B File Offset: 0x0011B92B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06007486 RID: 29830 RVA: 0x0011D738 File Offset: 0x0011B938
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007487 RID: 29831 RVA: 0x0011D744 File Offset: 0x0011B944
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(72);
				output.WriteInt64(this.EntityId);
			}
			if (this.TimeDilation != 0f)
			{
				output.WriteRawTag(125);
				output.WriteFloat(this.TimeDilation);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007488 RID: 29832 RVA: 0x0011D7A4 File Offset: 0x0011B9A4
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

		// Token: 0x06007489 RID: 29833 RVA: 0x0011D7F4 File Offset: 0x0011B9F4
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

		// Token: 0x0600748A RID: 29834 RVA: 0x0011D849 File Offset: 0x0011BA49
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600748B RID: 29835 RVA: 0x0011D854 File Offset: 0x0011BA54
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
				if (num != 72U)
				{
					if (num != 125U)
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

		// Token: 0x04003D6E RID: 15726
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003D6F RID: 15727
		public const int EntityIdFieldNumber = 9;

		// Token: 0x04003D70 RID: 15728
		private long entityId_;

		// Token: 0x04003D71 RID: 15729
		public const int TimeDilationFieldNumber = 15;

		// Token: 0x04003D72 RID: 15730
		private float timeDilation_;
	}
}
