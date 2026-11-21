using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B95 RID: 2965
	[NetMessage(EMessageId.OrderApplyBuffNotify)]
	public sealed class OrderApplyBuffNotify : IMessage<OrderApplyBuffNotify>, IMessage, IEquatable<OrderApplyBuffNotify>, IDeepCloneable<OrderApplyBuffNotify>, IBufferMessage
	{
		// Token: 0x06010198 RID: 65944 RVA: 0x0025A17C File Offset: 0x0025837C
		[NullableContext(1)]
		public static OrderApplyBuffNotify Create()
		{
			return new OrderApplyBuffNotify();
		}

		// Token: 0x170034C3 RID: 13507
		// (get) Token: 0x06010199 RID: 65945 RVA: 0x0025A183 File Offset: 0x00258383
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170034C4 RID: 13508
		// (get) Token: 0x0601019A RID: 65946 RVA: 0x0025A186 File Offset: 0x00258386
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return OrderApplyBuffNotify.Descriptor;
			}
		}

		// Token: 0x0601019B RID: 65947 RVA: 0x0025A18D File Offset: 0x0025838D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OrderApplyBuffNotify()
		{
		}

		// Token: 0x0601019C RID: 65948 RVA: 0x0025A198 File Offset: 0x00258398
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OrderApplyBuffNotify(OrderApplyBuffNotify other) : this()
		{
			this._hasBits0 = other._hasBits0;
			this.id_ = other.id_;
			this.level_ = other.level_;
			this.instigatorId_ = other.instigatorId_;
			this.applyType_ = other.applyType_;
			this.duration_ = other.duration_;
			this.serverId_ = other.serverId_;
			this.stackCount_ = other.stackCount_;
			this.isIterable_ = other.isIterable_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601019D RID: 65949 RVA: 0x0025A228 File Offset: 0x00258428
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OrderApplyBuffNotify Clone()
		{
			return new OrderApplyBuffNotify(this);
		}

		// Token: 0x170034C5 RID: 13509
		// (get) Token: 0x0601019E RID: 65950 RVA: 0x0025A230 File Offset: 0x00258430
		// (set) Token: 0x0601019F RID: 65951 RVA: 0x0025A238 File Offset: 0x00258438
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

		// Token: 0x170034C6 RID: 13510
		// (get) Token: 0x060101A0 RID: 65952 RVA: 0x0025A241 File Offset: 0x00258441
		// (set) Token: 0x060101A1 RID: 65953 RVA: 0x0025A249 File Offset: 0x00258449
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Level
		{
			get
			{
				return this.level_;
			}
			set
			{
				this.level_ = value;
			}
		}

		// Token: 0x170034C7 RID: 13511
		// (get) Token: 0x060101A2 RID: 65954 RVA: 0x0025A252 File Offset: 0x00258452
		// (set) Token: 0x060101A3 RID: 65955 RVA: 0x0025A25A File Offset: 0x0025845A
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

		// Token: 0x170034C8 RID: 13512
		// (get) Token: 0x060101A4 RID: 65956 RVA: 0x0025A263 File Offset: 0x00258463
		// (set) Token: 0x060101A5 RID: 65957 RVA: 0x0025A26B File Offset: 0x0025846B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ApplyGEType ApplyType
		{
			get
			{
				return this.applyType_;
			}
			set
			{
				this.applyType_ = value;
			}
		}

		// Token: 0x170034C9 RID: 13513
		// (get) Token: 0x060101A6 RID: 65958 RVA: 0x0025A274 File Offset: 0x00258474
		// (set) Token: 0x060101A7 RID: 65959 RVA: 0x0025A28C File Offset: 0x0025848C
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
				return OrderApplyBuffNotify.DurationDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.duration_ = value;
			}
		}

		// Token: 0x170034CA RID: 13514
		// (get) Token: 0x060101A8 RID: 65960 RVA: 0x0025A2A3 File Offset: 0x002584A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasDuration
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x060101A9 RID: 65961 RVA: 0x0025A2B0 File Offset: 0x002584B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearDuration()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x170034CB RID: 13515
		// (get) Token: 0x060101AA RID: 65962 RVA: 0x0025A2C1 File Offset: 0x002584C1
		// (set) Token: 0x060101AB RID: 65963 RVA: 0x0025A2C9 File Offset: 0x002584C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ServerId
		{
			get
			{
				return this.serverId_;
			}
			set
			{
				this.serverId_ = value;
			}
		}

		// Token: 0x170034CC RID: 13516
		// (get) Token: 0x060101AC RID: 65964 RVA: 0x0025A2D2 File Offset: 0x002584D2
		// (set) Token: 0x060101AD RID: 65965 RVA: 0x0025A2DA File Offset: 0x002584DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int StackCount
		{
			get
			{
				return this.stackCount_;
			}
			set
			{
				this.stackCount_ = value;
			}
		}

		// Token: 0x170034CD RID: 13517
		// (get) Token: 0x060101AE RID: 65966 RVA: 0x0025A2E3 File Offset: 0x002584E3
		// (set) Token: 0x060101AF RID: 65967 RVA: 0x0025A2EB File Offset: 0x002584EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsIterable
		{
			get
			{
				return this.isIterable_;
			}
			set
			{
				this.isIterable_ = value;
			}
		}

		// Token: 0x060101B0 RID: 65968 RVA: 0x0025A2F4 File Offset: 0x002584F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as OrderApplyBuffNotify);
		}

		// Token: 0x060101B1 RID: 65969 RVA: 0x0025A304 File Offset: 0x00258504
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(OrderApplyBuffNotify other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.Level == other.Level && this.InstigatorId == other.InstigatorId && this.ApplyType == other.ApplyType && ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.Duration, other.Duration) && this.ServerId == other.ServerId && this.StackCount == other.StackCount && this.IsIterable == other.IsIterable && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060101B2 RID: 65970 RVA: 0x0025A3B8 File Offset: 0x002585B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0L)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.Level != 0)
			{
				num ^= this.Level.GetHashCode();
			}
			if (this.InstigatorId != 0L)
			{
				num ^= this.InstigatorId.GetHashCode();
			}
			if (this.ApplyType != ApplyGEType.Common)
			{
				num ^= this.ApplyType.GetHashCode();
			}
			if (this.HasDuration)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.Duration);
			}
			if (this.ServerId != 0)
			{
				num ^= this.ServerId.GetHashCode();
			}
			if (this.StackCount != 0)
			{
				num ^= this.StackCount.GetHashCode();
			}
			if (this.IsIterable)
			{
				num ^= this.IsIterable.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060101B3 RID: 65971 RVA: 0x0025A4AF File Offset: 0x002586AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060101B4 RID: 65972 RVA: 0x0025A4BC File Offset: 0x002586BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060101B5 RID: 65973 RVA: 0x0025A4C8 File Offset: 0x002586C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0L)
			{
				output.WriteRawTag(24);
				output.WriteInt64(this.Id);
			}
			if (this.ApplyType != ApplyGEType.Common)
			{
				output.WriteRawTag(32);
				output.WriteEnum((int)this.ApplyType);
			}
			if (this.Level != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.Level);
			}
			if (this.IsIterable)
			{
				output.WriteRawTag(72);
				output.WriteBool(this.IsIterable);
			}
			if (this.ServerId != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.ServerId);
			}
			if (this.HasDuration)
			{
				output.WriteRawTag(101);
				output.WriteFloat(this.Duration);
			}
			if (this.StackCount != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.StackCount);
			}
			if (this.InstigatorId != 0L)
			{
				output.WriteRawTag(112);
				output.WriteInt64(this.InstigatorId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060101B6 RID: 65974 RVA: 0x0025A5CC File Offset: 0x002587CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.Id);
			}
			if (this.Level != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Level);
			}
			if (this.InstigatorId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.InstigatorId);
			}
			if (this.ApplyType != ApplyGEType.Common)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ApplyType);
			}
			if (this.HasDuration)
			{
				num += 5;
			}
			if (this.ServerId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ServerId);
			}
			if (this.StackCount != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.StackCount);
			}
			if (this.IsIterable)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060101B7 RID: 65975 RVA: 0x0025A69C File Offset: 0x0025889C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(OrderApplyBuffNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0L)
			{
				this.Id = other.Id;
			}
			if (other.Level != 0)
			{
				this.Level = other.Level;
			}
			if (other.InstigatorId != 0L)
			{
				this.InstigatorId = other.InstigatorId;
			}
			if (other.ApplyType != ApplyGEType.Common)
			{
				this.ApplyType = other.ApplyType;
			}
			if (other.HasDuration)
			{
				this.Duration = other.Duration;
			}
			if (other.ServerId != 0)
			{
				this.ServerId = other.ServerId;
			}
			if (other.StackCount != 0)
			{
				this.StackCount = other.StackCount;
			}
			if (other.IsIterable)
			{
				this.IsIterable = other.IsIterable;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060101B8 RID: 65976 RVA: 0x0025A764 File Offset: 0x00258964
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060101B9 RID: 65977 RVA: 0x0025A770 File Offset: 0x00258970
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
				if (num <= 72U)
				{
					if (num <= 32U)
					{
						if (num == 24U)
						{
							this.Id = input.ReadInt64();
							continue;
						}
						if (num == 32U)
						{
							this.ApplyType = (ApplyGEType)input.ReadEnum();
							continue;
						}
					}
					else
					{
						if (num == 48U)
						{
							this.Level = input.ReadInt32();
							continue;
						}
						if (num == 72U)
						{
							this.IsIterable = input.ReadBool();
							continue;
						}
					}
				}
				else if (num <= 101U)
				{
					if (num == 88U)
					{
						this.ServerId = input.ReadInt32();
						continue;
					}
					if (num == 101U)
					{
						this.Duration = input.ReadFloat();
						continue;
					}
				}
				else
				{
					if (num == 104U)
					{
						this.StackCount = input.ReadInt32();
						continue;
					}
					if (num == 112U)
					{
						this.InstigatorId = input.ReadInt64();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04006704 RID: 26372
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006705 RID: 26373
		private int _hasBits0;

		// Token: 0x04006706 RID: 26374
		public const int IdFieldNumber = 3;

		// Token: 0x04006707 RID: 26375
		private long id_;

		// Token: 0x04006708 RID: 26376
		public const int LevelFieldNumber = 6;

		// Token: 0x04006709 RID: 26377
		private int level_;

		// Token: 0x0400670A RID: 26378
		public const int InstigatorIdFieldNumber = 14;

		// Token: 0x0400670B RID: 26379
		private long instigatorId_;

		// Token: 0x0400670C RID: 26380
		public const int ApplyTypeFieldNumber = 4;

		// Token: 0x0400670D RID: 26381
		private ApplyGEType applyType_;

		// Token: 0x0400670E RID: 26382
		public const int DurationFieldNumber = 12;

		// Token: 0x0400670F RID: 26383
		private static readonly float DurationDefaultValue;

		// Token: 0x04006710 RID: 26384
		private float duration_;

		// Token: 0x04006711 RID: 26385
		public const int ServerIdFieldNumber = 11;

		// Token: 0x04006712 RID: 26386
		private int serverId_;

		// Token: 0x04006713 RID: 26387
		public const int StackCountFieldNumber = 13;

		// Token: 0x04006714 RID: 26388
		private int stackCount_;

		// Token: 0x04006715 RID: 26389
		public const int IsIterableFieldNumber = 9;

		// Token: 0x04006716 RID: 26390
		private bool isIterable_;
	}
}
