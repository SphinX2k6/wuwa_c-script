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
		// Token: 0x060023BC RID: 9148 RVA: 0x0005F303 File Offset: 0x0005D503
		[NullableContext(1)]
		public static ApplyBuffS2cRequestNotify Create()
		{
			return new ApplyBuffS2cRequestNotify();
		}

		// Token: 0x170004B2 RID: 1202
		// (get) Token: 0x060023BD RID: 9149 RVA: 0x0005F30A File Offset: 0x0005D50A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170004B3 RID: 1203
		// (get) Token: 0x060023BE RID: 9150 RVA: 0x0005F30D File Offset: 0x0005D50D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ApplyBuffS2cRequestNotify.Descriptor;
			}
		}

		// Token: 0x060023BF RID: 9151 RVA: 0x0005F314 File Offset: 0x0005D514
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ApplyBuffS2cRequestNotify()
		{
		}

		// Token: 0x060023C0 RID: 9152 RVA: 0x0005F31C File Offset: 0x0005D51C
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

		// Token: 0x060023C1 RID: 9153 RVA: 0x0005F3B8 File Offset: 0x0005D5B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ApplyBuffS2cRequestNotify Clone()
		{
			return new ApplyBuffS2cRequestNotify(this);
		}

		// Token: 0x170004B4 RID: 1204
		// (get) Token: 0x060023C2 RID: 9154 RVA: 0x0005F3C0 File Offset: 0x0005D5C0
		// (set) Token: 0x060023C3 RID: 9155 RVA: 0x0005F3C8 File Offset: 0x0005D5C8
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

		// Token: 0x170004B5 RID: 1205
		// (get) Token: 0x060023C4 RID: 9156 RVA: 0x0005F3D1 File Offset: 0x0005D5D1
		// (set) Token: 0x060023C5 RID: 9157 RVA: 0x0005F3D9 File Offset: 0x0005D5D9
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

		// Token: 0x170004B6 RID: 1206
		// (get) Token: 0x060023C6 RID: 9158 RVA: 0x0005F3E2 File Offset: 0x0005D5E2
		// (set) Token: 0x060023C7 RID: 9159 RVA: 0x0005F3EA File Offset: 0x0005D5EA
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

		// Token: 0x170004B7 RID: 1207
		// (get) Token: 0x060023C8 RID: 9160 RVA: 0x0005F3F3 File Offset: 0x0005D5F3
		// (set) Token: 0x060023C9 RID: 9161 RVA: 0x0005F3FB File Offset: 0x0005D5FB
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

		// Token: 0x170004B8 RID: 1208
		// (get) Token: 0x060023CA RID: 9162 RVA: 0x0005F404 File Offset: 0x0005D604
		// (set) Token: 0x060023CB RID: 9163 RVA: 0x0005F41C File Offset: 0x0005D61C
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

		// Token: 0x170004B9 RID: 1209
		// (get) Token: 0x060023CC RID: 9164 RVA: 0x0005F433 File Offset: 0x0005D633
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasDuration
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x060023CD RID: 9165 RVA: 0x0005F440 File Offset: 0x0005D640
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearDuration()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x170004BA RID: 1210
		// (get) Token: 0x060023CE RID: 9166 RVA: 0x0005F451 File Offset: 0x0005D651
		// (set) Token: 0x060023CF RID: 9167 RVA: 0x0005F459 File Offset: 0x0005D659
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

		// Token: 0x170004BB RID: 1211
		// (get) Token: 0x060023D0 RID: 9168 RVA: 0x0005F462 File Offset: 0x0005D662
		// (set) Token: 0x060023D1 RID: 9169 RVA: 0x0005F46A File Offset: 0x0005D66A
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

		// Token: 0x170004BC RID: 1212
		// (get) Token: 0x060023D2 RID: 9170 RVA: 0x0005F473 File Offset: 0x0005D673
		// (set) Token: 0x060023D3 RID: 9171 RVA: 0x0005F47B File Offset: 0x0005D67B
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

		// Token: 0x170004BD RID: 1213
		// (get) Token: 0x060023D4 RID: 9172 RVA: 0x0005F484 File Offset: 0x0005D684
		// (set) Token: 0x060023D5 RID: 9173 RVA: 0x0005F48C File Offset: 0x0005D68C
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

		// Token: 0x060023D6 RID: 9174 RVA: 0x0005F495 File Offset: 0x0005D695
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ApplyBuffS2cRequestNotify);
		}

		// Token: 0x060023D7 RID: 9175 RVA: 0x0005F4A4 File Offset: 0x0005D6A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ApplyBuffS2cRequestNotify other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.Level == other.Level && this.InstigatorId == other.InstigatorId && this.ApplyType == other.ApplyType && ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.Duration, other.Duration) && this.ServerId == other.ServerId && this.StackCount == other.StackCount && this.IsIterable == other.IsIterable && this.Reason == other.Reason && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060023D8 RID: 9176 RVA: 0x0005F568 File Offset: 0x0005D768
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

		// Token: 0x060023D9 RID: 9177 RVA: 0x0005F678 File Offset: 0x0005D878
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060023DA RID: 9178 RVA: 0x0005F685 File Offset: 0x0005D885
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060023DB RID: 9179 RVA: 0x0005F690 File Offset: 0x0005D890
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.IsIterable)
			{
				output.WriteRawTag(8);
				output.WriteBool(this.IsIterable);
			}
			if (this.HasDuration)
			{
				output.WriteRawTag(29);
				output.WriteFloat(this.Duration);
			}
			if (this.Id != 0L)
			{
				output.WriteRawTag(32);
				output.WriteInt64(this.Id);
			}
			if (this.ApplyType != ApplyGEType.Common)
			{
				output.WriteRawTag(40);
				output.WriteEnum((int)this.ApplyType);
			}
			if (this.Level != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.Level);
			}
			if (this.Reason != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.Reason);
			}
			if (this.ServerId != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.ServerId);
			}
			if (this.StackCount != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.StackCount);
			}
			if (this.InstigatorId != 0L)
			{
				output.WriteRawTag(120);
				output.WriteInt64(this.InstigatorId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060023DC RID: 9180 RVA: 0x0005F7AC File Offset: 0x0005D9AC
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

		// Token: 0x060023DD RID: 9181 RVA: 0x0005F894 File Offset: 0x0005DA94
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

		// Token: 0x060023DE RID: 9182 RVA: 0x0005F970 File Offset: 0x0005DB70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060023DF RID: 9183 RVA: 0x0005F97C File Offset: 0x0005DB7C
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
					if (num <= 29U)
					{
						if (num == 8U)
						{
							this.IsIterable = input.ReadBool();
							continue;
						}
						if (num == 29U)
						{
							this.Duration = input.ReadFloat();
							continue;
						}
					}
					else
					{
						if (num == 32U)
						{
							this.Id = input.ReadInt64();
							continue;
						}
						if (num == 40U)
						{
							this.ApplyType = (ApplyGEType)input.ReadEnum();
							continue;
						}
					}
				}
				else if (num <= 72U)
				{
					if (num == 64U)
					{
						this.Level = input.ReadInt32();
						continue;
					}
					if (num == 72U)
					{
						this.Reason = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 80U)
					{
						this.ServerId = input.ReadInt32();
						continue;
					}
					if (num == 88U)
					{
						this.StackCount = input.ReadInt32();
						continue;
					}
					if (num == 120U)
					{
						this.InstigatorId = input.ReadInt64();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400250C RID: 9484
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400250D RID: 9485
		private int _hasBits0;

		// Token: 0x0400250E RID: 9486
		public const int IdFieldNumber = 4;

		// Token: 0x0400250F RID: 9487
		private long id_;

		// Token: 0x04002510 RID: 9488
		public const int LevelFieldNumber = 8;

		// Token: 0x04002511 RID: 9489
		private int level_;

		// Token: 0x04002512 RID: 9490
		public const int InstigatorIdFieldNumber = 15;

		// Token: 0x04002513 RID: 9491
		private long instigatorId_;

		// Token: 0x04002514 RID: 9492
		public const int ApplyTypeFieldNumber = 5;

		// Token: 0x04002515 RID: 9493
		private ApplyGEType applyType_;

		// Token: 0x04002516 RID: 9494
		public const int DurationFieldNumber = 3;

		// Token: 0x04002517 RID: 9495
		private static readonly float DurationDefaultValue;

		// Token: 0x04002518 RID: 9496
		private float duration_;

		// Token: 0x04002519 RID: 9497
		public const int ServerIdFieldNumber = 10;

		// Token: 0x0400251A RID: 9498
		private int serverId_;

		// Token: 0x0400251B RID: 9499
		public const int StackCountFieldNumber = 11;

		// Token: 0x0400251C RID: 9500
		private int stackCount_;

		// Token: 0x0400251D RID: 9501
		public const int IsIterableFieldNumber = 1;

		// Token: 0x0400251E RID: 9502
		private bool isIterable_;

		// Token: 0x0400251F RID: 9503
		public const int ReasonFieldNumber = 9;

		// Token: 0x04002520 RID: 9504
		private int reason_;
	}
}
