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
		// Token: 0x06002436 RID: 9270 RVA: 0x00060A16 File Offset: 0x0005EC16
		[NullableContext(1)]
		public static ApplyGameplayEffectPush Create()
		{
			return new ApplyGameplayEffectPush();
		}

		// Token: 0x170004D7 RID: 1239
		// (get) Token: 0x06002437 RID: 9271 RVA: 0x00060A1D File Offset: 0x0005EC1D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170004D8 RID: 1240
		// (get) Token: 0x06002438 RID: 9272 RVA: 0x00060A20 File Offset: 0x0005EC20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ApplyGameplayEffectPush.Descriptor;
			}
		}

		// Token: 0x06002439 RID: 9273 RVA: 0x00060A27 File Offset: 0x0005EC27
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ApplyGameplayEffectPush()
		{
		}

		// Token: 0x0600243A RID: 9274 RVA: 0x00060A3C File Offset: 0x0005EC3C
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

		// Token: 0x0600243B RID: 9275 RVA: 0x00060AF0 File Offset: 0x0005ECF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ApplyGameplayEffectPush Clone()
		{
			return new ApplyGameplayEffectPush(this);
		}

		// Token: 0x170004D9 RID: 1241
		// (get) Token: 0x0600243C RID: 9276 RVA: 0x00060AF8 File Offset: 0x0005ECF8
		// (set) Token: 0x0600243D RID: 9277 RVA: 0x00060B00 File Offset: 0x0005ED00
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

		// Token: 0x170004DA RID: 1242
		// (get) Token: 0x0600243E RID: 9278 RVA: 0x00060B09 File Offset: 0x0005ED09
		// (set) Token: 0x0600243F RID: 9279 RVA: 0x00060B11 File Offset: 0x0005ED11
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

		// Token: 0x170004DB RID: 1243
		// (get) Token: 0x06002440 RID: 9280 RVA: 0x00060B1A File Offset: 0x0005ED1A
		// (set) Token: 0x06002441 RID: 9281 RVA: 0x00060B22 File Offset: 0x0005ED22
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

		// Token: 0x170004DC RID: 1244
		// (get) Token: 0x06002442 RID: 9282 RVA: 0x00060B2B File Offset: 0x0005ED2B
		// (set) Token: 0x06002443 RID: 9283 RVA: 0x00060B33 File Offset: 0x0005ED33
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

		// Token: 0x170004DD RID: 1245
		// (get) Token: 0x06002444 RID: 9284 RVA: 0x00060B3C File Offset: 0x0005ED3C
		// (set) Token: 0x06002445 RID: 9285 RVA: 0x00060B44 File Offset: 0x0005ED44
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

		// Token: 0x170004DE RID: 1246
		// (get) Token: 0x06002446 RID: 9286 RVA: 0x00060B4D File Offset: 0x0005ED4D
		// (set) Token: 0x06002447 RID: 9287 RVA: 0x00060B65 File Offset: 0x0005ED65
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

		// Token: 0x170004DF RID: 1247
		// (get) Token: 0x06002448 RID: 9288 RVA: 0x00060B7C File Offset: 0x0005ED7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasDuration
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06002449 RID: 9289 RVA: 0x00060B89 File Offset: 0x0005ED89
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearDuration()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x170004E0 RID: 1248
		// (get) Token: 0x0600244A RID: 9290 RVA: 0x00060B9A File Offset: 0x0005ED9A
		// (set) Token: 0x0600244B RID: 9291 RVA: 0x00060BA2 File Offset: 0x0005EDA2
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

		// Token: 0x170004E1 RID: 1249
		// (get) Token: 0x0600244C RID: 9292 RVA: 0x00060BAB File Offset: 0x0005EDAB
		// (set) Token: 0x0600244D RID: 9293 RVA: 0x00060BB3 File Offset: 0x0005EDB3
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

		// Token: 0x170004E2 RID: 1250
		// (get) Token: 0x0600244E RID: 9294 RVA: 0x00060BBC File Offset: 0x0005EDBC
		// (set) Token: 0x0600244F RID: 9295 RVA: 0x00060BC4 File Offset: 0x0005EDC4
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

		// Token: 0x170004E3 RID: 1251
		// (get) Token: 0x06002450 RID: 9296 RVA: 0x00060BCD File Offset: 0x0005EDCD
		// (set) Token: 0x06002451 RID: 9297 RVA: 0x00060BD5 File Offset: 0x0005EDD5
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

		// Token: 0x170004E4 RID: 1252
		// (get) Token: 0x06002452 RID: 9298 RVA: 0x00060BE8 File Offset: 0x0005EDE8
		// (set) Token: 0x06002453 RID: 9299 RVA: 0x00060BF0 File Offset: 0x0005EDF0
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

		// Token: 0x06002454 RID: 9300 RVA: 0x00060BF9 File Offset: 0x0005EDF9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ApplyGameplayEffectPush);
		}

		// Token: 0x06002455 RID: 9301 RVA: 0x00060C08 File Offset: 0x0005EE08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ApplyGameplayEffectPush other)
		{
			return other != null && (other == this || (this.Handle == other.Handle && this.Id == other.Id && this.Level == other.Level && this.InstigatorId == other.InstigatorId && this.ApplyType == other.ApplyType && ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.Duration, other.Duration) && this.ServerId == other.ServerId && this.StackCount == other.StackCount && this.IsActive == other.IsActive && !(this.Reason != other.Reason) && this.ConfBuffId == other.ConfBuffId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002456 RID: 9302 RVA: 0x00060CF0 File Offset: 0x0005EEF0
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

		// Token: 0x06002457 RID: 9303 RVA: 0x00060E34 File Offset: 0x0005F034
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06002458 RID: 9304 RVA: 0x00060E41 File Offset: 0x0005F041
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002459 RID: 9305 RVA: 0x00060E4C File Offset: 0x0005F04C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Reason.Length != 0)
			{
				output.WriteRawTag(18);
				output.WriteString(this.Reason);
			}
			if (this.Handle != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.Handle);
			}
			if (this.StackCount != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.StackCount);
			}
			if (this.Id != 0L)
			{
				output.WriteRawTag(40);
				output.WriteInt64(this.Id);
			}
			if (this.IsActive)
			{
				output.WriteRawTag(48);
				output.WriteBool(this.IsActive);
			}
			if (this.Level != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.Level);
			}
			if (this.HasDuration)
			{
				output.WriteRawTag(69);
				output.WriteFloat(this.Duration);
			}
			if (this.InstigatorId != 0L)
			{
				output.WriteRawTag(80);
				output.WriteInt64(this.InstigatorId);
			}
			if (this.ConfBuffId != 0L)
			{
				output.WriteRawTag(96);
				output.WriteInt64(this.ConfBuffId);
			}
			if (this.ApplyType != ApplyGEType.Common)
			{
				output.WriteRawTag(104);
				output.WriteEnum((int)this.ApplyType);
			}
			if (this.ServerId != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.ServerId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600245A RID: 9306 RVA: 0x00060FA8 File Offset: 0x0005F1A8
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

		// Token: 0x0600245B RID: 9307 RVA: 0x000610C4 File Offset: 0x0005F2C4
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

		// Token: 0x0600245C RID: 9308 RVA: 0x000611CD File Offset: 0x0005F3CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600245D RID: 9309 RVA: 0x000611D8 File Offset: 0x0005F3D8
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
						if (num == 18U)
						{
							this.Reason = input.ReadString();
							continue;
						}
						if (num == 24U)
						{
							this.Handle = input.ReadInt32();
							continue;
						}
					}
					else
					{
						if (num == 32U)
						{
							this.StackCount = input.ReadInt32();
							continue;
						}
						if (num == 40U)
						{
							this.Id = input.ReadInt64();
							continue;
						}
						if (num == 48U)
						{
							this.IsActive = input.ReadBool();
							continue;
						}
					}
				}
				else if (num <= 80U)
				{
					if (num == 56U)
					{
						this.Level = input.ReadInt32();
						continue;
					}
					if (num == 69U)
					{
						this.Duration = input.ReadFloat();
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
					if (num == 96U)
					{
						this.ConfBuffId = input.ReadInt64();
						continue;
					}
					if (num == 104U)
					{
						this.ApplyType = (ApplyGEType)input.ReadEnum();
						continue;
					}
					if (num == 112U)
					{
						this.ServerId = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04002549 RID: 9545
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400254A RID: 9546
		private int _hasBits0;

		// Token: 0x0400254B RID: 9547
		public const int HandleFieldNumber = 3;

		// Token: 0x0400254C RID: 9548
		private int handle_;

		// Token: 0x0400254D RID: 9549
		public const int IdFieldNumber = 5;

		// Token: 0x0400254E RID: 9550
		private long id_;

		// Token: 0x0400254F RID: 9551
		public const int LevelFieldNumber = 7;

		// Token: 0x04002550 RID: 9552
		private int level_;

		// Token: 0x04002551 RID: 9553
		public const int InstigatorIdFieldNumber = 10;

		// Token: 0x04002552 RID: 9554
		private long instigatorId_;

		// Token: 0x04002553 RID: 9555
		public const int ApplyTypeFieldNumber = 13;

		// Token: 0x04002554 RID: 9556
		private ApplyGEType applyType_;

		// Token: 0x04002555 RID: 9557
		public const int DurationFieldNumber = 8;

		// Token: 0x04002556 RID: 9558
		private static readonly float DurationDefaultValue;

		// Token: 0x04002557 RID: 9559
		private float duration_;

		// Token: 0x04002558 RID: 9560
		public const int ServerIdFieldNumber = 14;

		// Token: 0x04002559 RID: 9561
		private int serverId_;

		// Token: 0x0400255A RID: 9562
		public const int StackCountFieldNumber = 4;

		// Token: 0x0400255B RID: 9563
		private int stackCount_;

		// Token: 0x0400255C RID: 9564
		public const int IsActiveFieldNumber = 6;

		// Token: 0x0400255D RID: 9565
		private bool isActive_;

		// Token: 0x0400255E RID: 9566
		public const int ReasonFieldNumber = 2;

		// Token: 0x0400255F RID: 9567
		private string reason_ = "";

		// Token: 0x04002560 RID: 9568
		public const int ConfBuffIdFieldNumber = 12;

		// Token: 0x04002561 RID: 9569
		private long confBuffId_;
	}
}
