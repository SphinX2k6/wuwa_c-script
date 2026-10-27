using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F44 RID: 3908
	public sealed class RhythmResultPayload : IMessage<RhythmResultPayload>, IMessage, IEquatable<RhythmResultPayload>, IDeepCloneable<RhythmResultPayload>, IBufferMessage
	{
		// Token: 0x06014E83 RID: 85635 RVA: 0x00308645 File Offset: 0x00306845
		[NullableContext(1)]
		public static RhythmResultPayload Create()
		{
			return new RhythmResultPayload();
		}

		// Token: 0x17004584 RID: 17796
		// (get) Token: 0x06014E84 RID: 85636 RVA: 0x0030864C File Offset: 0x0030684C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004585 RID: 17797
		// (get) Token: 0x06014E85 RID: 85637 RVA: 0x0030864F File Offset: 0x0030684F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RhythmResultPayload.Descriptor;
			}
		}

		// Token: 0x06014E86 RID: 85638 RVA: 0x00308656 File Offset: 0x00306856
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RhythmResultPayload()
		{
		}

		// Token: 0x06014E87 RID: 85639 RVA: 0x0030866C File Offset: 0x0030686C
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

		// Token: 0x06014E88 RID: 85640 RVA: 0x003086F5 File Offset: 0x003068F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RhythmResultPayload Clone()
		{
			return new RhythmResultPayload(this);
		}

		// Token: 0x17004586 RID: 17798
		// (get) Token: 0x06014E89 RID: 85641 RVA: 0x003086FD File Offset: 0x003068FD
		// (set) Token: 0x06014E8A RID: 85642 RVA: 0x00308705 File Offset: 0x00306905
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

		// Token: 0x17004587 RID: 17799
		// (get) Token: 0x06014E8B RID: 85643 RVA: 0x0030870E File Offset: 0x0030690E
		// (set) Token: 0x06014E8C RID: 85644 RVA: 0x00308716 File Offset: 0x00306916
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

		// Token: 0x17004588 RID: 17800
		// (get) Token: 0x06014E8D RID: 85645 RVA: 0x0030871F File Offset: 0x0030691F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> JudgementCount
		{
			get
			{
				return this.judgementCount_;
			}
		}

		// Token: 0x17004589 RID: 17801
		// (get) Token: 0x06014E8E RID: 85646 RVA: 0x00308727 File Offset: 0x00306927
		// (set) Token: 0x06014E8F RID: 85647 RVA: 0x0030872F File Offset: 0x0030692F
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

		// Token: 0x1700458A RID: 17802
		// (get) Token: 0x06014E90 RID: 85648 RVA: 0x00308738 File Offset: 0x00306938
		// (set) Token: 0x06014E91 RID: 85649 RVA: 0x00308740 File Offset: 0x00306940
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

		// Token: 0x1700458B RID: 17803
		// (get) Token: 0x06014E92 RID: 85650 RVA: 0x00308749 File Offset: 0x00306949
		// (set) Token: 0x06014E93 RID: 85651 RVA: 0x00308751 File Offset: 0x00306951
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

		// Token: 0x1700458C RID: 17804
		// (get) Token: 0x06014E94 RID: 85652 RVA: 0x0030875A File Offset: 0x0030695A
		// (set) Token: 0x06014E95 RID: 85653 RVA: 0x00308762 File Offset: 0x00306962
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

		// Token: 0x1700458D RID: 17805
		// (get) Token: 0x06014E96 RID: 85654 RVA: 0x0030876B File Offset: 0x0030696B
		// (set) Token: 0x06014E97 RID: 85655 RVA: 0x00308773 File Offset: 0x00306973
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

		// Token: 0x06014E98 RID: 85656 RVA: 0x0030877C File Offset: 0x0030697C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RhythmResultPayload);
		}

		// Token: 0x06014E99 RID: 85657 RVA: 0x0030878C File Offset: 0x0030698C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RhythmResultPayload other)
		{
			return other != null && (other == this || (this.Score == other.Score && this.Accuracy == other.Accuracy && this.judgementCount_.Equals(other.judgementCount_) && this.MaxCombo == other.MaxCombo && this.Completion == other.Completion && this.Rank == other.Rank && this.CostSecond == other.CostSecond && this.FeverCount == other.FeverCount && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06014E9A RID: 85658 RVA: 0x0030883C File Offset: 0x00306A3C
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

		// Token: 0x06014E9B RID: 85659 RVA: 0x00308925 File Offset: 0x00306B25
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06014E9C RID: 85660 RVA: 0x00308932 File Offset: 0x00306B32
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06014E9D RID: 85661 RVA: 0x0030893C File Offset: 0x00306B3C
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

		// Token: 0x06014E9E RID: 85662 RVA: 0x00308A34 File Offset: 0x00306C34
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

		// Token: 0x06014E9F RID: 85663 RVA: 0x00308B18 File Offset: 0x00306D18
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

		// Token: 0x06014EA0 RID: 85664 RVA: 0x00308BDD File Offset: 0x00306DDD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06014EA1 RID: 85665 RVA: 0x00308BE8 File Offset: 0x00306DE8
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

		// Token: 0x04007E12 RID: 32274
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007E13 RID: 32275
		public const int ScoreFieldNumber = 2;

		// Token: 0x04007E14 RID: 32276
		private int score_;

		// Token: 0x04007E15 RID: 32277
		public const int AccuracyFieldNumber = 3;

		// Token: 0x04007E16 RID: 32278
		private int accuracy_;

		// Token: 0x04007E17 RID: 32279
		public const int JudgementCountFieldNumber = 4;

		// Token: 0x04007E18 RID: 32280
		private static readonly FieldCodec<int> _repeated_judgementCount_codec = FieldCodec.ForInt32(34U);

		// Token: 0x04007E19 RID: 32281
		private readonly RepeatedField<int> judgementCount_ = new RepeatedField<int>();

		// Token: 0x04007E1A RID: 32282
		public const int MaxComboFieldNumber = 5;

		// Token: 0x04007E1B RID: 32283
		private int maxCombo_;

		// Token: 0x04007E1C RID: 32284
		public const int CompletionFieldNumber = 6;

		// Token: 0x04007E1D RID: 32285
		private int completion_;

		// Token: 0x04007E1E RID: 32286
		public const int RankFieldNumber = 7;

		// Token: 0x04007E1F RID: 32287
		private RhythmShipRank rank_;

		// Token: 0x04007E20 RID: 32288
		public const int CostSecondFieldNumber = 8;

		// Token: 0x04007E21 RID: 32289
		private int costSecond_;

		// Token: 0x04007E22 RID: 32290
		public const int FeverCountFieldNumber = 9;

		// Token: 0x04007E23 RID: 32291
		private int feverCount_;
	}
}
