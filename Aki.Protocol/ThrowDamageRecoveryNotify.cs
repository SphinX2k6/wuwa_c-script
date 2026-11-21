using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020013DC RID: 5084
	[NetMessage(EMessageId.ThrowDamageRecoveryNotify)]
	public sealed class ThrowDamageRecoveryNotify : IMessage<ThrowDamageRecoveryNotify>, IMessage, IEquatable<ThrowDamageRecoveryNotify>, IDeepCloneable<ThrowDamageRecoveryNotify>, IBufferMessage
	{
		// Token: 0x0601B0B5 RID: 110773 RVA: 0x003EFD6F File Offset: 0x003EDF6F
		[NullableContext(1)]
		public static ThrowDamageRecoveryNotify Create()
		{
			return new ThrowDamageRecoveryNotify();
		}

		// Token: 0x17005B92 RID: 23442
		// (get) Token: 0x0601B0B6 RID: 110774 RVA: 0x003EFD76 File Offset: 0x003EDF76
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005B93 RID: 23443
		// (get) Token: 0x0601B0B7 RID: 110775 RVA: 0x003EFD79 File Offset: 0x003EDF79
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ThrowDamageRecoveryNotify.Descriptor;
			}
		}

		// Token: 0x0601B0B8 RID: 110776 RVA: 0x003EFD80 File Offset: 0x003EDF80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ThrowDamageRecoveryNotify()
		{
		}

		// Token: 0x0601B0B9 RID: 110777 RVA: 0x003EFD88 File Offset: 0x003EDF88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ThrowDamageRecoveryNotify(ThrowDamageRecoveryNotify other) : this()
		{
			this.entityId_ = other.entityId_;
			this.durability_ = other.durability_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601B0BA RID: 110778 RVA: 0x003EFDB9 File Offset: 0x003EDFB9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ThrowDamageRecoveryNotify Clone()
		{
			return new ThrowDamageRecoveryNotify(this);
		}

		// Token: 0x17005B94 RID: 23444
		// (get) Token: 0x0601B0BB RID: 110779 RVA: 0x003EFDC1 File Offset: 0x003EDFC1
		// (set) Token: 0x0601B0BC RID: 110780 RVA: 0x003EFDC9 File Offset: 0x003EDFC9
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

		// Token: 0x17005B95 RID: 23445
		// (get) Token: 0x0601B0BD RID: 110781 RVA: 0x003EFDD2 File Offset: 0x003EDFD2
		// (set) Token: 0x0601B0BE RID: 110782 RVA: 0x003EFDDA File Offset: 0x003EDFDA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Durability
		{
			get
			{
				return this.durability_;
			}
			set
			{
				this.durability_ = value;
			}
		}

		// Token: 0x0601B0BF RID: 110783 RVA: 0x003EFDE3 File Offset: 0x003EDFE3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ThrowDamageRecoveryNotify);
		}

		// Token: 0x0601B0C0 RID: 110784 RVA: 0x003EFDF1 File Offset: 0x003EDFF1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ThrowDamageRecoveryNotify other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && this.Durability == other.Durability && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601B0C1 RID: 110785 RVA: 0x003EFE30 File Offset: 0x003EE030
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EntityId != 0L)
			{
				num ^= this.EntityId.GetHashCode();
			}
			if (this.Durability != 0)
			{
				num ^= this.Durability.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601B0C2 RID: 110786 RVA: 0x003EFE88 File Offset: 0x003EE088
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601B0C3 RID: 110787 RVA: 0x003EFE95 File Offset: 0x003EE095
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601B0C4 RID: 110788 RVA: 0x003EFEA0 File Offset: 0x003EE0A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Durability != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.Durability);
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

		// Token: 0x0601B0C5 RID: 110789 RVA: 0x003EFEFC File Offset: 0x003EE0FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EntityId);
			}
			if (this.Durability != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Durability);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601B0C6 RID: 110790 RVA: 0x003EFF54 File Offset: 0x003EE154
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ThrowDamageRecoveryNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EntityId != 0L)
			{
				this.EntityId = other.EntityId;
			}
			if (other.Durability != 0)
			{
				this.Durability = other.Durability;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601B0C7 RID: 110791 RVA: 0x003EFFA4 File Offset: 0x003EE1A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601B0C8 RID: 110792 RVA: 0x003EFFB0 File Offset: 0x003EE1B0
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
				if (num != 32U)
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
					this.Durability = input.ReadInt32();
				}
			}
		}

		// Token: 0x04009DF2 RID: 40434
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009DF3 RID: 40435
		public const int EntityIdFieldNumber = 9;

		// Token: 0x04009DF4 RID: 40436
		private long entityId_;

		// Token: 0x04009DF5 RID: 40437
		public const int DurabilityFieldNumber = 4;

		// Token: 0x04009DF6 RID: 40438
		private int durability_;
	}
}
