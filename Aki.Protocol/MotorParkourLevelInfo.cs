using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A94 RID: 2708
	public sealed class MotorParkourLevelInfo : IMessage<MotorParkourLevelInfo>, IMessage, IEquatable<MotorParkourLevelInfo>, IDeepCloneable<MotorParkourLevelInfo>, IBufferMessage
	{
		// Token: 0x0600EBCF RID: 60367 RVA: 0x00226CBC File Offset: 0x00224EBC
		[NullableContext(1)]
		public static MotorParkourLevelInfo Create()
		{
			return new MotorParkourLevelInfo();
		}

		// Token: 0x17002FE0 RID: 12256
		// (get) Token: 0x0600EBD0 RID: 60368 RVA: 0x00226CC3 File Offset: 0x00224EC3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MotorParkourLevelInfo> Parser
		{
			get
			{
				return MotorParkourLevelInfo._parser;
			}
		}

		// Token: 0x17002FE1 RID: 12257
		// (get) Token: 0x0600EBD1 RID: 60369 RVA: 0x00226CCA File Offset: 0x00224ECA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002FE2 RID: 12258
		// (get) Token: 0x0600EBD2 RID: 60370 RVA: 0x00226CCD File Offset: 0x00224ECD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorParkourLevelInfo.Descriptor;
			}
		}

		// Token: 0x0600EBD3 RID: 60371 RVA: 0x00226CD4 File Offset: 0x00224ED4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorParkourLevelInfo()
		{
		}

		// Token: 0x0600EBD4 RID: 60372 RVA: 0x00226CE8 File Offset: 0x00224EE8
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

		// Token: 0x0600EBD5 RID: 60373 RVA: 0x00226D41 File Offset: 0x00224F41
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorParkourLevelInfo Clone()
		{
			return new MotorParkourLevelInfo(this);
		}

		// Token: 0x17002FE3 RID: 12259
		// (get) Token: 0x0600EBD6 RID: 60374 RVA: 0x00226D49 File Offset: 0x00224F49
		// (set) Token: 0x0600EBD7 RID: 60375 RVA: 0x00226D51 File Offset: 0x00224F51
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

		// Token: 0x17002FE4 RID: 12260
		// (get) Token: 0x0600EBD8 RID: 60376 RVA: 0x00226D5A File Offset: 0x00224F5A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<MotorParkourRewardState> RewardStates
		{
			get
			{
				return this.rewardStates_;
			}
		}

		// Token: 0x17002FE5 RID: 12261
		// (get) Token: 0x0600EBD9 RID: 60377 RVA: 0x00226D62 File Offset: 0x00224F62
		// (set) Token: 0x0600EBDA RID: 60378 RVA: 0x00226D6A File Offset: 0x00224F6A
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

		// Token: 0x17002FE6 RID: 12262
		// (get) Token: 0x0600EBDB RID: 60379 RVA: 0x00226D73 File Offset: 0x00224F73
		// (set) Token: 0x0600EBDC RID: 60380 RVA: 0x00226D7B File Offset: 0x00224F7B
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

		// Token: 0x0600EBDD RID: 60381 RVA: 0x00226D84 File Offset: 0x00224F84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorParkourLevelInfo);
		}

		// Token: 0x0600EBDE RID: 60382 RVA: 0x00226D94 File Offset: 0x00224F94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorParkourLevelInfo other)
		{
			return other != null && (other == this || (this.MotorParkourId == other.MotorParkourId && this.rewardStates_.Equals(other.rewardStates_) && this.UnlockTime == other.UnlockTime && this.BestPassTime == other.BestPassTime && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600EBDF RID: 60383 RVA: 0x00226E04 File Offset: 0x00225004
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

		// Token: 0x0600EBE0 RID: 60384 RVA: 0x00226E83 File Offset: 0x00225083
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600EBE1 RID: 60385 RVA: 0x00226E90 File Offset: 0x00225090
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600EBE2 RID: 60386 RVA: 0x00226E9C File Offset: 0x0022509C
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

		// Token: 0x0600EBE3 RID: 60387 RVA: 0x00226F24 File Offset: 0x00225124
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

		// Token: 0x0600EBE4 RID: 60388 RVA: 0x00226FA8 File Offset: 0x002251A8
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

		// Token: 0x0600EBE5 RID: 60389 RVA: 0x0022701D File Offset: 0x0022521D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600EBE6 RID: 60390 RVA: 0x00227028 File Offset: 0x00225228
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

		// Token: 0x04005FA7 RID: 24487
		private static readonly MessageParser<MotorParkourLevelInfo> _parser = new MessageParser<MotorParkourLevelInfo>(() => new MotorParkourLevelInfo());

		// Token: 0x04005FA8 RID: 24488
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005FA9 RID: 24489
		public const int MotorParkourIdFieldNumber = 1;

		// Token: 0x04005FAA RID: 24490
		private int motorParkourId_;

		// Token: 0x04005FAB RID: 24491
		public const int RewardStatesFieldNumber = 2;

		// Token: 0x04005FAC RID: 24492
		private static readonly FieldCodec<MotorParkourRewardState> _repeated_rewardStates_codec = FieldCodec.ForEnum<MotorParkourRewardState>(18U, (MotorParkourRewardState x) => (int)x, (int x) => (MotorParkourRewardState)x);

		// Token: 0x04005FAD RID: 24493
		private readonly RepeatedField<MotorParkourRewardState> rewardStates_ = new RepeatedField<MotorParkourRewardState>();

		// Token: 0x04005FAE RID: 24494
		public const int UnlockTimeFieldNumber = 3;

		// Token: 0x04005FAF RID: 24495
		private long unlockTime_;

		// Token: 0x04005FB0 RID: 24496
		public const int BestPassTimeFieldNumber = 4;

		// Token: 0x04005FB1 RID: 24497
		private int bestPassTime_;
	}
}
