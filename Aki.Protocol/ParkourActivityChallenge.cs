using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000BA7 RID: 2983
	public sealed class ParkourActivityChallenge : IMessage<ParkourActivityChallenge>, IMessage, IEquatable<ParkourActivityChallenge>, IDeepCloneable<ParkourActivityChallenge>, IBufferMessage
	{
		// Token: 0x06010311 RID: 66321 RVA: 0x0025D681 File Offset: 0x0025B881
		[NullableContext(1)]
		public static ParkourActivityChallenge Create()
		{
			return new ParkourActivityChallenge();
		}

		// Token: 0x17003515 RID: 13589
		// (get) Token: 0x06010312 RID: 66322 RVA: 0x0025D688 File Offset: 0x0025B888
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ParkourActivityChallenge> Parser
		{
			get
			{
				return ParkourActivityChallenge._parser;
			}
		}

		// Token: 0x17003516 RID: 13590
		// (get) Token: 0x06010313 RID: 66323 RVA: 0x0025D68F File Offset: 0x0025B88F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003517 RID: 13591
		// (get) Token: 0x06010314 RID: 66324 RVA: 0x0025D692 File Offset: 0x0025B892
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ParkourActivityChallenge.Descriptor;
			}
		}

		// Token: 0x06010315 RID: 66325 RVA: 0x0025D699 File Offset: 0x0025B899
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ParkourActivityChallenge()
		{
		}

		// Token: 0x06010316 RID: 66326 RVA: 0x0025D6A1 File Offset: 0x0025B8A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ParkourActivityChallenge(ParkourActivityChallenge other) : this()
		{
			this.challengeId_ = other.challengeId_;
			this.beginTime_ = other.beginTime_;
			this.endTime_ = other.endTime_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06010317 RID: 66327 RVA: 0x0025D6DE File Offset: 0x0025B8DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ParkourActivityChallenge Clone()
		{
			return new ParkourActivityChallenge(this);
		}

		// Token: 0x17003518 RID: 13592
		// (get) Token: 0x06010318 RID: 66328 RVA: 0x0025D6E6 File Offset: 0x0025B8E6
		// (set) Token: 0x06010319 RID: 66329 RVA: 0x0025D6EE File Offset: 0x0025B8EE
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

		// Token: 0x17003519 RID: 13593
		// (get) Token: 0x0601031A RID: 66330 RVA: 0x0025D6F7 File Offset: 0x0025B8F7
		// (set) Token: 0x0601031B RID: 66331 RVA: 0x0025D6FF File Offset: 0x0025B8FF
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

		// Token: 0x1700351A RID: 13594
		// (get) Token: 0x0601031C RID: 66332 RVA: 0x0025D708 File Offset: 0x0025B908
		// (set) Token: 0x0601031D RID: 66333 RVA: 0x0025D710 File Offset: 0x0025B910
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

		// Token: 0x0601031E RID: 66334 RVA: 0x0025D719 File Offset: 0x0025B919
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ParkourActivityChallenge);
		}

		// Token: 0x0601031F RID: 66335 RVA: 0x0025D728 File Offset: 0x0025B928
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ParkourActivityChallenge other)
		{
			return other != null && (other == this || (this.ChallengeId == other.ChallengeId && this.BeginTime == other.BeginTime && this.EndTime == other.EndTime && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06010320 RID: 66336 RVA: 0x0025D784 File Offset: 0x0025B984
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

		// Token: 0x06010321 RID: 66337 RVA: 0x0025D7F5 File Offset: 0x0025B9F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06010322 RID: 66338 RVA: 0x0025D802 File Offset: 0x0025BA02
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06010323 RID: 66339 RVA: 0x0025D80C File Offset: 0x0025BA0C
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

		// Token: 0x06010324 RID: 66340 RVA: 0x0025D880 File Offset: 0x0025BA80
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

		// Token: 0x06010325 RID: 66341 RVA: 0x0025D8F0 File Offset: 0x0025BAF0
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

		// Token: 0x06010326 RID: 66342 RVA: 0x0025D954 File Offset: 0x0025BB54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06010327 RID: 66343 RVA: 0x0025D960 File Offset: 0x0025BB60
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

		// Token: 0x0400677C RID: 26492
		private static readonly MessageParser<ParkourActivityChallenge> _parser = new MessageParser<ParkourActivityChallenge>(() => new ParkourActivityChallenge());

		// Token: 0x0400677D RID: 26493
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400677E RID: 26494
		public const int ChallengeIdFieldNumber = 1;

		// Token: 0x0400677F RID: 26495
		private int challengeId_;

		// Token: 0x04006780 RID: 26496
		public const int BeginTimeFieldNumber = 2;

		// Token: 0x04006781 RID: 26497
		private long beginTime_;

		// Token: 0x04006782 RID: 26498
		public const int EndTimeFieldNumber = 3;

		// Token: 0x04006783 RID: 26499
		private long endTime_;
	}
}
