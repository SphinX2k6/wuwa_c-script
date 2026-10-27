using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000BB9 RID: 3001
	[NetMessage(EMessageId.ParkourChallengeEndNotify)]
	public sealed class ParkourChallengeEndNotify : IMessage<ParkourChallengeEndNotify>, IMessage, IEquatable<ParkourChallengeEndNotify>, IDeepCloneable<ParkourChallengeEndNotify>, IBufferMessage
	{
		// Token: 0x06010446 RID: 66630 RVA: 0x0025FCBE File Offset: 0x0025DEBE
		[NullableContext(1)]
		public static ParkourChallengeEndNotify Create()
		{
			return new ParkourChallengeEndNotify();
		}

		// Token: 0x1700355B RID: 13659
		// (get) Token: 0x06010447 RID: 66631 RVA: 0x0025FCC5 File Offset: 0x0025DEC5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700355C RID: 13660
		// (get) Token: 0x06010448 RID: 66632 RVA: 0x0025FCC8 File Offset: 0x0025DEC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ParkourChallengeEndNotify.Descriptor;
			}
		}

		// Token: 0x06010449 RID: 66633 RVA: 0x0025FCCF File Offset: 0x0025DECF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ParkourChallengeEndNotify()
		{
		}

		// Token: 0x0601044A RID: 66634 RVA: 0x0025FCD8 File Offset: 0x0025DED8
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

		// Token: 0x0601044B RID: 66635 RVA: 0x0025FD2C File Offset: 0x0025DF2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ParkourChallengeEndNotify Clone()
		{
			return new ParkourChallengeEndNotify(this);
		}

		// Token: 0x1700355D RID: 13661
		// (get) Token: 0x0601044C RID: 66636 RVA: 0x0025FD34 File Offset: 0x0025DF34
		// (set) Token: 0x0601044D RID: 66637 RVA: 0x0025FD3C File Offset: 0x0025DF3C
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

		// Token: 0x1700355E RID: 13662
		// (get) Token: 0x0601044E RID: 66638 RVA: 0x0025FD45 File Offset: 0x0025DF45
		// (set) Token: 0x0601044F RID: 66639 RVA: 0x0025FD4D File Offset: 0x0025DF4D
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

		// Token: 0x1700355F RID: 13663
		// (get) Token: 0x06010450 RID: 66640 RVA: 0x0025FD56 File Offset: 0x0025DF56
		// (set) Token: 0x06010451 RID: 66641 RVA: 0x0025FD5E File Offset: 0x0025DF5E
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

		// Token: 0x17003560 RID: 13664
		// (get) Token: 0x06010452 RID: 66642 RVA: 0x0025FD67 File Offset: 0x0025DF67
		// (set) Token: 0x06010453 RID: 66643 RVA: 0x0025FD6F File Offset: 0x0025DF6F
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

		// Token: 0x06010454 RID: 66644 RVA: 0x0025FD78 File Offset: 0x0025DF78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ParkourChallengeEndNotify);
		}

		// Token: 0x06010455 RID: 66645 RVA: 0x0025FD88 File Offset: 0x0025DF88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ParkourChallengeEndNotify other)
		{
			return other != null && (other == this || (this.ChallengeId == other.ChallengeId && this.Score == other.Score && this.Duration == other.Duration && this.IsComplete == other.IsComplete && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06010456 RID: 66646 RVA: 0x0025FDF4 File Offset: 0x0025DFF4
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

		// Token: 0x06010457 RID: 66647 RVA: 0x0025FE7E File Offset: 0x0025E07E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06010458 RID: 66648 RVA: 0x0025FE8B File Offset: 0x0025E08B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06010459 RID: 66649 RVA: 0x0025FE94 File Offset: 0x0025E094
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.IsComplete)
			{
				output.WriteRawTag(32);
				output.WriteBool(this.IsComplete);
			}
			if (this.ChallengeId != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.ChallengeId);
			}
			if (this.Score != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.Score);
			}
			if (this.Duration != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.Duration);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601045A RID: 66650 RVA: 0x0025FF28 File Offset: 0x0025E128
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

		// Token: 0x0601045B RID: 66651 RVA: 0x0025FFA4 File Offset: 0x0025E1A4
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

		// Token: 0x0601045C RID: 66652 RVA: 0x0026001C File Offset: 0x0025E21C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601045D RID: 66653 RVA: 0x00260028 File Offset: 0x0025E228
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
				if (num <= 40U)
				{
					if (num == 32U)
					{
						this.IsComplete = input.ReadBool();
						continue;
					}
					if (num == 40U)
					{
						this.ChallengeId = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 64U)
					{
						this.Score = input.ReadInt32();
						continue;
					}
					if (num == 72U)
					{
						this.Duration = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400677F RID: 26495
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006780 RID: 26496
		public const int ChallengeIdFieldNumber = 5;

		// Token: 0x04006781 RID: 26497
		private int challengeId_;

		// Token: 0x04006782 RID: 26498
		public const int ScoreFieldNumber = 8;

		// Token: 0x04006783 RID: 26499
		private int score_;

		// Token: 0x04006784 RID: 26500
		public const int DurationFieldNumber = 9;

		// Token: 0x04006785 RID: 26501
		private int duration_;

		// Token: 0x04006786 RID: 26502
		public const int IsCompleteFieldNumber = 4;

		// Token: 0x04006787 RID: 26503
		private bool isComplete_;
	}
}
