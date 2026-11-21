using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200148A RID: 5258
	public sealed class TrapDefenseChallengeInfo : IMessage<TrapDefenseChallengeInfo>, IMessage, IEquatable<TrapDefenseChallengeInfo>, IDeepCloneable<TrapDefenseChallengeInfo>, IBufferMessage
	{
		// Token: 0x0601BEB6 RID: 114358 RVA: 0x0040E60E File Offset: 0x0040C80E
		[NullableContext(1)]
		public static TrapDefenseChallengeInfo Create()
		{
			return new TrapDefenseChallengeInfo();
		}

		// Token: 0x17005E88 RID: 24200
		// (get) Token: 0x0601BEB7 RID: 114359 RVA: 0x0040E615 File Offset: 0x0040C815
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<TrapDefenseChallengeInfo> Parser
		{
			get
			{
				return TrapDefenseChallengeInfo._parser;
			}
		}

		// Token: 0x17005E89 RID: 24201
		// (get) Token: 0x0601BEB8 RID: 114360 RVA: 0x0040E61C File Offset: 0x0040C81C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005E8A RID: 24202
		// (get) Token: 0x0601BEB9 RID: 114361 RVA: 0x0040E61F File Offset: 0x0040C81F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TrapDefenseChallengeInfo.Descriptor;
			}
		}

		// Token: 0x0601BEBA RID: 114362 RVA: 0x0040E626 File Offset: 0x0040C826
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseChallengeInfo()
		{
		}

		// Token: 0x0601BEBB RID: 114363 RVA: 0x0040E63C File Offset: 0x0040C83C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseChallengeInfo(TrapDefenseChallengeInfo other) : this()
		{
			this.challengeId_ = other.challengeId_;
			this.unlock_ = other.unlock_;
			this.target_ = other.target_.Clone();
			this.passed_ = other.passed_;
			this.rewarded_ = other.rewarded_;
			this.unlockTime_ = other.unlockTime_;
			this.leaved_ = other.leaved_;
			this.maxWave_ = other.maxWave_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601BEBC RID: 114364 RVA: 0x0040E6C5 File Offset: 0x0040C8C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseChallengeInfo Clone()
		{
			return new TrapDefenseChallengeInfo(this);
		}

		// Token: 0x17005E8B RID: 24203
		// (get) Token: 0x0601BEBD RID: 114365 RVA: 0x0040E6CD File Offset: 0x0040C8CD
		// (set) Token: 0x0601BEBE RID: 114366 RVA: 0x0040E6D5 File Offset: 0x0040C8D5
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

		// Token: 0x17005E8C RID: 24204
		// (get) Token: 0x0601BEBF RID: 114367 RVA: 0x0040E6DE File Offset: 0x0040C8DE
		// (set) Token: 0x0601BEC0 RID: 114368 RVA: 0x0040E6E6 File Offset: 0x0040C8E6
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

		// Token: 0x17005E8D RID: 24205
		// (get) Token: 0x0601BEC1 RID: 114369 RVA: 0x0040E6EF File Offset: 0x0040C8EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> Target
		{
			get
			{
				return this.target_;
			}
		}

		// Token: 0x17005E8E RID: 24206
		// (get) Token: 0x0601BEC2 RID: 114370 RVA: 0x0040E6F7 File Offset: 0x0040C8F7
		// (set) Token: 0x0601BEC3 RID: 114371 RVA: 0x0040E6FF File Offset: 0x0040C8FF
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

		// Token: 0x17005E8F RID: 24207
		// (get) Token: 0x0601BEC4 RID: 114372 RVA: 0x0040E708 File Offset: 0x0040C908
		// (set) Token: 0x0601BEC5 RID: 114373 RVA: 0x0040E710 File Offset: 0x0040C910
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Rewarded
		{
			get
			{
				return this.rewarded_;
			}
			set
			{
				this.rewarded_ = value;
			}
		}

		// Token: 0x17005E90 RID: 24208
		// (get) Token: 0x0601BEC6 RID: 114374 RVA: 0x0040E719 File Offset: 0x0040C919
		// (set) Token: 0x0601BEC7 RID: 114375 RVA: 0x0040E721 File Offset: 0x0040C921
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

		// Token: 0x17005E91 RID: 24209
		// (get) Token: 0x0601BEC8 RID: 114376 RVA: 0x0040E72A File Offset: 0x0040C92A
		// (set) Token: 0x0601BEC9 RID: 114377 RVA: 0x0040E732 File Offset: 0x0040C932
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Leaved
		{
			get
			{
				return this.leaved_;
			}
			set
			{
				this.leaved_ = value;
			}
		}

		// Token: 0x17005E92 RID: 24210
		// (get) Token: 0x0601BECA RID: 114378 RVA: 0x0040E73B File Offset: 0x0040C93B
		// (set) Token: 0x0601BECB RID: 114379 RVA: 0x0040E743 File Offset: 0x0040C943
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int MaxWave
		{
			get
			{
				return this.maxWave_;
			}
			set
			{
				this.maxWave_ = value;
			}
		}

		// Token: 0x0601BECC RID: 114380 RVA: 0x0040E74C File Offset: 0x0040C94C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TrapDefenseChallengeInfo);
		}

		// Token: 0x0601BECD RID: 114381 RVA: 0x0040E75C File Offset: 0x0040C95C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TrapDefenseChallengeInfo other)
		{
			return other != null && (other == this || (this.ChallengeId == other.ChallengeId && this.Unlock == other.Unlock && this.target_.Equals(other.target_) && this.Passed == other.Passed && this.Rewarded == other.Rewarded && this.UnlockTime == other.UnlockTime && this.Leaved == other.Leaved && this.MaxWave == other.MaxWave && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601BECE RID: 114382 RVA: 0x0040E80C File Offset: 0x0040CA0C
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
			num ^= this.target_.GetHashCode();
			if (this.Passed)
			{
				num ^= this.Passed.GetHashCode();
			}
			if (this.Rewarded)
			{
				num ^= this.Rewarded.GetHashCode();
			}
			if (this.UnlockTime != 0L)
			{
				num ^= this.UnlockTime.GetHashCode();
			}
			if (this.Leaved)
			{
				num ^= this.Leaved.GetHashCode();
			}
			if (this.MaxWave != 0)
			{
				num ^= this.MaxWave.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601BECF RID: 114383 RVA: 0x0040E8EF File Offset: 0x0040CAEF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601BED0 RID: 114384 RVA: 0x0040E8FC File Offset: 0x0040CAFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601BED1 RID: 114385 RVA: 0x0040E908 File Offset: 0x0040CB08
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
			this.target_.WriteTo(ref output, TrapDefenseChallengeInfo._repeated_target_codec);
			if (this.Passed)
			{
				output.WriteRawTag(32);
				output.WriteBool(this.Passed);
			}
			if (this.Rewarded)
			{
				output.WriteRawTag(40);
				output.WriteBool(this.Rewarded);
			}
			if (this.UnlockTime != 0L)
			{
				output.WriteRawTag(48);
				output.WriteInt64(this.UnlockTime);
			}
			if (this.Leaved)
			{
				output.WriteRawTag(56);
				output.WriteBool(this.Leaved);
			}
			if (this.MaxWave != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.MaxWave);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601BED2 RID: 114386 RVA: 0x0040EA00 File Offset: 0x0040CC00
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
			num += this.target_.CalculateSize(TrapDefenseChallengeInfo._repeated_target_codec);
			if (this.Passed)
			{
				num += 2;
			}
			if (this.Rewarded)
			{
				num += 2;
			}
			if (this.UnlockTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.UnlockTime);
			}
			if (this.Leaved)
			{
				num += 2;
			}
			if (this.MaxWave != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.MaxWave);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601BED3 RID: 114387 RVA: 0x0040EAB4 File Offset: 0x0040CCB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TrapDefenseChallengeInfo other)
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
			this.target_.Add(other.target_);
			if (other.Passed)
			{
				this.Passed = other.Passed;
			}
			if (other.Rewarded)
			{
				this.Rewarded = other.Rewarded;
			}
			if (other.UnlockTime != 0L)
			{
				this.UnlockTime = other.UnlockTime;
			}
			if (other.Leaved)
			{
				this.Leaved = other.Leaved;
			}
			if (other.MaxWave != 0)
			{
				this.MaxWave = other.MaxWave;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601BED4 RID: 114388 RVA: 0x0040EB79 File Offset: 0x0040CD79
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601BED5 RID: 114389 RVA: 0x0040EB84 File Offset: 0x0040CD84
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
				if (num <= 26U)
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
					else if (num == 24U || num == 26U)
					{
						this.target_.AddEntriesFrom(ref input, TrapDefenseChallengeInfo._repeated_target_codec);
						continue;
					}
				}
				else if (num <= 40U)
				{
					if (num == 32U)
					{
						this.Passed = input.ReadBool();
						continue;
					}
					if (num == 40U)
					{
						this.Rewarded = input.ReadBool();
						continue;
					}
				}
				else
				{
					if (num == 48U)
					{
						this.UnlockTime = input.ReadInt64();
						continue;
					}
					if (num == 56U)
					{
						this.Leaved = input.ReadBool();
						continue;
					}
					if (num == 64U)
					{
						this.MaxWave = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400A1E6 RID: 41446
		private static readonly MessageParser<TrapDefenseChallengeInfo> _parser = new MessageParser<TrapDefenseChallengeInfo>(() => new TrapDefenseChallengeInfo());

		// Token: 0x0400A1E7 RID: 41447
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A1E8 RID: 41448
		public const int ChallengeIdFieldNumber = 1;

		// Token: 0x0400A1E9 RID: 41449
		private int challengeId_;

		// Token: 0x0400A1EA RID: 41450
		public const int UnlockFieldNumber = 2;

		// Token: 0x0400A1EB RID: 41451
		private bool unlock_;

		// Token: 0x0400A1EC RID: 41452
		public const int TargetFieldNumber = 3;

		// Token: 0x0400A1ED RID: 41453
		private static readonly FieldCodec<int> _repeated_target_codec = FieldCodec.ForInt32(26U);

		// Token: 0x0400A1EE RID: 41454
		private readonly RepeatedField<int> target_ = new RepeatedField<int>();

		// Token: 0x0400A1EF RID: 41455
		public const int PassedFieldNumber = 4;

		// Token: 0x0400A1F0 RID: 41456
		private bool passed_;

		// Token: 0x0400A1F1 RID: 41457
		public const int RewardedFieldNumber = 5;

		// Token: 0x0400A1F2 RID: 41458
		private bool rewarded_;

		// Token: 0x0400A1F3 RID: 41459
		public const int UnlockTimeFieldNumber = 6;

		// Token: 0x0400A1F4 RID: 41460
		private long unlockTime_;

		// Token: 0x0400A1F5 RID: 41461
		public const int LeavedFieldNumber = 7;

		// Token: 0x0400A1F6 RID: 41462
		private bool leaved_;

		// Token: 0x0400A1F7 RID: 41463
		public const int MaxWaveFieldNumber = 8;

		// Token: 0x0400A1F8 RID: 41464
		private int maxWave_;
	}
}
