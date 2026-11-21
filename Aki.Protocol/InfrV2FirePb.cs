using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020007E2 RID: 2018
	public sealed class InfrV2FirePb : IMessage<InfrV2FirePb>, IMessage, IEquatable<InfrV2FirePb>, IDeepCloneable<InfrV2FirePb>, IBufferMessage
	{
		// Token: 0x0600B550 RID: 46416 RVA: 0x001B132C File Offset: 0x001AF52C
		[NullableContext(1)]
		public static InfrV2FirePb Create()
		{
			return new InfrV2FirePb();
		}

		// Token: 0x17002489 RID: 9353
		// (get) Token: 0x0600B551 RID: 46417 RVA: 0x001B1333 File Offset: 0x001AF533
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700248A RID: 9354
		// (get) Token: 0x0600B552 RID: 46418 RVA: 0x001B1336 File Offset: 0x001AF536
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return InfrV2FirePb.Descriptor;
			}
		}

		// Token: 0x0600B553 RID: 46419 RVA: 0x001B133D File Offset: 0x001AF53D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrV2FirePb()
		{
		}

		// Token: 0x0600B554 RID: 46420 RVA: 0x001B1348 File Offset: 0x001AF548
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrV2FirePb(InfrV2FirePb other) : this()
		{
			this.fireExp_ = other.fireExp_;
			this.fireLevel_ = other.fireLevel_;
			this.fireLevelReachTime_ = other.fireLevelReachTime_;
			this.fireStatus_ = other.fireStatus_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B555 RID: 46421 RVA: 0x001B139C File Offset: 0x001AF59C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrV2FirePb Clone()
		{
			return new InfrV2FirePb(this);
		}

		// Token: 0x1700248B RID: 9355
		// (get) Token: 0x0600B556 RID: 46422 RVA: 0x001B13A4 File Offset: 0x001AF5A4
		// (set) Token: 0x0600B557 RID: 46423 RVA: 0x001B13AC File Offset: 0x001AF5AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long FireExp
		{
			get
			{
				return this.fireExp_;
			}
			set
			{
				this.fireExp_ = value;
			}
		}

		// Token: 0x1700248C RID: 9356
		// (get) Token: 0x0600B558 RID: 46424 RVA: 0x001B13B5 File Offset: 0x001AF5B5
		// (set) Token: 0x0600B559 RID: 46425 RVA: 0x001B13BD File Offset: 0x001AF5BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int FireLevel
		{
			get
			{
				return this.fireLevel_;
			}
			set
			{
				this.fireLevel_ = value;
			}
		}

		// Token: 0x1700248D RID: 9357
		// (get) Token: 0x0600B55A RID: 46426 RVA: 0x001B13C6 File Offset: 0x001AF5C6
		// (set) Token: 0x0600B55B RID: 46427 RVA: 0x001B13CE File Offset: 0x001AF5CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long FireLevelReachTime
		{
			get
			{
				return this.fireLevelReachTime_;
			}
			set
			{
				this.fireLevelReachTime_ = value;
			}
		}

		// Token: 0x1700248E RID: 9358
		// (get) Token: 0x0600B55C RID: 46428 RVA: 0x001B13D7 File Offset: 0x001AF5D7
		// (set) Token: 0x0600B55D RID: 46429 RVA: 0x001B13DF File Offset: 0x001AF5DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrV2StatusPb FireStatus
		{
			get
			{
				return this.fireStatus_;
			}
			set
			{
				this.fireStatus_ = value;
			}
		}

		// Token: 0x0600B55E RID: 46430 RVA: 0x001B13E8 File Offset: 0x001AF5E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as InfrV2FirePb);
		}

		// Token: 0x0600B55F RID: 46431 RVA: 0x001B13F8 File Offset: 0x001AF5F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(InfrV2FirePb other)
		{
			return other != null && (other == this || (this.FireExp == other.FireExp && this.FireLevel == other.FireLevel && this.FireLevelReachTime == other.FireLevelReachTime && this.FireStatus == other.FireStatus && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B560 RID: 46432 RVA: 0x001B1464 File Offset: 0x001AF664
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.FireExp != 0L)
			{
				num ^= this.FireExp.GetHashCode();
			}
			if (this.FireLevel != 0)
			{
				num ^= this.FireLevel.GetHashCode();
			}
			if (this.FireLevelReachTime != 0L)
			{
				num ^= this.FireLevelReachTime.GetHashCode();
			}
			if (this.FireStatus != InfrV2StatusPb.InfrV2StatusLock)
			{
				num ^= this.FireStatus.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600B561 RID: 46433 RVA: 0x001B14F4 File Offset: 0x001AF6F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600B562 RID: 46434 RVA: 0x001B1501 File Offset: 0x001AF701
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B563 RID: 46435 RVA: 0x001B150C File Offset: 0x001AF70C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.FireExp != 0L)
			{
				output.WriteRawTag(8);
				output.WriteInt64(this.FireExp);
			}
			if (this.FireLevel != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.FireLevel);
			}
			if (this.FireLevelReachTime != 0L)
			{
				output.WriteRawTag(24);
				output.WriteInt64(this.FireLevelReachTime);
			}
			if (this.FireStatus != InfrV2StatusPb.InfrV2StatusLock)
			{
				output.WriteRawTag(32);
				output.WriteEnum((int)this.FireStatus);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B564 RID: 46436 RVA: 0x001B159C File Offset: 0x001AF79C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.FireExp != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.FireExp);
			}
			if (this.FireLevel != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.FireLevel);
			}
			if (this.FireLevelReachTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.FireLevelReachTime);
			}
			if (this.FireStatus != InfrV2StatusPb.InfrV2StatusLock)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.FireStatus);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600B565 RID: 46437 RVA: 0x001B1624 File Offset: 0x001AF824
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(InfrV2FirePb other)
		{
			if (other == null)
			{
				return;
			}
			if (other.FireExp != 0L)
			{
				this.FireExp = other.FireExp;
			}
			if (other.FireLevel != 0)
			{
				this.FireLevel = other.FireLevel;
			}
			if (other.FireLevelReachTime != 0L)
			{
				this.FireLevelReachTime = other.FireLevelReachTime;
			}
			if (other.FireStatus != InfrV2StatusPb.InfrV2StatusLock)
			{
				this.FireStatus = other.FireStatus;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600B566 RID: 46438 RVA: 0x001B169C File Offset: 0x001AF89C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B567 RID: 46439 RVA: 0x001B16A8 File Offset: 0x001AF8A8
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
						this.FireExp = input.ReadInt64();
						continue;
					}
					if (num == 16U)
					{
						this.FireLevel = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 24U)
					{
						this.FireLevelReachTime = input.ReadInt64();
						continue;
					}
					if (num == 32U)
					{
						this.FireStatus = (InfrV2StatusPb)input.ReadEnum();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040050CE RID: 20686
		private UnknownFieldSet _unknownFields;

		// Token: 0x040050CF RID: 20687
		public const int FireExpFieldNumber = 1;

		// Token: 0x040050D0 RID: 20688
		private long fireExp_;

		// Token: 0x040050D1 RID: 20689
		public const int FireLevelFieldNumber = 2;

		// Token: 0x040050D2 RID: 20690
		private int fireLevel_;

		// Token: 0x040050D3 RID: 20691
		public const int FireLevelReachTimeFieldNumber = 3;

		// Token: 0x040050D4 RID: 20692
		private long fireLevelReachTime_;

		// Token: 0x040050D5 RID: 20693
		public const int FireStatusFieldNumber = 4;

		// Token: 0x040050D6 RID: 20694
		private InfrV2StatusPb fireStatus_;
	}
}
