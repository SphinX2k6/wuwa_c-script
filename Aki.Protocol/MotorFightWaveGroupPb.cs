using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A70 RID: 2672
	public sealed class MotorFightWaveGroupPb : IMessage<MotorFightWaveGroupPb>, IMessage, IEquatable<MotorFightWaveGroupPb>, IDeepCloneable<MotorFightWaveGroupPb>, IBufferMessage
	{
		// Token: 0x0600E8FE RID: 59646 RVA: 0x002206B5 File Offset: 0x0021E8B5
		[NullableContext(1)]
		public static MotorFightWaveGroupPb Create()
		{
			return new MotorFightWaveGroupPb();
		}

		// Token: 0x17002F47 RID: 12103
		// (get) Token: 0x0600E8FF RID: 59647 RVA: 0x002206BC File Offset: 0x0021E8BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MotorFightWaveGroupPb> Parser
		{
			get
			{
				return MotorFightWaveGroupPb._parser;
			}
		}

		// Token: 0x17002F48 RID: 12104
		// (get) Token: 0x0600E900 RID: 59648 RVA: 0x002206C3 File Offset: 0x0021E8C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002F49 RID: 12105
		// (get) Token: 0x0600E901 RID: 59649 RVA: 0x002206C6 File Offset: 0x0021E8C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorFightWaveGroupPb.Descriptor;
			}
		}

		// Token: 0x0600E902 RID: 59650 RVA: 0x002206CD File Offset: 0x0021E8CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightWaveGroupPb()
		{
		}

		// Token: 0x0600E903 RID: 59651 RVA: 0x002206F8 File Offset: 0x0021E8F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightWaveGroupPb(MotorFightWaveGroupPb other) : this()
		{
			this.waveGroupId_ = other.waveGroupId_;
			this.monsters_ = other.monsters_.Clone();
			this.bosses_ = other.bosses_.Clone();
			this.buffGates_ = other.buffGates_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E904 RID: 59652 RVA: 0x0022075B File Offset: 0x0021E95B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightWaveGroupPb Clone()
		{
			return new MotorFightWaveGroupPb(this);
		}

		// Token: 0x17002F4A RID: 12106
		// (get) Token: 0x0600E905 RID: 59653 RVA: 0x00220763 File Offset: 0x0021E963
		// (set) Token: 0x0600E906 RID: 59654 RVA: 0x0022076B File Offset: 0x0021E96B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int WaveGroupId
		{
			get
			{
				return this.waveGroupId_;
			}
			set
			{
				this.waveGroupId_ = value;
			}
		}

		// Token: 0x17002F4B RID: 12107
		// (get) Token: 0x0600E907 RID: 59655 RVA: 0x00220774 File Offset: 0x0021E974
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<MotorFightMonsterPb> Monsters
		{
			get
			{
				return this.monsters_;
			}
		}

		// Token: 0x17002F4C RID: 12108
		// (get) Token: 0x0600E908 RID: 59656 RVA: 0x0022077C File Offset: 0x0021E97C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<MotorFightBossPb> Bosses
		{
			get
			{
				return this.bosses_;
			}
		}

		// Token: 0x17002F4D RID: 12109
		// (get) Token: 0x0600E909 RID: 59657 RVA: 0x00220784 File Offset: 0x0021E984
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<MotorFightBuffGatePb> BuffGates
		{
			get
			{
				return this.buffGates_;
			}
		}

		// Token: 0x0600E90A RID: 59658 RVA: 0x0022078C File Offset: 0x0021E98C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorFightWaveGroupPb);
		}

		// Token: 0x0600E90B RID: 59659 RVA: 0x0022079C File Offset: 0x0021E99C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorFightWaveGroupPb other)
		{
			return other != null && (other == this || (this.WaveGroupId == other.WaveGroupId && this.monsters_.Equals(other.monsters_) && this.bosses_.Equals(other.bosses_) && this.buffGates_.Equals(other.buffGates_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E90C RID: 59660 RVA: 0x00220814 File Offset: 0x0021EA14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.WaveGroupId != 0)
			{
				num ^= this.WaveGroupId.GetHashCode();
			}
			num ^= this.monsters_.GetHashCode();
			num ^= this.bosses_.GetHashCode();
			num ^= this.buffGates_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600E90D RID: 59661 RVA: 0x0022087D File Offset: 0x0021EA7D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600E90E RID: 59662 RVA: 0x0022088A File Offset: 0x0021EA8A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E90F RID: 59663 RVA: 0x00220894 File Offset: 0x0021EA94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.WaveGroupId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.WaveGroupId);
			}
			this.monsters_.WriteTo(ref output, MotorFightWaveGroupPb._repeated_monsters_codec);
			this.bosses_.WriteTo(ref output, MotorFightWaveGroupPb._repeated_bosses_codec);
			this.buffGates_.WriteTo(ref output, MotorFightWaveGroupPb._repeated_buffGates_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600E910 RID: 59664 RVA: 0x00220904 File Offset: 0x0021EB04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.WaveGroupId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.WaveGroupId);
			}
			num += this.monsters_.CalculateSize(MotorFightWaveGroupPb._repeated_monsters_codec);
			num += this.bosses_.CalculateSize(MotorFightWaveGroupPb._repeated_bosses_codec);
			num += this.buffGates_.CalculateSize(MotorFightWaveGroupPb._repeated_buffGates_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600E911 RID: 59665 RVA: 0x0022097C File Offset: 0x0021EB7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MotorFightWaveGroupPb other)
		{
			if (other == null)
			{
				return;
			}
			if (other.WaveGroupId != 0)
			{
				this.WaveGroupId = other.WaveGroupId;
			}
			this.monsters_.Add(other.monsters_);
			this.bosses_.Add(other.bosses_);
			this.buffGates_.Add(other.buffGates_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600E912 RID: 59666 RVA: 0x002209EB File Offset: 0x0021EBEB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E913 RID: 59667 RVA: 0x002209F4 File Offset: 0x0021EBF4
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
				if (num <= 18U)
				{
					if (num == 8U)
					{
						this.WaveGroupId = input.ReadInt32();
						continue;
					}
					if (num == 18U)
					{
						this.monsters_.AddEntriesFrom(ref input, MotorFightWaveGroupPb._repeated_monsters_codec);
						continue;
					}
				}
				else
				{
					if (num == 26U)
					{
						this.bosses_.AddEntriesFrom(ref input, MotorFightWaveGroupPb._repeated_bosses_codec);
						continue;
					}
					if (num == 34U)
					{
						this.buffGates_.AddEntriesFrom(ref input, MotorFightWaveGroupPb._repeated_buffGates_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04005ECB RID: 24267
		private static readonly MessageParser<MotorFightWaveGroupPb> _parser = new MessageParser<MotorFightWaveGroupPb>(() => new MotorFightWaveGroupPb());

		// Token: 0x04005ECC RID: 24268
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005ECD RID: 24269
		public const int WaveGroupIdFieldNumber = 1;

		// Token: 0x04005ECE RID: 24270
		private int waveGroupId_;

		// Token: 0x04005ECF RID: 24271
		public const int MonstersFieldNumber = 2;

		// Token: 0x04005ED0 RID: 24272
		private static readonly FieldCodec<MotorFightMonsterPb> _repeated_monsters_codec = FieldCodec.ForMessage<MotorFightMonsterPb>(18U, MotorFightMonsterPb.Parser);

		// Token: 0x04005ED1 RID: 24273
		private readonly RepeatedField<MotorFightMonsterPb> monsters_ = new RepeatedField<MotorFightMonsterPb>();

		// Token: 0x04005ED2 RID: 24274
		public const int BossesFieldNumber = 3;

		// Token: 0x04005ED3 RID: 24275
		private static readonly FieldCodec<MotorFightBossPb> _repeated_bosses_codec = FieldCodec.ForMessage<MotorFightBossPb>(26U, MotorFightBossPb.Parser);

		// Token: 0x04005ED4 RID: 24276
		private readonly RepeatedField<MotorFightBossPb> bosses_ = new RepeatedField<MotorFightBossPb>();

		// Token: 0x04005ED5 RID: 24277
		public const int BuffGatesFieldNumber = 4;

		// Token: 0x04005ED6 RID: 24278
		private static readonly FieldCodec<MotorFightBuffGatePb> _repeated_buffGates_codec = FieldCodec.ForMessage<MotorFightBuffGatePb>(34U, MotorFightBuffGatePb.Parser);

		// Token: 0x04005ED7 RID: 24279
		private readonly RepeatedField<MotorFightBuffGatePb> buffGates_ = new RepeatedField<MotorFightBuffGatePb>();
	}
}
