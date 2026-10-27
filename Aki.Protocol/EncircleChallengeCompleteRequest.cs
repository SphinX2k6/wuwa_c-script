using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000438 RID: 1080
	[NetMessage(EMessageId.EncircleChallengeCompleteRequest)]
	public sealed class EncircleChallengeCompleteRequest : IMessage<EncircleChallengeCompleteRequest>, IMessage, IEquatable<EncircleChallengeCompleteRequest>, IDeepCloneable<EncircleChallengeCompleteRequest>, IBufferMessage
	{
		// Token: 0x0600677B RID: 26491 RVA: 0x000F87FD File Offset: 0x000F69FD
		[NullableContext(1)]
		public static EncircleChallengeCompleteRequest Create()
		{
			return new EncircleChallengeCompleteRequest();
		}

		// Token: 0x17001374 RID: 4980
		// (get) Token: 0x0600677C RID: 26492 RVA: 0x000F8804 File Offset: 0x000F6A04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001375 RID: 4981
		// (get) Token: 0x0600677D RID: 26493 RVA: 0x000F8807 File Offset: 0x000F6A07
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EncircleChallengeCompleteRequest.Descriptor;
			}
		}

		// Token: 0x0600677E RID: 26494 RVA: 0x000F880E File Offset: 0x000F6A0E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EncircleChallengeCompleteRequest()
		{
		}

		// Token: 0x0600677F RID: 26495 RVA: 0x000F8818 File Offset: 0x000F6A18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EncircleChallengeCompleteRequest(EncircleChallengeCompleteRequest other) : this()
		{
			this.challengeId_ = other.challengeId_;
			this.step_ = other.step_;
			this.result_ = other.result_;
			this.reducedDifficulty_ = other.reducedDifficulty_;
			this.gameSeconds_ = other.gameSeconds_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006780 RID: 26496 RVA: 0x000F8878 File Offset: 0x000F6A78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EncircleChallengeCompleteRequest Clone()
		{
			return new EncircleChallengeCompleteRequest(this);
		}

		// Token: 0x17001376 RID: 4982
		// (get) Token: 0x06006781 RID: 26497 RVA: 0x000F8880 File Offset: 0x000F6A80
		// (set) Token: 0x06006782 RID: 26498 RVA: 0x000F8888 File Offset: 0x000F6A88
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

		// Token: 0x17001377 RID: 4983
		// (get) Token: 0x06006783 RID: 26499 RVA: 0x000F8891 File Offset: 0x000F6A91
		// (set) Token: 0x06006784 RID: 26500 RVA: 0x000F8899 File Offset: 0x000F6A99
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Step
		{
			get
			{
				return this.step_;
			}
			set
			{
				this.step_ = value;
			}
		}

		// Token: 0x17001378 RID: 4984
		// (get) Token: 0x06006785 RID: 26501 RVA: 0x000F88A2 File Offset: 0x000F6AA2
		// (set) Token: 0x06006786 RID: 26502 RVA: 0x000F88AA File Offset: 0x000F6AAA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Result
		{
			get
			{
				return this.result_;
			}
			set
			{
				this.result_ = value;
			}
		}

		// Token: 0x17001379 RID: 4985
		// (get) Token: 0x06006787 RID: 26503 RVA: 0x000F88B3 File Offset: 0x000F6AB3
		// (set) Token: 0x06006788 RID: 26504 RVA: 0x000F88BB File Offset: 0x000F6ABB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool ReducedDifficulty
		{
			get
			{
				return this.reducedDifficulty_;
			}
			set
			{
				this.reducedDifficulty_ = value;
			}
		}

		// Token: 0x1700137A RID: 4986
		// (get) Token: 0x06006789 RID: 26505 RVA: 0x000F88C4 File Offset: 0x000F6AC4
		// (set) Token: 0x0600678A RID: 26506 RVA: 0x000F88CC File Offset: 0x000F6ACC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int GameSeconds
		{
			get
			{
				return this.gameSeconds_;
			}
			set
			{
				this.gameSeconds_ = value;
			}
		}

		// Token: 0x0600678B RID: 26507 RVA: 0x000F88D5 File Offset: 0x000F6AD5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EncircleChallengeCompleteRequest);
		}

		// Token: 0x0600678C RID: 26508 RVA: 0x000F88E4 File Offset: 0x000F6AE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EncircleChallengeCompleteRequest other)
		{
			return other != null && (other == this || (this.ChallengeId == other.ChallengeId && this.Step == other.Step && this.Result == other.Result && this.ReducedDifficulty == other.ReducedDifficulty && this.GameSeconds == other.GameSeconds && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600678D RID: 26509 RVA: 0x000F8960 File Offset: 0x000F6B60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ChallengeId != 0)
			{
				num ^= this.ChallengeId.GetHashCode();
			}
			if (this.Step != 0)
			{
				num ^= this.Step.GetHashCode();
			}
			if (this.Result != 0)
			{
				num ^= this.Result.GetHashCode();
			}
			if (this.ReducedDifficulty)
			{
				num ^= this.ReducedDifficulty.GetHashCode();
			}
			if (this.GameSeconds != 0)
			{
				num ^= this.GameSeconds.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600678E RID: 26510 RVA: 0x000F8A03 File Offset: 0x000F6C03
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600678F RID: 26511 RVA: 0x000F8A10 File Offset: 0x000F6C10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006790 RID: 26512 RVA: 0x000F8A1C File Offset: 0x000F6C1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Result != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.Result);
			}
			if (this.ChallengeId != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.ChallengeId);
			}
			if (this.Step != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.Step);
			}
			if (this.ReducedDifficulty)
			{
				output.WriteRawTag(96);
				output.WriteBool(this.ReducedDifficulty);
			}
			if (this.GameSeconds != 0)
			{
				output.WriteRawTag(120);
				output.WriteInt32(this.GameSeconds);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006791 RID: 26513 RVA: 0x000F8ACC File Offset: 0x000F6CCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ChallengeId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ChallengeId);
			}
			if (this.Step != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Step);
			}
			if (this.Result != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Result);
			}
			if (this.ReducedDifficulty)
			{
				num += 2;
			}
			if (this.GameSeconds != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.GameSeconds);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06006792 RID: 26514 RVA: 0x000F8B60 File Offset: 0x000F6D60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EncircleChallengeCompleteRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ChallengeId != 0)
			{
				this.ChallengeId = other.ChallengeId;
			}
			if (other.Step != 0)
			{
				this.Step = other.Step;
			}
			if (other.Result != 0)
			{
				this.Result = other.Result;
			}
			if (other.ReducedDifficulty)
			{
				this.ReducedDifficulty = other.ReducedDifficulty;
			}
			if (other.GameSeconds != 0)
			{
				this.GameSeconds = other.GameSeconds;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06006793 RID: 26515 RVA: 0x000F8BEC File Offset: 0x000F6DEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006794 RID: 26516 RVA: 0x000F8BF8 File Offset: 0x000F6DF8
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
						this.Result = input.ReadInt32();
						continue;
					}
					if (num == 48U)
					{
						this.ChallengeId = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 72U)
					{
						this.Step = input.ReadInt32();
						continue;
					}
					if (num == 96U)
					{
						this.ReducedDifficulty = input.ReadBool();
						continue;
					}
					if (num == 120U)
					{
						this.GameSeconds = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04003969 RID: 14697
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400396A RID: 14698
		public const int ChallengeIdFieldNumber = 6;

		// Token: 0x0400396B RID: 14699
		private int challengeId_;

		// Token: 0x0400396C RID: 14700
		public const int StepFieldNumber = 9;

		// Token: 0x0400396D RID: 14701
		private int step_;

		// Token: 0x0400396E RID: 14702
		public const int ResultFieldNumber = 4;

		// Token: 0x0400396F RID: 14703
		private int result_;

		// Token: 0x04003970 RID: 14704
		public const int ReducedDifficultyFieldNumber = 12;

		// Token: 0x04003971 RID: 14705
		private bool reducedDifficulty_;

		// Token: 0x04003972 RID: 14706
		public const int GameSecondsFieldNumber = 15;

		// Token: 0x04003973 RID: 14707
		private int gameSeconds_;
	}
}
