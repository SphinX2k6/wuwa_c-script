using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020000FE RID: 254
	[NetMessage(EMessageId.ApplyBuffS2cRequestNotify)]
	public sealed class ApplyBuffS2cRequestNotify : IMessage<ApplyBuffS2cRequestNotify>, IMessage, IEquatable<ApplyBuffS2cRequestNotify>, IDeepCloneable<ApplyBuffS2cRequestNotify>, IBufferMessage
	{
		// Token: 0x060023F3 RID: 9203 RVA: 0x0005FDD2 File Offset: 0x0005DFD2
		[NullableContext(1)]
		public static ApplyBuffS2cRequestNotify Create()
		{
			return new ApplyBuffS2cRequestNotify();
		}

		// Token: 0x170004B8 RID: 1208
		// (get) Token: 0x060023F4 RID: 9204 RVA: 0x0005FDD9 File Offset: 0x0005DFD9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170004B9 RID: 1209
		// (get) Token: 0x060023F5 RID: 9205 RVA: 0x0005FDDC File Offset: 0x0005DFDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ApplyBuffS2cRequestNotify.Descriptor;
			}
		}

		// Token: 0x060023F6 RID: 9206 RVA: 0x0005FDE3 File Offset: 0x0005DFE3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ApplyBuffS2cRequestNotify()
		{
		}

		// Token: 0x060023F7 RID: 9207 RVA: 0x0005FDEC File Offset: 0x0005DFEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ApplyBuffS2cRequestNotify(ApplyBuffS2cRequestNotify other) : this()
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
			this.reason_ = other.reason_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060023F8 RID: 9208 RVA: 0x0005FE88 File Offset: 0x0005E088
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ApplyBuffS2cRequestNotify Clone()
		{
			return new ApplyBuffS2cRequestNotify(this);
		}

		// Token: 0x170004BA RID: 1210
		// (get) Token: 0x060023F9 RID: 9209 RVA: 0x0005FE90 File Offset: 0x0005E090
		// (set) Token: 0x060023FA RID: 9210 RVA: 0x0005FE98 File Offset: 0x0005E098
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

		// Token: 0x170004BB RID: 1211
		// (get) Token: 0x060023FB RID: 9211 RVA: 0x0005FEA1 File Offset: 0x0005E0A1
		// (set) Token: 0x060023FC RID: 9212 RVA: 0x0005FEA9 File Offset: 0x0005E0A9
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

		// Token: 0x170004BC RID: 1212
		// (get) Token: 0x060023FD RID: 9213 RVA: 0x0005FEB2 File Offset: 0x0005E0B2
		// (set) Token: 0x060023FE RID: 9214 RVA: 0x0005FEBA File Offset: 0x0005E0BA
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

		// Token: 0x170004BD RID: 1213
		// (get) Token: 0x060023FF RID: 9215 RVA: 0x0005FEC3 File Offset: 0x0005E0C3
		// (set) Token: 0x06002400 RID: 9216 RVA: 0x0005FECB File Offset: 0x0005E0CB
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

		// Token: 0x170004BE RID: 1214
		// (get) Token: 0x06002401 RID: 9217 RVA: 0x0005FED4 File Offset: 0x0005E0D4
		// (set) Token: 0x06002402 RID: 9218 RVA: 0x0005FEEC File Offset: 0x0005E0EC
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
				return ApplyBuffS2cRequestNotify.DurationDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.duration_ = value;
			}
		}

		// Token: 0x170004BF RID: 1215
		// (get) Token: 0x06002403 RID: 9219 RVA: 0x0005FF03 File Offset: 0x0005E103
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasDuration
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06002404 RID: 9220 RVA: 0x0005FF10 File Offset: 0x0005E110
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearDuration()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x170004C0 RID: 1216
		// (get) Token: 0x06002405 RID: 9221 RVA: 0x0005FF21 File Offset: 0x0005E121
		// (set) Token: 0x06002406 RID: 9222 RVA: 0x0005FF29 File Offset: 0x0005E129
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

		// Token: 0x170004C1 RID: 1217
		// (get) Token: 0x06002407 RID: 9223 RVA: 0x0005FF32 File Offset: 0x0005E132
		// (set) Token: 0x06002408 RID: 9224 RVA: 0x0005FF3A File Offset: 0x0005E13A
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

		// Token: 0x170004C2 RID: 1218
		// (get) Token: 0x06002409 RID: 9225 RVA: 0x0005FF43 File Offset: 0x0005E143
		// (set) Token: 0x0600240A RID: 9226 RVA: 0x0005FF4B File Offset: 0x0005E14B
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

		// Token: 0x170004C3 RID: 1219
		// (get) Token: 0x0600240B RID: 9227 RVA: 0x0005FF54 File Offset: 0x0005E154
		// (set) Token: 0x0600240C RID: 9228 RVA: 0x0005FF5C File Offset: 0x0005E15C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Reason
		{
			get
			{
				return this.reason_;
			}
			set
			{
				this.reason_ = value;
			}
		}

		// Token: 0x0600240D RID: 9229 RVA: 0x0005FF65 File Offset: 0x0005E165
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ApplyBuffS2cRequestNotify);
		}

		// Token: 0x0600240E RID: 9230 RVA: 0x0005FF74 File Offset: 0x0005E174
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ApplyBuffS2cRequestNotify other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.Level == other.Level && this.InstigatorId == other.InstigatorId && this.ApplyType == other.ApplyType && ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.Duration, other.Duration) && this.ServerId == other.ServerId && this.StackCount == other.StackCount && this.IsIterable == other.IsIterable && this.Reason == other.Reason && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600240F RID: 9231 RVA: 0x00060038 File Offset: 0x0005E238
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
			if (this.Reason != 0)
			{
				num ^= this.Reason.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06002410 RID: 9232 RVA: 0x00060148 File Offset: 0x0005E348
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06002411 RID: 9233 RVA: 0x00060155 File Offset: 0x0005E355
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002412 RID: 9234 RVA: 0x00060160 File Offset: 0x0005E360
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.InstigatorId != 0L)
			{
				output.WriteRawTag(24);
				output.WriteInt64(this.InstigatorId);
			}
			if (this.Reason != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.Reason);
			}
			if (this.Id != 0L)
			{
				output.WriteRawTag(40);
				output.WriteInt64(this.Id);
			}
			if (this.IsIterable)
			{
				output.WriteRawTag(48);
				output.WriteBool(this.IsIterable);
			}
			if (this.Level != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.Level);
			}
			if (this.HasDuration)
			{
				output.WriteRawTag(77);
				output.WriteFloat(this.Duration);
			}
			if (this.ServerId != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.ServerId);
			}
			if (this.StackCount != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.StackCount);
			}
			if (this.ApplyType != ApplyGEType.Common)
			{
				output.WriteRawTag(120);
				output.WriteEnum((int)this.ApplyType);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002413 RID: 9235 RVA: 0x00060280 File Offset: 0x0005E480
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
			if (this.Reason != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Reason);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06002414 RID: 9236 RVA: 0x00060368 File Offset: 0x0005E568
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ApplyBuffS2cRequestNotify other)
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
			if (other.Reason != 0)
			{
				this.Reason = other.Reason;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06002415 RID: 9237 RVA: 0x00060444 File Offset: 0x0005E644
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002416 RID: 9238 RVA: 0x00060450 File Offset: 0x0005E650
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
					if (num <= 32U)
					{
						if (num == 24U)
						{
							this.InstigatorId = input.ReadInt64();
							continue;
						}
						if (num == 32U)
						{
							this.Reason = input.ReadInt32();
							continue;
						}
					}
					else
					{
						if (num == 40U)
						{
							this.Id = input.ReadInt64();
							continue;
						}
						if (num == 48U)
						{
							this.IsIterable = input.ReadBool();
							continue;
						}
					}
				}
				else if (num <= 77U)
				{
					if (num == 56U)
					{
						this.Level = input.ReadInt32();
						continue;
					}
					if (num == 77U)
					{
						this.Duration = input.ReadFloat();
						continue;
					}
				}
				else
				{
					if (num == 96U)
					{
						this.ServerId = input.ReadInt32();
						continue;
					}
					if (num == 104U)
					{
						this.StackCount = input.ReadInt32();
						continue;
					}
					if (num == 120U)
					{
						this.ApplyType = (ApplyGEType)input.ReadEnum();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400256B RID: 9579
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400256C RID: 9580
		private int _hasBits0;

		// Token: 0x0400256D RID: 9581
		public const int IdFieldNumber = 5;

		// Token: 0x0400256E RID: 9582
		private long id_;

		// Token: 0x0400256F RID: 9583
		public const int LevelFieldNumber = 7;

		// Token: 0x04002570 RID: 9584
		private int level_;

		// Token: 0x04002571 RID: 9585
		public const int InstigatorIdFieldNumber = 3;

		// Token: 0x04002572 RID: 9586
		private long instigatorId_;

		// Token: 0x04002573 RID: 9587
		public const int ApplyTypeFieldNumber = 15;

		// Token: 0x04002574 RID: 9588
		private ApplyGEType applyType_;

		// Token: 0x04002575 RID: 9589
		public const int DurationFieldNumber = 9;

		// Token: 0x04002576 RID: 9590
		private static readonly float DurationDefaultValue;

		// Token: 0x04002577 RID: 9591
		private float duration_;

		// Token: 0x04002578 RID: 9592
		public const int ServerIdFieldNumber = 12;

		// Token: 0x04002579 RID: 9593
		private int serverId_;

		// Token: 0x0400257A RID: 9594
		public const int StackCountFieldNumber = 13;

		// Token: 0x0400257B RID: 9595
		private int stackCount_;

		// Token: 0x0400257C RID: 9596
		public const int IsIterableFieldNumber = 6;

		// Token: 0x0400257D RID: 9597
		private bool isIterable_;

		// Token: 0x0400257E RID: 9598
		public const int ReasonFieldNumber = 4;

		// Token: 0x0400257F RID: 9599
		private int reason_;
	}
}
