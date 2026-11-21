using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A53 RID: 2643
	[NetMessage(EMessageId.MotorFightSelectBuffGateRequest)]
	public sealed class MotorFightSelectBuffGateRequest : IMessage<MotorFightSelectBuffGateRequest>, IMessage, IEquatable<MotorFightSelectBuffGateRequest>, IDeepCloneable<MotorFightSelectBuffGateRequest>, IBufferMessage
	{
		// Token: 0x0600E6F6 RID: 59126 RVA: 0x0021C6E9 File Offset: 0x0021A8E9
		[NullableContext(1)]
		public static MotorFightSelectBuffGateRequest Create()
		{
			return new MotorFightSelectBuffGateRequest();
		}

		// Token: 0x17002EDA RID: 11994
		// (get) Token: 0x0600E6F7 RID: 59127 RVA: 0x0021C6F0 File Offset: 0x0021A8F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002EDB RID: 11995
		// (get) Token: 0x0600E6F8 RID: 59128 RVA: 0x0021C6F3 File Offset: 0x0021A8F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorFightSelectBuffGateRequest.Descriptor;
			}
		}

		// Token: 0x0600E6F9 RID: 59129 RVA: 0x0021C6FA File Offset: 0x0021A8FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightSelectBuffGateRequest()
		{
		}

		// Token: 0x0600E6FA RID: 59130 RVA: 0x0021C710 File Offset: 0x0021A910
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightSelectBuffGateRequest(MotorFightSelectBuffGateRequest other) : this()
		{
			this.subLevelIndex_ = other.subLevelIndex_;
			this.waveGroupIndex_ = other.waveGroupIndex_;
			this.buffGateId_ = other.buffGateId_;
			this.buffIds_ = other.buffIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E6FB RID: 59131 RVA: 0x0021C769 File Offset: 0x0021A969
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightSelectBuffGateRequest Clone()
		{
			return new MotorFightSelectBuffGateRequest(this);
		}

		// Token: 0x17002EDC RID: 11996
		// (get) Token: 0x0600E6FC RID: 59132 RVA: 0x0021C771 File Offset: 0x0021A971
		// (set) Token: 0x0600E6FD RID: 59133 RVA: 0x0021C779 File Offset: 0x0021A979
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SubLevelIndex
		{
			get
			{
				return this.subLevelIndex_;
			}
			set
			{
				this.subLevelIndex_ = value;
			}
		}

		// Token: 0x17002EDD RID: 11997
		// (get) Token: 0x0600E6FE RID: 59134 RVA: 0x0021C782 File Offset: 0x0021A982
		// (set) Token: 0x0600E6FF RID: 59135 RVA: 0x0021C78A File Offset: 0x0021A98A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int WaveGroupIndex
		{
			get
			{
				return this.waveGroupIndex_;
			}
			set
			{
				this.waveGroupIndex_ = value;
			}
		}

		// Token: 0x17002EDE RID: 11998
		// (get) Token: 0x0600E700 RID: 59136 RVA: 0x0021C793 File Offset: 0x0021A993
		// (set) Token: 0x0600E701 RID: 59137 RVA: 0x0021C79B File Offset: 0x0021A99B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int BuffGateId
		{
			get
			{
				return this.buffGateId_;
			}
			set
			{
				this.buffGateId_ = value;
			}
		}

		// Token: 0x17002EDF RID: 11999
		// (get) Token: 0x0600E702 RID: 59138 RVA: 0x0021C7A4 File Offset: 0x0021A9A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> BuffIds
		{
			get
			{
				return this.buffIds_;
			}
		}

		// Token: 0x0600E703 RID: 59139 RVA: 0x0021C7AC File Offset: 0x0021A9AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorFightSelectBuffGateRequest);
		}

		// Token: 0x0600E704 RID: 59140 RVA: 0x0021C7BC File Offset: 0x0021A9BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorFightSelectBuffGateRequest other)
		{
			return other != null && (other == this || (this.SubLevelIndex == other.SubLevelIndex && this.WaveGroupIndex == other.WaveGroupIndex && this.BuffGateId == other.BuffGateId && this.buffIds_.Equals(other.buffIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E705 RID: 59141 RVA: 0x0021C82C File Offset: 0x0021AA2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.SubLevelIndex != 0)
			{
				num ^= this.SubLevelIndex.GetHashCode();
			}
			if (this.WaveGroupIndex != 0)
			{
				num ^= this.WaveGroupIndex.GetHashCode();
			}
			if (this.BuffGateId != 0)
			{
				num ^= this.BuffGateId.GetHashCode();
			}
			num ^= this.buffIds_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600E706 RID: 59142 RVA: 0x0021C8AB File Offset: 0x0021AAAB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600E707 RID: 59143 RVA: 0x0021C8B8 File Offset: 0x0021AAB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E708 RID: 59144 RVA: 0x0021C8C4 File Offset: 0x0021AAC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.WaveGroupIndex != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.WaveGroupIndex);
			}
			if (this.BuffGateId != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.BuffGateId);
			}
			if (this.SubLevelIndex != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.SubLevelIndex);
			}
			this.buffIds_.WriteTo(ref output, MotorFightSelectBuffGateRequest._repeated_buffIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600E709 RID: 59145 RVA: 0x0021C94C File Offset: 0x0021AB4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.SubLevelIndex != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SubLevelIndex);
			}
			if (this.WaveGroupIndex != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.WaveGroupIndex);
			}
			if (this.BuffGateId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.BuffGateId);
			}
			num += this.buffIds_.CalculateSize(MotorFightSelectBuffGateRequest._repeated_buffIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600E70A RID: 59146 RVA: 0x0021C9D0 File Offset: 0x0021ABD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MotorFightSelectBuffGateRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.SubLevelIndex != 0)
			{
				this.SubLevelIndex = other.SubLevelIndex;
			}
			if (other.WaveGroupIndex != 0)
			{
				this.WaveGroupIndex = other.WaveGroupIndex;
			}
			if (other.BuffGateId != 0)
			{
				this.BuffGateId = other.BuffGateId;
			}
			this.buffIds_.Add(other.buffIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600E70B RID: 59147 RVA: 0x0021CA45 File Offset: 0x0021AC45
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E70C RID: 59148 RVA: 0x0021CA50 File Offset: 0x0021AC50
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
				if (num <= 48U)
				{
					if (num == 32U)
					{
						this.WaveGroupIndex = input.ReadInt32();
						continue;
					}
					if (num == 48U)
					{
						this.BuffGateId = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 56U)
					{
						this.SubLevelIndex = input.ReadInt32();
						continue;
					}
					if (num == 112U || num == 114U)
					{
						this.buffIds_.AddEntriesFrom(ref input, MotorFightSelectBuffGateRequest._repeated_buffIds_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04005E97 RID: 24215
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005E98 RID: 24216
		public const int SubLevelIndexFieldNumber = 7;

		// Token: 0x04005E99 RID: 24217
		private int subLevelIndex_;

		// Token: 0x04005E9A RID: 24218
		public const int WaveGroupIndexFieldNumber = 4;

		// Token: 0x04005E9B RID: 24219
		private int waveGroupIndex_;

		// Token: 0x04005E9C RID: 24220
		public const int BuffGateIdFieldNumber = 6;

		// Token: 0x04005E9D RID: 24221
		private int buffGateId_;

		// Token: 0x04005E9E RID: 24222
		public const int BuffIdsFieldNumber = 14;

		// Token: 0x04005E9F RID: 24223
		private static readonly FieldCodec<int> _repeated_buffIds_codec = FieldCodec.ForInt32(114U);

		// Token: 0x04005EA0 RID: 24224
		private readonly RepeatedField<int> buffIds_ = new RepeatedField<int>();
	}
}
