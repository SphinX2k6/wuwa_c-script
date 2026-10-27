using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A95 RID: 2709
	[NetMessage(EMessageId.MotorParkourLevelRewardRequest)]
	public sealed class MotorParkourLevelRewardRequest : IMessage<MotorParkourLevelRewardRequest>, IMessage, IEquatable<MotorParkourLevelRewardRequest>, IDeepCloneable<MotorParkourLevelRewardRequest>, IBufferMessage
	{
		// Token: 0x0600EBE8 RID: 60392 RVA: 0x0022710B File Offset: 0x0022530B
		[NullableContext(1)]
		public static MotorParkourLevelRewardRequest Create()
		{
			return new MotorParkourLevelRewardRequest();
		}

		// Token: 0x17002FE7 RID: 12263
		// (get) Token: 0x0600EBE9 RID: 60393 RVA: 0x00227112 File Offset: 0x00225312
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002FE8 RID: 12264
		// (get) Token: 0x0600EBEA RID: 60394 RVA: 0x00227115 File Offset: 0x00225315
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorParkourLevelRewardRequest.Descriptor;
			}
		}

		// Token: 0x0600EBEB RID: 60395 RVA: 0x0022711C File Offset: 0x0022531C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorParkourLevelRewardRequest()
		{
		}

		// Token: 0x0600EBEC RID: 60396 RVA: 0x0022712F File Offset: 0x0022532F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorParkourLevelRewardRequest(MotorParkourLevelRewardRequest other) : this()
		{
			this.motorParkourId_ = other.motorParkourId_;
			this.rewardIdxs_ = other.rewardIdxs_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600EBED RID: 60397 RVA: 0x00227165 File Offset: 0x00225365
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorParkourLevelRewardRequest Clone()
		{
			return new MotorParkourLevelRewardRequest(this);
		}

		// Token: 0x17002FE9 RID: 12265
		// (get) Token: 0x0600EBEE RID: 60398 RVA: 0x0022716D File Offset: 0x0022536D
		// (set) Token: 0x0600EBEF RID: 60399 RVA: 0x00227175 File Offset: 0x00225375
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

		// Token: 0x17002FEA RID: 12266
		// (get) Token: 0x0600EBF0 RID: 60400 RVA: 0x0022717E File Offset: 0x0022537E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> RewardIdxs
		{
			get
			{
				return this.rewardIdxs_;
			}
		}

		// Token: 0x0600EBF1 RID: 60401 RVA: 0x00227186 File Offset: 0x00225386
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorParkourLevelRewardRequest);
		}

		// Token: 0x0600EBF2 RID: 60402 RVA: 0x00227194 File Offset: 0x00225394
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorParkourLevelRewardRequest other)
		{
			return other != null && (other == this || (this.MotorParkourId == other.MotorParkourId && this.rewardIdxs_.Equals(other.rewardIdxs_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600EBF3 RID: 60403 RVA: 0x002271E4 File Offset: 0x002253E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.MotorParkourId != 0)
			{
				num ^= this.MotorParkourId.GetHashCode();
			}
			num ^= this.rewardIdxs_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600EBF4 RID: 60404 RVA: 0x00227231 File Offset: 0x00225431
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600EBF5 RID: 60405 RVA: 0x0022723E File Offset: 0x0022543E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600EBF6 RID: 60406 RVA: 0x00227248 File Offset: 0x00225448
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.MotorParkourId != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.MotorParkourId);
			}
			this.rewardIdxs_.WriteTo(ref output, MotorParkourLevelRewardRequest._repeated_rewardIdxs_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600EBF7 RID: 60407 RVA: 0x00227298 File Offset: 0x00225498
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.MotorParkourId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.MotorParkourId);
			}
			num += this.rewardIdxs_.CalculateSize(MotorParkourLevelRewardRequest._repeated_rewardIdxs_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600EBF8 RID: 60408 RVA: 0x002272EC File Offset: 0x002254EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MotorParkourLevelRewardRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.MotorParkourId != 0)
			{
				this.MotorParkourId = other.MotorParkourId;
			}
			this.rewardIdxs_.Add(other.rewardIdxs_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600EBF9 RID: 60409 RVA: 0x00227339 File Offset: 0x00225539
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600EBFA RID: 60410 RVA: 0x00227344 File Offset: 0x00225544
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
				if (num != 72U)
				{
					if (num != 104U && num != 106U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.rewardIdxs_.AddEntriesFrom(ref input, MotorParkourLevelRewardRequest._repeated_rewardIdxs_codec);
					}
				}
				else
				{
					this.MotorParkourId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04005FB2 RID: 24498
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005FB3 RID: 24499
		public const int MotorParkourIdFieldNumber = 9;

		// Token: 0x04005FB4 RID: 24500
		private int motorParkourId_;

		// Token: 0x04005FB5 RID: 24501
		public const int RewardIdxsFieldNumber = 13;

		// Token: 0x04005FB6 RID: 24502
		private static readonly FieldCodec<int> _repeated_rewardIdxs_codec = FieldCodec.ForInt32(106U);

		// Token: 0x04005FB7 RID: 24503
		private readonly RepeatedField<int> rewardIdxs_ = new RepeatedField<int>();
	}
}
