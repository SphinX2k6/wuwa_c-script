using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000209 RID: 521
	[NetMessage(EMessageId.BuffStackCountPush)]
	public sealed class BuffStackCountPush : IMessage<BuffStackCountPush>, IMessage, IEquatable<BuffStackCountPush>, IDeepCloneable<BuffStackCountPush>, IBufferMessage
	{
		// Token: 0x0600397D RID: 14717 RVA: 0x0008F62E File Offset: 0x0008D82E
		[NullableContext(1)]
		public static BuffStackCountPush Create()
		{
			return new BuffStackCountPush();
		}

		// Token: 0x17000967 RID: 2407
		// (get) Token: 0x0600397E RID: 14718 RVA: 0x0008F635 File Offset: 0x0008D835
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000968 RID: 2408
		// (get) Token: 0x0600397F RID: 14719 RVA: 0x0008F638 File Offset: 0x0008D838
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BuffStackCountPush.Descriptor;
			}
		}

		// Token: 0x06003980 RID: 14720 RVA: 0x0008F63F File Offset: 0x0008D83F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BuffStackCountPush()
		{
		}

		// Token: 0x06003981 RID: 14721 RVA: 0x0008F654 File Offset: 0x0008D854
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BuffStackCountPush(BuffStackCountPush other) : this()
		{
			this.handleId_ = other.handleId_;
			this.newStackCount_ = other.newStackCount_;
			this.isPrematureRemoval_ = other.isPrematureRemoval_;
			this.instigatorId_ = other.instigatorId_;
			this.notRefreshDuration_ = other.notRefreshDuration_;
			this.notRefreshPeriod_ = other.notRefreshPeriod_;
			this.duration_ = other.duration_;
			this.reason_ = other.reason_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003982 RID: 14722 RVA: 0x0008F6D8 File Offset: 0x0008D8D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BuffStackCountPush Clone()
		{
			return new BuffStackCountPush(this);
		}

		// Token: 0x17000969 RID: 2409
		// (get) Token: 0x06003983 RID: 14723 RVA: 0x0008F6E0 File Offset: 0x0008D8E0
		// (set) Token: 0x06003984 RID: 14724 RVA: 0x0008F6E8 File Offset: 0x0008D8E8
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

		// Token: 0x1700096A RID: 2410
		// (get) Token: 0x06003985 RID: 14725 RVA: 0x0008F6F1 File Offset: 0x0008D8F1
		// (set) Token: 0x06003986 RID: 14726 RVA: 0x0008F6F9 File Offset: 0x0008D8F9
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

		// Token: 0x1700096B RID: 2411
		// (get) Token: 0x06003987 RID: 14727 RVA: 0x0008F702 File Offset: 0x0008D902
		// (set) Token: 0x06003988 RID: 14728 RVA: 0x0008F70A File Offset: 0x0008D90A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsPrematureRemoval
		{
			get
			{
				return this.isPrematureRemoval_;
			}
			set
			{
				this.isPrematureRemoval_ = value;
			}
		}

		// Token: 0x1700096C RID: 2412
		// (get) Token: 0x06003989 RID: 14729 RVA: 0x0008F713 File Offset: 0x0008D913
		// (set) Token: 0x0600398A RID: 14730 RVA: 0x0008F71B File Offset: 0x0008D91B
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

		// Token: 0x1700096D RID: 2413
		// (get) Token: 0x0600398B RID: 14731 RVA: 0x0008F724 File Offset: 0x0008D924
		// (set) Token: 0x0600398C RID: 14732 RVA: 0x0008F72C File Offset: 0x0008D92C
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

		// Token: 0x1700096E RID: 2414
		// (get) Token: 0x0600398D RID: 14733 RVA: 0x0008F735 File Offset: 0x0008D935
		// (set) Token: 0x0600398E RID: 14734 RVA: 0x0008F73D File Offset: 0x0008D93D
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

		// Token: 0x1700096F RID: 2415
		// (get) Token: 0x0600398F RID: 14735 RVA: 0x0008F746 File Offset: 0x0008D946
		// (set) Token: 0x06003990 RID: 14736 RVA: 0x0008F74E File Offset: 0x0008D94E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public float Duration
		{
			get
			{
				return this.duration_;
			}
			set
			{
				this.duration_ = value;
			}
		}

		// Token: 0x17000970 RID: 2416
		// (get) Token: 0x06003991 RID: 14737 RVA: 0x0008F757 File Offset: 0x0008D957
		// (set) Token: 0x06003992 RID: 14738 RVA: 0x0008F75F File Offset: 0x0008D95F
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

		// Token: 0x06003993 RID: 14739 RVA: 0x0008F772 File Offset: 0x0008D972
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BuffStackCountPush);
		}

		// Token: 0x06003994 RID: 14740 RVA: 0x0008F780 File Offset: 0x0008D980
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BuffStackCountPush other)
		{
			return other != null && (other == this || (this.HandleId == other.HandleId && this.NewStackCount == other.NewStackCount && this.IsPrematureRemoval == other.IsPrematureRemoval && this.InstigatorId == other.InstigatorId && this.NotRefreshDuration == other.NotRefreshDuration && this.NotRefreshPeriod == other.NotRefreshPeriod && ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.Duration, other.Duration) && !(this.Reason != other.Reason) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003995 RID: 14741 RVA: 0x0008F838 File Offset: 0x0008DA38
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
			if (this.IsPrematureRemoval)
			{
				num ^= this.IsPrematureRemoval.GetHashCode();
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
			if (this.Duration != 0f)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.Duration);
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

		// Token: 0x06003996 RID: 14742 RVA: 0x0008F92F File Offset: 0x0008DB2F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06003997 RID: 14743 RVA: 0x0008F93C File Offset: 0x0008DB3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003998 RID: 14744 RVA: 0x0008F948 File Offset: 0x0008DB48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.HandleId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.HandleId);
			}
			if (this.Reason.Length != 0)
			{
				output.WriteRawTag(26);
				output.WriteString(this.Reason);
			}
			if (this.NotRefreshDuration)
			{
				output.WriteRawTag(32);
				output.WriteBool(this.NotRefreshDuration);
			}
			if (this.NotRefreshPeriod)
			{
				output.WriteRawTag(40);
				output.WriteBool(this.NotRefreshPeriod);
			}
			if (this.IsPrematureRemoval)
			{
				output.WriteRawTag(64);
				output.WriteBool(this.IsPrematureRemoval);
			}
			if (this.InstigatorId != 0L)
			{
				output.WriteRawTag(96);
				output.WriteInt64(this.InstigatorId);
			}
			if (this.Duration != 0f)
			{
				output.WriteRawTag(109);
				output.WriteFloat(this.Duration);
			}
			if (this.NewStackCount != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.NewStackCount);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003999 RID: 14745 RVA: 0x0008FA54 File Offset: 0x0008DC54
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
			if (this.IsPrematureRemoval)
			{
				num += 2;
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
			if (this.Duration != 0f)
			{
				num += 5;
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

		// Token: 0x0600399A RID: 14746 RVA: 0x0008FB14 File Offset: 0x0008DD14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BuffStackCountPush other)
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
			if (other.IsPrematureRemoval)
			{
				this.IsPrematureRemoval = other.IsPrematureRemoval;
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
			if (other.Duration != 0f)
			{
				this.Duration = other.Duration;
			}
			if (other.Reason.Length != 0)
			{
				this.Reason = other.Reason;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600399B RID: 14747 RVA: 0x0008FBE6 File Offset: 0x0008DDE6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600399C RID: 14748 RVA: 0x0008FBF0 File Offset: 0x0008DDF0
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
					if (num <= 26U)
					{
						if (num == 16U)
						{
							this.HandleId = input.ReadInt32();
							continue;
						}
						if (num == 26U)
						{
							this.Reason = input.ReadString();
							continue;
						}
					}
					else
					{
						if (num == 32U)
						{
							this.NotRefreshDuration = input.ReadBool();
							continue;
						}
						if (num == 40U)
						{
							this.NotRefreshPeriod = input.ReadBool();
							continue;
						}
					}
				}
				else if (num <= 96U)
				{
					if (num == 64U)
					{
						this.IsPrematureRemoval = input.ReadBool();
						continue;
					}
					if (num == 96U)
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
					if (num == 112U)
					{
						this.NewStackCount = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04002B88 RID: 11144
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002B89 RID: 11145
		public const int HandleIdFieldNumber = 2;

		// Token: 0x04002B8A RID: 11146
		private int handleId_;

		// Token: 0x04002B8B RID: 11147
		public const int NewStackCountFieldNumber = 14;

		// Token: 0x04002B8C RID: 11148
		private int newStackCount_;

		// Token: 0x04002B8D RID: 11149
		public const int IsPrematureRemovalFieldNumber = 8;

		// Token: 0x04002B8E RID: 11150
		private bool isPrematureRemoval_;

		// Token: 0x04002B8F RID: 11151
		public const int InstigatorIdFieldNumber = 12;

		// Token: 0x04002B90 RID: 11152
		private long instigatorId_;

		// Token: 0x04002B91 RID: 11153
		public const int NotRefreshDurationFieldNumber = 4;

		// Token: 0x04002B92 RID: 11154
		private bool notRefreshDuration_;

		// Token: 0x04002B93 RID: 11155
		public const int NotRefreshPeriodFieldNumber = 5;

		// Token: 0x04002B94 RID: 11156
		private bool notRefreshPeriod_;

		// Token: 0x04002B95 RID: 11157
		public const int DurationFieldNumber = 13;

		// Token: 0x04002B96 RID: 11158
		private float duration_;

		// Token: 0x04002B97 RID: 11159
		public const int ReasonFieldNumber = 3;

		// Token: 0x04002B98 RID: 11160
		private string reason_ = "";
	}
}
