using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020013DB RID: 5083
	[NetMessage(EMessageId.ThrowDamageNotify)]
	public sealed class ThrowDamageNotify : IMessage<ThrowDamageNotify>, IMessage, IEquatable<ThrowDamageNotify>, IDeepCloneable<ThrowDamageNotify>, IBufferMessage
	{
		// Token: 0x0601B0A1 RID: 110753 RVA: 0x003EFADC File Offset: 0x003EDCDC
		[NullableContext(1)]
		public static ThrowDamageNotify Create()
		{
			return new ThrowDamageNotify();
		}

		// Token: 0x17005B8E RID: 23438
		// (get) Token: 0x0601B0A2 RID: 110754 RVA: 0x003EFAE3 File Offset: 0x003EDCE3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005B8F RID: 23439
		// (get) Token: 0x0601B0A3 RID: 110755 RVA: 0x003EFAE6 File Offset: 0x003EDCE6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ThrowDamageNotify.Descriptor;
			}
		}

		// Token: 0x0601B0A4 RID: 110756 RVA: 0x003EFAED File Offset: 0x003EDCED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ThrowDamageNotify()
		{
		}

		// Token: 0x0601B0A5 RID: 110757 RVA: 0x003EFAF5 File Offset: 0x003EDCF5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ThrowDamageNotify(ThrowDamageNotify other) : this()
		{
			this.entityId_ = other.entityId_;
			this.durability_ = other.durability_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601B0A6 RID: 110758 RVA: 0x003EFB26 File Offset: 0x003EDD26
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ThrowDamageNotify Clone()
		{
			return new ThrowDamageNotify(this);
		}

		// Token: 0x17005B90 RID: 23440
		// (get) Token: 0x0601B0A7 RID: 110759 RVA: 0x003EFB2E File Offset: 0x003EDD2E
		// (set) Token: 0x0601B0A8 RID: 110760 RVA: 0x003EFB36 File Offset: 0x003EDD36
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

		// Token: 0x17005B91 RID: 23441
		// (get) Token: 0x0601B0A9 RID: 110761 RVA: 0x003EFB3F File Offset: 0x003EDD3F
		// (set) Token: 0x0601B0AA RID: 110762 RVA: 0x003EFB47 File Offset: 0x003EDD47
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

		// Token: 0x0601B0AB RID: 110763 RVA: 0x003EFB50 File Offset: 0x003EDD50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ThrowDamageNotify);
		}

		// Token: 0x0601B0AC RID: 110764 RVA: 0x003EFB5E File Offset: 0x003EDD5E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ThrowDamageNotify other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && this.Durability == other.Durability && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601B0AD RID: 110765 RVA: 0x003EFB9C File Offset: 0x003EDD9C
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

		// Token: 0x0601B0AE RID: 110766 RVA: 0x003EFBF4 File Offset: 0x003EDDF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601B0AF RID: 110767 RVA: 0x003EFC01 File Offset: 0x003EDE01
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601B0B0 RID: 110768 RVA: 0x003EFC0C File Offset: 0x003EDE0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(8);
				output.WriteInt64(this.EntityId);
			}
			if (this.Durability != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Durability);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601B0B1 RID: 110769 RVA: 0x003EFC64 File Offset: 0x003EDE64
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

		// Token: 0x0601B0B2 RID: 110770 RVA: 0x003EFCBC File Offset: 0x003EDEBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ThrowDamageNotify other)
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

		// Token: 0x0601B0B3 RID: 110771 RVA: 0x003EFD0C File Offset: 0x003EDF0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601B0B4 RID: 110772 RVA: 0x003EFD18 File Offset: 0x003EDF18
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
						this.Durability = input.ReadInt32();
					}
				}
				else
				{
					this.EntityId = input.ReadInt64();
				}
			}
		}

		// Token: 0x04009DED RID: 40429
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009DEE RID: 40430
		public const int EntityIdFieldNumber = 1;

		// Token: 0x04009DEF RID: 40431
		private long entityId_;

		// Token: 0x04009DF0 RID: 40432
		public const int DurabilityFieldNumber = 2;

		// Token: 0x04009DF1 RID: 40433
		private int durability_;
	}
}
