using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000423 RID: 1059
	public sealed class EncircleChallengePb : IMessage<EncircleChallengePb>, IMessage, IEquatable<EncircleChallengePb>, IDeepCloneable<EncircleChallengePb>, IBufferMessage
	{
		// Token: 0x06006617 RID: 26135 RVA: 0x000F5CF9 File Offset: 0x000F3EF9
		[NullableContext(1)]
		public static EncircleChallengePb Create()
		{
			return new EncircleChallengePb();
		}

		// Token: 0x17001329 RID: 4905
		// (get) Token: 0x06006618 RID: 26136 RVA: 0x000F5D00 File Offset: 0x000F3F00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<EncircleChallengePb> Parser
		{
			get
			{
				return EncircleChallengePb._parser;
			}
		}

		// Token: 0x1700132A RID: 4906
		// (get) Token: 0x06006619 RID: 26137 RVA: 0x000F5D07 File Offset: 0x000F3F07
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700132B RID: 4907
		// (get) Token: 0x0600661A RID: 26138 RVA: 0x000F5D0A File Offset: 0x000F3F0A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EncircleChallengePb.Descriptor;
			}
		}

		// Token: 0x0600661B RID: 26139 RVA: 0x000F5D11 File Offset: 0x000F3F11
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EncircleChallengePb()
		{
		}

		// Token: 0x0600661C RID: 26140 RVA: 0x000F5D1C File Offset: 0x000F3F1C
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

		// Token: 0x0600661D RID: 26141 RVA: 0x000F5D70 File Offset: 0x000F3F70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EncircleChallengePb Clone()
		{
			return new EncircleChallengePb(this);
		}

		// Token: 0x1700132C RID: 4908
		// (get) Token: 0x0600661E RID: 26142 RVA: 0x000F5D78 File Offset: 0x000F3F78
		// (set) Token: 0x0600661F RID: 26143 RVA: 0x000F5D80 File Offset: 0x000F3F80
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

		// Token: 0x1700132D RID: 4909
		// (get) Token: 0x06006620 RID: 26144 RVA: 0x000F5D89 File Offset: 0x000F3F89
		// (set) Token: 0x06006621 RID: 26145 RVA: 0x000F5D91 File Offset: 0x000F3F91
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

		// Token: 0x1700132E RID: 4910
		// (get) Token: 0x06006622 RID: 26146 RVA: 0x000F5D9A File Offset: 0x000F3F9A
		// (set) Token: 0x06006623 RID: 26147 RVA: 0x000F5DA2 File Offset: 0x000F3FA2
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

		// Token: 0x1700132F RID: 4911
		// (get) Token: 0x06006624 RID: 26148 RVA: 0x000F5DAB File Offset: 0x000F3FAB
		// (set) Token: 0x06006625 RID: 26149 RVA: 0x000F5DB3 File Offset: 0x000F3FB3
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

		// Token: 0x06006626 RID: 26150 RVA: 0x000F5DBC File Offset: 0x000F3FBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EncircleChallengePb);
		}

		// Token: 0x06006627 RID: 26151 RVA: 0x000F5DCC File Offset: 0x000F3FCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EncircleChallengePb other)
		{
			return other != null && (other == this || (this.ChallengeId == other.ChallengeId && this.OpenTime == other.OpenTime && this.Pass == other.Pass && this.MinStep == other.MinStep && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006628 RID: 26152 RVA: 0x000F5E38 File Offset: 0x000F4038
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

		// Token: 0x06006629 RID: 26153 RVA: 0x000F5EC2 File Offset: 0x000F40C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600662A RID: 26154 RVA: 0x000F5ECF File Offset: 0x000F40CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600662B RID: 26155 RVA: 0x000F5ED8 File Offset: 0x000F40D8
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

		// Token: 0x0600662C RID: 26156 RVA: 0x000F5F68 File Offset: 0x000F4168
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

		// Token: 0x0600662D RID: 26157 RVA: 0x000F5FE4 File Offset: 0x000F41E4
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

		// Token: 0x0600662E RID: 26158 RVA: 0x000F605C File Offset: 0x000F425C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600662F RID: 26159 RVA: 0x000F6068 File Offset: 0x000F4268
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

		// Token: 0x04003964 RID: 14692
		private static readonly MessageParser<EncircleChallengePb> _parser = new MessageParser<EncircleChallengePb>(() => new EncircleChallengePb());

		// Token: 0x04003965 RID: 14693
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003966 RID: 14694
		public const int ChallengeIdFieldNumber = 1;

		// Token: 0x04003967 RID: 14695
		private int challengeId_;

		// Token: 0x04003968 RID: 14696
		public const int OpenTimeFieldNumber = 2;

		// Token: 0x04003969 RID: 14697
		private long openTime_;

		// Token: 0x0400396A RID: 14698
		public const int PassFieldNumber = 3;

		// Token: 0x0400396B RID: 14699
		private bool pass_;

		// Token: 0x0400396C RID: 14700
		public const int MinStepFieldNumber = 5;

		// Token: 0x0400396D RID: 14701
		private int minStep_;
	}
}
