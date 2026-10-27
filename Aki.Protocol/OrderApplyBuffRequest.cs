using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Aki.Protocol.BattleDefine;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000BA6 RID: 2982
	[NetMessage(EMessageId.OrderApplyBuffRequest)]
	public sealed class OrderApplyBuffRequest : IMessage<OrderApplyBuffRequest>, IMessage, IEquatable<OrderApplyBuffRequest>, IDeepCloneable<OrderApplyBuffRequest>, IBufferMessage
	{
		// Token: 0x060102BE RID: 66238 RVA: 0x0025C710 File Offset: 0x0025A910
		[NullableContext(1)]
		public static OrderApplyBuffRequest Create()
		{
			return new OrderApplyBuffRequest();
		}

		// Token: 0x17003507 RID: 13575
		// (get) Token: 0x060102BF RID: 66239 RVA: 0x0025C717 File Offset: 0x0025A917
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003508 RID: 13576
		// (get) Token: 0x060102C0 RID: 66240 RVA: 0x0025C71A File Offset: 0x0025A91A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return OrderApplyBuffRequest.Descriptor;
			}
		}

		// Token: 0x060102C1 RID: 66241 RVA: 0x0025C721 File Offset: 0x0025A921
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OrderApplyBuffRequest()
		{
		}

		// Token: 0x060102C2 RID: 66242 RVA: 0x0025C734 File Offset: 0x0025A934
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OrderApplyBuffRequest(OrderApplyBuffRequest other) : this()
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
			this.transferContextId_ = ((other.transferContextId_ != null) ? other.transferContextId_.Clone() : null);
			this.reason_ = other.reason_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060102C3 RID: 66243 RVA: 0x0025C7EC File Offset: 0x0025A9EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OrderApplyBuffRequest Clone()
		{
			return new OrderApplyBuffRequest(this);
		}

		// Token: 0x17003509 RID: 13577
		// (get) Token: 0x060102C4 RID: 66244 RVA: 0x0025C7F4 File Offset: 0x0025A9F4
		// (set) Token: 0x060102C5 RID: 66245 RVA: 0x0025C7FC File Offset: 0x0025A9FC
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

		// Token: 0x1700350A RID: 13578
		// (get) Token: 0x060102C6 RID: 66246 RVA: 0x0025C805 File Offset: 0x0025AA05
		// (set) Token: 0x060102C7 RID: 66247 RVA: 0x0025C80D File Offset: 0x0025AA0D
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

		// Token: 0x1700350B RID: 13579
		// (get) Token: 0x060102C8 RID: 66248 RVA: 0x0025C816 File Offset: 0x0025AA16
		// (set) Token: 0x060102C9 RID: 66249 RVA: 0x0025C81E File Offset: 0x0025AA1E
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

		// Token: 0x1700350C RID: 13580
		// (get) Token: 0x060102CA RID: 66250 RVA: 0x0025C827 File Offset: 0x0025AA27
		// (set) Token: 0x060102CB RID: 66251 RVA: 0x0025C82F File Offset: 0x0025AA2F
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

		// Token: 0x1700350D RID: 13581
		// (get) Token: 0x060102CC RID: 66252 RVA: 0x0025C838 File Offset: 0x0025AA38
		// (set) Token: 0x060102CD RID: 66253 RVA: 0x0025C850 File Offset: 0x0025AA50
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
				return OrderApplyBuffRequest.DurationDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.duration_ = value;
			}
		}

		// Token: 0x1700350E RID: 13582
		// (get) Token: 0x060102CE RID: 66254 RVA: 0x0025C867 File Offset: 0x0025AA67
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasDuration
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x060102CF RID: 66255 RVA: 0x0025C874 File Offset: 0x0025AA74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearDuration()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x1700350F RID: 13583
		// (get) Token: 0x060102D0 RID: 66256 RVA: 0x0025C885 File Offset: 0x0025AA85
		// (set) Token: 0x060102D1 RID: 66257 RVA: 0x0025C88D File Offset: 0x0025AA8D
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

		// Token: 0x17003510 RID: 13584
		// (get) Token: 0x060102D2 RID: 66258 RVA: 0x0025C896 File Offset: 0x0025AA96
		// (set) Token: 0x060102D3 RID: 66259 RVA: 0x0025C89E File Offset: 0x0025AA9E
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

		// Token: 0x17003511 RID: 13585
		// (get) Token: 0x060102D4 RID: 66260 RVA: 0x0025C8A7 File Offset: 0x0025AAA7
		// (set) Token: 0x060102D5 RID: 66261 RVA: 0x0025C8AF File Offset: 0x0025AAAF
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

		// Token: 0x17003512 RID: 13586
		// (get) Token: 0x060102D6 RID: 66262 RVA: 0x0025C8B8 File Offset: 0x0025AAB8
		// (set) Token: 0x060102D7 RID: 66263 RVA: 0x0025C8C0 File Offset: 0x0025AAC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TransferContextId TransferContextId
		{
			get
			{
				return this.transferContextId_;
			}
			set
			{
				this.transferContextId_ = value;
			}
		}

		// Token: 0x17003513 RID: 13587
		// (get) Token: 0x060102D8 RID: 66264 RVA: 0x0025C8C9 File Offset: 0x0025AAC9
		// (set) Token: 0x060102D9 RID: 66265 RVA: 0x0025C8D1 File Offset: 0x0025AAD1
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

		// Token: 0x060102DA RID: 66266 RVA: 0x0025C8E4 File Offset: 0x0025AAE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as OrderApplyBuffRequest);
		}

		// Token: 0x060102DB RID: 66267 RVA: 0x0025C8F4 File Offset: 0x0025AAF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(OrderApplyBuffRequest other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.Level == other.Level && this.InstigatorId == other.InstigatorId && this.ApplyType == other.ApplyType && ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.Duration, other.Duration) && this.ServerId == other.ServerId && this.StackCount == other.StackCount && this.IsIterable == other.IsIterable && object.Equals(this.TransferContextId, other.TransferContextId) && !(this.Reason != other.Reason) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060102DC RID: 66268 RVA: 0x0025C9D4 File Offset: 0x0025ABD4
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
			if (this.transferContextId_ != null)
			{
				num ^= this.TransferContextId.GetHashCode();
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

		// Token: 0x060102DD RID: 66269 RVA: 0x0025CAFC File Offset: 0x0025ACFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060102DE RID: 66270 RVA: 0x0025CB09 File Offset: 0x0025AD09
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060102DF RID: 66271 RVA: 0x0025CB14 File Offset: 0x0025AD14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Level != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Level);
			}
			if (this.IsIterable)
			{
				output.WriteRawTag(16);
				output.WriteBool(this.IsIterable);
			}
			if (this.ApplyType != ApplyGEType.Common)
			{
				output.WriteRawTag(40);
				output.WriteEnum((int)this.ApplyType);
			}
			if (this.Reason.Length != 0)
			{
				output.WriteRawTag(50);
				output.WriteString(this.Reason);
			}
			if (this.ServerId != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.ServerId);
			}
			if (this.transferContextId_ != null)
			{
				output.WriteRawTag(66);
				output.WriteMessage(this.TransferContextId);
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
				output.WriteRawTag(96);
				output.WriteInt32(this.StackCount);
			}
			if (this.HasDuration)
			{
				output.WriteRawTag(109);
				output.WriteFloat(this.Duration);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060102E0 RID: 66272 RVA: 0x0025CC54 File Offset: 0x0025AE54
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
			if (this.transferContextId_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.TransferContextId);
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

		// Token: 0x060102E1 RID: 66273 RVA: 0x0025CD58 File Offset: 0x0025AF58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(OrderApplyBuffRequest other)
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
			if (other.transferContextId_ != null)
			{
				if (this.transferContextId_ == null)
				{
					this.TransferContextId = new TransferContextId();
				}
				this.TransferContextId.MergeFrom(other.TransferContextId);
			}
			if (other.Reason.Length != 0)
			{
				this.Reason = other.Reason;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060102E2 RID: 66274 RVA: 0x0025CE65 File Offset: 0x0025B065
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060102E3 RID: 66275 RVA: 0x0025CE70 File Offset: 0x0025B070
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
				if (num <= 56U)
				{
					if (num <= 16U)
					{
						if (num == 8U)
						{
							this.Level = input.ReadInt32();
							continue;
						}
						if (num == 16U)
						{
							this.IsIterable = input.ReadBool();
							continue;
						}
					}
					else
					{
						if (num == 40U)
						{
							this.ApplyType = (ApplyGEType)input.ReadEnum();
							continue;
						}
						if (num == 50U)
						{
							this.Reason = input.ReadString();
							continue;
						}
						if (num == 56U)
						{
							this.ServerId = input.ReadInt32();
							continue;
						}
					}
				}
				else if (num <= 72U)
				{
					if (num == 66U)
					{
						if (this.transferContextId_ == null)
						{
							this.TransferContextId = new TransferContextId();
						}
						input.ReadMessage(this.TransferContextId);
						continue;
					}
					if (num == 72U)
					{
						this.Id = input.ReadInt64();
						continue;
					}
				}
				else
				{
					if (num == 80U)
					{
						this.InstigatorId = input.ReadInt64();
						continue;
					}
					if (num == 96U)
					{
						this.StackCount = input.ReadInt32();
						continue;
					}
					if (num == 109U)
					{
						this.Duration = input.ReadFloat();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04006707 RID: 26375
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006708 RID: 26376
		private int _hasBits0;

		// Token: 0x04006709 RID: 26377
		public const int IdFieldNumber = 9;

		// Token: 0x0400670A RID: 26378
		private long id_;

		// Token: 0x0400670B RID: 26379
		public const int LevelFieldNumber = 1;

		// Token: 0x0400670C RID: 26380
		private int level_;

		// Token: 0x0400670D RID: 26381
		public const int InstigatorIdFieldNumber = 10;

		// Token: 0x0400670E RID: 26382
		private long instigatorId_;

		// Token: 0x0400670F RID: 26383
		public const int ApplyTypeFieldNumber = 5;

		// Token: 0x04006710 RID: 26384
		private ApplyGEType applyType_;

		// Token: 0x04006711 RID: 26385
		public const int DurationFieldNumber = 13;

		// Token: 0x04006712 RID: 26386
		private static readonly float DurationDefaultValue;

		// Token: 0x04006713 RID: 26387
		private float duration_;

		// Token: 0x04006714 RID: 26388
		public const int ServerIdFieldNumber = 7;

		// Token: 0x04006715 RID: 26389
		private int serverId_;

		// Token: 0x04006716 RID: 26390
		public const int StackCountFieldNumber = 12;

		// Token: 0x04006717 RID: 26391
		private int stackCount_;

		// Token: 0x04006718 RID: 26392
		public const int IsIterableFieldNumber = 2;

		// Token: 0x04006719 RID: 26393
		private bool isIterable_;

		// Token: 0x0400671A RID: 26394
		public const int TransferContextIdFieldNumber = 8;

		// Token: 0x0400671B RID: 26395
		private TransferContextId transferContextId_;

		// Token: 0x0400671C RID: 26396
		public const int ReasonFieldNumber = 6;

		// Token: 0x0400671D RID: 26397
		private string reason_ = "";
	}
}
