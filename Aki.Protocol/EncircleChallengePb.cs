using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200043A RID: 1082
	public sealed class EncircleChallengePb : IMessage<EncircleChallengePb>, IMessage, IEquatable<EncircleChallengePb>, IDeepCloneable<EncircleChallengePb>, IBufferMessage
	{
		// Token: 0x060067A7 RID: 26535 RVA: 0x000F8E75 File Offset: 0x000F7075
		[NullableContext(1)]
		public static EncircleChallengePb Create()
		{
			return new EncircleChallengePb();
		}

		// Token: 0x1700137E RID: 4990
		// (get) Token: 0x060067A8 RID: 26536 RVA: 0x000F8E7C File Offset: 0x000F707C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<EncircleChallengePb> Parser
		{
			get
			{
				return EncircleChallengePb._parser;
			}
		}

		// Token: 0x1700137F RID: 4991
		// (get) Token: 0x060067A9 RID: 26537 RVA: 0x000F8E83 File Offset: 0x000F7083
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001380 RID: 4992
		// (get) Token: 0x060067AA RID: 26538 RVA: 0x000F8E86 File Offset: 0x000F7086
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EncircleChallengePb.Descriptor;
			}
		}

		// Token: 0x060067AB RID: 26539 RVA: 0x000F8E8D File Offset: 0x000F708D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EncircleChallengePb()
		{
		}

		// Token: 0x060067AC RID: 26540 RVA: 0x000F8E98 File Offset: 0x000F7098
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EncircleChallengePb(EncircleChallengePb other) : this()
		{
			this.challengeId_ = other.challengeId_;
			this.openTime_ = other.openTime_;
			this.pass_ = other.pass_;
			this.minStep_ = other.minStep_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060067AD RID: 26541 RVA: 0x000F8EEC File Offset: 0x000F70EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EncircleChallengePb Clone()
		{
			return new EncircleChallengePb(this);
		}

		// Token: 0x17001381 RID: 4993
		// (get) Token: 0x060067AE RID: 26542 RVA: 0x000F8EF4 File Offset: 0x000F70F4
		// (set) Token: 0x060067AF RID: 26543 RVA: 0x000F8EFC File Offset: 0x000F70FC
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

		// Token: 0x17001382 RID: 4994
		// (get) Token: 0x060067B0 RID: 26544 RVA: 0x000F8F05 File Offset: 0x000F7105
		// (set) Token: 0x060067B1 RID: 26545 RVA: 0x000F8F0D File Offset: 0x000F710D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long OpenTime
		{
			get
			{
				return this.openTime_;
			}
			set
			{
				this.openTime_ = value;
			}
		}

		// Token: 0x17001383 RID: 4995
		// (get) Token: 0x060067B2 RID: 26546 RVA: 0x000F8F16 File Offset: 0x000F7116
		// (set) Token: 0x060067B3 RID: 26547 RVA: 0x000F8F1E File Offset: 0x000F711E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Pass
		{
			get
			{
				return this.pass_;
			}
			set
			{
				this.pass_ = value;
			}
		}

		// Token: 0x17001384 RID: 4996
		// (get) Token: 0x060067B4 RID: 26548 RVA: 0x000F8F27 File Offset: 0x000F7127
		// (set) Token: 0x060067B5 RID: 26549 RVA: 0x000F8F2F File Offset: 0x000F712F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int MinStep
		{
			get
			{
				return this.minStep_;
			}
			set
			{
				this.minStep_ = value;
			}
		}

		// Token: 0x060067B6 RID: 26550 RVA: 0x000F8F38 File Offset: 0x000F7138
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EncircleChallengePb);
		}

		// Token: 0x060067B7 RID: 26551 RVA: 0x000F8F48 File Offset: 0x000F7148
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EncircleChallengePb other)
		{
			return other != null && (other == this || (this.ChallengeId == other.ChallengeId && this.OpenTime == other.OpenTime && this.Pass == other.Pass && this.MinStep == other.MinStep && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060067B8 RID: 26552 RVA: 0x000F8FB4 File Offset: 0x000F71B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ChallengeId != 0)
			{
				num ^= this.ChallengeId.GetHashCode();
			}
			if (this.OpenTime != 0L)
			{
				num ^= this.OpenTime.GetHashCode();
			}
			if (this.Pass)
			{
				num ^= this.Pass.GetHashCode();
			}
			if (this.MinStep != 0)
			{
				num ^= this.MinStep.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060067B9 RID: 26553 RVA: 0x000F903E File Offset: 0x000F723E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060067BA RID: 26554 RVA: 0x000F904B File Offset: 0x000F724B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060067BB RID: 26555 RVA: 0x000F9054 File Offset: 0x000F7254
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ChallengeId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.ChallengeId);
			}
			if (this.OpenTime != 0L)
			{
				output.WriteRawTag(16);
				output.WriteInt64(this.OpenTime);
			}
			if (this.Pass)
			{
				output.WriteRawTag(24);
				output.WriteBool(this.Pass);
			}
			if (this.MinStep != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.MinStep);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060067BC RID: 26556 RVA: 0x000F90E4 File Offset: 0x000F72E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ChallengeId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ChallengeId);
			}
			if (this.OpenTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.OpenTime);
			}
			if (this.Pass)
			{
				num += 2;
			}
			if (this.MinStep != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.MinStep);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060067BD RID: 26557 RVA: 0x000F9160 File Offset: 0x000F7360
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EncircleChallengePb other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ChallengeId != 0)
			{
				this.ChallengeId = other.ChallengeId;
			}
			if (other.OpenTime != 0L)
			{
				this.OpenTime = other.OpenTime;
			}
			if (other.Pass)
			{
				this.Pass = other.Pass;
			}
			if (other.MinStep != 0)
			{
				this.MinStep = other.MinStep;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060067BE RID: 26558 RVA: 0x000F91D8 File Offset: 0x000F73D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060067BF RID: 26559 RVA: 0x000F91E4 File Offset: 0x000F73E4
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
				if (num <= 16U)
				{
					if (num == 8U)
					{
						this.ChallengeId = input.ReadInt32();
						continue;
					}
					if (num == 16U)
					{
						this.OpenTime = input.ReadInt64();
						continue;
					}
				}
				else
				{
					if (num == 24U)
					{
						this.Pass = input.ReadBool();
						continue;
					}
					if (num == 40U)
					{
						this.MinStep = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04003977 RID: 14711
		private static readonly MessageParser<EncircleChallengePb> _parser = new MessageParser<EncircleChallengePb>(() => new EncircleChallengePb());

		// Token: 0x04003978 RID: 14712
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003979 RID: 14713
		public const int ChallengeIdFieldNumber = 1;

		// Token: 0x0400397A RID: 14714
		private int challengeId_;

		// Token: 0x0400397B RID: 14715
		public const int OpenTimeFieldNumber = 2;

		// Token: 0x0400397C RID: 14716
		private long openTime_;

		// Token: 0x0400397D RID: 14717
		public const int PassFieldNumber = 3;

		// Token: 0x0400397E RID: 14718
		private bool pass_;

		// Token: 0x0400397F RID: 14719
		public const int MinStepFieldNumber = 5;

		// Token: 0x04003980 RID: 14720
		private int minStep_;
	}
}
