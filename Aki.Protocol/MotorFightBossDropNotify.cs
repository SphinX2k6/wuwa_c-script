using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A39 RID: 2617
	[NetMessage(EMessageId.MotorFightBossDropNotify)]
	public sealed class MotorFightBossDropNotify : IMessage<MotorFightBossDropNotify>, IMessage, IEquatable<MotorFightBossDropNotify>, IDeepCloneable<MotorFightBossDropNotify>, IBufferMessage
	{
		// Token: 0x0600E481 RID: 58497 RVA: 0x00216A71 File Offset: 0x00214C71
		[NullableContext(1)]
		public static MotorFightBossDropNotify Create()
		{
			return new MotorFightBossDropNotify();
		}

		// Token: 0x17002E51 RID: 11857
		// (get) Token: 0x0600E482 RID: 58498 RVA: 0x00216A78 File Offset: 0x00214C78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002E52 RID: 11858
		// (get) Token: 0x0600E483 RID: 58499 RVA: 0x00216A7B File Offset: 0x00214C7B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorFightBossDropNotify.Descriptor;
			}
		}

		// Token: 0x0600E484 RID: 58500 RVA: 0x00216A82 File Offset: 0x00214C82
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightBossDropNotify()
		{
		}

		// Token: 0x0600E485 RID: 58501 RVA: 0x00216A98 File Offset: 0x00214C98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightBossDropNotify(MotorFightBossDropNotify other) : this()
		{
			this.subLevelIndex_ = other.subLevelIndex_;
			this.waveGroupIndex_ = other.waveGroupIndex_;
			this.bossId_ = other.bossId_;
			this.drops_ = other.drops_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E486 RID: 58502 RVA: 0x00216AF1 File Offset: 0x00214CF1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightBossDropNotify Clone()
		{
			return new MotorFightBossDropNotify(this);
		}

		// Token: 0x17002E53 RID: 11859
		// (get) Token: 0x0600E487 RID: 58503 RVA: 0x00216AF9 File Offset: 0x00214CF9
		// (set) Token: 0x0600E488 RID: 58504 RVA: 0x00216B01 File Offset: 0x00214D01
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

		// Token: 0x17002E54 RID: 11860
		// (get) Token: 0x0600E489 RID: 58505 RVA: 0x00216B0A File Offset: 0x00214D0A
		// (set) Token: 0x0600E48A RID: 58506 RVA: 0x00216B12 File Offset: 0x00214D12
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

		// Token: 0x17002E55 RID: 11861
		// (get) Token: 0x0600E48B RID: 58507 RVA: 0x00216B1B File Offset: 0x00214D1B
		// (set) Token: 0x0600E48C RID: 58508 RVA: 0x00216B23 File Offset: 0x00214D23
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int BossId
		{
			get
			{
				return this.bossId_;
			}
			set
			{
				this.bossId_ = value;
			}
		}

		// Token: 0x17002E56 RID: 11862
		// (get) Token: 0x0600E48D RID: 58509 RVA: 0x00216B2C File Offset: 0x00214D2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<MotorFightCollectionDrop> Drops
		{
			get
			{
				return this.drops_;
			}
		}

		// Token: 0x0600E48E RID: 58510 RVA: 0x00216B34 File Offset: 0x00214D34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorFightBossDropNotify);
		}

		// Token: 0x0600E48F RID: 58511 RVA: 0x00216B44 File Offset: 0x00214D44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorFightBossDropNotify other)
		{
			return other != null && (other == this || (this.SubLevelIndex == other.SubLevelIndex && this.WaveGroupIndex == other.WaveGroupIndex && this.BossId == other.BossId && this.drops_.Equals(other.drops_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E490 RID: 58512 RVA: 0x00216BB4 File Offset: 0x00214DB4
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
			if (this.BossId != 0)
			{
				num ^= this.BossId.GetHashCode();
			}
			num ^= this.drops_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600E491 RID: 58513 RVA: 0x00216C33 File Offset: 0x00214E33
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600E492 RID: 58514 RVA: 0x00216C40 File Offset: 0x00214E40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E493 RID: 58515 RVA: 0x00216C4C File Offset: 0x00214E4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SubLevelIndex != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.SubLevelIndex);
			}
			this.drops_.WriteTo(ref output, MotorFightBossDropNotify._repeated_drops_codec);
			if (this.WaveGroupIndex != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.WaveGroupIndex);
			}
			if (this.BossId != 0)
			{
				output.WriteRawTag(120);
				output.WriteInt32(this.BossId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600E494 RID: 58516 RVA: 0x00216CD4 File Offset: 0x00214ED4
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
			if (this.BossId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.BossId);
			}
			num += this.drops_.CalculateSize(MotorFightBossDropNotify._repeated_drops_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600E495 RID: 58517 RVA: 0x00216D58 File Offset: 0x00214F58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MotorFightBossDropNotify other)
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
			if (other.BossId != 0)
			{
				this.BossId = other.BossId;
			}
			this.drops_.Add(other.drops_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600E496 RID: 58518 RVA: 0x00216DCD File Offset: 0x00214FCD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E497 RID: 58519 RVA: 0x00216DD8 File Offset: 0x00214FD8
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
				if (num <= 66U)
				{
					if (num == 8U)
					{
						this.SubLevelIndex = input.ReadInt32();
						continue;
					}
					if (num == 66U)
					{
						this.drops_.AddEntriesFrom(ref input, MotorFightBossDropNotify._repeated_drops_codec);
						continue;
					}
				}
				else
				{
					if (num == 96U)
					{
						this.WaveGroupIndex = input.ReadInt32();
						continue;
					}
					if (num == 120U)
					{
						this.BossId = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04005D7C RID: 23932
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005D7D RID: 23933
		public const int SubLevelIndexFieldNumber = 1;

		// Token: 0x04005D7E RID: 23934
		private int subLevelIndex_;

		// Token: 0x04005D7F RID: 23935
		public const int WaveGroupIndexFieldNumber = 12;

		// Token: 0x04005D80 RID: 23936
		private int waveGroupIndex_;

		// Token: 0x04005D81 RID: 23937
		public const int BossIdFieldNumber = 15;

		// Token: 0x04005D82 RID: 23938
		private int bossId_;

		// Token: 0x04005D83 RID: 23939
		public const int DropsFieldNumber = 8;

		// Token: 0x04005D84 RID: 23940
		private static readonly FieldCodec<MotorFightCollectionDrop> _repeated_drops_codec = FieldCodec.ForMessage<MotorFightCollectionDrop>(66U, MotorFightCollectionDrop.Parser);

		// Token: 0x04005D85 RID: 23941
		private readonly RepeatedField<MotorFightCollectionDrop> drops_ = new RepeatedField<MotorFightCollectionDrop>();
	}
}
