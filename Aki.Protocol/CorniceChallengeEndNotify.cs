using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000309 RID: 777
	[NetMessage(EMessageId.CorniceChallengeEndNotify)]
	public sealed class CorniceChallengeEndNotify : IMessage<CorniceChallengeEndNotify>, IMessage, IEquatable<CorniceChallengeEndNotify>, IDeepCloneable<CorniceChallengeEndNotify>, IBufferMessage
	{
		// Token: 0x06004EA0 RID: 20128 RVA: 0x000BF444 File Offset: 0x000BD644
		[NullableContext(1)]
		public static CorniceChallengeEndNotify Create()
		{
			return new CorniceChallengeEndNotify();
		}

		// Token: 0x17000DF1 RID: 3569
		// (get) Token: 0x06004EA1 RID: 20129 RVA: 0x000BF44B File Offset: 0x000BD64B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000DF2 RID: 3570
		// (get) Token: 0x06004EA2 RID: 20130 RVA: 0x000BF44E File Offset: 0x000BD64E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CorniceChallengeEndNotify.Descriptor;
			}
		}

		// Token: 0x06004EA3 RID: 20131 RVA: 0x000BF455 File Offset: 0x000BD655
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CorniceChallengeEndNotify()
		{
		}

		// Token: 0x06004EA4 RID: 20132 RVA: 0x000BF460 File Offset: 0x000BD660
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CorniceChallengeEndNotify(CorniceChallengeEndNotify other) : this()
		{
			this.levelPlayId_ = other.levelPlayId_;
			this.score_ = other.score_;
			this.remainingTime_ = other.remainingTime_;
			this.newScoreRecord_ = other.newScoreRecord_;
			this.newRemainingTimeRecord_ = other.newRemainingTimeRecord_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004EA5 RID: 20133 RVA: 0x000BF4C0 File Offset: 0x000BD6C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CorniceChallengeEndNotify Clone()
		{
			return new CorniceChallengeEndNotify(this);
		}

		// Token: 0x17000DF3 RID: 3571
		// (get) Token: 0x06004EA6 RID: 20134 RVA: 0x000BF4C8 File Offset: 0x000BD6C8
		// (set) Token: 0x06004EA7 RID: 20135 RVA: 0x000BF4D0 File Offset: 0x000BD6D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int LevelPlayId
		{
			get
			{
				return this.levelPlayId_;
			}
			set
			{
				this.levelPlayId_ = value;
			}
		}

		// Token: 0x17000DF4 RID: 3572
		// (get) Token: 0x06004EA8 RID: 20136 RVA: 0x000BF4D9 File Offset: 0x000BD6D9
		// (set) Token: 0x06004EA9 RID: 20137 RVA: 0x000BF4E1 File Offset: 0x000BD6E1
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

		// Token: 0x17000DF5 RID: 3573
		// (get) Token: 0x06004EAA RID: 20138 RVA: 0x000BF4EA File Offset: 0x000BD6EA
		// (set) Token: 0x06004EAB RID: 20139 RVA: 0x000BF4F2 File Offset: 0x000BD6F2
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

		// Token: 0x17000DF6 RID: 3574
		// (get) Token: 0x06004EAC RID: 20140 RVA: 0x000BF4FB File Offset: 0x000BD6FB
		// (set) Token: 0x06004EAD RID: 20141 RVA: 0x000BF503 File Offset: 0x000BD703
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool NewScoreRecord
		{
			get
			{
				return this.newScoreRecord_;
			}
			set
			{
				this.newScoreRecord_ = value;
			}
		}

		// Token: 0x17000DF7 RID: 3575
		// (get) Token: 0x06004EAE RID: 20142 RVA: 0x000BF50C File Offset: 0x000BD70C
		// (set) Token: 0x06004EAF RID: 20143 RVA: 0x000BF514 File Offset: 0x000BD714
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool NewRemainingTimeRecord
		{
			get
			{
				return this.newRemainingTimeRecord_;
			}
			set
			{
				this.newRemainingTimeRecord_ = value;
			}
		}

		// Token: 0x06004EB0 RID: 20144 RVA: 0x000BF51D File Offset: 0x000BD71D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CorniceChallengeEndNotify);
		}

		// Token: 0x06004EB1 RID: 20145 RVA: 0x000BF52C File Offset: 0x000BD72C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CorniceChallengeEndNotify other)
		{
			return other != null && (other == this || (this.LevelPlayId == other.LevelPlayId && this.Score == other.Score && this.RemainingTime == other.RemainingTime && this.NewScoreRecord == other.NewScoreRecord && this.NewRemainingTimeRecord == other.NewRemainingTimeRecord && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004EB2 RID: 20146 RVA: 0x000BF5A8 File Offset: 0x000BD7A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.LevelPlayId != 0)
			{
				num ^= this.LevelPlayId.GetHashCode();
			}
			if (this.Score != 0)
			{
				num ^= this.Score.GetHashCode();
			}
			if (this.RemainingTime != 0)
			{
				num ^= this.RemainingTime.GetHashCode();
			}
			if (this.NewScoreRecord)
			{
				num ^= this.NewScoreRecord.GetHashCode();
			}
			if (this.NewRemainingTimeRecord)
			{
				num ^= this.NewRemainingTimeRecord.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06004EB3 RID: 20147 RVA: 0x000BF64B File Offset: 0x000BD84B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06004EB4 RID: 20148 RVA: 0x000BF658 File Offset: 0x000BD858
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004EB5 RID: 20149 RVA: 0x000BF664 File Offset: 0x000BD864
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.NewScoreRecord)
			{
				output.WriteRawTag(16);
				output.WriteBool(this.NewScoreRecord);
			}
			if (this.RemainingTime != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.RemainingTime);
			}
			if (this.Score != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.Score);
			}
			if (this.NewRemainingTimeRecord)
			{
				output.WriteRawTag(104);
				output.WriteBool(this.NewRemainingTimeRecord);
			}
			if (this.LevelPlayId != 0)
			{
				output.WriteRawTag(120);
				output.WriteInt32(this.LevelPlayId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004EB6 RID: 20150 RVA: 0x000BF714 File Offset: 0x000BD914
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.LevelPlayId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.LevelPlayId);
			}
			if (this.Score != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Score);
			}
			if (this.RemainingTime != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RemainingTime);
			}
			if (this.NewScoreRecord)
			{
				num += 2;
			}
			if (this.NewRemainingTimeRecord)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06004EB7 RID: 20151 RVA: 0x000BF79C File Offset: 0x000BD99C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CorniceChallengeEndNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.LevelPlayId != 0)
			{
				this.LevelPlayId = other.LevelPlayId;
			}
			if (other.Score != 0)
			{
				this.Score = other.Score;
			}
			if (other.RemainingTime != 0)
			{
				this.RemainingTime = other.RemainingTime;
			}
			if (other.NewScoreRecord)
			{
				this.NewScoreRecord = other.NewScoreRecord;
			}
			if (other.NewRemainingTimeRecord)
			{
				this.NewRemainingTimeRecord = other.NewRemainingTimeRecord;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06004EB8 RID: 20152 RVA: 0x000BF828 File Offset: 0x000BDA28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004EB9 RID: 20153 RVA: 0x000BF834 File Offset: 0x000BDA34
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
				if (num <= 64U)
				{
					if (num == 16U)
					{
						this.NewScoreRecord = input.ReadBool();
						continue;
					}
					if (num == 64U)
					{
						this.RemainingTime = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 96U)
					{
						this.Score = input.ReadInt32();
						continue;
					}
					if (num == 104U)
					{
						this.NewRemainingTimeRecord = input.ReadBool();
						continue;
					}
					if (num == 120U)
					{
						this.LevelPlayId = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040031FB RID: 12795
		private UnknownFieldSet _unknownFields;

		// Token: 0x040031FC RID: 12796
		public const int LevelPlayIdFieldNumber = 15;

		// Token: 0x040031FD RID: 12797
		private int levelPlayId_;

		// Token: 0x040031FE RID: 12798
		public const int ScoreFieldNumber = 12;

		// Token: 0x040031FF RID: 12799
		private int score_;

		// Token: 0x04003200 RID: 12800
		public const int RemainingTimeFieldNumber = 8;

		// Token: 0x04003201 RID: 12801
		private int remainingTime_;

		// Token: 0x04003202 RID: 12802
		public const int NewScoreRecordFieldNumber = 2;

		// Token: 0x04003203 RID: 12803
		private bool newScoreRecord_;

		// Token: 0x04003204 RID: 12804
		public const int NewRemainingTimeRecordFieldNumber = 13;

		// Token: 0x04003205 RID: 12805
		private bool newRemainingTimeRecord_;
	}
}
