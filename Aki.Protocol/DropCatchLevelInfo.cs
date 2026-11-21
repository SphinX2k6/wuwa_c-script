using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020003F4 RID: 1012
	public sealed class DropCatchLevelInfo : IMessage<DropCatchLevelInfo>, IMessage, IEquatable<DropCatchLevelInfo>, IDeepCloneable<DropCatchLevelInfo>, IBufferMessage
	{
		// Token: 0x06006233 RID: 25139 RVA: 0x000ECB01 File Offset: 0x000EAD01
		[NullableContext(1)]
		public static DropCatchLevelInfo Create()
		{
			return new DropCatchLevelInfo();
		}

		// Token: 0x17001249 RID: 4681
		// (get) Token: 0x06006234 RID: 25140 RVA: 0x000ECB08 File Offset: 0x000EAD08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<DropCatchLevelInfo> Parser
		{
			get
			{
				return DropCatchLevelInfo._parser;
			}
		}

		// Token: 0x1700124A RID: 4682
		// (get) Token: 0x06006235 RID: 25141 RVA: 0x000ECB0F File Offset: 0x000EAD0F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700124B RID: 4683
		// (get) Token: 0x06006236 RID: 25142 RVA: 0x000ECB12 File Offset: 0x000EAD12
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DropCatchLevelInfo.Descriptor;
			}
		}

		// Token: 0x06006237 RID: 25143 RVA: 0x000ECB19 File Offset: 0x000EAD19
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DropCatchLevelInfo()
		{
		}

		// Token: 0x06006238 RID: 25144 RVA: 0x000ECB2C File Offset: 0x000EAD2C
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

		// Token: 0x06006239 RID: 25145 RVA: 0x000ECB85 File Offset: 0x000EAD85
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DropCatchLevelInfo Clone()
		{
			return new DropCatchLevelInfo(this);
		}

		// Token: 0x1700124C RID: 4684
		// (get) Token: 0x0600623A RID: 25146 RVA: 0x000ECB8D File Offset: 0x000EAD8D
		// (set) Token: 0x0600623B RID: 25147 RVA: 0x000ECB95 File Offset: 0x000EAD95
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

		// Token: 0x1700124D RID: 4685
		// (get) Token: 0x0600623C RID: 25148 RVA: 0x000ECB9E File Offset: 0x000EAD9E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> RewardStates
		{
			get
			{
				return this.rewardStates_;
			}
		}

		// Token: 0x1700124E RID: 4686
		// (get) Token: 0x0600623D RID: 25149 RVA: 0x000ECBA6 File Offset: 0x000EADA6
		// (set) Token: 0x0600623E RID: 25150 RVA: 0x000ECBAE File Offset: 0x000EADAE
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

		// Token: 0x1700124F RID: 4687
		// (get) Token: 0x0600623F RID: 25151 RVA: 0x000ECBB7 File Offset: 0x000EADB7
		// (set) Token: 0x06006240 RID: 25152 RVA: 0x000ECBBF File Offset: 0x000EADBF
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

		// Token: 0x06006241 RID: 25153 RVA: 0x000ECBC8 File Offset: 0x000EADC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DropCatchLevelInfo);
		}

		// Token: 0x06006242 RID: 25154 RVA: 0x000ECBD8 File Offset: 0x000EADD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DropCatchLevelInfo other)
		{
			return other != null && (other == this || (this.DropCatchId == other.DropCatchId && this.rewardStates_.Equals(other.rewardStates_) && this.UnlockTime == other.UnlockTime && this.Score == other.Score && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006243 RID: 25155 RVA: 0x000ECC48 File Offset: 0x000EAE48
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

		// Token: 0x06006244 RID: 25156 RVA: 0x000ECCC7 File Offset: 0x000EAEC7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06006245 RID: 25157 RVA: 0x000ECCD4 File Offset: 0x000EAED4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006246 RID: 25158 RVA: 0x000ECCE0 File Offset: 0x000EAEE0
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

		// Token: 0x06006247 RID: 25159 RVA: 0x000ECD68 File Offset: 0x000EAF68
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

		// Token: 0x06006248 RID: 25160 RVA: 0x000ECDEC File Offset: 0x000EAFEC
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

		// Token: 0x06006249 RID: 25161 RVA: 0x000ECE61 File Offset: 0x000EB061
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600624A RID: 25162 RVA: 0x000ECE6C File Offset: 0x000EB06C
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

		// Token: 0x04003823 RID: 14371
		private static readonly MessageParser<DropCatchLevelInfo> _parser = new MessageParser<DropCatchLevelInfo>(() => new DropCatchLevelInfo());

		// Token: 0x04003824 RID: 14372
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003825 RID: 14373
		public const int DropCatchIdFieldNumber = 1;

		// Token: 0x04003826 RID: 14374
		private int dropCatchId_;

		// Token: 0x04003827 RID: 14375
		public const int RewardStatesFieldNumber = 2;

		// Token: 0x04003828 RID: 14376
		private static readonly FieldCodec<int> _repeated_rewardStates_codec = FieldCodec.ForInt32(18U);

		// Token: 0x04003829 RID: 14377
		private readonly RepeatedField<int> rewardStates_ = new RepeatedField<int>();

		// Token: 0x0400382A RID: 14378
		public const int UnlockTimeFieldNumber = 3;

		// Token: 0x0400382B RID: 14379
		private long unlockTime_;

		// Token: 0x0400382C RID: 14380
		public const int ScoreFieldNumber = 4;

		// Token: 0x0400382D RID: 14381
		private int score_;
	}
}
