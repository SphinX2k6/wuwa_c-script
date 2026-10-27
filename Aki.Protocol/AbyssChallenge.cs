using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000013 RID: 19
	public sealed class AbyssChallenge : IMessage<AbyssChallenge>, IMessage, IEquatable<AbyssChallenge>, IDeepCloneable<AbyssChallenge>, IBufferMessage
	{
		// Token: 0x06000FCF RID: 4047 RVA: 0x0002C69C File Offset: 0x0002A89C
		[NullableContext(1)]
		public static AbyssChallenge Create()
		{
			return new AbyssChallenge();
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x06000FD0 RID: 4048 RVA: 0x0002C6A3 File Offset: 0x0002A8A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<AbyssChallenge> Parser
		{
			get
			{
				return AbyssChallenge._parser;
			}
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x06000FD1 RID: 4049 RVA: 0x0002C6AA File Offset: 0x0002A8AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x06000FD2 RID: 4050 RVA: 0x0002C6AD File Offset: 0x0002A8AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AbyssChallenge.Descriptor;
			}
		}

		// Token: 0x06000FD3 RID: 4051 RVA: 0x0002C6B4 File Offset: 0x0002A8B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssChallenge()
		{
		}

		// Token: 0x06000FD4 RID: 4052 RVA: 0x0002C6BC File Offset: 0x0002A8BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssChallenge(AbyssChallenge other) : this()
		{
			this.challengeId_ = other.challengeId_;
			this.unlock_ = other.unlock_;
			this.canChallenge_ = other.canChallenge_;
			this.unlockTime_ = other.unlockTime_;
			this.isConditionUnlock_ = other.isConditionUnlock_;
			this.maxProgress_ = other.maxProgress_;
			this.minPassTime_ = other.minPassTime_;
			this.passed_ = other.passed_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06000FD5 RID: 4053 RVA: 0x0002C740 File Offset: 0x0002A940
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssChallenge Clone()
		{
			return new AbyssChallenge(this);
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x06000FD6 RID: 4054 RVA: 0x0002C748 File Offset: 0x0002A948
		// (set) Token: 0x06000FD7 RID: 4055 RVA: 0x0002C750 File Offset: 0x0002A950
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

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x06000FD8 RID: 4056 RVA: 0x0002C759 File Offset: 0x0002A959
		// (set) Token: 0x06000FD9 RID: 4057 RVA: 0x0002C761 File Offset: 0x0002A961
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Unlock
		{
			get
			{
				return this.unlock_;
			}
			set
			{
				this.unlock_ = value;
			}
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x06000FDA RID: 4058 RVA: 0x0002C76A File Offset: 0x0002A96A
		// (set) Token: 0x06000FDB RID: 4059 RVA: 0x0002C772 File Offset: 0x0002A972
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool CanChallenge
		{
			get
			{
				return this.canChallenge_;
			}
			set
			{
				this.canChallenge_ = value;
			}
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x06000FDC RID: 4060 RVA: 0x0002C77B File Offset: 0x0002A97B
		// (set) Token: 0x06000FDD RID: 4061 RVA: 0x0002C783 File Offset: 0x0002A983
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long UnlockTime
		{
			get
			{
				return this.unlockTime_;
			}
			set
			{
				this.unlockTime_ = value;
			}
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x06000FDE RID: 4062 RVA: 0x0002C78C File Offset: 0x0002A98C
		// (set) Token: 0x06000FDF RID: 4063 RVA: 0x0002C794 File Offset: 0x0002A994
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsConditionUnlock
		{
			get
			{
				return this.isConditionUnlock_;
			}
			set
			{
				this.isConditionUnlock_ = value;
			}
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x06000FE0 RID: 4064 RVA: 0x0002C79D File Offset: 0x0002A99D
		// (set) Token: 0x06000FE1 RID: 4065 RVA: 0x0002C7A5 File Offset: 0x0002A9A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int MaxProgress
		{
			get
			{
				return this.maxProgress_;
			}
			set
			{
				this.maxProgress_ = value;
			}
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x06000FE2 RID: 4066 RVA: 0x0002C7AE File Offset: 0x0002A9AE
		// (set) Token: 0x06000FE3 RID: 4067 RVA: 0x0002C7B6 File Offset: 0x0002A9B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int MinPassTime
		{
			get
			{
				return this.minPassTime_;
			}
			set
			{
				this.minPassTime_ = value;
			}
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x06000FE4 RID: 4068 RVA: 0x0002C7BF File Offset: 0x0002A9BF
		// (set) Token: 0x06000FE5 RID: 4069 RVA: 0x0002C7C7 File Offset: 0x0002A9C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Passed
		{
			get
			{
				return this.passed_;
			}
			set
			{
				this.passed_ = value;
			}
		}

		// Token: 0x06000FE6 RID: 4070 RVA: 0x0002C7D0 File Offset: 0x0002A9D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AbyssChallenge);
		}

		// Token: 0x06000FE7 RID: 4071 RVA: 0x0002C7E0 File Offset: 0x0002A9E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AbyssChallenge other)
		{
			return other != null && (other == this || (this.ChallengeId == other.ChallengeId && this.Unlock == other.Unlock && this.CanChallenge == other.CanChallenge && this.UnlockTime == other.UnlockTime && this.IsConditionUnlock == other.IsConditionUnlock && this.MaxProgress == other.MaxProgress && this.MinPassTime == other.MinPassTime && this.Passed == other.Passed && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06000FE8 RID: 4072 RVA: 0x0002C88C File Offset: 0x0002AA8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ChallengeId != 0)
			{
				num ^= this.ChallengeId.GetHashCode();
			}
			if (this.Unlock)
			{
				num ^= this.Unlock.GetHashCode();
			}
			if (this.CanChallenge)
			{
				num ^= this.CanChallenge.GetHashCode();
			}
			if (this.UnlockTime != 0L)
			{
				num ^= this.UnlockTime.GetHashCode();
			}
			if (this.IsConditionUnlock)
			{
				num ^= this.IsConditionUnlock.GetHashCode();
			}
			if (this.MaxProgress != 0)
			{
				num ^= this.MaxProgress.GetHashCode();
			}
			if (this.MinPassTime != 0)
			{
				num ^= this.MinPassTime.GetHashCode();
			}
			if (this.Passed)
			{
				num ^= this.Passed.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06000FE9 RID: 4073 RVA: 0x0002C97A File Offset: 0x0002AB7A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06000FEA RID: 4074 RVA: 0x0002C987 File Offset: 0x0002AB87
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06000FEB RID: 4075 RVA: 0x0002C990 File Offset: 0x0002AB90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ChallengeId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.ChallengeId);
			}
			if (this.Unlock)
			{
				output.WriteRawTag(16);
				output.WriteBool(this.Unlock);
			}
			if (this.CanChallenge)
			{
				output.WriteRawTag(24);
				output.WriteBool(this.CanChallenge);
			}
			if (this.UnlockTime != 0L)
			{
				output.WriteRawTag(32);
				output.WriteInt64(this.UnlockTime);
			}
			if (this.IsConditionUnlock)
			{
				output.WriteRawTag(40);
				output.WriteBool(this.IsConditionUnlock);
			}
			if (this.MaxProgress != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.MaxProgress);
			}
			if (this.MinPassTime != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.MinPassTime);
			}
			if (this.Passed)
			{
				output.WriteRawTag(64);
				output.WriteBool(this.Passed);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06000FEC RID: 4076 RVA: 0x0002CA90 File Offset: 0x0002AC90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ChallengeId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ChallengeId);
			}
			if (this.Unlock)
			{
				num += 2;
			}
			if (this.CanChallenge)
			{
				num += 2;
			}
			if (this.UnlockTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.UnlockTime);
			}
			if (this.IsConditionUnlock)
			{
				num += 2;
			}
			if (this.MaxProgress != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.MaxProgress);
			}
			if (this.MinPassTime != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.MinPassTime);
			}
			if (this.Passed)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06000FED RID: 4077 RVA: 0x0002CB48 File Offset: 0x0002AD48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AbyssChallenge other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ChallengeId != 0)
			{
				this.ChallengeId = other.ChallengeId;
			}
			if (other.Unlock)
			{
				this.Unlock = other.Unlock;
			}
			if (other.CanChallenge)
			{
				this.CanChallenge = other.CanChallenge;
			}
			if (other.UnlockTime != 0L)
			{
				this.UnlockTime = other.UnlockTime;
			}
			if (other.IsConditionUnlock)
			{
				this.IsConditionUnlock = other.IsConditionUnlock;
			}
			if (other.MaxProgress != 0)
			{
				this.MaxProgress = other.MaxProgress;
			}
			if (other.MinPassTime != 0)
			{
				this.MinPassTime = other.MinPassTime;
			}
			if (other.Passed)
			{
				this.Passed = other.Passed;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06000FEE RID: 4078 RVA: 0x0002CC10 File Offset: 0x0002AE10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06000FEF RID: 4079 RVA: 0x0002CC1C File Offset: 0x0002AE1C
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
					if (num <= 16U)
					{
						if (num == 8U)
						{
							this.ChallengeId = input.ReadInt32();
							continue;
						}
						if (num == 16U)
						{
							this.Unlock = input.ReadBool();
							continue;
						}
					}
					else
					{
						if (num == 24U)
						{
							this.CanChallenge = input.ReadBool();
							continue;
						}
						if (num == 32U)
						{
							this.UnlockTime = input.ReadInt64();
							continue;
						}
					}
				}
				else if (num <= 48U)
				{
					if (num == 40U)
					{
						this.IsConditionUnlock = input.ReadBool();
						continue;
					}
					if (num == 48U)
					{
						this.MaxProgress = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 56U)
					{
						this.MinPassTime = input.ReadInt32();
						continue;
					}
					if (num == 64U)
					{
						this.Passed = input.ReadBool();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04001ED4 RID: 7892
		private static readonly MessageParser<AbyssChallenge> _parser = new MessageParser<AbyssChallenge>(() => new AbyssChallenge());

		// Token: 0x04001ED5 RID: 7893
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001ED6 RID: 7894
		public const int ChallengeIdFieldNumber = 1;

		// Token: 0x04001ED7 RID: 7895
		private int challengeId_;

		// Token: 0x04001ED8 RID: 7896
		public const int UnlockFieldNumber = 2;

		// Token: 0x04001ED9 RID: 7897
		private bool unlock_;

		// Token: 0x04001EDA RID: 7898
		public const int CanChallengeFieldNumber = 3;

		// Token: 0x04001EDB RID: 7899
		private bool canChallenge_;

		// Token: 0x04001EDC RID: 7900
		public const int UnlockTimeFieldNumber = 4;

		// Token: 0x04001EDD RID: 7901
		private long unlockTime_;

		// Token: 0x04001EDE RID: 7902
		public const int IsConditionUnlockFieldNumber = 5;

		// Token: 0x04001EDF RID: 7903
		private bool isConditionUnlock_;

		// Token: 0x04001EE0 RID: 7904
		public const int MaxProgressFieldNumber = 6;

		// Token: 0x04001EE1 RID: 7905
		private int maxProgress_;

		// Token: 0x04001EE2 RID: 7906
		public const int MinPassTimeFieldNumber = 7;

		// Token: 0x04001EE3 RID: 7907
		private int minPassTime_;

		// Token: 0x04001EE4 RID: 7908
		public const int PassedFieldNumber = 8;

		// Token: 0x04001EE5 RID: 7909
		private bool passed_;
	}
}
