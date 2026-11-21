using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000196 RID: 406
	public sealed class BeforeHitInformation : IMessage<BeforeHitInformation>, IMessage, IEquatable<BeforeHitInformation>, IDeepCloneable<BeforeHitInformation>, IBufferMessage
	{
		// Token: 0x06003072 RID: 12402 RVA: 0x0007BEAD File Offset: 0x0007A0AD
		[NullableContext(1)]
		public static BeforeHitInformation Create()
		{
			return new BeforeHitInformation();
		}

		// Token: 0x17000775 RID: 1909
		// (get) Token: 0x06003073 RID: 12403 RVA: 0x0007BEB4 File Offset: 0x0007A0B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000776 RID: 1910
		// (get) Token: 0x06003074 RID: 12404 RVA: 0x0007BEB7 File Offset: 0x0007A0B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BeforeHitInformation.Descriptor;
			}
		}

		// Token: 0x06003075 RID: 12405 RVA: 0x0007BEBE File Offset: 0x0007A0BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BeforeHitInformation()
		{
		}

		// Token: 0x06003076 RID: 12406 RVA: 0x0007BEC8 File Offset: 0x0007A0C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BeforeHitInformation(BeforeHitInformation other) : this()
		{
			this.id_ = other.id_;
			this.fightState_ = other.fightState_;
			this.triggerCounterType_ = other.triggerCounterType_;
			this.counterAnIndex_ = other.counterAnIndex_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003077 RID: 12407 RVA: 0x0007BF1C File Offset: 0x0007A11C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BeforeHitInformation Clone()
		{
			return new BeforeHitInformation(this);
		}

		// Token: 0x17000777 RID: 1911
		// (get) Token: 0x06003078 RID: 12408 RVA: 0x0007BF24 File Offset: 0x0007A124
		// (set) Token: 0x06003079 RID: 12409 RVA: 0x0007BF2C File Offset: 0x0007A12C
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

		// Token: 0x17000778 RID: 1912
		// (get) Token: 0x0600307A RID: 12410 RVA: 0x0007BF35 File Offset: 0x0007A135
		// (set) Token: 0x0600307B RID: 12411 RVA: 0x0007BF3D File Offset: 0x0007A13D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int FightState
		{
			get
			{
				return this.fightState_;
			}
			set
			{
				this.fightState_ = value;
			}
		}

		// Token: 0x17000779 RID: 1913
		// (get) Token: 0x0600307C RID: 12412 RVA: 0x0007BF46 File Offset: 0x0007A146
		// (set) Token: 0x0600307D RID: 12413 RVA: 0x0007BF4E File Offset: 0x0007A14E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TriggerCounterType
		{
			get
			{
				return this.triggerCounterType_;
			}
			set
			{
				this.triggerCounterType_ = value;
			}
		}

		// Token: 0x1700077A RID: 1914
		// (get) Token: 0x0600307E RID: 12414 RVA: 0x0007BF57 File Offset: 0x0007A157
		// (set) Token: 0x0600307F RID: 12415 RVA: 0x0007BF5F File Offset: 0x0007A15F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CounterAnIndex
		{
			get
			{
				return this.counterAnIndex_;
			}
			set
			{
				this.counterAnIndex_ = value;
			}
		}

		// Token: 0x06003080 RID: 12416 RVA: 0x0007BF68 File Offset: 0x0007A168
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BeforeHitInformation);
		}

		// Token: 0x06003081 RID: 12417 RVA: 0x0007BF78 File Offset: 0x0007A178
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BeforeHitInformation other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.FightState == other.FightState && this.TriggerCounterType == other.TriggerCounterType && this.CounterAnIndex == other.CounterAnIndex && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003082 RID: 12418 RVA: 0x0007BFE4 File Offset: 0x0007A1E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0L)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.FightState != 0)
			{
				num ^= this.FightState.GetHashCode();
			}
			if (this.TriggerCounterType != 0)
			{
				num ^= this.TriggerCounterType.GetHashCode();
			}
			if (this.CounterAnIndex != 0)
			{
				num ^= this.CounterAnIndex.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06003083 RID: 12419 RVA: 0x0007C06E File Offset: 0x0007A26E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06003084 RID: 12420 RVA: 0x0007C07B File Offset: 0x0007A27B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003085 RID: 12421 RVA: 0x0007C084 File Offset: 0x0007A284
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0L)
			{
				output.WriteRawTag(8);
				output.WriteInt64(this.Id);
			}
			if (this.FightState != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.FightState);
			}
			if (this.TriggerCounterType != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.TriggerCounterType);
			}
			if (this.CounterAnIndex != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.CounterAnIndex);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003086 RID: 12422 RVA: 0x0007C114 File Offset: 0x0007A314
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.Id);
			}
			if (this.FightState != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.FightState);
			}
			if (this.TriggerCounterType != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TriggerCounterType);
			}
			if (this.CounterAnIndex != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CounterAnIndex);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06003087 RID: 12423 RVA: 0x0007C19C File Offset: 0x0007A39C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BeforeHitInformation other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0L)
			{
				this.Id = other.Id;
			}
			if (other.FightState != 0)
			{
				this.FightState = other.FightState;
			}
			if (other.TriggerCounterType != 0)
			{
				this.TriggerCounterType = other.TriggerCounterType;
			}
			if (other.CounterAnIndex != 0)
			{
				this.CounterAnIndex = other.CounterAnIndex;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06003088 RID: 12424 RVA: 0x0007C214 File Offset: 0x0007A414
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003089 RID: 12425 RVA: 0x0007C220 File Offset: 0x0007A420
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
				if (num <= 16U)
				{
					if (num == 8U)
					{
						this.Id = input.ReadInt64();
						continue;
					}
					if (num == 16U)
					{
						this.FightState = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 24U)
					{
						this.TriggerCounterType = input.ReadInt32();
						continue;
					}
					if (num == 32U)
					{
						this.CounterAnIndex = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04002947 RID: 10567
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002948 RID: 10568
		public const int IdFieldNumber = 1;

		// Token: 0x04002949 RID: 10569
		private long id_;

		// Token: 0x0400294A RID: 10570
		public const int FightStateFieldNumber = 2;

		// Token: 0x0400294B RID: 10571
		private int fightState_;

		// Token: 0x0400294C RID: 10572
		public const int TriggerCounterTypeFieldNumber = 3;

		// Token: 0x0400294D RID: 10573
		private int triggerCounterType_;

		// Token: 0x0400294E RID: 10574
		public const int CounterAnIndexFieldNumber = 4;

		// Token: 0x0400294F RID: 10575
		private int counterAnIndex_;
	}
}
