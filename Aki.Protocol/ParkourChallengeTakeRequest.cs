using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000BAD RID: 2989
	[NetMessage(EMessageId.ParkourChallengeTakeRequest)]
	public sealed class ParkourChallengeTakeRequest : IMessage<ParkourChallengeTakeRequest>, IMessage, IEquatable<ParkourChallengeTakeRequest>, IDeepCloneable<ParkourChallengeTakeRequest>, IBufferMessage
	{
		// Token: 0x06010391 RID: 66449 RVA: 0x0025E84E File Offset: 0x0025CA4E
		[NullableContext(1)]
		public static ParkourChallengeTakeRequest Create()
		{
			return new ParkourChallengeTakeRequest();
		}

		// Token: 0x17003532 RID: 13618
		// (get) Token: 0x06010392 RID: 66450 RVA: 0x0025E855 File Offset: 0x0025CA55
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003533 RID: 13619
		// (get) Token: 0x06010393 RID: 66451 RVA: 0x0025E858 File Offset: 0x0025CA58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ParkourChallengeTakeRequest.Descriptor;
			}
		}

		// Token: 0x06010394 RID: 66452 RVA: 0x0025E85F File Offset: 0x0025CA5F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ParkourChallengeTakeRequest()
		{
		}

		// Token: 0x06010395 RID: 66453 RVA: 0x0025E867 File Offset: 0x0025CA67
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ParkourChallengeTakeRequest(ParkourChallengeTakeRequest other) : this()
		{
			this.challengeId_ = other.challengeId_;
			this.scoreIndex_ = other.scoreIndex_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06010396 RID: 66454 RVA: 0x0025E898 File Offset: 0x0025CA98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ParkourChallengeTakeRequest Clone()
		{
			return new ParkourChallengeTakeRequest(this);
		}

		// Token: 0x17003534 RID: 13620
		// (get) Token: 0x06010397 RID: 66455 RVA: 0x0025E8A0 File Offset: 0x0025CAA0
		// (set) Token: 0x06010398 RID: 66456 RVA: 0x0025E8A8 File Offset: 0x0025CAA8
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

		// Token: 0x17003535 RID: 13621
		// (get) Token: 0x06010399 RID: 66457 RVA: 0x0025E8B1 File Offset: 0x0025CAB1
		// (set) Token: 0x0601039A RID: 66458 RVA: 0x0025E8B9 File Offset: 0x0025CAB9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ScoreIndex
		{
			get
			{
				return this.scoreIndex_;
			}
			set
			{
				this.scoreIndex_ = value;
			}
		}

		// Token: 0x0601039B RID: 66459 RVA: 0x0025E8C2 File Offset: 0x0025CAC2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ParkourChallengeTakeRequest);
		}

		// Token: 0x0601039C RID: 66460 RVA: 0x0025E8D0 File Offset: 0x0025CAD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ParkourChallengeTakeRequest other)
		{
			return other != null && (other == this || (this.ChallengeId == other.ChallengeId && this.ScoreIndex == other.ScoreIndex && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601039D RID: 66461 RVA: 0x0025E910 File Offset: 0x0025CB10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ChallengeId != 0)
			{
				num ^= this.ChallengeId.GetHashCode();
			}
			if (this.ScoreIndex != 0)
			{
				num ^= this.ScoreIndex.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601039E RID: 66462 RVA: 0x0025E968 File Offset: 0x0025CB68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601039F RID: 66463 RVA: 0x0025E975 File Offset: 0x0025CB75
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060103A0 RID: 66464 RVA: 0x0025E980 File Offset: 0x0025CB80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ChallengeId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.ChallengeId);
			}
			if (this.ScoreIndex != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.ScoreIndex);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060103A1 RID: 66465 RVA: 0x0025E9DC File Offset: 0x0025CBDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ChallengeId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ChallengeId);
			}
			if (this.ScoreIndex != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ScoreIndex);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060103A2 RID: 66466 RVA: 0x0025EA34 File Offset: 0x0025CC34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ParkourChallengeTakeRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ChallengeId != 0)
			{
				this.ChallengeId = other.ChallengeId;
			}
			if (other.ScoreIndex != 0)
			{
				this.ScoreIndex = other.ScoreIndex;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060103A3 RID: 66467 RVA: 0x0025EA84 File Offset: 0x0025CC84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060103A4 RID: 66468 RVA: 0x0025EA90 File Offset: 0x0025CC90
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
				if (num != 24U)
				{
					if (num != 80U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ScoreIndex = input.ReadInt32();
					}
				}
				else
				{
					this.ChallengeId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040067A5 RID: 26533
		private UnknownFieldSet _unknownFields;

		// Token: 0x040067A6 RID: 26534
		public const int ChallengeIdFieldNumber = 3;

		// Token: 0x040067A7 RID: 26535
		private int challengeId_;

		// Token: 0x040067A8 RID: 26536
		public const int ScoreIndexFieldNumber = 10;

		// Token: 0x040067A9 RID: 26537
		private int scoreIndex_;
	}
}
