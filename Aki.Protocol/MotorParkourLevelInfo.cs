using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A83 RID: 2691
	public sealed class MotorParkourLevelInfo : IMessage<MotorParkourLevelInfo>, IMessage, IEquatable<MotorParkourLevelInfo>, IDeepCloneable<MotorParkourLevelInfo>, IBufferMessage
	{
		// Token: 0x0600EAB5 RID: 60085 RVA: 0x00224AC0 File Offset: 0x00222CC0
		[NullableContext(1)]
		public static MotorParkourLevelInfo Create()
		{
			return new MotorParkourLevelInfo();
		}

		// Token: 0x17002FA2 RID: 12194
		// (get) Token: 0x0600EAB6 RID: 60086 RVA: 0x00224AC7 File Offset: 0x00222CC7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MotorParkourLevelInfo> Parser
		{
			get
			{
				return MotorParkourLevelInfo._parser;
			}
		}

		// Token: 0x17002FA3 RID: 12195
		// (get) Token: 0x0600EAB7 RID: 60087 RVA: 0x00224ACE File Offset: 0x00222CCE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002FA4 RID: 12196
		// (get) Token: 0x0600EAB8 RID: 60088 RVA: 0x00224AD1 File Offset: 0x00222CD1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorParkourLevelInfo.Descriptor;
			}
		}

		// Token: 0x0600EAB9 RID: 60089 RVA: 0x00224AD8 File Offset: 0x00222CD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorParkourLevelInfo()
		{
		}

		// Token: 0x0600EABA RID: 60090 RVA: 0x00224AEC File Offset: 0x00222CEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorParkourLevelInfo(MotorParkourLevelInfo other) : this()
		{
			this.motorParkourId_ = other.motorParkourId_;
			this.rewardStates_ = other.rewardStates_.Clone();
			this.unlockTime_ = other.unlockTime_;
			this.bestPassTime_ = other.bestPassTime_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600EABB RID: 60091 RVA: 0x00224B45 File Offset: 0x00222D45
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorParkourLevelInfo Clone()
		{
			return new MotorParkourLevelInfo(this);
		}

		// Token: 0x17002FA5 RID: 12197
		// (get) Token: 0x0600EABC RID: 60092 RVA: 0x00224B4D File Offset: 0x00222D4D
		// (set) Token: 0x0600EABD RID: 60093 RVA: 0x00224B55 File Offset: 0x00222D55
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int MotorParkourId
		{
			get
			{
				return this.motorParkourId_;
			}
			set
			{
				this.motorParkourId_ = value;
			}
		}

		// Token: 0x17002FA6 RID: 12198
		// (get) Token: 0x0600EABE RID: 60094 RVA: 0x00224B5E File Offset: 0x00222D5E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<MotorParkourRewardState> RewardStates
		{
			get
			{
				return this.rewardStates_;
			}
		}

		// Token: 0x17002FA7 RID: 12199
		// (get) Token: 0x0600EABF RID: 60095 RVA: 0x00224B66 File Offset: 0x00222D66
		// (set) Token: 0x0600EAC0 RID: 60096 RVA: 0x00224B6E File Offset: 0x00222D6E
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

		// Token: 0x17002FA8 RID: 12200
		// (get) Token: 0x0600EAC1 RID: 60097 RVA: 0x00224B77 File Offset: 0x00222D77
		// (set) Token: 0x0600EAC2 RID: 60098 RVA: 0x00224B7F File Offset: 0x00222D7F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int BestPassTime
		{
			get
			{
				return this.bestPassTime_;
			}
			set
			{
				this.bestPassTime_ = value;
			}
		}

		// Token: 0x0600EAC3 RID: 60099 RVA: 0x00224B88 File Offset: 0x00222D88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorParkourLevelInfo);
		}

		// Token: 0x0600EAC4 RID: 60100 RVA: 0x00224B98 File Offset: 0x00222D98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorParkourLevelInfo other)
		{
			return other != null && (other == this || (this.MotorParkourId == other.MotorParkourId && this.rewardStates_.Equals(other.rewardStates_) && this.UnlockTime == other.UnlockTime && this.BestPassTime == other.BestPassTime && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600EAC5 RID: 60101 RVA: 0x00224C08 File Offset: 0x00222E08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.MotorParkourId != 0)
			{
				num ^= this.MotorParkourId.GetHashCode();
			}
			num ^= this.rewardStates_.GetHashCode();
			if (this.UnlockTime != 0L)
			{
				num ^= this.UnlockTime.GetHashCode();
			}
			if (this.BestPassTime != 0)
			{
				num ^= this.BestPassTime.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600EAC6 RID: 60102 RVA: 0x00224C87 File Offset: 0x00222E87
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600EAC7 RID: 60103 RVA: 0x00224C94 File Offset: 0x00222E94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600EAC8 RID: 60104 RVA: 0x00224CA0 File Offset: 0x00222EA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.MotorParkourId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.MotorParkourId);
			}
			this.rewardStates_.WriteTo(ref output, MotorParkourLevelInfo._repeated_rewardStates_codec);
			if (this.UnlockTime != 0L)
			{
				output.WriteRawTag(24);
				output.WriteInt64(this.UnlockTime);
			}
			if (this.BestPassTime != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.BestPassTime);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600EAC9 RID: 60105 RVA: 0x00224D28 File Offset: 0x00222F28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.MotorParkourId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.MotorParkourId);
			}
			num += this.rewardStates_.CalculateSize(MotorParkourLevelInfo._repeated_rewardStates_codec);
			if (this.UnlockTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.UnlockTime);
			}
			if (this.BestPassTime != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.BestPassTime);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600EACA RID: 60106 RVA: 0x00224DAC File Offset: 0x00222FAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MotorParkourLevelInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.MotorParkourId != 0)
			{
				this.MotorParkourId = other.MotorParkourId;
			}
			this.rewardStates_.Add(other.rewardStates_);
			if (other.UnlockTime != 0L)
			{
				this.UnlockTime = other.UnlockTime;
			}
			if (other.BestPassTime != 0)
			{
				this.BestPassTime = other.BestPassTime;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600EACB RID: 60107 RVA: 0x00224E21 File Offset: 0x00223021
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600EACC RID: 60108 RVA: 0x00224E2C File Offset: 0x0022302C
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
						this.MotorParkourId = input.ReadInt32();
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
						this.BestPassTime = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				continue;
				IL_4A:
				this.rewardStates_.AddEntriesFrom(ref input, MotorParkourLevelInfo._repeated_rewardStates_codec);
			}
		}

		// Token: 0x04005FB0 RID: 24496
		private static readonly MessageParser<MotorParkourLevelInfo> _parser = new MessageParser<MotorParkourLevelInfo>(() => new MotorParkourLevelInfo());

		// Token: 0x04005FB1 RID: 24497
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005FB2 RID: 24498
		public const int MotorParkourIdFieldNumber = 1;

		// Token: 0x04005FB3 RID: 24499
		private int motorParkourId_;

		// Token: 0x04005FB4 RID: 24500
		public const int RewardStatesFieldNumber = 2;

		// Token: 0x04005FB5 RID: 24501
		private static readonly FieldCodec<MotorParkourRewardState> _repeated_rewardStates_codec = FieldCodec.ForEnum<MotorParkourRewardState>(18U, (MotorParkourRewardState x) => (int)x, (int x) => (MotorParkourRewardState)x);

		// Token: 0x04005FB6 RID: 24502
		private readonly RepeatedField<MotorParkourRewardState> rewardStates_ = new RepeatedField<MotorParkourRewardState>();

		// Token: 0x04005FB7 RID: 24503
		public const int UnlockTimeFieldNumber = 3;

		// Token: 0x04005FB8 RID: 24504
		private long unlockTime_;

		// Token: 0x04005FB9 RID: 24505
		public const int BestPassTimeFieldNumber = 4;

		// Token: 0x04005FBA RID: 24506
		private int bestPassTime_;
	}
}
