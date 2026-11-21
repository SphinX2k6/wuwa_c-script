using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A84 RID: 2692
	[NetMessage(EMessageId.MotorParkourLevelRewardRequest)]
	public sealed class MotorParkourLevelRewardRequest : IMessage<MotorParkourLevelRewardRequest>, IMessage, IEquatable<MotorParkourLevelRewardRequest>, IDeepCloneable<MotorParkourLevelRewardRequest>, IBufferMessage
	{
		// Token: 0x0600EACE RID: 60110 RVA: 0x00224F0F File Offset: 0x0022310F
		[NullableContext(1)]
		public static MotorParkourLevelRewardRequest Create()
		{
			return new MotorParkourLevelRewardRequest();
		}

		// Token: 0x17002FA9 RID: 12201
		// (get) Token: 0x0600EACF RID: 60111 RVA: 0x00224F16 File Offset: 0x00223116
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002FAA RID: 12202
		// (get) Token: 0x0600EAD0 RID: 60112 RVA: 0x00224F19 File Offset: 0x00223119
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorParkourLevelRewardRequest.Descriptor;
			}
		}

		// Token: 0x0600EAD1 RID: 60113 RVA: 0x00224F20 File Offset: 0x00223120
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorParkourLevelRewardRequest()
		{
		}

		// Token: 0x0600EAD2 RID: 60114 RVA: 0x00224F33 File Offset: 0x00223133
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorParkourLevelRewardRequest(MotorParkourLevelRewardRequest other) : this()
		{
			this.motorParkourId_ = other.motorParkourId_;
			this.rewardIdxs_ = other.rewardIdxs_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600EAD3 RID: 60115 RVA: 0x00224F69 File Offset: 0x00223169
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorParkourLevelRewardRequest Clone()
		{
			return new MotorParkourLevelRewardRequest(this);
		}

		// Token: 0x17002FAB RID: 12203
		// (get) Token: 0x0600EAD4 RID: 60116 RVA: 0x00224F71 File Offset: 0x00223171
		// (set) Token: 0x0600EAD5 RID: 60117 RVA: 0x00224F79 File Offset: 0x00223179
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

		// Token: 0x17002FAC RID: 12204
		// (get) Token: 0x0600EAD6 RID: 60118 RVA: 0x00224F82 File Offset: 0x00223182
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> RewardIdxs
		{
			get
			{
				return this.rewardIdxs_;
			}
		}

		// Token: 0x0600EAD7 RID: 60119 RVA: 0x00224F8A File Offset: 0x0022318A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorParkourLevelRewardRequest);
		}

		// Token: 0x0600EAD8 RID: 60120 RVA: 0x00224F98 File Offset: 0x00223198
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorParkourLevelRewardRequest other)
		{
			return other != null && (other == this || (this.MotorParkourId == other.MotorParkourId && this.rewardIdxs_.Equals(other.rewardIdxs_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600EAD9 RID: 60121 RVA: 0x00224FE8 File Offset: 0x002231E8
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

		// Token: 0x0600EADA RID: 60122 RVA: 0x00225035 File Offset: 0x00223235
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600EADB RID: 60123 RVA: 0x00225042 File Offset: 0x00223242
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600EADC RID: 60124 RVA: 0x0022504C File Offset: 0x0022324C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.MotorParkourId != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.MotorParkourId);
			}
			this.rewardIdxs_.WriteTo(ref output, MotorParkourLevelRewardRequest._repeated_rewardIdxs_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600EADD RID: 60125 RVA: 0x0022509C File Offset: 0x0022329C
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

		// Token: 0x0600EADE RID: 60126 RVA: 0x002250F0 File Offset: 0x002232F0
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

		// Token: 0x0600EADF RID: 60127 RVA: 0x0022513D File Offset: 0x0022333D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600EAE0 RID: 60128 RVA: 0x00225148 File Offset: 0x00223348
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
				if (num != 48U)
				{
					if (num != 56U && num != 58U)
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

		// Token: 0x04005FBB RID: 24507
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005FBC RID: 24508
		public const int MotorParkourIdFieldNumber = 6;

		// Token: 0x04005FBD RID: 24509
		private int motorParkourId_;

		// Token: 0x04005FBE RID: 24510
		public const int RewardIdxsFieldNumber = 7;

		// Token: 0x04005FBF RID: 24511
		private static readonly FieldCodec<int> _repeated_rewardIdxs_codec = FieldCodec.ForInt32(58U);

		// Token: 0x04005FC0 RID: 24512
		private readonly RepeatedField<int> rewardIdxs_ = new RepeatedField<int>();
	}
}
