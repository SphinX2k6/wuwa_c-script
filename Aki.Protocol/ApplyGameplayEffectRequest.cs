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
		// Token: 0x0600245E RID: 9310 RVA: 0x00061314 File Offset: 0x0005F514
		[NullableContext(1)]
		public static ApplyGameplayEffectRequest Create()
		{
			return new ApplyGameplayEffectRequest();
		}

		// Token: 0x170004E5 RID: 1253
		// (get) Token: 0x0600245F RID: 9311 RVA: 0x0006131B File Offset: 0x0005F51B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170004E6 RID: 1254
		// (get) Token: 0x06002460 RID: 9312 RVA: 0x0006131E File Offset: 0x0005F51E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ApplyGameplayEffectRequest.Descriptor;
			}
		}

		// Token: 0x06002461 RID: 9313 RVA: 0x00061325 File Offset: 0x0005F525
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ApplyGameplayEffectRequest()
		{
		}

		// Token: 0x06002462 RID: 9314 RVA: 0x00061330 File Offset: 0x0005F530
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

		// Token: 0x06002463 RID: 9315 RVA: 0x000613CC File Offset: 0x0005F5CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ApplyGameplayEffectRequest Clone()
		{
			return new ApplyGameplayEffectRequest(this);
		}

		// Token: 0x170004E7 RID: 1255
		// (get) Token: 0x06002464 RID: 9316 RVA: 0x000613D4 File Offset: 0x0005F5D4
		// (set) Token: 0x06002465 RID: 9317 RVA: 0x000613DC File Offset: 0x0005F5DC
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

		// Token: 0x170004E8 RID: 1256
		// (get) Token: 0x06002466 RID: 9318 RVA: 0x000613E5 File Offset: 0x0005F5E5
		// (set) Token: 0x06002467 RID: 9319 RVA: 0x000613ED File Offset: 0x0005F5ED
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

		// Token: 0x170004E9 RID: 1257
		// (get) Token: 0x06002468 RID: 9320 RVA: 0x000613F6 File Offset: 0x0005F5F6
		// (set) Token: 0x06002469 RID: 9321 RVA: 0x000613FE File Offset: 0x0005F5FE
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

		// Token: 0x170004EA RID: 1258
		// (get) Token: 0x0600246A RID: 9322 RVA: 0x00061407 File Offset: 0x0005F607
		// (set) Token: 0x0600246B RID: 9323 RVA: 0x0006140F File Offset: 0x0005F60F
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

		// Token: 0x170004EB RID: 1259
		// (get) Token: 0x0600246C RID: 9324 RVA: 0x00061418 File Offset: 0x0005F618
		// (set) Token: 0x0600246D RID: 9325 RVA: 0x00061420 File Offset: 0x0005F620
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

		// Token: 0x170004EC RID: 1260
		// (get) Token: 0x0600246E RID: 9326 RVA: 0x00061429 File Offset: 0x0005F629
		// (set) Token: 0x0600246F RID: 9327 RVA: 0x00061441 File Offset: 0x0005F641
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

		// Token: 0x170004ED RID: 1261
		// (get) Token: 0x06002470 RID: 9328 RVA: 0x00061458 File Offset: 0x0005F658
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasDuration
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06002471 RID: 9329 RVA: 0x00061465 File Offset: 0x0005F665
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearDuration()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x170004EE RID: 1262
		// (get) Token: 0x06002472 RID: 9330 RVA: 0x00061476 File Offset: 0x0005F676
		// (set) Token: 0x06002473 RID: 9331 RVA: 0x0006147E File Offset: 0x0005F67E
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

		// Token: 0x170004EF RID: 1263
		// (get) Token: 0x06002474 RID: 9332 RVA: 0x00061487 File Offset: 0x0005F687
		// (set) Token: 0x06002475 RID: 9333 RVA: 0x0006148F File Offset: 0x0005F68F
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

		// Token: 0x170004F0 RID: 1264
		// (get) Token: 0x06002476 RID: 9334 RVA: 0x00061498 File Offset: 0x0005F698
		// (set) Token: 0x06002477 RID: 9335 RVA: 0x000614A0 File Offset: 0x0005F6A0
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

		// Token: 0x06002478 RID: 9336 RVA: 0x000614A9 File Offset: 0x0005F6A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ApplyGameplayEffectRequest);
		}

		// Token: 0x06002479 RID: 9337 RVA: 0x000614B8 File Offset: 0x0005F6B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ApplyGameplayEffectRequest other)
		{
			return other != null && (other == this || (this.Handle == other.Handle && this.Id == other.Id && this.Level == other.Level && this.InstigatorId == other.InstigatorId && this.ApplyType == other.ApplyType && ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.Duration, other.Duration) && this.ServerId == other.ServerId && this.StackCount == other.StackCount && this.IsActive == other.IsActive && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600247A RID: 9338 RVA: 0x0006157C File Offset: 0x0005F77C
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

		// Token: 0x0600247B RID: 9339 RVA: 0x0006168C File Offset: 0x0005F88C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600247C RID: 9340 RVA: 0x00061699 File Offset: 0x0005F899
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600247D RID: 9341 RVA: 0x000616A4 File Offset: 0x0005F8A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.HasDuration)
			{
				output.WriteRawTag(21);
				output.WriteFloat(this.Duration);
			}
			if (this.StackCount != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.StackCount);
			}
			if (this.Level != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.Level);
			}
			if (this.InstigatorId != 0L)
			{
				output.WriteRawTag(40);
				output.WriteInt64(this.InstigatorId);
			}
			if (this.Id != 0L)
			{
				output.WriteRawTag(56);
				output.WriteInt64(this.Id);
			}
			if (this.ApplyType != ApplyGEType.Common)
			{
				output.WriteRawTag(80);
				output.WriteEnum((int)this.ApplyType);
			}
			if (this.ServerId != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.ServerId);
			}
			if (this.Handle != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.Handle);
			}
			if (this.IsActive)
			{
				output.WriteRawTag(120);
				output.WriteBool(this.IsActive);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600247E RID: 9342 RVA: 0x000617C4 File Offset: 0x0005F9C4
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

		// Token: 0x0600247F RID: 9343 RVA: 0x000618AC File Offset: 0x0005FAAC
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

		// Token: 0x06002480 RID: 9344 RVA: 0x00061988 File Offset: 0x0005FB88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002481 RID: 9345 RVA: 0x00061994 File Offset: 0x0005FB94
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
					if (num <= 24U)
					{
						if (num == 21U)
						{
							this.Duration = input.ReadFloat();
							continue;
						}
						if (num == 24U)
						{
							this.StackCount = input.ReadInt32();
							continue;
						}
					}
					else
					{
						if (num == 32U)
						{
							this.Level = input.ReadInt32();
							continue;
						}
						if (num == 40U)
						{
							this.InstigatorId = input.ReadInt64();
							continue;
						}
					}
				}
				else if (num <= 80U)
				{
					if (num == 56U)
					{
						this.Id = input.ReadInt64();
						continue;
					}
					if (num == 80U)
					{
						this.ApplyType = (ApplyGEType)input.ReadEnum();
						continue;
					}
				}
				else
				{
					if (num == 88U)
					{
						this.ServerId = input.ReadInt32();
						continue;
					}
					if (num == 112U)
					{
						this.Handle = input.ReadInt32();
						continue;
					}
					if (num == 120U)
					{
						this.IsActive = input.ReadBool();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04002562 RID: 9570
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002563 RID: 9571
		private int _hasBits0;

		// Token: 0x04002564 RID: 9572
		public const int HandleFieldNumber = 14;

		// Token: 0x04002565 RID: 9573
		private int handle_;

		// Token: 0x04002566 RID: 9574
		public const int IdFieldNumber = 7;

		// Token: 0x04002567 RID: 9575
		private long id_;

		// Token: 0x04002568 RID: 9576
		public const int LevelFieldNumber = 4;

		// Token: 0x04002569 RID: 9577
		private int level_;

		// Token: 0x0400256A RID: 9578
		public const int InstigatorIdFieldNumber = 5;

		// Token: 0x0400256B RID: 9579
		private long instigatorId_;

		// Token: 0x0400256C RID: 9580
		public const int ApplyTypeFieldNumber = 10;

		// Token: 0x0400256D RID: 9581
		private ApplyGEType applyType_;

		// Token: 0x0400256E RID: 9582
		public const int DurationFieldNumber = 2;

		// Token: 0x0400256F RID: 9583
		private static readonly float DurationDefaultValue;

		// Token: 0x04002570 RID: 9584
		private float duration_;

		// Token: 0x04002571 RID: 9585
		public const int ServerIdFieldNumber = 11;

		// Token: 0x04002572 RID: 9586
		private int serverId_;

		// Token: 0x04002573 RID: 9587
		public const int StackCountFieldNumber = 3;

		// Token: 0x04002574 RID: 9588
		private int stackCount_;

		// Token: 0x04002575 RID: 9589
		public const int IsActiveFieldNumber = 15;

		// Token: 0x04002576 RID: 9590
		private bool isActive_;
	}
}
