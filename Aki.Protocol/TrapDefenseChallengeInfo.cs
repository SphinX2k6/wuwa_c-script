using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001417 RID: 5143
	public sealed class TrapDefenseChallengeInfo : IMessage<TrapDefenseChallengeInfo>, IMessage, IEquatable<TrapDefenseChallengeInfo>, IDeepCloneable<TrapDefenseChallengeInfo>, IBufferMessage
	{
		// Token: 0x0601B42B RID: 111659 RVA: 0x003F333B File Offset: 0x003F153B
		[NullableContext(1)]
		public static TrapDefenseChallengeInfo Create()
		{
			return new TrapDefenseChallengeInfo();
		}

		// Token: 0x17005BF3 RID: 23539
		// (get) Token: 0x0601B42C RID: 111660 RVA: 0x003F3342 File Offset: 0x003F1542
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<TrapDefenseChallengeInfo> Parser
		{
			get
			{
				return TrapDefenseChallengeInfo._parser;
			}
		}

		// Token: 0x17005BF4 RID: 23540
		// (get) Token: 0x0601B42D RID: 111661 RVA: 0x003F3349 File Offset: 0x003F1549
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005BF5 RID: 23541
		// (get) Token: 0x0601B42E RID: 111662 RVA: 0x003F334C File Offset: 0x003F154C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TrapDefenseChallengeInfo.Descriptor;
			}
		}

		// Token: 0x0601B42F RID: 111663 RVA: 0x003F3353 File Offset: 0x003F1553
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseChallengeInfo()
		{
		}

		// Token: 0x0601B430 RID: 111664 RVA: 0x003F3368 File Offset: 0x003F1568
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

		// Token: 0x0601B431 RID: 111665 RVA: 0x003F33F1 File Offset: 0x003F15F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseChallengeInfo Clone()
		{
			return new TrapDefenseChallengeInfo(this);
		}

		// Token: 0x17005BF6 RID: 23542
		// (get) Token: 0x0601B432 RID: 111666 RVA: 0x003F33F9 File Offset: 0x003F15F9
		// (set) Token: 0x0601B433 RID: 111667 RVA: 0x003F3401 File Offset: 0x003F1601
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

		// Token: 0x17005BF7 RID: 23543
		// (get) Token: 0x0601B434 RID: 111668 RVA: 0x003F340A File Offset: 0x003F160A
		// (set) Token: 0x0601B435 RID: 111669 RVA: 0x003F3412 File Offset: 0x003F1612
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

		// Token: 0x17005BF8 RID: 23544
		// (get) Token: 0x0601B436 RID: 111670 RVA: 0x003F341B File Offset: 0x003F161B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> Target
		{
			get
			{
				return this.target_;
			}
		}

		// Token: 0x17005BF9 RID: 23545
		// (get) Token: 0x0601B437 RID: 111671 RVA: 0x003F3423 File Offset: 0x003F1623
		// (set) Token: 0x0601B438 RID: 111672 RVA: 0x003F342B File Offset: 0x003F162B
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

		// Token: 0x17005BFA RID: 23546
		// (get) Token: 0x0601B439 RID: 111673 RVA: 0x003F3434 File Offset: 0x003F1634
		// (set) Token: 0x0601B43A RID: 111674 RVA: 0x003F343C File Offset: 0x003F163C
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

		// Token: 0x17005BFB RID: 23547
		// (get) Token: 0x0601B43B RID: 111675 RVA: 0x003F3445 File Offset: 0x003F1645
		// (set) Token: 0x0601B43C RID: 111676 RVA: 0x003F344D File Offset: 0x003F164D
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

		// Token: 0x17005BFC RID: 23548
		// (get) Token: 0x0601B43D RID: 111677 RVA: 0x003F3456 File Offset: 0x003F1656
		// (set) Token: 0x0601B43E RID: 111678 RVA: 0x003F345E File Offset: 0x003F165E
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

		// Token: 0x17005BFD RID: 23549
		// (get) Token: 0x0601B43F RID: 111679 RVA: 0x003F3467 File Offset: 0x003F1667
		// (set) Token: 0x0601B440 RID: 111680 RVA: 0x003F346F File Offset: 0x003F166F
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

		// Token: 0x0601B441 RID: 111681 RVA: 0x003F3478 File Offset: 0x003F1678
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TrapDefenseChallengeInfo);
		}

		// Token: 0x0601B442 RID: 111682 RVA: 0x003F3488 File Offset: 0x003F1688
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TrapDefenseChallengeInfo other)
		{
			return other != null && (other == this || (this.ChallengeId == other.ChallengeId && this.Unlock == other.Unlock && this.target_.Equals(other.target_) && this.Passed == other.Passed && this.Rewarded == other.Rewarded && this.UnlockTime == other.UnlockTime && this.Leaved == other.Leaved && this.MaxWave == other.MaxWave && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601B443 RID: 111683 RVA: 0x003F3538 File Offset: 0x003F1738
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

		// Token: 0x0601B444 RID: 111684 RVA: 0x003F361B File Offset: 0x003F181B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601B445 RID: 111685 RVA: 0x003F3628 File Offset: 0x003F1828
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601B446 RID: 111686 RVA: 0x003F3634 File Offset: 0x003F1834
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

		// Token: 0x0601B447 RID: 111687 RVA: 0x003F372C File Offset: 0x003F192C
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

		// Token: 0x0601B448 RID: 111688 RVA: 0x003F37E0 File Offset: 0x003F19E0
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

		// Token: 0x0601B449 RID: 111689 RVA: 0x003F38A5 File Offset: 0x003F1AA5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601B44A RID: 111690 RVA: 0x003F38B0 File Offset: 0x003F1AB0
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

		// Token: 0x04009D9F RID: 40351
		private static readonly MessageParser<TrapDefenseChallengeInfo> _parser = new MessageParser<TrapDefenseChallengeInfo>(() => new TrapDefenseChallengeInfo());

		// Token: 0x04009DA0 RID: 40352
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009DA1 RID: 40353
		public const int ChallengeIdFieldNumber = 1;

		// Token: 0x04009DA2 RID: 40354
		private int challengeId_;

		// Token: 0x04009DA3 RID: 40355
		public const int UnlockFieldNumber = 2;

		// Token: 0x04009DA4 RID: 40356
		private bool unlock_;

		// Token: 0x04009DA5 RID: 40357
		public const int TargetFieldNumber = 3;

		// Token: 0x04009DA6 RID: 40358
		private static readonly FieldCodec<int> _repeated_target_codec = FieldCodec.ForInt32(26U);

		// Token: 0x04009DA7 RID: 40359
		private readonly RepeatedField<int> target_ = new RepeatedField<int>();

		// Token: 0x04009DA8 RID: 40360
		public const int PassedFieldNumber = 4;

		// Token: 0x04009DA9 RID: 40361
		private bool passed_;

		// Token: 0x04009DAA RID: 40362
		public const int RewardedFieldNumber = 5;

		// Token: 0x04009DAB RID: 40363
		private bool rewarded_;

		// Token: 0x04009DAC RID: 40364
		public const int UnlockTimeFieldNumber = 6;

		// Token: 0x04009DAD RID: 40365
		private long unlockTime_;

		// Token: 0x04009DAE RID: 40366
		public const int LeavedFieldNumber = 7;

		// Token: 0x04009DAF RID: 40367
		private bool leaved_;

		// Token: 0x04009DB0 RID: 40368
		public const int MaxWaveFieldNumber = 8;

		// Token: 0x04009DB1 RID: 40369
		private int maxWave_;
	}
}
