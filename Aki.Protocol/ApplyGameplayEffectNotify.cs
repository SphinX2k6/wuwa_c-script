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
		// Token: 0x06002441 RID: 9281 RVA: 0x00060B2C File Offset: 0x0005ED2C
		[NullableContext(1)]
		public static ApplyGameplayEffectNotify Create()
		{
			return new ApplyGameplayEffectNotify();
		}

		// Token: 0x170004CD RID: 1229
		// (get) Token: 0x06002442 RID: 9282 RVA: 0x00060B33 File Offset: 0x0005ED33
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170004CE RID: 1230
		// (get) Token: 0x06002443 RID: 9283 RVA: 0x00060B36 File Offset: 0x0005ED36
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ApplyGameplayEffectNotify.Descriptor;
			}
		}

		// Token: 0x06002444 RID: 9284 RVA: 0x00060B3D File Offset: 0x0005ED3D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ApplyGameplayEffectNotify()
		{
		}

		// Token: 0x06002445 RID: 9285 RVA: 0x00060B48 File Offset: 0x0005ED48
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

		// Token: 0x06002446 RID: 9286 RVA: 0x00060C08 File Offset: 0x0005EE08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ApplyGameplayEffectNotify Clone()
		{
			return new ApplyGameplayEffectNotify(this);
		}

		// Token: 0x170004CF RID: 1231
		// (get) Token: 0x06002447 RID: 9287 RVA: 0x00060C10 File Offset: 0x0005EE10
		// (set) Token: 0x06002448 RID: 9288 RVA: 0x00060C18 File Offset: 0x0005EE18
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

		// Token: 0x170004D0 RID: 1232
		// (get) Token: 0x06002449 RID: 9289 RVA: 0x00060C21 File Offset: 0x0005EE21
		// (set) Token: 0x0600244A RID: 9290 RVA: 0x00060C29 File Offset: 0x0005EE29
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

		// Token: 0x170004D1 RID: 1233
		// (get) Token: 0x0600244B RID: 9291 RVA: 0x00060C32 File Offset: 0x0005EE32
		// (set) Token: 0x0600244C RID: 9292 RVA: 0x00060C3A File Offset: 0x0005EE3A
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

		// Token: 0x170004D2 RID: 1234
		// (get) Token: 0x0600244D RID: 9293 RVA: 0x00060C43 File Offset: 0x0005EE43
		// (set) Token: 0x0600244E RID: 9294 RVA: 0x00060C4B File Offset: 0x0005EE4B
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

		// Token: 0x170004D3 RID: 1235
		// (get) Token: 0x0600244F RID: 9295 RVA: 0x00060C54 File Offset: 0x0005EE54
		// (set) Token: 0x06002450 RID: 9296 RVA: 0x00060C5C File Offset: 0x0005EE5C
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

		// Token: 0x170004D4 RID: 1236
		// (get) Token: 0x06002451 RID: 9297 RVA: 0x00060C65 File Offset: 0x0005EE65
		// (set) Token: 0x06002452 RID: 9298 RVA: 0x00060C6D File Offset: 0x0005EE6D
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

		// Token: 0x170004D5 RID: 1237
		// (get) Token: 0x06002453 RID: 9299 RVA: 0x00060C76 File Offset: 0x0005EE76
		// (set) Token: 0x06002454 RID: 9300 RVA: 0x00060C8E File Offset: 0x0005EE8E
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
				return ApplyGameplayEffectNotify.DurationDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.duration_ = value;
			}
		}

		// Token: 0x170004D6 RID: 1238
		// (get) Token: 0x06002455 RID: 9301 RVA: 0x00060CA5 File Offset: 0x0005EEA5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasDuration
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06002456 RID: 9302 RVA: 0x00060CB2 File Offset: 0x0005EEB2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearDuration()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x170004D7 RID: 1239
		// (get) Token: 0x06002457 RID: 9303 RVA: 0x00060CC3 File Offset: 0x0005EEC3
		// (set) Token: 0x06002458 RID: 9304 RVA: 0x00060CCB File Offset: 0x0005EECB
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

		// Token: 0x170004D8 RID: 1240
		// (get) Token: 0x06002459 RID: 9305 RVA: 0x00060CD4 File Offset: 0x0005EED4
		// (set) Token: 0x0600245A RID: 9306 RVA: 0x00060CDC File Offset: 0x0005EEDC
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

		// Token: 0x170004D9 RID: 1241
		// (get) Token: 0x0600245B RID: 9307 RVA: 0x00060CE5 File Offset: 0x0005EEE5
		// (set) Token: 0x0600245C RID: 9308 RVA: 0x00060CED File Offset: 0x0005EEED
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

		// Token: 0x170004DA RID: 1242
		// (get) Token: 0x0600245D RID: 9309 RVA: 0x00060CF6 File Offset: 0x0005EEF6
		// (set) Token: 0x0600245E RID: 9310 RVA: 0x00060D0E File Offset: 0x0005EF0E
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
				return ApplyGameplayEffectNotify.LeftDurationDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.leftDuration_ = value;
			}
		}

		// Token: 0x170004DB RID: 1243
		// (get) Token: 0x0600245F RID: 9311 RVA: 0x00060D25 File Offset: 0x0005EF25
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasLeftDuration
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06002460 RID: 9312 RVA: 0x00060D32 File Offset: 0x0005EF32
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearLeftDuration()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x170004DC RID: 1244
		// (get) Token: 0x06002461 RID: 9313 RVA: 0x00060D43 File Offset: 0x0005EF43
		// (set) Token: 0x06002462 RID: 9314 RVA: 0x00060D4B File Offset: 0x0005EF4B
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

		// Token: 0x06002463 RID: 9315 RVA: 0x00060D54 File Offset: 0x0005EF54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ApplyGameplayEffectNotify);
		}

		// Token: 0x06002464 RID: 9316 RVA: 0x00060D64 File Offset: 0x0005EF64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ApplyGameplayEffectNotify other)
		{
			return other != null && (other == this || (this.Handle == other.Handle && this.Id == other.Id && this.Level == other.Level && this.EntityId == other.EntityId && this.InstigatorId == other.InstigatorId && this.ApplyType == other.ApplyType && ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.Duration, other.Duration) && this.IsActive == other.IsActive && this.ServerId == other.ServerId && this.StackCount == other.StackCount && ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.LeftDuration, other.LeftDuration) && this.ConfBuffId == other.ConfBuffId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002465 RID: 9317 RVA: 0x00060E64 File Offset: 0x0005F064
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

		// Token: 0x06002466 RID: 9318 RVA: 0x00060FC1 File Offset: 0x0005F1C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06002467 RID: 9319 RVA: 0x00060FCE File Offset: 0x0005F1CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002468 RID: 9320 RVA: 0x00060FD8 File Offset: 0x0005F1D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.HasDuration)
			{
				output.WriteRawTag(13);
				output.WriteFloat(this.Duration);
			}
			if (this.ServerId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.ServerId);
			}
			if (this.HasLeftDuration)
			{
				output.WriteRawTag(29);
				output.WriteFloat(this.LeftDuration);
			}
			if (this.ApplyType != ApplyGEType.Common)
			{
				output.WriteRawTag(32);
				output.WriteEnum((int)this.ApplyType);
			}
			if (this.Handle != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.Handle);
			}
			if (this.IsActive)
			{
				output.WriteRawTag(56);
				output.WriteBool(this.IsActive);
			}
			if (this.InstigatorId != 0L)
			{
				output.WriteRawTag(72);
				output.WriteInt64(this.InstigatorId);
			}
			if (this.StackCount != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.StackCount);
			}
			if (this.Level != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.Level);
			}
			if (this.ConfBuffId != 0L)
			{
				output.WriteRawTag(96);
				output.WriteInt64(this.ConfBuffId);
			}
			if (this.Id != 0L)
			{
				output.WriteRawTag(104);
				output.WriteInt64(this.Id);
			}
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(112);
				output.WriteInt64(this.EntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002469 RID: 9321 RVA: 0x0006114C File Offset: 0x0005F34C
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

		// Token: 0x0600246A RID: 9322 RVA: 0x00061270 File Offset: 0x0005F470
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

		// Token: 0x0600246B RID: 9323 RVA: 0x00061388 File Offset: 0x0005F588
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600246C RID: 9324 RVA: 0x00061394 File Offset: 0x0005F594
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
					if (num <= 29U)
					{
						if (num == 13U)
						{
							this.Duration = input.ReadFloat();
							continue;
						}
						if (num == 16U)
						{
							this.ServerId = input.ReadInt32();
							continue;
						}
						if (num == 29U)
						{
							this.LeftDuration = input.ReadFloat();
							continue;
						}
					}
					else
					{
						if (num == 32U)
						{
							this.ApplyType = (ApplyGEType)input.ReadEnum();
							continue;
						}
						if (num == 48U)
						{
							this.Handle = input.ReadInt32();
							continue;
						}
						if (num == 56U)
						{
							this.IsActive = input.ReadBool();
							continue;
						}
					}
				}
				else if (num <= 88U)
				{
					if (num == 72U)
					{
						this.InstigatorId = input.ReadInt64();
						continue;
					}
					if (num == 80U)
					{
						this.StackCount = input.ReadInt32();
						continue;
					}
					if (num == 88U)
					{
						this.Level = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 96U)
					{
						this.ConfBuffId = input.ReadInt64();
						continue;
					}
					if (num == 104U)
					{
						this.Id = input.ReadInt64();
						continue;
					}
					if (num == 112U)
					{
						this.EntityId = input.ReadInt64();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400258C RID: 9612
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400258D RID: 9613
		private int _hasBits0;

		// Token: 0x0400258E RID: 9614
		public const int HandleFieldNumber = 6;

		// Token: 0x0400258F RID: 9615
		private int handle_;

		// Token: 0x04002590 RID: 9616
		public const int IdFieldNumber = 13;

		// Token: 0x04002591 RID: 9617
		private long id_;

		// Token: 0x04002592 RID: 9618
		public const int LevelFieldNumber = 11;

		// Token: 0x04002593 RID: 9619
		private int level_;

		// Token: 0x04002594 RID: 9620
		public const int EntityIdFieldNumber = 14;

		// Token: 0x04002595 RID: 9621
		private long entityId_;

		// Token: 0x04002596 RID: 9622
		public const int InstigatorIdFieldNumber = 9;

		// Token: 0x04002597 RID: 9623
		private long instigatorId_;

		// Token: 0x04002598 RID: 9624
		public const int ApplyTypeFieldNumber = 4;

		// Token: 0x04002599 RID: 9625
		private ApplyGEType applyType_;

		// Token: 0x0400259A RID: 9626
		public const int DurationFieldNumber = 1;

		// Token: 0x0400259B RID: 9627
		private static readonly float DurationDefaultValue;

		// Token: 0x0400259C RID: 9628
		private float duration_;

		// Token: 0x0400259D RID: 9629
		public const int IsActiveFieldNumber = 7;

		// Token: 0x0400259E RID: 9630
		private bool isActive_;

		// Token: 0x0400259F RID: 9631
		public const int ServerIdFieldNumber = 2;

		// Token: 0x040025A0 RID: 9632
		private int serverId_;

		// Token: 0x040025A1 RID: 9633
		public const int StackCountFieldNumber = 10;

		// Token: 0x040025A2 RID: 9634
		private int stackCount_;

		// Token: 0x040025A3 RID: 9635
		public const int LeftDurationFieldNumber = 3;

		// Token: 0x040025A4 RID: 9636
		private static readonly float LeftDurationDefaultValue;

		// Token: 0x040025A5 RID: 9637
		private float leftDuration_;

		// Token: 0x040025A6 RID: 9638
		public const int ConfBuffIdFieldNumber = 12;

		// Token: 0x040025A7 RID: 9639
		private long confBuffId_;
	}
}
