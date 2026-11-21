using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000421 RID: 1057
	[NetMessage(EMessageId.EncircleChallengeCompleteRequest)]
	public sealed class EncircleChallengeCompleteRequest : IMessage<EncircleChallengeCompleteRequest>, IMessage, IEquatable<EncircleChallengeCompleteRequest>, IDeepCloneable<EncircleChallengeCompleteRequest>, IBufferMessage
	{
		// Token: 0x060065EB RID: 26091 RVA: 0x000F5681 File Offset: 0x000F3881
		[NullableContext(1)]
		public static EncircleChallengeCompleteRequest Create()
		{
			return new EncircleChallengeCompleteRequest();
		}

		// Token: 0x1700131F RID: 4895
		// (get) Token: 0x060065EC RID: 26092 RVA: 0x000F5688 File Offset: 0x000F3888
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001320 RID: 4896
		// (get) Token: 0x060065ED RID: 26093 RVA: 0x000F568B File Offset: 0x000F388B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EncircleChallengeCompleteRequest.Descriptor;
			}
		}

		// Token: 0x060065EE RID: 26094 RVA: 0x000F5692 File Offset: 0x000F3892
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EncircleChallengeCompleteRequest()
		{
		}

		// Token: 0x060065EF RID: 26095 RVA: 0x000F569C File Offset: 0x000F389C
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

		// Token: 0x060065F0 RID: 26096 RVA: 0x000F56FC File Offset: 0x000F38FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EncircleChallengeCompleteRequest Clone()
		{
			return new EncircleChallengeCompleteRequest(this);
		}

		// Token: 0x17001321 RID: 4897
		// (get) Token: 0x060065F1 RID: 26097 RVA: 0x000F5704 File Offset: 0x000F3904
		// (set) Token: 0x060065F2 RID: 26098 RVA: 0x000F570C File Offset: 0x000F390C
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

		// Token: 0x17001322 RID: 4898
		// (get) Token: 0x060065F3 RID: 26099 RVA: 0x000F5715 File Offset: 0x000F3915
		// (set) Token: 0x060065F4 RID: 26100 RVA: 0x000F571D File Offset: 0x000F391D
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

		// Token: 0x17001323 RID: 4899
		// (get) Token: 0x060065F5 RID: 26101 RVA: 0x000F5726 File Offset: 0x000F3926
		// (set) Token: 0x060065F6 RID: 26102 RVA: 0x000F572E File Offset: 0x000F392E
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

		// Token: 0x17001324 RID: 4900
		// (get) Token: 0x060065F7 RID: 26103 RVA: 0x000F5737 File Offset: 0x000F3937
		// (set) Token: 0x060065F8 RID: 26104 RVA: 0x000F573F File Offset: 0x000F393F
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

		// Token: 0x17001325 RID: 4901
		// (get) Token: 0x060065F9 RID: 26105 RVA: 0x000F5748 File Offset: 0x000F3948
		// (set) Token: 0x060065FA RID: 26106 RVA: 0x000F5750 File Offset: 0x000F3950
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

		// Token: 0x060065FB RID: 26107 RVA: 0x000F5759 File Offset: 0x000F3959
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EncircleChallengeCompleteRequest);
		}

		// Token: 0x060065FC RID: 26108 RVA: 0x000F5768 File Offset: 0x000F3968
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EncircleChallengeCompleteRequest other)
		{
			return other != null && (other == this || (this.ChallengeId == other.ChallengeId && this.Step == other.Step && this.Result == other.Result && this.ReducedDifficulty == other.ReducedDifficulty && this.GameSeconds == other.GameSeconds && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060065FD RID: 26109 RVA: 0x000F57E4 File Offset: 0x000F39E4
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

		// Token: 0x060065FE RID: 26110 RVA: 0x000F5887 File Offset: 0x000F3A87
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060065FF RID: 26111 RVA: 0x000F5894 File Offset: 0x000F3A94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006600 RID: 26112 RVA: 0x000F58A0 File Offset: 0x000F3AA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.GameSeconds != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.GameSeconds);
			}
			if (this.Result != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.Result);
			}
			if (this.ReducedDifficulty)
			{
				output.WriteRawTag(48);
				output.WriteBool(this.ReducedDifficulty);
			}
			if (this.Step != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.Step);
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

		// Token: 0x06006601 RID: 26113 RVA: 0x000F5950 File Offset: 0x000F3B50
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

		// Token: 0x06006602 RID: 26114 RVA: 0x000F59E4 File Offset: 0x000F3BE4
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

		// Token: 0x06006603 RID: 26115 RVA: 0x000F5A70 File Offset: 0x000F3C70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006604 RID: 26116 RVA: 0x000F5A7C File Offset: 0x000F3C7C
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
						this.GameSeconds = input.ReadInt32();
						continue;
					}
					if (num == 32U)
					{
						this.Result = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 48U)
					{
						this.ReducedDifficulty = input.ReadBool();
						continue;
					}
					if (num == 56U)
					{
						this.Step = input.ReadInt32();
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

		// Token: 0x04003956 RID: 14678
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003957 RID: 14679
		public const int ChallengeIdFieldNumber = 11;

		// Token: 0x04003958 RID: 14680
		private int challengeId_;

		// Token: 0x04003959 RID: 14681
		public const int StepFieldNumber = 7;

		// Token: 0x0400395A RID: 14682
		private int step_;

		// Token: 0x0400395B RID: 14683
		public const int ResultFieldNumber = 4;

		// Token: 0x0400395C RID: 14684
		private int result_;

		// Token: 0x0400395D RID: 14685
		public const int ReducedDifficultyFieldNumber = 6;

		// Token: 0x0400395E RID: 14686
		private bool reducedDifficulty_;

		// Token: 0x0400395F RID: 14687
		public const int GameSecondsFieldNumber = 2;

		// Token: 0x04003960 RID: 14688
		private int gameSeconds_;
	}
}
