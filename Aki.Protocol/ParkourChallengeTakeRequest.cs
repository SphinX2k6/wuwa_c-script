using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000BBD RID: 3005
	[NetMessage(EMessageId.ParkourChallengeTakeRequest)]
	public sealed class ParkourChallengeTakeRequest : IMessage<ParkourChallengeTakeRequest>, IMessage, IEquatable<ParkourChallengeTakeRequest>, IDeepCloneable<ParkourChallengeTakeRequest>, IBufferMessage
	{
		// Token: 0x06010495 RID: 66709 RVA: 0x00260706 File Offset: 0x0025E906
		[NullableContext(1)]
		public static ParkourChallengeTakeRequest Create()
		{
			return new ParkourChallengeTakeRequest();
		}

		// Token: 0x1700356B RID: 13675
		// (get) Token: 0x06010496 RID: 66710 RVA: 0x0026070D File Offset: 0x0025E90D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700356C RID: 13676
		// (get) Token: 0x06010497 RID: 66711 RVA: 0x00260710 File Offset: 0x0025E910
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ParkourChallengeTakeRequest.Descriptor;
			}
		}

		// Token: 0x06010498 RID: 66712 RVA: 0x00260717 File Offset: 0x0025E917
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ParkourChallengeTakeRequest()
		{
		}

		// Token: 0x06010499 RID: 66713 RVA: 0x0026071F File Offset: 0x0025E91F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ParkourChallengeTakeRequest(ParkourChallengeTakeRequest other) : this()
		{
			this.challengeId_ = other.challengeId_;
			this.scoreIndex_ = other.scoreIndex_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601049A RID: 66714 RVA: 0x00260750 File Offset: 0x0025E950
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ParkourChallengeTakeRequest Clone()
		{
			return new ParkourChallengeTakeRequest(this);
		}

		// Token: 0x1700356D RID: 13677
		// (get) Token: 0x0601049B RID: 66715 RVA: 0x00260758 File Offset: 0x0025E958
		// (set) Token: 0x0601049C RID: 66716 RVA: 0x00260760 File Offset: 0x0025E960
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

		// Token: 0x1700356E RID: 13678
		// (get) Token: 0x0601049D RID: 66717 RVA: 0x00260769 File Offset: 0x0025E969
		// (set) Token: 0x0601049E RID: 66718 RVA: 0x00260771 File Offset: 0x0025E971
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

		// Token: 0x0601049F RID: 66719 RVA: 0x0026077A File Offset: 0x0025E97A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ParkourChallengeTakeRequest);
		}

		// Token: 0x060104A0 RID: 66720 RVA: 0x00260788 File Offset: 0x0025E988
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ParkourChallengeTakeRequest other)
		{
			return other != null && (other == this || (this.ChallengeId == other.ChallengeId && this.ScoreIndex == other.ScoreIndex && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060104A1 RID: 66721 RVA: 0x002607C8 File Offset: 0x0025E9C8
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

		// Token: 0x060104A2 RID: 66722 RVA: 0x00260820 File Offset: 0x0025EA20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060104A3 RID: 66723 RVA: 0x0026082D File Offset: 0x0025EA2D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060104A4 RID: 66724 RVA: 0x00260838 File Offset: 0x0025EA38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ScoreIndex != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.ScoreIndex);
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

		// Token: 0x060104A5 RID: 66725 RVA: 0x00260894 File Offset: 0x0025EA94
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

		// Token: 0x060104A6 RID: 66726 RVA: 0x002608EC File Offset: 0x0025EAEC
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

		// Token: 0x060104A7 RID: 66727 RVA: 0x0026093C File Offset: 0x0025EB3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060104A8 RID: 66728 RVA: 0x00260948 File Offset: 0x0025EB48
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
				if (num != 72U)
				{
					if (num != 88U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ChallengeId = input.ReadInt32();
					}
				}
				else
				{
					this.ScoreIndex = input.ReadInt32();
				}
			}
		}

		// Token: 0x04006795 RID: 26517
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006796 RID: 26518
		public const int ChallengeIdFieldNumber = 11;

		// Token: 0x04006797 RID: 26519
		private int challengeId_;

		// Token: 0x04006798 RID: 26520
		public const int ScoreIndexFieldNumber = 9;

		// Token: 0x04006799 RID: 26521
		private int scoreIndex_;
	}
}
