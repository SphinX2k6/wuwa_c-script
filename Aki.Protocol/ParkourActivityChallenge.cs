using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000BB7 RID: 2999
	public sealed class ParkourActivityChallenge : IMessage<ParkourActivityChallenge>, IMessage, IEquatable<ParkourActivityChallenge>, IDeepCloneable<ParkourActivityChallenge>, IBufferMessage
	{
		// Token: 0x06010415 RID: 66581 RVA: 0x0025F535 File Offset: 0x0025D735
		[NullableContext(1)]
		public static ParkourActivityChallenge Create()
		{
			return new ParkourActivityChallenge();
		}

		// Token: 0x1700354E RID: 13646
		// (get) Token: 0x06010416 RID: 66582 RVA: 0x0025F53C File Offset: 0x0025D73C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ParkourActivityChallenge> Parser
		{
			get
			{
				return ParkourActivityChallenge._parser;
			}
		}

		// Token: 0x1700354F RID: 13647
		// (get) Token: 0x06010417 RID: 66583 RVA: 0x0025F543 File Offset: 0x0025D743
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003550 RID: 13648
		// (get) Token: 0x06010418 RID: 66584 RVA: 0x0025F546 File Offset: 0x0025D746
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ParkourActivityChallenge.Descriptor;
			}
		}

		// Token: 0x06010419 RID: 66585 RVA: 0x0025F54D File Offset: 0x0025D74D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ParkourActivityChallenge()
		{
		}

		// Token: 0x0601041A RID: 66586 RVA: 0x0025F555 File Offset: 0x0025D755
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ParkourActivityChallenge(ParkourActivityChallenge other) : this()
		{
			this.challengeId_ = other.challengeId_;
			this.beginTime_ = other.beginTime_;
			this.endTime_ = other.endTime_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601041B RID: 66587 RVA: 0x0025F592 File Offset: 0x0025D792
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ParkourActivityChallenge Clone()
		{
			return new ParkourActivityChallenge(this);
		}

		// Token: 0x17003551 RID: 13649
		// (get) Token: 0x0601041C RID: 66588 RVA: 0x0025F59A File Offset: 0x0025D79A
		// (set) Token: 0x0601041D RID: 66589 RVA: 0x0025F5A2 File Offset: 0x0025D7A2
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

		// Token: 0x17003552 RID: 13650
		// (get) Token: 0x0601041E RID: 66590 RVA: 0x0025F5AB File Offset: 0x0025D7AB
		// (set) Token: 0x0601041F RID: 66591 RVA: 0x0025F5B3 File Offset: 0x0025D7B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long BeginTime
		{
			get
			{
				return this.beginTime_;
			}
			set
			{
				this.beginTime_ = value;
			}
		}

		// Token: 0x17003553 RID: 13651
		// (get) Token: 0x06010420 RID: 66592 RVA: 0x0025F5BC File Offset: 0x0025D7BC
		// (set) Token: 0x06010421 RID: 66593 RVA: 0x0025F5C4 File Offset: 0x0025D7C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long EndTime
		{
			get
			{
				return this.endTime_;
			}
			set
			{
				this.endTime_ = value;
			}
		}

		// Token: 0x06010422 RID: 66594 RVA: 0x0025F5CD File Offset: 0x0025D7CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ParkourActivityChallenge);
		}

		// Token: 0x06010423 RID: 66595 RVA: 0x0025F5DC File Offset: 0x0025D7DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ParkourActivityChallenge other)
		{
			return other != null && (other == this || (this.ChallengeId == other.ChallengeId && this.BeginTime == other.BeginTime && this.EndTime == other.EndTime && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06010424 RID: 66596 RVA: 0x0025F638 File Offset: 0x0025D838
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ChallengeId != 0)
			{
				num ^= this.ChallengeId.GetHashCode();
			}
			if (this.BeginTime != 0L)
			{
				num ^= this.BeginTime.GetHashCode();
			}
			if (this.EndTime != 0L)
			{
				num ^= this.EndTime.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06010425 RID: 66597 RVA: 0x0025F6A9 File Offset: 0x0025D8A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06010426 RID: 66598 RVA: 0x0025F6B6 File Offset: 0x0025D8B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06010427 RID: 66599 RVA: 0x0025F6C0 File Offset: 0x0025D8C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ChallengeId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.ChallengeId);
			}
			if (this.BeginTime != 0L)
			{
				output.WriteRawTag(16);
				output.WriteInt64(this.BeginTime);
			}
			if (this.EndTime != 0L)
			{
				output.WriteRawTag(24);
				output.WriteInt64(this.EndTime);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06010428 RID: 66600 RVA: 0x0025F734 File Offset: 0x0025D934
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ChallengeId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ChallengeId);
			}
			if (this.BeginTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.BeginTime);
			}
			if (this.EndTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EndTime);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06010429 RID: 66601 RVA: 0x0025F7A4 File Offset: 0x0025D9A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ParkourActivityChallenge other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ChallengeId != 0)
			{
				this.ChallengeId = other.ChallengeId;
			}
			if (other.BeginTime != 0L)
			{
				this.BeginTime = other.BeginTime;
			}
			if (other.EndTime != 0L)
			{
				this.EndTime = other.EndTime;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601042A RID: 66602 RVA: 0x0025F808 File Offset: 0x0025DA08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601042B RID: 66603 RVA: 0x0025F814 File Offset: 0x0025DA14
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
				if (num != 8U)
				{
					if (num != 16U)
					{
						if (num != 24U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.EndTime = input.ReadInt64();
						}
					}
					else
					{
						this.BeginTime = input.ReadInt64();
					}
				}
				else
				{
					this.ChallengeId = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400676C RID: 26476
		private static readonly MessageParser<ParkourActivityChallenge> _parser = new MessageParser<ParkourActivityChallenge>(() => new ParkourActivityChallenge());

		// Token: 0x0400676D RID: 26477
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400676E RID: 26478
		public const int ChallengeIdFieldNumber = 1;

		// Token: 0x0400676F RID: 26479
		private int challengeId_;

		// Token: 0x04006770 RID: 26480
		public const int BeginTimeFieldNumber = 2;

		// Token: 0x04006771 RID: 26481
		private long beginTime_;

		// Token: 0x04006772 RID: 26482
		public const int EndTimeFieldNumber = 3;

		// Token: 0x04006773 RID: 26483
		private long endTime_;
	}
}
