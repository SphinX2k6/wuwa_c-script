using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000137 RID: 311
	[NetMessage(EMessageId.AvoidBlockRoundInfoNotify)]
	public sealed class AvoidBlockRoundInfoNotify : IMessage<AvoidBlockRoundInfoNotify>, IMessage, IEquatable<AvoidBlockRoundInfoNotify>, IDeepCloneable<AvoidBlockRoundInfoNotify>, IBufferMessage
	{
		// Token: 0x060028F0 RID: 10480 RVA: 0x0006BC59 File Offset: 0x00069E59
		[NullableContext(1)]
		public static AvoidBlockRoundInfoNotify Create()
		{
			return new AvoidBlockRoundInfoNotify();
		}

		// Token: 0x170005E3 RID: 1507
		// (get) Token: 0x060028F1 RID: 10481 RVA: 0x0006BC60 File Offset: 0x00069E60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170005E4 RID: 1508
		// (get) Token: 0x060028F2 RID: 10482 RVA: 0x0006BC63 File Offset: 0x00069E63
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AvoidBlockRoundInfoNotify.Descriptor;
			}
		}

		// Token: 0x060028F3 RID: 10483 RVA: 0x0006BC6A File Offset: 0x00069E6A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AvoidBlockRoundInfoNotify()
		{
		}

		// Token: 0x060028F4 RID: 10484 RVA: 0x0006BC80 File Offset: 0x00069E80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AvoidBlockRoundInfoNotify(AvoidBlockRoundInfoNotify other) : this()
		{
			this.instId_ = other.instId_;
			this.historyScore_ = other.historyScore_;
			this.rewardId_ = other.rewardId_.Clone();
			this.historyPass_ = other.historyPass_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060028F5 RID: 10485 RVA: 0x0006BCD9 File Offset: 0x00069ED9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AvoidBlockRoundInfoNotify Clone()
		{
			return new AvoidBlockRoundInfoNotify(this);
		}

		// Token: 0x170005E5 RID: 1509
		// (get) Token: 0x060028F6 RID: 10486 RVA: 0x0006BCE1 File Offset: 0x00069EE1
		// (set) Token: 0x060028F7 RID: 10487 RVA: 0x0006BCE9 File Offset: 0x00069EE9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int InstId
		{
			get
			{
				return this.instId_;
			}
			set
			{
				this.instId_ = value;
			}
		}

		// Token: 0x170005E6 RID: 1510
		// (get) Token: 0x060028F8 RID: 10488 RVA: 0x0006BCF2 File Offset: 0x00069EF2
		// (set) Token: 0x060028F9 RID: 10489 RVA: 0x0006BCFA File Offset: 0x00069EFA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int HistoryScore
		{
			get
			{
				return this.historyScore_;
			}
			set
			{
				this.historyScore_ = value;
			}
		}

		// Token: 0x170005E7 RID: 1511
		// (get) Token: 0x060028FA RID: 10490 RVA: 0x0006BD03 File Offset: 0x00069F03
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> RewardId
		{
			get
			{
				return this.rewardId_;
			}
		}

		// Token: 0x170005E8 RID: 1512
		// (get) Token: 0x060028FB RID: 10491 RVA: 0x0006BD0B File Offset: 0x00069F0B
		// (set) Token: 0x060028FC RID: 10492 RVA: 0x0006BD13 File Offset: 0x00069F13
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HistoryPass
		{
			get
			{
				return this.historyPass_;
			}
			set
			{
				this.historyPass_ = value;
			}
		}

		// Token: 0x060028FD RID: 10493 RVA: 0x0006BD1C File Offset: 0x00069F1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AvoidBlockRoundInfoNotify);
		}

		// Token: 0x060028FE RID: 10494 RVA: 0x0006BD2C File Offset: 0x00069F2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AvoidBlockRoundInfoNotify other)
		{
			return other != null && (other == this || (this.InstId == other.InstId && this.HistoryScore == other.HistoryScore && this.rewardId_.Equals(other.rewardId_) && this.HistoryPass == other.HistoryPass && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060028FF RID: 10495 RVA: 0x0006BD9C File Offset: 0x00069F9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.InstId != 0)
			{
				num ^= this.InstId.GetHashCode();
			}
			if (this.HistoryScore != 0)
			{
				num ^= this.HistoryScore.GetHashCode();
			}
			num ^= this.rewardId_.GetHashCode();
			if (this.HistoryPass)
			{
				num ^= this.HistoryPass.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06002900 RID: 10496 RVA: 0x0006BE1B File Offset: 0x0006A01B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06002901 RID: 10497 RVA: 0x0006BE28 File Offset: 0x0006A028
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002902 RID: 10498 RVA: 0x0006BE34 File Offset: 0x0006A034
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.rewardId_.WriteTo(ref output, AvoidBlockRoundInfoNotify._repeated_rewardId_codec);
			if (this.InstId != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.InstId);
			}
			if (this.HistoryPass)
			{
				output.WriteRawTag(104);
				output.WriteBool(this.HistoryPass);
			}
			if (this.HistoryScore != 0)
			{
				output.WriteRawTag(120);
				output.WriteInt32(this.HistoryScore);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002903 RID: 10499 RVA: 0x0006BEBC File Offset: 0x0006A0BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.InstId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.InstId);
			}
			if (this.HistoryScore != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.HistoryScore);
			}
			num += this.rewardId_.CalculateSize(AvoidBlockRoundInfoNotify._repeated_rewardId_codec);
			if (this.HistoryPass)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06002904 RID: 10500 RVA: 0x0006BF34 File Offset: 0x0006A134
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AvoidBlockRoundInfoNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.InstId != 0)
			{
				this.InstId = other.InstId;
			}
			if (other.HistoryScore != 0)
			{
				this.HistoryScore = other.HistoryScore;
			}
			this.rewardId_.Add(other.rewardId_);
			if (other.HistoryPass)
			{
				this.HistoryPass = other.HistoryPass;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06002905 RID: 10501 RVA: 0x0006BFA9 File Offset: 0x0006A1A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002906 RID: 10502 RVA: 0x0006BFB4 File Offset: 0x0006A1B4
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
				if (num <= 10U)
				{
					if (num == 8U || num == 10U)
					{
						this.rewardId_.AddEntriesFrom(ref input, AvoidBlockRoundInfoNotify._repeated_rewardId_codec);
						continue;
					}
				}
				else
				{
					if (num == 64U)
					{
						this.InstId = input.ReadInt32();
						continue;
					}
					if (num == 104U)
					{
						this.HistoryPass = input.ReadBool();
						continue;
					}
					if (num == 120U)
					{
						this.HistoryScore = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04002718 RID: 10008
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002719 RID: 10009
		public const int InstIdFieldNumber = 8;

		// Token: 0x0400271A RID: 10010
		private int instId_;

		// Token: 0x0400271B RID: 10011
		public const int HistoryScoreFieldNumber = 15;

		// Token: 0x0400271C RID: 10012
		private int historyScore_;

		// Token: 0x0400271D RID: 10013
		public const int RewardIdFieldNumber = 1;

		// Token: 0x0400271E RID: 10014
		private static readonly FieldCodec<int> _repeated_rewardId_codec = FieldCodec.ForInt32(10U);

		// Token: 0x0400271F RID: 10015
		private readonly RepeatedField<int> rewardId_ = new RepeatedField<int>();

		// Token: 0x04002720 RID: 10016
		public const int HistoryPassFieldNumber = 13;

		// Token: 0x04002721 RID: 10017
		private bool historyPass_;
	}
}
