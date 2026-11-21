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
		// Token: 0x06000FFA RID: 4090 RVA: 0x0002CC4A File Offset: 0x0002AE4A
		[NullableContext(1)]
		public static AbyssChallenge Create()
		{
			return new AbyssChallenge();
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x06000FFB RID: 4091 RVA: 0x0002CC51 File Offset: 0x0002AE51
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
		// (get) Token: 0x06000FFC RID: 4092 RVA: 0x0002CC58 File Offset: 0x0002AE58
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
		// (get) Token: 0x06000FFD RID: 4093 RVA: 0x0002CC5B File Offset: 0x0002AE5B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AbyssChallenge.Descriptor;
			}
		}

		// Token: 0x06000FFE RID: 4094 RVA: 0x0002CC62 File Offset: 0x0002AE62
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssChallenge()
		{
		}

		// Token: 0x06000FFF RID: 4095 RVA: 0x0002CC6C File Offset: 0x0002AE6C
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

		// Token: 0x06001000 RID: 4096 RVA: 0x0002CCF0 File Offset: 0x0002AEF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssChallenge Clone()
		{
			return new AbyssChallenge(this);
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x06001001 RID: 4097 RVA: 0x0002CCF8 File Offset: 0x0002AEF8
		// (set) Token: 0x06001002 RID: 4098 RVA: 0x0002CD00 File Offset: 0x0002AF00
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
		// (get) Token: 0x06001003 RID: 4099 RVA: 0x0002CD09 File Offset: 0x0002AF09
		// (set) Token: 0x06001004 RID: 4100 RVA: 0x0002CD11 File Offset: 0x0002AF11
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
		// (get) Token: 0x06001005 RID: 4101 RVA: 0x0002CD1A File Offset: 0x0002AF1A
		// (set) Token: 0x06001006 RID: 4102 RVA: 0x0002CD22 File Offset: 0x0002AF22
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
		// (get) Token: 0x06001007 RID: 4103 RVA: 0x0002CD2B File Offset: 0x0002AF2B
		// (set) Token: 0x06001008 RID: 4104 RVA: 0x0002CD33 File Offset: 0x0002AF33
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
		// (get) Token: 0x06001009 RID: 4105 RVA: 0x0002CD3C File Offset: 0x0002AF3C
		// (set) Token: 0x0600100A RID: 4106 RVA: 0x0002CD44 File Offset: 0x0002AF44
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
		// (get) Token: 0x0600100B RID: 4107 RVA: 0x0002CD4D File Offset: 0x0002AF4D
		// (set) Token: 0x0600100C RID: 4108 RVA: 0x0002CD55 File Offset: 0x0002AF55
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
		// (get) Token: 0x0600100D RID: 4109 RVA: 0x0002CD5E File Offset: 0x0002AF5E
		// (set) Token: 0x0600100E RID: 4110 RVA: 0x0002CD66 File Offset: 0x0002AF66
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
		// (get) Token: 0x0600100F RID: 4111 RVA: 0x0002CD6F File Offset: 0x0002AF6F
		// (set) Token: 0x06001010 RID: 4112 RVA: 0x0002CD77 File Offset: 0x0002AF77
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

		// Token: 0x06001011 RID: 4113 RVA: 0x0002CD80 File Offset: 0x0002AF80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AbyssChallenge);
		}

		// Token: 0x06001012 RID: 4114 RVA: 0x0002CD90 File Offset: 0x0002AF90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AbyssChallenge other)
		{
			return other != null && (other == this || (this.ChallengeId == other.ChallengeId && this.Unlock == other.Unlock && this.CanChallenge == other.CanChallenge && this.UnlockTime == other.UnlockTime && this.IsConditionUnlock == other.IsConditionUnlock && this.MaxProgress == other.MaxProgress && this.MinPassTime == other.MinPassTime && this.Passed == other.Passed && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001013 RID: 4115 RVA: 0x0002CE3C File Offset: 0x0002B03C
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

		// Token: 0x06001014 RID: 4116 RVA: 0x0002CF2A File Offset: 0x0002B12A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06001015 RID: 4117 RVA: 0x0002CF37 File Offset: 0x0002B137
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001016 RID: 4118 RVA: 0x0002CF40 File Offset: 0x0002B140
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

		// Token: 0x06001017 RID: 4119 RVA: 0x0002D040 File Offset: 0x0002B240
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

		// Token: 0x06001018 RID: 4120 RVA: 0x0002D0F8 File Offset: 0x0002B2F8
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

		// Token: 0x06001019 RID: 4121 RVA: 0x0002D1C0 File Offset: 0x0002B3C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600101A RID: 4122 RVA: 0x0002D1CC File Offset: 0x0002B3CC
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

		// Token: 0x04001F2A RID: 7978
		private static readonly MessageParser<AbyssChallenge> _parser = new MessageParser<AbyssChallenge>(() => new AbyssChallenge());

		// Token: 0x04001F2B RID: 7979
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001F2C RID: 7980
		public const int ChallengeIdFieldNumber = 1;

		// Token: 0x04001F2D RID: 7981
		private int challengeId_;

		// Token: 0x04001F2E RID: 7982
		public const int UnlockFieldNumber = 2;

		// Token: 0x04001F2F RID: 7983
		private bool unlock_;

		// Token: 0x04001F30 RID: 7984
		public const int CanChallengeFieldNumber = 3;

		// Token: 0x04001F31 RID: 7985
		private bool canChallenge_;

		// Token: 0x04001F32 RID: 7986
		public const int UnlockTimeFieldNumber = 4;

		// Token: 0x04001F33 RID: 7987
		private long unlockTime_;

		// Token: 0x04001F34 RID: 7988
		public const int IsConditionUnlockFieldNumber = 5;

		// Token: 0x04001F35 RID: 7989
		private bool isConditionUnlock_;

		// Token: 0x04001F36 RID: 7990
		public const int MaxProgressFieldNumber = 6;

		// Token: 0x04001F37 RID: 7991
		private int maxProgress_;

		// Token: 0x04001F38 RID: 7992
		public const int MinPassTimeFieldNumber = 7;

		// Token: 0x04001F39 RID: 7993
		private int minPassTime_;

		// Token: 0x04001F3A RID: 7994
		public const int PassedFieldNumber = 8;

		// Token: 0x04001F3B RID: 7995
		private bool passed_;
	}
}
