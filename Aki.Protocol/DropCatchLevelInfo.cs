using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200040B RID: 1035
	public sealed class DropCatchLevelInfo : IMessage<DropCatchLevelInfo>, IMessage, IEquatable<DropCatchLevelInfo>, IDeepCloneable<DropCatchLevelInfo>, IBufferMessage
	{
		// Token: 0x060063C3 RID: 25539 RVA: 0x000EFC75 File Offset: 0x000EDE75
		[NullableContext(1)]
		public static DropCatchLevelInfo Create()
		{
			return new DropCatchLevelInfo();
		}

		// Token: 0x1700129E RID: 4766
		// (get) Token: 0x060063C4 RID: 25540 RVA: 0x000EFC7C File Offset: 0x000EDE7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<DropCatchLevelInfo> Parser
		{
			get
			{
				return DropCatchLevelInfo._parser;
			}
		}

		// Token: 0x1700129F RID: 4767
		// (get) Token: 0x060063C5 RID: 25541 RVA: 0x000EFC83 File Offset: 0x000EDE83
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170012A0 RID: 4768
		// (get) Token: 0x060063C6 RID: 25542 RVA: 0x000EFC86 File Offset: 0x000EDE86
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DropCatchLevelInfo.Descriptor;
			}
		}

		// Token: 0x060063C7 RID: 25543 RVA: 0x000EFC8D File Offset: 0x000EDE8D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DropCatchLevelInfo()
		{
		}

		// Token: 0x060063C8 RID: 25544 RVA: 0x000EFCA0 File Offset: 0x000EDEA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DropCatchLevelInfo(DropCatchLevelInfo other) : this()
		{
			this.dropCatchId_ = other.dropCatchId_;
			this.rewardStates_ = other.rewardStates_.Clone();
			this.unlockTime_ = other.unlockTime_;
			this.score_ = other.score_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060063C9 RID: 25545 RVA: 0x000EFCF9 File Offset: 0x000EDEF9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DropCatchLevelInfo Clone()
		{
			return new DropCatchLevelInfo(this);
		}

		// Token: 0x170012A1 RID: 4769
		// (get) Token: 0x060063CA RID: 25546 RVA: 0x000EFD01 File Offset: 0x000EDF01
		// (set) Token: 0x060063CB RID: 25547 RVA: 0x000EFD09 File Offset: 0x000EDF09
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int DropCatchId
		{
			get
			{
				return this.dropCatchId_;
			}
			set
			{
				this.dropCatchId_ = value;
			}
		}

		// Token: 0x170012A2 RID: 4770
		// (get) Token: 0x060063CC RID: 25548 RVA: 0x000EFD12 File Offset: 0x000EDF12
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> RewardStates
		{
			get
			{
				return this.rewardStates_;
			}
		}

		// Token: 0x170012A3 RID: 4771
		// (get) Token: 0x060063CD RID: 25549 RVA: 0x000EFD1A File Offset: 0x000EDF1A
		// (set) Token: 0x060063CE RID: 25550 RVA: 0x000EFD22 File Offset: 0x000EDF22
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

		// Token: 0x170012A4 RID: 4772
		// (get) Token: 0x060063CF RID: 25551 RVA: 0x000EFD2B File Offset: 0x000EDF2B
		// (set) Token: 0x060063D0 RID: 25552 RVA: 0x000EFD33 File Offset: 0x000EDF33
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Score
		{
			get
			{
				return this.score_;
			}
			set
			{
				this.score_ = value;
			}
		}

		// Token: 0x060063D1 RID: 25553 RVA: 0x000EFD3C File Offset: 0x000EDF3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DropCatchLevelInfo);
		}

		// Token: 0x060063D2 RID: 25554 RVA: 0x000EFD4C File Offset: 0x000EDF4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DropCatchLevelInfo other)
		{
			return other != null && (other == this || (this.DropCatchId == other.DropCatchId && this.rewardStates_.Equals(other.rewardStates_) && this.UnlockTime == other.UnlockTime && this.Score == other.Score && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060063D3 RID: 25555 RVA: 0x000EFDBC File Offset: 0x000EDFBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.DropCatchId != 0)
			{
				num ^= this.DropCatchId.GetHashCode();
			}
			num ^= this.rewardStates_.GetHashCode();
			if (this.UnlockTime != 0L)
			{
				num ^= this.UnlockTime.GetHashCode();
			}
			if (this.Score != 0)
			{
				num ^= this.Score.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060063D4 RID: 25556 RVA: 0x000EFE3B File Offset: 0x000EE03B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060063D5 RID: 25557 RVA: 0x000EFE48 File Offset: 0x000EE048
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060063D6 RID: 25558 RVA: 0x000EFE54 File Offset: 0x000EE054
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.DropCatchId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.DropCatchId);
			}
			this.rewardStates_.WriteTo(ref output, DropCatchLevelInfo._repeated_rewardStates_codec);
			if (this.UnlockTime != 0L)
			{
				output.WriteRawTag(24);
				output.WriteInt64(this.UnlockTime);
			}
			if (this.Score != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.Score);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060063D7 RID: 25559 RVA: 0x000EFEDC File Offset: 0x000EE0DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.DropCatchId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.DropCatchId);
			}
			num += this.rewardStates_.CalculateSize(DropCatchLevelInfo._repeated_rewardStates_codec);
			if (this.UnlockTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.UnlockTime);
			}
			if (this.Score != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Score);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060063D8 RID: 25560 RVA: 0x000EFF60 File Offset: 0x000EE160
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DropCatchLevelInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.DropCatchId != 0)
			{
				this.DropCatchId = other.DropCatchId;
			}
			this.rewardStates_.Add(other.rewardStates_);
			if (other.UnlockTime != 0L)
			{
				this.UnlockTime = other.UnlockTime;
			}
			if (other.Score != 0)
			{
				this.Score = other.Score;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060063D9 RID: 25561 RVA: 0x000EFFD5 File Offset: 0x000EE1D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060063DA RID: 25562 RVA: 0x000EFFE0 File Offset: 0x000EE1E0
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
						this.DropCatchId = input.ReadInt32();
						continue;
					}
					if (num == 16U)
					{
						goto IL_4A;
					}
				}
				else
				{
					if (num == 18U)
					{
						goto IL_4A;
					}
					if (num == 24U)
					{
						this.UnlockTime = input.ReadInt64();
						continue;
					}
					if (num == 32U)
					{
						this.Score = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				continue;
				IL_4A:
				this.rewardStates_.AddEntriesFrom(ref input, DropCatchLevelInfo._repeated_rewardStates_codec);
			}
		}

		// Token: 0x04003836 RID: 14390
		private static readonly MessageParser<DropCatchLevelInfo> _parser = new MessageParser<DropCatchLevelInfo>(() => new DropCatchLevelInfo());

		// Token: 0x04003837 RID: 14391
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003838 RID: 14392
		public const int DropCatchIdFieldNumber = 1;

		// Token: 0x04003839 RID: 14393
		private int dropCatchId_;

		// Token: 0x0400383A RID: 14394
		public const int RewardStatesFieldNumber = 2;

		// Token: 0x0400383B RID: 14395
		private static readonly FieldCodec<int> _repeated_rewardStates_codec = FieldCodec.ForInt32(18U);

		// Token: 0x0400383C RID: 14396
		private readonly RepeatedField<int> rewardStates_ = new RepeatedField<int>();

		// Token: 0x0400383D RID: 14397
		public const int UnlockTimeFieldNumber = 3;

		// Token: 0x0400383E RID: 14398
		private long unlockTime_;

		// Token: 0x0400383F RID: 14399
		public const int ScoreFieldNumber = 4;

		// Token: 0x04003840 RID: 14400
		private int score_;
	}
}
