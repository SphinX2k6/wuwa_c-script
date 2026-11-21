using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000BA9 RID: 2985
	[NetMessage(EMessageId.ParkourChallengeEndNotify)]
	public sealed class ParkourChallengeEndNotify : IMessage<ParkourChallengeEndNotify>, IMessage, IEquatable<ParkourChallengeEndNotify>, IDeepCloneable<ParkourChallengeEndNotify>, IBufferMessage
	{
		// Token: 0x06010342 RID: 66370 RVA: 0x0025DE0A File Offset: 0x0025C00A
		[NullableContext(1)]
		public static ParkourChallengeEndNotify Create()
		{
			return new ParkourChallengeEndNotify();
		}

		// Token: 0x17003522 RID: 13602
		// (get) Token: 0x06010343 RID: 66371 RVA: 0x0025DE11 File Offset: 0x0025C011
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003523 RID: 13603
		// (get) Token: 0x06010344 RID: 66372 RVA: 0x0025DE14 File Offset: 0x0025C014
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ParkourChallengeEndNotify.Descriptor;
			}
		}

		// Token: 0x06010345 RID: 66373 RVA: 0x0025DE1B File Offset: 0x0025C01B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ParkourChallengeEndNotify()
		{
		}

		// Token: 0x06010346 RID: 66374 RVA: 0x0025DE24 File Offset: 0x0025C024
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ParkourChallengeEndNotify(ParkourChallengeEndNotify other) : this()
		{
			this.challengeId_ = other.challengeId_;
			this.score_ = other.score_;
			this.duration_ = other.duration_;
			this.isComplete_ = other.isComplete_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06010347 RID: 66375 RVA: 0x0025DE78 File Offset: 0x0025C078
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ParkourChallengeEndNotify Clone()
		{
			return new ParkourChallengeEndNotify(this);
		}

		// Token: 0x17003524 RID: 13604
		// (get) Token: 0x06010348 RID: 66376 RVA: 0x0025DE80 File Offset: 0x0025C080
		// (set) Token: 0x06010349 RID: 66377 RVA: 0x0025DE88 File Offset: 0x0025C088
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ChallengeId
		{
			get
			{
				return this.challengeId_;
			}
			set
			{
				this.challengeId_ = value;
			}
		}

		// Token: 0x17003525 RID: 13605
		// (get) Token: 0x0601034A RID: 66378 RVA: 0x0025DE91 File Offset: 0x0025C091
		// (set) Token: 0x0601034B RID: 66379 RVA: 0x0025DE99 File Offset: 0x0025C099
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

		// Token: 0x17003526 RID: 13606
		// (get) Token: 0x0601034C RID: 66380 RVA: 0x0025DEA2 File Offset: 0x0025C0A2
		// (set) Token: 0x0601034D RID: 66381 RVA: 0x0025DEAA File Offset: 0x0025C0AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Duration
		{
			get
			{
				return this.duration_;
			}
			set
			{
				this.duration_ = value;
			}
		}

		// Token: 0x17003527 RID: 13607
		// (get) Token: 0x0601034E RID: 66382 RVA: 0x0025DEB3 File Offset: 0x0025C0B3
		// (set) Token: 0x0601034F RID: 66383 RVA: 0x0025DEBB File Offset: 0x0025C0BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsComplete
		{
			get
			{
				return this.isComplete_;
			}
			set
			{
				this.isComplete_ = value;
			}
		}

		// Token: 0x06010350 RID: 66384 RVA: 0x0025DEC4 File Offset: 0x0025C0C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ParkourChallengeEndNotify);
		}

		// Token: 0x06010351 RID: 66385 RVA: 0x0025DED4 File Offset: 0x0025C0D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ParkourChallengeEndNotify other)
		{
			return other != null && (other == this || (this.ChallengeId == other.ChallengeId && this.Score == other.Score && this.Duration == other.Duration && this.IsComplete == other.IsComplete && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06010352 RID: 66386 RVA: 0x0025DF40 File Offset: 0x0025C140
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ChallengeId != 0)
			{
				num ^= this.ChallengeId.GetHashCode();
			}
			if (this.Score != 0)
			{
				num ^= this.Score.GetHashCode();
			}
			if (this.Duration != 0)
			{
				num ^= this.Duration.GetHashCode();
			}
			if (this.IsComplete)
			{
				num ^= this.IsComplete.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06010353 RID: 66387 RVA: 0x0025DFCA File Offset: 0x0025C1CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06010354 RID: 66388 RVA: 0x0025DFD7 File Offset: 0x0025C1D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06010355 RID: 66389 RVA: 0x0025DFE0 File Offset: 0x0025C1E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Duration != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Duration);
			}
			if (this.IsComplete)
			{
				output.WriteRawTag(32);
				output.WriteBool(this.IsComplete);
			}
			if (this.Score != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.Score);
			}
			if (this.ChallengeId != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.ChallengeId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06010356 RID: 66390 RVA: 0x0025E074 File Offset: 0x0025C274
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ChallengeId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ChallengeId);
			}
			if (this.Score != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Score);
			}
			if (this.Duration != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Duration);
			}
			if (this.IsComplete)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06010357 RID: 66391 RVA: 0x0025E0F0 File Offset: 0x0025C2F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ParkourChallengeEndNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ChallengeId != 0)
			{
				this.ChallengeId = other.ChallengeId;
			}
			if (other.Score != 0)
			{
				this.Score = other.Score;
			}
			if (other.Duration != 0)
			{
				this.Duration = other.Duration;
			}
			if (other.IsComplete)
			{
				this.IsComplete = other.IsComplete;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06010358 RID: 66392 RVA: 0x0025E168 File Offset: 0x0025C368
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06010359 RID: 66393 RVA: 0x0025E174 File Offset: 0x0025C374
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
				if (num <= 32U)
				{
					if (num == 16U)
					{
						this.Duration = input.ReadInt32();
						continue;
					}
					if (num == 32U)
					{
						this.IsComplete = input.ReadBool();
						continue;
					}
				}
				else
				{
					if (num == 40U)
					{
						this.Score = input.ReadInt32();
						continue;
					}
					if (num == 88U)
					{
						this.ChallengeId = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400678F RID: 26511
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006790 RID: 26512
		public const int ChallengeIdFieldNumber = 11;

		// Token: 0x04006791 RID: 26513
		private int challengeId_;

		// Token: 0x04006792 RID: 26514
		public const int ScoreFieldNumber = 5;

		// Token: 0x04006793 RID: 26515
		private int score_;

		// Token: 0x04006794 RID: 26516
		public const int DurationFieldNumber = 2;

		// Token: 0x04006795 RID: 26517
		private int duration_;

		// Token: 0x04006796 RID: 26518
		public const int IsCompleteFieldNumber = 4;

		// Token: 0x04006797 RID: 26519
		private bool isComplete_;
	}
}
