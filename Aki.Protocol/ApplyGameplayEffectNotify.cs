using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000101 RID: 257
	[NetMessage(EMessageId.ApplyGameplayEffectNotify)]
	public sealed class ApplyGameplayEffectNotify : IMessage<ApplyGameplayEffectNotify>, IMessage, IEquatable<ApplyGameplayEffectNotify>, IDeepCloneable<ApplyGameplayEffectNotify>, IBufferMessage
	{
		// Token: 0x0600240A RID: 9226 RVA: 0x00060058 File Offset: 0x0005E258
		[NullableContext(1)]
		public static ApplyGameplayEffectNotify Create()
		{
			return new ApplyGameplayEffectNotify();
		}

		// Token: 0x170004C7 RID: 1223
		// (get) Token: 0x0600240B RID: 9227 RVA: 0x0006005F File Offset: 0x0005E25F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170004C8 RID: 1224
		// (get) Token: 0x0600240C RID: 9228 RVA: 0x00060062 File Offset: 0x0005E262
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ApplyGameplayEffectNotify.Descriptor;
			}
		}

		// Token: 0x0600240D RID: 9229 RVA: 0x00060069 File Offset: 0x0005E269
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ApplyGameplayEffectNotify()
		{
		}

		// Token: 0x0600240E RID: 9230 RVA: 0x00060074 File Offset: 0x0005E274
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ApplyGameplayEffectNotify(ApplyGameplayEffectNotify other) : this()
		{
			this._hasBits0 = other._hasBits0;
			this.handle_ = other.handle_;
			this.id_ = other.id_;
			this.level_ = other.level_;
			this.entityId_ = other.entityId_;
			this.instigatorId_ = other.instigatorId_;
			this.applyType_ = other.applyType_;
			this.duration_ = other.duration_;
			this.isActive_ = other.isActive_;
			this.serverId_ = other.serverId_;
			this.stackCount_ = other.stackCount_;
			this.leftDuration_ = other.leftDuration_;
			this.confBuffId_ = other.confBuffId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600240F RID: 9231 RVA: 0x00060134 File Offset: 0x0005E334
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ApplyGameplayEffectNotify Clone()
		{
			return new ApplyGameplayEffectNotify(this);
		}

		// Token: 0x170004C9 RID: 1225
		// (get) Token: 0x06002410 RID: 9232 RVA: 0x0006013C File Offset: 0x0005E33C
		// (set) Token: 0x06002411 RID: 9233 RVA: 0x00060144 File Offset: 0x0005E344
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

		// Token: 0x170004CA RID: 1226
		// (get) Token: 0x06002412 RID: 9234 RVA: 0x0006014D File Offset: 0x0005E34D
		// (set) Token: 0x06002413 RID: 9235 RVA: 0x00060155 File Offset: 0x0005E355
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

		// Token: 0x170004CB RID: 1227
		// (get) Token: 0x06002414 RID: 9236 RVA: 0x0006015E File Offset: 0x0005E35E
		// (set) Token: 0x06002415 RID: 9237 RVA: 0x00060166 File Offset: 0x0005E366
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

		// Token: 0x170004CC RID: 1228
		// (get) Token: 0x06002416 RID: 9238 RVA: 0x0006016F File Offset: 0x0005E36F
		// (set) Token: 0x06002417 RID: 9239 RVA: 0x00060177 File Offset: 0x0005E377
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long EntityId
		{
			get
			{
				return this.entityId_;
			}
			set
			{
				this.entityId_ = value;
			}
		}

		// Token: 0x170004CD RID: 1229
		// (get) Token: 0x06002418 RID: 9240 RVA: 0x00060180 File Offset: 0x0005E380
		// (set) Token: 0x06002419 RID: 9241 RVA: 0x00060188 File Offset: 0x0005E388
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

		// Token: 0x170004CE RID: 1230
		// (get) Token: 0x0600241A RID: 9242 RVA: 0x00060191 File Offset: 0x0005E391
		// (set) Token: 0x0600241B RID: 9243 RVA: 0x00060199 File Offset: 0x0005E399
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

		// Token: 0x170004CF RID: 1231
		// (get) Token: 0x0600241C RID: 9244 RVA: 0x000601A2 File Offset: 0x0005E3A2
		// (set) Token: 0x0600241D RID: 9245 RVA: 0x000601BA File Offset: 0x0005E3BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public float Duration
		{
			get
			{
				if ((this._hasBits0 & 2) != 0)
				{
					return this.duration_;
				}
				return ApplyGameplayEffectNotify.DurationDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.duration_ = value;
			}
		}

		// Token: 0x170004D0 RID: 1232
		// (get) Token: 0x0600241E RID: 9246 RVA: 0x000601D1 File Offset: 0x0005E3D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasDuration
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x0600241F RID: 9247 RVA: 0x000601DE File Offset: 0x0005E3DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearDuration()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x170004D1 RID: 1233
		// (get) Token: 0x06002420 RID: 9248 RVA: 0x000601EF File Offset: 0x0005E3EF
		// (set) Token: 0x06002421 RID: 9249 RVA: 0x000601F7 File Offset: 0x0005E3F7
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

		// Token: 0x170004D2 RID: 1234
		// (get) Token: 0x06002422 RID: 9250 RVA: 0x00060200 File Offset: 0x0005E400
		// (set) Token: 0x06002423 RID: 9251 RVA: 0x00060208 File Offset: 0x0005E408
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

		// Token: 0x170004D3 RID: 1235
		// (get) Token: 0x06002424 RID: 9252 RVA: 0x00060211 File Offset: 0x0005E411
		// (set) Token: 0x06002425 RID: 9253 RVA: 0x00060219 File Offset: 0x0005E419
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

		// Token: 0x170004D4 RID: 1236
		// (get) Token: 0x06002426 RID: 9254 RVA: 0x00060222 File Offset: 0x0005E422
		// (set) Token: 0x06002427 RID: 9255 RVA: 0x0006023A File Offset: 0x0005E43A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public float LeftDuration
		{
			get
			{
				if ((this._hasBits0 & 1) != 0)
				{
					return this.leftDuration_;
				}
				return ApplyGameplayEffectNotify.LeftDurationDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.leftDuration_ = value;
			}
		}

		// Token: 0x170004D5 RID: 1237
		// (get) Token: 0x06002428 RID: 9256 RVA: 0x00060251 File Offset: 0x0005E451
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasLeftDuration
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06002429 RID: 9257 RVA: 0x0006025E File Offset: 0x0005E45E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearLeftDuration()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x170004D6 RID: 1238
		// (get) Token: 0x0600242A RID: 9258 RVA: 0x0006026F File Offset: 0x0005E46F
		// (set) Token: 0x0600242B RID: 9259 RVA: 0x00060277 File Offset: 0x0005E477
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

		// Token: 0x0600242C RID: 9260 RVA: 0x00060280 File Offset: 0x0005E480
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ApplyGameplayEffectNotify);
		}

		// Token: 0x0600242D RID: 9261 RVA: 0x00060290 File Offset: 0x0005E490
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ApplyGameplayEffectNotify other)
		{
			return other != null && (other == this || (this.Handle == other.Handle && this.Id == other.Id && this.Level == other.Level && this.EntityId == other.EntityId && this.InstigatorId == other.InstigatorId && this.ApplyType == other.ApplyType && ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.Duration, other.Duration) && this.IsActive == other.IsActive && this.ServerId == other.ServerId && this.StackCount == other.StackCount && ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.LeftDuration, other.LeftDuration) && this.ConfBuffId == other.ConfBuffId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600242E RID: 9262 RVA: 0x00060390 File Offset: 0x0005E590
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
			if (this.EntityId != 0L)
			{
				num ^= this.EntityId.GetHashCode();
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
			if (this.IsActive)
			{
				num ^= this.IsActive.GetHashCode();
			}
			if (this.ServerId != 0)
			{
				num ^= this.ServerId.GetHashCode();
			}
			if (this.StackCount != 0)
			{
				num ^= this.StackCount.GetHashCode();
			}
			if (this.HasLeftDuration)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.LeftDuration);
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

		// Token: 0x0600242F RID: 9263 RVA: 0x000604ED File Offset: 0x0005E6ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06002430 RID: 9264 RVA: 0x000604FA File Offset: 0x0005E6FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002431 RID: 9265 RVA: 0x00060504 File Offset: 0x0005E704
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.StackCount != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.StackCount);
			}
			if (this.Handle != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Handle);
			}
			if (this.Level != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.Level);
			}
			if (this.IsActive)
			{
				output.WriteRawTag(48);
				output.WriteBool(this.IsActive);
			}
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(56);
				output.WriteInt64(this.EntityId);
			}
			if (this.InstigatorId != 0L)
			{
				output.WriteRawTag(64);
				output.WriteInt64(this.InstigatorId);
			}
			if (this.ApplyType != ApplyGEType.Common)
			{
				output.WriteRawTag(72);
				output.WriteEnum((int)this.ApplyType);
			}
			if (this.ServerId != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.ServerId);
			}
			if (this.Id != 0L)
			{
				output.WriteRawTag(88);
				output.WriteInt64(this.Id);
			}
			if (this.HasLeftDuration)
			{
				output.WriteRawTag(101);
				output.WriteFloat(this.LeftDuration);
			}
			if (this.ConfBuffId != 0L)
			{
				output.WriteRawTag(112);
				output.WriteInt64(this.ConfBuffId);
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

		// Token: 0x06002432 RID: 9266 RVA: 0x00060674 File Offset: 0x0005E874
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
			if (this.EntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EntityId);
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
			if (this.IsActive)
			{
				num += 2;
			}
			if (this.ServerId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ServerId);
			}
			if (this.StackCount != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.StackCount);
			}
			if (this.HasLeftDuration)
			{
				num += 5;
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

		// Token: 0x06002433 RID: 9267 RVA: 0x00060798 File Offset: 0x0005E998
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ApplyGameplayEffectNotify other)
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
			if (other.EntityId != 0L)
			{
				this.EntityId = other.EntityId;
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
			if (other.IsActive)
			{
				this.IsActive = other.IsActive;
			}
			if (other.ServerId != 0)
			{
				this.ServerId = other.ServerId;
			}
			if (other.StackCount != 0)
			{
				this.StackCount = other.StackCount;
			}
			if (other.HasLeftDuration)
			{
				this.LeftDuration = other.LeftDuration;
			}
			if (other.ConfBuffId != 0L)
			{
				this.ConfBuffId = other.ConfBuffId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06002434 RID: 9268 RVA: 0x000608B0 File Offset: 0x0005EAB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002435 RID: 9269 RVA: 0x000608BC File Offset: 0x0005EABC
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
				if (num <= 64U)
				{
					if (num <= 40U)
					{
						if (num == 8U)
						{
							this.StackCount = input.ReadInt32();
							continue;
						}
						if (num == 16U)
						{
							this.Handle = input.ReadInt32();
							continue;
						}
						if (num == 40U)
						{
							this.Level = input.ReadInt32();
							continue;
						}
					}
					else
					{
						if (num == 48U)
						{
							this.IsActive = input.ReadBool();
							continue;
						}
						if (num == 56U)
						{
							this.EntityId = input.ReadInt64();
							continue;
						}
						if (num == 64U)
						{
							this.InstigatorId = input.ReadInt64();
							continue;
						}
					}
				}
				else if (num <= 88U)
				{
					if (num == 72U)
					{
						this.ApplyType = (ApplyGEType)input.ReadEnum();
						continue;
					}
					if (num == 80U)
					{
						this.ServerId = input.ReadInt32();
						continue;
					}
					if (num == 88U)
					{
						this.Id = input.ReadInt64();
						continue;
					}
				}
				else
				{
					if (num == 101U)
					{
						this.LeftDuration = input.ReadFloat();
						continue;
					}
					if (num == 112U)
					{
						this.ConfBuffId = input.ReadInt64();
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

		// Token: 0x0400252D RID: 9517
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400252E RID: 9518
		private int _hasBits0;

		// Token: 0x0400252F RID: 9519
		public const int HandleFieldNumber = 2;

		// Token: 0x04002530 RID: 9520
		private int handle_;

		// Token: 0x04002531 RID: 9521
		public const int IdFieldNumber = 11;

		// Token: 0x04002532 RID: 9522
		private long id_;

		// Token: 0x04002533 RID: 9523
		public const int LevelFieldNumber = 5;

		// Token: 0x04002534 RID: 9524
		private int level_;

		// Token: 0x04002535 RID: 9525
		public const int EntityIdFieldNumber = 7;

		// Token: 0x04002536 RID: 9526
		private long entityId_;

		// Token: 0x04002537 RID: 9527
		public const int InstigatorIdFieldNumber = 8;

		// Token: 0x04002538 RID: 9528
		private long instigatorId_;

		// Token: 0x04002539 RID: 9529
		public const int ApplyTypeFieldNumber = 9;

		// Token: 0x0400253A RID: 9530
		private ApplyGEType applyType_;

		// Token: 0x0400253B RID: 9531
		public const int DurationFieldNumber = 15;

		// Token: 0x0400253C RID: 9532
		private static readonly float DurationDefaultValue;

		// Token: 0x0400253D RID: 9533
		private float duration_;

		// Token: 0x0400253E RID: 9534
		public const int IsActiveFieldNumber = 6;

		// Token: 0x0400253F RID: 9535
		private bool isActive_;

		// Token: 0x04002540 RID: 9536
		public const int ServerIdFieldNumber = 10;

		// Token: 0x04002541 RID: 9537
		private int serverId_;

		// Token: 0x04002542 RID: 9538
		public const int StackCountFieldNumber = 1;

		// Token: 0x04002543 RID: 9539
		private int stackCount_;

		// Token: 0x04002544 RID: 9540
		public const int LeftDurationFieldNumber = 12;

		// Token: 0x04002545 RID: 9541
		private static readonly float LeftDurationDefaultValue;

		// Token: 0x04002546 RID: 9542
		private float leftDuration_;

		// Token: 0x04002547 RID: 9543
		public const int ConfBuffIdFieldNumber = 14;

		// Token: 0x04002548 RID: 9544
		private long confBuffId_;
	}
}
