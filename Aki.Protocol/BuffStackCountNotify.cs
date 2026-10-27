using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000208 RID: 520
	[NetMessage(EMessageId.BuffStackCountNotify)]
	public sealed class BuffStackCountNotify : IMessage<BuffStackCountNotify>, IMessage, IEquatable<BuffStackCountNotify>, IDeepCloneable<BuffStackCountNotify>, IBufferMessage
	{
		// Token: 0x0600395B RID: 14683 RVA: 0x0008EFDA File Offset: 0x0008D1DA
		[NullableContext(1)]
		public static BuffStackCountNotify Create()
		{
			return new BuffStackCountNotify();
		}

		// Token: 0x1700095C RID: 2396
		// (get) Token: 0x0600395C RID: 14684 RVA: 0x0008EFE1 File Offset: 0x0008D1E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700095D RID: 2397
		// (get) Token: 0x0600395D RID: 14685 RVA: 0x0008EFE4 File Offset: 0x0008D1E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BuffStackCountNotify.Descriptor;
			}
		}

		// Token: 0x0600395E RID: 14686 RVA: 0x0008EFEB File Offset: 0x0008D1EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BuffStackCountNotify()
		{
		}

		// Token: 0x0600395F RID: 14687 RVA: 0x0008EFF4 File Offset: 0x0008D1F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BuffStackCountNotify(BuffStackCountNotify other) : this()
		{
			this._hasBits0 = other._hasBits0;
			this.handleId_ = other.handleId_;
			this.newStackCount_ = other.newStackCount_;
			this.duration_ = other.duration_;
			this.leftDuration_ = other.leftDuration_;
			this.instigatorId_ = other.instigatorId_;
			this.notRefreshDuration_ = other.notRefreshDuration_;
			this.notRefreshPeriod_ = other.notRefreshPeriod_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003960 RID: 14688 RVA: 0x0008F078 File Offset: 0x0008D278
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BuffStackCountNotify Clone()
		{
			return new BuffStackCountNotify(this);
		}

		// Token: 0x1700095E RID: 2398
		// (get) Token: 0x06003961 RID: 14689 RVA: 0x0008F080 File Offset: 0x0008D280
		// (set) Token: 0x06003962 RID: 14690 RVA: 0x0008F088 File Offset: 0x0008D288
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

		// Token: 0x1700095F RID: 2399
		// (get) Token: 0x06003963 RID: 14691 RVA: 0x0008F091 File Offset: 0x0008D291
		// (set) Token: 0x06003964 RID: 14692 RVA: 0x0008F099 File Offset: 0x0008D299
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

		// Token: 0x17000960 RID: 2400
		// (get) Token: 0x06003965 RID: 14693 RVA: 0x0008F0A2 File Offset: 0x0008D2A2
		// (set) Token: 0x06003966 RID: 14694 RVA: 0x0008F0BA File Offset: 0x0008D2BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public float Duration
		{
			get
			{
				if ((this._hasBits0 & 1) != 0)
				{
					return this.duration_;
				}
				return BuffStackCountNotify.DurationDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.duration_ = value;
			}
		}

		// Token: 0x17000961 RID: 2401
		// (get) Token: 0x06003967 RID: 14695 RVA: 0x0008F0D1 File Offset: 0x0008D2D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasDuration
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06003968 RID: 14696 RVA: 0x0008F0DE File Offset: 0x0008D2DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearDuration()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17000962 RID: 2402
		// (get) Token: 0x06003969 RID: 14697 RVA: 0x0008F0EF File Offset: 0x0008D2EF
		// (set) Token: 0x0600396A RID: 14698 RVA: 0x0008F107 File Offset: 0x0008D307
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public float LeftDuration
		{
			get
			{
				if ((this._hasBits0 & 2) != 0)
				{
					return this.leftDuration_;
				}
				return BuffStackCountNotify.LeftDurationDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.leftDuration_ = value;
			}
		}

		// Token: 0x17000963 RID: 2403
		// (get) Token: 0x0600396B RID: 14699 RVA: 0x0008F11E File Offset: 0x0008D31E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasLeftDuration
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x0600396C RID: 14700 RVA: 0x0008F12B File Offset: 0x0008D32B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearLeftDuration()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x17000964 RID: 2404
		// (get) Token: 0x0600396D RID: 14701 RVA: 0x0008F13C File Offset: 0x0008D33C
		// (set) Token: 0x0600396E RID: 14702 RVA: 0x0008F144 File Offset: 0x0008D344
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

		// Token: 0x17000965 RID: 2405
		// (get) Token: 0x0600396F RID: 14703 RVA: 0x0008F14D File Offset: 0x0008D34D
		// (set) Token: 0x06003970 RID: 14704 RVA: 0x0008F155 File Offset: 0x0008D355
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

		// Token: 0x17000966 RID: 2406
		// (get) Token: 0x06003971 RID: 14705 RVA: 0x0008F15E File Offset: 0x0008D35E
		// (set) Token: 0x06003972 RID: 14706 RVA: 0x0008F166 File Offset: 0x0008D366
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

		// Token: 0x06003973 RID: 14707 RVA: 0x0008F16F File Offset: 0x0008D36F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BuffStackCountNotify);
		}

		// Token: 0x06003974 RID: 14708 RVA: 0x0008F180 File Offset: 0x0008D380
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BuffStackCountNotify other)
		{
			return other != null && (other == this || (this.HandleId == other.HandleId && this.NewStackCount == other.NewStackCount && ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.Duration, other.Duration) && ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.LeftDuration, other.LeftDuration) && this.InstigatorId == other.InstigatorId && this.NotRefreshDuration == other.NotRefreshDuration && this.NotRefreshPeriod == other.NotRefreshPeriod && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003975 RID: 14709 RVA: 0x0008F230 File Offset: 0x0008D430
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
			if (this.HasDuration)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.Duration);
			}
			if (this.HasLeftDuration)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.LeftDuration);
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
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06003976 RID: 14710 RVA: 0x0008F309 File Offset: 0x0008D509
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06003977 RID: 14711 RVA: 0x0008F316 File Offset: 0x0008D516
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003978 RID: 14712 RVA: 0x0008F320 File Offset: 0x0008D520
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.NotRefreshPeriod)
			{
				output.WriteRawTag(8);
				output.WriteBool(this.NotRefreshPeriod);
			}
			if (this.NewStackCount != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.NewStackCount);
			}
			if (this.NotRefreshDuration)
			{
				output.WriteRawTag(48);
				output.WriteBool(this.NotRefreshDuration);
			}
			if (this.HasDuration)
			{
				output.WriteRawTag(61);
				output.WriteFloat(this.Duration);
			}
			if (this.HandleId != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.HandleId);
			}
			if (this.HasLeftDuration)
			{
				output.WriteRawTag(93);
				output.WriteFloat(this.LeftDuration);
			}
			if (this.InstigatorId != 0L)
			{
				output.WriteRawTag(104);
				output.WriteInt64(this.InstigatorId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003979 RID: 14713 RVA: 0x0008F404 File Offset: 0x0008D604
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
			if (this.HasDuration)
			{
				num += 5;
			}
			if (this.HasLeftDuration)
			{
				num += 5;
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
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600397A RID: 14714 RVA: 0x0008F4A4 File Offset: 0x0008D6A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BuffStackCountNotify other)
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
			if (other.HasDuration)
			{
				this.Duration = other.Duration;
			}
			if (other.HasLeftDuration)
			{
				this.LeftDuration = other.LeftDuration;
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
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600397B RID: 14715 RVA: 0x0008F558 File Offset: 0x0008D758
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600397C RID: 14716 RVA: 0x0008F564 File Offset: 0x0008D764
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
				if (num <= 48U)
				{
					if (num == 8U)
					{
						this.NotRefreshPeriod = input.ReadBool();
						continue;
					}
					if (num == 32U)
					{
						this.NewStackCount = input.ReadInt32();
						continue;
					}
					if (num == 48U)
					{
						this.NotRefreshDuration = input.ReadBool();
						continue;
					}
				}
				else if (num <= 72U)
				{
					if (num == 61U)
					{
						this.Duration = input.ReadFloat();
						continue;
					}
					if (num == 72U)
					{
						this.HandleId = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 93U)
					{
						this.LeftDuration = input.ReadFloat();
						continue;
					}
					if (num == 104U)
					{
						this.InstigatorId = input.ReadInt64();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04002B76 RID: 11126
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002B77 RID: 11127
		private int _hasBits0;

		// Token: 0x04002B78 RID: 11128
		public const int HandleIdFieldNumber = 9;

		// Token: 0x04002B79 RID: 11129
		private int handleId_;

		// Token: 0x04002B7A RID: 11130
		public const int NewStackCountFieldNumber = 4;

		// Token: 0x04002B7B RID: 11131
		private int newStackCount_;

		// Token: 0x04002B7C RID: 11132
		public const int DurationFieldNumber = 7;

		// Token: 0x04002B7D RID: 11133
		private static readonly float DurationDefaultValue;

		// Token: 0x04002B7E RID: 11134
		private float duration_;

		// Token: 0x04002B7F RID: 11135
		public const int LeftDurationFieldNumber = 11;

		// Token: 0x04002B80 RID: 11136
		private static readonly float LeftDurationDefaultValue;

		// Token: 0x04002B81 RID: 11137
		private float leftDuration_;

		// Token: 0x04002B82 RID: 11138
		public const int InstigatorIdFieldNumber = 13;

		// Token: 0x04002B83 RID: 11139
		private long instigatorId_;

		// Token: 0x04002B84 RID: 11140
		public const int NotRefreshDurationFieldNumber = 6;

		// Token: 0x04002B85 RID: 11141
		private bool notRefreshDuration_;

		// Token: 0x04002B86 RID: 11142
		public const int NotRefreshPeriodFieldNumber = 1;

		// Token: 0x04002B87 RID: 11143
		private bool notRefreshPeriod_;
	}
}
