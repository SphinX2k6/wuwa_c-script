using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000302 RID: 770
	[NetMessage(EMessageId.CorniceChallengeEndNotify)]
	public sealed class CorniceChallengeEndNotify : IMessage<CorniceChallengeEndNotify>, IMessage, IEquatable<CorniceChallengeEndNotify>, IDeepCloneable<CorniceChallengeEndNotify>, IBufferMessage
	{
		// Token: 0x06004DC7 RID: 19911 RVA: 0x000BD058 File Offset: 0x000BB258
		[NullableContext(1)]
		public static CorniceChallengeEndNotify Create()
		{
			return new CorniceChallengeEndNotify();
		}

		// Token: 0x17000DC4 RID: 3524
		// (get) Token: 0x06004DC8 RID: 19912 RVA: 0x000BD05F File Offset: 0x000BB25F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000DC5 RID: 3525
		// (get) Token: 0x06004DC9 RID: 19913 RVA: 0x000BD062 File Offset: 0x000BB262
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CorniceChallengeEndNotify.Descriptor;
			}
		}

		// Token: 0x06004DCA RID: 19914 RVA: 0x000BD069 File Offset: 0x000BB269
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CorniceChallengeEndNotify()
		{
		}

		// Token: 0x06004DCB RID: 19915 RVA: 0x000BD074 File Offset: 0x000BB274
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

		// Token: 0x06004DCC RID: 19916 RVA: 0x000BD0D4 File Offset: 0x000BB2D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CorniceChallengeEndNotify Clone()
		{
			return new CorniceChallengeEndNotify(this);
		}

		// Token: 0x17000DC6 RID: 3526
		// (get) Token: 0x06004DCD RID: 19917 RVA: 0x000BD0DC File Offset: 0x000BB2DC
		// (set) Token: 0x06004DCE RID: 19918 RVA: 0x000BD0E4 File Offset: 0x000BB2E4
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

		// Token: 0x17000DC7 RID: 3527
		// (get) Token: 0x06004DCF RID: 19919 RVA: 0x000BD0ED File Offset: 0x000BB2ED
		// (set) Token: 0x06004DD0 RID: 19920 RVA: 0x000BD0F5 File Offset: 0x000BB2F5
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

		// Token: 0x17000DC8 RID: 3528
		// (get) Token: 0x06004DD1 RID: 19921 RVA: 0x000BD0FE File Offset: 0x000BB2FE
		// (set) Token: 0x06004DD2 RID: 19922 RVA: 0x000BD106 File Offset: 0x000BB306
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

		// Token: 0x17000DC9 RID: 3529
		// (get) Token: 0x06004DD3 RID: 19923 RVA: 0x000BD10F File Offset: 0x000BB30F
		// (set) Token: 0x06004DD4 RID: 19924 RVA: 0x000BD117 File Offset: 0x000BB317
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

		// Token: 0x17000DCA RID: 3530
		// (get) Token: 0x06004DD5 RID: 19925 RVA: 0x000BD120 File Offset: 0x000BB320
		// (set) Token: 0x06004DD6 RID: 19926 RVA: 0x000BD128 File Offset: 0x000BB328
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

		// Token: 0x06004DD7 RID: 19927 RVA: 0x000BD131 File Offset: 0x000BB331
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CorniceChallengeEndNotify);
		}

		// Token: 0x06004DD8 RID: 19928 RVA: 0x000BD140 File Offset: 0x000BB340
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CorniceChallengeEndNotify other)
		{
			return other != null && (other == this || (this.LevelPlayId == other.LevelPlayId && this.Score == other.Score && this.RemainingTime == other.RemainingTime && this.NewScoreRecord == other.NewScoreRecord && this.NewRemainingTimeRecord == other.NewRemainingTimeRecord && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004DD9 RID: 19929 RVA: 0x000BD1BC File Offset: 0x000BB3BC
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

		// Token: 0x06004DDA RID: 19930 RVA: 0x000BD25F File Offset: 0x000BB45F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06004DDB RID: 19931 RVA: 0x000BD26C File Offset: 0x000BB46C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004DDC RID: 19932 RVA: 0x000BD278 File Offset: 0x000BB478
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.NewScoreRecord)
			{
				output.WriteRawTag(32);
				output.WriteBool(this.NewScoreRecord);
			}
			if (this.RemainingTime != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.RemainingTime);
			}
			if (this.LevelPlayId != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.LevelPlayId);
			}
			if (this.NewRemainingTimeRecord)
			{
				output.WriteRawTag(104);
				output.WriteBool(this.NewRemainingTimeRecord);
			}
			if (this.Score != 0)
			{
				output.WriteRawTag(120);
				output.WriteInt32(this.Score);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004DDD RID: 19933 RVA: 0x000BD328 File Offset: 0x000BB528
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

		// Token: 0x06004DDE RID: 19934 RVA: 0x000BD3B0 File Offset: 0x000BB5B0
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

		// Token: 0x06004DDF RID: 19935 RVA: 0x000BD43C File Offset: 0x000BB63C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004DE0 RID: 19936 RVA: 0x000BD448 File Offset: 0x000BB648
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
					if (num == 32U)
					{
						this.NewScoreRecord = input.ReadBool();
						continue;
					}
					if (num == 48U)
					{
						this.RemainingTime = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 80U)
					{
						this.LevelPlayId = input.ReadInt32();
						continue;
					}
					if (num == 104U)
					{
						this.NewRemainingTimeRecord = input.ReadBool();
						continue;
					}
					if (num == 120U)
					{
						this.Score = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04003164 RID: 12644
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003165 RID: 12645
		public const int LevelPlayIdFieldNumber = 10;

		// Token: 0x04003166 RID: 12646
		private int levelPlayId_;

		// Token: 0x04003167 RID: 12647
		public const int ScoreFieldNumber = 15;

		// Token: 0x04003168 RID: 12648
		private int score_;

		// Token: 0x04003169 RID: 12649
		public const int RemainingTimeFieldNumber = 6;

		// Token: 0x0400316A RID: 12650
		private int remainingTime_;

		// Token: 0x0400316B RID: 12651
		public const int NewScoreRecordFieldNumber = 4;

		// Token: 0x0400316C RID: 12652
		private bool newScoreRecord_;

		// Token: 0x0400316D RID: 12653
		public const int NewRemainingTimeRecordFieldNumber = 13;

		// Token: 0x0400316E RID: 12654
		private bool newRemainingTimeRecord_;
	}
}
