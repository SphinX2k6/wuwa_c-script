using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000134 RID: 308
	[NetMessage(EMessageId.AvoidBlockRoundInfoNotify)]
	public sealed class AvoidBlockRoundInfoNotify : IMessage<AvoidBlockRoundInfoNotify>, IMessage, IEquatable<AvoidBlockRoundInfoNotify>, IDeepCloneable<AvoidBlockRoundInfoNotify>, IBufferMessage
	{
		// Token: 0x06002879 RID: 10361 RVA: 0x0006A824 File Offset: 0x00068A24
		[NullableContext(1)]
		public static AvoidBlockRoundInfoNotify Create()
		{
			return new AvoidBlockRoundInfoNotify();
		}

		// Token: 0x170005CF RID: 1487
		// (get) Token: 0x0600287A RID: 10362 RVA: 0x0006A82B File Offset: 0x00068A2B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170005D0 RID: 1488
		// (get) Token: 0x0600287B RID: 10363 RVA: 0x0006A82E File Offset: 0x00068A2E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AvoidBlockRoundInfoNotify.Descriptor;
			}
		}

		// Token: 0x0600287C RID: 10364 RVA: 0x0006A835 File Offset: 0x00068A35
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AvoidBlockRoundInfoNotify()
		{
		}

		// Token: 0x0600287D RID: 10365 RVA: 0x0006A848 File Offset: 0x00068A48
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

		// Token: 0x0600287E RID: 10366 RVA: 0x0006A8A1 File Offset: 0x00068AA1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AvoidBlockRoundInfoNotify Clone()
		{
			return new AvoidBlockRoundInfoNotify(this);
		}

		// Token: 0x170005D1 RID: 1489
		// (get) Token: 0x0600287F RID: 10367 RVA: 0x0006A8A9 File Offset: 0x00068AA9
		// (set) Token: 0x06002880 RID: 10368 RVA: 0x0006A8B1 File Offset: 0x00068AB1
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

		// Token: 0x170005D2 RID: 1490
		// (get) Token: 0x06002881 RID: 10369 RVA: 0x0006A8BA File Offset: 0x00068ABA
		// (set) Token: 0x06002882 RID: 10370 RVA: 0x0006A8C2 File Offset: 0x00068AC2
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

		// Token: 0x170005D3 RID: 1491
		// (get) Token: 0x06002883 RID: 10371 RVA: 0x0006A8CB File Offset: 0x00068ACB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> RewardId
		{
			get
			{
				return this.rewardId_;
			}
		}

		// Token: 0x170005D4 RID: 1492
		// (get) Token: 0x06002884 RID: 10372 RVA: 0x0006A8D3 File Offset: 0x00068AD3
		// (set) Token: 0x06002885 RID: 10373 RVA: 0x0006A8DB File Offset: 0x00068ADB
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

		// Token: 0x06002886 RID: 10374 RVA: 0x0006A8E4 File Offset: 0x00068AE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AvoidBlockRoundInfoNotify);
		}

		// Token: 0x06002887 RID: 10375 RVA: 0x0006A8F4 File Offset: 0x00068AF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AvoidBlockRoundInfoNotify other)
		{
			return other != null && (other == this || (this.InstId == other.InstId && this.HistoryScore == other.HistoryScore && this.rewardId_.Equals(other.rewardId_) && this.HistoryPass == other.HistoryPass && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002888 RID: 10376 RVA: 0x0006A964 File Offset: 0x00068B64
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

		// Token: 0x06002889 RID: 10377 RVA: 0x0006A9E3 File Offset: 0x00068BE3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600288A RID: 10378 RVA: 0x0006A9F0 File Offset: 0x00068BF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600288B RID: 10379 RVA: 0x0006A9FC File Offset: 0x00068BFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.rewardId_.WriteTo(ref output, AvoidBlockRoundInfoNotify._repeated_rewardId_codec);
			if (this.HistoryPass)
			{
				output.WriteRawTag(48);
				output.WriteBool(this.HistoryPass);
			}
			if (this.InstId != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.InstId);
			}
			if (this.HistoryScore != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.HistoryScore);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600288C RID: 10380 RVA: 0x0006AA84 File Offset: 0x00068C84
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

		// Token: 0x0600288D RID: 10381 RVA: 0x0006AAFC File Offset: 0x00068CFC
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

		// Token: 0x0600288E RID: 10382 RVA: 0x0006AB71 File Offset: 0x00068D71
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600288F RID: 10383 RVA: 0x0006AB7C File Offset: 0x00068D7C
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
				if (num <= 18U)
				{
					if (num == 16U || num == 18U)
					{
						this.rewardId_.AddEntriesFrom(ref input, AvoidBlockRoundInfoNotify._repeated_rewardId_codec);
						continue;
					}
				}
				else
				{
					if (num == 48U)
					{
						this.HistoryPass = input.ReadBool();
						continue;
					}
					if (num == 56U)
					{
						this.InstId = input.ReadInt32();
						continue;
					}
					if (num == 104U)
					{
						this.HistoryScore = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040026A4 RID: 9892
		private UnknownFieldSet _unknownFields;

		// Token: 0x040026A5 RID: 9893
		public const int InstIdFieldNumber = 7;

		// Token: 0x040026A6 RID: 9894
		private int instId_;

		// Token: 0x040026A7 RID: 9895
		public const int HistoryScoreFieldNumber = 13;

		// Token: 0x040026A8 RID: 9896
		private int historyScore_;

		// Token: 0x040026A9 RID: 9897
		public const int RewardIdFieldNumber = 2;

		// Token: 0x040026AA RID: 9898
		private static readonly FieldCodec<int> _repeated_rewardId_codec = FieldCodec.ForInt32(18U);

		// Token: 0x040026AB RID: 9899
		private readonly RepeatedField<int> rewardId_ = new RepeatedField<int>();

		// Token: 0x040026AC RID: 9900
		public const int HistoryPassFieldNumber = 6;

		// Token: 0x040026AD RID: 9901
		private bool historyPass_;
	}
}
