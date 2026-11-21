using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F34 RID: 3892
	public sealed class RhythmResultPayload : IMessage<RhythmResultPayload>, IMessage, IEquatable<RhythmResultPayload>, IDeepCloneable<RhythmResultPayload>, IBufferMessage
	{
		// Token: 0x06014D9E RID: 85406 RVA: 0x00306F89 File Offset: 0x00305189
		[NullableContext(1)]
		public static RhythmResultPayload Create()
		{
			return new RhythmResultPayload();
		}

		// Token: 0x1700455A RID: 17754
		// (get) Token: 0x06014D9F RID: 85407 RVA: 0x00306F90 File Offset: 0x00305190
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700455B RID: 17755
		// (get) Token: 0x06014DA0 RID: 85408 RVA: 0x00306F93 File Offset: 0x00305193
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RhythmResultPayload.Descriptor;
			}
		}

		// Token: 0x06014DA1 RID: 85409 RVA: 0x00306F9A File Offset: 0x0030519A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RhythmResultPayload()
		{
		}

		// Token: 0x06014DA2 RID: 85410 RVA: 0x00306FB0 File Offset: 0x003051B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RhythmResultPayload(RhythmResultPayload other) : this()
		{
			this.score_ = other.score_;
			this.accuracy_ = other.accuracy_;
			this.judgementCount_ = other.judgementCount_.Clone();
			this.maxCombo_ = other.maxCombo_;
			this.completion_ = other.completion_;
			this.rank_ = other.rank_;
			this.costSecond_ = other.costSecond_;
			this.feverCount_ = other.feverCount_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06014DA3 RID: 85411 RVA: 0x00307039 File Offset: 0x00305239
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RhythmResultPayload Clone()
		{
			return new RhythmResultPayload(this);
		}

		// Token: 0x1700455C RID: 17756
		// (get) Token: 0x06014DA4 RID: 85412 RVA: 0x00307041 File Offset: 0x00305241
		// (set) Token: 0x06014DA5 RID: 85413 RVA: 0x00307049 File Offset: 0x00305249
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Score
		{
			get
			{
				return this.score_;
			}
			set
			{
				this.score_ = value;
			}
		}

		// Token: 0x1700455D RID: 17757
		// (get) Token: 0x06014DA6 RID: 85414 RVA: 0x00307052 File Offset: 0x00305252
		// (set) Token: 0x06014DA7 RID: 85415 RVA: 0x0030705A File Offset: 0x0030525A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Accuracy
		{
			get
			{
				return this.accuracy_;
			}
			set
			{
				this.accuracy_ = value;
			}
		}

		// Token: 0x1700455E RID: 17758
		// (get) Token: 0x06014DA8 RID: 85416 RVA: 0x00307063 File Offset: 0x00305263
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> JudgementCount
		{
			get
			{
				return this.judgementCount_;
			}
		}

		// Token: 0x1700455F RID: 17759
		// (get) Token: 0x06014DA9 RID: 85417 RVA: 0x0030706B File Offset: 0x0030526B
		// (set) Token: 0x06014DAA RID: 85418 RVA: 0x00307073 File Offset: 0x00305273
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int MaxCombo
		{
			get
			{
				return this.maxCombo_;
			}
			set
			{
				this.maxCombo_ = value;
			}
		}

		// Token: 0x17004560 RID: 17760
		// (get) Token: 0x06014DAB RID: 85419 RVA: 0x0030707C File Offset: 0x0030527C
		// (set) Token: 0x06014DAC RID: 85420 RVA: 0x00307084 File Offset: 0x00305284
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Completion
		{
			get
			{
				return this.completion_;
			}
			set
			{
				this.completion_ = value;
			}
		}

		// Token: 0x17004561 RID: 17761
		// (get) Token: 0x06014DAD RID: 85421 RVA: 0x0030708D File Offset: 0x0030528D
		// (set) Token: 0x06014DAE RID: 85422 RVA: 0x00307095 File Offset: 0x00305295
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RhythmShipRank Rank
		{
			get
			{
				return this.rank_;
			}
			set
			{
				this.rank_ = value;
			}
		}

		// Token: 0x17004562 RID: 17762
		// (get) Token: 0x06014DAF RID: 85423 RVA: 0x0030709E File Offset: 0x0030529E
		// (set) Token: 0x06014DB0 RID: 85424 RVA: 0x003070A6 File Offset: 0x003052A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CostSecond
		{
			get
			{
				return this.costSecond_;
			}
			set
			{
				this.costSecond_ = value;
			}
		}

		// Token: 0x17004563 RID: 17763
		// (get) Token: 0x06014DB1 RID: 85425 RVA: 0x003070AF File Offset: 0x003052AF
		// (set) Token: 0x06014DB2 RID: 85426 RVA: 0x003070B7 File Offset: 0x003052B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int FeverCount
		{
			get
			{
				return this.feverCount_;
			}
			set
			{
				this.feverCount_ = value;
			}
		}

		// Token: 0x06014DB3 RID: 85427 RVA: 0x003070C0 File Offset: 0x003052C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RhythmResultPayload);
		}

		// Token: 0x06014DB4 RID: 85428 RVA: 0x003070D0 File Offset: 0x003052D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RhythmResultPayload other)
		{
			return other != null && (other == this || (this.Score == other.Score && this.Accuracy == other.Accuracy && this.judgementCount_.Equals(other.judgementCount_) && this.MaxCombo == other.MaxCombo && this.Completion == other.Completion && this.Rank == other.Rank && this.CostSecond == other.CostSecond && this.FeverCount == other.FeverCount && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06014DB5 RID: 85429 RVA: 0x00307180 File Offset: 0x00305380
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Score != 0)
			{
				num ^= this.Score.GetHashCode();
			}
			if (this.Accuracy != 0)
			{
				num ^= this.Accuracy.GetHashCode();
			}
			num ^= this.judgementCount_.GetHashCode();
			if (this.MaxCombo != 0)
			{
				num ^= this.MaxCombo.GetHashCode();
			}
			if (this.Completion != 0)
			{
				num ^= this.Completion.GetHashCode();
			}
			if (this.Rank != RhythmShipRank.Undefined)
			{
				num ^= this.Rank.GetHashCode();
			}
			if (this.CostSecond != 0)
			{
				num ^= this.CostSecond.GetHashCode();
			}
			if (this.FeverCount != 0)
			{
				num ^= this.FeverCount.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06014DB6 RID: 85430 RVA: 0x00307269 File Offset: 0x00305469
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06014DB7 RID: 85431 RVA: 0x00307276 File Offset: 0x00305476
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06014DB8 RID: 85432 RVA: 0x00307280 File Offset: 0x00305480
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Score != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Score);
			}
			if (this.Accuracy != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.Accuracy);
			}
			this.judgementCount_.WriteTo(ref output, RhythmResultPayload._repeated_judgementCount_codec);
			if (this.MaxCombo != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.MaxCombo);
			}
			if (this.Completion != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.Completion);
			}
			if (this.Rank != RhythmShipRank.Undefined)
			{
				output.WriteRawTag(56);
				output.WriteEnum((int)this.Rank);
			}
			if (this.CostSecond != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.CostSecond);
			}
			if (this.FeverCount != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.FeverCount);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06014DB9 RID: 85433 RVA: 0x00307378 File Offset: 0x00305578
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Score != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Score);
			}
			if (this.Accuracy != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Accuracy);
			}
			num += this.judgementCount_.CalculateSize(RhythmResultPayload._repeated_judgementCount_codec);
			if (this.MaxCombo != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.MaxCombo);
			}
			if (this.Completion != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Completion);
			}
			if (this.Rank != RhythmShipRank.Undefined)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Rank);
			}
			if (this.CostSecond != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CostSecond);
			}
			if (this.FeverCount != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.FeverCount);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06014DBA RID: 85434 RVA: 0x0030745C File Offset: 0x0030565C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RhythmResultPayload other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Score != 0)
			{
				this.Score = other.Score;
			}
			if (other.Accuracy != 0)
			{
				this.Accuracy = other.Accuracy;
			}
			this.judgementCount_.Add(other.judgementCount_);
			if (other.MaxCombo != 0)
			{
				this.MaxCombo = other.MaxCombo;
			}
			if (other.Completion != 0)
			{
				this.Completion = other.Completion;
			}
			if (other.Rank != RhythmShipRank.Undefined)
			{
				this.Rank = other.Rank;
			}
			if (other.CostSecond != 0)
			{
				this.CostSecond = other.CostSecond;
			}
			if (other.FeverCount != 0)
			{
				this.FeverCount = other.FeverCount;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06014DBB RID: 85435 RVA: 0x00307521 File Offset: 0x00305721
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06014DBC RID: 85436 RVA: 0x0030752C File Offset: 0x0030572C
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
				if (num <= 34U)
				{
					if (num <= 24U)
					{
						if (num == 16U)
						{
							this.Score = input.ReadInt32();
							continue;
						}
						if (num == 24U)
						{
							this.Accuracy = input.ReadInt32();
							continue;
						}
					}
					else if (num == 32U || num == 34U)
					{
						this.judgementCount_.AddEntriesFrom(ref input, RhythmResultPayload._repeated_judgementCount_codec);
						continue;
					}
				}
				else if (num <= 48U)
				{
					if (num == 40U)
					{
						this.MaxCombo = input.ReadInt32();
						continue;
					}
					if (num == 48U)
					{
						this.Completion = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 56U)
					{
						this.Rank = (RhythmShipRank)input.ReadEnum();
						continue;
					}
					if (num == 64U)
					{
						this.CostSecond = input.ReadInt32();
						continue;
					}
					if (num == 72U)
					{
						this.FeverCount = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04007E3C RID: 32316
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007E3D RID: 32317
		public const int ScoreFieldNumber = 2;

		// Token: 0x04007E3E RID: 32318
		private int score_;

		// Token: 0x04007E3F RID: 32319
		public const int AccuracyFieldNumber = 3;

		// Token: 0x04007E40 RID: 32320
		private int accuracy_;

		// Token: 0x04007E41 RID: 32321
		public const int JudgementCountFieldNumber = 4;

		// Token: 0x04007E42 RID: 32322
		private static readonly FieldCodec<int> _repeated_judgementCount_codec = FieldCodec.ForInt32(34U);

		// Token: 0x04007E43 RID: 32323
		private readonly RepeatedField<int> judgementCount_ = new RepeatedField<int>();

		// Token: 0x04007E44 RID: 32324
		public const int MaxComboFieldNumber = 5;

		// Token: 0x04007E45 RID: 32325
		private int maxCombo_;

		// Token: 0x04007E46 RID: 32326
		public const int CompletionFieldNumber = 6;

		// Token: 0x04007E47 RID: 32327
		private int completion_;

		// Token: 0x04007E48 RID: 32328
		public const int RankFieldNumber = 7;

		// Token: 0x04007E49 RID: 32329
		private RhythmShipRank rank_;

		// Token: 0x04007E4A RID: 32330
		public const int CostSecondFieldNumber = 8;

		// Token: 0x04007E4B RID: 32331
		private int costSecond_;

		// Token: 0x04007E4C RID: 32332
		public const int FeverCountFieldNumber = 9;

		// Token: 0x04007E4D RID: 32333
		private int feverCount_;
	}
}
