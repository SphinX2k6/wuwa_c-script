using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020001DC RID: 476
	[NetMessage(EMessageId.BossRushResultNotify)]
	public sealed class BossRushResultNotify : IMessage<BossRushResultNotify>, IMessage, IEquatable<BossRushResultNotify>, IDeepCloneable<BossRushResultNotify>, IBufferMessage
	{
		// Token: 0x060035C9 RID: 13769 RVA: 0x000873E9 File Offset: 0x000855E9
		[NullableContext(1)]
		public static BossRushResultNotify Create()
		{
			return new BossRushResultNotify();
		}

		// Token: 0x1700089A RID: 2202
		// (get) Token: 0x060035CA RID: 13770 RVA: 0x000873F0 File Offset: 0x000855F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700089B RID: 2203
		// (get) Token: 0x060035CB RID: 13771 RVA: 0x000873F3 File Offset: 0x000855F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BossRushResultNotify.Descriptor;
			}
		}

		// Token: 0x060035CC RID: 13772 RVA: 0x000873FA File Offset: 0x000855FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BossRushResultNotify()
		{
		}

		// Token: 0x060035CD RID: 13773 RVA: 0x00087404 File Offset: 0x00085604
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BossRushResultNotify(BossRushResultNotify other) : this()
		{
			this.activityId_ = other.activityId_;
			this.instId_ = other.instId_;
			this.kilMonsterScore_ = other.kilMonsterScore_;
			this.timerScore_ = other.timerScore_;
			this.technicalScore_ = other.technicalScore_;
			this.highScore_ = other.highScore_;
			this.leftTime_ = other.leftTime_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060035CE RID: 13774 RVA: 0x0008747C File Offset: 0x0008567C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BossRushResultNotify Clone()
		{
			return new BossRushResultNotify(this);
		}

		// Token: 0x1700089C RID: 2204
		// (get) Token: 0x060035CF RID: 13775 RVA: 0x00087484 File Offset: 0x00085684
		// (set) Token: 0x060035D0 RID: 13776 RVA: 0x0008748C File Offset: 0x0008568C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ActivityId
		{
			get
			{
				return this.activityId_;
			}
			set
			{
				this.activityId_ = value;
			}
		}

		// Token: 0x1700089D RID: 2205
		// (get) Token: 0x060035D1 RID: 13777 RVA: 0x00087495 File Offset: 0x00085695
		// (set) Token: 0x060035D2 RID: 13778 RVA: 0x0008749D File Offset: 0x0008569D
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

		// Token: 0x1700089E RID: 2206
		// (get) Token: 0x060035D3 RID: 13779 RVA: 0x000874A6 File Offset: 0x000856A6
		// (set) Token: 0x060035D4 RID: 13780 RVA: 0x000874AE File Offset: 0x000856AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int KilMonsterScore
		{
			get
			{
				return this.kilMonsterScore_;
			}
			set
			{
				this.kilMonsterScore_ = value;
			}
		}

		// Token: 0x1700089F RID: 2207
		// (get) Token: 0x060035D5 RID: 13781 RVA: 0x000874B7 File Offset: 0x000856B7
		// (set) Token: 0x060035D6 RID: 13782 RVA: 0x000874BF File Offset: 0x000856BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TimerScore
		{
			get
			{
				return this.timerScore_;
			}
			set
			{
				this.timerScore_ = value;
			}
		}

		// Token: 0x170008A0 RID: 2208
		// (get) Token: 0x060035D7 RID: 13783 RVA: 0x000874C8 File Offset: 0x000856C8
		// (set) Token: 0x060035D8 RID: 13784 RVA: 0x000874D0 File Offset: 0x000856D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TechnicalScore
		{
			get
			{
				return this.technicalScore_;
			}
			set
			{
				this.technicalScore_ = value;
			}
		}

		// Token: 0x170008A1 RID: 2209
		// (get) Token: 0x060035D9 RID: 13785 RVA: 0x000874D9 File Offset: 0x000856D9
		// (set) Token: 0x060035DA RID: 13786 RVA: 0x000874E1 File Offset: 0x000856E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int HighScore
		{
			get
			{
				return this.highScore_;
			}
			set
			{
				this.highScore_ = value;
			}
		}

		// Token: 0x170008A2 RID: 2210
		// (get) Token: 0x060035DB RID: 13787 RVA: 0x000874EA File Offset: 0x000856EA
		// (set) Token: 0x060035DC RID: 13788 RVA: 0x000874F2 File Offset: 0x000856F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int LeftTime
		{
			get
			{
				return this.leftTime_;
			}
			set
			{
				this.leftTime_ = value;
			}
		}

		// Token: 0x060035DD RID: 13789 RVA: 0x000874FB File Offset: 0x000856FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BossRushResultNotify);
		}

		// Token: 0x060035DE RID: 13790 RVA: 0x0008750C File Offset: 0x0008570C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BossRushResultNotify other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.InstId == other.InstId && this.KilMonsterScore == other.KilMonsterScore && this.TimerScore == other.TimerScore && this.TechnicalScore == other.TechnicalScore && this.HighScore == other.HighScore && this.LeftTime == other.LeftTime && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060035DF RID: 13791 RVA: 0x000875A8 File Offset: 0x000857A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ActivityId != 0)
			{
				num ^= this.ActivityId.GetHashCode();
			}
			if (this.InstId != 0)
			{
				num ^= this.InstId.GetHashCode();
			}
			if (this.KilMonsterScore != 0)
			{
				num ^= this.KilMonsterScore.GetHashCode();
			}
			if (this.TimerScore != 0)
			{
				num ^= this.TimerScore.GetHashCode();
			}
			if (this.TechnicalScore != 0)
			{
				num ^= this.TechnicalScore.GetHashCode();
			}
			if (this.HighScore != 0)
			{
				num ^= this.HighScore.GetHashCode();
			}
			if (this.LeftTime != 0)
			{
				num ^= this.LeftTime.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060035E0 RID: 13792 RVA: 0x0008767D File Offset: 0x0008587D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060035E1 RID: 13793 RVA: 0x0008768A File Offset: 0x0008588A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060035E2 RID: 13794 RVA: 0x00087694 File Offset: 0x00085894
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.HighScore != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.HighScore);
			}
			if (this.InstId != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.InstId);
			}
			if (this.TimerScore != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.TimerScore);
			}
			if (this.LeftTime != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.LeftTime);
			}
			if (this.KilMonsterScore != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.KilMonsterScore);
			}
			if (this.TechnicalScore != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.TechnicalScore);
			}
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(120);
				output.WriteInt32(this.ActivityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060035E3 RID: 13795 RVA: 0x0008777C File Offset: 0x0008597C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ActivityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActivityId);
			}
			if (this.InstId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.InstId);
			}
			if (this.KilMonsterScore != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.KilMonsterScore);
			}
			if (this.TimerScore != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TimerScore);
			}
			if (this.TechnicalScore != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TechnicalScore);
			}
			if (this.HighScore != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.HighScore);
			}
			if (this.LeftTime != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.LeftTime);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060035E4 RID: 13796 RVA: 0x0008784C File Offset: 0x00085A4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BossRushResultNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ActivityId != 0)
			{
				this.ActivityId = other.ActivityId;
			}
			if (other.InstId != 0)
			{
				this.InstId = other.InstId;
			}
			if (other.KilMonsterScore != 0)
			{
				this.KilMonsterScore = other.KilMonsterScore;
			}
			if (other.TimerScore != 0)
			{
				this.TimerScore = other.TimerScore;
			}
			if (other.TechnicalScore != 0)
			{
				this.TechnicalScore = other.TechnicalScore;
			}
			if (other.HighScore != 0)
			{
				this.HighScore = other.HighScore;
			}
			if (other.LeftTime != 0)
			{
				this.LeftTime = other.LeftTime;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060035E5 RID: 13797 RVA: 0x00087900 File Offset: 0x00085B00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060035E6 RID: 13798 RVA: 0x0008790C File Offset: 0x00085B0C
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
					if (num == 24U)
					{
						this.HighScore = input.ReadInt32();
						continue;
					}
					if (num == 32U)
					{
						this.InstId = input.ReadInt32();
						continue;
					}
					if (num == 48U)
					{
						this.TimerScore = input.ReadInt32();
						continue;
					}
				}
				else if (num <= 88U)
				{
					if (num == 72U)
					{
						this.LeftTime = input.ReadInt32();
						continue;
					}
					if (num == 88U)
					{
						this.KilMonsterScore = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 112U)
					{
						this.TechnicalScore = input.ReadInt32();
						continue;
					}
					if (num == 120U)
					{
						this.ActivityId = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04002A74 RID: 10868
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002A75 RID: 10869
		public const int ActivityIdFieldNumber = 15;

		// Token: 0x04002A76 RID: 10870
		private int activityId_;

		// Token: 0x04002A77 RID: 10871
		public const int InstIdFieldNumber = 4;

		// Token: 0x04002A78 RID: 10872
		private int instId_;

		// Token: 0x04002A79 RID: 10873
		public const int KilMonsterScoreFieldNumber = 11;

		// Token: 0x04002A7A RID: 10874
		private int kilMonsterScore_;

		// Token: 0x04002A7B RID: 10875
		public const int TimerScoreFieldNumber = 6;

		// Token: 0x04002A7C RID: 10876
		private int timerScore_;

		// Token: 0x04002A7D RID: 10877
		public const int TechnicalScoreFieldNumber = 14;

		// Token: 0x04002A7E RID: 10878
		private int technicalScore_;

		// Token: 0x04002A7F RID: 10879
		public const int HighScoreFieldNumber = 3;

		// Token: 0x04002A80 RID: 10880
		private int highScore_;

		// Token: 0x04002A81 RID: 10881
		public const int LeftTimeFieldNumber = 9;

		// Token: 0x04002A82 RID: 10882
		private int leftTime_;
	}
}
