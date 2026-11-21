using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200020E RID: 526
	[NetMessage(EMessageId.BuffStackCountPush)]
	public sealed class BuffStackCountPush : IMessage<BuffStackCountPush>, IMessage, IEquatable<BuffStackCountPush>, IDeepCloneable<BuffStackCountPush>, IBufferMessage
	{
		// Token: 0x06003A22 RID: 14882 RVA: 0x00091243 File Offset: 0x0008F443
		[NullableContext(1)]
		public static BuffStackCountPush Create()
		{
			return new BuffStackCountPush();
		}

		// Token: 0x17000986 RID: 2438
		// (get) Token: 0x06003A23 RID: 14883 RVA: 0x0009124A File Offset: 0x0008F44A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000987 RID: 2439
		// (get) Token: 0x06003A24 RID: 14884 RVA: 0x0009124D File Offset: 0x0008F44D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BuffStackCountPush.Descriptor;
			}
		}

		// Token: 0x06003A25 RID: 14885 RVA: 0x00091254 File Offset: 0x0008F454
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BuffStackCountPush()
		{
		}

		// Token: 0x06003A26 RID: 14886 RVA: 0x00091268 File Offset: 0x0008F468
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BuffStackCountPush(BuffStackCountPush other) : this()
		{
			this.handleId_ = other.handleId_;
			this.newStackCount_ = other.newStackCount_;
			this.isPrematureRemoval_ = other.isPrematureRemoval_;
			this.instigatorId_ = other.instigatorId_;
			this.notRefreshDuration_ = other.notRefreshDuration_;
			this.notRefreshPeriod_ = other.notRefreshPeriod_;
			this.duration_ = other.duration_;
			this.reason_ = other.reason_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003A27 RID: 14887 RVA: 0x000912EC File Offset: 0x0008F4EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BuffStackCountPush Clone()
		{
			return new BuffStackCountPush(this);
		}

		// Token: 0x17000988 RID: 2440
		// (get) Token: 0x06003A28 RID: 14888 RVA: 0x000912F4 File Offset: 0x0008F4F4
		// (set) Token: 0x06003A29 RID: 14889 RVA: 0x000912FC File Offset: 0x0008F4FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int HandleId
		{
			get
			{
				return this.handleId_;
			}
			set
			{
				this.handleId_ = value;
			}
		}

		// Token: 0x17000989 RID: 2441
		// (get) Token: 0x06003A2A RID: 14890 RVA: 0x00091305 File Offset: 0x0008F505
		// (set) Token: 0x06003A2B RID: 14891 RVA: 0x0009130D File Offset: 0x0008F50D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int NewStackCount
		{
			get
			{
				return this.newStackCount_;
			}
			set
			{
				this.newStackCount_ = value;
			}
		}

		// Token: 0x1700098A RID: 2442
		// (get) Token: 0x06003A2C RID: 14892 RVA: 0x00091316 File Offset: 0x0008F516
		// (set) Token: 0x06003A2D RID: 14893 RVA: 0x0009131E File Offset: 0x0008F51E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsPrematureRemoval
		{
			get
			{
				return this.isPrematureRemoval_;
			}
			set
			{
				this.isPrematureRemoval_ = value;
			}
		}

		// Token: 0x1700098B RID: 2443
		// (get) Token: 0x06003A2E RID: 14894 RVA: 0x00091327 File Offset: 0x0008F527
		// (set) Token: 0x06003A2F RID: 14895 RVA: 0x0009132F File Offset: 0x0008F52F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long InstigatorId
		{
			get
			{
				return this.instigatorId_;
			}
			set
			{
				this.instigatorId_ = value;
			}
		}

		// Token: 0x1700098C RID: 2444
		// (get) Token: 0x06003A30 RID: 14896 RVA: 0x00091338 File Offset: 0x0008F538
		// (set) Token: 0x06003A31 RID: 14897 RVA: 0x00091340 File Offset: 0x0008F540
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool NotRefreshDuration
		{
			get
			{
				return this.notRefreshDuration_;
			}
			set
			{
				this.notRefreshDuration_ = value;
			}
		}

		// Token: 0x1700098D RID: 2445
		// (get) Token: 0x06003A32 RID: 14898 RVA: 0x00091349 File Offset: 0x0008F549
		// (set) Token: 0x06003A33 RID: 14899 RVA: 0x00091351 File Offset: 0x0008F551
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool NotRefreshPeriod
		{
			get
			{
				return this.notRefreshPeriod_;
			}
			set
			{
				this.notRefreshPeriod_ = value;
			}
		}

		// Token: 0x1700098E RID: 2446
		// (get) Token: 0x06003A34 RID: 14900 RVA: 0x0009135A File Offset: 0x0008F55A
		// (set) Token: 0x06003A35 RID: 14901 RVA: 0x00091362 File Offset: 0x0008F562
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public float Duration
		{
			get
			{
				return this.duration_;
			}
			set
			{
				this.duration_ = value;
			}
		}

		// Token: 0x1700098F RID: 2447
		// (get) Token: 0x06003A36 RID: 14902 RVA: 0x0009136B File Offset: 0x0008F56B
		// (set) Token: 0x06003A37 RID: 14903 RVA: 0x00091373 File Offset: 0x0008F573
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string Reason
		{
			get
			{
				return this.reason_;
			}
			set
			{
				this.reason_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x06003A38 RID: 14904 RVA: 0x00091386 File Offset: 0x0008F586
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BuffStackCountPush);
		}

		// Token: 0x06003A39 RID: 14905 RVA: 0x00091394 File Offset: 0x0008F594
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BuffStackCountPush other)
		{
			return other != null && (other == this || (this.HandleId == other.HandleId && this.NewStackCount == other.NewStackCount && this.IsPrematureRemoval == other.IsPrematureRemoval && this.InstigatorId == other.InstigatorId && this.NotRefreshDuration == other.NotRefreshDuration && this.NotRefreshPeriod == other.NotRefreshPeriod && ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.Duration, other.Duration) && !(this.Reason != other.Reason) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003A3A RID: 14906 RVA: 0x0009144C File Offset: 0x0008F64C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.HandleId != 0)
			{
				num ^= this.HandleId.GetHashCode();
			}
			if (this.NewStackCount != 0)
			{
				num ^= this.NewStackCount.GetHashCode();
			}
			if (this.IsPrematureRemoval)
			{
				num ^= this.IsPrematureRemoval.GetHashCode();
			}
			if (this.InstigatorId != 0L)
			{
				num ^= this.InstigatorId.GetHashCode();
			}
			if (this.NotRefreshDuration)
			{
				num ^= this.NotRefreshDuration.GetHashCode();
			}
			if (this.NotRefreshPeriod)
			{
				num ^= this.NotRefreshPeriod.GetHashCode();
			}
			if (this.Duration != 0f)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.Duration);
			}
			if (this.Reason.Length != 0)
			{
				num ^= this.Reason.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06003A3B RID: 14907 RVA: 0x00091543 File Offset: 0x0008F743
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06003A3C RID: 14908 RVA: 0x00091550 File Offset: 0x0008F750
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003A3D RID: 14909 RVA: 0x0009155C File Offset: 0x0008F75C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.NotRefreshPeriod)
			{
				output.WriteRawTag(8);
				output.WriteBool(this.NotRefreshPeriod);
			}
			if (this.IsPrematureRemoval)
			{
				output.WriteRawTag(16);
				output.WriteBool(this.IsPrematureRemoval);
			}
			if (this.NotRefreshDuration)
			{
				output.WriteRawTag(24);
				output.WriteBool(this.NotRefreshDuration);
			}
			if (this.Duration != 0f)
			{
				output.WriteRawTag(45);
				output.WriteFloat(this.Duration);
			}
			if (this.Reason.Length != 0)
			{
				output.WriteRawTag(58);
				output.WriteString(this.Reason);
			}
			if (this.NewStackCount != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.NewStackCount);
			}
			if (this.HandleId != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.HandleId);
			}
			if (this.InstigatorId != 0L)
			{
				output.WriteRawTag(80);
				output.WriteInt64(this.InstigatorId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003A3E RID: 14910 RVA: 0x00091668 File Offset: 0x0008F868
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.HandleId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.HandleId);
			}
			if (this.NewStackCount != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.NewStackCount);
			}
			if (this.IsPrematureRemoval)
			{
				num += 2;
			}
			if (this.InstigatorId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.InstigatorId);
			}
			if (this.NotRefreshDuration)
			{
				num += 2;
			}
			if (this.NotRefreshPeriod)
			{
				num += 2;
			}
			if (this.Duration != 0f)
			{
				num += 5;
			}
			if (this.Reason.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Reason);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06003A3F RID: 14911 RVA: 0x00091728 File Offset: 0x0008F928
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BuffStackCountPush other)
		{
			if (other == null)
			{
				return;
			}
			if (other.HandleId != 0)
			{
				this.HandleId = other.HandleId;
			}
			if (other.NewStackCount != 0)
			{
				this.NewStackCount = other.NewStackCount;
			}
			if (other.IsPrematureRemoval)
			{
				this.IsPrematureRemoval = other.IsPrematureRemoval;
			}
			if (other.InstigatorId != 0L)
			{
				this.InstigatorId = other.InstigatorId;
			}
			if (other.NotRefreshDuration)
			{
				this.NotRefreshDuration = other.NotRefreshDuration;
			}
			if (other.NotRefreshPeriod)
			{
				this.NotRefreshPeriod = other.NotRefreshPeriod;
			}
			if (other.Duration != 0f)
			{
				this.Duration = other.Duration;
			}
			if (other.Reason.Length != 0)
			{
				this.Reason = other.Reason;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06003A40 RID: 14912 RVA: 0x000917FA File Offset: 0x0008F9FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003A41 RID: 14913 RVA: 0x00091804 File Offset: 0x0008FA04
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
				if (num <= 45U)
				{
					if (num <= 16U)
					{
						if (num == 8U)
						{
							this.NotRefreshPeriod = input.ReadBool();
							continue;
						}
						if (num == 16U)
						{
							this.IsPrematureRemoval = input.ReadBool();
							continue;
						}
					}
					else
					{
						if (num == 24U)
						{
							this.NotRefreshDuration = input.ReadBool();
							continue;
						}
						if (num == 45U)
						{
							this.Duration = input.ReadFloat();
							continue;
						}
					}
				}
				else if (num <= 64U)
				{
					if (num == 58U)
					{
						this.Reason = input.ReadString();
						continue;
					}
					if (num == 64U)
					{
						this.NewStackCount = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 72U)
					{
						this.HandleId = input.ReadInt32();
						continue;
					}
					if (num == 80U)
					{
						this.InstigatorId = input.ReadInt64();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04002C0A RID: 11274
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002C0B RID: 11275
		public const int HandleIdFieldNumber = 9;

		// Token: 0x04002C0C RID: 11276
		private int handleId_;

		// Token: 0x04002C0D RID: 11277
		public const int NewStackCountFieldNumber = 8;

		// Token: 0x04002C0E RID: 11278
		private int newStackCount_;

		// Token: 0x04002C0F RID: 11279
		public const int IsPrematureRemovalFieldNumber = 2;

		// Token: 0x04002C10 RID: 11280
		private bool isPrematureRemoval_;

		// Token: 0x04002C11 RID: 11281
		public const int InstigatorIdFieldNumber = 10;

		// Token: 0x04002C12 RID: 11282
		private long instigatorId_;

		// Token: 0x04002C13 RID: 11283
		public const int NotRefreshDurationFieldNumber = 3;

		// Token: 0x04002C14 RID: 11284
		private bool notRefreshDuration_;

		// Token: 0x04002C15 RID: 11285
		public const int NotRefreshPeriodFieldNumber = 1;

		// Token: 0x04002C16 RID: 11286
		private bool notRefreshPeriod_;

		// Token: 0x04002C17 RID: 11287
		public const int DurationFieldNumber = 5;

		// Token: 0x04002C18 RID: 11288
		private float duration_;

		// Token: 0x04002C19 RID: 11289
		public const int ReasonFieldNumber = 7;

		// Token: 0x04002C1A RID: 11290
		private string reason_ = "";
	}
}
