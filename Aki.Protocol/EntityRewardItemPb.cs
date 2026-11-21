using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020004A6 RID: 1190
	public sealed class EntityRewardItemPb : IMessage<EntityRewardItemPb>, IMessage, IEquatable<EntityRewardItemPb>, IDeepCloneable<EntityRewardItemPb>, IBufferMessage
	{
		// Token: 0x060071DE RID: 29150 RVA: 0x00117EA3 File Offset: 0x001160A3
		[NullableContext(1)]
		public static EntityRewardItemPb Create()
		{
			return new EntityRewardItemPb();
		}

		// Token: 0x170015FF RID: 5631
		// (get) Token: 0x060071DF RID: 29151 RVA: 0x00117EAA File Offset: 0x001160AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001600 RID: 5632
		// (get) Token: 0x060071E0 RID: 29152 RVA: 0x00117EAD File Offset: 0x001160AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EntityRewardItemPb.Descriptor;
			}
		}

		// Token: 0x060071E1 RID: 29153 RVA: 0x00117EB4 File Offset: 0x001160B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityRewardItemPb()
		{
		}

		// Token: 0x060071E2 RID: 29154 RVA: 0x00117EBC File Offset: 0x001160BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityRewardItemPb(EntityRewardItemPb other) : this()
		{
			this.hasCount_ = other.hasCount_;
			this.nextResetTime_ = other.nextResetTime_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060071E3 RID: 29155 RVA: 0x00117EED File Offset: 0x001160ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityRewardItemPb Clone()
		{
			return new EntityRewardItemPb(this);
		}

		// Token: 0x17001601 RID: 5633
		// (get) Token: 0x060071E4 RID: 29156 RVA: 0x00117EF5 File Offset: 0x001160F5
		// (set) Token: 0x060071E5 RID: 29157 RVA: 0x00117EFD File Offset: 0x001160FD
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

		// Token: 0x17001602 RID: 5634
		// (get) Token: 0x060071E6 RID: 29158 RVA: 0x00117F06 File Offset: 0x00116106
		// (set) Token: 0x060071E7 RID: 29159 RVA: 0x00117F0E File Offset: 0x0011610E
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

		// Token: 0x060071E8 RID: 29160 RVA: 0x00117F17 File Offset: 0x00116117
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EntityRewardItemPb);
		}

		// Token: 0x060071E9 RID: 29161 RVA: 0x00117F25 File Offset: 0x00116125
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EntityRewardItemPb other)
		{
			return other != null && (other == this || (this.HasCount == other.HasCount && this.NextResetTime == other.NextResetTime && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060071EA RID: 29162 RVA: 0x00117F64 File Offset: 0x00116164
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

		// Token: 0x060071EB RID: 29163 RVA: 0x00117FBC File Offset: 0x001161BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060071EC RID: 29164 RVA: 0x00117FC9 File Offset: 0x001161C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060071ED RID: 29165 RVA: 0x00117FD4 File Offset: 0x001161D4
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

		// Token: 0x060071EE RID: 29166 RVA: 0x0011802C File Offset: 0x0011622C
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

		// Token: 0x060071EF RID: 29167 RVA: 0x00118084 File Offset: 0x00116284
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

		// Token: 0x060071F0 RID: 29168 RVA: 0x001180D4 File Offset: 0x001162D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060071F1 RID: 29169 RVA: 0x001180E0 File Offset: 0x001162E0
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

		// Token: 0x04003D10 RID: 15632
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003D11 RID: 15633
		public const int HasCountFieldNumber = 1;

		// Token: 0x04003D12 RID: 15634
		private int hasCount_;

		// Token: 0x04003D13 RID: 15635
		public const int NextResetTimeFieldNumber = 2;

		// Token: 0x04003D14 RID: 15636
		private long nextResetTime_;
	}
}
