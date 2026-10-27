using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000BA5 RID: 2981
	[NetMessage(EMessageId.OrderApplyBuffNotify)]
	public sealed class OrderApplyBuffNotify : IMessage<OrderApplyBuffNotify>, IMessage, IEquatable<OrderApplyBuffNotify>, IDeepCloneable<OrderApplyBuffNotify>, IBufferMessage
	{
		// Token: 0x0601029C RID: 66204 RVA: 0x0025C03C File Offset: 0x0025A23C
		[NullableContext(1)]
		public static OrderApplyBuffNotify Create()
		{
			return new OrderApplyBuffNotify();
		}

		// Token: 0x170034FC RID: 13564
		// (get) Token: 0x0601029D RID: 66205 RVA: 0x0025C043 File Offset: 0x0025A243
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170034FD RID: 13565
		// (get) Token: 0x0601029E RID: 66206 RVA: 0x0025C046 File Offset: 0x0025A246
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return OrderApplyBuffNotify.Descriptor;
			}
		}

		// Token: 0x0601029F RID: 66207 RVA: 0x0025C04D File Offset: 0x0025A24D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OrderApplyBuffNotify()
		{
		}

		// Token: 0x060102A0 RID: 66208 RVA: 0x0025C058 File Offset: 0x0025A258
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

		// Token: 0x060102A1 RID: 66209 RVA: 0x0025C0E8 File Offset: 0x0025A2E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OrderApplyBuffNotify Clone()
		{
			return new OrderApplyBuffNotify(this);
		}

		// Token: 0x170034FE RID: 13566
		// (get) Token: 0x060102A2 RID: 66210 RVA: 0x0025C0F0 File Offset: 0x0025A2F0
		// (set) Token: 0x060102A3 RID: 66211 RVA: 0x0025C0F8 File Offset: 0x0025A2F8
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

		// Token: 0x170034FF RID: 13567
		// (get) Token: 0x060102A4 RID: 66212 RVA: 0x0025C101 File Offset: 0x0025A301
		// (set) Token: 0x060102A5 RID: 66213 RVA: 0x0025C109 File Offset: 0x0025A309
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

		// Token: 0x17003500 RID: 13568
		// (get) Token: 0x060102A6 RID: 66214 RVA: 0x0025C112 File Offset: 0x0025A312
		// (set) Token: 0x060102A7 RID: 66215 RVA: 0x0025C11A File Offset: 0x0025A31A
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

		// Token: 0x17003501 RID: 13569
		// (get) Token: 0x060102A8 RID: 66216 RVA: 0x0025C123 File Offset: 0x0025A323
		// (set) Token: 0x060102A9 RID: 66217 RVA: 0x0025C12B File Offset: 0x0025A32B
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

		// Token: 0x17003502 RID: 13570
		// (get) Token: 0x060102AA RID: 66218 RVA: 0x0025C134 File Offset: 0x0025A334
		// (set) Token: 0x060102AB RID: 66219 RVA: 0x0025C14C File Offset: 0x0025A34C
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

		// Token: 0x17003503 RID: 13571
		// (get) Token: 0x060102AC RID: 66220 RVA: 0x0025C163 File Offset: 0x0025A363
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasDuration
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x060102AD RID: 66221 RVA: 0x0025C170 File Offset: 0x0025A370
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearDuration()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17003504 RID: 13572
		// (get) Token: 0x060102AE RID: 66222 RVA: 0x0025C181 File Offset: 0x0025A381
		// (set) Token: 0x060102AF RID: 66223 RVA: 0x0025C189 File Offset: 0x0025A389
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

		// Token: 0x17003505 RID: 13573
		// (get) Token: 0x060102B0 RID: 66224 RVA: 0x0025C192 File Offset: 0x0025A392
		// (set) Token: 0x060102B1 RID: 66225 RVA: 0x0025C19A File Offset: 0x0025A39A
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

		// Token: 0x17003506 RID: 13574
		// (get) Token: 0x060102B2 RID: 66226 RVA: 0x0025C1A3 File Offset: 0x0025A3A3
		// (set) Token: 0x060102B3 RID: 66227 RVA: 0x0025C1AB File Offset: 0x0025A3AB
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

		// Token: 0x060102B4 RID: 66228 RVA: 0x0025C1B4 File Offset: 0x0025A3B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as OrderApplyBuffNotify);
		}

		// Token: 0x060102B5 RID: 66229 RVA: 0x0025C1C4 File Offset: 0x0025A3C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(OrderApplyBuffNotify other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.Level == other.Level && this.InstigatorId == other.InstigatorId && this.ApplyType == other.ApplyType && ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.Duration, other.Duration) && this.ServerId == other.ServerId && this.StackCount == other.StackCount && this.IsIterable == other.IsIterable && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060102B6 RID: 66230 RVA: 0x0025C278 File Offset: 0x0025A478
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

		// Token: 0x060102B7 RID: 66231 RVA: 0x0025C36F File Offset: 0x0025A56F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060102B8 RID: 66232 RVA: 0x0025C37C File Offset: 0x0025A57C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060102B9 RID: 66233 RVA: 0x0025C388 File Offset: 0x0025A588
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ApplyType != ApplyGEType.Common)
			{
				output.WriteRawTag(8);
				output.WriteEnum((int)this.ApplyType);
			}
			if (this.ServerId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.ServerId);
			}
			if (this.Level != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.Level);
			}
			if (this.IsIterable)
			{
				output.WriteRawTag(48);
				output.WriteBool(this.IsIterable);
			}
			if (this.Id != 0L)
			{
				output.WriteRawTag(72);
				output.WriteInt64(this.Id);
			}
			if (this.InstigatorId != 0L)
			{
				output.WriteRawTag(80);
				output.WriteInt64(this.InstigatorId);
			}
			if (this.StackCount != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.StackCount);
			}
			if (this.HasDuration)
			{
				output.WriteRawTag(125);
				output.WriteFloat(this.Duration);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060102BA RID: 66234 RVA: 0x0025C488 File Offset: 0x0025A688
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

		// Token: 0x060102BB RID: 66235 RVA: 0x0025C558 File Offset: 0x0025A758
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

		// Token: 0x060102BC RID: 66236 RVA: 0x0025C620 File Offset: 0x0025A820
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060102BD RID: 66237 RVA: 0x0025C62C File Offset: 0x0025A82C
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
					if (num <= 24U)
					{
						if (num == 8U)
						{
							this.ApplyType = (ApplyGEType)input.ReadEnum();
							continue;
						}
						if (num == 24U)
						{
							this.ServerId = input.ReadInt32();
							continue;
						}
					}
					else
					{
						if (num == 40U)
						{
							this.Level = input.ReadInt32();
							continue;
						}
						if (num == 48U)
						{
							this.IsIterable = input.ReadBool();
							continue;
						}
					}
				}
				else if (num <= 80U)
				{
					if (num == 72U)
					{
						this.Id = input.ReadInt64();
						continue;
					}
					if (num == 80U)
					{
						this.InstigatorId = input.ReadInt64();
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
					if (num == 125U)
					{
						this.Duration = input.ReadFloat();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040066F4 RID: 26356
		private UnknownFieldSet _unknownFields;

		// Token: 0x040066F5 RID: 26357
		private int _hasBits0;

		// Token: 0x040066F6 RID: 26358
		public const int IdFieldNumber = 9;

		// Token: 0x040066F7 RID: 26359
		private long id_;

		// Token: 0x040066F8 RID: 26360
		public const int LevelFieldNumber = 5;

		// Token: 0x040066F9 RID: 26361
		private int level_;

		// Token: 0x040066FA RID: 26362
		public const int InstigatorIdFieldNumber = 10;

		// Token: 0x040066FB RID: 26363
		private long instigatorId_;

		// Token: 0x040066FC RID: 26364
		public const int ApplyTypeFieldNumber = 1;

		// Token: 0x040066FD RID: 26365
		private ApplyGEType applyType_;

		// Token: 0x040066FE RID: 26366
		public const int DurationFieldNumber = 15;

		// Token: 0x040066FF RID: 26367
		private static readonly float DurationDefaultValue;

		// Token: 0x04006700 RID: 26368
		private float duration_;

		// Token: 0x04006701 RID: 26369
		public const int ServerIdFieldNumber = 3;

		// Token: 0x04006702 RID: 26370
		private int serverId_;

		// Token: 0x04006703 RID: 26371
		public const int StackCountFieldNumber = 13;

		// Token: 0x04006704 RID: 26372
		private int stackCount_;

		// Token: 0x04006705 RID: 26373
		public const int IsIterableFieldNumber = 6;

		// Token: 0x04006706 RID: 26374
		private bool isIterable_;
	}
}
