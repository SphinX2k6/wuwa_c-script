using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200020D RID: 525
	[NetMessage(EMessageId.BuffStackCountNotify)]
	public sealed class BuffStackCountNotify : IMessage<BuffStackCountNotify>, IMessage, IEquatable<BuffStackCountNotify>, IDeepCloneable<BuffStackCountNotify>, IBufferMessage
	{
		// Token: 0x06003A00 RID: 14848 RVA: 0x00090BEA File Offset: 0x0008EDEA
		[NullableContext(1)]
		public static BuffStackCountNotify Create()
		{
			return new BuffStackCountNotify();
		}

		// Token: 0x1700097B RID: 2427
		// (get) Token: 0x06003A01 RID: 14849 RVA: 0x00090BF1 File Offset: 0x0008EDF1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700097C RID: 2428
		// (get) Token: 0x06003A02 RID: 14850 RVA: 0x00090BF4 File Offset: 0x0008EDF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BuffStackCountNotify.Descriptor;
			}
		}

		// Token: 0x06003A03 RID: 14851 RVA: 0x00090BFB File Offset: 0x0008EDFB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BuffStackCountNotify()
		{
		}

		// Token: 0x06003A04 RID: 14852 RVA: 0x00090C04 File Offset: 0x0008EE04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BuffStackCountNotify(BuffStackCountNotify other) : this()
		{
			this._hasBits0 = other._hasBits0;
			this.handleId_ = other.handleId_;
			this.newStackCount_ = other.newStackCount_;
			this.duration_ = other.duration_;
			this.leftDuration_ = other.leftDuration_;
			this.instigatorId_ = other.instigatorId_;
			this.notRefreshDuration_ = other.notRefreshDuration_;
			this.notRefreshPeriod_ = other.notRefreshPeriod_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003A05 RID: 14853 RVA: 0x00090C88 File Offset: 0x0008EE88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BuffStackCountNotify Clone()
		{
			return new BuffStackCountNotify(this);
		}

		// Token: 0x1700097D RID: 2429
		// (get) Token: 0x06003A06 RID: 14854 RVA: 0x00090C90 File Offset: 0x0008EE90
		// (set) Token: 0x06003A07 RID: 14855 RVA: 0x00090C98 File Offset: 0x0008EE98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int HandleId
		{
			get
			{
				return this.handleId_;
			}
			set
			{
				this.handleId_ = value;
			}
		}

		// Token: 0x1700097E RID: 2430
		// (get) Token: 0x06003A08 RID: 14856 RVA: 0x00090CA1 File Offset: 0x0008EEA1
		// (set) Token: 0x06003A09 RID: 14857 RVA: 0x00090CA9 File Offset: 0x0008EEA9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int NewStackCount
		{
			get
			{
				return this.newStackCount_;
			}
			set
			{
				this.newStackCount_ = value;
			}
		}

		// Token: 0x1700097F RID: 2431
		// (get) Token: 0x06003A0A RID: 14858 RVA: 0x00090CB2 File Offset: 0x0008EEB2
		// (set) Token: 0x06003A0B RID: 14859 RVA: 0x00090CCA File Offset: 0x0008EECA
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
				return BuffStackCountNotify.DurationDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.duration_ = value;
			}
		}

		// Token: 0x17000980 RID: 2432
		// (get) Token: 0x06003A0C RID: 14860 RVA: 0x00090CE1 File Offset: 0x0008EEE1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasDuration
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06003A0D RID: 14861 RVA: 0x00090CEE File Offset: 0x0008EEEE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearDuration()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x17000981 RID: 2433
		// (get) Token: 0x06003A0E RID: 14862 RVA: 0x00090CFF File Offset: 0x0008EEFF
		// (set) Token: 0x06003A0F RID: 14863 RVA: 0x00090D17 File Offset: 0x0008EF17
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
				return BuffStackCountNotify.LeftDurationDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.leftDuration_ = value;
			}
		}

		// Token: 0x17000982 RID: 2434
		// (get) Token: 0x06003A10 RID: 14864 RVA: 0x00090D2E File Offset: 0x0008EF2E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasLeftDuration
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06003A11 RID: 14865 RVA: 0x00090D3B File Offset: 0x0008EF3B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearLeftDuration()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17000983 RID: 2435
		// (get) Token: 0x06003A12 RID: 14866 RVA: 0x00090D4C File Offset: 0x0008EF4C
		// (set) Token: 0x06003A13 RID: 14867 RVA: 0x00090D54 File Offset: 0x0008EF54
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

		// Token: 0x17000984 RID: 2436
		// (get) Token: 0x06003A14 RID: 14868 RVA: 0x00090D5D File Offset: 0x0008EF5D
		// (set) Token: 0x06003A15 RID: 14869 RVA: 0x00090D65 File Offset: 0x0008EF65
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool NotRefreshDuration
		{
			get
			{
				return this.notRefreshDuration_;
			}
			set
			{
				this.notRefreshDuration_ = value;
			}
		}

		// Token: 0x17000985 RID: 2437
		// (get) Token: 0x06003A16 RID: 14870 RVA: 0x00090D6E File Offset: 0x0008EF6E
		// (set) Token: 0x06003A17 RID: 14871 RVA: 0x00090D76 File Offset: 0x0008EF76
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool NotRefreshPeriod
		{
			get
			{
				return this.notRefreshPeriod_;
			}
			set
			{
				this.notRefreshPeriod_ = value;
			}
		}

		// Token: 0x06003A18 RID: 14872 RVA: 0x00090D7F File Offset: 0x0008EF7F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BuffStackCountNotify);
		}

		// Token: 0x06003A19 RID: 14873 RVA: 0x00090D90 File Offset: 0x0008EF90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BuffStackCountNotify other)
		{
			return other != null && (other == this || (this.HandleId == other.HandleId && this.NewStackCount == other.NewStackCount && ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.Duration, other.Duration) && ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.LeftDuration, other.LeftDuration) && this.InstigatorId == other.InstigatorId && this.NotRefreshDuration == other.NotRefreshDuration && this.NotRefreshPeriod == other.NotRefreshPeriod && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003A1A RID: 14874 RVA: 0x00090E40 File Offset: 0x0008F040
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.HandleId != 0)
			{
				num ^= this.HandleId.GetHashCode();
			}
			if (this.NewStackCount != 0)
			{
				num ^= this.NewStackCount.GetHashCode();
			}
			if (this.HasDuration)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.Duration);
			}
			if (this.HasLeftDuration)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.LeftDuration);
			}
			if (this.InstigatorId != 0L)
			{
				num ^= this.InstigatorId.GetHashCode();
			}
			if (this.NotRefreshDuration)
			{
				num ^= this.NotRefreshDuration.GetHashCode();
			}
			if (this.NotRefreshPeriod)
			{
				num ^= this.NotRefreshPeriod.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06003A1B RID: 14875 RVA: 0x00090F19 File Offset: 0x0008F119
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06003A1C RID: 14876 RVA: 0x00090F26 File Offset: 0x0008F126
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003A1D RID: 14877 RVA: 0x00090F30 File Offset: 0x0008F130
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.HasLeftDuration)
			{
				output.WriteRawTag(21);
				output.WriteFloat(this.LeftDuration);
			}
			if (this.HandleId != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.HandleId);
			}
			if (this.NewStackCount != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.NewStackCount);
			}
			if (this.NotRefreshDuration)
			{
				output.WriteRawTag(56);
				output.WriteBool(this.NotRefreshDuration);
			}
			if (this.InstigatorId != 0L)
			{
				output.WriteRawTag(80);
				output.WriteInt64(this.InstigatorId);
			}
			if (this.HasDuration)
			{
				output.WriteRawTag(109);
				output.WriteFloat(this.Duration);
			}
			if (this.NotRefreshPeriod)
			{
				output.WriteRawTag(120);
				output.WriteBool(this.NotRefreshPeriod);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003A1E RID: 14878 RVA: 0x00091018 File Offset: 0x0008F218
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.HandleId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.HandleId);
			}
			if (this.NewStackCount != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.NewStackCount);
			}
			if (this.HasDuration)
			{
				num += 5;
			}
			if (this.HasLeftDuration)
			{
				num += 5;
			}
			if (this.InstigatorId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.InstigatorId);
			}
			if (this.NotRefreshDuration)
			{
				num += 2;
			}
			if (this.NotRefreshPeriod)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06003A1F RID: 14879 RVA: 0x000910B8 File Offset: 0x0008F2B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BuffStackCountNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.HandleId != 0)
			{
				this.HandleId = other.HandleId;
			}
			if (other.NewStackCount != 0)
			{
				this.NewStackCount = other.NewStackCount;
			}
			if (other.HasDuration)
			{
				this.Duration = other.Duration;
			}
			if (other.HasLeftDuration)
			{
				this.LeftDuration = other.LeftDuration;
			}
			if (other.InstigatorId != 0L)
			{
				this.InstigatorId = other.InstigatorId;
			}
			if (other.NotRefreshDuration)
			{
				this.NotRefreshDuration = other.NotRefreshDuration;
			}
			if (other.NotRefreshPeriod)
			{
				this.NotRefreshPeriod = other.NotRefreshPeriod;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06003A20 RID: 14880 RVA: 0x0009116C File Offset: 0x0008F36C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003A21 RID: 14881 RVA: 0x00091178 File Offset: 0x0008F378
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
					if (num == 21U)
					{
						this.LeftDuration = input.ReadFloat();
						continue;
					}
					if (num == 40U)
					{
						this.HandleId = input.ReadInt32();
						continue;
					}
					if (num == 48U)
					{
						this.NewStackCount = input.ReadInt32();
						continue;
					}
				}
				else if (num <= 80U)
				{
					if (num == 56U)
					{
						this.NotRefreshDuration = input.ReadBool();
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
					if (num == 109U)
					{
						this.Duration = input.ReadFloat();
						continue;
					}
					if (num == 120U)
					{
						this.NotRefreshPeriod = input.ReadBool();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04002BF8 RID: 11256
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002BF9 RID: 11257
		private int _hasBits0;

		// Token: 0x04002BFA RID: 11258
		public const int HandleIdFieldNumber = 5;

		// Token: 0x04002BFB RID: 11259
		private int handleId_;

		// Token: 0x04002BFC RID: 11260
		public const int NewStackCountFieldNumber = 6;

		// Token: 0x04002BFD RID: 11261
		private int newStackCount_;

		// Token: 0x04002BFE RID: 11262
		public const int DurationFieldNumber = 13;

		// Token: 0x04002BFF RID: 11263
		private static readonly float DurationDefaultValue;

		// Token: 0x04002C00 RID: 11264
		private float duration_;

		// Token: 0x04002C01 RID: 11265
		public const int LeftDurationFieldNumber = 2;

		// Token: 0x04002C02 RID: 11266
		private static readonly float LeftDurationDefaultValue;

		// Token: 0x04002C03 RID: 11267
		private float leftDuration_;

		// Token: 0x04002C04 RID: 11268
		public const int InstigatorIdFieldNumber = 10;

		// Token: 0x04002C05 RID: 11269
		private long instigatorId_;

		// Token: 0x04002C06 RID: 11270
		public const int NotRefreshDurationFieldNumber = 7;

		// Token: 0x04002C07 RID: 11271
		private bool notRefreshDuration_;

		// Token: 0x04002C08 RID: 11272
		public const int NotRefreshPeriodFieldNumber = 15;

		// Token: 0x04002C09 RID: 11273
		private bool notRefreshPeriod_;
	}
}
