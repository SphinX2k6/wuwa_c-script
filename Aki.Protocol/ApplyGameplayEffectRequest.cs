using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000103 RID: 259
	[NetMessage(EMessageId.ApplyGameplayEffectRequest)]
	public sealed class ApplyGameplayEffectRequest : IMessage<ApplyGameplayEffectRequest>, IMessage, IEquatable<ApplyGameplayEffectRequest>, IDeepCloneable<ApplyGameplayEffectRequest>, IBufferMessage
	{
		// Token: 0x06002495 RID: 9365 RVA: 0x00061DEC File Offset: 0x0005FFEC
		[NullableContext(1)]
		public static ApplyGameplayEffectRequest Create()
		{
			return new ApplyGameplayEffectRequest();
		}

		// Token: 0x170004EB RID: 1259
		// (get) Token: 0x06002496 RID: 9366 RVA: 0x00061DF3 File Offset: 0x0005FFF3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170004EC RID: 1260
		// (get) Token: 0x06002497 RID: 9367 RVA: 0x00061DF6 File Offset: 0x0005FFF6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ApplyGameplayEffectRequest.Descriptor;
			}
		}

		// Token: 0x06002498 RID: 9368 RVA: 0x00061DFD File Offset: 0x0005FFFD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ApplyGameplayEffectRequest()
		{
		}

		// Token: 0x06002499 RID: 9369 RVA: 0x00061E08 File Offset: 0x00060008
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ApplyGameplayEffectRequest(ApplyGameplayEffectRequest other) : this()
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
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600249A RID: 9370 RVA: 0x00061EA4 File Offset: 0x000600A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ApplyGameplayEffectRequest Clone()
		{
			return new ApplyGameplayEffectRequest(this);
		}

		// Token: 0x170004ED RID: 1261
		// (get) Token: 0x0600249B RID: 9371 RVA: 0x00061EAC File Offset: 0x000600AC
		// (set) Token: 0x0600249C RID: 9372 RVA: 0x00061EB4 File Offset: 0x000600B4
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

		// Token: 0x170004EE RID: 1262
		// (get) Token: 0x0600249D RID: 9373 RVA: 0x00061EBD File Offset: 0x000600BD
		// (set) Token: 0x0600249E RID: 9374 RVA: 0x00061EC5 File Offset: 0x000600C5
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

		// Token: 0x170004EF RID: 1263
		// (get) Token: 0x0600249F RID: 9375 RVA: 0x00061ECE File Offset: 0x000600CE
		// (set) Token: 0x060024A0 RID: 9376 RVA: 0x00061ED6 File Offset: 0x000600D6
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

		// Token: 0x170004F0 RID: 1264
		// (get) Token: 0x060024A1 RID: 9377 RVA: 0x00061EDF File Offset: 0x000600DF
		// (set) Token: 0x060024A2 RID: 9378 RVA: 0x00061EE7 File Offset: 0x000600E7
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

		// Token: 0x170004F1 RID: 1265
		// (get) Token: 0x060024A3 RID: 9379 RVA: 0x00061EF0 File Offset: 0x000600F0
		// (set) Token: 0x060024A4 RID: 9380 RVA: 0x00061EF8 File Offset: 0x000600F8
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

		// Token: 0x170004F2 RID: 1266
		// (get) Token: 0x060024A5 RID: 9381 RVA: 0x00061F01 File Offset: 0x00060101
		// (set) Token: 0x060024A6 RID: 9382 RVA: 0x00061F19 File Offset: 0x00060119
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
				return ApplyGameplayEffectRequest.DurationDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.duration_ = value;
			}
		}

		// Token: 0x170004F3 RID: 1267
		// (get) Token: 0x060024A7 RID: 9383 RVA: 0x00061F30 File Offset: 0x00060130
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasDuration
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x060024A8 RID: 9384 RVA: 0x00061F3D File Offset: 0x0006013D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearDuration()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x170004F4 RID: 1268
		// (get) Token: 0x060024A9 RID: 9385 RVA: 0x00061F4E File Offset: 0x0006014E
		// (set) Token: 0x060024AA RID: 9386 RVA: 0x00061F56 File Offset: 0x00060156
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

		// Token: 0x170004F5 RID: 1269
		// (get) Token: 0x060024AB RID: 9387 RVA: 0x00061F5F File Offset: 0x0006015F
		// (set) Token: 0x060024AC RID: 9388 RVA: 0x00061F67 File Offset: 0x00060167
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

		// Token: 0x170004F6 RID: 1270
		// (get) Token: 0x060024AD RID: 9389 RVA: 0x00061F70 File Offset: 0x00060170
		// (set) Token: 0x060024AE RID: 9390 RVA: 0x00061F78 File Offset: 0x00060178
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

		// Token: 0x060024AF RID: 9391 RVA: 0x00061F81 File Offset: 0x00060181
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ApplyGameplayEffectRequest);
		}

		// Token: 0x060024B0 RID: 9392 RVA: 0x00061F90 File Offset: 0x00060190
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ApplyGameplayEffectRequest other)
		{
			return other != null && (other == this || (this.Handle == other.Handle && this.Id == other.Id && this.Level == other.Level && this.InstigatorId == other.InstigatorId && this.ApplyType == other.ApplyType && ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.Duration, other.Duration) && this.ServerId == other.ServerId && this.StackCount == other.StackCount && this.IsActive == other.IsActive && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060024B1 RID: 9393 RVA: 0x00062054 File Offset: 0x00060254
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
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060024B2 RID: 9394 RVA: 0x00062164 File Offset: 0x00060364
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060024B3 RID: 9395 RVA: 0x00062171 File Offset: 0x00060371
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060024B4 RID: 9396 RVA: 0x0006217C File Offset: 0x0006037C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ApplyType != ApplyGEType.Common)
			{
				output.WriteRawTag(8);
				output.WriteEnum((int)this.ApplyType);
			}
			if (this.IsActive)
			{
				output.WriteRawTag(16);
				output.WriteBool(this.IsActive);
			}
			if (this.ServerId != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.ServerId);
			}
			if (this.Handle != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.Handle);
			}
			if (this.Level != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.Level);
			}
			if (this.InstigatorId != 0L)
			{
				output.WriteRawTag(80);
				output.WriteInt64(this.InstigatorId);
			}
			if (this.HasDuration)
			{
				output.WriteRawTag(101);
				output.WriteFloat(this.Duration);
			}
			if (this.Id != 0L)
			{
				output.WriteRawTag(104);
				output.WriteInt64(this.Id);
			}
			if (this.StackCount != 0)
			{
				output.WriteRawTag(120);
				output.WriteInt32(this.StackCount);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060024B5 RID: 9397 RVA: 0x00062298 File Offset: 0x00060498
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
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060024B6 RID: 9398 RVA: 0x00062380 File Offset: 0x00060580
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ApplyGameplayEffectRequest other)
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
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060024B7 RID: 9399 RVA: 0x0006245C File Offset: 0x0006065C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060024B8 RID: 9400 RVA: 0x00062468 File Offset: 0x00060668
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
				if (num <= 40U)
				{
					if (num <= 16U)
					{
						if (num == 8U)
						{
							this.ApplyType = (ApplyGEType)input.ReadEnum();
							continue;
						}
						if (num == 16U)
						{
							this.IsActive = input.ReadBool();
							continue;
						}
					}
					else
					{
						if (num == 32U)
						{
							this.ServerId = input.ReadInt32();
							continue;
						}
						if (num == 40U)
						{
							this.Handle = input.ReadInt32();
							continue;
						}
					}
				}
				else if (num <= 80U)
				{
					if (num == 48U)
					{
						this.Level = input.ReadInt32();
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
					if (num == 101U)
					{
						this.Duration = input.ReadFloat();
						continue;
					}
					if (num == 104U)
					{
						this.Id = input.ReadInt64();
						continue;
					}
					if (num == 120U)
					{
						this.StackCount = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040025C1 RID: 9665
		private UnknownFieldSet _unknownFields;

		// Token: 0x040025C2 RID: 9666
		private int _hasBits0;

		// Token: 0x040025C3 RID: 9667
		public const int HandleFieldNumber = 5;

		// Token: 0x040025C4 RID: 9668
		private int handle_;

		// Token: 0x040025C5 RID: 9669
		public const int IdFieldNumber = 13;

		// Token: 0x040025C6 RID: 9670
		private long id_;

		// Token: 0x040025C7 RID: 9671
		public const int LevelFieldNumber = 6;

		// Token: 0x040025C8 RID: 9672
		private int level_;

		// Token: 0x040025C9 RID: 9673
		public const int InstigatorIdFieldNumber = 10;

		// Token: 0x040025CA RID: 9674
		private long instigatorId_;

		// Token: 0x040025CB RID: 9675
		public const int ApplyTypeFieldNumber = 1;

		// Token: 0x040025CC RID: 9676
		private ApplyGEType applyType_;

		// Token: 0x040025CD RID: 9677
		public const int DurationFieldNumber = 12;

		// Token: 0x040025CE RID: 9678
		private static readonly float DurationDefaultValue;

		// Token: 0x040025CF RID: 9679
		private float duration_;

		// Token: 0x040025D0 RID: 9680
		public const int ServerIdFieldNumber = 4;

		// Token: 0x040025D1 RID: 9681
		private int serverId_;

		// Token: 0x040025D2 RID: 9682
		public const int StackCountFieldNumber = 15;

		// Token: 0x040025D3 RID: 9683
		private int stackCount_;

		// Token: 0x040025D4 RID: 9684
		public const int IsActiveFieldNumber = 2;

		// Token: 0x040025D5 RID: 9685
		private bool isActive_;
	}
}
