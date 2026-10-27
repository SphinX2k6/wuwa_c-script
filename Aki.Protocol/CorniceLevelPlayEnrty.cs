using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000305 RID: 773
	public sealed class CorniceLevelPlayEnrty : IMessage<CorniceLevelPlayEnrty>, IMessage, IEquatable<CorniceLevelPlayEnrty>, IDeepCloneable<CorniceLevelPlayEnrty>, IBufferMessage
	{
		// Token: 0x06004E05 RID: 19973 RVA: 0x000BD89D File Offset: 0x000BBA9D
		[NullableContext(1)]
		public static CorniceLevelPlayEnrty Create()
		{
			return new CorniceLevelPlayEnrty();
		}

		// Token: 0x17000DD1 RID: 3537
		// (get) Token: 0x06004E06 RID: 19974 RVA: 0x000BD8A4 File Offset: 0x000BBAA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<CorniceLevelPlayEnrty> Parser
		{
			get
			{
				return CorniceLevelPlayEnrty._parser;
			}
		}

		// Token: 0x17000DD2 RID: 3538
		// (get) Token: 0x06004E07 RID: 19975 RVA: 0x000BD8AB File Offset: 0x000BBAAB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000DD3 RID: 3539
		// (get) Token: 0x06004E08 RID: 19976 RVA: 0x000BD8AE File Offset: 0x000BBAAE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CorniceLevelPlayEnrty.Descriptor;
			}
		}

		// Token: 0x06004E09 RID: 19977 RVA: 0x000BD8B5 File Offset: 0x000BBAB5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CorniceLevelPlayEnrty()
		{
		}

		// Token: 0x06004E0A RID: 19978 RVA: 0x000BD8C8 File Offset: 0x000BBAC8
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

		// Token: 0x06004E0B RID: 19979 RVA: 0x000BD921 File Offset: 0x000BBB21
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CorniceLevelPlayEnrty Clone()
		{
			return new CorniceLevelPlayEnrty(this);
		}

		// Token: 0x17000DD4 RID: 3540
		// (get) Token: 0x06004E0C RID: 19980 RVA: 0x000BD929 File Offset: 0x000BBB29
		// (set) Token: 0x06004E0D RID: 19981 RVA: 0x000BD931 File Offset: 0x000BBB31
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

		// Token: 0x17000DD5 RID: 3541
		// (get) Token: 0x06004E0E RID: 19982 RVA: 0x000BD93A File Offset: 0x000BBB3A
		// (set) Token: 0x06004E0F RID: 19983 RVA: 0x000BD942 File Offset: 0x000BBB42
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

		// Token: 0x17000DD6 RID: 3542
		// (get) Token: 0x06004E10 RID: 19984 RVA: 0x000BD94B File Offset: 0x000BBB4B
		// (set) Token: 0x06004E11 RID: 19985 RVA: 0x000BD953 File Offset: 0x000BBB53
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

		// Token: 0x17000DD7 RID: 3543
		// (get) Token: 0x06004E12 RID: 19986 RVA: 0x000BD95C File Offset: 0x000BBB5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> GetRewardScoreIndexList
		{
			get
			{
				return this.getRewardScoreIndexList_;
			}
		}

		// Token: 0x06004E13 RID: 19987 RVA: 0x000BD964 File Offset: 0x000BBB64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CorniceLevelPlayEnrty);
		}

		// Token: 0x06004E14 RID: 19988 RVA: 0x000BD974 File Offset: 0x000BBB74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CorniceLevelPlayEnrty other)
		{
			return other != null && (other == this || (this.MaxScore == other.MaxScore && this.RemainingTime == other.RemainingTime && this.UnlockTime == other.UnlockTime && this.getRewardScoreIndexList_.Equals(other.getRewardScoreIndexList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004E15 RID: 19989 RVA: 0x000BD9E4 File Offset: 0x000BBBE4
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

		// Token: 0x06004E16 RID: 19990 RVA: 0x000BDA63 File Offset: 0x000BBC63
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06004E17 RID: 19991 RVA: 0x000BDA70 File Offset: 0x000BBC70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004E18 RID: 19992 RVA: 0x000BDA7C File Offset: 0x000BBC7C
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

		// Token: 0x06004E19 RID: 19993 RVA: 0x000BDB04 File Offset: 0x000BBD04
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

		// Token: 0x06004E1A RID: 19994 RVA: 0x000BDB88 File Offset: 0x000BBD88
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

		// Token: 0x06004E1B RID: 19995 RVA: 0x000BDBFD File Offset: 0x000BBDFD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004E1C RID: 19996 RVA: 0x000BDC08 File Offset: 0x000BBE08
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

		// Token: 0x04003175 RID: 12661
		private static readonly MessageParser<CorniceLevelPlayEnrty> _parser = new MessageParser<CorniceLevelPlayEnrty>(() => new CorniceLevelPlayEnrty());

		// Token: 0x04003176 RID: 12662
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003177 RID: 12663
		public const int MaxScoreFieldNumber = 1;

		// Token: 0x04003178 RID: 12664
		private int maxScore_;

		// Token: 0x04003179 RID: 12665
		public const int RemainingTimeFieldNumber = 2;

		// Token: 0x0400317A RID: 12666
		private int remainingTime_;

		// Token: 0x0400317B RID: 12667
		public const int UnlockTimeFieldNumber = 3;

		// Token: 0x0400317C RID: 12668
		private long unlockTime_;

		// Token: 0x0400317D RID: 12669
		public const int GetRewardScoreIndexListFieldNumber = 4;

		// Token: 0x0400317E RID: 12670
		private static readonly FieldCodec<int> _repeated_getRewardScoreIndexList_codec = FieldCodec.ForInt32(34U);

		// Token: 0x0400317F RID: 12671
		private readonly RepeatedField<int> getRewardScoreIndexList_ = new RepeatedField<int>();
	}
}
