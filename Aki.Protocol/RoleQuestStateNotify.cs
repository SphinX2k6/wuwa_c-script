using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020010A5 RID: 4261
	[NetMessage(EMessageId.RoleQuestStateNotify)]
	public sealed class RoleQuestStateNotify : IMessage<RoleQuestStateNotify>, IMessage, IEquatable<RoleQuestStateNotify>, IDeepCloneable<RoleQuestStateNotify>, IBufferMessage
	{
		// Token: 0x06016C10 RID: 93200 RVA: 0x0034E6DB File Offset: 0x0034C8DB
		[NullableContext(1)]
		public static RoleQuestStateNotify Create()
		{
			return new RoleQuestStateNotify();
		}

		// Token: 0x17004C3B RID: 19515
		// (get) Token: 0x06016C11 RID: 93201 RVA: 0x0034E6E2 File Offset: 0x0034C8E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004C3C RID: 19516
		// (get) Token: 0x06016C12 RID: 93202 RVA: 0x0034E6E5 File Offset: 0x0034C8E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleQuestStateNotify.Descriptor;
			}
		}

		// Token: 0x06016C13 RID: 93203 RVA: 0x0034E6EC File Offset: 0x0034C8EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleQuestStateNotify()
		{
		}

		// Token: 0x06016C14 RID: 93204 RVA: 0x0034E718 File Offset: 0x0034C918
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

		// Token: 0x06016C15 RID: 93205 RVA: 0x0034E793 File Offset: 0x0034C993
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleQuestStateNotify Clone()
		{
			return new RoleQuestStateNotify(this);
		}

		// Token: 0x17004C3D RID: 19517
		// (get) Token: 0x06016C16 RID: 93206 RVA: 0x0034E79B File Offset: 0x0034C99B
		// (set) Token: 0x06016C17 RID: 93207 RVA: 0x0034E7A3 File Offset: 0x0034C9A3
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

		// Token: 0x17004C3E RID: 19518
		// (get) Token: 0x06016C18 RID: 93208 RVA: 0x0034E7AC File Offset: 0x0034C9AC
		// (set) Token: 0x06016C19 RID: 93209 RVA: 0x0034E7B4 File Offset: 0x0034C9B4
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

		// Token: 0x17004C3F RID: 19519
		// (get) Token: 0x06016C1A RID: 93210 RVA: 0x0034E7BD File Offset: 0x0034C9BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> InProgress
		{
			get
			{
				return this.inProgress_;
			}
		}

		// Token: 0x17004C40 RID: 19520
		// (get) Token: 0x06016C1B RID: 93211 RVA: 0x0034E7C5 File Offset: 0x0034C9C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> Unlock
		{
			get
			{
				return this.unlock_;
			}
		}

		// Token: 0x17004C41 RID: 19521
		// (get) Token: 0x06016C1C RID: 93212 RVA: 0x0034E7CD File Offset: 0x0034C9CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> Over
		{
			get
			{
				return this.over_;
			}
		}

		// Token: 0x17004C42 RID: 19522
		// (get) Token: 0x06016C1D RID: 93213 RVA: 0x0034E7D5 File Offset: 0x0034C9D5
		// (set) Token: 0x06016C1E RID: 93214 RVA: 0x0034E7DD File Offset: 0x0034C9DD
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

		// Token: 0x06016C1F RID: 93215 RVA: 0x0034E7E6 File Offset: 0x0034C9E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleQuestStateNotify);
		}

		// Token: 0x06016C20 RID: 93216 RVA: 0x0034E7F4 File Offset: 0x0034C9F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleQuestStateNotify other)
		{
			return other != null && (other == this || (this.UnlockPoint == other.UnlockPoint && this.MaxUnlockPoint == other.MaxUnlockPoint && this.inProgress_.Equals(other.inProgress_) && this.unlock_.Equals(other.unlock_) && this.over_.Equals(other.over_) && this.LastAddPointTime == other.LastAddPointTime && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06016C21 RID: 93217 RVA: 0x0034E88C File Offset: 0x0034CA8C
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

		// Token: 0x06016C22 RID: 93218 RVA: 0x0034E927 File Offset: 0x0034CB27
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06016C23 RID: 93219 RVA: 0x0034E934 File Offset: 0x0034CB34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06016C24 RID: 93220 RVA: 0x0034E940 File Offset: 0x0034CB40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.MaxUnlockPoint != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.MaxUnlockPoint);
			}
			if (this.UnlockPoint != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.UnlockPoint);
			}
			if (this.LastAddPointTime != 0L)
			{
				output.WriteRawTag(48);
				output.WriteInt64(this.LastAddPointTime);
			}
			this.over_.WriteTo(ref output, RoleQuestStateNotify._repeated_over_codec);
			this.unlock_.WriteTo(ref output, RoleQuestStateNotify._repeated_unlock_codec);
			this.inProgress_.WriteTo(ref output, RoleQuestStateNotify._repeated_inProgress_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06016C25 RID: 93221 RVA: 0x0034E9E8 File Offset: 0x0034CBE8
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

		// Token: 0x06016C26 RID: 93222 RVA: 0x0034EA90 File Offset: 0x0034CC90
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

		// Token: 0x06016C27 RID: 93223 RVA: 0x0034EB27 File Offset: 0x0034CD27
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06016C28 RID: 93224 RVA: 0x0034EB30 File Offset: 0x0034CD30
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
				if (num > 56U)
				{
					if (num <= 96U)
					{
						if (num == 58U)
						{
							goto IL_8C;
						}
						if (num != 96U)
						{
							goto IL_4E;
						}
					}
					else if (num != 98U)
					{
						if (num != 104U && num != 106U)
						{
							goto IL_4E;
						}
						this.inProgress_.AddEntriesFrom(ref input, RoleQuestStateNotify._repeated_inProgress_codec);
						continue;
					}
					this.unlock_.AddEntriesFrom(ref input, RoleQuestStateNotify._repeated_unlock_codec);
					continue;
				}
				if (num <= 32U)
				{
					if (num == 24U)
					{
						this.MaxUnlockPoint = input.ReadInt32();
						continue;
					}
					if (num == 32U)
					{
						this.UnlockPoint = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 48U)
					{
						this.LastAddPointTime = input.ReadInt64();
						continue;
					}
					if (num == 56U)
					{
						goto IL_8C;
					}
				}
				IL_4E:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				continue;
				IL_8C:
				this.over_.AddEntriesFrom(ref input, RoleQuestStateNotify._repeated_over_codec);
			}
		}

		// Token: 0x040087DC RID: 34780
		private UnknownFieldSet _unknownFields;

		// Token: 0x040087DD RID: 34781
		public const int UnlockPointFieldNumber = 4;

		// Token: 0x040087DE RID: 34782
		private int unlockPoint_;

		// Token: 0x040087DF RID: 34783
		public const int MaxUnlockPointFieldNumber = 3;

		// Token: 0x040087E0 RID: 34784
		private int maxUnlockPoint_;

		// Token: 0x040087E1 RID: 34785
		public const int InProgressFieldNumber = 13;

		// Token: 0x040087E2 RID: 34786
		private static readonly FieldCodec<int> _repeated_inProgress_codec = FieldCodec.ForInt32(106U);

		// Token: 0x040087E3 RID: 34787
		private readonly RepeatedField<int> inProgress_ = new RepeatedField<int>();

		// Token: 0x040087E4 RID: 34788
		public const int UnlockFieldNumber = 12;

		// Token: 0x040087E5 RID: 34789
		private static readonly FieldCodec<int> _repeated_unlock_codec = FieldCodec.ForInt32(98U);

		// Token: 0x040087E6 RID: 34790
		private readonly RepeatedField<int> unlock_ = new RepeatedField<int>();

		// Token: 0x040087E7 RID: 34791
		public const int OverFieldNumber = 7;

		// Token: 0x040087E8 RID: 34792
		private static readonly FieldCodec<int> _repeated_over_codec = FieldCodec.ForInt32(58U);

		// Token: 0x040087E9 RID: 34793
		private readonly RepeatedField<int> over_ = new RepeatedField<int>();

		// Token: 0x040087EA RID: 34794
		public const int LastAddPointTimeFieldNumber = 6;

		// Token: 0x040087EB RID: 34795
		private long lastAddPointTime_;
	}
}
