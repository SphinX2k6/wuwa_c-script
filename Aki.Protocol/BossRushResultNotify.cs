using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020001E0 RID: 480
	[NetMessage(EMessageId.BossRushResultNotify)]
	public sealed class BossRushResultNotify : IMessage<BossRushResultNotify>, IMessage, IEquatable<BossRushResultNotify>, IDeepCloneable<BossRushResultNotify>, IBufferMessage
	{
		// Token: 0x06003656 RID: 13910 RVA: 0x00088B5D File Offset: 0x00086D5D
		[NullableContext(1)]
		public static BossRushResultNotify Create()
		{
			return new BossRushResultNotify();
		}

		// Token: 0x170008B3 RID: 2227
		// (get) Token: 0x06003657 RID: 13911 RVA: 0x00088B64 File Offset: 0x00086D64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170008B4 RID: 2228
		// (get) Token: 0x06003658 RID: 13912 RVA: 0x00088B67 File Offset: 0x00086D67
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BossRushResultNotify.Descriptor;
			}
		}

		// Token: 0x06003659 RID: 13913 RVA: 0x00088B6E File Offset: 0x00086D6E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BossRushResultNotify()
		{
		}

		// Token: 0x0600365A RID: 13914 RVA: 0x00088B78 File Offset: 0x00086D78
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

		// Token: 0x0600365B RID: 13915 RVA: 0x00088BF0 File Offset: 0x00086DF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BossRushResultNotify Clone()
		{
			return new BossRushResultNotify(this);
		}

		// Token: 0x170008B5 RID: 2229
		// (get) Token: 0x0600365C RID: 13916 RVA: 0x00088BF8 File Offset: 0x00086DF8
		// (set) Token: 0x0600365D RID: 13917 RVA: 0x00088C00 File Offset: 0x00086E00
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

		// Token: 0x170008B6 RID: 2230
		// (get) Token: 0x0600365E RID: 13918 RVA: 0x00088C09 File Offset: 0x00086E09
		// (set) Token: 0x0600365F RID: 13919 RVA: 0x00088C11 File Offset: 0x00086E11
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

		// Token: 0x170008B7 RID: 2231
		// (get) Token: 0x06003660 RID: 13920 RVA: 0x00088C1A File Offset: 0x00086E1A
		// (set) Token: 0x06003661 RID: 13921 RVA: 0x00088C22 File Offset: 0x00086E22
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

		// Token: 0x170008B8 RID: 2232
		// (get) Token: 0x06003662 RID: 13922 RVA: 0x00088C2B File Offset: 0x00086E2B
		// (set) Token: 0x06003663 RID: 13923 RVA: 0x00088C33 File Offset: 0x00086E33
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

		// Token: 0x170008B9 RID: 2233
		// (get) Token: 0x06003664 RID: 13924 RVA: 0x00088C3C File Offset: 0x00086E3C
		// (set) Token: 0x06003665 RID: 13925 RVA: 0x00088C44 File Offset: 0x00086E44
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

		// Token: 0x170008BA RID: 2234
		// (get) Token: 0x06003666 RID: 13926 RVA: 0x00088C4D File Offset: 0x00086E4D
		// (set) Token: 0x06003667 RID: 13927 RVA: 0x00088C55 File Offset: 0x00086E55
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

		// Token: 0x170008BB RID: 2235
		// (get) Token: 0x06003668 RID: 13928 RVA: 0x00088C5E File Offset: 0x00086E5E
		// (set) Token: 0x06003669 RID: 13929 RVA: 0x00088C66 File Offset: 0x00086E66
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

		// Token: 0x0600366A RID: 13930 RVA: 0x00088C6F File Offset: 0x00086E6F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BossRushResultNotify);
		}

		// Token: 0x0600366B RID: 13931 RVA: 0x00088C80 File Offset: 0x00086E80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BossRushResultNotify other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.InstId == other.InstId && this.KilMonsterScore == other.KilMonsterScore && this.TimerScore == other.TimerScore && this.TechnicalScore == other.TechnicalScore && this.HighScore == other.HighScore && this.LeftTime == other.LeftTime && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600366C RID: 13932 RVA: 0x00088D1C File Offset: 0x00086F1C
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

		// Token: 0x0600366D RID: 13933 RVA: 0x00088DF1 File Offset: 0x00086FF1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600366E RID: 13934 RVA: 0x00088DFE File Offset: 0x00086FFE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600366F RID: 13935 RVA: 0x00088E08 File Offset: 0x00087008
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.KilMonsterScore != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.KilMonsterScore);
			}
			if (this.LeftTime != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.LeftTime);
			}
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.ActivityId);
			}
			if (this.InstId != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.InstId);
			}
			if (this.TimerScore != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.TimerScore);
			}
			if (this.HighScore != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.HighScore);
			}
			if (this.TechnicalScore != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.TechnicalScore);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003670 RID: 13936 RVA: 0x00088EEC File Offset: 0x000870EC
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

		// Token: 0x06003671 RID: 13937 RVA: 0x00088FBC File Offset: 0x000871BC
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

		// Token: 0x06003672 RID: 13938 RVA: 0x00089070 File Offset: 0x00087270
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003673 RID: 13939 RVA: 0x0008907C File Offset: 0x0008727C
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
				if (num <= 24U)
				{
					if (num == 8U)
					{
						this.KilMonsterScore = input.ReadInt32();
						continue;
					}
					if (num == 16U)
					{
						this.LeftTime = input.ReadInt32();
						continue;
					}
					if (num == 24U)
					{
						this.ActivityId = input.ReadInt32();
						continue;
					}
				}
				else if (num <= 56U)
				{
					if (num == 32U)
					{
						this.InstId = input.ReadInt32();
						continue;
					}
					if (num == 56U)
					{
						this.TimerScore = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 72U)
					{
						this.HighScore = input.ReadInt32();
						continue;
					}
					if (num == 104U)
					{
						this.TechnicalScore = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04002AEF RID: 10991
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002AF0 RID: 10992
		public const int ActivityIdFieldNumber = 3;

		// Token: 0x04002AF1 RID: 10993
		private int activityId_;

		// Token: 0x04002AF2 RID: 10994
		public const int InstIdFieldNumber = 4;

		// Token: 0x04002AF3 RID: 10995
		private int instId_;

		// Token: 0x04002AF4 RID: 10996
		public const int KilMonsterScoreFieldNumber = 1;

		// Token: 0x04002AF5 RID: 10997
		private int kilMonsterScore_;

		// Token: 0x04002AF6 RID: 10998
		public const int TimerScoreFieldNumber = 7;

		// Token: 0x04002AF7 RID: 10999
		private int timerScore_;

		// Token: 0x04002AF8 RID: 11000
		public const int TechnicalScoreFieldNumber = 13;

		// Token: 0x04002AF9 RID: 11001
		private int technicalScore_;

		// Token: 0x04002AFA RID: 11002
		public const int HighScoreFieldNumber = 9;

		// Token: 0x04002AFB RID: 11003
		private int highScore_;

		// Token: 0x04002AFC RID: 11004
		public const int LeftTimeFieldNumber = 2;

		// Token: 0x04002AFD RID: 11005
		private int leftTime_;
	}
}
