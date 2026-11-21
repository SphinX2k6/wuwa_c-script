using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200030C RID: 780
	public sealed class CorniceLevelPlayEnrty : IMessage<CorniceLevelPlayEnrty>, IMessage, IEquatable<CorniceLevelPlayEnrty>, IDeepCloneable<CorniceLevelPlayEnrty>, IBufferMessage
	{
		// Token: 0x06004EDE RID: 20190 RVA: 0x000BFC89 File Offset: 0x000BDE89
		[NullableContext(1)]
		public static CorniceLevelPlayEnrty Create()
		{
			return new CorniceLevelPlayEnrty();
		}

		// Token: 0x17000DFE RID: 3582
		// (get) Token: 0x06004EDF RID: 20191 RVA: 0x000BFC90 File Offset: 0x000BDE90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<CorniceLevelPlayEnrty> Parser
		{
			get
			{
				return CorniceLevelPlayEnrty._parser;
			}
		}

		// Token: 0x17000DFF RID: 3583
		// (get) Token: 0x06004EE0 RID: 20192 RVA: 0x000BFC97 File Offset: 0x000BDE97
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000E00 RID: 3584
		// (get) Token: 0x06004EE1 RID: 20193 RVA: 0x000BFC9A File Offset: 0x000BDE9A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CorniceLevelPlayEnrty.Descriptor;
			}
		}

		// Token: 0x06004EE2 RID: 20194 RVA: 0x000BFCA1 File Offset: 0x000BDEA1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CorniceLevelPlayEnrty()
		{
		}

		// Token: 0x06004EE3 RID: 20195 RVA: 0x000BFCB4 File Offset: 0x000BDEB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CorniceLevelPlayEnrty(CorniceLevelPlayEnrty other) : this()
		{
			this.maxScore_ = other.maxScore_;
			this.remainingTime_ = other.remainingTime_;
			this.unlockTime_ = other.unlockTime_;
			this.getRewardScoreIndexList_ = other.getRewardScoreIndexList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004EE4 RID: 20196 RVA: 0x000BFD0D File Offset: 0x000BDF0D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CorniceLevelPlayEnrty Clone()
		{
			return new CorniceLevelPlayEnrty(this);
		}

		// Token: 0x17000E01 RID: 3585
		// (get) Token: 0x06004EE5 RID: 20197 RVA: 0x000BFD15 File Offset: 0x000BDF15
		// (set) Token: 0x06004EE6 RID: 20198 RVA: 0x000BFD1D File Offset: 0x000BDF1D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int MaxScore
		{
			get
			{
				return this.maxScore_;
			}
			set
			{
				this.maxScore_ = value;
			}
		}

		// Token: 0x17000E02 RID: 3586
		// (get) Token: 0x06004EE7 RID: 20199 RVA: 0x000BFD26 File Offset: 0x000BDF26
		// (set) Token: 0x06004EE8 RID: 20200 RVA: 0x000BFD2E File Offset: 0x000BDF2E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RemainingTime
		{
			get
			{
				return this.remainingTime_;
			}
			set
			{
				this.remainingTime_ = value;
			}
		}

		// Token: 0x17000E03 RID: 3587
		// (get) Token: 0x06004EE9 RID: 20201 RVA: 0x000BFD37 File Offset: 0x000BDF37
		// (set) Token: 0x06004EEA RID: 20202 RVA: 0x000BFD3F File Offset: 0x000BDF3F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long UnlockTime
		{
			get
			{
				return this.unlockTime_;
			}
			set
			{
				this.unlockTime_ = value;
			}
		}

		// Token: 0x17000E04 RID: 3588
		// (get) Token: 0x06004EEB RID: 20203 RVA: 0x000BFD48 File Offset: 0x000BDF48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> GetRewardScoreIndexList
		{
			get
			{
				return this.getRewardScoreIndexList_;
			}
		}

		// Token: 0x06004EEC RID: 20204 RVA: 0x000BFD50 File Offset: 0x000BDF50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CorniceLevelPlayEnrty);
		}

		// Token: 0x06004EED RID: 20205 RVA: 0x000BFD60 File Offset: 0x000BDF60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CorniceLevelPlayEnrty other)
		{
			return other != null && (other == this || (this.MaxScore == other.MaxScore && this.RemainingTime == other.RemainingTime && this.UnlockTime == other.UnlockTime && this.getRewardScoreIndexList_.Equals(other.getRewardScoreIndexList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004EEE RID: 20206 RVA: 0x000BFDD0 File Offset: 0x000BDFD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.MaxScore != 0)
			{
				num ^= this.MaxScore.GetHashCode();
			}
			if (this.RemainingTime != 0)
			{
				num ^= this.RemainingTime.GetHashCode();
			}
			if (this.UnlockTime != 0L)
			{
				num ^= this.UnlockTime.GetHashCode();
			}
			num ^= this.getRewardScoreIndexList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06004EEF RID: 20207 RVA: 0x000BFE4F File Offset: 0x000BE04F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06004EF0 RID: 20208 RVA: 0x000BFE5C File Offset: 0x000BE05C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004EF1 RID: 20209 RVA: 0x000BFE68 File Offset: 0x000BE068
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.MaxScore != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.MaxScore);
			}
			if (this.RemainingTime != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.RemainingTime);
			}
			if (this.UnlockTime != 0L)
			{
				output.WriteRawTag(24);
				output.WriteInt64(this.UnlockTime);
			}
			this.getRewardScoreIndexList_.WriteTo(ref output, CorniceLevelPlayEnrty._repeated_getRewardScoreIndexList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004EF2 RID: 20210 RVA: 0x000BFEF0 File Offset: 0x000BE0F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.MaxScore != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.MaxScore);
			}
			if (this.RemainingTime != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RemainingTime);
			}
			if (this.UnlockTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.UnlockTime);
			}
			num += this.getRewardScoreIndexList_.CalculateSize(CorniceLevelPlayEnrty._repeated_getRewardScoreIndexList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06004EF3 RID: 20211 RVA: 0x000BFF74 File Offset: 0x000BE174
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CorniceLevelPlayEnrty other)
		{
			if (other == null)
			{
				return;
			}
			if (other.MaxScore != 0)
			{
				this.MaxScore = other.MaxScore;
			}
			if (other.RemainingTime != 0)
			{
				this.RemainingTime = other.RemainingTime;
			}
			if (other.UnlockTime != 0L)
			{
				this.UnlockTime = other.UnlockTime;
			}
			this.getRewardScoreIndexList_.Add(other.getRewardScoreIndexList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06004EF4 RID: 20212 RVA: 0x000BFFE9 File Offset: 0x000BE1E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004EF5 RID: 20213 RVA: 0x000BFFF4 File Offset: 0x000BE1F4
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
				if (num <= 16U)
				{
					if (num == 8U)
					{
						this.MaxScore = input.ReadInt32();
						continue;
					}
					if (num == 16U)
					{
						this.RemainingTime = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 24U)
					{
						this.UnlockTime = input.ReadInt64();
						continue;
					}
					if (num == 32U || num == 34U)
					{
						this.getRewardScoreIndexList_.AddEntriesFrom(ref input, CorniceLevelPlayEnrty._repeated_getRewardScoreIndexList_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400320C RID: 12812
		private static readonly MessageParser<CorniceLevelPlayEnrty> _parser = new MessageParser<CorniceLevelPlayEnrty>(() => new CorniceLevelPlayEnrty());

		// Token: 0x0400320D RID: 12813
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400320E RID: 12814
		public const int MaxScoreFieldNumber = 1;

		// Token: 0x0400320F RID: 12815
		private int maxScore_;

		// Token: 0x04003210 RID: 12816
		public const int RemainingTimeFieldNumber = 2;

		// Token: 0x04003211 RID: 12817
		private int remainingTime_;

		// Token: 0x04003212 RID: 12818
		public const int UnlockTimeFieldNumber = 3;

		// Token: 0x04003213 RID: 12819
		private long unlockTime_;

		// Token: 0x04003214 RID: 12820
		public const int GetRewardScoreIndexListFieldNumber = 4;

		// Token: 0x04003215 RID: 12821
		private static readonly FieldCodec<int> _repeated_getRewardScoreIndexList_codec = FieldCodec.ForInt32(34U);

		// Token: 0x04003216 RID: 12822
		private readonly RepeatedField<int> getRewardScoreIndexList_ = new RepeatedField<int>();
	}
}
