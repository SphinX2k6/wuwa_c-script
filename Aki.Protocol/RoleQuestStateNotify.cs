using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001095 RID: 4245
	[NetMessage(EMessageId.RoleQuestStateNotify)]
	public sealed class RoleQuestStateNotify : IMessage<RoleQuestStateNotify>, IMessage, IEquatable<RoleQuestStateNotify>, IDeepCloneable<RoleQuestStateNotify>, IBufferMessage
	{
		// Token: 0x06016B2B RID: 92971 RVA: 0x0034CFFF File Offset: 0x0034B1FF
		[NullableContext(1)]
		public static RoleQuestStateNotify Create()
		{
			return new RoleQuestStateNotify();
		}

		// Token: 0x17004C11 RID: 19473
		// (get) Token: 0x06016B2C RID: 92972 RVA: 0x0034D006 File Offset: 0x0034B206
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004C12 RID: 19474
		// (get) Token: 0x06016B2D RID: 92973 RVA: 0x0034D009 File Offset: 0x0034B209
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleQuestStateNotify.Descriptor;
			}
		}

		// Token: 0x06016B2E RID: 92974 RVA: 0x0034D010 File Offset: 0x0034B210
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleQuestStateNotify()
		{
		}

		// Token: 0x06016B2F RID: 92975 RVA: 0x0034D03C File Offset: 0x0034B23C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleQuestStateNotify(RoleQuestStateNotify other) : this()
		{
			this.unlockPoint_ = other.unlockPoint_;
			this.maxUnlockPoint_ = other.maxUnlockPoint_;
			this.inProgress_ = other.inProgress_.Clone();
			this.unlock_ = other.unlock_.Clone();
			this.over_ = other.over_.Clone();
			this.lastAddPointTime_ = other.lastAddPointTime_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06016B30 RID: 92976 RVA: 0x0034D0B7 File Offset: 0x0034B2B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleQuestStateNotify Clone()
		{
			return new RoleQuestStateNotify(this);
		}

		// Token: 0x17004C13 RID: 19475
		// (get) Token: 0x06016B31 RID: 92977 RVA: 0x0034D0BF File Offset: 0x0034B2BF
		// (set) Token: 0x06016B32 RID: 92978 RVA: 0x0034D0C7 File Offset: 0x0034B2C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int UnlockPoint
		{
			get
			{
				return this.unlockPoint_;
			}
			set
			{
				this.unlockPoint_ = value;
			}
		}

		// Token: 0x17004C14 RID: 19476
		// (get) Token: 0x06016B33 RID: 92979 RVA: 0x0034D0D0 File Offset: 0x0034B2D0
		// (set) Token: 0x06016B34 RID: 92980 RVA: 0x0034D0D8 File Offset: 0x0034B2D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int MaxUnlockPoint
		{
			get
			{
				return this.maxUnlockPoint_;
			}
			set
			{
				this.maxUnlockPoint_ = value;
			}
		}

		// Token: 0x17004C15 RID: 19477
		// (get) Token: 0x06016B35 RID: 92981 RVA: 0x0034D0E1 File Offset: 0x0034B2E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> InProgress
		{
			get
			{
				return this.inProgress_;
			}
		}

		// Token: 0x17004C16 RID: 19478
		// (get) Token: 0x06016B36 RID: 92982 RVA: 0x0034D0E9 File Offset: 0x0034B2E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> Unlock
		{
			get
			{
				return this.unlock_;
			}
		}

		// Token: 0x17004C17 RID: 19479
		// (get) Token: 0x06016B37 RID: 92983 RVA: 0x0034D0F1 File Offset: 0x0034B2F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> Over
		{
			get
			{
				return this.over_;
			}
		}

		// Token: 0x17004C18 RID: 19480
		// (get) Token: 0x06016B38 RID: 92984 RVA: 0x0034D0F9 File Offset: 0x0034B2F9
		// (set) Token: 0x06016B39 RID: 92985 RVA: 0x0034D101 File Offset: 0x0034B301
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long LastAddPointTime
		{
			get
			{
				return this.lastAddPointTime_;
			}
			set
			{
				this.lastAddPointTime_ = value;
			}
		}

		// Token: 0x06016B3A RID: 92986 RVA: 0x0034D10A File Offset: 0x0034B30A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleQuestStateNotify);
		}

		// Token: 0x06016B3B RID: 92987 RVA: 0x0034D118 File Offset: 0x0034B318
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleQuestStateNotify other)
		{
			return other != null && (other == this || (this.UnlockPoint == other.UnlockPoint && this.MaxUnlockPoint == other.MaxUnlockPoint && this.inProgress_.Equals(other.inProgress_) && this.unlock_.Equals(other.unlock_) && this.over_.Equals(other.over_) && this.LastAddPointTime == other.LastAddPointTime && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06016B3C RID: 92988 RVA: 0x0034D1B0 File Offset: 0x0034B3B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.UnlockPoint != 0)
			{
				num ^= this.UnlockPoint.GetHashCode();
			}
			if (this.MaxUnlockPoint != 0)
			{
				num ^= this.MaxUnlockPoint.GetHashCode();
			}
			num ^= this.inProgress_.GetHashCode();
			num ^= this.unlock_.GetHashCode();
			num ^= this.over_.GetHashCode();
			if (this.LastAddPointTime != 0L)
			{
				num ^= this.LastAddPointTime.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06016B3D RID: 92989 RVA: 0x0034D24B File Offset: 0x0034B44B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06016B3E RID: 92990 RVA: 0x0034D258 File Offset: 0x0034B458
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06016B3F RID: 92991 RVA: 0x0034D264 File Offset: 0x0034B464
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.unlock_.WriteTo(ref output, RoleQuestStateNotify._repeated_unlock_codec);
			this.inProgress_.WriteTo(ref output, RoleQuestStateNotify._repeated_inProgress_codec);
			if (this.UnlockPoint != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.UnlockPoint);
			}
			if (this.MaxUnlockPoint != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.MaxUnlockPoint);
			}
			if (this.LastAddPointTime != 0L)
			{
				output.WriteRawTag(80);
				output.WriteInt64(this.LastAddPointTime);
			}
			this.over_.WriteTo(ref output, RoleQuestStateNotify._repeated_over_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06016B40 RID: 92992 RVA: 0x0034D30C File Offset: 0x0034B50C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.UnlockPoint != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.UnlockPoint);
			}
			if (this.MaxUnlockPoint != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.MaxUnlockPoint);
			}
			num += this.inProgress_.CalculateSize(RoleQuestStateNotify._repeated_inProgress_codec);
			num += this.unlock_.CalculateSize(RoleQuestStateNotify._repeated_unlock_codec);
			num += this.over_.CalculateSize(RoleQuestStateNotify._repeated_over_codec);
			if (this.LastAddPointTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.LastAddPointTime);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06016B41 RID: 92993 RVA: 0x0034D3B4 File Offset: 0x0034B5B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoleQuestStateNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.UnlockPoint != 0)
			{
				this.UnlockPoint = other.UnlockPoint;
			}
			if (other.MaxUnlockPoint != 0)
			{
				this.MaxUnlockPoint = other.MaxUnlockPoint;
			}
			this.inProgress_.Add(other.inProgress_);
			this.unlock_.Add(other.unlock_);
			this.over_.Add(other.over_);
			if (other.LastAddPointTime != 0L)
			{
				this.LastAddPointTime = other.LastAddPointTime;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06016B42 RID: 92994 RVA: 0x0034D44B File Offset: 0x0034B64B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06016B43 RID: 92995 RVA: 0x0034D454 File Offset: 0x0034B654
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
				if (num <= 26U)
				{
					if (num <= 10U)
					{
						if (num == 8U || num == 10U)
						{
							this.unlock_.AddEntriesFrom(ref input, RoleQuestStateNotify._repeated_unlock_codec);
							continue;
						}
					}
					else if (num == 24U || num == 26U)
					{
						this.inProgress_.AddEntriesFrom(ref input, RoleQuestStateNotify._repeated_inProgress_codec);
						continue;
					}
				}
				else if (num <= 48U)
				{
					if (num == 32U)
					{
						this.UnlockPoint = input.ReadInt32();
						continue;
					}
					if (num == 48U)
					{
						this.MaxUnlockPoint = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 80U)
					{
						this.LastAddPointTime = input.ReadInt64();
						continue;
					}
					if (num == 112U || num == 114U)
					{
						this.over_.AddEntriesFrom(ref input, RoleQuestStateNotify._repeated_over_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04008806 RID: 34822
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008807 RID: 34823
		public const int UnlockPointFieldNumber = 4;

		// Token: 0x04008808 RID: 34824
		private int unlockPoint_;

		// Token: 0x04008809 RID: 34825
		public const int MaxUnlockPointFieldNumber = 6;

		// Token: 0x0400880A RID: 34826
		private int maxUnlockPoint_;

		// Token: 0x0400880B RID: 34827
		public const int InProgressFieldNumber = 3;

		// Token: 0x0400880C RID: 34828
		private static readonly FieldCodec<int> _repeated_inProgress_codec = FieldCodec.ForInt32(26U);

		// Token: 0x0400880D RID: 34829
		private readonly RepeatedField<int> inProgress_ = new RepeatedField<int>();

		// Token: 0x0400880E RID: 34830
		public const int UnlockFieldNumber = 1;

		// Token: 0x0400880F RID: 34831
		private static readonly FieldCodec<int> _repeated_unlock_codec = FieldCodec.ForInt32(10U);

		// Token: 0x04008810 RID: 34832
		private readonly RepeatedField<int> unlock_ = new RepeatedField<int>();

		// Token: 0x04008811 RID: 34833
		public const int OverFieldNumber = 14;

		// Token: 0x04008812 RID: 34834
		private static readonly FieldCodec<int> _repeated_over_codec = FieldCodec.ForInt32(114U);

		// Token: 0x04008813 RID: 34835
		private readonly RepeatedField<int> over_ = new RepeatedField<int>();

		// Token: 0x04008814 RID: 34836
		public const int LastAddPointTimeFieldNumber = 10;

		// Token: 0x04008815 RID: 34837
		private long lastAddPointTime_;
	}
}
