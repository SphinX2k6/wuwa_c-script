using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000193 RID: 403
	public sealed class BeforeHitInformation : IMessage<BeforeHitInformation>, IMessage, IEquatable<BeforeHitInformation>, IDeepCloneable<BeforeHitInformation>, IBufferMessage
	{
		// Token: 0x06002FFB RID: 12283 RVA: 0x0007AA75 File Offset: 0x00078C75
		[NullableContext(1)]
		public static BeforeHitInformation Create()
		{
			return new BeforeHitInformation();
		}

		// Token: 0x17000761 RID: 1889
		// (get) Token: 0x06002FFC RID: 12284 RVA: 0x0007AA7C File Offset: 0x00078C7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000762 RID: 1890
		// (get) Token: 0x06002FFD RID: 12285 RVA: 0x0007AA7F File Offset: 0x00078C7F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BeforeHitInformation.Descriptor;
			}
		}

		// Token: 0x06002FFE RID: 12286 RVA: 0x0007AA86 File Offset: 0x00078C86
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BeforeHitInformation()
		{
		}

		// Token: 0x06002FFF RID: 12287 RVA: 0x0007AA90 File Offset: 0x00078C90
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

		// Token: 0x06003000 RID: 12288 RVA: 0x0007AAE4 File Offset: 0x00078CE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BeforeHitInformation Clone()
		{
			return new BeforeHitInformation(this);
		}

		// Token: 0x17000763 RID: 1891
		// (get) Token: 0x06003001 RID: 12289 RVA: 0x0007AAEC File Offset: 0x00078CEC
		// (set) Token: 0x06003002 RID: 12290 RVA: 0x0007AAF4 File Offset: 0x00078CF4
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

		// Token: 0x17000764 RID: 1892
		// (get) Token: 0x06003003 RID: 12291 RVA: 0x0007AAFD File Offset: 0x00078CFD
		// (set) Token: 0x06003004 RID: 12292 RVA: 0x0007AB05 File Offset: 0x00078D05
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

		// Token: 0x17000765 RID: 1893
		// (get) Token: 0x06003005 RID: 12293 RVA: 0x0007AB0E File Offset: 0x00078D0E
		// (set) Token: 0x06003006 RID: 12294 RVA: 0x0007AB16 File Offset: 0x00078D16
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

		// Token: 0x17000766 RID: 1894
		// (get) Token: 0x06003007 RID: 12295 RVA: 0x0007AB1F File Offset: 0x00078D1F
		// (set) Token: 0x06003008 RID: 12296 RVA: 0x0007AB27 File Offset: 0x00078D27
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

		// Token: 0x06003009 RID: 12297 RVA: 0x0007AB30 File Offset: 0x00078D30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BeforeHitInformation);
		}

		// Token: 0x0600300A RID: 12298 RVA: 0x0007AB40 File Offset: 0x00078D40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BeforeHitInformation other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.FightState == other.FightState && this.TriggerCounterType == other.TriggerCounterType && this.CounterAnIndex == other.CounterAnIndex && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600300B RID: 12299 RVA: 0x0007ABAC File Offset: 0x00078DAC
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

		// Token: 0x0600300C RID: 12300 RVA: 0x0007AC36 File Offset: 0x00078E36
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600300D RID: 12301 RVA: 0x0007AC43 File Offset: 0x00078E43
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600300E RID: 12302 RVA: 0x0007AC4C File Offset: 0x00078E4C
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

		// Token: 0x0600300F RID: 12303 RVA: 0x0007ACDC File Offset: 0x00078EDC
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

		// Token: 0x06003010 RID: 12304 RVA: 0x0007AD64 File Offset: 0x00078F64
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

		// Token: 0x06003011 RID: 12305 RVA: 0x0007ADDC File Offset: 0x00078FDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003012 RID: 12306 RVA: 0x0007ADE8 File Offset: 0x00078FE8
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

		// Token: 0x040028D3 RID: 10451
		private UnknownFieldSet _unknownFields;

		// Token: 0x040028D4 RID: 10452
		public const int IdFieldNumber = 1;

		// Token: 0x040028D5 RID: 10453
		private long id_;

		// Token: 0x040028D6 RID: 10454
		public const int FightStateFieldNumber = 2;

		// Token: 0x040028D7 RID: 10455
		private int fightState_;

		// Token: 0x040028D8 RID: 10456
		public const int TriggerCounterTypeFieldNumber = 3;

		// Token: 0x040028D9 RID: 10457
		private int triggerCounterType_;

		// Token: 0x040028DA RID: 10458
		public const int CounterAnIndexFieldNumber = 4;

		// Token: 0x040028DB RID: 10459
		private int counterAnIndex_;
	}
}
