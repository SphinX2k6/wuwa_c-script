using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000102 RID: 258
	[NetMessage(EMessageId.ApplyGameplayEffectPush)]
	public sealed class ApplyGameplayEffectPush : IMessage<ApplyGameplayEffectPush>, IMessage, IEquatable<ApplyGameplayEffectPush>, IDeepCloneable<ApplyGameplayEffectPush>, IBufferMessage
	{
		// Token: 0x0600246D RID: 9325 RVA: 0x000614EF File Offset: 0x0005F6EF
		[NullableContext(1)]
		public static ApplyGameplayEffectPush Create()
		{
			return new ApplyGameplayEffectPush();
		}

		// Token: 0x170004DD RID: 1245
		// (get) Token: 0x0600246E RID: 9326 RVA: 0x000614F6 File Offset: 0x0005F6F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170004DE RID: 1246
		// (get) Token: 0x0600246F RID: 9327 RVA: 0x000614F9 File Offset: 0x0005F6F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ApplyGameplayEffectPush.Descriptor;
			}
		}

		// Token: 0x06002470 RID: 9328 RVA: 0x00061500 File Offset: 0x0005F700
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ApplyGameplayEffectPush()
		{
		}

		// Token: 0x06002471 RID: 9329 RVA: 0x00061514 File Offset: 0x0005F714
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ApplyGameplayEffectPush(ApplyGameplayEffectPush other) : this()
		{
			this._hasBits0 = other._hasBits0;
			this.handle_ = other.handle_;
			this.id_ = other.id_;
			this.level_ = other.level_;
			this.instigatorId_ = other.instigatorId_;
			this.applyType_ = other.applyType_;
			this.duration_ = other.duration_;
			this.serverId_ = other.serverId_;
			this.stackCount_ = other.stackCount_;
			this.isActive_ = other.isActive_;
			this.reason_ = other.reason_;
			this.confBuffId_ = other.confBuffId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002472 RID: 9330 RVA: 0x000615C8 File Offset: 0x0005F7C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ApplyGameplayEffectPush Clone()
		{
			return new ApplyGameplayEffectPush(this);
		}

		// Token: 0x170004DF RID: 1247
		// (get) Token: 0x06002473 RID: 9331 RVA: 0x000615D0 File Offset: 0x0005F7D0
		// (set) Token: 0x06002474 RID: 9332 RVA: 0x000615D8 File Offset: 0x0005F7D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Handle
		{
			get
			{
				return this.handle_;
			}
			set
			{
				this.handle_ = value;
			}
		}

		// Token: 0x170004E0 RID: 1248
		// (get) Token: 0x06002475 RID: 9333 RVA: 0x000615E1 File Offset: 0x0005F7E1
		// (set) Token: 0x06002476 RID: 9334 RVA: 0x000615E9 File Offset: 0x0005F7E9
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

		// Token: 0x170004E1 RID: 1249
		// (get) Token: 0x06002477 RID: 9335 RVA: 0x000615F2 File Offset: 0x0005F7F2
		// (set) Token: 0x06002478 RID: 9336 RVA: 0x000615FA File Offset: 0x0005F7FA
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

		// Token: 0x170004E2 RID: 1250
		// (get) Token: 0x06002479 RID: 9337 RVA: 0x00061603 File Offset: 0x0005F803
		// (set) Token: 0x0600247A RID: 9338 RVA: 0x0006160B File Offset: 0x0005F80B
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

		// Token: 0x170004E3 RID: 1251
		// (get) Token: 0x0600247B RID: 9339 RVA: 0x00061614 File Offset: 0x0005F814
		// (set) Token: 0x0600247C RID: 9340 RVA: 0x0006161C File Offset: 0x0005F81C
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

		// Token: 0x170004E4 RID: 1252
		// (get) Token: 0x0600247D RID: 9341 RVA: 0x00061625 File Offset: 0x0005F825
		// (set) Token: 0x0600247E RID: 9342 RVA: 0x0006163D File Offset: 0x0005F83D
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
				return ApplyGameplayEffectPush.DurationDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.duration_ = value;
			}
		}

		// Token: 0x170004E5 RID: 1253
		// (get) Token: 0x0600247F RID: 9343 RVA: 0x00061654 File Offset: 0x0005F854
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasDuration
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06002480 RID: 9344 RVA: 0x00061661 File Offset: 0x0005F861
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearDuration()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x170004E6 RID: 1254
		// (get) Token: 0x06002481 RID: 9345 RVA: 0x00061672 File Offset: 0x0005F872
		// (set) Token: 0x06002482 RID: 9346 RVA: 0x0006167A File Offset: 0x0005F87A
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

		// Token: 0x170004E7 RID: 1255
		// (get) Token: 0x06002483 RID: 9347 RVA: 0x00061683 File Offset: 0x0005F883
		// (set) Token: 0x06002484 RID: 9348 RVA: 0x0006168B File Offset: 0x0005F88B
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

		// Token: 0x170004E8 RID: 1256
		// (get) Token: 0x06002485 RID: 9349 RVA: 0x00061694 File Offset: 0x0005F894
		// (set) Token: 0x06002486 RID: 9350 RVA: 0x0006169C File Offset: 0x0005F89C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsActive
		{
			get
			{
				return this.isActive_;
			}
			set
			{
				this.isActive_ = value;
			}
		}

		// Token: 0x170004E9 RID: 1257
		// (get) Token: 0x06002487 RID: 9351 RVA: 0x000616A5 File Offset: 0x0005F8A5
		// (set) Token: 0x06002488 RID: 9352 RVA: 0x000616AD File Offset: 0x0005F8AD
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

		// Token: 0x170004EA RID: 1258
		// (get) Token: 0x06002489 RID: 9353 RVA: 0x000616C0 File Offset: 0x0005F8C0
		// (set) Token: 0x0600248A RID: 9354 RVA: 0x000616C8 File Offset: 0x0005F8C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long ConfBuffId
		{
			get
			{
				return this.confBuffId_;
			}
			set
			{
				this.confBuffId_ = value;
			}
		}

		// Token: 0x0600248B RID: 9355 RVA: 0x000616D1 File Offset: 0x0005F8D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ApplyGameplayEffectPush);
		}

		// Token: 0x0600248C RID: 9356 RVA: 0x000616E0 File Offset: 0x0005F8E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ApplyGameplayEffectPush other)
		{
			return other != null && (other == this || (this.Handle == other.Handle && this.Id == other.Id && this.Level == other.Level && this.InstigatorId == other.InstigatorId && this.ApplyType == other.ApplyType && ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.Duration, other.Duration) && this.ServerId == other.ServerId && this.StackCount == other.StackCount && this.IsActive == other.IsActive && !(this.Reason != other.Reason) && this.ConfBuffId == other.ConfBuffId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600248D RID: 9357 RVA: 0x000617C8 File Offset: 0x0005F9C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Handle != 0)
			{
				num ^= this.Handle.GetHashCode();
			}
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
			if (this.IsActive)
			{
				num ^= this.IsActive.GetHashCode();
			}
			if (this.Reason.Length != 0)
			{
				num ^= this.Reason.GetHashCode();
			}
			if (this.ConfBuffId != 0L)
			{
				num ^= this.ConfBuffId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600248E RID: 9358 RVA: 0x0006190C File Offset: 0x0005FB0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600248F RID: 9359 RVA: 0x00061919 File Offset: 0x0005FB19
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002490 RID: 9360 RVA: 0x00061924 File Offset: 0x0005FB24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Reason.Length != 0)
			{
				output.WriteRawTag(10);
				output.WriteString(this.Reason);
			}
			if (this.ServerId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.ServerId);
			}
			if (this.IsActive)
			{
				output.WriteRawTag(32);
				output.WriteBool(this.IsActive);
			}
			if (this.ApplyType != ApplyGEType.Common)
			{
				output.WriteRawTag(48);
				output.WriteEnum((int)this.ApplyType);
			}
			if (this.Level != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.Level);
			}
			if (this.Handle != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.Handle);
			}
			if (this.InstigatorId != 0L)
			{
				output.WriteRawTag(80);
				output.WriteInt64(this.InstigatorId);
			}
			if (this.HasDuration)
			{
				output.WriteRawTag(93);
				output.WriteFloat(this.Duration);
			}
			if (this.StackCount != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.StackCount);
			}
			if (this.ConfBuffId != 0L)
			{
				output.WriteRawTag(112);
				output.WriteInt64(this.ConfBuffId);
			}
			if (this.Id != 0L)
			{
				output.WriteRawTag(120);
				output.WriteInt64(this.Id);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002491 RID: 9361 RVA: 0x00061A80 File Offset: 0x0005FC80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Handle != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Handle);
			}
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
			if (this.IsActive)
			{
				num += 2;
			}
			if (this.Reason.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Reason);
			}
			if (this.ConfBuffId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.ConfBuffId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06002492 RID: 9362 RVA: 0x00061B9C File Offset: 0x0005FD9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ApplyGameplayEffectPush other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Handle != 0)
			{
				this.Handle = other.Handle;
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
			if (other.IsActive)
			{
				this.IsActive = other.IsActive;
			}
			if (other.Reason.Length != 0)
			{
				this.Reason = other.Reason;
			}
			if (other.ConfBuffId != 0L)
			{
				this.ConfBuffId = other.ConfBuffId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06002493 RID: 9363 RVA: 0x00061CA5 File Offset: 0x0005FEA5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002494 RID: 9364 RVA: 0x00061CB0 File Offset: 0x0005FEB0
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
					if (num <= 24U)
					{
						if (num == 10U)
						{
							this.Reason = input.ReadString();
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
						if (num == 32U)
						{
							this.IsActive = input.ReadBool();
							continue;
						}
						if (num == 48U)
						{
							this.ApplyType = (ApplyGEType)input.ReadEnum();
							continue;
						}
						if (num == 56U)
						{
							this.Level = input.ReadInt32();
							continue;
						}
					}
				}
				else if (num <= 93U)
				{
					if (num == 64U)
					{
						this.Handle = input.ReadInt32();
						continue;
					}
					if (num == 80U)
					{
						this.InstigatorId = input.ReadInt64();
						continue;
					}
					if (num == 93U)
					{
						this.Duration = input.ReadFloat();
						continue;
					}
				}
				else
				{
					if (num == 96U)
					{
						this.StackCount = input.ReadInt32();
						continue;
					}
					if (num == 112U)
					{
						this.ConfBuffId = input.ReadInt64();
						continue;
					}
					if (num == 120U)
					{
						this.Id = input.ReadInt64();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040025A8 RID: 9640
		private UnknownFieldSet _unknownFields;

		// Token: 0x040025A9 RID: 9641
		private int _hasBits0;

		// Token: 0x040025AA RID: 9642
		public const int HandleFieldNumber = 8;

		// Token: 0x040025AB RID: 9643
		private int handle_;

		// Token: 0x040025AC RID: 9644
		public const int IdFieldNumber = 15;

		// Token: 0x040025AD RID: 9645
		private long id_;

		// Token: 0x040025AE RID: 9646
		public const int LevelFieldNumber = 7;

		// Token: 0x040025AF RID: 9647
		private int level_;

		// Token: 0x040025B0 RID: 9648
		public const int InstigatorIdFieldNumber = 10;

		// Token: 0x040025B1 RID: 9649
		private long instigatorId_;

		// Token: 0x040025B2 RID: 9650
		public const int ApplyTypeFieldNumber = 6;

		// Token: 0x040025B3 RID: 9651
		private ApplyGEType applyType_;

		// Token: 0x040025B4 RID: 9652
		public const int DurationFieldNumber = 11;

		// Token: 0x040025B5 RID: 9653
		private static readonly float DurationDefaultValue;

		// Token: 0x040025B6 RID: 9654
		private float duration_;

		// Token: 0x040025B7 RID: 9655
		public const int ServerIdFieldNumber = 3;

		// Token: 0x040025B8 RID: 9656
		private int serverId_;

		// Token: 0x040025B9 RID: 9657
		public const int StackCountFieldNumber = 12;

		// Token: 0x040025BA RID: 9658
		private int stackCount_;

		// Token: 0x040025BB RID: 9659
		public const int IsActiveFieldNumber = 4;

		// Token: 0x040025BC RID: 9660
		private bool isActive_;

		// Token: 0x040025BD RID: 9661
		public const int ReasonFieldNumber = 1;

		// Token: 0x040025BE RID: 9662
		private string reason_ = "";

		// Token: 0x040025BF RID: 9663
		public const int ConfBuffIdFieldNumber = 14;

		// Token: 0x040025C0 RID: 9664
		private long confBuffId_;
	}
}
