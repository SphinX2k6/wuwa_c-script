using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A5F RID: 2655
	public sealed class MotorFightWaveGroupPb : IMessage<MotorFightWaveGroupPb>, IMessage, IEquatable<MotorFightWaveGroupPb>, IDeepCloneable<MotorFightWaveGroupPb>, IBufferMessage
	{
		// Token: 0x0600E7E4 RID: 59364 RVA: 0x0021E4C1 File Offset: 0x0021C6C1
		[NullableContext(1)]
		public static MotorFightWaveGroupPb Create()
		{
			return new MotorFightWaveGroupPb();
		}

		// Token: 0x17002F09 RID: 12041
		// (get) Token: 0x0600E7E5 RID: 59365 RVA: 0x0021E4C8 File Offset: 0x0021C6C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MotorFightWaveGroupPb> Parser
		{
			get
			{
				return MotorFightWaveGroupPb._parser;
			}
		}

		// Token: 0x17002F0A RID: 12042
		// (get) Token: 0x0600E7E6 RID: 59366 RVA: 0x0021E4CF File Offset: 0x0021C6CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002F0B RID: 12043
		// (get) Token: 0x0600E7E7 RID: 59367 RVA: 0x0021E4D2 File Offset: 0x0021C6D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorFightWaveGroupPb.Descriptor;
			}
		}

		// Token: 0x0600E7E8 RID: 59368 RVA: 0x0021E4D9 File Offset: 0x0021C6D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightWaveGroupPb()
		{
		}

		// Token: 0x0600E7E9 RID: 59369 RVA: 0x0021E504 File Offset: 0x0021C704
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

		// Token: 0x0600E7EA RID: 59370 RVA: 0x0021E567 File Offset: 0x0021C767
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightWaveGroupPb Clone()
		{
			return new MotorFightWaveGroupPb(this);
		}

		// Token: 0x17002F0C RID: 12044
		// (get) Token: 0x0600E7EB RID: 59371 RVA: 0x0021E56F File Offset: 0x0021C76F
		// (set) Token: 0x0600E7EC RID: 59372 RVA: 0x0021E577 File Offset: 0x0021C777
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

		// Token: 0x17002F0D RID: 12045
		// (get) Token: 0x0600E7ED RID: 59373 RVA: 0x0021E580 File Offset: 0x0021C780
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<MotorFightMonsterPb> Monsters
		{
			get
			{
				return this.monsters_;
			}
		}

		// Token: 0x17002F0E RID: 12046
		// (get) Token: 0x0600E7EE RID: 59374 RVA: 0x0021E588 File Offset: 0x0021C788
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<MotorFightBossPb> Bosses
		{
			get
			{
				return this.bosses_;
			}
		}

		// Token: 0x17002F0F RID: 12047
		// (get) Token: 0x0600E7EF RID: 59375 RVA: 0x0021E590 File Offset: 0x0021C790
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<MotorFightBuffGatePb> BuffGates
		{
			get
			{
				return this.buffGates_;
			}
		}

		// Token: 0x0600E7F0 RID: 59376 RVA: 0x0021E598 File Offset: 0x0021C798
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorFightWaveGroupPb);
		}

		// Token: 0x0600E7F1 RID: 59377 RVA: 0x0021E5A8 File Offset: 0x0021C7A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorFightWaveGroupPb other)
		{
			return other != null && (other == this || (this.WaveGroupId == other.WaveGroupId && this.monsters_.Equals(other.monsters_) && this.bosses_.Equals(other.bosses_) && this.buffGates_.Equals(other.buffGates_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E7F2 RID: 59378 RVA: 0x0021E620 File Offset: 0x0021C820
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

		// Token: 0x0600E7F3 RID: 59379 RVA: 0x0021E689 File Offset: 0x0021C889
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600E7F4 RID: 59380 RVA: 0x0021E696 File Offset: 0x0021C896
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E7F5 RID: 59381 RVA: 0x0021E6A0 File Offset: 0x0021C8A0
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

		// Token: 0x0600E7F6 RID: 59382 RVA: 0x0021E710 File Offset: 0x0021C910
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

		// Token: 0x0600E7F7 RID: 59383 RVA: 0x0021E788 File Offset: 0x0021C988
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

		// Token: 0x0600E7F8 RID: 59384 RVA: 0x0021E7F7 File Offset: 0x0021C9F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E7F9 RID: 59385 RVA: 0x0021E800 File Offset: 0x0021CA00
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

		// Token: 0x04005ED4 RID: 24276
		private static readonly MessageParser<MotorFightWaveGroupPb> _parser = new MessageParser<MotorFightWaveGroupPb>(() => new MotorFightWaveGroupPb());

		// Token: 0x04005ED5 RID: 24277
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005ED6 RID: 24278
		public const int WaveGroupIdFieldNumber = 1;

		// Token: 0x04005ED7 RID: 24279
		private int waveGroupId_;

		// Token: 0x04005ED8 RID: 24280
		public const int MonstersFieldNumber = 2;

		// Token: 0x04005ED9 RID: 24281
		private static readonly FieldCodec<MotorFightMonsterPb> _repeated_monsters_codec = FieldCodec.ForMessage<MotorFightMonsterPb>(18U, MotorFightMonsterPb.Parser);

		// Token: 0x04005EDA RID: 24282
		private readonly RepeatedField<MotorFightMonsterPb> monsters_ = new RepeatedField<MotorFightMonsterPb>();

		// Token: 0x04005EDB RID: 24283
		public const int BossesFieldNumber = 3;

		// Token: 0x04005EDC RID: 24284
		private static readonly FieldCodec<MotorFightBossPb> _repeated_bosses_codec = FieldCodec.ForMessage<MotorFightBossPb>(26U, MotorFightBossPb.Parser);

		// Token: 0x04005EDD RID: 24285
		private readonly RepeatedField<MotorFightBossPb> bosses_ = new RepeatedField<MotorFightBossPb>();

		// Token: 0x04005EDE RID: 24286
		public const int BuffGatesFieldNumber = 4;

		// Token: 0x04005EDF RID: 24287
		private static readonly FieldCodec<MotorFightBuffGatePb> _repeated_buffGates_codec = FieldCodec.ForMessage<MotorFightBuffGatePb>(34U, MotorFightBuffGatePb.Parser);

		// Token: 0x04005EE0 RID: 24288
		private readonly RepeatedField<MotorFightBuffGatePb> buffGates_ = new RepeatedField<MotorFightBuffGatePb>();
	}
}
